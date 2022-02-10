Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Public Class CondicionRuta_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Condicion_Ruta_Combo() As DataTable
        Dim objResultado As New DataTable
        Try
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONDICIONES_RUTA", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

End Class
