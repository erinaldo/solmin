Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Proveedor
Imports RANSA.DATA.slnSOLMIN.DAO.Proveedor

Public Class ucProveedor_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Proveedor As TD_InfBas_Proveedor)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Proveedor As TD_InfBas_Proveedor)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Proveedor As TD_InfBas_Proveedor)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_Filtro As TD_ProveedorL01 = New TD_ProveedorL01
    Private TD_ProveedorSelec As TD_InfBas_Proveedor = New TD_InfBas_Proveedor
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private intNroTotalPaginas As Int32 = 0
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""
    Private blnSalirDoubleClick As Boolean = False
#End Region
#Region " Propiedades "
    Public Property pPermitirSalirDoubleClick() As Boolean
        Get
            Return blnSalirDoubleClick
        End Get
        Set(ByVal value As Boolean)
            blnSalirDoubleClick = value
        End Set
    End Property

    Public ReadOnly Property pProveedorSelec() As TD_InfBas_Proveedor
        Get
            Return TD_ProveedorSelec
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        strMensajeError = ""
        blnCargando = True
        dgProveedor.DataSource = daoProveedor.fdtListar_Proveedor_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
        blnCargando = False
        If strMensajeError <> "" Then
            TD_ProveedorSelec.pCPRVCL_Proveedor = 0
            TD_ProveedorSelec.pTPRVCL_DescripcionProveedor = ""
            TD_ProveedorSelec.pNRUCPR_NroRUC = 0
            TD_Filtro.pNROPAG_NroPagina = 1
            intNroTotalPaginas = 0
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If dgProveedor.RowCount > 0 Then
                TD_ProveedorSelec.pCPRVCL_Proveedor = dgProveedor.CurrentRow.Cells("M_CPRVCL").Value
                TD_ProveedorSelec.pTPRVCL_DescripcionProveedor = ("" & dgProveedor.CurrentRow.Cells("M_TPRVCL").Value).ToString.Trim
                TD_ProveedorSelec.pNRUCPR_NroRUC = dgProveedor.CurrentRow.Cells("M_NRUCPR").Value
                intFilaActual = 0
            Else
                TD_ProveedorSelec.pCPRVCL_Proveedor = 0
                TD_ProveedorSelec.pTPRVCL_DescripcionProveedor = ""
                TD_ProveedorSelec.pNRUCPR_NroRUC = 0
                intFilaActual = -1
            End If
            Call pMostrarDetallePosicion()
            RaiseEvent DataLoadCompleted(TD_ProveedorSelec)
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgProveedor.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Proveedor Seleccionado
        TD_ProveedorSelec.pCPRVCL_Proveedor = 0
        TD_ProveedorSelec.pTPRVCL_DescripcionProveedor = ""
        TD_ProveedorSelec.pNRUCPR_NroRUC = 0
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

    Private Sub ucProveedor_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucProveedor_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        TD_Filtro.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgProveedor_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProveedor.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgProveedor.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgProveedor.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgProveedor.CurrentCell.RowIndex
            TD_ProveedorSelec.pCPRVCL_Proveedor = dgProveedor.CurrentRow.Cells("M_CPRVCL").Value
            TD_ProveedorSelec.pTPRVCL_DescripcionProveedor = ("" & dgProveedor.CurrentRow.Cells("M_TPRVCL").Value).ToString.Trim
            TD_ProveedorSelec.pNRUCPR_NroRUC = dgProveedor.CurrentRow.Cells("M_NRUCPR").Value
            RaiseEvent CurrentRowChanged(TD_ProveedorSelec)
        End If
    End Sub

    Private Sub dgProveedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProveedor.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(TD_ProveedorSelec)
    End Sub

    Private Sub dgProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(TD_ProveedorSelec)
    End Sub

    Private Sub txtPaginaActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim intTemp As Int32 = 0
            If Not Int32.TryParse(txtPaginaActual.Text, intTemp) Then
                Call pMostrarDetallePosicion()
            Else
                If intTemp <= 0 Then strMensajeError = "Posición debe ser Mayor a Cero"
                If intTemp > txtNroTotalPagina.Text Then strMensajeError = "Posición debe ser Menor al Total de Páginas."
                If strMensajeError <> "" Then
                    RaiseEvent ErrorMessage(strMensajeError)
                    Call pMostrarDetallePosicion()
                Else
                    ' Actualizamos la posición actual
                    TD_Filtro.pNROPAG_NroPagina = intTemp
                    ' Llamada al procedimiento de carga de información
                    Call pCargarInformacion()
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_ProveedorL01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCPRVCL_Proveedor = objFiltro.pCPRVCL_Proveedor
        TD_Filtro.pTPRVCL_DescripcionProveedor = objFiltro.pTPRVCL_DescripcionProveedor
        TD_Filtro.pNRUCPR_NroRUC = objFiltro.pNRUCPR_NroRUC
        TD_Filtro.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        TD_Filtro.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
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