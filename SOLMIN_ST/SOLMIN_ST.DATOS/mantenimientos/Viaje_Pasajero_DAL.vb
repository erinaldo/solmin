Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
  Public Class Viaje_Pasajero_DAL
    Private objSql As New SqlManager

    Public Function Listar_Viaje_Pasajero(ByVal objViajes_Cliente As Viaje_Pasajero) As List(Of Viaje_Pasajero)
      Dim oDt As New DataTable
      Dim loViaje_Pasajero As New List(Of Viaje_Pasajero)
      Dim objParam As New Parameter
      Try

        objParam.Add("PNNPRGVJ", objViajes_Cliente.PNNPRGVJ)
        'objParam.Add("PNNCRRRT", objViajes_Cliente.PNNCRRRT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objViajes_Cliente.PSCCMPN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VIAJE_PASAJERO", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          Dim objEntidad As New Viaje_Pasajero

          objEntidad.PNNPRGVJ = objDataRow("NPRGVJ").ToString.Trim
          objEntidad.PNNCRRRT = objDataRow("NCRRRT").ToString.Trim
          objEntidad.PNNCRRIN = objDataRow("NCRRIN").ToString.Trim
          objEntidad.PNNCREMB = objDataRow("NCREMB").ToString.Trim
          objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
          objEntidad.PSTCMPCL = objDataRow("TCMPCL").ToString.Trim
          objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim()

          objEntidad.PSORIGEN = objDataRow("ORIGEN").ToString.Trim
          objEntidad.PSDESTINO = objDataRow("DESTINO").ToString.Trim()

          objEntidad.PSTPRVCL = objDataRow("TPRVCL").ToString.Trim
          objEntidad.PSTPDCPE = objDataRow("TPDCPE").ToString.Trim
          objEntidad.PSTIPODOC = objDataRow("TIPODOC").ToString.Trim
          objEntidad.PSNMDCPE = objDataRow("NMDCPE").ToString.Trim
          objEntidad.PSAPENOM = objDataRow("APENOM").ToString.Trim
          objEntidad.PSTCMLGD = objDataRow("TCMLGD").ToString.Trim
          objEntidad.PSSSGRSD = objDataRow("SSGRSD").ToString.Trim
          If objDataRow("FCVNSS_1") = "0" Then
            objEntidad.PSFCVNSS_1 = "" 'objDataRow("FCVNSS_1").ToString.Trim
          Else
            objEntidad.PSFCVNSS_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSS_1").ToString.Trim)
          End If

          objEntidad.PNFCVNSS = objDataRow("FCVNSS").ToString.Trim
          objEntidad.PSSSGRSP = objDataRow("SSGRSP").ToString.Trim

          If objDataRow("FCVNSP_1") = "0" Then
            objEntidad.PSFCVNSP_1 = "" 'objDataRow("FCVNSP_1").ToString.Trim
          Else
            objEntidad.PSFCVNSP_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSP_1").ToString.Trim)
          End If

          'objEntidad.PSFCVNSP_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSP_1").ToString.Trim)
          objEntidad.PNFCVNSP = objDataRow("FCVNSP").ToString.Trim
          objEntidad.PSSSGRSV = objDataRow("SSGRSV").ToString.Trim
          If objDataRow("FCVNSV_1") = "0" Then
            objEntidad.PSFCVNSV_1 = "" 'objDataRow("FCVNSV_1").ToString.Trim
          Else
            objEntidad.PSFCVNSV_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSV_1").ToString.Trim)
          End If
          'objEntidad.PSFCVNSV_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSV_1").ToString.Trim)
          objEntidad.PNFCVNSV = objDataRow("FCVNSV").ToString.Trim
          objEntidad.PSSSGRAP = objDataRow("SSGRAP").ToString.Trim
          If objDataRow("FCVNSA_1") = "0" Then
            objEntidad.PSFCVNSA_1 = "" 'objDataRow("FCVNSA_1").ToString.Trim
          Else
            objEntidad.PSFCVNSA_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSA_1").ToString.Trim)
          End If
          'objEntidad.PSFCVNSA_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCVNSA_1").ToString.Trim)
          objEntidad.PNFCVNSA = objDataRow("FCVNSA").ToString.Trim
          If objDataRow("FCEXMD_1") = "0" Then
            objEntidad.PSFCEXMD_1 = "" 'objDataRow("FCEXMD_1").ToString.Trim
          Else
            objEntidad.PSFCEXMD_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCEXMD_1").ToString.Trim)
          End If
          'objEntidad.PSFCEXMD_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCEXMD_1").ToString.Trim)
          objEntidad.PNFCEXMD = objDataRow("FCEXMD").ToString.Trim
          objEntidad.PSSSDCSL = objDataRow("SSDCSL").ToString.Trim
          objEntidad.PSSSVCNR = objDataRow("SSVCNR").ToString.Trim
          If objDataRow("FCRSSG_1") = "0" Then
            objEntidad.PSFCRSSG_1 = "" 'objDataRow("FCRSSG_1").ToString.Trim
          Else
            objEntidad.PSFCRSSG_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCRSSG_1").ToString.Trim)
          End If
          'objEntidad.PSFCRSSG_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FCRSSG_1").ToString.Trim)
          objEntidad.PNFCRSSG = objDataRow("FCRSSG").ToString.Trim
          objEntidad.PSTMTVIN = objDataRow("TMTVIN").ToString.Trim
          objEntidad.PSNORCMC = objDataRow("NORCMC").ToString.Trim
          objEntidad.PSNPSPER = objDataRow("NPSPER").ToString.Trim
          If objDataRow("FVCPSP_1") = "0" Then
            objEntidad.PSFVCPSP_1 = "" 'objDataRow("FVCPSP_1").ToString.Trim
          Else
            objEntidad.PSFVCPSP_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FVCPSP_1").ToString.Trim)
          End If
          'objEntidad.PSFVCPSP_1 = Validacion.CFecha_a_Numero10Digitos(objDataRow("FVCPSP_1").ToString.Trim)
          objEntidad.PNFVCPSP = objDataRow("FVCPSP").ToString.Trim

          loViaje_Pasajero.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return loViaje_Pasajero
    End Function

    Public Function Insertar_Viaje_Pasajero(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As Integer
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNPRGVJ", Obe_Viaje_Pasajero.PNNPRGVJ)
        objParam.Add("PNNCRRRT", Obe_Viaje_Pasajero.PNNCRRRT)
        '   objParam.Add("PNNCRRIN", Obe_Viaje_Pasajero.PNNCRRIN)
        objParam.Add("PNNCREMB", Obe_Viaje_Pasajero.PNNCREMB)
        objParam.Add("PNCCLNT", Obe_Viaje_Pasajero.PNCCLNT)
        objParam.Add("PNCPRVCL", Obe_Viaje_Pasajero.PNCPRVCL)
        objParam.Add("PSTPDCPE", Obe_Viaje_Pasajero.PSTPDCPE)

        objParam.Add("PSNMDCPE", Obe_Viaje_Pasajero.PSNMDCPE)
        objParam.Add("PSTCMLGD", Obe_Viaje_Pasajero.PSTCMLGD)
        objParam.Add("PSSSGRSD", Obe_Viaje_Pasajero.PSSSGRSD)
        objParam.Add("PNFCVNSS", Obe_Viaje_Pasajero.PNFCVNSS)
        objParam.Add("PSSSGRSP", Obe_Viaje_Pasajero.PSSSGRSP)

        objParam.Add("PNFCVNSP", Obe_Viaje_Pasajero.PNFCVNSP)
        objParam.Add("PSSSGRSV", Obe_Viaje_Pasajero.PSSSGRSV)
        objParam.Add("PNFCVNSV", Obe_Viaje_Pasajero.PNFCVNSV)
        objParam.Add("PSSSGRAP", Obe_Viaje_Pasajero.PSSSGRAP)
        objParam.Add("PNFCVNSA", Obe_Viaje_Pasajero.PNFCVNSA)

        objParam.Add("PNFCEXMD", Obe_Viaje_Pasajero.PNFCEXMD)
        objParam.Add("PSSSDCSL", Obe_Viaje_Pasajero.PSSSDCSL)
        objParam.Add("PSSSVCNR", Obe_Viaje_Pasajero.PSSSVCNR)
        objParam.Add("PNFCRSSG", Obe_Viaje_Pasajero.PNFCRSSG)
        objParam.Add("PSTMTVIN", Obe_Viaje_Pasajero.PSTMTVIN)

        objParam.Add("PSNORCMC", Obe_Viaje_Pasajero.PSNORCMC)
        objParam.Add("PSNPSPER", Obe_Viaje_Pasajero.PSNPSPER)
        objParam.Add("PNFVCPSP", Obe_Viaje_Pasajero.PNFVCPSP)

        objParam.Add("PSSESTRG", Obe_Viaje_Pasajero.PSSESTRG)
        objParam.Add("PSCUSCRT", Obe_Viaje_Pasajero.PSCUSCRT)
        objParam.Add("PNFCHCRT", Obe_Viaje_Pasajero.PNFCHCRT)
        objParam.Add("PNHRACRT", Obe_Viaje_Pasajero.PNHRACRT)
        objParam.Add("PSNTRMCR", Obe_Viaje_Pasajero.PSNTRMCR)
        objParam.Add("PNRESULT", Obe_Viaje_Pasajero.PSNTRMCR, ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VIAJE_PASAJEROS_1", objParam)
        Return objSql.ParameterCollection("PNRESULT")

      Catch ex As Exception
        Return 0
      End Try
    End Function

    Public Function Actualizar_Viaje_Pasajero(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As Integer
      Try
                Dim objParam As New Parameter

                objParam.Add("PNNPRGVJ", Obe_Viaje_Pasajero.PNNPRGVJ)
                objParam.Add("PNNCRRRT", Obe_Viaje_Pasajero.PNNCRRRT)
                objParam.Add("PNNCRRIN", Obe_Viaje_Pasajero.PNNCRRIN)

                objParam.Add("PNNCREMB", Obe_Viaje_Pasajero.PNNCREMB)
                objParam.Add("PNCCLNT", Obe_Viaje_Pasajero.PNCCLNT)
                objParam.Add("PNCPRVCL", Obe_Viaje_Pasajero.PNCPRVCL)
                objParam.Add("PSTPDCPE", Obe_Viaje_Pasajero.PSTPDCPE)

                objParam.Add("PSNMDCPE", Obe_Viaje_Pasajero.PSNMDCPE)
                objParam.Add("PSTCMLGD", Obe_Viaje_Pasajero.PSTCMLGD)
                objParam.Add("PSSSGRSD", Obe_Viaje_Pasajero.PSSSGRSD)
                objParam.Add("PNFCVNSS", Obe_Viaje_Pasajero.PNFCVNSS)
                objParam.Add("PSSSGRSP", Obe_Viaje_Pasajero.PSSSGRSP)

                objParam.Add("PNFCVNSP", Obe_Viaje_Pasajero.PNFCVNSP)
                objParam.Add("PSSSGRSV", Obe_Viaje_Pasajero.PSSSGRSV)
                objParam.Add("PNFCVNSV", Obe_Viaje_Pasajero.PNFCVNSV)
                objParam.Add("PSSSGRAP", Obe_Viaje_Pasajero.PSSSGRAP)
                objParam.Add("PNFCVNSA", Obe_Viaje_Pasajero.PNFCVNSA)

                objParam.Add("PNFCEXMD", Obe_Viaje_Pasajero.PNFCEXMD)
                objParam.Add("PSSSDCSL", Obe_Viaje_Pasajero.PSSSDCSL)
                objParam.Add("PSSSVCNR", Obe_Viaje_Pasajero.PSSSVCNR)
                objParam.Add("PNFCRSSG", Obe_Viaje_Pasajero.PNFCRSSG)
                objParam.Add("PSTMTVIN", Obe_Viaje_Pasajero.PSTMTVIN)

                objParam.Add("PSNORCMC", Obe_Viaje_Pasajero.PSNORCMC)
                objParam.Add("PSNPSPER", Obe_Viaje_Pasajero.PSNPSPER)
                objParam.Add("PNFVCPSP", Obe_Viaje_Pasajero.PNFVCPSP)

                objParam.Add("PSCULUSA", Obe_Viaje_Pasajero.PSCULUSA)
                objParam.Add("PNFULTAC", Obe_Viaje_Pasajero.PNFULTAC)
                objParam.Add("PNHULTAC", Obe_Viaje_Pasajero.PNHULTAC)
                objParam.Add("PSNTRMNL", Obe_Viaje_Pasajero.PSNTRMNL)
                objParam.Add("PNRESULT", Obe_Viaje_Pasajero.PSNTRMCR, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_VIAJE_PASAJEROS_1", objParam)
                Return objSql.ParameterCollection("PNRESULT")
      Catch ex As Exception
        Return 0
      End Try
    End Function

    Public Function Eliminar_Viaje_Pasajero(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As Integer
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPRGVJ", Obe_Viaje_Pasajero.PNNPRGVJ)
        objParam.Add("PNNCRRRT", Obe_Viaje_Pasajero.PNNCRRRT)
        objParam.Add("PNNCRRIN", Obe_Viaje_Pasajero.PNNCRRIN)

        objParam.Add("PSSESTRG", Obe_Viaje_Pasajero.PSSESTRG)
        objParam.Add("PSCULUSA", Obe_Viaje_Pasajero.PSCULUSA)
        objParam.Add("PNFULTAC", Obe_Viaje_Pasajero.PNFULTAC)
        objParam.Add("PNHULTAC", Obe_Viaje_Pasajero.PNHULTAC)
        objParam.Add("PSNTRMNL", Obe_Viaje_Pasajero.PSNTRMNL)
        objParam.Add("PNRESULT", 0, ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VIAJE_PASAJERO", objParam)
        Return objSql.ParameterCollection("PNRESULT")
      Catch ex As Exception
        Return 0
      End Try
    End Function

    Public Function RptListar_Programacion_Viaje(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", Obe_Viaje_Pasajero.PNCCLNT)
                objParam.Add("PNNPRGVJ", Obe_Viaje_Pasajero.PNNPRGVJ)
                objParam.Add("PNFECINI", Obe_Viaje_Pasajero.PNFECINI)
                objParam.Add("PNFECFIN", Obe_Viaje_Pasajero.PNFECFIN)
                objParam.Add("PSCCMPN", Obe_Viaje_Pasajero.PSCCMPN)
                objParam.Add("PNCMEDTR", Obe_Viaje_Pasajero.PNCMEDTR)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PROGRAMACION_VIAJE", objParam)

                Return objDataTable
            Catch ex As Exception
                Return New Data.DataTable
            End Try
        End Function




    Public Function RptListar_PasajerosXGuia(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataSet
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Try
        objParam.Add("PNCTRMNC", Obe_Viaje_Pasajero.PNCTRMNC)
        objParam.Add("PNNGUITR", Obe_Viaje_Pasajero.PNNGUITR)
        objParam.Add("PSCCMPN", Obe_Viaje_Pasajero.PSCCMPN)
        objParam.Add("PSCDVSN", Obe_Viaje_Pasajero.PSCDVSN)
        objParam.Add("PNCPLNDV", Obe_Viaje_Pasajero.PNCPLNDV)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
        Return objSql.ExecuteDataSet("SP_SOLMIN_ST_MANIFIESTO_PASAJERO", objParam)
      Catch ex As Exception
        Return New DataSet
      End Try
    End Function

    Public Function RptListar_Pasajeros_Contratista_Cliente(ByVal Obe_Viaje_Pasajero As Viaje_Pasajero) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", Obe_Viaje_Pasajero.PSCCMPN)
        objParam.Add("PNCCLNT", Obe_Viaje_Pasajero.PNCCLNT)
        objParam.Add("PNCPRVCL", Obe_Viaje_Pasajero.PNCPRVCL)
        objParam.Add("PSTPDCPE", Obe_Viaje_Pasajero.PSTPDCPE)
        objParam.Add("PSNMDCPE", Obe_Viaje_Pasajero.PSNMDCPE)
        objParam.Add("PNFECINI", Obe_Viaje_Pasajero.PNFECINI)
        objParam.Add("PNFECFIN", Obe_Viaje_Pasajero.PNFECFIN)
        objParam.Add("PNCMEDTR", Obe_Viaje_Pasajero.PNCMEDTR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obe_Viaje_Pasajero.PSCCMPN)
        Return objSql.ExecuteDataTable("SP_SOLMIN_ST_CONTROL_PASAJEROS_CONTRATISTA_CLIENTE", objParam)
      Catch ex As Exception
        Return New DataTable
      End Try
    End Function

  End Class
End Namespace

