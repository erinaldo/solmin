Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.Cliente

'Imports Ransa.TypeDef.Cliente
'Imports Ransa.DAO.Cliente

Public Class ucClienteGrupo_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Cliente As TD_Inf_Cliente_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Cliente As TD_Inf_Cliente_L01)
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Msg As String)
    Public Event Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    Public Event SalirDobleClick(ByVal Cliente As TD_Inf_Cliente_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    'Private oCliente As cCliente = New Ransa.DAO.Cliente.cCliente
    Private oCliente As cCliente = New Cliente.cCliente
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    'Private oQry_Cliente_L01 As TD_Qry_Cliente_L01 = New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
    'Private oInf_Cliente As TD_Inf_Cliente_L01 = New Ransa.TypeDef.Cliente.TD_Inf_Cliente_L01
    Private oQry_Cliente_L01 As TD_Qry_Cliente_L01 = New Cliente.TD_Qry_Cliente_L01
    Private oInf_Cliente As TD_Inf_Cliente_L01 = New Cliente.TD_Inf_Cliente_L01
    Private intFilaActual As Int32 = 0
    Private intNroTotalPaginas As Int32 = 0
    Private intTipoCliente As Int32 = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private sAccesoPorUsuario As String = "N"
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

    Public ReadOnly Property pSeleccion() As TD_Inf_Cliente_L01
        Get
            Return oInf_Cliente
        End Get
    End Property

    Public Property pAccesoPorUsuario() As Boolean
        Get
            Dim bTemp As Boolean = False
            If sAccesoPorUsuario = "S" Then bTemp = True
            Return bTemp
        End Get
        Set(ByVal value As Boolean)
            Dim sTemp As String = "N"
            If value Then sTemp = "S"
            sAccesoPorUsuario = sTemp
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        blnCargando = True
        'sTipoCliente = 0 Normal = 1  Especial
        dgCliente.DataSource = oCliente.ListarGrupo(oQry_Cliente_L01, sAccesoPorUsuario, intNroTotalPaginas)

        blnCargando = False
        If oCliente.ErrorMessage <> "" Then
            oInf_Cliente.pClear()
            oQry_Cliente_L01.pClear()
            oQry_Cliente_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage(oCliente.ErrorMessage)
        Else
            If dgCliente.RowCount > 0 Then
                'Cambiar Columna a Mostrar
                oInf_Cliente.pCCLNT_Cliente = dgCliente.CurrentRow.Cells("NRCTCL").Value
                'ACD
                oInf_Cliente.pCCLNT_ClienteGrupo = dgCliente.CurrentRow.Cells("NRCTCL").Value
                'Fin ACD
                oInf_Cliente.pTCMPCL_DescripcionCliente = ("" & dgCliente.CurrentRow.Cells("M_DESCAR").Value).ToString.Trim
                oInf_Cliente.pNRUC_NroRUC = dgCliente.CurrentRow.Cells("M_NRUC").Value
                oInf_Cliente.pTDRCOR_DireccionOrigen = ("" & dgCliente.CurrentRow.Cells("M_TDRCOR").Value).ToString.Trim
                oInf_Cliente.pNLBTEL_NroDocIdentidad = dgCliente.CurrentRow.Cells("M_NLBTEL").Value

                'TMTVBJ

                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Cliente)
            Else
                oInf_Cliente.pClear()
                oQry_Cliente_L01.pClear()
                oQry_Cliente_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgCliente.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el Cliente Seleccionado
        oInf_Cliente.pClear()
        intFilaActual = -1
        oQry_Cliente_L01.pClear()
        oQry_Cliente_L01.pNROPAG_NroPagina = 1
        intNroTotalPaginas = 0
        Call pMostrarDetallePosicion()
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMostrarDetallePosicion()
        txtPaginaActual.Text = oQry_Cliente_L01.pNROPAG_NroPagina
        txtNroTotalPagina.Text = intNroTotalPaginas
        txtNroRegPorPagina.Text = oQry_Cliente_L01.pREGPAG_NroRegPorPagina
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If oQry_Cliente_L01.pNROPAG_NroPagina > 1 Then
            ' Ponemos la pagina actual en 1
            oQry_Cliente_L01.pNROPAG_NroPagina = 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If oQry_Cliente_L01.pNROPAG_NroPagina > 1 Then
            ' Restamos 1 a la posición actual
            oQry_Cliente_L01.pNROPAG_NroPagina -= 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If intNroTotalPaginas > 0 And oQry_Cliente_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Cliente_L01.pNROPAG_NroPagina += 1
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If intNroTotalPaginas > 0 And oQry_Cliente_L01.pNROPAG_NroPagina < intNroTotalPaginas Then
            ' Sumamos 1 a la posición actual
            oQry_Cliente_L01.pNROPAG_NroPagina = intNroTotalPaginas
            ' Llamada al procedimiento de carga de información
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucCliente_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oCliente.Dispose()
        oCliente = Nothing
    End Sub


    Private Sub ucCliente_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oQry_Cliente_L01.pNROPAG_NroPagina = 1
        oQry_Cliente_L01.pREGPAG_NroRegPorPagina = 20
    End Sub

    Private Sub dgCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCliente.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgCliente.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgCliente.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgCliente.CurrentCell.RowIndex
            oInf_Cliente.pCCLNT_Cliente = dgCliente.CurrentRow.Cells("M_CCLNT").Value
            'ACD
            oInf_Cliente.pCCLNT_ClienteGrupo = dgCliente.CurrentRow.Cells("NRCTCL").Value
            'Fin ACD
            oInf_Cliente.pTCMPCL_DescripcionCliente = ("" & dgCliente.CurrentRow.Cells("M_DESCAR").Value).ToString.Trim
            oInf_Cliente.pNRUC_NroRUC = dgCliente.CurrentRow.Cells("M_NRUC").Value
            oInf_Cliente.pTDRCOR_DireccionOrigen = ("" & dgCliente.CurrentRow.Cells("M_TDRCOR").Value).ToString.Trim
            oInf_Cliente.pNLBTEL_NroDocIdentidad = dgCliente.CurrentRow.Cells("M_NLBTEL").Value
            RaiseEvent CurrentRowChanged(oInf_Cliente)
        End If
    End Sub

    'Private Sub dgCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Cliente)
    'End Sub

    Private Sub dgCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCliente.DoubleClick
        If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Cliente)
    End Sub

    Private Sub dgCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCliente.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then If blnSalirDoubleClick Then RaiseEvent SalirDobleClick(oInf_Cliente)
    End Sub

    Private Sub txtPaginaActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
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
                        oQry_Cliente_L01.pNROPAG_NroPagina = intTemp
                        ' Llamada al procedimiento de carga de información
                        Call pCargarInformacion()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal objFiltro As TD_Qry_Cliente_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Cliente_L01.pCCLNT_Cliente = objFiltro.pCCLNT_Cliente
        'ACD
        oQry_Cliente_L01.pCCLNT_ClienteGrupo = objFiltro.pCCLNT_ClienteGrupo
        'Fin ACD
        oQry_Cliente_L01.pTCMPCL_DescripcionCliente = objFiltro.pTCMPCL_DescripcionCliente
        oQry_Cliente_L01.pNRUC_NroRUC = objFiltro.pNRUC_NroRUC
        oQry_Cliente_L01.pUsuario = objFiltro.pUsuario
        oQry_Cliente_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Cliente_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        oQry_Cliente_L01.pCCMPN_CodigoCompania = objFiltro.pCCMPN_CodigoCompania
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    Public Sub LoadDataSource(ByVal objFiltro As TD_Qry_Cliente_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer, Optional ByVal iTClient As Integer = 0)
        intTipoCliente = iTClient
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        oQry_Cliente_L01.pCCLNT_Cliente = objFiltro.pCCLNT_Cliente
        'ACD
        oQry_Cliente_L01.pCCLNT_ClienteGrupo = objFiltro.pCCLNT_ClienteGrupo
        oQry_Cliente_L01.pCCMPN_CodigoCompania = objFiltro.pCCMPN_CodigoCompania
        'fin ACD
        oQry_Cliente_L01.pTCMPCL_DescripcionCliente = objFiltro.pTCMPCL_DescripcionCliente
        oQry_Cliente_L01.pNRUC_NroRUC = objFiltro.pNRUC_NroRUC
        oQry_Cliente_L01.pUsuario = objFiltro.pUsuario
        oQry_Cliente_L01.pNROPAG_NroPagina = objFiltro.pNROPAG_NroPagina
        oQry_Cliente_L01.pREGPAG_NroRegPorPagina = objFiltro.pREGPAG_NroRegPorPagina
        intNroTotalPaginas = iTPag

        dgCliente.DataSource = DataSource
        If DataSource Is Nothing Then
            oInf_Cliente.pClear()
            oQry_Cliente_L01.pClear()
            oQry_Cliente_L01.pNROPAG_NroPagina = 1
            Call pMostrarDetallePosicion()
            RaiseEvent ErrorMessage("No existe información para visualizar.")
        Else
            If dgCliente.RowCount > 0 Then
                oInf_Cliente.pCCLNT_Cliente = dgCliente.CurrentRow.Cells("NRCTCL").Value
                oInf_Cliente.pCCLNT_ClienteGrupo = dgCliente.CurrentRow.Cells("NRCTCL").Value
                oInf_Cliente.pTCMPCL_DescripcionCliente = ("" & dgCliente.CurrentRow.Cells("M_DESCAR").Value).ToString.Trim
                oInf_Cliente.pNRUC_NroRUC = dgCliente.CurrentRow.Cells("M_NRUC").Value
                oInf_Cliente.pTDRCOR_DireccionOrigen = ("" & dgCliente.CurrentRow.Cells("M_TDRCOR").Value).ToString.Trim
                oInf_Cliente.pNLBTEL_NroDocIdentidad = dgCliente.CurrentRow.Cells("M_NLBTEL").Value
                intFilaActual = 0
                RaiseEvent DataLoadCompleted(oInf_Cliente)
            Else
                oInf_Cliente.pClear()
                oQry_Cliente_L01.pClear()
                oQry_Cliente_L01.pNROPAG_NroPagina = 1
                Call pMostrarDetallePosicion()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            Call pMostrarDetallePosicion()
        End If
    End Sub
#End Region

End Class