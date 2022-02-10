Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsRubroXDivision
    Private oRubroXDivision As SOLMIN_CTZ.DATOS.clsRubroXDivision

    Sub New()
        oRubroXDivision = New SOLMIN_CTZ.DATOS.clsRubroXDivision
    End Sub

    Public Sub Agregar_Rubro_Division(ByRef oSqlMan As SqlManager, ByVal pobjRubro_X_Division As Rubro_X_Division)
        Try
            oRubroXDivision.Agregar_Rubro_Division(oSqlMan, pobjRubro_X_Division)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
