Imports SOLMIN_SC.Negocio
Imports System.Web

Public Class frmProveedor
    Private oEstado As Negocio.clsEstado
    Private oProveedor As clsProveedor
    Private intPosicion As Integer
    Private oPais As clsPais
    Private dblCodProveedor As Double
    Private bolBuscar As Boolean


    Private Sub frmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oEstado = New Negocio.clsEstado
        oProveedor = New clsProveedor
        oPais = New clsPais
        intPosicion = -1
        Llenar_Combo()
        Crear_Grilla_Documentos()
        CargarGrilla()
    End Sub

    Private Sub Llenar_Combo()
        CargarCliente()
        CargarEstado()
        CargarPais()
    End Sub

    Private Sub CargarPais()
        oPais.Crea_Lista()
        cmbPais.DataSource = oPais.Lista_Pais(-1)
        cmbPais.ValueMember = "CPAIS"
        cmbPais.DisplayMember = "TCMPPS"
    End Sub

    Private Sub CargarCliente()
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpClass.UserName
        bolBuscar = False
    End Sub

    Private Sub CargarEstado()
        oEstado.Estado_General()
        cmbEstado.DataSource = oEstado.Tabla
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"
    End Sub

#Region "Crear Grilla dtgProveedor"

    Private Sub Crear_Grilla_Documentos()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOMBRE"
        oDcTx.HeaderText = "Proveedor"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        Me.dtgProveedor.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DIRECCION"
        oDcTx.HeaderText = "Dirección"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        Me.dtgProveedor.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CONTACTO"
        oDcTx.HeaderText = "Contacto"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        Me.dtgProveedor.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TCMPPS"
        oDcTx.HeaderText = "País"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        Me.dtgProveedor.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CPRPCL"
        oDcTx.HeaderText = "Prov- Cliente"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgProveedor.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CODIGO"
        oDcTx.HeaderText = "CODIGO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgProveedor.Columns.Add(oDcTx)
        dtgProveedor.AutoGenerateColumns = False
    End Sub

