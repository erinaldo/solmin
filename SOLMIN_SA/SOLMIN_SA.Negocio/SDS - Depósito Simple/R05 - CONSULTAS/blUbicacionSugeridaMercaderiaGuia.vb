Imports RANSA.TypeDef
Imports RANSA.DATA
Public Class blUbicacionSugeridaMercaderiaGuia
    'Public Function ListarSugerenciaMercaderia(ByVal obeSugerenciaMercaderiaGuia As beSugerenciaMercaderiaGuia) As DataTable

    '    Dim odtUbicacionSugerida As New ReporteSDS.UbicacionSugeridaDataTable
    '    Try
    '        Dim odtGuiaCabecera As New DataTable()
    '        Dim odtGuiaPosiciones As New DataTable()
    '        Dim numFilasGuia As Int64 = 0
    '        Dim obeUbicacionSugerida As beUbicacionSugerida
    '        Dim numFilasPosiciones As Int64 = 0
    '        Dim numSugerencias As Int32 = 0
    '        Dim dr As DataRow
    '        odtGuiaCabecera = New daUbicacionSugeridaMercaderiaGuia().ListarSugerenciaMercaderia(obeSugerenciaMercaderiaGuia).Tables(0)
    '        numFilasGuia = odtGuiaCabecera.Rows.Count - 1

    '        For index As Integer = 0 To numFilasGuia
    '            obeUbicacionSugerida = New beUbicacionSugerida()
    '            obeUbicacionSugerida.CCLNT = odtGuiaCabecera.Rows(index).Item("CCLNT2")
    '            obeUbicacionSugerida.CMRCLR = ("" & odtGuiaCabecera.Rows(index).Item("CMRCLR")).ToString.Trim
    '            obeUbicacionSugerida.CTPALM = ("" & odtGuiaCabecera.Rows(index).Item("CTPALM")).ToString.Trim
    '            obeUbicacionSugerida.CALMC = ("" & odtGuiaCabecera.Rows(index).Item("CALMC")).ToString.Trim
    '            obeUbicacionSugerida.MOBILE = 0
    '            odtGuiaPosiciones = New daUbicacionSugeridaMercaderiaGuia().ListarPosicionSugerida(obeUbicacionSugerida).Tables(0)
    '            numFilasPosiciones = odtGuiaPosiciones.Rows.Count - 1
    '            If (numFilasPosiciones < 0) Then
    '                dr = odtUbicacionSugerida.NewRow()
    '                dr("NGUIRN") = odtGuiaCabecera.Rows(index).Item("NGUIRN")
    '                dr("CMRCD") = odtGuiaCabecera.Rows(index).Item("CMRCD")
    '                dr("CMRCLR") = odtGuiaCabecera.Rows(index).Item("CMRCLR")
    '                dr("NORDSR") = odtGuiaCabecera.Rows(index).Item("NORDSR")
    '                dr("TMRCD2") = odtGuiaCabecera.Rows(index).Item("TMRCD2")
    '                dr("CCLNT2") = odtGuiaCabecera.Rows(index).Item("CCLNT2")
    '                dr("TCMPCL") = odtGuiaCabecera.Rows(index).Item("TCMPCL")
    '                dr("CCLSLS") = odtGuiaCabecera.Rows(index).Item("CCLSLS")
    '                dr("FEMORS") = odtGuiaCabecera.Rows(index).Item("FEMORS")
    '                dr("CSRVC") = odtGuiaCabecera.Rows(index).Item("CSRVC")
    '                dr("QTRMC") = odtGuiaCabecera.Rows(index).Item("QTRMC")
    '                odtUbicacionSugerida.Rows.Add(dr)
    '            End If
    '            numSugerencias = 0
    '            For index1 As Integer = 0 To numFilasPosiciones
    '                If (numSugerencias > 1) Then
    '                    Exit For  'solo seleccina hasta 2 sugerencias disponibles
    '                End If
    '                dr = odtUbicacionSugerida.NewRow()
    '                dr("NGUIRN") = odtGuiaCabecera.Rows(index).Item("NGUIRN")
    '                dr("CMRCD") = odtGuiaCabecera.Rows(index).Item("CMRCD")
    '                dr("CMRCLR") = odtGuiaCabecera.Rows(index).Item("CMRCLR")
    '                dr("NORDSR") = odtGuiaCabecera.Rows(index).Item("NORDSR")
    '                dr("TMRCD2") = odtGuiaCabecera.Rows(index).Item("TMRCD2")
    '                dr("CCLNT2") = odtGuiaCabecera.Rows(index).Item("CCLNT2")
    '                dr("TCMPCL") = odtGuiaCabecera.Rows(index).Item("TCMPCL")
    '                dr("CCLSLS") = odtGuiaCabecera.Rows(index).Item("CCLSLS")
    '                dr("FEMORS") = odtGuiaCabecera.Rows(index).Item("FEMORS")
    '                dr("CSRVC") = odtGuiaCabecera.Rows(index).Item("CSRVC")
    '                dr("QTRMC") = odtGuiaCabecera.Rows(index).Item("QTRMC")
    '                dr("CTPALM") = odtGuiaCabecera.Rows(index).Item("CTPALM")
    '                dr("CALMC") = odtGuiaCabecera.Rows(index).Item("CALMC")

    '                dr("CSECTR") = odtGuiaPosiciones.Rows(index1).Item("CSECTR")
    '                dr("CPSLL") = odtGuiaPosiciones.Rows(index1).Item("CPSLL")
    '                dr("CCLMN") = odtGuiaPosiciones.Rows(index1).Item("CCLMN")
    '                dr("CPSCN") = odtGuiaPosiciones.Rows(index1).Item("CPSCN")
    '                dr("SSCPOS") = odtGuiaPosiciones.Rows(index1).Item("SSCPOS")
    '                odtUbicacionSugerida.Rows.Add(dr)
    '                numSugerencias += 1
    '            Next
    '        Next
    '    Catch ex As Exception
    '        odtUbicacionSugerida = Nothing
    '    End Try    
    '    Return odtUbicacionSugerida
    '    End Function
    Public Function ListarSugerenciaPiking(ByVal CDPEPL As Int64) As DataTable

        'Dim odtUbicacionSugerida As New ReporteSDS.UbicacionSugeridaDataTable
        'Dim odtPedidoCabecera As New DataTable()
        Dim odtSugerenciaPosiciones As New DataTable
        Try


            'Dim numFilasGuia As Int64 = 0
            'Dim numFilasPosiciones As Int64 = 0
            'Dim IN_NORDSR As Int64 = 0
            ' Dim dr As DataRow
            odtSugerenciaPosiciones = New daUbicacionSugeridaMercaderiaGuia().SP_SOLMIN_SA_ITEMS_PEDIDO(CDPEPL).Tables(0)
            'numFilasGuia = odtPedidoCabecera.Rows.Count - 1

            'For index As Integer = 0 To numFilasGuia
            '    IN_NORDSR = Val("" & odtPedidoCabecera.Rows(index).Item("NORDSR"))
            '    odtSugerenciaPosiciones = New daUbicacionSugeridaMercaderiaGuia().ListarSugerenciaPiking(IN_NORDSR).Tables(0)
            '    numFilasPosiciones = odtSugerenciaPosiciones.Rows.Count - 1
            '    If (numFilasPosiciones < 0) Then
            '        dr = odtUbicacionSugerida.NewRow()
            '        dr("CDPEPL") = odtPedidoCabecera.Rows(index).Item("CDPEPL")
            '        dr("NORDSR") = odtPedidoCabecera.Rows(index).Item("NORDSR")
            '        dr("CMRCLR") = odtPedidoCabecera.Rows(index).Item("CMRCLR")
            '        dr("TMRCD2") = odtPedidoCabecera.Rows(index).Item("TMRCD2")
            '        dr("CCLNT") = odtPedidoCabecera.Rows(index).Item("CCLNT")
            '        dr("TCMPCL") = odtPedidoCabecera.Rows(index).Item("TCMPCL")
            '        dr("QSRVC") = Convert.ToInt64(Val("" & odtPedidoCabecera.Rows(index).Item("QSRVC")))
            '        dr("CUNCN6") = odtPedidoCabecera.Rows(index).Item("CUNCN6")
            '        dr("PSRVC") = odtPedidoCabecera.Rows(index).Item("PSRVC")
            '        dr("CUNPS6") = odtPedidoCabecera.Rows(index).Item("CUNPS6")
            '        odtUbicacionSugerida.Rows.Add(dr)
            '    End If

            '    For index1 As Integer = 0 To numFilasPosiciones

            '        dr = odtUbicacionSugerida.NewRow()
            '        dr("CDPEPL") = odtPedidoCabecera.Rows(index).Item("CDPEPL")
            '        dr("NORDSR") = odtPedidoCabecera.Rows(index).Item("NORDSR")
            '        dr("CMRCLR") = odtPedidoCabecera.Rows(index).Item("CMRCLR")
            '        dr("TMRCD2") = odtPedidoCabecera.Rows(index).Item("TMRCD2")
            '        dr("CCLNT") = odtPedidoCabecera.Rows(index).Item("CCLNT")
            '        dr("TCMPCL") = odtPedidoCabecera.Rows(index).Item("TCMPCL")
            '        dr("QSRVC") = Convert.ToInt64(Val("" & odtPedidoCabecera.Rows(index).Item("QSRVC")))
            '        dr("CUNCN6") = odtPedidoCabecera.Rows(index).Item("CUNCN6")
            '        dr("PSRVC") = odtPedidoCabecera.Rows(index).Item("PSRVC")
            '        dr("CUNPS6") = odtPedidoCabecera.Rows(index).Item("CUNPS6")


            '        dr("CTPALM") = odtSugerenciaPosiciones.Rows(index1).Item("CTPALM")
            '        dr("CALMC") = odtSugerenciaPosiciones.Rows(index1).Item("CALMC")
            '        dr("CTPALM_CALMC") = odtSugerenciaPosiciones.Rows(index1).Item("CTPALM_CALMC")
            '        dr("CSECTR") = odtSugerenciaPosiciones.Rows(index1).Item("CSECTR")
            '        dr("CPSCN") = odtSugerenciaPosiciones.Rows(index1).Item("CPSCN")
            '        dr("CZNALM") = odtSugerenciaPosiciones.Rows(index1).Item("CZNALM")
            '        dr("TCMZNA") = odtSugerenciaPosiciones.Rows(index1).Item("TCMZNA")
            '        dr("TABZNA") = odtSugerenciaPosiciones.Rows(index1).Item("TABZNA")
            '        dr("QSLETQ") = Convert.ToInt64(Val("" & odtSugerenciaPosiciones.Rows(index1).Item("QSLETQ")))
            '        dr("TOBSRV") = odtSugerenciaPosiciones.Rows(index1).Item("TOBSRV")
            '        odtUbicacionSugerida.Rows.Add(dr)
            '    Next
            'Next
        Catch ex As Exception
            odtSugerenciaPosiciones = Nothing
        End Try
        Return odtSugerenciaPosiciones


    End Function
   
End Class
