<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentroCostoCliente
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
    Me.txtCentroCosto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtNroSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.beSeparador = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnGrabar = New System.Windows.Forms.ToolStripButton
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.txtCentroCosto)
    Me.KryptonPanel.Controls.Add(Me.txtCliente)
    Me.KryptonPanel.Controls.Add(Me.txtNroSolicitud)
    Me.KryptonPanel.Controls.Add(Me.beSeparador)
    Me.KryptonPanel.Controls.Add(Me.MenuBar)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonPanel.Controls.Add(Me.lblSolicitud)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(401, 136)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'txtCentroCosto
    '
    Me.txtCentroCosto.Location = New System.Drawing.Point(85, 99)
    Me.txtCentroCosto.MaxLength = 10
    Me.txtCentroCosto.Name = "txtCentroCosto"
    Me.txtCentroCosto.Size = New System.Drawing.Size(110, 21)
    Me.txtCentroCosto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCentroCosto.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCentroCosto.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
    Me.txtCentroCosto.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCentroCosto.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtCentroCosto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtCentroCosto.TabIndex = 13
    Me.txtCentroCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtCliente
    '
    Me.txtCliente.Enabled = False
    Me.txtCliente.Location = New System.Drawing.Point(85, 55)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.Size = New System.Drawing.Size(303, 21)
    Me.txtCliente.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCliente.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
    Me.txtCliente.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCliente.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtCliente.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtCliente.TabIndex = 12
    '
    'txtNroSolicitud
    '
    Me.txtNroSolicitud.Enabled = False
    Me.txtNroSolicitud.Location = New System.Drawing.Point(85, 30)
    Me.txtNroSolicitud.Name = "txtNroSolicitud"
    Me.txtNroSolicitud.Size = New System.Drawing.Size(85, 21)
    Me.txtNroSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtNroSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
    Me.txtNroSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtNroSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtNroSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtNroSolicitud.TabIndex = 7
    Me.txtNroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'beSeparador
    '
    Me.beSeparador.Location = New System.Drawing.Point(9, 85)
    Me.beSeparador.Name = "beSeparador"
    Me.beSeparador.Size = New System.Drawing.Size(380, 1)
    Me.beSeparador.TabIndex = 10
    Me.beSeparador.Text = "KryptonBorderEdge1"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGrabar, Me.btnCancelar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(401, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnGrabar
    '
    Me.btnGrabar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGrabar.Name = "btnGrabar"
    Me.btnGrabar.Size = New System.Drawing.Size(65, 22)
    Me.btnGrabar.Text = " Grabar"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(74, 22)
    Me.btnCancelar.Text = " Cancelar"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(5, 100)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(76, 19)
    Me.KryptonLabel2.TabIndex = 14
    Me.KryptonLabel2.Text = "Centro Costo"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Centro Costo"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(5, 55)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel1.TabIndex = 11
    Me.KryptonLabel1.Text = "Cliente"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Cliente"
    '
    'lblSolicitud
    '
    Me.lblSolicitud.Location = New System.Drawing.Point(5, 31)
    Me.lblSolicitud.Name = "lblSolicitud"
    Me.lblSolicitud.Size = New System.Drawing.Size(69, 19)
    Me.lblSolicitud.TabIndex = 6
    Me.lblSolicitud.Text = "N° Solicitud"
    Me.lblSolicitud.Values.ExtraText = ""
    Me.lblSolicitud.Values.Image = Nothing
    Me.lblSolicitud.Values.Text = "N° Solicitud"
    '
    'frmCentroCostoCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(401, 136)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmCentroCostoCliente"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Centro Costo Cliente"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtNroSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents beSeparador As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents lblSolicitud As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCentroCosto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
