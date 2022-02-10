<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarOrdenServicio
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
        Me.txtOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAsignarOSAgencias = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtOSAgencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnBuscaOrdenServicio = New System.Windows.Forms.Button
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidadSolicitada = New System.Windows.Forms.TextBox
        Me.txtNroReq = New System.Windows.Forms.TextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpInfServicio = New System.Windows.Forms.GroupBox
        Me.txtLocalidadDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLocalidadOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUbigeoDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUbigeoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfServicio.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtOS)
        Me.KryptonPanel.Controls.Add(Me.btnAsignarOSAgencias)
        Me.KryptonPanel.Controls.Add(Me.txtOSAgencia)
        Me.KryptonPanel.Controls.Add(Me.btnBuscaOrdenServicio)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel30)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel33)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadSolicitada)
        Me.KryptonPanel.Controls.Add(Me.txtNroReq)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.grpInfServicio)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(753, 201)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtOS
        '
        Me.txtOS.Enabled = False
        Me.txtOS.Location = New System.Drawing.Point(122, 64)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(94, 22)
        Me.txtOS.TabIndex = 35
        Me.txtOS.Text = " "
        '
        'btnAsignarOSAgencias
        '
        Me.btnAsignarOSAgencias.Location = New System.Drawing.Point(657, 63)
        Me.btnAsignarOSAgencias.Name = "btnAsignarOSAgencias"
        Me.btnAsignarOSAgencias.Size = New System.Drawing.Size(29, 24)
        Me.btnAsignarOSAgencias.StateCommon.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnAsignarOSAgencias.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnAsignarOSAgencias.TabIndex = 39
        Me.btnAsignarOSAgencias.Values.ExtraText = ""
        Me.btnAsignarOSAgencias.Values.Image = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAsignarOSAgencias.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAsignarOSAgencias.Values.Text = ""
        '
        'txtOSAgencia
        '
        Me.txtOSAgencia.Enabled = False
        Me.txtOSAgencia.Location = New System.Drawing.Point(555, 64)
        Me.txtOSAgencia.Name = "txtOSAgencia"
        Me.txtOSAgencia.ReadOnly = True
        Me.txtOSAgencia.Size = New System.Drawing.Size(102, 22)
        Me.txtOSAgencia.TabIndex = 38
        '
        'btnBuscaOrdenServicio
        '
        Me.btnBuscaOrdenServicio.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscaOrdenServicio.Location = New System.Drawing.Point(215, 63)
        Me.btnBuscaOrdenServicio.Name = "btnBuscaOrdenServicio"
        Me.btnBuscaOrdenServicio.Size = New System.Drawing.Size(37, 24)
        Me.btnBuscaOrdenServicio.TabIndex = 36
        Me.btnBuscaOrdenServicio.UseVisualStyleBackColor = True
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(433, 66)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(122, 20)
        Me.KryptonLabel30.TabIndex = 37
        Me.KryptonLabel30.Text = "O/S Agencias Ransa:"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "O/S Agencias Ransa:"
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(82, 64)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Size = New System.Drawing.Size(31, 20)
        Me.KryptonLabel33.TabIndex = 34
        Me.KryptonLabel33.Text = "O/S"
        Me.KryptonLabel33.Values.ExtraText = ""
        Me.KryptonLabel33.Values.Image = Nothing
        Me.KryptonLabel33.Values.Text = "O/S"
        '
        'txtCantidadSolicitada
        '
        Me.txtCantidadSolicitada.Location = New System.Drawing.Point(555, 40)
        Me.txtCantidadSolicitada.MaxLength = 6
        Me.txtCantidadSolicitada.Name = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.Size = New System.Drawing.Size(106, 20)
        Me.txtCantidadSolicitada.TabIndex = 30
        Me.txtCantidadSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroReq
        '
        Me.txtNroReq.Enabled = False
        Me.txtNroReq.Location = New System.Drawing.Point(122, 40)
        Me.txtNroReq.MaxLength = 6
        Me.txtNroReq.Name = "txtNroReq"
        Me.txtNroReq.Size = New System.Drawing.Size(69, 20)
        Me.txtNroReq.TabIndex = 29
        Me.txtNroReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(458, 40)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(94, 20)
        Me.KryptonLabel2.TabIndex = 27
        Me.KryptonLabel2.Text = "Cant. Vehículos"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cant. Vehículos"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 36)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(108, 20)
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Text = "N° Requerimiento "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "N° Requerimiento "
        '
        'grpInfServicio
        '
        Me.grpInfServicio.BackColor = System.Drawing.Color.Transparent
        Me.grpInfServicio.Controls.Add(Me.txtLocalidadDestino)
        Me.grpInfServicio.Controls.Add(Me.txtLocalidadOrigen)
        Me.grpInfServicio.Controls.Add(Me.txtUbigeoDestino)
        Me.grpInfServicio.Controls.Add(Me.txtUbigeoOrigen)
        Me.grpInfServicio.Controls.Add(Me.KryptonLabel4)
        Me.grpInfServicio.Controls.Add(Me.KryptonLabel3)
        Me.grpInfServicio.Controls.Add(Me.lblOperacion)
        Me.grpInfServicio.Controls.Add(Me.lblNroGuiaRemision)
        Me.grpInfServicio.Location = New System.Drawing.Point(12, 93)
        Me.grpInfServicio.Name = "grpInfServicio"
        Me.grpInfServicio.Size = New System.Drawing.Size(729, 86)
        Me.grpInfServicio.TabIndex = 19
        Me.grpInfServicio.TabStop = False
        Me.grpInfServicio.Text = "Datos O/S"
        '
        'txtLocalidadDestino
        '
        Me.txtLocalidadDestino.Enabled = False
        Me.txtLocalidadDestino.Location = New System.Drawing.Point(543, 44)
        Me.txtLocalidadDestino.MaxLength = 100
        Me.txtLocalidadDestino.Name = "txtLocalidadDestino"
        Me.txtLocalidadDestino.Size = New System.Drawing.Size(175, 22)
        Me.txtLocalidadDestino.TabIndex = 32
        '
        'txtLocalidadOrigen
        '
        Me.txtLocalidadOrigen.Enabled = False
        Me.txtLocalidadOrigen.Location = New System.Drawing.Point(543, 19)
        Me.txtLocalidadOrigen.MaxLength = 100
        Me.txtLocalidadOrigen.Name = "txtLocalidadOrigen"
        Me.txtLocalidadOrigen.Size = New System.Drawing.Size(175, 22)
        Me.txtLocalidadOrigen.TabIndex = 31
        '
        'txtUbigeoDestino
        '
        Me.txtUbigeoDestino.Enabled = False
        Me.txtUbigeoDestino.Location = New System.Drawing.Point(110, 45)
        Me.txtUbigeoDestino.MaxLength = 100
        Me.txtUbigeoDestino.Name = "txtUbigeoDestino"
        Me.txtUbigeoDestino.Size = New System.Drawing.Size(305, 22)
        Me.txtUbigeoDestino.TabIndex = 31
        '
        'txtUbigeoOrigen
        '
        Me.txtUbigeoOrigen.Enabled = False
        Me.txtUbigeoOrigen.Location = New System.Drawing.Point(110, 19)
        Me.txtUbigeoOrigen.MaxLength = 100
        Me.txtUbigeoOrigen.Name = "txtUbigeoOrigen"
        Me.txtUbigeoOrigen.Size = New System.Drawing.Size(305, 22)
        Me.txtUbigeoOrigen.TabIndex = 22
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(435, 44)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(108, 20)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Text = "Localidad Destino"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Localidad Destino"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(437, 19)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(103, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Localidad Origen "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Localidad Origen "
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(17, 19)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(91, 20)
        Me.lblOperacion.TabIndex = 0
        Me.lblOperacion.Text = "Ubigeo Origen "
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "Ubigeo Origen "
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(13, 44)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(95, 20)
        Me.lblNroGuiaRemision.TabIndex = 1
        Me.lblNroGuiaRemision.Text = "Ubigeo Destino"
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "Ubigeo Destino"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(753, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipText = "Cancelar"
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
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmModificarOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 201)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModificarOrdenServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Datos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpInfServicio.ResumeLayout(False)
        Me.grpInfServicio.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpInfServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroReq As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadSolicitada As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUbigeoDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUbigeoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLocalidadDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLocalidadOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAsignarOSAgencias As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtOSAgencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnBuscaOrdenServicio As System.Windows.Forms.Button
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
