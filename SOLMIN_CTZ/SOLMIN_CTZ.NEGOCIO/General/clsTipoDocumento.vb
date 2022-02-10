Imports SOLMIN_CTZ.DATOS

Public Class clsTipoDocumento
    Private oTipoDocumento As SOLMIN_CTZ.DATOS.clsTipoDocumento
    Private oDt As DataTable

    Sub New()
        oTipoDocumento = New SOLMIN_CTZ.DATOS.clsTipoDocumento
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

    Public Function Lista_TipoDocumento_Multiple(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        objDt.Columns.Remove("TABTPD")
        If objDt.Rows.Count > 0 And pintFlag = 1 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_TipoDocumento()
        oDt = oTipoDocumento.Lista_TipoDocumento()
    End Sub

#Region "NC / ND Electronico"

    Public Function Crea_TipoDocumento_Electronico() As DataTable
        Return oTipoDocumento.Lista_TipoDocumento_Electronico()
    End Function

#End Region
End Class
