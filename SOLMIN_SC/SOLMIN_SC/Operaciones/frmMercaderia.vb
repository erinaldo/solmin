Imports SOLMIN_SC.Negocio
'Imports Ransa.TypeDef.Mercaderia
Imports System.Web

Public Class frmMercaderia

    Private Sub frmMercaderia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpUtil.UserName

    End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
  '    Buscar_Mercaderia()
  'End Sub

    Private Sub Buscar_Mercaderia()
        Try
            Me.Cursor = Cursors.WaitCursor
            'Dim oQuery As New TD_Qry_Mercaderia_L01
            Dim oQuery As New Ransa.Controls.Mercaderia.TD_Qry_Mercaderia_L01

            If Me.cmbCliente.pCodigo = 0 Then
                Exit Sub
            End If

            dtgMercaderia.pClear()
            oQuery.pCCLNT_CodigoCliente = Me.cmbCliente.pCodigo
            oQuery.pCMRCLR_Mercaderia = Me.txtCodigo.Text.Trim & "*"
            dtgMercaderia.pActualizar(oQuery)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

  Private Sub dtgMercaderia_Buscar() Handles dtgMercaderia.Buscar
    Buscar_Mercaderia()
  End Sub
End Class
