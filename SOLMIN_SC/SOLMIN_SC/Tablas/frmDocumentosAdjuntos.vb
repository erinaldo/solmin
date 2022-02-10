Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports System.IO
Public Class frmDocumentosAdjuntos
    Private _docAdjunto As String = ""
    Private _NomAdjunto As String = ""

    Private _pCCLNT As Decimal = 0
    Private _pNRPEMB As Decimal = 0
    Private _pNORCML As String = ""
    Private _pNRPARC As Decimal = 0

    Private _pTipoVizualizacion As TipoVizualizacion = TipoVizualizacion.PreEmbarque
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
        End Set
    End Property
    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property
    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property

  

    '
  
    Public Property pTipoVizualizacion() As TipoVizualizacion
        Get
            Return _pTipoVizualizacion
        End Get
        Set(ByVal value As TipoVizualizacion)
            _pTipoVizualizacion = value
        End Set
    End Property

    Private _pDialogResult As Boolean = False

    Public Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
        Set(ByVal value As Boolean)
            _pDialogResult = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Friend WithEvents picBox As MyPictureBox
    Enum TipoVizualizacion
        OrdenCompraParcial
        PreEmbarque
    End Enum
    Private SizeNormal As Int32 = 40
    Private SizeSelec As Int32 = 60
    Private Sub frmDocumentosAdjuntos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case _pTipoVizualizacion
                Case TipoVizualizacion.PreEmbarque
                    btnAgregar.Visible = True
                    btnEliminar.Visible = True
                    cargarDocLinks(_pTipoVizualizacion)
                Case TipoVizualizacion.OrdenCompraParcial
                    btnAgregar.Visible = False
                    btnEliminar.Visible = False
                    cargarDocLinks(_pTipoVizualizacion)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cargarDocLinks(ByVal Tipo As TipoVizualizacion)

        Dim oclsDocumentoAdjunto As New clsDocumentoAdjunto
        Dim obeParamsDocAdjunto As New beDocumentoAdjunto
        Dim dtb As New DataTable
        Select Case Tipo
            Case TipoVizualizacion.PreEmbarque
                obeParamsDocAdjunto.PNCCLNT = _pCCLNT
                obeParamsDocAdjunto.PNNRPEMB = _pNRPEMB
                dtb = oclsDocumentoAdjunto.Lista_Documentos_x_PreEmbarque(obeParamsDocAdjunto)
            Case TipoVizualizacion.OrdenCompraParcial
                obeParamsDocAdjunto.PNCCLNT = _pCCLNT
                obeParamsDocAdjunto.PSNORCML = _pNORCML
                obeParamsDocAdjunto.PNNRPARC = _pNRPARC
                obeParamsDocAdjunto.PSCCMPN = _pCCMPN
                dtb = oclsDocumentoAdjunto.Lista_Documentos_x_OrdenCompraParcial(obeParamsDocAdjunto)
        End Select
        PnlDocs.Controls.Clear()
        PnlImg.Controls.Clear()
        lblTitulo.Text = ""
        Dim imgPanelDocs As New TableLayoutPanel
        imgPanelDocs.AutoScroll = True
        imgPanelDocs.ColumnCount = 9
        imgPanelDocs.Dock = DockStyle.Fill

        Dim imgPanelImg As New TableLayoutPanel
        imgPanelImg.AutoScroll = True
        imgPanelImg.ColumnCount = 9
        imgPanelImg.Dock = DockStyle.Fill
        'crear componentes con sus imagenes
        Dim doclinks As beDocumentoAdjunto
        If dtb.Rows.Count > 0 Then
            For i As Integer = 0 To dtb.Rows.Count - 1
                doclinks = New beDocumentoAdjunto
                doclinks.PNCCLNT = dtb.Rows(i).Item("CCLNT").ToString.Trim
                doclinks.PNNRPEMB = dtb.Rows(i).Item("NRPEMB")
                doclinks.PNNCRRDC = dtb.Rows(i).Item("NCRRDC")
                doclinks.PSCTIIMG = dtb.Rows(i).Item("CTIIMG").ToString.Trim
                doclinks.PSTNMBAR = dtb.Rows(i).Item("TNMBAR").ToString.Trim
                doclinks.PSURLARC = dtb.Rows(i).Item("URLARC").ToString.Trim

                picBox = New MyPictureBox
                picBox.Name = doclinks.PNCCLNT.ToString & "/" & doclinks.PNNRPEMB & "/" & doclinks.PNNCRRDC
                picBox.Tag = doclinks.PSTNMBAR
                'estructura:Clienete + Num PreEmbarque + Correlativo
                picBox.BackColor = System.Drawing.Color.White
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.Cursor = Cursors.Hand
                picBox.setImage(doclinks.PSURLARC, doclinks.PSTNMBAR)

                AddHandler picBox.ImagenDoubleClick, AddressOf EventDobleClick
                AddHandler picBox.ImagenClick, AddressOf EventClick

                If doclinks.PSCTIIMG = "DOC" Then
                    picBox.Size = New System.Drawing.Size(SizeNormal, SizeNormal)
                    imgPanelDocs.Controls.Add(picBox)
                ElseIf doclinks.PSCTIIMG = "IMG" Then
                    picBox.Size = New System.Drawing.Size(SizeNormal, SizeNormal)
                    imgPanelImg.Controls.Add(picBox)
                End If
            Next
            PnlDocs.Controls.Add(imgPanelDocs)
            PnlImg.Controls.Add(imgPanelImg)
        End If
    End Sub

    Private Sub EventDobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is PictureBox Then
            Dim pb As New MyPictureBox
            pb = sender
            Process.Start(pb.URL)
        End If
    End Sub

    Private Function TabSeleccionado() As String
        Dim TabSelec As String = ""
        TabSelec = TabAdjuntos.SelectedTab.Name.ToUpper
        Return TabSelec
    End Function
    Private Sub EventClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each Item As Control In PnlDocs.Controls
            For Each ItemC As Control In Item.Controls
                If TypeOf ItemC Is PictureBox Then
                    ItemC.Size = New System.Drawing.Size(SizeNormal, SizeNormal)
                End If
            Next
        Next
        For Each Item As Control In PnlImg.Controls
            For Each ItemC As Control In Item.Controls
                If TypeOf ItemC Is PictureBox Then
                    ItemC.Size = New System.Drawing.Size(SizeNormal, SizeNormal)
                End If
            Next
        Next
        If TypeOf sender Is PictureBox Then
            Dim pb As New MyPictureBox
            pb = sender
            pb.Size = New System.Drawing.Size(SizeSelec, SizeSelec)
            lblTitulo.Text = "Archivo Seleccionado: " & pb.Tag
            _docAdjunto = pb.Name
            _NomAdjunto = pb.Tag
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim url_adj_pree As String = HelpUtil.getSetting("URL_ADJ_SIL")
            Dim strNomCarpeta As String = "ADJ_PREEMBARQUE"
            Dim obrDocumentoAdjunto As New clsDocumentoAdjunto
            Dim retorno As Int32 = 0
            Dim strNomFile As String = _pNRPEMB & "_" & TodayNumeric() & "_" & NowNumeric()
            Dim objfrmSA As New frmSubirArchivo(strNomFile, strNomCarpeta)
            If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then
                _pDialogResult = True
                Dim objCargarImagen As New clsImageWebUpload
                Dim extension As String = ""
                extension = objCargarImagen.GetFileExtencion("SOLMIN_SC\" & strNomCarpeta, strNomFile)
                If objCargarImagen.ExisteImagen("SOLMIN_SC\" & strNomCarpeta, strNomFile & extension) Then
                    Dim obeDocumentoAdjunto As New beDocumentoAdjunto
                    obeDocumentoAdjunto.PNCCLNT = _pCCLNT
                    obeDocumentoAdjunto.PNNRPEMB = _pNRPEMB
                    obeDocumentoAdjunto.PNNCRRDC = 0
                    obeDocumentoAdjunto.PSURLARC = url_adj_pree & strNomCarpeta & "/"
                    obeDocumentoAdjunto.PSTNMBAR = strNomFile & extension
                    obeDocumentoAdjunto.PSCULUSA = HelpUtil.UserName
                    If TabAdjuntos.SelectedTab.Name = "TabPageDocs" Then
                        obeDocumentoAdjunto.PSCTIIMG = "DOC"
                    ElseIf TabAdjuntos.SelectedTab.Name = "TabPageImg" Then
                        obeDocumentoAdjunto.PSCTIIMG = "IMG"
                    End If
                    retorno = obrDocumentoAdjunto.Insertar_Documentos_x_PreEmbarque(obeDocumentoAdjunto)
                    cargarDocLinks(_pTipoVizualizacion)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim obeDocAdjunto As New beDocumentoAdjunto
            Dim Documento As String = ""
            Dim retorno As Int32 = 0
            Dim obrDocumentoAdjunto As New Negocio.clsDocumentoAdjunto
            If (_docAdjunto.Trim.Length <> 0) Then
                If MessageBox.Show("Está seguro de eliminar el archivo " & _NomAdjunto, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    _pDialogResult = True
                    Dim DocAdjunto() As String
                    DocAdjunto = _docAdjunto.Split("/")
                    obeDocAdjunto.PNCCLNT = DocAdjunto(0)
                    obeDocAdjunto.PNNRPEMB = DocAdjunto(1)
                    obeDocAdjunto.PNNCRRDC = DocAdjunto(2)
                    obeDocAdjunto.PSCULUSA = HelpUtil.UserName
                    retorno = obrDocumentoAdjunto.Elimina_Documentos_x_PreEmbarque(obeDocAdjunto)
                    cargarDocLinks(_pTipoVizualizacion)
                End If
            Else
                MessageBox.Show("Seleccione el archivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Public Shared Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function
    Public Shared Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

  
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

    Public Sub setImage(ByVal URL_ADJ_PREEMBARQUE As String, ByVal lpNombreDoc As String)
        Dim lstr_URLDoc As String = URL_ADJ_PREEMBARQUE
        _URL = lstr_URLDoc & lpNombreDoc

        Dim objImage As Image
        Try
            Dim ext As String = ""
            ext = lpNombreDoc.Substring(lpNombreDoc.LastIndexOf("."), lpNombreDoc.Length - lpNombreDoc.LastIndexOf("."))
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

