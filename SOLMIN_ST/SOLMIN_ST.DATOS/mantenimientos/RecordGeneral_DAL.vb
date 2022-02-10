Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

'****************************************************************************************************
'** Autor: Anddy Ramos
'** Modificación: Rafael Gamboa
'** Fecha de Creación: 08/08/2009 
'** Descripción: capa de acceso a datos.
'****************************************************************************************************
Namespace mantenimientos
    Public Class RecordGeneral_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Record_General_Inactivacion_Reactivacion(ByVal objEntidad As RecordGeneral) As Int32
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT)

            objParam.Add("PNFRGTRO", objEntidad.FRGTRO)
            objParam.Add("PNHRGTRO", objEntidad.HRGTRO)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECTER", objEntidad.FECTER)
            objParam.Add("PSTOBSMD", objEntidad.TOBSMD)
            objParam.Add("PSSTPRCD", objEntidad.STPRCD)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)

            'ejecuta el procedimiento almacenado

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_RECORD_GENERAL_CONDUCTOR_INACT_REACT", objParam)
            'Catch ex As Exception

            'End Try
        End Function



        Public Function Registrar_Record_General(ByVal objEntidad As RecordGeneral) As RecordGeneral

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objParam.Add("PON_NCRRLT", objEntidad.NCRRLT, ParameterDirection.Output)
            objParam.Add("PSSTPRCD", objEntidad.STPRCD)
            objParam.Add("PNFRGTRO", objEntidad.FRGTRO)
            objParam.Add("PNHRGTRO", objEntidad.HRGTRO)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECTER", objEntidad.FECTER)
            objParam.Add("PNNRPPLT", objEntidad.NRPPLT)
            objParam.Add("PSMTVEVN", objEntidad.MTVEVN)
            objParam.Add("PSTOBSMD", objEntidad.TOBSMD)
            objParam.Add("PNQCNESP", objEntidad.QCNESP)
            objParam.Add("PSCUNCNA", objEntidad.CUNCNA)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCULUSA", objEntidad.CUSCRT)
            objParam.Add("PNFULTAC", objEntidad.FCHCRT)
            objParam.Add("PNHULTAC", objEntidad.HRACRT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_RECORD_GENERAL_CONDUCTOR_V2", objParam)

            objEntidad.CBRCNT = objSql.ParameterCollection("POS_CBRCNT")
            objEntidad.NCRRLT = objSql.ParameterCollection("PON_NCRRLT")
            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            '    objEntidad.NCRRLT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Modificar_Record_General(ByVal objEntidad As RecordGeneral) As RecordGeneral

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCRRLT", objEntidad.NCRRLT)
            objParam.Add("PSSTPRCD", objEntidad.STPRCD)
            objParam.Add("PNFRGTRO", objEntidad.FRGTRO)
            objParam.Add("PNHRGTRO", objEntidad.HRGTRO)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECTER", objEntidad.FECTER)
            objParam.Add("PNNRPPLT", objEntidad.NRPPLT)
            objParam.Add("PSTOBSMD", objEntidad.TOBSMD)
            objParam.Add("PNQCNESP", objEntidad.QCNESP)
            objParam.Add("PSCUNCNA", objEntidad.CUNCNA)
            objParam.Add("PSCULUSA ", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_RECORD_GENERAL_CONDUCTOR", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            '    objEntidad.NCRRLT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Record_General(ByVal objEntidad As RecordGeneral)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCRRLT", objEntidad.NCRRLT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_RECORD_GENERAL_CONDUCTOR", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            '    objEntidad.NCRRLT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_Record_General(ByVal objEntidad As RecordGeneral) As List(Of RecordGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of RecordGeneral)

            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RECORD_GENERAL_CONDUCTOR", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New RecordGeneral

                objDatos.NCRRLT = objDataRow("NCRRLT").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.STPRCD = objDataRow("STPRCD").ToString.Trim
                objDatos.FRGTRO = objDataRow("FRGTRO").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECTER = objDataRow("FECTER").ToString.Trim
                objDatos.NRPPLT = objDataRow("NRPPLT").ToString.Trim
                objDatos.MTVEVN = objDataRow("MTVEVN").ToString.Trim
                objDatos.TOBSMD = objDataRow("TOBSMD").ToString.Trim
                objDatos.QCNESP = objDataRow("QCNESP").ToString.Trim
                objDatos.CUNCNA = objDataRow("CUNCNA").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.TTPRCD = objDataRow("TTPRCD").ToString.Trim


                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Record_General_DT(ByVal objEntidad As RecordGeneral) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RECORD_GENERAL_CONDUCTOR", objParam)

            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function
    End Class
End Namespace
