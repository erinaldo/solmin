Imports Ransa.NEGO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports System.ComponentModel


Public Class ucOrdenCompra_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ShowfrmImportarOcSDS()
    Public Event TrasladoDeBultos()
    Public Event DblClickOc()
    Public Event BuscarOrdenCompra()
    Public Event ImportacionMIQ()
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
    Private TD_Filtro As TD_Qry_OrdenCompra_L01 = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_Qry_OrdenCompra_L01
    Private TD_OC_Actual As TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private intNroTotalPaginas As Int32 = 0

    Private oMOCForm As ucOrdenCompra_MOC

    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
    Private strHostName As String = ""

    Public CCLNT_Pendiente_Cod_Cliente As Int64 = 0
    Public TCMPCL_Pendiente_Des_Cliente As String = ""

    Private _pCCMPN_CodCompania As String = ""
    Public Property pCCMPN_CodCompania() As String
        Get
            Return _pCCMPN_CodCompania
        End Get
        Set(ByVal value As String)
            _pCCMPN_CodCompania = value
        End Set
    End Property

#End Region
#Region " Propiedades "

    Private _pMostrarSegCarga As Boolean = True
    <Browsable(True)> _
    Public Property pMostrarSegCarga() As Boolean
        Get
            Return _pMostrarSegCarga
        End Get
        Set(ByVal value As Boolean)
            _pMostrarSegCarga = value
            If dgOrdenesCompras.Columns("IMGSEGCARGA") IsNot Nothing Then
                dgOrdenesCompras.Columns("IMGSEGCARGA").Visible = value
            End If
        End Set
    End Property
    Private _pMostrarSegAlmacen As Boolean = True
    <Browsable(True)> _
    Public Property pMostrarSegAlmacen() As Boolean
        Get
            Return _pMostrarSegCarga
        End Get
        Set(ByVal value As Boolean)
            _pMostrarSegCarga = value
            If dgOrdenesCompras.Columns("IMGSEGALM") IsNot Nothing Then
                dgOrdenesCompras.Columns("IMGSEGALM").Visible = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Cambia el cliente de la OC
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    Public Property CambiarDeCliente() As Boolean
        Get
            Return Me.btnEditar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnCambiarDeCliente.Visible = value
            Me.tssSep_005.Visible = value
        End Set
    End Property


    Private _CodCliente As Integer

    Public Property CodCliente() As Integer
        Get
            Return (_CodCliente)
        End Get
        Set(ByVal value As Integer)
            _CodCliente = value
        End Set
    End Property


    <Browsable(True)> _
    Public Property Agregar() As Boolean
        Get
            Return Me.btnAgregar.Visible

        End Get
        Set(ByVal value As Boolean)
            Me.btnAgregar.Visible = value
            Me.tssSep_003.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property Modificar() As Boolean
        Get
            Return Me.btnEditar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnEditar.Visible = value
            tssSep_01.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property Eliminar() As Boolean
        Get
            Return Me.btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnEliminar.Visible = value
            tssSep_02.Visible = value
        End Set
    End Property

    <Browsable(True)> _
   Public Property Buscar() As Boolean
        Get
            Return Me.btnBuscar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnBuscar.Visible = value
        End Set
    End Property

    'btnBuscar

    ''' <summary>
    ''' Traslado de Mercaderia de Planta X a Planta Y
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    Public Property Traslado() As Boolean
        Get
            Return Me.btnTrasladoBulto.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnTrasladoBulto.Visible = value
            tssSep_07.Visible = value
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
    Public WriteOnly Property pHostName() As String
        Set(ByVal value As String)
            strHostName = value
        End Set
    End Property


    Private _isDepositoSimple As Boolean
    Public Property isDepositoSimple() As Boolean
        Get
            Return _isDepositoSimple
        End Get
        Set(ByVal value As Boolean)
            _isDepositoSimple = value
        End Set
    End Property

    <Browsable(True)> _
     Public Property RecepcionInterfazSap() As Boolean
        Get
            Return Me.btnBuscar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnRecepcionInterfazSap.Visible = value
        End Set
    End Property

    '<Browsable(True)> _
    '  Public Property RecepcionInterfazSap() As Boolean
    '    Get
    '        Return Me.btnBuscar.Visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Me.tssSep_03.Visible = value
    '    End Set
    'End Property


