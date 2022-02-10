Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.IO
Public Class frmDocAdjuntoConductor
    Dim miHash As New Hashtable
    Dim _CLINK As String = ""
    Dim _NCOIMG As Integer = -1
    Dim nomCarpeta As String = ""
    Friend WithEvents picBox As MyPictureBox1

    Public Sub cargarDatos(ByVal ht As Hashtable)
        miHash = ht
        nomCarpeta = miHash("CBRCNT").ToString()
    End Sub

    Private Sub frmDocumentosAdjuntos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDocLinks()
    End Sub

    Private Sub cargarDocLinks()
        Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
        Dim dtb As New DataTable

        PnlDocs.Controls.Clear()
        PnlImg.Controls.Clear()

        Dim imgPanelDocs As New TableLayoutPanel
        imgPanelDocs.AutoScroll = True
        imgPanelDocs.ColumnCount = 9
        imgPanelDocs.Dock = DockStyle.Fill

        Dim imgPanelImg As New TableLayoutPanel
        imgPanelImg.AutoScroll = True
        imgPanelImg.ColumnCount = 3
        imgPanelImg.Dock = DockStyle.Fill

        Dim lstr_URLDoc As String = My.Settings.ST_DIR + "imagenes/solmin/conductor/"
        lstr_URLDoc = lstr_URLDoc & miHash("CBRCNT").ToString()
        Dim strListaArchivos() As String
        strListaArchivos = Nothing
        Dim oDirectoryInfo As New DirectoryInfo(lstr_URLDoc)
        Dim nombrearchivo As String = ""
        Dim extension As String = ""
        If (oDirectoryInfo.Exists) Then
            For Each ofileinfo As FileInfo In oDirectoryInfo.GetFiles()
                nombrearchivo = ofileinfo.Name
                extension = ofileinfo.Extension
                picBox = New MyPictureBox1
                picBox.Name = nombrearchivo
                picBox.BackColor = System.Drawing.Color.White
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.Cursor = Cursors.Hand
                'se asigna su imagen correspondiente
                picBox.setImage(nombrearchivo, nomCarpeta)

                AddHandler picBox.ImagenDoubleClick, AddressOf metalDobleClick
                AddHandler picBox.ImagenClick, AddressOf metalClick

                If extension = "DOC" Then
                    picBox.Size = New System.Drawing.Size(60, 60)
                    imgPanelDocs.Controls.Add(picBox)
                ElseIf extension = "IMG" Then
                    picBox.Size = New System.Drawing.Size(200, 200)
                    imgPanelImg.Controls.Add(picBox)
                End If

            Next
            PnlDocs.Controls.Add(imgPanelDocs)
            PnlImg.Controls.Add(imgPanelImg)

        End If

    End Sub

    Private Sub metalDobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is PictureBox Then
            Dim pb As New MyPictureBox
            pb = sender
            Process.Start(pb.URL)
        End If
    End Sub

    Private Sub metalClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is PictureBox Then
            Dim pb As New MyPictureBox
            pb = sender
            _NCOIMG = pb.Name
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
       


        Dim strNomCarpeta As String = nomCarpeta
        Dim strNomFile As String = HelpClass.TodayNumeric & HelpClass.NowNumeric

        Dim objfrmSA As New frmSubirArchivo(strNomCarpeta, strNomFile)

        If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim objCargarImagen As New clsImageWebUpload
            Dim extension As String = ""

            extension = objCargarImagen.GetFileExtension(strNomCarpeta, strNomFile)

            If objCargarImagen.ExisteImagen(strNomCarpeta, strNomFile & extension) Then
                cargarDocLinks()


            End If
        End If
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        
        cargarDocLinks()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class

Class MyPictureBox1
    Inherits PictureBox
    Public Event ImagenClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ImagenDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
    Dim _URL As String = ""

    Public ReadOnly Property URL() As String
        Get
            Return _URL
        End Get
    End Property

    Private Sub MyPictureBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        RaiseEvent ImagenDoubleClick(Me, e)
    End Sub

    Private Sub MyPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        RaiseEvent ImagenClick(Me, e)
    End Sub

    Public Sub setImage(ByVal lpNombreDoc As String, ByVal strCarpeta As String)
        Dim lstr_URLDoc As String = My.Settings.ST_DIR + "imagenes/solmin/" & strCarpeta
        _URL = lstr_URLDoc & "/" & lpNombreDoc

        Dim objImage As Image
        Try

            Dim ext As String = lpNombreDoc.Substring(lpNombreDoc.LastIndexOf("."), lpNombreDoc.Length - lpNombreDoc.LastIndexOf("."))
            ext = ext.ToLower

            Select Case ext
                Case ".jpg"
                    objImage = LoadImageFromUrl(_URL)
                Case ".jpeg"
                    objImage = LoadImageFromUrl(_URL)
                Case ".bmp"
                    objImage = LoadImageFromUrl(_URL)
                Case ".png"
                    objImage = LoadImageFromUrl(_URL)
                Case ".tiff"
                    objImage = LoadImageFromUrl(_URL)
                Case ".gif"
                    objImage = LoadImageFromUrl(_URL)
                Case ".doc"
                    objImage = My.Resources.word_icon
                Case ".docx"
                    objImage = My.Resources.word_icon
                Case ".xls"
                    objImage = My.Resources.excel_icon
                Case ".xlsx"
                    objImage = My.Resources.excel_icon
                Case ".ppt"
                    objImage = My.Resources.powerpoint_icon
                Case ".pdf"
                    objImage = My.Resources.pdf_icon
                Case Else
                    objImage = My.Resources.unknown_icon
            End Select

            Me.Image = objImage
        Catch ex As Exception
            objImage = My.Resources._404FileNotFound
        End Try

    End Sub

    Public Function LoadImageFromUrl(ByRef url As String) As Bitmap
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Drawing.Image = Drawing.Image.FromStream(response.GetResponseStream())
            Dim objbitmap As Drawing.Bitmap
            objbitmap = img
            response.Close()
            Return objbitmap
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
