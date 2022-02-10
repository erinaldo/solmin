Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE


Public Class frmInterfaseRecSAP
#Region "Atributos"
    Private intCCLNT As Integer = 0
    Private strCREFFW As String = ""
    Private strCCMPN As String = ""
    Private strCDVSN As String = ""
    Private dblCPLNDV As Double = 0
    Private _pstrRazonSocialCliente As String = ""

#End Region
#Region " Propiedades "



    Public Property pRazonSocialCliente() As String
        Get
            Return _pstrRazonSocialCliente
        End Get
        Set(ByVal value As String)
            _pstrRazonSocialCliente = value
        End Set
    End Property


    Public Property pCodigoCliente_CCLNT() As Int32
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Int32)
            intCCLNT = value
        End Set
    End Property

    Public Property pCodigoCompania_CCMPN() As String
        Get
            Return strCCMPN
        End Get
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoDivision_CDVSN() As String
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoPlanta_CPLNDV() As String
        Set(ByVal value As String)
            dblCPLNDV = value
        End Set
    End Property


    Public ReadOnly Property pCodigoRecepcion_CREFFW() As String
        Get
            pCodigoRecepcion_CREFFW = strCREFFW
        End Get
    End Property
#End Region

#Region " Delegados "
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Call pIniciarProcesoRecepcionInterfazSap()
    End Sub
#End Region

