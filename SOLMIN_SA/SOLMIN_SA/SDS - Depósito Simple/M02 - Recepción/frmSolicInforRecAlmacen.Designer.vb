<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicInforRecAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicInforRecAlmacen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtZonaAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoMovimientoIng = New Ransa.Utilitario.ucAyuda
        Me.txtContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDesglose = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtRecPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarRecepcionItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoMovimientoIng)
        Me.KryptonPanel.Controls.Add(Me.txtContenedor)
        Me.KryptonPanel.Controls.Add(Me.lblContenedor)
        Me.KryptonPanel.Controls.Add(Me.chkDesglose)
        Me.KryptonPanel.Controls.Add(Me.lblTipoRecepcion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.txtRecObservacion)
        Me.KryptonPanel.Controls.Add(Me.txtRecPeso)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtRecCantidad)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarRecepcionItem)
        Me.KryptonPanel.Controls.Add(Me.lblNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.txtNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(386, 294)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.BackColor = System.Drawing.Color.White
        Me.txtZonaAlmacen.DataSource = Nothing
        Me.txtZonaAlmacen.DispleyMember = ""
        Me.txtZonaAlmacen.ListColumnas = Nothing
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(91, 114)
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Obligatorio = True
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(285, 23)
        Me.txtZonaAlmacen.TabIndex = 13
        Me.txtZonaAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(91, 61)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(285, 23)
        Me.txtTipoAlmacen.TabIndex = 9
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(91, 88)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.Size = New System.Drawing.Size(285, 23)
        Me.txtAlmacen.TabIndex = 11
        Me.txtAlmacen.ValueMember = ""
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(46, 117)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(44, 20)
        Me.lblZonaAlmacen.TabIndex = 12
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(30, 91)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(60, 20)
        Me.lblAlmacen.TabIndex = 10
        Me.lblAlmacen.Text = "Almacen:"
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen:"
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(2, 64)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(88, 20)
        Me.lblTipoAlmacen.TabIndex = 8
        Me.lblTipoAlmacen.Text = "Tipo Almacen:"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo Almacen:"
        '
        'txtTipoMovimientoIng
        '
        Me.txtTipoMovimientoIng.BackColor = System.Drawing.Color.White
        Me.txtTipoMovimientoIng.DataSource = Nothing
        Me.txtTipoMovimientoIng.DispleyMember = ""
        Me.txtTipoMovimientoIng.ListColumnas = Nothing
        Me.txtTipoMovimientoIng.Location = New System.Drawing.Point(91, 165)
        Me.txtTipoMovimientoIng.Name = "txtTipoMovimientoIng"
        Me.txtTipoMovimientoIng.Obligatorio = True
        Me.txtTipoMovimientoIng.Size = New System.Drawing.Size(285, 23)
        Me.txtTipoMovimientoIng.TabIndex = 19
        Me.txtTipoMovimientoIng.ValueMember = ""
        '
        'txtContenedor
        '
        Me.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtContenedor, True)
        Me.txtContenedor.Location = New System.Drawing.Point(248, 190)
        Me.txtContenedor.MaxLength = 11
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(127, 22)
        Me.txtContenedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContenedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtContenedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContenedor.TabIndex = 22
        Me.TypeValidator.SetTypes(Me.txtContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(175, 193)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(81, 20)
        Me.lblContenedor.TabIndex = 21
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'chkDesglose
        '
        Me.chkDesglose.Checked = False
        Me.chkDesglose.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDesglose.Location = New System.Drawing.Point(91, 193)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(73, 20)
        Me.chkDesglose.TabIndex = 20
        Me.chkDesglose.Text = "Desglose"
        Me.chkDesglose.Values.ExtraText = ""
        Me.chkDesglose.Values.Image = Nothing
        Me.chkDesglose.Values.Text = "Desglose"
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(24, 168)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(66, 20)
        Me.lblTipoRecepcion.TabIndex = 18
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(32, 215)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel7.TabIndex = 23
        Me.KryptonLabel7.Text = "Observ. : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observ. : "
        '
        'txtRecObservacion
        '
        Me.txtRecObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRecObservacion, True)
        Me.txtRecObservacion.Location = New System.Drawing.Point(91, 215)
        Me.txtRecObservacion.MaxLength = 25
        Me.txtRecObservacion.Name = "txtRecObservacion"
        Me.txtRecObservacion.Size = New System.Drawing.Size(285, 22)
        Me.txtRecObservacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtRecObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtRecObservacion.TabIndex = 24
        Me.TypeValidator.SetTypes(Me.txtRecObservacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtRecPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtRecPeso, 2)
        Me.txtRecPeso.Location = New System.Drawing.Point(248, 140)
        Me.txtRecPeso.Name = "txtRecPeso"
        Me.txtRecPeso.Size = New System.Drawing.Size(127, 22)
        Me.txtRecPeso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecPeso.TabIndex = 17
        Me.txtRecPeso.Text = "0.00"
        Me.txtRecPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(200, 143)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel2.TabIndex = 16
        Me.KryptonLabel2.Text = "Peso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Peso : "
        '
        'txtRecCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtRecCantidad, 2)
        Me.txtRecCantidad.Location = New System.Drawing.Point(91, 140)
        Me.txtRecCantidad.Name = "txtRecCantidad"
        Me.txtRecCantidad.Size = New System.Drawing.Size(97, 22)
        Me.txtRecCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecCantidad.TabIndex = 15
        Me.txtRecCantidad.Text = "0.00"
        Me.txtRecCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(24, 143)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel4.TabIndex = 14
        Me.KryptonLabel4.Text = "Cantidad : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(91, 9)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(114, 22)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(228, 255)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAgregarRecepcionItem
        '
        Me.btnAgregarRecepcionItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarRecepcionItem.Location = New System.Drawing.Point(142, 255)
        Me.btnAgregarRecepcionItem.Name = "btnAgregarRecepcionItem"
        Me.btnAgregarRecepcionItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarRecepcionItem.TabIndex = 25
        Me.btnAgregarRecepcionItem.Text = "Agregar"
        Me.btnAgregarRecepcionItem.Values.ExtraText = ""
        Me.btnAgregarRecepcionItem.Values.Image = CType(resources.GetObject("btnAgregarRecepcionItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarRecepcionItem.Values.Text = "Agregar"
        '
        'lblNroRUCCliente
        '
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(37, 36)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblNroRUCCliente.TabIndex = 6
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(25, 12)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblNroOrdenCompra.TabIndex = 2
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'txtNroRUCCliente
        '
        Me.txtNroRUCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroRUCCliente, True)
        Me.txtNroRUCCliente.Location = New System.Drawing.Point(91, 34)
        Me.txtNroRUCCliente.MaxLength = 30
        Me.txtNroRUCCliente.Name = "txtNroRUCCliente"
        Me.txtNroRUCCliente.Size = New System.Drawing.Size(114, 22)
        Me.txtNroRUCCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroRUCCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroRUCCliente.TabIndex = 7
        Me.txtNroRUCCliente.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroRUCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(210, 10)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(64, 20)
        Me.lblNroGuiaCliente.TabIndex = 4
        Me.lblNroGuiaCliente.Text = "No. Guía : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "No. Guía : "
        '
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaCliente, True)
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(274, 9)
        Me.txtNroGuiaCliente.MaxLength = 15
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(101, 22)
        Me.txtNroGuiaCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtNroGuiaCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'frmSolicInforRecAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAgregarRecepcionItem
        Me.ClientSize = New System.Drawing.Size(386, 294)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSolicInforRecAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDesglose As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtRecPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarRecepcionItem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoMovimientoIng As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtZonaAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
