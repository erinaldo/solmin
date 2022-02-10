Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmDocumentosAdjuntos
    Dim miHash As New Hashtable
    Dim _CLINK As String = ""
    Dim _NCOIMG As Integer = -1
    Friend WithEvents picBox As MyPictureBox

    Public Sub cargarDatos(ByVal ht As Hashtable)
        miHash = ht
    End Sub

    Private Sub frmDocumentosAdjuntos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDocLinks()
    End Sub

    Private Sub cargarDocLinks()
        Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
        Dim dtb As New DataTable

        'lee los doclinks de la BD
        dtb = objLogica.Listar_Documentos_Adjuntos(miHash)

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

        'crear componentes con sus imagenes
        If dtb.Rows.Count > 0 Then
            For i As Integer = 0 To dtb.Rows.Count - 1

                Dim doclinks As New DocsAdjuntos_SolTransporte
                doclinks.NCSOTR = dtb.Rows(i).Item("NCSOTR").ToString.Trim
                doclinks.NCRRSR = dtb.Rows(i).Item("NCRRSR").ToString.Trim
                doclinks.NCOIMG = dtb.Rows(i).Item("NCOIMG").ToString.Trim
                doclinks.CTIIMG = dtb.Rows(i).Item("CTIIMG").ToString.Trim
                doclinks.CLINK = dtb.Rows(i).Item("CLINK").ToString.Trim
                doclinks.TOBS = dtb.Rows(i).Item("TOBS").ToString.Trim


                picBox = New MyPictureBox
                picBox.Name = doclinks.NCOIMG
                picBox.BackColor = System.Drawing.Color.White

                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.Cursor = Cursors.Hand
                'se asigna su imagen correspondiente
                picBox.setImage(doclinks.CLINK, "st_documento_adjunto")

                AddHandler picBox.ImagenDoubleClick, AddressOf metalDobleClick
                AddHandler picBox.ImagenClick, AddressOf metalClick

                If doclinks.CTIIMG = "DOC" Then
                    picBox.Size = New System.Drawing.Size(60, 60)
                    imgPanelDocs.Controls.Add(picBox)
                ElseIf doclinks.CTIIMG = "IMG" Then
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

        Dim strNomCarpeta As String = "st_documento_adjunto"
        Dim strNomFile As String = HelpClass.TodayNumeric & HelpClass.NowNumeric

        Dim objfrmSA As New frmSubirArchivo(strNomCarpeta, strNomFile)

        If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim objCargarImagen As New clsImageWebUpload
            Dim extension As String = ""

            extension = objCargarImagen.GetFileExtension(strNomCarpeta, strNomFile)

            If objCargarImagen.ExisteImagen(strNomCarpeta, strNomFile & extension) Then
                Dim objEntidad As New DocsAdjuntos_SolTransporte
                objEntidad.NCSOTR = miHash("NCSOTR")
                objEntidad.NCRRSR = miHash("NCRRSR")
                objEntidad.CLINK = strNomFile & extension
                If TabControl1.SelectedTab.Name = "TabPageDocs" Then
                    objEntidad.CTIIMG = "DOC"
                ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
                    objEntidad.CTIIMG = "IMG"
                End If
                objEntidad.TOBS = ""
                objEntidad.CUSCRT = MainModule.USUARIO
                objEntidad.FCHCRT = HelpClass.TodayNumeric
                objEntidad.HRACRT = HelpClass.NowNumeric
                objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

                Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
                objEntidad = objLogica.Registrar_Documento_Adjunto(objEntidad)
                If objEntidad.NCSOTR = "0" Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                Else
                    cargarDocLinks()
                End If

            End If
        End If
    End Sub

    Private Sub txtObservacionesViewer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 13 : grabarDescripcion()
        End Select
    End Sub

    Private Sub grabarDescripcion()
        Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
        Dim objEntidad As New DocsAdjuntos_SolTransporte
        objEntidad.CLINK = _CLINK
        If TabControl1.SelectedTab.Name = "TabPageDocs" Then
            objEntidad.TOBS = txtObservacionesDocs.Text.Trim
        ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
            objEntidad.TOBS = txtObservacionesImg.Text.Trim
        End If
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        'Modificar_Documento_Adjunto: usado para setear la descripcion en el campo TOBS
        objEntidad = objLogica.Modificar_Documento_Adjunto(objEntidad)
        If objEntidad.NCSOTR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            cargarDocLinks()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
        Dim objEntidad As New DocsAdjuntos_SolTransporte

        objEntidad.NCOIMG = CInt(_NCOIMG)
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric

        objEntidad = objLogica.Eliminar_Documento_Adjunto(objEntidad)
        If objEntidad.NCSOTR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            cargarDocLinks()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class



Class MyPictureBox
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
    Dim lstr_URLDoc As String = My.Settings.ST_URL + "imagenes/solmin/" & strCarpeta
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
                Case ".txt"
                    objImage = My.Resources.text_block
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