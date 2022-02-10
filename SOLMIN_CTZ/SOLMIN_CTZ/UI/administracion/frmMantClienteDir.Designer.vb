<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantClienteDir
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboTipo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboCliente = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboPlanta = New Ransa.Utilitario.ucAyuda
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tslDetalle = New System.Windows.Forms.ToolStripLabel
        Me.tsS04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelarDet = New System.Windows.Forms.ToolStripButton
        Me.tsS05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGrabarDet = New System.Windows.Forms.ToolStripButton
        Me.tsS03 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cboZona = New Ransa.Utilitario.ucAyuda
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(384, 186)
        Me.KryptonPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboZona)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.cboCliente)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.cboPlanta)
        Me.Panel1.Controls.Add(Me.lblPlanta)
        Me.Panel1.Controls.Add(Me.UcCliente)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 161)
        Me.Panel1.TabIndex = 79
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.DropDownWidth = 106
        Me.cboTipo.FormattingEnabled = False
        Me.cboTipo.ItemHeight = 15
        Me.cboTipo.Location = New System.Drawing.Point(100, 19)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(237, 23)
        Me.cboTipo.TabIndex = 90
        '
        'cboCliente
        '
        Me.cboCliente.BackColor = System.Drawing.Color.Transparent
        Me.cboCliente.DataSource = Nothing
        Me.cboCliente.DispleyMember = ""
        Me.cboCliente.Etiquetas_Form = Nothing
        Me.cboCliente.ListColumnas = Nothing
        Me.cboCliente.Location = New System.Drawing.Point(100, 50)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Obligatorio = True
        Me.cboCliente.PopupHeight = 0
        Me.cboCliente.PopupWidth = 0
        Me.cboCliente.Size = New System.Drawing.Size(237, 22)
        Me.cboCliente.SizeFont = 0
        Me.cboCliente.TabIndex = 91
        Me.cboCliente.ValueMember = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(20, 104)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel1.TabIndex = 81
        Me.KryptonLabel1.Text = "Zona Fact.:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Zona Fact.:"
        '
        'cboPlanta
        '
        Me.cboPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cboPlanta.DataSource = Nothing
        Me.cboPlanta.DispleyMember = ""
        Me.cboPlanta.Etiquetas_Form = Nothing
        Me.cboPlanta.ListColumnas = Nothing
        Me.cboPlanta.Location = New System.Drawing.Point(100, 78)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Obligatorio = True
        Me.cboPlanta.PopupHeight = 0
        Me.cboPlanta.PopupWidth = 0
        Me.cboPlanta.Size = New System.Drawing.Size(237, 22)
        Me.cboPlanta.SizeFont = 0
        Me.cboPlanta.TabIndex = 92
        Me.cboPlanta.ValueMember = ""
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(20, 76)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(47, 20)
        Me.lblPlanta.TabIndex = 79
        Me.lblPlanta.Text = "Planta:"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta:"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(100, 50)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.pVisualizaNegocio = False
        Me.UcCliente.Size = New System.Drawing.Size(237, 22)
        Me.UcCliente.TabIndex = 77
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(20, 22)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(37, 20)
        Me.lblTipo.TabIndex = 76
        Me.lblTipo.Text = "Tipo:"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "Tipo:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(20, 48)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 78
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslDetalle, Me.tsS04, Me.btnCancelarDet, Me.tsS05, Me.btnGrabarDet, Me.tsS03})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(384, 25)
        Me.ToolStrip2.TabIndex = 74
        '
        'tslDetalle
        '
        Me.tslDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslDetalle.Name = "tslDetalle"
        Me.tslDetalle.Size = New System.Drawing.Size(0, 22)
        '
        'tsS04
        '
        Me.tsS04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS04.Name = "tsS04"
        Me.tsS04.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelarDet
        '
        Me.btnCancelarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelarDet.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCancelarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarDet.Name = "btnCancelarDet"
        Me.btnCancelarDet.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarDet.Text = "Cancelar"
        '
        'tsS05
        '
        Me.tsS05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS05.Name = "tsS05"
        Me.tsS05.Size = New System.Drawing.Size(6, 25)
        '
        'btnGrabarDet
        '
        Me.btnGrabarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabarDet.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGrabarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabarDet.Name = "btnGrabarDet"
        Me.btnGrabarDet.Size = New System.Drawing.Size(69, 22)
        Me.btnGrabarDet.Text = "Guardar"
        Me.btnGrabarDet.ToolTipText = "Guardar"
        '
        'tsS03
        '
        Me.tsS03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS03.Name = "tsS03"
        Me.tsS03.Size = New System.Drawing.Size(6, 25)
        '
        'cboZona
        '
        Me.cboZona.BackColor = System.Drawing.Color.Transparent
        Me.cboZona.DataSource = Nothing
        Me.cboZona.DispleyMember = ""
        Me.cboZona.Etiquetas_Form = Nothing
        Me.cboZona.ListColumnas = Nothing
        Me.cboZona.Location = New System.Drawing.Point(100, 106)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Obligatorio = False
        Me.cboZona.PopupHeight = 0
        Me.cboZona.PopupWidth = 0
        Me.cboZona.Size = New System.Drawing.Size(237, 21)
        Me.cboZona.SizeFont = 0
        Me.cboZona.TabIndex = 94
        Me.cboZona.ValueMember = ""
        '
        'frmMantClienteDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(384, 186)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantClienteDir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mant. Clientes por Dirección"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsS04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsS05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGrabarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsS03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboCliente As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboTipo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboZona As Ransa.Utilitario.ucAyuda
End Class
