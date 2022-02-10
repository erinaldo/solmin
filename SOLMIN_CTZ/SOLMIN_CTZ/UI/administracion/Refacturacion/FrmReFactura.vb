Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Imports SOLMIN_CTZ.Entidades
Public Class FrmReFactura
    Private oDtPlanta As New DataTable
    Private Sub FrmRefactura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            BusquedaOperaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmRefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chkFechaDoc.Checked = True
            chkFechaDoc_CheckedChanged(chkFechaDoc, Nothing)
            'chkNumDoc_CheckedChanged(chkNumDoc, Nothing)
            dtgCuentaCorriente.AutoGenerateColumns = False
            dtgServiciosOperacion.AutoGenerateColumns = False
            dgvHistorialxDocumento.AutoGenerateColumns = False
            dtgVentas.AutoGenerateColumns = False
            UcCompania.Usuario = ConfigurationWizard.UserName
            UcCompania.pActualizar()
            UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            UcCliente_Ope.pAccesoPorUsuario = False
            'UcCliente_Ope.pUsuario = ConfigurationWizard.UserName
            UcClienteFact.pAccesoPorUsuario = False
            'UcClienteFact.pUsuario = ConfigurationWizard.UserName
            Cargar_TipoDocumento()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_TipoDocumento()
        Dim oTipoDocumento As New clsTipoDocumento
        Dim oDtTipoDocumento As New DataTable
        oTipoDocumento.Crea_TipoDocumento()
        oDtTipoDocumento = oTipoDocumento.Lista_TipoDocumento_Multiple(0)
        cboTipoDoc.ValueMember = "CTPODC"
        cboTipoDoc.DisplayMember = "TCMTPD"
        cboTipoDoc.DataSource = oDtTipoDocumento
        cboTipoDoc.SelectedValue = 1D
        cboTipoDoc.Enabled = False
    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        Try
            UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision.Usuario = ConfigurationWizard.UserName
            UcDivision.ItemTodos = False
            UcDivision.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Try
            Dim oPlanta As New clsPlanta
            oPlanta.Crea_Lista()
            oDtPlanta = oPlanta.Lista_Planta_Division(UcCompania.CCMPN_CodigoCompania, UcDivision.Division)
            oDtPlanta.Columns.Remove("CCMPN")
            oDtPlanta.Columns.Remove("CDVSN")
            oDtPlanta.Columns.Remove("CRGVTA")
            Me.cmbPlanta.ValueMember = "CPLNDV"
            Me.cmbPlanta.DisplayMember = "TPLNTA"
            Me.cmbPlanta.DataSource = oDtPlanta
            For i As Integer = 0 To cmbPlanta.Items.Count - 1
                If cmbPlanta.Items.Item(i).Value = "-1" Then
                    cmbPlanta.SetItemChecked(i, True)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BusquedaOperaciones()
        dtgCuentaCorriente.DataSource = Nothing
        dtgServiciosOperacion.DataSource = Nothing
        dtgVentas.DataSource = Nothing
        dgvHistorialxDocumento.DataSource = Nothing

        txtNumDocumento.Text = txtNumDocumento.Text.Trim
        'If UcCliente_Ope.pCodigo = 0 Then
        '    Exit Sub
        'End If
        'If chkFechaDocumento.Checked = False Then
        '    If txtNumDocumento.Text.Length <= 0 Then
        '        MessageBox.Show("Ingrese Nro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Exit Sub
        '    End If
        'End If
        'If chkFechaDoc.Checked = False AndAlso chkNumDoc.Checked = False Then
        '    MessageBox.Show("Busque por Rango Fecha o Nro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        'If chkNumDoc.Checked = True Then
        '    If txtNumDocumento.Text.Length = 0 Then
        '        MessageBox.Show("Ingrese Nro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Exit Sub
        '    End If
        'End If



        Dim oServicio As New ServicioOperacion
        Dim clsServicio As New clsServicioOperacion
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division
        oServicio.CCLNT = UcCliente_Ope.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.TIPO_PLANTA = Lista_Planta()



        If chkFechaDoc.Checked = True Then
            oServicio.FDCFCC_INI = dtFechaInicio.Value.ToString("yyyyMMdd")
            oServicio.FDCFCC_FIN = dtFechaFin.Value.ToString("yyyyMMdd")
        Else
            oServicio.FDCFCC_INI = 0
            oServicio.FDCFCC_FIN = 99999999
        End If

        'If chkNumDoc.Checked = True Then

        'Else
        '    oServicio.NDCFCC = 0
        'End If
        If txtNumDocumento.Text.Length > 0 Then
            oServicio.NDCFCC = txtNumDocumento.Text
        Else
            oServicio.NDCFCC = 0
        End If

        oServicio.CTPODC = cboTipoDoc.SelectedValue
        oServicio.PageSize = Me.UcPaginacion1.PageSize
        oServicio.PageNumber = Me.UcPaginacion1.PageNumber

        Dim dtCuentaContable As New DataTable
        Dim Num_pag As Integer = 0
        dtCuentaContable = clsServicio.Lista_Cuenta_Corriente_Refactura(oServicio, Num_pag)
        dtgCuentaCorriente.DataSource = dtCuentaContable

        If Num_pag > 0 Then
            UcPaginacion1.PageCount = Num_pag
        End If

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dtgCuentaCorriente.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing
            'If UcCliente_Ope.pCodigo = 0 AndAlso UcClienteFact.pCodigo = 0 Then
            '    MessageBox.Show("Seleccione Cliente Operación u Facturación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            BusquedaOperaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Lista_Planta() As String
        Dim strPlantas As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            If (cmbPlanta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                    If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                        strPlantas += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                    End If
                Next
            Else
                strPlantas = ""
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        End If
        Return strPlantas
    End Function


    Private Sub btnNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaCredito.Click
        Try
            VistaXTipoDocumento(clsComun.TipoDocumento.NotaCredito)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNotaDebito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaDebito.Click
        Try
            VistaXTipoDocumento(clsComun.TipoDocumento.NotaDebito)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub VistaXTipoDocumento(ByVal TipoDocumento As clsComun.TipoDocumento)
        If dtgCuentaCorriente.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obeFacturaHistorialCab As New FacturaHistorialCab
        Dim BlClsFactura As New clsFactura
        Dim dtDatoDoc As New DataTable
        obeFacturaHistorialCab.PSCCMPN = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
        obeFacturaHistorialCab.PNCTPODC = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        obeFacturaHistorialCab.PNNDCFCC = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
        dtDatoDoc = BlClsFactura.Lista_Dato_General_Documento(obeFacturaHistorialCab)

        Dim SESTRG As String = ""
        If dtDatoDoc.Rows.Count = 0 Then
            MessageBox.Show("No se puede emitir documento" & Chr(13) & "No existe Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf dtDatoDoc.Rows.Count > 0 Then
            SESTRG = ("" & dtDatoDoc.Rows(0)("SESTRG")).ToString.Trim
            If SESTRG = "*" Then
                MessageBox.Show("No se puede emitir documento" & Chr(13) & "El documento se encuentra eliminado(*)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        Dim msg As String = ""
        Dim msgValidar As String = ""
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim msgIni As String = ""
        Select Case TipoDocumento
            Case clsComun.TipoDocumento.NotaCredito
                msgIni = "Para crear una Nota de Crédito," & Chr(13) & "En las operaciones seleccionadas:"
            Case clsComun.TipoDocumento.NotaDebito
                msgIni = "Para crear una Nota de Débito," & Chr(13) & "En las operaciones seleccionadas:"
        End Select
        Dim _pLIST_NOPRCN As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
        Dim obeServicioOp As Ransa.Controls.ServicioOperacion.Servicio_BE

        Dim CCLNT As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CCLNT_OP_COD").Value
        Dim CCLNFC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CO_CLIE").Value
        Dim NDCCTC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
        Dim CTPODC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        Dim CCMPN As String = dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value
        Dim CDVSN As String = dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value
        Dim FDCCTC As Decimal = CType(dtgCuentaCorriente.CurrentRow.Cells("FE_CNTA_CNTE").Value, Date).ToString("yyyyMMdd")
        Dim TABTPD As String = dtgCuentaCorriente.CurrentRow.Cells("TABTPD_DOC").Value
        Dim NOPRCN As Decimal = 0
        Dim list_op As New List(Of String)
        For FILA As Int32 = 0 To dtgServiciosOperacion.Rows.Count - 1
            NOPRCN = dtgServiciosOperacion.Rows(FILA).Cells("NOPRCN_SERV").Value
            If Not list_op.Contains(NOPRCN) Then
                obeServicioOp = New Ransa.Controls.ServicioOperacion.Servicio_BE
                obeServicioOp.CCLNT = CCLNT
                obeServicioOp.CCLNFC = CCLNFC
                obeServicioOp.NOPRCN = NOPRCN
                obeServicioOp.NDCCTC = NDCCTC
                obeServicioOp.CTPODC = CTPODC
                obeServicioOp.CCMPN = CCMPN
                obeServicioOp.CDVSN = CDVSN
                obeServicioOp.FDCCTC = FDCCTC
                obeServicioOp.TABTPD = TABTPD
                _pLIST_NOPRCN.Add(obeServicioOp)
                list_op.Add(NOPRCN)
            End If
        Next

        Dim dblSaldoRefactura As Decimal = 0
        Select Case TipoDocumento
            Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaDebito
                Dim dtImporteFact As New DataTable
                Dim objParametro As New Hashtable
                objParametro.Add("PSCCMPN", Me.UcCompania.CCMPN_CodigoCompania)
                objParametro.Add("PSCDVSN", Me.UcDivision.Division)
                objParametro.Add("PNNDCMFC", _pLIST_NOPRCN(0).NDCCTC)
                dtImporteFact = oFacturaNeg.Traer_Importe_Refactura(objParametro)
                If dtImporteFact.Rows.Count > 0 Then
                    For indice As Integer = 0 To dtImporteFact.Rows.Count - 1
                        dblSaldoRefactura += dtImporteFact.Rows(indice).Item("IMPORTE")
                    Next
                Else
                    HelpClass.MsgBox("No se encontró el documento", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
        End Select
        Dim ofrmNotaCredito As New frmNotaCredito
        ofrmNotaCredito.pLIST_NOPRCN = _pLIST_NOPRCN
        ofrmNotaCredito.pTotalSaldoFactura = dblSaldoRefactura
        ofrmNotaCredito.TipoDocumento = TipoDocumento
        If ofrmNotaCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim olOperaciones As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
            olOperaciones = ofrmNotaCredito.pLIST_NOPRCN
            LlamarVistaPrevia(olOperaciones, ofrmNotaCredito.pTipoVerDocumento, TipoDocumento, ofrmNotaCredito.dtServiciosTodosOp)
        End If
    End Sub

    Private Sub LlamarVistaPrevia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal _FormatoVerDocumento As clsComun.FormaVerDocumento, ByVal _TipoDocumento As clsComun.TipoDocumento, ByVal dtServicioOperacion As DataTable)

        Dim intCont As Integer
        Dim strRegionVenta As String = String.Empty
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim DtRegionVenta As New DataTable
        Dim objfrmVFactura As frmVistaRefactura
        Dim Moneda As String = String.Empty
        Dim dblCCLNFC As Double = 0
        Dim Cant As Integer = 0
        Dim blRegion As Boolean = True
        Dim strConsistencia As String = String.Empty
        Dim oDt As DataTable
        'Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oFiltro As New Hashtable
        Dim primerRegion As String = ""
        For intCont = 0 To olOperaciones.Count - 1
            'oFiltro.Parametro1 = "100" 'tipo cambio dolares
            'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
            'oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
            'If oDt.Rows.Count = 0 Then
            '    MessageBox.Show("No se puede generar el documento por no existir Tipo de Cambio a la Fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If
            Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
            oFacturacion.TIPOFACTURA = Val(_FormatoVerDocumento)

            '=============Si es de tipo 1  se genera por tipo de revision else por tipo Operacion===========
            'If Not olOperaciones.Item(intCont).TIPO = "1" Then
            '    oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
            '    oFacturacion.NSECFC = 0
            'Else
            '    oFacturacion.NOPRCN = 0
            '    oFacturacion.NSECFC = olOperaciones.Item(intCont).NSECFC
            'End If
            oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
            oFacturacion.NSECFC = 0

            oFacturacion.PNCCLNT = olOperaciones.Item(intCont).CCLNT


            oFacturacion.TCMPDV = olOperaciones.Item(intCont).TCMPDV
            oFacturacion.PSCDVSN = olOperaciones.Item(intCont).CDVSN
            oFacturacion.PSCCMPN = olOperaciones.Item(intCont).CCMPN
            oFacturacion.CCLNFC = olOperaciones.Item(intCont).CCLNFC
            oFacturacion.CPLNDV = olOperaciones.Item(intCont).CPLNDV
            oFacturacion.CMNDA1 = olOperaciones.Item(intCont).CMNDA1

            oFacturacion.ITCCTC = olOperaciones.Item(intCont).ITCCTC
            oFacturacion.CTPODC = olOperaciones.Item(intCont).CTPODC
            oFacturacion.NDCCTC = olOperaciones.Item(intCont).NDCCTC
            oFacturacion.FDCCTC = olOperaciones.Item(intCont).FDCCTC
            oFacturacion.LIBERAR = olOperaciones.Item(intCont).LIBERAR

            If oFacturacion.CCLNFC <> dblCCLNFC And dblCCLNFC <> 0 Then
                MessageBox.Show("No puede generar el documento por que las Operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            dblCCLNFC = oFacturacion.CCLNFC
            If Cant = 0 Then Moneda = olOperaciones.Item(intCont).TSGNMN
            If Moneda <> olOperaciones.Item(intCont).TSGNMN Then
                MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Moneda = olOperaciones.Item(intCont).TSGNMN

            If intCont = 0 Then
                primerRegion = olOperaciones.Item(intCont).CRGVTA
            End If
            If olOperaciones.Item(intCont).CRGVTA <> primerRegion Then
                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            'If Not olOperaciones.Item(intCont).TIPO = "1" Then
            '    DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

            '    If DtRegionVenta.Rows.Count = 0 Then
            '        blRegion = False
            '        strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
            '    Else
            '        If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
            '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '            Exit Sub
            '        End If
            '    End If
            'Else
            '    If Cant = 0 Then strRegionVenta = olOperaciones.Item(intCont).CRGVTA
            '    If strRegionVenta = olOperaciones.Item(intCont).CRGVTA Then
            '        If strRegionVenta.Trim.Length = 0 Then
            '            blRegion = False
            '            strConsistencia += oFacturacion.NSECFC & System.Environment.NewLine
            '        Else
            '            If strRegionVenta <> olOperaciones.Item(intCont).CRGVTA Then
            '                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '                Exit Sub
            '            End If
            '        End If
            '    End If
            'strRegionVenta = olOperaciones.Item(intCont).CRGVTA
            'oFacturacion.CRGVTA = strRegionVenta
            'End If

            oFacturacion.CRGVTA = primerRegion

            mListaFacturas.Add(oFacturacion)
            Cant += 1
        Next intCont

        If blRegion = False And Cant > 1 Then
            MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mListaFacturas.Count > 0 Then
            'Validamos si el Usuario Tiene Permisos paara Facturar
            'oFiltro = New SOLMIN_CTZ.Entidades.Filtro
            oFiltro = New Hashtable
            'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
            'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
            Dim oDtGiro As DataTable
            oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN 'strCodCom
            oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN 'strCodDiv

        

            oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
            If oDtGiro.Rows.Count > 0 Then
                objfrmVFactura = New frmVistaRefactura(mListaFacturas)
                objfrmVFactura.dtServiciosTodosOp = dtServicioOperacion
                objfrmVFactura.TipoDocumento = _TipoDocumento
                objfrmVFactura.MdiParent = Me.Parent.Parent
                objfrmVFactura.WindowState = FormWindowState.Maximized
                objfrmVFactura.Show()
            Else
                MessageBox.Show("Usted no tiene Acceso a generar este documento", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub dtgCuentaCorriente_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCuentaCorriente.SelectionChanged
        If dtgCuentaCorriente.CurrentCellAddress.Y = -1 Then Exit Sub
        Try

            dtgServiciosOperacion.DataSource = Nothing
            dgvHistorialxDocumento.DataSource = Nothing
            Dim brServicioOperacion As New clsServicioOperacion
            Dim dt As New DataTable
            Dim Fila As Int32 = dtgCuentaCorriente.CurrentRow.Index
            Dim obeServicioOperacion As New ServicioOperacion
            obeServicioOperacion.CCMPN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CCMPN_DOC").Value).ToString.Trim
            obeServicioOperacion.CDVSN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CDVSN_DOC").Value).ToString.Trim
            obeServicioOperacion.CCLNT = dtgCuentaCorriente.Rows(Fila).Cells("CCLNT_OP_COD").Value
            obeServicioOperacion.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
            obeServicioOperacion.NDCFCC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
            dt = brServicioOperacion.Lista_Servicios_X_Documento(obeServicioOperacion)
            dtgServiciosOperacion.DataSource = dt

            Dim dtReferencia As New DataTable
            Dim obeServicioOperacionRef As New ServicioOperacion
            obeServicioOperacion.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
            obeServicioOperacion.NDCFCC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
            dtReferencia = brServicioOperacion.Lista_Cuenta_Corriente_Refactura_Referencia(obeServicioOperacion)
            dgvHistorialxDocumento.DataSource = dtReferencia


            Dim oCtaCte_Venta As New CtaCte_Venta
            Dim oCtaCte_VentaNeg As New clsCtaCte_Venta
            dtgVentas.DataSource = Nothing
            Dim oDt As DataTable
            oCtaCte_Venta.PSCCMPN = dtgCuentaCorriente.Rows(Fila).Cells("CCMPN_DOC").Value
            oCtaCte_Venta.NDCCTC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
            oCtaCte_Venta.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
            oDt = oCtaCte_VentaNeg.Lista_CtaCte_Venta(oCtaCte_Venta)
            dtgVentas.DataSource = oDt

            '  Public Function Lista_Cuenta_Corriente_Refactura_Referencia(ByVal oServicio As ServicioOperacion) As DataTable
            Dim LisOp As New List(Of String)
            Dim NOPRCN As String = ""
            For Each Item As DataGridViewRow In dtgServiciosOperacion.Rows
                NOPRCN = Item.Cells("NOPRCN_SERV").Value
                If Not LisOp.Contains(NOPRCN) Then
                    LisOp.Add(NOPRCN)
                    Item.Cells("OP_HISTORIAL").Value = "Historial"
                Else
                    Item.Cells("OP_HISTORIAL").Value = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub MostrarServicios_Operacion_Documento()
    '    dtgServiciosOperacion.DataSource = Nothing
    '    Dim brServicioOperacion As New clsServicioOperacion
    '    Dim dt As New DataTable
    '    Dim Fila As Int32 = dtgCuentaCorriente.CurrentRow.Index
    '    Dim obeServicioOperacion As New ServicioOperacion
    '    obeServicioOperacion.CCMPN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CCMPN_DOC").Value).ToString.Trim
    '    obeServicioOperacion.CDVSN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CDVSN_DOC").Value).ToString.Trim
    '    obeServicioOperacion.CCLNT = dtgCuentaCorriente.Rows(Fila).Cells("CCLNT_OP_COD").Value
    '    obeServicioOperacion.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
    '    obeServicioOperacion.NDCFCC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
    '    dt = brServicioOperacion.Lista_Servicios_X_Documento(obeServicioOperacion)
    '    dtgServiciosOperacion.DataSource = dt

    '    Dim LisOp As New List(Of String)
    '    Dim NOPRCN As String = ""
    '    For Each Item As DataGridViewRow In dtgServiciosOperacion.Rows
    '        NOPRCN = Item.Cells("NOPRCN_SERV").Value
    '        If Not LisOp.Contains(NOPRCN) Then
    '            LisOp.Add(NOPRCN)
    '            Item.Cells("OP_HISTORIAL").Value = "Historial"
    '        Else
    '            Item.Cells("OP_HISTORIAL").Value = ""
    '        End If
    '    Next

    'End Sub

    Private Sub dtgServiciosOperacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgServiciosOperacion.CellContentClick
        Try
            Dim NameColumn As String = dtgServiciosOperacion.Columns(e.ColumnIndex).Name
            Select Case NameColumn
                Case "OP_HISTORIAL"
                    Dim PSCCMPN As String = dtgServiciosOperacion.CurrentRow.Cells("CCMPN").Value
                    Dim PSCDVSN As String = dtgServiciosOperacion.CurrentRow.Cells("CDVSN").Value
                    Dim PNNOPRCN As Decimal = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_SERV").Value
                    Dim oFrmHistorialOperacion As New FrmHistorialOperacion(PSCCMPN, PSCDVSN, PNNOPRCN)
                    oFrmHistorialOperacion.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub UcCliente_Ope_InformationChanged() Handles UcCliente_Ope.InformationChanged
    '    Try
    '        btnBuscar_Click(btnBuscar, Nothing)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub UcClienteFact_InformationChanged() Handles UcClienteFact.InformationChanged
    '    Try
    '        btnBuscar_Click(btnBuscar, Nothing)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub chkFechaDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaDoc.CheckedChanged
        dtFechaInicio.Enabled = chkFechaDoc.Checked
        dtFechaFin.Enabled = chkFechaDoc.Checked
    End Sub

    'Private Sub chkNumDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtNumDocumento.Enabled = chkNumDoc.Checked
    'End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Try
            dtgCuentaCorriente.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing
            'If UcCliente_Ope.pCodigo = 0 AndAlso UcClienteFact.pCodigo = 0 Then
            '    MessageBox.Show("Seleccione Cliente Operación u Facturación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            BusquedaOperaciones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

