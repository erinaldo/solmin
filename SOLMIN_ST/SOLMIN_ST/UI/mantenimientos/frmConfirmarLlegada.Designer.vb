<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmarLlegada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmarLlegada))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtpHoraConfirmacion = New System.Windows.Forms.MaskedTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblHora = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaConfirmacion = New System.Windows.Forms.DateTimePicker
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.dtpHoraConfirmacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.lblHora)
        Me.KryptonPanel.Controls.Add(Me.lblFecha)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaConfirmacion)
        Me.KryptonPanel.Controls.Add(Me.btnSalir)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(265, 182)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(83, 80)
        Me.txtObservaciones.MaxLength = 40
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(170, 35)
        Me.txtObservaciones.TabIndex = 2
        '
        'dtpHoraConfirmacion
        '
        Me.dtpHoraConfirmacion.Location = New System.Drawing.Point(83, 54)
        Me.dtpHoraConfirmacion.Mask = "00:00:00"
        Me.dtpHoraConfirmacion.Name = "dtpHoraConfirmacion"
        Me.dtpHoraConfirmacion.Size = New System.Drawing.Size(111, 20)
        Me.dtpHoraConfirmacion.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(1, 80)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 19)
        Me.KryptonLabel1.TabIndex = 82
        Me.KryptonLabel1.Text = "Obseraciones:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Obseraciones:"
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(1, 55)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(40, 19)
        Me.lblHora.TabIndex = 82
        Me.lblHora.Text = "Hora :"
        Me.lblHora.Values.ExtraText = ""
        Me.lblHora.Values.Image = Nothing
        Me.lblHora.Values.Text = "Hora :"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(1, 25)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 19)
        Me.lblFecha.TabIndex = 81
        Me.lblFecha.Text = "Fecha  :"
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "Fecha  :"
        '
        'dtpFechaConfirmacion
        '
        Me.dtpFechaConfirmacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaConfirmacion.Location = New System.Drawing.Point(83, 25)
        Me.dtpFechaConfirmacion.Name = "dtpFechaConfirmacion"
        Me.dtpFechaConfirmacion.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaConfirmacion.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(132, 145)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 25)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = CType(resources.GetObject("btnSalir.Values.Image"), System.Drawing.Image)
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(41, 145)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 25)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'frmConfirmarLlegada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 182)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmarLlegada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirmar Llegada"
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
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblHora As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaConfirmacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraConfirmacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
