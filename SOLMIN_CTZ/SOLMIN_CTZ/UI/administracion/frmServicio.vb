Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmServicio
    Private oRubro As SOLMIN_CTZ.Entidades.Rubro
    Private oRubroNeg As SOLMIN_CTZ.NEGOCIO.clsRubro
    Private oServicio As SOLMIN_CTZ.Entidades.Servicio
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oRubroXDivision As SOLMIN_CTZ.Entidades.Rubro_X_Division
    Private oRubroXDivisionNeg As SOLMIN_CTZ.NEGOCIO.clsRubroXDivision
    Private oServicioXRubro As SOLMIN_CTZ.Entidades.Servicio_X_Rubro
    Private oServicioXDivisionNeg As SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
    Private oTarifa As SOLMIN_CTZ.Entidades.Tarifa
    Private oTarifaNeg As SOLMIN_CTZ.NEGOCIO.clsTarifa
    Private oTarifario As SOLMIN_CTZ.Entidades.Tarifario
    Private oTarifarioNeg As SOLMIN_CTZ.NEGOCIO.clsTarifario
    Private oRango As SOLMIN_CTZ.Entidades.Rango
    Private oRangoNeg As SOLMIN_CTZ.NEGOCIO.clsRango
    Private oUsuario As clsUsuario
    Private oCliente As clsCliente
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oUM As SOLMIN_CTZ.NEGOCIO.clsUM
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oEstado As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oFiltro As SOLMIN_CTZ.Entidades.Filtro
    Private bolBuscar As Boolean

#Region "Enums"

    Enum Unidad
        TUNDIT
        TCMPUN
    End Enum

    Enum Rango
        NRRNGO
        RANGO
    End Enum

#End Region

    Private Sub frmServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oUsuario = DirectCast(HttpRuntime.Cache.Get("Usuario"), clsUsuario)
        oCliente = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente)
        oCompania = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania)
        oDivision = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision)
        oRubroNeg = New SOLMIN_CTZ.NEGOCIO.clsRubro
        oRubro = New SOLMIN_CTZ.Entidades.Rubro
        oServicio = New SOLMIN_CTZ.Entidades.Servicio
        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        oRubroXDivision = New SOLMIN_CTZ.Entidades.Rubro_X_Division
        oRubroXDivisionNeg = New SOLMIN_CTZ.NEGOCIO.clsRubroXDivision
        oServicioXRubro = New SOLMIN_CTZ.Entidades.Servicio_X_Rubro
        oServicioXDivisionNeg = New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
        oTarifa = New SOLMIN_CTZ.Entidades.Tarifa
        oTarifaNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifa
        oTarifario = New SOLMIN_CTZ.Entidades.Tarifario
        oTarifarioNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifario
        oRango = New SOLMIN_CTZ.Entidades.Rango
        oRangoNeg = New SOLMIN_CTZ.NEGOCIO.clsRango
        oUM = New SOLMIN_CTZ.NEGOCIO.clsUM
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oEstado = New SOLMIN_CTZ.NEGOCIO.clsEstado
        oFiltro = New SOLMIN_CTZ.Entidades.Filtro
        oRubroXDivision.CCMPN = oUsuario.Compania
        oRubroXDivision.CDVSN = oUsuario.Division
        'oServicioXRubro.CCMPN = oUsuario.Compania
        'oServicioXRubro.CDVSN = oUsuario.Division

        bolBuscar = False
        Crear_Grilla_Rango()
        Cargar_Rangos()
        Cargar_Clientes()
        Cargar_Compania()
        Cargar_Compania_Usuario()
        Cargar_Moneda()
        Cargar_Estado()
        Crear_Grilla_Tarifa_Servicio()
        Crear_Grilla_Tarifario()

        oTarifarioNeg.Lista_Tarifario()
        oTarifario.NRTARF = Buscar_Tarifario()
        oTarifarioNeg.Buscar_Observacion(oTarifario)
        Me.txtObservaTarifario.Text = oTarifario.TOBS
        bolBuscar = True
    End Sub

    Private Sub Cargar_Estado()
        oEstado.Estado_Servicio()
        cmbEstado.DataSource = oEstado.Tabla
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"
    End Sub

    Private Sub Cargar_Compania_Usuario()
        bolBuscar = True
        Me.cmbCompania.SelectedValue = Me.oUsuario.Compania
        bolBuscar = False
        Me.cmbDivision.SelectedValue = Me.oUsuario.Division
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Moneda()
        oMoneda.Crea_Moneda()
        cmbTarMoneda.DataSource = oMoneda.Lista_Moneda(1)
        cmbTarMoneda.ValueMember = "CMNDA1"
        cmbTarMoneda.DisplayMember = "TMNDA"
    End Sub

    Private Sub Cargar_Clientes()
        cmbTarCliente.DataSource = oCliente.Lista_Cliente
        cmbTarCliente.ValueMember = "NRCTCL"
        cmbTarCliente.DisplayMember = "NOMCAR"
    End Sub

