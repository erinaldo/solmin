<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor_UC
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
        Dim BeProveedor1 As Ransa.Controls.Proveedor.beProveedor = New Ransa.Controls.Proveedor.beProveedor
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.UcProveedor_DgCab1 = New Ransa.Controls.Proveedor.ucProveedor_DgCab
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.txtRUC = New System.Windows.Forms.TextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup8.Panel.SuspendLayout()
    Me.KryptonHeaderGroup8.SuspendLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonGroup1.Panel.SuspendLayout()
    Me.KryptonGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup8)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(997, 524)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonHeaderGroup8
    '
    Me.KryptonHeaderGroup8.AllowButtonSpecToolTips = True
    Me.KryptonHeaderGroup8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
    '
    'KryptonHeaderGroup8.Panel
    '
    Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.UcProveedor_DgCab1)
    Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonGroup1)
    Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(997, 524)
    Me.KryptonHeaderGroup8.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup8.TabIndex = 30
    Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup8.ValuesPrimary.Heading = ""
    Me.KryptonHeaderGroup8.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup8.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
    '
    'UcProveedor_DgCab1
    '
    Me.UcProveedor_DgCab1.Dock = System.Windows.Forms.DockStyle.Fill
    BeProveedor1.CREACION = ""
    BeProveedor1.PageCount = 0
    BeProveedor1.PageNumber = 0
    BeProveedor1.PageSize = 0
    BeProveedor1.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNCPAIS = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNFCHCRT = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNFULTAC = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNHRACRT = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNHULTAC = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNNDSDMP = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PNUPDATE_IDENT = New Decimal(New Integer() {0, 0, 0, 0})
    BeProveedor1.PSBUSQUEDA = ""
    BeProveedor1.PSCPRVCLSTR = ""
    BeProveedor1.PSCULUSA = ""
    BeProveedor1.PSCUSCRT = ""
    BeProveedor1.PSDIRCOMPLETO = ""
    BeProveedor1.PSNOMCOMPLETO = ""
    BeProveedor1.PSNRUCPRSTR = ""
    BeProveedor1.PSSESTRG = ""
    BeProveedor1.PSSTPORL = ""
    BeProveedor1.PSTDRPRC = ""
    BeProveedor1.PSTEMAI2 = ""
    BeProveedor1.PSTEMAI3 = ""
    BeProveedor1.PSTLFNO1 = ""
    BeProveedor1.PSTLFNO2 = ""
    BeProveedor1.PSTNACPR = ""
    BeProveedor1.PSTNROFX = ""
    BeProveedor1.PSTPRCL1 = ""
    BeProveedor1.PSTPRSCN = ""
    BeProveedor1.PSTPRVCL = ""
    BeProveedor1.RELACION = ""
    Me.UcProveedor_DgCab1.infoProveedor = BeProveedor1
    Me.UcProveedor_DgCab1.Location = New System.Drawing.Point(0, 54)
    Me.UcProveedor_DgCab1.Name = "UcProveedor_DgCab1"
    Me.UcProveedor_DgCab1.pMostrarBotonBuscar = True
    Me.UcProveedor_DgCab1.pMostrarTituloOpcion1 = False
    Me.UcProveedor_DgCab1.Size = New System.Drawing.Size(995, 462)
    Me.UcProveedor_DgCab1.TabIndex = 3
    '
    'KryptonGroup1
    '
    Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonGroup1.Name = "KryptonGroup1"
    '
    'KryptonGroup1.Panel
    '
    Me.KryptonGroup1.Panel.AutoScroll = True
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtRUC)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonGroup1.Panel.Controls.Add(Me.cmbCliente)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonGroup1.Size = New System.Drawing.Size(995, 54)
    Me.KryptonGroup1.TabIndex = 2
    '
    'txtRUC
    '
    Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRUC.Location = New System.Drawing.Point(762, 19)
    Me.txtRUC.MaxLength = 11
    Me.txtRUC.Name = "txtRUC"
    Me.txtRUC.Size = New System.Drawing.Size(143, 18)
    Me.txtRUC.TabIndex = 20
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(13, 15)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(50, 19)
    Me.KryptonLabel2.TabIndex = 43
    Me.KryptonLabel2.Text = "Cliente :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Cliente :"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(722, 18)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(34, 19)
    Me.KryptonLabel3.TabIndex = 44
    Me.KryptonLabel3.Text = "RUC:"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "RUC:"
    '
    'cmbCliente
    '
    Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
    Me.cmbCliente.CCMPN = "EZ"
    Me.cmbCliente.Location = New System.Drawing.Point(69, 15)
    Me.cmbCliente.Name = "cmbCliente"
    Me.cmbCliente.pAccesoPorUsuario = True
    Me.cmbCliente.pRequerido = True
    Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.cmbCliente.Size = New System.Drawing.Size(320, 21)
    Me.cmbCliente.TabIndex = 0
    '
    'txtDescripcion
    '
    Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.Location = New System.Drawing.Point(478, 18)
    Me.txtDescripcion.MaxLength = 30
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(238, 18)
    Me.txtDescripcion.TabIndex = 10
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(408, 17)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(64, 19)
    Me.KryptonLabel1.TabIndex = 42
    Me.KryptonLabel1.Text = "Proveedor:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Proveedor:"
    '
    'frmProveedor_UC
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(997, 524)
    Me.Controls.Add(Me.KryptonPanel)
    Me.MinimizeBox = False
    Me.Name = "frmProveedor_UC"
    Me.Text = "Proveedor"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup8.ResumeLayout(False)
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.Panel.ResumeLayout(False)
    Me.KryptonGroup1.Panel.PerformLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents UcProveedor_DgCab1 As Ransa.Controls.Proveedor.ucProveedor_DgCab
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Friend WithEvents txtRUC As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
