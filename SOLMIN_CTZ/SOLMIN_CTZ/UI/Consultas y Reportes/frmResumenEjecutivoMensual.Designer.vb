<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenEjecutivoMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenEjecutivoMensual))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnReporte = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.pbxBuscar = New System.Windows.Forms.PictureBox
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.dbMes = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ndAnio = New System.Windows.Forms.NumericUpDown
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalle.Panel.SuspendLayout()
        Me.HGDetalle.SuspendLayout()
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGDetalle)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1139, 448)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGDetalle
        '
        Me.HGDetalle.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnReporte})
        Me.HGDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGDetalle.HeaderVisibleSecondary = False
        Me.HGDetalle.Location = New System.Drawing.Point(0, 112)
        Me.HGDetalle.Name = "HGDetalle"
        '
        'HGDetalle.Panel
        '
        Me.HGDetalle.Panel.Controls.Add(Me.pbxBuscar)
        Me.HGDetalle.Panel.Controls.Add(Me.ReportViewer)
        Me.HGDetalle.Size = New System.Drawing.Size(1139, 336)
        Me.HGDetalle.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGDetalle.TabIndex = 2
        Me.HGDetalle.Text = "Resultados"
        Me.HGDetalle.ValuesPrimary.Description = ""
        Me.HGDetalle.ValuesPrimary.Heading = "Resultados"
        Me.HGDetalle.ValuesPrimary.Image = Nothing
        Me.HGDetalle.ValuesSecondary.Description = ""
        Me.HGDetalle.ValuesSecondary.Heading = "Description"
        Me.HGDetalle.ValuesSecondary.Image = Nothing
        '
        'btnReporte
        '
        Me.btnReporte.ExtraText = ""
        Me.btnReporte.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnReporte.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.ToolTipImage = Nothing
        Me.btnReporte.UniqueName = "E00F1F88311147C4E00F1F88311147C4"
        '
        'pbxBuscar
        '
        Me.pbxBuscar.BackColor = System.Drawing.Color.White
        Me.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxBuscar.Enabled = False
        Me.pbxBuscar.Image = CType(resources.GetObject("pbxBuscar.Image"), System.Drawing.Image)
        Me.pbxBuscar.ImageLocation = ""
        Me.pbxBuscar.InitialImage = Nothing
        Me.pbxBuscar.Location = New System.Drawing.Point(0, 0)
        Me.pbxBuscar.Name = "pbxBuscar"
        Me.pbxBuscar.Size = New System.Drawing.Size(1137, 307)
        Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBuscar.TabIndex = 15
        Me.pbxBuscar.TabStop = False
        Me.pbxBuscar.Visible = False
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(1137, 307)
        Me.ReportViewer.TabIndex = 18
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonPanel1)
        Me.HGFiltro.Panel.Controls.Add(Me.lblCompania)
        Me.HGFiltro.Size = New System.Drawing.Size(1139, 112)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 1
        Me.HGFiltro.Text = "Opciones de Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Opciones de Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.UcCompania)
        Me.KryptonPanel1.Controls.Add(Me.dbMes)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.ndAnio)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.UcCliente)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1137, 93)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 38
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Location = New System.Drawing.Point(83, 12)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        Me.UcCompania.Size = New System.Drawing.Size(297, 23)
        Me.UcCompania.TabIndex = 131
        Me.UcCompania.Usuario = ""
        '
        'dbMes
        '
        Me.dbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMes.FormattingEnabled = True
        Me.dbMes.Location = New System.Drawing.Point(689, 51)
        Me.dbMes.Name = "dbMes"
        Me.dbMes.Size = New System.Drawing.Size(113, 21)
        Me.dbMes.TabIndex = 129
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(642, 51)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(32, 16)
        Me.KryptonLabel3.TabIndex = 128
        Me.KryptonLabel3.Text = "Mes "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Mes "
        '
        'ndAnio
        '
        Me.ndAnio.Location = New System.Drawing.Point(556, 51)
        Me.ndAnio.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.ndAnio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ndAnio.Name = "ndAnio"
        Me.ndAnio.ReadOnly = True
        Me.ndAnio.Size = New System.Drawing.Size(53, 20)
        Me.ndAnio.TabIndex = 127
        Me.ndAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ndAnio.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(493, 51)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(30, 16)
        Me.KryptonLabel6.TabIndex = 126
        Me.KryptonLabel6.Text = "Año "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Año "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(16, 51)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel4.TabIndex = 70
        Me.KryptonLabel4.Text = "Cliente :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente :"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(83, 49)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.Size = New System.Drawing.Size(299, 19)
        Me.UcCliente.TabIndex = 69
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 16)
        Me.KryptonLabel1.TabIndex = 35
        Me.KryptonLabel1.Text = "Compañia :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(16, 42)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(68, 16)
        Me.lblCompania.TabIndex = 35
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'frmResumenEjecutivoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 448)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmResumenEjecutivoMensual"
        Me.Text = "Resumen Ejecutivo Mensual"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalle.Panel.ResumeLayout(False)
        CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalle.ResumeLayout(False)
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HGDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnReporte As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dbMes As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ndAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
End Class
