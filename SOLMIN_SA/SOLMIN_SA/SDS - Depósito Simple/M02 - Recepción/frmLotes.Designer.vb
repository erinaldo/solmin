<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotes))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtPendiente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecVencimientoLote = New System.Windows.Forms.DateTimePicker
        Me.dtpFecProduccionMercaderia = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaINgresoAlmacen = New System.Windows.Forms.DateTimePicker
        Me.lblFecVencimientLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblFecProduccionMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtlotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaIngreso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbllotes = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(378, 219)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtPendiente)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.dtpFecVencimientoLote)
        Me.KryptonPanel1.Controls.Add(Me.dtpFecProduccionMercaderia)
        Me.KryptonPanel1.Controls.Add(Me.dtpFechaINgresoAlmacen)
        Me.KryptonPanel1.Controls.Add(Me.lblFecVencimientLote)
        Me.KryptonPanel1.Controls.Add(Me.txtCantidad)
        Me.KryptonPanel1.Controls.Add(Me.lblFecProduccionMercaderia)
        Me.KryptonPanel1.Controls.Add(Me.btnSalir)
        Me.KryptonPanel1.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel1.Controls.Add(Me.txtlotes)
        Me.KryptonPanel1.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel1.Controls.Add(Me.lblFechaIngreso)
        Me.KryptonPanel1.Controls.Add(Me.lbllotes)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(378, 219)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 80
        '
        'txtPendiente
        '
        Me.txtPendiente.Enabled = False
        Me.txtPendiente.Location = New System.Drawing.Point(113, 8)
        Me.txtPendiente.MaxLength = 15
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Size = New System.Drawing.Size(111, 21)
        Me.txtPendiente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPendiente.TabIndex = 50
        Me.txtPendiente.Text = "0"
        Me.txtPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(76, 33)
        Me.KryptonLabel1.TabIndex = 78
        Me.KryptonLabel1.Text = "Pendiente de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asignación : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Pendiente de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asignación : "
        '
        'dtpFecVencimientoLote
        '
        Me.dtpFecVencimientoLote.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVencimientoLote.Location = New System.Drawing.Point(113, 151)
        Me.dtpFecVencimientoLote.Name = "dtpFecVencimientoLote"
        Me.dtpFecVencimientoLote.ShowCheckBox = True
        Me.dtpFecVencimientoLote.Size = New System.Drawing.Size(111, 20)
        Me.dtpFecVencimientoLote.TabIndex = 40
        '
        'dtpFecProduccionMercaderia
        '
        Me.dtpFecProduccionMercaderia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecProduccionMercaderia.Location = New System.Drawing.Point(113, 113)
        Me.dtpFecProduccionMercaderia.Name = "dtpFecProduccionMercaderia"
        Me.dtpFecProduccionMercaderia.ShowCheckBox = True
        Me.dtpFecProduccionMercaderia.Size = New System.Drawing.Size(111, 20)
        Me.dtpFecProduccionMercaderia.TabIndex = 30
        '
        'dtpFechaINgresoAlmacen
        '
        Me.dtpFechaINgresoAlmacen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaINgresoAlmacen.Location = New System.Drawing.Point(113, 87)
        Me.dtpFechaINgresoAlmacen.Name = "dtpFechaINgresoAlmacen"
        Me.dtpFechaINgresoAlmacen.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaINgresoAlmacen.TabIndex = 20
        '
        'lblFecVencimientLote
        '
        Me.lblFecVencimientLote.Location = New System.Drawing.Point(12, 151)
        Me.lblFecVencimientLote.Name = "lblFecVencimientLote"
        Me.lblFecVencimientLote.Size = New System.Drawing.Size(95, 33)
        Me.lblFecVencimientLote.TabIndex = 17
        Me.lblFecVencimientLote.Text = "Fec. Vencimiento" & Global.Microsoft.VisualBasic.ChrW(10) & "Lote : "
        Me.lblFecVencimientLote.Values.ExtraText = ""
        Me.lblFecVencimientLote.Values.Image = Nothing
        Me.lblFecVencimientLote.Values.Text = "Fec. Vencimiento" & Global.Microsoft.VisualBasic.ChrW(10) & "Lote : "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(113, 60)
        Me.txtCantidad.MaxLength = 15
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(111, 21)
        Me.txtCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.TabIndex = 10
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFecProduccionMercaderia
        '
        Me.lblFecProduccionMercaderia.Location = New System.Drawing.Point(12, 112)
        Me.lblFecProduccionMercaderia.Name = "lblFecProduccionMercaderia"
        Me.lblFecProduccionMercaderia.Size = New System.Drawing.Size(83, 33)
        Me.lblFecProduccionMercaderia.TabIndex = 13
        Me.lblFecProduccionMercaderia.Text = "Fec. Produción " & Global.Microsoft.VisualBasic.ChrW(10) & "Mercadería  : "
        Me.lblFecProduccionMercaderia.Values.ExtraText = ""
        Me.lblFecProduccionMercaderia.Values.Image = Nothing
        Me.lblFecProduccionMercaderia.Values.Text = "Fec. Produción " & Global.Microsoft.VisualBasic.ChrW(10) & "Mercadería  : "
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(207, 183)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 25)
        Me.btnSalir.TabIndex = 77
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = CType(resources.GetObject("btnSalir.Values.Image"), System.Drawing.Image)
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(113, 183)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 25)
        Me.btnAceptar.TabIndex = 50
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'txtlotes
        '
        Me.txtlotes.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtlotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotes.Location = New System.Drawing.Point(113, 35)
        Me.txtlotes.MaxLength = 15
        Me.txtlotes.Name = "txtlotes"
        Me.txtlotes.Size = New System.Drawing.Size(212, 21)
        Me.txtlotes.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlotes.TabIndex = 0
        '
        'bsaTipoAlmacenListar
        '
        Me.bsaTipoAlmacenListar.ExtraText = ""
        Me.bsaTipoAlmacenListar.Image = Nothing
        Me.bsaTipoAlmacenListar.Text = ""
        Me.bsaTipoAlmacenListar.ToolTipImage = Nothing
        Me.bsaTipoAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoAlmacenListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(12, 62)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(61, 19)
        Me.lblAlmacen.TabIndex = 9
        Me.lblAlmacen.Text = "Cantidad : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Cantidad : "
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.Location = New System.Drawing.Point(12, 87)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(75, 19)
        Me.lblFechaIngreso.TabIndex = 11
        Me.lblFechaIngreso.Text = "Fec. Ingreso :"
        Me.lblFechaIngreso.Values.ExtraText = ""
        Me.lblFechaIngreso.Values.Image = Nothing
        Me.lblFechaIngreso.Values.Text = "Fec. Ingreso :"
        '
        'lbllotes
        '
        Me.lbllotes.Location = New System.Drawing.Point(12, 37)
        Me.lbllotes.Name = "lbllotes"
        Me.lbllotes.Size = New System.Drawing.Size(37, 19)
        Me.lbllotes.TabIndex = 7
        Me.lbllotes.Text = "Lote : "
        Me.lbllotes.Values.ExtraText = ""
        Me.lbllotes.Values.Image = Nothing
        Me.lbllotes.Values.Text = "Lote : "
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 219)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(386, 253)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(386, 253)
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lotes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents lblFecVencimientLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblFecProduccionMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtlotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaIngreso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbllotes As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaINgresoAlmacen As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecProduccionMercaderia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecVencimientoLote As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPendiente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
