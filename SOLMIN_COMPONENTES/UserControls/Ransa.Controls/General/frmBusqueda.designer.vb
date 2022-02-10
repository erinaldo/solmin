<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusqueda))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.grpBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgvBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.cmdAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cmdCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboOperador = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboAtributos = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpBusqueda.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBusqueda.Panel.SuspendLayout()
        Me.grpBusqueda.SuspendLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpBusqueda)
        Me.KryptonPanel.Controls.Add(Me.cmdAceptar)
        Me.KryptonPanel.Controls.Add(Me.cmdCancelar)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeader3)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeader4)
        Me.KryptonPanel.Controls.Add(Me.cboOperador)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeader1)
        Me.KryptonPanel.Controls.Add(Me.cboAtributos)
        Me.KryptonPanel.Controls.Add(Me.txtBusqueda)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(486, 379)
        Me.KryptonPanel.TabIndex = 1
        '
        'grpBusqueda
        '
        Me.grpBusqueda.Location = New System.Drawing.Point(8, 55)
        Me.grpBusqueda.Name = "grpBusqueda"
        '
        'grpBusqueda.Panel
        '
        Me.grpBusqueda.Panel.Controls.Add(Me.dgvBusqueda)
        Me.grpBusqueda.Size = New System.Drawing.Size(471, 287)
        Me.grpBusqueda.TabIndex = 1
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToResizeRows = False
        Me.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBusqueda.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.dgvBusqueda.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile
        Me.dgvBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.dgvBusqueda.MultiSelect = False
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.RowHeadersVisible = False
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(469, 285)
        Me.dgvBusqueda.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile
        Me.dgvBusqueda.TabIndex = 0
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(296, 349)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 25)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.Values.ExtraText = ""
        Me.cmdAceptar.Values.Image = CType(resources.GetObject("cmdAceptar.Values.Image"), System.Drawing.Image)
        Me.cmdAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdAceptar.Values.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(389, 349)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 25)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.Values.ExtraText = ""
        Me.cmdCancelar.Values.Image = CType(resources.GetObject("cmdCancelar.Values.Image"), System.Drawing.Image)
        Me.cmdCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdCancelar.Values.Text = "Cancelar"
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.Location = New System.Drawing.Point(326, 8)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(153, 21)
        Me.KryptonHeader3.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 12
        Me.KryptonHeader3.Text = "   Valor Búsqueda"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "   Valor Búsqueda"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.Location = New System.Drawing.Point(167, 8)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(154, 21)
        Me.KryptonHeader4.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 11
        Me.KryptonHeader4.Text = "      Operador"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "      Operador"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'cboOperador
        '
        Me.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperador.DropDownWidth = 122
        Me.cboOperador.FormattingEnabled = False
        Me.cboOperador.ItemHeight = 13
        Me.cboOperador.Items.AddRange(New Object() {"IGUAL A", "INICIA EN", "DISTINTO A", "TERMINA EN", "CONTIENE EL TEXTO"})
        Me.cboOperador.Location = New System.Drawing.Point(167, 28)
        Me.cboOperador.Name = "cboOperador"
        Me.cboOperador.Size = New System.Drawing.Size(154, 21)
        Me.cboOperador.TabIndex = 3
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.Location = New System.Drawing.Point(8, 8)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(154, 21)
        Me.KryptonHeader1.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 10
        Me.KryptonHeader1.Text = "      Atributo"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "      Atributo"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'cboAtributos
        '
        Me.cboAtributos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtributos.DropDownWidth = 122
        Me.cboAtributos.FormattingEnabled = False
        Me.cboAtributos.ItemHeight = 13
        Me.cboAtributos.Location = New System.Drawing.Point(8, 29)
        Me.cboAtributos.Name = "cboAtributos"
        Me.cboAtributos.Size = New System.Drawing.Size(154, 21)
        Me.cboAtributos.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(326, 29)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(153, 19)
        Me.txtBusqueda.TabIndex = 1
        '
        'frmBusqueda
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(486, 379)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.grpBusqueda.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBusqueda.Panel.ResumeLayout(False)
        CType(Me.grpBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBusqueda.ResumeLayout(False)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents grpBusqueda As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgvBusqueda As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents cmdAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboOperador As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboAtributos As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
