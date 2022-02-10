Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsCentroCosto_DAL

    'Public Function Lista_CentroBeneficio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
    '                                 ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
    '                                 ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto_BE) '
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PSCCMPN", codCompania)
    '    lobjParams.Add("PSCRGVTA", codRegionVentaSAP)
    '    lobjParams.Add("PSCDSRSP", codMacroServicioSAP)
    '    lobjParams.Add("PSCDTSSP", codTipoServicioSAP)
    '    lobjParams.Add("PSCDTASP", codTipoActivoSAP)
    '    lobjParams.Add("PSCDSPSP", codSedeSAP)
    '    lobjParams.Add("PSCDUPSP", codUnidadProductivaSAP)
    '    lobjParams.Add("PSCDTPCE", tipoCentroSAP)

    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO", lobjParams)

    '    Dim lbeCentroCosto As New List(Of CentroCosto_BE)
    '    For Each dataRow As DataRow In dt.Rows
    '        Dim centroCosto As CentroCosto_BE = New CentroCosto_BE()
    '        centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
    '        centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
    '        centroCosto.PSCCNBNS = dataRow("CCNBNS").ToString.Trim()
    '        centroCosto.PSCRGVTA = dataRow("CRGVTA").ToString.Trim()
    '        centroCosto.PSCDSDSP = dataRow("CDSDSP").ToString.Trim()
    '        centroCosto.PSCDSRSP = dataRow("CDSRSP").ToString.Trim()
    '        centroCosto.PSCDTSSP = dataRow("CDTSSP").ToString.Trim()
    '        centroCosto.PSCDTASP = dataRow("CDTASP").ToString.Trim()
    '        centroCosto.PSCDSPSP = dataRow("CDSPSP").ToString.Trim()
    '        centroCosto.PSCDUPSP = dataRow("CDUPSP").ToString.Trim()
    '        centroCosto.PSCDSCSP = dataRow("CDSCSP").ToString.Trim()
    '        centroCosto.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
    '        centroCosto.PSSESTRG = dataRow("SESTRG").ToString.Trim()
    '        centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
    '        centroCosto.CEBE = dataRow("CEBE").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    '        lbeCentroCosto.Add(centroCosto)
    '    Next
    '    Return lbeCentroCosto
    'End Function



    Public Function Lista_CentroBeneficio_Tokio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                    ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                    ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto_BE) '
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

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_BENEFICIO_TOKIO_ADMIN", lobjParams)

        Dim lbeCentroCosto As New List(Of CentroCosto_BE)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto_BE = New CentroCosto_BE()
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
            centroCosto.PSCDTPCE = dataRow("CDTPCE").ToString.Trim
            centroCosto.PSSESTRG = dataRow("SESTRG").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.CEBE = dataRow("CEBE").ToString.Trim() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            lbeCentroCosto.Add(centroCosto)
        Next
        Return lbeCentroCosto
    End Function

    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Public Function Listar_CentroCosto_Origen_Tarifa(ByVal pstrCompania As String) As List(Of CentroCosto_BE)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO_X_COMPANIA", lobjParams)
        Dim lbeCentroCostoOrigen As New List(Of CentroCosto_BE)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto_BE = New CentroCosto_BE()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNCOS = dataRow("CCNCOS").ToString.Trim()
            lbeCentroCostoOrigen.Add(centroCosto)
        Next
        Return lbeCentroCostoOrigen
    End Function
    Public Function Listar_CentroCosto_Destino_Tarifa(ByVal pstrCompania As String, ByVal pstrCentroBeneficio As String) As List(Of CentroCosto_BE)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PNCCNTBN", pstrCentroBeneficio)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_COSTO_X_CEBE", lobjParams)
        Dim lbeCentroCostoDestino As New List(Of CentroCosto_BE)
        For Each dataRow As DataRow In dt.Rows
            Dim centroCosto As CentroCosto_BE = New CentroCosto_BE()
            centroCosto.PSCCMPN = dataRow("CCMPN").ToString.Trim()
            centroCosto.PNCCNTCS = dataRow("CCNTCS").ToString.Trim()
            centroCosto.PSTCNTCS = dataRow("TCNTCS").ToString.Trim()
            centroCosto.PSCCNCOS = dataRow("CCNCOS").ToString.Trim()
            lbeCentroCostoDestino.Add(centroCosto)
        Next
        Return lbeCentroCostoDestino
    End Function
End Class
