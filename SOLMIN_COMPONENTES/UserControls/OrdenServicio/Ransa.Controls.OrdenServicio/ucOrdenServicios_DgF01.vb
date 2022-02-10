Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.OrdenServicio
'Imports Ransa.DAO.OrdenServicio

Public Class ucOrdenServicios_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal OrdServSelec As TD_Inf_LstOrdenServPorMercaderia_F01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal OrdServSelec As TD_Inf_LstOrdenServPorMercaderia_F01)
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
    'Private Qry_Filtro As TD_Qry_LstOrdenServPorMercaderia_F01 = New Ransa.TypeDef.OrdenServicio.TD_Qry_LstOrdenServPorMercaderia_F01
    'Private Inf_OrdServSelec As TD_Inf_LstOrdenServPorMercaderia_F01 = New Ransa.TypeDef.OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01
    Private Qry_Filtro As TD_Qry_LstOrdenServPorMercaderia_F01 = New OrdenServicio.TD_Qry_LstOrdenServPorMercaderia_F01
    Private Inf_OrdServSelec As TD_Inf_LstOrdenServPorMercaderia_F01 = New OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01
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
    Public ReadOnly Property pCurrentOrdServ() As TD_Inf_LstOrdenServPorMercaderia_F01
        Get
            Return Inf_OrdServSelec
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If Qry_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgListaOrdenesServicio.DataSource = oOrdenServicio.LstOrdenServPorMercaderia_F01(Qry_Filtro, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgListaOrdenesServicio.RowCount > 0 Then
                    With Inf_OrdServSelec
                        .pCCLNT_CodigoCliente = Qry_Filtro.pCCLNT_CodigoCliente
                        .pNORDSR_OrdenServicio = dgListaOrdenesServicio.CurrentRow.Cells("M_NORDSR").Value
                        .pCMRCLR_Mercaderia = Qry_Filtro.pCMRCLR_Mercaderia
                        .pCTPDPS_TipoDeposito = Qry_Filtro.pCTPDPS_TipoDeposito
                        .pQMRCD1_CantidadDeclarada = dgListaOrdenesServicio.CurrentRow.Cells("M_QMRCD1").Value
                        .pQPSMR1_PesoDeclarado = dgListaOrdenesServicio.CurrentRow.Cells("M_QPSMR1").Value
                        .pQVLMR1_ValorDeclarado = dgListaOrdenesServicio.CurrentRow.Cells("M_QVLMR1").Value
                        .pFUNDS2_UnidadDespacho = dgListaOrdenesServicio.CurrentRow.Cells("M_FUNDS2").Value
                    End With
                Else
                    Inf_OrdServSelec.pClear()
                End If
                RaiseEvent DataLoadCompleted(Inf_OrdServSelec)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgListaOrdenesServicio.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        Inf_OrdServSelec.pClear()
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub ucOrdenServicios_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oOrdenServicio.Dispose()
        oOrdenServicio = Nothing
    End Sub

    Private Sub dgListaOrdenesServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgListaOrdenesServicio.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgListaOrdenesServicio.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgListaOrdenesServicio.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgListaOrdenesServicio.CurrentCell.RowIndex
            With Inf_OrdServSelec
                .pCCLNT_CodigoCliente = Qry_Filtro.pCCLNT_CodigoCliente
                .pNORDSR_OrdenServicio = dgListaOrdenesServicio.CurrentRow.Cells("M_NORDSR").Value
                .pCMRCLR_Mercaderia = Qry_Filtro.pCMRCLR_Mercaderia
                .pCTPDPS_TipoDeposito = Qry_Filtro.pCTPDPS_TipoDeposito
                .pQMRCD1_CantidadDeclarada = dgListaOrdenesServicio.CurrentRow.Cells("M_QMRCD1").Value
                .pQPSMR1_PesoDeclarado = dgListaOrdenesServicio.CurrentRow.Cells("M_QPSMR1").Value
                .pQVLMR1_ValorDeclarado = dgListaOrdenesServicio.CurrentRow.Cells("M_QVLMR1").Value
                .pFUNDS2_UnidadDespacho = dgListaOrdenesServicio.CurrentRow.Cells("M_FUNDS2").Value
            End With
            RaiseEvent CurrentRowChanged(Inf_OrdServSelec)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pCargar(ByVal Filtro As TD_Qry_LstOrdenServPorMercaderia_F01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With Qry_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pCMRCLR_Mercaderia = Filtro.pCMRCLR_Mercaderia
            .pCTPDPS_TipoDeposito = Filtro.pCTPDPS_TipoDeposito
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