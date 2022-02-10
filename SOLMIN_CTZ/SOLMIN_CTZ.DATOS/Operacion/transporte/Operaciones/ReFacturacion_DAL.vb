Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace Operaciones
    Public Class ReFacturacion_DAL

        Public Function Listar_Operaciones_Liquidadas(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PSCPLNDV", param("PNCPLNDV"))
                objParamtero.Add("PNCCLNT", param("PNCCLNT"))
                objParamtero.Add("PNCTPDCF", param("PNCTPDCF"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNFECINI", param("PNFECINI"))
                objParamtero.Add("PNFECFIN", param("PNFECFIN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_OS_FACTURADAS", objParamtero)
            Catch ex As Exception
            End Try
            Return dtQuery
        End Function
        Public Sub Insertar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable)
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter

            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))
                objParamtero.Add("PNCMNDA", param("PNCMNDA"))
                objParamtero.Add("PNIVNTA", param("PNIVNTA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_IMPORTES_X_OPERACIONES_FACTURADAS", objParamtero)
            Catch ex As Exception
            End Try

        End Sub
        Public Sub Eliminar_Servicios_A_ReFacturar(ByVal param As Hashtable)
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter

            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SERVICIOS_A_REFACTURAR", objParamtero)
            Catch ex As Exception
            End Try

        End Sub
        Public Function Listar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))
                objParamtero.Add("PNCMNDA1", param("PNCMNDA1"))
                objParamtero.Add("PNFECFAC", param("PNFECFAC"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTES_X_OPERACIONES_FACTURADAS", objParamtero)
            Catch ex As Exception
            End Try
            Return dtQuery
        End Function
        Public Function Listar_Guias_X_Operaciones(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                ' objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PNCPLNDV", param("PNCPLNDV"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_X_OPERACION_FACTURADAS", objParamtero)
            Catch ex As Exception

            End Try
            Return dtQuery
        End Function
        Public Function Listar_Documentos_Emitidos_x_Operacion(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PNOPRCN", param("PNNOPRCN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOCUMENTOS_EMITIDOS_X_OPERACION", objParamtero)
            Catch ex As Exception
            End Try
            Return dtQuery
        End Function


        Public Function Traer_Importe_Refactura(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtImporte As New DataTable
            Try
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                'objParamtero.Add("PNCTPODC_FC", param("PNCTPODC_FC"))
                'objParamtero.Add("PNCTPODC_RF", param("PNCTPODC_RF"))
                ' objParamtero.Add("PNITCALC", param("PNITCALC"), ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtImporte = objSql.ExecuteDataTable("SP_SOLMIN_ST_TRAER_IMPORTE_REFACTURA", objParamtero)
                'dblImporte = objSql.ParameterCollection("PNITCALC")
            Catch ex As Exception
            End Try
            Return dtImporte
        End Function

        Public Function Listar_Operaciones_Nota_Credito(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                objParamtero.Add("PSNOPRCN", param("PSNOPRCN"))
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PNCTPDCF", param("PNCTPDCF"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_NOTA_CREDITO", objParamtero)
            Catch ex As Exception
            End Try
            Return dtQuery
        End Function
    End Class

End Namespace
