Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports Ransa.Rpt.Mercaderia
Imports RANSA.Utilitario

Public Class frmReporteMovimientoPorBU

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New rptMovimientoxCeCo
    Private dsReportes As New DataSet
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0 Then
            'tsbExportarPDF.Enabled = False
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

    Private Sub pReporteMovimientoxCentroCosto()

        rptTemp = New rptMovimientoxCeCo
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value

        End With


        dsReportes = oReporteSDS.frptListar_MovMercaderias_x_CentroCosto(Filtro, strMensaje)
        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        rptTemp.SetDataSource(dsReportes.Tables(0).Copy)
        rptTemp.Subreports.Item("rptResumenxCentroCosto").SetDataSource(dsReportes.Tables(1).Copy)
        rptTemp.Subreports.Item("rptResumenxLugarEntrega").SetDataSource(dsReportes.Tables(2).Copy)
        rptTemp.Subreports.Item("rptResumenxBu2").SetDataSource(dsReportes.Tables(3).Copy)


        rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
        rptTemp.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
        rptTemp.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)

        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = rptTemp

    End Sub
#End Region

#Region "Enventos de Control"
    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteMovimientoxCentroCosto()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbGenerarReporte.Enabled = True
            'tsbExportarPDF.Enabled = True
            tsbEnviarCorreo.Enabled = True
            tsbExportarExcel.Enabled = True
            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Try
            Call mpEnviarEMail(objTemp, "Movimientos por BU - Centro de Costo", "Informe :  Movimientos por BU - Centro de Costo")
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

    Private Sub frmReporteMovimientoPorBU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

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
                'tsbExportarPDF.Enabled = False
                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Try

            Dim dtTemp As DataSet = dsReportes.Copy

            dtTemp.Tables(0).Columns("NORCML").ColumnName = "N° O/C"
            dtTemp.Tables(0).Columns("FCHCRT").ColumnName = "FECHA O/C"
            dtTemp.Tables(0).Columns("TCTCST").ColumnName = "CENTRO COSTO"
            dtTemp.Tables(0).Columns("TPRVCL").ColumnName = "PROVEEDOR"
            dtTemp.Tables(0).Columns("NRITOC").ColumnName = "ITEM"
            dtTemp.Tables(0).Columns("TMRCD2").ColumnName = "MERCADERIA"
            dtTemp.Tables(0).Columns("FRLZSR").ColumnName = "FECHA INGRESO"
            dtTemp.Tables(0).Columns("QTRMC").ColumnName = "CANTIDAD"
            dtTemp.Tables(0).Columns("CUNCN6").ColumnName = "UNIDAD"
            dtTemp.Tables(0).Columns("TLUGEN").ColumnName = "LUGAR ENTREGA"

            dtTemp.Tables(0).Columns.Remove("CCLNT")
            dtTemp.Tables(0).Columns.Remove("TCMPCL")
            dtTemp.Tables(0).Columns.Remove("TDITES")
            dtTemp.Tables(0).Columns.Remove("CMRCLR")
            dtTemp.Tables(0).Columns.Remove("NORDSR")
            dtTemp.Tables(0).Columns.Remove("NORCCL")
            dtTemp.Tables(0).Columns.Remove("TRFRN1")

            dtTemp.Tables(0).TableName = "MOVIMIENTO-POR-BU"

            dtTemp.Tables(1).Columns("TRFRN1").ColumnName = "BU"
            dtTemp.Tables(1).Columns("QTRMC_CECO").ColumnName = "CANTIDAD"
            dtTemp.Tables(1).Columns.Remove("TCTCST")
            dtTemp.Tables(1).TableName = "RESUMEN-POR-BU"

            dtTemp.Tables(2).Columns("TLUGEN").ColumnName = "CENTRO DE COSTO"
            dtTemp.Tables(2).Columns("QTRMC_LD").ColumnName = "CANTIDAD"
            dtTemp.Tables(2).TableName = "RESUMEN-POR-CENTRO-COSTO"

            dtTemp.Tables(3).Columns("TRFRN1").ColumnName = "LUGAR DE ENTREGA"
            dtTemp.Tables(3).Columns("QTRMC_CECO").ColumnName = "CANTIDAD"
            dtTemp.Tables(3).TableName = "RESUMEN-POR-LUGAR-ENTREGA"

            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
            strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            HelpClass.ExportExcelConTitulos(dtTemp, Me.Text, strlTitulo)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
