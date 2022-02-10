Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones
  Public Class LiquidacionCombustible_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible) As LiquidacionCombustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PON_NLQCMB", objEntidad.NLQCMB, ParameterDirection.Output)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNFLQDCN", objEntidad.FLQDCN)
        objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
        objParam.Add("PNQGLNSA", objEntidad.QGLNSA)
        objParam.Add("PNQTGLIN", objEntidad.QTGLIN)
        objParam.Add("PNQGLNUT", objEntidad.QGLNUT)
        objParam.Add("PSUSRCRT", objEntidad.USRCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_LIQUIDACION_COMBUSTIBLE", objParam)
        objEntidad.NLQCMB = objSql.ParameterCollection("PON_NLQCMB")
      Catch ex As Exception
        objEntidad.NLQCMB = 0
      End Try
      Return objEntidad
    End Function

    Public Function Registrar_Detalle_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible) As LiquidacionCombustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
        objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
        objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
        objParam.Add("PNQTCSDA", objEntidad.QTCSDA)
        objParam.Add("PNQTCLLG", objEntidad.QTCLLG)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_LIQUIDACION_COMBUSTIBLE", objParam)
      Catch ex As Exception
        objEntidad.NLQCMB = 0
      End Try
      Return objEntidad
    End Function

    Public Function Validar_Existencia_Operacion_Liquidacion(ByVal objParameter As Hashtable) As Int64
      Dim lstatus As Integer = 0
      Try
        Dim objParam As New Parameter
        objParam.Add("PON_NOPRCN", objParameter("NOPRCN"), ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_OPERACION_LIQUIDAR", objParam)
        lstatus = objSql.ParameterCollection("PON_NOPRCN")
      Catch ex As Exception
        lstatus = 0
      End Try
      Return lstatus
    End Function

    Public Function Listar_Liquidacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      'Dim objDataTable As New DataTable
      Dim objEntidad As LiquidacionCombustible
      Dim objGenericCollection As New List(Of LiquidacionCombustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_COMBUSTIBLE_X_TRACTO", objParam).Rows
          objEntidad = New LiquidacionCombustible
          objEntidad.NLQCMB = objDataRow("NLQCMB")
          objEntidad.FLQDCN_D = objDataRow("FLQDCN").ToString.Trim
          objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objEntidad.QGLNSA = objDataRow("QGLNSA")
          objEntidad.QTGLIN = objDataRow("QTGLIN")
          objEntidad.QGLNUT = objDataRow("QGLNUT")
          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Detalle_Liquidacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      Dim objEntidad As LiquidacionCombustible
      Dim objGenericCollection As New List(Of LiquidacionCombustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))

        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_DETALLE_LIQUIDACION_COMBUSTIBLE_X_TRACTO", objParam).Rows
          objEntidad = New LiquidacionCombustible

          objEntidad.NLQCMB = objDataRow("NLQCMB")
          objEntidad.NOPRCN = objDataRow("NOPRCN").ToString.Trim
          objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
          objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
          objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objEntidad.NKMRCR = objDataRow("NKMRCR").ToString.Trim
          objEntidad.QGLNCM = objDataRow("QGLNCM")
          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Detalle_Liquidacion_Vales_x_Tractos(ByVal objParametro As Hashtable) As List(Of Combustible)
      Dim objEntidad As Combustible
      Dim objGenericCollection As New List(Of Combustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PSSESSLC", objParametro("PSSESSLC"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ASIGNACION_COMBUSTIBLE_X_TRACTO", objParam).Rows
          objEntidad = New Combustible
          objEntidad.NSLCMB = objDataRow("NSLCMB")
          objEntidad.NVLGRF = objDataRow("NVLGRF").ToString.Trim
          objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
          objEntidad.FSLCMB_S = objDataRow("FSLCMB_S").ToString.Trim
          objEntidad.FCRCMB_S = objDataRow("FCRCMB_S").ToString.Trim
          objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objEntidad.QGLNCM = objDataRow("QGLNCM")
          objEntidad.CSTGLN = objDataRow("CSTGLN")
          objEntidad.SESSLC = objDataRow("SESSLC").ToString.Trim
          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Lista_Vales_Ruta_x_Tracto(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      Dim objEntidad As LiquidacionCombustible
      Dim objGenericCollection As New List(Of LiquidacionCombustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_RUTA_X_TRACTO", objParam).Rows
          objEntidad = New LiquidacionCombustible

          objEntidad.NVLGRF = objDataRow("NVLGRF")
          objEntidad.FCRCMB_S = objDataRow("FCRCMB").ToString.Trim
          objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objEntidad.QGLNCM = objDataRow("QGLNCM")
          objEntidad.NOPRCN = objDataRow("NOPRCN")
          objEntidad.CGRFO = objDataRow("CGRFO").ToString.Trim
          objEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim
          objEntidad.CSTGLN = objDataRow("CSTGLN")
          objEntidad.ICSTOS = objDataRow("ICSTOS")

          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
        End Function

        Public Function Listar_Liquidacion_Combustible_x_Operacion(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNROPRCN", objParametro("PNNOPRCN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_COMBUSTIBLE_X_OPERACION", objParam).Rows
                    objEntidad = New LiquidacionCombustible
                    objEntidad.NLQCMB = objDataRow("NLQCMB")
                    objEntidad.FLQDCN = objDataRow("FLQDCN")
                    objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                    objEntidad.QTGLIN = objDataRow("QTGLIN")
                    objEntidad.QGLNUT = objDataRow("QGLNUT")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_Liquidada(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_LIQUIDADA", objParam).Rows
                    objEntidad = New LiquidacionCombustible
                    objEntidad.NLQCMB = objDataRow("NLQCMB")
                    'objEntidad.FLQDCN = objDataRow("FLQDCN")
                    'objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                    objEntidad.QTGLIN = objDataRow("QTGLIN")
                    objEntidad.QGLNUT = objDataRow("QGLNUT")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Actualizar_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible) As LiquidacionCombustible
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNQTGLIN", objEntidad.QTGLIN)
                objParam.Add("PNQGLNUT", objEntidad.QGLNUT)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PSUSRCRT", objEntidad.USRCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.NLQCMB)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_LIQ_COMB_UTI", objParam)                
            Catch ex As Exception
                objEntidad.NLQCMB = 0
            End Try
            Return objEntidad
        End Function



        '' PARA LIQUIDACION

   

        'Public Function obtener_Nro_Liq_Corr() As DataTable
        '    Dim objDataTable As New DataTable

        '    Try
        '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_CORR_LIQ", Nothing)
        '        Return objDataTable
        '    Catch
        '        Return New DataTable
        '    End Try
        'End Function

        Public Function cargar_vehiculo(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter
            Try

                objParam.Add("PNCCMPN", objParametro("CCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_VEHICULO", objParam).Rows
                    objEntidad = New LiquidacionCombustible
                    objEntidad.NPLCUN = objDataRow("NPLCUN")
                    objEntidad.TMRCTR = objDataRow("TMRCTR")
                    objGenericCollection.Add(objEntidad)
                Next

                Return objGenericCollection
            Catch ex As Exception
                Return objGenericCollection
            End Try

        End Function
        Public Sub registrar_inf_escaner_liquidacion(ByVal objEntidad As Hashtable)
            Dim ob As New LiquidacionCombustible
            'Try
            Dim objParam As New Parameter
            'objParam.Add("PNINDICE", objEntidad("INDICE"))
            objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
            objParam.Add("PNKMSINI", objEntidad("PNKMSINI"))
            objParam.Add("PNKMSFIN", objEntidad("PNKMSFIN"))
            objParam.Add("PNKMSRCR", objEntidad("PNKMSRCR"))
            'objParam.Add("PNQGUREA", objEntidad("PNQGUREA"))
            'objParam.Add("PNCGUREA", objEntidad("PNCGUREA"))

            objParam.Add("PNDSTVJE", objEntidad("PNDSTVJE"))
            objParam.Add("PNCMVJE", objEntidad("PNCMVJE"))
            objParam.Add("PNPROCC", objEntidad("PNPROCC"))

            objParam.Add("PNCSMVJE", objEntidad("PNCSMVJE"))
            objParam.Add("PNCDUCC", objEntidad("PNCDUCC"))
            objParam.Add("PNVJECRU", objEntidad("PNVJECRU"))
            objParam.Add("PNTMVJE", objEntidad("PNTMVJE"))


            objParam.Add("PNVJERNE", objEntidad("PNVJERNE"))
            objParam.Add("PNVJESBR", objEntidad("PNVJESBR"))
            objParam.Add("PNCMVJENE", objEntidad("PNCMVJENE"))
            objParam.Add("PNVMVJE", objEntidad("PNVMVJE"))


            objParam.Add("PNDSPVJE", objEntidad("PNDSPVJE"))
            objParam.Add("PNSBRVLD", objEntidad("PNSBRVLD"))
            objParam.Add("PNHRMVJE", objEntidad("PNHRMVJE"))
            objParam.Add("PNTMRVJE", objEntidad("PNTMRVJE"))
            objParam.Add("PNCMRVJE", objEntidad("PNCMRVJE"))

        


            objParam.Add("PNDSTTAL", objEntidad("PNDSTTAL"))
            objParam.Add("PNCOBTAL", objEntidad("PNCOBTAL"))
            objParam.Add("PNMTRTAL", objEntidad("PNMTRTAL"))
            objParam.Add("PNTMRTAL", objEntidad("PNTMRTAL"))

            'objParam.Add("PNRETOMQ", objEntidad("PNRETOMQ"))
            'objParam.Add("PNTMVJE", objEntidad("PNTMVJE"))
            'objParam.Add("PNCCONS", objEntidad("PNCCONS"))
            objParam.Add("PSCULUSA", objEntidad("PSCULUSA"))
            objParam.Add("PSNTRMNL", objEntidad("PSNTRMNL"))
            objParam.Add("PSTOBS", objEntidad("PSTOBS"))
            '

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_INF_ESCANER", objParam)

            'ob.NLQCMB = 1

            'Catch ex As Exception
            '    ob.NLQCMB = 0
            '    Return ob
            'End Try
            'Return ob
        End Sub


        'Public Function Registrar_Liquidacion(ByVal objEntidad As Hashtable) As LiquidacionCombustible
        '    Dim ob As New LiquidacionCombustible
        '    Try



        '        Dim objParam As New Parameter
        '        objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
        '        objParam.Add("PSCCMPN", objEntidad("PNCCMPN"))
        '        objParam.Add("PSCDVSN", objEntidad("PNCDVSN"))
        '        objParam.Add("PNCPLNDV", objEntidad("PNCPLNDV"))
        '        objParam.Add("PNFLQDCN", objEntidad("PNFLQDCN"))


        '        objParam.Add("PSCTPCMB", objEntidad("PNCTPCMB"))
        '        objParam.Add("PNQGLNSA", objEntidad("PNQGLNSA"))
        '        objParam.Add("PNQTGLIN", objEntidad("PNQTGLIN"))
        '        objParam.Add("PNQGLNUT", objEntidad("PNQGLNUT"))

        '        objParam.Add("PSUSRCRT", objEntidad("PNUSRCRT"))
        '        objParam.Add("PNFCHCRT", objEntidad("PNFCHCRT"))
        '        objParam.Add("PNHRACRT", objEntidad("PNHRACRT"))
        '        objParam.Add("PSNTRMNL", objEntidad("NTRMNL"))

        '        objParam.Add("PNNPLCUN", objEntidad("PNNPLCUN"))


        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_LIQUIDACION_COMBUSTIBLE", objParam)

        '        ob.NLQCMB = 1


        '    Catch ex As Exception
        '        ob.NLQCMB = 0
        '        Return ob
        '    End Try
        '    Return ob

        'End Function

        Public Sub Registrar_Detalle_Liquidacion_Combustible2(ByVal objEntidad As LiquidacionCombustible)
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            'objParam.Add("PNNKMRCR", objEntidad.NKMRCR)
            'objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
            'objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            'objParam.Add("PNQTCSDA", objEntidad.QTCSDA)
            'objParam.Add("PNQTCLLG", objEntidad.QTCLLG)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_LIQUIDACION_COMBUSTIBLE2", objParam)
            'Catch ex As Exception
            '    objEntidad.NLQCMB = 0
            'End Try
            'Return objEntidad
        End Sub

        Public Function Listar_Imagenes_x_Liquidacion(ByVal OBJPARAMETRO As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNLQCMB", OBJPARAMETRO("PNNLQCMB"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(OBJPARAMETRO("PSCCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_IMAGENES", objParam).Rows
                    objEntidad = New LiquidacionCombustible

                    objEntidad.NLQCMB = objDataRow("NLQCMB")
                    objEntidad.RUTA = objDataRow("RUTA")
                    objEntidad.IMG = objDataRow("IMG")
                    objEntidad.EXT = objDataRow("EXT")


                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function
        Public Function Registrar_Liquidacion(ByVal objEntidad As Hashtable) As LiquidacionCombustible
            Dim ob As New LiquidacionCombustible
            Try



                Dim objParam As New Parameter
                objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
                objParam.Add("PSCCMPN", objEntidad("PNCCMPN"))
                objParam.Add("PSCDVSN", objEntidad("PNCDVSN"))
                objParam.Add("PNCPLNDV", objEntidad("PNCPLNDV"))
                objParam.Add("PNFLQDCN", objEntidad("PNFLQDCN"))


                objParam.Add("PSCTPCMB", objEntidad("PNCTPCMB"))
                objParam.Add("PNQGLNSA", objEntidad("PNQGLNSA"))
                objParam.Add("PNQTGLIN", objEntidad("PNQTGLIN"))
                objParam.Add("PNQGLNUT", objEntidad("PNQGLNUT"))

                objParam.Add("PSUSRCRT", objEntidad("PNUSRCRT"))
                objParam.Add("PNFCHCRT", objEntidad("PNFCHCRT"))
                objParam.Add("PNHRACRT", objEntidad("PNHRACRT"))
                objParam.Add("PSNTRMNL", objEntidad("NTRMNL"))

                objParam.Add("PNNPLCUN", objEntidad("PNNPLCUN"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_LIQUIDACION_COMBUSTIBLE", objParam)

                ob.NLQCMB = 1


            Catch ex As Exception
                ob.NLQCMB = 0
                Return ob
            End Try
            Return ob

        End Function
        Public Function Actualizar_Importe_Vale_Desde_Excel(ByVal objEntidad As LiquidacionCombustible) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSNRUCPR", objEntidad.NRUCPR)
            objParam.Add("PSREF_GRIFO", objEntidad.REF_GRIFO)
            objParam.Add("PSNVLGRS", objEntidad.NVLGRS)
            objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.NLQCMB)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ACTUALIZAR_IMPORTE_VALE_DESDE_EXCEL", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            msg = msg.Trim
            'Return objEntidad
            Return msg
        End Function

        Public Function Registrar_Liquidacion_Tracto(ByVal objEntidad As Hashtable, ByRef pNLQCMB As Decimal) As String
            'Dim ob As New LiquidacionCombustible

            Dim dtresult As New DataTable
            Dim msg As String = ""

            Dim objParam As New Parameter
            'objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
            objParam.Add("PSCCMPN", objEntidad("PNCCMPN"))
            objParam.Add("PSCDVSN", objEntidad("PNCDVSN"))
            objParam.Add("PNCPLNDV", objEntidad("PNCPLNDV"))
            'objParam.Add("PNFLQDCN", objEntidad("PNFLQDCN"))
            'objParam.Add("PSCTPCMB", objEntidad("PNCTPCMB"))
            'objParam.Add("PNQGLNSA", objEntidad("PNQGLNSA"))
            'objParam.Add("PNQTGLIN", objEntidad("PNQTGLIN"))
            'objParam.Add("PNQGLNUT", objEntidad("PNQGLNUT"))
            objParam.Add("PSCUSRCRT", objEntidad("PSCUSRCRT"))
            'objParam.Add("PNFCHCRT", objEntidad("PNFCHCRT"))
            'objParam.Add("PNHRACRT", objEntidad("PNHRACRT"))
            objParam.Add("PSNTRMNL", objEntidad("PSNTRMNL"))
            objParam.Add("PSNPLCUN", objEntidad("PSNPLCUN"))
            objParam.Add("PSTOBS", objEntidad("PSTOBS"))


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_LIQUIDACION_COMBUSTIBLE_V3", objParam)
            For Each item As DataRow In dtresult.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next

            If msg = "" And dtresult.Rows.Count > 0 Then
                pNLQCMB = dtresult.Rows(0)("CGENERADO")
            End If
            Return msg

        End Function
        Public Function Listar_Liquidacion_Combustible(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter

            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            objParam.Add("PNCPLNDV", objParametro("CPLNDV"))        'PLANTA
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNNPLCUN", objParametro("NPLCUN"))
            'TRANSPORTISTA
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_COMBUSTIBLE", objParam).Rows
                objEntidad = New LiquidacionCombustible
                objEntidad.FLQDCN = objDataRow("FLQDCN")
                objEntidad.NLQCMB = objDataRow("NLQCMB")
                objEntidad.CTPCMB = objDataRow("CTPCMB")
                objEntidad.QTGLIN = objDataRow("QTGLIN")
                objEntidad.QGLNUT = objDataRow("QGLNUT")
                objEntidad.QGLNSA = objDataRow("QGLNSA")
                objEntidad.ESTADO = objDataRow("ESTADO")
                objEntidad.NPLCUN = objDataRow("NPLCUN")
                objGenericCollection.Add(objEntidad)
            Next

            Return objGenericCollection
        End Function


        Public Function Listar_Liquidacion_Combustible_V2(ByVal objParametro As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            objParam.Add("PNCPLNDV", objParametro("CPLNDV"))        'PLANTA
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PSSESTRG", objParametro("SESTRG"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_COMBUSTIBLE_V2", objParam)
            dt.Columns.Add("TIEMPO_CIERRE")

            Dim pFecha1 As Date
            Dim pFecha2 As Date
         

            For Each item As DataRow In dt.Rows
                item("FLQDCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLQDCN"))

                item("FINCRG") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCRG"))
                item("FCRVJE") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCRVJE"))

                If Val("" & item("FINCRG")) <> 0 And Val("" & item("FCRVJE")) <> 0 Then
                    pFecha1 = Format(CDate(item("FINCRG")), "dd/MM/yyyy")
                    pFecha2 = Format(CDate(item("FCRVJE")), "dd/MM/yyyy")
                    item("TIEMPO_CIERRE") = DateDiff(DateInterval.Day, pFecha1, pFecha2)
                Else
                    item("TIEMPO_CIERRE") = ""
                End If
                item("FCHCER") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHCER"))
                item("USCRRE") = item("USCRRE") & " " & item("FCHCER")

                '                TRIM(R76.FCHCER) FCHCER ,
                'TRIM(R76.USCRRE) USCRRE ,

            Next


            Return dt
        End Function


        Public Function Eliminar_Liquidacion_Combustible(ByVal objEntidad As Hashtable) As String
            Dim dtresult As New DataTable
            Dim msg As String = ""
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
            objParam.Add("PSCCMPN", objEntidad("PSCCMPN"))
            objParam.Add("PSCULUSA", objEntidad("PSCULUSA"))
            objParam.Add("PSNTRMNL", objEntidad("PSNTRMNL"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_COMBUSTIBLE", objParam)
            For Each item As DataRow In dtresult.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            Return msg

        End Function

        Public Function Cerrar_Liquidacion_Combustible(ByVal objEntidad As Hashtable) As String
            Dim dtresult As New DataTable
            Dim msg As String = ""
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
            objParam.Add("PNFINCRG", objEntidad("PNFINCRG"))
            objParam.Add("PNFCRVJE", objEntidad("PNFCRVJE"))
            objParam.Add("PSCCMPN", objEntidad("PSCCMPN"))
            objParam.Add("PSCULUSA", objEntidad("PSCULUSA"))
            objParam.Add("PSNTRMNL", objEntidad("PSNTRMNL"))
            'objParam.Add("PSACCION", objEntidad("PSACCION"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_CERRAR_LIQUIDACION_COMBUSTIBLE", objParam)
            For Each item As DataRow In dtresult.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            Return msg

        End Function

        Public Function Listar_Operacion_Pendientes_Liquidacion_Combustible(ByVal objParametro As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            objParam.Add("PNNOPRCN", objParametro("NOPRCN"))          'DIVICION
            objParam.Add("PSNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PNFECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("PNFECFIN", objParametro("FECFIN"))          'FECHA FINAL

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OP_PENDIENTE_LIQ_COMBUSTIBLE", objParam)
            For Each item As DataRow In dt.Rows
                item("FGUIRM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FGUIRM"))
                item("FEMVLH") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FEMVLH"))
                item("FCHFTR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHFTR"))
                item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
                item("FATNSR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FATNSR"))
            Next

            Return dt
        End Function
        Public Sub Eliminar_Detalle_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible)
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_DETALLE_LIQUIDACION_COMBUSTIBLE", objParam)

        End Sub

        Public Function Anular_Pre_Cierre_Liquidacion_Combustible(ByVal objEntidad As Hashtable) As String
            Dim dtresult As New DataTable
            Dim msg As String = ""
            Dim objParam As New Parameter
            objParam.Add("PNNLQCMB", objEntidad("PNNLQCMB"))
            objParam.Add("PSCCMPN", objEntidad("PSCCMPN"))
            objParam.Add("PSCULUSA", objEntidad("PSCULUSA"))
            objParam.Add("PSNTRMNL", objEntidad("PSNTRMNL"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("PNCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_ANULAR_PRE_CIERRE_LIQUIDACION_COMBUSTIBLE", objParam)
            For Each item As DataRow In dtresult.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            Return msg

        End Function
        Public Function Listar_Reporte_Liquidacion(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Dim objEntidad As LiquidacionCombustible
            Dim objGenericCollection As New List(Of LiquidacionCombustible)
            Dim objParam As New Parameter


            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            objParam.Add("PNCPLNDV", objParametro("CPLNDV"))        'PLANTA
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNCCLNT", objParametro("CCLNT"))          'CLIENTE
            objParam.Add("PSNPLCTR", objParametro("NPLCTR"))        'TRACTO
            objParam.Add("PNNGUIRM", objParametro("NGUIRM"))        'GUIA DE TRANSPORTE
            objParam.Add("PSNRUCTR", objParametro("NRUCTR"))        'TRANSPORTISTA
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_REPORTE_LIQUIDACION_COMBUSTIBLE", objParam).Rows
                objEntidad = New LiquidacionCombustible

                objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
                objEntidad.PMRCDR = objDataRow("PMRCDR")
                objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                objEntidad.FLQDCN = objDataRow("FLQDCN")

                objEntidad.NLQCMB = objDataRow("NLQCMB")
                objEntidad.NSLCMB = objDataRow("NSLCMB")
                objEntidad.NOPRCN = objDataRow("NOPRCN")

                objEntidad.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objEntidad.CBRCNT = objDataRow("CBRCNT")


                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CENCOS = objDataRow("CENCOS").ToString.Trim
                objEntidad.NURRCR = objDataRow("NURRCR")
                objEntidad.NKMRCR = objDataRow("NKMRCR")

                objEntidad.NRNDUR = objDataRow("NRNDUR")


                objEntidad.QGLNCM = objDataRow("QGLNCM")
                objEntidad.CSTGLN = objDataRow("CSTGLN")
                objEntidad.SENTIDO = objDataRow("SENTIDO").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CONDUCTOR = objDataRow("CONDUCTOR").ToString.Trim

                objGenericCollection.Add(objEntidad)
            Next

            Return objGenericCollection
        End Function


        Public Function Listar_Reporte_Operaciones_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNNLQCMB", objParametro("NLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            'objParam.Add("PNCPLNDV", objParametro("CPLNDV"))        'PLANTA
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PSSESTRG", objParametro("SESTRG"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPT_LISTAR_OPERACIONES_ASIGNADOS_LIQ_COMBUSTIBLE", objParam)


            Return dt
        End Function
        Public Function Listar_Reporte_Vales_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNLQCMB", objParametro("NLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            'objParam.Add("PNCPLNDV", objParametro("CPLNDV"))        'PLANTA
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PSSESTRG", objParametro("SESTRG"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPT_LISTAR_VALES_ASIGNADOS_LIQ_COMBUSTIBLE", objParam)


            Return dt
        End Function


        Public Function Listar_Reporte_Consolidado_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataSet

            Dim objParam As New Parameter
            Dim ds As New DataSet
            objParam.Add("PNLQCMB", objParametro("NLQCMB"))      'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", objParametro("CDVSN"))          'DIVICION
            objParam.Add("FECINI", objParametro("FECINI"))          'FECHA DE INICIO
            objParam.Add("FECFIN", objParametro("FECFIN"))          'FECHA FINAL
            objParam.Add("PSCCMPN", objParametro("CCMPN"))          'COMPAÑIA
            objParam.Add("PNNPLCUN", objParametro("NPLCUN"))
            objParam.Add("PSSESTRG", objParametro("SESTRG"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_RPT_LISTAR_CONSOLIDA_INFO_ASIGNADOS_LIQ_COMBUSTIBLE", objParam)
            For Each item As DataRow In ds.Tables(0).Rows
                item("FLQDCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLQDCN"))
            Next

            Return ds
        End Function


        Public Function Registrar_Vale_Desde_Excel(ByVal objEntidad As LiquidacionCombustible) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSNRUCPR", objEntidad.NRUCPR)
            objParam.Add("PSREF_GRIFO", objEntidad.REF_GRIFO)
            objParam.Add("PSNVLGRS", objEntidad.NVLGRS)
            objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.NLQCMB)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_IMPORTE_VALE_DESDE_EXCEL", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            msg = msg.Trim
            'Return objEntidad
            Return msg
        End Function

        Public Function Registrar_Vale_Masivo_Desde_Excel(ByVal objEntidad As LiquidacionCombustible) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSPLACA", objEntidad.PLACA)
            objParam.Add("PSNRUCPR", objEntidad.NRUCPR)
            objParam.Add("PSGRIFO", objEntidad.GRIFO)
            objParam.Add("PSNVLGRS", objEntidad.NVLGRS)
            objParam.Add("PNFCRCMB", objEntidad.FCRCMB)
            objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
            objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
            objParam.Add("PSNPRCN1", objEntidad.NPRCN1)
            objParam.Add("PSNPRCN2", objEntidad.NPRCN2)
            objParam.Add("PSNPRCN3", objEntidad.NPRCN3)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.NLQCMB)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_VALE_DESDE_EXCEL", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & ("" & item("OBSRESULT")).ToString.Trim
                End If
            Next
            msg = msg.Trim

            Return msg
        End Function

        Public Function Listar_Vales_Pendiente_Asignacion(pCCMPN As String, pCDVSN As String, pNPLCUN As String) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", pCCMPN)  'NUMERO DE LIQUIDACION
            objParam.Add("PSCDVSN", pCDVSN)          'DIVICION
            objParam.Add("PSNPLCUN", pNPLCUN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_PENDIENTES_ASIGNACION", objParam)
            Return dt
        End Function

    End Class

End Namespace

