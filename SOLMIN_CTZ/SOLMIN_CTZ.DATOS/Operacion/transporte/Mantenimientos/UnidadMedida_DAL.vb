
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Public Class UnidadMedida_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Unidad_Medida_Combo(ByVal strCompania As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

End Class
