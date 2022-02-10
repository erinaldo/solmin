<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucfrmAprobarFlete
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
        Me.components = New System.ComponentModel.Container()
        Me.txtObs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAprobadorPor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMrgAprobacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAprobSugerido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtFeInicial = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(168, 180)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.MaxLength = 50
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(468, 66)
        Me.txtObs.TabIndex = 100
        '
        'txtAprobadorPor
        '
        Me.txtAprobadorPor.Location = New System.Drawing.Point(168, 113)
        Me.txtAprobadorPor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAprobadorPor.MaxLength = 30
        Me.txtAprobadorPor.Name = "txtAprobadorPor"
        Me.txtAprobadorPor.Size = New System.Drawing.Size(468, 26)
        Me.txtAprobadorPor.TabIndex = 99
        '
        'txtMrgAprobacion
        '
        Me.txtMrgAprobacion.Enabled = False
        Me.txtMrgAprobacion.Location = New System.Drawing.Point(168, 81)
        Me.txtMrgAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMrgAprobacion.MaxLength = 20
        Me.txtMrgAprobacion.Name = "txtMrgAprobacion"
        Me.txtMrgAprobacion.Size = New System.Drawing.Size(468, 26)
        Me.txtMrgAprobacion.TabIndex = 98
        '
        'txtAprobSugerido
        '
        Me.txtAprobSugerido.Enabled = False
        Me.txtAprobSugerido.Location = New System.Drawing.Point(168, 47)
        Me.txtAprobSugerido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAprobSugerido.MaxLength = 20
        Me.txtAprobSugerido.Name = "txtAprobSugerido"
        Me.txtAprobSugerido.Size = New System.Drawing.Size(468, 26)
        Me.txtAprobSugerido.TabIndex = 97
        '
        'lblFacturacion
        '
        Me.lblFacturacion.Location = New System.Drawing.Point(9, 180)
        Me.lblFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(144, 26)
        Me.lblFacturacion.TabIndex = 77
        Me.lblFacturacion.Text = "Observaciones       :"
        Me.lblFacturacion.UseMnemonic = False
        Me.lblFacturacion.Values.ExtraText = ""
        Me.lblFacturacion.Values.Image = Nothing
        Me.lblFacturacion.Values.Text = "Observaciones       :"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtObs)
        Me.KryptonPanel.Controls.Add(Me.txtAprobadorPor)
        Me.KryptonPanel.Controls.Add(Me.txtMrgAprobacion)
        Me.KryptonPanel.Controls.Add(Me.txtAprobSugerido)
        Me.KryptonPanel.Controls.Add(Me.lblFacturacion)
        Me.KryptonPanel.Controls.Add(Me.dtFeInicial)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(671, 277)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 2
        '
        'dtFeInicial
        '
        Me.dtFeInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFeInicial.Location = New System.Drawing.Point(168, 148)
        Me.dtFeInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFeInicial.Name = "dtFeInicial"
        Me.dtFeInicial.Size = New System.Drawing.Size(107, 22)
        Me.dtFeInicial.TabIndex = 26
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(8, 148)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(142, 26)
        Me.KryptonLabel8.TabIndex = 7
        Me.KryptonLabel8.Text = "Fecha Aprobación :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Fecha Aprobación :"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(8, 113)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(146, 26)
        Me.KryptonLabel7.TabIndex = 5
        Me.KryptonLabel7.Text = "Aprobador por       :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Aprobador por       :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(9, 47)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(143, 26)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "Aprob. Sugerido    :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Aprob. Sugerido    :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(8, 79)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(143, 26)
        Me.KryptonLabel5.TabIndex = 3
        Me.KryptonLabel5.Text = "Mrg. Aprobación   :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Mrg. Aprobación   :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(671, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(64, 24)
        Me.ToolStripLabel1.Text = "Aprobar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'ucfrmAprobarFlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 277)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucfrmAprobarFlete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtObs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAprobadorPor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMrgAprobacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAprobSugerido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblFacturacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtFeInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class
