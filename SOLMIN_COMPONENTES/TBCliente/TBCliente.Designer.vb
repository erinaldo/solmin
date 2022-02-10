<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TBCliente
    Inherits System.Windows.Forms.TextBox

    'Control reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de controles
    Private components As System.ComponentModel.IContainer

    ' NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    ' Se puede modificar usando el Diseñador de componentes. No lo modifique
    ' usando el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PopupMenuTexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuBusquedaAvanzada = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLimpiarElemento = New System.Windows.Forms.ToolStripMenuItem
        Me.PopupMenuTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'PopupMenuTexto
        '
        Me.PopupMenuTexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBusquedaAvanzada, Me.mnuLimpiarElemento})
        Me.PopupMenuTexto.Name = "ContextMenuStrip1"
        Me.PopupMenuTexto.Size = New System.Drawing.Size(184, 48)
        '
        'mnuBusquedaAvanzada
        '
        'Me.mnuBusquedaAvanzada.Image = Global.SOLMIN_TR.My.Resources.Resources._32px_Crystal_Clear_mimetype_vcard
        Me.mnuBusquedaAvanzada.Name = "mnuBusquedaAvanzada"
        Me.mnuBusquedaAvanzada.Size = New System.Drawing.Size(183, 22)
        Me.mnuBusquedaAvanzada.Text = "Búsqueda Avanzada"
        '
        'mnuLimpiarElemento
        '
        'Me.mnuLimpiarElemento.Image = Global.SOLMIN_TR.My.Resources.Resources.Delete16
        Me.mnuLimpiarElemento.Name = "mnuLimpiarElemento"
        Me.mnuLimpiarElemento.Size = New System.Drawing.Size(183, 22)
        Me.mnuLimpiarElemento.Text = "Limpiar Texto"
        Me.PopupMenuTexto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PopupMenuTexto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuBusquedaAvanzada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLimpiarElemento As System.Windows.Forms.ToolStripMenuItem

End Class

