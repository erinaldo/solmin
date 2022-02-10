Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Ransa.Utilitario

Namespace mantenimientos

  Public Class TransportistaTracto_DAL
    Private objSql As New SqlManager

    Public Function Existe_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
      Try
        Dim objParam As New Parameter
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_EXISTE_TRANSPORTISTA_TRACTO", objParam)
        objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR").ToString()
      Catch ex As Exception
        objEntidad.NRUCTR = "-1"
      End Try
      Return objEntidad
    End Function

        Public Function Registrar_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto


            Dim objParam As New Parameter

            objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PSHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("FLAG_SKIPCHECKS", objEntidad.FLAG_SKIPCHECKS)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            'objParam.Add("PSSTPVHP", objEntidad.STPVHP)

            objParam.Add("POS_RUC_ANTERIOR", objEntidad.POS_RUC_ANTERIOR, ParameterDirection.Output)
            objParam.Add("POS_ASIGNACION", objEntidad.SESTCM, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_TRACTO_DET", objParam)

            objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")
            objEntidad.POS_RUC_ANTERIOR = objSql.ParameterCollection("POS_RUC_ANTERIOR")
            objEntidad.SESTCM = objSql.ParameterCollection("POS_ASIGNACION")

          
            Return objEntidad
        End Function

    Public Function Registrar_Transportista_Tracto_Acoplado_Conductor_Carroceria(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
      Try
        Dim objParam As New Parameter

        objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
        objParam.Add("POS_NPLCUN", objEntidad.NPLCUN, ParameterDirection.Output)
        objParam.Add("PSNPLCAC", objEntidad.NPLACP)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PNCTPCRA", objEntidad.CTPCRA)

        objParam.Add("PNFECINI", objEntidad.FECINI)
        objParam.Add("PNFECFIN", objEntidad.FECFIN)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PSHRACRT", objEntidad.HRACRT)
        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)


        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_TRACTO_ACOPLADO_CONDUCT_TCARROCERIA", objParam)

        objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")

      Catch ex As Exception

        objEntidad.NRUCTR = 0
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_TransportistaTracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
      Try
        Dim objParam As New Parameter
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PNNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PNNPLACP", objEntidad.NPLACP)
        objParam.Add("PNCTPCRA", objEntidad.CTPCRA)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PNCCNLT", objEntidad.CCLNT)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TRANSPORTISTA_TRACTO_DET", objParam)
      Catch ex As Exception
        objEntidad.NRUCTR = "0"
      End Try
      Return objEntidad
    End Function

        Public Sub Eliminar_TransportistaTracto(ByVal objEntidad As TransportistaTracto)

            Dim objParam As New Parameter

            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado



            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRANSPORTISTA_TRACTO_DET", objParam)

          
        End Sub

        Public Function Listar_TractosPorTransportista(ByVal objEntidad As TransportistaTracto, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable 'List(Of TransportistaTracto)
            Dim objDataTable As New DataTable
            Dim ds As New DataSet
            Dim objParam As New Parameter


            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSSTPVHP", objEntidad.STPVHP)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("OU_TOTPAG", TOTPAG)



            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_TRACTO_DET_LA", objParam)
            'ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_TRACTO_DET_LA", objParam)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_TRACTO_DET_LA_V2", objParam)

            objDataTable = ds.Tables(0)

            TOTPAG = 0
            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If

            For Each dr As DataRow In objDataTable.Rows
                dr("FECINI") = HelpClass.FechaNum_a_Fecha(dr("FECINI"))
                dr("FECFIN") = HelpClass.FechaNum_a_Fecha(CDec(dr("FECFIN")))
                dr("CUSCRT") = ("" & dr("CUSCRT")).ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(dr("FCHCRT"))
                dr("CULUSA") = ("" & dr("CULUSA")).ToString.Trim & " - " & HelpClass.FechaNum_a_Fecha(dr("FULTAC"))
                dr("CONDICION") = dr("CONDICION") & " - " & dr("VIGENCIA")
                dr("FVALIN") = HelpClass.FechaNum_a_Fecha(dr("FVALIN"))
                dr("FVALFI") = HelpClass.FechaNum_a_Fecha(dr("FVALFI"))

            Next

            Return objDataTable
        End Function

    Public Function Listar_TractosPorTransportista_Reporte(ByVal objEntidad As TransportistaTracto) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter


            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_TRACTO_DET", objParam)
         
            Return objDataTable
    End Function

    Public Function Listar_Transportista_x_Tracto(ByVal objEntidad As Tracto) As List(Of TransportistaTracto)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaTracto)
      Dim objParam As New Parameter

            'Obteniendo resultados
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_X_TRACTO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TransportistaTracto

                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objDatos.FECINI = objDataRow("FECINI").ToString.Trim
                objDatos.FECFIN = objDataRow("FECFIN").ToString.Trim
                objDatos.SESTCM = objDataRow("SESTCM").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

       
            Return objGenericCollection
    End Function

    Public Function Listar_Tracto_X_Transportista(ByVal objEntidad As TransportistaTracto) As List(Of TransportistaTracto)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaTracto)
      Dim objParam As New Parameter

            'Obteniendo resultados
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO_X_TRANSPORTISTA", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TransportistaTracto
                objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objDataRow("NPLACP").ToString.Trim
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
           
            Return objGenericCollection
    End Function

    Public Function Obtener_Informacion_Tracto(ByVal objEntidad As TransportistaTracto) As TransportistaTracto
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaTracto)
      Dim objParam As New Parameter

            'Obteniendo resultados
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC, ParameterDirection.Output)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_INFORMACION_TRACTO", objParam)
            'Procesandolos como una Lista
            objEntidad.NPLCAC = objSql.ParameterCollection("PSNPLCAC").ToString
            objEntidad.CBRCNT = objSql.ParameterCollection("PSCBRCNT").ToString
           
            Return objEntidad
    End Function


    Public Function Listar_Transportista_X_Vehiculo(ByVal objEntidad As TransportistaTracto) As List(Of TransportistaTracto)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaTracto)
      Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_X_VEHICULO_LA", objParam)

            For Each dr As DataRow In objDataTable.Rows
                objEntidad = New TransportistaTracto
                objEntidad.CCMPN = dr.Item("CCMPN")
                objEntidad.CDVSN = dr.Item("CDVSN")
                objEntidad.CPLNDV = dr.Item("CPLNDV")
                objEntidad.TCMTRT = dr.Item("TCMTRT").ToString.Trim
                objEntidad.TNMCMC = dr.Item("TNMCMC").ToString.Trim
                objEntidad.FECINI = HelpClass.CFecha_de_8_a_10(dr.Item("FECINI").ToString.Trim)
                objEntidad.FECFIN = HelpClass.CFecha_de_8_a_10(dr.Item("FECFIN").ToString.Trim)
                objEntidad.CBRCND = dr.Item("CBRCND")
                objEntidad.CTITRA = dr.Item("CTPCRA")
                objEntidad.CCLNT = dr.Item("CCLNT")
                objEntidad.SESTCM = dr.Item("SESTCM")
                objEntidad.SESTRG = dr.Item("SESTRG")
                objEntidad.NRUCTR = dr.Item("NRUCTR").ToString.Trim
                objGenericCollection.Add(objEntidad)
            Next

           
            Return objGenericCollection
    End Function

        Public Function Listar_TractosPorTransportista_Propio(ByVal objEntidad As TransportistaTracto) As DataTable 'List(Of TransportistaTracto)
            Dim objDataTable As New DataTable

            Dim objParam As New Parameter


            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRANSPORTISTA_TRACTO_PROPIO_DET_LA", objParam)

            For Each dr As DataRow In objDataTable.Rows
                dr("FECINI") = HelpClass.CFecha_de_8_a_10(dr("FECINI").ToString.Trim)
                dr("FECFIN") = HelpClass.CFecha_de_8_a_10(dr("FECFIN").ToString.Trim)
            Next

            
            Return objDataTable
        End Function

        Public Function Registrar_TransportistaTracto_V2(ByVal objEntidad As TransportistaTracto) As TransportistaTracto


            Dim objParam As New Parameter

            objParam.Add("POS_NRUCTR", objEntidad.NRUCTR, ParameterDirection.Output)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PSHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("FLAG_SKIPCHECKS", objEntidad.FLAG_SKIPCHECKS)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSSTPVHP", objEntidad.STPVHP)

            objParam.Add("POS_RUC_ANTERIOR", objEntidad.POS_RUC_ANTERIOR, ParameterDirection.Output)
            objParam.Add("POS_ASIGNACION", objEntidad.SESTCM, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_TRACTO_DET_V2", objParam)

            objEntidad.NRUCTR = objSql.ParameterCollection("POS_NRUCTR")
            objEntidad.POS_RUC_ANTERIOR = objSql.ParameterCollection("POS_RUC_ANTERIOR")
            objEntidad.SESTCM = objSql.ParameterCollection("POS_ASIGNACION")

          
            Return objEntidad
        End Function


  End Class
End Namespace
