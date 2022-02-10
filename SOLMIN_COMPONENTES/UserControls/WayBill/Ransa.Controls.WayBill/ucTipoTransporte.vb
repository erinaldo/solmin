Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.WayBill
Public Class ucTipoTransporte

    Public oInfoTipoTransporte As New TipoTransporte
    Enum Tipo
        Normal = 0
        Todos = 1
        Seleccione = 2
    End Enum
    Private _TipoFiltro As Tipo = Tipo.Seleccione
    Public Property TipoFiltro() As Tipo
        Get
            Return _TipoFiltro
        End Get
        Set(ByVal value As Tipo)
            _TipoFiltro = value
        End Set
    End Property

    Private Sub CargaLista()
        Dim odaTipoTransporte As New daTipoTransporte
        Dim oListTipoTransporte As New List(Of TipoTransporte)
        Dim obeTipoTransporte As New TipoTransporte
        oListTipoTransporte = odaTipoTransporte.Listar_Tipo_Transporte()
        Select Case TipoFiltro
            Case Tipo.Normal
            Case Tipo.Seleccione
                obeTipoTransporte.CODIGO = "0"
                obeTipoTransporte.DESCRIPCION = "::Seleccione::"
                oListTipoTransporte.Insert(0, obeTipoTransporte)
            Case Tipo.Todos
                obeTipoTransporte.CODIGO = "0"
                obeTipoTransporte.DESCRIPCION = "::Todos::"
                oListTipoTransporte.Insert(0, obeTipoTransporte)
        End Select
        cboTipoTransporte.DataSource = oListTipoTransporte
        cboTipoTransporte.ValueMember = "CODIGO"
        cboTipoTransporte.DisplayMember = "DESCRIPCION"
    End Sub

    Private Sub ucTipoTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaLista()
    End Sub
    Private Sub cboTipoTransporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTransporte.SelectedIndexChanged
        oInfoTipoTransporte = cboTipoTransporte.SelectedItem
    End Sub
    Public Sub SeleccionarTipoTransporte(ByVal TipoTransporte As String)
        cboTipoTransporte.SelectedValue = TipoTransporte
        oInfoTipoTransporte = cboTipoTransporte.SelectedItem
    End Sub
End Class
