<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptConductor
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
        Me.GrpBoxOpcReportes = New System.Windows.Forms.GroupBox
        Me.chkDocAdjunto = New System.Windows.Forms.CheckBox
        Me.chkHistorial = New System.Windows.Forms.CheckBox
        Me.chkVacaciones = New System.Windows.Forms.CheckBox
        Me.chkListaAsistencia = New System.Windows.Forms.CheckBox
        Me.chkRecordGral = New System.Windows.Forms.CheckBox
        Me.chkCapacitaciones = New System.Windows.Forms.CheckBox
        Me.chkPase = New System.Windows.Forms.CheckBox
        Me.chVacunas = New System.Windows.Forms.CheckBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.GrpBoxOpcReportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.GrpBoxOpcReportes)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(219, 271)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(113, 231)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 68
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(17, 231)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 68
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'GrpBoxOpcReportes
        '
        Me.GrpBoxOpcReportes.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkDocAdjunto)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkHistorial)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkVacaciones)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkListaAsistencia)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkRecordGral)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkCapacitaciones)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkPase)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chVacunas)
        Me.GrpBoxOpcReportes.Location = New System.Drawing.Point(12, 9)
        Me.GrpBoxOpcReportes.Name = "GrpBoxOpcReportes"
        Me.GrpBoxOpcReportes.Size = New System.Drawing.Size(192, 209)
        Me.GrpBoxOpcReportes.TabIndex = 67
        Me.GrpBoxOpcReportes.TabStop = False
        Me.GrpBoxOpcReportes.Text = "Opciones Reporte"
        '
        'chkDocAdjunto
        '
        Me.chkDocAdjunto.AutoSize = True
        Me.chkDocAdjunto.Checked = True
        Me.chkDocAdjunto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDocAdjunto.Location = New System.Drawing.Point(6, 185)
        Me.chkDocAdjunto.Name = "chkDocAdjunto"
        Me.chkDocAdjunto.Size = New System.Drawing.Size(130, 17)
        Me.chkDocAdjunto.TabIndex = 73
        Me.chkDocAdjunto.Text = "Documentos Adjuntos"
        Me.chkDocAdjunto.UseVisualStyleBackColor = True
        Me.chkDocAdjunto.Visible = False
        '
        'chkHistorial
        '
        Me.chkHistorial.AutoSize = True
        Me.chkHistorial.Checked = True
        Me.chkHistorial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHistorial.Location = New System.Drawing.Point(6, 162)
        Me.chkHistorial.Name = "chkHistorial"
        Me.chkHistorial.Size = New System.Drawing.Size(63, 17)
        Me.chkHistorial.TabIndex = 72
        Me.chkHistorial.Text = "Historial"
        Me.chkHistorial.UseVisualStyleBackColor = True
        Me.chkHistorial.Visible = False
        '
        'chkVacaciones
        '
        Me.chkVacaciones.AutoSize = True
        Me.chkVacaciones.Checked = True
        Me.chkVacaciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVacaciones.Location = New System.Drawing.Point(6, 139)
        Me.chkVacaciones.Name = "chkVacaciones"
        Me.chkVacaciones.Size = New System.Drawing.Size(82, 17)
        Me.chkVacaciones.TabIndex = 71
        Me.chkVacaciones.Text = "Vacaciones"
        Me.chkVacaciones.UseVisualStyleBackColor = True
        Me.chkVacaciones.Visible = False
        '
        'chkListaAsistencia
        '
        Me.chkListaAsistencia.AutoSize = True
        Me.chkListaAsistencia.Checked = True
        Me.chkListaAsistencia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkListaAsistencia.Location = New System.Drawing.Point(6, 24)
        Me.chkListaAsistencia.Name = "chkListaAsistencia"
        Me.chkListaAsistencia.Size = New System.Drawing.Size(99, 17)
        Me.chkListaAsistencia.TabIndex = 70
        Me.chkListaAsistencia.Text = "Lista Asistencia"
        Me.chkListaAsistencia.UseVisualStyleBackColor = True
        Me.chkListaAsistencia.Visible = False
        '
        'chkRecordGral
        '
        Me.chkRecordGral.AutoSize = True
        Me.chkRecordGral.Checked = True
        Me.chkRecordGral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecordGral.Location = New System.Drawing.Point(6, 116)
        Me.chkRecordGral.Name = "chkRecordGral"
        Me.chkRecordGral.Size = New System.Drawing.Size(101, 17)
        Me.chkRecordGral.TabIndex = 69
        Me.chkRecordGral.Text = "Record General"
        Me.chkRecordGral.UseVisualStyleBackColor = True
        '
        'chkCapacitaciones
        '
        Me.chkCapacitaciones.AutoSize = True
        Me.chkCapacitaciones.Checked = True
        Me.chkCapacitaciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCapacitaciones.Location = New System.Drawing.Point(6, 47)
        Me.chkCapacitaciones.Name = "chkCapacitaciones"
        Me.chkCapacitaciones.Size = New System.Drawing.Size(99, 17)
        Me.chkCapacitaciones.TabIndex = 66
        Me.chkCapacitaciones.Text = "Capacitaciones"
        Me.chkCapacitaciones.UseVisualStyleBackColor = True
        '
        'chkPase
        '
        Me.chkPase.AutoSize = True
        Me.chkPase.Checked = True
        Me.chkPase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPase.Location = New System.Drawing.Point(6, 70)
        Me.chkPase.Name = "chkPase"
        Me.chkPase.Size = New System.Drawing.Size(55, 17)
        Me.chkPase.TabIndex = 67
        Me.chkPase.Text = "Pases"
        Me.chkPase.UseVisualStyleBackColor = True
        '
        'chVacunas
        '
        Me.chVacunas.AutoSize = True
        Me.chVacunas.Checked = True
        Me.chVacunas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chVacunas.Location = New System.Drawing.Point(6, 93)
        Me.chVacunas.Name = "chVacunas"
        Me.chVacunas.Size = New System.Drawing.Size(68, 17)
        Me.chVacunas.TabIndex = 68
        Me.chVacunas.Text = "Vacunas"
        Me.chVacunas.UseVisualStyleBackColor = True
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmOpRptConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(225, 300)
        Me.MinimumSize = New System.Drawing.Size(225, 300)
        Me.Name = "frmOpRptConductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones de Reporte"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.GrpBoxOpcReportes.ResumeLayout(False)
        Me.GrpBoxOpcReportes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByVal lpCBRCNT As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If lpCBRCNT.Trim.Length > 0 Then
            _CBRCNT = lpCBRCNT
        Else
            Exit Sub
        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents GrpBoxOpcReportes As System.Windows.Forms.GroupBox
    Friend WithEvents chkRecordGral As System.Windows.Forms.CheckBox
    Friend WithEvents chkCapacitaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkPase As System.Windows.Forms.CheckBox
    Friend WithEvents chVacunas As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents chkListaAsistencia As System.Windows.Forms.CheckBox
    Friend WithEvents chkHistorial As System.Windows.Forms.CheckBox
    Friend WithEvents chkVacaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkDocAdjunto As System.Windows.Forms.CheckBox
End Class
