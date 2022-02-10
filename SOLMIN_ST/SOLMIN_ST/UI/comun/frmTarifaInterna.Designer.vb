<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifaInterna
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCRDCO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DOCDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POSTDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPORTECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCCSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_HDR_TX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.toolSAP = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCRDCO_d = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SENITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_SERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POSTQUUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VALU_TCU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COST_ELE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNCOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEN_ORDE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REC_CCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REC_ORDE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtDatos)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(863, 517)
        Me.KryptonPanel1.TabIndex = 0
        '
        'dtDatos
        '
        Me.dtDatos.AllowUserToAddRows = False
        Me.dtDatos.AllowUserToDeleteRows = False
        Me.dtDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRDCO, Me.DOCDATE, Me.POSTDATE, Me.IMPORTECO, Me.NCCSAP, Me.D_HDR_TX})
        Me.dtDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtDatos.Location = New System.Drawing.Point(0, 25)
        Me.dtDatos.Name = "dtDatos"
        Me.dtDatos.ReadOnly = True
        Me.dtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtDatos.Size = New System.Drawing.Size(863, 249)
        Me.dtDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtDatos.TabIndex = 2
        '
        'NCRDCO
        '
        Me.NCRDCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRDCO.DataPropertyName = "NCRDCO"
        Me.NCRDCO.HeaderText = "Nro Tarifa Int"
        Me.NCRDCO.Name = "NCRDCO"
        Me.NCRDCO.ReadOnly = True
        Me.NCRDCO.Width = 106
        '
        'DOCDATE
        '
        Me.DOCDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DOCDATE.DataPropertyName = "DOCDATE"
        Me.DOCDATE.HeaderText = "Fecha Doc"
        Me.DOCDATE.Name = "DOCDATE"
        Me.DOCDATE.ReadOnly = True
        Me.DOCDATE.Width = 84
        '
        'POSTDATE
        '
        Me.POSTDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.POSTDATE.DataPropertyName = "POSTDATE"
        Me.POSTDATE.HeaderText = "Fecha Contable"
        Me.POSTDATE.Name = "POSTDATE"
        Me.POSTDATE.ReadOnly = True
        Me.POSTDATE.Width = 109
        '
        'IMPORTECO
        '
        Me.IMPORTECO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTECO.DataPropertyName = "IMPORTECO"
        Me.IMPORTECO.HeaderText = "Importe(S/.)"
        Me.IMPORTECO.Name = "IMPORTECO"
        Me.IMPORTECO.ReadOnly = True
        '
        'NCCSAP
        '
        Me.NCCSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCCSAP.DataPropertyName = "NCCSAP"
        Me.NCCSAP.HeaderText = "Nro Ref SAP"
        Me.NCCSAP.Name = "NCCSAP"
        Me.NCCSAP.ReadOnly = True
        Me.NCCSAP.Width = 92
        '
        'D_HDR_TX
        '
        Me.D_HDR_TX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.D_HDR_TX.DataPropertyName = "D_HDR_TX"
        Me.D_HDR_TX.HeaderText = "Ref Obs"
        Me.D_HDR_TX.Name = "D_HDR_TX"
        Me.D_HDR_TX.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolSAP})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(863, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'toolSAP
        '
        Me.toolSAP.Image = Global.SOLMIN_ST.My.Resources.Resources.sapcicon
        Me.toolSAP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSAP.Name = "toolSAP"
        Me.toolSAP.Size = New System.Drawing.Size(92, 22)
        Me.toolSAP.Text = "Enviar a &SAP"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 280)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtDetalle)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(863, 237)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Detalle"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Detalle"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'dtDetalle
        '
        Me.dtDetalle.AllowUserToAddRows = False
        Me.dtDetalle.AllowUserToDeleteRows = False
        Me.dtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRDCO_d, Me.SENITEM, Me.DESC_SERV, Me.POSTQUUN, Me.CANTIDAD, Me.VALU_TCU, Me.CMNDA, Me.COST_ELE, Me.CCNCOS, Me.SEN_ORDE, Me.REC_CCTR, Me.REC_ORDE})
        Me.dtDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtDetalle.Location = New System.Drawing.Point(0, 0)
        Me.dtDetalle.Name = "dtDetalle"
        Me.dtDetalle.ReadOnly = True
        Me.dtDetalle.Size = New System.Drawing.Size(861, 184)
        Me.dtDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtDetalle.TabIndex = 2
        '
        'NCRDCO_d
        '
        Me.NCRDCO_d.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRDCO_d.DataPropertyName = "NCRDCO"
        Me.NCRDCO_d.HeaderText = "NCRDCO"
        Me.NCRDCO_d.Name = "NCRDCO_d"
        Me.NCRDCO_d.ReadOnly = True
        Me.NCRDCO_d.Visible = False
        Me.NCRDCO_d.Width = 85
        '
        'SENITEM
        '
        Me.SENITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SENITEM.DataPropertyName = "SENITEM"
        Me.SENITEM.HeaderText = "Item"
        Me.SENITEM.Name = "SENITEM"
        Me.SENITEM.ReadOnly = True
        Me.SENITEM.Width = 60
        '
        'DESC_SERV
        '
        Me.DESC_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_SERV.DataPropertyName = "DESC_SERV"
        Me.DESC_SERV.HeaderText = "Servicio"
        Me.DESC_SERV.Name = "DESC_SERV"
        Me.DESC_SERV.ReadOnly = True
        Me.DESC_SERV.Width = 77
        '
        'POSTQUUN
        '
        Me.POSTQUUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.POSTQUUN.DataPropertyName = "UNID_MED"
        Me.POSTQUUN.HeaderText = "Unid Med."
        Me.POSTQUUN.Name = "POSTQUUN"
        Me.POSTQUUN.ReadOnly = True
        Me.POSTQUUN.Width = 91
        '
        'CANTIDAD
        '
        Me.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle1
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        Me.CANTIDAD.Width = 84
        '
        'VALU_TCU
        '
        Me.VALU_TCU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VALU_TCU.DataPropertyName = "VALU_TCU"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VALU_TCU.DefaultCellStyle = DataGridViewCellStyle2
        Me.VALU_TCU.HeaderText = "Importe"
        Me.VALU_TCU.Name = "VALU_TCU"
        Me.VALU_TCU.ReadOnly = True
        Me.VALU_TCU.Width = 78
        '
        'CMNDA
        '
        Me.CMNDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMNDA.DataPropertyName = "TMNDA"
        Me.CMNDA.HeaderText = "Moneda"
        Me.CMNDA.Name = "CMNDA"
        Me.CMNDA.ReadOnly = True
        Me.CMNDA.Width = 80
        '
        'COST_ELE
        '
        Me.COST_ELE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COST_ELE.DataPropertyName = "COST_ELE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.COST_ELE.DefaultCellStyle = DataGridViewCellStyle3
        Me.COST_ELE.HeaderText = "Clase Coste"
        Me.COST_ELE.Name = "COST_ELE"
        Me.COST_ELE.ReadOnly = True
        Me.COST_ELE.Width = 97
        '
        'CCNCOS
        '
        Me.CCNCOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNCOS.DataPropertyName = "CCNCOS"
        Me.CCNCOS.HeaderText = "CeCo(Emisor)"
        Me.CCNCOS.Name = "CCNCOS"
        Me.CCNCOS.ReadOnly = True
        Me.CCNCOS.Width = 109
        '
        'SEN_ORDE
        '
        Me.SEN_ORDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEN_ORDE.DataPropertyName = "SEN_ORDE"
        Me.SEN_ORDE.HeaderText = "OI(Emisor)"
        Me.SEN_ORDE.Name = "SEN_ORDE"
        Me.SEN_ORDE.ReadOnly = True
        Me.SEN_ORDE.Width = 92
        '
        'REC_CCTR
        '
        Me.REC_CCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REC_CCTR.DataPropertyName = "REC_CCTR"
        Me.REC_CCTR.HeaderText = "CeCo(Receptor)"
        Me.REC_CCTR.Name = "REC_CCTR"
        Me.REC_CCTR.ReadOnly = True
        Me.REC_CCTR.Width = 120
        '
        'REC_ORDE
        '
        Me.REC_ORDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REC_ORDE.DataPropertyName = "REC_ORDE"
        Me.REC_ORDE.HeaderText = "OI(Receptor)"
        Me.REC_ORDE.Name = "REC_ORDE"
        Me.REC_ORDE.ReadOnly = True
        Me.REC_ORDE.Width = 103
        '
        'frmTarifaInterna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 517)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTarifaInterna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tarifa Interna"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolSAP As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NCRDCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSTDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCCSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_HDR_TX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRDCO_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SENITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_SERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSTQUUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALU_TCU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COST_ELE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNCOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEN_ORDE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REC_CCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REC_ORDE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
