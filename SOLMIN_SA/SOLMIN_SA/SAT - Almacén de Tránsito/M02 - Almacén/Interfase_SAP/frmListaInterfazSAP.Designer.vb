<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaInterfazSAP
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
        Me.dgInterfaz = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DCENSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUCPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CENSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgInterfaz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgInterfaz)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(658, 251)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgInterfaz
        '
        Me.dgInterfaz.AllowUserToAddRows = False
        Me.dgInterfaz.AllowUserToDeleteRows = False
        Me.dgInterfaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgInterfaz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DCENSA, Me.NUMDES, Me.DESPRV, Me.RUCPRV, Me.CENSAP, Me.DESCEN})
        Me.dgInterfaz.DataMember = "dtItemOC"
        Me.dgInterfaz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInterfaz.Location = New System.Drawing.Point(0, 25)
        Me.dgInterfaz.MultiSelect = False
        Me.dgInterfaz.Name = "dgInterfaz"
        Me.dgInterfaz.RowHeadersWidth = 20
        Me.dgInterfaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgInterfaz.Size = New System.Drawing.Size(658, 226)
        Me.dgInterfaz.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgInterfaz.TabIndex = 28
        '
        'DCENSA
        '
        Me.DCENSA.DataPropertyName = "DCENSA"
        Me.DCENSA.HeaderText = "Nr. Documento"
        Me.DCENSA.Name = "DCENSA"
        '
        'NUMDES
        '
        Me.NUMDES.DataPropertyName = "NUMDES"
        Me.NUMDES.HeaderText = "Orden de Compra"
        Me.NUMDES.Name = "NUMDES"
        '
        'DESPRV
        '
        Me.DESPRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESPRV.DataPropertyName = "DESPRV"
        Me.DESPRV.HeaderText = "Proveedor"
        Me.DESPRV.Name = "DESPRV"
        '
        'RUCPRV
        '
        Me.RUCPRV.DataPropertyName = "RUCPRV"
        Me.RUCPRV.HeaderText = "Ruc. Proveedor"
        Me.RUCPRV.Name = "RUCPRV"
        '
        'CENSAP
        '
        Me.CENSAP.DataPropertyName = "CENSAP"
        Me.CENSAP.HeaderText = "Centro Costo "
        Me.CENSAP.Name = "CENSAP"
        '
        'DESCEN
        '
        Me.DESCEN.HeaderText = "Descripción Centro Costo"
        Me.DESCEN.Name = "DESCEN"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(658, 25)
        Me.tsMenuOpciones.TabIndex = 27
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "&Cancelar"
        Me.tsbCancelar.ToolTipText = "Guardar "
        '
        'frmListaInterfazSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 251)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaInterfazSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Interfaz SAP"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgInterfaz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Private WithEvents dgInterfaz As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DCENSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUCPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CENSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCEN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
