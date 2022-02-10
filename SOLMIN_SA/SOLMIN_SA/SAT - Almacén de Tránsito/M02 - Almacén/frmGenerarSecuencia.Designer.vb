<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarSecuencia
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
        Me.txtNroCopias = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroCopias = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroEtiquetas = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroEtiquetas = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpGenerarSecuencia = New System.Windows.Forms.GroupBox
        Me.txtPrefijoFinal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPrefijoInicial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroFinal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroInicial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCodigoFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodigoInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.chkReImprimirCodigos = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpGenerarSecuencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtNroCopias)
        Me.KryptonPanel.Controls.Add(Me.lblNroCopias)
        Me.KryptonPanel.Controls.Add(Me.txtNroEtiquetas)
        Me.KryptonPanel.Controls.Add(Me.lblNroEtiquetas)
        Me.KryptonPanel.Controls.Add(Me.grpGenerarSecuencia)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.chkReImprimirCodigos)
        Me.KryptonPanel.Controls.Add(Me.btnProcesar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(326, 199)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtNroCopias
        '
        Me.txtNroCopias.Location = New System.Drawing.Point(248, 126)
        Me.txtNroCopias.Name = "txtNroCopias"
        Me.txtNroCopias.Size = New System.Drawing.Size(53, 19)
        Me.txtNroCopias.TabIndex = 11
        Me.txtNroCopias.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroCopias, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroCopias
        '
        Me.lblNroCopias.Location = New System.Drawing.Point(166, 129)
        Me.lblNroCopias.Name = "lblNroCopias"
        Me.lblNroCopias.Size = New System.Drawing.Size(76, 16)
        Me.lblNroCopias.TabIndex = 10
        Me.lblNroCopias.Text = "Nro. Copias : "
        Me.lblNroCopias.Values.ExtraText = ""
        Me.lblNroCopias.Values.Image = Nothing
        Me.lblNroCopias.Values.Text = "Nro. Copias : "
        '
        'txtNroEtiquetas
        '
        Me.txtNroEtiquetas.Location = New System.Drawing.Point(106, 126)
        Me.txtNroEtiquetas.Name = "txtNroEtiquetas"
        Me.txtNroEtiquetas.Size = New System.Drawing.Size(53, 19)
        Me.txtNroEtiquetas.TabIndex = 9
        Me.txtNroEtiquetas.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroEtiquetas, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroEtiquetas
        '
        Me.lblNroEtiquetas.Location = New System.Drawing.Point(12, 129)
        Me.lblNroEtiquetas.Name = "lblNroEtiquetas"
        Me.lblNroEtiquetas.Size = New System.Drawing.Size(88, 16)
        Me.lblNroEtiquetas.TabIndex = 8
        Me.lblNroEtiquetas.Text = "Nro. Etiquetas : "
        Me.lblNroEtiquetas.Values.ExtraText = ""
        Me.lblNroEtiquetas.Values.Image = Nothing
        Me.lblNroEtiquetas.Values.Text = "Nro. Etiquetas : "
        '
        'grpGenerarSecuencia
        '
        Me.grpGenerarSecuencia.BackColor = System.Drawing.Color.Transparent
        Me.grpGenerarSecuencia.Controls.Add(Me.txtPrefijoFinal)
        Me.grpGenerarSecuencia.Controls.Add(Me.txtPrefijoInicial)
        Me.grpGenerarSecuencia.Controls.Add(Me.txtNroFinal)
        Me.grpGenerarSecuencia.Controls.Add(Me.txtNroInicial)
        Me.grpGenerarSecuencia.Controls.Add(Me.lblCodigoFinal)
        Me.grpGenerarSecuencia.Controls.Add(Me.lblCodigoInicial)
        Me.grpGenerarSecuencia.Location = New System.Drawing.Point(12, 34)
        Me.grpGenerarSecuencia.Name = "grpGenerarSecuencia"
        Me.grpGenerarSecuencia.Size = New System.Drawing.Size(302, 75)
        Me.grpGenerarSecuencia.TabIndex = 1
        Me.grpGenerarSecuencia.TabStop = False
        '
        'txtPrefijoFinal
        '
        Me.txtPrefijoFinal.Location = New System.Drawing.Point(94, 44)
        Me.txtPrefijoFinal.Name = "txtPrefijoFinal"
        Me.txtPrefijoFinal.ReadOnly = True
        Me.txtPrefijoFinal.Size = New System.Drawing.Size(26, 19)
        Me.txtPrefijoFinal.TabIndex = 6
        Me.txtPrefijoFinal.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtPrefijoFinal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtPrefijoInicial
        '
        Me.txtPrefijoInicial.Location = New System.Drawing.Point(94, 19)
        Me.txtPrefijoInicial.Name = "txtPrefijoInicial"
        Me.txtPrefijoInicial.Size = New System.Drawing.Size(26, 19)
        Me.txtPrefijoInicial.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtPrefijoInicial, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtNroFinal
        '
        Me.txtNroFinal.Location = New System.Drawing.Point(122, 44)
        Me.txtNroFinal.Name = "txtNroFinal"
        Me.txtNroFinal.ReadOnly = True
        Me.txtNroFinal.Size = New System.Drawing.Size(167, 19)
        Me.txtNroFinal.TabIndex = 7
        Me.txtNroFinal.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtNroFinal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtNroInicial
        '
        Me.txtNroInicial.Location = New System.Drawing.Point(122, 19)
        Me.txtNroInicial.Name = "txtNroInicial"
        Me.txtNroInicial.Size = New System.Drawing.Size(167, 19)
        Me.txtNroInicial.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroInicial, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCodigoFinal
        '
        Me.lblCodigoFinal.Location = New System.Drawing.Point(10, 47)
        Me.lblCodigoFinal.Name = "lblCodigoFinal"
        Me.lblCodigoFinal.Size = New System.Drawing.Size(80, 16)
        Me.lblCodigoFinal.TabIndex = 5
        Me.lblCodigoFinal.Text = "Código Final :"
        Me.lblCodigoFinal.Values.ExtraText = ""
        Me.lblCodigoFinal.Values.Image = Nothing
        Me.lblCodigoFinal.Values.Text = "Código Final :"
        '
        'lblCodigoInicial
        '
        Me.lblCodigoInicial.Location = New System.Drawing.Point(10, 22)
        Me.lblCodigoInicial.Name = "lblCodigoInicial"
        Me.lblCodigoInicial.Size = New System.Drawing.Size(84, 16)
        Me.lblCodigoInicial.TabIndex = 2
        Me.lblCodigoInicial.Text = "Código Inicial :"
        Me.lblCodigoInicial.Values.ExtraText = ""
        Me.lblCodigoInicial.Values.Image = Nothing
        Me.lblCodigoInicial.Values.Text = "Código Inicial :"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(211, 162)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'chkReImprimirCodigos
        '
        Me.chkReImprimirCodigos.Checked = False
        Me.chkReImprimirCodigos.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkReImprimirCodigos.Location = New System.Drawing.Point(12, 12)
        Me.chkReImprimirCodigos.Name = "chkReImprimirCodigos"
        Me.chkReImprimirCodigos.Size = New System.Drawing.Size(179, 16)
        Me.chkReImprimirCodigos.TabIndex = 0
        Me.chkReImprimirCodigos.Text = "Re-Imprimir Códigos de Barras"
        Me.chkReImprimirCodigos.Values.ExtraText = ""
        Me.chkReImprimirCodigos.Values.Image = Nothing
        Me.chkReImprimirCodigos.Values.Text = "Re-Imprimir Códigos de Barras"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(106, 162)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(90, 25)
        Me.btnProcesar.TabIndex = 12
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = ""
        Me.btnProcesar.Values.Image = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'frmGenerarSecuencia
        '
        Me.AcceptButton = Me.btnProcesar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(326, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGenerarSecuencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Secuencia - Código Barras"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpGenerarSecuencia.ResumeLayout(False)
        Me.grpGenerarSecuencia.PerformLayout()
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
    Friend WithEvents grpGenerarSecuencia As System.Windows.Forms.GroupBox
    Private WithEvents lblCodigoInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents chkReImprimirCodigos As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNroFinal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroInicial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCodigoFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroEtiquetas As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroEtiquetas As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroCopias As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroCopias As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPrefijoFinal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPrefijoInicial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
End Class
