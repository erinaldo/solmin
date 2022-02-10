<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUnidad_TxF01
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
        Me.txtUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaCliente = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.dstMoneda = New System.Data.DataSet
        Me.dtMoneda = New System.Data.DataTable
        Me.CMNDA1 = New System.Data.DataColumn
        Me.TMNDA = New System.Data.DataColumn
        CType(Me.dstMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnidad
        '
        Me.txtUnidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUnidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaCliente})
        Me.TypeValidator.SetEnterTAB(Me.txtUnidad, True)
        Me.txtUnidad.Location = New System.Drawing.Point(0, 0)
        Me.txtUnidad.MaxLength = 50
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(258, 19)
        Me.txtUnidad.TabIndex = 56
        Me.TypeValidator.SetTypes(Me.txtUnidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaCliente
        '
        Me.bsaCliente.ExtraText = ""
        Me.bsaCliente.Image = Nothing
        Me.bsaCliente.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaCliente.Text = ""
        Me.bsaCliente.ToolTipImage = Nothing
        Me.bsaCliente.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaCliente.UniqueName = "6B2527A567DC46316B2527A567DC4631"
        Me.bsaCliente.Visible = False
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
        'ucUnidad_TxF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtUnidad)
        Me.Name = "ucUnidad_TxF01"
        Me.Size = New System.Drawing.Size(258, 19)
        CType(Me.dstMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents dstMoneda As System.Data.DataSet
    Friend WithEvents dtMoneda As System.Data.DataTable
    Private WithEvents CMNDA1 As System.Data.DataColumn
    Private WithEvents TMNDA As System.Data.DataColumn
    Friend WithEvents txtUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaCliente As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
