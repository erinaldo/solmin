Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Namespace slnSOLMIN_SDS
    '-----------------------------------------------------'
    ' CLASE CON LOS METODOS BASICOS PARA TODAS LAS CLASES '
    '-----------------------------------------------------'
    Public Class clsGeneral_SDS
        Inherits clsBasicClass
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

        Public Function Listado_Plantas_x_Cliente_Tercero(ByVal objParametros As List(Of String)) As DataTable
            Return New RANSA.DATA.daPlantaClienteProveedor().Listado_Planta_x_Cliente_Tercero(objParametros)
        End Function

        Public Function ValidarRegOrdenServicio(ByVal objParametros As Hashtable) As String
            Return New RANSA.DATA.daGeneral().ValidarRegOrdenServicio(objParametros)
        End Function

#End Region
#Region " Metodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'
        Public Shared Function fdtBuscar_Familia(ByRef strMensajeError As String, ByVal intCliente As Int64, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_FAMILI_01", intCliente, strCadenaBusqueda)
            dtResultado.TableName = "Familia"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Grupo(ByRef strMensajeError As String, ByVal intCliente As Int64, ByVal strFamilia As String, _
                                               ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_GRUPO_01", intCliente, strFamilia, strCadenaBusqueda)
            dtResultado.TableName = "Grupo"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_EquivalenteMercRANSA(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_MERCAD_01", strCadenaBusqueda)
            dtResultado.TableName = "Equivalencia Ransa"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Proveedor(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_PROVEE_01", strCadenaBusqueda)
            dtResultado.TableName = "Proveedor"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoApilabilidad(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_APILAB_01", strCadenaBusqueda)
            dtResultado.TableName = "Apilabilidad"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoInflamable(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_INFLAM_01", strCadenaBusqueda)
            dtResultado.TableName = "Inflamable"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoPerfumancia(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_PERFUM_01", strCadenaBusqueda)
            dtResultado.TableName = "Perfumeria"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoMovimiento(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SDS_GENE_TMVSDS_01", strCadenaBusqueda)
            dtResultado.TableName = "TipoRecepcion"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_Familias(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_GENE_LSTFAM_01", intCliente)
            dtResultado.TableName = "ListaFamilia"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Grupos(ByVal intCliente As Int64, ByVal strFamilia As String, _
                                                ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_GENE_LSTGRP_01", intCliente, strFamilia)
            dtResultado.TableName = "ListaGrupo"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_OrdenServicioMercaderia(ByVal strCliente As String, ByVal strMercaderia As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_GENE_LSTOSE_01", strCliente, strMercaderia)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Mercaderias(ByVal intCliente As Int64, ByVal strFamilia As String, _
                                                     ByVal strGrupo As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_GENE_LSTMER_01", intCliente, strFamilia, strGrupo)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Mercaderias(ByVal objFiltro As clsFiltro_ListarMercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_GENE_LSTMER_02", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCodigoFamilia_CFMCLR, _
                                               objFiltro.pstrCodigoGrupo_CGRCLR, objFiltro.pstrCodigoMercaderia_CMRCLR, objFiltro.pintFechaVencimiento_FVNCMR, _
                                               objFiltro.pintFechaInventario_FINVRN, objFiltro.pstrStatusPublicacionWEB_FPUWEB)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function

        '-------------------------------SE AGREGO-----------------------------------------------------------------------
        Public Shared Function fdtListar_OrdenServicioMercaderiaGuia(ByVal strCliente As String, ByVal strGuiaRemision As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaGuia(strMensajeError, "SP_SOLMIN_SDS_MERCADERIA_GUIA_RZOL66_R01", strCliente, strGuiaRemision)
            dtResultado.TableName = "OrdenServicioMercaderiaGuia"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_OrdenServicioMercaderiaGuia_Info_Adicional(ByVal strOrdenServicio As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaGuia_Info_Adicional(strMensajeError, "SDS_GENE_LSTOSE_01", strOrdenServicio)
            dtResultado.TableName = "OrdenServicioMercaderiaGuiaInfo"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Funciones para Obtener Detalle de la Información -'
        '----------------------------------------------------'
        Public Shared Function fdtObtenerDetalle_Chofer(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_CHOFER_01", strEmpresaTransporte, strNroBrevete)
        End Function

        Public Shared Function fdtObtenerDetalle_CodigoMercaderiaRANSA(ByRef strMensajeError As String, ByVal strCodigoRansa As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_MERRNS_01", strCodigoRansa)
        End Function

        Public Shared Function fdtObtenerDetalle_EmpresaTransporteSDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_EMPTRA_01", strEmpresaTransporte)
        End Function

        Public Shared Function fdtObtenerDetalle_FamiliaSDS(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_FAMSDS_01", strCliente, strFamilia)
        End Function

        Public Shared Function fdtObtenerDetalle_GrupoSDS(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String, ByVal strGrupo As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_GRPSDS_01", strCliente, strFamilia, strGrupo)
        End Function

        Public Shared Function fdtObtenerDetalle_PlacaCamion(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_PLACAM_01", strEmpresaTransporte, strPlacaCamion)
        End Function

        Public Shared Function fdtObtenerDetalle_Proveedor(ByRef strMensajeError As String, ByVal strProveedor As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_PROVEE_01", strProveedor)
        End Function

        Public Shared Function fdtObtenerDetalle_TipoApilabilidad(ByRef strMensajeError As String, ByVal strTipoApilabilidad As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_APILAB_01", strTipoApilabilidad)
        End Function

        Public Shared Function fdtObtenerDetalle_TipoInflamable(ByRef strMensajeError As String, ByVal strTipoInflamable As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_INFLAM_01", strTipoInflamable)
        End Function

        Public Shared Function fdtObtenerDetalle_TipoPerfumancia(ByRef strMensajeError As String, ByVal strTipoPerfumancia As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SDS_GENE_PERFUM_01", strTipoPerfumancia)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Function fintObtener_CodigoServicioRecepcion(ByRef strMensajeError As String) As Int32
            'Dim dtResultado As DataTable = fdtResultadoConsulta(strMensajeError, "SDS_GENE_SDSREC_01")
            'Dim intCodigoServicio
            'If dtResultado.Rows.Count > 0 Then
            'Else
            'End If
            'dim strValor as String =
        End Function

        Public Function fintObtener_NroGuiaRansa(ByRef strMensajeError As String, ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
                                                 ByVal blnStatusDefinitivo As Boolean) As Int64
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            ' variables para recuperar la información de parámetro de salida
            Dim htResultado As Hashtable
            ' variables de Trabajo
            Dim intNroGuiaRansa As Int64 = 0
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"

            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CSRVC", intNroServicio)
            objParametros.Add("IN_STPODP", strTipoDeposito)
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_NGUIRN", 0, ParameterDirection.Output)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_NGUIRN", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                Int64.TryParse("" & htResultado("OU_NGUIRN"), intNroGuiaRansa)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fintObtener_NroGuiaRansa >> de la clase << clsRecepcion >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                intNroGuiaRansa = 0
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return intNroGuiaRansa
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_PlacaCamion(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String) As Boolean
            Return fblnExisteInformacion(strMensajeError, "SDS_GENE_PLACAM_01", strEmpresaTransporte, strPlacaCamion)
        End Function

        Public Shared Function fblnExiste_Chofer(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String) As Boolean
            Return fblnExisteInformacion(strMensajeError, "SDS_GENE_CHOFER_01", strEmpresaTransporte, strNroBrevete)
        End Function

        Public Shared Function fblnExiste_Mercaderia(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strMercaderia As String) As Boolean
            Return fblnExisteInformacion(strMensajeError, "SDS_GENE_MERCAD_01", strCliente, strMercaderia)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnCrearOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsCrearOrdenServicio, _
                                               ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objOrdenServicio
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CMRCLR", .pstrCodigoMercaderia_CMRCLR)
                objParametros.Add("IN_NCNTR", .pintNroContrato_NCNTR)
                objParametros.Add("IN_CTPDP3", .pstrTipoDeposito_CTPDP3)
                objParametros.Add("IN_CTPPR1", .pstrProducto_CTPPR1)
                objParametros.Add("IN_QMRCD", .pdecCantidadDeclarada_QMRCD)
                objParametros.Add("IN_CUNCND", .pstrUnidadCantidad_CUNCND)
                objParametros.Add("IN_QPSMR", .pdecPesoDeclarado_QPSMR)
                objParametros.Add("IN_CUNPS0", .pstrUnidadPeso_CUNPS0)
                objParametros.Add("IN_QVLMR", .pdecValorDeclarado_QVLMR)
                objParametros.Add("IN_CUNVLR", .pstrUnidadValor_CUNVLR)
                objParametros.Add("IN_FUNCTL", .pstrControlLotes_FUNCTL)
                objParametros.Add("IN_FUNDS", .pstrUnidadDespacho_FUNDS)
                objParametros.Add("IN_NTRMNL", strPCUSER)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ORDEN_SERVICIO_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnCrearOrdenServicio >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        '-----------------------SE AGREGO----------------------------------------------------------
        Public Function fblnActualizarOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsCrearOrdenServicio, _
                                               ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objOrdenServicio
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_NORDSR", .pintOrdenServicio_NORDSR)
                objParametros.Add("IN_QMRCD1", .pdecCantidadDeclarada_QMRCD)
                objParametros.Add("IN_QPSMR1", .pdecPesoDeclarado_QPSMR)
                objParametros.Add("IN_QVLMR1", .pdecValorDeclarado_QVLMR)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
                objParametros.Add("IN_NTRMNL", strPCUSER)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDS_ACTUALIZAR_ORDEN_SERVICIO", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnActualizarOrdenServicio >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
#End Region
    End Class
End Namespace