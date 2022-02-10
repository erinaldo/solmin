Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.TYPEDEF.OrdenCompra
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra

Public Class ucOrdenCompra_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
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
    Private TD_Filtro As TD_Qry_OrdenCompra_L01 = New TD_Qry_OrdenCompra_L01
    Private TD_OC_Actual As TD_OrdenCompraPK = New TD_OrdenCompraPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private intNroTotalPaginas As Int32 = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnMostrarInfCliente As Boolean = True
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
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

    Public Property pMostrarInfCliente() As Boolean
        Get
            Return blnMostrarInfCliente
        End Get
        Set(ByVal value As Boolean)
            blnMostrarInfCliente = value
        End Set
    End Property

    Public Property pREGPAG_NroRegPorPagina() As Int32
        Get
            Return TD_Filtro.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            TD_Filtro.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public ReadOnly Property pOrdenCompraSeleccionada() As TD_OrdenCompraPK
        Get
            Return TD_OC_Actual
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
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgOrdenesCompras.DataSource = daoOrdenCompra.fdtListar_OrdenCompras_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_OC_Actual.pCCLNT_CodigoCliente = 0
                TD_OC_Actual.pNORCML_NroOrdenCompra = ""
                TD_Filtro.pNROPAG_NroPagina = 1
                intNroTotalPaginas = 0
                Call pMostrarDetallePosicion()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgOrdenesCompras.RowCount > 0 Then
                    TD_OC_Actual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    TD_OC_Actual.pNORCML_NroOrdenCompra = dgOrdenesCompras.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
                    intFilaActual = 0
                Else
                    TD_OC_Actual.pCCLNT_CodigoCliente = 0
                    TD_OC_Actual.pNORCML_NroOrdenCompra = ""
                    intFilaActual = -1
                End If
                Call pMostrarDetallePosicion()
                RaiseEvent DataLoadCompleted(TD_OC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        lblOrdenCompra.Text = lblOrdenCompra.Tag
        dgOrdenesCompras.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra Seleccionada
        TD_OC_Actual.pCCLNT_CodigoCliente = 0
        TD_OC_Actual.pNORCML_NroOrdenCompra = ""
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
        ' Validamos de que haya un cliente seleccionado
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        Dim fOrdenCompra As ucOrdenCompra_MOC = New ucOrdenCompra_MOC
        With fOrdenCompra
            .pCliente = TD_Filtro.pCCLNT_CodigoCliente
            .pUsuario = strUsuario
            .ShowDialog()
        End With
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ' Validamos de que haya una O/C seleccionado
        If TD_OC_Actual.pNORCML_NroOrdenCompra = "" Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        Dim fOrdenCompra As ucOrdenCompra_MOC = New ucOrdenCompra_MOC
        With fOrdenCompra
            .pOrdenCompra = TD_OC_Actual
            .pUsuario = strUsuario
            .ShowDialog()
        End With
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_OC_Actual.pNORCML_NroOrdenCompra = "" Then Exit Sub
        Dim blnCancelar As Boolean = False
        Dim strMensaje As String = "¿Desea eliminar el registro actual?"
        RaiseEvent Confirmar(strMensaje, blnCancelar)
        If blnCancelar Then Exit Sub
        If Not daoOrdenCompra.Delete(objSqlManager, TD_OC_Actual, strUsuario, strMensajeError) Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            dgOrdenesCompras.Rows.Remove(dgOrdenesCompras.CurrentRow)
            RaiseEvent Message("Proceso culminó satisfactoriamente.")
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

    Private Sub ucOrdenCompra_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucOrdenCompra_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        TD_Filtro.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgOrdenesCompras_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesCompras.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgOrdenesCompras.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgOrdenesCompras.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgOrdenesCompras.CurrentCell.RowIndex
            TD_OC_Actual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            TD_OC_Actual.pNORCML_NroOrdenCompra = dgOrdenesCompras.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
            RaiseEvent CurrentRowChanged(TD_OC_Actual)
        End If
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
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_OrdenCompra_L01)
        If blnMostrarInfCliente Then
            Dim oCliente As TD_Cliente = daoCliente.Obtener(objSqlManager, Filtro.pCCLNT_CodigoCliente, strMensajeError)
            If strMensajeError <> "" Then
                Call pLimpiarContenido()
                RaiseEvent ErrorMessage(strMensajeError)
                Exit Sub
            Else
                lblOrdenCompra.Text = lblOrdenCompra.Tag & " : " & Filtro.pCCLNT_CodigoCliente & " - " & oCliente.pTCMPCL_DescripcionCliente
            End If
        End If
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
        TD_Filtro.pNORCML_NroOrdenCompra = Filtro.pNORCML_NroOrdenCompra
        TD_Filtro.pCPRVCL_Proveedor = Filtro.pCPRVCL_Proveedor
        TD_Filtro.pFORCML_FechaOC_Inicio = Filtro.pFORCML_FechaOC_Inicio
        TD_Filtro.pFORCML_FechaOC_Final = Filtro.pFORCML_FechaOC_Final
        TD_Filtro.pTCMPCL_DescripcionCliente = Filtro.pTCMPCL_DescripcionCliente
        TD_Filtro.pTTINTC_TermInterCarga = Filtro.pTTINTC_TermInterCarga
        TD_Filtro.pTDSCML_DescripcionOC = Filtro.pTDSCML_DescripcionOC
        TD_Filtro.pSITUOC_SituacionOC = Filtro.pSITUOC_SituacionOC
        If Filtro.pNROPAG_NroPagina > 0 Then
            TD_Filtro.pNROPAG_NroPagina = Filtro.pNROPAG_NroPagina
        Else
            TD_Filtro.pNROPAG_NroPagina = 1
        End If
        If Filtro.pREGPAG_NroRegPorPagina > 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = Filtro.pREGPAG_NroRegPorPagina
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
