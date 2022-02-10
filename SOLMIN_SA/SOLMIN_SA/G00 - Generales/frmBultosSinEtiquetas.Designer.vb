<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBultosSinEtiquetas
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
        Me.dgBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dstBulto = New System.Data.DataSet
        Me.Bultos = New System.Data.DataTable
        Me.MCREFFW = New System.Data.DataColumn
        Me.MSTPIMP = New System.Data.DataColumn
        Me.lblDescripcionPedido = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtInput = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPIMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bultos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgBultos)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcionPedido)
        Me.KryptonPanel.Controls.Add(Me.txtInput)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(484, 168)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgBultos
        '
        Me.dgBultos.AllowUserToAddRows = False
        Me.dgBultos.AllowUserToDeleteRows = False
        Me.dgBultos.AllowUserToResizeColumns = False
        Me.dgBultos.AllowUserToResizeRows = False
        Me.dgBultos.AutoGenerateColumns = False
        Me.dgBultos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CREFFW, Me.STPIMPDataGridViewTextBoxColumn})
        Me.dgBultos.DataMember = "Bultos"
        Me.dgBultos.DataSource = Me.dstBulto
        Me.dgBultos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgBultos.Location = New System.Drawing.Point(8, 8)
        Me.dgBultos.MultiSelect = False
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.RowHeadersWidth = 20
        Me.dgBultos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBultos.Size = New System.Drawing.Size(196, 147)
        Me.dgBultos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultos.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dgBultos.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBultos.StateCommon.HeaderRow.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dgBultos.TabIndex = 57
        '
        'dstBulto
        '
        Me.dstBulto.DataSetName = "NewDataSet"
        Me.dstBulto.Tables.AddRange(New System.Data.DataTable() {Me.Bultos})
        '
        'Bultos
        '
        Me.Bultos.Columns.AddRange(New System.Data.DataColumn() {Me.MCREFFW, Me.MSTPIMP})
        Me.Bultos.TableName = "Bultos"
        '
        'MCREFFW
        '
        Me.MCREFFW.ColumnName = "CREFFW"
        Me.MCREFFW.DefaultValue = ""
        '
        'MSTPIMP
        '
        Me.MSTPIMP.ColumnName = "STPIMP"
        Me.MSTPIMP.DefaultValue = ""
        '
        'lblDescripcionPedido
        '
        Me.lblDescripcionPedido.Location = New System.Drawing.Point(210, 13)
        Me.lblDescripcionPedido.Name = "lblDescripcionPedido"
        Me.lblDescripcionPedido.Size = New System.Drawing.Size(13, 16)
        Me.lblDescripcionPedido.TabIndex = 7
        Me.lblDescripcionPedido.Text = "."
        Me.lblDescripcionPedido.Values.ExtraText = ""
        Me.lblDescripcionPedido.Values.Image = Nothing
        Me.lblDescripcionPedido.Values.Text = "."
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(210, 107)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(262, 19)
        Me.txtInput.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtInput, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(286, 132)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(382, 132)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bultos"
        Me.M_CREFFW.Name = "M_CREFFW"
        '
        'STPIMPDataGridViewTextBoxColumn
        '
        Me.STPIMPDataGridViewTextBoxColumn.DataPropertyName = "STPIMP"
        Me.STPIMPDataGridViewTextBoxColumn.HeaderText = "STPIMP"
        Me.STPIMPDataGridViewTextBoxColumn.Name = "STPIMPDataGridViewTextBoxColumn"
        Me.STPIMPDataGridViewTextBoxColumn.Visible = False
        '
        'frmBultosSinEtiquetas
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(484, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBultosSinEtiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bultos sin Etiquetas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgBultos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bultos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents lblDescripcionPedido As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtInput As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dstBulto As System.Data.DataSet
    Friend WithEvents Bultos As System.Data.DataTable
    Friend WithEvents MCREFFW As System.Data.DataColumn
    Friend WithEvents MSTPIMP As System.Data.DataColumn
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents dgBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPIMPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
