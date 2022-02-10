Imports StorageFileManager
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmNuevaCarpeta

    Dim _RazonSocial As String = ""
    Private _IsEdition As Boolean
    Private _objFilemanager_BE As Filemanager_BE

    Public Property pRazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(ByVal value As String)
            _RazonSocial = value
        End Set
    End Property

    Public Property pIsEdition() As Boolean
        Get
            Return _IsEdition
        End Get
        Set(ByVal value As Boolean)
            _IsEdition = value
        End Set
    End Property

    Public Property pFilemanagerBE() As Filemanager_BE
        Get
            Return _objFilemanager_BE
        End Get
        Set(ByVal value As Filemanager_BE)
            _objFilemanager_BE = value
        End Set
    End Property

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
                nuevoNodo.Text = lstr_nombre_Carpeta 'String.Format("{0} - {1}", lstr_Codigo.ToString, lstr_nombre_Carpeta)
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

    Private Sub frmNuevaCarpeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'guardamos en el web service el directorio y lo crea en la tabla y fisicamente tambien
        If Me._objFilemanager_BE.pIdCliente = 0 Then Exit Sub
        Dim objFileManagerBL As New clsFileManager
        Dim dtFolder As New DataTable
        'dtFolder = objFileManagerBL.getFolderAll(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy, IdCliente)
        dtFolder = objFileManagerBL.getFolderAll("EZ", Me._objFilemanager_BE.pIdCliente)
        Me.NodeFolder.Nodes.Clear()
        Dim lstrCliente As String = String.Empty
        lstrCliente = String.Format("{0} - {1}", Me._objFilemanager_BE.pIdCliente, _RazonSocial)
        Me.NodeFolder.Nodes.Add("0", lstrCliente, 0)
        TreViewFileManager(dtFolder)
        If Me._objFilemanager_BE.pIdPadre <> 0 Then
            Dim node As TreeNode()
            node = NodeFolder.Nodes.Find(Me._objFilemanager_BE.pIdPadre.ToString, True)

            If node.Length > 0 Then
                NodeFolder.SelectedNode = node(0)
            End If
        End If
        Me.NodeFolder.Nodes(0).Expand()

        If Me._IsEdition Then
            Me.txtFolder.Text = Me._objFilemanager_BE.pNombre.Trim
            Me.NodeFolder.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtFolder.Text.Trim = "" Then
            MessageBox.Show("Ingrese Nombre de Carpeta", "Agregar directorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim objFileManagerBL As New clsFileManager
        Dim objDirectorio As New FileData
        If Me._IsEdition Then
            objDirectorio.IdCompañia = _objFilemanager_BE.pIdCompañia
            objDirectorio.IdCliente = _objFilemanager_BE.pIdCliente
            objDirectorio.IdFolder = _objFilemanager_BE.pIdPadre
            objDirectorio.Usuario = ConfigurationWizard.UserName
            objDirectorio.FileName = Me.txtFolder.Text.Trim
            If objFileManagerBL.modyfyFile(objDirectorio) = True Then
                MessageBox.Show("Se guardó con éxito", "Modificar directorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me._objFilemanager_BE.pIdPadre = objDirectorio.IdFolder
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error al Modificar el directorio", "Modificar directorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If Me.NodeFolder.SelectedNode Is Nothing Then MessageBox.Show("Seleccione una carpeta", "Atencion!", MessageBoxButtons.OK)
            objDirectorio.IdCompañia = _objFilemanager_BE.pIdCompañia
            objDirectorio.IdCliente = Me._objFilemanager_BE.pIdCliente
            objDirectorio.IdFolder = Me.NodeFolder.SelectedNode.Name
            objDirectorio.Usuario = ConfigurationWizard.UserName
            objDirectorio.FileName = Me.txtFolder.Text
            objDirectorio = objFileManagerBL.saveFolder(objDirectorio)
            If objDirectorio.IdFolder <> 0 Then
                MessageBox.Show("Se guardó con éxito", "Agregar directorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me._objFilemanager_BE.pIdPadre = objDirectorio.IdFolder
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
