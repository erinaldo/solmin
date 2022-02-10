Public Enum ValidationInputType
    Numeric = 0
    Alpha = 1
End Enum

Public Class TextField
    Inherits ComponentFactory.Krypton.Toolkit.KryptonTextBox


    Private ValidatorType As ValidationInputType
    Public Event AcceptDataChanges(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(pe)
    End Sub

    Public Property TextValidationType() As ValidationInputType
        Get
            Return ValidatorType
        End Get
        Set(ByVal value As ValidationInputType)
            ValidatorType = value
        End Set
    End Property

    Private Sub TextField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.StateCommon.Content.Font = New Font("Trebuchet", 8, FontStyle.Bold, GraphicsUnit.Point)
        Me.SelectionStart = 0
        Me.SelectionLength = Me.Text.Length
    End Sub

    Private Sub TextField_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
        End If

        If e.KeyCode = Keys.Enter Then
            RaiseEvent AcceptDataChanges(sender, e)
        End If
    End Sub

    Private Sub TextField_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If sender.focused = True Then
            Exit Sub
        End If


    End Sub

    Private Sub TextField_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.StateCommon.Back.Color1 = Color.White
        Me.StateCommon.Content.Color1 = Color.Black
        Me.StateCommon.Content.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
    End Sub
End Class
