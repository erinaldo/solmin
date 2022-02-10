<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPosicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarPosicion))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.v = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAyuda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAyuda = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.v, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.v.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'v
        '
        Me.v.Controls.Add(Me.txtTipoAlmacen)
        Me.v.Controls.Add(Me.txtAlmacen)
        Me.v.Controls.Add(Me.txtAyuda)
        Me.v.Controls.Add(Me.lblAlmacen)
        Me.v.Controls.Add(Me.lblTipoAlmacen)
        Me.v.Controls.Add(Me.lbl_CPRVCL)
        Me.v.Dock = System.Windows.Forms.DockStyle.Fill
        Me.v.Location = New System.Drawing.Point(0, 25)
        Me.v.Name = "v"
        Me.v.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.v.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.v.Size = New System.Drawing.Size(510, 103)
        Me.v.StateCommon.Color1 = System.Drawing.Color.White
        Me.v.TabIndex = 1
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(94, 10)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(380, 23)
        Me.txtTipoAlmacen.TabIndex = 0
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.Etiquetas_Form = Nothing
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(94, 37)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(380, 23)
        Me.txtAlmacen.TabIndex = 1
        Me.txtAlmacen.ValueMember = ""
        '
        'txtAyuda
        '
        Me.txtAyuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAyuda.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyuda})
        Me.txtAyuda.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtAyuda.Location = New System.Drawing.Point(94, 63)
        Me.txtAyuda.Name = "txtAyuda"
        Me.txtAyuda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtAyuda.Size = New System.Drawing.Size(380, 20)
        Me.txtAyuda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAyuda.TabIndex = 2
        '
        'btnAyuda
        '
        Me.btnAyuda.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit
        Me.btnAyuda.ExtraText = ""
        Me.btnAyuda.Image = Nothing
        Me.btnAyuda.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
        Me.btnAyuda.Text = ""
        Me.btnAyuda.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAyuda.UniqueName = "49E3634C8A8344A049E3634C8A8344A0"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblAlmacen.Location = New System.Drawing.Point(27, 39)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblAlmacen.Size = New System.Drawing.Size(59, 19)
        Me.lblAlmacen.TabIndex = 91
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(50, 13)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(38, 19)
        Me.lblTipoAlmacen.TabIndex = 89
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(29, 65)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(57, 19)
        Me.lbl_CPRVCL.TabIndex = 32
        Me.lbl_CPRVCL.Text = "Posición :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Posición :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.tsbCancelar, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(510, 25)
        Me.tsMenuOpciones.TabIndex = 59
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Lote"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(71, 22)
        Me.tsbCancelar.Text = "&Cancelar"
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
        'frmAgregarPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 128)
        Me.ControlBox = False
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.MaximumSize = New System.Drawing.Size(600, 450)
        Me.Name = "frmAgregarPosicion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Ubicación"
        CType(Me.v, System.ComponentModel.ISupportInitialize).EndInit()
        Me.v.ResumeLayout(False)
        Me.v.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents v As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtAyuda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAyuda As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
End Class
