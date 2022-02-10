'<[AHM]>
Public NotInheritable Class StringExtension
    Public Shared Function SubString(ByVal value As String, ByVal i As Int32, ByVal l As Int32) As String
        Dim t As Int32 = value.Length

        If (i <= 0) Then i = 0
        If (l <= 0) Then l = 0


        If (i > t) Then
            l = 0
            i = 0
        End If
        If (l > t) Then l = t

        If (i >= 0 And l >= t) Then l = l - i

        Return value.Substring(i, l)
    End Function
End Class
'</[AHM]>