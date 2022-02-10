
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Public Class frmNotaCreditoElectronico

    Private oReFacBL As NEGOCIO.Operaciones.ReFacturacion_BLL

    Private _TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento = clsComun.TipoDocumento.Neutro
    Public Property TipoDocumentoEmision() As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento
        Get
            Return _TipoDocumentoEmision
        End Get
        Set(ByVal value As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento)
            _TipoDocumentoEmision = value
        End Set
    End Property

    Private _pTipoVerDocumento As NEGOCIO.clsComun.VistaImpresion
    Public ReadOnly Property pTipoVerDocumento() As NEGOCIO.clsComun.VistaImpresion
        Get
            Return _pTipoVerDocumento
        End Get
    End Property

    Private _dtServiciosTodosOp As New DataTable
    Public Property dtServiciosTodosOp() As DataTable
        Get
            Return _dtServiciosTodosOp
        End Get
        Set(ByVal value As DataTable)
            _dtServiciosTodosOp = value
        End Set
    End Property

    Private _dtOperacion As New DataTable
    Public Property dtOperacion() As DataTable
        Get
            Return _dtOperacion
        End Get
        Set(ByVal value As DataTable)
            _dtOperacion = value
        End Set
    End Property

    Private _CodCompañia As String
    Public Property CodCompañia() As String
        Get
            Return _CodCompañia
        End Get
        Set(ByVal value As String)
            _CodCompañia = value
        End Set
    End Property

    Private _CodDivision As String
    Public Property CodDivision() As String
        Get
            Return _CodDivision
        End Get
        Set(ByVal value As String)
            _CodDivision = value
        End Set
    End Property

    Private _TipoDocOrigen As String
    Public Property TipoDocOrigen() As String
        Get
            Return _TipoDocOrigen
        End Get
        Set(ByVal value As String)
            _TipoDocOrigen = value
        End Set
    End Property

    Private _NumDocOrigen As Decimal
    Public Property NumDocOrigen() As Decimal
        Get
            Return _NumDocOrigen
        End Get
        Set(ByVal value As Decimal)
            _NumDocOrigen = value
        End Set
    End Property

    Private _FechaDocOrigen As Decimal
    Public Property FechaDocOrigen() As Decimal
        Get
            Return _FechaDocOrigen
        End Get
        Set(ByVal value As Decimal)
            _FechaDocOrigen = value
        End Set
    End Property



  



    Private _abriaturaDocOrigen As String
    Public Property abriaturaDocOrigen() As String
        Get
            Return _abriaturaDocOrigen
        End Get
        Set(ByVal value As String)
            _abriaturaDocOrigen = value
        End Set
    End Property

    Private _abreviaturaMoneda As String
    Public Property abreviaturaMoneda() As String
        Get
            Return _abreviaturaMoneda
        End Get
        Set(ByVal value As String)
            _abreviaturaMoneda = value
        End Set
    End Property

    Private _importeDocOrigen As Decimal
    Public Property importeDocOrigen() As Decimal
        Get
            Return _importeDocOrigen
        End Get
        Set(ByVal value As Decimal)
            _importeDocOrigen = value
        End Set
    End Property

   

    Private _TipoMoneda As String
    Public Property TipoMoneda() As String
        Get
            Return _TipoMoneda
        End Get
        Set(ByVal value As String)
            _TipoMoneda = value
        End Set
    End Property

    Private _TipCambioActual As Decimal = 0
    Public Property TipCambioActual() As Decimal
        Get
            Return _TipCambioActual
        End Get
        Set(ByVal value As Decimal)
            _TipCambioActual = value
        End Set
    End Property

    Private _TipCambioDocOrigen As Decimal = 0
    Public Property TipCambioDocOrigen() As Decimal
        Get
            Return _TipCambioDocOrigen
        End Get
        Set(ByVal value As Decimal)
            _TipCambioDocOrigen = value
        End Set
    End Property

    Private _lstServicios As List(Of ENTIDADES.Servicio)
    Public Property lstServicios() As List(Of ENTIDADES.Servicio)
        Get
            Return _lstServicios
        End Get
        Set(ByVal value As List(Of ENTIDADES.Servicio))
            _lstServicios = value
        End Set
    End Property

    Private _ohashNumOpSelec As Hashtable
    Public Property ohashNumOpSelec() As Hashtable
        Get
            Return _ohashNumOpSelec
        End Get
        Set(ByVal value As Hashtable)
            _ohashNumOpSelec = value
        End Set
    End Property

    Private _CodMotivo As Integer = 0
    Public Property CodMotivo() As Integer
        Get
            Return _CodMotivo
        End Get
        Set(ByVal value As Integer)
            _CodMotivo = value
        End Set
    End Property
    Private _Motivo As String = ""
    Public Property Motivo() As String
        Get
            Return _Motivo
        End Get
        Set(ByVal value As String)
            _Motivo = value
        End Set
    End Property

    Private Function ImporteDocActual() As Decimal
        Dim result As Boolean = True
        Dim dblImporteRefactura As Decimal = 0
        Dim msg As String = ""
        For index As Integer = 0 To Me.dtgOperaciones.RowCount - 1
            dblImporteRefactura += Me.dtgOperaciones.Item("TOTAL", index).Value
        Next
        Return dblImporteRefactura
    End Function

    Private Sub CargarTipo()
        Dim dt As New DataTable
        dt.Columns.Add("VALUE")
        dt.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("VALUE") = 1
        dr("DISPLAY") = "Resumido"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("VALUE") = 2
        dr("DISPLAY") = "Detallado"
        dt.Rows.Add(dr)

        cbTipo.ComboBox.DataSource = dt
        cbTipo.ComboBox.DisplayMember = "DISPLAY"
        cbTipo.ComboBox.ValueMember = "VALUE"
        cbTipo.ComboBox.SelectedValue = "1"
    End Sub

    Private Sub CargarMotivo()
        oReFacBL = New NEGOCIO.Operaciones.ReFacturacion_BLL
        Dim dt As New DataTable
        Dim oFiltro As New Hashtable
        oFiltro.Add("PSCCMPN", CodCompañia)
        oFiltro.Add("PNCTPODC", Val(_TipoDocumentoEmision))

        dt = oReFacBL.Lista_Motivos_Notas(oFiltro)
        cmbMotivo.DataSource = dt
        cmbMotivo.DisplayMember = "TDSDES"
        cmbMotivo.ValueMember = "CDMODN"

    End Sub

    Private Sub frmNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtOperacion.Columns.Add("NOPRCN")
            dtOperacion.Columns.Add("TSGNMN")
            dtOperacion.Columns.Add("CLI_OPE")
            dtOperacion.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dtOperacion.Columns.Add("CHK", Type.GetType("System.Boolean"))

            CargarTipo()
            CargarMotivo()

            txtTipoDoc.Text = abriaturaDocOrigen.ToString.Trim
            txtNroDoc.Text = NumDocOrigen.ToString.Trim
            txtFechaDoc.Text = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(FechaDocOrigen)
            txtImporteFactura.Text = Format(importeDocOrigen, "###########0.00")
            txt1.Text = abreviaturaMoneda
            txt2.Text = abreviaturaMoneda

            dtgServiciosOperacion.AutoGenerateColumns = False
            dtgOperaciones.AutoGenerateColumns = False

            Dim ofiltro As New Hashtable
            ofiltro.Add("PSCCMPN", CodCompañia)
            ofiltro.Add("PSCDVSN", CodDivision)
            ofiltro.Add("PNCTPODC", TipoDocOrigen)
            ofiltro.Add("PNNDCCTC", NumDocOrigen)
            ofiltro.Add("TIPMONE", TipoMoneda)

            _dtServiciosTodosOp = oReFacBL.Lista_Operacion_Servicio_Refactura(ofiltro)
            _dtServiciosTodosOp.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            _dtServiciosTodosOp.Columns.Add("IMPSOL", Type.GetType("System.Decimal"))
            _dtServiciosTodosOp.Columns.Add("IMPSOLFAC", Type.GetType("System.Decimal"))

            Dim Visitado As New Hashtable
            Dim row As DataRow
            For Each Item As DataRow In _dtServiciosTodosOp.Rows
                If Not Visitado.Contains(Item("NOPRCN")) Then
                    Visitado.Add(Item("NOPRCN"), Item("NOPRCN"))
                    row = dtOperacion.NewRow
                    row("NOPRCN") = Item("NOPRCN")
                    row("CLI_OPE") = Item("TCMPCL_OP")
                    dtOperacion.Rows.Add(row)
                End If
            Next

            If _TipoDocumentoEmision = clsComun.TipoDocumento.NotaCredito Or _TipoDocumentoEmision = clsComun.TipoDocumento.NotaCreditoE Then
                For FILA As Integer = 0 To dtOperacion.Rows.Count - 1
                    dtOperacion.Rows(FILA)("CHK") = True
                Next
            Else
                For FILA As Integer = 0 To dtOperacion.Rows.Count - 1
                    dtOperacion.Rows(FILA)("CHK") = False
                Next
                dtgOperaciones.Columns("chk").Visible = False
            End If
          

            RecalcularMonto()
            Select Case _TipoDocumentoEmision
                Case clsComun.TipoDocumento.NotaCreditoE
                    Me.Text = "NOTA CRÉDITO ELECTRONICO"
                Case clsComun.TipoDocumento.NotaDebitoE
                    Me.Text = "NOTA DÉBITO ELECTRONICO"
            End Select
            dtgOperaciones.DataSource = _dtOperacion

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RegistrarOperacionFacturaSinHistorial(ByVal dtOperacion As DataTable, ByVal _dtServiciosTodosOp As DataTable, ByVal CTPODC As Decimal, ByVal NDCCTC As Decimal, ByVal FDCCTC As Decimal)
        Try
            'COPIA DE OPERACIONES QUE NO CUENTAN CON SU HISTORIAL

            oReFacBL = New NEGOCIO.Operaciones.ReFacturacion_BLL

            Dim dt As DataTable
            If CTPODC <> 1 Then
                Exit Sub
            End If
            dt = oReFacBL.Verifica_Doc_Historial_Refactura(CTPODC, NDCCTC)
            If dt.Rows.Count > 0 AndAlso dt.Rows.Count = _dtServiciosTodosOp.Rows.Count Then
                Exit Sub
            End If
            Dim obeFacturaHistorialCab As Object
            Dim obeFacturaHistorialDet As Object
            Dim NCRRFC_CAB As Decimal = 0
            Dim CCLNT_CAB As Decimal = 0
            Dim NOPRCN_CAB As Decimal = 0
            Dim drServDet() As DataRow
            For Each ItemCabOp As DataRow In dtOperacion.Rows
                obeFacturaHistorialCab = New Object
                obeFacturaHistorialCab.PSCCMPN = ItemCabOp("CCMPN")
                obeFacturaHistorialCab.PNCCLNT = ItemCabOp("CCLNT")
                obeFacturaHistorialCab.PNNOPRCN = ItemCabOp("NOPRCN")
                obeFacturaHistorialCab.PNCTPODC = ItemCabOp("CTPODC")
                obeFacturaHistorialCab.PNNDCFCC = NDCCTC
                obeFacturaHistorialCab.PNFDCFCC = FDCCTC
                obeFacturaHistorialCab.PNCMNDA1 = ItemCabOp("CMNDA1")
                obeFacturaHistorialCab.PNIVLSRV = ItemCabOp("TOTAL")
                NOPRCN_CAB = ItemCabOp("NOPRCN")
                NCRRFC_CAB = oReFacBL.Grabar_Historial_Documento_Cabecera(obeFacturaHistorialCab)
                If NCRRFC_CAB > 0 Then
                    drServDet = _dtServiciosTodosOp.Select("NOPRCN='" & NOPRCN_CAB & "'")
                    For FILA As Int32 = 0 To drServDet.Length - 1
                        obeFacturaHistorialDet = New Object
                        obeFacturaHistorialDet.PSCCMPN = drServDet(FILA)("CCMPN")
                        obeFacturaHistorialDet.PNCCLNT = drServDet(FILA)("CCLNT")
                        obeFacturaHistorialDet.PNNOPRCN = drServDet(FILA)("NOPRCN")
                        obeFacturaHistorialDet.PNNCRRFC = NCRRFC_CAB
                        obeFacturaHistorialDet.PNNCRROP = drServDet(FILA)("NCRROP")
                        obeFacturaHistorialDet.PNNRTFSV = drServDet(FILA)("NRTFSV")
                        obeFacturaHistorialDet.PNQATNAN = drServDet(FILA)("QATNAN")
                        obeFacturaHistorialDet.PSCUNDMD = drServDet(FILA)("CUNDMD")
                        obeFacturaHistorialDet.PNIVLSRV = drServDet(FILA)("IVLSRV")
                        obeFacturaHistorialDet.PNNCRDCC = drServDet(FILA)("NCRDCC")
                        oReFacBL.Grabar_Historial_Documento_Detalle(obeFacturaHistorialDet)
                    Next
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RecalcularMonto()
        Dim QATNAN As Decimal = 0
        Dim IVLSRV As Decimal = 0
        For Fila As Int64 = 0 To _dtServiciosTodosOp.Rows.Count - 1
            QATNAN = _dtServiciosTodosOp.Rows(Fila)("QATNAN")
            IVLSRV = _dtServiciosTodosOp.Rows(Fila)("ISRVGU")
            _dtServiciosTodosOp.Rows(Fila)("TOTAL") = Math.Round(QATNAN * IVLSRV, 2)
            _dtServiciosTodosOp.Rows(Fila)("IMPSOL") = Math.Round(IVLSRV * _TipCambioActual, 2)
            _dtServiciosTodosOp.Rows(Fila)("IMPSOLFAC") = Math.Round(IVLSRV * _TipCambioDocOrigen, 2)
        Next

        Dim NOPRCN_ACTUAL As Decimal = 0
        Dim NDCFCC_ACTUAL As Decimal = 0
        Dim CTPODC_ACTUAL As Decimal = 0
        Dim MontoxOperacion As Decimal = 0

        Dim TOTAL_MONTO_REFACT As Decimal = 0
        For FILA As Integer = 0 To _dtOperacion.Rows.Count - 1
            NOPRCN_ACTUAL = _dtOperacion.Rows(FILA)("NOPRCN")
            MontoxOperacion = _dtServiciosTodosOp.Compute("SUM(TOTAL)", "NOPRCN='" & NOPRCN_ACTUAL & "'")
            dtOperacion.Rows(FILA)("TOTAL") = MontoxOperacion
            TOTAL_MONTO_REFACT = TOTAL_MONTO_REFACT + dtOperacion.Rows(FILA)("TOTAL")
        Next
        txtDocumento.Text = Format(TOTAL_MONTO_REFACT, "###########0.00")
    End Sub

    Private Function VerServiciosXOperacion(ByVal NOPRCN As Decimal) As DataTable
        Dim odtServicioxOperacion As New DataTable
        Dim drServ() As DataRow
        odtServicioxOperacion = _dtServiciosTodosOp.Copy
        odtServicioxOperacion.Rows.Clear()
        drServ = _dtServiciosTodosOp.Select("NOPRCN='" & NOPRCN & "'")
        For Fila As Int64 = 0 To drServ.Length - 1
            odtServicioxOperacion.ImportRow(drServ(Fila))
        Next
        Return odtServicioxOperacion
    End Function

    Private Sub dtgOperaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.SelectionChanged
        Try
            If dtgOperaciones.CurrentRow IsNot Nothing Then
                Dim NOPRCN As Decimal = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                dtgServiciosOperacion.DataSource = Nothing
                dtgServiciosOperacion.DataSource = VerServiciosXOperacion(NOPRCN)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ListaImporteFactura() As DataTable
        Dim objParametro As New Hashtable
        Dim dtImporteFact As New DataTable
        objParametro.Add("PSCCMPN", CodCompañia)
        objParametro.Add("PSCDVSN", CodDivision)
        objParametro.Add("PNNDCMFC", NumDocOrigen)
        oReFacBL = New NEGOCIO.Operaciones.ReFacturacion_BLL
        dtImporteFact = oReFacBL.Traer_Importe_Refactura_E(objParametro)

        Return dtImporteFact
    End Function

    Private Sub Generar()
        dtgOperaciones.EndEdit()
        If _dtOperacion.Rows.Count = 0 OrElse _dtServiciosTodosOp.Rows.Count = 0 Then
            MessageBox.Show("No existen servicios para generar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim msg As String = ""
        Dim TotalSaldoFactura As Decimal = 0
        Dim TotalRefactura As Decimal = 0
        Dim dtImporteFact As New DataTable

        dtImporteFact = ListaImporteFactura()
        If dtImporteFact.Rows.Count <= 0 Then
            MessageBox.Show("No se encontró el documento Origen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For indice As Integer = 0 To dtImporteFact.Rows.Count - 1
            TotalSaldoFactura += dtImporteFact.Rows(indice).Item("IMPORTE")
        Next
        TotalRefactura = 0
        For FILA As Integer = 0 To _dtOperacion.Rows.Count - 1
            TotalRefactura = TotalRefactura + _dtOperacion.Rows(FILA)("TOTAL")
        Next

        Select Case _TipoDocumentoEmision
            Case clsComun.TipoDocumento.NotaCreditoE
                If Math.Round(TotalRefactura, 2) > Math.Round(TotalSaldoFactura, 2) Then
                    msg = msg & "El importe " & Me.Text & " excede el saldo de la Factura."
                    msg = msg & Chr(13) & "Saldo Factura(" & NumDocOrigen.ToString.Trim & "):" & TotalSaldoFactura
                    msg = msg & Chr(13) & "Total " & Me.Text & ":" & TotalRefactura
                    msg = msg & Chr(13) & "Desea continuar ?"
                    If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
        End Select

        dtgOperaciones.EndEdit()
        ohashNumOpSelec = New Hashtable
        For Each Item As DataGridViewRow In dtgOperaciones.Rows
            If Item.Cells("chk").Value Then
                ohashNumOpSelec.Add(Item.Cells("NOPRCN").Value, Item.Cells("NOPRCN").Value)
            End If
        Next

        CodMotivo = Val(cmbMotivo.SelectedValue.ToString.Trim)
        Motivo = cmbMotivo.Text.Trim

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            dtgOperaciones.EndEdit()
            If dtgServiciosOperacion.CurrentRow IsNot Nothing Then
                Dim ofrmModifServicioRefac As New frmModifServicioRefacElectronico
                Dim obeServicio As New ENTIDADES.Servicio

                obeServicio.NOPRCN = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_COL").Value
                obeServicio.CCLNT = dtgServiciosOperacion.CurrentRow.Cells("CCLNT_COL").Value
                obeServicio.NCRRGU = dtgServiciosOperacion.CurrentRow.Cells("NCRRGU").Value
                obeServicio.TSGNMN = ("" & dtgServiciosOperacion.CurrentRow.Cells("TSGNMN_SRV").Value).ToString.Trim
                obeServicio.QATNAN = dtgServiciosOperacion.CurrentRow.Cells("QATNAN_SRV").Value
                obeServicio.CUNDMD = ("" & dtgServiciosOperacion.CurrentRow.Cells("CUNDMD").Value).ToString.Trim
                obeServicio.NGUITR = dtgServiciosOperacion.CurrentRow.Cells("NGUITR").Value
                obeServicio.ISRVGU = dtgServiciosOperacion.CurrentRow.Cells("IVLSRV").Value
                obeServicio.CSRVC = dtgServiciosOperacion.CurrentRow.Cells("CSRVC").Value
                obeServicio.DESCSRV = dtgServiciosOperacion.CurrentRow.Cells("DESTAR_SRV").Value
                obeServicio.CCMPN = CodCompañia
                obeServicio.CDVSN = CodDivision

                ofrmModifServicioRefac.pbeServicio = obeServicio
                If ofrmModifServicioRefac.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    obeServicio = ofrmModifServicioRefac.pbeServicio
                    For FILA As Integer = 0 To _dtServiciosTodosOp.Rows.Count - 1
                        If _dtServiciosTodosOp.Rows(FILA)("NOPRCN") = obeServicio.NOPRCN AndAlso _dtServiciosTodosOp.Rows(FILA)("NCRRGU") = obeServicio.NCRRGU AndAlso _dtServiciosTodosOp.Rows(FILA)("CSRVC") = obeServicio.CSRVC Then
                            _dtServiciosTodosOp.Rows(FILA)("QATNAN") = obeServicio.QATNAN
                            _dtServiciosTodosOp.Rows(FILA)("ISRVGU") = obeServicio.ISRVGU
                            Exit For
                        End If
                    Next
                    RecalcularMonto()
                    dtgOperaciones.DataSource = Nothing
                    dtgOperaciones.DataSource = _dtOperacion
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If dtgServiciosOperacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim retorno As Int32 = 0
            Dim NOPRCN As Decimal = 0
            Dim NCRRGU As Decimal = 0
            Dim CSRVC As Decimal = 0

            Dim msgElim As String = "Está seguro de eliminar el servicio"
            Dim EliminarOperacion As Boolean = False
            If dtgServiciosOperacion.Rows.Count = 1 Then
                msgElim = msgElim & Chr(13) & "Si elimina el servicio,El número de Operación será eliminado."
                EliminarOperacion = True
            End If

            If MessageBox.Show(msgElim, "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                NOPRCN = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_COL").Value
                NCRRGU = dtgServiciosOperacion.CurrentRow.Cells("NCRRGU").Value
                CSRVC = dtgServiciosOperacion.CurrentRow.Cells("CSRVC").Value
                For FILA As Integer = _dtServiciosTodosOp.Rows.Count - 1 To 0 Step -1
                    If _dtServiciosTodosOp.Rows(FILA)("NOPRCN") = NOPRCN AndAlso _dtServiciosTodosOp.Rows(FILA)("NCRRGU") = NCRRGU AndAlso _dtServiciosTodosOp.Rows(FILA)("CSRVC") = CSRVC Then
                        _dtServiciosTodosOp.Rows.RemoveAt(FILA)
                        Exit For
                    End If
                Next
                If EliminarOperacion = True Then
                    For FILA As Integer = _dtOperacion.Rows.Count - 1 To 0 Step -1
                        If _dtOperacion.Rows(FILA)("NOPRCN") = NOPRCN Then
                            _dtOperacion.Rows.RemoveAt(FILA)
                            Exit For
                        End If
                    Next
                End If
                RecalcularMonto()
                dtgOperaciones.DataSource = Nothing
                dtgOperaciones.DataSource = _dtOperacion
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            Dim tipo As String = cbTipo.ComboBox.SelectedValue
            Select Case tipo
                Case "1"
                    _pTipoVerDocumento = clsComun.VistaImpresion.Resumido
                Case "2"
                    _pTipoVerDocumento = clsComun.VistaImpresion.Detallado
            End Select
            Generar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            If dtgServiciosOperacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim retorno As Int32 = 0
            Dim NOPRCN As Decimal = 0
            Dim NCRRGU As Decimal = 0
            Dim CSRVC As Decimal = 0

            If MessageBox.Show("Está seguro de eliminar la Operación", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                NOPRCN = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_COL").Value
                For FILA As Integer = _dtServiciosTodosOp.Rows.Count - 1 To 0 Step -1
                    If _dtServiciosTodosOp.Rows(FILA)("NOPRCN") = NOPRCN Then
                        _dtServiciosTodosOp.Rows.RemoveAt(FILA)

                    End If
                Next

                For FILA As Integer = _dtOperacion.Rows.Count - 1 To 0 Step -1
                    If _dtOperacion.Rows(FILA)("NOPRCN") = NOPRCN Then
                        _dtOperacion.Rows.RemoveAt(FILA)
                        Exit For
                    End If
                Next

                RecalcularMonto()
                dtgServiciosOperacion.DataSource = Nothing
                dtgOperaciones.DataSource = Nothing
                dtgOperaciones.DataSource = _dtOperacion
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
