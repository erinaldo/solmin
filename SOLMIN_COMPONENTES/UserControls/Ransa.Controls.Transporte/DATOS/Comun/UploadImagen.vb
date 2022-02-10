Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class UploadImagen
    Private objSql As New SqlManager

    Public Function EliminaRelacionImagenRZST48_Requerimiento(ByVal NMRGIM As String, ByVal NUMREQT As String, ByVal CCMPN As String) As Boolean
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNMRGIM", NMRGIM)
            objParam.Add("PNNUMREQT", NUMREQT)
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ELIMINA_RZST48_DOC_REQ", objParam)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GuardarRelacionImagenRZST48_Requerimiento(ByVal NMRGIM As String, ByVal NUMREQT As String, ByVal CCMPN As String) As Boolean
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNMRGIM", NMRGIM)
            objParam.Add("PNNUMREQT", NUMREQT)
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_DOC_ACTUALIZA_RZST48_DOC_REQ", objParam)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class