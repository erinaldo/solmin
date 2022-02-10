<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoAcoplado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoAcoplado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtAño = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtConfEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCapacidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtColor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtChacis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Laberl1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNPLCCM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtAño)
        Me.KryptonPanel.Controls.Add(Me.txtConfEjes)
        Me.KryptonPanel.Controls.Add(Me.txtNumMTC)
        Me.KryptonPanel.Controls.Add(Me.txtCapacidad)
        Me.KryptonPanel.Controls.Add(Me.txtColor)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtChacis)
        Me.KryptonPanel.Controls.Add(Me.txtEjes)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.Laberl1)
        Me.KryptonPanel.Controls.Add(Me.txtNPLCCM)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(416, 266)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtAño
        '
        Me.txtAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Location = New System.Drawing.Point(163, 68)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(231, 21)
        Me.txtAño.TabIndex = 4
        '
        'txtConfEjes
        '
        Me.txtConfEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfEjes.Location = New System.Drawing.Point(163, 233)
        Me.txtConfEjes.MaxLength = 3
        Me.txtConfEjes.Name = "txtConfEjes"
        Me.txtConfEjes.Size = New System.Drawing.Size(231, 21)
        Me.txtConfEjes.TabIndex = 16
        '
        'txtNumMTC
        '
        Me.txtNumMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumMTC.Location = New System.Drawing.Point(163, 205)
        Me.txtNumMTC.MaxLength = 15
        Me.txtNumMTC.Name = "txtNumMTC"
        Me.txtNumMTC.Size = New System.Drawing.Size(231, 21)
        Me.txtNumMTC.TabIndex = 14
        '
        'txtCapacidad
        '
        Me.txtCapacidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidad.Location = New System.Drawing.Point(163, 178)
        Me.txtCapacidad.MaxLength = 8
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(231, 21)
        Me.txtCapacidad.TabIndex = 12
        '
        'txtColor
        '
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.Location = New System.Drawing.Point(163, 96)
        Me.txtColor.MaxLength = 25
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(231, 21)
        Me.txtColor.TabIndex = 6
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(23, 233)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(126, 19)
        Me.KryptonLabel9.TabIndex = 15
        Me.KryptonLabel9.Text = "Config. Ejes-Acoplado :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Config. Ejes-Acoplado :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(23, 207)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel8.TabIndex = 13
        Me.KryptonLabel8.Text = "Numero E. MTC :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Numero E. MTC :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(23, 179)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(116, 19)
        Me.KryptonLabel6.TabIndex = 11
        Me.KryptonLabel6.Text = "Capacidad de Carga :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Capacidad de Carga :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(23, 99)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(43, 19)
        Me.KryptonLabel5.TabIndex = 5
        Me.KryptonLabel5.Text = "Color :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Color :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(23, 70)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Text = "Año Fabricacion :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Año Fabricacion :"
        '
        'txtChacis
        '
        Me.txtChacis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChacis.Location = New System.Drawing.Point(163, 124)
        Me.txtChacis.MaxLength = 30
        Me.txtChacis.Name = "txtChacis"
        Me.txtChacis.Size = New System.Drawing.Size(231, 21)
        Me.txtChacis.TabIndex = 8
        '
        'txtEjes
        '
        Me.txtEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjes.Location = New System.Drawing.Point(163, 151)
        Me.txtEjes.MaxLength = 2
        Me.txtEjes.Name = "txtEjes"
        Me.txtEjes.Size = New System.Drawing.Size(231, 21)
        Me.txtEjes.TabIndex = 10
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(23, 127)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(92, 19)
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Text = "Numero Chacis :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Numero Chacis :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 152)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Text = "Numero ejes :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Numero ejes :"
        '
        'Laberl1
        '
        Me.Laberl1.Location = New System.Drawing.Point(23, 45)
        Me.Laberl1.Name = "Laberl1"
        Me.Laberl1.Size = New System.Drawing.Size(102, 19)
        Me.Laberl1.TabIndex = 1
        Me.Laberl1.Text = "Numero de Placa :"
        Me.Laberl1.Values.ExtraText = ""
        Me.Laberl1.Values.Image = Nothing
        Me.Laberl1.Values.Text = "Numero de Placa :"
        '
        'txtNPLCCM
        '
        Me.txtNPLCCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNPLCCM.Location = New System.Drawing.Point(163, 41)
        Me.txtNPLCCM.MaxLength = 6
        Me.txtNPLCCM.Name = "txtNPLCCM"
        Me.txtNPLCCM.Size = New System.Drawing.Size(97, 21)
        Me.txtNPLCCM.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNPLCCM.TabIndex = 2
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.ToolStripSeparator2, Me.tsbEliminar, Me.ToolStripSeparator3, Me.tsbGrabar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(416, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel1.Tag = "Datos Acoplado"
        Me.ToolStripLabel1.Text = "Datos Acoplado"
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(68, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        '
        'frmMantenimientoAcoplado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(424, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(424, 300)
        Me.Name = "frmMantenimientoAcoplado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Acoplado"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAño As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtConfEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNumMTC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCapacidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtColor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtChacis As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Laberl1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNPLCCM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
