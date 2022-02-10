<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroExportarXls_2
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
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.lblSituacionOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbSituacionOC = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.grpFechaCompProv = New System.Windows.Forms.GroupBox
        Me.lblFechaInicialComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaCompInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinalComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaCompFinal = New System.Windows.Forms.DateTimePicker
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblDestino = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator
        Me.tslTitulo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.grpFechaCompProv.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(384, 142)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblSituacionOC)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmbSituacionOC)
        Me.KryptonGroup1.Panel.Controls.Add(Me.grpFechaCompProv)
        Me.KryptonGroup1.Size = New System.Drawing.Size(384, 117)
        Me.KryptonGroup1.TabIndex = 102
        '
        'lblSituacionOC
        '
        Me.lblSituacionOC.Location = New System.Drawing.Point(36, 72)
        Me.lblSituacionOC.Name = "lblSituacionOC"
        Me.lblSituacionOC.Size = New System.Drawing.Size(50, 20)
        Me.lblSituacionOC.TabIndex = 101
        Me.lblSituacionOC.Text = "Status :"
        Me.lblSituacionOC.Values.ExtraText = ""
        Me.lblSituacionOC.Values.Image = Nothing
        Me.lblSituacionOC.Values.Text = "Status :"
        '
        'cmbSituacionOC
        '
        Me.cmbSituacionOC.BackColor = System.Drawing.Color.Transparent
        Me.cmbSituacionOC.Location = New System.Drawing.Point(87, 72)
        Me.cmbSituacionOC.Name = "cmbSituacionOC"
        Me.cmbSituacionOC.pCategoria = "SITUOC"
        Me.cmbSituacionOC.pIsRequired = False
        Me.cmbSituacionOC.Size = New System.Drawing.Size(259, 21)
        Me.cmbSituacionOC.TabIndex = 100
        '
        'grpFechaCompProv
        '
        Me.grpFechaCompProv.BackColor = System.Drawing.Color.Transparent
        Me.grpFechaCompProv.Controls.Add(Me.lblFechaInicialComp)
        Me.grpFechaCompProv.Controls.Add(Me.dteFechaCompInicial)
        Me.grpFechaCompProv.Controls.Add(Me.lblFechaFinalComp)
        Me.grpFechaCompProv.Controls.Add(Me.dteFechaCompFinal)
        Me.grpFechaCompProv.Location = New System.Drawing.Point(23, 12)
        Me.grpFechaCompProv.Name = "grpFechaCompProv"
        Me.grpFechaCompProv.Size = New System.Drawing.Size(341, 50)
        Me.grpFechaCompProv.TabIndex = 99
        Me.grpFechaCompProv.TabStop = False
        Me.grpFechaCompProv.Text = "Fecha estimada de entrega"
        '
        'lblFechaInicialComp
        '
        Me.lblFechaInicialComp.Location = New System.Drawing.Point(13, 19)
        Me.lblFechaInicialComp.Name = "lblFechaInicialComp"
        Me.lblFechaInicialComp.Size = New System.Drawing.Size(46, 20)
        Me.lblFechaInicialComp.TabIndex = 23
        Me.lblFechaInicialComp.Text = "Inicio : "
        Me.lblFechaInicialComp.Values.ExtraText = ""
        Me.lblFechaInicialComp.Values.Image = Nothing
        Me.lblFechaInicialComp.Values.Text = "Inicio : "
        '
        'dteFechaCompInicial
        '
        Me.dteFechaCompInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaCompInicial.Location = New System.Drawing.Point(62, 15)
        Me.dteFechaCompInicial.Name = "dteFechaCompInicial"
        Me.dteFechaCompInicial.ShowCheckBox = True
        Me.dteFechaCompInicial.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaCompInicial.TabIndex = 0
        '
        'lblFechaFinalComp
        '
        Me.lblFechaFinalComp.Location = New System.Drawing.Point(174, 19)
        Me.lblFechaFinalComp.Name = "lblFechaFinalComp"
        Me.lblFechaFinalComp.Size = New System.Drawing.Size(42, 20)
        Me.lblFechaFinalComp.TabIndex = 25
        Me.lblFechaFinalComp.Text = "Final : "
        Me.lblFechaFinalComp.Values.ExtraText = ""
        Me.lblFechaFinalComp.Values.Image = Nothing
        Me.lblFechaFinalComp.Values.Text = "Final : "
        '
        'dteFechaCompFinal
        '
        Me.dteFechaCompFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaCompFinal.Location = New System.Drawing.Point(221, 15)
        Me.dteFechaCompFinal.Name = "dteFechaCompFinal"
        Me.dteFechaCompFinal.ShowCheckBox = True
        Me.dteFechaCompFinal.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaCompFinal.TabIndex = 1
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDestino, Me.btnCancelar, Me.tssSeparador1, Me.btnGuardar, Me.tssSeparador2, Me.tslTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(384, 25)
        Me.tsMenuOpciones.TabIndex = 98
        '
        'lblDestino
        '
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(11, 22)
        Me.lblDestino.Tag = ""
        Me.lblDestino.Text = " "
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
        'tssSeparador1
        '
        Me.tssSeparador1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 22)
        Me.btnGuardar.Text = "Exportar"
        '
        'tssSeparador2
        '
        Me.tssSeparador2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador2.Name = "tssSeparador2"
        Me.tssSeparador2.Size = New System.Drawing.Size(6, 25)
        '
        'tslTitulo
        '
        Me.tslTitulo.Name = "tslTitulo"
        Me.tslTitulo.Size = New System.Drawing.Size(0, 22)
        '
        'frmFiltroExportarXls_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 142)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 180)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 180)
        Me.Name = "frmFiltroExportarXls_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Seguimiento OC Local"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.grpFechaCompProv.ResumeLayout(False)
        Me.grpFechaCompProv.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblDestino As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents grpFechaCompProv As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaInicialComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaCompInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinalComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaCompFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Private WithEvents lblSituacionOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbSituacionOC As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
End Class
