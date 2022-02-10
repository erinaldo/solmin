Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO
Imports RANSA.TYPEDEF
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports System.Globalization
Public Class frmImpresionMasiva
#Region " Atributos "
    Private intCCLNT As Int64 = 0
    Private strNRGUIA As String = ""
    Private blnSelect As Boolean = False

    Public strCompania As String = ""
    Public strDivision As String = ""
    Public dblPlanta As Double = 0

    Private odtInfoGuia As New DataTable
    Private PSNGUIRM As String = ""
    Private ListaGuia As New List(Of String)
    Private ListaGuiaTMP As New List(Of String)

    Private numGuias As Int32 = 0
    Private prtSettings As Printing.PrinterSettings
    Private PSMODELO As String = ""

    Private dstParamRpt As New DataSet
    Private drParamRpt As DataRow()

#End Region
#Region " Propiedades "
 


    Private _obeGuiaRemision As beGuiaRemision
    Public Property obeGuiaRemision() As beGuiaRemision
        Get
            Return _obeGuiaRemision
        End Get
        Set(ByVal value As beGuiaRemision)
            _obeGuiaRemision = value
        End Set
    End Property


#End Region
#Region " Procedimientos y Funciones "
   
    Private Sub pListarGuiasRemision()
        Dim obrGuiasRemision As New DespachoSAT.brGuiasRemision
        dgGuiasRemision.AutoGenerateColumns = False
        dgGuiasRemision.DataSource = obrGuiasRemision.fnListGuiasRemisionSAT(_obeGuiaRemision)
    End Sub
#End Region


    Private Sub frmImpresionMasiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call pListarGuiasRemision()
    End Sub

    Private Sub bsaVistaPreviaGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVistaPreviaGR.Click

        If dgGuiasRemision.RowCount > 0 Then
            dgGuiasRemision.EndEdit()
            ' VistraPreviaGuiaRemision_X_Guia()
            VistaPreviGuiaRemisionMasiva()
        End If
    End Sub

    Private Sub VistraPreviaGuiaRemision_X_Guia()
        Dim oDsPadre As New DataSet
        Dim oDs As New DataSet
        Dim oDt As New DataTable
        Dim oDrp As DataRow
        Dim intPrimero As Integer = 0
        Dim obeGuiaRemision As RANSA.TypeDef.beGuiaRemision = New RANSA.TypeDef.beGuiaRemision
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Dim obrGuiaRemision As New RANSA.NEGO.DespachoSAT.brGuiasRemision

        For Each row As DataGridViewRow In dgGuiasRemision.Rows
            If row.Cells("CHK").Value Then
                obeGuiaRemision = New RANSA.TypeDef.beGuiaRemision
                ' NGUIRMs += "" + row.Cells("GR_NGUIRM").Value + ", "
                With obeGuiaRemision
                    .PNCCLNT = intCCLNT
                    .PSNGUIRM = Val(row.Cells("GR_NGUIRM").Value)
                    .PSCCMPN = strCompania
                    .PSCDVSN = strDivision
                    .PNCPLNDV = dblPlanta
                End With
                oDs = obrGuiaRemision.fdstDataGuiaRemision(obeGuiaRemision)
                If oDt.Rows.Count = 0 Then
                    oDt = oDs.Tables(0).Clone
                End If

                For Each oDr As DataRow In oDs.Tables(0).Rows
                    oDrp = oDt.NewRow
                    For intColums As Integer = 0 To oDs.Tables(0).Columns.Count - 1
                        oDrp.Item(intColums) = oDr.Item(intColums)
                    Next
                    oDt.Rows.Add(oDrp)
                Next

            End If
        Next

        oDsPadre.Tables.Add(oDt)
        ' oDs = obrGuiaRemision.fdstDataGuiaRemision(obeGuiaRemision)

        If oDs Is Nothing OrElse oDs.Tables.Count = 0 OrElse oDs.Tables.Item(0).Rows.Count = 0 Then Exit Sub
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case obeGuiaRemision.PSMODELO
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionM01
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionM02
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionM03
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionM04
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionM05
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M5A"
                rdocGuiaRemision = New rptGuiaRemisionM05A
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5B"
                rdocGuiaRemision = New rptGuiaRemisionM05B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionM06
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M7"
                rdocGuiaRemision = New rptGuiaRemisionM07
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M9"
                rdocGuiaRemision = New rptGuiaRemisionM09
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M9B"
                rdocGuiaRemision = New rptGuiaRemisionM09B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M10"
                rdocGuiaRemision = New rptGuiaRemisionM10
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M12"
                rdocGuiaRemision = New rptGuiaRemisionM012
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionM01
        End Select
        rdocGuiaRemision.SetDataSource(oDsPadre)
        rdocGuiaRemision.Refresh()

        ' ''prueba----------
        'rdocGuiaRemision = New CopiarptGuiaRemisionM05()
        ''-------prueba

        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub

    Private Sub VistaPreviGuiaRemisionMasiva()
        Try
            ListaGuia.Clear()
            odtInfoGuia = UnificarGuia()
            ListaGuiaTMP.Clear()
            ListaGuiaTMP.AddRange(ListaGuia)

            numGuias = ListaGuia.Count
            dstParamRpt.ReadXml("Servidores.xml")
            drParamRpt = dstParamRpt.Tables("ParamGuiaRemisionAT_RPT").Select("ModReporte='" & PSMODELO & "'")
            Select Case PSMODELO
                Case "M1"

                Case "M2"

                Case "M3"

                Case "M4"

                Case "M5"
                    Imprime_Guia_M5B(True)
                Case "M5A"

                Case "M5B"
                    Imprime_Guia_M5B(True)
                Case "M6"

                Case "M7"

                Case "M9"

                Case "M9B"

                Case "M10"

                Case "M12"

                Case Else

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgGuiasRemision_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgGuiasRemision.ColumnHeaderMouseClick
        dgGuiasRemision.EndEdit()
        If dgGuiasRemision.Columns(e.ColumnIndex).Name = "CHK" Then
            For Each row As DataGridViewRow In dgGuiasRemision.Rows
                row.Cells("CHK").Value = IIf(blnSelect, False, True)
            Next
            blnSelect = IIf(blnSelect, False, True)
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrueba.Click
        VistaPreviGuiaRemisionMasiva()
    End Sub
    Private Function seleccionarImpresora() As Boolean
        Dim prtDialog As New PrintDialog
        With prtDialog
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = False
            '.PrinterSettings = prtSettings
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                prtSettings = New Printing.PrinterSettings
                prtSettings = .PrinterSettings
            Else
                Return False
            End If
        End With
        Return True
    End Function

