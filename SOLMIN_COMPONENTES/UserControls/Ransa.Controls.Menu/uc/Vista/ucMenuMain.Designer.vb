<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenuMain
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.UcMenuBusq = New Ransa.Controls.Menu.ucMenuBusq
    Me.UcOpcionBusq = New Ransa.Controls.Menu.ucOpcionBusq
    Me.Uc_CboAplicacion1 = New Ransa.Controls.Menu.uc_CboAplicacion
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SuspendLayout()
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
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboAplicacion1)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblAplicacion)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(820, 66)
    Me.KryptonHeaderGroup1.TabIndex = 40
    Me.KryptonHeaderGroup1.Text = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(546, 12)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(234, 21)
    Me.txtDescripcion.TabIndex = 5
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(495, 12)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel2.TabIndex = 4
    Me.KryptonLabel2.Text = "Menú :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Menú :"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(450, 12)
    Me.txtCodigo.MaxLength = 2
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(39, 21)
    Me.txtCodigo.TabIndex = 3
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(392, 12)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(52, 19)
    Me.KryptonLabel3.TabIndex = 2
    Me.KryptonLabel3.Text = "Código :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Código :"
    '
    'lblAplicacion
    '
    Me.lblAplicacion.Location = New System.Drawing.Point(13, 12)
    Me.lblAplicacion.Name = "lblAplicacion"
    Me.lblAplicacion.Size = New System.Drawing.Size(67, 19)
    Me.lblAplicacion.TabIndex = 0
    Me.lblAplicacion.Text = "Aplicación :"
    Me.lblAplicacion.Values.ExtraText = ""
    Me.lblAplicacion.Values.Image = Nothing
    Me.lblAplicacion.Values.Text = "Aplicación :"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 66)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.UcMenuBusq)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.UcOpcionBusq)
    Me.SplitContainer1.Size = New System.Drawing.Size(820, 358)
    Me.SplitContainer1.SplitterDistance = 181
    Me.SplitContainer1.TabIndex = 41
    '
    'UcMenuBusq
    '
    Me.UcMenuBusq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcMenuBusq.Location = New System.Drawing.Point(0, 0)
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
    Me.UcMenuBusq.Size = New System.Drawing.Size(820, 181)
    Me.UcMenuBusq.TabIndex = 0
    '
    'UcOpcionBusq
    '
    Me.UcOpcionBusq.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcOpcionBusq.Location = New System.Drawing.Point(0, 0)
    Me.UcOpcionBusq.Name = "UcOpcionBusq"
    Me.UcOpcionBusq.pInfo_MMCAPL_CodApl = ""
    Me.UcOpcionBusq.pInfo_MMCMNU_CodMenu = ""
    Me.UcOpcionBusq.pInfo_MMCOPC_CodOpc = New Decimal(New Integer() {0, 0, 0, 0})
    Me.UcOpcionBusq.pInfo_MMDAPL = ""
    Me.UcOpcionBusq.pInfo_MMDOPC = "0"
    Me.UcOpcionBusq.pInfo_MMTMNU = ""
    Me.UcOpcionBusq.pnumReg = CType(0, Long)
    Me.UcOpcionBusq.pVerBotonBuscar = False
    Me.UcOpcionBusq.pVerBotonEliminar = False
        'Me.UcOpcionBusq.pVerBotonExportar = False
    Me.UcOpcionBusq.pVerBotonModificar = False
    Me.UcOpcionBusq.pVerBotonNuevo = False
    Me.UcOpcionBusq.Size = New System.Drawing.Size(820, 173)
    Me.UcOpcionBusq.TabIndex = 0
    '
    'Uc_CboAplicacion1
    '
    Me.Uc_CboAplicacion1.Location = New System.Drawing.Point(87, 12)
    Me.Uc_CboAplicacion1.Name = "Uc_CboAplicacion1"
    Me.Uc_CboAplicacion1.Size = New System.Drawing.Size(299, 22)
    Me.Uc_CboAplicacion1.TabIndex = 1
    '
    'ucMenuMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.KryptonHeaderGroup1)
    Me.Name = "ucMenuMain"
    Me.Size = New System.Drawing.Size(820, 424)
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblAplicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Uc_CboAplicacion1 As Ransa.Controls.Menu.uc_CboAplicacion
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcMenuBusq As Ransa.Controls.Menu.ucMenuBusq
    Friend WithEvents UcOpcionBusq As Ransa.Controls.Menu.ucOpcionBusq

End Class
