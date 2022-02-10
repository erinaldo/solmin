Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.DATA.slnSOLMIN.DAO

Public Class clsGeneral
    Inherits clsBasicClass
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
    Public Shared Function fdtBuscar_Almacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strCadenaBusqueda)
        dtResultado.TableName = "Almacenes"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_BreveteAT(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_NRBREV_01", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Brevete"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_BreveteDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_NRBREV_02", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Brevete"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_ClienteConAcceso(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_CLIENT_CSEG", strCadenaBusqueda)
        dtResultado.TableName = "Cliente"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_EmpresaTransporteAT(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_EMPTRA_01", strCadenaBusqueda)
        dtResultado.TableName = "Empresa Transporte"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_EmpresaTransporteDS(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_EMPTRA_02", strCadenaBusqueda)
        dtResultado.TableName = "Empresa Transporte"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_EquipoManipuleo(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_EQUMAN_01", strCadenaBusqueda)
        dtResultado.TableName = "EquipoManipuleo"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_Moneda(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_MONEDA_01", strCadenaBusqueda)
        dtResultado.TableName = "Moneda"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_MotivoGuiaRemisionAT(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_MOTTRA_01", strCadenaBusqueda)
        dtResultado.TableName = "Motivo Traslado"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_MotivoGuiaRemisionDS(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_MOTTRA_02", strCadenaBusqueda)
        dtResultado.TableName = "Motivo Traslado"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlantasRANSA(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_PLANTA_01", strCadenaBusqueda)
        dtResultado.TableName = "Plantas"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlantasPorClientes(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_PLANTA_02", strCliente, strCadenaBusqueda)
        dtResultado.TableName = "Plantas"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlantasPorProveedor(ByRef strMensajeError As String, ByVal strProveedor As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_PLANTA_03", strProveedor, strCadenaBusqueda)
        dtResultado.TableName = "Plantas"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_TipoAlmacen(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_TIPALM_01", strCadenaBusqueda)
        dtResultado.TableName = "Tipo de Almacén"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_TipoBulto(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        'dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_UNIMED_02", strCadenaBusqueda)
        dtResultado = fdtLista_TipoBulto(strCadenaBusqueda)
        dtResultado.TableName = "TipoBulto"
        Return dtResultado
    End Function

    '

    Public Shared Function fdtBuscar_UnidadMedida(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String, ByVal strTipoUnidad As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_UNIMED_01", strCadenaBusqueda, strTipoUnidad)
        dtResultado.TableName = "Unidades"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlacaUnidadAT(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_PLAUNI_01", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Placa Unidad"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_PlacaUnidadDS(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_PLAUNI_02", strEmpresaTransporte, strCadenaBusqueda)
        dtResultado.TableName = "Placa Unidad"
        Return dtResultado
    End Function

    Public Shared Function fdtBuscar_ZonasAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String, _
                                                  ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_ZONALM_01", strTipoAlmacen, strAlmacen, strCadenaBusqueda)
        dtResultado.TableName = "Zonas de Almacén"
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Shared Function fdtListar_TipoBultoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_02")
        dtResultado.TableName = "TipoBulto"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadCantidadWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                      ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "C")
        dtResultado.TableName = "UnidadCantidad"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadPesoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                  ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "P")
        dtResultado.TableName = "UnidadPeso"
        Return dtResultado
    End Function

    Public Shared Function fdtListar_UnidadVolumenWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                     ByRef strMensajeError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_UNIMED_01", "V")
        dtResultado.TableName = "UnidadVolumen"
        Return dtResultado
    End Function


    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Detalle de la Información -'
    '--------------------------------------------------------'
    Public Shared Function fdtObtenerDetalle_Almacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String) As DataTable
        Return fdtResultadoConsulta(strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strAlmacen)
    End Function

    Public Shared Function fdtObtenerDetalle_Moneda(ByRef strMensajeError As String, ByVal strMoneda As String) As DataTable
        Return fdtResultadoConsulta(strMensajeError, "GENE_MONEDA_01", strMoneda)
    End Function

    Public Shared Function fdtObtenerDetalle_TipoAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String) As DataTable
        Return fdtResultadoConsulta(strMensajeError, "GENE_TIPALM_01", strTipoAlmacen)
    End Function

    Public Shared Function fdtObtenerDetalle_ZonasAlmacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByVal strZonaAlmacen As String) As DataTable
        Return fdtResultadoConsulta(strMensajeError, "GENE_ZONALM_01", strTipoAlmacen, strAlmacen, strZonaAlmacen)
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
        Return fblnExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_CCLNT", strCliente)
    End Function

    Public Shared Function fblnExiste_OrdenCompraWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                    ByRef strMensajeError As String, ByVal strCliente As String, ByVal strNroOC As String) As Boolean
        Return fblnExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_NORCML", strCliente, strNroOC)
    End Function

    Public Shared Function fblnExiste_ItemOrdenCompraWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                        ByRef strMensajeError As String, ByVal strCliente As String, ByVal strNroOC As String, _
                                                        ByVal strNroItem As String) As Boolean
        Return fblnExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_NRITOC", strCliente, strNroOC, strNroItem)
    End Function

    Public Shared Function fblnExiste_BultoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                              ByRef strMensajeError As String, ByVal strCliente As String, ByVal strBulto As String) As Boolean
        Return fblnExisteInformacionWS(strUsuario, strPassword, strServidor, strMensajeError, "GENE_EXIST_CREFFW", strCliente, strBulto)
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    ''' <summary>
    ''' Graba y/o Actualiza la información del Chofer
    ''' </summary>
    Public Function fblnGrabar_Chofer(ByRef strMensajeError As String, ByVal objChofer As boChofer, ByVal strEquipo As String) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim blnResultado As Boolean = True
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Inicio del proceso de Grabar
        Dim oChofer As daoChofer = New daoChofer
        With oChofer
            .pintEmpresaTransporte_CTRSP = objChofer.pintEmpresaTransporte_CTRSP
            .pstrNroBrevete_NBRVCH = objChofer.pstrNroBrevete_NBRVCH
            .pstrChofer_TNMBCH = objChofer.pstrChofer_TNMBCH
            .pintNroDocIdentidadChofer_NLELCH = objChofer.pintNroDocIdentidadChofer_NLELCH
            .pStatusChofer_SESTCH = objChofer.pStatusChofer_SESTCH
            .pblnStatusActualizarSiExiste_STACTU = objChofer.pblnStatusActualizarSiExiste_STACTU
            .pstrNroTerminal_NTRMNL = strEquipo
            .pstrUsuario = strUsuarioSistema
        End With
        blnResultado = daoChofer.Grabar(objSqlManager, oChofer, strMensajeError)
        objSqlManager = Nothing
        Return blnResultado
    End Function

    ''' <summary>
    ''' Graba y/o Actualiza la información del Camión
    ''' </summary>
    Public Function fblnGrabar_Camion(ByRef strMensajeError As String, ByVal objCamion As boCamion, ByVal strEquipo As String) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim blnResultado As Boolean = True
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Inicio del proceso de Grabar
        Dim oCamion As daoCamion = New daoCamion
        With oCamion
            .pdecCantidadPesoTara_PTRCM = objCamion.pdecCantidadPesoTara_PTRCM
            .pdteFechaAsignacionTurno_FASGTR = objCamion.pdteFechaAsignacionTurno_FASGTR
            .pintEmpresaTransporte_CTRSP = objCamion.pintEmpresaTransporte_CTRSP
            .pintHoraAsignacionTurno_HASGTR = objCamion.pintHoraAsignacionTurno_HASGTR
            .pintNroAnioCamion_NANOCM = objCamion.pintNroAnioCamion_NANOCM
            .pintNroTurnoLlegada_NTRNLL = objCamion.pintNroTurnoLlegada_NTRNLL
            .pstrDescripcionMarcaCamion_TMRCCM = objCamion.pstrDescripcionMarcaCamion_TMRCCM
            .pstrNroBreveteChofer_NBRVC1 = objCamion.pstrNroBreveteChofer_NBRVC1
            .pstrNroMotorCamion_NMTRCM = objCamion.pstrNroMotorCamion_NMTRCM
            .pstrNroPlacaAcoplado_NPLCAC = objCamion.pstrNroPlacaAcoplado_NPLCAC
            .pstrNroPlacaCamion_NPLCCM = objCamion.pstrNroPlacaCamion_NPLCCM
            .pstrNroTerminal_NTRMNL = strEquipo
            .pblnStatusActualizarSiExiste_STACTU = objCamion.pblnStatusActualizarSiExiste_STACTU
            .pstrStatusEstadoCamion_SESTCM = objCamion.pstrStatusEstadoCamion_SESTCM
            .pstrUsuario = strUsuarioSistema
        End With
        blnResultado = daoCamion.Grabar(objSqlManager, oCamion, strMensajeError)
        objSqlManager = Nothing
        Return blnResultado
    End Function
#End Region
End Class
