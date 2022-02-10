Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.Rutime.HojaCalculo
'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.WayBill
'Imports Ransa.DAO.Cliente
Imports Ransa.DAO.WayBill
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports System.ComponentModel

''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class ucWaybill_DgF01

#Region " Tipo de Datos "

#End Region


#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event ClickImagen(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Add_Bulto()
    Public Event Edit_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Delete_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event RePacking_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Bulto_Detalle(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Bulto_Mineria(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Paleta(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_SecuenciaBulto()
    Public Event AdjuntarDocumnto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Interfase_Bulto()
    Public Event Export(ByRef oSentido As TD_Qry_ExportInf_F01.Sentido, ByRef Formato As TD_Qry_ExportInf_F01.Formato, ByRef bUpdateInf As Boolean)
    ''' <summary>
    ''' Exportar Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Event ExportExcel()
    Public Event ExportInventarioExcel()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Bulto As TD_Sel_Bulto_L01)
    'Imprimir Material Receiving Report
    Public Event ImprimirMaterialReport(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event TrasladoOC(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event InterfaceBulto()
    Public Event InterfaceFecha()
    Public Event Enviar_Email(ByVal Bulto As TD_Sel_Bulto_L01)

    Public Event EnviarConfirmacion(ByVal lstBultosEnviados As List(Of String), ByVal lstBultosSeleccionados As List(Of TD_Sel_Bulto_L01))
    Public Event AnularConfirmacion(ByVal oTempBulto As TD_BultoPK, ByRef blnCancelar As Boolean)


    Public Event ActualizarFiltrosIniciales()

#End Region
#Region "Const"
    Private Const respExitosaSW As String = "S"
    Private Const errorComunicacionMilpo As String = "F"
    Private Const respErrorSW As String = "E"
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private oWayBill As cWayBill = New Ransa.DAO.WayBill.cWayBill
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_Filtro As TD_Qry_Bulto_L01 = New Ransa.TYPEDEF.WayBill.TD_Qry_Bulto_L01
    Private TD_BultoActual As TD_Sel_Bulto_L01 = New Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01
    Private oQry_ExportInf_F01 As TD_Qry_ExportInf_F01 = New Ransa.TYPEDEF.WayBill.TD_Qry_ExportInf_F01
    Private lstTD_Bultos As List(Of TD_Sel_Bulto_L01) = New List(Of Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01)
    Private intFilaActual As Int32 = 0
    Private intNroTotalPaginas As Int32 = 0

    Private oDlgPreDespacho As ucWaybill_PreDespacho
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnShowCheckColumn As Boolean = True
    Private blnMostrarInfCliente As Boolean = True
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
    Private _NameForm As String = ""
    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWaybill_DgF01))
#End Region

#Region " Propiedades "
    Public Property pMostrarInfCliente() As Boolean
        Get
            Return blnMostrarInfCliente
        End Get
        Set(ByVal value As Boolean)
            blnMostrarInfCliente = value
        End Set
    End Property

    Public Property NroRegPorPagina() As Int32
        Get
            Return TD_Filtro.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            TD_Filtro.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pCCLNT_CodigoCliente() As Int64
        Get
            Return TD_Filtro.pCCLNT_CodigoCliente
        End Get
        Set(ByVal value As Int64)
            If TD_Filtro.pCCLNT_CodigoCliente <> value Then pLimpiarContenido()
            TD_Filtro.pCCLNT_CodigoCliente = value
        End Set
    End Property

    Public ReadOnly Property pBultoSeleccionado() As TD_Sel_Bulto_L01
        Get
            Return TD_BultoActual
        End Get
    End Property

    Public ReadOnly Property pBultosSeleccionados() As List(Of TD_Sel_Bulto_L01)
        Get
            Return lstTD_Bultos
        End Get
    End Property

    Public Property pShowBtnAgregar() As Boolean
        Get
            Return btnAgregar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnAgregar.Visible = value
        End Set
    End Property

    Public Property pShowBtnEditar() As Boolean
        Get
            Return btnEditar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnEditar.Visible = value
        End Set
    End Property

    Public Property pShowBtnEliminar() As Boolean
        Get
            Return btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnEliminar.Visible = value
        End Set
    End Property

    Public Property pShowBtnEtiqueta() As Boolean
        Get
            Return btnEtiqueta.Visible
        End Get
        Set(ByVal value As Boolean)
            btnEtiqueta.Visible = value
        End Set
    End Property

    Public Property pShowBtnExportar() As Boolean
        Get
            Return btnExportar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnExportar.Visible = value
        End Set
    End Property

    Public Property pShowBtnInterfase() As Boolean
        Get
            Return btnInterfase.Visible
        End Get
        Set(ByVal value As Boolean)
            btnInterfase.Visible = value
        End Set
    End Property

    Public Property pShowBtnPaletizar() As Boolean
        Get
            Return btnPaletizar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnPaletizar.Visible = value
        End Set
    End Property

    Public Property pShowBtnPreDespacho() As Boolean
        Get
            Return btnPreDespacho.Visible
        End Get
        Set(ByVal value As Boolean)
            btnPreDespacho.Visible = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property pShowBtnAdjuntarDoc() As Boolean
        Get
            Return btnAdjuntarDocumentos.Visible
        End Get
        Set(ByVal value As Boolean)
            btnAdjuntarDocumentos.Visible = value
        End Set
    End Property

    Public Property pShowBtnRePacking() As Boolean
        Get
            Return btnRepacking.Visible
        End Get
        Set(ByVal value As Boolean)
            btnRepacking.Visible = value
        End Set
    End Property

    Public Property pShowColCheck() As Boolean
        Get
            Return blnShowCheckColumn
        End Get
        Set(ByVal value As Boolean)
            blnShowCheckColumn = value
            Me.dgWayBill.Columns("M_CHK").Visible = value
        End Set
    End Property

    Public Property pShowColStatusTransf() As Boolean
        Get
            Return dgWayBill.Columns("M_STRNSM").Visible
        End Get
        Set(ByVal value As Boolean)
            dgWayBill.Columns("M_STRNSM").Visible = value
        End Set
    End Property

    Public Property pShowBtnImprimir() As Boolean
        Get
            Return btnImprimir.Visible
        End Get
        Set(ByVal value As Boolean)
            btnImprimir.Visible = value
        End Set
    End Property

    Public Property pShowBtnExportarExcel() As Boolean
        Get
            Return Me.btnExportarExcel.Visible
        End Get
        Set(ByVal value As Boolean)
            btnExportarExcel.Visible = value
        End Set
    End Property

    Public Property pShowBtnExportarInventarioExcel() As Boolean
        Get
            Return Me.bsbExportarInventario.Visible
        End Get
        Set(ByVal value As Boolean)
            bsbExportarInventario.Visible = value
        End Set
    End Property

    ''' <summary>
    ''' mostraer boton confirmacion
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property pShowBtnEnviarConfirmacion() As Boolean
        Set(ByVal value As Boolean)
            btnEnviarConfirmacion.Visible = value
            dgWayBill.Columns("STRNSM_C").Visible = value
            dgWayBill.Columns("STRNSM_D").Visible = value
        End Set
    End Property


    ''' <summary>
    ''' Habilita el botón de confirmación de llegada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pShowBtnConfirmarLlegada() As Boolean
        Get
            Return btnConfirmarLlegada.Visible
        End Get
        Set(ByVal value As Boolean)
            btnConfirmarLlegada.Visible = value
        End Set
    End Property

    Public Property pShowBtnTraslado() As Boolean
        Get
            Return btnTrasladoOC.Visible
        End Get
        Set(ByVal value As Boolean)
            btnTrasladoOC.Visible = value
        End Set
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
    Public WriteOnly Property pNameForm() As String
        Set(ByVal value As String)
            _NameForm = value
            If (value <> "") Then
                btnTrasladoOC.Visible = ValidarPermisoTrasladoOC()
            End If
        End Set
    End Property


    Private _pVerInfDespacho As Boolean = False
    Public Property pVerInfDespacho() As Boolean
        Get
            Return _pVerInfDespacho
        End Get
        Set(ByVal value As Boolean)
            _pVerInfDespacho = value
        End Set
    End Property


#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            Dim oBrBulto As New brBulto()
            Dim estadoImg As String
            Dim bmpImage As Bitmap = Nothing
            blnCargando = True
            Dim oDtListar_L01 As New DataTable
            'If oBrBulto.ValidarClienteParaConfirmacion(TD_Filtro.pCCLNT_CodigoCliente) Then
            '    btnEnviarConfirmacion.Visible = True
            '    btnEliminar.Visible = True
            'End If
            oDtListar_L01 = oWayBill.fdtListar_L01(TD_Filtro, intNroTotalPaginas)
            'mockup
            'oBrBulto.ValidarClienteParaConfirmacion(TD_Filtro.pCCLNT_CodigoCliente)


            dgWayBill.DataSource = oDtListar_L01

            If dgWayBill.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgWayBill.Rows

                    row.Cells("STRNSM_D").Value = oDtListar_L01.Rows(row.Index).Item("STRNSM_D").ToString()
                    row.Cells("STRNSM_C_EST").Value = oDtListar_L01.Rows(row.Index).Item("STRNSM_C").ToString()

                    estadoImg = oDtListar_L01.Rows(row.Index).Item("STRNSM_C").ToString()
                    Select Case estadoImg
                        Case respExitosaSW
                            bmpImage = Global.Ransa.Controls.WayBill.My.Resources.Resources.verde
                            row.Cells("STRNSM_C").Value = bmpImage

                        Case errorComunicacionMilpo
                            bmpImage = Global.Ransa.Controls.WayBill.My.Resources.Resources.Rojo
                            row.Cells("STRNSM_C").Value = bmpImage

                        Case respErrorSW
                            bmpImage = Global.Ransa.Controls.WayBill.My.Resources.Resources.naranja
                            row.Cells("STRNSM_C").Value = bmpImage
                        Case Else
                            bmpImage = Global.Ransa.Controls.WayBill.My.Resources.Resources.filesave
                            row.Cells("STRNSM_C").Value = bmpImage

                    End Select

                Next
            End If



            blnCargando = False
            If oWayBill.ErrorMessage <> "" Then
                TD_Filtro.pNROPAG_NroPagina = 1
                intNroTotalPaginas = 0
                Call pMostrarDetallePosicion()
                RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
            Else
                If dgWayBill.RowCount > 0 Then
                    If lstTD_Bultos.Count > 0 Then
                        Dim intCont As Int32 = 0
                        Dim objTemp As TD_Sel_Bulto_L01
                        While intCont < dgWayBill.RowCount
                            For Each objTemp In lstTD_Bultos
                                If ("" & dgWayBill.Rows(intCont).Cells("M_CREFFW").Value).ToString.Trim = objTemp.pCREFFW_CodigoBulto Then
                                    dgWayBill.Rows(intCont).Cells("M_CHK").Value = True
                                    Exit For
                                End If
                            Next
                            intCont += 1
                        End While
                    End If
                    TD_BultoActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    TD_BultoActual.pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
                    TD_BultoActual.pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
                    Decimal.TryParse("" & dgWayBill.CurrentRow.Cells("M_QREFFW").Value, TD_BultoActual.pQREFFW_CantidadRecibida)
                    Int64.TryParse("" & dgWayBill.CurrentRow.Cells("M_NSEQIN").Value, TD_BultoActual.pNSEQIN_NrSecuencia)
                    TD_BultoActual.pNMRGIM_NrImagen = Val(dgWayBill.CurrentRow.Cells("M_NMRGIM").Value)
                    intFilaActual = 0

                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
                    TD_BultoActual.pCODMAT_CodigoMaterial = dgWayBill.CurrentRow.Cells("CODMAT").Value.ToString.Trim
                    TD_BultoActual.pDESMAT_DescripcionMaterial = dgWayBill.CurrentRow.Cells("DES_MAT").Value.ToString.Trim
                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

                Else
                    TD_BultoActual.pCCLNT_CodigoCliente = 0
                    TD_BultoActual.pCREFFW_CodigoBulto = ""
                    TD_BultoActual.pQREFFW_CantidadRecibida = 0

                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
                    TD_BultoActual.pCODMAT_CodigoMaterial = ""
                    TD_BultoActual.pDESMAT_DescripcionMaterial = ""
                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.
                    intFilaActual = -1
                End If

                Call pMostrarDetallePosicion()
                RaiseEvent DataLoadCompleted(TD_BultoActual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        lblWaybill.Text = lblWaybill.Tag
        dgWayBill.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_BultoActual.pCCLNT_CodigoCliente = 0
        TD_BultoActual.pCREFFW_CodigoBulto = ""
        TD_BultoActual.pQREFFW_CantidadRecibida = 0
        intFilaActual = -1
        TD_Filtro.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = TD_Filtro.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = TD_Filtro.pREGPAG_NroRegPorPagina
    End Sub

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos las opciones de Gestión
        btnPreDespacho.Enabled = True
        RemoveHandler oDlgPreDespacho.pDisposeForm, AddressOf pDisposeFormServF01
        oDlgPreDespacho.Dispose()
        oDlgPreDespacho = Nothing
        If StatusProceso And Not oWayBill Is Nothing And dgWayBill.RowCount > 0 Then Call pRefrescar()
    End Sub
#End Region
#Region " Eventos "
    Private Sub bgwExportarData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportarData.DoWork
        ' Asignamos los valores considerados en el FILTRO de la consulta
        oQry_ExportInf_F01.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
        oQry_ExportInf_F01.pCREFFW_CodigoBulto = TD_Filtro.pCREFFW_CodigoBulto.Trim
        oQry_ExportInf_F01.pTTINTC_TermInterCarga = TD_Filtro.pTTINTC_TermInterCarga
        oQry_ExportInf_F01.pTUBRFR_Ubicacion = TD_Filtro.pTUBRFR_Ubicacion
        'oQry_ExportInf_F01.pNROPLT_NroPaletizado = TD_Filtro.pNROPLT_NroPaletizado
        'oQry_ExportInf_F01.pCRTLTE_CriterioLote = TD_Filtro.pCRTLTE_CriterioLote
        oQry_ExportInf_F01.pSTPING_TipoMovimiento = TD_Filtro.pSTPING_TipoMovimiento
        oQry_ExportInf_F01.pSTRNSM_StatusTransmisionEnum = TD_Filtro.pSTRNSM_StatusTransmisionEnum
        oQry_ExportInf_F01.pUsuario = TD_Filtro.pUsuario

        ' Realizamos la consulta en Función al Tipo de Operación
        Dim dstTempExp As DataSet = Nothing
        Dim oQProRansa As cQProRansa = New cQProRansa()
        Dim sRutaExportXLS As String = ""
        Try
            If oQry_ExportInf_F01.pOperacion = TD_Qry_ExportInf_F01.Sentido.Recepcion Then
                oQry_ExportInf_F01.pFechaInicial = TD_Filtro.pFREFFW_FechaRecep_Ini
                oQry_ExportInf_F01.pFechaFinal = TD_Filtro.pFREFFW_FechaRecep_Fin
                oQry_ExportInf_F01.PSCCMPN = TD_Filtro.pCCMPN_CodigoCompania
                oQry_ExportInf_F01.PSCDVSN = TD_Filtro.pCDVSN_CodigoDivision
                oQry_ExportInf_F01.PNCPLNDV = TD_Filtro.pCPLNDV_CodigoPlanta
                ' Obtenemos la información de la Consulta
                dstTempExp = oWayBill.fdstExportRecepcion(oQry_ExportInf_F01)
                If dstTempExp.Tables.Count > 0 Then
                    ' Generamos el archivo en el Formato indicado
                    Select Case oQry_ExportInf_F01.pFormatFile
                        Case TD_Qry_ExportInf_F01.Formato.Ellipse
                            ' Formamos la Ruta de Acceso a los Archivos XLS
                            sRutaExportXLS = Application.StartupPath & "\ExportToEllipse\xltRecepcion" & TD_Filtro.pCCLNT_CodigoCliente.ToString & ".xlt"
                            ' Enviamos la Información a la Hoja de Cálculo

                            Select Case TD_Filtro.pCCLNT_CodigoCliente
                                Case 9425
                                    oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 5, dstTempExp.Tables(0))
                                Case 2287
                                    oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 2, dstTempExp.Tables(0))
                            End Select

                        Case TD_Qry_ExportInf_F01.Formato.SAP
                            ' Formamos la Ruta de Acceso a los Archivos XLS
                            sRutaExportXLS = Application.StartupPath & "\ExportToSAP\xltRecepcion" & TD_Filtro.pCCLNT_CodigoCliente.ToString & ".xlt"
                            ' Enviamos la Información a la Hoja de Cálculo
                            oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 2, dstTempExp.Tables(0), 20, 1)
                            'If dstTempExp.Tables.Count >= 2 And dstTempExp.Tables(1).Rows.Count > 0 Then
                            '    oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 5, dstTempExp.Tables(1), 20, 1)
                            'End If
                    End Select
                Else
                    MessageBox.Show("No se obtuvo información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If oQry_ExportInf_F01.pOperacion = TD_Qry_ExportInf_F01.Sentido.Despacho Then
                    oQry_ExportInf_F01.pFechaInicial = TD_Filtro.pFREFFW_FechaRecep_Ini
                    oQry_ExportInf_F01.pFechaFinal = TD_Filtro.pFREFFW_FechaRecep_Fin

                    'TD_Filtro.pFREFFW_FechaRecep_Ini()
                    'oQry_ExportInf_F01.pFechaFinal = TD_Filtro.pFREFFW_FechaRecep_Fin


                    ' Obenemos la información de la Consulta
                    dstTempExp = oWayBill.fdstExportDespacho(oQry_ExportInf_F01)
                    If dstTempExp.Tables.Count > 0 Then
                        ' Generamos el archivo en el Formato indicado
                        Select Case oQry_ExportInf_F01.pFormatFile
                            Case TD_Qry_ExportInf_F01.Formato.Ellipse
                                ' Formamos la Ruta de Acceso a los Archivos XLS
                                sRutaExportXLS = Application.StartupPath & "\ExportToEllipse\xltDespacho" & TD_Filtro.pCCLNT_CodigoCliente.ToString & ".xlt"
                                ' Enviamos la Información a la Hoja de Cálculo
                                oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 5, dstTempExp.Tables(0))
                            Case TD_Qry_ExportInf_F01.Formato.SAP
                                ' Formamos la Ruta de Acceso a los Archivos XLS
                                sRutaExportXLS = Application.StartupPath & "\ExportToSAP\xltDespacho" & TD_Filtro.pCCLNT_CodigoCliente.ToString & ".xlt"
                                oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 2, dstTempExp.Tables(0), 20, 1)
                                'If dstTempExp.Tables.Count >= 2 And dstTempExp.Tables(1).Rows.Count > 0 Then
                                '    oQProRansa.pExportarToXLS(sRutaExportXLS, 1, 5, dstTempExp.Tables(1), 20, 1)
                                'End If
                        End Select
                    Else
                        MessageBox.Show("No se obtuvo información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            RaiseEvent ErrorMessage(ex.Message)
        End Try
        oQProRansa.Dispose()
        oQProRansa = Nothing
        cMemory.ClearMemory()
    End Sub

    Private Sub bgwExportarData_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwExportarData.RunWorkerCompleted
        btnExportar.Enabled = True
        'MessageBox.Show("Exportación Culminó satisfactoriamente.")
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then RaiseEvent Add_Bulto()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
        TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
        TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Edit_Bulto(TD_BultoActual)
    End Sub

    Public Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim blnConfirm As Boolean = False
        RaiseEvent Confirm("Desea eliminar el Bulto.", blnConfirm)
        If blnConfirm Then Exit Sub

        If dgWayBill.RowCount >= 0 Then
            Dim oTempBulto As TD_BultoPK = New TD_BultoPK
            With oTempBulto
                .pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
                .pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
                .pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
                .pCCLNT_CodigoCliente = TD_BultoActual.pCCLNT_CodigoCliente
                .pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto
                .pNSEQIN_NrSecuencia = TD_BultoActual.pNSEQIN_NrSecuencia
            End With
            'Validar anulacion de bulto
            RaiseEvent AnularConfirmacion(oTempBulto, blnConfirm)
            If blnConfirm Then Exit Sub
            If oWayBill.Delete(oTempBulto, strUsuario) Then
                dgWayBill.Rows.Remove(dgWayBill.CurrentRow)
                MessageBox.Show("Proceso culminó satisfactoriamente.", "Eliminar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
            End If
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            Dim oSentido As TD_Qry_ExportInf_F01.Sentido = New TD_Qry_ExportInf_F01.Sentido
            Dim oFormatExport As TD_Qry_ExportInf_F01.Formato = New TD_Qry_ExportInf_F01.Formato
            Dim bInclEnv As Boolean = False
            Dim bUpdateInf As Boolean = False
            RaiseEvent Export(oSentido, oFormatExport, bUpdateInf)
            oQry_ExportInf_F01.pOperacion = oSentido
            oQry_ExportInf_F01.pUpdateInf = bUpdateInf
            oQry_ExportInf_F01.pFormatFile = oFormatExport

            ' Deshabilitamos el Botón
            btnExportar.Enabled = False
            ' Corremos el Proceso Asincrono
            bgwExportarData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnInterfase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterfase.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            RaiseEvent Interfase_Bulto()
        Else
            RaiseEvent ErrorMessage("Debe eligir un Cliente para poder realizar la Transferencia.")
        End If
    End Sub

    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If TD_Filtro.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            TD_Filtro.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If TD_Filtro.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            TD_Filtro.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And TD_Filtro.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            TD_Filtro.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And TD_Filtro.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            TD_Filtro.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Function ValidarUbicacion() As Boolean
        Dim validado As Boolean = True
        Dim numVeces As Int32 = 0
        Dim CodValAnterior As String = ""
        Dim CodValActual As String = ""
        For Each drv As DataGridViewRow In dgWayBill.Rows
            If (drv.Cells("M_CHK").Value = True) Then
                CodValActual = drv.Cells("N_COD_CTPALM").Value.ToString.Trim & drv.Cells("N_COD_CALMC").Value.ToString.Trim & drv.Cells("N_COD_CZNALM").Value.ToString.Trim
                If (numVeces > 0) Then
                    If (CodValActual <> CodValAnterior) Then
                        validado = False
                        Exit For
                    End If
                End If
                CodValAnterior = drv.Cells("N_COD_CTPALM").Value.ToString.Trim & drv.Cells("N_COD_CALMC").Value.ToString.Trim & drv.Cells("N_COD_CZNALM").Value.ToString
                numVeces += 1
            End If
        Next
        Return validado
    End Function


    Private Function VerificarPallet() As Boolean
        Dim validado As Boolean = True
       
        Dim TienePallet As Boolean = False
        For Each drv As DataGridViewRow In dgWayBill.Rows
            If (drv.Cells("M_CHK").Value = True) Then

                If drv.Cells("M_NROPLT").Value > 0 Then
                    TienePallet = True
                    Exit For
                End If
                '
            End If
        Next

        Return TienePallet
    End Function


    Private Sub btnPaletizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaletizar.Click
        Try
            Dim validacionUbicacion As Boolean = False
            Dim strmMensaje As String = ""

            If lstTD_Bultos.Count > 0 Then
                Dim Status As TD_Secuencia = New TD_Secuencia
                Status.pCTPCTR_TipoSecuencia = "ATR003"
                Status.pSTADEF_StatusDefinitivo = "S"
                Status.pUSUARI_Usuario = strUsuario
                'Dim intNroPaleta As Int64 = oWayBill.fintObtener_Secuencia(Status)

                If oWayBill.ErrorMessage <> "" Then
                    RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
                Else
                    'If intNroPaleta = 0 Then
                    '    RaiseEvent ErrorMessage("Error al generar Nro. de Paleta.")
                    'Else
                    'validacionUbicacion = ValidarUbicacion()
                    'If (validacionUbicacion = False) Then
                    '    strmMensaje = "Los bultos seleccionados deben de ser del mismo " & Chr(13)
                    '    strmMensaje += "Tipo Almacén,Almacén y Zona."
                    '    MessageBox.Show(strmMensaje, "Validación de Almacén", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    Exit Sub
                    'End If
                    If VerificarPallet() = True Then
                        MessageBox.Show("Los Bultos ya cuenta con pallet asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If


                    Dim ofrmGenrerPallet As New frmGenPallet
                    ofrmGenrerPallet.pCCLNT = lstTD_Bultos(0).pCCLNT_CodigoCliente
                    ofrmGenrerPallet.ShowDialog()
                    If ofrmGenrerPallet.pDialog = False Then Exit Sub

                    Dim NroPalletTxt As String = ""
                    Dim intNroPaleta As Int64 = oWayBill.fintObtener_Secuencia(Status)

                    If ofrmGenrerPallet.GenerarAutomatico = True Then
                        NroPalletTxt = intNroPaleta
                    End If
                    If ofrmGenrerPallet.GenerarAutomatico = False Then
                        NroPalletTxt = ofrmGenrerPallet.pNRPLTS
                    End If

                    If intNroPaleta = 0 Then
                        RaiseEvent ErrorMessage("Error al generar Nro. de Paleta.")
                    Else


                        Dim msg As String = ""
                        msg = oWayBill.Registrar_Paletas_V2(intNroPaleta, NroPalletTxt, "", lstTD_Bultos, strUsuario)
                        If msg.Length = 0 Then
                            lstTD_Bultos.Clear()
                            'MessageBox.Show("Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Paleta : " & intNroPaleta, "Paletizado:", _
                            '                MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MessageBox.Show("Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Paleta : " & NroPalletTxt, "Paletizado:", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call pRefrescar()
                        Else
                            RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
                        End If
                        'If oWayBill.fblnRegistrar_Paletas(intNroPaleta, "", lstTD_Bultos, strUsuario) Then
                        '    'Registrar_Paletas_V2
                        '    lstTD_Bultos.Clear()
                        '    MessageBox.Show("Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Paleta : " & intNroPaleta, "Paletizado:", _
                        '                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Call pRefrescar()
                        'Else
                        '    RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
                        'End If
                    End If
                End If
            Else
                RaiseEvent ErrorMessage("Debe seleccionar por los menos un Bulto.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Function ValidarUbicacionPreDespacho() As Boolean
        Dim validado As Boolean = False
        For Each drv As DataGridViewRow In dgWayBill.Rows

        Next
        Return validado
    End Function
    Private Sub btnPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreDespacho.Click

        Try

            ' Si no existe Cliente en el Filtro, no se procede con el pre-despacho

            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
            Dim strCriterioLote As String = ""
            If lstTD_Bultos.Count > 0 Then

                Dim strListaBultos As String = ""
                Dim strListaPaletas As String = ""
                Dim strCadenaPregunta As String = ""
                Dim objBultoTemp As TD_Sel_Bulto_L01

                For Each objBultoTemp In lstTD_Bultos
                    ' Cadena de Bultos - Siempre habrá código
                    If strListaBultos <> "" Then strListaBultos &= ","
                    strListaBultos &= "'" & objBultoTemp.pCREFFW_CodigoBulto & "'"
                    ' Cadena de Nros de Paletas - No siempre un bulto esta asociado a una paleta
                    If objBultoTemp.pNROPLT_NroPaletizado <> 0 Then
                        If strListaPaletas <> "" Then strListaPaletas &= ","
                        strListaPaletas &= objBultoTemp.pNROPLT_NroPaletizado
                    End If
                Next
                If strListaPaletas <> "" Then
                    strCadenaPregunta &= "(*) Existen Bultos que están PALETIZADOS, tener en cuenta que toda " & vbNewLine & _
                                         "    la PALETA será despachada." & vbNewLine & vbNewLine
                End If
                If oWayBill.fintObtener_NroLugares(TD_Filtro.pCCLNT_CodigoCliente, strListaBultos, strListaPaletas) > 1 Then
                    strCadenaPregunta &= "(*) Existen Bultos que van a Diferentes lugares de Entrega." & vbNewLine & vbNewLine
                End If
                If oWayBill.ErrorMessage <> "" Then
                    RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
                    Exit Sub
                End If
                If strCadenaPregunta <> "" Then
                    Dim Cancelar As Boolean = False
                    RaiseEvent Confirm(strCadenaPregunta & "¿Desea continuar con el Pre-Despacho?", Cancelar)
                    If Cancelar Then Exit Sub
                End If
                ' Rutina para registrar el PreDespacho y sus respectivos Waybills
                Dim sMessage As String = ""
                Dim nroPredespacho As String = String.Empty
                'If fblnRegistrarBultosAlPreDespacho(oWayBill, lstTD_Bultos, "", strUsuario, sMessage, nroPredespacho) Then
                '    lstTD_Bultos.Clear()
                '    MessageBox.Show(sMessage, "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Call pRefrescar()
                'Else
                '    MessageBox.Show(sMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If

                RegistrarPreDespacho(lstTD_Bultos, "", strUsuario, sMessage, nroPredespacho)
                If sMessage = "" Then
                    Dim msg As String = "Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Pre-Despacho : " & nroPredespacho
                    lstTD_Bultos.Clear()
                    MessageBox.Show(msg, "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call pRefrescar()
                Else
                    MessageBox.Show(sMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


                '

            Else
                ' Realizamos la carga del formulario y el control de los eventos
                oDlgPreDespacho = New ucWaybill_PreDespacho(TD_Filtro, strUsuario)
                AddHandler oDlgPreDespacho.pDisposeForm, AddressOf pDisposeFormServF01
                btnPreDespacho.Enabled = False
                oDlgPreDespacho.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnRepacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepacking.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then
            If TD_BultoActual.pNROPLT_NroPaletizado = 0 Then
                RaiseEvent RePacking_Bulto(TD_BultoActual)
            Else
                RaiseEvent ErrorMessage("Bulto no debe pertenecer a Ninguna Paleta")
            End If
        Else
            RaiseEvent ErrorMessage("No existe información.")
        End If
    End Sub

    Private Sub ucWaybill_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oWayBill.Dispose()
        oWayBill = Nothing
    End Sub

    Private Sub ucWaybill_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oBrBulto As New brBulto()

        TD_Filtro.pNROPAG_NroPagina = 1
        If TD_Filtro.pREGPAG_NroRegPorPagina = 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = 20

        'Ocultamos las columnas con relación a la información de Despacho
        Me.dgWayBill.Columns("FSLFFW").Visible = _pVerInfDespacho
        Me.dgWayBill.Columns("NGUIRM").Visible = _pVerInfDespacho
        Me.dgWayBill.Columns("FLGCNL").Visible = _pVerInfDespacho
        Me.dgWayBill.Columns("FCNFCL").Visible = _pVerInfDespacho
        Me.dgWayBill.Columns("HCNFCL").Visible = _pVerInfDespacho
        Me.dgWayBill.Columns("TOBSEN").Visible = _pVerInfDespacho

    End Sub

    Private Sub dgWayBill_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgWayBill.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgWayBill.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgWayBill.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgWayBill.CurrentCell.RowIndex
            TD_BultoActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            TD_BultoActual.pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
            Decimal.TryParse("" & dgWayBill.CurrentRow.Cells("M_QREFFW").Value, TD_BultoActual.pQREFFW_CantidadRecibida)
            Int64.TryParse("" & dgWayBill.CurrentRow.Cells("M_NROPLT").Value, TD_BultoActual.pNROPLT_NroPaletizado)
            TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
            TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
            TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
            TD_BultoActual.pNSEQIN_NrSecuencia = Val(dgWayBill.CurrentRow.Cells("M_NSEQIN").Value)
            TD_BultoActual.pCBLTOR_CodigoBultoOrigen = dgWayBill.CurrentRow.Cells("M_CBLTOR").Value.ToString.Trim
            TD_BultoActual.pNSEQIO_NrSecuenciaOrigen = Val(dgWayBill.CurrentRow.Cells("M_NSEQIO").Value)
            TD_BultoActual.pNMRGIM_NrImagen = Val(dgWayBill.CurrentRow.Cells("M_NMRGIM").Value)
            TD_BultoActual.pCODMAT_CodigoMaterial = dgWayBill.CurrentRow.Cells("CODMAT").Value.ToString.Trim
            TD_BultoActual.pDESMAT_DescripcionMaterial = dgWayBill.CurrentRow.Cells("DES_MAT").Value.ToString.Trim
            RaiseEvent CurrentRowChanged(TD_BultoActual)
        End If
    End Sub

    Private Sub dgWayBill_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgWayBill.CellContentClick
        If blnCargando Then Exit Sub
        With dgWayBill
            If .RowCount > 0 Then
                If e.ColumnIndex = 0 Then
                    Dim objBultoTemp As TD_Sel_Bulto_L01
                    ' Validamos el Status
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                        For Each objBultoTemp In lstTD_Bultos
                            If objBultoTemp.pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto Then
                                lstTD_Bultos.Remove(objBultoTemp)
                                Exit For
                            End If
                        Next
                    Else
                        .CurrentCell.Value = True
                        objBultoTemp = New TD_Sel_Bulto_L01
                        objBultoTemp.pCCLNT_CodigoCliente = TD_BultoActual.pCCLNT_CodigoCliente

                        objBultoTemp.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
                        objBultoTemp.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
                        objBultoTemp.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta

                        objBultoTemp.pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto
                        objBultoTemp.pNSEQIN_NrSecuencia = TD_BultoActual.pNSEQIN_NrSecuencia
                        objBultoTemp.pCBLTOR_CodigoBultoOrigen = TD_BultoActual.pCBLTOR_CodigoBultoOrigen
                        objBultoTemp.pNSEQIO_NrSecuenciaOrigen = TD_BultoActual.pNSEQIO_NrSecuenciaOrigen
                        objBultoTemp.pNROPLT_NroPaletizado = TD_BultoActual.pNROPLT_NroPaletizado
                        objBultoTemp.pQREFFW_CantidadRecibida = TD_BultoActual.pQREFFW_CantidadRecibida
                        objBultoTemp.pNMRGIM_NrImagen = TD_BultoActual.pNMRGIM_NrImagen

                        ' Insertamos el Bulto
                        lstTD_Bultos.Add(objBultoTemp)
                    End If
                End If
            End If
        End With
        'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS
        'TD_BultoActual.pCODMAT_CodigoMaterial = dgWayBill.CurrentRow.Cells("CODMAT").Value.ToString.Trim
        'TD_BultoActual.pDESMAT_DescripcionMaterial = dgWayBill.CurrentRow.Cells("DES_MAT").Value.ToString.Trim
    End Sub

    Private Sub tsmiBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBulto.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Etiqueta_Bulto(TD_BultoActual)
    End Sub

    Private Sub tsmiPaleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPaleta.Click
        If TD_BultoActual.pNROPLT_NroPaletizado > 0 Then RaiseEvent Etiqueta_Paleta(TD_BultoActual)
    End Sub

    Private Sub tsmiSecuenciaBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSecuenciaBulto.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then RaiseEvent Etiqueta_SecuenciaBulto()
    End Sub

    Private Sub txtPaginaActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim intTemp As Int32 = 0
            If Not Int32.TryParse(txtPaginaActual.Text, intTemp) Then
                Call pMostrarDetallePosicion()
            Else
                Dim sError As String = ""
                If intTemp <= 0 Then sError = "Posición debe ser Mayor a Cero"
                If intTemp > intNroTotalPaginas Then sError = "Posición debe ser Menor al Total de Páginas."
                If sError <> "" Then
                    RaiseEvent ErrorMessage(sError)
                Else
                    ' Actualizamos la posición actual
                    TD_Filtro.pNROPAG_NroPagina = intTemp
                    ' Llamada al procedimiento de carga de información
                    Call pCargarInformacion()
                End If
            End If
        End If
    End Sub

    Private Sub txtNroRegPorPagina_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroRegPorPagina.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim intTemp As Int32 = 0
            If Not Int32.TryParse(txtNroRegPorPagina.Text, intTemp) Then
                Call pMostrarDetallePosicion()
            Else
                If intTemp <= 0 Then
                    RaiseEvent ErrorMessage("Posición debe ser Mayor a Cero")
                Else
                    ' Actualizamos el Nro. de Registros por Página actual
                    TD_Filtro.pNROPAG_NroPagina = 1
                    ' Actualizamos el Nro. de Páginas actual
                    TD_Filtro.pREGPAG_NroRegPorPagina = intTemp
                    ' Llamada al procedimiento de carga de información
                    Call pCargarInformacion()
                End If
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent ImprimirMaterialReport(TD_BultoActual)
    End Sub

#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Bulto_L01)
        'If blnMostrarInfCliente Then
        '    Dim ClientePK As TD_ClientePK = New TD_ClientePK(Filtro.pCCLNT_CodigoCliente, strUsuario)
        '    Dim oCliente As TD_Cliente = cCliente.Obtener(objSqlManager, ClientePK, strMensajeError)

        '    If strMensajeError <> "" Then
        '        Call pLimpiarContenido()
        '        RaiseEvent ErrorMessage(strMensajeError)
        '        Exit Sub
        '    Else
        '        lblWaybill.Text = lblWaybill.Tag & " : " & Filtro.pCCLNT_CodigoCliente & " - " & oCliente.pTCMPCL_DescripcionCliente
        '    End If
        'End If
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
        TD_Filtro.pCREFFW_CodigoBulto = Filtro.pCREFFW_CodigoBulto
        TD_Filtro.pFREFFW_FechaRecep_Ini = Filtro.pFREFFW_FechaRecep_Ini
        TD_Filtro.pFREFFW_FechaRecep_Fin = Filtro.pFREFFW_FechaRecep_Fin
        TD_Filtro.pFSLFFW_FechaDesp_Ini = Filtro.pFSLFFW_FechaDesp_Ini
        TD_Filtro.pFSLFFW_FechaDesp_Fin = Filtro.pFSLFFW_FechaDesp_Fin
        TD_Filtro.pTTINTC_TermInterCarga = Filtro.pTTINTC_TermInterCarga
        TD_Filtro.pSSTINV_StatusAlmacen = Filtro.pSSTINV_StatusAlmacen
        TD_Filtro.pTUBRFR_Ubicacion = Filtro.pTUBRFR_Ubicacion
        TD_Filtro.pSTRNSM_StatusTransmisionEnum = Filtro.pSTRNSM_StatusTransmisionEnum
        TD_Filtro.pSTPING_TipoMovimiento = Filtro.pSTPING_TipoMovimiento
        TD_Filtro.pNROPLT_NroPaletizado = Filtro.pNROPLT_NroPaletizado
        TD_Filtro.pCRTLTE_CriterioLote = Filtro.pCRTLTE_CriterioLote
        TD_Filtro.pUsuario = Filtro.pUsuario
        TD_Filtro.pCCMPN_CodigoCompania = Filtro.pCCMPN_CodigoCompania
        TD_Filtro.pCDVSN_CodigoDivision = Filtro.pCDVSN_CodigoDivision
        TD_Filtro.pCPLNDV_CodigoPlanta = Filtro.pCPLNDV_CodigoPlanta
        TD_Filtro.pFLGCNL_FlagLlegada = Filtro.pFLGCNL_FlagLlegada

        TD_Filtro.pCPLNDV_CodigoPlanta = Filtro.pCPLNDV_CodigoPlanta
        TD_Filtro.pFLGCNL_FlagLlegada = Filtro.pFLGCNL_FlagLlegada
        TD_Filtro.pNGRPRV_GuiaProveedor = Filtro.pNGRPRV_GuiaProveedor
        TD_Filtro.pNORCML_OrdenDeCompra = Filtro.pNORCML_OrdenDeCompra
        TD_Filtro.pNGUIRM_GuiaDeRemision = Filtro.pNGUIRM_GuiaDeRemision
        TD_Filtro.pSSNCRG_Sentido_Carga = Filtro.pSSNCRG_Sentido_Carga
        If Filtro.pNROPAG_NroPagina > 0 Then
            TD_Filtro.pNROPAG_NroPagina = Filtro.pNROPAG_NroPagina
        Else
            TD_Filtro.pNROPAG_NroPagina = 1
        End If
        If Filtro.pREGPAG_NroRegPorPagina > 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = Filtro.pREGPAG_NroRegPorPagina
        ' Llamada al procedimiento de carga de información
        lstTD_Bultos.Clear()
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub ActualizarFlag_Adjunto(pNumeroImg As Decimal)
        Dim Flagimg As String = ""
        If pNumeroImg > 0 Then
            Flagimg = "X"
        End If
        If dgWayBill.CurrentRow IsNot Nothing Then
            dgWayBill.CurrentRow.Cells("M_NMRGIM").Value = pNumeroImg
            dgWayBill.CurrentRow.Cells("NMRGIM_S").Value = Flagimg
        End If

    End Sub
#End Region


    Private Sub dgWayBill_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgWayBill.DataBindingComplete
        If dgWayBill.RowCount = 0 Then Exit Sub
        For Each oDr As DataGridViewRow In dgWayBill.Rows
            If oDr.Cells("M_NMRGIM").Value <> 0 Then
                oDr.Cells("LINKGUIAPROV").Value = My.Resources.text_block
            End If
        Next
    End Sub

    Private Sub dgWayBill_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgWayBill.CellDoubleClick
        If Me.dgWayBill.CurrentCellAddress.Y = -1 Then Exit Sub

        If dgWayBill.Columns(e.ColumnIndex).Name = "LINKGUIAPROV" Then
            If dgWayBill.CurrentRow.Cells("M_NMRGIM").Value <> 0 Then
                TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
                TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
                TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
                RaiseEvent ClickImagen(TD_BultoActual)
            End If
        End If
        If dgWayBill.Columns(e.ColumnIndex).Name = "Auditoria" Then
            Dim ofrmAuditoria As New frmAuditoria
            With ofrmAuditoria
                .USUARIO_CREACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("CUSCRT")
                .FECHA_CREACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("FCHCRT")
                .HORA_CREACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("HRACRT")
                .FECHA_ACTUALIZACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("FULTAC")
                .USUARIO_ACTUALIZACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("CULUSA")
                .HORA_ACTUALIZACION = CType(dgWayBill.CurrentRow.DataBoundItem, DataRowView).Row.Item("HULTAC")
            End With


            ofrmAuditoria.ShowDialog()

        End If
    End Sub

    ''' <summary>
    ''' Abre cualquier tipo de documento
    ''' </summary>
    Private Sub AbrirDocumento(ByVal Path As String)
        Try
            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
            Dim Proceso As New System.Diagnostics.Process
            With InfoProceso
                .FileName = Path
                .CreateNoWindow = True
                .ErrorDialog = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With
            Proceso.StartInfo = InfoProceso
            Proceso.Start()
            Proceso.Dispose()
        Catch
        End Try
    End Sub

    Private Sub btnConfirmarLlegada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarLlegada.Click
        'RaiseEvent Edit_Bulto(TD_BultoActual)
        If lstTD_Bultos.Count = 0 Then Exit Sub
        Dim ofrmConfirmarLlegada As New frmConfirmarLlegada
        With ofrmConfirmarLlegada
            .olBultos = lstTD_Bultos
            If .ShowDialog() = DialogResult.OK Then
                Call pCargarInformacion()
                lstTD_Bultos.Clear()
                Call pRefrescar()
            End If
        End With
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        RaiseEvent ExportExcel()
    End Sub

    Private Function ValidarPermisoTrasladoOC() As Boolean
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario
        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", strUsuario)
        objParametro.Add("MMNPVB", _NameForm)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)
        If objEntidad.STSOP1 = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnTrasladoOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrasladoOC.Click
        Try
            Dim msg As String = ""
            Dim validado As Boolean = False
            Dim numVeces As Int32 = 0
            For Each drv As DataGridViewRow In dgWayBill.Rows
                If (drv.Cells("M_CHK").Value = True) Then
                    numVeces += 1
                    If (numVeces > 1) Then
                        Exit For
                    End If
                End If
            Next
            If (numVeces = 0) Then
                msg = "Debe seleccionar un bulto."
            ElseIf numVeces > 1 Then
                msg = "Solo debe de seleccionar un bulto."
            Else
                validado = True
            End If
            If (validado = True) Then
                TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
                TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
                TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
                TD_BultoActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent TrasladoOC(TD_BultoActual)
            Else
                RaiseEvent ErrorMessage(msg)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsbExportarInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsbExportarInventario.Click
        RaiseEvent ExportInventarioExcel()
    End Sub

    Private Sub btnAdjuntarDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumentos.Click
        TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
        TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
        TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta

        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent AdjuntarDocumnto(TD_BultoActual)
    End Sub

    Private Sub mnuBultoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBultoDetalle.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Etiqueta_Bulto_Detalle(TD_BultoActual)
    End Sub

    Private Sub btnInterfaceFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterfaceFecha.Click
        RaiseEvent InterfaceFecha()
    End Sub

    Private Sub btnInterfaceBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterfaceBulto.Click
        RaiseEvent InterfaceBulto()
    End Sub

    Private Sub BtnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviarEmail.Click
        TD_BultoActual.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
        TD_BultoActual.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
        TD_BultoActual.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
        'TD_BultoActual.pCREFFW_CodigoBulto = TD_Filtro.pCREFFW_CodigoBulto
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Enviar_Email(TD_BultoActual)
    End Sub

    Private Sub btnEnviarConfirmacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnviarConfirmacion.Click
        'Dim odtBultos As

        Dim lstCodEnvioCorrecto As New List(Of String)
        Dim lstBultosSeleccionados As New List(Of TD_Sel_Bulto_L01)
        Dim TD_BultosSeleccionados As TD_Sel_Bulto_L01  '= New Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01

        For Each drv As DataGridViewRow In dgWayBill.Rows
            If (CBool(drv.Cells("M_CHK").Value) = True) Then
                If drv.Cells("STRNSM_C_EST").Value = respExitosaSW Then
                    lstCodEnvioCorrecto.Add(drv.Cells("M_CREFFW").Value.ToString())
                End If

                TD_BultosSeleccionados = New TD_Sel_Bulto_L01()

                TD_BultosSeleccionados.pCCMPN_Compania = TD_Filtro.pCCMPN_CodigoCompania
                TD_BultosSeleccionados.pCDVSN_Division = TD_Filtro.pCDVSN_CodigoDivision
                TD_BultosSeleccionados.pCPLNDV_Planta = TD_Filtro.pCPLNDV_CodigoPlanta
                TD_BultosSeleccionados.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                TD_BultosSeleccionados.pCREFFW_CodigoBulto = drv.Cells("M_CREFFW").Value.ToString()
                TD_BultosSeleccionados.pNSEQIN_NrSecuencia = drv.Cells("M_NSEQIN").Value.ToString()

                lstBultosSeleccionados.Add(TD_BultosSeleccionados)

            End If
        Next

        RaiseEvent EnviarConfirmacion(lstCodEnvioCorrecto, lstBultosSeleccionados)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub tsmiBultoMineria_Click(sender As Object, e As EventArgs) Handles tsmiBultoMineria.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Etiqueta_Bulto_Mineria(TD_BultoActual)
    End Sub


    

    'Private Sub btnPreDespachoPLTZ_Click(sender As Object, e As EventArgs) Handles btnPreDespachoPLTZ.Click
    '    RaiseEvent EnviarConfirmacion(lstCodEnvioCorrecto, lstBultosSeleccionados)
    'End Sub


    Public Sub pActualizarFiltroInicial(ByVal Filtro As TD_Qry_Bulto_L01)
        TD_Filtro.pCCMPN_CodigoCompania = Filtro.pCCMPN_CodigoCompania
        TD_Filtro.pCDVSN_CodigoDivision = Filtro.pCDVSN_CodigoDivision
        TD_Filtro.pCPLNDV_CodigoPlanta = Filtro.pCPLNDV_CodigoPlanta
        TD_Filtro.pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
        TD_Filtro.pUsuario = Filtro.pUsuario
        TD_Filtro.pPlanta = Filtro.pPlanta
 

    End Sub



    Private Sub btnPreDespachoPLTZ_Click(sender As Object, e As EventArgs) Handles btnPreDespachoPLTZ.Click
        Try
            RaiseEvent ActualizarFiltrosIniciales()

            Dim msgval As String = ""
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                msgval = "Seleccione cliente."
            End If
            If TD_Filtro.pCCMPN_CodigoCompania = "" Then
                msgval = msgval & " Seleccione Compañia." & Chr(10)
            End If
            If TD_Filtro.pCDVSN_CodigoDivision = "" Then
                msgval = msgval & " Seleccione División." & Chr(10)
            End If
            If TD_Filtro.pCPLNDV_CodigoPlanta = 0 Then
                msgval = msgval & " Seleccione Planta." & Chr(10)
            End If

            msgval = msgval.Trim
            If msgval.Length > 0 Then
                MessageBox.Show(msgval, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim ofrmPreDespachoPltz As New frmPreDespachoPltz
            ofrmPreDespachoPltz.pCCLNT = TD_Filtro.pCCLNT_CodigoCliente
            ofrmPreDespachoPltz.pCCMPN = TD_Filtro.pCCMPN_CodigoCompania
            ofrmPreDespachoPltz.pCDVSN = TD_Filtro.pCDVSN_CodigoDivision
            ofrmPreDespachoPltz.pCPLNDV = TD_Filtro.pCPLNDV_CodigoPlanta
            ofrmPreDespachoPltz.pCPLNDV_DESC = TD_Filtro.pPlanta
            ofrmPreDespachoPltz.pUsuario = TD_Filtro.pUsuario
            ofrmPreDespachoPltz.ShowDialog()

            If ofrmPreDespachoPltz.pDialog = True Then
                Call pRefrescar()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
