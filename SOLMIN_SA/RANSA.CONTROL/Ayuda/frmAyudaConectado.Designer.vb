<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaConectado
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
        Me.UcPaginacion1 = New RANSA.Utilitario.UCPaginacion
        Me.chkFiltrar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblDato = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboCriterio = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgData)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion1)
        Me.KryptonPanel.Controls.Add(Me.chkFiltrar)
        Me.KryptonPanel.Controls.Add(Me.lblDato)
        Me.KryptonPanel.Controls.Add(Me.txtDato)
        Me.KryptonPanel.Controls.Add(Me.cboCriterio)
        Me.KryptonPanel.Controls.Add(Me.lblBusqueda)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(388, 340)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgData
        '
        Me.dtgData.AllowUserToAddRows = False
        Me.dtgData.AllowUserToDeleteRows = False
        Me.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgData.Location = New System.Drawing.Point(0, 67)
        Me.dtgData.Name = "dtgData"
        Me.dtgData.ReadOnly = True
        Me.dtgData.Size = New System.Drawing.Size(388, 248)
        Me.dtgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgData.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgData.TabIndex = 13
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 315)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(388, 25)
        Me.UcPaginacion1.TabIndex = 21
        '
        'chkFiltrar
        '
        Me.chkFiltrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrar.Location = New System.Drawing.Point(308, 33)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(52, 19)
        Me.chkFiltrar.TabIndex = 20
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.Values.ExtraText = ""
        Me.chkFiltrar.Values.Image = Nothing
        Me.chkFiltrar.Values.Text = "Filtrar"
        '
        'lblDato
        '
        Me.lblDato.Location = New System.Drawing.Point(1, 32)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(40, 19)
        Me.lblDato.TabIndex = 19
        Me.lblDato.Text = "Dato :"
        Me.lblDato.Values.ExtraText = ""
        Me.lblDato.Values.Image = Nothing
        Me.lblDato.Values.Text = "Dato :"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(92, 30)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(198, 21)
        Me.txtDato.TabIndex = 18
        Me.txtDato.Text = " "
        '
        'cboCriterio
        '
        Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriterio.DropDownWidth = 198
        Me.cboCriterio.FormattingEnabled = False
        Me.cboCriterio.ItemHeight = 13
        Me.cboCriterio.Location = New System.Drawing.Point(92, 7)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(198, 21)
        Me.cboCriterio.TabIndex = 17
        '
        'lblBusqueda
        '
        Me.lblBusqueda.Location = New System.Drawing.Point(1, 10)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(48, 19)
        Me.lblBusqueda.TabIndex = 16
        Me.lblBusqueda.Text = "Buscar :"
        Me.lblBusqueda.Values.ExtraText = ""
        Me.lblBusqueda.Values.Image = Nothing
        Me.lblBusqueda.Values.Text = "Buscar :"
        '
        'frmBusquedaConectado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 340)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaConectado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents UcPaginacion1 As RANSA.Utilitario.UCPaginacion
End Class
