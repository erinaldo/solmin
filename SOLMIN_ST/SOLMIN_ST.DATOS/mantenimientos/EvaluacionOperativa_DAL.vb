Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Namespace mantenimientos
    Public Class EvaluacionOperativa_DAL

        Private objSql As New SqlManager

        Public Function Listar_categorias(ByVal Tpcategoria As Integer, ByVal CCMPN As String) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNTIPCAT", Tpcategoria)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CATEGORIA_EVA", objParam)
            Return dt
        End Function

        Public Function Listar_categorias2(ByVal Entidad As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim objdatatable As New DataTable
            Dim objGenericCollection As New DataTable
            objGenericCollection.Columns.Add("CODIGO")
            objGenericCollection.Columns.Add("DESCRIP")
            'Insertamos parametros
            objParam.Add("PNTIPCAT", Entidad.TIPCAT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Entidad.CCMPN)
            objdatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CATEGORIA_EVA", objParam)
            'Traemos la Data 
            For Each objDataRow As DataRow In objdatatable.Rows
                objGenericCollection.Rows.Add(objDataRow("CODSCT"), objDataRow("DESSCT").ToString.Trim)
            Next
            Return objGenericCollection
        End Function

        Public Function Listar_Subcategorias(ByVal PNTIPCAT As Integer, ByVal PNCODCAT As Integer, ByVal CCMPN As String) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNTIPCAT", PNTIPCAT)
            objParam.Add("PNCODCAT", PNCODCAT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SUB_CATEGORIA_EVA", objParam)

            Return dt
        End Function


        Public Function Listar_Subcategorias2(ByVal Entidad As EvaluacionOperativa) As DataTable

            Dim objParam As New Parameter
            Dim objdatatable As New DataTable
            Dim objGenericCollection As New DataTable
            objGenericCollection.Columns.Add("CODIGO")
            objGenericCollection.Columns.Add("DESCRIP")

            objParam.Add("PNTIPCAT", Entidad.TIPCAT)
            objParam.Add("PNCODCAT", Entidad.CODCAT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Entidad.CCMPN)
            objdatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SUB_CATEGORIA_EVA", objParam)
            For Each objDataRow As DataRow In objdatatable.Rows
                objGenericCollection.Rows.Add(objDataRow("CODSCT"), objDataRow("DESSCT").ToString.Trim)
            Next
            Return objGenericCollection
        End Function


        Public Function Listar_Evaluacion_Operativa(ByVal objEntidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Dim objDataSet As New DataSet
            Dim objGenericCollection As New List(Of EvaluacionOperativa)

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EVA_OP_INCIDENCIA", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New EvaluacionOperativa
                objDatos.NSEQIN = objDataRow("NSEQIN")
                objDatos.CCMPN = objDataRow("CCMPN")
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR")
                objDatos.CODCAT = objDataRow("CODCAT")
                objDatos.DESCAT = objDataRow("DESCAT").ToString.Trim
                objDatos.FACCAT = objDataRow("FACCAT")
                objDatos.CODSCT = objDataRow("CODSCT")
                objDatos.DESSCT = objDataRow("DESSCT").ToString.Trim
                objDatos.FACSCT = objDataRow("FACSCT")
                objDatos.FOPRCN_S = HelpClass.FechaNum_a_Fecha(objDataRow("FOPRCN"))
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.NGUITR = objDataRow("NGUITR")
                objDatos.QAINSM = objDataRow("QAINSM")
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.FCHCRT_S = HelpClass.FechaNum_a_Fecha(objDataRow("FCHCRT"))
                objDatos.HRACRT_S = IIf(objDataRow("HRACRT").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HRACRT")), "")
                objDatos.CUSCRT = objDataRow("CUSCRT")
                objDatos.CULUSA = objDataRow("CULUSA")
                objDatos.FULTAC_S = HelpClass.FechaNum_a_Fecha(objDataRow("FULTAC"))
                objDatos.HULTAC_S = IIf(objDataRow("HULTAC").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HULTAC")), "")

                objGenericCollection.Add(objDatos)
            Next

            'Procesandolos como una Lista

            Return objGenericCollection
        End Function

        Public Sub Registrar_Evaluacion_Operacion(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PNCODCAT", objEntidad.CODCAT)
                objParam.Add("PNCODSCT", objEntidad.CODSCT)
                objParam.Add("PNFOPRCN", objEntidad.FOPRCN)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNGUITR", objEntidad.NGUITR)
                objParam.Add("PNQAINSM", objEntidad.QAINSM)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("USUARIO", objEntidad.CUSCRT)
                objParam.Add("PSNTRMNL", objEntidad.NTRMCR)
               
                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_EVA_OP_INCIDENCIA", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Eliminar_Evaluacion_Operacion(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNSEQIN", objEntidad.NSEQIN)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("USUARIO", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_EVA_OP_INCIDENCIA", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Actualizar_Evaluacion_Operacion(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNSEQIN", objEntidad.NSEQIN)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)

                objParam.Add("PNCODCAT", objEntidad.CODCAT)
                objParam.Add("PNCODSCT", objEntidad.CODSCT)
                objParam.Add("PNFOPRCN", objEntidad.FOPRCN)
                objParam.Add("PNQAINSM", objEntidad.QAINSM)
                objParam.Add("PSTOBS", objEntidad.TOBS)

                objParam.Add("USUARIO", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_EVA_OP_INCIDENCIA", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function LISTAR_EVA_OP_CONSULTA(ByVal objEntidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Dim objDataTable As New DataTable
            Dim objDataSet As New DataSet
            Dim objGenericCollection As New List(Of EvaluacionOperativa)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCRGVTA", objEntidad.CRGVTA)
            objParam.Add("PSANIO", objEntidad.ANIO)
            objParam.Add("PSANIOMES", objEntidad.MESES)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PNCODCAT", objEntidad.CODCAT)
            objParam.Add("PNCODSCT", objEntidad.CODSCT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EVA_OP_CONSULTA", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New EvaluacionOperativa
                objDatos.NSEQIN = objDataRow("NSEQIN")
                objDatos.CRGVTA = objDataRow("CRGVTA")
                objDatos.TCRVTA = objDataRow("TCRVTA")
                objDatos.CCMPN = objDataRow("CCMPN")
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR")
                objDatos.CODCAT = objDataRow("CODCAT")
                objDatos.DESCAT = objDataRow("DESCAT").ToString.Trim
                objDatos.FACCAT = objDataRow("FACCAT")
                objDatos.CODSCT = objDataRow("CODSCT")
                objDatos.DESSCT = objDataRow("DESSCT").ToString.Trim
                objDatos.FACSCT = objDataRow("FACSCT")
                objDatos.FOPRCN_S = HelpClass.FechaNum_a_Fecha(objDataRow("FOPRCN"))
                objDatos.NOPRCN = objDataRow("NOPRCN")
                objDatos.NGUITR = objDataRow("NGUITR")
                objDatos.QAINSM = objDataRow("QAINSM")
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.FCHCRT_S = HelpClass.FechaNum_a_Fecha(objDataRow("FCHCRT"))
                objDatos.HRACRT_S = IIf(objDataRow("HRACRT").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HRACRT")), "")
                objDatos.CUSCRT = objDataRow("CUSCRT")
                objDatos.CULUSA = objDataRow("CULUSA")
                objDatos.FULTAC_S = HelpClass.FechaNum_a_Fecha(objDataRow("FULTAC"))
                objDatos.HULTAC_S = IIf(objDataRow("HULTAC").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HULTAC")), "")


                objGenericCollection.Add(objDatos)
            Next

            'Procesandolos como una Lista

            Return objGenericCollection
        End Function


#Region "EVALUACION ADMINISTRATIVA"

        Public Function LISTAR_EVA_ADMIN_CONSULTA(ByVal objEntidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Dim objDataTable As New DataTable
            Dim objDataSet As New DataSet
            Dim objGenericCollection As New List(Of EvaluacionOperativa)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCRGVTA", objEntidad.CRGVTA)
            objParam.Add("PSANIO", objEntidad.ANIO)
            objParam.Add("PSMES", objEntidad.MESES)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PNCODCAT", objEntidad.CODCAT)
            objParam.Add("PNCODSCT", objEntidad.CODSCT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EVA_ADMIN_CONSULTA", objParam)


            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New EvaluacionOperativa
                objDatos.NSEQIN = objDataRow("NSEQIN")
                objDatos.CCMPN = objDataRow("CCMPN")
                objDatos.CRGVTA = objDataRow("CRGVTA")
                objDatos.TCRVTA = objDataRow("TCRVTA")
                objDatos.NRUCTR = objDataRow("NRUCTR")
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.CODCAT = objDataRow("CODCAT")
                objDatos.DESCAT = objDataRow("DESCAT").ToString.Trim
                objDatos.FACCAT = objDataRow("FACCAT")
                objDatos.CODSCT = objDataRow("CODSCT")
                objDatos.DESSCT = objDataRow("DESSCT").ToString.Trim
                objDatos.FACSCT = objDataRow("FACSCT")
                objDatos.ANIO = objDataRow("ANOALF")
                objDatos.ANIOMES = objDataRow("MESALF")
                objDatos.QAINSM = objDataRow("QAINSM")
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.NOMMES = objDataRow("NOMMES").ToString.Trim
                'objDatos.FCHCRT_S = HelpClass.FechaNum_a_Fecha(objDataRow("FCHCRT"))
                'objDatos.HRACRT_S = IIf(objDataRow("HRACRT").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HRACRT")), "")
                'objDatos.CUSCRT = objDataRow("CUSCRT")
                'objDatos.CULUSA = objDataRow("CULUSA")
                'objDatos.FULTAC_S = HelpClass.FechaNum_a_Fecha(objDataRow("FULTAC"))
                'objDatos.HULTAC_S = IIf(objDataRow("HULTAC").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HULTAC")), "")


                objGenericCollection.Add(objDatos)
            Next


            Return objGenericCollection
        End Function

        Public Sub INSERTAR_EVA_ADMIN(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCRGVTA", objEntidad.CRGVTA)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PNCODCAT", objEntidad.CODCAT)
                objParam.Add("PNCODSCT", objEntidad.CODSCT)
                objParam.Add("PNANOALF", objEntidad.ANIO)
                objParam.Add("PNMESALF", objEntidad.ANIOMES)
                objParam.Add("PNQAINSM", objEntidad.QAINSM)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("USUARIO", objEntidad.CUSCRT)
                objParam.Add("PSNTRMNL", objEntidad.NTRMCR)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_EVA_ADMIN", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Public Sub ACTUALIZAR_EVA_ADMIN(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNSEQIN", objEntidad.NSEQIN)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)

                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)

                objParam.Add("PNCODCAT", objEntidad.CODCAT)
                objParam.Add("PNCODSCT", objEntidad.CODSCT)

                objParam.Add("PNANOALF", objEntidad.ANIO)
                objParam.Add("PNMESALF", objEntidad.ANIOMES)

                objParam.Add("PNQAINSM", objEntidad.QAINSM)
                objParam.Add("PSTOBS", objEntidad.TOBS)

                objParam.Add("USUARIO", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_EVA_ADMIN", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub ELIMINAR_EVA_ADMIN(ByVal objEntidad As EvaluacionOperativa)
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNSEQIN", objEntidad.NSEQIN)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("USUARIO", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_EVA_ADMIN", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
#End Region


#Region "EVALUACION FINAL"
        Public Function LISTAR_EVA_FINAL_CONSULTA(ByVal objEntidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)

            Dim objDataTable As New DataTable
            Dim objDataSet As New DataSet
            Dim objGenericCollection As New List(Of EvaluacionOperativa)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCRGVTA", objEntidad.CRGVTA)
            objParam.Add("PNANIO", objEntidad.ANIO)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSANIOMES", objEntidad.MESES)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_EVALUACION_FINAL", objParam)

            Dim view As DataView = New DataView(objDataTable)

            ' Lo ordenamos por el campo Nombre.
            '
            view.Sort = "MESALF"


            For Each objDataRow As DataRowView In view
                Dim objDatos As New EvaluacionOperativa

                objDatos.NRUCTR = objDataRow("NRUCTR")
                objDatos.ANIO = objDataRow("ANOALF")
                objDatos.MES = objDataRow("MESALF")
                objDatos.TCMTRT = objDataRow("TCMTRT")
                objDatos.NOMMES = objDataRow("NOMMES")
                'objDatos.S_EVAOP = IIf(DBNull.Value.Equals(objDataRow("ENVOPER")), "", objDataRow("ENVOPER").ToString.Trim)
                'objDatos.S_EVAADM = IIf(DBNull.Value.Equals(objDataRow("EVAADM")), "", objDataRow("EVAADM").ToString.Trim)
                'objDatos.S_EVAFIN = IIf(DBNull.Value.Equals(objDataRow("EVAFINAL")), "", objDataRow("EVAFINAL").ToString.Trim)
                If objDataRow("ENVOPER") IsNot DBNull.Value Then
                    objDatos.S_EVAOP = Math.Round(objDataRow("ENVOPER"), 2).ToString.Trim
                End If

                If objDataRow("EVAADM") IsNot DBNull.Value Then
                    objDatos.S_EVAADM = Math.Round(objDataRow("EVAADM"), 2).ToString.Trim
                End If
                If objDataRow("EVAFINAL") IsNot DBNull.Value Then
                    objDatos.S_EVAFIN = Math.Round(objDataRow("EVAFINAL"), 2).ToString.Trim
                End If

                'objDatos.EVAOP = IIf(DBNull.Value.Equals(objDataRow("ENVOPER")), 0, objDataRow("ENVOPER"))
                'objDatos.EVAADM = IIf(DBNull.Value.Equals(objDataRow("EVAADM")), 0, objDataRow("EVAADM"))
                'objDatos.EVAFIN = IIf(DBNull.Value.Equals(objDataRow("EVAFINAL")), 0, objDataRow("EVAFINAL"))
                objGenericCollection.Add(objDatos)
            Next

            'Procesandolos como una Lista

            Return objGenericCollection

        End Function
#End Region

#Region "Exportar a Excel Ovaluacion Eperativa"

        Public Function Listar_CategoriasExcel(ByVal Tpcategoria As Integer, ByVal CCMPN As String) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNTIPCAT", Tpcategoria)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_CATGEROIA_SUBCATEGORIA", objParam)
            Return dt
        End Function

        Public Function INCIDENCIAS_CATEGORIA_PROVEEDOR(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCRGVTA", beFiltro.CRGVTA)
            objParam.Add("PSANIOMES", beFiltro.MESES)
            objParam.Add("PSNRUCTR", beFiltro.NRUCTR)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beFiltro.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_INCIDENCIAS_CATEGORIA_PROVEEDOR", objParam)
            Return dt
        End Function

        Public Function VIAJES_KILOMETROS_PROVEEDOR(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", beFiltro.CCMPN)
            objParam.Add("PSCRGVTA", beFiltro.CRGVTA)
            objParam.Add("PSANIOMES", beFiltro.MESES)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beFiltro.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VIAJES_KILOMETROS_PROVEEDOR", objParam)
            Return dt
        End Function
#End Region


#Region "Exportar a Excel Evaluacion Administrativa"


        Public Function PROVEEDORES_EVA_ADMIN_MES(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", beFiltro.CCMPN)
            objParam.Add("PSCRGVTA", beFiltro.CRGVTA)
            objParam.Add("PNANOALF", beFiltro.ANIO)
            objParam.Add("PNMESALF", beFiltro.MESES)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beFiltro.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROVEEDORES_EVA_ADMIN_MES", objParam)
            Return dt
        End Function

        Public Function PROVEEDORES_PERIODO(ByVal ANIOMES As Integer, ByVal CCMPN As String) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSANIOMES", ANIOMES)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROVEEDORES_PERIODO", objParam)
            Return dt
        End Function

        Public Function EVALUACION_ADMINISTRATIVA_MES(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSANIO", beFiltro.ANIO)
            objParam.Add("PSCRGVTA", beFiltro.CRGVTA)
            objParam.Add("PSMES", beFiltro.MESES)
            objParam.Add("PSNRUCTR", beFiltro.NRUCTR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(beFiltro.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_EVALUACION_ADMINISTRATIVA_MES", objParam)
            Return dt
        End Function

#End Region


#Region "Exportar a Excel Evaluacion Final"
        Public Function EVA_FINAL_MES(ByVal objEntidad As EvaluacionOperativa) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCRGVTA", objEntidad.CRGVTA)
            objParam.Add("PNANIO", objEntidad.ANIO)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSANIOMES", objEntidad.MESES)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_EVALUACION_FINAL", objParam)

            Return dt

        End Function
#End Region
    End Class

End Namespace
