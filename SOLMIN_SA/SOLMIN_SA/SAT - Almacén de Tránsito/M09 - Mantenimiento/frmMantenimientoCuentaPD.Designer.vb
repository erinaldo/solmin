<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCuentaPD
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
        Me.txtPorcentaje = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCuentaAfectacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblAfectacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCentroCosto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblTerrestre = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCostoAereo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCostoFluvial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblAereo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFluvial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtPorcentaje)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtCuentaAfectacion)
        Me.KryptonPanel.Controls.Add(Me.lblAfectacion)
        Me.KryptonPanel.Controls.Add(Me.txtCentroCosto)
        Me.KryptonPanel.Controls.Add(Me.lblTerrestre)
        Me.KryptonPanel.Controls.Add(Me.txtCostoAereo)
        Me.KryptonPanel.Controls.Add(Me.txtCostoFluvial)
        Me.KryptonPanel.Controls.Add(Me.lblAereo)
        Me.KryptonPanel.Controls.Add(Me.lblFluvial)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(502, 212)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(128, 173)
        Me.txtPorcentaje.MaxLength = 9
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(78, 21)
        Me.txtPorcentaje.TabIndex = 4
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 177)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel1.TabIndex = 23
        Me.KryptonLabel1.Text = "Porcentaje:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Porcentaje:"
        '
        'txtCuentaAfectacion
        '
        Me.txtCuentaAfectacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaAfectacion.Location = New System.Drawing.Point(128, 146)
        Me.txtCuentaAfectacion.MaxLength = 10
        Me.txtCuentaAfectacion.Name = "txtCuentaAfectacion"
        Me.txtCuentaAfectacion.Size = New System.Drawing.Size(192, 21)
        Me.txtCuentaAfectacion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCuentaAfectacion.TabIndex = 3
        '
        'lblAfectacion
        '
        Me.lblAfectacion.Location = New System.Drawing.Point(13, 148)
        Me.lblAfectacion.Name = "lblAfectacion"
        Me.lblAfectacion.Size = New System.Drawing.Size(81, 19)
        Me.lblAfectacion.TabIndex = 21
        Me.lblAfectacion.Text = "C.I Afectación:"
        Me.lblAfectacion.Values.ExtraText = ""
        Me.lblAfectacion.Values.Image = Nothing
        Me.lblAfectacion.Values.Text = "C.I Afectación:"
        '
        'txtCentroCosto
        '
        Me.txtCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroCosto.Location = New System.Drawing.Point(128, 59)
        Me.txtCentroCosto.MaxLength = 25
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.Size = New System.Drawing.Size(353, 21)
        Me.txtCentroCosto.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCentroCosto.TabIndex = 0
        '
        'lblTerrestre
        '
        Me.lblTerrestre.Location = New System.Drawing.Point(12, 61)
        Me.lblTerrestre.Name = "lblTerrestre"
        Me.lblTerrestre.Size = New System.Drawing.Size(72, 19)
        Me.lblTerrestre.TabIndex = 18
        Me.lblTerrestre.Text = "C.I Terrestre:"
        Me.lblTerrestre.Values.ExtraText = ""
        Me.lblTerrestre.Values.Image = Nothing
        Me.lblTerrestre.Values.Text = "C.I Terrestre:"
        '
        'txtCostoAereo
        '
        Me.txtCostoAereo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoAereo.Location = New System.Drawing.Point(128, 88)
        Me.txtCostoAereo.MaxLength = 25
        Me.txtCostoAereo.Name = "txtCostoAereo"
        Me.txtCostoAereo.Size = New System.Drawing.Size(353, 21)
        Me.txtCostoAereo.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCostoAereo.TabIndex = 1
        '
        'txtCostoFluvial
        '
        Me.txtCostoFluvial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoFluvial.Location = New System.Drawing.Point(128, 117)
        Me.txtCostoFluvial.MaxLength = 25
        Me.txtCostoFluvial.Name = "txtCostoFluvial"
        Me.txtCostoFluvial.Size = New System.Drawing.Size(353, 21)
        Me.txtCostoFluvial.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCostoFluvial.TabIndex = 2
        '
        'lblAereo
        '
        Me.lblAereo.Location = New System.Drawing.Point(13, 90)
        Me.lblAereo.Name = "lblAereo"
        Me.lblAereo.Size = New System.Drawing.Size(58, 19)
        Me.lblAereo.TabIndex = 19
        Me.lblAereo.Text = "C.I Aereo:"
        Me.lblAereo.Values.ExtraText = ""
        Me.lblAereo.Values.Image = Nothing
        Me.lblAereo.Values.Text = "C.I Aereo:"
        '
        'lblFluvial
        '
        Me.lblFluvial.Location = New System.Drawing.Point(13, 119)
        Me.lblFluvial.Name = "lblFluvial"
        Me.lblFluvial.Size = New System.Drawing.Size(60, 19)
        Me.lblFluvial.TabIndex = 20
        Me.lblFluvial.Text = "C.I Fluvial:"
        Me.lblFluvial.Values.ExtraText = ""
        Me.lblFluvial.Values.Image = Nothing
        Me.lblFluvial.Values.Text = "C.I Fluvial:"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator2, Me.btnEliminar, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(502, 25)
        Me.tsMenuOpciones.TabIndex = 1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(283, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = " Datos de Cuenta de Imputación por Distribución"
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
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Text = "&Eliminar"
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
        'frmMantenimientoCuentaPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 212)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantenimientoCuentaPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Ordenes por Distribución"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCuentaAfectacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblAfectacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCentroCosto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblTerrestre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCostoAereo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtCostoFluvial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblAereo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFluvial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPorcentaje As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
