<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.KryptonComboBox1 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cboLugarDestino = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboLugarorigen = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtEmbarque = New Ransa.Utilitario.clsTextBoxNumero
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.lblFecFin = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFecIni = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.lblEstado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.btAceptar = New System.Windows.Forms.ToolStripButton
        Me.lblTipo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboTipoOperacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.cmbCliente)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.DateTimePicker1)
        Me.KryptonPanel.Controls.Add(Me.DateTimePicker2)
        Me.KryptonPanel.Controls.Add(Me.KryptonComboBox1)
        Me.KryptonPanel.Controls.Add(Me.KryptonCheckBox1)
        Me.KryptonPanel.Controls.Add(Me.cboLugarDestino)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Controls.Add(Me.cboLugarorigen)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.txtEmbarque)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel37)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel36)
        Me.KryptonPanel.Controls.Add(Me.cmbPlanta)
        Me.KryptonPanel.Controls.Add(Me.cmbDivision)
        Me.KryptonPanel.Controls.Add(Me.dtpInicio)
        Me.KryptonPanel.Controls.Add(Me.lblFecFin)
        Me.KryptonPanel.Controls.Add(Me.lblFecIni)
        Me.KryptonPanel.Controls.Add(Me.dtpFin)
        Me.KryptonPanel.Controls.Add(Me.cmbEstado)
        Me.KryptonPanel.Controls.Add(Me.lblEstado)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(777, 216)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.White
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCliente.Location = New System.Drawing.Point(107, 60)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(245, 22)
        Me.cmbCliente.TabIndex = 186
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(14, 62)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 187
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(212, 142)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(21, 20)
        Me.KryptonLabel2.TabIndex = 185
        Me.KryptonLabel2.Text = "Al"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Al"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.CustomFormat = "MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 142)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 183
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DateTimePicker2.CustomFormat = "MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(257, 142)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 184
        '
        'KryptonComboBox1
        '
        Me.KryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KryptonComboBox1.DropDownWidth = 253
        Me.KryptonComboBox1.FormattingEnabled = False
        Me.KryptonComboBox1.ItemHeight = 15
        Me.KryptonComboBox1.Location = New System.Drawing.Point(107, 114)
        Me.KryptonComboBox1.Name = "KryptonComboBox1"
        Me.KryptonComboBox1.Size = New System.Drawing.Size(245, 23)
        Me.KryptonComboBox1.TabIndex = 182
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Checked = False
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(14, 117)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(87, 20)
        Me.KryptonCheckBox1.TabIndex = 181
        Me.KryptonCheckBox1.Text = "CheckPoint:"
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = "CheckPoint:"
        '
        'cboLugarDestino
        '
        Me.cboLugarDestino.BackColor = System.Drawing.Color.Transparent
        Me.cboLugarDestino.DataSource = Nothing
        Me.cboLugarDestino.DispleyMember = ""
        Me.cboLugarDestino.Etiquetas_Form = Nothing
        Me.cboLugarDestino.ListColumnas = Nothing
        Me.cboLugarDestino.Location = New System.Drawing.Point(463, 170)
        Me.cboLugarDestino.Name = "cboLugarDestino"
        Me.cboLugarDestino.Obligatorio = False
        Me.cboLugarDestino.PopupHeight = 0
        Me.cboLugarDestino.PopupWidth = 0
        Me.cboLugarDestino.Size = New System.Drawing.Size(271, 21)
        Me.cboLugarDestino.TabIndex = 174
        Me.cboLugarDestino.ValueMember = ""
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(367, 171)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel11.TabIndex = 176
        Me.KryptonLabel11.Text = "Lugar destino:"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Lugar destino:"
        '
        'cboLugarorigen
        '
        Me.cboLugarorigen.BackColor = System.Drawing.Color.Transparent
        Me.cboLugarorigen.DataSource = Nothing
        Me.cboLugarorigen.DispleyMember = ""
        Me.cboLugarorigen.Etiquetas_Form = Nothing
        Me.cboLugarorigen.ListColumnas = Nothing
        Me.cboLugarorigen.Location = New System.Drawing.Point(107, 171)
        Me.cboLugarorigen.Name = "cboLugarorigen"
        Me.cboLugarorigen.Obligatorio = False
        Me.cboLugarorigen.PopupHeight = 0
        Me.cboLugarorigen.PopupWidth = 0
        Me.cboLugarorigen.Size = New System.Drawing.Size(245, 21)
        Me.cboLugarorigen.TabIndex = 173
        Me.cboLugarorigen.ValueMember = ""
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(14, 171)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(83, 20)
        Me.KryptonLabel10.TabIndex = 175
        Me.KryptonLabel10.Text = "Lugar origen:"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Lugar origen:"
        '
        'txtEmbarque
        '
        Me.txtEmbarque.Location = New System.Drawing.Point(107, 88)
        Me.txtEmbarque.MaxLength = 10
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.NUMDECIMALES = 0
        Me.txtEmbarque.NUMENTEROS = 10
        Me.txtEmbarque.Size = New System.Drawing.Size(67, 20)
        Me.txtEmbarque.TabIndex = 78
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(14, 88)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 79
        Me.KryptonLabel4.Text = "Embarque :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Embarque :"
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(367, 34)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel37.TabIndex = 77
        Me.KryptonLabel37.Text = "Planta"
        Me.KryptonLabel37.Values.ExtraText = ""
        Me.KryptonLabel37.Values.Image = Nothing
        Me.KryptonLabel37.Values.Text = "Planta"
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(14, 34)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel36.TabIndex = 76
        Me.KryptonLabel36.Text = "División"
        Me.KryptonLabel36.Values.ExtraText = ""
        Me.KryptonLabel36.Values.Image = Nothing
        Me.KryptonLabel36.Values.Text = "División"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(463, 31)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta1
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(271, 23)
        Me.cmbPlanta.TabIndex = 67
        Me.cmbPlanta.Usuario = ""
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(107, 31)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.obeDivision = Nothing
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(245, 23)
        Me.cmbDivision.TabIndex = 66
        Me.cmbDivision.Usuario = ""
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarFont = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.dtpInicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(463, 88)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpInicio.TabIndex = 70
        '
        'lblFecFin
        '
        Me.lblFecFin.Location = New System.Drawing.Point(582, 88)
        Me.lblFecFin.Name = "lblFecFin"
        Me.lblFecFin.Size = New System.Drawing.Size(21, 20)
        Me.lblFecFin.TabIndex = 74
        Me.lblFecFin.Text = "Al"
        Me.lblFecFin.Values.ExtraText = ""
        Me.lblFecFin.Values.Image = Nothing
        Me.lblFecFin.Values.Text = "Al"
        '
        'lblFecIni
        '
        Me.lblFecIni.Location = New System.Drawing.Point(367, 88)
        Me.lblFecIni.Name = "lblFecIni"
        Me.lblFecIni.Size = New System.Drawing.Size(87, 20)
        Me.lblFecIni.TabIndex = 73
        Me.lblFecIni.Text = "Fec. apertura :"
        Me.lblFecIni.Values.ExtraText = ""
        Me.lblFecIni.Values.Image = Nothing
        Me.lblFecIni.Values.Text = "Fec. apertura :"
        '
        'dtpFin
        '
        Me.dtpFin.CalendarFont = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(640, 86)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(94, 20)
        Me.dtpFin.TabIndex = 71
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(463, 60)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(113, 22)
        Me.cmbEstado.TabIndex = 69
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(367, 62)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(53, 20)
        Me.lblEstado.TabIndex = 72
        Me.lblEstado.Text = "Estado :"
        Me.lblEstado.Values.ExtraText = ""
        Me.lblEstado.Values.Image = Nothing
        Me.lblEstado.Values.Text = "Estado :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.btAceptar, Me.lblTipo, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(777, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(59, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'btAceptar
        '
        Me.btAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btAceptar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok1
        Me.btAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btAceptar.Text = "Aceptar"
        '
        'lblTipo
        '
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "Tipo:Local"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(582, 60)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel1.TabIndex = 188
        Me.KryptonLabel1.Text = "Tipo :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo :"
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoOperacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoOperacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(621, 58)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(113, 22)
        Me.cboTipoOperacion.TabIndex = 189
        '
        'frmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 216)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmExportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exportar información"
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
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecFin As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFecIni As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmbarque As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboLugarDestino As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboLugarorigen As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonComboBox1 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
