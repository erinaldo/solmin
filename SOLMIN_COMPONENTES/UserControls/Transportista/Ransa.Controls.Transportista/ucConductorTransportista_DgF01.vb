Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucConductorTransportista_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Conductor As TD_Inf_ConductorTransportista_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Conductor As TD_Inf_ConductorTransportista_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Conductor As TD_Inf_ConductorTransportista_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oConductor As cConductorTransportista = New Ransa.DAO.Transportista.cConductorTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_Conductor_L01 As TD_Qry_ConductorTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Qry_ConductorTransportista_L01
    Private oInf_Conductor As TD_Inf_ConductorTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Inf_ConductorTransportista_L01
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

    Public ReadOnly Property pSeleccion() As TD_Inf_ConductorTransportista_L01
        Get
            Return oInf_Conductor
        End Get
    End Property

    Public Property pNroRegPorPagina() As Int32
        Get
            Return oQry_Conductor_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Conductor_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        dgConductor.DataSource = oConductor.Listar(oQry_Conductor_L01, intNroTotalPaginas)
        blnCargando = False
        If oConductor.ErrorMessage <> "" Then
            oInf_Conductor.pClear()
            oQry_Conductor_L01.pClear()
            oQry_Conductor_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oConductor.ErrorMessage)
        Else
            If dgConductor.RowCount > 0 Then
                oInf_Conductor.pCCMPN_Compania = oQry_Conductor_L01.pCCMPN_Compania
                oInf_Conductor.pCBRCNT_Brevete = ("" & dgConductor.CurrentRow.Cells("M_CBRCNT").Value).ToString.Trim
                oInf_Conductor.pTNMCMC_NombreChofer = ("" & dgConductor.CurrentRow.Cells("M_TNMCMC").Value).ToString.Trim
                oInf_Conductor.pAPEPAT_ApPaterno = ("" & dgConductor.CurrentRow.Cells("M_APEPAT").Value).ToString.Trim
                oInf_Conductor.pAPEMAT_ApMaterno = ("" & dgConductor.CurrentRow.Cells("M_APEMAT").Value).ToString.Trim
                oInf_Conductor.pSINDRC_StatusRecurso = ("" & dgConductor.CurrentRow.Cells("M_SINDRC").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Conductor)
            Else
                oInf_Conductor.pClear()
                oQry_Conductor_L01.pClear()
                oQry_Conductor_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgConductor.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Conductor Seleccionado
        oInf_Conductor.pClearAll()
        intFilaActual = -1
        oQry_Conductor_L01.pClearAll()
        oQry_Conductor_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_Conductor_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_Conductor_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_Conductor_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_Conductor_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_Conductor_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_Conductor_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_Conductor_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Conductor_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_Conductor_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Conductor_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucConductor_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oConductor.Dispose()
        oConductor = Nothing
    End Sub

    Private Sub dgConductor_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgConductor.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgConductor.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgConductor.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgConductor.CurrentCell.RowIndex
            oInf_Conductor.pCCMPN_Compania = oQry_Conductor_L01.pCCMPN_Compania
            oInf_Conductor.pCBRCNT_Brevete = ("" & dgConductor.CurrentRow.Cells("M_CBRCNT").Value).ToString.Trim
            oInf_Conductor.pTNMCMC_NombreChofer = ("" & dgConductor.CurrentRow.Cells("M_TNMCMC").Value).ToString.Trim
            oInf_Conductor.pAPEPAT_ApPaterno = ("" & dgConductor.CurrentRow.Cells("M_APEPAT").Value).ToString.Trim
            oInf_Conductor.pAPEMAT_ApMaterno = ("" & dgConductor.CurrentRow.Cells("M_APEMAT").Value).ToString.Trim
            oInf_Conductor.pSINDRC_StatusRecurso = ("" & dgConductor.CurrentRow.Cells("M_SINDRC").Value).ToString.Trim
            RaiseEvent CurrentRowChanged(oInf_Conductor)
        End If
    End Sub

    Private Sub dgConductor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgConductor.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Conductor)
    End Sub

    Private Sub dgConductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgConductor.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Conductor)
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
                        oQry_Conductor_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_ConductorTransportista_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Conductor_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Conductor_L01.pCDVSN = objFiltro.pCDVSN
        oQry_Conductor_L01.pPlanta = objFiltro.pPlanta
        oQry_Conductor_L01.pCBRCNT_Brevete = objFiltro.pCBRCNT_Brevete
        oQry_Conductor_L01.pNombreApellidoChofer = objFiltro.pNombreApellidoChofer
        oQry_Conductor_L01.pSINDRC_StatusRecurso = objFiltro.pSINDRC_StatusRecurso
        oQry_Conductor_L01.pUsuario = objFiltro.pUsuario
        oQry_Conductor_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_Conductor_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Conductor_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_ConductorTransportista_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Conductor_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Conductor_L01.pCDVSN = objFiltro.pCDVSN
        oQry_Conductor_L01.pCBRCNT_Brevete = objFiltro.pCBRCNT_Brevete
        oQry_Conductor_L01.pNombreApellidoChofer = objFiltro.pNombreApellidoChofer
        oQry_Conductor_L01.pSINDRC_StatusRecurso = objFiltro.pSINDRC_StatusRecurso
        oQry_Conductor_L01.pPlanta = objFiltro.pPlanta
        oQry_Conductor_L01.pNRUCTR_RucTransportista = objFiltro.pNRUCTR_RucTransportista
        oQry_Conductor_L01.pUsuario = objFiltro.pUsuario
        oQry_Conductor_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Conductor_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgConductor.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_Conductor.pClear()
            oQry_Conductor_L01.pClear()
            oQry_Conductor_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgConductor.RowCount > 0 Then
                oInf_Conductor.pCCMPN_Compania = oQry_Conductor_L01.pCCMPN_Compania
                oInf_Conductor.pCBRCNT_Brevete = ("" & dgConductor.CurrentRow.Cells("M_CBRCNT").Value).ToString.Trim
                oInf_Conductor.pTNMCMC_NombreChofer = ("" & dgConductor.CurrentRow.Cells("M_TNMCMC").Value).ToString.Trim
                oInf_Conductor.pAPEPAT_ApPaterno = ("" & dgConductor.CurrentRow.Cells("M_APEPAT").Value).ToString.Trim
                oInf_Conductor.pAPEMAT_ApMaterno = ("" & dgConductor.CurrentRow.Cells("M_APEMAT").Value).ToString.Trim
                oInf_Conductor.pSINDRC_StatusRecurso = ("" & dgConductor.CurrentRow.Cells("M_SINDRC").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Conductor)
            Else
                oInf_Conductor.pClear()
                oQry_Conductor_L01.pClear()
                oQry_Conductor_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region
End Class