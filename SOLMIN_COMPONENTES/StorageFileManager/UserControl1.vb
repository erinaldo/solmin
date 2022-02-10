Imports system.IO
Imports System.Collections
Imports StorageFileManager.localhost

Public Class UserControl1

    Dim ofd As New OpenFileDialog
    Dim objLista As New List(Of FileArray)
    Dim _SYSTEMNAME As String = ""
    Dim _TableName As String = ""
    Dim _UserName As String = ""
    Dim _NMRGIM As String = ""
    Dim _CCLNT As String = ""
    Dim _CCMPN As String = ""
    Dim objMainDirectory As New Directorio

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

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        ofd.ShowDialog(Me)

        'Obteniendo los datos del archivo seleccionado
        If ofd.FileName IsNot Nothing Then

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

    Public Sub CargarImagenes(ByVal objdirectorio As Directorio)
        Try
            Dim ws As New WsFileManager
            Dim objResult() As FileResult
            objResult = ws.getFileList(objdirectorio)

            For i As Integer = 0 To objResult.Length - 1
                'Dim obj As New DocumentElement
                'AddHandler obj.DetailClickEvent, AddressOf DetailClick
                'obj.FileTarget = objResult(i)
                'Me.PanelDocumentos.Controls.Add(obj)

                Dim objFilearray As New FileArray
                objFilearray.IdFileX = i + 1
                objFilearray.FileTarget = objResult(i)
                objFilearray.FileName = objResult(i).FileName
                objFilearray.FileSize = CInt(objResult(i).FileData.Length / 1024)

                If objResult(i).FileName.ToUpper.EndsWith("PDF") Then
                    objFilearray.FileIcon = Global.StorageFileManager.My.Resources.pdf2
                ElseIf objResult(i).FileName.ToUpper.EndsWith("DOC") Or objResult(i).FileName.ToUpper.EndsWith("DOCX") Then
                    objFilearray.FileIcon = Global.StorageFileManager.My.Resources.txt1
                ElseIf objResult(i).FileName.ToUpper.EndsWith("XLS") Or objResult(i).FileName.ToUpper.EndsWith("XLSX") Then
                    objFilearray.FileIcon = Global.StorageFileManager.My.Resources.spreadsheet_document2
                ElseIf objResult(i).FileName.ToUpper.EndsWith("JPEG") Or objResult(i).FileName.ToUpper.EndsWith("JPG") Or objResult(i).FileName.ToUpper.EndsWith("GIF") Or objResult(i).FileName.ToUpper.EndsWith("PNG") Or objResult(i).FileName.ToUpper.EndsWith("BMP") Then
                    objFilearray.FileIcon = Global.StorageFileManager.My.Resources.image1
                Else
                    objFilearray.FileIcon = Global.StorageFileManager.My.Resources.template_source1
                End If

                objLista.Add(objFilearray)
            Next
        Catch ex As Exception
            objLista = New Generic.List(Of FileArray)
        End Try

        'Me.dtg.AutoGenerateColumns = False
        Me.dtg.DataSource = objLista

    End Sub

    Public Sub DetailClick(ByVal sender As Object, ByVal evt As EventArgs)

        Dim obj As DocumentElement
        obj = CType(sender, DocumentElement)

        Dim fs As System.IO.FileStream
        Dim buffer As String
        Dim i As Integer
        Dim myarray(obj.FileTarget.FileData.Length) As Byte
        fs = New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName, IO.FileMode.Create)
        fs.Seek(0, System.IO.SeekOrigin.End)
        fs.Write(obj.FileTarget.FileData, 0, obj.FileTarget.FileData.Length)
        fs.Close()
        fs.Dispose()
        'mostrando el archivo en el browser
        Me.Browser.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName)

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        Dim ws As New WsFileManager
        Dim obj As New FileResult
        Dim ofilename As String = ofd.FileName
        Dim oFileInfo As New IO.FileInfo(ofilename)
        Dim fs As New FileStream(ofilename, FileMode.Open, FileAccess.Read)
        Dim ofileData(fs.Length) As Byte
        fs.Read(ofileData, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        fs.Dispose()
        obj.FileData = ofileData
        obj.FileName = oFileInfo.Name

        'Obteniendo la data de la carpeta contenedora
        Dim objDirectorio As New Directorio 
        objDirectorio.NMRGIM = objMainDirectory.NMRGIM

        'Obteniendo la data del archivo a guardar
        Dim objdocumento As New Documento
        objdocumento.NMRGIM = objMainDirectory.NMRGIM
        objdocumento.NCRIMG = "0"
        objdocumento.TNMBAR = oFileInfo.Name
        objdocumento.TIPIMG = oFileInfo.Extension
        objdocumento.QBYTIM = CInt(oFileInfo.Length)
        objdocumento.NTRMCR = Me.UserName
        objdocumento.CUSCRT = UserName

        If ws.SaveFile(obj, objDirectorio, objdocumento) = True Then
            MsgBox("archivo subio correctamente")
            CargarImagenes(objDirectorio)
        Else
            MsgBox("Fallo al subir el archivo")
        End If

    End Sub

    Private Sub dtg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg.CellContentClick

        If e.RowIndex <> -1 Then

            Dim obj As FileArray
            For x As Integer = 0 To Me.objLista.Count - 1
                If objLista(x).IdFileX = dtg.Rows(e.RowIndex).Cells("IdFileX").Value Then
                    obj = objLista(x)
                    Exit For
                End If
            Next

            Dim fs As System.IO.FileStream
            Dim buffer As String
            Dim i As Integer
            Dim myarray(obj.FileTarget.FileData.Length) As Byte
            fs = New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName, IO.FileMode.Create)
            fs.Seek(0, System.IO.SeekOrigin.End)
            fs.Write(obj.FileTarget.FileData, 0, obj.FileTarget.FileData.Length)
            fs.Close()
            fs.Dispose()
            'mostrando el archivo en el browser
            Me.Browser.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName)

        End If

    End Sub
 
    Public Sub InitComponentProperties()
        'al iniciar el formulario lo primero que valida es que exista el directorio raiz de toda la estructura
        Dim objDirectorio As New Directorio
        Dim ws As New WsFileManager
        objDirectorio.NMRGIM = Me.NMRGIM
        objDirectorio.CCLNTO = _CCLNT
        objDirectorio.CCMPN = _CCMPN
        objDirectorio.MMCAPL = Me.SystemName 
        objDirectorio.CUSCRT = UserName
        objMainDirectory = ws.CreateRootDirectory(objDirectorio)

        'Verificando que carguen las imagenes del directorio 
        Me.CargarImagenes(objDirectorio)

    End Sub


    'Public Sub LoadStructure()

    '    Dim objDirectorio As New Directorio
    '    Dim ws As New WsFileManager
    '    objDirectorio.SISSRC = Me.SystemName
    '    objDirectorio.CODFLD = "0"
    '    objDirectorio.FLDPDR = "0"

    '    Me.NodeFolder.Nodes.Clear()

    '    Dim lst(ws.getFolderStructure(objDirectorio).Length) As Directorio
    '    lst = ws.getFolderStructure(objDirectorio)

    '    For i As Integer = 0 To lst.Length - 1
    '        Dim obj As New Directorio
    '        obj = lst(i)

    '        'si es elemento raiz, procede a pintarlo primero
    '        If obj.FLDPDR = "0" Then
    '            Dim objTreenode As New TreeNode
    '            objTreenode.Name = obj.CODFLD
    '            objTreenode.Text = obj.NOMFLD
    '            objTreenode.ImageIndex = 0
    '            NodeFolder.Nodes.Add(objTreenode)
    '        Else
    '            For x As Integer = 0 To NodeFolder.Nodes.Count - 1
    '                If obj.FLDPDR = NodeFolder.Nodes(x).Name Then
    '                    Dim objTreenode As New TreeNode
    '                    objTreenode.Name = obj.CODFLD
    '                    objTreenode.Text = obj.NOMFLD
    '                    objTreenode.ImageIndex = 0
    '                    NodeFolder.Nodes(x).Nodes.Add(objTreenode)
    '                End If
    '            Next
    '        End If

    '    Next

    '    NodeFolder.ExpandAll()

    'End Sub

    'Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

    '    'verificamos que nodo se ha seleccionado en base a eso tomamos como nodo padre
    '    Dim objDirectorio As New Directorio
    '    Dim ws As New WsFileManager
    '    objDirectorio.NOMFLD = NMRGIM
    '    objDirectorio. = Me.NodeFolder.SelectedNode.Name
    '    objDirectorio.TBLSRC = TableName
    '    objDirectorio.SISSRC = Me.SystemName
    '    objDirectorio.NTRMCR = "SOLMIN"
    '    objDirectorio.TOBS = ""
    '    objDirectorio.CUSCRT = UserName
    '    ws.CreateDirectory(objDirectorio)

    '    Me.LoadStructure()

    'End Sub
 
    'Private Sub NodeFolder_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NodeFolder.DoubleClick

    '    'al dar doble lcik muestra los archivos contenido en la carpeta seleccionada

    '    'Obtenemos los archivos contenidos en la carpeta padre
    '    Dim objDirectorio As New Directorio
    '    Dim ws As New WsFileManager
    '    objDirectorio.NOMFLD = Me.txtNomberDir.Text
    '    objDirectorio.FLDPDR = Me.NodeFolder.SelectedNode.Name
    '    objDirectorio.TBLSRC = TableName
    '    objDirectorio.SISSRC = Me.SystemName
    '    objDirectorio.NTRMCR = "SOLMIN"
    '    objDirectorio.TOBS = ""
    '    objDirectorio.CUSCRT = UserName
    '    Me.CargarImagenes(objDirectorio)

    'End Sub
 
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        CType(Me.Parent, Form).Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

Class FileArray

    Private _IdFilex As Integer
    Private _oFileIcon As Image
    Private _fileName As String
    Private _FileSize As Long
    Private _FileTarget As FileResult

    Public Property FileIcon() As Image
        Get
            Return _oFileIcon
        End Get
        Set(ByVal value As Image)
            _oFileIcon = value
        End Set
    End Property

    Public Property IdFileX() As Int32
        Get
            Return _IdFilex
        End Get
        Set(ByVal value As Int32)
            _IdFilex = value
        End Set
    End Property

    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
        End Set
    End Property

    Public Property FileSize() As Long
        Get
            Return _FileSize
        End Get
        Set(ByVal value As Long)
            _FileSize = value
        End Set
    End Property

    Public Property FileTarget() As FileResult
        Get
            Return _FileTarget
        End Get
        Set(ByVal value As FileResult)
            _FileTarget = value
        End Set
    End Property

End Class
