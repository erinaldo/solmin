Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmMovMensualOper

    Private dstGeneral As New DataSet()
    'Private bolBuscar As Boolean = False
    Private _lstrTipoCuenta As String
    Private oDtEstado As DataTable
    Private oDtTipoViaje As DataTable
    Private ht As New Hashtable

    Private Sub Cargar_Region_Venta()
        'Try
        Dim objLogica As New ReportesVariados_BLL
        'Me.cboRegionVenta.DataSource = objLogica.Lista_Region_Venta(Me.cmbCompania.SelectedValue)
        Me.cboRegionVenta.DataSource = objLogica.Lista_Region_Venta(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboRegionVenta.ValueMember = "CODIGO"
        Me.cboRegionVenta.DisplayMember = "REGION"
        Me.cboRegionVenta.SelectedValue = "0"
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub frmMovMensualOper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Alinear_Columnas_Grilla()
            'Me.cargarComboCompania()
            Me.Cargar_Compania()
            Me.Carga_MedioTransporte()
            Me.CargarEstado()
            Me.CargarTipoViaje()
            Me.cmbViaje.SelectedItem = "TODOS"
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            Me.txtTransportista.pCargar(obeTracto)
            Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
            Me.cargarComboPlanta()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        oDr.Item(1) = "TODOS"
        oDr.Item(2) = 0
        oDr.Item(0) = "1"
        oDr.Item(3) = "TO"
        'oDr.Item(2) = "TO"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "PENDIENTE"
        oDr.Item(2) = 0
        oDr.Item(0) = "2"
        oDr.Item(3) = "P"
        'oDr.Item(2) = "PE"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "ASIGNADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "3"
        oDr.Item(3) = "A"
        ' oDr.Item(2) = "AS"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "PRE - FACTURADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "4"
        oDr.Item(3) = "F"
        ' oDr.Item(2) = "FA"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "FACTURADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "5"
        oDr.Item(3) = "F"
        ' oDr.Item(2) = "FA"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "CERRADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "6"
        oDr.Item(3) = "C"
        ' oDr.Item(2) = "CE"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "ANULADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "7"
        oDr.Item(3) = "*"
        ' oDr.Item(2) = "AN"
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
        oDr.Item(3) = "T"
        oDr.Item(2) = 0
        oDr.Item(1) = "TODOS"
        oDr.Item(0) = "1"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item(3) = "E"
        oDr.Item(2) = 0
        oDr.Item(1) = "EXCLUSIVO"
        oDr.Item(0) = "2"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item(3) = "R"
        oDr.Item(2) = 0
        oDr.Item(1) = "REPARTO"
        oDr.Item(0) = "3"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item(3) = "M"
        oDr.Item(2) = 0
        oDr.Item(1) = "MULTIMODAL"
        oDr.Item(0) = "4"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item(3) = "C"
        oDr.Item(2) = 0
        oDr.Item(1) = "CONSOLIDADO"
        oDr.Item(0) = "5"
        oDtTipoViaje.Rows.Add(oDr)

        oDr = oDtTipoViaje.NewRow
        oDr.Item(3) = "P"
        oDr.Item(2) = 0
        oDr.Item(1) = "PASAJERO"
        oDr.Item(0) = "6"
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
        'Try
        'If (bolBuscar = True And cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
        '    bolBuscar = False
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
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub InicializarFormulario()
        gwdDatos.DataSource = Nothing
        ctlCliente.pClear()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    End Sub

    'revisar mañana temprano 2012.05.23----URGENTE
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
            'HelpClass.ErrorMsgBox()
            'ClearMemory()
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
        If cmbViaje.SelectedItem = "TODOS" Then
            strAcVehicular = "TO"
        ElseIf cmbViaje.SelectedItem = "SI" Then
            strAcVehicular = "SI"
        ElseIf cmbViaje.SelectedItem = "NO" Then
            strAcVehicular = "NO"
        Else
            strAcVehicular = "NO"
        End If
        ht.Add("SSINVJ", strAcVehicular)
        ht.Add("PSREGION", Me.cboRegionVenta.SelectedValue)

        REM ECM-HUNDRED-INICIO
        If ctlClienteFact.pCodigo.Equals("") Then
            ht.Add("CCLNT", 0)
        Else
            ht.Add("CCLNF", Convert.ToInt32(Me.ctlClienteFact.pCodigo))
        End If
        REM ECM-HUNDRED-FIN
    End Sub

    'Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
    '    Try
    '        Dim objLogicaReportes As New ReportesVariados_BLL
    '        e.Result = objLogicaReportes.frptMovimientoOperaciones(ht)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dstreporte As New DataSet
            Dim dt As DataTable
            dstreporte = CType(e.Result, DataSet)
            dt = dstreporte.Tables(0)
            dt.Columns.Add("IMPCO_SOLES", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPPA_SOLES", Type.GetType("System.Decimal"))
            dt.Columns.Add("IMPTI_SOLES", Type.GetType("System.Decimal"))

            'IMPTI
            dt.Columns.Add("IMPORTE_NETO", Type.GetType("System.Decimal"))
            dt.Columns.Add("MARGEN", Type.GetType("System.Decimal"))


            dt.Columns.Add("CO_SOLO_FLETE_SOL", Type.GetType("System.Decimal"))
            dt.Columns.Add("CO_OT_FLETE_SOL", Type.GetType("System.Decimal"))

            dt.Columns.Add("TI_SOLO_FLETE_SOL", Type.GetType("System.Decimal"))
            dt.Columns.Add("TI_OT_FLETE_SOL", Type.GetType("System.Decimal"))

            dt.Columns.Add("PA_SOLO_FLETE_SOL", Type.GetType("System.Decimal"))
            dt.Columns.Add("PA_OT_FLETE_SOL", Type.GetType("System.Decimal"))
            'CREANDO LAS NUEVAS COLUMNAS
            dt.Columns.Add("USRAPR_OS_FCHAPR_OS_HRAAPR_OS", Type.GetType("System.String"))


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
                dt.Rows(x)("CTPOVJ") = Descripcion_Tipo_Viaje(dt.Rows(x)("CTPOVJ").ToString)

                dt.Rows(x)("FDSGDC") = HelpClass.CFecha_de_8_a_10(("" & dstreporte.Tables(0).Rows(x)("FDSGDC")).ToString.Trim)
                dt.Rows(x)("HDSGDC") = HelpClass.HoraNum_a_Hora_Default(("" & dstreporte.Tables(0).Rows(x)("HDSGDC")).ToString.Trim)


                dt.Rows(x)("FCH_INICIO_TRASLADO") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCH_INICIO_TRASLADO").ToString)
                dt.Rows(x)("FCH_ESTIMADA_SALIDA") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCH_ESTIMADA_SALIDA").ToString)
                dt.Rows(x)("FCH_ESTIMADA_LLEGADA") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCH_ESTIMADA_LLEGADA").ToString)
                dt.Rows(x)("FCH_REAL_SALIDA") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCH_REAL_SALIDA").ToString)
                dt.Rows(x)("FCH_REAL_LLEGADA") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCH_REAL_LLEGADA").ToString)
                dt.Rows(x)("FCHTARINT") = HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCHTARINT").ToString)


                If dt.Rows(x)("ID_MNDCO") = 100 Then
                    dt.Rows(x)("IMPCO_SOLES") = Math.Round(dt.Rows(x)("IMPCO") * dt.Rows(x)("TC_COBRAR"), 2)

                    'SOLO FLETE A SOLES
                    dt.Rows(x)("CO_SOLO_FLETE_SOL") = Math.Round(dt.Rows(x)("CO_SOLO_FLETE") * dt.Rows(x)("TC_COBRAR"), 2)
                    dt.Rows(x)("CO_OT_FLETE_SOL") = Math.Round(dt.Rows(x)("CO_OT_FLETE") * dt.Rows(x)("TC_COBRAR"), 2)

                Else
                    dt.Rows(x)("IMPCO_SOLES") = dt.Rows(x)("IMPCO")
                    'SOLO FLETE A SOLES
                    dt.Rows(x)("CO_SOLO_FLETE_SOL") = dt.Rows(x)("CO_SOLO_FLETE")
                    dt.Rows(x)("CO_OT_FLETE_SOL") = dt.Rows(x)("CO_OT_FLETE")
                End If

                If dt.Rows(x)("ID_MNDPA") = 100 Then
                    dt.Rows(x)("IMPPA_SOLES") = Math.Round(dt.Rows(x)("IMPPA") * dt.Rows(x)("TC_PAGAR"), 2)

                    'OTROS SERVICIOS A SOLES
                    dt.Rows(x)("PA_SOLO_FLETE_SOL") = Math.Round(dt.Rows(x)("PA_SOLO_FLETE") * dt.Rows(x)("TC_PAGAR"), 2)
                    dt.Rows(x)("PA_OT_FLETE_SOL") = Math.Round(dt.Rows(x)("PA_OT_FLETE") * dt.Rows(x)("TC_PAGAR"), 2)

                Else
                    dt.Rows(x)("IMPPA_SOLES") = dt.Rows(x)("IMPPA")

                    'OTROS SERVICIOS A SOLES
                    dt.Rows(x)("PA_SOLO_FLETE_SOL") = dt.Rows(x)("PA_SOLO_FLETE")
                    dt.Rows(x)("PA_OT_FLETE_SOL") = dt.Rows(x)("PA_OT_FLETE")
                End If

                If dt.Rows(x)("CMNDTI") = 100 Then
                    dt.Rows(x)("IMPTI_SOLES") = Math.Round(dt.Rows(x)("IMPTI") * dt.Rows(x)("TC_TARIFAINT"), 2)

                    'OTROS SERVICIOS A SOLES
                    dt.Rows(x)("TI_SOLO_FLETE_SOL") = Math.Round(dt.Rows(x)("TI_SOLO_FLETE") * dt.Rows(x)("TC_TARIFAINT"), 2)
                    dt.Rows(x)("TI_OT_FLETE_SOL") = Math.Round(dt.Rows(x)("TI_OT_FLETE") * dt.Rows(x)("TC_TARIFAINT"), 2)
                Else
                    dt.Rows(x)("IMPTI_SOLES") = dt.Rows(x)("IMPTI")

                    'OTROS SERVICIOS A SOLES
                    dt.Rows(x)("TI_SOLO_FLETE_SOL") = dt.Rows(x)("TI_SOLO_FLETE")
                    dt.Rows(x)("TI_OT_FLETE_SOL") = dt.Rows(x)("TI_OT_FLETE")
                End If

                'dt.Rows(x)("IMPORTE_NETO") = dt.Rows(x)("IMPCO_SOLES") - (dt.Rows(x)("IMPPA_SOLES") + dt.Rows(x)("GASTOAVC") + dt.Rows(x)("COSTO") + dt.Rows(x)("GASTOS") + dt.Rows(x)("IGSTOPCN") + dt.Rows(x)("IGSTOPCM"))
                dt.Rows(x)("IMPORTE_NETO") = dt.Rows(x)("IMPCO_SOLES") - (dt.Rows(x)("IMPPA_SOLES") + dt.Rows(x)("GASTOAVC") + dt.Rows(x)("COSTO") + dt.Rows(x)("GASTOS"))

                If dt.Rows(x)("IMPCO_SOLES") <> 0 Then
                    dt.Rows(x)("MARGEN") = (dt.Rows(x)("IMPORTE_NETO") / dt.Rows(x)("IMPCO_SOLES")) * 100
                Else
                    dt.Rows(x)("MARGEN") = 100
                End If
                'Agregar ------------------------------- los campos
                dt.Rows(x)("USRAPR_OS_FCHAPR_OS_HRAAPR_OS") = dt.Rows(x)("USRAPR_OS").ToString.Trim & " " & HelpClass.CFecha_de_8_a_10(dt.Rows(x)("FCHAPR_OS").ToString) & " " & HelpClass.HoraNum_a_Hora_Default(dt.Rows(x)("HRAAPR_OS").ToString.Trim)
                dt.Rows(x)("FCHENA_OP") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCHENA_OP").ToString.Trim)
                dt.Rows(x)("FCHAPR_OP") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCHAPR_OP").ToString.Trim)
                dt.Rows(x)("FCH_RCPDOC") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCH_RCPDOC").ToString.Trim)
                dt.Rows(x)("FCH_DEVDOC") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCH_DEVDOC").ToString.Trim)
                dt.Rows(x)("TOBS_OP") = (dstreporte.Tables(0).Rows(x)("TOBS_OP").ToString.Trim)

                dt.Rows(x)("UATAOP") = (dstreporte.Tables(0).Rows(x)("UATAOP").ToString.Trim)
                dt.Rows(x)("USLAOP") = (dstreporte.Tables(0).Rows(x)("USLAOP").ToString.Trim)
                dt.Rows(x)("MOTAOP") = (dstreporte.Tables(0).Rows(x)("MOTAOP").ToString.Trim)
                dt.Rows(x)("REEMPLAZO_OP") = (dstreporte.Tables(0).Rows(x)("REEMPLAZO_OP").ToString.Trim)
                dt.Rows(x)("OBSAOP") = (dstreporte.Tables(0).Rows(x)("OBSAOP").ToString.Trim)


                dt.Rows(x)("FECHA_PT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECHA_PT").ToString.Trim)
                dt.Rows(x)("FECHAAP_PT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECHAAP_PT").ToString.Trim)

                'Codigo agregado por MREATEGUIP - Ajuste Moneda
                '----- Ini -----
                dt.Rows(x)("FCH_FIN_TRASLADO_GT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCH_FIN_TRASLADO_GT").ToString.Trim)
                '----- Fin -----
            Next
            Me.gwdDatos.DataSource = dt
            dstGeneral = dstreporte
        Catch ex As Exception
            'ClearMemory()
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
    End Sub

    Private Function Datos_Reporte_Operaciones_Transporte_por_OrdenDeCompra() As DataSet
        Dim dst As New DataSet
        'Try
        Dim objcoleccion As New Collection
        Dim objLogicaReportes As New ReportesVariados_BLL
        Dim ht As New Hashtable

        'Me.Cursor = Cursors.WaitCursor
        ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        ht.Add("CDVSN", cmbDivision.Division)
        ht.Add("CPLNDV", cboPlanta.SelectedValue)
        If ctlCliente.pCodigo.Equals("") Then
            ht.Add("CCLNT", 0)
        Else
            ht.Add("CCLNT", CInt(Me.ctlCliente.pCodigo))
        End If
        ht.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
        ht.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))
        ht.Add("STATUS", "")

        dst = objLogicaReportes.ReporteOperacionesPorGuiaTR(ht)

        If dst.Tables.Count > 0 Then
            dst.Tables(0).TableName = "dtmovOperaciones"
        End If
      
        Return dst
    End Function
   

    Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & intCantRuta.ToString))
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & intCantPasajero.ToString))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Mensual de Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Mensual de Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE MENSUAL DE OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

            For Each dr As DataRow In objDt.Rows
                dr("NORCML") = dr("NORCML").ToString.Replace(",", "," + Chr(10)).ToString
                dr.AcceptChanges()
            Next
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "NORCML", "NOPRCN", "NPLVHT", "NPLCAC", "NMNFCR", "NGUITR", "CCNCST", "CCNBNS", "NLQDCN"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "PBRTOR", "PTRAOR", "PNETO", "IMPCO", "IMPCO_SOLES", "IMPPA", _
                         "IMPPA_SOLES", "GASTOS", "GASTOAVC", "QGLNCM", "COSTO", "IMPORTE_NETO", "MARGEN", "GASTOAVC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                    Case "TC_COBRAR", "TC_PAGAR"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Select Case Me.ctlCliente.pCodigo
                Case 1139
                    Me.Generar_Reporte_Primax()
                Case Else
                    Me.Generar_Reporte_Crystal()
            End Select
            'Catch : End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Generar_Reporte_Primax()

        If gwdDatos.Rows.Count <= 0 Then
            MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim dstreporte As New DataSet

        dstreporte = dstGeneral.Copy() 'Datos_Reporte_Operaciones_Transporte()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        'Try
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptMovOperacionesTR
        'Parametros internos del reporte
        dstreporte.Tables(0).TableName = "dtMovOperaciones"
        dstreporte.Tables(1).TableName = "dtResumenAcoplados"
        dstreporte.Tables(2).TableName = "dtResumenEstadoTMP"

        ' Dim oDt As New DataTable
        '  oDt = ObtenerEstadosOperacion.Copy()
        oDtEstado.Rows.RemoveAt(0) 'ELIMINAMOS EL PRIMER ESTADO ---> "TODOS"
        'Pasamos los estados obtenidos a la tabla general de todos los estados
        For item1 As Integer = 0 To dstreporte.Tables(2).Rows.Count - 1
            For item2 As Integer = 0 To oDtEstado.Rows.Count - 1
                If (dstreporte.Tables(2).Rows(item1).Item("ESTADO_NOPRCN") = oDtEstado.Rows(item2).Item("ESTADO_NOPRCN")) Then
                    oDtEstado.Rows(item2).Item("NROUNI") = dstreporte.Tables(2).Rows(item1).Item("NROUNI")
                End If
            Next
        Next
        ' Si todo esta Ok... cargamos el reporte de los movimientos de operaciones
        objReporte.SetDataSource(dstreporte.Tables(0))
        objReporte.Subreports.Item("rptResumenAcoplados").SetDataSource(dstreporte.Tables(1))
        objReporte.Subreports.Item("rptResumenAcopladosGrafico").SetDataSource(dstreporte.Tables(1))
        objReporte.Subreports.Item("rptResumenEstadoOperacion").SetDataSource(oDtEstado.Copy())
        objReporte.Subreports.Item("rptResumenEstadoTotales").SetDataSource(oDtEstado.Copy())
        objReporte.Refresh()
        objReporte.SetParameterValue("pCliente", Me.ctlCliente.pCodigo)
        objReporte.SetParameterValue("pFechaOperacionInicial", Me.dtpFechaInicio.Text)
        objReporte.SetParameterValue("pFechaOperacionFinal", Me.dtpFechaFin.Text)
        CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text

        objPrintForm.ShowForm(objReporte, Me)
        'Catch ex As Exception
        '    HelpClass.ErrorMsgBox()
        '    ClearMemory()
        'End Try
    End Sub
    Private Sub Generar_Reporte_Crystal()

        If gwdDatos.Rows.Count <= 0 Then
            MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim dstreporte As New DataSet
        dstreporte = dstGeneral.Copy() 'Datos_Reporte_Operaciones_Transporte()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        'Try
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptMovOperacionesTR
        'Parametros internos del reporte
        dstreporte.Tables(0).TableName = "dtMovOperaciones"
        dstreporte.Tables(1).TableName = "dtResumenAcoplados"
        dstreporte.Tables(2).TableName = "dtResumenEstadoTMP"

        ' Dim oDt As New DataTable
        '  oDt = ObtenerEstadosOperacion.Copy()
        'oDt.Rows.RemoveAt(0) 'ELIMINAMOS EL PRIMER ESTADO ---> "TODOS"
        'Pasamos los estados obtenidos a la tabla general de todos los estados
        'For item1 As Integer = 0 To dstreporte.Tables(2).Rows.Count - 1
        '  For item2 As Integer = 0 To oDt.Rows.Count - 1
        '    If (dstreporte.Tables(2).Rows(item1).Item("ESTADO_NOPRCN") = oDt.Rows(item2).Item("ESTADO_NOPRCN")) Then
        '      oDt.Rows(item2).Item("NROUNI") = dstreporte.Tables(2).Rows(item1).Item("NROUNI")
        '    End If
        '  Next
        'Next
        ' Si todo esta Ok... cargamos el reporte de los movimientos de operaciones
        objReporte.SetDataSource(dstreporte.Tables(0).Copy)
        objReporte.Subreports.Item("rptResumenAcoplados").SetDataSource(dstreporte.Tables(1).Copy)
        objReporte.Subreports.Item("rptResumenAcopladosGrafico").SetDataSource(dstreporte.Tables(1).Copy)
        objReporte.Subreports.Item("rptResumenEstadoOperacion").SetDataSource(dstreporte.Tables(2).Copy) 'oDT.Copy())
        objReporte.Subreports.Item("rptResumenEstadoTotales").SetDataSource(dstreporte.Tables(2).Copy) 'oDt.Copy())
        objReporte.Refresh()
        objReporte.SetParameterValue("pCliente", Me.ctlCliente.pCodigo)
        objReporte.SetParameterValue("pFechaOperacionInicial", Me.dtpFechaInicio.Text)
        objReporte.SetParameterValue("pFechaOperacionFinal", Me.dtpFechaFin.Text)
        CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text

        objPrintForm.ShowForm(objReporte, Me)
        'Catch ex As Exception
        '    HelpClass.ErrorMsgBox()
        '    ClearMemory()
        'End Try
    End Sub
    Private Sub Generar_Reporte_por_OC()
        Dim dstreporte As New DataSet
        dstreporte = Datos_Reporte_Operaciones_Transporte_por_OrdenDeCompra()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        'Try
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptMovOperacionesOrdenCompraTR
        'Parametros internos del reporte
        dstreporte.Tables(0).TableName = "dtMovOperaciones"
        objReporte.SetDataSource(dstreporte.Tables(0))
        objReporte.Refresh()
        objReporte.SetParameterValue("pCliente", Me.ctlCliente.pCodigo)
        objReporte.SetParameterValue("pFechaOperacionInicial", Me.dtpFechaInicio.Text)
        objReporte.SetParameterValue("pFechaOperacionFinal", Me.dtpFechaFin.Text)
        CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text

        objPrintForm.ShowForm(objReporte, Me)
        'Catch ex As Exception
        '    HelpClass.ErrorMsgBox()
        '    ClearMemory()
        'End Try
    End Sub
    Private Sub btnReporteOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteOC.Click
        Try
            Generar_Reporte_por_OC()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub txtPreLiquidacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreLiquidacion.KeyPress, txtNroOperacion.KeyPress, txtAgenciaRansa.KeyPress, txtPreFactura.KeyPress, txtOrdenInterna.KeyPress
    '  If IsNumeric(e.KeyChar) = False Then
    '    e.Handled = True
    '    Exit Sub
    '  End If

    '  If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    'End Sub

    Private Sub ctlCliente_InformationChanged() Handles ctlCliente.InformationChanged, ctlClienteFact.InformationChanged
        If Me.ctlCliente.pCodigo = 1139 Then
            Me.btnImprimir.Text = "Reporte Primax"
        End If
    End Sub
