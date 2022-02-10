Public Class frmServEspPorPromedio
#Region "Propiedades"
    Private bolBuscar As Boolean = False
    Private oDtBultos As DataTable
    ''' <summary>
    ''' Variable
    ''' </summary>
    ''' <remarks></remarks>
    Private _oServicio As Servicio_BE
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Private Sub frmServEspPorPromedio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(_oServicio.CCLNT, _oServicio.PSUSUARIO)
        UcClienteOperacion.pCargar(ClientePK)

        ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(_oServicio.CCLNFC, _oServicio.PSUSUARIO)
        ucClienteFacturar.pCargar(ClientePK)

        CargarPlanta()
        CargarUnidadMedida()
        CargarFormaTarifar()
        cargarServicio()
        cargarTipoAlmacen()
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then  '"M"
            Me.cmbPlanta.Enabled = False
            Me.UcClienteOperacion.Enabled = False
            Me.dteFechaOperacion.Enabled = False

            Me.dtFechaRecepcion.Enabled = False
            Me.dtFechaSalida.Enabled = False

            Me.btnCalcularProm.Visible = False
            Me.cmbPlanta.SelectedValue = _oServicio.CPLNDV
            Me.cmbUnidadMedida.SelectedValue = _oServicio.CUNDMD
            If _oServicio.FECINI <> 0 Then
                Me.dtFechaRecepcion.Value = Comun.FormatoFecha(_oServicio.FECINI)
            End If
            If _oServicio.FECFIN <> 0 Then
                Me.dtFechaSalida.Value = Comun.FormatoFecha(_oServicio.FECFIN)
            End If
            CargarTarifaServicio()
            CargarBultos()
        End If
    End Sub

    ''' <summary>
    ''' Carga Planta
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarPlanta()
        Dim oPlanta As New clsPlantaNeg
        bolBuscar = False
        oPlanta.Crea_Lista(_oServicio.PSUSUARIO)
        cmbPlanta.DataSource = oPlanta.Lista_Planta(_oServicio.CCMPN, _oServicio.CDVSN)
        cmbPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        If _oServicio.CPLNDV <> 0 Then
            cmbPlanta.SelectedValue = _oServicio.CPLNDV
        Else
            cmbPlanta.SelectedValue = 1
        End If
        cmbPlanta.DisplayMember = "TPLNTA"

    End Sub

    ''' <summary>
    ''' Cargar Unidad de Medida
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarUnidadMedida()
        Dim UM As New clsUnidadMedida_BL
        bolBuscar = False
        Me.cmbUnidadMedida.DataSource = UM.Lista_UnidadMedida
        Me.cmbUnidadMedida.ValueMember = "COD"
        bolBuscar = True
        Me.cmbUnidadMedida.DisplayMember = "VAL"
    End Sub


    ''' <summary>
    ''' Carga Tipo Almacen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarTipoAlmacen()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        bolBuscar = False
        oDt = oServicioBL.Listar_TipoAlmacen(UcClienteOperacion.pCodigo)
        cmbTipoAlmacen.ComboBox.DataSource = oDt
        cmbTipoAlmacen.ComboBox.ValueMember = "CTPALM"
        bolBuscar = True
        cmbTipoAlmacen.ComboBox.DisplayMember = "TALMC"
        cmbTipoAlmacen_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' Cuando Cambiamos el Tipo Almacen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbTipoAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAlmacen.SelectedIndexChanged
        If bolBuscar = True Then
            'Cargamos Almacen
            cargaAlmacen()
        End If
    End Sub

    ''' <summary>
    ''' Carga Almacen Combo con CheckBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaAlmacen()
        Dim oServicioBL As New clsServicio_BL
        Dim oSer As New Servicio_BE
        oSer.CCLNT = UcClienteOperacion.pCodigo
        oSer.CTPALM = cmbTipoAlmacen.SelectedValue
        oDtAlmacenes = oServicioBL.Listar_Almacenes(oSer)
        '------------------------------------------------------------------
        cmbAlmacen.ValueMember = "CALMC"
        cmbAlmacen.DisplayMember = "TCMPAL"
        cmbAlmacen.DataSource = oDtAlmacenes
        For i As Integer = 0 To cmbAlmacen.Items.Count - 1
            If cmbAlmacen.Items.Item(i).Value = "0" Then
                cmbAlmacen.SetItemChecked(i, True)
                cargaZona()
            End If
        Next
    End Sub

    ''' <summary>
    ''' Carga Zona Combo con CheckBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaZona()
        Dim oServicioBL As New clsServicio_BL
        Dim oSer As New Servicio_BE
        oSer.CCLNT = UcClienteOperacion.pCodigo
        oSer.CTPALM = cmbTipoAlmacen.SelectedValue
        oSer.CALMC = Lista_Almacen()
        oDtZonas = oServicioBL.Listar_Zonas(oSer)
        '------------------------------------------------------------------
        cmbZona.ValueMember = "CZNALM"
        cmbZona.DisplayMember = "TCMCNA"
        cmbZona.DataSource = oDtZonas
        For i As Integer = 0 To cmbZona.Items.Count - 1
            If cmbZona.Items.Item(i).Value = "0" Then
                cmbZona.SetItemChecked(i, True)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Cuando Cambiamos el combo Almacen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbAlmacen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.Leave
        If bolBuscar = True Then
            'Cargamos Zona
            cargaZona()
        End If
    End Sub

    Private Function Lista_Almacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbAlmacen.CheckedItems.Count - 1
            If cmbAlmacen.CheckedItems(i).Value = "0" Then
                For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                Next
                Exit For
            End If
            For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                If (oDtAlmacenes.Rows(j).Item("CALMC") = cmbAlmacen.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Function Lista_Zona() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbZona.CheckedItems.Count - 1
            If cmbZona.CheckedItems(i).Value = "0" Then
                For j As Integer = 0 To oDtZonas.Rows.Count - 1
                    strCadDocumentos += oDtZonas.Rows(j).Item("CZNALM") & ","
                Next
                Exit For
            End If
            For j As Integer = 0 To oDtZonas.Rows.Count - 1
                If (oDtZonas.Rows(j).Item("CZNALM") = cmbZona.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtZonas.Rows(j).Item("CZNALM") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function


    ''' <summary>
    ''' Cargar Forma Facturar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFormaTarifar()
        Dim oDtFormaTarifa As New DataTable
        Dim oDr As DataRow
        oDtFormaTarifa.Columns.Add("COD")
        oDtFormaTarifa.Columns.Add("VAL")
        oDr = oDtFormaTarifa.NewRow
        oDr("COD") = Comun.TARIFA_X_PROMEDIO
        oDr("VAL") = "PROMEDIO"
        oDtFormaTarifa.Rows.Add(oDr)
        oDr = oDtFormaTarifa.NewRow
        oDr("COD") = Comun.TARIFA_X_MAXIMO
        oDr("VAL") = "MAXIMO"
        oDtFormaTarifa.Rows.Add(oDr)
        oDr = oDtFormaTarifa.NewRow
        oDr("COD") = Comun.TARIFA_X_MINIMO
        oDr("VAL") = "MINIMO"
        oDtFormaTarifa.Rows.Add(oDr)
        bolBuscar = False
        Me.cmbFormaTarifa.ComboBox.DataSource = oDtFormaTarifa
        Me.cmbFormaTarifa.ComboBox.ValueMember = "COD"
        bolBuscar = True
        Me.cmbFormaTarifa.ComboBox.DisplayMember = "VAL"
    End Sub

    Private Sub calculaCantidadServicio()
        If dgServicio.Rows.Count > 0 Then
            For i As Integer = 0 To dgServicio.Rows.Count - 1
                Select Case dgServicio.Rows(i).Cells("CUNDMD").Value 'cmbUnidadMedida.SelectedValue
                    Case Comun.UNIDAD_MT2
                        dgServicio.Rows(i).Cells("QATNAN").Value = txtArea.Text
                    Case Comun.UNIDAD_MT3
                        dgServicio.Rows(i).Cells("QATNAN").Value = txtVolumen.Text
                    Case Comun.UNIDAD_KGS
                        dgServicio.Rows(i).Cells("QATNAN").Value = txtPeso.Text
                End Select
            Next
        End If
    End Sub

    ''' <summary>
    ''' Carga informacion del servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarServicio()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        _oServicio.CCLNT = UcClienteOperacion.pCodigo
        _oServicio.CPLNDV = Me.cmbPlanta.SelectedValue
        _oServicio.NRRUBR = 2 'Solo el rubro de almacenaje -_-_-_-_-_-=
        _oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        bolBuscar = False
        oDt = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)
        oDt.DefaultView.RowFilter = "CUNDMD = '" & cmbUnidadMedida.SelectedValue & "' "
        oDt = oDt.DefaultView.ToTable
        cmbServicio.ComboBox.DataSource = oDt
        cmbServicio.ComboBox.ValueMember = "NRTFSV"
        bolBuscar = True
        cmbServicio.ComboBox.DisplayMember = "DESTAR"
    End Sub

    ''' <summary>
    ''' Se ejecuta cuando se selecciona al cliente de la operación
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UcClienteOperacion_InformationChanged() Handles UcClienteOperacion.InformationChanged
        _oServicio.CCLNT = UcClienteOperacion.pCodigo
        If (UcClienteOperacion.pCodigo <> 0) Then
            cargarServicio()
            cargarTipoAlmacen()
            Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(UcClienteOperacion.pCodigo, _oServicio.PSUSUARIO)
            ucClienteFacturar.pCargar(ClientePK)
        End If
        LimpiarInformacion()
    End Sub

    ''' <summary>
    ''' Selecciona informacion del cliente a facturar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ucClienteFacturar_InformationChanged() Handles ucClienteFacturar.InformationChanged
        oServicio.CCLNFC = ucClienteFacturar.pCodigo
        LimpiarInformacion()
    End Sub
    ''' <summary>
    ''' Limpia toda la informacion en para cuando se hagan cambios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LimpiarInformacion()
        dtgBultos_Dinamico.DataSource = Nothing
        dgServicio.Rows.Clear()
        txtPeso.Text = 0
        txtVolumen.Text = 0
        txtArea.Text = 0
        txtMontoTotal.Text = 0
    End Sub

    ''' <summary>
    ''' Carga La tarifa asignada a la operación
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarTarifaServicio()
        Try
            Dim oServicioBL As New clsServicio_BL
            Dim oDs As New DataSet
            Dim oDt As New DataTable
            oDs = oServicioBL.fdtObtenerServiciosFacturacionSA(_oServicio)
            If oDs.Tables.Count > 0 Then
                oDt = oDs.Tables(0).Copy
                oServicio.NOPRCN = oDt.Rows(0).Item("NOPRCN")
                Me.hgTitulo.ValuesPrimary.Heading = "Nro. Operación :" & oServicio.NOPRCN.ToString
                'cmbProceso.SelectedValue = oDt.Rows(0).Item("STIPPR")
                Me.UcClienteOperacion.pCargar(_oServicio.CCLNT)
                Me.ucClienteFacturar.pCargar(oDt.Rows(0).Item("CCLNFC"))
                Me.dteFechaOperacion.Value = IIf(oDt.Rows(0).Item("FOPRCN") Is DBNull.Value, Now, oDt.Rows(0).Item("FOPRCN"))
                Me.dgServicio.AutoGenerateColumns = False
                Dim oDtServicio As DataTable
                oDtServicio = oDs.Tables(1).Copy
                For intCont As Integer = 0 To oDtServicio.Rows.Count - 1
                    Dim oDrvW As DataGridViewRow
                    oDrvW = New DataGridViewRow
                    oDrvW.CreateCells(Me.dgServicio)
                    With oDrvW
                        .Cells(0).Value = oDtServicio.Rows(intCont).Item("NRTFSV")
                        .Cells(1).Value = oDtServicio.Rows(intCont).Item("DESTAR")
                        .Cells(2).Value = oDtServicio.Rows(intCont).Item("VALCTE")
                        .Cells(3).Value = oDtServicio.Rows(intCont).Item("CUNDMD")
                        .Cells(4).Value = oDtServicio.Rows(intCont).Item("QATNAN")
                        .Cells(5).Value = oDtServicio.Rows(intCont).Item("TSGNMN")
                        .Cells(6).Value = oDtServicio.Rows(intCont).Item("CCNTCS")
                        .Cells(7).Value = oDtServicio.Rows(intCont).Item("IVLSRV")
                        .Cells(8).Value = oDtServicio.Rows(intCont).Item("NOPRCN")
                        .Cells(9).Value = oDtServicio.Rows(intCont).Item("NCRROP")
                    End With
                    Me.dgServicio.Rows.Add(oDrvW)
                Next
            End If
        Catch : End Try
    End Sub
    ''' <summary>
    ''' Busca si el servicio ya esta asignada a la operacion
    ''' </summary>
    ''' <param name="oDr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarServicio(ByVal oDr As DataRow) As Boolean
        For Each oDrServicio As DataGridViewRow In Me.dgServicio.Rows
            If oDrServicio.Cells("NRTFSV").Value = oDr.Item("NRTFSV") And oDrServicio.Cells("CCNTCS").Value = oDr.Item("CCNTCS") AndAlso oDrServicio.Cells("TSGNMN").Value.ToString.Trim = oDr.Item("TSGNMN").ToString.Trim Then
                Select Case oDrServicio.Cells("CUNDMD").Value
                    Case Comun.UNIDAD_MT2
                        oDrServicio.Cells("QATNAN").Value = txtArea.Text
                    Case Comun.UNIDAD_MT3
                        oDrServicio.Cells("QATNAN").Value = txtVolumen.Text
                    Case Comun.UNIDAD_KGS
                        oDrServicio.Cells("QATNAN").Value = txtPeso.Text
                End Select
                Return True
            End If
            If Not (oDrServicio.Cells("CCNTCS").Value = oDr.Item("CCNTCS") AndAlso oDrServicio.Cells("TSGNMN").Value.ToString.Trim = oDr.Item("TSGNMN").ToString.Trim) Then
                Return True
            End If
        Next
        Return False
    End Function
    ''' <summary>
    ''' Para agregar el Servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AgregarServicio()
        If oServicio.CCLNT = 0 Then Exit Sub 'VALIDA QUE TENGAMOS UN CLIENTE SELECCIONADO
        If cmbServicio.SelectedItem Is Nothing Then Exit Sub 'VALIDA QUE EXISTAN SERVICIOS SELECICONADOS
        If dgServicio.Rows.Count > 0 Then Exit Sub 'VALIDA QUE SOLO EXISTA UN SERVICIO A AGREGAR
        If Not fblnBuscarServicio(CType(Me.cmbServicio.SelectedItem, DataRowView).Row) Then
            CargarBultos()
            Dim oDrvW As DataGridViewRow
            oDrvW = New DataGridViewRow
            oDrvW.CreateCells(Me.dgServicio)
            With oDrvW
                .Cells(0).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("NRTFSV")
                .Cells(1).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("DESTAR")
                .Cells(2).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("VALCTE")
                .Cells(3).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CUNDMD")
                Select Case .Cells(3).Value
                    Case Comun.UNIDAD_MT2
                        .Cells(4).Value = txtArea.Text
                    Case Comun.UNIDAD_MT3
                        .Cells(4).Value = txtVolumen.Text
                    Case Comun.UNIDAD_KGS
                        .Cells(4).Value = txtPeso.Text
                End Select
                .Cells(5).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("TSGNMN")
                .Cells(6).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
                .Cells(7).Value = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IVLSRV")
                .Cells(8).Value = 0
            End With
            Me.dgServicio.Rows.Add(oDrvW)
            calcularMontoTotal()
        End If
    End Sub
    ''' <summary>
    ''' Validacion de los campos
    ''' </summary>
    ''' <remarks></remarks>
    Private Function fblnValidar() As Boolean
        Dim strErrr As String = ""
        If Me.cmbPlanta.SelectedValue Is Nothing Then
            strErrr = strErrr & "- Seleccione la planta" & Chr(10)
        End If
        If Me.dgServicio.Rows.Count = 0 Then
            strErrr = strErrr & "- Seleccione el servicio" & Chr(10)
        End If
        If Me.UcClienteOperacion.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione el cliente " & Chr(10)
        End If
        If Me.ucClienteFacturar.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione cliente a facturar" & Chr(10)
        End If
        If Me.txtMontoTotal.Text = "0" Then
            strErrr = strErrr & "- Debe Calcular los Datos Nuevamente" & Chr(10)
        End If
        If strErrr.Trim.Equals("") Then
            Return True
        Else
            MessageBox.Show(strErrr, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        AgregarServicio()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dgServicio.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dgServicio.Rows.Count = 0 Then Exit Sub

        If Me.dgServicio.CurrentRow.Cells("NOPRCN").Value = 0 Then
            Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)
            If dgServicio.Rows.Count = 0 Then
                dtgBultos_Dinamico.DataSource = Nothing
                txtArea.Text = 0
                txtPeso.Text = 0
                txtVolumen.Text = 0
            End If
        Else
            If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                Dim oServicio_BE As New Servicio_BE
                Dim oServicioBL As New clsServicio_BL
                oServicio_BE.CCLNT = Me.UcClienteOperacion.pCodigo
                oServicio_BE.NOPRCN = dgServicio.CurrentRow.Cells(8).Value
                oServicio_BE.SESTRG = "*"
                oServicio_BE.PSUSUARIO = _oServicio.PSUSUARIO

                Dim mssgUpd As String = ""

                mssgUpd = oServicioBL.fintActualizarServiciosFacturacionSA(oServicio_BE)

                If mssgUpd.Length > 0 Then
                    MessageBox.Show(mssgUpd, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

                'If oServicioBL.fintActualizarServiciosFacturacionSA(oServicio_BE) = 0 Then
                '    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                'Else
                '    Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)
                '    Me.DialogResult = Windows.Forms.DialogResult.OK
                'End If
            End If
        End If
        calcularMontoTotal()
    End Sub

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' Rutinas de Validación
        If Not fblnValidar() Then
            Exit Sub
        End If
        ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
        Dim bStatusSalir As Boolean = False
        Dim strNrOperacion As String = ""
        Dim oServicioBL As New clsServicio_BL
        'Inserta o Actualiza la operacion
        With _oServicio
            .CCLNT = UcClienteOperacion.pCodigo
            .FOPRCN = Comun.FormatoFechaAS400(dteFechaOperacion.Text)
            .CCLNFC = ucClienteFacturar.pCodigo
            .CPLNDV = Me.cmbPlanta.SelectedValue
            .STIPPR = Comun.PROCESO_Almacenaje
            If .NOPRCN = 0 Then
                .TIPO = Comun.ESTADO_Nuevo
                .NOPRCN = oServicioBL.fdecInsertarOperacionFacturacionSA(oServicio)
                If .NOPRCN <> 0 Then
                    Me.hgTitulo.ValuesPrimary.Heading = "Nro. Operacion : " & oServicio.NOPRCN.ToString
                Else
                    MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Information, "Validación")
                    Exit Sub
                End If
            Else
                _oServicio.SESTRG = "A"
                If oServicioBL.fdecActualizarOperacionFacturacionSA(oServicio) = 0 Then
                    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                End If
            End If
        End With

        '=================================
        'Inserta o Actualiza los Servicios
        For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
            With _oServicio
                .CCLNT = UcClienteOperacion.pCodigo
                .NRTFSV = Me.dgServicio.Rows(intCont).Cells(0).Value
                .NCRROP = Val("" & Me.dgServicio.Rows(intCont).Cells(9).Value & "")
                .QATNAN = Val(Me.dgServicio.Rows(intCont).Cells(4).Value)
                .CCNTCS = Me.dgServicio.Rows(intCont).Cells("CCNTCS").Value
                .STIPPR = Comun.PROCESO_Almacenaje
                .FINPRF = Format(dtFechaRecepcion.Value, "yyyyMMdd")
                .FFNPRF = Format(dtFechaSalida.Value, "yyyyMMdd")
                If .NCRROP = 0 Then
                    .TIPO = Comun.ESTADO_Nuevo

                    Dim msgserv As String = ""
                    Dim corr_servicio As Decimal = 0

                    msgserv = oServicioBL.fdecInsertarServiciosFacturacionSA(oServicio, corr_servicio)
                    .NCRROP = corr_servicio
                    '.NCRROP = oServicioBL.fdecInsertarServiciosFacturacionSA(oServicio)
                    If .NCRROP = 0 Then
                        'MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Information, "Validación")
                        MessageBox.Show(msgserv, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    _oServicio.SESTRG = "A"
                    Dim mssgUpd As String = ""

                    mssgUpd = oServicioBL.fintActualizarServiciosFacturacionSA(oServicio)
                    If mssgUpd.Length > 0 Then
                        MessageBox.Show(mssgUpd, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    'If oServicioBL.fintActualizarServiciosFacturacionSA(oServicio) = 0 Then
                    '    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                    'End If
                End If
            End With
        Next
        '---------------------------------------------
        ' Rutinas para la Gestion de Detalle
        '---------------------------------------------
        Me.dtgBultos_Dinamico.EndEdit()
        bStatusSalir = GrabarPromedios_RZSC25()
        If Not bStatusSalir Then
            Exit Sub
        Else
            strNrOperacion = strNrOperacion & oServicio.NOPRCN & ". "
        End If

        If bStatusSalir Then
            MsgBox(Comun.Mensaje("MENSAJE.EXITO") & Chr(10) & " Nr. Operación: " & strNrOperacion, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Function GrabarPromedios_RZSC25() As Boolean
        If btnCalcularProm.Visible = False Then Exit Function
        Dim oServicioBL As New clsServicio_BL
        Dim blnResultado As Boolean = True
        If dtgBultos_Dinamico.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '----------------------------------------------
            '-- Rutinas para registrar todos los Bultos ---
            '----------------------------------------------
            If dtgBultos_Dinamico.Rows.Count > 0 Then
                Dim oServicioSAT As New Servicio_BE
                For i As Integer = 0 To oDtBultos.Rows.Count - 1 'Registros Hechos
                    _oServicio.NCRRDC = i + 1
                    _oServicio.FPRCSO = oDtBultos.Rows(i).Item("FECHA")
                    _oServicio.QPSOTT = oDtBultos.Rows(i).Item("PESO")    
                    _oServicio.QVOLMR = oDtBultos.Rows(i).Item("VOLUMEN")
                    _oServicio.QARMTS = oDtBultos.Rows(i).Item("AREA")
                    oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosPromediosSA_RZSC25(oServicio)
                    If Not oServicio.PSERROR.Equals("") Then
                        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                        blnResultado = False
                        Exit For
                    End If
                Next
            End If
        End If
        Return blnResultado
    End Function

    Private Sub calcularMontoTotal()
        Dim dblTotaliza As Double = 0
        If dgServicio.Rows.Count > 0 Then
            For i As Integer = 0 To dgServicio.Rows.Count - 1
                dblTotaliza = dblTotaliza + (dgServicio.Rows(i).Cells(4).Value * dgServicio.Rows(i).Cells(7).Value) 'Calculamos la caja de monto txtMontoTotal
            Next
        End If
        'txtMontoTotal.Text = Math.Round(dblTotaliza, 2)
        txtMontoTotal.Text = dblTotaliza.ToString("N2")
    End Sub
    Private Sub btnAgregarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _oServicio.CCLNT = 0 Then Exit Sub
        Dim frmBulto As New frmBuscarBulto(_oServicio)
        frmBulto.ShowDialog()
    End Sub

    Private Sub cmbUnidadMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnidadMedida.SelectedIndexChanged
        If bolBuscar Then
            cargarServicio()
            txtArea.BackColor = Color.White
            txtVolumen.BackColor = Color.White
            txtPeso.BackColor = Color.White
            Select Case cmbUnidadMedida.SelectedValue
                Case Comun.UNIDAD_MT2
                    txtArea.BackColor = Color.LightPink
                Case Comun.UNIDAD_MT3
                    txtVolumen.BackColor = Color.LightPink
                Case Comun.UNIDAD_KGS
                    txtPeso.BackColor = Color.LightPink
            End Select
        End If
    End Sub
    ''' <summary>
    ''' CARGA LOS BULTOS
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarBultos()
        Dim oDsBultos As New DataSet
        If _oServicio.CCLNT = 0 Then Exit Sub
        Dim oSerV_BL As New clsServicio_BL
        _oServicio.CCLNT = UcClienteOperacion.pCodigo
        _oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        _oServicio.CTPALM = cmbTipoAlmacen.SelectedValue
        _oServicio.CALMC = Lista_Almacen()
        _oServicio.CZNALM = Lista_Zona()
        dtgBultos_Dinamico.DataSource = Nothing
        Select Case _oServicio.TIPO
            Case Comun.ESTADO_Modificado
                _oServicio.CPLNDV = cmbPlanta.SelectedValue
                oDsBultos = oSerV_BL.ListarBultosAlmacenaje_Promedio_RZSC25(_oServicio)
            Case Comun.ESTADO_Nuevo
                _oServicio.FREFFW = Format(dtFechaRecepcion.Value, "yyyyMMdd")
                _oServicio.FSLFFW = Format(dtFechaSalida.Value, "yyyyMMdd")
                '''' DIFERENCIA DE DIAS ''''
                _oServicio.TOTALDIAS = DateDiff(DateInterval.Day, dtFechaRecepcion.Value, dtFechaSalida.Value) + 1
                If _oServicio.TOTALDIAS <= 0 Then Exit Sub
                oDsBultos = oSerV_BL.ListarBultosAlmacenaje_Promedio(_oServicio) 'Evento que buscara todos los bultos segun condicion RZSC65
        End Select
        If oDsBultos.Tables(0).Rows.Count > 0 Then GrillaDinamicaBulto(oDsBultos)
        cargarServicio()
        cmbFormaTarifa_SelectedIndexChanged(Nothing, Nothing)
        calcularMontoTotal()
    End Sub

    Private Sub GrillaDinamicaBulto(ByVal oDsBultos As DataSet)
        oDtBultos = New DataTable
        oDtBultos = oDsBultos.Tables(0)
        Dim oDtPromedios As DataTable = oDsBultos.Tables(1)
        Dim oDtNewBultos As New DataTable
        Dim oDr As DataRow
        Dim fFormatCab As String = ""
        '''' Contamos la cantidad de Columnas que existiran
        Dim cantColumns As Integer = oDtBultos.Rows.Count
        '''' Creamos Columnas Fijas en la Grilla
        oDtNewBultos.Columns.Add("Unidad")
        oDtNewBultos.Columns("Unidad").Caption = "Uni"
        oDtNewBultos.Columns.Add("Promedio", GetType(System.Double))
        oDtNewBultos.Columns("Promedio").Caption = "Prom"
        oDtNewBultos.Columns.Add("Máximo", GetType(System.Double))
        oDtNewBultos.Columns("Máximo").Caption = "Max"
        oDtNewBultos.Columns.Add("Mínimo", GetType(System.Double))
        oDtNewBultos.Columns("Mínimo").Caption = "Min"
        '''' Creamos las columnas necesarias en un nuevo datatable
        For i As Integer = 0 To cantColumns - 1
            fFormatCab = oDtBultos.Rows(i).Item("FECHA")
            fFormatCab = fFormatCab.Substring(6, 2) & "-" & fFormatCab.Substring(4, 2) & "-" & fFormatCab.Substring(0, 4)
            oDtNewBultos.Columns.Add(fFormatCab)
            oDtNewBultos.Columns(fFormatCab).Caption = "Columna" & (i + 3)
        Next
        '''' Cargamos la nueva Dt con los registros de oDtBultos
        oDr = oDtNewBultos.NewRow
        For i As Integer = 0 To cantColumns - 1
            oDr("Unidad") = "PESO"
            oDr("Promedio") = Math.Round(oDtPromedios.Rows(0).Item("PESO"), 2)
            oDr("Máximo") = Math.Round(oDtPromedios.Rows(1).Item("PESO"), 2)
            oDr("Mínimo") = Math.Round(oDtPromedios.Rows(2).Item("PESO"), 2)
            oDr(i + 4) = oDtBultos.Rows(i).Item("PESO")
        Next
        oDtNewBultos.Rows.Add(oDr)
        '''' ------------------------------------
        oDr = oDtNewBultos.NewRow
        For i As Integer = 0 To cantColumns - 1
            oDr("Unidad") = "VOLUMEN"
            oDr("Promedio") = Math.Round(oDtPromedios.Rows(0).Item("VOLUMEN"), 2)
            oDr("Máximo") = Math.Round(oDtPromedios.Rows(1).Item("VOLUMEN"), 2)
            oDr("Mínimo") = Math.Round(oDtPromedios.Rows(2).Item("VOLUMEN"), 2)
            oDr(i + 4) = oDtBultos.Rows(i).Item("VOLUMEN")
        Next
        oDtNewBultos.Rows.Add(oDr)
        '''' ------------------------------------
        oDr = oDtNewBultos.NewRow
        For i As Integer = 0 To cantColumns - 1
            oDr("Unidad") = "AREA"
            oDr("Promedio") = Math.Round(oDtPromedios.Rows(0).Item("AREA"), 2)
            oDr("Máximo") = Math.Round(oDtPromedios.Rows(1).Item("AREA"), 2)
            oDr("Mínimo") = Math.Round(oDtPromedios.Rows(2).Item("AREA"), 2)
            oDr(i + 4) = oDtBultos.Rows(i).Item("AREA")
        Next
        oDtNewBultos.Rows.Add(oDr)
        '''' ------------------------------------
        dtgBultos_Dinamico.DataSource = oDtNewBultos

    End Sub

    Private Sub btnCalcularProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularProm.Click
        CargarBultos()
    End Sub

    Private Sub cmbFormaTarifa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormaTarifa.SelectedIndexChanged
        If bolBuscar Then
            If dtgBultos_Dinamico.Rows.Count > 0 Then
                Select Case cmbFormaTarifa.ComboBox.SelectedValue
                    Case Comun.TARIFA_X_PROMEDIO
                        txtPeso.Text = dtgBultos_Dinamico.Rows(0).Cells("Promedio").Value
                        txtVolumen.Text = dtgBultos_Dinamico.Rows(1).Cells("Promedio").Value
                        txtArea.Text = dtgBultos_Dinamico.Rows(2).Cells("Promedio").Value
                    Case Comun.TARIFA_X_MAXIMO
                        txtPeso.Text = dtgBultos_Dinamico.Rows(0).Cells("Máximo").Value
                        txtVolumen.Text = dtgBultos_Dinamico.Rows(1).Cells("Máximo").Value
                        txtArea.Text = dtgBultos_Dinamico.Rows(2).Cells("Máximo").Value
                    Case Comun.TARIFA_X_MINIMO
                        txtPeso.Text = dtgBultos_Dinamico.Rows(0).Cells("Mínimo").Value
                        txtVolumen.Text = dtgBultos_Dinamico.Rows(1).Cells("Mínimo").Value
                        txtArea.Text = dtgBultos_Dinamico.Rows(2).Cells("Mínimo").Value
                End Select
                txtPeso.Text = Math.Round(CDbl(txtPeso.Text), 2)
                txtVolumen.Text = Math.Round(CDbl(txtVolumen.Text), 2)
                txtArea.Text = Math.Round(CDbl(txtArea.Text), 2)
            End If
            calculaCantidadServicio()
        End If
    End Sub

    Private Sub dtgBultos_Dinamico_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgBultos_Dinamico.DataBindingComplete
        NoOrdenarGrilla()
    End Sub
    Private Sub NoOrdenarGrilla()
        Dim i As Integer
        For i = 0 To dtgBultos_Dinamico.ColumnCount - 1
            dtgBultos_Dinamico.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
End Class
