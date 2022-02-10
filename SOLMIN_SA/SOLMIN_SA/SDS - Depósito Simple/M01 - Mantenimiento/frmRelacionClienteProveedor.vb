Imports Ransa.TypeDef
Imports RANSA.Utilitario
Imports Ransa.NEGO
Imports Ransa.TypeDef.Cliente
Public Class frmRelacionClienteProveedor
    Public CCLNT As Int64 = 0
    Private Sub frmRelacionClienteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(Me.CCLNT, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            txtCliente.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If (txtProveedor.pCodigo = 0) Then
                MessageBox.Show("Debe de seleccionar un Proveedor", "Relacionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim resultado As String = ""
                Dim oblProveedor As New blProveedor()
                Dim obeProveedor As New beProveedor()
                obeProveedor.CCLNT_CodigoCliente = Me.CCLNT
                obeProveedor.CPRVCL_CodClienteTercero = txtProveedor.pCodigo
                obeProveedor.CUSCRT_UsuarioCre = objSeguridadBN.pUsuario
                obeProveedor = oblProveedor.RegistrarRelacionTercero_x_Cliente(obeProveedor)
                If (obeProveedor.RELACION = "TRUE") Then
                    MessageBox.Show("No se puede realizar la operación .La relación ya existe" & Chr(13) & "Puede seleccionar otro proveedor")
                ElseIf obeProveedor.CREACION = "INS" Then
                    MessageBox.Show("Se ha grabado satisfactoriamente la relación")
                    Me.Close()
                ElseIf obeProveedor.CREACION = "UPD" Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente la relación")
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo realizar la operación")
                End If
            End If
        Catch ex As Exception

        End Try
      
    End Sub
   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtProveedor_ErrorMessage(ByVal MsgError As String) Handles txtProveedor.ErrorMessage
        MessageBox.Show(MsgError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtProveedor_MostrarManAlternativo() Handles txtProveedor.MostrarManAlternativo
        Try
            Dim ofrmEProveedor As New frmEProveedor()
            ofrmEProveedor.IsNuevo = True
            ofrmEProveedor.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class
