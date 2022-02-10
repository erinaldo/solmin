Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports RANSA.TypeDef.Cliente

Public Class cCliente
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
    ''' Procedimiento que se encarga de Obtener el Objeto Cliente
    ''' </summary>
    Public Function Obtener(ByVal ClientePK As TD_ClientePK, ByVal sValidarUsuario As String) As TD_Obj_Cliente
        Dim objParametros As Parameter = New Parameter
        Dim objCliente As TD_Obj_Cliente = New TD_Obj_Cliente
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCLNT", ClientePK.pCCLNT_Cliente)
            .Add("IN_MMCUSR", ClientePK.pUsuario)
            .Add("IN_STUSER", sValidarUsuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(ClientePK.pCCMPN_CodigoCompania)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_CLIENTE_RZZM01_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With objCliente
                    .pCCLNT_Cliente = dtTemp.Rows(0).Item("CCLNT")
                    .pTCMPCL_DescripcionCliente = ("" & dtTemp.Rows(0).Item("TCMPCL")).ToString.Trim
                    .pTCMCL1_DescripcionAdicional = ("" & dtTemp.Rows(0).Item("TCMCL1")).ToString.Trim
                    .pTDRCOR_DireccionOrigen = ("" & dtTemp.Rows(0).Item("TDRCOR")).ToString.Trim
                    .pNRUC_NroRUC = dtTemp.Rows(0).Item("NRUC")
                    .pNLBTEL_NroDocIdentidad = dtTemp.Rows(0).Item("NLBTEL")
                    '<[AHM]>
                    .pCRGVTA_CodigoRegionVenta = dtTemp.Rows(0).Item("CRGVTA").ToString().Trim()
                    .pTCRVTA_DescripcionRegionVenta = dtTemp.Rows(0).Item("TCRVTA").ToString().Trim()
                    .pCDSCSP_CodigoSector = dtTemp.Rows(0).Item("CDSCSP").ToString().Trim()
                    .pCDDRSP_CodClienteSAP = dtTemp.Rows(0).Item("CDDRSP").ToString().Trim()
                    '</[AHM]>
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << daoCliente >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CLIENTE_RZZM01_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return objCliente
    End Function

    ''' <summary>
    ''' Listado de Clientes para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal TD_Filtro As TD_Qry_Cliente_L01, ByVal sValidarUsuario As String, ByRef intNroTotalPaginas As Int32, Optional ByVal iTClient As Integer = 0) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_Cliente)
            .Add("IN_TCMPCL", TD_Filtro.pTCMPCL_DescripcionCliente)
            .Add("IN_NRUC", TD_Filtro.pNRUC_NroRUC)
            .Add("IN_STUSER", sValidarUsuario)
            .Add("IN_MMCUSR", TD_Filtro.pUsuario)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
                    oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_CodigoCompania)

            If iTClient = 0 Then 'sTipoCliente = 0 Normal = 1 Especial       
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_CLIENTE_RZZM01_L01", objParametros)
            ElseIf iTClient = 1 Then
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_CLIENTE_ESPECIALES_RZZM01_L01", objParametros)
            End If

            Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << fdtListar_Cliente_L01 >> de la clase << cCliente >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CLIENTE_RZZM01_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    'ACD funcion agregada
    ''' <summary>
    ''' Listado de Clientes por Grupo para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function ListarGrupo(ByVal TD_Filtro As TD_Qry_Cliente_L01, ByVal sValidarUsuario As String, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_ClienteGrupo)
            .Add("IN_TCMPCL", TD_Filtro.pTCMPCL_DescripcionCliente)
            .Add("IN_NRUC", TD_Filtro.pNRUC_NroRUC)
            .Add("IN_STUSER", sValidarUsuario)
            .Add("IN_MMCUSR", TD_Filtro.pUsuario)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_CodigoCompania)

            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_CLIENTE_GRUPO_RZZM01_L01", objParametros)

            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << fdtListar_Cliente_L01 >> de la clase << cCliente >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CLIENTE_RZZM01_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Obtener el Objeto Cliente por Grupo
    ''' </summary>
    Public Function ObtenerGrupo(ByVal ClientePK As TD_ClientePK, ByVal sValidarUsuario As String) As TD_Obj_Cliente
        Dim objParametros As Parameter = New Parameter
        Dim objCliente As TD_Obj_Cliente = New TD_Obj_Cliente
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCLNT", ClientePK.pCCLNT_Cliente)
            .Add("IN_MMCUSR", ClientePK.pUsuario)
            .Add("IN_STUSER", sValidarUsuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(ClientePK.pCCMPN_CodigoCompania)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_CLIENTE_GRUPO_RZZM01_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With objCliente
                    .pCCLNT_Cliente = dtTemp.Rows(0).Item("CCLNT")
                    .pTCMPCL_DescripcionCliente = ("" & dtTemp.Rows(0).Item("DESCAR")).ToString.Trim
                    .pTCMCL1_DescripcionAdicional = ("" & dtTemp.Rows(0).Item("NOMCAR")).ToString.Trim
                    .pTDRCOR_DireccionOrigen = ("" & dtTemp.Rows(0).Item("TDRCOR")).ToString.Trim
                    .pNRUC_NroRUC = dtTemp.Rows(0).Item("NRUC")
                    .pNLBTEL_NroDocIdentidad = dtTemp.Rows(0).Item("NLBTEL")
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << daoCliente >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CLIENTE_RZZM01_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return objCliente
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

Public Class FCliente

    Public Function ObtenerFacturaCliente(ByVal ClientePK As TD_ClientePK) As String
        Dim oSqlManager As New SqlManager
        Dim sErrorMessage As String = ""
        Dim objParametros As Parameter = New Parameter
        Dim objCliente As TD_Obj_Cliente = New TD_Obj_Cliente
        Dim ldblResult As String = ""
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCMPN", ClientePK.pCCMPN_CodigoCompania)  'JM
            .Add("IN_CCLNT", ClientePK.pCCLNT_Cliente)
            .Add("IN_CTPDCI", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            'oSqlManager.DefaultSchema = Libreria.GetLibrary(ClientePK.pCCMPN_CodigoCompania)
            oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_LISTA_RZZM01", objParametros)
            ldblResult = oSqlManager.ParameterCollection("IN_CTPDCI")
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << daoCliente >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_LISTA_RZZM01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return ldblResult

    End Function
End Class