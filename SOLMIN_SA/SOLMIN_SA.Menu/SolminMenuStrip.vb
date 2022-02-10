Imports System.Windows.Forms.Control.ControlCollection
Imports System.Reflection
Imports System.Xml
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class SolminMenuStrip
    Inherits MenuStrip

    Private _StartDataBind As Boolean = False
    Private _AllReadyPainted As Boolean = False
    Private _System As String = ""
    Private _SystemPrefix As String
    Private _MMAPLC As String = String.Empty
    Private _MMCUSR As String = String.Empty
    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolminMenuStrip))

    'Menu de Sistema
    Private _mnuSistema As ToolStripMenuItem
    Private _mnuVentanas As ToolStripMenuItem

    Private _textoAcercade As String = ""

    Public Property AcercaDe() As String
        Get
            Return _textoAcercade
        End Get
        Set(ByVal value As String)
            _textoAcercade = value
        End Set
    End Property

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


    Private _MMCMNU As String
    Public Property MMCMNU() As String
        Get
            Return _MMCMNU
        End Get
        Set(ByVal value As String)
            _MMCMNU = value
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

    Private Function properties_MenuSistema() As ToolStripMenuItem

        _mnuSistema.Text = "Sistema"
        _mnuSistema.DropDownItems.Add(addSeparator)

        Dim mnuAcercaDe As New ToolStripMenuItem
        mnuAcercaDe.Text = "Acerca De Solmin"

        Dim data As Object = resources.GetObject("frmAcercaDe")
        If data IsNot Nothing Then
            mnuAcercaDe.Image = CType(data, System.Drawing.Image)
        End If

        AddHandler mnuAcercaDe.Click, AddressOf MenuAcercaDe
        _mnuSistema.DropDownItems.Add(mnuAcercaDe)

        Return _mnuSistema

    End Function

    Private Function Properties_MenuVentanas() As ToolStripMenuItem
        'Dim lstr_Ventanas As List(Of String) = ListadoVentanasActivas()  
        Dim Cascada As New ToolStripMenuItem
        Dim Horizontal As New ToolStripMenuItem
        Dim Vertical As New ToolStripMenuItem
        Dim Cerrar As New ToolStripMenuItem
        Dim CerrarVentanas As New ToolStripMenuItem
        Dim Salir As New ToolStripMenuItem

        Cascada.Text = "&Cascada"
        Cascada.Image = My.Resources.ToolStripMenuItem25_Image
        AddHandler Cascada.Click, AddressOf CascadaMenuItem_Click

        Horizontal.Text = "&Horizontal"
        Horizontal.Image = My.Resources.ToolStripMenuItem26_Image
        AddHandler Horizontal.Click, AddressOf HorizontalMenuItem_Click

        Vertical.Text = "&Vertical"
        Vertical.Image = My.Resources.ToolStripMenuItem27_Image
        AddHandler Vertical.Click, AddressOf VerticalMenuItem_Click

        Cerrar.Text = "C&errar"
        Cerrar.Image = My.Resources.ToolStripButton12_Image
        AddHandler Cerrar.Click, AddressOf CerrarVentanaActivaMenuItem_Click

        CerrarVentanas.Text = "Cerrar &Todos"
        CerrarVentanas.Image = My.Resources.ToolStripButton13_Image
        AddHandler CerrarVentanas.Click, AddressOf CerrarVentanasMenuItem_Click

        _mnuVentanas.Text = "Ventanas"
        _mnuVentanas.DropDownItems.Add(Cascada)
        _mnuVentanas.DropDownItems.Add(Horizontal)
        _mnuVentanas.DropDownItems.Add(Vertical)
        _mnuVentanas.DropDownItems.Add(Cerrar)
        _mnuVentanas.DropDownItems.Add(CerrarVentanas)

        Return _mnuVentanas
    End Function

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(pe)
        'Agregue su código personalizado de dibujo aquí 
    End Sub

    Private Sub LoadItems()
        Me.Items.Clear()
        _mnuSistema = New ToolStripMenuItem
        _mnuVentanas = New ToolStripMenuItem

        If Me._StartDataBind = False Then
            Exit Sub
        End If

        If _AllReadyPainted = True Then
            Exit Sub
        End If

        'Cargamos los Menu con Indice Cero ( 0 ) Los Menu Base

        Dim objMenuBuilder As New SolminMenuBuilder
        Dim dtbMenuPadre As New DataTable

        'Leyendo el nombre del sistema actual 
        Me._System = objMenuBuilder.getAppSetting("System")
        Me._SystemPrefix = objMenuBuilder.getAppSetting("System_prefix")
        MainModule.USUARIO = ConfigurationWizard.UserName

        Dim lstr_codigo_padre As String = "0"
        Dim lstr_nombre_padre As String = ""
        Dim lstr_nombre_form As String = ""
        Dim lstr_texto_form As String = ""
        Dim lstr_Imagen_form As String = ""



        'Lista de Menus Padres
        dtbMenuPadre = objMenuBuilder.Listar_Menu_Aplicacion_Raiz(MMCUSR, MMAPLC, MMCMNU)

        'Por cada Menu Padre, busca los menu Hijos y
        For lint_menu_padre As Integer = 0 To dtbMenuPadre.Rows.Count - 1

            'Por Cada Menu Padre Busca los Items Hijos
            Dim dtbMenuList As New DataTable

            lstr_codigo_padre = dtbMenuPadre.Rows(lint_menu_padre).Item("MMCMIN").ToString()
            lstr_nombre_padre = dtbMenuPadre.Rows(lint_menu_padre).Item("MMDOPC").ToString()

            dtbMenuList = objMenuBuilder.Listar_Menu(ConfigurationWizard.UserName, lstr_codigo_padre, MMAPLC)

            Dim objMenuPadre As New ToolStripMenuItem
            objMenuPadre.Name = "N" & lstr_codigo_padre.Trim
            objMenuPadre.Text = lstr_nombre_padre.Trim

            Me.Items.Add(objMenuPadre)
            Me.Items.Add(Me.addSeparator)

            For lint_menu_items As Integer = 0 To dtbMenuList.Rows.Count - 1

                lstr_nombre_form = dtbMenuList.Rows(lint_menu_items).Item("MMNPVB").ToString()
                lstr_texto_form = dtbMenuList.Rows(lint_menu_items).Item("MMDOPC").ToString()
                lstr_Imagen_form = dtbMenuList.Rows(lint_menu_items).Item("URLIMG").ToString()

                Dim objMenuHijo As New ToolStripMenuItem
                objMenuHijo.Name = lstr_nombre_form.Trim
                objMenuHijo.Text = lstr_texto_form.Trim

                Dim data As Object = resources.GetObject(lstr_Imagen_form.Trim)
                If data IsNot Nothing Then
                    objMenuHijo.Image = CType(data, System.Drawing.Image)
                End If

                objMenuHijo.PerformClick()

                AddHandler objMenuHijo.Click, AddressOf MenuClick

                'Agregamos los Menu hijos a la lista
                objMenuPadre.DropDownItems.Add(objMenuHijo)
                objMenuPadre.DropDownItems.Add(addSeparator)
            Next
        Next

        'Agregando el Menu Ventana del toolBar
        Me._mnuVentanas = Properties_MenuVentanas()
        'AddHandler _mnuVentanas.Click, AddressOf MenuVentana
        Me.Items.Add(_mnuVentanas)

        Me.Items.Add(Me.addSeparator)

        'Agregando Menues Fijos
        Me._mnuSistema = properties_MenuSistema()
        Me.Items.Add(_mnuSistema)

        Me.Items.Add(Me.addSeparator)

        'Agregando el menu Salir al MenuBar
        Dim objMenuSalir As New ToolStripMenuItem
        objMenuSalir.Text = "Salir"
        AddHandler objMenuSalir.Click, AddressOf MenuSalir
        Me.Items.Add(objMenuSalir)
        Me.MdiWindowListItem = _mnuVentanas
    End Sub

    Public Sub MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LoadForm(_System & ".exe", _System & "." & sender.Name)
    End Sub

    Private Function addSeparator() As ToolStripSeparator
        Dim objSeparator As New ToolStripSeparator
        Return objSeparator
    End Function

    Public Sub MenuSalir(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(Me.Parent, Form).Close()
    End Sub

    Public Sub MenuAcercaDe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objfrmAcercaDe As New frmAcercaDe
        objfrmAcercaDe.ShowForm(Me._textoAcercade, Me.Parent)
    End Sub

    Public Sub MenuOpcionesUsuario(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objfrmPermisosUsuario As New frmPermisosUsuario
        objfrmPermisosUsuario.ShowDialog(CType(Me.Parent, Form))
    End Sub

    Public Sub MenuVentana(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Existe_Ventana(CType(sender, ToolStripMenuItem).Text)
    End Sub

    Private Sub LoadForm(ByVal exeAppDomain As String, ByVal FormName As String)

        Dim objAssembly As Assembly = Assembly.LoadFile(Application.StartupPath & "\" & exeAppDomain)
        Dim objForm As Form = objAssembly.CreateInstance(FormName)

        'Verificando que la instancia no exista para poder levantarla
        If Existe_Ventana(objForm.Name) = True Then
            Exit Sub
        End If

        objForm.MdiParent = MyBase.Parent
        objForm.Opacity = 0
        objForm.WindowState = FormWindowState.Maximized
        objForm.Show()
        'Me._mnuVentanas = Properties_MenuVentanas()
    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To CType(Me.Parent, Form).MdiChildren.Length - 1
            If CType(Me.Parent, Form).MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                CType(Me.Parent, Form).MdiChildren(intCont).WindowState = FormWindowState.Maximized
                CType(Me.Parent, Form).MdiChildren(intCont).Show()
                Return True
            End If
        Next intCont

        Return False
    End Function

    Private Function ListadoVentanasActivas() As List(Of String)

        Dim lstr_ListaVentanas As New List(Of String)

        For intCont As Integer = 0 To CType(Me.Parent, Form).MdiChildren.Length - 1
            lstr_ListaVentanas.Add(CType(Me.Parent, Form).MdiChildren(intCont).Name)
        Next intCont

        Return lstr_ListaVentanas
    End Function

    Private Sub CascadaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(Me.Parent, Form).LayoutMdi(MdiLayout.Cascade)
    End Sub

    Public Sub HorizontalMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(Me.Parent, Form).LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Public Sub VerticalMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(Me.Parent, Form).LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Public Sub CerrarVentanaActivaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (CType(Me.Parent, Form).ActiveMdiChild IsNot Nothing) Then
            CType(Me.Parent, Form).ActiveMdiChild.Close()
        End If
    End Sub

    Public Sub CerrarVentanasMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        While CType(Me.Parent, Form).ActiveMdiChild IsNot Nothing
            CType(Me.Parent, Form).ActiveMdiChild.Close()
        End While
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