#Region "FORMATO M5B"
    Private Sub Imprimir_M5B(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListaGuia.Clear()
        'ListaGuiaTMP.Clear()
        ListaGuia.AddRange(ListaGuiaTMP)
        Imprime_Guia_M5B(False)
    End Sub

    Public Sub Imprime_Guia_M5B(ByVal esPreview As Boolean)
        Try
            Dim btnImprimir As New ToolStripButton
            btnImprimir.Text = "Imprimir"
            btnImprimir.Image = SOLMIN_SA.My.Resources.Resources.ico_impresora
            btnImprimir.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            AddHandler btnImprimir.Click, AddressOf Me.Imprimir_M5B

            Dim prn As New Printing.PrintDocument
            Dim preview As New PrintPreviewDialog
            Dim frmPrintPreview As New frmPrintPreview

            Dim SizePersonal As Printing.PaperSize
            Dim Ancho As Int32 = drParamRpt(0)("Ancho")
            Dim Alto As Int32 = drParamRpt(0)("Alto")
            SizePersonal = New Printing.PaperSize("imp", Ancho, Alto)

            With prn
                AddHandler prn.PrintPage, AddressOf Me.PrintPageHandlerM5B
                If esPreview Then
                    Dim prtPrev As New PrintPreviewDialog
                    prtPrev.Document = prn
                    prtPrev.Text = "Previsualizar documento."
                    DirectCast((prtPrev.Controls(1)), ToolStrip).Items.RemoveAt(0)
                    DirectCast((prtPrev.Controls(1)), ToolStrip).Items.Insert(0, btnImprimir)
                    CType(prtPrev, Form).WindowState = FormWindowState.Maximized
                    prtPrev.ShowDialog()
                Else
                    If seleccionarImpresora() = False Then
                        Return
                    Else
                        prn.PrinterSettings = prtSettings
                        prn.DefaultPageSettings.PaperSize = SizePersonal
                    End If
                    prn.Print()
                    RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandlerM5B
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PrintPageHandlerM5B(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim odt As New DataTable

        Dim lboolEstado As Int32 = 0
        Dim iPosDes As Integer = 0
        'DEFINICION POSICIONES
        Dim PosLeftCab As Int32 = 90
        Dim PosLeftCuerpo As Int32 = 10
        Dim PosLeftPie As Int32 = 140
        Dim PosLeftCabDetalle As Int32 = 20
        Dim PosY As Int32 = 0
        Dim rX As Int32 = 120 'espaciado entre las X
        Dim EspaciadoY As Int32 = 20
        Dim PosX As Int32 = 0

        Dim myFont As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim myFontX As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim F As New Font(myFont, FontStyle.Regular)

        Dim DetDescripcion() As String
        Dim dfi As DateTimeFormatInfo = New DateTimeFormatInfo()
        Dim ci As CultureInfo = New CultureInfo("es-ES")
        Dim intPosLinea As Integer = 0
        Dim drGuias() As DataRow

        Dim i As Int32 = 0
        While i <= 0 And ListaGuia.Count > 0
            Me.PSNGUIRM = ListaGuia(i)
            drGuias = odtInfoGuia.Select("NGUIRM='" & Me.PSNGUIRM & "'")
            'REINICIO DE POSICIONES PRINT***********'
            PosY = 170
            '***************************************'
            If (drGuias.Length > 0) Then
                'TCMPPL
                'TCMPPL
                'TDRCBP
                args.Graphics.DrawString(drGuias(0).Item("NUEVODIR").ToString.Trim, F, Brushes.Black, 85, 20)
                args.Graphics.DrawString(drGuias(0).Item("TCMPPL").ToString.Trim, F, Brushes.Black, PosLeftCab, PosY)

                PosY += EspaciadoY

                args.Graphics.DrawString(CType(drGuias(0).Item("FGUIRM").ToString, Date).ToString("dd MMMM yyyy", ci), F, Brushes.Black, PosLeftCab + 480, PosY)
                args.Graphics.DrawString(drGuias(0)("FGUIAUNICO").ToString.Trim, F, Brushes.Black, PosLeftCab + 620, PosY)

                '-------------------------------------------------------------
                Dim strDirecion As String = ""
                Dim strDirec01 As String = ""
                Dim strDirec02 As String = ""
                Dim intSum As Integer = 0
                strDirecion = drGuias(0).Item("TDRCPL").ToString.Trim
                For intRows As Integer = 0 To strDirecion.Split.Length - 1
                    intSum = intSum + strDirecion.Split.GetValue(intRows).ToString.Length
                    If intSum < 50 Then
                        strDirec01 = strDirec01 & " " & strDirecion.Split.GetValue(intRows).ToString & " "
                    Else
                        strDirec02 = strDirec02 & " " & strDirecion.Split.GetValue(intRows).ToString & " "
                    End If
                Next
                args.Graphics.DrawString(strDirec01, F, Brushes.Black, PosLeftCab, PosY)
                args.Graphics.DrawString(strDirec02, F, Brushes.Black, PosLeftCab, PosY + 10)
                '-----------------
                PosY += EspaciadoY + 12
                args.Graphics.DrawString(drGuias(0).Item("NRUCPL").ToString.Trim, F, Brushes.Black, PosLeftCab, PosY)

                PosY += EspaciadoY
                args.Graphics.DrawString(drGuias(0).Item("TDRCPL").ToString.Trim, F, Brushes.Black, PosLeftCab + 20, PosY)

                PosY += EspaciadoY
                args.Graphics.DrawString(drGuias(0).Item("TDRCPL_ORIGEN").ToString.Trim, F, Brushes.Black, PosLeftCab + 20, PosY)

                Select Case drGuias(0).Item("SMTGRM").ToString.Trim

                    Case "1"
                        PosY += 2 * EspaciadoY - 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 10, PosY)
                    Case "2"
                        PosY += 2 * EspaciadoY - 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + rX + 10, PosY)
                    Case "9"
                        PosY += 2 * EspaciadoY - 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 2 * rX - 5, PosY)
                    Case "5"
                        PosY += 2 * EspaciadoY - 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 3.5 * rX, PosY)
                    Case "7"
                        PosY += 2 * EspaciadoY - 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 4.5 * rX + 15, PosY)

                    Case "3"
                        PosY += 2 * EspaciadoY - 10
                        PosY += EspaciadoY + 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 10, PosY)
                        PosY = PosY - 30
                    Case "4"
                        PosY += 2 * EspaciadoY - 10
                        PosY += EspaciadoY + 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + rX + 10, PosY)
                        PosY = PosY - 30
                    Case "8"
                        PosY += 2 * EspaciadoY - 10
                        PosY += EspaciadoY + 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 2 * rX - 5, PosY)
                        PosY = PosY - 30
                    Case "6"
                        PosY += 2 * EspaciadoY - 10
                        PosY += EspaciadoY + 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 3.5 * rX, PosY)
                        PosY = PosY - 30
                    Case "A"
                        PosY += 2 * EspaciadoY - 10
                        PosY += EspaciadoY + 10
                        args.Graphics.DrawString("X", F, Brushes.Black, PosLeftCabDetalle + 4.5 * rX + 15, PosY)
                        args.Graphics.DrawString(drGuias(0).Item("TOBORM").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 5.5 * rX + 10, PosY)
                        PosY = PosY - 30
                End Select

                PosY += EspaciadoY + 50
                args.Graphics.DrawString(drGuias(0).Item("TCMTRT").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle, PosY)
                args.Graphics.DrawString(drGuias(0).Item("NRUCTR").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 325, PosY)
                args.Graphics.DrawString(drGuias(0).Item("TDRCTR").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 470, PosY)

                PosY += 2 * EspaciadoY + 7
                args.Graphics.DrawString(CType(drGuias(0).Item("FGUIRM"), Date).ToString("dd/MM/yyyy"), F, Brushes.Black, PosLeftCabDetalle, PosY)
                args.Graphics.DrawString(drGuias(0).Item("TNMBCH").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 100, PosY)
                args.Graphics.DrawString(drGuias(0).Item("NRGMT1").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 320, PosY)
                args.Graphics.DrawString(drGuias(0).Item("NBRVCH").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 470, PosY)
                args.Graphics.DrawString(drGuias(0).Item("TMRCTR").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 570, PosY)

                PosY += EspaciadoY - 10
                args.Graphics.DrawString(drGuias(0).Item("CONFUN").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 570, PosY)
                args.Graphics.DrawString(drGuias(0).Item("NPLCCM").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 670, PosY)
                args.Graphics.DrawString(drGuias(0).Item("NPLACP").ToString.Trim, F, Brushes.Black, PosLeftCabDetalle + 745, PosY)


                PosY += EspaciadoY + 27
                For Each dr As DataRow In drGuias
                    DetDescripcion = dr("TDITES").ToString.Trim.Split("%")
                    args.Graphics.DrawString(dr("FOC").ToString.Trim, F, Brushes.Black, PosLeftCuerpo, PosY)
                    args.Graphics.DrawString(dr("CREFFW").ToString.Trim, F, Brushes.Black, PosLeftCuerpo, PosY + EspaciadoY)

                    'If dr("TCITCL").ToString.Trim.Split(" ").Length > 1 Then
                    '    args.Graphics.DrawString(dr("TCITCL").ToString.Trim.Split(" ").GetValue(0), F, Brushes.Black, PosLeftCuerpo + 85, PosY)
                    '    args.Graphics.DrawString(dr("TCITCL").ToString.Trim.Split(" ").GetValue(1), F, Brushes.Black, PosLeftCuerpo + 85, PosY + 10)
                    'Else
                    args.Graphics.DrawString(dr("TCITCL").ToString.Trim, F, Brushes.Black, PosLeftCuerpo + 85, PosY)
                    'End If
                    iPosDes = 0
                    Dim impMat As String = "N"
                    For Each Item As String In DetDescripcion
                        Select Case iPosDes
                            Case 0, 1
                                args.Graphics.DrawString(Item, F, Brushes.Black, PosLeftCuerpo + 200, PosY)
                            Case 2
                                args.Graphics.DrawString(Item, F, Brushes.Black, PosLeftCuerpo + 140, PosY)
                            Case Else
                                args.Graphics.DrawString(Item, F, Brushes.Black, PosLeftCuerpo + 220, PosY)
                        End Select
                        PosY += EspaciadoY - 5
                        iPosDes += 1

                        If dr("CNDMATPEL").ToString.Trim() <> String.Empty And impMat = "N" Then
                            args.Graphics.DrawString(dr("CNDMATPEL").ToString.Trim(), F, Brushes.Black, PosLeftCuerpo + 200, PosY)
                            PosY += EspaciadoY - 5
                            impMat = "S"
                        End If

                    Next
                   
                    args.Graphics.DrawString(Math.Round(dr("QBLRCO"), 2), F, Brushes.Black, PosLeftCuerpo + 620, PosY - (EspaciadoY - 5) * DetDescripcion.Length)
                    args.Graphics.DrawString(dr("TUNDIT").ToString.Trim, F, Brushes.Black, PosLeftCuerpo + 660, PosY - (EspaciadoY - 5) * DetDescripcion.Length)
                    args.Graphics.DrawString(Math.Round(dr("QPEPQT"), 2), F, Brushes.Black, PosLeftCuerpo + 750, PosY - (EspaciadoY - 5) * DetDescripcion.Length)

                    PosY += EspaciadoY - 14
                Next


                PosY = 1055
                args.Graphics.DrawString(drGuias(0).Item("TOBSRM").ToString.Trim, F, Brushes.Black, PosLeftPie, PosY)
                PosY += EspaciadoY
                args.Graphics.DrawString("EL PESO TOTAL DE LA MERCADERÍA TRANSPORTADA ES:", F, Brushes.Black, PosLeftPie, PosY)
                args.Graphics.DrawString(Math.Round(drGuias(0).Item("TPSOBL"), 2), F, Brushes.Black, PosLeftPie + 480, PosY)
                args.Graphics.DrawString("Kgs.", F, Brushes.Black, PosLeftPie + 525, PosY)

                PosY += EspaciadoY

                args.Graphics.DrawString("LA CANTIDAD TOTAL DE LA MERCADERÍA TRANSPORTADA ES:", F, Brushes.Black, PosLeftPie, PosY)
                args.Graphics.DrawString(Math.Round(drGuias(0).Item("TREFFW"), 2), F, Brushes.Black, PosLeftPie + 480, PosY)
                args.Graphics.DrawString("Blts.".ToString.Trim, F, Brushes.Black, PosLeftPie + 525, PosY)

            End If

            ListaGuia.RemoveAt(i)
            i += 1
        End While

        i = 0
        If (ListaGuia.Count > 0) Then
            args.HasMorePages = True
        Else
            args.HasMorePages = False
        End If

    End Sub


