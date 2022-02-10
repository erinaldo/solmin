Imports system.IO
Imports System.Collections

Public Class Uploader

    Dim ofd As New OpenFileDialog
    Dim objLista As New List(Of FileArray)
    Dim _SYSTEMNAME As String = ""
    Dim _TableName As String = ""
    Dim _UserName As String = ""
    Dim _NMRGIM As String = ""
    Dim _CCLNT As String = ""
    Dim _CCMPN As String = ""


    Public Delegate Sub SaveNegocio(ByVal senderas As Object)
    Public Event onSaveCampoNegocio As SaveNegocio

    Public Sub ClickonSaveNegocio(ByVal sender As Object)
        RaiseEvent onSaveCampoNegocio(sender)
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

        If lblArchivo.Text = "" Then
            Exit Sub
        End If

        If ofd.FileName IsNot Nothing Then
            If ofd.FileName <> "" Then


                Dim ws As New WsFileManager
                ' ws.Url = "http://localhost:2685/WSFileManager/WsFileManager.asmx?wsdl"
                Dim obj As New FileResult
                Dim objDirectorio As New Directorio
                Dim objdocumento As New Documento

                'Verificando si es que no se tiene un directorio de destino
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

                Dim ofilename As String = ofd.FileName
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
        End If

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        'ofd.Multiselect = True
        ofd.ShowDialog(Me)

        'Obteniendo los datos del archivo seleccionado
        If ofd.FileName IsNot Nothing Then
            If ofd.FileName = "" Then
                ' MsgBox("Debe de seleccionar un archivo")
                Exit Sub
            End If
            Dim oFileInfo As New IO.FileInfo(ofd.FileName) 
            Me.lblArchivo.Text = oFileInfo.Name.ToUpper
            Me.lblFecha.Text = oFileInfo.CreationTime.ToShortDateString.ToUpper
            Me.lblTamano.Text = FormatNumber((oFileInfo.Length / 1024), 2) & " KB".ToUpper
            Me.lblTipoArchivo.Text = oFileInfo.Extension.Replace(".", "").ToUpper

            If Me.lblTipoArchivo.Text.ToUpper = "PDF" Then
                Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.pdf2
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "DOC" Or Me.lblTipoArchivo.Text.ToUpper = "DOCX" Then
                Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.txt2
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "XLS" Or Me.lblTipoArchivo.Text.ToUpper = "XLSX" Then
                Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.spreadsheet_document2
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "JPG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "GIF" Or Me.lblTipoArchivo.Text.ToUpper = "PNG" Or Me.lblTipoArchivo.Text.ToUpper = "TIFF" Or Me.lblTipoArchivo.Text.ToUpper = "BMP" Then
                Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.image2
            Else
                Me.PictureBox1.Image = Global.StorageFileManager.My.Resources.template_source1
            End If

            ' CargarImagenes()
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        CType(Me.Parent, Form).Close()
    End Sub
End Class
