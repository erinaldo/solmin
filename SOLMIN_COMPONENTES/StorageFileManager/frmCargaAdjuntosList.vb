Imports System
Imports Amazon.S3
Imports Amazon.S3.Model
Imports Amazon.AWSConfigs
Imports Amazon.AWSConfigsS3
Imports Amazon.CognitoIdentity
Imports System.Configuration

Public Class frmCargaAdjuntosList
    Private objCargaAdjunto_Bll As CargaAdjuntos_BL = New CargaAdjuntos_BL
    Public pCodCompania As String = ""
    Public pCarpetaBucketDestino As String = ""
    Private albumBucketName As String = ""
    Private bucketRegion As String = ""
    Private IdentityPoolId As String = ""
    Private ListVariables As New Hashtable
    Public pDialog As Boolean = False

    Public Enum Tabla_Relacion
        NEUTRO
        RZTR05_LIST
   
    End Enum


    Public pTablaRelacions As Tabla_Relacion = Tabla_Relacion.NEUTRO
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    

    Private Sub frmCargaAdjuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If pTablaRelacions = Tabla_Relacion.NEUTRO Then
                MessageBox.Show("Tabla Relación no asignada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
              
                Exit Sub
            End If
          

            Inicializar_AWS()

            Listar_Documentos()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Inicializar_AWS()

        Dim dt_bucket As New DataTable
        'dt_bucket = objCargaAdjunto_Bll.Get_Bucket_AWS()
        dt_bucket = objCargaAdjunto_Bll.Get_Bucket_AWS_APP2021()

        If dt_bucket.Rows.Count > 0 Then
            albumBucketName = ("" & dt_bucket.Rows(0)("BUCKET_AWS")).ToString.Trim
            bucketRegion = ("" & dt_bucket.Rows(0)("BUCKET_REGION")).ToString.Trim
            IdentityPoolId = ("" & dt_bucket.Rows(0)("BUCKET_IDENTITY_POOLID")).ToString.Trim
        Else
           
            MessageBox.Show("Ruta Bucket no configurada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
 

    End Sub

   

    Private Sub Listar_Documentos()
        dtglistaDoc.AutoGenerateColumns = False
        dtglistaDoc.DataSource = Nothing
        Select Case pTablaRelacions
            Case Tabla_Relacion.RZTR05_LIST
                Dim objCargaAdjuntos As New CargaAdjuntos
                objCargaAdjuntos.CCMPN = ListVariables("CCMPN")
                objCargaAdjuntos.NOPRCN = ListVariables("NOPRCN")
                dtglistaDoc.DataSource = objCargaAdjunto_Bll.Listar_Documentos_List_RZTR05(objCargaAdjuntos)
          
        End Select


    End Sub



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


    Private Sub descargar_archivo_aws(ByVal rutafinal As String, ByVal nomFile As String, ByVal ext As String)

        Dim rutaSave As String = ""
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

      

    End Sub

    Public Sub pAsignar_ParametroTablaRelacion_RZTR05(pCCMPN As String, pNOPRCN As Decimal)
        ListVariables("CCMPN") = pCCMPN
        ListVariables("NOPRCN") = pNOPRCN
    End Sub

    

   

End Class