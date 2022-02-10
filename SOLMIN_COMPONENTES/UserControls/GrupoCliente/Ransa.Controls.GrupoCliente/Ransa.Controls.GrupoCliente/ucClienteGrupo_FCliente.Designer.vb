<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClienteGrupo_FCliente
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
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRUC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dgCliente = New Ransa.Controls.GrupoCliente.ucClienteGrupo_DgF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.chkEnLaCadena)
        Me.KryptonPanel.Controls.Add(Me.btnSalir)
        Me.KryptonPanel.Controls.Add(Me.txtCodigo)
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.lblCodigo)
        Me.KryptonPanel.Controls.Add(Me.txtRUC)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcion)
        Me.KryptonPanel.Controls.Add(Me.lblRUC)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcion)
        Me.KryptonPanel.Controls.Add(Me.dgCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(783, 375)
        Me.KryptonPanel.TabIndex = 0
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(98, 88)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(86, 19)
        Me.chkEnLaCadena.TabIndex = 16
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(683, 82)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 25)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.CausesValidation = False
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(98, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(673, 21)
        Me.txtCodigo.TabIndex = 11
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(193, 88)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(119, 19)
        Me.chkMientrasEscribe.TabIndex = 17
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(12, 12)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(88, 16)
        Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.TabIndex = 10
        Me.lblCodigo.Text = "CODIGO GRUPO: "
        Me.lblCodigo.Values.ExtraText = ""
        Me.lblCodigo.Values.Image = Nothing
        Me.lblCodigo.Values.Text = "CODIGO GRUPO: "
        '
        'txtRUC
        '
        Me.txtRUC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUC.CausesValidation = False
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Location = New System.Drawing.Point(98, 59)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(673, 21)
        Me.txtRUC.TabIndex = 15
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 37)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "DESCRIPCIÓN : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
        '
        'lblRUC
        '
        Me.lblRUC.Location = New System.Drawing.Point(12, 62)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(44, 16)
        Me.lblRUC.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRUC.TabIndex = 14
        Me.lblRUC.Text = "R.U.C. :"
        Me.lblRUC.Values.ExtraText = ""
        Me.lblRUC.Values.Image = Nothing
        Me.lblRUC.Values.Text = "R.U.C. :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CausesValidation = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(673, 21)
        Me.txtDescripcion.TabIndex = 13
        '
        'dgCliente
        '
        Me.dgCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgCliente.Location = New System.Drawing.Point(0, 113)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.pAccesoPorUsuario = False
        Me.dgCliente.pPermitirSalirDoubleClick = False
        Me.dgCliente.Size = New System.Drawing.Size(783, 262)
        Me.dgCliente.TabIndex = 0
        '
        'ucClienteGrupo_FCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ucClienteGrupo_FCliente"
        Me.Text = "Buscar:"
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
    Friend WithEvents dgCliente As Ransa.Controls.GrupoCliente.ucClienteGrupo_DgF01
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblRUC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
