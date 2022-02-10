Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario

Namespace mantenimientos

  Public Class VacacionesConductor_DAL

    Private objSql As New SqlManager

    Public Function Registrar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor
            'Try
            Dim objParam As New Parameter

            'objParam.Add("PON_NCORMD", objEntidad.NCORMD, ParameterDirection.Output)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNANOINI", objEntidad.ANOINI)
            objParam.Add("PNANOFIN", objEntidad.ANOFIN)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PNQCNESP", objEntidad.QCNESP, ParameterDirection.Output)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VACACIONES_CONDUCTOR", objParam)
            objEntidad.QCNESP = objSql.ParameterCollection("PNQCNESP")
            'Catch ex As Exception
            '          objEntidad.QCNESP = 0
            '      End Try

            Return objEntidad
    End Function

    Public Function Modificar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCRRLT", objEntidad.NCRRLT)
            objParam.Add("PNANOINI", objEntidad.ANOINI)
            objParam.Add("PNANOFIN", objEntidad.ANOFIN)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PNQCNESP", objEntidad.QCNESP)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCULUSA ", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_VACACIONES_CONDUCTOR", objParam)

            'Catch ex As Exception
            '          objEntidad.CBRCNT = 0
            '      End Try

            Return objEntidad
    End Function

    Public Function Eliminar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As VacacionesConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCRRLT", objEntidad.NCRRLT)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VACACIONES_CONDUCTOR", objParam)

            'Catch ex As Exception
            '          'objEntidad.NCORMD = 0
            '      End Try
            Return objEntidad
    End Function

    Public Function Listar_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As DataTable
      Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VACACIONES_CONDUCTOR_LA", objParam)

            For Each dr As DataRow In objDataTable.Rows

                dr("FECINI") = HelpClass.CFecha_de_8_a_10(dr("FECINI").ToString.Trim)
                dr("FECFIN") = HelpClass.CFecha_de_8_a_10(dr("FECFIN").ToString.Trim)
                dr("FRGTRO") = HelpClass.CFecha_de_8_a_10(dr("FRGTRO").ToString.Trim)
            Next

            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
    End Function

    Public Function Reporte_Vacaciones_Conductor(ByVal objEntidad As VacacionesConductor) As DataTable
      Dim objDataTable As New DataTable
            'Try

            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_VACACIONES_CONDUCTORES", objParam)

            'Catch ex As Exception
            '          objDataTable = New DataTable
            '      End Try
            Return objDataTable
        End Function

        Public Function Listar_Vacaciones_Conductor_Rpt(ByVal objEntidad As VacacionesConductor) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VACACIONES_CONDUCTOR_RPT", objParam)

            'For Each dr As DataRow In objDataTable.Rows

            'dr("FECINI") = HelpClass.CFecha_de_8_a_10(dr("FECINI").ToString.Trim)
            'dr("FECFIN") = HelpClass.CFecha_de_8_a_10(dr("FECFIN").ToString.Trim)
            'dr("FRGTRO") = HelpClass.CFecha_de_8_a_10(dr("FRGTRO").ToString.Trim)
            'Next

            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
        End Function

  End Class

End Namespace