Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN


Namespace slnSOLMIN_SDSW
    '-----------------------------------------------------'
    ' CLASE CON LOS METODOS BASICOS PARA TODAS LAS CLASES '
    '-----------------------------------------------------'
    Public Class clsGeneral_SDS
        Inherits clsBasicClassSDSW
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

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
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_FAMILI_01", intCliente, strCadenaBusqueda)
            dtResultado.TableName = "Familia"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Grupo(ByRef strMensajeError As String, ByVal intCliente As Int64, ByVal strFamilia As String, _
                                               ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_GRUPO_01", intCliente, strFamilia, strCadenaBusqueda)
            dtResultado.TableName = "Grupo"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_EquivalenteMercRANSA(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_MERCAD_01", strCadenaBusqueda)
            dtResultado.TableName = "Equivalencia Ransa"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Proveedor(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_PROVEE_01", strCadenaBusqueda)
            dtResultado.TableName = "Proveedor"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoApilabilidad(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_APILAB_01", strCadenaBusqueda)
            dtResultado.TableName = "Apilabilidad"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoInflamable(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_INFLAM_01", strCadenaBusqueda)
            dtResultado.TableName = "Inflamable"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoPerfumancia(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_PERFUM_01", strCadenaBusqueda)
            dtResultado.TableName = "Perfumeria"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoMovimiento(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_TMVSDS_01", strCadenaBusqueda)
            dtResultado.TableName = "TipoRecepcion"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtBuscar_SDSWAlmacenTipo(ByRef strMensajeError As String, ByVal Tipo As String, ByVal strCadena As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_ALMACE_03", Tipo, strCadena)
            dtResultado.TableName = "Almacen"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtBuscar_SDSWProducto(ByRef strMensajeError As String, ByVal Codigo As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_PRODUCTO01", Codigo)
            dtResultado.TableName = "Producto"
            Return dtResultado
        End Function


        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_Familias(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTFAM_01", intCliente)
            dtResultado.TableName = "ListaFamilia"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Grupos(ByVal intCliente As Int64, ByVal strFamilia As String, _
                                                ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTGRP_01", intCliente, strFamilia)
            dtResultado.TableName = "ListaGrupo"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_OrdenServicioMercaderia(ByVal strCliente As String, ByVal strMercaderia As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_LSTOSE_02", strCliente, strMercaderia)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function
        'Agregado para Almaceneras 
        'Funcion que busca mercaderia por el Codigo de Ransa
        Public Shared Function fdtListar_SDSWOrdenServicioMercaderiaRansa(ByVal strCliente As String, ByVal strMercaderia As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTOSE_02", strCliente, strMercaderia)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function

        'Agregado para Almaceneras

        Public Shared Function fdtListar_SDSWOrdenServicioMercaderiaW(ByVal strCliente As String, ByVal strMercaderia As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_LSTOSE_01", strCliente, strMercaderia)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function

        'Agregado para Almaceneras
        Public Shared Function fdtListar_OrdenServicioMercaderiaWO(ByVal strCliente As String, ByVal strMercaderia As String, ByVal Orden As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_LSTOSE_03", strCliente, strMercaderia, Orden)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function
        Public Shared Function fdtListar_NOrden(ByVal strOrden As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "BUSCA_ORDEN", strOrden)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWOrdenServicioMercaderiaOS(ByVal strMercaderia As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSOS_GENE_LSTOSE_01", strMercaderia)
            dtResultado.TableName = "OrdenServicioMercaderia"
            Return dtResultado
        End Function
        Public Shared Function fdtListar_Mercaderias(ByVal intCliente As Int64, ByVal strFamilia As String, _
                                                     ByVal strGrupo As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTMER_01", intCliente, strFamilia, strGrupo)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Mercaderias(ByVal objFiltro As clsFiltro_SDSWListarMercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_LSTMER_02", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCodigoFamilia_CFMCLR, _
                                               objFiltro.pstrCodigoGrupo_CGRCLR, objFiltro.pstrCodigoMercaderia_CMRCLR, objFiltro.pintFechaVencimiento_FVNCMR, _
                                               objFiltro.pintFechaInventario_FINVRN, objFiltro.pstrStatusPublicacionWEB_FPUWEB)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWAutorizacionSalida(ByVal objfiltro As clsFiltro_SDSWListarMercaderia, ByRef strMensajeError As String) As DataTable
            Dim Resultado As DataTable = Nothing
            Resultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_DESAUT01", objfiltro.pintCodigoCliente_CCLNT)
            Resultado.TableName = "Autorizacion de Salida"
            Return Resultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWSolicitudes(ByVal objFiltro As clsFiltro_SDSWConsultaSolicitud, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_LSTSOL", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCodigoTipo_CTPALM, _
                                               objFiltro.pstrCodigoAlmacen_CALMC, objFiltro.pstrCodigoZona_CZNALM, objFiltro.pintFechaISolicitud_FSLCSR, _
                                               objFiltro.pintFechaFSolicitud_FSLCSR, objFiltro.pintFechaFSolicitud_FSLCSR)
            dtResultado.TableName = "Lista de Solicitud"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWPreFactura(ByVal objFiltro As clsFiltro_SDSWListaPreFactura, ByVal Compania As String, ByVal Division As String, _
                                                   ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONULTA_PFACTURA", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pintFechaISolicitud_FATNSR, _
                                                objFiltro.pintFechaFSolicitud_FATNSR, objFiltro.strCodigoServicio_CSVRNV, Compania, Division)
            dtResultado.TableName = "Lista de PreFactura"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWIngresos(ByVal objFiltro As clsFiltros_SDSWConsultaOrden, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_INGOS", objFiltro.pintFechaSolicitud_FSLCSR)
            dtResultado.TableName = "Lista de Ingresos"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWSalidas(ByVal objFiltro As clsFiltros_SDSWConsultaOrden, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_SALOS", objFiltro.pintFechaSolicitud_FSLCSR)
            dtResultado.TableName = "Lista de Salida"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdt_Listar_SDSWIngSalDol(ByVal objFiltro As clsFiltros_SDSWConsultaOrden, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "", objFiltro.pintFechaSolicitud_FSLCSR)
            dtResultado.TableName = "Lista de Dolares"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdt_Listar_SDSWIngSalSol(ByVal objfiltro As clsFiltros_SDSWConsultaOrden, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "", objfiltro.pintFechaSolicitud_FSLCSR)
            dtResultado.TableName = "Lista de Soles"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWOrdenes_Servicio(ByVal objFiltro As slnSOLMIN_R02.FiltrosWrrt, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsultaWrrnt(strMensajeError, "SDS_GENE_LSTMER_03", objFiltro.pintCodigoCliente_CCLNT, _
                                                 objFiltro.pstrNORDSR, objFiltro.pstrSESTRG)
            dtResultado.TableName = "Lista de Ordenes Servicio"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWGuiaOS(ByVal intCliente As Int64, ByVal intOrden As Int64, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTIMP_01", intCliente, intOrden)
            dtResultado.TableName = "Lista de Guia por OS"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWVehiculos(ByVal objFiltro As clsFiltros_SDSWConsultaVehiculos, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONVEHI_01", objFiltro.pintFechaFin, objFiltro.pstrNCHSVH, objFiltro.pstrEstado, objFiltro.pintFechaInicio)
            dtResultado.TableName = "Lista Vehiculos"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWVehiculos_Temporal(ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONVEHI_03")
            dtResultado.TableName = "Lista Vehiculos"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtListar_SDSWVehiculos_Total(ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONVEHI_02")
            dtResultado.TableName = "Lista Vehiculos"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtLista_SDSWPreFactVehiculo(ByVal objfiltro As clsFiltros_SDSWConsultaVehiculos, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_PREFACT_02", objfiltro.pstrCCLNT, objfiltro.pintFechaInicio, objfiltro.pintFechaFin)
            dtResultado.TableName = "Lista de Pre-Fact"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        ' LLAMADA AL CL DE EMISION DE ORDEN DESPACHO
        Public Function fdtListarOperacion_SDSWLiberacion(ByRef strMensajeError As String, ByVal Detalle As String) As Boolean
            Dim Dia As String = Format(Today, "yyyyMMdd")
            Dim dtResultado As DataTable = Nothing
            Dim blnResultado As Boolean = True
            Dim i As Integer
            Dim Operacion, Liberacion As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            'Dim Seguridad As New clsParametrosSeguridad

            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_OPELIB", Dia)
            dtResultado.TableName = "Lista de Operacion"

            Try
                If dtResultado.Rows.Count > 0 Then
                    For i = 1 To dtResultado.Rows.Count
                        Operacion = ("" & dtResultado.Rows(0)(0)).ToString.Trim
                        Liberacion = ("" & dtResultado.Rows(0)(1)).ToString.Trim
                        objParametros = New Parameter
                        With objParametros
                            .Add("NumOpe", Operacion)
                            .Add("NumLib", Liberacion)
                        End With
                        'Call objSqlManager.ExecuteNonQueryCon("ZZC527CL", objParametros, Detalle)
                    Next
                End If

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fdtListarOperacion_Liberacion >> de la clase << clsGeneral >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Funciones para Obtener Detalle de la Información -'
        '----------------------------------------------------'
        Public Shared Function fdtObtenerDetalle_SDSWChofer(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_CHOFER_01", strEmpresaTransporte, strNroBrevete)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWCodigoMercaderiaRANSA(ByRef strMensajeError As String, ByVal strCodigoRansa As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_MERRNS_01", strCodigoRansa)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWEmpresaTransporteSDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_EMPTRA_01", strEmpresaTransporte)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWFamiliaSDS(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_FAMSDS_01", strCliente, strFamilia)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWGrupoSDS(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String, ByVal strGrupo As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_GRPSDS_01", strCliente, strFamilia, strGrupo)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWPlacaCamion(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_PLACAM_01", strEmpresaTransporte, strPlacaCamion)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWProveedor(ByRef strMensajeError As String, ByVal strProveedor As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_PROVEE_01", strProveedor)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWTipoApilabilidad(ByRef strMensajeError As String, ByVal strTipoApilabilidad As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_APILAB_01", strTipoApilabilidad)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWTipoInflamable(ByRef strMensajeError As String, ByVal strTipoInflamable As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_INFLAM_01", strTipoInflamable)
        End Function

        Public Shared Function fdtObtenerDetalle_SDSWTipoPerfumancia(ByRef strMensajeError As String, ByVal strTipoPerfumancia As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_PERFUM_01", strTipoPerfumancia)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtObtenerDetalle_SDSWSectorEconomico(ByRef strMensajeError As String, ByVal strSectorEconomico As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_SECECO_01", strSectorEconomico)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtObtenerDetalle_SDSWUnidadMedida(ByRef strMensajeError As String, ByVal strUnidadMedida As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_UNIMED_01", strUnidadMedida)
        End Function


        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Function fintObtener_CodigoServicioRecepcion(ByRef strMensajeError As String) As Int32
            'Dim dtResultado As DataTable = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_SDSREC_01")
            'Dim intCodigoServicio
            'If dtResultado.Rows.Count > 0 Then
            'Else
            'End If
            'dim strValor as String =
        End Function

        Public Function fintObtener_SDSWNroGuiaRansa(ByRef strMensajeError As String, ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
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
            objParametros.Add("OU_NGUIRN", "", ParameterDirection.Output)
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
        Public Shared Function fblnExiste_SDSWPlacaCamion(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDS_GENE_PLACAM_01", strEmpresaTransporte, strPlacaCamion)
        End Function

        Public Shared Function fblnExiste_SDSWChofer(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDS_GENE_CHOFER_01", strEmpresaTransporte, strNroBrevete)
        End Function

        Public Shared Function fblnExiste_SDSWMercaderia(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String, _
                                                     ByVal strGrupo As String, ByVal strMercaderia As String) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDS_GENE_MERCAD_01", strCliente, strFamilia, strGrupo, strMercaderia)
        End Function

        Public Shared Function fblnExiste_SDSWMercaderia(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strCodigoMercaderia As String) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDS_GENE_MERCAD_02", strCliente, strCodigoMercaderia)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnExiste_SDSWMercaderiaW(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strFamilia As String, ByVal strMercaderia As String) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_MERCAD_01", strCliente, strFamilia, strMercaderia)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnInsertar_SDSWCamion(ByRef strMensajeError As String, ByVal objCamion As clsSDSWCamion) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objCamion
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NPLCCM", .pstrNroPlacaCamion_NPLCCM)
                objParametros.Add("IN_PTRCM", .pdecCantidadPesoTara_PTRCM)
                objParametros.Add("IN_NANOCM", .pintNroAnioCamion_NANOCM)
                objParametros.Add("IN_TMRCCM", .pstrDescripcionMarcaCamion_TMRCCM)
                objParametros.Add("IN_NMTRCM", .pstrNroMotorCamion_NMTRCM)
                objParametros.Add("IN_SESTCM", .pstrStatusEstadoCamion_SESTCM)
                objParametros.Add("IN_NROPLA", .pstrParteNumericaPlaca_NROPLA)
                objParametros.Add("IN_NBRVC1", .pstrNroBreveteChofer_NBRVC1)
                objParametros.Add("IN_NPLCAC", .pstrNroPlacaAcoplado_NPLCAC)
                objParametros.Add("IN_NTRNLL", .pintNroTurnoLlegada_NTRNLL)
                objParametros.Add("IN_FASGTR", .pintFechaAsignacionTurno_FASGTR)
                objParametros.Add("IN_HASGTR", .pintHoraAsignacionTurno_HASGTR)
                objParametros.Add("IN_NTRMNL", .pstrNroTerminal_NTRMNL)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_CAMION_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnInsertar_Camion >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnInsertar_SDSWChofer(ByRef strMensajeError As String, ByVal objChofer As clsSDSWChofer) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objChofer
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NBRVCH", .pstrNroBrevete_NBRVCH)
                objParametros.Add("IN_NLELCH", .pintNroDocIdentidadChofer_NLELCH)
                objParametros.Add("IN_NTRMNL", .pstrNroTerminal_NTRMNL)
                objParametros.Add("IN_TNMBCH", .pstrChofer_TNMBCH)
                objParametros.Add("IN_SESTCH", .pStatusChofer_SESTCH)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_CHOFER_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnInsertar_Chofer >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        Public Function fblnActualizar_SDSWMercaderia(ByRef strMensajeError As String, ByVal strcliente As String, ByVal strmercaderia As String, ByVal strmercaderiarel As String)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("IN_CCLNT", strcliente.Trim)
            objParametros.Add("IN_CMRCD", strmercaderia.Trim)
            objParametros.Add("IN_CMRCLR", strmercaderiarel.Trim)
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_UPDATE_MERCADERIA", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_UPDATE_MERCADERIA", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnActualizar_Mercaderia >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fbln_SDSWCrearOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsSDSWCrearOrdenServicio, _
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
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ORDEN_SERVICIO_INS", objParametros)

                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ORDEN_SERVICIO_INS", objParametros)
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
        'Agregado para Almaceneras
        Public Function fblnSDSWActualizarOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio, ByVal strpcuser As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            With objOrdenServicio
                objParametros.Add("IN_NORDSR", .pintOrdenServicio_NORDSR)
                objParametros.Add("IN_QMRCD", .pdecCantidadDeclarada_QMRCD)
                objParametros.Add("IN_CUNCND", .pstrUnidadCantidad_CUNCND)
                objParametros.Add("IN_QPSMR", .pdecPesoDeclarado_QPSMR)
                objParametros.Add("IN_CUNPS0", .pstrUnidadPeso_CUNPS0)
                objParametros.Add("IN_NTRMNL", strpcuser)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ORDEN_SERVICIO_EDIT", objParametros)

                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ORDEN_SERVICIO_EDIT", objParametros)
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
        'Agregado para Almaceneras
        Public Function fblnSDSWAnularOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio, _
                                                 ByVal strpcuser As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            With objOrdenServicio
                'objParametros.Add("IN_CCLNT", .pintCliente_CCLNT)
                objParametros.Add("IN_NORDSR", .pintOrdenServicio_NORDSR)
                objParametros.Add("IN_NTRMNL", strpcuser)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ORDEN_SERVICIO_ANL", objParametros)

                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ORDEN_SERVICIO_ANL", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAnularOrdenServicio >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        'Agregado para Almaceneras
        Public Shared Function fblnSDSWExiste_OrdenOperacion(ByRef strMensajeError As String, _
                                                    ByVal Compania As String, ByVal Division As String, _
                                                    ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_ORDEN_OPERACION_01", Compania, Division, objOrdenServicio.pintOrdenServicio_NORDSR)
        End Function

        ' Agregado para Almaceneras
        Public Function fintObtener_SDSWResultadoSaldoAutorizacion(ByRef strMensajeError As String, ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
                                                ByVal blnStatusDefinitivo As Boolean) As Int64
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            ' variables para recuperar la información de parámetro de salida
            Dim htResultado As Hashtable
            ' variables de Trabajo
            Dim intNroGuiaRansa As Int64 = 0
            Dim intNroResultado As Int64 = 0
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"

            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CSRVC", intNroServicio)
            objParametros.Add("IN_STPODP", strTipoDeposito)
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_NGUIRN", "", ParameterDirection.Output)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_NGUIRN", objParametros)

                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_NGUIRN", objParametros)
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

        'Agrebgado para Almaceneras
        Public Function fblnSDSWCerrarOrdenServicio(ByRef strMensajeError As String, ByVal objOrdenServicio As clsSDSWMovimientoMercaderia, _
                                               ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objOrdenServicio
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_NORDSR", .pintOrdenServicio_NORDEN)
                objParametros.Add("IN_NTRMNL", strPCUSER)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ORDEN_SERVICIO_CER", objParametros)

                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ORDEN_SERVICIO_CER", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnCerrarOrdenServicio >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras
        Public Function fblnSDSWAnularTicket(ByRef strMensajeError As String, ByVal objfiltros As clsFiltros_SDSWAnularTicket) As Boolean
            'Agregado para Almaceneras
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_NRTOCK", objfiltros.intNumTicket_NRTOCK)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ANULAR_TICKET", objParametros)

                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ANULAR_TICKET", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAnularTicket >> de la clase << clsGeneralSDS >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        'Agregado para Almaceneras
        Public Function fblSDSWCerrarTicket(ByRef strMensajeError As String, ByVal objfiltro As clsFiltros_SDSWAnularTicket) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            'Ingresamos los Parametros al Procedimiento
            objParametros.Add("IN_NROTCK", objfiltro.intNumTicket_NRTOCK)
            objParametros.Add("IN_NORDSR", objfiltro.intNumOrden_NORDSR)
            objParametros.Add("IN_USUARIO", strUsuarioSistema)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_ALMACEN_CERRAR_TICKET", objParametros)

                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_CERRAR_TICKET", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnCerrarTicket >> de la clase << clsGeneralSDS >> " & vbNewLine & _
                                              "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing

            End Try
        End Function
        'Agregado para Almaceneras
        Public Function fblnRegistro_SDSWPreFact(ByRef strMensajeError As String, _
                                          ByVal objMovimiento As clsSDSWInformacionVehiculo, ByVal Compania As String, ByVal Division As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros = New Parameter
            With objParametros
                .Add("IN_FECHA1", objMovimiento.pdteInicio.ToString("yyyyMMdd"))
                .Add("IN_FECHA2", objMovimiento.pdteFinal.ToString("yyyyMMdd"))
                .Add("IN_CCLNT", objMovimiento.pstrCCLNT)
                .Add("IN_USUARIO", strUsuarioSistema)
                .Add("IN_COMPANIA", Compania)
                .Add("IN_DIVISION", Division)
            End With
            Try

                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_PREFACT_VEHICULO", objParametros)
                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_PREFACT_VEHICULO", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRegistro_PreFact >> de la clase << clsGeneral >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        'Agregar para Almaceneras
        Public Function fblnCierre_SDSWVehiculo(ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objParametros = New Parameter
            With objParametros
                .Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_VEHICULO_CER", objParametros)
                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_VEHICULO_CER", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnCierre_Vehiculo >> de la clase << clsGeneral >> " & vbNewLine & _
                                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        'Agregado para Almaceneras
        Public Function fblnIngreso_SDSWVehiculo(ByRef strMensajeError As String, _
                                                   ByVal objMovimiento As clsSDSWInformacionVehiculo) As Boolean

            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter

            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                'Agregamos los cabecera de ticket 
                For Each objitem As clsSDSWInformacionVehiculo In objMovimiento.plstItemMovimiento

                    ' For i = 1 To objMovimiento.plstItemMovimiento
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NCHSVH", objitem.pstrVin.Trim)
                        .Add("IN_TMARCA", objitem.pstrMarca.Trim)
                        .Add("IN_TMDLO", objitem.pstrModelo.Trim)
                        .Add("IN_FECEST", objitem.pdteEntrega.ToString("yyyyMMdd"))
                        .Add("IN_TABRCL", IIf(objitem.pstrEmpresa = Nothing, "", objitem.pstrEmpresa))
                        .Add("IN_NWRRNT", IIf(objitem.pstrWarrant = Nothing, 0, objitem.pstrWarrant))
                        .Add("IN_CCLNT", objitem.pstrCCLNT.Trim)
                        .Add("IN_USUARIO", strUsuarioSistema)
                        'MsgBox(i)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_ORDEN_DESPACHO_INS", objParametros)
                    '    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ORDEN_DESPACHO_INS", objParametros)
                Next

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnIngreso_Vehiculo >> de la clase << clsGeneral >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras
        'Genera Operacion desde Cierre Vehiculo
        Public Function fblnIngreso_SDSWOperacion(ByRef strMensajeError As String, _
                                                   ByVal strPCUSER As String) As Boolean

            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            Dim htResultado As Hashtable
            Dim intNro As Int64 = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                'Inserta Detalle
                objParametros = New Parameter
                With objParametros
                    .Add("IN_USUARIO", strUsuarioSistema)
                    .Add("IN_TERMINAL", strPCUSER)
                    .Add("IN_NOPRCN", "", ParameterDirection.Output)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_INS_OPERACION_DETALLE", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_INS_OPERACION_DETALLE", objParametros)



                htResultado = objSqlManager.ParameterCollection
                Int64.TryParse("" & htResultado("IN_NOPRCN"), intNro)
                'Inserta Cabecera
                If intNro <> 0 Then
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_USUARIO", strUsuarioSistema)
                        .Add("IN_TERMINAL", strPCUSER)
                        .Add("IN_NOPRCN", intNro)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_INS_OPERACION_CABECERA", objParametros)
                    'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_INS_OPERACION_CABECERA", objParametros)
                End If
                'Crea Liberaciones
                objParametros = New Parameter
                With objParametros
                    .Add("IN_USUARIO", strUsuarioSistema)
                    .Add("IN_TERMINAL", strPCUSER)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_INS_LIBERACION", objParametros)

                'Call fdtListarOperacion_Liberacion()

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnIngreso_Operacion >> de la clase << clsGeneral >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
                blnResultado = False

            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function


        Public Function fblnActualizar_SDSWOrdenAmcor(ByRef strMensajeError As String, ByVal Orden As String, ByVal Guia As String, ByVal Articulo As String)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("IN_GUIA", Guia)
            objParametros.Add("IN_ORDEN", Orden)
            objParametros.Add("IN_CARTC", Articulo.Trim)

            Try
                strMensajeError = ""
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ACTUALIZA_ESTADO_AMCOR", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_UPDATE_MERCADERIA", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnActualizar_Mercaderia >> de la clase << clsGeneral_SDS >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtLista_NumOS(ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR02")
            dtResultado.TableName = "Lista Amcor"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtLista_SDSWAmcor(ByVal GuiaI As String, ByVal GuiaS As String, ByRef strMensajeError As String)
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR01", GuiaI, GuiaS)
            dtResultado.TableName = "Lista Amcor"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnIngreso_SDSWConsultaDespachoAmcor(ByRef strMensajeError As String, _
        ByVal Guia As String) As DataTable

            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR04", Guia)
        End Function

        'Agregado para Almaceneras
        Public Shared Function fblnConsulta_Estado_Amcor(ByRef strMensajeError As String, ByVal strGuia As String)
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR08", strGuia)
        End Function
        'Agregado para Almaceneras
        Public Function fblnRelacionEtiqueta(ByRef strMensajeError As String, ByVal objEtiqueta As clsSDSWInformacionAmcor)

            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter

            objSqlManager.TransactionController(TransactionType.Automatic)
            Try

                For Each objitem As clsSDSWInformacionAmcor In objEtiqueta.plstItemMovimiento
                    objParametros = New Parameter
                    With objParametros

                        'IN_NETQT VARCHAR(30), 	
                        'IN IN_CETQWR VARCHAR(30), 	
                        'IN IN_USUARIO VARCHAR(10)
                        .Add("IN_NETQT", objEtiqueta.pstrNETQT)
                        .Add("IN_CETQWR", objEtiqueta.pstrCETQWR)
                        .Add("IN_USUARIO", strUsuarioSistema)
                        'MsgBox(i)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_AMCOR_RELACION_ETIQUETA", objParametros)
                Next
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblSalida_SDSWAmcor >> de la clase << clsGeneral >> " & vbNewLine & _
                                                      "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                      "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras
        Public Function fblnActualizaEstado_SDSWAmcor(ByRef strMensajeError As String, ByVal strFlag As String, ByVal strGuia As String)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objParametros = New Parameter
            With objParametros
                .Add("IN_FLAG", strFlag)
                .Add("IN_GUIA", strGuia)
                .Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ACTUALIZA_ESTADO_AMCOR", objParametros)
                'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_VEHICULO_CER", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnActualizaEstado_SDSWAmcor >> de la clase << clsGeneral >> " & vbNewLine & _
                                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function
        'Agregado para Almaceneras
        Public Function fblIngreso_SDSWAmcor(ByRef strMensajeError As String, ByVal objMovimiento As clsSDSWInformacionAmcor)

            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                For Each objitem As clsSDSWInformacionAmcor In objMovimiento.plstItemMovimiento

                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NGUIIN", objitem.pstrGUIA.Trim)
                        .Add("IN_ENTREGA", objitem.pstrEntrega)
                        .Add("IN_STPMOV", objitem.pstrFlagTipo)
                        .Add("IN_CARTC", objitem.pstrMaterial)
                        .Add("IN_NETQT", objitem.pstrLote)
                        .Add("IN_CTPALM", objitem.pstrCTPALM)
                        .Add("IN_CALMCM", objitem.pstrCALMC)
                        .Add("IN_CZNALM", objitem.PSTRCZNALM)
                        .Add("IN_DESCRIP", objitem.pstrDescripcion)
                        ' .Add("IN_LOTE", objitem.pstrLote.Trim)
                        .Add("IN_FECEST", objitem.pdteFecha.ToString("yyyyMMdd"))
                        '.Add("IN_FECEST", 0)
                        .Add("IN_QPRDIN", IIf(objitem.pstrCantidad = Nothing, 0, objitem.pstrCantidad))
                        .Add("IN_QPSONT", IIf(objitem.pstrPeso = Nothing, 0, objitem.pstrPeso))
                        .Add("IN_FLAG", objitem.pstrFlagTipo)
                        .Add("IN_ENTREGA1", objitem.pstrEntregaSalida)
                        '  .Add("IN_CCLNT", objitem.pstrDescripcion.Trim)
                        .Add("IN_USUARIO", strUsuarioSistema)
                        'MsgBox(i)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_AMCOR_INSERTAR", objParametros)
                Next
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblIngreso_SDSWAmcor >> de la clase << clsGeneral >> " & vbNewLine & _
                                                      "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                      "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtObtener_DetalleAMcor(ByRef strMensajeError As String, ByVal strGuia As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR03", strGuia)
        End Function

        'Agregado para Almaceneras
        Public Shared Function fdtObtener_DetalleAmcorConsulta(ByRef strMensajeError As String, ByVal strNoprcn As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR06", strNoprcn)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnConsulta_Orden_Amcor(ByRef strmensajeError As String, ByVal strOrden As String)
            Return fdtSDSWResultadoConsulta(strmensajeError, "SDSW_GENE_AMCOR10", strOrden)
        End Function

        'Agregar para Almaceneras
        Public Function fblSalida_SDSWAmcor(ByRef strMensajeError As String, ByVal Operacion As String, ByVal Terminal As String)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                ' For Each objitem As clsSDSWInformacionAmcor In objMovimiento.plstItemMovimiento
                objParametros = New Parameter
                With objParametros
                    .Add("IN_NOPRCN", Operacion)
                    .Add("IN_USUARIO", strUsuarioSistema)
                    .Add("IN_TERMINAL", Terminal)
                    'MsgBox(i)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_AMCOR_DESPACHO", objParametros)
                'Next
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblSalida_SDSWAmcor >> de la clase << clsGeneral >> " & vbNewLine & _
                                                      "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                      "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function


        'Agregado para Almaceneras
        Public Shared Function fdtObtener_DetalleItemAmcorConsulta(ByRef strMensajeError As String, ByVal Orden As String) As DataTable
            Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR07", Orden)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fdtObtener_CabeceraAmcorConsulta(ByRef strMensajeError As String, ByVal strFecha As Date, ByVal strFlag As String) As DataTable
            If strflag = "I" Then
                Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR05", strFecha.ToString("yyyyMMdd"), "")
            Else
                Return fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_AMCOR05", "", strFecha.ToString("yyyyMMdd"))
            End If
        End Function
#End Region
    End Class
End Namespace