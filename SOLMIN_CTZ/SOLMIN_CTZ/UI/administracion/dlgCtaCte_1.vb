Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Cliente
Imports Ransa.Controls.Cliente
Imports Ransa.DAO.Cliente

Public Class dlgCtaCte
    Private oMoneda As New SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oCuentaCorrienteNeg As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
    Private oCuentaCorriente As New SOLMIN_CTZ.Entidades.CuentaCorriente
    Private oTipoDocumento As New SOLMIN_CTZ.NEGOCIO.clsTipoDocumento

    Private oDtPlanta As New DataTable
    Private oDtRegionVenta As New DataTable
    Private oDtTiposDocumentos As New DataTable

    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private srtListaDescPlanta As String
    Private srtListaDescRegionVenta As String
    Private strMoneda As String

    Private Sub dlgCtaCte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Negocio
        'oCuentaCorrienteNeg = New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        'oCuentaCorriente = New SOLMIN_CTZ.Entidades.CuentaCorriente
        'Moneda
        'oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        'CheckBox
        'Me.cbFechas.CheckPosition = VisualOrientation.Right
        'Cargar Cliente
        'ucCliente.CCMPN = Me.txtCodCompania.Text
        Try
            oPlanta = New clsPlanta
            oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
            oDivision = New clsDivision
            oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
            oCompania = New clsCompania
            oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy

            Cargar_Compania()

            cbFechas.Checked = True
            'Cargar Moneda
            Cargar_Moneda()
            'Clase
            Cargar_Clase()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New clsRegionVenta
        oRegionVenta.Crea_Lista()

        oDtRegionVenta = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        oDtRegionVenta.Columns.Remove("CCMPN")
        cmbRegionVenta.ValueMember = "CRGVTA"
        cmbRegionVenta.DisplayMember = "TCRVTA"
        cmbRegionVenta.DataSource = oDtRegionVenta

        For j As Integer = 0 To Me.cmbRegionVenta.Items.Count - 1
            If cmbRegionVenta.Items.Item(j).Value = "-1" Then
                cmbRegionVenta.SetItemChecked(j, True)
            End If
        Next
    End Sub

    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
    End Sub
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

        Cargar_Region_Venta()
    End Sub


    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        oDtPlanta = oPlanta.Lista_Planta_Division(obeDivision.CCMPN_CodigoCompania, obeDivision.CDVSN_CodigoDivision)
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
    End Sub


    Private Sub Cargar_Moneda()
        Dim dtMoneda As New DataTable
        oMoneda.Crea_Moneda()
        dtMoneda = oMoneda.Lista_Moneda_x_All(1)
        Dim dtMonedaRep As New DataTable
        dtMonedaRep = dtMoneda.Copy
        dtMonedaRep.Rows.Clear()
        Dim Fila As Int32 = 0
        For Each Item As DataRow In dtMoneda.Rows
            If Item("CMNDA1") = 1 OrElse Item("CMNDA1") = 100 Then
                dtMonedaRep.ImportRow(Item)
                Fila = dtMonedaRep.Rows.Count - 1
                dtMonedaRep.Rows(Fila)("TMNDA") = dtMonedaRep.Rows(Fila)("CMNDA1") & " - " & ("" & dtMonedaRep.Rows(Fila)("TMNDA")).ToString.Trim
            End If
        Next
        cmbMoneda.DataSource = dtMonedaRep
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DisplayMember = "TMNDA"
        cmbMoneda.SelectedValue = 1
    End Sub
    Private Sub Cargar_Clase()
        'V(-Ventas)
        'T - Parte Transferencia

        Dim dtTipo As New DataTable
        dtTipo.Columns.Add("VALUE")
        dtTipo.Columns.Add("DISPLAY")

        Dim dr As DataRow
        dr = dtTipo.NewRow
        dr("VALUE") = "V"
        dr("DISPLAY") = "VENTAS"
        dtTipo.Rows.Add(dr)

        dr = dtTipo.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "TRANSFERENCIA"
        dtTipo.Rows.Add(dr)

        For Each Item As DataRow In dtTipo.Rows
            Item("DISPLAY") = Item("VALUE") & " - " & Item("DISPLAY")
        Next

        cmbClase.DataSource = dtTipo
        cmbClase.DisplayMember = "DISPLAY"
        cmbClase.ValueMember = "VALUE"
        cmbClase.SelectedValue = "V"

        'cmbClase.Items.Clear()
        'cmbClase.Items.Add("V - Ventas")
        'cmbClase.Items.Add("T - Parte Transferencia")
        'cmbClase.SelectedIndex = 0
    End Sub

    Private Sub cbFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFechas.CheckedChanged
        If cbFechas.Checked Then
            dtFechaFin.Enabled = True
            dtFechaInicio.Enabled = True
        Else
            dtFechaFin.Value = Date.Now
            dtFechaInicio.Value = Date.Now
            dtFechaFin.Enabled = False
            dtFechaInicio.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '  If Not (cmbMoneda.SelectedValue = 1 Or cmbMoneda.SelectedValue = 100) Then
    '    HelpClass.MsgBox("Solo Se Mostrara Reporte para Soles y Dolares", MessageBoxIcon.Information)
    '    Exit Sub
    '  End If
    '  Me.Hide()
    '  Try
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '    '-------------------------
    '    Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
    '    Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
    '    Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
    '    Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
    '    '-------------------------

    '    Dim frm As frmVisorVentas
    '    Dim frm2 As frmVisorVentasDetallado
    '    Dim frm3 As frmVisorVentasCentroCosto
    '    Dim objDt As DataTable
    '    Dim objDs As New DataSet

    '    Dim objCuentaCorriente As rptVentasGeneral
    '    Dim objReporteDetallado As rptVentasDetallado
    '    Dim objReporteCentroCosto As rptVentasCentroCosto

    '    Dim cadenaFechas As String

    '    oCuentaCorriente.PSCCMPN = txtCodCompania.Text
    '    oCuentaCorriente.PSCDVSN = IIf(txtCodDivision.Text = "*", "%", txtCodDivision.Text)
    '    oCuentaCorriente.CCLNT = IIf(ucCliente.pCodigo.ToString = "0", "-1", ucCliente.pCodigo)  'cmbCliente.SelectedValue
    '    oCuentaCorriente.CMNDA = cmbMoneda.SelectedValue
    '    oCuentaCorriente.CTPODC = cmbClase.SelectedIndex
    '          oCuentaCorriente.CPLNDV = txtCodPlanta.Text 'IIf(txtCodPlanta.Text = "*", "-1", txtCodPlanta.Text)
    '          oCuentaCorriente.CRGVTA = txtCodRegionVenta.Text 'IIf(txtCodRegionVenta.Text = "*", "-1", txtCodRegionVenta.Text)

    '    If cbFechas.Checked Then
    '      oCuentaCorriente.FechaInicio = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
    '      oCuentaCorriente.FechaFin = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
    '      cadenaFechas = "Desde: " & Me.dtFechaInicio.Text & "     Hasta: " & Me.dtFechaFin.Text & ""
    '    Else
    '      oCuentaCorriente.FechaInicio = "0"
    '      oCuentaCorriente.FechaFin = "90000000"
    '      cadenaFechas = "---Todas Las Fechas---"
    '    End If
    '    'Mantiene mi pantalla siempre adelante
    '    Me.BringToFront()
    '    'Verifica si es reporte Detallado , Resumido O POR cENTRO DE cOSTO
    '    If rbDetallado.Checked = True Then
    '      objReporteDetallado = New rptVentasDetallado
    '      objDt = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_Detallado(oCuentaCorriente)
    '      objDt.TableName = "dtVentasDetallado"
    '      objDs.Tables.Add(objDt.Copy)

    '      Dim objDtClienteResumen As New DataTable
    '      objDtClienteResumen = GeneraClienteResumen(objDt.Copy)
    '      objDtClienteResumen.TableName = "dtVentasDetClienteResumen"
    '      objDs.Tables.Add(objDtClienteResumen.Copy)

    '      objReporteDetallado.SetDataSource(objDs)
    '      '------------------------------------
    '      crParameterFieldDefinitions = objReporteDetallado.DataDefinition.ParameterFields
    '      crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
    '      crParameterValues = crParameterFieldLocation.CurrentValues
    '      crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
    '      crParameterDiscreteValue.Value = cadenaFechas
    '      crParameterValues.Add(crParameterDiscreteValue)
    '      crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
    '      '------------------------------------
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtCodCompania.Text & " - " & txtCompania.Text
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtDivision.Text
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtPlanta.Text
    '      If ucCliente.pCodigo = 0 Then
    '        CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "Todos"
    '      Else
    '        CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pRazonSocial
    '      End If
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = cmbMoneda.Text
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
    '      CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text

    '      frm2 = New frmVisorVentasDetallado(objReporteDetallado, objDt.Copy)
    '      frm2.MonedaFactura = Me.cmbMoneda.SelectedValue
    '      frm2.Tag = Me.cmbMoneda.Text.Trim
    '      'frm2.TopMost = True
    '      frm2.MdiParent = Me.MdiParent
    '      frm2.ShowDialog()
    '    End If
    '    If rbGeneral.Checked = True Then
    '      objCuentaCorriente = New rptVentasGeneral
    '      objDt = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_General(oCuentaCorriente)
    '      objDt.TableName = "dtVentasGeneral"
    '      objDs.Tables.Add(objDt.Copy)
    '      objCuentaCorriente.SetDataSource(objDs)
    '      '------------------------------------
    '      crParameterFieldDefinitions = objCuentaCorriente.DataDefinition.ParameterFields
    '      crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
    '      crParameterValues = crParameterFieldLocation.CurrentValues
    '      crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
    '      crParameterDiscreteValue.Value = cadenaFechas
    '      crParameterValues.Add(crParameterDiscreteValue)
    '      crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
    '      '------------------------------------
    '      frm = New frmVisorVentas(objCuentaCorriente)
    '      frm.MdiParent = Me.MdiParent
    '      frm.ShowDialog()
    '    End If

    '    If rbCentroCosto.Checked = True Then
    '      objReporteCentroCosto = New rptVentasCentroCosto
    '      objDt = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_CentroCosto(oCuentaCorriente)
    '      objDt.TableName = "dtVentasCentroCosto"
    '      objDs.Tables.Add(objDt.Copy)
    '      objReporteCentroCosto.SetDataSource(objDs)
    '      '------------------------------------
    '      crParameterFieldDefinitions = objReporteCentroCosto.DataDefinition.ParameterFields
    '      crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
    '      crParameterValues = crParameterFieldLocation.CurrentValues
    '      crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
    '      'objCuentaCorriente.DataDefinition.ParameterFields.Item("@CLIENTE").CurrentValues
    '      crParameterDiscreteValue.Value = cadenaFechas

    '      crParameterValues.Add(crParameterDiscreteValue)
    '      crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

    '      CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtCodCompania.Text & " - " & txtCompania.Text
    '      CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtDivision.Text
    '      CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtPlanta.Text
    '      If ucCliente.pCodigo = 0 Then
    '        CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "Todos"
    '      Else
    '        CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pRazonSocial
    '      End If
    '      'CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = cmbMoneda.Text
    '      CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
    '      CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
    '      '------------------------------------
    '      frm3 = New frmVisorVentasCentroCosto(objReporteCentroCosto)
    '      'frm.TopMost = True
    '      frm3.MdiParent = Me.MdiParent
    '      frm3.ShowDialog()
    '    End If

    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '  Catch ex As Exception
    '    MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '  End Try
    '  Me.Close()
    'End Sub
    Private Function GeneraClienteResumen(ByVal oDt As DataTable) As DataTable
        oDt.Columns.Remove("TCMTRF")
        oDt.Columns.Remove("IVLDCS")
        oDt.Columns.Remove("IVLDCD")
        'oDt.Columns.Remove("TCNTCS")
        'oDt.Columns.Remove("CCNCSD")
        Dim oDtClienteResumen As New DataTable
        FormatoRepClienteResumen(oDtClienteResumen)
        Dim iTemp As Integer = 0
        Dim dtv As New DataView(oDt)
        dtv.Sort = "CCLNT"
        Dim columnas(3) As String
        columnas(0) = "CCLNT"
        columnas(1) = "TCMPCL"
        columnas(2) = "ITTFCS"
        columnas(3) = "NDCCTC"
        oDt = dtv.ToTable(True, columnas)
        Dim iCambia As Boolean = True
        Dim filaNueva As DataRow
        Dim codCliente As Integer = 0
        For i As Integer = 0 To oDt.Rows.Count - 1

            If codCliente = oDt.Rows(i).Item("CCLNT") Then
                oDtClienteResumen.Rows(oDtClienteResumen.Rows.Count - 1).Item("ITTFCS") = oDtClienteResumen.Rows(oDtClienteResumen.Rows.Count - 1).Item("ITTFCS") + oDt.Rows(i).Item("ITTFCS")
            Else
                filaNueva = oDtClienteResumen.NewRow()
                filaNueva(0) = oDt.Rows(i).Item("CCLNT")
                filaNueva(1) = oDt.Rows(i).Item("TCMPCL")
                filaNueva(2) = oDt.Rows(i).Item("ITTFCS")
                oDtClienteResumen.Rows.Add(filaNueva)
                codCliente = oDt.Rows(i).Item("CCLNT")
            End If
        Next
        Dim dtv2 As New DataView(oDtClienteResumen)
        dtv2.Sort = "ITTFCS DESC"
        oDtClienteResumen = dtv2.ToTable()

        Dim oDtClienteResumen2 As New DataTable
        oDtClienteResumen2 = oDtClienteResumen.Clone

        For j As Integer = 0 To oDtClienteResumen.Rows.Count - 1
            If j < 25 Then
                oDtClienteResumen2.ImportRow(oDtClienteResumen.Rows(j))
            Else
                If iCambia = True Then
                    filaNueva = oDtClienteResumen2.NewRow
                    filaNueva(0) = 0
                    filaNueva(1) = "OTROS"
                    filaNueva(2) = oDtClienteResumen.Rows(j).Item("ITTFCS")
                    oDtClienteResumen2.Rows.Add(filaNueva)
                    iCambia = False
                Else
                    oDtClienteResumen2.Rows(oDtClienteResumen2.Rows.Count - 1).Item("ITTFCS") = oDtClienteResumen2.Rows(oDtClienteResumen2.Rows.Count - 1).Item("ITTFCS") + oDtClienteResumen.Rows(j).Item("ITTFCS")
                End If
            End If
        Next
        Dim total As Double = 0D
        For index As Integer = 0 To oDtClienteResumen2.Rows.Count - 1
            total = total + oDtClienteResumen2.Rows(index).Item("ITTFCS")
        Next
        For k As Integer = 0 To oDtClienteResumen2.Rows.Count - 1
            oDtClienteResumen2.Rows(k).Item("PORCENTAJE") = CStr(Format(100 * oDtClienteResumen2.Rows(k).Item("ITTFCS") / total, "###,###,###,##0.00")) & " %"
        Next
        Return oDtClienteResumen2
    End Function
    Private Sub FormatoRepClienteResumen(ByRef pobjDt As DataTable)
        'pobjDt = New DataTable
        pobjDt.Columns.Add(New DataColumn("CCLNT", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("TCMPCL", GetType(System.String)))
        pobjDt.Columns.Add(New DataColumn("ITTFCS", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("ITTFCD", GetType(System.Double)))
        pobjDt.Columns.Add(New DataColumn("PORCENTAJE", GetType(System.String)))
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
                strPlantas = "-1,"
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        Else
            strPlantas = "-1"
        End If
        Return strPlantas
    End Function

    Private Function Lista_RegionVenta() As String
        Dim strRegionVenta As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If (cmbRegionVenta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtRegionVenta.Rows.Count - 1
                    If (oDtRegionVenta.Rows(j).Item("CRGVTA") = cmbRegionVenta.CheckedItems(i).Value) Then
                        strRegionVenta += oDtRegionVenta.Rows(j).Item("CRGVTA") & ","
                    End If
                Next
            Else
                strRegionVenta = "-1,"
                Exit For
            End If
        Next
        If strRegionVenta.Trim.Length > 0 Then
            strRegionVenta = strRegionVenta.Trim.Substring(0, strRegionVenta.Trim.Length - 1)
        Else
            strRegionVenta = "-1"
        End If
        Return strRegionVenta
    End Function

    Private Function Lista_DescPlanta() As String
        Dim strPlantas As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            If (cmbPlanta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                    If (oDtPlanta.Rows(j).Item("TPLNTA") = cmbPlanta.CheckedItems(i).Name) Then
                        strPlantas += oDtPlanta.Rows(j).Item("TPLNTA").ToString.Trim & ","
                    End If
                Next
            Else
                strPlantas = "TODOS,"
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        Else
            strPlantas = "TODOS"
        End If

        Return strPlantas
    End Function

    Private Function Lista_DescRegionVenta() As String
        Dim strRegionVenta As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If (cmbRegionVenta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtRegionVenta.Rows.Count - 1
                    If (oDtRegionVenta.Rows(j).Item("TCRVTA") = cmbRegionVenta.CheckedItems(i).Name) Then
                        strRegionVenta += oDtRegionVenta.Rows(j).Item("TCRVTA").ToString.Trim & ", "
                    End If
                Next
            Else
                strRegionVenta = "TODOS,"
                Exit For
            End If
        Next
        If strRegionVenta.Trim.Length > 0 Then
            strRegionVenta = strRegionVenta.Trim.Substring(0, strRegionVenta.Trim.Length - 1)
        Else
            strRegionVenta = "TODOS"

        End If
        Return strRegionVenta
    End Function




    Private Sub btnAceptarRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarRep.Click
        Try
            If Not (cmbMoneda.SelectedValue = 1 Or cmbMoneda.SelectedValue = 100) Then
                MessageBox.Show("Sólo se mostrará reporte para Soles y Dólares", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.PictureBox1.Visible = True
            oCuentaCorriente.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            oCuentaCorriente.PSCDVSN = IIf(UcDivision.Division = "-1", "%", UcDivision.Division)
            oCuentaCorriente.CCLNT = IIf(ucCliente.pCodigo.ToString = "0", "-1", ucCliente.pCodigo)
            oCuentaCorriente.CMNDA = cmbMoneda.SelectedValue
            oCuentaCorriente.CTPODC = cmbClase.SelectedValue
            oCuentaCorriente.CPLNDV = Lista_Planta()
            oCuentaCorriente.CRGVTA = Lista_RegionVenta()
            Me.srtListaDescPlanta = Lista_DescPlanta()
            Me.srtListaDescRegionVenta = Lista_DescRegionVenta()
            Me.strMoneda = cmbMoneda.Text
            Me.BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrarRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarRep.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try

            Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
            Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
            Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
            Dim crParameterValues As CrystalDecisions.Shared.ParameterValues


            Dim objReporteDetallado As rptDetalleXClienteXRubroXCB
            Dim objReporteDetalladoXDocumento As rptDetalleXDocumento
            Dim objResumenXCliente As rptResumenXCliente
            Dim objResumenXRubro As rptResumenXRubro
            Dim objResumenXDivision As rptResumenXDivision
            Dim objResumenXCentroBeneficio As rptResumenXCentroBeneficio
            Dim objReporteCentroCosto As rptVentasCentroCosto
            Dim objDt As DataTable
            Dim objDs As New DataSet
            Dim oDataSet As DataSet
            Dim cadenaFechas As String



            If cbFechas.Checked Then
                oCuentaCorriente.FechaInicio = CType(dtFechaInicio.Text, DateTime).ToString("yyyyMMdd")
                oCuentaCorriente.FechaFin = CType(dtFechaFin.Text, DateTime).ToString("yyyyMMdd")
                cadenaFechas = "Desde: " & Me.dtFechaInicio.Text & "     Hasta: " & Me.dtFechaFin.Text & ""
            Else
                oCuentaCorriente.FechaInicio = "0"
                oCuentaCorriente.FechaFin = "99999999"
                'cadenaFechas = "---Todas Las Fechas---"
                cadenaFechas = ""
            End If

            If rbDetallado.Checked = True Then
                Dim frm As New FormVisorReportesVentas

                objReporteDetallado = New rptDetalleXClienteXRubroXCB
                oDataSet = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_Detallado(oCuentaCorriente)
                objDt = oDataSet.Tables(0)
                objDt.TableName = "dtVentasDetallado"
                objDs.Tables.Add(objDt.Copy)
                objReporteDetallado.SetDataSource(objDt)
                frm.crvDetallexClientexRubroXCB.ReportSource = objReporteDetallado
                frm.pintMoneda = oCuentaCorriente.CMNDA
                frm.DataReport = oDataSet
                objResumenXRubro = New rptResumenXRubro
                objResumenXRubro.SetDataSource(objDt)
                frm.crvResumenXRubro.ReportSource = objResumenXRubro

                objResumenXDivision = New rptResumenXDivision
                objResumenXDivision.SetDataSource(objDt)
                frm.crvResumenXDivision.ReportSource = objResumenXDivision

                objResumenXCentroBeneficio = New rptResumenXCentroBeneficio
                objResumenXCentroBeneficio.SetDataSource(objDt)
                frm.crvResumenXCentroBeneficio.ReportSource = objResumenXCentroBeneficio

                Dim objDtClienteResumen As New DataTable
                objResumenXCliente = New rptResumenXCliente
                objDtClienteResumen = GeneraClienteResumen(objDt.Copy)
                objDtClienteResumen.TableName = "dtVentasDetClienteResumen"
                objDs.Tables.Add(objDtClienteResumen.Copy)
                objResumenXCliente.SetDataSource(objDs)
                frm.crvResumenxCliente.ReportSource = objResumenXCliente

                'parametros  detalle cliente x rubro x centro beneficio
                crParameterFieldDefinitions = objReporteDetallado.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objReporteDetallado.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteDetallado.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objReporteDetallado.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteDetallado.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objReporteDetallado.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda ' cmbMoneda.Text
                CType(objReporteDetallado.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                'CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
                CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta ' Lista_DescRegionVenta()

                'parametros resumen x cliente

                crParameterFieldDefinitions = objResumenXCliente.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objResumenXCliente.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objResumenXCliente.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXCliente.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objResumenXCliente.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objResumenXCliente.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXCliente.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objResumenXCliente.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda ' cmbMoneda.Text
                CType(objResumenXCliente.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                'CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
                CType(objResumenXCliente.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta 'Lista_DescRegionVenta()


                'parametros resumen x rubro

                crParameterFieldDefinitions = objResumenXRubro.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objResumenXRubro.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objResumenXRubro.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXRubro.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objResumenXRubro.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta ' Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objResumenXRubro.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXRubro.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objResumenXRubro.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda ' cmbMoneda.Text
                CType(objResumenXRubro.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                'CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
                CType(objResumenXRubro.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta 'Lista_DescRegionVenta()

                'parametros resumen x Division

                crParameterFieldDefinitions = objResumenXDivision.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objResumenXDivision.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objResumenXDivision.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXDivision.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objResumenXDivision.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objResumenXDivision.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXDivision.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objResumenXDivision.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda 'cmbMoneda.Text
                CType(objResumenXDivision.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                'CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
                CType(objResumenXDivision.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta 'Lista_DescRegionVenta()

                'parametros resumen x Centro Beneficio AS400

                crParameterFieldDefinitions = objResumenXCentroBeneficio.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda 'cmbMoneda.Text
                CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                'CType(objReporteDetallado.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = txtRegionVenta.Text
                CType(objResumenXCentroBeneficio.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta 'Lista_DescRegionVenta()



                'reporte detallado x documento
                Dim ds As New DataSet
                objReporteDetalladoXDocumento = New rptDetalleXDocumento
                objDt = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_Detallado_Documento(oCuentaCorriente)
                objDt.TableName = "dtVentasDetallado"
                ds.Tables.Add(objDt.Copy)
                objReporteDetalladoXDocumento.SetDataSource(ds)
                frm.crvDetalleXDocumento.ReportSource = objReporteDetalladoXDocumento
                '        '------------------------------------
                crParameterFieldDefinitions = objReporteDetalladoXDocumento.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If

                CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtMoneda"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.strMoneda 'cmbMoneda.Text
                CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                CType(objReporteDetalladoXDocumento.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescRegionVenta ' Lista_DescRegionVenta()

                frm.ShowDialog()
            End If


            If rbCentroCosto.Checked = True Then
                objReporteCentroCosto = New rptVentasCentroCosto
                objDt = oCuentaCorrienteNeg.Cargar_Reporte_Ventas_CentroCosto(oCuentaCorriente)
                objDt.TableName = "dtVentasCentroCosto"
                objDs.Tables.Add(objDt.Copy)
                objReporteCentroCosto.SetDataSource(objDs)
                '------------------------------------
                crParameterFieldDefinitions = objReporteCentroCosto.DataDefinition.ParameterFields
                crParameterFieldLocation = crParameterFieldDefinitions.Item("@FECHAS")
                crParameterValues = crParameterFieldLocation.CurrentValues
                crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                crParameterDiscreteValue.Value = cadenaFechas

                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

                CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion
                If UcDivision.Division = "-1" Then
                    CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.Division & " - " & UcDivision.DivisionDescripcion
                End If
                CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.srtListaDescPlanta 'Lista_DescPlanta()

                If ucCliente.pCodigo = 0 Then
                    CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "TODOS"
                Else
                    CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ucCliente.pCodigo & " - " & ucCliente.pRazonSocial
                End If
                CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                CType(objReporteCentroCosto.ReportDefinition.ReportObjects("txtRegionVenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Lista_DescRegionVenta()


                Dim OFG As New PrintForm
                OFG.WindowState = FormWindowState.Maximized
                OFG.ShowForm(objReporteCentroCosto, Me)

            End If

        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Me.PictureBox1.Visible = False
        Catch ex As Exception
        End Try
    End Sub
End Class
