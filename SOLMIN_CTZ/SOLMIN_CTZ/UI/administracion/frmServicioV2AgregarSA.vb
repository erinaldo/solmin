Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Ransa.Controls.Cliente
Public Class frmServicioV2AgregarSA
    Private dblFecha As Double
    Private oPlantaNeg As SOLMIN_CTZ.NEGOCIO.clsPlanta
    Private oServicioSIL As ServicioSIL
    Private oServicioAlmacen As ServicioAlmacen
    Private oServicioSILNeg As clsServicioSILNeg
    Private bolBuscar As Boolean
    Private dtResultado As New DataTable
    Private blnCargando As Boolean
    Private intFilaActual As Int32 = 0

    Public Sub New(ByVal poServicioAlmacen As ServicioAlmacen)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oServicioSILNeg = New clsServicioSILNeg
        oServicioSIL = New ServicioSIL
        oServicioAlmacen = New ServicioAlmacen
        oServicioAlmacen = poServicioAlmacen
        oServicioSIL.CCMPN = oServicioAlmacen.CCMPN
        oServicioSIL.CDVSN = oServicioAlmacen.CDVSN
        oServicioSIL.CCLNT = oServicioAlmacen.CCLNT
        oServicioSIL.NOPRCN = oServicioAlmacen.NOPRCN
    End Sub
    Private Sub frmServicioV2AgregarSA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oPlantaNeg = New clsPlanta
        oPlantaNeg.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        cargarPlanta()
        cargarServicio()
        cargaProceso()
        cargarCliente()
        cargarCampos()
        dtgBultos.Dock = DockStyle.Fill
        dtgMercaderia.Visible = False
    End Sub
    Private Sub ToolStrip2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStrip2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#Region "Carga Inicial"
    Private Sub cargarCampos()
        If oServicioAlmacen.TIPO <> "M" Then Exit Sub
        dteFechaOperacion.Enabled = False
        txtNroOperacion.Text = oServicioAlmacen.NOPRCN
        dteFechaOperacion.Text = HelpClass.FormatoFecha(oServicioAlmacen.FOPRCN)
        dtpFechaInicial.Text = HelpClass.FormatoFecha(oServicioAlmacen.FECINI)
        dtpFechaFinal.Text = HelpClass.FormatoFecha(oServicioAlmacen.FECFIN)
        txtCodigoContenedor.Text = oServicioAlmacen.CPRCN1
        txtSerieContenedor.Text = oServicioAlmacen.NSRCN1
        cargarTarifaServicio()
    End Sub
    Private Sub cargarTarifaServicio()
        Dim oDt As New DataTable
        Dim oDr As DataGridViewRow
        oDt = oServicioSILNeg.Lista_Servicio_Almacen_Modificar(oServicioSIL)
        For i As Integer = 0 To oDt.Rows.Count - 1
            oDr = New DataGridViewRow
            oDr.CreateCells(Me.dtgServicio)
            oDr.Cells(0).Value = oDt.Rows(i).Item("NRTFSV")
            oDr.Cells(1).Value = oDt.Rows(i).Item("NOMSER")
            oDr.Cells(2).Value = oDt.Rows(i).Item("QCNESP")
            oDr.Cells(3).Value = oDt.Rows(i).Item("TUNDIT")
            oDr.Cells(4).Value = oDt.Rows(i).Item("QATNAN")
            dtgServicio.Rows.Add(oDr)
            dtgServicio.Rows(i).Tag = "R"
        Next
        cargarBultosServicio()
    End Sub
    Private Sub cargarBultosServicio()
        Dim oDt As New DataTable
        Dim oDrVw As DataGridViewRow
        oServicioAlmacen.CPLNDV = cmbPlanta.SelectedValue
        oDt = oServicioSILNeg.Lista_Bultos_Servicio_Almacen_Modificar(oServicioSIL)
        For i As Integer = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgBultos)
            Me.dtgBultos.Rows.Add(oDrVw)
            With Me.dtgBultos
                dtgBultos.CurrentRow.ToString()
                Dim pos As Integer = i
                .Rows(pos).Cells("CREFFW").Value = oDt.Rows(i).Item("CREFFW").ToString.Trim
                .Rows(pos).Cells("DESCWB").Value = oDt.Rows(i).Item("DESCWB").ToString.Trim
                .Rows(pos).Cells("TUBRFR").Value = oDt.Rows(i).Item("TUBRFR").ToString.Trim
                .Rows(pos).Cells("QREFFW").Value = oDt.Rows(i).Item("QREFFW")
                .Rows(pos).Cells("TIPBTO").Value = oDt.Rows(i).Item("TIPBTO").ToString.Trim
                .Rows(pos).Cells("QPSOBL").Value = oDt.Rows(i).Item("QPSOBL")
                .Rows(pos).Cells("TUNPSO").Value = oDt.Rows(i).Item("TUNPSO").ToString.Trim
                .Rows(pos).Cells("QVLBTO").Value = oDt.Rows(i).Item("QVLBTO")
                .Rows(pos).Cells("TUNVOL").Value = oDt.Rows(i).Item("TUNVOL").ToString.Trim
                .Rows(pos).Cells("QAROCP").Value = oDt.Rows(i).Item("QAROCP")
                .Rows(pos).Cells("SESTRG").Value = oDt.Rows(i).Item("SESTRG").ToString.Trim
                dtgBultos.Rows(i).Tag = "R"
            End With
        Next
    End Sub
    Private Sub cargarCliente()
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(oServicioAlmacen.CCLNT, ConfigurationWizard.UserName)
        txtClienteFacturar.pCargar(ClientePK)
    End Sub
    Private Sub cargarPlanta()
        bolBuscar = False
        cmbPlanta.DataSource = oPlantaNeg.Lista_Planta(oServicioAlmacen.CCMPN, oServicioAlmacen.CDVSN)
        cmbPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        If cmbPlanta.FindString("1") = 0 Then
            cmbPlanta.SelectedValue = 1
        End If
        cmbPlanta.DisplayMember = "TPLNTA"
    End Sub
    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            cargarServicio()
        End If
    End Sub
    Private Sub cargarServicio()
        oServicioSIL.CPLNDV = cmbPlanta.SelectedValue
        oServicioSIL.FECSER = Format(dteFechaOperacion.Value, "yyyyMMdd")
        dtResultado = oServicioSILNeg.Cargar_Servicios_Tarifa_Cliente(oServicioSIL)
        cmbServicio.ComboBox.DataSource = dtResultado
        cmbServicio.ComboBox.ValueMember = "NRTFSV"
        cmbServicio.ComboBox.DisplayMember = "DESTAR"
    End Sub
    Private Sub cargaProceso()
        cmbProceso.ComboBox.DataSource = oServicioSILNeg.Listar_TablaAyuda_L01("TIPROC")
        cmbProceso.ComboBox.ValueMember = "CCMPRN"
        cmbProceso.ComboBox.DisplayMember = "TDSDES"
        If oServicioAlmacen.STIPPR <> "" Then
            cmbProceso.ComboBox.SelectedValue = oServicioAlmacen.STIPPR
        End If
    End Sub
