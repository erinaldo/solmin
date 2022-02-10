Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Imports SOLMIN_CTZ.Entidades
Public Class frmReFacturaElectronico
    Dim _tipoNota As New Decimal

    Private oDtPlanta As New DataTable
    'Private Sub frmReFacturaElectronico_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    Try
    '        BusquedaOperaciones()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub frmReFacturaElectronico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            UcClienteFact.pAccesoPorUsuario = False

            Cargar_TipoDocumento()


            TabDetalles.TabPages.Remove(TabServicios)
            TabDetalles.TabPages.Remove(tabHistoxFactura)

   
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub Cargar_TipoDocumento()
        Try
            Dim oTipoDocumento As New clsTipoDocumento
            cboTipoDoc.DisplayMember = "TCMTPD"
            cboTipoDoc.ValueMember = "CTPODC"
            cboTipoDoc.DataSource = oTipoDocumento.Crea_TipoDocumento_Electronico()
            cboTipoDoc.SelectedValue = 51 ' Factura Electronica

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tipo Documento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
            VistaXTipoDocumento(clsComun.TipoDocumento.NotaCreditoElectronico)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNotaDebito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaDebito.Click
        Try
            VistaXTipoDocumento(clsComun.TipoDocumento.NotaDebitoElectronico)
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
        Dim ESTSUN As String = ""


        obeFacturaHistorialCab.PSCCMPN = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
        obeFacturaHistorialCab.PNCTPODC = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        obeFacturaHistorialCab.PNNDCFCC = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
        dtDatoDoc = BlClsFactura.Lista_Dato_General_Documento(obeFacturaHistorialCab)
        ESTSUN = dtgCuentaCorriente.CurrentRow.Cells("ESTSUN").Value.ToString.Trim



        Dim SESTRG As String = ""
        If dtDatoDoc.Rows.Count = 0 Then
            MessageBox.Show("No se puede emitir documento" & Chr(13) & "No existe Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf dtDatoDoc.Rows.Count > 0 Then
            SESTRG = ("" & dtDatoDoc.Rows(0)("SESTRG")).ToString.Trim

            If SESTRG = "*" And ESTSUN <> "3" Then

                MessageBox.Show("No se puede emitir documento" & Chr(13) & "El documento se encuentra eliminado(*)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

        End If
        Dim msg As String = ""
        Dim msgValidar As String = ""
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim msgIni As String = ""
        'JM  cambie ELectronico
        Select Case TipoDocumento
            Case clsComun.TipoDocumento.NotaCreditoElectronico
                msgIni = "Para crear una Nota de Crédito Electrónico," & Chr(13) & "En las operaciones seleccionadas:"
            Case clsComun.TipoDocumento.NotaDebitoElectronico
                msgIni = "Para crear una Nota de Débito Electrónico," & Chr(13) & "En las operaciones seleccionadas:"
        End Select
        Dim _pLIST_NOPRCN As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
        'Dim obeServicioOp As Ransa.Controls.ServicioOperacion.Servicio_BE

        Dim CCLNT As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CCLNT_OP_COD").Value
        Dim CCLNFC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CO_CLIE").Value
        Dim NDCCTC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
        Dim CTPODC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        Dim CCMPN As String = dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value
        Dim CDVSN As String = dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value
        Dim FDCCTC As Decimal = CType(dtgCuentaCorriente.CurrentRow.Cells("FE_CNTA_CNTE").Value, Date).ToString("yyyyMMdd")
        Dim TABTPD As String = dtgCuentaCorriente.CurrentRow.Cells("TABTPD_DOC").Value
        Dim NOPRCN As Decimal = 0
        'Dim list_op As New List(Of String)
        'For FILA As Int32 = 0 To dtgServiciosOperacion.Rows.Count - 1
        '    NOPRCN = dtgServiciosOperacion.Rows(FILA).Cells("NOPRCN_SERV").Value
        '    If Not list_op.Contains(NOPRCN) Then
        '        obeServicioOp = New Ransa.Controls.ServicioOperacion.Servicio_BE
        '        obeServicioOp.CCLNT = CCLNT
        '        obeServicioOp.CCLNFC = CCLNFC
        '        obeServicioOp.NOPRCN = NOPRCN
        '        obeServicioOp.NDCCTC = NDCCTC
        '        obeServicioOp.CTPODC = CTPODC
        '        obeServicioOp.CCMPN = CCMPN
        '        obeServicioOp.CDVSN = CDVSN
        '        obeServicioOp.FDCCTC = FDCCTC
        '        obeServicioOp.TABTPD = TABTPD
        '        _pLIST_NOPRCN.Add(obeServicioOp)
        '        list_op.Add(NOPRCN)
        '    End If
        'Next

        Dim dblSaldoRefactura As Decimal = 0

        'Public Codigo_Compania As String = ""
        'Public CodigoDiv As String = ""

        'Public origenTipoDoc As Decimal = 0
        'Public origenNumDoc As Decimal = 0
        'Public origenFechaDoc As Decimal = 0

        'JM agrege Electronico
        Select Case TipoDocumento
            Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaCreditoElectronico
                Dim dtImporteFact As New DataTable
                Dim objParametro As New Hashtable
                objParametro.Add("PSCCMPN", Me.UcCompania.CCMPN_CodigoCompania)
                'objParametro.Add("PSCDVSN", Me.UcDivision.Division)
                'objParametro.Add("PNNDCMFC", _pLIST_NOPRCN(0).NDCCTC)
                objParametro.Add("PNNDCMFC", NDCCTC)
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
        Dim ofrmNotaCreditoElectronico As New frmNotaCreditoElectronico
        ofrmNotaCreditoElectronico.origenNumDoc = NDCCTC
        ofrmNotaCreditoElectronico.origenTipoDoc = CTPODC
        ofrmNotaCreditoElectronico.origenFechaDoc = FDCCTC
        'ofrmNotaCreditoElectronico.CodigoDiv = CDVSN
        'ofrmNotaCreditoElectronico.pLIST_NOPRCN = _pLIST_NOPRCN
        ofrmNotaCreditoElectronico.pTotalSaldoFactura = dblSaldoRefactura
        ofrmNotaCreditoElectronico.TipoDocumento = TipoDocumento
        ofrmNotaCreditoElectronico.Codigo_Compania = Me.UcCompania.CCMPN_CodigoCompania
        If ofrmNotaCreditoElectronico.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim olOperaciones As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
            olOperaciones = ofrmNotaCreditoElectronico.pLIST_NOPRCN
            _tipoNota = ofrmNotaCreditoElectronico.TipoNota
            LlamarVistaPrevia(olOperaciones, ofrmNotaCreditoElectronico.pTipoVerDocumento, TipoDocumento, ofrmNotaCreditoElectronico.dtServiciosTodosOp)
        End If
    End Sub

    Private Sub LlamarVistaPrevia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal _FormatoVerDocumento As clsComun.FormaVerDocumento, ByVal _TipoDocumento As clsComun.TipoDocumento, ByVal dtServicioOperacion As DataTable)

        Dim intCont As Integer
        Dim strRegionVenta As String = String.Empty
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim DtRegionVenta As New DataTable

        Dim objfrmVFacturaElectronico As frmVistaRefacturaElectronico
        Dim Moneda As String = String.Empty
        Dim dblCCLNFC As Double = 0
        Dim Cant As Integer = 0
        Dim blRegion As Boolean = True
        Dim strConsistencia As String = String.Empty
        Dim oDt As DataTable

        Dim oFiltro As New Hashtable
        Dim primerRegion As String = ""
        For intCont = 0 To olOperaciones.Count - 1

            Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
            oFacturacion.TIPOFACTURA = Val(_FormatoVerDocumento)


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
            oFacturacion.CRGVTA = primerRegion
            mListaFacturas.Add(oFacturacion)
            Cant += 1
        Next intCont

        If blRegion = False And Cant > 1 Then
            MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mListaFacturas.Count > 0 Then


            oFiltro = New Hashtable


            Dim oDtGiro As DataTable
            oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN
            oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN


            oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
            If oDtGiro.Rows.Count > 0 Then

                objfrmVFacturaElectronico = New frmVistaRefacturaElectronico(mListaFacturas)
                objfrmVFacturaElectronico.dtServiciosTodosOp = dtServicioOperacion
                objfrmVFacturaElectronico.TipoDocumento = _TipoDocumento
                objfrmVFacturaElectronico.TipoNota = _tipoNota   'JM
                objfrmVFacturaElectronico.MdiParent = Me.Parent.Parent
                objfrmVFacturaElectronico.WindowState = FormWindowState.Maximized
                objfrmVFacturaElectronico.Show()
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
            'Dim obeServicioOperacion As New ServicioOperacion
            'obeServicioOperacion.CCMPN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CCMPN_DOC").Value).ToString.Trim
            'obeServicioOperacion.CDVSN = ("" & dtgCuentaCorriente.Rows(Fila).Cells("CDVSN_DOC").Value).ToString.Trim
            'obeServicioOperacion.CCLNT = dtgCuentaCorriente.Rows(Fila).Cells("CCLNT_OP_COD").Value
            'obeServicioOperacion.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
            'obeServicioOperacion.NDCFCC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
            'dt = brServicioOperacion.Lista_Servicios_X_Documento(obeServicioOperacion)
            'dtgServiciosOperacion.DataSource = dt

            'Dim dtReferencia As New DataTable
            'Dim obeServicioOperacionRef As New ServicioOperacion
            'obeServicioOperacion.CTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC_DOC").Value
            'obeServicioOperacion.NDCFCC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC_DOC").Value
            'dtReferencia = brServicioOperacion.Lista_Cuenta_Corriente_Refactura_Referencia(obeServicioOperacion)
            'dgvHistorialxDocumento.DataSource = dtReferencia


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
            'Dim LisOp As New List(Of String)
            'Dim NOPRCN As String = ""
            'For Each Item As DataGridViewRow In dtgServiciosOperacion.Rows
            '    NOPRCN = Item.Cells("NOPRCN_SERV").Value
            '    If Not LisOp.Contains(NOPRCN) Then
            '        LisOp.Add(NOPRCN)
            '        Item.Cells("OP_HISTORIAL").Value = "Historial"
            '    Else
            '        Item.Cells("OP_HISTORIAL").Value = ""
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



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



    Private Sub chkFechaDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaDoc.CheckedChanged
        dtFechaInicio.Enabled = chkFechaDoc.Checked
        dtFechaFin.Enabled = chkFechaDoc.Checked
    End Sub


    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Try
            dtgCuentaCorriente.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing

            BusquedaOperaciones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboTipoDoc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.SelectedValueChanged
        Try
            MostrarBotones(CInt(cboTipoDoc.SelectedValue))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MostrarBotones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MostrarBotones(ByVal TipoDoc As Integer, Optional ByVal estado As Boolean = True)
        Select Case cboTipoDoc.SelectedValue
            'Factura, Boleta, Factura electrónico, Boleta electrónico
            Case 1, 7, 51, 57
                btnNotaCredito.Visible = estado
                btnNotaDebito.Visible = estado
                'Nota de Crédito, Nota de crédito electrónico
            Case 3, 53
                btnNotaCredito.Visible = Not (estado)
                btnNotaDebito.Visible = estado
            Case 2, 52
                btnNotaCredito.Visible = estado
                btnNotaDebito.Visible = Not (estado)
        End Select
    End Sub
End Class

