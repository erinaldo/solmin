Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Waybill
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.WayBill

Public Class ucWaybill_DgF02
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Agregar()
    Public Event Eliminar(ByVal Bulto As TD_Sel_Bulto_L02)
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Bulto As TD_Sel_Bulto_L02)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Bulto As TD_Sel_Bulto_L02)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_Filtro As TD_Qry_Bulto_L02 = New TD_Qry_Bulto_L02
    Private TD_BultoActual As TD_Sel_Bulto_L02 = New TD_Sel_Bulto_L02
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property pCCLNT_CodigoCliente() As Int64
        Get
            Return TD_Filtro.pCCLNT_CodigoCliente
        End Get
        Set(ByVal value As Int64)
            If TD_Filtro.pCCLNT_CodigoCliente <> value Then pLimpiarContenido()
            TD_Filtro.pCCLNT_CodigoCliente = value
        End Set
    End Property

    Public ReadOnly Property pBultoSeleccionado() As TD_Sel_Bulto_L02
        Get
            Return TD_BultoActual
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
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
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgWayBill.DataSource = daoWayBill.fdtListar_Bultos_L02(objSqlManager, TD_Filtro, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_BultoActual.pClear()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgWayBill.RowCount > 0 Then
                    With TD_BultoActual
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_Filtro.pNOPRCN_Operacion
                        .pCREFFW_CodigoBulto = dgWayBill.CurrentRow.Cells("M_CREFFW").Value.ToString.Trim
                    End With
                    intFilaActual = 0
                Else
                    TD_BultoActual.pClear()
                    intFilaActual = -1
                End If
                RaiseEvent DataLoadCompleted(TD_BultoActual)
            End If
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
#End Region
#Region " Eventos "
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub ucWaybill_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucWaybill_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Bulto_L02)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = Filtro.pNOPRCN_Operacion
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