#Region "Crear Grilla Rango"

    Private Sub Crear_Grilla_Rango()
        Dim oDcTx As DataGridViewColumn
        Dim oDcBx As DataGridViewComboBoxColumn
        Dim oDt As DataTable

        oDt = oUM.Lista_UM
        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRRNGO"
        oDcTx.HeaderText = "NRRNGO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgRangos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DESRNG"
        oDcTx.HeaderText = "Rango"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 200
        oDcTx.ReadOnly = False
        Me.dtgRangos.Columns.Add(oDcTx)

        oDcBx = New DataGridViewComboBoxColumn
        oDcBx.Name = "TUNMEDDIT"
        oDcBx.HeaderText = "UM"
        oDcBx.DataSource = oDt
        oDcBx.DisplayMember = "TCMPUN"
        oDcBx.ValueMember = "TUNDIT"
        oDcBx.DataPropertyName = Unidad.TUNDIT.ToString
        oDcBx.Resizable = DataGridViewTriState.False
        oDcBx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dtgRangos.Columns.Add(oDcBx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "VALCTE"
        oDcTx.HeaderText = "Valor Único"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgRangos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "VALMIN"
        oDcTx.HeaderText = "Mínimo"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgRangos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "VALMAX"
        oDcTx.HeaderText = "Máximo"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgRangos.Columns.Add(oDcTx)
        
    End Sub

#End Region

#Region "Crear Grilla Tarifa Servicio"

    Private Sub Crear_Grilla_Tarifa_Servicio()
        Dim oDcTx As DataGridViewColumn
        Dim oDcBx As DataGridViewComboBoxColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRTFSV"
        oDcTx.HeaderText = "NRTFSV"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 100
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcBx = New DataGridViewComboBoxColumn
        oDcBx.Name = "RANGO"
        oDcBx.HeaderText = "Rango"
        oDs.Tables("Rango").Load(CType(oRangoNeg.Lista, DataTable).CreateDataReader)
        oDcBx.DataSource = oDs.Tables("Rango")
        oDcBx.DisplayMember = "RANGO"
        oDcBx.ValueMember = "NRRNGO"
        oDcBx.DataPropertyName = Rango.NRRNGO.ToString()
        oDcBx.Resizable = DataGridViewTriState.False
        oDcBx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dtgTarifaServicio.Columns.Add(oDcBx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "VALOR"
        oDcTx.HeaderText = "Valor"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 100
        oDcTx.ReadOnly = False
        Me.dtgTarifaServicio.Columns.Add(oDcTx)
    End Sub

#End Region

#Region "Crear Grilla Tarifario"

    Private Sub Crear_Grilla_Tarifario()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DIVISION"
        oDcTx.HeaderText = "Negocio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "RUBRO"
        oDcTx.HeaderText = "Rubro"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "RANGO"
        oDcTx.HeaderText = "Rango"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONEDA"
        oDcTx.HeaderText = "Moneda"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "Tarifa"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifas.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Click Arbol Servicios"

    Private Sub tvwServicio_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwServicio.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.ctmServicio.Items(0).Visible = False
            Me.ctmServicio.Items(1).Visible = False
            Me.ctmServicio.Items(2).Visible = False
            Me.ctmServicio.Items(3).Visible = False
            If Me.tvwServicio.SelectedNode.Name = "Raiz" Then
                Me.ctmServicio.Items(1).Visible = True
            Else
                If Me.tvwServicio.SelectedNode.Tag(1) = 0 Then
                    Me.ctmServicio.Items(0).Visible = True
                    Me.ctmServicio.Items(3).Visible = False
                Else
                    Me.ctmServicio.Items(2).Visible = True
                End If
            End If
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Limpiar_Tarifas()
                If (Not e.Node.Name = "Raiz") And (Not e.Node.Tag(1) = 0) Then
                    oTarifario.NRTARF = Buscar_Tarifario()
                    oTarifarioNeg.Buscar_Observacion(oTarifario)
                    Me.txtObservaTarifario.Text = oTarifario.TOBS
                    If oTarifario.NRTARF = 0 Then
                        HelpClass.MsgBox("Necesita crear un tarifario para poder visualizar las tarifas")
                    Else
                        'Lista_Tarifa_Servicio(e.Node.Tag(0), e.Node.Tag(1))
                        Lista_Tarifa_Servicio(e.Node.Tag(3))
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Rubro y Servicio"

    Private Sub Mostrar_Panel_Nuevo_Rubro()
        Me.txtDesRubro.Text = vbNullString
        Me.txtRubro.Text = vbNullString
        KryptonHeaderGroup3.Collapsed = False
        KryptonHeaderGroup3.Visible = True
    End Sub

    Private Sub Ocultar_Panel_Nuevo_Rubro()
        KryptonHeaderGroup3.Visible = False
        KryptonHeaderGroup3.Collapsed = True
    End Sub

    Private Sub Mostrar_Panel_Seleccion_Rubro()
        Me.lsvRubros.Items.Clear()
        Me.lsvRubrosSel.Items.Clear()
        Me.txtRubroSel.Text = vbNullString
        KryptonHeaderGroup6.Collapsed = False
        KryptonHeaderGroup6.Visible = True
    End Sub

    Private Sub Ocultar_Panel_Seleccion_Rubro()
        KryptonHeaderGroup6.Visible = False
        KryptonHeaderGroup6.Collapsed = True
    End Sub

    Private Sub Mostrar_Panel_Nuevo_Servicio()
        Me.txtDesServicio.Text = vbNullString
        Me.txtServicio.Text = vbNullString
        KryptonHeaderGroup17.Collapsed = False
        KryptonHeaderGroup17.Visible = True
    End Sub

    Private Sub Ocultar_Panel_Nuevo_Servicio()
        KryptonHeaderGroup17.Visible = False
        KryptonHeaderGroup17.Collapsed = True
    End Sub

    Private Sub Mostrar_Panel_Seleccion_Servicio()
        Me.lsvServicios.Items.Clear()
        Me.lsvServiciosSel.Items.Clear()
        Me.txtServicioSel.Text = vbNullString
        KryptonHeaderGroup2.Collapsed = False
        KryptonHeaderGroup2.Visible = True
    End Sub

    Private Sub Ocultar_Panel_Seleccion_Servicio()
        KryptonHeaderGroup2.Visible = False
        KryptonHeaderGroup2.Collapsed = True
    End Sub

    Private Sub tsmAddServicioSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddServicioSel.Click
        Me.tvwServicio.Enabled = False
        Ocultar_Panel_Nuevo_Rubro()
        Ocultar_Panel_Seleccion_Rubro()
        Ocultar_Panel_Nuevo_Servicio()
        Mostrar_Panel_Seleccion_Servicio()
    End Sub

    Private Sub btnCancelarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarServ.Click
        Ocultar_Panel_Nuevo_Servicio()
    End Sub

    Private Sub btnCancelarServSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarServSel.Click
        Ocultar_Panel_Seleccion_Servicio()
        Ocultar_Panel_Nuevo_Servicio()
        Me.tvwServicio.Enabled = True
    End Sub

    Private Sub btnCrearServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearServicio.Click
        Mostrar_Panel_Nuevo_Servicio()
    End Sub

    Private Sub tsmAddRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddRubroSel.Click
        Me.tvwServicio.Enabled = False
        Me.lsvRubros.Items.Clear()
        Ocultar_Panel_Nuevo_Servicio()
        Ocultar_Panel_Seleccion_Servicio()
        Ocultar_Panel_Nuevo_Rubro()
        Mostrar_Panel_Seleccion_Rubro()
    End Sub

    Private Sub btnCrearRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearRubro.Click
        Mostrar_Panel_Nuevo_Rubro()
    End Sub

    Private Sub btnCancelarRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarRubroSel.Click
        Ocultar_Panel_Nuevo_Rubro()
        Ocultar_Panel_Seleccion_Rubro()
        Me.tvwServicio.Enabled = True
    End Sub

    Private Sub btnCancelarRubro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelarRubro.Click
        Ocultar_Panel_Nuevo_Rubro()
    End Sub

    Private Sub txtRubroSel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRubroSel.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_Rubro()
        End If
    End Sub

    Private Sub Buscar_Rubro()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim lsvRow As ListViewItem
            Dim oDt As DataTable
            Dim intCont As Integer

            Me.lsvRubros.Items.Clear()
            oRubro.NOMRUB = Me.txtRubroSel.Text.Trim
            oFiltro.Parametro1 = Me.cmbCompania.SelectedValue
            oFiltro.Parametro2 = Me.cmbDivision.SelectedValue
            oDt = oRubroNeg.Lista_Rubro(oRubro, oFiltro)
            Me.lsvRubros.View = View.Details
            Me.lsvRubros.GridLines = True
            Me.lsvRubros.Items.Clear()

            For intCont = 0 To oDt.Rows.Count - 1
                lsvRow = New ListViewItem(oDt.Rows(intCont).Item("NRRUBR").ToString.Trim, 0)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("NOMRUB").ToString.Trim)
                lsvRubros.Items.Add(lsvRow)
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Nuevo_Rubro()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oRubro.NOMRUB = Me.txtRubro.Text.Trim
            oRubro.DESRBR = Me.txtDesRubro.Text.Trim
            oRubroNeg.Crear_Rubro(oRubro)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("Se agregó un nuevo rubro correctamente")
            Ocultar_Panel_Nuevo_Rubro()
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabarRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarRubro.Click
        Grabar_Nuevo_Rubro()
    End Sub

    Private Sub txtServicioSel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServicioSel.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_Servicio()
        End If
    End Sub

    Private Sub Buscar_Servicio()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim lsvRow As ListViewItem
            Dim oDt As DataTable
            Dim intCont As Integer

            Me.lsvServicios.Items.Clear()
            oServicio.NOMSER = Me.txtServicioSel.Text.Trim
            oFiltro.Parametro1 = Me.tvwServicio.SelectedNode.Tag(2)
            oDt = oServicioNeg.Lista_Servicio(oServicio, oFiltro)
            Me.lsvServicios.View = View.Details
            Me.lsvServicios.GridLines = True
            Me.lsvServicios.Items.Clear()

            For intCont = 0 To oDt.Rows.Count - 1
                lsvRow = New ListViewItem(oDt.Rows(intCont).Item("NRSERV").ToString.Trim, 0)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("NOMSER").ToString.Trim)
                lsvServicios.Items.Add(lsvRow)
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Nuevo_Servicio()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oServicio.NOMSER = Me.txtServicio.Text.Trim
            oServicio.DESSER = Me.txtDesServicio.Text.Trim
            oServicioNeg.Crear_Servicio(oServicio)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("Se agregó un nuevo servicio correctamente")
            Ocultar_Panel_Nuevo_Servicio()
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabarServ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabarServ.Click
        Grabar_Nuevo_Servicio()
    End Sub

    Private Sub Seleccionar_Rubro()
        Dim intCont As Integer
        Dim lsvRow As ListViewItem

        For intCont = 0 To Me.lsvRubros.CheckedItems.Count - 1
            lsvRow = New ListViewItem(Me.lsvRubros.CheckedItems(intCont).SubItems(0).Text.ToString.Trim, 0)
            lsvRow.SubItems.Add(Me.lsvRubros.CheckedItems(intCont).SubItems(1).Text.Trim)
            Me.lsvRubrosSel.Items.Add(lsvRow)
        Next intCont
    End Sub

    Private Sub Quitar_Rubro()
        Dim intCont As Integer
        Dim intRep As Integer

        intRep = Me.lsvRubrosSel.CheckedItems.Count
        For intCont = 0 To intRep - 1
            Me.lsvRubrosSel.Items.RemoveAt(Me.lsvRubrosSel.CheckedItems(0).Index)
        Next intCont
    End Sub

    Private Sub btnAddRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRubro.Click
        Seleccionar_Rubro()
    End Sub

    Private Sub btnQuitarRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarRubro.Click
        Quitar_Rubro()
    End Sub

    Private Sub Seleccionar_Servicio()
        Dim intCont As Integer
        Dim lsvRow As ListViewItem

        For intCont = 0 To Me.lsvServicios.CheckedItems.Count - 1
            lsvRow = New ListViewItem(Me.lsvServicios.CheckedItems(intCont).SubItems(0).Text.ToString.Trim, 0)
            lsvRow.SubItems.Add(Me.lsvServicios.CheckedItems(intCont).SubItems(1).Text.Trim)
            Me.lsvServiciosSel.Items.Add(lsvRow)
        Next intCont
    End Sub

    Private Sub Quitar_Servicio()
        Dim intCont As Integer
        Dim intRep As Integer

        intRep = Me.lsvServiciosSel.CheckedItems.Count
        For intCont = 0 To intRep - 1
            Me.lsvServiciosSel.Items.RemoveAt(Me.lsvServiciosSel.CheckedItems(0).Index)
        Next intCont
    End Sub

    Private Sub btnAddServ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddServ.Click
        Seleccionar_Servicio()
    End Sub

    Private Sub btnQuitarServ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitarServ.Click
        Quitar_Servicio()
    End Sub

    Private Sub Agregar_Rubro_Seleccionado()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            If Me.lsvRubrosSel.Items.Count > 0 Then
                If HelpClass.RspMsgBox("Está seguro de agregar los rubros seleccionados?") = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    oRubroXDivision.CCMPN = Me.cmbCompania.SelectedValue
                    oRubroXDivision.CDVSN = Me.cmbDivision.SelectedValue
                    oSqlMan.TransactionController(TransactionType.Manual)
                    oSqlMan.BeginGlobalTransaction()
                    For intCont = 0 To Me.lsvRubrosSel.Items.Count - 1
                        oRubroXDivision.NRRUBR = Me.lsvRubrosSel.Items(intCont).Text
                        oRubroXDivisionNeg.Agregar_Rubro_Division(oSqlMan, oRubroXDivision)
                    Next intCont
                    oSqlMan.CommitGlobalTransaction()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpClass.MsgBox("Se agregaron los rubros correctamente")
                    Ocultar_Panel_Seleccion_Rubro()
                    Limpiar_Arbol_Servicios()
                    Crear_Arbol_Servicios()
                End If
            Else
                HelpClass.MsgBox("Debe seleccionar algún rubro")
            End If
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub btnGuardarRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRubroSel.Click
        Agregar_Rubro_Seleccionado()
        Me.tvwServicio.Enabled = True
    End Sub

