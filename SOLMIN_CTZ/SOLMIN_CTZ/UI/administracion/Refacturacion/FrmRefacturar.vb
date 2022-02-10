Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Imports SOLMIN_CTZ.Entidades
Public Class FrmRefacturar
    Private oDtPlanta As New DataTable
    Private Sub FrmRefacturar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            BusquedaOperaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmRefacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chkFechaDocumento.Checked = True
            dtgOperaciones.AutoGenerateColumns = False
            dtgServiciosOperacion.AutoGenerateColumns = False
            UcCompania.Usuario = ConfigurationWizard.UserName
            UcCompania.pActualizar()
            UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            UcCliente_Ope.pAccesoPorUsuario = True
            UcCliente_Ope.pUsuario = ConfigurationWizard.UserName
            UcClienteFact.pAccesoPorUsuario = True
            UcClienteFact.pUsuario = ConfigurationWizard.UserName
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

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        Try
            UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision.Usuario = ConfigurationWizard.UserName
            UcDivision.ItemTodos = False
            UcDivision.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
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
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub BusquedaOperaciones()
        dtgOperaciones.DataSource = Nothing
        'dtgServiciosOperacion.Rows.Clear()
        dtgServiciosOperacion.DataSource = Nothing
        If UcCliente_Ope.pCodigo = 0 Then
            Exit Sub
        End If
        If chkFechaDocumento.Checked = False AndAlso chkFechaOperacion.Checked = False Then
            If txtNumDocumento.Text.Length <= 0 Then
                MessageBox.Show("Ingrese Nro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        Dim oServicio As New ServicioOperacion
        Dim clsServicio As New clsServicioOperacion
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division
        oServicio.CCLNT = UcCliente_Ope.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.TIPO_PLANTA = Lista_Planta()
        If chkFechaDocumento.Checked = True Then
            oServicio.FDCFCC_INI = dtFechaInicio.Value.ToString("yyyyMMdd")
            oServicio.FDCFCC_FIN = dtFechaFin.Value.ToString("yyyyMMdd")
        Else
            oServicio.FDCFCC_INI = 0
            oServicio.FDCFCC_FIN = 99999999
        End If
        If chkFechaOperacion.Checked = True Then
            oServicio.FOPRCN_INI = dtFechaInicioOP.Value.ToString("yyyyMMdd")
            oServicio.FOPRCN_FIN = dtFechaFinOP.Value.ToString("yyyyMMdd")
        Else
            oServicio.FOPRCN_INI = 0
            oServicio.FOPRCN_FIN = 99999999
        End If
        txtNumDocumento.Text = txtNumDocumento.Text.Trim

        If txtNumDocumento.Text.Length = 0 Then
            oServicio.NDCFCC = 0
        Else
            oServicio.NDCFCC = txtNumDocumento.Text
        End If
        oServicio.CTPODC = cboTipoDoc.SelectedValue
        Dim oDtServicio As New DataTable
        oDtServicio = clsServicio.Lista_Servicios_Documento(oServicio)
        dtgOperaciones.DataSource = oDtServicio
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dtgOperaciones.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing
            If UcCliente_Ope.pCodigo = 0 Then
                MessageBox.Show("Seleccione Cliente Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
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

    Private Function EsSeleccionValida() As String
        Dim msg As String = ""
        Dim msgValidacionNotaCredito As New StringBuilder
        Dim msgIsValidCliente As String = IsValidoCliente()
        Dim msgIsValidOrgVenta As String = IsValidoOrganizacionVenta()
        Dim msgIsValidDoc As String = IsValidoDocumento()
        If msgIsValidCliente.Length > 0 Then
            msgValidacionNotaCredito.Append(msgIsValidCliente)
            msgValidacionNotaCredito.AppendLine()
        End If
        If msgIsValidOrgVenta.Length > 0 Then
            msgValidacionNotaCredito.Append(msgIsValidOrgVenta)
            msgValidacionNotaCredito.AppendLine()
        End If
        If msgIsValidDoc.Length > 0 Then
            msgValidacionNotaCredito.Append(msgIsValidDoc)
            msgValidacionNotaCredito.AppendLine()
        End If
        Return msgValidacionNotaCredito.ToString
    End Function

    Private Sub btnNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaCredito.Click
        VistaXTipoDocumento(clsComun.TipoDocumento.NotaCredito)
    End Sub

    Private Sub btnNotaDebito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaDebito.Click
        VistaXTipoDocumento(clsComun.TipoDocumento.NotaDebito)
    End Sub

    Private Sub VistaXTipoDocumento(ByVal TipoDocumento As clsComun.TipoDocumento)
        Dim msg As String = ""
        Dim msgValidar As String = ""
        dtgOperaciones.EndEdit()
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        If Existe_Check() = False Then
            MessageBox.Show("Debe seleccionar al menos una Operación Facturada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim msgIni As String = ""
        Select Case TipoDocumento
            Case clsComun.TipoDocumento.NotaCredito
                msgIni = "Para crear una Nota de Crédito," & Chr(13) & "En las operaciones seleccionadas:"
            Case clsComun.TipoDocumento.NotaDebito
                msgIni = "Para crear una Nota de Débito," & Chr(13) & "En las operaciones seleccionadas:"
        End Select
        msgValidar = EsSeleccionValida()
        If msgValidar.Length > 0 Then
            msg = msgIni & Chr(13) & msgValidar.ToString
            MessageBox.Show(msg.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim _pLIST_NOPRCN As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
        Dim obeServicioOp As Ransa.Controls.ServicioOperacion.Servicio_BE
        For FILA As Int32 = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(FILA).Cells("chk").Value = True Then
                obeServicioOp = New Ransa.Controls.ServicioOperacion.Servicio_BE
                obeServicioOp.CCLNT = dtgOperaciones.Rows(FILA).Cells("CCLNT").Value
                obeServicioOp.CCLNFC = dtgOperaciones.Rows(FILA).Cells("CCLNFC").Value
                obeServicioOp.NOPRCN = dtgOperaciones.Rows(FILA).Cells("NOPRCN").Value
                obeServicioOp.NDCCTC = dtgOperaciones.Rows(FILA).Cells("NDCFCC_OP").Value
                obeServicioOp.CTPODC = dtgOperaciones.Rows(FILA).Cells("CTPODC").Value
                obeServicioOp.CCMPN = dtgOperaciones.Rows(FILA).Cells("CCMPN").Value
                obeServicioOp.CDVSN = dtgOperaciones.Rows(FILA).Cells("CDVSN").Value
                obeServicioOp.FDCCTC = CType(dtgOperaciones.Rows(FILA).Cells("FDCCTC").Value, Date).ToString("yyyyMMdd")
                obeServicioOp.TABTPD = dtgOperaciones.Rows(FILA).Cells("TABTPD").Value
                _pLIST_NOPRCN.Add(obeServicioOp)
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
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro

        For intCont = 0 To olOperaciones.Count - 1
            oFiltro.Parametro1 = "100" 'tipo cambio dolares
            oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
            oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
            If oDt.Rows.Count = 0 Then
                MessageBox.Show("No se puede generar la Factura por no existir Tipo de Cambio a la Fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
            oFacturacion.TIPOFACTURA = Val(_FormatoVerDocumento)

            '=============Si es de tipo 1  se genera por tipo de revision else por tipo Operacion===========
            If Not olOperaciones.Item(intCont).TIPO = "1" Then
                oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
                oFacturacion.NSECFC = 0
            Else
                oFacturacion.NOPRCN = 0
                oFacturacion.NSECFC = olOperaciones.Item(intCont).NSECFC
            End If

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
                MessageBox.Show("No puede generar la Factura por que las Operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            dblCCLNFC = oFacturacion.CCLNFC
            If Cant = 0 Then Moneda = olOperaciones.Item(intCont).TSGNMN
            If Moneda <> olOperaciones.Item(intCont).TSGNMN Then
                MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Moneda = olOperaciones.Item(intCont).TSGNMN

            If Not olOperaciones.Item(intCont).TIPO = "1" Then
                DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

                If DtRegionVenta.Rows.Count = 0 Then
                    blRegion = False
                    strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
                Else
                    If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
                        MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                If Cant = 0 Then strRegionVenta = olOperaciones.Item(intCont).CRGVTA
                If strRegionVenta = olOperaciones.Item(intCont).CRGVTA Then
                    If strRegionVenta.Trim.Length = 0 Then
                        blRegion = False
                        strConsistencia += oFacturacion.NSECFC & System.Environment.NewLine
                    Else
                        If strRegionVenta <> olOperaciones.Item(intCont).CRGVTA Then
                            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                End If
                strRegionVenta = olOperaciones.Item(intCont).CRGVTA
                oFacturacion.CRGVTA = strRegionVenta
            End If

            mListaFacturas.Add(oFacturacion)
            Cant += 1
        Next intCont

        If blRegion = False And Cant > 1 Then
            MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mListaFacturas.Count > 0 Then
            'Validamos si el Usuario Tiene Permisos paara Facturar
            oFiltro = New SOLMIN_CTZ.Entidades.Filtro
            oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
            oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
            Dim oDtGiro As DataTable
            oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
            If oDtGiro.Rows.Count > 0 Then
                objfrmVFactura = New frmVistaRefactura(mListaFacturas)
                objfrmVFactura.dtServiciosTodosOp = dtServicioOperacion
                objfrmVFactura.TipoDocumento = _TipoDocumento
                objfrmVFactura.MdiParent = Me.Parent.Parent
                objfrmVFactura.WindowState = FormWindowState.Maximized
                objfrmVFactura.Show()
            Else
                MessageBox.Show("Usted no tiene Acceso a facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Function IsValidoCliente() As String
        Dim sbMsg As String = ""
        Dim IsValidCliente As Boolean = False
        Dim listVisitCliente As New List(Of String)
        Dim CCLNFC As Decimal = 0
        For FILA As Int32 = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(FILA).Cells("chk").Value = True Then
                CCLNFC = dtgOperaciones.Rows(FILA).Cells("CCLNFC").Value
                If CCLNFC > 0 Then
                    If listVisitCliente.Count = 0 Then
                        listVisitCliente.Add(CCLNFC)
                        IsValidCliente = True
                    Else
                        IsValidCliente = (listVisitCliente.Contains(CCLNFC))
                        If Not IsValidCliente = False Then Exit For
                    End If
                End If
            End If
        Next
        If IsValidCliente = False Then
            sbMsg = "* El cliente a Facturar deben iguales."
        End If
        Return sbMsg.ToString
    End Function

    Private Function IsValidoDocumento() As String
        Dim sbMsg As String = ""
        Dim NUM_DOC_UNI As String = "", CTPODC As String = "", NDCCTC As String = ""
        Dim listVisiDoc As New List(Of String)
        Dim isValidDoc As Boolean = False
        For FILA As Int32 = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(FILA).Cells("chk").Value = True Then
                CTPODC = ("" & dtgOperaciones.Rows(FILA).Cells("CTPODC").Value).ToString.Trim
                NDCCTC = ("" & dtgOperaciones.Rows(FILA).Cells("NDCFCC_OP").Value).ToString.Trim
                NUM_DOC_UNI = String.Format("{0}_{1}", CTPODC, NDCCTC)
                If EsValidDoc(CTPODC, NDCCTC) Then
                    If listVisiDoc.Count = 0 Then
                        listVisiDoc.Add(NUM_DOC_UNI)
                        isValidDoc = True
                    Else
                        isValidDoc = (listVisiDoc.Contains(NUM_DOC_UNI))
                        If isValidDoc = False Then Exit For
                    End If
                End If
            End If
        Next
        If isValidDoc = False Then
            sbMsg = "* El Tipo Documento y Número Documento deben ser iguales."
        End If
        Return sbMsg
    End Function

    Private Function IsValidoOrganizacionVenta() As String
        Dim sbMsg As String = ""
        Dim IsValidOrgVenta As Boolean = False
        Dim listVisitOrgVenta As New List(Of String)
        Dim CRGVTA As String = ""
        For FILA As Int32 = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(FILA).Cells("chk").Value = True Then
                CRGVTA = ("" & dtgOperaciones.Rows(FILA).Cells("CRGVTA").Value).ToString.Trim
                If CRGVTA.Length > 0 Then
                    If listVisitOrgVenta.Count = 0 Then
                        listVisitOrgVenta.Add(CRGVTA)
                        IsValidOrgVenta = True
                    Else
                        IsValidOrgVenta = (listVisitOrgVenta.Contains(CRGVTA))
                        If Not IsValidOrgVenta = False Then Exit For
                    End If
                End If
            End If
        Next
        If IsValidOrgVenta = False Then
            sbMsg = "* La Organización de Venta deben ser iguales."
        End If
        Return sbMsg
    End Function

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(intCont).Cells("chk").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function EsValidDoc(ByVal CTPODC_TipoDoc As String, ByVal NDCCTC_NumDoc As String) As Boolean
        Dim isValid As Boolean = False
        isValid = (CTPODC_TipoDoc.Length > 0 AndAlso NDCCTC_NumDoc.Length > 0 AndAlso Convert.ToDecimal(NDCCTC_NumDoc) > 0)
        Return isValid
    End Function

    Private Sub dtgOperaciones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgOperaciones.CurrentCellChanged
        If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Listar_Documentos_Emitidos_x_Operacion()
        MostrarServicios_Operacion_Documento()
    End Sub

    Private Sub Listar_Documentos_Emitidos_x_Operacion()
        Dim parametros As New Hashtable
        Dim ReFacturaBLL As New clsFactura
        parametros.Add("PSCCMPN", UcCompania.CCMPN_CodigoCompania)
        parametros.Add("PSCDVSN", UcDivision.Division)
        parametros.Add("PNNOPRCN", dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN"))
        Me.dgwDocumentosEmitidos.AutoGenerateColumns = False
        Me.dgwDocumentosEmitidos.DataSource = ReFacturaBLL.Listar_Documentos_Emitidos_x_Operacion(parametros)
    End Sub
    Private Sub ValidarDocumento(ByVal Fila As Int32)
        dtgOperaciones.EndEdit()
        If dtgOperaciones.Rows(Fila).Cells("chk").Value = True Then
            Dim msgValidar As String = ""
            msgValidar = EsSeleccionValida()
            If msgValidar.Length > 0 Then
                dtgOperaciones.EndEdit()
                dtgOperaciones.Item("chk", Fila).Value = False
            End If
        End If
    End Sub
    Private Sub dtgOperaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim ColumnaName As String = dtgOperaciones.Columns(e.ColumnIndex).Name
                Select Case ColumnaName
                    Case "chk"
                        ValidarDocumento(e.RowIndex)
                        'AdicionarServiciosOperacionDocumento(e.RowIndex, e.ColumnIndex)
                End Select

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dtgOperaciones_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellContentDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim ColumnaName As String = dtgOperaciones.Columns(e.ColumnIndex).Name
                Select Case ColumnaName
                    Case "chk"
                        ValidarDocumento(e.RowIndex)
                        'AdicionarServiciosOperacionDocumento(e.RowIndex, e.ColumnIndex)
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarServicios_Operacion_Documento()
        dtgServiciosOperacion.DataSource = Nothing
        Dim brServicioOperacion As New clsServicioOperacion
        Dim dt As New DataTable
        Dim Fila As Int32 = dtgOperaciones.CurrentRow.Index
        Dim obeServicioOperacion As New ServicioOperacion
        obeServicioOperacion.CCMPN = ("" & dtgOperaciones.Rows(Fila).Cells("CCMPN").Value).ToString.Trim
        obeServicioOperacion.CDVSN = ("" & dtgOperaciones.Rows(Fila).Cells("CDVSN").Value).ToString.Trim
        obeServicioOperacion.CCLNT = dtgOperaciones.Rows(Fila).Cells("CCLNT").Value
        obeServicioOperacion.NOPRCN = dtgOperaciones.Rows(Fila).Cells("NOPRCN").Value
        obeServicioOperacion.NCRRFC = dtgOperaciones.Rows(Fila).Cells("NCRRFC").Value
        obeServicioOperacion.CTPODC = dtgOperaciones.Rows(Fila).Cells("CTPODC").Value
        obeServicioOperacion.NDCFCC = dtgOperaciones.Rows(Fila).Cells("NDCFCC_OP").Value
        dt = brServicioOperacion.Lista_Servicios_Operacion_Documento(obeServicioOperacion)
        dtgServiciosOperacion.DataSource = dt
    End Sub

    'Private Sub EliminarOperacionServicio(ByVal Fila As Int32)
    '    Dim CCLNT As Decimal = dtgOperaciones.Rows(Fila).Cells("CCLNT").Value
    '    Dim NOPRCN As Decimal = dtgOperaciones.Rows(Fila).Cells("NOPRCN").Value
    '    Dim NCRRFC As Decimal = dtgOperaciones.Rows(Fila).Cells("NCRRFC").Value
    '    Dim CTPODC As Decimal = dtgOperaciones.Rows(Fila).Cells("CTPODC").Value
    '    Dim NDCFCC As Decimal = dtgOperaciones.Rows(Fila).Cells("NDCFCC_OP").Value
    '    Dim CodFila As String = CCLNT & "_" & NOPRCN & "_" & NCRRFC & "_" & CTPODC & "_" & NDCFCC
    '    Dim CCLNT_SERV As Decimal = 0
    '    Dim NOPRCN_SERV As Decimal = 0
    '    Dim NCRRFC_SERV As Decimal = 0
    '    Dim CTPODC_SERV As Decimal = 0
    '    Dim NDCFCC_SERV As Decimal = 0
    '    Dim CodFilaServ As String = ""
    '    For FilaIndex As Integer = dtgServiciosOperacion.Rows.Count - 1 To 0 Step -1
    '        CCLNT_SERV = dtgServiciosOperacion.Rows(FilaIndex).Cells("CCLNT_SERV").Value
    '        NOPRCN_SERV = dtgServiciosOperacion.Rows(FilaIndex).Cells("NOPRCN_SERV").Value
    '        NCRRFC_SERV = dtgServiciosOperacion.Rows(FilaIndex).Cells("NCRRFC_SERV").Value
    '        CTPODC_SERV = dtgServiciosOperacion.Rows(FilaIndex).Cells("CTPODC_SERV").Value
    '        NDCFCC_SERV = dtgServiciosOperacion.Rows(FilaIndex).Cells("NDCFCC_SERV").Value            
    '        CodFilaServ = CCLNT_SERV & "_" & NOPRCN_SERV & "_" & NCRRFC_SERV & "_" & CTPODC_SERV & "_" & NDCFCC_SERV
    '        If CodFila = CodFilaServ Then
    '            dtgServiciosOperacion.Rows.RemoveAt(FilaIndex)
    '        End If
    '    Next
    'End Sub
    'Private Sub AdicionarServiciosOperacionDocumento(ByVal Fila As Int32, ByVal Columna As Int32)
    '    dtgOperaciones.EndEdit()
    '    If dtgOperaciones.Rows(Fila).Cells("chk").Value = True Then
    '        Dim msgValidar As String = ""
    '        msgValidar = EsSeleccionValida()
    '        If msgValidar.Length > 0 Then
    '            dtgOperaciones.EndEdit()
    '            dtgOperaciones.Item("chk", Fila).Value = False
    '        End If
    '    End If
    '    EliminarOperacionServicio(Fila)

    '    If dtgOperaciones.Rows(Fila).Cells("chk").Value = True Then
    '        Dim brServicioOperacion As New clsServicioOperacion
    '        Dim dt As New DataTable
    '        Dim obeServicioOperacion As New ServicioOperacion
    '        obeServicioOperacion.CCMPN = ("" & dtgOperaciones.Rows(Fila).Cells("CCMPN").Value).ToString.Trim
    '        obeServicioOperacion.CDVSN = ("" & dtgOperaciones.Rows(Fila).Cells("CDVSN").Value).ToString.Trim
    '        obeServicioOperacion.CCLNT = dtgOperaciones.Rows(Fila).Cells("CCLNT").Value
    '        obeServicioOperacion.NOPRCN = dtgOperaciones.Rows(Fila).Cells("NOPRCN").Value
    '        obeServicioOperacion.NCRRFC = dtgOperaciones.Rows(Fila).Cells("NCRRFC").Value
    '        obeServicioOperacion.CTPODC = dtgOperaciones.Rows(Fila).Cells("CTPODC").Value
    '        obeServicioOperacion.NDCFCC = dtgOperaciones.Rows(Fila).Cells("NDCFCC_OP").Value
    '        dt = brServicioOperacion.Lista_Servicios_Operacion_Documento(obeServicioOperacion)

    '        Dim oDrVw As DataGridViewRow
    '        Dim FilaActual As Int32 = 0
    '        For IndexFila As Integer = 0 To dt.Rows.Count - 1
    '            oDrVw = New DataGridViewRow
    '            oDrVw.CreateCells(dtgServiciosOperacion)
    '            dtgServiciosOperacion.Rows.Add(oDrVw)
    '            FilaActual = dtgServiciosOperacion.Rows.Count - 1
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("NOPRCN_SERV").Value = dt.Rows(IndexFila)("NOPRCN")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("NCRRFC_SERV").Value = dt.Rows(IndexFila)("NCRRFC")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("CTPODC_SERV").Value = dt.Rows(IndexFila)("CTPODC")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("NDCFCC_SERV").Value = dt.Rows(IndexFila)("NDCFCC")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("NCRROP_SERV").Value = dt.Rows(IndexFila)("NCRROP")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("NRTFSV_SERV").Value = dt.Rows(IndexFila)("NRTFSV")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("DESTAR_SERV").Value = dt.Rows(IndexFila)("DESTAR")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("CUNDMD_SERV").Value = dt.Rows(IndexFila)("CUNDMD")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("QATNAN_SERV").Value = dt.Rows(IndexFila)("QATNAN")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("TARIFA_SERV").Value = dt.Rows(IndexFila)("IVLSRV")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("MONTO_SERV").Value = dt.Rows(IndexFila)("MONTO")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("TABTPD_SERV").Value = dt.Rows(IndexFila)("TABTPD")
    '            dtgServiciosOperacion.Rows(FilaActual).Cells("CCLNT_SERV").Value = dt.Rows(IndexFila)("CCLNT")
    '        Next
    '    End If
    'End Sub

End Class
