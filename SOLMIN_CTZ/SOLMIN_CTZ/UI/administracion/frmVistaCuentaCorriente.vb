#Region "imports"
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
#End Region

Public Class frmVistaCuentaCorriente

#Region "Variables Internas"
    Private bolPaginar As Boolean
    Private oCuentaCorriente As CuentaCorriente
    Private oCuentaCorrienteNeg As clsCuentaCorriente
    Private oCtaCte_ObservacionNeg As clsCtaCte_Observacion
    Private oCtaCte_Observacion As CtaCte_Observacion
    Private oCtaCte_VentaNeg As clsCtaCte_Venta
    Private oCtaCte_Venta As CtaCte_Venta
    Private bolCambiar As Boolean
#End Region
#Region "Propiedades"
    Private _oCuentaCorriente As CuentaCorriente
    Public Property MCuentaCorriente() As CuentaCorriente
        Get
            Return _oCuentaCorriente
        End Get
        Set(ByVal value As CuentaCorriente)
            _oCuentaCorriente = value
        End Set
    End Property

    Private _TipoAccion As String
    Public Property TipoAccion() As String
        Get
            Return _TipoAccion
        End Get
        Set(ByVal value As String)
            _TipoAccion = value
        End Set
    End Property

    Private _TituloConsulta As String
    Public Property TituloConsulta() As String
        Get
            Return _TituloConsulta
        End Get
        Set(ByVal value As String)
            _TituloConsulta = value
        End Set
    End Property

#End Region
#Region "Metodos Propios"
    Private Sub Limpiar_Paneles()
        Me.dtgObservaciones.DataSource = Nothing
        Me.dtgVentas.DataSource = Nothing
        Me.dtgDetalleOI.DataSource = Nothing
    End Sub
    Private Sub Buscar_CtaCte()
        'BUSCA SEGUN FILTRO
        If bolPaginar = False Then
            UcPaginacion1.PageNumber = 1
        Else
            MCuentaCorriente.PageNumber = UcPaginacion1.PageNumber
        End If

        MCuentaCorriente.PageCount = UcPaginacion1.PageCount
        MCuentaCorriente.PageSize = UcPaginacion1.PageSize
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim odtCtaCte As New DataTable
            oCuentaCorrienteNeg = New clsCuentaCorriente
            If TipoAccion = "A" Then
                odtCtaCte = oCuentaCorrienteNeg.Listar_CuentaCorriente(MCuentaCorriente)
            Else
                odtCtaCte = oCuentaCorrienteNeg.Listar_CuentaCorriente_Rubros(MCuentaCorriente)
            End If
            Llenar_Grilla_CuentaCorriente(odtCtaCte)

            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Llenar_Grilla_CuentaCorriente(ByVal odtCtaCte As DataTable)
        dtgCuentaCorriente.AutoGenerateColumns = False
        dtgCuentaCorriente.DataSource = odtCtaCte
        If odtCtaCte.Rows.Count > 0 Then
            Me.UcPaginacion1.PageCount = odtCtaCte.Rows(0).Item("PageCount")
        End If
    End Sub
    Private Sub Cargar_Informacion_CtaCte(ByVal pdblCompania As String, ByVal pstrDocumento As String, ByVal pstrNumDocumento As String)
        bolCambiar = False
        Limpiar_Paneles()
        oCtaCte_Observacion.PSCCMPN = pdblCompania
        oCtaCte_Observacion.NDCCTC = pstrNumDocumento
        oCtaCte_Observacion.CTPODC = pstrDocumento
        oCtaCte_Venta.PSCCMPN = pdblCompania
        oCtaCte_Venta.NDCCTC = pstrNumDocumento
        oCtaCte_Venta.CTPODC = pstrDocumento
        Cargar_Ventas()
        Cargar_Observaciones()
        Cargar_OrdenesInternas()
        bolCambiar = True
    End Sub
    Private Sub Cargar_OrdenesInternas()
        Dim oDt As DataTable
        oDt = oCuentaCorrienteNeg.Lista_CtaCte_OrdenesInternas(oCtaCte_Venta)
        dtgDetalleOI.AutoGenerateColumns = False
        dtgDetalleOI.DataSource = oDt
    End Sub
    Private Sub Cargar_Observaciones()
        Dim oDt As DataTable
        oDt = oCtaCte_ObservacionNeg.Lista_CtaCte_Observacion(oCtaCte_Observacion)
        dtgObservaciones.AutoGenerateColumns = False
        dtgObservaciones.DataSource = oDt
    End Sub
    Private Sub Cargar_Ventas()
        Dim oDt As DataTable
        oDt = oCtaCte_VentaNeg.Lista_CtaCte_Venta(oCtaCte_Venta)
        dtgVentas.AutoGenerateColumns = False
        dtgVentas.DataSource = oDt
    End Sub
    Private Sub ProcesarConsulta()
        oCtaCte_ObservacionNeg = New clsCtaCte_Observacion
        oCtaCte_Observacion = New CtaCte_Observacion
        oCtaCte_VentaNeg = New clsCtaCte_Venta
        oCtaCte_Venta = New CtaCte_Venta
        Limpiar_Paneles()
        Buscar_CtaCte()
        Me.hgCtaCote.ValuesPrimary.Heading = TituloConsulta
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmVistaCuentaCorriente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ProcesarConsulta()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub dtgCuentaCorriente_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCuentaCorriente.CurrentCellChanged
        Try
            If Me.dtgCuentaCorriente.Rows.Count > 0 Then
                Cargar_Informacion_CtaCte(Me.dtgCuentaCorriente.Rows(Me.dtgCuentaCorriente.CurrentRow.Index).Cells("CCMPN").Value, _
                                        Me.dtgCuentaCorriente.Rows(Me.dtgCuentaCorriente.CurrentRow.Index).Cells("CTPODC").Value, _
                                        Me.dtgCuentaCorriente.Rows(Me.dtgCuentaCorriente.CurrentRow.Index).Cells("NDCCTC").Value)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        ProcesarConsulta()
    End Sub
#End Region
   
End Class
