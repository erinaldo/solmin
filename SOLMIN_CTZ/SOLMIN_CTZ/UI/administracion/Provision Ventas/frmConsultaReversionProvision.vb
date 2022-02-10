Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Ransa.Controls.ServicioOperacion

Public Class frmConsultaReversionProvision
    Private Estatico As New Estaticos
    Private oServicioOpeBE As ServicioOperacion
    Private oServicioOpeBLL As New clsServicioOperacion
    Private oServicio As Servicio_BE
    Private oServicioOpeNeg As New clsServicio_BL
    Private oDtServicioDet As DataTable
    Public sTotalDatosPorOperacion As String
    Private oDtSerivcio As DataTable

    Private Sub frmConsultaOperacionesFacturadasFM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        Dim oLis As New List(Of String)
        oLis.Add("100")
        oLis.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
        Dim oDtTipoCambio As New DataTable
        oDtTipoCambio = oServicioOpeNeg.Lista_Tipo_Cambio(oLis)
        If oDtTipoCambio.Rows.Count > 0 Then
            lblTipoCambio_1.Text = oDtTipoCambio.Rows(0).Item("IVNTA").ToString.Trim
        Else
            lblTipoCambio_1.Text = "0"
            lblTipoCambio_1.Text = "0"
        End If

        Cargar_Region_Venta()


    End Sub
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta
    End Sub
    Public Sub Limpiar_Detalle_Servicios()
        Me.dtgServiciosOperacion.DataSource = Nothing
        Me.dtgDetalleServicioSil.DataSource = Nothing
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        Me.dtgReembolso.DataSource = Nothing
    End Sub
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()
    End Sub
    Private Sub Refrescar()
        Limpiar_Detalle_Servicios()
        Listar_Operaciones()
        dtgOperaciones_CurrentCellChanged(Nothing, Nothing)
    End Sub
    Private Sub Listar_Operaciones()
        oDtServicioDet = New DataTable
        oDtSerivcio = New DataTable
        oServicioOpeBE = New ServicioOperacion
        oServicio = New Servicio_BE

        'Sacamso el Tipo de Cambio
        Dim oLis As New List(Of String)
        oLis.Add("100")
        oLis.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
        Dim oDtTipoCambio As New DataTable
        oDtTipoCambio = oServicioOpeNeg.Lista_Tipo_Cambio(oLis)
        If oDtTipoCambio.Rows.Count > 0 Then
            lblTipoCambio_1.Text = oDtTipoCambio.Rows(0).Item("IVNTA").ToString.Trim
        Else
            lblTipoCambio_1.Text = "0"
            lblTipoCambio_1.Text = "0"
        End If

        '''''''''''''''''''''''''''''''''
        oServicioOpeBE.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicioOpeBE.CDVSN = UcDivision.Division
        oServicioOpeBE.FOPRCN_INI = HelpClass.FormatoFechaAS400(Me.DateTimePicker2.Text)
        oServicioOpeBE.FOPRCN_FIN = HelpClass.FormatoFechaAS400(Me.dtpFechaFin.Text)
        oServicioOpeBE.CRGVTA = Me.cmbRegionVenta.SelectedValue
        'Llennar Servicio Opreacion
        oDtSerivcio = oServicioOpeBLL.fdtLista_Operaciones_Facturadas_FM(oServicioOpeBE)

        oDtServicioDet = oServicioOpeBLL.fdtLista_Operaciones_Facturadas_FM(oServicioOpeBE)
        oDtServicioDet.Columns.Add("TIP_ALJ")
        oDtServicioDet.Columns(35).SetOrdinal(13)
        For i As Integer = 0 To oDtServicioDet.Rows.Count - 1
            Select Case Me.oDtServicioDet.Rows(i).Item("CTPALJ").ToString.Trim
                Case Estatico.E_ESP_Manual '"MA"
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "MANUAL"
                Case Estatico.E_ESP_Adicional '"AD"
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "ADICIONAL"
                Case Estatico.E_ESP_General, "" '"GE"
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "GENERAL"
                Case Estatico.E_ESP_Reembolso
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "REEMBOLSO"
                Case Estatico.E_ESP_Almacenaje '"AL"
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "ALMACENAJE"
                Case Estatico.E_ESP_AlmacenajePeso 'AP
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "ALMACENAJE POR FECHA DE CORTE"
                Case Estatico.E_ESP_ManipuleoPeso 'MP
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "MANIPULEO POR FECHA DE CORTE"
                Case Estatico.E_ESP_PesoPromedio 'PP
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "ALMACENAJE POR PESO PROMEDIOS"
                Case Estatico.E_ESP_Permanencia 'PE
                    Me.oDtServicioDet.Rows(i).Item("TIP_ALJ") = "ALMACENAJE POR PERMANENCIA"

            End Select
            'oDtServicioDet.Rows(i).Item("HDSGDC") = Format(oDtServicioDet.Rows(i).Item("HDSGDC"), "h:mm:ss tt")
        Next

        oDtServicioDet.Columns.Remove("CTPALJ")
        oDtServicioDet.Columns.Remove("CTPODC")
        oDtServicioDet.Columns.Remove("CRGVTA")
        oDtServicioDet.Columns.Remove("CCLNFC")
        oDtServicioDet.Columns.Remove("CCLNT")
        oDtServicioDet.Columns.Remove("STPODP")
        oDtServicioDet.Columns.Remove("CMNDA1")
        oDtServicioDet.Columns.Remove("CPLNDV")
        oDtServicioDet.Columns.Remove("STIPPR")
        oDtServicioDet.Columns.Remove("CDVSN")
        oDtServicioDet.Columns.Remove("CCMPN")
        oDtServicioDet.Columns.Remove("CANT_DOC")
        oDtServicioDet.Columns.Remove("FCHCRT")
        oDtServicioDet.Columns.Remove("HRACRT")
        oDtServicioDet.Columns.Remove("CUSCRT")
        oDtServicioDet.Columns.Remove("FULTAC")
        oDtServicioDet.Columns.Remove("HULTAC")
        oDtServicioDet.Columns.Remove("CULUSA")
        oDtServicioDet.Columns.Remove("TIPO_REV")
        oDtServicioDet.Columns.Remove("TCMPDV")
        oDtServicioDet.Columns(10).SetOrdinal(1)
        oDtServicioDet.Columns(10).SetOrdinal(7)
        oDtServicioDet.Columns(13).SetOrdinal(12)
        oDtServicioDet.Columns(0).ColumnName = "OPERACIÓN"
        oDtServicioDet.Columns(1).ColumnName = "PLANTA"
        oDtServicioDet.Columns(2).ColumnName = "FECHA"
        oDtServicioDet.Columns(3).ColumnName = "CLIENTE OPERACION"
        oDtServicioDet.Columns(4).ColumnName = "CLIENTE A FACTURAR"
        oDtServicioDet.Columns(5).ColumnName = "MONEDA"
        oDtServicioDet.Columns(6).ColumnName = "IMPORTE TARIFA"
        oDtServicioDet.Columns(7).ColumnName = "PROCESO"
        oDtServicioDet.Columns(8).ColumnName = "NRO. REVISIÓN"
        oDtServicioDet.Columns(9).ColumnName = "N° FACTURA"
        oDtServicioDet.Columns(10).ColumnName = "TIPO SERVICIO"
        oDtServicioDet.Columns(11).ColumnName = "TIPO ALMACENAJE"
        oDtServicioDet.Columns(12).ColumnName = "ESTADO DOCUMENTO"
        oDtServicioDet.Columns(13).ColumnName = "HORA SEG."
        oDtServicioDet.Columns(14).ColumnName = "RESPONSABLE"
        oDtServicioDet.Columns(15).ColumnName = "OBSERVACIÓN"
        oDtServicioDet.TableName = "Reporte"

        If Not oDtServicioDet.Columns.Contains("ESTADOOP") Then
            oDtServicioDet.Columns.Add("ESTADOOP")
        End If
        oDtServicioDet.Columns(16).SetOrdinal(0)

        dtgOperaciones.AutoGenerateColumns = False
        dtgOperaciones.DataSource = oDtSerivcio

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Refrescar()
    End Sub
    Private Sub dtgOperaciones_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.CurrentCellChanged
        If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Cargar_Servicios_x_Operacion()
    End Sub
    Private Sub Cargar_Servicios_x_Operacion()
        Dim oDt As New DataTable
        Dim _oServicioOper As New Servicio_BE
        Me.dtgServiciosOperacion.DataSource = Nothing
        If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        _oServicioOper.CDVSN = dtgOperaciones.CurrentRow.DataBoundItem.Item("CDVSN")
        _oServicioOper.CCMPN = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCMPN")
        _oServicioOper.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
        oDt = oServicioOpeNeg.fdtListaServicioOperacion(_oServicioOper)
        dtgServiciosOperacion.AutoGenerateColumns = False
        dtgServiciosOperacion.DataSource = oDt
        Cargar_Detalle_Servicios()

    End Sub
    Private Sub Cargar_Detalle_Servicios()
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dtgServiciosOperacion.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        dtgDetalleServicioSil.DataSource = Nothing

        oServicio.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
        oServicio.NRTFSV = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("NRTFSV")
        oServicio.CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
        oServicio.STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
        oServicio.CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")

        Dim iValida As String = oServicio.STPODP

        If oServicio.CTPALJ <> Estatico.E_ESP_General Then iValida = oServicio.CTPALJ.Trim '"GE"

        InhabilitaTabs()
        HabilitaTabs(oServicio.CDVSN, oServicio.STPODP.Trim, oServicio.CTPALJ.Trim)

        Select Case oServicio.CDVSN
            Case "R" ' =========ALMACEN===========

                Select Case iValida
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio, Estatico.E_ESP_Almacenaje
                        dtgBultos.AutoGenerateColumns = False
                        dtgBultos.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple '"1", "5"
                        dtgMercaderia.AutoGenerateColumns = False
                        Me.dtgMercaderia.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        dtgReembolso.AutoGenerateColumns = False
                        Me.dtgReembolso.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosReembolso(oServicio)
                End Select
            Case "S" ' ===========SIL=============
                Dim oDt As New DataTable
                Dim oclsServicioSC_DAL As New clsServicioSC_DAL
                oDt = oclsServicioSC_DAL.Lista_Detalle_Servicios_SC(oServicio)
                dtgDetalleServicioSil.AutoGenerateColumns = False
                dtgDetalleServicioSil.DataSource = oDt
        End Select
    End Sub
    Public Sub InhabilitaTabs()
        Me.TabDetalles.TabPages.Remove(TabBulto)
        Me.TabDetalles.TabPages.Remove(TabEmbarque)
        Me.TabDetalles.TabPages.Remove(TabMercaderia)
        Me.TabDetalles.TabPages.Remove(TabReembolso)
    End Sub
    Public Sub HabilitaTabs(ByVal pstrDivision As String, Optional ByVal tAlm As Integer = 0, Optional ByVal tCTPALJ As String = "")
        'Utiliza el tipo de la celda     
        Select Case pstrDivision
            Case "S"
                Me.TabDetalles.TabPages.Add(TabEmbarque)
            Case "R"
                Select Case tAlm.ToString
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_Almacenaje '"AL"
                        Me.TabDetalles.TabPages.Add(TabBulto)
                    Case Estatico.E_ESP_PesoPromedio
                        '====================================================================
                        '======================EL TAB CON LOS PROMEDIOS======================
                        '====================================================================
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple
                        Me.TabDetalles.TabPages.Add(TabMercaderia)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        Me.TabDetalles.TabPages.Add(TabReembolso)
                End Select
        End Select
    End Sub
    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Dim sumaDolares As Double = 0D
        Dim sumaSoles As Double = 0D
        Dim cambio As Double = CType(IIf(lblTipoCambio_1.Text = "0", "0", lblTipoCambio_1.Text), Decimal)
        Dim montoTemp As Double = 0D
        For i As Integer = 0 To dtgOperaciones.Rows.Count - 1
            If Me.dtgOperaciones.Rows(i).Cells("CMNDA1").Value() = 100 Then
                montoTemp = IIf(IsDBNull(Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()), 0, Me.dtgOperaciones.Rows(i).Cells("MONTO").Value())
                sumaDolares = sumaDolares + montoTemp
                If cambio <> 0 Then
                    sumaSoles = sumaSoles + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() * cambio)
                End If
            Else
                If cambio <> 0 Then
                    sumaDolares = sumaDolares + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() / cambio)
                End If
                sumaSoles = sumaSoles + Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()
            End If
            'DESCRIPCION TIPO ALMACENAJE-
            Select Case Me.dtgOperaciones.Rows(i).Cells("CTPALJ").Value.ToString.Trim
                Case Estatico.E_ESP_Manual '"MA"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANUAL"
                Case Estatico.E_ESP_Adicional '"AD"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ADICIONAL"
                Case Estatico.E_ESP_General, "" '"GE"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "GENERAL"
                Case Estatico.E_ESP_Reembolso
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "REEMBOLSO"
                Case Estatico.E_ESP_Almacenaje '"AL"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE"
                Case Estatico.E_ESP_AlmacenajePeso 'AP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR FECHA DE CORTE"
                Case Estatico.E_ESP_ManipuleoPeso 'MP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANIPULEO POR FECHA DE CORTE"
                Case Estatico.E_ESP_PesoPromedio 'PP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PESO PROMEDIOS"
                Case Estatico.E_ESP_Permanencia 'PE
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PERMANENCIA"

            End Select

            If Me.dtgOperaciones.Rows(i).Cells("CANT_DOC").Value() > 0 Then
                Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.text_block
            Else
                Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.filesave
            End If


        Next

        sTotalDatosPorOperacion = "Monto a Cobrar : S/. " & Format(sumaSoles, "###,###,###,###.00") & " / - - / Monto a Cobrar : USD " & Format(sumaDolares, "###,###,###,###.00")
        HGDatos.ValuesSecondary.Heading = sTotalDatosPorOperacion
    End Sub
    Private Sub dtgOperaciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
            If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
                dtgOperaciones.CurrentRow.Cells("chk").Value = False
                Me.dtgOperaciones.EndEdit()
            End If
        End If

    End Sub
    Private Sub dtgOperaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellDoubleClick
        Try
            If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
                If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
                    dtgOperaciones.CurrentRow.Cells("chk").Value = False
                    Me.dtgOperaciones.EndEdit()
                End If
            End If



            If dtgOperaciones.Columns(e.ColumnIndex).Name = "AUDI" Then
                Dim ofrmAuditoria As New frmAuditoria
                With ofrmAuditoria
                    .txtUsuarioCreador.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CUSCRT")
                    .txtFechaCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FCHCRT")
                    .txtHoraCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HRACRT")

                    .txtFechaActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FULTAC")
                    .txtUsuarioActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CULUSA")
                    .txtHoraActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HULTAC")
                End With


                ofrmAuditoria.ShowDialog()

            End If
        Catch : End Try
    End Sub
    Private Sub dtgBultos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBultos.CellContentClick
        If Me.dtgBultos.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgBultos.Columns(e.ColumnIndex).Name = "IMG" Then
            'Dim oServicio As New Servicio_BE
            With oServicio
                '.CCMPN = cmbCompania.SelectedValue
                '.CDVSN = cmbDivision.SelectedValue
                .CPLNDV = Me.dtgOperaciones.CurrentRow.Cells("CPLNDV").Value.ToString.Trim
                .CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value.ToString.Trim
                .CREFFW = Me.dtgBultos.CurrentRow.Cells("CREFFW").Value.ToString.Trim
                .NSEQIN = Me.dtgBultos.CurrentRow.Cells("NSEQIN").Value.ToString.Trim
                .STIPPR = Me.dtgOperaciones.CurrentRow.Cells("STIPPR").Value.ToString.Trim
            End With
            Dim ofrmDetalleBulto As New frmDetalleBulto
            ofrmDetalleBulto.oDetalleServicio = oServicio
            If ofrmDetalleBulto.ShowDialog() = DialogResult.Cancel Then
            End If
        End If


    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim oDs As New DataSet
        oServicioOpeBE = New ServicioOperacion
        oServicioOpeBE.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicioOpeBE.CDVSN = UcDivision.Division
        oServicioOpeBE.FOPRCN_INI = HelpClass.FormatoFechaAS400(Me.DateTimePicker2.Text)
        oServicioOpeBE.FOPRCN_FIN = HelpClass.FormatoFechaAS400(Me.dtpFechaFin.Text)
        oServicioOpeBE.CRGVTA = Me.cmbRegionVenta.SelectedValue
        oDs = oServicioOpeBLL.fdsLista_Operaciones_Facturadas_FM_Exportar(oServicioOpeBE)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)
        Dim lstSuma As New List(Of Hashtable)
        oDs.Tables(0).TableName = "Reporte1"
        oDs.Tables(1).TableName = "Reporte2"
        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("División :\n " & Me.UcDivision.DivisionDescripcion)
        olstr.Add("Negocio:\n " & IIf(Me.cmbRegionVenta.Text.Trim.Equals(""), "TODOS", Me.cmbRegionVenta.Text))
        olstr.Add("Fecha:\n " & Ransa.Utilitario.HelpClass.DateConvert(Me.DateTimePicker2.Value.ToString) & " Al " & Ransa.Utilitario.HelpClass.DateConvert(Me.dtpFechaFin.Value.ToString))     'Me.dtFeFinal.Value

        Dim olstrSuma As New Hashtable
        olstrSuma.Add(1.2, 21)
        olstrSuma.Add(1.3, 24)

        Dim decNumero As Decimal = 0
        For intColum As Integer = 5 To oDs.Tables(1).Columns.Count - 1
            decNumero = CType((2 & "." & intColum).ToString, Decimal)
            olstrSuma.Add(decNumero, intColum + 2)
        Next

        Ransa.Utilitario.HelpClass.ExportExcelConsultaFacturadasFM(oDs, "Reversión de Provisión", olstr, olstrSuma)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDs As New DataSet

        Dim odt As New DataTable

        odt.Columns.Add("ID")
        odt.Columns.Add("Valor")
        Try
            Dim odr As DataRow
            odr = odt.NewRow

            odr.Item(0) = "Lima"
            odr.Item(1) = "20"
            odt.Rows.Add(odr)

            odr = odt.NewRow
            odr.Item(0) = "Huaraz"
            odr.Item(1) = "50"
            odt.Rows.Add(odr)

            odr = odt.NewRow
            odr.Item(0) = "Chiclayo"
            odr.Item(1) = "30"
            odt.Rows.Add(odr)

            oDs.Tables.Add(odt)
            Dim olstr As New List(Of String)
            Dim lstSuma As New List(Of Hashtable)
            oDs.Tables(0).TableName = "Reporte1"

            Ransa.Utilitario.HelpClass.ExportarPrueba(oDs, "Reversión de Provisión", olstr)
        Catch ex As Exception

        End Try

    End Sub
End Class
