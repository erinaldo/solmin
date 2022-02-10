Public Class clsTipoDeposito
    Private objTabla As DataTable

    Sub New()
        objTabla = New DataTable
    End Sub

    Property Tabla()
        Get
            Return objTabla
        End Get
        Set(ByVal value)
            objTabla = value
        End Set
    End Property

    Public Sub Tipo_Almacen()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "1"
        objDr.Item(1) = "SIMPLE"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "5"
        objDr.Item(1) = "AUTORIZADO"
        objTabla.Rows.Add(objDr)
    End Sub

End Class
