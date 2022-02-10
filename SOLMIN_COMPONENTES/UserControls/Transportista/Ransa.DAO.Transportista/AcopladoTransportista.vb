Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cAcopladoTransportista
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
    ''' Procedimiento que se encarga de Obtener el Objeto Acoplado por Transportista
    ''' </summary>
    Public Function Obtener(ByVal AcopladoTransPK As TD_AcopladoTransportistaPK) As TD_Obj_AcopladoTransportista
        Dim objParametros As Parameter = New Parameter
        Dim oAcopladoTrans As TD_Obj_AcopladoTransportista = New TD_Obj_AcopladoTransportista
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_NRUCTR", AcopladoTransPK.pNRUCTR_RucTransportista)
            .Add("IN_CCMPN", AcopladoTransPK.pCCMPN_Compania)
            .Add("IN_CDVSN", AcopladoTransPK.pCDVSN_Division)
            .Add("IN_CPLNDV", AcopladoTransPK.pCPLNDV_Planta)
            .Add("IN_NPLCAC", AcopladoTransPK.pNPLCAC_NroAcoplado)
            '.Add("OU_MSGERR", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "")
        End With
        'Try
        sErrorMessage = ""
        oSqlManager.DefaultSchema = Libreria.GetLibrary(AcopladoTransPK.pCCMPN_Compania)
        Dim dtTemp As New DataTable
        ' Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_OBJ", objParametros)
        dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_OBJ_V2", objParametros)

        If dtTemp.Rows.Count = 0 Then
            sErrorMessage = "Acoplado no asignado al Transportista."
        End If
        'Dim htResultado As Hashtable
        'htResultado = oSqlManager.ParameterCollection
        'sErrorMessage = htResultado("OU_MSGERR")
        If sErrorMessage = "" Then
            With oAcopladoTrans
                .pNRUCTR_RucTransportista = ("" & dtTemp.Rows(0).Item("NRUCTR")).ToString.Trim
                .pCCMPN_Compania = AcopladoTransPK.pCCMPN_Compania
                .pCDVSN_Division = AcopladoTransPK.pCDVSN_Division
                .pCPLNDV_Planta = AcopladoTransPK.pCPLNDV_Planta
                .pNPLCAC_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLCAC")).ToString.Trim
                '.pFECINI_FechaInicio = dtTemp.Rows(0).Item("FECINI")
                '.pFECFIN_FechaFinal = dtTemp.Rows(0).Item("FECFIN")
                .pTOBS_Observaciones = ("" & dtTemp.Rows(0).Item("TOBS")).ToString.Trim
                .pSESTAC_StatusCamion = ("" & dtTemp.Rows(0).Item("SESTAC")).ToString.Trim
                .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
                .pTMRCVH_Marca = ("" & dtTemp.Rows(0).Item("TMRCVH")).ToString.Trim
                .pTDEACP_DetTipoAcoplado = ("" & dtTemp.Rows(0).Item("TDEACP")).ToString.Trim
            End With
        End If
        'Catch ex As Exception
        '    sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cAcopladoTransportista >> " & vbNewLine & _
        '                    "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_OBJ >> " & vbNewLine & _
        '                    "Motivo del Error : " & ex.Message
        'Finally
        '    objParametros = Nothing
        'End Try
        Return oAcopladoTrans
    End Function

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
    ''' <summary>
    ''' Listado de Acoplados por Transportista para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal TD_Filtro As TD_Qry_AcopladoTransportista_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        'Dim dtTemp As DataTable
        Dim ds As New DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NRUCTR", TD_Filtro.pNRUCTR_RucTransportista)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("IN_NPLCUN", TD_Filtro.pNPLCAC_NroAcoplado)
            .Add("IT_TMRCVH", TD_Filtro.pTMRCVH_Marca)
            .Add("IN_TDEACP", TD_Filtro.pTDEACP_DetTipoAcoplado)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            '.Add("OU_TOTPAG", 0, ParameterDirection.Output)
            .Add("OU_TOTPAG", 0)
        End With
        'Try
        sErrorMessage = ""
        oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_Compania)
        'dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_L01", objParametros)
        ds = oSqlManager.ExecuteDataSet("SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_L01_V2", objParametros)
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
        '    sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cAcopladoTransportista >> " & vbNewLine & _
        '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_ACOPLADO_POR_TRANSPORTISTA_RZST18_L01 >> " & vbNewLine & _
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