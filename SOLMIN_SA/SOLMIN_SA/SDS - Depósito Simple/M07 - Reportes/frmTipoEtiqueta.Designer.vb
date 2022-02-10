<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoEtiqueta
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
        Me.txtLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblubicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtcantidadU = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblordencompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblcompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rdmercaderia = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rdnormal = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.KryptonPanel.Size = New System.Drawing.Size(375, 342)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLote)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblLote)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtAlmacen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtUbicacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblubicacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcantidad)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtcantidadU)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantidad)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblordencompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtReferencia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.rdmercaderia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.rdnormal)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(375, 342)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Impresiones de Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Impresiones de Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = " "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(210, 166)
        Me.txtLote.MaxLength = 21
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(130, 22)
        Me.txtLote.TabIndex = 8
        Me.txtLote.Visible = False
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(170, 168)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(34, 20)
        Me.lblLote.TabIndex = 15
        Me.lblLote.Text = "Lote"
        Me.lblLote.Values.ExtraText = ""
        Me.lblLote.Values.Image = Nothing
        Me.lblLote.Values.Text = "Lote"
        Me.lblLote.Visible = False
        '
        'txtAlmacen
        '
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.Location = New System.Drawing.Point(210, 140)
        Me.txtAlmacen.MaxLength = 30
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(130, 22)
        Me.txtAlmacen.TabIndex = 7
        Me.txtAlmacen.Visible = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(148, 142)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel1.TabIndex = 13
        Me.KryptonLabel1.Text = "Almacén"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Almacén"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Location = New System.Drawing.Point(210, 115)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(130, 22)
        Me.txtUbicacion.TabIndex = 6
        Me.txtUbicacion.Visible = False
        '
        'lblubicacion
        '
        Me.lblubicacion.Location = New System.Drawing.Point(142, 118)
        Me.lblubicacion.Name = "lblubicacion"
        Me.lblubicacion.Size = New System.Drawing.Size(64, 20)
        Me.lblubicacion.TabIndex = 11
        Me.lblubicacion.Text = "Ubicacion"
        Me.lblubicacion.Values.ExtraText = ""
        Me.lblubicacion.Values.Image = Nothing
        Me.lblubicacion.Values.Text = "Ubicacion"
        Me.lblubicacion.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.Location = New System.Drawing.Point(149, 68)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(59, 20)
        Me.lblcantidad.TabIndex = 10
        Me.lblcantidad.Text = "Cantidad"
        Me.lblcantidad.Values.ExtraText = ""
        Me.lblcantidad.Values.Image = Nothing
        Me.lblcantidad.Values.Text = "Cantidad"
        Me.lblcantidad.Visible = False
        '
        'txtcantidadU
        '
        Me.txtcantidadU.Location = New System.Drawing.Point(210, 65)
        Me.txtcantidadU.Name = "txtcantidadU"
        Me.txtcantidadU.Size = New System.Drawing.Size(130, 22)
        Me.txtcantidadU.TabIndex = 4
        Me.txtcantidadU.Text = "1"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(124, 248)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(105, 35)
        Me.KryptonButton2.TabIndex = 11
        Me.KryptonButton2.Text = "Imprimir"
        Me.KryptonButton2.Values.ExtraText = ""
        Me.KryptonButton2.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.printer2
        Me.KryptonButton2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton2.Values.Text = "Imprimir"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(249, 248)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(105, 35)
        Me.KryptonButton1.TabIndex = 12
        Me.KryptonButton1.Text = "Cancelar"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Cancelar"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(114, 203)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 10
        Me.txtCantidad.Text = "1"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(9, 203)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(113, 20)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Text = "Cantidad Etiquetas"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cantidad Etiquetas"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.Location = New System.Drawing.Point(210, 90)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(130, 22)
        Me.txtOrdenCompra.TabIndex = 5
        Me.txtOrdenCompra.Visible = False
        '
        'lblordencompra
        '
        Me.lblordencompra.Location = New System.Drawing.Point(119, 93)
        Me.lblordencompra.Name = "lblordencompra"
        Me.lblordencompra.Size = New System.Drawing.Size(92, 20)
        Me.lblordencompra.TabIndex = 2
        Me.lblordencompra.Text = "Orden Compra"
        Me.lblordencompra.Values.ExtraText = ""
        Me.lblordencompra.Values.Image = Nothing
        Me.lblordencompra.Values.Text = "Orden Compra"
        Me.lblordencompra.Visible = False
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(210, 37)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(130, 22)
        Me.txtReferencia.TabIndex = 3
        Me.txtReferencia.Visible = False
        '
        'lblcompra
        '
        Me.lblcompra.Location = New System.Drawing.Point(140, 40)
        Me.lblcompra.Name = "lblcompra"
        Me.lblcompra.Size = New System.Drawing.Size(67, 20)
        Me.lblcompra.TabIndex = 2
        Me.lblcompra.Text = "Referencia"
        Me.lblcompra.Values.ExtraText = ""
        Me.lblcompra.Values.Image = Nothing
        Me.lblcompra.Values.Text = "Referencia"
        Me.lblcompra.Visible = False
        '
        'rdmercaderia
        '
        Me.rdmercaderia.Location = New System.Drawing.Point(15, 40)
        Me.rdmercaderia.Name = "rdmercaderia"
        Me.rdmercaderia.Size = New System.Drawing.Size(84, 20)
        Me.rdmercaderia.TabIndex = 1
        Me.rdmercaderia.Text = "Mercaderia"
        Me.rdmercaderia.Values.ExtraText = ""
        Me.rdmercaderia.Values.Image = Nothing
        Me.rdmercaderia.Values.Text = "Mercaderia"
        '
        'rdnormal
        '
        Me.rdnormal.Checked = True
        Me.rdnormal.Location = New System.Drawing.Point(15, 15)
        Me.rdnormal.Name = "rdnormal"
        Me.rdnormal.Size = New System.Drawing.Size(204, 20)
        Me.rdnormal.TabIndex = 0
        Me.rdnormal.Text = "Etiquetas de Posicion / Ubicacion"
        Me.rdnormal.Values.ExtraText = ""
        Me.rdnormal.Values.Image = Nothing
        Me.rdnormal.Values.Text = "Etiquetas de Posicion / Ubicacion"
        '
        'frmTipoEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 342)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmTipoEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Etiqueta"
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblcompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rdmercaderia As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rdnormal As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblcantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcantidadU As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUbicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblubicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblordencompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
