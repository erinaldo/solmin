<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.UcMenuBusq = New Ransa.Controls.Menu.ucMenuBusq
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.UcOpcionBusq = New Ransa.Controls.Menu.ucOpcionBusq
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(938, 557)
    Me.KryptonPanel.TabIndex = 0
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.UcMenuBusq)
    Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.UcOpcionBusq)
    Me.SplitContainer1.Size = New System.Drawing.Size(938, 557)
    Me.SplitContainer1.SplitterDistance = 312
    Me.SplitContainer1.TabIndex = 0
    '
    'UcMenuBusq
    '
    Me.UcMenuBusq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcMenuBusq.Location = New System.Drawing.Point(0, 68)
    Me.UcMenuBusq.Name = "UcMenuBusq"
    Me.UcMenuBusq.pInfo_MMCAPL_CodApl = ""
    Me.UcMenuBusq.pInfo_MMCMNU_CodMenu = ""
    Me.UcMenuBusq.pnumReg = CType(0, Long)
    Me.UcMenuBusq.pVerBotonBuscar = True
    Me.UcMenuBusq.pVerBotonEliminar = True
    Me.UcMenuBusq.pVerBotonExportar = True
    Me.UcMenuBusq.pVerBotonModificar = True
    Me.UcMenuBusq.pVerBotonNuevo = True
    Me.UcMenuBusq.pVerBotonOpcion = True
    Me.UcMenuBusq.Size = New System.Drawing.Size(938, 244)
    Me.UcMenuBusq.TabIndex = 39
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
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboAplicacion1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblAplicacion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(938, 68)
    Me.KryptonHeaderGroup1.TabIndex = 38
    Me.KryptonHeaderGroup1.Text = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(87, 12)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(231, 22)
    Me.Uc_CboAplicacion1.TabIndex = 77
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(492, 13)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(234, 21)
    Me.txtDescripcion.TabIndex = 65
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(441, 15)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel2.TabIndex = 66
    Me.KryptonLabel2.Text = "Menú :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Menú :"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(396, 13)
    Me.txtCodigo.MaxLength = 2
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(39, 21)
    Me.txtCodigo.TabIndex = 63
    '
    'lblAplicacion
    '
    Me.lblAplicacion.Location = New System.Drawing.Point(14, 14)
    Me.lblAplicacion.Name = "lblAplicacion"
    Me.lblAplicacion.Size = New System.Drawing.Size(67, 19)
    Me.lblAplicacion.TabIndex = 64
    Me.lblAplicacion.Text = "Aplicación :"
    Me.lblAplicacion.Values.ExtraText = ""
    Me.lblAplicacion.Values.Image = Nothing
    Me.lblAplicacion.Values.Text = "Aplicación :"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(338, 14)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(52, 19)
    Me.KryptonLabel3.TabIndex = 64
    Me.KryptonLabel3.Text = "Código :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Código :"
    '
    'UcOpcionBusq
    '
    Me.UcOpcionBusq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOpcionBusq.Location = New System.Drawing.Point(0, 0)
    Me.UcOpcionBusq.Name = "UcOpcionBusq"
    Me.UcOpcionBusq.pInfo_MMCAPL_CodApl = ""
    Me.UcOpcionBusq.pInfo_MMCMNU_CodMenu = ""
    Me.UcOpcionBusq.pInfo_MMCOPC_CodOpc = New Decimal(New Integer() {0, 0, 0, 0})
    Me.UcOpcionBusq.pnumReg = CType(0, Long)
    Me.UcOpcionBusq.pVerBotonBuscar = False
    Me.UcOpcionBusq.pVerBotonEliminar = False
        'Me.UcOpcionBusq.pVerBotonExportar = False
    Me.UcOpcionBusq.pVerBotonModificar = False
    Me.UcOpcionBusq.pVerBotonNuevo = False
    Me.UcOpcionBusq.Size = New System.Drawing.Size(938, 241)
    Me.UcOpcionBusq.TabIndex = 1
    '
    'FrmMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(938, 557)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "FrmMenu"
    Me.Text = "Menús"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblAplicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcOpcionBusq As Ransa.Controls.Menu.ucOpcionBusq
    Friend WithEvents UcMenuBusq As Ransa.Controls.Menu.ucMenuBusq
    'Friend WithEvents UcAplicacion1 As Ransa.Controls.Menu.ucAplicacion
    'Friend WithEvents UcAplicacion1 As Ransa.Controls.Menu.ucAplicacion
    'Friend WithEvents UcAplicacion1 As Ransa.Controls.Menu.UcAplicacion
    'Friend WithEvents UcAplicacion1 As Ransa.Controls.Menu.ucAplicacion'
End Class
