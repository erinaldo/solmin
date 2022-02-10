'CSR-HUNDRED-feature/151116_Combustibles-INICIO

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Ransa.Utilitario

Public Class frmConsCombustible

#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private objCombustible As New NEGOCIO.Combustible_BLL
    Private EntCombustible As New ENTIDADES.Combustible_BE
#End Region

#Region "Eventos"
    Private Sub frmConsCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cargar_Compania()
            Me.Cargar_Region_Venta()
            Me.Carga_MedioTransporte()
            Me.Cargar_Conductor()
            ChkFecha.Checked = True
            ChkFecha_CheckedChanged(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If bolBuscar Then
                Me.Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If bolBuscar Then
                Me.Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Me.dgvResultado.DataSource = Nothing
        Try
            dgvResultado.AutoGenerateColumns = False


            If CboConductor.Resultado Is Nothing Then
                EntCombustible.CBRCNT = ""
            Else
                EntCombustible.CBRCNT = CType(CboConductor.Resultado, SOLMIN_ST.ENTIDADES.mantenimientos.Chofer).CBRCNT
            End If


            If ChkFecha.Checked = False Then
                If Val(txtOperacion.Text.Trim) = 0 And Val(txtGuiaTransporte.Text.Trim) = 0 And txtTracto.Text.Trim = "" And EntCombustible.CBRCNT = "" Then
                    MessageBox.Show("Ingresar Nro. de Operación ó Guía De Transporte / Conductor / Tracto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                EntCombustible.FINIOP = 0
                EntCombustible.FFINOP = 0

            Else
                EntCombustible.FINIOP = HelpClass.CtypeDate(Me.dtpFecIni.Value)
                EntCombustible.FFINOP = HelpClass.CtypeDate(Me.dtpFecFin.Value)
            End If



            EntCombustible.CCMPN = Me.cboCompania.SelectedValue.ToString
            EntCombustible.CDVSN = Me.cboDivision.SelectedValue.ToString
            EntCombustible.CPLNDV = CType(Me.cboPlanta.SelectedValue, Double)

            If Me.txtCliente.pCodigo = 0 Then
                EntCombustible.CCLNT = 0
            Else
                EntCombustible.CCLNT = CType(Me.txtCliente.pCodigo, Integer)
            End If

            EntCombustible.CRGVTA = Me.cboNegocio.SelectedValue.ToString
            EntCombustible.CMEDTR = Me.cboMedioTransporteFiltro.SelectedIndex


            EntCombustible.NPLCUN = txtTracto.Text.Trim
            EntCombustible.NOPRCN = Val(Me.txtOperacion.Text)
            EntCombustible.NGUIRM = Val(Me.txtGuiaTransporte.Text)

            

            Dim dtTemp As DataTable = objCombustible.ListaReporteCombustible(EntCombustible)

            dgvResultado.DataSource = dtTemp

        Catch ex As Exception
           MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        'System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        Try
            If dgvResultado.Rows.Count <= 0 Then
                Exit Sub
            End If

            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)

            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "REPORTE DE COMBUSTIBLE "))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "REPORTE DE COMBUSTIBLE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "LISTA DE COMBUSTIBLE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))

            objDt = CType(Me.dgvResultado.DataSource, DataTable).Copy

            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dgvResultado, objDt).Copy)

            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "IMPCOMB", "CSTGLN", "QGLNCM", "NKMRCR", "QKMREC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Cargar_Conductor()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CBRCNT"
        oColumnas.DataPropertyName = "CBRCNT"
        oColumnas.HeaderText = "Brevete"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMBRECOMPLETO"
        oColumnas.DataPropertyName = "NOMBRECOMPLETO"
        oColumnas.HeaderText = "Conductor"
        oListColum.Add(2, oColumnas)

        Dim BLConductor As New Chofer_BLL
        Dim oConductor As New List(Of Chofer)

        oConductor = BLConductor.Lista_Conductor_General(cboCompania.SelectedValue)

        If oConductor.Count > 0 Then
            CboConductor.DataSource = oConductor
        Else
            CboConductor.DataSource = Nothing
        End If
        CboConductor.ListColumnas = oListColum
        CboConductor.Cargas()
        CboConductor.Limpiar()
        CboConductor.ValueMember = "CBRCNT"
        CboConductor.DispleyMember = "NOMBRECOMPLETO"
        ' Else
        If oConductor.Count > 0 Then
            CboConductor.DataSource = oConductor
        Else
            CboConductor.DataSource = Nothing
        End If

    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cboCompania.SelectedValue)
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

    Private Sub Cargar_Region_Venta()

        Dim objLogica As New ReportesVariados_BLL
        Me.cboNegocio.DataSource = objLogica.Lista_Region_Venta(Me.cboCompania.SelectedValue)
        Me.cboNegocio.ValueMember = "CODIGO"
        Me.cboNegocio.DisplayMember = "REGION"
        Me.cboNegocio.SelectedValue = "0"
    End Sub

    Private Sub Cargar_Planta()

        If bolBuscar Then
            bolBuscar = False
            objPlanta.Crea_Lista()


            'CSR-HUNDRED-feature/151116_Combustibles-inicio

            Dim ListaPlantas As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
            ListaPlantas = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)

            Dim OPlanta As New ClaseGeneral

            OPlanta.CPLNDV = 0
            OPlanta.TPLNTA = "TODOS"
            ListaPlantas.Insert(0, OPlanta)
            'CSR-HUNDRED-feature/151116_Combustibles-fin


            Me.cboPlanta.DataSource = ListaPlantas
            Me.cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DisplayMember = "TPLNTA"
            Me.cboPlanta.SelectedIndex = 0
            bolBuscar = True
        End If
    End Sub

    Private Sub Cargar_Division()
        bolBuscar = False
        objDivision.Crea_Lista()
        Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
        Me.cboDivision.ValueMember = "CDVSN"
        Me.cboDivision.DisplayMember = "TCMPDV"
        If Me.cboCompania.SelectedValue = "EZ" Then
            Me.cboDivision.SelectedValue = "T"
        End If
        bolBuscar = True
        If Me.cboDivision.SelectedIndex = -1 Then
            Me.cboDivision.SelectedIndex = 0
        End If
        cboDivision_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        cboCompania.SelectedValue = "EZ"
        bolBuscar = True
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectedIndexChanged(Nothing, Nothing)
    End Sub

#End Region

    Private Sub ChkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFecha.CheckedChanged
        dtpFecIni.Enabled = ChkFecha.Checked
        dtpFecFin.Enabled = ChkFecha.Checked
    End Sub
End Class

'CSR-HUNDRED-feature/151116_Combustibles-FIN