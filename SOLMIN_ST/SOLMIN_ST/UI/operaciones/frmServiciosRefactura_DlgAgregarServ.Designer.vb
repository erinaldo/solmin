<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosRefactura_DlgAgregarServ
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
        Me.txtCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpInfServicio = New System.Windows.Forms.GroupBox()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblReferencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbServicio = New Ransa.Controls.ServTransp.ucServTransp_CmbF01()
        Me.cmbMoneda = New Ransa.Controls.Moneda.ucMoneda_CmbF01()
        Me.txtUnidad = New Ransa.Controls.Unidad.ucUnidad_TxF02()
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtCantidadServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblImpServGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkFacturacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtImporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtCorrelativoServ)
        Me.KryptonPanel.Controls.Add(Me.lblCorrelativoServ)
        Me.KryptonPanel.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel.Controls.Add(Me.txtReferencia)
        Me.KryptonPanel.Controls.Add(Me.lblReferencia)
        Me.KryptonPanel.Controls.Add(Me.cmbServicio)
        Me.KryptonPanel.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblCantidad)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadServ)
        Me.KryptonPanel.Controls.Add(Me.lblServicio)
        Me.KryptonPanel.Controls.Add(Me.lblImpServGuia)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel.Controls.Add(Me.chkFacturacionCliente)
        Me.KryptonPanel.Controls.Add(Me.txtImporte)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(501, 447)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.SystemColors.ButtonHighlight
        Me.KryptonPanel.TabIndex = 0
        '
        'txtCorrelativoServ
        '
        Me.TypeValidator.SetEnterTAB(Me.txtCorrelativoServ, True)
        Me.txtCorrelativoServ.Location = New System.Drawing.Point(140, 154)
        Me.txtCorrelativoServ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCorrelativoServ.Name = "txtCorrelativoServ"
        Me.txtCorrelativoServ.ReadOnly = True
        Me.txtCorrelativoServ.Size = New System.Drawing.Size(139, 26)
        Me.txtCorrelativoServ.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.txtCorrelativoServ.TabIndex = 7
        Me.txtCorrelativoServ.Text = "0"
        Me.txtCorrelativoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCorrelativoServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(40, 158)
        Me.lblCorrelativoServ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(88, 26)
        Me.lblCorrelativoServ.TabIndex = 6
        Me.lblCorrelativoServ.Text = "Corr. Serv. : "
        Me.lblCorrelativoServ.Values.ExtraText = ""
        Me.lblCorrelativoServ.Values.Image = Nothing
        Me.lblCorrelativoServ.Values.Text = "Corr. Serv. : "
        '
        'grpInfServicio
        '
        Me.grpInfServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfServicio.Controls.Add(Me.lblOperacion)
        Me.grpInfServicio.Controls.Add(Me.lblNroGuiaRemision)
        Me.grpInfServicio.Location = New System.Drawing.Point(16, 15)
        Me.grpInfServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInfServicio.Size = New System.Drawing.Size(460, 92)
        Me.grpInfServicio.TabIndex = 1
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(24, 23)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(111, 26)
        Me.lblOperacion.TabIndex = 2
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(24, 54)
        Me.lblNroGuiaRemision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(160, 26)
        Me.lblNroGuiaRemision.TabIndex = 3
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(139, 185)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReferencia.MaxLength = 35
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(313, 26)
        Me.txtReferencia.TabIndex = 9
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(40, 188)
        Me.lblReferencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(90, 26)
        Me.lblReferencia.TabIndex = 8
        Me.lblReferencia.Text = "Referencia : "
        Me.lblReferencia.Values.ExtraText = ""
        Me.lblReferencia.Values.Image = Nothing
        Me.lblReferencia.Values.Text = "Referencia : "
        '
        'cmbServicio
        '
        Me.cmbServicio.Location = New System.Drawing.Point(139, 121)
        Me.cmbServicio.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.pCodigoServicio = 0
        Me.cmbServicio.pIsRequired = False
        Me.cmbServicio.Size = New System.Drawing.Size(313, 28)
        Me.cmbServicio.TabIndex = 5
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Location = New System.Drawing.Point(139, 215)
        Me.cmbMoneda.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.pIsRequired = False
        Me.cmbMoneda.Size = New System.Drawing.Size(313, 28)
        Me.cmbMoneda.TabIndex = 11
        '
        'txtUnidad
        '
        Me.txtUnidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtUnidad.BackColor = System.Drawing.Color.Transparent
        Me.txtUnidad.Location = New System.Drawing.Point(139, 310)
        Me.txtUnidad.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.pIsRequired = False
        Me.txtUnidad.Size = New System.Drawing.Size(313, 26)
        Me.txtUnidad.TabIndex = 17
        Me.txtUnidad.TipoUnidad = ""
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(40, 283)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(80, 26)
        Me.lblCantidad.TabIndex = 14
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(356, 390)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 31)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'txtCantidadServ
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadServ, 3)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadServ, True)
        Me.txtCantidadServ.Location = New System.Drawing.Point(139, 279)
        Me.txtCantidadServ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidadServ.Name = "txtCantidadServ"
        Me.txtCantidadServ.Size = New System.Drawing.Size(140, 26)
        Me.txtCantidadServ.TabIndex = 15
        Me.txtCantidadServ.Text = "0.000"
        Me.txtCantidadServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(40, 127)
        Me.lblServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(72, 26)
        Me.lblServicio.TabIndex = 4
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'lblImpServGuia
        '
        Me.lblImpServGuia.Location = New System.Drawing.Point(40, 252)
        Me.lblImpServGuia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblImpServGuia.Name = "lblImpServGuia"
        Me.lblImpServGuia.Size = New System.Drawing.Size(73, 26)
        Me.lblImpServGuia.TabIndex = 12
        Me.lblImpServGuia.Text = "Importe : "
        Me.lblImpServGuia.Values.ExtraText = ""
        Me.lblImpServGuia.Values.Image = Nothing
        Me.lblImpServGuia.Values.Text = "Importe : "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(228, 390)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 31)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(40, 314)
        Me.lblUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(68, 26)
        Me.lblUnidad.TabIndex = 16
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(40, 222)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(76, 26)
        Me.lblMoneda.TabIndex = 10
        Me.lblMoneda.Text = "Moneda :"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda :"
        '
        'chkFacturacionCliente
        '
        Me.chkFacturacionCliente.Checked = False
        Me.chkFacturacionCliente.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFacturacionCliente.Enabled = False
        Me.chkFacturacionCliente.Location = New System.Drawing.Point(140, 341)
        Me.chkFacturacionCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkFacturacionCliente.Name = "chkFacturacionCliente"
        Me.chkFacturacionCliente.Size = New System.Drawing.Size(157, 26)
        Me.chkFacturacionCliente.TabIndex = 18
        Me.chkFacturacionCliente.Text = "Facturación Cliente"
        Me.chkFacturacionCliente.Values.ExtraText = ""
        Me.chkFacturacionCliente.Values.Image = Nothing
        Me.chkFacturacionCliente.Values.Text = "Facturación Cliente"
        '
        'txtImporte
        '
        Me.TypeValidator.SetDecimales(Me.txtImporte, 4)
        Me.TypeValidator.SetEnterTAB(Me.txtImporte, True)
        Me.txtImporte.Location = New System.Drawing.Point(139, 249)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(140, 26)
        Me.txtImporte.TabIndex = 13
        Me.txtImporte.Text = "0.0000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmServiciosRefactura_DlgAgregarServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmServiciosRefactura_DlgAgregarServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents cmbMoneda As Ransa.Controls.Moneda.ucMoneda_CmbF01
    Friend WithEvents txtUnidad As Ransa.Controls.Unidad.ucUnidad_TxF02
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCantidadServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblImpServGuia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkFacturacionCliente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtImporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblReferencia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbServicio As Ransa.Controls.ServTransp.ucServTransp_CmbF01
    Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
