<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWaybill_PreDespacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWaybill_PreDespacho))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroBultos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNrosBultos = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgBultosSeleccionados = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgBultosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtCantidadBultos)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadBultos)
        Me.KryptonPanel.Controls.Add(Me.txtNroBultos)
        Me.KryptonPanel.Controls.Add(Me.lblNrosBultos)
        Me.KryptonPanel.Controls.Add(Me.txtBulto)
        Me.KryptonPanel.Controls.Add(Me.lblBulto)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.dgBultosSeleccionados)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.lblCriterioLote)
        Me.KryptonPanel.Controls.Add(Me.txtCriterioLote)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(569, 508)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtCantidadBultos
        '
        Me.txtCantidadBultos.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadBultos, True)
        Me.txtCantidadBultos.Location = New System.Drawing.Point(114, 470)
        Me.txtCantidadBultos.Name = "txtCantidadBultos"
        Me.txtCantidadBultos.ReadOnly = True
        Me.txtCantidadBultos.Size = New System.Drawing.Size(80, 19)
        Me.txtCantidadBultos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadBultos.TabIndex = 12
        Me.txtCantidadBultos.TabStop = False
        Me.txtCantidadBultos.Text = "0"
        Me.txtCantidadBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadBultos, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadBultos
        '
        Me.lblCantidadBultos.Location = New System.Drawing.Point(14, 473)
        Me.lblCantidadBultos.Name = "lblCantidadBultos"
        Me.lblCantidadBultos.Size = New System.Drawing.Size(94, 16)
        Me.lblCantidadBultos.TabIndex = 11
        Me.lblCantidadBultos.Text = "Cant. de Bultos : "
        Me.lblCantidadBultos.Values.ExtraText = ""
        Me.lblCantidadBultos.Values.Image = Nothing
        Me.lblCantidadBultos.Values.Text = "Cant. de Bultos : "
        '
        'txtNroBultos
        '
        Me.txtNroBultos.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtNroBultos, True)
        Me.txtNroBultos.Location = New System.Drawing.Point(114, 445)
        Me.txtNroBultos.Name = "txtNroBultos"
        Me.txtNroBultos.ReadOnly = True
        Me.txtNroBultos.Size = New System.Drawing.Size(80, 19)
        Me.txtNroBultos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNroBultos.TabIndex = 10
        Me.txtNroBultos.TabStop = False
        Me.txtNroBultos.Text = "0"
        Me.txtNroBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtNroBultos, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNrosBultos
        '
        Me.lblNrosBultos.Location = New System.Drawing.Point(14, 448)
        Me.lblNrosBultos.Name = "lblNrosBultos"
        Me.lblNrosBultos.Size = New System.Drawing.Size(94, 16)
        Me.lblNrosBultos.TabIndex = 9
        Me.lblNrosBultos.Text = "Nros. de Bultos : "
        Me.lblNrosBultos.Values.ExtraText = ""
        Me.lblNrosBultos.Values.Image = Nothing
        Me.lblNrosBultos.Values.Text = "Nros. de Bultos : "
        '
        'txtBulto
        '
        Me.txtBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBulto.Location = New System.Drawing.Point(124, 37)
        Me.txtBulto.MaxLength = 20
        Me.txtBulto.Name = "txtBulto"
        Me.txtBulto.Size = New System.Drawing.Size(175, 19)
        Me.txtBulto.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtBulto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblBulto
        '
        Me.lblBulto.Location = New System.Drawing.Point(14, 40)
        Me.lblBulto.Name = "lblBulto"
        Me.lblBulto.Size = New System.Drawing.Size(81, 16)
        Me.lblBulto.TabIndex = 4
        Me.lblBulto.Text = "Código Bulto : "
        Me.lblBulto.Values.ExtraText = ""
        Me.lblBulto.Values.Image = Nothing
        Me.lblBulto.Values.Text = "Código Bulto : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(305, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(63, 16)
        Me.KryptonLabel1.TabIndex = 3
        Me.KryptonLabel1.Text = "(Opcional)"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "(Opcional)"
        '
        'dgBultosSeleccionados
        '
        Me.dgBultosSeleccionados.AllowUserToAddRows = False
        Me.dgBultosSeleccionados.AllowUserToResizeRows = False
        Me.dgBultosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBultosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CREFFW, Me.M_QREFFW, Me.M_TLUGEN, Me.M_NROPLT})
        Me.dgBultosSeleccionados.Location = New System.Drawing.Point(14, 62)
        Me.dgBultosSeleccionados.MultiSelect = False
        Me.dgBultosSeleccionados.Name = "dgBultosSeleccionados"
        Me.dgBultosSeleccionados.RowHeadersWidth = 20
        Me.dgBultosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBultosSeleccionados.Size = New System.Drawing.Size(543, 377)
        Me.dgBultosSeleccionados.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBultosSeleccionados.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultosSeleccionados.TabIndex = 6
        Me.dgBultosSeleccionados.TabStop = False
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.MaxInputLength = 20
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.Width = 80
        '
        'M_QREFFW
        '
        Me.M_QREFFW.DataPropertyName = "QREFFW"
        Me.M_QREFFW.HeaderText = "Cantidad"
        Me.M_QREFFW.Name = "M_QREFFW"
        Me.M_QREFFW.Width = 60
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.DataPropertyName = "TLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Destino"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        Me.M_TLUGEN.Width = 260
        '
        'M_NROPLT
        '
        Me.M_NROPLT.DataPropertyName = "NROPLT"
        Me.M_NROPLT.HeaderText = "Nro. Paleta"
        Me.M_NROPLT.Name = "M_NROPLT"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(333, 451)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(109, 38)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(448, 451)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 38)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'lblCriterioLote
        '
        Me.lblCriterioLote.Location = New System.Drawing.Point(14, 15)
        Me.lblCriterioLote.Name = "lblCriterioLote"
        Me.lblCriterioLote.Size = New System.Drawing.Size(94, 16)
        Me.lblCriterioLote.TabIndex = 1
        Me.lblCriterioLote.Text = "Criterio de Lote : "
        Me.lblCriterioLote.Values.ExtraText = ""
        Me.lblCriterioLote.Values.Image = Nothing
        Me.lblCriterioLote.Values.Text = "Criterio de Lote : "
        '
        'txtCriterioLote
        '
        Me.txtCriterioLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCriterioLote, True)
        Me.txtCriterioLote.Location = New System.Drawing.Point(124, 12)
        Me.txtCriterioLote.MaxLength = 15
        Me.txtCriterioLote.Name = "txtCriterioLote"
        Me.txtCriterioLote.Size = New System.Drawing.Size(175, 19)
        Me.txtCriterioLote.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtCriterioLote, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ucWaybill_PreDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(569, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "'ucWaybill_PreDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRE-DESPACHO"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgBultosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents lblCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgBultosSeleccionados As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents txtBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroBultos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNrosBultos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
