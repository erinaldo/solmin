Imports System.Text
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Public Class clsRepMenAdn
    Private strCliente As String
    Private oReporte As Datos.clsRepMenAdn
    Private oDtTotalReg As DataTable
    Private oRepContenedor As clsRepContenedor
    Private oRepDespacho As clsRepDespacho

    Private oRepDespacho_Div_FueraObj As clsRepDespacho

    Private _dtRegimen As New DataTable

    Private _dtCanal As New DataTable

    Private _TOT_REGIMEN_NO_DEFINIDO As Int32 = 0

    Sub New()
        _dtRegimen.Columns.Add("Codigo", Type.GetType("System.Decimal"))
        _dtRegimen.Columns.Add("Regimen", Type.GetType("System.String"))
        _dtRegimen.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        _dtRegimen.Columns.Add("Embarque", Type.GetType("System.String"))
        Dim dr As DataRow
        Dim oListRegimen As New List(Of beRegimen)
        Dim obrclsRegimen As New clsRegimen
        oListRegimen = obrclsRegimen.ListarRegimen()
        
        If (oListRegimen IsNot Nothing AndAlso oListRegimen.Count > 0) Then
            For Each ItemRegimen As beRegimen In oListRegimen
                dr = _dtRegimen.NewRow
                dr("Codigo") = ItemRegimen.PNTPORGE
                dr("Regimen") = ItemRegimen.PSTCMRGA
                dr("Cantidad") = 0
                dr("Embarque") = ""
                _dtRegimen.Rows.Add(dr)
            Next
            dr = _dtRegimen.NewRow
            dr("Codigo") = 0
            dr("Regimen") = "NO DEFINIDOS"
            dr("Cantidad") = 0
            dr("Embarque") = ""
            _dtRegimen.Rows.Add(dr)
        End If

        Dim oCanal As New clsCanal
        Dim odtCanal As New DataTable
        Dim drCanal As DataRow
        Dim oLisCanal As New List(Of beCanal)
        odtCanal.Columns.Add(New DataColumn("NCANAL", GetType(String)))
        odtCanal.Columns.Add(New DataColumn("TCANAL", GetType(String)))
        odtCanal.Columns.Add(New DataColumn("TCANAL_ING", GetType(String)))
        oLisCanal = oCanal.Lista_Canal("")
        For Each Item As beCanal In oLisCanal
            drCanal = odtCanal.NewRow
            drCanal("NCANAL") = Item.PSNCANAL
            drCanal("TCANAL") = Item.PSTCANAL
            drCanal("TCANAL_ING") = Item.PSTCANAL_ING
            odtCanal.Rows.Add(drCanal)
        Next
        'oCanal.Lista_Canal()
        'odtCanal = oCanal.Tabla
    End Sub


    Public Property dtRegimen() As DataTable
        Get
            Return _dtRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtRegimen = value
        End Set
    End Property


    Property Despachos()
        Get
            Return oRepDespacho
        End Get
        Set(ByVal value)
            oRepDespacho = value
        End Set
    End Property

    Property RepDespacho_Div_FueraObj()
        Get
            Return oRepDespacho_Div_FueraObj
        End Get
        Set(ByVal value)
            oRepDespacho_Div_FueraObj = value
        End Set
    End Property


    Property Contenedores()
        Get
            Return oRepContenedor
        End Get
        Set(ByVal value)
            oRepContenedor = value
        End Set
    End Property

    Property TotalRegimen()
        Get
            Return oDtTotalReg
        End Get
        Set(ByVal value)
            oDtTotalReg = value
        End Set
    End Property

    Private Sub fdtFormatoTotalRegimen(ByRef pobjDt As DataTable)
        Dim objDr As DataRow
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TIMPDEF", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TIMPTEM", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TDEPOSI", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TADMTEM", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TSIMPLIF", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TREIMPO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TEXPDEF", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TEXPTEM", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TREEXPO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TREEMBA", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TTRANSB", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TTRANSI", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TNACDEP", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TIMPCON", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TADMPER", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TADMREE", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TEXPREI", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TEXPPER", GetType(System.Int32)))
        objDr = pobjDt.NewRow
        objDr("TCMPCL") = strCliente
        objDr("TIMPDEF") = 0
        objDr("TIMPTEM") = 0
        objDr("TDEPOSI") = 0
        objDr("TADMTEM") = 0
        objDr("TSIMPLIF") = 0
        objDr("TREIMPO") = 0
        objDr("TEXPDEF") = 0
        objDr("TEXPTEM") = 0
        objDr("TREEXPO") = 0
        objDr("TREEMBA") = 0
        objDr("TTRANSB") = 0
        objDr("TTRANSI") = 0
        objDr("TNACDEP") = 0
        objDr("TIMPCON") = 0
        objDr("TADMPER") = 0
        objDr("TADMREE") = 0
        objDr("TEXPREI") = 0
        objDr("TEXPPER") = 0
        pobjDt.Rows.Add(objDr)
    End Sub

    Private Sub fdtFormatoRepMenAD(ByRef pobjDt As DataTable)
        pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("CORRELATIVO", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("PNNMOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("REGIMEN", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FDCCMP", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DESPACHO", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TNMMDT", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NBLTAR", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FLETE", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("SEGURO", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("CIF", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ADVALOREM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("IGVPM", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("DUA", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("CANAL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NDIADN", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("EXW", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("GFOB", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("OGASTOS", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("FAPRAR", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("FECALM", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NCONTEN", GetType(System.Int32)))
        pobjDt.Columns.Add(New DataColumn("TOTDER", GetType(System.Double)))
        '-----------------------------------------------------------------------
        pobjDt.Columns.Add(New DataColumn("DOCUMENTOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFDOCUMENTOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("NUMERACION", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFNUMERACION", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DERECHOS", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIFDERECHOS", GetType(System.String)))

        pobjDt.Columns.Add(New DataColumn("COD_TNMMDT", GetType(System.Decimal)))
        pobjDt.Columns.Add(New DataColumn("COD_DESPACHO", GetType(System.Decimal)))

        pobjDt.Columns.Add(New DataColumn("TPRVCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("MERCADERIA", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("BL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TIPOCARGA", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("REFDO1", GetType(System.String)))


        '*********************************

        pobjDt.Columns.Add(New DataColumn("NAVE_CIATRANSPORTE", GetType(System.String))) 'NAVE
        pobjDt.Columns.Add(New DataColumn("AGENTE_CARGA", GetType(System.String))) 'AGENTE CARGA
        pobjDt.Columns.Add(New DataColumn("TERMINAL", GetType(System.String))) ' TERMINAL
        pobjDt.Columns.Add(New DataColumn("PAIS_ORIGEN", GetType(System.String))) ' PAIS ORIGEN
        pobjDt.Columns.Add(New DataColumn("PUERTO_ORIGEN", GetType(System.String))) 'DES_CPRTOE
        pobjDt.Columns.Add(New DataColumn("M3", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("TRANSPORTE_LOCAL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("ALMACEN_LOCAL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("LEVANTE", GetType(System.String)))



        pobjDt.Columns.Add(New DataColumn("DIF_DOCCOMPLETO_NUMERACION", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("DIF_PAGODERECHO_ENTREGAALM", GetType(System.String)))

        pobjDt.Columns.Add(New DataColumn("NORSCI", GetType(System.Double)))
    End Sub

    Private Sub Cuenta_Regimen(ByVal COD_REGIMEN As Decimal, ByVal NORSCI As Decimal)
        Dim REG_ENCONTRADO As Int32 = 0
        For Each Item As DataRow In _dtRegimen.Rows
            If (Item("Codigo") = COD_REGIMEN) Then
                Item("Cantidad") = Item("Cantidad") + 1
                If COD_REGIMEN = 0 Then
                    Item("Embarque") = Item("Embarque") + NORSCI.ToString & ","
                End If
                Exit For
            End If
        Next
    End Sub

    Private Function fintDiferencia_Dia_V2(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer
        'If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
        '    Return 0
        'End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        lintDif = Math.Abs(lintDif) - pintDia
        Return lintDif
    End Function
   

    Private Function fValidaContenedorBulto(ByVal pNCODRGTipoCarga As Decimal) As Boolean
        If pNCODRGTipoCarga = 1 Or pNCODRGTipoCarga = 11 _
            Or pNCODRGTipoCarga = 12 Or pNCODRGTipoCarga = 13 _
            Or pNCODRGTipoCarga = 14 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private cod_regimen As Decimal = 0
    Private Function BuscarRegimenIngles(ByVal ListRegimen As List(Of beRegimen), ByVal CodReg As Decimal) As String
        Dim Busqueda As String = ""
        Dim obeRegimen As beRegimen
        cod_regimen = CodReg
        Dim pred As New Predicate(Of beRegimen)(AddressOf BuscarRegimenPorCodigo)
        obeRegimen = ListRegimen.Find(pred)
        If obeRegimen IsNot Nothing Then
            Busqueda = obeRegimen.PSTCMRGI
        End If
        Return Busqueda
    End Function
    Private Function BuscarRegimenPorCodigo(ByVal obeRegimen As beRegimen) As Boolean
        Return obeRegimen.PNTPORGE = cod_regimen
    End Function


    Private Function BuscarTipoDespachoIng(ByVal dtTipoDespacho As DataTable, ByVal CodTipoDespachoFind As Decimal) As String
        Dim Busqueda As String = ""
        Dim dr() As DataRow
        dr = dtTipoDespacho.Select("NCODRG='" & CodTipoDespachoFind & "'")
        If dr.Length > 0 Then
            Busqueda = ("" & dr(0)("TDITIN")).ToString.Trim
        End If
        Return Busqueda
    End Function

    Private Function BuscarCanalIng(ByVal dtCanal As DataTable, ByVal CodCanal As String) As String
        Dim Busqueda As String = ""
        Dim dr() As DataRow
        dr = dtCanal.Select("NCANAL='" & CodCanal & "'")
        If dr.Length > 0 Then
            Busqueda = HelpClass.ToStringCvr(dr(0)("TCANAL_ING"))
        End If
        Return Busqueda
    End Function

    Private Function BuscarTipoTransporteIng(ByVal dtTransporte As DataTable, ByVal CodTransporte As Decimal) As String
        Dim Busqueda As String = ""
        Dim dr() As DataRow
        dr = dtTransporte.Select("CMEDTR='" & CodTransporte & "'")
        If dr.Length > 0 Then
            Busqueda = HelpClass.ToStringCvr(dr(0)("TDITIN"))
        End If
        Return Busqueda
    End Function


    'Public Function dtRepMenAduanero(ByVal PSCCMPN As String, ByVal pIdioma As String, ByVal pstrCliente As String, ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pdblFecIniLab As Double) As DataTable
    '    Dim lobjDtRep As New DataTable
    '    Dim lobjDt As New DataTable
    '    Dim lobjDtDia As New DataTable
    '    Dim lintcont As Integer
    '    Dim lintDias As Integer
    '    Dim lobjDr As DataRow
    '    Dim dblEmbarque As Double = 0

    '    strCliente = pstrCliente
    '    fdtFormatoTotalRegimen(oDtTotalReg)
    '    fdtFormatoRepMenAD(lobjDtRep)
    '    oReporte = New Datos.clsRepMenAdn()
    '    lobjDt = oReporte.dtRepMenAduanero(PSCCMPN, pdblCodCli, pdblFecIni, pdblFecFin)

    '    Dim odtRegimen As New DataTable
    '    Dim odtTipoDespacho As New DataTable
    '    Dim odtCanal As New DataTable
    '    Dim odtMedioTransporte As New DataTable

    '    Dim NORSCI As Decimal = 0

    '    Select Case pIdioma
    '        Case "EN"
    '            Dim oRegimen As New clsRegimen
    '            oRegimen.Crea_Lista()
    '            odtRegimen = oRegimen.Lista_Regimen(1)

    '            Dim oDespacho As New clsDespacho
    '            oDespacho.Crea_Lista()
    '            odtTipoDespacho = oDespacho.Lista()

    '            Dim oCanal As New clsCanal
    '            oCanal.Lista_Canal()
    '            odtCanal = oCanal.Tabla

    '            Dim oEnvio As New clsEnvio
    '            oEnvio.Listar_Envio(1)
    '            odtMedioTransporte = oEnvio.Lista

    '            For Each Item As DataRow In _dtRegimen.Rows
    '                If Item("Codigo") <> 0 Then
    '                    Item("Regimen") = BuscarRegimenIng(odtRegimen, Item("Codigo"))
    '                End If
    '            Next

    '            For Each Item As DataRow In lobjDt.Rows
    '                Item("TCANAL") = BuscarCanalIng(odtCanal, ("" & Item("TCANAL")).ToString.Trim)
    '                Item("REGIMEN") = BuscarRegimenIng(odtRegimen, Item("COD_REGIMEN"))
    '                Item("TNMMDT") = BuscarTipoTransporteIng(odtMedioTransporte, Item("COD_TNMMDT"))
    '                Item("DESPACHO") = BuscarTipoDespachoIng(odtTipoDespacho, Item("COD_DESPACHO"))
    '            Next

    '        Case "ES"
    '    End Select

    '    lobjDtDia = oReporte.dtNoLaborables(pdblFecIniLab, pdblFecFin)

    '    oRepContenedor = New clsRepContenedor
    '    oRepDespacho = New clsRepDespacho

    '    oRepDespacho_Div_FueraObj = New clsRepDespacho

    '    Dim COD_REGIMEN As Decimal = 0
    '    Dim COD_DESPACHO As Decimal = 0
    '    Dim COD_TNMMDT As Decimal = 0

    '    Dim CHK_120_DOC_COMPLETO As String = ""
    '    Dim CHK_121_NUMERACION As String = ""
    '    Dim CHK_122_PAGO_DERECHO As String = ""
    '    Dim CHK_124_ENTREGA_ALMACEN As String = ""
    '    Dim ETA_CHK_LLEGADA As String = ""
    '    Dim FECHA_FORSCI As String = ""


    '    Dim TipoCarga As String = ""
    '    For lintcont = 0 To lobjDt.Rows.Count - 1
    '        If dblEmbarque = Double.Parse(lobjDt.Rows(lintcont).Item("NORSCI").ToString) Then
    '            If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
    '                If lobjDr.Item("NBLTAR") = vbNullString Then
    '                    lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                Else
    '                    If Not IsDBNull(lobjDt.Rows(lintcont).Item("NBLTAR")) Then
    '                        lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR")) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                End If
    '            Else
    '                oRepContenedor.Contar_Tipo_Contenedor(lobjDt.Rows(lintcont).Item("NCODRG").ToString.Trim, Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR")), Double.Parse(lobjDt.Rows(lintcont).Item("NDIASE")))
    '                If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
    '                    If lobjDr.Item("NBLTAR").ToString = vbNullString Then
    '                        lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                    Else
    '                        lobjDr.Item("NBLTAR") = Double.Parse(lobjDr.Item("NBLTAR").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                Else
    '                    If lobjDr.Item("NCONTEN").ToString = vbNullString Then
    '                        lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                    Else
    '                        lobjDr.Item("NCONTEN") = Double.Parse(lobjDr.Item("NCONTEN").ToString) + Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR"))
    '                    End If
    '                End If
    '            End If

    '            TipoCarga = ("" & lobjDt.Rows(lintcont).Item("TCARGA")).ToString.Trim
    '            If TipoCarga.Length > 0 Then
    '                If ("" & lobjDr.Item("TIPOCARGA")).ToString.Trim.Length > 0 Then
    '                    TipoCarga = ("" & lobjDr.Item("TIPOCARGA")).ToString.Trim & "," & TipoCarga
    '                End If
    '            End If
    '            lobjDr.Item("TIPOCARGA") = TipoCarga

    '            If lintcont = lobjDt.Rows.Count - 1 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '        Else
    '            dblEmbarque = Double.Parse(lobjDt.Rows(lintcont).Item("NORSCI").ToString)
    '            If lintcont > 0 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '            lobjDr = lobjDtRep.NewRow

    '            COD_REGIMEN = lobjDt.Rows(lintcont).Item("COD_REGIMEN")
    '            NORSCI = lobjDt.Rows(lintcont).Item("NORSCI")

    '            lobjDr.Item("TCMPCL") = strCliente & " - " & pdblCodCli
    '            lobjDr.Item("NORCML") = lobjDt.Rows(lintcont).Item("NORCML")
    '            lobjDr.Item("PNNMOS") = lobjDt.Rows(lintcont).Item("PNNMOS")
    '            lobjDr.Item("REGIMEN") = lobjDt.Rows(lintcont).Item("REGIMEN")

    '            lobjDr.Item("COD_TNMMDT") = lobjDt.Rows(lintcont).Item("COD_TNMMDT")
    '            lobjDr.Item("COD_DESPACHO") = lobjDt.Rows(lintcont).Item("COD_DESPACHO")



    '            Cuenta_Regimen(COD_REGIMEN, NORSCI)

    '            lobjDr.Item("FDCCMP") = lobjDt.Rows(lintcont).Item("FDCCMP")
    '            lobjDr.Item("DESPACHO") = lobjDt.Rows(lintcont).Item("DESPACHO")
    '            lobjDr.Item("TNMMDT") = lobjDt.Rows(lintcont).Item("TNMMDT")
    '            If IsDBNull(lobjDt.Rows(lintcont).Item("TCARGA")) Then
    '                lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '            Else
    '                oRepContenedor.Contar_Tipo_Contenedor(lobjDt.Rows(lintcont).Item("NCODRG").ToString.Trim, Double.Parse(lobjDt.Rows(lintcont).Item("NBLTAR")), Double.Parse(lobjDt.Rows(lintcont).Item("NDIASE")))
    '                If fValidaContenedorBulto(lobjDt.Rows(lintcont)) Then
    '                    lobjDr.Item("NBLTAR") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                Else
    '                    lobjDr.Item("NCONTEN") = lobjDt.Rows(lintcont).Item("NBLTAR")
    '                End If
    '            End If
    '            lobjDr.Item("QPSOAR") = lobjDt.Rows(lintcont).Item("QPSOAR")
    '            oRepDespacho.Cuenta_Peso(lobjDt.Rows(lintcont).Item("COD_TNMMDT"), Double.Parse(lobjDt.Rows(lintcont).Item("QPSOAR")))
    '            lobjDr.Item("EXW") = lobjDt.Rows(lintcont).Item("ITTEXW")
    '            lobjDr.Item("GFOB") = lobjDt.Rows(lintcont).Item("ITGFOB")
    '            lobjDr.Item("FOB") = lobjDt.Rows(lintcont).Item("ITTFOB")
    '            lobjDr.Item("FLETE") = lobjDt.Rows(lintcont).Item("IVLFLT")
    '            lobjDr.Item("SEGURO") = lobjDt.Rows(lintcont).Item("IVLSGR")
    '            lobjDr.Item("CIF") = lobjDt.Rows(lintcont).Item("ITTCIF")
    '            lobjDr.Item("ADVALOREM") = lobjDt.Rows(lintcont).Item("ITTADV")
    '            lobjDr.Item("IGVPM") = lobjDt.Rows(lintcont).Item("IGVPM")
    '            lobjDr.Item("OGASTOS") = lobjDt.Rows(lintcont).Item("ITTOGS")
    '            lobjDr.Item("DUA") = lobjDt.Rows(lintcont).Item("DUA")
    '            lobjDr.Item("CANAL") = lobjDt.Rows(lintcont).Item("TCANAL")
    '            lobjDr.Item("FAPRAR") = lobjDt.Rows(lintcont).Item("FAPRAR")
    '            lobjDr.Item("FECALM") = lobjDt.Rows(lintcont).Item("ALMCLI")
    '            lobjDr.Item("TOTDER") = lobjDt.Rows(lintcont).Item("TOTAL")


    '            lobjDr.Item("TPRVCL") = lobjDt.Rows(lintcont).Item("TPRVCL")
    '            lobjDr.Item("MERCADERIA") = lobjDt.Rows(lintcont).Item("MERCADERIA")
    '            lobjDr.Item("BL") = lobjDt.Rows(lintcont).Item("BL")
    '            TipoCarga = ("" & lobjDt.Rows(lintcont).Item("TCARGA")).ToString.Trim
    '            lobjDr.Item("TIPOCARGA") = TipoCarga

    '            ===================Diferencias  DOCUMENTOS - NUMERACION - DERECHOS=============================
    '            lobjDr.Item("DOCUMENTOS") = lobjDt.Rows(lintcont).Item("DOCUMENTOS")
    '            lobjDr.Item("NUMERACION") = lobjDt.Rows(lintcont).Item("NUMERACION")
    '            lobjDr.Item("DERECHOS") = lobjDt.Rows(lintcont).Item("DERECHOS")
    '            ==============Diferencia Fechas 01===============
    '            CHK_124_ENTREGA_ALMACEN = ("" & lobjDt.Rows(lintcont).Item("ALMCLI")).ToString.Trim
    '            CHK_120_DOC_COMPLETO = ("" & lobjDt.Rows(lintcont).Item("DOCUMENTOS")).ToString.Trim
    '            FECHA_FORSCI = ("" & lobjDt.Rows(lintcont).Item("FDCCMP")).ToString.Trim
    '            ETA_CHK_LLEGADA = ("" & lobjDt.Rows(lintcont).Item("FAPRAR")).ToString.Trim
    '            CHK_122_PAGO_DERECHO = ("" & lobjDt.Rows(lintcont).Item("DERECHOS")).ToString.Trim
    '            CHK_121_NUMERACION = ("" & lobjDt.Rows(lintcont).Item("NUMERACION")).ToString.Trim


    '            lintDias = DifDiasFechas(lobjDtDia, CHK_120_DOC_COMPLETO, CHK_124_ENTREGA_ALMACEN)
    '            lobjDr.Item("DIFDOCUMENTOS") = lintDias

    '            lintDias = DifDiasFechas(lobjDtDia, ETA_CHK_LLEGADA, CHK_120_DOC_COMPLETO)
    '            lobjDr.Item("DIFNUMERACION") = lintDias

    '            lintDias = DifDiasFechas(lobjDtDia, CHK_122_PAGO_DERECHO, CHK_121_NUMERACION)
    '            lobjDr.Item("DIFDERECHOS") = lintDias

    '            If lobjDt.Rows(lintcont).Item("DESPACHO").ToString.Trim = "ANTICIPADO" Or lobjDt.Rows(lintcont).Item("DESPACHO").ToString.Trim = "URGENTE" Then
    '                lintDias = DifDiasFechas(lobjDtDia, ETA_CHK_LLEGADA, CHK_124_ENTREGA_ALMACEN)
    '                lobjDr.Item("DIFATETA") = lintDias

    '                lintDias = DifDiasFechas(lobjDtDia, ETA_CHK_LLEGADA, FECHA_FORSCI)
    '                oRepDespacho.Anticipado_ETA_DocCom = oRepDespacho.Anticipado_ETA_DocCom + lintDias
    '            Else

    '                lintDias = DifDiasFechas(lobjDtDia, ETA_CHK_LLEGADA, CHK_124_ENTREGA_ALMACEN)
    '                lobjDr.Item("DIFATETA") = lintDias

    '                lintDias = DifDiasFechas(lobjDtDia, ETA_CHK_LLEGADA, FECHA_FORSCI)
    '                oRepDespacho.Normal_ETA_DocCom = oRepDespacho.Normal_ETA_DocCom + lintDias
    '            End If

    '            COD_DESPACHO = lobjDt.Rows(lintcont).Item("COD_DESPACHO")
    '            COD_TNMMDT = lobjDt.Rows(lintcont).Item("COD_TNMMDT")
    '            oRepDespacho.Cuenta_Despacho(COD_DESPACHO, COD_TNMMDT, Double.Parse(lobjDr.Item("DIFATETA")), pdblCodCli)
    '            oRepDespacho_Div_FueraObj.Cuenta_Despacho(COD_DESPACHO, COD_TNMMDT, Double.Parse(lobjDr.Item("DIFDOCUMENTOS")), pdblCodCli)
    '            If lintcont = lobjDt.Rows.Count - 1 Then
    '                lobjDtRep.Rows.Add(lobjDr)
    '            End If
    '        End If
    '    Next lintcont
    '    Return lobjDtRep
    'End Function


    Public Function dtRepMenAduanero(ByVal PSCCMPN As String, ByVal pIdioma As String, ByVal pstrCliente As String, ByVal pCCLNT As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pdblFecIniLab As Double, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim DtReport As New DataTable
        Dim dtCarga As New DataTable
        Dim dsRepMenAd As New DataSet

        Dim dtResult As New DataTable
        Dim dtFeriado As New DataTable
        Dim lintDias As Integer
        Dim drActual As DataRow
        strCliente = pstrCliente
        fdtFormatoTotalRegimen(oDtTotalReg)
        fdtFormatoRepMenAD(DtReport)
        oReporte = New Datos.clsRepMenAdn()

        dsRepMenAd = oReporte.dtRepMenAduanero(PSCCMPN, pCCLNT, pdblFecIni, pdblFecFin, PSTPSRVA, PNNESTDO, PSESTADO_EMB)
        dtResult = dsRepMenAd.Tables(0).Copy
        dtCarga = dsRepMenAd.Tables(1).Copy


        Dim odtTipoDespacho As New DataTable
        Dim odtCanal As New DataTable
        Dim odtMedioTransporte As New DataTable

        Dim NORSCI As Decimal = 0

        Select Case pIdioma
            Case "EN"
                Dim oListRegimen As New List(Of beRegimen)
                Dim brclsRegimen As New clsRegimen
                oListRegimen = brclsRegimen.ListarRegimen()

                Dim oDespacho As New clsDespacho
                oDespacho.Crea_Lista()
                odtTipoDespacho = oDespacho.Lista()

                Dim oCanal As New clsCanal
                Dim oLisCanal As New List(Of beCanal)
                Dim drCanal As DataRow
                odtCanal.Columns.Add(New DataColumn("NCANAL", GetType(String)))
                odtCanal.Columns.Add(New DataColumn("TCANAL", GetType(String)))
                odtCanal.Columns.Add(New DataColumn("TCANAL_ING", GetType(String)))
                oLisCanal = oCanal.Lista_Canal("")
                For Each Item As beCanal In oLisCanal
                    drCanal = odtCanal.NewRow
                    drCanal("NCANAL") = Item.PSNCANAL
                    drCanal("TCANAL") = Item.PSTCANAL
                    drCanal("TCANAL_ING") = Item.PSTCANAL_ING
                    odtCanal.Rows.Add(drCanal)
                Next

                'oCanal.Lista_Canal()
                'odtCanal = oCanal.Tabla

                Dim oEnvio As New clsEnvio
                oEnvio.Listar_Envio(1)
                odtMedioTransporte = oEnvio.Lista

                For Each Item As DataRow In _dtRegimen.Rows
                    If Item("Codigo") <> 0 Then
                        Item("Regimen") = BuscarRegimenIngles(oListRegimen, Item("Codigo"))
                    End If
                Next

                For Each Item As DataRow In dtResult.Rows
                    Item("TCANAL") = BuscarCanalIng(odtCanal, ("" & Item("TCANAL")).ToString.Trim)
                    Item("REGIMEN") = BuscarRegimenIngles(oListRegimen, Item("COD_REGIMEN"))
                    Item("TNMMDT") = BuscarTipoTransporteIng(odtMedioTransporte, Item("COD_TNMMDT"))
                    Item("DESPACHO") = BuscarTipoDespachoIng(odtTipoDespacho, Item("COD_DESPACHO"))
                Next

            Case "ES"
        End Select

        dtFeriado = oReporte.dtNoLaborables(pdblFecIniLab, pdblFecFin)

        oRepContenedor = New clsRepContenedor
        oRepDespacho = New clsRepDespacho

        oRepDespacho_Div_FueraObj = New clsRepDespacho

        Dim COD_REGIMEN As Decimal = 0
        Dim COD_DESPACHO As Decimal = 0
        Dim COD_TNMMDT As Decimal = 0

        Dim CHK_120_DOC_COMPLETO As String = ""
        Dim CHK_121_NUMERACION As String = ""
        Dim CHK_122_PAGO_DERECHO As String = ""
        Dim CHK_124_ENTREGA_ALMACEN As String = ""
        Dim CHK_123_FECHA_LEVANTE = ""
        Dim ETA_CHK_LLEGADA As String = ""
        Dim FECHA_FORSCI As String = ""



        Dim TipoCarga As String = ""
        Dim NumFilas As Int64 = dtResult.Rows.Count - 1
        Dim drDatosEmb() As DataRow
        Dim NCODRGTipoCarga As Int64 = 0
        Dim NBLTAR As Int64 = 0
        Dim NDIASE As Int64 = 0
        Dim sbTipoCarga As New StringBuilder
        Dim NumContenedores As Int64 = 0
        Dim numBultos As Int64 = 0
        Dim Despacho As String = ""
        Dim QPSOAR As Decimal = 0

        Dim NaveCiaTransporte As String = ""
        Dim Nave As String = ""
        Dim CiaTransporte As String = ""


        For Fila As Int32 = 0 To NumFilas
            NORSCI = dtResult.Rows(Fila).Item("NORSCI")

            drActual = DtReport.NewRow
            COD_REGIMEN = dtResult.Rows(Fila).Item("COD_REGIMEN")
            COD_DESPACHO = dtResult.Rows(Fila)("COD_DESPACHO")
            COD_TNMMDT = dtResult.Rows(Fila)("COD_TNMMDT")
            QPSOAR = dtResult.Rows(Fila)("QPSOAR")
            Despacho = dtResult.Rows(Fila)("DESPACHO")


            drActual("NORSCI") = NORSCI
            drActual("TCMPCL") = strCliente & " - " & pCCLNT
            drActual("CORRELATIVO") = DtReport.Rows.Count + 1
            drActual("NORCML") = dtResult.Rows(Fila)("NORCML")
            drActual("PNNMOS") = dtResult.Rows(Fila)("PNNMOS")
            drActual("REGIMEN") = dtResult.Rows(Fila)("REGIMEN")
            drActual("COD_TNMMDT") = dtResult.Rows(Fila)("COD_TNMMDT")
            drActual("COD_DESPACHO") = dtResult.Rows(Fila)("COD_DESPACHO")

            drActual("FDCCMP") = dtResult.Rows(Fila)("FORSCI")

            drActual("DESPACHO") = dtResult.Rows(Fila)("DESPACHO")
            drActual("TNMMDT") = dtResult.Rows(Fila)("TNMMDT")
            drActual.Item("QPSOAR") = QPSOAR

            drActual("EXW") = dtResult.Rows(Fila)("ITTEXW")
            drActual("GFOB") = dtResult.Rows(Fila)("ITGFOB")
            drActual("FOB") = dtResult.Rows(Fila)("ITTFOB")
            drActual("FLETE") = dtResult.Rows(Fila)("IVLFLT")
            drActual("SEGURO") = dtResult.Rows(Fila)("IVLSGR")
            drActual("CIF") = dtResult.Rows(Fila)("ITTCIF")
            drActual("ADVALOREM") = dtResult.Rows(Fila)("ITTADV")
            drActual("IGVPM") = dtResult.Rows(Fila)("IGVPM")
            drActual("OGASTOS") = dtResult.Rows(Fila)("ITTOGS")
            drActual("TOTDER") = dtResult.Rows(Fila)("TOTAL")

            drActual("DUA") = dtResult.Rows(Fila)("DUA")
            drActual("CANAL") = dtResult.Rows(Fila)("TCANAL")

            drActual("FAPRAR") = dtResult.Rows(Fila)("FAPRAR")
            drActual("FECALM") = dtResult.Rows(Fila)("ALMCLI")
            drActual("LEVANTE") = dtResult.Rows(Fila)("LEVANTE")


            drActual("TPRVCL") = dtResult.Rows(Fila)("TPRVCL")
            drActual("MERCADERIA") = dtResult.Rows(Fila)("MERCADERIA")
            drActual("BL") = dtResult.Rows(Fila)("BL")
            drActual("REFDO1") = dtResult.Rows(Fila)("REFDO1")

            '*****ADICiON***************
            Nave = dtResult.Rows(Fila)("TCMPVP").ToString
            CiaTransporte = dtResult.Rows(Fila)("TNMCIN").ToString
            NaveCiaTransporte = ""

            If Nave.Length > 0 Then
                NaveCiaTransporte = Nave
                If CiaTransporte.Length > 0 Then
                    NaveCiaTransporte = String.Format("{0} / {1}", NaveCiaTransporte, Nave)
                End If
            Else
                NaveCiaTransporte = CiaTransporte
            End If
            drActual("NAVE_CIATRANSPORTE") = NaveCiaTransporte
            drActual("AGENTE_CARGA") = dtResult.Rows(Fila)("TNMAGC")
            drActual("TERMINAL") = dtResult.Rows(Fila)("TTRMAL")
            drActual("PAIS_ORIGEN") = dtResult.Rows(Fila)("TCMPPS")
            drActual("PUERTO_ORIGEN") = dtResult.Rows(Fila)("DES_CPRTOE")
            drActual("M3") = dtResult.Rows(Fila)("QVOLMR")
            drActual("TRANSPORTE_LOCAL") = dtResult.Rows(Fila)("TCMTRT")
            drActual("ALMACEN_LOCAL") = dtResult.Rows(Fila)("DES_ALMLOCAL")
            '*************************

            '===================Diferencias  DOCUMENTOS - NUMERACION - DERECHOS=============================
            drActual("DOCUMENTOS") = dtResult.Rows(Fila)("DOCUMENTOS")
            drActual("NUMERACION") = dtResult.Rows(Fila)("NUMERACION")
            drActual("DERECHOS") = dtResult.Rows(Fila)("DERECHOS")

            CHK_124_ENTREGA_ALMACEN = dtResult.Rows(Fila)("ALMCLI")
            CHK_120_DOC_COMPLETO = dtResult.Rows(Fila)("DOCUMENTOS")
            FECHA_FORSCI = dtResult.Rows(Fila)("FORSCI")
            ETA_CHK_LLEGADA = dtResult.Rows(Fila)("FAPRAR")
            CHK_122_PAGO_DERECHO = dtResult.Rows(Fila)("DERECHOS")
            CHK_121_NUMERACION = dtResult.Rows(Fila)("NUMERACION")
            CHK_123_FECHA_LEVANTE = dtResult.Rows(Fila)("LEVANTE")



            lintDias = DifDiasFechas(dtFeriado, CHK_120_DOC_COMPLETO, CHK_124_ENTREGA_ALMACEN)
            drActual.Item("DIFDOCUMENTOS") = lintDias

            lintDias = DifDiasFechas(dtFeriado, ETA_CHK_LLEGADA, CHK_120_DOC_COMPLETO)
            drActual.Item("DIFNUMERACION") = lintDias

            lintDias = DifDiasFechas(dtFeriado, CHK_122_PAGO_DERECHO, CHK_121_NUMERACION)
            drActual.Item("DIFDERECHOS") = lintDias

            lintDias = DifDiasFechas(dtFeriado, CHK_121_NUMERACION, CHK_120_DOC_COMPLETO)
            drActual.Item("DIF_DOCCOMPLETO_NUMERACION") = lintDias

            lintDias = DifDiasFechas(dtFeriado, CHK_124_ENTREGA_ALMACEN, CHK_122_PAGO_DERECHO)
            drActual.Item("DIF_PAGODERECHO_ENTREGAALM") = lintDias


            If Despacho = "ANTICIPADO" OrElse Despacho = "URGENTE" Then
                lintDias = DifDiasFechas(dtFeriado, ETA_CHK_LLEGADA, CHK_124_ENTREGA_ALMACEN)
                drActual.Item("DIFATETA") = lintDias

                lintDias = DifDiasFechas(dtFeriado, ETA_CHK_LLEGADA, FECHA_FORSCI)
                oRepDespacho.Anticipado_ETA_DocCom = oRepDespacho.Anticipado_ETA_DocCom + lintDias
            Else

                lintDias = DifDiasFechas(dtFeriado, ETA_CHK_LLEGADA, CHK_124_ENTREGA_ALMACEN)
                drActual.Item("DIFATETA") = lintDias

                lintDias = DifDiasFechas(dtFeriado, ETA_CHK_LLEGADA, FECHA_FORSCI)
                oRepDespacho.Normal_ETA_DocCom = oRepDespacho.Normal_ETA_DocCom + lintDias
            End If

            Cuenta_Regimen(COD_REGIMEN, NORSCI)
            oRepDespacho.Cuenta_Peso(COD_TNMMDT, QPSOAR)
            oRepDespacho.Cuenta_Despacho(COD_DESPACHO, COD_TNMMDT, Double.Parse(drActual.Item("DIFATETA")), pCCLNT)
            oRepDespacho_Div_FueraObj.Cuenta_Despacho(COD_DESPACHO, COD_TNMMDT, Double.Parse(drActual.Item("DIFDOCUMENTOS")), pCCLNT)

            drDatosEmb = dtCarga.Select("NORSCI='" & NORSCI & "'")
            numBultos = 0
            NumContenedores = 0
            sbTipoCarga.Length = 0

            NDIASE = dtResult.Rows(Fila)("NDIASE")

            For FilaDatos As Integer = 0 To drDatosEmb.Length - 1
                NCODRGTipoCarga = drDatosEmb(FilaDatos)("NCODRG")
                NBLTAR = drDatosEmb(FilaDatos)("NBLTAR")
                oRepContenedor.Contar_Tipo_Contenedor(NCODRGTipoCarga, NBLTAR, NDIASE)
                If fValidaContenedorBulto(NCODRGTipoCarga) Then
                    numBultos = numBultos + NBLTAR
                Else
                    NumContenedores = NumContenedores + NBLTAR
                End If
                TipoCarga = HelpClass.ToStringCvr(drDatosEmb(FilaDatos)("TCARGA"))

                If TipoCarga.Length > 0 Then
                    sbTipoCarga.Append(TipoCarga)
                    sbTipoCarga.Append(",")
                End If
            Next
            TipoCarga = sbTipoCarga.ToString.Trim
            If TipoCarga.Length > 0 Then TipoCarga = TipoCarga.Substring(0, TipoCarga.LastIndexOf(","))
            If numBultos > 0 Then
                drActual("NBLTAR") = numBultos
            Else
                drActual("NBLTAR") = DBNull.Value
            End If
            If NumContenedores > 0 Then
                drActual("NCONTEN") = NumContenedores
            Else
                drActual("NCONTEN") = DBNull.Value
            End If
            drActual("TIPOCARGA") = TipoCarga

            DtReport.Rows.Add(drActual)
           
        Next
        Return DtReport
    End Function



    Private Function DifDiasFechas(ByVal dtListaFeriados As DataTable, ByVal FechaInf As String, ByVal FechaSup As String) As Int32
        FechaInf = FechaInf.Trim
        FechaSup = FechaSup.Trim
        Dim lobjDrList As DataRow()
        Dim EsFecha As Date
        Dim DifDias As Int32 = 0
        Dim lintDias As Int32 = 0
        If Date.TryParse(FechaInf, EsFecha) AndAlso Date.TryParse(FechaSup, EsFecha) Then
            If FechaInf = FechaSup Then
                DifDias = 0
            Else
                lobjDrList = dtListaFeriados.Select("FFRDO >= " & Format(CType(FechaInf, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(FechaSup, Date), "yyyyMMdd"))
                DifDias = lobjDrList.Length
            End If
            lintDias = fintDiferencia_Dia_V2(FechaSup, FechaInf, DifDias)
        Else
            lintDias = 0
        End If
        Return lintDias
    End Function


End Class
