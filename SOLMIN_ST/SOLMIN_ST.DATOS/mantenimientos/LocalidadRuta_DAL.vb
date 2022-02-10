Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

    Public Class LocalidadRuta_DAL
        Private objSql As New SqlManager

        Public Function Listar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As List(Of LocalidadRuta)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of LocalidadRuta)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSTCMLCL", objEntidad.TCMLCL)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LOCALIDAD_RUTA", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New LocalidadRuta

                objDatos.CLCLD = objDataRow("CLCLD").ToString.Trim
                objDatos.TCMLCL = objDataRow("TCMLCL").ToString.Trim
                objDatos.TABLCL = objDataRow("TABLCL").ToString.Trim
                objDatos.CUBGEL = objDataRow("CUBGEL").ToString.Trim
                objDatos.UBIGEO = objDataRow("UBIGEO").ToString.Trim
                objDatos.CUBGEO = objDataRow("CUBGEO").ToString.Trim


                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Registrar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Try
                Dim objParam As New Parameter

                objParam.Add("PSTCMLCL", objEntidad.TCMLCL)
                objParam.Add("PSTABLCL", objEntidad.TABLCL)
                objParam.Add("PNCUBGEL", objEntidad.CUBGEL)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_LOCALIDAD_RUTA", objParam)

            Catch ex As Exception
                objEntidad.CLCLD = 0
            End Try
            Return objEntidad
        End Function

        Public Function Modificar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCLCLD", objEntidad.CLCLD)
                objParam.Add("PSTCMLCL", objEntidad.TCMLCL)
                objParam.Add("PSTABLCL", objEntidad.TABLCL)
                objParam.Add("PNCUBGEL", objEntidad.CUBGEL)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_LOCALIDAD_RUTA", objParam)

            Catch ex As Exception
                objEntidad.CLCLD = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_LocalidadRuta(ByVal objEntidad As LocalidadRuta) As LocalidadRuta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCLCLD", objEntidad.CLCLD)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_LOCALIDAD_RUTA", objParam)

            Catch ex As Exception
                objEntidad.CLCLD = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Ubigeo(ByVal lstr_CCMPN As String) As DataTable
            Dim objDataTable As New DataTable
            'Try
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lstr_CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UBICACION_GEOGRAFICA", Nothing)
            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function
        Public Function Listar_Ubigeo_Todos(ByVal lstr_CCMPN As String) As List(Of LocalidadRuta)
            Dim objDataTable As New DataTable
            Dim oList As New List(Of LocalidadRuta)
            Dim oLocalidadRuta As LocalidadRuta
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lstr_CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UBICACION_GEOGRAFICA", Nothing)
            For Each item As DataRow In objDataTable.Rows
                oLocalidadRuta = New LocalidadRuta
                oLocalidadRuta.CUBGEO = item("UBIGEO")
                oLocalidadRuta.UBIGEO = item("DESCRIPCION")
                oList.Add(oLocalidadRuta)
            Next
            Return oList
        End Function

    End Class
    'UBIGEO
    'DESCRIPCION
End Namespace