<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_UbicacionPlanta
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.cmbPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.SuspendLayout()
        '
        'cmbPlanta
        '
        Me.cmbPlanta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.DropDownWidth = 156
        Me.cmbPlanta.FormattingEnabled = False
        Me.cmbPlanta.ItemHeight = 13
        Me.cmbPlanta.Location = New System.Drawing.Point(658, 4)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(216, 21)
        Me.cmbPlanta.TabIndex = 13
        Me.cmbPlanta.TabStop = False
        '
        'cmbDivision
        '
        Me.cmbDivision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 156
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 13
        Me.cmbDivision.Location = New System.Drawing.Point(391, 4)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(216, 21)
        Me.cmbDivision.TabIndex = 11
        Me.cmbDivision.TabStop = False
        '
        'cmbCompania
        '
        Me.cmbCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 13
        Me.cmbCompania.Location = New System.Drawing.Point(74, 4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(249, 21)
        Me.cmbCompania.TabIndex = 9
        Me.cmbCompania.TabStop = False
        '
        'lblPlanta
        '
        Me.lblPlanta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanta.Location = New System.Drawing.Point(613, 6)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(49, 16)
        Me.lblPlanta.TabIndex = 12
        Me.lblPlanta.Text = "Planta :"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta :"
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(0, 6)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(68, 16)
        Me.lblCompania.TabIndex = 8
        Me.lblCompania.Text = "Compañía :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel5.Location = New System.Drawing.Point(329, 6)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(56, 16)
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Text = "División :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División :"
        '
        'Control_UbicacionPlanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmbPlanta)
        Me.Controls.Add(Me.cmbDivision)
        Me.Controls.Add(Me.cmbCompania)
        Me.Controls.Add(Me.lblPlanta)
        Me.Controls.Add(Me.lblCompania)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.MaximumSize = New System.Drawing.Size(880, 30)
        Me.MinimumSize = New System.Drawing.Size(880, 30)
        Me.Name = "Control_UbicacionPlanta"
        Me.Size = New System.Drawing.Size(880, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
