Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsGeneralSDSW
    Inherits clsBasicClassSDSW
#Region " Atributos "
    Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New(ByVal UsuarioSistema As String)
        strUsuarioSistema = UsuarioSistema
    End Sub
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'
    Public Shared Function fdtBuscar_SDSWAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strCadenaBusqueda)
        dtResultado.TableName = "Almacenes"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_SDSWBreveteAT(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_NRBREV_01", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Brevete"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_SDSWBreveteDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_NRBREV_02", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Brevete"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_ClienteConAcceso(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_CLIENT_CSEG", strCadenaBusqueda)
        dtResultado.TableName = "Cliente"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_ClienteGeneral(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_CLIENT_SSEG", strCadenaBusqueda)
        dtResultado.TableName = "Cliente"
        Return dtResultado
    End Function
    'GENESW_CLIENT_SSEG
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_ClienteGeneralW(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENESW_CLIENT_SSEG", strCadenaBusqueda)
        dtResultado.TableName = "Cliente"
        Return dtResultado
    End Function


    Public Shared Function fdtBuscar_EmpresaTransporteAT(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_EMPTRA_01", strCadenaBusqueda)
        dtResultado.TableName = "Empresa Transporte"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_EmpresaTransporteDS(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_EMPTRA_02", strCadenaBusqueda)
        dtResultado.TableName = "Empresa Transporte"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_Moneda(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_MONEDA_01", strCadenaBusqueda)
        dtResultado.TableName = "Moneda"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_MotivoGuiaRemisionAT(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_MOTTRA_01", strCadenaBusqueda)
        dtResultado.TableName = "Motivo Traslado"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_MotivoGuiaRemisionDS(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_MOTTRA_02", strCadenaBusqueda)
        dtResultado.TableName = "Motivo Traslado"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlantasRANSA(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_PLANTA_01", strCadenaBusqueda)
        dtResultado.TableName = "Plantas"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlantasPorClientes(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_PLANTA_02", strCliente, strCadenaBusqueda)
        dtResultado.TableName = "Plantas"
        Return dtResultado
    End Function
    Public Shared Function fdtBuscar_TipoAlmacen(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_TIPALM_01", strCadenaBusqueda)
        dtResultado.TableName = "Tipo de Almacén"
        Return dtResultado
    End Function
    'Agregado para Almacenera
    Public Shared Function fdtBuscar_ZonaAlmacen02(ByRef strMensajeError As String, ByVal strDescripcion As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_ZONALM_02", strDescripcion)
        dtResultado.TableName = "Zona"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_Almacen02(ByRef strMensajeError As String, ByVal strZona As String, ByVal strTipo As String, ByVal strAlmacen As String) As DataTable
        'GENE_ALMACE_02
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_ALMACE_02", strZona, strTipo, strAlmacen)
        dtResultado.TableName = "Almacen"
        Return dtResultado
    End Function

    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_TipoAduana(ByRef strMensajeError As String, ByVal strCadena As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_ADUANA", strCadena)
        dtResultado.TableName = "Aduana"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_TipoServicio(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String, ByVal strCadenaCompania As String, ByVal strCadenaDivision As String)
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_TIPSER_01", strCadenaBusqueda, strCadenaCompania, strCadenaDivision)
        dtResultado.TableName = "Tipo de Servicio"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_NTicket(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "TICKET_RECEPCION_REPORTE", strCadenaBusqueda)
        dtResultado.TableName = "Tipo de Servicio"
        Return dtResultado
    End Function
    Public Shared Function fdtBuscar_TipoBulto(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_UNIMED_02", strCadenaBusqueda)
        dtResultado.TableName = "TipoBulto"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_UnidadMedida(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String, ByVal strTipoUnidad As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_UNIMED_01", strCadenaBusqueda, strTipoUnidad)
        dtResultado.TableName = "Unidades"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_Unidad(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_UNIMED_03", strCadenaBusqueda)
        dtResultado.TableName = "Unidades"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_SectorEconomico(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_SECECO_01", strCadenaBusqueda)
        dtResultado.TableName = "SectorEconomico"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_Familia(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_FAMILI_01", strCadenaBusqueda)
        dtResultado.TableName = "Familia"
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Shared Function fdtBuscar_FamiliaProducto(ByRef strMensajeError As String, ByVal strFamilia As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDSW_GENE_FAMPROD_01", strFamilia, strCadenaBusqueda)
        dtResultado.TableName = "Familia Producto"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlacaUnidadAT(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "SDS_GENE_PLAUNI_01", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Placa Unidad"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlacaUnidadDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_PLAUNI_02", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Placa Unidad"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_ZonasAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String, _
                                                  ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoBusqueda(strMensajeError, "GENE_ZONALM_01", strTipoAlmacen, strAlmacen, strCadenaBusqueda)
        dtResultado.TableName = "Zonas de Almacén"
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Shared Function fdtListar_TipoBultoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_02")
        dtResultado.TableName = "TipoBulto"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadCantidadWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                      ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "C")
        dtResultado.TableName = "UnidadCantidad"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadPesoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                  ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "P")
        dtResultado.TableName = "UnidadPeso"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadVolumenWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                     ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtSDSWResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "V")
        dtResultado.TableName = "UnidadVolumen"
        Return dtResultado
    End Function


    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Detalle de la Información -'
    '--------------------------------------------------------'
    Public Shared Function fdtObtenerDetalle_Almacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String) As DataTable
        Return fdtSDSWResultadoConsulta(strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strAlmacen)
    End Function

    Public Shared Function fdtObtenerDetalle_Moneda(ByRef strMensajeError As String, ByVal strMoneda As String) As DataTable
        Return fdtSDSWResultadoConsulta(strMensajeError, "GENE_MONEDA_01", strMoneda)
    End Function

    Public Shared Function fdtObtenerDetalle_TipoAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String) As DataTable
        Return fdtSDSWResultadoConsulta(strMensajeError, "GENE_TIPALM_01", strTipoAlmacen)
    End Function

    Public Shared Function fdtObtenerDetalle_ZonasAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByVal strZonaAlmacen As String) As DataTable
        Return fdtSDSWResultadoConsulta(strMensajeError, "GENE_ZONALM_01", strTipoAlmacen, strAlmacen, strZonaAlmacen)
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    Public Shared Function fblnExiste_ClienteWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                ByRef strMensajeError As String, ByVal strCliente As String) As Boolean
        Return fblnSDSWExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_CCLNT", strCliente)
    End Function

    Public Shared Function fblnExiste_OrdenCompraWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                    ByRef strMensajeError As String, ByVal strCliente As String, ByVal strNroOC As String) As Boolean
        Return fblnSDSWExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_NORCML", strCliente, strNroOC)
    End Function

    Public Shared Function fblnExiste_ItemOrdenCompraWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                        ByRef strMensajeError As String, ByVal strCliente As String, ByVal strNroOC As String, _
                                                        ByVal strNroItem As String) As Boolean
        Return fblnSDSWExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_NRITOC", strCliente, strNroOC, strNroItem)
    End Function

    Public Shared Function fblnExiste_BultoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                            ByRef strMensajeError As String, ByVal strCliente As String, ByVal strBulto As String) As Boolean
        Return fblnSDSWExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_CREFFW", strCliente, strBulto)
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
#End Region
End Class
