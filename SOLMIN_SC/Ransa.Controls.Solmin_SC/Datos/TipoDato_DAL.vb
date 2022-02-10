Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class TipoDato_DAL
    Inherits Base_DAL(Of TipoDato_BE)

    Public Function ListarAlmacenLocaL(ByVal obeAlmacen As TipoDato_Info_BE) As List(Of TipoDato_BE)
        Dim objSqlManager As New SqlManager
        Dim olistAlmacen As New List(Of TipoDato_BE)
        Dim objParam As New Parameter
        objParam.Add("PNNCODRG", obeAlmacen.PNNCODRG)
        objParam.Add("PSTDSCRG", obeAlmacen.PSTDSCRG)
        objParam.Add("PNCCLNT", obeAlmacen.PNCCLNT)
        objParam.Add("PSBUSQUEDA", obeAlmacen.PSBUSQUEDA)
        objParam.Add("PAGESIZE", obeAlmacen.PageSize)
        objParam.Add("PAGENUMBER", obeAlmacen.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLSC_LISTA_ALMACEN_LOCAL", objParam)

    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TipoDato_BE)

    End Sub
End Class
