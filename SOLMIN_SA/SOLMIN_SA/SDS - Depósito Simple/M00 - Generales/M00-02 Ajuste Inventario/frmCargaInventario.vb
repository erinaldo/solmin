
Imports Ransa.TypeDef.Cliente
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario
Imports Ransa.TypeDef.beMercaderia
Imports Ransa.NEGO.brMercaderia
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE

Public Class frmCargaInventario


    Private Cliente As New Ransa.Controls.Cliente.ucCliente_TxtF01
    Private obrMercaderia As Ransa.NEGO.brMercaderia
    Private olbeMercaderia As New List(Of beMercaderia)

    Public Sub New(ByVal _cliente As Ransa.Controls.Cliente.ucCliente_TxtF01, ByVal _olbeMercaderia As List(Of beMercaderia))

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cliente = _cliente
        olbeMercaderia = _olbeMercaderia

    End Sub

    Private Sub frmCargaInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvResumen.AutoGenerateColumns = False
            dgvResumen.DataSource = olbeMercaderia
            txtFechaDespacho.Value = Now
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try

            Dim pstrError As String = String.Empty

            If txtFechaDespacho.Value.ToString = String.Empty Then
                MessageBox.Show("Ingrese Fecha de despacho", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim result As Integer = CargarInventarioMasivo(pstrError)

            If result < 0 Then
                MessageBox.Show(pstrError)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function CargarInventarioMasivo(ByRef pstrError As String) As Integer

        Dim obrMercaderia = New brMercaderia
        Dim USUARIO As String = objSeguridadBN.pUsuario
        Dim TERMINAL As String = HelpClass.NombreMaquina

        '===========Verifica si existe Contrato Vigente. 
        Dim dtTemp As DataTable = obrMercaderia.fdtListar_ContratosVigentes(Cliente.pCodigo, objSeguridadBN.pstrTipoAlmacen, pstrError)

        'Si hay error ejecuta el siguiente código
        If pstrError.Length > 0 Then
            Return -1
        End If
        If dtTemp.Rows.Count <= 0 Then
            pstrError = "No existe información del contrato"
            Return -1
        End If
        '===========Verifica si existe Contrato Vigente. 

        '========== Creamos la OC  ===================
        Dim strOC As String = "REGMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric
        Dim obeOrdenCompra As New beOrdenCompra
        With obeOrdenCompra
            .PNCCLNT = Cliente.pCodigo
            .PSNORCML = strOC '"CM-" & Now.ToString("yyyyMMdd")
            .PSTPOOCM = ""
            .PNFORCML = Now.ToString("yyyyMMdd")
            .PNFSOLIC = Now.ToString("yyyyMMdd")
            .PNCPRVCL = 0
            .PSTDSCML = txtDescripcion.Text.Trim
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
            .PSTDAITM = ""
            .PSCUSCRT = USUARIO
            .PSCULUSA = USUARIO
            .PSTPOOCM = ""
        End With
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)
        '========== Creamos la OC con el Nro. de guía Ransa ===================

        If rpta = 1 Then

            ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
            Dim intItem As Integer = 10
            Dim TD_Item As OrdenCompra.ItemOC.TD_ItemOC

            For Each obOC As beMercaderia In olbeMercaderia
                TD_Item = New OrdenCompra.ItemOC.TD_ItemOC
                With TD_Item
                    .pCCLNT_CodigoCliente = Cliente.pCodigo  'olbeMercaderia.Item(0).PNCCLNT
                    .pNORCML_NroOrdenCompra = strOC '"REGMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric 'txtOrdenCompra.Text.Trim
                    .pNRITOC_NroItemOC = intItem
                    .pTCITCL_CodigoCliente = obOC.PSCMRCLR_NEW
                    .pTDITES_DescripcionES = txtDescripcion.Text.Trim
                    .pTDITIN_DescripcionIN = ""
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
                Dim brpta As Boolean = True
                brpta = Ransa.DAO.OrdenCompra.cItemOrdenCompra.Grabar(objSqlManager, TD_Item, USUARIO, pstrError)

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

        Dim obeMercaderia As beMercaderia
        For Each obOCItem As beMercaderia In olbeMercaderia



            '=============== Buscamos si existe el material creado anteriormente ===============
            obeMercaderia = New beMercaderia
            obeMercaderia.PNCCLNT = Cliente.pCodigo
            obeMercaderia.PSCMRCLR = obOCItem.PSCMRCLR_NEW.Trim
            Dim oListMercaderia As New List(Of beMercaderia)
            oListMercaderia = obrMercaderia.ListaMercaderiaPorClienteItem(obeMercaderia)

            'Si no existe inserta mercaderia
            If oListMercaderia.Count = 0 Then
                Dim oclsMercaderia As New slnSOLMIN_SDS.MantenimientoSDS.clsMercaderia
                With oclsMercaderia
                    .pintCodigoCliente_CCLNT = Cliente.pCodigo
                    .pstrCodigoFamilia_CFMCLR = obOCItem.PSCFMCLR
                    .pstrCodigoGrupo_CGRCLR = obOCItem.PSCGRCLR
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR_NEW.ToString.Trim
                    .pstrCodigoMercaderiaReemplazo_CMRCRR = ""
                    .pstrCodigoRANSA_CMRCD = "1501390000"
                    .pstrDescripcion_TMRCD2 = obOCItem.PSTMRCD2
                    .pstrDescripcion_TMRCD3 = ""
                    '.pintProveedor_CPRVCL = 7988
                    .pintProveedor_CPRVCL = 0
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
                    .pstrUnidadInventario_CUNCNI = ""
                    Date.TryParse("0", .pdteFechaVencimiento_FVNCMR)
                    Date.TryParse("0", .pdteFechaInventario_FINVRN)
                    .pstrCodigoPerfumancia_CPRFMR = ""
                    .pstrCodigoInflamabilidad_CINFMR = ""
                    .pstrCodigoRotacion_CROTMR = ""
                    .pstrCodigoApilabilidad_CAPIMR = ""
                    .pstrCodigoDUN14 = ""
                    .pstrCodigoEAN13 = ""
                    Decimal.TryParse("0", .pdecCantidadMinimaProducir_QMRPRD)
                    .CPTDAR_PartidaArancelaria = ""
                    .SCNTSR_MarcaControlSerie = ""
                End With

                pstrError = obrMercaderia.fstrGuardarMercaderia(USUARIO, oclsMercaderia)
                If pstrError.Length > 0 Then
                    Return -1
                End If
                oclsMercaderia = Nothing
            End If
            '=============== Buscamos si existe el material creado anteriormente ===============


            '=============== Verificar si existe OS ==============
            Dim blnResultado As Boolean = True
            Dim DtServicio As DataTable = obrMercaderia.fdtListar_OrdenesServicioPorMercaderia(Cliente.pCodigo, obOCItem.PSCMRCLR_NEW.Trim, pstrError)
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

                    .pintCodigoCliente_CCLNT = Cliente.pCodigo
                    .pstrCodigoMercaderia_CMRCLR = obOCItem.PSCMRCLR_NEW.ToString.Trim

                    .pintNroContrato_NCNTR = Convert.ToInt64(dtTemp.Rows(0).Item("NCNTR").ToString.Trim)
                    .pstrTipoDeposito_CTPDP3 = dtTemp.Rows(0).Item("CTPDP3").ToString.Trim
                    .pstrProducto_CTPPR1 = dtTemp.Rows(0).Item("CTPPR1").ToString.Trim

                    .pdecCantidadDeclarada_QMRCD = 1
                    .pstrUnidadCantidad_CUNCND = "UNI"
                    .pdecPesoDeclarado_QPSMR = 1
                    .pstrUnidadPeso_CUNPS0 = "KGS"
                    .pdecValorDeclarado_QVLMR = 1
                    .pstrUnidadValor_CUNVLR = "DOL"
                    .pstrControlLotes_FUNCTL = "N"
                    .pstrUnidadDespacho_FUNDS = "C"
                End With

                'Creamos los OS.
                blnResultado = obrMercaderia.fblnCrearOrdenServicio(USUARIO, TERMINAL, objNuevaOrdenServicio, pstrError)

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
                DtServicio = obrMercaderia.fdtListar_OrdenesServicioPorMercaderia(Cliente.pCodigo, obOCItem.PSCMRCLR_NEW.Trim, pstrError)
                'Si hay error ejecuta el siguiente código
                If pstrError.Length > 0 Then
                    Return -1
                End If
                obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")

                obOCItem.PNNCNTR = Val("" & DtServicio.Rows(0).Item("NCNTR")) ' debe ser actualizado  contrato
                obOCItem.PNNCRCTC = Val("" & DtServicio.Rows(0).Item("NCRCTC"))  ' debe ser actualizado contrato
                obOCItem.PNNAUTR = Val("" & DtServicio.Rows(0).Item("NAUTR"))  ' debe ser actualizado contrato
                obOCItem.PSCUNCNT = ("" & DtServicio.Rows(0).Item("CUNCN5")).ToString.Trim   ' .PSCUNCN5 ' debe ser actualizado  contrato
                obOCItem.PSCUNPST = ("" & DtServicio.Rows(0).Item("CUNPS5")).ToString.Trim   ' .PSCUNPS5 ' debe ser actualizado  contrato
                obOCItem.pSCUNVLT = ("" & DtServicio.Rows(0).Item("CUNVL5")).ToString.Trim   ' .PSCUNVL5 ' debe ser actualizado  contrato

                obOCItem.PSFUNDS2 = ("" & DtServicio.Rows(0).Item("FUNDS2")).ToString.Trim
                obOCItem.PSCTPDPS = ("" & DtServicio.Rows(0).Item("CTPDP6")).ToString.Trim

                '============== Asigna el valor de la OS

            Else
                '============== Asigna el valor de la OS
                obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")

                obOCItem.PNNCNTR = Val("" & DtServicio.Rows(0).Item("NCNTR")) ' debe ser actualizado  contrato
                obOCItem.PNNCRCTC = Val("" & DtServicio.Rows(0).Item("NCRCTC"))  ' debe ser actualizado contrato
                obOCItem.PNNAUTR = Val("" & DtServicio.Rows(0).Item("NAUTR"))  ' debe ser actualizado contrato
                obOCItem.PSCUNCNT = ("" & DtServicio.Rows(0).Item("CUNCN5")).ToString.Trim   ' .PSCUNCN5 ' debe ser actualizado  contrato
                obOCItem.PSCUNPST = ("" & DtServicio.Rows(0).Item("CUNPS5")).ToString.Trim   ' .PSCUNPS5 ' debe ser actualizado  contrato
                obOCItem.pSCUNVLT = ("" & DtServicio.Rows(0).Item("CUNVL5")).ToString.Trim   ' .PSCUNVL5 ' debe ser actualizado  contrato

                obOCItem.PSFUNDS2 = ("" & DtServicio.Rows(0).Item("FUNDS2")).ToString.Trim
                obOCItem.PSCTPDPS = ("" & DtServicio.Rows(0).Item("CTPDP6")).ToString.Trim

                '============== Asigna el valor de la OS
            End If
        Next

        '==========Ejecutamos el proceso de recepcion
        Dim intNroRecepcion As Decimal = 0
        intNroRecepcion = obrMercaderia.fintRecepcionMercaderia(olbeMercaderia)

        If intNroRecepcion = 0 Then
            pstrError = "Error producido en la operación de recepción"
            Return -1
        Else
            Dim objFiltro As New beDespacho
            With objFiltro
                .PNCCLNT = Cliente.pCodigo
                .PNNGUIRN = intNroRecepcion
                .pRazonSocial = Cliente.pRazonSocial
            End With
            mReporteIngSalRansa(objFiltro)
        End If
    End Function

End Class
