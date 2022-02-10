Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
'Imports System.Windows.Forms

Public Class clsFactura
    

    Public Function Lista_Giro_Negocio(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GIRO_NEGOCIO", lobjParams)
        Return dt
    End Function



 

    Public Function Lista_Planta_Cliente(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_PLANTA_CLIENTE", lobjParams)
        Return dt
    End Function

 

    Public Function Lista_Datos_Planta_Cliente(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        
        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))
        lobjParams.Add("PNCPLNCL", pobjFiltro("CPLNCL"))
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DATOS_PLANTA_CLIENTE", lobjParams)
        Return dt
    End Function


    
    Public Function Lista_Planta_Facturar(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        
        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DATOS_PLANTA_FACTURAR", lobjParams)
        Return dt
    End Function

    

    Public Function Lista_Datos_Planta(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
        lobjParams.Add("PNCPLNDV", pobjFiltro("CPLNDV"))
       
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DATOS_PLANTA", lobjParams)
        Return dt
    End Function


    Public Function Lista_Documentos_Permitidos(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNCCLNT", pobjFiltro.Parametro3)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DOCUMENTOS_PERMITIDOS", lobjParams)
        Return dt
    End Function

    

    Public Function Lista_Datos_Cliente(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DATOS_CLIENTE", lobjParams)
        Return dt
    End Function


    Public Function Lista_Detalle_Servicios(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSNSECFC", pobjFiltro.Parametro1)
        lobjParams.Add("PNFECFAC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_RZSC20", lobjParams)
        Return dt
    End Function


 

   

    Public Function Lista_Detalle_ServiciosXRevision_V2(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim dtResult As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSNSECFC", pobjFiltro.Parametro1)
        lobjParams.Add("PNFECFAC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_X_REVISION_V2", lobjParams)
        dtResult = dt.Copy
         
        Return dtResult
    End Function


    Public Function Lista_Detalle_ServiciosXOperacion_V2(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim dtResult As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSNSECFC", pobjFiltro.Parametro1)
        lobjParams.Add("PNFECFAC", pobjFiltro.Parametro3)
       

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_X_OPERACION_V2", lobjParams)
        dtResult = dt.Copy
        
        Return dtResult
    End Function


    Public Function Lista_Detalle_ServiciosGeneral(esRecuperoCarga As Boolean, CCLNT As Decimal, Listado As String, TipoConsulta As String, fechaFac As Decimal) As DataTable
        Dim dt As DataTable


        Dim dtResult As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Dim Proceso As String = ""
        If esRecuperoCarga = True Then
            Proceso = "RS"
        End If

        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PSPROCESO", Proceso)
        lobjParams.Add("PSTIPO", TipoConsulta)
        lobjParams.Add("PSLISTADO", Listado)
        lobjParams.Add("PNFECFAC", fechaFac)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_GENERAL", lobjParams)
        dtResult = dt.Copy
        Return dtResult
    End Function

  

    

    Public Function Lista_Tipo_Cambio(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

      
        lobjParams.Add("PNCMNDA1", pobjFiltro("CMNDA1"))
        lobjParams.Add("PNFCMBO", pobjFiltro("FCMBO"))

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_CAMBIO", lobjParams)
        Return dt
    End Function


    Public Function Lista_Region_Venta(ByVal pobjFactura As FacturaSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFactura.PSCCMPN)
        lobjParams.Add("PNCCNTCS", pobjFactura.CCNTCS)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REGION_VENTA", lobjParams)
        Return dt
    End Function

    

    Public Function Grabar_Cabecera_Factura(ByVal pobjArr As Object) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
        lobjParams.Add("PSCTPCTR", pobjArr(1).ToString.Trim)
        lobjParams.Add("PNCTPODC", pobjArr(2).ToString.Trim)
        lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
        lobjParams.Add("PSCDVSN", pobjArr(4).ToString.Trim)
        lobjParams.Add("PSCGRONG", pobjArr(5).ToString.Trim)
        lobjParams.Add("PNCZNFCC", pobjArr(6).ToString.Trim)
        lobjParams.Add("PNCCBRD", pobjArr(7).ToString.Trim)
        lobjParams.Add("PNCCLNT", pobjArr(8).ToString.Trim)
        lobjParams.Add("PNCPLNCL", pobjArr(9).ToString.Trim)
        lobjParams.Add("PNNRUC", pobjArr(10).ToString.Trim)
        lobjParams.Add("PSCSTCDC", pobjArr(11).ToString.Trim)
        lobjParams.Add("PNCPLNDV", pobjArr(12).ToString.Trim)
        lobjParams.Add("PSSABOPN", pobjArr(13).ToString.Trim)
        lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
        lobjParams.Add("PNCMNDA", pobjArr(15).ToString.Trim)
        lobjParams.Add("PNIVLAFS", pobjArr(16).ToString.Trim)
        lobjParams.Add("PNIVLNAS", pobjArr(17).ToString.Trim)
        lobjParams.Add("PNIVLIGS", pobjArr(18).ToString.Trim)
        lobjParams.Add("PNITTFCS", pobjArr(19).ToString.Trim)
        lobjParams.Add("PNITTPGS", pobjArr(20).ToString.Trim)
        lobjParams.Add("PNIVLAFD", pobjArr(21).ToString.Trim)
        lobjParams.Add("PNIVLNAD", pobjArr(22).ToString.Trim)
        lobjParams.Add("PNIVLIGD", pobjArr(23).ToString.Trim)
        lobjParams.Add("PNITTFCD", pobjArr(24).ToString.Trim)
        lobjParams.Add("PNITTPGD", pobjArr(25).ToString.Trim)
        lobjParams.Add("PNITCCTC", pobjArr(26).ToString.Trim)
        lobjParams.Add("PSSFLLTR", pobjArr(27).ToString.Trim)
        lobjParams.Add("PSCZNCBD", pobjArr(28).ToString.Trim)
        lobjParams.Add("PNCCNCSC", pobjArr(29).ToString.Trim)
        lobjParams.Add("PSCRGVTA", pobjArr(30).ToString.Trim)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GRABAR_CABECERA", lobjParams)
        Return dt

    End Function

    Public Sub Grabar_Detalle_Factura(ByVal pobjArr As Object)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter



        lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
        lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
        lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
        lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
        lobjParams.Add("PNNCRDCC", pobjArr(4).ToString.Trim)
        lobjParams.Add("PNCRBCTC", pobjArr(5).ToString.Trim)
        lobjParams.Add("PSSTCCTC", pobjArr(6).ToString.Trim)
        lobjParams.Add("PSCUNCNA", ("" & pobjArr(7)).ToString.Trim)
        lobjParams.Add("PNQAPCTC", pobjArr(8).ToString.Trim)
        lobjParams.Add("PSCUTCTC", ("" & pobjArr(9)).ToString.Trim)
        lobjParams.Add("PNITRCTC", pobjArr(10).ToString.Trim)
        lobjParams.Add("PNIVLDCS", pobjArr(11).ToString.Trim)
        lobjParams.Add("PNIVLDCD", pobjArr(12).ToString.Trim)
        lobjParams.Add("PNNCTDCC", pobjArr(13).ToString.Trim)
        lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
        lobjParams.Add("PSCDVSN", pobjArr(15).ToString.Trim)
        lobjParams.Add("PSCGRNGD", ("" & pobjArr(16)).ToString.Trim)
        lobjParams.Add("PNCCNCSD", pobjArr(17).ToString.Trim)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_GRABAR_DETALLE", lobjParams)
       
    End Sub


    Public Sub Grabar_Detalle_Factura_Masivo(item As beFactura_Transporte)
        Dim retorno As Integer = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", item.CCMPN)

        lobjParams.Add("PNCTPODC", item.CTPODC)
        lobjParams.Add("PNNDCCTC", item.NDCCTC)
        lobjParams.Add("PNNINDRN", item.NINDRN)

        lobjParams.Add("PNNCTDCC", item.NCTDCC)
        lobjParams.Add("PNFDCCTC", item.FDCCTC)

      

         
        lobjParams.Add("PSLISTJSON", item.LISTJSON)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GRABAR_DETALLE_MASIVO", lobjParams)

        retorno = 1


    End Sub


    Public Sub Enviar_Documento_SAP(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
            lobjParams.Add("PSCTPODC", pobjFiltro.Parametro2)
            lobjParams.Add("PSNDCCTC", pobjFiltro.Parametro3)
            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ENVIAR_DOCUMENTO_SAP", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Datos_Servicio(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNCSRVNV", pobjFiltro.Parametro3)
        lobjParams.Add("PNNRTFSV", pobjFiltro.Parametro4)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DATOS_SERVICIO", lobjParams)
        Return dt
    End Function

    Public Function Comprobar_Envio_Documento_SAP(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_COMPROBAR_ENVIO_DOCUMENTO", lobjParams)
        Return dt
    End Function

    Public Sub Grabar_Referencia_Factura(ByVal pobjArr As Object)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
        lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
        lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
        lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
        lobjParams.Add("PNCTPDCC", pobjArr(4).ToString.Trim)
        lobjParams.Add("PSTOBCTC", pobjArr(5).ToString.Trim)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_GRABAR_REFERENCIA", lobjParams)
       
    End Sub


    Public Sub Grabar_Referencia_Factura_MasivoJS(ByVal odetFact As FacturaElectronicaDet)
        Dim dt As New DataTable
        Dim retorno As Integer = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", odetFact.CCMPN)
        lobjParams.Add("PNCTPODC", odetFact.CTPODC)
        lobjParams.Add("PNNDCCTC", odetFact.NDCCTC)
        lobjParams.Add("PNNINDRN", odetFact.NINDRN)
        lobjParams.Add("PSLISTJSON", odetFact.LISTJSON)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)       
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GRABAR_REFERENCIA_MASIVO", lobjParams)
        retorno = 1

    End Sub


    Public Function Lista_Datos_Factura(ByVal pobjFiltro As Filtro) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_FACTURA_LISTA_DATOS_FACTURA", lobjParams)
        Return ds
    End Function

    Public Function Lista_Datos_Factura_Transporte(ByVal pobjFiltro As Hashtable) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_FACTURA_LISTA_DATOS_FACTURA", lobjParams)
        Return ds
    End Function

    Public Function Obtener_Valor_Referencial(ByVal pobjFiltro As Hashtable) As Double
        Dim ldblResult As Double = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCCTC"))
        lobjParams.Add("PNVLRFDT", 0, ParameterDirection.Output)

        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_VALOR_REFERENCIAL", lobjParams)
        ldblResult = lobjSql.ParameterCollection("PNVLRFDT")
        Return ldblResult
    End Function

    Public Function Obtener_Tipo_Factura(ByVal pobjFiltro As Hashtable) As Double
        Dim ldblResult As Double = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCTPDCF", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCCTC"))
        lobjParams.Add("PNTIPOFA", 0, ParameterDirection.Output)

        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_TIPO_FACTURA", lobjParams)
        ldblResult = lobjSql.ParameterCollection("PNTIPOFA")
        Return ldblResult
    End Function

    Public Sub Actualizar_Detalle_Facturado(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNSECFC", pobjFiltro.Parametro1)
            lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
            lobjParams.Add("PNNDCFCC", pobjFiltro.Parametro3)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_RZSC20", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Detalle_Facturado_X_Revision(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNSECFC", pobjFiltro.Parametro1)
            lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
            lobjParams.Add("PNNDCFCC", pobjFiltro.Parametro3)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_X_REVISION", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub Actualizar_Detalle_Facturado_X_Operacion_Masivo(ByVal oHistDet As FacturaHistorialDet)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim retorno As Integer = 0

        lobjParams.Add("PSCCMPN", oHistDet.PSCCMPN)

        lobjParams.Add("PNCTPODC", oHistDet.PNCTPODC)
        lobjParams.Add("PNNDCFCC", oHistDet.PNNDCFCC)
        lobjParams.Add("PSLISTJSON", oHistDet.LISTJSON)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_X_OPERACION_MASIVO", lobjParams)
        retorno = 1



    End Sub

    Public Sub Actualizar_Detalle_Facturado_X_Operacion_V2(ByVal obeFacturaHistorialDet As FacturaHistorialDet)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNOPRCN", obeFacturaHistorialDet.PNNOPRCN)
        lobjParams.Add("PNNRTFSV", obeFacturaHistorialDet.PNNRTFSV)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialDet.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialDet.PNNDCFCC)
        lobjParams.Add("PNNCRDCC", obeFacturaHistorialDet.PNNCRDCC)

        lobjParams.Add("PSFLGAPR", obeFacturaHistorialDet.PSFLGAPR)
        lobjParams.Add("PSUSRCCO", obeFacturaHistorialDet.PSUSRCCO)


        lobjParams.Add("PNNCRROP", obeFacturaHistorialDet.PNNCRROP)


 

        lobjParams.Add("PSCCMPN", obeFacturaHistorialDet.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeFacturaHistorialDet.PNCCLNT)

        lobjParams.Add("PNNPRLQD", obeFacturaHistorialDet.PNNPRLQD)
        lobjParams.Add("PNNPREDOC", obeFacturaHistorialDet.PNNPREDOC)

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)

        lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_DETALLE_FACTURADO_X_OPERACION", lobjParams)
      

 
    End Sub

    Public Function fintRevertirProvisionXFacturaAdmin(ByVal pobjFiltro As Hashtable, EsxPorPreDocumento As Boolean) As Integer
        'Try
        Dim EsPreDocumento As String = "N"
        If EsxPorPreDocumento = True Then
            EsPreDocumento = "S"
        End If
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCMFC", pobjFiltro("PNNDCMFC"))
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjParams.Add("PSXPREDOC", EsPreDocumento)
        'lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_ADMINISTRACION_X_FACTURA", lobjParams)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REVERTIR_PROVISION_OPERACIONES_ADMINISTRACION_X_FACTURA_V2", lobjParams)
        Return 1


    End Function


 

    Public Function Lista_Referencia_Factura_SIL(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))
        lobjParams.Add("PSTIPO", pobjFiltro("TIPO"))
        lobjParams.Add("PSLISTADO", pobjFiltro("LISTADO"))
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_REFERENCIA_SIL_V2", lobjParams)
        Return dt
    End Function


    Public Function Lista_Referencia_RecuperoSeguroCarga(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))
        lobjParams.Add("PSTIPO", pobjFiltro("TIPO"))
        lobjParams.Add("PSLISTADO", pobjFiltro("LISTADO"))
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_REFERENCIA_RECUPERO", lobjParams)
        Return dt
    End Function



    Public Function Lista_Observacion_Factura_SIL(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNSECFC", pobjFiltro.Parametro1)
        lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro2)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_OBSERVACION_SIL_1", lobjParams)
        Return dt
    End Function

    

    

 


    Public Function FechaActualServidor() As Date
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("DTFECHA", "", ParameterDirection.Output)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_OBTENER_FECHA_SERVIDOR", lobjParams)
        Return lobjSql.ParameterCollection.Item("DTFECHA")
    End Function


    Public Function fstrValidarClienteSAP(ByVal objParameter As Hashtable) As String
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim strResultado As String = ""
        Try
            lobjParams.Add("PSCCMPN", objParameter("CCMPN"))
            lobjParams.Add("PSCDVSN", objParameter("CDVSN"))
            lobjParams.Add("PSCRGVTA", objParameter("CRGVTA"))
            lobjParams.Add("PNCCLNT", objParameter("CCLNT"))
            lobjParams.Add("PARAM_MSGRET", "", ParameterDirection.Output)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP103C", lobjParams)
            strResultado = lobjSql.ParameterCollection("PARAM_MSGRET").ToString.Trim
        Catch ex As Exception
            strResultado = ""
        End Try
        Return strResultado
    End Function

    Public Sub Actualizar_NombreServicio(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro1)
            lobjParams.Add("PNNRTFSV", pobjFiltro.Parametro2)
            lobjParams.Add("PNNDCFCC", pobjFiltro.Parametro3)
            lobjParams.Add("PNNCRDCC", pobjFiltro.Parametro4)
            lobjParams.Add("PSNOMSRV", pobjFiltro.Parametro5)
            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ACTUALIZAR_NOMSER_X_OPERACION", lobjParams)

        Catch ex As Exception
        End Try
    End Sub

    Public Function Lista_Operaciones_Documento_Facturadas_X_Operacion(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obeFacturaHistorialCab.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeFacturaHistorialCab.PNCCLNT)
        lobjParams.Add("PNNOPRCN", obeFacturaHistorialCab.PNNOPRCN)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialCab.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialCab.PNNDCFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_FACTURADOS_X_OPERACION", lobjParams)
        Return dt
    End Function

    Public Function Lista_Operaciones_Historial_x_Cliente(ByVal CCLNT As Decimal, ByVal NOPRCN As Decimal, ByVal LIST_NCRROP As String, ByVal CTPODC As Decimal, ByVal NDCCTC As Decimal) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PNNOPRCN", NOPRCN)
        lobjParams.Add("PSNCRROP", LIST_NCRROP)
        lobjParams.Add("CTPODC", CTPODC)
        lobjParams.Add("NDCCTC", NDCCTC)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_HISTORIAL_X_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Sub Actualizar_Referencia_Documento_Cuenta_Corriente(ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal, ByVal PNCTPDCO As Decimal, ByVal PNNDCMOR As Decimal, ByVal PNFDCMOR As Decimal)
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCTPODC", PNCTPODC)
        lobjParams.Add("PNNDCCTC", PNNDCCTC)
        lobjParams.Add("PNCTPDCO", PNCTPDCO)
        lobjParams.Add("PNNDCMOR", PNNDCMOR)
        lobjParams.Add("PNFDCMOR", PNFDCMOR)
        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        objSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_REFERENCIA_ORIGEN_DOCUMENTO", lobjParams)

    End Sub

    Public Function Lista_Dato_General_Documento(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obeFacturaHistorialCab.PSCCMPN)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialCab.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialCab.PNNDCFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_DATO_GENERAL_CUENTA_CORRIENTE", lobjParams)
        Return dt
    End Function

    ''' <summary>
    ''' Actualiza la factura si tiene detracción 
    ''' </summary>
    ''' <param name="obeFacturaHistorialCab"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintActualizarFacturaDetracionSPOT(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable

        lobjParams.Add("PSCCMPN", obeFacturaHistorialCab.PSCCMPN)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialCab.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialCab.PNNDCFCC)
        lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_GRABAR_DETRACCION_SPOT", lobjParams)
        
        Return 1
    End Function

    Public Sub Registrar_Refactura_Historial_RZCT34(ByVal pobjFiltro As Hashtable)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNTDOCOR", pobjFiltro("PNTDOCOR"))
        lobjParams.Add("PNNDOCOR", pobjFiltro("PNNDOCOR"))
        lobjParams.Add("PNTDOCGN", pobjFiltro("PNTDOCGN"))
        lobjParams.Add("PNNDOCGN", pobjFiltro("PNNDOCGN"))
        lobjParams.Add("PSFLGRFC", pobjFiltro("PSFLGRFC"))
        lobjParams.Add("PNTOR_HIST", pobjFiltro("PNTOR_HIST"))
        lobjParams.Add("PNNDOC_HIST", pobjFiltro("PNNDOC_HIST"))
        lobjParams.Add("PSUSRCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSPRGCRT", pobjFiltro("PSPRGCRT"))
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_FACTURA_GRABAR_HISTORIAL_REFACTURA_RZCT34", lobjParams)
    End Sub

    Public Function Lista_Datos_Cuenta_Corriente(ByVal pobjFiltro As Hashtable) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DOC_CUENTA_CTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Doc_Origen_Operacion(ByVal PNNOPRCN As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PNNOPRCN", PNNOPRCN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_FACTURAS_X_OPERACIONES_LIBERADAS", lobjParams)
        Return dt
    End Function


    Public Sub Anular_Cuenta_corriente_Historial_RZCT34(ByVal pobjFiltro As Hashtable)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro("PSCCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("PNCTPODC"))
        lobjParams.Add("PNNDCCTC", pobjFiltro("PNNDCCTC"))
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ANULAR_DOC_CUENTA_CTE_HISTORIAL", lobjParams)
    End Sub

 
    Public Function Lista_Datos_Adicionales_Factura(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_INFORMACION_COMPANIA", lobjParams)
        Return dt
    End Function

    'CSR-HUNDRED-FIN
    '<[AHM]>
    Public Function ValidarClienteSAP(ByVal codigoCompania As String, ByVal codRegionVenta As String, ByVal codCliente As String, ByRef msgError As String) As DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable

        lobjParams.Add("PSCCMPN", codigoCompania)
        lobjParams.Add("PSCRGVTA", codRegionVenta)
        lobjParams.Add("PNCCLNT", codCliente)
        lobjParams.Add("MSERROR", msgError, ParameterDirection.InputOutput)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_CLIENTE_SAP", lobjParams)
        'Dim dt As DataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_CLIENTE_SAP", lobjParams)
        msgError = lobjSql.ParameterCollection("MSERROR").ToString.Trim
        'msgError = lobjParams.Item(4).Value.ToString()
        Return dt
    End Function
    '</[AHM]>

  
    Public Function Estimacion_Ingreso_Revertir(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

  
        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("PNCTPODC", pobjFiltro("CTPODC"))
        lobjParams.Add("PNNDCFCC", pobjFiltro("NDCFCC"))
        lobjParams.Add("PNNSECFC", pobjFiltro("NSECFC"))

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTA_ESTIMACION_INGRESO_REVERTIR", lobjParams)
        Return dt
    End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

#Region "REFACTURA"

    Public Function Lista_Documentos_Permitidos_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNCCLNT", pobjFiltro.Parametro3)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro4)
        dt = objSql.ExecuteDataTable("SP_SOLCT_FACTURA_DOCUMENTOS_PERMITIDOS_REFACTURA", lobjParams)
        Return dt
    End Function

    Public Function Listar_Documentos_Emitidos_x_Operacion(ByVal param As Hashtable) As DataTable
        Dim objSql As New SqlManager
        Dim objParamtero As New Parameter
        Dim dtQuery As New DataTable
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNOPRCN", param("PNNOPRCN"))
        dtQuery = objSql.ExecuteDataTable("SP_SOLCT_LISTAR_DOC_EMITIDOS_X_OPERACION", objParamtero)
        Return dtQuery
    End Function


    Public Function Lista_Detalle_ServiciosXOperacionRefactura(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSNSECFC", pobjFiltro.Parametro1)
        lobjParams.Add("PNFECFAC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_X_OPERACION_REFACTURACION", lobjParams)
        Return dt
    End Function

    Public Function Grabar_Cabecera_ReFactura(ByVal pobjArr As Object) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
        lobjParams.Add("PSCTPCTR", pobjArr(1).ToString.Trim)
        lobjParams.Add("PNCTPODC", pobjArr(2).ToString.Trim)
        lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
        lobjParams.Add("PSCDVSN", pobjArr(4).ToString.Trim)
        lobjParams.Add("PSCGRONG", pobjArr(5).ToString.Trim)
        lobjParams.Add("PNCZNFCC", pobjArr(6).ToString.Trim)
        lobjParams.Add("PNCCBRD", pobjArr(7).ToString.Trim)
        lobjParams.Add("PNCCLNT", pobjArr(8).ToString.Trim)
        lobjParams.Add("PNCPLNCL", pobjArr(9).ToString.Trim)
        lobjParams.Add("PNNRUC", pobjArr(10).ToString.Trim)
        lobjParams.Add("PSCSTCDC", pobjArr(11).ToString.Trim)
        lobjParams.Add("PNCPLNDV", pobjArr(12).ToString.Trim)
        lobjParams.Add("PSSABOPN", pobjArr(13).ToString.Trim)
        lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
        lobjParams.Add("PNCMNDA", pobjArr(15).ToString.Trim)
        lobjParams.Add("PNIVLAFS", pobjArr(16).ToString.Trim)
        lobjParams.Add("PNIVLNAS", pobjArr(17).ToString.Trim)
        lobjParams.Add("PNIVLIGS", pobjArr(18).ToString.Trim)
        lobjParams.Add("PNITTFCS", pobjArr(19).ToString.Trim)
        lobjParams.Add("PNITTPGS", pobjArr(20).ToString.Trim)
        lobjParams.Add("PNIVLAFD", pobjArr(21).ToString.Trim)
        lobjParams.Add("PNIVLNAD", pobjArr(22).ToString.Trim)
        lobjParams.Add("PNIVLIGD", pobjArr(23).ToString.Trim)
        lobjParams.Add("PNITTFCD", pobjArr(24).ToString.Trim)
        lobjParams.Add("PNITTPGD", pobjArr(25).ToString.Trim)
        lobjParams.Add("PNITCCTC", pobjArr(26).ToString.Trim)
        lobjParams.Add("PSSFLLTR", pobjArr(27).ToString.Trim)
        lobjParams.Add("PSCZNCBD", pobjArr(28).ToString.Trim)
        lobjParams.Add("PNCCNCSC", pobjArr(29).ToString.Trim)
        lobjParams.Add("PSCRGVTA", pobjArr(30).ToString.Trim)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjParams.Add("PNCTPDCO", pobjArr(31).ToString.Trim)
        lobjParams.Add("PNNDCMOR", pobjArr(32).ToString.Trim)
        lobjParams.Add("PNFDCMOR", pobjArr(33).ToString.Trim)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GRABAR_CABECERA_REFACTURA", lobjParams)
        Return dt

    End Function

    Public Sub Grabar_Detalle_Factura_Refactura(ByVal pobjArr As Object)
        'Try
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjArr(0).ToString.Trim)
        lobjParams.Add("PNCTPODC", pobjArr(1).ToString.Trim)
        lobjParams.Add("PNNDCCTC", pobjArr(2).ToString.Trim)
        lobjParams.Add("PNNINDRN", pobjArr(3).ToString.Trim)
        lobjParams.Add("PNNCRDCC", pobjArr(4).ToString.Trim)
        lobjParams.Add("PNCRBCTC", pobjArr(5).ToString.Trim)
        lobjParams.Add("PSSTCCTC", pobjArr(6).ToString.Trim)
        lobjParams.Add("PSCUNCNA", ("" & pobjArr(7)).ToString.Trim)
        lobjParams.Add("PNQAPCTC", pobjArr(8).ToString.Trim)
        lobjParams.Add("PSCUTCTC", ("" & pobjArr(9)).ToString.Trim)
        lobjParams.Add("PNITRCTC", pobjArr(10).ToString.Trim)
        lobjParams.Add("PNIVLDCS", pobjArr(11).ToString.Trim)
        lobjParams.Add("PNIVLDCD", pobjArr(12).ToString.Trim)
        lobjParams.Add("PNNCTDCC", pobjArr(13).ToString.Trim)
        lobjParams.Add("PNFDCCTC", pobjArr(14).ToString.Trim)
        lobjParams.Add("PSCDVSN", pobjArr(15).ToString.Trim)
        lobjParams.Add("PSCGRNGD", ("" & pobjArr(16)).ToString.Trim)
        lobjParams.Add("PNCCNCSD", pobjArr(17).ToString.Trim)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_GRABAR_DETALLE_REFACTURA", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Function Traer_Importe_Refactura(ByVal param As Hashtable) As DataTable
        Dim objSql As New SqlManager
        Dim objParamtero As New Parameter
        Dim dtImporte As New DataTable
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        'objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
        dtImporte = objSql.ExecuteDataTable("SP_SOLCT_TRAER_IMPORTE_REFACTURA", objParamtero)
        Return dtImporte
    End Function

    Public Function Grabar_Historial_Documento_Cabecera(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As Decimal
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeFacturaHistorialCab.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeFacturaHistorialCab.PNCCLNT)
        lobjParams.Add("PNNOPRCN", obeFacturaHistorialCab.PNNOPRCN)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialCab.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialCab.PNNDCFCC)
        lobjParams.Add("PNFDCFCC", obeFacturaHistorialCab.PNFDCFCC)
        lobjParams.Add("PNCMNDA1", obeFacturaHistorialCab.PNCMNDA1)
        lobjParams.Add("PNIVLSRV", obeFacturaHistorialCab.PNIVLSRV)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
        lobjParams.Add("PNNCRRFC", 0, ParameterDirection.Output)
        lobjSql.ExecuteNonQuery("SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_CABECERA", lobjParams)
        Return lobjSql.ParameterCollection("PNNCRRFC")
    End Function

    'SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_MASIVO

    Public Sub Grabar_Historial_Documento_Detalle(ByVal obeFacturaHistorialDet As FacturaHistorialDet)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeFacturaHistorialDet.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeFacturaHistorialDet.PNCCLNT)
        lobjParams.Add("PNNOPRCN", obeFacturaHistorialDet.PNNOPRCN)
        lobjParams.Add("PNNCRRFC", obeFacturaHistorialDet.PNNCRRFC)
        lobjParams.Add("PNNCRROP", obeFacturaHistorialDet.PNNCRROP)
        lobjParams.Add("PNNRTFSV", obeFacturaHistorialDet.PNNRTFSV)
        lobjParams.Add("PNQATNAN", obeFacturaHistorialDet.PNQATNAN)
        lobjParams.Add("PSCUNDMD", obeFacturaHistorialDet.PSCUNDMD)
        lobjParams.Add("PNIVLSRV", obeFacturaHistorialDet.PNIVLSRV)
        lobjParams.Add("PNNCRDCC", obeFacturaHistorialDet.PNNCRDCC)
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_DETALLE", lobjParams)
    End Sub


    Public Sub Grabar_Historial_Documento_Masivo(ByVal oHistorial As FacturaHistorialCab)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        Dim retorno As Integer = 0
        lobjParams.Add("PSCCMPN", oHistorial.PSCCMPN)

        lobjParams.Add("PNCTPODC", oHistorial.PNCTPODC)
        lobjParams.Add("PNNDCFCC", oHistorial.PNNDCFCC)

        lobjParams.Add("PSLISTJSON", oHistorial.LISTJSON)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_MASIVO", lobjParams)

        retorno = 1
      

    End Sub


    Public Sub Liberar_Operacion_Servicio_Refactura(ByVal obeFacturaHistorialCab As FacturaHistorialCab, ByVal PSLIBERAR As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", obeFacturaHistorialCab.PNNOPRCN)
        lobjParams.Add("PNCCLNT", obeFacturaHistorialCab.PNCCLNT)
        lobjParams.Add("PNCTPODC", obeFacturaHistorialCab.PNCTPODC)
        lobjParams.Add("PNNDCFCC", obeFacturaHistorialCab.PNNDCFCC)
        lobjParams.Add("PSLIBERAR", PSLIBERAR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_REFACTURA_LIBERAR_OPERACION_SERVICIO_REFACTURA", lobjParams)
    End Sub

    Public Sub Actualizar_NombreServicio_Historial(ByVal pobjFiltro As Filtro)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro1)
        lobjParams.Add("PNNRTFSV", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCFCC", pobjFiltro.Parametro3)
        lobjParams.Add("PNNCRDCC", pobjFiltro.Parametro4)
        lobjParams.Add("PSNOMSRV", pobjFiltro.Parametro5)
        lobjSql.ExecuteNonQuery("SP_SOLCT_REFACTURA_ACTUALIZAR_NOMSER_X_OPERACION", lobjParams)
    End Sub
    Public Function Lista_Datos_ReFactura(ByVal pobjFiltro As Filtro) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_FACTURA_LISTA_DATOS_REFFACTURA", lobjParams)
        Return ds
    End Function

#Region "SIL-REFACTURA"
    Public Function Lista_Unidad_Consistencia_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_UNIDAD_CONSISTENCIA_SIL_REFACTURA", lobjParams)
        Return dt
    End Function

    Public Function Lista_Referencia_Factura_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_REFERENCIA_SIL_REFACTURA", lobjParams)
        Return dt
    End Function

    Public Function Lista_Observacion_Factura_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_OBSERVACION_SIL_REFACTURA", lobjParams)
        Return dt
    End Function

#End Region

#End Region

#Region "FACTURA - ELECTRONICA"  'JM

    

    Public Function Lista_Documentos_Permitidos_Facturacion_Electronico(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        
        lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
        lobjParams.Add("PNCCLNT", pobjFiltro("CCLNT"))
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_SD_FACTURA_DOCUMENTOS_PERMITIDOS_ELECTRONICO", lobjParams)
        Return dt
    End Function


 

    Public Function Lista_Punto_Venta_FE(ByVal pobjFiltro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", pobjFiltro("CCMPN"))
        lobjParams.Add("IN_CDVSN", pobjFiltro("CDVSN"))
        lobjParams.Add("IN_CUSROP", ConfigurationWizard.UserName)
        lobjParams.Add("IN_CGRONG", pobjFiltro("CGRONG"))
        lobjParams.Add("IN_CCLNT", pobjFiltro("CCLNT"))
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_PUNTO_VENTA_FE", lobjParams)
        Return dt
    End Function


    Public Sub Grabar_Cabecera_Factura_ELectronica(ByVal objCabecera_FE As FacturaElectronica)
        'Try
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", objCabecera_FE.CCMPN)
        lobjParams.Add("IN_CTPODC", objCabecera_FE.CTPODC)
        lobjParams.Add("IN_NDCCTC", objCabecera_FE.NDCCTC)
        lobjParams.Add("IN_NINDRN", objCabecera_FE.NINDRN)
        lobjParams.Add("IN_FDCCTC", objCabecera_FE.FDCCTC)
        lobjParams.Add("IN_CTPDCO", objCabecera_FE.CTPDCO)
        lobjParams.Add("IN_NDCMOR", objCabecera_FE.NDCMOR)
        lobjParams.Add("IN_FDCMOR", objCabecera_FE.FDCMOR)
        lobjParams.Add("IN_CDMODN", objCabecera_FE.CDMODN)
        lobjParams.Add("IN_CRGVTA", objCabecera_FE.CRGVTA)
        lobjParams.Add("IN_CTPCTR", objCabecera_FE.CTPCTR)
        lobjParams.Add("IN_CCLNT", objCabecera_FE.CCLNT)
        lobjParams.Add("IN_CCLNOP", objCabecera_FE.CCLNOP) 'Desarollador 3 JD
        lobjParams.Add("IN_CDDRSP", objCabecera_FE.CDDRSP)
        lobjParams.Add("IN_CGRONG", objCabecera_FE.CGRONG)
        lobjParams.Add("IN_CZNFCC", objCabecera_FE.CZNFCC)
        lobjParams.Add("IN_IVLDCS", objCabecera_FE.IVLDCS)
        lobjParams.Add("IN_PIGVA", objCabecera_FE.PIGVA)
        lobjParams.Add("IN_IVLIGS", objCabecera_FE.IVLIGS)
        lobjParams.Add("IN_ITTFCS", objCabecera_FE.ITTFCS)
        lobjParams.Add("IN_CMNDA", objCabecera_FE.CMNDA)
        lobjParams.Add("IN_NDSPGD", objCabecera_FE.NDSPGD)
        lobjParams.Add("IN_NFORFA", objCabecera_FE.NFORFA)
        lobjParams.Add("IN_CUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSCUBIGE", objCabecera_FE.CUBIGE)
        lobjParams.Add("PSDIRSEV", objCabecera_FE.DIRSEV)
        lobjParams.Add("PSOC_CLIENTE", objCabecera_FE.OC_CLIENTE)
        lobjParams.Add("ES_PREDOCUMENTO", objCabecera_FE.ES_PREDOCUMENTO)

        'lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_CAB_FE_INSERT", lobjParams)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_CAB_FE_INSERTV2", lobjParams)
       

    End Sub

    Public Sub Grabar_Detalle_Factura_Electronica(ByVal objDetalle_FE As FacturaElectronicaDet)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", objDetalle_FE.CCMPN)
        lobjParams.Add("IN_CTPODC", objDetalle_FE.CTPODC)
        lobjParams.Add("IN_NDCCTC", objDetalle_FE.NDCCTC)
        lobjParams.Add("IN_NCRDCC", objDetalle_FE.NCRDCC)
        lobjParams.Add("IN_NINDRN", objDetalle_FE.NINDRN)
        lobjParams.Add("IN_CSRVNV", objDetalle_FE.CSRVNV)
        lobjParams.Add("IN_NOMSER", objDetalle_FE.NOMSER)
        lobjParams.Add("IN_TOBCTC", objDetalle_FE.TOBCTC)
        lobjParams.Add("IN_QAPCTC", objDetalle_FE.QAPCTC)
        lobjParams.Add("IN_CUNCNA", objDetalle_FE.CUNCNA)
        lobjParams.Add("IN_ITRCTC", objDetalle_FE.ITRCTC)
        lobjParams.Add("IN_IVLDCS", objDetalle_FE.IVLDCS)
        lobjParams.Add("IN_CUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DET_FE_INSERT", lobjParams)
       
    End Sub

    Public Sub Grabar_Detalle_Factura_Electronica_Masivo(ByVal objDetalle_FE As FacturaElectronicaDet)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        Dim retorno As Integer = 0

       

        lobjParams.Add("IN_CCMPN", objDetalle_FE.CCMPN)
        lobjParams.Add("IN_CTPODC", objDetalle_FE.CTPODC)
        lobjParams.Add("IN_NDCCTC", objDetalle_FE.NDCCTC)
        lobjParams.Add("IN_NINDRN", objDetalle_FE.NINDRN)
        'lobjParams.Add("IN_NCRDCC", objDetalle_FE.NCRDCC)
        'lobjParams.Add("IN_CSRVNV", objDetalle_FE.CSRVNV)
        'lobjParams.Add("IN_NOMSER", objDetalle_FE.NOMSER)
        'lobjParams.Add("IN_TOBCTC", objDetalle_FE.TOBCTC)
        'lobjParams.Add("IN_QAPCTC", objDetalle_FE.QAPCTC)
        'lobjParams.Add("IN_CUNCNA", objDetalle_FE.CUNCNA)
        'lobjParams.Add("IN_ITRCTC", objDetalle_FE.ITRCTC)
        'lobjParams.Add("IN_IVLDCS", objDetalle_FE.IVLDCS)
        lobjParams.Add("LISTJSON", objDetalle_FE.LISTJSON)
        lobjParams.Add("IN_CUSCRT", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_DET_FE_INSERT_MASIVO", lobjParams)
        retorno = 1

    End Sub


    Public Function Lista_Tipo_Nota_Electronico(ByVal pCCMPN As String, ByVal pCTPODC As Integer) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", pCCMPN)
        lobjParams.Add("IN_CTPODC", pCTPODC)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_TIPO_NOTA", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_Factura_Electronica(ByVal pobjFiltro As Filtro) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_FACTURA_LISTA_DATOS_FACTURA_ELECTRONICO", lobjParams)

        Return ds
    End Function

    Public Sub Enviar_Documento_SAP_FE(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
            lobjParams.Add("PSCTPODC", pobjFiltro.Parametro2)
            lobjParams.Add("PSNDCCTC", pobjFiltro.Parametro3)
            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_ENVIAR_DOCUMENTO_SAP_FE", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Reenviar_Documento_SAP_FE(ByVal pobjFiltro As Filtro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
            lobjParams.Add("PSCTPODC", pobjFiltro.Parametro2)
            lobjParams.Add("PSNDCCTC", pobjFiltro.Parametro3)
            lobjParams.Add("PSCSCDSP", pobjFiltro.Parametro4)
            lobjParams.Add("PSNDCCTE", pobjFiltro.Parametro5)

            lobjSql.ExecuteNonQuery("SP_SOLCT_FACTURA_REENVIAR_DOCUMENTO_SAP_FE", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function fstrValidarClienteSAPFE(ByVal objParameter As Hashtable) As String
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim strResultado As String = ""
        Try

            lobjParams.Add("PSCCMPN", objParameter("CCMPN"))
            lobjParams.Add("PSCZNFCC", objParameter("CZNFCC"))
            lobjParams.Add("PNCCLNT", objParameter("CCLNT"))
            lobjParams.Add("PSCRGVTA", objParameter("CRGVTA"))
            lobjParams.Add("PARAM_MSGRET", "", ParameterDirection.Output)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP110", lobjParams)
            strResultado = lobjSql.ParameterCollection("PARAM_MSGRET").ToString.Trim
        Catch ex As Exception
            strResultado = ""
        End Try
        Return strResultado
    End Function

#Region "REFACTURA_ELECTRONICA"
    Public Function Lista_Documentos_Permitidos_Refactura_FE(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("IN_CDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("IN_CTPODC", CInt(pobjFiltro.Parametro3))
        lobjParams.Add("IN_CUSROP", ConfigurationWizard.UserName)
        lobjParams.Add("IN_CGRONG", pobjFiltro.Parametro4)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SD_FACTURA_DOCUMENTOS_PERMITIDOS_REFACTURA_FE", lobjParams)
        Return dt
    End Function



    Public Function Lista_Datos_ReFactura_Electronica(ByVal pobjFiltro As Filtro) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PNCTPODC", pobjFiltro.Parametro2)
        lobjParams.Add("PNNDCCTC", pobjFiltro.Parametro3)
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_FACTURA_LISTA_DATOS_REFFACTURA_FE", lobjParams)


        Return ds
    End Function

#End Region

#Region "Parte Transferencia"

    Public Function Lista_UsuarioAprobador_ParteTransferencia() As List(Of FacturaHistorialDet)
        Dim list As New List(Of FacturaHistorialDet)
        Dim obFacturaHistorialDet As FacturaHistorialDet
        Dim dt As DataTable
        Dim objSql As New SqlManager
        dt = objSql.ExecuteDataTable("SP_SOLCT_LISTA_USUARIO_APROBADO_TI", Nothing)
        For Each Item As DataRow In dt.Rows
            obFacturaHistorialDet = New FacturaHistorialDet()
            obFacturaHistorialDet.PSUSRCCO = Item("USRCCO").ToString.Trim
            obFacturaHistorialDet.PSNOMUAP = Item("NOMBRE").ToString.Trim
            list.Add(obFacturaHistorialDet)
        Next
        Return list
    End Function

    'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - INICIO 
    Public Function Lista_Datos_Documento_Emitido(ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal) As DataSet
        Dim dt As DataSet
        Dim lobjParams As New Parameter
        Dim objSql As New SqlManager
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCTPODC", PNCTPODC)
        lobjParams.Add("PNNDCCTC", PNNDCCTC)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        dt = objSql.ExecuteDataSet("SP_SOLMIN_SD_FACTURA_LISTA_DATOS_DOCUMENTO_EMITIDO", lobjParams)
        Return dt
    End Function
    'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - FIN 
#End Region

#End Region

    

    Public Function Validar_Listado_Facturacion(ByVal compania As String, ByVal division As String, cliente As Decimal, Listado As String, TipoLista As String) As DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As DataTable
     
        lobjParams.Add("PARAM_CCMPN", compania)
        lobjParams.Add("PARAM_CDVSN", division)
        lobjParams.Add("PARAM_CCLNT", cliente)
        lobjParams.Add("PARAM_TIPO", TipoLista)
        lobjParams.Add("PARAM_LISTADO", Listado)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDA_OPERACIONES_FACTURA_V2", lobjParams)

        
        Return dt

    End Function



    Public Function Obtener_Factura_Servicio_SUNAT(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PNNOPRCN As Decimal, ByVal PNNSECFC As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As DataTable


        lobjParams.Add("PARAM_CCMPN", PSCCMPN)
        lobjParams.Add("PARAM_CDVSN", PSCDVSN)
        lobjParams.Add("PARAM_CCLNT", PNCCLNT)
        lobjParams.Add("PARAM_NOPRCN", PNNOPRCN)
        lobjParams.Add("PARAM_NSECFC", PNNSECFC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DATOS_OPERACIONES_FACTURA_SERVICIO_SUNAT", lobjParams)

       
        Return dt
    End Function

    
    Public Function Lista_Detalle_ServiciosGeneral_PreDocumentos(CodCliente As Decimal, NroPl As Decimal, PreDocList As String, FechaFac As Decimal) As DataTable
        Dim dt As DataTable
        Dim dtResult As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
       
        lobjParams.Add("PNCCLNT", CodCliente)
        lobjParams.Add("PNNROPL", NroPl)
        lobjParams.Add("PSPREDOC", PreDocList)
        lobjParams.Add("PNFECFAC", FechaFac)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_DETALLE_SERVICIOS_X_PREDOC", lobjParams)
        dtResult = dt.Copy

        Return dtResult
    End Function

    Public Function Lista_OrgVenta_Cliente(pCCMPN As String, pCCLNFC As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pCCMPN)
        lobjParams.Add("PNCCLNT", pCCLNFC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_ORG_VENTA_CLIENTE", lobjParams)
        Return dt
    End Function


End Class
