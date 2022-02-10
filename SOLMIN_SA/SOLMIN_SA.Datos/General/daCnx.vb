Imports System.Configuration
Public Class daCnx
    Public Shared Function GetConnectionStringABB() As String
        Dim strCadena As String = ""
        Try
            strCadena = ConfigurationManager.ConnectionStrings("RANSAABB").ConnectionString
            Return strCadena
        Catch ex As Exception
        End Try
        Return strCadena
    End Function
    Public Shared Function GetConnectionTime() As Int64
        Return 3600
    End Function
End Class

