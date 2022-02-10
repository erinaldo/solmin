Public Class frmBultosConfirmaGral
#Region "Propiedades"
    ''' <summary>
    ''' Variable
    ''' </summary>
    ''' <remarks></remarks>
    Private bolBuscar As Boolean = False
    Private _oServicio As Servicio_BE
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable
    Private dgBULTO As New DataTable
    Private estatico As New Estaticos
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property
    Public ReadOnly Property valBULTO() As DataTable
        Get
            Return dgBULTO
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub frmBultosConfirma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '==========SEGUN EL TIPO DE DEPOSITO===========
        If _oServicio.STPODP = "7" Then
            Me.dtgMercaderia.Visible = False
            Me.dtgBultos.Visible = True
            dtgBultos.Dock = DockStyle.Fill
            Me.dtgBultos.AutoGenerateColumns = False
            cmbTerminoBusquedaDS.Visible = False
            Me.cmbTerminoBusquedaSAT.Visible = True
        ElseIf (_oServicio.STPODP = "1" OrElse _oServicio.STPODP = "5") Then
            Me.dtgBultos.Visible = False
            Me.dtgMercaderia.Visible = True
            dtgMercaderia.Dock = DockStyle.Fill
            dtgMercaderia.AutoGenerateColumns = False
            Me.dtgBultos.AutoGenerateColumns = True
            cmbTerminoBusquedaDS.Visible = True
            Me.cmbTerminoBusquedaSAT.Visible = False
        End If

        If _oServicio.TIPO = "M" Then btnCancelar.Visible = False
        cargarDatosServicio()
        cargarBultos()
    End Sub
    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        dtgBultos.EndEdit()
        dgBULTO = dtgBultos.DataSource
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub cargarBultos()
        If _oServicio.CCLNT = 0 Then Exit Sub
        Dim oSerV_BL As New clsServicio_BL
        dtgBultos.DataSource = Nothing
        dtgBultos.AutoGenerateColumns = False

        If Not _oServicio.BULTOS Is Nothing Then
            If _oServicio.BULTOS.Rows.Count > 0 Then
                dtgBultos.DataSource = _oServicio.BULTOS
            End If
        Else
            Select Case _oServicio.TIPO
                Case Comun.ESTADO_Modificado
                    dgBULTO = oSerV_BL.fdtListaDetalleServiciosFacturacionSA(_oServicio)
                    dtgBultos.DataSource = dgBULTO
            End Select
        End If
    End Sub
    Private Sub cargarDatosServicio()
        Try
            Dim odtTarifa As New DataTable
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(_oServicio.NRTFSV)
            If (odtTarifa.Rows.Count > 0) Then
                txtServicio.Text = _oServicio.NRTFSV & " - " & _oServicio.TARIFA_DESC
                txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
                txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
                txtValorServicio.Text = CDbl(odtTarifa.Rows(0)("IVLSRV").ToString.Trim)
                txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
                txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================
    '==========PROCESO DE BUSQUEDA===========
    '========================================
    ''' <summary>
    ''' Realiza la consulta cuando hace enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If oServicio.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "") And txtCodigo.Text <> "" Then
                If _oServicio.STPODP = "7" Then
                    BuscarBultos()
                Else
                    BuscarSolicituServicio()
                End If

            End If

        End If
    End Sub
    ''' <summary>
    ''' Busca Solicitud de servicio por Nr. guia Ingreso, Nr. Guia Salida o Nr. Guia Proveedor
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSolicituServicio()
        Dim oServicioAlmacen As New Servicio_BE
        With oServicioAlmacen
            .CCLNT = _oServicio.CCLNT
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = _oServicio.CPLNDV
            Select Case Mid(cmbTerminoBusquedaDS.Text, 1, 1)
                Case "P"
                    .NGUICL = txtCodigo.Text.ToUpper
                Case "I"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.INGRESO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 1
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 2
                    End If
            End Select
        End With
        BuscarOS(oServicioAlmacen)
    End Sub

    ''' <summary>
    ''' Busca Orden de servicio 
    ''' </summary>
    ''' <param name="oServicioAlmacen"></param>
    ''' <remarks></remarks>
    Private Sub BuscarOS(ByVal oServicioAlmacen As Servicio_BE)
        Dim oServicioBL As New clsServicio_BL
        Dim dtTemp As DataTable = oServicioBL.fdtListaSolicitudDeServicioSDS(oServicioAlmacen)
        If Me.dtgMercaderia.DataSource Is Nothing And Not dtTemp Is Nothing Then
            dtTemp.Columns.Add("CPRCN1")
            dtTemp.Columns.Add("NSRCN1")
            dtTemp.Columns.Add("NCRRDC", GetType(String))
            Me.dtgMercaderia.DataSource = dtTemp
        ElseIf (Not dtTemp Is Nothing) Then
            For Each oDr As DataRow In dtTemp.Rows
                If Not fblnBuscarSolicitudServicio(oDr) Then
                    Dim oDrMercaderia As DataRow
                    oDrMercaderia = Me.dtgMercaderia.DataSource.NewRow
                    For intColumna As Integer = 0 To dtTemp.Columns.Count - 1
                        oDrMercaderia.Item(intColumna) = oDr.Item(intColumna)
                    Next
                    Me.dtgMercaderia.DataSource.Rows.Add(oDrMercaderia)
                    dtgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgMercaderia.CurrentRow.Cells("CPRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    dtgMercaderia.CurrentRow.Cells("NSRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' Buscan  en o los bultos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarBultos()
        Dim oSerAlmacen As New Servicio_BE
        With oSerAlmacen
            .CCLNT = _oServicio.CCLNT
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = _oServicio.CPLNDV
            Select Case Mid(cmbTerminoBusquedaSAT.Text, 1, 1)
                Case "B"
                    .CREFFW = txtCodigo.Text.ToUpper
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.PALETA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROPLT = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROCTL = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NRGUSA = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.GUIA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRM = intTemp
                    End If
                Case "V"
                    .NGRPRV = txtCodigo.Text.ToUpper
            End Select
            CargarBultos(oSerAlmacen)
        End With

    End Sub

    Private Sub CargarBultos(ByVal oSerAlmacen As Servicio_BE)
        Dim oServicioBL As New clsServicio_BL
        Dim dtTemp As DataTable = oServicioBL.fdtListaBultoFacturarSA(oSerAlmacen)
        If Not oSerAlmacen.PSERROR.Trim.Equals("") Then
            MsgBox(oSerAlmacen.PSERROR, MsgBoxStyle.Information, "Información")
        End If
        Dim dtWayBill As DataTable
        Dim oDrVw As DataGridViewRow
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            dtWayBill = dtTemp.Clone
            For Each dwFila In dtTemp.Rows
                If Not fblnBuscarBulto(dwFila.Item("CREFFW").ToString.Trim) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgBultos)
                    Me.dtgBultos.Rows.Add(oDrVw)
                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    With Me.dtgBultos
                        Dim pos As Integer = dtgBultos.Rows.Count - 1
                        .Rows(pos).Cells("CREFFW").Value = dwFila.Item("CREFFW").ToString.Trim
                        .Rows(pos).Cells("NCRRDC").Value = DBNull.Value
                        .Rows(pos).Cells("DESCWB").Value = dwFila.Item("DESCWB").ToString.Trim
                        .Rows(pos).Cells("TUBRFR").Value = dwFila.Item("TUBRFR").ToString.Trim
                        .Rows(pos).Cells("QREFFW").Value = dwFila.Item("QREFFW")
                        .Rows(pos).Cells("TIPBTO").Value = dwFila.Item("TIPBTO").ToString.Trim
                        .Rows(pos).Cells("QPSOBL").Value = dwFila.Item("QPSOBL")
                        .Rows(pos).Cells("TUNPSO").Value = dwFila.Item("TUNPSO").ToString.Trim
                        .Rows(pos).Cells("QVLBTO").Value = dwFila.Item("QVLBTO")
                        .Rows(pos).Cells("TUNVOL").Value = dwFila.Item("TUNVOL").ToString.Trim
                        .Rows(pos).Cells("QAROCP").Value = dwFila.Item("QAROCP")
                        .Rows(pos).Cells("SESTRG").Value = dwFila.Item("SESTRG").ToString.Trim
                        .Rows(pos).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(pos).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(pos).Cells("CTPALM").Value = dwFila.Item("CTPALM").ToString.Trim
                        .Rows(pos).Cells("CALMC").Value = dwFila.Item("CALMC").ToString.Trim
                        .Rows(pos).Cells("CZNALM").Value = dwFila.Item("CZNALM").ToString.Trim
                    End With
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Busca si el bulto ya esta asignado a la operación 
    ''' </summary>
    ''' <param name="strCodigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarBulto(ByVal strCodigo As String) As Boolean
        Dim intIndice As Integer
        For intIndice = 0 To dtgBultos.RowCount - 1
            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim Then
                Return True
            End If
        Next
        Return False
    End Function


    ''' <summary>
    ''' Busca si la solicitud de servicio ya esta asignada a la operación
    ''' </summary>
    ''' <param name="oDr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarSolicitudServicio(ByVal oDr As DataRow) As Boolean
        For Each oDrMercaderia As DataRow In Me.dtgMercaderia.DataSource.Rows
            If oDrMercaderia.Item("NORDSR") = oDr.Item("NORDSR") And oDrMercaderia.Item("NSLCSR") = oDr.Item("NSLCSR") Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub cargarBultosServicio()

    End Sub
    Private Sub CargarSolicitudServicio()

    End Sub
    ''' <summary>
    ''' Elimna el detalle de la operacion 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EliminarDetalleOperacion()
        If _oServicio.STPODP = "7" Then
            Dim oServicioBL As New clsServicio_BL
            If Me.dtgBultos.RowCount <= 0 Then
                MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Val("" & Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value & "") = 0 Then
                dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                Exit Sub
            End If
            If MessageBox.Show("Está seguro de eliminar el bulto seleccionado?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim oServicioDel As New Servicio_BE
                oServicioDel.NOPRCN = _oServicio.NOPRCN
                oServicioDel.CCLNT = _oServicio.CCLNT
                oServicioDel.NCRRDC = Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value
                oServicioDel.STPODP = _oServicio.STPODP
                If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                Else
                    dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                End If
            End If

        Else
            Dim oServicioBL As New clsServicio_BL
            If Me.dtgMercaderia.RowCount <= 0 Then
                MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Information, "Validación")
                Exit Sub
            End If
            If Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC").ToString.Trim.Equals("") Then
                CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                Exit Sub
            End If
            If MessageBox.Show("Está seguro de eliminar el registro seleccionado ?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim oServicioDel As New Servicio_BE
                oServicioDel.NOPRCN = _oServicio.NOPRCN
                oServicioDel.CCLNT = _oServicio.CCLNT
                oServicioDel.NCRRDC = dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC")
                oServicioDel.STPODP = _oServicio.STPODP
                If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                Else
                    CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                End If
            End If

        End If

    End Sub
    Private Sub btnAgregarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTermino.Click
        If _oServicio.CCLNT = 0 Then Exit Sub
        If (Me.cmbTerminoBusquedaSAT.Text <> "" Or cmbTerminoBusquedaDS.Text <> "") And txtCodigo.Text <> "" Then
            If _oServicio.STPODP = "7" Then
                BuscarBultos()
            Else
                BuscarSolicituServicio()
            End If
        End If
    End Sub

    Private Sub BtnEliminarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTermino.Click
        EliminarDetalleOperacion()
    End Sub
#End Region
End Class
