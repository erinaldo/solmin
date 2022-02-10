Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario

Namespace Operaciones
  Public Class Detalle_Solicitud_Transporte_DAL
    Private objSql As New SqlManager

    Public Function Listar_Detalle_Solicitud(ByVal objParametro As Hashtable) As List(Of Detalle_Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
      Dim objDatos As Detalle_Solicitud_Transporte
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPLNJT", objParametro("PNNPLNJT"))
                objParam.Add("PNNCRRPL", objParametro("PNNCRRPL"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DETALLE_SOLICITUD_LA", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Detalle_Solicitud_Transporte
          objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim
          objDatos.NCRRSR = objDataRow("NCRRSR").ToString.Trim
                    objDatos.FASGTR = HelpClass.CFecha_de_8_a_10(objDataRow("FASGTR").ToString.Trim)
          objDatos.HASGTR = objDataRow("HASGTR").ToString.Trim
          objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
          objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
          objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
          objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
          objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
          objDatos.TCMPCL = objDataRow("TCMPCL").ToString.Trim
          objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
          objDatos.NOPRCN = objDataRow("NOPRCN").ToString.Trim
          objDatos.SEGUIMIENTO = objDataRow("SEGUIMIENTO").ToString.Trim
          objDatos.GPSLAT = objDataRow("GPSLAT").ToString.Trim
          objDatos.GPSLON = objDataRow("GPSLON").ToString.Trim
          objDatos.FECGPS = objDataRow("FECGPS").ToString.Trim
          objDatos.HORGPS = objDataRow("HORGPS").ToString.Trim
          objDatos.RUTA = objDataRow("RUTA").ToString.Trim
          objDatos.NPLNMT = objDataRow("NPLNMT").ToString.Trim
          objDatos.NORINS = objDataRow("NORINS").ToString.Trim
                    objDatos.CBRCN2 = objDataRow("CBRCN2").ToString.Trim

          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Cliente_Solicitud(ByVal objParamList As List(Of String)) As List(Of Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Solicitud_Transporte)
      Dim objDatos As Solicitud_Transporte
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNCSOTR", objParamList(0).Trim)
        objParam.Add("PNCCLNT", objParamList(1).Trim)
        objParam.Add("PNFINCRG", objParamList(2).Trim)
                objParam.Add("PSSESSLC", objParamList(3).Trim)
                objParam.Add("PSCCMPN", objParamList(4).Trim)
                objParam.Add("PSCDVSN", objParamList(5).Trim)
                objParam.Add("PNCPLNDV", objParamList(6))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(4).Trim)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CLIENTE_SOLICITUD", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Solicitud_Transporte
          objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim
          objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
          objDatos.TCMPCL = objDataRow("TCMPCL").ToString.Trim
          objDatos.FECOST = objDataRow("FECOST").ToString.Trim
          objDatos.HRAOTR = objDataRow("HRAOTR").ToString.Trim
          objDatos.CTPOSR = objDataRow("CTPOSR").ToString.Trim
          objDatos.CUNDVH = objDataRow("CUNDVH").ToString.Trim
          objDatos.CMRCDR = objDataRow("CMRCDR").ToString.Trim
          objDatos.QMRCDR = objDataRow("QMRCDR").ToString.Trim
          objDatos.QSLCIT = CType(objDataRow("QSLCIT").ToString.Trim, Integer)
          objDatos.QATNAN = CType(objDataRow("QATNAN").ToString.Trim, Integer)
          objDatos.QATNDR = CType(objDataRow("QATNDR").ToString.Trim, Integer)
          objDatos.CLCLOR = objDataRow("CLCLOR").ToString.Trim
          objDatos.CLCLDS = objDataRow("CLCLDS").ToString.Trim
          objDatos.SESSLC = objDataRow("SESSLC").ToString.Trim
          objDatos.CLCLOR_CLCLDS = objDataRow("CLCLOR").ToString.Trim & " - " & objDataRow("CLCLDS").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Transportista_Solicitud() As List(Of Transportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Transportista)
      Dim objDatos As New Transportista
      Try
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_SOLICITUD", Nothing)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Transportista
          objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Vehículo_Solicitud(ByVal objParamList As List(Of String)) As List(Of Detalle_Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
      Dim objDatos As Detalle_Solicitud_Transporte
      Dim objParam As New Parameter
      Try
        objParam.Add("PSNPLCUN", objParamList(0).ToString.Trim)
        objParam.Add("PNCTITRA", objParamList(1).ToString.Trim)
        objParam.Add("PSNRUCTR", objParamList(2).ToString.Trim)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VEHICULO_SOLICITUD", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Detalle_Solicitud_Transporte
          objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
          objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
          objDatos.TMRCTR = objDataRow("TMRCTR").ToString.Trim
          objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
          objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
          objDatos.SESTCM = objDataRow("SESTCM").ToString.Trim
          objDatos.GPSLAT = objDataRow("GPSLAT").ToString.Trim
          objDatos.GPSLON = objDataRow("GPSLON").ToString.Trim
          objDatos.FECGPS = objDataRow("FECGPS").ToString.Trim
          objDatos.HORGPS = objDataRow("HORGPS").ToString.Trim
          objDatos.SEGUIMIENTO = objDataRow("SEGUIMIENTO").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Vehículo_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As List(Of Detalle_Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
      Dim objDatos As Detalle_Solicitud_Transporte
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PNCTPCRA", objEntidad.CTPCRA)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VEHICULO_SOLICITUD", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Detalle_Solicitud_Transporte
          objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
          objDatos.CTPCRA = objDataRow("CTPCRA").ToString.Trim
          objDatos.TCMCRA = objDataRow("TCMCRA").ToString.Trim
          objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
          objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
          objDatos.SESTCM = objDataRow("SESTCM").ToString.Trim
          objDatos.CBRCNT = objDataRow("CBRCND").ToString.Trim
          objDatos.NPLCAC = objDataRow("NPLACP").ToString.Trim
          objDatos.NOMBRE = objDataRow("NOMBRE").ToString.Trim
          objDatos.GPSLAT = objDataRow("GPSLAT").ToString.Trim
          objDatos.GPSLON = objDataRow("GPSLON").ToString.Trim
          objDatos.FECGPS = objDataRow("FECGPS").ToString.Trim
          objDatos.HORGPS = objDataRow("HORGPS").ToString.Trim
          objDatos.SEGUIMIENTO = objDataRow("SEGUIMIENTO").ToString.Trim
          objDatos.SESTRG = objDataRow("ESTADO").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Acoplado_Solicitud(ByVal lstr_transportista As String) As List(Of TransportistaAcoplado)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TransportistaAcoplado)
      Dim objDatos As TransportistaAcoplado
      Dim objParam As New Parameter
      Try
        If lstr_transportista <> "" Then
          objParam.Add("PSNRUCTR", lstr_transportista)
        End If
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACOPLADO_SOLICITUD", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New TransportistaAcoplado
          objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
          objDatos.TOBS = objDataRow("TOBS").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

        Public Function Listar_Conductor_Solicitud(ByVal lstr_transportista As String, ByVal strCompania As String) As List(Of TransportistaConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TransportistaConductor)
            Dim objDatos As New TransportistaConductor
            Dim objParam As New Parameter
            Try
                If lstr_transportista <> "" Then
                    objParam.Add("PSNRUCTR", lstr_transportista)
                End If
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONDUCTOR_SOLICITUD", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objDatos = New TransportistaConductor
                    objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                    objGenericCollection.Add(objDatos)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

    Public Function Filtrar_Solicitud_Atendida(ByVal objEntidad As Detalle_Solicitud_Transporte) As List(Of Detalle_Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
      Dim objDatos As Detalle_Solicitud_Transporte
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_FILTRAR_ASIGNACION_SOLICITUD_JUNTA", objParam)
        For Each objDataRow As DataRow In objDataTable.Rows
          objDatos = New Detalle_Solicitud_Transporte
          objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim
          objDatos.NCRRSR = objDataRow("NCRRSR").ToString.Trim
          objDatos.FASGTR = objDataRow("FASGTR").ToString.Trim
          objDatos.HASGTR = objDataRow("HASGTR").ToString.Trim
          objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
          objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
          objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
          objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
          objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
          objDatos.TCMPCL = objDataRow("TCMPCL").ToString.Trim
          objDatos.NOPRCN = objDataRow("NOPRCN").ToString.Trim
          'objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
          objDatos.ESTADO = 0
          objGenericCollection.Add(objDatos)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Registrar_Detalle_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter
        objParam.Add("PIN_NCSOTR", objEntidad.NCSOTR, ParameterDirection.Output)
        objParam.Add("PNFASGTR", objEntidad.FASGTR)
        objParam.Add("PNHASGTR", objEntidad.HASGTR)
        objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_SOLICITUD", objParam)
        objEntidad.NCSOTR = objSql.ParameterCollection("PIN_NCSOTR").ToString()
      Catch ex As Exception
        objEntidad.NCSOTR = "0"
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_Detalle_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
        objParam.Add("PNFASGTR", objEntidad.FASGTR)
        objParam.Add("PNHASGTR", objEntidad.HASGTR)
        objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_DETALLE_SOLICITUD", objParam)
      Catch ex As Exception
        objEntidad.NCSOTR = "0"
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Detalle_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
        objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_DETALLE_SOLICITUD", objParam)
      Catch ex As Exception
        objEntidad.NCSOTR = "0"
      End Try
      Return objEntidad
    End Function

    Public Function Actualizar_Solicitud_Transporte(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_SOLICITUD_TRANSPORTE", objParam)
      Catch ex As Exception
        objEntidad.NCSOTR = "0"
      End Try
      Return objEntidad
    End Function

    Public Function Actualizar_Vehiculo(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_VEHICULO", objParam)
      Catch ex As Exception
        objEntidad.NRUCTR = "0"
      End Try
      Return objEntidad
    End Function

    Public Function Actualizar_Recursos_Asignados_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            'objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            'objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCBRCN2", objEntidad.CBRCN2)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_RECURSOS_ASIGNADOS_SOLICITUD", objParam)
            'Catch ex As Exception
            '          objEntidad.NCSOTR = "0"
            '      End Try
            Return objEntidad
    End Function

    Public Function Validar_Existencias_PAG(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
      Dim objParam As New Parameter
      Dim lstr_Estado As String = ""
            'Try

            objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PNNCTAVC", 0, ParameterDirection.Output)
            objParam.Add("PNNCTAV2", 0, ParameterDirection.Output)
            objParam.Add("PNNCSLPE", 0, ParameterDirection.Output)
            objParam.Add("PNNCSLP2", 0, ParameterDirection.Output)
            objParam.Add("PNNGUITR", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_EXISTE_PAG", objParam)
            objEntidad.NGUITR = objSql.ParameterCollection("PNNGUITR").ToString.Trim
            objEntidad.NCTAVC = objSql.ParameterCollection("PNNCTAVC").ToString.Trim
            objEntidad.NCTAV2 = objSql.ParameterCollection("PNNCTAV2").ToString.Trim
            objEntidad.NCSLPE = objSql.ParameterCollection("PNNCSLPE").ToString.Trim
            objEntidad.NCSLP2 = objSql.ParameterCollection("PNNCSLP2").ToString.Trim
            'Catch ex As Exception

            '      End Try
            Return objEntidad
        End Function




        Public Function Listar_Datos_Solicitud_Validacion(ByVal objEntidad As Detalle_Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_DATOS_VALIDACION_SOLICITUD", objParam)
            Return objDataSet
        End Function

        Public Function Listar_Cliente_Solicitud_Programacion(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSSESSLC", objEntidad.SESSLC)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PNHRAOTR_INI", objEntidad.HR_INI)
            objParam.Add("PNHRAOTR_FIN", objEntidad.HR_FIN)
            objParam.Add("PNCMEDTR", objEntidad.CMEDTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PSCURSCRT", objEntidad.CUSCRT)
            objParam.Add("PSTRFRN", objEntidad.TRFRN)
            objParam.Add("PSSPRSTR", objEntidad.SPRSTR)
            objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CLIENTE_SOLICITUD_PROGRAMACION_UNIDAD", objParam)
            For Each Item As DataRow In objDataTable.Rows
                Item("CCLNT") = HelpClass.ToStringCvr(Item("CCLNT"))
                Item("TNMMDT") = HelpClass.ToStringCvr(Item("TNMMDT"))
                Item("CLCLOR") = HelpClass.ToStringCvr(Item("CLCLOR"))
                Item("TDRCOR") = HelpClass.ToStringCvr(Item("TDRCOR"))
                Item("CLCLDS") = HelpClass.ToStringCvr(Item("CLCLDS"))
                Item("CUNDMD") = HelpClass.ToStringCvr(Item("CUNDMD"))
                Item("TOBS") = HelpClass.ToStringCvr(Item("TOBS"))
                Item("CUSCRT") = HelpClass.ToStringCvr(Item("CUSCRT"))
                Item("TRFRN") = HelpClass.ToStringCvr(Item("TRFRN"))
                Item("CUNDMD") = HelpClass.ToStringCvr(Item("CUNDMD"))
                Item("CTPOSR") = HelpClass.ToStringCvr(Item("CTPOSR"))
                Item("CMRCDR") = HelpClass.ToStringCvr(Item("CMRCDR"))
                Item("TDRENT") = HelpClass.ToStringCvr(Item("TDRENT"))
            Next

            Return objDataTable
        End Function

        Public Function Listar_Juntas_x_Solicitud(ByVal NCSOTR As Decimal, ByVal CCMPN As String) As DataTable
            Dim objData As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", NCSOTR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_JUNTAS_X_SOLICITUD", objParam)
            Return objData
        End Function



        Public Function Validar_Operacion_Solicitud(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
            Dim objParam As New Parameter
            Dim lstr_Estado As String = ""
            Dim dt As New DataTable
            'Try
            'objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            'objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            'objParam.Add("PNNCTAVC", 0, ParameterDirection.Output)
            'objParam.Add("PNNCTAV2", 0, ParameterDirection.Output)
            'objParam.Add("PNNCSLPE", 0, ParameterDirection.Output)
            'objParam.Add("PNNCSLP2", 0, ParameterDirection.Output)
            'objParam.Add("PNNGUITR", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_OPERACION_SOLICITUD", objParam)
            If dt.Rows.Count > 0 Then
                objEntidad.NGUITR = dt.Rows(0)("NGUITR").ToString.Trim
                objEntidad.NCTAVC = dt.Rows(0)("NCTAVC").ToString.Trim
                objEntidad.NCTAV2 = dt.Rows(0)("NCTAV2").ToString.Trim
                objEntidad.NCSLPE = dt.Rows(0)("NCSLPE").ToString.Trim
                objEntidad.NCSLP2 = dt.Rows(0)("NCSLP2").ToString.Trim
                objEntidad.SESGRP = dt.Rows(0)("SESGRP").ToString.Trim
                'SESGRP
            End If
          
            'Catch ex As Exception

            '      End Try
            Return objEntidad
        End Function

  End Class
End Namespace


