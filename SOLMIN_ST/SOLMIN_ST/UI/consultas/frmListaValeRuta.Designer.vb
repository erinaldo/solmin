<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaValeRuta
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.panelVales = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwListaValesRuta = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.C_NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_NVLGRF = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_FCRCMB_S = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_CTPCMB = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_QGLNCM = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_CSTGLN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_ICSTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_CGRFO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.C_NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.panelVales, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panelVales.SuspendLayout()
    CType(Me.gwListaValesRuta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panelVales
    '
    Me.panelVales.Controls.Add(Me.gwListaValesRuta)
    Me.panelVales.Controls.Add(Me.MenuBar)
    Me.panelVales.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panelVales.Location = New System.Drawing.Point(0, 0)
    Me.panelVales.Name = "panelVales"
    Me.panelVales.Size = New System.Drawing.Size(694, 317)
    Me.panelVales.TabIndex = 0
    '
    'gwListaValesRuta
    '
    Me.gwListaValesRuta.AllowUserToAddRows = False
    Me.gwListaValesRuta.AllowUserToDeleteRows = False
    Me.gwListaValesRuta.AllowUserToOrderColumns = True
    Me.gwListaValesRuta.ColumnHeadersHeight = 30
    Me.gwListaValesRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwListaValesRuta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_NOPRCN, Me.C_NVLGRF, Me.C_FCRCMB_S, Me.C_CTPCMB, Me.C_QGLNCM, Me.C_CSTGLN, Me.C_ICSTOS, Me.C_CGRFO, Me.C_CBRCND, Me.C_NRUCTR})
    Me.gwListaValesRuta.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwListaValesRuta.Location = New System.Drawing.Point(0, 25)
    Me.gwListaValesRuta.Name = "gwListaValesRuta"
    Me.gwListaValesRuta.ReadOnly = True
    Me.gwListaValesRuta.RowHeadersVisible = False
    Me.gwListaValesRuta.RowHeadersWidth = 30
    Me.gwListaValesRuta.Size = New System.Drawing.Size(694, 292)
    Me.gwListaValesRuta.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwListaValesRuta.TabIndex = 1
    '
    'C_NOPRCN
    '
    Me.C_NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_NOPRCN.DataPropertyName = "NOPRCN"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.C_NOPRCN.DefaultCellStyle = DataGridViewCellStyle1
    Me.C_NOPRCN.HeaderText = "N° Operación"
    Me.C_NOPRCN.Name = "C_NOPRCN"
    Me.C_NOPRCN.ReadOnly = True
    Me.C_NOPRCN.Width = 105
    '
    'C_NVLGRF
    '
    Me.C_NVLGRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_NVLGRF.DataPropertyName = "NVLGRF"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.C_NVLGRF.DefaultCellStyle = DataGridViewCellStyle2
    Me.C_NVLGRF.HeaderText = "N° Vale"
    Me.C_NVLGRF.Name = "C_NVLGRF"
    Me.C_NVLGRF.ReadOnly = True
    Me.C_NVLGRF.Width = 73
    '
    'C_FCRCMB_S
    '
    Me.C_FCRCMB_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_FCRCMB_S.DataPropertyName = "FCRCMB_S"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.C_FCRCMB_S.DefaultCellStyle = DataGridViewCellStyle3
    Me.C_FCRCMB_S.HeaderText = "F. Carga Combustible"
    Me.C_FCRCMB_S.Name = "C_FCRCMB_S"
    Me.C_FCRCMB_S.ReadOnly = True
    Me.C_FCRCMB_S.Width = 146
    '
    'C_CTPCMB
    '
    Me.C_CTPCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_CTPCMB.DataPropertyName = "CTPCMB"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.C_CTPCMB.DefaultCellStyle = DataGridViewCellStyle4
    Me.C_CTPCMB.HeaderText = "Tipo Combustible"
    Me.C_CTPCMB.Name = "C_CTPCMB"
    Me.C_CTPCMB.ReadOnly = True
    Me.C_CTPCMB.Width = 126
    '
    'C_QGLNCM
    '
    Me.C_QGLNCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_QGLNCM.DataPropertyName = "QGLNCM"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle5.Format = "N2"
    DataGridViewCellStyle5.NullValue = "0.00"
    Me.C_QGLNCM.DefaultCellStyle = DataGridViewCellStyle5
    Me.C_QGLNCM.HeaderText = "Galones Combustible"
    Me.C_QGLNCM.Name = "C_QGLNCM"
    Me.C_QGLNCM.ReadOnly = True
    Me.C_QGLNCM.Width = 146
    '
    'C_CSTGLN
    '
    Me.C_CSTGLN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_CSTGLN.DataPropertyName = "CSTGLN"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle6.Format = "N2"
    DataGridViewCellStyle6.NullValue = "0.00"
    Me.C_CSTGLN.DefaultCellStyle = DataGridViewCellStyle6
    Me.C_CSTGLN.HeaderText = "Precio x Galón  (S/.)"
    Me.C_CSTGLN.Name = "C_CSTGLN"
    Me.C_CSTGLN.ReadOnly = True
    Me.C_CSTGLN.Width = 134
    '
    'C_ICSTOS
    '
    Me.C_ICSTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_ICSTOS.DataPropertyName = "ICSTOS"
    Me.C_ICSTOS.HeaderText = "Importe Total"
    Me.C_ICSTOS.Name = "C_ICSTOS"
    Me.C_ICSTOS.ReadOnly = True
    Me.C_ICSTOS.Visible = False
    Me.C_ICSTOS.Width = 104
    '
    'C_CGRFO
    '
    Me.C_CGRFO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.C_CGRFO.DataPropertyName = "CGRFO"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.C_CGRFO.DefaultCellStyle = DataGridViewCellStyle7
    Me.C_CGRFO.HeaderText = "Código Grifo"
    Me.C_CGRFO.Name = "C_CGRFO"
    Me.C_CGRFO.ReadOnly = True
    Me.C_CGRFO.Visible = False
    Me.C_CGRFO.Width = 103
    '
    'C_CBRCND
    '
    Me.C_CBRCND.DataPropertyName = "CBRCND"
    Me.C_CBRCND.HeaderText = "Brevete"
    Me.C_CBRCND.Name = "C_CBRCND"
    Me.C_CBRCND.ReadOnly = True
    Me.C_CBRCND.Visible = False
    '
    'C_NRUCTR
    '
    Me.C_NRUCTR.DataPropertyName = "NRUCTR"
    Me.C_NRUCTR.HeaderText = "RUC"
    Me.C_NRUCTR.Name = "C_NRUCTR"
    Me.C_NRUCTR.ReadOnly = True
    Me.C_NRUCTR.Visible = False
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(694, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(74, 22)
    Me.btnCancelar.Text = " Cancelar"
    '
    'Separator1
    '
    Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.Separator1.Name = "Separator1"
    Me.Separator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(69, 22)
    Me.btnAceptar.Text = " Aceptar"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOPRCN"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
    Me.DataGridViewTextBoxColumn1.HeaderText = "N° Operación"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "NVLGRF"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
    Me.DataGridViewTextBoxColumn2.HeaderText = "N° Vale"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "FCRCMB"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
    Me.DataGridViewTextBoxColumn3.HeaderText = "F. Carga Combustible"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "CTPCMB"
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle11
    Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo Combustible"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "QGLNCM"
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle12.Format = "N2"
    DataGridViewCellStyle12.NullValue = "0.00"
    Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle12
    Me.DataGridViewTextBoxColumn5.HeaderText = "Galones Combustible"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "CSTGLN"
    DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle13.Format = "N2"
    DataGridViewCellStyle13.NullValue = "0.00"
    Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle13
    Me.DataGridViewTextBoxColumn6.HeaderText = "Precio x Galón  (S/.)"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "ICSTOS"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Importe Total"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    Me.DataGridViewTextBoxColumn7.Visible = False
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CGRFO"
    DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle14
    Me.DataGridViewTextBoxColumn8.HeaderText = "Código Grifo"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    Me.DataGridViewTextBoxColumn8.Visible = False
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "CBRCND"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Brevete"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    Me.DataGridViewTextBoxColumn9.Visible = False
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "NRUCTR"
    Me.DataGridViewTextBoxColumn10.HeaderText = "RUC"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    Me.DataGridViewTextBoxColumn10.Visible = False
    '
    'frmListaValeRuta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(694, 317)
    Me.ControlBox = False
    Me.Controls.Add(Me.panelVales)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmListaValeRuta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Lista Vales Ruta"
    CType(Me.panelVales, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panelVales.ResumeLayout(False)
    Me.panelVales.PerformLayout()
    CType(Me.gwListaValesRuta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panelVales As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents gwListaValesRuta As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_NVLGRF As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_FCRCMB_S As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_CTPCMB As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_QGLNCM As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_CSTGLN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_ICSTOS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_CGRFO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents C_NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
