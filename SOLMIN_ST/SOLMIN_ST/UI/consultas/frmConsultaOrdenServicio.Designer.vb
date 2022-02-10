<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOrdenServicio
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaOrdenServicio))
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gdwDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.clmSeleccion = New System.Windows.Forms.DataGridViewImageColumn
    Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TRFMRC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CTPOSR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.gdwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCLNT"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente / Razón Social"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.gdwDatos)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(936, 503)
    Me.KryptonPanel.TabIndex = 1
    '
    'gdwDatos
    '
    Me.gdwDatos.AllowUserToAddRows = False
    Me.gdwDatos.AllowUserToDeleteRows = False
    Me.gdwDatos.AllowUserToOrderColumns = True
    Me.gdwDatos.ColumnHeadersHeight = 30
    Me.gdwDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.NOPRCN, Me.NCTZCN, Me.NORSRT, Me.RUTA, Me.CCLNT, Me.CMRCDR, Me.QMRCDR, Me.TRFMRC, Me.CTPOSR})
    Me.gdwDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gdwDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gdwDatos.Location = New System.Drawing.Point(0, 72)
    Me.gdwDatos.MultiSelect = False
    Me.gdwDatos.Name = "gdwDatos"
    Me.gdwDatos.RowHeadersVisible = False
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.gdwDatos.RowsDefaultCellStyle = DataGridViewCellStyle2
    Me.gdwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gdwDatos.Size = New System.Drawing.Size(936, 431)
    Me.gdwDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gdwDatos.TabIndex = 1
    '
    'clmSeleccion
    '
    Me.clmSeleccion.HeaderText = ""
    Me.clmSeleccion.Image = Global.SOLMIN_ST.My.Resources.Resources.runprog
    Me.clmSeleccion.Name = "clmSeleccion"
    Me.clmSeleccion.Width = 30
    '
    'NOPRCN
    '
    Me.NOPRCN.DataPropertyName = "NOPRCN"
    Me.NOPRCN.HeaderText = "N° Operación"
    Me.NOPRCN.Name = "NOPRCN"
    Me.NOPRCN.Visible = False
    '
    'NCTZCN
    '
    Me.NCTZCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NCTZCN.DataPropertyName = "NCTZCN"
    Me.NCTZCN.HeaderText = "Cotización"
    Me.NCTZCN.Name = "NCTZCN"
    Me.NCTZCN.Width = 90
    '
    'NORSRT
    '
    Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NORSRT.DataPropertyName = "NORSRT"
    Me.NORSRT.HeaderText = "Orden de Servicio"
    Me.NORSRT.Name = "NORSRT"
    Me.NORSRT.Width = 127
    '
    'RUTA
    '
    Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.RUTA.DataPropertyName = "RUTA"
    Me.RUTA.HeaderText = "Ruta"
    Me.RUTA.Name = "RUTA"
    Me.RUTA.Width = 200
    '
    'CCLNT
    '
    Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.CCLNT.DataPropertyName = "CCLNT"
    Me.CCLNT.HeaderText = "Cliente "
    Me.CCLNT.Name = "CCLNT"
    Me.CCLNT.Width = 200
    '
    'CMRCDR
    '
    Me.CMRCDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CMRCDR.DataPropertyName = "CMRCDR"
    Me.CMRCDR.HeaderText = "Mercadería"
    Me.CMRCDR.Name = "CMRCDR"
    Me.CMRCDR.Width = 93
    '
    'QMRCDR
    '
    Me.QMRCDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.QMRCDR.DataPropertyName = "QMRCDR"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.QMRCDR.DefaultCellStyle = DataGridViewCellStyle1
    Me.QMRCDR.HeaderText = "Cantidad"
    Me.QMRCDR.Name = "QMRCDR"
    Me.QMRCDR.Width = 83
    '
    'TRFMRC
    '
    Me.TRFMRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TRFMRC.DataPropertyName = "TRFMRC"
    Me.TRFMRC.HeaderText = "Referencia Mercadería"
    Me.TRFMRC.Name = "TRFMRC"
    Me.TRFMRC.Width = 150
    '
    'CTPOSR
    '
    Me.CTPOSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CTPOSR.DataPropertyName = "CTPOSR"
    Me.CTPOSR.HeaderText = "Tipo de Servicio"
    Me.CTPOSR.Name = "CTPOSR"
    Me.CTPOSR.Width = 116
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar, Me.btnAceptar, Me.btnCancelar})
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(936, 72)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "59A77AB4FFBB44D159A77AB4FFBB44D1"
    '
    'btnAceptar
    '
    Me.btnAceptar.ExtraText = ""
    Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.ToolTipImage = Nothing
    Me.btnAceptar.UniqueName = "7514B2075AC048997514B2075AC04899"
    '
    'btnCancelar
    '
    Me.btnCancelar.ExtraText = ""
    Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.ToolTipBody = "Cancelar"
    Me.btnCancelar.ToolTipImage = Nothing
    Me.btnCancelar.UniqueName = "6B41DD36D3AF447B6B41DD36D3AF447B"
    '
    'txtCliente
    '
    Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtCliente.BackColor = System.Drawing.Color.Transparent
    Me.txtCliente.CCMPN = "EZ"
    Me.txtCliente.Location = New System.Drawing.Point(80, 11)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.pAccesoPorUsuario = False
    Me.txtCliente.pRequerido = False
    Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.txtCliente.Size = New System.Drawing.Size(304, 21)
    Me.txtCliente.TabIndex = 102
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(24, 12)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel1.TabIndex = 0
    Me.KryptonLabel1.Text = "Cliente "
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Cliente "
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLCLOR"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Punto de Origen"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NORSRT"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Orden de Servicio"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "CLCLDS"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Punto de Destino"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "CMRCDR"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Mercadería"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.DataPropertyName = "PNTDES"
    Me.DataGridViewTextBoxColumn12.HeaderText = "PNTDES"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.Visible = False
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "QMRCDR"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.DataPropertyName = "CUNDMD"
    Me.DataGridViewTextBoxColumn13.HeaderText = "CUNDMD"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.Visible = False
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "PNTORG"
    Me.DataGridViewTextBoxColumn11.HeaderText = "PNTORG"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.Visible = False
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.DataPropertyName = "PNTDES"
    Me.DataGridViewTextBoxColumn14.HeaderText = "PNTDES"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.Visible = False
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "TRFMRC"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Referencia Mercadería"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPSRV"
    Me.DataGridViewTextBoxColumn10.HeaderText = "TIPSRV"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.Visible = False
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CTPOSR"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo de Servicio"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "CODMER"
    Me.DataGridViewTextBoxColumn9.HeaderText = "CODMER"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.Visible = False
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.DataPropertyName = "CUNDMD"
    Me.DataGridViewTextBoxColumn15.HeaderText = "CUNDMD"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.Visible = False
    '
    'frmConsultaOrdenServicio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(936, 503)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmConsultaOrdenServicio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Consulta Orden de Servicio"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.gdwDatos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
  End Sub
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents gdwDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TRFMRC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CTPOSR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
