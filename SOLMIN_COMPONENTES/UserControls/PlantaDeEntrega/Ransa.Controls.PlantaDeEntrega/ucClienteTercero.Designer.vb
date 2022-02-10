<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClienteTercero
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
        Me.txtRuc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtgPlantaDeEntrega = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTDRPRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSTPORL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCPRPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgPlantaDeEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtRuc)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.dtgPlantaDeEntrega)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion1)
        Me.KryptonPanel.Controls.Add(Me.btnSalir)
        Me.KryptonPanel.Controls.Add(Me.txtCodigo)
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.lblCodigo)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcion)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(599, 377)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuc.CausesValidation = False
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRuc, True)
        Me.txtRuc.Location = New System.Drawing.Point(89, 32)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(498, 21)
        Me.txtRuc.TabIndex = 1
        Me.TypeValidator.SetTypes(Me.txtRuc, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 37)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 16)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Text = "RUC : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "RUC : "
        '
        'dtgPlantaDeEntrega
        '
        Me.dtgPlantaDeEntrega.AllowUserToAddRows = False
        Me.dtgPlantaDeEntrega.AllowUserToDeleteRows = False
        Me.dtgPlantaDeEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPlantaDeEntrega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCPRVCL, Me.PSTPRVCL, Me.PSTDRPRC, Me.PNNRUCPR, Me.PSSTPORL, Me.PSCPRPCL})
        Me.dtgPlantaDeEntrega.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgPlantaDeEntrega.Location = New System.Drawing.Point(0, 117)
        Me.dtgPlantaDeEntrega.Name = "dtgPlantaDeEntrega"
        Me.dtgPlantaDeEntrega.ReadOnly = True
        Me.dtgPlantaDeEntrega.Size = New System.Drawing.Size(599, 235)
        Me.dtgPlantaDeEntrega.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPlantaDeEntrega.TabIndex = 4
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "Cod. Cliente"
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.Width = 92
        '
        'PSTPRVCL
        '
        Me.PSTPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTPRVCL.DataPropertyName = "PSTPRVCL"
        Me.PSTPRVCL.HeaderText = "Descripción"
        Me.PSTPRVCL.Name = "PSTPRVCL"
        Me.PSTPRVCL.ReadOnly = True
        Me.PSTPRVCL.Width = 96
        '
        'PSTDRPRC
        '
        Me.PSTDRPRC.DataPropertyName = "PSTDRPRC"
        Me.PSTDRPRC.HeaderText = "Direción"
        Me.PSTDRPRC.Name = "PSTDRPRC"
        Me.PSTDRPRC.ReadOnly = True
        Me.PSTDRPRC.Width = 170
        '
        'PNNRUCPR
        '
        Me.PNNRUCPR.DataPropertyName = "PNNRUCPR"
        Me.PNNRUCPR.HeaderText = "Ruc"
        Me.PNNRUCPR.Name = "PNNRUCPR"
        Me.PNNRUCPR.ReadOnly = True
        '
        'PSSTPORL
        '
        Me.PSSTPORL.DataPropertyName = "PSSTPORL"
        Me.PSSTPORL.HeaderText = "Tipo de Relación"
        Me.PSSTPORL.Name = "PSSTPORL"
        Me.PSSTPORL.ReadOnly = True
        '
        'PSCPRPCL
        '
        Me.PSCPRPCL.DataPropertyName = "PSCPRPCL"
        Me.PSCPRPCL.HeaderText = "Código Tercero"
        Me.PSCPRPCL.Name = "PSCPRPCL"
        Me.PSCPRPCL.ReadOnly = True
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 352)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(599, 25)
        Me.UcPaginacion1.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(528, 86)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 25)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.CausesValidation = False
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigo, True)
        Me.txtCodigo.Location = New System.Drawing.Point(89, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(498, 21)
        Me.txtCodigo.TabIndex = 0
        Me.TypeValidator.SetTypes(Me.txtCodigo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(89, 92)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(119, 19)
        Me.chkMientrasEscribe.TabIndex = 7
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(3, 14)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(54, 16)
        Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "CODIGO : "
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "CODIGO : "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 59)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "DESCRIPCIÓN : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CausesValidation = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcion, True)
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(498, 21)
        Me.txtDescripcion.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtDescripcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNCCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PNCPLNCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod. Planta "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSTCMPPL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSTDRCPL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ucClienteTercero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(599, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "ucClienteTercero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar:"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgPlantaDeEntrega, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents dtgPlantaDeEntrega As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSTPORL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCPRPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtRuc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
