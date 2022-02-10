Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Configuration

Public Class frmDocumentosAdjuntosConductor
    Dim miHash As New Hashtable
    Dim _CLINK As String = ""
    Dim _NCOIMG As Integer = -1
    Dim NomCarpetaConductor As String = ""
    Dim NombrePictueSel As String = ""
    Friend WithEvents picBox As MyPictureBox

    Public Sub cargarDatos(ByVal ht As Hashtable)

        Try
            miHash = ht
            NomCarpetaConductor = ConfigurationManager.AppSettings("RUTA_CONDUCTOR").ToString()
            NomCarpetaConductor = (NomCarpetaConductor & miHash("CBRCNT").ToString()).Trim()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub frmDocumentosAdjuntosConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargarDocLinks()
            TabControl1.Controls.Remove(TabPageImg)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cargarDocLinks()
        Dim objLogica As New DocAdjuntoConductor_BLL
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

                Dim doclinks As New DocAdjuntoConductor
                doclinks.CBRCNT = dtb.Rows(i).Item("CBRCNT").ToString.Trim
                doclinks.NCRRDC = dtb.Rows(i).Item("NCRRDC").ToString.Trim
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

                picBox.setImage(doclinks.CLINK, NomCarpetaConductor)

                AddHandler picBox.ImagenDoubleClick, AddressOf metalDobleClick
                AddHandler picBox.ImagenClick, AddressOf metalClick

                If doclinks.CTIIMG = "DOC" Then
                    picBox.Size = New System.Drawing.Size(50, 50)
                    imgPanelDocs.Controls.Add(picBox)
                ElseIf doclinks.CTIIMG = "IMG" Then
                    picBox.Size = New System.Drawing.Size(50, 50)
                    imgPanelImg.Controls.Add(picBox)
                End If

            Next
            PnlDocs.Controls.Add(imgPanelDocs)
            PnlImg.Controls.Add(imgPanelImg)
        End If
    End Sub

    Private Sub metalDobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If TypeOf sender Is PictureBox Then
                Dim pb As New MyPictureBox
                pb = sender
                Process.Start(pb.URL)
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub metalClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If TypeOf sender Is PictureBox Then
                Dim pb As New MyPictureBox
                pb = sender
                _NCOIMG = pb.Name
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Seleccionar_DesSeleccionar(ByVal pb As PictureBox)
        For Each oControldoc As Control In Me.PnlDocs.Controls()
            If (oControldoc.Name = pb.Name) Then
                Continue For
            End If
            pb.Size = New System.Drawing.Size(50, 50)
        Next
        For Each oControlimg As Control In Me.PnlImg.Controls()
            If (oControlimg.Name = pb.Name) Then
                Continue For
            End If
            pb.Size = New System.Drawing.Size(50, 50)
        Next
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Try
            Dim strNomFile As String = miHash("CBRCNT").ToString() & "_" & HelpClass.TodayNumeric & HelpClass.NowNumeric
            Dim objfrmSA As New frmSubirArchivo(NomCarpetaConductor, strNomFile)
            If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim objCargarImagen As New clsImageWebUpload
                Dim extension As String = ""
                extension = objCargarImagen.GetFileExtension(NomCarpetaConductor, strNomFile)
                If objCargarImagen.ExisteImagen(NomCarpetaConductor, strNomFile & extension) Then
                    Dim objEntidad As New DocAdjuntoConductor
                    objEntidad.CBRCNT = miHash("CBRCNT")
                    objEntidad.NCRRDC = miHash("NCRRDC")
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
                    objEntidad.CCMPN = miHash("CCMPN")

                    Dim objLogica As New DocAdjuntoConductor_BLL
                    objEntidad = objLogica.Registrar_Documento_Adjunto(objEntidad)
                    If objEntidad.CBRCNT = "0" Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    Else
                        cargarDocLinks()
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub txtObservacionesViewer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Select Case Asc(e.KeyChar)
                Case 13 : grabarDescripcion()
            End Select
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub grabarDescripcion()
        Try
            Dim objLogica As New DocAdjuntoConductor_BLL
            Dim objEntidad As New DocAdjuntoConductor
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
            If objEntidad.CBRCNT = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                cargarDocLinks()
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try

            If MsgBox("Desea eliminar el archivo?", MsgBoxStyle.OkCancel, "Eliminar Archivo") = MsgBoxResult.Ok Then
                Dim objLogica As New DocAdjuntoConductor_BLL
                Dim objEntidad As New DocAdjuntoConductor
                objEntidad.NCOIMG = CInt(_NCOIMG)
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric

                objEntidad = objLogica.Eliminar_Documento_Adjunto(objEntidad)
                If objEntidad.CBRCNT = "0" Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                Else
                    cargarDocLinks()
                End If
            End If

           
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

End Class




