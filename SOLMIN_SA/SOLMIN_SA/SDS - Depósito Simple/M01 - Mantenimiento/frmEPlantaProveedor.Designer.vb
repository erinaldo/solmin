<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEPlantaProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEPlantaProveedor))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtUbigeo = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMailDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDireccionPlanta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNombrePlanta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDireccionDestinatario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(513, 171)
        Me.KryptonPanel.TabIndex = 1
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtUbigeo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtMailDestino)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDireccionPlanta)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtNombrePlanta)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDireccionDestinatario)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonGroup1.Size = New System.Drawing.Size(513, 146)
        Me.KryptonGroup1.TabIndex = 1
        '
        'txtUbigeo
        '
        Me.txtUbigeo.BackColor = System.Drawing.Color.Transparent
        Me.txtUbigeo.DataSource = Nothing
        Me.txtUbigeo.DispleyMember = ""
        Me.txtUbigeo.Etiquetas_Form = Nothing
        Me.txtUbigeo.ListColumnas = Nothing
        Me.txtUbigeo.Location = New System.Drawing.Point(142, 88)
        Me.txtUbigeo.Name = "txtUbigeo"
        Me.txtUbigeo.Obligatorio = False
        Me.txtUbigeo.PopupHeight = 0
        Me.txtUbigeo.PopupWidth = 0
        Me.txtUbigeo.Size = New System.Drawing.Size(348, 21)
        Me.txtUbigeo.TabIndex = 3
        Me.txtUbigeo.ValueMember = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 90)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.Text = "Ubigeo:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Ubigeo:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 113)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(75, 19)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Mail Destino:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Mail Destino:"
        '
        'txtMailDestino
        '
        Me.txtMailDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMailDestino.Location = New System.Drawing.Point(142, 113)
        Me.txtMailDestino.MaxLength = 40
        Me.txtMailDestino.Name = "txtMailDestino"
        Me.txtMailDestino.Size = New System.Drawing.Size(348, 21)
        Me.txtMailDestino.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtMailDestino.TabIndex = 4
        '
        'txtDireccionPlanta
        '
        Me.txtDireccionPlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionPlanta.Location = New System.Drawing.Point(142, 36)
        Me.txtDireccionPlanta.MaxLength = 35
        Me.txtDireccionPlanta.Name = "txtDireccionPlanta"
        Me.txtDireccionPlanta.Size = New System.Drawing.Size(348, 21)
        Me.txtDireccionPlanta.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDireccionPlanta.TabIndex = 1
        '
        'txtNombrePlanta
        '
        Me.txtNombrePlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePlanta.Location = New System.Drawing.Point(142, 11)
        Me.txtNombrePlanta.MaxLength = 35
        Me.txtNombrePlanta.Name = "txtNombrePlanta"
        Me.txtNombrePlanta.Size = New System.Drawing.Size(348, 21)
        Me.txtNombrePlanta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombrePlanta.TabIndex = 0
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(5, 38)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(121, 19)
        Me.lblTipoAlmacen.TabIndex = 11
        Me.lblTipoAlmacen.Text = "Dirección de la Planta:"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Dirección de la Planta:"
        '
        'txtDireccionDestinatario
        '
        Me.txtDireccionDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionDestinatario.Location = New System.Drawing.Point(142, 63)
        Me.txtDireccionDestinatario.MaxLength = 70
        Me.txtDireccionDestinatario.Name = "txtDireccionDestinatario"
        Me.txtDireccionDestinatario.Size = New System.Drawing.Size(348, 21)
        Me.txtDireccionDestinatario.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDireccionDestinatario.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 13)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(115, 19)
        Me.lblCliente.TabIndex = 14
        Me.lblCliente.Text = "Nombre de la Planta:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Nombre de la Planta:"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(513, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripLabel1.Tag = "Planta Cliente Tercero Edicion"
        Me.ToolStripLabel1.Text = "Planta Cliente Tercero Edicion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton2.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'frmEPlantaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximumSize = New System.Drawing.Size(521, 198)
        Me.MinimumSize = New System.Drawing.Size(521, 198)
        Me.Name = "frmEPlantaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planta Cliente Tercero"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMailDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDireccionPlanta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNombrePlanta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccionDestinatario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUbigeo As Ransa.Utilitario.ucAyuda
End Class
