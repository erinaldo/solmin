<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaCliente))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.dtgDatos = New System.Windows.Forms.DataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(666, 319)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderGroupFiltro
        '
        Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupFiltro.HeaderVisibleSecondary = False
        Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
        '
        'HeaderGroupFiltro.Panel
        '
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtFiltro)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.btnCerrar)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.btnProcesar)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.btnAceptar)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtgDatos)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(666, 319)
        Me.HeaderGroupFiltro.TabIndex = 6
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = ""
        'Me.HeaderGroupFiltro.ValuesPrimary.Image = Global.SOLMIN_TR.My.Resources.Resources.itunes2aqua
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = "Description"
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(116, 16)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Criterio de Búsqueda"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Criterio de Búsqueda"
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(124, 8)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(396, 21)
        Me.txtFiltro.TabIndex = 13
        '
        'dtgDatos
        '
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgDatos.Location = New System.Drawing.Point(8, 36)
        Me.dtgDatos.MultiSelect = False
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDatos.Size = New System.Drawing.Size(648, 228)
        Me.dtgDatos.TabIndex = 9
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.btnCerrar.Image = Global.SOLMIN_TR.My.Resources.Resources._exit
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(577, 268)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar "
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.btnProcesar.Image = Global.SOLMIN_TR.My.Resources.Resources.button_ok
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(528, 8)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(130, 23)
        Me.btnProcesar.TabIndex = 12
        Me.btnProcesar.Text = "Procesar Busqueda"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.btnAceptar.Image = Global.SOLMIN_TR.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(468, 268)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 23)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmBuscaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 319)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Clientes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
