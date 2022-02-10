Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web.Mail
Imports System.Configuration
Imports System.Text
Imports Ransa.Utilitario
Imports System.Web
Imports System.IO

Imports System.Security.Cryptography


Public Class frmEnvioCorreoDocumentos

#Region "Declaracion de Variables"

    Public oDtDocumentos As New DataTable
    Private oCuentaCorrienteNeg As New clsCuentaCorriente
    Private oSeguimiento As New clsSeguimientoDocumentos
    Private beSeguimiento As SeguimientoDocumentos
    Public sSeguimiento As String = String.Empty
    Public nSeguimiento As Decimal = 0
    Public sFecha As String = String.Empty
    Public sHora As String = String.Empty
    Public sResponsable As String = String.Empty
    Public sObs As String = String.Empty
    Public sUsuario As String = String.Empty
    Public sCompania As String = String.Empty
    Private nCorrEnvio As Integer = 0

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"

#End Region

#Region "Eventos de Control"

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

       
        If txtPara.Text.Trim.Split(";").Length > 1 Then
            MessageBox.Show("Solo puede enviar a un Destinatario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtPara.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar un correo destino", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If



        



        Dim MailsAdress() As String = txtPara.Text.Split(";")

        For i As Integer = 0 To MailsAdress.Length - 1
            If Not Ransa.Utilitario.HelpClass.validar_Mail(MailsAdress(i)) Then
                MessageBox.Show("Ingrese un Mail destino válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next


        If txtCopia.Text.Trim.Length > 0 Then
            Dim MailsCo() As String = txtCopia.Text.Split(";")
            For i As Integer = 0 To MailsCo.Length - 1
                If Not Ransa.Utilitario.HelpClass.validar_Mail(MailsCo(i)) Then
                    MessageBox.Show("Ingrese un Mail Copia válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If




        ActualizarDocumentos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#End Region


#Region "Procedimientos y funciones"

   

    Private Sub ActualizarDocumentos()
        Dim clsCorrelativo As New clsCuentaCorriente

        nCorrEnvio = clsCorrelativo.ObtenerCorrelativo("SMTD01").Rows(0).Item("NULCTR")
        If SendMail() Then
            DialogResult = Windows.Forms.DialogResult.Yes
        Else
            MessageBox.Show("Error al Enviar Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For Each dr As DataRow In oDtDocumentos.Rows
            beSeguimiento = New SeguimientoDocumentos

            beSeguimiento.CCMPN = dr("CCMPN")
            beSeguimiento.CTPODC = dr("CodTipo")
            beSeguimiento.NDCCTC = dr("Numero")
            beSeguimiento.CDSGDC = nSeguimiento
            beSeguimiento.FDSGDC = HelpClass.CtypeDate(sFecha)
            beSeguimiento.HDSGDC = obtenerFormatoHora(sHora)
            beSeguimiento.URSPDC = sResponsable
            beSeguimiento.TOBSSG = sObs
            beSeguimiento.CUSCRT = ConfigurationWizard.UserName
            beSeguimiento.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            beSeguimiento.NRSGDC = nCorrEnvio
            If oSeguimiento.InsertaSeguimientoDocumentos(beSeguimiento) = 0 Then
                MessageBox.Show("Error al Grabar Nro " & dr("Numero"))
            End If


        Next



    End Sub

    Private Function SendMail() As Boolean

        Dim strServer As String = ConfigurationManager.AppSettings("ServerMail").ToString()
        Dim strMailCo As String = ConfigurationManager.AppSettings("MailCO").ToString()
        Dim strMailFrom As String = ConfigurationManager.AppSettings("MailFrom").ToString()
        Dim strMailFromClave As String = ConfigurationManager.AppSettings("MailFromClave").ToString()
        Dim strAdress As String = txtPara.Text.Trim


        If Not Ransa.Utilitario.HelpClass.flSendMail(strServer, strMailCo, strMailFrom, strMailFromClave, _
        strAdress, "", txtAsunto.Text.Trim, CrearDatosCuerpoOperacion(True), True) Then
            MessageBox.Show("Error al Enviar Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        Else
            If txtCopia.Text.Trim.Length > 0 Then
                Ransa.Utilitario.HelpClass.flSendMail(strServer, "", strMailFrom, strMailFromClave, _
                                    txtCopia.Text.Trim, "", txtAsunto.Text.Trim, CrearDatosCuerpoOperacion(False), True)
            End If

        End If

        Return True

    End Function

    Private Function DevuelveArea(ByVal nCodigo As Integer) As String
        Select Case nCodigo
            Case 1
                Return "al area "
            Case 2, 3
                Return "al area de "
            Case 4
                Return "al "
        End Select

        Return ""
    End Function

    Private Function obtenerFormatoHora(ByVal psHora As String) As Decimal
        Dim Hora As String
        Hora = Now.Hour.ToString.ToString.PadLeft(2, "0") & Now.Minute.ToString.ToString.PadLeft(2, "0") & Now.Second.ToString.ToString.PadLeft(2, "0")

        If psHora.Trim.Equals(":") Then
            Return Hora
        Else
            Return psHora.Substring(0, 2) & psHora.Substring(3, 2) & Now.Second.ToString.PadLeft(2, "0")
        End If
    End Function



    Private Function CrearDatosCuerpoOperacion(ByVal bolTipoUrl As Boolean) As String

        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'; font-weight: bold>")
        bodyemail.Append("<b> Sres. </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5' ; font-weight: bold>")
        bodyemail.Append("El usuario <b> " & sUsuario & " </b>, ha transferido" & IIf(nSeguimiento = 1 Or 4, " al ", " a ") & "  <b> " & sSeguimiento & " los siguientes Documentos:" & " </b> ")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Compañia </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & oDtDocumentos.Rows(0).Item("TCMPCM"))
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Fecha </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sFecha)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Hora </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sHora)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Responsable </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sResponsable)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Observaci&oacute;n </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sObs)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='9'>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=50%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Tipo </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Número </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Código </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Cliente </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Fecha </b>")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Moneda </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:right'; font-weight: bold>")
        bodyemail.Append("<b> Soles </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:right'; font-weight: bold>")
        bodyemail.Append("<b> Dolares </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Seguimiento Origen </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")



        Dim Soles As String = String.Empty
        Dim Dolares As String = String.Empty

        For Each dr As DataRow In oDtDocumentos.Rows
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Tipo").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Numero").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Codigo").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Cliente").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Fecha").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("Moneda").ToString)
            bodyemail.Append("</td>")

            Soles = Math.Round(dr("Soles"), 2).ToString.PadLeft(10, " ")
            Dolares = Math.Round(dr("Dolares"), 2).ToString.PadLeft(10, " ")

            bodyemail.Append("<td style='text-align:right'>")
            bodyemail.Append(Soles.ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:right'>")
            bodyemail.Append(Dolares.ToString)
            bodyemail.Append("</td>")
             
            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("TDSGDC").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("</tr>")
        Next

        If bolTipoUrl Then
            Dim strCodigo As String = nCorrEnvio.ToString
            Dim strUrl As String = System.Configuration.ConfigurationSettings.AppSettings("url").ToString()
            strCodigo = HttpUtility.UrlEncode(Encrypt(strCodigo, "SoloClave"))

            strUrl = strUrl & "?IDAPLICACION=ALMACEN&IDOPCION=OPT6x&x_launcher=yes&from_portal=false&Codigo=" & strCodigo

            bodyemail.Append("<td colspan='5'; font-weight: bold>")
            bodyemail.Append("<a href='" & strUrl & "' target='_blank'  onclick='window.open(this.href, this.target, null,'height=250, width=250,status= no, resizable= no, scrollbars=no, toolbar=no,location=no,menubar=no '); return false;'>Confirmar</a>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")
        End If


        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString.Trim
    End Function

#End Region

#Region "Encrypt"

#End Region


    Private Shared key() As Byte = {}
    Private Shared IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF, &H80, &HFE}

    Private Function ExtrarLeft(ByVal str As String, ByVal Length As Integer) As String
        Return str.Substring(0, Length)
    End Function
    Private Function Encrypt(ByVal stringToEncrypt As String, _
    ByVal SEncryptionKey As String) As String
        Try
            key = System.Text.Encoding.UTF8.GetBytes(ExtrarLeft(SEncryptionKey, 8))
            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes( _
                stringToEncrypt)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), _
                  CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch e As Exception
            Return e.Message
        End Try
    End Function


    Private Sub frmEnvioCorreoDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = CrearDatosCuerpoOperacion(False)
    End Sub
End Class
