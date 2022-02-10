Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Public Class DocAjuntoAWS_DAL

    Public Function Get_Nro_Imagen_RZTR05(ByVal beImagen As DocAjuntoAWS) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", beImagen.CCMPN)
        lobjParams.Add("PNNOPRCN", beImagen.NOPRCN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZTR05", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If

        Return NroImg
    End Function

End Class
