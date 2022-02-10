Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario

Namespace Operaciones
  Public Class ValeCombustible_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
            'Try
            Dim objParam As New Parameter
            objParam.Add("PON_NRSCVL", objEntidad.NRSCVL, ParameterDirection.Output)
            objParam.Add("PNFECSLC", objEntidad.FECSLC)
            objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            objParam.Add("PNQGLNSL", objEntidad.QGLNSL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNCCNTCS", objEntidad.CCNTCS)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNORSRT", objEntidad.NORSRT)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PSTOBSCR", objEntidad.TOBSCR)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSUSRCRT", objEntidad.USRCRT)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VALE_COMBUSTIBLE", objParam)
            objEntidad.NRSCVL = objSql.ParameterCollection("PON_NRSCVL")
            'Catch ex As Exception
            '          objEntidad.NRSCVL = 0
            '      End Try
            Return objEntidad
    End Function

    Public Function Modificar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
      Try
        Dim objParam As New Parameter
        objParam.Add("PON_NRSCVL", objEntidad.NRSCVL, ParameterDirection.Output)
        objParam.Add("PNFECSLC", objEntidad.FECSLC)
        objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
        objParam.Add("PNQGLNSL", objEntidad.QGLNSL)
        objParam.Add("PNCCNTCS", objEntidad.CCNTCS)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PNNORSRT", objEntidad.NORSRT)
        objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
        objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
        objParam.Add("PSTOBSCR", objEntidad.TOBSCR)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_VALE_COMBUSTIBLE", objParam)
        objEntidad.NRSCVL = objSql.ParameterCollection("PON_NRSCVL")
      Catch ex As Exception
        objEntidad.NRSCVL = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Dim oDt As New DataTable
      Dim objetoEntidad As ValeCombustible
      Dim olbeValeCombustible As New List(Of ValeCombustible)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSCTRSPT", IIf(objEntidad.CTRSPT = 0, "", objEntidad.CTRSPT))
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
            objParam.Add("PSSSVLCM", objEntidad.SSVLCM)
            objParam.Add("PNFECINI", objEntidad.FECINI)
            objParam.Add("PNFECFIN", objEntidad.FECFIN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALE_COMBUSTIBLE_LA", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objetoEntidad = New ValeCombustible
                objetoEntidad.NRSCVL = objDataRow("NRSCVL")
                objetoEntidad.FECSLC_S = HelpClass.CFecha_de_8_a_10(objDataRow("FECSLC_S").ToString.Trim)
                objetoEntidad.NRVLGR = objDataRow("NRVLGR")
                objetoEntidad.FCVALE_S = HelpClass.CFecha_de_8_a_10(objDataRow("FCVALE_S").ToString.Trim)
                objetoEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                objetoEntidad.TDSCMB = objDataRow("TDSCMB").ToString.Trim
                objetoEntidad.QGLNSL = objDataRow("QGLNSL")
                objetoEntidad.QGLNVL = objDataRow("QGLNVL")
                objetoEntidad.CCNTCS = objDataRow("CCNTCS")
                objetoEntidad.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                objetoEntidad.STPVHT = objDataRow("STPVHT").ToString.Trim
                objetoEntidad.CTRSPT = objDataRow("CTRSPT")
                objetoEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objetoEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objetoEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objetoEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim
                objetoEntidad.NPLVEH = objDataRow("NPLVEH").ToString.Trim
                objetoEntidad.NCRTRC = objDataRow("NCRTRC")
                objetoEntidad.SSVLCM = objDataRow("SSVLCM").ToString.Trim
                objetoEntidad.NLQCMB = objDataRow("NLQCMB")
                objetoEntidad.FLQDCN_S = HelpClass.CFecha_de_8_a_10(objDataRow("FLQDCN_S").ToString.Trim) 'IIf(objDataRow("FLQDCN_S").ToString.Trim = "00/00/0000", "", objDataRow("FLQDCN_S").ToString.Trim)
                objetoEntidad.NOPRCN = objDataRow("NOPRCN")
                objetoEntidad.NORSRT = objDataRow("NORSRT")
                objetoEntidad.TOBSCR = objDataRow("TOBSCR").ToString.Trim
                objetoEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objetoEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                olbeValeCombustible.Add(objetoEntidad)
            Next
            'Catch ex As Exception
            '          olbeValeCombustible = New List(Of ValeCombustible)
            '      End Try
            Return olbeValeCombustible
    End Function

    Public Function Eliminar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
      Dim objParam As New Parameter
            'Try
            objParam.Add("PON_NRSCVL", objEntidad.NRSCVL, ParameterDirection.Output)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VALE_COMBUSTIBLE", objParam)
            objEntidad.NRSCVL = objSql.ParameterCollection("PON_NRSCVL")
            'Catch ex As Exception
            '          objEntidad.NRSCVL = 0
            '      End Try
            Return objEntidad
    End Function

    Public Function Listar_Vale_Combustible_1(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Dim oDt As New DataTable
      Dim objetoEntidad As ValeCombustible
      Dim olbeValeCombustible As New List(Of ValeCombustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
        objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
        objParam.Add("PSSSVLCM", objEntidad.SSVLCM)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALE_COMBUSTIBLE", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          objetoEntidad = New ValeCombustible
          objetoEntidad.NRSCVL = objDataRow("NRSCVL")
          objetoEntidad.FECSLC_S = objDataRow("FECSLC_S").ToString.Trim
          objetoEntidad.NRVLGR = objDataRow("NRVLGR")
          objetoEntidad.FCVALE_S = objDataRow("FCVALE_S").ToString.Trim
          objetoEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objetoEntidad.QGLNSL = objDataRow("QGLNSL")
          objetoEntidad.QGLNVL = objDataRow("QGLNVL")
          objetoEntidad.CCNTCS = objDataRow("CCNTCS")
          objetoEntidad.STPVHT = objDataRow("STPVHT").ToString.Trim
          objetoEntidad.CTRSPT = objDataRow("CTRSPT")
          objetoEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
          objetoEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
          objetoEntidad.NPLVEH = objDataRow("NPLVEH").ToString.Trim
          objetoEntidad.NCRTRC = objDataRow("NCRTRC")
          objetoEntidad.SSVLCM = objDataRow("SSVLCM").ToString.Trim
          objetoEntidad.NLQCMB = objDataRow("NLQCMB")
          objetoEntidad.FLQDCN_S = IIf(objDataRow("FLQDCN_S").ToString.Trim = "00/00/0000", "", objDataRow("FLQDCN_S").ToString.Trim)
          objetoEntidad.NOPRCN = objDataRow("NOPRCN")
          objetoEntidad.NORSRT = objDataRow("NORSRT")
          olbeValeCombustible.Add(objetoEntidad)
        Next
      Catch ex As Exception
        olbeValeCombustible = New List(Of ValeCombustible)
      End Try
      Return olbeValeCombustible
    End Function

    Public Function Listar_Vale_Combustible_RPT(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Dim oDt As New DataTable
      Dim objetoEntidad As ValeCombustible
      Dim olbeValeCombustible As New List(Of ValeCombustible)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
        objParam.Add("PSSTPVHT", objEntidad.STPVHT)
        objParam.Add("PSSSVLCM", objEntidad.SSVLCM)
        objParam.Add("PNFECINI", objEntidad.FECINI)
        objParam.Add("PNFECFIN", objEntidad.FECFIN)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALE_COMBUSTIBLE_RPT", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          objetoEntidad = New ValeCombustible
          objetoEntidad.NRSCVL = objDataRow("NRSCVL")
          objetoEntidad.FECSLC_S = objDataRow("FECSLC_S").ToString.Trim
          objetoEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
          objetoEntidad.QGLNSL = objDataRow("QGLNSL")
          objetoEntidad.QGLNVL = objDataRow("QGLNVL")
          objetoEntidad.TCNTCS = objDataRow("CCNTCS").ToString
          objetoEntidad.STPVHT = objDataRow("STPVHT").ToString.Trim
          objetoEntidad.CTRSPT = objDataRow("CTRSPT")
          objetoEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
          objetoEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
          objetoEntidad.CBRCND = objDataRow("CBRCND").ToString.Trim
          objetoEntidad.NPLVEH = objDataRow("NPLVEH").ToString.Trim
          objetoEntidad.SSVLCM = objDataRow("SSVLCM").ToString.Trim
          objetoEntidad.FLQDCN_S = IIf(objDataRow("FLQDCN_S").ToString.Trim = "00/00/0000", "", objDataRow("FLQDCN_S").ToString.Trim)
          objetoEntidad.NLQCMB = objDataRow("NLQCMB")
          objetoEntidad.RUTA = objDataRow("RUTA").ToString.Trim
          'objetoEntidad.TOBSCR = objDataRow("TOBSCR").ToString.Trim
          olbeValeCombustible.Add(objetoEntidad)
        Next
      Catch ex As Exception
        olbeValeCombustible = New List(Of ValeCombustible)
      End Try
      Return olbeValeCombustible
    End Function


    Public Function Obtener_Numerador_Vale_Combustible() As Double
      Dim objParam As New Parameter
      Dim lint64_Numerador As New Double
      Try
        objParam.Add("PON_NRSCVL", 0, ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NUMERADOR_VALE_COMBUSTIBLE", objParam)
        lint64_Numerador = objSql.ParameterCollection("PON_NRSCVL")
      Catch ex As Exception
        lint64_Numerador = 0
      End Try
      Return lint64_Numerador
    End Function


        Public Function Listar_Vale_Combustible_x_Tracto(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
            Dim oDt As New DataTable
            Dim objetoEntidad As ValeCombustible
            Dim olbeValeCombustible As New List(Of ValeCombustible)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
            objParam.Add("PSSSVLCM", objEntidad.SSVLCM)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALE_COMBUSTIBLES_X_TRACTO", objParam)


            For Each objDataRow As DataRow In oDt.Rows
                objetoEntidad = New ValeCombustible
                objetoEntidad.CCMPN = objDataRow("CCMPN")
                objetoEntidad.CDVSN = objDataRow("CDVSN")
                objetoEntidad.CPLNDV = objDataRow("CPLNDV")
                objetoEntidad.NSLCMB = objDataRow("NSLCMB")
                objetoEntidad.NLQCMB = Val(("" & objDataRow("NLQCMB")).ToString.Trim)
                objetoEntidad.NVLGRF = objDataRow("NVLGRF")
                objetoEntidad.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objetoEntidad.FSLCMB = HelpClass.FechaNum_a_Fecha(objDataRow("FSLCMB"))
                objetoEntidad.FCRCMB = HelpClass.FechaNum_a_Fecha(objDataRow("FCRCMB"))
                objetoEntidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                objetoEntidad.TDSCMB = objDataRow("TDSCMB").ToString.Trim
                objetoEntidad.QGLNCM = Val(("" & objDataRow("QGLNCM")).ToString.Trim)
                objetoEntidad.CSTGLN = Val(("" & objDataRow("CSTGLN")).ToString.Trim)
                objetoEntidad.CGRFO = Val(("" & objDataRow("CGRFO")).ToString.Trim)
                objetoEntidad.NPRCN1 = ("" & objDataRow("NPRCN1")).ToString.Trim
                objetoEntidad.NPRCN2 = ("" & objDataRow("NPRCN2")).ToString.Trim
                objetoEntidad.NPRCN3 = ("" & objDataRow("NPRCN3")).ToString.Trim
                objetoEntidad.CTPOD1 = Val(("" & objDataRow("CTPOD1")).ToString.Trim)
                objetoEntidad.NDCCT1 = Val(("" & objDataRow("NDCCT1")).ToString.Trim)
                objetoEntidad.FDCCT1 = HelpClass.FechaNum_a_Fecha(objDataRow("FDCCT1"))
                olbeValeCombustible.Add(objetoEntidad)
            Next

            Return olbeValeCombustible
        End Function

        Public Function Listar_Vale_Combustible_Pendientes_X_Tracto(ByVal objEntidad As ValeCombustible) As DataTable
            Dim oDt As New DataTable
            Dim obeValeCombustible As New ValeCombustible
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLVEH", objEntidad.NPLVEH)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALE_COMBUSTIBLES_PENDIENTE_X_TRACTO", objParam)
            Return oDt
        End Function


        Public Function Registrar_Vale_CombustibleV2(ByVal objEntidad As ValeCombustible) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
            objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
            objParam.Add("PNNRITEM", objEntidad.NRITEM)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)     'DIVISIÓN
            objParam.Add("PNCGRFO", objEntidad.CGRFO)     'GRIFO
            objParam.Add("PSNVLGRS", objEntidad.NVLGRS)     'GRIFO
            objParam.Add("PNFCRCMB", objEntidad.FCRCMB)   'FECHA
            objParam.Add("PNCTPOD1", objEntidad.CTPOD1)
            objParam.Add("PSNDCCTS", objEntidad.NDCCTS)
            objParam.Add("PNFDCCT1", objEntidad.FDCCT1)
            objParam.Add("PNQGLNCM", objEntidad.QGLNCM)
            objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
            objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
            objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            objParam.Add("PSNPRCN1", objEntidad.NPRCN1)
            objParam.Add("PSNPRCN2", objEntidad.NPRCN2)
            objParam.Add("PSNPRCN3", objEntidad.NPRCN3)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_VALE_COMBUSTIBLE_V2", objParam)
           
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim
            Return msg
        End Function


        Public Function Eliminar_Vale_Liquidacion_Combustible(ByVal objEntidad As ValeCombustible) As String
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
            objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
            objParam.Add("PNNRITEM", objEntidad.NRITEM)     'DIVISIÓN
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ELIMINAR_VALE_COMBUSTIBLE", objParam)

            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim
            Return msg
        End Function

        Public Function Listar_Item_Vale_Combustible(ByVal objEntidad As ValeCombustible) As DataTable
            Dim oDt As New DataTable
            Dim obeValeCombustible As New ValeCombustible
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNLQCMB", objEntidad.NLQCMB)
            objParam.Add("PNNRITEM", objEntidad.NRITEM)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ITEM_VALE_LIQUIDACION", objParam)
            Return oDt
        End Function

  End Class
End Namespace

