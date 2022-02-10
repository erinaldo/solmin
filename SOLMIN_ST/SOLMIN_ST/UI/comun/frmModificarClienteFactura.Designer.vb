<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarClienteFactura
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ucNivelServ = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel42 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcAyuda1 = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcAyuda2 = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcAyuda3 = New Ransa.Utilitario.ucAyuda
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UcAyuda3)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.UcAyuda2)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.UcAyuda1)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.ucNivelServ)
        Me.Panel1.Controls.Add(Me.KryptonLabel42)
        Me.Panel1.Controls.Add(Me.txtClienteFiltro)
        Me.Panel1.Controls.Add(Me.KryptonLabel18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 198)
        Me.Panel1.StateNormal.Color1 = System.Drawing.Color.White
        Me.Panel1.TabIndex = 0
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(89, 58)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pCDDRSP_CodClienteSAP = ""
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.pVisualizaNegocio = False
        Me.txtClienteFiltro.Size = New System.Drawing.Size(319, 22)
        Me.txtClienteFiltro.TabIndex = 15
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(9, 58)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(48, 22)
        Me.KryptonLabel18.TabIndex = 14
        Me.KryptonLabel18.Text = "Cliente"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Cliente"
        '
        'ucNivelServ
        '
        Me.ucNivelServ.BackColor = System.Drawing.Color.Transparent
        Me.ucNivelServ.DataSource = Nothing
        Me.ucNivelServ.DispleyMember = ""
        Me.ucNivelServ.Etiquetas_Form = Nothing
        Me.ucNivelServ.ListColumnas = Nothing
        Me.ucNivelServ.Location = New System.Drawing.Point(89, 106)
        Me.ucNivelServ.Name = "ucNivelServ"
        Me.ucNivelServ.Obligatorio = False
        Me.ucNivelServ.PopupHeight = 0
        Me.ucNivelServ.PopupWidth = 0
        Me.ucNivelServ.Size = New System.Drawing.Size(161, 21)
        Me.ucNivelServ.TabIndex = 67
        Me.ucNivelServ.ValueMember = ""
        '
        'KryptonLabel42
        '
        Me.KryptonLabel42.Location = New System.Drawing.Point(9, 105)
        Me.KryptonLabel42.Name = "KryptonLabel42"
        Me.KryptonLabel42.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel42.TabIndex = 66
        Me.KryptonLabel42.Text = "CeBe Propio:"
        Me.KryptonLabel42.Values.ExtraText = ""
        Me.KryptonLabel42.Values.Image = Nothing
        Me.KryptonLabel42.Values.Text = "CeBe Propio:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(259, 105)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel1.TabIndex = 66
        Me.KryptonLabel1.Text = "CeBe Propio:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "CeBe Propio:"
        '
        'UcAyuda1
        '
        Me.UcAyuda1.BackColor = System.Drawing.Color.Transparent
        Me.UcAyuda1.DataSource = Nothing
        Me.UcAyuda1.DispleyMember = ""
        Me.UcAyuda1.Etiquetas_Form = Nothing
        Me.UcAyuda1.ListColumnas = Nothing
        Me.UcAyuda1.Location = New System.Drawing.Point(339, 106)
        Me.UcAyuda1.Name = "UcAyuda1"
        Me.UcAyuda1.Obligatorio = False
        Me.UcAyuda1.PopupHeight = 0
        Me.UcAyuda1.PopupWidth = 0
        Me.UcAyuda1.Size = New System.Drawing.Size(161, 21)
        Me.UcAyuda1.TabIndex = 67
        Me.UcAyuda1.ValueMember = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(9, 146)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel2.TabIndex = 66
        Me.KryptonLabel2.Text = "CeBe Propio:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "CeBe Propio:"
        '
        'UcAyuda2
        '
        Me.UcAyuda2.BackColor = System.Drawing.Color.Transparent
        Me.UcAyuda2.DataSource = Nothing
        Me.UcAyuda2.DispleyMember = ""
        Me.UcAyuda2.Etiquetas_Form = Nothing
        Me.UcAyuda2.ListColumnas = Nothing
        Me.UcAyuda2.Location = New System.Drawing.Point(89, 147)
        Me.UcAyuda2.Name = "UcAyuda2"
        Me.UcAyuda2.Obligatorio = False
        Me.UcAyuda2.PopupHeight = 0
        Me.UcAyuda2.PopupWidth = 0
        Me.UcAyuda2.Size = New System.Drawing.Size(161, 21)
        Me.UcAyuda2.TabIndex = 67
        Me.UcAyuda2.ValueMember = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(259, 146)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel3.TabIndex = 66
        Me.KryptonLabel3.Text = "CeBe Propio:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "CeBe Propio:"
        '
        'UcAyuda3
        '
        Me.UcAyuda3.BackColor = System.Drawing.Color.Transparent
        Me.UcAyuda3.DataSource = Nothing
        Me.UcAyuda3.DispleyMember = ""
        Me.UcAyuda3.Etiquetas_Form = Nothing
        Me.UcAyuda3.ListColumnas = Nothing
        Me.UcAyuda3.Location = New System.Drawing.Point(339, 147)
        Me.UcAyuda3.Name = "UcAyuda3"
        Me.UcAyuda3.Obligatorio = False
        Me.UcAyuda3.PopupHeight = 0
        Me.UcAyuda3.PopupWidth = 0
        Me.UcAyuda3.Size = New System.Drawing.Size(161, 21)
        Me.UcAyuda3.TabIndex = 67
        Me.UcAyuda3.ValueMember = ""
        '
        'frmModificarClienteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 198)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmModificarClienteFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente Factura"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents Panel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcAyuda3 As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcAyuda2 As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcAyuda1 As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ucNivelServ As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel42 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
