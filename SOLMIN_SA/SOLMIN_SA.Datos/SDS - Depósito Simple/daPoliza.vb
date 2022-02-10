Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daPoliza

    Inherits daBase(Of bePoliza)
    Private objSql As New SqlManager

    Public Function ListarPoliza(ByVal obePoliza As bePoliza) As List(Of bePoliza)
        Dim oDt As New DataTable
        Dim olbebeSerie As New List(Of bePoliza)
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_NPDDPR", obePoliza.PNNPDDPR)
            End With
            Return Listar("SP_SOLMIN_SA_LISTA_POLIZA", objParam)

        Catch ex As Exception
            Return olbebeSerie
        End Try

    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.bePoliza)

    End Sub
End Class