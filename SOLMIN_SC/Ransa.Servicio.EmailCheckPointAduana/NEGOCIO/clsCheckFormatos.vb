Imports System.Text
Public Class clsCheckFormatos
    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"

  
    Public Function DatosCuerpoEnvioChekPoint_F1(ByVal dtDatosEmb As DataTable, ByVal dtObsEmb As DataTable, ByVal dtOCEmb As DataTable, ByVal dtCheckPoint As DataTable, ByVal CodCliente As Decimal, ByVal Embarque As Decimal, ByVal DescCliente As String, ByVal Usuario As String, ByVal CodChkUltModif As Decimal) As String

        Dim Dato As String = ""

        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append(DescCliente)
        bodyemail.Append(" el ")
        bodyemail.Append(Now.ToString("dd/MM/yyyy"))
        bodyemail.Append(" se ha registrado el siguiente evento  (*)")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")

        bodyemail.Append("<td>")
        bodyemail.Append("Nro Embarque")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(Embarque.ToString)
        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("TNMMDT").ToString.Trim
            If (Dato = "") Then
                Dato = "-"
            End If
        End If
        bodyemail.Append(" ")
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")

        bodyemail.Append("<td>")
        bodyemail.Append("Orden de Servicio:")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("PNNMOS")
            If (Dato = 0) Then
                Dato = ""
            End If
        End If
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td>")
        bodyemail.Append("Pa&iacute;s Origen")
        bodyemail.Append("</td>")

        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("TCMPPS").ToString.Trim
            If (Dato = "") Then
                Dato = "-"
            End If
        End If
        bodyemail.Append("<td>")
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td>")
        bodyemail.Append("Agente Carga")
        bodyemail.Append("</td>")
        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("TNMAGC").ToString.Trim
            If (Dato = "") Then
                Dato = "-"
            End If
        End If
        bodyemail.Append("<td>")
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td>")
        bodyemail.Append("Fecha ETD/ETA")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(CNumero8Digitos_a_FechaDefault(dtDatosEmb.Rows(0)("FAPREV")))
        bodyemail.Append("-")
        bodyemail.Append(CNumero8Digitos_a_FechaDefault(dtDatosEmb.Rows(0)("FAPRAR")))
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td>")
        bodyemail.Append("Canal")
        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("TCANAL").ToString.Trim
            If (Dato = "") Then
                Dato = "-"
            End If
        End If
        bodyemail.Append("<td>")
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td>")

        bodyemail.Append("DUA")
        bodyemail.Append("</td>")

        If (dtDatosEmb.Rows.Count > 0) Then
            Dato = dtDatosEmb.Rows(0)("TNRODU").ToString.Trim
            If (Dato = "") Then
                Dato = "-"
            End If
        End If
        bodyemail.Append("<td>")
        bodyemail.Append(Dato)
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        For Each Item As DataRow In dtCheckPoint.Rows

            If ("" & Item("MODIFICADO")).ToString.Trim = "X" Then
                bodyemail.Append("<tr>")
                bodyemail.Append("<td>")
                bodyemail.Append("<span  style='color:Red'>")
                bodyemail.Append(Item("TDESES_HTML").ToString.Trim)
                bodyemail.Append("</span>")
                bodyemail.Append("</td>")
                bodyemail.Append("<td>")
                bodyemail.Append("<span  style='color:Red'>")
                bodyemail.Append(CNumero8Digitos_a_FechaDefault(Item("F_FIN_VER")))
                If (CodChkUltModif = Item("NESTDO")) Then
                    bodyemail.Append(" * ")
                End If
                bodyemail.Append("</span>")
                bodyemail.Append("</td>")

                bodyemail.Append("</tr>")
            Else
                bodyemail.Append("<tr>")
                bodyemail.Append("<td>")
                bodyemail.Append("<span  style='color:Red'>")
                bodyemail.Append(Item("TDESES_HTML"))
                bodyemail.Append("</span>")
                bodyemail.Append("</td>")
                bodyemail.Append("<td>")
                bodyemail.Append("<span  style='color:Red'>")
                bodyemail.Append(CNumero8Digitos_a_FechaDefault(Item("F_FIN_VER")))
                bodyemail.Append("</td>")
                bodyemail.Append("</span>")
                bodyemail.Append("</td>")

                bodyemail.Append("</tr>")
            End If

        Next


       
        Dim Tot_Cantidad As Integer = 0



        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='6'>")

        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td >")

        bodyemail.Append("Orden/Compra")

        bodyemail.Append("</td>")
        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Proveedor")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Item")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Descripci&oacute;n")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("Cantidad")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("BU")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")
        For Each dr As DataRow In dtOCEmb.Rows
            bodyemail.Append("<tr>")

            bodyemail.Append("<td >")
            bodyemail.Append(dr("NORCML"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(dr("TPRVCL"))
            bodyemail.Append("</td>")
            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("NRITEM"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(dr("TDITES"))
            bodyemail.Append("</td>")
            bodyemail.Append("<td>")
            bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QRLCSC"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
            bodyemail.Append(dr("TUNDIT"))
            bodyemail.Append("</td>")

            bodyemail.Append("<td>")
            bodyemail.Append(dr("BU").ToString.Trim)
            bodyemail.Append("</td>")

            bodyemail.Append("</tr>")

            Tot_Cantidad += dr("QRLCSC")


        Next

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='6'>")

        bodyemail.Append("<hr style='border:1px dotted; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td></td>")
        bodyemail.Append("<td></td>")
        bodyemail.Append("<td></td>")
        bodyemail.Append("<td>")

        bodyemail.Append("Total: ")
        bodyemail.Append(dtOCEmb.Rows.Count)
        bodyemail.Append(" Items")
        bodyemail.Append("</td>")


        bodyemail.Append("<td>")
        bodyemail.Append(Tot_Cantidad.ToString)
        bodyemail.Append(" Unidades")
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
        bodyemail.Append(Usuario)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function


    Private Function GetFechaChk(ByVal dtChk As DataTable, ByVal NESTDO As Decimal) As String
        Dim fecha As String = ""
        Dim dr() As DataRow
        dr = dtChk.Select("NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            fecha = CNumero8Digitos_a_FechaDefault(dr(0)("F_FIN_VER"))
        End If
        Return fecha
    End Function

    Public Function DatosCuerpoEnvioChekPoint_F2(ByVal dtDatosEmb As DataTable, ByVal dtObsEmb As DataTable, ByVal dtOCEmb As DataTable, ByVal dtCheckPoint As DataTable, ByVal CodCliente As Decimal, ByVal Embarque As Decimal, ByVal DescCliente As String, ByVal Usuario As String, ByVal CodChkUltModif As Decimal) As String

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

        For Each dtRow As DataRow In dtOCEmb.Rows
            If tmpNORCML <> dtRow("NORCML").ToString.Trim Then
                dtInfoCarga.Rows.Add(New Object() {dtRow("TNOMCOM").ToString.Trim, dtRow("NORCML").ToString.Trim, dtRow("TPRVCL").ToString.Trim})
            End If
            tmpNORCML = dtRow("NORCML").ToString.Trim
        Next


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
        bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO IMPORTACIONES " & DescCliente & " – " & CodCliente.ToString & "</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td style='padding:20px 0'>")
        bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td align='left' valign='top'><img src='" & UrlBanner & "' width='600' height='110' border='0'></td>")

        Select Case dtDatosEmb.Rows(0)("TCANAL").ToString.ToUpper
            Case "ROJO"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoRojo & "' width='59' height='110' border='0'></td>")
            Case "NARANJA"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoNaranja & "' width='59' height='110' border='0'></td>")
            Case "VERDE"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoVerde & "' width='59' height='110' border='0'></td>")
            Case Else

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoBlanco & "' width='59' height='110' border='0'></td>")
        End Select

        bodyemail.Append("			</tr>")
        bodyemail.Append("		</table>")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>INFORMACIÓN DE LA CARGA - EMB NRO " & dtDatosEmb.Rows(0)("NORSCI") & "</td>")
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
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & dtDatosEmb.Rows(0)("PNNMOS") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & dtDatosEmb.Rows(0)("NDOCEM") & "</td>")
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
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TCMPPS") & "/" & dtDatosEmb.Rows(0)("LUGAR_ORIGEN") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>DESTINO</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TCMPPS_DES") & "/" & dtDatosEmb.Rows(0)("LUGAR_DESTINO") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TRANSPORTE</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TNMMDT") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO REGIMEN</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("REGIMEN") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO DESPACHO</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TIPO_DESPACHO") & "</td>")
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
        bodyemail.Append(GetFechaChk(dtCheckPoint, 107))
        bodyemail.Append("</td>")
        bodyemail.Append("					<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
        bodyemail.Append(CNumero8Digitos_a_FechaDefault(dtDatosEmb.Rows(0)("FAPRAR")))
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
        bodyemail.Append(GetFechaChk(dtCheckPoint, 108))
        bodyemail.Append("</td>")
        bodyemail.Append("              <td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
        bodyemail.Append(GetFechaChk(dtCheckPoint, 165))
        bodyemail.Append("</td>")
        bodyemail.Append("              <td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
        bodyemail.Append(GetFechaChk(dtCheckPoint, 116))
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
        bodyemail.Append(GetFechaChk(dtCheckPoint, 121))
        bodyemail.Append("</td>")


        Select Case dtDatosEmb.Rows(0)("TCANAL").ToString.ToUpper
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
        bodyemail.Append(GetFechaChk(dtCheckPoint, 123))
        bodyemail.Append("</td>")
        bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>")
        bodyemail.Append(GetFechaChk(dtCheckPoint, 124))
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
        If dtObsEmb.Rows.Count > 0 Then
            For Each Obsdr As DataRow In dtObsEmb.Rows
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

        For Each dr As DataRow In dtOCEmb.Rows
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
        bodyemail.Append(dtOCEmb.Rows.Count)
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
        bodyemail.Append(Usuario)
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function



    Public Function DatosCuerpoEnvioChekPoint_F3(ByVal dtDatosEmb As DataTable, ByVal dtObsEmb As DataTable, ByVal dtOCEmb As DataTable, ByVal dtCheckPoint As DataTable, ByVal CodCliente As Decimal, ByVal Embarque As Decimal, ByVal DescCliente As String, ByVal Usuario As String, ByVal CodChkUltModif As Decimal) As String

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

        For Each dtRow As DataRow In dtOCEmb.Rows
            If tmpNORCML <> dtRow("NORCML").ToString.Trim Then
                dtInfoCarga.Rows.Add(New Object() {dtRow("TNOMCOM").ToString.Trim, dtRow("NORCML").ToString.Trim, dtRow("TPRVCL").ToString.Trim})
            End If
            tmpNORCML = dtRow("NORCML").ToString.Trim
        Next


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
        bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO IMPORTACIONES " & DescCliente & " – " & CodCliente.ToString & "</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td style='padding:20px 0'>")
        bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td align='left' valign='top'><img src='" & UrlBanner & "' width='600' height='110' border='0'></td>")

        Select Case dtDatosEmb.Rows(0)("TCANAL").ToString.ToUpper
            Case "ROJO"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoRojo & "' width='59' height='110' border='0'></td>")
            Case "NARANJA"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoNaranja & "' width='59' height='110' border='0'></td>")
            Case "VERDE"

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoVerde & "' width='59' height='110' border='0'></td>")
            Case Else

                bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoBlanco & "' width='59' height='110' border='0'></td>")
        End Select

        bodyemail.Append("			</tr>")
        bodyemail.Append("		</table>")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>INFORMACIÓN DE LA CARGA - EMB NRO " & dtDatosEmb.Rows(0)("NORSCI") & "</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td style='padding:20px 0'>")
        bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'> <font color='white'> COMPRADOR  </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'> <font color='white'> ORDEN DE COMPRA </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'> <font color='white'>  PROVEEDOR  </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'> <font color='white'> O/S </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'> <font color='white'> BL/AWB  </font>  </th>")
        bodyemail.Append("			</tr>")
        'Informacion de carga
        For Each rowInfoCarga As DataRow In dtInfoCarga.Rows
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("TNOMCOM") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("NORCML") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & rowInfoCarga("TPRVCL") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & dtDatosEmb.Rows(0)("PNNMOS") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & dtDatosEmb.Rows(0)("NDOCEM") & "</td>")
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
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TCMPPS") & "/" & dtDatosEmb.Rows(0)("LUGAR_ORIGEN") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>DESTINO</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TCMPPS_DES") & "/" & dtDatosEmb.Rows(0)("LUGAR_DESTINO") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TRANSPORTE</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TNMMDT") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO REGIMEN</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("REGIMEN") & "</td>")
        bodyemail.Append("		</tr>")
        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO DESPACHO</td>")
        bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & dtDatosEmb.Rows(0)("TIPO_DESPACHO") & "</td>")
        bodyemail.Append("		</tr>")

        bodyemail.Append("		<tr>")
        bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>CANAL</td>")


        Select Case dtDatosEmb.Rows(0)("TCANAL").ToString.ToUpper
            Case "ROJO"
                bodyemail.Append("  <td valign='middle' style='padding:2px 4px'><p style='color:red;font-weight:700'>ROJO</p></td>")
            Case "NARANJA"
                bodyemail.Append(" <td valign='middle' style='padding:2px 4px'><p style='color:orange;font-weight:700'>NARANJA</p></td>")
            Case "VERDE"
                bodyemail.Append("	<td valign='middle' style='padding:2px 4px'><p style='color:green;font-weight:700'>VERDE</p></td>")
            Case Else
                bodyemail.Append("	<td valign='middle' style='padding:2px 4px'>&nbsp</td>")
        End Select


        bodyemail.Append("		</tr>")

        bodyemail.Append("	</table>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")



        'Select Case dtDatosEmb.Rows(0)("TCANAL").ToString.ToUpper
        '    Case "ROJO"
        '        bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:red;font-weight:700'>ROJO</p></td>")
        '    Case "NARANJA"
        '        bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:orange;font-weight:700'>NARANJA</p></td>")
        '    Case "VERDE"
        '        bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'><p style='color:green;font-weight:700'>VERDE</p></td>")
        '    Case Else
        '        bodyemail.Append("										<td style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'>&nbsp</td>")
        'End Select


        'bodyemail.Append("<tr>")
        'bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO DE LA CARGA</td>")
        'bodyemail.Append("</tr>")

        'bodyemail.Append("<tr>")
        'bodyemail.Append("<td style='padding:20px 0'>")


        'bodyemail.Append("	</td>")
        'bodyemail.Append("</tr>")

        'CHECK POINTS   
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td  style='padding-top:4px'>")

        bodyemail.Append("	<table width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>	")
        bodyemail.Append("	<tr>")
        bodyemail.Append("	  <th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>SEGUIMIENTO DE LA CARGA</th>")
        bodyemail.Append("	</tr>")
        bodyemail.Append("	<tr>")
        bodyemail.Append("	<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("	<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'><font color='white'>CHECKPOINT</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'><font color='white'>FECHA</font></th>")
        bodyemail.Append("			</tr>")

        For Each rowInfoCarga As DataRow In dtCheckPoint.Rows
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td style='border:1px solid #000' align='left' valign='middle'>" & rowInfoCarga("TDESES") & "</td>")
            bodyemail.Append("			<td style='border:1px solid #000' align='right' valign='middle'>" & IIf(rowInfoCarga("F_FIN_VER") <> 0, CNumero8Digitos_a_FechaDefault(rowInfoCarga("F_FIN_REAL")), "") & "</td>")
            bodyemail.Append("		</tr>")
        Next
        bodyemail.Append("	</table>")
        bodyemail.Append("	</td>")
        bodyemail.Append("	</tr>")
        bodyemail.Append("	</table>")
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        'End With



        bodyemail.Append("<tr>")
        'bodyemail.Append("	<td style='padding:0 0 20px'>")
        bodyemail.Append("	<td  style='padding-top:8px'>")
        bodyemail.Append("		<table width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>OBSERVACIONES</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("					<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")

        bodyemail.Append("<tr>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'>&nbsp</th>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> FECHA </font> </th>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> DESCRIPCI&Oacute;N </font> </th>")
        bodyemail.Append("	</tr>")
        'Parte dinamica
        Dim Obscorr As Integer = 0
        If dtObsEmb.Rows.Count > 0 Then
            For Each Obsdr As DataRow In dtObsEmb.Rows
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
        'bodyemail.Append("	<td>")
        bodyemail.Append("	<td  style='padding-top:8px'>")
        bodyemail.Append("<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>DETALLE DE CARGA</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("		<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> ORDEN COMPRA </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> PROVEEDOR </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'> <font color='white'> ITEM </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> DESCRIPCIÓN </font> </th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'> <font color='white'> CANTIDAD </font> </th>")
        bodyemail.Append("			</tr>")

        For Each dr As DataRow In dtOCEmb.Rows
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
        bodyemail.Append(dtOCEmb.Rows.Count)
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
        bodyemail.Append(Usuario)
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function

    Public Function DatosCuerpoEnvioChekPoint_F4(ByVal dtDatosEmb As DataTable, ByVal dtObsEmb As DataTable, ByVal dtOCEmb As DataTable, ByVal dtCheckPoint As DataTable, ByVal CodCliente As Decimal, ByVal Embarque As Decimal, ByVal DescCliente As String, ByVal Usuario As String) As String

        Dim Dato As String = ""
        Dim odaEmbarque As New clsEmbarqueEnvio

        Dim bodyemail As New StringBuilder
        Dim tmpNORCML As String = ""
        Dim UrlBanner As String = "http://asp.ransa.net/wsmineria/sgl_email/img/BannerF4.jpg"
        Dim UrlSemaforoRojo As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semafororojo.jpg"
        Dim UrlSemaforoNaranja As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoambar.jpg"
        Dim UrlSemaforoVerde As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoverde.jpg"
        Dim UrlSemaforoVerdeOscuro As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoverdeoscuro.jpg"
        Dim UrlSemaforoBlanco As String = "http://asp.ransa.net/wsmineria/sgl_email/img/semaforoblanco.jpg"

        Dim Open_Font As String = ""
        Dim Close_Font As String = "</font>"

        With dtDatosEmb
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
            bodyemail.Append("	<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>SEGUIMIENTO LOGISTICO AEREO " & DescCliente & " – " & CodCliente.ToString & "</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td style='padding:20px 0'>")
            bodyemail.Append("		<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("			<tr>")
            bodyemail.Append("				<td align='left' valign='top'><img src='" & UrlBanner & "' width='900' height='175' border='0'></td>")
            Select Case .Rows(0)("FLGTRF").ToString.Trim
                Case "2"
                    'Semaforo en rojo
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoRojo & "' width='75' height='175' border='0'></td>")
                    Open_Font = "<font color='RED'>"
                Case "1"
                    'Semaforo en verde oscuro
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoVerdeOscuro & "' width='75' height='175' border='0'></td>")
                    Open_Font = "<font color='DARKGREEN'>" 'GREEN
                Case Else
                    bodyemail.Append("				<td align='right' valign='top'><img src='" & UrlSemaforoBlanco & "' width='75' height='175' border='0'></td>")
                    Open_Font = "<font color='BLACK'>"
            End Select

            bodyemail.Append("			</tr>")
            bodyemail.Append("		</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("</tr>")
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='border:1px solid #000;padding:5px 0;font-weight:700' align='center' valign='middle'>INFORMACIÓN DE LA CARGA - EMB NRO " & .Rows(0)("NORSCI") & "</td>")
            bodyemail.Append("</tr>")

            'INFORMACIÓN DE LA CARGA  -
            bodyemail.Append("		<tr>")
            bodyemail.Append("<td  style='padding-top:4px'> ")
            bodyemail.Append("	<table style='border:1px solid #000' width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>ORIGEN</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TCMLCL_ORIGEN") & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("	    <tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'></td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TDRCOR").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>DESTINO</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TCMLCL_DESTINO").ToString.Trim & "</td>")
            bodyemail.Append("	   </tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'></td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TDREN2").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>DOC. EMB.</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("NDOCEM").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TIPO CARGA</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'><b>" & Open_Font & .Rows(0)("TIPO_TARIFA").ToString.Trim.ToUpper & Close_Font & "</b></td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>MEDIO TRANSPORTE</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TNMMDT").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>TRANSPORTE</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TNMCIN").ToString.Trim & " - " & .Rows(0)("NAVE").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>MERCADERÍA</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & .Rows(0)("TOBERV").ToString.Trim & "</td>")
            bodyemail.Append("		</tr>")

            bodyemail.Append("		<tr>")
            bodyemail.Append("			<td valign='middle' style='border-right:1px solid #000;font-weight:700;padding:2px 4px'>GUÍAS</td>")
            bodyemail.Append("			<td valign='middle' style='padding:2px 4px'>" & ListarGuias(dtOCEmb) & "</td>")
            bodyemail.Append("		</tr>")
            bodyemail.Append("	</table>")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")

            'CHECK POINTS   
            bodyemail.Append("<tr>")
            bodyemail.Append("	<td  style='padding-top:4px'>")

            bodyemail.Append("	<table width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>	")
            bodyemail.Append("	<tr>")
            bodyemail.Append("	  <th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>SEGUIMIENTO DE LA CARGA</th>")
            bodyemail.Append("	</tr>")
            bodyemail.Append("	<tr>")
            bodyemail.Append("	<td valign='middle' style='padding-top:4px'>")
            bodyemail.Append("	<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
            bodyemail.Append("			<tr>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'><font color='white'>CHECKPOINT</font></th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'><font color='white'>FECHA</font></th>")
            bodyemail.Append("				<th bgcolor='#00b050' style='border:1px solid #000' align='center' valign='middle'><font color='white'>OBSERVACION SEG.</font></th>")
            bodyemail.Append("			</tr>")

            For Each rowInfoCarga As DataRow In dtCheckPoint.Rows
                bodyemail.Append("		<tr>")
                bodyemail.Append("			<td style='border:1px solid #000' align='left' valign='middle'>" & rowInfoCarga("TDESES") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='center' valign='middle'>" & IIf(rowInfoCarga("F_FIN_VER") <> 0, CNumero8Digitos_a_FechaDefault(rowInfoCarga("F_FIN_REAL")), "") & "</td>")
                bodyemail.Append("			<td style='border:1px solid #000' align='left' valign='middle'>" & rowInfoCarga("OBS") & "</td>")
                bodyemail.Append("		</tr>")
            Next
            bodyemail.Append("	</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("	</tr>")
            bodyemail.Append("	</table>")
            bodyemail.Append("	</td>")
            bodyemail.Append("</tr>")
        End With

        'OBSERVACIONES
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td  style='padding-top:4px'>")
        bodyemail.Append("		<table width='50%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>OBSERVACIONES</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("					<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")

        bodyemail.Append("<tr>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'>&nbsp</th>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>FECHA</font></th>")
        bodyemail.Append("	<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>DESCRIPCI&Oacute;N</font></th>")
        bodyemail.Append("	</tr>")
        'Parte dinamica
        Dim Obscorr As Integer = 0
        If dtObsEmb.Rows.Count > 0 Then
            For Each Obsdr As DataRow In dtObsEmb.Rows
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

        Dim Tot_Cantidad As Decimal = 0
        Dim Tot_Bultos As Decimal = 0
        Dim Tot_Peso As Decimal = 0
        'DETALLE  
        bodyemail.Append("<tr>")
        bodyemail.Append("	<td  style='padding-top:4px'>")
        bodyemail.Append("<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<th valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'>DETALLE DE CARGA</th>")
        bodyemail.Append("			</tr>")
        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td valign='middle' style='padding-top:4px'>")
        bodyemail.Append("		<table width='100%' border='0' align='left' cellpadding='0' cellspacing='0'>")
        bodyemail.Append("			<tr>")

        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>BULTO</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>GUÍA PROVEEDOR</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>GUÍA REMISIÓN</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>CANTIDAD</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'><font color='white'>UNID BULTO</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 0px'><font color='white'>PESO(KGS)</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>O/C</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>PROVEEDOR</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>ITEM</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>DESCRIPCIÓN</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>CANTIDAD</font></th>")
        bodyemail.Append("				<th bgcolor='#00b050' valign='middle' align='center' style='border:1px solid #000;padding:2px 4px'><font color='white'>UNID MED.</font></th>")
        bodyemail.Append("			</tr>")


        'GENERA DETALLE
        Dim Bulto As String = ""
        For Each dr As DataRow In dtOCEmb.Rows
            bodyemail.Append("			<tr>")
            Bulto = ""
            If Not String.IsNullOrEmpty(dr("CREFFW").ToString.Trim) Then
                Bulto = dr("CREFFW").ToString.Trim & "-" & dr("DESC_BULTO").ToString.Trim
            End If
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(Bulto)
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("NGRPRV"))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("NUMDCR"))
            bodyemail.Append("              </td>")
            If ("" & dr("QBULTOS")).ToString.Trim = "" Then
                bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
                bodyemail.Append("")
                bodyemail.Append("              </td>")
            Else
                bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
                bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QBULTOS"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
                bodyemail.Append("              </td>")
            End If


            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='left' valign='middle'>")
            bodyemail.Append(dr("TIPBTO"))
            bodyemail.Append("              </td>")

            If ("" & dr("QPSOMR")).ToString.Trim = "" Then
                bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='left' valign='middle'>")
                bodyemail.Append("")
                bodyemail.Append("              </td>")
            Else
                bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='left' valign='middle'>")
                bodyemail.Append(dr("QPSOMR"))
                bodyemail.Append("              </td>")
            End If

            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("NORCML"))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")

            bodyemail.Append(dr("TPRVCL"))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("NRITEM"))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("TDITES"))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(FHTML_RIGHT(Math.Round(dr("QSEG"), 0).ToString.PadLeft(3, "0"), 5, CharRelleno))
            bodyemail.Append("              </td>")
            bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'>")
            bodyemail.Append(dr("TUNDIT"))
            bodyemail.Append("              </td>")



            Tot_Bultos += Val("" & dr("QBULTOS"))
            Tot_Cantidad += dr("QSEG")
            Tot_Peso += Val("" & dr("QPSOMR"))

            bodyemail.Append("			</tr>")
        Next

        bodyemail.Append("			<tr>")
        bodyemail.Append("				<td style='border:1px solid #000;padding:2px 4px' align='left' valign='middle'><strong>Total items:</strong> ")
        bodyemail.Append(dtOCEmb.Rows.Count)
        bodyemail.Append("</td>")

        bodyemail.Append("				<td  colspan='4' style='border:1px solid #000;padding:2px 4px' align='right' valign='middle'><em> ")
        bodyemail.Append(Val(Tot_Bultos.ToString))
        bodyemail.Append(" </em><strong>BULTOS</strong></td>")

        'colspan='2'
        bodyemail.Append(" <td  style='border:1px solid #000;padding:2px 4px' align='right' valign='middle'><em> ")
        bodyemail.Append(Val(Tot_Peso.ToString))
        bodyemail.Append(" </em><strong>KGS</strong></td>")

        'colspan='3' 
        ' bodyemail.Append("				<td style='border:1px solid #000;padding:2px 0px' align='center' valign='middle'></td>")
        '<td colspan='2' 
        'colspan='2'
        bodyemail.Append("				<td  colspan='6' style='border:1px solid #000;padding:2px 4px' align='right' valign='middle'><em> ")
        bodyemail.Append(Val(Tot_Cantidad.ToString))
        bodyemail.Append(" </em><strong>UNIDAD(ES)</strong></td>")
        'bodyemail.Append("				<td  style='border:1px solid #000;padding:2px 4px' align='center' valign='middle'></td>")
        ''&nbsp;colspan='0'

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
        bodyemail.Append(Usuario)
        bodyemail.Append("	</td>")
        bodyemail.Append("</tr>")
        bodyemail.Append("</table>")

        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString
    End Function
    Private Function FHTML_RIGHT(ByVal cadena As String, ByVal Char_Total_Relleno As Int32, ByVal CharRelleno As String) As String
        Dim cadenaRetorno As String = cadena.PadRight(Char_Total_Relleno, CharRelleno).Replace(CharRelleno, HTMLEspacio)
        Return cadenaRetorno
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
    Private Function ListarGuias(ByVal oDt As DataTable) As String
        Dim ht As New Hashtable
        Dim Guias As String = ""
        Dim R_Guias As String = ""
        If oDt.Rows.Count > 0 Then
            For Each row As DataRow In oDt.Rows
                If Not ht.Contains(row("NUMDCR")) Then
                    ht.Add(row("NUMDCR"), "")  '(Key , Valor)
                    Guias = Guias & row("NUMDCR") & ","
                End If
            Next
            R_Guias = Guias.Substring(0, Guias.Length - 1)
        End If
        Return R_Guias.Trim
    End Function
End Class
