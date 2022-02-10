
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class AgenteAduana_DAL
  Inherits Base_DAL(Of AgenteAduana_BE)

  Public Function ListarAgenteAduana(ByVal obeAgenteAduana As AgenteAduana_Info_BE) As List(Of AgenteAduana_BE)

    Dim oDt As New DataTable
    Dim objSqlManager As New SqlManager
    Dim olistAgenteAduana As New List(Of AgenteAduana_BE)
    Dim objParam As New Parameter
    objParam.Add("PNCTRSPT", obeAgenteAduana.PNCAGNAD)
    objParam.Add("PNNRUCPR", obeAgenteAduana.PSTCMAA)
    'objParam.Add("PSTCMTRT", obeTransportista.PSTCMTRT)
    objParam.Add("PSBUSQUEDA", obeAgenteAduana.PSBUSQUEDA)
    objParam.Add("PAGESIZE", obeAgenteAduana.PageSize)
    objParam.Add("PAGENUMBER", obeAgenteAduana.PageNumber)
    objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

    Return Listar("SP_SOLSC_LISTA_AGENCIA_CARGA", objParam)

  End Function

  Public Overrides Sub SetStoredprocedures()

  End Sub

  Public Overrides Sub ToParameters(ByVal obj As AgenteAduana_BE)

  End Sub
End Class
