Imports Ransa.Utilitario
Public Class frmVisorVentasDetalladoDoc
    Private oDtReporte As New DataTable
    Private intMonedaFac As Int16

    Public WriteOnly Property MonedaFactura() As Int16
        Set(ByVal value As Int16)
            intMonedaFac = value
        End Set
    End Property

    Public Sub New(ByVal objCuentaCorrienteDoc As rptVentasDetalladoDocumento, ByVal oDt As DataTable)
        InitializeComponent()
        oDtReporte = oDt.Copy
        CrystalReportViewer1.ReportSource = objCuentaCorrienteDoc
    End Sub
    Private Sub frmVisorVentasDetallado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExportarPorCentroDeCostoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorCentroDeCostoToolStripMenuItem.Click

        Try
            Dim NPOI As New HelpClass_NPOI_AD
            Dim TipoDato As String = ""
            Dim MdataColumna As String = ""

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

            'TipoDato = HelpClass_NPOI_SC.keyDatoNumero

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("División", TipoDato)
            oDtRepo.Columns(0).Caption = MdataColumna
            oDtRepo.Columns(0).ColumnName = "División"


            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Zona", TipoDato)
            oDtRepo.Columns(1).Caption = MdataColumna
            oDtRepo.Columns(1).ColumnName = "Zona"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Tipo", TipoDato)
            oDtRepo.Columns(2).Caption = MdataColumna
            oDtRepo.Columns(2).ColumnName = "Tipo"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Nro. Documento", TipoDato)
            oDtRepo.Columns(3).Caption = MdataColumna
            oDtRepo.Columns(3).ColumnName = "Nro. Documento"

            TipoDato = HelpClass_NPOI_AD.keyDatoFecha
            MdataColumna = NPOI.FormatDato("Fecha", TipoDato)
            oDtRepo.Columns(4).Caption = MdataColumna
            oDtRepo.Columns(4).ColumnName = "Fecha"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Tipo Cambio", TipoDato)
            oDtRepo.Columns(5).Caption = MdataColumna
            oDtRepo.Columns(5).ColumnName = "Tipo Cambio"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Código", TipoDato)
            oDtRepo.Columns(6).Caption = MdataColumna
            oDtRepo.Columns(6).ColumnName = "Código"


            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Cliente", TipoDato)
            oDtRepo.Columns(7).Caption = MdataColumna
            oDtRepo.Columns(7).ColumnName = "Cliente"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Venta", TipoDato)
            oDtRepo.Columns(8).Caption = MdataColumna
            oDtRepo.Columns(8).ColumnName = "Valor Venta"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("I.G.V", TipoDato)
            oDtRepo.Columns(9).Caption = MdataColumna
            oDtRepo.Columns(9).ColumnName = "I.G.V"


            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Total", TipoDato)
            oDtRepo.Columns(10).Caption = MdataColumna
            oDtRepo.Columns(10).ColumnName = "Valor Total"

            'TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            'MdataColumna = NPOI.FormatDato("Cod. Centro Costo", TipoDato)
            'oDtRepo.Columns(11).Caption = MdataColumna
            'oDtRepo.Columns(11).ColumnName = "Cod. Centro Costo"

            'TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            'MdataColumna = NPOI.FormatDato("Desc. Centro Costo", TipoDato)
            'oDtRepo.Columns(12).Caption = MdataColumna
            'oDtRepo.Columns(12).ColumnName = "Desc. Centro Costo"

            'TipoDato = HelpClass_NPOI_SC.keyDatoNumero
            'MdataColumna = NPOI.FormatDato("Monto Centro Costo", TipoDato)
            'oDtRepo.Columns(13).Caption = MdataColumna
            'oDtRepo.Columns(13).ColumnName = "Monto Centro Costo"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Centro Beneficio", TipoDato)
            oDtRepo.Columns(14).Caption = MdataColumna
            oDtRepo.Columns(14).ColumnName = "Centro Beneficio"

            oList.Add(oDtRepo)

            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(1) = "Entrega Almacén Desde  | " & Me.dtpFecIni.Value.ToShortDateString & " al " & Me.dtpFecFin.Value.ToShortDateString
            ' Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oList, "Registro de Ventas" & " - " & Me.Tag)
            HelpClass_NPOI_AD.ExportExcelGeneralRelease(oDtRepo, "REGISTRO DE VENTAS" & " - " & Me.Tag, Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub ExportarPorRubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorRubroToolStripMenuItem.Click
        Try
            Dim oList As New List(Of DataTable)
            Dim NPOI As New HelpClass_NPOI_AD
            Dim TipoDato As String = ""
            Dim MdataColumna As String = ""

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

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("División", TipoDato)
            oDtRepo.Columns(0).Caption = MdataColumna
            oDtRepo.Columns(0).ColumnName = "División"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Zona", TipoDato)
            oDtRepo.Columns(1).Caption = MdataColumna
            oDtRepo.Columns(1).ColumnName = "Zona"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Tipo", TipoDato)
            oDtRepo.Columns(2).Caption = MdataColumna
            oDtRepo.Columns(2).ColumnName = "Tipo"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Nro. Documento", TipoDato)
            oDtRepo.Columns(3).Caption = MdataColumna
            oDtRepo.Columns(3).ColumnName = "Nro. Documento"

            TipoDato = HelpClass_NPOI_AD.keyDatoFecha
            MdataColumna = NPOI.FormatDato("Fecha", TipoDato)
            oDtRepo.Columns(4).Caption = MdataColumna
            oDtRepo.Columns(4).ColumnName = "Fecha"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Tipo Moneda", TipoDato)
            oDtRepo.Columns(5).Caption = MdataColumna
            oDtRepo.Columns(5).ColumnName = "Tipo Moneda"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Tipo Cambio", TipoDato)
            oDtRepo.Columns(6).Caption = MdataColumna
            oDtRepo.Columns(6).ColumnName = "Tipo Cambio"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Código", TipoDato)
            oDtRepo.Columns(7).Caption = MdataColumna
            oDtRepo.Columns(7).ColumnName = "Código"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Cliente", TipoDato)
            oDtRepo.Columns(8).Caption = MdataColumna
            oDtRepo.Columns(8).ColumnName = "Cliente"

            For i As Integer = 0 To oDtRepo.Rows.Count - 1
                oDtRepo.Rows(i).Item("IVLAFS") = oDtRepo.Rows(i).Item("IVLAFS") + oDtRepo.Rows(i).Item("IVLNAS")
                oDtRepo.Rows(i).Item("IVLAFD") = oDtRepo.Rows(i).Item("IVLAFD") + oDtRepo.Rows(i).Item("IVLNAD")
            Next
            oDtRepo.Columns.Remove("IVLNAS")
            oDtRepo.Columns.Remove("IVLNAD")

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Venta (S/.)", TipoDato)
            oDtRepo.Columns(9).Caption = MdataColumna
            oDtRepo.Columns(9).ColumnName = "Valor Venta (S/.)"

            'oDtRepo.Columns(8).ColumnName = "I.G.V"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Total (S/.)", TipoDato)
            oDtRepo.Columns(10).Caption = MdataColumna
            oDtRepo.Columns(10).ColumnName = "Valor Total (S/.)"

            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Venta (USD.)", TipoDato)
            oDtRepo.Columns(11).Caption = MdataColumna
            oDtRepo.Columns(11).ColumnName = "Valor Venta (USD.)"


            TipoDato = HelpClass_NPOI_AD.keyDatoNumero
            MdataColumna = NPOI.FormatDato("Valor Total (USD.)", TipoDato)
            oDtRepo.Columns(12).Caption = MdataColumna
            oDtRepo.Columns(12).ColumnName = "Valor Total (USD.)"

            'TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            'MdataColumna = NPOI.FormatDato("Cod. Centro Costo", TipoDato)
            'oDtRepo.Columns(13).Caption = MdataColumna
            'oDtRepo.Columns(13).ColumnName = "Cod. Centro Costo"

            'TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            'MdataColumna = NPOI.FormatDato("Desc Centro Costo", TipoDato)
            'oDtRepo.Columns(14).Caption = MdataColumna
            'oDtRepo.Columns(14).ColumnName = "Desc Centro Costo"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Desc. Rubro", TipoDato)
            oDtRepo.Columns(15).Caption = MdataColumna
            oDtRepo.Columns(15).ColumnName = "Desc. Rubro"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Monto Rubro", TipoDato)
            oDtRepo.Columns(16).Caption = MdataColumna
            oDtRepo.Columns(16).ColumnName = "Monto Rubro"

            TipoDato = HelpClass_NPOI_AD.keyDatoTexto
            MdataColumna = NPOI.FormatDato("Centro Beneficio", TipoDato)
            oDtRepo.Columns(17).Caption = MdataColumna
            oDtRepo.Columns(17).ColumnName = "Centro Beneficio"

            oList.Add(oDtRepo)

            '  Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oList, "Registro de Ventas")
            HelpClass_NPOI_AD.ExportExcelGeneralRelease(oDtRepo, "REGISTRO DE VENTAS" & " - " & Me.Tag, Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
