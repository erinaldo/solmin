<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarGuia
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
        Me.Panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtNroRemision = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboTipoGR = New System.Windows.Forms.ComboBox()
        Me.txtPesoVolumen = New System.Windows.Forms.TextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnBuscaOrdenServicio = New System.Windows.Forms.Button()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar_0 = New System.Windows.Forms.ToolStrip()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaGuia = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.MenuBar_0.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.txtNroRemision)
        Me.Panel.Controls.Add(Me.KryptonLabel5)
        Me.Panel.Controls.Add(Me.cboTipoGR)
        Me.Panel.Controls.Add(Me.txtPesoVolumen)
        Me.Panel.Controls.Add(Me.KryptonLabel4)
        Me.Panel.Controls.Add(Me.btnBuscaOrdenServicio)
        Me.Panel.Controls.Add(Me.txtOperacion)
        Me.Panel.Controls.Add(Me.lblOperacion)
        Me.Panel.Controls.Add(Me.MenuBar_0)
        Me.Panel.Controls.Add(Me.UcCliente)
        Me.Panel.Controls.Add(Me.KryptonLabel1)
        Me.Panel.Controls.Add(Me.dtpFechaGuia)
        Me.Panel.Controls.Add(Me.KryptonLabel2)
        Me.Panel.Controls.Add(Me.KryptonLabel3)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel.Name = "Panel"
        Me.Panel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.Panel.Size = New System.Drawing.Size(607, 233)
        Me.Panel.StateCommon.Color1 = System.Drawing.Color.White
        Me.Panel.TabIndex = 3
        '
        'txtNroRemision
        '
        Me.txtNroRemision.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroRemision.Location = New System.Drawing.Point(139, 115)
        Me.txtNroRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroRemision.Mask = "A###-#######"
        Me.txtNroRemision.Name = "txtNroRemision"
        Me.txtNroRemision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroRemision.Size = New System.Drawing.Size(181, 26)
        Me.txtNroRemision.TabIndex = 1
        Me.txtNroRemision.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 86)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(45, 26)
        Me.KryptonLabel5.TabIndex = 76
        Me.KryptonLabel5.Text = "Tipo:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Tipo:"
        '
        'cboTipoGR
        '
        Me.cboTipoGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoGR.FormattingEnabled = True
        Me.cboTipoGR.ItemHeight = 16
        Me.cboTipoGR.Location = New System.Drawing.Point(139, 83)
        Me.cboTipoGR.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoGR.Name = "cboTipoGR"
        Me.cboTipoGR.Size = New System.Drawing.Size(181, 24)
        Me.cboTipoGR.TabIndex = 5
        '
        'txtPesoVolumen
        '
        Me.txtPesoVolumen.Location = New System.Drawing.Point(142, 152)
        Me.txtPesoVolumen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoVolumen.MaxLength = 10
        Me.txtPesoVolumen.Name = "txtPesoVolumen"
        Me.txtPesoVolumen.Size = New System.Drawing.Size(153, 22)
        Me.txtPesoVolumen.TabIndex = 3
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 152)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(121, 26)
        Me.KryptonLabel4.TabIndex = 17
        Me.KryptonLabel4.Text = "Peso / Peso Vol."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Peso / Peso Vol."
        '
        'btnBuscaOrdenServicio
        '
        Me.btnBuscaOrdenServicio.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.cell_layout
        Me.btnBuscaOrdenServicio.Location = New System.Drawing.Point(536, 150)
        Me.btnBuscaOrdenServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscaOrdenServicio.Name = "btnBuscaOrdenServicio"
        Me.btnBuscaOrdenServicio.Size = New System.Drawing.Size(33, 30)
        Me.btnBuscaOrdenServicio.TabIndex = 16
        Me.btnBuscaOrdenServicio.UseVisualStyleBackColor = True
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(420, 152)
        Me.txtOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperacion.MaxLength = 10
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(112, 22)
        Me.txtOperacion.TabIndex = 4
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(327, 154)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(82, 26)
        Me.lblOperacion.TabIndex = 14
        Me.lblOperacion.Text = "Operación"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "Operación"
        '
        'MenuBar_0
        '
        Me.MenuBar_0.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar_0.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar_0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.btnProcesar})
        Me.MenuBar_0.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar_0.Name = "MenuBar_0"
        Me.MenuBar_0.Size = New System.Drawing.Size(607, 27)
        Me.MenuBar_0.TabIndex = 0
        Me.MenuBar_0.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 24)
        Me.btnSalir.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.db_add
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(92, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(137, 48)
        Me.UcCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.pVisualizaNegocio = False
        Me.UcCliente.Size = New System.Drawing.Size(428, 26)
        Me.UcCliente.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 50)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(59, 26)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Cliente"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente"
        '
        'dtpFechaGuia
        '
        Me.dtpFechaGuia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaGuia.Location = New System.Drawing.Point(420, 116)
        Me.dtpFechaGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaGuia.Name = "dtpFechaGuia"
        Me.dtpFechaGuia.Size = New System.Drawing.Size(145, 22)
        Me.dtpFechaGuia.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(327, 118)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(86, 26)
        Me.KryptonLabel2.TabIndex = 11
        Me.KryptonLabel2.Text = "Fecha Guía"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Guía"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 118)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(109, 26)
        Me.KryptonLabel3.TabIndex = 9
        Me.KryptonLabel3.Text = "Guía Remisión"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Guía Remisión"
        '
        'frmAsignarGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 233)
        Me.Controls.Add(Me.Panel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAsignarGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación Manual - Guía Remisión"
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.MenuBar_0.ResumeLayout(False)
        Me.MenuBar_0.PerformLayout()
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
  Friend WithEvents Panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaGuia As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar_0 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtOperacion As System.Windows.Forms.TextBox
  Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnBuscaOrdenServicio As System.Windows.Forms.Button
  Friend WithEvents txtPesoVolumen As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoGR As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroRemision As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
End Class
