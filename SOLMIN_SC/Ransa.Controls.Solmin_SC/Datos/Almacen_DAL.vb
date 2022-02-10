Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class Almacen_DAL
    Inherits Base_DAL(Of Almacen_BE)


    Public Function ListarAlmacen(ByVal obeAlmacen As Almacen_Info_BE) As List(Of Almacen_BE)
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PSTCMPAL", obeAlmacen.PSTCMPAL)
        objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
        objParam.Add("PSCALMC", obeAlmacen.PSCALMC)
        objParam.Add("PSBUSQUEDA", obeAlmacen.PSBUSQUEDA)
        objParam.Add("PAGESIZE", obeAlmacen.PageSize)
        objParam.Add("PAGENUMBER", obeAlmacen.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLSC_LISTA_ALMACEN", objParam)

    End Function




    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Almacen_BE)

    End Sub
End Class
