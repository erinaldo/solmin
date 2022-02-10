Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class cYrcRnsIntegration
#Region " Tipos de Datos "

#End Region
#Region " Tipos de Datos "

#End Region
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Obtiene la información de RANSA de los Items de la Orden de Compra del Cliente
    ''' </summary>
    Public Shared Function fdtYRC_GetItemsOC_Q01(ByVal objSqlManager As SqlManager, ByVal Cliente As Int64, ByVal OrdenCompra As String, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        With objParametros
            .Add("IN_CCLNT", Cliente)
            .Add("IN_NORCML", OrdenCompra)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_ITEMS_X_OC_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetItemsOC_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_ITEMS_X_OC_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de los Items de la Orden de Compra del Cliente a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetItemsOC_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                 ByVal Cliente As Int64, ByVal OrdenCompra As String, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetItemsOC_Q01(objSqlManager, Cliente, OrdenCompra, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de los Maestros de Checkpoint para actualizar la tabla M004 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetM004_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_M004_CHECKPOINT_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetM004_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_M004_CHECKPOINT_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de los Maestros de Checkpoint para actualizar la tabla M004 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetM004_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetM004_WithInfRNSA_Q01(objSqlManager, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de los Items de la O/C para actualizar la tabla T002 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetT002_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByVal sTipoAlmacenaje As String, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
            .Add("IN_STREGI", sTipoAlmacenaje)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_T002_CAMBIAR_STATUS_OC", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT002_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_T002_CAMBIAR_STATUS_OC >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de los Items de la O/C para actualizar la tabla T002 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetT002_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByVal sTipoAlmacenaje As String, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetT002_WithInfRNSA_Q01(objSqlManager, OrdenServicio, sTipoAlmacenaje, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA del Embarque para actualizar la tabla T005 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetT005_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_EMBARQUE_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT005_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_EMBARQUE_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA del Embarque para actualizar la tabla T005 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetT005_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetT005_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Costo por Item de una Orden Compra perteneciente a una embarque para actualizar la tabla T006 de YRC
    ''' </summary>
    Public Shared Function fdstYRC_GetT006_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                           ByRef strMensajeError As String) As DataSet
        Dim dstTemp As DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dstTemp = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_YRC_T006_SUSTENTO_COSTO", objParametros)
        Catch ex As Exception
            dstTemp = New DataSet
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT006_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_T006_SUSTENTO_COSTO >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dstTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Costo por Item de una Orden Compra perteneciente a una embarque para actualizar la tabla T006 de YRC 
    ''' a través del Web Services
    ''' </summary>
    Public Shared Function fdstYRC_GetT006_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                           ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataSet
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstTemp As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dstTemp = fdstYRC_GetT006_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dstTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Item de la Orden Compra para actualizar la tabla T007 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetT007_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_ITEM_OC_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT007_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_ITEM_OC_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Item de la Orden de Compra para actualizar la tabla T007 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetT007_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetT007_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de CheckPoint para actualizar la tabla T008 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetT008_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_CHECKPOINT_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT008_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_CHECKPOINT_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de CheckPoint para actualizar la tabla T008 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetT008_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetT008_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Sustentos y Sustentos del Embarque para actualizar la tabla T011 y T012 de YRC
    ''' </summary>
    Public Shared Function fdstYRC_GetT012_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByRef strMensajeError As String) As DataSet
        Dim dstTemp As DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dstTemp = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_YRC_EMBARQUE_SUSTENTO_Q01", objParametros)
        Catch ex As Exception
            dstTemp = New DataSet
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT012_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_EMBARQUE_SUSTENTO_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dstTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de Sustentos y Sustentos del Embarque para actualizar la tabla T011 y T012 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdstYRC_GetT012_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataSet
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstTemp As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dstTemp = fdstYRC_GetT012_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dstTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de la Bitácora para actualizar la tabla T013 de YRC
    ''' </summary>
    Public Shared Function fdtYRC_GetT013_WithInfRNSA_Q01(ByVal objSqlManager As SqlManager, ByVal OrdenServicio As Int64, _
                                                          ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NORSCI", OrdenServicio)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_YRC_BITACORA_Q01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtYRC_GetT013_WithInfRNSA_Q01 >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_YRC_BITACORA_Q01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Obtiene la información de RANSA de la Bitácora para actualizar la tabla T013 de YRC a través del Web Services
    ''' </summary>
    Public Shared Function fdtYRC_GetT013_WithInfRNSA_Q01(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                                          ByVal OrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dtTemp As DataTable = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        dtTemp = fdtYRC_GetT013_WithInfRNSA_Q01(objSqlManager, OrdenServicio, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
        Return dtTemp
    End Function

    Public Shared Sub PruebaCall(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                ByRef strMensajeError As String)
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        'With objParametros
        '    .Add("IN_NORSCI", OrdenServicio)
        'End With
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNoQuery("CALL RZA534CLD PARM('0000402599' 'C' '1')", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << PruebaCall >> de la clase << cYrcRnsIntegration >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : RZA534CLD >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Sub
#End Region
End Class