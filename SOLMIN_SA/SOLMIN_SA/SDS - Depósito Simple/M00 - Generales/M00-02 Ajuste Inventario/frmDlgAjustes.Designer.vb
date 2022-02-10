<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDlgAjustes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDlgAjustes))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtTipoDesOutotec = New Ransa.Utilitario.ucAyuda
        Me.lblTipoDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDesPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDesCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarDespachoItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtTipoDesOutotec)
        Me.KryptonPanel.Controls.Add(Me.lblTipoDespacho)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.txtRecObservacion)
        Me.KryptonPanel.Controls.Add(Me.txtDesPeso)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtDesCantidad)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarDespachoItem)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(344, 134)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtTipoDesOutotec
        '
        Me.txtTipoDesOutotec.BackColor = System.Drawing.Color.White
        Me.txtTipoDesOutotec.DataSource = Nothing
        Me.txtTipoDesOutotec.DispleyMember = ""
        Me.txtTipoDesOutotec.Enabled = False
        Me.txtTipoDesOutotec.ListColumnas = Nothing
        Me.txtTipoDesOutotec.Location = New System.Drawing.Point(78, 41)
        Me.txtTipoDesOutotec.Name = "txtTipoDesOutotec"
        Me.txtTipoDesOutotec.Obligatorio = True
        Me.txtTipoDesOutotec.Size = New System.Drawing.Size(255, 21)
        Me.txtTipoDesOutotec.TabIndex = 31
        Me.txtTipoDesOutotec.ValueMember = ""
        '
        'lblTipoDespacho
        '
        Me.lblTipoDespacho.Location = New System.Drawing.Point(9, 45)
        Me.lblTipoDespacho.Name = "lblTipoDespacho"
        Me.lblTipoDespacho.Size = New System.Drawing.Size(68, 20)
        Me.lblTipoDespacho.TabIndex = 38
        Me.lblTipoDespacho.Text = "Tipo Dsp. : "
        Me.lblTipoDespacho.Values.ExtraText = ""
        Me.lblTipoDespacho.Values.Image = Nothing
        Me.lblTipoDespacho.Values.Text = "Tipo Dsp. : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(19, 70)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel7.TabIndex = 39
        Me.KryptonLabel7.Text = "Observ. : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observ. : "
        '
        'txtRecObservacion
        '
        Me.txtRecObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecObservacion.Location = New System.Drawing.Point(79, 68)
        Me.txtRecObservacion.MaxLength = 25
        Me.txtRecObservacion.Name = "txtRecObservacion"
        Me.txtRecObservacion.Size = New System.Drawing.Size(254, 22)
        Me.txtRecObservacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtRecObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtRecObservacion.TabIndex = 32
        '
        'txtDesPeso
        '
        Me.txtDesPeso.Location = New System.Drawing.Point(235, 12)
        Me.txtDesPeso.Name = "txtDesPeso"
        Me.txtDesPeso.Size = New System.Drawing.Size(97, 22)
        Me.txtDesPeso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesPeso.TabIndex = 28
        Me.txtDesPeso.Text = "0.00"
        Me.txtDesPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(187, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel2.TabIndex = 36
        Me.KryptonLabel2.Text = "Peso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Peso : "
        '
        'txtDesCantidad
        '
        Me.txtDesCantidad.Location = New System.Drawing.Point(78, 12)
        Me.txtDesCantidad.Name = "txtDesCantidad"
        Me.txtDesCantidad.Size = New System.Drawing.Size(97, 22)
        Me.txtDesCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesCantidad.TabIndex = 26
        Me.txtDesCantidad.Text = "0.00"
        Me.txtDesCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel4.TabIndex = 35
        Me.KryptonLabel4.Text = "Cantidad : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad : "
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(182, 96)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAgregarDespachoItem
        '
        Me.btnAgregarDespachoItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarDespachoItem.Location = New System.Drawing.Point(96, 96)
        Me.btnAgregarDespachoItem.Name = "btnAgregarDespachoItem"
        Me.btnAgregarDespachoItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarDespachoItem.TabIndex = 33
        Me.btnAgregarDespachoItem.Text = "Agregar"
        Me.btnAgregarDespachoItem.Values.ExtraText = ""
        Me.btnAgregarDespachoItem.Values.Image = CType(resources.GetObject("btnAgregarDespachoItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarDespachoItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarDespachoItem.Values.Text = "Agregar"
        '
        'frmDlgAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 134)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmDlgAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtTipoDesOutotec As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblTipoDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDesPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDesCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarDespachoItem As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
