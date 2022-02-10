Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class ucAplicacion_DAL
  Inherits Base_DAL(Of beAplicacionUc)

  Public Function ListarAplicacion(ByVal obeAplicacion As beAplicacionInfoUC) As List(Of beAplicacionUc)

    Dim oDt As New DataTable
    Dim objSqlManager As New SqlManager
    Dim olistAgenteAduana As New List(Of beAplicacionUc)
    Dim objParam As New Parameter
    objParam.Add("PSMMCAPL", obeAplicacion.PSMMCAPL)
    objParam.Add("PSMMDAPL", (obeAplicacion.PSMMDAPL).ToUpper)
    objParam.Add("PAGESIZE", obeAplicacion.PageSize)
    objParam.Add("PAGENUMBER", obeAplicacion.PageNumber)
    objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
    Return Listar("SP_SOLMIN_SD_LISTA_APLICACIONES_PAGINACION", objParam)
  End Function

  Public Overrides Sub SetStoredprocedures()

  End Sub

  Public Overrides Sub ToParameters(ByVal obj As beAplicacionUc)
  End Sub
End Class
