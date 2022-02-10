Public Class clsCliente_BL
    Public Function PerteneceASalmon(ByVal PSCMCPN As String) As Boolean
        Dim oCliente As New clsCliente_DAL
        If oCliente.PerteneceASalmon(PSCMCPN).Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function


    Public Function Validar_Cliente_Interno_v2(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente_BE)
        Dim oCliente As New clsCliente_DAL
        Return oCliente.Validar_Cliente_Interno_v2(CCMPN, PNNRCTSL)
    End Function

End Class
