Imports System.ComponentModel
Public Class Texto
    Inherits TextBox
    Private _SigControl As Control
    <Description("Siguiente control al dar enter"), Category("ADICIONAL")> _
    Public Property SigControl() As Control
        Get
            Return _SigControl
        End Get
        Set(ByVal value As Control)
            _SigControl = value
        End Set
    End Property

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = ControlChars.Cr) Then
            If _SigControl IsNot Nothing Then
                _SigControl.Focus()
            End If
        End If
    End Sub
End Class
