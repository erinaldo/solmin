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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
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
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSolicitud.Panel.SuspendLayout()
        Me.HeaderSolicitud.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderSolicitud)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(351, 249)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderSolicitud
        '
        Me.HeaderSolicitud.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.HeaderSolicitud.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToBoth
        Me.HeaderSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderSolicitud.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderSolicitud.HeaderVisibleSecondary = False
        Me.HeaderSolicitud.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSolicitud.Name = "HeaderSolicitud"
        '
        'HeaderSolicitud.Panel
        '
        Me.HeaderSolicitud.Panel.Controls.Add(Me.KryptonGroup1)
        Me.HeaderSolicitud.Size = New System.Drawing.Size(351, 249)
        Me.HeaderSolicitud.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form
        Me.HeaderSolicitud.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.HeaderSolicitud.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.HeaderSolicitud.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderSolicitud.TabIndex = 108
        Me.HeaderSolicitud.ValuesPrimary.Description = ""
        Me.HeaderSolicitud.ValuesPrimary.Heading = ""
        Me.HeaderSolicitud.ValuesPrimary.Image = Nothing
        Me.HeaderSolicitud.ValuesSecondary.Description = ""
        Me.HeaderSolicitud.ValuesSecondary.Heading = ""
        Me.HeaderSolicitud.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = My.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipBody = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "27D941CF936C4FCB27D941CF936C4FCB"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtTerminalUsadoActualizar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtHoraActualizado)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtTerminalUsado)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtFechaActualizado)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtUsuarioActualizado)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtHoraCreacion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtFechaCreacion)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtUsuarioCreador)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCerrar)
        Me.KryptonGroup1.Size = New System.Drawing.Size(349, 222)
        Me.KryptonGroup1.TabIndex = 9
        '
        'txtTerminalUsadoActualizar
        '
        Me.txtTerminalUsadoActualizar.Enabled = False
        Me.txtTerminalUsadoActualizar.Location = New System.Drawing.Point(172, 182)
        Me.txtTerminalUsadoActualizar.Name = "txtTerminalUsadoActualizar"
        Me.txtTerminalUsadoActualizar.ReadOnly = True
        Me.txtTerminalUsadoActualizar.Size = New System.Drawing.Size(156, 19)
        Me.txtTerminalUsadoActualizar.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsadoActualizar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsadoActualizar.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtTerminalUsadoActualizar.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalUsadoActualizar.TabIndex = 0
        '
        'txtHoraActualizado
        '
        Me.txtHoraActualizado.Enabled = False
        Me.txtHoraActualizado.Location = New System.Drawing.Point(172, 158)
        Me.txtHoraActualizado.Name = "txtHoraActualizado"
        Me.txtHoraActualizado.ReadOnly = True
        Me.txtHoraActualizado.Size = New System.Drawing.Size(156, 19)
        Me.txtHoraActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtHoraActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraActualizado.TabIndex = 0
        '
        'txtTerminalUsado
        '
        Me.txtTerminalUsado.Enabled = False
        Me.txtTerminalUsado.Location = New System.Drawing.Point(172, 86)
        Me.txtTerminalUsado.Name = "txtTerminalUsado"
        Me.txtTerminalUsado.ReadOnly = True
        Me.txtTerminalUsado.Size = New System.Drawing.Size(156, 19)
        Me.txtTerminalUsado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtTerminalUsado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtTerminalUsado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtTerminalUsado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalUsado.TabIndex = 0
        '
        'txtFechaActualizado
        '
        Me.txtFechaActualizado.Enabled = False
        Me.txtFechaActualizado.Location = New System.Drawing.Point(172, 134)
        Me.txtFechaActualizado.Name = "txtFechaActualizado"
        Me.txtFechaActualizado.ReadOnly = True
        Me.txtFechaActualizado.Size = New System.Drawing.Size(156, 19)
        Me.txtFechaActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaActualizado.TabIndex = 0
        '
        'txtUsuarioActualizado
        '
        Me.txtUsuarioActualizado.Enabled = False
        Me.txtUsuarioActualizado.Location = New System.Drawing.Point(172, 110)
        Me.txtUsuarioActualizado.Name = "txtUsuarioActualizado"
        Me.txtUsuarioActualizado.ReadOnly = True
        Me.txtUsuarioActualizado.Size = New System.Drawing.Size(156, 19)
        Me.txtUsuarioActualizado.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioActualizado.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioActualizado.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioActualizado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUsuarioActualizado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioActualizado.TabIndex = 0
        '
        'txtHoraCreacion
        '
        Me.txtHoraCreacion.Enabled = False
        Me.txtHoraCreacion.Location = New System.Drawing.Point(172, 62)
        Me.txtHoraCreacion.Name = "txtHoraCreacion"
        Me.txtHoraCreacion.ReadOnly = True
        Me.txtHoraCreacion.Size = New System.Drawing.Size(156, 19)
        Me.txtHoraCreacion.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtHoraCreacion.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraCreacion.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtHoraCreacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtHoraCreacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraCreacion.TabIndex = 0
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Location = New System.Drawing.Point(172, 38)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.ReadOnly = True
        Me.txtFechaCreacion.Size = New System.Drawing.Size(156, 19)
        Me.txtFechaCreacion.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtFechaCreacion.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaCreacion.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtFechaCreacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaCreacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.TabIndex = 0
        '
        'txtUsuarioCreador
        '
        Me.txtUsuarioCreador.Enabled = False
        Me.txtUsuarioCreador.Location = New System.Drawing.Point(172, 14)
        Me.txtUsuarioCreador.Name = "txtUsuarioCreador"
        Me.txtUsuarioCreador.ReadOnly = True
        Me.txtUsuarioCreador.Size = New System.Drawing.Size(156, 19)
        Me.txtUsuarioCreador.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioCreador.StateDisabled.Border.Color1 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioCreador.StateDisabled.Border.Color2 = System.Drawing.Color.CornflowerBlue
        Me.txtUsuarioCreador.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUsuarioCreador.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioCreador.TabIndex = 0
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(5, 185)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(171, 16)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "N° Terminal Usado al Actualizar"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Terminal Usado al Actualizar"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(5, 161)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(120, 16)
        Me.KryptonLabel5.TabIndex = 1
        Me.KryptonLabel5.Text = "Hora de Actualización"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Hora de Actualización"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(5, 137)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(127, 16)
        Me.KryptonLabel4.TabIndex = 1
        Me.KryptonLabel4.Text = "Fecha de Actualización"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha de Actualización"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(5, 89)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(106, 16)
        Me.KryptonLabel9.TabIndex = 1
        Me.KryptonLabel9.Text = "N° Terminal Usado"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "N° Terminal Usado"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(5, 113)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(150, 16)
        Me.KryptonLabel8.TabIndex = 1
        Me.KryptonLabel8.Text = "Último Usuario Actualizador"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Último Usuario Actualizador"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 65)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(99, 16)
        Me.KryptonLabel3.TabIndex = 1
        Me.KryptonLabel3.Text = "Hora de Creación"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hora de Creación"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 41)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(106, 16)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Fecha de Creación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha de Creación"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(93, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Usuario Creador"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Usuario Creador"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(320, 17)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 8)
        Me.btnCerrar.TabIndex = 19
        Me.btnCerrar.Text = "Cerrar Ventana"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "Cerrar Ventana"
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
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
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.Panel.ResumeLayout(False)
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUsuarioCreador As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTerminalUsadoActualizar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtHoraActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUsuarioActualizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtHoraCreacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaCreacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTerminalUsado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
