Imports Ransa.TypeDef.OrdenCompra.SubItemOC

Public Class frmSubItems

    Private olistTD_SubItemOC As New List(Of TD_SubItemOC)

    Public Property SubItems() As List(Of TD_SubItemOC)
        Get
            Return olistTD_SubItemOC
        End Get
        Set(ByVal value As List(Of TD_SubItemOC))
            olistTD_SubItemOC = value
        End Set
    End Property

    Private Sub frmSubItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarItems()
    End Sub


    Private Sub CargarItems()
        dgSubItemOC.ReadOnly = True
        Dim oDrv As DataGridViewRow
        For Each objTempSubItem As TD_SubItemOC In olistTD_SubItemOC
            oDrv = New DataGridViewRow
            oDrv.CreateCells(Me.dgSubItemOC)
            oDrv.Cells(0).Value = objTempSubItem.pNRITOC_NroItemOC
            oDrv.Cells(1).Value = objTempSubItem.pSBITOC_NroSubItemOC
            oDrv.Cells(2).Value = objTempSubItem.pTCITCL_CodigoCliente
            oDrv.Cells(3).Value = objTempSubItem.pTDITES_DescripcionES
            oDrv.Cells(4).Value = objTempSubItem.pQCNREC_QtaRecibida
            oDrv.Cells(5).Value = objTempSubItem.pTUNDIT_Unidad

            Me.dgSubItemOC.Rows.Add(oDrv)
        Next
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
