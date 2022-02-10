Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Public Class Naves_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Naves() As DataTable
        Dim objResultado As New DataTable
        Try
            'Obtiene el resultado
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_NAVES", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

End Class
