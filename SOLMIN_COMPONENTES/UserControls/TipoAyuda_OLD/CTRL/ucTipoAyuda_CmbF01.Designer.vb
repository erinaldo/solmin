<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTipoAyuda_CmbF01
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
        Me.cmbTipoAyuda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.dstTipoAyuda = New System.Data.DataSet
        Me.dtTipoAyuda = New System.Data.DataTable
        Me.CCMPRN = New System.Data.DataColumn
        Me.TDSDES = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.dstTipoAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTipoAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoAyuda
        '
        Me.cmbTipoAyuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoAyuda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoAyuda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoAyuda.DisplayMember = "TDSDES"
        Me.cmbTipoAyuda.DropDownWidth = 274
        Me.cmbTipoAyuda.FormattingEnabled = False
        Me.cmbTipoAyuda.ItemHeight = 13
        Me.cmbTipoAyuda.Location = New System.Drawing.Point(0, 0)
        Me.cmbTipoAyuda.Name = "cmbTipoAyuda"
        Me.cmbTipoAyuda.Size = New System.Drawing.Size(274, 21)
        Me.cmbTipoAyuda.TabIndex = 0
        Me.cmbTipoAyuda.ValueMember = "CCMPRN"
        '
        'dstTipoAyuda
        '
        Me.dstTipoAyuda.DataSetName = "dstTipoAyuda"
        Me.dstTipoAyuda.Tables.AddRange(New System.Data.DataTable() {Me.dtTipoAyuda})
        '
        'dtTipoAyuda
        '
        Me.dtTipoAyuda.Columns.AddRange(New System.Data.DataColumn() {Me.CCMPRN, Me.TDSDES})
        Me.dtTipoAyuda.TableName = "dtTipoAyuda"
        '
        'CCMPRN
        '
        Me.CCMPRN.ColumnName = "CCMPRN"
        Me.CCMPRN.DefaultValue = ""
        '
        'TDSDES
        '
        Me.TDSDES.ColumnName = "TDSDES"
        Me.TDSDES.DefaultValue = ""
        '
        'ucTipoAyuda_CmbF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmbTipoAyuda)
        Me.Name = "ucTipoAyuda_CmbF01"
        Me.Size = New System.Drawing.Size(274, 21)
        CType(Me.dstTipoAyuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTipoAyuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents cmbTipoAyuda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents dstTipoAyuda As System.Data.DataSet
    Friend WithEvents dtTipoAyuda As System.Data.DataTable
    Private WithEvents CCMPRN As System.Data.DataColumn
    Private WithEvents TDSDES As System.Data.DataColumn

End Class
