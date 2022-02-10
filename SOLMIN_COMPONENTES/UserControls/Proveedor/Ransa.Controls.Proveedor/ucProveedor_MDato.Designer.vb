<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProveedor_MDato
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProveedor_MDato))
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dbPNCPAIS = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTPRSCN = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_Situacion = New System.Windows.Forms.Label()
        Me.grpContacto = New System.Windows.Forms.GroupBox()
        Me.lbl_TLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTEMAI3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPSTLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPNNDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_NDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPNCPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPSTEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPSTLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTNROFX = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TNROFX = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_CPAIS = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTNACPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_TNACPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPNNRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSTPRCL1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpContacto.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(701, 27)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 24)
        Me.ToolStripLabel1.Tag = "POSICION"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.db_add
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(86, 24)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dbPNCPAIS)
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
        Me.KryptonPanel.Controls.Add(Me.lbl_CPAIS)
        Me.KryptonPanel.Controls.Add(Me.txtPSTDRPRC)
        Me.KryptonPanel.Controls.Add(Me.lbl_TDRPRC)
        Me.KryptonPanel.Controls.Add(Me.txtPSTNACPR)
        Me.KryptonPanel.Controls.Add(Me.lbl_TNACPR)
        Me.KryptonPanel.Controls.Add(Me.txtPNNRUCPR)
        Me.KryptonPanel.Controls.Add(Me.lbl_NRUCPR)
        Me.KryptonPanel.Controls.Add(Me.txtPSTPRCL1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 27)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel.Size = New System.Drawing.Size(701, 446)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 1
        '
        'dbPNCPAIS
        '
        Me.dbPNCPAIS.DropDownWidth = 141
        Me.dbPNCPAIS.FormattingEnabled = False
        Me.dbPNCPAIS.ItemHeight = 20
        Me.dbPNCPAIS.Location = New System.Drawing.Point(125, 133)
        Me.dbPNCPAIS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dbPNCPAIS.Name = "dbPNCPAIS"
        Me.dbPNCPAIS.Size = New System.Drawing.Size(188, 28)
        Me.dbPNCPAIS.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dbPNCPAIS.TabIndex = 11
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(25, 230)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(75, 24)
        Me.KryptonLabel1.TabIndex = 17
        Me.KryptonLabel1.Text = "Teléfono: "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Teléfono: "
        '
        'txtPSTPRSCN
        '
        Me.txtPSTPRSCN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRSCN.Location = New System.Drawing.Point(125, 196)
        Me.txtPSTPRSCN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTPRSCN.MaxLength = 40
        Me.txtPSTPRSCN.Name = "txtPSTPRSCN"
        Me.txtPSTPRSCN.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTPRSCN.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtPSTPRSCN.TabIndex = 16
        '
        'lbl_Situacion
        '
        Me.lbl_Situacion.AutoSize = True
        Me.lbl_Situacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Situacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Situacion.ForeColor = System.Drawing.Color.Red
        Me.lbl_Situacion.Location = New System.Drawing.Point(321, 15)
        Me.lbl_Situacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Situacion.Name = "lbl_Situacion"
        Me.lbl_Situacion.Size = New System.Drawing.Size(12, 18)
        Me.lbl_Situacion.TabIndex = 2
        Me.lbl_Situacion.Text = "."
        Me.lbl_Situacion.Visible = False
        '
        'grpContacto
        '
        Me.grpContacto.BackColor = System.Drawing.Color.Transparent
        Me.grpContacto.Controls.Add(Me.lbl_TLFNO2)
        Me.grpContacto.Controls.Add(Me.txtPSTEMAI3)
        Me.grpContacto.Controls.Add(Me.txtPSTLFNO2)
        Me.grpContacto.Controls.Add(Me.lbl_TEMAI2)
        Me.grpContacto.Location = New System.Drawing.Point(16, 316)
        Me.grpContacto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpContacto.Name = "grpContacto"
        Me.grpContacto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpContacto.Size = New System.Drawing.Size(597, 97)
        Me.grpContacto.TabIndex = 23
        Me.grpContacto.TabStop = False
        Me.grpContacto.Text = " Contacto "
        '
        'lbl_TLFNO2
        '
        Me.lbl_TLFNO2.Location = New System.Drawing.Point(9, 28)
        Me.lbl_TLFNO2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TLFNO2.Name = "lbl_TLFNO2"
        Me.lbl_TLFNO2.Size = New System.Drawing.Size(79, 24)
        Me.lbl_TLFNO2.TabIndex = 0
        Me.lbl_TLFNO2.Text = "Teléfono : "
        Me.lbl_TLFNO2.Values.ExtraText = ""
        Me.lbl_TLFNO2.Values.Image = Nothing
        Me.lbl_TLFNO2.Values.Text = "Teléfono : "
        '
        'txtPSTEMAI3
        '
        Me.txtPSTEMAI3.Location = New System.Drawing.Point(109, 58)
        Me.txtPSTEMAI3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTEMAI3.MaxLength = 40
        Me.txtPSTEMAI3.Name = "txtPSTEMAI3"
        Me.txtPSTEMAI3.Size = New System.Drawing.Size(480, 26)
        Me.txtPSTEMAI3.TabIndex = 3
        '
        'txtPSTLFNO2
        '
        Me.txtPSTLFNO2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTLFNO2.Location = New System.Drawing.Point(109, 22)
        Me.txtPSTLFNO2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTLFNO2.MaxLength = 15
        Me.txtPSTLFNO2.Name = "txtPSTLFNO2"
        Me.txtPSTLFNO2.Size = New System.Drawing.Size(188, 26)
        Me.txtPSTLFNO2.TabIndex = 1
        '
        'lbl_TEMAI2
        '
        Me.lbl_TEMAI2.Location = New System.Drawing.Point(9, 58)
        Me.lbl_TEMAI2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TEMAI2.Name = "lbl_TEMAI2"
        Me.lbl_TEMAI2.Size = New System.Drawing.Size(62, 24)
        Me.lbl_TEMAI2.TabIndex = 2
        Me.lbl_TEMAI2.Text = "Em@il : "
        Me.lbl_TEMAI2.Values.ExtraText = ""
        Me.lbl_TEMAI2.Values.Image = Nothing
        Me.lbl_TEMAI2.Values.Text = "Em@il : "
        '
        'txtPNNDSDMP
        '
        Me.txtPNNDSDMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNNDSDMP.Location = New System.Drawing.Point(125, 103)
        Me.txtPNNDSDMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPNNDSDMP.MaxLength = 5
        Me.txtPNNDSDMP.Name = "txtPNNDSDMP"
        Me.txtPNNDSDMP.Size = New System.Drawing.Size(171, 26)
        Me.txtPNNDSDMP.TabIndex = 9
        '
        'lbl_NDSDMP
        '
        Me.lbl_NDSDMP.Location = New System.Drawing.Point(25, 107)
        Me.lbl_NDSDMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_NDSDMP.Name = "lbl_NDSDMP"
        Me.lbl_NDSDMP.Size = New System.Drawing.Size(94, 24)
        Me.lbl_NDSDMP.TabIndex = 8
        Me.lbl_NDSDMP.Text = "Plazo Pago : "
        Me.lbl_NDSDMP.Values.ExtraText = ""
        Me.lbl_NDSDMP.Values.Image = Nothing
        Me.lbl_NDSDMP.Values.Text = "Plazo Pago : "
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(25, 15)
        Me.lbl_CPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(89, 24)
        Me.lbl_CPRVCL.TabIndex = 0
        Me.lbl_CPRVCL.Text = "Proveedor :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Proveedor :"
        '
        'txtPNCPRVCL
        '
        Me.txtPNCPRVCL.Location = New System.Drawing.Point(125, 12)
        Me.txtPNCPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPNCPRVCL.Name = "txtPNCPRVCL"
        Me.txtPNCPRVCL.Size = New System.Drawing.Size(188, 26)
        Me.txtPNCPRVCL.TabIndex = 1
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(25, 46)
        Me.lbl_TPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(99, 24)
        Me.lbl_TPRVCL.TabIndex = 5
        Me.lbl_TPRVCL.Text = "Descripción : "
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Descripción : "
        '
        'txtPSTPRVCL
        '
        Me.txtPSTPRVCL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRVCL.Location = New System.Drawing.Point(125, 42)
        Me.txtPSTPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTPRVCL.MaxLength = 30
        Me.txtPSTPRVCL.Name = "txtPSTPRVCL"
        Me.txtPSTPRVCL.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTPRVCL.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPSTPRVCL.TabIndex = 6
        '
        'txtPSTEMAI2
        '
        Me.txtPSTEMAI2.Location = New System.Drawing.Point(125, 286)
        Me.txtPSTEMAI2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTEMAI2.MaxLength = 40
        Me.txtPSTEMAI2.Name = "txtPSTEMAI2"
        Me.txtPSTEMAI2.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTEMAI2.TabIndex = 22
        '
        'txtPSTLFNO1
        '
        Me.txtPSTLFNO1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTLFNO1.Location = New System.Drawing.Point(125, 226)
        Me.txtPSTLFNO1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTLFNO1.MaxLength = 15
        Me.txtPSTLFNO1.Name = "txtPSTLFNO1"
        Me.txtPSTLFNO1.Size = New System.Drawing.Size(192, 26)
        Me.txtPSTLFNO1.TabIndex = 18
        '
        'lbl_TLFNO1
        '
        Me.lbl_TLFNO1.Location = New System.Drawing.Point(25, 289)
        Me.lbl_TLFNO1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TLFNO1.Name = "lbl_TLFNO1"
        Me.lbl_TLFNO1.Size = New System.Drawing.Size(56, 24)
        Me.lbl_TLFNO1.TabIndex = 21
        Me.lbl_TLFNO1.Text = "Email : "
        Me.lbl_TLFNO1.Values.ExtraText = ""
        Me.lbl_TLFNO1.Values.Image = Nothing
        Me.lbl_TLFNO1.Values.Text = "Email : "
        '
        'txtPSTNROFX
        '
        Me.txtPSTNROFX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTNROFX.Location = New System.Drawing.Point(125, 257)
        Me.txtPSTNROFX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTNROFX.MaxLength = 40
        Me.txtPSTNROFX.Name = "txtPSTNROFX"
        Me.txtPSTNROFX.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTNROFX.TabIndex = 20
        '
        'lbl_TNROFX
        '
        Me.lbl_TNROFX.Location = New System.Drawing.Point(25, 261)
        Me.lbl_TNROFX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TNROFX.Name = "lbl_TNROFX"
        Me.lbl_TNROFX.Size = New System.Drawing.Size(79, 24)
        Me.lbl_TNROFX.TabIndex = 19
        Me.lbl_TNROFX.Text = "Nro . Fax : "
        Me.lbl_TNROFX.Values.ExtraText = ""
        Me.lbl_TNROFX.Values.Image = Nothing
        Me.lbl_TNROFX.Values.Text = "Nro . Fax : "
        '
        'lbl_CPAIS
        '
        Me.lbl_CPAIS.Location = New System.Drawing.Point(25, 138)
        Me.lbl_CPAIS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_CPAIS.Name = "lbl_CPAIS"
        Me.lbl_CPAIS.Size = New System.Drawing.Size(46, 24)
        Me.lbl_CPAIS.TabIndex = 10
        Me.lbl_CPAIS.Text = "País : "
        Me.lbl_CPAIS.Values.ExtraText = ""
        Me.lbl_CPAIS.Values.Image = Nothing
        Me.lbl_CPAIS.Values.Text = "País : "
        '
        'txtPSTDRPRC
        '
        Me.txtPSTDRPRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTDRPRC.Location = New System.Drawing.Point(125, 165)
        Me.txtPSTDRPRC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTDRPRC.MaxLength = 35
        Me.txtPSTDRPRC.Name = "txtPSTDRPRC"
        Me.txtPSTDRPRC.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTDRPRC.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtPSTDRPRC.TabIndex = 15
        '
        'lbl_TDRPRC
        '
        Me.lbl_TDRPRC.Location = New System.Drawing.Point(25, 169)
        Me.lbl_TDRPRC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TDRPRC.Name = "lbl_TDRPRC"
        Me.lbl_TDRPRC.Size = New System.Drawing.Size(83, 24)
        Me.lbl_TDRPRC.TabIndex = 14
        Me.lbl_TDRPRC.Text = "Dirección : "
        Me.lbl_TDRPRC.Values.ExtraText = ""
        Me.lbl_TDRPRC.Values.Image = Nothing
        Me.lbl_TDRPRC.Values.Text = "Dirección : "
        '
        'txtPSTNACPR
        '
        Me.txtPSTNACPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTNACPR.Location = New System.Drawing.Point(443, 134)
        Me.txtPSTNACPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTNACPR.MaxLength = 15
        Me.txtPSTNACPR.Name = "txtPSTNACPR"
        Me.txtPSTNACPR.Size = New System.Drawing.Size(171, 26)
        Me.txtPSTNACPR.TabIndex = 13
        '
        'lbl_TNACPR
        '
        Me.lbl_TNACPR.Location = New System.Drawing.Point(325, 134)
        Me.lbl_TNACPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TNACPR.Name = "lbl_TNACPR"
        Me.lbl_TNACPR.Size = New System.Drawing.Size(109, 24)
        Me.lbl_TNACPR.TabIndex = 12
        Me.lbl_TNACPR.Text = "Nacionalidad : "
        Me.lbl_TNACPR.Values.ExtraText = ""
        Me.lbl_TNACPR.Values.Image = Nothing
        Me.lbl_TNACPR.Values.Text = "Nacionalidad : "
        '
        'txtPNNRUCPR
        '
        Me.txtPNNRUCPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNNRUCPR.Location = New System.Drawing.Point(421, 11)
        Me.txtPNNRUCPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPNNRUCPR.MaxLength = 11
        Me.txtPNNRUCPR.Name = "txtPNNRUCPR"
        Me.txtPNNRUCPR.Size = New System.Drawing.Size(192, 26)
        Me.txtPNNRUCPR.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtPNNRUCPR.TabIndex = 4
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(343, 11)
        Me.lbl_NRUCPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(82, 24)
        Me.lbl_NRUCPR.TabIndex = 3
        Me.lbl_NRUCPR.Text = "Nro. RUC :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. RUC :"
        '
        'txtPSTPRCL1
        '
        Me.txtPSTPRCL1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPSTPRCL1.Location = New System.Drawing.Point(125, 73)
        Me.txtPSTPRCL1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPSTPRCL1.MaxLength = 30
        Me.txtPSTPRCL1.Name = "txtPSTPRCL1"
        Me.txtPSTPRCL1.Size = New System.Drawing.Size(488, 26)
        Me.txtPSTPRCL1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtPSTPRCL1.TabIndex = 7
        '
        'ucProveedor_MDato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucProveedor_MDato"
        Me.Size = New System.Drawing.Size(701, 473)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpContacto.ResumeLayout(False)
        Me.grpContacto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dbPNCPAIS As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTPRSCN As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbl_Situacion As System.Windows.Forms.Label
    Friend WithEvents grpContacto As System.Windows.Forms.GroupBox
    Private WithEvents lbl_TLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTEMAI3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPNNDSDMP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NDSDMP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPNCPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtPSTLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTNROFX As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TNROFX As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPAIS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTDRPRC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TDRPRC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTNACPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TNACPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPNNRUCPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtPSTPRCL1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
