Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports Ransa.TypeDef
Imports RANSA.Utilitario
Imports ComponentFactory.Krypton.Toolkit


Public Class frmReporteStockProducto

    Public objCliente As beCliente
    Public Lista As List(Of beCliente)


#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New StockProductosR01
    Private DtReporte As New DataTable
    Private boolChecActivo As Boolean = False
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        ' Validamos los valores de la Guía de Salida

        'If cmbCliente.Properties.GetCheckedItems = "" Then
        '    tsbExportarExcel.Enabled = False
        '    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        'End If

        txtCliente.Refresh()
        If txtCliente.Resultado IsNot Nothing Then

            Dim Estado As String = txtCliente.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        tsbExportarExcel.Enabled = False
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If

            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If
       

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pReporteStockProductoR01()
        Dim Filtro As TD_Qry_StockProductosF01 = New TD_Qry_StockProductosF01
        Dim oFiltro As New Reportes.beFiltrosDespachoPorAlmacen
        rptTemp = New StockProductosR01
        Dim intIsInventarioActual As Integer = 1
        Dim strMensaje As String = String.Empty
        Dim Est As String = txtCliente.Resultado.GetType.ToString

        ' Filtros
        'With Filtro
        '    .psCCLNT_CodigoCliente = cmbCliente.Properties.GetCheckedItems
        '    .pCTPDP6_TipoDeposito = "1"
        'End With

        With oFiltro
            '.PSCCLNT = cmbCliente.Properties.GetCheckedItems
            If Est = "Ransa.Utilitario.beCliente" Then
                'cmbCliente.Properties.GetCheckedItems
                .PSCCLNT = CType(txtCliente.Resultado, beCliente).Codigo 'cmbCliente.Properties.GetCheckedItems
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            ' .PSTCMPCL = txtCliente.pRazonSocial
            .PSCTPDP6 = "1"
            .PNFECINV = HelpClass.CDate_a_Numero8Digitos(dtpFechaInv.Value)

        End With
        Dim oReporteSDS As New brReporteDS

        If boolChecActivo Then
            DtReporte = oReporteSDS.fdtRepInventarioPorFecha(oFiltro)
            intIsInventarioActual = 0
        Else
            DtReporte = oReporteSDS.fdtRepInventarioSDS(oFiltro)
        End If

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DtReporte.Rows.Count > 0 Then

            DtReporte.TableName = "StockProductosR01"
            rptTemp.SetDataSource(DtReporte)
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            '  rptTemp.SetParameterValue("pCliente", Filtro.pCCLNT_CodigoCliente)
            ' rptTemp.SetParameterValue("pRazonSocial", txtCliente.pRazonSocial)
            rptTemp.SetParameterValue("pFecha", Now)
            rptTemp.SetParameterValue("pIsInventarioActual", intIsInventarioActual)

            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = rptTemp
        End If
    End Sub
#End Region

