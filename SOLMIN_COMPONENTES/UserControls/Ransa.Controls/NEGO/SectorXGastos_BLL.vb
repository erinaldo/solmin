Public Class SectorXGastos_BLL

  Public Function Lista_SectorXGastos() As DataTable
    Dim oDt As New DataTable
    Dim oDr As DataRow

    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")
    oDr = oDt.NewRow()
    oDr.Item(0) = "C"
    oDr.Item(1) = "Consumo"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "M"
    oDr.Item(1) = "Minero"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "P"
    oDr.Item(1) = "Paita"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "I"
    oDr.Item(1) = "Internacional"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "A"
    oDr.Item(1) = "Mesa de Carga"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "B"
    oDr.Item(1) = "Traslados OLR"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow()
    oDr.Item(0) = "T"
    oDr.Item(1) = "Traslados General"
    oDt.Rows.Add(oDr)

    Return oDt
  End Function

End Class
