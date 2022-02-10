<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoSerie
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dteFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSerie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(503, 203)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dteFecha)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtObservacion)
        Me.KryptonPanel1.Controls.Add(Me.txtSerie)
        Me.KryptonPanel1.Controls.Add(Me.txtModelo)
        Me.KryptonPanel1.Controls.Add(Me.txtCliente)
        Me.KryptonPanel1.Controls.Add(Me.txtOS)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel1.Size = New System.Drawing.Size(503, 178)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 63
        '
        'dteFecha
        '
        Me.dteFecha.Checked = False
        Me.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFecha.Location = New System.Drawing.Point(100, 136)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Size = New System.Drawing.Size(102, 20)
        Me.dteFecha.TabIndex = 30
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(15, 140)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel9.TabIndex = 136
        Me.KryptonLabel9.Text = "Fecha Ingreso:"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fecha Ingreso:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(15, 112)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(77, 16)
        Me.KryptonLabel8.TabIndex = 135
        Me.KryptonLabel8.Text = "Observación:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Observación:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(15, 87)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(51, 16)
        Me.KryptonLabel7.TabIndex = 134
        Me.KryptonLabel7.Text = "Modelo:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Modelo:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 62)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(40, 16)
        Me.KryptonLabel6.TabIndex = 133
        Me.KryptonLabel6.Text = "Serie:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Serie:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 37)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel5.TabIndex = 132
        Me.KryptonLabel5.Text = "Cliente:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel3.TabIndex = 131
        Me.KryptonLabel3.Text = "N° O.S."
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "N° O.S."
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(100, 109)
        Me.txtObservacion.MaxLength = 25
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(353, 19)
        Me.txtObservacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtObservacion.TabIndex = 20
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(100, 59)
        Me.txtSerie.MaxLength = 20
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(166, 19)
        Me.txtSerie.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtSerie.TabIndex = 0
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Location = New System.Drawing.Point(100, 84)
        Me.txtModelo.MaxLength = 30
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(353, 19)
        Me.txtModelo.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtModelo.TabIndex = 10
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(100, 34)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.Size = New System.Drawing.Size(353, 19)
        Me.txtCliente.TabIndex = 50
        '
        'txtOS
        '
        Me.txtOS.Enabled = False
        Me.txtOS.Location = New System.Drawing.Point(100, 9)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(166, 19)
        Me.txtOS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOS.TabIndex = 40
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(503, 25)
        Me.tsMenuOpciones.TabIndex = 62
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Datos Serie"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'frmMantenimientoSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 203)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(511, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(511, 230)
        Me.Name = "frmMantenimientoSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serie"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtSerie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtModelo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents txtOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFecha As System.Windows.Forms.DateTimePicker
End Class
