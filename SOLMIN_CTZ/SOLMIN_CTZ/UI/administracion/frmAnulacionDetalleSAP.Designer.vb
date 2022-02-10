<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnulacionDetalleSAP
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tlsControl1 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.separador0 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.txtDocumento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDocumento = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAprobador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboAprobador = New Ransa.Utilitario.ucAyuda
        Me.tlsControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Location = New System.Drawing.Point(11, 41)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(65, 20)
        Me.lblTipoDoc.TabIndex = 3
        Me.lblTipoDoc.Text = "Tipo Doc.:"
        Me.lblTipoDoc.Values.ExtraText = ""
        Me.lblTipoDoc.Values.Image = Nothing
        Me.lblTipoDoc.Values.Text = "Tipo Doc.:"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Enabled = False
        Me.txtTipoDoc.Location = New System.Drawing.Point(83, 41)
        Me.txtTipoDoc.MaxLength = 11
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(53, 22)
        Me.txtTipoDoc.TabIndex = 2
        '
        'tlsControl1
        '
        Me.tlsControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tlsControl1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.separador0, Me.btnAceptar})
        Me.tlsControl1.Location = New System.Drawing.Point(0, 0)
        Me.tlsControl1.Name = "tlsControl1"
        Me.tlsControl1.Size = New System.Drawing.Size(471, 25)
        Me.tlsControl1.TabIndex = 6
        Me.tlsControl1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'separador0
        '
        Me.separador0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.separador0.Name = "separador0"
        Me.separador0.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_CT.My.Resources.Resources.ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(236, 41)
        Me.txtDocumento.MaxLength = 11
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(222, 22)
        Me.txtDocumento.TabIndex = 2
        '
        'lblDocumento
        '
        Me.lblDocumento.Location = New System.Drawing.Point(153, 41)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(77, 20)
        Me.lblDocumento.TabIndex = 3
        Me.lblDocumento.Text = "Documento:"
        Me.lblDocumento.Values.ExtraText = ""
        Me.lblDocumento.Values.Image = Nothing
        Me.lblDocumento.Values.Text = "Documento:"
        '
        'lblAprobador
        '
        Me.lblAprobador.Location = New System.Drawing.Point(11, 69)
        Me.lblAprobador.Name = "lblAprobador"
        Me.lblAprobador.Size = New System.Drawing.Size(72, 20)
        Me.lblAprobador.TabIndex = 3
        Me.lblAprobador.Text = "Aprobador:"
        Me.lblAprobador.Values.ExtraText = ""
        Me.lblAprobador.Values.Image = Nothing
        Me.lblAprobador.Values.Text = "Aprobador:"
        '
        'cboAprobador
        '
        Me.cboAprobador.BackColor = System.Drawing.Color.Transparent
        Me.cboAprobador.DataSource = Nothing
        Me.cboAprobador.DispleyMember = ""
        Me.cboAprobador.Etiquetas_Form = Nothing
        Me.cboAprobador.ListColumnas = Nothing
        Me.cboAprobador.Location = New System.Drawing.Point(83, 69)
        Me.cboAprobador.Name = "cboAprobador"
        Me.cboAprobador.Obligatorio = True
        Me.cboAprobador.PopupHeight = 0
        Me.cboAprobador.PopupWidth = 0
        Me.cboAprobador.Size = New System.Drawing.Size(375, 22)
        Me.cboAprobador.SizeFont = 0
        Me.cboAprobador.TabIndex = 7
        Me.cboAprobador.ValueMember = ""
        '
        'frmAnulacionDetalleSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(471, 113)
        Me.Controls.Add(Me.cboAprobador)
        Me.Controls.Add(Me.tlsControl1)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblAprobador)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnulacionDetalleSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anulación Detalle SAP PT"
        Me.tlsControl1.ResumeLayout(False)
        Me.tlsControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tlsControl1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDocumento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDocumento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAprobador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboAprobador As Ransa.Utilitario.ucAyuda
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador0 As System.Windows.Forms.ToolStripSeparator
End Class
