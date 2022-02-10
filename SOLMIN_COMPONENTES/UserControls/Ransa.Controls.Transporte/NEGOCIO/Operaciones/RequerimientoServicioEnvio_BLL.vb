
Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Imports System.Configuration

Public Class RequerimientoServicioEnvio_BLL

    Private oListCheckPointEnvio As New List(Of RequerimientoServicio)
    Private PNNESTDO As Decimal = 0
    Private PNNESTDO_ULTIMO_MODIFICADO As Decimal = 0 'PARA COLOCAR EL ASTERISCO

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

    Private TipoProceso As String = "ST_REQSERV"

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


    Public Function EnviarEmail_RequerimientoServicio(ByVal NUMREQT As Decimal, ByVal CCMPN As String) As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Dim Entidad As New RequerimientoServicio

        Try

            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0

            Dim ReqServ As New RequerimientoServicio

            Dim Negocio As New RequerimientoServicioEnvio_DAL

            Entidad = Negocio.Envio_Email_Requerimiento_Servicio(NUMREQT, CCMPN)

            Dim odaEmbarque As New RequerimientoServicioEnvio_DAL
            Dim odtDatosEmbarqueFinal As New DataTable
            Dim oclsEmailManager As New clsEmailManager
            Dim obeDestinatariosEnvio As New beDestinatario
            bodyemail = DatosCuerpoEnvioChekPoint(Entidad)
            Dim obeDestinatario As New beDestinatario
            obeDestinatario = BuscarDestinatarios(Entidad.CCLNT)
            obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
            obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
            oclsEmailManager.MailAccount = Me.MailAccount
            oclsEmailManager.Mailpassword = Me.Mailpassword
            oclsEmailManager.MailBody = bodyemail
            oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
            oclsEmailManager.MailSubject = String.Format("RANSA: ({0}) Requerimiento de Unidad Nro {1}", Entidad.CCLNT, Entidad.NUMREQT) ''MensajeAsuntoEmail(odtOrdenesCompra_X_Embarque, odtDatosEmbarqueFinal, obeListaCheckPointInicioFinal)
            If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                oclsEmailManager.SendMailProvider()
                exito = 1
            Else
                MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                exito = 0
            End If


        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO PARA EL CLIENTE " & Entidad.CCLNT
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "REQUERIMIENTO SERVICIO-ERROR ENVIO REQUERIMIENTO"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        Return exito
    End Function



    Private Function DatosCuerpoEnvioChekPoint(ByVal Entidad As RequerimientoServicio) As String

        Dim Dato As String = ""

        Dim Lista As New List(Of Dimensiones)

        Dim ObjDimensiones As New Dimensiones
        Dim objDimensiones_BLL As New Dimensiones_BLL
        With ObjDimensiones
            .NUMREQT = Entidad.NUMREQT
            .CCMPN = Entidad.CCMPN
        End With

        Lista = objDimensiones_BLL.fListar_Dimensiones(ObjDimensiones)

        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table style='font-size:10px;font-family:Arial' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append(Entidad.CCLNT_S)
        bodyemail.Append(" el ")
        bodyemail.Append(Now.ToString)
        bodyemail.Append(" se registr&oacute; lo siguiente:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='3' align='center'>")
        bodyemail.Append("<b>SOLICITUD DE REQUERIMIENTO</b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        With Entidad

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Nro Requerimiento:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            ''bodyemail.Append(.NUMREQT & " (" & .TIPSRV_S & " - " & .SPRSTR_S & " )")
            bodyemail.Append(.NUMREQT & " (" & .TNMMDT & " - " & .SPRSTR_S & " )")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Fecha de requerimiento:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.FECREQ_S & "  " & .HRAREQ_S)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Fecha para atención:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.FCHATN_D & "  " & .HRAATN_D)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Cliente Operación:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.CCLNT_S)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Cliente Facturación:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(Entidad.CCLNFC_S)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Doc Referencia:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.REFDO1)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Contacto:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.PRSCNT.ToString.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Responsable:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.TIRALC.ToString.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("O/S TRANSPORTE:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.NORSRT)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("O/S AGENCIA RANSA:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.NDCORM)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Punto de Carga:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.TDRCOR.ToString.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Punto de Descarga:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.TDRENT.ToString.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Tipo de Unidad:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.CUNDVH_D)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Mercader&iacute;a")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.TOBERV.ToString.Trim)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Peso Total(Kg)")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.QPSOMR)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Observaciones:")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(.TOBS)
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='22%'>")
            bodyemail.Append("Medidas de c/Pieza")
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("</table>")

            bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td colspan='5'>")

            bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            If Lista.Count > 0 Then 'dimensiones

                bodyemail.Append("<tr>")
                bodyemail.Append("<td width='30%'>")
                bodyemail.Append("Descripci&oacute;n")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Largo(m)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Ancho(m)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Alto(m)")
                bodyemail.Append("</td>")
                bodyemail.Append("<td width='10%'>")
                bodyemail.Append("Peso(Kg)")
                bodyemail.Append("</td>")
                bodyemail.Append("</tr>")

                For Each dimension As Dimensiones In Lista

                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td width='30%'>")
                    bodyemail.Append(dimension.TDITES)
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(dimension.QMTLRG)
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(dimension.QMTANC)
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(dimension.QMTALT)
                    bodyemail.Append("</td>")
                    bodyemail.Append("<td width='10%'>")
                    bodyemail.Append(dimension.QPESO)
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")

                Next

            End If

        End With

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        'bodyemail.Append(HTMLSalto)
        'bodyemail.Append(HTMLSalto)
        'bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)
        bodyemail.Append("</table>")

        bodyemail.Append("<table style='font-size:10px;font-family:Arial'>")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Modificado por : ")
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

    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As beDestinatario

        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEmbarque As New RequerimientoServicioEnvio_DAL
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT, TipoProceso)
        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio

    End Function

    Public Function Enviar_Email_Requerimiento_Servicio_Notificacion(ByVal beSegEnvioReq As SegEnvioRequerimiento) As Int32 'ByVal NUMREQT As Decimal, ByVal CCMPN As String, ByVal EMAIL_RESP As String) As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Dim Entidad As New RequerimientoServicio

        Try

            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0

            Dim ReqServ As New RequerimientoServicio

            Dim Negocio As New RequerimientoServicioEnvio_DAL

            Entidad = Negocio.Envio_Email_Requerimiento_Servicio(beSegEnvioReq.NUMREQT, beSegEnvioReq.CCMPN)

            Dim odaEmbarque As New RequerimientoServicioEnvio_DAL
            Dim odtDatosEmbarqueFinal As New DataTable
            Dim oclsEmailManager As New clsEmailManager
            Dim obeDestinatariosEnvio As New beDestinatario
            bodyemail = DatosCuerpoEnvioChekPoint(Entidad)
            Dim obeDestinatario As New beDestinatario
            obeDestinatario = BuscarDestinatarios_Notificacion(Entidad.CCLNT, beSegEnvioReq.EMAIL) ', beSegEnvioReq.EMAILCC)
            obeDestinatariosEnvio.PSEMAILTO = obeDestinatario.PSEMAILTO
            obeDestinatariosEnvio.PSEMAILBC = obeDestinatario.PSEMAILBC
            'obeDestinatariosEnvio.PSEMAILCC = obeDestinatario.PSEMAILCC
            oclsEmailManager.MailAccount = Me.MailAccount
            oclsEmailManager.Mailpassword = Me.Mailpassword
            oclsEmailManager.MailBody = bodyemail
            oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
            'oclsEmailManager.mailnotificationCC = obeDestinatariosEnvio.PSEMAILCC
            oclsEmailManager.MailSubject = String.Format("RANSA: ({0}) Requerimiento de Unidad Nro {1} / {2}", Entidad.CCLNT, Entidad.NUMREQT, beSegEnvioReq.SUBJECT)
            If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                oclsEmailManager.SendMailProvider()
                exito = 1
            Else
                MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                exito = 0
            End If


        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO PARA EL CLIENTE " & Entidad.CCLNT
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "REQUERIMIENTO SERVICIO-ERROR ENVIO REQUERIMIENTO"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        Return exito

    End Function

    Public Function BuscarDestinatarios_Notificacion(ByVal CCLNT As Decimal, ByVal EMAIL_RESP As String) As beDestinatario ', ByVal EMAILCC As String) As beDestinatario
        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEmbarque As New RequerimientoServicioEnvio_DAL
        'Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT, TipoProceso)
        'oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = EMAIL_RESP
        'obeDestinatariosEnvio.PSEMAILCC = EMAILCC
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio
    End Function


    Public Function Cargar_Cuerpo_Email_Notificacion(ByVal NUMREQT As Decimal, ByVal CCMPN As String) As String
        Dim bodyemail As String = ""
        Dim Entidad As New RequerimientoServicio

        Dim Negocio As New RequerimientoServicioEnvio_DAL
        Entidad = Negocio.Envio_Email_Requerimiento_Servicio(NUMREQT, CCMPN)
        bodyemail = DatosCuerpoEnvioChekPoint(Entidad)

        Return bodyemail
    End Function

    Public Function Registrar_Envio_Requerimiento_Servicio(ByVal beSegEnvioReq As SegEnvioRequerimiento) As SegEnvioRequerimiento
        Dim Negocio As New RequerimientoServicioEnvio_DAL
        Return Negocio.Registrar_Envio_Requerimiento_Servicio(beSegEnvioReq)
    End Function

    Public Function Listar_Seg_Envio_Requerimiento(ByVal beSegEnvioReq As SegEnvioRequerimiento) As List(Of SegEnvioRequerimiento)
        Dim Negocio As New RequerimientoServicioEnvio_DAL
        Return Negocio.Listar_Seg_Envio_Requerimiento(beSegEnvioReq)
    End Function

End Class
