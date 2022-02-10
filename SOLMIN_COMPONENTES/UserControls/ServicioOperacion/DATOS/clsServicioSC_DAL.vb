Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsServicioSC_DAL
    'Public Function Lista_Servicios_X_Operacion_Embarque(ByVal oServicioSIL As Servicio_BE) As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
    '    lobjParams.Add("PNNORSCI", oServicioSIL.NORSCI)
    '    lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
    '    dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_SERVICIOS_ALL_SERVICIO_EMBARQUE", lobjParams)
    '    Return dt
    'End Function




    Public Function Eliminar_Item_Embarque_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNNORSCI", oServicioSIL.NORSCI)
            lobjParams.Add("PNNRITEM", oServicioSIL.NRITEM)
            lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_ITEM_EMBARQUE_SERVICIOS", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
 
    End Function

    'Public Function Lista_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
    '    lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
    '    lobjParams.Add("PNNORSCI", oServicioSIL.PNNORSCI)
    '    lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_LISTA_ITEM_DETALLE_SERVICIOS", lobjParams)
    '    retorno = 1
    '    Return retorno
    'End Function

    'Public Function Insertar_Servicio_Facturacion_SC(ByVal oServicios As Servicio_BE) As Decimal
    '    Dim retorno As Decimal = -1
    '    Dim lobjSql As New SqlManager
    '    Dim objParam As New Parameter
    '    objParam.Add("PNCCLNT", oServicios.CCLNT)
    '    objParam.Add("PNFOPRCN", oServicios.FOPRCN)
    '    objParam.Add("PNCCLNFC", oServicios.CCLNFC)
    '    objParam.Add("PNNRTFSV", oServicios.NRTFSV)
    '    objParam.Add("PSCCMPN", oServicios.CCMPN)
    '    objParam.Add("PSCDVSN", oServicios.CDVSN)
    '    objParam.Add("PNQATNAN", oServicios.QATNAN)
    '    objParam.Add("PSTOBS", oServicios.TOBS)
    '    objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
    '    objParam.Add("PNNOPRCN", 0, ParameterDirection.Output)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_INSERT", objParam)
    '    retorno = lobjSql.ParameterCollection("PNNOPRCN")
    '    Return retorno

    'End Function

    'Public Function Actualizar_Servicio_Facturacion_SC(ByVal oServicios As Servicio_BE) As Decimal
    '    Dim retorno As Decimal = 0
    '    Dim lobjSql As New SqlManager
    '    Dim objParam As New Parameter
    '    objParam.Add("PNCCLNT", oServicios.CCLNT)
    '    objParam.Add("PNNOPRCN", oServicios.NOPRCN)
    '    objParam.Add("PNFOPRCN", oServicios.FOPRCN)
    '    objParam.Add("PNCCLNFC", oServicios.CCLNFC)
    '    objParam.Add("PNNRTFSV", oServicios.NRTFSV)
    '    objParam.Add("PSCCMPN", oServicios.CCMPN)
    '    objParam.Add("PSCDVSN", oServicios.CDVSN)
    '    objParam.Add("PNQATNAN", oServicios.QATNAN)
    '    objParam.Add("PSTOBS", oServicios.TOBS)
    '    objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_UPDATE", objParam)
    '    retorno = 1
    '    Return retorno
    'End Function


    'Public Function Insertar_Detalle_Servicio_Facturacion_SC(ByVal oServicios As Servicio_BE) As Int32
    '    Dim retorno As Decimal = 0
    '    Dim lobjSql As New SqlManager
    '    Dim objParam As New Parameter
    '    objParam.Add("PNCCLNT", oServicios.CCLNT)
    '    objParam.Add("PNNOPRCN", oServicios.NOPRCN)
    '    objParam.Add("PNNORSCI", oServicios.NORSCI)
    '    objParam.Add("PSCUSCRT", oServicios.PSUSUARIO)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_DETALLE_FACTURAR_INSERT", objParam)
    '    retorno = 1
    '    Return retorno
    'End Function

    '******************************DE PROYECTO SIL**************************
    'Public Function Lista_Servicios_X_Operacion_Embarque(ByVal oServicioSIL As Servicio_BE) As DataTable
    '    Dim dt As New DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
    '    lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
    '    dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_SERVICIOS_SERVICIO_OPERACION", lobjParams)
    '    Return dt
    'End Function
    Public Function Lista_Servicios_Operacion(ByVal oServicioSIL As Servicio_BE) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        lobjParams.Add("PNNORSCI", oServicioSIL.NORSCI)
        lobjParams.Add("PSBUSQUEDA", oServicioSIL.PSBUSQUEDA)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_SERVICIOS_SERVICIO_OPERACION", lobjParams)
        Return dt
    End Function

    Public Function Insertar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim PNNOPRCN As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", oServicioSIL.CCLNT)
        objParam.Add("PNCCLNFC", oServicioSIL.CCLNFC)
        objParam.Add("PSCCMPN", oServicioSIL.CCMPN)
        objParam.Add("PSCDVSN", oServicioSIL.CDVSN)
        objParam.Add("PNFOPRCN", oServicioSIL.FOPRCN)
        objParam.Add("PSCTPALJ", oServicioSIL.CTPALJ)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        objParam.Add("PNNOPRCN", 0, ParameterDirection.Output)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_CABECERA_INSERT", objParam)
        PNNOPRCN = lobjSql.ParameterCollection("PNNOPRCN")
        Return PNNOPRCN
    End Function

    Public Function Actualizar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.CCLNT)
        objParam.Add("PNCCLNFC", oServicioSIL.CCLNFC)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_CABECERA_ACTUALIZAR", objParam)
        retorno = 1
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Embarques(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.CCLNT)
        objParam.Add("PNNORSCI", oServicioSIL.NORSCI)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        objParam.Add("PNNCRROP", oServicioSIL.NCRROP)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_EMBARQUES_INSERTAR", objParam)
        Return 1
        'Catch ex As Exception
        '    Return -1
        'End Try

    End Function

    Public Function Insertar_Servicio_Facturar_Servicios(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        objParam.Add("PNCCLNT", oServicioSIL.CCLNT)
        objParam.Add("PNNCRROP", oServicioSIL.NCRROP)
        objParam.Add("PNNRTFSV", oServicioSIL.NRTFSV)
        objParam.Add("PNQATNAN", oServicioSIL.QATNAN)
        objParam.Add("PSCCMPN", oServicioSIL.CCMPN)
        objParam.Add("PSCDVSN", oServicioSIL.CDVSN)
        objParam.Add("PSUSUARIO", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_SERVICIOS_FACTURAR_SERVICIOS_INSERT", objParam)
        retorno = 1
        Return retorno
    End Function


    Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        lobjParams.Add("PNNCRROP", oServicioSIL.NCRROP)
        lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)
        lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_ITEM_SERVICIO", lobjParams)
        retorno = 1
        Return retorno
    End Function

    '**********************************************************************************

    Public Function Lista_Detalle_Servicios_SC(ByVal oServicios As Servicio_BE) As DataTable
        Dim odt As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", oServicios.CCLNT)
        objParam.Add("PNNOPRCN", oServicios.NOPRCN)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTA_DETALLE_SERVICIOS_RZSC21", objParam)
        Return odt
    End Function

    Public Function Lista_OC_X_Embarque_OS(ByVal oServicios As Servicio_BE) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeListServicio As New List(Of Servicio_BE)
        lobjParams.Add("PNCCLNT", oServicios.CCLNT)
        lobjParams.Add("PNNORSCI", oServicios.NORSCI)
        lobjParams.Add("PNPNNMOS", oServicios.PNNMOS)
        lobjParams.Add("PSBUSQUEDA", oServicios.PSBUSQUEDA)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTA_OC_X_EMBARQUE_OS", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_Tarifa(ByVal PNNRTFSV As Decimal) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeListServicio As New List(Of Servicio_BE)
        lobjParams.Add("PNNRTFSV", PNNRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_TARIFA", lobjParams)
        Return dt
    End Function

    'Public Function Eliminar_Operacion_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
    '    lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
    '    lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_SERVICIO_OPERACION", lobjParams)
    '    retorno = 1
    '    Return retorno
    'End Function


    Public Function Lista_Detalle_OC_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_OC_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function ValidaIngresoEmbarqueAOperacion(ByVal oSerAlmacen As Servicio_BE) As String
        Dim dt As New DataTable
        Dim mensaje As String = ""
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", oSerAlmacen.NORSCI)
        lobjParams.Add("PNCCLNT", oSerAlmacen.CCLNT)
        lobjParams.Add("PNPNNMOS", oSerAlmacen.PNNMOS)
        lobjParams.Add("PSTIPO", oSerAlmacen.PSBUSQUEDA)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_VALIDA_INGRESO_EMBARQUE_A_OPERACION", lobjParams)
        If (dt.Rows.Count > 0) Then
            mensaje = dt.Rows(0)("MSGIMP").ToString.Trim
        End If
        Return mensaje
    End Function

    Public Function Obtener_Datos_Operacion(ByVal PNCCLNT As Decimal, ByVal PNNOPRCN As Decimal) As DataTable
        Dim odt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNOPRCN", PNNOPRCN)
        odt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SC_OBTENER_DATOS_OPERACION", lobjParams)
        Return odt
    End Function

    'Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
    '    lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
    '    lobjParams.Add("PNNCRROP", oServicioSIL.NCRROP)
    '    lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)
    '    lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
    '    lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_ITEM_SERVICIO", lobjParams)
    '    retorno = 1
    '    Return retorno
    'End Function

End Class
