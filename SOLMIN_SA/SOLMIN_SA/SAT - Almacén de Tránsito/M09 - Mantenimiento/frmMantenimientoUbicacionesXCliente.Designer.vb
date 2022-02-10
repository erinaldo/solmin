<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoUbicacionesXCliente
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
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCompania = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSigla = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumero = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTara = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCargaUtil = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCubica = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UcCliente_TxtF011 = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUbicacionReferencial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(165, 68)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(436, 22)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 14
        '
        'txtCompania
        '
        Me.txtCompania.Location = New System.Drawing.Point(165, 42)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.ReadOnly = True
        Me.txtCompania.Size = New System.Drawing.Size(436, 22)
        Me.txtCompania.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCompania.TabIndex = 13
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(165, 94)
        Me.txtSigla.MaxLength = 4
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(126, 22)
        Me.txtSigla.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(475, 97)
        Me.txtNumero.MaxLength = 7
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(126, 22)
        Me.txtNumero.TabIndex = 1
        '
        'txtTara
        '
        Me.txtTara.Location = New System.Drawing.Point(165, 176)
        Me.txtTara.MaxLength = 9
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(126, 22)
        Me.txtTara.TabIndex = 6
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(165, 255)
        Me.txtObs.MaxLength = 15
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(436, 22)
        Me.txtObs.TabIndex = 12
        '
        'txtCargaUtil
        '
        Me.txtCargaUtil.Location = New System.Drawing.Point(475, 174)
        Me.txtCargaUtil.MaxLength = 9
        Me.txtCargaUtil.Name = "txtCargaUtil"
        Me.txtCargaUtil.Size = New System.Drawing.Size(126, 22)
        Me.txtCargaUtil.TabIndex = 7
        Me.txtCargaUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCubica
        '
        Me.txtCubica.Location = New System.Drawing.Point(165, 202)
        Me.txtCubica.MaxLength = 9
        Me.txtCubica.Name = "txtCubica"
        Me.txtCubica.Size = New System.Drawing.Size(126, 22)
        Me.txtCubica.TabIndex = 8
        Me.txtCubica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.UcCliente_TxtF011)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtUbicacionReferencial)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(480, 130)
        Me.KryptonPanel.TabIndex = 1
        '
        'UcCliente_TxtF011
        '
        Me.UcCliente_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente_TxtF011.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente_TxtF011.Location = New System.Drawing.Point(159, 49)
        Me.UcCliente_TxtF011.Name = "UcCliente_TxtF011"
        Me.UcCliente_TxtF011.pAccesoPorUsuario = True
        Me.UcCliente_TxtF011.pRequerido = True
        Me.UcCliente_TxtF011.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente_TxtF011.Size = New System.Drawing.Size(291, 22)
        Me.UcCliente_TxtF011.TabIndex = 15
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(22, 85)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(134, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "Ubicación Referencial : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Ubicación Referencial : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(22, 51)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 3
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'txtUbicacionReferencial
        '
        Me.txtUbicacionReferencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacionReferencial.Location = New System.Drawing.Point(159, 83)
        Me.txtUbicacionReferencial.MaxLength = 17
        Me.txtUbicacionReferencial.Name = "txtUbicacionReferencial"
        Me.txtUbicacionReferencial.Size = New System.Drawing.Size(291, 22)
        Me.txtUbicacionReferencial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUbicacionReferencial.TabIndex = 14
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(480, 25)
        Me.tsMenuOpciones.TabIndex = 1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Datos de Contenedor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(49, 22)
        Me.btnCancelar.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'frmMantenimientoUbicacionesXCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantenimientoUbicacionesXCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Ubicaciones por Cliente"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCompania As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSigla As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNumero As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTara As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCargaUtil As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCubica As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUbicacionReferencial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UcCliente_TxtF011 As RANSA.Controls.Cliente.ucCliente_TxtF01
End Class
