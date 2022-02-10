Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmConsultaNotaCredito

    Private dstGeneral As New DataSet()
    'Private bolBuscar As Boolean = False
    Private _lstrTipoCuenta As String
    Private oDtEstado As DataTable
    Private oDtTipoViaje As DataTable
    Private ht As New Hashtable

    Private Sub frmConsultaNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Alinear_Columnas_Grilla()
            Me.Cargar_Compania()
            Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
            Me.cargarComboPlanta()
            Cargar_Tipo_Documento()
        Catch : End Try

    End Sub

    Private Sub Cargar_Tipo_Documento()
        Dim objTipoDocumento_BLL As New TipoDocumento_BLL
        Dim objEntidad As New TipoDocumento
        Dim dt As DataTable
        Dim DR() As DataRow
        Dim DtDocumento As DataTable
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        dt = objTipoDocumento_BLL.Listar_Tipo_Documentos_Para_Refacturar(objEntidad)
        DtDocumento = dt.Clone
        DR = dt.Select("CTPODC <> 2")
        For Each DRR As DataRow In DR
            DtDocumento.ImportRow(DRR)
        Next
        Me.cmbTipoDoc.DataSource = DtDocumento
        Me.cmbTipoDoc.DisplayMember = "TCMTPD"
        Me.cmbTipoDoc.ValueMember = "CTPODC"
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""
        Try
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InicializarFormulario()
        gwdDatos.DataSource = Nothing
        ctlCliente.pClear()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    End Sub

    'revisar mañana temprano 2012.05.23----URGENTE
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
            HelpClass.ErrorMsgBox()
            ClearMemory()
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub PrepararProceesWorked(ByRef boolEstado As Boolean)
        'boolEstado = True 'ValidarFiltroFecha()
        'If boolEstado = True Then Exit Sub
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
        ht.Add("CTPDCF", Me.cmbTipoDoc.SelectedValue)
        If Me.txtNDocumento.Text.Trim.Equals("") Then
            ht.Add("NDCMFC", 0)
        Else
            ht.Add("NDCMFC", Convert.ToDouble(Me.txtNDocumento.Text.Trim))
        End If
        If Me.chkFecha.Checked = True Then
            ht.Add("FECINI", Format(dtpFechaInicio.Value, "yyyyMMdd"))
            ht.Add("FECFIN", Format(dtpFechaFin.Value, "yyyyMMdd"))
        Else
            ht.Add("FECINI", 0)
            ht.Add("FECFIN", 0)
        End If

    End Sub

    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim objLogicaReportes As New ReportesVariados_BLL

        If ht.Item("CTPDCF") = 1 OrElse ht.Item("CTPDCF") = 51 Then 'CSR-HUNDRED-280916-ADICIONAR NC ELECTRONICA-GUIAS PACASMAYO
            e.Result = objLogicaReportes.Reporte_Refacturacion_X_Operaciones_FC(ht)
        ElseIf ht.Item("CTPDCF") = 3 OrElse ht.Item("CTPDCF") = 53 Then 'CSR-HUNDRED-280916-ADICIONAR NC ELECTRONICA-GUIAS PACASMAYO
            e.Result = objLogicaReportes.Reporte_Refacturacion_X_Operaciones_NC(ht)
        End If

    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dtResult As DataTable = e.Result
            Dim lintDocumento As Int32 = 0

            For x As Integer = 0 To dtResult.Rows.Count - 1
                If dtResult.Rows(x)("NDCMNC") = lintDocumento Then
                    dtResult.Rows(x)("FECFNC") = ""
                    dtResult.Rows(x)("NDCMNC") = ""
                    dtResult.Rows(x)("CCLNT") = ""
                    dtResult.Rows(x)("TCMPCL") = ""
                    dtResult.Rows(x)("ITCCTC") = ""
                    dtResult.Rows(x)("MNDANC") = ""
                    dtResult.Rows(x)("VVNTNC") = ""
                Else
                    dtResult.Rows(x)("FECFNC") = HelpClass.CFecha_de_8_a_10(dtResult.Rows(x)("FECFNC").ToString)
                    lintDocumento = dtResult.Rows(x)("NDCMNC")
                    dtResult.Rows(x).Item("VVNTNC") = Format(Convert.ToDouble(dtResult.Rows(x).Item("VVNTNC")), "###,###,###,###.00")
                End If

                dtResult.Rows(x).Item("VVNTFO") = Format(Convert.ToDouble(dtResult.Rows(x).Item("VVNTFO")), "###,###,###,###.00")
                dtResult.Rows(x)("FINCOP") = HelpClass.CFecha_de_8_a_10(dtResult.Rows(x)("FINCOP").ToString)
                dtResult.Rows(x)("FDCMOR") = HelpClass.CFecha_de_8_a_10(dtResult.Rows(x)("FDCMOR").ToString)
                dtResult.Rows(x)("FECRFC") = HelpClass.CFecha_de_8_a_10(dtResult.Rows(x)("FECRFC").ToString)
            Next
            Me.gwdDatos.DataSource = dtResult
        Catch ex As Exception
            ClearMemory()
        End Try
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
    End Sub

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
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Refacturación"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Refacturación"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE REFACTURACÍON"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "FECFAC", "FINCOP", "FDCMOR"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "VVNTNC", "VVNTFC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                        'Case "TC_COBRAR", "TC_PAGAR"
                        ' dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtNDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNDocumento.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

#Region "Planta"
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
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
        If chkFecha.Checked Then
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        Else
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub Limpiar()
        InicializarFormulario()
    End Sub
#End Region
End Class
