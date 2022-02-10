Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.OrdenCompra

Namespace slnSOLMIN_SAT.DAO.OrdenCompra
    Public Class daoOrdenCompra
        Inherits BasicClass
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
        ''' Listado de Órdenes de Compras e Items para ser procesado por el Servicios Web swSolminSAT
        ''' que permite la Integración con otros Sistemas de nuestros clientes.
        ''' </summary>
        Public Shared Function fdtListar_OrdenesComprasWS(ByVal objSqlManager As SqlManager, ByVal strCliente As String, ByVal strNroOC As String, _
                                                          ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_RECE_LOCITE_02", strCliente, strNroOC)
            dtResultado.TableName = "OrdenesCompras"
            Return dtResultado
        End Function

        ''' <summary>
        ''' Seguimiento de las Órdenes de Compras según Fecha de Entrega
        ''' </summary>
        Public Shared Function fdtListar_SegOCSegunFechaEntrega_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_SegOC_L01, _
                                                                    ByRef strMensajeError As String) As DataTable
            Dim dtTemp As DataTable
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
                .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
                .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
                .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
                .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
                .Add("IN_FORCMI", TD_Filtro.pFORCMI_FechaOCInicial_Int)
                .Add("IN_FORCMF", TD_Filtro.pFORCMF_FechaOCFinal_Int)
                .Add("IN_FMPDMI", TD_Filtro.pFMPDMI_FechaCompInicial_Int)
                .Add("IN_FMPDMF", TD_Filtro.pFMPDMF_FechaCompFinal_Int)
                .Add("IN_STATOC", TD_Filtro.pSTATOC_StatusOC)
            End With
            Try
                strMensajeError = ""
                dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_FECHA_ENTREGA", objParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                strMensajeError = "Error producido en la funcion : << fdtListar_SegOCSegunFechaEntrega_L01 >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_L02 >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return dtTemp
        End Function

        ''' <summary>
        ''' Movimiento de Productos Valorizado según rango de fecha
        ''' </summary>
        'Public Shared Function fdtMovimientoProductosValorizado_R01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_MovProValor_L01, _
        '                                                            ByRef strMensajeError As String) As DataTable
        '    Dim dtTemp As DataTable
        '    Dim objParametros As Parameter = New Parameter
        '    ' Ingresamos los parametros del Procedure
        '    With objParametros
        '        .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
        '        .Add("IN_FMOVI", TD_Filtro.pFECINI_FechaInicial_Int)
        '        .Add("IN_FMOVF", TD_Filtro.pFECFIN_FechaFinal_Int)
        '    End With
        '    Try
        '        strMensajeError = ""
        '        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_ITEM_RZOL39_R01", objParametros)
        '    Catch ex As Exception
        '        dtTemp = New DataTable
        '        strMensajeError = "Error producido en la funcion : << fdtMovimientoProductosValorizado_R01 >> de la clase << daoOrdenCompra >> " & vbNewLine & _
        '                          "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_R01 >> " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '    Finally
        '        objSqlManager = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return dtTemp
        'End Function
#End Region
    End Class
End Namespace