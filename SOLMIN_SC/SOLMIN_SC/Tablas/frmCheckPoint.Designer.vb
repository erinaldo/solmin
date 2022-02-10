<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckPoint
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
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carga Internacional", 2, 0)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aduanero", 2, 0)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CheckPoints", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckPoint))
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aduanero", 6, 6)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carga Internacional", 6, 6)
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.tvwCheckPoint = New System.Windows.Forms.TreeView
        Me.cmsArbol = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActivarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DesactivarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtSeg = New System.Windows.Forms.TextBox
        Me.txtCheck = New System.Windows.Forms.TextBox
        Me.txtDiv = New System.Windows.Forms.TextBox
        Me.txtComp = New System.Windows.Forms.TextBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.lblSeg = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDiv = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tvwSA = New System.Windows.Forms.TreeView
        Me.cmsCheck = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DesasignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tvwCI = New System.Windows.Forms.TreeView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.oDsChk = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        Me.cmsArbol.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        Me.cmsCheck.SuspendLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.oDsChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup2)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup3)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup4)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(952, 696)
        Me.KryptonSplitContainer1.SplitterDistance = 471
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(471, 696)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 3
        Me.KryptonHeaderGroup2.Text = "CheckPoints"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "CheckPoints"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.tvwCheckPoint)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtSeg)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtCheck)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtDiv)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtComp)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnCancelar)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnGrabar)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.lblSeg)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.lblDiv)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.lblComp)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.lblDescripcion)
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(469, 674)
        Me.KryptonSplitContainer2.SplitterDistance = 493
        Me.KryptonSplitContainer2.TabIndex = 0
        '
        'tvwCheckPoint
        '
        Me.tvwCheckPoint.ContextMenuStrip = Me.cmsArbol
        Me.tvwCheckPoint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwCheckPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwCheckPoint.ImageIndex = 1
        Me.tvwCheckPoint.ImageList = Me.ImageList1
        Me.tvwCheckPoint.Location = New System.Drawing.Point(0, 0)
        Me.tvwCheckPoint.Name = "tvwCheckPoint"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "CI"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Tag = "E"
        TreeNode2.Text = "Carga Internacional"
        TreeNode2.ToolTipText = "Reporte Estadístico Mensual de Carga Internacional"
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = "AD"
        TreeNode7.SelectedImageIndex = 0
        TreeNode7.Tag = "A"
        TreeNode7.Text = "Aduanero"
        TreeNode7.ToolTipText = "Reporte Estadístico Mensual de Seguimiento Aduanero"
        TreeNode8.ImageIndex = 3
        TreeNode8.Name = "Raiz"
        TreeNode8.SelectedImageIndex = 3
        TreeNode8.Text = "CheckPoints"
        Me.tvwCheckPoint.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.tvwCheckPoint.SelectedImageIndex = 2
        Me.tvwCheckPoint.Size = New System.Drawing.Size(469, 493)
        Me.tvwCheckPoint.TabIndex = 2
        '
        'cmsArbol
        '
        Me.cmsArbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmsArbol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.AsignarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ActivarToolStripMenuItem, Me.DesactivarToolStripMenuItem})
        Me.cmsArbol.Name = "cmsArbol"
        Me.cmsArbol.Size = New System.Drawing.Size(129, 114)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'AsignarToolStripMenuItem
        '
        Me.AsignarToolStripMenuItem.Name = "AsignarToolStripMenuItem"
        Me.AsignarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AsignarToolStripMenuItem.Text = "Asignar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ActivarToolStripMenuItem
        '
        Me.ActivarToolStripMenuItem.Name = "ActivarToolStripMenuItem"
        Me.ActivarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ActivarToolStripMenuItem.Text = "Activar"
        '
        'DesactivarToolStripMenuItem
        '
        Me.DesactivarToolStripMenuItem.Name = "DesactivarToolStripMenuItem"
        Me.DesactivarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DesactivarToolStripMenuItem.Text = "Desactivar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Tips.ico")
        Me.ImageList1.Images.SetKeyName(1, "Error.ico")
        Me.ImageList1.Images.SetKeyName(2, "Tipo.ico")
        Me.ImageList1.Images.SetKeyName(3, "Maestro.ico")
        Me.ImageList1.Images.SetKeyName(4, "Activo.ico")
        Me.ImageList1.Images.SetKeyName(5, "Inactivo.ico")
        Me.ImageList1.Images.SetKeyName(6, "Parcial.ico")
        '
        'txtSeg
        '
        Me.txtSeg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSeg.Location = New System.Drawing.Point(85, 98)
        Me.txtSeg.Name = "txtSeg"
        Me.txtSeg.ReadOnly = True
        Me.txtSeg.Size = New System.Drawing.Size(200, 20)
        Me.txtSeg.TabIndex = 9
        '
        'txtCheck
        '
        Me.txtCheck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheck.Location = New System.Drawing.Point(85, 72)
        Me.txtCheck.MaxLength = 50
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(350, 20)
        Me.txtCheck.TabIndex = 8
        '
        'txtDiv
        '
        Me.txtDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiv.Location = New System.Drawing.Point(85, 46)
        Me.txtDiv.Name = "txtDiv"
        Me.txtDiv.ReadOnly = True
        Me.txtDiv.Size = New System.Drawing.Size(350, 20)
        Me.txtDiv.TabIndex = 7
        '
        'txtComp
        '
        Me.txtComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComp.Location = New System.Drawing.Point(85, 20)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.ReadOnly = True
        Me.txtComp.Size = New System.Drawing.Size(350, 20)
        Me.txtComp.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(304, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrabar.Location = New System.Drawing.Point(128, 131)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(64, 25)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'lblSeg
        '
        Me.lblSeg.Location = New System.Drawing.Point(11, 102)
        Me.lblSeg.Name = "lblSeg"
        Me.lblSeg.Size = New System.Drawing.Size(79, 16)
        Me.lblSeg.TabIndex = 3
        Me.lblSeg.Text = "Seguimiento :"
        Me.lblSeg.Values.ExtraText = ""
        Me.lblSeg.Values.Image = Nothing
        Me.lblSeg.Values.Text = "Seguimiento :"
        '
        'lblDiv
        '
        Me.lblDiv.Location = New System.Drawing.Point(11, 50)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(56, 16)
        Me.lblDiv.TabIndex = 2
        Me.lblDiv.Text = "División :"
        Me.lblDiv.Values.ExtraText = ""
        Me.lblDiv.Values.Image = Nothing
        Me.lblDiv.Values.Text = "División :"
        '
        'lblComp
        '
        Me.lblComp.Location = New System.Drawing.Point(11, 24)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(68, 16)
        Me.lblComp.TabIndex = 1
        Me.lblComp.Text = "Compañia :"
        Me.lblComp.Values.ExtraText = ""
        Me.lblComp.Values.Image = Nothing
        Me.lblComp.Values.Text = "Compañia :"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(11, 76)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(74, 16)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "CheckPoint :"
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "CheckPoint :"
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.AutoSize = True
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 375)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.tvwSA)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(476, 321)
        Me.KryptonHeaderGroup3.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup3.TabIndex = 13
        Me.KryptonHeaderGroup3.Text = "CheckPoints de Seguimiento Aduanero"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "CheckPoints de Seguimiento Aduanero"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'tvwSA
        '
        Me.tvwSA.ContextMenuStrip = Me.cmsCheck
        Me.tvwSA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwSA.ImageIndex = 1
        Me.tvwSA.ImageList = Me.ImageList1
        Me.tvwSA.Location = New System.Drawing.Point(0, 0)
        Me.tvwSA.Name = "tvwSA"
        TreeNode3.ImageIndex = 6
        TreeNode3.Name = "Raiz"
        TreeNode3.SelectedImageIndex = 6
        TreeNode3.Text = "Aduanero"
        Me.tvwSA.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.tvwSA.SelectedImageIndex = 2
        Me.tvwSA.Size = New System.Drawing.Size(474, 299)
        Me.tvwSA.TabIndex = 3
        '
        'cmsCheck
        '
        Me.cmsCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmsCheck.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesasignarToolStripMenuItem})
        Me.cmsCheck.Name = "cmsArbol"
        Me.cmsCheck.Size = New System.Drawing.Size(131, 26)
        '
        'DesasignarToolStripMenuItem
        '
        Me.DesasignarToolStripMenuItem.Name = "DesasignarToolStripMenuItem"
        Me.DesasignarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DesasignarToolStripMenuItem.Text = "Desasignar"
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.AutoSize = True
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(0, 65)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.tvwCI)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(476, 310)
        Me.KryptonHeaderGroup4.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup4.TabIndex = 12
        Me.KryptonHeaderGroup4.Text = "CheckPoints de Carga Internacional"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "CheckPoints de Carga Internacional"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'tvwCI
        '
        Me.tvwCI.ContextMenuStrip = Me.cmsCheck
        Me.tvwCI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwCI.Dock = System.Windows.Forms.DockStyle.Top
        Me.tvwCI.ImageIndex = 1
        Me.tvwCI.ImageList = Me.ImageList1
        Me.tvwCI.Location = New System.Drawing.Point(0, 0)
        Me.tvwCI.Name = "tvwCI"
        TreeNode4.ImageIndex = 6
        TreeNode4.Name = "Raiz"
        TreeNode4.SelectedImageIndex = 6
        TreeNode4.Text = "Carga Internacional"
        Me.tvwCI.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.tvwCI.SelectedImageIndex = 2
        Me.tvwCI.Size = New System.Drawing.Size(474, 288)
        Me.tvwCI.TabIndex = 4
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(476, 65)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(13, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'cmbCliente
        '
        Me.cmbCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(71, 13)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(377, 22)
        Me.cmbCliente.TabIndex = 10
        '
        'oDsChk
        '
        Me.oDsChk.DataSetName = "NewDataSet"
        Me.oDsChk.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable1.TableName = "oDtCheck"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "N° Orden de Compra"
        Me.DataColumn1.ColumnName = "NORCML"
        Me.DataColumn1.ReadOnly = True
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Proveedor"
        Me.DataColumn2.ColumnName = "TPRVCL"
        Me.DataColumn2.ReadOnly = True
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Fecha de Creación"
        Me.DataColumn3.ColumnName = "FORCML"
        Me.DataColumn3.ReadOnly = True
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Medio de Transporte"
        Me.DataColumn4.ColumnName = "TNMMDT"
        Me.DataColumn4.ReadOnly = True
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Tipo de Despacho"
        Me.DataColumn5.ColumnName = "TTDESP"
        Me.DataColumn5.ReadOnly = True
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Lugar de Arrivo"
        Me.DataColumn6.ColumnName = "TDEFIN"
        Me.DataColumn6.ReadOnly = True
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Incoterm"
        Me.DataColumn7.ColumnName = "TTINTC"
        Me.DataColumn7.ReadOnly = True
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "Estado"
        Me.DataColumn8.ColumnName = "SESTRG"
        Me.DataColumn8.ReadOnly = True
        '
        'frmCheckPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 696)
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "frmCheckPoint"
        Me.Text = "Administración de CheckPoints"
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        Me.cmsArbol.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        Me.cmsCheck.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.oDsChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents tvwCheckPoint As System.Windows.Forms.TreeView
    Friend WithEvents oDsChk As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSeg As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDiv As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSeg As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtDiv As System.Windows.Forms.TextBox
    Friend WithEvents txtComp As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents cmsArbol As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesactivarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tvwSA As System.Windows.Forms.TreeView
    Friend WithEvents tvwCI As System.Windows.Forms.TreeView
    Friend WithEvents cmsCheck As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DesasignarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
