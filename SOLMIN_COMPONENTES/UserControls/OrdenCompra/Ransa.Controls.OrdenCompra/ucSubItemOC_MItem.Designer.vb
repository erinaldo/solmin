<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSubItemOC_MItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSubItemOC_MItem))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cbxUnidadMedida = New Ransa.Controls.Unidad.ucUnidad_TxF01
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNroSubItemOCProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroItemOCProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroItemOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroSubItemOC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtImporteTotal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteUnitario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteUnitario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidadSubItem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidadItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcionSubItemES = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcionItemES = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroSubItemOCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroItemOCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(572, 166)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.cbxUnidadMedida)
        Me.KryptonPanel1.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel1.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel1.Controls.Add(Me.txtNroSubItemOCProveedor)
        Me.KryptonPanel1.Controls.Add(Me.lblNroItemOCProveedor)
        Me.KryptonPanel1.Controls.Add(Me.lblNroItemOC)
        Me.KryptonPanel1.Controls.Add(Me.txtNroSubItemOC)
        Me.KryptonPanel1.Controls.Add(Me.txtImporteTotal)
        Me.KryptonPanel1.Controls.Add(Me.lblImporteTotal)
        Me.KryptonPanel1.Controls.Add(Me.txtImporteUnitario)
        Me.KryptonPanel1.Controls.Add(Me.lblImporteUnitario)
        Me.KryptonPanel1.Controls.Add(Me.lblUnidadMedida)
        Me.KryptonPanel1.Controls.Add(Me.txtCantidadSubItem)
        Me.KryptonPanel1.Controls.Add(Me.lblCantidadItem)
        Me.KryptonPanel1.Controls.Add(Me.txtDescripcionSubItemES)
        Me.KryptonPanel1.Controls.Add(Me.lblDescripcionItemES)
        Me.KryptonPanel1.Controls.Add(Me.txtNroSubItemOCCliente)
        Me.KryptonPanel1.Controls.Add(Me.lblNroItemOCCliente)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(572, 166)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 1
        '
        'cbxUnidadMedida
        '
        Me.cbxUnidadMedida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cbxUnidadMedida.BackColor = System.Drawing.Color.Transparent
        Me.cbxUnidadMedida.Location = New System.Drawing.Point(384, 66)
        Me.cbxUnidadMedida.Name = "cbxUnidadMedida"
        Me.cbxUnidadMedida.pIsRequired = True
        Me.cbxUnidadMedida.Size = New System.Drawing.Size(173, 21)
        Me.cbxUnidadMedida.TabIndex = 14
        Me.cbxUnidadMedida.TipoUnidad = ""
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(467, 119)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(371, 119)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "&Guardar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Guardar"
        '
        'txtNroSubItemOCProveedor
        '
        Me.txtNroSubItemOCProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSubItemOCProveedor.Location = New System.Drawing.Point(473, 16)
        Me.txtNroSubItemOCProveedor.MaxLength = 20
        Me.txtNroSubItemOCProveedor.Name = "txtNroSubItemOCProveedor"
        Me.txtNroSubItemOCProveedor.Size = New System.Drawing.Size(84, 21)
        Me.txtNroSubItemOCProveedor.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtNroSubItemOCProveedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroItemOCProveedor
        '
        Me.lblNroItemOCProveedor.Location = New System.Drawing.Point(371, 19)
        Me.lblNroItemOCProveedor.Name = "lblNroItemOCProveedor"
        Me.lblNroItemOCProveedor.Size = New System.Drawing.Size(93, 19)
        Me.lblNroItemOCProveedor.TabIndex = 5
        Me.lblNroItemOCProveedor.Text = "Cód. Proveedor :"
        Me.lblNroItemOCProveedor.Values.ExtraText = ""
        Me.lblNroItemOCProveedor.Values.Image = Nothing
        Me.lblNroItemOCProveedor.Values.Text = "Cód. Proveedor :"
        '
        'lblNroItemOC
        '
        Me.lblNroItemOC.Location = New System.Drawing.Point(12, 19)
        Me.lblNroItemOC.Name = "lblNroItemOC"
        Me.lblNroItemOC.Size = New System.Drawing.Size(60, 19)
        Me.lblNroItemOC.TabIndex = 1
        Me.lblNroItemOC.Text = "Sub Item : "
        Me.lblNroItemOC.Values.ExtraText = ""
        Me.lblNroItemOC.Values.Image = Nothing
        Me.lblNroItemOC.Values.Text = "Sub Item : "
        '
        'txtNroSubItemOC
        '
        Me.txtNroSubItemOC.CausesValidation = False
        Me.txtNroSubItemOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSubItemOC.Enabled = False
        Me.txtNroSubItemOC.Location = New System.Drawing.Point(106, 16)
        Me.txtNroSubItemOC.MaxLength = 10
        Me.txtNroSubItemOC.Name = "txtNroSubItemOC"
        Me.txtNroSubItemOC.Size = New System.Drawing.Size(84, 21)
        Me.txtNroSubItemOC.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtNroSubItemOC.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroSubItemOC.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSubItemOC.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNroSubItemOC, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtImporteTotal
        '
        Me.TypeValidator.SetDecimales(Me.txtImporteTotal, 5)
        Me.txtImporteTotal.Location = New System.Drawing.Point(384, 91)
        Me.txtImporteTotal.MaxLength = 15
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(103, 21)
        Me.txtImporteTotal.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtImporteTotal.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporteTotal.TabIndex = 18
        Me.txtImporteTotal.Text = "0.00"
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporteTotal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.Location = New System.Drawing.Point(270, 94)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(84, 19)
        Me.lblImporteTotal.TabIndex = 17
        Me.lblImporteTotal.Text = "Importe Total : "
        Me.lblImporteTotal.Values.ExtraText = ""
        Me.lblImporteTotal.Values.Image = Nothing
        Me.lblImporteTotal.Values.Text = "Importe Total : "
        '
        'txtImporteUnitario
        '
        Me.TypeValidator.SetDecimales(Me.txtImporteUnitario, 5)
        Me.txtImporteUnitario.Location = New System.Drawing.Point(106, 91)
        Me.txtImporteUnitario.MaxLength = 10
        Me.txtImporteUnitario.Name = "txtImporteUnitario"
        Me.txtImporteUnitario.Size = New System.Drawing.Size(103, 21)
        Me.txtImporteUnitario.TabIndex = 16
        Me.txtImporteUnitario.Text = "0.00000"
        Me.txtImporteUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporteUnitario, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporteUnitario
        '
        Me.lblImporteUnitario.Location = New System.Drawing.Point(12, 94)
        Me.lblImporteUnitario.Name = "lblImporteUnitario"
        Me.lblImporteUnitario.Size = New System.Drawing.Size(98, 19)
        Me.lblImporteUnitario.TabIndex = 15
        Me.lblImporteUnitario.Text = "Importe Unitario : "
        Me.lblImporteUnitario.Values.ExtraText = ""
        Me.lblImporteUnitario.Values.Image = Nothing
        Me.lblImporteUnitario.Values.Text = "Importe Unitario : "
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.Location = New System.Drawing.Point(270, 69)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(109, 19)
        Me.lblUnidadMedida.TabIndex = 13
        Me.lblUnidadMedida.Text = "Unidad de Medida : "
        Me.lblUnidadMedida.Values.ExtraText = ""
        Me.lblUnidadMedida.Values.Image = Nothing
        Me.lblUnidadMedida.Values.Text = "Unidad de Medida : "
        '
        'txtCantidadSubItem
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadSubItem, 5)
        Me.txtCantidadSubItem.Location = New System.Drawing.Point(106, 66)
        Me.txtCantidadSubItem.MaxLength = 10
        Me.txtCantidadSubItem.Name = "txtCantidadSubItem"
        Me.txtCantidadSubItem.Size = New System.Drawing.Size(103, 21)
        Me.txtCantidadSubItem.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtCantidadSubItem.TabIndex = 12
        Me.txtCantidadSubItem.Text = "0.00"
        Me.txtCantidadSubItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadSubItem, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadItem
        '
        Me.lblCantidadItem.Location = New System.Drawing.Point(12, 69)
        Me.lblCantidadItem.Name = "lblCantidadItem"
        Me.lblCantidadItem.Size = New System.Drawing.Size(61, 19)
        Me.lblCantidadItem.TabIndex = 11
        Me.lblCantidadItem.Text = "Cantidad : "
        Me.lblCantidadItem.Values.ExtraText = ""
        Me.lblCantidadItem.Values.Image = Nothing
        Me.lblCantidadItem.Values.Text = "Cantidad : "
        '
        'txtDescripcionSubItemES
        '
        Me.txtDescripcionSubItemES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionSubItemES.Location = New System.Drawing.Point(106, 41)
        Me.txtDescripcionSubItemES.MaxLength = 100
        Me.txtDescripcionSubItemES.Name = "txtDescripcionSubItemES"
        Me.txtDescripcionSubItemES.Size = New System.Drawing.Size(451, 21)
        Me.txtDescripcionSubItemES.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtDescripcionSubItemES.TabIndex = 8
        Me.TypeValidator.SetTypes(Me.txtDescripcionSubItemES, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblDescripcionItemES
        '
        Me.lblDescripcionItemES.Location = New System.Drawing.Point(12, 44)
        Me.lblDescripcionItemES.Name = "lblDescripcionItemES"
        Me.lblDescripcionItemES.Size = New System.Drawing.Size(74, 19)
        Me.lblDescripcionItemES.TabIndex = 7
        Me.lblDescripcionItemES.Text = "Descripción : "
        Me.lblDescripcionItemES.Values.ExtraText = ""
        Me.lblDescripcionItemES.Values.Image = Nothing
        Me.lblDescripcionItemES.Values.Text = "Descripción : "
        '
        'txtNroSubItemOCCliente
        '
        Me.txtNroSubItemOCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSubItemOCCliente.Location = New System.Drawing.Point(281, 16)
        Me.txtNroSubItemOCCliente.MaxLength = 20
        Me.txtNroSubItemOCCliente.Name = "txtNroSubItemOCCliente"
        Me.txtNroSubItemOCCliente.Size = New System.Drawing.Size(84, 21)
        Me.txtNroSubItemOCCliente.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtNroSubItemOCCliente.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroSubItemOCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroItemOCCliente
        '
        Me.lblNroItemOCCliente.Location = New System.Drawing.Point(196, 19)
        Me.lblNroItemOCCliente.Name = "lblNroItemOCCliente"
        Me.lblNroItemOCCliente.Size = New System.Drawing.Size(76, 19)
        Me.lblNroItemOCCliente.TabIndex = 3
        Me.lblNroItemOCCliente.Text = "Cód. Cliente : "
        Me.lblNroItemOCCliente.Values.ExtraText = ""
        Me.lblNroItemOCCliente.Values.Image = Nothing
        Me.lblNroItemOCCliente.Values.Text = "Cód. Cliente : "
        '
        'ucSubItemOC_MItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 166)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 200)
        Me.MinimumSize = New System.Drawing.Size(580, 200)
        Me.Name = "ucSubItemOC_MItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Item"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cbxUnidadMedida As Ransa.Controls.Unidad.ucUnidad_TxF01
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtNroSubItemOCProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroItemOCProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblNroItemOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroSubItemOC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtImporteTotal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblImporteTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtImporteUnitario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblImporteUnitario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCantidadSubItem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCantidadItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcionSubItemES As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcionItemES As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroSubItemOCCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroItemOCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
End Class
