<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWSolicInforDesAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWSolicInforDesAlmacen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtVigencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblVigencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoDespacho = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoDespachoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDesPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDesCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarDespachoItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.lblProducto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtProducto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtProducto)
        Me.KryptonPanel.Controls.Add(Me.lblProducto)
        Me.KryptonPanel.Controls.Add(Me.txtVigencia)
        Me.KryptonPanel.Controls.Add(Me.lblVigencia)
        Me.KryptonPanel.Controls.Add(Me.txtTipoDespacho)
        Me.KryptonPanel.Controls.Add(Me.lblTipoDespacho)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.txtRecObservacion)
        Me.KryptonPanel.Controls.Add(Me.txtDesPeso)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtDesCantidad)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarDespachoItem)
        Me.KryptonPanel.Controls.Add(Me.lblNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.txtNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(344, 229)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtVigencia
        '
        Me.txtVigencia.Location = New System.Drawing.Point(77, 87)
        Me.txtVigencia.Name = "txtVigencia"
        Me.txtVigencia.Size = New System.Drawing.Size(97, 21)
        Me.txtVigencia.TabIndex = 18
        Me.txtVigencia.Text = "0"
        Me.txtVigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtVigencia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblVigencia
        '
        Me.lblVigencia.Location = New System.Drawing.Point(10, 90)
        Me.lblVigencia.Name = "lblVigencia"
        Me.lblVigencia.Size = New System.Drawing.Size(58, 19)
        Me.lblVigencia.TabIndex = 17
        Me.lblVigencia.Text = "Vigencia : "
        Me.lblVigencia.Values.ExtraText = ""
        Me.lblVigencia.Values.Image = Nothing
        Me.lblVigencia.Values.Text = "Vigencia : "
        '
        'txtTipoDespacho
        '
        Me.txtTipoDespacho.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoDespachoListar})
        Me.txtTipoDespacho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoDespacho, True)
        Me.txtTipoDespacho.Location = New System.Drawing.Point(77, 140)
        Me.txtTipoDespacho.MaxLength = 50
        Me.txtTipoDespacho.Name = "txtTipoDespacho"
        Me.txtTipoDespacho.Size = New System.Drawing.Size(254, 21)
        Me.txtTipoDespacho.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoDespacho.TabIndex = 20
        Me.TypeValidator.SetTypes(Me.txtTipoDespacho, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTipoDespachoListar
        '
        Me.bsaTipoDespachoListar.ExtraText = ""
        Me.bsaTipoDespachoListar.Image = Nothing
        Me.bsaTipoDespachoListar.Text = ""
        Me.bsaTipoDespachoListar.ToolTipImage = Nothing
        Me.bsaTipoDespachoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoDespachoListar.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'lblTipoDespacho
        '
        Me.lblTipoDespacho.Location = New System.Drawing.Point(10, 143)
        Me.lblTipoDespacho.Name = "lblTipoDespacho"
        Me.lblTipoDespacho.Size = New System.Drawing.Size(63, 19)
        Me.lblTipoDespacho.TabIndex = 19
        Me.lblTipoDespacho.Text = "Tipo Dsp. : "
        Me.lblTipoDespacho.Values.ExtraText = ""
        Me.lblTipoDespacho.Values.Image = Nothing
        Me.lblTipoDespacho.Values.Text = "Tipo Dsp. : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(10, 168)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(53, 19)
        Me.KryptonLabel7.TabIndex = 21
        Me.KryptonLabel7.Text = "Observ. : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observ. : "
        '
        'txtRecObservacion
        '
        Me.txtRecObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRecObservacion, True)
        Me.txtRecObservacion.Location = New System.Drawing.Point(77, 165)
        Me.txtRecObservacion.MaxLength = 25
        Me.txtRecObservacion.Name = "txtRecObservacion"
        Me.txtRecObservacion.Size = New System.Drawing.Size(254, 21)
        Me.txtRecObservacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtRecObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtRecObservacion.TabIndex = 22
        Me.TypeValidator.SetTypes(Me.txtRecObservacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtDesPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtDesPeso, 2)
        Me.txtDesPeso.Location = New System.Drawing.Point(247, 62)
        Me.txtDesPeso.Name = "txtDesPeso"
        Me.txtDesPeso.Size = New System.Drawing.Size(81, 21)
        Me.txtDesPeso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesPeso.TabIndex = 16
        Me.txtDesPeso.Text = "0.00"
        Me.txtDesPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtDesPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(200, 65)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Text = "Peso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Peso : "
        '
        'txtDesCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtDesCantidad, 2)
        Me.txtDesCantidad.Location = New System.Drawing.Point(77, 62)
        Me.txtDesCantidad.Name = "txtDesCantidad"
        Me.txtDesCantidad.Size = New System.Drawing.Size(97, 21)
        Me.txtDesCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesCantidad.TabIndex = 14
        Me.txtDesCantidad.Text = "0.00"
        Me.txtDesCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtDesCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(10, 65)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Cantidad : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(77, 12)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(97, 21)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(251, 192)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAgregarDespachoItem
        '
        Me.btnAgregarDespachoItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarDespachoItem.Location = New System.Drawing.Point(165, 192)
        Me.btnAgregarDespachoItem.Name = "btnAgregarDespachoItem"
        Me.btnAgregarDespachoItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarDespachoItem.TabIndex = 23
        Me.btnAgregarDespachoItem.Text = "Agregar"
        Me.btnAgregarDespachoItem.Values.ExtraText = ""
        Me.btnAgregarDespachoItem.Values.Image = CType(resources.GetObject("btnAgregarDespachoItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarDespachoItem.Values.Text = "Agregar"
        '
        'lblNroRUCCliente
        '
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(10, 40)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(45, 19)
        Me.lblNroRUCCliente.TabIndex = 5
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(10, 15)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(60, 19)
        Me.lblNroOrdenCompra.TabIndex = 1
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'txtNroRUCCliente
        '
        Me.txtNroRUCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroRUCCliente, True)
        Me.txtNroRUCCliente.Location = New System.Drawing.Point(77, 37)
        Me.txtNroRUCCliente.MaxLength = 30
        Me.txtNroRUCCliente.Name = "txtNroRUCCliente"
        Me.txtNroRUCCliente.Size = New System.Drawing.Size(97, 21)
        Me.txtNroRUCCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroRUCCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroRUCCliente.TabIndex = 6
        Me.txtNroRUCCliente.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroRUCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(180, 15)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(59, 19)
        Me.lblNroGuiaCliente.TabIndex = 3
        Me.lblNroGuiaCliente.Text = "No. Guía : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "No. Guía : "
        '
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaCliente, True)
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(247, 12)
        Me.txtNroGuiaCliente.MaxLength = 30
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(84, 21)
        Me.txtNroGuiaCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroGuiaCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblProducto
        '
        Me.lblProducto.Location = New System.Drawing.Point(10, 114)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(58, 19)
        Me.lblProducto.TabIndex = 25
        Me.lblProducto.Text = "Producto:"
        Me.lblProducto.Values.ExtraText = ""
        Me.lblProducto.Values.Image = Nothing
        Me.lblProducto.Values.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtProducto, True)
        Me.txtProducto.Location = New System.Drawing.Point(77, 114)
        Me.txtProducto.MaxLength = 25
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(254, 21)
        Me.txtProducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProducto.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtProducto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtProducto.TabIndex = 26
        Me.TypeValidator.SetTypes(Me.txtProducto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'frmSolicInforDesAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAgregarDespachoItem
        Me.ClientSize = New System.Drawing.Size(344, 229)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSolicInforDesAlmacen"
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
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDesPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDesCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarDespachoItem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtVigencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVigencia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoDespacho As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoDespachoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProducto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtProducto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
