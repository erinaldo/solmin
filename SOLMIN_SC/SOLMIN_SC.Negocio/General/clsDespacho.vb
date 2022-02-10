Public Class clsDespacho
    Private oDespacho As Datos.clsDespacho
    Private intCodigo As Integer
    Private oDt As DataTable

    Sub New()
        oDespacho = New Datos.clsDespacho
    End Sub

    Property Codigo()
        Get
            Return intCodigo
        End Get
        Set(ByVal value)
            intCodigo = value
        End Set
    End Property

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Despacho(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_Lista()
        oDt = oDespacho.Lista_Despacho
    End Sub
End Class
