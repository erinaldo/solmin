Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsCentroCosto
    Public Function Lista_CentroCosto(ByVal strCompania As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", strCompania)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CENTRO_COSTO", lobjParams)
        Return dt
    End Function

    '<[AHM]>
    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-Se cambio nombre de método
    Public Function Lista_CentroBeneficio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                      ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                      ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto) '
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", codCompania)
        lobjParams.Add("PSCRGVTA", codRegionVentaSAP)
        lobjParams.Add("PSCDSRSP", codMacroServicioSAP)
        lobjParams.Add("PSCDTSSP", codTipoServicioSAP)
        lobjParams.Add("PSCDTASP", codTipoActivoSAP)
        lobjParams.Add("PSCDSPSP", codSedeSAP)
        lobjParams.Add("PSCDUPSP", codUnidadProductivaSAP)
        lobjParams.Add("PSCDTPCE", tipoCentroSAP)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO", lobjParams)

        Dim lbeCentroCosto As New List(Of CentroCosto)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto = New CentroCosto()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSCCNBNS = dataRow("CCNBNS").ToString.Trim()
            centroCosto.PSCRGVTA = dataRow("CRGVTA").ToString.Trim()
            centroCosto.PSCDSDSP = dataRow("CDSDSP").ToString.Trim()
            centroCosto.PSCDSRSP = dataRow("CDSRSP").ToString.Trim()
            centroCosto.PSCDTSSP = dataRow("CDTSSP").ToString.Trim()
            centroCosto.PSCDTASP = dataRow("CDTASP").ToString.Trim()
            centroCosto.PSCDSPSP = dataRow("CDSPSP").ToString.Trim()
            centroCosto.PSCDUPSP = dataRow("CDUPSP").ToString.Trim()
            centroCosto.PSCDSCSP = dataRow("CDSCSP").ToString.Trim()
            'centroCosto.PSCDTPCE = Convert.ToInt32(dataRow("CDTPCE"))
            centroCosto.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
            centroCosto.PSSESTRG = dataRow("SESTRG").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.CEBE = dataRow("CEBE").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            lbeCentroCosto.Add(centroCosto)
        Next
        Return lbeCentroCosto
    End Function



    Public Sub Lista_CentroBeneficio_Tokio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                     ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                     ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String, ByRef oCebePropio As CentroCosto, ByRef oCebeTercero As CentroCosto)
        Dim dtPropio As DataTable
        Dim dtTercero As DataTable
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", codCompania)
        lobjParams.Add("PSCRGVTA", codRegionVentaSAP)
        lobjParams.Add("PSCDSRSP", codMacroServicioSAP)
        lobjParams.Add("PSCDTSSP", codTipoServicioSAP)
        'lobjParams.Add("PSCDTASP", codTipoActivoSAP)
        lobjParams.Add("PSTIPO_ACTIVO", codTipoActivoSAP)
        lobjParams.Add("PSCDSPSP", codSedeSAP)
        lobjParams.Add("PSCDUPSP", codUnidadProductivaSAP)
        lobjParams.Add("PSCDTPCE", tipoCentroSAP)

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_CENTRO_BENEFICIO_TOKIO", lobjParams)
        dtPropio = ds.Tables(0).Copy


        'Dim lbeCentroCosto As New List(Of CentroCosto)
        For Each dataRow As DataRow In dtPropio.Rows
            'Dim oCebePropio As CentroCosto = New CentroCosto()
            oCebePropio.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            oCebePropio.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            oCebePropio.PSCCNBNS = dataRow("CCNBNS").ToString.Trim()
            oCebePropio.PSCRGVTA = dataRow("CRGVTA").ToString.Trim()
            oCebePropio.PSCDSDSP = dataRow("CDSDSP").ToString.Trim()
            oCebePropio.PSCDSRSP = dataRow("CDSRSP").ToString.Trim()
            oCebePropio.PSCDTSSP = dataRow("CDTSSP").ToString.Trim()
            oCebePropio.PSCDTASP = dataRow("CDTASP").ToString.Trim()
            oCebePropio.PSCDSPSP = dataRow("CDSPSP").ToString.Trim()
            oCebePropio.PSCDUPSP = dataRow("CDUPSP").ToString.Trim()
            oCebePropio.PSCDSCSP = dataRow("CDSCSP").ToString.Trim()
            oCebePropio.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
            oCebePropio.PSSESTRG = dataRow("SESTRG").ToString.Trim()
            oCebePropio.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            oCebePropio.CEBE = dataRow("CEBE").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            'lbeCentroCosto.Add(centroCosto)
        Next

        If codTipoActivoSAP = "OS" Then

            dtTercero = ds.Tables(1).Copy
            For Each dataRow As DataRow In dtTercero.Rows
                'Dim oCebePropio As CentroCosto = New CentroCosto()
                oCebeTercero.PSCCMPN = dataRow("CCMPN").ToString.Trim()
                oCebeTercero.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
                oCebeTercero.PSCCNBNS = dataRow("CCNBNS").ToString.Trim()
                oCebeTercero.PSCRGVTA = dataRow("CRGVTA").ToString.Trim()
                oCebeTercero.PSCDSDSP = dataRow("CDSDSP").ToString.Trim()
                oCebeTercero.PSCDSRSP = dataRow("CDSRSP").ToString.Trim()
                oCebeTercero.PSCDTSSP = dataRow("CDTSSP").ToString.Trim()
                oCebeTercero.PSCDTASP = dataRow("CDTASP").ToString.Trim()
                oCebeTercero.PSCDSPSP = dataRow("CDSPSP").ToString.Trim()
                oCebeTercero.PSCDUPSP = dataRow("CDUPSP").ToString.Trim()
                oCebeTercero.PSCDSCSP = dataRow("CDSCSP").ToString.Trim()
                oCebeTercero.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
                oCebeTercero.PSSESTRG = dataRow("SESTRG").ToString.Trim()
                oCebeTercero.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
                oCebeTercero.CEBE = dataRow("CEBE").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                'lbeCentroCosto.Add(centroCosto)
            Next

        End If
      

        '  Return lbeCentroCosto
    End Sub

    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Public Function Listar_CentroCosto_Origen_Tarifa(ByVal pstrCompania As String) As List(Of CentroCosto)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO_X_COMPANIA", lobjParams)
        Dim lbeCentroCostoOrigen As New List(Of CentroCosto)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto = New CentroCosto()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNCOS = dataRow("CCNCOS").ToString.Trim()
            lbeCentroCostoOrigen.Add(centroCosto)
        Next
        Return lbeCentroCostoOrigen
    End Function

    Public Function Listar_CentroCosto_Destino_Tarifa(ByVal pstrCompania As String, ByVal pstrCentroBeneficio As String) As List(Of CentroCosto)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PNCCNTBN", pstrCentroBeneficio)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO_X_CEBE", lobjParams)
        Dim lbeCentroCostoDestino As New List(Of CentroCosto)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto = New CentroCosto()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNCOS = dataRow("CCNCOS").ToString.Trim()
            lbeCentroCostoDestino.Add(centroCosto)
        Next
        Return lbeCentroCostoDestino
    End Function

    Public Function Listar_CentroCosto_CeBe(ByVal pstrCompania As String, ByVal pstrCentroBeneficio As String) As List(Of CentroCosto)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PNCCNTBN", pstrCentroBeneficio)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CECO_X_CEBE", lobjParams)
        Dim lbeCentroCosto As New List(Of CentroCosto)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto = New CentroCosto()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNCOS = dataRow("CCNCOS").ToString.Trim()
            centroCosto.CECO = dataRow("CECO").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            lbeCentroCosto.Add(centroCosto)
        Next
        Return lbeCentroCosto
    End Function


    Public Function Listar_CentroBeneficio_Id(ByVal pstrCompania As String, ByVal CeBe As Decimal) As List(Of CentroCosto)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PNCCNTCS", CeBe)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_BENEFICIO_ID", lobjParams)
        Dim lbeCentroCosto As New List(Of CentroCosto)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto = New CentroCosto()
            
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNBNS = dataRow("CCNBNS").ToString.Trim()
            centroCosto.PSCRGVTA = dataRow("CRGVTA").ToString.Trim()
            centroCosto.PSCDSDSP = dataRow("CDSDSP").ToString.Trim()
            centroCosto.PSCDSRSP = dataRow("CDSRSP").ToString.Trim()
            centroCosto.PSCDTSSP = dataRow("CDTSSP").ToString.Trim()
            centroCosto.PSCDTASP = dataRow("CDTASP").ToString.Trim()
            centroCosto.PSCDSPSP = dataRow("CDSPSP").ToString.Trim()
            centroCosto.PSCDUPSP = dataRow("CDUPSP").ToString.Trim()
            centroCosto.PSCDSCSP = dataRow("CDSCSP").ToString.Trim()
            centroCosto.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
            centroCosto.PSSESTRG = dataRow("SESTRG").ToString.Trim()



            lbeCentroCosto.Add(centroCosto)
        Next
        Return lbeCentroCosto
    End Function

    'RCS-HUNDRED-FIN
    
End Class
