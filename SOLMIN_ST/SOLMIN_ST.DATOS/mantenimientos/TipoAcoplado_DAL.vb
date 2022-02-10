Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Modificación: Rafael Gamboa
'** Fecha de Creación: 15/07/2009 
'** Descripción: capa de acceso a datos .
'****************************************************************************************************
Namespace mantenimientos

    Public Class TipoAcoplado_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As TipoAcoplado
            Try
                Dim objParam As New Parameter

                objParam.Add("PON_CTIACP", objEntidad.CTIACP, ParameterDirection.InputOutput)
                objParam.Add("PSTDEACP", objEntidad.TDEACP)
                objParam.Add("PSTABDES", objEntidad.TABDES)
                objParam.Add("PSTCNFVH", objEntidad.TCNFVH)
                objParam.Add("PSIMGACP", objEntidad.IMGACP)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TIPO_ACOPLADO", objParam)

                objEntidad.CTIACP = objSql.ParameterCollection("PON_CTIACP")

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.CTIACP = 0
            End Try

            Return objEntidad
        End Function

        Public Function Modificar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As TipoAcoplado

            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTIACP", objEntidad.CTIACP)
                objParam.Add("PSTDEACP", objEntidad.TDEACP)
                objParam.Add("PSTABDES", objEntidad.TABDES)
                objParam.Add("PSTCNFVH", objEntidad.TCNFVH)
                objParam.Add("PSIMGACP", objEntidad.IMGACP)
                objParam.Add("PSCULUSA ", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado



                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TIPO_ACOPLADO", objParam)

            Catch ex As Exception
                objEntidad.CTIACP = 0
                MsgBox(ex.Message)
            End Try

            Return objEntidad
        End Function

        Public Function Listar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado) As List(Of TipoAcoplado)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TipoAcoplado)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSTDEACP", objEntidad.TDEACP)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_ACOPLADO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TipoAcoplado
                objDatos.CTIACP = objDataRow("CTIACP").ToString.Trim
                objDatos.TDEACP = objDataRow("TDEACP").ToString.Trim
                objDatos.TABDES = objDataRow("TABDES").ToString.Trim
                objDatos.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objDatos.IMGACP = objDataRow("IMGACP").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                Dim lstr_URL As String = My.Settings.DAL_URL + "imagenes/solmin/acoplado/"
                Dim lstr_URLArchivo As String = lstr_URL & objDataRow("CTIACP").ToString.Trim & ".jpg"
                Dim lstr_URLDefault As String = lstr_URL & "BlankPicture.jpg"
                Try
                    objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLArchivo))
                Catch ex As Exception
                    objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLDefault))
                End Try
                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function


        Public Function Eliminar_Tipo_Acoplado(ByVal objEntidad As TipoAcoplado)
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCTIACP", objEntidad.CTIACP)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TIPO_ACOPLADO", objParam)

            Catch ex As Exception
                objEntidad.CTIACP = 0
            End Try

            Return objEntidad
        End Function

        Public Function Listar_Tipo_Acoplado_Seleccion(ByVal CCMPN As String) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of TipoAcoplado)
            Dim objParam As New Parameter
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_ACOPLADO_SEL", objParam)
            Return objDataTable
        End Function

    End Class

End Namespace