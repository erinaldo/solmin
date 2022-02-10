Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Ransa.Utilitario

Namespace mantenimientos
  Public Class TransportistaConductor_DAL
    Private objSql As New SqlManager


        Public Function Registrar_TransportistaConductor(ByVal objEntidad As TransportistaConductor) As TransportistaConductor

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PSHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("POS_RUC_ANTERIOR", objEntidad.POS_RUC_ANTERIOR, ParameterDirection.Output)
            objParam.Add("FLAG_SKIPCHECKS", objEntidad.FLAG_SKIPCHECKS)
            objParam.Add("POS_ASIGNACION", objEntidad.SESTCH, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_CONDUCTOR_DET", objParam)

            objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")
            objEntidad.POS_RUC_ANTERIOR = objSql.ParameterCollection("POS_RUC_ANTERIOR")
            objEntidad.SESTCH = objSql.ParameterCollection("POS_ASIGNACION")

            'Catch ex As Exception
            '          objEntidad.NRUCTR = "-1"
            '      End Try
            Return objEntidad
        End Function

        Public Sub Eliminar_TransportistaConductor(ByVal objEntidad As TransportistaConductor)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRANSPORTISTA_CONDUCTOR_DET", objParam)

            'Catch ex As Exception

            '          objEntidad.NRUCTR = "0"
            '      End Try

            'Return objEntidad
        End Sub

        Public Function Listar_TransportistaConductor(ByVal objEntidad As TransportistaConductor, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of TransportistaConductor)
            Dim objDataTable As New DataTable
            Dim ds As New DataSet
            Dim objGenericCollection As New List(Of TransportistaConductor)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("OU_TOTPAG", 0)



            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_CONDUCTOR_DET_LA", objParam)
            'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_CONDUCTOR_DET_LA", objParam)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_CONDUCTOR_DET_LA_V2", objParam)

            objDataTable = ds.Tables(0)


            TOTPAG = 0
            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If


            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TransportistaConductor

                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
                objDatos.TAPPAC = objDataRow("APEPAT").ToString.Trim
                objDatos.TAPMAC = objDataRow("APEMAT").ToString.Trim
                'objDatos.FECINI = HelpClass.CFecha_de_8_a_10(objDataRow("FECINI").ToString.Trim)
                'objDatos.FECFIN = HelpClass.CFecha_de_8_a_10(objDataRow("FECFIN").ToString.Trim)

                objDatos.FECINI = IIf(objDataRow("FECINI").ToString.Trim <> "", Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(CDec(objDataRow("FECINI"))), "")
                objDatos.FECFIN = IIf(objDataRow("FECFIN").ToString.Trim <> "", Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(CDec(objDataRow("FECFIN"))), "")

                objDatos.SESTCH = objDataRow("SESTCH").ToString.Trim

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.CPLNDV = objDataRow("CPLNDV")

                objDatos.ESTADO_CONDUCTOR = ("" & objDataRow("ESTADO_CONDUCTOR")).ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function

    Public Function Listar_TransportistaConductor_Reporte(ByVal objEntidad As TransportistaConductor) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Try
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_CONDUCTOR_DET", objParam)
      Catch ex As Exception
      End Try
      Return objDataTable
    End Function

    Public Function Listar_Transportista_x_Conductor(ByVal objEntidad As Chofer) As List(Of TransportistaConductor)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaConductor)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_X_CHOFER", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TransportistaConductor
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function


    Public Function Listar_TransportistaConductor_Historial(ByVal objEntidad As TransportistaConductor) As DataTable
      Dim objDataTable As New DataTable()
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_HISTORIAL_TRANSPORTISTA", objParam).Copy()
            If (objDataTable.Rows.Count = 0) Then
                objDataTable = Nothing
            End If
            'Catch ex As Exception
            '      End Try
            Return objDataTable
        End Function

        Public Function Listar_TransportistaConductor_Historial_Rpt(ByVal objEntidad As TransportistaConductor) As DataTable
            Dim objDataTable As New DataTable()
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCBRCNT", objEntidad.CBRCNT)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_HISTORIAL_TRANSPORTISTA_RPT", objParam)
                If (objDataTable.Rows.Count = 0) Then
                    objDataTable = Nothing
                End If
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function
    End Class
End Namespace