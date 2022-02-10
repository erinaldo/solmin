Imports System.Text
Imports System.Runtime.CompilerServices
Imports RANSA.Controls.Email
Public Class clsCheckPointEnvio_F2

    Private oListCheckPointEnvio As New List(Of beCheckPointEnvio)
    Private PNNESTDO As Decimal = 0
    Private PNNESTDO_ULTIMO_MODIFICADO As Decimal = 0 'PARA COLOCAR EL ASTERISCO

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"
    Private PSTNMBCM As String = ""
    Private PNESTDO As Decimal = 0

    Private _mailaccount As String = ""
    Private _mailpassword As String = ""

    Private _mailaccount_gmail As String = ""
    Private _mailpassword_gmail As String = ""
    Private _mailto_error As String = ""

    Private _CULUSA As String = ""
    'Private oListCCLNTEnvioCambioChk As New List(Of String)
    Private odtOrdenesCompra_X_Embarque As New DataTable
    Private odtObsSeguimiento As New DataTable
    Private _odtDatosEmbarqueInicial As New DataTable
    Private oListDestinatario As New List(Of beDestinatario)
    Private oListPSBU As New List(Of String)
    'Private _Tipo_Envio As String = "SC_CHKADN"
    Dim oTipoEnvio As New ClsCheckClienteEnvio
    Private _Tipo_Envio As String = oTipoEnvio.Tipo_Envio_Chk_x_Aduana

    Public ReadOnly Property Tipo_Envio() As String
        Get
            Return _Tipo_Envio
        End Get
    End Property


    Private _CCLNT As Decimal = 0
    Public Property odtDatosEmbarqueInicial() As DataTable
        Get
            Return _odtDatosEmbarqueInicial
        End Get
        Set(ByVal value As DataTable)
            _odtDatosEmbarqueInicial = value
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


    'Private _dtListaClienteEnvio As New DataTable

    'Public Function Lista_Cliente_Envio_Notificacion() As DataTable
    '    Dim odaEmbarqueEnvio As New clsEmbarqueEnvio
    '    _dtListaClienteEnvio = odaEmbarqueEnvio.LISTAR_CLIENTE_ENVIO_EMAIL_NOTIFICACION_X_TIPO_ENVIO(Tipo_Envio)
    '    Return _dtListaClienteEnvio
    'End Function

    'Public Sub Asignar_Lista_Cliente_Envio_Notificacion(ByVal dtListaClienteEnvio As DataTable)
    '    _dtListaClienteEnvio = dtListaClienteEnvio.Copy
    'End Sub

    'Public Function DebeNotificarEnvio__X_Cliente(ByVal CCLNT As Decimal) As Boolean
    '    'si la notificacion se debe de realizar al cliente
    '    'Return oListCCLNTEnvioCambioChk.Contains(CCLNT.ToString)
    '    Dim dr() As DataRow
    '    Dim Enviar As Boolean = False
    '    dr = _dtListaClienteEnvio.Select("CCLNT='" & CCLNT & "'")
    '    If dr.Length > 0 Then
    '        Enviar = True
    '    End If
    '    Return Enviar
    'End Function

    Sub New()
        oListCheckPointEnvio.Clear()
        oListCheckPointEnvio = ListaCheckPoint_ParaEnvioEmail()
        'oListCCLNTEnvioCambioChk.Clear()
        'oListCCLNTEnvioCambioChk.Add("11232") 'lista de clientes a notificar
        'oListCCLNTEnvioCambioChk.Add("6318")
        'oListCCLNTEnvioCambioChk.Add("2287")
        'oListCCLNTEnvioCambioChk.Add("56108")
    End Sub

    Public Sub ListaDatosCheckPointInicial(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal)
        Dim odaEmbarque As New clsEmbarqueEnvio
        'se debe de listar los datos inciciales antes de realizar la modificacion
        _odtDatosEmbarqueInicial = odaEmbarque.DATO_EMBARQUE_ENVIO_EMAIL_CHEKPOINT(CCLNT, NORSCI)
    End Sub
    Private Function ListaCheckPoint_ParaEnvioEmail() As List(Of beCheckPointEnvio)
        Dim obeChekPointEnvio As beCheckPointEnvio

        oListCheckPointEnvio.Clear()

        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 1 'ORDEN EN QUE APARECERA EN EL ENVIO DE MAIL
        obeChekPointEnvio.PSTNMBCM = "FAPREV"
        obeChekPointEnvio.PNNESTDO = 107
        obeChekPointEnvio.PSTDESES = "Fecha Embarque"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Embarque" 'TEXTO A UTILIZAR EN EL ENVIO MAIL
        oListCheckPointEnvio.Add(obeChekPointEnvio)


        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 2 'ORDEN EN QUE APARECERA EN EL ENVIO DE MAIL
        obeChekPointEnvio.PSTNMBCM = "FAPRAR"
        obeChekPointEnvio.PNNESTDO = 108
        obeChekPointEnvio.PSTDESES = "Fecha Llegada"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Llegada" 'TEXTO A UTILIZAR EN EL ENVIO MAIL
        oListCheckPointEnvio.Add(obeChekPointEnvio)


        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 3
        obeChekPointEnvio.PSTNMBCM = "FECNUM"
        obeChekPointEnvio.PNNESTDO = 121
        obeChekPointEnvio.PSTDESES = "Fecha Numeración"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Numeraci&oacute;n"
        oListCheckPointEnvio.Add(obeChekPointEnvio)

        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 4
        obeChekPointEnvio.PSTNMBCM = "FECPGD"
        obeChekPointEnvio.PNNESTDO = 122
        obeChekPointEnvio.PSTDESES = "Fecha Pago Derecho"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Pago Derecho"
        oListCheckPointEnvio.Add(obeChekPointEnvio)

        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 5
        obeChekPointEnvio.PSTNMBCM = "FECLEV"
        obeChekPointEnvio.PNNESTDO = 123
        obeChekPointEnvio.PSTDESES = "Fecha Levante"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Levante"
        oListCheckPointEnvio.Add(obeChekPointEnvio)

        obeChekPointEnvio = New beCheckPointEnvio
        obeChekPointEnvio.PNORDEN_ANALIZAR = 6
        obeChekPointEnvio.PSTNMBCM = "FECALM"
        obeChekPointEnvio.PNNESTDO = 124
        obeChekPointEnvio.PSTDESES = "Fecha Entrega Almacén"
        obeChekPointEnvio.PSTDESES_HTML = "Fecha Entrega Almac&eacute;n"
        oListCheckPointEnvio.Add(obeChekPointEnvio)

        oListCheckPointEnvio.Sort(AddressOf SortXOrdenEnvio)

        Return oListCheckPointEnvio
    End Function

    Public Function ExisteChkEnvioxPSTNMBCM(ByVal PSTNMBCM_VALUE As String) As beCheckPointEnvio
        Dim Existe As Boolean = False
        PSTNMBCM = PSTNMBCM_VALUE
        Dim obeCheckPointFind As beCheckPointEnvio
        obeCheckPointFind = oListCheckPointEnvio.Find(AddressOf SearchCheckPointParaEnvio_X_PSTNMBCM)
        Return obeCheckPointFind
    End Function

    Public Function ExisteChkEnvioxNESTDO(ByVal PNNESTDO_VALUE As Decimal) As beCheckPointEnvio
        Dim Existe As Boolean = False
        PNESTDO = PNNESTDO_VALUE
        Dim obeCheckPointFind As beCheckPointEnvio
        obeCheckPointFind = oListCheckPointEnvio.Find(AddressOf SearchCheckPointParaEnvio_X_PNNESTDO)
        Return obeCheckPointFind
    End Function

    Private Function SearchCheckPointParaEnvio_X_PSTNMBCM(ByVal obechk1 As beCheckPointEnvio) As Boolean
        Return obechk1.PSTNMBCM = PSTNMBCM
    End Function

    Private Function SearchCheckPointParaEnvio_X_PNNESTDO(ByVal obechk1 As beCheckPointEnvio) As Boolean
        Return obechk1.PNNESTDO = PNNESTDO
    End Function
    Private Function SortXOrdenEnvio(ByVal obechk1 As beCheckPointEnvio, ByVal obechk2 As beCheckPointEnvio) As Int32
        Dim retorno As Int32 = obechk1.PNORDEN_ANALIZAR.CompareTo(obechk2.PNORDEN_ANALIZAR)
        Return retorno
    End Function

    Private Function SortXListaFormato(ByVal obechk1 As beCheckPointFormato, ByVal obechk2 As beCheckPointFormato) As Int32
        Dim retorno As Int32 = obechk1.PNORDEN_ANALIZAR.CompareTo(obechk2.PNORDEN_ANALIZAR)
        Return retorno
    End Function

    Private Function OtieneFechaCheckPoint(ByVal odtCheckPoint As DataTable, ByVal NESTDO As Decimal) As Decimal
        Dim FECHA As Decimal = 0
        If (odtCheckPoint.Rows.Count > 0) Then
            Select Case NESTDO
                Case 107
                    FECHA = odtCheckPoint.Rows(0)("CHK_FAPREV")
                Case 108
                    FECHA = odtCheckPoint.Rows(0)("CHK_FAPRAR")
                Case 121
                    FECHA = odtCheckPoint.Rows(0)("CHK_FECNUM")
                Case 122
                    FECHA = odtCheckPoint.Rows(0)("CHK_FECPGD")
                Case 123
                    FECHA = odtCheckPoint.Rows(0)("CHK_FECLEV")
                Case 124
                    FECHA = odtCheckPoint.Rows(0)("CHK_FECALM")
            End Select
        End If
        Return FECHA
    End Function
    Public Function EnviarEmail_X_Modificacion_CheckPoint(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal TCMPL As String) As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Try
            _CCLNT = CCLNT
            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0

            Dim odaEmbarque As New clsEmbarqueEnvio
            Dim obeListaCheckPointInicioFinal As New List(Of beCheckPointFormato)
            Dim obeCheckPointFormato As New beCheckPointFormato
            Dim odtDatosEmbarqueFinal As New DataTable
            odtDatosEmbarqueFinal = odaEmbarque.DATO_EMBARQUE_ENVIO_EMAIL_CHEKPOINT(CCLNT, NORSCI)
            For Each obeCheckPointEnvio As beCheckPointEnvio In oListCheckPointEnvio
                obeCheckPointFormato = New beCheckPointFormato
                obeCheckPointFormato.PNNESTDO = obeCheckPointEnvio.PNNESTDO
                obeCheckPointFormato.PNFRETES_INICIAL = OtieneFechaCheckPoint(_odtDatosEmbarqueInicial, obeCheckPointEnvio.PNNESTDO)
                obeCheckPointFormato.PNFRETES_FINAL = OtieneFechaCheckPoint(odtDatosEmbarqueFinal, obeCheckPointEnvio.PNNESTDO)
                obeCheckPointFormato.PSTDESES = obeCheckPointEnvio.PSTDESES
                obeCheckPointFormato.PSTDESES_HTML = obeCheckPointEnvio.PSTDESES_HTML
                obeCheckPointFormato.PNORDEN_ANALIZAR = obeCheckPointEnvio.PNORDEN_ANALIZAR
                obeListaCheckPointInicioFinal.Add(obeCheckPointFormato)
            Next
            obeListaCheckPointInicioFinal.Sort(AddressOf SortXListaFormato)

            'If (oListCCLNTEnvioCambioChk.Contains(CCLNT.ToString)) Then
            Dim HayCambioCheckPoint As Boolean = HayCambioChekPoint(obeListaCheckPointInicioFinal)
            If (HayCambioCheckPoint = True) Then
                Dim oclsEmailManager As New clsEmailManager
                Dim obeDestinatariosEnvio As New beDestinatario
                Dim oDsDetalle As New DataSet
                oDsDetalle = odaEmbarque.DETALLE_OC_EMBARQUE_ENVIO_EMAIL(CCLNT, NORSCI)
                odtOrdenesCompra_X_Embarque = oDsDetalle.Tables(0)
                odtObsSeguimiento = oDsDetalle.Tables(1)
                bodyemail = DatosCuerpoEnvioChekPoint(obeListaCheckPointInicioFinal, CCLNT, NORSCI, TCMPL)
                obeDestinatariosEnvio = BuscarDestinatarios(CCLNT, odtOrdenesCompra_X_Embarque)
                oclsEmailManager.MailAccount = Me.MailAccount
                oclsEmailManager.Mailpassword = Me.Mailpassword
                oclsEmailManager.MailBody = bodyemail
                oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
                oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
                oclsEmailManager.MailSubject = MensajeAsuntoEmail(odtOrdenesCompra_X_Embarque, odtDatosEmbarqueFinal, obeListaCheckPointInicioFinal)
                If (obeDestinatariosEnvio.PSEMAILTO <> "") Then
                    oclsEmailManager.SendMailProvider()
                    'MsgBox("Correo Enviado")
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

    Private Function MensajeAsuntoEmail(ByVal odtOC As DataTable, ByVal odtDatosEmbarqueFinal As DataTable, ByVal obeListaCheckPointInicioFinal As List(Of beCheckPointFormato)) As String
        Dim AsuntoEmail As New StringBuilder

        Dim CheckPoint_Modificado As String = ""
        Dim OC_Referencia As String = ""
        Dim NDOCEM As String = ""
        For Each obeCheckPointFormato As beCheckPointFormato In obeListaCheckPointInicioFinal
            If (PNNESTDO_ULTIMO_MODIFICADO = obeCheckPointFormato.PNNESTDO) Then
                CheckPoint_Modificado = obeCheckPointFormato.PSTDESES
                Exit For
            End If
        Next
        If (odtOC.Rows.Count > 0) Then
            OC_Referencia = odtOC.Rows(0)("NORCML").ToString.Trim
        End If
        If (odtDatosEmbarqueFinal.Rows.Count > 0) Then
            NDOCEM = odtDatosEmbarqueFinal.Rows(0)("NDOCEM").ToString.Trim
        End If

        AsuntoEmail.Append("RANSA :(")
        AsuntoEmail.Append(_CCLNT.ToString)
        AsuntoEmail.Append(") Se ha registrado un  Evento:")
        AsuntoEmail.Append(CheckPoint_Modificado)
        AsuntoEmail.Append(" - ")
        AsuntoEmail.Append("OC:")
        AsuntoEmail.Append(OC_Referencia)
        AsuntoEmail.Append(" - ")
        AsuntoEmail.Append("BL/AWB:")
        AsuntoEmail.Append(NDOCEM)
        Return AsuntoEmail.ToString.Trim
    End Function
    Private Function SearchCheckPointParaEnvioFormato(ByVal obechk1 As beCheckPointFormato) As Boolean
        Return obechk1.PNNESTDO = PNNESTDO
    End Function

    Private Function HayCambioChekPoint(ByVal obeListaCheckPointInicioFinal As List(Of beCheckPointFormato)) As Boolean
        Dim HayCambios As Boolean = False
        Dim obeCheckPointFormatoFind As beCheckPointFormato
        For Each obeCheckPointFormato As beCheckPointFormato In obeListaCheckPointInicioFinal
            PNNESTDO = obeCheckPointFormato.PNNESTDO
            obeCheckPointFormatoFind = obeListaCheckPointInicioFinal.Find(AddressOf SearchCheckPointParaEnvioFormato)
            If (obeCheckPointFormatoFind IsNot Nothing) Then
                'Select Case _CCLNT
                '    Case 2287 ' PARA ANTAMINA SOLO SE ENVIA EN CASO DE MODIFICACION DE FECHA LEVANTE-123
                '        If (PNNESTDO = 123 AndAlso obeCheckPointFormatoFind.PNFRETES_INICIAL <> obeCheckPointFormatoFind.PNFRETES_FINAL) Then
                '            HayCambios = True
                '            obeCheckPointFormato.PBNESTDO_MODIFICADO = True 'INDICAMOS QUE EL CHK SUFRIO CAMBIOS
                '            PNNESTDO_ULTIMO_MODIFICADO = obeCheckPointFormato.PNNESTDO 'ALMACENAMOS EL CHK ULTIMO EN MODIFICACION 
                '        End If
                'Case Else 'PARA EL RESTO DE CLIENTE SE ENVIA CADA VEZ QUE ES MODIFICADO CUALQUIER CHECKPOINT
                If (obeCheckPointFormatoFind.PNFRETES_INICIAL <> obeCheckPointFormatoFind.PNFRETES_FINAL) Then
                    HayCambios = True
                    obeCheckPointFormato.PBNESTDO_MODIFICADO = True 'INDICAMOS QUE EL CHK SUFRIO CAMBIOS
                    PNNESTDO_ULTIMO_MODIFICADO = obeCheckPointFormato.PNNESTDO 'ALMACENAMOS EL CHK ULTIMO EN MODIFICACION 
                End If
                'End Select
            End If
        Next
        Return HayCambios
    End Function

    Private Function DatosCuerpoEnvioChekPoint(ByVal obeListaCheckPointInicioFinal As List(Of beCheckPointFormato), ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal TCMPL As String) As String

        Dim Dato As String = ""

        Dim datosEmbarque As New DataTable
        Dim observacionesEmbarque As New DataTable
        Dim odaEmbarque As New clsEmbarqueEnvio
        datosEmbarque = odaEmbarque.DATO_EMBARQUE_ENVIO_EMAIL_CHEKPOINT(CCLNT, NORSCI)
        'Retorna las observaciones -----------------
        observacionesEmbarque = odtObsSeguimiento 'odaEmbarque.DETALLE_OC_EMBARQUE_ENVIO_EMAIL(CCLNT, NORSCI)
        '-------------------------------------------
        Dim bodyemail As New StringBuilder
        Dim dtInfoCarga As New DataTable
        Dim tmpNORCML As String = ""
        Dim UrlBanner As String = "http://asp.ransa.net/wsmineria/sgl_email/img/banner.jpg"
        Dim UrlSemaforoRojo As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semafororojo.jpg"
        Dim UrlSemaforoNaranja As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoambar.jpg"
        Dim UrlSemaforoVerde As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoverde.jpg"
        Dim UrlSemaforoBlanco As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoblanco.jpg"
      
        dtInfoCarga.Columns.Add("TNOMCOM")
        dtInfoCarga.Columns.Add("NORCML")
        dtInfoCarga.Columns.Add("TPRVCL")

        For Each dtRow As DataRow In odtOrdenesCompra_X_Embarque.Rows
            If tmpNORCML <> dtRow("NORCML").ToString.Trim Then
                dtInfoCarga.Rows.Add(New Object() {dtRow("TNOMCOM").ToString.Trim, dtRow("NORCML").ToString.Trim, dtRow("TPRVCL").ToString.Trim})
            End If
            tmpNORCML = dtRow("NORCML").ToString.Trim
        Next

        With datosEmbarque
            bodyemail.Append("<html>")
            bodyemail.Append("<head>")
            bodyemail.Append("<meta charset='UTF-8'>")
            bodyemail.Append("<style type='text/css'>")
            bodyemail.Append("body {")
            bodyemail.Append("font-family: Arial, Helvetica, sans-serif;")
            bodyemail.Append("font-size:10px;")
            bodyemail.Append("line-height:15px;")
            bodyemail.Append("}")
            bodyemail.Append("table{border-collapse: collapse;}")
            bodyemail.Append("td,th{padding:0}")
            bodyemail.Append("</style>")
            bodyemail.Append("</head>")
            bodyemail.Append("<body style='margin:0;padding:20px 0'>")
            '740
            bodyemail.Append("<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO IMPORTACIONES " & TCMPL & " – " & CCLNT.ToString & "</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='padding:20px 0'>")
            bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("			<tr>")
            bodyemail.Append("				<td align='left' valign='top'><img src='" & UrlBanner & "' width='600' height='110' border='0'></td>")

            Select Case .Rows(0)("TCANAL").ToString.ToUpper
                Case "ROJO"
                    'Semaforo en rojo
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoRojo & "' width='59' height='110' border='0'></td>")
                Case "NARANJA"
                    'Semarofo en ambar
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoNaranja & "' width='59' height='110' border='0'></td>")
                Case "VERDE"
                    'Semaforo en verde
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoVerde & "' width='59' height='110' border='0'></td>")
                Case Else
                    'Semaforo en rojo
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoBlanco & "' width='59' height='110' border='0'></td>")
            End Select

            bodyemail.Append("			</tr>")
            bodyemail.Append("		</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>INFORMACIÓN DE LA CARGA - EMB NRO " & .Rows(0)("NORSCI") & "</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='padding:20px 0'>")
            bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("			<tr>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'>COMPRADOR</th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'>ORDEN DE COMPRA</th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'>PROVEEDOR</th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'>O/S</th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'>BL/AWB</th>")
            bodyemail.Append("			</tr>")
            'Informacion de carga
            For Each rowInfoCarga As DataRow In dtInfoCarga.Rows
                bodyemail.Append("		<tr>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("TNOMCOM") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("NORCML") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("TPRVCL") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & .Rows(0)("PNNMOS") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & .Rows(0)("NDOCEM") & "</td>")
                bodyemail.Append("		</tr>")
            Next

            bodyemail.Append("		</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("<td style='padding:0 0 20px'>")
            bodyemail.Append("	<table style='border:1px solid #000' width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>ORIGEN</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TCMPPS") & "/" & .Rows(0)("LUGAR_ORIGEN") & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>DESTINO</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TCMPPS_DES") & "/" & .Rows(0)("LUGAR_DESTINO") & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TRANSPORTE</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TNMMDT") & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO REGIMEN</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("REGIMEN") & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO DESPACHO</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TIPO_DESPACHO") & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("	</table>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO DE LA CARGA</td>")
            bodyemail.Append("</tr>")

            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='padding:20px 0'>")
            bodyemail.Append("<table style='font-size:11px;line-height:13px' width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("<tr>")
            bodyemail.Append("<td width='210' valign='top'>")
            bodyemail.Append("	<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td style='border:1px solid #000;padding:2px 0;font-weight:700' align='center' valign='middle'>TRANSITO INTERNACIONAL</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("      <tr>")
            bodyemail.Append("          <td style='padding:20px 0 0'>")
            bodyemail.Append("          <table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("              <tr>")
            bodyemail.Append("  				<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA SALIDA NAVE (ETS)</th>")
            bodyemail.Append("                  <th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA ESTIMADA ARRIBO NAVE (ETA)</th>")
            bodyemail.Append("              </tr>")

            '-----------------------------------------------
            bodyemail.Append("              <tr>")
            bodyemail.Append("                  <td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FAPREV")))
            bodyemail.Append("</td>")
            bodyemail.Append("					<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("FAPRAR")))
            bodyemail.Append("</td>")
            bodyemail.Append("				</tr>")
            '-----------------------------------------------

            bodyemail.Append("			</table>")
            bodyemail.Append("			</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("	</table>")
            bodyemail.Append("		   </td>")
            bodyemail.Append("				<td width='10' valign='top'></td>")
            bodyemail.Append("				<td width='285' valign='top'>")
            bodyemail.Append("					<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("						<tr>")
            bodyemail.Append("							<td style='border:1px solid #000;padding:2px 0;font-weight:700' align='center' valign='middle'>OPERATIVIDAD PUERTO/AEROPUERTO</td>")
            bodyemail.Append("              		</tr>")
            bodyemail.Append("                      <tr>")
            bodyemail.Append("				<td style='padding:20px 0 0'>")
            bodyemail.Append("              <table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("          <tr>")
            bodyemail.Append("              <th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA CONFIRMADA DE ARRIBO NAVE</th>")
            bodyemail.Append("				<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA TERMINO DESCARGA NAVE</th>")
            bodyemail.Append("				<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA VOLANTE DEPOSITO TEMPORAL</th>")
            bodyemail.Append("			</tr>")

            '---------------------------------------------------
            bodyemail.Append("			<tr>")
            bodyemail.Append("  			<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FAPRAR")))
            bodyemail.Append("</td>")
            bodyemail.Append("              <td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FTNDSC")))
            bodyemail.Append("</td>")
            bodyemail.Append("              <td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FCDCOR")))
            bodyemail.Append("</td>")
            bodyemail.Append("          </tr>")
            '-----------------------------------------------

            bodyemail.Append("  </table>")
            bodyemail.Append("          </td>")
            bodyemail.Append("          </tr>")
            bodyemail.Append("      </table>")
            bodyemail.Append("      </td>")
            bodyemail.Append("      <td width='10' valign='top'></td>")
            bodyemail.Append("      <td width='286' valign='top'>")
            bodyemail.Append("  <table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("  <tr>")
            bodyemail.Append("  <td style='border:1px solid #000;padding:2px 0;font-weight:700' align='center' valign='middle'>ADUANAS</td>")
            bodyemail.Append("	</tr>")
            bodyemail.Append("						<tr>")
            bodyemail.Append("							<td style='padding:20px 0 0'>")
            bodyemail.Append("								<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("									<tr>")
            bodyemail.Append("										<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA NUMERACION DAM</th>")
            bodyemail.Append("										<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>CANAL ADUANAS</th>")
            bodyemail.Append("										<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA LEVANTE ADUANERO</th>")
            bodyemail.Append("										<th height='65' bgcolor='#00b050' style='border:1px solid #000;padding:2px 4px'>FECHA INGRESO AT</th>")
            bodyemail.Append("									</tr>")

            '----------------------------------------------------
            bodyemail.Append("									<tr>")
            bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FECNUM")))
            bodyemail.Append("</td>")


            Select Case .Rows(0)("TCANAL").ToString.ToUpper
                Case "ROJO"
                    bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:red;font-weight:700'>ROJO</p></td>")
                Case "NARANJA"
                    bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:orange;font-weight:700'>NARANJA</p></td>")
                Case "VERDE"
                    bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:green;font-weight:700'>VERDE</p></td>")
                Case Else
                    bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp</td>")
            End Select

            bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FECLEV")))
            bodyemail.Append("</td>")
            bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
            bodyemail.Append(CNumero8Digitos_a_FechaDefault(.Rows(0)("CHK_FECALM")))
            bodyemail.Append("</td>")
            bodyemail.Append("									</tr>")
            '-------------------------------------------------------------------

            bodyemail.Append("								</table>")
            bodyemail.Append("							</td>")
            bodyemail.Append("						</tr>")
            bodyemail.Append("					</table>")
            bodyemail.Append("				</td>")
            bodyemail.Append("			</tr>")
            bodyemail.Append("		</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("</tr>")

        End With

        bodyemail.Append("<tr>")
        bodyemail.Append("	<td style='padding:0 0 20px'>")
        bodyemail.Append("		<table width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>OBSERVACIONES</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("					<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")

        bodyemail.Append("<tr>")
        bodyemail.Append("	<th valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'>&nbsp</th>")
        bodyemail.Append("	<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>FECHA</th>")
        bodyemail.Append("	<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>DESCRIPCI&Oacute;N</th>")
        bodyemail.Append("	</tr>")
        'Parte dinamica
        Dim Obscorr As Integer = 0
        If observacionesEmbarque.Rows.Count > 0 Then
            For Each Obsdr As DataRow In observacionesEmbarque.Rows
                Obscorr = Obscorr + 1
                bodyemail.Append("						<tr>")
                bodyemail.Append("							<td style='border:1px solid #000;padding:2px 0px' align='center' valign='middle'>" & Obscorr.ToString & "</td>")
                bodyemail.Append("							<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
                bodyemail.Append(CNumero8Digitos_a_FechaDefault(Obsdr("FECHA_OBS")))
                bodyemail.Append("</td>")
                bodyemail.Append("							<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>" & Obsdr("OBS") & "</td>")
                bodyemail.Append("						</tr>")
            Next
        Else
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='border:1px solid #000;padding:2px 0px' align='center' valign='middle'>&nbsp</td>")
            bodyemail.Append("	<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp</td>")
            bodyemail.Append("	<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp</td>")
            bodyemail.Append("</tr>")
        End If
        bodyemail.Append("					</table>")
        bodyemail.Append("				</td>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("		</table>")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")

        Dim Tot_Cantidad As Integer = 0

        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>DETALLE DE CARGA</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("		<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>ORDEN COMPRA</th>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>PROVEEDOR</th>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'>ITEM</th>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>DESCRIPCIÓN</th>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>CANTIDAD</th>")
        bodyemail.Append("			</tr>")

        For Each dr As DataRow In odtOrdenesCompra_X_Embarque.Rows
            bodyemail.Append("			<tr>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("NORCML"))
            bodyemail.Append("</td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("TPRVCL"))
            bodyemail.Append("</td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='left' valign='middle'>")
            bodyemail.Append(dr("NRITEM"))
            bodyemail.Append("</td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("TDITES"))
            bodyemail.Append("</td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QRLCSC"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
            bodyemail.Append(dr("TUNDIT"))
            bodyemail.Append("</td>")
            bodyemail.Append("			</tr>")

            Tot_Cantidad += dr("QRLCSC")

        Next

        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'><strong>Total items:</strong> ")
        bodyemail.Append(odtOrdenesCompra_X_Embarque.Rows.Count)
        bodyemail.Append("</td>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp;</td>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='center' valign='middle'></td>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp;</td>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'><em> ")
        bodyemail.Append(Tot_Cantidad.ToString)
        bodyemail.Append(" </em><strong>UNIDAD(ES)</strong></td>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("		</table>")
        bodyemail.Append("</td>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("		</table>")

        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("	 &nbsp;")
        bodyemail.Append("	 &nbsp;")
        bodyemail.Append("	 &nbsp;")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("	 Para mayores detalles ingrese a nuestra p&aacute;gina web")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("	<a href='https://secure.ransa.net/wps/portal/extranet'>https://secure.ransa.net/wps/portal/extranet</a>")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("	 &nbsp;")
        bodyemail.Append("	 &nbsp;")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td>")
        bodyemail.Append("	 Modificado por : ")
        bodyemail.Append(CULUSA)
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function


    Private Function CNumero8Digitos_a_FechaDefault(ByVal oFechaNumero As Int64) As String
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        Dim oFecha As String = oFechaNumero.ToString()
        If (Val(oFecha) = 0) Then
            FechaFormada = ""
        Else
            y = Left(oFecha.ToString(), 4)
            m = Right(Left(oFecha.ToString(), 6), 2)
            d = Right(oFecha.ToString(), 2)
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function
    Private Function FHTML_RIGHT(ByVal cadena As String, ByVal Char_Total_Relleno As Int32, ByVal CharRelleno As String) As String
        Dim cadenaRetorno As String = cadena.PadRight(Char_Total_Relleno, CharRelleno).Replace(CharRelleno, HTMLEspacio)
        Return cadenaRetorno
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
    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal, ByVal odtOrdenesCompra As DataTable) As beDestinatario
        Dim obeDestinatariosEnvio As New beDestinatario
        Dim oListBU As New List(Of String)
        Dim odaEmbarque As New clsEmbarqueEnvio
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        'oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_CHECKPOINT(CCLNT)
        oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_X_TIPO_ENVIO(CCLNT, Tipo_Envio)
        'Select Case CCLNT
        '    Case 6318
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        '    Case 56108
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        '    Case 11232
        '        oListPSBU = ListaBU(odtOrdenesCompra)
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioxBU)
        '    Case 2287
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        'End Select
        Select Case CCLNT
            Case 11232
                oListPSBU = ListaBU(odtOrdenesCompra)
                oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioBU)
            Case Else
                oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        End Select

        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio
    End Function

    'Private Function FindDestinatarioxBU(ByVal obeDestinatario As beDestinatario) As Boolean
    '    Return oListPSBU.Contains(obeDestinatario.PSBU)
    'End Function

    'Private Function FindDestinatarioxReplicacion(ByVal obeDestinatario As beDestinatario) As Boolean
    '    Return obeDestinatario.PSBU = "-1"
    'End Function
    'Private Function FindDestinatarioxNoReplicacion(ByVal obeDestinatario As beDestinatario) As Boolean
    '    'Return obeDestinatario.PSBU <> "-1" 'CHECKPOINT
    '    Return obeDestinatario.PSBU = "CHECKPOINT"
    'End Function

    Private Function FindDestinatarioBU(ByVal obeDestinatario As beDestinatario) As Boolean
        Return oListPSBU.Contains(obeDestinatario.PSDIV_ENVIO)
    End Function

    Private Function FindDestinatarioCopia(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"
    End Function

    Private Function FindDestinatarioCliente(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIPO_ENVIO = Tipo_Envio AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"
    End Function

    'Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As beDestinatario

    '    Dim obeDestinatariosEnvio As New beDestinatario
    '    Dim oListBU As New List(Of String)
    '    Dim odaEnviarEmail As New EnvioEmailAnulacionOperacion_DAL
    '    Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
    '    Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
    '    oListDestinatario = odaEnviarEmail.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(CCLNT, TipoProceso)
    '    oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
    '    oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
    '    obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
    '    obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
    '    Return obeDestinatariosEnvio

    'End Function




End Class
