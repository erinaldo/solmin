Public Class frmEstructuraArchivo

    Dim _SYSTEMNAME As String = ""

    Public Property SystemName() As String
        Get
            Return _SYSTEMNAME
        End Get
        Set(ByVal value As String)
            _SYSTEMNAME = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        'guardamos en el web service el directorio y lo crea en la tabla y fisicamente tambien

    End Sub
End Class
