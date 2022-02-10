<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal2
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SolminToolStrip1 = New SOLMIN_SA.Menu.SolminToolStrip()
        Me.SolminMenuStrip1 = New SOLMIN_SA.Menu.SolminMenuStrip()
        Me.SolminStatusStrip1 = New SOLMIN_SA.Menu.SolminStatusStrip()
        Me.bgwCtrlEtiquetaPaleta = New System.ComponentModel.BackgroundWorker()
        Me.tmrIniciarChekeoBulto = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIniciarChekeoPaleta = New System.Windows.Forms.Timer(Me.components)
        Me.bgwCtrlEtiquetaBulto = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'SolminToolStrip1
        '
        Me.SolminToolStrip1.DataBind = False
        Me.SolminToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SolminToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SolminToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.SolminToolStrip1.MMAPLC = ""
        Me.SolminToolStrip1.MMCMNU = Nothing
        Me.SolminToolStrip1.MMCUSR = ""
        Me.SolminToolStrip1.Name = "SolminToolStrip1"
        Me.SolminToolStrip1.Size = New System.Drawing.Size(1031, 25)
        Me.SolminToolStrip1.TabIndex = 1
        Me.SolminToolStrip1.Text = "SolminToolStrip1"
        '
        'SolminMenuStrip1
        '
        Me.SolminMenuStrip1.AcercaDe = ""
        Me.SolminMenuStrip1.DataBind = False
        Me.SolminMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SolminMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SolminMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.SolminMenuStrip1.MMAPLC = ""
        Me.SolminMenuStrip1.MMCMNU = Nothing
        Me.SolminMenuStrip1.MMCUSR = ""
        Me.SolminMenuStrip1.Name = "SolminMenuStrip1"
        Me.SolminMenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.SolminMenuStrip1.Size = New System.Drawing.Size(1031, 24)
        Me.SolminMenuStrip1.TabIndex = 3
        Me.SolminMenuStrip1.Text = "SolminMenuStrip1"
        '
        'SolminStatusStrip1
        '
        Me.SolminStatusStrip1.BackColor = System.Drawing.Color.White
        Me.SolminStatusStrip1.CLIENTE = ""
        Me.SolminStatusStrip1.DataBind = False
        Me.SolminStatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SolminStatusStrip1.Location = New System.Drawing.Point(0, 720)
        Me.SolminStatusStrip1.MMAPLC = ""
        Me.SolminStatusStrip1.MMCMNU = Nothing
        Me.SolminStatusStrip1.MMCUSR = ""
        Me.SolminStatusStrip1.MMTVAR = Nothing
        Me.SolminStatusStrip1.Name = "SolminStatusStrip1"
        Me.SolminStatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SolminStatusStrip1.RUTA_IMPRESORA = ""
        Me.SolminStatusStrip1.SERVIDOR = ""
        Me.SolminStatusStrip1.Size = New System.Drawing.Size(1031, 22)
        Me.SolminStatusStrip1.TabIndex = 5
        Me.SolminStatusStrip1.Text = "SolminStatusStrip1"
        Me.SolminStatusStrip1.USUARIO = ""
        '
        'bgwCtrlEtiquetaPaleta
        '
        '
        'tmrIniciarChekeoBulto
        '
        Me.tmrIniciarChekeoBulto.Interval = 10000
        '
        'tmrIniciarChekeoPaleta
        '
        Me.tmrIniciarChekeoPaleta.Interval = 10000
        '
        'bgwCtrlEtiquetaBulto
        '
        '
        'MDIPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.SOLMIN_SA.My.Resources.Resources.FondoPantalla
        Me.ClientSize = New System.Drawing.Size(1031, 742)
        Me.Controls.Add(Me.SolminStatusStrip1)
        Me.Controls.Add(Me.SolminToolStrip1)
        Me.Controls.Add(Me.SolminMenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.SolminMenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MDIPrincipal2"
        Me.Text = "Sistema Almacenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents SolminToolStrip1 As SOLMIN_SA.Menu.SolminToolStrip
    Friend WithEvents SolminMenuStrip1 As SOLMIN_SA.Menu.SolminMenuStrip
    Friend WithEvents SolminStatusStrip1 As SOLMIN_SA.Menu.SolminStatusStrip
    Friend WithEvents bgwCtrlEtiquetaPaleta As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrIniciarChekeoBulto As System.Windows.Forms.Timer
    Friend WithEvents tmrIniciarChekeoPaleta As System.Windows.Forms.Timer
    Friend WithEvents bgwCtrlEtiquetaBulto As System.ComponentModel.BackgroundWorker
End Class