#End Region
  
    Private Function UnificarGuia() As DataTable
        Dim odt As New DataTable
        Dim GuiaBulto As String = ""
        Dim ValorUnico As String = ""
        Dim GuiaValorUnico As String = ""
        Dim GuiaUnico As String = ""
        Dim odtResumenGuia As New DataTable
        odt = ListaInformacionGuia()
        odtResumenGuia = odt.Copy
        odtResumenGuia.Rows.Clear()
        odtResumenGuia.Columns.Add("FGUIAUNICO") 'formato guia unico
        odtResumenGuia.Columns.Add("FOC") 'formato orden compra
        Dim numFilas As Int32 = odt.Rows.Count - 1
        Dim numGuiaInicial As String = "-1"
        Dim GuiaCrea As Boolean = False
        Dim Fila As Int32 = 0
        Dim PSNGUIRM As String = ""
        Dim PSCREFFW As String = ""
        Dim PSNORCML As String = ""
        Dim PSNRITOC As String = ""

        If (numFilas >= 0) Then
            While Fila <= numFilas
                PSNGUIRM = odt.Rows(Fila)("NGUIRM").ToString.Trim
                PSCREFFW = odt.Rows(Fila)("CREFFW").ToString.Trim
                PSNORCML = odt.Rows(Fila)("NORCML").ToString.Trim
                PSNRITOC = odt.Rows(Fila)("NRITOC").ToString.Trim
                GuiaUnico = PSNGUIRM & PSCREFFW & PSNORCML & PSNRITOC
                If (GuiaValorUnico <> GuiaUnico) Then
                    GuiaValorUnico = GuiaUnico
                    odtResumenGuia.ImportRow(odt.Rows(Fila))
                    odtResumenGuia.Rows(odtResumenGuia.Rows.Count - 1)("TDITES") = odtResumenGuia.Rows(odtResumenGuia.Rows.Count - 1)("TDITES").ToString.Trim
                    odtResumenGuia.Rows(odtResumenGuia.Rows.Count - 1)("FGUIAUNICO") = FormatoGuiaNroUnico(PSNGUIRM)
                    odtResumenGuia.Rows(odtResumenGuia.Rows.Count - 1)("FOC") = FormatoOC(PSNORCML, PSNRITOC)
                    If (Not ListaGuia.Contains(PSNGUIRM)) Then
                        ListaGuia.Add(PSNGUIRM)
                    End If
                Else
                    odtResumenGuia.Rows(odtResumenGuia.Rows.Count - 1)("TDITES") += "%" & odt.Rows(Fila)("TDITES").ToString.Trim
                End If
                Fila += 1
            End While
        End If
        Return odtResumenGuia.Copy
    End Function

    Private Function FormatoGuiaNroUnico(ByVal PSNGUIRM As String) As String
        Dim rPSNGUIRM As String = ""
        rPSNGUIRM = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right("0000000000" & Microsoft.VisualBasic.Replace(PSNGUIRM, ",", ""), 10), 3) & "-" & Microsoft.VisualBasic.Right("0000000000" & Microsoft.VisualBasic.Replace(PSNGUIRM, ",", ""), 7)
        Return rPSNGUIRM
    End Function
    Private Function FormatoOC(ByVal PSNORCML As String, ByVal PNRITOC As Decimal) As String
        Dim rFormato As String = ""
        rFormato = PSNORCML & "/" & PNRITOC.ToString("000")
        Return rFormato
    End Function

    Private Function ListaInformacionGuia() As DataTable
        Dim oDsPadre As New DataSet
        Dim oDs As New DataSet
        Dim oDt As New DataTable
        Dim oDrp As DataRow
        Dim intPrimero As Integer = 0
        Dim obeGuiaRemision As RANSA.TYPEDEF.beGuiaRemision = New RANSA.TYPEDEF.beGuiaRemision
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Dim obrGuiaRemision As New RANSA.NEGO.DespachoSAT.brGuiasRemision

        dgGuiasRemision.EndEdit()
        For Each row As DataGridViewRow In dgGuiasRemision.Rows
            If row.Cells("CHK").Value Then
                obeGuiaRemision = New Ransa.TypeDef.beGuiaRemision

                With obeGuiaRemision
                    .PNCCLNT = _obeGuiaRemision.PNCCLNT
                    .PNCCLNGR = _obeGuiaRemision.PNCCLNT
                    .PSCCMPN = _obeGuiaRemision.PSCCMPN
                    .PSCDVSN = _obeGuiaRemision.PSCDVSN
                    .PNCPLNDV = _obeGuiaRemision.PNCPLNDV
                    .PNNRGUSA = row.DataBoundItem.PNNRGUSA
                    .PSNGUIRM = row.DataBoundItem.PSNGUIRM
                    .strAplicacion = Application.StartupPath
                 
                End With
                oDs = obrGuiaRemision.fdstDataGuiaRemision(obeGuiaRemision)
                If oDt.Rows.Count = 0 Then
                    oDt = oDs.Tables(0).Clone
                End If

                For Each oDr As DataRow In oDs.Tables(0).Rows
                    oDrp = oDt.NewRow
                    For intColums As Integer = 0 To oDs.Tables(0).Columns.Count - 1
                        oDrp.Item(intColums) = oDr.Item(intColums)
                    Next
                    oDt.Rows.Add(oDrp)
                Next

            End If
        Next
        PSMODELO = obeGuiaRemision.PSMODELO
        Return oDt
    End Function


End Class
