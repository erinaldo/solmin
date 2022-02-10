Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class FormVisorReportesVentas
    Private oDtReporte As New DataTable

    Private _DataReport As DataSet
    Public Property DataReport() As DataSet
        Get
            Return _DataReport
        End Get
        Set(ByVal value As DataSet)
            _DataReport = value
        End Set
    End Property


    Private _pintMoneda As Integer
    Public Property pintMoneda() As Integer
        Get
            Return _pintMoneda
        End Get
        Set(ByVal value As Integer)
            _pintMoneda = value
        End Set
    End Property


    Private Sub FormVisorReportesVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.crvDetallexClientexRubroXCB.DisplayToolbar = True
        Me.crvDetallexClientexRubroXCB.DisplayStatusBar = True
        Me.crvDetallexClientexRubroXCB.Zoom(1)

        Me.crvDetalleXDocumento.DisplayToolbar = True
        Me.crvDetalleXDocumento.DisplayStatusBar = True
        Me.crvDetalleXDocumento.Zoom(1)

        Me.crvResumenXCentroBeneficio.DisplayToolbar = True
        Me.crvResumenXCentroBeneficio.DisplayStatusBar = True
        Me.crvResumenXCentroBeneficio.Zoom(1)

        Me.crvResumenxCliente.DisplayToolbar = True
        Me.crvResumenxCliente.DisplayStatusBar = True
        Me.crvResumenxCliente.Zoom(1)

        Me.crvResumenXDivision.DisplayToolbar = True
        Me.crvResumenXDivision.DisplayStatusBar = True
        Me.crvResumenXDivision.Zoom(1)

        Me.crvResumenXRubro.DisplayToolbar = True
        Me.crvResumenXRubro.DisplayStatusBar = True
        Me.crvResumenXRubro.Zoom(1)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim oList As New List(Of DataTable)
        Dim oDataSet As New DataSet
        Dim oDtRepo As New DataTable
        Dim oDTRepObs As New DataTable
        'Dim oCtaCte_ObservacionNeg As New SOLMIN_CTZ.NEGOCIO.clsCtaCte_Observacion
        'Dim oCtaCte_Observacion As New SOLMIN_CTZ.Entidades.CtaCte_Observacion
        Dim oDs As New DataSet
        Dim strlTitulo As New List(Of String)
        Dim LisFiltros As New List(Of SortedList)
        Dim Placa As String = ""
        'Dim itemSortedList As SortedList
        'Dim NFilas As New List(Of SortedList)

        Dim NPOI As New Ransa.Utilitario.HelpClass_NPOI_AD
        Dim oDtRepDocRubro As New DataTable
        Dim MdataColumna As String = ""
        Dim oListDtReport As New List(Of DataTable)
        oDtRepo = DataReport.Tables(0).Copy
        strlTitulo.Add("Registro de Ventas")
        strlTitulo.Add("Registro de Ventas")


        'oDtRepo.TableName = "DOCUMENTOS - RUBRO"
        'oDtRepo.Columns.Remove("CCMPN")
        'oDtRepo.Columns.Remove("CDVSN")
        'oDtRepo.Columns.Remove("CZNFCC")
        'oDtRepo.Columns.Remove("CTPODC")
        'oDtRepo.Columns.Remove("TCMTPD")
        'oDtRepo.Columns.Remove("IVLDCD")
        'oDtRepo.Columns.Remove("IVLIGS")
        'oDtRepo.Columns.Remove("IVLIGD")
        'oDtRepo.Columns(0).ColumnName = "División"
        'oDtRepo.Columns(1).ColumnName = "Zona"
        'oDtRepo.Columns(2).ColumnName = "Tipo"
        'oDtRepo.Columns(3).ColumnName = "Nro. Documento"
        'oDtRepo.Columns(4).ColumnName = "Fecha"

        'oDtRepo.Columns(5).ColumnName = "Tipo Moneda"
        'oDtRepo.Columns(6).ColumnName = "Tipo Cambio"

        'oDtRepo.Columns(7).ColumnName = "Código"
        'oDtRepo.Columns(8).ColumnName = "Cliente"

        'For i As Integer = 0 To oDtRepo.Rows.Count - 1
        '    oDtRepo.Rows(i).Item("IVLAFS") = oDtRepo.Rows(i).Item("IVLAFS") + oDtRepo.Rows(i).Item("IVLNAS")
        '    oDtRepo.Rows(i).Item("IVLAFD") = oDtRepo.Rows(i).Item("IVLAFD") + oDtRepo.Rows(i).Item("IVLNAD")
        'Next
        'oDtRepo.Columns.Remove("IVLNAS")
        'oDtRepo.Columns.Remove("IVLNAD")
        'oDtRepo.Columns(9).ColumnName = "Valor Venta (S/.)"
        'oDtRepo.Columns(10).ColumnName = "Valor Total (S/.)"
        'oDtRepo.Columns(11).ColumnName = "Valor Venta (USD.)"
        'oDtRepo.Columns(12).ColumnName = "Valor Total (USD.)"
        'oDtRepo.Columns(13).ColumnName = "Cod. Centro Beneficio AS400"
        'oDtRepo.Columns(14).ColumnName = "Desc Centro Beneficio"
        'oDtRepo.Columns(15).ColumnName = "Desc. Rubro"
        'oDtRepo.Columns(16).ColumnName = "Monto Rubro"
        'oDtRepo.Columns(17).ColumnName = "Centro Beneficio"

        'Dim dtv As New DataView(oDtRepo)
        'dtv.Sort = "TCMPDV, CCLNT, NDCCTC DESC"
        'oDtRepo = dtv.ToTable.DefaultView.ToTable

        'oDataSet.Tables.Add(oDtRepo)
        'oDTRepObs = DataReport.Tables(1).Copy


        'Dim datRow As DataRow
        'If oDtRepo.Rows.Count > 0 Then
        '    'Dim numDocumento As Decimal = -1
        '    'Dim dtObs As DataTable
        '    'Dim dtview As New DataView(oDTRepObs)
        '    'dtview.Sort = "TCMPDV, CCLNT, NDCCTC DESC"
        '    'oDTRepObs = dtview.ToTable()
        '    Dim dt As DataTable = _DataReport.Tables(0).Clone
        '    Dim dtRep As DataTable = _DataReport.Tables(0).Copy
        '    dt.TableName = "DOCUMENTOS"
        '    For intX As Long = 0 To dtRep.Rows.Count - 1
        '        Dim strObservacion As String = ""
        '        'If oDTRepObs.Rows(intX).Item("NDCCTC") <> numDocumento Then
        '        datRow = dt.NewRow
        '        'oCtaCte_Observacion.PSCCMPN = oDTRepObs.Rows(intX).Item("CCMPN")
        '        'oCtaCte_Observacion.CTPODC = oDTRepObs.Rows(intX).Item("CTPODC")
        '        'oCtaCte_Observacion.NDCCTC = oDTRepObs.Rows(intX).Item("NDCCTC")
        '        'dtObs = oCtaCte_ObservacionNeg.Lista_CtaCte_Observacion(oCtaCte_Observacion)
        '        For Each dr As DataRow In oDTRepObs.Select(String.Format("CTPODC={0} AND NDCCTC={1}", dtRep.Rows(intX).Item("CTPODC"), dtRep.Rows(intX).Item("NDCCTC")))
        '            strObservacion += dr("NCRDSC").ToString.Trim & "  " & dr("TOBCTC").ToString.Trim & Chr(10)
        '        Next
        '        datRow("TCMPDV") = dtRep.Rows(intX).Item("TCMPDV").ToString.Trim
        '        datRow("TZNFCC") = dtRep.Rows(intX).Item("TZNFCC").ToString.Trim
        '        datRow("TABTPD") = dtRep.Rows(intX).Item("TABTPD").ToString.Trim
        '        datRow("NDCCTC") = dtRep.Rows(intX).Item("NDCCTC")
        '        datRow("FE_CNTA_CNTE") = dtRep.Rows(intX).Item("FE_CNTA_CNTE").ToString.Trim
        '        datRow("CMNDA") = dtRep.Rows(intX).Item("CMNDA").ToString.Trim
        '        datRow("ITCCTC") = dtRep.Rows(intX).Item("ITCCTC")
        '        datRow("CCLNT") = dtRep.Rows(intX).Item("CCLNT")
        '        datRow("TCMPCL") = dtRep.Rows(intX).Item("TCMPCL").ToString.Trim
        '        datRow("IVLAFS") = dtRep.Rows(intX).Item("IVLAFS") + dtRep.Rows(intX).Item("IVLNAS")
        '        datRow("IVLAFD") = dtRep.Rows(intX).Item("IVLAFD") + dtRep.Rows(intX).Item("IVLNAD")
        '        datRow("ITTFCS") = dtRep.Rows(intX).Item("ITTFCS")
        '        datRow("ITTFCD") = dtRep.Rows(intX).Item("ITTFCD")
        '        datRow("TCNTCS") = strObservacion
        '        dt.Rows.Add(datRow)
        '        'numDocumento = oDTRepObs.Rows(intX).Item("NDCCTC")
        '        'End If
        '    Next

        '    dt.Columns.Remove("CCMPN")
        '    dt.Columns.Remove("CDVSN")
        '    dt.Columns.Remove("CZNFCC")
        '    dt.Columns.Remove("CTPODC")
        '    dt.Columns.Remove("TCMTPD")
        '    'oDtRepo.Columns.Remove("TCNTCS")
        '    'oDtRepo.Columns.Remove("CMNDA")
        '    dt.Columns.Remove("IVLDCD")
        '    dt.Columns.Remove("IVLIGS")
        '    dt.Columns.Remove("IVLIGD")
        '    dt.Columns.Remove("IVLNAS")
        '    dt.Columns.Remove("IVLNAD")

        '    dt.Columns.Remove("CCNCSD")
        '    dt.Columns.Remove("TCMTRF")
        '    dt.Columns.Remove("IVLDCS")
        '    dt.Columns.Remove("CCNBNS")

        '    'oDtRepo.Columns.Remove("CCNCSD")
        '    dt.Columns(0).ColumnName = "División"
        '    dt.Columns(1).ColumnName = "Zona"
        '    dt.Columns(2).ColumnName = "Tipo"
        '    dt.Columns(3).ColumnName = "Nro. Documento"
        '    dt.Columns(4).ColumnName = "Fecha"

        '    dt.Columns(5).ColumnName = "Tipo Moneda"
        '    dt.Columns(6).ColumnName = "Tipo Cambio"

        '    dt.Columns(7).ColumnName = "Código"
        '    dt.Columns(8).ColumnName = "Cliente"


        '    dt.Columns(9).ColumnName = "Valor Venta (S/.)"
        '    'oDtRepo.Columns(8).ColumnName = "I.G.V"
        '    dt.Columns(10).ColumnName = "Valor Total (S/.)"
        '    dt.Columns(11).ColumnName = "Valor Venta (USD.)"
        '    dt.Columns(12).ColumnName = "Valor Total (USD.)"
        '    dt.Columns(13).ColumnName = "Observación"

        '    oDataSet.Tables.Add(dt)
        'End If

        '' Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oList, "Registro de Ventas")
        'Dim lst As New List(Of String)
        'Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDataSet, "Registro de Ventas", lst)

        With oDtRepDocRubro
            MdataColumna = NPOI.FormatDato("División", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCMPDV").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Zona", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TZNFCC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TABTPD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Número" & Chr(10) & "Documento", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("NDCCTC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Fecha", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoFecha)
            .Columns.Add("FE_CNTA_CNTE").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo" & Chr(10) & "Moneda", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("CMNDA").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo" & Chr(10) & "Cambio", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("ITCCTC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Código Cliente", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("CCLNT").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Cliente", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCMPCL").Caption = MdataColumna

            If pintMoneda <> 100 Then
                MdataColumna = NPOI.FormatDato("Valor" & Chr(10) & "Venta (S/.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
                .Columns.Add("IVLAFS").Caption = MdataColumna
                MdataColumna = NPOI.FormatDato("Valor" & Chr(10) & "Total (S/.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
                .Columns.Add("ITTFCS").Caption = MdataColumna
            End If

            MdataColumna = NPOI.FormatDato("Valor" & Chr(10) & "Venta (USD.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
            .Columns.Add("IVLAFD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Valor" & Chr(10) & "Total (USD.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
            .Columns.Add("ITTFCD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Cod. Centro" & Chr(10) & "Beneficio AS400", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("CCNCSD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Desc Centro Beneficio", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCNTCS").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Desc. Rubro", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCMTRF").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Monto Rubro", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
            .Columns.Add("IVLDCS").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Centro Beneficio", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("CCNBNS").Caption = MdataColumna
        End With
        Dim dtRow As DataRow
        For intX As Long = 0 To oDtRepo.Rows.Count - 1
            dtRow = oDtRepDocRubro.NewRow
            dtRow("TCMPDV") = oDtRepo.Rows(intX).Item("TCMPDV").ToString.Trim
            dtRow("TZNFCC") = oDtRepo.Rows(intX).Item("TZNFCC").ToString.Trim
            dtRow("TABTPD") = oDtRepo.Rows(intX).Item("TABTPD").ToString.Trim
            dtRow("NDCCTC") = oDtRepo.Rows(intX).Item("NDCCTC")
            dtRow("FE_CNTA_CNTE") = oDtRepo.Rows(intX).Item("FE_CNTA_CNTE").ToString.Trim
            dtRow("CMNDA") = oDtRepo.Rows(intX).Item("CMNDA").ToString.Trim
            dtRow("ITCCTC") = oDtRepo.Rows(intX).Item("ITCCTC")
            dtRow("CCLNT") = oDtRepo.Rows(intX).Item("CCLNT")
            dtRow("TCMPCL") = oDtRepo.Rows(intX).Item("TCMPCL").ToString.Trim
            If pintMoneda <> 100 Then
                dtRow("IVLAFS") = oDtRepo.Rows(intX).Item("IVLAFS") + oDtRepo.Rows(intX).Item("IVLNAS")
                dtRow("ITTFCS") = oDtRepo.Rows(intX).Item("ITTFCS")
            End If

            dtRow("IVLAFD") = oDtRepo.Rows(intX).Item("IVLAFD") + oDtRepo.Rows(intX).Item("IVLNAD")
            If pintMoneda = 100 Then
                dtRow("ITTFCD") = oDtRepo.Rows(intX).Item("ITTFCS")  'oDtRepo.Rows(intX).Item("ITTFCD")
            Else
                dtRow("ITTFCD") = oDtRepo.Rows(intX).Item("ITTFCD")
            End If

            dtRow("CCNCSD") = oDtRepo.Rows(intX).Item("CCNCSD")
            dtRow("TCNTCS") = oDtRepo.Rows(intX).Item("TCNTCS").ToString.Trim
            dtRow("TCMTRF") = oDtRepo.Rows(intX).Item("TCMTRF").ToString.Trim
            dtRow("IVLDCS") = oDtRepo.Rows(intX).Item("IVLDCS")
            dtRow("CCNBNS") = oDtRepo.Rows(intX).Item("CCNBNS").ToString.Trim
            oDtRepDocRubro.Rows.Add(dtRow)
        Next
        oDtRepDocRubro.TableName = "DOCUMENTOS - RUBRO"
        Dim oDtRepDocumentos As New DataTable
        oDTRepObs = DataReport.Tables(1).Copy
        With oDtRepDocumentos
            MdataColumna = NPOI.FormatDato("División", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCMPDV").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Zona", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TZNFCC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TABTPD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Número" & Chr(10) & "Documento", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("NDCCTC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Fecha", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoFecha)
            .Columns.Add("FE_CNTA_CNTE").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo" & Chr(10) & "Moneda", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("CMNDA").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Tipo" & Chr(10) & "Cambio", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("ITCCTC").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Código Cliente", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoNumero)
            .Columns.Add("CCLNT").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Cliente", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TCMPCL").Caption = MdataColumna
            If pintMoneda <> 100 Then

                MdataColumna = NPOI.FormatDato("Valor Venta (S/.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
                .Columns.Add("IVLAFS").Caption = MdataColumna
                MdataColumna = NPOI.FormatDato("Valor Total (S/.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
                .Columns.Add("ITTFCS").Caption = MdataColumna
            End If


            MdataColumna = NPOI.FormatDato("Valor Venta (USD.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
            .Columns.Add("IVLAFD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Valor Total (USD.)", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoMonto)
            .Columns.Add("ITTFCD").Caption = MdataColumna
            MdataColumna = NPOI.FormatDato("Observación", Ransa.Utilitario.HelpClass_NPOI_AD.keyDatoTexto)
            .Columns.Add("TOBCTC").Caption = MdataColumna
        End With
        Dim datRow As DataRow
        Dim obs As String = ""
        For intX As Long = 0 To oDtRepo.Rows.Count - 1
            Dim strObservacion As String = ""
            datRow = oDtRepDocumentos.NewRow
            For Each dr As DataRow In oDTRepObs.Select(String.Format("CTPODC={0} AND NDCCTC={1}", oDtRepo.Rows(intX).Item("CTPODC"), oDtRepo.Rows(intX).Item("NDCCTC")))
                obs = dr("TOBCTC").ToString.Trim
                If obs.Length > 0 Then
                    strObservacion += dr("NCRDSC").ToString.Trim & "  " & obs & Chr(10)
                End If
            Next
            datRow("TCMPDV") = oDtRepo.Rows(intX).Item("TCMPDV").ToString.Trim
            datRow("TZNFCC") = oDtRepo.Rows(intX).Item("TZNFCC").ToString.Trim
            datRow("TABTPD") = oDtRepo.Rows(intX).Item("TABTPD").ToString.Trim
            datRow("NDCCTC") = oDtRepo.Rows(intX).Item("NDCCTC")
            datRow("FE_CNTA_CNTE") = oDtRepo.Rows(intX).Item("FE_CNTA_CNTE").ToString.Trim
            datRow("CMNDA") = oDtRepo.Rows(intX).Item("CMNDA").ToString.Trim
            datRow("ITCCTC") = oDtRepo.Rows(intX).Item("ITCCTC")
            datRow("CCLNT") = oDtRepo.Rows(intX).Item("CCLNT")
            datRow("TCMPCL") = oDtRepo.Rows(intX).Item("TCMPCL").ToString.Trim

            If pintMoneda <> 100 Then
                datRow("IVLAFS") = oDtRepo.Rows(intX).Item("IVLAFS") + oDtRepo.Rows(intX).Item("IVLNAS")
                datRow("ITTFCS") = oDtRepo.Rows(intX).Item("ITTFCS")
            End If

            datRow("IVLAFD") = oDtRepo.Rows(intX).Item("IVLAFD") + oDtRepo.Rows(intX).Item("IVLNAD")
            If pintMoneda = 100 Then
                datRow("ITTFCD") = oDtRepo.Rows(intX).Item("ITTFCS")   'oDtRepo.Rows(intX).Item("ITTFCD")
            Else
                datRow("ITTFCD") = oDtRepo.Rows(intX).Item("ITTFCD")
            End If

            datRow("TOBCTC") = strObservacion
            oDtRepDocumentos.Rows.Add(datRow)
        Next
        oDtRepDocumentos.TableName = "DOCUMENTOS"

        oListDtReport.Add(oDtRepDocRubro)
        oListDtReport.Add(oDtRepDocumentos)
        Dim olString As New List(Of String)


        'Dim itemSortedListnfilas As New SortedList
        'NFilas.Add(itemSortedListnfilas)
        'itemSortedListnfilas = New SortedList
        'itemSortedListnfilas.Add("TOBCTC")
        'NFilas.Add(itemSortedListnfilas)
        'olString.Add("NPLCUN|")
        Dim ListNFilas As New List(Of String)
        ListNFilas.Add("")
        ListNFilas.Add("TOBCTC")
        NPOI.ExportExcelGeneralMultiple(oListDtReport, strlTitulo, ListNFilas, LisFiltros, Nothing)

      
    End Sub
    Private Sub CrearTablaReporte(ByVal dt As DataTable)

    End Sub
End Class
