<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOCDet
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
        Me.dgOrdenCompra = New Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01
        Me.dgItemsOC = New Ransa.Controls.OrdenCompra.ucItemOC_DgF01
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTermIternN = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF02
        Me.UcProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.lblMedio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReq = New System.Windows.Forms.TextBox
        Me.chxReq = New System.Windows.Forms.CheckBox
        Me.cmbTransporte = New System.Windows.Forms.ComboBox
        Me.txtOC = New System.Windows.Forms.TextBox
        Me.chxOC = New System.Windows.Forms.CheckBox
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.chxFecha = New System.Windows.Forms.CheckBox
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.dgItemsOC)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1008, 670)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgOrdenCompra
        '
        Me.dgOrdenCompra.Agregar = True
        Me.dgOrdenCompra.BackColor = System.Drawing.Color.Transparent
        Me.dgOrdenCompra.Buscar = True
        Me.dgOrdenCompra.CambiarDeCliente = True
        Me.dgOrdenCompra.CodCliente = 0
        Me.dgOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenCompra.Eliminar = True
        Me.dgOrdenCompra.Location = New System.Drawing.Point(0, 130)
        Me.dgOrdenCompra.Modificar = True
        Me.dgOrdenCompra.Name = "dgOrdenCompra"
        Me.dgOrdenCompra.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgOrdenCompra.pREGPAG_NroRegPorPagina = 20
        Me.dgOrdenCompra.Size = New System.Drawing.Size(1008, 305)
        Me.dgOrdenCompra.TabIndex = 32
        Me.dgOrdenCompra.Traslado = True
        '
        'dgItemsOC
        '
        Me.dgItemsOC.Agregar = True
        Me.dgItemsOC.BackColor = System.Drawing.Color.Transparent
        Me.dgItemsOC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgItemsOC.Eliminar = True
        Me.dgItemsOC.Location = New System.Drawing.Point(0, 435)
        Me.dgItemsOC.Modificar = True
        Me.dgItemsOC.Name = "dgItemsOC"
        Me.dgItemsOC.pEstado = ""
        Me.dgItemsOC.pMostrarGenerar = Ransa.Controls.OrdenCompra.eGenerarTipo.Ninguno
        Me.dgItemsOC.pMostrarGenerarRecojo = False
        Me.dgItemsOC.Size = New System.Drawing.Size(1008, 235)
        Me.dgItemsOC.TabIndex = 31
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTermIternN)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcProveedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblMedio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblProveedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtReq)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chxReq)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chxOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chxFecha)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1008, 130)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 30
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(408, 82)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel1.TabIndex = 50
        Me.KryptonLabel1.Text = "Term. Inter. :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Term. Inter. :"
        '
        'cmbTermIternN
        '
        Me.cmbTermIternN.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermIternN.Location = New System.Drawing.Point(497, 81)
        Me.cmbTermIternN.Name = "cmbTermIternN"
        Me.cmbTermIternN.pIsRequired = False
        Me.cmbTermIternN.Size = New System.Drawing.Size(297, 21)
        Me.cmbTermIternN.TabIndex = 49
        '
        'UcProveedor
        '
        Me.UcProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcProveedor.BackColor = System.Drawing.Color.Transparent
        Me.UcProveedor.Location = New System.Drawing.Point(91, 58)
        Me.UcProveedor.Name = "UcProveedor"
        Me.UcProveedor.pCodigo = CType(0, Long)
        Me.UcProveedor.pMostarBtnNewProv = False
        Me.UcProveedor.pRequerido = False
        Me.UcProveedor.Size = New System.Drawing.Size(303, 21)
        Me.UcProveedor.TabIndex = 48
        '
        'lblMedio
        '
        Me.lblMedio.Location = New System.Drawing.Point(11, 82)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(70, 19)
        Me.lblMedio.TabIndex = 47
        Me.lblMedio.Text = "Transporte :"
        Me.lblMedio.Values.ExtraText = ""
        Me.lblMedio.Values.Image = Nothing
        Me.lblMedio.Values.Text = "Transporte :"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(11, 57)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(64, 19)
        Me.lblProveedor.TabIndex = 46
        Me.lblProveedor.Text = "Proveedor:"
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 19)
        Me.lblCliente.TabIndex = 45
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente:"
        '
        'txtReq
        '
        Me.txtReq.Enabled = False
        Me.txtReq.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtReq.Location = New System.Drawing.Point(497, 57)
        Me.txtReq.Name = "txtReq"
        Me.txtReq.Size = New System.Drawing.Size(297, 20)
        Me.txtReq.TabIndex = 43
        '
        'chxReq
        '
        Me.chxReq.AutoSize = True
        Me.chxReq.BackColor = System.Drawing.Color.White
        Me.chxReq.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chxReq.Location = New System.Drawing.Point(409, 60)
        Me.chxReq.Name = "chxReq"
        Me.chxReq.Size = New System.Drawing.Size(82, 17)
        Me.chxReq.TabIndex = 42
        Me.chxReq.Text = "N° de Req :"
        Me.chxReq.UseVisualStyleBackColor = False
        '
        'cmbTransporte
        '
        Me.cmbTransporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransporte.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbTransporte.FormattingEnabled = True
        Me.cmbTransporte.Location = New System.Drawing.Point(91, 82)
        Me.cmbTransporte.Name = "cmbTransporte"
        Me.cmbTransporte.Size = New System.Drawing.Size(304, 22)
        Me.cmbTransporte.TabIndex = 41
        '
        'txtOC
        '
        Me.txtOC.Enabled = False
        Me.txtOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtOC.Location = New System.Drawing.Point(497, 31)
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Size = New System.Drawing.Size(297, 20)
        Me.txtOC.TabIndex = 38
        '
        'chxOC
        '
        Me.chxOC.AutoSize = True
        Me.chxOC.BackColor = System.Drawing.Color.White
        Me.chxOC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chxOC.Location = New System.Drawing.Point(409, 36)
        Me.chxOC.Name = "chxOC"
        Me.chxOC.Size = New System.Drawing.Size(77, 17)
        Me.chxOC.TabIndex = 31
        Me.chxOC.Text = "N° de OC :"
        Me.chxOC.UseVisualStyleBackColor = False
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(700, 5)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(94, 20)
        Me.dtpFin.TabIndex = 30
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(553, 5)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(94, 20)
        Me.dtpInicio.TabIndex = 29
        '
        'chxFecha
        '
        Me.chxFecha.AutoSize = True
        Me.chxFecha.BackColor = System.Drawing.Color.White
        Me.chxFecha.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chxFecha.Location = New System.Drawing.Point(409, 8)
        Me.chxFecha.Name = "chxFecha"
        Me.chxFecha.Size = New System.Drawing.Size(59, 17)
        Me.chxFecha.TabIndex = 27
        Me.chxFecha.Text = "Fecha:"
        Me.chxFecha.UseVisualStyleBackColor = False
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbCliente.Location = New System.Drawing.Point(91, 33)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = False
        Me.cmbCliente.pRequerido = False
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(304, 21)
        Me.cmbCliente.TabIndex = 44
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(11, 7)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel24.TabIndex = 54
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(91, 7)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(303, 23)
        Me.cmbCompania.TabIndex = 53
        Me.cmbCompania.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(497, 5)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel2.TabIndex = 55
        Me.KryptonLabel2.Text = "Desde:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Desde:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(653, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(41, 19)
        Me.KryptonLabel3.TabIndex = 56
        Me.KryptonLabel3.Text = "Hasta:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hasta:"
        '
        'frmOCDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 670)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmOCDet"
        Me.Text = "Orden de Compra"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgOrdenCompra As Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01
    Friend WithEvents dgItemsOC As Ransa.Controls.OrdenCompra.ucItemOC_DgF01
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
    Friend WithEvents chxOC As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents txtReq As System.Windows.Forms.TextBox
    Friend WithEvents chxReq As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCliente As New Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblMedio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcProveedor As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents cmbTermIternN As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF02
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
