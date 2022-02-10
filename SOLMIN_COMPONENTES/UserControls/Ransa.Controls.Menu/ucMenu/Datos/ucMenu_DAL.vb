Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class ucMenu_DAL
  Inherits Base_DAL(Of beMenuUC)

  Public Function ListarMenu(ByVal obeMenu As beMenu_InfoUC) As List(Of beMenuUC)

    Dim oDt As New DataTable
    Dim objSqlManager As New SqlManager
    Dim olistAgenteAduana As New List(Of beMenuUC)
    Dim objParam As New Parameter
    objParam.Add("PSMMCAPL", obeMenu.PSMMCAPL)
    objParam.Add("PSMMCMNU", obeMenu.PSMMCMNU)
    objParam.Add("PSMMTMNU", (obeMenu.PSMMTMNU).ToUpper)
    objParam.Add("PAGESIZE", obeMenu.PageSize)
    objParam.Add("PAGENUMBER", obeMenu.PageNumber)
    objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
    Return Listar("SP_SOLMIN_SD_LISTA_MENUXAPLICACION_PAGINACION", objParam)
  End Function

  Public Overrides Sub SetStoredprocedures()

  End Sub

  Public Overrides Sub ToParameters(ByVal obj As beMenuUC)
  End Sub
End Class
