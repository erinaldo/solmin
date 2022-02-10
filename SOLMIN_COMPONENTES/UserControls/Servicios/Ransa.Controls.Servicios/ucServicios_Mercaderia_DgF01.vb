Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Servicios
Imports RANSA.DAO.Servicios

Public Class ucServicios_Mercaderia_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal Mensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Agregar()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Mercaderia As TD_Inf_Servicio_Mercaderia_F01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Mercaderia As TD_Inf_Servicio_Mercaderia_F01)
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
    Private strMensajeError As String = ""
    Private TD_Filtro As TD_Qry_Servicio_Mercaderia_F01 = New Ransa.TypeDef.Servicios.TD_Qry_Servicio_Mercaderia_F01
    Private TD_MercaderiaActual As TD_Inf_Servicio_Mercaderia_F01 = New Ransa.TypeDef.Servicios.TD_Inf_Servicio_Mercaderia_F01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private intFilaActual As Int32 = 0
    Private blnConfirm As Boolean = True
    Private blnCargando As Boolean = False
    Private blnOnLine As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property AskForConfirmation() As Boolean
        Get
            Return blnConfirm
        End Get
        Set(ByVal value As Boolean)
            blnConfirm = value
        End Set
    End Property

    Public Property BackGround() As Color
        Get
            Return dgMercaderia.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgMercaderia.StateCommon.Background.Color1 = value
        End Set
    End Property

    Public Property OnlineRegistration() As Boolean
        Get
            Return blnOnLine
        End Get
        Set(ByVal value As Boolean)
            blnOnLine = value
        End Set
    End Property

    Public ReadOnly Property pBultoSeleccionado() As TD_Inf_Servicio_Mercaderia_F01
        Get
            Return TD_MercaderiaActual
        End Get
    End Property

    Public ReadOnly Property pListaServiciosREG() As List(Of TD_Inf_Servicio_Mercaderia_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Mercaderia_F01) = New List(Of TD_Inf_Servicio_Mercaderia_F01)
            Dim oTemp As TD_Inf_Servicio_Mercaderia_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgMercaderia.RowCount - 1
                If ("" & dgMercaderia.Rows(intIndice).Tag) = "R" Then
                    oTemp = New TD_Inf_Servicio_Mercaderia_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pNORDSR_OrdenServicio = dgMercaderia.Rows(intIndice).Cells("M_NORDSR").Value
                        .pNSLCSR_NroSolicitud = dgMercaderia.Rows(intIndice).Cells("M_NSLCSR").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pListaServiciosDEL() As List(Of TD_Inf_Servicio_Mercaderia_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Mercaderia_F01) = New List(Of TD_Inf_Servicio_Mercaderia_F01)
            Dim oTemp As TD_Inf_Servicio_Mercaderia_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgMercaderia.RowCount - 1
                If ("" & dgMercaderia.Rows(intIndice).Tag) = "E" Then
                    oTemp = New TD_Inf_Servicio_Mercaderia_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pNORDSR_OrdenServicio = dgMercaderia.Rows(intIndice).Cells("M_NORDSR").Value
                        .pNSLCSR_NroSolicitud = dgMercaderia.Rows(intIndice).Cells("M_NSLCSR").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pRowsCount() As Int32
        Get
            Return dgMercaderia.RowCount
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnBuscar(ByVal intNroOS As Int64, ByVal intNroSol As Int32, Optional ByVal blnStatus As Boolean = False) As Boolean
        Dim blnResultado As Boolean = False
        Dim intIndice As Integer
        For intIndice = 0 To dgMercaderia.RowCount - 1
            If intNroOS = dgMercaderia.Rows(intIndice).Cells("M_NORDSR").Value And intNroSol = dgMercaderia.Rows(intIndice).Cells("M_NSLCSR").Value Then
                If blnStatus Then dgMercaderia.Rows(intIndice).Tag = "R"
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function

    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            Dim oOperacionPK As TD_OperacionPK = New TD_OperacionPK
            oOperacionPK.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            oOperacionPK.pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
            strMensajeError = ""
            blnCargando = True
            dgMercaderia.DataSource = cServicios.fdtServicios_Detalle_L03(objSqlManager, oOperacionPK, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_MercaderiaActual.pClear()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                ' Carga el Item y lanzo el evento respectivo
                If dgMercaderia.RowCount > 0 Then
                    With TD_MercaderiaActual
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pNORDSR_OrdenServicio = dgMercaderia.CurrentRow.Cells("M_NORDSR").Value
                        .pNSLCSR_NroSolicitud = dgMercaderia.CurrentRow.Cells("M_NSLCSR").Value
                    End With
                    intFilaActual = 0
                    RaiseEvent DataLoadCompleted(TD_MercaderiaActual)
                Else
                    TD_MercaderiaActual.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If
            With TD_Filtro
                ' Validamos que por lo menos un campo de carga previa se haya ingresado
                If (.pNORDSR_OrdenServicio <> 0 And .pNSLCSR_NroSolicitud <> 0) Or .pNGUIRN_NroGuiaRansa <> 0 Then
                    ' Procedemos a realizar la carga prevía
                    Call pMercaderia_Cargar(TD_Filtro)
                End If
            End With
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgMercaderia.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_MercaderiaActual.pClear()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMercaderia_Registrar()
        Dim oTemp As TD_Servicio_Detalle_I01 = New TD_Servicio_Detalle_I01
        With oTemp
            .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
            .pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
            Select Case Mid(cbxTipoCodigo.Text, 1, 1)
                Case "S"
                    Dim intTemp As Int64 = InStr(txtCodigo.Text, ",")
                    If InStr(txtCodigo.Text, ",") > 0 Then
                        Dim strOS As String = txtCodigo.Text.Substring(0, intTemp - 1).Trim
                        Dim strNroSol As String = txtCodigo.Text.Substring(intTemp).Trim

                        If Not Int64.TryParse(strOS, intTemp) Then
                            strMensajeError = "Debe ingresar un Nro.O/S válido."
                            RaiseEvent ErrorMessage(strMensajeError)
                            txtCodigo.SelectAll()
                            Exit Sub
                        Else
                            .pNORDSR_OrdenServicio = intTemp
                        End If

                        If Not Int64.TryParse(strNroSol, intTemp) Then
                            strMensajeError = "Debe ingresar un Nro. Solic. válido."
                            RaiseEvent ErrorMessage(strMensajeError)
                            txtCodigo.SelectAll()
                            Exit Sub
                        Else
                            .pNSLCSR_NroSolicitud = intTemp
                        End If
                    Else
                        strMensajeError = "Debe ingresar un Nro.O/S y un Nro. Solic. válido."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        strMensajeError = "Debe ingresar un Nro. de Guía de Ransa válido."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNGUIRN_NroGuiaRansa = intTemp
                    End If
            End Select
            If blnOnLine Then
                If Not cServicios.AgregarDetalleServicio(objSqlManager, oTemp, strUsuario, strMensajeError) Then
                    RaiseEvent ErrorMessage(strMensajeError)
                    txtCodigo.SelectAll()
                    Exit Sub
                End If
            End If
            ' Ahora registramos los Bultos
            strMensajeError = ""
            Dim oTemp2 As TD_Qry_Servicio_Mercaderia_F01 = New TD_Qry_Servicio_Mercaderia_F01
            oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
            oTemp2.pNORDSR_OrdenServicio = .pNORDSR_OrdenServicio
            oTemp2.pNSLCSR_NroSolicitud = .pNSLCSR_NroSolicitud
            oTemp2.pNGUIRN_NroGuiaRansa = .pNGUIRN_NroGuiaRansa
            Call pMercaderia_Cargar(oTemp2)
            txtCodigo.SelectAll()
        End With
    End Sub

    Private Sub pMercaderia_Cargar(ByVal oTemp As TD_Qry_Servicio_Mercaderia_F01)
        Dim dtTemp As DataTable = cServicios.fdtServicios_Detalle_L04(objSqlManager, oTemp, strMensajeError)
        If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            blnCargando = True
            Dim dtMercaderia As DataTable = CType(dgMercaderia.DataSource, DataTable)
            For Each dwFila In dtTemp.Rows
                If Not fblnBuscar(dwFila.Item("NORDSR"), dwFila.Item("NSLCSR")) Then
                    Dim dwTemp As DataRow = dtMercaderia.NewRow
                    With dwTemp
                        .Item("CMRCLR") = dwFila.Item("CMRCLR")
                        .Item("TMRCD2") = dwFila.Item("TMRCD2")
                        .Item("CMRCD") = dwFila.Item("CMRCD")
                        .Item("CTPOAT") = dwFila.Item("CTPOAT")
                        .Item("NORDSR") = dwFila.Item("NORDSR")
                        .Item("NSLCSR") = dwFila.Item("NSLCSR")
                        .Item("CTPALM") = dwFila.Item("CTPALM")
                        .Item("CALMC") = dwFila.Item("CALMC")
                        .Item("QTRMC") = dwFila.Item("QTRMC")
                        .Item("CUNCN5") = dwFila.Item("CUNCN5")
                        .Item("QTRMP") = dwFila.Item("QTRMP")
                        .Item("CUNPS5") = dwFila.Item("CUNPS5")
                        .Item("NGUIRN") = dwFila.Item("NGUIRN")
                        .Item("SESTRG") = dwFila.Item("SESTRG")
                    End With
                    dtMercaderia.Rows.Add(dwTemp)
                    ' Si estamos en Batch, debemos marcar el registro para poderlo distiguirlo
                    If Not blnOnLine Then fblnBuscar(dwFila.Item("NORDSR"), dwFila.Item("NSLCSR"), True)
                End If
            Next
            blnCargando = False
        End If
        ' Cargamos el Item y lanzo el evento respectivo
        If dgMercaderia.RowCount > 0 Then
            With TD_MercaderiaActual
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                .pNORDSR_OrdenServicio = dgMercaderia.CurrentRow.Cells("M_NORDSR").Value
                .pNSLCSR_NroSolicitud = dgMercaderia.CurrentRow.Cells("M_NSLCSR").Value
            End With
            intFilaActual = 0
            RaiseEvent DataLoadCompleted(TD_MercaderiaActual)
        Else
            TD_MercaderiaActual.pClear()
            intFilaActual = -1
            RaiseEvent TableWithOutData()
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pMercaderia_Registrar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgMercaderia.RowCount <= 0 Then
            RaiseEvent ErrorMessage("No existe elementos para poder ser eliminados.")
            Exit Sub
        End If
        strMensajeError = ""
        If blnOnLine Then
            Dim oTemp As TD_Servicio_Detalle_E01 = New TD_Servicio_Detalle_E01
            oTemp.pCCLNT_CodigoCliente = TD_MercaderiaActual.pCCLNT_CodigoCliente
            oTemp.pNOPRCN_Operacion = TD_MercaderiaActual.pNOPRCN_Operacion
            oTemp.pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
            oTemp.pNORDSR_OrdenServicio = TD_MercaderiaActual.pNORDSR_OrdenServicio
            oTemp.pNSLCSR_NroSolicitud = TD_MercaderiaActual.pNSLCSR_NroSolicitud
            cServicios.EliminarDetalleServicio(objSqlManager, oTemp, strUsuario, strMensajeError)
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                dgMercaderia.Rows.Remove(dgMercaderia.CurrentRow)
                intFilaActual = -1
                If dgMercaderia.RowCount = 0 Then
                    TD_MercaderiaActual.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If
        Else
            If ("" & dgMercaderia.CurrentRow.Tag) = "E" Then
                dgMercaderia.CurrentRow.Tag = "R"
                dgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Nothing
            Else
                dgMercaderia.CurrentRow.Tag = "E"
                dgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Color.LightCyan
            End If
        End If
    End Sub

    Private Sub ucServicios_Waybill_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucServicios_Waybill_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
    End Sub

    Private Sub dgMercaderia_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMercaderia.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgMercaderia.CurrentCell Is Nothing Then
            intFilaActual = -1
            TD_MercaderiaActual.pClear()
        Else
            If dgMercaderia.CurrentCell.RowIndex <> intFilaActual Then
                intFilaActual = dgMercaderia.CurrentCell.RowIndex
                With TD_MercaderiaActual
                    .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                    .pNORDSR_OrdenServicio = dgMercaderia.CurrentRow.Cells("M_NORDSR").Value
                    .pNSLCSR_NroSolicitud = dgMercaderia.CurrentRow.Cells("M_NSLCSR").Value
                End With
                RaiseEvent CurrentRowChanged(TD_MercaderiaActual)
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pMercaderia_Registrar()
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Servicio_Mercaderia_F01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = Filtro.pNOPRCN_Operacion
            .pSTPODP_TipoSistAlm = Filtro.pSTPODP_TipoSistAlm
            .pNORDSR_OrdenServicio = Filtro.pNORDSR_OrdenServicio
            .pNSLCSR_NroSolicitud = Filtro.pNSLCSR_NroSolicitud
            .pNGUIRN_NroGuiaRansa = Filtro.pNGUIRN_NroGuiaRansa
        End With
        ' Llamada al procedimiento de carga de información
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