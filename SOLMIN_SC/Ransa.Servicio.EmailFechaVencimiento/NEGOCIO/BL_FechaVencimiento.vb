Imports System.Text
Imports System.Text.RegularExpressions
Imports RANSA.Controls.Email
Public Class BL_FechaVencimiento
   
    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private Const CharRelleno As String = "#"
    Const NumMaxDiasDiferencia As Int32 = 15


    Private _ValorIntervalo As Int32 = 0
    Private _CodEscala As String = ""
   
    Sub New()
        ConstruirTablaEscala()
    End Sub

    Dim oListEscala As New List(Of BE_Escala)
    Private Sub ConstruirTablaEscala()
        oListEscala.Clear()
        Dim Max As Int32 = 0
        Dim Min As Int32 = 0
        Dim obeEscala As BE_Escala

        Max = 99999
        Min = 45
        obeEscala = New BE_Escala
        obeEscala.PSCODIGO = "T1"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "Mayor a " & Min & " d&iacute;as"
        obeEscala.PNORDEN = 3
        oListEscala.Add(obeEscala)

        Max = 45
        Min = 30
        obeEscala = New BE_Escala
        obeEscala.PSCODIGO = "T2"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "Entre " & Min & " - " & Max & " d&iacute;as"
        obeEscala.PNORDEN = 2
        oListEscala.Add(obeEscala)


        Max = 30
        Min = 0
        obeEscala = New BE_Escala
        obeEscala.PSCODIGO = "T3"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "Entre " & Min & " - " & Max & " d&iacute;as"
        obeEscala.PNORDEN = 1
        oListEscala.Add(obeEscala)

        oListEscala.Sort(AddressOf SortEscalaxOrden)
    End Sub

    Private Function BuscarIntervalo(ByVal obeEscala As BE_Escala) As Boolean
        Return (_ValorIntervalo <= obeEscala.PNMAX AndAlso _ValorIntervalo > obeEscala.PNMIN)
    End Function

    Private Function BuscarRegimenxCodEscala(ByVal obeRegimen As BE_Regimen) As Boolean
        Return _CodEscala = obeRegimen.POBESCALA.PSCODIGO
    End Function
    Private Function BuscarTipoCargaxCodEscala(ByVal obeTipoCarga As BE_TipoCarga) As Boolean
        Return _CodEscala = obeTipoCarga.POBESCALA.PSCODIGO
    End Function
    Private Function BuscarCartaFianzaxCodEscala(ByVal obeCartaFianza As BE_CartaFianza) As Boolean
        Return _CodEscala = obeCartaFianza.POBESCALA.PSCODIGO
    End Function


    Public Function BuscaEscala(ByVal VALUE As Int32) As BE_Escala
        _ValorIntervalo = VALUE
        Dim obeEscalaFind As BE_Escala
        obeEscalaFind = oListEscala.Find(AddressOf BuscarIntervalo)
        Return obeEscalaFind
    End Function

    Private Function IsValidEmail(ByVal strIn As String) As Boolean
        Dim ExpreReg As New StringBuilder
        ExpreReg.Append("^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))")
        ExpreReg.Append("(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
        Return Regex.IsMatch(strIn, ExpreReg.ToString.Trim)
    End Function

    Private Function Calculo_Dif_Fecha(ByVal FechaMax As String) As Int32
        Dim FechaMin As String = Today.ToString("dd/MM/yyyy")
        Dim dif As Int32 = -999 'no existe diferencia
        Dim Fecha As Date
        If (Date.TryParse(FechaMin, Fecha) AndAlso Date.TryParse(FechaMax, Fecha)) Then
            dif = DateDiff(DateInterval.Day, CDate(FechaMin), CDate(FechaMax))
        Else
            dif = -999
        End If
        Return dif
    End Function


    Private Function ClasificarListaRegimen(ByVal oListRegimen As List(Of BE_Regimen)) As List(Of BE_Regimen)
        Dim dif_dias As Int32 = 0
        Dim oFindEscala As BE_Escala
        For Each Item As BE_Regimen In oListRegimen
            dif_dias = Calculo_Dif_Fecha(Item.PSFECVEN)
            Item.PNDIFDIAS = dif_dias
            oFindEscala = BuscaEscala(dif_dias)
            If oFindEscala IsNot Nothing Then
                Item.POBESCALA = oFindEscala
            End If
        Next
        Return oListRegimen
    End Function
    Private Function ClasificarListaCartaFianza(ByVal oListCartaFianza As List(Of BE_CartaFianza)) As List(Of BE_CartaFianza)
        Dim dif_dias As Int32 = 0
        Dim oFindEscala As BE_Escala
        For Each Item As BE_CartaFianza In oListCartaFianza
            dif_dias = Calculo_Dif_Fecha(Item.PSFECVEN)
            Item.PNDIFDIAS = dif_dias
            oFindEscala = BuscaEscala(dif_dias)
            If oFindEscala IsNot Nothing Then
                Item.POBESCALA = oFindEscala
            End If
        Next
        Return oListCartaFianza
    End Function
    Private Function ClasificarListaTipoCarga(ByVal oListTipoCarga As List(Of BE_TipoCarga)) As List(Of BE_TipoCarga)
        Dim dif_dias As Int32 = 0
        Dim oFindEscala As BE_Escala
        For Each Item As BE_TipoCarga In oListTipoCarga
            dif_dias = Calculo_Dif_Fecha(Item.PSFECVEN)
            Item.PNDIFDIAS = dif_dias
            oFindEscala = BuscaEscala(dif_dias)
            If oFindEscala IsNot Nothing Then
                Item.POBESCALA = oFindEscala
            End If
        Next
        Return oListTipoCarga
    End Function

    Private Function SortEscalaxOrden(ByVal obeEscala1 As BE_Escala, ByVal obeEscala2 As BE_Escala) As Int32
        Dim retorno As Int32 = obeEscala1.PNORDEN.CompareTo(obeEscala2.PNORDEN)
        Return retorno
    End Function

    Private Function SortRegimenxOrden(ByVal obeReg1 As BE_Regimen, ByVal obeReg2 As BE_Regimen) As Int32
        Dim retorno As Int32 = obeReg1.POBESCALA.PNORDEN.CompareTo(obeReg2.POBESCALA.PNORDEN)
        Return retorno
    End Function
    Private Function SortRegimenxDifDias(ByVal obeReg1 As BE_Regimen, ByVal obeReg2 As BE_Regimen) As Int32
        Dim retorno As Int32 = obeReg1.PNDIFDIAS.CompareTo(obeReg2.PNDIFDIAS)
        Return retorno
    End Function

    Private Function SortCartaFianzaxOrden(ByVal obeCartaFianza1 As BE_CartaFianza, ByVal obeCartaFianza2 As BE_CartaFianza) As Int32
        Dim retorno As Int32 = obeCartaFianza1.POBESCALA.PNORDEN.CompareTo(obeCartaFianza2.POBESCALA.PNORDEN)
        Return retorno
    End Function
    Private Function SortCartaFianzaxDifDias(ByVal obeCartaFianza1 As BE_CartaFianza, ByVal obeCartaFianza2 As BE_CartaFianza) As Int32
        Dim retorno As Int32 = obeCartaFianza1.PNDIFDIAS.CompareTo(obeCartaFianza2.PNDIFDIAS)
        Return retorno
    End Function

    Private Function SortTipoCargaxOrden(ByVal obeTipoCarga1 As BE_TipoCarga, ByVal obeTipoCarga2 As BE_TipoCarga) As Int32
        Dim retorno As Int32 = obeTipoCarga1.POBESCALA.PNORDEN.CompareTo(obeTipoCarga2.POBESCALA.PNORDEN)
        Return retorno
    End Function

    Private Function SortTipoCargaxDifDias(ByVal obeTipoCarga1 As BE_TipoCarga, ByVal obeTipoCarga2 As BE_TipoCarga) As Int32
        Dim retorno As Int32 = obeTipoCarga1.PNDIFDIAS.CompareTo(obeTipoCarga2.PNDIFDIAS)
        Return retorno
    End Function

    Private Function CrearDatosCuerpoRegimen(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String) As String
        Dim bodyemail As New StringBuilder
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim oListRegimen As List(Of BE_Regimen)
        Dim oListRegimenFind As New List(Of BE_Regimen)
        oListRegimen = odaFechaVencimiento.Listar_Regimen_X_Vencer_Envio(PSCCMPN, CCLNT)

        If oListRegimen.Count = 0 Then Return ""

        oListRegimen = ClasificarListaRegimen(oListRegimen)

        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append(CCLNT & "-" & TCMPL)
        bodyemail.Append(" al ")

        bodyemail.Append(Now.ToString("dd/MM/yyyy"))
        bodyemail.Append(" se les envia el estado de los reg&iacute;menes de sus embarques que est&aacute;n por vencer.")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)



        bodyemail.Append("<tr>")

        bodyemail.Append("<td >")
        bodyemail.Append("Embarque")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append(" Orden Servicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Apertura")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  R&eacute;gimen")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Faltan para vencer(D&iacute;as)")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Inicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Vencimiento")
        bodyemail.Append("</td>")


        bodyemail.Append("</tr>")

        For Each ItemEscala As BE_Escala In oListEscala
            _CodEscala = ItemEscala.PSCODIGO
            oListRegimenFind = oListRegimen.FindAll(AddressOf BuscarRegimenxCodEscala)
            If oListRegimenFind IsNot Nothing Then

                If oListRegimenFind.Count > 0 Then

                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td colspan='8'>")
                    bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")


                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td style='text-align:left; font-weight: bold'>")
                    bodyemail.Append(ItemEscala.PSDESCRIPCION)
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")
                End If

                oListRegimenFind.Sort(AddressOf SortRegimenxDifDias)
                For Each ItemReg As BE_Regimen In oListRegimenFind

                    bodyemail.Append("<tr>")

                    bodyemail.Append("<td >")
                    bodyemail.Append(ItemReg.PNNORSCI.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSPNNMOS)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PSFORSCI)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:left'>")
                    bodyemail.Append(ItemReg.PSREGIMEN)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PNDIFDIAS.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECINI)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECVEN)
                    bodyemail.Append("</td>")

                    bodyemail.Append("</tr>")

                Next
            End If
        Next
        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString.Trim
    End Function



    Private Function CrearDatosCuerpoTipoCarga(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String) As String
        Dim bodyemail As New StringBuilder
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim oListTipoCarga As List(Of BE_TipoCarga)
        Dim oListTipoCargaFind As New List(Of BE_TipoCarga)
        oListTipoCarga = odaFechaVencimiento.Listar_TipoCarga_X_Vencer_Envio(PSCCMPN, CCLNT)

        If oListTipoCarga.Count = 0 Then Return ""

        oListTipoCarga = ClasificarListaTipoCarga(oListTipoCarga)

        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append(CCLNT & "-" & TCMPL)
        bodyemail.Append(" al ")

        bodyemail.Append(Now.ToString("dd/MM/yyyy"))
        bodyemail.Append(" se les envia el estado de los contenedores de sus embarques que est&aacute;n por vencer.")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)



        bodyemail.Append("<tr>")

        bodyemail.Append("<td >")
        bodyemail.Append("Embarque")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append(" Orden Servicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Apertura")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Contenedor")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Faltan para vencer(D&iacute;as)")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Inicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Vencimiento")
        bodyemail.Append("</td>")



        bodyemail.Append("</tr>")

        For Each ItemEscala As BE_Escala In oListEscala
            _CodEscala = ItemEscala.PSCODIGO
            oListTipoCargaFind = oListTipoCarga.FindAll(AddressOf BuscarTipoCargaxCodEscala)
            If oListTipoCargaFind IsNot Nothing Then

                If oListTipoCargaFind.Count > 0 Then

                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td colspan='8'>")
                    bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")


                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td style='text-align:left; font-weight: bold'>")
                    bodyemail.Append(ItemEscala.PSDESCRIPCION)
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")

                End If


                oListTipoCargaFind.Sort(AddressOf SortTipoCargaxDifDias)
                For Each ItemReg As BE_TipoCarga In oListTipoCargaFind

                    bodyemail.Append("<tr>")

                    bodyemail.Append("<td >")
                    bodyemail.Append(ItemReg.PNNORSCI.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSPNNMOS)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PSFORSCI)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:left'>")
                    bodyemail.Append(ItemReg.PSTIPO_CARGA)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PNDIFDIAS.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECINI)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECVEN)
                    bodyemail.Append("</td>")

                    bodyemail.Append("</tr>")

                Next
            End If
        Next
        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString.Trim
    End Function


    Private Function CrearDatosCuerpoCartaFianza(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String) As String
        Dim bodyemail As New StringBuilder
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim oListCartaFianza As List(Of BE_CartaFianza)

        Dim oListCartaFianzaFind As New List(Of BE_CartaFianza)
        oListCartaFianza = odaFechaVencimiento.Listar_CartaFianza_X_Vencer_Envio(PSCCMPN, CCLNT)

        If oListCartaFianza.Count = 0 Then Return ""

        oListCartaFianza = ClasificarListaCartaFianza(oListCartaFianza)

        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("Sres:")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append(CCLNT & "-" & TCMPL)
        bodyemail.Append(" al ")

        bodyemail.Append(Now.ToString("dd/MM/yyyy"))
        bodyemail.Append(" se les envia el estado de las Carta Fianzas de sus embarques que est&aacute;n por vencer.")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='8'>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append(HTMLSalto)



        bodyemail.Append("<tr>")

        bodyemail.Append("<td >")
        bodyemail.Append("Embarque")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append(" Orden Servicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Apertura")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Nro P&oacute;liza")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Banco")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Faltan para vencer(D&iacute;as)")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Inicio")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'>")
        bodyemail.Append("  Fecha Vencimiento")
        bodyemail.Append("</td>")

        bodyemail.Append("</tr>")

        For Each ItemEscala As BE_Escala In oListEscala
            _CodEscala = ItemEscala.PSCODIGO
            oListCartaFianzaFind = oListCartaFianza.FindAll(AddressOf BuscarCartaFianzaxCodEscala)
            If oListCartaFianzaFind IsNot Nothing Then

                If oListCartaFianzaFind.Count > 0 Then

                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td colspan='8'>")
                    bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")


                    bodyemail.Append("<tr>")
                    bodyemail.Append("<td style='text-align:left; font-weight: bold'>")
                    bodyemail.Append(ItemEscala.PSDESCRIPCION)
                    bodyemail.Append("</td>")
                    bodyemail.Append("</tr>")

                End If

                oListCartaFianzaFind.Sort(AddressOf SortCartaFianzaxDifDias)
                For Each ItemReg As BE_CartaFianza In oListCartaFianzaFind

                    bodyemail.Append("<tr>")

                    bodyemail.Append("<td >")
                    bodyemail.Append(ItemReg.PNNORSCI.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSPNNMOS)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PSFORSCI)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:left'>")
                    bodyemail.Append(ItemReg.PSNDOCUM)
                    bodyemail.Append("</td>")


                    bodyemail.Append("<td style='text-align:left'>")
                    bodyemail.Append(ItemReg.PSTCMBCF)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td style='text-align:center'>")
                    bodyemail.Append(ItemReg.PNDIFDIAS.ToString)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECINI)
                    bodyemail.Append("</td>")

                    bodyemail.Append("<td>")
                    bodyemail.Append(ItemReg.PSFECVEN)
                    bodyemail.Append("</td>")

                    bodyemail.Append("</tr>")

                Next
            End If
        Next
        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString.Trim
    End Function


    'Public Sub EnviarEmail_X_FecVencRegimen(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
    '    Dim odaFechaVencimiento As New DAL_FechaVencimiento
    '    Dim bodyemailRegimen As String = ""
    '    Try
    '        Dim Total_Items As Int32 = 0
    '        If (obeEmail.EMAILTO.Trim.Length <> 0) Then
    '            bodyemailRegimen = CrearDatosCuerpoRegimen(PSCCMPN, CCLNT, TCMPL)
    '            If bodyemailRegimen.Length > 0 Then
    '                EnvioNotificacionUserEmail(bodyemailRegimen, "RANSA:(" & CCLNT & ")LISTA DE REGIMENES POR VENCER.", obeEmail)
    '            Else
    '                EnvioNotificacionAdminEmail(CCLNT & " - " & "No existen información(Regimen x Vencer) a enviar", "Status Envio de Régimen", obeEmail)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
    '    End Try
    'End Sub

    'Public Sub EnviarEmail_X_FecVencContenedor(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
    '    Dim odaFechaVencimiento As New DAL_FechaVencimiento
    '    Dim bodyemailTipoCarga As String = ""
    '    Try
    '        Dim Total_Items As Int32 = 0
    '        If (obeEmail.EMAILTO.Trim.Length <> 0) Then
    '            bodyemailTipoCarga = CrearDatosCuerpoTipoCarga(PSCCMPN, CCLNT, TCMPL)
    '            If bodyemailTipoCarga.Length > 0 Then
    '                EnvioNotificacionUserEmail(bodyemailTipoCarga, "RANSA:(" & CCLNT & ") LISTA DE CONTENEDORES POR VENCER.", obeEmail)
    '            Else
    '                EnvioNotificacionAdminEmail(CCLNT & " - " & "No existen información (Contenedores x Vencer) a enviar", "Status Envio de Contenedores", obeEmail)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
    '    End Try
    'End Sub
    'Public Sub EnviarEmail_X_FecVencCartaFianza(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
    '    Dim odaFechaVencimiento As New DAL_FechaVencimiento
    '    Dim bodyemailCartaFianza As String = ""
    '    Try
    '        Dim Total_Items As Int32 = 0
    '        If (obeEmail.EMAILTO.Trim.Length <> 0) Then
    '            bodyemailCartaFianza = CrearDatosCuerpoCartaFianza(PSCCMPN, CCLNT, TCMPL)
    '            If bodyemailCartaFianza.Length > 0 Then
    '                EnvioNotificacionUserEmail(bodyemailCartaFianza, "RANSA:(" & CCLNT & ") LISTA DE CARTAS FIANZAS POR VENCER.", obeEmail)
    '            Else
    '                EnvioNotificacionAdminEmail(CCLNT & " - " & "No existen información (Carta Fianza x Vencer) a enviar", "Status Envio de Carta Fianza", obeEmail)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
    '    End Try
    'End Sub

    Public Sub EnviarEmail_X_FecVencRegimen(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim bodyemailRegimen As String = ""
        Try
            Dim Total_Items As Int32 = 0
            If (obeEmail.EMAILTO.Trim.Length <> 0) Then
                bodyemailRegimen = CrearDatosCuerpoRegimen(PSCCMPN, CCLNT, TCMPL)
                If bodyemailRegimen.Length > 0 Then
                    EnvioNotificacionUserEmail(bodyemailRegimen, "RANSA:(" & CCLNT & ")LISTA DE REGIMENES POR VENCER.", obeEmail)
                End If
            End If
        Catch ex As Exception
            EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
        End Try
    End Sub

    Public Sub EnviarEmail_X_FecVencContenedor(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim bodyemailTipoCarga As String = ""
        Try
            Dim Total_Items As Int32 = 0
            If (obeEmail.EMAILTO.Trim.Length <> 0) Then
                bodyemailTipoCarga = CrearDatosCuerpoTipoCarga(PSCCMPN, CCLNT, TCMPL)
                If bodyemailTipoCarga.Length > 0 Then
                    EnvioNotificacionUserEmail(bodyemailTipoCarga, "RANSA:(" & CCLNT & ") LISTA DE CONTENEDORES POR VENCER.", obeEmail)
                End If
            End If
        Catch ex As Exception
            EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
        End Try
    End Sub
    Public Sub EnviarEmail_X_FecVencCartaFianza(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal TCMPL As String, ByVal obeEmail As BE_Email)
        Dim odaFechaVencimiento As New DAL_FechaVencimiento
        Dim bodyemailCartaFianza As String = ""
        Try
            Dim Total_Items As Int32 = 0
            If (obeEmail.EMAILTO.Trim.Length <> 0) Then
                bodyemailCartaFianza = CrearDatosCuerpoCartaFianza(PSCCMPN, CCLNT, TCMPL)
                If bodyemailCartaFianza.Length > 0 Then
                    EnvioNotificacionUserEmail(bodyemailCartaFianza, "RANSA:(" & CCLNT & ") LISTA DE CARTAS FIANZAS POR VENCER.", obeEmail)
                End If
            End If
        Catch ex As Exception
            EnvioNotificacionAdminEmail(ex.Message, CCLNT & " - " & "Error: ENVIO DE EMAIL FECHAS VENCIMIENTO.", obeEmail)
        End Try
    End Sub


   
    Private Sub EnvioNotificacionUserEmail(ByVal Cuerpo As String, ByVal Titulo As String, ByVal obeEmail As BE_Email)
        Dim oclsEmailManager As New clsEmailManager
        oclsEmailManager = New clsEmailManager
        oclsEmailManager.MailAccount = obeEmail.MailAccount
        oclsEmailManager.Mailpassword = obeEmail.Mailpassword
        oclsEmailManager.MailNotification = obeEmail.EmailTO
        If (obeEmail.EMAILBC.Trim.Length <> 0) Then
            oclsEmailManager.mailnotificationBCC = obeEmail.EMAILBC
        End If
        oclsEmailManager.MailBody = Cuerpo
        oclsEmailManager.MailSubject = Titulo
        'oclsEmailManager.SendMail()
        oclsEmailManager.SendMailProvider()
    End Sub
    Private Sub EnvioNotificacionAdminEmail(ByVal Cuerpo As String, ByVal Titulo As String, ByVal obeEmail As BE_Email)
        Try
            Dim oclsEmailManagerGMAIL As New clsEmailManagerGMAIL
            oclsEmailManagerGMAIL.MailAccount = obeEmail.MailAccountGmail
            oclsEmailManagerGMAIL.Mailpassword = obeEmail.MailpasswordGmail
            oclsEmailManagerGMAIL.MailNotification = obeEmail.EmailTO
            oclsEmailManagerGMAIL.MailBody = Cuerpo
            oclsEmailManagerGMAIL.MailSubject = Titulo
            oclsEmailManagerGMAIL.SendMailGmail()
        Catch exx As Exception
        End Try

    End Sub


    Private Function FHTML_RIGHT(ByVal cadena As String, ByVal Char_Total_Relleno As Int32, ByVal CharRelleno As String) As String
        Dim cadenaRetorno As String = cadena.PadRight(Char_Total_Relleno, CharRelleno).Replace(CharRelleno, HTMLEspacio)
        Return cadenaRetorno
    End Function



    Private CCLNT_A_BUSCAR As Decimal = 0
    Private TIPO_FECH_VENC As String = ""
    Public Enum TipoFechaVenc
        VencCartaFianza = 0
        VencRegTemporal = 1
        VencContenedor = 2
    End Enum

    Public Function ListarClienteDiferente(ByVal oListEmailTodos As List(Of BE_Destinatario)) As List(Of Decimal)
        Dim oListCliente As New List(Of Decimal)
        For Each ItemEmail As BE_Destinatario In oListEmailTodos
            If ItemEmail.PNCCLNT > 0 Then
                If Not oListCliente.Contains(ItemEmail.PNCCLNT) Then
                    oListCliente.Add(ItemEmail.PNCCLNT)
                End If
            End If
        Next
        Return oListCliente
    End Function
    Public Function ConsolidarListaEnvioClienteTipoFechaVenc(ByVal oListEmailTodos As List(Of BE_Destinatario), ByVal CCLNT As Decimal, ByVal _TipoFechaVenc As TipoFechaVenc) As BE_Destinatario
        Dim beEmailConsolidado As New BE_Destinatario
        Dim TipoFechaVencimiento As String = ""
        Dim ListEmailEncontrado As New List(Of BE_Destinatario)
        CCLNT_A_BUSCAR = CCLNT
        Select Case _TipoFechaVenc
            Case TipoFechaVenc.VencCartaFianza
                TipoFechaVencimiento = "FEVEFIANZA"
            Case TipoFechaVenc.VencContenedor
                TipoFechaVencimiento = "FEVECONTEN"
            Case TipoFechaVenc.VencRegTemporal
                TipoFechaVencimiento = "FEVEREGTEM"
        End Select
        TIPO_FECH_VENC = TipoFechaVencimiento
        ListEmailEncontrado = oListEmailTodos.FindAll(AddressOf BuscarClienteInListaEnvio)
        If ListEmailEncontrado IsNot Nothing Then
            If ListEmailEncontrado.Count > 0 Then
                beEmailConsolidado.PNCCLNT = ListEmailEncontrado(0).PNCCLNT
                beEmailConsolidado.PSTCMPCL = ListEmailEncontrado(0).PSTCMPCL
                beEmailConsolidado.PSNLTECL = ListEmailEncontrado(0).PSNLTECL
            End If
        End If

        Dim ListEmailExiste As New List(Of String)
        Dim sbEmail As New StringBuilder
        Dim Email As String = ""
        Dim CharSeparacion As String = ";"
        Dim strJoinEmail As String = ""
        For Each ItemEmail As BE_Destinatario In ListEmailEncontrado
            Email = ItemEmail.PSEMAILTO
            If Email.Length AndAlso (Not ListEmailExiste.Contains(Email)) Then
                ListEmailExiste.Add(Email)
                sbEmail.Append(Email)
                sbEmail.Append(CharSeparacion)
            End If
        Next
        If sbEmail.Length > 0 Then
            strJoinEmail = sbEmail.ToString
            strJoinEmail = strJoinEmail.Substring(0, strJoinEmail.LastIndexOf(CharSeparacion))
        End If
        beEmailConsolidado.PSEMAILTO = strJoinEmail
        Return beEmailConsolidado
    End Function

    Private Function BuscarClienteInListaEnvio(ByVal BE_Destinatario As BE_Destinatario) As Boolean
        Return CCLNT_A_BUSCAR = BE_Destinatario.PNCCLNT AndAlso TIPO_FECH_VENC = BE_Destinatario.PSNLTECL
    End Function

    'Public Function listaDestinatarioEnvio(ByVal PSLISCLIENTE As String) As List(Of BE_Destinatario)
    '    Dim oDAL_FechaVencimiento As New DAL_FechaVencimiento
    '    Return oDAL_FechaVencimiento.listaDestinatarioEnvio(PSLISCLIENTE)
    'End Function
    Public Function listaDestinatarioEnvio() As List(Of BE_Destinatario)
        Dim oDAL_FechaVencimiento As New DAL_FechaVencimiento
        Return oDAL_FechaVencimiento.listaDestinatarioEnvio()
    End Function
End Class
