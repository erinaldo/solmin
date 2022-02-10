Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class OperacionesXAlquiler_DAL
    Private objSql As New SqlManager
    Public Function Listar_Operacion_X_Alquiler(ByVal objEntidad As OperacionesXAlquiler) As List(Of OperacionesXAlquiler)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of OperacionesXAlquiler)
        Dim objParam As New Parameter

        Try
            'Obteniendo resultados
            objParam.Add("PNNRALQT", objEntidad.NRALQT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_ALQUILER", objParam)


            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New OperacionesXAlquiler
                objDatos.NRALQT = objDataRow("NRALQT")
                objDatos.NCRRRT = objDataRow("NCRRRT")
                objDatos.NRUCTR = objDataRow("NRUCTR")
                objDatos.TCMTRT = objDataRow("TCMTRT")
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.FINCOP_S = HelpClass.CFecha_de_8_a_10(objDataRow("FINCOP").ToString.Trim)
                objDatos.NORSRT = objDataRow("NORSRT").ToString.Trim
                objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
                objDatos.CCLNT_S = objDataRow("CCLNT_S").ToString.Trim
                objDatos.RUTA = objDataRow("CLCLOR_S").ToString.Trim & " - " & objDataRow("CLCLDS_S").ToString.Trim
                objDatos.CLCLOR = objDataRow("CLCLOR")
                objDatos.CLCLOR_S = objDataRow("CLCLOR_S").ToString.Trim
                objDatos.CLCLDS = objDataRow("CLCLDS")
                objDatos.CLCLDS_S = objDataRow("CLCLDS_S").ToString.Trim
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
                objDatos.SESTOP = objDataRow("SESTOP").ToString.Trim
                'objDatos.CCNCST = objDataRow("CCNCST")
                'objDatos.NKMRTA = objDataRow("NKMRTA")
                'objDatos.CRUTA = objDataRow("CRUTA")
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next

            'Procesandolos como una Lista


        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function

    Public Sub Registrar_Operacion_X_Alquiler(ByVal objEntidad As OperacionesXAlquiler)
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNRALQT", objEntidad.NRALQT)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNCCNCST", objEntidad.CCNCST)
            objParam.Add("PNNKMRTA", objEntidad.NKMRTA)
            'objParam.Add("PNCRUTA", objEntidad.CRUTA)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OPERACION_ALQUILER", objParam)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Actualizar_NroAlquiler_Operacion(ByVal objEntidad As OperacionesXAlquiler)
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNRALQT", objEntidad.NRALQT)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_NROALQUILER_X_OPERACION", objParam)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Registrar_Aprobacion_Alquiler(ByVal objEntidad As OperacionesXAlquiler)
        'Try
        Dim objParam As New Parameter

        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSTOBRES", objEntidad.TOBRES)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_APROBAR_ALQUILER_UNIDAD", objParam)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub





End Class
