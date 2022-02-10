Imports Ransa.Utilitario
Imports System.Windows.Forms

Public Class frmConsultaIncidenciaPorFecha

    Private rptTemp As rptIncidenciaPorFecha1
    Public objCliente As beCliente
    Public Lista As List(Of beCliente)
    Dim DSGENERAL As DataSet
    Dim DTGENERAL As DataTable

#Region "PROPIEDADES"

    Private _Compania As String
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pArea As String
    Public Property pArea() As String
        Get
            Return _pArea
        End Get
        Set(ByVal value As String)
            _pArea = value
        End Set
    End Property

    Private _pIncPara As Decimal
    Public Property pIncPara() As Decimal
        Get
            Return _pIncPara
        End Get
        Set(ByVal value As Decimal)
            _pIncPara = value
        End Set
    End Property

    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)
    Dim obj As HelpClass

#End Region

#Region "EVENTOS"

    Private Sub frmListaRegistroIncidencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            'Cargar_Divisiones()
            Cargar_Areas()
            Cargar_Reportado()
            Cargar_Plantas()
            Cargar_Clientes1()
            CargaTipoAlmacen()
            Lista_Inc_Para()
            Lista_Inc_Negocio()
            cmbIncPara.SelectedValue = _pIncPara
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() = True Then
                pcxEspera.Visible = True

                btnExportar.Enabled = False
                tsbGenerarReporte.Enabled = False
                tsbCancelar.Enabled = False

                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Try
            pReporteConsultaIncidenciaPorFecha()
        Catch ex As Exception
            pcxEspera.Visible = False
            btnExportar.Enabled = True
            tsbGenerarReporte.Enabled = True
            tsbCancelar.Enabled = True
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "METODOS"

    Function ListaCodigoAreas() As String

        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbArea.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbArea.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Function ListaCodigoPlantas() As String

        Dim strCadDocumentos As String = ""
        Dim cont As Int32 = 0
        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbPlanta.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbPlanta.Properties.Items.Item(i).Value & ","
                cont = cont + 1
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        If cont < cmbArea.Properties.Items.Count Then
            Return strCadDocumentos
        Else
            Return "-1"
        End If

    End Function

    Private Sub pReporteConsultaIncidenciaPorFecha()
        Dim obeIncidencias As New beIncidencias
        Dim obrIncidencias As New brIncidencias
        With obeIncidencias
            .PSCCMPN = _Compania
            .PSCARINC = ListaCodigoAreas()
            .PSCPLNDV_DES = cmbPlanta.EditValue.ToString.Trim.Replace(" ", "")

            If txtCliente.Resultado Is Nothing Then
                .PSCCLNT1 = "-1"
            Else
                Dim Est As String = txtCliente.Resultado.GetType.ToString
                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCCLNT1 = CType(txtCliente.Resultado, beCliente).Codigo
                Else
                    .PSCCLNT1 = ListaCodigoClientes()
                End If
            End If
            If txtTipoAlmacen.Resultado IsNot Nothing Then
                .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM.ToString.Trim
            End If
            If txtAlmacen.Resultado IsNot Nothing Then
                .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC.ToString.Trim
            End If
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            .PNCTPINC = cmbIncPara.SelectedValue
            .PSCRGVTA = cmbNegocio.EditValue.ToString.Trim.Replace(" ", "")
            .PSSORINC = cmbReportado.EditValue.ToString.Trim.Replace(" ", "")

        End With
        Dim dsReporte As New DataSet
        DSGENERAL = New DataSet

        dsReporte = obrIncidencias.ConsultaIncidenciaPorFecha(obeIncidencias)
        DSGENERAL = Nothing

        If dsReporte.Tables(0).Rows.Count > 0 Then

            Dim dt1 As DataTable = dsReporte.Tables(0)
            Dim dt2 As DataTable = dsReporte.Tables(1)

            Dim dv1 As New DataView(dt1)
            dv1.Sort = "TDARINC ASC"
            dt1 = dv1.ToTable

            Dim dv2 As New DataView(dt2)
            dv2.Sort = "TINCSI ASC"
            dt2 = dv2.ToTable

            Dim dsReporteOrdenado As New DataSet

            dsReporteOrdenado.Tables.Add(dt1.Copy)
            dsReporteOrdenado.Tables.Add(dt2.Copy)

            DSGENERAL = dsReporteOrdenado

        End If

    End Sub

    Function ListaDescripcionAreas() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbArea.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbArea.Properties.Items.Item(i).Description & "-"
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    'Private Sub Cargar_Divisiones()
    '    Dim objDAL As New DAO.UbicacionPlanta.Division.daoDivision
    '    Dim dt As DataTable = Nothing
    '    dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, _Compania)
    '    cmbArea.Properties.DataSource = dt
    '    cmbArea.Properties.ValueMember = "CDVSN"
    '    cmbArea.Properties.DisplayMember = "TCMPDV"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    cmbArea.EditValue = _pDivision
    '    cmbArea.RefreshEditValue()
    'End Sub

    Private Sub Cargar_Areas()

        Dim dt As DataTable = Nothing
        Dim objBLL As New brIncidencias
        dt = objBLL.Lista_Areas

        cmbArea.Properties.DataSource = dt
        cmbArea.Properties.Tag = dt.Copy
        cmbArea.Properties.ValueMember = "CARINC"
        cmbArea.Properties.DisplayMember = "TDARINC"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbArea.EditValue = _pArea
        cmbArea.RefreshEditValue()

    End Sub


    Private Sub Cargar_Reportado()

        Dim objBLL As New brIncidencias
        Dim dtReportado_data As New DataTable
        dtReportado_data = objBLL.Lista_Nivel_y_Reportado().Tables(1)

        cmbReportado.Properties.DataSource = dtReportado_data
        cmbReportado.Properties.ValueMember = "SORINC"
        cmbReportado.Properties.DisplayMember = "DESCRIPCION"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbReportado.EditValue = _pArea
        cmbReportado.RefreshEditValue()

    End Sub

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias

        cmbIncPara.DataSource = objBLL.Lista_Inc_Para
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 1

    End Sub


    Sub Lista_Inc_Negocio()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtNegocio As New DataTable
        Dim dr As DataRow

        objBE.PSCCMPN = _Compania

        cmbNegocio.Properties.DataSource = objBLL.Lista_Inc_Negocio(objBE)
        cmbNegocio.Properties.DisplayMember = "TCRVTA"
        cmbNegocio.Properties.ValueMember = "CRGVTA"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbNegocio.EditValue = "0"
        cmbNegocio.RefreshEditValue()

    End Sub

    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""
        Dim ListaS As New List(Of String)
        ListaS = CType(txtCliente.Resultado, List(Of String))
        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub CargaTipoAlmacen()
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
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub


    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub Cargar_Clientes1()
        'Dim obrcliente As New RANSA.DAO.Cliente.cCliente
        'Dim obeCliente As New RANSA.TYPEDEF.Cliente.TD_Qry_Cliente_L01
        Dim obrcliente As New Cliente.cCliente
        Dim obeCliente As New Cliente.TD_Qry_Cliente_L01
        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'cmbCliente.Properties.SelectAllItemCaption = "(Seleccionar todo)"
        With obeCliente
            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = _pUsuario
            .pCCMPN_CodigoCompania = "EZ"
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

        If Lista Is Nothing Then
            Me.txtCliente.DataSource = Nothing
        Else
            Me.txtCliente.DataSource = Lista
        End If

        Me.txtCliente.ListColumnas = oListColum
        Me.txtCliente.Cargas()
        Me.txtCliente.DispleyMember = "Descripcion"
        Me.txtCliente.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbArea.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar una área. " & vbNewLine
        End If

        If cmbPlanta.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar una planta. " & vbNewLine
        End If

        If cmbReportado.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccione Reportado por: . " & vbNewLine
        End If

        If cmbNegocio.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar un negocio. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

