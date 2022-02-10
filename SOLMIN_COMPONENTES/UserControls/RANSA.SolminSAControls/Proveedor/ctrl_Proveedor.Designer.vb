<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_Proveedor
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txt_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TPRCL1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TPRCL1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TNACPR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TNACPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TDRPRC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_CPAIS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_CPAIS = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TNROFX = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TNROFX = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TLFNO1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TEMAI2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TPRSCN = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TPRSCN = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TLFNO2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_TEMAI3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_TEMAI3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_NDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_NDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lbl_Situacion = New System.Windows.Forms.Label
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(3, 6)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(69, 16)
        Me.lbl_CPRVCL.TabIndex = 0
        Me.lbl_CPRVCL.Text = "Proveedor :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Proveedor :"
        '
        'txt_CPRVCL
        '
        Me.txt_CPRVCL.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txt_CPRVCL, True)
        Me.txt_CPRVCL.Location = New System.Drawing.Point(85, 3)
        Me.txt_CPRVCL.MaxLength = 6
        Me.txt_CPRVCL.Name = "txt_CPRVCL"
        Me.txt_CPRVCL.Size = New System.Drawing.Size(78, 19)
        Me.txt_CPRVCL.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_CPRVCL.TabIndex = 1
        Me.txt_CPRVCL.Text = "0"
        Me.TypeValidator.SetTypes(Me.txt_CPRVCL, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txt_TPRVCL
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TPRVCL, True)
        Me.txt_TPRVCL.Location = New System.Drawing.Point(85, 28)
        Me.txt_TPRVCL.MaxLength = 30
        Me.txt_TPRVCL.Name = "txt_TPRVCL"
        Me.txt_TPRVCL.Size = New System.Drawing.Size(312, 19)
        Me.txt_TPRVCL.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txt_TPRVCL, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(3, 31)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(76, 16)
        Me.lbl_TPRVCL.TabIndex = 2
        Me.lbl_TPRVCL.Text = "Descripción : "
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Descripción : "
        '
        'txt_TPRCL1
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TPRCL1, True)
        Me.txt_TPRCL1.Location = New System.Drawing.Point(85, 53)
        Me.txt_TPRCL1.MaxLength = 30
        Me.txt_TPRCL1.Name = "txt_TPRCL1"
        Me.txt_TPRCL1.Size = New System.Drawing.Size(312, 19)
        Me.txt_TPRCL1.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txt_TPRCL1, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TPRCL1
        '
        Me.lbl_TPRCL1.Location = New System.Drawing.Point(3, 56)
        Me.lbl_TPRCL1.Name = "lbl_TPRCL1"
        Me.lbl_TPRCL1.Size = New System.Drawing.Size(75, 16)
        Me.lbl_TPRCL1.TabIndex = 4
        Me.lbl_TPRCL1.Text = "Desc. Abrev."
        Me.lbl_TPRCL1.Values.ExtraText = ""
        Me.lbl_TPRCL1.Values.Image = Nothing
        Me.lbl_TPRCL1.Values.Text = "Desc. Abrev."
        '
        'txt_NRUCPR
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_NRUCPR, True)
        Me.txt_NRUCPR.Location = New System.Drawing.Point(85, 78)
        Me.txt_NRUCPR.MaxLength = 11
        Me.txt_NRUCPR.Name = "txt_NRUCPR"
        Me.txt_NRUCPR.Size = New System.Drawing.Size(114, 19)
        Me.txt_NRUCPR.TabIndex = 7
        Me.txt_NRUCPR.Text = "0"
        Me.TypeValidator.SetTypes(Me.txt_NRUCPR, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(3, 81)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(65, 16)
        Me.lbl_NRUCPR.TabIndex = 6
        Me.lbl_NRUCPR.Text = "Nro. RUC :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. RUC :"
        '
        'txt_TNACPR
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TNACPR, True)
        Me.txt_TNACPR.Location = New System.Drawing.Point(283, 103)
        Me.txt_TNACPR.Name = "txt_TNACPR"
        Me.txt_TNACPR.Size = New System.Drawing.Size(114, 19)
        Me.txt_TNACPR.TabIndex = 13
        Me.TypeValidator.SetTypes(Me.txt_TNACPR, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TNACPR
        '
        Me.lbl_TNACPR.Location = New System.Drawing.Point(203, 106)
        Me.lbl_TNACPR.Name = "lbl_TNACPR"
        Me.lbl_TNACPR.Size = New System.Drawing.Size(82, 16)
        Me.lbl_TNACPR.TabIndex = 12
        Me.lbl_TNACPR.Text = "Nacionalidad : "
        Me.lbl_TNACPR.Values.ExtraText = ""
        Me.lbl_TNACPR.Values.Image = Nothing
        Me.lbl_TNACPR.Values.Text = "Nacionalidad : "
        '
        'txt_TDRPRC
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TDRPRC, True)
        Me.txt_TDRPRC.Location = New System.Drawing.Point(85, 128)
        Me.txt_TDRPRC.Name = "txt_TDRPRC"
        Me.txt_TDRPRC.Size = New System.Drawing.Size(312, 19)
        Me.txt_TDRPRC.TabIndex = 15
        Me.TypeValidator.SetTypes(Me.txt_TDRPRC, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TDRPRC
        '
        Me.lbl_TDRPRC.Location = New System.Drawing.Point(3, 131)
        Me.lbl_TDRPRC.Name = "lbl_TDRPRC"
        Me.lbl_TDRPRC.Size = New System.Drawing.Size(64, 16)
        Me.lbl_TDRPRC.TabIndex = 14
        Me.lbl_TDRPRC.Text = "Dirección : "
        Me.lbl_TDRPRC.Values.ExtraText = ""
        Me.lbl_TDRPRC.Values.Image = Nothing
        Me.lbl_TDRPRC.Values.Text = "Dirección : "
        '
        'txt_CPAIS
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_CPAIS, True)
        Me.txt_CPAIS.Location = New System.Drawing.Point(85, 103)
        Me.txt_CPAIS.Name = "txt_CPAIS"
        Me.txt_CPAIS.Size = New System.Drawing.Size(114, 19)
        Me.txt_CPAIS.TabIndex = 11
        Me.TypeValidator.SetTypes(Me.txt_CPAIS, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_CPAIS
        '
        Me.lbl_CPAIS.Location = New System.Drawing.Point(3, 106)
        Me.lbl_CPAIS.Name = "lbl_CPAIS"
        Me.lbl_CPAIS.Size = New System.Drawing.Size(38, 16)
        Me.lbl_CPAIS.TabIndex = 10
        Me.lbl_CPAIS.Text = "País : "
        Me.lbl_CPAIS.Values.ExtraText = ""
        Me.lbl_CPAIS.Values.Image = Nothing
        Me.lbl_CPAIS.Values.Text = "País : "
        '
        'txt_TNROFX
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TNROFX, True)
        Me.txt_TNROFX.Location = New System.Drawing.Point(283, 153)
        Me.txt_TNROFX.MaxLength = 40
        Me.txt_TNROFX.Name = "txt_TNROFX"
        Me.txt_TNROFX.Size = New System.Drawing.Size(114, 19)
        Me.txt_TNROFX.TabIndex = 19
        Me.TypeValidator.SetTypes(Me.txt_TNROFX, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TNROFX
        '
        Me.lbl_TNROFX.Location = New System.Drawing.Point(203, 156)
        Me.lbl_TNROFX.Name = "lbl_TNROFX"
        Me.lbl_TNROFX.Size = New System.Drawing.Size(63, 16)
        Me.lbl_TNROFX.TabIndex = 18
        Me.lbl_TNROFX.Text = "Nro . Fax : "
        Me.lbl_TNROFX.Values.ExtraText = ""
        Me.lbl_TNROFX.Values.Image = Nothing
        Me.lbl_TNROFX.Values.Text = "Nro . Fax : "
        '
        'txt_TLFNO1
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TLFNO1, True)
        Me.txt_TLFNO1.Location = New System.Drawing.Point(85, 153)
        Me.txt_TLFNO1.MaxLength = 15
        Me.txt_TLFNO1.Name = "txt_TLFNO1"
        Me.txt_TLFNO1.Size = New System.Drawing.Size(114, 19)
        Me.txt_TLFNO1.TabIndex = 17
        Me.TypeValidator.SetTypes(Me.txt_TLFNO1, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TLFNO1
        '
        Me.lbl_TLFNO1.Location = New System.Drawing.Point(3, 156)
        Me.lbl_TLFNO1.Name = "lbl_TLFNO1"
        Me.lbl_TLFNO1.Size = New System.Drawing.Size(60, 16)
        Me.lbl_TLFNO1.TabIndex = 16
        Me.lbl_TLFNO1.Text = "Teléfono : "
        Me.lbl_TLFNO1.Values.ExtraText = ""
        Me.lbl_TLFNO1.Values.Image = Nothing
        Me.lbl_TLFNO1.Values.Text = "Teléfono : "
        '
        'txt_TEMAI2
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TEMAI2, True)
        Me.txt_TEMAI2.Location = New System.Drawing.Point(85, 178)
        Me.txt_TEMAI2.MaxLength = 40
        Me.txt_TEMAI2.Name = "txt_TEMAI2"
        Me.txt_TEMAI2.Size = New System.Drawing.Size(312, 19)
        Me.txt_TEMAI2.TabIndex = 21
        Me.TypeValidator.SetTypes(Me.txt_TEMAI2, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TEMAI2
        '
        Me.lbl_TEMAI2.Location = New System.Drawing.Point(3, 181)
        Me.lbl_TEMAI2.Name = "lbl_TEMAI2"
        Me.lbl_TEMAI2.Size = New System.Drawing.Size(50, 16)
        Me.lbl_TEMAI2.TabIndex = 20
        Me.lbl_TEMAI2.Text = "Em@il : "
        Me.lbl_TEMAI2.Values.ExtraText = ""
        Me.lbl_TEMAI2.Values.Image = Nothing
        Me.lbl_TEMAI2.Values.Text = "Em@il : "
        '
        'txt_TPRSCN
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TPRSCN, True)
        Me.txt_TPRSCN.Location = New System.Drawing.Point(82, 19)
        Me.txt_TPRSCN.MaxLength = 40
        Me.txt_TPRSCN.Name = "txt_TPRSCN"
        Me.txt_TPRSCN.Size = New System.Drawing.Size(299, 19)
        Me.txt_TPRSCN.TabIndex = 24
        Me.TypeValidator.SetTypes(Me.txt_TPRSCN, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TPRSCN
        '
        Me.lbl_TPRSCN.Location = New System.Drawing.Point(7, 22)
        Me.lbl_TPRSCN.Name = "lbl_TPRSCN"
        Me.lbl_TPRSCN.Size = New System.Drawing.Size(71, 16)
        Me.lbl_TPRSCN.TabIndex = 23
        Me.lbl_TPRSCN.Text = "Referencia : "
        Me.lbl_TPRSCN.Values.ExtraText = ""
        Me.lbl_TPRSCN.Values.Image = Nothing
        Me.lbl_TPRSCN.Values.Text = "Referencia : "
        '
        'txt_TLFNO2
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TLFNO2, True)
        Me.txt_TLFNO2.Location = New System.Drawing.Point(82, 44)
        Me.txt_TLFNO2.MaxLength = 15
        Me.txt_TLFNO2.Name = "txt_TLFNO2"
        Me.txt_TLFNO2.Size = New System.Drawing.Size(107, 19)
        Me.txt_TLFNO2.TabIndex = 26
        Me.TypeValidator.SetTypes(Me.txt_TLFNO2, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TLFNO2
        '
        Me.lbl_TLFNO2.Location = New System.Drawing.Point(7, 47)
        Me.lbl_TLFNO2.Name = "lbl_TLFNO2"
        Me.lbl_TLFNO2.Size = New System.Drawing.Size(60, 16)
        Me.lbl_TLFNO2.TabIndex = 25
        Me.lbl_TLFNO2.Text = "Teléfono : "
        Me.lbl_TLFNO2.Values.ExtraText = ""
        Me.lbl_TLFNO2.Values.Image = Nothing
        Me.lbl_TLFNO2.Values.Text = "Teléfono : "
        '
        'txt_TEMAI3
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_TEMAI3, True)
        Me.txt_TEMAI3.Location = New System.Drawing.Point(82, 69)
        Me.txt_TEMAI3.MaxLength = 40
        Me.txt_TEMAI3.Name = "txt_TEMAI3"
        Me.txt_TEMAI3.Size = New System.Drawing.Size(299, 19)
        Me.txt_TEMAI3.TabIndex = 28
        Me.TypeValidator.SetTypes(Me.txt_TEMAI3, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lbl_TEMAI3
        '
        Me.lbl_TEMAI3.Location = New System.Drawing.Point(7, 72)
        Me.lbl_TEMAI3.Name = "lbl_TEMAI3"
        Me.lbl_TEMAI3.Size = New System.Drawing.Size(50, 16)
        Me.lbl_TEMAI3.TabIndex = 27
        Me.lbl_TEMAI3.Text = "Em@il : "
        Me.lbl_TEMAI3.Values.ExtraText = ""
        Me.lbl_TEMAI3.Values.Image = Nothing
        Me.lbl_TEMAI3.Values.Text = "Em@il : "
        '
        'txt_NDSDMP
        '
        Me.TypeValidator.SetEnterTAB(Me.txt_NDSDMP, True)
        Me.txt_NDSDMP.Location = New System.Drawing.Point(283, 78)
        Me.txt_NDSDMP.MaxLength = 11
        Me.txt_NDSDMP.Name = "txt_NDSDMP"
        Me.txt_NDSDMP.Size = New System.Drawing.Size(114, 19)
        Me.txt_NDSDMP.TabIndex = 9
        Me.txt_NDSDMP.Text = "0"
        Me.txt_NDSDMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txt_NDSDMP, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lbl_NDSDMP
        '
        Me.lbl_NDSDMP.Location = New System.Drawing.Point(203, 81)
        Me.lbl_NDSDMP.Name = "lbl_NDSDMP"
        Me.lbl_NDSDMP.Size = New System.Drawing.Size(74, 16)
        Me.lbl_NDSDMP.TabIndex = 8
        Me.lbl_NDSDMP.Text = "Plazo Pago : "
        Me.lbl_NDSDMP.Values.ExtraText = ""
        Me.lbl_NDSDMP.Values.Image = Nothing
        Me.lbl_NDSDMP.Values.Text = "Plazo Pago : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_TPRSCN)
        Me.GroupBox1.Controls.Add(Me.lbl_TPRSCN)
        Me.GroupBox1.Controls.Add(Me.lbl_TLFNO2)
        Me.GroupBox1.Controls.Add(Me.txt_TEMAI3)
        Me.GroupBox1.Controls.Add(Me.txt_TLFNO2)
        Me.GroupBox1.Controls.Add(Me.lbl_TEMAI3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Contacto "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(211, 326)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(307, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'lbl_Situacion
        '
        Me.lbl_Situacion.AutoSize = True
        Me.lbl_Situacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Situacion.ForeColor = System.Drawing.Color.Red
        Me.lbl_Situacion.Location = New System.Drawing.Point(169, 6)
        Me.lbl_Situacion.Name = "lbl_Situacion"
        Me.lbl_Situacion.Size = New System.Drawing.Size(10, 15)
        Me.lbl_Situacion.TabIndex = 31
        Me.lbl_Situacion.Text = "."
        Me.lbl_Situacion.Visible = False
        '
        'ctrl_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lbl_Situacion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_NDSDMP)
        Me.Controls.Add(Me.lbl_NDSDMP)
        Me.Controls.Add(Me.lbl_CPRVCL)
        Me.Controls.Add(Me.txt_CPRVCL)
        Me.Controls.Add(Me.lbl_TPRVCL)
        Me.Controls.Add(Me.txt_TPRVCL)
        Me.Controls.Add(Me.txt_TEMAI2)
        Me.Controls.Add(Me.lbl_TEMAI2)
        Me.Controls.Add(Me.txt_TLFNO1)
        Me.Controls.Add(Me.lbl_TLFNO1)
        Me.Controls.Add(Me.txt_TNROFX)
        Me.Controls.Add(Me.lbl_TNROFX)
        Me.Controls.Add(Me.txt_CPAIS)
        Me.Controls.Add(Me.lbl_CPAIS)
        Me.Controls.Add(Me.txt_TDRPRC)
        Me.Controls.Add(Me.lbl_TDRPRC)
        Me.Controls.Add(Me.txt_TNACPR)
        Me.Controls.Add(Me.lbl_TNACPR)
        Me.Controls.Add(Me.txt_NRUCPR)
        Me.Controls.Add(Me.lbl_NRUCPR)
        Me.Controls.Add(Me.txt_TPRCL1)
        Me.Controls.Add(Me.lbl_TPRCL1)
        Me.Name = "ctrl_Proveedor"
        Me.Size = New System.Drawing.Size(407, 356)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents txt_TPRSCN As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TPRSCN As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txt_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TPRCL1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TPRCL1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TNACPR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TNACPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TDRPRC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TDRPRC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_CPAIS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_CPAIS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TNROFX As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TNROFX As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TLFNO1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TEMAI2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TLFNO2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_TEMAI3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TEMAI3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txt_NDSDMP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NDSDMP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lbl_Situacion As System.Windows.Forms.Label
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator

End Class
