Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Servicios.Almacenaje

Namespace Almacenaje
    Public Class cAlmacenaje
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
        ''' Función para eliminar un Proceso de Almacenaje, siempre en cuando esté en Proceso
        ''' </summary>
        Public Function Delete(ByVal oInf_DeleteAlmacenaje_L01 As TD_Inf_DeleteAlmacenaje_L01) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oInf_DeleteAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_NPRALM", oInf_DeleteAlmacenaje_L01.pNPRALM_NroOperacion)
                .Add("IN_USUARI", oInf_DeleteAlmacenaje_L01.pUsuario)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                sErrorMessage = ""
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ALMACENAJE_RZSC32_DEL", objParametros)
                Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
                sErrorMessage = htResultado("OU_MSGERR")
            Catch ex As Exception
                blnResultado = False
                sErrorMessage = "Error producido en la funcion : << Delete >> de la clase << cAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC32_DEL >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Función para agregar un Proceso de Almacenaje
        ''' </summary>
        Public Function Add(ByVal oInf_AddAlmacenaje_L01 As TD_Inf_AddAlmacenaje_L01, ByRef NroOperacion As Int64) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oInf_AddAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_CCMPN", oInf_AddAlmacenaje_L01.pCCMPN_Compania)
                .Add("IN_CDVSN", oInf_AddAlmacenaje_L01.pCDVSN_Division)
                .Add("IN_CPLNDV", oInf_AddAlmacenaje_L01.pCPLNDV_Planta)
                .Add("IN_STPODP", oInf_AddAlmacenaje_L01.pSTPODP_TipoSistAlm)
                .Add("IN_NANPRC", oInf_AddAlmacenaje_L01.pNANPRC_Ano)
                .Add("IN_NMES", oInf_AddAlmacenaje_L01.pNMES_Mes)
                .Add("IN_FECINI", oInf_AddAlmacenaje_L01.pFECINI_FechaInicial_FNum)
                .Add("IN_FECFIN", oInf_AddAlmacenaje_L01.pFECINI_FechaFinal_FNum)
                .Add("IN_OBSERV", oInf_AddAlmacenaje_L01.pOBSERV_Observacion)
                .Add("IN_NDIALI", oInf_AddAlmacenaje_L01.pNDIALI_NroDiaLibres)
                .Add("IN_NRTFSV", oInf_AddAlmacenaje_L01.pNRTFSV_Tarifa_Servicio)
                .Add("IN_QCNESP", oInf_AddAlmacenaje_L01.pQCNESP_Cantidad_Base)
                .Add("IN_TUNDIT", oInf_AddAlmacenaje_L01.pTUNDIT_Unidad)
                .Add("IN_STPOUN", oInf_AddAlmacenaje_L01.pSTPOUN_TipoUnidad)
                .Add("IN_CMNDA1", oInf_AddAlmacenaje_L01.pCMNDA1_Moneda)
                .Add("IN_VALUNI", oInf_AddAlmacenaje_L01.pVALUNI_ValorUnitario)
                .Add("IN_STPFLT", oInf_AddAlmacenaje_L01.pSTPFLT_ConsiderarFiltros)
                .Add("IN_CREFFW", oInf_AddAlmacenaje_L01.pCREFFW_CodigoBulto)
                .Add("IN_NROPLT", oInf_AddAlmacenaje_L01.pNROPLT_NroPaleta)
                .Add("IN_TTINTC", oInf_AddAlmacenaje_L01.pTTINTC_TermInterCarga)
                .Add("IN_TUBRFR", oInf_AddAlmacenaje_L01.pTUBRFR_Ubicacion)
                .Add("IN_STPING", oInf_AddAlmacenaje_L01.pSTPING_TipoMovimiento)
                .Add("IN_CRTLTE", oInf_AddAlmacenaje_L01.pCRTLTE_CriterioLote)
                .Add("IN_USUARI", oInf_AddAlmacenaje_L01.pUsuario)
                .Add("OU_NPRALM", "", ParameterDirection.Output)
            End With
            Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ALMACENAJE_RZSC32_INS", objParametros)
                Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
                NroOperacion = htResultado("OU_NPRALM")
            Catch ex As Exception
                blnResultado = False
                NroOperacion = 0
                sErrorMessage = "Error producido en la funcion : << Add >> de la clase << cAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC32_INS >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Función para Obtener un Proceso de Almacenaje
        ''' </summary>
        Public Function GetObj(ByVal oPkey_Almacenaje As TD_Pkey_Almacenaje) As DataTable
            Dim objParametros As Parameter = New Parameter
            Dim dtTemp As DataTable = Nothing
            sErrorMessage = ""
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oPkey_Almacenaje.pCCLNT_CodigoCliente)
                .Add("IN_NPRALM", oPkey_Almacenaje.pNPRALM_NroOperacion)
            End With
            Try
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_RZSC32_OBJ", objParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                sErrorMessage = "Error producido en la funcion : << GetObj >> de la clase << cAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC32_OBJ >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return dtTemp
        End Function

        ''' <summary>
        ''' Listado de los Procesos de Almacenajes registrados en el Sistema SOLMIN SAT - RZSC32
        ''' </summary>
        Public Function Listar(ByVal oQry_LstAlmacenaje_L01 As TD_Qry_LstAlmacenaje_L01) As DataTable
            Dim dtTemp As DataTable
            Dim oParametros As Parameter = New Parameter
            With oParametros
                .Add("IN_CCLNT", oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_CCMPN", oQry_LstAlmacenaje_L01.pCCMPN_Compania)
                .Add("IN_CDVSN", oQry_LstAlmacenaje_L01.pCDVSN_Division)
                .Add("IN_CPLNDV", oQry_LstAlmacenaje_L01.pCPLNDV_Planta)
                .Add("IN_STPODP", oQry_LstAlmacenaje_L01.pSTPODP_TipoSistAlm)
                .Add("IN_NPRALM", oQry_LstAlmacenaje_L01.pNPRALM_NroOperacion)
                .Add("IN_NANPRC", oQry_LstAlmacenaje_L01.pNANPRC_AnoProceso)
                .Add("IN_NMES", oQry_LstAlmacenaje_L01.pNMES_MesProceso)
            End With
            Try
                sErrorMessage = ""
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_RZSC32_L01", oParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC32_L01 >> " & vbNewLine & _
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
End Namespace