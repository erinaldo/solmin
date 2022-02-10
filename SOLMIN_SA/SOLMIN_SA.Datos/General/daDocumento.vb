Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daDocumento
    Inherits daBase(Of BeDocumento)
    Private objSql As New SqlManager

    Public Function DocumentoAlmacenInsertar(ByVal oBeDocumento As BeDocumento) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oBeDocumento.PNCCLNT)
            objParam.Add("PSNDOCUM", oBeDocumento.PSNDOCUM)
            objParam.Add("PSTIPODC", oBeDocumento.PSTIPODC)
            objParam.Add("PSCTIIMG", oBeDocumento.PSCTIIMG)

            objParam.Add("PSTOBSMD", oBeDocumento.PSTOBSMD)
            objParam.Add("PSTNMBAR", oBeDocumento.PSTNMBAR)
            objParam.Add("PSURLARC", oBeDocumento.PSURLARC)
            objParam.Add("PSCUSCRT", oBeDocumento.PSCUSCRT)
            objParam.Add("PSCULUSA", oBeDocumento.PSCULUSA)
            objParam.Add("PSSESTRG", oBeDocumento.PSSESTRG)
            objParam.Add("PNNCRRDC", oBeDocumento.PNNCRRDC, ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_DOCUMENTO_ALAMCEN_INSERT", objParam)
            Return objParam.Item(objParam.Count).Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function DocumentoAlmacenActualizar(ByVal oBeDocumento As BeDocumento) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oBeDocumento.PNCCLNT)
            objParam.Add("PSNDOCUM", oBeDocumento.PSNDOCUM)
            objParam.Add("PSTIPODC", oBeDocumento.PSTIPODC)
            objParam.Add("PSCTIIMG", oBeDocumento.PSCTIIMG)
            objParam.Add("PNNCRRDC", oBeDocumento.PNNCRRDC)
            objParam.Add("PSTOBSMD", oBeDocumento.PSTOBSMD)
            objParam.Add("PSTNMBAR", oBeDocumento.PSTNMBAR)
            objParam.Add("PSURLARC", oBeDocumento.PSURLARC)
            objParam.Add("PSCULUSA", oBeDocumento.PSCULUSA)
            objParam.Add("PSSESTRG", oBeDocumento.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_DOCUMENTO_ALAMCEN_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function DocumentoAlmacenListar(ByVal oBeDocumento As BeDocumento) As List(Of BeDocumento)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", oBeDocumento.PNCCLNT)
            objParam.Add("PSNDOCUM", oBeDocumento.PSNDOCUM)
            objParam.Add("PSTIPODC", oBeDocumento.PSTIPODC)
            objParam.Add("PSCTIIMG", oBeDocumento.PSCTIIMG)
            objParam.Add("PNNCRRDC", oBeDocumento.PNNCRRDC)
            Return Listar("SP_SOLMIN_SA_DOCUMENTO_ALAMCEN_LIST", objParam)
        Catch ex As Exception
            Return New List(Of BeDocumento)
        End Try

    End Function
    Public Function ObtenerCorrelativo(ByVal oBeDocumento As BeDocumento) As Decimal
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", oBeDocumento.PNCCLNT)
            objParam.Add("PSNDOCUM", oBeDocumento.PSNDOCUM)
            objParam.Add("PSTIPODC", oBeDocumento.PSTIPODC)
            objParam.Add("PSCTIIMG", oBeDocumento.PSCTIIMG)
            objParam.Add("PNNCRRDC", 0, ParameterDirection.InputOutput)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_DOCUMENTO_OBTENER_CORRELATIVO", objParam)
            Return objParam.Item(objParam.Count).Value
        Catch ex As Exception
            Return 0
        End Try

    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.BeDocumento)

    End Sub
End Class