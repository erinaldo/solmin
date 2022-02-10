<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAnualSegLocal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteAnualSegLocal))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.icoEspera = New System.Windows.Forms.PictureBox
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblFechaInicialComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblDestino = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator
        Me.tslTitulo = New System.Windows.Forms.ToolStripLabel
        Me.btnExportarPdf = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.bgwExportar = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.icoEspera, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(242, 113)
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
        Me.KryptonGroup1.Panel.Controls.Add(Me.icoEspera)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtAnio)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblFechaInicialComp)
        Me.KryptonGroup1.Size = New System.Drawing.Size(242, 88)
        Me.KryptonGroup1.TabIndex = 102
        '
        'icoEspera
        '
        Me.icoEspera.Image = Global.SOLMIN_SC.My.Resources.Resources.iconoEspera
        Me.icoEspera.Location = New System.Drawing.Point(8, 13)
        Me.icoEspera.Name = "icoEspera"
        Me.icoEspera.Size = New System.Drawing.Size(65, 62)
        Me.icoEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icoEspera.TabIndex = 25
        Me.icoEspera.TabStop = False
        Me.icoEspera.Visible = False
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(133, 33)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(88, 21)
        Me.txtAnio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtAnio.TabIndex = 24
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtAnio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblFechaInicialComp
        '
        Me.lblFechaInicialComp.Location = New System.Drawing.Point(88, 33)
        Me.lblFechaInicialComp.Name = "lblFechaInicialComp"
        Me.lblFechaInicialComp.Size = New System.Drawing.Size(36, 19)
        Me.lblFechaInicialComp.TabIndex = 23
        Me.lblFechaInicialComp.Text = "Año : "
        Me.lblFechaInicialComp.Values.ExtraText = ""
        Me.lblFechaInicialComp.Values.Image = Nothing
        Me.lblFechaInicialComp.Values.Text = "Año : "
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDestino, Me.btnCancelar, Me.tssSeparador1, Me.btnExportar, Me.tssSeparador2, Me.tslTitulo, Me.btnExportarPdf})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(242, 25)
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
        Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
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
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
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
        'btnExportarPdf
        '
        Me.btnExportarPdf.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarPdf.Image = CType(resources.GetObject("btnExportarPdf.Image"), System.Drawing.Image)
        Me.btnExportarPdf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarPdf.Name = "btnExportarPdf"
        Me.btnExportarPdf.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarPdf.Text = "Exportar"
        '
        'bgwExportar
        '
        '
        'frmReporteAnualSegLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 113)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(250, 140)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(250, 140)
        Me.Name = "frmReporteAnualSegLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Anual de Seguimiento OC"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.icoEspera, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblFechaInicialComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents btnExportarPdf As System.Windows.Forms.ToolStripButton
    Friend WithEvents icoEspera As System.Windows.Forms.PictureBox
    Friend WithEvents bgwExportar As System.ComponentModel.BackgroundWorker
End Class
