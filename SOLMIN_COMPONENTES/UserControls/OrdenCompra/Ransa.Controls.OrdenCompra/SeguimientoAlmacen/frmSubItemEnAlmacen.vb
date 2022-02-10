Imports Ransa.Utilitario

Public Class frmSubItemEnAlmacen

#Region "Propiedades"
  Private _Items As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
  Public Property Items() As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
    Get
      Return _Items
    End Get
    Set(ByVal value As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK)
      _Items = value
    End Set
  End Property
#End Region
  Private Sub frmSubItemEnAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    UcSubItemOcEnAlmacen_DgF.pUsuario = ""
        UcSubItemOcEnAlmacen_DgF.pActualizar(_Items)
    End Sub
    Private Sub UcSubItemOcEnAlmacen_DgFClick() Handles UcSubItemOcEnAlmacen_DgF.DialogResult
        Me.Close()
    End Sub
End Class
