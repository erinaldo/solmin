<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeTextBox
    Inherits System.Windows.Forms.Panel

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeTextBox))
        Me.Images = New System.Windows.Forms.ImageList(Me.components)
        Me.PopupMenuTexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuBusquedaAvanzada = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLimpiarElemento = New System.Windows.Forms.ToolStripMenuItem
        Me.PopupMenuTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Images
        '
        Me.Images.ImageStream = CType(resources.GetObject("Images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Images.TransparentColor = System.Drawing.Color.Transparent
        Me.Images.Images.SetKeyName(0, "trash.png")
        Me.Images.Images.SetKeyName(1, "btnBuscar.png")
        Me.Images.Images.SetKeyName(2, "search.png")
        '
        'PopupMenuTexto
        '
        Me.PopupMenuTexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBusquedaAvanzada, Me.mnuLimpiarElemento})
        Me.PopupMenuTexto.Name = "ContextMenuStrip1"
        Me.PopupMenuTexto.Size = New System.Drawing.Size(184, 48)
        '
        'mnuBusquedaAvanzada
        '
        Me.mnuBusquedaAvanzada.Name = "mnuBusquedaAvanzada"
        Me.mnuBusquedaAvanzada.Size = New System.Drawing.Size(183, 22)
        Me.mnuBusquedaAvanzada.Text = "Búsqueda Avanzada"
        '
        'mnuLimpiarElemento
        '
        Me.mnuLimpiarElemento.Name = "mnuLimpiarElemento"
        Me.mnuLimpiarElemento.Size = New System.Drawing.Size(183, 22)
        Me.mnuLimpiarElemento.Text = "Limpiar Texto"
        '
        'CodeTextBox
        '
        Me.PopupMenuTexto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Images As System.Windows.Forms.ImageList
    Friend WithEvents PopupMenuTexto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuBusquedaAvanzada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLimpiarElemento As System.Windows.Forms.ToolStripMenuItem

End Class

