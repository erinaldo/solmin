
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Public Class FrmMovSegOperacion
    Private dstGeneral As New DataSet()
    Private _lstrTipoCuenta As String
    Private oDtEstado As DataTable
    Private oDtTipoViaje As DataTable
    Private ht As New Hashtable

    Private Sub Cargar_Region_Venta()
        Dim objLogica As New ReportesVariados_BLL
        Dim dtRegion As New DataTable
        dtRegion = objLogica.Lista_Region_Venta(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboRegionVenta.ValueMember = "CODIGO"
        Me.cboRegionVenta.DisplayMember = "REGION"
        Me.cboRegionVenta.DataSource = dtRegion
        Me.cboRegionVenta.SelectedValue = "0"

        For i As Integer = 0 To cboRegionVenta.Items.Count - 1
            If cboRegionVenta.Items.Item(i).Value = "0" Then
                cboRegionVenta.SetItemChecked(i, True)
            End If
        Next
    End Sub
    Private Sub FrmSeguimientoOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Alinear_Columnas_Grilla()
            Me.Cargar_Compania()
            Me.Carga_MedioTransporte()
            Me.CargarEstado()
            Me.CargarTipoViaje()
            'Me.cmbViaje.SelectedItem = "TODOS"
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            Me.txtTransportista.pCargar(obeTracto)
            Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
            Me.cargarComboPlanta()
            'cboRegionVenta()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Dim oDr As DataRow
        oDr = objTabla.NewRow
        oDr.Item("CMEDTR") = 0
        oDr.Item("TNMMDT") = "TODOS"
        objTabla.Rows.Add(oDr)
        objTabla.Select("", "")

        Dim dv As DataView
        dv = New DataView(objTabla, "", "CMEDTR ASC", DataViewRowState.CurrentRows)

        Me.cboMedioTransporteFiltro.DataSource = dv
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"

    End Sub
    Private Sub CargarEstado()
        Dim dt As New DataTable
        dt = ListaEstadoOperacion()
        Me.cboEstadoChk.DisplayMember = "ESTADO_NOPRCN"
        Me.cboEstadoChk.ValueMember = "VALUE"
        Me.cboEstadoChk.DataSource = dt.Copy

        For i As Integer = 0 To cboEstadoChk.Items.Count - 1
            If cboEstadoChk.Items.Item(i).Value = "1" Then
                cboEstadoChk.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Sub CargarTipoViaje()
        Dim dt As New DataTable
        dt = ListaEstadosTipoViaje()
        Me.cboTipoViajeChk.DisplayMember = "ESTADO_CTPOVJ"
        Me.cboTipoViajeChk.ValueMember = "VALUE"
        Me.cboTipoViajeChk.DataSource = dt.Copy

        For i As Integer = 0 To cboTipoViajeChk.Items.Count - 1
            If cboTipoViajeChk.Items.Item(i).Value = "1" Then
                cboTipoViajeChk.SetItemChecked(i, True)
            End If
        Next
    End Sub
    Private Function ListaEstadoOperacion() As DataTable
        oDtEstado = New DataTable
        oDtEstado.TableName = "dtResumenEstado"
        Dim oDr As DataRow
        oDtEstado.Columns.Add("VALUE", Type.GetType("System.String"))
        oDtEstado.Columns.Add("ESTADO_NOPRCN", Type.GetType("System.String"))
        oDtEstado.Columns.Add("NROUNI", Type.GetType("System.Int32"))
        oDtEstado.Columns.Add("VALUES_STRING", Type.GetType("System.String"))

        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "TODOS"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "1"
        oDr.Item("VALUES_STRING") = "TO"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "PENDIENTE"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "2"
        oDr.Item("VALUES_STRING") = "P"
        oDtEstado.Rows.Add(oDr)



        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "ASIGNADO"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "3"
        oDr.Item("VALUES_STRING") = "A"
        oDtEstado.Rows.Add(oDr)


        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "PRE - FACTURADO"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "4"
        oDr.Item("VALUES_STRING") = "F"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "FACTURADO"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "5"
        oDr.Item("VALUES_STRING") = "F"
        oDtEstado.Rows.Add(oDr)


        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "CERRADO"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "6"
        oDr.Item("VALUES_STRING") = "C"
        oDtEstado.Rows.Add(oDr)


        oDr = oDtEstado.NewRow
        oDr.Item("ESTADO_NOPRCN") = "ANULADO"
        oDr.Item("NROUNI") = 0
        oDr.Item("VALUE") = "7"
        oDr.Item("VALUES_STRING") = "*"
        oDtEstado.Rows.Add(oDr)
        Return oDtEstado

    End Function

    Private Function ListaEstadosTipoViaje() As DataTable
        oDtTipoViaje = New DataTable
        oDtTipoViaje.TableName = "dtResumenTipoViaje"
        Dim oDr As DataRow
        oDtTipoViaje.Columns.Add("VALUE", Type.GetType("System.String"))
        oDtTipoViaje.Columns.Add("ESTADO_CTPOVJ", Type.GetType("System.String"))
        oDtTipoViaje.Columns.Add("NROUNI", Type.GetType("System.Int32"))
        oDtTipoViaje.Columns.Add("VALUES_STRING", Type.GetType("System.String"))

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "T"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "TODOS"
        oDr.Item("VALUE") = "1"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "E"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "EXCLUSIVO"
        oDr.Item("VALUE") = "2"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "R"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "REPARTO"
        oDr.Item("VALUE") = "3"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "M"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "MULTIMODAL"
        oDr.Item("VALUE") = "4"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "C"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "CONSOLIDADO"
        oDr.Item("VALUE") = "5"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item("VALUES_STRING") = "P"
        oDr.Item("NROUNI") = 0
        oDr.Item("ESTADO_CTPOVJ") = "PASAJERO"
        oDr.Item("VALUE") = "6"
        oDtTipoViaje.Rows.Add(oDr)

        Return oDtTipoViaje

    End Function

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub CargarTransportista()
        txtTransportista.pClear()
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        Me.txtTransportista.pCargar(obeTracto)
    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""
        Try
            If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
                objLogica.Crea_Lista()
                objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                cboPlanta.DisplayMember = "TPLNTA"
                cboPlanta.ValueMember = "CPLNDV"
                Me.cboPlanta.DataSource = objLisEntidad
                For i As Integer = 0 To cboPlanta.Items.Count - 1
                    If cboPlanta.Items.Item(i).Value = "1" Then
                        cboPlanta.SetItemChecked(i, True)
                    End If
                Next
                If cboPlanta.Text = "" Then
                    cboPlanta.SetItemChecked(0, True)
                End If
                If objLisEntidad.Count > 0 Then
                    _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
                Else
                    _lstrTipoCuenta = ""
                End If
                'bolBuscar = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InicializarFormulario()
        gwdDatos.DataSource = Nothing
        ctlCliente.pClear()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    End Sub
    Private Function ValidarFiltroFecha() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        If Me.chkFecha.Checked = False Then
            If IsNumeric(Me.txtNroOperacion.Text.Trim) = False Then
                If IsNumeric(Me.txtPreFactura.Text.Trim) = False Then
                    If IsNumeric(Me.txtPreLiquidacion.Text.Trim) = False Then
                        If IsNumeric(Me.txtFactura.Text.Trim) = False Then
                            If IsNumeric(Me.txtOrdenInterna.Text.Trim) = False Then
                                If IsNumeric(Me.txtAgenciaRansa.Text.Trim) = False Then
                                    lbool_existe_error = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If lbool_existe_error = True Then HelpClass.MsgBox(" Ingresar el número de documento a consultar " & Chr(13) & lstr_validacion)
        Return lbool_existe_error
    End Function
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        'cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Cargar_Region_Venta()
                Me.Limpiar()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                cargarComboPlanta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Select Case Me.chkFecha.Checked
            Case True
                Me.txtAgenciaRansa.Enabled = False
                Me.txtNroOperacion.Enabled = False
                Me.txtOrdenInterna.Enabled = False
                Me.txtPreFactura.Enabled = False
                Me.txtPreLiquidacion.Enabled = False
                Me.txtFactura.Enabled = False
                Me.gbFecha.Enabled = True
            Case False
                Me.txtAgenciaRansa.Enabled = True
                Me.txtNroOperacion.Enabled = True
                Me.txtOrdenInterna.Enabled = True
                Me.txtPreFactura.Enabled = True
                Me.txtPreLiquidacion.Enabled = True
                Me.txtFactura.Enabled = True
                Me.gbFecha.Enabled = False
        End Select
    End Sub

    Private Sub Limpiar()
        InicializarFormulario()
        CargarTransportista()
    End Sub
    Private Function ObtenerEstado(ByRef intValorCon As Int32) As String
        Dim strCodEstado As String = ""
        For i As Integer = 0 To cboEstadoChk.CheckedItems.Count - 1
            If (cboEstadoChk.CheckedItems(i).Value <> "1") Then
                For j As Integer = 0 To oDtEstado.Rows.Count - 1
                    If (oDtEstado.Rows(j).Item("VALUE") = cboEstadoChk.CheckedItems(i).Value) Then
                        Select Case cboEstadoChk.CheckedItems(i).Value
                            Case 4
                                intValorCon = 1
                            Case 5
                                intValorCon = 2
                        End Select
                        strCodEstado += oDtEstado.Rows(j).Item("VALUES_STRING") & ","
                    End If
                Next
            Else
                If (cboEstadoChk.CheckedItems.Count = 1) Then
                    strCodEstado = "TO,"
                End If
            End If
        Next
        If strCodEstado.Trim.Length > 0 Then
            strCodEstado = strCodEstado.Trim.Substring(0, strCodEstado.Trim.Length - 1)
        End If
        Return strCodEstado
    End Function

    Private Function ObtenerTipoViaje() As String
        Dim strCodTipoViaje As String = ""
        For i As Integer = 0 To cboTipoViajeChk.CheckedItems.Count - 1
            If (cboTipoViajeChk.CheckedItems(i).Value <> "1") Then
                For j As Integer = 0 To oDtEstado.Rows.Count - 1
                    If (oDtEstado.Rows(j).Item("VALUE") = cboTipoViajeChk.CheckedItems(i).Value) Then
                        strCodTipoViaje += oDtEstado.Rows(j).Item("VALUES_STRING") & ","
                    End If
                Next
            Else
                If (cboTipoViajeChk.CheckedItems.Count = 1) Then
                    strCodTipoViaje = "TO,"
                End If
            End If
        Next
        If strCodTipoViaje.Trim.Length > 0 Then
            strCodTipoViaje = strCodTipoViaje.Trim.Substring(0, strCodTipoViaje.Trim.Length - 1)
        End If
        Return strCodTipoViaje
    End Function

    'Private Function Descripcion_Tipo_Viaje(ByVal strCTPOVJ As String) As String
    '    Dim strTipoViaje As String = ""
    '    Select Case strCTPOVJ
    '        Case "E"
    '            strTipoViaje = "EXCLUSIVO"
    '        Case "R"
    '            strTipoViaje = "REPARTO"
    '        Case "M"
    '            strTipoViaje = "MULTIMODAL"
    '        Case "C"
    '            strTipoViaje = "CONSOLIDADO"
    '        Case "P"
    '            strTipoViaje = "PASAJERO"
    '    End Select
    '    Return strTipoViaje
    'End Function

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try
            Dim boolEstado As Boolean
            Me.dstGeneral = Nothing
            Me.gwdDatos.DataSource = Nothing
            Me.Cursor = Cursors.WaitCursor
            ht = New Hashtable
            PrepararProceesWorked(boolEstado)
            If boolEstado = True Then Exit Sub
            bgwProceso.RunWorkerAsync()
        Catch ex As Exception
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub PrepararProceesWorked(ByRef boolEstado As Boolean)
        boolEstado = ValidarFiltroFecha()
        If boolEstado = True Then Exit Sub
        Dim strCodPlanta As String = ""
        Dim intValorCon As Int32 = 0
        Me.Cursor = Cursors.WaitCursor
        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."

        ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        ht.Add("CDVSN", cmbDivision.Division)

        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            strCodPlanta += cboPlanta.CheckedItems(i).Value & ","
        Next
        If strCodPlanta = "" Then
            For i As Integer = 0 To cboPlanta.Items.Count - 1
                strCodPlanta += cboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        ht.Add("CPLNDV", strCodPlanta)
        If ctlCliente.pCodigo.Equals("") Then
            ht.Add("CCLNT", 0)
        Else
            ht.Add("CCLNT", Convert.ToInt32(Me.ctlCliente.pCodigo))
        End If
        If Me.chkFecha.Checked = True Then
            ht.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
            ht.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))
        Else
            ht.Add("FINCOP_IN", 0)
            ht.Add("FINCOP_FI", 0)
        End If
        ht.Add("STATUS", "")
        ht.Add("ESTADO", Me.ObtenerEstado(intValorCon))
        ht.Add("TIPVJE", Me.ObtenerTipoViaje())
        ht.Add("VARCON", intValorCon)
        ht.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)
        If txtTransportista.pRucTransportista = "" Then
            ht.Add("CTRSPT", 0)
        Else
            ht.Add("CTRSPT", Convert.ToInt32(txtTransportista.pCodigoRNS))
        End If
        If Me.chkFecha.Checked = False Then
            If Me.txtPreFactura.Text.Trim.Equals("") OrElse IsNumeric(Me.txtPreFactura.Text.Trim) = False Then
                ht.Add("NDCPRF", 0)
            Else
                ht.Add("NDCPRF", Convert.ToInt64(Me.txtPreFactura.Text.Trim))
            End If
            If Me.txtPreLiquidacion.Text.Trim.Equals("") OrElse IsNumeric(Me.txtPreLiquidacion.Text.Trim) = False Then
                ht.Add("NPRLQD", 0)
            Else
                ht.Add("NPRLQD", Convert.ToInt64(Me.txtPreLiquidacion.Text.Trim))
            End If
            If Me.txtNroOperacion.Text.Trim.Equals("") OrElse IsNumeric(Me.txtNroOperacion.Text.Trim) = False Then
                ht.Add("NOPRCN", 0)
            Else
                ht.Add("NOPRCN", Convert.ToInt64(Me.txtNroOperacion.Text.Trim))
            End If
            If Me.txtAgenciaRansa.Text.Trim.Equals("") OrElse IsNumeric(Me.txtAgenciaRansa.Text.Trim) = False Then
                ht.Add("NDCORM", 0)
            Else
                ht.Add("NDCORM", Convert.ToInt64(Me.txtAgenciaRansa.Text.Trim))
            End If
            If Me.txtOrdenInterna.Text.Trim.Equals("") OrElse IsNumeric(Me.txtOrdenInterna.Text.Trim) = False Then
                ht.Add("NORINS", 0)
            Else
                ht.Add("NORINS", Convert.ToInt64(Me.txtOrdenInterna.Text.Trim))
            End If
            If Me.txtFactura.Text.Trim.Equals("") OrElse IsNumeric(Me.txtFactura.Text.Trim) = False Then
                ht.Add("NDCMFC", 0)
            Else
                ht.Add("NDCMFC", Convert.ToInt64(Me.txtFactura.Text.Trim))
            End If
            ht.Add("STSTIP", 0)
        Else
            ht.Add("NDCPRF", 0)
            ht.Add("NPRLQD", 0)
            ht.Add("NOPRCN", 0)
            ht.Add("NDCORM", 0)
            ht.Add("NORINS", 0)
            ht.Add("NDCMFC", 0)

            Dim strEstado As Integer = 0
            If Me.rbnOperacion.Checked Then
                strEstado = 1
            ElseIf Me.rbnGuia.Checked Then
                strEstado = 2
            ElseIf Me.rbnLiquidacion.Checked Then
                strEstado = 3
            Else
                strEstado = 4
            End If

            ht.Add("STSTIP", strEstado)

        End If
        ht.Add("NPLVHT", Me.txtTracto.Text)
        Dim strAcVehicular As String = ""
        'If cmbViaje.SelectedItem = "TODOS" Then
        '    strAcVehicular = "TO"
        'ElseIf cmbViaje.SelectedItem = "SI" Then
        '    strAcVehicular = "SI"
        'ElseIf cmbViaje.SelectedItem = "NO" Then
        '    strAcVehicular = "NO"
        'Else
        '    strAcVehicular = "NO"
        'End If
        strAcVehicular = "TO"
        ht.Add("SSINVJ", strAcVehicular)
        ht.Add("PSREGION", ObtenerRegionVenta)


        Dim REGION As String = ObtenerRegionVenta
    End Sub

    Private Function ObtenerRegionVenta() As String
        Dim strCodRegionventa As String = ""
        For i As Integer = 0 To cboRegionVenta.CheckedItems.Count - 1
            If (cboRegionVenta.CheckedItems(i).Value = "0") Then
                strCodRegionventa = "0" & ","
                Exit For
            Else
                strCodRegionventa = cboRegionVenta.CheckedItems(i).Value
                strCodRegionventa = strCodRegionventa & ","
            End If
        Next
        strCodRegionventa = strCodRegionventa.Trim
        If strCodRegionventa.Length > 0 Then
            strCodRegionventa = strCodRegionventa.Trim.Substring(0, strCodRegionventa.Length - 1)
        End If
        Return strCodRegionventa
    End Function



    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim objLogicaReportes As New ReportesVariados_BLL
        e.Result = objLogicaReportes.frptSeguimientoOperaciones(ht)
    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dstreporte As New DataSet
            Dim dt As DataTable
            dstreporte = CType(e.Result, DataSet)
            dt = dstreporte.Tables(0)
            dt.Columns.Add("IMPCO_SOLES", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPPA_SOLES", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPORTE_NETO", Type.GetType("System.Decimal"))
            dt.Columns.Add("MARGEN", Type.GetType("System.Decimal"))
            If dstreporte Is Nothing Then Exit Sub
            If dstreporte.Tables.Count > 0 Then dt.TableName = "dtmovOperaciones"
            For x As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(x)("FINCOP") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FINCOP").ToString)
                dt.Rows(x)("FATNSR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FATNSR").ToString)
                dt.Rows(x)("FGUITR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FGUITR").ToString)
                dt.Rows(x)("FSLDCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FSLDCM").ToString)
                dt.Rows(x)("FLLGCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FLLGCM").ToString)
                dt.Rows(x)("FCHCRR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCHCRR").ToString)
                dt.Rows(x)("FDCPRF") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FDCPRF").ToString)
                dt.Rows(x)("FECFAC") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECFAC").ToString)
                dt.Rows(x)("FECCRE") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECCRE").ToString)
                dt.Rows(x)("FCHCRT_INICIO") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCHCRT_INICIO").ToString)
                dt.Rows(x)("FCHCRT_CIERRE") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCHCRT_CIERRE").ToString)
                'dt.Rows(x)("CTPOVJ") = Descripcion_Tipo_Viaje(dt.Rows(x)("CTPOVJ").ToString)

                dt.Rows(x)("FECOST") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECOST").ToString)


                dt.Rows(x)("FOPENTR_ADMIN") = HelpClass.CFecha_de_8_a_10(("" & dt.Rows(x)("FOPENTR_ADMIN")).ToString.Trim)


                dt.Rows(x)("FDOCENTR_NEGOCIO") = HelpClass.CFecha_de_8_a_10(("" & dt.Rows(x)("FDOCENTR_NEGOCIO")).ToString.Trim)

                dt.Rows(x)("FENTCB") = HelpClass.CFecha_de_8_a_10(("" & dt.Rows(x)("FENTCB")).ToString.Trim)
                dt.Rows(x)("FENCBD") = HelpClass.CFecha_de_8_a_10(("" & dt.Rows(x)("FENCBD")).ToString.Trim)
                dt.Rows(x)("FENTCL") = HelpClass.CFecha_de_8_a_10(("" & dt.Rows(x)("FENTCL")).ToString.Trim)



                If dt.Rows(x)("ID_MNDCO") = 100 Then
                    dt.Rows(x)("IMPCO_SOLES") = dt.Rows(x)("IMPCO") * dt.Rows(x)("TC_COBRAR")
                Else
                    dt.Rows(x)("IMPCO_SOLES") = dt.Rows(x)("IMPCO")
                End If

                If dt.Rows(x)("ID_MNDPA") = 100 Then
                    dt.Rows(x)("IMPPA_SOLES") = dt.Rows(x)("IMPPA") * dt.Rows(x)("TC_PAGAR")
                Else
                    dt.Rows(x)("IMPPA_SOLES") = dt.Rows(x)("IMPPA")
                End If

                ' dt.Rows(x)("IMPORTE_NETO") = dt.Rows(x)("IMPCO_SOLES") - (dt.Rows(x)("IMPPA_SOLES") + dt.Rows(x)("GASTOAVC") + dt.Rows(x)("COSTO") + dt.Rows(x)("GASTOS") + dt.Rows(x)("IGSTOPCN") + dt.Rows(x)("IGSTOPCM"))

                dt.Rows(x)("IMPORTE_NETO") = dt.Rows(x)("IMPCO_SOLES") - (dt.Rows(x)("IMPPA_SOLES") + dt.Rows(x)("GASTOAVC") + dt.Rows(x)("COSTO") + dt.Rows(x)("GASTOS"))
                'dt.Rows(x)("IMPORTE_NETO") = dt.Rows(x)("IMPCO_SOLES") - (dt.Rows(x)("IMPPA_SOLES") + dt.Rows(x)("GASTOAVC") + dt.Rows(x)("COSTO") + dt.Rows(x)("GASTOS"))

                If dt.Rows(x)("IMPCO_SOLES") <> 0 Then
                    dt.Rows(x)("MARGEN") = Math.Round((dt.Rows(x)("IMPORTE_NETO") / dt.Rows(x)("IMPCO_SOLES")) * 100, 5)
                Else
                    dt.Rows(x)("MARGEN") = 100
                End If
            Next
            Me.gwdDatos.DataSource = dt
            dstGeneral = dstreporte
        Catch ex As Exception
            'ClearMemory()
        End Try
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
    End Sub
    'Private Function Datos_Reporte_Operaciones_Transporte_por_OrdenDeCompra() As DataSet
    '    Dim dst As New DataSet
    '    Try
    '        Dim objcoleccion As New Collection
    '        Dim objLogicaReportes As New ReportesVariados_BLL
    '        Dim ht As New Hashtable

    '        Me.Cursor = Cursors.WaitCursor
    '        ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
    '        ht.Add("CDVSN", cmbDivision.Division)
    '        ht.Add("CPLNDV", cboPlanta.SelectedValue)
    '        If ctlCliente.pCodigo.Equals("") Then
    '            ht.Add("CCLNT", 0)
    '        Else
    '            ht.Add("CCLNT", CInt(Me.ctlCliente.pCodigo))
    '        End If
    '        ht.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
    '        ht.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))
    '        ht.Add("STATUS", "")

    '        dst = objLogicaReportes.ReporteOperacionesPorGuiaTR(ht)

    '        If dst.Tables.Count > 0 Then
    '            dst.Tables(0).TableName = "dtmovOperaciones"
    '        End If
    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '    End Try
    '    Return dst
    'End Function

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_ST
            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("NOPRCN").Caption = NPOI.FormatDato("N° Operación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCRVTA").Caption = NPOI.FormatDato("Región de Venta", HelpClass_NPOI_ST.keyDatoTexto)

            dtResumen.Columns.Add("FECOST").Caption = NPOI.FormatDato("Fecha Solicitud", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FATNSR").Caption = NPOI.FormatDato("Fecha Atención Serv.", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FINCOP").Caption = NPOI.FormatDato("Fecha Operación", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FGUITR").Caption = NPOI.FormatDato("Fecha Guía Transporte", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FOPENTR_ADMIN").Caption = NPOI.FormatDato("Fecha Entrega" & Chr(10) & "a Administración", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FCHCRR").Caption = NPOI.FormatDato("Fecha Liquidación Flete", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FDCPRF").Caption = NPOI.FormatDato("Fecha Pre Factura", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FECFAC").Caption = NPOI.FormatDato("Fecha Factura", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FDOCENTR_NEGOCIO").Caption = NPOI.FormatDato("Fecha Entrega Doc." & Chr(10) & "A Negocio", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FENTCB").Caption = NPOI.FormatDato("Fecha Entrega Doc." & Chr(10) & "A Cobranza", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FENCBD").Caption = NPOI.FormatDato("Fecha Entrega Doc." & Chr(10) & "A Cobrador", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FENTCL").Caption = NPOI.FormatDato("Fecha Entrega Doc." & Chr(10) & "A Cliente", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("ESTADO_NOPRCN").Caption = NPOI.FormatDato("Estado Operación", HelpClass_NPOI_ST.keyDatoTexto)

            dtResumen.Columns.Add("TPLNTA").Caption = NPOI.FormatDato("Planta", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NCSOTR").Caption = NPOI.FormatDato("N° Solicitud Transporte", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCMTRT").Caption = NPOI.FormatDato("Transportista", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NMNFCR").Caption = NPOI.FormatDato("N° Guía Transporte", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NGUIRM").Caption = NPOI.FormatDato("N° Guía Remitente", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NLQDCN").Caption = NPOI.FormatDato("N° Liquidación Flete", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NRFSAP").Caption = NPOI.FormatDato("N° Referencia SAP", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NLQCMB").Caption = NPOI.FormatDato("N° Liquidación Combustible", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CCLNT").Caption = NPOI.FormatDato("Cód.Cliente", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCMPCL").Caption = NPOI.FormatDato("Cliente", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NDCORM").Caption = NPOI.FormatDato("O / S Agencia", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NORSRT").Caption = NPOI.FormatDato("Orden Servicio", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("ORIGEN").Caption = NPOI.FormatDato("Localidad Origen", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("DESTIN").Caption = NPOI.FormatDato("Localidad Destino", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NDCPRF").Caption = NPOI.FormatDato("Pre Factura", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPRLQD").Caption = NPOI.FormatDato("N° Pre Liquidación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TABTPD").Caption = NPOI.FormatDato("Tipo Documento", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NDCMFC").Caption = NPOI.FormatDato("N° Factura", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FECCRE").Caption = NPOI.FormatDato("Fecha Creación Factura", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("MNDCO").Caption = NPOI.FormatDato("Moneda Cobrar", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("IMPCO").Caption = NPOI.FormatDato("Tarifa cobrar", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("TC_COBRAR").Caption = NPOI.FormatDato("T.C Cobrar", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("IMPCO_SOLES").Caption = NPOI.FormatDato("Tarifa cobrar (S/.)", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("MNDPA").Caption = NPOI.FormatDato("Moneda Pagar", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("IMPPA").Caption = NPOI.FormatDato("Tarifa pagar", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("TC_PAGAR").Caption = NPOI.FormatDato("T.C pagar", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("IMPPA_SOLES").Caption = NPOI.FormatDato("Tarifa pagar (S/.)", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("GASTOS").Caption = NPOI.FormatDato("Importe de Gastos", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("GASTOAVC").Caption = NPOI.FormatDato("Importe AVC", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("IMPORTE_NETO").Caption = NPOI.FormatDato("Importe Neto", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("MARGEN").Caption = NPOI.FormatDato("Margen(%)", HelpClass_NPOI_ST.keyDatoMonto)
            dtResumen.Columns.Add("NORINS").Caption = NPOI.FormatDato("N° Orden Interna", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CCNCST").Caption = NPOI.FormatDato("Ce. Co.", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CCNBNS").Caption = NPOI.FormatDato("Ce. Be.", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TRFRN").Caption = NPOI.FormatDato("Usuario Solicitante", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("MMCUSR").Caption = NPOI.FormatDato("Usuario Creador", HelpClass_NPOI_ST.keyDatoTexto)

            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).Value
                Next
                dtResumen.Rows.Add(dr)
            Next

            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "Seguimiento Operación"
            oListDtReport.Add(dtResumen.Copy)


            Dim lstrPeriodo As String = ""
            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            'Dim itemSortedList As SortedList
            ListTitulo.Add("SEGUIMIENTO INTERNO DE OPERACIONES" & lstrPeriodo)


            NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
