<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMoneda_CmbF01
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
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.cmbMoneda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.dstMoneda = New System.Data.DataSet
        Me.dtMoneda = New System.Data.DataTable
        Me.CMNDA1 = New System.Data.DataColumn
        Me.TMNDA = New System.Data.DataColumn
        CType(Me.dstMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMoneda.DisplayMember = "TMNDA"
        Me.cmbMoneda.DropDownWidth = 274
        Me.cmbMoneda.FormattingEnabled = False
        Me.cmbMoneda.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.cmbMoneda.ItemHeight = 13
        Me.cmbMoneda.Location = New System.Drawing.Point(0, 0)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(274, 21)
        Me.cmbMoneda.TabIndex = 1
        Me.cmbMoneda.ValueMember = "CMNDA1"
        '
        'dstMoneda
        '
        Me.dstMoneda.DataSetName = "dstMoneda"
        Me.dstMoneda.Tables.AddRange(New System.Data.DataTable() {Me.dtMoneda})
        '
        'dtMoneda
        '
        Me.dtMoneda.Columns.AddRange(New System.Data.DataColumn() {Me.CMNDA1, Me.TMNDA})
        Me.dtMoneda.TableName = "dtMoneda"
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
        'ucMoneda_CmbF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbMoneda)
        Me.Name = "ucMoneda_CmbF01"
        Me.Size = New System.Drawing.Size(274, 21)
        CType(Me.dstMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents cmbMoneda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents dstMoneda As System.Data.DataSet
    Friend WithEvents dtMoneda As System.Data.DataTable
    Private WithEvents CMNDA1 As System.Data.DataColumn
    Private WithEvents TMNDA As System.Data.DataColumn

End Class
