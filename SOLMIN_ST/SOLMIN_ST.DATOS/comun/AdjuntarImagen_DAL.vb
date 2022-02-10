Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Public Class AdjuntarImagen_DAL


    Public Sub Actualizar_Numero_Imagen_Liq_Combustible(ByVal objHash As Hashtable)

        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objHash("PSCCMPN"))
        objParam.Add("PNNLQCMB", objHash("PNNLQCMB"))
        objParam.Add("PNNMRGIM", objHash("PNNMRGIM"))
        objParam.Add("PSNTRMNL", objHash("PSNTRMNL"))
        objParam.Add("PSCULUSA", objHash("PSCULUSA"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_NUMERO_IMAGEN_LIQ_COMBUSTIBLE", objParam)
    End Sub

    Public Function Eliminar_Correlativo_Imagen_Liq_Combustible(ByVal objHash As Hashtable) As Boolean
        'Try
        Dim retorno As Boolean = False
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("PNNMRGIM", objHash("PARAM_NMRGIM"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CORRELATIVO_IMAGEN_LIQ_COMBUSTIBLE", objParam)
        retorno = True
        Return retorno
        'Catch ex As Exception
        '    Return False
        'End Try
        'Return True
    End Function


End Class