#Region "Eventos de control"
    Private Sub frmReporteStockProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        'Cargar_Clientes()
        Cargar_Clientes1()
    End Sub

    Sub Cargar_Clientes1()

        Dim obrcliente As New Ransa.Controls.Cliente.cCliente
        Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01
        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With obeCliente
            '.pCCLNT_Cliente = 0
            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        End With
        oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

        Lista = New List(Of beCliente)

        For Each dr As DataRow In oDtCliente.Rows
            objCliente = New beCliente
            objCliente.Codigo = dr("CCLNT")
            If dr("TMTVBJ").ToString.Trim = "" Then
                objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
            Else
                objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
            End If

            objCliente.RUC = dr("NRUC")
            objCliente.Estado = 0
            Lista.Add(objCliente)
        Next

        Dim oListColum As New Hashtable

        Dim oColumnas1 As New DataGridViewCheckBoxColumn
        oColumnas1.Name = "CHK"
        oColumnas1.DataPropertyName = "CHK"
        oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas1.HeaderText = "Check"
        oColumnas1.ReadOnly = False
        oColumnas1.Visible = True
        oListColum.Add(1, oColumnas1)

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "Código"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "RUC"
        oColumnas.DataPropertyName = "RUC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "RUC"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(4, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Estado"
        oColumnas.DataPropertyName = "Estado"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oColumnas.HeaderText = "Estado"
        oColumnas.Visible = False
        oColumnas.ReadOnly = True
        oListColum.Add(5, oColumnas)

        Me.txtCliente.DataSource = Lista
        Me.txtCliente.ListColumnas = oListColum
        Me.txtCliente.Cargas()
        Me.txtCliente.DispleyMember = "Descripcion"
        Me.txtCliente.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteStockProductoR01()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbExportarExcel.Enabled = True
            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If fblnValidaInformacion() = True Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)
                pcxEspera.Visible = True
                tsbExportarExcel.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            Else
                crvReporte.ReportSource = Nothing

            End If
        Catch ex As Exception
            crvReporte.ReportSource = Nothing
        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDt As DataTable
        oDt = DtReporte.Copy
        For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
            If oDt.Rows(i).Item("NORDSR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORDSR").ToString.Trim) Then
                oDt.Rows(i).Item(0) = ""
                oDt.Rows(i).Item(1) = DBNull.Value
                oDt.Rows(i).Item(2) = ""
                oDt.Rows(i).Item(3) = ""
                oDt.Rows(i).Item(4) = DBNull.Value
                oDt.Rows(i).Item(5) = DBNull.Value
                oDt.Rows(i).Item(6) = DBNull.Value
                oDt.Rows(i).Item(7) = ""
                oDt.Rows(i).Item(8) = DBNull.Value
                oDt.Rows(i).Item(9) = ""
            End If
        Next

        oDt.TableName = "Inventario de Productos"
        oDt.Columns(0).ColumnName = "CÓDIGO \n MERCADERIA"
        oDt.Columns(1).ColumnName = "ORDEN \n SERVICIO"
        oDt.Columns(2).ColumnName = "CODIGO \n RANSA"
        oDt.Columns(3).ColumnName = "DETALLE \n MERCADERIA"
        oDt.Columns(4).ColumnName = "FECHA ULT MOV \n INGRESO"
        oDt.Columns(5).ColumnName = "FECHA ULT MOV \n SALIDA"
        oDt.Columns(6).ColumnName = "SALDO \n CANTIDAD"
        oDt.Columns(7).ColumnName = "SALDO \n UNIDAD"
        oDt.Columns(8).ColumnName = "SALDO \n PESO"
        oDt.Columns(9).ColumnName = "SALDO \n UNIDAD "
        If Not boolChecActivo Then
            oDt.Columns(10).ColumnName = "PEDIDO \n  Nro. "
            oDt.Columns(11).ColumnName = "PEDIDO \n SALDO "
        Else
            oDt.Columns.RemoveAt(10)
            oDt.Columns.RemoveAt(10)
        End If



        Dim oDs As New DataSet
        oDs.Tables.Add(oDt)
        Dim strTitulo As New List(Of String)
        'strTitulo.Add("Cliente: \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        ' strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

        '==========================Exportamos==========================
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
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

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call mpEnviarEMail(objTemp, "Stock de Productos", "Informe :  Stock de Productos")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

