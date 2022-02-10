<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionVehicular
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separador = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCNFVH = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TDSCM1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QCRUTV = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    CType(Me.gwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.gwDatos)
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(341, 286)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 0
    '
    'gwDatos
    '
    Me.gwDatos.AllowUserToAddRows = False
    Me.gwDatos.AllowUserToDeleteRows = False
    Me.gwDatos.AllowUserToOrderColumns = True
    Me.gwDatos.AllowUserToResizeRows = False
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.gwDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
    Me.gwDatos.ColumnHeadersHeight = 30
    Me.gwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCNFVH, Me.TDSCM1, Me.QCRUTV})
    Me.gwDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwDatos.Location = New System.Drawing.Point(0, 25)
    Me.gwDatos.MultiSelect = False
    Me.gwDatos.Name = "gwDatos"
    Me.gwDatos.ReadOnly = True
    Me.gwDatos.RowHeadersVisible = False
    Me.gwDatos.RowHeadersWidth = 20
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.gwDatos.RowsDefaultCellStyle = DataGridViewCellStyle4
    Me.gwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwDatos.Size = New System.Drawing.Size(341, 261)
    Me.gwDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwDatos.TabIndex = 52
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(341, 25)
    Me.MenuBar.TabIndex = 6
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'Separador
    '
    Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.Separador.Name = "Separador"
    Me.Separador.Size = New System.Drawing.Size(6, 25)
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(64, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "TCNFVH"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Configuración"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.Width = 101
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "TDSCM1"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "QCRUTV"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Carga Útil"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.Width = 82
    '
    'TCNFVH
    '
    Me.TCNFVH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TCNFVH.DataPropertyName = "TCNFVH"
    Me.TCNFVH.HeaderText = "Configuración"
    Me.TCNFVH.Name = "TCNFVH"
    Me.TCNFVH.ReadOnly = True
    Me.TCNFVH.Width = 101
    '
    'TDSCM1
    '
    Me.TDSCM1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TDSCM1.DataPropertyName = "TDSCM1"
    Me.TDSCM1.HeaderText = "Descripción"
    Me.TDSCM1.Name = "TDSCM1"
    Me.TDSCM1.ReadOnly = True
    '
    'QCRUTV
    '
    Me.QCRUTV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.QCRUTV.DataPropertyName = "QCRUTV"
    Me.QCRUTV.HeaderText = "Carga Útil"
    Me.QCRUTV.Name = "QCRUTV"
    Me.QCRUTV.ReadOnly = True
    Me.QCRUTV.Width = 82
    '
    'frmConfiguracionVehicular
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(341, 286)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmConfiguracionVehicular"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Configuración Vehicular"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    CType(Me.gwDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents gwDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents TCNFVH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TDSCM1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QCRUTV As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
