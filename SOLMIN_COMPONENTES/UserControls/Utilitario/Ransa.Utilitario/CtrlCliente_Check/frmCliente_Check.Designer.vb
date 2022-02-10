<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente_Check
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkFiltrar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDato = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dtgData = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkFiltrar
        '
        Me.chkFiltrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrar.Location = New System.Drawing.Point(122, 102)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(55, 20)
        Me.chkFiltrar.TabIndex = 22
        Me.chkFiltrar.Text = "Filtrar"
        Me.chkFiltrar.Values.ExtraText = ""
        Me.chkFiltrar.Values.Image = Nothing
        Me.chkFiltrar.Values.Text = "Filtrar"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2
        Me.lblBusqueda.Location = New System.Drawing.Point(21, 21)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(63, 20)
        Me.lblBusqueda.TabIndex = 24
        Me.lblBusqueda.Text = "CÓDIGO :"
        Me.lblBusqueda.Values.ExtraText = ""
        Me.lblBusqueda.Values.Image = Nothing
        Me.lblBusqueda.Values.Text = "CÓDIGO :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(122, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(224, 22)
        Me.txtCodigo.TabIndex = 20
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(122, 47)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(417, 22)
        Me.txtDato.TabIndex = 21
        '
        'lblDato
        '
        Me.lblDato.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2
        Me.lblDato.Location = New System.Drawing.Point(21, 49)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(93, 20)
        Me.lblDato.TabIndex = 25
        Me.lblDato.Text = "DESCRIPCIÓN :"
        Me.lblDato.Values.ExtraText = ""
        Me.lblDato.Values.Image = Nothing
        Me.lblDato.Values.Text = "DESCRIPCIÓN :"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblBusqueda)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtRUC)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.chkFiltrar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblDato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCodigo)
        Me.KryptonGroup1.Size = New System.Drawing.Size(605, 126)
        Me.KryptonGroup1.TabIndex = 26
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(218, 102)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(128, 20)
        Me.chkMientrasEscribe.TabIndex = 26
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(122, 74)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(417, 22)
        Me.txtRUC.TabIndex = 21
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2
        Me.KryptonLabel1.Location = New System.Drawing.Point(21, 76)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel1.TabIndex = 25
        Me.KryptonLabel1.Text = "RUC :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "RUC :"
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 126)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.dtgData)
        Me.KryptonGroup2.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(605, 421)
        Me.KryptonGroup2.TabIndex = 27
        '
        'dtgData
        '
        Me.dtgData.AllowUserToAddRows = False
        Me.dtgData.AllowUserToDeleteRows = False
        Me.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgData.Location = New System.Drawing.Point(0, 25)
        Me.dtgData.Name = "dtgData"
        Me.dtgData.Size = New System.Drawing.Size(603, 394)
        Me.dtgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgData.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgData.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheck, Me.ToolStripSeparator1, Me.btnCerrar, Me.ToolStripSeparator3, Me.btnAceptar, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.Ransa.Utilitario.My.Resources.Resources.ark_selectall
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 22)
        Me.btnCheck.Text = "Check all"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.Ransa.Utilitario.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(59, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.Ransa.Utilitario.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmCliente_Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(605, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonGroup2)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCliente_Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.dtgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkFiltrar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblBusqueda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDato As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgData As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
