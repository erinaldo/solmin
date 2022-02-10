Public Class frmDetalleBulto
  Public obeBulto As beBultoSegAlmacen

  Private Sub frmDetalleBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim obrBulto As New brBultoSegAlmacen
    dgBultosDetalle.AutoGenerateColumns = False
    dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
  End Sub

  Private Sub dgBultosDetalle_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgBultosDetalle.DataBindingComplete
    For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
      Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
      If NRSITEM > 0 Then
        oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.button_ok1
      End If
    Next
  End Sub


  Private Sub dgBultosDetalle_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgBultosDetalle.CellMouseClick
    If e.RowIndex < 0 Then Exit Sub
    If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
      If Me.dgBultosDetalle.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
      Dim Item As New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
      Item.pCCMPN_Compania = obeBulto.PSCCMPN
      Item.pCDVSN_Division = obeBulto.PSCDVSN
      Item.pCPLNDV_Planta = obeBulto.PNCPLNDV
      Item.pCCLNT_CodigoCliente = obeBulto.PNCCLNT
      Item.pCREFFW_FrdForw = obeBulto.PSCREFFW
      Item.pCIDPAQ_CodIndentificacionPaquete = Me.dgBultosDetalle.CurrentRow.Cells("D_CIDPAQ").Value
      Item.pNORCML_NroOrdenCompra = Me.dgBultosDetalle.CurrentRow.Cells("D_NORCML").Value
      Item.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value
      Dim ofrmSubItemEnAlmacen As New frmSubItemEnAlmacen
      With ofrmSubItemEnAlmacen
        .Items = Item
                .UcSubItemOcEnAlmacen_DgF.Agregar = False
                .UcSubItemOcEnAlmacen_DgF.Eliminar = False
        .ShowDialog()
      End With
    End If
  End Sub

End Class
