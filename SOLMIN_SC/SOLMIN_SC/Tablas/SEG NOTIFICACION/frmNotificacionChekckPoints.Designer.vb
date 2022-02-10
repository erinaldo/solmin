<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificacionChekckPoints
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtOrden = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.UcCheckpoint = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoCheckpoint = New System.Windows.Forms.ComboBox
        Me.txtDescripNotificacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbNotificar = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbVisualizar = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(613, 168)
        Me.KryptonPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtOrden)
        Me.Panel1.Controls.Add(Me.UcCheckpoint)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Controls.Add(Me.cmbTipoCheckpoint)
        Me.Panel1.Controls.Add(Me.txtDescripNotificacion)
        Me.Panel1.Controls.Add(Me.cmbNotificar)
        Me.Panel1.Controls.Add(Me.cmbVisualizar)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 143)
        Me.Panel1.TabIndex = 0
        '
        'txtOrden
        '
        Me.txtOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtOrden.BackColor = System.Drawing.Color.Transparent
        Me.txtOrden.Location = New System.Drawing.Point(122, 101)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.NumerosDecimales = 0
        Me.txtOrden.NumerosEnteros = 4
        Me.txtOrden.Obligatorio = False
        Me.txtOrden.Size = New System.Drawing.Size(58, 22)
        Me.txtOrden.TabIndex = 4
        '
        'UcCheckpoint
        '
        Me.UcCheckpoint.BackColor = System.Drawing.Color.Transparent
        Me.UcCheckpoint.DataSource = Nothing
        Me.UcCheckpoint.DispleyMember = ""
        Me.UcCheckpoint.Etiquetas_Form = Nothing
        Me.UcCheckpoint.ListColumnas = Nothing
        Me.UcCheckpoint.Location = New System.Drawing.Point(300, 16)
        Me.UcCheckpoint.Name = "UcCheckpoint"
        Me.UcCheckpoint.Obligatorio = False
        Me.UcCheckpoint.PopupHeight = 0
        Me.UcCheckpoint.PopupWidth = 0
        Me.UcCheckpoint.Size = New System.Drawing.Size(299, 25)
        Me.UcCheckpoint.TabIndex = 0
        Me.UcCheckpoint.ValueMember = ""
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(12, 16)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel10.TabIndex = 75
        Me.KryptonLabel10.Text = "Checkpoint :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Checkpoint :"
        '
        'cmbTipoCheckpoint
        '
        Me.cmbTipoCheckpoint.BackColor = System.Drawing.Color.White
        Me.cmbTipoCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCheckpoint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCheckpoint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoCheckpoint.FormattingEnabled = True
        Me.cmbTipoCheckpoint.Location = New System.Drawing.Point(122, 16)
        Me.cmbTipoCheckpoint.Name = "cmbTipoCheckpoint"
        Me.cmbTipoCheckpoint.Size = New System.Drawing.Size(172, 22)
        Me.cmbTipoCheckpoint.TabIndex = 0
        '
        'txtDescripNotificacion
        '
        Me.txtDescripNotificacion.Location = New System.Drawing.Point(122, 46)
        Me.txtDescripNotificacion.MaxLength = 60
        Me.txtDescripNotificacion.Name = "txtDescripNotificacion"
        Me.txtDescripNotificacion.Size = New System.Drawing.Size(361, 21)
        Me.txtDescripNotificacion.TabIndex = 1
        '
        'cmbNotificar
        '
        Me.cmbNotificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNotificar.DropDownWidth = 121
        Me.cmbNotificar.FormattingEnabled = False
        Me.cmbNotificar.ItemHeight = 13
        Me.cmbNotificar.Location = New System.Drawing.Point(351, 74)
        Me.cmbNotificar.Name = "cmbNotificar"
        Me.cmbNotificar.Size = New System.Drawing.Size(132, 21)
        Me.cmbNotificar.TabIndex = 3
        '
        'cmbVisualizar
        '
        Me.cmbVisualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVisualizar.DropDownWidth = 131
        Me.cmbVisualizar.FormattingEnabled = False
        Me.cmbVisualizar.ItemHeight = 13
        Me.cmbVisualizar.Items.AddRange(New Object() {"Real", "Estimado"})
        Me.cmbVisualizar.Location = New System.Drawing.Point(122, 74)
        Me.cmbVisualizar.Name = "cmbVisualizar"
        Me.cmbVisualizar.Size = New System.Drawing.Size(131, 21)
        Me.cmbVisualizar.TabIndex = 2
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 102)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel6.TabIndex = 68
        Me.KryptonLabel6.Text = "Orden :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Orden :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 74)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel5.TabIndex = 67
        Me.KryptonLabel5.Text = "Visualizar :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Visualizar :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 46)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(105, 19)
        Me.KryptonLabel4.TabIndex = 66
        Me.KryptonLabel4.Text = "Descripción Notif. :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Descripción Notif. :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(280, 74)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel1.TabIndex = 10
        Me.KryptonLabel1.Text = "Notificar   :   "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Notificar   :   "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(613, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'frmNotificacionChekckPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmNotificacionChekckPoints"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CheckPoint Notificación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNotificar As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbVisualizar As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtDescripNotificacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UcCheckpoint As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoCheckpoint As System.Windows.Forms.ComboBox
    Friend WithEvents txtOrden As Ransa.Utilitario.UCtxtSoloDecimales
End Class
