Imports System.Text
Imports RANSA.Controls.Email
Public Class clsCheckPEnvioPreChange

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"
    Private oListDestinatario As New List(Of beDestinatario)

    'Private oListCliente As New List(Of Decimal)
    Private oPreEmbarque As New clsPreEmbarqueEnvio
    Private _odtDatosCheckInicial As New DataTable
    Private _odtDatosCheckFinal As New DataTable

    Private _mailaccount As String = ""
    Private _mailpassword As String = ""

    Private _mailaccount_gmail As String = ""
    Private _mailpassword_gmail As String = ""
    Private _mailto_error As String = ""
    'Private Tipo_Envio As String = "SC_CHKPRB"
    Dim oTipoEnvio As New ClsCheckClienteEnvio
    Private Tipo_Envio As String = oTipoEnvio.Tipo_Envio_Chk_x_PreEmbarque


    Private _pCCLNT As Decimal = 0
    'Private _CanEnviarACliente As Boolean = False

    Private _pNORCML As String = ""
    Private _pNRPARC As Decimal = 0
    Private _pCULUSA As String = ""
    Private _pCCMPN As String = ""
    Private _pCDVSN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property
    Public Property pCULUSA() As String
        Get
            Return _pCULUSA
        End Get
        Set(ByVal value As String)
            _pCULUSA = value
        End Set
    End Property

    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property

    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property

    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Sub New()
        'oListCliente.Clear()
        'oListCliente.Add(6318) ' EDELNOR
        'oListCliente.Add(56108) ' CONTUGAS
    End Sub
    Public Property odtDatosCheckInicial() As DataTable
        Get
            Return _odtDatosCheckInicial
        End Get
        Set(ByVal value As DataTable)
            _odtDatosCheckInicial = value
        End Set
    End Property
    Public Property odtDatosCheckFinal() As DataTable
        Get
            Return _odtDatosCheckFinal
        End Get
        Set(ByVal value As DataTable)
            _odtDatosCheckFinal = value
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


    Private Function HayCambioChekPoint(ByVal odtDatosUnion As DataTable) As Boolean
        'VERIFICA SI HUBO CAMBIOS EN FECHAS PREEMBARQUE PARA FECHA EMBARQUE(NESTDO=107)
        Dim ExisteCambioFechaEmbarque As Boolean = False
        Dim Fecha_Antes_107_DFECEST As String = ""
        Dim Fecha_Actual_107_DFECEST As String = ""

        Dim Fecha_Antes_108_DFECEST As String = ""
        Dim Fecha_Actual_108_DFECEST As String = ""

        For Each Item As DataRow In odtDatosUnion.Rows
            Fecha_Antes_107_DFECEST = Item("107_DFECEST_ANTES")
            Fecha_Actual_107_DFECEST = Item("107_DFECEST")

            Fecha_Antes_108_DFECEST = Item("108_DFECEST_ANTES")
            Fecha_Actual_108_DFECEST = Item("108_DFECEST")

            If (Fecha_Antes_107_DFECEST.Trim <> Fecha_Actual_107_DFECEST.Trim) Then
                ExisteCambioFechaEmbarque = True
                Exit For
            End If
            If (Fecha_Antes_108_DFECEST.Trim <> Fecha_Actual_108_DFECEST.Trim) Then
                ExisteCambioFechaEmbarque = True
                Exit For
            End If
        Next
        Return ExisteCambioFechaEmbarque
    End Function

    'Public Function CanEnviarACliente(ByVal PNCCLNT As Decimal) As Boolean
    '    _CanEnviarACliente = CanEnviar(PNCCLNT)
    '    Return _CanEnviarACliente
    'End Function
    'Private Function CanEnviar(ByVal PNCCLNT As Decimal) As Boolean
    '    Return (oListCliente.Contains(PNCCLNT))
    'End Function

    Private Function UnirDatosItems(ByVal odtCHKInicial As DataTable, ByVal odtCHKFinal As DataTable) As DataTable
        Dim odtDatosUnion As New DataTable
        odtDatosUnion = odtDatosCheckFinal.Copy
        odtDatosUnion.Columns.Add("107_DFECEST_ANTES")
        odtDatosUnion.Columns.Add("108_DFECEST_ANTES")
        odtDatosUnion.Columns.Add("107_DFECEST_MODIFICADO")
        odtDatosUnion.Columns.Add("108_DFECEST_MODIFICADO")
        'VERIFICA SI HUBO CAMBIOS EN CHECKPOINT PARA FECHA EMBARQUE(NESTDO=107)
        'VERIFICA SI HUBO CAMBIOS EN CHECKPOINT PARA FECHA EMBARQUE(NESTDO=108)
        Dim ExisteCambioFechaEmbarque As Boolean = False
        Dim NESTDO_107_DFECEST As String = ""
        Dim NESTDO As Decimal = 107 ' FECHA DE EMBARQUE
        Dim dr() As DataRow
        Dim PSNORCML As String = ""
        Dim PNRITOC As Decimal = 0
        Dim PNNRPARC As Decimal = 0
        Dim FECHA_107_DFECEST As String = ""
        Dim FECHA_108_DFECEST As String = ""
        Dim FECHA_VALOR As Date
        Dim FECHA_ACTUAL_107 As String = ""
        Dim FECHA_ACTUAL_108 As String = ""
        For Each Item As DataRow In odtDatosUnion.Rows
            PSNORCML = Item("NORCML")
            PNRITOC = Item("NRITOC")
            PNNRPARC = Item("NRPARC")
            FECHA_ACTUAL_107 = Item("107_DFECEST")
            FECHA_ACTUAL_108 = Item("108_DFECEST")
            dr = odtCHKInicial.Select("CCLNT=" & _pCCLNT & " AND NORCML='" & PSNORCML & "' AND NRITOC=" & PNRITOC & " AND NRPARC=" & PNNRPARC)
            FECHA_107_DFECEST = ""
            FECHA_108_DFECEST = ""
            If (dr.Length > 0) Then
                If (Date.TryParse(dr(0)("107_DFECEST").ToString.Trim, FECHA_VALOR)) Then
                    FECHA_107_DFECEST = FECHA_VALOR.ToString("dd/MM/yyyy")
                End If
                If (Date.TryParse(dr(0)("108_DFECEST").ToString.Trim, FECHA_VALOR)) Then
                    FECHA_108_DFECEST = FECHA_VALOR.ToString("dd/MM/yyyy")
                End If
            End If
            Item("107_DFECEST_ANTES") = FECHA_107_DFECEST
            Item("108_DFECEST_ANTES") = FECHA_108_DFECEST
            If (FECHA_107_DFECEST <> FECHA_ACTUAL_107) Then
                Item("107_DFECEST_MODIFICADO") = "*"
            Else
                Item("107_DFECEST_MODIFICADO") = ""
            End If
            If (FECHA_108_DFECEST <> FECHA_ACTUAL_108) Then
                Item("108_DFECEST_MODIFICADO") = "*"
            Else
                Item("108_DFECEST_MODIFICADO") = ""
            End If
        Next
        Return odtDatosUnion
    End Function
    Public Function EnviarEmail_X_Modificacion_CheckPoint() As Int32
        Dim exito As Int32 = -1
        Dim bodyemail As String = ""
        Try
            Dim oListDestEnvio As String = ""
            Dim oListDestEnvioReplicacion As String = ""
            Dim FECHA_INCIAL As Int32 = 0

            Dim obeListaCheckPointInicioFinal As New List(Of beCheckPointFormato)
            Dim obeCheckPointFormato As New beCheckPointFormato
            Dim obeOrdenPreEmbarcarda As New beOrdenPreEmbarcadaFiltro
            obeOrdenPreEmbarcarda.PSNORCML = _pNORCML
            obeOrdenPreEmbarcarda.PNCCLNT = _pCCLNT
            obeOrdenPreEmbarcarda.PNNRPARC = _pNRPARC
            obeOrdenPreEmbarcarda.PSCCMPN = _pCCMPN
            obeOrdenPreEmbarcarda.PSCDVSN = _pCDVSN
            '_CanEnviarACliente = CanEnviar(_pCCLNT)
            Dim odtDatosUnion As New DataTable
            'If (_CanEnviarACliente) Then
            odtDatosCheckFinal = ListarItemsXOrdenCompraParcial(obeOrdenPreEmbarcarda)
            odtDatosUnion = UnirDatosItems(odtDatosCheckInicial, odtDatosCheckFinal)
            Dim HayCambioCheckPoint As Boolean = HayCambioChekPoint(odtDatosUnion)
            If (HayCambioCheckPoint = True) Then
                Dim oclsEmailManager As New clsEmailManager
                Dim obeDestinatariosEnvio As New beDestinatario
                bodyemail = DatosCuerpoEnvioChekPoint(odtDatosUnion)
                obeDestinatariosEnvio = BuscarDestinatarios(_pCCLNT)
                oclsEmailManager.MailAccount = Me.MailAccount
                oclsEmailManager.Mailpassword = Me.Mailpassword
                oclsEmailManager.MailBody = bodyemail
                oclsEmailManager.MailNotification = obeDestinatariosEnvio.PSEMAILTO
                oclsEmailManager.mailnotificationBCC = obeDestinatariosEnvio.PSEMAILBC
                oclsEmailManager.MailSubject = "RANSA:Envio de Actualización de Fecha de Embarque."
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
            msgError = "OCURRIÒ UN ERROR EN EL ENVIO PARA EL CLIENTE " & _pCCLNT
            msgError = msgError & "<br/>" & ex.Message
            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = msgError & "<br/>" & bodyemail
                oclsEmailManagerGMAIL.MailNotification = Me.Mailto_Error
                oclsEmailManagerGMAIL.MailSubject = "SEGUIMIENTO LOGÌSTICO-ERROR ENVIO CHECKPOINT PREEMBARQUE"
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try
        End Try

        Return exito
    End Function

    Private Function DatosCuerpoEnvioChekPoint(ByVal odtDatosUnion As DataTable) As String
        Dim obeOrdenPreEmbarcarda As New beOrdenPreEmbarcadaFiltro
        Dim dtDatosAdicionalEmail As New DataTable
        obeOrdenPreEmbarcarda.PSNORCML = _pNORCML
        obeOrdenPreEmbarcarda.PNCCLNT = _pCCLNT
        dtDatosAdicionalEmail = oPreEmbarque.Listar_Datos_Adicionales_Envios_CHK_PreEmb(obeOrdenPreEmbarcarda)

        Dim bodyemail As New StringBuilder
        Dim TCMPL As String = ""
        Dim TPRVCL As String = ""
        If (dtDatosAdicionalEmail.Rows.Count > 0) Then
            TCMPL = dtDatosAdicionalEmail.Rows(0)("TCMPCL").ToString.Trim
            TPRVCL = dtDatosAdicionalEmail.Rows(0)("TPRVCL").ToString.Trim
        End If
        Dim Dato As String = ""
        'Dim odaEmbarque As New Datos.clsEmbarque

        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append(TCMPL)
        bodyemail.Append(" al ")
        bodyemail.Append(Now.ToString("dd/MM/yyyy"))
        bodyemail.Append(" se ha actualizado lo siguiente(*)")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td >")
        bodyemail.Append("N&uacute;mero Orden Compra:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append(_pNORCML)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td >")
        bodyemail.Append("Nombre Proveedor:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append(TPRVCL)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td >")
        bodyemail.Append("N&uacute;mero Parcial:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append(_pNRPARC.ToString)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")

        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td >")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append("</td>")

        bodyemail.Append("<td colspan='3' style='text-align:center' >")
        bodyemail.Append("Fechas Estimadas")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("PreEmbarque/Item")
        bodyemail.Append("</td>")

        bodyemail.Append("<td >")
        bodyemail.Append("Descripci&oacute;n")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Cantidad")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Antes(*)")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Embarque")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Llegada")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        Dim Tot_Cantidad As Integer = 0
        Dim NORCML As String = ""
        For Each dr As DataRow In odtDatosUnion.Rows
            bodyemail.Append("<tr>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("NRPEMB"))
            bodyemail.Append("/")
            bodyemail.Append(dr("NRITOC").ToString.PadLeft(4, "0"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(dr("TDITES"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QRLCSC"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
            bodyemail.Append(dr("TUNDIT"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td  style='text-align:center'>")
            bodyemail.Append(dr("107_DFECEST_ANTES"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td  style='text-align:center'>")
            bodyemail.Append(dr("107_DFECEST_MODIFICADO"))
            bodyemail.Append("</td>")


            bodyemail.Append("<td  style='text-align:center'>")
            bodyemail.Append(dr("107_DFECEST"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("108_DFECEST"))
            bodyemail.Append("</td>")

            bodyemail.Append("</tr>")

            Tot_Cantidad += dr("QRLCSC")
        Next

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")

        bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td colspan='2'></td>")

        bodyemail.Append("<td colspan='2'>")
        bodyemail.Append(Tot_Cantidad.ToString)
        bodyemail.Append(" Unidades")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append("Totales: ")
        bodyemail.Append(odtDatosUnion.Rows.Count)
        bodyemail.Append(" Items")

        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Para mayores detalles ingrese a nuestra p&aacute;gina web")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")


        bodyemail.Append("<a href='https://secure.ransa.net/wps/portal/extranet'>https://secure.ransa.net/wps/portal/extranet</a>")

        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Modificado por :")
        bodyemail.Append(_pCULUSA)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")



        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
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

    Public Sub ListarItemsDatosInicialCheckPoint(ByVal CCMPN As String, ByVal CDVSN As String, ByVal NORCML As String, ByVal CCLNT As Decimal, ByVal NRPARC As Decimal)
        Dim obeOrdenPreEmbarcarda As New beOrdenPreEmbarcadaFiltro
        obeOrdenPreEmbarcarda.PSCCMPN = CCMPN
        obeOrdenPreEmbarcarda.PSCDVSN = CDVSN
        obeOrdenPreEmbarcarda.PSNORCML = NORCML
        obeOrdenPreEmbarcarda.PNCCLNT = CCLNT
        obeOrdenPreEmbarcarda.PNNRPARC = NRPARC
        _odtDatosCheckInicial = ListarItemsXOrdenCompraParcial(obeOrdenPreEmbarcarda)
    End Sub


    Private Function ListarItemsXOrdenCompraParcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As New DataSet
        Dim odtJoinItemOCParcial As New DataTable
        Dim dtCHKItemOCParcial As New DataTable
        Dim dtDatosAdicionalEmail As New DataTable

        odtJoinItemOCParcial = oPreEmbarque.ListarItemsXOrdenCompraParcial_Datos_Envios_CHK_PreEmb(obeOrdenPreEmbarcarda)
        dtCHKItemOCParcial = oPreEmbarque.ListarCheckPointXOrdenCompraParcial(obeOrdenPreEmbarcarda)

        'Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim NESTDO_CHK As String = ""
        Dim NRITOC As Decimal = 0
        odtJoinItemOCParcial.Columns.Add("107_DFECEST")
        odtJoinItemOCParcial.Columns.Add("108_DFECEST")
        Dim obeCHKFecha As beCheckPointFecha
        Dim NORCML As String = ""
        Dim NRPARC As Decimal = 0
        Dim CCLNT As Decimal = 0
        For Each drItem As DataRow In odtJoinItemOCParcial.Rows
            NORCML = drItem("NORCML").ToString.Trim
            NRPARC = drItem("NRPARC")
            CCLNT = drItem("CCLNT")
            NRITOC = drItem("NRITOC")

            NESTDO_CHK = 107
            obeCHKFecha = New beCheckPointFecha
            obeCHKFecha = FindCHKxOC_Parcial(dtCHKItemOCParcial, CCLNT, NORCML, NRPARC, NESTDO_CHK, NRITOC)
            drItem("107_DFECEST") = obeCHKFecha.PSDFECEST.Trim

            NESTDO_CHK = 108
            obeCHKFecha = New beCheckPointFecha
            obeCHKFecha = FindCHKxOC_Parcial(dtCHKItemOCParcial, CCLNT, NORCML, NRPARC, NESTDO_CHK, NRITOC)
            drItem("108_DFECEST") = obeCHKFecha.PSDFECEST
        Next
        Return odtJoinItemOCParcial
    End Function
    Private Function FindCHKxOC_Parcial(ByVal odtCHK As DataTable, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal NRPARC As Decimal, ByVal NESTDO As Decimal, ByVal NRITOC As Decimal) As beCheckPointFecha
        Dim obeCHKFecha As New beCheckPointFecha
        Dim dr() As DataRow
        Dim DFECEST As String = ""
        Dim DFECREA As String = ""
        Dim oListDFECEST As New List(Of String)
        Dim oListDFECREA As New List(Of String)
        Dim sbDFECEST As New StringBuilder
        Dim sbDFECREA As New StringBuilder
        Dim numReg As Int32 = 0
        Dim oHasObs As New Hashtable
        Dim sb As New StringBuilder


        dr = odtCHK.Select("CCLNT=" & CCLNT & " AND NORCML='" & NORCML & "' AND NRPARC=" & NRPARC & " AND NESTDO=" & NESTDO & " AND NRITOC=" & NRITOC)
        If (dr.Length > 0) Then
            DFECEST = dr(0)("DFECEST").ToString.Trim
            DFECREA = dr(0)("DFECREA").ToString.Trim

            If (DFECEST.Length > 0) Then
                If (Not oListDFECEST.Contains(DFECEST)) Then
                    oListDFECEST.Add(DFECEST)
                    sbDFECEST.Append(DFECEST)
                    sbDFECEST.AppendLine()
                End If
            End If
            If (DFECREA.Length > 0) Then
                If (Not oListDFECREA.Contains(DFECREA)) Then
                    oListDFECREA.Add(DFECREA)
                    sbDFECREA.Append(DFECREA)
                    sbDFECREA.AppendLine()
                End If
            End If
        End If

        If (oListDFECEST.Count = 1) Then
            obeCHKFecha.PSDFECEST = oListDFECEST(0).Trim
        Else
            obeCHKFecha.PSDFECEST = sbDFECEST.ToString.Trim
        End If

        If (oListDFECREA.Count = 1) Then
            obeCHKFecha.PSDFECREA = oListDFECREA(0).Trim
        Else
            obeCHKFecha.PSDFECREA = sbDFECREA.ToString.Trim
        End If
        Return obeCHKFecha
    End Function

    'Private Function FindDestinatarioxReplicacion(ByVal obeDestinatario As beDestinatario) As Boolean
    '    Return obeDestinatario.PSBU = "-1"
    'End Function
    'Private Function FindDestinatarioxNoReplicacion(ByVal obeDestinatario As beDestinatario) As Boolean
    '    Return obeDestinatario.PSBU <> "-1"
    'End Function
    Private Function FindDestinatarioCopia(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"
    End Function

    Private Function FindDestinatarioCliente(ByVal obeDestinatario As beDestinatario) As Boolean
        Return obeDestinatario.PSTIPO_ENVIO = Tipo_Envio AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"
    End Function

    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As beDestinatario
        Dim obeDestinatariosEnvio As New beDestinatario
        Dim odaEmbarque As New clsEmbarqueEnvio
        Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
        Dim dtNofifBU As New DataTable
        'oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_X_TIPO_ENVIO(CCLNT, Tipo_Envio)
        oListDestinatario = odaEmbarque.Listar_Destinatarios_Envio_Notificacion(CCLNT, Tipo_Envio, dtNofifBU)

        'oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_CHECKPOINT(CCLNT)
        'Select Case CCLNT
        '    Case 6318
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioxNoReplicacion)
        '    Case 56108
        '        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioxNoReplicacion)
        'End Select
        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio
    End Function

    'Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As beDestinatario
    '    Dim obeDestinatariosEnvio As New beDestinatario
    '    Dim odaEmbarque As New clsEmbarqueEnvio
    '    Dim oListDestinatarioBusqueda As New List(Of beDestinatario)
    '    Dim oListDestinatarioReplicacion As New List(Of beDestinatario)
    '    oListDestinatario = odaEmbarque.DESTINATARIO_ENVIO_EMAIL_CHECKPOINT(CCLNT)
    '    Select Case CCLNT
    '        Case 6318
    '            oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioxNoReplicacion)
    '        Case 56108
    '            oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioxNoReplicacion)
    '    End Select
    '    oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioxReplicacion)
    '    obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
    '    obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
    '    Return obeDestinatariosEnvio
    'End Function
End Class
