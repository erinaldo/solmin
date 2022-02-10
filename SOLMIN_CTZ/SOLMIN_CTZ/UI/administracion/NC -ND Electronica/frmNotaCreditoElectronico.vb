Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports System.Text
Public Class frmNotaCreditoElectronico
    Private _pTipoVerDocumento As clsComun.FormaVerDocumento

    Public ReadOnly Property pTipoVerDocumento() As clsComun.FormaVerDocumento
        Get
            Return _pTipoVerDocumento
        End Get
    End Property

    Private _TipoNota As Decimal = 0
    Public Property TipoNota() As Decimal
        Get
            Return _TipoNota
        End Get
        Set(ByVal value As Decimal)
            _TipoNota = value
        End Set
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
    'Private _pLIST_NOPRCN As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
    Private _opeServOpe As ServicioOperacion
    Private _pTotalSaldoFactura As Decimal = 0
    Public Property pTotalSaldoFactura() As Decimal
        Get
            Return _pTotalSaldoFactura
        End Get
        Set(ByVal value As Decimal)
            _pTotalSaldoFactura = value
        End Set
    End Property
    Private _TipoDocumento As clsComun.TipoDocumento = clsComun.TipoDocumento.Neutro
    Public Property TipoDocumento() As clsComun.TipoDocumento
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As clsComun.TipoDocumento)
            _TipoDocumento = value
        End Set
    End Property
    'Public Property pLIST_NOPRCN() As List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
    '    Get
    '        Return _pLIST_NOPRCN
    '    End Get
    '    Set(ByVal value As List(Of Ransa.Controls.ServicioOperacion.Servicio_BE))
    '        _pLIST_NOPRCN = value
    '    End Set
    'End Property
    'JM
    'Private _Codigo_Compañia As String = ""
    'Public Property Codigo_Compañia() As String
    '    Get
    '        Return _Codigo_Compañia
    '    End Get
    '    Set(ByVal value As String)
    '        _Codigo_Compañia = value
    '    End Set
    'End Property
    Public Codigo_Compania As String = ""
    'Public CodigoDiv As String = ""

    Public origenTipoDoc As Decimal = 0
    Public origenNumDoc As Decimal = 0
    Public origenFechaDoc As Decimal = 0


    Public pLIST_NOPRCN As New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
    Private Function ImporteDocActual() As Decimal
        Dim result As Boolean = True
        Dim dblImporteRefactura As Decimal = 0
        Dim msg As String = ""
        For index As Integer = 0 To Me.dtgOperaciones.RowCount - 1
            dblImporteRefactura += Me.dtgOperaciones.Item("MONTO", index).Value
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

    Private Sub frmNotaCreditoElectronico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarTipo()

            Dim dtImporteFac As New DataTable
            dtImporteFac = ListaImporteFactura()
            Dim dr() As DataRow

 

            'dr = dtImporteFac.Select("NDCCTC='" & _pLIST_NOPRCN(0).NDCCTC & "' AND CTPODC=1 " & " OR NDCCTC='" & _pLIST_NOPRCN(0).NDCCTC & "' AND CTPODC=51 ")
            dr = dtImporteFac.Select("NDCCTC='" & origenNumDoc & "' AND CTPODC=1 " & " OR NDCCTC='" & origenNumDoc & "' AND CTPODC=51 ")

            If dr.Length > 0 Then

                txtImporteFactura.Text = Format(dr(0)("IMPORTE"), "###########0.00")
            End If
            'txtTipoDoc.Text = _pLIST_NOPRCN(0).TABTPD
            'txtNroDoc.Text = _pLIST_NOPRCN(0).NDCCTC
            txtNroDoc.Text = origenNumDoc
            'txtFechaDoc.Text = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(_pLIST_NOPRCN(0).FDCCTC)
            txtFechaDoc.Text = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(origenFechaDoc)
            '

            dtgServiciosOperacion.AutoGenerateColumns = False
            dtgOperaciones.AutoGenerateColumns = False
            Dim ods As New DataSet
            Dim oServicioOpeNeg As New clsServicioOperacion
            'Dim oLisServicio As New List(Of ServicioOperacion)
            'Dim oServicio As ServicioOperacion
            'For Each Item As Ransa.Controls.ServicioOperacion.Servicio_BE In _pLIST_NOPRCN
            '    oServicio = New ServicioOperacion
            '    oServicio.CCMPN = Item.CCMPN
            '    oServicio.CDVSN = Item.CDVSN
            '    oServicio.CCLNT = Item.CCLNT
            '    oServicio.NOPRCN = Item.NOPRCN
            '    oServicio.CTPODC = Item.CTPODC
            '    oServicio.NDCFCC = Item.NDCCTC
            '    oLisServicio.Add(oServicio)
            'Next



            Dim oServConsulta As New ServicioOperacion
            oServConsulta.CCMPN = Codigo_Compania
            'oServConsulta.CDVSN = CodigoDiv
            'oServConsulta.CCLNT = 0
            oServConsulta.CTPODC = origenTipoDoc
            oServConsulta.NDCFCC = origenNumDoc
            dtOperacion = oServicioOpeNeg.Lista_Operacion_Refactura(oServConsulta)
            'dtOperacion = oServicioOpeNeg.Lista_Operacion_Refactura(oLisServicio)
            dtOperacion.Columns.Add("CHK", Type.GetType("System.Boolean"))
            For FILA As Integer = 0 To dtOperacion.Rows.Count - 1
                dtOperacion.Rows(FILA)("CHK") = False
            Next



            'lobjParams.Add("PSCCMPN", oServicio.CCMPN)



            'lobjParams.Add("PNCTPODC", oServicio.CTPODC)
            'lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
            'lobjParams.Add("PNFECFAC", Now.ToString("yyyyMMdd"))

            oServConsulta = New ServicioOperacion
            oServConsulta.CCMPN = Codigo_Compania
            oServConsulta.CTPODC = origenTipoDoc
            oServConsulta.NDCFCC = origenNumDoc
            _dtServiciosTodosOp = oServicioOpeNeg.Lista_Operacion_Servicio_Refactura_FE(oServConsulta) 'JM
            _dtServiciosTodosOp.Columns.Add("MONTO", Type.GetType("System.Decimal"))

            RecalcularMonto()
            'RegistrarOperacionFacturaSinHistorial(dtOperacion.Copy, _dtServiciosTodosOp.Copy, _pLIST_NOPRCN(0).CTPODC, pLIST_NOPRCN(0).NDCCTC, _pLIST_NOPRCN(0).FDCCTC)
            Select Case _TipoDocumento
                Case clsComun.TipoDocumento.NotaCreditoElectronico
                    Me.Text = "NOTA CRÉDITO ELECTRONICO"
                Case clsComun.TipoDocumento.NotaDebitoElectronico
                    Me.Text = "NOTA DÉBITO ELECTRONICO"
            End Select
            dtgOperaciones.DataSource = _dtOperacion
            'Cargar Tipo de Nota 
            LLenarComboTipoNota()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RegistrarOperacionFacturaSinHistorial(ByVal dtOperacion As DataTable, ByVal _dtServiciosTodosOp As DataTable, ByVal CTPODC As Decimal, ByVal NDCCTC As Decimal, ByVal FDCCTC As Decimal)
        Try
            'COPIA DE OPERACIONES QUE NO CUENTAN CON SU HISTORIAL
            Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
            Dim clsDalServicioOperacion As New clsServicioOperacion

            Dim dt As DataTable
            If CTPODC <> 1 Then
                Exit Sub
            End If
            dt = clsDalServicioOperacion.Verifica_Doc_Historial_Refactura(CTPODC, NDCCTC)
            If dt.Rows.Count > 0 AndAlso dt.Rows.Count = _dtServiciosTodosOp.Rows.Count Then
                Exit Sub
            End If
            Dim obeFacturaHistorialCab As FacturaHistorialCab
            Dim obeFacturaHistorialDet As FacturaHistorialDet
            Dim NCRRFC_CAB As Decimal = 0
            Dim CCLNT_CAB As Decimal = 0
            Dim NOPRCN_CAB As Decimal = 0
            Dim drServDet() As DataRow
            For Each ItemCabOp As DataRow In dtOperacion.Rows
                obeFacturaHistorialCab = New FacturaHistorialCab
                obeFacturaHistorialCab.PSCCMPN = ItemCabOp("CCMPN")
                obeFacturaHistorialCab.PNCCLNT = ItemCabOp("CCLNT")
                obeFacturaHistorialCab.PNNOPRCN = ItemCabOp("NOPRCN")
                obeFacturaHistorialCab.PNCTPODC = ItemCabOp("CTPODC")
                obeFacturaHistorialCab.PNNDCFCC = NDCCTC
                obeFacturaHistorialCab.PNFDCFCC = FDCCTC
                obeFacturaHistorialCab.PNCMNDA1 = ItemCabOp("CMNDA1")
                obeFacturaHistorialCab.PNIVLSRV = ItemCabOp("MONTO")
                NOPRCN_CAB = ItemCabOp("NOPRCN")
                NCRRFC_CAB = oFacturaNeg.Grabar_Historial_Documento_Cabecera(obeFacturaHistorialCab)
                If NCRRFC_CAB > 0 Then
                    drServDet = _dtServiciosTodosOp.Select("NOPRCN='" & NOPRCN_CAB & "'")
                    For FILA As Int32 = 0 To drServDet.Length - 1
                        obeFacturaHistorialDet = New FacturaHistorialDet
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
                        oFacturaNeg.Grabar_Historial_Documento_Detalle(obeFacturaHistorialDet)



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
            IVLSRV = _dtServiciosTodosOp.Rows(Fila)("IVLSRV")
            _dtServiciosTodosOp.Rows(Fila)("MONTO") = Math.Round(QATNAN * IVLSRV, 3) 'Math.Round(QATNAN * IVLSRV, 2)
        Next

        Dim NOPRCN_ACTUAL As Decimal = 0
        Dim NDCFCC_ACTUAL As Decimal = 0
        Dim CTPODC_ACTUAL As Decimal = 0
        Dim MontoxOperacion As Decimal = 0

        Dim TOTAL_MONTO_REFACT As Decimal = 0
        For FILA As Integer = 0 To _dtOperacion.Rows.Count - 1
            NOPRCN_ACTUAL = _dtOperacion.Rows(FILA)("NOPRCN")
            NDCFCC_ACTUAL = _dtOperacion.Rows(FILA)("NDCFCC")
            CTPODC_ACTUAL = _dtOperacion.Rows(FILA)("CTPODC")
            MontoxOperacion = _dtServiciosTodosOp.Compute("SUM(MONTO)", "NOPRCN='" & NOPRCN_ACTUAL & "' AND CTPODC='" & CTPODC_ACTUAL & "' AND NDCFCC='" & NDCFCC_ACTUAL & "'")
            dtOperacion.Rows(FILA)("MONTO") = MontoxOperacion
            TOTAL_MONTO_REFACT = TOTAL_MONTO_REFACT + dtOperacion.Rows(FILA)("MONTO")
        Next
        'txtDocumento.Text = Format(TOTAL_MONTO_REFACT, "###########0.00000")
        txtDocumento.Text = Format(TOTAL_MONTO_REFACT, "###########0.00")
    End Sub

    Private Function VerServiciosXOperacion(ByVal NOPRCN As Decimal, ByVal CTPODC As Decimal, ByVal NDCFCC As Decimal) As DataTable
        Dim odtServicioxOperacion As New DataTable
        Dim drServ() As DataRow
        odtServicioxOperacion = _dtServiciosTodosOp.Copy
        odtServicioxOperacion.Rows.Clear()
        drServ = _dtServiciosTodosOp.Select("NOPRCN='" & NOPRCN & "' AND NDCFCC='" & NDCFCC & "' AND CTPODC='" & CTPODC & "'")
        For Fila As Int64 = 0 To drServ.Length - 1
            odtServicioxOperacion.ImportRow(drServ(Fila))
        Next
        Return odtServicioxOperacion
    End Function

    Private Sub dtgOperaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.SelectionChanged
        Try
            If dtgOperaciones.CurrentRow IsNot Nothing Then
                Dim NOPRCN As Decimal = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                Dim NDCFCC As Decimal = dtgOperaciones.CurrentRow.Cells("NDCFCC").Value
                Dim CTPODC As Decimal = dtgOperaciones.CurrentRow.Cells("CTPODC").Value
                dtgServiciosOperacion.DataSource = Nothing
                dtgServiciosOperacion.DataSource = VerServiciosXOperacion(NOPRCN, CTPODC, NDCFCC)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ListaImporteFactura() As DataTable
        Dim objParametro As New Hashtable
        Dim dtImporteFact As New DataTable
        'objParametro.Add("PSCCMPN", _pLIST_NOPRCN(0).CCMPN)
        'objParametro.Add("PSCDVSN", _pLIST_NOPRCN(0).CDVSN)
        objParametro.Add("PSCCMPN", Codigo_Compania)
        'objParametro.Add("PSCDVSN", CodigoDiv)
        'objParametro.Add("PNNDCMFC", _pLIST_NOPRCN(0).NDCCTC)
        objParametro.Add("PNNDCMFC", origenNumDoc)
        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
        dtImporteFact = oFactura.Traer_Importe_Refactura(objParametro)
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
            TotalRefactura = TotalRefactura + _dtOperacion.Rows(FILA)("MONTO")
        Next
        'JM Agrege Electronico
        Select Case _TipoDocumento
            Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaCreditoElectronico
                If Math.Round(TotalRefactura, 2) > Math.Round(TotalSaldoFactura, 2) Then
                    msg = msg & "El importe " & Me.Text & " excede el saldo de la Factura."
                    'msg = msg & Chr(13) & "Saldo Factura(" & _pLIST_NOPRCN(0).NDCCTC & "):" & TotalSaldoFactura
                    msg = msg & Chr(13) & "Saldo Factura(" & origenNumDoc & "):" & TotalSaldoFactura
                    msg = msg & Chr(13) & "Total " & Me.Text & ":" & TotalRefactura
                    msg = msg & Chr(13) & "Desea continuar ?"
                    If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
        End Select


        pLIST_NOPRCN = New List(Of Ransa.Controls.ServicioOperacion.Servicio_BE)
        dtgOperaciones.EndEdit()
        Dim obeSerOp As Ransa.Controls.ServicioOperacion.Servicio_BE
        For Each Item As DataGridViewRow In dtgOperaciones.Rows
            obeSerOp = New Ransa.Controls.ServicioOperacion.Servicio_BE
            obeSerOp.NOPRCN = Item.Cells("NOPRCN").Value
            'obeSerOp.NSECFC = Item.Cells("NSECFC").Value
            obeSerOp.TCMPDV = ("" & Item.Cells("TCMPDV").Value).ToString.Trim
            obeSerOp.CDVSN = ("" & Item.Cells("CDVSN").Value).ToString.Trim
            obeSerOp.CCMPN = ("" & Item.Cells("CCMPN").Value).ToString.Trim
            obeSerOp.CCLNT = Item.Cells("CCLNT").Value
            obeSerOp.CCLNFC = Item.Cells("CCLNFC").Value
            obeSerOp.CPLNDV = Item.Cells("CPLNDV").Value
            obeSerOp.CMNDA1 = Item.Cells("CMNDA1").Value
            obeSerOp.TSGNMN = ("" & Item.Cells("TSGNMN").Value).ToString.Trim
            obeSerOp.CRGVTA = ("" & Item.Cells("CRGVTA").Value).ToString.Trim
            obeSerOp.ITCCTC = Item.Cells("ITCCTC").Value
            obeSerOp.CTPODC = Item.Cells("CTPODC").Value
            obeSerOp.NDCCTC = Item.Cells("NDCFCC").Value
            obeSerOp.FDCCTC = CType(Item.Cells("FDCCTC").Value, Date).ToString("yyyyMMdd")
            If Item.Cells("chk").Value = True Then
                obeSerOp.LIBERAR = "S"
            Else
                obeSerOp.LIBERAR = "N"
            End If
            pLIST_NOPRCN.Add(obeSerOp)
        Next
        TipoNota = cboTipoNota.SelectedValue
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
                Dim ofrmModifServicioRefac As New frmModifServicioRefac
                Dim obeServicio As New ServicioOperacion
                Dim oServicioOpeNeg As New clsServicioOperacion
                obeServicio.NOPRCN = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_COL").Value
                obeServicio.CCLNT = dtgServiciosOperacion.CurrentRow.Cells("CCLNT_COL").Value
                obeServicio.NCRROP = dtgServiciosOperacion.CurrentRow.Cells("NCRROP").Value
                obeServicio.TSGNMN = ("" & dtgServiciosOperacion.CurrentRow.Cells("TSGNMN_SRV").Value).ToString.Trim
                obeServicio.QATNAN = dtgServiciosOperacion.CurrentRow.Cells("QATNAN_SRV").Value
                obeServicio.CUNDMD = ("" & dtgServiciosOperacion.CurrentRow.Cells("CUNDMD").Value).ToString.Trim
                obeServicio.IVLSRV = dtgServiciosOperacion.CurrentRow.Cells("IVLSRV").Value
                obeServicio.CCMPN = dtgOperaciones.CurrentRow.Cells("CCMPN").Value
                obeServicio.CDVSN = dtgOperaciones.CurrentRow.Cells("CDVSN").Value
                obeServicio.CPLNDV = dtgOperaciones.CurrentRow.Cells("CPLNDV").Value
                obeServicio.NRRUBR = dtgServiciosOperacion.CurrentRow.Cells("NRRUBR").Value
                obeServicio.NRTFSV = dtgServiciosOperacion.CurrentRow.Cells("NRTFSV").Value
                obeServicio.DESTAR = dtgServiciosOperacion.CurrentRow.Cells("DESTAR_SRV").Value
                'obeServicio.FATNSR = dtgServiciosOperacion.CurrentRow.Cells("FATNSR").Value
                'obeServicio.FATNSR = Now.ToString("yyyyMMdd")
                ofrmModifServicioRefac.pbeServicio = obeServicio
                If ofrmModifServicioRefac.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    obeServicio = ofrmModifServicioRefac.pbeServicio
                    For FILA As Integer = 0 To _dtServiciosTodosOp.Rows.Count - 1
                        If _dtServiciosTodosOp.Rows(FILA)("NOPRCN") = obeServicio.NOPRCN AndAlso _dtServiciosTodosOp.Rows(FILA)("NCRROP") = obeServicio.NCRROP Then
                            _dtServiciosTodosOp.Rows(FILA)("QATNAN") = obeServicio.QATNAN
                            _dtServiciosTodosOp.Rows(FILA)("IVLSRV") = obeServicio.IVLSRV
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
            Dim oServicioOpeNeg As New clsServicioOperacion
            Dim retorno As Int32 = 0
            Dim oServicio As New ServicioOperacion
            Dim msgElim As String = "Está seguro de eliminar el servicio"
            Dim EliminarOperacion As Boolean = False
            If dtgServiciosOperacion.Rows.Count = 1 Then
                msgElim = msgElim & Chr(13) & "Si elimina el servicio,El número de Operación será eliminado."
                EliminarOperacion = True
            End If

            If MessageBox.Show(msgElim, "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                oServicio.CCLNT = dtgServiciosOperacion.CurrentRow.Cells("CCLNT_COL").Value
                oServicio.NOPRCN = dtgServiciosOperacion.CurrentRow.Cells("NOPRCN_COL").Value
                oServicio.NCRROP = dtgServiciosOperacion.CurrentRow.Cells("NCRROP").Value
                For FILA As Integer = _dtServiciosTodosOp.Rows.Count - 1 To 0 Step -1
                    If _dtServiciosTodosOp.Rows(FILA)("NOPRCN") = oServicio.NOPRCN AndAlso _dtServiciosTodosOp.Rows(FILA)("NCRROP") = oServicio.NCRROP Then
                        _dtServiciosTodosOp.Rows.RemoveAt(FILA)
                        Exit For
                    End If
                Next
                If EliminarOperacion = True Then
                    For FILA As Integer = _dtOperacion.Rows.Count - 1 To 0 Step -1
                        If _dtOperacion.Rows(FILA)("NOPRCN") = oServicio.NOPRCN Then
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
                    _pTipoVerDocumento = clsComun.FormaVerDocumento.Resumido
                Case "2"
                    _pTipoVerDocumento = clsComun.FormaVerDocumento.Detallado
            End Select
            Generar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LLenarComboTipoNota()
        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim TipoDoc As Integer = _TipoDocumento
        cboTipoNota.DataSource = oFactura.Lista_Tipo_Nota_Electronico(Codigo_Compania, TipoDoc)
        cboTipoNota.DisplayMember = "TDSDES"
        cboTipoNota.ValueMember = "CDMODN"
    End Sub



End Class
