Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports System.Threading
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones.ReFacturacion_BLL
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

'inicio de programacion
 

Public Class FrmReFactElectronico
    Private objRefact_BLL As NEGOCIO.Operaciones.ReFacturacion_BLL
    Private oDtPlanta As New DataTable
    Private TipoCambioActual As Decimal = 0
    Private strNumSAP As String = String.Empty

    Dim hiloCompania As String
    Dim hiloTipoDoc As Int32
    Dim hiloNumFact As Long

    Private Sub FrmRefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chkFechaDoc.Checked = True
            chkFechaDoc_CheckedChanged(chkFechaDoc, Nothing)
            dtgCuentaCorriente.AutoGenerateColumns = False
            dtgServiciosOperacion.AutoGenerateColumns = False
            dgvHistorialxDocumento.AutoGenerateColumns = False
            dtgVentas.AutoGenerateColumns = False

            Cargar_Compania()

            UcClienteFact.pAccesoPorUsuario = False
            UcClienteFact.pUsuario = ConfigurationWizard.UserName

            Cargar_Tipo_Documento()
            Cargar_Estado_Documento()
            Cargar_Estado_Sunat()


            Dim oFiltro As New Hashtable
            Dim oDt As New DataTable
            Dim oFacturaNeg As New NEGOCIO.Operaciones.Factura_Transporte_BLL
            oFiltro.Add("PNCMNDA1", "100")
            oFiltro.Add("PNFCMBO", Format(Now, "yyyyMMdd"))
            oFiltro.Add("PSCCMPN", UcCompania.CCMPN_CodigoCompania)
            oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)

            If oDt.Rows.Count > 0 Then
                TipoCambioActual = oDt.Rows(0)("IVNTA")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        Try
            UcDivision.Usuario = MainModule.USUARIO
            UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                UcDivision.DivisionDefault = "T"
            End If
            UcDivision.ItemTodos = False
            UcDivision.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Tipo_Documento()
        Dim objTipoDocumento_BLL As New mantenimientos.TipoDocumento_BLL
        Dim objEntidad As New TipoDocumento
        objEntidad.CCMPN = UcCompania.CCMPN_CodigoCompania
        cboTipoDoc.DataSource = objTipoDocumento_BLL.Listar_Tipo_Documentos_Para_Refacturar_FE(objEntidad)
        cboTipoDoc.DisplayMember = "TCMTPD"
        cboTipoDoc.ValueMember = "CTPODC"
    End Sub

    Private Sub Cargar_Estado_Sunat()
        Dim objEstadoSunat_BLL As New Operaciones.TipoDatoGeneral_BLL
        Dim olistEstado As New List(Of TipoDatoGeneral)
        olistEstado = objEstadoSunat_BLL.Lista_Tipo_Dato_General(UcCompania.CCMPN_CodigoCompania, "STDESN")
        Dim obeTipoDatoGeneral As New TipoDatoGeneral
        obeTipoDatoGeneral.CODIGO_TIPO = "-1"
        obeTipoDatoGeneral.DESC_TIPO = "Todos"
        olistEstado.Insert(0, obeTipoDatoGeneral)

        cboEstadoSunat.DataSource = olistEstado
        cboEstadoSunat.DisplayMember = "DESC_TIPO"
        cboEstadoSunat.ValueMember = "CODIGO_TIPO"
    End Sub

    Private Sub Cargar_Estado_Documento()
        Dim objEstadoDocumento_BLL As New Operaciones.TipoDatoGeneral_BLL

        Dim dtEstado As New datatable
        dtEstado.columns.add("CODIGO_TIPO")
        dtEstado.columns.add("DESC_TIPO")
        Dim dr As datarow
        dr = dtEstado.newrow
        dr("CODIGO_TIPO") = "A"
        dr("DESC_TIPO") = "Activo"
        dtEstado.rows.add(dr)

        dr = dtEstado.newrow
        dr("CODIGO_TIPO") = "*"
        dr("DESC_TIPO") = "Inactivo"
        dtEstado.rows.add(dr)

        cboEstadoDocumento.DataSource = dtEstado
        cboEstadoDocumento.DisplayMember = "DESC_TIPO"
        cboEstadoDocumento.ValueMember = "CODIGO_TIPO"
    End Sub
    Private Sub BusquedaOperaciones()
        dtgCuentaCorriente.DataSource = Nothing
        dtgServiciosOperacion.DataSource = Nothing
        dtgVentas.DataSource = Nothing
        dgvHistorialxDocumento.DataSource = Nothing
        Dim dtCuentaContable As New DataTable
        Dim parametros As New Hashtable
        objRefact_BLL = New NEGOCIO.Operaciones.ReFacturacion_BLL

        parametros.Add("PSCCMPN", UcCompania.CCMPN_CodigoCompania)
        parametros.Add("PSCDVSN", UcDivision.Division)
        parametros.Add("PNTIPO_PLANTA", String.Empty)
        parametros.Add("PNCCLNT_FAC", IIf(Me.UcClienteFact.pCodigo = 0, 0, Me.UcClienteFact.pCodigo))
        parametros.Add("PNCTPODC", Me.cboTipoDoc.SelectedValue)
        parametros.Add("PNNDCCTC", IIf(Me.txtNumDocumento.Text = "", 0, Me.txtNumDocumento.Text))
        parametros.Add("PNFECINI", IIf(Me.dtFechaInicio.Enabled = False, 0, HelpClass.CFecha_a_Numero8Digitos(Me.dtFechaInicio.Value)))
        parametros.Add("PNFECFIN", IIf(Me.dtFechaFin.Enabled = False, 0, HelpClass.CFecha_a_Numero8Digitos(Me.dtFechaFin.Value)))

        parametros.Add("PAGESIZE", Me.UcPaginacion1.PageSize)
        parametros.Add("PAGENUMBER", Me.UcPaginacion1.PageNumber)

        parametros.Add("PSESTSUN", IIf(Me.cboEstadoSunat.SelectedValue <> "S", Me.cboEstadoSunat.SelectedValue, ""))
        parametros.Add("PSSESTRG", Me.cboEstadoDocumento.SelectedValue)


        Dim Num_pag As Integer = 0

        dtCuentaContable = objRefact_BLL.Lista_Cuenta_Corriente_Refactura(parametros, Num_pag)

        dtgCuentaCorriente.DataSource = dtCuentaContable

        Dim i As Integer = 0

        If dtgCuentaCorriente.Rows.Count Then
            For i = 0 To dtgCuentaCorriente.Rows.Count - 1
                If dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Value = "0" Then
                    dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Value = "Enviar SAP"
                End If

                If dtgCuentaCorriente.Rows(i).Cells("URLARC").Value.ToString.Trim = String.Empty And dtgCuentaCorriente.Rows(i).Cells("CTPODC_DOC").Value <> 6 Then
                    dtgCuentaCorriente.Rows(i).Cells("link").Value = My.Resources.text_block
                End If
            Next
        End If

        If Num_pag > 0 Then
            UcPaginacion1.PageCount = Num_pag
        End If

    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Try
            dtgCuentaCorriente.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing
            dtgVentas.DataSource = Nothing
            dgvHistorialxDocumento.DataSource = Nothing
            BusquedaOperaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'fin de comentario
    Public Function Demo1() As String
        Return ""
    End Function

    Private Function ValidarBusqueda() As String
        Dim strMensaje As String = String.Empty
        If Not chkFechaDoc.Checked = True Then
            Dim NumDoc As Decimal = Val(txtNumDocumento.Text.Trim)
            If NumDoc = 0 Then
                strMensaje = "INgrese Nro. Documento válido."
            End If
        End If
        Return strMensaje
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dtgCuentaCorriente.DataSource = Nothing
            dtgServiciosOperacion.DataSource = Nothing
            Dim strResult As String = String.Empty

            strResult = ValidarBusqueda()
            If strResult.Length > 0 Then
                MessageBox.Show(strResult, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            BusquedaOperaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaCredito.Click
        Try
            If ValidarDocumentoEmision(clsComun.TipoDocumento.NotaCreditoE) Then
                VistaXTipoDocumento(clsComun.TipoDocumento.NotaCreditoE)
            Else
                MessageBox.Show("No se puede generar el documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNotaDebito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaDebito.Click
        Try
            If ValidarDocumentoEmision(clsComun.TipoDocumento.NotaDebitoE) Then
                VistaXTipoDocumento(clsComun.TipoDocumento.NotaDebitoE)
            Else
                MessageBox.Show("No es posible la emisión al documento origen seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarDocumentoEmision(ByVal _TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento) As Boolean
        Dim Result As Boolean
        If dtgCuentaCorriente.Rows.Count > 0 Then
            Dim NumDocOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
            If _TipoDocumentoEmision = clsComun.TipoDocumento.NotaCreditoE Then
                Select Case NumDocOrigen
                    Case 1, 51, 2, 52, 7, 57
                        Result = True
                End Select
            ElseIf _TipoDocumentoEmision = clsComun.TipoDocumento.NotaDebitoE Then
                Select Case NumDocOrigen
                    Case 1, 51, 7, 57, 3, 53
                        Result = True
                End Select
            End If
        End If

        Return Result
    End Function

    Private Sub VistaXTipoDocumento(ByVal _TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento)
        If dtgCuentaCorriente.CurrentRow Is Nothing Then
            Exit Sub
        End If

        objRefact_BLL = New NEGOCIO.Operaciones.ReFacturacion_BLL

        Dim dtDatoDoc As New DataTable
        Dim parametros As New Hashtable

        Dim TipoDocumento As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        Dim msgValidacion As String = ""
        Select Case TipoDocumento
            Case 51, 52, 53, 57
                If ("" & dtgCuentaCorriente.CurrentRow.Cells("NDCMSP").Value).ToString.Trim.ToUpper = "ENVIAR SAP" Then
                    msgValidacion = "No tiene documento SAP.Debe reenviar el documento(Enviar Sap)."
                End If
                If msgValidacion = "" Then
                    Dim estadosunat As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("ESTSUN").Value).ToString.Trim
                    Dim stadopp As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("ESTPP").Value).ToString.Trim
                    If estadosunat = "" Or stadopp = "" Then
                        'msgValidacion = "Debe actualizar los estados Sunat/PP"
                        msgValidacion = "Estados Sunat/PP no actualizados."
                    Else
                        If Not (stadopp = "0" Or estadosunat = "1" Or estadosunat = "2" Or estadosunat = "3") Then
                            'msgValidacion = "No se tiene respuesta válida.Debe actualizar los estados Sunat/PP"
                            msgValidacion = "Estados Sunat/PP sin respuesta válida."
                        End If
                    End If
                End If
        End Select

        If msgValidacion <> "" Then
            If MessageBox.Show(msgValidacion & Chr(13) & " Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Dim PSCCMPN As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
        Dim PSCDVSN As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim
        Dim PNCTPODC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        Dim PNNDCCTC As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value

        parametros.Add("PSCCMPN", PSCCMPN)
        parametros.Add("PNCTPODC", PNCTPODC)
        parametros.Add("PNNDCCTC", PNNDCCTC)
        parametros.Add("PSCDVSN", PSCDVSN)

        dtDatoDoc = objRefact_BLL.Lista_Dato_General_Documento(parametros)

        Dim SESTRG As String = ""
        If dtDatoDoc.Rows.Count = 0 Then
            MessageBox.Show("No se puede emitir documento" & Chr(13) & "No existe Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf dtDatoDoc.Rows.Count > 0 Then
            SESTRG = ("" & dtDatoDoc.Rows(0)("SESTRG")).ToString.Trim
            If SESTRG = "*" Then
                If MessageBox.Show("El documento se encuentra eliminado(*). Desea continuar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If

        Dim dblSaldoRefactura As Decimal = 0
        Select Case _TipoDocumentoEmision
            Case clsComun.TipoDocumento.NotaCreditoE, clsComun.TipoDocumento.NotaDebitoE
                Dim dtImporteFact As New DataTable
                Dim parametros1 As New Hashtable
                parametros1.Add("PSCCMPN", PSCCMPN)
                parametros1.Add("PNCTPODC", PNCTPODC)
                parametros1.Add("PNNDCMFC", PNNDCCTC)
                parametros1.Add("PSCDVSN", PSCDVSN)

                dtImporteFact = objRefact_BLL.Traer_Importe_Refactura_E(parametros1)

                If dtImporteFact.Rows.Count > 0 Then
                    For indice As Integer = 0 To dtImporteFact.Rows.Count - 1
                        dblSaldoRefactura += dtImporteFact.Rows(indice).Item("IMPORTE")
                    Next
                    If dblSaldoRefactura <= 0 Then
                        If MessageBox.Show("El documento tiene saldo " & dblSaldoRefactura & Chr(13) & "Desea continuar?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If
                Else
                    HelpClass.MsgBox("No se encontró el documento", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
        End Select


        Dim CodCompañia As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
        Dim CodDivison As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim
        Dim TipDocOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
        Dim NumDocOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
        Dim abreviaturaDocOrigen As String = dtgCuentaCorriente.CurrentRow.Cells("TABTPD_DOC").Value
        Dim abreviaturamoneda As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("SI_MONE").Value).ToString.Trim
        Dim TipoMoneda As String = IIf(dtgCuentaCorriente.CurrentRow.Cells("CMNDA").Value = 1, "SOL", "DOL")
        Dim FechaDocOrigen As Decimal = CType(dtgCuentaCorriente.CurrentRow.Cells("FE_CNTA_CNTE").Value, Decimal)
        Dim TipCambioDocOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("ITCCTC").Value

        Dim ImporteDocOrigen As Decimal = 0
        If TipoMoneda = "SOL" Then
            ImporteDocOrigen = dtgCuentaCorriente.CurrentRow.Cells("IVLAFS").Value
        Else
            ImporteDocOrigen = dtgCuentaCorriente.CurrentRow.Cells("IVLAFD").Value
        End If

        Dim ofrmNotaCredito As New frmNotaCreditoElectronico

        ofrmNotaCredito.CodCompañia = CodCompañia
        ofrmNotaCredito.CodDivision = CodDivison
        ofrmNotaCredito.TipoDocOrigen = TipDocOrigen
        ofrmNotaCredito.NumDocOrigen = NumDocOrigen
        ofrmNotaCredito.FechaDocOrigen = FechaDocOrigen
        ofrmNotaCredito.abriaturaDocOrigen = abreviaturaDocOrigen
        ofrmNotaCredito.abreviaturaMoneda = abreviaturamoneda
        ofrmNotaCredito.importeDocOrigen = ImporteDocOrigen
        ofrmNotaCredito.TipoMoneda = TipoMoneda
        ofrmNotaCredito.TipCambioDocOrigen = TipCambioDocOrigen
        ofrmNotaCredito.TipCambioActual = TipoCambioActual
        ofrmNotaCredito.TipoDocumentoEmision = _TipoDocumentoEmision

        If ofrmNotaCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
            LlamarVistaPrevia(ofrmNotaCredito.dtServiciosTodosOp, _TipoDocumentoEmision, ofrmNotaCredito.ohashNumOpSelec, ofrmNotaCredito.CodMotivo, ofrmNotaCredito.Motivo)
        End If

    End Sub

    Private Sub LlamarVistaPrevia(ByVal dtServiciosTodosOp As DataTable, ByVal _TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento, ByVal oHashOpeSelec As Hashtable, ByVal CodMotivo As Integer, ByVal Motivo As String)

        Dim oFacturaNeg As New ReFacturacion_BLL

        Dim CodComp As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
        Dim CodDivison As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim

        If TipoCambioActual = 0 Then
            MessageBox.Show("No se puede generar el documento por no existir Tipo de Cambio a la Fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim oDtGiro As DataTable
        Dim oFiltro1 As New Hashtable
        oFiltro1.Add("PSCCMPN", CodComp)
        oFiltro1.Add("PSCDVSN", CodDivison)

        oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro1)
        If oDtGiro.Rows.Count > 0 Then

            Dim pstrCodDiv As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim
            Dim pstrDivicion As String = UcDivision.DivisionDescripcion
            Dim pstrCodCom As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
            Dim pdblCliente As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CO_CLIE").Value
            Dim pstrCodPlanta As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CO_PLAN").Value).ToString.Trim
            Dim pstrMoneda As String = IIf(dtgCuentaCorriente.CurrentRow.Cells("CMNDA").Value = 1, "SOL", "DOL")
            Dim pintZonaFacturacion As Integer = dtgCuentaCorriente.CurrentRow.Cells("CZNFCC").Value
            Dim pstrOrgVenta As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CRGVTA").Value).ToString.Trim

            Dim FechaDocAtencion As Date = Date.Now
            Dim TipoCambioOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("ITCCTC").Value

            Dim TipoDocOrigen As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CTPDCO_CAB").Value).ToString.Trim
            Dim NumDocOrigen As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCMOR_CAB").Value
            Dim FechaDocOrigen As Decimal = CType(dtgCuentaCorriente.CurrentRow.Cells("FDCMOR_CAB").Value, Decimal)


            Dim TipDocOrigenOP As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
            Dim NumDocOrigenOP As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
            Dim FechaDocOrigenOP As Decimal = CType(dtgCuentaCorriente.CurrentRow.Cells("FE_CNTA_CNTE").Value, Decimal)

            If TipoDocOrigen = 0 Then
                TipoDocOrigen = TipDocOrigenOP
                NumDocOrigen = NumDocOrigenOP
                FechaDocOrigen = FechaDocOrigenOP
            End If

            Dim objfrmVFactura As New frmVistaReFacturaElectronico(pstrDivicion, pstrCodDiv, pstrCodCom, pdblCliente, pstrCodPlanta, pstrMoneda, pintZonaFacturacion, pstrOrgVenta)

            objfrmVFactura.dtListaServicioDoc = dtServiciosTodosOp

            'objfrmVFactura.Tag = 1
            objfrmVFactura.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
            objfrmVFactura.TipoDocumentoEmision = _TipoDocumentoEmision
            objfrmVFactura.oHashListaOpeLiberar = oHashOpeSelec
            objfrmVFactura.TipoCambioOrigen = TipoCambioOrigen

            objfrmVFactura.TipoDocOrigen = TipoDocOrigen
            objfrmVFactura.NumDocOrigen = NumDocOrigen
            objfrmVFactura.FechaDocOrigen = FechaDocOrigen

            objfrmVFactura.TipoDocOrigenOPRef = TipDocOrigenOP
            objfrmVFactura.NumDocOrigenOPRef = NumDocOrigenOP
            objfrmVFactura.FechaDocOrigenOPRef = FechaDocOrigenOP

            objfrmVFactura.ldtpFechaFactura = FechaDocAtencion
            objfrmVFactura.CodMotivo = CodMotivo
            objfrmVFactura.Motivo = Motivo
            If objfrmVFactura.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            BusquedaOperaciones()
        Else
            MessageBox.Show("Usted no tiene Acceso a generar este documento", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub dtgCuentaCorriente_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCuentaCorriente.SelectionChanged
        If dtgCuentaCorriente.CurrentCellAddress.Y = -1 Then Exit Sub
        Try

            dtgServiciosOperacion.DataSource = Nothing
            dgvHistorialxDocumento.DataSource = Nothing
            dtgVentas.DataSource = Nothing

            Dim parametros As New Hashtable
            objRefact_BLL = New NEGOCIO.Operaciones.ReFacturacion_BLL

            If dtgCuentaCorriente.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ccmpn As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
            Dim cdvsn As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim
            Dim tipodoc As Decimal = dtgCuentaCorriente.CurrentRow.Cells("CTPODC_DOC").Value
            Dim numDoc As Decimal = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value

            parametros.Add("PSCCMPN", ccmpn)
            parametros.Add("PSCDVSN", cdvsn)
            parametros.Add("PNCTPODC", tipodoc)
            parametros.Add("PNNDCCTC", numDoc)

            Dim dsSeg As New DataSet
            dsSeg = objRefact_BLL.Listar_SegHistorial_Documento_Refactura(parametros)

            Dim dtServiciosOP As New DataTable
            Dim dtSegOp As New DataTable
            Dim dtSegCtaCte As New DataTable

            dtServiciosOP = dsSeg.Tables(0).Copy
            dtSegCtaCte = dsSeg.Tables(1).Copy
            dtSegOp = dsSeg.Tables(2).Copy

            dtgServiciosOperacion.DataSource = dtServiciosOP
            dgvHistorialxDocumento.DataSource = dtSegOp
            dtgVentas.DataSource = dtSegCtaCte

            Dim LisOp As New List(Of String)
            Dim NOPRCN As String = ""
            For Each Item As DataGridViewRow In dtgServiciosOperacion.Rows
                NOPRCN = Item.Cells("NOPRCN_D").Value
                If Not LisOp.Contains(NOPRCN) Then
                    LisOp.Add(NOPRCN)
                    Item.Cells("HISTRL").Value = "Historial"
                Else
                    Item.Cells("HISTRL").Value = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgServiciosOperacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgServiciosOperacion.CellContentClick
        Try
            If dtgCuentaCorriente.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If dtgServiciosOperacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim NameColumn As String = dtgServiciosOperacion.Columns(e.ColumnIndex).Name
            Select Case NameColumn
                Case "HISTRL"
                    Dim ccmpn As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
                    Dim cdvsn As String = ("" & dtgCuentaCorriente.CurrentRow.Cells("CDVSN_DOC").Value).ToString.Trim
                    Dim PNNOPRCN As Decimal = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_D").Value
                    Dim frmHistorialOperaciones As New FormHistorialOperaciones
                    frmHistorialOperaciones.Compania = ccmpn
                    frmHistorialOperaciones.Division = cdvsn
                    frmHistorialOperaciones.Operacion = PNNOPRCN
                    frmHistorialOperaciones.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcClienteFact_InformationChanged() Handles UcClienteFact.InformationChanged
        Try
            btnBuscar_Click(btnBuscar, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkFechaDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaDoc.CheckedChanged

        dtFechaInicio.Enabled = chkFechaDoc.Checked
        dtFechaFin.Enabled = chkFechaDoc.Checked
        txtNumDocumento.Enabled = Not chkFechaDoc.Checked

    End Sub

    Private Sub dtgCuentaCorriente_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellDoubleClick
        Try
            If dtgCuentaCorriente.Rows.Count > 0 Then
                Dim tipoDoc As Decimal = dtgCuentaCorriente.Item("CTPODC_DOC", e.RowIndex).Value 'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA
                Select Case dtgCuentaCorriente.Columns(e.ColumnIndex).Name
                    Case "link"
                        If tipoDoc = "6" Then
                            Dim frm As New frmVistarptParteTransf()
                            frm.PSCCMPN = ("" & dtgCuentaCorriente.CurrentRow.Cells("CCMPN_DOC").Value).ToString.Trim
                            frm.PNCTPODC = dtgCuentaCorriente.Item("CTPODC_DOC", e.RowIndex).Value
                            frm.PNNDCCTC = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC_DOC").Value
                            frm.ShowDialog()
                        Else
                            Dim result As String = ("" & dtgCuentaCorriente.Item("URLARC", e.RowIndex).Value).ToString.Trim
                            If result.Length > 0 Then
                                Dim startInfo As New ProcessStartInfo(result)
                                startInfo.WindowStyle = ProcessWindowStyle.Maximized
                                Process.Start(startInfo)
                            End If
                        End If
                    Case "NDCMSP"
                        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                        If tipoDoc = "6" Then
                            MessageBox.Show("Los documentos de Parte Transferencia no son permitidos para envío a SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information) 'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA
                        Else
                            'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
                            If dtgCuentaCorriente.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Enviar SAP" Then
                                Enviar_Factura(dtgCuentaCorriente.Rows(e.RowIndex))
                            End If
                        End If

                    Case Else

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub dtgCuentaCorriente_CellMouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgCuentaCorriente.CellMouseMove
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If
            If (dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "link" Or dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "NDCMSP") Then
                dtgCuentaCorriente.Cursor = Cursors.Hand
            Else
                dtgCuentaCorriente.Cursor = Cursors.Default
                If (dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "ESTPP") Then
                    dtgCuentaCorriente.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = dtgCuentaCorriente.Rows(e.RowIndex).Cells("MSJPPL").Value.ToString.Trim
                Else
                    If (dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "ESTSUN") Then
                        dtgCuentaCorriente.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = dtgCuentaCorriente.Rows(e.RowIndex).Cells("MSJSUN").Value.ToString.Trim
                    Else
                        dtgCuentaCorriente.Cursor = Cursors.Default
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgCuentaCorriente_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCuentaCorriente.MouseMove
        dtgCuentaCorriente.Cursor = Cursors.Default
    End Sub


    Private Sub Enviar_Factura(ByVal fila As DataGridViewRow)
        Dim Compania As String = String.Empty
        Dim TipoDoc As String = String.Empty
        Dim NumeroDoc As String = String.Empty

        Compania = fila.Cells("CCMPN_DOC").Value.ToString
        TipoDoc = fila.Cells("CTPODC_DOC").Value.ToString.Trim
        NumeroDoc = fila.Cells("NDCCTC_DOC").Value.ToString

        Select Case TipoDoc
            Case "1", "7", "2", "3"
                Enviar_Factura_SAP(Compania, TipoDoc, NumeroDoc)
            Case "51", "57", "52", "53"
                Enviar_Factura_SAP_FE(Compania, TipoDoc, NumeroDoc)
            Case Else
                MessageBox.Show("No se ha indentificado ningún tipo de documento de envio a SAP", "Enviar SAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select

        If strNumSAP <> String.Empty Then
            strNumSAP = String.Empty
            Actualizar_Fila(fila)
            
        End If
    End Sub

    Private Sub Actualizar_Fila(ByVal fila As DataGridViewRow)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PSCCMPN", fila.Cells("CCMPN_DOC").Value.ToString)
        oFiltro.Add("PNCTPODC", fila.Cells("CTPODC_DOC").Value.ToString)
        oFiltro.Add("PNNDCCTC", fila.Cells("NDCCTC_DOC").Value.ToString)

        Dim oFacturaNegSAP As New Factura_Transporte_BLL
        Dim oDt As New DataTable
        oDt = oFacturaNegSAP.Comprobar_Envio_Documento_SAP(oFiltro)


        If oDt.Rows.Count > 0 Then
            fila.Cells("ESTSUN").Value = oDt.Rows(0).Item("ESTSUN").ToString.Trim 'estado sunat
            fila.Cells("MSJSUN").Value = oDt.Rows(0).Item("MSJSUN").ToString.Trim 'estado sunat tooltip
            fila.Cells("ESTPP").Value = oDt.Rows(0).Item("ESTPP").ToString.Trim ' estado pp
            fila.Cells("MSJPPL").Value = oDt.Rows(0).Item("MSJPPL").ToString.Trim 'estado pp tooltip
            fila.Cells("URLARC").Value = oDt.Rows(0).Item("URLARC").ToString.Trim ' url pdf
            If fila.Cells("URLARC").Value.ToString <> String.Empty Then
                fila.Cells("link").Value = My.Resources.pdf2
            Else
                fila.Cells("link").Value = My.Resources.text_block
            End If
        End If
    End Sub

    Private Sub Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String)
        Dim oFiltro As Hashtable
        Dim oDt As DataTable
        strNumSAP = String.Empty
        Dim oFacturaNegSAP As New Factura_Transporte_BLL
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania.PadLeft(2, "0"))
            oFiltro.Add("PSCTPODC", pstrTipoDoc.PadLeft(3, "0"))
            oFiltro.Add("PSNDCCTC", pstrNumFact.PadLeft(10, "0"))
            oFacturaNegSAP.Enviar_Documento_SAP(oFiltro)
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PNCTPODC", pstrTipoDoc)
            oFiltro.Add("PNNDCCTC", pstrNumFact)
            oDt = oFacturaNegSAP.Comprobar_Envio_Documento_SAP(oFiltro)
            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim


                hiloCompania = pstrCompania
                hiloTipoDoc = pstrTipoDoc
                hiloNumFact = pstrNumFact

                'Dim oHiloCierreOrdenInterna As Thread
                'oHiloCierreOrdenInterna = New Thread(AddressOf Cerrar_Orden_Interna_Hilos)
                'oHiloCierreOrdenInterna.Start()


                HelpClass.MsgBox("Se envió correctamente al SAP con N° de Documento SAP " & vbCrLf & strNumSAP)
            Else

                MessageBox.Show("No se generó el documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            HelpClass.MsgBox("Error al enviar documento al SAP " & ex.Message)
        End Try
    End Sub

    Private Sub Enviar_Factura_SAP_FE(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String)
        Dim oFiltro As Hashtable
        Dim oDt As DataTable
        strNumSAP = String.Empty
        Dim oFacturaNegSAP As New Factura_Transporte_BLL
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PSCTPODC", pstrTipoDoc.ToString.Trim.PadLeft(3, "0"))
            oFiltro.Add("PSNDCCTC", pstrNumFact.ToString.Trim.PadLeft(10, "0"))
            oFacturaNegSAP.Enviar_Documento_SAP_FE(oFiltro)

            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PNCTPODC", pstrTipoDoc)
            oFiltro.Add("PNNDCCTC", pstrNumFact)
            oDt = oFacturaNegSAP.Comprobar_Envio_Documento_SAP(oFiltro)

            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim


                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                'hiloCompania = pstrCompania
                'hiloTipoDoc = pstrTipoDoc
                'hiloNumFact = pstrNumFact
                'Dim oHiloCierreOrdenInterna As Thread
                'oHiloCierreOrdenInterna = New Thread(AddressOf Cerrar_Orden_Interna_Hilos)
                'oHiloCierreOrdenInterna.Start()
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN


                MessageBox.Show("Se envió correctamente al SAP con N° de Documento SAP " & vbCrLf & strNumSAP, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se generó el documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al enviar documento al SAP " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Actualizar_Estado_Sunat_PP()
        If dtgCuentaCorriente.Rows.Count > 0 Then
            If Not dtgCuentaCorriente.CurrentRow Is Nothing Then
                Dim fila As DataGridViewRow = dtgCuentaCorriente.CurrentRow
                If fila.Cells("NDCMSP").Value <> "Enviar SAP" Then
                    Dim oFactura_Transporte_BLL As New Factura_Transporte_BLL
                    Dim pobjFiltro As New Hashtable
                    Dim oDt As New DataTable
                    Dim oFacturaNeg As New Factura_Transporte_BLL
                    pobjFiltro.Add("PSCCMPN", fila.Cells("CCMPN_DOC").Value.ToString.Trim)
                    pobjFiltro.Add("PSCTPODC", fila.Cells("CTPODC_DOC").Value.ToString.PadLeft(3, "0"))
                    pobjFiltro.Add("PSNDCCTC", fila.Cells("NDCCTC_DOC").Value.ToString.PadLeft(10, "0"))
                    pobjFiltro.Add("PSCSCDSP", fila.Cells("CSCDSP").Value.ToString.Trim)
                    pobjFiltro.Add("PSNDCCTE", fila.Cells("NDCCTE").Value.ToString.Trim)

                    oFactura_Transporte_BLL.Actualizar_Estado_Sunat(pobjFiltro)

                    Actualizar_Fila(fila)

                    'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                Else
                    MessageBox.Show("No se puede actualizar. No tiene documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
                'Else
                '    MessageBox.Show("No se puede actualizar. No tiene documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnActualizarEstadoSunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarEstadoSunat.Click
        Try
            Actualizar_Estado_Sunat_PP()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Private Sub Cerrar_Orden_Interna_Hilos()
    '    Cerrar_Orden_Interna(hiloCompania, hiloTipoDoc, hiloNumFact)
    'End Sub


    'Private Sub Cerrar_Orden_Interna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)
    '    Dim oFiltro As Hashtable
    '    Dim oValor As Int32 = 0
    '    Dim oFacturaNeg As New Factura_Transporte_BLL
    '    Try
    '        oFiltro = New Hashtable
    '        oFiltro.Add("PSCCMPN", pstrCompania)
    '        oFiltro.Add("PSCTPODC", pstrTipoDoc)
    '        oFiltro.Add("PSNDCCTC", pstrNumFact)
    '        If oFacturaNeg.Cerrar_Orden_Interna_Factura(oFiltro) = 0 Then
    '            MessageBox.Show("Error al cerrar Orden / Interna Factura N° " & pstrNumFact.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch : End Try

    'End Sub
End Class

