<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantTransportista
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
        Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDesCompleto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDesAbreviado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNumEmpadronamiento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtrepresentante = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLERepresentante = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRuc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtDireccion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.txtDesCompleto)
        Me.KryptonPanel.Controls.Add(Me.txtDesAbreviado)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.lbl_TPRVCL)
        Me.KryptonPanel.Controls.Add(Me.txtNumEmpadronamiento)
        Me.KryptonPanel.Controls.Add(Me.txtrepresentante)
        Me.KryptonPanel.Controls.Add(Me.txtLERepresentante)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtRuc)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.lbl_CPRVCL)
        Me.KryptonPanel.Controls.Add(Me.txtCodigo)
        Me.KryptonPanel.Controls.Add(Me.lbl_NRUCPR)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(523, 276)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(134, 209)
        Me.txtDireccion.MaxLength = 30
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(353, 21)
        Me.txtDireccion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDireccion.TabIndex = 14
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 211)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Text = "Dirección : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Dirección : "
        '
        'txtDesCompleto
        '
        Me.txtDesCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesCompleto.Location = New System.Drawing.Point(134, 93)
        Me.txtDesCompleto.MaxLength = 30
        Me.txtDesCompleto.Name = "txtDesCompleto"
        Me.txtDesCompleto.Size = New System.Drawing.Size(353, 21)
        Me.txtDesCompleto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesCompleto.TabIndex = 6
        '
        'txtDesAbreviado
        '
        Me.txtDesAbreviado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesAbreviado.Location = New System.Drawing.Point(134, 122)
        Me.txtDesAbreviado.MaxLength = 10
        Me.txtDesAbreviado.Name = "txtDesAbreviado"
        Me.txtDesAbreviado.Size = New System.Drawing.Size(166, 21)
        Me.txtDesAbreviado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDesAbreviado.TabIndex = 8
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 124)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(91, 19)
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Text = "Desc Abreviado: "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Desc Abreviado: "
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(11, 95)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(90, 19)
        Me.lbl_TPRVCL.TabIndex = 5
        Me.lbl_TPRVCL.Text = "Desc. Completa: "
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Desc. Completa: "
        '
        'txtNumEmpadronamiento
        '
        Me.txtNumEmpadronamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEmpadronamiento.Location = New System.Drawing.Point(134, 238)
        Me.txtNumEmpadronamiento.MaxLength = 12
        Me.txtNumEmpadronamiento.Name = "txtNumEmpadronamiento"
        Me.txtNumEmpadronamiento.Size = New System.Drawing.Size(166, 21)
        Me.txtNumEmpadronamiento.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtNumEmpadronamiento.TabIndex = 16
        '
        'txtrepresentante
        '
        Me.txtrepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrepresentante.Location = New System.Drawing.Point(134, 151)
        Me.txtrepresentante.MaxLength = 30
        Me.txtrepresentante.Name = "txtrepresentante"
        Me.txtrepresentante.Size = New System.Drawing.Size(353, 21)
        Me.txtrepresentante.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtrepresentante.TabIndex = 10
        '
        'txtLERepresentante
        '
        Me.txtLERepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLERepresentante.Location = New System.Drawing.Point(134, 180)
        Me.txtLERepresentante.MaxLength = 8
        Me.txtLERepresentante.Name = "txtLERepresentante"
        Me.txtLERepresentante.Size = New System.Drawing.Size(166, 21)
        Me.txtLERepresentante.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtLERepresentante.TabIndex = 12
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(12, 153)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel12.TabIndex = 9
        Me.KryptonLabel12.Text = "Representante: "
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Representante: "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(9, 238)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(119, 33)
        Me.KryptonLabel6.TabIndex = 15
        Me.KryptonLabel6.Text = "N° empadronamiento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MTC: "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° empadronamiento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MTC: "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 182)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(110, 19)
        Me.KryptonLabel4.TabIndex = 11
        Me.KryptonLabel4.Text = "DNI Representante : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "DNI Representante : "
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Location = New System.Drawing.Point(134, 64)
        Me.txtRuc.MaxLength = 15
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(166, 21)
        Me.txtRuc.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtRuc.TabIndex = 4
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 287)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 66
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        Me.KryptonLabel1.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(134, 285)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(353, 21)
        Me.txtCliente.TabIndex = 90
        Me.txtCliente.Visible = False
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(12, 37)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(81, 19)
        Me.lbl_CPRVCL.TabIndex = 1
        Me.lbl_CPRVCL.Text = "Transportista :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Transportista :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(134, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(109, 21)
        Me.txtCodigo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCodigo.TabIndex = 2
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(12, 66)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(62, 19)
        Me.lbl_NRUCPR.TabIndex = 3
        Me.lbl_NRUCPR.Text = "Nro. RUC :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. RUC :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(523, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Datos Transportista"
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
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
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
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'frmMantTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 276)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(531, 310)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 310)
        Me.Name = "frmMantTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimineto Transportista"
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
    Private WithEvents txtDesCompleto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtDesAbreviado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNumEmpadronamiento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtrepresentante As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtLERepresentante As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtRuc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Private WithEvents txtDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
