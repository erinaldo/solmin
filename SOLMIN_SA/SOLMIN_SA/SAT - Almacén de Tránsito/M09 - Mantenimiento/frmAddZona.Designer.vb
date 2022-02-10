<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddZona
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
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescAbreviado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescCompleta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblalmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbAtencion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmbAtencion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtCantidad)
        Me.KryptonPanel.Controls.Add(Me.txtDescAbreviado)
        Me.KryptonPanel.Controls.Add(Me.txtDescCompleta)
        Me.KryptonPanel.Controls.Add(Me.txtCodigo)
        Me.KryptonPanel.Controls.Add(Me.lblalmacen)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(478, 237)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(13, 208)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(123, 20)
        Me.KryptonLabel5.TabIndex = 21
        Me.KryptonLabel5.Text = "Disponible Atención:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Disponible Atención:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(50, 180)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(83, 20)
        Me.KryptonLabel4.TabIndex = 20
        Me.KryptonLabel4.Text = "Cantidad M2:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad M2:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 152)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(135, 20)
        Me.KryptonLabel3.TabIndex = 19
        Me.KryptonLabel3.Text = "Descripción Abreviada:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Descripción Abreviada:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 124)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(133, 20)
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.Text = "Descripción Completa:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción Completa:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(78, 96)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel1.TabIndex = 17
        Me.KryptonLabel1.Text = "Codigo:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Codigo:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(142, 177)
        Me.txtCantidad.MaxLength = 20
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 22)
        Me.txtCantidad.TabIndex = 15
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescAbreviado
        '
        Me.txtDescAbreviado.Location = New System.Drawing.Point(142, 149)
        Me.txtDescAbreviado.MaxLength = 15
        Me.txtDescAbreviado.Name = "txtDescAbreviado"
        Me.txtDescAbreviado.Size = New System.Drawing.Size(306, 22)
        Me.txtDescAbreviado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescAbreviado.TabIndex = 14
        '
        'txtDescCompleta
        '
        Me.txtDescCompleta.Location = New System.Drawing.Point(141, 121)
        Me.txtDescCompleta.MaxLength = 35
        Me.txtDescCompleta.Name = "txtDescCompleta"
        Me.txtDescCompleta.Size = New System.Drawing.Size(307, 22)
        Me.txtDescCompleta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescCompleta.TabIndex = 13
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(142, 93)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(75, 22)
        Me.txtCodigo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.TabIndex = 12
        '
        'lblalmacen
        '
        Me.lblalmacen.Location = New System.Drawing.Point(71, 68)
        Me.lblalmacen.Name = "lblalmacen"
        Me.lblalmacen.Size = New System.Drawing.Size(60, 20)
        Me.lblalmacen.TabIndex = 11
        Me.lblalmacen.Text = "Almacen:"
        Me.lblalmacen.Values.ExtraText = ""
        Me.lblalmacen.Values.Image = Nothing
        Me.lblalmacen.Values.Text = "Almacen:"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(142, 66)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.Size = New System.Drawing.Size(306, 21)
        Me.txtAlmacen.TabIndex = 10
        Me.txtAlmacen.ValueMember = ""
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(91, 43)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(37, 20)
        Me.lblTipoAlmacen.TabIndex = 9
        Me.lblTipoAlmacen.Text = "Tipo:"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo:"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(141, 39)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = False
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(307, 21)
        Me.txtTipoAlmacen.TabIndex = 8
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(478, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'cmbAtencion
        '
        Me.cmbAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAtencion.DropDownWidth = 76
        Me.cmbAtencion.FormattingEnabled = False
        Me.cmbAtencion.ItemHeight = 15
        Me.cmbAtencion.Location = New System.Drawing.Point(141, 202)
        Me.cmbAtencion.Name = "cmbAtencion"
        Me.cmbAtencion.Size = New System.Drawing.Size(76, 23)
        Me.cmbAtencion.TabIndex = 22
        '
        'frmAddZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 237)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zona Almacén"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblalmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    'Friend WithEvents cmbAtencion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescAbreviado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescCompleta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbAtencion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
