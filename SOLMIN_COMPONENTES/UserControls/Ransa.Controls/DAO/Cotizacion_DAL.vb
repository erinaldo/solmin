Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Data

Public Class Cotizacion_DAL

  Dim objSql As SqlManager

  Sub New()
    objSql = New SqlManager()
  End Sub

  Public Function Guardar_Cotizacion(ByVal objEntidad As Cotizacion) As List(Of Cotizacion)
    Dim dblResultado As Double = 0
    Dim oDt As DataTable
    Dim olbeCotizacion As New List(Of Cotizacion)
    Dim obeCotizacon As Cotizacion
    Try
      Dim objParam As New Parameter

      objParam.Add("PNCCLNT", objEntidad.CCLNT)
      objParam.Add("PNCMNDA", objEntidad.CMNDA)
      objParam.Add("PNFCTZCN", objEntidad.FCTZCN)
      objParam.Add("PNFVGCTZ", objEntidad.FVGCTZ)
      objParam.Add("PSTCNCLC", objEntidad.TCNCLC)
      objParam.Add("PSCCMPN", objEntidad.CCMPN)
      objParam.Add("PSCDVSN", objEntidad.CDVSN)
      objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
      objParam.Add("PSSCTZTR", objEntidad.SCTZTR)
      objParam.Add("PNCMTVRC", objEntidad.CMTVRC)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
      objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
      objParam.Add("PNHRACRT", objEntidad.HRACRT)
      objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
      objParam.Add("PSTFRMPG", objEntidad.TFRMPG)
      objParam.Add("PSTPRLUN", objEntidad.TPRLUN)
      objParam.Add("PSTDRGDA", objEntidad.TDRGDA)
      objParam.Add("PSTCARGO", objEntidad.TCARGO)
      objParam.Add("PNCPLNFC", objEntidad.CPLNFC)
      objParam.Add("PSSFLZNP", objEntidad.SFLZNP)
      objParam.Add("PNSFSANF", objEntidad.SFSANF)
      objParam.Add("PSSCBRMD", objEntidad.SCBRMD)
      objParam.Add("PSNCNTRT", objEntidad.NCNTRT)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_COTIZACION", objParam)
      For Each objDataRow As DataRow In oDt.Rows
        obeCotizacon = New Cotizacion
        obeCotizacon.NCTZCN = objDataRow.Item("NCTZCN")
        obeCotizacon.CCLNT = objDataRow.Item("CCLNT")
        obeCotizacon.SESTCT = objDataRow.Item("SESTCT")
        obeCotizacon.FVGCTZ = objDataRow.Item("FVGCTZ")
        obeCotizacon.CCMPN = objDataRow.Item("CCMPN")
        obeCotizacon.CDVSN = objDataRow.Item("CDVSN")
        obeCotizacon.SESTCT = objDataRow.Item("SESTCT")
        obeCotizacon.CCLNT = objDataRow.Item("CCLNT")
        olbeCotizacion.Add(obeCotizacon)
      Next
    Catch ex As Exception
      Return olbeCotizacion
    End Try
    Return olbeCotizacion
  End Function

  Public Function Modificar_Cotizacion(ByVal objEntidad As Cotizacion) As Double
    Dim dblResultado As Double = 0
    Try
      Dim objParam As New Parameter
      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNCCLNT", objEntidad.CCLNT)
      objParam.Add("PNCMNDA", objEntidad.CMNDA)
      objParam.Add("PNFCTZCN", objEntidad.FCTZCN)
      objParam.Add("PNFVGCTZ", objEntidad.FVGCTZ)
      objParam.Add("PSTCNCLC", objEntidad.TCNCLC)
      objParam.Add("PSSCTZTR", objEntidad.SCTZTR)
      objParam.Add("PNCMTVRC", objEntidad.CMTVRC)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objParam.Add("PSTFRMPG", objEntidad.TFRMPG)
      objParam.Add("PSTPRLUN", objEntidad.TPRLUN)
      objParam.Add("PSTDRGDA", objEntidad.TDRGDA)
      objParam.Add("PSTCARGO", objEntidad.TCARGO)
      objParam.Add("PNCPLNFC", objEntidad.CPLNFC)
      objParam.Add("PSSFLZNP", objEntidad.SFLZNP)
      objParam.Add("PNSFSANF", objEntidad.SFSANF)
      objParam.Add("PSSCBRMD", objEntidad.SCBRMD)
      objParam.Add("PSNCNTRT", objEntidad.NCNTRT)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_COTIZACION", objParam)

    Catch ex As Exception
      dblResultado = 1
    End Try
    Return dblResultado
  End Function


  Public Function Listar_Cotizaciones(ByVal LobjEntidad As Hashtable) As List(Of Cotizacion)
    Dim objResultado As New DataTable
    Dim objEntidad As Cotizacion
    Dim objListEntidad As New List(Of Cotizacion)
    Try
      Dim objParam As New Parameter
      objParam.Add("PSCCMPN", LobjEntidad("CCMPN"))
      objParam.Add("PSCDVSN", LobjEntidad("CDVSN"))
      objParam.Add("PNCPLNDV", LobjEntidad("CPLNDV"))
      objParam.Add("PSSESTCT", LobjEntidad("SESTCT"))
      objParam.Add("PNFECINI", LobjEntidad("FECINI"))
      objParam.Add("FNFECFIN", LobjEntidad("FECFIN"))
      objParam.Add("PNCCLNT", LobjEntidad("CCLNT"))
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(LobjEntidad("CCMPN"))

      objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_COTIZACION", objParam)

      For Each objDataRow As DataRow In objResultado.Rows
        objEntidad = New Cotizacion
        objEntidad.NCTZCN = objDataRow("NCTZCN").ToString.Trim
        objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
        objEntidad.CLIENTE = objDataRow("CLIENTE").ToString.Trim
        objEntidad.FCTZCN = objDataRow("FCTZCN").ToString.Trim
        objEntidad.FVGCTZ = objDataRow("FVGCTZ").ToString.Trim
        objEntidad.NCNTRT = objDataRow("NCNTRT").ToString.Trim
        objEntidad.SESTCT = objDataRow("SESTCT").ToString.Trim
        objEntidad.CMNDA = objDataRow("CMNDA").ToString.Trim
        objEntidad.MONEDA = objDataRow("MONEDA").ToString.Trim
        objEntidad.TCNCLC = objDataRow("TCNCLC").ToString.Trim
        objEntidad.CPLNFC = objDataRow("CPLNFC").ToString.Trim
        objEntidad.SFLZNP = objDataRow("SFLZNP").ToString.Trim
        objEntidad.SCBRMD = objDataRow("SCBRMD").ToString.Trim
        objEntidad.SFSANF = objDataRow("SFSANF").ToString.Trim
        objEntidad.SCTZTR = objDataRow("SCTZTR").ToString.Trim
        objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
        objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
        objEntidad.CPLNDV = objDataRow("CPLNDV").ToString.Trim
        objListEntidad.Add(objEntidad)
      Next

    Catch ex As Exception
    End Try
    Return objListEntidad
  End Function

  Public Function Reporte_Cotizacion(ByVal lobjEntidad As Hashtable) As List(Of Cotizacion)
    Dim objResultado As New DataTable
    Dim objListEntidad As New List(Of Cotizacion)
    Try
      Dim objParam As New Parameter
      Dim objEntidad As Cotizacion

      objParam.Add("PNNCTZCN", lobjEntidad("NCTZCN"))
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("CCMPN"))
      objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_COTIZACION", objParam)
      For Each objDataRow As DataRow In objResultado.Rows
        objEntidad = New Cotizacion
        objEntidad.NCTZCN = objDataRow("NCTZCN").ToString.Trim
        objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
        objEntidad.CLIENTE = objDataRow("CLIENT").ToString.Trim
        objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
        objEntidad.MERCA = objDataRow("MERCA").ToString.Trim
        objEntidad.RUCCLI = objDataRow("RUCCLI").ToString.Trim
        objEntidad.NCNTRT = objDataRow("NCNTRT").ToString.Trim
        objEntidad.MONEDA = objDataRow("MONEDA").ToString.Trim
        objEntidad.TFRMPG = objDataRow("TFRMPG").ToString.Trim
        objEntidad.CSRCTZ = objDataRow("CSRCTZ").ToString.Trim
        objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
        objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
        objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
        objEntidad.CUNDMD = objDataRow("CUNDMD").ToString.Trim
        objEntidad.SERVIC = objDataRow("SERVIC").ToString.Trim
        objEntidad.PMRCDR = objDataRow("PMRCDR").ToString.Trim
        objEntidad.CSRCTZ = objDataRow("CSRCTZ").ToString.Trim
        objEntidad.DESSCZ = objDataRow("DESSCZ").ToString.Trim
        objEntidad.ITRSRT = objDataRow("ITRSRT").ToString.Trim
        objEntidad.CFRMPG = objDataRow("CFRMPG").ToString.Trim
        objEntidad.MONTRN = objDataRow("MONTRN").ToString.Trim
        objEntidad.ITRSRT = objDataRow("ITRSRT").ToString.Trim
        objEntidad.CFRMPG = objDataRow("CFRMPG").ToString.Trim
        objEntidad.FVGCTZ = objDataRow("FVGCTZ").ToString.Trim
        objEntidad.ORIGEN = objDataRow("ORIGEN").ToString.Trim
        objEntidad.DESTIN = objDataRow("DESTIN").ToString.Trim
        objEntidad.NORSRT = objDataRow("NORSRT").ToString.Trim
        objEntidad.TUNDVH = objDataRow("TUNDVH").ToString.Trim
        objListEntidad.Add(objEntidad)
      Next
    Catch ex As Exception
    End Try
    Return objListEntidad
  End Function

  Public Function Eliminar(ByVal objEntidad As Cotizacion) As Double
    Dim dblResultado As Double = 0
    Try
      Dim objParam As New Parameter
      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_COTIZACION", objParam)
    Catch ex As Exception
      dblResultado = 1
    End Try
  End Function

  Public Function Buscar_Cotizacion(ByVal obe_Cotizacion As Cotizacion) As List(Of Cotizacion)
    Dim oDt As New DataTable
    Dim olbeCotizacion As New List(Of Cotizacion)
    Dim objParam As New Parameter
    Try
      objParam.Add("PNNCTZCN", obe_Cotizacion.NCTZCN)
      objParam.Add("PNCCLNT", obe_Cotizacion.CCLNT)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Cotizacion.CCMPN)

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_COTIZACION", objParam)
      For Each objDataRow As DataRow In oDt.Rows
        Dim objEntidad As New Cotizacion
        objEntidad.NCTZCN = objDataRow("NCTZCN").ToString.Trim
        objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
        objEntidad.CMNDA = objDataRow("CMNDA").ToString.Trim
        objEntidad.FCTZCN = objDataRow("FCTZCN").ToString.Trim
        objEntidad.FVGCTZ = objDataRow("FVGCTZ").ToString.Trim
        objEntidad.NCNTRT = objDataRow("NCNTRT").ToString.Trim
        objEntidad.SESTCT = objDataRow("SESTCT").ToString.Trim
        objEntidad.TCNCLC = objDataRow("TCNCLC").ToString.Trim
        objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
        objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
        objEntidad.CPLNDV = objDataRow("CPLNDV").ToString.Trim
        objEntidad.SCTZTR = objDataRow("SCTZTR").ToString.Trim
        objEntidad.CMTVRC = objDataRow("CMTVRC").ToString.Trim
        objEntidad.FULTAC = objDataRow("FULTAC").ToString.Trim
        objEntidad.HULTAC = objDataRow("HULTAC").ToString.Trim
        objEntidad.CULUSA = objDataRow("CULUSA").ToString.Trim
        objEntidad.NTRMNL = objDataRow("NTRMNL").ToString.Trim
        objEntidad.CUSCRT = objDataRow("CUSCRT").ToString.Trim
        objEntidad.FCHCRT = objDataRow("FCHCRT").ToString.Trim
        objEntidad.HRACRT = objDataRow("HRACRT").ToString.Trim
        objEntidad.NTRMCR = objDataRow("NTRMCR").ToString.Trim
        objEntidad.TFRMPG = objDataRow("TFRMPG").ToString.Trim
        objEntidad.TPRLUN = objDataRow("TPRLUN").ToString.Trim
        objEntidad.TDRGDA = objDataRow("TDRGDA").ToString.Trim
        objEntidad.TCARGO = objDataRow("TCARGO").ToString.Trim
        objEntidad.CPLNFC = objDataRow("CPLNFC").ToString.Trim
        objEntidad.SFLZNP = objDataRow("SFLZNP").ToString.Trim
        objEntidad.SFSANF = objDataRow("SFSANF").ToString.Trim
        objEntidad.SCBRMD = objDataRow("SCBRMD").ToString.Trim
        olbeCotizacion.Add(objEntidad)
      Next
    Catch ex As Exception
    End Try
    Return olbeCotizacion
  End Function

  Public Function Copiar_Cotizacion(ByVal objEntidad As Cotizacion) As Int32
    Dim dblResultado As Int32 = 0
    Try
      Dim objParam As New Parameter
      objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_COPIAR_COTIZACION", objParam)
      dblResultado = 1
    Catch ex As Exception
      dblResultado = 0
    End Try
    Return dblResultado
  End Function

End Class
