Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class ucOpcion_DAL
  Inherits Base_DAL(Of beOpcionUC)

  Public Function ListarOpcion(ByVal obeOpcion As beOpcion_InfoUC) As List(Of beOpcionUC)

    Dim oDt As New DataTable
    Dim objSqlManager As New SqlManager
    Dim olistOpcionUC As New List(Of beOpcionUC)
    Dim objParam As New Parameter

    objParam.Add("PSMMCAPL", obeOpcion.PSMMCAPL)
    objParam.Add("PSMMCMNU", obeOpcion.PSMMCMNU)

    If obeOpcion.PNMMCOPC = Nothing Then
      objParam.Add("PNMMCOPC", 0)
    Else
      objParam.Add("PNMMCOPC", obeOpcion.PNMMCOPC)
    End If
    objParam.Add("PSMMDOPC", obeOpcion.PSMMDOPC)
    objParam.Add("PAGESIZE", obeOpcion.PageSize)
    objParam.Add("PAGENUMBER", obeOpcion.PageNumber)
    objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

    'oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SD_LISTA_OPCIONXMENU_PAGINACION", objParam)
    olistOpcionUC = Listar("SP_SOLMIN_SD_LISTA_OPCIONXMENU_PAGINACION", objParam)
    Return olistOpcionUC
  End Function

  Public Overrides Sub SetStoredprocedures()

  End Sub

  Public Overrides Sub ToParameters(ByVal obj As beOpcionUC)
  End Sub
End Class
