Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario
Public Class frmReporteStockProductoPorAlmacenValorizado

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New StockProductosPorAlmacenR02
    Private DtReporte As New DataTable
#End Region

#Region "Procedimientos y funciones"
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

    Private Sub pReporteStockProductoPorUbicacionR02()
        Dim Filtro As TD_Qry_StockProductosPorUbicacionF01 = New TD_Qry_StockProductosPorUbicacionF01
        rptTemp = New StockProductosPorAlmacenR02
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        ' Filtros

        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
            .pCTPDP6_TipoDeposito = "1"
            .pCTPALM_TipoAlmacen = "" & txtTipoAlmacen.Tag
            .pCALMC_Almacen = "" & txtAlmacen.Tag
            .pCZNALM_ZonaAlmacen = "" & txtZonaAlmacen.Tag
            .pSTQRY_StatusValorizado = 1
        End With


        DtReporte = oReporteSDS.frptStockProductosPorUbicacionR02(Filtro, strMensaje)
        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "StockProductosPorAlmacenR02"
            rptTemp.SetDataSource(DtReporte)


            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
            rptTemp.SetParameterValue("pRazonSocial", Filtro.pTCMPCL_RazonSocial)
            rptTemp.SetParameterValue("pFecha", Now)

            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = rptTemp
        End If
    End Sub
#End Region

#Region "Eventos de Control"

    Private Sub frmReporteMovimientosProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True
                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                btnGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteStockProductoPorUbicacionR02()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            btnGenerarReporte.Enabled = True
            tsbEnviarCorreo.Enabled = True
            tsbExportarExcel.Enabled = True
            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        DtReporte.Columns(0).ColumnName = "TIPO ALMACÉN \n COD"
        DtReporte.Columns(1).ColumnName = "TIPO ALMACÉN \n DETALLE"
        DtReporte.Columns(2).ColumnName = "ALMACÉN \n COD"
        DtReporte.Columns(3).ColumnName = "ALMACÉN \n DETALLE"
        DtReporte.Columns(4).ColumnName = "ZONA ALMACEN \n COD"
        DtReporte.Columns(5).ColumnName = "ZONA ALMACEN \n DETALLE"
        DtReporte.Columns(6).ColumnName = "CÓDIGO \n MERCADERIA"
        DtReporte.Columns(7).ColumnName = "ORDEN \n SERVICIO"
        DtReporte.Columns(8).ColumnName = "CÓDIGO \n RANSA"
        DtReporte.Columns(9).ColumnName = "DETALLE \n MERCADERIA"
        DtReporte.Columns(10).ColumnName = " \n STOCK"
        DtReporte.Columns(11).ColumnName = " \n UNIDAD"
        DtReporte.Columns(12).ColumnName = " \n VALOR"

        Dim oList As New List(Of DataTable)
        oList.Add(DtReporte)
        Dim strTitulo As String = "INVENTARIO DE PRODUCTOS POR ALMACÉN"
        '==========================Exportamos==========================
        HelpClass.ExportExcel(oList, strTitulo.ToUpper)
        '==============================================================
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Try
            Call mpEnviarEMail(objTemp, "Stock de Productos por Almacén Valorizado", "Informe :  Stock de Productos por Almacén Valorizado")
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

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Try
            Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Try
            Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Try
            Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                Case Keys.Delete
                    txtTipoAlmacen.Text = ""
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        Try
            If txtTipoAlmacen.Text = "" Then
                txtTipoAlmacen.Tag = ""
            Else
                If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                    Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                    If txtTipoAlmacen.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                Case Keys.Delete
                    txtAlmacen.Text = ""
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        ' Si modificamos el Almacén - debe limpiarse la Zona
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        Try
            If txtAlmacen.Text = "" Then
                txtAlmacen.Tag = ""
            Else
                If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                    Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                    If txtAlmacen.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                Case Keys.Delete
                    txtZonaAlmacen.Text = ""
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        Try
            If txtZonaAlmacen.Text = "" Then
                txtZonaAlmacen.Tag = ""
            Else
                If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                    Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                    If txtZonaAlmacen.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

End Class
