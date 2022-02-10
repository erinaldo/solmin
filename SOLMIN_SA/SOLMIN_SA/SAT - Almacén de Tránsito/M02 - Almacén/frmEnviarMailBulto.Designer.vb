<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarMailBulto
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TxtObs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblobs = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDocAdjunto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtasunto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDestinatario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDestinatario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.spBtnEnviar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.SpBtnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.Animacion = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.WrkCorreo = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.Animacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Animacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.TxtObs)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblobs)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDocAdjunto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtasunto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDestinatario)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDestinatario)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(828, 230)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Datos del Correo "
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Datos del Correo "
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'TxtObs
        '
        Me.TxtObs.Location = New System.Drawing.Point(113, 150)
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObs.Size = New System.Drawing.Size(632, 51)
        Me.TxtObs.TabIndex = 9
        '
        'lblobs
        '
        Me.lblobs.Location = New System.Drawing.Point(21, 148)
        Me.lblobs.Name = "lblobs"
        Me.lblobs.Size = New System.Drawing.Size(96, 20)
        Me.lblobs.TabIndex = 8
        Me.lblobs.Text = "Observaciones :"
        Me.lblobs.Values.ExtraText = ""
        Me.lblobs.Values.Image = Nothing
        Me.lblobs.Values.Text = "Observaciones :"
        '
        'txtDocAdjunto
        '
        Me.txtDocAdjunto.Location = New System.Drawing.Point(112, 117)
        Me.txtDocAdjunto.Multiline = True
        Me.txtDocAdjunto.Name = "txtDocAdjunto"
        Me.txtDocAdjunto.ReadOnly = True
        Me.txtDocAdjunto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDocAdjunto.Size = New System.Drawing.Size(634, 30)
        Me.txtDocAdjunto.StateNormal.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocAdjunto.TabIndex = 7
        '
        'txtasunto
        '
        Me.txtasunto.Location = New System.Drawing.Point(112, 92)
        Me.txtasunto.Name = "txtasunto"
        Me.txtasunto.ReadOnly = True
        Me.txtasunto.Size = New System.Drawing.Size(634, 22)
        Me.txtasunto.StateNormal.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtasunto.TabIndex = 6
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(112, 54)
        Me.txtCC.Multiline = True
        Me.txtCC.Name = "txtCC"
        Me.txtCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCC.Size = New System.Drawing.Size(634, 35)
        Me.txtCC.TabIndex = 5
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Location = New System.Drawing.Point(112, 15)
        Me.txtDestinatario.Multiline = True
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDestinatario.Size = New System.Drawing.Size(634, 35)
        Me.txtDestinatario.TabIndex = 4
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(30, 121)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "Doc. Adjunto :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Doc. Adjunto :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(60, 92)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(55, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Asunto :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Asunto :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(80, 61)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(32, 20)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "CC :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "CC :"
        '
        'lblDestinatario
        '
        Me.lblDestinatario.Location = New System.Drawing.Point(32, 20)
        Me.lblDestinatario.Name = "lblDestinatario"
        Me.lblDestinatario.Size = New System.Drawing.Size(82, 20)
        Me.lblDestinatario.TabIndex = 0
        Me.lblDestinatario.Text = "Destinatario :"
        Me.lblDestinatario.Values.ExtraText = ""
        Me.lblDestinatario.Values.Image = Nothing
        Me.lblDestinatario.Values.Text = "Destinatario :"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.spBtnEnviar, Me.SpBtnCancelar})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 230)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.crvReporte)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(828, 356)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 3
        Me.KryptonHeaderGroup2.Text = "Contenido del Correo"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Contenido del Correo"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'spBtnEnviar
        '
        Me.spBtnEnviar.ExtraText = ""
        Me.spBtnEnviar.Image = Global.SOLMIN_SA.My.Resources.Resources.email_start
        Me.spBtnEnviar.Text = "Enviar"
        Me.spBtnEnviar.ToolTipImage = Nothing
        Me.spBtnEnviar.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.spBtnEnviar.UniqueName = "31B45011EC344C4031B45011EC344C40"
        '
        'SpBtnCancelar
        '
        Me.SpBtnCancelar.ExtraText = ""
        Me.SpBtnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.SpBtnCancelar.Text = "Cancelar"
        Me.SpBtnCancelar.ToolTipImage = Nothing
        Me.SpBtnCancelar.UniqueName = "7E9C76A1093F4A6F7E9C76A1093F4A6F"
        '
        'Animacion
        '
        Me.Animacion.Image = Global.SOLMIN_SA.My.Resources.Resources.enviando
        Me.Animacion.Location = New System.Drawing.Point(750, 170)
        Me.Animacion.Name = "Animacion"
        Me.Animacion.Size = New System.Drawing.Size(65, 29)
        Me.Animacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Animacion.TabIndex = 1
        Me.Animacion.TabStop = False
        Me.Animacion.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.DisplayBackgroundEdge = False
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.DisplayStatusBar = False
        Me.crvReporte.DisplayToolbar = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.EnableDrillDown = False
        Me.crvReporte.EnableToolTips = False
        Me.crvReporte.Location = New System.Drawing.Point(0, 0)
        Me.crvReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowExportButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowPageNavigateButtons = False
        Me.crvReporte.ShowPrintButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.ShowZoomButton = False
        Me.crvReporte.Size = New System.Drawing.Size(826, 330)
        Me.crvReporte.TabIndex = 0
        Me.crvReporte.ViewTimeSelectionFormula = ""
        '
        'WrkCorreo
        '
        '
        'frmEnviarMailBulto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonHeaderGroup2)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmEnviarMailBulto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bultos  - "
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.Animacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtasunto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDestinatario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDestinatario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDocAdjunto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents spBtnEnviar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SpBtnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TxtObs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblobs As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents WrkCorreo As System.ComponentModel.BackgroundWorker
    Friend WithEvents Animacion As System.Windows.Forms.PictureBox
End Class
