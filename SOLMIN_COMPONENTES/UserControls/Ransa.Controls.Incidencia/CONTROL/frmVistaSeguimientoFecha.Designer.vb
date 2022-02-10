<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaSeguimientoFecha
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(677, 511)
        Me.CrystalReportViewer1.TabIndex = 71
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.iconoEspera
        Me.pcxEspera.Location = New System.Drawing.Point(85, 90)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(189, 189)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 72
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'frmVistaSeguimientoFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 511)
        Me.Controls.Add(Me.pcxEspera)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmVistaSeguimientoFecha"
        Me.Text = "Visor Seguimiento Incidencias por Fecha"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
End Class
