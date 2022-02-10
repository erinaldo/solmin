Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Imports System.Text
Public Class clsDespachoNacional

    'Public Function Listar_Tipo_Tarifa() As DataTable
    '    Dim oTipoTarifa As New Datos.clsDespachoNacional
    '    Return oTipoTarifa.Listar_Tipo_Tarifa()
    'End Function

    Public Function Grabar_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Int32
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Grabar_Despacho_Nacional(obeDespachoNacional)
    End Function

    Public Function Listar_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional, ByVal PNFECINI As Decimal, ByVal PNFECFIN As Decimal) As List(Of beDespachoNacional)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Despacho_Nacional(obeDespachoNacional, PNFECINI, PNFECFIN)
    End Function

    Public Function Mant_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Boolean
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Mant_Despacho_Nacional(obeDespachoNacional)
    End Function

    Public Function Anular_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Boolean
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Anular_Despacho_Nacional(obeDespachoNacional)
    End Function
    Public Sub Anular_Tarifa_Local(ByVal obeDespachoNacional As beDespachoNacional)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Anular_Tarifa_Local(obeDespachoNacional)
    End Sub


    Public Function Listar_Costos_Despacho_Nacional() As List(Of beCostoTotalEmbarqueNacional)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Costos_Despacho_Nacional()
    End Function

    Public Function Listar_Costos_Despacho_Nacional_X_Embarque(ByVal PNNORSCI As Decimal, ByVal TIPO As String) As List(Of beCostoTotalEmbarqueNacional)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Costos_Despacho_Nacional_X_Embarque(PNNORSCI, TIPO)
    End Function

    Public Sub Guardar_Costos_Totales_Embarque(ByVal PSTIPO As String, ByVal obeCostoTotalEmbarque As beCostoTotalEmbarqueNacional)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Guardar_Costos_Totales_Embarque(PSTIPO, obeCostoTotalEmbarque)
    End Sub

    '' gaston
    Public Function Listar_Carga_Asignada_x_Embarque(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataSet
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Carga_Asignada_x_Embarque(PNNORSCI, PNCCLNT)
    End Function
    Public Function Listar_Dimension_Todos_x_Embarque(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Dimension_Todos_x_Embarque(PNNORSCI, PNCCLNT)
    End Function

    Public Sub Eliminar_Item_Carga_Asignada(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As String, ByVal PNNRPEMB As Decimal)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Eliminar_Item_Carga_Asignada(PNNORSCI, PNCCLNT, PSNORCML, PNNRITEM, PNNRPEMB)
    End Sub


   

    Public Function Registrar_Item_Carga_Manual(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga) As Decimal
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Registrar_Item_Carga_Manual(obeOrdenEmbarqueCarga)
    End Function

    Public Sub Actualizar_Item_Carga(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Actualizar_Item_Carga(obeOrdenEmbarqueCarga)
    End Sub
    Public Sub Actualizar_Datos_Item(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Actualizar_Datos_Item(obeOrdenEmbarqueCarga)
    End Sub


    Public Function Registrar_Dimension_Item_Carga(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga) As Boolean
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Registrar_Dimension_Item_Carga(obeOrdenEmbarqueCarga)
    End Function


    Public Sub Eliminar_Dimension_Item_Carga(ByVal ObeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Eliminar_Dimension_Item_Carga(ObeOrdenEmbarqueCarga)

    End Sub

    Public Function Enviar_Operacion_Facturacion_Despacho(ByVal pstrCompania As String, ByVal pstrDivision As String, ByVal pdblEmbarque As Double, ByVal pdblCli As Double, ByVal pdblFecSrv As Double, _
        ByVal pdblTarifa As Double, ByVal pstrTipoTarifa As String, ByVal pstrUnidadMedida As String, ByVal pdblValor As Double, ByVal PNCCLNFC As Double, ByVal CPLNDV As Decimal, ByVal QFACTOR As Decimal, ByVal CDIRSE As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Enviar_Operacion_Facturacion_Despacho(pstrCompania, pstrDivision, pdblEmbarque, pdblCli, pdblFecSrv, _
         pdblTarifa, pstrTipoTarifa, pstrUnidadMedida, pdblValor, PNCCLNFC, CPLNDV, QFACTOR, CDIRSE)

    End Function

    Public Function Lista_Guia_Salida_Zona_GR(ByVal CCLNT1 As Decimal, ByVal NUMDOC As Decimal, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CPLNDV As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Lista_Guia_Salida_Zona_GR(CCLNT1, NUMDOC, CCMPN, CDVSN, CPLNDV)
    End Function

    Public Function Listar_Unidades_Medida_Carga() As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Unidades_Medida_Carga()
    End Function
    Public Function Listar_Unidades_Medida_Carga_Item() As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Unidades_Medida_Carga_Item()
    End Function

    Public Function Listar_CheckPoint(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSCDVSN As String, ByVal PSCEMB As String) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_CheckPoint(PSCCMPN, PNCCLNT, PSCDVSN, PSCEMB)
    End Function

    Public Function Datos_X_Embarque_Despacho(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As beDespachoNacional
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Datos_X_Embarque_Despacho(PNNORSCI, PNCCLNT)
    End Function



    Public Function Listar_Embarque_Nacional_Consulta_Exportar(ByVal Filtro As Hashtable, ByVal FiltroFact As Hashtable) As DataSet
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Dim ds As New DataSet
        Dim dtDatoFacturacion As New DataTable
        Dim oFnEmbarque As New clsEmbarqueAduanas
        Dim dsResult As New DataSet
        Dim oClsFnLocal As New ClsFnDespachoLocal
        ds = oclsDespachoNacional.Listar_Embarque_Nacional_Consulta_Exportar(Filtro)

        dtDatoFacturacion = oclsDespachoNacional.LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(FiltroFact)
        dtDatoFacturacion.TableName = "dtFacturacion"



        Dim dtJoin As New DataTable

        Dim dtOrdEmb As New DataTable
        Dim dtMovCkPoint As New DataTable
        Dim dtMovObs As New DataTable
        Dim dtMovCostos As New DataTable
        Dim dtLstCkPoint As New DataTable
        Dim dtLstCostos As New DataTable
        'Jm
        Dim dtBultosEmbarque As New DataTable
        Dim dtTipoTarifa As New DataTable


        dtOrdEmb = ds.Tables("dtOrdenesEmbarque").Copy
        dtMovCkPoint = ds.Tables("dtMovChekPoint").Copy
        dtMovObs = ds.Tables("dtMovObservaciones").Copy
        dtMovCostos = ds.Tables("dtMovCostos").Copy
        dtLstCkPoint = ds.Tables("dtListaCheckPoint").Copy
        dtLstCostos = ds.Tables("dtListaCostos").Copy
        'JM
        dtBultosEmbarque = ds.Tables("dtBultosEmbarque").Copy
        dtTipoTarifa = ds.Tables("dtTipoTarifa").Copy


        dtJoin = ds.Tables("dtDatosEmbarque").Copy
        'JM
        dtJoin.Columns.Add("QBULTOS", Type.GetType("System.Decimal"))

        Dim TotalGuias As Decimal = 0

        Dim ColNombreCosto As String = String.Empty
        For Each drCostoItem As DataRow In dtLstCostos.Rows
            ColNombreCosto = drCostoItem("VALVAR").ToString.Trim & "-COSTO"
            dtJoin.Columns.Add(ColNombreCosto).Caption = drCostoItem("NOMVAR").ToString.Trim
        Next



        Dim ColNombFesChk As String = String.Empty
        Dim ColNombFreChk As String = String.Empty
        For Each drCkItem As DataRow In dtLstCkPoint.Rows
            ColNombFreChk = drCkItem("NESTDO").ToString.Trim & "-FRE-CHK"
            dtJoin.Columns.Add(ColNombFreChk).Caption = drCkItem("TCOLUM").ToString.Trim
            dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption
            If drCkItem("NESTDO") = 158 Then
                dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption & " (2)"
            End If
            If drCkItem("NESTDO") = 157 Then
                dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption & " (1)"
            End If


            If drCkItem("NESTDO") = 161 Then
                dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption & " (3)"
            End If
            If drCkItem("NESTDO") = 163 Then
                dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption & " (4)"
            End If

        Next
        If dtJoin.Columns("157-FRE-CHK") Is Nothing Then
            dtJoin.Columns.Add("157-FRE-CHK").Caption = "Fecha Salida almacén (1)"
        End If
        If dtJoin.Columns("158-FRE-CHK") Is Nothing Then
            dtJoin.Columns.Add("158-FRE-CHK").Caption = "Fecha Llegada (2)"
        End If

        If dtJoin.Columns("161-FRE-CHK") Is Nothing Then
            dtJoin.Columns.Add("161-FRE-CHK").Caption = "Fecha Embarque (3)"
        End If
        If dtJoin.Columns("163-FRE-CHK") Is Nothing Then
            dtJoin.Columns.Add("163-FRE-CHK").Caption = "Entrega en Alm. Cliente (4)"
        End If


        'TOTGUIAEMB
        dtJoin.Columns.Add("NUMDCR").Caption = "Documento(GR)"
        dtJoin.Columns.Add("NORCML").Caption = "Órdenes de Compra"
        dtJoin.Columns.Add("OBS").Caption = "Observaciones"
        dtJoin.Columns.Add("DIF").Caption = "(2) - (1) "
        dtJoin.Columns.Add("DIF_CHK161_CHK163").Caption = "(4) - (3) "

        dtJoin.Columns.Add("TOTGUIAEMB").Caption = "Cant. Doc"


        Dim NORSCI As Decimal = 0
        Dim cadOrd As String = String.Empty
        Dim cadNumDcr As String = String.Empty
        Dim cadObs As String = String.Empty

        For Each dr As DataRow In dtJoin.Rows

            NORSCI = dr("NORSCI")

            Dim MyChar() As Char = {" ", ","}

            dr("FORSCI") = HelpClass.FechaNum_a_Fecha(dr("FORSCI"))
            dr("QVOLMR") = Val(dr("QVOLMR"))
            dr("QPSOAR") = Val(dr("QPSOAR"))
            dr("NORCML") = oClsFnLocal.Buscar_Lista_Orden_Compra(dtOrdEmb, NORSCI)
            dr("NUMDCR") = oClsFnLocal.Buscar_Doc_Guia_Embarque(dtOrdEmb, NORSCI, TotalGuias)
            dr("TOTGUIAEMB") = TotalGuias
            dr("OBS") = oFnEmbarque.Buscar_Observaciones_Embarque(dtMovObs, NORSCI)
            'JM
            dr("QBULTOS") = Val("" & dtBultosEmbarque.Compute("SUM(QSEDNA)", "NORSCI='" & NORSCI & "'"))

            Dim column As New DataColumn
            For Each column In dtJoin.Columns

                Dim colum As String = column.ColumnName.Trim

                If colum.EndsWith("-COSTO") Then
                    Dim result() As String = Split(colum, "-")
                    Dim costo As String = ""
                    costo = oClsFnLocal.Buscar_Costo_Embarque(dtMovCostos, NORSCI, result(0))
                    If costo = "" Then
                        dr(colum) = DBNull.Value
                    Else
                        dr(colum) = costo
                    End If

                End If

                If colum.EndsWith("-CHK") Then
                    Dim result() As String = Split(colum, "-")
                    Dim NESTDO As Decimal = CDec(result(0).Trim)
                    Dim CodFecha As String = result(1).ToString.Trim()
                    dr(colum) = oFnEmbarque.ObtieneChkEmb(dtMovCkPoint, NORSCI, NESTDO)

                End If

            Next
            Dim Fecha_158_FechaLlegada As String = ("" & dr("158-FRE-CHK"))
            Dim Fecha_157_SalidaAlmacen As String = ("" & dr("157-FRE-CHK"))

            Dim Fecha_161_FechaEmbarque As String = ("" & dr("161-FRE-CHK"))
            Dim Fecha_163_FechaEntregaAlmacen As String = ("" & dr("163-FRE-CHK"))

            If Fecha_158_FechaLlegada = "" Or Fecha_157_SalidaAlmacen = "" Then
                dr("DIF") = Nothing
            Else
                Dim lintDif As Integer
                lintDif = DateDiff(DateInterval.Day, CType(Fecha_157_SalidaAlmacen, Date), CType(Fecha_158_FechaLlegada, Date))
                dr("DIF") = lintDif
            End If


            If Fecha_161_FechaEmbarque = "" Or Fecha_163_FechaEntregaAlmacen = "" Then
                dr("DIF_CHK161_CHK163") = Nothing
            Else
                Dim lintDif As Integer
                lintDif = DateDiff(DateInterval.Day, CType(Fecha_161_FechaEmbarque, Date), CType(Fecha_163_FechaEntregaAlmacen, Date))
                dr("DIF_CHK161_CHK163") = lintDif
            End If

        Next

        dsResult.Tables.Add(dtJoin.Copy)
        dsResult.Tables.Add(dtOrdEmb.Copy)
        'JM    --------------------------------------------------

        dsResult.Tables.Add(dtTipoTarifa.Copy)
        dsResult.Tables.Add(dtDatoFacturacion.Copy)
        Return dsResult

    End Function



    Public Function Lista_Despacho_Bulto_Guia_Remision(ByVal PSNUMDCR As String, ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PNNRGUSA As Decimal, ByVal PSNGRPRV As String, ByVal PSNORCML As String, ByVal PNNORSCI As Decimal) As DataSet
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Lista_Despacho_Bulto_Guia_Remision(PSNUMDCR, PSCCMPN, PNCPLNDV, PNCCLNT, PNNRGUSA, PSNGRPRV, PSNORCML, PNNORSCI)
    End Function
    Public Function Lista_Despacho_Bulto_Detalle_Dimension(ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCREFFW As String, ByVal PNNSEQIN As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Lista_Despacho_Bulto_Detalle_Dimension(PSCCMPN, PNCPLNDV, PNCCLNT, PSCREFFW, PNNSEQIN)
    End Function
    Public Function Lista_Despacho_Bulto_Detalle_Items(ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCREFFW As String, ByVal PNNSEQIN As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Lista_Despacho_Bulto_Detalle_Items(PSCCMPN, PNCPLNDV, PNCCLNT, PSCREFFW, PNNSEQIN)
    End Function


    Public Sub Registrar_Bulto_Guia_Remision(ByVal obeCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Registrar_Bulto_Guia_Remision(obeCarga)
    End Sub
    Public Function Listar_Dimnesiones_x_Carga_Item(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Dimnesiones_x_Carga_Item(PNNORSCI, PNCCLNT, PSNORCML, PNNRITEM, PNNRPEMB)

    End Function

    Public Function Listar_ItemsOC_x_Carga_Item(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPEMB As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_ItemsOC_x_Carga_Item(PNNORSCI, PNCCLNT, PSNORCML, PNNRPEMB)

    End Function


    Public Function Listar_Datos_Exportar_General(ByVal obeDespachoNacional As beDespachoNacional) As DataTable
        Dim dsDespacho As New DataSet
        Dim oClsFnLocal As New ClsFnDespachoLocal
        Dim oFnEmbarque As New clsEmbarqueAduanas
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        dsDespacho = oclsDespachoNacional.Listar_Datos_Exportar_General(obeDespachoNacional)

        Dim dtEmbarque As New DataTable
        Dim dtCheckPoint As New DataTable
        Dim dtObservacion As New DataTable
        Dim dtCostos As New DataTable
        Dim dtListaConceptoCHK As New DataTable
        Dim dtListaConceptoCosto As New DataTable
        Dim dtJoin As New DataTable

        dtEmbarque = dsDespacho.Tables(0).Copy
        dtCheckPoint = dsDespacho.Tables(1).Copy
        dtObservacion = dsDespacho.Tables(2).Copy
        dtCostos = dsDespacho.Tables(3).Copy
        dtListaConceptoCHK = dsDespacho.Tables(4).Copy
        dtListaConceptoCosto = dsDespacho.Tables(5).Copy
        dtJoin = dtEmbarque.Copy

        dtJoin.Columns.Add("OBS")

        Dim ColNombreCosto As String = String.Empty
        For Each drCostoItem As DataRow In dtListaConceptoCosto.Rows
            ColNombreCosto = drCostoItem("VALVAR").ToString.Trim & "-COSTO"
            dtJoin.Columns.Add(ColNombreCosto).Caption = drCostoItem("NOMVAR").ToString.Trim
        Next
        Dim ColNombFreChk As String = ""
        For Each drCkItem As DataRow In dtListaConceptoCHK.Rows
            ColNombFreChk = drCkItem("NESTDO").ToString.Trim & "-FRE-CHK"
            dtJoin.Columns.Add(ColNombFreChk).Caption = drCkItem("TCOLUM").ToString.Trim
            dtJoin.Columns(ColNombFreChk).Caption = dtJoin.Columns(ColNombFreChk).Caption
        Next
        Dim NORSCI As Decimal = 0
        Dim costo As String = ""
        For Each dr As DataRow In dtJoin.Rows

            NORSCI = dr("NORSCI")

            dr("FORSCI") = HelpClass.FechaNum_a_Fecha(dr("FORSCI"))
            dr("QVOLMR") = Val(dr("QVOLMR"))
            dr("QPSOAR") = Val(dr("QPSOAR"))

            dr("OBS") = oFnEmbarque.Buscar_Observaciones_Embarque(dtObservacion, NORSCI)

            Dim column As New DataColumn
            For Each column In dtJoin.Columns
                Dim colum As String = column.ColumnName.Trim
                If colum.EndsWith("-COSTO") Then
                    Dim result() As String = Split(colum, "-")
                    costo = oClsFnLocal.Buscar_Costo_Embarque(dtCostos, NORSCI, result(0))
                    If costo <> "" Then
                        dr(colum) = costo
                    Else
                        dr(colum) = DBNull.Value
                    End If
                End If

                If colum.EndsWith("-CHK") Then
                    Dim result() As String = Split(colum, "-")
                    Dim NESTDO As Decimal = CDec(result(0).Trim)
                    Dim CodFecha As String = result(1).ToString.Trim()
                    dr(colum) = oFnEmbarque.ObtieneChkEmb(dtCheckPoint, NORSCI, NESTDO)
                End If
            Next

        Next


        Return dtJoin
    End Function



    Public Function Listar_Datos_Exportar_Formato2(ByVal obeDespachoNacional As beDespachoNacional) As DataTable
        Dim dsDespacho As New DataSet
        Dim oClsFnLocal As New ClsFnDespachoLocal
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        dsDespacho = oclsDespachoNacional.Listar_Datos_Exportar_Formato2(obeDespachoNacional)

        Dim dtEmbarque As New DataTable
        'Dim dtEmbarqueDimension As New DataTable
        'Dim dtBulto As New DataTable
        Dim dtItem As New DataTable
        'Dim dtDimension As New DataTable
        Dim dtCheckPoint As New DataTable
        Dim dtObservacion As New DataTable
        'Dim dtCostos As New DataTable
        Dim dtListaConceptoCHK As New DataTable
        'Dim dtListaConceptoCosto As New DataTable

        dtEmbarque = dsDespacho.Tables(0).Copy
        'dtBulto = dsDespacho.Tables(1).Copy
        dtItem = dsDespacho.Tables(1).Copy
        'dtDimension = dsDespacho.Tables(3).Copy
        dtCheckPoint = dsDespacho.Tables(2).Copy
        dtObservacion = dsDespacho.Tables(3).Copy
        'dtCostos = dsDespacho.Tables(6).Copy
        dtListaConceptoCHK = dsDespacho.Tables(4).Copy
        'dtListaConceptoCosto = dsDespacho.Tables(8).Copy
        'dtEmbarqueDimension = dsDespacho.Tables(9).Copy

        Dim dtJoin As New DataTable
        dtJoin = dtEmbarque.Copy
        Dim oFnEmbarque As New clsEmbarqueAduanas

     
        dtJoin.Columns.Add("156_FRE_CHK")
        dtJoin.Columns.Add("157_FRE_CHK")
        dtJoin.Columns.Add("158_FRE_CHK")
        dtJoin.Columns.Add("159_FRE_CHK")
        dtJoin.Columns.Add("160_FRE_CHK")
        dtJoin.Columns.Add("161_FRE_CHK")
        dtJoin.Columns.Add("162_FRE_CHK")

        dtJoin.Columns.Add("VALOROC_ITEM")
        dtJoin.Columns.Add("NORCML")
        dtJoin.Columns.Add("NUMDCR")
        dtJoin.Columns.Add("NGRPRV")
        dtJoin.Columns.Add("TPRVCL")
        'dtJoin.Columns.Add("FINGAL")
        'dtJoin.Columns.Add("FSLDAL")
        dtJoin.Columns.Add("OBSERVACION")

        dtJoin.Columns.Add("PESO_VOLUMEN")
        dtJoin.Columns.Add("PESO_FACTOR", Type.GetType("System.Decimal"))
        dtJoin.Columns.Add("FACTOR_SERV")
        dtJoin.Columns.Add("VAL_SERV")


        'odtExportar.Columns.Add("PESO_VOLUMEN").Caption = NPOI_SC.FormatDato("Peso Volumen", NPOI_SC.keyDatoNumero)
        'odtExportar.Columns.Add("PESO_FACTOR", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Peso Factor", NPOI_SC.keyDatoNumero)




        Dim norsci As Decimal = 0
        Dim TotalGuiasxEmb As Decimal = 0

        Dim Visitado As New Hashtable
        'Dim Fila As Int32 = 0
        For Each Item As DataRow In dtJoin.Rows
            norsci = Item("NORSCI")
            Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            Item("156_FRE_CHK") = oClsFnLocal.Fecha_Solicitud(dtCheckPoint, norsci)
            Item("157_FRE_CHK") = oClsFnLocal.Fecha_Salida_Almacen(dtCheckPoint, norsci)
            Item("158_FRE_CHK") = oClsFnLocal.Fecha_Llegada(dtCheckPoint, norsci)
            Item("159_FRE_CHK") = oClsFnLocal.Fecha_Requerimiento_Transporte(dtCheckPoint, norsci)
            Item("160_FRE_CHK") = oClsFnLocal.Fecha_Ingreso_Terminal(dtCheckPoint, norsci)
            Item("161_FRE_CHK") = oClsFnLocal.Fecha_Embarque(dtCheckPoint, norsci)
            Item("162_FRE_CHK") = oClsFnLocal.Fecha_Ingreso(dtCheckPoint, norsci)

            Item("OBSERVACION") = oFnEmbarque.Buscar_Observaciones_Embarque(dtObservacion, norsci)
            Item("NUMDCR") = oClsFnLocal.Buscar_Doc_Guia_Embarque(dtItem, norsci, TotalGuiasxEmb)
            Item("NGRPRV") = oClsFnLocal.Buscar_Doc_GuiaProv_Embarque(dtItem, norsci)
            Item("NORCML") = oClsFnLocal.Buscar_Doc_OC_Embarque(dtItem, norsci)
            Item("TPRVCL") = oClsFnLocal.Buscar_Proveedor_Embarque(dtItem, norsci)
            Item("VALOROC_ITEM") = oClsFnLocal.Total_OC_Item(dtItem, norsci)
            'Item("FINGAL") = oClsFnLocal.Buscar_Fecha_Ingreso_Almacen(dtEmbarque, norsci)
            'Item("FSLDAL") = oClsFnLocal.Buscar_Fecha_Salida_Almacen(dtEmbarque, norsci)

            Item("PESO_VOLUMEN") = oClsFnLocal.Calcular_Peso_Volumen(Item("QMTLRG_DET"), Item("QMTANC_DET"), Item("QMTALT_DET"), Item("QCTPQT_DET"))
            Item("PESO_FACTOR") = oClsFnLocal.Calcular_Peso_Factor_Servicio(Item("QPSOMR_DET"), Item("PESO_VOLUMEN"))

         

        Next
        Visitado.Clear()
        Dim qFactorxCierre As Decimal = 0
        For Each item As DataRow In dtJoin.Rows
            norsci = item("NORSCI")
            qFactorxCierre = item("QFACTOR_SERV")
            If Not Visitado.Contains(norsci) Then
                Visitado.Add(norsci, norsci)

                If qFactorxCierre > 0 Then
                    item("FACTOR_SERV") = qFactorxCierre
                Else
                    item("FACTOR_SERV") = Val("" & dtJoin.Compute("SUM(PESO_FACTOR)", "NORSCI='" & norsci & "'"))
                End If
                item("VAL_SERV") = item("FACTOR_SERV") * Val("" & item("IVLSRV"))
            End If
        Next

        Return dtJoin
    End Function





    Public Function Listar_Datos_Item_Carga(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Datos_Item_Carga(PNNORSCI, PNCCLNT, PSNORCML, PNNRITEM, PNNRPEMB)
    End Function
    Public Function Listar_Datos_Tarifa_Asignada(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNRTFSV As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Datos_Tarifa_Asignada(PSCCMPN, PSCDVSN, PNNRTFSV)
    End Function
    Public Function Calcular_Factor_Servicio(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As Decimal
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Dim oClsFnLocal As New ClsFnDespachoLocal
        Dim Factor_Serv As Decimal = 0
        Dim dtDetalleCarga As New DataTable
        dtDetalleCarga = oclsDespachoNacional.Listar_Dimension_Todos_x_Embarque_Calculo_Factor(PNNORSCI, PNCCLNT)
        dtDetalleCarga.Columns.Add("PESO_VOLUMEN", Type.GetType("System.Decimal"))
        dtDetalleCarga.Columns.Add("PESO_FACTOR", Type.GetType("System.Decimal"))

        For Each Item As DataRow In dtDetalleCarga.Rows
            Item("PESO_VOLUMEN") = oClsFnLocal.Calcular_Peso_Volumen(Item("QMTLRG"), Item("QMTANC"), Item("QMTALT"), Item("QCTPQT"))
            Item("PESO_FACTOR") = oClsFnLocal.Calcular_Peso_Factor_Servicio(Item("QPSOMR"), Item("PESO_VOLUMEN"))
        Next
        Factor_Serv = Val("" & dtDetalleCarga.Compute("SUM(PESO_FACTOR)", ""))
        Return Factor_Serv
    End Function



    Public Sub Actualizar_Documento_Salida_Despacho(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Actualizar_Documento_Salida_Despacho(PNNORSCI, PNCCLNT)
    End Sub

    Public Sub Eliminar_Item_OC_Carga(ByVal ObeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Eliminar_Item_OC_Carga(ObeOrdenEmbarqueCarga)
    End Sub

    Public Function Listar_Items_OC_X_Bulto(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPEMB As Decimal) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Items_OC_X_Bulto(PNNORSCI, PNCCLNT, PSNORCML, PNNRPEMB)
    End Function

    Public Sub Registrar_Item_OC_Manual(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Registrar_Item_OC_Manual(obeOrdenEmbarqueCarga)
    End Sub

    Public Function Listar_Datos_Despacho_Nacional(ByVal NORSCI As Decimal) As beDespachoNacional
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.Listar_Datos_Despacho_Nacional(NORSCI)
    End Function
    Public Sub Actualizar_Datos_Item_OC(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        oclsDespachoNacional.Actualizar_Datos_Item_OC(obeOrdenEmbarqueCarga)
    End Sub

    'JM
    'Public Function LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PSTPSRVA As String, ByVal PNFECINI As String, ByVal PNFECFIN As Decimal, ByVal PNANIO As Integer, ByVal PSMESES As String) As DataTable
    '    Dim oclsDespachoNacional As New Datos.clsDespachoNacional
    '    Return oclsDespachoNacional.LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(PSCCMPN, PSCDVSN, PNCCLNT, PSTPSRVA, PNFECINI, PNFECFIN, PNANIO, PSMESES)
    'End Function
    Public Function LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(ByVal Param As Hashtable) As DataTable
        Dim oclsDespachoNacional As New Datos.clsDespachoNacional
        Return oclsDespachoNacional.LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(Param)
    End Function
    
End Class
