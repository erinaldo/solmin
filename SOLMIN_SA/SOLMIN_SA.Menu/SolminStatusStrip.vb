Imports System.Windows.Forms.Control.ControlCollection
Imports System.Reflection
Imports System.Xml
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Drawing.Printing
Imports System.Windows.Forms.Timer

Public Class SolminStatusStrip
    Inherits StatusStrip

    Private _StartDataBind As Boolean = False
    Private _AllReadyPainted As Boolean = False
    Private _System As String = ""
    Private _System_prefix As String = ""
    Private _MMAPLC As String = String.Empty
    Private _MMCUSR As String = String.Empty
    Private _SERVIDOR As String = String.Empty
    Private _USUARIO As String = String.Empty
    Private _CLIENTE As String = String.Empty
    Private _RUTA_IMPRESORA As String = String.Empty

    Public Event EventDetalleSistema_Click()
    Public Event EventObtenerVersion(ByRef strVersion As String)
    Public Event EventRutaImpresora_DoubleClick()
    Public Event EventBultosSinEtiquetasChecked(ByVal Checked As Boolean)
    Public Event EventPaletasSinEtiquetasChecked(ByVal Checked As Boolean)

    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolminToolStrip))

    Public Property MMCUSR() As String
        Get
            Return Me._MMCUSR
        End Get
        Set(ByVal value As String)
            Me._MMCUSR = value
        End Set
    End Property

    Public Property MMAPLC() As String
        Get
            Return Me._MMAPLC
        End Get
        Set(ByVal value As String)
            Me._MMAPLC = value
        End Set
    End Property


    Private _MMTVAR As String
    ''' <summary>
    ''' Tipo de Deposito
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MMTVAR() As String
        Get
            Return _MMTVAR
        End Get
        Set(ByVal value As String)
            _MMTVAR = value
        End Set
    End Property

    Private _MMCMNU As String
    Public Property MMCMNU() As String
        Get
            Return _MMCMNU
        End Get
        Set(ByVal value As String)
            _MMCMNU = value
        End Set
    End Property


    Public Property SERVIDOR() As String
        Get
            Return Me._SERVIDOR
        End Get
        Set(ByVal value As String)
            Me._SERVIDOR = value
        End Set
    End Property

    Public Property USUARIO() As String
        Get
            Return Me._USUARIO
        End Get
        Set(ByVal value As String)
            Me._USUARIO = value
        End Set
    End Property

    Public Property CLIENTE() As String
        Get
            Return Me._CLIENTE
        End Get
        Set(ByVal value As String)
            Me._CLIENTE = value
            Try
                Dim lblCliente As ToolStripStatusLabel = CType(Me.Items("lblCliente"), ToolStripStatusLabel)
                lblCliente.Text = _CLIENTE
            Catch ex As Exception
            End Try

        End Set
    End Property

    Public Property RUTA_IMPRESORA() As String
        Get
            Return Me._RUTA_IMPRESORA
        End Get
        Set(ByVal value As String)
            Me._RUTA_IMPRESORA = value
        End Set
    End Property

    Public Property DataBind() As Boolean
        Get
            Return Me._StartDataBind
        End Get
        Set(ByVal value As Boolean)
            Me._StartDataBind = value
            LoadItems()
        End Set
    End Property

    Private Sub LoadItems()
        Me.Items.Clear()

        If Me._StartDataBind = False Then
            Exit Sub
        End If

        If _AllReadyPainted = True Then
            Exit Sub
        End If

        'Cargamos los Menu con Indice Cero ( 0 ) Los Menu Base

        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.Items.Add(addlblServidor)
        Me.Items.Add(addlblDetalleServidor)
        Me.Items.Add(addlblSistema)
        Me.Items.Add(addlblDetalleSistema)
        Me.Items.Add(addlblUsuario)
        Me.Items.Add(addlblDetalleUsuario)
        Me.Items.Add(addtsbEtiqueta)
        Me.Items.Add(addlblCliente)
        Me.Items.Add(addlblImpresora)
        Me.Items.Add(addlblRutaImpresora)
        Me.Items.Add(addlblVersion)
        Me.Items.Add(addlblDetalleVersion)
   
        Me.Location = New System.Drawing.Point(0, 627)
        Me.Name = "ssMenuInformativo"
        Me.Size = New System.Drawing.Size(982, 29)

        Me.Visible = True
    End Sub
 

    Private Function addlblVersion() As System.Windows.Forms.ToolStripStatusLabel


        Dim lblServidor As New System.Windows.Forms.ToolStripStatusLabel
        lblServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'lblServidor.Image = CType(resources.GetObject("lblServidor.Image"), System.Drawing.Image)
        lblServidor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        lblServidor.Name = "lblVersion"
        lblServidor.Size = New System.Drawing.Size(97, 24)
        lblServidor.Text = "VERSIÓN : "
        lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return lblServidor
    End Function

    Private Function addlblDetalleVersion() As System.Windows.Forms.ToolStripStatusLabel
        Dim strVersion As String = String.Empty
        RaiseEvent EventObtenerVersion(strVersion)
        Dim lblDetalleVersion As New System.Windows.Forms.ToolStripStatusLabel
        lblDetalleVersion.AutoSize = False
        lblDetalleVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        lblDetalleVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblDetalleVersion.ForeColor = System.Drawing.Color.Maroon
        lblDetalleVersion.Name = "lblDetalleServidor"
        lblDetalleVersion.Size = New System.Drawing.Size(110, 24)
        lblDetalleVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' Indentificando el Servidor
        lblDetalleVersion.Text = strVersion
        Return lblDetalleVersion
    End Function

    Private Function addlblServidor() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblServidor As New System.Windows.Forms.ToolStripStatusLabel
        lblServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        lblServidor.Image = CType(resources.GetObject("lblServidor.Image"), System.Drawing.Image)
        lblServidor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        lblServidor.Name = "lblServidor"
        lblServidor.Size = New System.Drawing.Size(97, 24)
        lblServidor.Text = "SERVIDOR : "
        lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return lblServidor
    End Function

    Private Function addlblDetalleServidor() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblDetalleServidor As New System.Windows.Forms.ToolStripStatusLabel
        lblDetalleServidor.AutoSize = False
        lblDetalleServidor.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        lblDetalleServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblDetalleServidor.ForeColor = System.Drawing.Color.Maroon
        lblDetalleServidor.Name = "lblDetalleServidor"
        lblDetalleServidor.Size = New System.Drawing.Size(110, 24)
        lblDetalleServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' Indentificando el Servidor
        lblDetalleServidor.Text = _SERVIDOR
        Return lblDetalleServidor
    End Function

    Private Function addlblSistema() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblSistema As New System.Windows.Forms.ToolStripStatusLabel
        lblSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        lblSistema.Image = CType(resources.GetObject("lblSistema.Image"), System.Drawing.Image)
        lblSistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        lblSistema.Name = "lblSistema"
        lblSistema.Size = New System.Drawing.Size(88, 24)
        lblSistema.Text = "SISTEMA : "
        lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return lblSistema
    End Function

    Private Sub StatisStrip_Click(ByVal sender As Object, ByVal e As EventArgs)
        If (CType(Me.Parent, Form).ActiveMdiChild IsNot Nothing) Then
            MessageBox.Show("Debe cerrar todas las ventanas.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim senderMenuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Dim lblDetalleSistema As ToolStripDropDownButton = CType(Me.Items("lblDetalleSistema"), ToolStripDropDownButton)
        For Each MenuItem As ToolStripItem In lblDetalleSistema.DropDownItems
            Dim tsmi As ToolStripMenuItem = DirectCast(MenuItem, ToolStripMenuItem)
            tsmi.Checked = False
            If tsmi.Name = senderMenuItem.Name Then
                lblDetalleSistema.Text = tsmi.Text
                tsmi.Checked = True
                MMCMNU = tsmi.Name
                _MMTVAR = tsmi.Tag
            End If
        Next
        ' Carga del Menu       
        RaiseEvent EventDetalleSistema_Click()
    End Sub

    Private Function addtsmi(ByVal row As DataRow) As System.Windows.Forms.ToolStripMenuItem
        Dim tsmi As New System.Windows.Forms.ToolStripMenuItem
        tsmi.ForeColor = System.Drawing.Color.Maroon
        tsmi.Name = row.Item("MMCMIN").ToString()
        tsmi.Text = row.Item("MMDOPC").ToString()
        tsmi.Tag = row.Item("MMTVAR").ToString()
        tsmi.Size = New System.Drawing.Size(246, 22)
        AddHandler tsmi.Click, AddressOf StatisStrip_Click
        Return tsmi
    End Function

    Private Function addlblDetalleSistema() As System.Windows.Forms.ToolStripDropDownButton
        Dim lblDetalleSistema As New System.Windows.Forms.ToolStripDropDownButton

        '''''
        Dim objStatusBuilder As New SolminStatusBuilder
        Dim dtbStatus As New DataTable
        'Leyendo el nombre del sistema actual 
        Me._System = objStatusBuilder.getAppSetting("System")
        Me._System_prefix = MMAPLC 'objStatusBuilder.getAppSetting("_System_prefix")
        MainModule.USUARIO = ConfigurationWizard.UserName
        'Lista de Menus Padres
        dtbStatus = objStatusBuilder.Listar_Aplicacion_X_Usuario(_MMAPLC, _MMCUSR)
        For Each row As DataRow In dtbStatus.Rows
            lblDetalleSistema.DropDownItems.Add(addtsmi(row))
        Next

        'Dim MenuItem As ToolStripMenuItem = DirectCast(lblDetalleSistema.DropDownItems.Item(0), ToolStripMenuItem)
        For Each MenuItem As ToolStripMenuItem In lblDetalleSistema.DropDownItems
            If _MMCMNU = MenuItem.Name Then
                lblDetalleSistema.Text = MenuItem.Text
                _MMCMNU = MenuItem.Name
                _MMTVAR = MenuItem.Tag
                MenuItem.Checked = True
            End If
        Next
        '''''
        lblDetalleSistema.AutoSize = False
        lblDetalleSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblDetalleSistema.ForeColor = System.Drawing.Color.Maroon
        lblDetalleSistema.Name = "lblDetalleSistema"
        lblDetalleSistema.Size = New System.Drawing.Size(150, 27)
        lblDetalleSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblDetalleSistema.ToolTipText = "Seleccionar Sistema de Trabajo"
        Return lblDetalleSistema
    End Function

    Private Function addlblUsuario() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblUsuario As New System.Windows.Forms.ToolStripStatusLabel
        lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        lblUsuario.Image = CType(resources.GetObject("lblUsuario.Image"), System.Drawing.Image)
        lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New System.Drawing.Size(90, 24)
        lblUsuario.Text = "USUARIO : "
        lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return lblUsuario
    End Function

    Private Function addlblDetalleUsuario() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblDetalleUsuario As New System.Windows.Forms.ToolStripStatusLabel
        lblDetalleUsuario.AutoSize = False
        lblDetalleUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        lblDetalleUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblDetalleUsuario.ForeColor = System.Drawing.Color.Maroon
        lblDetalleUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblDetalleUsuario.Name = "lblDetalleUsuario"
        lblDetalleUsuario.Size = New System.Drawing.Size(80, 24)
        lblDetalleUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' Indentificando el Usuario
        lblDetalleUsuario.Text = _USUARIO
        Return lblDetalleUsuario

    End Function

    Private Function addtsbEtiqueta() As System.Windows.Forms.ToolStripDropDownButton
        Dim tsbEtiqueta As New System.Windows.Forms.ToolStripDropDownButton
        tsbEtiqueta.DropDownItems.Add(addtsmiMostrarBultosSinEtiquetas())
        tsbEtiqueta.DropDownItems.Add(addtsmiMostrarPaletasSinEtiquetas())
        tsbEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        tsbEtiqueta.ForeColor = System.Drawing.Color.Blue
        tsbEtiqueta.Image = CType(resources.GetObject("tsbEtiqueta.Image"), System.Drawing.Image)
        tsbEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta
        tsbEtiqueta.Name = "tsbEtiqueta"
        tsbEtiqueta.Size = New System.Drawing.Size(95, 27)
        tsbEtiqueta.Text = "ETIQUETAS"
        tsbEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return tsbEtiqueta
    End Function

    Private Function addtsmiMostrarBultosSinEtiquetas() As System.Windows.Forms.ToolStripMenuItem
        Dim tsmiMostrarBultosSinEtiquetas As New System.Windows.Forms.ToolStripMenuItem
        tsmiMostrarBultosSinEtiquetas.CheckOnClick = True
        tsmiMostrarBultosSinEtiquetas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tsmiMostrarBultosSinEtiquetas.ForeColor = System.Drawing.Color.Blue
        tsmiMostrarBultosSinEtiquetas.Name = "tsmiMostrarBultosSinEtiquetas"
        tsmiMostrarBultosSinEtiquetas.Size = New System.Drawing.Size(237, 22)
        tsmiMostrarBultosSinEtiquetas.Text = "Mostrar Bultos Sin Etiquetas"
        AddHandler tsmiMostrarBultosSinEtiquetas.Click, AddressOf MostrarBultosSinEtiquetas_Click
        Return tsmiMostrarBultosSinEtiquetas
    End Function

    Private Sub MostrarBultosSinEtiquetas_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tsbEtiqueta As ToolStripDropDownButton = CType(Me.Items("tsbEtiqueta"), ToolStripDropDownButton)
        Dim tsmiMostrarBultosSinEtiquetas As ToolStripMenuItem = CType(tsbEtiqueta.DropDownItems("tsmiMostrarBultosSinEtiquetas"), ToolStripMenuItem)
        RaiseEvent EventBultosSinEtiquetasChecked(tsmiMostrarBultosSinEtiquetas.Checked)
    End Sub

    Public Function addtsmiMostrarPaletasSinEtiquetas() As System.Windows.Forms.ToolStripMenuItem
        Dim tsmiMostrarPaletasSinEtiquetas As New System.Windows.Forms.ToolStripMenuItem
        tsmiMostrarPaletasSinEtiquetas.CheckOnClick = True
        tsmiMostrarPaletasSinEtiquetas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        tsmiMostrarPaletasSinEtiquetas.ForeColor = System.Drawing.Color.Blue
        tsmiMostrarPaletasSinEtiquetas.Name = "tsmiMostrarPaletasSinEtiquetas"
        tsmiMostrarPaletasSinEtiquetas.Size = New System.Drawing.Size(237, 22)
        tsmiMostrarPaletasSinEtiquetas.Text = "Mostrar Paletas Sin Etiquetas"
        AddHandler tsmiMostrarPaletasSinEtiquetas.Click, AddressOf MostrarPaletasSinEtiquetas_Click
        Return tsmiMostrarPaletasSinEtiquetas
    End Function

    Private Sub MostrarPaletasSinEtiquetas_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tsbEtiqueta As ToolStripDropDownButton = CType(Me.Items("tsbEtiqueta"), ToolStripDropDownButton)
        Dim tsmiMostrarPaletasSinEtiquetas As ToolStripMenuItem = CType(tsbEtiqueta.DropDownItems("tsmiMostrarPaletasSinEtiquetas"), ToolStripMenuItem)
        RaiseEvent EventPaletasSinEtiquetasChecked(tsmiMostrarPaletasSinEtiquetas.Checked)
    End Sub

    Private Function addlblCliente() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblCliente As New System.Windows.Forms.ToolStripStatusLabel
        lblCliente.AutoSize = False
        lblCliente.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                   Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblCliente.ForeColor = System.Drawing.Color.Maroon
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New System.Drawing.Size(45, 24)
        lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblCliente.ToolTipText = "Cliente en Proceso de Almacén"
        Return lblCliente
    End Function

    Private Function addlblImpresora() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblImpresora As New System.Windows.Forms.ToolStripStatusLabel
        lblImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        lblImpresora.Image = CType(resources.GetObject("lblImpresora.Image"), System.Drawing.Image)
        lblImpresora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblImpresora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        lblImpresora.Name = "lblImpresora"
        lblImpresora.Size = New System.Drawing.Size(106, 24)
        lblImpresora.Text = "IMPRESORA : "
        lblImpresora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Return lblImpresora
    End Function

    Private Function addlblRutaImpresora() As System.Windows.Forms.ToolStripStatusLabel
        Dim lblRutaImpresora As New System.Windows.Forms.ToolStripStatusLabel
        lblRutaImpresora.AutoSize = False
        lblRutaImpresora.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        lblRutaImpresora.DoubleClickEnabled = True
        lblRutaImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        lblRutaImpresora.ForeColor = System.Drawing.Color.Maroon
        lblRutaImpresora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblRutaImpresora.Name = "lblRutaImpresora"
        lblRutaImpresora.Size = New System.Drawing.Size(106, 24)
        lblRutaImpresora.Spring = True
        lblRutaImpresora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblRutaImpresora.ToolTipText = "Impresora Seleccionada [Default LPT1]"
        ' Cargamos la inpresora por defecto registrada en el Control
        lblRutaImpresora.Text = GetDefaultPrinterName()
        _RUTA_IMPRESORA = lblRutaImpresora.Text
        ' Realizamos la presentación de la información que puede volver a ser cargada
        AddHandler lblRutaImpresora.DoubleClick, AddressOf lblRutaImpresora_DoubleClick
        Return lblRutaImpresora
    End Function

    Private Sub lblRutaImpresora_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent EventRutaImpresora_DoubleClick()
    End Sub

    Private Function GetDefaultPrinterName() As String
        Dim pd As PrintDocument = New PrintDocument
        Dim sTempDefaultPrinter As String = pd.PrinterSettings.PrinterName
        Return sTempDefaultPrinter
    End Function


   

End Class
