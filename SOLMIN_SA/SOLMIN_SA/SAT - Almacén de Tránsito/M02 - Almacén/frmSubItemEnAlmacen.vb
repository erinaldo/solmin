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
        UcSubItemOcEnAlmacen_DgF011.pUsuario = objSeguridadBN.pUsuario
        UcSubItemOcEnAlmacen_DgF011.pActualizar(_Items)

    End Sub

    Private Sub UcSubItemOcEnAlmacen_DgF011_DialogResult() Handles UcSubItemOcEnAlmacen_DgF011.DialogResult
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub UcSubItemOcEnAlmacen_DgF011_Confirm(ByVal strPregunta As System.String, ByRef blnCancelar As System.Boolean) Handles UcSubItemOcEnAlmacen_DgF011.Confirm
        If MessageBox.Show(strPregunta, "SubItems:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub
End Class
