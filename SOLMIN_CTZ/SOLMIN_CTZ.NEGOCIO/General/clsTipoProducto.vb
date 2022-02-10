Public Class clsTipoProducto
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
        objDr.Item(0) = "0"
        objDr.Item(1) = "----------"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "P"
        objDr.Item(1) = "PROPIO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "R"
        objDr.Item(1) = "REG. AUTOM."
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "T"
        objDr.Item(1) = "TERCERO"
        objTabla.Rows.Add(objDr)
    End Sub
End Class
