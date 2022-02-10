<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTomaInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTomaInventario))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgBotones = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgTomaInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCOTIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTRMC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPSCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsbInicializar = New System.Windows.Forms.ToolStripButton
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBotones.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBotones.Panel.SuspendLayout()
        Me.hgBotones.SuspendLayout()
        CType(Me.dgTomaInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgBotones)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(823, 597)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgBotones
        '
        Me.hgBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgBotones.HeaderVisibleSecondary = False
        Me.hgBotones.Location = New System.Drawing.Point(0, 110)
        Me.hgBotones.Name = "hgBotones"
        '
        'hgBotones.Panel
        '
        Me.hgBotones.Panel.Controls.Add(Me.dgTomaInventario)
        Me.hgBotones.Size = New System.Drawing.Size(823, 487)
        Me.hgBotones.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBotones.TabIndex = 7
        Me.hgBotones.ValuesPrimary.Description = ""
        Me.hgBotones.ValuesPrimary.Heading = ""
        Me.hgBotones.ValuesPrimary.Image = Nothing
        Me.hgBotones.ValuesSecondary.Description = ""
        Me.hgBotones.ValuesSecondary.Heading = "Description"
        Me.hgBotones.ValuesSecondary.Image = Nothing
        '
        'dgTomaInventario
        '
        Me.dgTomaInventario.AllowUserToAddRows = False
        Me.dgTomaInventario.AllowUserToDeleteRows = False
        Me.dgTomaInventario.AllowUserToResizeRows = False
        Me.dgTomaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTomaInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.TMRCD2, Me.NCOTIN, Me.QTRMC1, Me.CPSCN, Me.CUSCRT, Me.FCHCRT, Me.HRACRT})
        Me.dgTomaInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTomaInventario.Location = New System.Drawing.Point(0, 0)
        Me.dgTomaInventario.MultiSelect = False
        Me.dgTomaInventario.Name = "dgTomaInventario"
        Me.dgTomaInventario.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTomaInventario.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTomaInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTomaInventario.Size = New System.Drawing.Size(821, 482)
        Me.dgTomaInventario.StandardTab = True
        Me.dgTomaInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgTomaInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgTomaInventario.TabIndex = 6
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "CMRCLR"
        Me.CMRCLR.HeaderText = "Codigo"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.Width = 74
        '
        'TMRCD2
        '
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Descripcion"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.Width = 96
        '
        'NCOTIN
        '
        Me.NCOTIN.DataPropertyName = "NCOTIN"
        Me.NCOTIN.HeaderText = "Corr."
        Me.NCOTIN.Name = "NCOTIN"
        Me.NCOTIN.Width = 61
        '
        'QTRMC1
        '
        Me.QTRMC1.DataPropertyName = "QTRMC1"
        Me.QTRMC1.HeaderText = "Cant."
        Me.QTRMC1.Name = "QTRMC1"
        Me.QTRMC1.Width = 63
        '
        'CPSCN
        '
        Me.CPSCN.DataPropertyName = "CPSCN"
        Me.CPSCN.HeaderText = "Ubicacion"
        Me.CPSCN.Name = "CPSCN"
        Me.CPSCN.Width = 87
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Usuario"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.Width = 76
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "Fecha"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.Width = 66
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "Hora"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.Width = 61
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.tsMenuOpciones)
        Me.hgFiltros.Panel.Controls.Add(Me.btnProcesar)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblZonaAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Size = New System.Drawing.Size(823, 110)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 1
        Me.hgFiltros.Text = "Información"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Información"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInicializar, Me.tsbExportar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 66)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(821, 25)
        Me.tsMenuOpciones.TabIndex = 35
        '
        'tsbInicializar
        '
        Me.tsbInicializar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tsbInicializar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInicializar.Name = "tsbInicializar"
        Me.tsbInicializar.Size = New System.Drawing.Size(75, 22)
        Me.tsbInicializar.Text = "&Inicializar"
        Me.tsbInicializar.ToolTipText = "Inicializar"
        '
        'tsbExportar
        '
        Me.tsbExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(70, 22)
        Me.tsbExportar.Text = "&Exportar"
        Me.tsbExportar.ToolTipText = "Exportar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(742, 3)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(68, 57)
        Me.btnProcesar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnProcesar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnProcesar.TabIndex = 34
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = ""
        Me.btnProcesar.Values.Image = CType(resources.GetObject("btnProcesar.Values.Image"), System.Drawing.Image)
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(82, 28)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.TabIndex = 2
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(415, 39)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(54, 50)
        Me.lblZonaAlmacen.TabIndex = 33
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.lblZonaAlmacen.Values.Text = ""
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(24, 31)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(50, 19)
        Me.lblTipoAlmacen.TabIndex = 29
        Me.lblTipoAlmacen.Text = "Cliente : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Cliente : "
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'frmTomaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 597)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTomaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tomo de Inventario"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgBotones.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBotones.Panel.ResumeLayout(False)
        CType(Me.hgBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBotones.ResumeLayout(False)
        CType(Me.dgTomaInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbInicializar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents hgBotones As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgTomaInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCOTIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTRMC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
