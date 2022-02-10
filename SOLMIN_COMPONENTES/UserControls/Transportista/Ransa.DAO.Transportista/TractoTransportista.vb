Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cTractoTransportista
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
    ''' Procedimiento que se encarga de Obtener el Objeto Tracto asociado al Transportista
    ''' </summary>
    Public Function Obtener(ByVal TractoPK As TD_TractoTransportistaPK) As TD_Obj_TractoTransportista
        Dim objParametros As Parameter = New Parameter
        Dim oTractoTransportista As TD_Obj_TractoTransportista = New TD_Obj_TractoTransportista
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_NRUCTR", TractoPK.pNRUCTR_RucTransportista)
            .Add("IN_CCMPN", TractoPK.pCCMPN_Compania)
            .Add("IN_CDVSN", TractoPK.pCDVSN_Division)
            .Add("IN_CPLNDV", TractoPK.pCPLNDV_Planta)
            .Add("IN_NPLCUN", TractoPK.pNPLCUN_NroPlacaUnidad)
            '.Add("OU_MSGERR", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "")
        End With
        'Try
        sErrorMessage = ""
        oSqlManager.DefaultSchema = Libreria.GetLibrary(TractoPK.pCCMPN_Compania)
        Dim dtTemp As New DataTable
        'Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_OBJ", objParametros)
        dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_OBJ_V2", objParametros)

        'Dim htResultado As Hashtable
        'htResultado = oSqlManager.ParameterCollection
        'sErrorMessage = htResultado("OU_MSGERR")
        If dtTemp.Rows.Count = 0 Then
            sErrorMessage = "Tracto  no se encuentra asignado al transportista "
        End If
        If sErrorMessage = "" Then
            With oTractoTransportista
                .pNRUCTR_RucTransportista = TractoPK.pNRUCTR_RucTransportista
                .pCCMPN_Compania = TractoPK.pCCMPN_Compania
                .pCDVSN_Division = TractoPK.pCDVSN_Division
                .pCPLNDV_Planta = TractoPK.pCPLNDV_Planta
                .pNPLCUN_NroPlacaUnidad = ("" & dtTemp.Rows(0).Item("NPLCUN")).ToString.Trim
                .pTMRCTR_Marca_Modelo = ("" & dtTemp.Rows(0).Item("TMRCTR")).ToString.Trim
                .pNRGMT1_NroMTC = ("" & dtTemp.Rows(0).Item("NRGMT1")).ToString.Trim
                '.pFECINI_FechaInicio = dtTemp.Rows(0).Item("FECINI")
                '.pFECFIN_FechaFinal = dtTemp.Rows(0).Item("FECFIN")
                .pNPLACP_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLACP")).ToString.Trim
                .pCBRCND_Brevete = ("" & dtTemp.Rows(0).Item("CBRCND")).ToString.Trim
                .pCTPCRA_TipoAcoplado = dtTemp.Rows(0).Item("CTPCRA")
                .pCCLNT_Cliente = dtTemp.Rows(0).Item("CCLNT")
                .pTOBS_Observaciones = ("" & dtTemp.Rows(0).Item("TOBS")).ToString.Trim
                .pSESTCM_StatusCamion = ("" & dtTemp.Rows(0).Item("SESTCM")).ToString.Trim
                .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
            End With
        End If
        'Catch ex As Exception
        '    sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cTractoTransportista >> " & vbNewLine & _
        '                    "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_OBJ >> " & vbNewLine & _
        '                    "Motivo del Error : " & ex.Message
        'Finally
        'objParametros = Nothing
        'End Try
        Return oTractoTransportista
    End Function

    ''' <summary>
    ''' Listado de Tractos asociados a un Transportista para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Private Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function

    Public Function Listar(ByVal TD_Filtro As TD_Qry_TractoTransportista_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        'Dim dtTemp As DataTable
        Dim ds As New DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NRUCTR", TD_Filtro.pNRUCTR_RucTransportista)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("IN_NPLCUN", TD_Filtro.pNPLCUN_NroPlacaUnidad)
            .Add("IN_TMRCTR", TD_Filtro.pTMRCTR_Marca_Modelo)
            .Add("IN_NRGMT1", TD_Filtro.pNRGMT1_NroMTC)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            '.Add("OU_TOTPAG", 0, ParameterDirection.Output)
            .Add("OU_TOTPAG", 0)
        End With
        'Try
        sErrorMessage = ""
        oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_Compania)
        'dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_L01", objParametros)
        ds = oSqlManager.ExecuteDataSet("SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_L01_V2", objParametros)

        'For Each Item As DataRow In dtTemp.Rows
        '    Item("FVALIN") = FechaNum_a_Fecha(Item("FVALIN"))
        '    Item("FVALFI") = FechaNum_a_Fecha(Item("FVALFI"))
        'Next
        For Each Item As DataRow In ds.Tables(0).Rows
            Item("FVALIN") = FechaNum_a_Fecha(Item("FVALIN"))
            Item("FVALFI") = FechaNum_a_Fecha(Item("FVALFI"))
        Next

        If ds.Tables(1).Rows.Count > 0 Then
            intNroTotalPaginas = ds.Tables(1).Rows(0)("NUM_PAG")
        End If

        'Dim htResultado As Hashtable
        'htResultado = oSqlManager.ParameterCollection
        'intNroTotalPaginas = htResultado("OU_TOTPAG")
        'Catch ex As Exception
        '    dtTemp = New DataTable
        '    intNroTotalPaginas = 0
        '    sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cTractoTransportista >> " & vbNewLine & _
        '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRACTO_POR_TRANSPORTISTA_RZST17_L01 >> " & vbNewLine & _
        '                      "Motivo del Error : " & ex.Message
        'Finally
        '    objParametros = Nothing
        'End Try
        'Return dtTemp
        Return ds.Tables(0)
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