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
        Me.components = New System.ComponentModel.Container
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblReferencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbMoneda = New Ransa.Controls.Moneda.ucMoneda_CmbF01
        Me.txtUnidad = New Ransa.Controls.Unidad.ucUnidad_TxF02
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpInfServicio = New System.Windows.Forms.GroupBox
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbServicio = New Ransa.Controls.ServTransp.ucServTransp_CmbF01
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCantidadServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblImpServGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkFacturacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtImporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(366, 349)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(104, 150)
        Me.txtReferencia.MaxLength = 35
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(235, 22)
        Me.txtReferencia.TabIndex = 9
        Me.TypeValidator.SetTypes(Me.txtReferencia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(30, 153)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(73, 20)
        Me.lblReferencia.TabIndex = 8
        Me.lblReferencia.Text = "Referencia : "
        Me.lblReferencia.Values.ExtraText = ""
        Me.lblReferencia.Values.Image = Nothing
        Me.lblReferencia.Values.Text = "Referencia : "
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Location = New System.Drawing.Point(104, 175)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.pIsRequired = False
        Me.cmbMoneda.Size = New System.Drawing.Size(235, 23)
        Me.cmbMoneda.TabIndex = 11
        '
        'txtUnidad
        '
        Me.txtUnidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtUnidad.BackColor = System.Drawing.Color.Transparent
        Me.txtUnidad.Location = New System.Drawing.Point(104, 252)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.pIsRequired = False
        Me.txtUnidad.Size = New System.Drawing.Size(235, 22)
        Me.txtUnidad.TabIndex = 17
        Me.txtUnidad.TipoUnidad = ""
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtCorrelativoServ)
        Me.KryptonPanel1.Controls.Add(Me.lblCorrelativoServ)
        Me.KryptonPanel1.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel1.Controls.Add(Me.txtReferencia)
        Me.KryptonPanel1.Controls.Add(Me.lblReferencia)
        Me.KryptonPanel1.Controls.Add(Me.cmbServicio)
        Me.KryptonPanel1.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel1.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel1.Controls.Add(Me.lblCantidad)
        Me.KryptonPanel1.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel1.Controls.Add(Me.txtCantidadServ)
        Me.KryptonPanel1.Controls.Add(Me.lblServicio)
        Me.KryptonPanel1.Controls.Add(Me.lblImpServGuia)
        Me.KryptonPanel1.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel1.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel1.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel1.Controls.Add(Me.chkFacturacionCliente)
        Me.KryptonPanel1.Controls.Add(Me.txtImporte)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(366, 349)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 1
        '
        'txtCorrelativoServ
        '
        Me.TypeValidator.SetEnterTAB(Me.txtCorrelativoServ, True)
        Me.txtCorrelativoServ.Location = New System.Drawing.Point(105, 125)
        Me.txtCorrelativoServ.Name = "txtCorrelativoServ"
        Me.txtCorrelativoServ.ReadOnly = True
        Me.txtCorrelativoServ.Size = New System.Drawing.Size(104, 22)
        Me.txtCorrelativoServ.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.txtCorrelativoServ.TabIndex = 7
        Me.txtCorrelativoServ.Text = "0"
        Me.txtCorrelativoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCorrelativoServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(30, 128)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(72, 20)
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
        Me.grpInfServicio.Location = New System.Drawing.Point(12, 12)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Size = New System.Drawing.Size(345, 75)
        Me.grpInfServicio.TabIndex = 1
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(18, 19)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(90, 20)
        Me.lblOperacion.TabIndex = 2
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(18, 44)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(129, 20)
        Me.lblNroGuiaRemision.TabIndex = 3
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'cmbServicio
        '
        Me.cmbServicio.Location = New System.Drawing.Point(104, 98)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.pCodigoServicio = 0
        Me.cmbServicio.pIsRequired = False
        Me.cmbServicio.Size = New System.Drawing.Size(235, 23)
        Me.cmbServicio.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(30, 230)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 20)
        Me.lblCantidad.TabIndex = 14
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(267, 317)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
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
        Me.txtCantidadServ.Location = New System.Drawing.Point(104, 227)
        Me.txtCantidadServ.Name = "txtCantidadServ"
        Me.txtCantidadServ.Size = New System.Drawing.Size(105, 22)
        Me.txtCantidadServ.TabIndex = 15
        Me.txtCantidadServ.Text = "0.000"
        Me.txtCantidadServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(30, 103)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(59, 20)
        Me.lblServicio.TabIndex = 4
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'lblImpServGuia
        '
        Me.lblImpServGuia.Location = New System.Drawing.Point(30, 205)
        Me.lblImpServGuia.Name = "lblImpServGuia"
        Me.lblImpServGuia.Size = New System.Drawing.Size(60, 20)
        Me.lblImpServGuia.TabIndex = 12
        Me.lblImpServGuia.Text = "Importe : "
        Me.lblImpServGuia.Values.ExtraText = ""
        Me.lblImpServGuia.Values.Image = Nothing
        Me.lblImpServGuia.Values.Text = "Importe : "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(171, 317)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
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
        Me.lblUnidad.Location = New System.Drawing.Point(30, 255)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidad.TabIndex = 16
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(30, 180)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(62, 20)
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
        Me.chkFacturacionCliente.Location = New System.Drawing.Point(105, 277)
        Me.chkFacturacionCliente.Name = "chkFacturacionCliente"
        Me.chkFacturacionCliente.Size = New System.Drawing.Size(127, 20)
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
        Me.txtImporte.Location = New System.Drawing.Point(104, 202)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(105, 22)
        Me.txtImporte.TabIndex = 13
        Me.txtImporte.Text = "0.0000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'frmServiciosRefactura_DlgAgregarServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 349)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServiciosRefactura_DlgAgregarServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents lblReferencia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbMoneda As Ransa.Controls.Moneda.ucMoneda_CmbF01
    Friend WithEvents txtUnidad As Ransa.Controls.Unidad.ucUnidad_TxF02
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbServicio As Ransa.Controls.ServTransp.ucServTransp_CmbF01
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
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class
