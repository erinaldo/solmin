<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoSDS))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMSJCrearFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dgGrupos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.G_CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtGrupo = New System.Data.DataTable
        Me.GCGRCLR = New System.Data.DataColumn
        Me.GTGRCLR = New System.Data.DataColumn
        Me.GSESTRG = New System.Data.DataColumn
        Me.GSITUAC = New System.Data.DataColumn
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.lblMSJCrearFamilia)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.dgGrupos)
        Me.KryptonPanel.Controls.Add(Me.txtFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(487, 520)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 477)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(154, 14)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Text = "( DEL ) - ELIMINA EL REGISTRO"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "( DEL ) - ELIMINA EL REGISTRO"
        '
        'lblMSJCrearFamilia
        '
        Me.lblMSJCrearFamilia.Location = New System.Drawing.Point(12, 457)
        Me.lblMSJCrearFamilia.Name = "lblMSJCrearFamilia"
        Me.lblMSJCrearFamilia.Size = New System.Drawing.Size(150, 14)
        Me.lblMSJCrearFamilia.StateCommon.ShortText.Color1 = System.Drawing.Color.Green
        Me.lblMSJCrearFamilia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSJCrearFamilia.TabIndex = 6
        Me.lblMSJCrearFamilia.Text = "( F6 ) - CREAR NUEVA FAMILIA"
        Me.lblMSJCrearFamilia.Values.ExtraText = ""
        Me.lblMSJCrearFamilia.Values.Image = Nothing
        Me.lblMSJCrearFamilia.Values.Text = "( F6 ) - CREAR NUEVA FAMILIA"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(415, 457)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 51)
        Me.btnCancelar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCancelar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCancelar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(349, 457)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 51)
        Me.btnGuardar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnGuardar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGuardar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = CType(resources.GetObject("btnGuardar.Values.Image"), System.Drawing.Image)
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "&Guardar"
        '
        'dgGrupos
        '
        Me.dgGrupos.AllowUserToAddRows = False
        Me.dgGrupos.AllowUserToDeleteRows = False
        Me.dgGrupos.AllowUserToResizeColumns = False
        Me.dgGrupos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGrupos.AutoGenerateColumns = False
        Me.dgGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.G_CGRCLR, Me.G_TGRCLR, Me.G_SESTRG, Me.G_SITUAC})
        Me.dgGrupos.DataMember = "dtGrupo"
        Me.dgGrupos.DataSource = Me.dstMercaderia
        Me.dgGrupos.Location = New System.Drawing.Point(12, 63)
        Me.dgGrupos.MultiSelect = False
        Me.dgGrupos.Name = "dgGrupos"
        Me.dgGrupos.RowHeadersWidth = 20
        Me.dgGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgGrupos.Size = New System.Drawing.Size(463, 388)
        Me.dgGrupos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGrupos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGrupos.TabIndex = 5
        '
        'G_CGRCLR
        '
        Me.G_CGRCLR.DataPropertyName = "CGRCLR"
        Me.G_CGRCLR.HeaderText = "Grupo"
        Me.G_CGRCLR.MaxInputLength = 4
        Me.G_CGRCLR.Name = "G_CGRCLR"
        Me.G_CGRCLR.Width = 68
        '
        'G_TGRCLR
        '
        Me.G_TGRCLR.DataPropertyName = "TGRCLR"
        Me.G_TGRCLR.HeaderText = "Descripción"
        Me.G_TGRCLR.MaxInputLength = 30
        Me.G_TGRCLR.Name = "G_TGRCLR"
        Me.G_TGRCLR.Width = 250
        '
        'G_SESTRG
        '
        Me.G_SESTRG.DataPropertyName = "SESTRG"
        Me.G_SESTRG.HeaderText = "Situación"
        Me.G_SESTRG.Name = "G_SESTRG"
        Me.G_SESTRG.Visible = False
        Me.G_SESTRG.Width = 61
        '
        'G_SITUAC
        '
        Me.G_SITUAC.DataPropertyName = "SITUAC"
        Me.G_SITUAC.HeaderText = "Situación"
        Me.G_SITUAC.Name = "G_SITUAC"
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtGrupo})
        '
        'dtGrupo
        '
        Me.dtGrupo.Columns.AddRange(New System.Data.DataColumn() {Me.GCGRCLR, Me.GTGRCLR, Me.GSESTRG, Me.GSITUAC})
        Me.dtGrupo.TableName = "dtGrupo"
        '
        'GCGRCLR
        '
        Me.GCGRCLR.ColumnName = "CGRCLR"
        '
        'GTGRCLR
        '
        Me.GTGRCLR.ColumnName = "TGRCLR"
        '
        'GSESTRG
        '
        Me.GSESTRG.ColumnName = "SESTRG"
        '
        'GSITUAC
        '
        Me.GSITUAC.ColumnName = "SITUAC"
        '
        'txtFamilia
        '
        Me.txtFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaFamiliaListar})
        Me.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtFamilia, True)
        Me.txtFamilia.Location = New System.Drawing.Point(70, 37)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(405, 19)
        Me.txtFamilia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFamilia.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtFamilia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaFamiliaListar
        '
        Me.bsaFamiliaListar.ExtraText = ""
        Me.bsaFamiliaListar.Image = Nothing
        Me.bsaFamiliaListar.Text = ""
        Me.bsaFamiliaListar.ToolTipImage = Nothing
        Me.bsaFamiliaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaFamiliaListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(12, 40)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(53, 16)
        Me.lblFamilia.TabIndex = 3
        Me.lblFamilia.Text = "Familia : "
        Me.lblFamilia.Values.ExtraText = ""
        Me.lblFamilia.Values.Image = Nothing
        Me.lblFamilia.Values.Text = "Familia : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(12, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(70, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.Size = New System.Drawing.Size(405, 19)
        Me.txtCliente.TabIndex = 2
        '
        'frmGrupoSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGrupoSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGrupo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtFamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaFamiliaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgGrupos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtGrupo As System.Data.DataTable
    Friend WithEvents GCGRCLR As System.Data.DataColumn
    Friend WithEvents GTGRCLR As System.Data.DataColumn
    Friend WithEvents GSESTRG As System.Data.DataColumn
    Friend WithEvents GSITUAC As System.Data.DataColumn
    Friend WithEvents G_CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMSJCrearFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
