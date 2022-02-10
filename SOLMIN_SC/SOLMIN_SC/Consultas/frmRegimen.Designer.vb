<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegimen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.mnuCabecera = New System.Windows.Forms.ToolStrip
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgvDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPSRVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNTPORGE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMRGA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.mnuCabecera.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvDatos)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.mnuCabecera)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(648, 380)
        Me.KryptonPanel.TabIndex = 0
        '
        'mnuCabecera
        '
        Me.mnuCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mnuCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mnuCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.btnAceptar})
        Me.mnuCabecera.Location = New System.Drawing.Point(0, 0)
        Me.mnuCabecera.Name = "mnuCabecera"
        Me.mnuCabecera.Size = New System.Drawing.Size(648, 25)
        Me.mnuCabecera.TabIndex = 37
        Me.mnuCabecera.Text = "ToolStrip2"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtBusqueda)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(648, 52)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 40
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Información"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel24.TabIndex = 54
        Me.KryptonLabel24.Text = "Régimen:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Régimen:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSTPSRVA, Me.PNTPORGE, Me.PSTCMRGA})
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDatos.Location = New System.Drawing.Point(0, 77)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersWidth = 10
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(648, 303)
        Me.dgvDatos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvDatos.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dgvDatos.TabIndex = 41
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(66, 9)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(470, 20)
        Me.txtBusqueda.TabIndex = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTPSRVA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PNTPORGE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 74
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSTCMRGA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Régimen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'PSTPSRVA
        '
        Me.PSTPSRVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTPSRVA.DataPropertyName = "PSTPSRVA"
        Me.PSTPSRVA.HeaderText = "Tipo"
        Me.PSTPSRVA.Name = "PSTPSRVA"
        Me.PSTPSRVA.ReadOnly = True
        Me.PSTPSRVA.Width = 58
        '
        'PNTPORGE
        '
        Me.PNTPORGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNTPORGE.DataPropertyName = "PNTPORGE"
        Me.PNTPORGE.HeaderText = "Código"
        Me.PNTPORGE.Name = "PNTPORGE"
        Me.PNTPORGE.ReadOnly = True
        Me.PNTPORGE.Width = 74
        '
        'PSTCMRGA
        '
        Me.PSTCMRGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTCMRGA.DataPropertyName = "PSTCMRGA"
        Me.PSTCMRGA.HeaderText = "Régimen"
        Me.PSTCMRGA.Name = "PSTCMRGA"
        Me.PSTCMRGA.ReadOnly = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(71, 22)
        Me.btnCerrar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmRegimen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 380)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRegimen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "REGÍMENES"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.mnuCabecera.ResumeLayout(False)
        Me.mnuCabecera.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mnuCabecera As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PSTPSRVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNTPORGE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMRGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
