Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsUploadImagen
    Public Function GuardarEnTabla(ByVal objParams As Hashtable) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PSCCMPN", objParams("PARAM_CCMPN"))
            objparam.Add("PSCDVSN", objParams("PARAM_CDVSN"))
            objparam.Add("PNCPLNDV", objParams("PARAM_CPLNDV"))
            objparam.Add("PNCCLNT", objParams("PARAM_CCLNT"))
            objparam.Add("PSCREFFW", objParams("PARAM_CREFFW"))
            objparam.Add("PNNMRGIM", objParams("PARAM_NMRGIM"))
            objparam.Add("PSUSUARIO", objParams("PARAM_USUARIO"))
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_BULTO_NUMERO_IMAGEN", objparam)
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
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZOL65", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function


    Public Function GuardarEnTablaGuiaRemision(ByVal objParams As Hashtable) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNCCLNT", objParams("PARAM_CCLNT"))
            objparam.Add("PNNGUIRM", objParams("PARAM_NGUIRM"))
            objparam.Add("PNNMRGIM", objParams("PARAM_NMRGIM"))
            objparam.Add("PSUSUARIO", objParams("PARAM_USUARIO"))
            objSql.ExecuteNonQuery("SP_SOLMIN_SD_ACTUALIZAR_GUIA_NUMERO_IMAGEN", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function EliminaRelacionImagenGuia(ByVal objParams As Hashtable) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PARAM_NMRGIM", objParams("PARAM_NMRGIM"))
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZIM36", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function


End Class
