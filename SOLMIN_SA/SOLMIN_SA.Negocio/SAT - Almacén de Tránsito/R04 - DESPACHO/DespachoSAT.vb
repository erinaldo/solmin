Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SAT.Despacho.Procesos
    Public Class clsDespacho
        Inherits clsBasicClass
#Region " Tipos Definidos "

#End Region
#Region " Atributos "
        Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
        Private Function fblnAnularGuiaSalida(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", objPrimaryKey_Despacho.pintCodigoCliente_CCLNT)
            objParametros.Add("IN_NRGUSA", objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_GUIA_SALIDA", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAnularGuiaSalida >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Private Function fblnRestaurarGuiaSalida(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", objPrimaryKey_Despacho.pintCodigoCliente_CCLNT)
            objParametros.Add("IN_NRGUSA", objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_RESTAURAR_GUIA_SALIDA", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRestaurarGuiaSalida >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Private Function fblnAnularGuiaRemision(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", objPrimaryKey_Despacho.pintCodigoCliente_CCLNT)
            objParametros.Add("IN_NRGUSA", objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_GUIA_REMISION", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRestaurarGuiaSalida >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        Public Function fblnGenerarGuiaSalida(ByVal oGuiaSalida As clsGuiaSalida, ByRef NroGuiaSalida As Int64) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            'Dim blnResultado As Boolean = True
            Dim blnResultado As Boolean = False
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCMPN", oGuiaSalida.pCodigoCompania_CCMPN)
                .Add("IN_CDVSN", oGuiaSalida.pCodigoDivision_CDVSN)
                .Add("IN_CPLNDV", oGuiaSalida.pCodigoPlanta_CPLNDV)
                .Add("IN_CCLNT", oGuiaSalida.pCodigoCliente_CCLNT)
                .Add("IN_NROCTL", oGuiaSalida.pNroControl_NROCTL)
                .Add("IN_FSLDAL", oGuiaSalida.pFechaSalidaAlmacen_FSLDAL_Num)
                .Add("IN_SMTRCP", oGuiaSalida.pMotivoRecepcion_SMTRCP)
                .Add("IN_SSNCRG", oGuiaSalida.pSentidoCarga_SSNCRG)
                .Add("IN_TOBSGS", oGuiaSalida.pObservacionGuiaSalidaLinea01)
                .Add("IN_TOBDGS", oGuiaSalida.pObservacionGuiaSalidaLinea02)
                .Add("IN_CTRSPT", oGuiaSalida.pCodigoTransportista_CTRSPT)
                .Add("IN_NPLCUN", oGuiaSalida.pNroPlacaUnidad_NPLCUN)
                .Add("IN_NPLCAC", oGuiaSalida.pNroPlacaAcoplado_NPLCAC)
                .Add("IN_CBRCNT", oGuiaSalida.pCodigoBreveteTransportista_CBRCNT)
                .Add("IN_STPOCM", oGuiaSalida.pTipoCampo_STPOCM)
                .Add("IN_NTCKPS", oGuiaSalida.pNroTicketBalanza_NTCKPS)
                .Add("IN_STPDSP", oGuiaSalida.pTipoDespacho_STPDSP)
                .Add("IN_USUARI", strUsuarioSistema)
                .Add("OU_NRGUSA", 0, ParameterDirection.Output)
            End With
            'Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_GUIA_SALIDA_RZIM59_INS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            NroGuiaSalida = htResultado("OU_NRGUSA")
            blnResultado = True
            'Catch ex As Exception
            '    blnResultado = False
            'Finally
            '    objSqlManager = Nothing
            '    objParametros = Nothing
            'End Try
            Return blnResultado
        End Function

        '-------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_GuiaSalidaConGuiaRemision(ByRef strMensajeError As String, _
                                                                    ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            ' DESP_GSCONGR : Guía de Salida CON Guías de Remisión
            Return fblnExisteInformacion(strMensajeError, "SAT_DESP_GSCONGR", _
                                         objPrimaryKey_Despacho.pintCodigoCliente_CCLNT, objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA)
        End Function

        '-------------------------------------------'
        '- Funciones para los procesos de Despacho -'
        '-------------------------------------------'
        Public Function fblnProceso_AnularGuiaSalida(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            If Not fblnExiste_GuiaSalidaConGuiaRemision(strMensajeError, objPrimaryKey_Despacho) Then
                Return fblnAnularGuiaSalida(strMensajeError, objPrimaryKey_Despacho)
            Else
                If strMensajeError = "" Then _
                    strMensajeError = "La Guía de Salida Nro: " & objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA & " posee Guías de Remisión."
                Return False
            End If
        End Function

        Public Function fblnProceso_RestaurarGuiaSalida(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            If fblnExiste_GuiaSalidaConGuiaRemision(strMensajeError, objPrimaryKey_Despacho) Then
                Return fblnRestaurarGuiaSalida(strMensajeError, objPrimaryKey_Despacho)
            Else
                If strMensajeError = "" Then _
                    strMensajeError = "La Guía de Salida Nro: " & objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA & " no posee Guías de Remisión."
                Return False
            End If
        End Function

        Public Function fblnProceso_AnularGuiaRemision(ByRef strMensajeError As String, ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
            If fblnExiste_GuiaSalidaConGuiaRemision(strMensajeError, objPrimaryKey_Despacho) Then
                Return fblnAnularGuiaRemision(strMensajeError, objPrimaryKey_Despacho)
            Else
                If strMensajeError = "" Then _
                    strMensajeError = "La Guía de Salida Nro: " & objPrimaryKey_Despacho.pstrNroGuiaSalida_NRGUSA & " no posee Guías de Remisión."
                Return False
            End If
        End Function


        '----------------------------------------------'
        '- Funciones para Listar Información DataGrid -'
        '----------------------------------------------'
        Public Shared Function fdtListarGuiasSalida(ByVal objFiltro As clsFiltroGuiaSalida, ByRef strMensajeError As String) As DataTable
            Dim dtEntidad As DataTable = Nothing
            ' Busco la relación de los Motivos de Traslado
            With objFiltro
                dtEntidad = fdtResultadoConsulta(strMensajeError, "DESP_GUIASA_01", _
                                                .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaSalida_NRGUSA, _
                                                .pstrFechaGuiaSalidaInicial_FSLDAL, .pstrFechaGuiaSalidaFinal_FSLDAL, _
                                                .pstrCodigoCompania_CCMPN, .pstrCodigoDivision_CDVSN, _
                                                .pdblCodigoPlanta_CPLNDV, .pstrEstadoGuiaSalida_STGUSA)
            End With
            Return dtEntidad
        End Function

        Public Shared Function fdtListarGuiasRemision(ByVal objFiltro As clsPrimaryKey_Despacho, ByRef strMensajeError As String) As DataTable
            Dim dtEntidad As DataTable = Nothing
            ' Busco la relación de los Motivos de Traslado
            With objFiltro
                dtEntidad = fdtResultadoConsulta(strMensajeError, "DESP_GUIARM_01", .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaSalida_NRGUSA)
            End With
            Return dtEntidad
        End Function
#End Region
    End Class

End Namespace