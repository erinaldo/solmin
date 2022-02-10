Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucAcopladoTransportista_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal AcopladoTransportista As TD_Inf_AcopladoTransportista_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal AcopladoTransportista As TD_Inf_AcopladoTransportista_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal AcopladoTransportista As TD_Inf_AcopladoTransportista_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oAcopladoTransportista As cAcopladoTransportista = New Ransa.DAO.Transportista.cAcopladoTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_AcopladoTransportista_L01 As TD_Qry_AcopladoTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Qry_AcopladoTransportista_L01
    Private oInf_AcopladoTransportista As TD_Inf_AcopladoTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Inf_AcopladoTransportista_L01
    Private intFilaActual As Int32 = 0
    Private intNroTotalPaginas As Int32 = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnSalirDoubleClick As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
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

    Public ReadOnly Property pSeleccion() As TD_Inf_AcopladoTransportista_L01
        Get
            Return oInf_AcopladoTransportista
        End Get
    End Property

    Public Property pNroRegPorPagina() As Int32
        Get
            Return oQry_AcopladoTransportista_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_AcopladoTransportista_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        dgAcopladoTransportista.DataSource = oAcopladoTransportista.Listar(oQry_AcopladoTransportista_L01, intNroTotalPaginas)
        blnCargando = False
        If oAcopladoTransportista.ErrorMessage <> "" Then
            oInf_AcopladoTransportista.pClear()
            oQry_AcopladoTransportista_L01.pClear()
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oAcopladoTransportista.ErrorMessage)
        Else
            If dgAcopladoTransportista.RowCount > 0 Then
                oInf_AcopladoTransportista.pCCMPN_Compania = oQry_AcopladoTransportista_L01.pCCMPN_Compania
                oInf_AcopladoTransportista.pCDVSN_Division = oQry_AcopladoTransportista_L01.pCDVSN_Division
                oInf_AcopladoTransportista.pCPLNDV_Planta = oQry_AcopladoTransportista_L01.pCPLNDV_Planta
                oInf_AcopladoTransportista.pNRUCTR_RucTransportista = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
                oInf_AcopladoTransportista.pNPLCAC_NroAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
                oInf_AcopladoTransportista.pTMRCVH_Marca = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
                oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_AcopladoTransportista)
            Else
                oInf_AcopladoTransportista.pClear()
                oQry_AcopladoTransportista_L01.pClear()
                oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgAcopladoTransportista.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el AcopladoTransportista Seleccionado
        oInf_AcopladoTransportista.pClearAll()
        intFilaActual = -1
        oQry_AcopladoTransportista_L01.pClearAll()
        oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_AcopladoTransportista_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_AcopladoTransportista_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_AcopladoTransportista_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_AcopladoTransportista_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_AcopladoTransportista_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_AcopladoTransportista_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucAcopladoTransportista_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oAcopladoTransportista.Dispose()
        oAcopladoTransportista = Nothing
    End Sub

    Private Sub dgAcopladoTransportista_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAcopladoTransportista.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgAcopladoTransportista.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgAcopladoTransportista.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgAcopladoTransportista.CurrentCell.RowIndex
            oInf_AcopladoTransportista.pCCMPN_Compania = oQry_AcopladoTransportista_L01.pCCMPN_Compania
            oInf_AcopladoTransportista.pCDVSN_Division = oQry_AcopladoTransportista_L01.pCDVSN_Division
            oInf_AcopladoTransportista.pCPLNDV_Planta = oQry_AcopladoTransportista_L01.pCPLNDV_Planta
            oInf_AcopladoTransportista.pNRUCTR_RucTransportista = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
            oInf_AcopladoTransportista.pNPLCAC_NroAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
            oInf_AcopladoTransportista.pTMRCVH_Marca = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
            oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
            RaiseEvent CurrentRowChanged(oInf_AcopladoTransportista)
        End If
    End Sub

    Private Sub dgAcopladoTransportista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAcopladoTransportista.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_AcopladoTransportista)
    End Sub

    Private Sub dgAcopladoTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgAcopladoTransportista.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_AcopladoTransportista)
    End Sub

    Private Sub txtPaginaActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim intTemp As Int32 = 0
            If Not Int32.TryParse(txtPaginaActual.Text, intTemp) Then
                Call pMostrarDetallePosicion()
            Else
                If intTemp <= 0 Then
                    RaiseEvent ErrorMessage("Posición debe ser Mayor a Cero")
                    Call pMostrarDetallePosicion()
                Else
                    If intTemp > txtNroTotalPagina.Text Then
                        RaiseEvent ErrorMessage("Posición debe ser Menor al Total de Páginas.")
                        Call pMostrarDetallePosicion()
                    Else
                        ' Actualizamos la posición actual
                        oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_AcopladoTransportista_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_AcopladoTransportista_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_AcopladoTransportista_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_AcopladoTransportista_L01.pCDVSN_Division = objFiltro.pCDVSN_Division
        oQry_AcopladoTransportista_L01.pCPLNDV_Planta = objFiltro.pCPLNDV_Planta
        oQry_AcopladoTransportista_L01.pNPLCAC_NroAcoplado = objFiltro.pNPLCAC_NroAcoplado
        oQry_AcopladoTransportista_L01.pTMRCVH_Marca = objFiltro.pTMRCVH_Marca
        oQry_AcopladoTransportista_L01.pTDEACP_DetTipoAcoplado = objFiltro.pTDEACP_DetTipoAcoplado
        oQry_AcopladoTransportista_L01.pUsuario = objFiltro.pUsuario
        oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_AcopladoTransportista_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_AcopladoTransportista_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_AcopladoTransportista_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_AcopladoTransportista_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_AcopladoTransportista_L01.pCDVSN_Division = objFiltro.pCDVSN_Division
        oQry_AcopladoTransportista_L01.pCPLNDV_Planta = objFiltro.pCPLNDV_Planta
        oQry_AcopladoTransportista_L01.pNPLCAC_NroAcoplado = objFiltro.pNPLCAC_NroAcoplado
        oQry_AcopladoTransportista_L01.pTMRCVH_Marca = objFiltro.pTMRCVH_Marca
        oQry_AcopladoTransportista_L01.pTDEACP_DetTipoAcoplado = objFiltro.pTDEACP_DetTipoAcoplado
        oQry_AcopladoTransportista_L01.pUsuario = objFiltro.pUsuario
        oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_AcopladoTransportista_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgAcopladoTransportista.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_AcopladoTransportista.pClear()
            oQry_AcopladoTransportista_L01.pClear()
            oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgAcopladoTransportista.RowCount > 0 Then
                oInf_AcopladoTransportista.pCCMPN_Compania = oQry_AcopladoTransportista_L01.pCCMPN_Compania
                oInf_AcopladoTransportista.pCDVSN_Division = oQry_AcopladoTransportista_L01.pCDVSN_Division
                oInf_AcopladoTransportista.pCPLNDV_Planta = oQry_AcopladoTransportista_L01.pCPLNDV_Planta
                oInf_AcopladoTransportista.pNRUCTR_RucTransportista = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
                oInf_AcopladoTransportista.pNPLCAC_NroAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
                oInf_AcopladoTransportista.pTMRCVH_Marca = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
                oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado = ("" & dgAcopladoTransportista.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_AcopladoTransportista)
            Else
                oInf_AcopladoTransportista.pClear()
                oQry_AcopladoTransportista_L01.pClear()
                oQry_AcopladoTransportista_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region
End Class