Public Class frmVisorVentasDetallado
  Private oDtReporte As New DataTable
  Private intMonedaFac As Int16

  Public WriteOnly Property MonedaFactura() As Int16
    Set(ByVal value As Int16)
      intMonedaFac = value
    End Set
  End Property


  Public Sub New(ByVal objCuentaCorriente As rptVentasDetallado, ByVal oDt As DataTable)
    InitializeComponent()
    oDtReporte = oDt.Copy
    CrystalReportViewer1.ReportSource = objCuentaCorriente
  End Sub
  Private Sub frmVisorVentasDetallado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub ExportarPorCentroDeCostoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorCentroDeCostoToolStripMenuItem.Click
    Dim oList As New List(Of DataTable)
    Dim oDtRepo As New DataTable
    oDtRepo = oDtReporte.Copy
    Dim dtv As New DataView(oDtRepo)
    dtv.Sort = "CDVSN, CCLNT, NDCCTC DESC"
    oDtRepo = dtv.ToTable()

    oDtRepo.Columns.Remove("CCMPN")
    oDtRepo.Columns.Remove("CDVSN")
    oDtRepo.Columns.Remove("CZNFCC")
    oDtRepo.Columns.Remove("CTPODC")
    oDtRepo.Columns.Remove("TCMTPD")
    oDtRepo.Columns.Remove("TCMTRF")
    oDtRepo.Columns.Remove("CMNDA")
    'oDtRepo.Columns.Remove("ITCCTC")
    If intMonedaFac = 1 Then
      oDtRepo.Columns.Remove("IVLDCD")
      oDtRepo.Columns.Remove("IVLAFD")
      oDtRepo.Columns.Remove("ITTFCD")
      oDtRepo.Columns.Remove("IVLIGD")
      For i As Integer = 0 To oDtRepo.Rows.Count - 1
        oDtRepo.Rows(i).Item("IVLAFS") = oDtRepo.Rows(i).Item("IVLAFS") + oDtRepo.Rows(i).Item("IVLNAS")
      Next
    Else
      For i As Integer = 0 To oDtRepo.Rows.Count - 1
        oDtRepo.Rows(i).Item("IVLAFD") = oDtRepo.Rows(i).Item("IVLAFD") + oDtRepo.Rows(i).Item("IVLNAD")
      Next
      oDtRepo.Columns.Remove("IVLDCS")
      oDtRepo.Columns.Remove("IVLAFS")
      oDtRepo.Columns.Remove("ITTFCS")
      oDtRepo.Columns.Remove("IVLIGS")
    End If
    oDtRepo.Columns.Remove("IVLNAS")
    oDtRepo.Columns.Remove("IVLNAD")

    oDtRepo.Columns(0).ColumnName = "División"
    oDtRepo.Columns(1).ColumnName = "Zona"
    oDtRepo.Columns(2).ColumnName = "Tipo"
    oDtRepo.Columns(3).ColumnName = "Nro. Documento"
    oDtRepo.Columns(4).ColumnName = "Fecha"
    oDtRepo.Columns(5).ColumnName = "Tipo Cambio"
    oDtRepo.Columns(6).ColumnName = "Código"
    oDtRepo.Columns(7).ColumnName = "Cliente"
    oDtRepo.Columns(8).ColumnName = "Valor Venta"
    oDtRepo.Columns(9).ColumnName = "I.G.V"
    oDtRepo.Columns(10).ColumnName = "Valor Total"
    oDtRepo.Columns(11).ColumnName = "Cod. Centro Costo"
    oDtRepo.Columns(12).ColumnName = "Desc. Centro Costo"
    oDtRepo.Columns(13).ColumnName = "Monto Centro Costo"
    oDtRepo.Columns(14).ColumnName = "Centro Beneficio"

    oList.Add(oDtRepo)

    Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oList, "Registro de Ventas" & " - " & Me.Tag)
  End Sub

  Private Sub ExportarPorRubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorRubroToolStripMenuItem.Click
    Dim oList As New List(Of DataTable)
    Dim oDtRepo As New DataTable
    oDtRepo = oDtReporte.Copy
    Dim dtv As New DataView(oDtRepo)
    dtv.Sort = "CDVSN, CCLNT, NDCCTC DESC"
    oDtRepo = dtv.ToTable()

    oDtRepo.Columns.Remove("CCMPN")
    oDtRepo.Columns.Remove("CDVSN")
    oDtRepo.Columns.Remove("CZNFCC")
    oDtRepo.Columns.Remove("CTPODC")
    oDtRepo.Columns.Remove("TCMTPD")
    'oDtRepo.Columns.Remove("TCNTCS")
    'oDtRepo.Columns.Remove("CMNDA")
    oDtRepo.Columns.Remove("IVLDCD")
    oDtRepo.Columns.Remove("IVLIGS")
    oDtRepo.Columns.Remove("IVLIGD")
    'oDtRepo.Columns.Remove("CCNCSD")
    oDtRepo.Columns(0).ColumnName = "División"
    oDtRepo.Columns(1).ColumnName = "Zona"
    oDtRepo.Columns(2).ColumnName = "Tipo"
    oDtRepo.Columns(3).ColumnName = "Nro. Documento"
    oDtRepo.Columns(4).ColumnName = "Fecha"

    oDtRepo.Columns(5).ColumnName = "Tipo Moneda"
    oDtRepo.Columns(6).ColumnName = "Tipo Cambio"

    oDtRepo.Columns(7).ColumnName = "Código"
    oDtRepo.Columns(8).ColumnName = "Cliente"
    For i As Integer = 0 To oDtRepo.Rows.Count - 1
      oDtRepo.Rows(i).Item("IVLAFS") = oDtRepo.Rows(i).Item("IVLAFS") + oDtRepo.Rows(i).Item("IVLNAS")
      oDtRepo.Rows(i).Item("IVLAFD") = oDtRepo.Rows(i).Item("IVLAFD") + oDtRepo.Rows(i).Item("IVLNAD")
    Next
    oDtRepo.Columns.Remove("IVLNAS")
    oDtRepo.Columns.Remove("IVLNAD")
    oDtRepo.Columns(9).ColumnName = "Valor Venta (S/.)"
    'oDtRepo.Columns(8).ColumnName = "I.G.V"
    oDtRepo.Columns(10).ColumnName = "Valor Total (S/.)"
    oDtRepo.Columns(11).ColumnName = "Valor Venta (USD.)"
    oDtRepo.Columns(12).ColumnName = "Valor Total (USD.)"
    oDtRepo.Columns(13).ColumnName = "Cod. Centro Costo"
    oDtRepo.Columns(14).ColumnName = "Desc Centro Costo"
    oDtRepo.Columns(15).ColumnName = "Desc. Rubro"
    oDtRepo.Columns(16).ColumnName = "Monto Rubro"
    oDtRepo.Columns(17).ColumnName = "Centro Beneficio"

    oList.Add(oDtRepo)

    Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oList, "Registro de Ventas")
  End Sub
End Class
