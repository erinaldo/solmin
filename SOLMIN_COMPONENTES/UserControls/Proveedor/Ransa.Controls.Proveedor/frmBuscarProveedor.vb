Imports Ransa.DAO.Proveedor
Imports Ransa.TypeDef.Proveedor

Public Class frmBuscarProveedor

    Public pCPRVCL_Proveedor As Int64 = 0
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pNRUCPR_NroRUC As Int64 = 0

#Region "Proveedores"

    Private _pbeProveedores As New beProveedor

    Public Property pbeProveedores() As beProveedor
        Get
            Return _pbeProveedores
        End Get
        Set(ByVal value As beProveedor)
            _pbeProveedores = value
        End Set
    End Property

    Public pbeProveedorSeleccionado As New beProveedor

#End Region

    Private Sub KryptonDataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellContentClick

    End Sub

    Private Sub txtCampo01_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCampo01.KeyPress, txtCampo02.KeyPress, txtCampo03.KeyPress
        If e.KeyChar = Chr(13) Then
            ListarProveedores()
        End If
    End Sub

    Private Sub frmBuscarProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarProveedores()
    End Sub

    Private Sub ListarProveedores()
        _pbeProveedores = New beProveedor
        _pbeProveedores.PNCPRVCL = Val(txtCampo01.Text)
        _pbeProveedores.PSTPRVCL = txtCampo02.Text.Trim
        _pbeProveedores.PNNRUCPR = Val(txtCampo03.Text)
        _pbeProveedores.PageSize = UcPaginacion1.PageSize
        _pbeProveedores.PageNumber = UcPaginacion1.PageNumber
        Dim odaProveedor As New cProveedor
        Me.dtgListaProveedores.AutoGenerateColumns = False
        Me.dtgListaProveedores.DataSource = Nothing
        Me.dtgListaProveedores.DataSource = odaProveedor.floListaProveedoresPaginado(_pbeProveedores)
        If CType(Me.dtgListaProveedores.DataSource, List(Of beProveedor)).Count > 0 Then
            UcPaginacion1.PageCount = CType(Me.dtgListaProveedores.DataSource, List(Of beProveedor)).Item(0).PageCount
        End If

    End Sub


    

    Private Sub dtgListaProveedores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaProveedores.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        pbeProveedorSeleccionado = CType(Me.dtgListaProveedores.CurrentRow.DataBoundItem, beProveedor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        ListarProveedores()
    End Sub
End Class
