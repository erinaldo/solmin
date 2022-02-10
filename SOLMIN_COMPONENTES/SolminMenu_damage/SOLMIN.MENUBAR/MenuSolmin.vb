Imports System.Reflection
Imports System.Xml
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class MenuSolmin

  Private _TamanoActual As Integer = 250
  Private _Collapsed As Boolean = False
  Private _MenuVisibleState As Boolean = False
  Private _ElementosFavoritos As New DataTable
  Private _StartDataBind As Boolean = False
  Private _AllReadyPainted As Boolean = False
  Private _System As String
  Private _SystemPrefix As String
  Private _formsloaded As New List(Of Form)
  '---------------------------------------------------------------------------------------
  Private _ObjAccesoDirectoBL As New Acceso_Directo_BL
  Private _ObjOpcionBE As New OpcionBE
  Private _ListaOpcion As New List(Of OpcionBE)
  Private _ListaAccesoDirecto As New List(Of Acceso_DirectoBE)
  Private _matchOpcion As New Predicate(Of OpcionBE)(AddressOf Buscar_Opciones_X_Menu_Aplicacion)
  Private _matchAcceso As New Predicate(Of Acceso_DirectoBE)(AddressOf Buscar_Acceso_Directo)
  Private _matchContador As New Predicate(Of Acceso_DirectoBE)(AddressOf Buscar_Acceso_Activo)

  Public Property ImageBind() As ImageList
    Get
      Return Me.NodeMenu.ImageList
    End Get
    Set(ByVal value As ImageList)
      Me.NodeMenu.ImageList = value
    End Set
  End Property

  Public Property DataBind() As Boolean

    Get
      Return Me._StartDataBind
    End Get
    Set(ByVal value As Boolean)
      Me._StartDataBind = value
      LoadMenu()
    End Set

  End Property

  Public Function LoginExists() As Boolean
    Return ConfigurationWizard.ConnectionFileExists() And ConfigurationWizard.LoginFileExists()
  End Function

  Public Property MenuVisibleState() As Boolean

    Get
      Return Me._MenuVisibleState
    End Get
    Set(ByVal value As Boolean)
      Me._MenuVisibleState = value
      Me.MenuVisibleStateChanger()
    End Set

  End Property

  Private Sub MenuVisibleStateChanger()

    If Me._MenuVisibleState = True Then
      Me.Width = 20
    Else
      Me.Width = 250
    End If

  End Sub

  Public Property TituloMenu() As String
    Get
      Return Me.HGSolminBar.Values.Heading
    End Get
    Set(ByVal value As String)
      Me.HGSolminBar.Values.Heading = value
    End Set
  End Property

  Public Property DescripcionMenu() As String
    Get
      Return Me.HGSolminBar.Values.Description
    End Get
    Set(ByVal value As String)
      Me.HGSolminBar.Values.Description = value
    End Set
  End Property

  Private Sub LoadForm(ByVal exeAppDomain As String, ByVal FormName As String)
    Try
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

    Catch ex As Exception

    End Try

  End Sub

  Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
    Dim intCont As Integer

    For intCont = 0 To Me.ParentForm.MdiChildren.Length - 1
      If Me.ParentForm.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
        Me.ParentForm.MdiChildren(intCont).WindowState = FormWindowState.Maximized
        Me.ParentForm.MdiChildren(intCont).Show()
        Return True
      End If
    Next intCont

    Return False
  End Function

  Private Sub btnCollapse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    MenuVisibleState = Not MenuVisibleState
  End Sub

  Private Sub LoadMenu()

    If _StartDataBind = False Then Exit Sub
    If _AllReadyPainted = True Then Exit Sub

    Dim objMenuBuilder As New SolminMenuBuilder
    Dim dtbMenuPadre As New DataTable

    Cargar_Lista()

    'Leyendo el nombre del sistema actual
    Me._System = objMenuBuilder.getAppSetting("System")
    Me._SystemPrefix = objMenuBuilder.getAppSetting("System_prefix")
    MainModule.USUARIO = ConfigurationWizard.UserName

    'Agrega Menu Raiz
    Me.NodeMenu.Nodes.Add("SOLMIN", "SOLMIN", 1)

    'Cargamos los Menu con Indice Cero ( 0 ) Los Menu Base 
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
      'Lista de Menu Hijos
      Dim lobj_OpcionBL As New Opcion_BL
      Dim lobj_OpcionBE As New OpcionBE
      lobj_OpcionBE.MMCAPL = _SystemPrefix
      lobj_OpcionBE.MMCMNU = lstr_codigo_padre
      For Each objBE As OpcionBE In lobj_OpcionBL.Lista_Opcion(lobj_OpcionBE)
        Me._ListaOpcion.Add(objBE)
      Next
      'Agregamos al Menu Padre a la Lista
      Me.NodeMenu.Nodes(0).Nodes.Add("Nx" & lstr_codigo_padre.Trim, lstr_nombre_padre.Trim, 0, 0)

      For lint_menu_items As Integer = 0 To dtbMenuList.Rows.Count - 1

        lstr_nombre_form = dtbMenuList.Rows(lint_menu_items).Item("MMNPVB").ToString()
        lstr_texto_form = dtbMenuList.Rows(lint_menu_items).Item("MMDOPC").ToString()

        'Agregamos los Menu hijos a la lista
        Me.NodeMenu.Nodes(0).Nodes("Nx" & lstr_codigo_padre).Nodes.Add(lstr_nombre_form.Trim, lstr_texto_form.Trim, 1, 1)

      Next

    Next

    'Propiedad para expandir los nodos
        'Me.NodeMenu.ExpandAll()
        Me.NodeMenu.Nodes(0).Expand()

    'Listando los Favoritos 

    _AllReadyPainted = True

    'Crear Button
    EliminarButton()
    CrearButton()

  End Sub

  Private Sub NodeMenu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NodeMenu.DoubleClick

    If (NodeMenu.SelectedNode Is Nothing) OrElse (NodeMenu.SelectedNode.Name = "SOLMIN") Then Exit Sub
    If NodeMenu.SelectedNode.Name.StartsWith("Nx") = True Then Exit Sub

    'Registrando en el log de eventos los formularios accesados por usuario
    Try
      Dim objMenuBuilder As New SolminMenuBuilder
      objMenuBuilder.Registrar_Log_Usuario(ConfigurationWizard.UserName, Me._SystemPrefix, NodeMenu.SelectedNode.Name)
    Catch : End Try

    Me.Cursor = Cursors.WaitCursor
    Me.Cursor.Tag = "Cargando Aplicacion"

    'Lanzando el formulario
    Me.LoadForm(_System & ".exe", _System & "." & NodeMenu.SelectedNode.Name)

    Me.Cursor = Cursors.Arrow
    Me.Cursor.Tag = ""

    'Colapsando el menu
    btnwindowSize_Click(sender, New EventArgs)

  End Sub

  Private Sub btnwindowSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwindowSize.Click

    _Collapsed = Not _Collapsed

    If _Collapsed = True Then
      Me.Width = 20
      Me.HGSolminBar.ButtonSpecs(0).Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight
    Else
      Me.Width = _TamanoActual
      Me.HGSolminBar.ButtonSpecs(0).Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
    End If

    MyBase.Parent.Refresh()

  End Sub

  Private Sub MenuSolmin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If _StartDataBind = False Then Exit Sub
    If _AllReadyPainted = True Then Exit Sub

    MainModule.USUARIO = ConfigurationWizard.UserName

  End Sub

  'Private Sub OpcionesPorUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  'End Sub

  'Private Sub NodeMenu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles NodeMenu.AfterSelect
  'End Sub

  Private Sub AgregarComoFavoritoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarComoFavoritoToolStripMenuItem.Click

    If Me.NodeMenu.Nodes(0).ToString.Trim.Substring(10, Me.NodeMenu.Nodes(0).ToString.Trim.Length - 10) <> Me.NodeMenu.SelectedNode.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.ToString.Trim.Length - 10) Then
      If Me.NodeMenu.Nodes(0).ToString.Trim.Substring(10, Me.NodeMenu.Nodes(0).ToString.Trim.Length - 10) <> Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Length - 10) Then
        Me._ObjOpcionBE = Me._ListaOpcion.Find(_matchOpcion)
        Dim lobj_Acceso As Acceso_DirectoBE = Me._ListaAccesoDirecto.Find(_matchAcceso)
        Asignar_Valor(lobj_Acceso, 0)
      Else
      End If
    Else
    End If

  End Sub

  Private Function Buscar_Opciones_X_Menu_Aplicacion(ByVal objBE As OpcionBE) As Boolean
    If (objBE.MMCAPL.Trim.ToUpper = Me._SystemPrefix.Trim.ToUpper) And (objBE.MMTMNU.Trim.ToUpper = Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Length - 10).ToUpper) And (objBE.MMDOPC.Trim.ToUpper = Me.NodeMenu.SelectedNode.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.ToString.Trim.Length - 10).ToUpper) Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Function Buscar_Acceso_Directo(ByVal objBE As Acceso_DirectoBE) As Boolean
    If (objBE.MMCAPL.Trim.ToUpper = Me._ObjOpcionBE.MMCAPL.Trim.ToUpper) And (objBE.MMCMNU.Trim.ToUpper = Me._ObjOpcionBE.MMCMNU.Trim.ToUpper) And (objBE.MMCOPC.Trim.ToUpper = Me._ObjOpcionBE.MMCOPC.Trim.ToUpper) Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Function Buscar_Acceso_Activo(ByVal objBE As Acceso_DirectoBE) As Boolean
    If (objBE.MMCAPL.Trim.ToUpper = Me._ObjOpcionBE.MMCAPL.Trim.ToUpper) And (objBE.SESTRG.Trim.ToUpper = "A") Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub EliminarComoFavoritoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarComoFavoritoToolStripMenuItem.Click
    If Me.NodeMenu.Nodes(0).ToString.Trim.Substring(10, Me.NodeMenu.Nodes(0).ToString.Trim.Length - 10) <> Me.NodeMenu.SelectedNode.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.ToString.Trim.Length - 10) Then
      If Me.NodeMenu.Nodes(0).ToString.Trim.Substring(10, Me.NodeMenu.Nodes(0).ToString.Trim.Length - 10) <> Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Substring(10, Me.NodeMenu.SelectedNode.Parent.ToString.Trim.Length - 10) Then
        Me._ObjOpcionBE = Me._ListaOpcion.Find(_matchOpcion)
        Dim lobj_Acceso As Acceso_DirectoBE = Me._ListaAccesoDirecto.Find(_matchAcceso)
        Asignar_Valor(lobj_Acceso, 1)
      Else
      End If
    Else
    End If
  End Sub

  Private Sub Asignar_Valor(ByVal lobj_Acceso As Acceso_DirectoBE, ByVal lint As Integer)
    Dim lint_Contador As Integer = 0
    If lint = 0 Then
      If lobj_Acceso Is Nothing Then
        Dim lobjeto As New Acceso_DirectoBE
        lobjeto.MMCUSR = MainModule.USUARIO
        lobjeto.MMCAPL = _ObjOpcionBE.MMCAPL
        lobjeto.MMCMNU = _ObjOpcionBE.MMCMNU
        lobjeto.MMCOPC = _ObjOpcionBE.MMCOPC
        lobjeto.CULUSA = MainModule.USUARIO
        lobjeto.FULTAC = HelpClass.TodayNumeric
        lobjeto.HULTAC = HelpClass.NowNumeric
        lobjeto.NTRMNL = HelpClass.NombreMaquina
        If Me._ObjAccesoDirectoBL.Registra_Acceso_Directo(lobjeto) = 1 Then
          Cargar_Lista()
          EliminarButton()
          CrearButton()
        Else
        End If
      Else
        lobj_Acceso.CULUSA = MainModule.USUARIO
        lobj_Acceso.FULTAC = HelpClass.TodayNumeric
        lobj_Acceso.HULTAC = HelpClass.NowNumeric
        lobj_Acceso.NTRMNL = HelpClass.NombreMaquina
        lint_Contador = Me._ListaAccesoDirecto.FindAll(_matchContador).Count
        If lint_Contador < 5 Then
          If lobj_Acceso.SESTRG = "A" Then
          ElseIf lobj_Acceso.SESTRG = "*" Then
            If Me._ObjAccesoDirectoBL.Activa_Acceso_Directo(lobj_Acceso) = 1 Then
              Cargar_Lista()
              EliminarButton()
              CrearButton()
            Else
            End If
          End If
        Else
        End If
      End If
    Else
      If lobj_Acceso Is Nothing Then
      Else
        lobj_Acceso.CULUSA = MainModule.USUARIO
        lobj_Acceso.FULTAC = HelpClass.TodayNumeric
        lobj_Acceso.HULTAC = HelpClass.NowNumeric
        lobj_Acceso.NTRMNL = HelpClass.NombreMaquina
        If lobj_Acceso.SESTRG = "A" Then
          If Me._ObjAccesoDirectoBL.Elimina_Acceso_Directo(lobj_Acceso) = 1 Then
            Cargar_Lista()
            EliminarButton()
            CrearButton()
          End If
        ElseIf lobj_Acceso.SESTRG = "*" Then
        End If
      End If
    End If
  End Sub

  Private Sub Cargar_Lista()
    Me._ListaAccesoDirecto = Me._ObjAccesoDirectoBL.Lista_Acceso_Directo
  End Sub

  Private Sub EliminarButton()
    For lint As Integer = Me.pnlBotones.Controls.Count - 1 To 1 Step -1
      Dim OptionButton As ComponentFactory.Krypton.Toolkit.KryptonButton = Me.pnlBotones.Controls.Item(lint)
      Me.pnlBotones.Controls.Remove(OptionButton)
    Next
  End Sub

  Private Sub CrearButton()
    Dim lint_location As Integer = 20
    Dim lint_TabIndex As Integer = 1
    Dim lobj As New List(Of Acceso_DirectoBE)

    Me._ObjOpcionBE.MMCAPL = Me._SystemPrefix
    lobj = Me._ListaAccesoDirecto.FindAll(_matchContador)
    If lobj Is Nothing Then
    Else
      Dim lcontrol As ControlCollection
      lcontrol = Me.pnlBotones.Controls
      Me.pnlBotones.Visible = True
      For Each lobjBE As Acceso_DirectoBE In lobj
        Dim OptionButton As New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pnlBotones.Controls.Add(OptionButton)
        OptionButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        OptionButton.Location = New System.Drawing.Point(0, lint_location)
        OptionButton.Name = lobjBE.MMNPVB.Trim
        OptionButton.Size = New System.Drawing.Size(252, 24)
        OptionButton.TabIndex = lint_TabIndex
        OptionButton.Text = lobjBE.MMDOPC.Trim
        OptionButton.Values.Text = lobjBE.MMDOPC.Trim
        AddHandler OptionButton.Click, AddressOf OptionButton_Click
        lint_location = lint_location + 24
        lint_TabIndex = lint_TabIndex + 1
      Next
      OcultarControles(lint_TabIndex)
    End If
  End Sub

  Private Sub OcultarControles(ByVal lint_Control As Integer)
    If lint_Control > 5 Then
    ElseIf lint_Control < 1 Then
    Else
      Dim lcontrol As ControlCollection
      Dim OptionButton As New ComponentFactory.Krypton.Toolkit.KryptonButton
      lcontrol = Me.pnlBotones.Controls
      For lint As Integer = lint_Control To lcontrol.Count - 1
        OptionButton = lcontrol.Item(lint)
        Me.pnlBotones.Controls.Remove(OptionButton)
      Next
    End If
  End Sub
  Private Sub OptionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.LoadForm(_System & ".exe", _System & "." & sender.Name)
  End Sub
End Class