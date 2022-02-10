<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOIActualizaSAP
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnActualizaSap = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtClaseOrden = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbClaseOrden = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblNumDocumento = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbRango = New System.Windows.Forms.CheckBox
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtInicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFin = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(453, 152)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnActualizaSap, Me.btnCerrar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtClaseOrden)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbClaseOrden)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNumDocumento)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtFechaFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cbRango)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtFechaInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(453, 152)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnActualizaSap
        '
        Me.btnActualizaSap.ExtraText = ""
        Me.btnActualizaSap.Image = Global.SOLMIN_CT.My.Resources.Resources.irc_server
        Me.btnActualizaSap.Text = "Actualiza del Sap"
        Me.btnActualizaSap.ToolTipImage = Nothing
        Me.btnActualizaSap.UniqueName = "51ADCDBB5ECC404E51ADCDBB5ECC404E"
        '
        'btnCerrar
        '
        Me.btnCerrar.ExtraText = ""
        Me.btnCerrar.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.ToolTipImage = Nothing
        Me.btnCerrar.UniqueName = "6422F63D478A41396422F63D478A4139"
        '
        'txtClaseOrden
        '
        Me.txtClaseOrden.Enabled = False
        Me.txtClaseOrden.Location = New System.Drawing.Point(189, 12)
        Me.txtClaseOrden.Name = "txtClaseOrden"
        Me.txtClaseOrden.Size = New System.Drawing.Size(242, 21)
        Me.txtClaseOrden.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClaseOrden.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaseOrden.TabIndex = 2
        '
        'cmbClaseOrden
        '
        Me.cmbClaseOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClaseOrden.DropDownWidth = 236
        Me.cmbClaseOrden.FormattingEnabled = False
        Me.cmbClaseOrden.ItemHeight = 13
        Me.cmbClaseOrden.Location = New System.Drawing.Point(83, 12)
        Me.cmbClaseOrden.Name = "cmbClaseOrden"
        Me.cmbClaseOrden.Size = New System.Drawing.Size(100, 21)
        Me.cmbClaseOrden.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbClaseOrden.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbClaseOrden.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbClaseOrden.TabIndex = 1
        '
        'lblNumDocumento
        '
        Me.lblNumDocumento.Location = New System.Drawing.Point(11, 12)
        Me.lblNumDocumento.Name = "lblNumDocumento"
        Me.lblNumDocumento.Size = New System.Drawing.Size(77, 19)
        Me.lblNumDocumento.TabIndex = 0
        Me.lblNumDocumento.Text = "Clase Orden :"
        Me.lblNumDocumento.Values.ExtraText = ""
        Me.lblNumDocumento.Values.Image = Nothing
        Me.lblNumDocumento.Values.Text = "Clase Orden :"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(338, 82)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.dtFechaFin.TabIndex = 12
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(257, 83)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(62, 19)
        Me.KryptonLabel4.TabIndex = 11
        Me.KryptonLabel4.Text = "Fecha Fin :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Fin :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(257, 60)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Fecha Inicio :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Fecha Inicio :"
        '
        'cbRango
        '
        Me.cbRango.AutoSize = True
        Me.cbRango.BackColor = System.Drawing.Color.Transparent
        Me.cbRango.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRango.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cbRango.Location = New System.Drawing.Point(257, 39)
        Me.cbRango.Name = "cbRango"
        Me.cbRango.Size = New System.Drawing.Size(108, 17)
        Me.cbRango.TabIndex = 8
        Me.cbRango.Text = "Rango Fechas"
        Me.cbRango.UseVisualStyleBackColor = False
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.CustomFormat = ""
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(337, 59)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(93, 20)
        Me.dtFechaInicio.TabIndex = 10
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 39)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(91, 19)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "Numero Orden :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Numero Orden :"
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(58, 58)
        Me.txtInicio.MaxLength = 12
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(193, 21)
        Me.txtInicio.TabIndex = 5
        '
        'txtFin
        '
        Me.txtFin.Location = New System.Drawing.Point(58, 82)
        Me.txtFin.MaxLength = 12
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(193, 21)
        Me.txtFin.TabIndex = 7
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 60)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(41, 19)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Text = "Desde"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Desde"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 84)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Hasta"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Hasta"
        '
        'frmOIActualizaSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 152)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(461, 186)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(461, 186)
        Me.Name = "frmOIActualizaSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar OI desde el SAP"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnActualizaSap As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbRango As System.Windows.Forms.CheckBox
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtInicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFin As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClaseOrden As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbClaseOrden As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblNumDocumento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