#Region " Procedimientos y Funciones "



    'Private Sub ObtenerDocumentoInterfazSapRecepcion()
    Private Sub pIniciarProcesoRecepcionInterfazSap()

        Dim objRecepcionSap As New beRecepcionInterfaceSap
        Dim RecepcionInterfazSap As New brRecepcionInterfaceSap
        Dim brMercaderia As New brMercaderia

        Dim oTabla As New DataSet
        Dim oDtCabecera As New DataTable("Cabecera")
        Dim oDtDetalle As New DataTable("Detalle")
        Dim oDtOC As New DataTable("OC")
        Dim mensaje As String = ""
        With objRecepcionSap
            .CCMPN = pCodigoCompania_CCMPN
            .CRGVTA = ObtenerRegistroVentaCliente()
            .CCLNT = pCodigoCliente_CCLNT
            .DCENSA = txtNroDocumentoSap.Text.Trim
            .USUARIO = objSeguridadBN.pUsuario
            .ERRORS = ""
        End With
        oTabla = RecepcionInterfazSap.ObtenerDocInterfazSapRecepcion(objRecepcionSap)
        If oTabla.Tables.Count > 0 Then
            oDtCabecera = oTabla.Tables(0)
            oDtDetalle = oTabla.Tables(1)
            oDtOC = oTabla.Tables(2)
        End If
        If objRecepcionSap.ERRORS.Length > 0 Then
            mensaje = objRecepcionSap.ERRORS.ToUpper
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If oDtCabecera.Rows.Count > 0 And oDtDetalle.Rows.Count > 0 Then
            If brMercaderia.GenerarMercaderiaInterfazSap(oTabla, objSeguridadBN.pUsuario, objSeguridadBN.pstrTipoAlmacen, "", mensaje) = 1 Then
                If mensaje.Length > 0 Then
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim fSolicInforRecOCAlmacen As New frmSolicInforRecOCAlmacen(True)
                    Dim fGenerarRecepcion As New frmGenerarRecepcion
                    Dim objMovimientoMercaderia As clsMovimientoMercaderia = Nothing
                    'Dim objMovimientoMercaderia As slnSOLMIN_SDS.clsMovimientoMercaderia = Nothing
                    With fSolicInforRecOCAlmacen
                        .txtNroOrdenCompra.Text = oDtOC.Rows(0)("NORCML").ToString.Trim
                        .pstrCodProveedor = oDtOC.Rows(0)("CPRVCL")
                        .pstrNroOrdenCompra = oDtOC.Rows(0)("NORCML").ToString.Trim
                        .pintCliente = pCodigoCliente_CCLNT
                        .pstrRazonSocialCliente = pRazonSocialCliente
                        .txtNroGuiaCliente.Text = oDtCabecera.Rows(0)("NROGRP").ToString.Trim
                        '.txtTobs.Text = oDtOC.Rows(0)("NROGRP").ToString.Trim
                        .ListaOrdenCompraInterfazSap = ObtenerOrdenDeCompraParaGenerarRecepcion(oTabla)
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

                        Dim objHashTable As Hashtable
                        objHashTable = New Hashtable
                        objHashTable.Add("TPOOCM", "")
                        objHashTable.Add("NORCCL", .pstrNroOrdenCompra)
                        objHashTable.Add("NGUICL", .pstrNroGuiaCliente)
                        objHashTable.Add("NRUCLL", .pstrNroRUCCliente)
                        objHashTable.Add("STPING", .pstrTipoRecepcion)
                        objHashTable.Add("CTPALM", .pstrTipoAlmacen)
                        objHashTable.Add("TALMC", .pstrDetalleAlmacen)
                        objHashTable.Add("CALMC", .pstrAlmacen)
                        objHashTable.Add("TCMPAL", .pstrDetalleTipoAlmacen)
                        objHashTable.Add("CZNALM", .pstrZonaAlmacen)
                        objHashTable.Add("TCMZNA", .pstrDetalleZonaAlmacen)
                        objHashTable.Add("CCNTD", .pstrContenedor)
                        objHashTable.Add("CTPOCN", .pblnDesglose)
                        objHashTable.Add("NOMPRO", oDtCabecera.Rows(0)("DESPRV"))
                        objHashTable.Add("NOMBPR", oDtCabecera.Rows(0)("RUCPRV") + " <-> " + oDtCabecera.Rows(0)("DESPRV"))
                        objHashTable.Add("NORSCI", .pdecEmbarque)
                        objHashTable.Add("CPRPCL", oDtCabecera.Rows(0)("CODPRV"))
                        objHashTable.Add("TIPORG", .pstrTipoOrigen_TIPORG)
                        objHashTable.Add("TIPORI", .pstrTipoDocumentoOrigen_TIPORI)
                        objHashTable.Add("CPRVCL", .pstrCodProvCliente)
                        objHashTable.Add("SCNEMB", .pstrEmbalajaOC)

                        fGenerarRecepcion.objInformacionIngresada = .pobjInformacionIngresada
                        fGenerarRecepcion.pHashTable = objHashTable
                        fGenerarRecepcion.ItemSelec_List = .ListaOrdenCompraInterfazSap
                        fGenerarRecepcion.Cliente_CCLNT = pCodigoCliente_CCLNT
                        fGenerarRecepcion.RazonSocial = pRazonSocialCliente
                        fGenerarRecepcion.UcUbicaciones_Lista.Enabled = True
                        If fGenerarRecepcion.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

                        .Dispose()
                        fSolicInforRecOCAlmacen = Nothing
                        fGenerarRecepcion = Nothing
                        DialogResult = Windows.Forms.DialogResult.OK
                    End With
                End If
            Else
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No se  pudo grabar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Function ObtenerOrdenDeCompraParaGenerarRecepcion(ByVal odSet As DataSet) As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
        Dim strMensajeError2 As String = ""
        Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
        Dim dtItemOC As New DataTable
        Dim TD_OrdenCompraActual As OrdenCompra.OrdenCompra.TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK


        TD_OrdenCompraActual.pCCLNT_CodigoCliente = odSet.Tables(0).Rows(0)("CCLNT")
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = odSet.Tables(0).Rows(0)("NUMDES")
        TD_OrdenCompraActual.PAGESIZE = 1000
        TD_OrdenCompraActual.PAGENUMBER = 1

        dtItemOC = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError2)

        Dim intCont As Int32 = 0
        intCont = 0
        Dim objTemp As New OrdenCompra.ItemOC.TD_ItemOCForWayBill
        objTemp = Nothing

        Dim lstItemsSelec As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill) = New List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
        While intCont < dtItemOC.Rows.Count
            objTemp = New OrdenCompra.ItemOC.TD_ItemOCForWayBill
            objTemp.pNRITOC_NroItemOC = dtItemOC.Rows(intCont).Item("NRITOC")
            objTemp.pTCITCL_CodigoCliente = dtItemOC.Rows(intCont).Item("TCITCL").ToString.Trim
            objTemp.pQCNREC_QtaRecibida = dtItemOC.Rows(intCont).Item("QCNPEN")
            objTemp.pTUNDIT_UnidadQta = dtItemOC.Rows(intCont).Item("TUNDIT").ToString.Trim
            objTemp.pTDAITM_Observaciones = ""
            objTemp.pQPEPQT_QtaPeso = 0
            objTemp.pTUNPSO_UnidadPeso = ""
            objTemp.pCMRCD_CodigoRANSA = dtItemOC.Rows(intCont).Item("CMRCD").ToString
            objTemp.pTMRCD2_MercaDescripcion = dtItemOC.Rows(intCont).Item("TMRCD2").ToString.Trim
            objTemp.pNORDSR_OrdenServicio = dtItemOC.Rows(intCont).Item("NORDSR")
            objTemp.pNCNTR_NroContrato = dtItemOC.Rows(intCont).Item("NCNTR")
            objTemp.pNCRCTC_NroCorrelativoContrato = dtItemOC.Rows(intCont).Item("NCRCTC")
            objTemp.pNAUTR_NroAutorizacionContrato = dtItemOC.Rows(intCont).Item("NAUTR")
            objTemp.pCTPDPS_TipoDeposito = dtItemOC.Rows(intCont).Item("CTPDPS").ToString.Trim
            objTemp.pFUNDS2_Status = dtItemOC.Rows(intCont).Item("FUNDS2").ToString.Trim
            objTemp.pCUNCN5_UnidadCantidad = dtItemOC.Rows(intCont).Item("CUNCN5")
            objTemp.pCUNPS5_UnidadPeso = dtItemOC.Rows(intCont).Item("CUNPS5").ToString.Trim
            objTemp.pCUNVL5_UnidadValor = dtItemOC.Rows(intCont).Item("CUNVL5").ToString.Trim
            objTemp.pFMPDME_FechaMaxDespacho = dtItemOC.Rows(intCont).Item("FMPDME").ToString.Trim
            objTemp.pFUNCTL_FlagControlDeLotes = dtItemOC.Rows(intCont).Item("FUNCTL").ToString.Trim
            lstItemsSelec.Add(objTemp)
            intCont += 1
        End While
        Return lstItemsSelec

    End Function





    Private Function ObtenerRegistroVentaCliente() As String
        Dim objRecepcionSap As New beRecepcionInterfaceSap
        Dim RecepcionInterfazSap As New brRecepcionInterfaceSap
        Dim dt As New DataTable("RegristroVentaCliente")
        Dim CRGVTA As String = ""
        objRecepcionSap.CCMPN = pCodigoCompania_CCMPN
        objRecepcionSap.CCLNT = pCodigoCliente_CCLNT
        dt = RecepcionInterfazSap.ObtenerRegistroVentaCliente(objRecepcionSap)
        If dt.Rows.Count > 0 Then
            CRGVTA = dt.Rows(0)("CRGVTA").ToString.Trim
        End If
        Return CRGVTA
    End Function


#End Region

    Private Sub txtNroDocumentoSap_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumentoSap.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Call pIniciarProcesoRecepcionInterfazSap()
        End If

    End Sub
End Class