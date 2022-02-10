<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarETA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtoperacion = New System.Windows.Forms.TextBox
        Me.txtgt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpeta = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtfechasalida = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtfechallegada = New System.Windows.Forms.TextBox
        Me.chkFechaLlegada = New System.Windows.Forms.CheckBox
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(357, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número Operación"
        '
        'txtoperacion
        '
        Me.txtoperacion.Enabled = False
        Me.txtoperacion.Location = New System.Drawing.Point(183, 40)
        Me.txtoperacion.Name = "txtoperacion"
        Me.txtoperacion.Size = New System.Drawing.Size(125, 20)
        Me.txtoperacion.TabIndex = 2
        '
        'txtgt
        '
        Me.txtgt.Enabled = False
        Me.txtgt.Location = New System.Drawing.Point(183, 66)
        Me.txtgt.Name = "txtgt"
        Me.txtgt.Size = New System.Drawing.Size(125, 20)
        Me.txtgt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Llegada Estimado(ETA)"
        '
        'dtpeta
        '
        Me.dtpeta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpeta.Location = New System.Drawing.Point(204, 124)
        Me.dtpeta.Name = "dtpeta"
        Me.dtpeta.Size = New System.Drawing.Size(102, 20)
        Me.dtpeta.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Guía Transporte"
        '
        'txtfechasalida
        '
        Me.txtfechasalida.Enabled = False
        Me.txtfechasalida.Location = New System.Drawing.Point(183, 97)
        Me.txtfechasalida.Name = "txtfechasalida"
        Me.txtfechasalida.Size = New System.Drawing.Size(125, 20)
        Me.txtfechasalida.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha Salida(Real)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha Llegada (Real)"
        '
        'txtfechallegada
        '
        Me.txtfechallegada.Enabled = False
        Me.txtfechallegada.Location = New System.Drawing.Point(183, 157)
        Me.txtfechallegada.Name = "txtfechallegada"
        Me.txtfechallegada.Size = New System.Drawing.Size(125, 20)
        Me.txtfechallegada.TabIndex = 11
        '
        'chkFechaLlegada
        '
        Me.chkFechaLlegada.AutoSize = True
        Me.chkFechaLlegada.Location = New System.Drawing.Point(183, 127)
        Me.chkFechaLlegada.Name = "chkFechaLlegada"
        Me.chkFechaLlegada.Size = New System.Drawing.Size(15, 14)
        Me.chkFechaLlegada.TabIndex = 12
        Me.chkFechaLlegada.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmActualizarETA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(357, 200)
        Me.Controls.Add(Me.chkFechaLlegada)
        Me.Controls.Add(Me.txtfechallegada)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfechasalida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtgt)
        Me.Controls.Add(Me.txtoperacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmActualizarETA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizar ETA"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoperacion As System.Windows.Forms.TextBox
    Friend WithEvents txtgt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpeta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfechasalida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfechallegada As System.Windows.Forms.TextBox
    Friend WithEvents chkFechaLlegada As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
