Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsUploadImagen
    Public Function GuardarEnTabla(ByVal objParams As Hashtable) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNNRCTSL", objParams("PARAM_NRCTSL"))
            objparam.Add("PNNMRGIM", objParams("PARAM_NMRGIM"))
            objparam.Add("PSUSUARIO", objParams("PARAM_USUARIO"))
            objSql.ExecuteNonQuery("SP_SOLMIN_SD_ACTUALIZAR_CONTRATO_NUMERO_IMAGEN", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function EliminaRelacion(ByVal objParams As Hashtable) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PARAM_NMRGIM", objParams("PARAM_NMRGIM"))
            objSql.ExecuteNonQuery("SP_SOLMIN_SD_DOC_ELIMINA_NUMERO_CARPETA_RZSC01", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function
End Class
