Public Class clsUnidadMedida_BL
    Public Function Lista_UnidadMedida() As DataTable
        Dim objDr As DataRow
        Dim objDt As New DataTable
        objDt.Columns.Add("COD")
        objDt.Columns.Add("VAL")

        objDr = objDt.NewRow
        objDr(0) = "MT2"
        objDr(1) = "METROS CUADRADOS"
        objDt.Rows.Add(objDr)

        objDr = objDt.NewRow
        objDr(0) = "MT3"
        objDr(1) = "METROS CUBICOS"
        objDt.Rows.Add(objDr)

        objDr = objDt.NewRow
        objDr(0) = "KGS"
        objDr(1) = "KILOGRAMOS"
        objDt.Rows.Add(objDr)

        Return objDt
    End Function

End Class