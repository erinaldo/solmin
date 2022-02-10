<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionItem
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
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.cmbMoneda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPrecioUniatrio = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtCantidad = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtNroitem = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtGuiaProv = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRefNum = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cbxUnidadMedida = New Ransa.Controls.Unidad.ucUnidad_TxF01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cbxUnidadMedida)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.UcProveedor)
        Me.KryptonPanel.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.txtPrecioUniatrio)
        Me.KryptonPanel.Controls.Add(Me.txtCantidad)
        Me.KryptonPanel.Controls.Add(Me.txtNroitem)
        Me.KryptonPanel.Controls.Add(Me.txtGuiaProv)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.txtRefNum)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(584, 229)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 98)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(62, 19)
        Me.KryptonLabel9.TabIndex = 42
        Me.KryptonLabel9.Text = "Proveedor"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Proveedor"
        '
        'UcProveedor
        '
        Me.UcProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcProveedor.BackColor = System.Drawing.Color.Transparent
        Me.UcProveedor.Location = New System.Drawing.Point(112, 98)
        Me.UcProveedor.Name = "UcProveedor"
        Me.UcProveedor.pCodigo = CType(0, Long)
        Me.UcProveedor.pMostarBtnNewProv = False
        Me.UcProveedor.pRequerido = False
        Me.UcProveedor.Size = New System.Drawing.Size(452, 21)
        Me.UcProveedor.TabIndex = 41
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.DropDownWidth = 121
        Me.cmbMoneda.FormattingEnabled = False
        Me.cmbMoneda.ItemHeight = 13
        Me.cmbMoneda.Location = New System.Drawing.Point(400, 183)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cmbMoneda.TabIndex = 16
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(311, 183)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Moneda"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Moneda"
        '
        'txtPrecioUniatrio
        '
        Me.txtPrecioUniatrio.Location = New System.Drawing.Point(112, 188)
        Me.txtPrecioUniatrio.MaxLength = 10
        Me.txtPrecioUniatrio.Name = "txtPrecioUniatrio"
        Me.txtPrecioUniatrio.NUMDECIMALES = 5
        Me.txtPrecioUniatrio.NUMENTEROS = 10
        Me.txtPrecioUniatrio.Size = New System.Drawing.Size(88, 20)
        Me.txtPrecioUniatrio.TabIndex = 14
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(112, 159)
        Me.txtCantidad.MaxLength = 10
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NUMDECIMALES = 5
        Me.txtCantidad.NUMENTEROS = 10
        Me.txtCantidad.Size = New System.Drawing.Size(88, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'txtNroitem
        '
        Me.txtNroitem.Location = New System.Drawing.Point(112, 40)
        Me.txtNroitem.MaxLength = 10
        Me.txtNroitem.Name = "txtNroitem"
        Me.txtNroitem.NUMDECIMALES = 0
        Me.txtNroitem.NUMENTEROS = 6
        Me.txtNroitem.Size = New System.Drawing.Size(79, 20)
        Me.txtNroitem.TabIndex = 2
        '
        'txtGuiaProv
        '
        Me.txtGuiaProv.Location = New System.Drawing.Point(400, 126)
        Me.txtGuiaProv.Name = "txtGuiaProv"
        Me.txtGuiaProv.Size = New System.Drawing.Size(164, 21)
        Me.txtGuiaProv.TabIndex = 8
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(12, 130)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel7.TabIndex = 5
        Me.KryptonLabel7.Text = "Guía(Remisión)"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Guía(Remisión)"
        '
        'txtRefNum
        '
        Me.txtRefNum.Location = New System.Drawing.Point(112, 128)
        Me.txtRefNum.MaxLength = 20
        Me.txtRefNum.Name = "txtRefNum"
        Me.txtRefNum.Size = New System.Drawing.Size(164, 21)
        Me.txtRefNum.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 67)
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(452, 21)
        Me.txtDescripcion.TabIndex = 4
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 66)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel6.TabIndex = 3
        Me.KryptonLabel6.Text = "Descripción"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Descripción"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 162)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Cantidad"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cantidad"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 188)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Precio Unit."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Precio Unit."
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(311, 154)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(77, 19)
        Me.KryptonLabel3.TabIndex = 11
        Me.KryptonLabel3.Text = "Unid. medida"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Unid. medida"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(311, 126)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(62, 19)
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Text = "Guía(Prov)"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Guía(Prov)"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 40)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Nro item"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro item"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(58, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok1
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(66, 22)
        Me.btnGuardar.Text = "Aceptar"
        '
        'cbxUnidadMedida
        '
        Me.cbxUnidadMedida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cbxUnidadMedida.BackColor = System.Drawing.Color.Transparent
        Me.cbxUnidadMedida.Location = New System.Drawing.Point(400, 152)
        Me.cbxUnidadMedida.Name = "cbxUnidadMedida"
        Me.cbxUnidadMedida.pIsRequired = True
        Me.cbxUnidadMedida.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnidadMedida.TabIndex = 43
        Me.cbxUnidadMedida.TipoUnidad = ""
        '
        'frmAdicionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 229)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAdicionItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos item"
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
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRefNum As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtGuiaProv As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroitem As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtCantidad As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtPrecioUniatrio As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents cmbMoneda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcProveedor As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents cbxUnidadMedida As Ransa.Controls.Unidad.ucUnidad_TxF01
End Class