#End Region

#Region "Crear Arbol de Servicios"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Limpiar_Arbol_Servicios()
        Limpiar_Tarifario()
        Limpiar_Tarifas()
        Crear_Arbol_Servicios()
        Crear_Tarifario()
    End Sub

    Private Sub Limpiar_Arbol_Servicios()
        Me.tvwServicio.Nodes(0).Nodes.Clear()
    End Sub

    Private Sub Crear_Arbol_Servicios()
        Try
            Dim oDt As DataTable
            Dim intCont As Integer
            Dim intRubro As Integer = 0
            Dim tndNodo As TreeNode
            Dim tndNodoHijo As TreeNode

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oFiltro.Parametro1 = Me.cmbCompania.SelectedValue
            'oServicioXRubro.CCMPN = Me.cmbCompania.SelectedValue
            If Me.cmbDivision.SelectedValue = "Z" Then
                oFiltro.Parametro2 = ""
                'oServicioXRubro.CDVSN = ""
            Else
                oFiltro.Parametro2 = Me.cmbDivision.SelectedValue
                'oServicioXRubro.CDVSN = Me.cmbDivision.SelectedValue
            End If
            If Me.cmbEstado.Text.Trim = "TODOS" Then
                oServicioXRubro.SESTRG = ""
            Else
                oServicioXRubro.SESTRG = Me.cmbEstado.SelectedValue
            End If
            oDt = oServicioXDivisionNeg.Lista_Servicio_X_Division(oServicioXRubro, oFiltro)
            For intCont = 0 To oDt.Rows.Count - 1
                Dim obj(3) As Object
                obj(0) = oDt.Rows(intCont).Item("NRRUBR").ToString.Trim
                obj(1) = oDt.Rows(intCont).Item("NRSERV").ToString.Trim
                obj(2) = oDt.Rows(intCont).Item("NRRBDV").ToString.Trim
                obj(3) = oDt.Rows(intCont).Item("NRSRRB").ToString.Trim
                If intRubro <> Integer.Parse(oDt.Rows(intCont).Item("NRRUBR").ToString.Trim) Then
                    tndNodo = New TreeNode(oDt.Rows(intCont).Item("NOMRUB").ToString.Trim, 9, 10)
                    tndNodo.Tag = obj
                    tvwServicio.Nodes(0).Nodes.Add(tndNodo)
                Else
                    tndNodoHijo = New TreeNode(oDt.Rows(intCont).Item("NOMSER").ToString.Trim, 11, 12)
                    tndNodoHijo.Tag = obj
                    tndNodo.Nodes.Add(tndNodoHijo)
                End If
                intRubro = Integer.Parse(oDt.Rows(intCont).Item("NRRUBR").ToString.Trim)
            Next intCont
            tvwServicio.Nodes(0).ExpandAll()
            Dim oTaj(3) As Object
            oTaj(0) = -1
            oTaj(1) = -1
            oTaj(2) = -1
            oTaj(3) = -1
            Me.tvwServicio.Nodes(0).Tag = oTaj
            Me.tvwServicio.SelectedNode = Me.tvwServicio.Nodes(0)
            Me.tvwServicio.Enabled = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Asignar Servicio"

    Private Sub Agregar_Servicio_Seleccionado()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            If Me.lsvServiciosSel.Items.Count > 0 Then
                If HelpClass.RspMsgBox("Está seguro de agregar los servicios seleccionados?") = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    'oServicioXRubro.CCMPN = Me.cmbCompania.SelectedValue
                    'oServicioXRubro.CDVSN = Me.cmbDivision.SelectedValue
                    oSqlMan.TransactionController(TransactionType.Manual)
                    oSqlMan.BeginGlobalTransaction()
                    For intCont = 0 To Me.lsvServiciosSel.Items.Count - 1
                        'oServicioXRubro.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0)
                        oServicioXRubro.NRRBDV = Me.tvwServicio.SelectedNode.Tag(2)
                        oServicioXRubro.NRSERV = Me.lsvServiciosSel.Items(intCont).Text
                        oServicioXDivisionNeg.Agregar_Servicio_X_Division(oSqlMan, oServicioXRubro)
                    Next intCont
                    oSqlMan.CommitGlobalTransaction()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpClass.MsgBox("Se agregaron los servicios correctamente")
                    Ocultar_Panel_Seleccion_Servicio()
                    Limpiar_Arbol_Servicios()
                    Crear_Arbol_Servicios()
                End If
            Else
                HelpClass.MsgBox("Debe seleccionar algún servicio")
            End If
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub btnGuardarServSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarServSel.Click
        Agregar_Servicio_Seleccionado()
        Me.tvwServicio.Enabled = True
    End Sub

