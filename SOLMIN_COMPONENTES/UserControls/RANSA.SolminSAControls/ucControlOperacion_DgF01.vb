Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.ControlOperacion
Imports RANSA.DATA.slnSOLMIN.DAO.ControlOperacion

Public Class ucControlOperacion_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal ControlOperacion As TD_ControlOperacion)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal ControlOperacion As TD_ControlOperacion)
    Public Event ErrorMessage(ByVal ErrorMensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private oFiltro As TD_Qry_CtrlOperacion = New TD_Qry_CtrlOperacion
    Private oControlOperacion As TD_ControlOperacion = New TD_ControlOperacion
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pRegSeleccionado() As TD_ControlOperacion
        Get
            Return oControlOperacion
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pObtenerItemSeleccionado()
        With oControlOperacion
            .pSTPODP_TipoAlmacen = dgControlOperaciones.CurrentRow.Cells("M_STPODP").Value.ToString.Trim
            .pCTPOAT_TipoOperacion = dgControlOperaciones.CurrentRow.Cells("M_CTPOAT").Value.ToString.Trim
            Date.TryParse(dgControlOperaciones.CurrentRow.Cells("M_FTRMOP").Value, .pFTRMOP_FechaCierre)
            Int64.TryParse(dgControlOperaciones.CurrentRow.Cells("M_CCLNT").Value, .pCCLNT_CodigoCliente)
            Int64.TryParse(dgControlOperaciones.CurrentRow.Cells("M_NOPRSP").Value, .pNOPRSP_NroOperacion)
            Decimal.TryParse(dgControlOperaciones.CurrentRow.Cells("M_QQBLTO").Value, .pQQBLTO_TotalBultos)
            Decimal.TryParse(dgControlOperaciones.CurrentRow.Cells("M_QQPESO").Value, .pQQPESO_TotalPeso)
            Decimal.TryParse(dgControlOperaciones.CurrentRow.Cells("M_QTAMOV").Value, .pQTAMOV_TotalMovimiento)
        End With
    End Sub

    Private Sub pLimpiarItemSeleccionado()
        With oControlOperacion
            .pSTPODP_TipoAlmacen = ""
            .pCTPOAT_TipoOperacion = ""
            .pFTRMOP_FechaCierre = New Date
            .pCCLNT_CodigoCliente = 0
            .pNOPRSP_NroOperacion = 0
            .pQQBLTO_TotalBultos = 0
            .pQQPESO_TotalPeso = 0
            .pQTAMOV_TotalMovimiento = 0
        End With
    End Sub

    Private Sub pCargarInformacion()
        If oFiltro.pSTPODP_TipoAlmacen <> "" And oFiltro.pCTPOAT_TipoOperacion <> "" And oFiltro.pFTRMOP_FechaCierre_Int > 0 Then
            strMensajeError = ""
            blnCargando = True
            dgControlOperaciones.DataSource = daoControlOperacion.fdtListar_ResumenMovimiento_L01(objSqlManager, oFiltro, strMensajeError)
            blnCargando = False
            With oControlOperacion
                If strMensajeError <> "" Then
                    Call pLimpiarItemSeleccionado()
                    RaiseEvent ErrorMessage(strMensajeError)
                Else
                    If dgControlOperaciones.RowCount > 0 Then
                        Call pObtenerItemSeleccionado()
                        intFilaActual = 0
                    Else
                        call pLimpiarItemSeleccionado()
                        intFilaActual = -1
                    End If
                    RaiseEvent DataLoadCompleted(oControlOperacion)
                End If
            End With
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgControlOperaciones.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la inf. del Control Operacion Seleccionada
        call pLimpiarItemSeleccionado()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnCerrarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarOperacion.Click
        ' Validamos de que exista información
        If dgControlOperaciones.RowCount > 0 Then
            Dim intCont As Int32 = 0
            While intCont < dgControlOperaciones.RowCount
                If dgControlOperaciones.Rows(intCont).Cells("M_CHK").Value Then
                    Dim oControl As TD_ControlOperacionPK01 = New TD_ControlOperacionPK01
                    With oControl
                        .pCCLNT_CodigoCliente = dgControlOperaciones.Rows(intCont).Cells("M_CCLNT").Value
                        .pSTPODP_TipoAlmacen = oFiltro.pSTPODP_TipoAlmacen
                        .pCTPOAT_TipoOperacion = oFiltro.pCTPOAT_TipoOperacion
                        .pFTRMOP_FechaCierre = oFiltro.pFTRMOP_FechaCierre
                    End With
                    dgControlOperaciones.Rows(intCont).Cells("M_NOPRSP").Value = daoControlOperacion.Grabar(objSqlManager, oControl, strUsuario, strMensajeError)
                    If strMensajeError <> "" Then
                        RaiseEvent ErrorMessage(strMensajeError & vbNewLine & vbNewLine & "Proceso se cancelo...!!!")
                        Exit While
                    Else
                        dgControlOperaciones.Rows(intCont).Cells("M_CHK").Value = False
                    End If
                End If
                intCont += 1
            End While
            Call pObtenerItemSeleccionado()
        End If
    End Sub

    Private Sub btnAbrirOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirOperacion.Click
        ' Validamos de que exista información
        If dgControlOperaciones.RowCount > 0 Then
            If dgControlOperaciones.CurrentRow.Cells("M_NOPRSP").Value > 0 Then
                Dim blnCancelar As Boolean = False
                RaiseEvent Confirmar("¿ Desea Re-Abrir la Operación ?", blnCancelar)
                If blnCancelar Then Exit Sub
                Dim oControl As TD_ControlOperacionPK02 = New TD_ControlOperacionPK02
                With oControl
                    .pCCLNT_CodigoCliente = dgControlOperaciones.CurrentRow.Cells("M_CCLNT").Value
                    .pSTPODP_TipoAlmacen = oFiltro.pSTPODP_TipoAlmacen
                    .pCTPOAT_TipoOperacion = oFiltro.pCTPOAT_TipoOperacion
                    .pNOPRSP_NroOperacion = dgControlOperaciones.CurrentRow.Cells("M_NOPRSP").Value
                End With
                daoControlOperacion.Delete(objSqlManager, oControl, strUsuario, strMensajeError)
                If strMensajeError <> "" Then
                    RaiseEvent ErrorMessage(strMensajeError & vbNewLine & vbNewLine & "Proceso se cancelo...!!!")
                Else
                    dgControlOperaciones.CurrentRow.Cells("M_NOPRSP").Value = 0
                    RaiseEvent Message("Proceso culminó satisfactoriamente.")
                End If
            End If
        End If
    End Sub
    
    Private Sub ucControlOperacion_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucControlOperacion_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
    End Sub

    Private Sub dgControlOperaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgControlOperaciones.CellContentClick
        If blnCargando Then Exit Sub
        With dgControlOperaciones
            If .RowCount > 0 Then
                If e.ColumnIndex = 0 And .CurrentRow.Cells("M_NOPRSP").Value = 0 Then
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                    Else
                        .CurrentCell.Value = True
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub dgControlOperaciones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgControlOperaciones.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgControlOperaciones.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgControlOperaciones.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgControlOperaciones.CurrentCell.RowIndex
            Call pObtenerItemSeleccionado()
            RaiseEvent CurrentRowChanged(oControlOperacion)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal TD_Filtro As TD_Qry_CtrlOperacion)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oFiltro.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
        oFiltro.pCTPOAT_TipoOperacion = TD_Filtro.pCTPOAT_TipoOperacion
        oFiltro.pFTRMOP_FechaCierre = TD_Filtro.pFTRMOP_FechaCierre
        oFiltro.pSTPODP_TipoAlmacen = TD_Filtro.pSTPODP_TipoAlmacen
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
