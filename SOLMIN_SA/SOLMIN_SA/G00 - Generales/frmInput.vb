Public Class frmInput
#Region " Atributos "
    Dim blnSalir As Boolean = False
#End Region
#Region " Propiedades "
    Public WriteOnly Property pTitulo() As String
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property

    Public WriteOnly Property pMensaje() As String
        Set(ByVal value As String)
            lblDescripcionPedido.Text = value
            If lblDescripcionPedido.Width + 34 >= 290 Then
                Me.Width = lblDescripcionPedido.Width + 34
            Else
                Me.Width = 290
            End If
            If lblDescripcionPedido.Width + 34 >= 150 Then
                Me.Height = lblDescripcionPedido.Height + 134
            Else
                Me.Height = 150
            End If
        End Set
    End Property

    Public ReadOnly Property pInput() As String
        Get
            Return txtInput.Text
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Eventos "
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnSalir = True
    End Sub

    Private Sub frmInput_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnSalir Then e.Cancel = False
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
