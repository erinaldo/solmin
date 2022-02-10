Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class Combustible_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PON_NSLCMB", objEntidad.NSLCMB, ParameterDirection.Output)
        objParam.Add("PNFSLCMB", objEntidad.FSLCMB)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PNCGRFO", objEntidad.CGRFO)
        objParam.Add("PNFCRCMB", objEntidad.FCRCMB)
        objParam.Add("PNNVLGRF", objEntidad.NVLGRF)
        objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
        objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
        objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
        objParam.Add("PSNPRCN1", objEntidad.NPRCN1)
        objParam.Add("PSNPRCN2", objEntidad.NPRCN2)
        objParam.Add("PSNPRCN3", objEntidad.NPRCN3)
        objParam.Add("PNNDCCT1", objEntidad.NDCCT1)
        objParam.Add("PNCTPOD1", objEntidad.CTPOD1)
        objParam.Add("PNFDCCT1", objEntidad.FDCCT1)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ASIGNACION_COMBUSTIBLE", objParam)
        objEntidad.NSLCMB = objSql.ParameterCollection("PON_NSLCMB")
      Catch ex As Exception
        objEntidad.NSLCMB = 0
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNSLCMB", objEntidad.NSLCMB)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNCGRFO", objEntidad.CGRFO)
        objParam.Add("PNFCRCMB", objEntidad.FCRCMB)
        objParam.Add("PNNVLGRF", objEntidad.NVLGRF)
        objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
        objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
        objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
        objParam.Add("PSNPRCN1", objEntidad.NPRCN1)
        objParam.Add("PSNPRCN2", objEntidad.NPRCN2)
        objParam.Add("PSNPRCN3", objEntidad.NPRCN3)
        objParam.Add("PNCTPOD1", objEntidad.CTPOD1)
        objParam.Add("PNNDCCT1", objEntidad.NDCCT1)
        objParam.Add("PNFDCCT1", objEntidad.FDCCT1)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ASIGNACION_COMBUSTIBLE", objParam)
      Catch ex As Exception
        objEntidad.NSLCMB = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNSLCMB", objEntidad.NSLCMB)
        objParam.Add("PNNRSCVL", objEntidad.NRSCVL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_ASIGNACION_COMBUSTIBLE", objParam)
      Catch ex As Exception
        objEntidad.NSLCMB = 0
      End Try
      Return objEntidad
    End Function


    Public Function Actualizar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
        objParam.Add("PNNSLCMB", objEntidad.NSLCMB)
        objParam.Add("PNFCHLQD", objEntidad.FCHLQD)
        objParam.Add("PNHRALQD", objEntidad.HRALQD)
        objParam.Add("PSUSRLQD", objEntidad.USRLQD)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ASIGNACION_COMBUSTIBLE", objParam)

      Catch ex As Exception
        objEntidad.NSLCMB = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Asignacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of Combustible)
      'Dim objDataTable As New DataTable
      Dim objEntidad As Combustible
      Dim objGenericCollection As New List(Of Combustible)
      Dim objParam As New Parameter
      Try

        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("PSSESSLC", objParametro("PSSESSLC"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ASIGNACION_COMBUSTIBLE_X_TRACTO", objParam).Rows
          objEntidad = New Combustible
          objEntidad.NSLCMB = objDataRow("NSLCMB")
          objEntidad.FSLCMB_D = objDataRow("FSLCMB").ToString.Trim
          objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
          objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
          objEntidad.CPLNDV = objDataRow("CPLNDV")
          objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
          objEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim
          objEntidad.CGRFO = objDataRow("CGRFO")
          objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
          objEntidad.FCRCMB_D = objDataRow("FCRCMB").ToString.Trim
          objEntidad.NVLGRF = objDataRow("NVLGRF")
          objEntidad.NPRCN1 = objDataRow("NPRCN1").ToString
          objEntidad.NPRCN2 = objDataRow("NPRCN2").ToString
          objEntidad.NPRCN3 = objDataRow("NPRCN3").ToString
          objEntidad.QGLNCM = objDataRow("QGLNCM")
          objEntidad.CSTGLN = objDataRow("CSTGLN")
          objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objEntidad.NLQGST = objDataRow("NLQGST")
          objEntidad.NLQCMB = objDataRow("NLQCMB")
          objEntidad.FCHLQD_S = objDataRow("FCHLQD").ToString.Trim
          objEntidad.HRALQD_S = objDataRow("HRALQD").ToString.Trim
          objEntidad.USRLQD = objDataRow("USRLQD").ToString.Trim
          objEntidad.SESSLC = objDataRow("SESSLC").ToString.Trim
          objEntidad.NDCCT1 = objDataRow("NDCCT1")
          objEntidad.FDCCT1_S = objDataRow("FDCCT1").ToString.Trim
          objEntidad.CTPOD1 = objDataRow("CTPOD1")

          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Tractos_Asignacion_Combustible(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
      ' Dim objDataTable As New DataTable
      Dim objEntidad As ClaseGeneral
      Dim objGenericCollection As New List(Of ClaseGeneral)
      Dim objParam As New Parameter
      Try

        objParam.Add("PSNRUCTR", objParametro("PSNRUCTR"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTOS_ASIGNACION_COMBUSTIBLE", objParam).Rows
          objEntidad = New ClaseGeneral
          objEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objEntidad.CBRCNT = objDataRow("CBRCND").ToString.Trim
          objEntidad.CBRCND = objDataRow("CBRCNT").ToString.Trim
          objEntidad.TCLRUN = objDataRow("TCLRUN").ToString.Trim
          objEntidad.TMRCTR = objDataRow("TMRCTR").ToString.Trim
          objEntidad.QPSOTR = objDataRow("QPSOTR")
          objEntidad.QGNXCN = objDataRow("QGNXCN")
          objEntidad.FFBRUN = objDataRow("FFBRUN")
          objEntidad.QGLNSA = objDataRow("QGLNSA")
          objEntidad.CTRSPT = objDataRow("CTRSPT")
          objEntidad.COMTOT = objDataRow("QGNXCN") + objDataRow("QGLNSA")

          objGenericCollection.Add(objEntidad)
        Next

      Catch ex As Exception
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Tractos_Asignacion_Combustible_RPT(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
      'Dim objDataTable As New DataTable
      Dim objEntidad As ClaseGeneral
      Dim objGenericCollection As New List(Of ClaseGeneral)
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCLNT", objParametro("PSCCLNT"))
        objParam.Add("PSNPLCUN", objParametro("PSNPLCUN"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
        objParam.Add("STATUS", objParametro("STATUS"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TRACTOS_ASIGNACION_COMBUSTIBLE_RPT", objParam).Rows
          objEntidad = New ClaseGeneral
          If objParametro("STATUS") = 1 Then
            objEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
            objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
            objEntidad.TMRCTR = objDataRow("TMRCTR").ToString.Trim
            objEntidad.TCLRUN = objDataRow("TCLRUN").ToString.Trim
            objEntidad.FFBRUN = objDataRow("FFBRUN")
            objEntidad.QPSOTR = objDataRow("QPSOTR")
            objEntidad.NVLGRF = objDataRow("NVLGRF").ToString.Trim
            objEntidad.FCRCMB_S = objDataRow("FCRCMB").ToString.Trim
            objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
            objEntidad.TDSCMB = objDataRow("TDSCMB").ToString.Trim
            objEntidad.QGLNCM = objDataRow("QGLNCM")
            objEntidad.SESSLC = objDataRow("SESSLC").ToString.Trim
          Else
            objEntidad.NLQCMB = objDataRow("NLQCMB")
            objEntidad.NOPRCN = objDataRow("NOPRCN")
            objEntidad.CCLNT = objDataRow("CCLNT")
            objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
            objEntidad.NKMRCR = objDataRow("NKMRCR")
            objEntidad.QGLNCM = objDataRow("QGLNCM")
            objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
            objEntidad.FLQDCN_S = objDataRow("FLQDCN_S").ToString.Trim
            objEntidad.QGLNSA = objDataRow("QGLNSA")
            objEntidad.QTGLIN = objDataRow("QTGLIN")
            objEntidad.QGLNUT = objDataRow("QGLNUT")
            objEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
            objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
            objEntidad.TMRCTR = IIf(objDataRow("TMRCTR").ToString.Trim Is DBNull.Value, "", objDataRow("TMRCTR").ToString.Trim)
            objEntidad.PMRCDR = objDataRow("PMRCDR")
            objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
            objEntidad.NKMVRT = objDataRow("NKMVRT")
            objEntidad.QGLVRT = objDataRow("QGLVRT")
            If objParametro("STATUS") = 3 Then
              If objEntidad.QGLNCM = 0 Then
                objEntidad.RENREA = 0
              Else
                objEntidad.RENREA = objEntidad.NKMRCR / objEntidad.QGLNCM
              End If
              If objEntidad.QGLVRT = 0 Then
                objEntidad.RENVRT = 0
              Else
                objEntidad.RENVRT = objEntidad.NKMVRT / objEntidad.QGLVRT
              End If
              If objEntidad.QGLVRT = 0 Then
                objEntidad.EVACBG = ""
              ElseIf objEntidad.QGLNCM < objEntidad.QGLVRT Then
                objEntidad.EVACBG = "BIEN"
              Else
                objEntidad.EVACBG = (objEntidad.QGLVRT - objEntidad.QGLNCM).ToString
              End If
              If objEntidad.EVACBG = "" OrElse objEntidad.EVACBG = "BIEN" OrElse (objEntidad.QGLVRT - objEntidad.QGLNCM) = 0 Then
                objEntidad.EVACBP = ""
              Else
                objEntidad.EVACBP = (((objEntidad.QGLNCM - objEntidad.QGLVRT) / objEntidad.QGLVRT) * 100).ToString
              End If
              If objEntidad.RENVRT = 0 Then
                objEntidad.EVAREN = 0
              Else
                objEntidad.EVAREN = ((objEntidad.RENVRT - objEntidad.RENREA) / objEntidad.RENVRT)
              End If
              If objEntidad.EVACBP = "" Then
                objEntidad.ALERTA = ""
              ElseIf ((objEntidad.QGLNCM - objEntidad.QGLVRT) / objEntidad.QGLVRT) > (5 / 100) Then
                objEntidad.ALERTA = "ALERTA"
              End If
            End If
          End If
          objGenericCollection.Add(objEntidad)

        Next
      Catch ex As Exception
      End Try
      Return objGenericCollection
        End Function

        Public Function Listar_Vales_Asignados_x_Operacion(ByVal objParametro As Hashtable) As List(Of Combustible)
            Dim objEntidad As Combustible
            Dim objGenericCollection As New List(Of Combustible)
            Dim objParam As New Parameter
            Try

                objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_ASIGNADOS_X_OPERACION", objParam).Rows
                    objEntidad = New Combustible
                    objEntidad.NSLCMB = objDataRow("NSLCMB")
                    objEntidad.FSLCMB = objDataRow("FSLCMB")
                    objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objDataRow("CPLNDV")
                    objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim
                    objEntidad.CGRFO = objDataRow("CGRFO")
                    objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
                    objEntidad.FCRCMB = objDataRow("FCRCMB")
                    objEntidad.NVLGRF = objDataRow("NVLGRF")
                    objEntidad.NPRCN1 = objDataRow("NPRCN1").ToString
                    objEntidad.NPRCN2 = objDataRow("NPRCN2").ToString
                    objEntidad.NPRCN3 = objDataRow("NPRCN3").ToString
                    objEntidad.QGLNCM = objDataRow("QGLNCM")
                    objEntidad.CSTGLN = objDataRow("CSTGLN")
                    objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                    objEntidad.NLQGST = objDataRow("NLQGST")
                    objEntidad.NLQCMB = objDataRow("NLQCMB")
                    objEntidad.FCHLQD = objDataRow("FCHLQD")
                    objEntidad.HRALQD_S = objDataRow("HRALQD").ToString.Trim
                    objEntidad.USRLQD = objDataRow("USRLQD").ToString.Trim
                    objEntidad.SESSLC = objDataRow("SESSLC").ToString.Trim
                    objEntidad.NDCCT1 = objDataRow("NDCCT1")
                    objEntidad.FDCCT1 = objDataRow("FDCCT1")
                    objEntidad.CTPOD1 = objDataRow("CTPOD1")

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Datos_Adicionales_Asignacion_Combustible(ByVal obeCombustible As Combustible) As List(Of Combustible)
            Dim objEntidad As Combustible
            Dim objGenericCollection As New List(Of Combustible)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", obeCombustible.NOPRCN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeCombustible.CCMPN)

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_COMP_CDV_RUCTR_OPERACION", objParam).Rows
                    objEntidad = New Combustible
                    objEntidad.NSLCMB = objDataRow("NOPRCN")
                    objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objDataRow("CPLNDV")
                    objEntidad.NRUCTR = objDataRow("NRUCTR")
                    objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Validar_Existencia_Vale_Asignacion_Combustible(ByVal objParametro As Hashtable) As Int64
            Dim lstatus As Integer = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NVLGRF", objParametro("NVLGRF"), ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_VALE_ASIGNAR", objParam)
                lstatus = objSql.ParameterCollection("PON_NVLGRF")
            Catch ex As Exception
                lstatus = 0
            End Try
            Return lstatus
        End Function


        Public Function Listar_Vales_Asignados_x_Liquidacion(ByVal objParametro As Hashtable) As DataTable
            'Dim objEntidad As Combustible
            'Dim objGenericCollection As New List(Of Combustible)
            Dim dt As New DataTable
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_ASIGNADOS_X_LIQUIDACION", objParam)
            For Each item As DataRow In dt.Rows
                item("FCRCMB") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCRCMB"))
                item("FDCCT1") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FDCCT1"))
            Next

            '    For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VALES_ASIGNADOS_X_LIQUIDACION", objParam).Rows
            '        objEntidad = New Combustible
            '        objEntidad.NLQCMB = objDataRow("NLQCMB")
            '        objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
            '        objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
            '        objEntidad.CGRFO = objDataRow("CGRFO")
            '        objEntidad.TGRFO = objDataRow("TGRFO").ToString.Trim
            '        objEntidad.FCRCMB = objDataRow("FCRCMB")
            '        objEntidad.NVLGRF = objDataRow("NVLGRF")
            '        objEntidad.NPRCN1 = objDataRow("NPRCN1").ToString
            '        objEntidad.NPRCN2 = objDataRow("NPRCN2").ToString
            '        objEntidad.NPRCN3 = objDataRow("NPRCN3").ToString
            '        objEntidad.QGLNCM = objDataRow("QGLNCM")
            '        objEntidad.CSTGLN = objDataRow("CSTGLN")
            '        objEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
            '        objEntidad.NLQGST = objDataRow("NLQGST")
            '        objEntidad.NDCCT1 = objDataRow("NDCCT1")
            '        objEntidad.FDCCT1 = objDataRow("FDCCT1")
            '        objEntidad.CTPOD1 = objDataRow("CTPOD1")

            '        objGenericCollection.Add(objEntidad)
            '    Next
            'Catch ex As Exception
            'End Try
            'Return objGenericCollection
            Return dt
        End Function

        Public Function Listar_Operaciones_Asignados_x_Liquidacion(ByVal objParametro As Hashtable) As DataTable
          
            Dim dt As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PNNLQCMB", objParametro("PNNLQCMB"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_ASIGNADOS_X_LIQ_COMBUSTIBLE", objParam)
           
            Return dt
        End Function

     

        Public Sub Registrar_Distribucion_Cierre_Liquidacion(ByVal objParametro As LiquidacionCombustible)

            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objParametro.CCMPN)
            objParam.Add("PNNLQCMB", objParametro.NLQCMB)
            objParam.Add("PNNOPRCN", objParametro.NOPRCN)
            objParam.Add("PNNKMRCR", objParametro.NKMRCR)
            objParam.Add("PNQGLNCM", objParametro.QGLNCM)
            objParam.Add("PNCSTTCB", objParametro.CSTTCB)
            objParam.Add("PNQGUREA", objParametro.QGUREA)
            objParam.Add("PNCTUREA", objParametro.CTUREA)
            objParam.Add("PSCULUSA", objParametro.CULUSA)
            objParam.Add("PSNTRMNL", objParametro.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ACTUALIZAR_DISTRIBUCION_OP_LIQ_COMBUSTIBLE", objParam)

         



        End Sub
        

        '


    End Class
End Namespace
