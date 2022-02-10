Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Web

<DefaultProperty("Text"), ToolboxData("<{0}:ExportBar runat=server></{0}:ExportBar>")> _
Public Class ExportBar
    Inherits WebControl

    Private webCache As System.Web.Caching.Cache
    Private _ExportText As String = ""
    Private _AjaxProcessMessage As String = ""
    Private _ImageDirectory As String = ""
    Private _Exportpage As String = ""
    Public WithEvents wordButton As New ImageButton
    Public WithEvents excelButton As New ImageButton
    Public WithEvents pdfButton As New ImageButton

    Public Enum TipoReporte
        PDF = 1
        Excel = 2
        Word = 3
    End Enum 

    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> _
    Public Property ExportPage() As String
        Get
            Return _Exportpage
        End Get
        Set(ByVal value As String)
            _Exportpage = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> _
    Public Property ExportText() As String
        Get 
            Return _ExportText
        End Get
        Set(ByVal value As String)
            _ExportText = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("Procesando Reporte..."), Localizable(True)> _
    Public Property AjaxProcessMessage() As String
        Get
            Return _AjaxProcessMessage
        End Get
        Set(ByVal value As String)
            ViewState("AjaxProcessMessage") = value
            _ExportText = value
        End Set
    End Property

    Protected Overrides Sub RenderContents(ByVal output As HtmlTextWriter)
        Me.RenderWebControl(output)
    End Sub

    Private Sub CrystalReport()

        Dim reporte As New ReportDocument()
        webCache = System.Web.HttpContext.Current.Cache
        reporte.Load(System.Web.HttpContext.Current.Server.MapPath("reportes/" & webCache.Get("REPORTNAME")), CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
        reporte.SetDataSource(DirectCast(webCache.Get("REPORTDOCUMENT"), DataSet))

        If webCache.Get("REPORTDOCUMENT") IsNot Nothing Then
            webCache.Remove("REPORTDOCUMENT")
        End If

        webCache.Insert("REPORTDOCUMENT", reporte)

    End Sub

    Private Sub RenderWebControl(ByVal out As HtmlTextWriter)

          'Etiqueta Principal
        out.WriteLine("<TABLE width=""100%"">")

        out.WriteLine("<TR>")

        'Texto que muestra el mensaje de exportacion
        out.WriteLine("<TD align=""LEFT"" width=""80%"">")
        out.WriteLine("&nbsp;")
        out.WriteLine(_ExportText)
        out.WriteLine("</TD>")

        'Imagenes que procesan la exportacion de los reportes
        out.WriteLine("<TD align=""RIGHT"" width=""20%"">")
        wordButton.ImageUrl = System.Web.HttpContext.Current.Server.MapPath("images/imgWORD.PNG")
        wordButton.RenderControl(out)
        out.WriteLine("&nbsp;|&nbsp;")
        wordButton.ImageUrl = System.Web.HttpContext.Current.Server.MapPath("images/imgEXCEL.PNG")
        excelButton.RenderControl(out)
        out.WriteLine("&nbsp;|&nbsp;")
        wordButton.ImageUrl = System.Web.HttpContext.Current.Server.MapPath("images/imgPDF.PNG")
        pdfButton.RenderControl(out)
        out.WriteLine("</TD>")

        'Etiqueta Final
        out.WriteLine("</TABLE>")

        'Agrega Código JavaScript para procesar los reportes

        out.WriteLine("<script language=""JavaScript"">")
        out.WriteLine("function ctl_export_open_window(){")
        out.WriteLine("window.open('" & Me._Exportpage & "','" & Me._Exportpage & "','');")
        out.WriteLine("}")
        out.WriteLine("</script>")

    End Sub

    Public Overrides Property CssClass() As String
        Get
            Return MyBase.CssClass
        End Get
        Set(ByVal value As String)
            MyBase.CssClass = value
        End Set
    End Property
 
    Private Sub export_process(ByVal tipo As TipoReporte)

        webCache = System.Web.HttpContext.Current.Cache
        Dim objStream As IO.Stream = Nothing
        Dim objrpt As New ReportDocument
        objrpt = CType(webCache.Get("REPORTDOCUMENT"), ReportDocument)
        If tipo = TipoReporte.PDF Then

            webCache.Insert("APPTYPE", "application/pdf")
            webCache.Insert("CONTENT", "attachment;filename=ransanet.pdf")
            objStream = objrpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)

        ElseIf tipo = TipoReporte.Excel Then

            webCache.Insert("APPTYPE", "application/vnd.ms-excel")
            webCache.Insert("CONTENT", "attachment;filename=ransanet.xls")
            objStream = objrpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.ExcelRecord)

        Else

            webCache.Insert("APPTYPE", "application/msword")
            webCache.Insert("CONTENT", "attachment;filename=ransanet.doc")
            objStream = objrpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)

        End If

        webCache.Insert("STREAM", objStream)

    End Sub
 
    Private Sub excelButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles excelButton.Click
        Try
            CrystalReport()
            export_process(TipoReporte.Excel)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pdfButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles pdfButton.Click
        export_process(TipoReporte.PDF)
    End Sub

    Private Sub wordButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles wordButton.Click
        export_process(TipoReporte.Word)
    End Sub

End Class
