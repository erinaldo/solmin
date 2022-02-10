<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWTicketRecAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWTicketRecAlmacen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txthorafact = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txthoracalc = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txthorafinal = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txthorainicio = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtFecha = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.lblFechaIngresoItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblHoraFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblHoraInicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoServicioListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarRecepcionItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtobser = New System.Windows.Forms.TextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtobser)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.txthorafact)
        Me.KryptonPanel.Controls.Add(Me.txthoracalc)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txthorafinal)
        Me.KryptonPanel.Controls.Add(Me.txthorainicio)
        Me.KryptonPanel.Controls.Add(Me.txtFecha)
        Me.KryptonPanel.Controls.Add(Me.lblFechaIngresoItem)
        Me.KryptonPanel.Controls.Add(Me.lblHoraFinal)
        Me.KryptonPanel.Controls.Add(Me.lblHoraInicio)
        Me.KryptonPanel.Controls.Add(Me.txtTipoServicio)
        Me.KryptonPanel.Controls.Add(Me.lblTipoServicio)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarRecepcionItem)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonPanel.Size = New System.Drawing.Size(364, 173)
        Me.KryptonPanel.TabIndex = 0
        '
        'txthorafact
        '
        Me.txthorafact.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txthorafact.Location = New System.Drawing.Point(302, 60)
        Me.txthorafact.Mask = "##.##"
        Me.txthorafact.Name = "txthorafact"
        Me.txthorafact.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txthorafact.Size = New System.Drawing.Size(55, 19)
        Me.txthorafact.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txthorafact.TabIndex = 101
        Me.txthorafact.Text = "00.00"
        '
        'txthoracalc
        '
        Me.txthoracalc.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txthoracalc.Enabled = False
        Me.txthoracalc.Location = New System.Drawing.Point(302, 34)
        Me.txthoracalc.Mask = "##.##"
        Me.txthoracalc.Name = "txthoracalc"
        Me.txthoracalc.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txthoracalc.Size = New System.Drawing.Size(55, 19)
        Me.txthoracalc.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txthoracalc.TabIndex = 100
        Me.txthoracalc.Text = "  ."
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(203, 61)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(92, 16)
        Me.KryptonLabel2.TabIndex = 99
        Me.KryptonLabel2.Text = "Hora Facturada: "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hora Facturada: "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(202, 37)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(94, 16)
        Me.KryptonLabel1.TabIndex = 98
        Me.KryptonLabel1.Text = "Hora Calculada : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Hora Calculada : "
        '
        'txthorafinal
        '
        Me.txthorafinal.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txthorafinal.Location = New System.Drawing.Point(115, 61)
        Me.txthorafinal.Mask = "##:##:##"
        Me.txthorafinal.Name = "txthorafinal"
        Me.txthorafinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txthorafinal.Size = New System.Drawing.Size(55, 19)
        Me.txthorafinal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txthorafinal.TabIndex = 97
        Me.txthorafinal.Text = "  :00:00"
        '
        'txthorainicio
        '
        Me.txthorainicio.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txthorainicio.Location = New System.Drawing.Point(115, 34)
        Me.txthorainicio.Mask = "##:##:##"
        Me.txthorainicio.Name = "txthorainicio"
        Me.txthorainicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txthorainicio.Size = New System.Drawing.Size(55, 19)
        Me.txthorainicio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txthorainicio.TabIndex = 96
        Me.txthorainicio.Text = "  :00:00"
        '
        'txtFecha
        '
        Me.txtFecha.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFecha.Location = New System.Drawing.Point(113, 88)
        Me.txtFecha.Mask = "##/##/####"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFecha.Size = New System.Drawing.Size(84, 19)
        Me.txtFecha.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.TabIndex = 90
        Me.txtFecha.Text = "  /  /"
        '
        'lblFechaIngresoItem
        '
        Me.lblFechaIngresoItem.Location = New System.Drawing.Point(12, 88)
        Me.lblFechaIngresoItem.Name = "lblFechaIngresoItem"
        Me.lblFechaIngresoItem.Size = New System.Drawing.Size(76, 16)
        Me.lblFechaIngresoItem.TabIndex = 89
        Me.lblFechaIngresoItem.Text = "Fec. Ingreso:"
        Me.lblFechaIngresoItem.Values.ExtraText = ""
        Me.lblFechaIngresoItem.Values.Image = Nothing
        Me.lblFechaIngresoItem.Values.Text = "Fec. Ingreso:"
        '
        'lblHoraFinal
        '
        Me.lblHoraFinal.Location = New System.Drawing.Point(12, 60)
        Me.lblHoraFinal.Name = "lblHoraFinal"
        Me.lblHoraFinal.Size = New System.Drawing.Size(69, 16)
        Me.lblHoraFinal.TabIndex = 83
        Me.lblHoraFinal.Text = "Hora Final : "
        Me.lblHoraFinal.Values.ExtraText = ""
        Me.lblHoraFinal.Values.Image = Nothing
        Me.lblHoraFinal.Values.Text = "Hora Final : "
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(12, 35)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(70, 16)
        Me.lblHoraInicio.TabIndex = 82
        Me.lblHoraInicio.Text = "Hora Inicio : "
        Me.lblHoraInicio.Values.ExtraText = ""
        Me.lblHoraInicio.Values.Image = Nothing
        Me.lblHoraInicio.Values.Text = "Hora Inicio : "
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoServicioListar})
        Me.txtTipoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoServicio.Location = New System.Drawing.Point(115, 9)
        Me.txtTipoServicio.MaxLength = 50
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.Size = New System.Drawing.Size(242, 19)
        Me.txtTipoServicio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoServicio.TabIndex = 81
        '
        'bsaTipoServicioListar
        '
        Me.bsaTipoServicioListar.ExtraText = ""
        Me.bsaTipoServicioListar.Image = Nothing
        Me.bsaTipoServicioListar.Text = ""
        Me.bsaTipoServicioListar.ToolTipImage = Nothing
        Me.bsaTipoServicioListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoServicioListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblTipoServicio
        '
        Me.lblTipoServicio.Location = New System.Drawing.Point(12, 12)
        Me.lblTipoServicio.Name = "lblTipoServicio"
        Me.lblTipoServicio.Size = New System.Drawing.Size(97, 16)
        Me.lblTipoServicio.TabIndex = 80
        Me.lblTipoServicio.Text = "Tipo de Servicio : "
        Me.lblTipoServicio.Values.ExtraText = ""
        Me.lblTipoServicio.Values.Image = Nothing
        Me.lblTipoServicio.Values.Text = "Tipo de Servicio : "
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(272, 141)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 79
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAgregarRecepcionItem
        '
        Me.btnAgregarRecepcionItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarRecepcionItem.Location = New System.Drawing.Point(186, 141)
        Me.btnAgregarRecepcionItem.Name = "btnAgregarRecepcionItem"
        Me.btnAgregarRecepcionItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarRecepcionItem.TabIndex = 78
        Me.btnAgregarRecepcionItem.Text = "Agregar"
        Me.btnAgregarRecepcionItem.Values.ExtraText = ""
        Me.btnAgregarRecepcionItem.Values.Image = CType(resources.GetObject("btnAgregarRecepcionItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarRecepcionItem.Values.Text = "Agregar"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 115)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(80, 16)
        Me.KryptonLabel3.TabIndex = 102
        Me.KryptonLabel3.Text = "Observ . Ref :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Observ . Ref :"
        '
        'txtobser
        '
        Me.txtobser.BackColor = System.Drawing.Color.PeachPuff
        Me.txtobser.Location = New System.Drawing.Point(113, 115)
        Me.txtobser.MaxLength = 20
        Me.txtobser.Name = "txtobser"
        Me.txtobser.Size = New System.Drawing.Size(244, 20)
        Me.txtobser.TabIndex = 103
        '
        'frmTicketRecAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 173)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTicketRecAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarRecepcionItem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblHoraFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblHoraInicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoServicioListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFecha As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblFechaIngresoItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txthorainicio As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txthorafinal As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txthorafact As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txthoracalc As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtobser As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
