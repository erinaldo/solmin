<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Visor_Reporte
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_Visor_Reporte))
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pbxBuscar = New System.Windows.Forms.PictureBox
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(150, 150)
        Me.ReportViewer.TabIndex = 17
        Me.ReportViewer.ViewTimeSelectionFormula = ""
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
        Me.pbxBuscar.Size = New System.Drawing.Size(150, 150)
        Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBuscar.TabIndex = 18
        Me.pbxBuscar.TabStop = False
        Me.pbxBuscar.Visible = False
        '
        'Control_Visor_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbxBuscar)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "Control_Visor_Reporte"
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox

End Class
