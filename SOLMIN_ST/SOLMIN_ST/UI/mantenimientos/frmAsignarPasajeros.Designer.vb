<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarPasajeros
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPasePersonal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMotivoIngreso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtLugarDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpSeguroSocial = New System.Windows.Forms.DateTimePicker
        Me.txtPasajero = New Ransa.Utilitario.ucAyuda
        Me.KryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.dtpVencimientoPase = New System.Windows.Forms.DateTimePicker
        Me.txtEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtpCursoSeguridad = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkVacunasRequeridas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDeclaracionSalud = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpExamenMedico = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpSeguroAccidente = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpSeguroVida = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtContratista = New Ransa.Utilitario.ucAyuda
        Me.dtpSeguroPension = New System.Windows.Forms.DateTimePicker
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(905, 358)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtClienteFiltro)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.txtPasePersonal)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel29)
        Me.KryptonPanel1.Controls.Add(Me.txtOrdenCompra)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel28)
        Me.KryptonPanel1.Controls.Add(Me.txtMotivoIngreso)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel26)
        Me.KryptonPanel1.Controls.Add(Me.txtLugarDestino)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel20)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel13)
        Me.KryptonPanel1.Controls.Add(Me.dtpSeguroSocial)
        Me.KryptonPanel1.Controls.Add(Me.txtPasajero)
        Me.KryptonPanel1.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonPanel1.Controls.Add(Me.dtpVencimientoPase)
        Me.KryptonPanel1.Controls.Add(Me.txtEmbarque)
        Me.KryptonPanel1.Controls.Add(Me.dtpCursoSeguridad)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.chkVacunasRequeridas)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.chkDeclaracionSalud)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.dtpExamenMedico)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.dtpSeguroAccidente)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel1.Controls.Add(Me.dtpSeguroVida)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel22)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtContratista)
        Me.KryptonPanel1.Controls.Add(Me.dtpSeguroPension)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(905, 333)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 33
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Enabled = False
        Me.txtClienteFiltro.Location = New System.Drawing.Point(181, 52)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.Size = New System.Drawing.Size(251, 21)
        Me.txtClienteFiltro.TabIndex = 3
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 20)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Nro Embarque"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro Embarque"
        '
        'txtPasePersonal
        '
        Me.txtPasePersonal.Enabled = False
        Me.txtPasePersonal.Location = New System.Drawing.Point(614, 120)
        Me.txtPasePersonal.MaxLength = 15
        Me.txtPasePersonal.Name = "txtPasePersonal"
        Me.txtPasePersonal.Size = New System.Drawing.Size(141, 21)
        Me.txtPasePersonal.TabIndex = 26
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(13, 87)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel29.TabIndex = 4
        Me.KryptonLabel29.Text = "Contratista"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Contratista"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(614, 188)
        Me.txtOrdenCompra.MaxLength = 35
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(141, 21)
        Me.txtOrdenCompra.TabIndex = 30
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(13, 53)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel28.TabIndex = 2
        Me.KryptonLabel28.Text = "Cliente"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Cliente"
        '
        'txtMotivoIngreso
        '
        Me.txtMotivoIngreso.Location = New System.Drawing.Point(614, 222)
        Me.txtMotivoIngreso.MaxLength = 50
        Me.txtMotivoIngreso.Multiline = True
        Me.txtMotivoIngreso.Name = "txtMotivoIngreso"
        Me.txtMotivoIngreso.Size = New System.Drawing.Size(247, 40)
        Me.txtMotivoIngreso.TabIndex = 32
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(13, 121)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel26.TabIndex = 6
        Me.KryptonLabel26.Text = "Pasajero"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Pasajero"
        '
        'txtLugarDestino
        '
        Me.txtLugarDestino.Location = New System.Drawing.Point(181, 154)
        Me.txtLugarDestino.MaxLength = 50
        Me.txtLugarDestino.Name = "txtLugarDestino"
        Me.txtLugarDestino.Size = New System.Drawing.Size(251, 21)
        Me.txtLugarDestino.TabIndex = 9
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(13, 189)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(137, 19)
        Me.KryptonLabel20.TabIndex = 10
        Me.KryptonLabel20.Text = "Fecha Vcto. Seguro Salud"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha Vcto. Seguro Salud"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(13, 155)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(145, 19)
        Me.KryptonLabel13.TabIndex = 8
        Me.KryptonLabel13.Text = "Dirección Lugar de Destino"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Dirección Lugar de Destino"
        '
        'dtpSeguroSocial
        '
        Me.dtpSeguroSocial.Checked = False
        Me.dtpSeguroSocial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeguroSocial.Location = New System.Drawing.Point(181, 188)
        Me.dtpSeguroSocial.Name = "dtpSeguroSocial"
        Me.dtpSeguroSocial.ShowCheckBox = True
        Me.dtpSeguroSocial.Size = New System.Drawing.Size(95, 20)
        Me.dtpSeguroSocial.TabIndex = 11
        '
        'txtPasajero
        '
        Me.txtPasajero.BackColor = System.Drawing.Color.Transparent
        Me.txtPasajero.DataSource = Nothing
        Me.txtPasajero.DispleyMember = ""
        Me.txtPasajero.ListColumnas = Nothing
        Me.txtPasajero.Location = New System.Drawing.Point(181, 120)
        Me.txtPasajero.Name = "txtPasajero"
        Me.txtPasajero.Obligatorio = False
        Me.txtPasajero.Size = New System.Drawing.Size(251, 21)
        Me.txtPasajero.TabIndex = 7
        Me.txtPasajero.ValueMember = ""
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(452, 2)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(1, 330)
        Me.KryptonBorderEdge4.TabIndex = 18
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge4"
        '
        'dtpVencimientoPase
        '
        Me.dtpVencimientoPase.Checked = False
        Me.dtpVencimientoPase.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimientoPase.Location = New System.Drawing.Point(614, 86)
        Me.dtpVencimientoPase.Name = "dtpVencimientoPase"
        Me.dtpVencimientoPase.ShowCheckBox = True
        Me.dtpVencimientoPase.Size = New System.Drawing.Size(95, 20)
        Me.dtpVencimientoPase.TabIndex = 24
        '
        'txtEmbarque
        '
        Me.txtEmbarque.Location = New System.Drawing.Point(181, 19)
        Me.txtEmbarque.MaxLength = 4
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(54, 21)
        Me.txtEmbarque.TabIndex = 1
        '
        'dtpCursoSeguridad
        '
        Me.dtpCursoSeguridad.Checked = False
        Me.dtpCursoSeguridad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCursoSeguridad.Location = New System.Drawing.Point(614, 52)
        Me.dtpCursoSeguridad.Name = "dtpCursoSeguridad"
        Me.dtpCursoSeguridad.ShowCheckBox = True
        Me.dtpCursoSeguridad.Size = New System.Drawing.Size(95, 20)
        Me.dtpCursoSeguridad.TabIndex = 22
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 291)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(163, 19)
        Me.KryptonLabel4.TabIndex = 16
        Me.KryptonLabel4.Text = "Fecha Vcto. Seguro Accidentes "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Vcto. Seguro Accidentes "
        '
        'chkVacunasRequeridas
        '
        Me.chkVacunasRequeridas.Checked = False
        Me.chkVacunasRequeridas.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkVacunasRequeridas.Location = New System.Drawing.Point(614, 155)
        Me.chkVacunasRequeridas.Name = "chkVacunasRequeridas"
        Me.chkVacunasRequeridas.Size = New System.Drawing.Size(123, 19)
        Me.chkVacunasRequeridas.TabIndex = 28
        Me.chkVacunasRequeridas.Text = "Vacunas Requeridas"
        Me.chkVacunasRequeridas.Values.ExtraText = ""
        Me.chkVacunasRequeridas.Values.Image = Nothing
        Me.chkVacunasRequeridas.Values.Text = "Vacunas Requeridas"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(464, 20)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(121, 19)
        Me.KryptonLabel5.TabIndex = 19
        Me.KryptonLabel5.Text = "Fecha Examen Medico  "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Fecha Examen Medico  "
        '
        'chkDeclaracionSalud
        '
        Me.chkDeclaracionSalud.Checked = False
        Me.chkDeclaracionSalud.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDeclaracionSalud.Location = New System.Drawing.Point(469, 155)
        Me.chkDeclaracionSalud.Name = "chkDeclaracionSalud"
        Me.chkDeclaracionSalud.Size = New System.Drawing.Size(128, 19)
        Me.chkDeclaracionSalud.TabIndex = 27
        Me.chkDeclaracionSalud.Text = "Declaración de Salud"
        Me.chkDeclaracionSalud.Values.ExtraText = ""
        Me.chkDeclaracionSalud.Values.Image = Nothing
        Me.chkDeclaracionSalud.Values.Text = "Declaración de Salud"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(464, 53)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(125, 19)
        Me.KryptonLabel8.TabIndex = 21
        Me.KryptonLabel8.Text = "Fecha Curso Seguridad "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Fecha Curso Seguridad "
        '
        'dtpExamenMedico
        '
        Me.dtpExamenMedico.Checked = False
        Me.dtpExamenMedico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExamenMedico.Location = New System.Drawing.Point(614, 19)
        Me.dtpExamenMedico.Name = "dtpExamenMedico"
        Me.dtpExamenMedico.ShowCheckBox = True
        Me.dtpExamenMedico.Size = New System.Drawing.Size(95, 20)
        Me.dtpExamenMedico.TabIndex = 20
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(464, 223)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(102, 19)
        Me.KryptonLabel9.TabIndex = 31
        Me.KryptonLabel9.Text = "Motivo de Ingreso"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Motivo de Ingreso"
        '
        'dtpSeguroAccidente
        '
        Me.dtpSeguroAccidente.Checked = False
        Me.dtpSeguroAccidente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeguroAccidente.Location = New System.Drawing.Point(181, 288)
        Me.dtpSeguroAccidente.Name = "dtpSeguroAccidente"
        Me.dtpSeguroAccidente.ShowCheckBox = True
        Me.dtpSeguroAccidente.Size = New System.Drawing.Size(95, 20)
        Me.dtpSeguroAccidente.TabIndex = 17
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(464, 189)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel10.TabIndex = 29
        Me.KryptonLabel10.Text = "Orden Compra "
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Orden Compra "
        '
        'dtpSeguroVida
        '
        Me.dtpSeguroVida.Checked = False
        Me.dtpSeguroVida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeguroVida.Location = New System.Drawing.Point(181, 255)
        Me.dtpSeguroVida.Name = "dtpSeguroVida"
        Me.dtpSeguroVida.ShowCheckBox = True
        Me.dtpSeguroVida.Size = New System.Drawing.Size(95, 20)
        Me.dtpSeguroVida.TabIndex = 15
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(464, 121)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel11.TabIndex = 25
        Me.KryptonLabel11.Text = "Pase del Pasajero "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Pase del Pasajero "
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(13, 257)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(131, 19)
        Me.KryptonLabel22.TabIndex = 14
        Me.KryptonLabel22.Text = "Fecha Vcto. Seguro Vida "
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Fecha Vcto. Seguro Vida "
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(464, 87)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(139, 19)
        Me.KryptonLabel12.TabIndex = 23
        Me.KryptonLabel12.Text = "Fecha Vcto. Pase Personal"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Fecha Vcto. Pase Personal"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 223)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(148, 19)
        Me.KryptonLabel3.TabIndex = 12
        Me.KryptonLabel3.Text = "Fecha Vcto. Seguro Pension"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha Vcto. Seguro Pension"
        '
        'txtContratista
        '
        Me.txtContratista.BackColor = System.Drawing.Color.Transparent
        Me.txtContratista.DataSource = Nothing
        Me.txtContratista.DispleyMember = ""
        Me.txtContratista.ListColumnas = Nothing
        Me.txtContratista.Location = New System.Drawing.Point(181, 86)
        Me.txtContratista.Name = "txtContratista"
        Me.txtContratista.Obligatorio = False
        Me.txtContratista.Size = New System.Drawing.Size(251, 21)
        Me.txtContratista.TabIndex = 5
        Me.txtContratista.ValueMember = ""
        '
        'dtpSeguroPension
        '
        Me.dtpSeguroPension.Checked = False
        Me.dtpSeguroPension.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeguroPension.Location = New System.Drawing.Point(181, 222)
        Me.dtpSeguroPension.Name = "dtpSeguroPension"
        Me.dtpSeguroPension.ShowCheckBox = True
        Me.dtpSeguroPension.Size = New System.Drawing.Size(95, 20)
        Me.dtpSeguroPension.TabIndex = 13
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator2, Me.btnGuardar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(905, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 22)
        Me.btnSalir.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'frmAsignarPasajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAsignarPasajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Pasajeros"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmbarque As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtContratista As Ransa.Utilitario.ucAyuda
    Friend WithEvents dtpSeguroSocial As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpSeguroPension As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCursoSeguridad As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVacunasRequeridas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkDeclaracionSalud As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtpExamenMedico As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSeguroAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSeguroVida As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpVencimientoPase As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPasePersonal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMotivoIngreso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLugarDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPasajero As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
