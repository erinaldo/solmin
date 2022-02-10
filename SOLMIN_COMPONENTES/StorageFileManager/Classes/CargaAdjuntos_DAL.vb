Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Public Class CargaAdjuntos_DAL
    Private objSql As New SqlManager
    Public Function Cargar_Motivo_Adjuntos(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Dim objDataTable As New DataTable

        Dim objParam As New Parameter
        objParam.Add("PSTIPPROC", objCargaAdjuntos.TIPPROC)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_LISTAR_MOTIVO_CARGA_IMAGEN", objParam)
         
        Return objDataTable
    End Function

    Public Function Get_Bucket_AWS() As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_BUCKET_AWS", Nothing)
        'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_BUCKET_AWS_PRUEBA", Nothing)
        Return objDataTable
    End Function

    Public Function Get_Bucket_AWS_APP2021() As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_BUCKET_AWS_APP2021", Nothing)

        Return objDataTable
    End Function


    Public Function Listar_Documentos(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Dim objDataTable As New DataTable

        Dim objParam As New Parameter
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_DOC_LISTAR_DOCUMENTOS", objParam)
       
        Return objDataTable
    End Function


    Public Function crear_carpeta(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Dim dt As New DataTable

        Dim objParam As New Parameter
        objParam.Add("PARAM_DSTIMG", objCargaAdjuntos.DSTIMG)
        objParam.Add("PARAM_TIPODC", objCargaAdjuntos.TIPODC)
        objParam.Add("PARAM_CCLNTO", objCargaAdjuntos.CCLNTO)
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_MMCAPL", objCargaAdjuntos.MMCAPL)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_DOC_AGREGAR_CARPETA", objParam)
        For Each row As DataRow In dt.Rows
            objCargaAdjuntos.NMRGIM = row("NMRGIM").ToString()
            objCargaAdjuntos.STATUS = row("STATUS").ToString()
            objCargaAdjuntos.OBSRESULT = row("OBSRESULT").ToString()
        Next
      
        Return dt
    End Function


   

    Public Function agregar_documento(ByVal objCargaAdjuntos As CargaAdjuntos) As String
        Dim dt As New DataTable
        Dim status As String = ""
        Dim objParam As New Parameter
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_TIPIMG", objCargaAdjuntos.TIPIMG)
        objParam.Add("PARAM_TNMBAR", objCargaAdjuntos.TNMBAR)
        objParam.Add("PARAM_TPFILE", objCargaAdjuntos.TPFILE)
        objParam.Add("PARAM_IMTVIM", objCargaAdjuntos.IMTVIM)
        objParam.Add("PARAM_TOBS", objCargaAdjuntos.TOBS)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_DOC_AGREGAR_DOCUMENTO", objParam)

        If dt.Rows.Count > 0 Then
            status = dt.Rows(0)("STATUS").ToString()
        End If
      
        Return status
    End Function

    Public Sub eliminar_imagenes(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim dt As New DataTable

        Dim objParam As New Parameter
        objParam.Add("PNNMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PNNCRIMG", objCargaAdjuntos.NCRIMG)

       
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_ELIMINAR_IMAGENES", objParam)
      
    End Sub

    Public Sub Eliminar_Relacion_RZSC03(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NRCTSL", objCargaAdjuntos.NRCTSL)
        objParam.Add("PARAM_NRTFSV", objCargaAdjuntos.NRTFSV)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZSC03", objParam)
    End Sub

    Public Sub Guardar_relacion_RZSC03(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NRCTSL", objCargaAdjuntos.NRCTSL)
        objParam.Add("PARAM_NRTFSV", objCargaAdjuntos.NRTFSV)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZSC03", objParam)
    End Sub

    Public Sub Eliminar_Relacion_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NOPRCN", objCargaAdjuntos.NOPRCN)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZTR05", objParam)
    End Sub

    Public Sub Guardar_relacion_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NOPRCN", objCargaAdjuntos.NOPRCN)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZTR05", objParam)
    End Sub


    Public Sub Eliminar_Relacion_RZTR76(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NLQCMB", objCargaAdjuntos.NLQCMB)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZTR76", objParam)
    End Sub

    Public Sub Guardar_relacion_RZTR76(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NLQCMB", objCargaAdjuntos.NLQCMB)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZTR76", objParam)
    End Sub

    Public Sub Eliminar_Relacion_RZST07(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NCSOTR", objCargaAdjuntos.NCSOTR)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZST07", objParam)
    End Sub

    Public Sub Eliminar_Relacion_RZOL65P(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_NROPLT", objCargaAdjuntos.NROPLT)

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZOL65P", objParam)

    End Sub


    Public Sub Eliminar_Relacion_RZOL65I(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_CDVSN", objCargaAdjuntos.CDVSN)
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_CREFFW", objCargaAdjuntos.CREFFW)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZOL65I", objParam)

    End Sub

    Public Sub Eliminar_Relacion_RZOL67(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NRCTRL", objCargaAdjuntos.NRCTRL)

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZOL67", objParam)

    End Sub

    Public Sub Eliminar_Relacion_RZOL65(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_CDVSN", objCargaAdjuntos.CDVSN)
        objParam.Add("PARAM_CPLNDV", objCargaAdjuntos.CPLNDV)
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_CREFFW", objCargaAdjuntos.CREFFW)
        objParam.Add("PARAM_NSEQIN", objCargaAdjuntos.NSEQIN)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)
 

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZOL65", objParam)

    End Sub


    Public Sub Eliminar_Relacion_RZIM36(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_NGUIRM", objCargaAdjuntos.NGUIRM)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZIM36", objParam)

    End Sub


    Public Sub Eliminar_Relacion_RZSC53(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NOPRCN", objCargaAdjuntos.NOPRCN)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZSC53", objParam)
    End Sub


    Public Sub Eliminar_Relacion_RZSC58(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_TPCTRL", objCargaAdjuntos.TPCTRL)
        objParam.Add("PARAM_NRCTRL", objCargaAdjuntos.NRCTRL)

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZSC58", objParam)
    End Sub


    Public Sub Eliminar_Relacion_RZTR31(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NLQDCN", objCargaAdjuntos.NLQDCN)      
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_ELIMINAR_RELACION_IMG_RZTR31", objParam)
    End Sub



    Public Sub Guardar_relacion_RZST07(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NCSOTR", objCargaAdjuntos.NCSOTR)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZST07", objParam)

    End Sub

    Public Sub Guardar_relacion_RZOL65P(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_NROPLT", objCargaAdjuntos.NROPLT)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZOL65P", objParam)
     
    End Sub


    Public Sub Guardar_relacion_RZOL65I(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_CDVSN", objCargaAdjuntos.CDVSN)
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_CREFFW", objCargaAdjuntos.CREFFW)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZOL65I", objParam)

       
    End Sub


    Public Sub Guardar_relacion_RZOL67(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NRCTRL", objCargaAdjuntos.NRCTRL)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZOL67", objParam)

 
    End Sub


    Public Sub Guardar_relacion_RZOL65(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_CDVSN", objCargaAdjuntos.CDVSN)
        objParam.Add("PARAM_CPLNDV", objCargaAdjuntos.CPLNDV)
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_CREFFW", objCargaAdjuntos.CREFFW)
        objParam.Add("PARAM_NSEQIN", objCargaAdjuntos.NSEQIN)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)

        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZOL65", objParam)


 

    End Sub


    Public Sub Guardar_relacion_RZIM36(ByVal objCargaAdjuntos As CargaAdjuntos)

        Dim objParam As New Parameter     
        objParam.Add("PARAM_CCLNT", objCargaAdjuntos.CCLNT)
        objParam.Add("PARAM_NGUIRM", objCargaAdjuntos.NGUIRM)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objParam.Add("PARAM_CUSCRT", objCargaAdjuntos.CUSCRT)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZIM36", objParam)

    End Sub


    Public Sub Guardar_relacion_RZSC53(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NROVLR", objCargaAdjuntos.NROVLR)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZSC53", objParam)
    End Sub

    Public Sub Guardar_relacion_RZSC58(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_TPCTRL", objCargaAdjuntos.TPCTRL)
        objParam.Add("PARAM_NRCTRL", objCargaAdjuntos.NRCTRL)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZSC58", objParam)

    End Sub


    Public Sub Guardar_relacion_RZTR31(ByVal objCargaAdjuntos As CargaAdjuntos)
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NLQDCN", objCargaAdjuntos.NLQDCN)
        objParam.Add("PARAM_NMRGIM", objCargaAdjuntos.NMRGIM)
        objSql.ExecuteNonQuery("SP_SOLMIN_CTZ_DOC_GUARDAR_RELACION_IMG_RZTR31", objParam)

    End Sub



    Public Function Listar_Documentos_List_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        objParam.Add("PARAM_NOPRCN", objCargaAdjuntos.NOPRCN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CTZ_DOC_LISTAR_DOCUMENTOS_RZTR05_LIST", objParam)
        Return objDataTable

    End Function





End Class
