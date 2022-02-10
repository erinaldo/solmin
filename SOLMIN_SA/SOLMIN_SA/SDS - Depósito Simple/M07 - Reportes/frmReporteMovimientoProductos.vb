Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario
Public Class frmReporteMovimientoProductos

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New MovimientoProductosR01
    Private rptTempI = New MovimientoProductosR01
    Private rptTempS = New MovimientoProductosR01

    Private DtReporteExcel As New DataTable
    Private DtReporteIngreso As New DataTable
    Private DtReporteSalida As New DataTable


    Private oPrintMovProdForm As New frmPrintMovimientoProductos
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0 Then
            tsbExportarExcel.Enabled = False
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pReporteMovimientoProductoR01()
        Dim DtReporte As New DataTable
        rptTemp = New MovimientoProductosR01
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS


        Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
            .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
            .pSCMRCLR_CodigoMercaderia = txtCodMercaderia.Text.Trim.ToUpper()
            .pSTMRCD2_DetalleMercaderia = txtDetMercaderia.Text.Trim.ToUpper()
            .pSTPODP_TipoDeposito = "1"
            .pSTQRY_StatusValorizado = 0
        End With

        DtReporte = oReporteSDS.frptMovimientoProductosR01(Filtro, strMensaje)

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "MovimientoProductosR01"
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

