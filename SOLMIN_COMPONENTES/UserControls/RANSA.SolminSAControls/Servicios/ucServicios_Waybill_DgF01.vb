Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Servicios
Imports RANSA.DATA.slnSOLMIN_SA.DAO.Servicios

Public Class ucServicios_Waybill_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal Mensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Agregar()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Bulto As TD_Inf_Servicio_Bulto_F01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Bulto As TD_Inf_Servicio_Bulto_F01)
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
    Private TD_Filtro As TD_Qry_Servicio_Bulto_F01 = New TD_Qry_Servicio_Bulto_F01
    Private TD_BultoActual As TD_Inf_Servicio_Bulto_F01 = New TD_Inf_Servicio_Bulto_F01
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
            Return dgWayBill.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgWayBill.StateCommon.Background.Color1 = value
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

    Public ReadOnly Property pBultoSeleccionado() As TD_Inf_Servicio_Bulto_F01
        Get
            Return TD_BultoActual
        End Get
    End Property

    Public ReadOnly Property pListaServiciosREG() As List(Of TD_Inf_Servicio_Bulto_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Bulto_F01) = New List(Of TD_Inf_Servicio_Bulto_F01)
            Dim oTemp As TD_Inf_Servicio_Bulto_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgWayBill.RowCount - 1
                If ("" & dgWayBill.Rows(intIndice).Tag) = "R" Then
                    oTemp = New TD_Inf_Servicio_Bulto_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pCREFFW_CodigoBulto = dgWayBill.Rows(intIndice).Cells("M_CREFFW").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pListaServiciosDEL() As List(Of TD_Inf_Servicio_Bulto_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Bulto_F01) = New List(Of TD_Inf_Servicio_Bulto_F01)
            Dim oTemp As TD_Inf_Servicio_Bulto_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgWayBill.RowCount - 1
                If ("" & dgWayBill.Rows(intIndice).Tag) = "E" Then
                    oTemp = New TD_Inf_Servicio_Bulto_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pCREFFW_CodigoBulto = dgWayBill.Rows(intIndice).Cells("M_CREFFW").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pRowsCount() As Int32
        Get
            Return dgWayBill.RowCount
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnBuscar(ByVal strCodigo As String, Optional ByVal blnStatus As Boolean = False) As Boolean
        Dim blnResultado As Boolean = False
        Dim intIndice As Integer
        For intIndice = 0 To dgWayBill.RowCount - 1
            If strCodigo.Trim = dgWayBill.Rows(intIndice).Cells("M_CREFFW").Value.ToString.Trim Then
                If blnStatus Then dgWayBill.Rows(intIndice).Tag = "R"
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
            dgWayBill.DataSource = daoServicio.fdtServicios_Detalle_L01(objSqlManager, oOperacionPK, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_BultoActual.pClear()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                ' Carga el Item y lanzo el evento respectivo
                If dgWayBill.RowCount > 0 Then
                    With TD_BultoActual
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
                    End With
                    intFilaActual = 0
                    RaiseEvent DataLoadCompleted(TD_BultoActual)
                Else
                    TD_BultoActual.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If
            With TD_Filtro
                ' Validamos que por lo menos un campo de carga previa se haya ingresado
                If .pCREFFW_CodigoBulto <> "" Or .pNROPLT_NroPaletizado <> 0 Or .pNROCTL_NroPreDespacho <> 0 Or .pNRGUSA_NroGuiaSalida <> 0 Or _
                   .pNGUIRM_NroGuiaRemision <> 0 Then
                    ' Procedemos a realizar la carga prevía
                    Call pWayBills_Cargar(TD_Filtro)
                End If
            End With
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgWayBill.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_BultoActual.pClear()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pWaybills_Registrar()
        Dim oTemp As TD_Servicio_Detalle_I01 = New TD_Servicio_Detalle_I01
        With oTemp
            .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
            .pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
            Select Case Mid(cbxTipoCodigo.Text, 1, 1)
                Case "B"
                    .pCREFFW_CodigoBulto = txtCodigo.Text
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        strMensajeError = "Debe ingresar un Nro. de Paleta válido."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNROPLT_NroPaletizado = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        strMensajeError = "Debe ingresar un Nro. de Pre-Despacho."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNROCTL_NroPreDespacho = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        strMensajeError = "Debe ingresar un Nro. de Pre-Despacho."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNRGUSA_NroGuiaSalida = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        strMensajeError = "Debe ingresar un Nro. de Guía de Remisión válido."
                        RaiseEvent ErrorMessage(strMensajeError)
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNGUIRM_NroGuiaRemision = intTemp
                    End If
            End Select
            If blnOnLine Then
                If Not daoServicio.AgregarDetalleServicio(objSqlManager, oTemp, TD_Filtro.pUsuario, strMensajeError) Then
                    RaiseEvent ErrorMessage(strMensajeError)
                    txtCodigo.SelectAll()
                    Exit Sub
                End If
            End If
            ' Ahora registramos los Bultos
            strMensajeError = ""
            Dim oTemp2 As TD_Qry_Servicio_Bulto_F01 = New TD_Qry_Servicio_Bulto_F01
            oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
            oTemp2.pSTPODP_TipoSistAlm = .pSTPODP_TipoSistAlm
            oTemp2.pCREFFW_CodigoBulto = .pCREFFW_CodigoBulto
            oTemp2.pNROPLT_NroPaletizado = .pNROPLT_NroPaletizado
            oTemp2.pNROCTL_NroPreDespacho = .pNROCTL_NroPreDespacho
            oTemp2.pNRGUSA_NroGuiaSalida = .pNRGUSA_NroGuiaSalida
            oTemp2.pNGUIRM_NroGuiaRemision = .pNGUIRM_NroGuiaRemision
            Call pWayBills_Cargar(oTemp2)
            txtCodigo.SelectAll()
        End With
    End Sub

    Private Sub pWayBills_Cargar(ByVal oTemp As TD_Qry_Servicio_Bulto_F01)
        Dim dtTemp As DataTable = daoServicio.fdtServicios_Detalle_L02(objSqlManager, oTemp, strMensajeError)
        If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            blnCargando = True
            Dim dtWayBill As DataTable = CType(dgWayBill.DataSource, DataTable)
            For Each dwFila In dtTemp.Rows
                If Not fblnBuscar(dwFila.Item("CREFFW")) Then
                    Dim dwTemp As DataRow = dtWayBill.NewRow
                    With dwTemp
                        .Item("CREFFW") = dwFila.Item("CREFFW")
                        .Item("DESCWB") = dwFila.Item("DESCWB")
                        .Item("TUBRFR") = dwFila.Item("TUBRFR")
                        .Item("QREFFW") = dwFila.Item("QREFFW")
                        .Item("TIPBTO") = dwFila.Item("TIPBTO")
                        .Item("QPSOBL") = dwFila.Item("QPSOBL")
                        .Item("TUNPSO") = dwFila.Item("TUNPSO")
                        .Item("QVLBTO") = dwFila.Item("QVLBTO")
                        .Item("TUNVOL") = dwFila.Item("TUNVOL")
                        .Item("QAROCP") = dwFila.Item("QAROCP")
                        .Item("SESTRG") = dwFila.Item("SESTRG")
                    End With
                    dtWayBill.Rows.Add(dwTemp)
                    ' Si estamos en Batch, debemos marcar el registro para poderlo distiguirlo
                    If Not blnOnLine Then fblnBuscar(dwFila.Item("CREFFW"), True)
                End If
            Next
            blnCargando = False
        End If
        ' Cargamos el Item y lanzo el evento respectivo
        If dgWayBill.RowCount > 0 Then
            With TD_BultoActual
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                .pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
            End With
            intFilaActual = 0
            RaiseEvent DataLoadCompleted(TD_BultoActual)
        Else
            TD_BultoActual.pClear()
            intFilaActual = -1
            RaiseEvent TableWithOutData()
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pWaybills_Registrar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgWayBill.RowCount <= 0 Then
            RaiseEvent ErrorMessage("No existe elementos para poder ser eliminados.")
            Exit Sub
        End If
        strMensajeError = ""
        If blnOnLine Then
            Dim oTemp As TD_Servicio_Detalle_E01 = New TD_Servicio_Detalle_E01
            oTemp.pCCLNT_CodigoCliente = TD_BultoActual.pCCLNT_CodigoCliente
            oTemp.pNOPRCN_Operacion = TD_BultoActual.pNOPRCN_Operacion
            oTemp.pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
            oTemp.pCREFFW_CodigoBulto = TD_BultoActual.pCREFFW_CodigoBulto
            daoServicio.EliminarDetalleServicio(objSqlManager, oTemp, TD_Filtro.pUsuario, strMensajeError)
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                dgWayBill.Rows.Remove(dgWayBill.CurrentRow)
                intFilaActual = -1
                If dgWayBill.RowCount = 0 Then
                    TD_BultoActual.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If
        Else
            If ("" & dgWayBill.CurrentRow.Tag) = "E" Then
                dgWayBill.CurrentRow.Tag = "R"
                dgWayBill.CurrentRow.DefaultCellStyle.BackColor = Nothing
            Else
                dgWayBill.CurrentRow.Tag = "E"
                dgWayBill.CurrentRow.DefaultCellStyle.BackColor = Color.LightCyan
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

    Private Sub dgWayBill_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgWayBill.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgWayBill.CurrentCell Is Nothing Then
            intFilaActual = -1
            TD_BultoActual.pClear()
        Else
            If dgWayBill.CurrentCell.RowIndex <> intFilaActual Then
                intFilaActual = dgWayBill.CurrentCell.RowIndex
                With TD_BultoActual
                    .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                    .pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
                End With
                RaiseEvent CurrentRowChanged(TD_BultoActual)
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pWaybills_Registrar()
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Servicio_Bulto_F01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = Filtro.pNOPRCN_Operacion
            .pSTPODP_TipoSistAlm = Filtro.pSTPODP_TipoSistAlm
            .pCREFFW_CodigoBulto = Filtro.pCREFFW_CodigoBulto
            .pNROPLT_NroPaletizado = Filtro.pNROPLT_NroPaletizado
            .pNROCTL_NroPreDespacho = Filtro.pNROCTL_NroPreDespacho
            .pNRGUSA_NroGuiaSalida = Filtro.pNRGUSA_NroGuiaSalida
            .pNGUIRM_NroGuiaRemision = Filtro.pNGUIRM_NroGuiaRemision
            .pUsuario = Filtro.pUsuario
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