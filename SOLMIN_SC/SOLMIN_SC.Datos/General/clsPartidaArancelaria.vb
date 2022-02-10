Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsPartidaArancelaria
    Public Function Lista_Partidas() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PARTIDA", Nothing)
        Return dt
    End Function

    Public Function Lista_Partidas_Item(ByVal pdblCliente As Double, ByVal pstrSKU As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSTCITCL", pstrSKU)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PARTIDA_ITEM", lobjParams)
        Return dt
    End Function

    Public Function Lista_Partidas_Arancelarias(ByVal obePartidas As bePartidaArancelaria) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCPTDAR", obePartidas.PSCPTDAR)
        lobjParams.Add("PSTDEPTD", obePartidas.PSTDEPTD)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PARTIDAS_ARANCELARIAS", lobjParams)
        Return dt
    End Function

    Public Sub Guardar_Partidas_Arancelarias(ByVal obePartidas As bePartidaArancelaria)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCPTDAR", obePartidas.PSCPTDAR)
        lobjParams.Add("PSTDEPTD", obePartidas.PSTDEPTD.Trim)
        lobjParams.Add("PNPRARAN", obePartidas.PNPRARAN)
        lobjParams.Add("PSUSUARIO", obePartidas.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_PARTIDAS_ARANCELARIAS", lobjParams)
    End Sub

    Public Sub Elimina_Partidas_Arancelarias(ByVal obePartidas As bePartidaArancelaria)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCPTDAR", obePartidas.PSCPTDAR)
        lobjParams.Add("PSUSUARIO", obePartidas.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINA_PARTIDAS_ARANCELARIAS", lobjParams)
    End Sub

End Class
