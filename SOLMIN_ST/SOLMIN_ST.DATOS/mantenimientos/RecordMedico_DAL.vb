Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 15/07/2009 
'** Descripción: capa de acceso a RECORD MEDICO.
'****************************************************************************************************
Namespace mantenimientos

    Public Class RecordMedico_DAL

        Private objSql As New SqlManager

        Public Function Registrar_Record_Medico(ByVal objEntidad As RecordMedico) As RecordMedico
            'Try
            Dim objParam As New Parameter

            objParam.Add("PON_NCORMD", objEntidad.NCORMD, ParameterDirection.Output)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNFECREG", objEntidad.FECREG)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PNNCOVAC", objEntidad.NCOVAC)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objParam.Add("NEW_NCOVAC", objEntidad.NEW_NCOVAC)
            objParam.Add("OLD_PNFECINI", objEntidad.FECINI)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_RECORD_MEDICO_V2", objParam)

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

            Return objEntidad
        End Function

        Public Function Modificar_Record_Medico(ByVal objEntidad As RecordMedico) As RecordMedico

            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNCORMD", objEntidad.NCORMD)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNFECREG", objEntidad.FECREG)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PNNCOVAC", objEntidad.NCOVAC)
            objParam.Add("PSCULUSA ", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_RECORD_MEDICO", objParam)

            'Catch ex As Exception
            '    objEntidad.NCORMD = 0
            'End Try

            Return objEntidad
        End Function

        Public Function Eliminar_Record_Medico(ByVal objEntidad As RecordMedico)

            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNCORMD", objEntidad.NCORMD)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_RECORD_MEDICO", objParam)

            'Catch ex As Exception
            '    objEntidad.NCORMD = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_Record_Medico(ByVal objEntidad As RecordMedico) As List(Of RecordMedico)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of RecordMedico)

            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RECORD_MEDICO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New RecordMedico

                objDatos.NCORMD = objDataRow("NCORMD").ToString.Trim
                objDatos.CBRCNT = objDataRow("BREVETE").ToString.Trim
                objDatos.FECREG = objDataRow("FECREG").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.NCOVAC = objDataRow("NCOVAC").ToString.Trim
                objDatos.NOMVAC = objDataRow("NOMVAC").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Record_Medico_DT(ByVal objEntidad As RecordMedico) As DataTable
            Dim objDataTable As New DataTable
            'Try

            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RECORD_MEDICO_RPT", objParam)

            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

    Public Function Listar_VencimientoVacuna_Reporte(ByVal ht As Hashtable) As List(Of RecordMedico)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of RecordMedico)

            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOVAC", ht.Item("PNNCOVAC"))
            objParam.Add("PSSINDRC", ht.Item("PSSINDRC"))
            objParam.Add("PNFECHA_LIMITE1", ht.Item("PNFECHA_LIMITE1"))
            objParam.Add("PNFECHA_LIMITE2", ht.Item("PNFECHA_LIMITE2"))
            objParam.Add("PSCCMPN", ht.Item("CCMPN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VENCIMIENTO_VACUNA_MASIVO_RPT", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New RecordMedico

                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
                objDatos.TAPPAC = objDataRow("TAPPAC").ToString.Trim
                objDatos.TAPMAC = objDataRow("TAPMAC").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function

    End Class

End Namespace