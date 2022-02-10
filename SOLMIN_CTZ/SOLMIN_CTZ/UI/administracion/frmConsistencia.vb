Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmConsistencia
    Private oCliente As SOLMIN_CTZ.NEGOCIO.clsCliente
    Private oDivision As clsDivision
    Private oCompania As clsCompania
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oPlanta As clsPlanta
    Private oServicioAtendido As Servicio_Atendido
    Private oServicioAtendidoNeg As clsServicioAtendido
    Private bolBuscar As Boolean
    Private bolFacturar As Boolean
    Private dblConsistencia As Double
    Private oDtConsistencia As DataTable

    Private Sub frmConsistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oServicioAtendido = New SOLMIN_CTZ.Entidades.Servicio_Atendido
        oServicioAtendidoNeg = New SOLMIN_CTZ.NEGOCIO.clsServicioAtendido
        bolBuscar = False
        Cargar_Compania()
        Cargar_Cliente_Usuario()
        Cargar_Moneda()
        bolBuscar = True
        bolFacturar = False
        dblConsistencia = 0
        Crear_Grilla_Consistencias()
        Crear_Grilla_ConsistenciaFactura()
        Me.dtpInicio.Value = Now.AddMonths(-1)
        Me.dtpFin.Value = Now

    End Sub

#Region "Crear Grilla Consistencias"

    Private Sub Crear_Grilla_Consistencias()
        Dim oDcCb As DataGridViewCheckBoxColumn
        Dim oDcTx As DataGridViewColumn

        oDcCb = New DataGridViewCheckBoxColumn
        oDcCb.Name = "VALIDAR"
        oDcCb.HeaderText = " "
        oDcCb.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcCb.SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dtgConsistencia.Columns.Add(oDcCb)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CLIENTE"
        oDcTx.HeaderText = "Cliente"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.Width = 150
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CDVSN"
        oDcTx.HeaderText = "Área"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOPRCN"
        oDcTx.HeaderText = "N° Operación"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicios"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECINI"
        oDcTx.HeaderText = "Fecha Inicio"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECFIN"
        oDcTx.HeaderText = "Fecha Fín"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TMNDA"
        oDcTx.HeaderText = "Moneda"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "IVLSRV"
        oDcTx.HeaderText = "Tarifa Unitaria"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QATNAN"
        oDcTx.HeaderText = "Cantidad Atendida"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOTAL"
        oDcTx.HeaderText = "Total"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CCLNT"
        oDcTx.HeaderText = "CCLNT"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgConsistencia.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRTFSV"
        oDcTx.HeaderText = "NRTFSV"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgConsistencia.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Crear Grilla Consistencia Factura"

    Private Sub Crear_Grilla_ConsistenciaFactura()
        Dim oDcCb As DataGridViewCheckBoxColumn
        Dim oDcTx As DataGridViewColumn

        oDcCb = New DataGridViewCheckBoxColumn
        oDcCb.Name = "VALIDAR"
        oDcCb.HeaderText = " "
        oDcCb.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcCb.SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dtgConsistenciaFactura.Columns.Add(oDcCb)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CLIENTE"
        oDcTx.HeaderText = "Cliente"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CDVSN"
        oDcTx.HeaderText = "Área"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicios"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECINI"
        oDcTx.HeaderText = "Fecha Inicio"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECFIN"
        oDcTx.HeaderText = "Fecha Fín"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TMNDA"
        oDcTx.HeaderText = "Moneda"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "IVLSRV"
        oDcTx.HeaderText = "Tarifa Unitaria"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QATNAN"
        oDcTx.HeaderText = "Cantidad Atendida"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOTAL"
        oDcTx.HeaderText = "Total"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CCLNT"
        oDcTx.HeaderText = "CCLNT"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOPRCN"
        oDcTx.HeaderText = "NOPRCN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRTFSV"
        oDcTx.HeaderText = "NRTFSV"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgConsistenciaFactura.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Filtros Cabecera"""

    Private Sub Cargar_Moneda()
        oMoneda.Crea_Moneda()
        cmbMoneda.DataSource = oMoneda.Lista_Moneda(1)
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DisplayMember = "TMNDA"
        cmbMoneda.SelectedValue = 100
    End Sub

    Private Sub Cargar_Compania()
        bolBuscar = False
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        bolBuscar = True
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedValue = "EZ"
        'cmbCompania.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Try
            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                cmbPlanta.DataSource = oPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                If cmbPlanta.FindString("1") = 0 Then
                    cmbPlanta.SelectedValue = 1
                End If
                cmbPlanta.DisplayMember = "TPLNTA"
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cliente_Usuario()  
        'UcCliente.pUsuario = ConfigurationWizard.UserName
        UcCliente.CCMPN = Me.cmbCompania.SelectedValue
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
        End If
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub Listar_Consistencia()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim dblAcumulado As Double

        dblAcumulado = 0
        oServicioAtendido.CCLNT = UcCliente.pCodigo.ToString 'cmbCliente.SelectedValue
        oServicioAtendido.CCMPN = cmbCompania.SelectedValue
        oServicioAtendido.CDVSN = cmbDivision.SelectedValue
        oServicioAtendido.CMNDA1 = cmbMoneda.SelectedValue
        oServicioAtendido.CPLNDV = cmbPlanta.SelectedValue
        oServicioAtendido.FECINI = Format(CType(Me.dtpInicio.Text, Date), "yyyyMMdd")
        oServicioAtendido.FECFIN = Format(CType(Me.dtpFin.Text, Date), "yyyyMMdd")
        oDt = oServicioAtendidoNeg.Lista_Servicio_Atendido(oServicioAtendido)
        If Not oDtConsistencia Is Nothing Then oDtConsistencia.Rows.Clear()
        oDtConsistencia = oDt.Copy
        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgConsistencia)
                    oDrVw.Cells(0).Value = 0
                    oDrVw.Cells(1).Value = .Rows(intCont).Item("TCMPCL").ToString.Trim
                    oDrVw.Cells(2).Value = .Rows(intCont).Item("TCMPDV").ToString.Trim
                    oDrVw.Cells(3).Value = .Rows(intCont).Item("NOPRCN").ToString.Trim
                    oDrVw.Cells(4).Value = .Rows(intCont).Item("SERVICIO").ToString.Trim
                    oDrVw.Cells(5).Value = .Rows(intCont).Item("FECINI").ToString.Trim
                    oDrVw.Cells(6).Value = .Rows(intCont).Item("FECFIN").ToString.Trim
                    oDrVw.Cells(7).Value = .Rows(intCont).Item("TMNDA").ToString.Trim
                    oDrVw.Cells(8).Value = Format(CType(.Rows(intCont).Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")
                    oDrVw.Cells(9).Value = Format(CType(.Rows(intCont).Item("QATNAN").ToString.Trim, Double), "###,###,###,##0")
                    oDrVw.Cells(10).Value = Format(CType(.Rows(intCont).Item("TOTAL").ToString.Trim, Double), "###,###,###,##0.000")
                    oDrVw.Cells(11).Value = .Rows(intCont).Item("CCLNT").ToString.Trim
                    oDrVw.Cells(12).Value = .Rows(intCont).Item("NRTFSV").ToString.Trim
                    dblAcumulado = CType(.Rows(intCont).Item("TOTAL").ToString.Trim, Double) + dblAcumulado
                    Me.dtgConsistencia.Rows.Add(oDrVw)
                Next intCont
            End If
        End With
        txtMonto.Text = Format(CType(dblAcumulado, Double), "###,###,###,##0.000")
        txtRegistro.Text = dtgConsistencia.Rows.Count & " Registros "
    End Sub

#End Region

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dtgConsistencia.Rows.Clear()
        Listar_Consistencia()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim strTitulo As String
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'strTitulo = cmbDivision.Text.ToString.Trim & " - " + UcCliente.pRazonSocial.ToString.Trim + " - PLANTA " & cmbPlanta.Text.Trim + " EN " + cmbMoneda.Text.Trim
        'pExportarExcel("REPORTE DE CONSISTENCIA", "REPORTE DE CONSISTENCIA", strTitulo, Me.dtgConsistencia.Rows, Me.dtgConsistencia)
        'Me.Cursor = System.Windows.Forms.Cursors.Default
        'If oDtConsistencia Is Nothing Then
        '    Exit Sub
        'End If
        'Dim mpGenerarXLS As New ExportarExcel
        'Dim strReporteseleccionado As String = "009"

        'Dim dtNuevo As New DataTable
        'dtNuevo = oDtConsistencia.Clone
        ''Eliminamos Columnas que no se usaran
        'dtNuevo.Columns.Remove("TCMPDV")
        'dtNuevo.Columns.Remove("TPLNTA")
        'dtNuevo.Columns.Remove("CCLNT")
        ''Cambiamos de tipo de dato a las Fechas
        'dtNuevo.Columns(0).DataType = GetType(String)
        'dtNuevo.Columns(1).DataType = GetType(String)
        'dtNuevo.Columns(2).DataType = GetType(String)
        'dtNuevo.Columns(3).DataType = GetType(String)
        'dtNuevo.Columns(4).DataType = GetType(String)
        'dtNuevo.Columns(5).DataType = GetType(String)
        'dtNuevo.Columns(6).DataType = GetType(String)
        'dtNuevo.Columns(7).DataType = GetType(String)
        'dtNuevo.Columns(8).DataType = GetType(String)
        'dtNuevo.Columns(9).DataType = GetType(String)
        ''Agregamos datos Filtro
        'Dim filaNueva As DataRow
        ''----------
        'filaNueva = dtNuevo.NewRow()
        'filaNueva(0) = "Compania:"
        'filaNueva(1) = cmbCompania.Text
        'dtNuevo.Rows.Add(filaNueva)
        ''-----------
        'filaNueva = dtNuevo.NewRow()
        'filaNueva(0) = "Division:"
        'filaNueva(1) = cmbDivision.Text
        'dtNuevo.Rows.Add(filaNueva)
        ''------------
        'filaNueva = dtNuevo.NewRow()
        'filaNueva(0) = "Planta:"
        'filaNueva(1) = cmbPlanta.Text
        'dtNuevo.Rows.Add(filaNueva)

        'filaNueva = dtNuevo.NewRow()
        'filaNueva(0) = "CLIENTE"
        'filaNueva(1) = "OPERACION"
        'filaNueva(2) = "MONEDA"
        'filaNueva(3) = "NRO. TARIFA"
        'filaNueva(4) = "SERVICIO"
        'filaNueva(5) = "FECHA INICIO"
        'filaNueva(6) = "FECHA FIN"
        'filaNueva(7) = "MONTO"
        'filaNueva(8) = "CANTIDAD"
        'filaNueva(9) = "TOTAL"
        'dtNuevo.Rows.Add(filaNueva)

        'For i As Integer = 0 To oDtConsistencia.Rows.Count - 1
        '    If Not (i > (oDtConsistencia.Rows.Count - 1)) Then
        '        dtNuevo.ImportRow(oDtConsistencia.Rows(i))
        '    End If
        'Next

        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'If dtNuevo.Rows.Count > 1 Then
        '    Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtNuevo)
        'Else
        '    HelpClass.MsgBox("No hay Registros para exportar")
        'End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        If oDtConsistencia Is Nothing Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        Dim filtro As New Hashtable
        'filtro.Add("División : ", cmbDivision.Text)
        'filtro.Add("Cliente : ", UcCliente.pRazonSocial)
        filtro.Add("Compañia : ", cmbCompania.Text)
        'filtro.Add("Planta : ", cmbPlanta.Text)
        odtReporte = oDtConsistencia.Copy
        odtReporte.Columns.Remove("CCLNT")
        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns("TCMPDV").ColumnName = "DIVISION" 'COMPAÑIA
        odtReporte.Columns("TPLNTA").ColumnName = "PLANTA"
        odtReporte.Columns("TCMPCL").ColumnName = "CLIENTE"
        odtReporte.Columns("NOPRCN").ColumnName = "OPERACION"
        odtReporte.Columns("TMNDA").ColumnName = "MONEDA"
        'odtReporte.Columns("CCLNT").ColumnName = "COD. CLIENTE" 'NRO TARIFA
        odtReporte.Columns("NRTFSV").ColumnName = "NRO TARIFA"
        odtReporte.Columns("SERVICIO").ColumnName = "SERVICIO"
        odtReporte.Columns("FECINI").ColumnName = "FECHA INICIO"
        odtReporte.Columns("FECFIN").ColumnName = "FECHA FIN"
        odtReporte.Columns("IVLSRV").ColumnName = "MONTO"
        odtReporte.Columns("QATNAN").ColumnName = "CANTIDAD"
        odtReporte.Columns("TOTAL").ColumnName = "TOTAL"
        ListDt.Add(odtReporte)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "REPORTE DE CONSISTENCIA", filtro)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub pExportarExcel(ByVal pstrTitulo As String, ByVal plinea1 As String, ByVal plinea2 As String, ByVal drvRows As DataGridViewRowCollection, ByVal pdtgDatos As DataGridView)
        If pdtgDatos.Rows.Count > 0 Then
            Dim objListColumns As New List(Of String)
            Dim objListColumnsHide As New List(Of Boolean)
            Try
                With pdtgDatos
                    For i As Int16 = 0 To .Columns.Count - 1
                        If .Columns(i).HeaderText <> "" Then
                            objListColumns.Add(.Columns(i).HeaderText)
                            objListColumnsHide.Add(.Columns(i).Visible)
                        End If
                    Next i
                End With
                ' Exportar
                Call pExportar(pstrTitulo, plinea1, plinea2, drvRows, objListColumns, objListColumnsHide)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                objListColumns = Nothing
                objListColumnsHide = Nothing
            End Try
        End If
    End Sub

    Public Sub pExportar(ByVal strTitulo As String, ByVal linea1_ As String, ByVal plinea2 As String, ByVal drvRows As DataGridViewRowCollection, _
                       ByVal objListColumns As List(Of String), ByVal objListColumnsHide As List(Of Boolean))
        Dim oExcel As Object
        Dim oBook As Object
        Dim oBooks As Object
        Dim oWorksheet As Object
        Dim objType As Type
        Dim intHeaders As Int32
        Dim intHeaders1 As Int32
        Dim intRow As Int32
        Dim i As Int32
        Dim j As Int32
        Dim intContador As Int16
        Try
            ' Validamos que la coleccion de filas no sea nothing
            If Not drvRows Is Nothing Then
                ' Iniciamos Excel y abrimos un libro
                objType = Type.GetTypeFromProgID("Excel.Application")

                oExcel = Activator.CreateInstance(objType)
                oExcel.Visible = False
                oBooks = oExcel.Workbooks
                oBook = oBooks.Open(Application.StartupPath & "\ExportToXLS\SOLMIN_Contrato.xlt")

                ' Asignamos el objeto Sheet
                oWorksheet = oBook.ActiveSheet

                ' Contamos las columnas q son visibles
                For i = 1 To objListColumnsHide.Count - 1
                    If objListColumnsHide(i) Then
                        intHeaders += 1
                    Else
                        intHeaders1 += 1
                    End If
                Next
                ' Ejecutamos macro, enviamos las columnas y valores
                oBook.MuestraGrid(strTitulo, linea1_, plinea2, intHeaders, drvRows.Count)
                ' Agregar las columnas
                intRow = 5
                For i = 1 To objListColumnsHide.Count - 1 'intHeaders - 1
                    If objListColumnsHide(i) Then
                        oWorksheet.Cells(5, intContador + 3).Value = objListColumns(i) 'mdtTablaMaster.Columns(i).ColumnName
                        intContador += 1
                    End If
                Next
                For i = 1 To objListColumnsHide.Count - 1
                    oWorksheet.columns(i + 3).ColumnWidth = 15
                Next i
                intRow = 6
                For i = 0 To drvRows.Count - 1
                    intContador = 0

                    ' Cargar la data
                    For j = 1 To objListColumnsHide.Count - 1 'intHeaders - 1
                        If objListColumnsHide(j) Then
                            If Not drvRows.Item(i).Cells(j).Value = Nothing Then

                                Select Case Me.dtgConsistencia.Columns(j).Name.ToString.Trim
                                    Case "CLIENTE", "CDVSN", "SERVICIO"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4131 'xlLeft
                                        intContador += 1
                                    Case "FECINI", "FECFIN", "TMNDA"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4108 'xlCenter 
                                        intContador += 1
                                    Case "IVLSRV", "QATNAN", "TOTAL"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4152 'xlRight
                                        intContador += 1
                                End Select
                            Else
                                oWorksheet.Cells(intRow + i, intContador + 3).Value = ""
                                intContador += 1
                            End If
                        End If
                    Next j
                Next i
            End If
            oExcel.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Eliminamos los objetos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
            oBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
            oBooks = Nothing
            'oExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
            oExcel = Nothing
            oExcel = Nothing
            oBook = Nothing
            oBooks = Nothing
            oWorksheet = Nothing
        End Try
    End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        dtgConsistenciaFactura.Focus()
        txtRegistro.Focus()
        FiltrarDatos()
    End Sub

    Private Sub FiltrarDatos()
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim dblAcumulado As Double

        If dtgConsistenciaFactura.RowCount > 0 Then
            dtgConsistenciaFactura.Rows.Clear()
        End If
        For intCont = 0 To dtgConsistencia.RowCount - 1
            If dtgConsistencia.Rows(intCont).Cells(0).Value = True Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgConsistenciaFactura)
                oDrVw.Cells(0).Value = 1
                oDrVw.Cells(1).Value = dtgConsistencia.Rows(intCont).Cells("CLIENTE").Value
                oDrVw.Cells(2).Value = dtgConsistencia.Rows(intCont).Cells("CDVSN").Value
                oDrVw.Cells(3).Value = dtgConsistencia.Rows(intCont).Cells("SERVICIO").Value
                oDrVw.Cells(4).Value = dtgConsistencia.Rows(intCont).Cells("FECINI").Value
                oDrVw.Cells(5).Value = dtgConsistencia.Rows(intCont).Cells("FECFIN").Value
                oDrVw.Cells(6).Value = dtgConsistencia.Rows(intCont).Cells("TMNDA").Value
                oDrVw.Cells(7).Value = dtgConsistencia.Rows(intCont).Cells("IVLSRV").Value
                oDrVw.Cells(8).Value = dtgConsistencia.Rows(intCont).Cells("QATNAN").Value
                oDrVw.Cells(9).Value = dtgConsistencia.Rows(intCont).Cells("TOTAL").Value
                oDrVw.Cells(10).Value = dtgConsistencia.Rows(intCont).Cells("CCLNT").Value
                oDrVw.Cells(11).Value = dtgConsistencia.Rows(intCont).Cells("NOPRCN").Value
                oDrVw.Cells(12).Value = dtgConsistencia.Rows(intCont).Cells("NRTFSV").Value
                dblAcumulado = Convert.ToDouble(dtgConsistencia.Rows(intCont).Cells("TOTAL").Value.ToString.Trim) + dblAcumulado
                Me.dtgConsistenciaFactura.Rows.Add(oDrVw)
            End If
        Next intCont
        If dtgConsistenciaFactura.RowCount = 0 Then
            HelpClass.MsgBox("No hay Registros para Consistenciar")
        Else
            HGDetalleFacturar.Collapsed = False
            HGFiltro.Visible = False
            HGTotales.Collapsed = False
            HGDetalles.Visible = False

            HGDetalleFacturar.Visible = True
            HGFiltro.Collapsed = True
            HGTotales.Visible = True
            HGDetalles.Collapsed = True
            txtMonto.Text = Format(CType(dblAcumulado, Double), "###,###,###,##0.000")
            txtRegistro.Text = dtgConsistenciaFactura.RowCount & " Registros "
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim dblAcumulado As Double
        Dim intCont As Integer

        HGDetalleFacturar.Collapsed = True
        HGDetalleFacturar.Visible = False
        HGFiltro.Visible = True
        HGDetalles.Visible = True
        HGTotales.Visible = True
        HGFiltro.Collapsed = False
        HGDetalles.Collapsed = False
        HGTotales.Collapsed = False
        For intCont = 0 To dtgConsistencia.RowCount - 1
            dblAcumulado = dtgConsistencia.Item(9, intCont).Value.ToString.Trim + dblAcumulado
        Next intCont
        txtMonto.Text = Format(CType(dblAcumulado, Double), "###,###,###,##0.000")
        txtRegistro.Text = dtgConsistencia.RowCount & " Registros "
    End Sub


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim strTitulo As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        strTitulo = cmbDivision.Text.ToString.Trim & " - " + UcCliente.pRazonSocial.ToString.Trim + " - PLANTA " & cmbPlanta.Text.Trim + " EN " + cmbMoneda.Text.Trim
        pExportarExcel("REPORTE DE CONSISTENCIA PARA FACTURAR", "REPORTE DE CONSISTENCIA PARA FACTURAR", strTitulo, Me.dtgConsistenciaFactura.Rows, Me.dtgConsistenciaFactura)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.txtRegistro.Focus()
        ActualizarDatos()
        Me.dtgConsistenciaFactura.Focus()
    End Sub

    Private Sub ActualizarDatos()
        Dim intCont As Integer
        Dim dblAcumulado As Double = 0

        For intCont = dtgConsistenciaFactura.RowCount - 1 To 0 Step -1
            If dtgConsistenciaFactura.Rows(intCont).Cells("VALIDAR").Value = 0 Then
                dtgConsistenciaFactura.Rows.RemoveAt(intCont)
            End If
        Next intCont
        For intCont = 0 To dtgConsistenciaFactura.RowCount - 1
            dblAcumulado = dtgConsistenciaFactura.Rows(intCont).Cells("TOTAL").Value.ToString.Trim + dblAcumulado
        Next
        txtMonto.Text = Format(CType(dblAcumulado, Double), "###,###,###,##0.000")
        txtRegistro.Text = dtgConsistenciaFactura.RowCount & " Registros "
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Procesar_Consistencia()
        Actualizar_Informacion_Visualizada()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Procesar_Consistencia()
        Dim dblCodigo As Double
        Dim intCont As Integer
        Dim intProcesado As Integer = 0
        Try
            dblCodigo = oServicioAtendidoNeg.ObtenerCodigoConsistencia.Rows(0).Item("NULCTR")
            Me.txtRegistro.Focus()
            For intCont = 0 To dtgConsistenciaFactura.RowCount - 1
                If Convert.ToBoolean(dtgConsistenciaFactura.Rows(intCont).Cells("VALIDAR").Value) = True Then
                    oServicioAtendido.CCLNT = dtgConsistenciaFactura.Rows(intCont).Cells("CCLNT").Value
                    oServicioAtendido.NOPRCN = dtgConsistenciaFactura.Rows(intCont).Cells("NOPRCN").Value
                    oServicioAtendido.NRTFSNV = dtgConsistenciaFactura.Rows(intCont).Cells("NRTFSV").Value
                    oServicioAtendido.NSECFC = dblCodigo
                    oServicioAtendidoNeg.ActualizarServicio_Atendido(oServicioAtendido)
                    intProcesado = 1
                End If
            Next intCont
            If intProcesado = 0 Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                bolFacturar = False
                HelpClass.MsgBox("No hay Registro habilitado para Procesar")
                Return
            End If
            bolFacturar = True
            dblConsistencia = dblCodigo
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            bolFacturar = False
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_Informacion_Visualizada()
        Dim intCont As Integer
        Dim dblAcumulado As Double

        dtgConsistencia.Rows.Clear()
        Listar_Consistencia()
        HelpClass.MsgBox("Se Procesó correctamente")
        HGDetalleFacturar.Collapsed = True
        HGDetalleFacturar.Visible = False
        HGFiltro.Visible = True
        HGDetalles.Visible = True
        HGTotales.Visible = True
        HGFiltro.Collapsed = False
        HGDetalles.Collapsed = False
        HGTotales.Collapsed = False
        For intCont = 0 To dtgConsistencia.RowCount - 1
            dblAcumulado = dtgConsistencia.Rows(intCont).Cells("TOTAL").Value.ToString.Trim + dblAcumulado
        Next intCont
        txtMonto.Text = Format(CType(dblAcumulado, Double), "###,###,###,##0.000")
        txtRegistro.Text = dtgConsistencia.RowCount & " Registros "
    End Sub


    Private Sub dtgConsistencia_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgConsistencia.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.WaitCursor
            dtgConsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dtgConsistencia.RowCount > 0 Then
                If Existe_Check() Then
                    Poner_Check_Todo_OC(False)
                Else
                    Poner_Check_Todo_OC(True)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Function Existe_Check() As Boolean
        Dim intCont As Integer

        For intCont = 0 To dtgConsistencia.Rows.Count - 1
            If dtgConsistencia.Rows(intCont).Cells(0).Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer

        For intCont = 0 To dtgConsistencia.RowCount - 1
            dtgConsistencia.Rows(intCont).Cells("VALIDAR").Value = blnEstado
            dtgConsistencia.EndEdit()
        Next intCont
        dtgConsistencia.Focus()
    End Sub

    Private Sub LlamarVistaPrevia()
        Dim objfrmVFactura As frmVistaFactura
        Dim oDt As DataTable


        oServicioAtendido.NSECFC = dblConsistencia
        oDt = oServicioAtendidoNeg.Lista_Datos_Consistencia(oServicioAtendido)
        dblConsistencia = 0
        Dim ListaFact As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
        oFacturacion.NSECFC = oDt.Rows(0).Item("NSECFC")
        oFacturacion.TCMPDV = oDt.Rows(0).Item("TCMPDV").ToString.Trim
        oFacturacion.PSCDVSN = oDt.Rows(0).Item("CDVSN").ToString.Trim
        oFacturacion.PSCCMPN = oDt.Rows(0).Item("CCMPN").ToString.Trim
        oFacturacion.CCLNFC = oDt.Rows(0).Item("CCLNFC")
        oFacturacion.CPLNDV = oDt.Rows(0).Item("CPLNDV").ToString.Trim
        oFacturacion.CMNDA1 = oDt.Rows(0).Item("CMNDA1").ToString.Trim
        oFacturacion.CCNTCS = oDt.Rows(0).Item("CCNTCS").ToString.Trim
        'objfrmVFactura = New frmVistaFactura(oDt.Rows(0).Item("NSECFC").ToString.Trim, _
        '                                     oDt.Rows(0).Item("TCMPDV").ToString.Trim, _
        '                                     oDt.Rows(0).Item("CDVSN").ToString.Trim, _
        '                                     oDt.Rows(0).Item("CCMPN").ToString.Trim, _
        '                                     oDt.Rows(0).Item("CCLNFC").ToString.Trim, _
        '                                     oDt.Rows(0).Item("CPLNDV").ToString.Trim, _
        '                                     oDt.Rows(0).Item("CMNDA1").ToString.Trim)

        objfrmVFactura = New frmVistaFactura(ListaFact)

        objfrmVFactura.ShowDialog()
    End Sub

    Private Sub btnProcesarFact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcesarFact.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Procesar_Consistencia()
        If bolFacturar Then
            LlamarVistaPrevia()
        End If
        Actualizar_Informacion_Visualizada()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

End Class