#End Region
    Private _odtMovimiento As DataTable


#Region " Funciones y Procedimientos "
    Public Function ListarServicio(ByVal cclnt As Decimal, ByVal norcml As String) As DataTable
        Dim oOrdenCompra_DAL As New OrdenCompra_DAL
        Return oOrdenCompra_DAL.ListarServicio(cclnt, norcml, 0, 0)
    End Function

    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True

            dgOrdenesCompras.DataSource = cOrdenCompra.fdtListar_OrdenCompras_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_OC_Actual.pCCLNT_CodigoCliente = 0
                TD_OC_Actual.pNORCML_NroOrdenCompra = ""
                TD_OC_Actual.pNRUCPR_NroRucProveedor = ""
                TD_OC_Actual.pNOMBPR_NombreProveedor = ""
                TD_Filtro.pNROPAG_NroPagina = 1
                intNroTotalPaginas = 0
                Call pMostrarDetallePosicion()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgOrdenesCompras.RowCount > 0 Then
                    TD_OC_Actual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    TD_OC_Actual.pNORCML_NroOrdenCompra = dgOrdenesCompras.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
                    TD_OC_Actual.pNRUCPR_NroRucProveedor = dgOrdenesCompras.CurrentRow.Cells("M_NRUCPR").Value.ToString.Trim
                    TD_OC_Actual.pCPRVCL_CodProveedor = dgOrdenesCompras.CurrentRow.Cells("M_CPRVCL").Value.ToString.Trim
                    TD_OC_Actual.pNOMBPR_NombreProveedor = dgOrdenesCompras.CurrentRow.Cells("M_TPRVCL").Value.ToString.Trim
                    TD_OC_Actual.pTTINTC_TerminoIntern = dgOrdenesCompras.CurrentRow.Cells("M_TTINTC").Value.ToString.Trim
                    TD_OC_Actual.pTPOOCM_TipoOC = dgOrdenesCompras.CurrentRow.Cells("M_TPOOCM").Value.ToString.Trim
                    TD_OC_Actual.pCPRPCL_CodProvCliente = dgOrdenesCompras.CurrentRow.Cells("M_CPRPCL").Value.ToString.Trim
                    TD_OC_Actual.pSTPORL_TipoRelacion = dgOrdenesCompras.CurrentRow.Cells("M_STPORL").Value.ToString.Trim
                    TD_OC_Actual.pSFLGES_FlagEstado = dgOrdenesCompras.CurrentRow.Cells("M_SFLGES").Value.ToString.Trim

                    Call pMostrarDetallePosicion()
                    intFilaActual = 0
                    RaiseEvent CurrentRowChanged(TD_OC_Actual)
                Else
                    Call pLimpiarContenido()
                End If
            End If

            EvaluarAccesoImportar()
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
        TD_OC_Actual.pNRUCPR_NroRucProveedor = ""
        TD_OC_Actual.pNOMBPR_NombreProveedor = ""
        intFilaActual = -1
        TD_Filtro.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0

        VisualizarItemImportar(False)

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
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        RemoveHandler oMOCForm.pDisposeForm, AddressOf pDisposeFormServF01
        oMOCForm.Dispose()
        oMOCForm = Nothing
        If StatusProceso And Not objSqlManager Is Nothing And dgOrdenesCompras.RowCount > 0 Then Call pRefrescar()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ' Validamos de que haya un cliente seleccionado
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información de la Orden de Compra a editar
        oMOCForm = New ucOrdenCompra_MOC(TD_Filtro.pCCLNT_CodigoCliente, strUsuario)
        AddHandler oMOCForm.pDisposeForm, AddressOf pDisposeFormServF01
        'btnAgregar.Enabled = False
        'btnEditar.Enabled = False
        'btnEliminar.Enabled = False
        'oMOCForm.Show()
        oMOCForm.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ' Validamos de que haya una O/C seleccionado
        If TD_OC_Actual.pNORCML_NroOrdenCompra = "" Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        oMOCForm = New ucOrdenCompra_MOC(TD_OC_Actual, strUsuario)
        AddHandler oMOCForm.pDisposeForm, AddressOf pDisposeFormServF01
        'btnAgregar.Enabled = False
        'btnEditar.Enabled = False
        'btnEliminar.Enabled = False
        'oMOCForm.Show()
        oMOCForm.ShowDialog()
        'If .pRefrescarInf Then pCargarInformacion()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_OC_Actual.pNORCML_NroOrdenCompra = "" Then Exit Sub
        Dim blnCancelar As Boolean = False
        Dim strMensaje As String = "¿Desea eliminar el registro actual?"
        RaiseEvent Confirmar(strMensaje, blnCancelar)
        If blnCancelar Then Exit Sub
        If Not cOrdenCompra.Delete(objSqlManager, TD_OC_Actual, strUsuario, strMensajeError) Then
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
        VisualizarItemImportar(False)
    End Sub

    Private Sub dgOrdenesCompras_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesCompras.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgOrdenesCompras.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgOrdenesCompras.CurrentCell.RowIndex <> intFilaActual Then
            If Val(dgOrdenesCompras.Item("ESDS", dgOrdenesCompras.CurrentCell.RowIndex).Value) > 0 Then
                isDepositoSimple = True
            Else
                isDepositoSimple = False
            End If
            intFilaActual = dgOrdenesCompras.CurrentCell.RowIndex
            TD_OC_Actual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            TD_OC_Actual.pNORCML_NroOrdenCompra = dgOrdenesCompras.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
            TD_OC_Actual.pCPRVCL_CodProveedor = dgOrdenesCompras.CurrentRow.Cells("M_CPRVCL").Value.ToString.Trim
            TD_OC_Actual.pNRUCPR_NroRucProveedor = dgOrdenesCompras.CurrentRow.Cells("M_NRUCPR").Value.ToString.Trim
            TD_OC_Actual.pNOMBPR_NombreProveedor = dgOrdenesCompras.CurrentRow.Cells("M_TPRVCL").Value.ToString.Trim
            TD_OC_Actual.pTTINTC_TerminoIntern = dgOrdenesCompras.CurrentRow.Cells("M_TTINTC").Value.ToString.Trim
            TD_OC_Actual.pTPOOCM_TipoOC = dgOrdenesCompras.CurrentRow.Cells("M_TPOOCM").Value.ToString.Trim
            TD_OC_Actual.pCPRPCL_CodProvCliente = dgOrdenesCompras.CurrentRow.Cells("M_CPRPCL").Value.ToString.Trim
            TD_OC_Actual.pSTPORL_TipoRelacion = dgOrdenesCompras.CurrentRow.Cells("M_STPORL").Value.ToString.Trim
            TD_OC_Actual.pSFLGES_FlagEstado = dgOrdenesCompras.CurrentRow.Cells("M_SFLGES").Value.ToString.Trim
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
    Public Sub pActualizar(ByVal Filtro As TD_Qry_OrdenCompra_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
        TD_Filtro.pNORCML_NroOrdenCompra = Filtro.pNORCML_NroOrdenCompra
        TD_Filtro.pCPRVCL_Proveedor = Filtro.pCPRVCL_Proveedor
        TD_Filtro.pFORCML_FechaOC_Inicio = Filtro.pFORCML_FechaOC_Inicio
        TD_Filtro.pFORCML_FechaOC_Final = Filtro.pFORCML_FechaOC_Final
        TD_Filtro.pTCMPCL_DescripcionCliente = Filtro.pTCMPCL_DescripcionCliente
        TD_Filtro.pTTINTC_TermInterCarga = Filtro.pTTINTC_TermInterCarga
        TD_Filtro.pCMEDTR_MedioTransporte = Filtro.pCMEDTR_MedioTransporte
        TD_Filtro.pNREFCL_ReferenciaCliente = Filtro.pNREFCL_ReferenciaCliente
        TD_Filtro.pREFDO1_ReferenciaDocumento = Filtro.pREFDO1_ReferenciaDocumento
        TD_Filtro.pNTPDES_Prioridad = Filtro.pNTPDES_Prioridad
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

    Public Sub VisualizarImpresionPendientes(ByVal visualizar As Boolean)
        btnImprimirPendiente.Visible = visualizar
        tssSep_4.Visible = visualizar
    End Sub

#End Region

    Private Sub btnImprimirPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPendiente.Click
        Try

            Dim ofrmPendienteRecepcion As New frmPendienteOC()
            ofrmPendienteRecepcion.pUsuario = strUsuario
            ofrmPendienteRecepcion.CCLNT = CCLNT_Pendiente_Cod_Cliente
            ofrmPendienteRecepcion.TCMPCL = TCMPCL_Pendiente_Des_Cliente
            ofrmPendienteRecepcion.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

    '    Select Case TD_Filtro.pCCLNT_CodigoCliente
    '        Case 11232, 63577
    '            Dim ofrmImportarOcSDS As New frmImportarOcSDS
    '            ofrmImportarOcSDS.Cod_Cliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
    '            ofrmImportarOcSDS.strUsuario = strUsuario
    '            ofrmImportarOcSDS.ShowDialog()
    '        Case 30507, 11731
    '            Dim ofrmImportarOcSDSexcel As New frmImportarOCDeExcel
    '            ofrmImportarOcSDSexcel.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
    '            ofrmImportarOcSDSexcel.strUsuario = strUsuario
    '            ofrmImportarOcSDSexcel.ShowDialog()
    '        Case 50068
    '            Dim ofrmImportarOCTxt As New frmImportarOCTxt
    '            ofrmImportarOCTxt.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
    '            ofrmImportarOCTxt.strUsuario = strUsuario
    '            ofrmImportarOCTxt.ShowDialog()

    '        Case Else

    '            Dim ofrmImportarOc As New frmImportarOC
    '            ofrmImportarOc._strHostName = strHostName
    '            ofrmImportarOc._strUser = strUsuario
    '            ofrmImportarOc.ShowDialog()

    '    End Select
    'End Sub

    Private Sub btnCambiarDeCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarDeCliente.Click
        If Me.pCCLNT_CodigoCliente = 0 Then Exit Sub
        Dim fClienteDestino As frmClienteDestino = New frmClienteDestino
        With fClienteDestino
            .Usuario = strUsuario
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' proceso el cambio
                Dim objOrdenCompra As NEGO.slnSOLMIN_SAT.Recepcion.clsPrimaryKey_OrdenCompra = New NEGO.slnSOLMIN_SAT.Recepcion.clsPrimaryKey_OrdenCompra
                objOrdenCompra.pintCodigoCliente_CCLNT = Me.pCCLNT_CodigoCliente
                objOrdenCompra.pstrNroOrdenCompra_NORCML = pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra
                ' Procedimiento que realiza el cambio según las condiciones que tuviese
                If mfblnCambiarClienteOC(objOrdenCompra, .pintCodigoCliente_CCLNT) Then
                    pCargarInformacion()
                    'dgOrdenesCompras.Rows.Remove(dgOrdenesCompras.CurrentRow)
                End If
            End If
            .Dispose()
            fClienteDestino = Nothing
        End With
    End Sub

    ''' <summary>
    ''' Cambiar de Cliente
    ''' </summary>
    ''' <param name="objOrdenCompra"></param>
    ''' <param name="strClienteDestino"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mfblnCambiarClienteOC(ByVal objOrdenCompra As NEGO.slnSOLMIN_SAT.Recepcion.clsPrimaryKey_OrdenCompra, ByVal strClienteDestino As String) As Boolean
        Dim objRecepcion As NEGO.slnSOLMIN_SAT.Recepcion.Procesos.clsRecepcion = New NEGO.slnSOLMIN_SAT.Recepcion.Procesos.clsRecepcion(strUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objRecepcion.fblnCambiarClienteOC(strMensajeError, objOrdenCompra, strClienteDestino)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objRecepcion = Nothing
        Return blnResultado
    End Function

    Private Sub btnTrasladoBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrasladoBulto.Click
        RaiseEvent TrasladoDeBultos()
    End Sub

    Private Sub dgOrdenesCompras_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenesCompras.CellDoubleClick
        If blnCargando Then Exit Sub
        If dgOrdenesCompras.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        intFilaActual = dgOrdenesCompras.CurrentCell.RowIndex
        TD_OC_Actual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
        TD_OC_Actual.pNORCML_NroOrdenCompra = dgOrdenesCompras.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
        TD_OC_Actual.pCPRVCL_CodProveedor = dgOrdenesCompras.CurrentRow.Cells("M_CPRVCL").Value.ToString.Trim
        TD_OC_Actual.pNRUCPR_NroRucProveedor = dgOrdenesCompras.CurrentRow.Cells("M_NRUCPR").Value.ToString.Trim
        TD_OC_Actual.pNOMBPR_NombreProveedor = dgOrdenesCompras.CurrentRow.Cells("M_TPRVCL").Value.ToString.Trim
        TD_OC_Actual.pTTINTC_TerminoIntern = dgOrdenesCompras.CurrentRow.Cells("M_TTINTC").Value.ToString.Trim
        TD_OC_Actual.pTPOOCM_TipoOC = dgOrdenesCompras.CurrentRow.Cells("M_TPOOCM").Value.ToString.Trim
        TD_OC_Actual.pCPRPCL_CodProvCliente = dgOrdenesCompras.CurrentRow.Cells("M_CPRPCL").Value.ToString.Trim
        TD_OC_Actual.pSTPORL_TipoRelacion = dgOrdenesCompras.CurrentRow.Cells("M_STPORL").Value.ToString.Trim


        RaiseEvent CurrentRowChanged(TD_OC_Actual)
        RaiseEvent DblClickOc()
    End Sub

    Private Sub VisualizarItemImportar(ByVal Ver As Boolean)
        btnImportarMIQ.Visible = Ver
        btnImportABB.Visible = Ver
        btnImportPlusPetrol.Visible = Ver
        txtTXTFile.Visible = Ver
        btnImportOtros.Visible = Ver
        btnXLS_PPC.Visible = Ver
    End Sub
    Dim _pCCLIENT_CodigoClinteYRC As Decimal = 0
    Private Sub EvaluarAccesoImportar()
        Dim odaBasicClass As New clsBasicClass()
        'Dim _pCCLIENT_CodigoClinteYRC As Decimal = 0
        _pCCLIENT_CodigoClinteYRC = 0
        Dim strError As String = "Error"
        VisualizarItemImportar(False)
        _pCCLIENT_CodigoClinteYRC = odaBasicClass.fdsCodigoClienteDelPortar(objSqlManager, strError, TD_Filtro.pCCLNT_CodigoCliente.ToString)

        btnImportABB.Visible = False
        btnImportOtros.Visible = False
        btnImportarMIQ.Visible = False
        btnImportPlusPetrol.Visible = False
        txtTXTFile.Visible = False
        btnXLS_PPC.Visible = False

        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            Select Case TD_Filtro.pCCLNT_CodigoCliente
                Case 11232, 63577
                    btnImportABB.Visible = True
                    'btnImportOtros.Visible = True
                    'btnImportarMIQ.Visible = False
                    'btnImportPlusPetrol.Visible = False
                    'txtTXTFile.Visible = False
                    'btnXLS_PPC.Visible = False

                Case 30507
                    'btnImportABB.Visible = False
                    btnImportOtros.Visible = True
                    'btnImportarMIQ.Visible = False
                    btnImportPlusPetrol.Visible = True
                    'txtTXTFile.Visible = False
                    'btnXLS_PPC.Visible = False

                Case 11731
                    'btnImportABB.Visible = False
                    'btnImportOtros.Visible = False
                    'btnImportarMIQ.Visible = False
                    'btnImportPlusPetrol.Visible = False
                    'txtTXTFile.Visible = False
                    btnXLS_PPC.Visible = True

                Case 50068
                    'btnImportABB.Visible = False
                    btnImportOtros.Visible = True
                    'btnImportarMIQ.Visible = False
                    'btnImportPlusPetrol.Visible = False
                    txtTXTFile.Visible = True
                    'btnXLS_PPC.Visible = False

                Case 18541, 53694, 53695, 53525, 53526, 53527
                    'btnImportABB.Visible = False
                    'btnImportOtros.Visible = False
                    'btnImportarMIQ.Visible = False
                    'btnImportPlusPetrol.Visible = False
                    'txtTXTFile.Visible = False
                    btnImportarOutotec.Visible = True
                    'btnXLS_PPC.Visible = False


                Case Else
                    If _pCCLIENT_CodigoClinteYRC <> 0 Then
                        'btnImportABB.Visible = False
                        btnImportOtros.Visible = True
                        btnImportarMIQ.Visible = True
                        'btnImportPlusPetrol.Visible = False
                        'txtTXTFile.Visible = False
                        'btnXLS_PPC.Visible = False

                    Else
                        'btnImportABB.Visible = False
                        btnImportOtros.Visible = True
                        'btnImportarMIQ.Visible = False
                        'btnImportPlusPetrol.Visible = False
                        'txtTXTFile.Visible = False
                        'btnXLS_PPC.Visible = False
                    End If
            End Select
        End If
    End Sub

    Private Sub btnImportarMIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarMIQ.Click
        Try
            Dim ofrmImportarDatos As New frmListaOC_MIQ
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
           
            ofrmImportarDatos.pCCCLNT = TD_Filtro.pCCLNT_CodigoCliente
            ofrmImportarDatos.pCCCLNT_YRC = _pCCLIENT_CodigoClinteYRC
            ofrmImportarDatos.pUSER = strUsuario
            If ofrmImportarDatos.ShowDialog() = DialogResult.OK Then
                RaiseEvent ImportacionMIQ()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub btnImportABB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportABB.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOcSDS As New frmImportarOcSDS
            ofrmImportarOcSDS.Cod_Cliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmImportarOcSDS.strUsuario = strUsuario
            ofrmImportarOcSDS.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnImportPlusPetrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPlusPetrol.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOcSDSexcel As New frmImportarOCDeExcel
            ofrmImportarOcSDSexcel.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmImportarOcSDSexcel.strUsuario = strUsuario
            ofrmImportarOcSDSexcel.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtTXTFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTXTFile.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOCTxt As New frmImportarOCTxt
            ofrmImportarOCTxt.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmImportarOCTxt.strUsuario = strUsuario
            ofrmImportarOCTxt.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnImportOtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOtros.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOc As New frmImportarOC
            ofrmImportarOc._strHostName = strHostName
            ofrmImportarOc._strUser = strUsuario
            ofrmImportarOc.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub btnImportarOutotecMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarOutotec.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmInterfazOC As New frmInterfazOC
            ofrmInterfazOC.pCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmInterfazOC.pUsuario = strUsuario
            ofrmInterfazOC.pTerminal = strHostName
            ofrmInterfazOC.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        RaiseEvent BuscarOrdenCompra()
    End Sub

    Private Sub dgOrdenesCompras_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgOrdenesCompras.DataBindingComplete
        ' Pintar si es >0 SEGALM y SEGCARGA
        Dim SEGALM As Integer = 0
        Dim SEGCARGA As Integer = 0
        For Each oDgvrItemOC As DataGridViewRow In dgOrdenesCompras.Rows
            SEGALM = Val(oDgvrItemOC.Cells("SEGALM").Value)
            SEGCARGA = Val(oDgvrItemOC.Cells("SEGCARGA").Value)
            If SEGALM > 0 Then
                oDgvrItemOC.Cells("IMGSEGALM").Value = My.Resources.text_block
            Else
                oDgvrItemOC.Cells("IMGSEGALM").Value = My.Resources.EnBlanco
            End If
            If SEGCARGA > 0 Then
                oDgvrItemOC.Cells("IMGSEGCARGA").Value = My.Resources.text_block
            Else
                oDgvrItemOC.Cells("IMGSEGCARGA").Value = My.Resources.EnBlanco
            End If
        Next

        If dgOrdenesCompras.Rows.Count > 0 Then
            If Val(dgOrdenesCompras.Item("ESDS", 0).Value) > 0 Then
                isDepositoSimple = True
            Else
                isDepositoSimple = False
            End If
        End If

    End Sub

    Private Sub dgOrdenesCompras_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenesCompras.CellContentDoubleClick
        'Mostrar FrmMovimientoOC o FrmSeguimientoCarga

        Dim oFrmSeguimientoCarga As New Ransa.Controls.Seguimiento.FrmSeguimientoCarga
        Dim ColName As String = ""
        Try
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            If dgOrdenesCompras.Columns(dgOrdenesCompras.CurrentCell.ColumnIndex) IsNot Nothing Then
                ColName = dgOrdenesCompras.Columns(dgOrdenesCompras.CurrentCell.ColumnIndex).Name
                Select Case ColName
                    Case "IMGSEGALM"

                        If Val(dgOrdenesCompras.Item("SEGALM", e.RowIndex).Value) > 0 Then
                            If Val(dgOrdenesCompras.Item("ESDS", e.RowIndex).Value) > 0 Then

                                Dim oFrmMovimientoOC As New frmMovimientoOcSDS
                                oFrmMovimientoOC.pCCLNT = TD_OC_Actual.pCCLNT_CodigoCliente
                                oFrmMovimientoOC.pNORCML = TD_OC_Actual.pNORCML_NroOrdenCompra
                                oFrmMovimientoOC.ShowDialog()

                            Else
                                Dim oFrmMovimientoOC As New FrmMovimientoOC
                                oFrmMovimientoOC.pCCLNT = TD_OC_Actual.pCCLNT_CodigoCliente
                                oFrmMovimientoOC.pCCMPN = _pCCMPN_CodCompania
                                oFrmMovimientoOC.pNORCML = TD_OC_Actual.pNORCML_NroOrdenCompra
                                oFrmMovimientoOC.ShowDialog()
                            End If

                        End If
                    Case "IMGSEGCARGA"
                        If Val(dgOrdenesCompras.Item("SEGCARGA", e.RowIndex).Value) > 0 Then
                            oFrmSeguimientoCarga.PNCCLNT = TD_OC_Actual.pCCLNT_CodigoCliente
                            oFrmSeguimientoCarga.PSCCMPN = _pCCMPN_CodCompania
                            oFrmSeguimientoCarga.PSCDVSN = "S"
                            oFrmSeguimientoCarga.PSNORCML = TD_OC_Actual.pNORCML_NroOrdenCompra
                            oFrmSeguimientoCarga.PNNRITEM_INI = 0
                            oFrmSeguimientoCarga.PNNRITEM_FIN = 0
                            oFrmSeguimientoCarga.CASO = Val(dgOrdenesCompras.Item("SEGCARGA", e.RowIndex).Value)
                            oFrmSeguimientoCarga.ShowDialog()
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub XLSPPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXLS_PPC.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOCExcel_PPC As New frmImportarOCExcel_PPC
            ofrmImportarOCExcel_PPC.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmImportarOCExcel_PPC.strUsuario = strUsuario
            ofrmImportarOCExcel_PPC.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnArchivoXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivoXLS.Click
        Try
            If TD_Filtro.pCCLNT_CodigoCliente = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim ofrmImportarOCExcel_PPC As New frmImportarOCExcel_PPC
            ofrmImportarOCExcel_PPC.dblCodCliente = TD_Filtro.pCCLNT_CodigoCliente.ToString().Trim()
            ofrmImportarOCExcel_PPC.strUsuario = strUsuario
            ofrmImportarOCExcel_PPC.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnRecepcionInterfazSap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecepcionInterfazSap.Click
        RaiseEvent RecepcionInterfazEvent()
    End Sub

    Public Event RecepcionInterfazEvent()


End Class
