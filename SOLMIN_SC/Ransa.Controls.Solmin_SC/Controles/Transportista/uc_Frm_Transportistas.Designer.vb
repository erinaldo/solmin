<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Frm_Transportistas
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
        Me.components = New System.ComponentModel.Container
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgvTransportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRUC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvTransportista)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(497, 414)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvTransportista
        '
        Me.dgvTransportista.AllowUserToAddRows = False
        Me.dgvTransportista.AllowUserToDeleteRows = False
        Me.dgvTransportista.AllowUserToResizeColumns = False
        Me.dgvTransportista.AllowUserToResizeRows = False
        Me.dgvTransportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTransportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTRSPT, Me.NRUCTR, Me.TCMTRT})
        Me.dgvTransportista.DataMember = "dtCliente"
        Me.dgvTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransportista.Location = New System.Drawing.Point(0, 122)
        Me.dgvTransportista.MultiSelect = False
        Me.dgvTransportista.Name = "dgvTransportista"
        Me.dgvTransportista.ReadOnly = True
        Me.dgvTransportista.RowHeadersWidth = 20
        Me.dgvTransportista.RowTemplate.ReadOnly = True
        Me.dgvTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTransportista.Size = New System.Drawing.Size(497, 267)
        Me.dgvTransportista.StandardTab = True
        Me.dgvTransportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvTransportista.TabIndex = 43
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "PNCTRSPT"
        Me.CTRSPT.HeaderText = "Codigo"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Width = 74
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "PSNRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 58
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMTRT.DataPropertyName = "PSTCMTRT"
        Me.TCMTRT.HeaderText = "Descripción"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 389)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(497, 25)
        Me.UcPaginacion.TabIndex = 42
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 97)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(497, 25)
        Me.ToolStrip1.TabIndex = 41
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripLabel1.Text = "TRANSPORTISTA"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnSalir)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCodigo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblCodigo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtRUC)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblDescripcion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblRUC)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonGroup1.Size = New System.Drawing.Size(497, 97)
        Me.KryptonGroup1.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(425, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 25)
        Me.btnSalir.TabIndex = 91
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.CausesValidation = False
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(99, 7)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(306, 21)
        Me.txtCodigo.TabIndex = 84
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(11, 7)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(54, 16)
        Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.TabIndex = 83
        Me.lblCodigo.Text = "CODIGO : "
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "CODIGO : "
        '
        'txtRUC
        '
        Me.txtRUC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUC.CausesValidation = False
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Location = New System.Drawing.Point(99, 34)
        Me.txtRUC.MaxLength = 40
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(306, 21)
        Me.txtRUC.TabIndex = 88
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(11, 62)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.TabIndex = 85
        Me.lblDescripcion.Text = "DESCRIPCIÓN : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
        '
        'lblRUC
        '
        Me.lblRUC.Location = New System.Drawing.Point(11, 34)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(44, 16)
        Me.lblRUC.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRUC.TabIndex = 87
        Me.lblRUC.Text = "R.U.C. :"
        Me.lblRUC.Values.ExtraText = ""
        Me.lblRUC.Values.Image = Nothing
        Me.lblRUC.Values.Text = "R.U.C. :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CausesValidation = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(99, 62)
        Me.txtDescripcion.MaxLength = 15
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 21)
        Me.txtDescripcion.TabIndex = 86
        '
        'uc_Frm_Transportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximumSize = New System.Drawing.Size(505, 448)
        Me.MinimumSize = New System.Drawing.Size(505, 448)
        Me.Name = "uc_Frm_Transportistas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda Transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgvTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblRUC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgvTransportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
