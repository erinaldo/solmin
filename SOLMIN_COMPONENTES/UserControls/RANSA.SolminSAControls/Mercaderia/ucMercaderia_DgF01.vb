Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.TYPEDEF.Mercaderia 
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente
Imports RANSA.DATA.slnSOLMIN_SDS.DAO.Mercaderia

Public Class ucMercaderia_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Add()
    Public Event Edit(ByVal Mercaderia As TD_Inf_Mercaderia_L01)
    Public Event Delete(ByVal Mercaderia As TD_Inf_Mercaderia_L01)
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Mercaderia As TD_Inf_Mercaderia_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Mercaderia As TD_Inf_Mercaderia_L01)
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
    Private TD_Filtro As TD_Qry_Mercaderia_L01 = New TD_Qry_Mercaderia_L01
    Private TD_MercaderiaActual As TD_Inf_Mercaderia_L01 = New TD_Inf_Mercaderia_L01
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private intNroTotalPaginas As Int32 = 0
    Private pTCMPCL_RazonSocialCliente As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnMostrarInfCliente As Boolean = True
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
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

    Public ReadOnly Property pMercaderiaSeleccionada() As TD_Inf_Mercaderia_L01
        Get
            Return TD_MercaderiaActual
        End Get
    End Property

    Public WriteOnly Property pMostrarColFamilia() As Boolean
        Set(ByVal value As Boolean)
            dgMercaderia.Columns("M_CFMCLR").Visible = value
            dgMercaderia.Columns("M_TFMCLR").Visible = value
        End Set
    End Property

    Public WriteOnly Property pMostrarColGrupo() As Boolean
        Set(ByVal value As Boolean)
            dgMercaderia.Columns("M_CGRCLR").Visible = value
            dgMercaderia.Columns("M_TGRCLR").Visible = value
        End Set
    End Property

    Public WriteOnly Property pMostrarBotonesGestion() As Boolean
        Set(ByVal value As Boolean)
            ' Aplicamos los cambios a los controles
            btnAgregar.Visible = value
            tssSep_01.Visible = value
            btnEditar.Visible = value
            tssSep_02.Visible = value
            btnEliminar.Visible = value
            tssSep_03.Visible = (btnReporte.Visible And value)
        End Set
    End Property

    Public WriteOnly Property pMostrarBotonReporte() As Boolean
        Set(ByVal value As Boolean)
            ' Aplicamos los cambios a los controles
            tssSep_03.Visible = ((btnAgregar.Visible Or btnAgregar.Visible Or btnEliminar.Visible) And value)
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgMercaderia.DataSource = daoMercaderia.fdtListar_Mercaderias_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_Filtro.pNROPAG_NroPagina = 1
                intNroTotalPaginas = 0
                Call pMostrarDetallePosicion()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgMercaderia.RowCount > 0 Then
                    TD_MercaderiaActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    TD_MercaderiaActual.pCFMCLR_Familia = dgMercaderia.CurrentRow.Cells("M_CFMCLR").Value.ToString.Trim
                    TD_MercaderiaActual.pCGRCLR_Grupo = dgMercaderia.CurrentRow.Cells("M_CGRCLR").Value.ToString.Trim
                    TD_MercaderiaActual.pCMRCLR_Mercaderia = dgMercaderia.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
                    TD_MercaderiaActual.pCMRCD_CodigoRansa = dgMercaderia.CurrentRow.Cells("M_CMRCD").Value.ToString.Trim
                    intFilaActual = 0
                Else
                    TD_MercaderiaActual.pClear()
                    pTCMPCL_RazonSocialCliente = ""
                    intFilaActual = -1
                End If
                Call pMostrarDetallePosicion()
                RaiseEvent DataLoadCompleted(TD_MercaderiaActual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        lblMercadería.Text = lblMercadería.Tag
        dgMercaderia.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_MercaderiaActual.pClear()
        pTCMPCL_RazonSocialCliente = ""
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
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then RaiseEvent Add()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If TD_MercaderiaActual.pCMRCLR_Mercaderia <> "" Then RaiseEvent Edit(TD_MercaderiaActual)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgMercaderia.RowCount <= 0 Then
            RaiseEvent ErrorMessage("No existe elementos para poder ser eliminados.")
            Exit Sub
        End If

        Dim blnConfirm As Boolean = False
        RaiseEvent Confirm("Desea eliminar la Mercadería.", blnConfirm)
        If blnConfirm Then Exit Sub

        strMensajeError = ""
        Dim oTemp As TD_MercaderiaPK = New TD_MercaderiaPK
        With oTemp
            .pCCLNT_CodigoCliente = TD_MercaderiaActual.pCCLNT_CodigoCliente
            .pCMRCLR_Mercaderia = TD_MercaderiaActual.pCMRCLR_Mercaderia
        End With
        daoMercaderia.Delete(objSqlManager, oTemp, TD_Filtro.pUsuario, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            dgMercaderia.Rows.Remove(dgMercaderia.CurrentRow)
            intFilaActual = -1
            If dgMercaderia.RowCount = 0 Then
                TD_MercaderiaActual.pClear()
                pTCMPCL_RazonSocialCliente = ""
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
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

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        If Me.dgMercaderia.RowCount <= 0 Then
            RaiseEvent ErrorMessage("No existe información para generar reporte.")
            Exit Sub
        End If

        Dim rdocTemp As ReportDocument = Nothing
        Dim dtResultado As DataTable = Nothing
        strMensajeError = ""
        dtResultado = CType(dgMercaderia.DataSource, DataTable)
        dtResultado.TableName = "ucMercaderia_DgF01A"
        If strMensajeError = "" Then
            rdocTemp = New ucMercaderia_DgF01A
            rdocTemp.SetDataSource(dtResultado)
            rdocTemp.Refresh()
            rdocTemp.SetParameterValue("pCliente", TD_Filtro.pCCLNT_CodigoCliente)
            rdocTemp.SetParameterValue("pRazonSocialCliente", pTCMPCL_RazonSocialCliente)
            rdocTemp.SetParameterValue("pUsuario", TD_Filtro.pUsuario)
        End If

        Dim frmTemp As ucReportes_FVisorF01 = New ucReportes_FVisorF01(rdocTemp)
        frmTemp.ShowDialog()
    End Sub

    Private Sub ucMercaderia_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucMercaderia_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        If TD_Filtro.pREGPAG_NroRegPorPagina = 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgMercaderia_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If blnCargando Then Exit Sub
        If dgMercaderia.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgMercaderia.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgMercaderia.CurrentCell.RowIndex
            TD_MercaderiaActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            TD_MercaderiaActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            TD_MercaderiaActual.pCFMCLR_Familia = dgMercaderia.CurrentRow.Cells("M_CFMCLR").Value.ToString.Trim
            TD_MercaderiaActual.pCGRCLR_Grupo = dgMercaderia.CurrentRow.Cells("M_CGRCLR").Value.ToString.Trim
            TD_MercaderiaActual.pCMRCLR_Mercaderia = dgMercaderia.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
            TD_MercaderiaActual.pCMRCD_CodigoRansa = dgMercaderia.CurrentRow.Cells("M_CMRCD").Value.ToString.Trim
            RaiseEvent CurrentRowChanged(TD_MercaderiaActual)
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
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Mercaderia_L01)

        Dim oCliente As TD_Cliente = daoCliente.Obtener(objSqlManager, Filtro.pCCLNT_CodigoCliente, strMensajeError)
        If blnMostrarInfCliente Then
            If strMensajeError <> "" Then
                Call pLimpiarContenido()
                RaiseEvent ErrorMessage(strMensajeError)
                Exit Sub
            Else
                lblMercadería.Text = lblMercadería.Tag & " : " & Filtro.pCCLNT_CodigoCliente & " - " & oCliente.pTCMPCL_DescripcionCliente
            End If
        End If
        pTCMPCL_RazonSocialCliente = oCliente.pTCMPCL_DescripcionCliente
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        TD_Filtro.pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
        TD_Filtro.pCFMCLR_Familia = Filtro.pCFMCLR_Familia
        TD_Filtro.pCGRCLR_Grupo = Filtro.pCGRCLR_Grupo
        TD_Filtro.pCMRCLR_Mercaderia = Filtro.pCMRCLR_Mercaderia
        TD_Filtro.pUsuario = Filtro.pUsuario
        If Filtro.pNROPAG_NroPagina > 0 Then TD_Filtro.pNROPAG_NroPagina = Filtro.pNROPAG_NroPagina
        If Filtro.pREGPAG_NroRegPorPagina > 0 Then TD_Filtro.pREGPAG_NroRegPorPagina = Filtro.pREGPAG_NroRegPorPagina
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