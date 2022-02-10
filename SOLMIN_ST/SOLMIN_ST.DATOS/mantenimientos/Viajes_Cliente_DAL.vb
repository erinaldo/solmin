Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
    Public Class Viajes_Cliente_DAL
        Private objSql As New SqlManager
        Public Function Insertar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Try
                Dim objParam As New Parameter
                ' objParam.Add("PNNPRGVJ", obe_Viajes_Cliente.PNNPRGVJ)
                objParam.Add("PNFCHPSA", obe_Viajes_Cliente.PNFCHPSA_1)
                objParam.Add("PNHRAPSA", obe_Viajes_Cliente.PNHRAPSA_1)
                objParam.Add("PSCCMPN", obe_Viajes_Cliente.PSCCMPN)
                objParam.Add("PNCMEDTR", obe_Viajes_Cliente.PNCMEDTR)
                objParam.Add("PNCCLNT", obe_Viajes_Cliente.PNCCLNT)
                objParam.Add("PSSESTRG", obe_Viajes_Cliente.PSSESTRG)
                objParam.Add("PSCUSCRT", obe_Viajes_Cliente.PSCUSCRT)
                objParam.Add("PNFCHCRT", obe_Viajes_Cliente.PNFCHCRT)
                objParam.Add("PNHRACRT", obe_Viajes_Cliente.PNHRACRT)
                objParam.Add("PSNTRMCR", obe_Viajes_Cliente.PSNTRMCR)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Viajes_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VIAJE_CLIENTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Actualizar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPRGVJ", obe_Viajes_Cliente.PNNPRGVJ)
                objParam.Add("PNFCHPSA", obe_Viajes_Cliente.PNFCHPSA_1)
                objParam.Add("PNHRAPSA", obe_Viajes_Cliente.PNHRAPSA_1)
                objParam.Add("PSCCMPN", obe_Viajes_Cliente.PSCCMPN)
                objParam.Add("PNCMEDTR", obe_Viajes_Cliente.PNCMEDTR)
                objParam.Add("PNCCLNT", obe_Viajes_Cliente.PNCCLNT)
                objParam.Add("PSCULUSA", obe_Viajes_Cliente.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Viajes_Cliente.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Viajes_Cliente.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Viajes_Cliente.PSNTRMNL)
                objParam.Add("VAR_MESSAGE", 0, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Viajes_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_VIAJE_CLIENTE", objParam)

                Return objSql.ParameterCollection.Item("VAR_MESSAGE")
            Catch ex As Exception
                ' -1 'Update Error
                Return -1
            End Try
        End Function

        Public Function Listar_Viaje_Cliente(ByVal objViajes_Cliente As Viajes_Cliente) As List(Of Viajes_Cliente)
            Dim oDt As New DataTable
            Dim olbeViajes_Cliente As New List(Of Viajes_Cliente)
            Dim objParam As New Parameter
            Try

                objParam.Add("PNCCLNT", objViajes_Cliente.PNCCLNT)
                objParam.Add("PSCCMPN", objViajes_Cliente.PSCCMPN)
                objParam.Add("PNCMEDTR", objViajes_Cliente.PNCMEDTR)
                objParam.Add("PNFINI", objViajes_Cliente.PNFINI)
                objParam.Add("PNFFIN", objViajes_Cliente.PNFFIN)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objViajes_Cliente.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VIAJE_CLIENTE", objParam)
                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Viajes_Cliente
                    objEntidad.PNNPRGVJ = objDataRow("NPRGVJ").ToString.Trim
                    objEntidad.PSFCHPSA = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCHPSA").ToString.Trim)
                    objEntidad.PSHRAPSA = objDataRow("HRAPSA").ToString.Trim
                    objEntidad.PNHRAPSA_1 = objDataRow("HRAPSA_1").ToString.Trim
                    objEntidad.PNFCHPSA_1 = objDataRow("FCHPSA_1").ToString.Trim

                    objEntidad.PSCCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.PNCMEDTR = objDataRow("CMEDTR").ToString.Trim
                    objEntidad.PSTNMMDT = objDataRow("TNMMDT").ToString.Trim
                    objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.PSTCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.PNCANTRUTA = objDataRow("CANTRUTA").ToString.Trim
                    objEntidad.PNCANTPASAJERO = objDataRow("CANTPASAJERO").ToString.Trim
                    olbeViajes_Cliente.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbeViajes_Cliente
        End Function


        Public Function Listar_MedioTransporte(ByVal strCompañia As String) As DataTable
            Dim objResultado As New DataTable
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompañia)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MEDIO_TRANSPORTE_V2", Nothing)
            Catch ex As Exception
            End Try
            Return objResultado
        End Function

        Public Function Eliminar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNPRGVJ", obe_Viajes_Cliente.PNNPRGVJ)
                objParam.Add("PSSESTRG", obe_Viajes_Cliente.PSSESTRG)
                objParam.Add("PSCULUSA", obe_Viajes_Cliente.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Viajes_Cliente.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Viajes_Cliente.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Viajes_Cliente.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Viajes_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VIAJE_CLIENTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

    End Class
End Namespace



