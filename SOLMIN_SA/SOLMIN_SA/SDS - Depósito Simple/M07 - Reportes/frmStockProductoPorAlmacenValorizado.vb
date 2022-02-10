Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario

Public Class frmReporteMovimientoValorizadoPorFecha

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New ucMovMercaderias_F03
    Private DtReporte As New DataTable
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0 Then
            tsbExportarPDF.Enabled = False
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

    Private Sub pReporteMovimientoProductoR05()

        rptTemp = New ucMovMercaderias_F03
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
            .pSTPODP_TipoDeposito = "1"

        End With


        DtReporte = oReporteSDS.frptMovimientoProductosValorizadoR03(Filtro, strMensaje)

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        rptTemp.SetDataSource(DtReporte)

        rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)

        rptTemp.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
        rptTemp.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)


        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = rptTemp

    End Sub
#End Region

#Region "Eventos de Control"
    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True
                tsbExportarPDF.Enabled = False
                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                btnGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteListadoMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteMovimientoProductoR05()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            btnGenerarReporte.Enabled = True
            tsbExportarPDF.Enabled = True
            tsbEnviarCorreo.Enabled = True
            tsbExportarExcel.Enabled = True
            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Try
            Call mpEnviarEMail(objTemp, "Listado de Movimientos Valorizado por Fecha", "Informe :  Listado de Movimientos Valorizado por Fecha")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarPDF.Click
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

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Dim dtTemp = DtReporte.Copy

        dtTemp.Columns(0).ColumnName = " \n CLIENTE"
        dtTemp.Columns(1).ColumnName = "\n RAZON SOCIAL"
        dtTemp.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
        dtTemp.Columns(3).ColumnName = "ORDEN \n SERVICIO"
        dtTemp.Columns(4).ColumnName = "CODIGO \n RANSA"
        dtTemp.Columns(5).ColumnName = "DETALLE \n MERCADERIA"
        dtTemp.Columns(6).ColumnName = "\n UNIDAD"
        dtTemp.Columns(7).ColumnName = "SALDO\n INICIAL"
        dtTemp.Columns(8).ColumnName = "VALOR \n INICIAL"
        dtTemp.Columns(9).ColumnName = "CANTIDAD \n INGRESO"
        dtTemp.Columns(10).ColumnName = "VALOR \n INGRESO"
        dtTemp.Columns(11).ColumnName = "CANTIDAD \n SALIDA"
        dtTemp.Columns(12).ColumnName = "VALOR\n SALIDA"
        dtTemp.Columns(13).ColumnName = "STOCK \n FINAL"
        dtTemp.Columns(14).ColumnName = "VALOR\n FINAL"
        Dim oList As New List(Of DataTable)
        oList.Add(dtTemp)
        Dim strTitulo As String = "LISTADO DE MOVIMIENTOS DE PRODUCTOS"
        '==========================Exportamos==========================
        HelpClass.ExportExcel(oList, strTitulo)
        '==============================================================
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

End Class
