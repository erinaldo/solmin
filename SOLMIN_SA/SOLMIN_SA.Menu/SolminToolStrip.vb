Imports System.Windows.Forms.Control.ControlCollection
Imports System.Reflection
Imports System.Xml
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class SolminToolStrip
    Inherits ToolStrip

    Private _StartDataBind As Boolean = False
    Private _AllReadyPainted As Boolean = False
    Private _System As String = ""
    Private _MMAPLC As String = String.Empty
    Private _MMCUSR As String = String.Empty

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

    Private Sub LoadItems()
        Me.Items.Clear()

        If Me._StartDataBind = False Then
            Exit Sub
        End If

        If _AllReadyPainted = True Then
            Exit Sub
        End If

        'Cargamos los Menu con Indice Cero ( 0 ) Los Menu Base

        Dim objToolBuilder As New SolminToolBuilder
        Dim dtbTool As New DataTable

        'Leyendo el nombre del sistema actual 
        Me._System = objToolBuilder.getAppSetting("System")
        MainModule.USUARIO = ConfigurationWizard.UserName

        'Lista de Menus Padres
        dtbTool = objToolBuilder.Listar_Aplicacion_X_Usuario_Tool(MMAPLC, MMCUSR, _MMCMNU)

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolminToolStrip))

        For Each row As DataRow In dtbTool.Rows
            Dim tsb As New ToolStripButton
            If row.Item("URLIMG").ToString().Trim <> String.Empty Then
                Dim data As Object = resources.GetObject(row.Item("URLIMG").ToString().Trim)
                Dim Image As System.Drawing.Image = Nothing
                If data IsNot Nothing Then
                    Image = CType(data, System.Drawing.Image)

                    Dim oImage As System.Drawing.Image = Image
                    Dim oNewImage As System.Drawing.Image

                    Dim bmp As Bitmap = New Bitmap(oImage)
                    oImage.Dispose()
                    oNewImage = bmp.GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)

                    tsb.Image = oNewImage
                    tsb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                    tsb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
                    tsb.ImageTransparentColor = System.Drawing.Color.Magenta
                    tsb.Size = New System.Drawing.Size(78, 28)
                End If
            End If
            tsb.Name = row.Item("MMNPVB").ToString().Trim
            tsb.Tag = row.Item("MMNPVB").ToString().Trim
            tsb.Text = row.Item("MMDOPC").ToString().Trim
            tsb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            tsb.ToolTipText = row.Item("MMDOPC").ToString().Trim
            AddHandler tsb.Click, AddressOf ToolStrip_Click
            Me.Items.Add(tsb)
            Me.Items.Add(addSeparator)
        Next
        'Agregando el botones
        addCerrar()
        addCerrarTodo()
        addSalir()
        Me.Visible = True
        'Me.MdiWindowListItem = _mnuVentanas
    End Sub

    Private Sub addCerrar()
        'tsbCerrar
        Dim tsbCerrar As New ToolStripButton
        tsbCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        tsbCerrar.Image = My.Resources.tsbCerrar_Image
        tsbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        tsbCerrar.Name = "tsbCerrar"
        tsbCerrar.Size = New System.Drawing.Size(28, 28)
        tsbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        AddHandler tsbCerrar.Click, AddressOf tsbCerrar_Click

        Me.Items.Add(tsbCerrar)
        Me.Items.Add(addSeparator)
    End Sub
    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call pCerrarVentanaActiva()
    End Sub
    Private Sub pCerrarVentanaActiva()
        If (CType(Me.Parent, Form).ActiveMdiChild IsNot Nothing) Then
            CType(Me.Parent, Form).ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub addCerrarTodo()
        'tsbCerrarTodo
        '
        Dim tsbCerrarTodo As New ToolStripButton
        tsbCerrarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        tsbCerrarTodo.Image = My.Resources.tsbCerrarTodo_Image
        tsbCerrarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        tsbCerrarTodo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        tsbCerrarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        tsbCerrarTodo.Name = "tsbCerrarTodo"
        tsbCerrarTodo.Size = New System.Drawing.Size(28, 28)
        tsbCerrarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        AddHandler tsbCerrarTodo.Click, AddressOf tsbCerrarTodo_Click

        Me.Items.Add(tsbCerrarTodo)
        Me.Items.Add(addSeparator)
    End Sub
    Private Sub tsbCerrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call pCerrarVentanas()
    End Sub
    Private Sub pCerrarVentanas()
        While CType(Me.Parent, Form).ActiveMdiChild IsNot Nothing
            CType(Me.Parent, Form).ActiveMdiChild.Close()
        End While
    End Sub

    Private Sub addSalir()
        'tsbSalir
        '
        Dim tsbSalir As New ToolStripButton
        tsbSalir.Image = My.Resources.tsbSalir_Image
        tsbSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        tsbSalir.Name = "tsbSalir"
        tsbSalir.Size = New System.Drawing.Size(55, 28)
        tsbSalir.Text = "Salir"
        tsbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        AddHandler tsbSalir.Click, AddressOf tsbSalir_Click

        Me.Items.Add(tsbSalir)
    End Sub
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(Me.Parent, Form).Close()
    End Sub

    Private Function addSeparator() As ToolStripSeparator
        Dim objSeparator As New ToolStripSeparator
        objSeparator.Size = New System.Drawing.Size(6, 31)
        Return objSeparator
    End Function

    Private Sub ToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LoadForm(_System & ".exe", _System & "." & sender.Name)
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
        objForm.WindowState = FormWindowState.Normal
        objForm.WindowState = FormWindowState.Maximized
        objForm.Show()

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

End Class
