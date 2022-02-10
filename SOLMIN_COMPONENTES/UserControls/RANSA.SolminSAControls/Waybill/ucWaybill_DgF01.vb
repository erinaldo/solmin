Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.TYPEDEF.Waybill
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.WayBill

Public Class ucWaybill_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Add_Bulto()
    Public Event Edit_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Delete_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event RePacking_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Bulto(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_Paleta(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event Etiqueta_SecuenciaBulto()
    Public Event Interfase_Bulto()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Bulto As TD_Sel_Bulto_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Bulto As TD_Sel_Bulto_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_Filtro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
    Private TD_BultoActual As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
    Private lstTD_Bultos As List(Of TD_Sel_Bulto_L01) = New List(Of TD_Sel_Bulto_L01)
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private intNroTotalPaginas As Int32 = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnShowAllBotton As Boolean = True
    Private blnShowCheckColumn As Boolean = True
    Private blnMostrarInfCliente As Boolean = True
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
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

    Public Property pMostrarBotones() As Boolean
        Get
            Return blnShowAllBotton
        End Get
        Set(ByVal value As Boolean)
            blnShowAllBotton = value
            ' Aplicamos los cambios a los controles
            btnAgregar.Visible = value
            tssSep_01.Visible = value
            btnEditar.Visible = value
            tssSep_02.Visible = value
            btnEliminar.Visible = value
            tssSep_03.Visible = value
            btnRepacking.Visible = value
            tssSep_04.Visible = value
            btnInterfase.Visible = value
            tssSep_05.Visible = value
            btnPaletizar.Visible = value
            tssSep_06.Visible = value
            btnPreDespacho.Visible = value
            tssSep_07.Visible = value
            btnEtiqueta.Visible = value
        End Set
    End Property

    Public Property pMostrarColumnaCheck() As Boolean
        Get
            Return blnShowCheckColumn
        End Get
        Set(ByVal value As Boolean)
            blnShowCheckColumn = value
            Me.dgWayBill.Columns("M_CHK").Visible = value
        End Set
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgWayBill.DataSource = daoWayBill.fdtListar_Bultos_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_Filtro.pNROPAG_NroPagina = 1
                intNroTotalPaginas = 0
                Call pMostrarDetallePosicion()
                RaiseEvent ErrorMessage(strMensajeError)
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
                    Decimal.TryParse("" & dgWayBill.CurrentRow.Cells("M_QREFFW").Value, TD_BultoActual.pQREFFW_CantidadRecibida)
                    Int64.TryParse("" & dgWayBill.CurrentRow.Cells("M_NROPLT").Value, TD_BultoActual.pNROPLT_NroPaletizado)
                    intFilaActual = 0
                Else
                    TD_BultoActual.pCCLNT_CodigoCliente = 0
                    TD_BultoActual.pCREFFW_CodigoBulto = ""
                    TD_BultoActual.pQREFFW_CantidadRecibida = 0
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
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then RaiseEvent Add_Bulto()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then RaiseEvent Edit_Bulto(TD_BultoActual)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim blnConfirm As Boolean = False
        RaiseEvent Confirm("Desea eliminar el Bulto.", blnConfirm)
        If blnConfirm Then Exit Sub
        If dgWayBill.RowCount >= 0 Then
            Dim oTempBulto As TD_BultoPK = New TD_BultoPK
            With oTempBulto
                .pCCLNT_CodigoCliente = TD_BultoActual.pCCLNT_CodigoCliente
                .pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto
            End With
            If daoWayBill.Delete(objSqlManager, oTempBulto, strUsuario, strMensajeError) Then
                dgWayBill.Rows.Remove(dgWayBill.CurrentRow)
                RaiseEvent Message("Proceso culminó satisfactoriamente.")
            Else
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub

    Private Sub btnInterfase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterfase.Click
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            RaiseEvent Interfase_Bulto()
        Else
            strMensajeError = "Debe eligir un Cliente para poder realizar la Transferencia."
            RaiseEvent ErrorMessage(strMensajeError)
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

    Private Sub btnPaletizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaletizar.Click
        If lstTD_Bultos.Count > 0 Then
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim Status As TD_Secuencia = New TD_Secuencia
            Status.pCTPCTR_TipoSecuencia = "ATR003"
            Status.pSTADEF_StatusDefinitivo = "S"
            Status.pUSUARI_Usuario = strUsuario
            Dim intNroPaleta As Int64 = daoWayBill.fintObtener_Secuencia(objSqlManager, Status, strMensajeError)
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If intNroPaleta = 0 Then
                    strMensajeError = "Error al generar Nro. de Paleta."
                    RaiseEvent ErrorMessage(strMensajeError)
                Else
                    If daoWayBill.fblnRegistrar_Paletas(objSqlManager, intNroPaleta, "", lstTD_Bultos, strUsuario, strMensajeError) Then
                        lstTD_Bultos.Clear()
                        Call pRefrescar()
                        RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Paleta : " & intNroPaleta)
                    Else
                        RaiseEvent ErrorMessage(strMensajeError)
                    End If
                End If
            End If
        Else
            strMensajeError = "Debe seleccionar por los menos un Bulto."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
    End Sub

    Private Sub btnPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreDespacho.Click
        ' Si no existe Cliente en el Filtro, no se procede con el pre-despacho
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub

        Dim intNroPreDespacho As Int64 = 0
        Dim strCriterioLote As String = ""
        If lstTD_Bultos.Count > 0 Then
            objSqlManager.TransactionController(TransactionType.Automatic)

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
                strCadenaPregunta &= "(*) Existen Bultos que estan PALETIZADOS, tener en cuenta que toda " & vbNewLine & _
                                     "    la PALETA será despachada." & vbNewLine & vbNewLine
            End If
            If daoWayBill.fintObtener_NroLugares(objSqlManager, TD_Filtro.pCCLNT_CodigoCliente, strListaBultos, strListaPaletas, strMensajeError) > 1 Then
                strCadenaPregunta &= "(*) Existen Bultos que van a Diferentes lugares de Entrega." & vbNewLine & vbNewLine
            End If
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
                Exit Sub
            End If
            If strCadenaPregunta <> "" Then
                Dim Cancelar As Boolean = False
                RaiseEvent Confirm(strCadenaPregunta & "¿Desea continuar con el Pre-Despacho?", Cancelar)
                If Cancelar Then Exit Sub
            End If
        Else
            Dim fGenPrespacho As ucWaybill_PreDespacho = New ucWaybill_PreDespacho
            With fGenPrespacho
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                If .ShowDialog <> DialogResult.OK Then
                    Exit Sub
                Else
                    lstTD_Bultos = .pListaBultos
                    strCriterioLote = .pCTRLTE_CriterioLote
                    Call pRefrescar()
                End If
                fGenPrespacho.Dispose()
                fGenPrespacho = Nothing
            End With
        End If
        ' Iniciamos el proceso de Pre-Despacho
        Dim Status As TD_Secuencia = New TD_Secuencia
        Status.pCTPCTR_TipoSecuencia = "EZOL19"
        Status.pSTADEF_StatusDefinitivo = "S"
        Status.pUSUARI_Usuario = strUsuario
        intNroPreDespacho = daoWayBill.fintObtener_Secuencia(objSqlManager, Status, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If intNroPreDespacho = 0 Then
                strMensajeError = "Error al generar Nro. de Pre-Despacho."
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If daoWayBill.fblnRegistrar_PreDespacho(objSqlManager, intNroPreDespacho, strCriterioLote, lstTD_Bultos, strUsuario, strMensajeError) Then
                    lstTD_Bultos.Clear()
                    Call pRefrescar()
                    RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Paleta : " & intNroPreDespacho)
                Else
                    RaiseEvent ErrorMessage(strMensajeError)
                End If
            End If
        End If
    End Sub

    Private Sub btnRepacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepacking.Click
        If TD_BultoActual.pCREFFW_CodigoBulto <> "" Then
            If TD_BultoActual.pNROPLT_NroPaletizado = 0 Then
                RaiseEvent RePacking_Bulto(TD_BultoActual)
            Else
                strMensajeError = "Bulto no debe pertenecer a Ninguna Paleta"
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        Else
            strMensajeError = "No existe información."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
    End Sub

    Private Sub ucWaybill_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucWaybill_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        If TD_Filtro.pREGPAG_NroRegPorPagina = 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = 20
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
                        objBultoTemp.pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto
                        objBultoTemp.pNROPLT_NroPaletizado = TD_BultoActual.pNROPLT_NroPaletizado
                        objBultoTemp.pQREFFW_CantidadRecibida = TD_BultoActual.pQREFFW_CantidadRecibida
                        ' Insertamos el Bulto
                        lstTD_Bultos.Add(objBultoTemp)
                    End If
                End If
            End If
        End With
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
                If intTemp <= 0 Then strMensajeError = "Posición debe ser Mayor a Cero"
                If intTemp > intNroTotalPaginas Then strMensajeError = "Posición debe ser Menor al Total de Páginas."
                If strMensajeError <> "" Then
                    RaiseEvent ErrorMessage(strMensajeError)
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
                    strMensajeError = "Posición debe ser Mayor a Cero"
                    RaiseEvent ErrorMessage(strMensajeError)
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
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Bulto_L01)
        If blnMostrarInfCliente Then
            Dim oCliente As TD_Cliente = daoCliente.Obtener(objSqlManager, Filtro.pCCLNT_CodigoCliente, strMensajeError)
            If strMensajeError <> "" Then
                Call pLimpiarContenido()
                RaiseEvent ErrorMessage(strMensajeError)
                Exit Sub
            Else
                lblWaybill.Text = lblWaybill.Tag & " : " & Filtro.pCCLNT_CodigoCliente & " - " & oCliente.pTCMPCL_DescripcionCliente
            End If
        End If
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
        TD_Filtro.pNROPLT_NroPaletizado = Filtro.pNROPLT_NroPaletizado
        TD_Filtro.pCRTLTE_CriterioLote = Filtro.pCRTLTE_CriterioLote
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
#End Region
End Class
