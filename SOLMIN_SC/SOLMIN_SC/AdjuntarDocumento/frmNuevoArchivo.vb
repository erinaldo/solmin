Imports StorageFileManager
Imports System.Text
Imports System.io
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmNuevoArchivo
    Dim ofd As New OpenFileDialog
    Private _IsSave As Boolean
    Private _IsEdition As Boolean
    Private _objFilemanager_BE As Filemanager_BE
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

    Private Sub frmNuevoArchivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _IsEdition Then
            Me.btnSeleccionar.Enabled = False
            Me.btnGuardar.Enabled = True
            Me.txtDescripcion.Text = pFilemanagerBE.pDescripcion.Trim
            Me.lblArchivo.Text = _objFilemanager_BE.pNombre.ToUpper
            Me.lblFecha.Text = _objFilemanager_BE.pFechaCreacion
            Me.lblTamano.Text = _objFilemanager_BE.pTamanio
            Me.lblTipoArchivo.Text = _objFilemanager_BE.pExtension.Replace(".", "").ToUpper
            If Me.lblTipoArchivo.Text.ToUpper = "PDF" Then
                Me.PictureBox1.Image = My.Resources.pdf2
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "DOC" Or Me.lblTipoArchivo.Text.ToUpper = "DOCX" Then
                Me.PictureBox1.Image = My.Resources.txt1
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "XLS" Or Me.lblTipoArchivo.Text.ToUpper = "XLSX" Then
                Me.PictureBox1.Image = My.Resources.spreadsheet_document1
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "JPG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "GIF" Or Me.lblTipoArchivo.Text.ToUpper = "PNG" Or Me.lblTipoArchivo.Text.ToUpper = "TIFF" Or Me.lblTipoArchivo.Text.ToUpper = "BMP" Then
                Me.PictureBox1.Image = My.Resources.image2
            Else
                Me.PictureBox1.Image = My.Resources.template_source
            End If
            Me.txtDescripcion.Focus()
        Else
            Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        ofd.ShowDialog(Me)
        If ofd.FileName IsNot Nothing Then
            If ofd.FileName = "" Then
                Me.btnGuardar.Enabled = False
                Exit Sub
            End If

            Dim oFileInfo As New IO.FileInfo(ofd.FileName)
            Me.lblArchivo.Text = oFileInfo.Name.ToUpper
            Me.lblFecha.Text = oFileInfo.CreationTime.ToShortDateString.ToUpper
            Me.lblTamano.Text = FormatNumber((oFileInfo.Length / 1024), 2) & " KB".ToUpper
            Me.lblTipoArchivo.Text = oFileInfo.Extension.Replace(".", "").ToUpper
            If Me.lblTipoArchivo.Text.ToUpper = "PDF" Then
                Me.PictureBox1.Image = My.Resources.pdf2
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "DOC" Or Me.lblTipoArchivo.Text.ToUpper = "DOCX" Then
                Me.PictureBox1.Image = My.Resources.txt1
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "XLS" Or Me.lblTipoArchivo.Text.ToUpper = "XLSX" Then
                Me.PictureBox1.Image = My.Resources.spreadsheet_document1
            ElseIf Me.lblTipoArchivo.Text.ToUpper = "JPG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "JPEG" Or Me.lblTipoArchivo.Text.ToUpper = "GIF" Or Me.lblTipoArchivo.Text.ToUpper = "PNG" Or Me.lblTipoArchivo.Text.ToUpper = "TIFF" Or Me.lblTipoArchivo.Text.ToUpper = "BMP" Then
                Me.PictureBox1.Image = My.Resources.image2
            Else
                Me.PictureBox1.Image = My.Resources.template_source
            End If
            Me.txtDescripcion.Focus()
            Me.btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If lblArchivo.Text = "" OrElse Me.txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Ingrese Nombre del Archivo", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim objFilemanagerBLl As New clsFileManager
        Dim objFileData As New FileData
        If _IsEdition Then
            objFileData.IdCompañia = _objFilemanager_BE.pIdCompañia
            objFileData.IdCliente = _objFilemanager_BE.pIdCliente
            objFileData.IdFolder = _objFilemanager_BE.pIdPadre
            objFileData.Usuario = HelpUtil.UserName
            objFileData.IdFile = _objFilemanager_BE.pId
            objFileData.FileName = Me.txtDescripcion.Text
            If objFilemanagerBLl.modyfyFile(objFileData) = True Then
                _IsSave = True
                MessageBox.Show("Se guardó con éxito", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al modificar el archivo", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If ofd.FileName IsNot Nothing Then
                If ofd.FileName <> "" Then
                    'Verificando si es que no se tiene un directorio de destino
                    Dim ofilename As String = ofd.FileName
                    Dim oFileInfo As New IO.FileInfo(ofilename)
                    If oFileInfo.Name.Length > 50 Then
                        MessageBox.Show("El nombre del archivo a guardar excede al máximo permitido (50 caracteres)", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    Dim fs As New FileStream(ofilename, FileMode.Open, FileAccess.Read)
                    Dim ofileData(fs.Length) As Byte
                    fs.Read(ofileData, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()
                    fs.Dispose()
                    With objFileData
                        .Data = ofileData
                        .IdCliente = Me._objFilemanager_BE.pIdCliente
                        .IdCompañia = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                        ' .IdCompañia = "EZ"
                        .FileName = oFileInfo.Name
                        .Descripcion = Me.txtDescripcion.Text.Trim
                        .TipoFile = oFileInfo.Extension
                        .IdFolder = Me._objFilemanager_BE.pIdPadre
                        .IdFile = 0
                        .Tamanio = CType(oFileInfo.Length, Double)
                        .Usuario = HelpUtil.UserName
                    End With
                    If objFilemanagerBLl.saveFile(objFileData).IdFile <> 0 Then
                        _IsSave = True
                        Me.btnGuardar.Enabled = False
                        Me.btnSeleccionar.Enabled = True
                        MessageBox.Show("Se guardó con éxito", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error al subir el archivo", "Registro de Archivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me.Close()
    End Sub

    Private Sub frmNuevoArchivo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _IsSave Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class
