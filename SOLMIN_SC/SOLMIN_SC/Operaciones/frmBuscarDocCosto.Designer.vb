<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDocCosto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgDocumentosAdjuntos = New System.Windows.Forms.DataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgDocumentosAdjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(642, 316)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnCancelar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgDocumentosAdjuntos)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(642, 316)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 41
        Me.KryptonHeaderGroup1.Text = "Documentos "
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Documentos "
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = Nothing
        Me.btnGuardar.Text = "Guardar    |"
        Me.btnGuardar.ToolTipBody = "Guardar Documento"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "9FF5E8F6723044089FF5E8F672304408"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Nothing
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipBody = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "75DA61B3A28E4A3B75DA61B3A28E4A3B"
        '
        'dtgDocumentosAdjuntos
        '
        Me.dtgDocumentosAdjuntos.AllowUserToAddRows = False
        Me.dtgDocumentosAdjuntos.AllowUserToDeleteRows = False
        Me.dtgDocumentosAdjuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDocumentosAdjuntos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDocumentosAdjuntos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDocumentosAdjuntos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDocumentosAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDocumentosAdjuntos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDocumentosAdjuntos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDocumentosAdjuntos.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgDocumentosAdjuntos.Location = New System.Drawing.Point(0, 0)
        Me.dtgDocumentosAdjuntos.MultiSelect = False
        Me.dtgDocumentosAdjuntos.Name = "dtgDocumentosAdjuntos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDocumentosAdjuntos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDocumentosAdjuntos.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDocumentosAdjuntos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgDocumentosAdjuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDocumentosAdjuntos.Size = New System.Drawing.Size(640, 285)
        Me.dtgDocumentosAdjuntos.TabIndex = 37
        '
        'frmBuscarDocCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 350)
        Me.Name = "frmBuscarDocCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Referencia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgDocumentosAdjuntos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgDocumentosAdjuntos As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
