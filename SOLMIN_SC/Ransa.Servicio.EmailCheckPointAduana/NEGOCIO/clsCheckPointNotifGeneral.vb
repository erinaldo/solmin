Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Public Class clsCheckPointNotifGeneral
    Private PNNESTDO_ULTIMO_MODIFICADO As Decimal = 0 'PARA COLOCAR EL ASTERISCO
    Private PSTDESES_ULTIMO_MODIFICADO As String = ""


    Private _mailaccount As String = ""
    Private _mailpassword As String = ""

    Private _mailaccount_gmail As String = ""
    Private _mailpassword_gmail As String = ""
    Private _mailto_error As String = ""

    Private _CULUSA As String = ""

    Private _dtChkEmbarqueInicial As New DataTable
    Private oListDestinatario As New List(Of beDestinatario)
    Private oListPSBU As New List(Of String)
    'Dim oTipoEnvio As New ClsCheckClienteEnvio
    Private _Tipo_Envio As String = "" ' oTipoEnvio.Tipo_Envio_Chk_x_Aduana

    Private dtListCheckPointEnvio As New DataTable

    'Public ReadOnly Property Tipo_Envio() As String
    '    Get
    '        Return _Tipo_Envio
    '    End Get
    'End Property

    Public Property Tipo_Envio() As String
        Get
            Return _Tipo_Envio
        End Get
        Set(ByVal value As String)
            _Tipo_Envio = value
        End Set
    End Property



    Private _CCLNT As Decimal = 0
    Public Property dtChkEmbarqueInicial() As DataTable
        Get
            Return _dtChkEmbarqueInicial
        End Get
        Set(ByVal value As DataTable)
            _dtChkEmbarqueInicial = value
        End Set
    End Property

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



    Private _CodFormato As String
    Public Property CodFormato() As String
        Get
            Return _CodFormato
        End Get
        Set(ByVal value As String)
            _CodFormato = value
        End Set
    End Property



    Sub New()

        dtListCheckPointEnvio.Rows.Clear()

        dtListCheckPointEnvio.Columns.Add("TNMBCM")
        dtListCheckPointEnvio.Columns.Add("NESTDO")
        dtListCheckPointEnvio.Columns.Add("F_INI_EST")
        dtListCheckPointEnvio.Columns.Add("F_FIN_EST")
        dtListCheckPointEnvio.Columns.Add("F_INI_REAL")
        dtListCheckPointEnvio.Columns.Add("F_FIN_REAL")
        dtListCheckPointEnvio.Columns.Add("F_FIN_VER")
        dtListCheckPointEnvio.Columns.Add("MODIFICADO")
        dtListCheckPointEnvio.Columns.Add("TDESES")
        dtListCheckPointEnvio.Columns.Add("TDESES_HTML")
        dtListCheckPointEnvio.Columns.Add("MOSTRAR")
        dtListCheckPointEnvio.Columns.Add("NOTIFICAR")
        dtListCheckPointEnvio.Columns.Add("OBS")

    End Sub

    Public Sub ListaDatosCheckPointInicial(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal)
        ListaDatosCheckPointInicial_General(CCLNT, NORSCI, _CodFormato)
    End Sub

    Public Function EnviarEmail_X_Modificacion_CheckPoint(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal TCMPL As String) As Int32
        EnviarEmail_X_Modificacion_CheckPoint_General(CCLNT, NORSCI, TCMPL, _CodFormato)
    End Function

    Private Sub ListaDatosCheckPointInicial_General(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal CodFormato As String)
        Dim odaEmbarque As New clsEmbarqueEnvio
        Dim dtListaChkVerNotificar As New DataTable
        'se debe de listar los datos inciciales antes de realizar la modificacion
        Dim dsResult As New DataSet
        dsResult = odaEmbarque.Listar_datos_Embarque_Chk_Notificacion(CCLNT, NORSCI, _Tipo_Envio)
        _dtChkEmbarqueInicial = dsResult.Tables(0).Copy
        dtListaChkVerNotificar = dsResult.Tables(1).Copy

        'If CodFormato = "F2" Then
        '    FormardtListaChkVerNotificar_F2(dtListaChkVerNotificar)
        'Else
        Dim dr As DataRow
        dtListCheckPointEnvio.Rows.Clear()
        For Each Item As DataRow In dtListaChkVerNotificar.Rows
            dr = dtListCheckPointEnvio.NewRow
            dr("TNMBCM") = Item("TNMBCM").ToString.Trim
            dr("NESTDO") = Item("NESTDO")
            dr("TDESES") = Item("TCOLUM").ToString.Trim
            dr("TDESES_HTML") = FormatoTituloHTML(Item("TCOLUM").ToString.Trim)
            dr("MOSTRAR") = Item("FLGEST").ToString.Trim
            dr("NOTIFICAR") = Item("FLGNTE").ToString.Trim
            dtListCheckPointEnvio.Rows.Add(dr)
        Next
        'End If

    End Sub

    Private Function EnviarEmail_X_Modificacion_CheckPoint_General(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal TCMPL As String, ByVal CodFormato As String) As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Dim AsuntoEmail As New StringBuilder
        Dim oclsCheckFormatos As New clsCheckFormatos
        Try
            _CCLNT = CCLNT
            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0
            Dim HayCambioCheckPoint As Boolean = False

            Dim dtListaChkEnvio As New DataTable
            dtListaChkEnvio = dtListCheckPointEnvio.Copy
            dtListaChkEnvio.Rows.Clear()

            Dim drList As DataRow

            Dim odaEmbarque As New clsEmbarqueEnvio
            Dim obeCheckPointFormato As New beCheckPointFormato
            Dim dtChkEmbarqueFinal As New DataTable
            Dim dtChkParaNotif As New DataTable
            Dim dsFinal As New DataSet
            dsFinal = odaEmbarque.Listar_datos_Embarque_Chk_Notificacion(CCLNT, NORSCI, _Tipo_Envio)
            dtChkEmbarqueFinal = dsFinal.Tables(0).Copy
            dtChkParaNotif = dsFinal.Tables(1).Copy

            Dim _TipoFechaChkMostrar As TipoFecha = TipoFecha.Real
            Dim _TipoFechaChkNotificar As TipoFecha = TipoFecha.Real

            For Each dr As DataRow In dtListCheckPointEnvio.Rows

                If EsNotificableChk(dtChkParaNotif, dr("NESTDO")) Then

                    drList = dtListaChkEnvio.NewRow

                    Select Case dr("MOSTRAR")
                        Case "R"
                            _TipoFechaChkMostrar = TipoFecha.Real
                        Case "E"
                            _TipoFechaChkMostrar = TipoFecha.Estimado
                    End Select

                    drList("NESTDO") = dr("NESTDO")
                    drList("TNMBCM") = dr("TNMBCM")
                    drList("TDESES") = dr("TDESES")
                    drList("TDESES_HTML") = dr("TDESES_HTML")

                    drList("F_INI_EST") = OtieneFechaCheckPoint(_dtChkEmbarqueInicial, dr("NESTDO"), TipoFecha.Estimado)
                    drList("F_FIN_EST") = OtieneFechaCheckPoint(dtChkEmbarqueFinal, dr("NESTDO"), TipoFecha.Estimado)
                    drList("F_INI_REAL") = OtieneFechaCheckPoint(_dtChkEmbarqueInicial, dr("NESTDO"), TipoFecha.Real)
                    drList("F_FIN_REAL") = OtieneFechaCheckPoint(dtChkEmbarqueFinal, dr("NESTDO"), TipoFecha.Real)
                    drList("F_FIN_VER") = OtieneFechaCheckPoint(dtChkEmbarqueFinal, dr("NESTDO"), _TipoFechaChkMostrar)
                    drList("OBS") = OtieneObservacionCheckPoint(dtChkEmbarqueFinal, dr("NESTDO"))
                    Select Case dr("NOTIFICAR")
                        Case "E"
                            If drList("F_INI_EST") <> drList("F_FIN_EST") Then
                                HayCambioCheckPoint = True
                                drList("MODIFICADO") = "X"
                                PNNESTDO_ULTIMO_MODIFICADO = drList("NESTDO")
                                PSTDESES_ULTIMO_MODIFICADO = dr("TDESES")
                            End If
                        Case "R"
                            If drList("F_INI_REAL") <> drList("F_FIN_REAL") Then
                                HayCambioCheckPoint = True
                                drList("MODIFICADO") = "X"
                                PNNESTDO_ULTIMO_MODIFICADO = drList("NESTDO")
                                PSTDESES_ULTIMO_MODIFICADO = dr("TDESES")
                            End If
                        Case "T"

                            If drList("F_INI_EST") <> drList("F_FIN_EST") OrElse drList("F_INI_REAL") <> drList("F_FIN_REAL") Then
                                HayCambioCheckPoint = True
                                drList("MODIFICADO") = "X"
                                PNNESTDO_ULTIMO_MODIFICADO = drList("NESTDO")
                                PSTDESES_ULTIMO_MODIFICADO = dr("TDESES")
                            End If
                    End Select
                    dtListaChkEnvio.Rows.Add(drList)
                End If
            Next

            Dim dtDatosEmb As New DataTable
            Dim dtOCEmb As New DataTable
            Dim dtObsEmb As New DataTable

            If (HayCambioCheckPoint = True) Then
                Dim oclsEmailManager As New clsEmailManager
                Dim obeDestinatariosEnvio As New beDestinatario
                Dim oDsDetalle As New DataSet




                Select Case CodFormato
                    Case "F1"
                        oDsDetalle = odaEmbarque.Listar_Datos_Cuerpo_Envio_Email(CCLNT, NORSCI)
                        dtDatosEmb = oDsDetalle.Tables(0).Copy
                        dtOCEmb = oDsDetalle.Tables(1).Copy
                        dtObsEmb = oDsDetalle.Tables(2).Copy
                        bodyemail = oclsCheckFormatos.DatosCuerpoEnvioChekPoint_F1(dtDatosEmb, dtObsEmb, dtOCEmb, dtListaChkEnvio, CCLNT, NORSCI, TCMPL, CULUSA, PNNESTDO_ULTIMO_MODIFICADO)
                        Dim OC_Referencia As String = ""
                        If (dtOCEmb.Rows.Count > 0) Then
                            OC_Referencia = dtOCEmb.Rows(0)("NORCML").ToString.Trim
                        End If
                        Dim NDOCEM As String = dtDatosEmb.Rows(0)("NDOCEM").ToString.Trim
                        AsuntoEmail.Append("RANSA :(")
                        AsuntoEmail.Append(_CCLNT.ToString)
                        AsuntoEmail.Append(") Se ha registrado un  Evento:")
                        AsuntoEmail.Append(PSTDESES_ULTIMO_MODIFICADO.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("OC:")
                        AsuntoEmail.Append(OC_Referencia.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("BL/AWB:")
                        AsuntoEmail.Append(NDOCEM.Trim)
                    Case "F2"

                        oDsDetalle = odaEmbarque.Listar_Datos_Cuerpo_Envio_Email(CCLNT, NORSCI)
                        dtDatosEmb = oDsDetalle.Tables(0).Copy
                        dtOCEmb = oDsDetalle.Tables(1).Copy
                        dtObsEmb = oDsDetalle.Tables(2).Copy
                        bodyemail = oclsCheckFormatos.DatosCuerpoEnvioChekPoint_F2(dtDatosEmb, dtObsEmb, dtOCEmb, dtListaChkEnvio, CCLNT, NORSCI, TCMPL, CULUSA, PNNESTDO_ULTIMO_MODIFICADO)
                        Dim OC_Referencia As String = ""
                        If (dtOCEmb.Rows.Count > 0) Then
                            OC_Referencia = dtOCEmb.Rows(0)("NORCML").ToString.Trim
                        End If
                        Dim NDOCEM As String = dtDatosEmb.Rows(0)("NDOCEM").ToString.Trim
                        AsuntoEmail.Append("RANSA :(")
                        AsuntoEmail.Append(_CCLNT.ToString)
                        AsuntoEmail.Append(") Se ha registrado un  Evento:")
                        AsuntoEmail.Append(PSTDESES_ULTIMO_MODIFICADO.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("OC:")
                        AsuntoEmail.Append(OC_Referencia.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("BL/AWB:")
                        AsuntoEmail.Append(NDOCEM.Trim)
                    Case "F3"
                        oDsDetalle = odaEmbarque.Listar_Datos_Cuerpo_Envio_Email(CCLNT, NORSCI)
                        dtDatosEmb = oDsDetalle.Tables(0).Copy
                        dtOCEmb = oDsDetalle.Tables(1).Copy
                        dtObsEmb = oDsDetalle.Tables(2).Copy
                        bodyemail = oclsCheckFormatos.DatosCuerpoEnvioChekPoint_F3(dtDatosEmb, dtObsEmb, dtOCEmb, dtListaChkEnvio, CCLNT, NORSCI, TCMPL, CULUSA, PNNESTDO_ULTIMO_MODIFICADO)
                        Dim OC_Referencia As String = ""
                        If (dtOCEmb.Rows.Count > 0) Then
                            OC_Referencia = dtOCEmb.Rows(0)("NORCML").ToString.Trim
                        End If
                        Dim NDOCEM As String = dtDatosEmb.Rows(0)("NDOCEM").ToString.Trim
                        AsuntoEmail.Append("RANSA :(")
                        AsuntoEmail.Append(_CCLNT.ToString)
                        AsuntoEmail.Append(") Se ha registrado un  Evento:")
                        AsuntoEmail.Append(PSTDESES_ULTIMO_MODIFICADO.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("OC:")
                        AsuntoEmail.Append(OC_Referencia.Trim)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("BL/AWB:")
                        AsuntoEmail.Append(NDOCEM.Trim)
                    Case "F4"
                        oDsDetalle = odaEmbarque.Listar_Datos_Cuerpo_Envio_Email_Local(CCLNT, NORSCI)
                        dtDatosEmb = oDsDetalle.Tables(0).Copy
                        dtOCEmb = oDsDetalle.Tables(1).Copy
                        dtObsEmb = oDsDetalle.Tables(2).Copy
                        Dim codigo As String = ""
                        Dim Visitado As New Hashtable
                        For Each Item As DataRow In dtOCEmb.Rows
                            codigo = Item("CREFFW").ToString.Trim & "_" & Item("NUMDCR").ToString.Trim & "_" & Item("NGRPRV").ToString.Trim
                            If Not Visitado.Contains(codigo) Then
                                Visitado(codigo) = codigo
                            Else
                                Item("CREFFW") = ""
                                Item("NUMDCR") = ""
                                Item("NGRPRV") = ""
                                Item("DESC_BULTO") = ""
                                Item("QBULTOS") = DBNull.Value
                                Item("TIPBTO") = ""
                                Item("QPSOMR") = DBNull.Value
                            End If
                        Next
  
                        bodyemail = oclsCheckFormatos.DatosCuerpoEnvioChekPoint_F4(dtDatosEmb, dtObsEmb, dtOCEmb, dtListaChkEnvio, CCLNT, NORSCI, TCMPL, CULUSA)
                        AsuntoEmail.Append("RANSA :(")
                        AsuntoEmail.Append(_CCLNT.ToString)
                        AsuntoEmail.Append(") ")
                        AsuntoEmail.Append("Embarque:")
                        AsuntoEmail.Append(NORSCI)
                        AsuntoEmail.Append(" - ")
                        AsuntoEmail.Append("Guía: ")
                        AsuntoEmail.Append(DevuelveGuiaRemision(dtOCEmb))
                End Select

                obeDestinatariosEnvio = BuscarDestinatarios(CCLNT, dtOCEmb)
                oclsEmailManager.MailAccount = Me.MailAccount
                oclsEmailManager.Mailpassword = Me.Mailpassword
                oclsEmailManager.MailBody = bodyemail
                oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
                oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC

                oclsEmailManager.MailSubject = AsuntoEmail.ToString.Trim

                If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                    oclsEmailManager.SendMailProvider()
                    exito = 1
                Else
                    MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
                    exito = 0
                End If
            Else
                exito = 0
            End If

            'End If

        Catch ex As Exception
            Dim msgError As String = ""
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO PARA EL CLIENTE " & CCLNT
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "SEGUIMIENTO LOGÌSTICO-ERROR ENVIO CHECKPOINT ADUANA"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try
        Return exito
    End Function



    Private Function ListaBU(ByVal odtOrdenesCompra As DataTable) As List(Of String)
        Dim oListBU As New List(Of String)
        Dim BU As String = ""
        For Each dr As DataRow In odtOrdenesCompra.Rows
            BU = dr("BU").ToString.Trim
            If (BU.Length <> 0) Then
                If (Not oListBU.Contains(BU)) Then
                    oListBU.Add(BU)
                End If
            End If
        Next
        Return oListBU
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

    Private Function EsDestinatarioxBU(ByVal dtClienteNotifBU As DataTable, ByVal CCLNT As Decimal) As Boolean
        Dim dr() As DataRow
        Dim EsDestionatarioBU As Boolean = False
        dr = dtClienteNotifBU.Select("CCLNT='" & CCLNT & "'")
        If dr.Length > 0 Then
            EsDestionatarioBU = True
        End If
        Return EsDestionatarioBU
    End Function
    Private Function BuscarDestinatarios(ByVal CCLNT As Decimal, ByVal odtOrdenesCompra As DataTable) As beDestinatario
        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEmbarque As New clsEmbarqueEnvio
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)

        Dim dtClienteNotifBU As New DataTable

        oListDestinatario = odaEmbarque.Listar_Destinatarios_Envio_Notificacion(CCLNT, Tipo_Envio, dtClienteNotifBU)

        If EsDestinatarioxBU(dtClienteNotifBU, CCLNT) Then
            oListPSBU = ListaBU(odtOrdenesCompra)
            oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioBU)
        Else
            oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        End If

        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio
    End Function



    Private Function FindDestinatarioBU(ByVal obeDestinatario As beDestinatario) As Boolean
        Return oListPSBU.Contains(obeDestinatario.PSDIV_ENVIO)
    End Function

    Private Function FindDestinatarioCopia(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"
    End Function

    Private Function FindDestinatarioCliente(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIPO_ENVIO = Tipo_Envio AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"
    End Function


    Public Function ExisteChkEnvioxPSTNMBCM(ByVal PSTNMBCM_VALUE As String) As beCheckPointEnvio

        Dim obeCheckPointFind As New beCheckPointEnvio

        Dim dr() As DataRow
        dr = dtListCheckPointEnvio.Select("TNMBCM='" & PSTNMBCM_VALUE & "'")
        If dr.Length > 0 Then
            obeCheckPointFind = New beCheckPointEnvio
            obeCheckPointFind.PSTNMBCM = dr(0)("TNMBCM")
            obeCheckPointFind.PNNESTDO = dr(0)("NESTDO")
            obeCheckPointFind.PSTDESES = dr(0)("TDESES")
            obeCheckPointFind.PSTDESES_HTML = dr(0)("TDESES_HTML")
        Else
            obeCheckPointFind = Nothing
        End If

        Return obeCheckPointFind
    End Function

    Private Function ExisteChkEnvioxNESTDO(ByVal PNNESTDO_VALUE As Decimal) As beCheckPointEnvio

        Dim obeCheckPointFind As New beCheckPointEnvio

        Dim dr() As DataRow
        dr = dtListCheckPointEnvio.Select("NESTDO='" & PNNESTDO_VALUE & "'")
        If dr.Length > 0 Then
            obeCheckPointFind = New beCheckPointEnvio
            obeCheckPointFind.PSTNMBCM = dr(0)("TNMBCM")
            obeCheckPointFind.PNNESTDO = dr(0)("NESTDO")
            obeCheckPointFind.PSTDESES = dr(0)("TDESES")
            obeCheckPointFind.PSTDESES_HTML = dr(0)("TDESES_HTML")
        Else
            obeCheckPointFind = Nothing
        End If

        Return obeCheckPointFind
    End Function


    Enum TipoFecha
        Estimado
        Real
    End Enum
    Private Function OtieneFechaCheckPoint(ByVal odtCheckPoint As DataTable, ByVal NESTDO As Decimal, ByVal _TipoFecha As TipoFecha) As Decimal
        Dim FECHA As Decimal = 0
        Dim dr() As DataRow
        If (odtCheckPoint.Rows.Count > 0) Then
            dr = odtCheckPoint.Select("NESTDO='" & NESTDO & "'")
            If dr.Length > 0 Then
                If _TipoFecha = TipoFecha.Real Then
                    FECHA = dr(0)("FRETES")
                Else
                    FECHA = dr(0)("FESEST")
                End If
            End If
        End If
        Return FECHA
    End Function

    Private Function EsNotificableChk(ByVal dtChkParaNotificar As DataTable, ByVal NESTDO As Decimal) As Boolean
        Dim dr() As DataRow
        Dim notificar As Boolean = False
        dr = dtChkParaNotificar.Select("NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            notificar = True
        End If
        Return notificar
    End Function

    Private Function FormatoTituloHTML(ByVal descripcion As String) As String
        Dim desc As String = ""
        Dim c As String = ""
        For Each Item As Char In descripcion.ToCharArray
            c = Item.ToString
            If c = "á" Then
                c = "&aacute;"
            End If
            If c = "Á" Then
                c = "&Aacute;"
            End If
            If c = "é" Then
                c = "&eacute;"
            End If
            If c = "É" Then
                c = "&Eacute;"
            End If
            If c = "í" Then
                c = "&iacute;"
            End If
            If c = "Í" Then
                c = "&iacute;"
            End If
            If c = "ó" Then
                c = "&oacute;"
            End If
            If c = "Ó" Then
                c = "&Oacute;"
            End If
            If c = "ú" Then
                c = "&uacute;"
            End If
            If c = "Ú" Then
                c = "&Uacute;"
            End If
            desc = desc & c
        Next
        Return desc
    End Function

    Private Function DevuelveGuiaRemision(ByVal obdtOCEmb As DataTable) As String
        Dim GuiaRem As String = ""
        If (obdtOCEmb.Rows.Count > 0) Then
            For Each Item As DataRow In obdtOCEmb.Rows
                If ("" & Item("NUMDCR")).ToString.Trim <> "" Then
                    GuiaRem = ("" & Item("NUMDCR")).ToString.Trim
                    Exit For
                End If
            Next
        End If
        Return GuiaRem
    End Function

    Private Function OtieneObservacionCheckPoint(ByVal odtCheckPoint As DataTable, ByVal NESTDO As Decimal) As String
        Dim obs As String = ""
        Dim dr() As DataRow
        If (odtCheckPoint.Rows.Count > 0) Then
            dr = odtCheckPoint.Select("NESTDO='" & NESTDO & "'")
            If dr.Length > 0 Then
                obs = ("" & dr(0)("OBS")).ToString.Trim
            End If
        End If
        Return obs
    End Function
    Public Function Listar_datos_Embarque_Chk_Actual(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim odaEmbarque As New clsEmbarqueEnvio
        Return Listar_datos_Embarque_Chk_Actual(PNCCLNT, PNNORSCI)
    End Function
End Class
