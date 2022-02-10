<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAplicacionMain
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UcAplicacionBusq = New Ransa.Controls.Menu.ucAplicacionBusq
        Me.UcMenuBusq = New Ransa.Controls.Menu.ucMenuBusq
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
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(693, 66)
        Me.KryptonHeaderGroup1.TabIndex = 39
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
        Me.txtDescripcion.Location = New System.Drawing.Point(274, 12)
        Me.txtDescripcion.MaxLength = 25
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(212, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(153, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Descripción Inicial :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción Inicial :"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(74, 12)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(51, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel3.TabIndex = 0
        Me.KryptonLabel3.Text = "Código :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Código :"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcAplicacionBusq)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcMenuBusq)
        Me.SplitContainer1.Size = New System.Drawing.Size(693, 426)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 40
        '
        'UcAplicacionBusq
        '
        Me.UcAplicacionBusq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAplicacionBusq.Location = New System.Drawing.Point(0, 0)
        Me.UcAplicacionBusq.Name = "UcAplicacionBusq"
        Me.UcAplicacionBusq.pInfo_MMCAPL_CodApl = ""
        Me.UcAplicacionBusq.pnumReg = CType(0, Long)
        Me.UcAplicacionBusq.pVerBotonBuscar = True
        Me.UcAplicacionBusq.pVerBotonEliminar = True
        Me.UcAplicacionBusq.pVerBotonExportar = True
        Me.UcAplicacionBusq.pVerBotonMenu = True
        Me.UcAplicacionBusq.pVerBotonModificar = True
        Me.UcAplicacionBusq.pVerBotonNuevo = True
        Me.UcAplicacionBusq.Size = New System.Drawing.Size(693, 233)
        Me.UcAplicacionBusq.TabIndex = 0
        '
        'UcMenuBusq
        '
        Me.UcMenuBusq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuBusq.Location = New System.Drawing.Point(0, 0)
        Me.UcMenuBusq.Name = "UcMenuBusq"
        Me.UcMenuBusq.pInfo_MMCAPL_CodApl = ""
        Me.UcMenuBusq.pInfo_MMCMNU_CodMenu = ""
        Me.UcMenuBusq.pnumReg = CType(0, Long)
        Me.UcMenuBusq.pVerBotonBuscar = False
        Me.UcMenuBusq.pVerBotonEliminar = False
        Me.UcMenuBusq.pVerBotonExportar = False
        Me.UcMenuBusq.pVerBotonModificar = False
        Me.UcMenuBusq.pVerBotonNuevo = False
        Me.UcMenuBusq.pVerBotonOpcion = False
        Me.UcMenuBusq.Size = New System.Drawing.Size(693, 189)
        Me.UcMenuBusq.TabIndex = 0
        '
        'ucAplicacionMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Name = "ucAplicacionMain"
        Me.Size = New System.Drawing.Size(693, 492)
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
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcAplicacionBusq As Ransa.Controls.Menu.ucAplicacionBusq
    Friend WithEvents UcMenuBusq As Ransa.Controls.Menu.ucMenuBusq

End Class
