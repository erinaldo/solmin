<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAlmacenaje_FAlmF01
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
        Me.grpServicio = New System.Windows.Forms.GroupBox
        Me.dteFechaOperacion = New System.Windows.Forms.DateTimePicker
        Me.lblFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxServicio = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.grpParametros = New System.Windows.Forms.GroupBox
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxMoneda = New Ransa.Controls.Moneda.ucMoneda_CmbF01
        Me.lblNota = New System.Windows.Forms.Label
        Me.txtValorRef = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblValorRef = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblValorizarPor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxValorizarPor = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.chkFiltro = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtDiaLibres = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDiaLibres = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblObservacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblAnio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.lblMes = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblfechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.txtPaleta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPaleta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUbicacion = New Ransa.Controls.CtrlsSolminSA.ucCtrlsSolminSA_TxUbicAlm
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTermInter = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUbicacionReferencial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpServicio.SuspendLayout()
        Me.grpParametros.SuspendLayout()
        Me.grpFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpServicio)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnProcesar)
        Me.KryptonPanel.Controls.Add(Me.grpParametros)
        Me.KryptonPanel.Controls.Add(Me.grpFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(553, 490)
        Me.KryptonPanel.TabIndex = 0
        '
        'grpServicio
        '
        Me.grpServicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpServicio.Controls.Add(Me.dteFechaOperacion)
        Me.grpServicio.Controls.Add(Me.lblFechaOperacion)
        Me.grpServicio.Controls.Add(Me.lblServicio)
        Me.grpServicio.Controls.Add(Me.cbxServicio)
        Me.grpServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServicio.Location = New System.Drawing.Point(12, 260)
        Me.grpServicio.Name = "grpServicio"
        Me.grpServicio.Size = New System.Drawing.Size(529, 76)
        Me.grpServicio.TabIndex = 22
        Me.grpServicio.TabStop = False
        Me.grpServicio.Text = "SERVICIO : "
        '
        'dteFechaOperacion
        '
        Me.dteFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaOperacion.Location = New System.Drawing.Point(93, 19)
        Me.dteFechaOperacion.Name = "dteFechaOperacion"
        Me.dteFechaOperacion.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaOperacion.TabIndex = 24
        '
        'lblFechaOperacion
        '
        Me.lblFechaOperacion.Location = New System.Drawing.Point(6, 23)
        Me.lblFechaOperacion.Name = "lblFechaOperacion"
        Me.lblFechaOperacion.Size = New System.Drawing.Size(48, 16)
        Me.lblFechaOperacion.TabIndex = 23
        Me.lblFechaOperacion.Text = "Fecha : "
        Me.lblFechaOperacion.Values.ExtraText = ""
        Me.lblFechaOperacion.Values.Image = Nothing
        Me.lblFechaOperacion.Values.Text = "Fecha : "
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(6, 50)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(57, 16)
        Me.lblServicio.TabIndex = 25
        Me.lblServicio.Text = "Servicio :"
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio :"
        '
        'cbxServicio
        '
        Me.cbxServicio.DropDownWidth = 434
        Me.cbxServicio.FormattingEnabled = False
        Me.cbxServicio.ItemHeight = 13
        Me.cbxServicio.Location = New System.Drawing.Point(93, 45)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(430, 21)
        Me.cbxServicio.TabIndex = 26
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(445, 453)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(349, 453)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(90, 25)
        Me.btnProcesar.TabIndex = 36
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = ""
        Me.btnProcesar.Values.Image = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'grpParametros
        '
        Me.grpParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpParametros.BackColor = System.Drawing.Color.Transparent
        Me.grpParametros.Controls.Add(Me.lblMoneda)
        Me.grpParametros.Controls.Add(Me.cbxMoneda)
        Me.grpParametros.Controls.Add(Me.lblNota)
        Me.grpParametros.Controls.Add(Me.txtValorRef)
        Me.grpParametros.Controls.Add(Me.lblValorRef)
        Me.grpParametros.Controls.Add(Me.lblValorizarPor)
        Me.grpParametros.Controls.Add(Me.cbxValorizarPor)
        Me.grpParametros.Controls.Add(Me.chkFiltro)
        Me.grpParametros.Controls.Add(Me.txtDiaLibres)
        Me.grpParametros.Controls.Add(Me.lblDiaLibres)
        Me.grpParametros.Controls.Add(Me.txtObservacion)
        Me.grpParametros.Controls.Add(Me.lblObservacion)
        Me.grpParametros.Controls.Add(Me.txtAnio)
        Me.grpParametros.Controls.Add(Me.txtMes)
        Me.grpParametros.Controls.Add(Me.lblAnio)
        Me.grpParametros.Controls.Add(Me.dtpFechaFinal)
        Me.grpParametros.Controls.Add(Me.lblMes)
        Me.grpParametros.Controls.Add(Me.lblfechaInicial)
        Me.grpParametros.Controls.Add(Me.lblFechaFinal)
        Me.grpParametros.Controls.Add(Me.dtpFechaInicial)
        Me.grpParametros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParametros.Location = New System.Drawing.Point(12, 12)
        Me.grpParametros.Name = "grpParametros"
        Me.grpParametros.Size = New System.Drawing.Size(529, 242)
        Me.grpParametros.TabIndex = 1
        Me.grpParametros.TabStop = False
        Me.grpParametros.Text = "PROCESO : "
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(6, 152)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(57, 16)
        Me.lblMoneda.TabIndex = 16
        Me.lblMoneda.Text = "Moneda : "
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda : "
        '
        'cbxMoneda
        '
        Me.cbxMoneda.Location = New System.Drawing.Point(93, 147)
        Me.cbxMoneda.Name = "cbxMoneda"
        Me.cbxMoneda.pIsRequired = False
        Me.cbxMoneda.Size = New System.Drawing.Size(185, 21)
        Me.cbxMoneda.TabIndex = 17
        '
        'lblNota
        '
        Me.lblNota.ForeColor = System.Drawing.Color.Brown
        Me.lblNota.Location = New System.Drawing.Point(95, 203)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(430, 31)
        Me.lblNota.TabIndex = 21
        Me.lblNota.Text = "( * ) El valor referencial, es el costo de Almacenamiento por cada día de permane" & _
            "ncia de la unidad seleccionada."
        '
        'txtValorRef
        '
        Me.TypeValidator.SetDecimales(Me.txtValorRef, 4)
        Me.TypeValidator.SetEnterTAB(Me.txtValorRef, True)
        Me.txtValorRef.Location = New System.Drawing.Point(394, 149)
        Me.txtValorRef.Name = "txtValorRef"
        Me.txtValorRef.Size = New System.Drawing.Size(129, 19)
        Me.txtValorRef.TabIndex = 19
        Me.txtValorRef.Text = "0.0000"
        Me.txtValorRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtValorRef, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblValorRef
        '
        Me.lblValorRef.Location = New System.Drawing.Point(284, 152)
        Me.lblValorRef.Name = "lblValorRef"
        Me.lblValorRef.Size = New System.Drawing.Size(103, 16)
        Me.lblValorRef.TabIndex = 18
        Me.lblValorRef.Text = "Valor Referencial :"
        Me.lblValorRef.Values.ExtraText = ""
        Me.lblValorRef.Values.Image = Nothing
        Me.lblValorRef.Values.Text = "Valor Referencial :"
        '
        'lblValorizarPor
        '
        Me.lblValorizarPor.Location = New System.Drawing.Point(6, 125)
        Me.lblValorizarPor.Name = "lblValorizarPor"
        Me.lblValorizarPor.Size = New System.Drawing.Size(78, 16)
        Me.lblValorizarPor.TabIndex = 14
        Me.lblValorizarPor.Text = "Valorizar por:"
        Me.lblValorizarPor.Values.ExtraText = ""
        Me.lblValorizarPor.Values.Image = Nothing
        Me.lblValorizarPor.Values.Text = "Valorizar por:"
        '
        'cbxValorizarPor
        '
        Me.cbxValorizarPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxValorizarPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxValorizarPor.DropDownWidth = 185
        Me.cbxValorizarPor.FormattingEnabled = False
        Me.cbxValorizarPor.ItemHeight = 13
        Me.cbxValorizarPor.Items.AddRange(New Object() {"A - Área", "P - Peso", "V - Volumen"})
        Me.cbxValorizarPor.Location = New System.Drawing.Point(93, 120)
        Me.cbxValorizarPor.Name = "cbxValorizarPor"
        Me.cbxValorizarPor.Size = New System.Drawing.Size(185, 21)
        Me.cbxValorizarPor.TabIndex = 15
        '
        'chkFiltro
        '
        Me.chkFiltro.Checked = False
        Me.chkFiltro.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFiltro.Location = New System.Drawing.Point(95, 174)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(86, 16)
        Me.chkFiltro.TabIndex = 20
        Me.chkFiltro.Text = "Utilizar Filtro"
        Me.chkFiltro.Values.ExtraText = ""
        Me.chkFiltro.Values.Image = Nothing
        Me.chkFiltro.Values.Text = "Utilizar Filtro"
        '
        'txtDiaLibres
        '
        Me.txtDiaLibres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDiaLibres, True)
        Me.txtDiaLibres.Location = New System.Drawing.Point(463, 47)
        Me.txtDiaLibres.MaxLength = 2
        Me.txtDiaLibres.Name = "txtDiaLibres"
        Me.txtDiaLibres.Size = New System.Drawing.Size(60, 19)
        Me.txtDiaLibres.TabIndex = 11
        Me.txtDiaLibres.Text = "0"
        Me.txtDiaLibres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtDiaLibres, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblDiaLibres
        '
        Me.lblDiaLibres.Location = New System.Drawing.Point(394, 50)
        Me.lblDiaLibres.Name = "lblDiaLibres"
        Me.lblDiaLibres.Size = New System.Drawing.Size(67, 16)
        Me.lblDiaLibres.TabIndex = 10
        Me.lblDiaLibres.Text = "Día Libres : "
        Me.lblDiaLibres.Values.ExtraText = ""
        Me.lblDiaLibres.Values.Image = Nothing
        Me.lblDiaLibres.Values.Text = "Día Libres : "
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtObservacion, True)
        Me.txtObservacion.Location = New System.Drawing.Point(93, 72)
        Me.txtObservacion.MaxLength = 60
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(430, 42)
        Me.txtObservacion.TabIndex = 13
        Me.TypeValidator.SetTypes(Me.txtObservacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(6, 75)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(80, 16)
        Me.lblObservacion.TabIndex = 12
        Me.lblObservacion.Text = "Observación : "
        Me.lblObservacion.Values.ExtraText = ""
        Me.lblObservacion.Values.Image = Nothing
        Me.lblObservacion.Values.Text = "Observación : "
        '
        'txtAnio
        '
        Me.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtAnio, True)
        Me.txtAnio.Location = New System.Drawing.Point(93, 21)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(88, 19)
        Me.txtAnio.TabIndex = 3
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtAnio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtMes
        '
        Me.txtMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtMes, True)
        Me.txtMes.Location = New System.Drawing.Point(284, 21)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(88, 19)
        Me.txtMes.TabIndex = 5
        Me.txtMes.Text = "0"
        Me.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtMes, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblAnio
        '
        Me.lblAnio.Location = New System.Drawing.Point(6, 24)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(36, 16)
        Me.lblAnio.TabIndex = 2
        Me.lblAnio.Text = "Año : "
        Me.lblAnio.Values.ExtraText = ""
        Me.lblAnio.Values.Image = Nothing
        Me.lblAnio.Values.Text = "Año : "
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(284, 46)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 9
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(212, 24)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(38, 16)
        Me.lblMes.TabIndex = 4
        Me.lblMes.Text = "Mes : "
        Me.lblMes.Values.ExtraText = ""
        Me.lblMes.Values.Image = Nothing
        Me.lblMes.Values.Text = "Mes : "
        '
        'lblfechaInicial
        '
        Me.lblfechaInicial.Location = New System.Drawing.Point(6, 50)
        Me.lblfechaInicial.Name = "lblfechaInicial"
        Me.lblfechaInicial.Size = New System.Drawing.Size(71, 16)
        Me.lblfechaInicial.TabIndex = 6
        Me.lblfechaInicial.Text = "Fch. Inicial : "
        Me.lblfechaInicial.Values.ExtraText = ""
        Me.lblfechaInicial.Values.Image = Nothing
        Me.lblfechaInicial.Values.Text = "Fch. Inicial : "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(212, 50)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(66, 16)
        Me.lblFechaFinal.TabIndex = 8
        Me.lblFechaFinal.Text = "Fch. Final :"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fch. Final :"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(93, 46)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicial.TabIndex = 7
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtPaleta)
        Me.grpFiltro.Controls.Add(Me.lblPaleta)
        Me.grpFiltro.Controls.Add(Me.txtUbicacion)
        Me.grpFiltro.Controls.Add(Me.txtCodigoRecepcion)
        Me.grpFiltro.Controls.Add(Me.lblCodigoRecepcion)
        Me.grpFiltro.Controls.Add(Me.cmbTermInter)
        Me.grpFiltro.Controls.Add(Me.lblTerminoInternacional)
        Me.grpFiltro.Controls.Add(Me.lblUbicacionReferencial)
        Me.grpFiltro.Enabled = False
        Me.grpFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltro.Location = New System.Drawing.Point(12, 342)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(529, 98)
        Me.grpFiltro.TabIndex = 27
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "FILTRO : "
        '
        'txtPaleta
        '
        Me.txtPaleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtPaleta, True)
        Me.txtPaleta.Location = New System.Drawing.Point(89, 69)
        Me.txtPaleta.MaxLength = 100
        Me.txtPaleta.Name = "txtPaleta"
        Me.txtPaleta.Size = New System.Drawing.Size(434, 19)
        Me.txtPaleta.TabIndex = 35
        Me.TypeValidator.SetTypes(Me.txtPaleta, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblPaleta
        '
        Me.lblPaleta.Location = New System.Drawing.Point(6, 72)
        Me.lblPaleta.Name = "lblPaleta"
        Me.lblPaleta.Size = New System.Drawing.Size(54, 16)
        Me.lblPaleta.TabIndex = 34
        Me.lblPaleta.Text = "Paletas : "
        Me.lblPaleta.Values.ExtraText = ""
        Me.lblPaleta.Values.Image = Nothing
        Me.lblPaleta.Values.Text = "Paletas : "
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(89, 19)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.pRequerido = False
        Me.txtUbicacion.Size = New System.Drawing.Size(175, 19)
        Me.txtUbicacion.TabIndex = 29
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoRecepcion, True)
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(89, 44)
        Me.txtCodigoRecepcion.MaxLength = 100
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(434, 19)
        Me.txtCodigoRecepcion.TabIndex = 33
        Me.TypeValidator.SetTypes(Me.txtCodigoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCodigoRecepcion
        '
        Me.lblCodigoRecepcion.Location = New System.Drawing.Point(6, 47)
        Me.lblCodigoRecepcion.Name = "lblCodigoRecepcion"
        Me.lblCodigoRecepcion.Size = New System.Drawing.Size(48, 16)
        Me.lblCodigoRecepcion.TabIndex = 32
        Me.lblCodigoRecepcion.Text = "Bultos : "
        Me.lblCodigoRecepcion.Values.ExtraText = ""
        Me.lblCodigoRecepcion.Values.Image = Nothing
        Me.lblCodigoRecepcion.Values.Text = "Bultos : "
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(348, 17)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(175, 21)
        Me.cmbTermInter.TabIndex = 31
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(270, 22)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(72, 16)
        Me.lblTerminoInternacional.TabIndex = 30
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'lblUbicacionReferencial
        '
        Me.lblUbicacionReferencial.Location = New System.Drawing.Point(6, 22)
        Me.lblUbicacionReferencial.Name = "lblUbicacionReferencial"
        Me.lblUbicacionReferencial.Size = New System.Drawing.Size(66, 16)
        Me.lblUbicacionReferencial.TabIndex = 28
        Me.lblUbicacionReferencial.Text = "Ubicación : "
        Me.lblUbicacionReferencial.Values.ExtraText = ""
        Me.lblUbicacionReferencial.Values.Image = Nothing
        Me.lblUbicacionReferencial.Values.Text = "Ubicación : "
        '
        'ucAlmacenaje_FAlmF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 490)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ucAlmacenaje_FAlmF01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacenaje"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.grpServicio.ResumeLayout(False)
        Me.grpServicio.PerformLayout()
        Me.grpParametros.ResumeLayout(False)
        Me.grpParametros.PerformLayout()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
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
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents txtUbicacion As Ransa.Controls.CtrlsSolminSA.ucCtrlsSolminSA_TxUbicAlm
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTermInter As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUbicacionReferencial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpParametros As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblAnio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMes As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblObservacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDiaLibres As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDiaLibres As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPaleta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPaleta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents chkFiltro As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents grpServicio As System.Windows.Forms.GroupBox
    Private WithEvents dteFechaOperacion As System.Windows.Forms.DateTimePicker
    Private WithEvents lblFechaOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxServicio As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtValorRef As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblValorRef As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblValorizarPor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxValorizarPor As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxMoneda As Ransa.Controls.Moneda.ucMoneda_CmbF01
End Class
