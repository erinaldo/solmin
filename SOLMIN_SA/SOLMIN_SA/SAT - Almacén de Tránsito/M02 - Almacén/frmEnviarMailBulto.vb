Imports System.Text
Imports System.IO
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
Imports RANSA.Controls.Email
Imports Ransa.NEGO.SendFileToEMail
Imports System.Web.Mail
Imports System.IO.Compression




Public Class frmEnviarMailBulto
    Dim LisArchivos As New List(Of String)

    Dim Body As String = ""
    Private intCCLNT As Integer = 0
    Private strCREFFW As String = ""
    Private strCCMPN As String = ""
    Private strCDVSN As String = ""
    Private dblCPLNDV As Double = 0
    Private dblNSEQIN As Double = 0

    Public oListEmail As New List(Of beBulto)

    Public WriteOnly Property pCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    Public WriteOnly Property pCodigoRecepcion_CREFFW() As String
        Set(ByVal value As String)
            strCREFFW = value
        End Set
    End Property

    Public WriteOnly Property pCodigoCompania_CCMPN() As String
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoDivision_CDVSN() As String
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoPlanta_CPLNDV() As String
        Set(ByVal value As String)
            dblCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property pNrCorrelativo_NSEQIN() As String
        Set(ByVal value As String)
            dblNSEQIN = value
        End Set
    End Property

    Dim objBulto As New beBulto
    Private Sub frmEnviarMailBulto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        objBulto.PSCCMPN = strCCMPN
        objBulto.PSCDVSN = strCDVSN
        objBulto.PNCPLNDV = dblCPLNDV
        objBulto.PNCCLNT = intCCLNT
        objBulto.PSCREFFW = strCREFFW
        objBulto.PNNSEQIN = dblNSEQIN

        CargarDatosCorreo(1)
        CargarDatosCorreo(2)
        CargarAsuntoEmail()
        CargarDocAdjuntos()
        pReporteStockProductoR01()


    End Sub

    Public Sub CargarDatosCorreo(ByVal TipoCorreo As Integer)

        Dim olbebeBulto As New List(Of beBulto)
        Dim obrBulto As New brBulto

        If TipoCorreo = 1 Then ' destinatario Para
            objBulto.PNTIPPROC = 1
            olbebeBulto = obrBulto.ObtenerCorreosPara(objBulto)

            For i As Integer = 0 To olbebeBulto.Count - 1
                txtDestinatario.Text = txtDestinatario.Text & Trim(olbebeBulto.Item(i).PSemailto) & ";"
            Next i

        ElseIf TipoCorreo = 2 Then ' Destinatario Copia
            objBulto.PNTIPPROC = 2

            olbebeBulto = obrBulto.ObtenerCorreosPara(objBulto)

            For i As Integer = 0 To olbebeBulto.Count - 1
                txtCC.Text = txtCC.Text & Trim(olbebeBulto.Item(i).PSemailto) & ";"
            Next i
        End If
    End Sub

    Public Sub CargarAsuntoEmail()

        Dim olbebeBulto As New List(Of beBulto)
        Dim obrBulto As New brBulto

        olbebeBulto = obrBulto.ObtenerCorreosAsunto(objBulto)
        txtasunto.Text = Trim(olbebeBulto.Item(0).PSNORCML) & "-" & Trim(olbebeBulto.Item(0).PSTPRVCL) & "-" & Trim(olbebeBulto.Item(0).PSNGRPRV)

    End Sub

    Public Sub CargarDocAdjuntos()
        Dim FullpathOld As String = ""
        Dim FullpathNew As String = ""
        Dim size As Long

        Dim olbebeBulto As New List(Of beBulto)
        Dim obrBulto As New brBulto
        olbebeBulto = obrBulto.ObtenerCorreosDocAdjunto(objBulto)

        Dim BtnButtonSpe As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Dim ext As String = ""

        Dim objAppConfig As cAppConfig = New cAppConfig
        For i As Integer = 0 To olbebeBulto.Count - 1

            If Trim(olbebeBulto.Item(i).PSTNMBAR) <> "" Then
                FullpathOld = objAppConfig.GetValue("RutaImagen", GetType(System.String)) & olbebeBulto.Item(i).PSNMRGIM & "\" & Trim(olbebeBulto.Item(i).PSTNMBAR)
                FullpathNew = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Trim(olbebeBulto.Item(i).PSTNMBAR)
              
                '  ext = System.IO.Path.GetExtension(objAppConfig.GetValue("RutaImagen", GetType(System.String)) & olbebeBulto.Item(i).PSNMRGIM & "\" & Trim(olbebeBulto.Item(i).PSTNMBAR))
                
                If DescargarImagen(FullpathOld, FullpathNew) Then

                    Dim oFileInfo As New IO.FileInfo(FullpathNew)
                    ext = oFileInfo.Extension
                    size = oFileInfo.Length
                    oFileInfo = Nothing

                    If size > 2000000 Then
                        ComprimirArchivo(FullpathNew, FullpathNew.Replace(ext, ".zip"))
                        FullpathNew = FullpathNew.Replace(ext, ".zip")
                    End If
                    LisArchivos.Add(FullpathNew)
                    'imagen
                    BtnButtonSpe = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny

                    BtnButtonSpe.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
                    If ext.ToUpper = ".PDF" Then
                        BtnButtonSpe.Image = Global.SOLMIN_SA.My.Resources.Resources.PDF_18

                    ElseIf ext.ToUpper = ".JPG" Or ext = ".PNG" Or ext = ".GIF" Then
                        BtnButtonSpe.Image = My.Resources.image_star
                    ElseIf ext.ToUpper = ".XLS" Or ext.ToUpper = ".XLSX" Then
                        BtnButtonSpe.Image = My.Resources.excelicon
                    Else
                        BtnButtonSpe.Image = My.Resources.text_block
                    End If

                    BtnButtonSpe.Text = Trim(olbebeBulto.Item(i).PSTNMBAR) & " (" & Math.Round((size / 1024) / 1024, 2) & " MB);"
                    Me.txtDocAdjunto.ButtonSpecs.Add(BtnButtonSpe)
                Else
                    MsgBox("No se pudo adjuntar la Imagen : " & Trim(olbebeBulto.Item(i).PSTNMBAR), MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Next i
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub spBtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spBtnEnviar.Click

        Try
            If Not WrkCorreo.IsBusy Then
                'ModoAccion = "C" ' el modo es cargarndo 

                'CuPreload = New UsrPreload(DgvGuiaRecepcion)
                'DgvGuiaRecepcion.Controls.Add(CuPreload)
                'CuPreload.ResumeLayout(True)
                'CuPreload.Refresh()
                'CuPreload.BringToFront()
                'CuPreload.Size = New Size(CuPreload.Size)
                CheckForIllegalCrossThreadCalls = False 'para que se pueda accceder a otro controles 
                Animacion.Visible = True
                spBtnEnviar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                WrkCorreo.RunWorkerAsync() ' inicia el trabajo en segundo plano
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            spBtnEnviar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        End Try



    End Sub


    Public Function Enviar_Email_Requerimiento_Servicio_Notificacion() As Int32 'ByVal NUMREQT As Decimal, ByVal CCMPN As String, ByVal EMAIL_RESP As String) As Int32

        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Dim Destinatarios As String = ""
        Dim Copia As String = ""
        Try
            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0
            Dim odtDatosEmbarqueFinal As New DataTable
            Dim oclsEmailManager As New clsEmailManager

            Dim objAppConfig As cAppConfig = New cAppConfig

            oclsEmailManager.MailAccount = objAppConfig.GetValue("MailFrom", GetType(System.String))
            oclsEmailManager.Mailpassword = objAppConfig.GetValue("MailFromClave", GetType(System.String))

            If Trim(TxtObs.Text) <> "" Then

                Dim BodyObs As String = ""

                BodyObs = " <table width='671' border='0'>" _
                  & "<tr>" _
                  & "<td width='32'><b>Observación.</b></td>" _
                   & "<td width='95'>&nbsp;</td>" _
                   & "<td width='62'>&nbsp;</td>" _
                   & "<td width='75'>&nbsp;</td>" _
                   & "<td width='74'>&nbsp;</td>" _
                   & "<td width='176'>&nbsp;</td>" _
                   & "<td width='111'>&nbsp;</td>" _
                  & "</tr><tr><td>&nbsp;</td>" _
                   & "<td colspan='6'> " & TxtObs.Text & "</td>" _
              & "</tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td>" _
                & "<td>&nbsp;</td> <td>&nbsp;</td></tr><table>"

                Body = Body & BodyObs
            End If

            oclsEmailManager.MailBody = Body

            If txtDestinatario.Text <> "" Then
                Dim s As String = txtDestinatario.Text.Substring(Len(txtDestinatario.Text) - 1, 1)
                If s = ";" Then
                    Destinatarios = txtDestinatario.Text.Substring(0, Len(txtDestinatario.Text) - 1) 'obeDestinatariosEnvio.PSEMAILTO
                Else
                    Destinatarios = txtDestinatario.Text  'obeDestinatariosEnvio.PSEMAILTO
                End If
                oclsEmailManager.MailNotification = Destinatarios

            End If
            If txtCC.Text <> "" Then
                Dim s As String = txtCC.Text.Substring(Len(txtCC.Text) - 1, 1)
                If s = ";" Then
                    Copia = txtCC.Text.Substring(0, Len(txtCC.Text) - 1) 'obeDestinatariosEnvio.PSEMAILBC
                Else
                    Copia = txtCC.Text
                End If
                oclsEmailManager.mailnotificationBCC = Copia

            End If

            oclsEmailManager.MailSubject = txtasunto.Text

            For i As Integer = 0 To LisArchivos.Count - 1
                oclsEmailManager.Attachmentcollection.Add(LisArchivos.Item(i))
            Next i

            oclsEmailManager.EnableSSL = True

            If (txtDestinatario.Text <> "") And (txtCC.Text <> "") Then

                If Body = "" Then

                    If MessageBox.Show("Desea enviar un Mensaje Vacio", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = 6 Then
                        oclsEmailManager.SendMailProvider()

                        exito = 1
                        Animacion.Visible = False

                        MsgBox("Mensaje enviado Satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                        Me.Close()
                    End If
                Else
                    oclsEmailManager.SendMailProvider()
                    ' Enviar(Destinatarios, Copia, Body, txtasunto.Text)

                    exito = 1
                    Animacion.Visible = False
                    MsgBox("Mensaje enviado Satisfactoriamente.", MsgBoxStyle.Information, "Aviso")

                    Me.Close()
                End If
            Else
                Animacion.Visible = False
                MsgBox("Correo no enviado.No se encontró destinatarios .", MsgBoxStyle.Critical, "Aviso")
                exito = 0
            End If
        Catch ex As Exception
            Animacion.Visible = False
            MsgBox("Correo no enviado.", MsgBoxStyle.Critical, "Aviso")
            spBtnEnviar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        End Try
        Return exito
    End Function

    Public Sub SubGenerarBody(ByVal dt As DataTable)
        Dim qmtanc As Decimal = "0.00"
        Dim qvolmr As Decimal = "0.00"
        Dim qpsomr As Decimal = "0.00"
        Body = ""
        Dim GridBody As String = ""
        Dim BodyObs As String = ""
        Body = " <table width='671' border='0'>" _
      & "<tr>" _
      & "<td width='32'>Sres.</td>" _
       & "<td width='95'>&nbsp;</td>" _
       & "<td width='62'>&nbsp;</td>" _
       & "<td width='75'>&nbsp;</td>" _
       & "<td width='74'>&nbsp;</td>" _
       & "<td width='176'>&nbsp;</td>" _
       & "<td width='111'>&nbsp;</td>" _
      & "</tr><tr><td>&nbsp;</td>" _
       & "<td colspan='6'> Hoy :  " & Now.Date & "  Se recepcionó el siguiente material :<b>" & dt.Rows(0)("Ttpomr").ToString & "</b></td>" _
  & "</tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td>" _
    & "<td>&nbsp;</td> <td>&nbsp;</td></tr>" _
   & "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" _
  & "<tr><td>&nbsp;</td><td colspan='6'><table width='100%' border=1 cellpadding='0' cellspacing='0' bordercolor='#000000'>" _
      & "<tr>" _
        & "<td width='136' bgcolor='#79DEFF'><div align='center' >Nro de Bulto</div></td>" _
        & "<td width='72' bgcolor='#79DEFF'><div align='center' >Largo (mts)</div></td>" _
        & "<td width='90' bgcolor='#79DEFF'><div align='center' >Ancho (mts)</div></td>" _
        & "<td width='81' bgcolor='#79DEFF'><div align='center' >Alto (mts)</div></td>" _
        & "<td width='72' bgcolor='#79DEFF'><div align='center' >M3</div></td>" _
        & "<td width='130' bgcolor='#79DEFF'><div align='center' >Peso Total Kg.</div></td>" _
        & "</tr> "

        For i As Integer = 0 To dt.Rows.Count - 1

            qmtanc = dt.Rows(i)("qmtanc").ToString
            qvolmr = dt.Rows(i)("qvolmr").ToString
            qpsomr = dt.Rows(i)("qpsomr").ToString

            GridBody = GridBody & "<tr><td align='center' >" & dt.Rows(i)("qctpqt").ToString _
                     & "</Td><td align='center'>" & Format("##,##0.00", dt.Rows(i)("qmtlrg").ToString) _
                     & "</Td><td align='center' >" & Math.Round(qmtanc, 2) _
                     & "</Td><td align='center' >" & Format("##,##0.00", dt.Rows(i)("qmtalt").ToString) _
                     & "</Td><td align='center' >" & Math.Round(qvolmr, 2) _
                     & "</Td><td align='center' >" & Math.Round(qpsomr, 2) & "</td></tr>"
        Next i

        Body = Body & GridBody & "</table></td></tr>" _
                 & "<tr><td>&nbsp;</td> " _
                 & "<td colspan='6'>&nbsp;</td>" _
                 & "<table bordercolor='#000000' width='200' border='1'  cellpadding='0' cellspacing='0' align='right'><tr><td width='74' bgcolor='#79DEFF'> <div align='center'>M2</div></td>" _
                 & " <td width='110' align='center' >" & dt.Rows(0)("QAROCP").ToString & "</td></tr></table>" _
                 & "</tr><tr><td>&nbsp;</td><td colspan='6'>" _
                 & "</td></tr></table>"
    End Sub


    Private Sub pReporteStockProductoR01()
        Dim DtReporte As New DataTable
        Dim objTemp As TipoDato_ResultaReporte

        Dim rptTemp = New rptbodyemail
        Dim intIsInventarioActual As Integer = 1
        Dim strMensaje As String = String.Empty
     
        Dim oReporteSDS As New brReporteDS

        DtReporte = oReporteSDS.fdtBodyEmail(objBulto.PSCCMPN, objBulto.PSCDVSN, objBulto.PNCPLNDV, objBulto.PNCCLNT, objBulto.PSCREFFW, objBulto.PNNSEQIN)

        If DtReporte.Rows.Count > 0 Then
            SubGenerarBody(DtReporte)
        End If

        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'asignar los datos al reporte 
        DtReporte.TableName = "DtBulto"
        rptTemp.SetDataSource(DtReporte)

        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = rptTemp

        crvReporte.ReportSource = objTemp.pReporte
    End Sub

    Private Sub SpBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpBtnCancelar.Click
        Me.Close()
    End Sub

    Public Function DescargarImagen(ByVal Ruta As String, ByVal nombArchivo As String) As Boolean
        Dim rw As Boolean = False

        Try

            If Not File.Exists(nombArchivo) Then
                My.Computer.Network.DownloadFile(Ruta, nombArchivo)
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub Enviar(ByVal Destinatario As String, ByVal Copia As String, ByVal body As String, ByVal asunto As String)

        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim adjunto As System.Net.Mail.Attachment
        Dim objAppConfig As cAppConfig = New cAppConfig
        With smtp
            .Timeout = 500000
            .Port = 25
            .Host = "outlook.office365.com"
            .Credentials = New System.Net.NetworkCredential(objAppConfig.GetValue("MailFrom", GetType(System.String)), objAppConfig.GetValue("MailFromClave", GetType(System.String)))
            .EnableSsl = True
        End With

        For i As Integer = 0 To LisArchivos.Count - 1

            adjunto = New System.Net.Mail.Attachment(LisArchivos.Item(i))
            correo.Attachments.Add(adjunto)

        Next i

        With correo
            .From = New System.Net.Mail.MailAddress(objAppConfig.GetValue("MailFrom", GetType(System.String)))
            .To.Add(Destinatario)
            .CC.Add(Copia)
            .Subject = asunto
            .Body = body
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.High
            .Attachments.Add(adjunto)
        End With

        Try
            smtp.Send(correo)
            MessageBox.Show("Su mensaje de correo ha sido enviado.", _
                            "Correo enviado", _
                            MessageBoxButtons.OK)
            Animacion.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, _
                            "Error al enviar correo", _
                            MessageBoxButtons.OK)

            Animacion.Visible = False

        End Try


    End Sub

    Public Sub ComprimirArchivo(ByVal PathAchivo As String, ByVal PathDestino As String)

        Try
            Dim zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile()
            zip.AddFile(PathAchivo, "")
            zip.Save(PathDestino)

        Catch ex As Exception

        End Try

    End Sub


    Private Sub WrkCorreo_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles WrkCorreo.DoWork

        If WrkCorreo.IsBusy Then
            Enviar_Email_Requerimiento_Servicio_Notificacion()
        End If

    End Sub

    Private Sub WrkCorreo_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles WrkCorreo.RunWorkerCompleted
        Animacion.Visible = False
        spBtnEnviar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub
End Class
