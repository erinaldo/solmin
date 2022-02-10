<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.mnuMenu = New System.Windows.Forms.MenuStrip
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RequerimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeCompraDetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CargaInternacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreEmbarqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeguimientoAduaneroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CostoItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SolicitudDeFletesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculoCosto = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_Salir = New System.Windows.Forms.ToolStripMenuItem
        Me.TablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuCheckPoint = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuMercaderia = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuMultiTabla = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuProveedor = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesMensualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.splDivisor = New System.Windows.Forms.Splitter
        Me.btn_Requerimiento = New System.Windows.Forms.ToolStripButton
        Me.btn_OC = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_Preembarque = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_SeguimientoAdu = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_Salir = New System.Windows.Forms.ToolStripButton
        Me.tlbMenu = New System.Windows.Forms.ToolStrip
        Me.btn_Reporte = New System.Windows.Forms.ToolStripButton
        Me.CostoItemOC = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMenu.SuspendLayout()
        Me.tlbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.TablasToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(952, 24)
        Me.mnuMenu.TabIndex = 2
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequerimientoToolStripMenuItem, Me.OrdenDeCompraToolStripMenuItem, Me.OrdenDeCompraDetToolStripMenuItem, Me.CargaInternacionalToolStripMenuItem, Me.PreEmbarqueToolStripMenuItem, Me.SeguimientoAduaneroToolStripMenuItem, Me.ToolStripSeparator4, Me.ServiciosToolStripMenuItem, Me.CostoItem, Me.CostoItemOC, Me.SolicitudDeFletesToolStripMenuItem, Me.CalculoCosto, Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem, Me.ToolStripSeparator1, Me.mnu_Salir})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.OperacionesToolStripMenuItem.Text = "&Operaciones"
        '
        'RequerimientoToolStripMenuItem
        '
        Me.RequerimientoToolStripMenuItem.Name = "RequerimientoToolStripMenuItem"
        Me.RequerimientoToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.RequerimientoToolStripMenuItem.Text = "&Requerimiento"
        '
        'OrdenDeCompraToolStripMenuItem
        '
        Me.OrdenDeCompraToolStripMenuItem.Name = "OrdenDeCompraToolStripMenuItem"
        Me.OrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.OrdenDeCompraToolStripMenuItem.Text = "Or&den de Compra"
        Me.OrdenDeCompraToolStripMenuItem.Visible = False
        '
        'OrdenDeCompraDetToolStripMenuItem
        '
        Me.OrdenDeCompraDetToolStripMenuItem.Name = "OrdenDeCompraDetToolStripMenuItem"
        Me.OrdenDeCompraDetToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.OrdenDeCompraDetToolStripMenuItem.Text = "Or&den de Compra"
        '
        'CargaInternacionalToolStripMenuItem
        '
        Me.CargaInternacionalToolStripMenuItem.Name = "CargaInternacionalToolStripMenuItem"
        Me.CargaInternacionalToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.CargaInternacionalToolStripMenuItem.Text = "P&re - Embarque"
        '
        'PreEmbarqueToolStripMenuItem
        '
        Me.PreEmbarqueToolStripMenuItem.Name = "PreEmbarqueToolStripMenuItem"
        Me.PreEmbarqueToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.PreEmbarqueToolStripMenuItem.Text = "P&re - Embarque"
        Me.PreEmbarqueToolStripMenuItem.Visible = False
        '
        'SeguimientoAduaneroToolStripMenuItem
        '
        Me.SeguimientoAduaneroToolStripMenuItem.Name = "SeguimientoAduaneroToolStripMenuItem"
        Me.SeguimientoAduaneroToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.SeguimientoAduaneroToolStripMenuItem.Text = "Embarque y &Seguimiento Aduanero"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(264, 6)
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'CostoItem
        '
        Me.CostoItem.Name = "CostoItem"
        Me.CostoItem.Size = New System.Drawing.Size(267, 22)
        Me.CostoItem.Text = "Costo por Item - Embarque"
        '
        'SolicitudDeFletesToolStripMenuItem
        '
        Me.SolicitudDeFletesToolStripMenuItem.Name = "SolicitudDeFletesToolStripMenuItem"
        Me.SolicitudDeFletesToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.SolicitudDeFletesToolStripMenuItem.Text = "Solicitud de Fletes"
        Me.SolicitudDeFletesToolStripMenuItem.Visible = False
        '
        'CalculoCosto
        '
        Me.CalculoCosto.Name = "CalculoCosto"
        Me.CalculoCosto.Size = New System.Drawing.Size(267, 22)
        Me.CalculoCosto.Text = "Calculo de Costo de Operación"
        Me.CalculoCosto.Visible = False
        '
        'CalculoDeCostoDeOperaciónMensualToolStripMenuItem
        '
        Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem.Name = "CalculoDeCostoDeOperaciónMensualToolStripMenuItem"
        Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem.Text = "Calculo de Costo de Operación Mensual"
        Me.CalculoDeCostoDeOperaciónMensualToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(264, 6)
        '
        'mnu_Salir
        '
        Me.mnu_Salir.Name = "mnu_Salir"
        Me.mnu_Salir.Size = New System.Drawing.Size(267, 22)
        Me.mnu_Salir.Text = "Salir"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCheckPoint, Me.MnuMercaderia, Me.MnuMultiTabla, Me.MnuProveedor})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TablasToolStripMenuItem.Text = "&Tablas"
        '
        'MnuCheckPoint
        '
        Me.MnuCheckPoint.Name = "MnuCheckPoint"
        Me.MnuCheckPoint.Size = New System.Drawing.Size(137, 22)
        Me.MnuCheckPoint.Text = "CheckPoint"
        '
        'MnuMercaderia
        '
        Me.MnuMercaderia.Name = "MnuMercaderia"
        Me.MnuMercaderia.Size = New System.Drawing.Size(137, 22)
        Me.MnuMercaderia.Text = "Mercadería"
        '
        'MnuMultiTabla
        '
        Me.MnuMultiTabla.Name = "MnuMultiTabla"
        Me.MnuMultiTabla.Size = New System.Drawing.Size(137, 22)
        Me.MnuMultiTabla.Text = "Generales"
        '
        'MnuProveedor
        '
        Me.MnuProveedor.Name = "MnuProveedor"
        Me.MnuProveedor.Size = New System.Drawing.Size(137, 22)
        Me.MnuProveedor.Text = "Proveedores"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesMensualesToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ReportesMensualesToolStripMenuItem
        '
        Me.ReportesMensualesToolStripMenuItem.Name = "ReportesMensualesToolStripMenuItem"
        Me.ReportesMensualesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ReportesMensualesToolStripMenuItem.Text = "Reportes Mensuales"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'splDivisor
        '
        Me.splDivisor.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.splDivisor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.splDivisor.Location = New System.Drawing.Point(131, 24)
        Me.splDivisor.Name = "splDivisor"
        Me.splDivisor.Size = New System.Drawing.Size(12, 672)
        Me.splDivisor.TabIndex = 10
        Me.splDivisor.TabStop = False
        '
        'btn_Requerimiento
        '
        Me.btn_Requerimiento.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Requerimiento.Image = CType(resources.GetObject("btn_Requerimiento.Image"), System.Drawing.Image)
        Me.btn_Requerimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Requerimiento.Name = "btn_Requerimiento"
        Me.btn_Requerimiento.Size = New System.Drawing.Size(128, 64)
        Me.btn_Requerimiento.Text = "Requerimiento"
        Me.btn_Requerimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Requerimiento.ToolTipText = "Requerimientos"
        '
        'btn_OC
        '
        Me.btn_OC.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OC.Image = CType(resources.GetObject("btn_OC.Image"), System.Drawing.Image)
        Me.btn_OC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_OC.Name = "btn_OC"
        Me.btn_OC.Size = New System.Drawing.Size(128, 64)
        Me.btn_OC.Text = "Orden de Compra"
        Me.btn_OC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_OC.ToolTipText = "Ordenes de Compra"
        '
        'tssSeparador1
        '
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(128, 6)
        '
        'btn_Preembarque
        '
        Me.btn_Preembarque.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Preembarque.Image = CType(resources.GetObject("btn_Preembarque.Image"), System.Drawing.Image)
        Me.btn_Preembarque.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Preembarque.Name = "btn_Preembarque"
        Me.btn_Preembarque.Size = New System.Drawing.Size(128, 64)
        Me.btn_Preembarque.Text = "Pre-Embarque"
        Me.btn_Preembarque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Preembarque.ToolTipText = "Seguimiento Internacional - Pre-Embarque"
        '
        'tssSeparador2
        '
        Me.tssSeparador2.Name = "tssSeparador2"
        Me.tssSeparador2.Size = New System.Drawing.Size(128, 6)
        '
        'btn_SeguimientoAdu
        '
        Me.btn_SeguimientoAdu.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SeguimientoAdu.Image = CType(resources.GetObject("btn_SeguimientoAdu.Image"), System.Drawing.Image)
        Me.btn_SeguimientoAdu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SeguimientoAdu.Name = "btn_SeguimientoAdu"
        Me.btn_SeguimientoAdu.Size = New System.Drawing.Size(128, 64)
        Me.btn_SeguimientoAdu.Text = "Embarque y Aduanas"
        Me.btn_SeguimientoAdu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_SeguimientoAdu.ToolTipText = "Embarque & Seguimiento Aduanero"
        '
        'tssSeparador3
        '
        Me.tssSeparador3.Name = "tssSeparador3"
        Me.tssSeparador3.Size = New System.Drawing.Size(128, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(128, 6)
        '
        'btn_Salir
        '
        Me.btn_Salir.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(128, 64)
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Salir.ToolTipText = "Salir del Sistema"
        '
        'tlbMenu
        '
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlbMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tlbMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Requerimiento, Me.btn_OC, Me.tssSeparador1, Me.btn_Preembarque, Me.tssSeparador2, Me.btn_SeguimientoAdu, Me.tssSeparador3, Me.btn_Reporte, Me.ToolStripSeparator3, Me.btn_Salir})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 24)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(131, 672)
        Me.tlbMenu.TabIndex = 7
        '
        'btn_Reporte
        '
        Me.btn_Reporte.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Reporte.Image = CType(resources.GetObject("btn_Reporte.Image"), System.Drawing.Image)
        Me.btn_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Reporte.Name = "btn_Reporte"
        Me.btn_Reporte.Size = New System.Drawing.Size(128, 64)
        Me.btn_Reporte.Text = "Consultas"
        Me.btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CostoItemOC
        '
        Me.CostoItemOC.Name = "CostoItemOC"
        Me.CostoItemOC.Size = New System.Drawing.Size(267, 22)
        Me.CostoItemOC.Text = "Costo por Item - Orden Compra"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 696)
        Me.Controls.Add(Me.splDivisor)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.mnuMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmPrincipal"
        Me.Text = "SOLMIN - Seguimiento Logístico Minero"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequerimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreEmbarqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguimientoAduaneroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCheckPoint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents splDivisor As System.Windows.Forms.Splitter
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Requerimiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_OC As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_Preembarque As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_SeguimientoAdu As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents MnuMultiTabla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesMensualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents CalculoCosto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalculoDeCostoDeOperaciónMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeCompraDetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMercaderia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargaInternacionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudDeFletesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostoItemOC As System.Windows.Forms.ToolStripMenuItem
End Class
