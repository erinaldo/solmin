<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionFlete_DlgLiquServicio
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
        Me.cboMoneda_2 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboUnidad = New Ransa.Utilitario.ucAyuda
        Me.grpInfServicio = New System.Windows.Forms.GroupBox
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtTarifa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkLiquTransporte = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTarifa = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMoneda_2
        '
        Me.cboMoneda_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda_2.DropDownWidth = 121
        Me.cboMoneda_2.FormattingEnabled = False
        Me.cboMoneda_2.ItemHeight = 15
        Me.cboMoneda_2.Location = New System.Drawing.Point(93, 149)
        Me.cboMoneda_2.Name = "cboMoneda_2"
        Me.cboMoneda_2.Size = New System.Drawing.Size(174, 23)
        Me.cboMoneda_2.TabIndex = 2
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboMoneda_2)
        Me.KryptonPanel.Controls.Add(Me.cboUnidad)
        Me.KryptonPanel.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.txtTarifa)
        Me.KryptonPanel.Controls.Add(Me.chkLiquTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblTarifa)
        Me.KryptonPanel.Controls.Add(Me.txtImporte)
        Me.KryptonPanel.Controls.Add(Me.lblImporte)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(312, 325)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 1
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.Transparent
        Me.cboUnidad.DataSource = Nothing
        Me.cboUnidad.DispleyMember = ""
        Me.cboUnidad.ListColumnas = Nothing
        Me.cboUnidad.Location = New System.Drawing.Point(93, 222)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Obligatorio = False
        Me.cboUnidad.PopupHeight = 0
        Me.cboUnidad.PopupWidth = 0
        Me.cboUnidad.Size = New System.Drawing.Size(194, 26)
        Me.cboUnidad.TabIndex = 8
        Me.cboUnidad.ValueMember = ""
        '
        'grpInfServicio
        '
        Me.grpInfServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfServicio.Controls.Add(Me.lblOperacion)
        Me.grpInfServicio.Controls.Add(Me.lblCorrelativoServ)
        Me.grpInfServicio.Controls.Add(Me.lblNroGuiaRemision)
        Me.grpInfServicio.Controls.Add(Me.lblServicio)
        Me.grpInfServicio.Location = New System.Drawing.Point(12, 12)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Size = New System.Drawing.Size(287, 120)
        Me.grpInfServicio.TabIndex = 0
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(18, 19)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(90, 20)
        Me.lblOperacion.TabIndex = 0
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(18, 94)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(76, 20)
        Me.lblCorrelativoServ.TabIndex = 3
        Me.lblCorrelativoServ.Text = "Correlativo : "
        Me.lblCorrelativoServ.Values.ExtraText = ""
        Me.lblCorrelativoServ.Values.Image = Nothing
        Me.lblCorrelativoServ.Values.Text = "Correlativo : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(18, 44)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(129, 20)
        Me.lblNroGuiaRemision.TabIndex = 1
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(18, 69)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(59, 20)
        Me.lblServicio.TabIndex = 2
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(209, 282)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(113, 282)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'txtTarifa
        '
        Me.TypeValidator.SetDecimales(Me.txtTarifa, 4)
        Me.TypeValidator.SetEnterTAB(Me.txtTarifa, True)
        Me.txtTarifa.Location = New System.Drawing.Point(93, 173)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(105, 22)
        Me.txtTarifa.TabIndex = 4
        Me.txtTarifa.Text = "0.0000"
        Me.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtTarifa, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'chkLiquTransporte
        '
        Me.chkLiquTransporte.Checked = False
        Me.chkLiquTransporte.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkLiquTransporte.Location = New System.Drawing.Point(93, 248)
        Me.chkLiquTransporte.Name = "chkLiquTransporte"
        Me.chkLiquTransporte.Size = New System.Drawing.Size(148, 20)
        Me.chkLiquTransporte.TabIndex = 9
        Me.chkLiquTransporte.Text = "Liquidación Transporte"
        Me.chkLiquTransporte.Values.ExtraText = ""
        Me.chkLiquTransporte.Values.Image = Nothing
        Me.chkLiquTransporte.Values.Text = "Liquidación Transporte"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(30, 151)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(62, 20)
        Me.lblMoneda.TabIndex = 1
        Me.lblMoneda.Text = "Moneda :"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda :"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(30, 226)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidad.TabIndex = 7
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblTarifa
        '
        Me.lblTarifa.Location = New System.Drawing.Point(30, 176)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(47, 20)
        Me.lblTarifa.TabIndex = 3
        Me.lblTarifa.Text = "Tarifa : "
        Me.lblTarifa.Values.ExtraText = ""
        Me.lblTarifa.Values.Image = Nothing
        Me.lblTarifa.Values.Text = "Tarifa : "
        '
        'txtImporte
        '
        Me.TypeValidator.SetDecimales(Me.txtImporte, 3)
        Me.TypeValidator.SetEnterTAB(Me.txtImporte, True)
        Me.txtImporte.Location = New System.Drawing.Point(93, 198)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(105, 22)
        Me.txtImporte.TabIndex = 6
        Me.txtImporte.Text = "0.000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(30, 201)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(66, 20)
        Me.lblImporte.TabIndex = 5
        Me.lblImporte.Text = "Cantidad : "
        Me.lblImporte.Values.ExtraText = ""
        Me.lblImporte.Values.Image = Nothing
        Me.lblImporte.Values.Text = "Cantidad : "
        '
        'frmLiquidacionFlete_DlgLiquServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLiquidacionFlete_DlgLiquServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidación Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpInfServicio.ResumeLayout(False)
        Me.grpInfServicio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents cboMoneda_2 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cboUnidad As Ransa.Utilitario.ucAyuda
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtTarifa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents chkLiquTransporte As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTarifa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblImporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class
