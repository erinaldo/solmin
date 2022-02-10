Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

  Public Class Reportes_DAL

    Private objSql As New SqlManager

    Public Function Listado_Tarifas_por_Cliente_Ordenes_Servicio(ByVal objEntidad As ReporteListadoTarifas) As DataSet
      Dim objResultado As New DataSet
      Dim dt As New DataTable
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
        objParam.Add("PARAM_SESTOS", objEntidad.SESTOS)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_LISTA_TARIFAS_ORDENES_SERVICIO", objParam)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_LISTA_TARIFAS_ORDENES_SERVICIO_V2", objParam)
                For Each item As DataRow In dt.Rows
                    item("FECHA_ORDEN_SERVICIO") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FECHA_ORDEN_SERVICIO"))
                Next


        dt.TableName = "Listado_Tarifas_x_Orden_Servicio"
        objResultado.Tables.Add(dt)

      Catch ex As Exception
      End Try
      Return objResultado
    End Function

    Public Function Listado_Ordenes_ServicioxCliente(ByVal objEntidad As ReporteListadoTarifas) As DataSet
      Dim objResultado As New DataSet
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_CCLNT", IIf(objEntidad.CCLNT = 0, "", objEntidad.CCLNT))
        objParam.Add("PARAM_SESTOS", objEntidad.SESTOS)

        Dim dt As New DataTable
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_LISTA_ORDENES_SERVICIO", objParam)
        dt.TableName = "LISTADO_ORDEN_SERVICIO"
        objResultado.Tables.Add(dt)

      Catch
        objResultado = Nothing
      End Try
      Return objResultado
    End Function

    Public Function Lista_Detalle_Operaciones_X_OS(ByVal NumOs As String) As DataSet
      Dim objResultado As New DataSet
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_NORSRT", NumOs)

        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_LISTA_DETALLEOPERACIONES_X_OS", objParam)
        dt.TableName = "LISTADO_DETALLE_ORDEN_SERVICIO"
        objResultado.Tables.Add(dt)

      Catch
        objResultado = Nothing
      End Try
      Return objResultado
    End Function

    Public Function Lista_Planeamiento_X_Operacion(ByVal oPlaneamientoBE As Planeamiento) As DataSet
      Dim objResultado As New DataSet
      Dim oListaPlaneamiento As New List(Of Planeamiento)
      Try
        Dim objParam As New Parameter
        objParam.Add("PARAM_NPLNMT", oPlaneamientoBE.NPLNMT)
        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTA_PLANEAMIENTO_X_OERACION", objParam)
        dt.TableName = "LISTADO_PLANEAMIENTO_X_OERACION"
                objResultado.Tables.Add(dt)
      Catch
        objResultado = Nothing
      End Try
      Return objResultado
    End Function

        Public Function Reporte_Rendimiento_Vehicular(ByVal objEntidad As List(Of String)) As DataTable
            Dim dtb As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PSCCMPN", objEntidad(0))
                objParam.Add("PSCDVSN", objEntidad(1))
                objParam.Add("PNCPLNDV", objEntidad(2))
                objParam.Add("PNCCLNT", objEntidad(3))
                objParam.Add("PNCTRMNC", objEntidad(4))
                objParam.Add("PNFECINI", objEntidad(5))
                objParam.Add("PNFECFIN", objEntidad(6))
                objParam.Add("PSNPLCTR", objEntidad(7))
                objParam.Add("PSCRGVTA", objEntidad(8))
                dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VEHICULOS_RENDIMIENTO_LM", objParam)
                'dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VEHICULOS_RENDIMIENTO_PRD", objParam)
            Catch ex As Exception
                dtb = Nothing
            End Try
            Return dtb
        End Function

        Public Function Reporte_Rendimiento_Vehicular_Operacion(ByVal objEntidad As List(Of String)) As DataTable
            Dim dtb As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PSCCMPN", objEntidad(0))
                objParam.Add("PSCDVSN", objEntidad(1))
                objParam.Add("PNCPLNDV", objEntidad(2))
                objParam.Add("PNCCLNT", objEntidad(3))
                objParam.Add("PNCTRMNC", objEntidad(4))
                objParam.Add("PNFECINI", objEntidad(5))
                objParam.Add("PNFECFIN", objEntidad(6))
                objParam.Add("PSNPLCTR", objEntidad(7))
                objParam.Add("PSCRGVTA", objEntidad(8))
                dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VEHICULOS_OPERACION_RENDIMIENTO_LM", objParam)
            Catch ex As Exception
                dtb = Nothing
            End Try
            Return dtb
        End Function
    End Class
End Namespace