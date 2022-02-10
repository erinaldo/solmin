Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES

Public Class ServicioMercaderia_DAL
    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function ListaServicioFlete(ByVal lobjEntidad As Hashtable) As DataTable
        Dim oDt As New DataTable
        Try
            Dim objParam As New Parameter
            Dim objEntidad As New ServicioMercaderia
            objParam.Add("PSCCMPN", lobjEntidad("PSCCMPN"))
            objParam.Add("PSCDVSN", lobjEntidad("PSCDVSN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("PSCCMPN"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_FLETE", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
        Return oDt

    End Function


    Public Function ListaServicioMercaderia(ByVal lobjEntidad As Hashtable) As List(Of ServicioMercaderia)
        Dim objListEntidad As New List(Of ServicioMercaderia)
        Try
            Dim objParam As New Parameter
            Dim objEntidad As New ServicioMercaderia
            Dim oDt As New DataTable
            objParam.Add("PNNCTZCN", lobjEntidad("NCTZCN"))
            objParam.Add("PNNCRRCT", lobjEntidad("NCRRCT"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("CCMPN"))

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_MERCADERIA", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad = New ServicioMercaderia

                objEntidad.NCTZCN = objDataRow("NCTZCN").ToString().Trim()
                objEntidad.NCRRCT = objDataRow("NCRRCT").ToString().Trim()
                objEntidad.NCRRSR = objDataRow("NCRRSR").ToString().Trim()
                objEntidad.CSRCTZ = objDataRow("CSRCTZ").ToString().Trim()
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString().Trim()
                objEntidad.TOBSSR = objDataRow("TOBSSR").ToString().Trim()
                objEntidad.CLCLOR = objDataRow("CLCLOR").ToString().Trim()
                objEntidad.CLCLDS = objDataRow("CLCLDS").ToString().Trim()
                objEntidad.ITRSRT = objDataRow("ITRSRT").ToString().Trim()
                objEntidad.CMNTRN = objDataRow("CMNTRN").ToString().Trim()
                objEntidad.QIMFCD = objDataRow("QIMFCD").ToString().Trim()
                objEntidad.QIMFCS = objDataRow("QIMFCS").ToString().Trim()
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString().Trim()
                objEntidad.ILSFTR = objDataRow("ILSFTR").ToString().Trim()
                objEntidad.ILCFTR = objDataRow("ILCFTR").ToString().Trim()
                objEntidad.ILQFMX = objDataRow("ILQFMX").ToString().Trim()
                objEntidad.ILQSMT = objDataRow("ILQSMT").ToString().Trim()
                objEntidad.CUNSRA = objDataRow("CUNSRA").ToString().Trim()
                objEntidad.QDSTVR = objDataRow("QDSTVR").ToString().Trim()
                objEntidad.SFCRTV = objDataRow("SFCRTV").ToString().Trim()
                objEntidad.SSRVCB = objDataRow("SSRVCB").ToString().Trim()
                objEntidad.SSRVPG = objDataRow("SSRVPG").ToString().Trim()
                objEntidad.SSRVFE = objDataRow("SSRVFE").ToString().Trim()
                objEntidad.CSTNDT = objDataRow("CSTNDT").ToString().Trim()
                objEntidad.SERVICIO = objDataRow("SERVICIO").ToString().Trim()
                objEntidad.ORIGEN = objDataRow("ORIGEN").ToString().Trim()
                objEntidad.DESTINO = objDataRow("DESTINO").ToString().Trim()
                objEntidad.MONEDA = objDataRow("MONEDA").ToString().Trim()

                objListEntidad.Add(objEntidad)
            Next
        Catch ex As Exception
          
        End Try
        Return objListEntidad
    End Function


    Public Function Guardar_Servicio_Mercadia(ByVal objEntidad As ServicioMercaderia) As ServicioMercaderia
        Dim objResultado As String = ""
        Dim oDt As DataTable
        Try

            Dim objParam As New Parameter

            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
            objParam.Add("PNCSRCTZ", objEntidad.CSRCTZ)
            objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
            objParam.Add("PSTOBSSR", objEntidad.TOBSSR)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNITRSRT", objEntidad.ITRSRT)
            objParam.Add("PNCMNTRN", objEntidad.CMNTRN)
            objParam.Add("PNQIMFCD", objEntidad.QIMFCD)
            objParam.Add("PNQIMFCS", objEntidad.QIMFCS)
            objParam.Add("PNCMNLQT", objEntidad.CMNLQT)
            objParam.Add("PNILSFTR", objEntidad.ILSFTR)
            objParam.Add("PNILCFTR", objEntidad.ILCFTR)
            objParam.Add("PNILQFMX", objEntidad.ILQFMX)
            objParam.Add("PNILQSMT", objEntidad.ILQSMT)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSCUNSRA", objEntidad.CUNSRA)
            objParam.Add("PNQDSTVR", objEntidad.QDSTVR)
            objParam.Add("PSSFCRTV", objEntidad.SFCRTV)
            objParam.Add("PSSSRVCB", objEntidad.SSRVCB)
            objParam.Add("PSSSRVPG", objEntidad.SSRVPG)
            objParam.Add("PSSSRVFE", objEntidad.SSRVFE)
            objParam.Add("PNCSTNDT", objEntidad.CSTNDT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_SERVICIO", objParam)
            For Each oDr As DataRow In oDt.Rows
                objEntidad = New ServicioMercaderia
                objEntidad.NCTZCN = oDr.Item("NCTZCN")
                objEntidad.NCRRCT = oDr.Item("NCRRCT")
                objEntidad.NCRRSR = oDr.Item("NCRRSR")
            Next
        Catch
            objEntidad.NCTZCN = 0
            objEntidad.NCRRCT = 0
            objEntidad.NCRRSR = 0
        End Try
        Return objEntidad
    End Function

    Public Function Modificar_Servicio_Mercadia(ByVal objEntidad As ServicioMercaderia) As String
        Dim objResultado As String = 1
        Try

            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PNCSRCTZ", objEntidad.CSRCTZ)
            objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
            objParam.Add("PSTOBSSR", objEntidad.TOBSSR)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNITRSRT", objEntidad.ITRSRT)
            objParam.Add("PNCMNTRN", objEntidad.CMNTRN)
          
            objParam.Add("PNCMNLQT", objEntidad.CMNLQT)
            objParam.Add("PNILSFTR", objEntidad.ILSFTR)
            objParam.Add("PNILCFTR", objEntidad.ILCFTR)
            objParam.Add("PNILQFMX", objEntidad.ILQFMX)
            objParam.Add("PNILQSMT", objEntidad.ILQSMT)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCUNSRA", objEntidad.CUNSRA)
            objParam.Add("PNQDSTVR", objEntidad.QDSTVR)
            objParam.Add("PSSFCRTV", objEntidad.SFCRTV)
            objParam.Add("PSSSRVCB", objEntidad.SSRVCB)
            objParam.Add("PSSSRVPG", objEntidad.SSRVPG)
            objParam.Add("PSSSRVFE", objEntidad.SSRVFE)
            objParam.Add("PNCSTNDT", objEntidad.CSTNDT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_MODIFICAR_SERVICIO", objParam)
            objResultado = 1
        Catch ex As Exception

            objResultado = 0
        End Try
        Return objResultado
    End Function


    Public Function Cantidad_Detalle_Cotizacion(ByVal objEntidad As ServicioMercaderia) As Double
        Dim dblResultado As Double = 0
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            objParam.Add("PNCANTIDAD", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_CANTIDAD_DETALLE_COTIZACION", objParam)
            dblResultado = objSql.ParameterCollection("PNCANTIDAD")
        Catch ex As Exception
            dblResultado = -1
        End Try
        Return dblResultado
    End Function

    Public Function Eliminar(ByVal objEntidad As ServicioMercaderia) As Double
        Dim dblResultado As Double = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_SERVICIO", objParam)
        Catch ex As Exception
            dblResultado = 1
        End Try
  End Function

  Public Function Existe_Servicio(ByVal objEntidad As ServicioMercaderia) As Int32
    Dim intResultado As Int32 = 0
    Try
      Dim objParam As New Parameter
      objParam.Add("PSCCMPN", objEntidad.CCMPN)
      objParam.Add("PSCDVSN", objEntidad.CDVSN)
      objParam.Add("PNCSRCTZ", objEntidad.CSRCTZ)
      objParam.Add("PNRESPON", 0, ParameterDirection.Output)
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNoQuery("SP_SOLMIN_ST_EXISTE_SERVICIO", objParam)
      intResultado = objSql.ParameterCollection("PNRESPON")
    Catch ex As Exception
      intResultado = 0
    End Try
    Return intResultado
    End Function


    Public Function Existe_FleteRuta(ByVal objEntidad As ServicioMercaderia) As Int32
        Dim intResultado As Int32 = 0
        Try

            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            objParam.Add("PNNCRRCT", objEntidad.NCRRCT)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNRESPON", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_EXISTE_FLETE_RUTA", objParam)
            intResultado = objSql.ParameterCollection("PNRESPON")

        Catch ex As Exception
            intResultado = 0
        End Try
        Return intResultado
    End Function

    ''' <summary>
    ''' Método que permite obtener los servicios asociados a cada detalle de la cotización 
    ''' </summary>
    ''' <param name="objEntidad"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Create :      Hugo Pérez Ryan
    ''' Creaton Date: 20/02/2012
    ''' </remarks>
    ''' 

    Public Function Detectar_Servicio(ByVal objEntidad As ServicioMercaderia) As Double

        Dim dblResultado As Double = 0

        Try

            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", objEntidad.NCTZCN)
            'objParam.Add("PNCRRCT", objEntidad.NCRRCT)
            objParam.Add("PNCANTIDAD", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_CANTIDAD_DETALLE_COTIZACION", objParam)

            'objSql.ExecuteNoQuery("SP_SOLMIN_ST_DETALLE_COTIZACION_TIENE_SERVICIO", objParam)
            dblResultado = objSql.ParameterCollection("PNCANTIDAD")

        Catch ex As Exception

            dblResultado = -1

        End Try

        Return dblResultado

    End Function
End Class
