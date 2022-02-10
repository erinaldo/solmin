Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace mantenimientos
    Public Class DuracionDias_DAL

        Private objSql As New SqlManager
        Public Function Listar(objEntidad As DuracionDias) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of DuracionDias)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DURACIONDIAS", objParam)
            Return objDataTable
        End Function

        Public Function Nuevo(ByVal objEntidad As DuracionDias) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msgError As String = ""
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_QDSEST", objEntidad.QDSEST)
            objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
            objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_DURACIONDIAS", objParam)

            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "E" Then
                    msgError = msgError & Item("OBSRESULT") & Chr(13)
                End If

            Next
            Return msgError.Trim
        End Function

        Public Sub Editar(ByVal objEntidad As DuracionDias)
            Dim objParam As New Parameter
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_NCRRDT", objEntidad.NCRRDT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_QDSEST", objEntidad.QDSEST)
            objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
            objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_DURACIONDIAS", objParam)

        End Sub


        Public Sub Eliminar(ByVal objEntidad As DuracionDias)
            Dim objParam As New Parameter
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_NCRRDT", objEntidad.NCRRDT)
            objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
            objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_DURACIONDIAS", objParam)

        End Sub

        'Public Function Obtener(ByVal objEntidad As DuracionDias) As DuracionDias
        '    Dim objParam As New Parameter
        '    objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        '    objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        '    objParam.Add("PARAM_NCRRDT", objEntidad.NCRRDT)
        '    Return objSql.getStatement(Of DuracionDias)("SP_SOLMIN_ST_OBTENER_DURACIONDIAS", objParam).Item(0)
        'End Function

        'Public Function ListarDuracionDias_x_Cliente(ByVal objEntidad As DuracionDias) As List(Of DuracionDias)
        '    Dim objParam As New Parameter
        '    objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        '    objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        '    objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
        '    objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
        '    objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)

        '    Return objSql.getStatement(Of DuracionDias)("SP_SOLMIN_ST_OBTENER_DURACIONDIAS_X_CLIENTE", objParam)
        'End Function
        Public Function ListarDuracionDias_x_Cliente(ByVal objEntidad As DuracionDias) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_DURACIONDIAS_X_CLIENTE", objParam)
            Return dt
        End Function

    End Class

End Namespace