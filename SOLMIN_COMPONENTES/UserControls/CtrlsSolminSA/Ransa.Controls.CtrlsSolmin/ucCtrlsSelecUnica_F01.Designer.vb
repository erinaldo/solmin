<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCtrlsSelecUnica_F01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCtrlsSelecUnica_F01))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dgBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.MCAMP01 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstBusqueda = New System.Data.DataSet
        Me.dtBusqueda = New System.Data.DataTable
        Me.CAMP01 = New System.Data.DataColumn
        Me.txtCondicion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
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
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.dgBusqueda)
        Me.KryptonPanel.Controls.Add(Me.txtCondicion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(274, 401)
        Me.KryptonPanel.TabIndex = 0
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.Checked = False
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(12, 41)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(89, 16)
        Me.chkEnLaCadena.TabIndex = 2
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(141, 41)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(121, 16)
        Me.chkMientrasEscribe.TabIndex = 3
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(172, 367)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 6
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
        Me.btnAceptar.Location = New System.Drawing.Point(76, 367)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 5
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
        Me.dgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MCAMP01})
        Me.dgBusqueda.DataMember = "dtBusqueda"
        Me.dgBusqueda.DataSource = Me.dstBusqueda
        Me.dgBusqueda.Location = New System.Drawing.Point(12, 63)
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.ReadOnly = True
        Me.dgBusqueda.RowHeadersWidth = 15
        Me.dgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBusqueda.Size = New System.Drawing.Size(250, 298)
        Me.dgBusqueda.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBusqueda.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBusqueda.TabIndex = 4
        '
        'MCAMP01
        '
        Me.MCAMP01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MCAMP01.DataPropertyName = "CAMP01"
        Me.MCAMP01.HeaderText = "CAMP01"
        Me.MCAMP01.Name = "MCAMP01"
        Me.MCAMP01.ReadOnly = True
        '
        'dstBusqueda
        '
        Me.dstBusqueda.DataSetName = "dstBusqueda"
        Me.dstBusqueda.Tables.AddRange(New System.Data.DataTable() {Me.dtBusqueda})
        '
        'dtBusqueda
        '
        Me.dtBusqueda.Columns.AddRange(New System.Data.DataColumn() {Me.CAMP01})
        Me.dtBusqueda.TableName = "dtBusqueda"
        '
        'CAMP01
        '
        Me.CAMP01.ColumnName = "CAMP01"
        Me.CAMP01.DefaultValue = ""
        '
        'txtCondicion
        '
        Me.txtCondicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondicion.Location = New System.Drawing.Point(12, 12)
        Me.txtCondicion.Name = "txtCondicion"
        Me.txtCondicion.Size = New System.Drawing.Size(250, 19)
        Me.txtCondicion.TabIndex = 1
        '
        'ucCtrlsSelecUnica_F01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(274, 401)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ucCtrlsSelecUnica_F01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Titulo"
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
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgBusqueda As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtCondicion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dstBusqueda As System.Data.DataSet
    Friend WithEvents dtBusqueda As System.Data.DataTable
    Friend WithEvents CAMP01 As System.Data.DataColumn
    Friend WithEvents MCAMP01 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
