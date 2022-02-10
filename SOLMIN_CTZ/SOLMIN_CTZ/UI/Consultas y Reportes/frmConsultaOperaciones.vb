Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Odbc
Imports Ransa.Controls.ServicioOperacion

Public Class frmConsultaOperaciones
    Private Estatico As New Estaticos
    Private oEstadoFactura As New clsEstadoNeg
    Private bolBuscar As Boolean = False
    Private oServicioOpeNeg As New clsServicio_BL
    Private oServicio As Servicio_BE
    Private oDtTiposDocumentos As New DataTable
    Private oDtPlanta As New DataTable
    Private oPlanta As New clsPlantaNeg
    Private olOperacion As New List(Of Servicio_BE)
    Private oDtSerivcio As DataTable
    Private oDtServicioDet As DataTable
    Public sTotalDatosPorOperacion As String

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Refrescar()
    End Sub

    Public Sub Limpiar_Detalle_Servicios()
        Me.dtgServiciosOperacion.DataSource = Nothing
        Me.dtgDetalleServicioSil.DataSource = Nothing
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        Me.dtgReembolso.DataSource = Nothing
    End Sub

    Private Sub Refrescar()
        Limpiar_Detalle_Servicios()
        Listar_Operaciones()
        dtgOperaciones_CurrentCellChanged(Nothing, Nothing)
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

 

    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta
    End Sub

    Private Sub Carga_Estado()
        oEstadoFactura.Estado_Operacion()
        bolBuscar = False
        cmbEstadoFactura.DataSource = oEstadoFactura.Tabla
        cmbEstadoFactura.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoFactura.DisplayMember = "TEX"
        cmbEstadoFactura.SelectedValue = "0"
    End Sub

    Private Sub CargarPlanta()
        Try
            Dim oDtAux As New DataTable
            Dim oDr As DataRow

            oDtAux.Columns.Add("CPLNDV", GetType(String))
            oDtAux.Columns.Add("TPLNTA", GetType(String))


            oDtPlanta = oPlanta.Lista_Planta_Division(UcCompania.CCMPN_CodigoCompania, UcDivision.Division)
            For Each dr As DataRow In oDtPlanta.Rows
                oDr = oDtAux.NewRow
                oDr("CPLNDV") = dr("CPLNDV")
                oDr("TPLNTA") = dr("TPLNTA")
                oDtAux.Rows.Add(oDr)
            Next
            oDtPlanta = oDtAux
            cmbPlanta.ValueMember = "CPLNDV"
            cmbPlanta.DisplayMember = "TPLNTA"
            cmbPlanta.DataSource = oDtPlanta
            For i As Integer = 0 To cmbPlanta.Items.Count - 1
                If cmbPlanta.Items.Item(i).Value = "0" Then
                    cmbPlanta.SetItemChecked(i, True)
                End If
            Next
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

    End Sub


    Private Sub frmConsultaOperaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        Carga_Estado()
        Cargar_Region_Venta()
        oPlanta.Crea_Lista(ConfigurationWizard.UserName)
        CargarPlanta()

        Dim oLis As New List(Of String)
        oLis.Add("100")
        oLis.Add(Format(Now, "yyyyMMdd"))

        If oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows.Count > 0 Then
            lblTipoCambio_1.Text = oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows(0).Item("IVNTA").ToString.Trim
        Else
            lblTipoCambio_1.Text = "0"
        End If

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

    Private Function Lista_Tipo_Planta() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function


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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


      
       
    End Sub


    Private Sub Listar_Operaciones()
        oDtServicioDet = New DataTable
        oDtSerivcio = New DataTable
        oServicio = New Servicio_BE
        '''''''''''''''''''''''''''''''''
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.PSUSUARIO = ConfigurationWizard.UserName
        oServicio.CDVSN = UcDivision.Division
        ''
        oServicio.TIPO_PLANTA = Lista_Tipo_Planta()
        oServicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.TCMPDV = UcDivision.DivisionDescripcion
        oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
        oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)
     
        If chkFechaOperacion.Checked Then
            oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaOperacionIni.Text)
            oServicio.FECSERV_FIN = Comun.FormatoFechaAS400(Me.dtpFechaOperacionFin.Text)
        Else
            oServicio.FECSERV_INI = 0
            oServicio.FECSERV_FIN = 0
        End If
        oServicio.CCMPN_DESC = UcCompania.CCMPN_Descripcion
        oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
        oServicio.CCLNT_DESC = UcCliente.pRazonSocial
        oServicio.FLGPEN = cmbEstadoFactura.SelectedValue
        oServicio.CRGVTA = Me.cmbRegionVenta.SelectedValue
        'Llennar Servicio Opreacion
        oServicio.NOPRCN = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
        oDtSerivcio = oServicioOpeNeg.fdtListaOperaciones(oServicio)

        oDtServicioDet = oDtSerivcio.Copy

        'oDtServicioDet = oServicioOpeNeg.fdtListaOperaciones(oServicio)
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

    

    Private Sub fExportarExcelResumido()
        'oDtSerivcio = New DataTable
        Refrescar()

        oServicio = New Servicio_BE
        '''''''''''''''''''''''''''''''''
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.PSUSUARIO = ConfigurationWizard.UserName
        oServicio.CDVSN = UcDivision.Division
        ''
        oServicio.TIPO_PLANTA = Lista_Tipo_Planta()
        oServicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.TCMPDV = UcDivision.DivisionDescripcion
       
        oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
        oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)

        If chkFechaOperacion.Checked Then
            oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaOperacionIni.Text)
        Else
            oServicio.FECSERV_INI = 0
            oServicio.FECSERV_FIN = 0
        End If
        oServicio.CCMPN_DESC = UcCompania.CCMPN_Descripcion
        oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
        oServicio.CCLNT_DESC = UcCliente.pRazonSocial
        oServicio.FLGPEN = cmbEstadoFactura.SelectedValue
        oServicio.CRGVTA = Me.cmbRegionVenta.SelectedValue
        'Llennar Servicio Opreacion
        oServicio.NOPRCN = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
        Dim oDs As New DataSet
        oDs = oServicioOpeNeg.fdsReporteDeOperacionesResumido(oServicio)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)

        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("División :\n " & Me.UcDivision.DivisionDescripcion)
        olstr.Add("Planta :\n " & IIf(Me.cmbPlanta.Text.Trim.Equals(""), "TODOS", Me.cmbPlanta.Text))
        olstr.Add("Fecha:\n " & Me.dtFeInicial.Value.Year.ToString & "/" & Me.dtFeInicial.Value.Month.ToString & "/" & Me.dtFeInicial.Value.Day & " - " & Me.dtFeFinal.Value.Year.ToString & "/" & Me.dtFeFinal.Value.Month & "/" & Me.dtFeFinal.Value.Day)
        'Me.dtFeFinal.Value


        '==========tabla 2====================
        For intCont As Integer = oDs.Tables(2).Rows.Count - 1 To 1 Step -1
            If oDs.Tables(2).Rows(intCont).Item("ESTADOOP") = oDs.Tables(2).Rows(intCont - 1).Item("ESTADOOP") And oDs.Tables(2).Rows(intCont).Item("""Rubro General""") = oDs.Tables(2).Rows(intCont - 1).Item("""Rubro General""") Then
                oDs.Tables(2).Rows(intCont).Item("""Rubro General""") = ""
            End If
        Next

        '==========tabla 2====================

        '================Limpiamos el estado y las comillas============================
        For Each oDt As DataTable In oDs.Tables
            For intCont As Integer = oDt.Rows.Count - 1 To 1 Step -1
                If oDt.Rows(intCont).Item("ESTADOOP") = oDt.Rows(intCont - 1).Item("ESTADOOP") Then
                    oDt.Rows(intCont).Item("""Estado Operación""") = ""
                End If
            Next
            For intCont As Integer = 0 To oDt.Columns.Count - 1
                Dim strColumName As String = """"
                strColumName = oDt.Columns(intCont).ColumnName.Trim.Replace(strColumName, "")
                oDt.Columns(intCont).ColumnName = strColumName
            Next

        Next
        '================Limpiamos el estado y las comillas============================

        '==========tabla 0====================
        For intCont As Integer = oDs.Tables(0).Rows.Count - 1 To 1 Step -1
            If oDs.Tables(0).Rows(intCont).Item("Cod. Cliente Operación") = oDs.Tables(0).Rows(intCont - 1).Item("Cod. Cliente Operación") Then
                oDs.Tables(0).Rows(intCont).Item("Cod. Cliente Operación") = DBNull.Value
                oDs.Tables(0).Rows(intCont).Item("Cliente de Operación") = ""
            End If
            'Cod. Cliente Facturar
            If oDs.Tables(0).Rows(intCont).Item("Cod. Cliente Facturar") = oDs.Tables(0).Rows(intCont - 1).Item("Cod. Cliente Facturar") Then
                oDs.Tables(0).Rows(intCont).Item("Cod. Cliente Facturar") = DBNull.Value
                oDs.Tables(0).Rows(intCont).Item("Cliente a Facturar") = ""
            End If
        Next

        Dim oDsExcel As New DataSet
        oDsExcel.Tables.Add(oDtServicioDet.Copy)

        Dim oDtResumen01 As DataTable
        Dim oDtResumen02 As DataTable
        Dim oDtResumen03 As DataTable

        oDtResumen01 = oDs.Tables(0).Clone
        oDtResumen02 = oDs.Tables(1).Clone
        oDtResumen03 = oDs.Tables(2).Clone

        Dim oDr As DataRow
        'Filtramos todas las Monedas que existen
        Dim oDv As New DataView(oDs.Tables(0))
        Dim oDtMonedas As DataTable
        oDtMonedas = oDv.ToTable(True, "Moneda")
        oDtMonedas.Columns.Add("TOTAL", GetType(Decimal))

        'Tabla  oDtResumen01
        '=========== Suma los Sub Totales =======================
        Dim bolContieneMov As Boolean = False
        For intRow As Integer = 1 To 3
            bolContieneMov = False
            oDtResumen01 = New DataTable
            oDtResumen01 = oDs.Tables(0).Clone
            For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                oDtMonedas.Rows(intCont).Item("TOTAL") = 0
            Next
            For Each drp As DataRow In oDs.Tables(0).Select("ESTADOOP=" & intRow)
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    If drp.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda") Then
                        oDtMonedas.Rows(intCont).Item("TOTAL") = Val("" & oDtMonedas.Rows(intCont).Item("TOTAL") & "") + Val("" & drp.Item("Monto") & "")
                    End If
                Next
                'dblSuma = dblSuma + Val("" & drp.Item("Monto") & "")
                oDtResumen01.ImportRow(drp)
                bolContieneMov = True
            Next
            If bolContieneMov Then
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    oDr = oDtResumen01.NewRow
                    oDr.Item("Fecha Operación") = "Total"
                    oDr.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda")
                    oDr.Item("Monto") = oDtMonedas.Rows(intCont).Item("TOTAL")
                    oDr.Item("ESTADOOP") = -1
                    oDtResumen01.Rows.Add(oDr)
                Next
                If intRow = 1 Then
                    'Eliminamos la columna Nr. Revisiòn

                End If

                Select Case intRow
                    Case 1
                        oDtResumen01.Columns.Remove("Nr. Revisión")
                        oDtResumen01.Columns.Remove("Nr. Documento Cta. Cte.")
                        oDtResumen01.Columns.Remove("Tipo Documento")

                    Case 2
                        oDtResumen01.Columns.Remove("Nr. Documento Cta. Cte.")
                        oDtResumen01.Columns.Remove("Tipo Documento")
                End Select
                oDtResumen01.TableName = "Operaciones - " & oDtResumen01.Rows(0).Item("Estado Operación").ToString
                oDtResumen01.Columns.Remove("Estado Operación")
                oDsExcel.Tables.Add(oDtResumen01)
            End If
        Next

        '==========tabla 1====================
        For intCont As Integer = oDs.Tables(1).Rows.Count - 1 To 1 Step -1
            If oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") = oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Facturar") And oDs.Tables(1).Rows(intCont).Item("Rubro General") = oDs.Tables(1).Rows(intCont - 1).Item("Rubro General") Then
                oDs.Tables(1).Rows(intCont).Item("Rubro General") = ""
            End If
            If oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Operación") = oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Operación") Then
                oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Operación") = DBNull.Value
                oDs.Tables(1).Rows(intCont).Item("Cliente de Operación") = ""
            End If
            'Cod. Cliente Facturar
            If oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") = oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Facturar") Then
                oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") = DBNull.Value
                oDs.Tables(1).Rows(intCont).Item("Cliente a Facturar") = ""
            End If
        Next

        'Tabla  oDtResumen02
        '=========== Suma los Sub Totales =======================

        For intRow As Integer = 1 To 3
            bolContieneMov = False
            For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                oDtMonedas.Rows(intCont).Item("TOTAL") = 0
            Next
            For Each drp As DataRow In oDs.Tables(1).Select("ESTADOOP=" & intRow)
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    If drp.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda") Then
                        oDtMonedas.Rows(intCont).Item("TOTAL") = Val("" & oDtMonedas.Rows(intCont).Item("TOTAL") & "") + Val("" & drp.Item("Monto") & "")
                    End If
                Next
                oDtResumen02.ImportRow(drp)
                bolContieneMov = True
            Next
            If bolContieneMov Then
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    oDr = oDtResumen02.NewRow
                    oDr.Item("Rubro Especifico") = "Total"
                    oDr.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda")
                    oDr.Item("Monto") = oDtMonedas.Rows(intCont).Item("TOTAL")
                    oDr.Item("ESTADOOP") = -1
                    oDtResumen02.Rows.Add(oDr)
                Next
            End If
        Next
        '=========== Suma los Sub Totales=======================

        '=========== Suma los Totales Generales =======================
        For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
            oDtMonedas.Rows(intCont).Item("TOTAL") = 0
        Next
        For Each drp As DataRow In oDs.Tables(1).Rows
            For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                If drp.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda") Then
                    oDtMonedas.Rows(intCont).Item("TOTAL") = Val("" & oDtMonedas.Rows(intCont).Item("TOTAL") & "") + Val("" & drp.Item("Monto") & "")
                End If
            Next
            bolContieneMov = True
        Next
        'Agregamos columna Vacio
        oDr = oDtResumen02.NewRow
        oDtResumen02.Rows.Add(oDr)

        For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
            oDr = oDtResumen02.NewRow
            oDr.Item("Rubro Especifico") = "Total General"
            oDr.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda")
            oDr.Item("Monto") = oDtMonedas.Rows(intCont).Item("TOTAL")
            oDr.Item("ESTADOOP") = -1
            oDtResumen02.Rows.Add(oDr)
        Next
        '=========== Suma los Totales Generales =======================


        'Tabla  oDtResumen03
        '=========== Suma los Sub Totales =======================

        For intRow As Integer = 1 To 3
            bolContieneMov = False
            For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                oDtMonedas.Rows(intCont).Item("TOTAL") = 0
            Next
            For Each drp As DataRow In oDs.Tables(2).Select("ESTADOOP=" & intRow)
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    If drp.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda") Then
                        oDtMonedas.Rows(intCont).Item("TOTAL") = Val("" & oDtMonedas.Rows(intCont).Item("TOTAL") & "") + Val("" & drp.Item("Monto") & "")
                    End If
                Next
                'dblSuma = dblSuma + Val("" & drp.Item("Monto") & "")
                oDtResumen03.ImportRow(drp)
                bolContieneMov = True
            Next
            If bolContieneMov Then
                For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                    oDr = oDtResumen03.NewRow
                    oDr.Item("Centro de Beneficio") = "Total"
                    oDr.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda")
                    oDr.Item("Monto") = oDtMonedas.Rows(intCont).Item("TOTAL")
                    oDr.Item("ESTADOOP") = -1
                    oDtResumen03.Rows.Add(oDr)
                Next
            End If
        Next
        '=========== Suma los Sub Totales=======================

        '=========== Suma los Totales Generales =======================
        For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
            oDtMonedas.Rows(intCont).Item("TOTAL") = 0
        Next
        For Each drp As DataRow In oDs.Tables(2).Rows
            For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
                If drp.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda") Then
                    oDtMonedas.Rows(intCont).Item("TOTAL") = Val("" & oDtMonedas.Rows(intCont).Item("TOTAL") & "") + Val("" & drp.Item("Monto") & "")
                End If
            Next
            bolContieneMov = True
        Next

        'Agregamos columna Vacio
        oDr = oDtResumen03.NewRow
        oDtResumen03.Rows.Add(oDr)



        For intCont As Integer = 0 To oDtMonedas.Rows.Count - 1
            oDr = oDtResumen03.NewRow
            oDr.Item("Centro de Beneficio") = "Total General"
            oDr.Item("Moneda") = oDtMonedas.Rows(intCont).Item("Moneda")
            oDr.Item("Monto") = oDtMonedas.Rows(intCont).Item("TOTAL")
            oDr.Item("ESTADOOP") = -1
            oDtResumen03.Rows.Add(oDr)
        Next
        '=========== Suma los Totales Generales =======================
        oDtResumen02.TableName = "Resumen por Clientes"
        oDtResumen03.TableName = "Resumen por Rubros"

        oDsExcel.Tables.Add(oDtResumen02)
        oDsExcel.Tables.Add(oDtResumen03)
        Ransa.Utilitario.HelpClass.ExportExcelConsultaOperaciones(oDsExcel, "Consulta de Operaciones", olstr)
    End Sub

    Private Sub fExportarExcelDetallado()
        Refrescar()

        oServicio = New Servicio_BE
        '''''''''''''''''''''''''''''''''
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.PSUSUARIO = ConfigurationWizard.UserName
        oServicio.CDVSN = UcDivision.Division
        ''
        oServicio.TIPO_PLANTA = Lista_Tipo_Planta()
        oServicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.TCMPDV = UcDivision.DivisionDescripcion

        oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
        oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)

        If chkFechaOperacion.Checked Then
            oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaOperacionIni.Text)
        Else
            oServicio.FECSERV_INI = 0
            oServicio.FECSERV_FIN = 0
        End If
        oServicio.CCMPN_DESC = UcCompania.CCMPN_Descripcion
        oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
        oServicio.CCLNT_DESC = UcCliente.pRazonSocial
        oServicio.FLGPEN = cmbEstadoFactura.SelectedValue
        oServicio.CRGVTA = Me.cmbRegionVenta.SelectedValue
        'Llennar Servicio Opreacion
        oServicio.NOPRCN = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
        Dim oDs As New DataSet
        oDs = oServicioOpeNeg.fdsReporteDeOperacionesDetallado(oServicio)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)

        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("División :\n " & Me.UcDivision.DivisionDescripcion)
        olstr.Add("Planta :\n " & IIf(Me.cmbPlanta.Text.Trim.Equals(""), "TODOS", Me.cmbPlanta.Text))
        olstr.Add("Fecha:\n " & Me.dtFeInicial.Value.Year.ToString & "/" & Me.dtFeInicial.Value.Month.ToString & "/" & Me.dtFeInicial.Value.Day & " - " & Me.dtFeFinal.Value.Year.ToString & "/" & Me.dtFeFinal.Value.Month & "/" & Me.dtFeFinal.Value.Day)
        olstr.Add("Moneda:\n Nuevo Soles")

        For intRow As Integer = 0 To oDs.Tables(2).Rows.Count - 1
            Dim oDtgColums As New DataColumn
            oDtgColums.ColumnName = oDs.Tables(2).Rows(intRow).Item("CORRELATIVO")
            oDtgColums.DataType = GetType(Decimal)
            oDs.Tables(0).Columns.Add(oDtgColums)
        Next
        oDs.Tables(0).Columns.Add("TOTAL", GetType(Decimal))


        '================Llenamos los Montos ===============================================
        For Each dr As DataRow In oDs.Tables(0).Rows
            For Each drp As DataRow In oDs.Tables(1).Select("NOPRCN=" & dr("NOPRCN"))
                dr(drp.Item("CORRELATIVO").ToString.Trim) = drp("""Monto""")
            Next
        Next
        '===================Cambiamos por su nombre real del servicio =======================
        For intRow As Integer = 0 To oDs.Tables(2).Rows.Count - 1
            oDs.Tables(0).Columns(oDs.Tables(2).Rows(intRow).Item("CORRELATIVO").ToString).ColumnName = (intRow + 1) & " - " & oDs.Tables(2).Rows(intRow).Item("""Rubro Especifico""").ToString.Trim
        Next

        '=================Cambiamos el Nombre ==============================================
        For intCont As Integer = 0 To oDs.Tables(0).Columns.Count - 1
            Dim strColumName As String = """"
            strColumName = oDs.Tables(0).Columns(intCont).ColumnName.Trim.Replace(strColumName, "")
            oDs.Tables(0).Columns(intCont).ColumnName = strColumName
        Next

        oDs.Tables(0).Columns("NOPRCN").ColumnName = "Nr. de Operación"

        For intCont As Integer = 0 To oDs.Tables(1).Columns.Count - 1
            Dim strColumName As String = """"
            strColumName = oDs.Tables(1).Columns(intCont).ColumnName.Trim.Replace(strColumName, "")
            oDs.Tables(1).Columns(intCont).ColumnName = strColumName
        Next

        '=================Cambiamos el Nombre ===============================================

        '====Creamos la estructura de la Nueva Tabla Vista Vertical
        Dim oDtResumen01 As New DataTable
        oDtResumen01 = oDs.Tables(0).Copy
        oDtResumen01.Clear()

        Dim bolContieneMov As Boolean = False
        Dim oDr As DataRow
        For intRow As Integer = 1 To 3
            bolContieneMov = False
            For Each drp As DataRow In oDs.Tables(0).Select("ESTADOOP=" & intRow)
                Dim dblSuma As Decimal = 0
                For intColumn As Integer = 8 To oDs.Tables(0).Columns.Count - 1
                    dblSuma = dblSuma + Val("" & drp.Item(intColumn) & "")
                Next
                drp.Item("TOTAL") = dblSuma
                oDtResumen01.ImportRow(drp)

                bolContieneMov = True
            Next
            If bolContieneMov Then
                oDr = oDtResumen01.NewRow
                oDr.Item("Región de Venta") = "Total"
                oDr.Item("ESTADOOP") = "-1"
                For intColumn As Integer = 8 To oDtResumen01.Columns.Count - 1
                    Dim dblSuma As Decimal = 0
                    For Each drp As DataRow In oDs.Tables(0).Select("ESTADOOP=" & intRow)
                        dblSuma = dblSuma + Val("" & drp.Item(intColumn) & "")
                    Next
                    oDr.Item(intColumn) = dblSuma
                Next
                oDtResumen01.Rows.Add(oDr)
            End If
        Next

        'Agregamos Registro en Blanco
        oDr = oDtResumen01.NewRow
        oDtResumen01.Rows.Add(oDr)
        'Agregamos el Total
        oDr = oDtResumen01.NewRow
        oDr.Item("Región de Venta") = "Total General"
        oDr.Item("ESTADOOP") = "-1"
        For intColumn As Integer = 8 To oDtResumen01.Columns.Count - 1
            Dim dblSuma As Decimal = 0
            For intReg As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                dblSuma = dblSuma + Val("" & oDs.Tables(0).Rows(intReg).Item(intColumn) & "")
            Next
            oDr.Item(intColumn) = dblSuma
        Next
        oDtResumen01.Rows.Add(oDr)

        '=================
        For intCont As Integer = oDtResumen01.Rows.Count - 1 To 1 Step -1
            If ("" & oDtResumen01.Rows(intCont).Item("Estado Operación") & "") = ("" & oDtResumen01.Rows(intCont - 1).Item("Estado Operación") & "") Then
                oDtResumen01.Rows(intCont).Item("Estado Operación") = ""
            End If

            If ("" & oDtResumen01.Rows(intCont).Item("Cod. Cliente Operación") & "") = ("" & oDtResumen01.Rows(intCont - 1).Item("Cod. Cliente Operación") & "") Then
                oDtResumen01.Rows(intCont).Item("Cod. Cliente Operación") = DBNull.Value
                oDtResumen01.Rows(intCont).Item("Cliente de Operación") = ""
            End If
            'Cod. Cliente Facturar
            If ("" & oDtResumen01.Rows(intCont).Item("Cod. Cliente Facturar") & "") = ("" & oDtResumen01.Rows(intCont - 1).Item("Cod. Cliente Facturar") & "") Then
                oDtResumen01.Rows(intCont).Item("Cod. Cliente Facturar") = DBNull.Value
                oDtResumen01.Rows(intCont).Item("Cliente a Facturar") = ""
            End If
        Next
        'Eliminamos el estado de operaciòn

        '===============Armanos el SEGUNDO RESUMEN
        For intCont As Integer = oDs.Tables(1).Rows.Count - 1 To 1 Step -1
            If oDs.Tables(1).Rows(intCont).Item("Estado Operación") = oDs.Tables(1).Rows(intCont - 1).Item("Estado Operación") Then
                oDs.Tables(1).Rows(intCont).Item("Estado Operación") = ""
            End If

            If ("" & oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Operación") & "") = ("" & oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Operación") & "") Then
                oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Operación") = DBNull.Value
                oDs.Tables(1).Rows(intCont).Item("Cliente de Operación") = ""
            End If
            'Cod. Cliente Facturar
            If ("" & oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") & "") = ("" & oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Facturar") & "") Then
                oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") = DBNull.Value
                oDs.Tables(1).Rows(intCont).Item("Cliente a Facturar") = ""
            End If

            If ("" & oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") & "") = ("" & oDs.Tables(1).Rows(intCont - 1).Item("Cod. Cliente Facturar") & "") Then
                oDs.Tables(1).Rows(intCont).Item("Cod. Cliente Facturar") = DBNull.Value
                oDs.Tables(1).Rows(intCont).Item("Cliente a Facturar") = ""
            End If
        Next
        'Eliminamos el estado de operaciòn


        '===================
        Dim oDtResumen02 As New DataTable
        oDtResumen02 = oDs.Tables(1).Copy
        oDtResumen02.Clear()
        Dim dblSumaTotal As Decimal = 0
        For intRow As Integer = 0 To oDs.Tables(1).Rows.Count - 1
            dblSumaTotal = dblSumaTotal + Val("" & oDs.Tables(1).Rows(intRow).Item("Monto") & "")
        Next
        For intRow As Integer = 1 To 3
            bolContieneMov = False
            Dim dblSuma As Decimal = 0
            For Each drp As DataRow In oDs.Tables(1).Select("ESTADOOP=" & intRow)
                dblSuma = dblSuma + Val("" & drp.Item("Monto") & "")
                oDtResumen02.ImportRow(drp)
                bolContieneMov = True
            Next
            If bolContieneMov Then
                oDr = oDtResumen02.NewRow
                oDr.Item("Región de Venta") = "Total"
                oDr.Item("Monto") = dblSuma
                oDr.Item("ESTADOOP") = "-1"
                oDtResumen02.Rows.Add(oDr)
            End If
        Next

        'Agregamos Registro en Blanco
        oDr = oDtResumen02.NewRow
        oDtResumen02.Rows.Add(oDr)
        'Agregamos el Total
        oDr = oDtResumen02.NewRow
        oDr.Item("Región de Venta") = "Total General"
        oDr.Item("Monto") = dblSumaTotal
        oDr.Item("ESTADOOP") = "-1"
        oDtResumen02.Rows.Add(oDr)

        '==================
        'Eliminamos el estado de la operaciòn
        oDtResumen02.Columns.Remove("CORRELATIVO")
        oDtResumen02.Columns("NOPRCN").ColumnName = "Nr. Operación"

        Dim oDsExportar As New DataSet

        oDsExportar.Tables.Add(oDtServicioDet.Copy)
        oDtResumen01.TableName = "Modelo 01"
        oDsExportar.Tables.Add(oDtResumen01.Copy)
        oDtResumen02.TableName = "Modelo 02"
        oDsExportar.Tables.Add(oDtResumen02.Copy)
        Ransa.Utilitario.HelpClass.ExportExcelConsultaOperaciones(oDsExportar, "Consulta de Operaciones", olstr)

    End Sub

    Private Sub ResumidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumidoToolStripMenuItem.Click
        fExportarExcelResumido()
    End Sub

    Private Sub DetalladoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalladoToolStripMenuItem.Click
        fExportarExcelDetallado()
    End Sub

   
    Private Sub chkFechaOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaOperacion.CheckedChanged
        dtpFechaOperacionIni.Checked = Not Me.chkFechaOperacion.Checked
        dtpFechaOperacionFin.Checked = Not Me.chkFechaOperacion.Checked

    End Sub

    'Private Sub rbOp_CheckedChanged(sender As Object, e As EventArgs)
    '    Try

    '        TabControl1.TabPages.Clear()
    '        TabControl1.TabPages.Add(TabPageOP)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub rbServicio_CheckedChanged(sender As Object, e As EventArgs)
    '    Try

    '        TabControl1.TabPages.Clear()
    '        TabControl1.TabPages.Add(TabPageServ)

    '        'TabPageOP
    '        'TabPageServ
    '        'TabControl1
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class
