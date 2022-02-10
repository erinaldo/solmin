<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantImpresionEtiqueta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtCantCopias = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantBultos = New System.Windows.Forms.TextBox()
        Me.txtCantFinal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCantInicial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimir, Me.btnCancelar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantCopias)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantBultos)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(452, 141)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "4FE11196E6E24C884FE11196E6E24C88"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "DB967E28A80B408BDB967E28A80B408B"
        '
        'txtCantCopias
        '
        Me.txtCantCopias.Location = New System.Drawing.Point(124, 17)
        Me.txtCantCopias.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantCopias.Name = "txtCantCopias"
        Me.txtCantCopias.Size = New System.Drawing.Size(80, 26)
        Me.txtCantCopias.TabIndex = 7
        Me.txtCantCopias.Text = "1"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(10, 19)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(96, 24)
        Me.KryptonLabel4.TabIndex = 6
        Me.KryptonLabel4.Text = "Cant. Copias"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cant. Copias"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(221, 55)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(58, 24)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Hasta :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hasta :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(10, 56)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(51, 24)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Inicio:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Inicio:"
        '
        'txtCantBultos
        '
        Me.txtCantBultos.Enabled = False
        Me.txtCantBultos.Location = New System.Drawing.Point(312, 21)
        Me.txtCantBultos.Name = "txtCantBultos"
        Me.txtCantBultos.Size = New System.Drawing.Size(80, 22)
        Me.txtCantBultos.TabIndex = 1
        '
        'txtCantFinal
        '
        Me.txtCantFinal.Location = New System.Drawing.Point(312, 53)
        Me.txtCantFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantFinal.Name = "txtCantFinal"
        Me.txtCantFinal.Size = New System.Drawing.Size(80, 26)
        Me.txtCantFinal.TabIndex = 5
        Me.txtCantFinal.Text = "1"
        '
        'txtCantInicial
        '
        Me.txtCantInicial.Location = New System.Drawing.Point(124, 55)
        Me.txtCantInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantInicial.Name = "txtCantInicial"
        Me.txtCantInicial.Size = New System.Drawing.Size(80, 26)
        Me.txtCantInicial.TabIndex = 3
        Me.txtCantInicial.Text = "1"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(212, 19)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(93, 24)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cant. Bultos"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cant. Bultos"
        '
        'frmCantImpresionEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 141)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCantImpresionEtiqueta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantFinal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantInicial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantBultos As System.Windows.Forms.TextBox
    Friend WithEvents txtCantCopias As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
