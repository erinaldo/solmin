Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

    Public Class daSerie

    Inherits daBase(Of beSeries)
    Private objSql As New SqlManager

    Public Function ListarSerie(ByVal obeSerie As beSeries) As List(Of beSeries)
        Dim oDt As New DataTable
        Dim olbebeSerie As New List(Of beSeries)
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_NPDDPR", obeSerie.PNNPDDPR)
            End With
            Return Listar("SP_SOLMIN_SA_LISTA_SERIE", objParam)

        Catch ex As Exception
            Return olbebeSerie
        End Try

    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beSeries)

    End Sub
    End Class
