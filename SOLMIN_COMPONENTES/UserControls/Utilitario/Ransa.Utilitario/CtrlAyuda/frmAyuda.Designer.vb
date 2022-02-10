<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
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
        Me.dtgData = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.txtTitulo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.chkFiltrar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cmdAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDato = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgData)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(431, 419)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgData
        '
        Me.dtgData.AllowUserToAddRows = False
        Me.dtgData.AllowUserToDeleteRows = False
        Me.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgData.Location = New System.Drawing.Point(0, 111)
        Me.dtgData.Name = "dtgData"
        Me.dtgData.ReadOnly = True
        Me.dtgData.Size = New System.Drawing.Size(431, 308)
        Me.dtgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgData.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgData.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtTitulo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 86)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(431, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(59, 22)
        Me.txtTitulo.Text = "Búsqueda"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.chkFiltrar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmdAceptar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblBusqueda)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCodigo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblDato)
        Me.KryptonGroup1.Size = New System.Drawing.Size(431, 86)
        Me.KryptonGroup1.TabIndex = 23
        '
        'chkFiltrar
        '
        Me.chkFiltrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrar.Location = New System.Drawing.Point(105, 60)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(55, 20)
        Me.chkFiltrar.TabIndex = 2
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.Values.ExtraText = ""
        Me.chkFiltrar.Values.Image = Nothing
        Me.chkFiltrar.Values.Text = "Filtrar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(321, 56)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(73, 25)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Cerrar"
        Me.cmdAceptar.Values.ExtraText = ""
        Me.cmdAceptar.Values.Image = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdAceptar.Values.Text = "Cerrar"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2
        Me.lblBusqueda.Location = New System.Drawing.Point(11, 9)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(60, 20)
        Me.lblBusqueda.TabIndex = 16
        Me.lblBusqueda.Text = "Código  :"
        Me.lblBusqueda.Values.ExtraText = ""
        Me.lblBusqueda.Values.Image = Nothing
        Me.lblBusqueda.Values.Text = "Código  :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(105, 7)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(289, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(105, 33)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(289, 22)
        Me.txtDato.TabIndex = 1
        '
        'lblDato
        '
        Me.lblDato.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2
        Me.lblDato.Location = New System.Drawing.Point(11, 33)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(80, 20)
        Me.lblDato.TabIndex = 19
        Me.lblDato.Text = "Descripción :"
        Me.lblDato.Values.ExtraText = ""
        Me.lblDato.Values.Image = Nothing
        Me.lblDato.Values.Text = "Descripción :"
        '
        'frmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 419)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chkFiltrar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblDato As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblBusqueda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgData As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmdAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtTitulo As System.Windows.Forms.ToolStripLabel
End Class