#End Region

#Region "Agregar Servicio"
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If oServicioAlmacen.CCLNT = 0 Then Exit Sub
        If cmbServicio.Text <> "" And txtCantidad.Text <> "" Then registrarServicio()
    End Sub
    Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If oServicioAlmacen.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cmbServicio.Text <> "" And txtCantidad.Text <> "" Then registrarServicio()
        End If
    End Sub
    Private Sub registrarServicio()
        Dim oTemp As ServicioAlmacen = New ServicioAlmacen
        Dim intNroOperacion As Int64 = 0
        Dim oDrVw As DataGridViewRow
        ' Validamos que sea un servicio disponible
        If fblnBuscarServicioDisponible(cmbServicio.Text, oTemp) Then
            blnCargando = True
            If Not fblnBuscarServicio(oTemp.NRTFSV, txtCantidad.Text) Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgServicio)
                oDrVw.Cells(0).Value = oTemp.NRTFSV
                oDrVw.Cells(1).Value = oTemp.NOMSER
                oDrVw.Cells(2).Value = oTemp.QATNAN
                oDrVw.Cells(3).Value = oTemp.TUNDIT
                oDrVw.Cells(4).Value = txtCantidad.Text
                dtgServicio.Rows.Add(oDrVw)
                dtgServicio.Rows(dtgServicio.Rows.Count - 1).Tag = "N"
            End If
            blnCargando = False
            ' Cargamos el Item y lanzo el evento respectivo
            If dtgServicio.RowCount > 0 Then
                With oServicioAlmacen
                    .CCLNT = oServicioAlmacen.CCLNT
                    .NOMSER = dtgServicio.CurrentRow.Cells("M_NOMSER").Value
                    .QCNESP = dtgServicio.CurrentRow.Cells("M_QCNESP").Value
                    .NRTFSV = dtgServicio.CurrentRow.Cells("M_NRTFSV").Value
                    .QATNAN = dtgServicio.CurrentRow.Cells("M_QATNAN").Value.ToString.Trim
                    .TUNDIT = dtgServicio.CurrentRow.Cells("M_TUNDIT").Value.ToString.Trim
                End With
                intFilaActual = 0
            Else
                intFilaActual = -1
            End If
            txtCantidad.SelectAll()
        End If
    End Sub
    Private Function fblnBuscarServicioDisponible(ByVal strDetalle As String, ByRef oTemp As ServicioAlmacen) As Boolean
        Dim intIndice As Integer = 0
        Dim blnResultado As Boolean = False
        While intIndice < dtResultado.Rows.Count
            If strDetalle.Trim = ("" & dtResultado.Rows(intIndice).Item("DESTAR")).ToString.Trim Then
                With oTemp
                    Int64.TryParse("" & dtResultado.Rows(intIndice).Item("NRTFSV"), .NRTFSV)
                    .NOMSER = ("" & dtResultado.Rows(intIndice).Item("DESTAR")).ToString.Trim
                    .QATNAN = dtResultado.Rows(intIndice).Item("VALCTE")
                    .TUNDIT = ("" & dtResultado.Rows(intIndice).Item("CUNDMD")).ToString.Trim
                End With
                blnResultado = True
                Exit While
            End If
            intIndice += 1
        End While
        Return blnResultado
    End Function
    Private Function fblnBuscarServicio(ByVal strCodigo As String, Optional ByVal decQtaAtendida As Decimal = 0) As Boolean
        Dim intIndice As Integer
        For intIndice = 0 To Me.dtgServicio.RowCount - 1
            If strCodigo.Trim = dtgServicio.Rows(intIndice).Cells("M_NRTFSV").Value.ToString.Trim Then
                If decQtaAtendida <> 0 Then
                    dtgServicio.Rows(intIndice).Cells("M_QATNAN").Value = decQtaAtendida
                    dtgServicio.Rows(intIndice).DefaultCellStyle.BackColor = Nothing
                    dtgServicio.Rows(intIndice).Tag = "N"
                End If
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
    Private Function fblnBuscarBulto(ByVal strCodigo As String, Optional ByVal blnStatus As Boolean = False) As Boolean
        Dim blnResultado As Boolean = False
        Dim intIndice As Integer
        For intIndice = 0 To dtgBultos.RowCount - 1
            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim Then
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function
#End Region

