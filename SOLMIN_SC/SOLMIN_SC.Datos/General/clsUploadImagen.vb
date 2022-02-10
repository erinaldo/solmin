Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsUploadImagen
  

    Public Function GuardarRelacionImagenRZOL39P_PreEmbarque(ByVal obeCabImagen As beCabImagen, ByVal PNNRPEMB As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Dim objSql As New SqlManager
        Dim objparam As New Parameter
        objparam.Add("PNNMRGIM", obeCabImagen.PNNMRGIM)
        objparam.Add("PNNRPEMB", PNNRPEMB)
        objparam.Add("PNCCLNT", obeCabImagen.PNCCLNT)
        objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ACTUALIZA_RZOL39P_LM", objparam)
        lbool_resultado = True
        Return lbool_resultado
    End Function

    Public Function EliminaRelacionImagenRZOL39P_PreEmbarque(ByVal PNNMRGIM As Decimal, ByVal PNNRPEMB As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNNMRGIM", PNNMRGIM)
            objparam.Add("PNNRPEMB", PNNRPEMB)
            objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZOL39P", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

 
    Public Function GuardarRelacionImagenRZOL53_Embarque_Doc(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Dim objSql As New SqlManager
        Dim objparam As New Parameter
        objparam.Add("PNNMRGIM", obeCabImagen.PNNMRGIM)
        objparam.Add("PNNORSCI", PNNORSCI)
        objparam.Add("PNNDOCIN", PNNDOCIN)
        objparam.Add("PNNCRRDC", PNNCRRDC)
        objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ACTUALIZA_RZOL53_DOC_EMBARQUE", objparam)
        lbool_resultado = True
        Return lbool_resultado
    End Function

    Public Function EliminaRelacionImagenRZOL53_Embarque_Doc(ByVal PNNMRGIM As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNNMRGIM", PNNMRGIM)
            objparam.Add("PNNORSCI", PNNORSCI)
            objparam.Add("PNNDOCIN", PNNDOCIN)
            objparam.Add("PNNCRRDC", PNNCRRDC)
            objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZOL53_DOC_EMBARQUE", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function GuardarRelacionImagenRZOL53C_Embarque_Costos(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Dim objSql As New SqlManager
        Dim objparam As New Parameter
        objparam.Add("PNNMRGIM", obeCabImagen.PNNMRGIM)
        objparam.Add("PNNORSCI", PNNORSCI)
        objparam.Add("PNNDOCIN", PNNDOCIN)
        objparam.Add("PNNCRRDC", PNNCRRDC)
        objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ACTUALIZA_RZOL53C_COSTOS", objparam)
        lbool_resultado = True
        Return lbool_resultado
    End Function

    Public Function EliminaRelacionImagenRZOL53C_Embarque_Costos(ByVal PNNMRGIM As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNNMRGIM", PNNMRGIM)
            objparam.Add("PNNORSCI", PNNORSCI)
            objparam.Add("PNNDOCIN", PNNDOCIN)
            objparam.Add("PNNCRRDC", PNNCRRDC)
            objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZOL53C_COSTOS", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function GuardarRelacionImagenRZOL42C_Costos_X_Embarque(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Boolean
        Dim lbool_resultado As Boolean = False
        Dim objSql As New SqlManager
        Dim objparam As New Parameter
        objparam.Add("PNNMRGIM", obeCabImagen.PNNMRGIM)
        objparam.Add("PNNORSCI", PNNORSCI)
        objparam.Add("PSCODVAR", PSCODVAR)
        objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZA_RZOL42C_COSTO_EMBARQUE", objparam)
        lbool_resultado = True
        Return lbool_resultado
    End Function


    Public Function EliminaRelacionImagenRZOL42C_Costos_X_Embarque(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Boolean
        Dim lbool_resultado As Boolean = False
        Try
            Dim objSql As New SqlManager
            Dim objparam As New Parameter
            objparam.Add("PNNORSCI", PNNORSCI)
            objparam.Add("PSCODVAR", PSCODVAR)
            objparam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_NUMERO_CARPETA_RZOL42C_COSTOS_EMBARQUE", objparam)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

End Class
