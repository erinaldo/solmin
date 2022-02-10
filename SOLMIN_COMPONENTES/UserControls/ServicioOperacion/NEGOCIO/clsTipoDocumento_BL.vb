Public Class clsTipoDocumento_BL

    Private oTipoDocumento As clsTipoDocumento_DAL
    Private oDt As DataTable

    Sub New()
        oTipoDocumento = New clsTipoDocumento_DAL
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_TipoDocumento(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "-------"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Function Lista_TipoDocumento_X_All(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 1 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDr(2) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_TipoDocumento()
        oDt = oTipoDocumento.Lista_TipoDocumento()
    End Sub
End Class
