<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamiliaSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFamiliaSDS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblMSJCrearFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgFamilias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.F_CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtFamilia = New System.Data.DataTable
        Me.FCFMCLR = New System.Data.DataColumn
        Me.FTFMCLR = New System.Data.DataColumn
        Me.FSESTRG = New System.Data.DataColumn
        Me.FSITUAC = New System.Data.DataColumn
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.lblMSJCrearFamilia)
        Me.KryptonPanel.Controls.Add(Me.dgFamilias)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(487, 520)
        Me.KryptonPanel.TabIndex = 0
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
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 477)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(154, 14)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Text = "( DEL ) - ELIMINA EL REGISTRO"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "( DEL ) - ELIMINA EL REGISTRO"
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
        Me.btnCancelar.TabIndex = 7
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
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Location = New System.Drawing.Point(349, 457)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 51)
        Me.btnGuardar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnGuardar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGuardar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = CType(resources.GetObject("btnGuardar.Values.Image"), System.Drawing.Image)
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "&Guardar"
        '
        'lblMSJCrearFamilia
        '
        Me.lblMSJCrearFamilia.Location = New System.Drawing.Point(12, 457)
        Me.lblMSJCrearFamilia.Name = "lblMSJCrearFamilia"
        Me.lblMSJCrearFamilia.Size = New System.Drawing.Size(150, 14)
        Me.lblMSJCrearFamilia.StateCommon.ShortText.Color1 = System.Drawing.Color.Green
        Me.lblMSJCrearFamilia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSJCrearFamilia.TabIndex = 4
        Me.lblMSJCrearFamilia.Text = "( F6 ) - CREAR NUEVA FAMILIA"
        Me.lblMSJCrearFamilia.Values.ExtraText = ""
        Me.lblMSJCrearFamilia.Values.Image = Nothing
        Me.lblMSJCrearFamilia.Values.Text = "( F6 ) - CREAR NUEVA FAMILIA"
        '
        'dgFamilias
        '
        Me.dgFamilias.AllowUserToAddRows = False
        Me.dgFamilias.AllowUserToDeleteRows = False
        Me.dgFamilias.AllowUserToResizeColumns = False
        Me.dgFamilias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgFamilias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgFamilias.AutoGenerateColumns = False
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F_CFMCLR, Me.F_TFMCLR, Me.F_SESTRG, Me.F_SITUAC})
        Me.dgFamilias.DataMember = "dtFamilia"
        Me.dgFamilias.DataSource = Me.dstMercaderia
        Me.dgFamilias.Location = New System.Drawing.Point(12, 47)
        Me.dgFamilias.MultiSelect = False
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.RowHeadersWidth = 20
        Me.dgFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgFamilias.Size = New System.Drawing.Size(463, 403)
        Me.dgFamilias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgFamilias.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgFamilias.TabIndex = 3
        '
        'F_CFMCLR
        '
        Me.F_CFMCLR.DataPropertyName = "CFMCLR"
        Me.F_CFMCLR.HeaderText = "Familia"
        Me.F_CFMCLR.MaxInputLength = 3
        Me.F_CFMCLR.Name = "F_CFMCLR"
        Me.F_CFMCLR.ReadOnly = True
        Me.F_CFMCLR.Width = 68
        '
        'F_TFMCLR
        '
        Me.F_TFMCLR.DataPropertyName = "TFMCLR"
        Me.F_TFMCLR.HeaderText = "Descripción"
        Me.F_TFMCLR.MaxInputLength = 30
        Me.F_TFMCLR.Name = "F_TFMCLR"
        Me.F_TFMCLR.Width = 250
        '
        'F_SESTRG
        '
        Me.F_SESTRG.DataPropertyName = "SESTRG"
        Me.F_SESTRG.HeaderText = "Situación"
        Me.F_SESTRG.Name = "F_SESTRG"
        Me.F_SESTRG.ReadOnly = True
        Me.F_SESTRG.Visible = False
        Me.F_SESTRG.Width = 61
        '
        'F_SITUAC
        '
        Me.F_SITUAC.DataPropertyName = "SITUAC"
        Me.F_SITUAC.HeaderText = "Situación"
        Me.F_SITUAC.Name = "F_SITUAC"
        Me.F_SITUAC.ReadOnly = True
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtFamilia})
        '
        'dtFamilia
        '
        Me.dtFamilia.Columns.AddRange(New System.Data.DataColumn() {Me.FCFMCLR, Me.FTFMCLR, Me.FSESTRG, Me.FSITUAC})
        Me.dtFamilia.TableName = "dtFamilia"
        '
        'FCFMCLR
        '
        Me.FCFMCLR.ColumnName = "CFMCLR"
        '
        'FTFMCLR
        '
        Me.FTFMCLR.ColumnName = "TFMCLR"
        '
        'FSESTRG
        '
        Me.FSESTRG.ColumnName = "SESTRG"
        '
        'FSITUAC
        '
        Me.FSITUAC.ColumnName = "SITUAC"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmFamiliaSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFamiliaSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Familia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFamilia, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgFamilias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtFamilia As System.Data.DataTable
    Friend WithEvents FCFMCLR As System.Data.DataColumn
    Friend WithEvents FTFMCLR As System.Data.DataColumn
    Friend WithEvents FSESTRG As System.Data.DataColumn
    Friend WithEvents FSITUAC As System.Data.DataColumn
    Friend WithEvents lblMSJCrearFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents F_CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
