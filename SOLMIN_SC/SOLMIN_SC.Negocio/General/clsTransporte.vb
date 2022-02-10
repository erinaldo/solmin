Public Class clsTransporte
    Private intCodigo As Integer
    Private objTabla As DataTable

    Sub New()
        objTabla = New DataTable
    End Sub

    Property Codigo()
        Get
            Return intCodigo
        End Get
        Set(ByVal value)
            intCodigo = value
        End Set
    End Property

    Property Tabla()
        Get
            Return objTabla
        End Get
        Set(ByVal value)
            objTabla = value
        End Set
    End Property

    Public Sub Transporte_Forol()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "1"
        objDr.Item(1) = "AGENCIAS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "2"
        objDr.Item(1) = "PROPIO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "3"
        objDr.Item(1) = "TERCEROS"
        objTabla.Rows.Add(objDr)
    End Sub
End Class
