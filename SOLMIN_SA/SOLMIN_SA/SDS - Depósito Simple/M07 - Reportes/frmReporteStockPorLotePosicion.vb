
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports Ransa.TYPEDEF
Imports Ransa.TYPEDEF.Reportes
Imports RANSA.Utilitario

Public Class frmReporteStockPorLotePosicion

#Region "Declaracion de variables"

    Public objCliente As beCliente
    Public Lista As List(Of beCliente)

    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New rptInventarioPosicion
    Private DsReporte As New DataSet
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        ' Validamos los valores de la Guía de Salida

        'If cmbCliente.Properties.GetCheckedItems = "" Then
        '    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        'End If

        txtCliente.Refresh()
        If txtCliente.Resultado IsNot Nothing Then
            Dim Estado As String = txtCliente.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    tsbExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    tsbExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        tsbExcel.Enabled = False
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


    Private Sub pReporteInventarioXUbicacionPosicion()
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        rptTemp = New rptStockProductoXUbicacionXposicion
        Dim strMensaje As String = String.Empty
        Dim Est As String = txtCliente.Resultado.GetType.ToString
        Dim obrReporteDS As New brReporteDS
        Try
            With obeFiltro
                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCCLNT = CType(txtCliente.Resultado, beCliente).Codigo
                Else
                    .PSCCLNT = ListaCodigoClientes()
                End If

                .PSCTPDP6 = "1"
                If txtTipoAlmacen.Resultado IsNot Nothing Then .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                If txtAlmacen.Resultado IsNot Nothing Then .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
            End With
            DsReporte = obrReporteDS.fdtInventarioPorLotePorPosicion(obeFiltro)


            
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Exit Sub
        End Try



    End Sub

    Private Sub pReporteInventarioMercaderiaPosicion()
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        rptTemp = New rptStockProductoXPosicion
        Dim strMensaje As String = String.Empty
        Dim Est As String = txtCliente.Resultado.GetType.ToString

        Try
            With obeFiltro
                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCCLNT = CType(txtCliente.Resultado, beCliente).Codigo
                Else
                    .PSCCLNT = ListaCodigoClientes()
                End If

                .PSCTPDP6 = "1"
                If txtTipoAlmacen.Resultado IsNot Nothing Then .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                If txtAlmacen.Resultado IsNot Nothing Then .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
            End With
            DsReporte = brReporteDS.fdtInventarioPorPosicion(obeFiltro)

            Dim dtTemp As DataTable
            dtTemp = DsReporte.Tables(0).Copy


            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CPSCN") = dtTemp.Rows(intX - 1).Item("CPSCN") Then
                        dtTemp.Rows(intX).Item("CPSCN") = ""
                        dtTemp.Rows(intX).Item("QSLETQ") = 0
                    End If
                Next
            End If

            Dim dView As New DataView(dtTemp)
            dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CPSCN DESC"
            dtTemp = dView.ToTable()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CPSCN") = "" Then
                        dtTemp.Rows.RemoveAt(intX)
                    End If
                Next
            End If

            rptTemp.SetDataSource(dtTemp.Copy)
            CType(rptTemp.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario

            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = rptTemp
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Exit Sub
        End Try



    End Sub

    Private Sub CargarControles()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub


    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = 1
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub




#End Region

#Region "Eventos de Control"
    Private Sub frmReporteInventarioPorPosicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0
        Cargar_Clientes1()
        CargarControles()
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


        pReporteInventarioXUbicacionPosicion()
        

    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbGenerarReporte.Enabled = True
            tsbExcel.Enabled = True

            dgConsulta.AutoGenerateColumns = False
            dgConsulta.DataSource = DsReporte.Tables(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
        Catch ex As Exception

        End Try

    End Sub



    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New Ransa.TYPEDEF.beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

        'If objEntidad.STSOP1 = "" Then
        '    bsaGenerarGuiaRegularizacion.Visible = False
        'Else
        '    bsaGenerarGuiaRegularizacion.Visible = True
        'End If
    End Sub




#End Region

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


    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() = True Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True

                tsbExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                bgwGifAnimado.RunWorkerAsync()
              

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCliente_CambioDeTexto(ByVal objData As System.Object) Handles txtCliente.CambioDeTexto
        'txtTipoAlmacen.Text = ""
        '' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        'txtAlmacen.Text = ""
        'txtZonaAlmacen.Text = ""
    End Sub

    Private Sub Formato01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDs As New DataSet
        Try
            Dim dtTemp As DataTable = DsReporte.Tables(0).Copy()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CPSCN") = dtTemp.Rows(intX - 1).Item("CPSCN") Then
                        dtTemp.Rows(intX).Item("CPSCN") = ""
                        dtTemp.Rows(intX).Item("QSLETQ") = 0
                    End If
                Next
            End If

            Dim dView As New DataView(dtTemp)
            dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CPSCN DESC"
            dtTemp = dView.ToTable()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CPSCN") = "" Then
                        dtTemp.Rows.RemoveAt(intX)
                    End If
                Next
            End If

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CPSCN") <> "" Then
                        dtTemp.Rows(intX).Item("TCMPCL") = DBNull.Value
                        dtTemp.Rows(intX).Item("CTPALM") = DBNull.Value
                        dtTemp.Rows(intX).Item("TALMC") = DBNull.Value
                        dtTemp.Rows(intX).Item("CALMC") = DBNull.Value
                        dtTemp.Rows(intX).Item("TCMPAL") = DBNull.Value
                        dtTemp.Rows(intX).Item("CMRCLR") = DBNull.Value
                        dtTemp.Rows(intX).Item("NORDSR") = DBNull.Value
                        dtTemp.Rows(intX).Item("TMRCD2") = DBNull.Value
                        dtTemp.Rows(intX).Item("QSLMC2") = DBNull.Value
                        dtTemp.Rows(intX).Item("CUNCN5") = DBNull.Value
                        dtTemp.Rows(intX).Item("QSLMP2") = DBNull.Value
                        dtTemp.Rows(intX).Item("CUNPS5") = DBNull.Value
                    End If
                Next
            End If

            dtTemp.Columns("TCMPCL").ColumnName = "CLIENTE \n RAZON SOCIAL"
            dtTemp.Columns("CTPALM").ColumnName = "TIPO ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TALMC").ColumnName = "TIPO ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CALMC").ColumnName = "ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TCMPAL").ColumnName = "ALMACÉN \n DESCRIPCIÓN"

            dtTemp.Columns("CMRCLR").ColumnName = "MERCADERIA \n CÓDIGO"
            dtTemp.Columns("NORDSR").ColumnName = "MERCADERIA \n ORDEN DE SERVICIO"
            dtTemp.Columns("TMRCD2").ColumnName = "MERCADERIA \n DESCRIPCIÓN"
            dtTemp.Columns("QSLMC2").ColumnName = "MERCADERIA \n STOCK ORDEN"
            dtTemp.Columns("CUNCN5").ColumnName = "MERCADERIA \n UNIDAD MEDIA"
            dtTemp.Columns("QSLMP2").ColumnName = "MERCADERIA \n PESO"
            dtTemp.Columns("CUNPS5").ColumnName = "MERCADERIA \n UNIDAD PESO"
            dtTemp.Columns("CPSCN").ColumnName = "MERCADERIA \n POSICIÓN"
            dtTemp.Columns("QSLETQ").ColumnName = "MERCADERIA \n STOCK POSICIÓN"


            Dim oDtClientes As DataTable = dtTemp.Copy
            Dim oDtResultado As DataTable
            oDtResultado = dtTemp.Clone
            Dim oDv As New DataView(oDtClientes)
            'oDv.Sort = "NRTFSV ASC"
            Dim oDrs As DataRow()
            Dim oDrResultado As DataRow
            oDtClientes = oDv.ToTable(True, "CCLNT")
            For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
                oDtResultado = New DataTable
                oDtResultado = dtTemp.Clone
                oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
                oDrs = dtTemp.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
                For Each oDr As DataRow In oDrs
                    oDrResultado = oDtResultado.NewRow
                    For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                        oDrResultado(intColumns) = oDr(intColumns)
                    Next
                    oDtResultado.Rows.Add(oDrResultado)
                Next
                oDtResultado.Columns.Remove("CCLNT")
                oDs.Tables.Add(oDtResultado)
            Next
            Dim strTitulo As New List(Of String)
            strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, "INVENTARIO POR POSICIÓN", strTitulo)
            '==============================================================
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub

    Private Sub Formato02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDs As New DataSet
        Try
            Dim dtTemp As DataTable = DsReporte.Tables(0).Copy()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CPSCN") = dtTemp.Rows(intX - 1).Item("CPSCN") Then
                        dtTemp.Rows(intX).Item("CPSCN") = ""
                        dtTemp.Rows(intX).Item("QSLETQ") = 0
                    End If
                Next
            End If

            Dim dView As New DataView(dtTemp)
            dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CPSCN DESC"
            dtTemp = dView.ToTable()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CPSCN") = "" Then
                        dtTemp.Rows.RemoveAt(intX)
                    End If
                Next
            End If

            dtTemp.Columns("TCMPCL").ColumnName = "CLIENTE \n RAZON SOCIAL"
            dtTemp.Columns("CTPALM").ColumnName = "TIPO ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TALMC").ColumnName = "TIPO ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CALMC").ColumnName = "ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TCMPAL").ColumnName = "ALMACÉN \n DESCRIPCIÓN"

            dtTemp.Columns("CMRCLR").ColumnName = "MERCADERIA \n CÓDIGO"
            dtTemp.Columns("NORDSR").ColumnName = "MERCADERIA \n ORDEN DE SERVICIO"
            dtTemp.Columns("TMRCD2").ColumnName = "MERCADERIA \n DESCRIPCIÓN"
            dtTemp.Columns("QSLMC2").ColumnName = "MERCADERIA \n STOCK ORDEN"
            dtTemp.Columns("CUNCN5").ColumnName = "MERCADERIA \n UNIDAD MEDIA"
            dtTemp.Columns("QSLMP2").ColumnName = "MERCADERIA \n PESO"
            dtTemp.Columns("CUNPS5").ColumnName = "MERCADERIA \n UNIDAD PESO"
            dtTemp.Columns("CPSCN").ColumnName = "MERCADERIA \n POSICIÓN"
            dtTemp.Columns("QSLETQ").ColumnName = "MERCADERIA \n STOCK POSICIÓN"


            Dim oDtClientes As DataTable = dtTemp.Copy
            Dim oDtResultado As DataTable
            oDtResultado = dtTemp.Clone
            Dim oDv As New DataView(oDtClientes)
            'oDv.Sort = "NRTFSV ASC"
            Dim oDrs As DataRow()
            Dim oDrResultado As DataRow
            oDtClientes = oDv.ToTable(True, "CCLNT")
            For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
                oDtResultado = New DataTable
                oDtResultado = dtTemp.Clone
                oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
                oDrs = dtTemp.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
                For Each oDr As DataRow In oDrs
                    oDrResultado = oDtResultado.NewRow
                    For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                        oDrResultado(intColumns) = oDr(intColumns)
                    Next
                    oDtResultado.Rows.Add(oDrResultado)
                Next
                oDtResultado.Columns("CCLNT").ColumnName = "CLIENTE \n CODIGO"
                oDs.Tables.Add(oDtResultado)
            Next
            Dim strTitulo As New List(Of String)
            strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, "INVENTARIO POR POSICIÓN", strTitulo)
            '==============================================================
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub


    Private Sub Formato03ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDs As New DataSet
        Try
            Dim dtTemp As DataTable = DsReporte.Tables(0).Copy()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CPSCN") = dtTemp.Rows(intX - 1).Item("CPSCN") Then
                        dtTemp.Rows(intX).Item("CPSCN") = ""
                        dtTemp.Rows(intX).Item("QSLETQ") = 0
                    End If
                Next
            End If

            Dim dView As New DataView(dtTemp)
            dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CZNALM,CPSCN DESC"
            dtTemp = dView.ToTable()

            If dtTemp.Rows.Count > 0 Then
                For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
                    If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CZNALM") = dtTemp.Rows(intX - 1).Item("CZNALM") And dtTemp.Rows(intX).Item("CPSCN") = "" Then
                        dtTemp.Rows.RemoveAt(intX)
                    End If
                Next
            End If

            'Dim dView As New DataView(dtTemp)
            'dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CZNALM,CPSCN DESC"
            'dtTemp = dView.ToTable()


            dtTemp.Columns("TCMPCL").ColumnName = "CLIENTE \n RAZON SOCIAL"
            dtTemp.Columns("CTPALM").ColumnName = "TIPO ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TALMC").ColumnName = "TIPO ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CALMC").ColumnName = "ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TCMPAL").ColumnName = "ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CZNALM").ColumnName = "ZONA ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TCMZNA").ColumnName = "ZONA ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CMRCLR").ColumnName = "MERCADERIA \n CÓDIGO"
            dtTemp.Columns("NORDSR").ColumnName = "MERCADERIA \n ORDEN DE SERVICIO"
            dtTemp.Columns("TMRCD2").ColumnName = "MERCADERIA \n DESCRIPCIÓN"
            dtTemp.Columns("QSLMC2").ColumnName = "MERCADERIA \n STOCK ORDEN"
            dtTemp.Columns("CUNCN5").ColumnName = "MERCADERIA \n UNIDAD MEDIA"
            dtTemp.Columns("QSLMP2").ColumnName = "MERCADERIA \n PESO"
            dtTemp.Columns("CUNPS5").ColumnName = "MERCADERIA \n UNIDAD PESO"
            dtTemp.Columns("CPSCN").ColumnName = "MERCADERIA \n POSICIÓN"
            dtTemp.Columns("QSLETQ").ColumnName = "MERCADERIA \n STOCK POSICIÓN"


            Dim oDtClientes As DataTable = dtTemp.Copy
            Dim oDtResultado As DataTable
            oDtResultado = dtTemp.Clone
            Dim oDv As New DataView(oDtClientes)
            'oDv.Sort = "NRTFSV ASC"
            Dim oDrs As DataRow()
            Dim oDrResultado As DataRow
            oDtClientes = oDv.ToTable(True, "CCLNT")
            For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
                oDtResultado = New DataTable
                oDtResultado = dtTemp.Clone
                oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
                oDrs = dtTemp.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
                For Each oDr As DataRow In oDrs
                    oDrResultado = oDtResultado.NewRow
                    For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                        oDrResultado(intColumns) = oDr(intColumns)
                    Next
                    oDtResultado.Rows.Add(oDrResultado)
                Next
                oDtResultado.Columns("CCLNT").ColumnName = "CLIENTE \n CODIGO"
                oDs.Tables.Add(oDtResultado)
            Next
            Dim strTitulo As New List(Of String)
            strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, "INVENTARIO POR POSICIÓN", strTitulo)
            '==============================================================
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsbExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExcel.Click
        Dim oDs As New DataSet
        Try
            Dim dtTemp As DataTable = DsReporte.Tables(0).Copy()

            'If dtTemp.Rows.Count > 0 Then
            '    For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            '        If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CPSCN") = dtTemp.Rows(intX - 1).Item("CPSCN") Then
            '            dtTemp.Rows(intX).Item("CPSCN") = ""
            '            dtTemp.Rows(intX).Item("QSLETQ") = 0
            '        End If
            '    Next
            'End If

            Dim dView As New DataView(dtTemp)
            dView.Sort = "CCLNT, CTPALM, CALMC, CMRCLR, NORDSR,CRTLTE,CPSCN DESC"
            dtTemp = dView.ToTable()

            'If dtTemp.Rows.Count > 0 Then
            '    For intX As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            '        If dtTemp.Rows(intX).Item("NORDSR") = dtTemp.Rows(intX - 1).Item("NORDSR") And dtTemp.Rows(intX).Item("CTPALM") = dtTemp.Rows(intX - 1).Item("CTPALM") And dtTemp.Rows(intX).Item("CALMC") = dtTemp.Rows(intX - 1).Item("CALMC") And dtTemp.Rows(intX).Item("CPSCN") = "" Then
            '            dtTemp.Rows.RemoveAt(intX)
            '        End If
            '    Next
            'End If

            dtTemp.Columns("TCMPCL").ColumnName = "CLIENTE \n RAZON SOCIAL"
            dtTemp.Columns("CTPALM").ColumnName = "TIPO ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TALMC").ColumnName = "TIPO ALMACÉN \n DESCRIPCIÓN"
            dtTemp.Columns("CALMC").ColumnName = "ALMACÉN \n CÓDIGO"
            dtTemp.Columns("TCMPAL").ColumnName = "ALMACÉN \n DESCRIPCIÓN"

            dtTemp.Columns("CMRCLR").ColumnName = "MERCADERIA \n CÓDIGO"
            dtTemp.Columns("NORDSR").ColumnName = "MERCADERIA \n ORDEN DE SERVICIO"
            dtTemp.Columns("TMRCD2").ColumnName = "MERCADERIA \n DESCRIPCIÓN"
            dtTemp.Columns("QSLMC2").ColumnName = "MERCADERIA \n STOCK ORDEN"
            dtTemp.Columns("CUNCN5").ColumnName = "MERCADERIA \n UNIDAD MEDIA"
            dtTemp.Columns("QSLMP2").ColumnName = "MERCADERIA \n PESO"
            dtTemp.Columns("CUNPS5").ColumnName = "MERCADERIA \n UNIDAD PESO"

            dtTemp.Columns("CRTLTE").ColumnName = "MERCADERIA \n CRITERIO DE LOTE"
            dtTemp.Columns("QMRCSL").ColumnName = "MERCADERIA \n STOCK LOTE"

            dtTemp.Columns("CPSCN").ColumnName = "MERCADERIA \n POSICIÓN"
            dtTemp.Columns("QSLETQ").ColumnName = "MERCADERIA \n STOCK POSICIÓN"


            Dim oDtClientes As DataTable = dtTemp.Copy
            Dim oDtResultado As DataTable
            oDtResultado = dtTemp.Clone
            Dim oDv As New DataView(oDtClientes)
            'oDv.Sort = "NRTFSV ASC"
            Dim oDrs As DataRow()
            Dim oDrResultado As DataRow
            oDtClientes = oDv.ToTable(True, "CCLNT")
            For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
                oDtResultado = New DataTable
                oDtResultado = dtTemp.Clone
                oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
                oDrs = dtTemp.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
                For Each oDr As DataRow In oDrs
                    oDrResultado = oDtResultado.NewRow
                    For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
                        oDrResultado(intColumns) = oDr(intColumns)
                    Next
                    oDtResultado.Rows.Add(oDrResultado)
                Next
                oDtResultado.Columns("CCLNT").ColumnName = "CLIENTE \n CODIGO"
                oDs.Tables.Add(oDtResultado)
            Next
            Dim strTitulo As New List(Of String)
            strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)

            '==========================Exportamos==========================
            HelpClass.ExportExcelConTitulos(oDs, "STOCK DE MERCADERÍA POR LOTES/ POSICIÓN", strTitulo)
            '==============================================================
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub
End Class
