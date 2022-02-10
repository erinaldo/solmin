<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisarOCPortalResumen
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge9 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtCargaRecibida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnRecibido = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge8 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge7 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtCargaAtendida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAtendido = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge6 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtCargaEmbarcada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnEmbarcado = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtCargaTrasladoCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btntrasladoCliente = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtRecibidoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnRecibidoAlmacen = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(283, 207)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnCerrar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCargaRecibida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCargaAtendida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCargaEmbarcada)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCargaTrasladoCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRecibidoAlmacen)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(283, 207)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 35
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnCerrar
        '
        Me.btnCerrar.ExtraText = ""
        Me.btnCerrar.Image = Nothing
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.ToolTipImage = Nothing
        Me.btnCerrar.UniqueName = "AD41301713BB4036AD41301713BB4036"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Carga Recibida"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Carga Recibida"
        '
        'KryptonBorderEdge9
        '
        Me.KryptonBorderEdge9.AutoSize = False
        Me.KryptonBorderEdge9.Location = New System.Drawing.Point(123, 9)
        Me.KryptonBorderEdge9.Name = "KryptonBorderEdge9"
        Me.KryptonBorderEdge9.Size = New System.Drawing.Size(1, 182)
        Me.KryptonBorderEdge9.TabIndex = 34
        Me.KryptonBorderEdge9.Text = "KryptonBorderEdge9"
        '
        'txtCargaRecibida
        '
        Me.txtCargaRecibida.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnRecibido})
        Me.txtCargaRecibida.Location = New System.Drawing.Point(130, 16)
        Me.txtCargaRecibida.Name = "txtCargaRecibida"
        Me.txtCargaRecibida.ReadOnly = True
        Me.txtCargaRecibida.Size = New System.Drawing.Size(131, 21)
        Me.txtCargaRecibida.TabIndex = 2
        Me.txtCargaRecibida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRecibido
        '
        Me.btnRecibido.ExtraText = ""
        Me.btnRecibido.Image = Nothing
        Me.btnRecibido.Text = ""
        Me.btnRecibido.ToolTipBody = "Ver Detalles"
        Me.btnRecibido.ToolTipImage = Nothing
        Me.btnRecibido.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnRecibido.UniqueName = "EC192E90D8654970EC192E90D8654970"
        Me.btnRecibido.Visible = False
        '
        'KryptonBorderEdge8
        '
        Me.KryptonBorderEdge8.AutoSize = False
        Me.KryptonBorderEdge8.Location = New System.Drawing.Point(12, 9)
        Me.KryptonBorderEdge8.Name = "KryptonBorderEdge8"
        Me.KryptonBorderEdge8.Size = New System.Drawing.Size(1, 182)
        Me.KryptonBorderEdge8.TabIndex = 33
        Me.KryptonBorderEdge8.Text = "KryptonBorderEdge8"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(19, 93)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(103, 19)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Carga De Aduanas"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Carga De Aduanas"
        '
        'KryptonBorderEdge7
        '
        Me.KryptonBorderEdge7.AutoSize = False
        Me.KryptonBorderEdge7.Location = New System.Drawing.Point(267, 9)
        Me.KryptonBorderEdge7.Name = "KryptonBorderEdge7"
        Me.KryptonBorderEdge7.Size = New System.Drawing.Size(1, 182)
        Me.KryptonBorderEdge7.TabIndex = 24
        Me.KryptonBorderEdge7.Text = "KryptonBorderEdge7"
        '
        'txtCargaAtendida
        '
        Me.txtCargaAtendida.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAtendido})
        Me.txtCargaAtendida.Location = New System.Drawing.Point(130, 89)
        Me.txtCargaAtendida.Name = "txtCargaAtendida"
        Me.txtCargaAtendida.ReadOnly = True
        Me.txtCargaAtendida.Size = New System.Drawing.Size(131, 21)
        Me.txtCargaAtendida.TabIndex = 4
        Me.txtCargaAtendida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAtendido
        '
        Me.btnAtendido.ExtraText = ""
        Me.btnAtendido.Image = Nothing
        Me.btnAtendido.Text = ""
        Me.btnAtendido.ToolTipBody = "Ver Detalles"
        Me.btnAtendido.ToolTipImage = Nothing
        Me.btnAtendido.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAtendido.UniqueName = "B6A1384573BE41B6B6A1384573BE41B6"
        '
        'KryptonBorderEdge6
        '
        Me.KryptonBorderEdge6.Location = New System.Drawing.Point(12, 9)
        Me.KryptonBorderEdge6.Name = "KryptonBorderEdge6"
        Me.KryptonBorderEdge6.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge6.TabIndex = 23
        Me.KryptonBorderEdge6.Text = "KryptonBorderEdge6"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(19, 55)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(98, 19)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Carga Embarcada"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Carga Embarcada"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(12, 46)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge5.TabIndex = 22
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'txtCargaEmbarcada
        '
        Me.txtCargaEmbarcada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnEmbarcado})
        Me.txtCargaEmbarcada.Location = New System.Drawing.Point(130, 52)
        Me.txtCargaEmbarcada.Name = "txtCargaEmbarcada"
        Me.txtCargaEmbarcada.ReadOnly = True
        Me.txtCargaEmbarcada.Size = New System.Drawing.Size(131, 21)
        Me.txtCargaEmbarcada.TabIndex = 6
        Me.txtCargaEmbarcada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCargaEmbarcada, "Ver Detalles")
        '
        'btnEmbarcado
        '
        Me.btnEmbarcado.ExtraText = ""
        Me.btnEmbarcado.Image = Nothing
        Me.btnEmbarcado.Text = ""
        Me.btnEmbarcado.ToolTipBody = "Ver Detalles"
        Me.btnEmbarcado.ToolTipImage = Nothing
        Me.btnEmbarcado.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnEmbarcado.UniqueName = "DD903A7AEB8F4051DD903A7AEB8F4051"
        Me.btnEmbarcado.Visible = False
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(12, 190)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge4.TabIndex = 21
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge4"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(19, 154)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(96, 33)
        Me.KryptonLabel10.TabIndex = 14
        Me.KryptonLabel10.Text = "Carga Trasladada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al Cliente"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Carga Trasladada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al Cliente"
        '
        'KryptonBorderEdge3
        '
        Me.KryptonBorderEdge3.Location = New System.Drawing.Point(12, 117)
        Me.KryptonBorderEdge3.Name = "KryptonBorderEdge3"
        Me.KryptonBorderEdge3.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge3.TabIndex = 20
        Me.KryptonBorderEdge3.Text = "KryptonBorderEdge3"
        '
        'txtCargaTrasladoCliente
        '
        Me.txtCargaTrasladoCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btntrasladoCliente})
        Me.txtCargaTrasladoCliente.Location = New System.Drawing.Point(130, 162)
        Me.txtCargaTrasladoCliente.Name = "txtCargaTrasladoCliente"
        Me.txtCargaTrasladoCliente.ReadOnly = True
        Me.txtCargaTrasladoCliente.Size = New System.Drawing.Size(131, 21)
        Me.txtCargaTrasladoCliente.TabIndex = 15
        Me.txtCargaTrasladoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btntrasladoCliente
        '
        Me.btntrasladoCliente.ExtraText = ""
        Me.btntrasladoCliente.Image = Nothing
        Me.btntrasladoCliente.Text = ""
        Me.btntrasladoCliente.ToolTipBody = "Ver Detalles"
        Me.btntrasladoCliente.ToolTipImage = Nothing
        Me.btntrasladoCliente.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btntrasladoCliente.UniqueName = "F90468F382994D56F90468F382994D56"
        Me.btntrasladoCliente.Visible = False
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(12, 81)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge2.TabIndex = 19
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(19, 118)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(86, 33)
        Me.KryptonLabel9.TabIndex = 16
        Me.KryptonLabel9.Text = "Carga Recibido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en almacen"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Carga Recibido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en almacen"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(12, 153)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(255, 1)
        Me.KryptonBorderEdge1.TabIndex = 18
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'txtRecibidoAlmacen
        '
        Me.txtRecibidoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnRecibidoAlmacen})
        Me.txtRecibidoAlmacen.Location = New System.Drawing.Point(130, 125)
        Me.txtRecibidoAlmacen.Name = "txtRecibidoAlmacen"
        Me.txtRecibidoAlmacen.ReadOnly = True
        Me.txtRecibidoAlmacen.Size = New System.Drawing.Size(131, 21)
        Me.txtRecibidoAlmacen.TabIndex = 17
        Me.txtRecibidoAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtRecibidoAlmacen, "Ver Detalles")
        '
        'btnRecibidoAlmacen
        '
        Me.btnRecibidoAlmacen.ExtraText = ""
        Me.btnRecibidoAlmacen.Image = Nothing
        Me.btnRecibidoAlmacen.Text = ""
        Me.btnRecibidoAlmacen.ToolTipBody = "Ver Detalles"
        Me.btnRecibidoAlmacen.ToolTipImage = Nothing
        Me.btnRecibidoAlmacen.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnRecibidoAlmacen.UniqueName = "07D821901E6E4C0007D821901E6E4C00"
        '
        'frmRevisarOCPortalResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 207)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRevisarOCPortalResumen"
        Me.Text = "Resumen O/C Portal"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    Friend WithEvents txtCargaEmbarcada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCargaAtendida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCargaRecibida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCargaTrasladoCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecibidoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonBorderEdge7 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge6 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge9 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge8 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents btnRecibido As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnRecibidoAlmacen As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btntrasladoCliente As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnEmbarcado As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnAtendido As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
