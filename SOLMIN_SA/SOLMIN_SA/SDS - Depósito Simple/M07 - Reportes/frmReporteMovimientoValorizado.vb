Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario

Public Class frmReporteMovimientoValorizado

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New MovimientoProductosR03
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

    Private Sub pReporteMovimientoProductoR03()

        rptTemp = New MovimientoProductosR03
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
            .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
            .pSTPODP_TipoDeposito = "1"
            .pSTQRY_StatusValorizado = 2
        End With


        DtReporte = oReporteSDS.frptMovimientoProductosR03(Filtro, strMensaje)

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "MovimientoProductosR03"
            rptTemp.SetDataSource(DtReporte)


            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
            rptTemp.SetParameterValue("pRazonSocial", Filtro.pTCMPCL_RazonSocial)
            rptTemp.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
            rptTemp.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)

            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = rptTemp
        End If
    End Sub
#End Region

#Region "Eventos de Control"

    Private Sub ReporteListadoMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteMovimientoProductoR03()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbGenerarReporte.Enabled = True
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
            Call mpEnviarEMail(objTemp, "Listado de Movimiento Valorizados", "Informe :  Listado de Movimientos Valorizados")
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

        Try

            Dim dtTemp = DtReporte.Copy

            Dim objDs As New DataSet

            dtTemp.Columns(0).ColumnName = "TIPO MOV."
            dtTemp.Columns(1).ColumnName = "FECHA"
            dtTemp.Columns(2).ColumnName = "CÓDIGO MERCADERIA"
            dtTemp.Columns(3).ColumnName = "CODIGO RANSA"
            dtTemp.Columns(4).ColumnName = "DETALLE MERCADERIA"
            dtTemp.Columns(5).ColumnName = "ORDEN SERVICIO"
            dtTemp.Columns(6).ColumnName = "NRO. SOLICITUD"
            dtTemp.Columns(7).ColumnName = "TIPO ALMACEN"
            dtTemp.Columns(8).ColumnName = "ALMACEN"
            dtTemp.Columns(9).ColumnName = "MOVIMIENTO"
            dtTemp.Columns(10).ColumnName = "UNIDAD"
            dtTemp.Columns(11).ColumnName = "VALOR"
            dtTemp.Columns(12).ColumnName = "GUIA RANSA"
            dtTemp.Columns(13).ColumnName = "GUIA CLIENTE"
            dtTemp.Columns(14).ColumnName = "OBSERVACIONES"

            dtTemp.TableName = "MOVIMIENTO-VALORIZADO"
            objDs.Tables.Add(dtTemp)

            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
            strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            HelpClass.ExportExcelConTitulos(objDs, Me.Text, strlTitulo)
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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
                tsbExportarPDF.Enabled = False
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
