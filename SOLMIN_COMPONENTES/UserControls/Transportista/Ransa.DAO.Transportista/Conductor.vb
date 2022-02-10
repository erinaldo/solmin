Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Transportista

Public Class cConductor
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
    ''' Procedimiento que se encarga de Obtener el Objeto Conductor
    ''' </summary>
    Public Function Obtener(ByVal ConductorPK As TD_ConductorPK) As TD_Obj_Conductor
        Dim objParametros As Parameter = New Parameter
        Dim oConductor As TD_Obj_Conductor = New TD_Obj_Conductor
        ' Ingresamos los parametros del Procedure 
        With objParametros
            .Add("IN_CCMPN", ConductorPK.pCCMPN_Compania)
            .Add("IN_CBRCNT", ConductorPK.pCBRCNT_Brevete)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
      oSqlManager.DefaultSchema = Libreria.GetLibrary(ConductorPK.pCCMPN_Compania)
            Dim dtTemp As DataTable = oSqlManager.ExecuteDataTable("SP_SOLMIN_CONDUCTOR_RZST08_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sErrorMessage = htResultado("OU_MSGERR")
            If sErrorMessage = "" Then
                With oConductor
                    .pCCMPN_Compania = ("" & dtTemp.Rows(0).Item("CCMPN")).ToString.Trim
                    .pCBRCNT_Brevete = ("" & dtTemp.Rows(0).Item("CBRCNT")).ToString.Trim
                    .pTNMCMC_NombreChofer = ("" & dtTemp.Rows(0).Item("TNMCMC")).ToString.Trim
                    .pAPEPAT_ApPaterno = ("" & dtTemp.Rows(0).Item("APEPAT")).ToString.Trim
                    .pAPEMAT_ApMaterno = ("" & dtTemp.Rows(0).Item("APEMAT")).ToString.Trim
                    .pNCLICO_TipoLicencia = ("" & dtTemp.Rows(0).Item("NCLICO")).ToString.Trim
                    .pNLELCH_DocumentoIdentidad = dtTemp.Rows(0).Item("NLELCH")
                    .pCSGRSC_SeguroSocial = ("" & dtTemp.Rows(0).Item("CSGRSC")).ToString.Trim
                    .pTGRPSN_GrupoSanguineo = ("" & dtTemp.Rows(0).Item("TGRPSN")).ToString.Trim
                    .pFVEDNI_FechaVencDNI = dtTemp.Rows(0).Item("FVEDNI")
                    .pFEMLIC_FechaVencLicencia = dtTemp.Rows(0).Item("FEMLIC")
                    .pFVELIC_FechaVencLicencia = dtTemp.Rows(0).Item("FVELIC")
                    .pCODSAP_CodigoSAP = ("" & dtTemp.Rows(0).Item("CODSAP")).ToString.Trim
                    .pFECING_FechaIngreso = dtTemp.Rows(0).Item("FECING")
                    .pTDRCC_Direccion = ("" & dtTemp.Rows(0).Item("TDRCC")).ToString.Trim
                    .pNTERPM_NroTelefonoRPM = ("" & dtTemp.Rows(0).Item("NTERPM")).ToString.Trim
                    .pTOBS_Observaciones = ("" & dtTemp.Rows(0).Item("TOBS")).ToString.Trim
                    .pSINDRC_StatusRecurso = ("" & dtTemp.Rows(0).Item("SINDRC")).ToString.Trim
                    .pSESTRG_StatusRegistro = ("" & dtTemp.Rows(0).Item("SESTRG")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            sErrorMessage = "Error producido en la funcion : << Obtener >> de la clase << cConductor >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CONDUCTOR_RZST08_OBJ >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return oConductor
    End Function

    ''' <summary>
    ''' Listado de Conductors para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Function Listar(ByVal TD_Filtro As TD_Qry_Conductor_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CBRCNT", TD_Filtro.pCBRCNT_Brevete)
            .Add("IN_TNMCMC", TD_Filtro.pNombreApellidoChofer)
            .Add("IN_SINDRC", TD_Filtro.pSINDRC_StatusRecurso)
            .Add("IN_NRUCTR", TD_Filtro.pNRUCTR_RucTransportista)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.DefaultSchema = Libreria.GetLibrary(TD_Filtro.pCCMPN_Compania)
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_CONDUCTOR_RZST08_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cConductor >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CONDUCTOR_RZST08_L01 >> " & vbNewLine & _
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