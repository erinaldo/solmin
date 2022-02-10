Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsServicio
    Public Function Lista_Servicios_X_Operacion(ByVal oServicioSIL As beServicioFacturar) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        lobjParams.Add("PNNORSCI", oServicioSIL.PNNORSCI)
        lobjParams.Add("PSBUSQUEDA", oServicioSIL.PSBUSQUEDA)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_SERVICIOS_SERVICIO_OPERACION", lobjParams)
        Return dt
    End Function

    Public Function Lista_Tarifa_Servicios_Cliente_Adicionales(ByVal oServicioSIL As beServicioConsulta) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicioSIL.PSCCMPN)
        lobjParams.Add("PSCDVSN", oServicioSIL.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oServicioSIL.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        lobjParams.Add("PNFECSER", oServicioSIL.PNFECSER)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION_ADICIONALES", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_Tarifa(ByVal PNNRTFSV As Decimal) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRTFSV", PNNRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_TARIFA", lobjParams)
        Return dt
    End Function


    Public Function Insertar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim PNNOPRCN As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        objParam.Add("PNCCLNFC", oServicioSIL.PNCCLNFC)
        objParam.Add("PSCCMPN", oServicioSIL.PSCCMPN)
        objParam.Add("PSCDVSN", oServicioSIL.PSCDVSN)
        objParam.Add("PNFOPRCN", oServicioSIL.PNFOPRCN)
        objParam.Add("PSCTPALJ", oServicioSIL.PSCTPALJ)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        objParam.Add("PNNOPRCN", 0, ParameterDirection.Output)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_CABECERA_INSERT", objParam)
        PNNOPRCN = lobjSql.ParameterCollection("PNNOPRCN")
        Return PNNOPRCN
    End Function

    Public Function Actualizar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        objParam.Add("PNCCLNFC", oServicioSIL.PNCCLNFC)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_CABECERA_ACTUALIZAR", objParam)
        retorno = 1
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Embarques(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        objParam.Add("PNNORSCI", oServicioSIL.PNNORSCI)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_EMBARQUES_INSERTAR", objParam)
        retorno = 1
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Servicios(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        objParam.Add("PNNCRROP", oServicioSIL.PNNCRROP)
        objParam.Add("PNNRTFSV", oServicioSIL.PNNRTFSV)
        objParam.Add("PNQATNAN", oServicioSIL.PNQATNAN)
        objParam.Add("PSCCMPN", oServicioSIL.PSCCMPN)
        objParam.Add("PSCDVSN", oServicioSIL.PSCDVSN)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_SERVICIOS_INSERT", objParam)
        retorno = 1
        Return retorno
    End Function


    Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        lobjParams.Add("PNNCRROP", oServicioSIL.PNNCRROP)
        lobjParams.Add("PNNRTFSV", oServicioSIL.PNNRTFSV)
        lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_ITEM_SERVICIO", lobjParams)
        retorno = 1
        Return retorno
    End Function


    Public Function Existe_Embarque_En_Operacion(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCTPALJ As String) As DataTable
        Dim odt As New DataTable
        Dim PNNOPRCN As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCTPALJ", PSCTPALJ)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_VERIFICA_EXISTENCIA_EMBARQUE_EN_OPERACION", lobjParams)
        Return odt
    End Function

    Public Function Eliminar_Operacion_Facturacion(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNOPRCN", oServicioSIL.PNNOPRCN)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_QUITAR_SERVICIO_SIL_RZSC19", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function fdtListaDirServicxDefecto(ByVal PSCCMPN As String, _
                                               ByVal PSCDVSN As String, _
                                               ByVal PNCCLNTOP As Decimal, _
                                               ByVal PNCCLNTFC As Decimal, _
                                               ByVal PNCPLNDVOP As Decimal, _
                                               ByVal PNCPLNDVFC As Decimal) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Try
            lobjParams.Add("PSCCMPN", PSCCMPN)
            lobjParams.Add("PSCDVSN", PSCDVSN)
            lobjParams.Add("PNCCLNTOP", PNCCLNTOP)
            lobjParams.Add("PNCCLNTFC", PNCCLNTFC)
            lobjParams.Add("PNCPLNDVOP", PNCPLNDVOP)
            lobjParams.Add("PNCPLNDVFC", PNCPLNDVFC)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DIRECCION_SERVICIO_X_DEFECTO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New DataTable
        End Try
        Return dt
    End Function
End Class
