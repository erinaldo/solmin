Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports System
Imports System.Globalization
Public Class frmSeguimientoControlFlota


    Private sMensaje As String = "Falta Registrar Datos"
    Private bExcelFact As Boolean = False

    Private Sub frmCargoPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Validar_Acceso_Opciones_Usuario()

            Me.dtgHito.AutoGenerateColumns = False

            Me.Alinear_Columnas_Grilla()
            Me.Cargar_Compania()
            Me.Carga_MedioTransporte()
            Me.Cargar_BusquedaDocumento()
            Me.Cargar_TipoDoc()
            Cargar_PuntoOrigen_Destino()

            Me.cboMedioTransporteFiltro.SelectedValue = 0
            txtTransportista.pClearAll()
            Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTransportista.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
            obeTransportista.pNRUCTR_RucTransportista = ""
            txtTransportista.pCargar(obeTransportista)


            chkFecha.Checked = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then

        End If
        If objEntidad.STSCHG = "" Then

        End If
        If objEntidad.STSELI = "" Then

        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnEditarHito.Enabled = False
        End If

    End Sub



    Private Sub Cargar_BusquedaDocumento()

        Dim obj_TipoBusquedaDocumento As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL

        Dim oTipoGeneralBLL As New TipoDatoGeneral_BLL
        Dim ListaGeneral As New List(Of TipoDatoGeneral)
        ListaGeneral = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "FCRGPL")



    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim dt As New DataTable
        dt = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Dim dr As DataRow
        dr = dt.NewRow
        dr("CMEDTR") = "0"
        dr("TNMMDT") = "Todos"
        dt.Rows.InsertAt(dr, 0)
        Me.cboMedioTransporteFiltro.DataSource = dt
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    End Sub


    Private Sub Cargar_TipoDoc()
        Dim obj_TipoBusquedaDocumento As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
        'Dim objDt As DataTable
        Dim oTipoGeneralBLL As New TipoDatoGeneral_BLL
        Dim ListaGeneral As New List(Of TipoDatoGeneral)
        ListaGeneral = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "STFLCH")

        cboTipoBusqueda.DataSource = ListaGeneral
        cboTipoBusqueda.ValueMember = "CODIGO_TIPO"
        cboTipoBusqueda.DisplayMember = "DESC_TIPO"


        Dim ListaSentidoVje As New List(Of TipoDatoGeneral)
        ListaSentidoVje = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "SDSNVJ")
        Dim beSentidoViaje As New TipoDatoGeneral
        beSentidoViaje.CODIGO_TIPO = ""
        beSentidoViaje.DESC_TIPO = "Todos"
        ListaSentidoVje.Insert(0, beSentidoViaje)
        cbosentidovje.DataSource = ListaSentidoVje
        cbosentidovje.ValueMember = "CODIGO_TIPO"
        cbosentidovje.DisplayMember = "DESC_TIPO"


        Dim ListaEstadoEntrega As New List(Of TipoDatoGeneral)
        ListaEstadoEntrega = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "STFLSH")
        Dim beEstadoEntrega As New TipoDatoGeneral
        beEstadoEntrega.CODIGO_TIPO = ""
        beEstadoEntrega.DESC_TIPO = "Todos"
        ListaEstadoEntrega.Insert(0, beEstadoEntrega)

        cboestadoentrega.DataSource = ListaEstadoEntrega
        cboestadoentrega.ValueMember = "CODIGO_TIPO"
        cboestadoentrega.DisplayMember = "DESC_TIPO"

    End Sub

    Private Sub Alinear_Columnas_Grilla()

        Me.gwdDatos.AutoGenerateColumns = False
        Me.dtgGuiasSeleccionadas.AutoGenerateColumns = False

        Me.dtgOrdenCompra.AutoGenerateColumns = False

        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        For lint_contador As Integer = 0 To Me.dtgGuiasSeleccionadas.ColumnCount - 1
            Me.dtgGuiasSeleccionadas.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        For lint_contador As Integer = 0 To Me.dtgOrdenCompra.ColumnCount - 1
            Me.dtgOrdenCompra.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar

        cmbDivision.Usuario = MainModule.USUARIO
        cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        cmbDivision.DivisionDefault = "T"
        cmbDivision.pActualizar()
        If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
            Me.gwdDatos.DataSource = Nothing
            Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
        End If

    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        'Try
        Me.cmbChkPlanta.Text = ""
        If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing AndAlso Me.cmbDivision.Division IsNot Nothing) Then

            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next
            cmbChkPlanta.DisplayMember = "TPLNTA"
            cmbChkPlanta.ValueMember = "CPLNDV"
            Me.cmbChkPlanta.DataSource = objLisEntidad
            'For i As Integer = 0 To cmbChkPlanta.Items.Count - 1
            '    If cmbChkPlanta.Items.Item(i).Value = "1" Then
            '        Me.cmbChkPlanta.SetItemChecked(i, True)
            '    End If
            'Next
            'If Me.cmbChkPlanta.Text = "" Then
            '    Me.cmbChkPlanta.SetItemChecked(0, True)
            'End If
        End If

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Me.cargarComboPlanta()
    End Sub



    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click

        Try
            If chkFecha.Checked = False Then
                If txtbusqueda.Text = "" Then
                    MessageBox.Show("Ingrese algún valor de búsqueda", "Aviso", MessageBoxButtons.OK)
                    Exit Sub
                End If
            End If
            If cboTipoBusqueda.SelectedValue = "TRT" And chkFecha.Checked = False Then
                MessageBox.Show("Seleccione rango búsqueda", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Me.gwdDatos.DataSource = Nothing
            Me.dtgGuiasSeleccionadas.DataSource = Nothing
            Me.dtgOrdenCompra.DataSource = Nothing
            'Me.dtgGuiasTransportistaAnexa.DataSource = Nothing
            Me.Listar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objParameter As New Hashtable
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim estado_entrega As String = ""
        lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
        lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        objParameter.Add("CCLNT", txtClienteFiltro.pCodigo)
        objParameter.Add("CTRSPT", txtTransportista.pCodigoRNS)
        If chkFecha.Checked = True Then
            objParameter.Add("FECINI", lstr_FecIni)
            objParameter.Add("FECFIN", lstr_FecFin)
        Else
            objParameter.Add("FECINI", 0)
            objParameter.Add("FECFIN", 0)
        End If

        objParameter.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)
        objParameter.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objParameter.Add("CDVSN", Me.cmbDivision.Division)
        'If GetPlanta().Trim.Equals("") Then
        '    Exit Sub
        'End If
        objParameter.Add("CPLNDV", Me.GetPlanta())
        objParameter.Add("TIPOBUSQ", cboTipoBusqueda.SelectedValue)
        objParameter.Add("DOCBUSQ", txtbusqueda.Text)

        objParameter.Add("SDSNVJ", cbosentidovje.SelectedValue)
        objParameter.Add("ESTENTREGA", cboestadoentrega.SelectedValue)


        objParameter.Add("CLCLOR", cmbOrigen.Text.Trim)
        objParameter.Add("CLCLDS", cmbDestino.Text.Trim)

        'cboestadoentrega
        Dim dt As New DataTable
        dt = objSolicitudTransporte.Listar_Seguimiento_Traslado_Hito(objParameter)
        gwdDatos.DataSource = Nothing



        For Each Item As DataColumn In dt.Columns
            If (Item.ColumnName.Contains("F_CHK_") Or Item.ColumnName.Contains("H_CHK_")) Then
                If (gwdDatos.Columns(Item.ColumnName) IsNot Nothing) Then
                    gwdDatos.Columns.Remove(Item.ColumnName)
                End If
            End If

        Next

        Dim Header As String = ""
        For Each Item As DataColumn In dt.Columns
            If Item.ColumnName.Contains("F_CHK_") Or Item.ColumnName.Contains("H_CHK_") Then
                'Header = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Item.ColumnName.ToString.Substring(6))
                Header = Item.ColumnName.ToString.Substring(6)
                Dim oDcTx As DataGridViewColumn
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = Item.ColumnName
                oDcTx.HeaderText = Header
                oDcTx.Resizable = DataGridViewTriState.False
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DataPropertyName = Item.ColumnName.Trim
                oDcTx.ReadOnly = True
                gwdDatos.Columns.Add(oDcTx)
            End If

        Next

        Me.gwdDatos.DataSource = dt

    End Sub

    Private Function GetPlanta() As String
        Dim strCodPlanta As String = ""
        For i As Integer = 0 To Me.cmbChkPlanta.CheckedItems.Count - 1
            strCodPlanta += Me.cmbChkPlanta.CheckedItems(i).Value & ","
        Next
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
            'Else
            '    HelpClass.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
        End If
        Return strCodPlanta
    End Function



    Private Sub Listar_Guias_Remision_Cargo_Plan()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objHashtable As New Hashtable

        objHashtable.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("NGUITR", Me.gwdDatos.Item("NGUITR_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)

        'LLENANDO EL dtgGuiasSeleccionadas
        Me.dtgGuiasSeleccionadas.DataSource = objSolicitudTransporte.Listar_Guia_Remision_Cliente_CargoPlan(objHashtable)

    End Sub

    Private Sub Listar_Ordenes_Compra_Cargo_Plan()
        'Para cada guia de remision, traemos las ordenes de compra
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objHashtable As New Hashtable

        objHashtable.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("NGUITR", Me.gwdDatos.Item("NGUITR_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)

        Me.dtgOrdenCompra.DataSource = objSolicitudTransporte.Listar_Guia_Orden_Compra_CargoPlan(objHashtable)

    End Sub



    Public Function TransformarGrilla(ByVal gv As DataGridView) As DataTable
        Dim dtData As New DataTable
        For Each Item As DataGridViewColumn In gv.Columns
            If Item.Visible = True Then
                dtData.Columns.Add(Item.Name)
            End If
        Next

        Dim dr As DataRow
        Dim NameColumna As String = ""
        For Each Item As DataGridViewRow In gv.Rows
            dr = dtData.NewRow
            For Each dcColumna As DataColumn In dtData.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = Item.Cells(NameColumna).Value
            Next
            dtData.Rows.Add(dr)
        Next

        For Each Item As DataColumn In dtData.Columns
            Item.ColumnName = gv.Columns(Item.ColumnName).HeaderText
        Next

        Return dtData

    End Function

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Dim ODs As New DataSet
            Dim objDt As DataTable
            'objDt = TransformarGrilla(Me.gwdDatos, HelpClass.GetDataSetNative(Me.gwdDatos.DataSource))
            objDt = TransformarGrilla(Me.gwdDatos)
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "COMPAÑIA : " & " " & Me.cmbCompania.CCMPN_Descripcion))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "CLIENTE : " & IIf(txtClienteFiltro.pCodigo = 0, "TODOS", txtClienteFiltro.pCodigo & " - " & txtClienteFiltro.pRazonSocial)))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "0.00"))
            ODs.Tables.Add(objDt.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnEditarHito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarHito.Click
        Try
            'verificando si es que ha seleccionado un hito
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub

            Dim frmControlHito As New frmControlHitos
            frmControlHito.pCTRMNC = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.pNOPRCN = Me.gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.pNGUIRM = Me.gwdDatos.Item("NGUITR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.pCCLNT = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.pSNTVJE = Me.gwdDatos.Item("SNTVJE_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.pDESTINO = Me.gwdDatos.Item("DESTINO_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            frmControlHito.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub Cargar_PuntoOrigen_Destino()

        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim objDt As DataTable
        objDt = obj_Logica_Localidad.Listar_Localidades_Combo_Todos("EZ")
        With Me.cmbOrigen
            .DataSource = objDt.Copy
            .ValueMember = "CLCLD"
            .DisplayMember = "TCMLCL"
        End With
        With Me.cmbDestino
            .DataSource = objDt.Copy
            .ValueMember = "CLCLD"
            .DisplayMember = "TCMLCL"
        End With

    End Sub

    Private Sub ListarHitos()

        Dim dtbListaHitos As New DataTable
        Dim objcontrolhito As New ControlHito
        Dim objHito As New ControlHitos_BLL
        Dim objHitooperacion As New HitoOperacion
        Dim dtbHitosOperacion As New DataTable
        Dim ds As New DataSet
        objHitooperacion.NOPRCN = gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value
        objHitooperacion.NGUIRM = gwdDatos.Item("NGUITR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
        objHitooperacion.CTRMNC = gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
        objHitooperacion.CCLNT = gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
        objHitooperacion.SNTVJE = gwdDatos.Item("SNTVJE_P", Me.gwdDatos.CurrentCellAddress.Y).Value
        ds = objHito.ConsultaHitosRegistrados(objHitooperacion)
        dtbHitosOperacion = ds.Tables(0)
        Me.dtgHito.DataSource = dtbHitosOperacion


    End Sub


    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            Me.Listar_Guias_Remision_Cargo_Plan()
            Me.Listar_Ordenes_Compra_Cargo_Plan()
            ListarHitos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        dtpFechaInicio.Enabled = chkFecha.Checked
        dtpFechaFin.Enabled = chkFecha.Checked

    End Sub

    Private Sub btnETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETA.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmActualizarETA As New frmActualizarETA
            ofrmActualizarETA.compania = cmbCompania.CCMPN_CodigoCompania
            ofrmActualizarETA.operacion = gwdDatos.Item("NOPRCN_P", gwdDatos.CurrentCellAddress.Y).Value
            ofrmActualizarETA.codigo_transporte = gwdDatos.Item("CTRMNC_P", gwdDatos.CurrentCellAddress.Y).Value
            ofrmActualizarETA.guia_transporte = gwdDatos.Item("NGUITR_P", gwdDatos.CurrentCellAddress.Y).Value
            ofrmActualizarETA.fecha_llegada = gwdDatos.Item("F_LLEGD_TRASL_P", gwdDatos.CurrentCellAddress.Y).Value
            ofrmActualizarETA.fecha_salida_real = gwdDatos.Item("F_INI_TRASL_P", gwdDatos.CurrentCellAddress.Y).Value
            ofrmActualizarETA.fecha_ETA = gwdDatos.Item("FECETA_P", gwdDatos.CurrentCellAddress.Y).Value
            If ofrmActualizarETA.ShowDialog() = Windows.Forms.DialogResult.OK Then
                gwdDatos.Item("FECETA_P", Me.gwdDatos.CurrentCellAddress.Y).Value = ofrmActualizarETA.fecha_ETA
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class