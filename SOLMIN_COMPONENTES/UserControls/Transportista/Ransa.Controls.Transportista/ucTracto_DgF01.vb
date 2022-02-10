Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucTracto_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Tracto As TD_Inf_Tracto_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Tracto As TD_Inf_Tracto_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Tracto As TD_Inf_Tracto_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oTracto As cTracto = New Ransa.DAO.Transportista.cTracto
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_Tracto_L01 As TD_Qry_Tracto_L01 = New Ransa.TypeDef.Transportista.TD_Qry_Tracto_L01
    Private oInf_Tracto As TD_Inf_Tracto_L01 = New Ransa.TypeDef.Transportista.TD_Inf_Tracto_L01
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

    Public ReadOnly Property pSeleccion() As TD_Inf_Tracto_L01
        Get
            Return oInf_Tracto
        End Get
    End Property

    Public Property pNroRegPorPagina() As Int32
        Get
            Return oQry_Tracto_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Tracto_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        dgTracto.DataSource = oTracto.Listar(oQry_Tracto_L01, intNroTotalPaginas)
        blnCargando = False
        If oTracto.ErrorMessage <> "" Then
            oInf_Tracto.pClear()
            oQry_Tracto_L01.pClear()
            oQry_Tracto_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oTracto.ErrorMessage)
        Else
            If dgTracto.RowCount > 0 Then
                oInf_Tracto.pCCMPN_Compania = oQry_Tracto_L01.pCCMPN_Compania
                oInf_Tracto.pNPLCUN_NroPlacaUnidad = ("" & dgTracto.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
                oInf_Tracto.pTMRCTR_Marca_Modelo = ("" & dgTracto.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
                oInf_Tracto.pNRGMT1_NroMTC = ("" & dgTracto.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Tracto)
            Else
                oInf_Tracto.pClear()
                oQry_Tracto_L01.pClear()
                oQry_Tracto_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgTracto.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Tracto Seleccionado
        oInf_Tracto.pClearAll()
        intFilaActual = -1
        oQry_Tracto_L01.pClearAll()
        oQry_Tracto_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_Tracto_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_Tracto_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_Tracto_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_Tracto_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_Tracto_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_Tracto_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_Tracto_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Tracto_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_Tracto_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Tracto_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucTracto_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oTracto.Dispose()
        oTracto = Nothing
    End Sub

    Private Sub dgTracto_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTracto.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgTracto.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgTracto.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgTracto.CurrentCell.RowIndex
            oInf_Tracto.pCCMPN_Compania = oQry_Tracto_L01.pCCMPN_Compania
            oInf_Tracto.pNPLCUN_NroPlacaUnidad = ("" & dgTracto.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
            oInf_Tracto.pTMRCTR_Marca_Modelo = ("" & dgTracto.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
            oInf_Tracto.pNRGMT1_NroMTC = ("" & dgTracto.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
            RaiseEvent CurrentRowChanged(oInf_Tracto)
        End If
    End Sub

    Private Sub dgTracto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTracto.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Tracto)
    End Sub

    Private Sub dgTracto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgTracto.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Tracto)
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
                        oQry_Tracto_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_Tracto_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Tracto_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Tracto_L01.pNPLCUN_NroPlacaUnidad = objFiltro.pNPLCUN_NroPlacaUnidad
        oQry_Tracto_L01.pTMRCTR_Marca_Modelo = objFiltro.pTMRCTR_Marca_Modelo
        oQry_Tracto_L01.pNRGMT1_NroMTC = objFiltro.pNRGMT1_NroMTC
        oQry_Tracto_L01.pUsuario = objFiltro.pUsuario
        oQry_Tracto_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Tracto_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_Tracto_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Tracto_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Tracto_L01.pNPLCUN_NroPlacaUnidad = objFiltro.pNPLCUN_NroPlacaUnidad
        oQry_Tracto_L01.pTMRCTR_Marca_Modelo = objFiltro.pTMRCTR_Marca_Modelo
        oQry_Tracto_L01.pNRGMT1_NroMTC = objFiltro.pNRGMT1_NroMTC
        oQry_Tracto_L01.pUsuario = objFiltro.pUsuario
        oQry_Tracto_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Tracto_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgTracto.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_Tracto.pClear()
            oQry_Tracto_L01.pClear()
            oQry_Tracto_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgTracto.RowCount > 0 Then
                oInf_Tracto.pCCMPN_Compania = oQry_Tracto_L01.pCCMPN_Compania
                oInf_Tracto.pNPLCUN_NroPlacaUnidad = ("" & dgTracto.CurrentRow.Cells("M_NPLCUN").Value).ToString.Trim
                oInf_Tracto.pTMRCTR_Marca_Modelo = ("" & dgTracto.CurrentRow.Cells("M_TMRCTR").Value).ToString.Trim
                oInf_Tracto.pNRGMT1_NroMTC = ("" & dgTracto.CurrentRow.Cells("M_NRGMT1").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Tracto)
            Else
                oInf_Tracto.pClear()
                oQry_Tracto_L01.pClear()
                oQry_Tracto_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region
End Class