Imports System.Text
Imports System.Text.RegularExpressions
Imports RANSA.Controls.Email
Public Class BL_CheckPointEnvioPreEmb
    Private _MailAccount As String = ""
    Private _Mailpassword As String = ""
    Private _EmailTo As String = ""
    Private _EmailBC As String = ""
    Private _EmailTo_Error As String = ""
    Private strEmailUnionValidos As String = ""
    Private strEmailUnionNoValidos As String = ""

    Private _mailaccount_gmail As String = ""
    Private _mailpassword_gmail As String = ""
    Private _mailto_error As String = ""

    Public Property MailAccount() As String
        Get
            Return _MailAccount
        End Get
        Set(ByVal value As String)
            _MailAccount = value
        End Set
    End Property
    Public Property Mailpassword() As String
        Get
            Return _Mailpassword
        End Get
        Set(ByVal value As String)
            _Mailpassword = value
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


    Public Property EmailTo() As String
        Get
            Return _EMAILTO
        End Get
        Set(ByVal value As String)
            _EMAILTO = value
        End Set
    End Property


    Public Property Mailto_error() As String
        Get
            Return _mailto_error
        End Get
        Set(ByVal value As String)
            _mailto_error = value
        End Set
    End Property

    Public Property EmailBC() As String
        Get
            Return _EmailBC
        End Get
        Set(ByVal value As String)
            _EmailBC = value
        End Set
    End Property

    Public Property Emailto_error() As String
        Get
            Return _EmailTo_Error
        End Get
        Set(ByVal value As String)
            _EmailTo_Error = value
        End Set
    End Property

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"
    Const NumMaxDiasDiferencia As Int32 = 15


    Private oListCliente As New List(Of Decimal)
    Private _CanEnviarACliente As Boolean = False
    Public Function CanEnviarACliente(ByVal PNCCLNT As Decimal) As Boolean
        _CanEnviarACliente = CanEnviar(PNCCLNT)
    End Function
    Private Function CanEnviar(ByVal PNCCLNT As Decimal) As Boolean
        Return (oListCliente.Contains(PNCCLNT))
    End Function
    Sub New()
        oListCliente.Clear()
        'CLIENTES DE ENVIO : 6318
        oListCliente.Add(6318)
    End Sub



    Private Function DatosCuerpoEnvioChekPoint(ByVal odtDatosOrdenes As DataTable, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByRef TotalItems As Int32) As String
        Dim bodyemail As New StringBuilder
        TotalItems = odtDatosOrdenes.Rows.Count
        Dim Dato As String = ""

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
        bodyemail.Append(" se les envia el estado de sus &Oacute;rdenes de Compra y sus pr&oacute;ximos embarques.")
        bodyemail.Append("(Prox. " & NumMaxDiasDiferencia.ToString & " d&iacute;as)")
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
        bodyemail.Append("<td >")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append("</td>")
        bodyemail.Append("<td >")
        bodyemail.Append("</td>")
        bodyemail.Append("<td colspan='2' style='text-align:center' >")
        bodyemail.Append("Fechas Estimadas")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td >")
        bodyemail.Append("Orden Compra")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Proveedor")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Parcial")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:right'>")
        bodyemail.Append("Item")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Descripci&oacute;n")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Cantidad")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Embarque")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Llegada")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        Dim Tot_Cantidad As Integer = 0
        Dim oListOrdenes As New List(Of String)
        Dim NORCML As String = ""


        For Each dr As DataRow In odtDatosOrdenes.Rows
            bodyemail.Append("<tr>")

            bodyemail.Append("<td >")
            NORCML = dr("NORCML")
            bodyemail.Append(NORCML)
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(dr("TPRVCL"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("NRPARC"))
            bodyemail.Append("</td>")


            bodyemail.Append("<td style='text-align:right'>")
            bodyemail.Append(dr("NRITOC").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append("/")
            bodyemail.Append(dr("TDITES"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QRLCSC"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
            bodyemail.Append(" ")
            bodyemail.Append(dr("TUNDIT"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td  style='text-align:center'>")
            bodyemail.Append(dr("107_DEFESEST"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("108_DEFESEST"))
            bodyemail.Append("</td>")


            bodyemail.Append("</tr>")

            If NORCML.Trim.Length <> 0 AndAlso (Not oListOrdenes.Contains(NORCML)) Then
                oListOrdenes.Add(NORCML)
            End If
            Tot_Cantidad += dr("QRLCSC")

        Next

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")

        bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td colspan='5'></td>")

        bodyemail.Append("<td colspan='2'>")
        bodyemail.Append(Tot_Cantidad.ToString)
        bodyemail.Append(" Unidades")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")

        bodyemail.Append("<td colspan='3'>")
        bodyemail.Append("Totales: ")
        bodyemail.Append(oListOrdenes.Count.ToString)
        bodyemail.Append(" &Oacute;rdenes de Compra")
        bodyemail.Append("/")
        bodyemail.Append(odtDatosOrdenes.Rows.Count)
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


        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function

    Private Function IsValidEmail(ByVal strIn As String) As Boolean
        Dim ExpreReg As New StringBuilder
        ExpreReg.Append("^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))")
        ExpreReg.Append("(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
        Return Regex.IsMatch(strIn, ExpreReg.ToString.Trim)
    End Function

    Private Sub Llenar_Lista_CorreosEnvio_Adicionales(ByVal odtDatosOrdenes As DataTable, ByVal EmailPrincipal As String)
        Dim oListCorreosValidos As New List(Of String)
        Dim oListCorreosNoValidos As New List(Of String)
        oListCorreosValidos.Add(EmailPrincipal.ToLower)
        Dim strEvaluacionEmail As String = ""
        For Each Item As DataRow In odtDatosOrdenes.Rows
            strEvaluacionEmail = Item("TNOMCOM").ToString.Trim
            If (strEvaluacionEmail.Length > 0) Then
                If (IsValidEmail(strEvaluacionEmail)) Then
                    If (Not oListCorreosValidos.Contains(strEvaluacionEmail.ToLower)) Then
                        oListCorreosValidos.Add(strEvaluacionEmail.ToLower)
                    End If
                Else
                    oListCorreosNoValidos.Add(strEvaluacionEmail.ToLower)
                End If
            End If
        Next
        Dim EmailValidos As New StringBuilder
        Dim EmailNoValidos As New StringBuilder
        For Each Item As String In oListCorreosValidos
            EmailValidos.Append(Item)
            EmailValidos.Append(";")
        Next
        For Each Item As String In oListCorreosNoValidos
            EmailNoValidos.Append(Item)
            EmailNoValidos.Append(";")
        Next
        If (EmailValidos.Length > 0) Then
            strEmailUnionValidos = EmailValidos.ToString.Remove(EmailValidos.ToString.Trim.Length - 1, 1)
        End If
        If (EmailNoValidos.Length > 0) Then
            strEmailUnionNoValidos = EmailNoValidos.ToString.Remove(EmailNoValidos.ToString.Trim.Length - 1, 1)
        End If

    End Sub

    Public Sub EnviarEmail_X_Modificacion_CheckPoint_PreEmb(ByVal PSCCMPN As String, ByVal CCLNT As Decimal)
        Dim odtDatosEnvio As New DataTable
        Try
            _CanEnviarACliente = CanEnviar(CCLNT)
            Dim Total_Items As Int32 = 0
            If (_CanEnviarACliente = True) Then
                Dim bodyemail As String = ""
                Dim oclsEmailManager As New clsEmailManager
                oclsEmailManager.MailAccount = Me.MailAccount
                oclsEmailManager.Mailpassword = Me.Mailpassword
                If (EMAILTO.Trim.Length <> 0) Then
                    Dim odtDatosOrdenes As New DataTable
                    Dim TCMPL As String = ""
                    odtDatosOrdenes = ListarDatosCheckPointEnvioEmail(PSCCMPN, CCLNT, TCMPL)
                    bodyemail = DatosCuerpoEnvioChekPoint(odtDatosOrdenes, CCLNT, TCMPL, Total_Items)
                    Llenar_Lista_CorreosEnvio_Adicionales(odtDatosOrdenes, EMAILTO)
                    If (strEmailUnionValidos.Length > 0) Then
                        oclsEmailManager.MainNotification = strEmailUnionValidos
                    End If
                    If (EMAILBC.Trim.Length <> 0) Then
                        oclsEmailManager.mailnotificationBCC = EMAILBC
                    End If

                    oclsEmailManager.MailBody = bodyemail
                    oclsEmailManager.MailSubject = "RANSA:Relación de Embarques por recibir."

                    If (Total_Items <> 0) Then
                        oclsEmailManager.SendMailProvider()

                        If (strEmailUnionNoValidos.Length > 0) Then
                            'oclsEmailManager = New clsEmailManager
                            'oclsEmailManager.MailAccount = Me.MailAccount
                            'oclsEmailManager.Mailpassword = Me.Mailpassword
                            'oclsEmailManager.MainNotification = Me.Emailto_ERROR
                            'oclsEmailManager.MailBody = strEmailUnionNoValidos
                            'oclsEmailManager.MailSubject = "Status:Envio Email items PreEmbarque-Correo No Válidos."
                            ''oclsEmailManager.SendMail()
                            'oclsEmailManager.SendMailProvider()
                            Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                            oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                            oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                            oclsEmailManagerGMAIL.MailBody = strEmailUnionNoValidos
                            oclsEmailManagerGMAIL.MainNotification = Me.Mailto_Error
                            oclsEmailManagerGMAIL.MailSubject = "Status:Envio Email items PreEmbarque-Correo No Válidos."
                            oclsEmailManagerGMAIL.SendMailGmail()

                        End If
                    Else
                        'oclsEmailManager = New clsEmailManager
                        'oclsEmailManager.MailAccount = Me.MailAccount
                        'oclsEmailManager.Mailpassword = Me.Mailpassword
                        'oclsEmailManager.MainNotification = Me.Emailto_ERROR
                        'oclsEmailManager.MailBody = "No existen items a enviar"
                        'oclsEmailManager.MailSubject = "Status:Envio Email items PreEmbarque.(RANSA:Relación de Embarques por recibir.)"
                        ''oclsEmailManager.SendMail()
                        'oclsEmailManager.SendMailProvider()

                        Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                        oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                        oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                        oclsEmailManagerGMAIL.MailBody = "No existen items a enviar"
                        oclsEmailManagerGMAIL.MainNotification = Me.Mailto_Error
                        oclsEmailManagerGMAIL.MailSubject = "Status:Envio Email items PreEmbarque.(RANSA:Relación de Embarques por recibir.)"
                        oclsEmailManagerGMAIL.SendMailGmail()

                    End If
                End If
            End If
        Catch ex As Exception
            'Dim oclsEmailManager As New clsEmailManager
            'oclsEmailManager.MailAccount = Me.MailAccount
            'oclsEmailManager.Mailpassword = Me.Mailpassword
            'oclsEmailManager.MainNotification = Me.Emailto_ERROR
            'oclsEmailManager.MailBody = ex.Message
            'oclsEmailManager.MailSubject = "Error: Status Envio items Email PreEmbarque."
            ''oclsEmailManager.SendMail()
            'oclsEmailManager.SendMailProvider()

            Try
                Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
                oclsEmailManagerGMAIL.MailAccount = Me.MailAccount_Gmail
                oclsEmailManagerGMAIL.Mailpassword = Me.MailPassword_Gmail
                oclsEmailManagerGMAIL.MailBody = ex.Message
                oclsEmailManagerGMAIL.MainNotification = Me.Mailto_error
                oclsEmailManagerGMAIL.MailSubject = "Error: Status Envio items Email PreEmbarque."
                oclsEmailManagerGMAIL.SendMailGmail()
            Catch exx As Exception
            End Try

        End Try

    End Sub


    Private Function ListarDatosCheckPointEnvioEmail(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByRef TCMPCL As String) As DataTable
        'LA DATA DEBE DE VENIR ORDENADA POR ORDEN DE COMPRA,PARCIAL,ITEM

        Dim odaCheckPoint As New DAL_CheckPoint
        Dim odsDatos As New DataSet
        Dim oListOC As New Hashtable
        Dim oListOCParcial As New Hashtable
        Dim odtItemCheckPoint As New DataTable
        Dim odtUnionItem As New DataTable
        Dim odtCheckPoint As New DataTable
        Dim NORCML As String = ""
        Dim NESTDO As Decimal = 0
        Dim NRITOC As Decimal = 0
        Dim OC_PARCIAL As String = ""
        Dim PARCIAL As Decimal = 0
        Dim PNFECHA_REFERENCIA As Decimal = Date.Now.ToString("yyyyMMdd")
        'Fecha Referencia:Fechas CheckPoint mayores o iguales a la fecha de hoy
        odsDatos = odaCheckPoint.Lista_Datos_CheckPoint_PreEmbarque_Envio_Email(PSCCMPN, PNCCLNT, PNFECHA_REFERENCIA)
        TCMPCL = odsDatos.Tables("dtCliente").Rows(0)("TCMPCL")
        odtUnionItem = odsDatos.Tables("dtDatosItemOC").Copy
        odtUnionItem.Columns.Add("107_DEFESEST") 'Fecha Embarque
        odtUnionItem.Columns.Add("108_DEFESEST") 'Fecha Llegada
        odtCheckPoint = odsDatos.Tables("dtDatosCheckPoint").Copy

        Dim Frecuencia As Int32 = 0
        Dim FILA As Int32 = 0
        Dim NUM_FILAS As Int32 = odtUnionItem.Rows.Count - 1
        Dim FechaActual As String = Date.Now.ToString("dd/MM/yyy")
        Dim NumDiasDif As Int32 = 0
        For FILA = 0 To NUM_FILAS
            If (FILA <= NUM_FILAS) Then
                NORCML = odtUnionItem.Rows(FILA)("NORCML").ToString.Trim
                PARCIAL = odtUnionItem.Rows(FILA)("NRPARC")
                NRITOC = odtUnionItem.Rows(FILA)("NRITOC")
                OC_PARCIAL = odtUnionItem.Rows(FILA)("NORCML").ToString.Trim & "_" & odtUnionItem.Rows(FILA)("NRPARC").ToString.Trim
                odtUnionItem.Rows(FILA)("107_DEFESEST") = ObtieneFecha(odtCheckPoint, PNCCLNT, NORCML, NRITOC, 107)
                odtUnionItem.Rows(FILA)("108_DEFESEST") = ObtieneFecha(odtCheckPoint, PNCCLNT, NORCML, NRITOC, 108)
                NumDiasDif = Dif_Fecha_CheckPoint(FechaActual, odtUnionItem.Rows(FILA)("107_DEFESEST"))
                If (NumDiasDif > NumMaxDiasDiferencia OrElse NumDiasDif < 0) Then
                    odtUnionItem.Rows.RemoveAt(FILA)
                    FILA = FILA - 1
                    NUM_FILAS = NUM_FILAS - 1
                Else

                    If (oListOC.Contains(NORCML)) Then
                        Frecuencia = oListOC(NORCML)
                        Frecuencia = Frecuencia + 1
                        oListOC(NORCML) = Frecuencia
                        If (Frecuencia > 1) Then
                            odtUnionItem.Rows(FILA)("NORCML") = ""
                            odtUnionItem.Rows(FILA)("TPRVCL") = ""
                        End If
                    Else
                        Frecuencia = 1
                        oListOC.Add(NORCML, Frecuencia)
                    End If
                    If (oListOCParcial.Contains(OC_PARCIAL)) Then
                        Frecuencia = oListOCParcial(OC_PARCIAL)
                        Frecuencia = Frecuencia + 1
                        oListOCParcial(OC_PARCIAL) = Frecuencia
                        If (Frecuencia > 1) Then
                            odtUnionItem.Rows(FILA)("NRPARC") = ""
                        End If
                    Else
                        Frecuencia = 1
                        oListOCParcial.Add(OC_PARCIAL, Frecuencia)
                    End If

                End If
            End If
        Next
        odtUnionItem.AcceptChanges()
        Return odtUnionItem
    End Function

    Private Function ObtieneFecha(ByVal odtCheckPointPreEmb As DataTable, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal NRITOC As Decimal, ByVal NESTDO As Decimal) As String
        Dim Fecha As String = ""
        Dim dr() As DataRow
        dr = odtCheckPointPreEmb.Select("CCLNT=" & CCLNT & " AND NORCML='" & NORCML & "' AND NRITOC=" & NRITOC & " AND NESTDO=" & NESTDO)
        If dr.Length > 0 Then
            Fecha = CNumero8Digitos_a_FechaDefault(dr(0)("FESEST"))
        End If
        Return Fecha
    End Function

    Private Function Dif_Fecha_CheckPoint(ByVal FechaMin As String, ByVal FechaMax As String) As Int32
        Dim dif As Int32 = -999 'no existe diferencia
        Dim Fecha As Date
        If (Date.TryParse(FechaMin, Fecha) AndAlso Date.TryParse(FechaMax, Fecha)) Then
            dif = DateDiff(DateInterval.Day, CDate(FechaMin), CDate(FechaMax))
        Else
            dif = -999
        End If
        Return dif
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

End Class
