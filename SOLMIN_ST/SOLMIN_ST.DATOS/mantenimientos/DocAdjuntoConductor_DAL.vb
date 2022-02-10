Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class DocAdjuntoConductor_DAL

    Private objSql As New SqlManager

    Public Function Listar_Documentos_Adjuntos(ByVal ht As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCBRCNT", ht("CBRCNT"))
        objParam.Add("PNNCRRDC", ht("NCRRDC"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOC_ADJUNTO_CONDUCTOR", objParam)
        Return objDataTable
        'Catch ex As Exception
        '    Return New Data.DataTable
        'End Try
    End Function

    Public Function Registrar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
        'Try
        Dim objParam As New Parameter

        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PNNCRRDC", objEntidad.NCRRDC)
        objParam.Add("PSCTIIMG", objEntidad.CTIIMG)
        objParam.Add("PSCLINK", objEntidad.CLINK)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GUARDAR_DOC_ADJUNTO_CONDUCTOR", objParam)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    objEntidad.CBRCNT = "0"
        'End Try

        Return objEntidad
    End Function

    Public Function Modificar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNCOIMG", objEntidad.CLINK)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_DOC_ADJUNTO_CONDUCTOR", objParam)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    objEntidad.CBRCNT = "0"
        'End Try

        Return objEntidad
    End Function

    Public Function Eliminar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNCOIMG", objEntidad.NCOIMG)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_DOC_ADJUNTO_CONDUCTOR", objParam)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    objEntidad.CBRCNT = "0"
        'End Try

        Return objEntidad
    End Function

    Public Function Modificar_Documento_Adjunto_Obs(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNCOIMG", objEntidad.NCOIMG)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_DOC_ADJUNTO_CONDUCTOR_OBS", objParam)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    objEntidad.CBRCNT = "0"
        'End Try

        Return objEntidad
    End Function

    Public Function Listar_Documentos_Adjuntos_Rpt(ByVal ht As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCBRCNT", ht("CBRCNT"))
        objParam.Add("PNNCRRDC", ht("NCRRDC"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOC_ADJUNTO_CONDUCTOR_RPT", objParam)
        Return objDataTable
        'Catch ex As Exception
        '    Return New Data.DataTable
        'End Try
    End Function

End Class
