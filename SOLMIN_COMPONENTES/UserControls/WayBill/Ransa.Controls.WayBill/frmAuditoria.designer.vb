<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditoria))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtTerminalUsadoActualizar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtHoraActualizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTerminalUsado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFechaActualizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUsuarioActualizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtHoraCreacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFechaCreacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUsuarioCreador = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblAuditoria = New System.Windows.Forms.ToolStripLabel
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(351, 249)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtTerminalUsadoActualizar)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtHoraActualizado)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtTerminalUsado)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtFechaActualizado)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtUsuarioActualizado)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtHoraCreacion)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtFechaCreacion)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtUsuarioCreador)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(351, 224)
        Me.KryptonGroup2.TabIndex = 110
        '
        'txtTerminalUsadoActualizar
        '
        Me.txtTerminalUsadoActualizar.Enabled = False
        Me.txtTerminalUsadoActualizar.Location = New System.Drawing.Point(179, 179)
        Me.txtTerminalUsadoActualizar.Name = "txtTerminalUsadoActualizar"
        Me.txtTerminalUsadoActualizar.ReadOnly = True
        Me.txtTerminalUsadoActualizar.Size = New System.Drawing.Size(156, 21)
        Me.txtTerminalUsadoActualizar.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsadoActualizar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtTerminalUsadoActualizar.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalUsadoActualizar.TabIndex = 7
        '
        'txtHoraActualizado
        '
        Me.txtHoraActualizado.Enabled = False
        Me.txtHoraActualizado.Location = New System.Drawing.Point(179, 155)
        Me.txtHoraActualizado.Name = "txtHoraActualizado"
        Me.txtHoraActualizado.ReadOnly = True
        Me.txtHoraActualizado.Size = New System.Drawing.Size(156, 21)
        Me.txtHoraActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtHoraActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraActualizado.TabIndex = 6
        '
        'txtTerminalUsado
        '
        Me.txtTerminalUsado.Enabled = False
        Me.txtTerminalUsado.Location = New System.Drawing.Point(179, 83)
        Me.txtTerminalUsado.Name = "txtTerminalUsado"
        Me.txtTerminalUsado.ReadOnly = True
        Me.txtTerminalUsado.Size = New System.Drawing.Size(156, 21)
        Me.txtTerminalUsado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtTerminalUsado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalUsado.TabIndex = 9
        '
        'txtFechaActualizado
        '
        Me.txtFechaActualizado.Enabled = False
        Me.txtFechaActualizado.Location = New System.Drawing.Point(179, 131)
        Me.txtFechaActualizado.Name = "txtFechaActualizado"
        Me.txtFechaActualizado.ReadOnly = True
        Me.txtFechaActualizado.Size = New System.Drawing.Size(156, 21)
        Me.txtFechaActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaActualizado.TabIndex = 8
        '
        'txtUsuarioActualizado
        '
        Me.txtUsuarioActualizado.Enabled = False
        Me.txtUsuarioActualizado.Location = New System.Drawing.Point(179, 107)
        Me.txtUsuarioActualizado.Name = "txtUsuarioActualizado"
        Me.txtUsuarioActualizado.ReadOnly = True
        Me.txtUsuarioActualizado.Size = New System.Drawing.Size(156, 21)
        Me.txtUsuarioActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUsuarioActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioActualizado.TabIndex = 3
        '
        'txtHoraCreacion
        '
        Me.txtHoraCreacion.Enabled = False
        Me.txtHoraCreacion.Location = New System.Drawing.Point(179, 59)
        Me.txtHoraCreacion.Name = "txtHoraCreacion"
        Me.txtHoraCreacion.ReadOnly = True
        Me.txtHoraCreacion.Size = New System.Drawing.Size(156, 21)
        Me.txtHoraCreacion.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraCreacion.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraCreacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtHoraCreacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraCreacion.TabIndex = 2
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Location = New System.Drawing.Point(179, 35)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.ReadOnly = True
        Me.txtFechaCreacion.Size = New System.Drawing.Size(156, 21)
        Me.txtFechaCreacion.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaCreacion.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaCreacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaCreacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.TabIndex = 5
        '
        'txtUsuarioCreador
        '
        Me.txtUsuarioCreador.Enabled = False
        Me.txtUsuarioCreador.Location = New System.Drawing.Point(179, 11)
        Me.txtUsuarioCreador.Name = "txtUsuarioCreador"
        Me.txtUsuarioCreador.ReadOnly = True
        Me.txtUsuarioCreador.Size = New System.Drawing.Size(156, 21)
        Me.txtUsuarioCreador.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioCreador.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioCreador.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUsuarioCreador.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioCreador.TabIndex = 4
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 182)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(168, 19)
        Me.KryptonLabel6.TabIndex = 15
        Me.KryptonLabel6.Text = "N° Terminal Usado al Actualizar"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Terminal Usado al Actualizar"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 158)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(119, 19)
        Me.KryptonLabel5.TabIndex = 14
        Me.KryptonLabel5.Text = "Hora de Actualización"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Hora de Actualización"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 134)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(124, 19)
        Me.KryptonLabel4.TabIndex = 17
        Me.KryptonLabel4.Text = "Fecha de Actualización"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha de Actualización"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 86)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(104, 19)
        Me.KryptonLabel9.TabIndex = 16
        Me.KryptonLabel9.Text = "N° Terminal Usado"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "N° Terminal Usado"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(12, 110)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(150, 19)
        Me.KryptonLabel8.TabIndex = 11
        Me.KryptonLabel8.Text = "Último Usuario Actualizador"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Último Usuario Actualizador"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 62)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(97, 19)
        Me.KryptonLabel3.TabIndex = 10
        Me.KryptonLabel3.Text = "Hora de Creación"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hora de Creación"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(102, 19)
        Me.KryptonLabel2.TabIndex = 13
        Me.KryptonLabel2.Text = "Fecha de Creación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha de Creación"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(91, 19)
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Text = "Usuario Creador"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Usuario Creador"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAuditoria, Me.tsbCerrar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(351, 25)
        Me.tsMenuOpciones.TabIndex = 109
        '
        'lblAuditoria
        '
        Me.lblAuditoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuditoria.Name = "lblAuditoria"
        Me.lblAuditoria.Size = New System.Drawing.Size(59, 22)
        Me.lblAuditoria.Tag = "Auditoría"
        Me.lblAuditoria.Text = "Auditoría"
        '
        'tsbCerrar
        '
        Me.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCerrar.Image = CType(resources.GetObject("tsbCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(58, 22)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAuditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información de Auditoría"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblAuditoria As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtTerminalUsadoActualizar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtHoraActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTerminalUsado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUsuarioActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtHoraCreacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaCreacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUsuarioCreador As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
