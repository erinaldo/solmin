<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresionMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpresionMasiva))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaVistaPreviaGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnPrueba = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dstDespacho = New System.Data.DataSet
        Me.dtGuiaSalida = New System.Data.DataTable
        Me.NRGUSA = New System.Data.DataColumn
        Me.NMNFTF = New System.Data.DataColumn
        Me.FSLDAL = New System.Data.DataColumn
        Me.SMTRCP = New System.Data.DataColumn
        Me.MOTREC = New System.Data.DataColumn
        Me.STPDSP = New System.Data.DataColumn
        Me.TIPDES = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.SITUAC = New System.Data.DataColumn
        Me.CTRSPT = New System.Data.DataColumn
        Me.NPLCUN = New System.Data.DataColumn
        Me.NPLCAC = New System.Data.DataColumn
        Me.CBRCNT = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GR_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SMTGRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaRemision.Panel.SuspendLayout()
        Me.hgGuiaRemision.SuspendLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGuiaSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgGuiaRemision)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(536, 320)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgGuiaRemision
        '
        Me.hgGuiaRemision.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaVistaPreviaGR, Me.bsaCerrar, Me.btnPrueba})
        Me.hgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGuiaRemision.HeaderVisibleSecondary = False
        Me.hgGuiaRemision.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaRemision.Name = "hgGuiaRemision"
        '
        'hgGuiaRemision.Panel
        '
        Me.hgGuiaRemision.Panel.Controls.Add(Me.dgGuiasRemision)
        Me.hgGuiaRemision.Size = New System.Drawing.Size(536, 320)
        Me.hgGuiaRemision.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaRemision.TabIndex = 1
        Me.hgGuiaRemision.Text = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Description = ""
        Me.hgGuiaRemision.ValuesPrimary.Heading = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Image = Nothing
        Me.hgGuiaRemision.ValuesSecondary.Description = ""
        Me.hgGuiaRemision.ValuesSecondary.Heading = "Description"
        Me.hgGuiaRemision.ValuesSecondary.Image = Nothing
        '
        'bsaVistaPreviaGR
        '
        Me.bsaVistaPreviaGR.ExtraText = ""
        Me.bsaVistaPreviaGR.Image = CType(resources.GetObject("bsaVistaPreviaGR.Image"), System.Drawing.Image)
        Me.bsaVistaPreviaGR.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaVistaPreviaGR.Text = "Vista Previa"
        Me.bsaVistaPreviaGR.ToolTipImage = Nothing
        Me.bsaVistaPreviaGR.UniqueName = "67570F8A96AC493B67570F8A96AC493B"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.UniqueName = "4632FEE4BDD24E144632FEE4BDD24E14"
        '
        'btnPrueba
        '
        Me.btnPrueba.ExtraText = ""
        Me.btnPrueba.Image = Nothing
        Me.btnPrueba.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnPrueba.Text = "Prueba"
        Me.btnPrueba.ToolTipImage = Nothing
        Me.btnPrueba.UniqueName = "2BBCC8F93276434F2BBCC8F93276434F"
        Me.btnPrueba.Visible = False
        '
        'dgGuiasRemision
        '
        Me.dgGuiasRemision.AllowUserToAddRows = False
        Me.dgGuiasRemision.AllowUserToDeleteRows = False
        Me.dgGuiasRemision.AllowUserToResizeColumns = False
        Me.dgGuiasRemision.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasRemision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuiasRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.GR_NGUIRM, Me.GR_FGUIRM, Me.GR_SMTGRM, Me.GR_MOTTRA, Me.GR_SESTRG, Me.GR_SITUAC})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 0)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.RowHeadersWidth = 20
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(534, 290)
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.TabIndex = 1
        '
        'dstDespacho
        '
        Me.dstDespacho.DataSetName = "dstDespacho"
        Me.dstDespacho.Tables.AddRange(New System.Data.DataTable() {Me.dtGuiaSalida})
        '
        'dtGuiaSalida
        '
        Me.dtGuiaSalida.Columns.AddRange(New System.Data.DataColumn() {Me.NRGUSA, Me.NMNFTF, Me.FSLDAL, Me.SMTRCP, Me.MOTREC, Me.STPDSP, Me.TIPDES, Me.SESTRG, Me.SITUAC, Me.CTRSPT, Me.NPLCUN, Me.NPLCAC, Me.CBRCNT})
        Me.dtGuiaSalida.TableName = "dtGuiaSalida"
        '
        'NRGUSA
        '
        Me.NRGUSA.ColumnName = "NRGUSA"
        Me.NRGUSA.DataType = GetType(Long)
        Me.NRGUSA.DefaultValue = CType(0, Long)
        '
        'NMNFTF
        '
        Me.NMNFTF.ColumnName = "NMNFTF"
        Me.NMNFTF.DefaultValue = ""
        '
        'FSLDAL
        '
        Me.FSLDAL.ColumnName = "FSLDAL"
        Me.FSLDAL.DataType = GetType(Date)
        '
        'SMTRCP
        '
        Me.SMTRCP.ColumnName = "SMTRCP"
        Me.SMTRCP.DefaultValue = ""
        '
        'MOTREC
        '
        Me.MOTREC.ColumnName = "MOTREC"
        Me.MOTREC.DefaultValue = ""
        '
        'STPDSP
        '
        Me.STPDSP.ColumnName = "STPDSP"
        Me.STPDSP.DefaultValue = ""
        '
        'TIPDES
        '
        Me.TIPDES.ColumnName = "TIPDES"
        Me.TIPDES.DefaultValue = ""
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'SITUAC
        '
        Me.SITUAC.ColumnName = "SITUAC"
        Me.SITUAC.DefaultValue = ""
        '
        'CTRSPT
        '
        Me.CTRSPT.ColumnName = "CTRSPT"
        Me.CTRSPT.DataType = GetType(Integer)
        Me.CTRSPT.DefaultValue = 0
        '
        'NPLCUN
        '
        Me.NPLCUN.ColumnName = "NPLCUN"
        Me.NPLCUN.DefaultValue = ""
        '
        'NPLCAC
        '
        Me.NPLCAC.ColumnName = "NPLCAC"
        Me.NPLCAC.DefaultValue = ""
        '
        'CBRCNT
        '
        Me.CBRCNT.ColumnName = "CBRCNT"
        Me.CBRCNT.DefaultValue = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Guía Remisión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 135
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FGUIRM"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha G. Remisión"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SMTGRM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código MotivoTraslado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 156
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MOTTRA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Motivo Traslado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 118
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Código Situación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 84
        '
        'CHK
        '
        Me.CHK.HeaderText = "CHK"
        Me.CHK.Name = "CHK"
        Me.CHK.Width = 38
        '
        'GR_NGUIRM
        '
        Me.GR_NGUIRM.DataPropertyName = "PSNGUIRM"
        Me.GR_NGUIRM.HeaderText = "Nro. Guía Remisión"
        Me.GR_NGUIRM.Name = "GR_NGUIRM"
        Me.GR_NGUIRM.Width = 135
        '
        'GR_FGUIRM
        '
        Me.GR_FGUIRM.DataPropertyName = "PSFECGUIA"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.GR_FGUIRM.DefaultCellStyle = DataGridViewCellStyle2
        Me.GR_FGUIRM.HeaderText = "Fecha G. Remisión"
        Me.GR_FGUIRM.Name = "GR_FGUIRM"
        Me.GR_FGUIRM.Width = 130
        '
        'GR_SMTGRM
        '
        Me.GR_SMTGRM.DataPropertyName = "PSSMTGRM"
        Me.GR_SMTGRM.HeaderText = "Código MotivoTraslado"
        Me.GR_SMTGRM.Name = "GR_SMTGRM"
        Me.GR_SMTGRM.Visible = False
        Me.GR_SMTGRM.Width = 156
        '
        'GR_MOTTRA
        '
        Me.GR_MOTTRA.DataPropertyName = "PSMOTTRA"
        Me.GR_MOTTRA.HeaderText = "Motivo Traslado"
        Me.GR_MOTTRA.Name = "GR_MOTTRA"
        Me.GR_MOTTRA.Width = 118
        '
        'GR_SESTRG
        '
        Me.GR_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GR_SESTRG.HeaderText = "Código Situación"
        Me.GR_SESTRG.Name = "GR_SESTRG"
        Me.GR_SESTRG.Visible = False
        Me.GR_SESTRG.Width = 125
        '
        'GR_SITUAC
        '
        Me.GR_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GR_SITUAC.HeaderText = "Situación"
        Me.GR_SITUAC.Name = "GR_SITUAC"
        Me.GR_SITUAC.Width = 84
        '
        'frmImpresionMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 320)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpresionMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion Masiva"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.Panel.ResumeLayout(False)
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.ResumeLayout(False)
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGuiaSalida, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaVistaPreviaGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents dstDespacho As System.Data.DataSet
    Friend WithEvents dtGuiaSalida As System.Data.DataTable
    Friend WithEvents NRGUSA As System.Data.DataColumn
    Friend WithEvents NMNFTF As System.Data.DataColumn
    Friend WithEvents FSLDAL As System.Data.DataColumn
    Friend WithEvents SMTRCP As System.Data.DataColumn
    Friend WithEvents MOTREC As System.Data.DataColumn
    Friend WithEvents STPDSP As System.Data.DataColumn
    Friend WithEvents TIPDES As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents SITUAC As System.Data.DataColumn
    Friend WithEvents CTRSPT As System.Data.DataColumn
    Friend WithEvents NPLCUN As System.Data.DataColumn
    Friend WithEvents NPLCAC As System.Data.DataColumn
    Friend WithEvents CBRCNT As System.Data.DataColumn
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnPrueba As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GR_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SMTGRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
