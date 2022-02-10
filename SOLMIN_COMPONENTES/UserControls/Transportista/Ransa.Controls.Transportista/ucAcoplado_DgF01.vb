Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucAcoplado_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Acoplado As TD_Inf_Acoplado_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Acoplado As TD_Inf_Acoplado_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Acoplado As TD_Inf_Acoplado_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oAcoplado As cAcoplado = New Ransa.DAO.Transportista.cAcoplado
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_Acoplado_L01 As TD_Qry_Acoplado_L01 = New Ransa.TypeDef.Transportista.TD_Qry_Acoplado_L01
    Private oInf_Acoplado As TD_Inf_Acoplado_L01 = New Ransa.TypeDef.Transportista.TD_Inf_Acoplado_L01
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

    Public ReadOnly Property pSeleccion() As TD_Inf_Acoplado_L01
        Get
            Return oInf_Acoplado
        End Get
    End Property

    Public Property pNroRegPorPagina() As Int32
        Get
            Return oQry_Acoplado_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        dgAcoplado.DataSource = oAcoplado.Listar(oQry_Acoplado_L01, intNroTotalPaginas)
        blnCargando = False
        If oAcoplado.ErrorMessage <> "" Then
            oInf_Acoplado.pClear()
            oQry_Acoplado_L01.pClear()
            oQry_Acoplado_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oAcoplado.ErrorMessage)
        Else
            If dgAcoplado.RowCount > 0 Then
                oInf_Acoplado.pCCMPN_Compania = oQry_Acoplado_L01.pCCMPN_Compania
                oInf_Acoplado.pNPLCAC_NroAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
                oInf_Acoplado.pTMRCVH_Marca = ("" & dgAcoplado.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
                oInf_Acoplado.pTDEACP_DetTipoAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Acoplado)
            Else
                oInf_Acoplado.pClear()
                oQry_Acoplado_L01.pClear()
                oQry_Acoplado_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgAcoplado.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Acoplado Seleccionado
        oInf_Acoplado.pClearAll()
        intFilaActual = -1
        oQry_Acoplado_L01.pClearAll()
        oQry_Acoplado_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_Acoplado_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_Acoplado_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_Acoplado_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_Acoplado_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_Acoplado_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_Acoplado_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_Acoplado_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Acoplado_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_Acoplado_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Acoplado_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucAcoplado_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oAcoplado.Dispose()
        oAcoplado = Nothing
    End Sub

    Private Sub dgAcoplado_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAcoplado.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgAcoplado.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgAcoplado.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgAcoplado.CurrentCell.RowIndex
            oInf_Acoplado.pCCMPN_Compania = oQry_Acoplado_L01.pCCMPN_Compania
            oInf_Acoplado.pNPLCAC_NroAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
            oInf_Acoplado.pTMRCVH_Marca = ("" & dgAcoplado.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
            oInf_Acoplado.pTDEACP_DetTipoAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
            RaiseEvent CurrentRowChanged(oInf_Acoplado)
        End If
    End Sub

    Private Sub dgAcoplado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAcoplado.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Acoplado)
    End Sub

    Private Sub dgAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgAcoplado.KeyDown
        If e.KeyCode = Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Acoplado)
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
                        oQry_Acoplado_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_Acoplado_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Acoplado_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Acoplado_L01.pNPLCAC_NroAcoplado = objFiltro.pNPLCAC_NroAcoplado
        oQry_Acoplado_L01.pTMRCVH_Marca = objFiltro.pTMRCVH_Marca
        oQry_Acoplado_L01.pTDEACP_DetTipoAcoplado = objFiltro.pTDEACP_DetTipoAcoplado
        oQry_Acoplado_L01.pUsuario = objFiltro.pUsuario
        oQry_Acoplado_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_Acoplado_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Acoplado_L01.pCCMPN_Compania = objFiltro.pCCMPN_Compania
        oQry_Acoplado_L01.pNPLCAC_NroAcoplado = objFiltro.pNPLCAC_NroAcoplado
        oQry_Acoplado_L01.pTMRCVH_Marca = objFiltro.pTMRCVH_Marca
        oQry_Acoplado_L01.pTDEACP_DetTipoAcoplado = objFiltro.pTDEACP_DetTipoAcoplado
        oQry_Acoplado_L01.pUsuario = objFiltro.pUsuario
        oQry_Acoplado_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgAcoplado.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_Acoplado.pClear()
            oQry_Acoplado_L01.pClear()
            oQry_Acoplado_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgAcoplado.RowCount > 0 Then
                oInf_Acoplado.pCCMPN_Compania = oQry_Acoplado_L01.pCCMPN_Compania
                oInf_Acoplado.pNPLCAC_NroAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_NPLCAC").Value).ToString.Trim
                oInf_Acoplado.pTMRCVH_Marca = ("" & dgAcoplado.CurrentRow.Cells("M_TMRCVH").Value).ToString.Trim
                oInf_Acoplado.pTDEACP_DetTipoAcoplado = ("" & dgAcoplado.CurrentRow.Cells("M_TDEACP").Value).ToString.Trim
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Acoplado)
            Else
                oInf_Acoplado.pClear()
                oQry_Acoplado_L01.pClear()
                oQry_Acoplado_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region
End Class