Public Class frmAlmacenesSDS
#Region "Varibales"

#End Region

#Region "Propiedades"
    Private _OrdenDeServicio As Decimal = 0
    Public Property OrdenDeServicio() As Decimal
        Get
            Return _OrdenDeServicio
        End Get
        Set(ByVal value As Decimal)
            _OrdenDeServicio = value
        End Set
    End Property

    Private _PSCTPALM As String
    Public Property PSCTPALM() As String
        Get
            Return _PSCTPALM
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property


    Private _PSCALMC As String = ""
    Public Property PSCALMC() As String
        Get
            Return _PSCALMC
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property


    Private _PSCZNALM As String = ""
    Public Property PSCZNALM() As String
        Get
            Return _PSCZNALM
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property


    Private _PNQSLMC2 As Decimal = 0
    Public Property PNQSLMC2() As Decimal
        Get
            Return _PNQSLMC2
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC2 = value
        End Set
    End Property


#End Region

    Private Sub frmAlmacenesSDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtgStockAlmacen.DataSource = mfdtListar_StockMercaderiasPorAlmacen(_OrdenDeServicio)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
        Seleccionar()
    End Sub

    Private Sub dtgStockAlmacen_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgStockAlmacen.KeyUp
        If e.KeyCode = Keys.Enter Then
            Seleccionar()
        End If
    End Sub

    Private Sub Seleccionar()
        If Me.dtgStockAlmacen.CurrentCellAddress.Y = -1 Then Exit Sub
        _PSCTPALM = dtgStockAlmacen.CurrentRow.Cells("D_CTPALM").Value
        _PSCALMC = dtgStockAlmacen.CurrentRow.Cells("D_CALMC").Value
        _PSCZNALM = dtgStockAlmacen.CurrentRow.Cells("D_CZNALM").Value
        _PNQSLMC2 = dtgStockAlmacen.CurrentRow.Cells("D_QSLMC2").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub dtgStockAlmacen_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgStockAlmacen.CellDoubleClick
        Seleccionar()
    End Sub
End Class
