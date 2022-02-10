Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class brMercaderia_DAL
    Inherits daBase(Of TYPEDEF.beMercaderia)

    Public Function ListaMarca(ByVal obeParam As Ransa.TYPEDEF.beMercaderia) As List(Of Ransa.TYPEDEF.beMercaderia)
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSSTPOUN", obeParam.PNCMRCA)
        lobjParams.Add("PSCUNDMD", obeParam.PSTCMMRC)

        lobjParams.Add("PAGESIZE", obeParam.PageSize)
        lobjParams.Add("PAGENUMBER", obeParam.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLMIN_SA_MARCA_MERCADERIA_LISTAR", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of beMercaderia)
        'End Try
    End Function
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beMercaderia)

    End Sub
End Class