#End Region

    Private Sub dtpFechaInv_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInv.ValueChanged
        boolChecActivo = Me.dtpFechaInv.Checked
    End Sub

    Private Sub Formato01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Formato01ToolStripMenuItem.Click
        Dim oDt As DataTable
        Dim oDs As New DataSet
        oDt = DtReporte.Copy
        For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
            If oDt.Rows(i).Item("NORDSR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORDSR").ToString.Trim) Then
                'oDt.Rows(i).Item(0) = DBNull.Value
                'oDt.Rows(i).Item(1) = ""
                oDt.Rows(i).Item(2) = ""
                oDt.Rows(i).Item(3) = DBNull.Value
                oDt.Rows(i).Item(4) = ""
                oDt.Rows(i).Item(5) = ""
                oDt.Rows(i).Item(6) = DBNull.Value
                oDt.Rows(i).Item(7) = DBNull.Value
                oDt.Rows(i).Item(8) = ""
                oDt.Rows(i).Item(9) = DBNull.Value
                oDt.Rows(i).Item(10) = ""
                oDt.Rows(i).Item(11) = DBNull.Value
                oDt.Rows(i).Item(12) = ""
            End If
        Next

        oDt.TableName = "Inventario de Productos"
        'oDt.Columns(0).ColumnName = "CLIENTE \n CÓDIGO"
        oDt.Columns(1).ColumnName = "CLIENTE \n RAZON SOCIAL"
        oDt.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
        oDt.Columns(3).ColumnName = "ORDEN \n SERVICIO"
        oDt.Columns(4).ColumnName = "CODIGO \n RANSA"
        oDt.Columns(5).ColumnName = "DETALLE \n MERCADERIA"
        oDt.Columns(6).ColumnName = "FECHA ULT MOV \n INGRESO"
        oDt.Columns(7).ColumnName = "FECHA ULT MOV \n SALIDA"
        oDt.Columns(8).ColumnName = "REF. UBICACIÓN"
        oDt.Columns(9).ColumnName = "SALDO \n CANTIDAD"
        oDt.Columns(10).ColumnName = "SALDO \n UNIDAD"
        oDt.Columns(11).ColumnName = "SALDO \n PESO"
        oDt.Columns(12).ColumnName = "SALDO \n UNIDAD "
        If Not boolChecActivo Then
            oDt.Columns(13).ColumnName = "PEDIDO \n  Nro. "
            oDt.Columns(14).ColumnName = "PEDIDO \n SALDO "
        Else
            oDt.Columns.RemoveAt(13)
            oDt.Columns.RemoveAt(13)
        End If

        Dim oDtClientes As DataTable = oDt.Copy
        Dim oDtResultado As DataTable
        oDtResultado = oDt.Clone
        Dim oDv As New DataView(oDtClientes)
        'oDv.Sort = "NRTFSV ASC"
        Dim oDrs As DataRow()
        Dim oDrResultado As DataRow
        oDtClientes = oDv.ToTable(True, "CCLNT")
        For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
            oDtResultado = New DataTable
            oDtResultado = oDt.Clone
            oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
            oDrs = oDt.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
            For Each oDr As DataRow In oDrs
                oDrResultado = oDtResultado.NewRow
                For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                    oDrResultado(intColumns) = oDr(intColumns)
                Next
                oDtResultado.Rows.Add(oDrResultado)
            Next
            oDtResultado.Columns(0).ColumnName = "CLIENTE \n CÓDIGO"
            oDs.Tables.Add(oDtResultado)
        Next
        Dim strTitulo As New List(Of String)
        'strTitulo.Add("Cliente: \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

        '==========================Exportamos==========================
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
    End Sub

    Private Sub Formato02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Formato02ToolStripMenuItem.Click
        Dim oDt As DataTable
        Dim oDs As New DataSet

        oDt = DtReporte.Copy
        For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
            If oDt.Rows(i).Item("NORDSR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORDSR").ToString.Trim) Then
                oDt.Rows(i).Item(6) = DBNull.Value
                oDt.Rows(i).Item(7) = DBNull.Value
                oDt.Rows(i).Item(8) = ""
                oDt.Rows(i).Item(9) = DBNull.Value
                oDt.Rows(i).Item(10) = ""
                oDt.Rows(i).Item(11) = DBNull.Value
                oDt.Rows(i).Item(12) = ""
            End If
        Next

        oDt.TableName = "Inventario de Productos"
        oDt.Columns(1).ColumnName = "CLIENTE \n RAZON SOCIAL"
        oDt.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
        oDt.Columns(3).ColumnName = "ORDEN \n SERVICIO"
        oDt.Columns(4).ColumnName = "CODIGO \n RANSA"
        oDt.Columns(5).ColumnName = "DETALLE \n MERCADERIA"
        oDt.Columns(6).ColumnName = "FECHA ULT MOV \n INGRESO"
        oDt.Columns(7).ColumnName = "FECHA ULT MOV \n SALIDA"
        oDt.Columns(8).ColumnName = "REF. UBICACIÓN"
        oDt.Columns(9).ColumnName = "SALDO \n CANTIDAD"
        oDt.Columns(10).ColumnName = "SALDO \n UNIDAD"
        oDt.Columns(11).ColumnName = "SALDO \n PESO"
        oDt.Columns(12).ColumnName = "SALDO \n UNIDAD "
        If Not boolChecActivo Then
            oDt.Columns(13).ColumnName = "PEDIDO \n  Nro. "
            oDt.Columns(14).ColumnName = "PEDIDO \n SALDO "
        Else
            oDt.Columns.RemoveAt(13)
            oDt.Columns.RemoveAt(13)
        End If


        Dim oDtClientes As DataTable = oDt.Copy
        Dim oDtResultado As DataTable
        oDtResultado = oDt.Clone
        Dim oDv As New DataView(oDtClientes)
        'oDv.Sort = "NRTFSV ASC"
        Dim oDrs As DataRow()
        Dim oDrResultado As DataRow
        oDtClientes = oDv.ToTable(True, "CCLNT")
        For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
            oDtResultado = New DataTable
            oDtResultado = oDt.Clone
            oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
            oDrs = oDt.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
            For Each oDr As DataRow In oDrs
                oDrResultado = oDtResultado.NewRow
                For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                    oDrResultado(intColumns) = oDr(intColumns)
                Next
                oDtResultado.Rows.Add(oDrResultado)
            Next
            oDtResultado.Columns(0).ColumnName = "CLIENTE \n CÓDIGO"
            oDs.Tables.Add(oDtResultado)
        Next

        Dim strTitulo As New List(Of String)
        ' strTitulo.Add("Cliente: \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

        '==========================Exportamos==========================
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
    End Sub

    Private Sub tsbExportarExcel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

    End Sub
 
    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""

        Dim ListaS As New List(Of String)

        ListaS = CType(txtCliente.Resultado, List(Of String))

        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next

        'For Each items As Integer In cmbCliente.Properties.GetCheckedItems
        '    strCadDocumentos += cmbCliente.Properties.ValueMember & ","
        'Next

        'For i As Integer = 0 To cmbCliente.Properties.Items.Count - 1
        '    strCadDocumentos += cmbCliente.CheckedItems(i).Value & ","
        'Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Function ListaRazonSocialClientes() As String
        Dim strCadDocumentos As String = ""
        'For i As Integer = 0 To cmbCliente.CheckedItems.Count - 1
        '    strCadDocumentos += cmbCliente.CheckedItems(i).name.ToString.Replace("<->", ",").Split(",").GetValue(1) & ","
        'Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

End Class
