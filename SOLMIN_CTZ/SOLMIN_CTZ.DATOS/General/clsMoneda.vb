Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsMoneda
    Inherits clsBase(Of Moneda)

    Public Function Lista_Moneda() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_MONEDA", Nothing)
        Return dt
    End Function

    Public Function Listar_Moneda() As List(Of Moneda)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As DataTable
        Dim objEntidad As Moneda
        Dim lbeMoneda As New List(Of Moneda)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_MONEDA", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New Moneda
            objEntidad.CMNDA1 = objDataRow("CMNDA1")
            objEntidad.TMNDA = objDataRow("TMNDA").ToString.Trim()
            objEntidad.TSGNMN = objDataRow("TSGNMN").ToString.Trim()
            lbeMoneda.Add(objEntidad)
        Next
        Return lbeMoneda
    End Function
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As Entidades.Moneda)

    End Sub

End Class
