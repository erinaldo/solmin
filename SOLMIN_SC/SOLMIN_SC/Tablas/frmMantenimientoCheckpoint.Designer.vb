<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCheckpoint
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.UcCheckpoint = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCheckPoint = New System.Windows.Forms.TextBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNomSeguimiento = New System.Windows.Forms.TextBox
        Me.cmbTipoCheckpoint = New System.Windows.Forms.ComboBox
        Me.chbEstadoSeguimiento = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup8.Panel.SuspendLayout()
        Me.KryptonHeaderGroup8.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(574, 224)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup8)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(574, 224)
        Me.KryptonSplitContainer1.SplitterDistance = 25
        Me.KryptonSplitContainer1.TabIndex = 35
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(574, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel1.Tag = "Checkpoint"
        Me.ToolStripLabel1.Text = "Checkpoint"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.fileexport
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonHeaderGroup8
        '
        Me.KryptonHeaderGroup8.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
        '
        'KryptonHeaderGroup8.Panel
        '
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.UcCheckpoint)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.txtOrdenCheckPoint)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.txtNomSeguimiento)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.cmbTipoCheckpoint)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.chbEstadoSeguimiento)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.cmbDivision)
        Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(574, 194)
        Me.KryptonHeaderGroup8.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup8.TabIndex = 0
        Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
        '
        'UcCheckpoint
        '
        Me.UcCheckpoint.BackColor = System.Drawing.Color.Transparent
        Me.UcCheckpoint.DataSource = Nothing
        Me.UcCheckpoint.DispleyMember = ""
        Me.UcCheckpoint.ListColumnas = Nothing
        Me.UcCheckpoint.Location = New System.Drawing.Point(130, 84)
        Me.UcCheckpoint.Name = "UcCheckpoint"
        Me.UcCheckpoint.Obligatorio = False
        Me.UcCheckpoint.Size = New System.Drawing.Size(299, 25)
        Me.UcCheckpoint.TabIndex = 62
        Me.UcCheckpoint.ValueMember = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel2.TabIndex = 60
        Me.KryptonLabel2.Text = "División:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "División:"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(11, 53)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(35, 19)
        Me.KryptonLabel11.TabIndex = 0
        Me.KryptonLabel11.Text = "Tipo:"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Tipo:"
        '
        'txtOrdenCheckPoint
        '
        Me.txtOrdenCheckPoint.AcceptsReturn = True
        Me.txtOrdenCheckPoint.BackColor = System.Drawing.Color.White
        Me.txtOrdenCheckPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCheckPoint.Location = New System.Drawing.Point(130, 150)
        Me.txtOrdenCheckPoint.MaxLength = 3
        Me.txtOrdenCheckPoint.Name = "txtOrdenCheckPoint"
        Me.txtOrdenCheckPoint.Size = New System.Drawing.Size(71, 18)
        Me.txtOrdenCheckPoint.TabIndex = 7
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(11, 84)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel10.TabIndex = 2
        Me.KryptonLabel10.Text = "Checkpoint :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Checkpoint :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 150)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Orden:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Orden:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 119)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(105, 19)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Desc. Seguimiento:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Desc. Seguimiento:"
        '
        'txtNomSeguimiento
        '
        Me.txtNomSeguimiento.AcceptsReturn = True
        Me.txtNomSeguimiento.BackColor = System.Drawing.Color.White
        Me.txtNomSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomSeguimiento.Location = New System.Drawing.Point(130, 119)
        Me.txtNomSeguimiento.MaxLength = 60
        Me.txtNomSeguimiento.Name = "txtNomSeguimiento"
        Me.txtNomSeguimiento.Size = New System.Drawing.Size(421, 18)
        Me.txtNomSeguimiento.TabIndex = 5
        '
        'cmbTipoCheckpoint
        '
        Me.cmbTipoCheckpoint.BackColor = System.Drawing.Color.White
        Me.cmbTipoCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCheckpoint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCheckpoint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoCheckpoint.FormattingEnabled = True
        Me.cmbTipoCheckpoint.Location = New System.Drawing.Point(130, 51)
        Me.cmbTipoCheckpoint.Name = "cmbTipoCheckpoint"
        Me.cmbTipoCheckpoint.Size = New System.Drawing.Size(299, 22)
        Me.cmbTipoCheckpoint.TabIndex = 1
        '
        'chbEstadoSeguimiento
        '
        Me.chbEstadoSeguimiento.Checked = False
        Me.chbEstadoSeguimiento.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chbEstadoSeguimiento.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chbEstadoSeguimiento.Location = New System.Drawing.Point(255, 148)
        Me.chbEstadoSeguimiento.Name = "chbEstadoSeguimiento"
        Me.chbEstadoSeguimiento.Size = New System.Drawing.Size(161, 19)
        Me.chbEstadoSeguimiento.TabIndex = 8
        Me.chbEstadoSeguimiento.Text = "Mostrar en el Seguimiento :             "
        Me.chbEstadoSeguimiento.Values.ExtraText = ""
        Me.chbEstadoSeguimiento.Values.Image = Nothing
        Me.chbEstadoSeguimiento.Values.Text = "Mostrar en el Seguimiento :             "
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(130, 17)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.obeDivision = Nothing
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(299, 30)
        Me.cmbDivision.TabIndex = 63
        Me.cmbDivision.Usuario = ""
        '
        'frmMantenimientoCheckpoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 224)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantenimientoCheckpoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Checkpoint"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup8.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtOrdenCheckPoint As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoCheckpoint As System.Windows.Forms.ComboBox
    Friend WithEvents chbEstadoSeguimiento As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtNomSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCheckpoint As Ransa.Utilitario.ucAyuda
End Class
