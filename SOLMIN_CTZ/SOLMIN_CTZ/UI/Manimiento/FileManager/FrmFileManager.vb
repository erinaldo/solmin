Imports Ransa.Controls.Menu
Imports StorageFileManager
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class FrmFileManager
    Private _ValuePadre As Decimal = 0
    Private _ValueFolder As Decimal = 0
    Private _NameFolder As String = String.Empty
    Sub TreViewFileManager(ByVal odtFolder As DataTable, Optional ByVal lstr_codigo_padre As Decimal = 0, Optional ByVal nodePadre As TreeNode = Nothing)
        Dim lstr_nombre_Carpeta As String = String.Empty
        Dim lstr_Codigo As String = String.Empty
        Dim lstr_Tipo As String = String.Empty
        Dim llobj_TempOpcion As DataRow()
        Dim nuevoNodo As TreeNode
        llobj_TempOpcion = odtFolder.Select("NRSGDC =" + lstr_codigo_padre.ToString)
        If llobj_TempOpcion.Length > 0 Then
            For Each item As DataRow In llobj_TempOpcion
                lstr_Codigo = item("NMRGIM").ToString.Trim
                lstr_nombre_Carpeta = item("TDSGIM").ToString.Trim
                lstr_Tipo = item("TIPODC").ToString.Trim
                nuevoNodo = New TreeNode
                nuevoNodo.Text = lstr_nombre_Carpeta
                nuevoNodo.Tag = lstr_codigo_padre
                '  nuevoNodo.Text = String.Format("{0} - {1}", lstr_Codigo.ToString, lstr_nombre_Carpeta)
                nuevoNodo.Name = lstr_Codigo.ToString
                nuevoNodo.ImageIndex = 1
                If lstr_Tipo.Equals("FILEMANAGER") Then
                    If nodePadre Is Nothing Then
                        Me.NodeFolder.Nodes(lstr_codigo_padre.ToString).Nodes.Add(nuevoNodo)
                    Else
                        nodePadre.Nodes.Add(nuevoNodo)
                    End If
                    Me.TreViewFileManager(odtFolder, lstr_Codigo, nuevoNodo)
                End If
            Next
        End If
    End Sub

    Private Sub ListarArchivos(ByVal IdPadre As String, Optional ByVal NameFolder As String = "0", Optional ByVal pNameFile As String = "")
        Me._ValueFolder = IdPadre
        If NameFolder <> "0" Then Me._NameFolder = NameFolder
        Dim objFileManager As New clsFileManager
        Dim dtFolder As New DataSet
        'dtFolder = objFileManager.getSubFolder(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy, UcCliente.pCodigo.ToString, CInt(NodeFolder.SelectedNode.Name))
        dtFolder = objFileManager.getSubFolder("EZ", UcCliente.pCodigo.ToString, CInt(IdPadre), pNameFile)
        Dim odtCarpetas As DataTable = dtFolder.Tables(0)
        Dim odtFiles As DataTable = dtFolder.Tables(1)

        Dim llobj_Filemanager As New List(Of Filemanager_BE)
        Dim lobj_Filemanager As Filemanager_BE
        For Each Item As DataRow In odtCarpetas.Rows
            lobj_Filemanager = New Filemanager_BE
            With lobj_Filemanager
                '.ICompañia =  Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                .pIdCompañia = "EZ"
                .pIdCliente = UcCliente.pCodigo.ToString
                .pId = Item("NMRGIM")
                .pIdPadre = Item("NRSGDC")
                .pTipo = "F"
                .pNombre = Item("TDSGIM")
                .pDescripcion = Item("TDSGIM").ToString 'String.Format("{0} - {1}", Item("NMRGIM").ToString, Item("TDSGIM").ToString)
                .pTamanio = " "
                .pFechaCreacion = HelpClass.FormatoFecha(Item("FCHCRT")).ToString
            End With
            llobj_Filemanager.Add(lobj_Filemanager)
        Next
        For Each Item As DataRow In odtFiles.Rows
            lobj_Filemanager = New Filemanager_BE
            With lobj_Filemanager
                ' .ICompañia =  Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                .pIdCompañia = "EZ"
                .pIdCliente = UcCliente.pCodigo.ToString
                .pId = Item("NCRIMG")
                .pIdPadre = Item("NMRGIM")
                .pTipo = "A"
                .pNombre = Item("TNMBAR")
                .pDescripcion = Item("TDSGIM")
                .pTamanio = String.Format("{0} {1}", (System.Math.Round((CDbl(Item("QBYTIM")) / 1024), 2, MidpointRounding.AwayFromZero)).ToString, "KB")
                .pFechaCreacion = HelpClass.FormatoFecha(Item("FCHCRT")).ToString
                .pExtension = Item("TIPIMG")
            End With
            llobj_Filemanager.Add(lobj_Filemanager)
        Next
        dgvMenu.DataSource = llobj_Filemanager
    End Sub

    Private Sub Buscar()
        Dim objFileManager As New clsFileManager
        Dim dtFolder As New DataTable
        'dtFolder = objFileManager.getFolderAll(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy, UcCliente.pCodigo.ToString)
        dtFolder = objFileManager.getFolderAll("EZ", UcCliente.pCodigo.ToString)
        Me.NodeFolder.Nodes.Clear()
        Dim lstrCliente As String = String.Empty
        lstrCliente = String.Format("{0} - {1}", UcCliente.pCodigo.ToString, UcCliente.pRazonSocial.ToString)
        Me.NodeFolder.Nodes.Add("0", lstrCliente, 0)
        TreViewFileManager(dtFolder)
        Me.NodeFolder.Nodes(0).Expand()
    End Sub

    Private Sub NodeFolder_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles NodeFolder.NodeMouseClick
        _ValuePadre = e.Node.Tag
        Me.ListarArchivos(e.Node.Name, e.Node.Text)
        Me.dgvMenu.ClearSelection()
        Me.dgvMenu.CurrentCell = Nothing
    End Sub

    Private Sub FrmAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'UcCliente.CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            UcCliente.CCMPN = "EZ"
            dgvMenu.AutoGenerateColumns = False
            dgvMenu.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If UcCliente.pCodigo.ToString = 0 Then Exit Sub
            Me.Buscar()
            Me.ListarArchivos(0, "", Me.txtNameFile.Text.Trim.ToUpper)
            Me.dgvMenu.ClearSelection()
            Me.dgvMenu.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvMenu_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvMenu.DataBindingComplete
        For i As Integer = 0 To dgvMenu.Rows.Count - 1
            If Me.dgvMenu.Rows(i).Cells("Tipo_ID").Value() = "F" Then
                Me.dgvMenu.Rows(i).Cells("Tipo").Value() = Lista.Images(1)
                Me.dgvMenu.Rows(i).Cells("Descargar").Value() = My.Resources.CuadradoBlanco
            Else
                Me.dgvMenu.Rows(i).Cells("Tipo").Value() = My.Resources.text_block
                Me.dgvMenu.Rows(i).Cells("Descargar").Value() = My.Resources.icono_verdetalle 'search
            End If
        Next
    End Sub

    Private Sub AbrirArchivo(ByVal objTempFileManager As Filemanager_BE)
        Try
            Dim objFileManager As New clsFileManager
            Dim objFileData As New FileData
            objFileData.IdCompañia = objTempFileManager.pIdCompañia
            objFileData.IdCliente = objTempFileManager.pIdCliente
            objFileData.IdFolder = objTempFileManager.pIdPadre
            objFileData.IdFile = objTempFileManager.pId
            objFileData = objFileManager.getFileData(objFileData)
            Using fs As New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & objFileData.FileName, IO.FileMode.Create)
                Dim myarray(objFileData.Data.Length) As Byte
                fs.Seek(0, System.IO.SeekOrigin.End)
                fs.Write(objFileData.Data, 0, objFileData.Data.Length)
                fs.Close()
                fs.Dispose()
            End Using
            ''mostrando el archivo en el browser
            Ransa.Utilitario.HelpClass.AbrirDocumento(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & objFileData.FileName)
            'Help.ShowHelp(New Form(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & objFileData.FileName)
        Catch : End Try
    End Sub

    Private Sub dgvMenu_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenu.CellDoubleClick
        If (e.ColumnIndex < 0 OrElse e.RowIndex < 0) Then Exit Sub
        Dim index As Int32 = dgvMenu.CurrentCellAddress.Y
        Dim objTempFileManager As Filemanager_BE
        objTempFileManager = dgvMenu.Rows(index).DataBoundItem
        If objTempFileManager.pTipo = "F" Then
            Dim node As TreeNode()
            node = NodeFolder.Nodes.Find(objTempFileManager.pId, True)
            If node.Length > 0 Then
                NodeFolder.SelectedNode = node(0)
            End If
            Me.ListarArchivos(objTempFileManager.pId, objTempFileManager.pNombre)
        Else
            AbrirArchivo(objTempFileManager)
        End If
    End Sub

    Private Sub dgvMenu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If (e.ColumnIndex < 0 OrElse e.RowIndex < 0) Then Exit Sub
        Dim index As Int32 = dgvMenu.CurrentCellAddress.Y
        Dim objTempFileManager As Filemanager_BE
        objTempFileManager = dgvMenu.Rows(index).DataBoundItem

        If dgvMenu.Columns(e.ColumnIndex).Name = "Descargar" Then
            If objTempFileManager.pTipo = "F" Then
                Me.ListarArchivos(objTempFileManager.pId, objTempFileManager.pNombre)
            Else
                AbrirArchivo(objTempFileManager)
            End If
        Else
            If objTempFileManager.pTipo = "F" Then
                Me._ValueFolder = objTempFileManager.pId
                Me._NameFolder = objTempFileManager.pNombre
            End If
        End If
    End Sub

    Private Sub dgvMenu_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenu.CellMouseEnter
        If (e.ColumnIndex < 0 OrElse e.RowIndex < 0) Then Exit Sub
        Dim dv As DataGridView = CType(sender, DataGridView)
        dv.Cursor = Cursors.Hand
    End Sub

    Private Sub btnNuevaCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Dim objfrmNuevaCarpeta As New frmNuevaCarpeta
        Dim objFilemanager As New Filemanager_BE
        'objFilemanager.pIdCompañia = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        objFilemanager.pIdCompañia = "EZ"
        objFilemanager.pIdCliente = UcCliente.pCodigo.ToString
        objFilemanager.pIdPadre = Me._ValueFolder
        objfrmNuevaCarpeta.pRazonSocial = UcCliente.pRazonSocial.ToString
        objfrmNuevaCarpeta.pFilemanagerBE = objFilemanager
        If objfrmNuevaCarpeta.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre <> 0 Then
                Me.Buscar()
                Dim node As TreeNode()
                node = NodeFolder.Nodes.Find(objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre.ToString, True)
                If node.Length > 0 Then
                    Me.NodeFolder.SelectedNode = node(0)
                    Me.ListarArchivos(objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre)
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If _ValueFolder = 0 Then Exit Sub
        Dim objfrmNuevoArchivo As New frmNuevoArchivo
        Dim objFilemanagerBE As New Filemanager_BE
        objFilemanagerBE.pIdPadre = Me._ValueFolder
        objFilemanagerBE.pIdCliente = UcCliente.pCodigo.ToString
        objfrmNuevoArchivo.pFilemanagerBE = objFilemanagerBE
        If objfrmNuevoArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.ListarArchivos(Me._ValueFolder)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If _ValueFolder = 0 Then Exit Sub
        Try
            Dim objTempFileManager As New Filemanager_BE
            objTempFileManager.pIdCompañia = "EZ"
            objTempFileManager.pIdCliente = UcCliente.pCodigo.ToString
            If dgvMenu.Rows.Count > 0 Then
                If dgvMenu.CurrentRow IsNot Nothing Then
                    Dim index As Int32 = dgvMenu.CurrentCellAddress.Y
                    objTempFileManager = dgvMenu.Rows(index).DataBoundItem
                    If objTempFileManager.pTipo = "A" Then
                        Me.deleteFile(objTempFileManager)
                    Else
                        ' objTempFileManager.pIdPadre = objTempFileManager.pId
                        Me.deleteFolder(objTempFileManager)
                    End If
                Else
                    'Elimina directorio
                    'objTempFileManager.pIdPadre = Me._ValueFolder
                    objTempFileManager.pId = Me._ValueFolder
                    objTempFileManager.pNombre = Me._NameFolder
                    Me.deleteFolder(objTempFileManager)
                End If
            Else
                'Elimina directorio
                ' objTempFileManager.pIdPadre = Me._ValueFolder
                objTempFileManager.pId = Me._ValueFolder
                objTempFileManager.pNombre = Me._NameFolder
                Me.deleteFolder(objTempFileManager)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub deleteFolder(ByVal objTempFileManager As Filemanager_BE)
        'Valida si tiene Varias Carpetas o Archivos dentro
        Dim objFileManagerBL As New clsFileManager
        Dim obj As New FileData
        obj.IdCompañia = objTempFileManager.pIdCompañia
        obj.IdCliente = objTempFileManager.pIdCliente
        obj.IdFolder = objTempFileManager.pId
        obj.Usuario = ConfigurationWizard.UserName
        obj.IdFile = 0
        Dim lint_countFile As Decimal = objFileManagerBL.getFileCount(obj)
        If lint_countFile = -1 OrElse lint_countFile > 0 Then
            MessageBox.Show(String.Format("La carpeta ""{0}"" contiene archivos {1}", objTempFileManager.pNombre.Trim, ", elimine el contenido"), "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show(String.Format("¿Está seguro de eliminar el directorio ""{0}"" ?", objTempFileManager.pNombre.Trim), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim node As TreeNode()
            If objFileManagerBL.deleteFile(obj) Then
                MessageBox.Show("Se eliminó con éxito", "Eliminar directorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If objTempFileManager.pIdPadre Is Nothing Then
                    node = NodeFolder.Nodes.Find(_ValuePadre, True)
                    Me.Buscar()
                    If node.Length > 0 Then
                        Me.NodeFolder.SelectedNode = node(0)
                        Me.ListarArchivos(_ValuePadre)
                    Else
                        Me.ListarArchivos(0)
                    End If
                Else
                    node = NodeFolder.Nodes.Find(objTempFileManager.pIdPadre.ToString, True)
                    Me.Buscar()
                    If node.Length > 0 Then
                        Me.NodeFolder.SelectedNode = node(0)
                        Me.ListarArchivos(objTempFileManager.pIdPadre)
                    Else
                        Me.ListarArchivos(0)
                    End If
                End If
            Else
                MessageBox.Show("No se pudo eliminar el directorio", "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Sub deleteFile(ByVal objTempFileManager As Filemanager_BE)
        If MessageBox.Show(String.Format("¿Está seguro de eliminar el archivo ""{0}""?", objTempFileManager.pDescripcion.Trim), "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim objFileManagerBL As New clsFileManager
            Dim obj As New FileData
            obj.IdCompañia = objTempFileManager.pIdCompañia
            obj.IdCliente = objTempFileManager.pIdCliente
            obj.IdFolder = objTempFileManager.pIdPadre
            obj.Usuario = ConfigurationWizard.UserName
            obj.IdFile = objTempFileManager.pId

            If objFileManagerBL.deleteFile(obj) Then
                MessageBox.Show("Se eliminó con éxito", "Eliminar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Buscar()
                Dim node As TreeNode()
                node = NodeFolder.Nodes.Find(objTempFileManager.pIdPadre.ToString, True)
                If node.Length > 0 Then
                    Me.NodeFolder.SelectedNode = node(0)
                    Me.ListarArchivos(objTempFileManager.pIdPadre)
                End If
            Else
                MessageBox.Show("No se pudo eliminar el archivo", "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If _ValueFolder = 0 Then Exit Sub
        Try
            Dim objTempFileManager As New Filemanager_BE
            objTempFileManager.pIdCompañia = "EZ"
            objTempFileManager.pIdCliente = UcCliente.pCodigo.ToString
            If dgvMenu.Rows.Count > 0 Then
                If dgvMenu.CurrentRow IsNot Nothing Then
                    Dim index As Int32 = dgvMenu.CurrentCellAddress.Y
                    objTempFileManager = dgvMenu.Rows(index).DataBoundItem
                    If objTempFileManager.pTipo = "F" Then
                        Me.ModificarFolder(objTempFileManager)
                    Else
                        Me.ModificarFile(objTempFileManager)
                    End If
                Else
                    'Modifica directorio
                    Me.ModificarFolder(objTempFileManager)
                End If
            Else
                'Modifica directorio
                Me.ModificarFolder(objTempFileManager)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModificarFolder(ByVal objTempFileManager As Filemanager_BE)
        Dim objfrmNuevaCarpeta As New frmNuevaCarpeta
        'objFilemanager.pIdCompañia = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        objTempFileManager.pIdCompañia = "EZ"
        objTempFileManager.pIdCliente = UcCliente.pCodigo.ToString
        objTempFileManager.pIdPadre = Me._ValueFolder
        objTempFileManager.pNombre = Me._NameFolder.Trim
        objfrmNuevaCarpeta.pRazonSocial = UcCliente.pRazonSocial.ToString

        objfrmNuevaCarpeta.pFilemanagerBE = objTempFileManager
        objfrmNuevaCarpeta.pRazonSocial = UcCliente.pRazonSocial.ToString
        objfrmNuevaCarpeta.pIsEdition = True
        If objfrmNuevaCarpeta.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre <> 0 Then
                Me.Buscar()
                Dim node As TreeNode()
                node = NodeFolder.Nodes.Find(objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre.ToString, True)
                If node.Length > 0 Then
                    Me.NodeFolder.SelectedNode = node(0)
                    Me.ListarArchivos(objfrmNuevaCarpeta.pFilemanagerBE.pIdPadre)
                End If
            End If
        End If
    End Sub

    Private Sub ModificarFile(ByVal objTempFileManager As Filemanager_BE)
        Dim objfrmNuevoArchivo As New frmNuevoArchivo
        Dim objFilemanagerBE As New Filemanager_BE
        objfrmNuevoArchivo.pIsEdition = True
        objTempFileManager.pIdCompañia = "EZ"
        objTempFileManager.pIdCliente = UcCliente.pCodigo.ToString
        objTempFileManager.pIdPadre = Me._ValueFolder
        objTempFileManager.pNombre = Me._NameFolder
        objfrmNuevoArchivo.pFilemanagerBE = objTempFileManager
        If objfrmNuevoArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.ListarArchivos(Me._ValueFolder)
        End If
    End Sub

End Class

Public Class Filemanager_BE
    Private _IdCompañia As String
    Private _IdCliente As Decimal
    Private _Id As String
    Private _IdPadre As String
    Private _Tipo As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _Tamanio As String
    Private _FechaCreacion As String
    Private _Extension As String

    Public Property pIdCompañia() As String
        Get
            Return _IdCompañia
        End Get
        Set(ByVal value As String)
            _IdCompañia = value
        End Set
    End Property

    Public Property pIdCliente() As Decimal
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Decimal)
            _IdCliente = value
        End Set
    End Property

    Public Property pId() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property pIdPadre() As String
        Get
            Return _IdPadre
        End Get
        Set(ByVal value As String)
            _IdPadre = value
        End Set
    End Property

    Public Property pTipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Public Property pNombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property pDescripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property pTamanio() As String
        Get
            Return _Tamanio
        End Get
        Set(ByVal value As String)
            _Tamanio = value
        End Set
    End Property

    Public Property pFechaCreacion() As String
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As String)
            _FechaCreacion = value
        End Set
    End Property

    Public Property pExtension() As String
        Get
            Return _Extension
        End Get
        Set(ByVal value As String)
            _Extension = value
        End Set
    End Property

End Class