#Region "Planta"
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

        '  Me.cboTipoViajeChk.DataSource = dt.Copy
        Dim dtTipoViaje As New DataTable
        dtTipoViaje = cboTipoViajeChk.DataSource
        For i As Integer = 0 To cboTipoViajeChk.CheckedItems.Count - 1
            If (cboTipoViajeChk.CheckedItems(i).Value <> "1") Then
                For j As Integer = 0 To dtTipoViaje.Rows.Count - 1
                    If (dtTipoViaje.Rows(j).Item("VALUE") = cboTipoViajeChk.CheckedItems(i).Value) Then
                        strCodTipoViaje += dtTipoViaje.Rows(j).Item("VALUES_STRING") & ","
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

    Private Function Descripcion_Tipo_Viaje(ByVal strCTPOVJ As String) As String
        Dim strTipoViaje As String = ""
        Select Case strCTPOVJ
            Case "E"
                strTipoViaje = "EXCLUSIVO"
            Case "R"
                strTipoViaje = "REPARTO"
            Case "M"
                strTipoViaje = "MULTIMODAL"
            Case "C"
                strTipoViaje = "CONSOLIDADO"
            Case "P"
                strTipoViaje = "PASAJERO"
        End Select
        Return strTipoViaje
    End Function

#End Region

End Class
