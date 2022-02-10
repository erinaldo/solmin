'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario
Imports Ransa.TypeDef
Imports System.IO
Imports Ransa.Utilitario.Helpclass_txt

Public Class frmMovimientoPorFecha
#Region " Atributos "
    Private blnStatusBultoNormal As Boolean = True
    Private oDtPlanta As New DataTable
    Private oPlanta As blPlanta
    Private oDt As DataTable
    'Private dgRecep As DataGridView
    'Private dgRecepOc As DataGridView
    'Private dgDesp As DataGridView
    'Private dgDespOc As DataGridView

#End Region
#Region " Funciones y Procedimientos "

    Private Sub Cargar_Cliente()
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub Cargar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub Cargar_Controles()
        '==============tipo Movimiento================'
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Tipo Movimiento"
        oListColum.Add(2, oColumnas)
        Dim oListaTipMov As New List(Of beGeneral)
        If (blnStatusBultoNormal = True) Then
            If txtTipoMovimiento.Resultado IsNot Nothing Then
                txtTipoMovimiento.DataSource = obrGeneral.olTipoMovimiento(CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN)
                oListaTipMov = obrGeneral.olTipoMovimiento(CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN)
            Else
                txtTipoMovimiento.DataSource = obrGeneral.olTipoMovimiento("")
                oListaTipMov = obrGeneral.olTipoMovimiento("")
            End If

        Else
            txtTipoMovimiento.DataSource = obrGeneral.olTipoMovimientoMarcaE()
        End If
        txtTipoMovimiento.ListColumnas = oListColum
        txtTipoMovimiento.Cargas()
        txtTipoMovimiento.ValueMember = "PSCCMPRN"
        txtTipoMovimiento.DispleyMember = "PSTDSDES"

        ''==========Sentido Carga
        Dim oListColumSC As New Hashtable
        Dim oColumnasSC As New DataGridViewTextBoxColumn
        oColumnasSC.Name = "CODIGO"
        oColumnasSC.DataPropertyName = "PSCCMPRN"
        oColumnasSC.HeaderText = "Código "
        oListColumSC.Add(1, oColumnasSC)
        oColumnasSC = New DataGridViewTextBoxColumn
        oColumnasSC.Name = "DETALLE"
        oColumnasSC.DataPropertyName = "PSTDSDES"
        oColumnasSC.HeaderText = "Sentido de Carga"
        oListColumSC.Add(2, oColumnasSC)
        Dim oListaSenCarga As New List(Of beGeneral)

        txtSentidoCarga.DataSource = obrGeneral.olSentidoCargaTotal()
        oListaSenCarga = obrGeneral.olSentidoCargaTotal()
        txtSentidoCarga.ListColumnas = oListColumSC
        txtSentidoCarga.Cargas()
        txtSentidoCarga.ValueMember = "PSCCMPRN"
        txtSentidoCarga.DispleyMember = "PSTDSDES"
        'If oListaSenCarga.Count() > 0 Then
        '    txtSentidoCarga.Valor = "1"
        '    txtSentidoCarga.Refresh()
        'Else
        '    txtSentidoCarga.Refresh()
        'End If

        '===========Medio Envío
        Dim oListColumME As New Hashtable
        Dim oColumnasME As New DataGridViewTextBoxColumn
        oColumnasME.Name = "CODIGO"
        oColumnasME.DataPropertyName = "PNCMEDTR"
        oColumnasME.HeaderText = "Código "
        oListColumME.Add(1, oColumnasME)
        oColumnasME = New DataGridViewTextBoxColumn
        oColumnasME.Name = "DETALLE"
        oColumnasME.DataPropertyName = "PSTNMMDT"
        oColumnasME.HeaderText = "Medio Envío"
        oListColumME.Add(2, oColumnasME)

        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
        If txtMedioEnvio.Resultado IsNot Nothing Then
            With obeMedioTransporte
                .PNCMEDTR = IIf(txtMedioEnvio.Resultado IsNot Nothing, (CType(Me.txtMedioEnvio.Resultado, beGeneral).PNCMEDTR), 0)
                .PSTNMMDT = IIf(txtMedioEnvio.Resultado IsNot Nothing, (CType(Me.txtMedioEnvio.Resultado, beGeneral).PSTNMMDT), "")
            End With
        End If
        Dim oListaMedEnv As New List(Of beGeneral)
        txtMedioEnvio.DataSource = obrGeneral.ListaMedioTransporte(obeMedioTransporte)
        oListaMedEnv = obrGeneral.ListaMedioTransporte(obeMedioTransporte)
        txtMedioEnvio.ListColumnas = oListColumME
        txtMedioEnvio.Cargas()
        txtMedioEnvio.ValueMember = "PNCMEDTR"
        txtMedioEnvio.DispleyMember = "PSTNMMDT"
        'If oListaMedEnv.Count() > 0 Then
        '    txtMedioEnvio.Valor = "1"
        '    txtMedioEnvio.Refresh()
        'Else
        '    txtMedioEnvio.Refresh()
        'End If

    End Sub

    Private Sub Visible_Grilla()
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            If rbItem.Checked = True Then
                dgRecepcion.Visible = True
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = False
                dgDespachoOC.Visible = False
            Else
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = True
                dgDespacho.Visible = False
                dgDespachoOC.Visible = False
            End If

        Else
            If rbItem.Checked = True Then
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = True
                dgDespachoOC.Visible = False
            Else
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = False
                dgDespachoOC.Visible = True
            End If
        End If
    End Sub

    Private Sub pCargarInformacion()
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            Dim oIngresoMovimientos As New beIngresoMovimientos
            Dim bIngresoMovimientos As New brIngresoMovimientos
            With oIngresoMovimientos
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                .PNCCLNT = txtCliente.pCodigo
                .PSNORCML = txtOC.Text.Trim
                '.PSListaCliente = Me.ResourceCombo1.GetClientesAll
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PSUSUARIO = objSeguridadBN.pUsuario
                If txtTipoMovimiento.Resultado IsNot Nothing Then
                    .PSSTPING = CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSTPING = "0"
                End If
                If txtSentidoCarga.Resultado IsNot Nothing Then
                    .PSSSNCRG = CType(Me.txtSentidoCarga.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSSNCRG = "0"
                End If

                .PSTLUGEN = Me.txtLugarEntrega.Text.Trim
                .PSTCMAEM = Me.txtAreaSolicitante.Text.Trim
                .PSNRUCPR = String.Empty
                .PageSize = Me.UcPaginacion1.PageSize
                .PageNumber = Me.UcPaginacion1.PageNumber
                Dim loIngresoMovimientos_BE As New List(Of beIngresoMovimientos)
                If rbItem.Checked = True Then
                    'oDt = New DataTable

                    loIngresoMovimientos_BE = bIngresoMovimientos.ListarMovimientoFecha(oIngresoMovimientos)
                    dgRecepcion.AutoGenerateColumns = False
                    dgRecepcion.DataSource = loIngresoMovimientos_BE
                    If TryCast(dgRecepcion.DataSource, List(Of beIngresoMovimientos)).Count > 0 Then
                        UcPaginacion1.PageCount = TryCast(dgRecepcion.DataSource, List(Of beIngresoMovimientos)).Item(0).PageCount
                    End If
                    dgRecepcion.Visible = True
                    dgRecepcionOC.Visible = False
                    dgDespacho.Visible = False
                    dgDespachoOC.Visible = False
                    If dgRecepcion.RowCount > 0 Then
                        tsbExportarExcel.Enabled = True
                    Else
                        tsbExportarExcel.Enabled = False
                    End If
                Else
                    'oDt = New DataTable
                    loIngresoMovimientos_BE = bIngresoMovimientos.ListarMovimientoFecha_OC(oIngresoMovimientos)
                    dgRecepcionOC.AutoGenerateColumns = False
                    dgRecepcionOC.DataSource = loIngresoMovimientos_BE
                    If TryCast(dgRecepcionOC.DataSource, List(Of beIngresoMovimientos)).Count > 0 Then
                        UcPaginacion1.PageCount = TryCast(dgRecepcionOC.DataSource, List(Of beIngresoMovimientos)).Item(0).PageCount
                    End If
                    dgRecepcionOC.Visible = True
                    dgRecepcion.Visible = False
                    dgDespacho.Visible = False
                    dgDespachoOC.Visible = False

                    If dgRecepcionOC.RowCount > 0 Then
                        tsbExportarExcel.Enabled = True
                        tsbExportarTxt.Enabled = True
                    Else
                        tsbExportarExcel.Enabled = False
                        tsbExportarTxt.Enabled = False
                    End If
                End If

            End With
        Else
            Dim oDespachoMovimientos As New beDespachoMovimientos
            Dim bDespachoMovimientos As New brDespachoMovimientos
            Dim loDespachoMovimientos_BE As New List(Of beDespachoMovimientos)
            With oDespachoMovimientos
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                .PNCCLNT = txtCliente.pCodigo
                .PSNORCML = txtOC.Text.Trim
                '.PSListaCliente = Me.ResourceCombo1.GetClientesAll
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PSUSUARIO = objSeguridadBN.pUsuario
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                '.DetalleGR = lstr_popupwindow_JScript
                If txtTipoMovimiento.Resultado IsNot Nothing Then
                    .PSSTPING = CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSTPING = "0"
                End If
                If txtSentidoCarga.Resultado IsNot Nothing Then
                    .PSSSNCRG = CType(Me.txtSentidoCarga.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSSNCRG = "0"
                End If
                If cmbEstadoEntrega.SelectedItem() = "En Destino" Then
                    .PSFLGCNL = "X"
                Else
                    If cmbEstadoEntrega.SelectedItem() = "En Tránsito" Then
                        .PSFLGCNL = ""
                    Else
                        .PSFLGCNL = "0"
                    End If
                End If
                '.PSFLGCNL = Me.cmbEstadoEntrega.SelectedValue
                If txtMedioEnvio.Resultado IsNot Nothing Then
                    .PNCODMEDENVIO = (CType(Me.txtMedioEnvio.Resultado, beGeneral).PNCMEDTR)
                Else
                    .PNCODMEDENVIO = 0
                End If
                '.PNCODMEDENVIO = IIf(txtMedioEnvio.Resultado IsNot Nothing, (CType(Me.txtMedioEnvio.Resultado, beGeneral).PNCMEDTR), 0)
                .PSTLUGEN = Me.txtLugarEntrega.Text.Trim
                .PSTCMAEM = Me.txtAreaSolicitante.Text.Trim
                .PSNRUCPR = String.Empty
                .PageSize = Me.UcPaginacion1.PageSize
                .PageNumber = Me.UcPaginacion1.PageNumber
            End With
            If rbItem.Checked = True Then
                'oDt = New DataTable
                loDespachoMovimientos_BE = bDespachoMovimientos.ListarMovimientoFecha(oDespachoMovimientos)
                dgDespacho.AutoGenerateColumns = False
                dgDespacho.DataSource = loDespachoMovimientos_BE
                If TryCast(dgDespacho.DataSource, List(Of beDespachoMovimientos)).Count > 0 Then
                    UcPaginacion1.PageCount = TryCast(dgDespacho.DataSource, List(Of beDespachoMovimientos)).Item(0).PageCount
                End If
                dgDespacho.Visible = True
                dgDespachoOC.Visible = False
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                If dgDespacho.RowCount > 0 Then
                    tsbExportarExcel.Enabled = True
                Else
                    tsbExportarExcel.Enabled = False
                End If
            Else
                'oDt = New DataTable
                Dim loDespachoMovimientos_DT As New Data.DataTable
                loDespachoMovimientos_DT = bDespachoMovimientos.ListarMovimientoFecha_OC(oDespachoMovimientos, UcPaginacion1.PageCount)
                loDespachoMovimientos_DT.DefaultView.Sort = "TCMPCL,PLANTA,CREFFW,NSEQIN"
                loDespachoMovimientos_DT = loDespachoMovimientos_DT.DefaultView.ToTable()
                dgDespachoOC.AutoGenerateColumns = False
                dgDespachoOC.DataSource = loDespachoMovimientos_DT
                dgDespachoOC.Visible = True
                dgDespacho.Visible = False
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                If dgDespachoOC.RowCount > 0 Then
                    tsbExportarExcel.Enabled = True
                    tsbExportarTxt.Enabled = True
                Else
                    tsbExportarExcel.Enabled = False
                    tsbExportarTxt.Enabled = False
                End If
            End If

        End If
    End Sub
#End Region
#Region " Eventos"
    Private Sub frmMovimientoPorFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Cliente()
        Cargar_Compania()
        Cargar_Controles()
        cmbMovimiento.SelectedItem() = "Recepcion"
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            lblMedioEnvio.Visible = False
            lblEstadoEntrega.Visible = False
            txtMedioEnvio.Visible = False
            cmbEstadoEntrega.Visible = False
        Else
            lblMedioEnvio.Visible = True
            lblEstadoEntrega.Visible = True
            txtMedioEnvio.Visible = True
            cmbEstadoEntrega.Visible = True
        End If
        rbOC.Checked = True
        tsbExportarExcel.Enabled = False
        Visible_Grilla()
    End Sub

    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            lblMedioEnvio.Visible = False
            lblEstadoEntrega.Visible = False
            txtMedioEnvio.Visible = False
            cmbEstadoEntrega.Visible = False
            If rbItem.Checked = True Then
                dgRecepcion.Visible = True
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = False
                dgDespachoOC.Visible = False
                tsbExportarTxt.Visible = False
                'tsbExportarExcel.Enabled = False
            Else
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = True
                dgDespacho.Visible = False
                dgDespachoOC.Visible = False
                'tsbExportarExcel.Enabled = False
                tsbExportarTxt.Visible = True
            End If

        Else
            lblMedioEnvio.Visible = True
            lblEstadoEntrega.Visible = True
            txtMedioEnvio.Visible = True
            cmbEstadoEntrega.Visible = True
            If rbItem.Checked = True Then
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = True
                dgDespachoOC.Visible = False
                tsbExportarTxt.Visible = False
            Else
                dgRecepcion.Visible = False
                dgRecepcionOC.Visible = False
                dgDespacho.Visible = False
                dgDespachoOC.Visible = True
                tsbExportarTxt.Visible = True
            End If
        End If
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Call pCargarInformacion()
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Call pCargarInformacion()
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        oDt = New DataTable
        oDt = Nothing
        Dim bIngresoMovimientos As New brIngresoMovimientos
        Dim bDespachoMovimientos As New brDespachoMovimientos

        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            Dim oIngresoMovimientos As New beIngresoMovimientos
            With oIngresoMovimientos
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                .PNCCLNT = txtCliente.pCodigo
                .PSNORCML = txtOC.Text.Trim
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PSUSUARIO = objSeguridadBN.pUsuario
                If txtTipoMovimiento.Resultado IsNot Nothing Then
                    .PSSTPING = CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSTPING = "0"
                End If
                If txtSentidoCarga.Resultado IsNot Nothing Then
                    .PSSSNCRG = CType(Me.txtSentidoCarga.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSSNCRG = "0"
                End If

                .PSTLUGEN = Me.txtLugarEntrega.Text.Trim
                .PSTCMAEM = Me.txtAreaSolicitante.Text.Trim
                .PSNRUCPR = String.Empty
                If UcPaginacion1.PageCount > 0 Then
                    .PageSize = Me.UcPaginacion1.PageSize * UcPaginacion1.PageCount
                Else
                    .PageSize = Me.UcPaginacion1.PageSize
                End If
                '.PageSize = Me.UcPaginacion1.PageSize * UcPaginacion1.PageCount
                .PageNumber = 1
                Dim loIngresoMovimientos_BE As New List(Of beIngresoMovimientos)
                If rbItem.Checked = True Then
                    oDt = New DataTable
                    'loIngresoMovimientos_BE = bIngresoMovimientos.ListarMovimientoFecha(oIngresoMovimientos)
                    oDt = RANSA.Utilitario.HelpClass.GetDataSetNative(bIngresoMovimientos.ListarMovimientoFecha(oIngresoMovimientos))
                    If oDt.Columns.Count > 0 Then
                        oDt.Columns.Remove("PSLINK")
                    End If

                Else
                    oDt = New DataTable
                    oDt = RANSA.Utilitario.HelpClass.GetDataSetNative(bIngresoMovimientos.ListarMovimientoFecha_OC(oIngresoMovimientos))
                    If oDt.Columns.Count > 0 Then
                        oDt.Columns.Remove("PSLINK")
                    End If

                End If

            End With
        Else
            Dim oDespachoMovimientos As New beDespachoMovimientos
            Dim loDespachoMovimientos_BE As New List(Of beDespachoMovimientos)
            With oDespachoMovimientos
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                .PNCCLNT = txtCliente.pCodigo
                .PSNORCML = txtOC.Text.Trim
                '.PSListaCliente = Me.ResourceCombo1.GetClientesAll
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PSUSUARIO = objSeguridadBN.pUsuario
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                '.DetalleGR = lstr_popupwindow_JScript
                If txtTipoMovimiento.Resultado IsNot Nothing Then
                    .PSSTPING = CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSTPING = "0"
                End If
                If txtSentidoCarga.Resultado IsNot Nothing Then
                    .PSSSNCRG = CType(Me.txtSentidoCarga.Resultado, beGeneral).PSCCMPRN
                Else
                    .PSSSNCRG = "0"
                End If
                If cmbEstadoEntrega.SelectedItem() = "Destino" Then
                    .PSFLGCNL = "X"
                Else
                    If cmbEstadoEntrega.SelectedItem() = "Tránsito" Then
                        .PSFLGCNL = ""
                    Else
                        .PSFLGCNL = "0"
                    End If
                End If
                '.PSFLGCNL = Me.cmbEstadoEntrega.SelectedValue
                If txtMedioEnvio.Resultado IsNot Nothing Then
                    .PNCODMEDENVIO = (CType(Me.txtMedioEnvio.Resultado, beGeneral).PNCMEDTR)
                Else
                    .PNCODMEDENVIO = 0
                End If
                '.PNCODMEDENVIO = IIf(txtMedioEnvio.Resultado IsNot Nothing, (CType(Me.txtMedioEnvio.Resultado, beGeneral).PNCMEDTR), 0)
                .PSTLUGEN = Me.txtLugarEntrega.Text.Trim
                .PSTCMAEM = Me.txtAreaSolicitante.Text.Trim
                .PSNRUCPR = String.Empty
                If UcPaginacion1.PageCount > 0 Then
                    .PageSize = Me.UcPaginacion1.PageSize * UcPaginacion1.PageCount
                Else
                    .PageSize = Me.UcPaginacion1.PageSize
                End If
                '.PageSize = Me.UcPaginacion1.PageSize * UcPaginacion1.PageCount
                .PageNumber = 1 'Me.UcPaginacion1.PageNumber
            End With
            If rbItem.Checked = True Then
                oDt = New DataTable
                oDt = RANSA.Utilitario.HelpClass.GetDataSetNative(bDespachoMovimientos.ListarMovimientoFecha(oDespachoMovimientos))
                If oDt.Columns.Count > 0 Then
                    oDt.Columns.Remove("PSLINK")
                End If

            Else
                oDt = New DataTable
                Dim PageCount As Integer = 1
                oDt = bDespachoMovimientos.ListarMovimientoFecha_OC(oDespachoMovimientos, PageCount)
                oDt.DefaultView.Sort = "TCMPCL,PLANTA,CREFFW,NSEQIN"
                oDt = oDt.DefaultView.ToTable()
                If oDt.Columns.Count > 0 Then
                    oDt.Columns.Remove("LINK")
                End If

            End If

        End If
        '***********************
        'Dim bIngresoMovimientos As New brIngresoMovimientos
        Dim oLstrTtitulo As New List(Of String)
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            oLstrTtitulo.Add("REPORTE DE RECEPCIÓN DE MERCADERÍA")
        Else
            oLstrTtitulo.Add("REPORTE DE DESPACHOS")
        End If
        oLstrTtitulo.Add("Cliente: " & txtCliente.pRazonSocial)
        oLstrTtitulo.Add("Planta: " & UcPLanta_Cmb011.DescripcionPlanta)
        Dim TipoMovimiento As String = ""
        If txtTipoMovimiento.Resultado IsNot Nothing Then
            TipoMovimiento = CType(Me.txtTipoMovimiento.Resultado, beGeneral).PSTDSDES
        Else
            TipoMovimiento = "TODOS"
        End If
        oLstrTtitulo.Add("Tipo Movimiento: " & TipoMovimiento)
        Dim SentidoCarga As String = ""
        If txtSentidoCarga.Resultado IsNot Nothing Then
            SentidoCarga = CType(Me.txtSentidoCarga.Resultado, beGeneral).PSTDSDES
        Else
            SentidoCarga = "TODOS"
        End If
        oLstrTtitulo.Add("Desde: " & dteFechaInicial.Value)
        oLstrTtitulo.Add("Hasta: " & dteFechaFinal.Value)
        Dim VistaMovimientos As String = ""
        If rbItem.Checked = True Then
            VistaMovimientos = "Item"
        Else
            VistaMovimientos = "Orden de Compra"
        End If
        oLstrTtitulo.Add("Vista de Movimientos: " & VistaMovimientos)
        oLstrTtitulo.Add("Movimiento: " & cmbMovimiento.SelectedItem())

        'If oDt.Rows.Count = 0 Then
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            Dim strTitulo As String = "Movimientos de Ingresos de Mercadería"
            If rbItem.Checked = True Then
                'Recepcion x Item
                Dim DtPaginado As New DataTable
                Dim ds As New Data.DataSet
                If oDt.Rows.Count > 0 Then
                    DtPaginado = oDt.Copy
                    DtPaginado.TableName = "DT_Detalle"
                    ds.Tables.Add(DtPaginado)
                    HelpClass_NPOI.ExportExcelDespacho_Item("Recepcion", oLstrTtitulo, ds, Me.dgRecepcion)
                End If


            Else

                Dim DtPaginado As New DataTable

                'Recepcion x OC
                Dim ds As New Data.DataSet
                If oDt.Rows.Count > 0 Then
                    DtPaginado = oDt.Copy
                    ds.Tables.Add(DirectCast(DtPaginado, Data.DataTable).Copy)
                    HelpClass_NPOI.ExportExcelDespacho2("Recepcion", oLstrTtitulo, bIngresoMovimientos.CrearResumenes_Movimientos(ds.Tables(0)), Me.dgRecepcionOC)

                End If

            End If
        Else
            If rbItem.Checked = True Then
                'Despacho x Item
                Dim ds As New Data.DataSet
                Dim DtPaginado As New DataTable
                If oDt.Rows.Count > 0 Then
                    DtPaginado = oDt.Copy
                    DtPaginado.TableName = "DT_Detalle"
                    ds.Tables.Add(DtPaginado)
                    HelpClass_NPOI.ExportExcelDespacho_Item("Despacho", oLstrTtitulo, ds, Me.dgDespacho)
                End If
            Else

                Dim ds As New Data.DataSet
                Dim DtPaginado As New DataTable
                If oDt.Rows.Count > 0 Then
                    DtPaginado = oDt.Copy
                    ds.Tables.Add(DtPaginado)
                    HelpClass_NPOI.ExportExcelDespachoOC("Despacho", oLstrTtitulo, bIngresoMovimientos.CrearResumenes_Despacho(ds.Tables(0)), Me.dgDespachoOC)
                End If
            End If
            'Dim strTitulo2 As String = "Movimientos de Despacho de Mercadería"
            'Dim oDs As New DataSet
            'oDs.Tables.Add(oDt.Copy)
            'HelpClass.ExportExcelConTitulos(oDs, strTitulo2.Trim, oLstrTtitulo)


        End If
        'End If


    End Sub


    Private Sub dgRecepcion_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgRecepcion.DataBindingComplete
        If dgRecepcion.RowCount = 0 Then Exit Sub
        For Each oDr As DataGridViewRow In dgRecepcion.Rows
            If Not ("" & oDr.Cells("LINK_1").Value & "").ToString.Trim.Equals("") Then
                oDr.Cells("LINK").Value = My.Resources.text_block
            End If
        Next
    End Sub

    Private Sub dgRecepcionOC_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgRecepcionOC.DataBindingComplete
        If dgRecepcionOC.RowCount = 0 Then Exit Sub
        For Each oDr As DataGridViewRow In dgRecepcionOC.Rows
            If Not ("" & oDr.Cells("LINK_2").Value & "").ToString.Trim.Equals("") Then
                oDr.Cells("LINK2").Value = My.Resources.text_block
            End If
        Next
    End Sub

    Private Sub dgDespacho_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgDespacho.DataBindingComplete
        If dgDespacho.RowCount = 0 Then Exit Sub
        For Each oDr As DataGridViewRow In dgDespacho.Rows
            If Not ("" & oDr.Cells("LINK_3").Value & "").ToString.Trim.Equals("") Then
                oDr.Cells("LINK3").Value = My.Resources.text_block
            End If
        Next
    End Sub

    Private Sub dgDespachoOC_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgDespachoOC.DataBindingComplete
        If dgDespachoOC.RowCount = 0 Then Exit Sub
        For Each oDr As DataGridViewRow In dgDespachoOC.Rows
            If Not ("" & oDr.Cells("LINK_4").Value & "").ToString.Trim.Equals("") Then
                oDr.Cells("LINK4").Value = My.Resources.text_block
            End If
        Next
    End Sub

    Private Sub dgRecepcion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRecepcion.CellDoubleClick
        If Me.dgRecepcion.CurrentCellAddress.Y = -1 Then Exit Sub
        'HelpClass.AbrirDocumento(Me.dgRecepcion.CurrentRow.DataBoundItem.Item("PSLINK").ToString.Trim)
    End Sub

    Private Sub rbOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOC.CheckedChanged
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            dgRecepcionOC.Visible = True
            dgRecepcion.Visible = False
            dgDespacho.Visible = False
            dgDespachoOC.Visible = False
        Else
            dgRecepcionOC.Visible = False
            dgRecepcion.Visible = False
            dgDespacho.Visible = False
            dgDespachoOC.Visible = True
        End If
    End Sub

    Private Sub rbItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbItem.CheckedChanged
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            dgRecepcionOC.Visible = False
            dgRecepcion.Visible = True
            dgDespacho.Visible = False
            dgDespachoOC.Visible = False
        Else
            dgRecepcionOC.Visible = False
            dgRecepcion.Visible = False
            dgDespacho.Visible = True
            dgDespachoOC.Visible = False
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
#End Region

    Private Sub tsbExportarTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarTxt.Click
        If cmbMovimiento.SelectedItem() = "Recepcion" Then
            ExportarTxtRecepcion()
        Else
            ExportarTxtDespacho()
        End If

    End Sub

    Private Sub ExportarTxtRecepcion()
        If dgRecepcionOC.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgRecepcionOC.EndEdit()
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        Dim oDt As DataTable
        Dim strBultos As String = String.Empty
        Dim strPlanta As String = String.Empty
        Dim strHora As String = Now.Hour.ToString().PadLeft(2, "0") + Now.Minute.ToString().PadLeft(2, "0") + Now.Second.ToString().PadLeft(2, "0")
        Dim intNroBulto As Integer = 0
        Dim intNroBultoLineas As Integer = 0

        Dim obeIngMov As beIngresoMovimientos
        Dim loIngMov As New List(Of beIngresoMovimientos)
        'loIngMov = Me.dgRecepcionOC.DataSource.FindAll(MatchSelectIngMov)
        For i As Int32 = 0 To dgRecepcionOC.RowCount - 1
            If dgRecepcionOC.Rows(i).Cells("chk_Re").Value = True Then
                obeIngMov = New beIngresoMovimientos
                obeIngMov.PSTCMPCL = Me.dgRecepcionOC.Item("TCMPCL2", i).Value.ToString.Trim()
                obeIngMov.PSPLANTA = Me.dgRecepcionOC.Item("PLANTA2", i).Value.ToString.Trim()
                obeIngMov.PSCREFFW = Me.dgRecepcionOC.Item("CREFFW2", i).Value.ToString.Trim()
                obeIngMov.PNNSEQIN = Me.dgRecepcionOC.Item("NSEQIN", i).Value.ToString.Trim()
                obeIngMov.PSDESCWB = Me.dgRecepcionOC.Item("DESCWB2", i).Value.ToString.Trim()
                obeIngMov.PNQBLTSR = Me.dgRecepcionOC.Item("QBLTSR2", i).Value.ToString.Trim()
                obeIngMov.PNCPLNDV = Me.dgRecepcionOC.Item("PNCPLNDV", i).Value.ToString.Trim()
                loIngMov.Add(obeIngMov)
            End If
        Next
        If loIngMov.Count = 0 Then Exit Sub
        Dim lstrCPLNDV As String = ""
        For i As Integer = 0 To loIngMov.Count - 1
            If i = 0 Then
                strPlanta = loIngMov.Item(i).PNCPLNDV.ToString().Trim() + ","
                lstrCPLNDV = loIngMov.Item(i).PNCPLNDV.ToString().Trim()
            Else
                If lstrCPLNDV.Trim() <> loIngMov.Item(i).PNCPLNDV.ToString().Trim() Then
                    strPlanta += loIngMov.Item(i).PNCPLNDV + ","
                    lstrCPLNDV = loIngMov.Item(i).PNCPLNDV
                End If
            End If
        Next

        For Each obeMov As beIngresoMovimientos In loIngMov 'TryCast(dgRecepcionOC.DataSource, List(Of beIngresoMovimientos))
            strBultos += obeMov.PSCREFFW & ","
            'strPlanta += obeMov.PNCPLNDV & ","
        Next

        If strBultos.Length > 0 Then
            strBultos = strBultos.Substring(0, strBultos.Length - 1)
        End If
        If strPlanta.Length > 0 Then
            strPlanta = strPlanta.Substring(0, strPlanta.Length - 1)
        End If

        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PSPLANTA = strPlanta
            '.PNCPLNDV = strPlanta 'UcPLanta_Cmb011.Planta
            .PNCCLNT = txtCliente.pCodigo
            .PSCREFFW = strBultos
        End With
        oDt = obrBulto.fdtListaBultoIngresadosPoraExportarTxt(obeBulto)
        Dim Mes As String = ""
        Dim Dia As String = ""
        If Today.Month < 10 Then
            Mes = "0" & Today.Month.ToString()
        Else
            Mes = Today.Month.ToString
        End If
        If Today.Day < 10 Then
            Dia = "0" & Today.Day
        Else
            Dia = Today.Day
        End If

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = path & "\" & "MRRW" & txtCliente.pCodigo & Mes & Dia & "01" & ".txt" 'xml

        'Crean la estructura de los archivos a modificar
        Dim objListaColumnas As New List(Of RANSA.Utilitario.Helpclass_txt.DataFormat)
        'objListaColumnas.Add(New DataFormat("H1", 15, AutoCompleteType.White_Space, CharDirection.Right))
        objListaColumnas.Add(New DataFormat("H1", 2, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColumnas.Add(New DataFormat("CREFFW", 20, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColumnas.Add(New DataFormat("FREFFW", 8, AutoCompleteType.Numeric, CharDirection.Left))
        objListaColumnas.Add(New DataFormat("TIPBTO", 30, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColumnas.Add(New DataFormat("QPSOBL_E", 20, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColumnas.Add(New DataFormat("QPSOBL_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColumnas.Add(New DataFormat("TUNPSO", 10, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColumnas.Add(New DataFormat("QVLBTO_E", 20, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColumnas.Add(New DataFormat("QVLBTO_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColumnas.Add(New DataFormat("TUNVOL", 10, AutoCompleteType.White_Space, CharDirection.Left))

        Dim objListaColOC As New List(Of RANSA.Utilitario.Helpclass_txt.DataFormat)
        objListaColOC.Add(New DataFormat("L1", 2, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOC.Add(New DataFormat("NORCML", 15, AutoCompleteType.White_Space, CharDirection.Left))

        Dim objListaColOCItem As New List(Of RANSA.Utilitario.Helpclass_txt.DataFormat)
        objListaColOCItem.Add(New DataFormat("L2", 2, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("CREFFW", 20, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("NRITOC", 6, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("QBLTSR_E", 11, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("QBLTSR_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("TTIPPQ", 30, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("QPEPQT_E", 20, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("QPEPQT_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("TUNPSODES", 10, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("QVOPQT_E", 20, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("QVOPQT_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
        objListaColOCItem.Add(New DataFormat("TUNVOLDES", 10, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("CINVEND", 1, AutoCompleteType.White_Space, CharDirection.Left))
        objListaColOCItem.Add(New DataFormat("NGRPRV", 20, AutoCompleteType.White_Space, CharDirection.Left))

        'Generando el archivo
        Using fl As New StreamWriter(archivo, False)
            Dim lstr_textfile As New System.Text.StringBuilder
            Dim lstr_textfileOC As New System.Text.StringBuilder
            Dim lstr_textfileOCItem As New System.Text.StringBuilder
            Dim lstr_CREFFW As String = ""

            'Cabecera
            Dim strCodCliente As String = Me.txtCliente.pCodigo.ToString.PadLeft(6, "0")
            lstr_textfile.Append("AA")
            lstr_textfile.Append(HelpClass.CDate_a_Numero8Digitos(Now.Date))

            lstr_textfile.Append(strHora)
            lstr_textfile.Append(strCodCliente)
            fl.WriteLine(lstr_textfile.ToString())

            'Cuerpo
            For i As Integer = 0 To oDt.Rows.Count - 1

                If (i = 0 And lstr_CREFFW = "") Or (lstr_CREFFW <> "" And lstr_CREFFW <> oDt.Rows(i).Item(0).ToString().Trim() And i <> 0) Then
                    lstr_CREFFW = oDt.Rows(i).Item(0).ToString().Trim
                    If lstr_textfile.Length > 0 Then
                        lstr_textfile.Remove(0, lstr_textfile.Length)
                    End If
                    If lstr_textfileOC.Length > 0 Then
                        lstr_textfileOC.Remove(0, lstr_textfileOC.Length)
                    End If
                    If lstr_textfileOCItem.Length > 0 Then
                        lstr_textfileOCItem.Remove(0, lstr_textfileOCItem.Length)
                    End If
                    lstr_textfile.Append("H1")
                    For Each objTemp As DataFormat In objListaColumnas
                        For x As Integer = 0 To oDt.Columns.Count - 1
                            'si la columna es la adecuada
                            If String.Compare(oDt.Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDt.Rows(i).Item(x).ToString(), objTemp._columnlenght))

                            End If
                        Next
                    Next
                    intNroBulto += 1
                    'intNroBultoLineas += 1
                    fl.WriteLine(lstr_textfile.ToString())

                    lstr_textfileOC.Append("L1")
                    For Each objTemp As DataFormat In objListaColOC
                        For x As Integer = 0 To oDt.Columns.Count - 1
                            If String.Compare(oDt.Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfileOC.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDt.Rows(i).Item(x).ToString(), objTemp._columnlenght))
                                'intNroBultoLineas += 1
                            End If
                        Next
                    Next
                    'intNroBultoLineas += 1
                    fl.WriteLine(lstr_textfileOC.ToString())

                    lstr_textfileOCItem.Append("L2")
                    For Each objTemp As DataFormat In objListaColOCItem
                        For x As Integer = 0 To oDt.Columns.Count - 1
                            If String.Compare(oDt.Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfileOCItem.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDt.Rows(i).Item(x).ToString(), objTemp._columnlenght))

                            End If
                        Next
                    Next
                    'intNroBultoLineas += 1
                    fl.WriteLine(lstr_textfileOCItem.ToString())
                Else
                    If lstr_CREFFW = oDt.Rows(i).Item(0).ToString().Trim() Then
                        If lstr_textfileOCItem.Length > 0 Then
                            lstr_textfileOCItem.Remove(0, lstr_textfileOCItem.Length)
                            lstr_textfileOCItem.Append("L2")
                            For Each objTemp As DataFormat In objListaColOCItem
                                For x As Integer = 0 To oDt.Columns.Count - 1
                                    If String.Compare(oDt.Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                        lstr_textfileOCItem.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDt.Rows(i).Item(x).ToString(), objTemp._columnlenght))
                                    End If
                                Next
                            Next
                            'intNroBultoLineas += 1
                            fl.WriteLine(lstr_textfileOCItem.ToString())
                        End If

                    End If
                End If
            Next

            'Pie
            'Limpiamos la variable
            If lstr_textfile.Length > 0 Then
                lstr_textfile.Remove(0, lstr_textfile.Length)
            End If
            intNroBultoLineas = oDt.Rows.Count + intNroBulto * 2  '+= intNroBultoLineas + 2

            lstr_textfile.Append("ZZ")
            lstr_textfile.Append(intNroBulto.ToString.PadLeft(6, "0"))
            lstr_textfile.Append(intNroBultoLineas.ToString.PadLeft(9, "0"))
            fl.WriteLine(lstr_textfile)

            fl.Flush()
            fl.Close()
        End Using
        HelpClass.AbrirDocumento(archivo)
    End Sub


    Private Sub ExportarTxtDespacho()
        If dgDespachoOC.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgDespachoOC.EndEdit()
        Dim strPlanta As String = String.Empty
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        Dim obeDespMov As beDespachoMovimientos
        'Dim olbeDesp As New List(Of beGuiaRemision)
        Dim loDespachoMovimientos_BE As New List(Of beDespachoMovimientos)
        For i As Int32 = 0 To dgDespachoOC.RowCount - 1
            If dgDespachoOC.Rows(i).Cells("Chk").Value = True Then
                obeDespMov = New beDespachoMovimientos
                obeDespMov.PNNGUIRM = Me.dgDespachoOC.Item("NGUIRM", i).Value.ToString.Trim()
                obeDespMov.PNCPLNDV = Me.dgDespachoOC.Item("CPLNDV", i).Value.ToString.Trim()
                obeDespMov.PSCREFFW = Me.dgDespachoOC.Item("CREFFW4", i).Value.ToString.Trim()
                loDespachoMovimientos_BE.Add(obeDespMov)
            End If
        Next
        'loDespachoMovimientos_BE = Me.dgDespachoOC.DataSource.FindAll(MatchSelectDesMov)
        If loDespachoMovimientos_BE.Count = 0 Then Exit Sub

        Dim lstrCPLNDV As String = ""
        For i As Integer = 0 To loDespachoMovimientos_BE.Count - 1
            If i = 0 Then
                strPlanta = loDespachoMovimientos_BE.Item(i).PNCPLNDV.ToString().Trim() + ","
                lstrCPLNDV = loDespachoMovimientos_BE.Item(i).PNCPLNDV.ToString().Trim()
            Else
                If lstrCPLNDV.Trim() <> loDespachoMovimientos_BE.Item(i).PNCPLNDV.ToString().Trim() Then
                    strPlanta += loDespachoMovimientos_BE.Item(i).PNCPLNDV + ","
                    lstrCPLNDV = loDespachoMovimientos_BE.Item(i).PNCPLNDV
                End If
            End If
        Next

        If strPlanta.Length > 0 Then
            strPlanta = strPlanta.Substring(0, strPlanta.Length - 1)
        End If

        Dim intNroDesp As Integer = 0
        Dim intNroDespLineas As Integer = 0
        Dim path As String = Application.StartupPath.ToString
        Dim strNombreArchivo As String = ""
        Dim strHora As String = Now.Hour.ToString().PadLeft(2, "0") + Now.Minute.ToString().PadLeft(2, "0") + Now.Second.ToString().PadLeft(2, "0")

        strNombreArchivo = "DERN" & Me.txtCliente.pCodigo.ToString & HelpClass.CDate_a_Numero8Digitos(Now.Date).ToString
        Dim archivo As String = path & "\" & strNombreArchivo & ".txt"
        Dim lstr_NGUIRM As String = ""

        Using fl As New StreamWriter(archivo, False)
            Dim lstr_textfile As New System.Text.StringBuilder
            'Creamos la cabecera
            Dim strCodCliente As String = Me.txtCliente.pCodigo.ToString.PadLeft(6, "0")
            lstr_textfile.Append("AA")
            lstr_textfile.Append(HelpClass.CDate_a_Numero8Digitos(Now.Date))

            lstr_textfile.Append(strHora)
            lstr_textfile.Append(strCodCliente)
            fl.WriteLine(lstr_textfile.ToString())

            For Each obeDesMov As beDespachoMovimientos In loDespachoMovimientos_BE
                Dim oDs As DataSet
                'obeDesMov.PSCCMPN = "EZ"
                'obeDesMov.PSCDVSN = "R"
                'obeDesMov.PSPLANTA = strPlanta
                'obeDesMov.PNCCLNT = Me.txtCliente.pCodigo

                With obeBulto
                    .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = UcDivision_Cmb011.Division
                    .PSPLANTA = strPlanta
                    .PNCCLNT = txtCliente.pCodigo
                    .PNNGUIRM = obeDesMov.PNNGUIRM
                    .PSCREFFW = obeDesMov.PSCREFFW
                End With

                oDs = obrBulto.fdtListaBultoDespachoParaExportarTxt(obeBulto)
                intNroDespLineas += oDs.Tables(1).Rows.Count
                '---------------------------------------------------------------------
                'Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
                'oDs = obrGuiaRemision.fdtGuiaRemisionParaExportarTxt(obeGui)
                'intNroGuiaLineas += oDs.Tables(1).Rows.Count
                'Crean la estructura H1
                Dim objListaColumnas As New List(Of RANSA.Utilitario.Helpclass_txt.DataFormat)
                objListaColumnas.Add(New DataFormat("NGUIRM", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("FGUIRM", 8, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("ORIGEN", 80, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("DESTINO", 80, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NRUCTR", 15, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TCMTRT", 40, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NPLCCM", 6, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NPLACP", 6, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NBRVCH", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("SMTGRM", 1, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TOBORM", 30, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("CPRCN1", 4, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NSRCN1", 7, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TTMNCN", 2, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("CPRCN2", 4, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NSRCN2", 7, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TTMNCN1", 2, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("QPSOBL_E", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("QPSOBL_D", 5, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TNMBCH", 40, AutoCompleteType.White_Space, CharDirection.Left))
                'Generando el archivo

                If lstr_NGUIRM = "" Then
                    lstr_NGUIRM = oDs.Tables(0).Rows(0).Item(0).ToString().Trim()
                    For i As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                        If lstr_textfile.Length > 0 Then
                            lstr_textfile.Remove(0, lstr_textfile.Length)
                        End If
                        lstr_textfile.Append("H1")
                        For Each objTemp As DataFormat In objListaColumnas
                            For x As Integer = 0 To oDs.Tables(0).Columns.Count - 1
                                'si la columna es la adecuada
                                If objTemp._columnname = "NSRCN2" Then
                                    x = x
                                End If
                                If String.Compare(oDs.Tables(0).Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                    lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDs.Tables(0).Rows(i).Item(x).ToString(), objTemp._columnlenght))
                                End If
                            Next
                        Next
                        intNroDesp += 1
                        fl.WriteLine(lstr_textfile.ToString())
                    Next

                Else
                    If oDs.Tables(0).Rows(0).Item(0).ToString().Trim() <> lstr_NGUIRM Then
                        lstr_NGUIRM = oDs.Tables(0).Rows(0).Item(0).ToString().Trim()
                        For i As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                            If lstr_textfile.Length > 0 Then
                                lstr_textfile.Remove(0, lstr_textfile.Length)
                            End If
                            lstr_textfile.Append("H1")
                            For Each objTemp As DataFormat In objListaColumnas
                                For x As Integer = 0 To oDs.Tables(0).Columns.Count - 1
                                    'si la columna es la adecuada
                                    If objTemp._columnname = "NSRCN2" Then
                                        x = x
                                    End If
                                    If String.Compare(oDs.Tables(0).Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                        lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDs.Tables(0).Rows(i).Item(x).ToString(), objTemp._columnlenght))
                                    End If
                                Next
                            Next
                            intNroDesp += 1
                            fl.WriteLine(lstr_textfile.ToString())
                        Next
                    End If
                End If



                'Limpiamos la variable
                If lstr_textfile.Length > 0 Then
                    lstr_textfile.Remove(0, lstr_textfile.Length)
                End If

                'Crean la estructura H1
                Dim objListaColumnas_L2 As New List(Of RANSA.Utilitario.Helpclass_txt.DataFormat)

                objListaColumnas_L2.Add(New DataFormat("NGUIRM", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CREFFW", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CIDPAQ", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NORCML", 35, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NRITOC", 6, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("NFCPRT", 15, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NITPRT", 18, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("FFCPRT", 8, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("QCNTDC_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QCNTDC_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QBLTSR_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QBLTSR_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QPSOBL_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QPSOBL_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("TUNPSO", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("QVLBTO_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QVLBTO_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("TUNVOL", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CREEMB", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("FREFFW", 8, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NGRPRV", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("TLUGEN", 50, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("STRNSM", 1, AutoCompleteType.White_Space, CharDirection.Left))

                'Generando el archivo

                For i As Integer = 0 To oDs.Tables(1).Rows.Count - 1
                    If lstr_textfile.Length > 0 Then
                        lstr_textfile.Remove(0, lstr_textfile.Length)
                    End If
                    lstr_textfile.Append("L1")
                    For Each objTemp As DataFormat In objListaColumnas_L2
                        For x As Integer = 0 To oDs.Tables(1).Columns.Count - 1
                            'si la columna es la adecuada
                            If String.Compare(oDs.Tables(1).Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDs.Tables(1).Rows(i).Item(x).ToString(), objTemp._columnlenght))
                            End If
                        Next
                    Next

                    fl.WriteLine(lstr_textfile.ToString())
                Next


            Next


            'Creamos el pie de txt
            'Limpiamos la variable
            If lstr_textfile.Length > 0 Then
                lstr_textfile.Remove(0, lstr_textfile.Length)
            End If
            'intNroDesp = loDespachoMovimientos_BE.Count
            intNroDespLineas += intNroDesp

            lstr_textfile.Append("ZZ")
            lstr_textfile.Append(intNroDesp.ToString.PadLeft(6, "0"))
            lstr_textfile.Append(intNroDespLineas.ToString.PadLeft(9, "0"))
            fl.WriteLine(lstr_textfile)
            fl.Flush()
            fl.Close()
        End Using

        HelpClass.AbrirDocumento(archivo)


    End Sub

    Private Sub dgDespachoOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDespachoOC.CellContentClick

    End Sub
End Class
