

Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Imports System.Configuration

Public Class brIncidenciaEnvioEmail
    'Private oListCheckPointEnvio As New List(Of beIncidencias)
    'Private PNNESTDO As Decimal = 0
    'Private PNNESTDO_ULTIMO_MODIFICADO As Decimal = 0 'PARA COLOCAR EL ASTERISCO

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"
    Private _mailaccount As String = ""
    Private _mailpassword As String = ""

    Private _mailaccount_gmail As String = ""
    Private _mailpassword_gmail As String = ""
    Private _mailto_error As String = ""
    Private _CULUSA As String = ""
    Private oListDestinatario As New List(Of beDestinatario)
    Private TipoProceso As String = "SC_INCREG"


    Private _CCLNT As Decimal = 0

    Public Property MailAccount() As String
        Get
            Return _mailaccount
        End Get
        Set(ByVal value As String)
            _mailaccount = value
        End Set
    End Property

    Public Property Mailpassword() As String
        Get
            Return _mailpassword
        End Get
        Set(ByVal value As String)
            _mailpassword = value
        End Set
    End Property


    Public Property MailAccount_Gmail() As String
        Get
            Return _mailaccount_gmail
        End Get
        Set(ByVal value As String)
            _mailaccount_gmail = value
        End Set
    End Property

    Public Property MailPassword_Gmail() As String
        Get
            Return _mailpassword_gmail
        End Get
        Set(ByVal value As String)
            _mailpassword_gmail = value
        End Set
    End Property

    Public Property Mailto_Error() As String
        Get
            Return _mailto_error
        End Get
        Set(ByVal value As String)
            _mailto_error = value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    'Private Function FormatTipoProceso(ByVal Area As String, ByVal IncPara As Decimal, ByVal Negocio As String) As String
    '    Return "SC_IN" & Area & IncPara.ToString & Negocio.Trim
    'End Function

    Public Sub EnviarEmail_Incidencia(ByVal beIncidencias As beIncidencias)

        'Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Dim obeIncidencias As New beIncidencias
        Try

            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            'Dim FECHA_INCIAL As Int32 = 0
            'Dim obeIncidencias As New beIncidencias
            Dim Negocio As New daIncidenciaEnvioEmail
            obeIncidencias = Negocio.Envio_Email_Incidencia(beIncidencias)

            ' TipoProceso = "SC_INCREG" 'FormatTipoProceso(obeIncidencias.PSCARINC, obeIncidencias.PNCTPINC, obeIncidencias.PSCRGVTA)

            Dim odaEmbarque As New daIncidenciaEnvioEmail
            Dim odtDatosEmbarqueFinal As New DataTable
            Dim oclsEmailManager As New clsEmailManager
            Dim obeDestinatariosEnvio As New beDestinatario
            bodyemail = DatosCuerpoEnvio(obeIncidencias)
            Dim obeDestinatario As New beDestinatario
            obeDestinatario = BuscarDestinatarios(beIncidencias.PNCCLNT, beIncidencias.PSEMAIL)
            obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
            obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
            oclsEmailManager.MailAccount = Me.MailAccount
            oclsEmailManager.Mailpassword = Me.Mailpassword
            oclsEmailManager.MailBody = bodyemail
            oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
            oclsEmailManager.MailSubject = String.Format("RANSA: ({0}) Se ha registrado una incidencia", beIncidencias.PNCCLNT) ''MensajeAsuntoEmail(odtOrdenesCompra_X_Embarque, odtDatosEmbarqueFinal, obeListaCheckPointInicioFinal)
            If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                oclsEmailManager.SendMailProvider()
                'exito = 1
                'Else
                '    MsgBox("Correo no enviado. No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                'exito = 0
            End If
        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÓ UN ERROR EN EL ENVIO PARA EL CLIENTE " & beIncidencias.PNCCLNT
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "Error, Registro de Incidencias"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        'Return exito
    End Sub



    Private Function DatosCuerpoEnvio(ByVal obeIncidencias As beIncidencias) As String

        Dim Dato As String = ""

        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:14px' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append(obeIncidencias.PSTCMPCL)
        bodyemail.Append(" el ")
        bodyemail.Append(Now.ToString)
        'bodyemail.Append(" se registr&oacute; lo siguiente:")
        bodyemail.Append(" se ha registrado lo siguiente.")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        With obeIncidencias

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='15%'>")
            bodyemail.Append("Nro Incidencia:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PNNINCSI & " (Incidencia-" & .PSNIVEL & " )")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Área:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTDARINC)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Reportado por:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSREPORTADO)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Inc. para:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTTPINC)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Negocio:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTCRVTA)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Incidencia:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTINCSI)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Fecha Inc.")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.FechaRegistro & " " & .HoraRegistro)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Doc. Ref Cliente")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTRDCCL)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Descripción:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTINCDT)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Cantidad:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSCUNDCN)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Almacén")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTCMPAL)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Responsable:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSTIRALC)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td>")
            bodyemail.Append("Contacto:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PSPRSCNT)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")



        End With

        'bodyemail.Append(HTMLSalto)
        'bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Registrado por : ")
        bodyemail.Append(CULUSA)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function



    Private Function FHTML_RIGHT(ByVal cadena As String, ByVal Char_Total_Relleno As Int32, ByVal CharRelleno As String) As String
        Dim cadenaRetorno As String = cadena.PadRight(Char_Total_Relleno, CharRelleno).Replace(CharRelleno, HTMLEspacio)
        Return cadenaRetorno
    End Function

    Private Function ListaEmailDistintos(ByVal oList As List(Of beDestinatario)) As String
        Dim Tot_Destinatarios As Int32 = 0
        Dim STR_LISTA_EMAIL As String = ""
        Dim sbDestinatarios As New StringBuilder
        Dim CharSeparacion As String = ";"
        Dim ListTempEMAIL As New List(Of String)
        Dim FILA As Int32 = 0
        Dim EMAIL As String = ""
        Tot_Destinatarios = oList.Count
        ListTempEMAIL.Clear()
        For FILA = 0 To Tot_Destinatarios - 1
            EMAIL = oList(FILA).PSEMAILTO.Trim.ToLower
            If (EMAIL.Length <> 0) Then
                If (Not ListTempEMAIL.Contains(EMAIL)) Then
                    ListTempEMAIL.Add(EMAIL)
                    sbDestinatarios.Append(EMAIL)
                    sbDestinatarios.Append(CharSeparacion)
                End If
            End If
        Next
        STR_LISTA_EMAIL = sbDestinatarios.ToString.Trim
        If (STR_LISTA_EMAIL.Length > 0) Then
            STR_LISTA_EMAIL = STR_LISTA_EMAIL.Substring(0, STR_LISTA_EMAIL.LastIndexOf(CharSeparacion))
        End If
        Return STR_LISTA_EMAIL
    End Function


    Private Function FindDestinatarioCopia(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"
    End Function

    Private Function FindDestinatarioCliente(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIPPROC = TipoProceso AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"
    End Function

    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal, ByVal Email_Responsable As String) As beDestinatario

        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEmbarque As New daIncidenciaEnvioEmail
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT, TipoProceso)

        Dim beResponsable As New beDestinatario

        beResponsable.PSTIP_MAIL_DEST = "CLIENTE"
        beResponsable.PNCCLNT = 999999
        beResponsable.PSTIPPROC = TipoProceso
        beResponsable.PSEMAILTO = Email_Responsable

        oListDestinatario.Add(beResponsable)

        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio
    End Function

End Class
