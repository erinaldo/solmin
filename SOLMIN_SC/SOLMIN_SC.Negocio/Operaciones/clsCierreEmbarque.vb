Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsCierreEmbarque
    Enum EstadoEmbarque
        Atencion
        Cerrado
    End Enum

    Private _ListaClienteReapertura As New List(Of String)
    Private _ListaClienteIntegracionEmbarqueABB As New List(Of String)
    Private _ListaClienteEnviarCostos As New List(Of String)
    Private _DebeEnviarCostos As Boolean = False
    Private _DebeEnviarDatosIntegracionEmbarqueABB As Boolean = False
    Sub New()
        _ListaClienteReapertura.Clear()
        _ListaClienteReapertura.Add("11232")

        _ListaClienteEnviarCostos.Clear()
        _ListaClienteEnviarCostos.Add("11232")

        _ListaClienteIntegracionEmbarqueABB.Add("11232")
    End Sub
    Public Function NoContieneACliente(ByVal CCLNT As String) As Boolean
        Return Not _ListaClienteReapertura.Contains(CCLNT)
    End Function

    Public Function DebeEnviarDatosIntegracionEmbarqueABB(ByVal CCLNT As String) As Boolean
        _DebeEnviarDatosIntegracionEmbarqueABB = _ListaClienteIntegracionEmbarqueABB.Contains(CCLNT)
        Return _DebeEnviarDatosIntegracionEmbarqueABB
    End Function

    Public Function DebeEnviarCostoACliente(ByVal CCLNT As String) As Boolean
        _DebeEnviarCostos = _ListaClienteEnviarCostos.Contains(CCLNT)
        Return _DebeEnviarCostos
    End Function
    Public Function Reaperturar_Embarque(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As Int32
        Dim oclsEmbarque As New Datos.clsEmbarque
        Dim reotorno As Int32 = 0
        reotorno = oclsEmbarque.Reaperturar_Embarque(PNCCLNT, PNNORSCI)
        Return reotorno
    End Function


    Public Function EnviarCostos(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal CULUSA As String) As String
        Dim msg As String = ""
        If (_DebeEnviarCostos = True) Then
            Try
                Dim oDocApertura As New clsDocApertura
                Dim oEmbarque As New clsEmbarque
                Dim oDtCostos As New DataTable
                Dim oDtCheckPoint As New DataTable
                Dim oDs As New DataSet
                Dim intValorUnitario As Decimal = 0
                ''Costos de la cabecera
                oDs = oDocApertura.Lista_Costos_Totales_Embarque_ABB(NORSCI)
                oDtCostos = oDs.Tables(0)
                oDtCheckPoint = oDs.Tables(1)
                'Dim obrOC As New OrdenCompra_BLL
                Dim strParam As New List(Of String)
                Dim obrclsExportarCostos As New Operaciones.clsExportarCostos
                Dim oHasCab As New Hashtable
                Dim oHasDet As New Hashtable
                Dim intCodCI As Integer

                Dim oDt As New DataTable
                ''Costos de los detalles
                oEmbarque.pCCLNT = CCLNT
                oEmbarque.pNORSCI = NORSCI
                oDt = oEmbarque.Lista_Detalle_OC_Embarque_ABB(oEmbarque.pCCLNT, oEmbarque.pNORSCI)



                With oHasCab
                    .Add("vc_IdCostoImportacion", NORSCI.ToString)
                    .Add("dt_FechaEntradaArticulos", "")
                    .Add("vc_ViaEntrega", "" & oDt.Rows(0).Item("TNMMDT") & "")
                    .Add("vc_Moneda", "PEN")
                    .Add("fl_CIF", (Buscar_Costo_Total_X_Embarque_ABB("CIF", oDtCostos)).ToString)
                    .Add("fl_FOB", (Buscar_Costo_Total_X_Embarque_ABB("FOB", oDtCostos)).ToString)
                    .Add("fl_Peso", "0")
                    .Add("fl_Flete", (Buscar_Costo_Total_X_Embarque_ABB("FLETE", oDtCostos)).ToString)
                    .Add("fl_Seguro", (Buscar_Costo_Total_X_Embarque_ABB("SEGURO", oDtCostos)).ToString)
                    .Add("fl_AdValorem", (Buscar_Costo_Total_X_Embarque_ABB("ADVALO", oDtCostos)).ToString)
                    .Add("fl_DescAlmacenaje", (Buscar_Costo_Total_X_Embarque_ABB("ALMLOC", oDtCostos) + Buscar_Costo_Total_X_Embarque_ABB("CARDES", oDtCostos)).ToString)
                    .Add("fl_Handling", (Buscar_Costo_Total_X_Embarque_ABB("HANDLI", oDtCostos)).ToString)
                    .Add("fl_OtrosGastosAd", (Buscar_Costo_Total_X_Embarque_ABB("OTSGAS", oDtCostos)).ToString)
                    .Add("fl_ComisionAgencia", (Buscar_Costo_Total_X_Embarque_ABB("ITTCAG", oDtCostos)).ToString)
                    .Add("fl_TarifaAgencia", "0") 'Tarifa agencias
                    .Add("fl_GastosOperativos", (Buscar_Costo_Total_X_Embarque_ABB("ITTGOA", oDtCostos)).ToString)
                    .Add("in_Cerrado", "1")
                    .Add("dt_FechaCerrado", Now.ToString)
                    .Add("vc_PurchaseOrder", ("" & oDt.Rows(0).Item("NORCML") & "").ToString.Trim)

                    .Add("dt_FechaEmbarque", oDtCheckPoint.Rows(0).Item("CHK_FAPREV").ToString)
                    .Add("dt_FechaLlegada", oDtCheckPoint.Rows(0).Item("CHK_FAPRAR").ToString)
                    .Add("dt_FechaNumeracion", oDtCheckPoint.Rows(0).Item("CHK_FECNUM").ToString)
                    .Add("dt_FechaPagoDerecho", oDtCheckPoint.Rows(0).Item("CHK_FECPGD").ToString)
                    .Add("dt_FechaLevante", oDtCheckPoint.Rows(0).Item("CHK_FECLEV").ToString)
                    .Add("dt_FechaEntregaAlmacen", oDtCheckPoint.Rows(0).Item("CHK_FECALM").ToString)
                    .Add("dt_FechaETD", oDtCheckPoint.Rows(0).Item("FAPREV").ToString)
                    .Add("dt_FechaETA", oDtCheckPoint.Rows(0).Item("FAPRAR").ToString)

                    .Add("vc_Usuario", CULUSA)
                End With
                intCodCI = obrclsExportarCostos.GuardarCostoImportacionCabecera(oHasCab)

                If intCodCI = -2 Then
                    msg = "La orden de compra no se encuentra en Integración ABB"
                    Return msg
                End If
                If intCodCI = -1 Then
                    msg = "Error comuníquese con el departamento de Sistemas"
                End If
                For intCont As Integer = 0 To oDt.Rows.Count - 1
                    oHasDet = New Hashtable
                    With oHasDet
                        intValorUnitario = ( _
                        Decimal.Parse(oDt.Rows(intCont).Item("ITTGOA")) + _
                        Decimal.Parse(oDt.Rows(intCont).Item("TOTADV")) + _
                        Decimal.Parse(oDt.Rows(intCont).Item("ITTCAG")) + _
                        Decimal.Parse(oDt.Rows(intCont).Item("TOTOGS")) + _
                        Decimal.Parse(oDt.Rows(intCont).Item("TOTCIF"))) / Decimal.Parse((oDt.Rows(intCont).Item("QRLCSC")))
                        'ITTCAG
                        .Add("in_IdCostoImportacion", intCodCI.ToString)
                        .Add("vc_PurchaseOrder", oDt.Rows(intCont).Item("NORCML").ToString.Trim)
                        .Add("vc_PurchaseOrderLine", oDt.Rows(intCont).Item("NRITEM").ToString.Trim)
                        .Add("vc_IdCostoImportacionLinea", intCont.ToString)
                        .Add("vc_NumeroFactura", oDt.Rows(intCont).Item("NFCTCM").ToString.Trim) 'lsvItems.Items(intCont).SubItems(9).Text.ToString)
                        .Add("vc_PartidaArancelaria", oDt.Rows(intCont).Item("CPTDAR").ToString.Trim) 'lsvItems.Items(intCont).SubItems(8).Text.ToString)
                        .Add("fl_CantidadItem", oDt.Rows(intCont).Item("QRLCSC").ToString.Trim)
                        .Add("fl_GastosOperativos", oDt.Rows(intCont).Item("ITTGOA").ToString.Trim)
                        .Add("fl_FOBUnitario", (oDt.Rows(intCont).Item("TOTFOB") / oDt.Rows(intCont).Item("QRLCSC")).ToString)
                        .Add("fl_FOBTotal", oDt.Rows(intCont).Item("TOTFOB").ToString) 'falta no se
                        .Add("fl_ValorUnitario", intValorUnitario.ToString)
                        .Add("fl_Handling", oDt.Rows(intCont).Item("HANDLI").ToString) 'falta
                        .Add("fl_Flete", oDt.Rows(intCont).Item("TOTFLT").ToString)
                        .Add("fl_Seguro", oDt.Rows(intCont).Item("TOTSEG").ToString)
                        .Add("fl_DescAlmacenaje", oDt.Rows(intCont).Item("DESALM").ToString) 'falta
                        .Add("fl_AdValorem", oDt.Rows(intCont).Item("TOTADV").ToString)
                        .Add("fl_ComisionAgencia", oDt.Rows(intCont).Item("ITTCAG").ToString)
                        .Add("fl_TarifaAgencia", "0") '  _TarifaAgencia                       
                        .Add("fl_OtrosGastosAd", oDt.Rows(intCont).Item("TOTOGS").ToString)
                        .Add("fl_CIF", oDt.Rows(intCont).Item("TOTCIF").ToString)
                        .Add("in_Cerrado", "1")
                        .Add("dt_FechaCerrado", Now.ToString)
                        .Add("vc_Usuario", CULUSA)
                    End With
                    Dim str As String = ""
                    str = obrclsExportarCostos.GuardarCostoImportacionDetalle(oHasDet)
                Next
            Catch
                msg = "Error comuníquese con el departamento de Sistemas"
            End Try
        End If
        Return msg
    End Function



    Public Function EnviarChangesEmbarque(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal, ByVal CULUSA As String) As String
        Dim msg As String = ""
        If (_DebeEnviarDatosIntegracionEmbarqueABB = True) Then
            Dim oDocApertura As New clsDocApertura
            Dim oEmbarque As New clsEmbarque
            Dim oDtCostos As New DataTable
            Dim oDtCheckPoint As New DataTable
            Dim oDs As New DataSet
            Dim intValorUnitario As Decimal = 0
            ''Costos de la cabecera
            oDs = oDocApertura.Lista_Costos_Totales_Embarque_ABB_Cambio_CheckPoint(NORSCI)
            oDtCostos = oDs.Tables(0)
            oDtCheckPoint = oDs.Tables(1)
            'Dim obrOC As New OrdenCompra_BLL
            Dim strParam As New List(Of String)
            Dim obrclsExportarCostos As New Operaciones.clsExportarCostos
            Dim oHasCab As New Hashtable
            Dim oHasDet As New Hashtable
            Dim intCodCI As Integer

            Dim oDt As New DataTable
            ''Costos de los detalles
            oEmbarque.pCCLNT = CCLNT
            oEmbarque.pNORSCI = NORSCI
            oDt = oEmbarque.Lista_Detalle_OC_Embarque_ABB_Cambio_CheckPoint(oEmbarque.pCCLNT, oEmbarque.pNORSCI)

            With oHasCab
                .Add("vc_IdEmbarque", NORSCI.ToString)
                .Add("dt_FechaEntradaArticulos", "")
                .Add("vc_Moneda", "PEN")
                .Add("vc_ViaEntrega", ("" & oDt.Rows(0).Item("TNMMDT")).ToString.Trim)
                .Add("fl_CIF", (Buscar_Costo_Total_X_Embarque_ABB("CIF", oDtCostos)).ToString)
                .Add("fl_FOB", (Buscar_Costo_Total_X_Embarque_ABB("FOB", oDtCostos)).ToString)
                .Add("fl_Peso", "0")
                .Add("fl_Flete", (Buscar_Costo_Total_X_Embarque_ABB("FLETE", oDtCostos)).ToString)
                .Add("fl_Seguro", (Buscar_Costo_Total_X_Embarque_ABB("SEGURO", oDtCostos)).ToString)
                .Add("fl_AdValorem", (Buscar_Costo_Total_X_Embarque_ABB("ADVALO", oDtCostos)).ToString)
                .Add("fl_DescAlmacenaje", (Buscar_Costo_Total_X_Embarque_ABB("ALMLOC", oDtCostos) + Buscar_Costo_Total_X_Embarque_ABB("CARDES", oDtCostos)).ToString)
                .Add("fl_Handling", (Buscar_Costo_Total_X_Embarque_ABB("HANDLI", oDtCostos)).ToString)
                .Add("fl_OtrosGastosAd", (Buscar_Costo_Total_X_Embarque_ABB("OTSGAS", oDtCostos)).ToString)
                .Add("fl_ComisionAgencia", (Buscar_Costo_Total_X_Embarque_ABB("ITTCAG", oDtCostos)).ToString)
                .Add("fl_TarifaAgencia", "0") 'Tarifa agencias
                .Add("fl_GastosOperativos", (Buscar_Costo_Total_X_Embarque_ABB("ITTGOA", oDtCostos)).ToString)
                .Add("in_Cerrado", "0")
                .Add("dt_FechaCerrado", Now.ToString)
                .Add("dt_FechaEmbarque", oDtCheckPoint.Rows(0).Item("CHK_FAPREV").ToString)
                .Add("dt_FechaLlegada", oDtCheckPoint.Rows(0).Item("CHK_FAPRAR").ToString)
                .Add("dt_FechaNumeracion", oDtCheckPoint.Rows(0).Item("CHK_FECNUM").ToString)
                .Add("dt_FechaPagoDerecho", oDtCheckPoint.Rows(0).Item("CHK_FECPGD").ToString)
                .Add("dt_FechaLevante", oDtCheckPoint.Rows(0).Item("CHK_FECLEV").ToString)
                .Add("dt_FechaEntregaAlmacen", oDtCheckPoint.Rows(0).Item("CHK_FECALM").ToString)
                .Add("dt_FechaETD", oDtCheckPoint.Rows(0).Item("FAPREV").ToString)
                .Add("dt_FechaETA", oDtCheckPoint.Rows(0).Item("FAPRAR").ToString)
                .Add("vc_MedioTransporte", ("" & oDt.Rows(0).Item("TNMMDT")).ToString.Trim)
                .Add("nu_OrdenServicio", oDt.Rows(0).Item("PNNMOS").ToString)
                .Add("vc_PaisOrigen", ("" & oDt.Rows(0).Item("TCMPPS")).ToString.Trim)
                .Add("vc_AgenteCarga", ("" & oDt.Rows(0).Item("TNMAGC")).ToString.Trim)
                .Add("vc_Canal", ("" & oDt.Rows(0).Item("TCANAL")).ToString.Trim)
                .Add("vc_DUA", ("" & oDt.Rows(0).Item("TNRODU")).ToString.Trim)
                .Add("vc_PurchaseOrder", ("" & oDt.Rows(0).Item("NORCML") & "").ToString.Trim)
                .Add("vc_Usuario", CULUSA)
            End With
            intCodCI = obrclsExportarCostos.GuardarIntegracionEmbarqueCab(oHasCab)
            If intCodCI = -2 Then
                msg = "La orden de compra no se encuentra en Integración ABB"
                Return msg
            End If
            If intCodCI = -1 Then
                msg = "Error comuníquese con el departamento de Sistemas"
                Return msg
            End If

            For intCont As Integer = 0 To oDt.Rows.Count - 1
                oHasDet = New Hashtable
                With oHasDet
                    intValorUnitario = ( _
                    Decimal.Parse(oDt.Rows(intCont).Item("ITTGOA")) + _
                    Decimal.Parse(oDt.Rows(intCont).Item("TOTADV")) + _
                    Decimal.Parse(oDt.Rows(intCont).Item("ITTCAG")) + _
                    Decimal.Parse(oDt.Rows(intCont).Item("TOTOGS")) + _
                    Decimal.Parse(oDt.Rows(intCont).Item("TOTCIF"))) / Decimal.Parse((oDt.Rows(intCont).Item("QRLCSC")))
                    .Add("in_IdEmbarque ", intCodCI.ToString)
                    .Add("vc_PurchaseOrder", oDt.Rows(intCont).Item("NORCML").ToString.Trim)
                    .Add("vc_PurchaseOrderLine", oDt.Rows(intCont).Item("NRITEM").ToString.Trim)
                    .Add("vc_IdCostoImportacionLinea", intCont.ToString)
                    .Add("vc_NumeroFactura", oDt.Rows(intCont).Item("NFCTCM").ToString.Trim) 'lsvItems.Items(intCont).SubItems(9).Text.ToString)
                    .Add("vc_PartidaArancelaria", oDt.Rows(intCont).Item("CPTDAR").ToString.Trim) 'lsvItems.Items(intCont).SubItems(8).Text.ToString)
                    .Add("fl_CantidadItem", oDt.Rows(intCont).Item("QRLCSC").ToString.Trim)
                    .Add("fl_GastosOperativos", oDt.Rows(intCont).Item("ITTGOA").ToString.Trim)
                    .Add("fl_FOBUnitario", (oDt.Rows(intCont).Item("TOTFOB") / oDt.Rows(intCont).Item("QRLCSC")).ToString)
                    .Add("fl_FOBTotal", oDt.Rows(intCont).Item("TOTFOB").ToString) 'falta no se
                    .Add("fl_ValorUnitario", intValorUnitario.ToString)
                    .Add("fl_Handling", oDt.Rows(intCont).Item("HANDLI").ToString) 'falta
                    .Add("fl_Flete", oDt.Rows(intCont).Item("TOTFLT").ToString)
                    .Add("fl_Seguro", oDt.Rows(intCont).Item("TOTSEG").ToString)
                    .Add("fl_DescAlmacenaje", oDt.Rows(intCont).Item("DESALM").ToString) 'falta
                    .Add("fl_AdValorem", oDt.Rows(intCont).Item("TOTADV").ToString)
                    .Add("fl_ComisionAgencia", oDt.Rows(intCont).Item("ITTCAG").ToString)
                    .Add("fl_TarifaAgencia", "0") '  _TarifaAgencia                       
                    .Add("fl_OtrosGastosAd", oDt.Rows(intCont).Item("TOTOGS").ToString)
                    .Add("fl_CIF", oDt.Rows(intCont).Item("TOTCIF").ToString)
                    .Add("in_Cerrado", "0")
                    .Add("dt_FechaCerrado", Now.ToString)
                    .Add("vc_Usuario", CULUSA)
                End With
                Dim str As String = ""
                str = obrclsExportarCostos.GuardarIntegracionEmbarqueDetalle(oHasDet)
            Next
        End If
        Return msg
    End Function



    Private Function Buscar_Costo_Total_X_Embarque_ABB(ByVal strgCodVariable As String, ByVal oDt As DataTable) As Double
        Dim intRow As Integer
        Dim pdblResultado As Double = 0.0
        Dim dr() As DataRow
        If strgCodVariable = "OTSGAS" Then
            dr = oDt.Select("CODVAR IN ('TASDES','SOBTAS','DERESP','ANTDUM','IMSECO','INTCOM')")
            If dr.Length > 0 Then
                For Fila As Integer = 0 To dr.Length - 1
                    pdblResultado = pdblResultado + dr(Fila)("COSABB")
                Next
                pdblResultado = Format(pdblResultado, "###,###,##0.00")
            End If           
        Else
            For intRow = 0 To oDt.Rows.Count - 1
                If oDt.Rows(intRow).Item("CODVAR").ToString = strgCodVariable Then
                    pdblResultado = Format(Double.Parse(oDt.Rows(intRow).Item("COSABB").ToString), "###,###,##0.00")
                    'Return pdblResultado
                    Exit For
                End If
            Next
        End If
        Return pdblResultado
    End Function
End Class
