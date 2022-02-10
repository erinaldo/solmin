<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaGeneral))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgSalidas = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.VisorReportesCrystal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSalidas.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgSalidas.Panel.SuspendLayout()
        Me.hgSalidas.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgSalidas)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(836, 590)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgSalidas
        '
        Me.hgSalidas.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesar})
        Me.hgSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgSalidas.HeaderVisibleSecondary = False
        Me.hgSalidas.Location = New System.Drawing.Point(0, 0)
        Me.hgSalidas.Name = "hgSalidas"
        '
        'hgSalidas.Panel
        '
        Me.hgSalidas.Panel.Controls.Add(Me.pcxEspera)
        Me.hgSalidas.Panel.Controls.Add(Me.VisorReportesCrystal)
        Me.hgSalidas.Size = New System.Drawing.Size(836, 590)
        Me.hgSalidas.TabIndex = 2
        Me.hgSalidas.Text = "Reporte"
        Me.hgSalidas.ValuesPrimary.Description = ""
        Me.hgSalidas.ValuesPrimary.Heading = "Reporte"
        Me.hgSalidas.ValuesPrimary.Image = CType(resources.GetObject("hgSalidas.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgSalidas.ValuesSecondary.Description = ""
        Me.hgSalidas.ValuesSecondary.Heading = "Description"
        Me.hgSalidas.ValuesSecondary.Image = Nothing
        '
        'btnProcesar
        '
        Me.btnProcesar.ExtraText = ""
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.ToolTipImage = Nothing
        Me.btnProcesar.UniqueName = "FC7819E8676D4F77FC7819E8676D4F77"
        '
        'pcxEspera
        '
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(640, 243)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 48
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'VisorReportesCrystal
        '
        Me.VisorReportesCrystal.ActiveViewIndex = -1
        Me.VisorReportesCrystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReportesCrystal.DisplayGroupTree = False
        Me.VisorReportesCrystal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReportesCrystal.Location = New System.Drawing.Point(0, 0)
        Me.VisorReportesCrystal.Name = "VisorReportesCrystal"
        Me.VisorReportesCrystal.SelectionFormula = ""
        Me.VisorReportesCrystal.Size = New System.Drawing.Size(834, 560)
        Me.VisorReportesCrystal.TabIndex = 0
        Me.VisorReportesCrystal.ViewTimeSelectionFormula = ""
        '
        'bgwGifAnimado
        '
        '
        'frmConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 590)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsultaGeneral"
        Me.Text = "Consulta General"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgSalidas.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalidas.Panel.ResumeLayout(False)
        Me.hgSalidas.Panel.PerformLayout()
        CType(Me.hgSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalidas.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hgSalidas As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents VisorReportesCrystal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
