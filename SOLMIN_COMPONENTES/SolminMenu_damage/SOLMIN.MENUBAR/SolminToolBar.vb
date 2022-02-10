Imports System.Windows.Forms.Control.ControlCollection
Imports System.Reflection
Imports System.Xml
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class SolminToolBar
  Inherits MenuStrip

  Private _StartDataBind As Boolean = False
  Private _AllReadyPainted As Boolean = False
  Private _System As String = ""
  Private _SystemPrefix As String

  'Menu de Sistema
  Private _mnuSistema As New ToolStripMenuItem
  Private _mnuVentanas As New ToolStripMenuItem

  Private _textoAcercade As String = ""

  Public Event CascadaToolStripMenuItem_Click()
  Public Event HorizontalToolStripMenuItem_Click()
  Public Event VerticalToolStripMenuItem_Click()
  Public Event CerrarVentanaActivaToolStripMenuItem_Click()
  Public Event CerrarVentanasToolStripMenuItem_Click()
  'Public Event SalirToolStripMenuItem_Click()

  Public Property AcercaDe() As String
    Get
      Return _textoAcercade
    End Get
    Set(ByVal value As String)
      _textoAcercade = value
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

    Dim mnuOpcionesUsuario As New ToolStripMenuItem
    mnuOpcionesUsuario.Text = "Permisos de Usuario"
    AddHandler mnuOpcionesUsuario.Click, AddressOf MenuOpcionesUsuario
    _mnuSistema.DropDownItems.Add(mnuOpcionesUsuario)

    _mnuSistema.DropDownItems.Add(addSeparator)

    Dim mnuAcercaDe As New ToolStripMenuItem
    mnuAcercaDe.Text = "Acerca De Solmin"
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

    'Salir.Text = "&Salir"
    'AddHandler Salir.Click, AddressOf SalirMenuItem_Click

    _mnuVentanas.Text = "Ventanas"
    _mnuVentanas.DropDownItems.Add(Cascada)
    _mnuVentanas.DropDownItems.Add(Horizontal)
    _mnuVentanas.DropDownItems.Add(Vertical)
    _mnuVentanas.DropDownItems.Add(Cerrar)
    _mnuVentanas.DropDownItems.Add(CerrarVentanas)
    ' _mnuVentanas.DropDownItems.Add(Salir)

    '_mnuVentanas.DropDownItems.Clear()
    'For i As Integer = 0 To lstr_Ventanas.Count - 1
    '  _mnuVentanas.DropDownItems.Add(lstr_Ventanas(i))
    'Next

    Return _mnuVentanas
  End Function

  Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
    MyBase.OnPaint(pe)
    'Agregue su código personalizado de dibujo aquí 
  End Sub

  Private Sub LoadItems()

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

    'Lista de Menus Padres
    dtbMenuPadre = objMenuBuilder.Listar_Menu_Aplicacion(_SystemPrefix)

    'Por cada Menu Padre, busca los menu Hijos y
    For lint_menu_padre As Integer = 0 To dtbMenuPadre.Rows.Count - 1

      'Por Cada Menu Padre Busca los Items Hijos
      Dim dtbMenuList As New DataTable

      lstr_codigo_padre = dtbMenuPadre.Rows(lint_menu_padre).Item("MMCMNU").ToString()
      lstr_nombre_padre = dtbMenuPadre.Rows(lint_menu_padre).Item("MMTMNU").ToString()

      dtbMenuList = objMenuBuilder.Listar_Menu(ConfigurationWizard.UserName, lstr_codigo_padre, _SystemPrefix)

      Dim objMenuPadre As New ToolStripMenuItem
      objMenuPadre.Name = "N" & lstr_codigo_padre.Trim
      objMenuPadre.Text = lstr_nombre_padre.Trim

      Me.Items.Add(objMenuPadre)
      Me.Items.Add(Me.addSeparator)

      For lint_menu_items As Integer = 0 To dtbMenuList.Rows.Count - 1

        lstr_nombre_form = dtbMenuList.Rows(lint_menu_items).Item("MMNPVB").ToString()
        lstr_texto_form = dtbMenuList.Rows(lint_menu_items).Item("MMDOPC").ToString()

        Dim objMenuHijo As New ToolStripMenuItem
        objMenuHijo.Name = lstr_nombre_form.Trim
        objMenuHijo.Text = lstr_texto_form.Trim
        objMenuHijo.Image = My.Resources.imagen_20

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
    RaiseEvent CascadaToolStripMenuItem_Click()
  End Sub

  Public Sub HorizontalMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent HorizontalToolStripMenuItem_Click()
  End Sub

  Public Sub VerticalMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent VerticalToolStripMenuItem_Click()
  End Sub

  Public Sub CerrarVentanaActivaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent CerrarVentanaActivaToolStripMenuItem_Click()
  End Sub

  Public Sub CerrarVentanasMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent CerrarVentanasToolStripMenuItem_Click()
  End Sub

  'Public Sub SalirMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  RaiseEvent SalirToolStripMenuItem_Click()
  'End Sub

End Class
