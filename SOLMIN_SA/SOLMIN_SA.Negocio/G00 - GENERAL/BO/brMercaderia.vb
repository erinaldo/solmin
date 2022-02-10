Imports RANSA.DATA.slnSOLMIN_SDS.DAO.Mercaderia
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class brMercaderia

    Public Function ListarMercaderiaPorCliente(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListarMercaderiaPorCliente(obeMercaderia)
    End Function

    Public Function ListaKardex(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaKardex(obeMercaderia)
    End Function


    Public Function ListaKardexAlmacen(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaKardexAlmacen(obeMercaderia)
    End Function



    Public Function ListaKardexPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaKardexPorSolicitudServicio(obeKardex)
    End Function

    Public Function ListaPedidoPorOrdenDeCompra(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaPedidoPorOrdenDeCompra(obeMercaderia)
    End Function

    Public Function ListaMercaderiaPorClienteItem(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)
    End Function

    Public Function ListaSeriePorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaSeriePorSolicitudServicio(obeKardex)
    End Function

    Public Function ListaUbicacionPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaUbicacionPorSolicitudServicio(obeKardex)
    End Function


    Public Function ListaLotesPorSolicitudServicio(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaLotesPorSolicitudServicio(obeKardex)
    End Function

    Public Function ListaLotesPorOSPosicion(ByVal obeKardex As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaLotesPorOSPosicion(obeKardex)
    End Function


#Region "Deposito Simple por OS"
    ''' <summary>
    ''' Lista de Mercaderia por orden de servicios
    ''' </summary>
    ''' <param name="obeMercaderia"></param>    /*
    ''' 
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function flistListarMercaderiaOSNew(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistListarMercaderiaOSNew(obeMercaderia)
    End Function
    Public Function flistListarMercaderiaOS(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistListarMercaderiaOS(obeMercaderia)
    End Function

    Public Function fCargarPrimerRegistro(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fCargarPrimerRegistro(obeMercaderia)
    End Function

    Public Function flistListarMercaderiRansa(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistListarMercaderiRansa(obeMercaderia)
    End Function

    Public Function ListaContratosVigentes(ByVal obeContrato As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaContratosVigentes(obeContrato)
    End Function

    Public Function ListaFamiliaDeMercaderia(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaFamiliaDeMercaderia(obeMercaderia)
    End Function

    Public Function ListaGrupoDeMercaderia(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaGrupoDeMercaderia(obeMercaderia)
    End Function

    Public Function ListaMarca(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.ListaMarca(obeMercaderia)
    End Function

    Public Function fintCrearOrdenServicio(ByVal obeMercaderia As TYPEDEF.beMercaderia) As Integer
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fintCrearOrdenServicio(obeMercaderia)
    End Function

    Public Function fintActualizarOrdenServicio(ByVal obeMercaderia As TYPEDEF.beMercaderia) As Integer
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fintActualizarOrdenServicio(obeMercaderia)
    End Function

    Public Function fintObtener_NroGuiaRansa(ByVal ObeMercaderia As TYPEDEF.beMercaderia) As Decimal
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fintObtener_NroGuiaRansa(ObeMercaderia)
    End Function

    Public Function fintRecepcionMercaderia(ByRef olbeMercaderia As List(Of TYPEDEF.beMercaderia)) As Decimal
        Dim odaMercaderia As New daoMercaderia
        olbeMercaderia.Item(0).blnStatusDefinitivo = True
        olbeMercaderia.Item(0).PNCSRVC = 1
        olbeMercaderia.Item(0).PSSTPODP = "1"
        olbeMercaderia.Item(0).PNNGUIRN = fintObtener_NroGuiaRansa(olbeMercaderia.Item(0))
        If olbeMercaderia.Item(0).PNNGUIRN <> 0 Then
            If odaMercaderia.fintRecepcionMercaderia(olbeMercaderia) = 1 Then
                Return olbeMercaderia.Item(0).PNNGUIRN
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    Public Function fdsObtenerGuiaRecepcion(ByVal obeMercaderia As TYPEDEF.beMercaderia) As DataSet
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fdsObtenerGuiaRecepcion(obeMercaderia)
    End Function
    Public Function fdsObtenerGuiaSalida(ByVal obeMercaderia As TYPEDEF.beMercaderia) As DataSet
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fdsObtenerGuiaSalida(obeMercaderia)
    End Function

    Public Function fintDespachoMercaderia(ByRef olbeMercaderia As List(Of TYPEDEF.beMercaderia)) As Decimal
        Dim odaMercaderia As New daoMercaderia
        olbeMercaderia.Item(0).blnStatusDefinitivo = True
        olbeMercaderia.Item(0).PNCSRVC = 2
        olbeMercaderia.Item(0).PSSTPODP = "1"
        olbeMercaderia.Item(0).PNNGUIRN = fintObtener_NroGuiaRansa(olbeMercaderia.Item(0))
        If olbeMercaderia.Item(0).PNNGUIRN <> 0 Then
            If odaMercaderia.fintDespachoMercaderia(olbeMercaderia) = 1 Then
                Return olbeMercaderia.Item(0).PNNGUIRN
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Public Function fdtListaParaExportarOutotecRecepcion(ByVal pbeFiltro As TYPEDEF.beDespacho) As DataSet
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fdtListaParaExportarOutotecRecepcion(pbeFiltro)
    End Function

    Public Function fstrGuardarMercaderia(ByVal strUsuario As String, ByVal objNuevaMercaderia As slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia) As String
        Dim objMantenimiento As slnSOLMIN_SDS.MantenimientoSDS.Procesos.clsMantenimiento = New slnSOLMIN_SDS.MantenimientoSDS.Procesos.clsMantenimiento(strUsuario)
        Dim strMensajeError As String = String.Empty
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Mercaderia(strMensajeError, objNuevaMercaderia)
        If strMensajeError <> "" Then Return strMensajeError
        Return strMensajeError
    End Function


    Public Function fdtListar_OrdenesServicioPorMercaderia(ByVal intCliente As Int64, ByVal strMercaderia As String, ByRef pstrError As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        dtEntidad = slnSOLMIN_SDS.clsGeneral_SDS.fdtListar_OrdenServicioMercaderia(intCliente, strMercaderia, pstrError)
        Return dtEntidad
    End Function

    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function fdtListar_ContratosVigentes(ByVal strCliente As String, ByVal strTipoDeposito As String, ByRef pstrError As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        dtResultado = slnSOLMIN_SDS.RecepcionSDS.Procesos.clsRecepcion.fdtListar_ContratosVigentes(strCliente, strTipoDeposito, pstrError)
        Return dtResultado
    End Function

    'Public Function fblnCrearOrdenServicio(ByVal strUsuario As String, ByVal pstrPCName As String, ByVal objOrdenServicio As slnSOLMIN_SDS.clsCrearOrdenServicio, ByRef pstrError As String) As Boolean
    Public Function fblnCrearOrdenServicio(ByVal strUsuario As String, ByVal pstrPCName As String, ByVal objOrdenServicio As clsCrearOrdenServicio, ByRef pstrError As String) As Boolean
        Dim blnResultado As Boolean = True
        Dim objRecepcion As slnSOLMIN_SDS.clsGeneral_SDS = New slnSOLMIN_SDS.clsGeneral_SDS(strUsuario)
        blnResultado = objRecepcion.fblnCrearOrdenServicio(pstrError, objOrdenServicio, pstrPCName)
        Return blnResultado
    End Function

#End Region

#Region "Lista de Mercadería por pedido"

    Public Function flistListarMercaderiaPorPedido(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistListarMercaderiaPorPedido(obeMercaderia)
    End Function

    Public Function flistListarDetallePedidoPorOc(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistListarDetallePedidoPorOc(obeMercaderia)
    End Function

#End Region

#Region "Ubicación de mercadería"

    Public Function flistUbicacionesPorOSKardex(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistUbicacionesPorOSKardex(obeMercaderia)
    End Function

    Public Function fintInsertarPosicionMercaderia(ByVal obeUbicacionMerca As beMercaderia) As Integer
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fintInsertarPosicionMercaderia(obeUbicacionMerca)
    End Function
#End Region

#Region "Serie mercadería"

    Public Function flistSeriePorOS(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistSeriePorOS(obeMercaderia)
    End Function

    Public Function fintInsertarSerieMercaderia(ByVal obeUbicacionMerca As beMercaderia) As Integer
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.fintInsertarSerieMercaderia(obeUbicacionMerca)
    End Function

#End Region


#Region "Cambio de Código"

    Public Function flistStockMercaderiaPorCliente(ByVal obeMercaderia As TYPEDEF.beMercaderia) As List(Of TYPEDEF.beMercaderia)
        Dim odaMercaderia As New daoMercaderia
        Return odaMercaderia.flistStockMercaderiaPorCliente(obeMercaderia)
    End Function

    ''' <summary>
    ''' Generar cambio de código
    ''' </summary>
    ''' <param name="olbeMercaderia"></param>
    ''' <param name="pstrError"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fstrGenerarMercaderiaCambioCodigo(ByVal olbeMercaderia As List(Of TYPEDEF.beMercaderia), ByRef pstrError As String) As Integer

        '===========Verifica si existe Contrato Vigente. 
        Dim dtTemp As DataTable = fdtListar_ContratosVigentes(olbeMercaderia.Item(0).PNCCLNT, olbeMercaderia.Item(0).PSSTPODP, pstrError)

        'Si hay error ejecuta el siguiente código
        If pstrError.Length > 0 Then
            Return -1
        End If
        If dtTemp.Rows.Count <= 0 Then
            pstrError = "No existe información del contrato"
            Return -1
        End If
        '===========Verifica si existe Contrato Vigente. 

        '===============Genera el despacho ===============================
        olbeMercaderia.Item(0).PNNGUIRN = fintDespachoMercaderia(olbeMercaderia)
        If olbeMercaderia.Item(0).PNNGUIRN = 0 Then
            pstrError = "Error producido en la operación de despacho"
            Return -1
        End If

        '============== Despacho de Ubicación
        Dim olistUbicacion As List(Of beMercaderia)
        For Each obeMercaUbicacion As beMercaderia In olbeMercaderia
            olistUbicacion = New List(Of beMercaderia)
            olistUbicacion = flistUbicacionesPorOSKardex(obeMercaUbicacion)

            'Si hay error ejecuta la consulta de mercaderia ubicación
            If olistUbicacion Is Nothing Then
                pstrError = "Error producido al consultar la ubicación"
                Return -1
            End If

            If olistUbicacion.Count > 0 Then
                'Proceso de despacho de ubicación
                For Each obeUbicacion As beMercaderia In olistUbicacion
                    obeUbicacion.PNCSRVC = 2
                    obeUbicacion.PNNGUIRN = olbeMercaderia.Item(0).PNNGUIRN
                    If fintInsertarPosicionMercaderia(obeUbicacion) = -1 Then
                        pstrError = "Error al despachar la ubicación"
                        Return -1
                    End If
                Next

            End If
            obeMercaUbicacion.Ubicacion = olistUbicacion

        Next
        '============== Despacho de Ubicación

        '============== Despacho de serie 
        Dim olistSerie As List(Of beMercaderia)
        For Each obeMercaSerie As beMercaderia In olbeMercaderia
            olistSerie = New List(Of beMercaderia)
            olistSerie = flistSeriePorOS(obeMercaSerie)

            'Si hay error ejecuta la consulta de mercaderia ubicación
            If olistSerie Is Nothing Then
                pstrError = "Error producido al consultar la ubicación"
                Return -1
            End If

            If olistSerie.Count > 0 Then
                'Proceso de despacho de ubicación
                For Each obeSerie As beMercaderia In olistSerie
                    obeSerie.PNNGUIRN = olbeMercaderia.Item(0).PNNGUIRN
                    obeSerie.PSFSLDAL = obeMercaSerie.PNFRLZSR
                    obeSerie.PSSTPING = obeMercaSerie.PSSTPING
                    obeSerie.PSSSTINV = "2" 'Despacho
                    obeSerie.PSUSUARIO = obeMercaSerie.PSUSUARIO
                    obeSerie.PNNSLCSR = obeMercaSerie.PNNSLCSR

                    If fintInsertarSerieMercaderia(obeSerie) = -1 Then
                        pstrError = "Error al despachar la ubicación"
                        Return -1
                    End If
                Next

            End If
            obeMercaSerie.Serie = olistSerie
        Next
        '============== Despacho de serie


        '===============Genera el despacho ===============================

        '============== creación de variable para el ingreso ================= 
        Dim obeOrdenCompra As beOrdenCompra = New beOrdenCompra
        Dim objBrProveedor As brProveedor = New brProveedor
        Dim objBrOC As brOrdenDeCompra = New brOrdenDeCompra
        Dim TD_Item As OrdenCompra.ItemOC.TD_ItemOC = New OrdenCompra.ItemOC.TD_ItemOC
        Dim CodProv As Decimal = 0
        Dim DesItem As String = ""
        obeOrdenCompra.PNCCLNT = olbeMercaderia.Item(0).PNCCLNT
        obeOrdenCompra.PNGUIRN = olbeMercaderia.Item(0).PNNGUIRN
        '============== creación de variable para el ingreso ================= 


        '========== Creamos la OC con el Nro. de guía Ransa ===================
        With obeOrdenCompra
            .PNCCLNT = olbeMercaderia.Item(0).PNCCLNT
            .PSNORCML = "GS-" & Convert.ToString(olbeMercaderia.Item(0).PNNGUIRN)
            .PSTPOOCM = ""
            .PNFORCML = olbeMercaderia.Item(0).PNFRLZSR
            .PNFSOLIC = olbeMercaderia.Item(0).PNFRLZSR
            .PNCPRVCL = 0 'olbeMercaderia.Item(0).PSCPRVCL 'CodProv
            .PSTDSCML = "" 'DesItem
            .PSTCMAEM = ""
            .PSTTINTC = "LOC"
            .PSNREFCL = ""
            .PSTPAGME = ""
            .PSREFDO1 = ""
            .PNNTPDES = 1
            .PNCMNDA1 = 100
            .PSTEMPFAC = ""
            .PSTNOMCOM = ""
            .PSTCTCST = ""
            .PSCREGEMB = ""
            .PNCMEDTR = 4
            .PSTDEFIN = ""
            .PSTCNDPG = ""
            .PNIVCOTO = 0
            .PNIVTOCO = 0
            .PNIVTOIM = 0
            .PSTDAITM = olbeMercaderia.Item(0).PSUSUARIO
            .PSCUSCRT = olbeMercaderia.Item(0).PSUSUARIO
            .PSCULUSA = olbeMercaderia.Item(0).PSUSUARIO
            .PSTPOOCM = ""
        End With
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)
        '========== Creamos la OC con el Nro. de guía Ransa ===================

        If rpta = 1 Then

            ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
            Dim intItem As Integer = 10
            For Each obOC As beMercaderia In olbeMercaderia
                With TD_Item
                    .pCCLNT_CodigoCliente = olbeMercaderia.Item(0).PNCCLNT
                    .pNORCML_NroOrdenCompra = "GS-" & Convert.ToString(olbeMercaderia.Item(0).PNNGUIRN)
                    .pNRITOC_NroItemOC = intItem
                    .pTCITCL_CodigoCliente = obOC.PSCMRCLR_NEW
                    .pTDITES_DescripcionES = obOC.PSTMRCD2
                    .pTDITIN_DescripcionIN = obOC.PSTMRCD3
                    .pQCNTIT_Cantidad = obOC.PNQTRMC
                    .pTUNDIT_Unidad = obOC.PSCUNCN5_NEW
                    .pIVUNIT_ImporteUnitario = 0
                    .pIVTOIT_ImporteTotal = 0
                    .pQTOLMAX_ToleranciaMax = 0
                    .pQTOLMIN_ToleranciaMin = 0
                    .pFMPDME_FechaEstEntregaDte = Now.Date
                    .pFMPIME_FechaReqPlantaDte = Now.Date
                    .pTLUGOR_LugarOrigen = ""
                    .pTLUGEN_LugarEntrega = ""
                    .pTCTCST_CentroDeCosto = ""
                    .pTRFRN_RefSolicitante = ""
                    .pFLGPEN_FlagSeguimiento = ""

                    'Actualizamos el registro 
                    obOC.PNNRITOC = intItem
                    obOC.PSNORCCL = .pNORCML_NroOrdenCompra


                End With
                Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
                Dim strUsuario As String = olbeMercaderia.Item(0).PSUSUARIO
                Dim brpta As Boolean = RANSA.DAO.OrdenCompra.cItemOrdenCompra.Grabar(objSqlManager, TD_Item, strUsuario, pstrError)

                If brpta = False Then
                    Return -1
                End If

                ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
                intItem += 10
            Next

        Else
            pstrError = "Error al registrar la OC"
            Return -1
        End If


        'Verificar si existe Codigo de Mercaderia
        Dim obrMercaderia As brMercaderia = New brMercaderia
        Dim obeMercaderia As beMercaderia

        For Each obOCItem As beMercaderia In olbeMercaderia

            '=============== Buscamos si existe el material creado anteriormente ===============
            obeMercaderia = New beMercaderia
            obeMercaderia.PNCCLNT = olbeMercaderia.Item(0).PNCCLNT
            obeMercaderia.PSCMRCLR = obOCItem.PSCMRCLR_NEW.Trim
            Dim oListMercaderia As New List(Of beMercaderia)
            oListMercaderia = obrMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)

            'Si no existe inserta mercaderia
            If oListMercaderia.Count = 0 Then
                Dim oclsMercaderia As New slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia
                With oclsMercaderia
                    .pintCodigoCliente_CCLNT = olbeMercaderia.Item(0).PNCCLNT
                    .pstrCodigoFamilia_CFMCLR = obOCItem.PSCFMCLR
                    .pstrCodigoGrupo_CGRCLR = obOCItem.PSCGRCLR
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR_NEW.ToString.Trim
                    .pstrCodigoMercaderiaReemplazo_CMRCRR = obOCItem.PSCMRCLR
                    .pstrCodigoRANSA_CMRCD = "1501390000"
                    .pstrDescripcion_TMRCD2 = obOCItem.PSTMRCD2
                    .pstrDescripcion_TMRCD3 = obOCItem.PSTMRCD3
                    .pintProveedor_CPRVCL = 7988
                    .pintCodigoMoneda_CMNCT = 100
                    Decimal.TryParse(0.0, .pdecImporteCosto_QIMCT)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedio_QIMCTP)
                    Decimal.TryParse(0.0, .pdecImporteCostoPromedioSoles_QICOPS)
                    .pblnMarcaReembolso_MARCRE = False
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAD)
                    Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAS)
                    Decimal.TryParse("0.000", .pdecImportePorMts2_IMVLM2)
                    Decimal.TryParse("0.00", .pdecPorcentajeDescuento_PDSCTO)
                    .pstrMarcaModelo_TMRCTR = ""
                    .pstrUbicacion_UBICA1 = ""
                    .pstrObservacion_TOBSRV = ""
                    Decimal.TryParse("0.000", .pdecCantidadMinimaReqServicio_QMRSRC)
                    Decimal.TryParse("0.000", .pdecPesoMinimoReqServicio_QMRSRP)
                    Decimal.TryParse("0.000", .pdecCantidadMercaderiaPtoReorden_QMRODC)
                    Decimal.TryParse("0.000", .pdecPesoMercaderiaPtoReorden_QMRODP)
                    Decimal.TryParse("0.000", .pdecLargoMercaderia_QLRGMR)
                    Decimal.TryParse("0.000", .pdecAnchoMercaderia_QANCMR)
                    Decimal.TryParse("0.000", .pdecAlturaMercaderia_QALTMR)
                    Decimal.TryParse("0.000", .pdecAreaMts2_QARMT2)
                    Decimal.TryParse("0.000", .pdecVolumenMts3_QARMT3)
                    Decimal.TryParse("0.000", .pdecVolumenEquivalente_QVOLEQ)
                    Decimal.TryParse("0.000", .pdecCantidadPesoDeclarado_QPSODC)
                    Decimal.TryParse("0.000", .pdecTiempoCargaMercaderia_QTMPCR)
                    Decimal.TryParse("0.000", .pdecTiempoDesargaMercaderia_QTMPDS)
                    .pblnStatusPublicacionWEB_FPUWEB = False
                    .pstrUnidad_CUNCNC = ""
                    .pstrUnidadInventario_CUNCNI = "N"
                    Date.TryParse("0", .pdteFechaVencimiento_FVNCMR)
                    Date.TryParse("0", .pdteFechaInventario_FINVRN)
                    .pstrCodigoPerfumancia_CPRFMR = ""
                    .pstrCodigoInflamabilidad_CINFMR = ""
                    .pstrCodigoRotacion_CROTMR = ""
                    .pstrCodigoApilabilidad_CAPIMR = ""
                    .pstrCodigoDUN14 = ""
                    .pstrCodigoEAN13 = ""
                    Decimal.TryParse("", .pdecCantidadMinimaProducir_QMRPRD)
                    .CPTDAR_PartidaArancelaria = ""
                    .SCNTSR_MarcaControlSerie = IIf(False, "X", "")
                End With

                pstrError = fstrGuardarMercaderia(olbeMercaderia.Item(0).PSUSUARIO, oclsMercaderia)
                If pstrError.Length > 0 Then
                    Return -1
                End If
                oclsMercaderia = Nothing
            End If
            '=============== Buscamos si existe el material creado anteriormente ===============


            '=============== Verificar si existe OS ==============
            Dim blnResultado As Boolean = True
            Dim DtServicio As DataTable = fdtListar_OrdenesServicioPorMercaderia(olbeMercaderia.Item(0).PNCCLNT, obOCItem.PSCMRCLR_NEW.Trim, pstrError)
            'Si hay error ejecuta el siguiente código
            If pstrError.Length > 0 Then
                Return -1
            End If
            '=============== Verificar si existe OS ==============

            If DtServicio.Rows.Count = 0 Then

                '=============== Si no existe OS , se crea  ==============

                'Dim objNuevaOrdenServicio As slnSOLMIN_SDS.clsCrearOrdenServicio = New slnSOLMIN_SDS.clsCrearOrdenServicio
                Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
                With objNuevaOrdenServicio
                    .pintCodigoCliente_CCLNT = olbeMercaderia.Item(0).PNCCLNT
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR_NEW.Trim
                    .pintNroContrato_NCNTR = Convert.ToInt64(dtTemp.Rows(0).Item("NCNTR").ToString.Trim)
                    .pstrTipoDeposito_CTPDP3 = dtTemp.Rows(0).Item("CTPDP3").ToString.Trim
                    .pstrProducto_CTPPR1 = dtTemp.Rows(0).Item("CTPPR1").ToString.Trim
                    .pdecCantidadDeclarada_QMRCD = 1
                    .pstrUnidadCantidad_CUNCND = obOCItem.PSCUNCN5_NEW.Trim
                    .pdecPesoDeclarado_QPSMR = 1
                    .pstrUnidadPeso_CUNPS0 = "KGS"
                    .pdecValorDeclarado_QVLMR = 1
                    .pstrUnidadValor_CUNVLR = "DOL"
                    .pstrControlLotes_FUNCTL = "N"
                    .pstrUnidadDespacho_FUNDS = "C"
                End With


                'Creamos los OS.
                blnResultado = fblnCrearOrdenServicio(olbeMercaderia.Item(0).PSUSUARIO, olbeMercaderia.Item(0).PSNTRMNL, objNuevaOrdenServicio, pstrError)

                'Si hay error ejecuta el siguiente código
                If pstrError.Length > 0 Then
                    Return -1
                End If
                objNuevaOrdenServicio = Nothing
                If blnResultado = False Then
                    pstrError = "No se registró la Orden de Servicio"
                    Return -1
                End If
                '=============== Si no existe OS , se crea  ==============

                '============== Asigna el valor de la OS
                DtServicio = fdtListar_OrdenesServicioPorMercaderia(olbeMercaderia.Item(0).PNCCLNT, obOCItem.PSCMRCLR_NEW.Trim, pstrError)
                'Si hay error ejecuta el siguiente código
                If pstrError.Length > 0 Then
                    Return -1
                End If
                obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                '============== Asigna el valor de la OS

            Else
                '============== Asigna el valor de la OS
                obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                '============== Asigna el valor de la OS
            End If
        Next

        For Each obeMerca As beMercaderia In olbeMercaderia

            obeMerca.PSSTPING = "K" ''Cambio de código
            obeMerca.PSCMRCLR = obeMerca.PSCMRCLR_NEW.Trim
            obeMerca.PSCUNCN5 = obeMerca.PSCUNCN5_NEW
            obeMerca.PSTIPORI = "PS"
            obeMerca.PSNGUICL = olbeMercaderia.Item(0).PNNGUIRN
            'Dim DtServicio As DataTable = fdtListar_OrdenesServicioPorMercaderia(olbeMercaderia.Item(0).PNCCLNT, obeMerca.PSCMRCLR, pstrError)
            ''Si hay error ejecuta el siguiente código
            'If pstrError.Length > 0 Then
            '    Return -1
            'End If
            'obeMerca.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")

        Next

        '==========Ejecutamos el proceso de recepcion
        Dim intNroRecepcion As Decimal = 0
        intNroRecepcion = fintRecepcionMercaderia(olbeMercaderia)
        If intNroRecepcion = 0 Then
            pstrError = "Error producido en la operación de recepción"
            Return -1
        End If

        '=============Ejecutamos el proceso de recepción de Ubicación
        For Each obeMerca As beMercaderia In olbeMercaderia
            'Proceso de recepción de ubicación
            If obeMerca.Ubicacion IsNot Nothing Then
                For Each obeUbicacion As beMercaderia In obeMerca.Ubicacion
                    obeUbicacion.PNCSRVC = 1
                    obeUbicacion.PNNGUIRN = intNroRecepcion
                    obeUbicacion.PNNORDSR = obeMerca.PNNORDSR
                    If fintInsertarPosicionMercaderia(obeUbicacion) = -1 Then
                        pstrError = "Error al despachar la ubicación"
                        Return -1
                    End If
                Next
            End If
            If obeMerca.Serie IsNot Nothing Then
                'Proceso de despacho de ubicación
                For Each obeSerie As beMercaderia In obeMerca.Serie
                    obeSerie.PNNGUIRN = intNroRecepcion
                    obeSerie.PNNORDSR = obeMerca.PNNORDSR
                    obeSerie.PNNSLCSR = obeMerca.PNNSLCSR
                    obeSerie.PSFINGAL = obeMerca.PNFRLZSR
                    obeSerie.PSSTPING = obeMerca.PSSTPING
                    obeSerie.PSSSTINV = "1" 'Recepcion
                    obeSerie.PSUSUARIO = obeMerca.PSUSUARIO


                    If fintInsertarSerieMercaderia(obeSerie) = -1 Then
                        pstrError = "Error al despachar la ubicación"
                        Return -1
                    End If
                Next
            End If

        Next
        '=============Ejecutamos el proceso de recepción de Ubicación





        Return intNroRecepcion
    End Function

    'culpables Jm & Az
    Public Function GenerarMercaderiaInterfazSap(ByVal olbeMercaderia As DataSet, ByVal pUser As String, ByVal pstrTipoAlmacen As String, ByVal pstrTerminal As String, ByRef pstrError As String) As Integer
        Try

            Dim obrMercaderia As brMercaderia = New brMercaderia
            Dim obeMercaderia As beMercaderia

            Dim oDtCabecera As New DataTable("Cabecera")
            Dim oDtDetalle As New DataTable("Detalle")
            If olbeMercaderia.Tables.Count > 0 Then
                oDtCabecera = olbeMercaderia.Tables(0) 'Cabecera
                oDtDetalle = olbeMercaderia.Tables(1) 'Detalle
            Else
                Return 0
            End If

            '===========Verifica si existe Contrato Vigente. 
            Dim dtTemp As DataTable = fdtListar_ContratosVigentes(oDtCabecera.Rows(0)("CCLNT"), pstrTipoAlmacen, pstrError)

            'Si hay error ejecuta el siguiente código
            If pstrError.Length > 0 Then
                Return -1
            End If
            If dtTemp.Rows.Count <= 0 Then
                pstrError = "No existe información del contrato"
                Return -1
            End If
            '===========Verifica si existe Contrato Vigente. 

            'Verificar si existe Codigo de Mercaderia
            For Each obOCItem As DataRow In oDtDetalle.Rows

                '=============== Buscamos si existe el material creado anteriormente ===============
                obeMercaderia = New beMercaderia
                obeMercaderia.PNCCLNT = oDtCabecera.Rows(0)("CCLNT")
                obeMercaderia.PSCMRCLR = obOCItem("CODMAT")
                Dim oListMercaderia As New List(Of beMercaderia)
                'Valida si la mercaderaia existe para el cliente ---------------------------
                oListMercaderia = obrMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)
                Dim DtFamilia As New DataTable
                Dim DtGrupo As New DataTable

                DtFamilia = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Familia("", Val(oDtCabecera.Rows(0)("CCLNT")), "")
                DtGrupo = slnSOLMIN_SDS.clsGeneral_SDS.fdtBuscar_Grupo("", oDtCabecera.Rows(0)("CCLNT"), DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim, "")
                '----------------------------------------------------------------------------
                'Si no existe inserta mercaderia
                If oListMercaderia.Count = 0 Then
                    Dim oclsMercaderia As New slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia
                    With oclsMercaderia
                        .pintCodigoCliente_CCLNT = obOCItem("CCLNT")
                        .pstrCodigoFamilia_CFMCLR = DtFamilia.Rows(0).Item("FAMILIA").ToString.Trim
                        .pstrCodigoGrupo_CGRCLR = DtGrupo.Rows(0).Item("GRUPO").ToString.Trim
                        .pstrCodigoMercaderia_CMRCLR = obOCItem("CODMAT").ToString
                        .pstrCodigoRANSA_CMRCD = "9999999999"
                        .pstrDescripcion_TMRCD2 = obOCItem("DESMAT")
                        .pstrDescripcion_TMRCD3 = String.Empty
                        .pintProveedor_CPRVCL = 7988
                        .pintCodigoMoneda_CMNCT = 100
                        Decimal.TryParse(0.0, .pdecImporteCosto_QIMCT)
                        Decimal.TryParse(0.0, .pdecImporteCostoPromedio_QIMCTP)
                        Decimal.TryParse(0.0, .pdecImporteCostoPromedioSoles_QICOPS)
                        .pblnMarcaReembolso_MARCRE = False
                        Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAD)
                        Decimal.TryParse("0.000", .pdecImporteVentaDolar_IMVTAS)
                        Decimal.TryParse("0.000", .pdecImportePorMts2_IMVLM2)
                        Decimal.TryParse("0.00", .pdecPorcentajeDescuento_PDSCTO)
                        .pstrMarcaModelo_TMRCTR = ""
                        .pstrUbicacion_UBICA1 = ""
                        .pstrObservacion_TOBSRV = ""
                        Decimal.TryParse("0.000", .pdecCantidadMinimaReqServicio_QMRSRC)
                        Decimal.TryParse("0.000", .pdecPesoMinimoReqServicio_QMRSRP)
                        Decimal.TryParse("0.000", .pdecCantidadMercaderiaPtoReorden_QMRODC)
                        Decimal.TryParse("0.000", .pdecPesoMercaderiaPtoReorden_QMRODP)
                        Decimal.TryParse("0.000", .pdecLargoMercaderia_QLRGMR)
                        Decimal.TryParse("0.000", .pdecAnchoMercaderia_QANCMR)
                        Decimal.TryParse("0.000", .pdecAlturaMercaderia_QALTMR)
                        Decimal.TryParse("0.000", .pdecAreaMts2_QARMT2)
                        Decimal.TryParse("0.000", .pdecVolumenMts3_QARMT3)
                        Decimal.TryParse("0.000", .pdecVolumenEquivalente_QVOLEQ)
                        Decimal.TryParse("0.000", .pdecCantidadPesoDeclarado_QPSODC)
                        Decimal.TryParse("0.000", .pdecTiempoCargaMercaderia_QTMPCR)
                        Decimal.TryParse("0.000", .pdecTiempoDesargaMercaderia_QTMPDS)
                        .pblnStatusPublicacionWEB_FPUWEB = False
                        .pstrUnidad_CUNCNC = ""
                        .pstrUnidadInventario_CUNCNI = "N"
                        Date.TryParse("0", .pdteFechaVencimiento_FVNCMR)
                        Date.TryParse("0", .pdteFechaInventario_FINVRN)
                        .pstrCodigoPerfumancia_CPRFMR = ""
                        .pstrCodigoInflamabilidad_CINFMR = ""
                        .pstrCodigoRotacion_CROTMR = ""
                        .pstrCodigoApilabilidad_CAPIMR = ""
                        .pstrCodigoDUN14 = ""
                        .pstrCodigoEAN13 = ""
                        Decimal.TryParse("", .pdecCantidadMinimaProducir_QMRPRD)
                        .CPTDAR_PartidaArancelaria = ""
                        .SCNTSR_MarcaControlSerie = IIf(False, "X", "")
                        .FUNCTL = ""
                    End With

                    pstrError = fstrGuardarMercaderia(pUser, oclsMercaderia)
                    If pstrError.Length > 0 Then
                        pstrError = "Error al grabar  mercadería: " & obOCItem("CODMAT").ToString
                        Return -1

                    End If
                    oclsMercaderia = Nothing
                End If
                '=============== Buscamos si existe el material creado anteriormente ===============


                '=============== Verificar si existe OS ==============
                Dim blnResultado As Boolean = True
                Dim DtServicio As DataTable = fdtListar_OrdenesServicioPorMercaderia(oDtCabecera.Rows(0)("CCLNT"), obOCItem("CODMAT").ToString, pstrError)
                'Si hay error ejecuta el siguiente código
                If pstrError.Length > 0 Then
                    Return -1
                End If
                '=============== Verificar si existe OS ==============

                If DtServicio.Rows.Count = 0 Then

                    '=============== Si no existe OS , se crea  ==============
                    Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
                    'Dim objNuevaOrdenServicio As slnSOLMIN_SDS.clsCrearOrdenServicio = New slnSOLMIN_SDS.clsCrearOrdenServicio
                    With objNuevaOrdenServicio
                        .pintCodigoCliente_CCLNT = oDtCabecera.Rows(0)("CCLNT")
                        .pstrCodigoMercaderia_CMRCLR = obOCItem("CODMAT").ToString
                        .pintNroContrato_NCNTR = Convert.ToInt64(dtTemp.Rows(0).Item("NCNTR").ToString.Trim)
                        .pstrTipoDeposito_CTPDP3 = dtTemp.Rows(0).Item("CTPDP3").ToString.Trim
                        .pstrProducto_CTPPR1 = dtTemp.Rows(0).Item("CTPPR1").ToString.Trim
                        .pdecCantidadDeclarada_QMRCD = 1
                        .pstrUnidadCantidad_CUNCND = obOCItem("UNIMED").ToString
                        .pdecPesoDeclarado_QPSMR = 1
                        .pstrUnidadPeso_CUNPS0 = "KGS"
                        .pdecValorDeclarado_QVLMR = 1
                        .pstrUnidadValor_CUNVLR = "DOL"
                        .pstrControlLotes_FUNCTL = "N"
                        .pstrUnidadDespacho_FUNDS = "C"
                    End With


                    'Creamos los OS.
                    blnResultado = fblnCrearOrdenServicio(pUser, pstrTerminal, objNuevaOrdenServicio, pstrError)

                    'Si hay error ejecuta el siguiente código
                    If pstrError.Length > 0 Then
                        Return -1
                    End If
                    objNuevaOrdenServicio = Nothing
                    If blnResultado = False Then
                        pstrError = "No se registró la Orden de Servicio"
                        Return -1
                    End If
                    '=============== Si no existe OS , se crea  ==============

                    '============== Asigna el valor de la OS
                    DtServicio = fdtListar_OrdenesServicioPorMercaderia(oDtCabecera.Rows(0)("CCLNT"), obOCItem("CODMAT").ToString, pstrError)
                    'Si hay error ejecuta el siguiente código
                    If pstrError.Length > 0 Then
                        Return -1
                    End If
                    'obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                    '============== Asigna el valor de la OS

                    'Else
                    '============== Asigna el valor de la OS
                    'obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                    '============== Asigna el valor de la OS
                End If
            Next

            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function


    Public Function fListUnidadesMedidaOS() As DataSet
        Dim ds As New DataSet
        Dim odaMercaderia As New daoMercaderia
        ds = odaMercaderia.fListUnidadesMedidaOS()
        Return ds
    End Function
    Public Function fListContratosVigentesxCliente(ByVal obeMercaderia As TYPEDEF.beMercaderia) As DataTable
        Dim dt As New DataTable
        Dim odaMercaderia As New daoMercaderia
        dt = odaMercaderia.fListContratosVigentesxCliente(obeMercaderia)
        Return dt
    End Function

    Public Function fListOrdenServicioxSKU(ByVal obeMercaderia As TYPEDEF.beMercaderia) As DataTable
        Dim dt As New DataTable
        Dim odaMercaderia As New daoMercaderia
        dt = odaMercaderia.fListOrdenServicioxSKU(obeMercaderia)
        Return dt
    End Function

    Public Function fListValidarCrearOS_SKU(ByVal obeMercaderia As TYPEDEF.beMercaderia) As String
        Dim msg As String = ""
        Dim odaMercaderia As New daoMercaderia
        msg = odaMercaderia.fListValidarCrearOS_SKU(obeMercaderia)
        Return msg
    End Function
    Public Function fListOrdenServicioSKU_Ubicacion(ByVal obeMercaderia As TYPEDEF.beMercaderia) As DataSet
        Dim ds As New DataSet
        Dim odaMercaderia As New daoMercaderia
        ds = odaMercaderia.fListOrdenServicioSKU_Ubicacion(obeMercaderia)
        Return ds
    End Function


#End Region






End Class