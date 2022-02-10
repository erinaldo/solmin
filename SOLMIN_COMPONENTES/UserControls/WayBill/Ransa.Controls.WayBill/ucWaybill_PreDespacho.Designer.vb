<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWaybill_PreDespacho
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWaybill_PreDespacho))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgBultosSeleccionados = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroBultos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblNrosBultos = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgBultosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgBultosSeleccionados)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadBultos)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadBultos)
        Me.KryptonPanel.Controls.Add(Me.txtNroBultos)
        Me.KryptonPanel.Controls.Add(Me.lblNrosBultos)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(860, 625)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgBultosSeleccionados
        '
        Me.dgBultosSeleccionados.AllowUserToAddRows = False
        Me.dgBultosSeleccionados.AllowUserToResizeRows = False
        Me.dgBultosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBultosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CREFFW, Me.M_NSEQIN, Me.M_QREFFW, Me.M_TLUGEN, Me.M_NROPLT})
        Me.dgBultosSeleccionados.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgBultosSeleccionados.Location = New System.Drawing.Point(0, 109)
        Me.dgBultosSeleccionados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgBultosSeleccionados.MultiSelect = False
        Me.dgBultosSeleccionados.Name = "dgBultosSeleccionados"
        Me.dgBultosSeleccionados.ReadOnly = True
        Me.dgBultosSeleccionados.RowHeadersWidth = 20
        Me.dgBultosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBultosSeleccionados.Size = New System.Drawing.Size(860, 420)
        Me.dgBultosSeleccionados.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBultosSeleccionados.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultosSeleccionados.TabIndex = 17
        Me.dgBultosSeleccionados.TabStop = False
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.MaxInputLength = 20
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 80
        '
        'M_NSEQIN
        '
        Me.M_NSEQIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NSEQIN.DataPropertyName = "NSEQIN"
        Me.M_NSEQIN.HeaderText = "Nr. de Secuencia"
        Me.M_NSEQIN.Name = "M_NSEQIN"
        Me.M_NSEQIN.ReadOnly = True
        Me.M_NSEQIN.Width = 152
        '
        'M_QREFFW
        '
        Me.M_QREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QREFFW.DataPropertyName = "QREFFW"
        Me.M_QREFFW.HeaderText = "Cantidad"
        Me.M_QREFFW.Name = "M_QREFFW"
        Me.M_QREFFW.ReadOnly = True
        Me.M_QREFFW.Width = 102
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGEN.DataPropertyName = "TLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Destino"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        Me.M_TLUGEN.Width = 134
        '
        'M_NROPLT
        '
        Me.M_NROPLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NROPLT.DataPropertyName = "NROPLT"
        Me.M_NROPLT.HeaderText = "Nro. Paleta"
        Me.M_NROPLT.Name = "M_NROPLT"
        Me.M_NROPLT.ReadOnly = True
        Me.M_NROPLT.Width = 114
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 84)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(860, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.lblCriterioLote)
        Me.Panel1.Controls.Add(Me.txtCriterioLote)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.lblBulto)
        Me.Panel1.Controls.Add(Me.txtBulto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 84)
        Me.Panel1.TabIndex = 3
        '
        'lblCriterioLote
        '
        Me.lblCriterioLote.Location = New System.Drawing.Point(24, 16)
        Me.lblCriterioLote.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCriterioLote.Name = "lblCriterioLote"
        Me.lblCriterioLote.Size = New System.Drawing.Size(125, 24)
        Me.lblCriterioLote.TabIndex = 6
        Me.lblCriterioLote.Text = "Criterio de Lote : "
        Me.lblCriterioLote.Values.ExtraText = ""
        Me.lblCriterioLote.Values.Image = Nothing
        Me.lblCriterioLote.Values.Text = "Criterio de Lote : "
        '
        'txtCriterioLote
        '
        Me.txtCriterioLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCriterioLote, True)
        Me.txtCriterioLote.Location = New System.Drawing.Point(170, 13)
        Me.txtCriterioLote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCriterioLote.MaxLength = 15
        Me.txtCriterioLote.Name = "txtCriterioLote"
        Me.txtCriterioLote.Size = New System.Drawing.Size(233, 26)
        Me.txtCriterioLote.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(412, 16)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(82, 24)
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Text = "(Opcional)"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "(Opcional)"
        '
        'lblBulto
        '
        Me.lblBulto.Location = New System.Drawing.Point(24, 47)
        Me.lblBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBulto.Name = "lblBulto"
        Me.lblBulto.Size = New System.Drawing.Size(109, 24)
        Me.lblBulto.TabIndex = 9
        Me.lblBulto.Text = "Código Bulto : "
        Me.lblBulto.Values.ExtraText = ""
        Me.lblBulto.Values.Image = Nothing
        Me.lblBulto.Values.Text = "Código Bulto : "
        '
        'txtBulto
        '
        Me.txtBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBulto.Location = New System.Drawing.Point(170, 44)
        Me.txtBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBulto.MaxLength = 20
        Me.txtBulto.Name = "txtBulto"
        Me.txtBulto.Size = New System.Drawing.Size(233, 26)
        Me.txtBulto.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(267, 555)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(87, 44)
        Me.KryptonLabel2.TabIndex = 14
        Me.KryptonLabel2.Text = "Tipo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transporte:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tipo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transporte:"
        '
        'txtCantidadBultos
        '
        Me.txtCantidadBultos.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadBultos, True)
        Me.txtCantidadBultos.Location = New System.Drawing.Point(152, 578)
        Me.txtCantidadBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadBultos.Name = "txtCantidadBultos"
        Me.txtCantidadBultos.ReadOnly = True
        Me.txtCantidadBultos.Size = New System.Drawing.Size(107, 26)
        Me.txtCantidadBultos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadBultos.TabIndex = 12
        Me.txtCantidadBultos.TabStop = False
        Me.txtCantidadBultos.Text = "0"
        Me.txtCantidadBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadBultos, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadBultos
        '
        Me.lblCantidadBultos.Location = New System.Drawing.Point(19, 582)
        Me.lblCantidadBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadBultos.Name = "lblCantidadBultos"
        Me.lblCantidadBultos.Size = New System.Drawing.Size(122, 24)
        Me.lblCantidadBultos.TabIndex = 11
        Me.lblCantidadBultos.Text = "Cant. de Bultos : "
        Me.lblCantidadBultos.Values.ExtraText = ""
        Me.lblCantidadBultos.Values.Image = Nothing
        Me.lblCantidadBultos.Values.Text = "Cant. de Bultos : "
        '
        'txtNroBultos
        '
        Me.txtNroBultos.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtNroBultos, True)
        Me.txtNroBultos.Location = New System.Drawing.Point(152, 548)
        Me.txtNroBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroBultos.Name = "txtNroBultos"
        Me.txtNroBultos.ReadOnly = True
        Me.txtNroBultos.Size = New System.Drawing.Size(107, 26)
        Me.txtNroBultos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNroBultos.TabIndex = 10
        Me.txtNroBultos.TabStop = False
        Me.txtNroBultos.Text = "0"
        Me.txtNroBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtNroBultos, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNrosBultos
        '
        Me.lblNrosBultos.Location = New System.Drawing.Point(19, 551)
        Me.lblNrosBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNrosBultos.Name = "lblNrosBultos"
        Me.lblNrosBultos.Size = New System.Drawing.Size(123, 24)
        Me.lblNrosBultos.TabIndex = 9
        Me.lblNrosBultos.Text = "Nros. de Bultos : "
        Me.lblNrosBultos.Values.ExtraText = ""
        Me.lblNrosBultos.Values.Image = Nothing
        Me.lblNrosBultos.Values.Text = "Nros. de Bultos : "
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(545, 555)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(145, 47)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(699, 555)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(145, 47)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "QREFFW"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TLUGEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lugar Destino"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NROPLT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro. Paleta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo-Almacén-Zona"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ALLALMACEN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'ucWaybill_PreDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(860, 625)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ucWaybill_PreDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRE-DESPACHO"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgBultosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents txtNroBultos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNrosBultos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgBultosSeleccionados As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
