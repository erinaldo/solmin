<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionFlete_DlgAgregarServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionFlete_DlgAgregarServ))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboUnidad = New Ransa.Utilitario.ucAyuda
        Me.cboMoneda_2 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbServicio = New Ransa.Utilitario.ucAyuda
        Me.grpInfServicio = New System.Windows.Forms.GroupBox
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtImporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkFacturacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblReferencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblImpServGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidadServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(372, 356)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(372, 356)
        Me.KryptonHeaderGroup1.TabIndex = 21
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.cboUnidad)
        Me.KryptonPanel1.Controls.Add(Me.cboMoneda_2)
        Me.KryptonPanel1.Controls.Add(Me.cmbServicio)
        Me.KryptonPanel1.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel1.Controls.Add(Me.txtCorrelativoServ)
        Me.KryptonPanel1.Controls.Add(Me.txtImporte)
        Me.KryptonPanel1.Controls.Add(Me.lblCorrelativoServ)
        Me.KryptonPanel1.Controls.Add(Me.chkFacturacionCliente)
        Me.KryptonPanel1.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel1.Controls.Add(Me.txtReferencia)
        Me.KryptonPanel1.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel1.Controls.Add(Me.lblReferencia)
        Me.KryptonPanel1.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel1.Controls.Add(Me.lblImpServGuia)
        Me.KryptonPanel1.Controls.Add(Me.lblServicio)
        Me.KryptonPanel1.Controls.Add(Me.txtCantidadServ)
        Me.KryptonPanel1.Controls.Add(Me.lblCantidad)
        Me.KryptonPanel1.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(370, 354)
        Me.KryptonPanel1.TabIndex = 0
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.Transparent
        Me.cboUnidad.DataSource = Nothing
        Me.cboUnidad.DispleyMember = ""
        Me.cboUnidad.ListColumnas = Nothing
        Me.cboUnidad.Location = New System.Drawing.Point(107, 252)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Obligatorio = False
        Me.cboUnidad.Size = New System.Drawing.Size(236, 21)
        Me.cboUnidad.TabIndex = 14
        Me.cboUnidad.ValueMember = ""
        '
        'cboMoneda_2
        '
        Me.cboMoneda_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda_2.DropDownWidth = 121
        Me.cboMoneda_2.FormattingEnabled = False
        Me.cboMoneda_2.ItemHeight = 13
        Me.cboMoneda_2.Location = New System.Drawing.Point(107, 175)
        Me.cboMoneda_2.Name = "cboMoneda_2"
        Me.cboMoneda_2.Size = New System.Drawing.Size(174, 21)
        Me.cboMoneda_2.TabIndex = 8
        '
        'cmbServicio
        '
        Me.cmbServicio.BackColor = System.Drawing.Color.Transparent
        Me.cmbServicio.DataSource = Nothing
        Me.cmbServicio.DispleyMember = ""
        Me.cmbServicio.ListColumnas = Nothing
        Me.cmbServicio.Location = New System.Drawing.Point(108, 100)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Obligatorio = False
        Me.cmbServicio.Size = New System.Drawing.Size(236, 21)
        Me.cmbServicio.TabIndex = 2
        Me.cmbServicio.ValueMember = ""
        '
        'grpInfServicio
        '
        Me.grpInfServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfServicio.Controls.Add(Me.lblOperacion)
        Me.grpInfServicio.Controls.Add(Me.lblNroGuiaRemision)
        Me.grpInfServicio.Location = New System.Drawing.Point(15, 12)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Size = New System.Drawing.Size(345, 75)
        Me.grpInfServicio.TabIndex = 0
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(18, 19)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(83, 19)
        Me.lblOperacion.TabIndex = 0
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(18, 44)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(119, 19)
        Me.lblNroGuiaRemision.TabIndex = 1
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'txtCorrelativoServ
        '
        Me.TypeValidator.SetEnterTAB(Me.txtCorrelativoServ, True)
        Me.txtCorrelativoServ.Location = New System.Drawing.Point(108, 125)
        Me.txtCorrelativoServ.Name = "txtCorrelativoServ"
        Me.txtCorrelativoServ.ReadOnly = True
        Me.txtCorrelativoServ.Size = New System.Drawing.Size(104, 21)
        Me.txtCorrelativoServ.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.txtCorrelativoServ.TabIndex = 4
        Me.txtCorrelativoServ.Text = "0"
        Me.txtCorrelativoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCorrelativoServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtImporte
        '
        Me.TypeValidator.SetDecimales(Me.txtImporte, 4)
        Me.TypeValidator.SetEnterTAB(Me.txtImporte, True)
        Me.txtImporte.Location = New System.Drawing.Point(107, 202)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(105, 21)
        Me.txtImporte.TabIndex = 10
        Me.txtImporte.Text = "0.0000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(33, 128)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(67, 19)
        Me.lblCorrelativoServ.TabIndex = 3
        Me.lblCorrelativoServ.Text = "Corr. Serv. : "
        Me.lblCorrelativoServ.Values.ExtraText = ""
        Me.lblCorrelativoServ.Values.Image = Nothing
        Me.lblCorrelativoServ.Values.Text = "Corr. Serv. : "
        '
        'chkFacturacionCliente
        '
        Me.chkFacturacionCliente.Checked = False
        Me.chkFacturacionCliente.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFacturacionCliente.Location = New System.Drawing.Point(108, 277)
        Me.chkFacturacionCliente.Name = "chkFacturacionCliente"
        Me.chkFacturacionCliente.Size = New System.Drawing.Size(118, 19)
        Me.chkFacturacionCliente.TabIndex = 16
        Me.chkFacturacionCliente.Text = "Facturación Cliente"
        Me.chkFacturacionCliente.Values.ExtraText = ""
        Me.chkFacturacionCliente.Values.Image = Nothing
        Me.chkFacturacionCliente.Values.Text = "Facturación Cliente"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(33, 180)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(57, 19)
        Me.lblMoneda.TabIndex = 7
        Me.lblMoneda.Text = "Moneda :"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda :"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(107, 150)
        Me.txtReferencia.MaxLength = 35
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(235, 21)
        Me.txtReferencia.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtReferencia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(33, 255)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidad.TabIndex = 13
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(33, 153)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(68, 19)
        Me.lblReferencia.TabIndex = 5
        Me.lblReferencia.Text = "Referencia : "
        Me.lblReferencia.Values.ExtraText = ""
        Me.lblReferencia.Values.Image = Nothing
        Me.lblReferencia.Values.Text = "Referencia : "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(174, 317)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'lblImpServGuia
        '
        Me.lblImpServGuia.Location = New System.Drawing.Point(33, 205)
        Me.lblImpServGuia.Name = "lblImpServGuia"
        Me.lblImpServGuia.Size = New System.Drawing.Size(55, 19)
        Me.lblImpServGuia.TabIndex = 9
        Me.lblImpServGuia.Text = "Importe : "
        Me.lblImpServGuia.Values.ExtraText = ""
        Me.lblImpServGuia.Values.Image = Nothing
        Me.lblImpServGuia.Values.Text = "Importe : "
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(33, 103)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(54, 19)
        Me.lblServicio.TabIndex = 1
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'txtCantidadServ
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadServ, 3)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadServ, True)
        Me.txtCantidadServ.Location = New System.Drawing.Point(107, 227)
        Me.txtCantidadServ.Name = "txtCantidadServ"
        Me.txtCantidadServ.Size = New System.Drawing.Size(105, 21)
        Me.txtCantidadServ.TabIndex = 12
        Me.txtCantidadServ.Text = "0.000"
        Me.txtCantidadServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadServ, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(33, 230)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(61, 19)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(270, 317)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'frmLiquidacionFlete_DlgAgregarServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLiquidacionFlete_DlgAgregarServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
    Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmbServicio As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboMoneda_2 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboUnidad As Ransa.Utilitario.ucAyuda
End Class
