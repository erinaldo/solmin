<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEProveedor))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TNACPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_CPAIS = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TNROFX = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_NDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpContacto = New System.Windows.Forms.GroupBox
        Me.lbl_TLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPSTEMAI3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_Situacion = New System.Windows.Forms.Label
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPSTPRSCN = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPNNDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPNCPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTNROFX = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPNCPAIS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTNACPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPNNRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPSTPRCL1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.grpContacto.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(19, 87)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(62, 19)
        Me.lbl_NRUCPR.TabIndex = 38
        Me.lbl_NRUCPR.Text = "Nro. RUC :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. RUC :"
        '
        'lbl_TNACPR
        '
        Me.lbl_TNACPR.Location = New System.Drawing.Point(244, 109)
        Me.lbl_TNACPR.Name = "lbl_TNACPR"
        Me.lbl_TNACPR.Size = New System.Drawing.Size(81, 19)
        Me.lbl_TNACPR.TabIndex = 44
        Me.lbl_TNACPR.Text = "Nacionalidad : "
        Me.lbl_TNACPR.Values.ExtraText = ""
        Me.lbl_TNACPR.Values.Image = Nothing
        Me.lbl_TNACPR.Values.Text = "Nacionalidad : "
        '
        'lbl_TDRPRC
        '
        Me.lbl_TDRPRC.Location = New System.Drawing.Point(19, 137)
        Me.lbl_TDRPRC.Name = "lbl_TDRPRC"
        Me.lbl_TDRPRC.Size = New System.Drawing.Size(63, 19)
        Me.lbl_TDRPRC.TabIndex = 46
        Me.lbl_TDRPRC.Text = "Dirección : "
        Me.lbl_TDRPRC.Values.ExtraText = ""
        Me.lbl_TDRPRC.Values.Image = Nothing
        Me.lbl_TDRPRC.Values.Text = "Dirección : "
        '
        'lbl_CPAIS
        '
        Me.lbl_CPAIS.Location = New System.Drawing.Point(19, 112)
        Me.lbl_CPAIS.Name = "lbl_CPAIS"
        Me.lbl_CPAIS.Size = New System.Drawing.Size(75, 19)
        Me.lbl_CPAIS.TabIndex = 42
        Me.lbl_CPAIS.Text = "Código País : "
        Me.lbl_CPAIS.Values.ExtraText = ""
        Me.lbl_CPAIS.Values.Image = Nothing
        Me.lbl_CPAIS.Values.Text = "Código País : "
        '
        'lbl_TNROFX
        '
        Me.lbl_TNROFX.Location = New System.Drawing.Point(19, 212)
        Me.lbl_TNROFX.Name = "lbl_TNROFX"
        Me.lbl_TNROFX.Size = New System.Drawing.Size(60, 19)
        Me.lbl_TNROFX.TabIndex = 50
        Me.lbl_TNROFX.Text = "Nro . Fax : "
        Me.lbl_TNROFX.Values.ExtraText = ""
        Me.lbl_TNROFX.Values.Image = Nothing
        Me.lbl_TNROFX.Values.Text = "Nro . Fax : "
        '
        'lbl_TLFNO1
        '
        Me.lbl_TLFNO1.Location = New System.Drawing.Point(19, 235)
        Me.lbl_TLFNO1.Name = "lbl_TLFNO1"
        Me.lbl_TLFNO1.Size = New System.Drawing.Size(42, 19)
        Me.lbl_TLFNO1.TabIndex = 48
        Me.lbl_TLFNO1.Text = "Email : "
        Me.lbl_TLFNO1.Values.ExtraText = ""
        Me.lbl_TLFNO1.Values.Image = Nothing
        Me.lbl_TLFNO1.Values.Text = "Email : "
        '
        'lbl_TEMAI2
        '
        Me.lbl_TEMAI2.Location = New System.Drawing.Point(7, 47)
        Me.lbl_TEMAI2.Name = "lbl_TEMAI2"
        Me.lbl_TEMAI2.Size = New System.Drawing.Size(48, 19)
        Me.lbl_TEMAI2.TabIndex = 52
        Me.lbl_TEMAI2.Text = "Em@il : "
        Me.lbl_TEMAI2.Values.ExtraText = ""
        Me.lbl_TEMAI2.Values.Image = Nothing
        Me.lbl_TEMAI2.Values.Text = "Em@il : "
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(19, 37)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(74, 19)
        Me.lbl_TPRVCL.TabIndex = 34
        Me.lbl_TPRVCL.Text = "Descripción : "
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Descripción : "
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(19, 12)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(67, 19)
        Me.lbl_CPRVCL.TabIndex = 32
        Me.lbl_CPRVCL.Text = "Proveedor :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Proveedor :"
        '
        'lbl_NDSDMP
        '
        Me.lbl_NDSDMP.Location = New System.Drawing.Point(244, 87)
        Me.lbl_NDSDMP.Name = "lbl_NDSDMP"
        Me.lbl_NDSDMP.Size = New System.Drawing.Size(71, 19)
        Me.lbl_NDSDMP.TabIndex = 40
        Me.lbl_NDSDMP.Text = "Plazo Pago : "
        Me.lbl_NDSDMP.Values.ExtraText = ""
        Me.lbl_NDSDMP.Values.Image = Nothing
        Me.lbl_NDSDMP.Values.Text = "Plazo Pago : "
        '
        'grpContacto
        '
        Me.grpContacto.BackColor = System.Drawing.Color.Transparent
        Me.grpContacto.Controls.Add(Me.lbl_TLFNO2)
        Me.grpContacto.Controls.Add(Me.txtPSTEMAI3)
        Me.grpContacto.Controls.Add(Me.txtPSTLFNO2)
        Me.grpContacto.Controls.Add(Me.lbl_TEMAI2)
        Me.grpContacto.Location = New System.Drawing.Point(12, 257)
        Me.grpContacto.Name = "grpContacto"
        Me.grpContacto.Size = New System.Drawing.Size(448, 79)
        Me.grpContacto.TabIndex = 54
        Me.grpContacto.TabStop = False
        Me.grpContacto.Text = " Contacto "
        '
        'lbl_TLFNO2
        '
        Me.lbl_TLFNO2.Location = New System.Drawing.Point(7, 23)
        Me.lbl_TLFNO2.Name = "lbl_TLFNO2"
        Me.lbl_TLFNO2.Size = New System.Drawing.Size(59, 19)
        Me.lbl_TLFNO2.TabIndex = 25
        Me.lbl_TLFNO2.Text = "Teléfono : "
        Me.lbl_TLFNO2.Values.ExtraText = ""
        Me.lbl_TLFNO2.Values.Image = Nothing
        Me.lbl_TLFNO2.Values.Text = "Teléfono : "
        '
        'txtPSTEMAI3
        '
        Me.txtPSTEMAI3.Location = New System.Drawing.Point(82, 47)
        Me.txtPSTEMAI3.MaxLength = 40
        Me.txtPSTEMAI3.Name = "txtPSTEMAI3"
        Me.txtPSTEMAI3.Size = New System.Drawing.Size(360, 21)
        Me.txtPSTEMAI3.TabIndex = 100
        '
        'txtPSTLFNO2
        '
        Me.txtPSTLFNO2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTLFNO2.Location = New System.Drawing.Point(82, 18)
        Me.txtPSTLFNO2.MaxLength = 15
        Me.txtPSTLFNO2.Name = "txtPSTLFNO2"
        Me.txtPSTLFNO2.Size = New System.Drawing.Size(141, 21)
        Me.txtPSTLFNO2.TabIndex = 90
        '
        'lbl_Situacion
        '
        Me.lbl_Situacion.AutoSize = True
        Me.lbl_Situacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Situacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Situacion.ForeColor = System.Drawing.Color.Red
        Me.lbl_Situacion.Location = New System.Drawing.Point(241, 12)
        Me.lbl_Situacion.Name = "lbl_Situacion"
        Me.lbl_Situacion.Size = New System.Drawing.Size(10, 15)
        Me.lbl_Situacion.TabIndex = 57
        Me.lbl_Situacion.Text = "."
        Me.lbl_Situacion.Visible = False
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtPSTPRSCN)
        Me.KryptonPanel.Controls.Add(Me.lbl_Situacion)
        Me.KryptonPanel.Controls.Add(Me.grpContacto)
        Me.KryptonPanel.Controls.Add(Me.txtPNNDSDMP)
        Me.KryptonPanel.Controls.Add(Me.lbl_NDSDMP)
        Me.KryptonPanel.Controls.Add(Me.lbl_CPRVCL)
        Me.KryptonPanel.Controls.Add(Me.txtPNCPRVCL)
        Me.KryptonPanel.Controls.Add(Me.lbl_TPRVCL)
        Me.KryptonPanel.Controls.Add(Me.txtPSTPRVCL)
        Me.KryptonPanel.Controls.Add(Me.txtPSTEMAI2)
        Me.KryptonPanel.Controls.Add(Me.txtPSTLFNO1)
        Me.KryptonPanel.Controls.Add(Me.lbl_TLFNO1)
        Me.KryptonPanel.Controls.Add(Me.txtPSTNROFX)
        Me.KryptonPanel.Controls.Add(Me.lbl_TNROFX)
        Me.KryptonPanel.Controls.Add(Me.txtPNCPAIS)
        Me.KryptonPanel.Controls.Add(Me.lbl_CPAIS)
        Me.KryptonPanel.Controls.Add(Me.txtPSTDRPRC)
        Me.KryptonPanel.Controls.Add(Me.lbl_TDRPRC)
        Me.KryptonPanel.Controls.Add(Me.txtPSTNACPR)
        Me.KryptonPanel.Controls.Add(Me.lbl_TNACPR)
        Me.KryptonPanel.Controls.Add(Me.txtPNNRUCPR)
        Me.KryptonPanel.Controls.Add(Me.lbl_NRUCPR)
        Me.KryptonPanel.Controls.Add(Me.txtPSTPRCL1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel.Size = New System.Drawing.Size(472, 341)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 187)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 19)
        Me.KryptonLabel1.TabIndex = 81
        Me.KryptonLabel1.Text = "Teléfono: "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Teléfono: "
        '
        'txtPSTPRSCN
        '
        Me.txtPSTPRSCN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRSCN.Location = New System.Drawing.Point(94, 159)
        Me.txtPSTPRSCN.MaxLength = 40
        Me.txtPSTPRSCN.Name = "txtPSTPRSCN"
        Me.txtPSTPRSCN.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTPRSCN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPSTPRSCN.TabIndex = 70
        '
        'txtPNNDSDMP
        '
        Me.txtPNNDSDMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNNDSDMP.Location = New System.Drawing.Point(332, 84)
        Me.txtPNNDSDMP.MaxLength = 5
        Me.txtPNNDSDMP.Name = "txtPNNDSDMP"
        Me.txtPNNDSDMP.Size = New System.Drawing.Size(128, 21)
        Me.txtPNNDSDMP.TabIndex = 30
        '
        'txtPNCPRVCL
        '
        Me.txtPNCPRVCL.Location = New System.Drawing.Point(94, 10)
        Me.txtPNCPRVCL.Name = "txtPNCPRVCL"
        Me.txtPNCPRVCL.Size = New System.Drawing.Size(141, 21)
        Me.txtPNCPRVCL.TabIndex = 59
        '
        'txtPSTPRVCL
        '
        Me.txtPSTPRVCL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRVCL.Location = New System.Drawing.Point(94, 34)
        Me.txtPSTPRVCL.MaxLength = 30
        Me.txtPSTPRVCL.Name = "txtPSTPRVCL"
        Me.txtPSTPRVCL.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTPRVCL.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPSTPRVCL.TabIndex = 0
        '
        'txtPSTEMAI2
        '
        Me.txtPSTEMAI2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTEMAI2.Location = New System.Drawing.Point(94, 232)
        Me.txtPSTEMAI2.MaxLength = 40
        Me.txtPSTEMAI2.Name = "txtPSTEMAI2"
        Me.txtPSTEMAI2.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTEMAI2.TabIndex = 80
        '
        'txtPSTLFNO1
        '
        Me.txtPSTLFNO1.Location = New System.Drawing.Point(94, 184)
        Me.txtPSTLFNO1.MaxLength = 15
        Me.txtPSTLFNO1.Name = "txtPSTLFNO1"
        Me.txtPSTLFNO1.Size = New System.Drawing.Size(144, 21)
        Me.txtPSTLFNO1.TabIndex = 49
        '
        'txtPSTNROFX
        '
        Me.txtPSTNROFX.Location = New System.Drawing.Point(94, 209)
        Me.txtPSTNROFX.MaxLength = 40
        Me.txtPSTNROFX.Name = "txtPSTNROFX"
        Me.txtPSTNROFX.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTNROFX.TabIndex = 51
        '
        'txtPNCPAIS
        '
        Me.txtPNCPAIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNCPAIS.Location = New System.Drawing.Point(94, 109)
        Me.txtPNCPAIS.MaxLength = 4
        Me.txtPNCPAIS.Name = "txtPNCPAIS"
        Me.txtPNCPAIS.Size = New System.Drawing.Size(144, 21)
        Me.txtPNCPAIS.TabIndex = 40
        '
        'txtPSTDRPRC
        '
        Me.txtPSTDRPRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTDRPRC.Location = New System.Drawing.Point(94, 134)
        Me.txtPSTDRPRC.MaxLength = 35
        Me.txtPSTDRPRC.Name = "txtPSTDRPRC"
        Me.txtPSTDRPRC.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTDRPRC.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPSTDRPRC.TabIndex = 60
        '
        'txtPSTNACPR
        '
        Me.txtPSTNACPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTNACPR.Location = New System.Drawing.Point(332, 109)
        Me.txtPSTNACPR.MaxLength = 15
        Me.txtPSTNACPR.Name = "txtPSTNACPR"
        Me.txtPSTNACPR.Size = New System.Drawing.Size(128, 21)
        Me.txtPSTNACPR.TabIndex = 50
        '
        'txtPNNRUCPR
        '
        Me.txtPNNRUCPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNNRUCPR.Location = New System.Drawing.Point(94, 84)
        Me.txtPNNRUCPR.MaxLength = 11
        Me.txtPNNRUCPR.Name = "txtPNNRUCPR"
        Me.txtPNNRUCPR.Size = New System.Drawing.Size(144, 21)
        Me.txtPNNRUCPR.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPNNRUCPR.TabIndex = 20
        Me.txtPNNRUCPR.Text = "0"
        '
        'txtPSTPRCL1
        '
        Me.txtPSTPRCL1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRCL1.Location = New System.Drawing.Point(94, 59)
        Me.txtPSTPRCL1.MaxLength = 30
        Me.txtPSTPRCL1.Name = "txtPSTPRCL1"
        Me.txtPSTPRCL1.Size = New System.Drawing.Size(366, 21)
        Me.txtPSTPRCL1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPSTPRCL1.TabIndex = 10
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(472, 25)
        Me.tsMenuOpciones.TabIndex = 59
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel1.Tag = "POSICION"
        Me.ToolStripLabel1.Text = "Cliente Tercero"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton2.Text = "&Cancelar"
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
        'frmEProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.MaximumSize = New System.Drawing.Size(480, 400)
        Me.MinimumSize = New System.Drawing.Size(480, 400)
        Me.Name = "frmEProveedor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor Detalle"
        Me.grpContacto.ResumeLayout(False)
        Me.grpContacto.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TNACPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TDRPRC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPAIS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TNROFX As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_NDSDMP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpContacto As System.Windows.Forms.GroupBox
    Private WithEvents txtPSTEMAI3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbl_Situacion As System.Windows.Forms.Label
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents txtPNNDSDMP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPNCPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTNROFX As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPNCPAIS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTDRPRC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTNACPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPNNRUCPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTPRCL1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents txtPSTPRSCN As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
