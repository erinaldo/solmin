Public Class clsEnvio
    Private oEnvio As Datos.clsEnvio
    Private oDt As DataTable

    Sub New()
        oEnvio = New Datos.clsEnvio
    End Sub
    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property
    Public Function Listar_Envio(Optional ByVal pintFlag As Integer = 0) As DataTable
        oDt = oEnvio.Lista_Forma_Envio
        If (pintFlag = 0) Then
            Dim objDr As DataRow
            objDr = oDt.NewRow
            objDr("CMEDTR") = "0"
            objDr("TNMMDT") = "TODOS"
            oDt.Rows.InsertAt(objDr, 0)
        End If
        Return oDt
    End Function

End Class
