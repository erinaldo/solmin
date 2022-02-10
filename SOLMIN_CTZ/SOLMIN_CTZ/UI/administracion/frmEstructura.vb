Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmEstructura
    Private oRubro As SOLMIN_CTZ.Entidades.Rubro
    Private oRubroNeg As SOLMIN_CTZ.NEGOCIO.clsRubro
    Private oServicio As SOLMIN_CTZ.Entidades.Servicio
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oServicioXRubro As SOLMIN_CTZ.Entidades.Servicio_X_Rubro
    Private oServicioXDivisionNeg As SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
    Private oCliente As clsCliente
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oEstado As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oFiltro As SOLMIN_CTZ.Entidades.Filtro
    Private oTarifaNeg As SOLMIN_CTZ.NEGOCIO.clsTarifa
    Private bolBuscar As Boolean
    Private bolServicio As Boolean
    Private oTarifa As SOLMIN_CTZ.Entidades.Tarifa
    Private key As String


    Private Sub frmEstructura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oEstado = New SOLMIN_CTZ.NEGOCIO.clsEstado
        oRubroNeg = New SOLMIN_CTZ.NEGOCIO.clsRubro
        oRubro = New SOLMIN_CTZ.Entidades.Rubro
        oServicio = New SOLMIN_CTZ.Entidades.Servicio
        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        oServicioXRubro = New SOLMIN_CTZ.Entidades.Servicio_X_Rubro
        oServicioXDivisionNeg = New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
        oTarifaNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifa
        oFiltro = New SOLMIN_CTZ.Entidades.Filtro
        bolBuscar = False
        Crear_Grilla_Tarifas()
        Cargar_Estado()
        Cargar_Compania()
        Cargar_Division()
        bolBuscar = True
        Mostrar_Tarifario()
        'inicializa en 0
        key = "0"
    End Sub

    Private Sub Mostrar_Tarifario()
        Me.TabControl1.Dock = DockStyle.Top
        Me.TabControl1.Visible = True
        Me.TabControl2.Visible = False
        Me.TabControl3.Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(0).Visible = True
        Me.KryptonHeaderGroup8.ButtonSpecs(1).Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(2).Visible = False
    End Sub

    Private Sub Cargar_Estado()
        oEstado.Estado_Servicio()
        cmbEstado.DataSource = oEstado.Tabla
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedIndex = 0
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
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

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Limpiar_Arbol_Servicios()
            Crear_Arbol_Servicios()
            Limpiar_Grilla_Tarifa()
        End If
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        If bolBuscar Then
            Limpiar_Arbol_Servicios()
            Crear_Arbol_Servicios()
        End If
    End Sub

