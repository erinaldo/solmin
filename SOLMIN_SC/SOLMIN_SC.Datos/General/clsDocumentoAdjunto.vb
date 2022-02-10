Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsDocumentoAdjunto

    Public Function Lista_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeDocumentoAdjunto.PNCCLNT)
        lobjParams.Add("PNNRPEMB", obeDocumentoAdjunto.PNNRPEMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DOC_ADJUNTOS_X_PREEMBARQUE", lobjParams)
        Return dt
    End Function
    Public Function Lista_Documentos_x_OrdenCompraParcial(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeDocumentoAdjunto.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeDocumentoAdjunto.PNCCLNT)
        lobjParams.Add("PSNORCML", obeDocumentoAdjunto.PSNORCML)
        lobjParams.Add("PNNRPARC", obeDocumentoAdjunto.PNNRPARC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DOC_ADJUNTOS_X_ORDEN_COMPRA_PARCIAL", lobjParams)
        Return dt
    End Function

    Public Function Elimina_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As Int32
        Dim retorno As Integer = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeDocumentoAdjunto.PNCCLNT)
        lobjParams.Add("PNNRPEMB", obeDocumentoAdjunto.PNNRPEMB)
        lobjParams.Add("PNNCRRDC", obeDocumentoAdjunto.PNNCRRDC)
        lobjParams.Add("PSCULUSA", obeDocumentoAdjunto.PSCULUSA)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_DOC_ADJUNTOS_X_PREEMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function
    Public Function Insertar_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As Int32
        Dim retorno As Integer = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
       

        lobjParams.Add("PNCCLNT", obeDocumentoAdjunto.PNCCLNT)
        lobjParams.Add("PNNRPEMB", obeDocumentoAdjunto.PNNRPEMB)
        lobjParams.Add("PSCTIIMG", obeDocumentoAdjunto.PSCTIIMG)
        lobjParams.Add("PSTNMBAR", obeDocumentoAdjunto.PSTNMBAR)
        lobjParams.Add("PSURLARC", obeDocumentoAdjunto.PSURLARC)
        lobjParams.Add("PSCULUSA", obeDocumentoAdjunto.PSCULUSA)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTAR_DOC_ADJUNTOS_X_PREEMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function




End Class
