Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cTracto
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
    ''' Procedimiento que se encarga de Obtener el Objeto Tracto
    ''' </summary>
    Public Function Obtener(ByVal TractoPK As TD_TractoPK) As TD_Obj_Tracto
        Dim objParametros As Parameter = New Parameter
        Dim oTracto As TD_Obj_Tracto = New TD_Obj_Tracto
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCMPN", TractoPK.pCCMPN_Compania)
            .Add("IN_NPLCUN", TractoPK.pNPLCUN_NroPlacaUnidad)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRACTO_RZST03_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With oTracto
                    .pCCMPN_Compania = TractoPK.pCCMPN_Compania
                    .pNPLCUN_NroPlacaUnidad = ("" & dtTemp.Rows(0).Item("NPLCUN")).ToString.Trim
                    .pNEJSUN = dtTemp.Rows(0).Item("NEJSUN")
                    .pNSRCHU_NroChasis = ("" & dtTemp.Rows(0).Item("NSRCHU")).ToString.Trim
                    .pNSRMTU_NroSerieMotor = ("" & dtTemp.Rows(0).Item("NSRMTU")).ToString.Trim
                    .pFFBRUN_FechaFabricacion = dtTemp.Rows(0).Item("FFBRUN")
                    .pTCLRUN_Color = ("" & dtTemp.Rows(0).Item("TCLRUN")).ToString.Trim
                    .pTCRRUN_Carroceria = ("" & dtTemp.Rows(0).Item("TCRRUN")).ToString.Trim
                    .pNCPCRU_CapacidadTracto = dtTemp.Rows(0).Item("NCPCRU")
                    .pCTITRA_TipoTracto = dtTemp.Rows(0).Item("CTITRA")
                    .pQPSOTR_PesoTracto = dtTemp.Rows(0).Item("QPSOTR")
                    .pTMRCTR_Marca_Modelo = ("" & dtTemp.Rows(0).Item("TMRCTR")).ToString.Trim
                    .pNRGMT1_NroMTC = ("" & dtTemp.Rows(0).Item("NRGMT1")).ToString.Trim
                    .pNTERPM_NroTlfnRPM = ("" & dtTemp.Rows(0).Item("NTERPM")).ToString.Trim
                    .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cTracto >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRACTO_RZST03_OBJ >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return oTracto
    End Function

    ''' <summary>
    ''' Listado de Tractos para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal TD_Filtro As TD_Qry_Tracto_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_NPLCUN", TD_Filtro.pNPLCUN_NroPlacaUnidad)
            .Add("IN_TMRCTR", TD_Filtro.pTMRCTR_Marca_Modelo)
            .Add("IN_NRGMT1", TD_Filtro.pNRGMT1_NroMTC)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
      sErrorMessage = ""
      oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_Compania)
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_TRACTO_RZST03_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cTracto >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TRACTO_RZST03_L01 >> " & vbNewLine & _
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