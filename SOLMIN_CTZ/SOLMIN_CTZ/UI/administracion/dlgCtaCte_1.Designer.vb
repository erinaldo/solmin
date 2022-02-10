<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCtaCte
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCerrarRep = New System.Windows.Forms.ToolStripButton
        Me.btnAceptarRep = New System.Windows.Forms.ToolStripButton
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbRegionVenta = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.cmbPlanta = New SOLMIN_CT.CheckComboBoxTest.CheckedComboBox
        Me.UcDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbClase = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.ucCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cmbMoneda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbFechas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbCentroCosto = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbDetallado = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrarRep, Me.btnAceptarRep})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(410, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCerrarRep
        '
        Me.btnCerrarRep.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrarRep.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.btnCerrarRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrarRep.Name = "btnCerrarRep"
        Me.btnCerrarRep.Size = New System.Drawing.Size(55, 22)
        Me.btnCerrarRep.Text = "Cerrar"
        '
        'btnAceptarRep
        '
        Me.btnAceptarRep.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptarRep.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAceptarRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptarRep.Name = "btnAceptarRep"
        Me.btnAceptarRep.Size = New System.Drawing.Size(64, 22)
        Me.btnAceptarRep.Text = "Aceptar"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.PictureBox1)
        Me.KryptonPanel.Controls.Add(Me.cmbRegionVenta)
        Me.KryptonPanel.Controls.Add(Me.cmbPlanta)
        Me.KryptonPanel.Controls.Add(Me.UcDivision)
        Me.KryptonPanel.Controls.Add(Me.UcCompania)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.cmbClase)
        Me.KryptonPanel.Controls.Add(Me.ucCliente)
        Me.KryptonPanel.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.GroupBox2)
        Me.KryptonPanel.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(410, 316)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLMIN_CT.My.Resources.Resources.iconoEspera
        Me.PictureBox1.Location = New System.Drawing.Point(352, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cmbRegionVenta
        '
        Me.cmbRegionVenta.CheckOnClick = True
        Me.cmbRegionVenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbRegionVenta.DropDownHeight = 1
        Me.cmbRegionVenta.FormattingEnabled = True
        Me.cmbRegionVenta.IntegralHeight = False
        Me.cmbRegionVenta.Location = New System.Drawing.Point(111, 87)
        Me.cmbRegionVenta.Name = "cmbRegionVenta"
        Me.cmbRegionVenta.Size = New System.Drawing.Size(288, 21)
        Me.cmbRegionVenta.TabIndex = 101
        Me.cmbRegionVenta.ValueSeparator = ", "
        '
        'cmbPlanta
        '
        Me.cmbPlanta.CheckOnClick = True
        Me.cmbPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPlanta.DropDownHeight = 1
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.IntegralHeight = False
        Me.cmbPlanta.Location = New System.Drawing.Point(111, 62)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(288, 21)
        Me.cmbPlanta.TabIndex = 99
        Me.cmbPlanta.ValueSeparator = ", "
        '
        'UcDivision
        '
        Me.UcDivision.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision.CDVSN_ANTERIOR = Nothing
        Me.UcDivision.Compania = ""
        Me.UcDivision.Division = Nothing
        Me.UcDivision.DivisionDefault = Nothing
        Me.UcDivision.DivisionDescripcion = Nothing
        Me.UcDivision.ItemTodos = True
        Me.UcDivision.Location = New System.Drawing.Point(111, 35)
        Me.UcDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision.Name = "UcDivision"
        Me.UcDivision.pHabilitado = True
        Me.UcDivision.pRequerido = False
        Me.UcDivision.Size = New System.Drawing.Size(288, 23)
        Me.UcDivision.TabIndex = 97
        Me.UcDivision.Usuario = ""
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Location = New System.Drawing.Point(111, 8)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        Me.UcCompania.Size = New System.Drawing.Size(288, 23)
        Me.UcCompania.TabIndex = 89
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 89)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(79, 16)
        Me.KryptonLabel9.TabIndex = 20
        Me.KryptonLabel9.Text = "Región Venta"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Región Venta"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 64)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(42, 16)
        Me.KryptonLabel4.TabIndex = 7
        Me.KryptonLabel4.Text = "Planta"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Planta"
        '
        'cmbClase
        '
        Me.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClase.DropDownWidth = 258
        Me.cmbClase.FormattingEnabled = False
        Me.cmbClase.ItemHeight = 13
        Me.cmbClase.Location = New System.Drawing.Point(111, 168)
        Me.cmbClase.Name = "cmbClase"
        Me.cmbClase.Size = New System.Drawing.Size(288, 21)
        Me.cmbClase.TabIndex = 15
        '
        'ucCliente
        '
        Me.ucCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucCliente.BackColor = System.Drawing.Color.Transparent
        Me.ucCliente.CCMPN = "EZ"
        Me.ucCliente.Location = New System.Drawing.Point(111, 114)
        Me.ucCliente.Name = "ucCliente"
        Me.ucCliente.pAccesoPorUsuario = False
        Me.ucCliente.pRequerido = False
        Me.ucCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.ucCliente.Size = New System.Drawing.Size(288, 19)
        Me.ucCliente.TabIndex = 11
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.DropDownWidth = 258
        Me.cmbMoneda.FormattingEnabled = False
        Me.cmbMoneda.ItemHeight = 13
        Me.cmbMoneda.Location = New System.Drawing.Point(111, 141)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(288, 21)
        Me.cmbMoneda.TabIndex = 13
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 170)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(96, 16)
        Me.KryptonLabel6.TabIndex = 14
        Me.KryptonLabel6.Text = "Clase de Importe"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Clase de Importe"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 39)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(50, 16)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "División"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 116)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(46, 16)
        Me.KryptonLabel3.TabIndex = 10
        Me.KryptonLabel3.Text = "Cliente"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 143)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(51, 16)
        Me.KryptonLabel2.TabIndex = 12
        Me.KryptonLabel2.Text = "Moneda"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Moneda"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Compañia"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cbFechas)
        Me.GroupBox2.Controls.Add(Me.dtFechaFin)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel8)
        Me.GroupBox2.Controls.Add(Me.dtFechaInicio)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 55)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango"
        '
        'cbFechas
        '
        Me.cbFechas.Checked = False
        Me.cbFechas.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbFechas.Location = New System.Drawing.Point(9, 16)
        Me.cbFechas.Name = "cbFechas"
        Me.cbFechas.Size = New System.Drawing.Size(60, 29)
        Me.cbFechas.TabIndex = 0
        Me.cbFechas.Text = "Rango " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fechas"
        Me.cbFechas.Values.ExtraText = ""
        Me.cbFechas.Values.Image = Nothing
        Me.cbFechas.Values.Text = "Rango " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fechas"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(290, 18)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(91, 20)
        Me.dtFechaFin.TabIndex = 4
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(82, 19)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel8.TabIndex = 1
        Me.KryptonLabel8.Text = "Desde :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Desde :"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(147, 18)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(87, 20)
        Me.dtFechaInicio.TabIndex = 2
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(240, 19)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(46, 16)
        Me.KryptonLabel7.TabIndex = 3
        Me.KryptonLabel7.Text = "Hasta :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Hasta :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbCentroCosto)
        Me.GroupBox1.Controls.Add(Me.rbDetallado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 54)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Reporte"
        '
        'rbCentroCosto
        '
        Me.rbCentroCosto.Location = New System.Drawing.Point(188, 21)
        Me.rbCentroCosto.Name = "rbCentroCosto"
        Me.rbCentroCosto.Size = New System.Drawing.Size(146, 16)
        Me.rbCentroCosto.TabIndex = 1
        Me.rbCentroCosto.Text = "Centro Beneficio / Rubro"
        Me.rbCentroCosto.Values.ExtraText = ""
        Me.rbCentroCosto.Values.Image = Nothing
        Me.rbCentroCosto.Values.Text = "Centro Beneficio / Rubro"
        '
        'rbDetallado
        '
        Me.rbDetallado.Checked = True
        Me.rbDetallado.Location = New System.Drawing.Point(7, 21)
        Me.rbDetallado.Name = "rbDetallado"
        Me.rbDetallado.Size = New System.Drawing.Size(175, 16)
        Me.rbDetallado.TabIndex = 0
        Me.rbDetallado.Text = "Documentos / División / Rubro"
        Me.rbDetallado.Values.ExtraText = ""
        Me.rbDetallado.Values.Image = Nothing
        Me.rbDetallado.Values.Text = "Documentos / División / Rubro"
        '
        'BackgroundWorker1
        '
        '
        'dlgCtaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 341)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "dlgCtaCte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Ventas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptarRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrarRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmbRegionVenta As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents cmbPlanta As SOLMIN_CT.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents UcDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbClase As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents ucCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbMoneda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFechas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCentroCosto As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbDetallado As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
