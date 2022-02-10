<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObservacionesPedido
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
    Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.dtgDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.PSTOBSGSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.BeObservacionPedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup2.Panel.SuspendLayout()
    Me.KryptonHeaderGroup2.SuspendLayout()
    CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BeObservacionPedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(673, 438)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonHeaderGroup2
    '
    Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 75)
    Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
    '
    'KryptonHeaderGroup2.Panel
    '
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnCancelar)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnAceptar)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtgDatos)
    Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(673, 363)
    Me.KryptonHeaderGroup2.TabIndex = 1
    Me.KryptonHeaderGroup2.Text = "Observaciones a Registrar"
    Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Observaciones a Registrar"
    Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
    Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(570, 310)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.Values.ExtraText = ""
    Me.btnCancelar.Values.Image = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCancelar.Values.Text = "Cancelar"
    '
    'btnAceptar
    '
    Me.btnAceptar.Location = New System.Drawing.Point(470, 310)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
    Me.btnAceptar.TabIndex = 1
    Me.btnAceptar.Text = "Guardar"
    Me.btnAceptar.Values.ExtraText = ""
    Me.btnAceptar.Values.Image = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnAceptar.Values.Text = "Guardar"
    '
    'dtgDatos
    '
    Me.dtgDatos.AutoGenerateColumns = False
    Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dtgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSTOBSGSDataGridViewTextBoxColumn})
    Me.dtgDatos.DataSource = Me.BeObservacionPedidoBindingSource
    Me.dtgDatos.Location = New System.Drawing.Point(10, 10)
    Me.dtgDatos.Name = "dtgDatos"
    Me.dtgDatos.Size = New System.Drawing.Size(650, 290)
    Me.dtgDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgDatos.TabIndex = 0
    '
    'PSTOBSGSDataGridViewTextBoxColumn
    '
    Me.PSTOBSGSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.PSTOBSGSDataGridViewTextBoxColumn.DataPropertyName = "PSTOBSGS"
    Me.PSTOBSGSDataGridViewTextBoxColumn.HeaderText = "Observaciones"
    Me.PSTOBSGSDataGridViewTextBoxColumn.MaxInputLength = 60
    Me.PSTOBSGSDataGridViewTextBoxColumn.Name = "PSTOBSGSDataGridViewTextBoxColumn"
    '
    'BeObservacionPedidoBindingSource
    '
    Me.BeObservacionPedidoBindingSource.DataSource = GetType(RANSA.TYPEDEF.beObservacionPedido)
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantidad)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtMercaderia)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(673, 75)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Datos del Pedido"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Datos del Pedido"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'txtCantidad
    '
    Me.txtCantidad.Enabled = False
    Me.txtCantidad.Location = New System.Drawing.Point(450, 15)
    Me.txtCantidad.Name = "txtCantidad"
    Me.txtCantidad.Size = New System.Drawing.Size(100, 21)
    Me.txtCantidad.TabIndex = 3
    Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(390, 15)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel2.TabIndex = 2
    Me.KryptonLabel2.Text = "Cantidad"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Cantidad"
    '
    'txtMercaderia
    '
    Me.txtMercaderia.Enabled = False
    Me.txtMercaderia.Location = New System.Drawing.Point(90, 15)
    Me.txtMercaderia.Name = "txtMercaderia"
    Me.txtMercaderia.Size = New System.Drawing.Size(270, 21)
    Me.txtMercaderia.TabIndex = 1
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(10, 15)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(66, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Mercaderia"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Mercaderia"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CDPEPL"
    Me.DataGridViewTextBoxColumn1.HeaderText = "CDPEPL"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "CDREGP"
    Me.DataGridViewTextBoxColumn2.HeaderText = "CDREGP"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Visible = False
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "NCRRLT"
    Me.DataGridViewTextBoxColumn3.HeaderText = "NCRRLT"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Visible = False
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "CMRCLR"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Visible = False
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "TOBSGS"
    Me.DataGridViewTextBoxColumn5.HeaderText = "OBSERVACIONES"
    Me.DataGridViewTextBoxColumn5.MaxInputLength = 60
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.Width = 600
    '
    'frmObservacionesPedido
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(673, 438)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmObservacionesPedido"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Observaciones "
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.ResumeLayout(False)
    CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BeObservacionPedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtgDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeObservacionPedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PSTOBSGSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
