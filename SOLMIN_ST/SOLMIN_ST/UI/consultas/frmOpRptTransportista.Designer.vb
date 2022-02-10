<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptTransportista
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
        Me.chkVehiculos = New System.Windows.Forms.CheckBox
        Me.chkAcoplados = New System.Windows.Forms.CheckBox
        Me.chkConductores = New System.Windows.Forms.CheckBox
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
        Me.KryptonPanel.Size = New System.Drawing.Size(217, 160)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(108, 129)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 70
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
        Me.btnAceptar.Location = New System.Drawing.Point(12, 129)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 69
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
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkVehiculos)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkAcoplados)
        Me.GrpBoxOpcReportes.Controls.Add(Me.chkConductores)
        Me.GrpBoxOpcReportes.Location = New System.Drawing.Point(12, 12)
        Me.GrpBoxOpcReportes.Name = "GrpBoxOpcReportes"
        Me.GrpBoxOpcReportes.Size = New System.Drawing.Size(192, 111)
        Me.GrpBoxOpcReportes.TabIndex = 68
        Me.GrpBoxOpcReportes.TabStop = False
        Me.GrpBoxOpcReportes.Text = "Opciones Reporte"
        '
        'chkVehiculos
        '
        Me.chkVehiculos.AutoSize = True
        Me.chkVehiculos.Checked = True
        Me.chkVehiculos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVehiculos.Location = New System.Drawing.Point(6, 19)
        Me.chkVehiculos.Name = "chkVehiculos"
        Me.chkVehiculos.Size = New System.Drawing.Size(74, 17)
        Me.chkVehiculos.TabIndex = 66
        Me.chkVehiculos.Text = "Vehículos"
        Me.chkVehiculos.UseVisualStyleBackColor = True
        '
        'chkAcoplados
        '
        Me.chkAcoplados.AutoSize = True
        Me.chkAcoplados.Checked = True
        Me.chkAcoplados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAcoplados.Location = New System.Drawing.Point(6, 42)
        Me.chkAcoplados.Name = "chkAcoplados"
        Me.chkAcoplados.Size = New System.Drawing.Size(76, 17)
        Me.chkAcoplados.TabIndex = 67
        Me.chkAcoplados.Text = "Acoplados"
        Me.chkAcoplados.UseVisualStyleBackColor = True
        '
        'chkConductores
        '
        Me.chkConductores.AutoSize = True
        Me.chkConductores.Checked = True
        Me.chkConductores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConductores.Location = New System.Drawing.Point(6, 65)
        Me.chkConductores.Name = "chkConductores"
        Me.chkConductores.Size = New System.Drawing.Size(86, 17)
        Me.chkConductores.TabIndex = 68
        Me.chkConductores.Text = "Conductores"
        Me.chkConductores.UseVisualStyleBackColor = True
        '
        'frmOpRptTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOpRptTransportista"
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

    Public Sub New(ByVal lpNRUCTR As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If lpNRUCTR.Trim.Length > 0 Then
            _NRUCTR = lpNRUCTR
        Else
            Exit Sub
        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents GrpBoxOpcReportes As System.Windows.Forms.GroupBox
    Friend WithEvents chkVehiculos As System.Windows.Forms.CheckBox
    Friend WithEvents chkAcoplados As System.Windows.Forms.CheckBox
    Friend WithEvents chkConductores As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
