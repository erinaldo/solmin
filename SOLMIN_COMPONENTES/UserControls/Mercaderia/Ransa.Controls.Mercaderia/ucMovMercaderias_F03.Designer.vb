<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMovMercaderias_F03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMovMercaderias_F03))
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpTitulo = New System.Windows.Forms.GroupBox
        Me.btnGenerarReporte = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(87, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.Size = New System.Drawing.Size(246, 19)
        Me.txtCliente.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(6, 22)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'grpTitulo
        '
        Me.grpTitulo.Controls.Add(Me.btnGenerarReporte)
        Me.grpTitulo.Controls.Add(Me.dteFechaFinal)
        Me.grpTitulo.Controls.Add(Me.dteFechaInicial)
        Me.grpTitulo.Controls.Add(Me.lblFechaFinal)
        Me.grpTitulo.Controls.Add(Me.lblFechaInicial)
        Me.grpTitulo.Controls.Add(Me.txtCliente)
        Me.grpTitulo.Controls.Add(Me.lblCliente)
        Me.grpTitulo.Location = New System.Drawing.Point(0, 0)
        Me.grpTitulo.Name = "grpTitulo"
        Me.grpTitulo.Size = New System.Drawing.Size(357, 154)
        Me.grpTitulo.TabIndex = 2
        Me.grpTitulo.TabStop = False
        Me.grpTitulo.Text = "Movimiento Valorizado"
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarReporte.Location = New System.Drawing.Point(192, 104)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(141, 34)
        Me.btnGenerarReporte.TabIndex = 18
        Me.btnGenerarReporte.Text = " &Generar Reporte "
        Me.btnGenerarReporte.Values.ExtraText = ""
        Me.btnGenerarReporte.Values.Image = CType(resources.GetObject("btnGenerarReporte.Values.Image"), System.Drawing.Image)
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarReporte.Values.Text = " &Generar Reporte "
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(87, 70)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaFinal.TabIndex = 12
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(87, 44)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInicial.TabIndex = 10
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(6, 74)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(76, 16)
        Me.lblFechaFinal.TabIndex = 11
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(6, 48)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(77, 16)
        Me.lblFechaInicial.TabIndex = 9
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'ucMovMercaderias_F03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.grpTitulo)
        Me.Name = "ucMovMercaderias_F03"
        Me.Size = New System.Drawing.Size(357, 154)
        Me.grpTitulo.ResumeLayout(False)
        Me.grpTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpTitulo As System.Windows.Forms.GroupBox
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGenerarReporte As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
