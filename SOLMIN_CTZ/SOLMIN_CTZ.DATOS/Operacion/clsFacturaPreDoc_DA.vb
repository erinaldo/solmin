Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.Operaciones
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class clsFacturaPreDoc_DA
    Private objSql As New SqlManager
    Public Function Listar_PreLiquidacion_Factura(ByVal objParametro As Hashtable) As List(Of FacturaPreDoc_BE)
        Dim objEntidad As FacturaPreDoc_BE
        Dim dtresult As New DataTable

        Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
       
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        dtresult = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_PRELIQUIDACION_ADMIN", objParam)
        For Each objDataRow As DataRow In dtresult.Rows
            objEntidad = New FacturaPreDoc_BE
            objEntidad.CCLNFC = objDataRow("CCLNFC")
            objEntidad.CCLNT = objDataRow("CCLNT")
            objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
            objEntidad.NRUCRM = objDataRow("NRUC")
            objEntidad.TDRCRM = objDataRow("TDRCOR").ToString.Trim
            objEntidad.IMPOCOS = objDataRow("IMPOCOS")
            objEntidad.IMPOCOD = objDataRow("IMPOCOD")

          
            objGenericCollection.Add(objEntidad)
        Next
     
        Return objGenericCollection
    End Function

    Public Function Listar_Operaciones_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
        objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
        objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(1))
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPEXLIQUIDACION_ADMIN", objParam)
      
        Return objDataTable
    End Function



    Public Function ListaDatosAdPreLiquidacion(ByVal objParametros As Hashtable) As DataTable

        Dim objParam As New Parameter
        Dim objDataTable As New DataTable

        objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
        objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_INFO_PL_ADMIN", objParam)

      

        Return objDataTable
    End Function
    Public Function ListarPLDocumentos_ADMIN(ByVal obePreDoc As FacturaPreDoc_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CAB_PRE_DOCPL", lobjParams)
        For Each item As DataRow In dt.Rows
            item("IMPORTE") = Val("" & item("IMPORTE"))
        Next


        Return dt
    End Function
   
    Public Sub ActualizarDatosLiquidacion_admin(ByVal objParametros As Hashtable)

        Dim objParam As New Parameter
        Dim objDataTable As New DataTable

        objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
        objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))
        objParam.Add("PSTPDCPE", objParametros("PSTPDCPE"))
        objParam.Add("PSDCCLNT", objParametros("PSDCCLNT"))
        objParam.Add("PSSBCLNT", objParametros("PSSBCLNT"))
        objParam.Add("PSCULUSA", objParametros("PSCULUSA"))
        objParam.Add("PSNTRMNL", HelpClass.NombreMaquina)
       
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

        objSql.ExecuteNonQuery("SP_SOLMIN_CT_UPDATE_INFO_PL_ADMIN", objParam)

      


    End Sub

    Public Sub Anular_PreLiquidacion_Admin(ByVal objEntidad As FacturaPreDoc_BE)

        Dim objParam As New Parameter


        objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_ADMIN", objParam)
       
    End Sub
    Public Function Lista_Liquidacion_ADMIN(ByVal oServicio As FacturaPreDoc_BE, Codvista As String) As DataTable
        'Try
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PSVISTA", Codvista)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_LISTA_LIQUIDACION_ADMIN", lobjParams)

        Return dt

    End Function
    Public Function Listar_Liquidacion(ByVal objParametro As Hashtable) As List(Of FacturaPreDoc_BE)
        Dim objEntidad As New FacturaPreDoc_BE
        Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNFECINI", objParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
       

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        Dim oDt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_LIQUIDACION_ADMIN", objParam)
        For Each objDataRow As DataRow In oDt.Rows
            objEntidad = New FacturaPreDoc_BE
            objEntidad.NPRLQD = objDataRow("NPRLQD")
            objEntidad.IMPOCOS = Val(("" & objDataRow("IMPOCOS")).ToString.Trim)
            objEntidad.IMPOCOD = Val(("" & objDataRow("IMPOCOD")).ToString.Trim)
            objEntidad.TCRVTA = objDataRow("TCRVTA").ToString
            objEntidad.CRGVTA = objDataRow("CRGVTA").ToString

            objEntidad.TIPODOC = objDataRow("TIPODOC").ToString
            objEntidad.DCCLNT = objDataRow("DCCLNT").ToString
            objEntidad.SBCLNT = objDataRow("SBCLNT").ToString

           
            objGenericCollection.Add(objEntidad)
        Next
      
        Return objGenericCollection
    End Function

    '---------------------------------------------COMPANIA-----------------------------------------------
    Public Function Lista_Compania() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_COMPANIA", Nothing)
        Return dt
    End Function

    Public Function Lista_Compania_X_Usuario() As List(Of ClaseGeneral)
        Dim objDataTable As DataTable
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        Dim objClaseGeneral As ClaseGeneral
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_COMPANIA_X_USUARIO", lobjParams)

        For Each objDataRow As DataRow In objDataTable.Rows
            objClaseGeneral = New ClaseGeneral
            objClaseGeneral.CCMPN = objDataRow("CCMPN").ToString.Trim
            objClaseGeneral.TCMPCM = objDataRow("TCMPCM").ToString.Trim
            objLisClaseGeneral.Add(objClaseGeneral)
        Next
        'Catch ex As Exception
        'End Try
        Return objLisClaseGeneral
    End Function
    '-------------------------------------------DIVISION---------------------------------------------
    Public Function Lista_Division() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DIVISION", Nothing)
        Return dt
    End Function

    Public Function Lista_Division_X_Usuario(ByVal strCompania As String) As List(Of ClaseGeneral)
        Dim objDataTable As DataTable
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        Dim objClaseGeneral As ClaseGeneral
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        'lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DIVISION_X_USUARIO", lobjParams)

        For Each objDataRow As DataRow In objDataTable.Rows
            objClaseGeneral = New ClaseGeneral
            objClaseGeneral.CDVSN = objDataRow("CDVSN").ToString.Trim
            objClaseGeneral.TCMPDV = objDataRow("TCMPDV").ToString.Trim
            objClaseGeneral.CCMPN = objDataRow("CCMPN").ToString.Trim
            objLisClaseGeneral.Add(objClaseGeneral)
        Next
        'Catch ex As Exception
        'End Try
        Return objLisClaseGeneral
    End Function

    '-----------------------------------T-------------------
    Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCMNDA1", objParametro("PNCMNDA1"))
        lobjParams.Add("PNFCMBO", objParametro("PNFCMBO"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_CAMBIO", lobjParams)
     
        Return dt
    End Function
    'Public Function Lista_Revision_ADMIN(ByVal pobjFiltro As FacturaPreDoc_BE) As DataTable  'FacturaPreDoc_BE = Filtro
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter

    '    lobjParams.Add("PNNROPL", pobjFiltro.NPRLQD)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_REVISIONES_ADMIN", lobjParams)
    '    Return dt
    'End Function

    'FIX SUMMIT
    '-------------------------------------------------------------------------------------------------
    Public Function ListarPreFacturas_x_PreLiquidacion(ByVal objParametro As Hashtable) As DataTable 'List(Of FacturaPreDoc_BE)
        Dim objEntidad As New FacturaPreDoc_BE
        Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
        Dim objParam As New Parameter

        objParam.Add("PNPRLQD", objParametro("NPRLQD"))
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
        Dim oDt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CONSISTENCIA_X_PRE_LIQUIDACION", objParam)
      
        Return oDt
    End Function

    Public Function Listar_PreFactura(ByVal objParametro As Hashtable) As DataTable 'List(Of FacturaPreDoc_BE)
        Dim objEntidad As New FacturaPreDoc_BE
        Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
        objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
 


        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

        Dim dt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CONSISTENCIA_2_LA", objParam)
      

        Return dt
    End Function


    Public Function Quitar_Pre_Factura(ByVal objEntidad As FacturaPreDoc_BE) As Integer
        Dim Nro_PreLiquidacion As Integer
        Dim objParam As New Parameter

        objParam.Add("PNNDCPRF", objEntidad.NSECFC) 'NDCPRF
        objParam.Add("PNPRLQD", objEntidad.NPRLQD)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PNCCNLNT", objEntidad.CCLNT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_CT_ANULAR_CONSISTENCIA_DE_PRE_LIQUIDACION", objParam)
        Nro_PreLiquidacion = 1

        Return Nro_PreLiquidacion
    End Function



    Public Function Actualizar_PreLiquidacion(ByVal objEntidad As FacturaPreDoc_BE, ByVal NSECFC As String) As String

        Dim objParam As New Parameter 'AEA
        Dim dt As New DataTable
        Dim msg As String = ""
        objParam.Add("PNNPRLQD", objEntidad.NPRLCF)
        objParam.Add("PSNSECFC", NSECFC) 'objEntidad.NSECFC
 
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCCNLNT", objEntidad.CCLNT)
  
 
        dt = objSql.ExecuteDataTable("SP_SOLMIN_CT_ACTUALIZAR_PRE_LIQUIDACION_ADMIN_SOLMIN", objParam)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim

 
        Return msg
    End Function

End Class

