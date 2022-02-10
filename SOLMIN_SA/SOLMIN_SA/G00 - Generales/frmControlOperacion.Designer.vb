<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlOperacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlOperacion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dteFechaCierre = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoOperacion = New RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblTipoMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgControlOperacion = New Ransa.Controls.WayBill.ucControlOperacion_DgF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnProcesar)
        Me.KryptonPanel.Controls.Add(Me.dteFechaCierre)
        Me.KryptonPanel.Controls.Add(Me.lblFecha)
        Me.KryptonPanel.Controls.Add(Me.cmbTipoOperacion)
        Me.KryptonPanel.Controls.Add(Me.lblTipoMovimiento)
        Me.KryptonPanel.Controls.Add(Me.dgControlOperacion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(735, 290)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(459, 12)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(93, 47)
        Me.btnProcesar.TabIndex = 21
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = ""
        Me.btnProcesar.Values.Image = CType(resources.GetObject("btnProcesar.Values.Image"), System.Drawing.Image)
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'dteFechaCierre
        '
        Me.dteFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaCierre.Location = New System.Drawing.Point(117, 39)
        Me.dteFechaCierre.Name = "dteFechaCierre"
        Me.dteFechaCierre.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaCierre.TabIndex = 4
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(12, 43)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(97, 16)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha de Cierre : "
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "Fecha de Cierre : "
        '
        'cmbTipoOperacion
        '
        Me.cmbTipoOperacion.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipoOperacion.Location = New System.Drawing.Point(117, 12)
        Me.cmbTipoOperacion.Name = "cmbTipoOperacion"
        Me.cmbTipoOperacion.pCategoria = "TIPOPE"
        Me.cmbTipoOperacion.pIsRequired = True
        Me.cmbTipoOperacion.Size = New System.Drawing.Size(336, 21)
        Me.cmbTipoOperacion.TabIndex = 2
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(12, 17)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(99, 16)
        Me.lblTipoMovimiento.TabIndex = 1
        Me.lblTipoMovimiento.Text = "Tipo Movimiento : "
        Me.lblTipoMovimiento.Values.ExtraText = ""
        Me.lblTipoMovimiento.Values.Image = Nothing
        Me.lblTipoMovimiento.Values.Text = "Tipo Movimiento : "
        '
        'dgControlOperacion
        '
        Me.dgControlOperacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgControlOperacion.Location = New System.Drawing.Point(0, 68)
        Me.dgControlOperacion.Name = "dgControlOperacion"
        Me.dgControlOperacion.Size = New System.Drawing.Size(735, 222)
        Me.dgControlOperacion.TabIndex = 0
        '
        'frmControlOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 290)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmControlOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Almacén"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents dgControlOperacion As Ransa.Controls.WayBill.ucControlOperacion_DgF01
    Friend WithEvents lblTipoMovimiento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoOperacion As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents dteFechaCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
