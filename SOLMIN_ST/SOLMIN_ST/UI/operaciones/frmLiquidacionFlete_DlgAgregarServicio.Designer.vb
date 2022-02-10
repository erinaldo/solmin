<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionFlete_DlgAgregarServicio
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboUnidad = New Ransa.Utilitario.ucAyuda()
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadServ = New System.Windows.Forms.TextBox()
        Me.lblImpServGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkFacturacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.cboMoneda_2 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboProveedor = New Ransa.Controls.Transportista.ucTransportista_TxtF01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbServicio = New Ransa.Utilitario.ucAyuda()
        Me.grpInfServicio = New System.Windows.Forms.GroupBox()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblReferencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblmensaje = New System.Windows.Forms.Label()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel.Controls.Add(Me.cboProveedor)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.cmbServicio)
        Me.KryptonPanel.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel.Controls.Add(Me.txtCorrelativoServ)
        Me.KryptonPanel.Controls.Add(Me.lblCorrelativoServ)
        Me.KryptonPanel.Controls.Add(Me.txtReferencia)
        Me.KryptonPanel.Controls.Add(Me.lblReferencia)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.lblServicio)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(528, 523)
        Me.KryptonPanel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblmensaje)
        Me.GroupBox1.Controls.Add(Me.cboUnidad)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.txtCantidadServ)
        Me.GroupBox1.Controls.Add(Me.lblImpServGuia)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.lblUnidad)
        Me.GroupBox1.Controls.Add(Me.lblMoneda)
        Me.GroupBox1.Controls.Add(Me.chkFacturacionCliente)
        Me.GroupBox1.Controls.Add(Me.cboMoneda_2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 258)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(499, 192)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturación"
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.Transparent
        Me.cboUnidad.DataSource = Nothing
        Me.cboUnidad.DispleyMember = ""
        Me.cboUnidad.Etiquetas_Form = Nothing
        Me.cboUnidad.ListColumnas = Nothing
        Me.cboUnidad.Location = New System.Drawing.Point(123, 97)
        Me.cboUnidad.Margin = New System.Windows.Forms.Padding(5)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Obligatorio = False
        Me.cboUnidad.PopupHeight = 0
        Me.cboUnidad.PopupWidth = 0
        Me.cboUnidad.Size = New System.Drawing.Size(360, 26)
        Me.cboUnidad.SizeFont = 0
        Me.cboUnidad.TabIndex = 3
        Me.cboUnidad.ValueMember = ""
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(267, 69)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(80, 26)
        Me.lblCantidad.TabIndex = 30
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtCantidadServ
        '
        Me.txtCantidadServ.Location = New System.Drawing.Point(365, 66)
        Me.txtCantidadServ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadServ.MaxLength = 12
        Me.txtCantidadServ.Name = "txtCantidadServ"
        Me.txtCantidadServ.Size = New System.Drawing.Size(116, 22)
        Me.txtCantidadServ.TabIndex = 2
        Me.txtCantidadServ.Text = "0.000"
        Me.txtCantidadServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImpServGuia
        '
        Me.lblImpServGuia.Location = New System.Drawing.Point(24, 69)
        Me.lblImpServGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblImpServGuia.Name = "lblImpServGuia"
        Me.lblImpServGuia.Size = New System.Drawing.Size(57, 26)
        Me.lblImpServGuia.TabIndex = 28
        Me.lblImpServGuia.Text = "Tarifa : "
        Me.lblImpServGuia.Values.ExtraText = ""
        Me.lblImpServGuia.Values.Image = Nothing
        Me.lblImpServGuia.Values.Text = "Tarifa : "
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(123, 66)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.MaxLength = 16
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(132, 22)
        Me.txtImporte.TabIndex = 1
        Me.txtImporte.Text = "0.0000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(24, 101)
        Me.lblUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(68, 26)
        Me.lblUnidad.TabIndex = 32
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(24, 38)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(76, 26)
        Me.lblMoneda.TabIndex = 26
        Me.lblMoneda.Text = "Moneda :"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda :"
        '
        'chkFacturacionCliente
        '
        Me.chkFacturacionCliente.Checked = False
        Me.chkFacturacionCliente.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFacturacionCliente.Location = New System.Drawing.Point(124, 128)
        Me.chkFacturacionCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFacturacionCliente.Name = "chkFacturacionCliente"
        Me.chkFacturacionCliente.Size = New System.Drawing.Size(157, 26)
        Me.chkFacturacionCliente.TabIndex = 4
        Me.chkFacturacionCliente.Text = "Facturación Cliente"
        Me.chkFacturacionCliente.Values.ExtraText = ""
        Me.chkFacturacionCliente.Values.Image = Nothing
        Me.chkFacturacionCliente.Values.Text = "Facturación Cliente"
        '
        'cboMoneda_2
        '
        Me.cboMoneda_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda_2.DropDownWidth = 121
        Me.cboMoneda_2.FormattingEnabled = False
        Me.cboMoneda_2.ItemHeight = 20
        Me.cboMoneda_2.Location = New System.Drawing.Point(123, 32)
        Me.cboMoneda_2.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMoneda_2.Name = "cboMoneda_2"
        Me.cboMoneda_2.Size = New System.Drawing.Size(232, 28)
        Me.cboMoneda_2.TabIndex = 0
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboProveedor.BackColor = System.Drawing.Color.Transparent
        Me.cboProveedor.Location = New System.Drawing.Point(139, 130)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(5)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.pNroRegPorPaginas = 0
        Me.cboProveedor.pRequerido = False
        Me.cboProveedor.Size = New System.Drawing.Size(359, 26)
        Me.cboProveedor.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(37, 133)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(89, 26)
        Me.KryptonLabel1.TabIndex = 36
        Me.KryptonLabel1.Text = "Proveedor : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Proveedor : "
        '
        'cmbServicio
        '
        Me.cmbServicio.BackColor = System.Drawing.Color.Transparent
        Me.cmbServicio.DataSource = Nothing
        Me.cmbServicio.DispleyMember = ""
        Me.cmbServicio.Etiquetas_Form = Nothing
        Me.cmbServicio.ListColumnas = Nothing
        Me.cmbServicio.Location = New System.Drawing.Point(139, 161)
        Me.cmbServicio.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Obligatorio = False
        Me.cmbServicio.PopupHeight = 0
        Me.cmbServicio.PopupWidth = 0
        Me.cmbServicio.Size = New System.Drawing.Size(359, 26)
        Me.cmbServicio.SizeFont = 0
        Me.cmbServicio.TabIndex = 1
        Me.cmbServicio.ValueMember = ""
        '
        'grpInfServicio
        '
        Me.grpInfServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfServicio.Controls.Add(Me.lblOperacion)
        Me.grpInfServicio.Controls.Add(Me.lblNroGuiaRemision)
        Me.grpInfServicio.Location = New System.Drawing.Point(16, 15)
        Me.grpInfServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInfServicio.Size = New System.Drawing.Size(499, 92)
        Me.grpInfServicio.TabIndex = 18
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(24, 23)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(111, 26)
        Me.lblOperacion.TabIndex = 0
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(24, 54)
        Me.lblNroGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(160, 26)
        Me.lblNroGuiaRemision.TabIndex = 1
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'txtCorrelativoServ
        '
        Me.txtCorrelativoServ.Location = New System.Drawing.Point(140, 193)
        Me.txtCorrelativoServ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorrelativoServ.Name = "txtCorrelativoServ"
        Me.txtCorrelativoServ.ReadOnly = True
        Me.txtCorrelativoServ.Size = New System.Drawing.Size(139, 26)
        Me.txtCorrelativoServ.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.txtCorrelativoServ.TabIndex = 2
        Me.txtCorrelativoServ.Text = "0"
        Me.txtCorrelativoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(40, 197)
        Me.lblCorrelativoServ.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(88, 26)
        Me.lblCorrelativoServ.TabIndex = 22
        Me.lblCorrelativoServ.Text = "Corr. Serv. : "
        Me.lblCorrelativoServ.Values.ExtraText = ""
        Me.lblCorrelativoServ.Values.Image = Nothing
        Me.lblCorrelativoServ.Values.Text = "Corr. Serv. : "
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(139, 224)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia.MaxLength = 35
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(360, 26)
        Me.txtReferencia.TabIndex = 3
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(40, 228)
        Me.lblReferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(90, 26)
        Me.lblReferencia.TabIndex = 24
        Me.lblReferencia.Text = "Referencia : "
        Me.lblReferencia.Values.ExtraText = ""
        Me.lblReferencia.Values.Image = Nothing
        Me.lblReferencia.Values.Text = "Referencia : "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(267, 458)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 31)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(39, 165)
        Me.lblServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(72, 26)
        Me.lblServicio.TabIndex = 20
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(395, 458)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 31)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.ForeColor = System.Drawing.Color.Red
        Me.lblmensaje.Location = New System.Drawing.Point(120, 158)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(86, 17)
        Me.lblmensaje.TabIndex = 33
        Me.lblmensaje.Text = "Autorización"
        '
        'frmLiquidacionFlete_DlgAgregarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 523)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLiquidacionFlete_DlgAgregarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpInfServicio.ResumeLayout(False)
        Me.grpInfServicio.PerformLayout()
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
    Friend WithEvents cboUnidad As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboMoneda_2 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbServicio As Ransa.Utilitario.ucAyuda
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkFacturacionCliente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblReferencia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblImpServGuia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cboProveedor As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidadServ As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
End Class
