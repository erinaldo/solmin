Imports RANSA.NEGO
Imports Ransa.TypeDef
Imports RANSA.Utilitario
Imports RANSA.NEGO.slnSOLMIN_SDS

Public Class frmAjustarInventario

#Region "Propiedades"
    Private _PNCCLNT As Decimal
    Private _PSCCMPN As String
    Private _PSCRGVTA As String
    Private _PNCPLNDV As Decimal
    Private _PNNROERI As Decimal
    Private _PSCTPDP6 As String
    Private _PNFECHINV As Decimal

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCRGVTA() As String
        Get
            Return (_PSCRGVTA)
        End Get
        Set(ByVal value As String)
            _PSCRGVTA = value
        End Set
    End Property

    Public Property PNCPLNDV() As Decimal
        Get
            Return (_PNCPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Public Property PNNROERI() As Decimal
        Get
            Return (_PNNROERI)
        End Get
        Set(ByVal value As Decimal)
            _PNNROERI = value
        End Set
    End Property

    Public Property PSCTPDP6() As String
        Get
            Return (_PSCTPDP6)
        End Get
        Set(ByVal value As String)
            _PSCTPDP6 = value
        End Set
    End Property

    Public Property PNFECHINV() As Decimal
        Get
            Return (_PNFECHINV)
        End Get
        Set(ByVal value As Decimal)
            _PNFECHINV = value
        End Set
    End Property
#End Region

#Region "Variables"
    Private _TipoAjuste As String = ""
    Private olistMercaderia As New List(Of beMercaderia)
    Private objMovimientoMercaderiaPositivo As clsMovimientoMercaderia
    Private objMovimientoMercaderiaNegativo As clsMovimientoMercaderia
    Private objMovimientoMercaderia As clsMovimientoMercaderia
    Private DtReporte As New DataTable
#End Region

#Region "Eventos Formulario"
    Private Sub frmAjustarInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNroDocEri.Text = PNNROERI.ToString()
        txtFecInv.Text = HelpClass.CFecha_de_8_a_10(PNFECHINV.ToString())
        ListarProductoxRegularizar()
    End Sub

    Private Sub dtgMercaderia_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMercaderia.SelectionChanged
        If Me.dgMercaderia.CurrentCellAddress.Y = -1 Then
            Limpiar()
            Exit Sub
        End If
        CargarDetalleOS(ObtenerEntidadMercaderia())
    End Sub

    Private Sub bsaOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesar.Click
        If dgMercaderia.CurrentCellAddress.Y = -1 OrElse Me.dtgKardex.CurrentCellAddress.Y = -1 Then Exit Sub

        Dim decQta As Decimal = CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC2
        Dim decPeso As Decimal = CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMP2
        Dim status As String = String.Empty 'dgMercaderia.CurrentRow.Cells("FUNDS2").Value
        Dim strTipoAjuste As String = dgMercaderia.CurrentRow.Cells("TPAJUSTE").Value
        If strTipoAjuste = "Positivo" Then
            _TipoAjuste = "P"
        ElseIf strTipoAjuste = "Negativo" Then
            _TipoAjuste = "N"
        Else
            _TipoAjuste = String.Empty
        End If
        If _TipoAjuste <> "" Then
            Dim ofrmDlgAjustes As frmProcesarAjuste = New frmProcesarAjuste(_TipoAjuste, decQta, decPeso, status, PNCCLNT)
            With ofrmDlgAjustes
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' INICIO
                    Dim obeMercaderia As New beMercaderia
                    'olistMercaderia = New List(Of beMercaderia)
                    ' If ofrmDlgAjustes.pdecRecCantidad > 0 Then
                    'With CType(Me.dgMercaderia.CurrentRow.DataBoundItem, beMercaderia)
                    obeMercaderia.PSTIPOAJUSTE = _TipoAjuste
                    obeMercaderia.PSCMRCD = dgMercaderia.CurrentRow.Cells("CMRCD").Value '.PSCMRCD
                    obeMercaderia.PSTCMPMR = dgMercaderia.CurrentRow.Cells("TCMPMR").Value '.PSTCMPMR
                    obeMercaderia.PSCMRCLR = dgMercaderia.CurrentRow.Cells("CMRCLR").Value '.PSCMRCLR
                    obeMercaderia.PNNORDSR = dgMercaderia.CurrentRow.Cells("NORDSR1").Value '.PNNORDSR
                    obeMercaderia.PNNCNTR = dgMercaderia.CurrentRow.Cells("NCNTR").Value '.PNNCNTR
                    obeMercaderia.PNNCRCTC = dgMercaderia.CurrentRow.Cells("NCRCTC").Value '.PNNCRCTC
                    obeMercaderia.PNNAUTR = dgMercaderia.CurrentRow.Cells("NAUTR").Value '.PNNAUTR
                    obeMercaderia.PSCUNCNT = dgMercaderia.CurrentRow.Cells("CUNCN5").Value '.PSCUNCN5
                    obeMercaderia.PSCUNPST = dgMercaderia.CurrentRow.Cells("CUNPS5").Value '.PSCUNPS5
                    obeMercaderia.pSCUNVLT = dgMercaderia.CurrentRow.Cells("CUNVL5").Value '.PSCUNVL5
                    obeMercaderia.PSNORCCL = 0
                    obeMercaderia.PSNGUICL = 0
                    obeMercaderia.PSNRUCLL = 0
                    obeMercaderia.PSSTPING = ofrmDlgAjustes.pstrTipoDespacho
                    obeMercaderia.PSCTPALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
                    obeMercaderia.PSTALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTALMC
                    obeMercaderia.PSCALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
                    obeMercaderia.PSTCMPAL = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMPAL
                    obeMercaderia.PSCZNALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
                    obeMercaderia.PSTCMZNA = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMZNA
                    obeMercaderia.PNQTRMC = ofrmDlgAjustes.pdecRecCantidad
                    obeMercaderia.PNQTRMP = ofrmDlgAjustes.pdecRecPeso
                    obeMercaderia.PNQDSVGN = 0
                    obeMercaderia.PSFUNDS2 = dgMercaderia.CurrentRow.Cells("FUNDS2").Value '.PSFUNDS2
                    obeMercaderia.PSCTPOCN = False
                    obeMercaderia.PSCTPDPS = dgMercaderia.CurrentRow.Cells("CTPDP6").Value '.PSCTPDP6
                    obeMercaderia.PSTOBSRV = ofrmDlgAjustes.pstrRecObservacion
                    'End With

                    'End If
                    olistMercaderia.Add(obeMercaderia)
                    Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
                    Me.dgMercaderiaSeleccionada.DataSource = Nothing
                    If olistMercaderia.Count > 0 Then
                        btnEliminarItem.Enabled = True
                        btnProcesarDespacho.Enabled = True
                    End If
                    Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
                End If
            End With
        End If
    End Sub

    Private Sub btnEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarItem.Click
        If Me.dgMercaderiaSeleccionada.CurrentCellAddress.Y = -1 Then Exit Sub
        olistMercaderia.Remove(Me.dgMercaderiaSeleccionada.CurrentRow.DataBoundItem)
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
        Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
        If dgMercaderiaSeleccionada.RowCount = 0 Then
            btnProcesarDespacho.Enabled = False
            btnEliminarItem.Enabled = False
        End If
    End Sub

    Private Sub btnProcesarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarDespacho.Click
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        pProcesarAjustePositivo()
        pProcesarAjusteNegativo()
        ActualizaEstadoEri()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos y funciones"
    Private Sub CargarDetalleOS(ByVal obeMercaderia As beMercaderia)
        Limpiar()
        Dim obrMercaderia As New brMercaderia
        Me.dtgKardex.DataSource = obrMercaderia.ListaKardex(obeMercaderia)
    End Sub

    Private Sub Limpiar()
        dtgKardex.AutoGenerateColumns = False
        dtgKardex.DataSource = Nothing
    End Sub

    Private Function ObtenerEntidadMercaderia() As beMercaderia
        Dim objbeMercaderia As New beMercaderia
        objbeMercaderia.PNNORDSR = dgMercaderia.CurrentRow.Cells("NORDSR1").Value()
        Return objbeMercaderia
    End Function

    Private Sub ListarProductoxRegularizar()
        Try
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim dtListaProductoRegula As New DataTable
            dtListaProductoRegula = oblInventarioMercaderia.ListarProductosxRegularizar(ObtenerEntidadProdRegulariza()).Tables(0)
            DtReporte = dtListaProductoRegula.Copy()
            dgMercaderia.AutoGenerateColumns = False
            dgMercaderia.DataSource = dtListaProductoRegula
            Dim decStockFisico As Decimal
            Dim decStockSistem As Decimal
            Dim decTotalStock As Decimal
            For i1 As Integer = 0 To dgMercaderia.RowCount - 1
                If IsDBNull(dgMercaderia.Rows(i1).Cells("QSFMC").Value) Then
                    decStockFisico = 0
                Else
                    decStockFisico = dgMercaderia.Rows(i1).Cells("QSFMC").Value
                End If
                If IsDBNull(dgMercaderia.Rows(i1).Cells("QSLMC").Value) Then
                    decStockSistem = 0
                Else
                    decStockSistem = dgMercaderia.Rows(i1).Cells("QSLMC").Value
                End If
                decTotalStock = decStockFisico - decStockSistem
               
                If decTotalStock < 0 Then
                    dgMercaderia.Rows(i1).Cells("TPAJUSTE").Value = "Negativo"
                    decTotalStock = decTotalStock - (decTotalStock * 2)
                Else
                    dgMercaderia.Rows(i1).Cells("TPAJUSTE").Value = "Positivo"
                End If
              
                dgMercaderia.Rows(i1).Cells("CNTREGULA").Value = decTotalStock
            Next
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al lista productos: " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function ObtenerEntidadProdRegulariza() As beProductoxRegularizar
        Dim objbeProductoxRegularizar As New beProductoxRegularizar
        objbeProductoxRegularizar.PNCCLNT = PNCCLNT
        objbeProductoxRegularizar.PNCPLNDV = PNCPLNDV
        objbeProductoxRegularizar.PNNROERI = PNNROERI
        objbeProductoxRegularizar.PSCCMPN = PSCCMPN
        objbeProductoxRegularizar.PSCRGVTA = PSCRGVTA
        objbeProductoxRegularizar.PSCTPDP6 = PSCTPDP6
        Return objbeProductoxRegularizar
    End Function

    Private Sub pProcesarAjusteNegativo()
        objMovimientoMercaderiaNegativo = New clsMovimientoMercaderia
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strMensaje As String = ""
        'If objSeguridadBN.fblnIsLocked(PNCCLNT, "SOLMIN_SA", strMensaje) Then
        '    If strMensaje <> "" Then MessageBox.Show(strMensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If


        ' Obtenemos la información de la cabecera registrada
        objMovimientoMercaderiaNegativo.pintServicio_CSRVC = 911
        objMovimientoMercaderiaNegativo.pintCodigoCliente_CCLNT = PNCCLNT
        ' Recuperamos la información ingresada en el datatable a la Lista de Clases
        Dim iCont As Integer = 0
        While iCont < dgMercaderiaSeleccionada.RowCount
            If dgMercaderiaSeleccionada.Rows(iCont).Cells("PSTIPOAJUSTE").Value = "N" Then
                Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
                With objTemp
                    .pintOrdenServicio_NORDSR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NORDSR").Value
                    .pintNroContrato_NCNTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCNTR").Value
                    .pintNroCorrDetalleContrato_NCRCTC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCRCTC").Value
                    .pintNroAutorizacion_NAUTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NAUTR").Value
                    .pstrCodigoMercaderia_CMRCLR = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCLR").Value).ToString.Trim
                    .pstrCodigoRANSA_CMRCD = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value

                    .pstrNroOrdenCompraCliente_NORCCL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value).ToString.Trim
                    .pstrNroGuiaCliente_NGUICL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NGUICL").Value).ToString.Trim
                    .pstrNroRUCCliente_NRUCLL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NRUCLL").Value).ToString.Trim

                    .pstrTipoAlmacen_CTPALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPALM").Value).ToString.Trim
                    .pstrAlmacen_CALMC = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CALMC").Value).ToString.Trim
                    .pstrZonaAlmacen_CZNALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CZNALM").Value).ToString.Trim

                    .pdecCantidad_QTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .PNQTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .PNQTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                    .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                    .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                    .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim
                    .pintNroDiasVigencia_QDSVGN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QDSVGN").Value

                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                    .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                End With
                objMovimientoMercaderiaNegativo.AddItemMovimientoMercaderia(objTemp)
            End If
            
            iCont += 1
        End While
        ' Procedemos con el procesamiento de la información
        Call pProcesarDespachoNegativo(False)

    End Sub

    Private Sub pProcesarAjustePositivo()
        objMovimientoMercaderiaPositivo = New clsMovimientoMercaderia
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strMensaje As String = ""
        'If objSeguridadBN.fblnIsLocked(PNCCLNT, "SOLMIN_SA", strMensaje) Then
        '    If strMensaje <> "" Then MessageBox.Show(strMensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        objMovimientoMercaderiaPositivo.pintServicio_CSRVC = 910
        objMovimientoMercaderiaPositivo.pintCodigoCliente_CCLNT = PNCCLNT
        ' Recuperamos la información ingresada en el datatable a la Lista de Clases
        Dim iCont As Integer = 0
        While iCont < dgMercaderiaSeleccionada.RowCount
            If dgMercaderiaSeleccionada.Rows(iCont).Cells("PSTIPOAJUSTE").Value = "P" Then
                Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
                With objTemp

                    .pintOrdenServicio_NORDSR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NORDSR").Value
                    .pintNroContrato_NCNTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCNTR").Value
                    .pintNroCorrDetalleContrato_NCRCTC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCRCTC").Value
                    .pintNroAutorizacion_NAUTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NAUTR").Value
                    .pstrCodigoMercaderia_CMRCLR = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCLR").Value).ToString.Trim
                    .pstrCodigoRANSA_CMRCD = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value

                    .pstrNroOrdenCompraCliente_NORCCL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value).ToString.Trim
                    .pstrNroGuiaCliente_NGUICL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NGUICL").Value).ToString.Trim
                    .pstrNroRUCCliente_NRUCLL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NRUCLL").Value).ToString.Trim

                    .pstrTipoAlmacen_CTPALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPALM").Value).ToString.Trim
                    .pstrAlmacen_CALMC = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CALMC").Value).ToString.Trim
                    .pstrZonaAlmacen_CZNALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CZNALM").Value).ToString.Trim

                    .pdecCantidad_QTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .PNQTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .PNQTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                    .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                    .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                    .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim
                    .pintNroDiasVigencia_QDSVGN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QDSVGN").Value

                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                    .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                End With
                objMovimientoMercaderiaPositivo.AddItemMovimientoMercaderia(objTemp)
            End If
          
            iCont += 1
        End While
        ' Procedemos con el procesamiento de la información
        Call pProcesarDespachoPositivo(False)
        'ActualizaEstadoEri()
    End Sub

    Private Sub pProcesarDespachoPositivo(ByVal blnCheckServicio As Boolean)
        If objMovimientoMercaderiaPositivo.plstItemMovimientoMercaderia.Count <= 0 Then
            'MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim intNroGuiaRansa As Int64 = 0
            If mfblnDespacho_Mercaderia(objMovimientoMercaderiaPositivo, blnCheckServicio, intNroGuiaRansa) Then
                Dim objFiltro As New beDespacho
                With objFiltro
                    .PNCCLNT = objMovimientoMercaderiaPositivo.pintCodigoCliente_CCLNT
                    .PNNGUIRN = intNroGuiaRansa
                    .pRazonSocial = objMovimientoMercaderiaPositivo.pstrRazonSocialCliente_TCMPCL()
                    .PSCTPOAT = objMovimientoMercaderiaPositivo.pintServicio_CSRVC
                End With
                mReporteIngSalRansa(objFiltro)
            End If
        End If
    End Sub

    Private Sub pProcesarDespachoNegativo(ByVal blnCheckServicio As Boolean)
        If objMovimientoMercaderiaNegativo.plstItemMovimientoMercaderia.Count <= 0 Then
            'MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim intNroGuiaRansa As Int64 = 0
            If mfblnDespacho_Mercaderia(objMovimientoMercaderiaNegativo, blnCheckServicio, intNroGuiaRansa) Then
                Dim objFiltro As New beDespacho
                With objFiltro
                    .PNCCLNT = objMovimientoMercaderiaNegativo.pintCodigoCliente_CCLNT
                    .PNNGUIRN = intNroGuiaRansa
                    .pRazonSocial = objMovimientoMercaderiaNegativo.pstrRazonSocialCliente_TCMPCL()
                    .PSCTPOAT = objMovimientoMercaderiaNegativo.pintServicio_CSRVC
                End With
                mReporteIngSalRansa(objFiltro)

            End If
        End If
    End Sub

    Private Sub ListaMercaderia()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        With obeMercaderia
            .PNCCLNT = PNCCLNT
            .PSCTPDP6 = PSCTPDP6
            If IsNumeric(dgMercaderia.CurrentRow.Cells("NORDSR1").Value()) Then
                .PNNORDSR = Val(dgMercaderia.CurrentRow.Cells("NORDSR1").Value())
            Else
                .PSTCMPMR = dgMercaderia.CurrentRow.Cells("NORDSR1").Value()
            End If

        End With
        dgMercaderia.AutoGenerateColumns = False
        Limpiar()
        Me.dgMercaderia.DataSource = obrMercaderia.flistListarMercaderiaOSNew(obeMercaderia)
        'intWidth = hgOS.Width

        'Me.Contenedor1.Panel2Collapsed = True
        'Me.Contenedor2.Panel2Collapsed = True
        'btnCancelar.PerformClick()
    End Sub

    Private Sub ActualizaEstadoEri()
        Dim objblRegistroInventario As New blRegistroInventario
        Dim intRetorno As Integer = objblRegistroInventario.ActualizaEstadoCabERI(ObtenerEntidadCabeceraERI())
        If intRetorno = 1 Then
            MessageBox.Show("Se procesó correctamente", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error al procesar ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function ObtenerEntidadCabeceraERI() As beActualizaEstadoCabERI
        Dim objbeActEstadoCabEri As New beActualizaEstadoCabERI
        objbeActEstadoCabEri.PSCCMPN = PSCCMPN
        objbeActEstadoCabEri.PSCRGVTA = PSCRGVTA 'txtCliente.pNegocio
        objbeActEstadoCabEri.PNCPLNDV = PNCPLNDV
        objbeActEstadoCabEri.PNCCLNT = PNCCLNT
        objbeActEstadoCabEri.PNNROERI = PNNROERI
        objbeActEstadoCabEri.PSCUSERI = objSeguridadBN.pUsuario
        objbeActEstadoCabEri.NTRMCR = objSeguridadBN.pstrPCName
        objbeActEstadoCabEri.PSSTSERI = "C"
        Return objbeActEstadoCabEri
    End Function
#End Region

End Class