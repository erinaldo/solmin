Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.TYPEDEF.Servicios
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente
Imports RANSA.DATA.slnSOLMIN_SA.DAO.Servicios

Public Class ucServicios_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal Mensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirm(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event SaveEnd()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Servicio As TD_Inf_Servicio_F03)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Servicio As TD_Inf_Servicio_F03)
    Public Event CurrentOperationNumberChanged(ByVal Servicio As TD_Inf_Servicio_F03)
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
    Private TD_Filtro As TD_Qry_Servicios_Adquiridos_L01 = New TD_Qry_Servicios_Adquiridos_L01
    Private TD_InfServF03 As TD_Inf_Servicio_F03 = New TD_Inf_Servicio_F03
    Private intFilaActual As Int32 = 0
    Private intNroOperacion As Int64 = 0
    Private intNroTotalPaginas As Int32 = 0
    Private strMensajeError As String = ""
    Private lstIndexCbx As List(Of Int32) = New List(Of Int32)
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property NroRegPorPagina() As Int32
        Get
            Return TD_Filtro.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            TD_Filtro.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public ReadOnly Property pServicioSeleccionado() As TD_Inf_Servicio_F03
        Get
            Return TD_InfServF03
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarFormGestion(ByVal TD_InfServF01 As TD_Inf_Servicio_F01)
        Dim fServF01 As ucServicios_FServF01 = New ucServicios_FServF01(TD_InfServF01)
        AddHandler fServF01.Message, AddressOf pHandler_Mensaje
        AddHandler fServF01.ErrorMessage, AddressOf pHandler_ErrorMessage
        AddHandler fServF01.Confirm, AddressOf pHandler_Confirmar
        AddHandler fServF01.SaveEnd, AddressOf pHandler_SaveEnd
        fServF01.ShowDialog()
        RemoveHandler fServF01.Message, AddressOf pHandler_Mensaje
        RemoveHandler fServF01.ErrorMessage, AddressOf pHandler_ErrorMessage
        RemoveHandler fServF01.Confirm, AddressOf pHandler_Confirmar
        RemoveHandler fServF01.SaveEnd, AddressOf pHandler_SaveEnd
    End Sub

    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente = 0 Then Exit Sub
        strMensajeError = ""
        blnCargando = True
        dgServicio.DataSource = daoServicio.fdtListar_Servicios_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
        blnCargando = False
        If strMensajeError <> "" Then
            TD_Filtro.pNROPAG_NroPagina = 1
            TD_InfServF03.pClear()
            intNroTotalPaginas = 0
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If dgServicio.RowCount > 0 Then
                With TD_InfServF03
                    .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    .pNOPRCN_Operacion = dgServicio.CurrentRow.Cells("M_NOPRCN").Value
                    .pFOPRCN_FechaOperacion = dgServicio.CurrentRow.Cells("M_FOPRCN").Value
                    .pNRTFSV_Tarifa = dgServicio.CurrentRow.Cells("M_NRTFSV").Value
                    .pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
                    .pSTIPPR_Proceso = dgServicio.CurrentRow.Cells("M_STIPPR").Value.ToString.Trim
                End With
                intFilaActual = 0
                intNroOperacion = dgServicio.CurrentRow.Cells("M_NOPRCN").Value
                RaiseEvent DataLoadCompleted(TD_InfServF03)
            Else
                TD_InfServF03.pClear()
                intFilaActual = -1
                intNroOperacion = 0
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        lblServicio.Text = lblServicio.Tag
        dgServicio.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_InfServF03.pClear()
        intFilaActual = -1
        intNroOperacion = 0
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

    Private Sub pHandler_Mensaje(ByVal strMensaje As String)
        RaiseEvent Message(strMensaje)
    End Sub

    Private Sub pHandler_Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
        RaiseEvent Confirm(strPregunta, blnCancelar)
    End Sub

    Private Sub pHandler_ErrorMessage(ByVal strMensaje As String)
        RaiseEvent ErrorMessage(strMensaje)
    End Sub

    Private Sub pHandler_SaveEnd()
        Call pCargarInformacion()
        RaiseEvent SaveEnd()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If cbxPlanta.SelectedIndex < 0 Then
            RaiseEvent ErrorMessage("Debe seleccionar una planta.")
            Exit Sub
        End If
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            Dim TD_InfServF01 As TD_Inf_Servicio_F01 = New TD_Inf_Servicio_F01
            With TD_InfServF01
                .pCCMPN_Compania = TD_Filtro.pCCMPN_Compania
                .pCDVSN_Division = TD_Filtro.pCDVSN_Division
                .pCPLNDV_Planta = lstIndexCbx.Item(cbxPlanta.SelectedIndex)
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                .pFOPRCN_FechaOperacion = Date.Now
                .pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
                .pUsuario = TD_Filtro.pUsuario
                Call pCargarFormGestion(TD_InfServF01)
            End With
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If cbxPlanta.SelectedIndex < 0 Then
            RaiseEvent ErrorMessage("Debe seleccionar una planta.")
            Exit Sub
        End If
        If TD_InfServF03.pNOPRCN_Operacion <> 0 Then
            Dim TD_InfServF01 As TD_Inf_Servicio_F01 = New TD_Inf_Servicio_F01
            With TD_InfServF01
                .pCCMPN_Compania = dgServicio.CurrentRow.Cells("M_CCMPN").Value.ToString.Trim
                .pCDVSN_Division = dgServicio.CurrentRow.Cells("M_CDVSN").Value.ToString.Trim
                .pCPLNDV_Planta = lstIndexCbx.Item(cbxPlanta.SelectedIndex)
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                .pNOPRCN_Operacion = TD_InfServF03.pNOPRCN_Operacion
                .pFOPRCN_FechaOperacion = TD_InfServF03.pFOPRCN_FechaOperacion
                .pSTPODP_TipoSistAlm = TD_InfServF03.pSTPODP_TipoSistAlm
                .pSTIPPR_Proceso = TD_InfServF03.pSTIPPR_Proceso
                .pCCLNFC_ClienteFacturar = dgServicio.CurrentRow.Cells("M_CCLNFC").Value.ToString.Trim
                .pCPRCN1_Contenedor = dgServicio.CurrentRow.Cells("M_CPRCN1").Value.ToString.Trim
                .pNSRCN1_SerieContenedor = dgServicio.CurrentRow.Cells("M_NSRCN1").Value.ToString.Trim
                .pUsuario = TD_Filtro.pUsuario
                Call pCargarFormGestion(TD_InfServF01)
            End With
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgServicio.RowCount <= 0 Then
            RaiseEvent ErrorMessage("No existe elementos Servicios para poder ser eliminados.")
            Exit Sub
        End If
        Dim oServAdquPK As TD_Servicio_AdquiridoPK = New TD_Servicio_AdquiridoPK
        Dim strStatus As String = ""
        With oServAdquPK
            .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = TD_InfServF03.pNOPRCN_Operacion
            .pNRTFSV_Tarifa_Servicio = TD_InfServF03.pNRTFSV_Tarifa
            If daoServicio.EliminarServicioAdquirido(objSqlManager, oServAdquPK, TD_Filtro.pUsuario, strStatus, strMensajeError) Then
                If strStatus = "S" Then RaiseEvent Message("Toda la información asociada a la Operación, fue eliminada.")
                dgServicio.Rows.Remove(dgServicio.CurrentRow)
                If dgServicio.RowCount = 0 Then RaiseEvent TableWithOutData()
            Else
                RaiseEvent ErrorMessage(strMensajeError)
                Exit Sub
            End If
        End With
        RaiseEvent Message("Proceso culminó satisfactoriamente.")
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

    Private Sub ucServicios_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucServicios_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        TD_Filtro.pNROPAG_NroPagina = 1
        TD_Filtro.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgServicio.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgServicio.CurrentCell Is Nothing Then
            intFilaActual = -1
            intNroOperacion = 0
            Exit Sub
        End If
        If dgServicio.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgServicio.CurrentCell.RowIndex
            With TD_InfServF03
                .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                .pNOPRCN_Operacion = dgServicio.CurrentRow.Cells("M_NOPRCN").Value
                .pFOPRCN_FechaOperacion = dgServicio.CurrentRow.Cells("M_FOPRCN").Value
                .pNRTFSV_Tarifa = dgServicio.CurrentRow.Cells("M_NRTFSV").Value
                .pSTPODP_TipoSistAlm = TD_Filtro.pSTPODP_TipoSistAlm
                .pSTIPPR_Proceso = dgServicio.CurrentRow.Cells("M_STIPPR").Value.ToString.Trim
                ' Verifico que el Nro de Operación sea distinto al que tengo registrado
                If intNroOperacion <> .pNOPRCN_Operacion Then
                    intNroOperacion = .pNOPRCN_Operacion
                    RaiseEvent CurrentOperationNumberChanged(TD_InfServF03)
                End If
            End With

            RaiseEvent CurrentRowChanged(TD_InfServF03)
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
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Servicios_Adquiridos_L01, ByVal dtPlantasUsuario As DataTable)
        ' Llenamos las plantas correspondientes al usuario
        Dim rwTemp As DataRow
        Dim intIndex As Integer = 0
        cbxPlanta.Items.Clear()
        lstIndexCbx.Clear()
        For Each rwTemp In dtPlantasUsuario.Rows
            cbxPlanta.Items.Add(rwTemp("CPLNDV") & " - " & rwTemp("TPLNTA").ToString.Trim)
            lstIndexCbx.Add(rwTemp("CPLNDV"))
        Next
        If lstIndexCbx.Count > 0 Then cbxPlanta.SelectedIndex = 0
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_Filtro
            .pCCMPN_Compania = Filtro.pCCMPN_Compania
            .pCDVSN_Division = Filtro.pCDVSN_Division
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = Filtro.pNOPRCN_Operacion
            .pSTPODP_TipoSistAlm = Filtro.pSTPODP_TipoSistAlm
            .pCSRVNV_Servicio = Filtro.pCSRVNV_Servicio
            .pFOPRCN_FechaOperacion_Ini = Filtro.pFOPRCN_FechaOperacion_Ini
            .pFOPRCN_FechaOperacion_Fin = Filtro.pFOPRCN_FechaOperacion_Fin
            .pUsuario = Filtro.pUsuario
        End With
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