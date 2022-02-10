<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptEntregCobranza
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtNrpEntreCob = New Ransa.Utilitario.clsTextBoxNumero
        Me.cmbEstadoFac = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbSap = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoCambio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbRegionVenta = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.cmbPlanta = New SOLMIN_CT.CheckComboBoxTest.CheckedComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(294, 91)
        Me.KryptonPanel.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 62)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(294, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Reporte"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AutoSize = True
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(294, 62)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.txtNrpEntreCob)
        Me.KryptonPanel2.Controls.Add(Me.cmbRegionVenta)
        Me.KryptonPanel2.Controls.Add(Me.cmbPlanta)
        Me.KryptonPanel2.Controls.Add(Me.cmbEstadoFac)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.cbSap)
        Me.KryptonPanel2.Controls.Add(Me.lblCompania)
        Me.KryptonPanel2.Controls.Add(Me.lblPlanta)
        Me.KryptonPanel2.Controls.Add(Me.lblTipoCambio)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(292, 40)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 0
        '
        'txtNrpEntreCob
        '
        Me.txtNrpEntreCob.Location = New System.Drawing.Point(139, 8)
        Me.txtNrpEntreCob.Name = "txtNrpEntreCob"
        Me.txtNrpEntreCob.NUMDECIMALES = 0
        Me.txtNrpEntreCob.NUMENTEROS = 10
        Me.txtNrpEntreCob.Size = New System.Drawing.Size(100, 20)
        Me.txtNrpEntreCob.TabIndex = 102
        '
        'cmbEstadoFac
        '
        Me.cmbEstadoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoFac.FormattingEnabled = True
        Me.cmbEstadoFac.Location = New System.Drawing.Point(775, 91)
        Me.cmbEstadoFac.Name = "cmbEstadoFac"
        Me.cmbEstadoFac.Size = New System.Drawing.Size(237, 21)
        Me.cmbEstadoFac.TabIndex = 45
        Me.cmbEstadoFac.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(678, 36)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel3.TabIndex = 42
        Me.KryptonLabel3.Text = "Región Venta :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Región Venta :"
        '
        'cbSap
        '
        Me.cbSap.Checked = False
        Me.cbSap.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.cbSap.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbSap.Location = New System.Drawing.Point(678, 65)
        Me.cbSap.Name = "cbSap"
        Me.cbSap.Size = New System.Drawing.Size(103, 19)
        Me.cbSap.TabIndex = 5
        Me.cbSap.Text = "Sin envio al SAP"
        Me.cbSap.Values.ExtraText = ""
        Me.cbSap.Values.Image = Nothing
        Me.cbSap.Values.Text = "Sin envio al SAP"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(10, 8)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(123, 19)
        Me.lblCompania.TabIndex = 0
        Me.lblCompania.Text = "Nro Entrega Cobranza:"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Nro Entrega Cobranza:"
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(678, 8)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(47, 19)
        Me.lblPlanta.TabIndex = 6
        Me.lblPlanta.Text = "Planta :"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta :"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.Location = New System.Drawing.Point(678, 92)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(90, 19)
        Me.lblTipoCambio.TabIndex = 44
        Me.lblTipoCambio.Text = "Tipo de Cambio"
        Me.lblTipoCambio.Values.ExtraText = ""
        Me.lblTipoCambio.Values.Image = Nothing
        Me.lblTipoCambio.Values.Text = "Tipo de Cambio"
        '
        'cmbRegionVenta
        '
        Me.cmbRegionVenta.CheckOnClick = True
        Me.cmbRegionVenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbRegionVenta.DropDownHeight = 1
        Me.cmbRegionVenta.FormattingEnabled = True
        Me.cmbRegionVenta.IntegralHeight = False
        Me.cmbRegionVenta.Location = New System.Drawing.Point(775, 33)
        Me.cmbRegionVenta.Name = "cmbRegionVenta"
        Me.cmbRegionVenta.Size = New System.Drawing.Size(237, 21)
        Me.cmbRegionVenta.TabIndex = 100
        Me.cmbRegionVenta.ValueSeparator = ", "
        '
        'cmbPlanta
        '
        Me.cmbPlanta.CheckOnClick = True
        Me.cmbPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPlanta.DropDownHeight = 1
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.IntegralHeight = False
        Me.cmbPlanta.Location = New System.Drawing.Point(775, 6)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(237, 21)
        Me.cmbPlanta.TabIndex = 98
        Me.cmbPlanta.ValueSeparator = ", "
        '
        'frmRptEntregCobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 91)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.Name = "frmRptEntregCobranza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doc. Enviados a Cobranza"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtNrpEntreCob As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents cmbRegionVenta As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents cmbPlanta As SOLMIN_CT.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents cmbEstadoFac As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbSap As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoCambio As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