#Region "Agregar Bulto"
    Private Sub btnAgregarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTermino.Click
        If oServicioAlmacen.CCLNT = 0 Then Exit Sub
        If cmbTerminoBusqueda.Text <> "" And txtCodigo.Text <> "" Then Call Waybills_Registrar()
    End Sub
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If oServicioAlmacen.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cmbTerminoBusqueda.Text <> "" And txtCodigo.Text <> "" Then Waybills_Registrar()
        End If
    End Sub
    Private Sub Waybills_Registrar()
        Dim oSerAlm As New ServicioAlmacen
        With oSerAlm
            .CCLNT = oServicioAlmacen.CCLNT
            .NOPRCN = oServicioAlmacen.NOPRCN
            .TIPOALM = oServicioAlmacen.TIPOALM
            .CCMPN = oServicioAlmacen.CCMPN
            .CDVSN = oServicioAlmacen.CDVSN
            .CPLNDV = cmbPlanta.SelectedValue

            Select Case Mid(cmbTerminoBusqueda.Text, 1, 1)
                Case "B"
                    .CREFFW = txtCodigo.Text
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        HelpClass.MsgBox("Debe ingresar un Nro. de Paleta válido.")
                        Exit Sub
                    Else
                        .NROPLT = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        HelpClass.MsgBox("Debe ingresar un Nro. de Pre-Despacho.")
                        Exit Sub
                    Else
                        .NROCTL = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        HelpClass.MsgBox("Debe ingresar un Nro. de Pre-Despacho.")
                        Exit Sub
                    Else
                        .NRGUSA = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        HelpClass.MsgBox("Debe ingresar un Nro. de Guía de Remisión válido.")
                        Exit Sub
                    Else
                        .NGUIRM = intTemp
                    End If
            End Select
            'If Not oServicioSILNeg.AgregarDetalleServicio(oSerAlm) Then
            '    Exit Sub
            'End If
            ' Ahora registramos los Bultos
            Dim oSerAlm2 As New ServicioAlmacen
            oSerAlm2.CCLNT = .CCLNT
            oSerAlm2.NOPRCN = .NOPRCN
            oSerAlm2.TIPOALM = .TIPOALM
            oSerAlm2.CREFFW = .CREFFW
            oSerAlm2.NROPLT = .NROPLT
            oSerAlm2.NROCTL = .NROCTL
            oSerAlm2.NRGUSA = .NRGUSA
            oSerAlm2.NGUIRM = .NGUIRM
            oSerAlm2.CCMPN = .CCMPN
            oSerAlm2.CDVSN = .CDVSN
            oSerAlm2.CPLNDV = .CPLNDV
            WayBills_Cargar(oSerAlm2)
        End With
    End Sub
    Private Sub WayBills_Cargar(ByVal oSerAlm2 As ServicioAlmacen)
        Dim dtTemp As DataTable = oServicioSILNeg.fdtServicios_Detalle_L02(oSerAlm2)
        Dim dtWayBill As DataTable
        Dim oDrVw As DataGridViewRow
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            blnCargando = True
            dtWayBill = dtTemp.Clone
            For Each dwFila In dtTemp.Rows
                If Not fblnBuscarBulto(dwFila.Item("CREFFW").ToString.Trim, dwFila.Item("QREFFW")) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgBultos)
                    Me.dtgBultos.Rows.Add(oDrVw)
                    With Me.dtgBultos
                        dtgBultos.CurrentRow.ToString()
                        Dim pos As Integer = dtgBultos.Rows.Count - 1
                        .Rows(pos).Cells("CREFFW").Value = dwFila.Item("CREFFW").ToString.Trim
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
                        dtgBultos.Rows(pos).Tag = "N"
                    End With
                    ' ========Si estamos en Batch, debemos marcar el registro para poderlo distiguirlo===========PARA VERIFICAR EXISTENCIA
                    'If Not blnOnLine Then fblnBuscar(dwFila.Item("CREFFW"), True)
                End If
            Next
            blnCargando = False
        End If
        ' Cargamos el Item y lanzo el evento respectivo
        If dtgBultos.RowCount > 0 Then
            With oServicioAlmacen
                .CCLNT = oServicioAlmacen.CCLNT
                .NOPRCN = oServicioAlmacen.NOPRCN
                .CCMPN = oServicioAlmacen.CCMPN
                .CDVSN = oServicioAlmacen.CDVSN
                .CPLNDV = cmbPlanta.SelectedValue
                .CREFFW = dtgBultos.CurrentRow.Cells("CREFFW").Value.ToString.Trim
            End With
            intFilaActual = 0
        Else
            intFilaActual = -1
        End If
    End Sub
