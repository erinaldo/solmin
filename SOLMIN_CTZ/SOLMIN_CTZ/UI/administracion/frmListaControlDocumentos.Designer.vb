<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaControlDocumentos
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaCobrador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaCobranza = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstados = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstadoCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstadoCobranza = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstadoCobrador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblImporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNumero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroCobranza = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNombreNro = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(370, 264)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNroCobranza)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNombreNro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblImporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNumero)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(370, 264)
        Me.KryptonHeaderGroup1.TabIndex = 9
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seguimiento"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "1D7B5CC0A1E24BCF1D7B5CC0A1E24BCF"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(36, 117)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblFechaCliente)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblFechaCobrador)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblFechaCobranza)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstados)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstadoCliente)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstadoCobranza)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstadoCobrador)
        Me.KryptonGroup1.Size = New System.Drawing.Size(270, 98)
        Me.KryptonGroup1.TabIndex = 13
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(188, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(43, 16)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 17
        Me.KryptonLabel2.Text = "Fecha"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha"
        '
        'lblFechaCliente
        '
        Me.lblFechaCliente.Location = New System.Drawing.Point(188, 76)
        Me.lblFechaCliente.Name = "lblFechaCliente"
        Me.lblFechaCliente.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaCliente.TabIndex = 16
        Me.lblFechaCliente.Text = "Fecha"
        Me.lblFechaCliente.Values.ExtraText = ""
        Me.lblFechaCliente.Values.Image = Nothing
        Me.lblFechaCliente.Values.Text = "Fecha"
        '
        'lblFechaCobrador
        '
        Me.lblFechaCobrador.Location = New System.Drawing.Point(188, 54)
        Me.lblFechaCobrador.Name = "lblFechaCobrador"
        Me.lblFechaCobrador.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaCobrador.TabIndex = 15
        Me.lblFechaCobrador.Text = "Fecha"
        Me.lblFechaCobrador.Values.ExtraText = ""
        Me.lblFechaCobrador.Values.Image = Nothing
        Me.lblFechaCobrador.Values.Text = "Fecha"
        '
        'lblFechaCobranza
        '
        Me.lblFechaCobranza.Location = New System.Drawing.Point(188, 33)
        Me.lblFechaCobranza.Name = "lblFechaCobranza"
        Me.lblFechaCobranza.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaCobranza.TabIndex = 14
        Me.lblFechaCobranza.Text = "Fecha"
        Me.lblFechaCobranza.Values.ExtraText = ""
        Me.lblFechaCobranza.Values.Image = Nothing
        Me.lblFechaCobranza.Values.Text = "Fecha"
        '
        'lblEstados
        '
        Me.lblEstados.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1
        Me.lblEstados.Location = New System.Drawing.Point(3, 12)
        Me.lblEstados.Name = "lblEstados"
        Me.lblEstados.Size = New System.Drawing.Size(53, 16)
        Me.lblEstados.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstados.TabIndex = 7
        Me.lblEstados.Text = "Estados"
        Me.lblEstados.Values.ExtraText = ""
        Me.lblEstados.Values.Image = Nothing
        Me.lblEstados.Values.Text = "Estados"
        '
        'lblEstadoCliente
        '
        Me.lblEstadoCliente.Location = New System.Drawing.Point(3, 76)
        Me.lblEstadoCliente.Name = "lblEstadoCliente"
        Me.lblEstadoCliente.Size = New System.Drawing.Size(90, 19)
        Me.lblEstadoCliente.TabIndex = 12
        Me.lblEstadoCliente.Text = "lblEstadoCliente"
        Me.lblEstadoCliente.Values.ExtraText = ""
        Me.lblEstadoCliente.Values.Image = Nothing
        Me.lblEstadoCliente.Values.Text = "lblEstadoCliente"
        '
        'lblEstadoCobranza
        '
        Me.lblEstadoCobranza.Location = New System.Drawing.Point(3, 33)
        Me.lblEstadoCobranza.Name = "lblEstadoCobranza"
        Me.lblEstadoCobranza.Size = New System.Drawing.Size(103, 19)
        Me.lblEstadoCobranza.TabIndex = 8
        Me.lblEstadoCobranza.Text = "lblEstadoCobranza"
        Me.lblEstadoCobranza.Values.ExtraText = ""
        Me.lblEstadoCobranza.Values.Image = Nothing
        Me.lblEstadoCobranza.Values.Text = "lblEstadoCobranza"
        '
        'lblEstadoCobrador
        '
        Me.lblEstadoCobrador.Location = New System.Drawing.Point(3, 54)
        Me.lblEstadoCobrador.Name = "lblEstadoCobrador"
        Me.lblEstadoCobrador.Size = New System.Drawing.Size(103, 19)
        Me.lblEstadoCobrador.TabIndex = 10
        Me.lblEstadoCobrador.Text = "lblEstadoCobrador"
        Me.lblEstadoCobrador.Values.ExtraText = ""
        Me.lblEstadoCobrador.Values.Image = Nothing
        Me.lblEstadoCobrador.Values.Text = "lblEstadoCobrador"
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(124, 70)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(62, 19)
        Me.lblImporte.TabIndex = 6
        Me.lblImporte.Text = "lblImporte"
        Me.lblImporte.Values.ExtraText = ""
        Me.lblImporte.Values.Image = Nothing
        Me.lblImporte.Values.Text = "lblImporte"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(36, 70)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel4.TabIndex = 5
        Me.KryptonLabel4.Text = "Importe : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Importe : "
        '
        'lblNumero
        '
        Me.lblNumero.Location = New System.Drawing.Point(124, 49)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(63, 19)
        Me.lblNumero.TabIndex = 4
        Me.lblNumero.Text = "lblNumero"
        Me.lblNumero.Values.ExtraText = ""
        Me.lblNumero.Values.Image = Nothing
        Me.lblNumero.Values.Text = "lblNumero"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(36, 49)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel5.TabIndex = 1
        Me.KryptonLabel5.Text = "Número : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Número : "
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(124, 28)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(44, 19)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "lblTipo"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "lblTipo"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(36, 28)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Tipo : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(124, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(57, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "lblCliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "lblCliente"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(36, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'lblNroCobranza
        '
        Me.lblNroCobranza.Location = New System.Drawing.Point(124, 92)
        Me.lblNroCobranza.Name = "lblNroCobranza"
        Me.lblNroCobranza.Size = New System.Drawing.Size(77, 19)
        Me.lblNroCobranza.TabIndex = 15
        Me.lblNroCobranza.Text = "NroCobranza"
        Me.lblNroCobranza.Values.ExtraText = ""
        Me.lblNroCobranza.Values.Image = Nothing
        Me.lblNroCobranza.Values.Text = "NroCobranza"
        '
        'lblNombreNro
        '
        Me.lblNombreNro.Location = New System.Drawing.Point(36, 92)
        Me.lblNombreNro.Name = "lblNombreNro"
        Me.lblNombreNro.Size = New System.Drawing.Size(85, 19)
        Me.lblNombreNro.TabIndex = 14
        Me.lblNombreNro.Text = "Nro Cobranza : "
        Me.lblNombreNro.Values.ExtraText = ""
        Me.lblNombreNro.Values.Image = Nothing
        Me.lblNombreNro.Values.Text = "Nro Cobranza : "
        '
        'frmListaControlDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 264)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaControlDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Control de Documentos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblEstadoCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstadoCobrador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstadoCobranza As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstados As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblImporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNumero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaCobrador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaCobranza As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroCobranza As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNombreNro As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
