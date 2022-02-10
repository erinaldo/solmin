<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlantaDeEntrega
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgPlantaDeEntrega = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNCPLNCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTCMPPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTDRCPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBIGEO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUBGEO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgPlantaDeEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
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
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(735, 464)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgPlantaDeEntrega
        '
        Me.dtgPlantaDeEntrega.AllowUserToAddRows = False
        Me.dtgPlantaDeEntrega.AllowUserToDeleteRows = False
        Me.dtgPlantaDeEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPlantaDeEntrega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCCLNT, Me.PNCPLNCL, Me.PSTCMPPL, Me.PSTDRCPL, Me.CPRPCL, Me.UBIGEO, Me.CUBGEO})
        Me.dtgPlantaDeEntrega.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgPlantaDeEntrega.Location = New System.Drawing.Point(0, 108)
        Me.dtgPlantaDeEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgPlantaDeEntrega.Name = "dtgPlantaDeEntrega"
        Me.dtgPlantaDeEntrega.ReadOnly = True
        Me.dtgPlantaDeEntrega.Size = New System.Drawing.Size(735, 325)
        Me.dtgPlantaDeEntrega.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPlantaDeEntrega.TabIndex = 10
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 433)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(735, 31)
        Me.UcPaginacion1.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(640, 75)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(79, 31)
        Me.btnSalir.TabIndex = 9
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
        Me.txtCodigo.Location = New System.Drawing.Point(119, 11)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(600, 26)
        Me.txtCodigo.TabIndex = 2
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(119, 75)
        Me.chkMientrasEscribe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(155, 24)
        Me.chkMientrasEscribe.TabIndex = 7
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(4, 15)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(65, 20)
        Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "CODIGO : "
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "CODIGO : "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 46)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 20)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(119, 42)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(600, 26)
        Me.txtDescripcion.TabIndex = 4
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
        'PNCCLNT
        '
        Me.PNCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "Cod. Cliente"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Width = 122
        '
        'PNCPLNCL
        '
        Me.PNCPLNCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PNCPLNCL.DataPropertyName = "PNCPLNCL"
        Me.PNCPLNCL.HeaderText = "Cod. Planta "
        Me.PNCPLNCL.Name = "PNCPLNCL"
        Me.PNCPLNCL.ReadOnly = True
        Me.PNCPLNCL.Width = 121
        '
        'PSTCMPPL
        '
        Me.PSTCMPPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTCMPPL.DataPropertyName = "PSTCMPPL"
        Me.PSTCMPPL.HeaderText = "Descripción"
        Me.PSTCMPPL.Name = "PSTCMPPL"
        Me.PSTCMPPL.ReadOnly = True
        Me.PSTCMPPL.Width = 120
        '
        'PSTDRCPL
        '
        Me.PSTDRCPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTDRCPL.DataPropertyName = "PSTDRCPL"
        Me.PSTDRCPL.HeaderText = "Direción"
        Me.PSTDRCPL.Name = "PSTDRCPL"
        Me.PSTDRCPL.ReadOnly = True
        Me.PSTDRCPL.Width = 98
        '
        'CPRPCL
        '
        Me.CPRPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRPCL.DataPropertyName = "PSCPRPCL"
        Me.CPRPCL.HeaderText = "Codigo del proveedor - Cliente"
        Me.CPRPCL.Name = "CPRPCL"
        Me.CPRPCL.ReadOnly = True
        Me.CPRPCL.Width = 185
        '
        'UBIGEO
        '
        Me.UBIGEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBIGEO.DataPropertyName = "PSUBIGEO"
        Me.UBIGEO.HeaderText = "Ubigeo"
        Me.UBIGEO.Name = "UBIGEO"
        Me.UBIGEO.ReadOnly = True
        Me.UBIGEO.Width = 91
        '
        'CUBGEO
        '
        Me.CUBGEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUBGEO.DataPropertyName = "PNCUBGEO"
        Me.CUBGEO.HeaderText = "CUBGEO"
        Me.CUBGEO.Name = "CUBGEO"
        Me.CUBGEO.ReadOnly = True
        Me.CUBGEO.Visible = False
        Me.CUBGEO.Width = 99
        '
        'ucPlantaDeEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(735, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucPlantaDeEntrega"
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
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPLNCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMPPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRCPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBIGEO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUBGEO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