#End Region
    
#Region "Rangos"

    Private Sub btnAgregarRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRango.Click
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgRangos)
        Me.dtgRangos.Rows.Add(oDrVw)
    End Sub

    Private Sub btnGrabarRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarRango.Click
        Grabar_Rangos()
        oRangoNeg.Lista_Rango_Unidad()
        oDs.Tables("Rango").Clear()
        oDs.Tables("Rango").Load(CType(oRangoNeg.Lista, DataTable).CreateDataReader)
    End Sub

    Private Sub Grabar_Rangos()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgRangos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            oRangoNeg.Eliminar_Rango(oSqlMan)
            With Me.dtgRangos
                For intCont = 0 To .Rows.Count - 1
                    If Not (.Rows(intCont).Cells("VALCTE").Value = vbNullString And .Rows(intCont).Cells("VALMAX").Value = vbNullString And .Rows(intCont).Cells("VALMIN").Value = vbNullString) Then
                        If .Rows(intCont).Cells("DESRNG").Value Is Nothing Then
                            oRango.DESRNG = ""
                        Else
                            oRango.DESRNG = .Rows(intCont).Cells("DESRNG").Value
                        End If
                        oRango.TUNDIT = .Rows(intCont).Cells("TUNMEDDIT").Value
                        oRango.VALCTE = .Rows(intCont).Cells("VALCTE").Value
                        oRango.VALMIN = .Rows(intCont).Cells("VALMIN").Value
                        oRango.VALMAX = .Rows(intCont).Cells("VALMAX").Value
                        oRangoNeg.Crear_Rango(oSqlMan, oRango)
                    End If
                Next intCont
            End With
            oSqlMan.CommitGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub Cargar_Rangos()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer

        oRangoNeg.Lista_Rango_Unidad()
        oDt = oRangoNeg.Lista_Rango(oRango)

        If oDt.Rows.Count > 0 Then
            For intCont = 0 To oDt.Rows.Count - 1
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgRangos)
                oDrVw.Cells(0).Value = oDt.Rows(intCont).Item("NRRNGO").ToString.Trim
                oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("DESRNG").ToString.Trim
                oDrVw.Cells(2).Value = oDt.Rows(intCont).Item("TUNDIT").ToString.Trim
                oDrVw.Cells(3).Value = oDt.Rows(intCont).Item("VALCTE").ToString.Trim
                oDrVw.Cells(4).Value = oDt.Rows(intCont).Item("VALMIN").ToString.Trim
                oDrVw.Cells(5).Value = oDt.Rows(intCont).Item("VALMAX").ToString.Trim
                Me.dtgRangos.Rows.Add(oDrVw)
            Next intCont
        End If
    End Sub

