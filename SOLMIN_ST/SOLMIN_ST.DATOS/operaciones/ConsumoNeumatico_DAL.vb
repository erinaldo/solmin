Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones

    Public Class ConsumoNeumatico_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Consumo_Neumatico(ByVal objEntidad As ConsumoNeumatico) As ConsumoNeumatico
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NCONEU", objEntidad.NCONEU, ParameterDirection.Output)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSTDETRA", objEntidad.TDETRA)
                objParam.Add("PSTCRVTA", objEntidad.TCRVTA)
                objParam.Add("PSNROSER", objEntidad.NROSER)
                objParam.Add("PSTMRCTR", objEntidad.TMRCTR)
                objParam.Add("PSTRFMED", objEntidad.TRFMED)
                objParam.Add("PSTRFDIS", objEntidad.TRFDIS)
                objParam.Add("PNQATNAN", objEntidad.QATNAN)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("PNIMPUNI", objEntidad.IMPUNI)
                objParam.Add("PNIMPTTL", objEntidad.IMPTTL)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONSUMO_NEUMATICO", objParam)
                objEntidad.NCONEU = objSql.ParameterCollection("PON_NCONEU")
            Catch ex As Exception
                objEntidad.NCONEU = 0
            End Try
            Return objEntidad
        End Function

        Public Function Validar_Existe_Mes_Anio(ByVal objEntidad As ConsumoNeumatico) As Integer
            Dim Resultado As Integer = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_REGIST", objEntidad.NCONEU, ParameterDirection.Output)
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_EXISTE_MES_ANIO_CN", objParam)
                Resultado = objSql.ParameterCollection("PON_REGIST")
            Catch ex As Exception
                Resultado = -1
            End Try
            Return Resultado
        End Function

        Public Function Eliminar_Consumo_Neumatico(ByVal objEntidad As ConsumoNeumatico) As ConsumoNeumatico
            Try
                Dim objParam As New Parameter
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CONSUMO_NEUMATICO", objParam)
                objEntidad.NCONEU = 1
            Catch ex As Exception
                objEntidad.NCONEU = 0
            End Try

            Return objEntidad
        End Function

        Public Function Registrar_Consumo_Neumatico_Operacion(ByVal objEntidad As ConsumoNeumatico) As ConsumoNeumatico
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NLQNEM", objEntidad.NLQNEM, ParameterDirection.Output)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PNFLQCNM", objEntidad.FLQCNM)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
                objParam.Add("PNPMRCMC", objEntidad.PMRCMC)
                objParam.Add("PNIGSTOP", objEntidad.IGSTOP)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONSUMO_NEUMATICO_OPERACION", objParam)
                objEntidad.NLQNEM = objSql.ParameterCollection("PON_NLQNEM")
            Catch ex As Exception
                objEntidad.NCONEU = 0
            End Try
            Return objEntidad
        End Function

        Public Function Actualizar_Consumo_Neumatico_Operacion(ByVal objEntidad As ConsumoNeumatico) As ConsumoNeumatico
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNFLQCNM", objEntidad.FLQCNM)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_CONSUMO_NEUMATICO_OPERACION", objParam)
                objEntidad.NLQNEM = 1
            Catch ex As Exception
                objEntidad.NLQNEM = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Importe_Soles_X_Mes_Anio(ByVal objParametro As Hashtable) As List(Of ConsumoNeumatico)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ConsumoNeumatico)
            Dim objParam As New Parameter
            Dim objEntidad As ConsumoNeumatico
            Try
                objParam.Add("PSTIPO", objParametro("TIPO"))
                objParam.Add("PNFECREG", objParametro("FECREG"))
                objParam.Add("PSANIO", objParametro("ANIO"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTES_MES_ANIO", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New ConsumoNeumatico
                    objEntidad.FECREG = objDataRow("FECREG")
                    objEntidad.QATNAN = objDataRow("QATNAN")
                    objEntidad.IMPTTL = objDataRow("IMPTTL")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of ConsumoNeumatico)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Vehiculo_X_Mes_Anio(ByVal objEntidad As ConsumoNeumatico) As List(Of ConsumoNeumatico)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ConsumoNeumatico)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VEHICULO_X_MES_ANIO", objParam)

                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New ConsumoNeumatico
                    objEntidad.FECREG = objDataRow("FECREG")
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.TDETRA = objDataRow("TDETRA").ToString().Trim()
                    objEntidad.TCRVTA = objDataRow("TCRVTA")
                    objEntidad.NROSER = objDataRow("NROSER")
                    objEntidad.TMRCTR = objDataRow("TMRCTR")
                    objEntidad.TRFMED = objDataRow("TRFMED")
                    objEntidad.TRFDIS = objDataRow("TRFDIS")
                    objEntidad.QATNAN = objDataRow("QATNAN")
                    objEntidad.TOBS = objDataRow("TOBS").ToString().Trim()
                    objEntidad.IMPUNI = objDataRow("IMPUNI")
                    objEntidad.IMPTTL = objDataRow("IMPTTL")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of ConsumoNeumatico)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Cuadro_Costo_X_Mes_Anio(ByVal objEntidad As ConsumoNeumatico) As DataTable 'List(Of ConsumoNeumatico)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ConsumoNeumatico)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_X_MES_ANIO", objParam)

            Catch ex As Exception
                Return New DataTable
            End Try

            Return objDataTable
        End Function

        Public Function Validar_Existe_Consumo_Neumatico_Operacion(ByVal objEntidad As ConsumoNeumatico) As Integer
            Dim Resultado As Integer = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_REGIST", objEntidad.NCONEU, ParameterDirection.Output)
                objParam.Add("PNFLQCNM", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_EXISTE_CONSUMO_NEUMATICO_OPERACION", objParam)
                Resultado = objSql.ParameterCollection("PON_REGIST")
            Catch ex As Exception
                Resultado = -1
            End Try
            Return Resultado
        End Function

        Public Function Listar_Consumo_Neumatico_X_Mes_Anio_Excel(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Crear_Estructura_ConNeu(objDataTable)
            Dim objParam As New Parameter
            Dim oDr As DataRow
            Try
                objParam.Add("PSTIPO", objParametro("TIPO"))
                objParam.Add("PNFECREG", objParametro("FECREG"))
                objParam.Add("PSANIO", objParametro("ANIO"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                For Each dr As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONSUMO_NEUMATICO_EXCEL", objParam).Rows
                    oDr = objDataTable.NewRow
                    oDr.Item("NPLCUN") = dr.Item("NPLCUN").ToString.Trim
                    oDr.Item("FECREG") = Ransa.Utilitario.HelpClass.CFecha_de_8_a_10(dr.Item("FECREG").ToString.Trim)
                    oDr.Item("TDETRA") = dr.Item("TDETRA").ToString.Trim
                    oDr.Item("TCRVTA") = dr.Item("TCRVTA").ToString.Trim
                    oDr.Item("NROSER") = dr.Item("NROSER").ToString.Trim
                    oDr.Item("TRFDIS") = dr.Item("TRFDIS").ToString.Trim
                    oDr.Item("TRFMED") = dr.Item("TRFMED").ToString.Trim
                    oDr.Item("TMRCTR") = dr.Item("TMRCTR").ToString.Trim
                    oDr.Item("NOPRCN") = dr.Item("NOPRCN").ToString.Trim
                    oDr.Item("NGUIRM") = dr.Item("NGUIRM").ToString.Trim
                    oDr.Item("RUTA") = dr.Item("RUTA").ToString.Trim
                    oDr.Item("PMRCMC") = dr.Item("PMRCMC")
                    oDr.Item("NKMRCR") = dr.Item("NKMRCR").ToString.Trim
                    oDr.Item("IGSTOP") = dr.Item("IGSTOP").ToString.Trim
                    objDataTable.Rows.Add(oDr)
                Next
            Catch ex As Exception
                Return New DataTable
            End Try
            Return objDataTable
        End Function

        Private Sub Crear_Estructura_ConNeu(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("FECREG", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TDETRA", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TCRVTA", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("NROSER", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TRFDIS", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TRFMED", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TMRCTR", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.Double)))
            poDt.Columns.Add(New DataColumn("NKMRCR", GetType(System.Double)))
            poDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
        End Sub

    End Class



End Namespace