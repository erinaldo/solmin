<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesAgenciaRansa
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
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.btnProcesarBusqueda = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.txtOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.dtgDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup2.Panel.SuspendLayout()
    Me.KryptonHeaderGroup2.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonManager
    '
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
    '
    'btnProcesarBusqueda
    '
    Me.btnProcesarBusqueda.ExtraText = ""
    Me.btnProcesarBusqueda.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnProcesarBusqueda.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnProcesarBusqueda.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnProcesarBusqueda.Text = "Buscar"
    Me.btnProcesarBusqueda.ToolTipImage = Nothing
    Me.btnProcesarBusqueda.UniqueName = "AB5209FD1C4F43DFAB5209FD1C4F43DF"
    '
    'btnCancelar
    '
    Me.btnCancelar.ExtraText = ""
    Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnCancelar.Text = "Salir"
    Me.btnCancelar.ToolTipImage = Nothing
    Me.btnCancelar.UniqueName = "30AE8BF728354BE830AE8BF728354BE8"
    Me.btnCancelar.Visible = False
    '
    'KryptonHeaderGroup2
    '
    Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesarBusqueda, Me.btnCancelar})
    Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
    '
    'KryptonHeaderGroup2.Panel
    '
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtClienteFiltro)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel18)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtpFechaFin)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtpFechaInicio)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtOrdenServicio)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1135, 100)
    Me.KryptonHeaderGroup2.TabIndex = 0
    Me.KryptonHeaderGroup2.Text = "Filtros de Búsqueda"
    Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Filtros de Búsqueda"
    Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.SOLMIN_ST.My.Resources.Resources.chardevice___
    Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "  "
    Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
    '
    'txtClienteFiltro
    '
    Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
    Me.txtClienteFiltro.CCMPN = "EZ"
    Me.txtClienteFiltro.Location = New System.Drawing.Point(120, 10)
    Me.txtClienteFiltro.Name = "txtClienteFiltro"
    Me.txtClienteFiltro.pAccesoPorUsuario = False
    Me.txtClienteFiltro.pRequerido = False
    Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.txtClienteFiltro.Size = New System.Drawing.Size(275, 21)
    Me.txtClienteFiltro.TabIndex = 13
    '
    'KryptonLabel18
    '
    Me.KryptonLabel18.Location = New System.Drawing.Point(12, 10)
    Me.KryptonLabel18.Name = "KryptonLabel18"
    Me.KryptonLabel18.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel18.TabIndex = 12
    Me.KryptonLabel18.Text = "Cliente "
    Me.KryptonLabel18.Values.ExtraText = ""
    Me.KryptonLabel18.Values.Image = Nothing
    Me.KryptonLabel18.Values.Text = "Cliente "
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(590, 9)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(88, 21)
    Me.dtpFechaFin.TabIndex = 6
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(478, 9)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(88, 21)
    Me.dtpFechaInicio.TabIndex = 4
    '
    'txtOrdenServicio
    '
    Me.txtOrdenServicio.Location = New System.Drawing.Point(120, 39)
    Me.txtOrdenServicio.Name = "txtOrdenServicio"
    Me.txtOrdenServicio.Size = New System.Drawing.Size(100, 21)
    Me.txtOrdenServicio.TabIndex = 3
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(12, 40)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(99, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Orden de Servicio"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Orden de Servicio"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(568, 10)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(20, 19)
    Me.KryptonLabel3.TabIndex = 2
    Me.KryptonLabel3.Text = "Al"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Al"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(430, 10)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel2.TabIndex = 1
    Me.KryptonLabel2.Text = "Fecha"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Fecha"
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 100)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgDatos)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1135, 581)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Listado de Operaciones de Agencias Ransa"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Listado de Operaciones de Agencias Ransa"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'dtgDatos
    '
    Me.dtgDatos.ColumnHeadersHeight = 20
    Me.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dtgDatos.Location = New System.Drawing.Point(0, 0)
    Me.dtgDatos.MultiSelect = False
    Me.dtgDatos.Name = "dtgDatos"
    Me.dtgDatos.RowTemplate.Height = 20
    Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dtgDatos.Size = New System.Drawing.Size(1133, 559)
    Me.dtgDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgDatos.TabIndex = 0
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1135, 681)
    Me.KryptonPanel.TabIndex = 1
    '
    'frmOperacionesAgenciaRansa
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1135, 681)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmOperacionesAgenciaRansa"
    Me.Text = "Operaciones desde Agencias Ransa"
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup2.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
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
  Friend WithEvents btnProcesarBusqueda As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtgDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
