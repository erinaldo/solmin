Imports RANSA.DATA.slnSOLMIN_SDS.DAO.Familia

Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SDS.MantenimientoSDSW.Procesos
    Public Class clsMantenimiento
        Inherits clsBasicClassSDSW
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
        Protected Function fblnFamilia(ByRef strMensajeError As String, ByVal strTipoOperacion As String, ByVal intCliente As Int64, _
                                       ByVal strFamilia As String, ByVal strDescripcion As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_TIOPER", strTipoOperacion)
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_CFMCLR", strFamilia)
            objParametros.Add("IN_TFMCLR", strDescripcion)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_FAMILIA", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnFamilia >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << " & strTipoOperacion & " >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Protected Function fblnGrupo(ByRef strMensajeError As String, ByVal strTipoOperacion As String, ByVal intCliente As Int64, _
                                     ByVal strFamilia As String, ByVal strGrupo As String, ByVal strDescripcion As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_TIOPER", strTipoOperacion)
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_CFMCLR", strFamilia)
            objParametros.Add("IN_CGRCLR", strGrupo)
            objParametros.Add("IN_TGRCLR", strDescripcion)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_GRUPO", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnGrupo >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operacion : << " & strTipoOperacion & " >> " & vbNewLine & _
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

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Funciones para Obtener Detalle de la Información -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Function fdtObtener_Mercaderia(ByVal objPrimaryKey_Mercaderia As clsSDSWPrimaryKey_Mercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_MANT_MERCAD_01", objPrimaryKey_Mercaderia.pintCodigoCliente_CCLNT, _
                                               objPrimaryKey_Mercaderia.pstrCodigoFamilia_CFMCLR, objPrimaryKey_Mercaderia.pstrCodigoGrupo_CGRCLR, _
                                               objPrimaryKey_Mercaderia.pstrCodigoMercaderia_CMRCLR)
            dtResultado.TableName = "Mercaderia"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Function fdtObtener_MercaderiaW(ByVal objPrimaryKey_Mercaderia As clsSDSWPrimaryKey_Mercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_MANT_MERCAD_01", objPrimaryKey_Mercaderia.pintCodigoCliente_CCLNT, _
                                               objPrimaryKey_Mercaderia.pstrCodigoMercaderia_CMRCLR)
            dtResultado.TableName = "Mercaderia"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        ' FAMILIA
        Public Function fblnGuardar_Familia(ByVal objNuevaFamilia As clsSDSWFamilia, ByRef strMensajeError As String) As Boolean
            Dim objFamilia As Familia = New Familia
            With objFamilia
                .pintCodigoCliente_CCLNT = objNuevaFamilia.pintCodigoCliente_CCLNT
                .pstrCodigoFamilia_CFMCLR = objNuevaFamilia.pstrCodigoFamilia_CFMCLR
                .pstrDescripcionFamilia_TFMCLR = objNuevaFamilia.pstrDescripcionFamilia_TFMCLR
                .pstrUsuario_CUSCRT = strUsuarioSistema
            End With
            Return Familia.fblnRegistrar_Familia(objFamilia, strMensajeError)
        End Function

        Public Function fblnGuardar_Familia(ByVal lstNuevaFamilia As List(Of clsSDSWFamilia), ByRef strMensajeError As String) As Boolean
            Dim objFamilia As Familia = Nothing
            Dim objNuevaFamilia As clsSDSWFamilia
            Dim blnResultado As Boolean = True
            Dim strTemp As String = ""
            ' Limpiamos la cadena de errores
            strMensajeError = ""
            ' Recorremos cada item de la lista y realizamos el registro
            For Each objNuevaFamilia In lstNuevaFamilia
                objFamilia = New Familia
                With objFamilia
                    .pintCodigoCliente_CCLNT = objNuevaFamilia.pintCodigoCliente_CCLNT
                    .pstrCodigoFamilia_CFMCLR = objNuevaFamilia.pstrCodigoFamilia_CFMCLR
                    .pstrDescripcionFamilia_TFMCLR = objNuevaFamilia.pstrDescripcionFamilia_TFMCLR
                    .pstrUsuario_CUSCRT = strUsuarioSistema
                End With
                If Not Familia.fblnRegistrar_Familia(objFamilia, strTemp) Then
                    strMensajeError &= vbNewLine & strTemp
                End If
            Next
            If strMensajeError <> "" Then blnResultado = False
            Return blnResultado
        End Function

        Public Function fblnEliminar_Familia(ByVal objEliminarFamilia As clsSDSWFamilia, ByRef strMensajeError As String) As Boolean
            Dim objFamilia As Familia = New Familia
            With objFamilia
                .pintCodigoCliente_CCLNT = objEliminarFamilia.pintCodigoCliente_CCLNT
                .pstrCodigoFamilia_CFMCLR = objEliminarFamilia.pstrCodigoFamilia_CFMCLR
                .pstrUsuario_CUSCRT = strUsuarioSistema
            End With
            Return Familia.fblnEliminar_Familia(objFamilia, strMensajeError)
        End Function

        Public Function fblnEliminar_Familia(ByVal lstFamilia As List(Of clsSDSWFamilia), ByRef strMensajeError As String) As Boolean
            Dim objFamilia As Familia = Nothing
            Dim objNuevaFamilia As clsSDSWFamilia
            Dim blnResultado As Boolean = True
            Dim strTemp As String = ""
            ' Limpiamos la cadena de errores
            strMensajeError = ""
            ' Recorremos cada item de la lista y realizamos el registro
            For Each objNuevaFamilia In lstFamilia
                objFamilia = New Familia
                With objFamilia
                    .pintCodigoCliente_CCLNT = objNuevaFamilia.pintCodigoCliente_CCLNT
                    .pstrCodigoFamilia_CFMCLR = objNuevaFamilia.pstrCodigoFamilia_CFMCLR
                    .pstrUsuario_CUSCRT = strUsuarioSistema
                End With
                If Not Familia.fblnEliminar_Familia(objFamilia, strTemp) Then
                    strMensajeError &= vbNewLine & strTemp
                End If
            Next
            If strMensajeError <> "" Then blnResultado = False
            Return blnResultado
        End Function

        ' GRUPO
        Public Function fblnGuardar_Grupo(ByVal objNuevaGrupo As clsSDSWGrupo, ByRef strMensajeError As String) As Boolean
            Return fblnGrupo(strMensajeError, "G", objNuevaGrupo.pintCodigoCliente_CCLNT, objNuevaGrupo.pstrCodigoFamilia_CFMCLR, _
                             objNuevaGrupo.pstrCodigoGrupo_CGRCLR, objNuevaGrupo.pstrDescripcionGrupo_TGRCLR)
        End Function

        Public Function fdtGuardar_Grupo(ByVal lstNuevaGrupo As List(Of clsSDSWGrupo)) As DataTable
            Dim objNuevaGrupo As clsSDSWGrupo
            Dim dtResultadoError As DataTable = New DataTable
            Dim strMensajeError As String = ""

            dtResultadoError.Columns.Add("CCLNT")   ' Cliente
            dtResultadoError.Columns.Add("CFMCLR")  ' Codigo Familia 3 Caracteres
            dtResultadoError.Columns.Add("CGRCLR")  ' Codigo Grupo 4 Caracteres
            dtResultadoError.Columns.Add("TGRCLR")  ' Descripción Familia 30 Caracteres
            dtResultadoError.Columns.Add("OBSERV")  ' Observación en la carga

            For Each objNuevaGrupo In lstNuevaGrupo
                With objNuevaGrupo
                    ' Creamos un nuevo registro para almacena la familia que no pudo ser ingresada
                    Dim rwTemporal As DataRow = dtResultadoError.NewRow()
                    rwTemporal("CCLNT") = .pintCodigoCliente_CCLNT
                    rwTemporal("CFMCLR") = .pstrCodigoFamilia_CFMCLR
                    rwTemporal("CGRCLR") = .pstrCodigoGrupo_CGRCLR
                    rwTemporal("TGRCLR") = .pstrDescripcionGrupo_TGRCLR
                    ' Si se presenta algún error se almacena en la Tabla de Error
                    If fblnGrupo(strMensajeError, "G", objNuevaGrupo.pintCodigoCliente_CCLNT, objNuevaGrupo.pstrCodigoFamilia_CFMCLR, _
                                 objNuevaGrupo.pstrCodigoGrupo_CGRCLR, objNuevaGrupo.pstrDescripcionGrupo_TGRCLR) Then
                        strMensajeError = "OK"
                    Else
                        strMensajeError = "Error !!!... " & strMensajeError
                    End If
                    rwTemporal("OBSERV") = strMensajeError
                    dtResultadoError.Rows.Add(rwTemporal)
                End With
            Next
            Return dtResultadoError
        End Function

        Public Function fblnEliminar_Grupo(ByVal objGrupo As clsSDSWGrupo, ByRef strMensajeError As String) As Boolean
            Return fblnGrupo(strMensajeError, "D", objGrupo.pintCodigoCliente_CCLNT, objGrupo.pstrCodigoFamilia_CFMCLR, _
                             objGrupo.pstrCodigoGrupo_CGRCLR, objGrupo.pstrDescripcionGrupo_TGRCLR)
        End Function

        Public Function fdtEliminar_Grupo(ByVal lstGrupo As List(Of clsSDSWGrupo)) As DataTable
            Dim objGrupo As clsSDSWGrupo
            Dim dtResultadoError As DataTable = New DataTable
            Dim strMensajeError As String = ""

            dtResultadoError.Columns.Add("CCLNT")   ' Cliente
            dtResultadoError.Columns.Add("CFMCLR")  ' Codigo Familia 3 Caracteres
            dtResultadoError.Columns.Add("CGRCLR")  ' Codigo Grupo 4 Caracteres
            dtResultadoError.Columns.Add("TGRCLR")  ' Descripción Familia 30 Caracteres
            dtResultadoError.Columns.Add("OBSERV")  ' Observación en la carga

            For Each objGrupo In lstGrupo
                With objGrupo
                    ' Creamos un nuevo registro para almacena la familia que no pudo ser ingresada
                    Dim rwTemporal As DataRow = dtResultadoError.NewRow()
                    rwTemporal("CCLNT") = .pintCodigoCliente_CCLNT
                    rwTemporal("CFMCLR") = .pstrCodigoFamilia_CFMCLR
                    rwTemporal("CGRCLR") = .pstrCodigoGrupo_CGRCLR
                    rwTemporal("TGRCLR") = .pstrDescripcionGrupo_TGRCLR
                    ' Si se presenta algún error se almacena en la Tabla de Error
                    If fblnGrupo(strMensajeError, "D", .pintCodigoCliente_CCLNT, .pstrCodigoFamilia_CFMCLR, .pstrCodigoGrupo_CGRCLR, _
                                .pstrDescripcionGrupo_TGRCLR) Then
                        strMensajeError = "OK"
                    Else
                        strMensajeError = "Error !!!... " & strMensajeError
                    End If
                    rwTemporal("OBSERV") = strMensajeError
                    dtResultadoError.Rows.Add(rwTemporal)
                End With
            Next
            Return dtResultadoError
        End Function

        ' MERCADERIA
        Public Function fblnGuardar_Mercaderia(ByRef strMensajeError As String, ByVal objMercaderia As clsSDSWMercaderia) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objMercaderia
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CMRCLR", .pstrCodigoMercaderia_CMRCLR)
                objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
                objParametros.Add("IN_CGRCLR", .pstrCodigoGrupo_CGRCLR)
                objParametros.Add("IN_CMRCRR", .pstrCodigoMercaderiaReemplazo_CMRCRR)
                objParametros.Add("IN_CMRCD", .pstrCodigoRANSA_CMRCD)
                objParametros.Add("IN_TMRCD2", .pstrDescripcion_TMRCD2)
                objParametros.Add("IN_TMRCD3", .pstrDescripcion_TMRCD3)
                objParametros.Add("IN_CPRVCL", .pintProveedor_CPRVCL)
                objParametros.Add("IN_CMNCT", .pintCodigoMoneda_CMNCT)
                objParametros.Add("IN_QIMCT", .pdecImporteCosto_QIMCT)
                objParametros.Add("IN_QIMCTP", .pdecImporteCostoPromedio_QIMCTP)
                objParametros.Add("IN_MARCRE", .pstrMarcaReembolso_MARCRE)
                objParametros.Add("IN_QICOPS", .pdecImporteCostoPromedioSoles_QICOPS)
                objParametros.Add("IN_IMVTAD", .pdecImporteVentaDolar_IMVTAD)
                objParametros.Add("IN_IMVTAS", .pdecImporteVentaDolar_IMVTAS)
                objParametros.Add("IN_IMVLM2", .pdecImportePorMts2_IMVLM2)
                objParametros.Add("IN_PDSCTO", .pdecPorcentajeDescuento_PDSCTO)
                objParametros.Add("IN_TMRCTR", .pstrMarcaModelo_TMRCTR)
                objParametros.Add("IN_UBICA1", .pstrUbicacion_UBICA1)
                objParametros.Add("IN_TOBSRV", .pstrObservacion_TOBSRV)
                objParametros.Add("IN_QMRSRC", .pdecCantidadMinimaReqServicio_QMRSRC)
                objParametros.Add("IN_QMRSRP", .pdecPesoMinimoReqServicio_QMRSRP)
                objParametros.Add("IN_QMRODC", .pdecCantidadMercaderiaPtoReorden_QMRODC)
                objParametros.Add("IN_QMRODP", .pdecPesoMercaderiaPtoReorden_QMRODP)
                objParametros.Add("IN_QMRPRD", .pdecCantidadMinimaProducir_QMRPRD)
                objParametros.Add("IN_QLRGMR", .pdecLargoMercaderia_QLRGMR)
                objParametros.Add("IN_QANCMR", .pdecAnchoMercaderia_QANCMR)
                objParametros.Add("IN_QALTMR", .pdecAlturaMercaderia_QALTMR)
                objParametros.Add("IN_QARMT2", .pdecAreaMts2_QARMT2)
                objParametros.Add("IN_QARMT3", .pdecVolumenMts3_QARMT3)
                objParametros.Add("IN_QVOLEQ", .pdecVolumenEquivalente_QVOLEQ)
                objParametros.Add("IN_QPSODC", .pdecCantidadPesoDeclarado_QPSODC)
                objParametros.Add("IN_QTMPCR", .pdecTiempoCargaMercaderia_QTMPCR)
                objParametros.Add("IN_QTMPDS", .pdecTiempoDesargaMercaderia_QTMPDS)
                objParametros.Add("IN_CUNCNC", .pstrUnidad_CUNCNC)
                objParametros.Add("IN_CUNCNI", .pstrUnidadInventario_CUNCNI)
                objParametros.Add("IN_FPUWEB", .pstrStatusPublicacionWEB_FPUWEB)
                objParametros.Add("IN_FVNCMR", .pintFechaVencimiento_FVNCMR)
                objParametros.Add("IN_FINVRN", .pintFechaInventario_FINVRN)
                objParametros.Add("IN_CPRFMR", .pstrCodigoPerfumancia_CPRFMR)
                objParametros.Add("IN_CINFMR", .pstrCodigoInflamabilidad_CINFMR)
                objParametros.Add("IN_CROTMR", .pstrCodigoRotacion_CROTMR)
                objParametros.Add("IN_CAPIMR", .pstrCodigoApilabilidad_CAPIMR)
                objParametros.Add("IN_DUN14", .pstrCodigoDUN14)
                objParametros.Add("IN_EAN13", .pstrCodigoEAN13)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_MERCADERIA_INS", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnGuardarMercaderia >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Guardar Mercadería >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        'Agregado para Almaceneras
        Public Function fblnGuardar_MercaderiaW(ByRef strMensajeError As String, ByVal objMercaderia As clsSDSWMercaderia) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            Dim a, b As String
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objMercaderia
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
                objParametros.Add("IN_CMRCD", .pstrCodigoRANSA_CMRCD)

                b = .pstrDescripcion_TMRCD2.Length
                If b > 50 Then
                    objParametros.Add("IN_TMRCD2", .pstrDescripcion_TMRCD2.Substring(0, 49))
                Else
                    objParametros.Add("IN_TMRCD2", .pstrDescripcion_TMRCD2)
                End If

                a = .pstrDescripcionFamilia_TFMCLR.Length
                If a > 30 Then
                    objParametros.Add("IN_TFMCLR", .pstrDescripcionFamilia_TFMCLR.Substring(0, 29))
                Else
                    objParametros.Add("IN_TFMCLR", .pstrDescripcionFamilia_TFMCLR)
                End If

                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_GUARDAR_MERCADERIA", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnGuardarMercaderiaW >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Guardar Mercadería >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        Public Function fblnEliminar_Mercaderia(ByRef strMensajeError As String, ByVal objPrimaryKey_Mercaderia As clsSDSWPrimaryKey_Mercaderia) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objPrimaryKey_Mercaderia
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
                objParametros.Add("IN_CGRCLR", .pstrCodigoGrupo_CGRCLR)
                objParametros.Add("IN_CMRCLR", .pstrCodigoMercaderia_CMRCLR)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_MERCADERIA_DEL", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnEliminarMercaderia >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Elimnar Mercadería >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        ' CHOFER
        Public Function fblnGuardar_Chofer(ByVal objNuevoChofer As clsSDSWChofer, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objNuevoChofer
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NBRVCH", .pstrNroBrevete_NBRVCH)
                objParametros.Add("IN_NLELCH", .pstrDocumentoIdentidad_NLELCH)
                objParametros.Add("IN_NTRMNL", .pstrNroTerminalUsado_NTRMNL)
                objParametros.Add("IN_TNMBCH", .pstrNombreChofer_TNMBCH)
                objParametros.Add("IN_SESTCH", .pstrEstadoChofer_SESTCH)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CHOFER_INS", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnGuardar_Chofer >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Guardar Chofer >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Public Function fblnEliminar_Chofer(ByVal objPrimaryKey_Chofer As clsSDSWPrimaryKey_Chofer, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objPrimaryKey_Chofer
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NBRVCH", .pstrNroBrevete_NBRVCH)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CHOFER_DEL", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnEliminar_Chofer >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Eliminar Chofer >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        ' CAMION
        Public Function fblnGuardar_Camion(ByVal objNuevoCamion As clsSDSWCamion, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objNuevoCamion
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NPLCCM", .pstrNroPlacaCamion_NPLCCM)
                objParametros.Add("IN_PTRCM", .pdecCantidadPesoTara_PTRCM)
                objParametros.Add("IN_NANOCM", .pintNroAnioCamion_NANOCM)
                objParametros.Add("IN_TMRCCM", .pstrMarcaCamion_TMRCCM)
                objParametros.Add("IN_NMTRCM", .pstrNroMotorCamion_NMTRCM)
                objParametros.Add("IN_SESTCM", .pstrEstadoCamion_SESTCM)
                objParametros.Add("IN_NROPLA", .pstrNroPlacaCamion_NROPLA)
                objParametros.Add("IN_NBRVC1", .pstrNroBrevete_NBRVC1)
                objParametros.Add("IN_NPLCAC", .pstrNroAcoplado_NPLCAC)
                objParametros.Add("IN_NTRNLL", .pintNroTurnoLlegada_NTRNLL)
                objParametros.Add("IN_FASGTR", .pintFechaAsignacionTurno_FASGTR)
                objParametros.Add("IN_HASGTR", .pintHoraAsignacionTurno_HASGTR)
                objParametros.Add("IN_NTRMNL", .pstrNroTerminalUsado_NTRMNL)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CAMION_INS", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnGuardar_Camion >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Guardar Camión >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Public Function fblnEliminar_Camion(ByVal objPrimaryKey_Camion As clsSDSWPrimaryKey_Camion, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objPrimaryKey_Camion
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NPLCCM", .pstrNroPlacaCamion_NPLCCM)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CAMION_DEL", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnEliminar_Camion >> de la clase << clsMantenimiento >> " & vbNewLine & _
                                  "Tipo de Operación : << Eliminar Camion >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
#End Region
    End Class
End Namespace