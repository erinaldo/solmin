<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarInfoAgencias
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
        Me.EventViewer = New System.Windows.Forms.TextBox
        Me.ddlAnio = New System.Windows.Forms.ComboBox
        Me.barra = New System.Windows.Forms.ProgressBar
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnProceso = New System.Windows.Forms.Button
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Button1)
        Me.KryptonPanel.Controls.Add(Me.EventViewer)
        Me.KryptonPanel.Controls.Add(Me.ddlAnio)
        Me.KryptonPanel.Controls.Add(Me.barra)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Controls.Add(Me.btnProceso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(354, 202)
        Me.KryptonPanel.TabIndex = 0
        '
        'EventViewer
        '
        Me.EventViewer.Location = New System.Drawing.Point(8, 68)
        Me.EventViewer.Multiline = True
        Me.EventViewer.Name = "EventViewer"
        Me.EventViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EventViewer.Size = New System.Drawing.Size(340, 124)
        Me.EventViewer.TabIndex = 15
        '
        'ddlAnio
        '
        Me.ddlAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlAnio.FormattingEnabled = True
        Me.ddlAnio.Location = New System.Drawing.Point(112, 8)
        Me.ddlAnio.Name = "ddlAnio"
        Me.ddlAnio.Size = New System.Drawing.Size(80, 21)
        Me.ddlAnio.TabIndex = 14
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(8, 40)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(340, 16)
        Me.barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barra.TabIndex = 13
        Me.barra.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(4, 12)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(100, 19)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Año de Migracion"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Año de Migracion"
        '
        'btnProceso
        '
        Me.btnProceso.Location = New System.Drawing.Point(196, 8)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(88, 23)
        Me.btnProceso.TabIndex = 0
        Me.btnProceso.Text = "Iniciar Proceso"
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImportarInfoAgencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 202)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmImportarInfoAgencias"
        Me.Text = "Migrar Informacion de Agencias Ransa"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents btnProceso As System.Windows.Forms.Button
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ddlAnio As System.Windows.Forms.ComboBox
    Friend WithEvents EventViewer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