#End Region

    Private Sub CargarGrilla()
        Dim strEstado As String
        Dim strFiltroNombre As String
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow

        If bolBuscar Then
            If Me.cmbEstado.Text = "TODOS" Then
                strEstado = ""
            Else
                strEstado = Me.cmbEstado.SelectedValue
            End If
            If Me.txtFiltroNombre.Text.Trim = String.Empty Then
                strFiltroNombre = ""
            Else
                strFiltroNombre = Me.txtFiltroNombre.Text.Trim
            End If
            oDt = oProveedor.Lista_Proveedor_X_Cliente(cmbCliente.pCodigo.ToString.Trim, strEstado, strFiltroNombre)

            With oDt
                If oDt.Rows.Count > 0 Then
                    For intCont = 0 To .Rows.Count - 1
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgProveedor)
                        oDrVw.Cells(0).Value = .Rows(intCont).Item("NOMBRE").ToString.Trim
                        oDrVw.Cells(1).Value = .Rows(intCont).Item("DIRECCION").ToString.Trim
                        oDrVw.Cells(2).Value = .Rows(intCont).Item("CONTACTO").ToString.Trim
                        oDrVw.Cells(3).Value = .Rows(intCont).Item("TCMPPS").ToString.Trim
                        oDrVw.Cells(4).Value = .Rows(intCont).Item("CPRPCL").ToString.Trim
                        oDrVw.Cells(5).Value = .Rows(intCont).Item("CODIGO").ToString.Trim
                        Me.dtgProveedor.Rows.Add(oDrVw)
                    Next intCont
                End If
            End With
        End If
    End Sub

    Private Sub Limpiar_Grilla()
        dtgProveedor.Rows.Clear()
    End Sub
    
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.bolBuscar = True
        Me.Cursor = Cursors.WaitCursor
        Buscar_Proveedor()
        Me.Cursor = Cursors.Default
        Me.bolBuscar = False
    End Sub

    Private Sub Buscar_Proveedor()
        Limpiar_Grilla()
        LimpiarDatos()
        CargarGrilla()
        If Me.dtgProveedor.Rows.Count > 0 Then
            Cargar_Infromacion_Proveedor(cmbCliente.pCodigo.ToString.Trim, Me.dtgProveedor.Rows(0).Cells("CODIGO").Value)
        End If
    End Sub

    Private Sub dtgProveedor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProveedor.CellClick
        If e.RowIndex > -1 Then
            Cargar_Infromacion_Proveedor(cmbCliente.pCodigo.ToString.Trim, Me.dtgProveedor.Rows(e.RowIndex).Cells("CODIGO").Value)
        End If
        intPosicion = e.RowIndex
    End Sub

    Private Sub Cargar_Infromacion_Proveedor(ByVal pdblCodClie As Double, ByVal pdblCodProv As Double)
        Dim oDt As DataTable
        oDt = oProveedor.Cargar_Datos_Proveedor(pdblCodClie, pdblCodProv)
        If oDt.Rows.Count <> 0 Then
            dblCodProveedor = oDt.Rows(0).Item("CPRVCL").ToString.Trim
            txtNomProv.Text = oDt.Rows(0).Item("TPRVCL").ToString.Trim
            txtDesc.Text = oDt.Rows(0).Item("TPRCL1").ToString.Trim
            If oDt.Rows(0).Item("NRUCPR").ToString.Trim <> "0" Then
                txtRUC.Text = oDt.Rows(0).Item("NRUCPR").ToString.Trim
            Else
                txtRUC.Text = ""
            End If
            txtCodProv.Text = oDt.Rows(0).Item("CPRPCL").ToString.Trim
            cmbPais.SelectedValue = oDt.Rows(0).Item("CPAIS").ToString.Trim
            txtDireccion.Text = oDt.Rows(0).Item("TDRPRC").ToString.Trim
            txtTelefono.Text = oDt.Rows(0).Item("TLFNO1").ToString.Trim
            txtEmail.Text = oDt.Rows(0).Item("TEMAI2").ToString.Trim
            txtFax.Text = oDt.Rows(0).Item("TNROFX").ToString.Trim
            txtNomProv.Text = oDt.Rows(0).Item("TPRVCL").ToString.Trim
            txtDesc.Text = oDt.Rows(0).Item("TPRCL1").ToString.Trim
            txtDatContContrato.Text = oDt.Rows(0).Item("TPRSCN").ToString.Trim
            txtDatTelContrato.Text = oDt.Rows(0).Item("TLFNO2").ToString.Trim
            txtDatCorreoContrato.Text = oDt.Rows(0).Item("TEMAI3").ToString.Trim
            If oDt.Rows(0).Item("SESTRG").ToString.Trim() = "A" Then
                chbEstado.Checked = True
            Else
                chbEstado.Checked = False
            End If
        End If
        intPosicion = 1
    End Sub

    Private Sub LimpiarDatos()
        txtNomProv.Text = ""
        txtDesc.Text = ""
        txtRUC.Text = ""
        txtCodProv.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtDesc.Text = ""
        txtDatContContrato.Text = ""
        txtDatTelContrato.Text = ""
        txtDatCorreoContrato.Text = ""
        chbEstado.Checked = True
        cmbPais.SelectedIndex = -1
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarDatos()
        Cargar_Codigo_Proveedor_Cliente()
    End Sub

    Private Sub Cargar_Codigo_Proveedor_Cliente()
        Dim oDt As DataTable

        oDt = oProveedor.Codigo_Proveedor_Cliente(cmbCliente.pCodigo.ToString.Trim())
        If oDt.Rows.Count > 0 Then
            txtCodProv.Text = oDt.Rows(0).Item("CPRPCL").ToString.Trim()
        End If
        intPosicion = -1
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Guardar_Informacion()
    End Sub

    Private Sub Guardar_Informacion()
        If intPosicion = -1 Then
            Crear_Nuevo_Proveedor()
        Else
            Grabar_Datos_Proveedor()
            Actualizar_Grilla()
        End If
        Actualizar_Proveedor_Global()
    End Sub

    Private Sub Actualizar_Grilla()
        Dim intCont As Integer

        For intCont = 0 To Me.dtgProveedor.Rows.Count - 1
            If Double.Parse(Me.dtgProveedor.Rows(intCont).Cells("CODIGO").Value.ToString.Trim) = dblCodProveedor Then
                With Me.dtgProveedor.Rows(intCont)
                    .Cells("NOMBRE").Value = txtNomProv.Text.Trim
                    .Cells("DIRECCION").Value = txtDireccion.Text.Trim
                    .Cells("CONTACTO").Value = txtDatContContrato.Text.Trim
                    .Cells("TCMPPS").Value = cmbPais.Text.Trim
                    .Cells("CPRPCL").Value = txtCodProv.Text.Trim
                End With
                Exit For
            End If
        Next intCont
    End Sub

    Private Sub Crear_Nuevo_Proveedor()
        Grabar_Nuevo_Proveedor()
    End Sub

    Private Sub Grabar_Nuevo_Proveedor()
        Dim dblRuc As Double
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If txtRUC.Text.Trim = vbNullString Then
                dblRuc = 0
            Else
                dblRuc = CType(txtRUC.Text, Double)
            End If
            If txtNomProv.Text.Trim <> vbNullString And txtCodProv.Text.Trim <> vbNullString Then
                oProveedor.Crear_Proveedor(txtNomProv.Text, txtDesc.Text, dblRuc, txtTelefono.Text, txtFax.Text, txtEmail.Text, txtDireccion.Text, cmbPais.SelectedValue, txtDatContContrato.Text, txtDatTelContrato.Text, txtDatCorreoContrato.Text, cmbCliente.pCodigo, txtCodProv.Text)
                Buscar_Proveedor()
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Debe colocar el nombre y el código del Proveedor")
                txtNomProv.Focus()
                Exit Sub
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("Se agregó un nuevo Proveedor correctamente")
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Datos_Proveedor()
        Dim strEstado As String
        Dim dblRuc As Double
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If chbEstado.Checked Then
                strEstado = "A"
            Else
                strEstado = "*"
            End If
            If txtRUC.Text.Trim = vbNullString Then
                dblRuc = 0
            Else
                dblRuc = CType(txtRUC.Text, Double)
            End If
            oProveedor.Actualizar_Proveedor(dblCodProveedor, txtNomProv.Text, txtDesc.Text, dblRuc, txtTelefono.Text, txtFax.Text, txtEmail.Text, txtDireccion.Text, cmbPais.SelectedValue, txtDatContContrato.Text, txtDatTelContrato.Text, txtDatCorreoContrato.Text, cmbCliente.pCodigo, txtCodProv.Text, strEstado)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Limpiar_Grilla()
        LimpiarDatos()
    End Sub

End Class
