Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Servicios

Public Class cServicios
    Implements IDisposable
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private oSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property ErrorMessage() As String
        Get
            Return sErrorMessage
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New()
        oSqlManager = New SqlManager
    End Sub

    ''' <summary>
    ''' Listado de Servicios Disponibles en Formato L01 para ser utilizadas en el DataGrid o ComboBox
    ''' </summary>
    Public Function fdtListar_ServiciosDisponibles_L01(ByVal TD_Filtro As TD_Qry_Servicio_Disponible_L01) As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("PSCDVSN", TD_Filtro.pCDVSN_Division)
            .Add("PNCPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("PNFECSER", TD_Filtro.pFOPRCN_FechaOperacion_FNum)
        End With

        Dim dtTemp As DataTable = New DataTable
        dtTemp.Columns.Add(New DataColumn("CODIGO", GetType(System.Int64)))
        dtTemp.Columns.Add(New DataColumn("DETALLE", GetType(System.String)))
        dtTemp.Columns.Add(New DataColumn("UNIDAD", GetType(System.String)))
        dtTemp.Columns.Add(New DataColumn("QTBASE", GetType(System.Decimal)))
        Try
            Dim dtTemp2 As DataTable = oSqlManager.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_SERVICIO_X_DIVISION", objParametros)
            sErrorMessage = ""
            ' Recorremos el resultado 
            Dim rwTemp As DataRow
            Dim intCont As Integer
            ' Variables Temporales
            Dim intCodigoServicio As Int64 = 0
            Dim decQtaBase As Decimal = 0.0
            Dim strDetalleServicio As String = ""
            ' Recorremos la Tabla
            For intCont = 0 To dtTemp2.Rows.Count - 1
                rwTemp = dtTemp.NewRow
                Int64.TryParse("" & dtTemp2.Rows(intCont).Item("NRTFSV"), intCodigoServicio)
                rwTemp.Item("CODIGO") = intCodigoServicio
                rwTemp.Item("UNIDAD") = ("" & dtTemp2.Rows(intCont).Item("CUNDMD")).ToString.Trim
                Decimal.TryParse("" & dtTemp2.Rows(intCont).Item("VALCTE"), decQtaBase)
                rwTemp.Item("QTBASE") = decQtaBase
                rwTemp.Item("DETALLE") = dtTemp2.Rows(intCont).Item("DESTAR").ToString.Trim
                dtTemp.Rows.Add(rwTemp)
            Next intCont
        Catch ex As Exception
            dtTemp = New DataTable
            sErrorMessage = "Error producido en la funcion : << fdtListar_ServiciosDisponibles_L01 >> de la clase << daoServicio >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLCT_LISTA_TARIFA_SERVICIO_X_DIVISION >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Servicios Disponibles en Formato L01 para ser utilizadas en el DataGrid o ComboBox
    ''' </summary>
    Public Shared Function fdtListar_ServiciosDisponibles_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_Servicio_Disponible_L01, _
                                                              ByRef strMensajeError As String) As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("PSCDVSN", TD_Filtro.pCDVSN_Division)
            .Add("PNCPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("PNFECSER", TD_Filtro.pFOPRCN_FechaOperacion_FNum)
        End With

        Dim dtTemp As DataTable = New DataTable
        dtTemp.Columns.Add(New DataColumn("CODIGO", GetType(System.Int64)))
        dtTemp.Columns.Add(New DataColumn("DETALLE", GetType(System.String)))
        dtTemp.Columns.Add(New DataColumn("UNIDAD", GetType(System.String)))
        dtTemp.Columns.Add(New DataColumn("QTBASE", GetType(System.Decimal)))
        Try
            Dim dtTemp2 As DataTable = objSqlManager.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_SERVICIO_X_DIVISION", objParametros)
            strMensajeError = ""
            ' Recorremos el resultado 
            Dim rwTemp As DataRow
            Dim intCont As Integer
            ' Variables Temporales
            Dim intCodigoServicio As Int64 = 0
            Dim decQtaBase As Decimal = 0.0
            Dim strDetalleServicio As String = ""
            ' Recorremos la Tabla
            For intCont = 0 To dtTemp2.Rows.Count - 1
                rwTemp = dtTemp.NewRow
                Int64.TryParse("" & dtTemp2.Rows(intCont).Item("NRTFSV"), intCodigoServicio)
                rwTemp.Item("CODIGO") = intCodigoServicio
                rwTemp.Item("UNIDAD") = ("" & dtTemp2.Rows(intCont).Item("CUNDMD")).ToString.Trim
                Decimal.TryParse("" & dtTemp2.Rows(intCont).Item("VALCTE"), decQtaBase)
                rwTemp.Item("QTBASE") = decQtaBase
                rwTemp.Item("DETALLE") = dtTemp2.Rows(intCont).Item("DESTAR").ToString.Trim
                dtTemp.Rows.Add(rwTemp)
            Next intCont
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_ServiciosDisponibles_L01 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLCT_LISTA_TARIFA_SERVICIO_X_DIVISION >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Servicios en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Shared Function fdtListar_Servicios_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_Servicios_Adquiridos_L01, _
                                                   ByRef intNroTotalPaginas As Int32, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
            .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoSistAlm)
            .Add("IN_CSRVNV", TD_Filtro.pCSRVNV_Servicio)
            .Add("IN_FECINI", TD_Filtro.pFOPRCN_FechaOperacion_Ini_FNum)
            .Add("IN_FECFIN", TD_Filtro.pFOPRCN_FechaOperacion_Fin_FNum)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_RZSC30_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            strMensajeError = "Error producido en la funcion : << fdtListar_Servicios_L01 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Servicios en Formato L02 para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtListar_Servicios_L02(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_ServicioPK, _
                                                   ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_RZSC30_L02", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_Servicios_L02 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_L02 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Función para agregar un Servicio Disponible a la relación de Servicios Adquiridos por el Cliente
    ''' </summary>
    Public Shared Function AgregarServicioAdquirido(ByVal objSqlManager As SqlManager, ByVal Servicio As TD_Servicio_Adquirido, ByVal strUsuario As String, _
                                                    ByRef NroOperacion As Int64, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim dtTemp As DataTable = Nothing
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", Servicio.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", Servicio.pNOPRCN_Operacion)
            .Add("IN_NRTFSV", Servicio.pNRTFSV_Tarifa_Servicio)
            .Add("IN_FOPRCN", Servicio.pFOPRCN_FechaOperacion_FNum)
            .Add("IN_FECINI", Servicio.pFECINI_Inicio_FNum)
            .Add("IN_FECFIN", Servicio.pFECFIN_Final_FNum)
            .Add("IN_CCMPN", Servicio.pCCMPN_Compania)
            .Add("IN_CDVSN", Servicio.pCDVSN_Division)
            .Add("IN_CPLNDV", Servicio.pCPLNDV_Planta)
            .Add("IN_QCNESP", Servicio.pQCNESP_Cantidad_Base)
            .Add("IN_TUNDIT", Servicio.pTUNDIT_Unidad)
            .Add("IN_STPODP", Servicio.pSTPODP_TipoSistAlm)
            .Add("IN_STIPPR", Servicio.pSTIPPR_Proceso)
            .Add("IN_CCLNFC", Servicio.pCCLNFC_ClienteFacturar)
            .Add("IN_QATNAN", Servicio.pQATNAN_CantAtendida)
            .Add("IN_CPRCN1", Servicio.pCPRCN1_Contenedor)
            .Add("IN_NSRCN1", Servicio.pNSRCN1_SerieContenedor)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_NOPRCN", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_RZSC30_INS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            NroOperacion = htResultado("OU_NOPRCN")
        Catch ex As Exception
            blnResultado = False
            NroOperacion = 0
            strMensajeError = "Error producido en la funcion : << AgregarServicioAdquirido >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Función para agregar detalle al Servicio Adquirido por el Cliente
    ''' </summary>
    Public Shared Function AgregarDetalleServicio(ByVal objSqlManager As SqlManager, ByVal DetalleServicio As TD_Servicio_Detalle_I01, ByVal strUsuario As String, _
                                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", DetalleServicio.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", DetalleServicio.pNOPRCN_Operacion)
            .Add("IN_STPODP", DetalleServicio.pSTPODP_TipoSistAlm)
            .Add("IN_CREFFW", DetalleServicio.pCREFFW_CodigoBulto)
            .Add("IN_NROPLT", DetalleServicio.pNROPLT_NroPaletizado)
            .Add("IN_NROCTL", DetalleServicio.pNROCTL_NroPreDespacho)
            .Add("IN_NRGUSA", DetalleServicio.pNRGUSA_NroGuiaSalida)
            .Add("IN_NGUIRM", DetalleServicio.pNGUIRM_NroGuiaRemision)
            .Add("IN_NORDSR", DetalleServicio.pNORDSR_OrdenServicio)
            .Add("IN_NSLCSR", DetalleServicio.pNSLCSR_NroSolicitud)
            .Add("IN_NGUIRN", DetalleServicio.pNGUIRN_NroGuiaRansa)
            .Add("IN_USUARI", strUsuario)
            .Add("IN_CCMPN", DetalleServicio.pCCMPN_Compania)
            .Add("IN_CDVSN", DetalleServicio.pCDVSN_Division)
            .Add("IN_CPLNDV", DetalleServicio.pCPLNDV_Planta)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            strMensajeError = strMensajeError.Replace("%", vbNewLine)
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << AgregarDetalleServicio >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Función para eliminar detalle al Servicio Adquirido por el Cliente
    ''' </summary>
    Public Shared Function EliminarDetalleServicio(ByVal objSqlManager As SqlManager, ByVal DetalleServicio As TD_Servicio_Detalle_E01, ByVal strUsuario As String, _
                                                   ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", DetalleServicio.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", DetalleServicio.pNOPRCN_Operacion)
            .Add("IN_STPODP", DetalleServicio.pSTPODP_TipoSistAlm)
            .Add("IN_CREFFW", DetalleServicio.pCREFFW_CodigoBulto)
            .Add("IN_NORDSR", DetalleServicio.pNORDSR_OrdenServicio)
            .Add("IN_NSLCSR", DetalleServicio.pNSLCSR_NroSolicitud)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << EliminarDetalleServicio >> de la clase << cServicios >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Función para Actualizar la información de los Servicio Adquiridos por el Cliente
    ''' </summary>
    Public Shared Function EditarServicioAdquirido(ByVal objSqlManager As SqlManager, ByVal ServAdquInfGen As TD_Servicio_Adquirido_InfGen, ByVal strUsuario As String, _
                                                   ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim dtTemp As DataTable = Nothing
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", ServAdquInfGen.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", ServAdquInfGen.pNOPRCN_Operacion)
            .Add("IN_STIPPR", ServAdquInfGen.pSTIPPR_Proceso)
            .Add("IN_CCLNFC", ServAdquInfGen.pCCLNFC_ClienteFacturar)
            .Add("IN_FECINI", ServAdquInfGen.pFECINI_Inicio_FNum)
            .Add("IN_FECFIN", ServAdquInfGen.pFECFIN_Final_FNum)
            .Add("IN_CPRCN1", ServAdquInfGen.pCPRCN1_Contenedor)
            .Add("IN_NSRCN1", ServAdquInfGen.pNSRCN1_SerieContenedor)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << EditarServicioAdquirido >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Función para eliminar un Servicio Adquirido por el Cliente
    ''' </summary>
    Public Shared Function EliminarServicioAdquirido(ByVal objSqlManager As SqlManager, ByVal Servicio As TD_Servicio_AdquiridoPK, ByVal strUsuario As String, _
                                                     ByRef strBorrarTodo As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim dtTemp As DataTable = Nothing
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", Servicio.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", Servicio.pNOPRCN_Operacion)
            .Add("IN_NRTFSV", Servicio.pNRTFSV_Tarifa_Servicio)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_DELALL", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_RZSC30_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            strBorrarTodo = htResultado("OU_DELALL")
        Catch ex As Exception
            blnResultado = False
            strBorrarTodo = "N"
            strMensajeError = "Error producido en la funcion : << EliminarServicioAdquirido >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Listado de Bultos en Formato L01 asociados a una operación de Servicio para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtServicios_Detalle_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_OperacionPK, _
                                                    ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtServicios_Bultos_L01 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Bultos en Formato L02 para poder ser asociados a una operación para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtServicios_Detalle_L02(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_Servicio_Bulto_F01, _
                                                   ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto)
            .Add("IN_NROPLT", TD_Filtro.pNROPLT_NroPaletizado)
            .Add("IN_NROCTL", TD_Filtro.pNROCTL_NroPreDespacho)
            .Add("IN_NRGUSA", TD_Filtro.pNRGUSA_NroGuiaSalida)
            .Add("IN_NGUIRM", TD_Filtro.pNGUIRM_NroGuiaRemision)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            strMensajeError = strMensajeError.Replace("%", vbNewLine)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtServicios_Detalle_L02 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Mercaderías en Formato L03 asociados a una operación de Servicio para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtServicios_Detalle_L03(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_OperacionPK, _
                                                       ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L03", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtServicios_Detalle_L03 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L03 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Mercadería en Formato L04 para poder ser asociados a una operación para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtServicios_Detalle_L04(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_Servicio_Mercaderia_F01, _
                                                    ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NOPRCN", TD_Filtro.pNOPRCN_Operacion)
            .Add("IN_NORDSR", TD_Filtro.pNORDSR_OrdenServicio)
            .Add("IN_NSLCSR", TD_Filtro.pNSLCSR_NroSolicitud)
            .Add("IN_NGUIRN", TD_Filtro.pNGUIRN_NroGuiaRansa)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L04", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            strMensajeError = strMensajeError.Replace("%", vbNewLine)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtServicios_Detalle_L04 >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L04 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                oSqlManager.Dispose()
                oSqlManager = Nothing
            End If
            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class