#End Region

#Region "Guardar Servicio"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' Rutinas de Validación
        If dtgServicio.Rows.Count <= 0 Then
            MessageBox.Show("Debe seleccionar por lo menos un servicio.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Variables de Trabajo
        '---------------------------------------------
        Dim intNroOperInicial As Int64 = oServicioAlmacen.NOPRCN
        ' Rutinas para registrar todos los servicios
        '---------------------------------------------
        If dtgServicio.Rows.Count > 0 Then 'Si existen Registros para Agregar
            ' Registramos cada uno de los Servicios Asociados
            Dim oServAdqu As ServicioAlmacen
            Dim intNroOperacion As Int64 = 0
            ' Recorremos cada uno de los servicios seleccionados
            For i As Integer = 0 To dtgServicio.Rows.Count - 1
                If dtgServicio.Rows(i).Tag <> "R" Then
                    oServAdqu = New ServicioAlmacen
                    With oServAdqu
                        .CCMPN = oServicioAlmacen.CCMPN
                        .CDVSN = oServicioAlmacen.CDVSN
                        .CCLNT = oServicioAlmacen.CCLNT
                        .NOPRCN = oServicioAlmacen.NOPRCN
                        .FOPRCN = HelpClass.FormatoFechaAS400(dteFechaOperacion.Text)
                        .FECINI = HelpClass.FormatoFechaAS400(dtpFechaInicial.Text)
                        .FECFIN = HelpClass.FormatoFechaAS400(dtpFechaFinal.Text)
                        .NRTFSV = dtgServicio.CurrentRow.Cells("M_NRTFSV").Value
                        .QCNESP = dtgServicio.CurrentRow.Cells("M_QCNESP").Value
                        .TUNDIT = dtgServicio.CurrentRow.Cells("M_TUNDIT").Value
                        .QATNAN = dtgServicio.CurrentRow.Cells("M_QATNAN").Value
                        .TIPOALM = oServicioAlmacen.TIPOALM
                        .TIPO = cmbProceso.SelectedValue
                        .CPRCN1 = txtCodigoContenedor.Text
                        .CCLNFC = oServicioAlmacen.CCLNT
                        .NSRCN1 = txtSerieContenedor.Text
                        'Rutina para registrar servicio '=========intNroOperacion SE DEBE QUITAR
                        If oServicioSILNeg.AgregarServicioAdquiridoSA(oServAdqu, intNroOperacion) Then
                            If oServicioAlmacen.NOPRCN = 0 Then
                                oServicioAlmacen.NOPRCN = oServAdqu.NOPRCN
                                txtNroOperacion.Text = oServAdqu.NOPRCN
                            End If
                        Else
                            HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR"), MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End With
                End If
            Next
        End If
        '======Es cuando se ha actualizado el registro=============
        If dtgServicio.Rows.Count >= 1 Then
            ' Si no se agregó o modificó algún registro, se procede a actualizar la información general
            'If dtgServicio.Rows(i).Tag <> "R" Then
            Dim oTempCab As New ServicioAlmacen
            With oTempCab
                .CCLNT = oServicioAlmacen.CCLNT
                .NOPRCN = txtNroOperacion.Text
                .FECINI = HelpClass.FormatoFechaAS400(dtpFechaInicial.Text)
                .FECFIN = HelpClass.FormatoFechaAS400(dtpFechaFinal.Text)
                .TIPO = cmbProceso.SelectedValue
                .CCLNFC = oServicioAlmacen.CCLNT
                .CPRCN1 = txtCodigoContenedor.Text
                .NSRCN1 = txtSerieContenedor.Text
                '.QATNAN = 
            End With
            ' Rutina para registrar servicio    
            If Not oServicioSILNeg.EditarServicioAdquiridoSA(oTempCab) Then
                HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR"), MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '---------------------------------------------
        ' Rutinas para eliminar los servicios
        '---------------------------------------------
        ' Solo eliminamos item solo si existía antes, no cuando es nuevo
        'If intNroOperInicial <> 0 Then
        '    If dtgServicio.Rows.Count > 0 Then 'Recorre los que son para eliminar
        '        Dim oServAdquPK As ServicioAlmacen
        '        Dim strStatus As String = ""
        '        For i As Integer = 0 To dtgServicio.Rows.Count - 1 'Lista de los que seran eliminados
        '            oServAdquPK = New ServicioAlmacen
        '            With oServAdquPK
        '                .CCLNT = oServicioAlmacen.CCLNT
        '                .NOPRCN = oServicioAlmacen.NOPRCN
        '                .CCLNFC = oServicioAlmacen.CCLNFC
        '                .NRTFSV = oServicioAlmacen.NRTFSV

        '                If oServicioSILNeg.EliminarServicioAdquirido(oServAdquPK, strStatus) Then
        '                    If strStatus = "S" Then MessageBox.Show("Toda la información asociada a la Operación, fue eliminada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Else
        '                    MessageBox.Show("Error al Eliminar los Registros")
        '                    Exit Sub
        '                End If
        '            End With
        '        Next
        '    End If
        'End If
        '---------------------------------------------
        ' Rutinas para la Gestion de Detalle
        '---------------------------------------------
        ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
        Dim bStatusSalir As Boolean
        Select Case oServicioAlmacen.TIPOALM
            'Case "1"
            '    bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            'Case "5"
            '    bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            Case "7"
                bStatusSalir = GrabarBultos(intNroOperInicial)
        End Select
        If bStatusSalir Then
            HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.EXITO"), MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Function GrabarBultos(ByVal NroOperacion As Int64) As Boolean
        Dim blnResultado As Boolean = True
        If dtgBultos.Rows.Count > 0 And oServicioAlmacen.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dtgBultos.Rows.Count > 0 Then
                Dim oDetalle As ServicioAlmacen
                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                    If dtgBultos.Rows(i).Tag = "N" Then
                        oDetalle = New ServicioAlmacen
                        With oDetalle
                            .CCLNT = oServicioAlmacen.CCLNT
                            .NOPRCN = oServicioAlmacen.NOPRCN
                            .TIPOALM = oServicioAlmacen.TIPOALM
                            .CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                            .CCMPN = oServicioAlmacen.CCMPN
                            .CDVSN = oServicioAlmacen.CDVSN
                            .CPLNDV = cmbPlanta.SelectedValue
                        End With
                        If Not oServicioSILNeg.AgregarDetalleServicio(oDetalle) Then
                            HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR"), MessageBoxIcon.Error)
                            blnResultado = False
                            Exit For
                        End If
                    End If
                Next
            End If
            '---------------------------------------------
            ' Rutinas para eliminar los servicios
            '---------------------------------------------
            ' Solo eliminamos item si existía antes, no cuando es nuevo
            'Dim intNroOperInicial As Integer = 0
            'If blnResultado And intNroOperInicial <> 0 Then
            '    If dtgBultos.Rows.Count > 0 Then 'Los que stan marcados apra eliminar
            '        Dim oDetalle As ServicioAlmacen
            '        For Each oDetalleTemp In dtgBultos.Rows
            '            oDetalle = New ServicioAlmacen
            '            With oDetalle
            '                .CCLNT = oServicioAlmacen.CCLNT
            '                .NOPRCN = oServicioAlmacen.NOPRCN
            '                .TIPOALM = oServicioAlmacen.TIPOALM
            '                .CREFFW = oServicioAlmacen.CREFFW
            '            End With
            '            If Not oServicioSILNeg.EliminarDetalleServicioSA(oDetalle) Then
            '                MessageBox.Show("Error al eliminar el registro")
            '                blnResultado = False
            '                Exit For
            '            End If
            '        Next
            '    End If
            'End If
        End If
        Return blnResultado
    End Function
#End Region

End Class
