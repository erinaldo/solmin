Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.Proveedor

Public Class cProveedor
    'Inherits daBase(Of TypeDef.Proveedor.beProveedor)
    Inherits daBase(Of Proveedor.beProveedor)

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
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Proveedor
    ''' </summary>
    Public Function Grabar(ByVal Usuario As String, ByVal oProveedor As TD_Obj_Proveedor_F01, ByRef intNewCodeProv As Int64, _
                           ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim sNameProcedure As String = ""
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", oProveedor.pCPRVCL_Proveedor)
            .Add("IN_TPRVCL", oProveedor.pTPRVCL_DescripcionProveedor)
            .Add("IN_TPRCL1", oProveedor.pTPRCL1_DescripcionAdicional)
            .Add("IN_NRUCPR", oProveedor.pNRUCPR_NroRUC)
            .Add("IN_TNACPR", oProveedor.pTNACPR_ProvinciaDistrito)
            .Add("IN_TDRPRC", oProveedor.pTDRPRC_DireccionProveedor)
            .Add("IN_CPAIS", oProveedor.pCPAIS_Pais)
            .Add("IN_TNROFX", oProveedor.pTNROFX_NroFAX)
            .Add("IN_TLFNO1", oProveedor.pTLFNO1_TelefonoProveedor)
            .Add("IN_TEMAI2", oProveedor.pTEMAI2_EmailProveedor)
            .Add("IN_TPRSCN", oProveedor.pTPRSCN_ContactoProveedor)
            .Add("IN_TLFNO2", oProveedor.pTLFNO2_TelefonoContacto)
            .Add("IN_TEMAI3", oProveedor.pTEMAI3_EmailContacto)
            .Add("IN_NDSDMP", oProveedor.pNDSDMP_NroDiasDemoraPago)
            .Add("IN_USUARI", Usuario)
            .Add("OU_CPRVCL", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            If oProveedor.pCPRVCL_Proveedor = 0 Then
                sNameProcedure = "SP_SOLMIN_PROVEEDOR_RZOL05_INS"
            Else
                sNameProcedure = "SP_SOLMIN_PROVEEDOR_RZOL05_UPD"
            End If
            oSqlManager.ExecuteNonQuery(sNameProcedure, objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            Int32.TryParse("" & htResultado("OU_CPRVCL"), intNewCodeProv)
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << cProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : " & sNameProcedure & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
            intNewCodeProv = 0
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Obtener el Objeto Proveedor
    ''' </summary>
    Public Function Obtener(ByVal Proveedor As Int64, ByRef strMensajeError As String) As TD_Obj_Proveedor_F01
        Dim oParametros As Parameter = New Parameter
        Dim oProveedor As TD_Obj_Proveedor_F01 = New TD_Obj_Proveedor_F01
        ' Ingresamos los parametros del Procedure
        With oParametros
            .Add("IN_CPRVCL", Proveedor)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            ' Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_OBJ", oParametros)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_OBJ_AJUSTE", oParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            strMensajeError = ("" & htResultado("OU_MSGERR")).ToString.Trim
            If strMensajeError = "" Then
                With oProveedor
                    .pCPRVCL_Proveedor = dtTemp.Rows(0).Item("CPRVCL")
                    .pTPRVCL_DescripcionProveedor = ("" & dtTemp.Rows(0).Item("TPRVCL")).ToString.Trim
                    .pTPRCL1_DescripcionAdicional = ("" & dtTemp.Rows(0).Item("TPRCL1")).ToString.Trim
                    .pNRUCPR_NroRUC = dtTemp.Rows(0).Item("NRUCPR")
                    .pTNACPR_ProvinciaDistrito = "" & dtTemp.Rows(0).Item("TNACPR")
                    .pTDRPRC_DireccionProveedor = ("" & dtTemp.Rows(0).Item("TDRPRC")).ToString.Trim
                    .pCPAIS_Pais = dtTemp.Rows(0).Item("CPAIS")
                    .pTNROFX_NroFAX = "" & dtTemp.Rows(0).Item("TNROFX")
                    .pTLFNO1_TelefonoProveedor = "" & dtTemp.Rows(0).Item("TLFNO1")
                    .pTEMAI2_EmailProveedor = ("" & dtTemp.Rows(0).Item("TEMAI2")).ToString.Trim
                    .pTPRSCN_ContactoProveedor = ("" & dtTemp.Rows(0).Item("TPRSCN")).ToString.Trim
                    .pTLFNO2_TelefonoContacto = "" & dtTemp.Rows(0).Item("TLFNO2")
                    .pTEMAI3_EmailContacto = "" & dtTemp.Rows(0).Item("TEMAI3")
                    .pNDSDMP_NroDiasDemoraPago = "" & dtTemp.Rows(0).Item("NDSDMP")
                    .pSESTRG_Situacion = "" & dtTemp.Rows(0).Item("SESTRG")
                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << cProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oProveedor
    End Function

    ''' <summary>
    ''' Listado de los Proveedores registrados en el Sistema SOLMIN SAT - RZOL05
    ''' </summary>
    Public Function ListarSAT(ByVal oQry_Proveedor_F02 As TD_Qry_LstProveedor_F02) As DataTable
        Dim dtTemp As DataTable
        Dim oParametros As Parameter = New Parameter
        With oParametros
            .Add("IN_CPRVCL", oQry_Proveedor_F02.pCPRVCL_Proveedor)
            .Add("IN_TPRVCL", oQry_Proveedor_F02.pTPRVCL_DescripcionProveedor)
            .Add("IN_NRUCPR", oQry_Proveedor_F02.pNRUCPR_NroRUC)
        End With
        Try
            sErrorMessage = ""
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_L02", oParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cProveedor >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_L02 >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function





    'Public Shared Function Exists(ByVal objSqlManager As SqlManager, ByVal TD_Exist As TD_InfBas_Proveedor, ByRef intCodigoExistente As Int32, ByRef strMensajeError As String) As Boolean
    '    Dim objParametros As Parameter = New Parameter
    '    Dim blnResultado As Boolean = True
    '    ' Ingresamos los parametros del Procedure
    '    With objParametros
    '        .Add("IN_CPRVCL", TD_Exist.pCPRVCL_Proveedor)
    '        .Add("IN_NRUCPR", TD_Exist.pNRUCPR_NroRUC)
    '        .Add("OU_CPRVCL", "", ParameterDirection.Output)
    '    End With
    '    Try
    '        strMensajeError = ""
    '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_PROVEEDOR_RZOL05_EXS", objParametros)
    '        Dim htResultado As Hashtable
    '        htResultado = objSqlManager.ParameterCollection
    '        Int32.TryParse(htResultado("OU_CPRVCL"), intCodigoExistente)
    '        If intCodigoExistente = 0 Then blnResultado = False
    '    Catch ex As Exception
    '        strMensajeError = "Error producido en la funcion : << Exists >> de la clase << daoProveedor >> " & vbNewLine & _
    '                          "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_EXS >> " & vbNewLine & _
    '                          "Motivo del Error : " & ex.Message
    '        blnResultado = False
    '        intCodigoExistente = 0
    '    Finally
    '        objSqlManager = Nothing
    '        objParametros = Nothing
    '    End Try
    '    Return blnResultado
    'End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Proveedor
    ''' </summary>
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal Usuario As String, ByVal oProveedor As TD_Proveedor, _
                                  ByRef intCodigoAsigNuevoProveedor As Int32, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", oProveedor.pCPRVCL_Proveedor)
            .Add("IN_TPRVCL", oProveedor.pTPRVCL_DescripcionProveedor)
            .Add("IN_TPRCL1", oProveedor.pTPRCL1_DescripcionAdicional)
            .Add("IN_NRUCPR", oProveedor.pNRUCPR_NroRUC)
            .Add("IN_TNACPR", oProveedor.pTNACPR_ProvinciaDistrito)
            .Add("IN_TDRPRC", oProveedor.pTDRPRC_DireccionProveedor)
            .Add("IN_CPAIS", oProveedor.pCPAIS_Pais)
            .Add("IN_TNROFX", oProveedor.pTNROFX_NroFAX)
            .Add("IN_TLFNO1", oProveedor.pTLFNO1_TelefonoProveedor)
            .Add("IN_TEMAI2", oProveedor.pTEMAI2_EmailProveedor)
            .Add("IN_TPRSCN", oProveedor.pTPRSCN_ContactoProveedor)
            .Add("IN_TLFNO2", oProveedor.pTLFNO2_TelefonoContacto)
            .Add("IN_TEMAI3", oProveedor.pTEMAI3_EmailContacto)
            .Add("IN_NDSDMP", oProveedor.pNDSDMP_NroDiasDemoraPago)
            .Add("IN_USUARI", Usuario)
            .Add("OU_CPRVCL", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_PROVEEDOR_RZOL05_INS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            Int32.TryParse(htResultado("OU_CPRVCL"), intCodigoAsigNuevoProveedor)
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
            intCodigoAsigNuevoProveedor = 0
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Proveedor a través del Web Services
    ''' </summary>
    Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                  ByVal oProveedor As TD_Proveedor, ByRef intCodigoAsigNuevoProveedor As Int32, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, strUsuario, oProveedor, intCodigoAsigNuevoProveedor, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal Proveedor As TD_ProveedorPK, ByVal Usuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", Proveedor.pCPRVCL_Proveedor)
            '-- Seguridad
            .Add("IN_USUARI", Usuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_PROVEEDOR_RZOL05_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    Public Shared Function Objeto(ByVal objSqlManager As SqlManager, ByVal pCPRVCL_Proveedor As Int32, ByRef strMensajeError As String) As TD_Proveedor
        Dim objParametros As Parameter = New Parameter
        Dim objProveedor As TD_Proveedor = New TD_Proveedor
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", pCPRVCL_Proveedor)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError = "" Then
                With objProveedor
                    .pCPRVCL_Proveedor = dtTemp.Rows(0).Item("CPRVCL")
                    .pTPRVCL_DescripcionProveedor = "" & dtTemp.Rows(0).Item("TPRVCL")
                    .pTPRCL1_DescripcionAdicional = "" & dtTemp.Rows(0).Item("TPRCL1")
                    .pNRUCPR_NroRUC = dtTemp.Rows(0).Item("NRUCPR")
                    .pTNACPR_ProvinciaDistrito = "" & dtTemp.Rows(0).Item("TNACPR")
                    .pTDRPRC_DireccionProveedor = "" & dtTemp.Rows(0).Item("TDRPRC")
                    .pCPAIS_Pais = dtTemp.Rows(0).Item("CPAIS")
                    '.pTCMPPS_DetallePais = "" & dtTemp.Rows(0).Item("TCMPPS")
                    .pTNROFX_NroFAX = "" & dtTemp.Rows(0).Item("TNROFX")
                    .pTLFNO1_TelefonoProveedor = "" & dtTemp.Rows(0).Item("TLFNO1")
                    .pTEMAI2_EmailProveedor = "" & dtTemp.Rows(0).Item("TEMAI2")
                    .pTPRSCN_ContactoProveedor = "" & dtTemp.Rows(0).Item("TPRSCN")
                    .pTLFNO2_TelefonoContacto = "" & dtTemp.Rows(0).Item("TLFNO2")
                    .pTEMAI3_EmailContacto = "" & dtTemp.Rows(0).Item("TEMAI3")
                    .pNDSDMP_NroDiasDemoraPago = "" & dtTemp.Rows(0).Item("NDSDMP")
                    '.pSESTRG_StatusRegistro = "" & dtTemp.Rows(0).Item("SESTRG")
                    '.pSITUAC_DetalleRegistro = "" & dtTemp.Rows(0).Item("SITUAC")
                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Objeto >> de la clase << daoProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objProveedor
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Obtener el Objeto Proveedor
    ''' </summary>
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal Codigo As Int32, ByRef strMensajeError As String) As TD_Proveedor
        Dim objParametros As Parameter = New Parameter
        Dim objProveedor As TD_Proveedor = New TD_Proveedor
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", Codigo)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError = "" Then
                With objProveedor
                    .pCPRVCL_Proveedor = dtTemp.Rows(0).Item("CPRVCL")
                    .pTPRVCL_DescripcionProveedor = ("" & dtTemp.Rows(0).Item("TPRVCL")).ToString.Trim
                    .pTPRCL1_DescripcionAdicional = ("" & dtTemp.Rows(0).Item("TPRCL1")).ToString.Trim
                    .pNRUCPR_NroRUC = dtTemp.Rows(0).Item("NRUCPR")
                    .pTNACPR_ProvinciaDistrito = ("" & dtTemp.Rows(0).Item("TNACPR")).ToString.Trim
                    .pTDRPRC_DireccionProveedor = ("" & dtTemp.Rows(0).Item("TDRPRC")).ToString.Trim
                    .pCPAIS_Pais = dtTemp.Rows(0).Item("CPAIS")
                    .pTNROFX_NroFAX = ("" & dtTemp.Rows(0).Item("TNROFX")).ToString.Trim
                    .pTLFNO1_TelefonoProveedor = ("" & dtTemp.Rows(0).Item("TLFNO1")).ToString.Trim
                    .pTEMAI2_EmailProveedor = ("" & dtTemp.Rows(0).Item("TEMAI2")).ToString.Trim
                    .pTPRSCN_ContactoProveedor = ("" & dtTemp.Rows(0).Item("TPRSCN")).ToString.Trim
                    .pTLFNO2_TelefonoContacto = ("" & dtTemp.Rows(0).Item("TLFNO2")).ToString.Trim
                    .pTEMAI3_EmailContacto = ("" & dtTemp.Rows(0).Item("TEMAI3")).ToString.Trim
                    .pNDSDMP_NroDiasDemoraPago = ("" & dtTemp.Rows(0).Item("NDSDMP")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objProveedor
    End Function

    ''' <summary>
    ''' Listado de Proveedores en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Shared Function fdtListar_Proveedor_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_ProveedorL01, _
                                                   ByRef intNroTotalPaginas As Int32, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
            .Add("IN_TPRVCL", TD_Filtro.pTPRVCL_DescripcionProveedor)
            .Add("IN_NRUCPR", TD_Filtro.pNRUCPR_NroRUC)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_PROVEEDOR_RZOL05_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            strMensajeError = "Error producido en la funcion : << fdtListar_Proveedor_L01 >> de la clase << daoProveedor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PROVEEDOR_RZOL05_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function



    Public Function floListaProveedoresPaginado(ByVal pbeProveedores As beProveedor) As List(Of beProveedor)
        Try
            Dim objParametros As Parameter = New Parameter
            With objParametros
                .Add("IN_CPRVCL", pbeProveedores.PNCPRVCL)
                .Add("IN_TPRVCL", pbeProveedores.PSTPRVCL)
                .Add("IN_NRUCPR", pbeProveedores.PNNRUCPR)
                .Add("PAGESIZE", pbeProveedores.PageSize)
                .Add("PAGENUMBER", pbeProveedores.PageNumber)
                .Add("PAGECOUNT", "", ParameterDirection.Output)
            End With
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_PROVEEDORES", objParametros)
        Catch ex As Exception
            Return New List(Of beProveedor)
        End Try

    End Function

    Public Function ListaProveedoresPaginado(ByVal pbeProveedores As beProveedor) As List(Of beProveedor)
        Try
            Dim objParametros As Parameter = New Parameter
            With objParametros
                .Add("IN_CPRVCL", pbeProveedores.PSCPRVCLSTR)
                .Add("IN_TPRVCL", pbeProveedores.PSTPRVCL)
                .Add("IN_NRUCPR", pbeProveedores.PSNRUCPRSTR)
                .Add("PSBUSQUEDA", pbeProveedores.PSBUSQUEDA)
                .Add("PAGESIZE", pbeProveedores.PageSize)
                .Add("PAGENUMBER", pbeProveedores.PageNumber)
                .Add("PAGECOUNT", 0, ParameterDirection.Output)
            End With
            ' Return Listar("SP_SOLMIN_PROVEEDOR_RZOL05_PAG", objParametros)
            Return Listar("SP_SOLMIN_PROVEEDOR_RZOL05_PAG", objParametros)

        Catch ex As Exception
            Return New List(Of beProveedor)
        End Try

    End Function

    Public Function ListarClienteTercero_x_Cliente_General(ByVal obeProveedor As beProveedor) As List(Of beProveedor)

        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olbeProveedor As New List(Of beProveedor)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeProveedor.PNCCLNT)
            objParam.Add("IN_NRUCPR", obeProveedor.PSNRUCPRSTR)
            objParam.Add("IN_TPRVCL", obeProveedor.PSTPRVCL)
            objParam.Add("IN_STPORL", obeProveedor.PSSTPORL)
            objParam.Add("PAGESIZE", obeProveedor.PageSize)
            objParam.Add("PAGENUMBER", obeProveedor.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_LISTA_CLIENTE_TERCERO_X_CLIENTE_GENERAL", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function EliminarRelacionTercero_x_Cliente(ByVal obeProveedor As beProveedor) As Int32
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Try
            objParam.Add("IN_CCLNT", obeProveedor.PNCCLNT)
            objParam.Add("IN_CPRVCL", obeProveedor.PNCPRVCL)
            objParam.Add("IN_STPORL", obeProveedor.PSSTPORL)
            objParam.Add("IN_USUARI", obeProveedor.PSCULUSA)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_DEL_RELACION_CLIENTE_VS_TERCERO", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function
    Public Function RegistrarRelacionTercero_x_Cliente(ByVal obeProveedor As beProveedor) As beProveedor

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeProveedor.PNCCLNT)
            objParam.Add("IN_CPRVCL", obeProveedor.PNCPRVCL)
            objParam.Add("IN_USUARI", obeProveedor.PSCULUSA)
            objParam.Add("IN_STPORL", obeProveedor.PSSTPORL)
            objParam.Add("IN_CPRPCL", obeProveedor.PSCPRPCL)
            objParam.Add("RELACION", "", ParameterDirection.Output)
            objParam.Add("CREACION", "", ParameterDirection.Output)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_INS_RELACION_CLIENTE_VS_TERCERO", objParam)
            obeProveedor.RELACION = objSqlManager.ParameterCollection("RELACION").ToString
            obeProveedor.CREACION = objSqlManager.ParameterCollection("CREACION").ToString
        Catch ex As Exception
            obeProveedor.CREACION = "FALSE"
        End Try
        Return obeProveedor
    End Function

    Public Function ObtenerProveedor(ByVal obeProveedor As beProveedor) As beProveedor

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim odt As New DataTable
        Try
            objParam.Add("PS_NRUCPR", obeProveedor.PSNRUCPRSTR)
            odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_PROVEEDOR", objParam)
            If (odt.Rows.Count > 0) Then
                obeProveedor.PNCPRVCL = odt.Rows(0).Item("CPRVCL")
                obeProveedor.PSTPRVCL = odt.Rows(0).Item("TPRVCL").ToString.Trim
                obeProveedor.PSTPRCL1 = odt.Rows(0).Item("TPRCL1").ToString.Trim
                obeProveedor.PNNRUCPR = odt.Rows(0).Item("NRUCPR")
                obeProveedor.PSTNACPR = odt.Rows(0).Item("TNACPR").ToString.Trim
                obeProveedor.PSTDRPRC = odt.Rows(0).Item("TDRPRC").ToString.Trim
                obeProveedor.PNCPAIS = odt.Rows(0).Item("CPAIS")
                obeProveedor.PSTNROFX = odt.Rows(0).Item("TNROFX").ToString.Trim
                obeProveedor.PSTLFNO1 = odt.Rows(0).Item("TLFNO1").ToString.Trim
                obeProveedor.PSTEMAI2 = odt.Rows(0).Item("TEMAI2").ToString.Trim
                obeProveedor.PSTPRSCN = odt.Rows(0).Item("TPRSCN").ToString.Trim
                obeProveedor.PSTLFNO2 = odt.Rows(0).Item("TLFNO2").ToString.Trim
                obeProveedor.PSTEMAI3 = odt.Rows(0).Item("TEMAI3").ToString.Trim
                obeProveedor.PNNDSDMP = odt.Rows(0).Item("NDSDMP")
                obeProveedor.PSSESTRG = odt.Rows(0).Item("SESTRG").ToString.Trim
            Else
                obeProveedor.PNCPRVCL = -1
            End If
        Catch ex As Exception
            obeProveedor.PNCPRVCL = -1
        End Try
        Return obeProveedor
    End Function
    Public Function RegistrarProveedorGeneral(ByVal obeProveedor As beProveedor) As beProveedor
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCPRVCL", obeProveedor.PNCPRVCL, ParameterDirection.Output)
            objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
            objParam.Add("PSTPRCL1", obeProveedor.PSTPRCL1)
            objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
            objParam.Add("PSTNACPR", obeProveedor.PSTNACPR)
            objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC)
            objParam.Add("PNCPAIS", obeProveedor.PNCPAIS)
            objParam.Add("PSTNROFX", obeProveedor.PSTNROFX)
            objParam.Add("PSTLFNO1", obeProveedor.PSTLFNO1)
            objParam.Add("PSTEMAI2", obeProveedor.PSTEMAI2)
            objParam.Add("PSTPRSCN", obeProveedor.PSTPRSCN)
            objParam.Add("PSTLFNO2", obeProveedor.PSTLFNO2)
            objParam.Add("PSTEMAI3", obeProveedor.PSTEMAI3)
            objParam.Add("PNNDSDMP", obeProveedor.PNNDSDMP)
            objParam.Add("PSCULUSA", obeProveedor.PSCULUSA)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_PROVEEDOR_INSERTAR_GENERAL", objParam)
            obeProveedor.PNCPRVCL = objSqlManager.ParameterCollection("PNCPRVCL")
        Catch ex As Exception
            obeProveedor.PNCPRVCL = -1
        End Try
        Return obeProveedor

    End Function


    Public Function ActualizarProveedorGeneral(ByVal obeProveedor As beProveedor) As Int32
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Try
            objParam.Add("PNCPRVCL", obeProveedor.PNCPRVCL)
            objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
            objParam.Add("PSTPRCL1", obeProveedor.PSTPRCL1)
            objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
            objParam.Add("PSTNACPR", obeProveedor.PSTNACPR)
            objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC)
            objParam.Add("PNCPAIS", obeProveedor.PNCPAIS)
            objParam.Add("PSTNROFX", obeProveedor.PSTNROFX)
            objParam.Add("PSTLFNO1", obeProveedor.PSTLFNO1)
            objParam.Add("PSTEMAI2", obeProveedor.PSTEMAI2)
            objParam.Add("PSTPRSCN", obeProveedor.PSTPRSCN)
            objParam.Add("PSTLFNO2", obeProveedor.PSTLFNO2)
            objParam.Add("PSTEMAI3", obeProveedor.PSTEMAI3)
            objParam.Add("PNNDSDMP", obeProveedor.PNNDSDMP)
            objParam.Add("PSSESTRG", obeProveedor.PSSESTRG)
            objParam.Add("PNFULTAC", obeProveedor.PNFULTAC)
            objParam.Add("PNHULTAC", obeProveedor.PNHULTAC)
            objParam.Add("PSCULUSA", obeProveedor.PSCULUSA)
            objParam.Add("PSCUSCRT", obeProveedor.PSCUSCRT)
            objParam.Add("PNFCHCRT", obeProveedor.PNFCHCRT)
            objParam.Add("PNHRACRT", obeProveedor.PNHRACRT)
            objParam.Add("PNUPDATE_IDEN", obeProveedor.PNUPDATE_IDENT)           
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_PROVEEDOR_UPDATE", objParam)

            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno

    End Function

    Public Function EliminarProveedorGeneral(ByVal obeProveedor As beProveedor) As Int32
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Try
            objParam.Add("PNCPRVCL", obeProveedor.PNCPRVCL)
            objParam.Add("PSCULUSA", obeProveedor.PSCULUSA)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_PROVEEDOR_DELETE_GENERAL", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno

    End Function


    Public Function ListarPais() As DataTable

        Dim objSqlManager As New SqlManager
        Dim odt As New DataTable
        Try
            odt = objSqlManager.ExecuteDataTable("SP_SOLSC_PAIS", Nothing)
        Catch : End Try
        Return odt
    End Function

    Public Function ListarProveedorGeneral(ByVal obeProveedor As beProveedor) As List(Of beProveedor)
        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olbeProveedor As New List(Of beProveedor)
        Dim objParam As New Parameter
        objParam.Add("PNNRUCPR", obeProveedor.PSNRUCPRSTR)
        objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
        objParam.Add("PAGESIZE", obeProveedor.PageSize)
        objParam.Add("PAGENUMBER", obeProveedor.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        Return Listar("SP_SOLMIN_SA_PROVEEDOR_LISTAR_GENERAL", objParam)

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

    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_PROVEEDOR_LISTAR"
        SPUpdate = "SP_SOLMIN_SA_PROVEEDOR_UPDATE"
        SPInsert = "SP_SOLMIN_SA_PROVEEDOR_INSERT"
        SPDelete = "SP_SOLMIN_SA_PROVEEDOR_DELETE"
    End Sub

    Public Overrides Sub ToParameters(ByVal obj As beProveedor)
        SetParameter(obj.PNCPRVCL)
        SetParameter(obj.PSTPRVCL)
        SetParameter(obj.PSTPRCL1)
        SetParameter(obj.PNNRUCPR)
        SetParameter(obj.PSTNACPR)
        SetParameter(obj.PSTDRPRC)
        SetParameter(obj.PNCPAIS)
        SetParameter(obj.PSTNROFX)
        SetParameter(obj.PSTLFNO1)
        SetParameter(obj.PSTEMAI2)
        SetParameter(obj.PSTPRSCN)
        SetParameter(obj.PSTLFNO2)
        SetParameter(obj.PSTEMAI3)
        SetParameter(obj.PNNDSDMP)
        SetParameter(obj.PSSESTRG)
        SetParameter(obj.PNFULTAC)
        SetParameter(obj.PNHULTAC)
        SetParameter(obj.PSCULUSA)
        SetParameter(obj.PSCUSCRT)
        SetParameter(obj.PNFCHCRT)
        SetParameter(obj.PNHRACRT)
        SetParameter(obj.PNUPDATE_IDENT)
    End Sub
End Class