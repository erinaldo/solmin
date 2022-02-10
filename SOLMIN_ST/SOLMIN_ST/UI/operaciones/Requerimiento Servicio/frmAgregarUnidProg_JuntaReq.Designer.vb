<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUnidProg_JuntaReq
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
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmbSegundoConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.lblSegundoConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAcoplado = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
        Me.lblAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.lblTracto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.dtpFecha)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.cmbSegundoConductor)
        Me.KryptonPanel.Controls.Add(Me.cmbConductor)
        Me.KryptonPanel.Controls.Add(Me.lblSegundoConductor)
        Me.KryptonPanel.Controls.Add(Me.lblConductor)
        Me.KryptonPanel.Controls.Add(Me.txtAcoplado)
        Me.KryptonPanel.Controls.Add(Me.lblAcoplado)
        Me.KryptonPanel.Controls.Add(Me.txtTracto)
        Me.KryptonPanel.Controls.Add(Me.lblTracto)
        Me.KryptonPanel.Controls.Add(Me.txtTransportista)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(421, 290)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(142, 203)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(257, 75)
        Me.txtObservaciones.TabIndex = 204
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 227)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel2.TabIndex = 203
        Me.KryptonLabel2.Text = "Observaciones"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Observaciones"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(142, 178)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 21)
        Me.dtpFecha.TabIndex = 202
        Me.dtpFecha.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 179)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(123, 20)
        Me.KryptonLabel1.TabIndex = 201
        Me.KryptonLabel1.Text = "Fecha PreAsignación"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha PreAsignación"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnAceptar, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(421, 25)
        Me.ToolStrip1.TabIndex = 200
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmbSegundoConductor
        '
        Me.cmbSegundoConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbSegundoConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbSegundoConductor.Location = New System.Drawing.Point(142, 153)
        Me.cmbSegundoConductor.Name = "cmbSegundoConductor"
        Me.cmbSegundoConductor.pRequerido = False
        Me.cmbSegundoConductor.Size = New System.Drawing.Size(257, 22)
        Me.cmbSegundoConductor.TabIndex = 194
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(142, 126)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(257, 22)
        Me.cmbConductor.TabIndex = 193
        '
        'lblSegundoConductor
        '
        Me.lblSegundoConductor.Location = New System.Drawing.Point(12, 153)
        Me.lblSegundoConductor.Name = "lblSegundoConductor"
        Me.lblSegundoConductor.Size = New System.Drawing.Size(95, 20)
        Me.lblSegundoConductor.TabIndex = 199
        Me.lblSegundoConductor.Text = "Conductor N° 2"
        Me.lblSegundoConductor.Values.ExtraText = ""
        Me.lblSegundoConductor.Values.Image = Nothing
        Me.lblSegundoConductor.Values.Text = "Conductor N° 2"
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(12, 124)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(95, 20)
        Me.lblConductor.TabIndex = 198
        Me.lblConductor.Text = "Conductor N° 1"
        Me.lblConductor.Values.ExtraText = ""
        Me.lblConductor.Values.Image = Nothing
        Me.lblConductor.Values.Text = "Conductor N° 1"
        '
        'txtAcoplado
        '
        Me.txtAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.txtAcoplado.Location = New System.Drawing.Point(142, 100)
        Me.txtAcoplado.Name = "txtAcoplado"
        Me.txtAcoplado.pRequerido = False
        Me.txtAcoplado.Size = New System.Drawing.Size(257, 22)
        Me.txtAcoplado.TabIndex = 192
        '
        'lblAcoplado
        '
        Me.lblAcoplado.Location = New System.Drawing.Point(12, 98)
        Me.lblAcoplado.Name = "lblAcoplado"
        Me.lblAcoplado.Size = New System.Drawing.Size(62, 20)
        Me.lblAcoplado.TabIndex = 197
        Me.lblAcoplado.Text = "Acoplado"
        Me.lblAcoplado.Values.ExtraText = ""
        Me.lblAcoplado.Values.Image = Nothing
        Me.lblAcoplado.Values.Text = "Acoplado"
        '
        'txtTracto
        '
        Me.txtTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtTracto.BackColor = System.Drawing.Color.Transparent
        Me.txtTracto.Location = New System.Drawing.Point(142, 71)
        Me.txtTracto.Name = "txtTracto"
        Me.txtTracto.pRequerido = False
        Me.txtTracto.Size = New System.Drawing.Size(257, 22)
        Me.txtTracto.TabIndex = 191
        '
        'lblTracto
        '
        Me.lblTracto.Location = New System.Drawing.Point(12, 71)
        Me.lblTracto.Name = "lblTracto"
        Me.lblTracto.Size = New System.Drawing.Size(45, 20)
        Me.lblTracto.TabIndex = 196
        Me.lblTracto.Text = "Tracto"
        Me.lblTracto.Values.ExtraText = ""
        Me.lblTracto.Values.Image = Nothing
        Me.lblTracto.Values.Text = "Tracto"
        '
        'txtTransportista
        '
        Me.txtTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtTransportista.BackColor = System.Drawing.Color.Transparent
        Me.txtTransportista.Location = New System.Drawing.Point(142, 42)
        Me.txtTransportista.Name = "txtTransportista"
        Me.txtTransportista.pNroRegPorPaginas = 0
        Me.txtTransportista.pRequerido = False
        Me.txtTransportista.Size = New System.Drawing.Size(257, 22)
        Me.txtTransportista.TabIndex = 190
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 44)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(82, 20)
        Me.KryptonLabel9.TabIndex = 195
        Me.KryptonLabel9.Text = "Transportista"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Transportista"
        '
        'frmAgregarUnidProg_JuntaReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 290)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAgregarUnidProg_JuntaReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Unidades Programadas"
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
    Friend WithEvents cmbSegundoConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents lblSegundoConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAcoplado As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents lblAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents lblTracto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
