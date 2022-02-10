<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercaderia
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
    Me.dtgMercaderia = New Ransa.Controls.Mercaderia.ucMercaderia_DgF01
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New System.Windows.Forms.TextBox
    Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
    Me.KryptonPanel.Controls.Add(Me.dtgMercaderia)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1008, 693)
    Me.KryptonPanel.TabIndex = 0
    '
    'dtgMercaderia
    '
    Me.dtgMercaderia.BackColor = System.Drawing.Color.Transparent
    Me.dtgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgMercaderia.Location = New System.Drawing.Point(0, 62)
    Me.dtgMercaderia.Name = "dtgMercaderia"
    Me.dtgMercaderia.pMostrarBotonBuscar = True
    Me.dtgMercaderia.pMostrarBotonesGestion = False
    Me.dtgMercaderia.pMostrarBotonReporte = False
    Me.dtgMercaderia.pMostrarFmtCatalogo = True
    Me.dtgMercaderia.pNroRegPorPagina = 35
    Me.dtgMercaderia.Size = New System.Drawing.Size(1008, 631)
    Me.dtgMercaderia.TabIndex = 5
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.AutoSize = True
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.AutoScroll = True
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
    Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1008, 62)
    Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup1.TabIndex = 4
    Me.KryptonHeaderGroup1.Text = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'cmbCliente
    '
    Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
    Me.cmbCliente.CCMPN = "EZ"
    Me.cmbCliente.Location = New System.Drawing.Point(80, 8)
    Me.cmbCliente.Name = "cmbCliente"
    Me.cmbCliente.pAccesoPorUsuario = False
    Me.cmbCliente.pRequerido = False
    Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.cmbCliente.Size = New System.Drawing.Size(312, 21)
    Me.cmbCliente.TabIndex = 43
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(414, 13)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(127, 19)
    Me.KryptonLabel1.TabIndex = 42
    Me.KryptonLabel1.Text = "Código de Mercadería :"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Código de Mercadería :"
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(548, 9)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(115, 20)
    Me.txtCodigo.TabIndex = 41
    '
    'lblCliente
    '
    Me.lblCliente.Location = New System.Drawing.Point(21, 13)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(50, 19)
    Me.lblCliente.TabIndex = 12
    Me.lblCliente.Text = "Cliente :"
    Me.lblCliente.Values.ExtraText = ""
    Me.lblCliente.Values.Image = Nothing
    Me.lblCliente.Values.Text = "Cliente :"
    '
    'frmMercaderia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1008, 693)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmMercaderia"
    Me.Text = "Mercaderias"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgMercaderia As Ransa.Controls.Mercaderia.ucMercaderia_DgF01
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
