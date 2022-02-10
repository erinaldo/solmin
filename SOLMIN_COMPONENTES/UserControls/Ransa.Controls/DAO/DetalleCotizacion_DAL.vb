Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports System.Data

Public Class DetalleCotizacion_DAL
  Dim objSql As SqlManager

  Sub New()
    objSql = New SqlManager()
  End Sub

  Public Function ListaDetalleCotizacion(ByVal lobjEntidad As Hashtable) As List(Of Detalle_Cotizacion)
    Dim objListEntidad As New List(Of Detalle_Cotizacion)
    Try
      Dim objParam As New Parameter
      Dim objDataTable As New DataTable
      Dim objEntidad As New Detalle_Cotizacion
      objParam.Add("PNNCTZCN", lobjEntidad("NCTZCN"))

      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("CCMPN"))

      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DETALLE_COTIZACION", objParam)

      For Each objDataRow As DataRow In objDataTable.Rows
        objEntidad = New Detalle_Cotizacion
        objEntidad.NCRRCT = objDataRow("NCRRCT").ToString().Trim()
        objEntidad.NCTZCN = objDataRow("NCTZCN").ToString().Trim()
        objEntidad.CMRCDR = objDataRow("CMRCDR").ToString().Trim()
        objEntidad.CUNDMD = objDataRow("CUNDMD").ToString().Trim()
        objEntidad.CFRMPG = objDataRow("CFRMPG").ToString().Trim()

        objEntidad.SSGRCT = objDataRow("SSGRCT").ToString().Trim()
        Select Case objEntidad.SSGRCT
          Case "C"
            objEntidad.SEGURO = "CLIENTE"
          Case "T"
            objEntidad.SEGURO = "RANSA"
          Case "P"
            objEntidad.SEGURO = "TERCERO"
        End Select

        objEntidad.TUNDVH = objDataRow("TUNDVH").ToString().Trim()

        objEntidad.CCMPSG = objDataRow("CCMPSG")
        objEntidad.NPLSGC = objDataRow("NPLSGC")
        objEntidad.QPRCS1 = objDataRow("QPRCS1")
        objEntidad.QMRCDR = objDataRow("QMRCDR")
        objEntidad.PMRCDR = objDataRow("PMRCDR").ToString().Trim()
        objEntidad.VMRCDR = objDataRow("VMRCDR")
        objEntidad.LMRCDR = objDataRow("LMRCDR")
        objEntidad.TRFMRC = objDataRow("TRFMRC").ToString().Trim()
        objEntidad.FINCSR = objDataRow("FINCSR")
        objEntidad.STPOMR = objDataRow("STPOMR").ToString().Trim()
        objEntidad.FCRGMR = objDataRow("FCRGMR")
        objEntidad.NPTSCR = objDataRow("NPTSCR")
        objEntidad.NPTSDS = objDataRow("NPTSDS")
        objEntidad.FENTMR = objDataRow("FENTMR")
        objEntidad.SCNDTR = objDataRow("SCNDTR").ToString().Trim()
        objEntidad.TMRCDR = objDataRow("TMRCDR")
        objEntidad.SRSTRC = objDataRow("SRSTRC").ToString().Trim()
        objEntidad.NORSRT = objDataRow("NORSRT")
        objEntidad.CTPOSR = objDataRow("CTPOSR").ToString().Trim()
        objEntidad.CTPSBS = objDataRow("CTPSBS").ToString().Trim()
        objEntidad.CCNDRT = objDataRow("CCNDRT")
        objEntidad.CVPRCN = objDataRow("CVPRCN").ToString().Trim()
        objEntidad.NVJES = objDataRow("NVJES")
        objEntidad.CTPUNV = objDataRow("CTPUNV").ToString().Trim()
        objEntidad.CFRAPG = objDataRow("CFRAPG").ToString().Trim()
        objEntidad.MERCAD = objDataRow("MERCAD").ToString().Trim()
        objEntidad.UNIMED = objDataRow("UNIMED").ToString().Trim()
        objEntidad.FFACTURA = objDataRow("FFACTURA").ToString().Trim()
        objEntidad.FPAGO = objDataRow("FPAGO").ToString().Trim()
        objEntidad.SESTOS = objDataRow("SESTOS").ToString().Trim()
        Select Case objEntidad.SESTOS
          Case "P"
            objEntidad.ESTADOOS = "PENDIENTE"
          Case "C"
            objEntidad.ESTADOOS = "CERRADO"
        End Select
        objEntidad.CCNCST = objDataRow("CCNCST").ToString().Trim()
        objEntidad.CCNCS1 = objDataRow("CCNCS1").ToString().Trim()
        objListEntidad.Add(objEntidad)
      Next

    Catch ex As Exception
    End Try
    Return objListEntidad
  End Function

  Public Function Guardar_Detalle_Cotizacion(ByVal objEntidad As Detalle_Cotizacion) As Detalle_Cotizacion
    Dim obeDetalle_Cotizacion As New Detalle_Cotizacion
    Dim oDt As New DataTable
    Try
      Dim objParam As New Parameter

      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
      objParam.Add("PNCUNDMD", objEntidad.CUNDMD)
      objParam.Add("PNCFRMPG", objEntidad.CFRMPG)
      objParam.Add("PNSSGRCT", objEntidad.SSGRCT)
      objParam.Add("PNCCMPSG", objEntidad.CCMPSG)
      objParam.Add("PNNPLSGC", objEntidad.NPLSGC)
      objParam.Add("PNQPRCS1", objEntidad.QPRCS1)
      objParam.Add("PNQMRCDR", objEntidad.QMRCDR)
      objParam.Add("PNPMRCDR", objEntidad.PMRCDR)
      objParam.Add("PNVMRCDR", objEntidad.VMRCDR)
      objParam.Add("PNLMRCDR", objEntidad.LMRCDR)
      objParam.Add("PNTRFMRC", objEntidad.TRFMRC)
      objParam.Add("PNFINCSR", objEntidad.FINCSR)
      objParam.Add("PNSTPOMR", objEntidad.STPOMR)
      objParam.Add("PNFCRGMR", objEntidad.FCRGMR)
      objParam.Add("PNNPTSCR", objEntidad.NPTSCR)
      objParam.Add("PNNPTSDS", objEntidad.NPTSDS)
      objParam.Add("PNFENTMR", objEntidad.FENTMR)
      objParam.Add("PNSCNDTR", objEntidad.SCNDTR)
      objParam.Add("PNTMRCDR", objEntidad.TMRCDR)
      objParam.Add("PNSRSTRC", objEntidad.SRSTRC)
      objParam.Add("PNCTPOSR", objEntidad.CTPOSR)
      objParam.Add("PNCTPSBS", objEntidad.CTPSBS)
      objParam.Add("PNCCNDRT", objEntidad.CCNDRT)
      objParam.Add("PNCVPRCN", objEntidad.CVPRCN)
      objParam.Add("PNNVJES ", objEntidad.NVJES)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PNCULUSA", objEntidad.CULUSA)
      objParam.Add("PNNTRMNL", objEntidad.NTRMNL)
      objParam.Add("PNCUSCRT", objEntidad.CUSCRT)
      objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
      objParam.Add("PNHRACRT", objEntidad.HRACRT)
      objParam.Add("PNNTRMCR", objEntidad.NTRMCR)
      objParam.Add("PNCTPUNV", objEntidad.CTPUNV)
      objParam.Add("PNCFRAPG", objEntidad.CFRAPG)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_DETALLE_COTIZACION", objParam)
      For Each oDr As DataRow In oDt.Rows
        obeDetalle_Cotizacion = New Detalle_Cotizacion
        obeDetalle_Cotizacion.NCTZCN = oDr.Item("NCTZCN")
        obeDetalle_Cotizacion.QMRCDR = oDr.Item("QMRCDR")
        obeDetalle_Cotizacion.PMRCDR = oDr.Item("PMRCDR")
        obeDetalle_Cotizacion.CMRCDR = oDr.Item("CMRCDR")
        obeDetalle_Cotizacion.CTPOSR = oDr.Item("CTPOSR")
        obeDetalle_Cotizacion.CTPSBS = oDr.Item("CTPSBS")
        obeDetalle_Cotizacion.NCRRCT = oDr.Item("NCRRCT")
      Next
    Catch ex As Exception
      obeDetalle_Cotizacion.NCTZCN = 0
    End Try
    Return obeDetalle_Cotizacion
  End Function

  Public Function Modificar_Detalle_Cotizacion(ByVal objEntidad As Detalle_Cotizacion) As String
    Dim objResultado As String = ""
    Try

      Dim objParam As New Parameter

      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
      objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
      objParam.Add("PSCUNDMD", objEntidad.CUNDMD)
      objParam.Add("PNCFRMPG", objEntidad.CFRMPG)
      objParam.Add("PSSSGRCT", objEntidad.SSGRCT)
      objParam.Add("PNCCMPSG", objEntidad.CCMPSG)
      objParam.Add("PNNPLSGC", objEntidad.NPLSGC)
      objParam.Add("PNQPRCS1", objEntidad.QPRCS1)
      objParam.Add("PNQMRCDR", objEntidad.QMRCDR)
      objParam.Add("PNPMRCDR", objEntidad.PMRCDR)
      objParam.Add("PNVMRCDR", objEntidad.VMRCDR)
      objParam.Add("PNLMRCDR", objEntidad.LMRCDR)
      objParam.Add("PSTRFMRC", objEntidad.TRFMRC)

      objParam.Add("PSSCNDTR", objEntidad.SCNDTR)

      objParam.Add("PSSRSTRC", objEntidad.SRSTRC)
      objParam.Add("PSCTPOSR", objEntidad.CTPOSR)
      objParam.Add("PSCTPSBS", objEntidad.CTPSBS)

      objParam.Add("PSCVPRCN", objEntidad.CVPRCN)

      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objParam.Add("PSCTPUNV", objEntidad.CTPUNV)
      objParam.Add("PNCFRAPG ", objEntidad.CFRAPG)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNoQuery("SP_SOLMIN_ST_MODIFICAR_DETALLE_COTIZACION", objParam)
      objResultado = "0"
    Catch ex As Exception

      objResultado = "1"
    End Try
    Return objResultado
  End Function

  Public Function Eliminar(ByVal objEntidad As Detalle_Cotizacion) As Double
    Dim dblResultado As Double = 0
    Try
      Dim objParam As New Parameter
      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
      objParam.Add("PNRETORNO", 0, ParameterDirection.Output)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_DETALLE_COTIZACION", objParam)
      dblResultado = objSql.ParameterCollection("PNRETORNO")
    Catch ex As Exception
      dblResultado = 1
    End Try
    Return dblResultado
  End Function

  Public Function Buscar_Detalle_Cotizacion(ByVal obe_Detalle_Cotizacion As Detalle_Cotizacion) As Detalle_Cotizacion
    Dim oDt As New DataTable
    Dim objParam As New Parameter
    Try
      objParam.Add("PNNCTZCN", obe_Detalle_Cotizacion.NCTZCN)
      objParam.Add("PNNCRRCT", obe_Detalle_Cotizacion.NCRRCT)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Detalle_Cotizacion.CCMPN)
      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_DETALLE_COTIZACION", objParam)
      For Each objDataRow As DataRow In oDt.Rows
        obe_Detalle_Cotizacion = New Detalle_Cotizacion
        obe_Detalle_Cotizacion.NORSRT = objDataRow("NORSRT").ToString.Trim
      Next
    Catch ex As Exception
      obe_Detalle_Cotizacion.NORSRT = 0
    End Try
    Return obe_Detalle_Cotizacion
  End Function
End Class
