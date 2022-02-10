<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantImpresion
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonRadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonRadioButton2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.txtTotal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCantInicial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantFinal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTotal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonRadioButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonRadioButton1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(369, 186)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Etiquetas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonRadioButton1
        '
        Me.KryptonRadioButton1.Checked = True
        Me.KryptonRadioButton1.Location = New System.Drawing.Point(15, 10)
        Me.KryptonRadioButton1.Name = "KryptonRadioButton1"
        Me.KryptonRadioButton1.Size = New System.Drawing.Size(173, 20)
        Me.KryptonRadioButton1.TabIndex = 0
        Me.KryptonRadioButton1.Text = "Sin Numeracion - Cantidad:"
        Me.KryptonRadioButton1.Values.ExtraText = ""
        Me.KryptonRadioButton1.Values.Image = Nothing
        Me.KryptonRadioButton1.Values.Text = "Sin Numeracion - Cantidad:"
        '
        'KryptonRadioButton2
        '
        Me.KryptonRadioButton2.Location = New System.Drawing.Point(15, 50)
        Me.KryptonRadioButton2.Name = "KryptonRadioButton2"
        Me.KryptonRadioButton2.Size = New System.Drawing.Size(260, 20)
        Me.KryptonRadioButton2.TabIndex = 1
        Me.KryptonRadioButton2.Text = "Con Numeracion de Items - Cantidad Inicial"
        Me.KryptonRadioButton2.Values.ExtraText = ""
        Me.KryptonRadioButton2.Values.Image = Nothing
        Me.KryptonRadioButton2.Values.Text = "Con Numeracion de Items - Cantidad Inicial"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(185, 10)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(60, 22)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.Text = "1"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(175, 85)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel1.TabIndex = 4
        Me.KryptonLabel1.Text = "Cantidad Final"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cantidad Final"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(135, 125)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(90, 25)
        Me.KryptonButton1.TabIndex = 6
        Me.KryptonButton1.Text = "Imprimir"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Imprimir"
        '
        'txtCantInicial
        '
        Me.txtCantInicial.Location = New System.Drawing.Point(270, 50)
        Me.txtCantInicial.Name = "txtCantInicial"
        Me.txtCantInicial.Size = New System.Drawing.Size(60, 22)
        Me.txtCantInicial.TabIndex = 7
        Me.txtCantInicial.Text = "1"
        '
        'txtCantFinal
        '
        Me.txtCantFinal.Location = New System.Drawing.Point(270, 85)
        Me.txtCantFinal.Name = "txtCantFinal"
        Me.txtCantFinal.Size = New System.Drawing.Size(60, 22)
        Me.txtCantFinal.TabIndex = 8
        Me.txtCantFinal.Text = "1"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(255, 125)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(90, 25)
        Me.KryptonButton2.TabIndex = 9
        Me.KryptonButton2.Text = "Cancelar"
        Me.KryptonButton2.Values.ExtraText = ""
        Me.KryptonButton2.Values.Image = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton2.Values.Text = "Cancelar"
        '
        'frmCantImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 186)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCantImpresion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cantidad de Impresiones"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTotal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonRadioButton2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonRadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtCantFinal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantInicial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
