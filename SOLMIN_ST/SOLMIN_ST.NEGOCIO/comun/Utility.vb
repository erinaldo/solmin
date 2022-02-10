Public Class Utility
    Public Shared Function RetornaFecha() As String
        Dim fecha As String = Date.Today()
        Return String.Format("dd/mm/yyyy", fecha)
    End Function
    Public Shared Function CFecha_de_8_a_10(ByVal fecha As String) As String
        If fecha = "" OrElse fecha = "0" Then Return ""
        Dim y As String = fecha.Substring(0, 4)
        Dim m As String = fecha.Substring(4, 2)
        Dim d As String = fecha.Substring(6, 2)
        Return y & "-" & m & "-" & d
    End Function
End Class
