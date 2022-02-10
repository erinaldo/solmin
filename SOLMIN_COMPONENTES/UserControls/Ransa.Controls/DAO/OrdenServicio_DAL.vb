Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos


Namespace Operaciones

  Public Class OrdenServicio_DAL
    Private objSql As New SqlManager

    Public Function Listar_Ordenes_Servicio_x_Cliente(ByVal objParamList As List(Of String)) As List(Of OrdenServicioTransporte)

      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of OrdenServicioTransporte)
      Dim objParam As New Parameter

      Try

        objParam.Add("PSNORSRT", objParamList(0))
        objParam.Add("PNCCLNT", objParamList(1))
        objParam.Add("PSCCMPN", objParamList(2))
        objParam.Add("PSCDVSN", objParamList(3))
        objParam.Add("PNCPLNDV", objParamList(4))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(2))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ORDENES_SERVICIO", objParam)

        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New OrdenServicioTransporte
          objDatos.NORSRT = objDataRow("NORSRT").ToString.Trim
          objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
          objDatos.CMRCDR = objDataRow("CMRCDR").ToString.Trim
          objDatos.QMRCDR = objDataRow("QMRCDR").ToString.Trim
          objDatos.TRFMRC = objDataRow("TRFMRC").ToString.Trim
          objDatos.CTPOSR = objDataRow("CTPOSR").ToString.Trim
          objDatos.CLCLOR = objDataRow("CLCLOR").ToString.Trim
          objDatos.CLCLDS = objDataRow("CLCLDS").ToString.Trim

          objDatos.PNTORG = objDataRow("PNTORG").ToString.Trim
          objDatos.PNTDES = objDataRow("PNTDES").ToString.Trim
          objDatos.TIPSRV = objDataRow("TIPSRV").ToString.Trim
          objDatos.CODMER = objDataRow("CODMER").ToString.Trim
          objDatos.CUNDMD = objDataRow("CUNDMD").ToString.Trim
          objDatos.CTPUNV = objDataRow("CTPUNV").ToString.Trim
          objDatos.NCTZCN = objDataRow("NCTZCN").ToString.Trim

          objGenericCollection.Add(objDatos)
        Next

      Catch ex As Exception
      End Try

      Return objGenericCollection

    End Function

    Public Function Obtener_Orden_Servicio(ByVal objEntidad As OrdenServicioTransporte) As OrdenServicioTransporte

      Dim objDataTable As New DataTable
      Dim objParam As New Parameter

      Try

        objParam.Add("PSNORSRT", objEntidad.NORSRT)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_ORDEN_SERVICIO", objParam)

        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New OrdenServicioTransporte
          objEntidad.NORSRT = objDataRow("NORSRT").ToString.Trim
          objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
          objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
          objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
          objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
          objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
          objEntidad.CLCLOR = objDataRow("CLCLOR").ToString.Trim
          objEntidad.CLCLDS = objDataRow("CLCLDS").ToString.Trim

          objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
          objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
          objEntidad.CUNDMD = objDataRow("CUNDMD").ToString.Trim
          objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
        Next

      Catch ex As Exception
        objEntidad.NORSRT = 0
      End Try

      Return objEntidad

    End Function

    Public Function GenerarOS(ByVal lobjEntidad As Hashtable) As Double
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Dim dblResultado As Double = 0

      Try
        objParam.Add("PNNCTZCN", lobjEntidad("PNNCTZCN"))
        objParam.Add("PNCCLNT", lobjEntidad("PNCCLNT"))
        objParam.Add("PSCCMPN", lobjEntidad("PSCCMPN"))
        objParam.Add("PSCDVSN", lobjEntidad("PSCDVSN"))
        objParam.Add("PNCPLNDV", lobjEntidad("PNCPLNDV"))
        objParam.Add("PNCCLNFC", lobjEntidad("PNCCLNFC"))
        objParam.Add("PSSSCGST", lobjEntidad("PSSSCGST"))
        objParam.Add("PNCCNCST", lobjEntidad("PNCCNCST"))
        objParam.Add("PNCCNCS1", lobjEntidad("PNCCNCS1"))
        objParam.Add("PSCUSCRT", lobjEntidad("PSCUSCRT"))
        objParam.Add("PNFCHCRT", lobjEntidad("PNFCHCRT"))
        objParam.Add("PNHRACRT", lobjEntidad("PNHRACRT"))
        objParam.Add("PSNTRMCR", lobjEntidad("PSNTRMCR"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("PSCCMPN"))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_OS", objParam)

      Catch ex As Exception
        dblResultado = 1
      End Try
      Return dblResultado

    End Function

    Public Function Cerrar_OS(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
      Dim dblResultado = 0
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNORSRT", obeOrdenServicio.NORSRT)
        objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
        objParam.Add("PNFULTAC", obeOrdenServicio.FULTAC)
        objParam.Add("PNHULTAC", obeOrdenServicio.HULTAC)
        objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_OS", objParam)
      Catch ex As Exception
        dblResultado = 1
      End Try
      Return dblResultado
        End Function


        ''' <summary>
        ''' Método que genera el detalle de la cotizacion
        ''' </summary>
        ''' <param name="lobjEntidad"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Create for: Hugo Pérez Ryan
        ''' Date:       21/02/2012
        ''' </remarks>
        Public Function GenerarOSxDetalleCotizacion(ByVal lobjEntidad As Hashtable) As Double
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim dblResultado As Double = 0

            Try
                objParam.Add("PNNCTZCN", lobjEntidad("PNNCTZCN"))
                objParam.Add("PNCCLNT", lobjEntidad("PNCCLNT"))
                objParam.Add("PSCCMPN", lobjEntidad("PSCCMPN"))
                objParam.Add("PSCDVSN", lobjEntidad("PSCDVSN"))
                objParam.Add("PNCPLNDV", lobjEntidad("PNCPLNDV"))
                objParam.Add("PNCCLNFC", lobjEntidad("PNCCLNFC"))
                objParam.Add("PSSSCGST", lobjEntidad("PSSSCGST"))
                objParam.Add("PNCCNCST", lobjEntidad("PNCCNCST"))
                objParam.Add("PNCCNCS1", lobjEntidad("PNCCNCS1"))
                objParam.Add("PSCUSCRT", lobjEntidad("PSCUSCRT"))
                objParam.Add("PNFCHCRT", lobjEntidad("PNFCHCRT"))
                objParam.Add("PNHRACRT", lobjEntidad("PNHRACRT"))
                objParam.Add("PSNTRMCR", lobjEntidad("PSNTRMCR"))
                objParam.Add("PNCRRCT", lobjEntidad("PNCRRCT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_OS_X_DETALLE_COTIZACION", objParam)

            Catch ex As Exception
                dblResultado = 1
            End Try
            Return dblResultado
        End Function

        ''' <summary>
        ''' Método que permite cerrar la OS de cada uno de los detalles
        ''' </summary>
        ''' <param name="obeOrdenServicio"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Create for: Hugo Pérez Ryan
        ''' Date:       21/02/2012
        ''' </remarks>
        Public Function CerrarOSxDetalleCotizacion(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
            Dim dblResultado = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNORSRT", obeOrdenServicio.NORSRT)
                objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
                objParam.Add("PNFULTAC", obeOrdenServicio.FULTAC)
                objParam.Add("PNHULTAC", obeOrdenServicio.HULTAC)
                objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
                objParam.Add("PNNCTZCN", obeOrdenServicio.NCTZCN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_OS_X_DETALLE_COTIZACION", objParam)
            Catch ex As Exception
                dblResultado = 1
            End Try
            Return dblResultado
        End Function

  End Class

End Namespace