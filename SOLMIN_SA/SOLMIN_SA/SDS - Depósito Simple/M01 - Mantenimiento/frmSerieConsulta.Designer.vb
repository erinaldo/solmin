<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerieConsulta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgMercaderiaSerie = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CSRECL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSMDL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINGAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSLDAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONDICION_SSTINV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRPLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSTINV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUISL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.lblDetalle = New System.Windows.Forms.ToolStripLabel
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgMercaderiaSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMercaderiaSerie)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(830, 552)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgMercaderiaSerie
        '
        Me.dgMercaderiaSerie.AllowUserToAddRows = False
        Me.dgMercaderiaSerie.AllowUserToDeleteRows = False
        Me.dgMercaderiaSerie.AllowUserToResizeColumns = False
        Me.dgMercaderiaSerie.AllowUserToResizeRows = False
        Me.dgMercaderiaSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSerie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CSRECL, Me.TDSMDL, Me.FINGAL, Me.FSLDAL, Me.CONDICION_SSTINV, Me.TOBSRV, Me.NORDSR, Me.NCRPLL, Me.CCLNT2, Me.SSTINV, Me.NGUISL})
        Me.dgMercaderiaSerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSerie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgMercaderiaSerie.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderiaSerie.MultiSelect = False
        Me.dgMercaderiaSerie.Name = "dgMercaderiaSerie"
        Me.dgMercaderiaSerie.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSerie.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderiaSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSerie.Size = New System.Drawing.Size(830, 502)
        Me.dgMercaderiaSerie.StandardTab = True
        Me.dgMercaderiaSerie.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSerie.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSerie.TabIndex = 78
        '
        'CSRECL
        '
        Me.CSRECL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CSRECL.DataPropertyName = "CSRECL"
        Me.CSRECL.HeaderText = "Nro Serie"
        Me.CSRECL.Name = "CSRECL"
        Me.CSRECL.Width = 80
        '
        'TDSMDL
        '
        Me.TDSMDL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDSMDL.DataPropertyName = "TDSMDL"
        Me.TDSMDL.HeaderText = "Descripción Modelo"
        Me.TDSMDL.Name = "TDSMDL"
        Me.TDSMDL.Width = 130
        '
        'FINGAL
        '
        Me.FINGAL.DataPropertyName = "FINGAL"
        Me.FINGAL.HeaderText = "Fecha Ingreso"
        Me.FINGAL.Name = "FINGAL"
        Me.FINGAL.Width = 104
        '
        'FSLDAL
        '
        Me.FSLDAL.DataPropertyName = "FSLDAL"
        Me.FSLDAL.HeaderText = "Fecha Salida"
        Me.FSLDAL.Name = "FSLDAL"
        Me.FSLDAL.Width = 98
        '
        'CONDICION_SSTINV
        '
        Me.CONDICION_SSTINV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CONDICION_SSTINV.DataPropertyName = "CONDICION_SSTINV"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CONDICION_SSTINV.DefaultCellStyle = DataGridViewCellStyle1
        Me.CONDICION_SSTINV.HeaderText = "Estado"
        Me.CONDICION_SSTINV.Name = "CONDICION_SSTINV"
        Me.CONDICION_SSTINV.Width = 69
        '
        'TOBSRV
        '
        Me.TOBSRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBSRV.DataPropertyName = "TOBSRV"
        Me.TOBSRV.HeaderText = "Observación"
        Me.TOBSRV.Name = "TOBSRV"
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "NORDSR"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.Visible = False
        Me.NORDSR.Width = 83
        '
        'NCRPLL
        '
        Me.NCRPLL.DataPropertyName = "NCRPLL"
        Me.NCRPLL.HeaderText = "NCRPLL"
        Me.NCRPLL.Name = "NCRPLL"
        Me.NCRPLL.Visible = False
        Me.NCRPLL.Width = 78
        '
        'CCLNT2
        '
        Me.CCLNT2.DataPropertyName = "CCLNT2"
        Me.CCLNT2.HeaderText = "CCLNT2"
        Me.CCLNT2.Name = "CCLNT2"
        Me.CCLNT2.Visible = False
        Me.CCLNT2.Width = 77
        '
        'SSTINV
        '
        Me.SSTINV.DataPropertyName = "SSTINV"
        Me.SSTINV.HeaderText = "SSTINV"
        Me.SSTINV.Name = "SSTINV"
        Me.SSTINV.Visible = False
        Me.SSTINV.Width = 75
        '
        'NGUISL
        '
        Me.NGUISL.DataPropertyName = "NGUISL"
        Me.NGUISL.HeaderText = "NGUISL"
        Me.NGUISL.Name = "NGUISL"
        Me.NGUISL.Visible = False
        Me.NGUISL.Width = 76
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 527)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(830, 25)
        Me.UcPaginacion.TabIndex = 77
        Me.UcPaginacion.Visible = False
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDetalle, Me.btnSalir, Me.btnEliminar, Me.btnModificar, Me.btnAgregar})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(830, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 76
        '
        'lblDetalle
        '
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(89, 22)
        Me.lblDetalle.Text = "Información Serie"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(47, 22)
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(70, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'frmSerieConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 552)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(838, 579)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(838, 579)
        Me.Name = "frmSerieConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento Serie"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgMercaderiaSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
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
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents lblDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents dgMercaderiaSerie As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CSRECL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSMDL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINGAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLDAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONDICION_SSTINV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRPLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSTINV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUISL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
