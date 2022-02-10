Imports system.IO
Imports System.Collections

Public Class FileStorage
    'Friend WithEvents f As New FRMuPLOADER
    Friend WithEvents f As New FrmMultiUploader

    Public Delegate Sub SaveNegocio(ByVal sender As Object)
    Public Event onSaveCampoNegocio As SaveNegocio

    Public Sub ClickonSaveNegocio(ByVal sender As Object)
        RaiseEvent onSaveCampoNegocio(sender)
    End Sub

    Public Event EliminaImagen(ByVal NMRGIM As String)


    Dim ofd As New OpenFileDialog
    Dim objLista As New List(Of FileArray)
    Dim _SYSTEMNAME As String = ""
    Dim _TableName As String = ""
    Dim _UserName As String = ""
    Private _NMRGIM As String = ""
    Dim _CCLNT As String = ""
    Dim _CCMPN As String = ""
    Dim _lstImagenesLst As New Generic.List(Of String)
    Private _ModeEdition As Boolean = True

    Public Property ModeEdition() As Boolean
        Get
            Return _ModeEdition
        End Get
        Set(ByVal value As Boolean)
            _ModeEdition = value
        End Set
    End Property

    Public Property NMRGIM() As String
        Get
            Return _NMRGIM
        End Get
        Set(ByVal value As String)
            _NMRGIM = value
        End Set
    End Property

    Public Property ImageListNumbers() As List(Of String)
        Get
            Return _lstImagenesLst
        End Get
        Set(ByVal value As List(Of String))
            _lstImagenesLst = value
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

    Public Sub VerAgregar(ByVal ver As Boolean)
        btnAgregar1.Visible = ver
    End Sub
    Public Sub VerEliminar(ByVal ver As Boolean)
        btnEliminarPopup.Visible = ver
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        f.Uploader1.NMRGIM = Me._NMRGIM
        f.Uploader1.CCLNT = Me._CCLNT
        f.Uploader1.CCMPN = Me._CCMPN
        f.Uploader1.SystemName = Me._SYSTEMNAME
        f.Uploader1.TableName = Me._TableName
        f.Uploader1.UserName = Me._UserName
        f.ShowDialog(Me)
        'AddHandler f.onSaveCampoNegocio, AddressOf Me.onSaveCampoNegocioUpload
        'Ejecuta el Evento para las Tablas de Negocio
        'ClickonSaveNegocio()
        Me._NMRGIM = f.Uploader1.NMRGIM
        Dim objDirectorio As New Directorio
        objDirectorio.NMRGIM = Me.NMRGIM
        objDirectorio.CCLNTO = Me._CCLNT
        objDirectorio.CCMPN = Me._CCMPN
        objDirectorio.MMCAPL = Me.SystemName
        objDirectorio.TIPODC = Me.TableName
        objDirectorio.CUSCRT = UserName
        Me.CargarImagenes(objDirectorio)
    End Sub

    Public Sub CargarImagenes(ByVal objdirectorio As Directorio, Optional ByVal ListadoMultiple As Boolean = False)
        Try
            Dim ws As New WsFileManager
            Dim objResult() As FileResult
            'ws.Url = "http://localhost:63043/SOLMINDOCS/WsFileManager.asmx?wsdl"
            objResult = ws.getFileList(objdirectorio)
            If ListadoMultiple = False Then
                objLista.Clear()
            End If
            For i As Integer = 0 To objResult.Length - 1
                Dim objFilearray As New FileArray
                objFilearray.IdFileX = objResult(i).IfFile
                objFilearray.FileTarget = objResult(i)
                objFilearray.FileName = objResult(i).FileName
                objFilearray.FileSize = CInt(objResult(i).FileData.Length / 1024)
                objLista.Add(objFilearray)
            Next
        Catch ex As Exception
            objLista = New Generic.List(Of FileArray)
        End Try

        Dim objT As New FileArray
        objLista.Add(objT)
        Me.lstFiles.Items.Clear()
        For Each obj As FileArray In objLista
            If obj.FileName IsNot Nothing Then
                Dim lwi As New ListViewItem
                lwi.Text = obj.FileName
                Try
                    lwi.Text = lwi.Text & " - " & (FormatNumber(obj.FileSize, 2) & " .KB")
                Catch : End Try
                lwi.Name = obj.IdFileX

                If obj.FileName.ToUpper.EndsWith("PDF") Then
                    lwi.ImageKey = "pdf"
                ElseIf obj.FileName.ToUpper.EndsWith("DOC") Or obj.FileName.ToUpper.EndsWith("DOCX") Then
                    lwi.ImageKey = "word"
                ElseIf obj.FileName.ToUpper.EndsWith("XLS") Or obj.FileName.ToUpper.EndsWith("XLSX") Then
                    lwi.ImageKey = "excel"
                ElseIf obj.FileName.ToUpper.EndsWith("JPEG") Or obj.FileName.ToUpper.EndsWith("JPG") Or obj.FileName.ToUpper.EndsWith("GIF") Or obj.FileName.ToUpper.EndsWith("PNG") Or obj.FileName.ToUpper.EndsWith("BMP") Then
                    lwi.ImageKey = "image"
                Else
                    lwi.ImageKey = "filex"
                End If
                Me.lstFiles.Items.Add(lwi)
            End If
        Next
        Me.lblArchivo.Text = ""
        Me.lblFecha.Text = ""
        Me.lblTamano.Text = ""
        Me.lblTipoArchivo.Text = ""
        Me.GrpDetalleArchivo.Visible = False
    End Sub

    Public Shared Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    Public Shared Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

    Public Sub InitComponentProperties()
        btnAgregar1.Visible = ModeEdition
        btnEliminarPopup.Visible = ModeEdition
        If Me._lstImagenesLst.Count = 0 Then
            CargaImagenesIndividuales()
        Else
            For Each obj As String In Me._lstImagenesLst
                Dim objDirectorio As New Directorio
                objDirectorio.NMRGIM = obj
                objDirectorio.CCLNTO = _CCLNT
                objDirectorio.CCMPN = _CCMPN
                objDirectorio.MMCAPL = Me.SystemName
                objDirectorio.TIPODC = Me.TableName
                objDirectorio.CUSCRT = UserName
                'Verificando que carguen las imagenes del directorio 
                Me.CargarImagenes(objDirectorio, True)
            Next
        End If
    End Sub

    Private Sub CargaImagenesIndividuales()
        If _NMRGIM <> "" And _NMRGIM <> "0" Then
            Dim objDirectorio As New Directorio
            objDirectorio.NMRGIM = Me._NMRGIM
            objDirectorio.CCLNTO = Me._CCLNT
            objDirectorio.CCMPN = Me._CCMPN
            objDirectorio.MMCAPL = Me.SystemName
            objDirectorio.TIPODC = Me.TableName
            objDirectorio.CUSCRT = Me.UserName
            'Verificando que carguen las imagenes del directorio 
            Me.CargarImagenes(objDirectorio)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If lstFiles.SelectedItems Is Nothing Then
                Exit Sub
            End If
            Dim cantDocEliminado As Integer = 0
            Dim obj As FileArray
            For x As Integer = 0 To Me.objLista.Count - 1
                For Each j As ListViewItem In Me.lstFiles.SelectedItems
                    If objLista(x).IdFileX = j.Name Then
                        obj = objLista(x)
                        If obj.FileName Is Nothing Then
                            Exit Sub
                        End If
                        'Dim ws As New WsFileManager
                        'Dim objDirectorio As New Directorio
                        'objDirectorio.NMRGIM = Me._NMRGIM
                        'Dim objdocumento As New Documento
                        'objdocumento.NMRGIM = Me._NMRGIM
                        'objdocumento.NCRIMG = obj.IdFileX
                        'objdocumento.CUSCRT = UserName
                        'If ws.DeleteFile(objDirectorio, objdocumento) = True Then
                        '    cantDocEliminado = cantDocEliminado + 1
                        'Else
                        '    MsgBox("Error al eliminar")
                        '    Exit For
                        'End If
                        'Exit For
                    End If
                Next
            Next

            'If cantDocEliminado > 0 Then

            '    Dim wsConsulta As New WsFileManager
            '    Dim objDirectorioConsulta As New Directorio
            '    objDirectorioConsulta.NMRGIM = Me._NMRGIM
            '    MsgBox(cantDocEliminado & " Archivo(s) Eliminado(s)")
            '    CargarImagenes(objDirectorioConsulta)
            '    If Me.lstFiles.Items.Count = 0 Then
            '        RaiseEvent EliminaImagen(_NMRGIM)
            '    End If

            'End If


            If obj.FileName Is Nothing Then
                Exit Sub
            End If

            Dim ws As New WsFileManager
            Dim objDirectorio As New Directorio
            objDirectorio.NMRGIM = Me._NMRGIM
            Dim objdocumento As New Documento
            objdocumento.NMRGIM = Me._NMRGIM
            objdocumento.NCRIMG = obj.IdFileX
            objdocumento.CUSCRT = UserName
            'ws.Url = "http://localhost:2685/WSFileManager/WsFileManager.asmx?wsdl"
            If ws.DeleteFile(objDirectorio, objdocumento) = True Then
                MsgBox("Archivo Eliminado")
                CargarImagenes(objDirectorio)
                If Me.lstFiles.Items.Count = 0 Then
                    RaiseEvent EliminaImagen(_NMRGIM)
                End If
            Else
                MsgBox("Error al eliminar")
            End If
          Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Refrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objDirectorio As New Directorio
        Dim ws As New WsFileManager
        objDirectorio.NMRGIM = _NMRGIM
        objDirectorio.CCLNTO = _CCLNT
        objDirectorio.CCMPN = _CCMPN
        objDirectorio.MMCAPL = Me.SystemName
        objDirectorio.TIPODC = Me.TableName
        objDirectorio.CUSCRT = UserName
        Me.CargarImagenes(objDirectorio)
    End Sub

    Private Sub lstFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFiles.DoubleClick
        Try
            If lstFiles.SelectedItems Is Nothing Then
                Exit Sub
            End If
            Dim obj As FileArray
            For x As Integer = 0 To Me.objLista.Count - 1
                For Each j As ListViewItem In Me.lstFiles.SelectedItems
                    If objLista(x).IdFileX = j.Name Then
                        obj = objLista(x)
                        Exit For
                    End If
                Next
            Next

            Using fs As New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName, IO.FileMode.Create)
                Dim myarray(obj.FileTarget.FileData.Length) As Byte
                fs.Seek(0, System.IO.SeekOrigin.End)
                fs.Write(obj.FileTarget.FileData, 0, obj.FileTarget.FileData.Length)
                fs.Close()
                fs.Dispose()
            End Using
            'mostrando el archivo en el browser
            Help.ShowHelp(New Form(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & obj.FileTarget.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.btnEliminar_Click(sender, e)
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPopup.Click
        Me.btnEliminar_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar1.Click
        btnSeleccionar_Click(sender, e)
    End Sub

    Protected Sub onSaveCampoNegocioUpload(ByVal sender As System.Object) Handles f.onSaveCampoNegocio
        ClickonSaveNegocio(sender)
    End Sub

End Class
