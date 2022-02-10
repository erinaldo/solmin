Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

    Public Class CapacitacionConductor_DAL

        Private objSql As New SqlManager

        Public Function Registrar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objParam.Add("PON_NCOCPT", objEntidad.NCOCPT, ParameterDirection.Output)
            objParam.Add("PNFECREG", objEntidad.FECREG)

            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CAPACITACION_CONDUCTOR_V2", objParam)

            objEntidad.CBRCNT = objSql.ParameterCollection("POS_CBRCNT")
            objEntidad.NCOCPT = objSql.ParameterCollection("PON_NCOCPT")

            'Catch ex As Exception
            '    objEntidad.CBRCNT = 0
            '    objEntidad.NCOCPT = 0
            '    MsgBox(ex.Message)
            'End Try
            Return objEntidad
        End Function

        Public Function Modificar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objParam.Add("PON_NCOCPT", objEntidad.NCOCPT, ParameterDirection.Output)
            objParam.Add("PNFECREG", objEntidad.FECREG)

            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CAPACITACION_CONDUCTOR_V2", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = 0
            '    objEntidad.NCOCPT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As CapacitacionConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNCOCPT", objEntidad.NCOCPT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado 
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CAPACITACION_CONDUCTOR", objParam)

            'Catch ex As Exception
            '    objEntidad.CBRCNT = 0
            '    objEntidad.NCOCPT = 0
            'End Try
            Return objEntidad

        End Function

        Public Function Listar_CapacitacionConductor(ByVal objEntidad As CapacitacionConductor) As List(Of CapacitacionConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of CapacitacionConductor)
            Dim objParam As New Parameter
            'Try

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CAPACITACION_CONDUCTOR", objParam)

            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New CapacitacionConductor

                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.NCOCPT = objDataRow("NCOCPT").ToString.Trim
                objDatos.NOMCPT = objDataRow("NOMCPT").ToString.Trim
                objDatos.FECREG = objDataRow("FECREG").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_CapacitacionConductor_Reporte(ByVal objEntidad As CapacitacionConductor) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONDUCTOR_CAPACITACION_RPTCONDUCTOR", objParam)

            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

    Public Function Listar_VencimientoCapacitacion_Reporte(ByVal ht As Hashtable) As List(Of CapacitacionConductor)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of CapacitacionConductor)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNNCOCPT", ht.Item("PNNCOCPT"))
            objParam.Add("PSSINDRC", ht.Item("PSSINDRC"))
            objParam.Add("PNFECHA_LIMITE1", ht.Item("PNFECHA_LIMITE1"))
            objParam.Add("PNFECHA_LIMITE2", ht.Item("PNFECHA_LIMITE2"))
            objParam.Add("PSCCMPN", ht.Item("CCMPN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VENCIMIENTO_CAPACITACION_MASIVO_RPT", objParam)

            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New CapacitacionConductor
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