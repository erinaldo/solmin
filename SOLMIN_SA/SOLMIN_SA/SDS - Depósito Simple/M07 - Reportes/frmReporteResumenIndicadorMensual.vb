Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario
Public Class frmReporteResumenIndicadorMensual

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New rptIndicadorMensual
    Private oTemp As New DataSet
    Private Mes As String = 0
    Private strMes As String = ""
    Private cboMesLleno As Boolean = False
#End Region

#Region "Procedimientos y funciones"
    Private Sub LlenarFiltrosReporteIndicador()
        ndAnio.Minimum = 0
        ndAnio.Maximum = HelpClass.TodayAnio
        ndAnio.Value = HelpClass.TodayAnio
        MostrarMeses_x_Anio()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Mes = dbMes.SelectedValue
        strMes = dbMes.Text
    End Sub

    Private Sub MostrarMeses_x_Anio()
        Dim odtMeses As New DataTable
        odtMeses.Rows.Clear()
        odtMeses = HelpClass.Meses(ndAnio.Value)
        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "key"
        dbMes.DisplayMember = "value"
        dbMes.SelectedIndex = 0
        cboMesLleno = True
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try

            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub dbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbMes.SelectedIndexChanged
        If (cboMesLleno = True) Then
            Mes = dbMes.SelectedValue
            strMes = dbMes.Text
        End If

    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        ' Validamos los valores de la Guía de Salida
        If txtCliente.pCodigo = 0 Then

            tsbEnviarCorreo.Enabled = False
            tsbExportarExcel.Enabled = False
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pReporteResumenMensualIndicador()

        rptTemp = New rptIndicadorMensual
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS
        Dim AbrevMes As String = String.Empty
        Dim MaxDiaMes As Int32 = 0
        Dim columna As String = ""
        Dim nomTxtObject As String = ""


        ' Filtros
        Dim oIndicador As New beMercaderia

        oIndicador.PNANIOEMI = ndAnio.Value
        oIndicador.PNMESEMI = Mes
        oIndicador.PSMES = strMes
        oIndicador.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        oIndicador.PSCDVSN = UcDivision_Cmb011.Division
        oIndicador.PNCCLNT = txtCliente.pCodigo
        oIndicador.PSTCMPL = txtCliente.pRazonSocial
        oIndicador.PSCULUSA = objSeguridadBN.pUsuario


        oTemp = oReporteSDS.frptListar_Resumen_Indicador_Mensual(oIndicador, strMensaje, MaxDiaMes, AbrevMes)

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        rptTemp.SetDataSource(oTemp.Tables(0).Copy)


        rptTemp.Subreports.Item("rptGraficoMensual").SetDataSource(oTemp.Tables(1).Copy)

        rptTemp.Subreports.Item("rptGraficoERISKU").SetDataSource(oTemp.Tables(2))
        rptTemp.Subreports.Item("rptGraficoERISKU_x100").SetDataSource(oTemp.Tables(3))
        rptTemp.Subreports.Item("rptGraficoERIUBICACION").SetDataSource(oTemp.Tables(4))
        rptTemp.Subreports.Item("rptGraficoERIUBICACION_x100").SetDataSource(oTemp.Tables(5))
        rptTemp.Subreports.Item("rptGraficoOCUPACION").SetDataSource(oTemp.Tables(6))
        rptTemp.Subreports.Item("rptGraficoOCUPACION_x100").SetDataSource(oTemp.Tables(7))

        CType(rptTemp.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario
        CType(rptTemp.ReportDefinition.ReportObjects("txtAnio"), TextObject).Text = oIndicador.PNANIOEMI
        CType(rptTemp.ReportDefinition.ReportObjects("txtMes"), TextObject).Text = oIndicador.PSMES
        CType(rptTemp.ReportDefinition.ReportObjects("txtCliente"), TextObject).Text = oIndicador.PNCCLNT & "-" & oIndicador.PSTCMPL

        For index As Integer = 1 To 31

            columna = HelpClass.StringRight(FormatoNombreColumna(index), 2)
            nomTxtObject = "txtDia"
            nomTxtObject = nomTxtObject & columna
            If (index > MaxDiaMes) Then
                CType(rptTemp.ReportDefinition.ReportObjects(nomTxtObject), TextObject).Text = ""
            Else
                CType(rptTemp.ReportDefinition.ReportObjects(nomTxtObject), TextObject).Text = AbrevMes & "-" & columna
            End If
        Next
        If (MaxDiaMes = 28) Then
            CType(rptTemp.ReportDefinition.ReportObjects("Line37"), LineObject).LineColor = Color.White
            CType(rptTemp.ReportDefinition.ReportObjects("Line38"), LineObject).LineColor = Color.White
        End If
        If (MaxDiaMes = 29) Then
            CType(rptTemp.ReportDefinition.ReportObjects("Line38"), LineObject).LineColor = Color.White
        End If

        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = rptTemp

    End Sub

    Private Function FormatoNombreColumna(ByVal numeroDia As Int32) As String
        Dim retorno As String = "DIA"
        Dim strDia As String = ""
        strDia = numeroDia.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function
#End Region

#Region "Eventos de Control"

    Private Sub frmReporteResumenIndicadorMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        LlenarFiltrosReporteIndicador()

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteResumenMensualIndicador()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbGenerarReporte.Enabled = True

            tsbEnviarCorreo.Enabled = True

            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Try
            Call mpEnviarEMail(objTemp, "Resumen Indicador Mensual", "Informe : Resumen Indicador Mensual")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dlgSavePDF As SaveFileDialog = New SaveFileDialog
            dlgSavePDF.Filter = "Adobe Acrobat PDF (*.pdf)|*.pdf"
            dlgSavePDF.CheckPathExists = True
            If dlgSavePDF.ShowDialog = Windows.Forms.DialogResult.OK Then
                objTemp.pReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dlgSavePDF.FileName)
            End If
            dlgSavePDF.Dispose()
            dlgSavePDF = Nothing
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

    '    Try
    '        Dim dtTemp As DataSet = oTemp.Copy

    '        Dim a As Integer = 0

    '        dtTemp.Tables(0).Columns("NORCML").ColumnName = "N° O/C"
    '        dtTemp.Tables(0).Columns("FCHCRT").ColumnName = "FECHA O/C"
    '        dtTemp.Tables(0).Columns("TCTCST").ColumnName = "CENTRO COSTO"
    '        dtTemp.Tables(0).Columns("TPRVCL").ColumnName = "PROVEEDOR"
    '        dtTemp.Tables(0).Columns("NRITOC").ColumnName = "ITEM"
    '        dtTemp.Tables(0).Columns("TMRCD2").ColumnName = "MERCADERIA"
    '        dtTemp.Tables(0).Columns("FRLZSR").ColumnName = "FECHA INGRESO"
    '        dtTemp.Tables(0).Columns("QTRMC").ColumnName = "CANTIDAD"
    '        dtTemp.Tables(0).Columns("CUNCN6").ColumnName = "UNIDAD"
    '        dtTemp.Tables(0).Columns("TLUGEN").ColumnName = "LUGAR ENTREGA"

    '        dtTemp.Tables(0).Columns.Remove("CCLNT")
    '        dtTemp.Tables(0).Columns.Remove("TCMPCL")
    '        dtTemp.Tables(0).Columns.Remove("TDITES")
    '        dtTemp.Tables(0).Columns.Remove("CMRCLR")
    '        dtTemp.Tables(0).Columns.Remove("NORDSR")
    '        dtTemp.Tables(0).Columns.Remove("NORCCL")
    '        dtTemp.Tables(0).Columns.Remove("TRFRN1")

    '        dtTemp.Tables(0).TableName = "MOVIMIENTO-POR-BU"


    '        Dim strlTitulo As New List(Of String)
    '        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
    '        strlTitulo.Add("Compañia :\n" & IIf(Me.UcCompania_Cmb011.CCMPN_CodigoCompania = "", "TODOS", Me.UcCompania_Cmb011.CCMPN_CodigoCompania & " - " & Me.UcCompania_Cmb011.CCMPN_Descripcion))
    '        strlTitulo.Add("División :\n" & IIf(Me.UcDivision_Cmb011.Division = "", "TODOS", Me.UcDivision_Cmb011.Division & " - " & Me.UcDivision_Cmb011.DivisionDescripcion))
    '        strlTitulo.Add("Año :\n" & ndAnio.Value)
    '        strlTitulo.Add("Mes :\n" & dbMes.SelectedText)
    '        strlTitulo.Add("Fecha:\n" & Now.Date)
    '        HelpClass.ExportExcelConTitulos(dtTemp, Me.Text, strlTitulo)

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try

    'End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region




    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True

                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
