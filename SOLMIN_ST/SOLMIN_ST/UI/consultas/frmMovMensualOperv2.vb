Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Public Class frmMovMensualOperv2

    Private dstGeneral As New DataSet()


    Private oDtEstado As DataTable


    Private oDtTipoViaje As DataTable
    Private ht As New Hashtable
    Private dtUnidadesProductiva As New DataTable


    Private listGrupoVistaColumnas As New List(Of String)
    Private Sub Cargar_Region_Venta()
        Dim objLogica As New ReportesVariados_BLL
        Me.cboRegionVenta.DataSource = objLogica.Lista_Region_Venta(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboRegionVenta.ValueMember = "CODIGO"
        Me.cboRegionVenta.DisplayMember = "REGION"
        Me.cboRegionVenta.SelectedValue = "0"
      
    End Sub

    Private Sub CargarBusqueda()
        Dim dtTipoBusqueda As New DataTable
        dtTipoBusqueda.Columns.Add("COD")
        dtTipoBusqueda.Columns.Add("TIPO")
        Dim dr As DataRow
        dr = dtTipoBusqueda.NewRow
        dr("COD") = "OP"
        dr("TIPO") = "Nro Operación"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "SL"
        dr("TIPO") = "Nro Solicitud"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "RP"
        dr("TIPO") = "Nro Reparto"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "CN"
        dr("TIPO") = "Nro Consolidado"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "PF"
        dr("TIPO") = "Nro Pre Factura"
        dtTipoBusqueda.Rows.Add(dr)

        dr = dtTipoBusqueda.NewRow
        dr("COD") = "PL"
        dr("TIPO") = "Nro PL"
        dtTipoBusqueda.Rows.Add(dr
                                )
        dr = dtTipoBusqueda.NewRow
        dr("COD") = "FA"
        dr("TIPO") = "Nro Factura"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "OA"
        dr("TIPO") = "O/S Agencia"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "NV"
        dr("TIPO") = "Nro Valorización"
        dtTipoBusqueda.Rows.Add(dr)


        dr = dtTipoBusqueda.NewRow
        dr("COD") = "LC"
        dr("TIPO") = "Nro Liq. Combustible"
        dtTipoBusqueda.Rows.Add(dr)



   


        cboTipoBusqueda.DataSource = dtTipoBusqueda
        cboTipoBusqueda.DisplayMember = "TIPO"
        cboTipoBusqueda.ValueMember = "COD"
        cboTipoBusqueda.SelectedValue = "OP"
    End Sub


    Private Sub frmMovMensualOper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            gwdDatos.AutoGenerateColumns = False
            CargarBusqueda()

            Dim oUnidadProductiva As New NEGOCIO.UnidadProductiva_BLL
            dtUnidadesProductiva = oUnidadProductiva.Listar_Unidad_Productiva


            Dim oDt As New DataTable
            Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL

            'Me.Alinear_Columnas_Grilla()
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

            Dim dtb As New List(Of TipoDatoGeneral)
            dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(cmbCompania.CCMPN_CodigoCompania, "TPOSSG")

            Dim TipoDatoGeneral = New TipoDatoGeneral
            TipoDatoGeneral.CODIGO_TIPO = "T"
            TipoDatoGeneral.DESC_TIPO = "TODOS"
            dtb.Insert(0, TipoDatoGeneral)

            cboTipoSeg.DataSource = dtb
            cboTipoSeg.DisplayMember = "DESC_TIPO"
            cboTipoSeg.ValueMember = "CODIGO_TIPO"
            cboTipoSeg.SelectedValue = ""



            Dim olistEstadoValoriz As New List(Of TipoDatoGeneral)
            olistEstadoValoriz = objTipoDatoGeneral.Lista_Tipo_Dato_General(cmbCompania.CCMPN_CodigoCompania, "SDEVLR")

            Dim beEstadoValoriz = New TipoDatoGeneral
            beEstadoValoriz.CODIGO_TIPO = "T"
            beEstadoValoriz.DESC_TIPO = "TODOS"
            olistEstadoValoriz.Insert(0, beEstadoValoriz)




            cboEstadValorz.DataSource = olistEstadoValoriz
            cboEstadValorz.DisplayMember = "DESC_TIPO"
            cboEstadValorz.ValueMember = "CODIGO_TIPO"
            cboEstadValorz.SelectedValue = "T"


            Dim olistEstadoComb As New List(Of TipoDatoGeneral)
            olistEstadoComb = objTipoDatoGeneral.Lista_Tipo_Dato_General(cmbCompania.CCMPN_CodigoCompania, "STELQC")

            Dim beEstadoComb = New TipoDatoGeneral
            beEstadoComb.CODIGO_TIPO = "T"
            beEstadoComb.DESC_TIPO = "TODOS"
            olistEstadoComb.Insert(0, beEstadoComb)




            cboEstadComb.DataSource = olistEstadoComb
            cboEstadComb.DisplayMember = "DESC_TIPO"
            cboEstadComb.ValueMember = "CODIGO_TIPO"
            cboEstadComb.SelectedValue = "T"


            HabilitarVistaColumna()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ListaUnidadProductiva_X_Division(pCdvsn As String)


        Dim dr() As DataRow
        dr = dtUnidadesProductiva.Select("CDVSN='" & pCdvsn & "'", "CDVSN ")
        Dim dtUnidProdDivision As New DataTable
        dtUnidProdDivision = dr.CopyToDataTable()

        Dim oDr As DataRow
        oDr = dtUnidProdDivision.NewRow
        oDr.Item("CDUPSP") = "TO"
        oDr.Item("TDUPSP") = "TODOS"
        dtUnidProdDivision.Rows.InsertAt(oDr, 0)

        cboUnidadProductiva.DataSource = dtUnidProdDivision
        cboUnidadProductiva.ValueMember = "CDUPSP"
        cboUnidadProductiva.DisplayMember = "TDUPSP"
        cboUnidadProductiva.SelectedValue = "TO"
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
        oDtEstado.Rows.Add(oDr)

        'oDr = oDtEstado.NewRow
        'oDr.Item(1) = "PENDIENTE"
        'oDr.Item(2) = 0
        'oDr.Item(0) = "2"
        'oDr.Item(3) = "P"
        ''oDr.Item(2) = "PE"
        'oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "ASIGNADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "3"
        oDr.Item(3) = "A"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "PRE - FACTURADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "4"
        oDr.Item(3) = "F"
        oDtEstado.Rows.Add(oDr)


        oDr = oDtEstado.NewRow
        oDr.Item(1) = "FACTURADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "5"
        'oDr.Item(3) = "F"
        oDr.Item(3) = "X"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "CERRADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "6"
        oDr.Item(3) = "C"
        oDtEstado.Rows.Add(oDr)

        oDr = oDtEstado.NewRow
        oDr.Item(1) = "ANULADO"
        oDr.Item(2) = 0
        oDr.Item(0) = "7"
        oDr.Item(3) = "*"
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

    'Private Sub Alinear_Columnas_Grilla()
    '    Me.gwdDatos.AutoGenerateColumns = False
    '    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
    '        Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    Next
    'End Sub

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

        If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = 0
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)


            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DataSource = objLisEntidad

            If objLisEntidad.Count > 0 Then
                cboPlanta.SetItemChecked(0, True)
            End If



        End If

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
                lbool_existe_error = True
            End If
        End If

        If lbool_existe_error = True Then HelpClass.MsgBox(" Ingresar el número de documento a consultar " & Chr(13) & lstr_validacion)

        If cboPlanta.CheckedItems.Count = 0 Then
            MessageBox.Show("Seleccione planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lbool_existe_error = True
        End If


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

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default

    End Sub



    Private Sub PrepararProceesWorked(ByRef boolEstado As Boolean)
        boolEstado = ValidarFiltroFecha()
        If boolEstado = True Then Exit Sub
        Dim strCodPlanta As String = ""

        Me.Cursor = Cursors.WaitCursor
        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."
        Dim PlantaTodos As Boolean = False
        Dim CodPlanta As String = ""

        ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        ht.Add("CDVSN", cmbDivision.Division)



        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CodPlanta = cboPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","

        Next
        If strCodPlanta = "0," Then
            strCodPlanta = ""
            For i As Integer = 1 To cboPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cboPlanta.Items(i).Value & ","
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

        ht.Add("ESTADO", ObtenerEstado())
        ht.Add("TIPVJE", ObtenerTipoViaje())

        ht.Add("CMEDTR", cboMedioTransporteFiltro.SelectedValue)
        If txtTransportista.pRucTransportista = "" Then
            ht.Add("CTRSPT", 0)
        Else
            ht.Add("CTRSPT", Convert.ToInt32(txtTransportista.pCodigoRNS))
        End If

        ht("TIPO") = ""
        ht("VALOR_TIPO") = 0

        If Me.chkFecha.Checked = False Then
            ht("TIPO") = cboTipoBusqueda.SelectedValue
            ht("VALOR_TIPO") = Val(txtNroOperacion.Text.Trim)
            ht.Add("STSTIP", 0)
        Else

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

        ht.Add("FTRTSG", cboTipoSeg.SelectedValue)

        ht.Add("ESTADO_VLRZ", cboEstadValorz.SelectedValue)
        ht.Add("ESTADO_COMB", cboEstadComb.SelectedValue)
        ht.Add("CDUPSP", cboUnidadProductiva.SelectedValue)

        ht("AD_COL_PESOALM") = ""
        If chkPesoAlmacen.Checked = True Then
            ht("AD_COL_PESOALM") = "X"
        End If



    End Sub




    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim op As Decimal
        Dim msg As String = ""
        Try
            Dim objLogicaReportes As New ReportesVariados_BLL
            e.Result = objLogicaReportes.frptMovimientoOperaciones_v2(ht, op, msg)
            ' e.Result = objLogicaReportes.frptMovimientoOperaciones_v3(ht, op, msg)
        Catch ex As Exception
            MessageBox.Show(ex.Message & op & " operación: " & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dstreporte As New DataSet
            Dim dt As DataTable
            dstreporte = CType(e.Result, DataSet)
            dt = dstreporte.Tables(0)
            Me.gwdDatos.DataSource = dt
            dstGeneral = dstreporte
        Catch ex As Exception
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

            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Mensual de Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Mensual de Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE MENSUAL DE OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


            For Each dr As DataRow In objDt.Rows
                dr("NORCML") = dr("NORCML").ToString.Replace(",", "," + Chr(10)).ToString
                dr("NGUIRM") = dr("NGUIRM").ToString.Replace(",", "," + Chr(10)).ToString
                dr.AcceptChanges()
            Next
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "NORCML", "NGUIRM", "NOPRCN", "NPLVHT", "NPLCAC", "NMNFCR", "NGUITR", "CCNCST", "CCNBNS", "NLQDCN"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "PBRTOR", "PTRAOR", "PNETO", "IMPCO", "IMPCO_SOLES", "IMPPA", _
                         "IMPPA_SOLES", "GASTOS", "GASTOAVC", "QGLNCM", "COSTO", "IMPORTE_NETO", "MARGEN", "GASTOAVC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
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

        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptMovOperacionesTR
        'Parametros internos del reporte
        dstreporte.Tables(0).TableName = "dtMovOperaciones"
        dstreporte.Tables(1).TableName = "dtResumenAcoplados"
        dstreporte.Tables(2).TableName = "dtResumenEstadoTMP"


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

    End Sub
    Private Sub btnReporteOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteOC.Click
        Try
            Generar_Reporte_por_OC()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                ListaUnidadProductiva_X_Division(cmbDivision.Division)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
    '    Select Case Me.chkFecha.Checked
    '        Case True
    '            Me.txtAgenciaRansa.Enabled = False
    '            Me.txtNroOperacion.Enabled = False
    '            Me.txtOrdenInterna.Enabled = False
    '            Me.txtPreFactura.Enabled = False
    '            Me.txtPreLiquidacion.Enabled = False
    '            Me.txtFactura.Enabled = False
    '            Me.gbFecha.Enabled = True
    '        Case False
    '            Me.txtAgenciaRansa.Enabled = True
    '            Me.txtNroOperacion.Enabled = True
    '            Me.txtOrdenInterna.Enabled = True
    '            Me.txtPreFactura.Enabled = True
    '            Me.txtPreLiquidacion.Enabled = True
    '            Me.txtFactura.Enabled = True
    '            Me.gbFecha.Enabled = False
    '    End Select
    'End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Select Case Me.chkFecha.Checked
            Case True
                Me.txtNroOperacion.Enabled = False
                Me.gbFecha.Enabled = True
            Case False
                Me.txtNroOperacion.Enabled = True
                Me.gbFecha.Enabled = False
        End Select
    End Sub


    Private Sub Limpiar()
        InicializarFormulario()
        CargarTransportista()
    End Sub

    'Private Function ObtenerEstado(ByRef intValorCon As Int32) As String
    '    Dim strCodEstado As String = ""
    '    For i As Integer = 0 To cboEstadoChk.CheckedItems.Count - 1
    '        If (cboEstadoChk.CheckedItems(i).Value <> "1") Then
    '            For j As Integer = 0 To oDtEstado.Rows.Count - 1
    '                If (oDtEstado.Rows(j).Item("VALUE") = cboEstadoChk.CheckedItems(i).Value) Then
    '                    Select Case cboEstadoChk.CheckedItems(i).Value
    '                        Case 4
    '                            intValorCon = 1
    '                        Case 5
    '                            intValorCon = 2
    '                    End Select
    '                    strCodEstado += oDtEstado.Rows(j).Item("VALUES_STRING") & ","
    '                End If
    '            Next
    '        Else
    '            If (cboEstadoChk.CheckedItems.Count = 1) Then
    '                strCodEstado = "TO,"
    '            End If
    '        End If
    '    Next
    '    If strCodEstado.Trim.Length > 0 Then
    '        strCodEstado = strCodEstado.Trim.Substring(0, strCodEstado.Trim.Length - 1)
    '    End If
    '    Return strCodEstado
    'End Function

    Private Function ObtenerEstado() As String
        Dim strCodEstado As String = ""
        For i As Integer = 0 To cboEstadoChk.CheckedItems.Count - 1
            If (cboEstadoChk.CheckedItems(i).Value <> "1") Then
                For j As Integer = 0 To oDtEstado.Rows.Count - 1
                    If (oDtEstado.Rows(j).Item("VALUE") = cboEstadoChk.CheckedItems(i).Value) Then
                        'Select Case cboEstadoChk.CheckedItems(i).Value
                        '    Case 4
                        '        intValorCon = 1
                        '    Case 5
                        '        intValorCon = 2
                        'End Select
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



#End Region

    Private Sub btnAdjuntos_Click(sender As Object, e As EventArgs) Handles btnAdjuntos.Click

        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim NroOperacion As Decimal = gwdDatos.CurrentRow.Cells("NOPRCN").Value
            Dim CodCompania As String = cmbCompania.CCMPN_CodigoCompania
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntosList
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = CodCompania
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntosList.Tabla_Relacion.RZTR05_LIST
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR05(CodCompania, NroOperacion)
            ofrmCargaAdjuntos.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   
    Private Sub btnVerGrupoColumna_Click(sender As Object, e As EventArgs) Handles btnVerGrupoColumna.Click
        Try
            Dim ofrmVistaGrupoColResumen As New frmVistaGrupoColResumen
            ofrmVistaGrupoColResumen.listVista = listGrupoVistaColumnas
            ofrmVistaGrupoColResumen.ShowDialog()
            listGrupoVistaColumnas = ofrmVistaGrupoColResumen.listVista
            HabilitarVistaColumna()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub HabilitarVistaColumna()
        For Each item As DataGridViewColumn In gwdDatos.Columns
            If item.ToolTipText.Length > 0 Then
                If listGrupoVistaColumnas.Contains(item.ToolTipText) Then
                    item.Visible = True
                Else
                    item.Visible = False
                End If
            End If
        Next
    End Sub
End Class
