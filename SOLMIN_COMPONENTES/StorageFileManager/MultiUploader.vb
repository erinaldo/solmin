Imports System.IO
Imports System.Collections
Imports StorageFileManager.Classes
Imports System.ComponentModel

Public Class MultiUploader

    Dim ofd As New OpenFileDialog
    Dim objLista As New List(Of FileArray)
    Dim _SYSTEMNAME As String = ""
    Dim _TableName As String = ""
    Dim _UserName As String = ""
    Dim _NMRGIM As String = ""
    Dim _CCLNT As String = ""
    Dim _CCMPN As String = ""
    Dim m_EntityFileStorages As New BindingList(Of EntityFileStorage)


    Public Delegate Sub SaveNegocio(ByVal senderas As Object)
    Public Event onSaveCampoNegocio As SaveNegocio

    Public Delegate Sub CloseUploader(ByVal sender As Object)
    Public Event onCloseUploader As CloseUploader

    Public Sub ClickonSaveNegocio(ByVal sender As Object)
        RaiseEvent onSaveCampoNegocio(sender)
    End Sub

    Public Sub ClickonCloseUploader(ByVal sender As Object)
        m_EntityFileStorages = New BindingList(Of EntityFileStorage)
        EntityFileStorageBindingSource.DataSource = Nothing
        RaiseEvent onCloseUploader(sender)
    End Sub

    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EntityFileStorageBindingSource.DataSource = m_EntityFileStorages
    End Sub

    'Private _SaveIntorage As Boolean
    'Public Property SaveIntorage() As Boolean
    '    Get
    '        Return _SaveIntorage
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _SaveIntorage = value
    '    End Set
    'End Property

    Public Property NMRGIM() As String
        Get
            Return _NMRGIM
        End Get
        Set(ByVal value As String)
            _NMRGIM = value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return _TableName
        End Get
        Set(ByVal value As String)
            _TableName = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    Public Property SystemName() As String
        Get
            Return _SYSTEMNAME
        End Get
        Set(ByVal value As String)
            _SYSTEMNAME = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            If m_EntityFileStorages.Count <= 0 Then
                Exit Sub
            End If

            For Each m_EntityFileStorage As EntityFileStorage In m_EntityFileStorages
                'If m_EntityFileStorage.FileName.Length > 50 Then
                '    MsgBox("El nombre del archivo a guardar excede al máximo permitido (50 caracteres)")
                '    Exit Sub
                'End If
                Dim ofilename As String = m_EntityFileStorage.FileName
                Dim oFileInfo As New IO.FileInfo(ofilename)
                If oFileInfo.Name.Length > 50 Then
                    MsgBox("El nombre del archivo a guardar excede al máximo permitido (50 caracteres)")
                    Exit Sub
                End If
            Next

            Dim ws As New WsFileManager
            Dim obj As New FileResult
            Dim objDirectorio As New Directorio
            Dim objdocumento As New Documento

            If _NMRGIM = "" Or _NMRGIM = "0" Then
                objDirectorio.NMRGIM = Me.NMRGIM
                objDirectorio.CCLNTO = _CCLNT
                objDirectorio.CCMPN = _CCMPN
                objDirectorio.MMCAPL = Me.SystemName
                objDirectorio.TIPODC = Me.TableName
                objDirectorio.CUSCRT = UserName
                Dim DirectoryTemp As New Directorio
                DirectoryTemp = ws.CreateRootDirectory(objDirectorio)
                Me._NMRGIM = DirectoryTemp.NMRGIM
            End If


            For Each m_EntityFileStorage As EntityFileStorage In m_EntityFileStorages

                If m_EntityFileStorage.FileName <> "" Then

                    'Dim ws As New WsFileManager
                    '' ws.Url = "http://localhost:2685/WSFileManager/WsFileManager.asmx?wsdl"
                    'Dim obj As New FileResult
                    'Dim objDirectorio As New Directorio
                    'Dim objdocumento As New Documento

                    'Verificando si es que no se tiene un directorio de destino
                    'If _NMRGIM = "" Or _NMRGIM = "0" Then
                    '    objDirectorio.NMRGIM = Me.NMRGIM
                    '    objDirectorio.CCLNTO = _CCLNT
                    '    objDirectorio.CCMPN = _CCMPN
                    '    objDirectorio.MMCAPL = Me.SystemName
                    '    objDirectorio.TIPODC = Me.TableName
                    '    objDirectorio.CUSCRT = UserName
                    '    Dim DirectoryTemp As New Directorio
                    '    DirectoryTemp = ws.CreateRootDirectory(objDirectorio)
                    '    Me._NMRGIM = DirectoryTemp.NMRGIM
                    'End If

                    Dim ofilename As String = m_EntityFileStorage.FileName
                    Dim oFileInfo As New IO.FileInfo(ofilename)

                    If oFileInfo.Name.Length > 50 Then
                        MsgBox("El nombre del archivo a guardar excede al máximo permitido (50 caracteres)")
                        Exit Sub
                    End If

                    Dim fs As New FileStream(ofilename, FileMode.Open, FileAccess.Read)
                    Dim ofileData(fs.Length) As Byte
                    fs.Read(ofileData, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()
                    fs.Dispose()
                    obj.FileData = ofileData
                    obj.FileName = oFileInfo.Name

                    'Obteniendo la data de la carpeta contenedora
                    objDirectorio.NMRGIM = Me._NMRGIM

                    'Obteniendo la data del archivo a guardar
                    objdocumento.NMRGIM = Me._NMRGIM
                    objdocumento.NCRIMG = "0"
                    objdocumento.TNMBAR = oFileInfo.Name
                    objdocumento.TIPIMG = oFileInfo.Extension
                    objdocumento.QBYTIM = CInt(oFileInfo.Length)
                    objdocumento.NTRMCR = Me.UserName
                    objdocumento.CUSCRT = UserName

                    If ws.SaveFile(obj, objDirectorio, objdocumento) = True Then
                        Me.ClickonSaveNegocio(objdocumento.NMRGIM)
                    Else
                        MsgBox("Error al subir el archivo")
                    End If

                End If
            Next

            Me.ClickonCloseUploader(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        ofd.Multiselect = True
        Dim dr As DialogResult = ofd.ShowDialog(Me)

        If (dr = DialogResult.OK) Then
            If ofd.FileNames.Length <= 0 Then
                ' MsgBox("Debe de seleccionar un archivo")
                Exit Sub
            End If

            m_EntityFileStorages = New BindingList(Of EntityFileStorage)

            For Each m_FileName As String In ofd.FileNames

                Dim oFileInfo As New IO.FileInfo(m_FileName)
                Dim m_EntityFileStorage As New EntityFileStorage
                m_EntityFileStorage.FileName = m_FileName
                m_EntityFileStorage.Archivo = oFileInfo.Name.ToUpper
                m_EntityFileStorage.Fecha = oFileInfo.CreationTime.ToShortDateString.ToUpper
                m_EntityFileStorage.Tamanho = FormatNumber((oFileInfo.Length / 1024), 2) & " KB".ToUpper
                m_EntityFileStorage.TipoArchivo = oFileInfo.Extension.Replace(".", "").ToUpper
                m_EntityFileStorages.Add(m_EntityFileStorage)
                ' CargarImagenes()
            Next
            EntityFileStorageBindingSource.DataSource = m_EntityFileStorages
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me.ClickonCloseUploader(Nothing)
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        If Not EntityFileStorageBindingSource.Current Is Nothing Then
            m_EntityFileStorages.Remove(CType(EntityFileStorageBindingSource.Current, EntityFileStorage))
        Else
            MsgBox("Debe seleccionar un archivo para eliminarlo")
        End If
        EntityFileStorageBindingSource.DataSource = m_EntityFileStorages
    End Sub
End Class
