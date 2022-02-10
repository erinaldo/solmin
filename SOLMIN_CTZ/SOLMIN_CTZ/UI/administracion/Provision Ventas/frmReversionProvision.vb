Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports System.Globalization

Public Class frmReversionProvision
    ''' <summary>
    ''' Modified: Miguel Dagnino 20/10/2015
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmProvisionDeVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Compania()
        Cargar_Region_Venta()
        Cargar_Mes()
        txtAnio.Text = Now.Year.ToString
    End Sub


    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    ''' <summary>
    ''' Cargar Mes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Mes()
        cmbMes.Properties.DataSource = HelpClass.odtMeses ' dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        cmbMes.SetEditValue(Now.Month.ToString.PadLeft(2, "0"))
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.Properties.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.Properties.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.Properties.DataSource = oDtRegionVenta
    End Sub

    Private Sub btnGenerarProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarProvision.Click
        Dim ofrmGenerarProvision As New frmGenerarProvision
        ofrmGenerarProvision.CCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmGenerarProvision.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarCabReversionProvision()
    End Sub


    Private Sub BuscarCabReversionProvision()
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With

        dtgDetReversionProvision.AutoGenerateColumns = False
        dtgDetReversionProvision.DataSource = Nothing

        dtgCabReversionProvision.AutoGenerateColumns = False

        'INI-ECM-Estimación-de-Ingreso-Anulación[RF002]-100516
        Dim dtListaReversionProvision As New DataTable
        dtListaReversionProvision = obrProvisionVentas.fdtListaReversionProvision(obeProvisionVentas)
        Dim bit = New Bitmap(16, 16)
        dtListaReversionProvision.Columns.Add("EstadoEnvioSAP", bit.GetType())
        bit.Dispose()

        For Each row As DataRow In dtListaReversionProvision.Rows
            Dim indice As Integer = Integer.Parse(row("STDPROV"))
            row(dtListaReversionProvision.Columns.Count - 1) = imlEstadoEnvioSAP.Images(indice)
        Next

        dtgCabReversionProvision.DataSource = dtListaReversionProvision 'obrProvisionVentas.fdtListaReversionProvision(obeProvisionVentas)
        'FIN-ECM-Estimación-de-Ingreso-Anulación[RF002]-100516
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbRegionVenta.EditValue = "" Then
            strMensajeError &= "Debe seleccionar Región de Venta. " & vbNewLine
        End If

        If txtAnio.Text.Trim = "" OrElse txtAnio.Text = "0" OrElse txtAnio.Text.Trim <= "2000" Then
            strMensajeError &= "Debe Ingresar un año correcto. " & vbNewLine
        End If

        If cmbMes.EditValue = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub dtgCabReversionProvision_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCabReversionProvision.SelectionChanged
        BuscarDetReversionProvision()
    End Sub


    Private Sub BuscarDetReversionProvision()
        If Me.dtgCabReversionProvision.CurrentCellAddress.Y = -1 Then Exit Sub
        Try
            Dim obrProvisionVentas As New clsProvisionDeVenta
            Dim obeProvisionVentas As New ProvisionVenta
            With obeProvisionVentas
                .CCMPN = dtgCabReversionProvision.CurrentRow.DataBoundItem.Item("CCMPN")
                .NMRVVT = dtgCabReversionProvision.CurrentRow.DataBoundItem.Item("NMRVVT")
            End With
            dtgDetReversionProvision.AutoGenerateColumns = False
            Dim oDt As New DataTable
            oDt = obrProvisionVentas.fdtDetalleReversionProvion(obeProvisionVentas)

            dtgDetReversionProvision.Columns.Clear()
            Me.dtgDetReversionProvision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dtgDetReversionProvision.Dock = System.Windows.Forms.DockStyle.Fill
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            For i As Integer = 0 To oDt.Columns.Count - 1
                Dim objCol As New DataGridViewColumn
                objCol.Name = oDt.Columns(i).ColumnName
                Dim objCelda As New DataGridViewTextBoxCell
                objCol.CellTemplate = objCelda

                If i <= 6 Then
                    If oDt.Columns(i).ColumnName = "CCMPN" Then
                        objCol.HeaderText = "Compañía"
                        objCol.Visible = False
                        objCol.Width = 50
                    ElseIf oDt.Columns(i).ColumnName = "NMRVVT" Then
                        objCol.HeaderText = "Cod. Reversión"
                        objCol.Visible = False
                        objCol.Width = 120
                    ElseIf oDt.Columns(i).ColumnName = "CCNTCS" Then
                        objCol.HeaderText = "Cod. Centro Beneficio"
                        objCol.Visible = True
                        objCol.DisplayIndex = 0
                        objCol.Width = 120
                    ElseIf oDt.Columns(i).ColumnName = "TCNTCS" Then
                        objCol.HeaderText = "Centro de Beneficio"
                        objCol.DisplayIndex = 1
                        objCol.Visible = True
                        objCol.Width = 150
                    ElseIf oDt.Columns(i).ColumnName = "CCNBNS" Then
                        objCol.HeaderText = "Centro de Beneficio"
                        objCol.DisplayIndex = 1
                        objCol.Visible = False
                        objCol.Width = 150
                    ElseIf oDt.Columns(i).ColumnName = "CCLNFC" Then
                        objCol.HeaderText = "Cod. Cliente"
                        objCol.DisplayIndex = 2
                        objCol.Visible = True
                        objCol.Width = 50
                    ElseIf oDt.Columns(i).ColumnName = "TCMPCL" Then
                        objCol.HeaderText = "Razón Social Cliente"
                        objCol.DisplayIndex = 3
                        objCol.Visible = True
                        objCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
                    End If
                    'objCol.Name = oDt.Columns(i).ColumnName
                Else
                    objCol.HeaderText = oDt.Columns(i).ColumnName
                    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                    DataGridViewCellStyle2.Format = "N2"
                    objCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    objCol.DefaultCellStyle = DataGridViewCellStyle2
                End If

                dtgDetReversionProvision.Columns.Add(objCol)
            Next

            For i As Integer = 0 To oDt.Rows.Count - 1
                Dim objRow As New DataGridViewRow
                objRow.CreateCells(dtgDetReversionProvision)
                For j As Integer = 0 To oDt.Columns.Count - 1
                    objRow.Cells(j).Value = oDt.Rows(i)(j)
                Next
                dtgDetReversionProvision.Rows.Add(objRow)
            Next

        Catch ex As Exception
        End Try

    End Sub



    Private Sub dtgDetProvision_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetReversionProvision.CellDoubleClick
        If dtgDetReversionProvision.CurrentCellAddress.Y = -1 Then Exit Sub
        If e.ColumnIndex >= 7 Then 'If dtgDetReversionProvision.Columns(e.ColumnIndex).Name = "Detalle" Then
            Try
                Dim ofrmListOperacionesRevertidas As New frmListOperacionesRevertidas
                Dim obeProvisionVenta As New ProvisionVenta

                With obeProvisionVenta
                    .CCMPN = dtgDetReversionProvision.CurrentRow.Cells("CCMPN").Value
                    .NMRVVT = dtgDetReversionProvision.CurrentRow.Cells("NMRVVT").Value
                    .CCNTCS = dtgDetReversionProvision.CurrentRow.Cells("CCNTCS").Value
                    .CCLNFC = dtgDetReversionProvision.CurrentRow.Cells("CCLNFC").Value
                    Dim cultura As New CultureInfo("es-ES")
                    'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
                    'dtgDetReversionProvision.CurrentCell.OwningColumn.owningColumn.HeaderText()
                    Dim AnioMes As String = ""
                    If Convert.ToInt32(DateTime.ParseExact(dtgDetReversionProvision.CurrentCell.OwningColumn.Name.Split(" ")(0), "MMMM", cultura).Month) < 10 Then
                        AnioMes = dtgDetReversionProvision.CurrentCell.OwningColumn.Name.Split(" ")(1) & "0" & DateTime.ParseExact(dtgDetReversionProvision.CurrentCell.OwningColumn.Name.Split(" ")(0), "MMMM", cultura).Month
                    Else
                        AnioMes = dtgDetReversionProvision.CurrentCell.OwningColumn.Name.Split(" ")(1) & DateTime.ParseExact(dtgDetReversionProvision.CurrentCell.OwningColumn.Name.Split(" ")(0), "MMMM", cultura).Month
                    End If
                    .ANIOMES = AnioMes

                End With
                ofrmListOperacionesRevertidas.obeProvisionVenta = obeProvisionVenta
                ofrmListOperacionesRevertidas.ShowDialog()
            Catch ex As Exception

            End Try


        End If

    End Sub

 

    Private Sub ExportarExcel_Formato01()
        Dim oDs As New DataSet
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With
        oDs = obrProvisionVentas.fdsListaReversionesExportar(obeProvisionVentas, 1)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)
        Dim lstSuma As New List(Of Hashtable)
        'oDs.Tables(0).TableName = "Reporte1"
        'oDs.Tables(1).TableName = "Reporte2"
        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("Negocio:\n " & IIf(Me.cmbRegionVenta.Text.Trim.Equals(""), "TODOS", Me.cmbRegionVenta.Text))
        olstr.Add("Mes Año:\n " & cmbMes.Text & " de " & txtAnio.Text)
        Dim olstrSuma As New Hashtable

        'olstrSuma.Add(1.2, 23)
        'olstrSuma.Add(2.1, 38)
        olstrSuma.Add(1.1, 39)
        olstrSuma.Add(1.2, 40)
        olstrSuma.Add(2.1, 52)
        olstrSuma.Add(2.2, 53)



        Dim intCorrelativo As Integer = 2
        For intX As Integer = 2 To oDs.Tables.Count - 1
            Dim intNroColumns As Integer = 8
            Dim strNroColumns As String = String.Empty
            For intColumns As Integer = 7 To oDs.Tables(intX).Columns.Count

                If intCorrelativo.ToString.Length = 1 Then
                    strNroColumns = (intX + 1).ToString & ".0" & (intCorrelativo).ToString
                Else
                    strNroColumns = (intX + 1).ToString & "." & (intCorrelativo).ToString
                End If
                olstrSuma.Add(CType(strNroColumns, Decimal), intNroColumns)
                intNroColumns += 1
                intCorrelativo += 1
            Next

        Next


        Ransa.Utilitario.HelpClass.ExportExcel_Formato01(oDs, "Reversión de Provisión", olstr, olstrSuma)
    End Sub


    Private Sub ExportarExcel_Formato02()
        Dim oDs As New DataSet
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With
        oDs = obrProvisionVentas.fdsListaReversionesExportar(obeProvisionVentas, 2)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)
        Dim lstSuma As New List(Of Hashtable)
        'oDs.Tables(0).TableName = "Reporte1"
        'oDs.Tables(1).TableName = "Reporte2"
        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("Negocio:\n " & IIf(Me.cmbRegionVenta.Text.Trim.Equals(""), "TODOS", Me.cmbRegionVenta.Text))
        olstr.Add("Mes Año:\n " & cmbMes.Text & " de " & txtAnio.Text)
        Dim olstrSuma As New Hashtable

        'olstrSuma.Add(1.2, 23)
        'olstrSuma.Add(2.1, 38)
        olstrSuma.Add(1.1, 39)
        olstrSuma.Add(1.2, 40)

        olstrSuma.Add(2.1, 52)
        olstrSuma.Add(2.2, 53)



        Dim intCorrelativo As Integer = 2
        For intX As Integer = 2 To oDs.Tables.Count - 1
            Dim intNroColumns As Integer = 10
            Dim strNroColumns As String = String.Empty
            For intColumns As Integer = 9 To oDs.Tables(intX).Columns.Count
                strNroColumns = (intX + 1).ToString & "." & intCorrelativo
                olstrSuma.Add(CType(strNroColumns, Decimal), intNroColumns)
                intNroColumns += 1
                intCorrelativo += 1
            Next

        Next


        Ransa.Utilitario.HelpClass.ExportExcel_Formato01(oDs, "Reversión de Provisión", olstr, olstrSuma)
    End Sub
 
    Private Sub tsmFormato01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFormato01.Click
        ExportarExcel_Formato01()
    End Sub

    Private Sub tsmFormato02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFormato02.Click
        ExportarExcel_Formato02()
    End Sub

    'INI-ECM-Estimación-de-Ingreso-Anulación[RF002]-100516
    Private Sub BtnEnviarSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviarSAP.Click
        Try
            Dim logica As New clsProvisionDeVenta
            Dim parametros As New ProvisionVenta

            Dim stdprov As Integer = dtgCabReversionProvision.CurrentRow.DataBoundItem.item("STDPROV")
            Dim nmrvvt As String = dtgCabReversionProvision.CurrentRow.DataBoundItem.item("NMRVVT")
            If stdprov = 1 Then
                MessageBox.Show(String.Format("No es posible realizar el proceso de envío al SAP de la reversión: {0} porque ha sido procesada correctamente.", nmrvvt), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ListRequestDataReversion As New List(Of RequestDataReversion)
                With parametros
                    .CCMPN = dtgCabReversionProvision.CurrentRow.DataBoundItem.item("CCMPN") 'Compañía 
                    .NMRVVT = dtgCabReversionProvision.CurrentRow.DataBoundItem.item("NMRVVT") 'Reversión de Venta 
                End With

                ListRequestDataReversion = logica.ObtenerListaProvisiones(parametros)
                Dim url_ws_servicio As String = ""

                If ListRequestDataReversion.Count = 0 Then
                    MessageBox.Show(String.Format("No es posible realizar el proceso de envío al SAP de la reversión: {0} porque no se ha encontrado información de provisiones.", nmrvvt), "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim wsSalmon As New Ransa.Controls.ServicioOperacion.ws_reversion_Ingreso.ws_salmon

                    Dim dt_url_servicio As New DataTable
                    Dim oda_url_servicio As New SOLMIN_CTZ.NEGOCIO.clsUrlServicio
                    dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)

                    If dt_url_servicio.Rows.Count > 0 Then
                        url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
                    End If
                    wsSalmon.Url = url_ws_servicio
                    For Each request As RequestDataReversion In ListRequestDataReversion
                        wsSalmon.ws_reversion_ingreso(request.IDESTM, request.CSCDSP, request.NDESAP, request.ACNTSP, request.NDCCTE, request.FDCFCC)
                    Next request

                    BuscarCabReversionProvision()

                    MessageBox.Show("Se realizó el proceso de envío al SAP satisfactoriamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error en el proceso de envío al SAP, comuníquese con el departamento de sistema.{0}{1}", vbNewLine, ex.Message), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    'FIN-ECM-Estimación-de-Ingreso-Anulación[RF002]-100516
End Class
