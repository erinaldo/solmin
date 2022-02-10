Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class Transportista_DAL
    Inherits Base_DAL(Of Transportista_BE)

    Public Function ListarTransportista(ByVal obeTransportista As Transportista_Info_BE) As List(Of Transportista_BE)
        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olistTransportista As New List(Of Transportista_BE)
        Dim objParam As New Parameter
        objParam.Add("PNCTRSPT", obeTransportista.PNCTRSPT)
        objParam.Add("PNNRUCPR", obeTransportista.PSNRUCTR)
        objParam.Add("PSTCMTRT", obeTransportista.PSTCMTRT)
        objParam.Add("PSBUSQUEDA", obeTransportista.PSBUSQUEDA)
        objParam.Add("PAGESIZE", obeTransportista.PageSize)
        objParam.Add("PAGENUMBER", obeTransportista.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLSC_LISTA_TRANSPORTISTAS", objParam)

    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Transportista_BE)

    End Sub
End Class
