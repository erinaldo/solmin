Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cAcoplado
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
    ''' Procedimiento que se encarga de Obtener el Objeto Acoplado
    ''' </summary>
    Public Function Obtener(ByVal AcopladoPK As TD_AcopladoPK) As TD_Obj_Acoplado
        Dim objParametros As Parameter = New Parameter
        Dim oAcoplado As TD_Obj_Acoplado = New TD_Obj_Acoplado
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCMPN", AcopladoPK.pCCMPN_Compania)
            .Add("IN_NPLCAC", AcopladoPK.pNPLCAC_NroAcoplado)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(AcopladoPK.pCCMPN_Compania)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_ACOPLADO_RZST05_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With oAcoplado
                    .pCCMPN_Compania = ("" & dtTemp.Rows(0).Item("CCMPN")).ToString.Trim
                    .pNPLCAC_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLCAC")).ToString.Trim
                    .pTCLRUN_Color = ("" & dtTemp.Rows(0).Item("TCLRUN")).ToString.Trim
                    .pQPSTRA_PesoTara = dtTemp.Rows(0).Item("NEJSUN")
                    .pNEJSUN_NroEjes = dtTemp.Rows(0).Item("NEJSUN")
                    .pNCPCRU_CapacidadCarga = dtTemp.Rows(0).Item("NCPCRU")
                    .pNSRCHU_NroChasis = ("" & dtTemp.Rows(0).Item("NSRCHU")).ToString.Trim
                    .pQLNGAC_Longitud = dtTemp.Rows(0).Item("QLNGAC")
                    .pQANCAC_Ancho = dtTemp.Rows(0).Item("QANCAC")
                    .pQALTAC_Alto = dtTemp.Rows(0).Item("QALTAC")
                    .pCTIACP_TipoAcoplado = dtTemp.Rows(0).Item("CTIACP")
                    .pTDEACP_DetTipoAcoplado = ("" & dtTemp.Rows(0).Item("TDEACP")).ToString.Trim
                    .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
                    .pNRGMT2_NroMTC = ("" & dtTemp.Rows(0).Item("NRGMT2")).ToString.Trim
                    .pTCNFG2_ConfigEjeAcoplado = ("" & dtTemp.Rows(0).Item("TCNFG2")).ToString.Trim
                    .pTMRCVH_Marca = ("" & dtTemp.Rows(0).Item("TMRCVH")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cAcoplado >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_ACOPLADO_RZST05_OBJ >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return oAcoplado
    End Function

    ''' <summary>
    ''' Listado de Acoplados para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal TD_Filtro As TD_Qry_Acoplado_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_NPLCUN", TD_Filtro.pNPLCAC_NroAcoplado)
            .Add("IT_TMRCVH", TD_Filtro.pTMRCVH_Marca)
            .Add("IN_TDEACP", TD_Filtro.pTDEACP_DetTipoAcoplado)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_Compania)
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_ACOPLADO_RZST05_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cAcoplado >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_ACOPLADO_RZST05_L01 >> " & vbNewLine & _
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