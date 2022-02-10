<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroWAP
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
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CICLO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCOEVT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMEV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FRGTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRGTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnReiniciarCiclo = New System.Windows.Forms.ToolStripButton
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CICLO, Me.NPLCTR, Me.NCOEVT, Me.TNMEV, Me.FRGTRO, Me.HRGTRO, Me.TOBS, Me.CULUSA})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gwdDatos.Location = New System.Drawing.Point(0, 24)
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(654, 452)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 7
        '
        'CICLO
        '
        Me.CICLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CICLO.DataPropertyName = "CICLO"
        Me.CICLO.HeaderText = "N° Ciclo"
        Me.CICLO.Name = "CICLO"
        Me.CICLO.ReadOnly = True
        Me.CICLO.Width = 76
        '
        'NPLCTR
        '
        Me.NPLCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCTR.DataPropertyName = "NPLCTR"
        Me.NPLCTR.HeaderText = "Tracto"
        Me.NPLCTR.Name = "NPLCTR"
        Me.NPLCTR.ReadOnly = True
        Me.NPLCTR.Width = 67
        '
        'NCOEVT
        '
        Me.NCOEVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCOEVT.HeaderText = "Cod. Evento"
        Me.NCOEVT.Name = "NCOEVT"
        Me.NCOEVT.ReadOnly = True
        Me.NCOEVT.Visible = False
        Me.NCOEVT.Width = 98
        '
        'TNMEV
        '
        Me.TNMEV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMEV.DataPropertyName = "TNMEV"
        Me.TNMEV.HeaderText = "Nombre Evento"
        Me.TNMEV.Name = "TNMEV"
        Me.TNMEV.ReadOnly = True
        Me.TNMEV.Width = 115
        '
        'FRGTRO
        '
        Me.FRGTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FRGTRO.DataPropertyName = "FRGTRO"
        Me.FRGTRO.HeaderText = "Fecha Registro"
        Me.FRGTRO.Name = "FRGTRO"
        Me.FRGTRO.ReadOnly = True
        Me.FRGTRO.Width = 112
        '
        'HRGTRO
        '
        Me.HRGTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRGTRO.DataPropertyName = "HRGTRO"
        Me.HRGTRO.HeaderText = "Hora Registro"
        Me.HRGTRO.Name = "HRGTRO"
        Me.HRGTRO.ReadOnly = True
        Me.HRGTRO.Width = 107
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observación"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'CULUSA
        '
        Me.CULUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "Auditoría"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.ReadOnly = True
        Me.CULUSA.Width = 84
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificar, Me.btnReiniciarCiclo, Me.btnSalir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(654, 25)
        Me.MenuBar.TabIndex = 111
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(69, 22)
        Me.btnModificar.Text = " Asignar"
        '
        'btnReiniciarCiclo
        '
        Me.btnReiniciarCiclo.Image = Global.SOLMIN_ST.My.Resources.Resources.runprog
        Me.btnReiniciarCiclo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReiniciarCiclo.Name = "btnReiniciarCiclo"
        Me.btnReiniciarCiclo.Size = New System.Drawing.Size(105, 22)
        Me.btnReiniciarCiclo.Text = "  Reiniciar Ciclo"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = " Salir"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.MenuBar)
        Me.KryptonPanel1.Controls.Add(Me.gwdDatos)
        Me.KryptonPanel1.Controls.Add(Me.btnCerrar)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(654, 476)
        Me.KryptonPanel1.TabIndex = 112
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(541, 86)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 8)
        Me.btnCerrar.TabIndex = 112
        Me.btnCerrar.Text = "Cerrar Ventana"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "Cerrar Ventana"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CICLO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Ciclo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NPLCTR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tracto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cod. Evento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TNMEV"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Evento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FRGTRO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Registro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HRGTRO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hora Registro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'frmRegistroWAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(654, 476)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(660, 500)
        Me.MinimumSize = New System.Drawing.Size(660, 500)
        Me.Name = "frmRegistroWAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro WAP"
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByVal lp_NPLCUN As String)
        If lp_NPLCUN = "" Then Exit Sub
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vNPLCUN = lp_NPLCUN.Trim
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnReiniciarCiclo As System.Windows.Forms.ToolStripButton
  Friend WithEvents CICLO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCOEVT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TNMEV As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FRGTRO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HRGTRO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
