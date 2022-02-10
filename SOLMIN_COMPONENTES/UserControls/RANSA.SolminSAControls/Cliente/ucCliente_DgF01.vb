Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente

Public Class ucCliente_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Cliente As TD_InfBas_Cliente)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Cliente As TD_InfBas_Cliente)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Cliente As TD_InfBas_Cliente)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_Filtro As TD_ClienteL01 = New TD_ClienteL01
    Private TD_ClienteSeleccionado As TD_InfBas_Cliente = New TD_InfBas_Cliente
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

    Public ReadOnly Property pClienteSeleccionado() As TD_InfBas_Cliente
        Get
            Return TD_ClienteSeleccionado
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
        dgCliente.DataSource = daoCliente.fdtListar_Cliente_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
        blnCargando = False
        If strMensajeError <> "" Then
            TD_ClienteSeleccionado.pCCLNT_Cliente = 0
            TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = ""
            TD_ClienteSeleccionado.pNRUC_NroRUC = 0
            TD_Filtro.pNROPAG_NroPagina = 1
            intNroTotalPaginas = 0
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If dgCliente.RowCount > 0 Then
                TD_ClienteSeleccionado.pCCLNT_Cliente = dgCliente.CurrentRow.Cells("M_CCLNT").Value
                TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = ("" & dgCliente.CurrentRow.Cells("M_TCMPCL").Value).ToString.Trim
                TD_ClienteSeleccionado.pNRUC_NroRUC = dgCliente.CurrentRow.Cells("M_NRUC").Value
                intFilaActual = 0
            Else
                TD_ClienteSeleccionado.pCCLNT_Cliente = 0
                TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = ""
                TD_ClienteSeleccionado.pNRUC_NroRUC = 0
                intFilaActual = -1
            End If
            Call pMostrarDetallePosicion()
            RaiseEvent DataLoadCompleted(TD_ClienteSeleccionado)
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgCliente.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Cliente Seleccionado
        TD_ClienteSeleccionado.pCCLNT_Cliente = 0
        TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = ""
        TD_ClienteSeleccionado.pNRUC_NroRUC = 0
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

    Private Sub ucCliente_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucCliente_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        TD_Filtro.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCliente.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgCliente.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgCliente.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgCliente.CurrentCell.RowIndex
            TD_ClienteSeleccionado.pCCLNT_Cliente = dgCliente.CurrentRow.Cells("M_CCLNT").Value
            TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = ("" & dgCliente.CurrentRow.Cells("M_TCMPCL").Value).ToString.Trim
            TD_ClienteSeleccionado.pNRUC_NroRUC = dgCliente.CurrentRow.Cells("M_NRUC").Value
            RaiseEvent CurrentRowChanged(TD_ClienteSeleccionado)
        End If
    End Sub

    Private Sub dgCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCliente.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(TD_ClienteSeleccionado)
    End Sub

    Private Sub dgCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCliente.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(TD_ClienteSeleccionado)
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
    Public Sub pActualizar(ByVal objFiltro As TD_ClienteL01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCCLNT_Cliente = objFiltro.pCCLNT_Cliente
        TD_Filtro.pTCMPCL_DescripcionCliente = objFiltro.pTCMPCL_DescripcionCliente
        TD_Filtro.pNRUC_NroRUC = objFiltro.pNRUC_NroRUC
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