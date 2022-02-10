Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario

Imports Newtonsoft
Imports Newtonsoft.Json


Namespace mantenimientos

    Public Class ReportesVariados_BLL
        Dim objDataAccessLayer As New ReportesVariados_DAL

        Public Function Listado_Seguro_Flete(ByVal objcoleccion As Collection) As DataSet
            Return objDataAccessLayer.Listado_Seguro_Flete(objcoleccion)
        End Function

        Public Function ReporteMensual(ByVal objEntidad As ReporteMensualEntidad) As DataSet
            Return objDataAccessLayer.ReporteMensual(objEntidad)
        End Function

        Public Function Datos_Reporte_Guias_ABC(ByVal ht As Hashtable) As DataSet
            Return objDataAccessLayer.Datos_Reporte_Guias_ABC(ht)
        End Function

      
        Private Function EsFleteServicio(ByVal dtListaFlete As DataTable, ByVal CodServ As Decimal) As Boolean
            Dim EsFlete As Boolean = False
            Dim dr() As DataRow
            dr = dtListaFlete.Select("CSRVC='" & CodServ & "'")
            If dr.Length > 0 Then
                EsFlete = True
            End If
            Return EsFlete
        End Function

      


        


      


        Private Function ListarLiqCombustible(dtLiqCombustible As DataTable, NLQCMB As Decimal, NOPRCN As Decimal) As beResultadoOP
           Dim obeLiqCombustible As New beResultadoOP
            Dim drLiq() As DataRow
            Dim GastoComb As Decimal = 0
            Dim CantGalComb As Decimal = 0
            Dim CantUrea As Decimal = 0
            Dim GastoUrea As Decimal = 0
            Dim Km_Recorrido As Decimal = 0
            Dim pesoIda As Decimal = 0
            Dim pesoRetorno As Decimal = 0
            Dim pesoInterno As Decimal = 0

            drLiq = dtLiqCombustible.Select("NLQCMB='" & NLQCMB & "' AND NOPRCN='" & NOPRCN & "'")
            For Each itemLiq As DataRow In drLiq
                CantGalComb = CantGalComb + itemLiq("QGLNCM")
                GastoComb = GastoComb + itemLiq("CSTTCB")
                CantUrea = CantUrea + itemLiq("QGUREA")
                GastoUrea = GastoUrea + itemLiq("CTUREA")
                Km_Recorrido = Km_Recorrido + itemLiq("NKMRCR")
                pesoIda = pesoIda + itemLiq("PESO_IDA")
                pesoRetorno = pesoRetorno + itemLiq("PESO_RETORNO")
                pesoInterno = pesoInterno + itemLiq("PESO_INTERNO")


            Next
            obeLiqCombustible.QGLNCM = Math.Round(CantGalComb, 2)
            obeLiqCombustible.CSTTCB = Math.Round(GastoComb, 2)
            obeLiqCombustible.QGUREA = Math.Round(CantUrea, 2)
            obeLiqCombustible.CTUREA = Math.Round(GastoUrea, 2)
            obeLiqCombustible.NKMRCR = Math.Round(Km_Recorrido, 2)


            obeLiqCombustible.PESO_IDA = Math.Round(pesoIda, 2)
            obeLiqCombustible.PESO_RETORNO = Math.Round(pesoRetorno, 2)
            obeLiqCombustible.PESO_INTERNO = Math.Round(pesoInterno, 2)



            obeLiqCombustible.REND_COMB = 0
            If obeLiqCombustible.QGLNCM > 0 Then
                obeLiqCombustible.REND_COMB = Math.Round(obeLiqCombustible.NKMRCR / obeLiqCombustible.QGLNCM, 2)
            End If
            obeLiqCombustible.REND_UREA = 0
            If obeLiqCombustible.QGUREA > 0 Then
                obeLiqCombustible.REND_UREA = Math.Round(obeLiqCombustible.NKMRCR / obeLiqCombustible.QGUREA, 2)
            End If


           
            Return obeLiqCombustible

        End Function
        'NORCMC
        Private Function CalcularLiquidacionFlete(dtListaCodFletes As DataTable, dtServicios As DataTable, NOPRCN As Decimal, SIN_CARGA_GR As String, NGUIRT As Decimal, oTarifaOS As beResultadoOP) As beResultadoOP
            Dim obeResultadoOP As New beResultadoOP
            Dim drServ() As DataRow
            Dim dtServicio_x_Op As New DataTable
            drServ = dtServicios.Select("NOPRCN='" & NOPRCN & "' AND NGUITR='" & NGUIRT & "'")
            dtServicio_x_Op = HelpClass.RowToDatatable(drServ, dtServicios)

            obeResultadoOP.ID_MONEDA_COBRO = oTarifaOS.ID_MONEDA_COBRO_OS
            obeResultadoOP.MONEDA_COBRO = oTarifaOS.MONEDA_COBRO_OS
            obeResultadoOP.TARIFA_COBRO = oTarifaOS.TARIFA_COBRO_OS

            obeResultadoOP.ID_MONEDA_PAGO = oTarifaOS.ID_MONEDA_PAGO_OS
            obeResultadoOP.MONEDA_PAGO = oTarifaOS.MONEDA_PAGO_OS
            obeResultadoOP.TARIFA_PAGO = oTarifaOS.TARIFA_PAGO_OS

            'obeResultadoOP.ID_MONEDA_TI = oTarifaOS.ID_MONEDA_TI_OS
            'obeResultadoOP.MONEDA_TI = oTarifaOS.MONEDA_TI_OS
            'obeResultadoOP.TARIFA_INTERNA = oTarifaOS.TARIFA_INTERNA_OS


            Dim TC As Decimal = oTarifaOS.TC_COBRO
            If dtServicio_x_Op.Rows.Count = 0 Then

                Dim drT As DataRow
                drT = dtServicio_x_Op.NewRow
                drT("NOPRCN") = NOPRCN
                drT("CSRVC") = 1

                drT("IMPORTE_COBRO_SOL") = 0
                drT("IMPORTE_COBRO_DOL") = 0
                drT("IMPORTE_PAGO_SOL") = 0
                drT("IMPORTE_PAGO_DOL") = 0



                If obeResultadoOP.ID_MONEDA_COBRO = 1 Then
                    drT("IMPORTE_COBRO_SOL") = obeResultadoOP.TARIFA_COBRO
                    drT("IMPORTE_COBRO_DOL") = Math.Round(obeResultadoOP.TARIFA_COBRO / TC, 2, MidpointRounding.AwayFromZero)
                End If
                If obeResultadoOP.ID_MONEDA_COBRO = 100 Then
                    drT("IMPORTE_COBRO_SOL") = Math.Round(obeResultadoOP.TARIFA_COBRO * TC, 2, MidpointRounding.AwayFromZero)
                    drT("IMPORTE_COBRO_DOL") = obeResultadoOP.TARIFA_COBRO
                End If
                If obeResultadoOP.ID_MONEDA_PAGO = 1 Then
                    drT("IMPORTE_PAGO_SOL") = obeResultadoOP.TARIFA_PAGO
                    drT("IMPORTE_PAGO_DOL") = Math.Round(obeResultadoOP.TARIFA_PAGO / TC, 2, MidpointRounding.AwayFromZero)
                End If
                If obeResultadoOP.ID_MONEDA_PAGO = 100 Then
                    drT("IMPORTE_PAGO_SOL") = Math.Round(obeResultadoOP.TARIFA_PAGO * TC, 2, MidpointRounding.AwayFromZero)
                    drT("IMPORTE_PAGO_DOL") = obeResultadoOP.TARIFA_PAGO
                End If
                'If obeResultadoOP.ID_MONEDA_TI = 1 Then
                '    drT("IMPORTE_TI_SOL") = obeResultadoOP.TARIFA_INTERNA
                '    drT("IMPORTE_TI_DOL") = Math.Round(obeResultadoOP.TARIFA_INTERNA / TC, 2, MidpointRounding.AwayFromZero)
                'End If
                'If obeResultadoOP.ID_MONEDA_TI = 100 Then
                '    drT("IMPORTE_TI_SOL") = Math.Round(obeResultadoOP.TARIFA_INTERNA * TC, 2, MidpointRounding.AwayFromZero)
                '    drT("IMPORTE_TI_DOL") = obeResultadoOP.TARIFA_INTERNA
                'End If
                dtServicio_x_Op.Rows.Add(drT)

            End If

            Dim TotalCobroSol As Decimal = 0
            Dim TotalCobroSoloFleteSol As Decimal = 0
            Dim TotalCobroOtrosSol As Decimal = 0

            Dim TotalPagoSol As Decimal = 0
            Dim TotalPagoSoloFleteSol As Decimal = 0
            Dim TotalPagoOtrosSol As Decimal = 0

            'Dim TotalTISol As Decimal = 0
            'Dim TotalTISoloFleteSol As Decimal = 0
            'Dim TotalTIOtrosSol As Decimal = 0

            Dim TarifaCobro As Decimal = 0
            Dim TarifaPago As Decimal = 0
            Dim TarifaTI As Decimal = 0


            For Each dr As DataRow In dtServicio_x_Op.Rows

                If obeResultadoOP.ID_MONEDA_COBRO = 1 Then
                    TarifaCobro = TarifaCobro + dr("IMPORTE_COBRO_SOL")
                End If
                If obeResultadoOP.ID_MONEDA_COBRO = 100 Then
                    TarifaCobro = TarifaCobro + dr("IMPORTE_COBRO_DOL")
                End If
                TotalCobroSol = TotalCobroSol + dr("IMPORTE_COBRO_SOL")
                If EsFleteServicio(dtListaCodFletes, Val("" & dr("CSRVC"))) Then
                    TotalCobroSoloFleteSol = TotalCobroSoloFleteSol + dr("IMPORTE_COBRO_SOL")
                Else
                    TotalCobroOtrosSol = TotalCobroOtrosSol + dr("IMPORTE_COBRO_SOL")
                End If

                If obeResultadoOP.ID_MONEDA_PAGO = 1 Then
                    TarifaPago = TarifaPago + dr("IMPORTE_PAGO_SOL")
                End If
                If obeResultadoOP.ID_MONEDA_PAGO = 100 Then
                    TarifaPago = TarifaPago + dr("IMPORTE_PAGO_DOL")
                End If
                TotalPagoSol = TotalPagoSol + dr("IMPORTE_PAGO_SOL")
                If EsFleteServicio(dtListaCodFletes, Val("" & dr("CSRVC"))) Then
                    TotalPagoSoloFleteSol = TotalPagoSoloFleteSol + dr("IMPORTE_PAGO_SOL")
                Else
                    TotalPagoOtrosSol = TotalPagoOtrosSol + dr("IMPORTE_PAGO_SOL")
                End If

                'If obeResultadoOP.ID_MONEDA_TI = 1 Then
                '    TarifaTI = TarifaTI + dr("IMPORTE_TI_SOL")
                'End If
                'If obeResultadoOP.ID_MONEDA_TI = 100 Then
                '    TarifaTI = TarifaTI + dr("IMPORTE_TI_DOL")
                'End If
                'TotalTISol = TotalTISol + dr("IMPORTE_TI_SOL")
                'If EsFleteServicio(dtListaCodFletes, Val("" & dr("CSRVC"))) Then
                '    TotalTISoloFleteSol = TotalTISoloFleteSol + dr("IMPORTE_TI_SOL")
                'Else
                '    TotalTIOtrosSol = TotalTIOtrosSol + dr("IMPORTE_TI_SOL")
                'End If

            Next

            obeResultadoOP.TARIFA_COBRO = TarifaCobro
            obeResultadoOP.TOT_COBRO_S = TotalCobroSol
            obeResultadoOP.TOT_COBRO_S_FLETE = TotalCobroSoloFleteSol
            obeResultadoOP.TOT_COBRO_S_OTROS = TotalCobroOtrosSol

            obeResultadoOP.TARIFA_PAGO = TarifaPago
            obeResultadoOP.TOT_PAGO_S = TotalPagoSol
            obeResultadoOP.TOT_PAGO_S_FLETE = TotalPagoSoloFleteSol
            obeResultadoOP.TOT_PAGO_S_OTROS = TotalPagoOtrosSol

            'obeResultadoOP.TARIFA_INTERNA = TarifaTI
            'obeResultadoOP.TOT_TARIFA_TI_S = TotalTISol
            'obeResultadoOP.TOT_TI_S_FLETE = TotalTISoloFleteSol
            'obeResultadoOP.TOT_TI_S_OTROS = TotalTIOtrosSol


            Return obeResultadoOP
        End Function
        Private Function SegAdministrativoOperacion(dtSegOp As DataTable, NOPRCN As Decimal) As beResultadoOP
            Dim dr() As DataRow
            Dim obeSegAdminOp As New beResultadoOP
            dr = dtSegOp.Select("NOPRCN='" & NOPRCN & "'")
            Dim ItemMax As Integer = 0
            Dim ItemRecep As Integer = 0
            Dim ItemDevolucion As Integer = 0

            Dim filaSegAdmininicial As Int32 = 0
            For Each item As DataRow In dr
                If item("NCRRSG") >= ItemMax Then
                    ItemMax = item("NCRRSG")
                    obeSegAdminOp.ESTADO_SEG_AD_OP = item("SESTTP_DESC")
                    obeSegAdminOp.FECHA_SEG_AD_OP = Val("" & item("FDSGDC"))
                    obeSegAdminOp.HORA_SEG_AD_OP = Val("" & item("HDSGDC"))
                End If

                If filaSegAdmininicial = 0 And item("SESTTP") = "A" Then
                    obeSegAdminOp.FECHA_SEG_ADMIN_INICIAL = Val("" & item("FDSGDC"))
                    filaSegAdmininicial = filaSegAdmininicial + 1
                End If


                If ItemRecep = 0 And item("SESTTP") = "A" Then
                    obeSegAdminOp.FECHA_SEG_ADMIN_INICIAL = Val("" & item("FDSGDC"))
                End If

                If item("NCRRSG") >= ItemRecep And item("SESTTP") = "A" Then
                    ItemRecep = item("NCRRSG")
                   

                    obeSegAdminOp.FECHA_SEG_ADMIN = Val("" & item("FDSGDC"))
                    obeSegAdminOp.HORA_SEG_ADMIN = Val("" & item("HDSGDC"))
                    obeSegAdminOp.RESPON_SEG_DOC = item("URSPDC").ToString.Trim
                    obeSegAdminOp.FECHA_RECEP_GT = Val("" & item("FCNFCL"))
                    obeSegAdminOp.HORA_RECEP_GT = Val("" & item("HCNFCL"))


                End If
                If item("NCRRSG") >= ItemDevolucion And (item("SESTTP") = "O" Or item("SESTTP") = "G") Then
                    ItemDevolucion = item("NCRRSG")
                
                    obeSegAdminOp.FECHA_SEG_OP = Val("" & item("FDSGDC"))
                    obeSegAdminOp.HORA_SEG_OP = Val("" & item("HDSGDC"))
                End If

            Next
 


            Return obeSegAdminOp

 
        End Function

        Private Function CalcularGastos_AVC(dtGastosAVC As DataTable, NOPRCN As Decimal) As beResultadoOP
            Dim obeResultadoOP As New beResultadoOP
            Dim drGastos_AVC() As DataRow
            Dim Gastos As Decimal = 0
            Dim AVC As Decimal = 0
            drGastos_AVC = dtGastosAVC.Select("NOPRCN='" & NOPRCN & "'")
            For Each item As DataRow In drGastos_AVC
                If item("NCTAVC") = 0 Then
                    Gastos = Gastos + Val(item("IGSTOS"))
                End If
                If item("NCTAVC") <> 0 Then
                    AVC = AVC + Val(item("IGSTOS"))
                End If
            Next
            obeResultadoOP.GASTOS = Math.Round(Gastos, 2)
            obeResultadoOP.GASTOAVC = Math.Round(AVC, 2)
            Return obeResultadoOP
        End Function

        Private Function FormatearDocGuia(Tipo As String, Documento As String) As String
            Dim tamanio As String = Documento.Length
            Select Case Tipo
                Case "F"
                    If tamanio <= 10 Then
                        Documento = Documento.PadLeft(10, "0")
                        Documento = Documento.Substring(0, 3) & "-" & Documento.Substring(3, 7)
                    End If

                Case "E"
                    'If tamanio = 12 Then
                    '    Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4, 8)
                    'End If
                    Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4)
            End Select
            Return Documento
        End Function

        Public Function frptMovimientoOperaciones_v2(ByVal ht As Hashtable, ByRef OP As Decimal, ByRef msg As String) As DataSet

            Dim odsResultado As New DataSet
            Dim ad_columna_pesoAlmacen As String = ht.Item("AD_COL_PESOALM")

            Dim dtOperacion As New DataTable
            Dim dtServicios As New DataTable
            Dim dtGR_OC As New DataTable
            Dim dtLiqCombustible As New DataTable

            Dim dtGasto_AVC As New DataTable
            Dim dtPedidoCompra As New DataTable
            Dim dtSegAdmOP As New DataTable
            Dim dtResult As New DataTable
            Dim Operacion As Decimal = 0
            Dim LiqCombust As Decimal = 0
            Dim CodTransportista As Decimal = 0
            Dim GuiaTransp As Decimal = 0
            Dim GuiaRemLiq As Decimal = 0


            Dim objNegocios As New ServicioMercaderia_BLL
            Dim objEntidad As New Hashtable
            objEntidad.Add("PSCCMPN", ht.Item("CCMPN"))
            objEntidad.Add("PSCDVSN", ht.Item("CDVSN"))
            Dim dtListaCodFletes As New DataTable
            dtListaCodFletes = objNegocios.ListaServicioFlete(objEntidad)

            'Dim ds As DataSet = objDataAccessLayer.frptMovimientoOperaciones_v2(ht)
            Dim ds As DataSet = objDataAccessLayer.frptMovimientoOperaciones_v3(ht)
            dtOperacion = ds.Tables(0).Copy
            dtServicios = ds.Tables(1).Copy
            dtGR_OC = ds.Tables(2).Copy
            dtLiqCombustible = ds.Tables(3).Copy

            dtGasto_AVC = ds.Tables(4).Copy
            dtPedidoCompra = ds.Tables(5).Copy
            dtSegAdmOP = ds.Tables(6).Copy


            dtOperacion.Columns.Add("FILA")
            dtOperacion.Columns.Add("PESO_ALM", Type.GetType("System.Decimal"))


            dtOperacion.Columns.Add("NGUIRM")
            'dtOperacion.Columns.Add("NGUITR_FM")
            dtOperacion.Columns.Add("NORCML")
            dtOperacion.Columns.Add("NLQDCN")
            dtOperacion.Columns.Add("FCH_LIQ")
            dtOperacion.Columns.Add("USU_LIQ")
            dtOperacion.Columns.Add("NRFSAP")

            'dtOperacion.Columns.Add("NTARINT")
            'dtOperacion.Columns.Add("FCHTARINT")
            'dtOperacion.Columns.Add("NREFTARINT")


            dtOperacion.Columns.Add("QGLNCM", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("CSTTCB", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("QGUREA", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("CTUREA", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("KM_COMB", Type.GetType("System.Decimal")) ' km reales combustible por operacion
            dtOperacion.Columns.Add("REND_COMB", Type.GetType("System.Decimal")) ' para rendimiento combustible
            dtOperacion.Columns.Add("REND_UREA", Type.GetType("System.Decimal")) ' para rendimiento urea

            dtOperacion.Columns.Add("PESO_IDA", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("PESO_RETORNO", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("PESO_INTERNO", Type.GetType("System.Decimal"))



            dtOperacion.Columns.Add("GASTOS", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("GASTOAVC", Type.GetType("System.Decimal"))

            dtOperacion.Columns.Add("MNDCO") ' moneda cobrar
            dtOperacion.Columns.Add("IMPCO", Type.GetType("System.Decimal")) ' tarifa cobrar
            dtOperacion.Columns.Add("IMPCO_SOLES", Type.GetType("System.Decimal"))  'total tarifa cobrar soles
            dtOperacion.Columns.Add("CO_SOLO_FLETE", Type.GetType("System.Decimal")) 'flete cobrar soles
            dtOperacion.Columns.Add("CO_OT_FLETE", Type.GetType("System.Decimal")) 'otros servicios cobrar
            dtOperacion.Columns.Add("CO_SOLO_FLETE_SOL", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("CO_OT_FLETE_SOL", Type.GetType("System.Decimal"))


            dtOperacion.Columns.Add("MNDPA") ' moneda pagar
            dtOperacion.Columns.Add("IMPPA", Type.GetType("System.Decimal")) ' tarifa pagar
            dtOperacion.Columns.Add("IMPPA_SOLES", Type.GetType("System.Decimal")) 'tot tarifa pagar soles
            dtOperacion.Columns.Add("PA_SOLO_FLETE", Type.GetType("System.Decimal")) 'flete pagar soles
            dtOperacion.Columns.Add("PA_OT_FLETE", Type.GetType("System.Decimal")) 'otros serv pagar soles
            dtOperacion.Columns.Add("PA_SOLO_FLETE_SOL", Type.GetType("System.Decimal")) ' 
            dtOperacion.Columns.Add("PA_OT_FLETE_SOL", Type.GetType("System.Decimal"))

            dtOperacion.Columns.Add("IMPORTE_NETO", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("MARGEN", Type.GetType("System.Decimal"))

            dtOperacion.Columns.Add("SESTTP_DESC")
            dtOperacion.Columns.Add("FDSGDC")
            dtOperacion.Columns.Add("HDSGDC")
            dtOperacion.Columns.Add("FDSGDC_ADM")
            dtOperacion.Columns.Add("HDSGDC_ADM")
            dtOperacion.Columns.Add("URSPDC")
            dtOperacion.Columns.Add("FDSGDC_ADM_INI")


            dtOperacion.Columns.Add("FCNFCL_GT")
            dtOperacion.Columns.Add("HCNFCL_GT")

            dtOperacion.Columns.Add("FDSGDC_OP")
            dtOperacion.Columns.Add("HDSGDC_OP")


            Dim obeResultadoOP As beResultadoOP
            Dim obeTarifaOS As beResultadoOP
            Dim SIN_CARGA_GR As String = ""
            Dim strResultado As String = ""

            Dim oclsResultadoBusqueda As clsResultadoBusqueda

            Dim JsGt As Dictionary(Of String, Object)
            Dim listJsGT As New List(Of Dictionary(Of String, Object))
            Dim listjson As New List(Of String)
            Dim listjsmax As Int64 = 1000
            Dim StrJson As String = ""

            Dim FILA As Int64 = 0
            Dim FinFila As Boolean = False
            For Each item As DataRow In dtOperacion.Rows


                FILA = FILA + 1
                item("FILA") = FILA
                If dtOperacion.Rows.Count = FILA Then
                    FinFila = True
                End If



                Operacion = item("NOPRCN")
                LiqCombust = item("NLQCMB")
                SIN_CARGA_GR = item("SIN_CARGA_GR").ToString.Trim
                OP = Operacion
                CodTransportista = Val("" & item("CTRMNC"))
                GuiaTransp = Val("" & item("NGUITR"))
                GuiaRemLiq = Val("" & item("NGUIAR"))


                If GuiaTransp > 0 Then
                    JsGt = New Dictionary(Of String, Object)
                    JsGt.Add("FL", item("FILA"))
                    JsGt.Add("CODT", CodTransportista)
                    JsGt.Add("GT", GuiaTransp)
                    listJsGT.Add(JsGt)
                End If
                If listJsGT.Count >= listjsmax Or FinFila = True Then
                    StrJson = JsonConvert.SerializeObject(listJsGT)
                    listjson.Add(StrJson)
                    listJsGT = New List(Of Dictionary(Of String, Object))
                End If

                item("CTDGRT") = ("" & item("CTDGRT")).ToString.Trim
                item("NGUITS") = ("" & item("NGUITS")).ToString.Trim
                item("NGUITS") = FormatearDocGuia(item("CTDGRT"), item("NGUITS"))

                msg = "Inicio  carga fechas"
                item("FINCOP") = HelpClass.CFecha_de_8_a_10("" & item("FINCOP"))
                item("FATNSR") = HelpClass.CFecha_de_8_a_10("" & item("FATNSR"))
                item("HATNSR") = HelpClass.HoraNum_a_Hora_Default("" & item("HATNSR"))
                item("FGUITR") = HelpClass.CFecha_de_8_a_10("" & item("FGUITR"))
                item("FCH_INI_TRASL_GT") = HelpClass.CFecha_de_8_a_10("" & item("FCH_INI_TRASL_GT"))
                item("FCH_EST_SAL_GT") = HelpClass.CFecha_de_8_a_10("" & item("FCH_EST_SAL_GT"))
                item("FCH_EST_LLEG_GT") = HelpClass.CFecha_de_8_a_10("" & item("FCH_EST_LLEG_GT"))
                item("FCH_FIN_TRASL_GT") = HelpClass.CFecha_de_8_a_10("" & item("FCH_FIN_TRASL_GT"))
                item("FCH_SALIDA_LIQ") = HelpClass.CFecha_de_8_a_10("" & item("FCH_SALIDA_LIQ"))
                item("FCH_LLEGADA_LIQ") = HelpClass.CFecha_de_8_a_10("" & item("FCH_LLEGADA_LIQ"))
                item("FDCPRF") = HelpClass.CFecha_de_8_a_10("" & item("FDCPRF"))
                item("FECFAC") = HelpClass.CFecha_de_8_a_10("" & item("FECFAC"))
                item("FIDESTM") = HelpClass.CFecha_de_8_a_10("" & item("FIDESTM"))
                item("FCH_ENVIO") = HelpClass.CFecha_de_8_a_10("" & item("FCH_ENVIO"))
                item("FECHA_LIQ") = HelpClass.CFecha_de_8_a_10("" & item("FECHA_LIQ"))
                item("FCIERRE_LIQ") = HelpClass.CFecha_de_8_a_10("" & item("FCIERRE_LIQ"))
                msg = "Fin  carga fechas"


                item("TPLNTA") = item("TPLNTA").ToString.Trim
                item("PLANTA_FACT") = item("PLANTA_FACT").ToString.Trim
                item("TCMTRT") = item("TCMTRT").ToString.Trim
                item("NPLVHT") = item("NPLVHT").ToString.Trim
                item("NPLCAC") = item("NPLCAC").ToString.Trim
                item("CBRCNT") = item("CBRCNT").ToString.Trim
                item("CONDUCTOR") = item("CONDUCTOR").ToString.Trim
                item("RECURSO_REASIG") = item("RECURSO_REASIG").ToString.Trim

                item("UATAOP") = item("UATAOP").ToString.Trim
                item("USLAOP") = item("USLAOP").ToString.Trim
                item("MOTAOP") = item("MOTAOP").ToString.Trim
                item("REEMPLAZO_OP") = item("REEMPLAZO_OP").ToString.Trim
                item("OBSAOP") = item("OBSAOP").ToString.Trim

                item("ORIGEN") = item("ORIGEN").ToString.Trim
                item("DESTIN") = item("DESTIN").ToString.Trim
                item("CTPUNV_UNID_VEHICULO") = item("CTPUNV_UNID_VEHICULO").ToString.Trim
                item("TRFMRC") = item("TRFMRC").ToString.Trim
                item("TNMMDT") = item("TNMMDT").ToString.Trim
                item("TOBS") = item("TOBS").ToString.Trim


                item("TRFRN") = item("TRFRN").ToString.Trim
                item("TPLNTA") = item("TPLNTA").ToString.Trim
                item("TCRVTA") = item("TCRVTA").ToString.Trim
                item("TIPO_VEHICULO") = item("TIPO_VEHICULO").ToString.Trim
                item("MERCADERIA") = item("MERCADERIA").ToString.Trim

                item("REEMPLAZO_OP") = item("REEMPLAZO_OP").ToString.Trim
                item("MOTAOP") = item("MOTAOP").ToString.Trim
                item("CCLNFC_DES") = item("CCLNFC_DES").ToString.Trim
                item("TDSRSP") = item("TDSRSP").ToString.Trim
                item("TDTSSP") = item("TDTSSP").ToString.Trim
                item("TDSPSP") = item("TDSPSP").ToString.Trim
                item("PLANTA_FACT") = item("PLANTA_FACT").ToString.Trim
                item("TDUPSP") = item("TDUPSP").ToString.Trim
                item("NIVSERV") = item("NIVSERV").ToString.Trim
                item("TIPCARGA") = item("TIPCARGA").ToString.Trim


                If Val(item("NDCPRF")) = 0 Then
                    item("NDCPRF") = ""
                End If
                If Val(item("NPRLQD")) = 0 Then
                    item("NPRLQD") = ""
                End If
                If Val(item("NDCMFC")) = 0 Then
                    item("NDCMFC") = ""
                End If


                msg = "Inicio  GR Cliente"

                Dim dr() As DataRow
                'Dim obeResultadoOP As New beResultadoOP
                Dim dtOC As New DataTable
                dr = dtGR_OC.Select("NOPRCN='" & Operacion & "' AND CTRMNC ='" & CodTransportista & "' AND NGUITR='" & GuiaTransp & "'")
                dtOC = HelpClass.RowToDatatable(dr, dtGR_OC)
                oclsResultadoBusqueda = New clsResultadoBusqueda
                'oclsResultadoBusqueda.AddCampo("NRGUCL")
                oclsResultadoBusqueda.AddCampo("NGUIRS", , , True)
                oclsResultadoBusqueda.AddCampo("NORCMC")
                oclsResultadoBusqueda.EjecutarBusquedaCampos(dtOC)
                'item("NGUIRM") = oclsResultadoBusqueda.GetCampo("NRGUCL")
                item("NGUIRM") = oclsResultadoBusqueda.GetCampo("NGUIRS")
                item("NORCML") = oclsResultadoBusqueda.GetCampo("NORCMC")

                msg = "Fin GR Cliente"


                msg = "Inicio  Liquidación"
                Dim drLiq() As DataRow
                Dim dtLiq As New DataTable
                drLiq = dtPedidoCompra.Select("NOPRCN='" & Operacion & "' AND NGUIAR='" & GuiaRemLiq & "'")
                dtLiq = HelpClass.RowToDatatable(drLiq, dtPedidoCompra)

                oclsResultadoBusqueda = New clsResultadoBusqueda
                oclsResultadoBusqueda.AddCampo("NLQDCN")
                oclsResultadoBusqueda.AddCampo("FLQDCN", True)
                oclsResultadoBusqueda.AddCampo("USU_LIQ")
                oclsResultadoBusqueda.AddCampo("NRFSAP")
                oclsResultadoBusqueda.EjecutarBusquedaCampos(dtLiq)
                item("NLQDCN") = oclsResultadoBusqueda.GetCampo("NLQDCN")
                item("FCH_LIQ") = oclsResultadoBusqueda.GetCampo("FLQDCN")
                item("USU_LIQ") = oclsResultadoBusqueda.GetCampo("USU_LIQ")
                item("NRFSAP") = oclsResultadoBusqueda.GetCampo("NRFSAP")

                msg = "Fin  Liquidación"


                msg = "Inicio  Gastos/AVC"
                obeResultadoOP = New beResultadoOP
                obeResultadoOP = CalcularGastos_AVC(dtGasto_AVC, Operacion)
                item("GASTOS") = obeResultadoOP.GASTOS
                item("GASTOAVC") = obeResultadoOP.GASTOAVC
                msg = "Fin  Gastos/AVC"

                msg = "Inicio  Liq Combustible"
                obeResultadoOP = New beResultadoOP
                obeResultadoOP = ListarLiqCombustible(dtLiqCombustible, LiqCombust, Operacion)
                item("QGLNCM") = obeResultadoOP.QGLNCM
                item("CSTTCB") = obeResultadoOP.CSTTCB
                item("QGUREA") = obeResultadoOP.QGUREA
                item("CTUREA") = obeResultadoOP.CTUREA

                item("KM_COMB") = obeResultadoOP.NKMRCR
                item("REND_COMB") = obeResultadoOP.REND_COMB
                item("REND_UREA") = obeResultadoOP.REND_UREA


                item("PESO_IDA") = obeResultadoOP.PESO_IDA
                item("PESO_RETORNO") = obeResultadoOP.PESO_RETORNO
                item("PESO_INTERNO") = obeResultadoOP.PESO_INTERNO


                msg = "Fin  Liq Combustible"

                msg = "Inicio  Cálculo costos Flete"
                obeTarifaOS = New beResultadoOP
                obeTarifaOS.ID_MONEDA_COBRO_OS = item("CMNTRN_OS")
                obeTarifaOS.MONEDA_COBRO_OS = ("" & item("MNDCO_OS")).ToString.Trim
                obeTarifaOS.TARIFA_COBRO_OS = item("ITRSRT_OS")
                obeTarifaOS.ID_MONEDA_PAGO_OS = item("CMNLQT_OS")
                obeTarifaOS.MONEDA_PAGO_OS = ("" & item("MNDPA_OS")).ToString.Trim
                obeTarifaOS.TARIFA_PAGO_OS = item("ILSFTR_OS")

                obeTarifaOS.TC_COBRO = item("TC_COBRAR")
                obeTarifaOS.TC_PAGO = item("TC_PAGAR")

                obeResultadoOP = New beResultadoOP
                obeResultadoOP = CalcularLiquidacionFlete(dtListaCodFletes, dtServicios, Operacion, SIN_CARGA_GR, GuiaTransp, obeTarifaOS)

                item("MNDCO") = obeResultadoOP.MONEDA_COBRO
                item("IMPCO") = obeResultadoOP.TARIFA_COBRO
                item("IMPCO_SOLES") = obeResultadoOP.TOT_COBRO_S
                item("CO_SOLO_FLETE_SOL") = obeResultadoOP.TOT_COBRO_S_FLETE
                item("CO_OT_FLETE_SOL") = obeResultadoOP.TOT_COBRO_S_OTROS

                item("MNDPA") = obeResultadoOP.MONEDA_PAGO
                item("IMPPA") = obeResultadoOP.TARIFA_PAGO
                item("IMPPA_SOLES") = obeResultadoOP.TOT_PAGO_S
                item("PA_SOLO_FLETE_SOL") = obeResultadoOP.TOT_PAGO_S_FLETE
                item("PA_OT_FLETE_SOL") = obeResultadoOP.TOT_PAGO_S_OTROS

                item("IMPORTE_NETO") = item("IMPCO_SOLES") - (item("IMPPA_SOLES") + item("GASTOAVC") + item("CSTTCB") + item("CTUREA") + item("GASTOS"))
                If item("IMPCO_SOLES") <> 0 Then
                    item("MARGEN") = (item("IMPORTE_NETO") / item("IMPCO_SOLES")) * 100
                Else
                    item("MARGEN") = 100
                End If
                msg = "Fin  Cálculo costos Flete"

                msg = "Inicio  Seg. Admin"
                obeResultadoOP = New beResultadoOP
                obeResultadoOP = SegAdministrativoOperacion(dtSegAdmOP, Operacion)
                item("SESTTP_DESC") = obeResultadoOP.ESTADO_SEG_AD_OP
                item("FDSGDC") = HelpClass.CFecha_de_8_a_10(obeResultadoOP.FECHA_SEG_AD_OP)
                item("HDSGDC") = HelpClass.HoraNum_a_Hora_Default(obeResultadoOP.HORA_SEG_AD_OP)


                item("FDSGDC_ADM") = HelpClass.CFecha_de_8_a_10(obeResultadoOP.FECHA_SEG_ADMIN)
                item("HDSGDC_ADM") = HelpClass.HoraNum_a_Hora_Default(obeResultadoOP.HORA_SEG_ADMIN)
                item("URSPDC") = obeResultadoOP.RESPON_SEG_DOC.Trim

                item("FDSGDC_ADM_INI") = HelpClass.CFecha_de_8_a_10(obeResultadoOP.FECHA_SEG_ADMIN_INICIAL)


                item("FCNFCL_GT") = HelpClass.CFecha_de_8_a_10(obeResultadoOP.FECHA_RECEP_GT)
                item("HCNFCL_GT") = HelpClass.HoraNum_a_Hora_Default(obeResultadoOP.HORA_RECEP_GT)


                item("FDSGDC_OP") = HelpClass.CFecha_de_8_a_10(obeResultadoOP.FECHA_SEG_OP)
                item("HDSGDC_OP") = HelpClass.HoraNum_a_Hora_Default(obeResultadoOP.HORA_SEG_AD_OP)


                msg = "Fin  Seg. Admin"


            Next



            If ad_columna_pesoAlmacen = "X" Then
                Dim dtPesos As New DataTable
                Dim dtPesoResumen As New DataTable

                For Each itemjs As String In listjson
                    dtPesos = objDataAccessLayer.calcularPesoAlmxGuiaTransporte(itemjs)
                    If dtPesoResumen.Rows.Count = 0 Then
                        dtPesoResumen = dtPesos.Copy
                    Else
                        For Each item As DataRow In dtPesos.Rows
                            dtPesoResumen.ImportRow(item)
                        Next
                    End If
                Next

                Dim drbusq() As DataRow
                'Dim cantMathGR As Int64 = 0
                For Each item As DataRow In dtOperacion.Rows
                    drbusq = dtPesoResumen.Select("FILA='" & item("FILA") & "' AND CANT_GRALM>0")
                    'CANT_GRALM
                    If drbusq.Length > 0 Then                      
                        item("PESO_ALM") = drbusq(0)("PSOALMACEN")
                    Else
                        item("PESO_ALM") = DBNull.Value
                    End If
                Next
            End If

            odsResultado.Tables.Add(dtOperacion.Copy)



            Return odsResultado
        End Function



        'Public Function frptMovimientoOperaciones(ByVal ht As Hashtable) As DataSet

        '    Dim TOT_IMPCO As Decimal
        '    Dim TOT_IMPPA As Decimal
        '    Dim TOT_COSTO As Decimal
        '    Dim TOT_GASTOS As Decimal
        '    Dim TOT_GASTOAVC As Decimal
        '    Dim ModenaFlete_CO As Integer
        '    Dim ModenaFlete_PA As Integer

        '    Dim TOT_IMPTINT As Decimal = 0

        '    Dim dt As New DataTable
        '    Dim dtResult As New DataTable
        '    Dim ds As DataSet = objDataAccessLayer.frptMovimientoOperaciones(ht)
        '    dt = ds.Tables(0).Copy

        '    dt.Columns.Add("CO_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dt.Columns.Add("CO_OT_FLETE", Type.GetType("System.Decimal"))

        '    dt.Columns.Add("PA_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dt.Columns.Add("PA_OT_FLETE", Type.GetType("System.Decimal"))

        '    dt.Columns.Add("TI_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dt.Columns.Add("TI_OT_FLETE", Type.GetType("System.Decimal"))

        '    dtResult = ds.Tables(0).Clone

        '    dtResult.Columns.Add("CO_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dtResult.Columns.Add("CO_OT_FLETE", Type.GetType("System.Decimal"))

        '    dtResult.Columns.Add("PA_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dtResult.Columns.Add("PA_OT_FLETE", Type.GetType("System.Decimal"))

        '    dtResult.Columns.Add("TI_SOLO_FLETE", Type.GetType("System.Decimal"))
        '    dtResult.Columns.Add("TI_OT_FLETE", Type.GetType("System.Decimal"))


        '    Dim objNegocios As New ServicioMercaderia_BLL
        '    Dim objEntidad As New Hashtable
        '    objEntidad.Add("PSCCMPN", ht.Item("CCMPN"))
        '    objEntidad.Add("PSCDVSN", ht.Item("CDVSN"))
        '    Dim odtServiciosflete As New DataTable
        '    odtServiciosflete = objNegocios.ListaServicioFlete(objEntidad)







        '    Dim drResult As DataRow
        '    Dim drSelect As DataRow()
        '    'Ordenado Por Operacion Y  tipo de Servicio

        '    TOT_COSTO = 0
        '    TOT_GASTOS = 0
        '    TOT_GASTOAVC = 0

        '    Dim Monto_Cobrar As Decimal = 0
        '    Dim Monto_TarifaInterna As Decimal = 0
        '    Dim Monto_Pagar As Decimal = 0



        '    Dim Monto_Solo_Flete_CO As Decimal = 0
        '    Dim Monto_Otros_Flete_CO As Decimal = 0

        '    Dim Monto_Solo_Flete_PA As Decimal = 0
        '    Dim Monto_Otros_Flete_PA As Decimal = 0

        '    Dim Monto_Solo_Flete_TInterna As Decimal = 0
        '    Dim Monto_Otros_Flete_TInterna As Decimal = 0

        '    Dim monedaTarifaInterna As Decimal = 0

        '    For i As Integer = 0 To dt.Rows.Count - 1
        '        TOT_IMPCO = 0
        '        TOT_IMPPA = 0
        '        TOT_IMPTINT = 0

        '        ModenaFlete_CO = 0
        '        ModenaFlete_PA = 0
        '        monedaTarifaInterna = 0

        '        drSelect = dt.Select("NOPRCN = " + dt.Rows(i)("NOPRCN").ToString.Trim)

        '        'Inicio 02/10/2017

        '        Dim VAR_ID_MNDCO As Decimal = 0
        '        Dim VAR_MNDCO As String = ""

        '        Dim VAR_ID_MNDPA As Decimal = 0
        '        Dim VAR_MNDPA As String = ""

        '        Dim VAR_CMNDTI As Decimal = 0
        '        Dim VAR_MNDTI As String = ""

        '        For Each dr As DataRow In drSelect
        '            If VAR_ID_MNDCO = 0 And dr("ID_MNDCO") <> 0 Then
        '                VAR_ID_MNDCO = dr("ID_MNDCO")
        '                VAR_MNDCO = dr("MNDCO")
        '            End If
        '            If VAR_ID_MNDPA = 0 And dr("ID_MNDPA") <> 0 Then
        '                VAR_ID_MNDPA = dr("ID_MNDPA")
        '                VAR_MNDPA = dr("MNDPA")
        '            End If
        '            If VAR_CMNDTI = 0 And dr("CMNDTI") <> 0 Then
        '                VAR_CMNDTI = dr("CMNDTI")
        '                VAR_MNDTI = dr("MNDTI")
        '            End If
        '        Next

        '        If drSelect.Length > 0 Then
        '            If drSelect(0)("IMPCO") = 0 Then
        '                drSelect(0)("ID_MNDCO") = VAR_ID_MNDCO
        '                drSelect(0)("MNDCO") = VAR_MNDCO
        '            End If
        '            If drSelect(0)("IMPPA") = 0 Then
        '                drSelect(0)("ID_MNDPA") = VAR_ID_MNDPA
        '                drSelect(0)("MNDPA") = VAR_MNDPA
        '            End If
        '            If drSelect(0)("IMPTI") = 0 Then
        '                drSelect(0)("CMNDTI") = VAR_CMNDTI
        '                drSelect(0)("MNDTI") = VAR_MNDTI
        '            End If
        '        End If

        '        ' Fin Nuevo



        '        Monto_Solo_Flete_CO = 0
        '        Monto_Otros_Flete_CO = 0
        '        Monto_Solo_Flete_PA = 0
        '        Monto_Otros_Flete_PA = 0

        '        Monto_Solo_Flete_TInterna = 0
        '        Monto_Otros_Flete_TInterna = 0

        '        For Each dr As DataRow In drSelect
        '            'Verifica el Tipo de servicio :flete
        '            Monto_Cobrar = 0
        '            Monto_Pagar = 0
        '            Monto_TarifaInterna = 0

        '            If EsFleteServicio(odtServiciosflete, Val("" & dr("CSRVC"))) Then
        '                'If dr("CSRVC").ToString.Trim.Equals("1") Then

        '                ModenaFlete_CO = dr("ID_MNDCO")
        '                ModenaFlete_PA = dr("ID_MNDPA")

        '                monedaTarifaInterna = dr("CMNDTI")

        '                Monto_Cobrar = Math.Round(dr("IMPCO"), 2)
        '                Monto_Pagar = Math.Round(dr("IMPPA"), 2)

        '                Monto_TarifaInterna = Math.Round(dr("IMPTI"), 2)

        '                TOT_IMPCO += Monto_Cobrar
        '                TOT_IMPPA += Monto_Pagar

        '                TOT_IMPTINT += Monto_TarifaInterna


        '                Monto_Solo_Flete_CO = Monto_Solo_Flete_CO + Monto_Cobrar
        '                Monto_Solo_Flete_PA = Monto_Solo_Flete_PA + Monto_Pagar
        '                Monto_Solo_Flete_TInterna = Monto_Solo_Flete_TInterna + Monto_TarifaInterna

        '            Else
        '                If ModenaFlete_CO = 0 Then
        '                    ModenaFlete_CO = dr("ID_MNDCO")
        '                End If
        '                If ModenaFlete_PA = 0 Then
        '                    ModenaFlete_PA = dr("ID_MNDPA")
        '                End If
        '                If monedaTarifaInterna = 0 Then
        '                    monedaTarifaInterna = dr("CMNDTI")
        '                End If

        '                If ModenaFlete_CO = 1 Then
        '                    'SOLES
        '                    If dr("ID_MNDCO") = 1 Then
        '                        Monto_Cobrar = Math.Round(dr("IMPCO"), 2)

        '                        TOT_IMPCO += Monto_Cobrar
        '                    Else


        '                        Monto_Cobrar = Math.Round(dr("IMPCO") * dr("TC_COBRAR"), 2)
        '                        TOT_IMPCO += Monto_Cobrar
        '                    End If
        '                Else  'Dolares

        '                    If dr("ID_MNDCO") = 1 Then
        '                        If dr("TC_COBRAR") = 0D Then
        '                            Monto_Cobrar = 0
        '                            TOT_IMPCO += Monto_Cobrar
        '                        Else
        '                            Monto_Cobrar = Math.Round(dr("IMPCO") / dr("TC_COBRAR"), 2)

        '                            TOT_IMPCO += Monto_Cobrar
        '                        End If

        '                    Else

        '                        Monto_Cobrar = Math.Round(dr("IMPCO"), 2)
        '                        TOT_IMPCO += Monto_Cobrar
        '                    End If
        '                End If


        '                If ModenaFlete_PA = 1 Then
        '                    'SOLES
        '                    If dr("ID_MNDPA") = 1 Then

        '                        Monto_Pagar = Math.Round(dr("IMPPA"), 2)
        '                        TOT_IMPPA += Monto_Pagar

        '                    Else
        '                        Monto_Pagar = Math.Round(dr("IMPPA") * dr("TC_PAGAR"), 2)

        '                        TOT_IMPPA += Monto_Pagar
        '                    End If
        '                Else  'Dolares

        '                    If dr("ID_MNDPA") = 1 Then
        '                        Monto_Pagar = Math.Round(dr("IMPPA") / dr("TC_PAGAR"), 2)

        '                        TOT_IMPPA += Monto_Pagar
        '                    Else
        '                        'TOT_IMPPA += Math.Round(dr("IMPPA"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")), 2)
        '                        Monto_Pagar = Math.Round(dr("IMPPA"), 2)
        '                        TOT_IMPPA += Monto_Pagar
        '                    End If
        '                End If

        '                If monedaTarifaInterna = 1 Then
        '                    'SOLES
        '                    If dr("CMNDTI") = 1 Then
        '                        Monto_TarifaInterna = Math.Round(dr("IMPTI"), 2)
        '                        TOT_IMPTINT += Monto_TarifaInterna
        '                    Else
        '                        Monto_TarifaInterna = Math.Round(dr("IMPTI") * dr("TC_TARIFAINT"), 2)
        '                        TOT_IMPTINT += Monto_TarifaInterna
        '                    End If
        '                Else  'Dolares

        '                    If dr("CMNDTI") = 1 Then
        '                        If dr("TC_TARIFAINT") = 0D Then
        '                            Monto_TarifaInterna = 0
        '                            TOT_IMPTINT += Monto_TarifaInterna
        '                        Else
        '                            Monto_TarifaInterna = Math.Round(dr("IMPTI") / dr("TC_TARIFAINT"), 2)
        '                            TOT_IMPTINT += Monto_TarifaInterna
        '                        End If

        '                    Else

        '                        Monto_TarifaInterna = Math.Round(dr("IMPTI"), 2)
        '                        TOT_IMPTINT += Monto_TarifaInterna
        '                    End If
        '                End If

        '                If EsFleteServicio(odtServiciosflete, Val("" & dr("CSRVC"))) Then
        '                    Monto_Solo_Flete_CO = Monto_Solo_Flete_CO + Monto_Cobrar
        '                    Monto_Solo_Flete_PA = Monto_Solo_Flete_PA + Monto_Pagar
        '                    Monto_Solo_Flete_TInterna = Monto_Solo_Flete_TInterna + Monto_TarifaInterna
        '                Else
        '                    Monto_Otros_Flete_CO = Monto_Otros_Flete_CO + Monto_Cobrar
        '                    Monto_Otros_Flete_PA = Monto_Otros_Flete_PA + Monto_Pagar
        '                    Monto_Otros_Flete_TInterna = Monto_Otros_Flete_TInterna + Monto_TarifaInterna
        '                End If

        '            End If


        '        Next
        '        If drSelect.Length > 0 Then
        '            TOT_COSTO = Math.Round(drSelect(0)("COSTO"), 2)
        '            TOT_GASTOS = Math.Round(drSelect(0)("GASTOS"), 2)
        '            TOT_GASTOAVC = Math.Round(drSelect(0)("GASTOAVC"), 2)

        '            drResult = dtResult.NewRow()
        '            For Each dc As DataColumn In dt.Columns
        '                Select Case dc.ColumnName
        '                    Case "IMPCO"
        '                        drResult("IMPCO") = TOT_IMPCO
        '                    Case "IMPPA"
        '                        drResult("IMPPA") = TOT_IMPPA
        '                    Case "COSTO"
        '                        drResult("COSTO") = TOT_COSTO
        '                    Case "GASTOS"
        '                        drResult("GASTOS") = TOT_GASTOS
        '                    Case "GASTOAVC"
        '                        drResult("GASTOAVC") = TOT_GASTOAVC
        '                        'ADICIONALES
        '                    Case "CO_SOLO_FLETE"
        '                        drResult("CO_SOLO_FLETE") = Monto_Solo_Flete_CO
        '                    Case "CO_OT_FLETE"
        '                        drResult("CO_OT_FLETE") = Monto_Otros_Flete_CO
        '                    Case "PA_SOLO_FLETE"
        '                        drResult("PA_SOLO_FLETE") = Monto_Solo_Flete_PA
        '                    Case "PA_OT_FLETE"
        '                        drResult("PA_OT_FLETE") = Monto_Otros_Flete_PA
        '                    Case "IMPTI"
        '                        drResult("IMPTI") = TOT_IMPTINT
        '                    Case "TI_SOLO_FLETE"
        '                        drResult("TI_SOLO_FLETE") = Monto_Solo_Flete_TInterna
        '                    Case "TI_OT_FLETE"
        '                        drResult("TI_OT_FLETE") = Monto_Otros_Flete_TInterna

        '                    Case Else
        '                        drResult(dc.ColumnName) = dt.Rows(i)(dc.ColumnName)
        '                End Select
        '            Next
        '            dtResult.Rows.Add(drResult)
        '            i = i + drSelect.Length - 1
        '        End If
        '    Next
        '    ds.Tables.RemoveAt(0)
        '    'dtResult.TableName = "dtmovOperaciones"
        '    Dim dsResult As New DataSet
        '    dsResult.Tables.Add(dtResult.Copy)
        '    For Each dtt As DataTable In ds.Tables()
        '        dsResult.Tables.Add(dtt.Copy)
        '    Next

        '    Return dsResult
        'End Function


        Public Function ReporteOperacionesPorGuiaTR(ByVal ht As Hashtable) As DataSet
            Return objDataAccessLayer.ReporteOperacionesPorGuiaTR(ht)
        End Function

        Public Function Lista_Region_Venta(ByVal strCCMPN As String) As DataTable
            Dim objTabla As DataTable = objDataAccessLayer.Lista_Region_Venta(strCCMPN)
            Dim objDataRow As DataRow
            objDataRow = objTabla.NewRow
            objDataRow.Item(0) = 0
            objDataRow.Item(1) = "TODOS"
            objTabla.Rows.InsertAt(objDataRow, 0)
            Return objTabla
        End Function

        Public Function ReporteOperacionesPorOrdeDeCompra(ByVal ht As Hashtable) As DataSet
            Return objDataAccessLayer.ReporteOperacionesPorOrdeDeCompra(ht)
        End Function

        Public Function Reporte_Facturacion_Operaciones(ByVal objColeccion As List(Of String)) As DataSet
            Return objDataAccessLayer.Reporte_Facturacion_Operaciones(objColeccion)
        End Function

        Public Function Reporte_Consistencia_Operaciones(ByVal objColeccion As List(Of String)) As DataTable
            Return objDataAccessLayer.Reporte_Consistencia_Operaciones(objColeccion)
        End Function

        'Public Function Reporte_Guia_Transportista_Facturada(ByVal ht As Hashtable) As DataSet
        '    Dim objDs As New DataSet
        '    Dim dtGuia_Transportista_Facturada As DataTable
        '    Dim dtGuia_Transportista_Anexo_3 As DataTable
        '    Dim dtGuia_Transportista_Anexo_31 As DataTable
        '    Dim dtVales_x_Transportista_Facturada As DataTable
        '    Dim dtVales_x_Transportista_Asignada As DataTable
        '    Dim dtNotas_de_Credito_y_Debito As DataTable

        '    dtGuia_Transportista_Facturada = New DataTable
        '    dtGuia_Transportista_Facturada = objDataAccessLayer.Reporte_Guia_Transportista_Facturada(ht)
        '    dtGuia_Transportista_Facturada.TableName = "Guia_Transportista_Facturada"

        '    dtGuia_Transportista_Anexo_3 = New DataTable
        '    dtGuia_Transportista_Anexo_3 = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_3(ht)
        '    dtGuia_Transportista_Anexo_3.TableName = "dtGuia_Transportista_Anexo_3"

        '    dtGuia_Transportista_Anexo_31 = New DataTable
        '    dtGuia_Transportista_Anexo_31 = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_31(ht)
        '    dtGuia_Transportista_Anexo_31.TableName = "dtGuia_Transportista_Anexo_31"

        '    dtVales_x_Transportista_Facturada = New DataTable
        '    dtVales_x_Transportista_Facturada = fnEstructuraTablaVales(objDataAccessLayer.Reporte_Vales_x_Transportista_Facturada(ht))
        '    dtVales_x_Transportista_Facturada.TableName = "Vales_x_Transportista_Facturada"

        '    dtVales_x_Transportista_Asignada = New DataTable
        '    dtVales_x_Transportista_Asignada = fnEstructuraTablaVales(objDataAccessLayer.Reporte_Vales_x_Transportista_Asignada(ht))
        '    dtVales_x_Transportista_Asignada.TableName = "Vales_x_Transportista_Asignada"

        '    fnLimpiarInformacionDuplicadaPorColumnas(dtVales_x_Transportista_Facturada)

        '    dtNotas_de_Credito_y_Debito = New DataTable
        '    dtNotas_de_Credito_y_Debito = objDataAccessLayer.Reporte_Notas_de_Credito_y_Debito(ht)
        '    dtNotas_de_Credito_y_Debito.TableName = "Notas_de_Credito_y_Debito"

        '    objDs.Tables.Add(dtGuia_Transportista_Facturada)
        '    objDs.Tables.Add(dtGuia_Transportista_Anexo_3)
        '    objDs.Tables.Add(dtGuia_Transportista_Anexo_31)
        '    objDs.Tables.Add(dtVales_x_Transportista_Facturada)
        '    objDs.Tables.Add(dtVales_x_Transportista_Asignada)
        '    objDs.Tables.Add(dtNotas_de_Credito_y_Debito)

        '    'objDs = objDataAccessLayer.Reporte_Guia_Transportista(ht)
        '    Return objDs
        'End Function

        Public Function Reporte_Guia_Transportista_Facturada(ByVal ht As Hashtable) As DataSet
            Dim objDs As New DataSet
            Dim dtGuia_Transportista_Facturada As DataTable
            Dim dtGuia_Transportista_Facturada_Distribucion As DataTable
            Dim dtGuia_Transportista_Anexo_3 As DataTable
            Dim dtGuia_Transportista_Anexo_3_Distribucion As DataTable
            Dim dtGuia_Transportista_Anexo_31 As DataTable
            Dim dtGuia_Transportista_Anexo_31_Distribucion As DataTable
            Dim dtVales_x_Transportista_Facturada As DataTable
            Dim dtVales_x_Transportista_Asignada As DataTable
            Dim dtNotas_de_Credito_y_Debito As DataTable

            dtGuia_Transportista_Facturada = New DataTable
            dtGuia_Transportista_Facturada_Distribucion = New DataTable
            dtGuia_Transportista_Facturada = objDataAccessLayer.Reporte_Guia_Transportista_Facturada(ht)
            ' Si es distribución
            If ht.Item("CDVSN") = "B" Or ht.Item("CDVSN") = "H" Then
                dtGuia_Transportista_Facturada_Distribucion = objDataAccessLayer.Reporte_Guia_Transportista_Facturada_Distribucion(ht)
                dtGuia_Transportista_Facturada.Merge(dtGuia_Transportista_Facturada_Distribucion)
            End If
            dtGuia_Transportista_Facturada.TableName = "Guia_Transportista_Facturada"


            dtGuia_Transportista_Anexo_3 = New DataTable
            dtGuia_Transportista_Anexo_3_Distribucion = New DataTable
            dtGuia_Transportista_Anexo_3 = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_3(ht)
            ' Si es distribución
            If ht.Item("CDVSN") = "B" Or ht.Item("CDVSN") = "H" Then
                dtGuia_Transportista_Anexo_3_Distribucion = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_3_Distribucion(ht)
                dtGuia_Transportista_Anexo_3.Merge(dtGuia_Transportista_Anexo_3_Distribucion)
            End If
            dtGuia_Transportista_Anexo_3.TableName = "dtGuia_Transportista_Anexo_3"


            dtGuia_Transportista_Anexo_31 = New DataTable
            dtGuia_Transportista_Anexo_31_Distribucion = New DataTable
            dtGuia_Transportista_Anexo_31 = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_31(ht)
            ' Si es distribución
            If ht.Item("CDVSN") = "B" Or ht.Item("CDVSN") = "H" Then
                dtGuia_Transportista_Anexo_31_Distribucion = objDataAccessLayer.Reporte_Guia_Transportista_Anexo_31_Distribucion(ht)
                dtGuia_Transportista_Anexo_31.Merge(dtGuia_Transportista_Anexo_31_Distribucion)
            End If
            dtGuia_Transportista_Anexo_31.TableName = "dtGuia_Transportista_Anexo_31"


            dtVales_x_Transportista_Facturada = New DataTable
            dtVales_x_Transportista_Facturada = fnEstructuraTablaVales(objDataAccessLayer.Reporte_Vales_x_Transportista_Facturada(ht))
            dtVales_x_Transportista_Facturada.TableName = "Vales_x_Transportista_Facturada"

            dtVales_x_Transportista_Asignada = New DataTable
            dtVales_x_Transportista_Asignada = fnEstructuraTablaVales(objDataAccessLayer.Reporte_Vales_x_Transportista_Asignada(ht))
            dtVales_x_Transportista_Asignada.TableName = "Vales_x_Transportista_Asignada"

            fnLimpiarInformacionDuplicadaPorColumnas(dtVales_x_Transportista_Facturada)

            dtNotas_de_Credito_y_Debito = New DataTable
            dtNotas_de_Credito_y_Debito = objDataAccessLayer.Reporte_Notas_de_Credito_y_Debito(ht)
            dtNotas_de_Credito_y_Debito.TableName = "Notas_de_Credito_y_Debito"

            objDs.Tables.Add(dtGuia_Transportista_Facturada)
            objDs.Tables.Add(dtGuia_Transportista_Anexo_3)
            objDs.Tables.Add(dtGuia_Transportista_Anexo_31)
            objDs.Tables.Add(dtVales_x_Transportista_Facturada)
            objDs.Tables.Add(dtVales_x_Transportista_Asignada)
            objDs.Tables.Add(dtNotas_de_Credito_y_Debito)

            'objDs = objDataAccessLayer.Reporte_Guia_Transportista(ht)
            Return objDs
        End Function

        'Private Function fnEstructuraTablaVales(ByVal dtVales As DataTable) As DataTable

        '    Dim dt As New DataTable
        '    dt.Columns.Add("FECHA_VALE", System.Type.GetType("System.String"))
        '    dt.Columns.Add("VALE_GRIFO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("PLACA", System.Type.GetType("System.String"))
        '    dt.Columns.Add("CBRCNT", System.Type.GetType("System.String"))
        '    dt.Columns.Add("CONDUCTOR", System.Type.GetType("System.String"))
        '    dt.Columns.Add("RUC_TRANPORTISTA", System.Type.GetType("System.String"))
        '    dt.Columns.Add("TRANSPORTISTA", System.Type.GetType("System.String"))
        '    dt.Columns.Add("PROPIO_TERCERO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("CENTRO_COSTO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("CANTIDAD_GALONES", System.Type.GetType("System.String"))
        '    dt.Columns.Add("COSTO_GALON", System.Type.GetType("System.String"))
        '    dt.Columns.Add("TOTAL", System.Type.GetType("System.String"))
        '    dt.Columns.Add("NRO_FACTURA_PRO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("FEC_FACTURA_PRO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("ORDEN", System.Type.GetType("System.String"))
        '    dt.Columns.Add("RUC_PROVEEDOR", System.Type.GetType("System.String"))
        '    dt.Columns.Add("GRIFO", System.Type.GetType("System.String"))
        '    dt.Columns.Add("OPERACION", System.Type.GetType("System.String"))
        '    dt.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
        '    dt.Columns.Add("FEC_FACTURA_CLI", System.Type.GetType("System.String"))
        '    dt.Columns.Add("NRO_FACTURA_CLI", System.Type.GetType("System.String"))

        '    For Each row As DataRow In dtVales.Rows
        '        Dim dr As DataRow = dt.NewRow
        '        dr("FECHA_VALE") = row.Item(0)
        '        dr("VALE_GRIFO") = row.Item(1)
        '        dr("PLACA") = row.Item(2)
        '        dr("CBRCNT") = row.Item(3)
        '        dr("CONDUCTOR") = row.Item(4)
        '        dr("RUC_TRANPORTISTA") = row.Item(5)
        '        dr("TRANSPORTISTA") = row.Item(6)
        '        dr("PROPIO_TERCERO") = row.Item(7)
        '        dr("CENTRO_COSTO") = row.Item(8)
        '        dr("CANTIDAD_GALONES") = row.Item(9)
        '        dr("COSTO_GALON") = row.Item(10)
        '        dr("TOTAL") = row.Item(11)
        '        dr("NRO_FACTURA_PRO") = row.Item(12)
        '        dr("FEC_FACTURA_PRO") = row.Item(13)
        '        dr("ORDEN") = row.Item(14)
        '        dr("RUC_PROVEEDOR") = row.Item(15)
        '        dr("GRIFO") = row.Item(16)
        '        dr("CLIENTE") = row.Item(17)
        '        dr("OPERACION") = row.Item(18)
        '        dr("FEC_FACTURA_CLI") = row.Item(19)
        '        dr("NRO_FACTURA_CLI") = row.Item(20)

        '        dt.Rows.Add(dr)
        '    Next
        '    Return dt
        'End Function

        Private Sub fnLimpiarInformacionDuplicadaPorColumnas(ByRef dt As DataTable)
            Dim sNroVale As String = String.Empty
            Dim sValor As String = String.Empty
            For Each row As DataRow In dt.Rows
                sValor = row.Item(1).ToString
                If sNroVale = sValor Then
                    row.Item(0) = ""
                    row.Item(1) = ""
                    row.Item(2) = ""
                    row.Item(3) = ""
                    row.Item(4) = ""
                    row.Item(5) = ""
                    row.Item(6) = ""
                    row.Item(7) = ""
                    row.Item(8) = ""
                    row.Item(9) = ""
                    row.Item(10) = ""
                    row.Item(11) = ""
                    row.Item(12) = ""
                    row.Item(13) = ""
                    row.Item(14) = ""
                    row.Item(15) = ""
                    row.Item(16) = ""
                Else
                    sNroVale = row.Item(1)
                End If
            Next
        End Sub

        Private Function fnEstructuraTablaVales(ByVal dtVales As DataTable) As DataTable

            Dim dt As New DataTable
            dt.Columns.Add("FECHA_VALE", System.Type.GetType("System.String"))
            dt.Columns.Add("VALE_GRIFO", System.Type.GetType("System.String"))
            dt.Columns.Add("PLACA", System.Type.GetType("System.String"))
            dt.Columns.Add("CBRCNT", System.Type.GetType("System.String"))
            dt.Columns.Add("CONDUCTOR", System.Type.GetType("System.String"))
            dt.Columns.Add("RUC_TRANPORTISTA", System.Type.GetType("System.String"))
            dt.Columns.Add("TRANSPORTISTA", System.Type.GetType("System.String"))
            dt.Columns.Add("PROPIO_TERCERO", System.Type.GetType("System.String"))
            dt.Columns.Add("CENTRO_COSTO", System.Type.GetType("System.String"))
            dt.Columns.Add("CANTIDAD_GALONES", System.Type.GetType("System.String"))
            dt.Columns.Add("COSTO_GALON", System.Type.GetType("System.String"))
            dt.Columns.Add("TOTAL", System.Type.GetType("System.String"))
            dt.Columns.Add("NRO_FACTURA_PRO", System.Type.GetType("System.String"))
            dt.Columns.Add("FEC_FACTURA_PRO", System.Type.GetType("System.String"))
            dt.Columns.Add("ORDEN", System.Type.GetType("System.String"))
            dt.Columns.Add("RUC_PROVEEDOR", System.Type.GetType("System.String"))
            dt.Columns.Add("NOM_PROVEEDOR", System.Type.GetType("System.String"))
            dt.Columns.Add("ESTACION", System.Type.GetType("System.String"))
            dt.Columns.Add("OPERACION", System.Type.GetType("System.String"))
            dt.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
            dt.Columns.Add("FEC_FACTURA_CLI", System.Type.GetType("System.String"))
            dt.Columns.Add("NRO_FACTURA_CLI", System.Type.GetType("System.String"))

            For Each row As DataRow In dtVales.Rows
                Dim dr As DataRow = dt.NewRow
                dr("FECHA_VALE") = row.Item(0)
                dr("VALE_GRIFO") = row.Item(1)
                dr("PLACA") = row.Item(2)
                dr("CBRCNT") = row.Item(3)
                dr("CONDUCTOR") = row.Item(4)
                dr("RUC_TRANPORTISTA") = row.Item(5)
                dr("TRANSPORTISTA") = row.Item(6)
                dr("PROPIO_TERCERO") = row.Item(7)
                dr("CENTRO_COSTO") = row.Item(8)
                dr("CANTIDAD_GALONES") = row.Item(9)
                dr("COSTO_GALON") = row.Item(10)
                dr("TOTAL") = row.Item(11)
                dr("NRO_FACTURA_PRO") = row.Item(12)
                dr("FEC_FACTURA_PRO") = row.Item(13)
                dr("ORDEN") = row.Item(14)
                dr("RUC_PROVEEDOR") = row.Item(15)
                dr("NOM_PROVEEDOR") = row.Item(16)
                dr("ESTACION") = row.Item(17)
                dr("CLIENTE") = row.Item(18)
                dr("OPERACION") = row.Item(19)
                dr("FEC_FACTURA_CLI") = row.Item(20)
                dr("NRO_FACTURA_CLI") = row.Item(21)

                dt.Rows.Add(dr)
            Next
            Return dt
        End Function


        Public Function Lista_Operaciones_Seguimiento_Administrativo(ByVal objColeccion As Hashtable) As DataTable
            Return objDataAccessLayer.Lista_Operaciones_Seguimiento_Administrativo(objColeccion)
        End Function

        Public Function Lista_CorrelativoControl(ByVal strcadena As String) As DataTable
            Return objDataAccessLayer.Lista_CorrelativoControl(strcadena)
        End Function

        Public Function Lista_SeguimientoPorOperacion(ByVal nOperacion As Decimal) As DataTable
            Return objDataAccessLayer.Lista_SeguimientoPorOperacion(nOperacion)
        End Function
        Public Function Reporte_Refacturacion_X_Operaciones_NC(ByVal ht As Hashtable) As DataTable
            Dim dsreporte As DataSet
            Dim dtreporte As DataTable
            Dim dt As DataTable
            Dim dr() As DataRow
            Dim Sql As String = ""
            dsreporte = objDataAccessLayer.Reporte_Refacturacion_X_Operaciones_NC(ht)
            dtreporte = dsreporte.Tables(0)
            dt = dsreporte.Tables(1)
            For indice As Integer = 0 To dtreporte.Rows.Count - 1
                Sql = "NOPRCN=" & dtreporte.Rows(indice).Item("NOPRCN") & _
                      " AND FECFRF>=" & dtreporte.Rows(indice).Item("FECFNC") & _
                      " AND CSRVC=" & dtreporte.Rows(indice).Item("CSRVC")
                dr = dt.Select(Sql, "FECFRF")
                If dr.Length > 0 Then
                    dtreporte.Rows(indice).Item("FECRFC") = dr(0).Item("FECFRF")
                    dtreporte.Rows(indice).Item("NDCMRF") = dr(0).Item("NDCMRF")
                    dtreporte.Rows(indice).Item("VVNTRF") = Format(IIf(dtreporte.Rows(indice).Item("CMNDA") = 1, dr(0).Item("VVNTRF_SOL"), dr(0).Item("VVNTRF_DOL")), "###,###,###,###.00")

                Else
                    dtreporte.Rows(indice).Item("FECRFC") = ""
                    dtreporte.Rows(indice).Item("NDCMRF") = ""
                    dtreporte.Rows(indice).Item("VVNTRF") = ""
                End If
            Next
            Return dtreporte
        End Function
        Public Function Reporte_Refacturacion_X_Operaciones_FC(ByVal ht As Hashtable) As DataTable
            Dim dsreporte As DataSet
            Dim dtreporte As New DataTable
            Dim dtNC As DataTable
            Dim dtFC As DataTable
            Dim dr() As DataRow
            Dim Sql As String = ""
            Dim drNew As DataRow
            dsreporte = objDataAccessLayer.Reporte_Refacturacion_X_Operaciones_FC(ht)
            dtFC = dsreporte.Tables(0)
            dtNC = dsreporte.Tables(1)
            CrearTablaReporte(dtreporte)
            For indice As Integer = 0 To dtNC.Rows.Count - 1
                Sql = "NOPRCN=" & dtNC.Rows(indice).Item("NOPRCN") & _
                      " AND FECFAC>=" & dtNC.Rows(indice).Item("FDCMOR") & _
                      " AND CSRVC=" & dtNC.Rows(indice).Item("CSRVC") & _
                      "AND CTPDCF=1 AND NDCMFC<>" & dtNC.Rows(indice).Item("NDCMOR")
                dr = dtFC.Select(Sql, "FECFAC")
                drNew = dtreporte.NewRow

                drNew("FECFNC") = dtNC.Rows(indice).Item("FECFNC")
                drNew("NDCMNC") = dtNC.Rows(indice).Item("NDCMNC")
                drNew("CCLNT") = dtNC.Rows(indice).Item("CCLNT")
                drNew("TCMPCL") = dtNC.Rows(indice).Item("TCMPCL")
                drNew("MNDANC") = dtNC.Rows(indice).Item("MNDANC")
                drNew("VVNTNC") = Format(Convert.ToDouble(dtNC.Rows(indice).Item("VVNTNC")), "###,###,###,###.00")
                drNew("ITCCTC") = dtNC.Rows(indice).Item("ITCCTC")
                drNew("NOPRCN") = dtNC.Rows(indice).Item("NOPRCN")
                drNew("FINCOP") = dtNC.Rows(indice).Item("FINCOP")
                drNew("NORINS") = dtNC.Rows(indice).Item("NORINS")
                drNew("FDCMOR") = dtNC.Rows(indice).Item("FDCMOR")
                drNew("NDCMOR") = dtNC.Rows(indice).Item("NDCMOR")
                drNew("VVNTFO") = Format(Convert.ToDouble(dtNC.Rows(indice).Item("VVNTFO")), "###,###,###,###.00")
                drNew("NDCPRF") = dtNC.Rows(indice).Item("NDCPRF")
                drNew("NPRLQD") = dtNC.Rows(indice).Item("NPRLQD")
                If dr.Length > 0 Then
                    drNew("FECRFC") = dr(0).Item("FECFAC")
                    drNew("NDCMRF") = dr(0).Item("NDCMFC")
                    drNew("VVNTRF") = Format(IIf(dtNC.Rows(indice).Item("CMNDA") = 1, dr(0).Item("VVNTFC_SOL"), dr(0).Item("VVNTFC_DOL")), "###,###,###,###.00")
                Else
                    drNew("FECRFC") = 0
                    drNew("NDCMRF") = 0
                    drNew("VVNTRF") = 0
                End If
                'drNew("FECFNC") = dr(0).Item("FECFNC")
                'drNew("NDCMNC") = dr(0).Item("NDCMNC")
                'drNew("CCLNT") = dr(0).Item("CCLNT")
                'drNew("TCMPCL") = dr(0).Item("TCMPCL")
                'drNew("MNDANC") = dr(0).Item("MNDANC")
                'drNew("VVNTNC") = Format(Convert.ToDouble(dr(0).Item("VVNTNC")), "###,###,###,###.00")
                'drNew("ITCCTC") = dr(0).Item("ITCCTC")
                'drNew("NOPRCN") = dr(0).Item("NOPRCN")
                'drNew("FINCOP") = dr(0).Item("FINCOP")
                'drNew("NORINS") = dr(0).Item("NORINS")
                'drNew("FDCMOR") = dr(0).Item("FDCMOR")
                'drNew("NDCMOR") = dr(0).Item("NDCMOR")
                'drNew("VVNTFO") = Format(Convert.ToDouble(dr(0).Item("VVNTFO")), "###,###,###,###.00")
                'drNew("NDCPRF") = dr(0).Item("NDCPRF")
                'drNew("NPRLQD") = dr(0).Item("NPRLQD")
                'drNew("FECRFC") = dtFC.Rows(indice).Item("FECFAC")
                'drNew("NDCMRF") = dtFC.Rows(indice).Item("NDCMFC")
                'drNew("VVNTRF") = Format(IIf(dr(0).Item("CMNDA") = 1, dtFC.Rows(indice).Item("VVNTFC_SOL"), dtFC.Rows(indice).Item("VVNTFC_DOL")), "###,###,###,###.00")
                dtreporte.Rows.Add(drNew)


            Next
            Return dtreporte
        End Function
        Private Sub CrearTablaReporte(ByVal dt As DataTable)
            dt.Columns.Add(New DataColumn("FECFNC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NDCMNC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            dt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
            dt.Columns.Add(New DataColumn("MNDANC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("VVNTNC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("ITCCTC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
            dt.Columns.Add(New DataColumn("FINCOP", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NORINS", GetType(System.String)))
            dt.Columns.Add(New DataColumn("FDCMOR", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NDCMOR", GetType(System.String)))
            dt.Columns.Add(New DataColumn("VVNTFO", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NDCPRF", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NPRLQD", GetType(System.String)))
            dt.Columns.Add(New DataColumn("FECRFC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("NDCMRF", GetType(System.String)))
            dt.Columns.Add(New DataColumn("VVNTRF", GetType(System.String)))
        End Sub


        Private Function FechaEntregaDoc(ByVal dtFechaEntrega As DataTable, ByVal CDSGDC As DocFechaEntrega, ByVal CCMPN As String, ByVal CTPODC As Int32, ByVal NDCCTC As Decimal) As String
            Dim FEntregaDoc As String = ""
            Dim drFechaDoc() As DataRow
            Dim Mayor As Int32 = 0
            drFechaDoc = dtFechaEntrega.Select("CDSGDC='" & CDSGDC & "' AND CTPODC='" & CTPODC & "' AND NDCCTC='" & NDCCTC & "'")
            If drFechaDoc.Length > 0 Then
                For Each Item As DataRow In drFechaDoc
                    If Item("NCRRSG") >= Mayor Then
                        FEntregaDoc = ("" & Item("FDSGDC")).ToString.Trim
                    End If
                Next
            End If
            Return FEntregaDoc
        End Function

        Private Function FechaSegOperacion(ByVal dtSegOperacion As DataTable, ByVal SESTTP As String, ByVal NOPRCN As Decimal) As String
            Dim FDocOperacion As String = ""
            Dim drDocOperacion() As DataRow
            Dim Mayor_NCRRSG As Int32 = 0
            drDocOperacion = dtSegOperacion.Select("NOPRCN='" & NOPRCN & "' AND SESTTP='" & SESTTP & "'")
            If drDocOperacion.Length > 0 Then
                For Each Item As DataRow In drDocOperacion
                    If Item("NCRRSG") >= Mayor_NCRRSG Then
                        FDocOperacion = ("" & Item("FDSGDC")).ToString.Trim
                    End If
                Next
            End If
            Return FDocOperacion
        End Function


        Enum DocFechaEntrega
            ADMINISTRATIVO = 1
            NEGOCIO = 2
            COBRANZA = 3
            CLIENTE = 4
            GENERADO = 5
        End Enum

        Public Function frptSeguimientoOperaciones(ByVal ht As Hashtable) As DataSet

            Dim TOT_IMPCO As Decimal
            Dim TOT_IMPPA As Decimal
            Dim TOT_COSTO As Decimal
            Dim TOT_GASTOS As Decimal
            Dim TOT_GASTOAVC As Decimal
            Dim ModenaFlete_CO As Integer
            Dim ModenaFlete_PA As Integer
            Dim dtFechaEntrega As New DataTable
            Dim dtSegOperacion As New DataTable

            Dim dt As New DataTable
            Dim dtResult As New DataTable
            Dim ds As DataSet = objDataAccessLayer.frptSeguimientoOperaciones(ht)
            ds.Tables(0).Columns.Add("FOPENTR_ADMIN")

            ds.Tables(0).Columns.Add("FDOCENTR_NEGOCIO")




            dt = ds.Tables(0).Copy
            dtFechaEntrega = ds.Tables(1).Copy
            dtSegOperacion = ds.Tables(2).Copy
            dtResult = ds.Tables(0).Clone
            Dim drResult As DataRow
            Dim drSelect As DataRow()
            'Ordenado Por Operacion Y  tipo de Servicio

            TOT_COSTO = 0
            TOT_GASTOS = 0
            TOT_GASTOAVC = 0

            For i As Integer = 0 To dt.Rows.Count - 1
                TOT_IMPCO = 0
                TOT_IMPPA = 0

                ModenaFlete_CO = 0
                ModenaFlete_PA = 0
                drSelect = dt.Select("NOPRCN = " + dt.Rows(i)("NOPRCN").ToString.Trim)
                For Each dr As DataRow In drSelect
                    'Verifica el Tipo de servicio :flete
                    If dr("CSRVC").ToString.Trim.Equals("1") Then
                        ModenaFlete_CO = dr("ID_MNDCO")
                        ModenaFlete_PA = dr("ID_MNDPA")
                        TOT_IMPCO += Math.Round(dr("IMPCO"), 2) 'Math.Round(Convert.ToDouble(dr("IMPCO")), 2)
                        TOT_IMPPA += Math.Round(dr("IMPPA"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")), 2)
                    Else
                        If ModenaFlete_CO = 0 Then
                            ModenaFlete_CO = dr("ID_MNDCO")
                        End If
                        If ModenaFlete_PA = 0 Then
                            ModenaFlete_PA = dr("ID_MNDPA")
                        End If

                        If ModenaFlete_CO = 1 Then
                            'SOLES
                            If dr("ID_MNDCO") = 1 Then
                                TOT_IMPCO += Math.Round(dr("IMPCO"), 2) 'Math.Round(Convert.ToDouble(dr("IMPCO")), 2)
                            Else
                                TOT_IMPCO += Math.Round(dr("IMPCO") / dr("TC_COBRAR"), 2) 'Math.Round(Convert.ToDouble(dr("IMPCO")) / Convert.ToDouble(dr("TC_COBRAR")), 2)
                            End If
                        Else  'Dolares

                            If dr("ID_MNDCO") = 1 Then
                                If dr("TC_COBRAR") = 0D Then
                                    TOT_IMPCO += 0
                                Else
                                    TOT_IMPCO += Math.Round(dr("IMPCO") / dr("TC_COBRAR"), 2)
                                End If
                                'IIf(Convert.ToDouble(dr("TC_COBRAR")) = 0D, 0, Convert.ToDecimal(dr("IMPCO")) / Convert.ToDecimal(dr("TC_COBRAR")))
                            Else
                                TOT_IMPCO += Math.Round(dr("IMPCO"), 2) 'Math.Round(Convert.ToDouble(dr("IMPCO")), 2)
                            End If
                        End If


                        If ModenaFlete_PA = 1 Then
                            'SOLES
                            If dr("ID_MNDPA") = 1 Then
                                TOT_IMPPA += Math.Round(dr("IMPPA"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")), 2)
                            Else
                                TOT_IMPPA += Math.Round(dr("IMPPA") * dr("TC_PAGAR"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")) * Convert.ToDouble(dr("TC_PAGAR")), 2)
                            End If
                        Else  'Dolares

                            If dr("ID_MNDPA") = 1 Then
                                TOT_IMPPA += Math.Round(dr("IMPPA") / dr("TC_PAGAR"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")) / Convert.ToDouble(dr("TC_PAGAR")), 2)
                            Else
                                TOT_IMPPA += Math.Round(dr("IMPPA"), 2) 'Math.Round(Convert.ToDouble(dr("IMPPA")), 2)
                            End If
                        End If
                    End If

                    'TOT_COSTO += Convert.ToDouble(dr("COSTO"))
                    'TOT_GASTOS += Convert.ToDouble(dr("GASTOS"))
                    'TOT_GASTOAVC += Convert.ToDouble(dr("GASTOAVC"))
                Next
                If drSelect.Length > 0 Then

                    TOT_COSTO = Math.Round(drSelect(0)("COSTO"), 2)  'Math.Round(Convert.ToDouble(drSelect(0)("COSTO")), 2)
                    TOT_GASTOS = Math.Round(drSelect(0)("GASTOS"), 2)  'Math.Round(Convert.ToDouble(drSelect(0)("GASTOS")), 2)
                    TOT_GASTOAVC = Math.Round(drSelect(0)("GASTOAVC"), 2) 'Math.Round(Convert.ToDouble(drSelect(0)("GASTOAVC")), 2)

                    drResult = dtResult.NewRow()
                    For Each dc As DataColumn In dt.Columns
                        Select Case dc.ColumnName
                            Case "IMPCO"
                                drResult("IMPCO") = TOT_IMPCO
                            Case "IMPPA"
                                drResult("IMPPA") = TOT_IMPPA
                            Case "COSTO"
                                drResult("COSTO") = TOT_COSTO
                            Case "GASTOS"
                                drResult("GASTOS") = TOT_GASTOS
                            Case "GASTOAVC"
                                drResult("GASTOAVC") = TOT_GASTOAVC
                            Case Else
                                drResult(dc.ColumnName) = dt.Rows(i)(dc.ColumnName)
                        End Select
                    Next

                    drResult("FOPENTR_ADMIN") = FechaSegOperacion(dtSegOperacion, "A", drResult("NOPRCN"))
                    drResult("FDOCENTR_NEGOCIO") = FechaEntregaDoc(dtFechaEntrega, DocFechaEntrega.NEGOCIO, "", drResult("CTPDCF"), IIf(drResult("NDCMFC") = "" OrElse drResult("NDCMFC") Is DBNull.Value, 0, drResult("NDCMFC")))


                    dtResult.Rows.Add(drResult)
                    i = i + drSelect.Length - 1
                End If
            Next
            ds.Tables.RemoveAt(0)
            'dtResult.TableName = "dtmovOperaciones"
            Dim dsResult As New DataSet
            dsResult.Tables.Add(dtResult.Copy)
            For Each dtt As DataTable In ds.Tables()
                dsResult.Tables.Add(dtt.Copy)
            Next

            Return dsResult
        End Function


    End Class
End Namespace