Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daUbicacionSugeridaMercaderiaGuia
    Private objSql As New SqlManager
    Public Function ListarSugerenciaMercaderia(ByVal obeSugerenciaMercaderiaGuia As beSugerenciaMercaderiaGuia) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeSugerenciaMercaderiaGuia.CCLNT2)
            objParam.Add("IN_NGUIRN", obeSugerenciaMercaderiaGuia.NGUIRN)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_UBICACION_SUGERIDA_GUIA", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function
    Public Function ListarSugerenciaPiking(ByVal IN_NORDSR As Int64) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_NORDSR", IN_NORDSR)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_SUGERENCIA_PICKING", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function
    'Public Function ListarPosicionSugerida(ByVal obeUbicacionSugerida As beUbicacionSugerida) As DataSet
    '    Dim oDs As New DataSet
    '    Dim objParam As New Parameter
    '    Try
    '        objParam.Add("PNCCLNT", obeUbicacionSugerida.CCLNT)
    '        objParam.Add("PSCMRCLR", obeUbicacionSugerida.CMRCLR)
    '        objParam.Add("PSCTPALM", obeUbicacionSugerida.CTPALM)
    '        objParam.Add("PSCALMC", obeUbicacionSugerida.CALMC)
    '        objParam.Add("PNMOBILE", obeUbicacionSugerida.MOBILE)
    '        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_MOVIMIENTO_POSICION_LISTAR", objParam)
    '    Catch ex As Exception
    '        oDs = Nothing
    '    End Try
    '    Return oDs
    'End Function
    Public Function SP_SOLMIN_SA_ITEMS_PEDIDO(ByVal IN_CDPEPL As Int64) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CDPEPL", IN_CDPEPL)         
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_ITEMS_PEDIDO", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

End Class
