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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.cboMoneda_2_tmp = New System.Windows.Forms.ComboBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.cboMoneda_2 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboUnidad = New Ransa.Utilitario.ucAyuda()
        Me.grpInfServicio = New System.Windows.Forms.GroupBox()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkLiquTransporte = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTarifa = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblImporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.lblmensaje = New System.Windows.Forms.Label()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.lblmensaje)
        Me.KryptonPanel.Controls.Add(Me.cboMoneda_2_tmp)
        Me.KryptonPanel.Controls.Add(Me.txtImporte)
        Me.KryptonPanel.Controls.Add(Me.txtTarifa)
        Me.KryptonPanel.Controls.Add(Me.cboMoneda_2)
        Me.KryptonPanel.Controls.Add(Me.cboUnidad)
        Me.KryptonPanel.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.chkLiquTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblTarifa)
        Me.KryptonPanel.Controls.Add(Me.lblImporte)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(447, 435)
        Me.KryptonPanel.TabIndex = 0
        '
        'cboMoneda_2_tmp
        '
        Me.cboMoneda_2_tmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMoneda_2_tmp.BackColor = System.Drawing.SystemColors.Menu
        Me.cboMoneda_2_tmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda_2_tmp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMoneda_2_tmp.Location = New System.Drawing.Point(124, 183)
        Me.cboMoneda_2_tmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMoneda_2_tmp.MaxDropDownItems = 100
        Me.cboMoneda_2_tmp.Name = "cboMoneda_2_tmp"
        Me.cboMoneda_2_tmp.Size = New System.Drawing.Size(231, 24)
        Me.cboMoneda_2_tmp.TabIndex = 41
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(124, 247)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImporte.MaxLength = 12
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(132, 22)
        Me.txtImporte.TabIndex = 40
        Me.txtImporte.Text = "0.000"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTarifa
        '
        Me.txtTarifa.Location = New System.Drawing.Point(124, 217)
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTarifa.MaxLength = 16
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(132, 22)
        Me.txtTarifa.TabIndex = 39
        Me.txtTarifa.Text = "0.0000"
        Me.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboMoneda_2
        '
        Me.cboMoneda_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMoneda_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda_2.DropDownWidth = 121
        Me.cboMoneda_2.FormattingEnabled = False
        Me.cboMoneda_2.ItemHeight = 20
        Me.cboMoneda_2.Location = New System.Drawing.Point(124, 183)
        Me.cboMoneda_2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMoneda_2.Name = "cboMoneda_2"
        Me.cboMoneda_2.Size = New System.Drawing.Size(232, 28)
        Me.cboMoneda_2.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.cboMoneda_2.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.cboMoneda_2.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda_2.TabIndex = 2
        Me.cboMoneda_2.Visible = False
        '
        'cboUnidad
        '
        Me.cboUnidad.BackColor = System.Drawing.Color.Transparent
        Me.cboUnidad.DataSource = Nothing
        Me.cboUnidad.DispleyMember = ""
        Me.cboUnidad.Etiquetas_Form = Nothing
        Me.cboUnidad.ListColumnas = Nothing
        Me.cboUnidad.Location = New System.Drawing.Point(124, 273)
        Me.cboUnidad.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Obligatorio = False
        Me.cboUnidad.PopupHeight = 0
        Me.cboUnidad.PopupWidth = 0
        Me.cboUnidad.Size = New System.Drawing.Size(259, 26)
        Me.cboUnidad.SizeFont = 0
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
        Me.grpInfServicio.Location = New System.Drawing.Point(16, 15)
        Me.grpInfServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInfServicio.Size = New System.Drawing.Size(383, 148)
        Me.grpInfServicio.TabIndex = 0
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Información Servicio"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(24, 23)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(111, 26)
        Me.lblOperacion.TabIndex = 0
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblCorrelativoServ
        '
        Me.lblCorrelativoServ.Location = New System.Drawing.Point(24, 116)
        Me.lblCorrelativoServ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCorrelativoServ.Name = "lblCorrelativoServ"
        Me.lblCorrelativoServ.Size = New System.Drawing.Size(94, 26)
        Me.lblCorrelativoServ.TabIndex = 3
        Me.lblCorrelativoServ.Text = "Correlativo : "
        Me.lblCorrelativoServ.Values.ExtraText = ""
        Me.lblCorrelativoServ.Values.Image = Nothing
        Me.lblCorrelativoServ.Values.Text = "Correlativo : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(24, 54)
        Me.lblNroGuiaRemision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(160, 26)
        Me.lblNroGuiaRemision.TabIndex = 1
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(24, 85)
        Me.lblServicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(72, 26)
        Me.lblServicio.TabIndex = 2
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(279, 361)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 31)
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
        Me.btnAceptar.Location = New System.Drawing.Point(151, 361)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 31)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'chkLiquTransporte
        '
        Me.chkLiquTransporte.Checked = False
        Me.chkLiquTransporte.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkLiquTransporte.Location = New System.Drawing.Point(124, 305)
        Me.chkLiquTransporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkLiquTransporte.Name = "chkLiquTransporte"
        Me.chkLiquTransporte.Size = New System.Drawing.Size(183, 26)
        Me.chkLiquTransporte.TabIndex = 9
        Me.chkLiquTransporte.Text = "Liquidación Transporte"
        Me.chkLiquTransporte.Values.ExtraText = ""
        Me.chkLiquTransporte.Values.Image = Nothing
        Me.chkLiquTransporte.Values.Text = "Liquidación Transporte"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(40, 186)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(76, 26)
        Me.lblMoneda.TabIndex = 1
        Me.lblMoneda.Text = "Moneda :"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda :"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(40, 278)
        Me.lblUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(68, 26)
        Me.lblUnidad.TabIndex = 7
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'lblTarifa
        '
        Me.lblTarifa.Location = New System.Drawing.Point(40, 217)
        Me.lblTarifa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(57, 26)
        Me.lblTarifa.TabIndex = 3
        Me.lblTarifa.Text = "Tarifa : "
        Me.lblTarifa.Values.ExtraText = ""
        Me.lblTarifa.Values.Image = Nothing
        Me.lblTarifa.Values.Text = "Tarifa : "
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(40, 247)
        Me.lblImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(80, 26)
        Me.lblImporte.TabIndex = 5
        Me.lblImporte.Text = "Cantidad : "
        Me.lblImporte.Values.ExtraText = ""
        Me.lblImporte.Values.Image = Nothing
        Me.lblImporte.Values.Text = "Cantidad : "
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmensaje.ForeColor = System.Drawing.Color.Red
        Me.lblmensaje.Location = New System.Drawing.Point(121, 335)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(86, 17)
        Me.lblmensaje.TabIndex = 42
        Me.lblmensaje.Text = "Autorización"
        '
        'frmLiquidacionFlete_DlgLiquServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLiquidacionFlete_DlgLiquServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.Red
        Me.Text = "Liquidación Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpInfServicio.ResumeLayout(False)
        Me.grpInfServicio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkLiquTransporte As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblImporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTarifa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboUnidad As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboMoneda_2 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda_2_tmp As System.Windows.Forms.ComboBox
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
End Class
