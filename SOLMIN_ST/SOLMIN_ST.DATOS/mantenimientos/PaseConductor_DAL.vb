'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 27/07/2009                                   **'
'** Descripción: CAPA DE ACCESO A DATOS.                            **'
'*********************************************************************'

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

    Public Class PaseConductor_DAL
        'tabla RZST10
        Private objSql As New SqlManager

        Public Function Registrar_PaseConductor(ByVal objEntidad As PaseConductor) As PaseConductor
            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objParam.Add("PON_NCOPSE", objEntidad.NCOPSE, ParameterDirection.Output)
            objParam.Add("PNFECREG", objEntidad.FECREG)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objParam.Add("NEW_NCOPSE", objEntidad.NEW_NCOPSE)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objParam.Add("OLD_PNFECINI", objEntidad.OLD_PNFECINI)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_PASE_CONDUCTOR_V2", objParam)
            objEntidad.CBRCNT = objSql.ParameterCollection("POS_CBRCNT")
            objEntidad.NCOPSE = objSql.ParameterCollection("PON_NCOPSE")

            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            '    objEntidad.NCOPSE = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Modificar_PaseConductor(ByVal objEntidad As PaseConductor) As PaseConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCOPSE", objEntidad.NCOPSE)
            objParam.Add("PNFECREG", objEntidad.FECREG)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_PASE_CONDUCTOR", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_PaseConductor(ByVal objEntidad As PaseConductor) As PaseConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCOPSE", objEntidad.NCOPSE)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_PASE_CONDUCTOR", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = "0"
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_PaseConductor(ByVal objEntidad As PaseConductor) As List(Of PaseConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of PaseConductor)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PASE_CONDUCTOR", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New PaseConductor

                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.NCOPSE = objDataRow("NCOPSE").ToString.Trim
                objDatos.NOMPSE = objDataRow("NOMPSE").ToString.Trim
                objDatos.FECREG = objDataRow("FECREG").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception

            'End Try
            Return objGenericCollection
        End Function

        Public Function Listado_Pases_x_Conductor_DT(ByVal objEntidad As PaseConductor) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPTPASES", objParam)
            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

        Public Function Listar_VencimientoPase_Reporte(ByVal ht As Hashtable) As List(Of PaseConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of PaseConductor)
            Dim objParam As New Parameter
            'Try
            'Obteniendo resultados
            objParam.Add("PNNCOPSE", ht.Item("PNNCOPSE"))
            objParam.Add("PSSINDRC", ht.Item("PSSINDRC"))
            objParam.Add("PNFECHA_LIMITE1", ht.Item("PNFECHA_LIMITE1"))
            objParam.Add("PNFECHA_LIMITE2", ht.Item("PNFECHA_LIMITE2"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VENCIMIENTO_PASE_MASIVO_RPT", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New PaseConductor
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
                objDatos.TAPPAC = objDataRow("TAPPAC").ToString.Trim
                objDatos.TAPMAC = objDataRow("TAPMAC").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

    End Class
End Namespace
