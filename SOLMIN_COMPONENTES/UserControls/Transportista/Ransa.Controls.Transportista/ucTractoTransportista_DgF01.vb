Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucTractoTransportista_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal TractoTransportista As TD_Inf_TractoTransportista_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal TractoTransportista As TD_Inf_TractoTransportista_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal TractoTransportista As TD_Inf_TractoTransportista_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oTractoTransportista As cTractoTransportista = New Ransa.DAO.Transportista.cTractoTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_TractoTransportista_L01 As TD_Qry_TractoTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Qry_TractoTransportista_L01
    Private oInf_TractoTransportista As TD_Inf_TractoTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Inf_TractoTransportista_L01
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

    Public ReadOnly Property pSeleccion() As TD_Inf_TractoTransportista_L01
        Get
            Return oInf_TractoTransportista
        End Get
    End Property

    Public Property pNroRegPorPagina() As Int32
        Get
            Return oQry_TractoTransportista_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_TractoTransportista_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        dgTractoTransportista.DataSource = oTractoTransportista.Listar(oQry_TractoTransportista_L01, intNroTotalPaginas)
        blnCargando = False
        If oTractoTransportista.ErrorMessage <> "" Then
            oInf_TractoTransportista.pClear()
            oQry_TractoTransportista_L01.pClear()
            oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oTractoTransportista.ErrorMessage)
        Else
            If dgTractoTransportista.RowCount > 0 Then
                oInf_TractoTransportista.pNRUCTR_RucTransportista = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
                oInf_TractoTransportista.pCCMPN_Compania = ("" & dgTractoTransportista.CurrentRow.Cells("M_CCMPN").Value).ToString.Trim
                oInf_TractoTransportista.pCDVSN_Division = ("" & dgTractoTransportista.CurrentRow.Cells("M_CDVSN").Value).ToString.Trim
                oInf_TractoTransportista.pCPLNDV_Planta = dgTractoTransportista.CurrentRow.Cells("M_CPLNDV").Value

                oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
                oInf_TractoTransportista.pTMRCTR_Marca_Modelo = ("" & dgTractoTransportista.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
                oInf_TractoTransportista.pNRGMT1_NroMTC = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
                oInf_TractoTransportista.pNPLACP_NroAcoplado = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLACP").Value).ToString.Trim
                oInf_TractoTransportista.pCBRCND_Brevete = ("" & dgTractoTransportista.CurrentRow.Cells("M_CBRCND").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_TractoTransportista)
            Else
                oInf_TractoTransportista.pClear()
                oQry_TractoTransportista_L01.pClear()
                oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgTractoTransportista.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el TractoTransportista Seleccionado
        oInf_TractoTransportista.pClearAll()
        intFilaActual = -1
        oQry_TractoTransportista_L01.pClearAll()
        oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_TractoTransportista_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_TractoTransportista_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_TractoTransportista_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_TractoTransportista_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_TractoTransportista_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_TractoTransportista_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_TractoTransportista_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_TractoTransportista_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_TractoTransportista_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucTractoTransportista_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oTractoTransportista.Dispose()
        oTractoTransportista = Nothing
    End Sub

    Private Sub dgTractoTransportista_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTractoTransportista.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgTractoTransportista.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgTractoTransportista.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgTractoTransportista.CurrentCell.RowIndex
            oInf_TractoTransportista.pNRUCTR_RucTransportista = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
            oInf_TractoTransportista.pCCMPN_Compania = ("" & dgTractoTransportista.CurrentRow.Cells("M_CCMPN").Value).ToString.Trim
            oInf_TractoTransportista.pCDVSN_Division = ("" & dgTractoTransportista.CurrentRow.Cells("M_CDVSN").Value).ToString.Trim
            oInf_TractoTransportista.pCPLNDV_Planta = dgTractoTransportista.CurrentRow.Cells("M_CPLNDV").Value

            oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
            oInf_TractoTransportista.pTMRCTR_Marca_Modelo = ("" & dgTractoTransportista.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
            oInf_TractoTransportista.pNRGMT1_NroMTC = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
            oInf_TractoTransportista.pNPLACP_NroAcoplado = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLACP").Value).ToString.Trim
            oInf_TractoTransportista.pCBRCND_Brevete = ("" & dgTractoTransportista.CurrentRow.Cells("M_CBRCND").Value).ToString.Trim
            RaiseEvent CurrentRowChanged(oInf_TractoTransportista)
        End If
    End Sub

    Private Sub dgTractoTransportista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTractoTransportista.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_TractoTransportista)
    End Sub

    Private Sub dgTractoTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgTractoTransportista.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_TractoTransportista)
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
                        oQry_TractoTransportista_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_TractoTransportista_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_TractoTransportista_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_TractoTransportista_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_TractoTransportista_L01.pCDVSN_Division = objFiltro.pCDVSN_Division
        oQry_TractoTransportista_L01.pCPLNDV_Planta = objFiltro.pCPLNDV_Planta

        oQry_TractoTransportista_L01.pNPLCUN_NroPlacaUnidad = objFiltro.pNPLCUN_NroPlacaUnidad
        oQry_TractoTransportista_L01.pTMRCTR_Marca_Modelo = objFiltro.pTMRCTR_Marca_Modelo
        oQry_TractoTransportista_L01.pNRGMT1_NroMTC = objFiltro.pNRGMT1_NroMTC
        oQry_TractoTransportista_L01.pUsuario = objFiltro.pUsuario
        oQry_TractoTransportista_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_TractoTransportista_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_TractoTransportista_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_TractoTransportista_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_TractoTransportista_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_TractoTransportista_L01.pCDVSN_Division = objFiltro.pCDVSN_Division
        oQry_TractoTransportista_L01.pCPLNDV_Planta = objFiltro.pCPLNDV_Planta
        oQry_TractoTransportista_L01.pNPLCUN_NroPlacaUnidad = objFiltro.pNPLCUN_NroPlacaUnidad
        oQry_TractoTransportista_L01.pTMRCTR_Marca_Modelo = objFiltro.pTMRCTR_Marca_Modelo
        oQry_TractoTransportista_L01.pNRGMT1_NroMTC = objFiltro.pNRGMT1_NroMTC
        oQry_TractoTransportista_L01.pUsuario = objFiltro.pUsuario
        oQry_TractoTransportista_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_TractoTransportista_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgTractoTransportista.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_TractoTransportista.pClear()
            oQry_TractoTransportista_L01.pClear()
            oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgTractoTransportista.RowCount > 0 Then
                oInf_TractoTransportista.pNRUCTR_RucTransportista = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRUCTR").Value).ToString.Trim
                oInf_TractoTransportista.pCCMPN_Compania = ("" & dgTractoTransportista.CurrentRow.Cells("M_CCMPN").Value).ToString.Trim
                oInf_TractoTransportista.pCDVSN_Division = ("" & dgTractoTransportista.CurrentRow.Cells("M_CDVSN").Value).ToString.Trim
                oInf_TractoTransportista.pCPLNDV_Planta = ("" & dgTractoTransportista.CurrentRow.Cells("M_CPLNDV").Value).ToString.Trim
                oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
                oInf_TractoTransportista.pTMRCTR_Marca_Modelo = ("" & dgTractoTransportista.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
                oInf_TractoTransportista.pNRGMT1_NroMTC = ("" & dgTractoTransportista.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
                oInf_TractoTransportista.pNPLACP_NroAcoplado = ("" & dgTractoTransportista.CurrentRow.Cells("M_NPLACP").Value).ToString.Trim
                oInf_TractoTransportista.pCBRCND_Brevete = ("" & dgTractoTransportista.CurrentRow.Cells("M_CBRCND").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_TractoTransportista)
            Else
                oInf_TractoTransportista.pClear()
                oQry_TractoTransportista_L01.pClear()
                oQry_TractoTransportista_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region
End Class