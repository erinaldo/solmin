Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Imports Ransa.Utilitario
Public Class clsResumenTipoCarga
  Public Function ListarEmbarqueTipoCarga(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECHA_INICIAL As Decimal, ByVal PNFECHA_FINAL As Decimal, ByVal PSTPSRVA As String) As List(Of beTipoCarga)
    Dim oclsResumenTipoCarga As New Datos.clsResumenTipoCarga
    Dim oListResumenTipoCarga As New List(Of beTipoCarga)
    oListResumenTipoCarga = oclsResumenTipoCarga.ListarEmbarqueTipoCarga(PSCCMPN, PNCCLNT, PNFECHA_INICIAL, PNFECHA_FINAL, PSTPSRVA)
    Return oListResumenTipoCarga
  End Function

    Dim PAIS As String = ""
    Dim PUERTO As String = ""
    Dim FORWARDER As String = ""
    Dim TIPOCARGA As String = ""
    Dim MERCADERIA As String = ""
    Public Function ResumirDatosTipoCarga(ByVal oListTipoCarga As List(Of beTipoCarga)) As DataTable

        Dim MdataColumna As String = ""
        Dim TipoDato As String = ""
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim ColName As String = ""
        Dim ColTitle As String = ""


        Dim odtExp As New DataTable
        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("País", TipoDato)
        odtExp.Columns.Add("PAIS").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("Puerto", TipoDato)
        odtExp.Columns.Add("PUERTO").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("Forwarder", TipoDato)
        odtExp.Columns.Add("FORWARDER").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("Tipo Carga", TipoDato)
        odtExp.Columns.Add("TIPO_CARGA").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("Mercadería", TipoDato)
        odtExp.Columns.Add("MERCADERIA").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoTexto
        MdataColumna = NPOI_SC.FormatDato("DATOS", TipoDato)
        odtExp.Columns.Add("DATOS").Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|AEREO", TipoDato)
        odtExp.Columns.Add("AEREO_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna

        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|MARITIMO", TipoDato)
        odtExp.Columns.Add("MARITIMO_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna



        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|TERRESTRE", TipoDato)
        odtExp.Columns.Add("TERRESTRE_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna


        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|POSTAL", TipoDato)
        odtExp.Columns.Add("POSTAL_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna


        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|FLUVIAL", TipoDato)
        odtExp.Columns.Add("FLUVIAL_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna


        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TRANSPORTE|(EN BLANCO)", TipoDato)
        odtExp.Columns.Add("SIN_MEDIO_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna


        TipoDato = NPOI_SC.keyDatoNumero
        MdataColumna = NPOI_SC.FormatDato("TOTAL GENERAL", TipoDato)
        odtExp.Columns.Add("TOTALGENERAL_VALOR", Type.GetType("System.Decimal")).Caption = MdataColumna



        Dim oucOrdena As ucOrdenaS(Of beTipoCarga)
        Dim Orden As ucOrdenaS(Of beTipoCarga).TiposOrden
        Orden = ucOrdenaS(Of Global.SOLMIN_SC.Entidad.beTipoCarga).TiposOrden.Ascendente
        oucOrdena = New ucOrdenaS(Of beTipoCarga)("PSPAIS", Orden, False)

        oListTipoCarga.Sort(oucOrdena)

        Dim ListCodUnicoVisitados As New Hashtable
        Dim ListPuertoxPais As New List(Of beTipoCarga)
        Dim ListForwarderxPuerto As New List(Of beTipoCarga)
        Dim ListTipoCargaxForwarder As New List(Of beTipoCarga)
        Dim ListMercaderiaxTipoCarga As New List(Of beTipoCarga)
        Dim ListMercaderia As New List(Of beTipoCarga)
        Dim oListMercaderia As New List(Of beTipoCarga)
        Dim PSMERCADERIA As String = ""

        Dim ListPaisVisistados As New List(Of String)
        Dim ListPuertoVisitados As New List(Of String)
        Dim ListForwarderVisitados As New List(Of String)
        Dim ListTipoCargaVisitados As New List(Of String)
        Dim ListMercaderiaVisitados As New List(Of String)

        Const DatoPeso As String = "Suma Peso"
        Const DatoFlete As String = "Suma Flete"

        Dim drPeso As DataRow
        Dim drFlete As DataRow

        For Each ItemPais As beTipoCarga In oListTipoCarga
            '************ XPAIS**************************************
            PAIS = ItemPais.PSPAIS
            If Not ListPaisVisistados.Contains(PAIS) Then
                ListPaisVisistados.Add(PAIS)
                ListPuertoxPais = oListTipoCarga.FindAll(AddressOf BuscarPuertoxPais_Desc)
                oucOrdena = New ucOrdenaS(Of beTipoCarga)("PSPUERTO", Orden, False)
                ListPuertoxPais.Sort(oucOrdena)

                ListPuertoVisitados.Clear()
                For Each ItemPuerto As beTipoCarga In ListPuertoxPais
                    '************ XPUERTO**************************************
                    PUERTO = ItemPuerto.PSPUERTO
                    If Not ListPuertoVisitados.Contains(PUERTO) Then
                        ListPuertoVisitados.Add(PUERTO)
                        ListForwarderxPuerto = ListPuertoxPais.FindAll(AddressOf BuscarForwarderxPuerto_Desc)
                        oucOrdena = New ucOrdenaS(Of beTipoCarga)("PSFORWARDER", Orden, False)
                        ListForwarderxPuerto.Sort(oucOrdena)

                        ListForwarderVisitados.Clear()
                        For Each ItemForwarder As beTipoCarga In ListForwarderxPuerto
                            '************ XFORWARDER**************************************
                            FORWARDER = ItemForwarder.PSFORWARDER
                            If Not ListForwarderVisitados.Contains(FORWARDER) Then
                                ListForwarderVisitados.Add(FORWARDER)
                                ListTipoCargaxForwarder = ListForwarderxPuerto.FindAll(AddressOf BuscarTipoCargaxForwarder_Desc)
                                oucOrdena = New ucOrdenaS(Of beTipoCarga)("PSTIPO_CARGA", Orden, False)
                                ListTipoCargaxForwarder.Sort(oucOrdena)

                                ListTipoCargaVisitados.Clear()
                                For Each ItemTipoCarga As beTipoCarga In ListTipoCargaxForwarder
                                    '************ XTIPOCARGA**************************************
                                    TIPOCARGA = ItemTipoCarga.PSTIPO_CARGA
                                    If Not ListTipoCargaVisitados.Contains(TIPOCARGA) Then
                                        ListTipoCargaVisitados.Add(TIPOCARGA)
                                        ListMercaderiaxTipoCarga = ListTipoCargaxForwarder.FindAll(AddressOf BuscarMercaderiaxTipoCarga_Desc)
                                        oucOrdena = New ucOrdenaS(Of beTipoCarga)("PSMERCADERIA", Orden, False)
                                        ListMercaderiaxTipoCarga.Sort(oucOrdena)

                                        ListMercaderiaVisitados.Clear()
                                        For Each ItemMercaderia As beTipoCarga In ListMercaderiaxTipoCarga
                                            MERCADERIA = ItemMercaderia.PSMERCADERIA
                                            '************ XMERCADERIA**************************************
                                            If Not ListMercaderiaVisitados.Contains(MERCADERIA) Then
                                                ListMercaderiaVisitados.Add(MERCADERIA)
                                                ListMercaderia = ListMercaderiaxTipoCarga.FindAll(AddressOf BuscarMercaderia_Desc)

                                                If ListMercaderia IsNot Nothing AndAlso ListMercaderia.Count > 0 Then

                                                    drPeso = odtExp.NewRow
                                                    drFlete = odtExp.NewRow

                                                    drPeso("PAIS") = ItemMercaderia.PSPAIS
                                                    drPeso("PUERTO") = ItemMercaderia.PSPUERTO
                                                    drPeso("FORWARDER") = ItemMercaderia.PSFORWARDER
                                                    drPeso("TIPO_CARGA") = ItemMercaderia.PSTIPO_CARGA
                                                    drPeso("MERCADERIA") = ItemMercaderia.PSMERCADERIA
                                                    drPeso("DATOS") = DatoPeso
                                                    For Each Item As DataColumn In drPeso.Table.Columns
                                                        If Item.ColumnName.EndsWith("_VALOR") Then
                                                            drPeso(Item.ColumnName) = 0
                                                            drFlete(Item.ColumnName) = 0
                                                        End If
                                                    Next


                                                    drFlete("PAIS") = ItemMercaderia.PSPAIS
                                                    drFlete("PUERTO") = ItemMercaderia.PSPUERTO
                                                    drFlete("FORWARDER") = ItemMercaderia.PSFORWARDER
                                                    drFlete("TIPO_CARGA") = ItemMercaderia.PSTIPO_CARGA
                                                    drFlete("MERCADERIA") = ItemMercaderia.PSMERCADERIA
                                                    drFlete("DATOS") = DatoFlete

                                                    For Each Item As beTipoCarga In ListMercaderia
                                                        Select Case Item.PNCOD_TRANSPORTE
                                                            Case 1
                                                                drPeso("AEREO_VALOR") = drPeso("AEREO_VALOR") + Item.PNPESO
                                                                drFlete("AEREO_VALOR") = drFlete("AEREO_VALOR") + Item.PNFLETE
                                                            Case 2
                                                                drPeso("MARITIMO_VALOR") = drPeso("MARITIMO_VALOR") + Item.PNPESO
                                                                drFlete("MARITIMO_VALOR") = drFlete("MARITIMO_VALOR") + Item.PNFLETE
                                                            Case 3
                                                                drPeso("POSTAL_VALOR") = drPeso("POSTAL_VALOR") + Item.PNPESO
                                                                drFlete("POSTAL_VALOR") = drFlete("POSTAL_VALOR") + Item.PNFLETE
                                                            Case 4
                                                                drPeso("TERRESTRE_VALOR") = drPeso("TERRESTRE_VALOR") + Item.PNPESO
                                                                drFlete("TERRESTRE_VALOR") = drFlete("TERRESTRE_VALOR") + Item.PNFLETE
                                                            Case 5
                                                                drPeso("FLUVIAL_VALOR") = drPeso("FLUVIAL_VALOR") + Item.PNPESO
                                                                drFlete("FLUVIAL_VALOR") = drFlete("FLUVIAL_VALOR") + Item.PNFLETE
                                                            Case Else
                                                                drPeso("SIN_MEDIO_VALOR") = drPeso("SIN_MEDIO_VALOR") + Item.PNPESO
                                                                drFlete("SIN_MEDIO_VALOR") = drFlete("SIN_MEDIO_VALOR") + Item.PNFLETE
                                                        End Select

                                                    Next
                                                    drPeso("TOTALGENERAL_VALOR") = drPeso("AEREO_VALOR") + drPeso("MARITIMO_VALOR") + drPeso("POSTAL_VALOR") + drPeso("TERRESTRE_VALOR") + drPeso("FLUVIAL_VALOR") + drPeso("SIN_MEDIO_VALOR")
                                                    drFlete("TOTALGENERAL_VALOR") = drFlete("AEREO_VALOR") + drFlete("MARITIMO_VALOR") + drFlete("POSTAL_VALOR") + drFlete("TERRESTRE_VALOR") + drFlete("FLUVIAL_VALOR") + drFlete("SIN_MEDIO_VALOR")
                                                    odtExp.Rows.Add(drPeso)
                                                    odtExp.Rows.Add(drFlete)
                                                End If
                                            End If
                                            '************ XMERCADERIA**************************************
                                        Next
                                    End If
                                    '************ XTIPOCARGA**************************************
                                Next
                            End If
                            '************ XFORWARDER**************************************
                        Next
                    End If
                    '************ XPUERTO**************************************
                Next
            End If
            '************ XPAIS**************************************
        Next

        Dim SumaAereo As Decimal = 0
        Dim SumaMaritimo As Decimal = 0
        Dim SumaFluvial As Decimal = 0
        Dim SumaTerrestre As Decimal = 0
        Dim SumaPostal As Decimal = 0
        Dim SumaSinMedio As Decimal = 0
        Dim SumaTotalGeneral As Decimal = 0


        If odtExp.Rows.Count > 0 Then
            drPeso = odtExp.NewRow
            drFlete = odtExp.NewRow
            Dim exp As String = ""
            Dim filtro As String = ""
            drPeso("DATOS") = "TOTAL PESO"
            drFlete("DATOS") = "TOTAL FLETE"
            For Each Item As DataColumn In odtExp.Columns
                If Item.ColumnName.EndsWith("_VALOR") Then
                    exp = String.Format("Sum({0})", Item.ColumnName)

                    filtro = String.Format("DATOS='{0}'", DatoPeso)
                    drPeso(Item.ColumnName) = odtExp.Compute(exp, filtro)

                    filtro = String.Format("DATOS='{0}'", DatoFlete)
                    drFlete(Item.ColumnName) = odtExp.Compute(exp, filtro)

                End If
            Next
            odtExp.Rows.Add(drPeso)
            odtExp.Rows.Add(drFlete)


            SumaAereo = odtExp.Compute("Sum(AEREO_VALOR)", "")
            SumaMaritimo = odtExp.Compute("Sum(MARITIMO_VALOR)", "")
            SumaFluvial = odtExp.Compute("Sum(FLUVIAL_VALOR)", "")
            SumaTerrestre = odtExp.Compute("Sum(TERRESTRE_VALOR)", "")
            SumaPostal = odtExp.Compute("Sum(POSTAL_VALOR)", "")
            SumaSinMedio = odtExp.Compute("Sum(SIN_MEDIO_VALOR)", "")
            SumaTotalGeneral = odtExp.Compute("Sum(TOTALGENERAL_VALOR)", "")

            If SumaAereo = 0 Then odtExp.Columns.Remove("AEREO_VALOR")
            If SumaMaritimo = 0 Then odtExp.Columns.Remove("MARITIMO_VALOR)")
            If SumaFluvial = 0 Then odtExp.Columns.Remove("FLUVIAL_VALOR")
            If SumaTerrestre = 0 Then odtExp.Columns.Remove("TERRESTRE_VALOR")
            If SumaPostal = 0 Then odtExp.Columns.Remove("POSTAL_VALOR")
            If SumaSinMedio = 0 Then odtExp.Columns.Remove("SIN_MEDIO_VALOR")
            If SumaTotalGeneral = 0 Then odtExp.Columns.Remove("TOTALGENERAL_VALOR")
        End If
        Return odtExp
    End Function

    Private Function BuscarPuertoxPais_Desc(ByVal obeTipoCarga As beTipoCarga) As Boolean
        Return (obeTipoCarga.PSPAIS = PAIS)
    End Function

    Private Function BuscarForwarderxPuerto_Desc(ByVal obeTipoCarga As beTipoCarga) As Boolean
        Return obeTipoCarga.PSPUERTO = PUERTO
    End Function

    Private Function BuscarTipoCargaxForwarder_Desc(ByVal obeTipoCarga As beTipoCarga) As Boolean
        Return obeTipoCarga.PSFORWARDER = FORWARDER
    End Function
    Private Function BuscarMercaderiaxTipoCarga_Desc(ByVal obeTipoCarga As beTipoCarga) As Boolean
        Return obeTipoCarga.PSTIPO_CARGA = TIPOCARGA
    End Function

    Private Function BuscarMercaderia_Desc(ByVal obeTipoCarga As beTipoCarga) As Boolean
        Return obeTipoCarga.PSMERCADERIA = MERCADERIA
    End Function
End Class
