<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServTransp_CmbF01
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cmbServTransp = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.dstServTransp = New System.Data.DataSet
        Me.dtServTransp = New System.Data.DataTable
        Me.CMNDA1 = New System.Data.DataColumn
        Me.TMNDA = New System.Data.DataColumn
        CType(Me.dstServTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtServTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbServTransp
        '
        Me.cmbServTransp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbServTransp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbServTransp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbServTransp.DisplayMember = "TCMTRF"
        Me.cmbServTransp.DropDownWidth = 274
        Me.cmbServTransp.FormattingEnabled = False
        Me.cmbServTransp.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.cmbServTransp.ItemHeight = 13
        Me.cmbServTransp.Location = New System.Drawing.Point(0, 0)
        Me.cmbServTransp.Name = "cmbServTransp"
        Me.cmbServTransp.Size = New System.Drawing.Size(274, 21)
        Me.cmbServTransp.TabIndex = 1
        Me.cmbServTransp.ValueMember = "CSRVNV"
        '
        'dstServTransp
        '
        Me.dstServTransp.DataSetName = "dstServTransp"
        Me.dstServTransp.Tables.AddRange(New System.Data.DataTable() {Me.dtServTransp})
        '
        'dtServTransp
        '
        Me.dtServTransp.Columns.AddRange(New System.Data.DataColumn() {Me.CMNDA1, Me.TMNDA})
        Me.dtServTransp.TableName = "dtServTransp"
        '
        'CMNDA1
        '
        Me.CMNDA1.ColumnName = "CMNDA1"
        Me.CMNDA1.DefaultValue = ""
        '
        'TMNDA
        '
        Me.TMNDA.ColumnName = "TMNDA"
        Me.TMNDA.DefaultValue = ""
        '
        'ucServTransp_CmbF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbServTransp)
        Me.Name = "ucServTransp_CmbF01"
        Me.Size = New System.Drawing.Size(274, 21)
        CType(Me.dstServTransp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtServTransp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents cmbServTransp As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents dstServTransp As System.Data.DataSet
    Friend WithEvents dtServTransp As System.Data.DataTable
    Private WithEvents CMNDA1 As System.Data.DataColumn
    Private WithEvents TMNDA As System.Data.DataColumn

End Class
