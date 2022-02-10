Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports System.Xml 'CSR-HUNDRED-SGR-DAS-DMA-PMO-001
Imports System.Text 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001
Imports System.Configuration 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001

Public Class IntegracionPacasmayo

    Private _CCLNT As String = ""
    Private _LocalDirectory As String = ""
    'Private objListaGuias As New List(Of String)
    Private objListaGuias As New Hashtable
 

    Dim wsSolmin As New ws_sync ' CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO

    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    'Public Property ListaGuias() As List(Of String)
    '    Get
    '        Return objListaGuias
    '    End Get
    '    Set(ByVal value As List(Of String))
    '        objListaGuias = value
    '    End Set
    'End Property
    Public Property ListaGuias() As Hashtable
        Get
            Return objListaGuias
        End Get
        Set(ByVal value As Hashtable)
            objListaGuias = value
        End Set
    End Property

    


    Public Property LocalDirectory() As String
        Get
            Return _LocalDirectory
        End Get
        Set(ByVal value As String)
            _LocalDirectory = value
        End Set
    End Property

    Public Sub EnviarGuia()
        Try
            If IO.Directory.Exists("D:\SolminTramasEnvio") = False Then
                IO.Directory.CreateDirectory("D:\SolminTramasEnvio")
            End If

            If IO.Directory.Exists("D:\SolminTramasEnvio\Java") = False Then
                IO.Directory.CreateDirectory("D:\SolminTramasEnvio\Java")
            End If

            IO.File.Copy(LocalDirectory & "\Java\AppPacasmayoFinal.jar", "D:\SolminTramasEnvio\Java\AppPacasmayoFinal.jar", True)

            'copiando los archivos Jar
            LocalDirectory = "D:\SolminTramasEnvio"

            Dim lstr_nombre_archivo As String = LocalDirectory & "\Java\Pacasmayo_" & TodayNumeric() & "_" & NowNumeric() & ".txt"
            Dim lstr_archivo As New IO.StreamWriter(lstr_nombre_archivo, True)


            For Each item As DictionaryEntry In objListaGuias
                'For Each obj As String In Me.objListaGuias
                Dim dtb As New DataTable
                Dim lstr_trama As New Text.StringBuilder
                'dtb = getData(_CCLNT, obj)
                dtb = getData(_CCLNT, item.Key)

                Dim lstr_guia As String = ""

                'lstr_trama.Append(CompStr(obj.Trim(), 16, "0", Windows.Forms.HorizontalAlignment.Left))
                lstr_trama.Append(CompStr(("" & item.Value).ToString.Trim, 16, "0", Windows.Forms.HorizontalAlignment.Left))
                lstr_trama.Append("*")

                For i As Integer = 0 To dtb.Rows.Count - 1
                    'lstr_guia = CompStr(dtb.Rows(0).Item("nguirm").ToString.Trim(), 16, "0", Windows.Forms.HorizontalAlignment.Left)

                    lstr_trama.Append(CompStr((i + 1), 5, "0", Windows.Forms.HorizontalAlignment.Left))
                    lstr_trama.Append("#")
                    lstr_trama.Append(CompStr(dtb.Rows(i).Item("TCITCL").ToString.Trim(), 18, "0", Windows.Forms.HorizontalAlignment.Left))
                    lstr_trama.Append("#")
                    lstr_trama.Append(CompStr(NmbReplace(dtb.Rows(i).Item("QBLTSR").ToString.Trim()), 14, "0", Windows.Forms.HorizontalAlignment.Left))
                    lstr_trama.Append("#")
                    lstr_trama.Append(CompStr(dtb.Rows(i).Item("TUNDIT").ToString.Trim(), 3, "$", Windows.Forms.HorizontalAlignment.Right))
                    lstr_trama.Append("#")
                    lstr_trama.Append(CompStr(dtb.Rows(i).Item("NORCML").ToString.Trim(), 10, "0", Windows.Forms.HorizontalAlignment.Left))
                    lstr_trama.Append("#")
                    lstr_trama.Append(CompStr(dtb.Rows(i).Item("NRITOC").ToString.Trim(), 5, "0", Windows.Forms.HorizontalAlignment.Left))
                    lstr_trama.Append("!")
                Next
                lstr_archivo.WriteLine(lstr_trama.ToString)
            Next

            lstr_archivo.Flush()
            lstr_archivo.Close()
            lstr_archivo.Dispose()

            'creando el archivo bat a transferir via JavaApplication
            Me.CrearArchivoBAT(lstr_nombre_archivo)

        Catch ex As Exception
            MsgBox("Error al enviar trama a pacasmayo " & ex.ToString)
            Throw New Exception(ex.ToString)

        End Try
    End Sub

    Private Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    Private Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

    Private Sub CrearArchivoBAT(ByVal NombreArchivo As String)

        Dim lstr_archivo As String = LocalDirectory & "\Pacasmayo_" & TodayNumeric() & "_" & NowNumeric() & ".bat"
        Dim archivo As New System.IO.StreamWriter(lstr_archivo, False, System.Text.Encoding.ASCII)
        archivo.WriteLine("java -Xms128m -Xmx768m -jar Java\AppPacasmayoFinal.jar " & NombreArchivo)
        archivo.Close()
        archivo.Dispose()
        Process.Start(lstr_archivo)

    End Sub

    Public Function CompStr(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As Windows.Forms.HorizontalAlignment)
        Dim longitudActual As Integer = Texto.Length
        If longitudActual <= Longitud Then
            For i As Integer = longitudActual To Longitud - 1
                If Orientacion = Windows.Forms.HorizontalAlignment.Right Then
                    Texto = Texto & Caracter
                Else
                    Texto = Caracter & Texto
                End If
            Next
        Else
            Texto = Texto.Substring(0, Longitud)
        End If
        Return Texto
    End Function

    Public Function NmbReplace(ByVal lstrNum As String) As String
        Dim lstr_numreplace As String = ""
        lstr_numreplace = lstrNum.Substring(0, (lstrNum.IndexOf(".") + 4))
        Return lstr_numreplace
    End Function

    Public Function getData(ByVal lstr_cclnt, ByVal lstr_nguirm) As DataTable
        Dim dtb As New DataTable
        'Try
        Dim lstr_sql As String
        lstr_sql = ""
        lstr_sql = lstr_sql & " SELECT      "
        '  lstr_sql = lstr_sql & " r66.nguirm,	"
        lstr_sql = lstr_sql & " TRIM(r66.NGUIRS) nguirm,	"
        lstr_sql = lstr_sql & " R37. ncrrgr,"
        lstr_sql = lstr_sql & " R39.TCITCL,	"
        lstr_sql = lstr_sql & " R66.QBLTSR ,"
        lstr_sql = lstr_sql & " R39.TUNDIT,	"
        lstr_sql = lstr_sql & " R39.NORCML,	"
        lstr_sql = lstr_sql & " R39.NRITOC	"
        lstr_sql = lstr_sql & " FROM RZIM36 R36  "
        lstr_sql = lstr_sql & " JOIN RZIM37 R37 ON R37.CCLNT=R36.CCLNT AND R37.NGUIRM=R36.NGUIRM AND      R37.SESTRG<>'*'    "
        lstr_sql = lstr_sql & " JOIN RZOL66 R66 ON R66.CCLNT=R37.CCLNT AND (R66.NGUIRM=R36.NGUIRM OR R66.NGUIRM=R36.NGUIRO )  AND     R66.CREFFW=R37.CREFFW  AND R66.SESTRG<>'*' "
        lstr_sql = lstr_sql & " JOIN RZOL39 R39 ON R39.CCLNT=R66.CCLNT  AND  R39.NORCML= R66.NORCML AND    R39.NRITOC= R66.NRITOC  "
        lstr_sql = lstr_sql & " WHERE R36.CCLNT=" & lstr_cclnt & " AND R36.NGUIRM=" & lstr_nguirm

        dtb = New SqlManager().ExecuteDataTable(lstr_sql)
        'Catch ex As Exception
        'End Try
        Return dtb
    End Function

    Dim outputSOAP As New DataSet
    'CSR-HUNDRED-CORRECTIVO-SOLMIN-INICIO
    Public Sub EnviarGuiaNet()
        outputSOAP = EnviarListaGuia()

        If outputSOAP.Tables.Count > 0 Then
            XMLLogEvent(outputSOAP)
        Else
            MsgBox("Error en la comunicacion con el servicio.")
        End If

    End Sub

    Private Function CreateWebRequest(ByVal url As String, ByVal action As String) As Net.HttpWebRequest

        Dim webRequest As Net.HttpWebRequest = CType(Net.WebRequest.Create(url), Net.HttpWebRequest)
        webRequest.Headers.Add("SOAPAction", action)
        webRequest.ContentType = "text/xml;charset=""utf-8"""
        webRequest.Accept = "text/xml"
        webRequest.Method = "POST"
        Return webRequest
    End Function

    Private Sub InsertSoapEnvelopeIntoWebRequest(ByRef soapEnvelopeXml As XmlDocument, ByRef webRequest As Net.HttpWebRequest)

        Using stream As IO.Stream = webRequest.GetRequestStream()
            soapEnvelopeXml.Save(stream)
        End Using
    End Sub

    Function EnviarListaGuia() As DataSet
        Dim ds As New DataSet()
        Try
            Dim _url As String = ConfigurationSettings.AppSettings("UrlServWeb") '"http://intranet.cpsaa.com.pe/Portal/publico/ServiciosWeb.nsf/WS-ValidaGuiaSOAP"  
            Dim _action As String = ConfigurationSettings.AppSettings("SoapAction") '"http://intranet.cpsaa.com.pe/Portal/publico/ServiciosWeb.nsf/WS-ValidaGuiaSOAP/validaGuia" 
            Dim xd As XmlDocument = New XmlDocument()
            Dim soapEnvelopeXml As XmlDocument = GenerarGuiasSoap()
            Dim webRequest As Net.HttpWebRequest = CreateWebRequest(_url, _action)
            Dim elemList As XmlNodeList


            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest)

            Dim asyncResult As IAsyncResult = webRequest.BeginGetResponse(Nothing, Nothing)
            asyncResult.AsyncWaitHandle.WaitOne()

            Dim soapResult As String
            Using webResponse As Net.WebResponse = webRequest.EndGetResponse(asyncResult)
                Using rd As IO.StreamReader = New IO.StreamReader(webResponse.GetResponseStream())
                    soapResult = rd.ReadToEnd()
                    xd.LoadXml(soapResult) 'Convertimos el String a XML 
                    elemList = xd.GetElementsByTagName("estatus") 'Obtenemos el resultado del nodo
                    Dim Resultado = elemList(0).InnerXml
                    If Resultado = 1 Then 'Verifica si el envio fue correcto
                        Dim xmlBytes As Byte() = Encoding.UTF8.GetBytes(soapResult)
                        Dim memory As IO.Stream = New IO.MemoryStream(xmlBytes)
                        ds.ReadXml(memory)
                    Else
                        GuardarLog(soapResult) 'Evidencia Error
                    End If
                End Using
            End Using
        Catch ex As Exception
            GuardarLog(String.Format("Error en método EnviarListaGuia: {0}", ex.Message))
        End Try
        Return ds
    End Function

    Function GenerarGuiasSoap() As XmlDocument 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001

        Dim soapEnvelop As XmlDocument = New XmlDocument()
        Dim tramaSoap As New Text.StringBuilder

        For Each item As DictionaryEntry In objListaGuias
            'For Each guias As String In objListaGuias
            'Dim dataGuias As DataTable = getData(_CCLNT, guias)
            'Dim numeroGuias As String = guias.PadLeft(16, "0"c)
            Dim dataGuias As DataTable = getData(_CCLNT, item.Key)
            Dim numeroGuias As String = ("" & item.Value).ToString.Trim.PadLeft(16, "0"c)

            tramaSoap.AppendLine("<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""  xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv = ""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:urn=""urn:DefaultNamespace""> <soapenv:Header/> <soapenv:Body> <urn:validaGuia soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/""> <listaGuias xsi:type=""urn:ListGuias""> <idUsuario xsi:type=""xsd:string"">" & ConfigurationSettings.AppSettings("Usuario") & "</idUsuario> <password xsi:type=""xsd:string"">" & ConfigurationSettings.AppSettings("Password") & "</password> <estatus xsi:type=""xsd:string""></estatus><listaGuia xsi:type=""urn:BeanGuia"">")
            tramaSoap.AppendLine("<numeroGuia xsi:type=""xsd:string"">" & numeroGuias & "</numeroGuia>")

            For posicion As Integer = 0 To dataGuias.Rows.Count - 1
                tramaSoap.AppendLine(String.Format("<listPosicion xsi:type=""xsd:string"">{0}¬{1}¬{2}¬{3}¬{4}¬{5}</listPosicion>", CompStr((posicion + 1), 5, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("TCITCL").ToString.Trim(), 18, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(NmbReplace(dataGuias.Rows(posicion).Item("QBLTSR").ToString.Trim()), 14, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("TUNDIT").ToString.Trim(), 3, " ", Windows.Forms.HorizontalAlignment.Right), CompStr(dataGuias.Rows(posicion).Item("NORCML").ToString.Trim(), 10, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("NRITOC").ToString.Trim(), 5, "0", Windows.Forms.HorizontalAlignment.Left)))
            Next posicion
            tramaSoap.AppendLine(String.Format("</listaGuia>"))
            tramaSoap.AppendLine("</listaGuias> </urn:validaGuia> </soapenv:Body></soapenv:Envelope>")
        Next

        soapEnvelop.LoadXml(tramaSoap.ToString())
        Return soapEnvelop

    End Function
    'CSR-HUNDRED-CORRECTIVO-SOLMIN-FIN

    'Public Sub EnviarGuiaNet() 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001: Creación del método EnviarGuiaNet    
    '    outputSOAP = EnviarListaGuia(GenerarGuiasSoap())
    '    If outputSOAP.Tables.Count > 0 Then
    '        XMLLogEvent(outputSOAP)
    '    Else
    '        MsgBox("Error en la comunicacion con el servicio.")
    '    End If

    'End Sub

    'Function EnviarListaGuia(ByVal guias As String) As DataSet 
    'Dim ds As New DataSet()
    'Try
    '    Dim tramaSOAP
    '    tramaSOAP = "<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" " & _
    '              " xmlns:xsd = ""http://www.w3.org/2001/XMLSchema""" & _
    '              " xmlns:soapenv = ""http://schemas.xmlsoap.org/soap/envelope/""" & _
    '              " xmlns:urn=""urn:DefaultNamespace"">" & _
    '                 " <soapenv:Header/>" & _
    '                  " <soapenv:Body>" & _
    '                   " <urn:validaGuia soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">" & _
    '                    " <listaGuias xsi:type=""urn:ListGuias"">" & _
    '                      " <idUsuario xsi:type=""xsd:string"">" & ConfigurationSettings.AppSettings("Usuario") & "</idUsuario>" & _
    '                      " <password xsi:type=""xsd:string"">" & ConfigurationSettings.AppSettings("Password") & "</password>" & _
    '                      " <estatus xsi:type=""xsd:string"">" & "" & "</estatus>" & _
    '                         guias.ToString & _
    '                       " </listaGuias>" & _
    '                     " </urn:validaGuia>" & _
    '                  " </soapenv:Body>" & _
    '                "</soapenv:Envelope>"

    'Dim soap As Object
    'soap = CreateObject("MSXML2.ServerXMLHTTP")
    'soap.open("post", ConfigurationSettings.AppSettings("UrlServWeb"), False)
    'soap.setRequestHeader("Content-Type", "text/xml")
    'soap.setRequestHeader("soapAction", ConfigurationSettings.AppSettings("SoapAction"))
    'soap.setTimeouts(90000, 90000, 90000, 90000)
    '' soap.send(tramaSOAP)

    'Dim outputSOAP As New XmlDocument()

    'If soap.status = 200 Then
    '    outputSOAP.LoadXml(CStr(soap.responseText))
    'Else
    '    outputSOAP.LoadXml(CStr(soap.responseText))
    '    GuardarLog(CStr(soap.responseText)) 'Evidencia Error
    'End If

    'Dim responseSOAP As String
    'responseSOAP = CStr(soap.responseText)

    'Dim xmlBytes As Byte() = Encoding.UTF8.GetBytes(responseSOAP)
    'Dim memory As IO.Stream = New IO.MemoryStream(xmlBytes)
    'ds.ReadXml(memory)

    '    Catch ex As Exception
    '        GuardarLog(String.Format("Error en método EnviarListaGuia: {0}", ex.Message))
    '    End Try

    '    Return ds
    'End Function

    'Function GenerarGuiasSoap() As String 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001
    '    Dim tramaSoap As New Text.StringBuilder

    '    For Each guias As String In objListaGuias
    '        Dim dataGuias As DataTable = getData(_CCLNT, guias)
    '        Dim numeroGuias As String = guias.PadLeft(16, "0"c) 'ECM-CorrectivoSolmin(SA_SC_CTZ)-[300516]
    '        tramaSoap.AppendLine(String.Format("<listaGuia xsi:type=""urn:BeanGuia"">"))
    '        tramaSoap.AppendLine(String.Format("<numeroGuia xsi:type=""xsd:string"">" & numeroGuias & "</numeroGuia>"))

    '        For posicion As Integer = 0 To dataGuias.Rows.Count - 1
    '            tramaSoap.AppendLine(String.Format("<listPosicion xsi:type=""xsd:string"">{0}¬{1}¬{2}¬{3}¬{4}¬{5}</listPosicion>", CompStr((posicion + 1), 5, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("TCITCL").ToString.Trim(), 18, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(NmbReplace(dataGuias.Rows(posicion).Item("QBLTSR").ToString.Trim()), 14, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("TUNDIT").ToString.Trim(), 3, " ", Windows.Forms.HorizontalAlignment.Right), CompStr(dataGuias.Rows(posicion).Item("NORCML").ToString.Trim(), 10, "0", Windows.Forms.HorizontalAlignment.Left), CompStr(dataGuias.Rows(posicion).Item("NRITOC").ToString.Trim(), 5, "0", Windows.Forms.HorizontalAlignment.Left)))
    '        Next posicion

    '        tramaSoap.AppendLine(String.Format("</listaGuia>"))
    '    Next

    '    Return tramaSoap.ToString
    'End Function

    Sub XMLLogEvent(ByVal ResponseSOAP As DataSet) 'CSR-HUNDRED-SGR-DAS-DMA-PMO-001
        Dim dtMultiRef As DataTable = ResponseSOAP.Tables("multiRef")
        Dim dtListPosicion As DataTable = ResponseSOAP.Tables("listPosicion")
        Dim rowDataGeneral As DataRow = dtMultiRef.Rows(0)
        Dim dv As New DataView(dtListPosicion)
        Dim construirTrama As New Text.StringBuilder
        Dim numeroGuias As String = String.Empty 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
        Dim contadorGuias As Integer = 0 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)

        'Obtener datos de la cabecera
        Dim usuario As String = rowDataGeneral("idUsuario").ToString()
        Dim password As String = rowDataGeneral("password").ToString()
        Dim estatus As String = rowDataGeneral("estatus").ToString()
        Try
            ' 
            For Each rowMultiRef As DataRow In dtMultiRef.Rows
                If estatus = 1 Then
                    'For Each guias As String In objListaGuias
                    For Each item As DictionaryEntry In objListaGuias
                        construirTrama.AppendLine("<DATAROW>")
                        construirTrama.AppendLine("<CODIGO>" & estatus & "</CODIGO>")
                        'construirTrama.AppendLine("<NUMEROGUIA>" & guias & "</NUMEROGUIA>")
                        construirTrama.AppendLine("<NUMEROGUIA>" & ("" & item.Key).ToString.Trim & "</NUMEROGUIA>")

                        construirTrama.AppendLine("<MENSAJE>PROCESO COMPLETO!</MENSAJE>")
                        'ActualizarGuia(guias)
                        ActualizarGuia(item.Key)
                        construirTrama.AppendLine("</DATAROW>")
                        'numeroGuias = numeroGuias & CStr(guias) & ","
                        numeroGuias = numeroGuias & CStr(item.Key) & ","
                        contadorGuias += 1
                    Next
                Else
                    Dim idMultiRef = rowMultiRef("multiRef_id")
                    If idMultiRef > 0 Then
                        dv = New DataView(dtListPosicion, "multiRef_id =" & idMultiRef, "multiRef_id", DataViewRowState.CurrentRows)
                        Dim dtfilter As New DataTable
                        dtfilter = dv.ToTable()

                        For Each rowFilter As DataRow In dtfilter.Rows

                            Dim idListPosicion = rowFilter("multiRef_id")
                            If idMultiRef = idListPosicion Then
                                Dim numeroGuia As String = rowMultiRef("numeroGuia")
                                Dim listaPosicion As String = rowFilter("listPosicion_text").replace("¬", "|")

                                Select Case estatus

                                    Case "0"
                                        construirTrama.AppendLine("<DATAROW>")
                                        construirTrama.AppendLine("<CODIGO>" & estatus & "</CODIGO>")
                                        construirTrama.AppendLine("<MENSAJE>ERROR</MENSAJE>")
                                        construirTrama.AppendLine("<POSICION>" & listaPosicion & " </POSICION>")
                                        construirTrama.AppendLine("</DATAROW>")

                                    Case "2"
                                        construirTrama.AppendLine("<DATAROW>")
                                        construirTrama.AppendLine("<CODIGO>" & estatus & "</CODIGO>")
                                        construirTrama.AppendLine("<POSICION>" & listaPosicion & " </POSICION>")
                                        construirTrama.AppendLine("</DATAROW>")

                                    Case "3"
                                        construirTrama.AppendLine("<DATAROW>")
                                        construirTrama.AppendLine("<CODIGO>" & estatus & "</CODIGO>")
                                        construirTrama.AppendLine("<MENSAJE>ERROR DE PASSWORD</MENSAJE>")
                                        construirTrama.AppendLine("<POSICION>" & listaPosicion & " </POSICION>")
                                        construirTrama.AppendLine("</DATAROW>")

                                    Case Else
                                        construirTrama.AppendLine("<DATAROW>")
                                        construirTrama.AppendLine("<CODIGO>" & estatus & "</CODIGO>")
                                        construirTrama.AppendLine("<MENSAJE>ERROR INESPERADO!</MENSAJE>")
                                        construirTrama.AppendLine("<POSICION>" & listaPosicion & " </POSICION>")
                                        construirTrama.AppendLine("</DATAROW>")
                                End Select
                            End If
                        Next
                    End If
                End If
                GuardarLog(construirTrama.ToString())
                GuardarLog("Termina Proceso envio a CPSAA")
            Next

            If Len(numeroGuias) > 0 Then 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
                If contadorGuias = 1 Then
                    MsgBox(String.Format("La guía {0} se enviaron con éxito.", Mid(numeroGuias, 1, Len(numeroGuias) - 1)), MsgBoxStyle.Information, "Información")
                Else
                    MsgBox(String.Format("Las guías {0} se enviaron con éxito.", Mid(numeroGuias, 1, Len(numeroGuias) - 1)), MsgBoxStyle.Information, "Información")
                End If
            End If

        Catch ex As Exception
            GuardarLog("ERROR EN WebService " + ex.ToString())
        End Try

    End Sub

    Sub ActualizarGuia(ByVal guia As String) 'ECM-HUNDRED-SGR-DAS-DMA-PMO-001
        Dim resultado As Boolean = False

        Try

            GuardarLog("Guia por actualizar : " + guia + " -> inicia")
            wsSolmin.ActualizarGuia("CPSAA", "INTEGRACION", "16168", guia, "SOLMINWEB")

            GuardarLog("Guia actualizada : " + guia + " -> termina")
            wsSolmin.ActualizarGuia("CPSAA", "INTEGRACION", "21625", guia, "SOLMINWEB")

            GuardarLog("Guia actualizada : " + guia + " -> termina")
            wsSolmin.ActualizarGuia("CPSAA", "INTEGRACION", "48035", guia, "SOLMINWEB")

            GuardarLog("Guia actualizada : " + guia + " -> termina")
            wsSolmin.ActualizarGuia("CPSAA", "INTEGRACION", "20337", guia, "SOLMINWEB")

            GuardarLog("Guia actualizada : " + guia + " -> termina")
            wsSolmin.ActualizarGuia("CPSAA", "INTEGRACION", "58342", guia, "SOLMINWEB")


            GuardarLog("Guia actualizada : " + guia + " -> termina")
            resultado = True

        Catch ex As Exception
            GuardarLog("Error al guardar guia " + guia + " por " + ex.ToString())
            resultado = False

        End Try
    End Sub

    Sub GuardarLog(ByVal texto As String)
        wsSolmin.TraceLogCPSAA(texto)
    End Sub

End Class
