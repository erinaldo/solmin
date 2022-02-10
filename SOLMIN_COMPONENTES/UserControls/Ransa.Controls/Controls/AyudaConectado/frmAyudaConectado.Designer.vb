<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyudaConectado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAyudaConectado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboCriterio = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.tsMenuNavegacion = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.lblDato = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgData = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.chkFiltrar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuNavegacion.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtDato)
        Me.KryptonPanel.Controls.Add(Me.cboCriterio)
        Me.KryptonPanel.Controls.Add(Me.tsMenuNavegacion)
        Me.KryptonPanel.Controls.Add(Me.lblDato)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(388, 313)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(91, 62)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(219, 22)
        Me.txtDato.TabIndex = 18
        Me.txtDato.Text = " "
        '
        'cboCriterio
        '
        Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriterio.DropDownWidth = 198
        Me.cboCriterio.FormattingEnabled = False
        Me.cboCriterio.ItemHeight = 15
        Me.cboCriterio.Location = New System.Drawing.Point(91, 39)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(219, 23)
        Me.cboCriterio.TabIndex = 17
        '
        'tsMenuNavegacion
        '
        Me.tsMenuNavegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuNavegacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator8, Me.btnAceptar, Me.ToolStripSeparator7})
        Me.tsMenuNavegacion.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuNavegacion.Name = "tsMenuNavegacion"
        Me.tsMenuNavegacion.Size = New System.Drawing.Size(388, 25)
        Me.tsMenuNavegacion.TabIndex = 29
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'lblDato
        '
        Me.lblDato.Location = New System.Drawing.Point(12, 64)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(43, 20)
        Me.lblDato.TabIndex = 19
        Me.lblDato.Text = "Dato :"
        Me.lblDato.Values.ExtraText = ""
        Me.lblDato.Values.Image = Nothing
        Me.lblDato.Values.Text = "Dato :"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.Location = New System.Drawing.Point(12, 42)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(52, 20)
        Me.lblBusqueda.TabIndex = 16
        Me.lblBusqueda.Text = "Buscar :"
        Me.lblBusqueda.Values.ExtraText = ""
        Me.lblBusqueda.Values.Image = Nothing
        Me.lblBusqueda.Values.Text = "Buscar :"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtgData)
        Me.KryptonPanel1.Controls.Add(Me.UcPaginacion1)
        Me.KryptonPanel1.Controls.Add(Me.chkFiltrar)
        Me.KryptonPanel1.Controls.Add(Me.lblBusqueda)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(388, 313)
        Me.KryptonPanel1.TabIndex = 30
        '
        'dtgData
        '
        Me.dtgData.AllowUserToAddRows = False
        Me.dtgData.AllowUserToDeleteRows = False
        Me.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgData.Location = New System.Drawing.Point(0, 90)
        Me.dtgData.Name = "dtgData"
        Me.dtgData.ReadOnly = True
        Me.dtgData.Size = New System.Drawing.Size(388, 198)
        Me.dtgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgData.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgData.TabIndex = 13
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 288)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(388, 25)
        Me.UcPaginacion1.TabIndex = 31
        '
        'chkFiltrar
        '
        Me.chkFiltrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrar.Location = New System.Drawing.Point(316, 62)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(55, 20)
        Me.chkFiltrar.TabIndex = 20
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.Values.ExtraText = ""
        Me.chkFiltrar.Values.Image = Nothing
        Me.chkFiltrar.Values.Text = "Filtrar"
        '
        'frmAyudaConectado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 313)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAyudaConectado"
        Me.Text = " "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuNavegacion.ResumeLayout(False)
        Me.tsMenuNavegacion.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboCriterio As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblBusqueda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgData As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuNavegacion As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
End Class
