<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionFlete_DlgAgregarLiqServ
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
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.grpInfLiqServicio = New System.Windows.Forms.GroupBox
        Me.chkLiquTransporte = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbMoneda_1 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteLiq = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadLiq = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboUnidadLiq = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCorrelativoServ = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfLiqServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.grpInfLiqServicio)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.lblOperacion)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaRemision)
        Me.KryptonPanel.Controls.Add(Me.txtCorrelativoServ)
        Me.KryptonPanel.Controls.Add(Me.lblServicio)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(446, 344)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(317, 304)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 38
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
        Me.btnAceptar.Location = New System.Drawing.Point(221, 304)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 37
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'grpInfLiqServicio
        '
        Me.grpInfLiqServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfLiqServicio.Controls.Add(Me.chkLiquTransporte)
        Me.grpInfLiqServicio.Controls.Add(Me.KryptonLabel4)
        Me.grpInfLiqServicio.Controls.Add(Me.cmbMoneda_1)
        Me.grpInfLiqServicio.Controls.Add(Me.cboTransportista)
        Me.grpInfLiqServicio.Controls.Add(Me.KryptonLabel5)
        Me.grpInfLiqServicio.Controls.Add(Me.KryptonLabel1)
        Me.grpInfLiqServicio.Controls.Add(Me.txtImporteLiq)
        Me.grpInfLiqServicio.Controls.Add(Me.txtCantidadLiq)
        Me.grpInfLiqServicio.Controls.Add(Me.KryptonLabel6)
        Me.grpInfLiqServicio.Controls.Add(Me.cboUnidadLiq)
        Me.grpInfLiqServicio.Controls.Add(Me.KryptonLabel7)
        Me.grpInfLiqServicio.Location = New System.Drawing.Point(12, 100)
        Me.grpInfLiqServicio.Name = "grpInfLiqServicio"
        Me.grpInfLiqServicio.Size = New System.Drawing.Size(415, 198)
        Me.grpInfLiqServicio.TabIndex = 36
        Me.grpInfLiqServicio.TabStop = False
        Me.grpInfLiqServicio.Text = "Liquidación Servicio"
        '
        'chkLiquTransporte
        '
        Me.chkLiquTransporte.Checked = False
        Me.chkLiquTransporte.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkLiquTransporte.Location = New System.Drawing.Point(15, 19)
        Me.chkLiquTransporte.Name = "chkLiquTransporte"
        Me.chkLiquTransporte.Size = New System.Drawing.Size(148, 22)
        Me.chkLiquTransporte.TabIndex = 37
        Me.chkLiquTransporte.Text = "Liquidación Transporte"
        Me.chkLiquTransporte.Values.ExtraText = ""
        Me.chkLiquTransporte.Values.Image = Nothing
        Me.chkLiquTransporte.Values.Text = "Liquidación Transporte"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 75)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(62, 22)
        Me.KryptonLabel4.TabIndex = 21
        Me.KryptonLabel4.Text = "Moneda :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Moneda :"
        '
        'cmbMoneda_1
        '
        Me.cmbMoneda_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda_1.DropDownWidth = 121
        Me.cmbMoneda_1.FormattingEnabled = False
        Me.cmbMoneda_1.ItemHeight = 15
        Me.cmbMoneda_1.Location = New System.Drawing.Point(126, 75)
        Me.cmbMoneda_1.Name = "cmbMoneda_1"
        Me.cmbMoneda_1.Size = New System.Drawing.Size(174, 23)
        Me.cmbMoneda_1.TabIndex = 22
        '
        'cboTransportista
        '
        Me.cboTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTransportista.BackColor = System.Drawing.Color.Transparent
        Me.cboTransportista.Location = New System.Drawing.Point(126, 49)
        Me.cboTransportista.Name = "cboTransportista"
        Me.cboTransportista.pNroRegPorPaginas = 0
        Me.cboTransportista.pRequerido = False
        Me.cboTransportista.Size = New System.Drawing.Size(267, 22)
        Me.cboTransportista.TabIndex = 30
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(17, 103)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(60, 22)
        Me.KryptonLabel5.TabIndex = 23
        Me.KryptonLabel5.Text = "Importe : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Importe : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 49)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(73, 22)
        Me.KryptonLabel1.TabIndex = 29
        Me.KryptonLabel1.Text = "Proveedor : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Proveedor : "
        '
        'txtImporteLiq
        '
        Me.txtImporteLiq.Location = New System.Drawing.Point(126, 105)
        Me.txtImporteLiq.Name = "txtImporteLiq"
        Me.txtImporteLiq.Size = New System.Drawing.Size(105, 22)
        Me.txtImporteLiq.TabIndex = 24
        Me.txtImporteLiq.Text = "0.0000"
        Me.txtImporteLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadLiq
        '
        Me.txtCantidadLiq.Location = New System.Drawing.Point(126, 132)
        Me.txtCantidadLiq.Name = "txtCantidadLiq"
        Me.txtCantidadLiq.Size = New System.Drawing.Size(105, 22)
        Me.txtCantidadLiq.TabIndex = 26
        Me.txtCantidadLiq.Text = "0.000"
        Me.txtCantidadLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(17, 131)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(66, 22)
        Me.KryptonLabel6.TabIndex = 25
        Me.KryptonLabel6.Text = "Cantidad : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cantidad : "
        '
        'cboUnidadLiq
        '
        Me.cboUnidadLiq.BackColor = System.Drawing.Color.Transparent
        Me.cboUnidadLiq.DataSource = Nothing
        Me.cboUnidadLiq.DispleyMember = ""
        Me.cboUnidadLiq.Etiquetas_Form = Nothing
        Me.cboUnidadLiq.ListColumnas = Nothing
        Me.cboUnidadLiq.Location = New System.Drawing.Point(126, 159)
        Me.cboUnidadLiq.Name = "cboUnidadLiq"
        Me.cboUnidadLiq.Obligatorio = False
        Me.cboUnidadLiq.PopupHeight = 0
        Me.cboUnidadLiq.PopupWidth = 0
        Me.cboUnidadLiq.Size = New System.Drawing.Size(236, 21)
        Me.cboUnidadLiq.TabIndex = 28
        Me.cboUnidadLiq.ValueMember = ""
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(17, 156)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 22)
        Me.KryptonLabel7.TabIndex = 27
        Me.KryptonLabel7.Text = "Unidad : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Unidad : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(253, 62)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(72, 22)
        Me.KryptonLabel2.TabIndex = 33
        Me.KryptonLabel2.Text = "Corr. Serv. : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Corr. Serv. : "
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(12, 12)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(90, 22)
        Me.lblOperacion.TabIndex = 2
        Me.lblOperacion.Text = "N° Operación : "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación : "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(12, 36)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(129, 22)
        Me.lblNroGuiaRemision.TabIndex = 3
        Me.lblNroGuiaRemision.Text = "N° Guía de Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "N° Guía de Remisión : "
        '
        'txtCorrelativoServ
        '
        Me.txtCorrelativoServ.Location = New System.Drawing.Point(331, 60)
        Me.txtCorrelativoServ.Name = "txtCorrelativoServ"
        Me.txtCorrelativoServ.ReadOnly = True
        Me.txtCorrelativoServ.Size = New System.Drawing.Size(74, 22)
        Me.txtCorrelativoServ.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.txtCorrelativoServ.TabIndex = 18
        Me.txtCorrelativoServ.Text = "0"
        Me.txtCorrelativoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(12, 62)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(59, 22)
        Me.lblServicio.TabIndex = 15
        Me.lblServicio.Text = "Servicio : "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio : "
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmLiquidacionFlete_DlgAgregarLiqServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 344)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmLiquidacionFlete_DlgAgregarLiqServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpInfLiqServicio.ResumeLayout(False)
        Me.grpInfLiqServicio.PerformLayout()
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
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCorrelativoServ As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfLiqServicio As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbMoneda_1 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporteLiq As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadLiq As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboUnidadLiq As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkLiquTransporte As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
