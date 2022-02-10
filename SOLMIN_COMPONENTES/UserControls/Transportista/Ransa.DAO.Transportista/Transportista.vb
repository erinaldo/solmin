Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cTransportista
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
    ''' Procedimiento que se encarga de Obtener el Objeto Transportista
    ''' </summary>
    Public Function Obtener(ByVal oPrKey As TD_TransportistaPK) As TD_Obj_Transportista
        Dim objParametros As Parameter = New Parameter
        Dim oTransp As TD_Obj_Transportista = New TD_Obj_Transportista
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCMPN", oPrKey.pCCMPN_Compania)
            .Add("IN_NRUCTR", oPrKey.pNRUCTR_RucTransportista)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(oPrKey.pCCMPN_Compania)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRANSPORTISTA_RZST01_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With oTransp
                    .pCCMPN_Compania = dtTemp.Rows(0).Item("CCMPN")
                    .pNRUCTR_RucTransportista = dtTemp.Rows(0).Item("NRUCTR")
                    .pCTRSPT_CodTransportista = dtTemp.Rows(0).Item("CTRSPT")
                    .pTCMTRT_RazonSocial = ("" & dtTemp.Rows(0).Item("TCMTRT")).ToString.Trim
                    .pTABTRT_DescAbrevRazonSocial = ("" & dtTemp.Rows(0).Item("TABTRT")).ToString.Trim
                    .pTDRCTR_Direccion = ("" & dtTemp.Rows(0).Item("TDRCTR")).ToString.Trim
                    .pTLFTRP_Telefono = ("" & dtTemp.Rows(0).Item("TLFTRP")).ToString.Trim
                    .pSINDRC_IndicadorRecurso = ("" & dtTemp.Rows(0).Item("SINDRC")).ToString.Trim
                    .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
                    .pSINDRC_PropioTercero = ("" & dtTemp.Rows(0).Item("SINDRC")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cTransportista >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRANSPORTISTA_RZST01_OBJ >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return oTransp
    End Function

    ''' <summary>
    ''' Listado de Transportistas para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal oFiltro As TD_Qry_Transportista_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", oFiltro.pCCMPN_Compania)
            .Add("IN_NRUCTR", oFiltro.pNRUCTR_RucTransportista)
            .Add("IN_TCMTRT", oFiltro.pTCMTRT_RazonSocial)
            .Add("IN_CTRSPT", oFiltro.pCTRSPT_CodTransportista)
            .Add("IN_NROPAG", oFiltro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", oFiltro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(oFiltro.pCCMPN_Compania)
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRANSPORTISTA_RZST01_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cTransportista >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRANSPORTISTA_RZST01_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
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