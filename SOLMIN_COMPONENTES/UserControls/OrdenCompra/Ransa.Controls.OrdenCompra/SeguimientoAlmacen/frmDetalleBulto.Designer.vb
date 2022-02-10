<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleBulto
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgBultosDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.D_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_QVOPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.D_NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.X_MARRET = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SUBITEM = New System.Windows.Forms.DataGridViewImageColumn
    Me.NRSITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgBultosDetalle)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(794, 243)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgBultosDetalle
    '
    Me.dgBultosDetalle.AllowUserToAddRows = False
    Me.dgBultosDetalle.AllowUserToDeleteRows = False
    Me.dgBultosDetalle.AllowUserToOrderColumns = True
    Me.dgBultosDetalle.AllowUserToResizeColumns = False
    Me.dgBultosDetalle.AllowUserToResizeRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
    Me.dgBultosDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgBultosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgBultosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgBultosDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_CREFFW, Me.D_NORCML, Me.D_NRITOC, Me.D_CIDPAQ, Me.D_TDITES, Me.D_QBLTSR, Me.D_QPEPQT, Me.D_TUNPSO, Me.D_QVOPQT, Me.D_TUNVOL, Me.D_TLUGEN, Me.D_NGRPRV, Me.X_MARRET, Me.SUBITEM, Me.NRSITEM})
    Me.dgBultosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgBultosDetalle.Location = New System.Drawing.Point(0, 0)
    Me.dgBultosDetalle.Name = "dgBultosDetalle"
    Me.dgBultosDetalle.ReadOnly = True
    Me.dgBultosDetalle.RowHeadersWidth = 20
    Me.dgBultosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgBultosDetalle.Size = New System.Drawing.Size(794, 243)
    Me.dgBultosDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dgBultosDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgBultosDetalle.TabIndex = 3
    '
    'D_CREFFW
    '
    Me.D_CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_CREFFW.DataPropertyName = "CREFFW"
    Me.D_CREFFW.HeaderText = "Bulto"
    Me.D_CREFFW.Name = "D_CREFFW"
    Me.D_CREFFW.ReadOnly = True
    Me.D_CREFFW.Visible = False
    '
    'D_NORCML
    '
    Me.D_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_NORCML.DataPropertyName = "NORCML"
    Me.D_NORCML.HeaderText = "Nro. O/C"
    Me.D_NORCML.Name = "D_NORCML"
    Me.D_NORCML.ReadOnly = True
    Me.D_NORCML.Width = 75
    '
    'D_NRITOC
    '
    Me.D_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_NRITOC.DataPropertyName = "NRITOC"
    Me.D_NRITOC.HeaderText = "Nro. Item  O/C"
    Me.D_NRITOC.Name = "D_NRITOC"
    Me.D_NRITOC.ReadOnly = True
    Me.D_NRITOC.Width = 83
    '
    'D_CIDPAQ
    '
    Me.D_CIDPAQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_CIDPAQ.DataPropertyName = "CIDPAQ"
    Me.D_CIDPAQ.HeaderText = "Cód. Paquete"
    Me.D_CIDPAQ.Name = "D_CIDPAQ"
    Me.D_CIDPAQ.ReadOnly = True
    Me.D_CIDPAQ.Width = 97
    '
    'D_TDITES
    '
    Me.D_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_TDITES.DataPropertyName = "TDITES"
    Me.D_TDITES.HeaderText = "Descripción"
    Me.D_TDITES.Name = "D_TDITES"
    Me.D_TDITES.ReadOnly = True
    Me.D_TDITES.Width = 96
    '
    'D_QBLTSR
    '
    Me.D_QBLTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_QBLTSR.DataPropertyName = "QBLTSR"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    Me.D_QBLTSR.DefaultCellStyle = DataGridViewCellStyle2
    Me.D_QBLTSR.HeaderText = "Cantidad"
    Me.D_QBLTSR.Name = "D_QBLTSR"
    Me.D_QBLTSR.ReadOnly = True
    Me.D_QBLTSR.Width = 83
    '
    'D_QPEPQT
    '
    Me.D_QPEPQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_QPEPQT.DataPropertyName = "QPEPQT"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "N2"
    Me.D_QPEPQT.DefaultCellStyle = DataGridViewCellStyle3
    Me.D_QPEPQT.HeaderText = "Peso"
    Me.D_QPEPQT.Name = "D_QPEPQT"
    Me.D_QPEPQT.ReadOnly = True
    Me.D_QPEPQT.Width = 60
    '
    'D_TUNPSO
    '
    Me.D_TUNPSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_TUNPSO.DataPropertyName = "TUNPSO"
    Me.D_TUNPSO.HeaderText = "Unidad"
    Me.D_TUNPSO.Name = "D_TUNPSO"
    Me.D_TUNPSO.ReadOnly = True
    Me.D_TUNPSO.Width = 74
    '
    'D_QVOPQT
    '
    Me.D_QVOPQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_QVOPQT.DataPropertyName = "QVOPQT"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle4.Format = "N2"
    Me.D_QVOPQT.DefaultCellStyle = DataGridViewCellStyle4
    Me.D_QVOPQT.HeaderText = "Volumen"
    Me.D_QVOPQT.Name = "D_QVOPQT"
    Me.D_QVOPQT.ReadOnly = True
    Me.D_QVOPQT.Width = 82
    '
    'D_TUNVOL
    '
    Me.D_TUNVOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_TUNVOL.DataPropertyName = "TUNVOL"
    Me.D_TUNVOL.HeaderText = "Unidad"
    Me.D_TUNVOL.Name = "D_TUNVOL"
    Me.D_TUNVOL.ReadOnly = True
    Me.D_TUNVOL.Width = 74
    '
    'D_TLUGEN
    '
    Me.D_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_TLUGEN.DataPropertyName = "TLUGEN"
    Me.D_TLUGEN.HeaderText = "Lugar Entrega"
    Me.D_TLUGEN.Name = "D_TLUGEN"
    Me.D_TLUGEN.ReadOnly = True
    '
    'D_NGRPRV
    '
    Me.D_NGRPRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.D_NGRPRV.DataPropertyName = "NGRPRV"
    Me.D_NGRPRV.HeaderText = "Guía Proveedor"
    Me.D_NGRPRV.Name = "D_NGRPRV"
    Me.D_NGRPRV.ReadOnly = True
    Me.D_NGRPRV.Visible = False
    '
    'X_MARRET
    '
    Me.X_MARRET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.X_MARRET.DataPropertyName = "MARRET"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.X_MARRET.DefaultCellStyle = DataGridViewCellStyle5
    Me.X_MARRET.HeaderText = "Custodia" & Global.Microsoft.VisualBasic.ChrW(10) & "Retención"
    Me.X_MARRET.Name = "X_MARRET"
    Me.X_MARRET.ReadOnly = True
    Me.X_MARRET.Width = 88
    '
    'SUBITEM
    '
    Me.SUBITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.SUBITEM.DataPropertyName = "SUBITEM"
    Me.SUBITEM.HeaderText = "Sub Items"
    Me.SUBITEM.Image = Global.Ransa.Controls.OrdenCompra.My.Resources.Resources.EnBlanco
    Me.SUBITEM.Name = "SUBITEM"
    Me.SUBITEM.ReadOnly = True
    Me.SUBITEM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.SUBITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.SUBITEM.Width = 80
    '
    'NRSITEM
    '
    Me.NRSITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRSITEM.DataPropertyName = "NRSITEM"
    Me.NRSITEM.HeaderText = "NRSITEM"
    Me.NRSITEM.Name = "NRSITEM"
    Me.NRSITEM.ReadOnly = True
    Me.NRSITEM.Visible = False
    '
    'frmDetalleBulto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(794, 243)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmDetalleBulto"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Detalle Bulto"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgBultosDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents D_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QPEPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QVOPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents X_MARRET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBITEM As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents NRSITEM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
