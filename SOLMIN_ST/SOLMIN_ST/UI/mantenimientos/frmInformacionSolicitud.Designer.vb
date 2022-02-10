<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionSolicitud
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
    Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnModificar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnAsignarUnidad = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnConfirmarAtencion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnAgregarGuiaTransporte = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderSolicitud.Panel.SuspendLayout()
    Me.HeaderSolicitud.SuspendLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderSolicitud)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1059, 302)
    Me.KryptonPanel.TabIndex = 0
    '
    'HeaderSolicitud
    '
    Me.HeaderSolicitud.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnModificar, Me.btnAsignarUnidad, Me.btnConfirmarAtencion, Me.btnAgregarGuiaTransporte, Me.btnSalir})
    Me.HeaderSolicitud.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToBoth
    Me.HeaderSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderSolicitud.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderSolicitud.HeaderVisibleSecondary = False
    Me.HeaderSolicitud.Location = New System.Drawing.Point(0, 0)
    Me.HeaderSolicitud.Name = "HeaderSolicitud"
    '
    'HeaderSolicitud.Panel
    '
    Me.HeaderSolicitud.Panel.Controls.Add(Me.KryptonGroup1)
    Me.HeaderSolicitud.Size = New System.Drawing.Size(1059, 302)
    Me.HeaderSolicitud.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form
    Me.HeaderSolicitud.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounded
    Me.HeaderSolicitud.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
    Me.HeaderSolicitud.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.HeaderSolicitud.TabIndex = 106
    Me.HeaderSolicitud.ValuesPrimary.Description = ""
    Me.HeaderSolicitud.ValuesPrimary.Heading = ""
    Me.HeaderSolicitud.ValuesPrimary.Image = Nothing
    Me.HeaderSolicitud.ValuesSecondary.Description = ""
    Me.HeaderSolicitud.ValuesSecondary.Heading = ""
    Me.HeaderSolicitud.ValuesSecondary.Image = Nothing
    '
    'btnModificar
    '
    Me.btnModificar.ExtraText = ""
    Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
    Me.btnModificar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnModificar.Text = "&Guardar"
    Me.btnModificar.ToolTipImage = Nothing
    Me.btnModificar.UniqueName = "D56ED8F5BBB649E1D56ED8F5BBB649E1"
    '
    'btnAsignarUnidad
    '
    Me.btnAsignarUnidad.ExtraText = ""
    Me.btnAsignarUnidad.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnAsignarUnidad.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnAsignarUnidad.Text = "&Asignar Unidad"
    Me.btnAsignarUnidad.ToolTipImage = Nothing
    Me.btnAsignarUnidad.UniqueName = "C716916A53EF44C1C716916A53EF44C1"
    Me.btnAsignarUnidad.Visible = False
    '
    'btnConfirmarAtencion
    '
    Me.btnConfirmarAtencion.ExtraText = ""
    Me.btnConfirmarAtencion.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
    Me.btnConfirmarAtencion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnConfirmarAtencion.Text = "&Confirmar Atención"
    Me.btnConfirmarAtencion.ToolTipImage = Nothing
    Me.btnConfirmarAtencion.UniqueName = "4E770F5E42AF40B84E770F5E42AF40B8"
    Me.btnConfirmarAtencion.Visible = False
    '
    'btnAgregarGuiaTransporte
    '
    Me.btnAgregarGuiaTransporte.ExtraText = ""
    Me.btnAgregarGuiaTransporte.Image = Global.SOLMIN_ST.My.Resources.Resources.Agregar2
    Me.btnAgregarGuiaTransporte.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnAgregarGuiaTransporte.Text = "Agregar Guía Transporte"
    Me.btnAgregarGuiaTransporte.ToolTipImage = Nothing
    Me.btnAgregarGuiaTransporte.UniqueName = "94BE3FA4BF0E4E0894BE3FA4BF0E4E08"
    Me.btnAgregarGuiaTransporte.Visible = False
    '
    'btnSalir
    '
    Me.btnSalir.ExtraText = ""
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnSalir.Text = "&Salir"
    Me.btnSalir.ToolTipBody = "Salir"
    Me.btnSalir.ToolTipImage = Nothing
    Me.btnSalir.UniqueName = "27D941CF936C4FCB27D941CF936C4FCB"
    '
    'KryptonGroup1
    '
    Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonGroup1.Name = "KryptonGroup1"
    Me.KryptonGroup1.Size = New System.Drawing.Size(1057, 267)
    Me.KryptonGroup1.TabIndex = 9
    '
    'frmInformacionSolicitud
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1059, 302)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmInformacionSolicitud"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Información de Solicitud"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderSolicitud.Panel.ResumeLayout(False)
    CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderSolicitud.ResumeLayout(False)
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.ResumeLayout(False)
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
  Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnModificar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnAsignarUnidad As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnConfirmarAtencion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnAgregarGuiaTransporte As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
