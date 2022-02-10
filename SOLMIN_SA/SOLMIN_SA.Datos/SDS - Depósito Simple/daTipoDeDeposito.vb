Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daTipoDeDeposito
    Inherits daBase(Of beTipoDeDeposito)

    Private objSql As New SqlManager

    Public Function ListarTipoDeDeposito() As List(Of beTipoDeDeposito)
        Dim olbebeTipoDeDeposito As New List(Of beTipoDeDeposito)
        Dim objParam As New Parameter
        'Try
        Return Listar("SP_SOLMIN_SA_SDS_LISTA_TIPO_DE_DEPOSITO")
        'Catch ex As Exception
        'End Try
        'Return olbebeTipoDeDeposito
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub


    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beTipoDeDeposito)

    End Sub
End Class