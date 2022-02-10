<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCtrlsSelecTres_F01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCtrlsSelecTres_F01))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dgBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.MCAMP01 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MCAMP02 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MCAMP03 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstBusqueda = New System.Data.DataSet
        Me.dtBusqueda = New System.Data.DataTable
        Me.CAMP01 = New System.Data.DataColumn
        Me.CAMP02 = New System.Data.DataColumn
        Me.CAMP03 = New System.Data.DataColumn
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtCampo03 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo03 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCampo02 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo02 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCampo01 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCampo01 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.chkEnLaCadena)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.dgBusqueda)
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.txtCampo03)
        Me.KryptonPanel.Controls.Add(Me.lblCampo03)
        Me.KryptonPanel.Controls.Add(Me.txtCampo02)
        Me.KryptonPanel.Controls.Add(Me.lblCampo02)
        Me.KryptonPanel.Controls.Add(Me.txtCampo01)
        Me.KryptonPanel.Controls.Add(Me.lblCampo01)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(496, 418)
        Me.KryptonPanel.TabIndex = 0
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.Checked = False
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(105, 87)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(89, 16)
        Me.chkEnLaCadena.TabIndex = 7
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(394, 385)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(298, 385)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'dgBusqueda
        '
        Me.dgBusqueda.AllowUserToAddRows = False
        Me.dgBusqueda.AllowUserToDeleteRows = False
        Me.dgBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgBusqueda.AutoGenerateColumns = False
        Me.dgBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MCAMP01, Me.MCAMP02, Me.MCAMP03})
        Me.dgBusqueda.DataMember = "dtBusqueda"
        Me.dgBusqueda.DataSource = Me.dstBusqueda
        Me.dgBusqueda.Location = New System.Drawing.Point(12, 109)
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.ReadOnly = True
        Me.dgBusqueda.RowHeadersWidth = 15
        Me.dgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBusqueda.Size = New System.Drawing.Size(472, 266)
        Me.dgBusqueda.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBusqueda.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBusqueda.TabIndex = 9
        '
        'MCAMP01
        '
        Me.MCAMP01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MCAMP01.DataPropertyName = "CAMP01"
        Me.MCAMP01.HeaderText = "CAMP01"
        Me.MCAMP01.Name = "MCAMP01"
        Me.MCAMP01.ReadOnly = True
        Me.MCAMP01.Width = 78
        '
        'MCAMP02
        '
        Me.MCAMP02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MCAMP02.DataPropertyName = "CAMP02"
        Me.MCAMP02.HeaderText = "CAMP02"
        Me.MCAMP02.Name = "MCAMP02"
        Me.MCAMP02.ReadOnly = True
        Me.MCAMP02.Width = 78
        '
        'MCAMP03
        '
        Me.MCAMP03.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MCAMP03.DataPropertyName = "CAMP03"
        Me.MCAMP03.HeaderText = "CAMP03"
        Me.MCAMP03.Name = "MCAMP03"
        Me.MCAMP03.ReadOnly = True
        Me.MCAMP03.Width = 78
        '
        'dstBusqueda
        '
        Me.dstBusqueda.DataSetName = "dstBusqueda"
        Me.dstBusqueda.Tables.AddRange(New System.Data.DataTable() {Me.dtBusqueda})
        '
        'dtBusqueda
        '
        Me.dtBusqueda.Columns.AddRange(New System.Data.DataColumn() {Me.CAMP01, Me.CAMP02, Me.CAMP03})
        Me.dtBusqueda.TableName = "dtBusqueda"
        '
        'CAMP01
        '
        Me.CAMP01.ColumnName = "CAMP01"
        Me.CAMP01.DefaultValue = ""
        '
        'CAMP02
        '
        Me.CAMP02.ColumnName = "CAMP02"
        Me.CAMP02.DefaultValue = ""
        '
        'CAMP03
        '
        Me.CAMP03.ColumnName = "CAMP03"
        Me.CAMP03.DefaultValue = ""
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(200, 87)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(121, 16)
        Me.chkMientrasEscribe.TabIndex = 8
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'txtCampo03
        '
        Me.txtCampo03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo03.CausesValidation = False
        Me.txtCampo03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo03.Location = New System.Drawing.Point(105, 62)
        Me.txtCampo03.Name = "txtCampo03"
        Me.txtCampo03.Size = New System.Drawing.Size(379, 19)
        Me.txtCampo03.TabIndex = 6
        '
        'lblCampo03
        '
        Me.lblCampo03.Location = New System.Drawing.Point(3, 65)
        Me.lblCampo03.Name = "lblCampo03"
        Me.lblCampo03.Size = New System.Drawing.Size(61, 16)
        Me.lblCampo03.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCampo03.TabIndex = 5
        Me.lblCampo03.Text = "CAMPO03 :"
        Me.lblCampo03.Values.ExtraText = ""
        Me.lblCampo03.Values.Image = Nothing
        Me.lblCampo03.Values.Text = "CAMPO03 :"
        '
        'txtCampo02
        '
        Me.txtCampo02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo02.CausesValidation = False
        Me.txtCampo02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo02.Location = New System.Drawing.Point(105, 37)
        Me.txtCampo02.Name = "txtCampo02"
        Me.txtCampo02.Size = New System.Drawing.Size(379, 19)
        Me.txtCampo02.TabIndex = 4
        '
        'lblCampo02
        '
        Me.lblCampo02.Location = New System.Drawing.Point(3, 40)
        Me.lblCampo02.Name = "lblCampo02"
        Me.lblCampo02.Size = New System.Drawing.Size(61, 16)
        Me.lblCampo02.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCampo02.TabIndex = 3
        Me.lblCampo02.Text = "CAMPO02 : "
        Me.lblCampo02.Values.ExtraText = ""
        Me.lblCampo02.Values.Image = Nothing
        Me.lblCampo02.Values.Text = "CAMPO02 : "
        '
        'txtCampo01
        '
        Me.txtCampo01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo01.CausesValidation = False
        Me.txtCampo01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo01.Location = New System.Drawing.Point(105, 12)
        Me.txtCampo01.Name = "txtCampo01"
        Me.txtCampo01.Size = New System.Drawing.Size(379, 19)
        Me.txtCampo01.TabIndex = 2
        '
        'lblCampo01
        '
        Me.lblCampo01.Location = New System.Drawing.Point(3, 15)
        Me.lblCampo01.Name = "lblCampo01"
        Me.lblCampo01.Size = New System.Drawing.Size(61, 16)
        Me.lblCampo01.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampo01.TabIndex = 1
        Me.lblCampo01.Text = "CAMPO01 : "
        Me.lblCampo01.Values.ExtraText = ""
        Me.lblCampo01.Values.Image = Nothing
        Me.lblCampo01.Values.Text = "CAMPO01 : "
        '
        'ucCtrlsSelecTres_F01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(496, 418)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ucCtrlsSelecTres_F01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSQUEDA : "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents txtCampo03 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo03 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCampo02 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo02 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCampo01 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCampo01 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dstBusqueda As System.Data.DataSet
    Friend WithEvents dtBusqueda As System.Data.DataTable
    Friend WithEvents CAMP01 As System.Data.DataColumn
    Private WithEvents dgBusqueda As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CAMP02 As System.Data.DataColumn
    Friend WithEvents CAMP03 As System.Data.DataColumn
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents MCAMP01 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCAMP02 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCAMP03 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
