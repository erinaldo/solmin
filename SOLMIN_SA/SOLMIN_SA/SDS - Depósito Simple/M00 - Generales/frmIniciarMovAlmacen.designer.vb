<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIniciarMovAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIniciarMovAlmacen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dteFechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.lblFechaRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkRegistrarServicio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaEmpresaTransporteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaUnidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtNroRUCEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaBreveteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblEtiquetaRUC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDocIdentidadChofer = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAnio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDocIdentidadChofer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMarca = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblChofer = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMarca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtChofer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dteFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.lblFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.chkRegistrarServicio)
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.lblObservaciones)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.txtEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel.Controls.Add(Me.txtNroRUCEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblBrevete)
        Me.KryptonPanel.Controls.Add(Me.txtBrevete)
        Me.KryptonPanel.Controls.Add(Me.lblEtiquetaRUC)
        Me.KryptonPanel.Controls.Add(Me.lblDocIdentidadChofer)
        Me.KryptonPanel.Controls.Add(Me.lblAnio)
        Me.KryptonPanel.Controls.Add(Me.txtDocIdentidadChofer)
        Me.KryptonPanel.Controls.Add(Me.lblMarca)
        Me.KryptonPanel.Controls.Add(Me.lblChofer)
        Me.KryptonPanel.Controls.Add(Me.txtMarca)
        Me.KryptonPanel.Controls.Add(Me.txtChofer)
        Me.KryptonPanel.Controls.Add(Me.txtAnio)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(407, 370)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dteFechaRecepcion
        '
        Me.dteFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaRecepcion.Location = New System.Drawing.Point(102, 12)
        Me.dteFechaRecepcion.Name = "dteFechaRecepcion"
        Me.dteFechaRecepcion.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaRecepcion.TabIndex = 23
        '
        'lblFechaRecepcion
        '
        Me.lblFechaRecepcion.Location = New System.Drawing.Point(51, 13)
        Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
        Me.lblFechaRecepcion.Size = New System.Drawing.Size(45, 16)
        Me.lblFechaRecepcion.TabIndex = 22
        Me.lblFechaRecepcion.Text = "Fecha:"
        Me.lblFechaRecepcion.Values.ExtraText = ""
        Me.lblFechaRecepcion.Values.Image = Nothing
        Me.lblFechaRecepcion.Values.Text = "Fecha:"
        '
        'chkRegistrarServicio
        '
        Me.chkRegistrarServicio.Checked = False
        Me.chkRegistrarServicio.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkRegistrarServicio.Location = New System.Drawing.Point(101, 292)
        Me.chkRegistrarServicio.Name = "chkRegistrarServicio"
        Me.chkRegistrarServicio.Size = New System.Drawing.Size(113, 16)
        Me.chkRegistrarServicio.TabIndex = 19
        Me.chkRegistrarServicio.Text = "Registrar Servicio"
        Me.chkRegistrarServicio.Values.ExtraText = ""
        Me.chkRegistrarServicio.Values.Image = Nothing
        Me.chkRegistrarServicio.Values.Text = "Registrar Servicio"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(101, 213)
        Me.txtObservaciones.MaxLength = 180
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(279, 73)
        Me.txtObservaciones.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtObservaciones.TabIndex = 18
        Me.TypeValidator.SetTypes(Me.txtObservaciones, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 216)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(80, 16)
        Me.lblObservaciones.TabIndex = 17
        Me.lblObservaciones.Text = "Observación : "
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observación : "
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(225, 317)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(119, 318)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 25)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'txtEmpresaTransporte
        '
        Me.txtEmpresaTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporteListar})
        Me.txtEmpresaTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(101, 38)
        Me.txtEmpresaTransporte.MaxLength = 30
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(279, 19)
        Me.txtEmpresaTransporte.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpresaTransporte.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtEmpresaTransporte.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtEmpresaTransporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaEmpresaTransporteListar
        '
        Me.bsaEmpresaTransporteListar.ExtraText = ""
        Me.bsaEmpresaTransporteListar.Image = Nothing
        Me.bsaEmpresaTransporteListar.Text = ""
        Me.bsaEmpresaTransporteListar.ToolTipImage = Nothing
        Me.bsaEmpresaTransporteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaEmpresaTransporteListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(40, 91)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(52, 16)
        Me.lblUnidad.TabIndex = 5
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'txtUnidad
        '
        Me.txtUnidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaUnidadListar})
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(101, 88)
        Me.txtUnidad.MaxLength = 6
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(140, 19)
        Me.txtUnidad.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtUnidad.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtUnidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaUnidadListar
        '
        Me.bsaUnidadListar.ExtraText = ""
        Me.bsaUnidadListar.Image = Nothing
        Me.bsaUnidadListar.Text = ""
        Me.bsaUnidadListar.ToolTipImage = Nothing
        Me.bsaUnidadListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaUnidadListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'txtNroRUCEmpresaTransporte
        '
        Me.txtNroRUCEmpresaTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroRUCEmpresaTransporte.Location = New System.Drawing.Point(101, 63)
        Me.txtNroRUCEmpresaTransporte.MaxLength = 4
        Me.txtNroRUCEmpresaTransporte.Name = "txtNroRUCEmpresaTransporte"
        Me.txtNroRUCEmpresaTransporte.ReadOnly = True
        Me.txtNroRUCEmpresaTransporte.Size = New System.Drawing.Size(140, 19)
        Me.txtNroRUCEmpresaTransporte.StateCommon.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtNroRUCEmpresaTransporte.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtNroRUCEmpresaTransporte.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroRUCEmpresaTransporte.TabIndex = 4
        Me.txtNroRUCEmpresaTransporte.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtNroRUCEmpresaTransporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(8, 41)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(82, 16)
        Me.lblEmpresaTransporte.TabIndex = 1
        Me.lblEmpresaTransporte.Text = "Transportista : "
        Me.lblEmpresaTransporte.Values.ExtraText = ""
        Me.lblEmpresaTransporte.Values.Image = Nothing
        Me.lblEmpresaTransporte.Values.Text = "Transportista : "
        '
        'lblBrevete
        '
        Me.lblBrevete.Location = New System.Drawing.Point(12, 141)
        Me.lblBrevete.Name = "lblBrevete"
        Me.lblBrevete.Size = New System.Drawing.Size(80, 16)
        Me.lblBrevete.TabIndex = 11
        Me.lblBrevete.Text = "Nro. Brevete : "
        Me.lblBrevete.Values.ExtraText = ""
        Me.lblBrevete.Values.Image = Nothing
        Me.lblBrevete.Values.Text = "Nro. Brevete : "
        '
        'txtBrevete
        '
        Me.txtBrevete.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaBreveteListar})
        Me.txtBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrevete.Location = New System.Drawing.Point(101, 138)
        Me.txtBrevete.MaxLength = 10
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Size = New System.Drawing.Size(140, 19)
        Me.txtBrevete.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtBrevete.TabIndex = 12
        Me.TypeValidator.SetTypes(Me.txtBrevete, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaBreveteListar
        '
        Me.bsaBreveteListar.ExtraText = ""
        Me.bsaBreveteListar.Image = Nothing
        Me.bsaBreveteListar.Text = ""
        Me.bsaBreveteListar.ToolTipImage = Nothing
        Me.bsaBreveteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaBreveteListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblEtiquetaRUC
        '
        Me.lblEtiquetaRUC.Location = New System.Drawing.Point(29, 66)
        Me.lblEtiquetaRUC.Name = "lblEtiquetaRUC"
        Me.lblEtiquetaRUC.Size = New System.Drawing.Size(65, 16)
        Me.lblEtiquetaRUC.TabIndex = 3
        Me.lblEtiquetaRUC.Text = "Nro. RUC :"
        Me.lblEtiquetaRUC.Values.ExtraText = ""
        Me.lblEtiquetaRUC.Values.Image = Nothing
        Me.lblEtiquetaRUC.Values.Text = "Nro. RUC :"
        '
        'lblDocIdentidadChofer
        '
        Me.lblDocIdentidadChofer.Location = New System.Drawing.Point(28, 191)
        Me.lblDocIdentidadChofer.Name = "lblDocIdentidadChofer"
        Me.lblDocIdentidadChofer.Size = New System.Drawing.Size(66, 16)
        Me.lblDocIdentidadChofer.TabIndex = 15
        Me.lblDocIdentidadChofer.Text = "No. D.N.I. :"
        Me.lblDocIdentidadChofer.Values.ExtraText = ""
        Me.lblDocIdentidadChofer.Values.Image = Nothing
        Me.lblDocIdentidadChofer.Values.Text = "No. D.N.I. :"
        '
        'lblAnio
        '
        Me.lblAnio.Location = New System.Drawing.Point(259, 116)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(36, 16)
        Me.lblAnio.TabIndex = 9
        Me.lblAnio.Text = "Año : "
        Me.lblAnio.Values.ExtraText = ""
        Me.lblAnio.Values.Image = Nothing
        Me.lblAnio.Values.Text = "Año : "
        '
        'txtDocIdentidadChofer
        '
        Me.txtDocIdentidadChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocIdentidadChofer.Location = New System.Drawing.Point(101, 188)
        Me.txtDocIdentidadChofer.MaxLength = 8
        Me.txtDocIdentidadChofer.Name = "txtDocIdentidadChofer"
        Me.txtDocIdentidadChofer.ReadOnly = True
        Me.txtDocIdentidadChofer.Size = New System.Drawing.Size(103, 19)
        Me.txtDocIdentidadChofer.StateCommon.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtDocIdentidadChofer.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtDocIdentidadChofer.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtDocIdentidadChofer.TabIndex = 16
        Me.txtDocIdentidadChofer.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtDocIdentidadChofer, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblMarca
        '
        Me.lblMarca.Location = New System.Drawing.Point(46, 67)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(48, 16)
        Me.lblMarca.TabIndex = 7
        Me.lblMarca.Text = "Marca : "
        Me.lblMarca.Values.ExtraText = ""
        Me.lblMarca.Values.Image = Nothing
        Me.lblMarca.Values.Text = "Marca : "
        '
        'lblChofer
        '
        Me.lblChofer.Location = New System.Drawing.Point(42, 163)
        Me.lblChofer.Name = "lblChofer"
        Me.lblChofer.Size = New System.Drawing.Size(50, 16)
        Me.lblChofer.TabIndex = 13
        Me.lblChofer.Text = "Chofer : "
        Me.lblChofer.Values.ExtraText = ""
        Me.lblChofer.Values.Image = Nothing
        Me.lblChofer.Values.Text = "Chofer : "
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Location = New System.Drawing.Point(101, 113)
        Me.txtMarca.MaxLength = 15
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(140, 19)
        Me.txtMarca.StateCommon.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtMarca.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtMarca.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtMarca.TabIndex = 8
        Me.txtMarca.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtMarca, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtChofer
        '
        Me.txtChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChofer.Location = New System.Drawing.Point(101, 163)
        Me.txtChofer.MaxLength = 30
        Me.txtChofer.Name = "txtChofer"
        Me.txtChofer.ReadOnly = True
        Me.txtChofer.Size = New System.Drawing.Size(279, 19)
        Me.txtChofer.StateCommon.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtChofer.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtChofer.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtChofer.TabIndex = 14
        Me.txtChofer.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtChofer, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtAnio
        '
        Me.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnio.Location = New System.Drawing.Point(301, 113)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Size = New System.Drawing.Size(79, 19)
        Me.txtAnio.StateCommon.Back.Color1 = System.Drawing.Color.LightGray
        Me.txtAnio.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtAnio.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtAnio.TabIndex = 10
        Me.txtAnio.TabStop = False
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtAnio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'frmIniciarMovAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(407, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmIniciarMovAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso de "
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
    Friend WithEvents bsaEmpresaTransporteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaUnidadListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaBreveteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents txtEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtNroRUCEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblBrevete As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtBrevete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblEtiquetaRUC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblDocIdentidadChofer As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblAnio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDocIdentidadChofer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblMarca As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblChofer As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtMarca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtChofer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents chkRegistrarServicio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dteFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