#End Region

    Private Sub txtTipoAlmacen_CambioDeTexto_1(ByVal objData As System.Object) Handles txtTipoAlmacen.CambioDeTexto
        Try
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
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(2, oColumnas)
            Dim obrAlmacen As New brAlmacen
            'Se esta cargando la planta por defecto 1 (CAllao)
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

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        If fblnValidaInformacion() = True Then
            Control.CheckForIllegalCrossThreadCalls = False
            pcxEspera.Visible = True
            btnExportar.Enabled = False
            tsbGenerarReporte.Enabled = False
            tsbCancelar.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If
   
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted

        Dim objVisor As New Ransa.Controls.Incidencia.frmVisorIncidenciasPorFecha

        If DSGENERAL IsNot Nothing AndAlso DSGENERAL.Tables(0).Rows.Count > 0 Then

            objVisor.dsReporte = DSGENERAL
            objVisor.Areas = ListaDescripcionAreas()
            objVisor.FechaInicial = dteFechaInicial.Value.Date
            objVisor.FechaFinal = dteFechaFinal.Value.Date
            objVisor.IncPara = cmbIncPara.Text
            pcxEspera.Visible = False
            btnExportar.Enabled = True
            tsbGenerarReporte.Enabled = True
            tsbCancelar.Enabled = True
            objVisor.ShowDialog()
        Else
            pcxEspera.Visible = False
            btnExportar.Enabled = True
            tsbGenerarReporte.Enabled = True
            tsbCancelar.Enabled = True
            MessageBox.Show("No hay información a mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Exportar()
        Catch ex As Exception
            pcxEspera.Visible = False
            btnExportar.Enabled = True
            tsbGenerarReporte.Enabled = True
            tsbCancelar.Enabled = True
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Exportar()

        Dim obeIncidencias As New beIncidencias
        Dim obrIncidencias As New brIncidencias
        With obeIncidencias
            .PSCCMPN = _Compania
            .PSCARINC = ListaCodigoAreas()
            .PSCPLNDV_DES = cmbPlanta.EditValue.ToString.Trim.Replace(" ", "")
            If txtCliente.Resultado Is Nothing Then
                .PSCCLNT1 = "-1"
            Else
                Dim Est As String = txtCliente.Resultado.GetType.ToString
                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCCLNT1 = CType(txtCliente.Resultado, beCliente).Codigo
                Else
                    .PSCCLNT1 = ListaCodigoClientes()
                End If
            End If
            If txtTipoAlmacen.Resultado IsNot Nothing Then
                .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM.ToString.Trim
            End If
            If txtAlmacen.Resultado IsNot Nothing Then
                .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC.ToString.Trim
            End If
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            .PSCRGVTA = cmbNegocio.EditValue.ToString.Trim.Replace(" ", "")
            .PNCTPINC = cmbIncPara.SelectedValue
            .PSSORINC = cmbReportado.EditValue.ToString.Trim.Replace(" ", "")

        End With
        Dim dsReporte As New DataSet
        DTGENERAL = New DataTable
        dsReporte = obrIncidencias.ConsultaIncidenciaPorFecha(obeIncidencias)
        DTGENERAL = Nothing
        If dsReporte.Tables(0).Rows.Count > 0 Then

            Dim dt1 As DataTable = dsReporte.Tables(0)
            Dim dt2 As DataTable = dsReporte.Tables(1)

            Dim dv1 As New DataView(dt1)
            dv1.Sort = "TDARINC ASC"
            dt1 = dv1.ToTable

            Dim dv2 As New DataView(dt2)
            dv2.Sort = "TINCSI ASC"
            dt2 = dv2.ToTable

            Dim dsReporteOrdenado As New DataSet

            dsReporteOrdenado.Tables.Add(dt1.Copy)
            dsReporteOrdenado.Tables.Add(dt2.Copy)

            '--------------------------------------- EXPORTAR EXCEL --------------------------------------

            Dim NPOI_SC As New HelpClass_NPOI_SC

            Dim dtExcel As New DataTable
            Dim row As DataRow
            dtExcel.Columns.Add("TDARINC").Caption = NPOI_SC.FormatDato("Área", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TPLNTA").Caption = NPOI_SC.FormatDato("Planta", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("NINCSI").Caption = NPOI_SC.FormatDato("Nro. Inc", NPOI_SC.keyDatoNumero)

            dtExcel.Columns.Add("FRGTRO").Caption = NPOI_SC.FormatDato("Fecha", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRGTRO").Caption = NPOI_SC.FormatDato("Hora", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMPCL").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TINCSI").Caption = NPOI_SC.FormatDato("Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QAINSM", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("CUNDCN").Caption = NPOI_SC.FormatDato("Unidad Medida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("ICSTOS", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Costo", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("CDMNDA").Caption = NPOI_SC.FormatDato("Moneda", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TRDCCL").Caption = NPOI_SC.FormatDato("Doc. Referencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TINCDT").Caption = NPOI_SC.FormatDato("Descripción incidencia", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("NIVEL").Caption = NPOI_SC.FormatDato("Nivel", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("REPORTADO").Caption = NPOI_SC.FormatDato("Reportado por", NPOI_SC.keyDatoTexto)

            'dtExcel.Columns.Add("CTPALM").Caption = NPOI_SC.FormatDato("Cod. Tipo almacén", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TALMC").Caption = NPOI_SC.FormatDato("Tipo almacén", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("CALMC").Caption = NPOI_SC.FormatDato("Cod. Almacén", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMPAL").Caption = NPOI_SC.FormatDato("Almacén", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("CZNALM").Caption = NPOI_SC.FormatDato("Cod. Zona", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMZNA").Caption = NPOI_SC.FormatDato("Zona", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("ADJUNTO").Caption = NPOI_SC.FormatDato("Adj", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CUSCRT").Caption = NPOI_SC.FormatDato("Usuario creador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CULUSA").Caption = NPOI_SC.FormatDato("Usuario actualizador", NPOI_SC.keyDatoTexto)

            For Each dr As DataRow In dsReporteOrdenado.Tables(0).Rows
                row = dtExcel.NewRow
                For Each cl As DataColumn In dtExcel.Columns
                    row(cl.ColumnName) = dr(cl.ColumnName)
                Next
                dtExcel.Rows.Add(row)
            Next

            DTGENERAL = dtExcel.Copy
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC

            If DTGENERAL IsNot Nothing AndAlso DTGENERAL.Rows.Count > 0 Then

                DTGENERAL.TableName = "INCIDENCIAS"

                Dim dv3 As New DataView(DTGENERAL.Copy)
                dv3.Sort = "TDARINC ASC"
                DTGENERAL = dv3.ToTable

                ListaDatatable = New List(Of DataTable)
                ListaDatatable.Add(DTGENERAL)

                ListaTitulos = New List(Of String)
                ListaTitulos.Add("INCIDENCIAS POR FECHA")

                Dim oLisFiltro As New List(Of SortedList)
                Dim F As New SortedList
                If ListaCodigoAreas.Trim.Length > 5 Then
                    F.Add(0, "ÁREA:|" & " VARIOS")
                Else
                    F.Add(0, "ÁREA:|" & ListaDescripcionAreas())
                End If

                If cmbPlanta.ToString.Trim.Length > 5 Then
                    F.Add(1, "PLANTA:|" & " VARIOS")
                Else
                    F.Add(1, "PLANTA:|" & cmbPlanta.Text)
                End If
                F.Add(2, "INC. PARA:|" & cmbIncPara.Text)

                F.Add(3, "FECHA:|" & dteFechaInicial.Value.Date & " - " & dteFechaFinal.Value.Date)
                oLisFiltro.Add(F)

                Dim ListColumnNFilas As New List(Of String)
                ListColumnNFilas.Add("TINCDT")
                pcxEspera.Visible = False
                btnExportar.Enabled = True
                tsbGenerarReporte.Enabled = True
                tsbCancelar.Enabled = True
                NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, 0)

            Else
                MessageBox.Show("No hay información a mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pcxEspera.Visible = False
                btnExportar.Enabled = True
                tsbGenerarReporte.Enabled = True
                tsbCancelar.Enabled = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmbDivision_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.EditValueChanged

        Cargar_Plantas()

    End Sub

    Function Codigo_Division_X_Area(ByVal dt As DataTable, ByVal CCMPN As String, ByVal codigo_area As String) As String
        Dim resultado As String = ""
        Dim dr() As DataRow
        dr = dt.Select("CCMPN = '" & CCMPN & "' AND CARINC = '" & codigo_area & "'")
        If dr.Length > 0 Then
            resultado = ("" & dr(0)("CDVSN")).ToString.Trim
        End If
        Return resultado
    End Function

    Private Sub Cargar_Plantas()

        'Dim objBLL As Negocio.UbicacionPlanta.Planta.brPlanta
        'Dim objBE As New TypeDef.UbicacionPlanta.Planta.bePlanta
        'Dim objLisEntidad As List(Of TypeDef.UbicacionPlanta.Planta.bePlanta)
        Dim objBLL As UbicacionPlanta.Planta.brPlanta
        Dim objBE As New UbicacionPlanta.Planta.bePlanta
        Dim objLisEntidad As List(Of UbicacionPlanta.Planta.bePlanta)
        Dim Codigo_Division As String = ""

        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add("CPLNDV")
        dt.Columns.Add("TPLNTA")

        cmbPlanta.Properties.DataSource = Nothing
        cmbPlanta.EditValue = 0

        If cmbArea.Properties.Items.Count = 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbArea.Properties.Items.Item(i).CheckState = 1 Then

                'objLisEntidad = New List(Of TypeDef.UbicacionPlanta.Planta.bePlanta)
                'objBLL = New Negocio.UbicacionPlanta.Planta.brPlanta
                objLisEntidad = New List(Of UbicacionPlanta.Planta.bePlanta)
                objBLL = New UbicacionPlanta.Planta.brPlanta

                Codigo_Division = Codigo_Division_X_Area(cmbArea.Properties.Tag, _Compania, cmbArea.Properties.Items.Item(i).Value.ToString.Trim)

                objBLL.Crea_Lista(_pUsuario)
                objLisEntidad = objBLL.Lista_Planta_X_Usuario(_Compania, Codigo_Division)

                For Each objBE In objLisEntidad
                    dr = dt.NewRow

                    Dim dr1 As DataRow()
                    dr1 = dt.Select("CPLNDV = '" & objBE.CPLNDV_CodigoPlanta.ToString.Trim & "'")

                    If dr1.Length = 0 Then
                        dr("CPLNDV") = objBE.CPLNDV_CodigoPlanta
                        dr("TPLNTA") = objBE.TPLNTA_DescripcionPlanta
                        dt.Rows.Add(dr)
                    End If

                Next

            End If
        Next

        cmbPlanta.Properties.DataSource = dt
        cmbPlanta.Properties.ValueMember = "CPLNDV"
        cmbPlanta.Properties.DisplayMember = "TPLNTA"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbPlanta.CheckAll()

    End Sub


End Class

