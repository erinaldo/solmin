<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsigRecursoGT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.CboDestino = New Ransa.Utilitario.ucAyuda
        Me.CboOrigen = New Ransa.Utilitario.ucAyuda
        Me.CboMedio = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.cboSegundoConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
        Me.cboPrimerConductor = New Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
        Me.cboAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.CboMotivo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiltros.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.CboDestino)
        Me.PanelFiltros.Panel.Controls.Add(Me.CboOrigen)
        Me.PanelFiltros.Panel.Controls.Add(Me.CboMedio)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboTracto)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboSegundoConductor)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboPrimerConductor)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboAcoplado)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel8)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.CboMotivo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.DateTimePicker1)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtObservacion)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel22)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel24)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel19)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Size = New System.Drawing.Size(712, 315)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Description = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Heading = "Datos Generales"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Asignación de Recursos"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "4ABB2086ACE547644ABB2086ACE54764"
        '
        'CboDestino
        '
        Me.CboDestino.BackColor = System.Drawing.Color.Transparent
        Me.CboDestino.DataSource = Nothing
        Me.CboDestino.DispleyMember = ""
        Me.CboDestino.Etiquetas_Form = Nothing
        Me.CboDestino.ListColumnas = Nothing
        Me.CboDestino.Location = New System.Drawing.Point(455, 128)
        Me.CboDestino.Name = "CboDestino"
        Me.CboDestino.Obligatorio = False
        Me.CboDestino.PopupHeight = 0
        Me.CboDestino.PopupWidth = 0
        Me.CboDestino.Size = New System.Drawing.Size(244, 31)
        Me.CboDestino.SizeFont = 0
        Me.CboDestino.TabIndex = 22
        Me.CboDestino.ValueMember = ""
        '
        'CboOrigen
        '
        Me.CboOrigen.BackColor = System.Drawing.Color.Transparent
        Me.CboOrigen.DataSource = Nothing
        Me.CboOrigen.DispleyMember = ""
        Me.CboOrigen.Etiquetas_Form = Nothing
        Me.CboOrigen.ListColumnas = Nothing
        Me.CboOrigen.Location = New System.Drawing.Point(115, 128)
        Me.CboOrigen.Name = "CboOrigen"
        Me.CboOrigen.Obligatorio = False
        Me.CboOrigen.PopupHeight = 0
        Me.CboOrigen.PopupWidth = 0
        Me.CboOrigen.Size = New System.Drawing.Size(240, 31)
        Me.CboOrigen.SizeFont = 0
        Me.CboOrigen.TabIndex = 21
        Me.CboOrigen.ValueMember = ""
        '
        'CboMedio
        '
        Me.CboMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMedio.DropDownWidth = 191
        Me.CboMedio.FormattingEnabled = False
        Me.CboMedio.ItemHeight = 15
        Me.CboMedio.Location = New System.Drawing.Point(508, 31)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(191, 23)
        Me.CboMedio.TabIndex = 6
        '
        'cboTracto
        '
        Me.cboTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboTracto.BackColor = System.Drawing.Color.Transparent
        Me.cboTracto.Location = New System.Drawing.Point(115, 62)
        Me.cboTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.pRequerido = False
        Me.cboTracto.Size = New System.Drawing.Size(240, 22)
        Me.cboTracto.TabIndex = 8
        '
        'cboSegundoConductor
        '
        Me.cboSegundoConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboSegundoConductor.BackColor = System.Drawing.Color.Transparent
        Me.cboSegundoConductor.Location = New System.Drawing.Point(455, 95)
        Me.cboSegundoConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSegundoConductor.Name = "cboSegundoConductor"
        Me.cboSegundoConductor.pRequerido = False
        Me.cboSegundoConductor.Size = New System.Drawing.Size(244, 22)
        Me.cboSegundoConductor.TabIndex = 14
        '
        'cboPrimerConductor
        '
        Me.cboPrimerConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboPrimerConductor.BackColor = System.Drawing.Color.Transparent
        Me.cboPrimerConductor.Location = New System.Drawing.Point(115, 95)
        Me.cboPrimerConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPrimerConductor.Name = "cboPrimerConductor"
        Me.cboPrimerConductor.pRequerido = False
        Me.cboPrimerConductor.Size = New System.Drawing.Size(240, 22)
        Me.cboPrimerConductor.TabIndex = 12
        '
        'cboAcoplado
        '
        Me.cboAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.cboAcoplado.Location = New System.Drawing.Point(455, 62)
        Me.cboAcoplado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAcoplado.Name = "cboAcoplado"
        Me.cboAcoplado.pRequerido = False
        Me.cboAcoplado.Size = New System.Drawing.Size(244, 22)
        Me.cboAcoplado.TabIndex = 10
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(393, 128)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(52, 22)
        Me.KryptonLabel8.TabIndex = 17
        Me.KryptonLabel8.Text = "Destino"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Destino"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(367, 95)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel6.TabIndex = 13
        Me.KryptonLabel6.Text = "Conductor 2"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Conductor 2"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(383, 62)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(62, 22)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Text = "Acoplado"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Acoplado"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(465, 31)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(46, 22)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Medio"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Medio"
        '
        'CboMotivo
        '
        Me.CboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMotivo.DropDownWidth = 145
        Me.CboMotivo.FormattingEnabled = False
        Me.CboMotivo.ItemHeight = 15
        Me.CboMotivo.Location = New System.Drawing.Point(287, 30)
        Me.CboMotivo.Name = "CboMotivo"
        Me.CboMotivo.Size = New System.Drawing.Size(172, 23)
        Me.CboMotivo.TabIndex = 4
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(232, 33)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 22)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Motivo"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Motivo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 181)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel1.TabIndex = 19
        Me.KryptonLabel1.Text = "Observación"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(115, 165)
        Me.txtObservacion.MaxLength = 100
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.txtObservacion.Size = New System.Drawing.Size(584, 100)
        Me.txtObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtObservacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.TabIndex = 20
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(10, 62)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(45, 22)
        Me.KryptonLabel22.TabIndex = 7
        Me.KryptonLabel22.Text = "Tracto"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Tracto"
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(11, 128)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(48, 22)
        Me.KryptonLabel24.TabIndex = 15
        Me.KryptonLabel24.Text = "Origen"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Origen"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(10, 33)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(75, 22)
        Me.KryptonLabel19.TabIndex = 1
        Me.KryptonLabel19.Text = "Fecha Inicio"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Fecha Inicio"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 6)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(129, 20)
        Me.KryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Text = "Información General "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Información General "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(10, 95)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel7.TabIndex = 11
        Me.KryptonLabel7.Text = "Conductor 1"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Conductor 1"
        '
        'frmAsigRecursoGT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelFiltros)
        Me.Name = "frmAsigRecursoGT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación"
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CboMotivo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents cboPrimerConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents cboSegundoConductor As Ransa.Controls.Transportista.ucConductorTransportista_TxtF01
    Friend WithEvents cboTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents CboMedio As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents CboDestino As Ransa.Utilitario.ucAyuda
    Friend WithEvents CboOrigen As Ransa.Utilitario.ucAyuda
End Class
