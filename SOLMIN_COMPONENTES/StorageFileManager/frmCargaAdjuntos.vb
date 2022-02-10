Imports System
Imports Amazon.S3
Imports Amazon.S3.Model
Imports Amazon.AWSConfigs
Imports Amazon.AWSConfigsS3
Imports Amazon.CognitoIdentity
Imports System.Configuration

Public Class frmCargaAdjuntos
    Private objCargaAdjunto_Bll As CargaAdjuntos_BL = New CargaAdjuntos_BL
    Public pNroImagen As Decimal = 0
  
    Private pCodListaMotivo As String = ""
    Private pCodRefMotivoDefault As String = ""
    Public pCodCompania As String = ""
    Public pCarpetaBucketDestino As String = ""
    Private albumBucketName As String = ""
    Private bucketRegion As String = ""
    Private IdentityPoolId As String = ""
    Private ListVariables As New Hashtable

    Public pDialog As Boolean = False
    Public pNroImagenGetUltimo As Boolean = False

    Private MaxTamanioNombreDoc As Integer = 45
    'Public pbucket_slmnsmp_2021 As Boolean = False
    Public Enum Tabla_Relacion
        NEUTRO
        RZTR05
        RZTR76
        RZSC03
        RZST07
        RZOL65P
        RZOL65I
        RZOL67
        RZOL65
        RZIM36
        RZSC53
        RZSC58
        RZTR31
    End Enum


    Public pTablaRelacions As Tabla_Relacion = Tabla_Relacion.NEUTRO
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub pAsignarCargaMotivo(TablaMotivo As String, CodDefault As String)
        pCodListaMotivo = TablaMotivo
        pCodRefMotivoDefault = CodDefault
    End Sub


    Private Sub frmCargaAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt.Columns.Add("COD")
            dt.Columns.Add("DESC")
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("COD") = "LC"
            dr("DESC") = "Local"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("COD") = "WS"
            dr("DESC") = "WS"
            dt.Rows.Add(dr)

            cboOrigen.ComboBox.DataSource = dt
            cboOrigen.ComboBox.DisplayMember = "DESC"
            cboOrigen.ComboBox.ValueMember = "COD"
            'cboOrigen.ComboBox.SelectedValue = "LC"
            cboOrigen.ComboBox.SelectedValue = "WS"

            If pTablaRelacions = Tabla_Relacion.NEUTRO Then
                MessageBox.Show("Tabla Relación no asignada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnSeleccionar.Enabled = False
                btnEliminar.Enabled = False
                Exit Sub
            End If
            If pNroImagenGetUltimo = True Then
                pNroImagen = GetNroImagenActualizado()
            End If

            Inicializar_AWS()
            Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos
            objCargaAdjuntos.TIPPROC = Me.pCodListaMotivo
            objCargaAdjuntos.NMRGIM = pNroImagen
            cargar_Motivo(objCargaAdjuntos)
            Listar_Documentos(objCargaAdjuntos)

            txtnro_imagen.Text = pNroImagen
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Inicializar_AWS()

        Dim dt_bucket As New DataTable
        'If pbucket_slmnsmp_2021 = True Then
        '    dt_bucket = objCargaAdjunto_Bll.Get_Bucket_AWS_APP2021()
        'Else
        '    dt_bucket = objCargaAdjunto_Bll.Get_Bucket_AWS()
        'End If
        dt_bucket = objCargaAdjunto_Bll.Get_Bucket_AWS_APP2021()

        If dt_bucket.Rows.Count > 0 Then
            albumBucketName = ("" & dt_bucket.Rows(0)("BUCKET_AWS")).ToString.Trim
            bucketRegion = ("" & dt_bucket.Rows(0)("BUCKET_REGION")).ToString.Trim
            IdentityPoolId = ("" & dt_bucket.Rows(0)("BUCKET_IDENTITY_POOLID")).ToString.Trim
        Else
            btnSeleccionar.Enabled = False
            btnEliminar.Enabled = False
            MessageBox.Show("Ruta Bucket no configurada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If




    End Sub

    Private Sub cargar_Motivo(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim IdMotivoDefault As Decimal = 0
        Dim dt As DataTable = New DataTable
        dt = objCargaAdjunto_Bll.Cargar_Motivo_Adjuntos(objCargaAdjuntos)
        Dim dr() As DataRow
        If pCodRefMotivoDefault.Length > 0 Then
            dr = dt.Select("CODRFM='" & pCodRefMotivoDefault & "'")
            If dr.Length > 0 Then
                IdMotivoDefault = dr(0)("IMTVIM")
            End If
        End If
        If dt.Rows.Count > 0 Then
            Dim drGeneral As DataRow
            drGeneral = dt.NewRow
            drGeneral("IMTVIM") = "0"
            drGeneral("MTVIMG") = "-General-"
            dt.Rows.Add(drGeneral)
        End If

        cbomotivo.DataSource = dt
        cbomotivo.DisplayMember = "MTVIMG"
        cbomotivo.ValueMember = "IMTVIM"

        If IdMotivoDefault > 0 Then
            cbomotivo.SelectedValue = IdMotivoDefault
        End If
    End Sub

    Private Function Listar_Documentos(ByVal objCargaAdjuntos As CargaAdjuntos) As Integer
        dtglistaDoc.AutoGenerateColumns = False
        dtglistaDoc.DataSource = Nothing
        If objCargaAdjuntos.NMRGIM > 0 Then
            dtglistaDoc.DataSource = objCargaAdjunto_Bll.Listar_Documentos(objCargaAdjuntos)
        End If
        For Each Item As DataGridViewRow In dtglistaDoc.Rows
            Item.Cells("SEL").Value = False
            Item.Cells("VERIMG").Value = My.Resources.eye
        Next

        Return dtglistaDoc.RowCount

    End Function



    Private Sub dtglistaDoc_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglistaDoc.CellContentDoubleClick
        Try
            Dim colname As String = ""
            Dim rowsel As Integer = 0
            Dim nomfile As String = ""
            Dim carpeta As String = ""
            Dim rutafinal As String = ""
            Dim ext As String = ""

            If dtglistaDoc.RowCount > 0 Then
                colname = dtglistaDoc.Columns.Item(dtglistaDoc.CurrentCell.ColumnIndex).Name
                rowsel = dtglistaDoc.CurrentRow.Index
                If colname = "VERIMG" Then
                    nomfile = dtglistaDoc.Rows(rowsel).Cells("TNMBAR").Value
                    carpeta = dtglistaDoc.Rows(rowsel).Cells("NMRGIM").Value
                    ext = dtglistaDoc.Rows(rowsel).Cells("TIPIMG").Value

                    rutafinal = Me.albumBucketName + "/" + Me.pCarpetaBucketDestino + "/" + carpeta
                    descargar_archivo_aws(rutafinal, nomfile, ext)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub subir_archivo_aws(ByVal rutaFile As String, ByVal nomFile As String, ByVal extFile As String, ByRef msgErrorAmazon As String, fileBytes() As Byte)

        Dim dt As DataTable = New DataTable
        Dim rutafinal As String = ""
        Dim carpeta As String = ""
        Dim status As String = ""
        Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos

        If Me.pNroImagen = 0 Then
            ''CREAR CARPETA
            objCargaAdjuntos.DSTIMG = "CLOUD"
            objCargaAdjuntos.TIPODC = pTablaRelacions.ToString.Trim  ' Me.TIPODC
            objCargaAdjuntos.CCLNTO = 0
            objCargaAdjuntos.CCMPN = pCodCompania
            objCargaAdjuntos.MMCAPL = pCarpetaBucketDestino
            objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            dt = objCargaAdjunto_Bll.crear_carpeta(objCargaAdjuntos)
            For Each row As DataRow In dt.Rows
                carpeta = row("NMRGIM").ToString
                status = row("STATUS").ToString
            Next
            pNroImagen = carpeta
            Guardar_Relacion_Tabla(carpeta)
            ''RELACIONAR DOCUMENTO 
        Else
            carpeta = Me.pNroImagen
        End If

        ''CREAR NOMBRE DEL DOCUMENTO
        objCargaAdjuntos.NMRGIM = carpeta
        objCargaAdjuntos.TIPIMG = extFile
        objCargaAdjuntos.TNMBAR = nomFile
        objCargaAdjuntos.TPFILE = ""
        objCargaAdjuntos.IMTVIM = Val("" & cbomotivo.SelectedValue).ToString.Trim
        objCargaAdjuntos.TOBS = txtref.Text
        objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName


        Dim opcion As String = cboOrigen.ComboBox.SelectedValue
        rutafinal = Me.albumBucketName + "/" + Me.pCarpetaBucketDestino + "/" + carpeta
        Dim response As New PutObjectResponse
        If opcion = "LC" Then


            Try

                Dim credentials As CognitoAWSCredentials = New CognitoAWSCredentials(
                          IdentityPoolId,
                          Amazon.RegionEndpoint.USEast1)
                Dim config As AmazonS3Config = New AmazonS3Config()
                config.RegionEndpoint = Amazon.RegionEndpoint.USEast1
                Dim client As AmazonS3Client = New AmazonS3Client(credentials, config)
                Dim putRequest As PutObjectRequest = New PutObjectRequest
                putRequest.BucketName = rutafinal
                putRequest.Key = nomFile
                putRequest.FilePath = rutaFile

                Amazon.AWSConfigs.AWSRegion = Me.bucketRegion
                response = client.PutObject(putRequest)

                Dim a As String = ""
            Catch amazonS3Exception As AmazonS3Exception
                msgErrorAmazon = amazonS3Exception.Message
            End Try

        End If
        If opcion = "WS" Then

            Dim oFile As New ProxyFileManagerAWS.FileResult
            oFile.FileData = fileBytes
            Dim oWSDocFileManager As New ProxyFileManagerAWS.WsFileManager
            Dim estado As String = oWSDocFileManager.CargarFileAWS(oFile, rutafinal, nomFile, Me.bucketRegion, IdentityPoolId)
            If estado = "OK" Then
                msgErrorAmazon = ""
            Else
                msgErrorAmazon = estado
            End If

        End If


        If msgErrorAmazon.Length = 0 Then

            status = objCargaAdjunto_Bll.agregar_documento(objCargaAdjuntos)
        End If


        txtref.Text = ""
        Me.pNroImagen = carpeta

        txtnro_imagen.Text = pNroImagen
        pDialog = True
    End Sub

    Private Function Valida_Archivo_Registrado(NMRGIM As Int64, TNMBAR As String) As Boolean
        Dim Respuesta As Boolean = False
        For Each Item As DataGridViewRow In dtglistaDoc.Rows
            If Item.Cells("NMRGIM").Value = NMRGIM And Item.Cells("TNMBAR").Value.ToString.Trim = TNMBAR Then
                Respuesta = True
            End If
        Next
        Return Respuesta
    End Function

    Private Sub eliminar_archiv_aws(ByVal rutafinal As String, ByVal nomFile As String)

        Dim msgElim As String = ""

        Dim opcion As String = cboOrigen.ComboBox.SelectedValue

        If opcion = "LC" Then

            Dim credentials As CognitoAWSCredentials = New CognitoAWSCredentials(IdentityPoolId, Amazon.RegionEndpoint.USEast1)
            Dim config As AmazonS3Config = New AmazonS3Config()
            config.RegionEndpoint = Amazon.RegionEndpoint.USEast1
            Dim client As AmazonS3Client = New AmazonS3Client(credentials, config)
            Dim deleteRequest As DeleteObjectRequest = New DeleteObjectRequest
            deleteRequest.BucketName = rutafinal
            deleteRequest.Key = nomFile

            Amazon.AWSConfigs.AWSRegion = Me.bucketRegion
            client.DeleteObject(deleteRequest)

        End If

        If opcion = "WS" Then

            Dim oWSDocFileManager As New ProxyFileManagerAWS.WsFileManager
            Dim estado As String = oWSDocFileManager.EliminarFileAWS(rutafinal, nomFile, Me.bucketRegion, IdentityPoolId)
            msgElim = estado

        End If




    End Sub

    Private Sub descargar_archivo_aws(ByVal rutafinal As String, ByVal nomFile As String, ByVal ext As String)

        Dim rutaSave As String = ""
        Dim opcion As String = cboOrigen.ComboBox.SelectedValue

        If opcion = "LC" Then

            Dim credentials As CognitoAWSCredentials = New CognitoAWSCredentials(IdentityPoolId, Amazon.RegionEndpoint.USEast1)
            Dim config As AmazonS3Config = New AmazonS3Config()
            config.RegionEndpoint = Amazon.RegionEndpoint.USEast1
            Dim client As AmazonS3Client = New AmazonS3Client(credentials, config)
            Amazon.AWSConfigs.AWSRegion = Me.bucketRegion

            Dim request As GetObjectRequest = New GetObjectRequest()
            request.BucketName = rutafinal
            request.Key = nomFile
            Dim response As GetObjectResponse = client.GetObject(request)
            SaveFileDialog1.DefaultExt = ext

            Dim ruta_alt As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & nomFile
            response.WriteResponseStreamToFile(ruta_alt)
            Help.ShowHelp(New Form(), ruta_alt)

        End If

        If opcion = "WS" Then
            Dim oWSDocFileManager As New ProxyFileManagerAWS.WsFileManager
            Dim ofileresult As New ProxyFileManagerAWS.FileResult
            ofileresult = oWSDocFileManager.getFileListAWS(rutafinal, nomFile, Me.bucketRegion, IdentityPoolId)
            Using fs As New System.IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & nomFile, System.IO.FileMode.Create)
                fs.Seek(0, System.IO.SeekOrigin.End)
                fs.Write(ofileresult.FileData, 0, ofileresult.FileData.Length)
                fs.Close()
                fs.Dispose()
            End Using
            'mostrando el archivo en el browser
            Help.ShowHelp(New Form(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & nomFile)


        End If




        'If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
        '    rutaSave = SaveFileDialog1.FileName
        '    response.WriteResponseStreamToFile(rutaSave)
        '    Help.ShowHelp(New Form(), rutaSave)
        'End If
        'MsgBox("Operaciòn Exitosa, se ha descargado el archivo en: " + rutaSave, MsgBoxStyle.Information, "Informaciòn")


    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            Dim msgErrorAmazon As String = ""
            Dim msgErrorCargaAmazon As String = ""
            lbladjuntar.Text = "...Iniciando carga..."

            Dim directorio_ok As String = ""
            Dim Lista_File_Repetidos As String = ""
            Dim Lista_File_No_Repetidos As String = ""
            Dim nomFile As String
            Dim extFile As String
            Dim openFileDialog1 As New OpenFileDialog
            openFileDialog1.InitialDirectory = directorio_ok
            openFileDialog1.Multiselect = True
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True
            If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If openFileDialog1.FileNames.Length <= 0 Then
                    Exit Sub
                End If


                For Each m_FileName As String In openFileDialog1.FileNames
                    Dim thisFile As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(m_FileName)
                    nomFile = thisFile.Name
                    If (nomFile.Length - thisFile.Extension.Length) > MaxTamanioNombreDoc Then
                        MessageBox.Show("Verificar tamaño máximo del nombre. [" & MaxTamanioNombreDoc & "]", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Next


                Dim CantAdjuntos As Integer = 0
                For Each m_FileName As String In openFileDialog1.FileNames


                    Dim thisFile As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(m_FileName)
                    nomFile = thisFile.Name
                    extFile = thisFile.Extension

                    Dim fileBytes() As Byte
                    fileBytes = System.IO.File.ReadAllBytes(thisFile.FullName)


                    If Valida_Archivo_Registrado(pNroImagen, nomFile) Then
                        Lista_File_Repetidos = Lista_File_Repetidos + nomFile + ","
                    Else
                        msgErrorCargaAmazon = ""
                        subir_archivo_aws(m_FileName, nomFile, extFile, msgErrorCargaAmazon, fileBytes)
                        CantAdjuntos = CantAdjuntos + 1
                        Lista_File_No_Repetidos = Lista_File_No_Repetidos + nomFile + ","

                        msgErrorAmazon = (msgErrorAmazon & Chr(10) & msgErrorCargaAmazon).Trim
                    End If

                Next
                If CantAdjuntos > 0 Then
                    lbladjuntar.Text = "...Carga completada..."
                Else
                    lbladjuntar.Text = "..."
                End If

                Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos
                objCargaAdjuntos.NMRGIM = pNroImagen
                Listar_Documentos(objCargaAdjuntos)


                If msgErrorAmazon.Length > 0 Then
                    MessageBox.Show(msgErrorAmazon, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If


        Catch ex As Exception
            lbladjuntar.Text = "..."
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            lbladjuntar.Text = "..."
            Dim nroRows As Integer = 0
            Dim rutafinal As String = ""
            Dim nomfile As String = ""
            Dim nroimagen As String
            Dim corrImagen As Integer = 0
            'Dim dt As DataTable = New DataTable
            Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos

            If HaySeleccionados() Then

                If MessageBox.Show("Esta seguro de eliminar el documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                For Each dr As DataGridViewRow In Me.dtglistaDoc.Rows
                    If Convert.ToBoolean(dr.Cells("Sel").Value) Then
                        nroimagen = dr.Cells("NMRGIM").Value
                        corrImagen = dr.Cells("NCRIMG").Value
                        nomfile = dr.Cells("TNMBAR").Value
                        rutafinal = albumBucketName + "/" + Me.pCarpetaBucketDestino + "/" + nroimagen

                        ''ELIMINAR ARCHIVO
                        objCargaAdjuntos.NMRGIM = nroimagen
                        objCargaAdjuntos.NCRIMG = corrImagen

                        objCargaAdjunto_Bll.eliminar_imagenes(objCargaAdjuntos)
                        ''ELIMINAR ARCHIVO BUCKET AWS
                        eliminar_archiv_aws(rutafinal, nomfile)

                    End If
                Next

                ''REFRESCAR GRILLA 

                objCargaAdjuntos.NMRGIM = Me.pNroImagen
                nroRows = Listar_Documentos(objCargaAdjuntos)

                txtref.Text = ""

                If nroRows = 0 Then
                    ''ELIMINAR CARPETA
                    Eliminar_Relacion_Tabla(pNroImagen)
                    Me.pNroImagen = 0
                End If


            End If
            txtnro_imagen.Text = pNroImagen
            pDialog = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HaySeleccionados() As Boolean

        dtglistaDoc.EndEdit()
        Dim intCont As Integer
        Dim HaySeleccionadosCliente As Boolean = False
        For intCont = 0 To dtglistaDoc.RowCount - 1
            If dtglistaDoc.Rows(intCont).Cells("Sel").Value = True Then
                HaySeleccionadosCliente = True
                Exit For
            End If
        Next
        Return HaySeleccionadosCliente
    End Function





    Private Function GetNroImagenActualizado()
        Dim objCargaAdjuntos As New CargaAdjuntos
        Dim oImagenBLL As New Imagen_BLL
        Dim NumImg As Decimal = 0
        Select Case pTablaRelacions
            Case Tabla_Relacion.RZSC03

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTSL = ListVariables("NRCTSL")
                objCargaAdjuntos.NRTFSV = ListVariables("NRTFSV")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZSC03(objCargaAdjuntos)

            Case Tabla_Relacion.RZTR05
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NOPRCN = ListVariables("NOPRCN")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZTR05(objCargaAdjuntos)


            Case Tabla_Relacion.RZTR76
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NLQCMB = ListVariables("NLQCMB")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZTR76(objCargaAdjuntos)

            Case Tabla_Relacion.RZST07
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NCSOTR = ListVariables("NCSOTR")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZST07(objCargaAdjuntos)

            Case Tabla_Relacion.RZOL65P
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NROPLT = ListVariables("NROPLT")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZOL65P(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL65I
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZOL65I(objCargaAdjuntos)



            Case Tabla_Relacion.RZOL67
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZOL67(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL65

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CPLNDV = ListVariables("CPLNDV")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                objCargaAdjuntos.NSEQIN = ListVariables("NSEQIN")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZOL65(objCargaAdjuntos)


            Case Tabla_Relacion.RZIM36

                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NGUIRM = ListVariables("NGUIRM")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZIM36(objCargaAdjuntos)

            Case Tabla_Relacion.RZSC53
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NROVLR = ListVariables("NROVLR")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZSC53(objCargaAdjuntos)



            Case Tabla_Relacion.RZSC58
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.TPCTRL = ListVariables("TPCTRL")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZSC58(objCargaAdjuntos)



            Case Tabla_Relacion.RZTR31
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NLQDCN = ListVariables("NLQDCN")
                NumImg = oImagenBLL.Get_Nro_Imagen_RZTR31(objCargaAdjuntos)


            Case Else
                btnSeleccionar.Enabled = False
                MessageBox.Show("Nro Imagen no actualizada.Tabla Relación no implementada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

        Return NumImg
    End Function


    Private Sub Guardar_Relacion_Tabla(NRO_IMAGEN As Decimal)
        Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos

        Select Case pTablaRelacions

            Case Tabla_Relacion.RZSC03
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTSL = ListVariables("NRCTSL")
                objCargaAdjuntos.NRTFSV = ListVariables("NRTFSV")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZSC03(objCargaAdjuntos)

            Case Tabla_Relacion.RZTR05

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NOPRCN = ListVariables("NOPRCN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZTR05(objCargaAdjuntos)

            Case Tabla_Relacion.RZTR76

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NLQCMB = ListVariables("NLQCMB")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZTR76(objCargaAdjuntos)

            Case Tabla_Relacion.RZST07

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NCSOTR = ListVariables("NCSOTR")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZST07(objCargaAdjuntos)

            Case Tabla_Relacion.RZOL65P

                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NROPLT = ListVariables("NROPLT")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZOL65P(objCargaAdjuntos)



            Case Tabla_Relacion.RZOL65I

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZOL65I(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL67

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZOL67(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL65


                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CPLNDV = ListVariables("CPLNDV")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                objCargaAdjuntos.NSEQIN = ListVariables("NSEQIN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZOL65(objCargaAdjuntos)


            Case Tabla_Relacion.RZIM36

                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NGUIRM = ListVariables("NGUIRM")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZIM36(objCargaAdjuntos)

            Case Tabla_Relacion.RZSC53

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NROVLR = ListVariables("NROVLR")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZSC53(objCargaAdjuntos)



            Case Tabla_Relacion.RZSC58

           
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.TPCTRL = ListVariables("TPCTRL")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZSC58(objCargaAdjuntos)



            Case Tabla_Relacion.RZTR31


                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")      
                objCargaAdjuntos.NLQDCN = ListVariables("NLQDCN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Guardar_relacion_RZTR31(objCargaAdjuntos)


             
            Case Else
                MessageBox.Show("Relación no guardada.Tabla Relación no implementada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

    End Sub
    Private Sub Eliminar_Relacion_Tabla(NRO_IMAGEN As Decimal)
        Dim objCargaAdjuntos As CargaAdjuntos = New CargaAdjuntos

        Select Case pTablaRelacions
            Case Tabla_Relacion.RZSC03

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTSL = ListVariables("NRCTSL")
                objCargaAdjuntos.NRTFSV = ListVariables("NRTFSV")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZSC03(objCargaAdjuntos)
            Case Tabla_Relacion.RZTR05

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NOPRCN = ListVariables("NOPRCN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZTR05(objCargaAdjuntos)

            Case Tabla_Relacion.RZTR76

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NLQCMB = ListVariables("NLQCMB")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZTR76(objCargaAdjuntos)

            Case Tabla_Relacion.RZST07

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NCSOTR = ListVariables("NCSOTR")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZST07(objCargaAdjuntos)



            Case Tabla_Relacion.RZOL65P

                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NROPLT = ListVariables("NROPLT")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZOL65P(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL65I

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZOL65I(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL67

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZOL67(objCargaAdjuntos)


            Case Tabla_Relacion.RZOL65

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.CDVSN = ListVariables("CDVSN")
                objCargaAdjuntos.CPLNDV = ListVariables("CPLNDV")
                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.CREFFW = ListVariables("CREFFW")
                objCargaAdjuntos.NSEQIN = ListVariables("NSEQIN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjuntos.CUSCRT = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
                objCargaAdjunto_Bll.Eliminar_Relacion_RZOL65(objCargaAdjuntos)


            Case Tabla_Relacion.RZIM36

                objCargaAdjuntos.CCLNT = ListVariables("CCLNT")
                objCargaAdjuntos.NGUIRM = ListVariables("NGUIRM")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZIM36(objCargaAdjuntos)


            Case Tabla_Relacion.RZSC53

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NROVLR = ListVariables("NROVLR")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZSC53(objCargaAdjuntos)


            Case Tabla_Relacion.RZSC58

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.TPCTRL = ListVariables("TPCTRL")
                objCargaAdjuntos.NRCTRL = ListVariables("NRCTRL")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZSC58(objCargaAdjuntos)


            Case Tabla_Relacion.RZTR31

                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NLQDCN = ListVariables("NLQDCN")
                objCargaAdjuntos.NMRGIM = NRO_IMAGEN
                objCargaAdjunto_Bll.Eliminar_Relacion_RZTR31(objCargaAdjuntos)

            Case Else
                MessageBox.Show("Relación no eliminada.Tabla Relación no implementada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZSC03(pCCMPN As String, pNRCTSL As Decimal, pNRTFSV As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NRCTSL") = pNRCTSL
        ListVariables("NRTFSV") = pNRTFSV
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZTR05(pCCMPN As String, pNOPRCN As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NOPRCN") = pNOPRCN  
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZTR76(pCCMPN As String, pNLQCMB As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NLQCMB") = pNLQCMB
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZST07(pCCMPN As String, pNCSOTR As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NCSOTR") = pNCSOTR
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZOL65P(pCCLNT As Decimal, pNROPLT As Decimal)
        ListVariables("CCLNT") = pCCLNT
        ListVariables("NROPLT") = pNROPLT
    End Sub


    Public Sub pAsignar_ParametroTablaRelacion_RZOL65I(pCCMPN As String, pCDVSN As String, pCCLNT As Decimal, pCREFFW As String)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("CDVSN") = pCDVSN
        ListVariables("CCLNT") = pCCLNT
        ListVariables("CREFFW") = pCREFFW
    End Sub
    Public Sub pAsignar_ParametroTablaRelacion_RZOL67(pCCMPN As String, pNRCTRL As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NRCTRL") = pNRCTRL
    End Sub


    Public Sub pAsignar_ParametroTablaRelacion_RZOL65(pCCMPN As String, pCDVSN As String, pCPLNDV As String, pCCLNT As Decimal, pCREFFW As String, pNSEQIN As String)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("CDVSN") = pCDVSN
        ListVariables("CPLNDV") = pCPLNDV
        ListVariables("CCLNT") = pCCLNT
        ListVariables("CREFFW") = pCREFFW
        ListVariables("NSEQIN") = pNSEQIN
    End Sub


    Public Sub pAsignar_ParametroTablaRelacion_RZIM36(pCCMPN As String, pCCLNT As Decimal, pNGUIRM As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("CCLNT") = pCCLNT
        ListVariables("NGUIRM") = pNGUIRM
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZSC53(pCCMPN As String, pNROVLR As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NROVLR") = pNROVLR
    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZSC58(pCCMPN As String, pTPCTRL As String, pNRCTRL As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("TPCTRL") = pTPCTRL
        ListVariables("NRCTRL") = pNRCTRL

    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZTR31(pCCMPN As String, pNLQDCN As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NLQDCN") = pNLQDCN
    End Sub





    Private chkAll As Boolean = False
    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        Try
            chkAll = Not chkAll

            For Each item As DataGridViewRow In dtglistaDoc.Rows
                item.Cells("Sel").Value = chkAll
            Next
            dtglistaDoc.EndEdit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class