Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class UCtxtSoloNumeros
    Private bIsRequired As Boolean = False
    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtSoloNumeros.StateCommon.Back.Color1 = Nothing
            Else
                '255, 255, 192
                txtSoloNumeros.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0") '.CornflowerBlue
            End If
        End Set
    End Property
 
    Public ReadOnly Property pDescripcion() As String
        Get
            Return txtSoloNumeros.Text
        End Get
    End Property
    Private Sub txtSoloNumeros_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoloNumeros.TextChanged
        If txtSoloNumeros.Text <> "" Then
            If Not IsNumeric(txtSoloNumeros.Text) Then
                txtSoloNumeros.Text = ""
            End If
        End If
    End Sub
End Class
