Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Ransa.Utilitario

Namespace mantenimientos
  Public Class TransportistaAcoplado_DAL
    Private objSql As New SqlManager

    Public Function Registrar_TransportistaAcoplado(ByVal objEntidad As TransportistaAcoplado) As TransportistaAcoplado

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
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
            'objParam.Add("PSSTPACP", objEntidad.STPACP)

            objParam.Add("POS_RUC_ANTERIOR", objEntidad.POS_RUC_ANTERIOR, ParameterDirection.Output)
            objParam.Add("FLAG_SKIPCHECKS", objEntidad.FLAG_SKIPCHECKS)
            objParam.Add("POS_ASIGNACION", objEntidad.SESTAC, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_ACOPLADO_DET", objParam)

            objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")
            objEntidad.POS_RUC_ANTERIOR = objSql.ParameterCollection("POS_RUC_ANTERIOR")
            objEntidad.SESTAC = objSql.ParameterCollection("POS_ASIGNACION")

            'Catch ex As Exception
            '          objEntidad.NRUCTR = "-1"
            '      End Try
            Return objEntidad
    End Function

        Public Sub Eliminar_TransportistaAcoplado(ByVal objEntidad As TransportistaAcoplado)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            'ejecuta el procedimiento almacenado

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRANSPORTISTA_ACOPLADO_DET", objParam)

            'Catch ex As Exception

            '          objEntidad.NRUCTR = "0"
            '      End Try
            '      Return objEntidad
        End Sub

        Public Function Listar_AcopladosPorTransportista(ByVal objEntidad As TransportistaAcoplado, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of TransportistaAcoplado)

 
            Dim objDataTable As New DataTable
            Dim ds As New DataSet
            Dim objGenericCollection As New List(Of TransportistaAcoplado)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSSTPACP", objEntidad.STPACP)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("TOTPAG", TOTPAG)

            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_ACOPLADO_DET_LA", objParam)
            'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_ACOPLADO_DET_LA", objParam)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_ACOPLADO_DET_LA_V2", objParam)


            objDataTable = ds.Tables(0)

            TOTPAG = 0
            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TransportistaAcoplado

                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.TMRCVH = objDataRow("TMRCVH").ToString.Trim
                objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim



                'objDatos.FECINI = HelpClass.CFecha_de_8_a_10(objDataRow("FECINI").ToString.Trim)
                'objDatos.FECFIN = HelpClass.CFecha_de_8_a_10(objDataRow("FECFIN").ToString.Trim)

                objDatos.FECINI = IIf(objDataRow("FECINI").ToString.Trim <> "", Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(CDec(objDataRow("FECINI"))), "")
                objDatos.FECFIN = IIf(objDataRow("FECFIN").ToString.Trim <> "", Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(CDec(objDataRow("FECFIN"))), "")

                objDatos.SESTAC = objDataRow("SESTAC").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim

                objDatos.STPACP = objDataRow("STPACP").ToString.Trim
                objDatos.STPACP_S = objDataRow("STPACP_S").ToString.Trim

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.CPLNDV = objDataRow("CPLNDV")


                objDatos.NRALQT = ("" & objDataRow("NRALQT")).ToString.Trim
                objDatos.CUSCRT = ("" & objDataRow("CUSCRT")).ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(objDataRow("FCHCRT"))
                objDatos.CULUSA = ("" & objDataRow("CULUSA")).ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(objDataRow("FULTAC"))
                objDatos.CONDICION = objDataRow("CONDICION") & " - " & objDataRow("VIGENCIA")
                objDatos.FVALIN = HelpClass.FechaNum_a_Fecha(objDataRow("FVALIN"))
                objDatos.FVALFI = HelpClass.FechaNum_a_Fecha(objDataRow("FVALFI"))

                objDatos.ESTADO_ACOPLADO = ("" & objDataRow("ESTADO_ACOPLADO")).ToString.Trim


                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function

    Public Function Listar_AcopladosPorTransportista_Reporte(ByVal objEntidad As TransportistaAcoplado) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)


            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_ACOPLADO_DET", objParam)
            'Catch ex As Exception
            '      End Try
            Return objDataTable
    End Function

    Public Function Listar_Transportista_x_Acoplado(ByVal objEntidad As Acoplado) As List(Of TransportistaAcoplado)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaAcoplado)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_X_ACOPLADO", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TransportistaAcoplado

                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_AcopladosPorTransportista_Reporte_Propio(ByVal objEntidad As TransportistaAcoplado) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_ACOPLADO_PROPIO_DET", objParam)
            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

        Public Function Registrar_TransportistaAcoplado_V2(ByVal objEntidad As TransportistaAcoplado) As TransportistaAcoplado

            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
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
            objParam.Add("PSSTPACP", objEntidad.STPACP)

            objParam.Add("POS_RUC_ANTERIOR", objEntidad.POS_RUC_ANTERIOR, ParameterDirection.Output)
            objParam.Add("FLAG_SKIPCHECKS", objEntidad.FLAG_SKIPCHECKS)
            objParam.Add("POS_ASIGNACION", objEntidad.SESTAC, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_ACOPLADO_DET_V2", objParam)

            objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")
            objEntidad.POS_RUC_ANTERIOR = objSql.ParameterCollection("POS_RUC_ANTERIOR")
            objEntidad.SESTAC = objSql.ParameterCollection("POS_ASIGNACION")

            'Catch ex As Exception
            '    objEntidad.NRUCTR = "-1"
            'End Try
            Return objEntidad
        End Function

  End Class
End Namespace