#Region "Eventos de control"
    Private Sub frmReporteMovimientoProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If fblnValidaInformacion() Then

                'pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                'pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                'pcxEspera.Visible = True
                tsbImprimir.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                CargarIngresoSalida()
                'crvReporte.Visible = False
                'bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarIngresoSalida()
        Dim DtReporte As New DataTable
        rptTemp = New MovimientoProductosR01
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
            .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
            .pSCMRCLR_CodigoMercaderia = txtCodMercaderia.Text.Trim.ToUpper()
            .pSTMRCD2_DetalleMercaderia = txtDetMercaderia.Text.Trim.ToUpper()
            .pSTPODP_TipoDeposito = "1"
            .pSTQRY_StatusValorizado = 0
        End With
        DtReporte = oReporteSDS.frptMovimientoProductosR01(Filtro, strMensaje)
        If (DtReporte.Rows.Count > 0) Then

            If DtReporteIngreso.Rows.Count > 0 Then
                DtReporteIngreso.Rows.Clear()
            Else
                DtReporteIngreso.Rows.Clear()
                If (DtReporteIngreso.Columns.Count = 0) Then
                    CargarColumnasIngreso()
                End If

            End If

            If DtReporteSalida.Rows.Count > 0 Then
                DtReporteSalida.Rows.Clear()
            Else
                DtReporteSalida.Rows.Clear()
                If (DtReporteSalida.Columns.Count = 0) Then
                    CargarColumnasSalida()
                End If
            End If

            Dim index As Integer = 0
            For Each row As DataRow In DtReporte.Rows
                If (row.ItemArray(0) = "INGRESO") Then
                    DtReporteIngreso.LoadDataRow(row.ItemArray, True)
                End If
                If (row.ItemArray(0) = "SALIDA") Then
                    DtReporteSalida.LoadDataRow(row.ItemArray, True)
                End If
            Next

            dgIngreso.DataSource = DtReporteIngreso
            dgSalida.DataSource = DtReporteSalida
            HabilitarBotones()
        Else
            HabilitarBotones()
            dgIngreso.Rows.Clear()
            dgSalida.Rows.Clear()
        End If

    End Sub

    Private Sub HabilitarBotones()
        tsbGenerarReporte.Enabled = True
        tssSeparador_003.Visible = False
        tsbImprimir.Enabled = True
        tsbExportarExcel.Enabled = True
    End Sub



    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call mpEnviarEMail(objTemp, "Movimiento de Productos", "Informe :  Movimiento de Productos")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs)
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

    Private Sub CargarColumnasIngreso()
        DtReporteIngreso.Columns.Add("CTPOAT", GetType(String))
        DtReporteIngreso.Columns.Add("FRLZSR", GetType(Date))
        DtReporteIngreso.Columns.Add("CMRCLR", GetType(String))
        DtReporteIngreso.Columns.Add("CMRCD", GetType(String))
        DtReporteIngreso.Columns.Add("TMRCD2", GetType(String))
        DtReporteIngreso.Columns.Add("NORDSR", GetType(String))
        DtReporteIngreso.Columns.Add("NSLCSR", GetType(String))
        DtReporteIngreso.Columns.Add("CTPALM", GetType(String))
        DtReporteIngreso.Columns.Add("CALMC", GetType(String))
        DtReporteIngreso.Columns.Add("QTRMC", GetType(String))
        DtReporteIngreso.Columns.Add("CUNCN5", GetType(String))
        DtReporteIngreso.Columns.Add("QTRMP", GetType(String))
        DtReporteIngreso.Columns.Add("CUNPS5", GetType(String))
        DtReporteIngreso.Columns.Add("NGUIRN", GetType(String))
        DtReporteIngreso.Columns.Add("NGUICL", GetType(String))
        DtReporteIngreso.Columns.Add("TOBSRV", GetType(String))

    End Sub

    Private Sub CargarColumnasSalida()
        DtReporteSalida.Columns.Add("CTPOAT", GetType(String))
        DtReporteSalida.Columns.Add("FRLZSR", GetType(Date))
        DtReporteSalida.Columns.Add("CMRCLR", GetType(String))
        DtReporteSalida.Columns.Add("CMRCD", GetType(String))
        DtReporteSalida.Columns.Add("TMRCD2", GetType(String))
        DtReporteSalida.Columns.Add("NORDSR", GetType(String))
        DtReporteSalida.Columns.Add("NSLCSR", GetType(String))
        DtReporteSalida.Columns.Add("CTPALM", GetType(String))
        DtReporteSalida.Columns.Add("CALMC", GetType(String))
        DtReporteSalida.Columns.Add("QTRMC", GetType(String))
        DtReporteSalida.Columns.Add("CUNCN5", GetType(String))
        DtReporteSalida.Columns.Add("QTRMP", GetType(String))
        DtReporteSalida.Columns.Add("CUNPS5", GetType(String))
        DtReporteSalida.Columns.Add("NGUIRN", GetType(String))
        DtReporteSalida.Columns.Add("NGUICL", GetType(String))
        DtReporteSalida.Columns.Add("TOBSRV", GetType(String))
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        'Dim strMensaje As String = String.Empty
        'Dim oReporteSDS As New ReporteSDS
        'Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
        '' Filtros
        'With Filtro
        '    .pCCLNT_CodigoCliente = txtCliente.pCodigo
        '    .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
        '    .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
        '    .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
        '    .pSCMRCLR_CodigoMercaderia = txtCodMercaderia.Text.Trim.ToUpper()
        '    .pSTMRCD2_DetalleMercaderia = txtDetMercaderia.Text.Trim.ToUpper()
        '    .pSTPODP_TipoDeposito = "1"
        '    .pSTQRY_StatusValorizado = 0
        'End With
        Try
            Dim DtReporteIng As New DataTable
            Dim DtReporteSal As New DataTable
            DtReporteIng = Me.dgIngreso.DataSource.Copy
            DtReporteSal = Me.dgSalida.DataSource.Copy
            'DtReporteExcel = oReporteSDS.frptMovimientoProductosR01(Filtro, strMensaje)

            'DtReporteIng.Columns.Add("CTPOAT", GetType(String))
            'DtReporteIng.Columns.Add("FRLZSR", GetType(Date))
            'DtReporteIng.Columns.Add("CMRCLR", GetType(String))
            'DtReporteIng.Columns.Add("CMRCD", GetType(String))
            'DtReporteIng.Columns.Add("TMRCD2", GetType(String))
            'DtReporteIng.Columns.Add("NORDSR", GetType(String))
            'DtReporteIng.Columns.Add("NSLCSR", GetType(String))
            'DtReporteIng.Columns.Add("CTPALM", GetType(String))
            'DtReporteIng.Columns.Add("CALMC", GetType(String))
            'DtReporteIng.Columns.Add("QTRMC", GetType(String))
            'DtReporteIng.Columns.Add("CUNCN5", GetType(String))
            'DtReporteIng.Columns.Add("QTRMP", GetType(String))
            'DtReporteIng.Columns.Add("CUNPS5", GetType(String))
            'DtReporteIng.Columns.Add("NGUIRN", GetType(String))
            'DtReporteIng.Columns.Add("NGUICL", GetType(String))
            'DtReporteIng.Columns.Add("TOBSRV", GetType(String))

            'DtReporteSal.Columns.Add("CTPOAT", GetType(String))
            'DtReporteSal.Columns.Add("FRLZSR", GetType(Date))
            'DtReporteSal.Columns.Add("CMRCLR", GetType(String))
            'DtReporteSal.Columns.Add("CMRCD", GetType(String))
            'DtReporteSal.Columns.Add("TMRCD2", GetType(String))
            'DtReporteSal.Columns.Add("NORDSR", GetType(String))
            'DtReporteSal.Columns.Add("NSLCSR", GetType(String))
            'DtReporteSal.Columns.Add("CTPALM", GetType(String))
            'DtReporteSal.Columns.Add("CALMC", GetType(String))
            'DtReporteSal.Columns.Add("QTRMC", GetType(String))
            'DtReporteSal.Columns.Add("CUNCN5", GetType(String))
            'DtReporteSal.Columns.Add("QTRMP", GetType(String))
            'DtReporteSal.Columns.Add("CUNPS5", GetType(String))
            'DtReporteSal.Columns.Add("NGUIRN", GetType(String))
            'DtReporteSal.Columns.Add("NGUICL", GetType(String))
            'DtReporteSal.Columns.Add("TOBSRV", GetType(String))

            Dim intLinea As Integer = 0
            DtReporteIng.Columns.RemoveAt(0)
            DtReporteSal.Columns.RemoveAt(0)

            'DtReporteIng.Columns(0).ColumnName = " \n MOVIMIENTO"
            DtReporteIng.Columns(intLinea).ColumnName = "\n FECHA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = " CÓDIGO \n MERCADERIA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "CODIGO \n RANSA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "DETALLE \n MERCADERIA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "ORDEN \n SERVICIO"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "NRO. \n SOLICITUD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "TIPO  ALMACEN"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "ALMACEN"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n CANTIDAD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n UNIDAD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n PESO"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \nUNIDAD "
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "GUIA \n RANSA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "GUIA \n CLIENTE"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = ".\n OBSERVACION"

            intLinea = 0
            DtReporteSal.Columns(intLinea).ColumnName = "\n FECHA"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "CÓDIGO \n MERCADERIA"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "CODIGO \n RANSA"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "DETALLE \n MERCADERIA"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "ORDEN \n SERVICIO"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "NRO. \n SOLICITUD"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "TIPO ALMACEN"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = " ALMACEN"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "MOVIMIENTO \n CANTIDAD"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "MOVIMIENTO \n UNIDAD"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "MOVIMIENTO \n PESO"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "MOVIMIENTO \nUNIDAD "
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "GUIA \n RANSA"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = "GUIA \n CLIENTE"
            intLinea += 1
            DtReporteSal.Columns(intLinea).ColumnName = ". \n  OBSERVACION"
            intLinea += 1

            DtReporteIng.TableName = "Ingreso"
            DtReporteSal.TableName = "Salida"


            Dim strTitulo As New List(Of String)
            strTitulo.Add("Cliente : \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
            strTitulo.Add("Fecha : \n" & Me.dteFechaInicial.Value.ToShortDateString & " - " & Me.dteFechaFinal.Value.ToShortDateString)

            Dim oDs As New DataSet
            oDs.Tables.Add(DtReporteIng)
            oDs.Tables.Add(DtReporteSal)

            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
        Catch ex As Exception
        End Try
        

    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        Try

            If fblnValidaInformacion() Then
                Dim Filtro As TD_FiltroRepMovProductos = New TD_FiltroRepMovProductos
                ' Filtros
                With Filtro
                    .pCCLNT_CodigoCliente = txtCliente.pCodigo
                    .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
                    .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
                    .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
                    .pSCMRCLR_CodigoMercaderia = txtCodMercaderia.Text.Trim.ToUpper()
                    .pSTMRCD2_DetalleMercaderia = txtDetMercaderia.Text.Trim.ToUpper()
                    .pSTPODP_TipoDeposito = "1"
                    .pSTQRY_StatusValorizado = 0
                End With

                If TabDetalle.SelectedIndex = 0 Then
                    If DtReporteIngreso.Rows.Count > 0 Then

                        DtReporteIngreso.TableName = "MovimientoProductosIngresoR01"
                        rptTempI.SetDataSource(DtReporteIngreso)
                        rptTempI.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                        rptTempI.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
                        rptTempI.SetParameterValue("pRazonSocial", Filtro.pTCMPCL_RazonSocial)
                        rptTempI.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
                        rptTempI.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)

                        objTemp = New TipoDato_ResultaReporte
                        objTemp.pReporte = rptTempI
                    End If
                    oPrintMovProdForm.ShowForm(objTemp.pReporte, Me)
                Else
                    If DtReporteSalida.Rows.Count > 0 Then

                        DtReporteSalida.TableName = "MovimientoProductosSalidaR01"
                        rptTempS.SetDataSource(DtReporteSalida)
                        rptTempS.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                        rptTempS.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
                        rptTempS.SetParameterValue("pRazonSocial", Filtro.pTCMPCL_RazonSocial)
                        rptTempS.SetParameterValue("pFechaInicial", Filtro.pFMOVI_FechaInventarioDte)
                        rptTempS.SetParameterValue("pFechaFinal", Filtro.pFMOVF_FechaInventarioDte)

                        objTemp = New TipoDato_ResultaReporte
                        objTemp.pReporte = rptTempS
                    End If
                    oPrintMovProdForm.ShowForm(objTemp.pReporte, Me)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then
                tsbImprimir.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                CargarIngresoSalida()
            End If
        Catch : End Try


    End Sub
End Class
