Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones


Namespace Operaciones

    Public Class CostoMantenimiento_DAL

        Private objSql As New SqlManager

        Public Function Registrar_Costo_Mantenimiento(ByVal objEntidad As CostoMantenimiento) As CostoMantenimiento
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NCOMNT", objEntidad.NCOMNT, ParameterDirection.Output)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSTCNTCS", objEntidad.TCNTCS)
                objParam.Add("PSTTRBES", objEntidad.TTRBES)
                objParam.Add("PSSESTCT", objEntidad.SESTCT)
                objParam.Add("PSTNBPRV", objEntidad.TNBPRV)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSSINDRC", objEntidad.SINDRC)
                objParam.Add("PSTMRCTR", objEntidad.TMRCTR)
                objParam.Add("PSTOPRC", objEntidad.TOPRC)
                objParam.Add("PNIMTOTD", objEntidad.IMTOTD)
                objParam.Add("PNIMTOTS", objEntidad.IMTOTS)
                objParam.Add("PSTFAMIL", objEntidad.TFAMIL)
                objParam.Add("PNITPCMT", objEntidad.ITPCMT)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONSUMO_MANTENIMIENTO", objParam)
                objEntidad.NCOMNT = objSql.ParameterCollection("PON_NCOMNT")
            Catch ex As Exception
                objEntidad.NCOMNT = 0
            End Try
            Return objEntidad
        End Function

        Public Function Validar_Existe_Mes_Anio(ByVal objEntidad As CostoMantenimiento) As Integer
            Dim Resultado As Integer = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_REGIST", objEntidad.NCOMNT, ParameterDirection.Output)
                objParam.Add("PNREGFEC", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_EXISTE_MES_ANIO_CM", objParam)
                Resultado = objSql.ParameterCollection("PON_REGIST")
            Catch ex As Exception
                Resultado = -1
            End Try
            Return Resultado
        End Function

        Public Function Buscar_Costo_Mantenimiento(ByVal objEntidad As CostoMantenimiento) As Boolean
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNCOMNT", 0, ParameterDirection.Output)
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_BUSCAR_CONSUMO_MANTENIMIENTO", objParam)

                If objSql.ParameterCollection("PNNCOMNT") <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function Actualizar_Costo_Mantenimiento(ByVal objEntidad As CostoMantenimiento) As CostoMantenimiento
            Try
                Dim objParam As New Parameter
                objParam.Add("PNREGFEC", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CONSUMO_MANTENIMIENTO", objParam)
                objEntidad.NCOMNT = 1
            Catch ex As Exception
                objEntidad.NCOMNT = 0
            End Try

            Return objEntidad
        End Function

        Public Function Actualizar_Costo_Mantenimiento_Operacion(ByVal objEntidad As CostoMantenimiento) As CostoMantenimiento
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNFLQCMM", objEntidad.FLQCMM)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_CONSUMO_MANTENIMIENTO_OPERACION", objParam)
                objEntidad.NLQMNT = 1
            Catch ex As Exception
                objEntidad.NLQMNT = 0
            End Try
            Return objEntidad
        End Function

        Public Function Registrar_Costo_Mantenimiento_Operacion(ByVal objEntidad As CostoMantenimiento) As CostoMantenimiento
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NLQMNT", objEntidad.NLQMNT, ParameterDirection.Output)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PNFLQCMM", objEntidad.FLQCMM)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
                objParam.Add("PNPMRCMC", objEntidad.PMRCMC)
                objParam.Add("PNIGSTOP", objEntidad.IGSTOP)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONSUMO_MANTENIMIENTO_OPERACION", objParam)
                objEntidad.NLQMNT = objSql.ParameterCollection("PON_NLQMNT")
            Catch ex As Exception
                objEntidad.NLQMNT = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Importe_Soles_X_Mes_Anio(ByVal objParametro As Hashtable) As List(Of CostoMantenimiento)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of CostoMantenimiento)
            Dim objParam As New Parameter
            Dim objEntidad As CostoMantenimiento
            Try
                objParam.Add("PSTIPO", objParametro("TIPO"))
                objParam.Add("PNFECREG", objParametro("FECREG"))
                objParam.Add("PSANIO", objParametro("ANIO"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTE_CONSUMO_MANTENIMIENTO_X_MES_ANIO", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New CostoMantenimiento
                    objEntidad.FECREG = objDataRow("FECREG")
                    objEntidad.IMTOTS = objDataRow("IMTOTS")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of CostoMantenimiento)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Vehiculo_CM_X_Mes_Anio(ByVal objEntidad As CostoMantenimiento) As List(Of CostoMantenimiento)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of CostoMantenimiento)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VEHICULO_CM_X_MES_ANIO", objParam)

                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New CostoMantenimiento
                    objEntidad.FECREG = objDataRow("FECREG")
                    objEntidad.TCNTCS = objDataRow("TCNTCS").ToString().Trim()
                    objEntidad.TTRBES = objDataRow("TTRBES").ToString().Trim()
                    objEntidad.SESTCT = objDataRow("SESTCT").ToString().Trim()
                    objEntidad.TNBPRV = objDataRow("TNBPRV").ToString().Trim()
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.SINDRC = objDataRow("SINDRC")
                    objEntidad.TMRCTR = objDataRow("TMRCTR").ToString().Trim()
                    objEntidad.TOPRC = objDataRow("TOPRC").ToString().Trim()
                    objEntidad.IMTOTD = objDataRow("IMTOTD")
                    objEntidad.IMTOTS = objDataRow("IMTOTS")
                    objEntidad.TFAMIL = objDataRow("TFAMIL").ToString().Trim()
                    objEntidad.ITPCMT = objDataRow("ITPCMT")
                    objEntidad.TOTALS = objDataRow("TOTALS")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Return New List(Of CostoMantenimiento)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Cuadro_Costo_X_Mes_Anio(ByVal objEntidad As CostoMantenimiento) As DataTable 'List(Of CostoMantenimiento)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of CostoMantenimiento)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNFECREG", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_CM_X_MES_ANIO", objParam)
            Catch ex As Exception
                Return New DataTable
            End Try
            Return objDataTable
        End Function

        Public Function Validar_Existe_Costo_Mantenimiento_Operacion(ByVal objEntidad As CostoMantenimiento) As Integer
            Dim Resultado As Integer = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_REGIST", objEntidad.NCOMNT, ParameterDirection.Output)
                objParam.Add("PNFLQCNM", objEntidad.FECREG)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_EXISTE_COSTO_MANTENIMIENTO_OPERACION", objParam)
                Resultado = objSql.ParameterCollection("PON_REGIST")
            Catch ex As Exception
                Resultado = -1
            End Try
            Return Resultado
        End Function

        Public Function Listar_Costo_Mantenimiento_X_Mes_Anio_Excel(ByVal objParametro As Hashtable) As DataTable 'List(Of CostoMantenimiento)
            Dim objDataTable As New DataTable
            Crear_Estructura_CosMan(objDataTable)
            Dim oDr As DataRow
            Dim objParam As New Parameter
            Try
                objParam.Add("PSTIPO", objParametro("TIPO"))
                objParam.Add("PNFECREG", objParametro("FECREG"))
                objParam.Add("PNANIO", objParametro("ANIO"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                For Each dr As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_COSTO_MANTENIMIENTO_EXCEL", objParam).Rows
                    oDr = objDataTable.NewRow
                    oDr.Item("NPLCUN") = dr.Item("NPLCUN").ToString.Trim
                    oDr.Item("FECREG") = Ransa.Utilitario.HelpClass.CFecha_de_8_a_10(dr.Item("FECREG").ToString.Trim)
                    oDr.Item("TCNTCS") = dr.Item("TCNTCS").ToString.Trim
                    oDr.Item("TTRBES") = dr.Item("TTRBES").ToString.Trim
                    oDr.Item("SESTCT") = dr.Item("SESTCT").ToString.Trim
                    oDr.Item("TNBPRV") = dr.Item("TNBPRV").ToString.Trim
                    oDr.Item("SINDRC") = dr.Item("SINDRC").ToString.Trim
                    oDr.Item("TMRCTR") = dr.Item("TMRCTR").ToString.Trim
                    oDr.Item("TOPRC") = dr.Item("TOPRC").ToString.Trim
                    oDr.Item("TFAMIL") = dr.Item("TFAMIL").ToString.Trim
                    oDr.Item("NOPRCN") = dr.Item("NOPRCN").ToString.Trim
                    oDr.Item("NGUIRM") = dr.Item("NGUIRM").ToString.Trim
                    oDr.Item("RUTA") = dr.Item("RUTA").ToString.Trim
                    oDr.Item("PMRCMC") = dr.Item("PMRCMC").ToString.Trim
                    oDr.Item("IGSTOP") = dr.Item("IGSTOP").ToString.Trim
                    objDataTable.Rows.Add(oDr)
                Next
            Catch ex As Exception
                Return New DataTable
            End Try
            Return objDataTable
        End Function

        Private Sub Crear_Estructura_CosMan(ByRef poDt As DataTable)
            poDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("FECREG", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TCNTCS", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TTRBES", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("SESTCT", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TNBPRV", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("SINDRC", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TMRCTR", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TOPRC", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("TFAMIL", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.String)))
            poDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
        End Sub

    End Class
End Namespace