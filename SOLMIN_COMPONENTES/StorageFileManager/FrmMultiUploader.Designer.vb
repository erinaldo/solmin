<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMultiUploader
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
        Me.Uploader1 = New StorageFileManager.MultiUploader()
        Me.SuspendLayout()
        '
        'Uploader1
        '
        Me.Uploader1.CCLNT = ""
        Me.Uploader1.CCMPN = ""
        Me.Uploader1.Location = New System.Drawing.Point(2, 1)
        Me.Uploader1.Margin = New System.Windows.Forms.Padding(5)
        Me.Uploader1.Name = "Uploader1"
        Me.Uploader1.NMRGIM = ""
        Me.Uploader1.Size = New System.Drawing.Size(625, 303)
        Me.Uploader1.SystemName = ""
        Me.Uploader1.TabIndex = 0
        Me.Uploader1.TableName = ""
        Me.Uploader1.UserName = ""
        '
        'FrmMultiUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 307)
        Me.Controls.Add(Me.Uploader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMultiUploader"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Carga de Archivos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Uploader1 As StorageFileManager.MultiUploader

End Class
