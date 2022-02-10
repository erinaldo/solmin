<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSavingAdvalorem
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
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.VisorRep = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnExportar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.lblBusqueda = New System.Windows.Forms.Label
    Me.pbxBuscar = New System.Windows.Forms.PictureBox
    Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.dtpFecFin = New System.Windows.Forms.DateTimePicker
    Me.dtpFecIni = New System.Windows.Forms.DateTimePicker
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.bgwProcesoReport = New System.ComponentModel.BackgroundWorker
    Me.cboTipoOperacion = New System.Windows.Forms.ComboBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.TabControl1)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(987, 588)
    Me.KryptonPanel.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 103)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(987, 485)
    Me.TabControl1.TabIndex = 16
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.VisorRep)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(979, 459)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Resultado"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'VisorRep
    '
    Me.VisorRep.ActiveViewIndex = -1
    Me.VisorRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.VisorRep.DisplayGroupTree = False
    Me.VisorRep.Dock = System.Windows.Forms.DockStyle.Fill
    Me.VisorRep.Location = New System.Drawing.Point(3, 3)
    Me.VisorRep.Name = "VisorRep"
    Me.VisorRep.SelectionFormula = ""
    Me.VisorRep.Size = New System.Drawing.Size(973, 453)
    Me.VisorRep.TabIndex = 13
    Me.VisorRep.ViewTimeSelectionFormula = ""
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator1, Me.btnExportar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 78)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(987, 25)
    Me.ToolStrip1.TabIndex = 15
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnBuscar
    '
    Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
    Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnBuscar.Text = "Buscar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnExportar
    '
    Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
    Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(70, 22)
    Me.btnExportar.Text = "Exportar"
    Me.btnExportar.Visible = False
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
    Me.KryptonHeaderGroup1.AutoSize = True
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.AutoScroll = True
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTipoOperacion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblBusqueda)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.pbxBuscar)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecFin)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecIni)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(987, 78)
    Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup1.TabIndex = 14
    Me.KryptonHeaderGroup1.Text = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'lblBusqueda
    '
    Me.lblBusqueda.AutoSize = True
    Me.lblBusqueda.BackColor = System.Drawing.Color.Transparent
    Me.lblBusqueda.Location = New System.Drawing.Point(657, 30)
    Me.lblBusqueda.Name = "lblBusqueda"
    Me.lblBusqueda.Size = New System.Drawing.Size(48, 13)
    Me.lblBusqueda.TabIndex = 79
    Me.lblBusqueda.Text = "Consulta"
    '
    'pbxBuscar
    '
    Me.pbxBuscar.BackColor = System.Drawing.Color.Transparent
    Me.pbxBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.mozilla_blu
    Me.pbxBuscar.Location = New System.Drawing.Point(722, 28)
    Me.pbxBuscar.Name = "pbxBuscar"
    Me.pbxBuscar.Size = New System.Drawing.Size(24, 21)
    Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pbxBuscar.TabIndex = 78
    Me.pbxBuscar.TabStop = False
    '
    'KryptonLabel24
    '
    Me.KryptonLabel24.Location = New System.Drawing.Point(9, 6)
    Me.KryptonLabel24.Name = "KryptonLabel24"
    Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
    Me.KryptonLabel24.TabIndex = 52
    Me.KryptonLabel24.Text = "Compañía:"
    Me.KryptonLabel24.Values.ExtraText = ""
    Me.KryptonLabel24.Values.Image = Nothing
    Me.KryptonLabel24.Values.Text = "Compañía:"
    '
    'cmbCompania
    '
    Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
    Me.cmbCompania.CCMPN_ANTERIOR = Nothing
    Me.cmbCompania.CCMPN_CodigoCompania = Nothing
    Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
    Me.cmbCompania.CCMPN_Descripcion = Nothing
    Me.cmbCompania.Location = New System.Drawing.Point(82, 3)
    Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
    Me.cmbCompania.Name = "cmbCompania"
    Me.cmbCompania.Size = New System.Drawing.Size(260, 23)
    Me.cmbCompania.TabIndex = 51
    Me.cmbCompania.Usuario = ""
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(500, 29)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(27, 19)
    Me.KryptonLabel2.TabIndex = 49
    Me.KryptonLabel2.Text = "Fin:"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Fin:"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(351, 30)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel1.TabIndex = 48
    Me.KryptonLabel1.Text = "Inicio:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Inicio:"
    '
    'lblCliente
    '
    Me.lblCliente.Location = New System.Drawing.Point(9, 32)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(47, 19)
    Me.lblCliente.TabIndex = 45
    Me.lblCliente.Text = "Cliente:"
    Me.lblCliente.Values.ExtraText = ""
    Me.lblCliente.Values.Image = Nothing
    Me.lblCliente.Values.Text = "Cliente:"
    '
    'cmbCliente
    '
    Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
    Me.cmbCliente.CCMPN = "EZ"
    Me.cmbCliente.Location = New System.Drawing.Point(82, 32)
    Me.cmbCliente.Name = "cmbCliente"
    Me.cmbCliente.pAccesoPorUsuario = True
    Me.cmbCliente.pRequerido = True
    Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.cmbCliente.Size = New System.Drawing.Size(260, 21)
    Me.cmbCliente.TabIndex = 40
    '
    'dtpFecFin
    '
    Me.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White
    Me.dtpFecFin.CalendarTitleForeColor = System.Drawing.Color.White
    Me.dtpFecFin.CustomFormat = "MM/yyyy"
    Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecFin.Location = New System.Drawing.Point(544, 29)
    Me.dtpFecFin.Name = "dtpFecFin"
    Me.dtpFecFin.Size = New System.Drawing.Size(91, 20)
    Me.dtpFecFin.TabIndex = 13
    '
    'dtpFecIni
    '
    Me.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White
    Me.dtpFecIni.CalendarTitleForeColor = System.Drawing.Color.White
    Me.dtpFecIni.CustomFormat = "MM/yyyy"
    Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecIni.Location = New System.Drawing.Point(396, 29)
    Me.dtpFecIni.Name = "dtpFecIni"
    Me.dtpFecIni.Size = New System.Drawing.Size(93, 20)
    Me.dtpFecIni.TabIndex = 5
    '
    'bgwProcesoReport
    '
    '
    'cboTipoOperacion
    '
    Me.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoOperacion.FormattingEnabled = True
    Me.cboTipoOperacion.Location = New System.Drawing.Point(396, 5)
    Me.cboTipoOperacion.Name = "cboTipoOperacion"
    Me.cboTipoOperacion.Size = New System.Drawing.Size(131, 21)
    Me.cboTipoOperacion.TabIndex = 81
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(352, 5)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(38, 19)
    Me.KryptonLabel3.TabIndex = 80
    Me.KryptonLabel3.Text = "Tipo :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Tipo :"
    '
    'frmRptSavingAdvalorem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(987, 588)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmRptSavingAdvalorem"
    Me.Text = "Saving Advalorem"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents VisorRep As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents lblBusqueda As System.Windows.Forms.Label
  Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
  Friend WithEvents bgwProcesoReport As System.ComponentModel.BackgroundWorker
  Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
