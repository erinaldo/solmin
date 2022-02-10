Public Class frmSeleccionarSistema
#Region " Atributo "
    Private strTipoSistema As String
    Private strDetalleTipoSistema As String
    Private strTipoAlmacen As String

    Private _System As String = ""
    Private _System_prefix As String = ""
    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionarSistema))


#End Region

#Region " Propiedades "

    Public ReadOnly Property pstrTipoSistema() As String
        Get
            Return strTipoSistema
        End Get
    End Property

    Public ReadOnly Property pstrDetalleTipoSistema() As String
        Get
            Return strDetalleTipoSistema
        End Get
    End Property

    Public ReadOnly Property pstrTipoAlmacen()
        Get
            Return strTipoAlmacen
        End Get
    End Property

    Private _MMAPLC As String
    Public Property MMAPLC() As String
        Get
            Return _MMAPLC
        End Get
        Set(ByVal value As String)
            _MMAPLC = value
        End Set
    End Property

    Private _MMCUSR As String = String.Empty
    Public Property MMCUSR() As String
        Get
            Return Me._MMCUSR
        End Get
        Set(ByVal value As String)
            Me._MMCUSR = value
        End Set
    End Property
  

#End Region

#Region " Procedimientos y Funciones "


#End Region

#Region " Eventos "

    Private Sub pbImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strTipoSistema = sender.Tag.Item(0)
        strTipoAlmacen = sender.Tag.Item(1)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub pbImages_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Cursor = Cursors.Hand
    End Sub

    Private Sub pbImages_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.Cursor = Cursors.Default
    End Sub

#End Region

#Region " Metodos "

    Public Sub New(ByVal strAplicacion As String, ByVal strUsuario As String, ByRef bolUnico As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _MMAPLC = strAplicacion
        _MMCUSR = strUsuario
        bolUnico = CargarMenuPrincipal()
    End Sub

    Private Function CargarMenuPrincipal() As Boolean

        Dim objStatusBuilder As New Menu.SolminStatusBuilder
        Dim dtbStatus As DataTable
        'Leyendo el nombre del sistema actual 

        _System = objStatusBuilder.getAppSetting("System")
        _System_prefix = MMAPLC 'objStatusBuilder.getAppSetting("_System_prefix")
        'Lista de Menus Padres
        dtbStatus = objStatusBuilder.Listar_Aplicacion_X_Usuario(_MMAPLC, _MMCUSR)
        Dim opbImages As PictureBox
        Dim lblMenu As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Dim intXParImagen As Integer = 7
        Dim intWidth As Integer = 0
        For intCont As Integer = 0 To dtbStatus.Rows.Count - 1
            opbImages = New PictureBox
            lblMenu = New ComponentFactory.Krypton.Toolkit.KryptonLabel
            Dim data As Object = resources.GetObject(dtbStatus.Rows(intCont).Item("URLIMG").ToString.Trim)
            If data IsNot Nothing Then
                opbImages.Location = New Point(intXParImagen, 13)
                opbImages.Size = New Point(120, 130)
                opbImages.BackColor = Color.Transparent
                opbImages.Image = CType(data, System.Drawing.Image)
                opbImages.SizeMode = PictureBoxSizeMode.StretchImage
                opbImages.BorderStyle = BorderStyle.FixedSingle
                opbImages.SizeMode = PictureBoxSizeMode.StretchImage
                opbImages.BorderStyle = BorderStyle.FixedSingle
                lblMenu.Location = New Point(intXParImagen, 145)
                lblMenu.Size = New Point(124, 19)
                intXParImagen = 145 + intXParImagen
                Size = New Point(145 * (intWidth + 1), 205)
                intWidth = intWidth + 1
                lblMenu.Text = dtbStatus.Rows(intCont).Item("MMDOPC").ToString

                Dim olstrTag As New List(Of String)
                olstrTag.Add(dtbStatus.Rows(intCont).Item("MMCMIN").ToString)
                olstrTag.Add(dtbStatus.Rows(intCont).Item("MMTVAR").ToString)
                opbImages.Tag = olstrTag

                AddHandler opbImages.DoubleClick, AddressOf pbImages_Click
                AddHandler opbImages.MouseHover, AddressOf pbImages_MouseHover
                AddHandler opbImages.MouseLeave, AddressOf pbImages_MouseLeave

                KryptonPanel.Controls.Add(opbImages)
                KryptonPanel.Controls.Add(lblMenu)
            End If
        Next
        If KryptonPanel.Controls.Count = 2 Then
            strTipoSistema = KryptonPanel.Controls.Item(0).Tag.Item(0)
            strTipoAlmacen = KryptonPanel.Controls.Item(0).Tag.Item(1)
            Return True
        End If
        Return False
    End Function
#End Region

  
    Private Sub frmSeleccionarSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If KryptonPanel.Controls.Count = 2 Then
            strTipoSistema = KryptonPanel.Controls.Item(0).Tag.Item(0)
            strTipoAlmacen = KryptonPanel.Controls.Item(0).Tag.Item(1)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class
