Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario

Public Class frmReporteMovimientoProductosPorAlmacen
#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New MovProductosPorUbicacionR01
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

    Private Sub pReporteMovimientoProductoPorUbicacionR01()

        rptTemp = New MovProductosPorUbicacionR01
        Dim strMensaje As String = String.Empty
        Dim oReporteSDS As New ReporteSDS

        Dim Filtro As TD_FiltroRepMovProductosPorUbicacion = New TD_FiltroRepMovProductosPorUbicacion
        ' Filtros
        With Filtro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaInventarioDte = dteFechaInicial.Value
            .pFMOVF_FechaInventarioDte = dteFechaFinal.Value
            .pTCMPCL_RazonSocial = txtCliente.pRazonSocial
            .pSTPODP_TipoDeposito = "1"
            .pCTPALM_TipoAlmacen = "" & txtTipoAlmacen.Tag
            .pCALMC_Almacen = "" & txtAlmacen.Tag
            .pCZNALM_ZonaAlmacen = "" & txtZonaAlmacen.Tag
            .pSTQRY_StatusValorizado = 0
        End With


        DtReporte = oReporteSDS.frptMovimientoProductosPorUbicacionR01(Filtro, strMensaje)
        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "MovProductosPorUbicacionR01"
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

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True
                'tsbExportarPDF.Enabled = False
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
        pReporteMovimientoProductoPorUbicacionR01()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            btnGenerarReporte.Enabled = True
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
            Call mpEnviarEMail(objTemp, "Movimiento de Productos por Almacen", "Informe :  Movimiento de Productos por Almacen")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            DtReporte.Columns(0).ColumnName = "TIPO ALMACÉN \n COD"
            DtReporte.Columns(1).ColumnName = "TIPO ALMACÉN \n DETALLE"
            DtReporte.Columns(2).ColumnName = "ALMACÉN \n COD"
            DtReporte.Columns(3).ColumnName = "ALMACÉN \n DETALLE"
            DtReporte.Columns(4).ColumnName = "ZONA ALMACÉN \n COD"
            DtReporte.Columns(5).ColumnName = "ZONA ALMACÉN \n DETALLE"
            DtReporte.Columns(6).ColumnName = " \n MOVIMIENTO"
            DtReporte.Columns(7).ColumnName = " \n FECHA"
            DtReporte.Columns(8).ColumnName = " CÓDIGO\n MERCADERIA"
            DtReporte.Columns(9).ColumnName = "CÓDIGO \n RANSA"
            DtReporte.Columns(10).ColumnName = "DETALLE \n MERCADERIA"
            DtReporte.Columns(11).ColumnName = "ORDEN \n SERVICIO"
            DtReporte.Columns(12).ColumnName = "NRO. \nSOLICITUD"
            DtReporte.Columns(13).ColumnName = "MOVIMIENTO \n CANTIDAD"
            DtReporte.Columns(14).ColumnName = "MOVIMIENTO \n UNIDAD"
            DtReporte.Columns(15).ColumnName = "MOVIMIENTO \n PESO"
            DtReporte.Columns(16).ColumnName = "MOVIMIENTO \nUNIDAD "
            DtReporte.Columns(17).ColumnName = " GUIA \n RANSA"
            DtReporte.Columns(18).ColumnName = "GUIA \n CLIENTE"


            Dim oDs As New DataSet
            oDs.Tables.Add(DtReporte.Copy)

            Dim strTitulo As New List(Of String)
            strTitulo.Add("Cliente : \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
            strTitulo.Add("Tipo Almacén : \n" & Me.txtTipoAlmacen.Text)
            strTitulo.Add("Almacén : \n" & Me.txtAlmacen.Text)
            strTitulo.Add("Zona Almacén : \n" & Me.txtZonaAlmacen.Text)
            strTitulo.Add("Fecha : \n" & Me.dteFechaInicial.Value.ToShortDateString & " - " & Me.dteFechaFinal.Value.ToShortDateString)


            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
        Catch : End Try
    End Sub

 

    Private Sub frmReporteMovimientoProductosPorAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
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
