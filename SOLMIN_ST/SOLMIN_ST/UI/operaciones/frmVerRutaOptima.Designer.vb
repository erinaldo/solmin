<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerRutaOptima
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NMOPRP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ITEMAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRHJCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDIROR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDIRDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QKMREC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESGRP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLCLOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLCLDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenu = New System.Windows.Forms.ToolStrip
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.tsMenu)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(950, 416)
        Me.KryptonPanel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.gwdDatos)
        Me.SplitContainer1.Size = New System.Drawing.Size(950, 391)
        Me.SplitContainer1.SplitterDistance = 525
        Me.SplitContainer1.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(522, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 391)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NMOPRP, Me.ITEMAN, Me.CTRSPT, Me.NRHJCR, Me.NOPRCN, Me.TDIROR, Me.TDIRDS, Me.TCMRCD, Me.QKMREC, Me.CBRCNT, Me.CBRCND, Me.SESGRP, Me.CLCLOR, Me.CLCLDS, Me.CMRCDR})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gwdDatos.Size = New System.Drawing.Size(421, 391)
        Me.gwdDatos.StandardTab = True
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 2
        '
        'NMOPRP
        '
        Me.NMOPRP.DataPropertyName = "NMOPRP"
        Me.NMOPRP.HeaderText = "Item"
        Me.NMOPRP.MinimumWidth = 40
        Me.NMOPRP.Name = "NMOPRP"
        Me.NMOPRP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.NMOPRP.Width = 40
        '
        'ITEMAN
        '
        Me.ITEMAN.DataPropertyName = "ITEMAN"
        Me.ITEMAN.HeaderText = "Item Antiguo"
        Me.ITEMAN.Name = "ITEMAN"
        Me.ITEMAN.ReadOnly = True
        Me.ITEMAN.Visible = False
        '
        'CTRSPT
        '
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Cod. Transportista"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.Visible = False
        '
        'NRHJCR
        '
        Me.NRHJCR.DataPropertyName = "NRHJCR"
        Me.NRHJCR.HeaderText = "Nro. Hoja de Carguio"
        Me.NRHJCR.Name = "NRHJCR"
        Me.NRHJCR.Visible = False
        '
        'NOPRCN
        '
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.MinimumWidth = 70
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.Width = 70
        '
        'TDIROR
        '
        Me.TDIROR.DataPropertyName = "TDIROR"
        Me.TDIROR.HeaderText = "Localidad Origen"
        Me.TDIROR.MinimumWidth = 100
        Me.TDIROR.Name = "TDIROR"
        '
        'TDIRDS
        '
        Me.TDIRDS.DataPropertyName = "TDIRDS"
        Me.TDIRDS.HeaderText = "Localidad Destino"
        Me.TDIRDS.MinimumWidth = 100
        Me.TDIRDS.Name = "TDIRDS"
        '
        'TCMRCD
        '
        Me.TCMRCD.DataPropertyName = "TCMRCD"
        Me.TCMRCD.HeaderText = "Mercadería"
        Me.TCMRCD.Name = "TCMRCD"
        Me.TCMRCD.Visible = False
        '
        'QKMREC
        '
        Me.QKMREC.DataPropertyName = "QKMREC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QKMREC.DefaultCellStyle = DataGridViewCellStyle1
        Me.QKMREC.HeaderText = "Km. Recorridos"
        Me.QKMREC.MinimumWidth = 90
        Me.QKMREC.Name = "QKMREC"
        Me.QKMREC.Width = 90
        '
        'CBRCNT
        '
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Brevete de Conductor"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.Visible = False
        '
        'CBRCND
        '
        Me.CBRCND.DataPropertyName = "CBRCND"
        Me.CBRCND.HeaderText = "Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.Visible = False
        '
        'SESGRP
        '
        Me.SESGRP.DataPropertyName = "SESGRP"
        Me.SESGRP.HeaderText = "Flag de Est. de Guía de Remisión"
        Me.SESGRP.Name = "SESGRP"
        Me.SESGRP.Visible = False
        '
        'CLCLOR
        '
        Me.CLCLOR.DataPropertyName = "CLCLOR"
        Me.CLCLOR.HeaderText = "Código Localidad Origen"
        Me.CLCLOR.Name = "CLCLOR"
        Me.CLCLOR.Visible = False
        '
        'CLCLDS
        '
        Me.CLCLDS.DataPropertyName = "CLCLDS"
        Me.CLCLDS.HeaderText = "Código Localidad Destino"
        Me.CLCLDS.Name = "CLCLDS"
        Me.CLCLDS.Visible = False
        '
        'CMRCDR
        '
        Me.CMRCDR.DataPropertyName = "CMRCDR"
        Me.CMRCDR.HeaderText = "Código de Mercadería"
        Me.CMRCDR.Name = "CMRCDR"
        Me.CMRCDR.Visible = False
        '
        'tsMenu
        '
        Me.tsMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(950, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Transportista"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRHJCR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nro. Hoja de Carguio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 145
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TDIROR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Localidad Origen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 124
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TDIRDS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Localidad Destino"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 128
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCMRCD"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 60
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 93
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QKMREC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Km. Recorridos"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 60
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 112
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Brevete de Conductor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 148
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CBRCND"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 91
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SESGRP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Flag de Est. de Guía de Remisión"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 204
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CLCLOR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Código Localidad Origen"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 165
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CLCLDS"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Código Localidad Destino"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 169
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 90
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CMRCDR"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Código de Mercadería"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CMRCDR"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Código de Mercadería"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(69, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'frmVerRutaOptima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 416)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerRutaOptima"
        Me.Text = "Ruta Óptima"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    'Public Sub New()

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents NMOPRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEMAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRHJCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDIROR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDIRDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QKMREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESGRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLCLOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLCLDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
