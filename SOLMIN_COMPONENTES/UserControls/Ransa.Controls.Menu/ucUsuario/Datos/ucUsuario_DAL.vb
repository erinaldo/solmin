
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class ucUsuario_DAL
  Inherits Base_DAL(Of beUsuarioUC)

  Public Function ListarUsuario(ByVal obeUsuario As beUsuario_InfoUC) As List(Of beUsuarioUC)

    Dim oDt As New DataTable
    Dim objSqlManager As New SqlManager
    Dim olistUsuarioUC As New List(Of beUsuarioUC)
    Dim objParam As New Parameter

    objParam.Add("PSMMCAPL", obeUsuario.PSMMCUSR)
    objParam.Add("PSMMCMNU", obeUsuario.PSMMNUSR)

    objParam.Add("PAGESIZE", obeUsuario.PageSize)
    objParam.Add("PAGENUMBER", obeUsuario.PageNumber)
    objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

    olistUsuarioUC = Listar("SP_SOLMIN_SD_LISTA_USUARIOS_PAGINACION", objParam)
    Return olistUsuarioUC
  End Function

  Public Overrides Sub SetStoredprocedures()
  End Sub

  Public Overrides Sub ToParameters(ByVal obj As beUsuarioUC)
  End Sub
End Class

