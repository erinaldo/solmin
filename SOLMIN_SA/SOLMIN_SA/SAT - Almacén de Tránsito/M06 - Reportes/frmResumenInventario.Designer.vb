<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenInventario
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
        Me.lblFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClient = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInventario = New System.Windows.Forms.DateTimePicker
        Me.txtSentidoCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaSentidoCargaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboPlanta = New RANSA.CONTROL.CheckComboBoxTest.CheckedComboBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblDestino = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator
        Me.tslTitulo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.lblFechaInventario)
        Me.KryptonPanel.Controls.Add(Me.txtClient)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Controls.Add(Me.dteFechaInventario)
        Me.KryptonPanel.Controls.Add(Me.txtSentidoCarga)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.cboPlanta)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(434, 164)
        Me.KryptonPanel.TabIndex = 0
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.AutoSize = False
        Me.lblFechaInventario.Location = New System.Drawing.Point(20, 114)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(107, 23)
        Me.lblFechaInventario.TabIndex = 101
        Me.lblFechaInventario.Text = "Fecha  Inventario :"
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha  Inventario :"
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.Location = New System.Drawing.Point(127, 39)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.Size = New System.Drawing.Size(248, 19)
        Me.txtClient.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(23, 39)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 67
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'dteFechaInventario
        '
        Me.dteFechaInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInventario.Location = New System.Drawing.Point(127, 114)
        Me.dteFechaInventario.Name = "dteFechaInventario"
        Me.dteFechaInventario.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInventario.TabIndex = 4
        '
        'txtSentidoCarga
        '
        Me.txtSentidoCarga.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaSentidoCargaListar})
        Me.txtSentidoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSentidoCarga.Location = New System.Drawing.Point(127, 89)
        Me.txtSentidoCarga.MaxLength = 17
        Me.txtSentidoCarga.Name = "txtSentidoCarga"
        Me.txtSentidoCarga.Size = New System.Drawing.Size(248, 19)
        Me.txtSentidoCarga.TabIndex = 2
        '
        'bsaSentidoCargaListar
        '
        Me.bsaSentidoCargaListar.ExtraText = ""
        Me.bsaSentidoCargaListar.Image = Nothing
        Me.bsaSentidoCargaListar.Text = ""
        Me.bsaSentidoCargaListar.ToolTipImage = Nothing
        Me.bsaSentidoCargaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaSentidoCargaListar.UniqueName = "0F1FEA32575749D90F1FEA32575749D9"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(23, 86)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "Sentido de Carga : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Sentido de Carga : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(23, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Planta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Planta :"
        '
        'cboPlanta
        '
        Me.cboPlanta.CheckOnClick = True
        Me.cboPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboPlanta.DropDownHeight = 1
        Me.cboPlanta.FormattingEnabled = True
        Me.cboPlanta.IntegralHeight = False
        Me.cboPlanta.Location = New System.Drawing.Point(127, 65)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Size = New System.Drawing.Size(248, 21)
        Me.cboPlanta.TabIndex = 1
        Me.cboPlanta.ValueSeparator = ", "
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDestino, Me.btnCancelar, Me.tssSeparador1, Me.btnGuardar, Me.tssSeparador2, Me.tslTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(434, 25)
        Me.tsMenuOpciones.TabIndex = 87
        '
        'lblDestino
        '
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(11, 22)
        Me.lblDestino.Tag = ""
        Me.lblDestino.Text = " "
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(47, 22)
        Me.btnCancelar.Text = "Salir"
        '
        'tssSeparador1
        '
        Me.tssSeparador1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(66, 22)
        Me.btnGuardar.Text = "Exportar"
        '
        'tssSeparador2
        '
        Me.tssSeparador2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador2.Name = "tssSeparador2"
        Me.tssSeparador2.Size = New System.Drawing.Size(6, 25)
        '
        'tslTitulo
        '
        Me.tslTitulo.Name = "tslTitulo"
        Me.tslTitulo.Size = New System.Drawing.Size(0, 22)
        '
        'frmResumenInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResumenInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Inventario"
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
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As Ransa.CONTROL.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents txtSentidoCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaSentidoCargaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClient As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblDestino As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInventario As System.Windows.Forms.DateTimePicker
End Class
