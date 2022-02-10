Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.Operaciones

Namespace Operaciones
    Public Class PlanRuta_DAL
        Dim objSql As SqlManager

        Sub New()
            objSql = New SqlManager()
        End Sub

        Public Function Listar_PlanRutaInicial(ByVal objEntidad As PlanRuta) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNCTZCN", objEntidad.PNNCTZCN)
                objParam.Add("PNNCRRCT", objEntidad.PNNCRRCT)
                objParam.Add("PNNCRRSR", objEntidad.PNNCRRSR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLAN_RUTA", objParam)
            Catch ex As Exception
            End Try
            Return dt
        End Function


        Public Function Listar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLAN_RUTA_VIAJE", objParam)
            Catch ex As Exception
            End Try
            Return dt
        End Function


        Public Function Reporte_PlanRutaViaje(ByVal objEntidad As PlanRuta) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.PSCCMPN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLAN_RUTA_VIAJE_REPORTE", objParam)
            Catch ex As Exception
            End Try
            Return dt
        End Function


        Public Function Listar_PrioridadCarga(ByVal objEntidad As PlanRuta) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.PSCCMPN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLAN_RUTA_VIAJE_PRIORIDAD_CARGA", objParam)
            Catch ex As Exception
            End Try
            Return dt
        End Function


        Public Function Actualizar_PrioridadCarga(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.PSCCMPN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PSFLPRCG", objEntidad.PSFLPRCG)
                objParam.Add("PSCULUSA", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLAN_RUTA_VIAJE_PRIORIDAD_CARGA", objParam)
                Nro_Item = 1
            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

        Public Function Registrar_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNCTZCN", objEntidad.PNNCTZCN)
                objParam.Add("PNNCRRCT", objEntidad.PNNCRRCT)
                objParam.Add("PNNCRRSR", objEntidad.PNNCRRSR)
                objParam.Add("PNCLCLD", objEntidad.PNCLCLD)
                objParam.Add("PNFECSEG", objEntidad.PNFECSEG)

                objParam.Add("PNHRASEG", objEntidad.PNHRASEG)
                objParam.Add("PNQDSTVR", objEntidad.PNQDSTVR)
                objParam.Add("PSTOBS", objEntidad.PSTOBS)

                objParam.Add("PSTPOREG", objEntidad.PSTPOREG)
                objParam.Add("PSSIDAVL", objEntidad.PSSIDAVL)

                objParam.Add("PSUSRCRT", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMCR", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_PLAN_RUTA_INICIAL", objParam)
                Nro_Item = 1

            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

        Public Function Actualiza_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNCTZCN", objEntidad.PNNCTZCN)
                objParam.Add("PNNCRRCT", objEntidad.PNNCRRCT)
                objParam.Add("PNNCRRSR", objEntidad.PNNCRRSR)
                objParam.Add("PNNCRRIT", objEntidad.PNNCRRIT)

                objParam.Add("PNCLCLD", objEntidad.PNCLCLD)
                objParam.Add("PNFECSEG", objEntidad.PNFECSEG)
                objParam.Add("PNHRASEG", objEntidad.PNHRASEG)
                objParam.Add("PNQDSTVR", objEntidad.PNQDSTVR)
                objParam.Add("PSTOBS", objEntidad.PSTOBS)

                objParam.Add("PSTPOREG", objEntidad.PSTPOREG)
                objParam.Add("PSSIDAVL", objEntidad.PSSIDAVL)


                objParam.Add("PSCULUSA", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMCR)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLAN_RUTA_INICIAL", objParam)
                Nro_Item = 1

            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

        Public Function Registrar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNNCRRIT", objEntidad.PNNCRRIT)

                objParam.Add("PNCLCLD", objEntidad.PNCLCLD)
                objParam.Add("PNFECSEG", objEntidad.PNFECSEG)

                objParam.Add("PNHRASEG", objEntidad.PNHRASEG)
                objParam.Add("PNQDSTVR", objEntidad.PNQDSTVR)
                objParam.Add("PSTOBS", objEntidad.PSTOBS)

                objParam.Add("PSTPOREG", objEntidad.PSTPOREG)
                objParam.Add("PSSIDAVL", objEntidad.PSSIDAVL)

                objParam.Add("PSUSRCRT", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMCR", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_PLAN_RUTA_VIAJE", objParam)
                Nro_Item = 1

            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function
        Public Function Actualiza_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNNCRRIT", objEntidad.PNNCRRIT)

                objParam.Add("PNCLCLD", objEntidad.PNCLCLD)
                objParam.Add("PNFECSEG", objEntidad.PNFECSEG)
                objParam.Add("PNHRASEG", objEntidad.PNHRASEG)
                objParam.Add("PNQDSTVR", objEntidad.PNQDSTVR)
                objParam.Add("PSTOBS", objEntidad.PSTOBS)
                objParam.Add("PSTPOREG", objEntidad.PSTPOREG)
                objParam.Add("PSSIDAVL", objEntidad.PSSIDAVL)
                objParam.Add("PSCULUSA", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLAN_RUTA_VIAJE", objParam)
                Nro_Item = 1
            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

        Public Function Eliminar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNNCRRIT", objEntidad.PNNCRRIT)
                objParam.Add("PSTPOREG", objEntidad.PSTPOREG)
                objParam.Add("PSCULUSA", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_PLAN_RUTA_VIAJE", objParam)
                Nro_Item = 1
            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

        Public Function Elimina_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
            Dim Nro_Item As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNCTZCN", objEntidad.PNNCTZCN)
                objParam.Add("PNNCRRCT", objEntidad.PNNCRRCT)
                objParam.Add("PNNCRRSR", objEntidad.PNNCRRSR)
                objParam.Add("PNNCRRIT", objEntidad.PNNCRRIT)
                objParam.Add("PSCULUSA", objEntidad.PSUSRCRT)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_PLAN_RUTA_INICIAL", objParam)
                Nro_Item = 1
            Catch ex As Exception
                Nro_Item = 0
            End Try
            Return Nro_Item
        End Function

    End Class
End Namespace
