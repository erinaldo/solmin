Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenServicio
Imports Ransa.DAO.OrdenServicio

Public Class ucSolicOrdenServicios_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event BeforeDelte()
    Public Event AfterDelete()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal SolOrdServSelec As TD_Inf_LstSolicOrdenServPorMercaderia_F01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal SolOrdServSelec As TD_Inf_LstSolicOrdenServPorMercaderia_F01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    'Private oOrdenServicio As cOrdenServicio = New Ransa.DAO.OrdenServicio.cOrdenServicio
    Private oOrdenServicio As cOrdenServicio = New OrdenServicio.cOrdenServicio
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    'Private Qry_Filtro As TD_Qry_LstSolicOrdenServ_F01 = New Ransa.TypeDef.OrdenServicio.TD_Qry_LstSolicOrdenServ_F01
    'Private Inf_SolOrdServSelec As TD_Inf_LstSolicOrdenServPorMercaderia_F01 = New Ransa.TypeDef.OrdenServicio.TD_Inf_LstSolicOrdenServPorMercaderia_F01
    Private Qry_Filtro As TD_Qry_LstSolicOrdenServ_F01 = New OrdenServicio.TD_Qry_LstSolicOrdenServ_F01
    Private Inf_SolOrdServSelec As TD_Inf_LstSolicOrdenServPorMercaderia_F01 = New OrdenServicio.TD_Inf_LstSolicOrdenServPorMercaderia_F01
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pCurrentOrdServ() As TD_Inf_LstSolicOrdenServPorMercaderia_F01
        Get
            Return Inf_SolOrdServSelec
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If Qry_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgListaSolicOrdenesServicio.DataSource = oOrdenServicio.LstSolicOrdenServPorMercaderia_F01(Qry_Filtro, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgListaSolicOrdenesServicio.RowCount > 0 Then
                    With Inf_SolOrdServSelec
                        .pCCLNT_CodigoCliente = Qry_Filtro.pCCLNT_CodigoCliente
                        .pCMRCLR_Mercaderia = Qry_Filtro.pCMRCLR_Mercaderia
                        .pCTPDPS_TipoDeposito = Qry_Filtro.pCTPDPS_TipoDeposito
                        .pNORDSR_OrdenServicio = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NORDSR").Value
                        .pNSLCSR_NroSolicitud = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NSLCSR").Value
                        .pFRLZSR_FechaSolcitud = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_FRLZSR").Value
                        .pCMRCD_CodigoRansa = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CMRCD").Value
                        .pCTPALM_TipoAlmacen = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CTPALM").Value
                        .pCALMC_Almacen = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CALMC").Value
                        .pQTRMC_Cantidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_QTRMC").Value
                        .pCUNCN5_Unidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CUNCN5").Value
                        .pQTRMP_Peso = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_QTRMP").Value
                        .pCUNPS5_Unidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CUNPS5").Value
                        .pNGUIRN_NroGuiaRansa = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NGUIRN").Value
                        .pNGUICL_NroGuiaCliente = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NGUICL").Value
                    End With
                Else
                    Inf_SolOrdServSelec.pClear()
                End If
                RaiseEvent DataLoadCompleted(Inf_SolOrdServSelec)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgListaSolicOrdenesServicio.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        Inf_SolOrdServSelec.pClear()
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnEliminarMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarMovimiento.Click
        If dgListaSolicOrdenesServicio.RowCount <= 0 Then Exit Sub

        Dim blnCancelar As Boolean = False
        RaiseEvent Confirm("¿Desea eliminar el registro actual?", blnCancelar)
        If blnCancelar Then Exit Sub

        RaiseEvent BeforeDelte()
        Dim Inf_OrdenServicio As TD_Inf_DeleteOrdenServicio_F01 = New TD_Inf_DeleteOrdenServicio_F01
        With Inf_OrdenServicio
            .pCCLNT_CodigoCliente = Qry_Filtro.pCCLNT_CodigoCliente
            .pNORDSR_OrdenServicio = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NORDSR").Value
            .pNSLCSR_NroSolicitud = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NSLCSR").Value
            .pCTPDPS_TipoDeposito = Qry_Filtro.pCTPDPS_TipoDeposito
            .pNroDiasLimite = 4
            .pNTRMNL_NombreTerminal = Qry_Filtro.pNTRMNL_NombreTerminal
            .pUsuario = Qry_Filtro.pUsuario
        End With
        If Not oOrdenServicio.Delete(Inf_OrdenServicio, strMensajeError) Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            Call pCargarInformacion()
            RaiseEvent Message("Proceso terminó satisfactoriamente.")
            RaiseEvent AfterDelete()
        End If
    End Sub

    Private Sub ucOrdenServicios_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oOrdenServicio.Dispose()
        oOrdenServicio = Nothing
    End Sub

    Private Sub dgListaOrdenesServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgListaSolicOrdenesServicio.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgListaSolicOrdenesServicio.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgListaSolicOrdenesServicio.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgListaSolicOrdenesServicio.CurrentCell.RowIndex
            With Inf_SolOrdServSelec
                .pCCLNT_CodigoCliente = Qry_Filtro.pCCLNT_CodigoCliente
                .pCMRCLR_Mercaderia = Qry_Filtro.pCMRCLR_Mercaderia
                .pCTPDPS_TipoDeposito = Qry_Filtro.pCTPDPS_TipoDeposito
                .pNORDSR_OrdenServicio = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NORDSR").Value
                .pNSLCSR_NroSolicitud = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NSLCSR").Value
                .pFRLZSR_FechaSolcitud = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_FRLZSR").Value
                .pCMRCD_CodigoRansa = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CMRCD").Value
                .pCTPALM_TipoAlmacen = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CTPALM").Value
                .pCALMC_Almacen = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CALMC").Value
                .pQTRMC_Cantidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_QTRMC").Value
                .pCUNCN5_Unidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CUNCN5").Value
                .pQTRMP_Peso = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_QTRMP").Value
                .pCUNPS5_Unidad = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_CUNPS5").Value
                .pNGUIRN_NroGuiaRansa = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NGUIRN").Value
                .pNGUICL_NroGuiaCliente = dgListaSolicOrdenesServicio.CurrentRow.Cells("M_NGUICL").Value
            End With
            RaiseEvent CurrentRowChanged(Inf_SolOrdServSelec)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pCargar(ByVal Filtro As TD_Qry_LstSolicOrdenServ_F01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With Qry_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pCMRCLR_Mercaderia = Filtro.pCMRCLR_Mercaderia
            .pCTPDPS_TipoDeposito = Filtro.pCTPDPS_TipoDeposito
            .pNORDSR_OrdenServicio = Filtro.pNORDSR_OrdenServicio
            .pNTRMNL_NombreTerminal = Filtro.pNTRMNL_NombreTerminal
            .pUsuario = Filtro.pUsuario
        End With
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