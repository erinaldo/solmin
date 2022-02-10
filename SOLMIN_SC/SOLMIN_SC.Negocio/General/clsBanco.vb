Public Class clsBanco
    Private oBanco As Datos.clsBanco
    Private oDt As DataTable

    Sub New()
        oBanco = New Datos.clsBanco
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Banco(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag > 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(2) = ""
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_Lista()
        oDt = oBanco.Lista_Banco
    End Sub
End Class
