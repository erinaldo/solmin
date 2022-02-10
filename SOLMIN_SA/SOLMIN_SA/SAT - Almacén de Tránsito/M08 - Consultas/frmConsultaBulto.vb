' Librerías del Framework  
Imports System.IO
' Librerías del Proyecto
'Imports Ransa.TypeDef.Cliente
Imports Ransa.TYPEDEF.WayBill
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen.Procesos
Imports Ransa.NEGO.slnSOLMIN_SAT.PreDespacho.Procesos
Imports Ransa.DAO.WayBill
Imports Ransa.Utilitario
'Imports Ransa.TypeDef.UbicacionPlanta

Public Class frmConsultaBulto
#Region " Atributos "
    Private blnDetalleItemChanged As Boolean = False
    Private dblCodCliente As Decimal = 0
    Private bolEstado As Boolean = False

#End Region

#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim objFiltro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
        With objFiltro
            .pCCLNT_CodigoCliente = txtClient.pCodigo
            dblCodCliente = txtClient.pCodigo
            .pCREFFW_CodigoBulto = txtCodigoRecepcion.Text
            .pNROPLT_NroPaletizado = txtNroPaletizado.Text
            .pCRTLTE_CriterioLote = txtCriterioLote.Text
            .pFREFFW_FechaRecep_Ini = dteFechaInicial.Value
            .pFREFFW_FechaRecep_Fin = dteFechaFinal.Value
            .pSSTINV_StatusAlmacen = Me.cmbEstado.SelectedValue  ' Predefinimos el código de Stock en almacén
            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .pTUBRFR_Ubicacion = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .pTUBRFR_Ubicacion = ""
            End If
            .pUsuario = objSeguridadBN.pUsuario

            .pCCMPN_CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCDVSN_CodigoDivision = UcDivision_Cmb011.Division
            .pCPLNDV_CodigoPlanta = UcPLanta_Cmb011.Planta

            .pFLGCNL_FlagLlegada = cmbEstadoTransito.SelectedValue
            'Modificado por ABraham Zorrilla
            .pNGRPRV_GuiaProveedor = Me.txtGuiaProveedor.Text.Trim
            .pNORCML_OrdenDeCompra = Me.txtOc.Text.Trim
            .pSSNCRG_Sentido_Carga = "" & txtSentidoCarga.Tag & ""

        End With
        dgBultos.pActualizar(objFiltro)
        '-- Registro los nuevos valores de los campos de los clientes
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RecepcionClienteCodigo", txtClient.pCodigo)
        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pListarItemsBultos(ByVal TD_BultoSeleccionado As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        ' Cargamos la data
        'dgBultosDetalle.DataSource = mfdtListar_ItemsBultos(TD_BultoSeleccionado.pCCLNT_CodigoCliente, TD_BultoSeleccionado.pCREFFW_CodigoBulto, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)

        'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
        'For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
        '    Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
        '    If NRSITEM > 0 Then
        '        oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.retencion
        '    End If
        'Next


        '----------frmObservacionItemOC-------------
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .PNCCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .PNNSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia

        End With
        dgBultosDetalle.AutoGenerateColumns = False
        dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
        For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
            Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
            If NRSITEM > 0 Then
                oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.retencion
            End If
        Next





    End Sub


    Private Sub pMostrarInformacionItemBulto()
        If dgBultosDetalle.CurrentRow Is Nothing Then
            txtInformacionItemBulto.Text = ""
            Exit Sub
        End If
        Dim obrBulto As New brBulto
        txtInformacionItemBulto.Text = obrBulto.fstrInformacionItemBulto(dgBultosDetalle.CurrentRow.DataBoundItem)
    End Sub

    Private Sub pInterfaseCliente()
        Dim strCodigoRecepcion As String = ""
        If txtClient.pCodigo <> 0 Then
            Dim fInterfase As frmInterfase = New frmInterfase
            With fInterfase
                .pCodigoCliente_CCLNT = txtClient.pCodigo
                .pCodigoCompania_CCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .pCodigoDivision_CDVSN = Me.UcDivision_Cmb011.Division
                .pCodigoPlanta_CPLNDV = Me.UcPLanta_Cmb011.Planta
                .ShowDialog()
                strCodigoRecepcion = .pCodigoRecepcion_CREFFW
                .Dispose()
                fInterfase = Nothing
            End With
        End If
        If strCodigoRecepcion <> "" Then
            Dim fModificarBulto As frmModificarBulto = New frmModificarBulto
            With fModificarBulto
                .pCodigoCliente_CCLNT = txtClient.pCodigo
                .pCodigoRecepcion_CREFFW = strCodigoRecepcion
                .Text &= "Modificar"
                .ShowDialog()
                .Dispose()
                fModificarBulto = Nothing
            End With
        End If
        Me.dgBultos.pRefrescar()
    End Sub

    Private Sub pEliminar_BultoPaleta()
        With dgBultos
            If .pBultoSeleccionado.pCREFFW_CodigoBulto <> "" And .pBultoSeleccionado.pNROPLT_NroPaletizado > 0 Then
                If mfblnEliminar_BultoPaleta(.pBultoSeleccionado.pCCLNT_CodigoCliente, .pBultoSeleccionado.pNROPLT_NroPaletizado, _
                                             .pBultoSeleccionado.pCREFFW_CodigoBulto) Then
                    ' corregir
                    ' dgBultosCabecera.CurrentRow.Cells("M_NROPLT").Value = 0
                    Beep()
                End If
            End If
        End With
    End Sub

    Private Function fblnValidaFiltros() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    'Private Sub dgBultos_AdjuntarDocumnto(ByVal Bulto As RANSA.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.AdjuntarDocumnto
    '    Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
    '    With ofrmAdjuntarDocumento
    '        '.obeBulto.PSCCMPN = Bulto.pCCMPN_Compania
    '        '.obeBulto.PSCDVSN = Bulto.pCDVSN_Division
    '        '.obeBulto.PNCPLNDV = Bulto.pCPLNDV_Planta
    '        .oBeDocumento.PNCCLNT = Bulto.pCCLNT_CodigoCliente
    '        .oBeDocumento.PSNDOCUM = Bulto.pCREFFW_CodigoBulto
    '        .oBeDocumento.PSTIPODC = "RECEPCION"
    '    End With
    '    If ofrmAdjuntarDocumento.ShowDialog() Then
    '        Call pActualizarInformacion()
    '    End If
    'End Sub


    Private Sub dgBultos_ClickImagen(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.ClickImagen
        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Bulto
        'With ofrmAdjuntarDocumento
        '    .pTABLE_NAME = "RZOL65"
        '    .pUSER_NAME = objSeguridadBN.pUsuario
        '    .PSCCMPN = Bulto.pCCMPN_Compania
        '    .PSCDVSN = Bulto.pCDVSN_Division
        '    .PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .PSCREFFW = Bulto.pCREFFW_CodigoBulto
        '    .pNMRGIM = Bulto.pNMRGIM_NrImagen
        '    .ShowDialog()
        '    pActualizarInformacion()
        'End With

        Try

            Dim pCCLNT As String = Bulto.pCCLNT_CodigoCliente
            Dim pNSEQIN As String = Bulto.pNSEQIN_NrSecuencia
            Dim pCCMPN As String = Bulto.pCCMPN_Compania
            Dim pCDVSN As String = Bulto.pCDVSN_Division
            Dim pCREFFW As String = Bulto.pCREFFW_CodigoBulto
            Dim pCPLNDV As String = Bulto.pCPLNDV_Planta


            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaAdjuntos.pNroImagen = Bulto.pNMRGIM_NrImagen
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65(pCCMPN, pCDVSN, pCPLNDV, pCCLNT, pCREFFW, pNSEQIN)
            ofrmCargaAdjuntos.ShowDialog()
            If ofrmCargaAdjuntos.pDialog = True Then
                dgBultos.ActualizarFlag_Adjunto(ofrmCargaAdjuntos.pNroImagen)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgBultos_AdjuntarDocumnto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.AdjuntarDocumnto
        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
        'With ofrmAdjuntarDocumento
        '    '.obeBulto.PSCCMPN = Bulto.pCCMPN_Compania
        '    '.obeBulto.PSCDVSN = Bulto.pCDVSN_Division
        '    '.obeBulto.PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .oBeDocumento.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .oBeDocumento.PSNDOCUM = Bulto.pCREFFW_CodigoBulto
        '    .oBeDocumento.PSTIPODC = "RECEPCION"
        'End With
        'If ofrmAdjuntarDocumento.ShowDialog() Then
        '    Call pActualizarInformacion()
        'End If
        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Bulto
        'With ofrmAdjuntarDocumento
        '    .pTABLE_NAME = "RZOL65"
        '    .pUSER_NAME = objSeguridadBN.pUsuario
        '    .PSCCMPN = Bulto.pCCMPN_Compania
        '    .PSCDVSN = Bulto.pCDVSN_Division
        '    .PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .PSCREFFW = Bulto.pCREFFW_CodigoBulto
        '    .pNMRGIM = Bulto.pNMRGIM_NrImagen
        '    .ShowDialog()
        '    pActualizarInformacion()
        'End With

        Try

            Dim pCCLNT As String = Bulto.pCCLNT_CodigoCliente
            Dim pNSEQIN As String = Bulto.pNSEQIN_NrSecuencia
            Dim pCCMPN As String = Bulto.pCCMPN_Compania
            Dim pCDVSN As String = Bulto.pCDVSN_Division
            Dim pCREFFW As String = Bulto.pCREFFW_CodigoBulto
            Dim pCPLNDV As String = Bulto.pCPLNDV_Planta


            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaAdjuntos.pNroImagen = Bulto.pNMRGIM_NrImagen
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            'ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65(pCCMPN, pCDVSN, pCPLNDV, pCCLNT, pCREFFW, pNSEQIN)
            ofrmCargaAdjuntos.ShowDialog()
            If ofrmCargaAdjuntos.pDialog = True Then
                'dgBulto.CurrentRow.Cells("NMRGIM_PAL").Value = ofrmCargaAdjuntos.pNroImagen
                'If ofrmCargaAdjuntos.pNroImagen > 0 Then
                '    dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPAL").Value = "X"
                'Else
                '    dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPAL").Value = "..."
                'End If
                dgBultos.ActualizarFlag_Adjunto(ofrmCargaAdjuntos.pNroImagen)
                'pActualizarInformacion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub dgBultos_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgBultos.Confirm
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgBultos_CurrentRowChanged(ByVal Bulto As RANSA.TYPEDEF.Waybill.TD_Sel_Bulto_L01) Handles dgBultos.CurrentRowChanged
        Call pListarItemsBultos(Bulto)
        Call pListarPaqueteBultos(Bulto)
    End Sub

    Private Sub dgBultos_DataLoadCompleted(ByVal Bulto As RANSA.TYPEDEF.Waybill.TD_Sel_Bulto_L01) Handles dgBultos.DataLoadCompleted
        Call pListarItemsBultos(Bulto)
        Call pListarPaqueteBultos(Bulto)
    End Sub

    Private Sub dgBultos_Edit_Bulto(ByVal Bulto As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Edit_Bulto
        Call pModificarBulto(Bulto)
    End Sub

    Private Sub dgBultos_ErrorMessage(ByVal strMensaje As String) Handles dgBultos.ErrorMessage
        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgBultos_Etiqueta_Bulto(ByVal Bulto As RANSA.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto
        Dim obeBulto As New beBulto
        obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeBulto.PSCDVSN = UcDivision_Cmb011.Division
        obeBulto.PNCPLNDV = UcPLanta_Cmb011.Planta
        obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
        obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
        Call mpImprimir_EtiquetaBulto(obeBulto)
        'Call mpImprimir_EtiquetaBulto(Bulto.pCCLNT_CodigoCliente, Bulto.pCREFFW_CodigoBulto)
    End Sub

    Private Sub dgBultos_Etiqueta_Paleta(ByVal Bulto As RANSA.TYPEDEF.Waybill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Paleta
        Call mpImprimir_EtiquetaPaleta(Bulto.pCCLNT_CodigoCliente, Bulto.pNROPLT_NroPaletizado)
    End Sub

    Private Sub dgBultos_Etiqueta_SecuenciaBulto() Handles dgBultos.Etiqueta_SecuenciaBulto
        If txtClient.pCodigo = 0 Then Exit Sub
        Dim fGenerarSecuencia As frmGenerarSecuencia = New frmGenerarSecuencia
        With fGenerarSecuencia
            .pintCliente = txtClient.pCodigo
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Beep()
            End If
            fGenerarSecuencia = Nothing
        End With
    End Sub

    Private Sub dgBultos_Export(ByRef oSentido As Ransa.TYPEDEF.WayBill.TD_Qry_ExportInf_F01.Sentido, ByRef Formato As Ransa.TYPEDEF.WayBill.TD_Qry_ExportInf_F01.Formato, ByRef bUpdateInf As Boolean) Handles dgBultos.Export
        'Dim objListdt As New List(Of DataTable)
        'dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
        'dtTemp.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        'dtTemp.Columns("CPRVCL").ColumnName = "PROVEEDOR"
        'dtTemp.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL "
        'dtTemp.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        'dtTemp.Columns("NRITOC").ColumnName = "ITEM"
        'dtTemp.Columns("TDITES").ColumnName = "DETALLE"
        'dtTemp.Columns("QCNTIT").ColumnName = "QTA O/C"
        'dtTemp.Columns("FORCML").ColumnName = "FECHA EMISION O/C"
        'dtTemp.Columns("FMPDME").ColumnName = "FECHA POSIBLE ENTREGA"
        'dtTemp.Columns("FREFFW").ColumnName = "FECHA ENTREGA AT"
        'dtTemp.Columns("NDIATR").ColumnName = "DIAS ATRASO"
        'dtTemp.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
        'dtTemp.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
        'dtTemp.Columns("STFREC").ColumnName = "STATUS RECEPCION"
        'dtTemp.Columns("STFENT").ColumnName = "STATUS ENTREGAL"
        'objListdt.Add(ME.)
        'HelpClass.ExportExcel(objListdt, strTitulo)
    End Sub

    Private Sub dgBultos_ExportExcel() Handles dgBultos.ExportExcel
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PNCCLNT = Me.txtClient.pCodigo
            .PSCREFFW = txtCodigoRecepcion.Text
            .PNNROPLT = Val(txtNroPaletizado.Text)
            .PSCRTLTE = txtCriterioLote.Text
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            .PSSSTINV = Me.cmbEstado.SelectedValue  ' Predefinimos el código de Stock en almacén
            .PSTUBRFR = txtUbicacionReferencial.Text
            .PSFLGCNL = cmbEstadoTransito.SelectedValue
            'Modificado por ABraham Zorrilla
            .PSNGRPRV = Me.txtGuiaProveedor.Text.Trim
            .PSNORCML = Me.txtOc.Text.Trim
            .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
        End With
        Dim dstTemp As New DataSet
        Dim odt As New DataTable
        'dstTemp = HelpClass.GetDataSetNative(Me.dtgCentroCostoREcepcion.DataSource)
        odt = obrBulto.ListarBultoALL(obeBulto)
        dstTemp.Tables.Add(odt.Copy)
        For i As Integer = dstTemp.Tables(0).Columns.Count - 1 To 1 Step -1
            'Select Case dstTemp.Tables(0).Columns(i).ColumnName
            '    Case "PSFREFFW", "PSNORCML", "PSNREFCL", "PSTPRVCL", "PSCREFFW", "PSNGRPRV", "PSDESCWB", "PNQREFFW", "PNQPSOBL", "PNQVLBTO", "PSMEDSUG", "PSMEDCONF", "PSTCTCST", "PSTCTCSA", "PSTCTCSF", "PSLOTE"
            '    Case Else
            '        dstTemp.Tables(0).Columns.RemoveAt(i)
            'End Select
        Next

        Call mpGenerarXLS("BULTO", dstTemp.Tables(0), Me.txtClient.pCodigo.ToString & " - " & Me.txtClient.pRazonSocial.ToString)


    End Sub


    Private Sub dgBultos_Interfase_Bulto() Handles dgBultos.Interfase_Bulto
        Call pInterfaseCliente()
    End Sub

    Private Sub dgBultos_RePacking_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.RePacking_Bulto
        Dim fRePacking As frmRePacking = New frmRePacking
        With fRePacking
            .pCodigoCliente_CCLNT = Bulto.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = Bulto.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCodigoDivision_CDVSN = UcDivision_Cmb011.Division
            .pCodigoPlanta_CPLNDV = UcPLanta_Cmb011.Planta
            .ShowDialog()
            .Dispose()
            fRePacking = Nothing
        End With
        dgBultos.pRefrescar()
    End Sub

    Private Sub dgBultos_TableWithOutData() Handles dgBultos.TableWithOutData
        dgBultosDetalle.DataSource = Nothing
    End Sub


    Private Sub dgBultosDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        hgDetalleItem.Width = 21
        blnDetalleItemChanged = True
    End Sub


    Private Sub frmRecepciónBultos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'CARGAMOS ESTADO DE ALMACEN
        CargarEstado()
        'dteFechaInicial.Value = Now.AddYears(-1)
        dteFechaInicial.Value = Now
        dteFechaFinal.Value = Now
        ' ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Informamos a los controles el Usuario actual
        dgBultos.pUsuario = objSeguridadBN.pUsuario
        dgBultos.pNameForm = Me.Name
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtClient.pCargar(ClientePK)
        CargarUbicacion()
        If txtClient.pCodigo <> 0 Then dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    ''' <summary>
    ''' Cargar Estado del bulto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEstado()
        Dim oDt As New DataTable
        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item(0) = ""
        oDr.Item(1) = "TODOS"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "0"
        oDr.Item(1) = "EN ALMACÉN"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "1"
        oDr.Item(1) = "DESPACHADO"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "8"
        oDr.Item(1) = "EN PREDESPACHO"
        oDt.Rows.Add(oDr)
        bolEstado = True
        cmbEstado.DataSource = oDt
        cmbEstado.DisplayMember = "NOM"
        cmbEstado.ValueMember = "COD"


        Dim oDtConfirmacon As New DataTable
        Dim oDrConfirmacon As DataRow
        oDtConfirmacon.Columns.Add("COD")
        oDtConfirmacon.Columns.Add("NOM")

        oDrConfirmacon = oDtConfirmacon.NewRow
        oDrConfirmacon.Item(0) = "0"
        oDrConfirmacon.Item(1) = "TODOS"
        oDtConfirmacon.Rows.Add(oDrConfirmacon)

        oDrConfirmacon = oDtConfirmacon.NewRow
        oDrConfirmacon.Item(0) = ""
        oDrConfirmacon.Item(1) = "EN TRANSITO"
        oDtConfirmacon.Rows.Add(oDrConfirmacon)

        oDrConfirmacon = oDtConfirmacon.NewRow
        oDrConfirmacon.Item(0) = "X"
        oDrConfirmacon.Item(1) = "EN DESTINO"
        oDtConfirmacon.Rows.Add(oDrConfirmacon)

        cmbEstadoTransito.DataSource = oDtConfirmacon
        cmbEstadoTransito.DisplayMember = "NOM"
        cmbEstadoTransito.ValueMember = "COD"

        bolEstado = False

    End Sub

    Private Sub hgDetalleItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If hgDetalleItem.Width = 21 Then
            hgDetalleItem.Width = 400
            If blnDetalleItemChanged Then Call pMostrarInformacionItemBulto()
        Else
            hgDetalleItem.Width = 21
        End If
    End Sub

    Private Sub tsmiEliminarBultoPaleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminarBultoPaleta.Click
        Call pEliminar_BultoPaleta()
    End Sub

    Private Sub txtClient_ExitFocusWithOutData() Handles txtClient.ExitFocusWithOutData
        dgBultos.pClear()
    End Sub

    Private Sub txtClient_InformationChanged() Handles txtClient.InformationChanged
        dgBultos.pClear()
    End Sub

    Private Sub txtClient_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClient.Validating
        dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
        'dgBultos.pShowBtnImprimir = ValidarImpresion(txtClient.pCodigo)
    End Sub


#End Region

    Private Sub dgBultosDetalle_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex < 0 Then Exit Sub
        If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
            If Me.dgBultosDetalle.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
            Dim Item As New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
            Item.pCCMPN_Compania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            Item.pCDVSN_Division = Me.UcDivision_Cmb011.Division
            Item.pCPLNDV_Planta = Me.UcPLanta_Cmb011.Planta

            Item.pCCLNT_CodigoCliente = dblCodCliente
            Item.pCREFFW_FrdForw = Me.dgBultosDetalle.CurrentRow.Cells("D_CREFFW").Value
            Item.pCIDPAQ_CodIndentificacionPaquete = Me.dgBultosDetalle.CurrentRow.Cells("D_CIDPAQ").Value
            Item.pNORCML_NroOrdenCompra = Me.dgBultosDetalle.CurrentRow.Cells("D_NORCML").Value
            Item.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value

            Dim ofrmSubItemEnAlmacen As New frmSubItemEnAlmacen
            With ofrmSubItemEnAlmacen
                .Items = Item
                .UcSubItemOcEnAlmacen_DgF011.Agregar = False
                .UcSubItemOcEnAlmacen_DgF011.Eliminar = False
                .ShowDialog()
            End With
        End If

        If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("Obs") Then
            Dim obeItemOC As New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
            obeItemOC.pCCMPN_Compania = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCCMPN
            obeItemOC.pCDVSN_Division = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCDVSN
            obeItemOC.pCPLNDV_Planta = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNCPLNDV
            obeItemOC.pCCLNT_CodigoCliente = dblCodCliente
            obeItemOC.pCREFFW_FrdForw = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCREFFW
            obeItemOC.pCIDPAQ_CodIndentificacionPaquete = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCIDPAQ
            obeItemOC.pNORCML_NroOrdenCompra = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSNORCML
            obeItemOC.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNNRITOC

            Dim frmObs As New frmObservacionItemOC(obeItemOC)
            frmObs.ShowInTaskbar = False
            frmObs.VisualizarbtnActualizar = False
            frmObs.StartPosition = FormStartPosition.CenterScreen
            frmObs.ShowDialog()
        End If

    End Sub

    Private Sub dgBultosDetalle_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)
        Dim imagen As Bitmap
        imagen = New Bitmap(Global.SOLMIN_SA.My.Resources.text_block)
        For i As Integer = 0 To dgBultosDetalle.Rows.Count - 1
            dgBultosDetalle.Rows(i).Cells("Obs").Value = imagen
        Next
    End Sub


    Private Sub RealizarRetencion(ByVal pstrRetencion As String)
        Dim oItemWaybill As cItemWayBill = New Ransa.DAO.WayBill.cItemWayBill(objSeguridadBN.pUsuario)
        Dim oItemBulto As TD_Obj_ItemBulto = New TD_Obj_ItemBulto
        With oItemBulto
            oItemBulto.pCCLNT_CodigoCliente = dgBultos.pBultoSeleccionado.pCCLNT_CodigoCliente 'dgBultosDetalle.CurrentRow.Cells("CCLNT").Value
            oItemBulto.pCREFFW_CodigoBulto = dgBultos.pBultoSeleccionado.pCREFFW_CodigoBulto
            oItemBulto.pNORCML_NroOrdenCompra = dgBultosDetalle.CurrentRow.Cells("D_NORCML").Value
            oItemBulto.pNRITOC_NroItemOC = dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value
            oItemBulto.pCIDPAQ_CodItentificadorPaquetes = dgBultosDetalle.CurrentRow.Cells("D_CIDPAQ").Value
            oItemBulto.pMARRET_MarcaRetencion = pstrRetencion
        End With
        oItemWaybill.ActualizarCustodia(oItemBulto)
        Call pListarItemsBultos(dgBultos.pBultoSeleccionado)
    End Sub

    'Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania)
    '    UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
    '    UcDivision_Cmb011.Usuario = "AZORRILLAP"
    '    UcDivision_Cmb011.pActualizar()
    'End Sub

    'Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As RANSA.TYPEDEF.UbicacionPlanta.Division.beDivision)
    '    UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
    '    UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
    '    UcPLanta_Cmb011.Usuario = "AZORRILLAP"
    '    UcPLanta_Cmb011.pActualizar()
    'End Sub

    'Private Sub dgBultos_ImprimirMaterialReport(ByVal Bulto As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.ImprimirMaterialReport
    '    Dim ofrmVisorRPT As New frmVisorRPT
    '    Dim oReport As New Ransa.NEGO.rptReceivingReport
    '    Dim strMensajeError As String = ""
    '    Dim oDt As New DataTable
    '    oReport.SetDataSource(clsAlmacen.fdtReporteMaterialReceivingReport(Bulto.pCCLNT_CodigoCliente, Bulto.pCREFFW_CodigoBulto, strMensajeError).Copy)
    '    oReport.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
    '    ofrmVisorRPT.pReportDocument = oReport
    '    If strMensajeError <> "" Then
    '        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        ofrmVisorRPT.MaximizeBox = True
    '        ofrmVisorRPT.ShowDialog()
    '    End If
    'End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub KryptonSplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles KryptonSplitContainer1.SplitterMoved

    End Sub

    Private Sub cmbEstado_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedValueChanged
        If bolEstado Then Exit Sub
        If Me.cmbEstado.SelectedValue = "1" Then
            Me.cmbEstadoTransito.Visible = True
            lblEstadoTransito.Visible = True
            dgBultos.pShowBtnConfirmarLlegada = True
            lblFechaInicial.Text = "Fch. Salida De: "
        Else
            cmbEstadoTransito.Visible = False
            lblEstadoTransito.Visible = False
            dgBultos.pShowBtnConfirmarLlegada = False
            If Me.cmbEstado.SelectedValue = "" Or Me.cmbEstado.SelectedValue = "0" Or Me.cmbEstado.SelectedValue = "8" Then
                lblFechaInicial.Text = "Fch. Recepción De: "
            End If
        End If
    End Sub


    Private Sub cmbEstadoTransito_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoTransito.SelectedValueChanged
        'If bolEstado Then Exit Sub
        'If Me.cmbEstadoTransito.SelectedValue = "X" Then
        '    dgBultos.pShowBtnConfirmarLlegada = True
        'Else
        '    dgBultos.pShowBtnConfirmarLlegada = False
        'End If
    End Sub

    Private Sub pModificarBulto(ByVal TD_BultoSeleccionado As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01)
        Dim fModificarBulto As frmModificarBulto_V3 = New frmModificarBulto_V3
        With fModificarBulto
            .pCodigoCliente_CCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = TD_BultoSeleccionado.pCCMPN_Compania
            .pCodigoDivision_CDVSN = TD_BultoSeleccionado.pCDVSN_Division
            .pCodigoPlanta_CPLNDV = TD_BultoSeleccionado.pCPLNDV_Planta
            .pNrCorrelativo_NSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
            .Text &= "Modificar"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                .Dispose()
                fModificarBulto = Nothing
                dgBultos.pRefrescar()
            End If
        End With

    End Sub
    Private Sub dgBultos_TrasladoOC(ByVal Bulto As RANSA.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.TrasladoOC
        Try
            Dim ofrmConsultaOCTraslado As New frmConsultaOCTraslado
            Dim olistBulto As New List(Of beBulto)
            olistBulto = CType(Me.dgBultosDetalle.DataSource, List(Of beBulto))
            ofrmConsultaOCTraslado.oListBulto = olistBulto
            ofrmConsultaOCTraslado.Bulto = Bulto
            ofrmConsultaOCTraslado.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmConsultaOCTraslado.PSCDVSN = Me.UcDivision_Cmb011.Division
            ofrmConsultaOCTraslado.PNCPLNDV = Me.UcPLanta_Cmb011.Planta

            ofrmConsultaOCTraslado.ShowDialog()
            If (ofrmConsultaOCTraslado.myDialogResult) Then
                Call pActualizarInformacion()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click
        Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
    End Sub

    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
        End If
    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating
        If txtSentidoCarga.Text = "" Then
            txtSentidoCarga.Tag = ""
        Else
            If txtSentidoCarga.Text <> "" And "" & txtSentidoCarga.Tag = "" Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                If txtSentidoCarga.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub CargarUbicacion()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        Dim objNegocio As New brUbicacionesXCliente

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR_1"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación "
        oColumnas.Visible = False
        oListColum.Add(2, oColumnas)
        txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(Me.txtClient.pCodigo)
        txtUbicacionReferencial.ListColumnas = oListColum
        txtUbicacionReferencial.Cargas()
        txtUbicacionReferencial.Limpiar()
        txtUbicacionReferencial.ValueMember = "PSTUBRFR"
        txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtClient.InformationChanged
        CargarUbicacion()
    End Sub

    Private Sub pListarPaqueteBultos(ByVal TD_BultoSeleccionado As RANSA.TypeDef.WayBill.TD_Sel_Bulto_L01)
        '----------frmObservacionItemOC-------------
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .PNCCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .PNNSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
        End With
        dtgPaquetesDeBulto.AutoGenerateColumns = False
        dtgPaquetesDeBulto.DataSource = obrBulto.flistListarBultoDetalleCarga(obeBulto)
    End Sub

    'miguel 

    Public Sub dgBultos_Enviar_Email(ByVal Bulto As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Enviar_Email

        Call pEnviarEmail(Bulto)


    End Sub






    Private Sub pEnviarEmail(ByVal TD_BultoSeleccionado As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01)
        Dim fModificarBulto As frmEnviarMailBulto = New frmEnviarMailBulto
        With fModificarBulto
            .pCodigoCliente_CCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = TD_BultoSeleccionado.pCCMPN_Compania
            .pCodigoDivision_CDVSN = TD_BultoSeleccionado.pCDVSN_Division
            .pCodigoPlanta_CPLNDV = TD_BultoSeleccionado.pCPLNDV_Planta
            .pNrCorrelativo_NSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
            .Text &= "Enviar Correo"
        End With

        If fModificarBulto.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fModificarBulto.Dispose()
            fModificarBulto = Nothing
            dgBultos.pRefrescar()
        End If


    End Sub

    Private Sub dgBultos_Etiqueta_Bulto_Mineria(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto_Mineria
        Try
            Dim obeBulto As New beBulto
            obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            obeBulto.PSCDVSN = UcDivision_Cmb011.Division
            obeBulto.PNCPLNDV = UcPLanta_Cmb011.Planta
            obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
            obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
            obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
            obeBulto.PNQREFFW = Bulto.pQREFFW_CantidadRecibida
            Call mpImprimir_EtiquetaBulto_Mineria(obeBulto)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


End Class