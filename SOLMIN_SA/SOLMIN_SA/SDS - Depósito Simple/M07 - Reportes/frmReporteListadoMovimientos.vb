Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario

Public Class frmReporteListadoMovimientos

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New MovimientoProductosR02
    Private DtReporte As New DataTable
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

    Private Sub pReporteMovimientoProductoR02()

        rptTemp = New MovimientoProductosR02
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
            .pSTQRY_StatusValorizado = 1
        End With


        DtReporte = oReporteSDS.frptMovimientoProductosR02(Filtro, strMensaje)

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "MovimientoProductosR02"
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
        pReporteMovimientoProductoR02()
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
            Call mpEnviarEMail(objTemp, "Listado de Movimientos", "Informe :  Listado de Movimientos")
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

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Try

            Dim dsTemp As New DataSet

            DtReporte.Columns(0).ColumnName = "CÓDIGO  \n MERCADERIA"
            DtReporte.Columns(1).ColumnName = "DETALLE \n MERCADERIA"
            DtReporte.Columns(2).ColumnName = "CÓDIGO \n RANSA"
            DtReporte.Columns(3).ColumnName = "ORDEN \n SERVICIO"
            DtReporte.Columns(4).ColumnName = "NRO. \n SOLICITUD"
            DtReporte.Columns(5).ColumnName = "TIPO \n MOVIMIENTO"
            DtReporte.Columns(6).ColumnName = " TIPO\n ALMACÉN"
            DtReporte.Columns(7).ColumnName = " \n ALMACÉN"
            DtReporte.Columns(8).ColumnName = "GUIA\n RANSA"
            DtReporte.Columns(9).ColumnName = "\n FECHA"
            DtReporte.Columns(10).ColumnName = "MOVIMIENTO \n CANTIDAD"
            DtReporte.Columns(11).ColumnName = "MOVIMIENTO \n UNIDAD"
            DtReporte.Columns(12).ColumnName = "MOVIMIENTO \n PESO"
            DtReporte.Columns(13).ColumnName = "MOVIMIENTO \nUNIDAD "
            DtReporte.Columns(14).ColumnName = "GUIA \n CLIENTE"
            DtReporte.Columns(15).ColumnName = "\nOBSERVACIÓN"

            DtReporte.TableName = "LISTADO-MOVIMIENTO"

            dsTemp.Tables.Add(DtReporte.Copy)

            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
            strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            HelpClass.ExportExcelConTitulos(dsTemp, Me.Text, strlTitulo)

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
                'tsbExportarPDF.Enabled = False
                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