#End Region

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            cmbDivision.DataSource = oDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            cmbDivision.DisplayMember = "TCMPDV"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmDelServicioSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelServicioSel.Click
        Quitar_Servicio_Division()
        Limpiar_Arbol_Servicios()
        Limpiar_Tarifario()
        Limpiar_Tarifas()
        Crear_Arbol_Servicios()
        Crear_Tarifario()
    End Sub

    Private Sub Quitar_Servicio_Division()
        Try
            If HelpClass.RspMsgBox("Está seguro de quitar el servicio?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                'oServicioXRubro.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0).ToString.Trim
                oServicioXRubro.NRSRRB = Me.tvwServicio.SelectedNode.Tag(3).ToString.Trim
                'oServicioXRubro.NRSERV = Me.tvwServicio.SelectedNode.Tag(1).ToString.Trim
                oServicioXDivisionNeg.Quitar_Servicio_X_Division(oServicioXRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el servicio")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#Region "Tarifario"

    'Private Sub Lista_Tarifa_Servicio(ByVal pdblRubro As Double, ByVal pdblServ As Double)
    Private Sub Lista_Tarifa_Servicio(ByVal pdblServXRubro As Double)
        'oTarifa.CCMPN = Me.cmbCompania.SelectedValue
        'oTarifa.CDVSN = Me.cmbDivision.SelectedValue
        'oTarifa.NRRUBR = pdblRubro
        'oTarifa.NRSERV = pdblServ
        oTarifa.NRSRRB = pdblServXRubro
        oTarifa.NRTARF = oTarifario.NRTARF
        oTarifaNeg.Lista_Tarifa(oTarifa)
        If oTarifaNeg.Lista.Rows.Count > 0 Then
            Mostrar_Tarifas()
        End If
    End Sub

    Private Sub cmbTarCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTarCliente.SelectedIndexChanged
        If bolBuscar Then
            oTarifario.NRTARF = Buscar_Tarifario()
            oTarifarioNeg.Buscar_Observacion(oTarifario)
            Me.txtObservaTarifario.Text = oTarifario.TOBS
            Limpiar_Tarifas()
            Crear_Tarifario()
            If Servicio_Seleccionado() Then
                If oTarifario.NRTARF = 0 Then
                    HelpClass.MsgBox("Necesita crear un tarifario para poder visualizar las tarifas")
                Else
                    'Lista_Tarifa_Servicio(Me.tvwServicio.SelectedNode.Tag(0), Me.tvwServicio.SelectedNode.Tag(1))
                    Lista_Tarifa_Servicio(Me.tvwServicio.SelectedNode.Tag(3))
                    Crear_Tarifario()
                End If
            End If
        End If
    End Sub

    Private Sub cmbTarMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTarMoneda.SelectedIndexChanged
        If bolBuscar Then
            oTarifario.NRTARF = Buscar_Tarifario()
            oTarifarioNeg.Buscar_Observacion(oTarifario)
            Me.txtObservaTarifario.Text = oTarifario.TOBS
            Limpiar_Tarifas()
            Crear_Tarifario()
            If Servicio_Seleccionado() Then
                If oTarifario.NRTARF = 0 Then
                    HelpClass.MsgBox("Necesita crear un tarifario para poder visualizar las tarifas")
                Else
                    'Lista_Tarifa_Servicio(Me.tvwServicio.SelectedNode.Tag(0), Me.tvwServicio.SelectedNode.Tag(1))
                    Lista_Tarifa_Servicio(Me.tvwServicio.SelectedNode.Tag(3))
                End If
            End If
        End If
    End Sub

    Private Function Servicio_Seleccionado() As Boolean
        If Me.tvwServicio.Nodes(0).Nodes.Count > 0 Then
            If Me.tvwServicio.SelectedNode.Tag(1) > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnAgregarTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTar.Click
        If Valida_Seleccion() Then
            If oTarifario.NRTARF = 0 Then
                HelpClass.MsgBox("Necesita crear un tarifario para poder agregar tarifas")
            Else
                Agregar_Tarifa()
            End If
        Else
            HelpClass.MsgBox("Debe seleccionar un servicio")
        End If
    End Sub

    Private Function Valida_Seleccion() As Boolean
        If Me.tvwServicio.Nodes(0).Nodes.Count > 0 Then
            If Me.tvwServicio.SelectedNode.Tag(1) > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Crear_Nuevo_Tarifario()
        Dim oNewTarifario As New SOLMIN_CTZ.Entidades.Tarifario
        Dim strMsn As String

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oNewTarifario.NRCTCL = Me.cmbTarCliente.SelectedValue
            oNewTarifario.CMNDA1 = Me.cmbTarMoneda.SelectedValue
            oNewTarifario.TOBS = Me.txtObservaTarifario.Text.Trim
            strMsn = "Cliente: " & Me.cmbTarCliente.Text.Trim & vbCrLf
            strMsn = strMsn & "Moneda: " & Me.cmbTarMoneda.Text.Trim & vbCrLf
            strMsn = strMsn & "Obs: " & oNewTarifario.TOBS.Trim
            If HelpClass.RspMsgBox("Está seguro de grabar un Tarifario con los sgtes. datos :" & vbCrLf & strMsn) = Windows.Forms.DialogResult.Yes Then
                oTarifarioNeg.Crear_Tarifario(oNewTarifario)
                oTarifarioNeg.Lista_Tarifario()
                oTarifario.NRTARF = Buscar_Tarifario()
                oTarifarioNeg.Buscar_Observacion(oTarifario)
                Me.txtObservaTarifario.Text = oTarifario.TOBS
                oTarifa.NRTARF = oTarifario.NRTARF
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se creó correctamente el Tarifario")
                'oTarifa.CCMPN = Me.cmbCompania.SelectedValue
                'oTarifa.CDVSN = Me.cmbDivision.SelectedValue
                If Me.tvwServicio.SelectedNode.Name <> "Raiz" Then
                    'oTarifa.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0)
                    'oTarifa.NRSERV = Me.tvwServicio.SelectedNode.Tag(1)
                    oTarifa.NRSRRB = Me.tvwServicio.SelectedNode.Tag(3)
                End If
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Agregar_Tarifa()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgTarifaServicio)
        oDrVw.Cells(0).Value = ""
        Me.dtgTarifaServicio.Rows.Add(oDrVw)
    End Sub

    Private Sub Mostrar_Tarifas()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer

        oDt = oTarifaNeg.Lista.Copy
        If oDt.Rows.Count > 0 Then
            For intCont = 0 To oDt.Rows.Count - 1
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgTarifaServicio)
                oDrVw.Cells(0).Value = oDt.Rows(intCont).Item("NRTFSV").ToString.Trim
                oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("NRRNGO")
                oDrVw.Cells(2).Value = oDt.Rows(intCont).Item("IVLSRV").ToString.Trim
                oDrVw.ReadOnly = True
                Me.dtgTarifaServicio.Rows.Add(oDrVw)
            Next intCont
        End If
    End Sub

    Private Function Buscar_Tarifario() As Double
        Dim strCadena As String

        oFiltro.Parametro1 = Me.cmbTarCliente.SelectedValue
        oFiltro.Parametro2 = Me.cmbTarMoneda.SelectedValue
        strCadena = oTarifarioNeg.Buscar_Tarifario(oFiltro)
        If strCadena = vbNullString Then
            Return 0
        End If

        Return Double.Parse(strCadena)
    End Function

    Private Sub Limpiar_Tarifas()
        Me.dtgTarifaServicio.Rows.Clear()
    End Sub

    Private Sub btnGrabarTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTar.Click
        Grabar_Tarifas_Nuevas()
        Limpiar_Tarifas()
        'Lista_Tarifa_Servicio(oTarifa.NRRUBR, oTarifa.NRSERV)
        Lista_Tarifa_Servicio(oTarifa.NRSRRB)
        Crear_Tarifario()
    End Sub

    Private Sub Grabar_Tarifas_Nuevas()
        Dim intCont As Integer
        Dim oSqlMan As New SqlManager

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgTarifaServicio.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            For intCont = 0 To Me.dtgTarifaServicio.Rows.Count - 1
                With dtgTarifaServicio.Rows(intCont)
                    If .Cells(0).Value = vbNullString Then
                        oTarifa.NRRNGO = .Cells(1).Value
                        oTarifa.IVLSRV = Double.Parse(.Cells(2).Value)
                        oTarifa.NRSRRB = Me.tvwServicio.SelectedNode.Tag(3)
                        oTarifa.NRTARF = oTarifario.NRTARF
                        oTarifa.FECINI = Format(Now, "yyyyMMdd")
                        oTarifaNeg.Crear_Tarifa(oSqlMan, oTarifa)
                    End If
                End With
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub Deshabilitar_Panel_Tarifas()
        Me.KryptonHeaderGroup7.Enabled = False
    End Sub

    Private Sub Habilitar_Panel_Tarifas()
        Me.KryptonHeaderGroup7.Enabled = True
    End Sub

    Private Sub Deshabilitar_Filtro_Tarifario()
        KryptonPanel5.Enabled = False
    End Sub

    Private Sub Habilitar_Filtro_Tarifario()
        KryptonPanel5.Enabled = True
    End Sub

    Private Sub tsmDelTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelTarifa.Click
        Eliminar_Tarifa()
        Crear_Tarifario()
    End Sub

    Private Sub Eliminar_Tarifa()
        Try
            If Me.dtgTarifaServicio.SelectedRows.Count > 0 Then
                If HelpClass.RspMsgBox("Está seguro de eliminar la tarifa?") = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    If Me.dtgTarifaServicio.SelectedRows(0).Cells(0).Value.ToString.Trim <> vbNullString Then
                        oTarifa.NRTFSV = Double.Parse(Me.dtgTarifaServicio.SelectedRows(0).Cells(0).Value.ToString.Trim)
                        oTarifaNeg.Eliminar_Tarifa(oTarifa)
                    End If
                    Me.dtgTarifaServicio.Rows.RemoveAt(Me.dtgTarifaServicio.SelectedRows(0).Index)
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpClass.MsgBox("Se quitó correctamente la tarifa")
                End If
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub Crear_Tarifario()
        Limpiar_Tarifario()
        If oTarifario.NRTARF > 0 Then
            Listar_Tarifas()
        End If
    End Sub

    Private Sub Listar_Tarifas()
        Try
            Dim oDt As DataTable
            Dim intCont As Integer

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oFiltro.Parametro1 = Me.cmbCompania.SelectedValue.ToString.Trim
            oFiltro.Parametro2 = oTarifario.NRTARF
            oFiltro.Parametro3 = ""
            oFiltro.Parametro4 = Me.cmbDivision.SelectedValue.ToString.Trim
            oDt = oTarifaNeg.Buscar_Tarifa(oFiltro)
            For intCont = 0 To oDt.Rows.Count - 1
                Agregar_Row_Tarifa()
                With Me.dtgTarifas.Rows(intCont)
                    .Cells(0).Value = oDt.Rows(intCont).Item("TCMPDV").ToString.Trim
                    .Cells(1).Value = oDt.Rows(intCont).Item("NOMRUB").ToString.Trim
                    .Cells(2).Value = oDt.Rows(intCont).Item("NOMSER").ToString.Trim
                    .Cells(3).Value = oDt.Rows(intCont).Item("DESRNG").ToString.Trim
                    .Cells(4).Value = oDt.Rows(intCont).Item("TSGNMN").ToString.Trim
                    .Cells(5).Value = oDt.Rows(intCont).Item("IVLSRV").ToString.Trim
                End With
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Tarifario()
        Me.dtgTarifas.Rows.Clear()
    End Sub

    Private Sub Agregar_Row_Tarifa()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgTarifas)
        Me.dtgTarifas.Rows.Add(oDrVw)
    End Sub

    Private Sub KryptonHeaderGroup5_CollapsedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonHeaderGroup5.CollapsedChanged
        If Me.KryptonHeaderGroup5.Collapsed Then
            Me.btnAgregarTar.Visible = True
            Me.btnGrabarTar.Visible = True
            Me.dtgTarifaServicio.Enabled = True
            Me.btnGrabarRango.Visible = False
            Me.btnAgregarRango.Visible = False
        Else
            Me.btnAgregarTar.Visible = False
            Me.btnGrabarTar.Visible = False
            Me.dtgTarifaServicio.Enabled = False
            Me.btnGrabarRango.Visible = True
            Me.btnAgregarRango.Visible = True
        End If
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        Limpiar_Arbol_Servicios()
        Limpiar_Tarifario()
        Limpiar_Tarifas()
    End Sub

    Private Sub tsmDelRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelRango.Click
        If Me.dtgRangos.SelectedRows.Count > 0 Then
            Me.dtgRangos.Rows.RemoveAt(Me.dtgRangos.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub btnAddTarifario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTarifario.Click
        If oTarifario.NRTARF = 0 Then
            btnExportarXLS.Visible = False
            btnAddTarifario.Visible = False
            btnEscTarifario.Visible = True
            btnSaveTarifario.Visible = True
            txtObservaTarifario.Enabled = True
            txtObservaTarifario.ReadOnly = False
            txtObservaTarifario.BackColor = Color.FromArgb(255, 255, 192)
        Else
            HelpClass.MsgBox("Ya existe un tarifario, no puede duplicar un tarifario")
        End If
    End Sub

    Private Sub btnSaveTarifario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveTarifario.Click
        Ocultar_Botones()
        Crear_Nuevo_Tarifario()
    End Sub

    Private Sub Ocultar_Botones()
        btnExportarXLS.Visible = True
        btnAddTarifario.Visible = True
        btnEscTarifario.Visible = False
        btnSaveTarifario.Visible = False
        txtObservaTarifario.BackColor = Color.White
        txtObservaTarifario.Enabled = False
        txtObservaTarifario.ReadOnly = True
    End Sub

    Private Sub btnEscTarifario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEscTarifario.Click
        Ocultar_Botones
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        Limpiar_Arbol_Servicios()
        Limpiar_Tarifario()
        Limpiar_Tarifas()
    End Sub
End Class
