<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVisorReportesVentas
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.crvDetalleXDocumento = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.crvDetallexClientexRubroXCB = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.crvResumenxCliente = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.crvResumenXRubro = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.crvResumenXCentroBeneficio = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.crvResumenXDivision = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabControl1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(819, 463)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 438)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.crvDetalleXDocumento)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Documento x División"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'crvDetalleXDocumento
        '
        Me.crvDetalleXDocumento.ActiveViewIndex = -1
        Me.crvDetalleXDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvDetalleXDocumento.DisplayGroupTree = False
        Me.crvDetalleXDocumento.DisplayStatusBar = False
        Me.crvDetalleXDocumento.DisplayToolbar = False
        Me.crvDetalleXDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvDetalleXDocumento.Location = New System.Drawing.Point(3, 3)
        Me.crvDetalleXDocumento.Name = "crvDetalleXDocumento"
        Me.crvDetalleXDocumento.SelectionFormula = ""
        Me.crvDetalleXDocumento.Size = New System.Drawing.Size(805, 406)
        Me.crvDetalleXDocumento.TabIndex = 0
        Me.crvDetalleXDocumento.ViewTimeSelectionFormula = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.crvDetallexClientexRubroXCB)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Documento x Rubro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'crvDetallexClientexRubroXCB
        '
        Me.crvDetallexClientexRubroXCB.ActiveViewIndex = -1
        Me.crvDetallexClientexRubroXCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvDetallexClientexRubroXCB.DisplayGroupTree = False
        Me.crvDetallexClientexRubroXCB.DisplayStatusBar = False
        Me.crvDetallexClientexRubroXCB.DisplayToolbar = False
        Me.crvDetallexClientexRubroXCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvDetallexClientexRubroXCB.Location = New System.Drawing.Point(3, 3)
        Me.crvDetallexClientexRubroXCB.Name = "crvDetallexClientexRubroXCB"
        Me.crvDetallexClientexRubroXCB.SelectionFormula = ""
        Me.crvDetallexClientexRubroXCB.Size = New System.Drawing.Size(805, 406)
        Me.crvDetallexClientexRubroXCB.TabIndex = 0
        Me.crvDetallexClientexRubroXCB.ViewTimeSelectionFormula = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.crvResumenxCliente)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(811, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resumen x Cliente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'crvResumenxCliente
        '
        Me.crvResumenxCliente.ActiveViewIndex = -1
        Me.crvResumenxCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResumenxCliente.DisplayGroupTree = False
        Me.crvResumenxCliente.DisplayStatusBar = False
        Me.crvResumenxCliente.DisplayToolbar = False
        Me.crvResumenxCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvResumenxCliente.Location = New System.Drawing.Point(3, 3)
        Me.crvResumenxCliente.Name = "crvResumenxCliente"
        Me.crvResumenxCliente.SelectionFormula = ""
        Me.crvResumenxCliente.Size = New System.Drawing.Size(805, 406)
        Me.crvResumenxCliente.TabIndex = 0
        Me.crvResumenxCliente.ViewTimeSelectionFormula = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.crvResumenXRubro)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(811, 412)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Resumen x Rubro"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'crvResumenXRubro
        '
        Me.crvResumenXRubro.ActiveViewIndex = -1
        Me.crvResumenXRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResumenXRubro.DisplayGroupTree = False
        Me.crvResumenXRubro.DisplayStatusBar = False
        Me.crvResumenXRubro.DisplayToolbar = False
        Me.crvResumenXRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvResumenXRubro.Location = New System.Drawing.Point(3, 3)
        Me.crvResumenXRubro.Name = "crvResumenXRubro"
        Me.crvResumenXRubro.SelectionFormula = ""
        Me.crvResumenXRubro.Size = New System.Drawing.Size(805, 406)
        Me.crvResumenXRubro.TabIndex = 0
        Me.crvResumenXRubro.ViewTimeSelectionFormula = ""
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.crvResumenXCentroBeneficio)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(811, 412)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Resumen x Centro Beneficio"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'crvResumenXCentroBeneficio
        '
        Me.crvResumenXCentroBeneficio.ActiveViewIndex = -1
        Me.crvResumenXCentroBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResumenXCentroBeneficio.DisplayGroupTree = False
        Me.crvResumenXCentroBeneficio.DisplayStatusBar = False
        Me.crvResumenXCentroBeneficio.DisplayToolbar = False
        Me.crvResumenXCentroBeneficio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvResumenXCentroBeneficio.Location = New System.Drawing.Point(3, 3)
        Me.crvResumenXCentroBeneficio.Name = "crvResumenXCentroBeneficio"
        Me.crvResumenXCentroBeneficio.SelectionFormula = ""
        Me.crvResumenXCentroBeneficio.Size = New System.Drawing.Size(805, 406)
        Me.crvResumenXCentroBeneficio.TabIndex = 0
        Me.crvResumenXCentroBeneficio.ViewTimeSelectionFormula = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.crvResumenXDivision)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(811, 412)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Resumen x División"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'crvResumenXDivision
        '
        Me.crvResumenXDivision.ActiveViewIndex = -1
        Me.crvResumenXDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvResumenXDivision.DisplayGroupTree = False
        Me.crvResumenXDivision.DisplayStatusBar = False
        Me.crvResumenXDivision.DisplayToolbar = False
        Me.crvResumenXDivision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvResumenXDivision.Location = New System.Drawing.Point(3, 3)
        Me.crvResumenXDivision.Name = "crvResumenXDivision"
        Me.crvResumenXDivision.SelectionFormula = ""
        Me.crvResumenXDivision.Size = New System.Drawing.Size(805, 406)
        Me.crvResumenXDivision.TabIndex = 0
        Me.crvResumenXDivision.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(819, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripButton1.Text = "Exportar Excel"
        '
        'FormVisorReportesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 463)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FormVisorReportesVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor Reportes Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents crvDetallexClientexRubroXCB As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvDetalleXDocumento As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvResumenxCliente As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvResumenXRubro As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvResumenXCentroBeneficio As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvResumenXDivision As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