#Region "Crear Grilla Tarifas"

    Private Sub Crear_Grilla_Tarifas()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRCTCL"
        oDcTx.HeaderText = "Código"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DESCAR"
        oDcTx.HeaderText = "Cliente"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCNTRT"
        oDcTx.HeaderText = "Contrato"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TPLNTA"
        oDcTx.HeaderText = "Planta"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "Tarifa"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CONCEPTO"
        oDcTx.HeaderText = "Concepto"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Observación"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.ReadOnly = True
        Me.dtgTarifaServicio.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Rubro y Servicio"

    Private Sub Mostrar_Panel_Nuevo_Rubro()
        Me.txtRubro.Text = vbNullString
    End Sub

    Private Sub Mostrar_Panel_Nuevo_Servicio()
        Me.txtServicio.Text = vbNullString
    End Sub

    Private Sub tsmAddServicioSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddServicioSel.Click
        Me.tvwServicio.Enabled = False
        Cargar_Servicio()
        Mostrar_Panel_Nuevo_Servicio()
        Mostrar_Servicio()
    End Sub

    Private Sub Mostrar_Servicio()
        Me.TabControl3.Dock = DockStyle.Top
        Me.TabControl3.Visible = True
        Me.TabControl1.Visible = False
        Me.TabControl2.Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(0).Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(1).Visible = True
        Me.KryptonHeaderGroup8.ButtonSpecs(2).Visible = True
    End Sub

    Private Sub Cancelar_Servicio()
        Habilitar_Arbol_Servicio()
    End Sub

    Private Sub tsmAddRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddRubroSel.Click
        Deshabilitar_Arbol_Servicio()
        Mostrar_Panel_Nuevo_Rubro()
        Mostrar_Rubro()
    End Sub

    Private Sub Mostrar_Rubro()
        Me.TabControl2.Dock = DockStyle.Top
        Me.TabControl2.Visible = True
        Me.TabControl1.Visible = False
        Me.TabControl1.Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(0).Visible = False
        Me.KryptonHeaderGroup8.ButtonSpecs(1).Visible = True
        Me.KryptonHeaderGroup8.ButtonSpecs(2).Visible = True
    End Sub

    Private Sub Cancelar_Rubro()
        Habilitar_Arbol_Servicio()
    End Sub

    Private Sub Actualizar_Rubro()
        Try
            If HelpClass.RspMsgBox("Está seguro de actualizar el rubro seleccionado?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oRubro.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0)
                oRubro.NOMRUB = Me.txtRubro.Text.Trim
                oRubroNeg.Actualizar_Rubro(oRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se actualizó el rubro correctamente")
                'Ocultar_Panel_Nuevo_Rubro()
                Habilitar_Arbol_Servicio()
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Nuevo_Rubro()
        Try
            If HelpClass.RspMsgBox("Está seguro de agregar el rubro?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oRubro.CCMPN = Me.cmbCompania.SelectedValue
                oRubro.CDVSN = Me.cmbDivision.SelectedValue
                'oRubro.CRGVTA = Me.oCompania.Lista_Region_Venta(Me.cmbCompania.SelectedValue)
                oRubro.NOMRUB = Me.txtRubro.Text.Trim
                oRubroNeg.Crear_Rubro(oRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se agregó un nuevo rubro correctamente")
                'Ocultar_Panel_Nuevo_Rubro()
                Habilitar_Arbol_Servicio()
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Habilitar_Arbol_Servicio()
        Me.tvwServicio.Enabled = True
    End Sub

    Private Sub Deshabilitar_Arbol_Servicio()
        Me.tvwServicio.Enabled = False
    End Sub

    Private Sub Grabar_Rubro()
        If Me.tvwServicio.SelectedNode.Name = "Raiz" Then
            Grabar_Nuevo_Rubro()
        Else
            Actualizar_Rubro()
        End If
        Limpiar_Arbol_Servicios()
        Crear_Arbol_Servicios()
    End Sub

    Private Sub Grabar_Nuevo_Servicio()
        Try
            If HelpClass.RspMsgBox("Está seguro de agregar el servicio?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                oServicioXRubro.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0)
                oServicioXRubro.CSCDSP = Me.tvwServicio.SelectedNode.Tag(3)
                'oServicioXRubro.CRGVTA = Me.tvwServicio.SelectedNode.Tag(4)
                oServicioXRubro.CSRVNV = Me.cmbServicio.SelectedValue
                oServicioXRubro.CCMPN = Me.cmbCompania.SelectedValue
                oServicioXRubro.CDVSN = Me.cmbDivision.SelectedValue
                oServicioXRubro.NOMSER = Me.txtServicio.Text.Trim
                oServicioNeg.Crear_Servicio(oServicioXRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se agregó un nuevo servicio correctamente")
                'Ocultar_Panel_Nuevo_Servicio()
            End If

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Actualizar_Servicio()
        Try
            If HelpClass.RspMsgBox("Está seguro de actualizar el servicio seleccionado?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oServicioXRubro.NRSRRB = Me.tvwServicio.SelectedNode.Tag(2)
                oServicioXRubro.CSRVNV = Me.cmbServicio.SelectedValue
                oServicioXRubro.CCMPN = Me.cmbCompania.SelectedValue
                oServicioXRubro.CDVSN = Me.cmbDivision.SelectedValue
                oServicioXRubro.NOMSER = Me.txtServicio.Text.Trim
                oServicioNeg.Actualizar_Servicio(oServicioXRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se actualizó el servicio correctamente")
                'Ocultar_Panel_Nuevo_Servicio()
            End If

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Servicio()
        If Me.tvwServicio.SelectedNode.Tag(1) <> "0" Then
            Actualizar_Servicio()
        Else
            Grabar_Nuevo_Servicio()
        End If
        Limpiar_Arbol_Servicios()
        Crear_Arbol_Servicios()
    End Sub

    Private Sub Quitar_Rubro()
        Try
            If HelpClass.RspMsgBox("Está seguro de quitar el rubro y los servicios asociados?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oRubro.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0).ToString.Trim
                oRubroNeg.Quitar_Rubro_X_Division(oRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el rubro")
                Limpiar_Arbol_Servicios()
                Crear_Arbol_Servicios()
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Quitar_Servicio()
        Try
            If HelpClass.RspMsgBox("Está seguro que desea quitar el servicio seleccionado?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim objEntidad As New Servicio_X_Rubro
                objEntidad.NRSRRB = Me.tvwServicio.SelectedNode.Tag(2)
                oServicioNeg.Eliminar_Servicio(objEntidad)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el servicio")
                Limpiar_Arbol_Servicios()
                Crear_Arbol_Servicios()
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmDelServicioSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelServicioSel.Click
        If Verificar_Servicio() Then
            Quitar_Servicio()
        Else
            HelpClass.MsgBox("El servicio no se puede eliminar por tener tarifas asociadas vigentes")
        End If
    End Sub

    Private Sub Quitar_Servicio_Division()
        Try
            If HelpClass.RspMsgBox("Está seguro de quitar el servicio?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oServicioXRubro.NRSRRB = Me.tvwServicio.SelectedNode.Tag(3).ToString.Trim
                oServicioXDivisionNeg.Quitar_Servicio_X_Division(oServicioXRubro)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el servicio")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Crear Arbol de Servicios"

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
            If Me.cmbDivision.SelectedValue = "Z" Then
                oFiltro.Parametro2 = ""
            Else
                oFiltro.Parametro2 = Me.cmbDivision.SelectedValue
            End If
            If Me.cmbEstado.Text.Trim = "TODOS" Then
                oServicioXRubro.SESTRG = ""
            Else
                oServicioXRubro.SESTRG = Me.cmbEstado.SelectedValue
            End If
            oDt = oServicioXDivisionNeg.Lista_Servicio_X_Division(oServicioXRubro, oFiltro)
            For intCont = 0 To oDt.Rows.Count - 1
                Dim obj(6) As Object
                obj(0) = oDt.Rows(intCont).Item("NRRUBR").ToString.Trim
                obj(1) = oDt.Rows(intCont).Item("CSRVNV").ToString.Trim
                'obj(2) = oDt.Rows(intCont).Item("NRRBDV").ToString.Trim
                obj(2) = oDt.Rows(intCont).Item("NRSRRB").ToString.Trim
                obj(3) = oDt.Rows(intCont).Item("CSCDSP").ToString.Trim
                obj(4) = oDt.Rows(intCont).Item("CRGVTA").ToString.Trim
                obj(5) = oDt.Rows(intCont).Item("TCMTRF").ToString.Trim
                obj(6) = oDt.Rows(intCont).Item("NOMRUB").ToString.Trim
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

#Region "Click Arbol Servicios"

    Private Sub tvwServicio_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwServicio.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.ctmServicio.Items(0).Visible = False
            Me.ctmServicio.Items(1).Visible = False
            Me.ctmServicio.Items(2).Visible = False
            Me.ctmServicio.Items(3).Visible = False
            Me.ctmServicio.Items(4).Visible = False
            Me.ctmServicio.Items(5).Visible = False
            If Me.tvwServicio.SelectedNode.Name = "Raiz" Then
                Me.ctmServicio.Items(1).Visible = True
            Else
                If Me.tvwServicio.SelectedNode.Tag(1) = 0 Then
                    Me.ctmServicio.Items(0).Visible = True
                    Me.ctmServicio.Items(3).Visible = True
                    Me.ctmServicio.Items(5).Visible = True
                Else
                    Me.ctmServicio.Items(2).Visible = True
                    Me.ctmServicio.Items(4).Visible = True
                End If
            End If
        Else
            Limpiar_Grilla_Tarifa()
            If e.Button = Windows.Forms.MouseButtons.Left Then
                If e.Node.Tag(2) > 0 Then
                    Cargar_Tarifas(e.Node.Tag(2))
                    key = e.Node.Tag(2)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Tarifas"

    Private Sub Cargar_Tarifas(ByVal pdblServicio As Double)
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim objEntidad As New Tarifa

        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.NRSRRB = pdblServicio
        oDt = oTarifaNeg.Lista_Tarifa_Servicio(objEntidad)
        For intCont = 0 To oDt.Rows.Count - 1
            Agrega_Row_Tarifa()
            dtgTarifaServicio.Rows(intCont).Cells("NRCTCL").Value = oDt.Rows(intCont).Item("NRCTCL").ToString.Trim
            dtgTarifaServicio.Rows(intCont).Cells("DESCAR").Value = oDt.Rows(intCont).Item("DESCAR").ToString.Trim
            dtgTarifaServicio.Rows(intCont).Cells("TPLNTA").Value = oDt.Rows(intCont).Item("TPLNTA").ToString.Trim
            dtgTarifaServicio.Rows(intCont).Cells("NCNTRT").Value = oDt.Rows(intCont).Item("NCNTRT").ToString.Trim
            dtgTarifaServicio.Rows(intCont).Cells("SERVICIO").Value = oDt.Rows(intCont).Item("SERVICIO").ToString.Trim
            dtgTarifaServicio.Rows(intCont).Cells("TARIFA").Value = Generar_Tarifa(oDt.Rows(intCont))
            dtgTarifaServicio.Rows(intCont).Cells("CONCEPTO").Value = Generar_Concepto(oDt.Rows(intCont))
            dtgTarifaServicio.Rows(intCont).Cells("TOBS").Value = oDt.Rows(intCont).Item("TOBS").ToString.Trim
        Next intCont
    End Sub

    Private Sub Agrega_Row_Tarifa()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgTarifaServicio)
        Me.dtgTarifaServicio.Rows.Add(oDrVw)
    End Sub

    Private Sub Limpiar_Grilla_Tarifa()
        Me.dtgTarifaServicio.Rows.Clear()
    End Sub

    Private Function Generar_Tarifa(ByVal poRow As DataRow) As String
        Dim strTarifa As String = ""

        With poRow
            strTarifa = .Item("TSGNMN").ToString.Trim 'Moneda
            strTarifa = strTarifa & " " & Format(CType(.Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")

        End With
        Return strTarifa
    End Function

    Private Function Generar_Concepto(ByVal poRow As DataRow) As String
        Dim strConcepto As String = ""
        Dim nValMin As Double = 0D
        Dim nValMax As Double = 0D
        Dim nValCte As Double = 0D
        With poRow
            nValMin = IIf(IsDBNull(.Item("VALMIN")), 0, .Item("VALMIN"))
            nValMax = IIf(IsDBNull(.Item("VALMAX")), 0, .Item("VALMAX"))
            nValCte = IIf(IsDBNull(.Item("VALCTE")), 0, .Item("VALCTE"))
            If nValMin.ToString.Trim > 1 Then
                strConcepto = strConcepto & " por " & Format(CType(nValCte.ToString.Trim, Double), "###,###,###,##0")
            Else
                If nValCte.ToString.Trim = 1 And nValMin.ToString.Trim = 0 And nValMax.ToString.Trim = 0 Then
                    strConcepto = strConcepto & " por"
                End If
            End If
            If nValMin.ToString.Trim > 0 Then
                strConcepto = strConcepto & " de " & Format(CType(nValMin.ToString.Trim, Double), "###,###,###,##0")
            End If
            If nValMax.ToString.Trim > 0 Then
                strConcepto = strConcepto & " a " & Format(CType(nValMax.ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("MEDIDA").ToString.Trim <> "" Then
                strConcepto = strConcepto & " " & .Item("MEDIDA").ToString.Trim
            End If
            strConcepto = strConcepto & " " & .Item("DESRNG").ToString.Trim
            If .Item("STPTRA").ToString.Trim = "F" Then
                strConcepto = strConcepto & " (Fijo)"
            End If
            '-------------------          
        End With
        Return strConcepto
    End Function

#End Region

    Private Sub Cargar_Servicio()
        Try
            Dim oServicioGral As New Servicio_General
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oServicioGral.CCMPN = cmbCompania.SelectedValue
            oServicioGral.CDVSN = cmbDivision.SelectedValue
            'cmbServicio.DataSource = oServicioNeg.Lista_Servicio_General(oServicioGral)
            cmbServicio.ValueMember = "CSRVNV"
            cmbServicio.DisplayMember = "TCMTRF"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmDelRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelRubroSel.Click
        If Verificar_Rubro() Then
            Quitar_Rubro()
        Else
            HelpClass.MsgBox("El rubro no se puede eliminar por tener servicios con tarifas asociadas vigentes")
        End If
    End Sub

    Private Sub tsmUpdRubroSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUpdRubroSel.Click
        Deshabilitar_Arbol_Servicio()
        Mostrar_Panel_Nuevo_Rubro()
        'Cambiar_Titulo_Actualizar_Rubro()
        Cargar_Datos_Rubro()
        Mostrar_Rubro()
    End Sub

    Private Sub tsmUpdServicioSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUpdServicioSel.Click
        Deshabilitar_Arbol_Servicio()
        Cargar_Servicio()
        'Cambiar_Titulo_Actualizar_Servicio()
        Mostrar_Panel_Nuevo_Servicio()
        Cargar_Datos_Servicio()
        Mostrar_Servicio()
    End Sub

    Private Sub Cargar_Datos_Rubro()
        Me.txtRubro.Text = Me.tvwServicio.SelectedNode.Text
    End Sub

    Private Sub Cargar_Datos_Servicio()
        Me.cmbServicio.SelectedValue = Me.tvwServicio.SelectedNode.Tag(1)
        Me.txtServicio.Text = Me.tvwServicio.SelectedNode.Text
    End Sub

    Private Function Verificar_Servicio() As Boolean
        Try
            Dim objEntidad As New Servicio_X_Rubro
            Dim oDt As DataTable

            objEntidad.NRSRRB = Me.tvwServicio.SelectedNode.Tag(2)
            oDt = oServicioNeg.Verificar_Servicio(objEntidad)
            If oDt.Rows.Count > 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Function
    Private Function Verificar_Rubro() As Boolean
        Try
            Dim objEntidad As New Rubro
            Dim oDt As DataTable

            objEntidad.NRRUBR = Me.tvwServicio.SelectedNode.Tag(0)
            oDt = oRubroNeg.Verificar_Rubro(objEntidad)
            If oDt.Rows.Count > 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnExportarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarTarifa.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "003"
        Dim oDt As DataTable

        Dim intCont As Integer
        Dim objEntidad As New Tarifa

        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.NRSRRB = key
        oDt = oTarifaNeg.Lista_Tarifa_Servicio(objEntidad)
        '----------------------------------------------------------
        Dim dtNuevo As System.Data.DataTable = New System.Data.DataTable
        Dim colNueva As System.Data.DataColumn
        Dim filaNueva As System.Data.DataRow
        Dim numCols As Integer

        For Each dataGridViewCol As DataGridViewColumn In dtgTarifaServicio.Columns
            colNueva = New System.Data.DataColumn(dataGridViewCol.Name)
            dtNuevo.Columns.Add(colNueva)
        Next
        numCols = dtNuevo.Columns.Count

        For intCont = 0 To oDt.Rows.Count - 1
            filaNueva = dtNuevo.NewRow()
            With Me.dtgTarifaServicio.Rows(intCont)
                filaNueva(0) = oDt.Rows(intCont).Item("DESCAR").ToString.Trim
                filaNueva(1) = oDt.Rows(intCont).Item("TPLNTA").ToString.Trim
                filaNueva(2) = oDt.Rows(intCont).Item("NCNTRT").ToString.Trim
                filaNueva(3) = oDt.Rows(intCont).Item("SERVICIO").ToString.Trim
                filaNueva(4) = Generar_Tarifa(oDt.Rows(intCont))
                filaNueva(5) = Generar_Concepto(oDt.Rows(intCont))
                filaNueva(6) = IIf(IsDBNull(oDt.Rows(intCont).Item("TOBS")), "", oDt.Rows(intCont).Item("TOBS"))
            End With
            dtNuevo.Rows.Add(filaNueva)
        Next intCont
        '----------------------------------------------------------
        dtNuevo.Columns(0).ColumnName = "CLIENTE"
        dtNuevo.Columns(1).ColumnName = "PLANTA"
        dtNuevo.Columns(2).ColumnName = "CONTRATO"
        dtNuevo.Columns(3).ColumnName = "SERVICIO"
        dtNuevo.Columns(4).ColumnName = "TARIFA "
        dtNuevo.Columns(5).ColumnName = "CONCEPTO "
        dtNuevo.Columns(6).ColumnName = "OBSERVACION"
        dtNuevo.Columns.Remove("TOBS")

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim oListDt As New List(Of DataTable)
        dtNuevo.TableName = "Tarifas"
        oListDt.Add(dtNuevo)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oListDt, "TARIFAS POR SERVICIO")
        ' Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtNuevo)
        '   pExportarExcel("TARIFAS POR SERVICIO", UcClienteGrupo.pRazonSocial.ToString, Me.cmbDivision.Text.Trim & " EN " & Me.cmbMoneda.Text, Me.dtgTarifario.Rows, dtgTarifario)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function Convierte_Arbol() As DataTable
        '----------------------------
        ' Create new datatable
        Dim oDt As New DataTable
        Dim intCont As Integer
        Dim intNode As Integer
        ' Create columns
        oDt.Columns.Add("TCMTRF", Type.GetType("System.String"))
        oDt.Columns.Add("NOMRUB", Type.GetType("System.String"))
        oDt.Columns.Add("NOMSER", Type.GetType("System.String"))

        For intCont = 0 To tvwServicio.Nodes(0).Nodes.Count - 1
            For intNode = 0 To tvwServicio.Nodes(0).Nodes(intCont).Nodes.Count - 1
                If tvwServicio.Nodes(0).Nodes(intCont).Nodes(intNode).Tag(1) > 0 Then
                    ' Declare row
                    Dim oRow As DataRow
                    ' create new row
                    oRow = oDt.NewRow
                    oRow("TCMTRF") = tvwServicio.Nodes(0).Nodes(intCont).Nodes(intNode).Tag(5)
                    oRow("NOMRUB") = tvwServicio.Nodes(0).Nodes(intCont).Nodes(intNode).Tag(6)
                    oRow("NOMSER") = tvwServicio.Nodes(0).Nodes(intCont).Nodes(intNode).Text
                    oDt.Rows.Add(oRow)
                End If
            Next intNode
        Next intCont

        Return oDt
    End Function

    Private Sub btnExportarEstructura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarEstructura.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "002"
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intRubro As Integer = 0
        
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        oFiltro.Parametro1 = Me.cmbCompania.SelectedValue
        If Me.cmbDivision.SelectedValue = "Z" Then
            oFiltro.Parametro2 = ""
        Else
            oFiltro.Parametro2 = Me.cmbDivision.SelectedValue
        End If
        If Me.cmbEstado.Text.Trim = "TODOS" Then
            oServicioXRubro.SESTRG = ""
        Else
            oServicioXRubro.SESTRG = Me.cmbEstado.SelectedValue
        End If
        oDt = oServicioXDivisionNeg.Lista_Servicio_X_Division(oServicioXRubro, oFiltro)

        '----------------------------------------------------------
        Dim dtNuevo As DataTable = New DataTable
        Dim dtFiltro As DataTable = New DataTable
        Dim filaNueva As System.Data.DataRow

        dtNuevo.Columns.Add(New System.Data.DataColumn("RUBRO"))
        dtNuevo.Columns.Add(New System.Data.DataColumn("SERVICIO"))
        dtNuevo.Columns.Add(New System.Data.DataColumn("CODIGO"))
        dtNuevo.Columns.Add(New System.Data.DataColumn("SERVICIORUBRO"))

        dtFiltro.Columns.Add("ETIQUETA")
        dtFiltro.Columns.Add("DESCRIPCION")

        For intCont = 0 To oDt.Rows.Count - 1
            If oDt.Rows(intCont).Item("TCMTRF").ToString.Trim <> "" Then
                filaNueva = dtNuevo.NewRow()
                With oDt.Rows(intCont)

                    filaNueva(0) = oDt.Rows(intCont).Item("NOMRUB").ToString.Trim
                    filaNueva(1) = oDt.Rows(intCont).Item("TCMTRF").ToString.Trim
                    filaNueva(2) = oDt.Rows(intCont).Item("NRSRRB").ToString.Trim
                    filaNueva(3) = oDt.Rows(intCont).Item("NOMSER").ToString.Trim

                End With
                dtNuevo.Rows.Add(filaNueva)
            End If
        Next intCont
        '----------------------------------------------------------      
        dtNuevo.TableName = "SERVICIOS"

        Dim oListDt As New DataSet
        oListDt.Tables.Add(dtNuevo)

        Dim oDrw As DataRow
        oDrw = dtFiltro.NewRow
        oDrw("ETIQUETA") = "COMPAÑIA"
        oDrw("DESCRIPCION") = cmbCompania.Text
        dtFiltro.Rows.Add(oDrw)
        oDrw = dtFiltro.NewRow
        oDrw("ETIQUETA") = "DIVISION"
        oDrw("DESCRIPCION") = cmbDivision.Text
        dtFiltro.Rows.Add(oDrw)

        oListDt.Tables.Add(dtFiltro)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel_Generico(oListDt, "TARIFAS POR SERVICIO")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If Me.TabControl2.Visible Then
            Grabar_Rubro()
            Mostrar_Tarifario()
        End If
        If Me.TabControl3.Visible Then
            Grabar_Servicio()
            Mostrar_Tarifario()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Mostrar_Tarifario()
        Me.tvwServicio.Enabled = True
    End Sub
End Class