Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO

Public Class frmCargoPlan

    Private sMensaje As String = "Falta Registrar Datos"
    Private bExcelFact As Boolean = False

    Private Sub frmCargoPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Alinear_Columnas_Grilla()
            Me.Cargar_Compania()
            Me.Validar_Acceso_Opciones_Usuario()
            Me.Carga_MedioTransporte()
            Me.Cargar_PuntoOrigen_Destino()
            Me.Cargar_BusquedaDocumento()
            Me.Cargar_TipoDoc()

            Me.cboMedioTransporteFiltro.SelectedValue = 4
            txtTransportista.pClearAll()
            Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTransportista.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
            obeTransportista.pNRUCTR_RucTransportista = ""
            txtTransportista.pCargar(obeTransportista)
            Me.btnEliminar.Visible = False
            KryptonComboBox1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub Cargar_PuntoOrigen_Destino()
        'Try
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
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Cargar_BusquedaDocumento()

        Dim obj_TipoBusquedaDocumento As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
        'Dim objDt As DataTable
        Dim oTipoGeneralBLL As New TipoDatoGeneral_BLL
        Dim ListaGeneral As New List(Of TipoDatoGeneral)
        ListaGeneral = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "FCRGPL")
        'objDt = obj_TipoBusquedaDocumento.TipoBusquedaDocumento()
        'tipoDatoGeneral.CODIGO_TIPO = Item("CODIGO_TIPO").ToString.Trim
        'tipoDatoGeneral.DESC_TIPO = Item("DESC_TIPO").ToString.Trim
        With Me.cmbTipoDocumento
            .DataSource = ListaGeneral
            .ValueMember = "CODIGO_TIPO"
            .DisplayMember = "DESC_TIPO"
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Me.cboMedioTransporteFiltro.DataSource = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    End Sub


    Private Sub Cargar_TipoDoc()
        Dim obj_TipoBusquedaDocumento As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
        Dim objDt As DataTable
        Dim oTipoGeneralBLL As New TipoDatoGeneral_BLL
        Dim ListaGeneral As New List(Of TipoDatoGeneral)
        ListaGeneral = oTipoGeneralBLL.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "SFLFGT")
        'objDt = obj_TipoBusquedaDocumento.TipoBusquedaDocumento()
        'tipoDatoGeneral.CODIGO_TIPO = Item("CODIGO_TIPO").ToString.Trim
        'tipoDatoGeneral.DESC_TIPO = Item("DESC_TIPO").ToString.Trim
        With Me.KryptonComboBox1
            .DataSource = ListaGeneral
            .ValueMember = "CODIGO_TIPO"
            .DisplayMember = "DESC_TIPO"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub Alinear_Columnas_Grilla()

        Me.gwdDatos.AutoGenerateColumns = False
        'Me.dtgRecursosAsignados.AutoGenerateColumns = False
        Me.dtgGuiasSeleccionadas.AutoGenerateColumns = False
        Me.dtgGuiasTransportistaAnexa.AutoGenerateColumns = False
        Me.dtgOrdenCompra.AutoGenerateColumns = False

        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        'For lint_contador As Integer = 0 To Me.dtgRecursosAsignados.ColumnCount - 1
        '  Me.dtgRecursosAsignados.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Next
        For lint_contador As Integer = 0 To Me.dtgGuiasSeleccionadas.ColumnCount - 1
            Me.dtgGuiasSeleccionadas.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador As Integer = 0 To Me.dtgGuiasTransportistaAnexa.ColumnCount - 1
            Me.dtgGuiasTransportistaAnexa.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador As Integer = 0 To Me.dtgOrdenCompra.ColumnCount - 1
            Me.dtgOrdenCompra.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub Cargar_Compania()
        'Try
        cmbCompania.Usuario = MainModule.USUARIO
        ' cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.gwdDatos.DataSource = Nothing
                'Me.dtgRecursosAsignados.Rows.Clear()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


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

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = 0
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)

            cmbChkPlanta.DisplayMember = "TPLNTA"
            cmbChkPlanta.ValueMember = "CPLNDV"
            Me.cmbChkPlanta.DataSource = objLisEntidad

            If objLisEntidad.Count > 0 Then
                cmbChkPlanta.SetItemChecked(0, True)
            End If

            'For i As Integer = 0 To cmbChkPlanta.Items.Count - 1
            '    'If cmbChkPlanta.Items.Item(i).Value = "1" Then
            '    '    Me.cmbChkPlanta.SetItemChecked(i, True)
            '    'End If
            '    If cmbChkPlanta.Items.Item(i).Value = "0" Then
            '        Me.cmbChkPlanta.SetItemChecked(i, True)
            '    End If
            'Next
            'If Me.cmbChkPlanta.Text = "" Then
            '    Me.cmbChkPlanta.SetItemChecked(0, True)
            'End If
        End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Me.cmbPlanta.Usuario = MainModule.USUARIO
        'Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        'Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        'Me.cmbPlanta.PlantaDefault = 1
        'If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
        '    Me.cmbPlanta.pActualizar()
        'End If
    End Sub

    Private Sub btnAdjuntarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumento.Click

        Try
            Dim ht As New Hashtable
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub 'OrElse Me.dtgRecursosAsignados.RowCount = 0 OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
            'If Me.dtgRecursosAsignados.Item("NGUITR_D", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value <> 0 Then Exit Sub
            'Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            'ht.Add("NCSOTR", Me.dtgRecursosAsignados.Item("NCSOTR_P", lint_indice).Value)
            'ht.Add("NCRRSR", Me.dtgRecursosAsignados.Item("NCRRSR_P", lint_indice).Value)
            '=========ANTIGUO=============
            'Dim f As New frmDocumentosAdjuntos
            'f.cargarDatos(ht)
            'f.Show()
            '============NUEVO =============
            Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            With ofrmAdjuntarDocumento
                .pTABLE_NAME = "RZTR96"
                .pUSER_NAME = USUARIO
                .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                .PSCDVSN = cmbDivision.Division
                .PNCPLNDV = Me.gwdDatos.Item("CPLNDV_P", lint_indice).Value
                '.PNCCLNT = Me.gwdDatos.Item("CTRMNC_P", lint_indice).Value
                .PNCCLNT = Me.gwdDatos.Item("CCLNT_P", lint_indice).Value
                .pNGUIRM = Me.gwdDatos.Item("NGUIRM_P", lint_indice).Value
                .pNMRGIM = Me.gwdDatos.Item("NMRGIM_P", lint_indice).Value
                .ShowDialog()
            End With
            'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
            'With ofrmAdjuntarDocumento
            '    .docsAdjunto.CCMPN = cmbCompania.CCMPN_CodigoCompania
            '    .docsAdjunto.CDVSN = cmbDivision.Division
            '    .docsAdjunto.CPLNDV = Me.gwdDatos.Item("CPLNDV_P", lint_indice).Value '
            '    .docsAdjunto.CTRSPT = Me.gwdDatos.Item("CTRMNC_P", lint_indice).Value
            '    .docsAdjunto.NGUITR = Me.gwdDatos.Item("NGUIRM_P", lint_indice).Value
            'End With
            'If ofrmAdjuntarDocumento.ShowDialog() Then
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub gwdDatos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gwdDatos.ColumnHeaderMouseClick
    '  If Me.gwdDatos.RowCount = 0 Then Exit Sub
    '  Dim oucOrdena As UCOrdena(Of Solicitud_Transporte)
    '  Dim olbeSolicitud_Transporte As List(Of Solicitud_Transporte) = Me.gwdDatos.DataSource  'olbeGrifo
    '  oucOrdena = New UCOrdena(Of Solicitud_Transporte)(Me.gwdDatos.Columns(e.ColumnIndex).Name, UCOrdena(Of Grifo).TipoOrdenacion.Ascendente)
    '  olbeSolicitud_Transporte.Sort(oucOrdena)
    '  Me.gwdDatos.DataSource = olbeSolicitud_Transporte
    '  Me.gwdDatos.Refresh()
    'End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            Select Case e.KeyCode
                Case Keys.Enter, Keys.Up, Keys.Down
                    Me.gwdDatos_CellClick(Nothing, Nothing)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click

        Try
            If cmbChkPlanta.CheckedItems.Count = 0 Then
                MessageBox.Show("Seleccione planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If cmbTipoDocumento.SelectedValue <> "TRT" Then
                If txtNroDocumento.Text.Trim <> "" AndAlso Not IsNumeric(txtNroDocumento.Text) Then
                    MessageBox.Show("Ingrese valor númerico en nro documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.WaitCursor
            'LIMPIANDO LAS DGV
            Me.gwdDatos.DataSource = Nothing
            Me.dtgGuiasSeleccionadas.DataSource = Nothing
            Me.dtgOrdenCompra.DataSource = Nothing
            Me.dtgGuiasTransportistaAnexa.DataSource = Nothing
            Me.Listar()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar()

        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objParameter As New Hashtable
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim PlantaSel As String = ""

        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objParameter.Add("CCLNT", txtClienteFiltro.pCodigo)
        objParameter.Add("CTRSPT", txtTransportista.pCodigoRNS)
        'If Me.txtNroDocumento.Text.Trim.Equals("") Then
        '  Me.txtNroDocumento.Text = "0"
        'End If
        'objParameter.Add("NDCMFC", 0)
        'objParameter.Add("NOPRCN", 0)
        'objParameter.Add("NGUITR", 0)
        'objParameter.Add("NGUIRM", 0)
        'objParameter.Add("NCSOTR", 0)
        'objParameter.Add("NDCPRF", 0)
        'objParameter.Add("NPRLQD", 0)
        'Select Case cmbTipoDocumento.SelectedValue
        '  Case "SOL"
        '    objParameter.Item("NCSOTR") = Me.txtNroDocumento.Text.Trim
        '  Case "OPE"
        '    objParameter.Item("NOPRCN") = Me.txtNroDocumento.Text.Trim
        '  Case "GTR"
        '    objParameter.Item("NGUITR") = Me.txtNroDocumento.Text.Trim
        '  Case "GRM"
        '    objParameter.Item("NGUIRM") = Me.txtNroDocumento.Text.Trim
        '  Case "PRF"
        '    objParameter.Item("NDCPRF") = Me.txtNroDocumento.Text.Trim
        '  Case "PRL"
        '    objParameter.Item("NPRLQD") = Me.txtNroDocumento.Text.Trim
        '  Case "FAC"
        '    objParameter.Item("NDCMFC") = Me.txtNroDocumento.Text.Trim
        '  Case Else

        'End Select
        objParameter.Add("FECINI", lstr_FecIni)
        objParameter.Add("FECFIN", lstr_FecFin)
        objParameter.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)
        objParameter.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objParameter.Add("CDVSN", Me.cmbDivision.Division)
        'objParameter.Add("CPLNDV", Me.cmbPlanta.Planta)
        PlantaSel = DevuelvePlantaSeleccionadas()
        If PlantaSel.Trim.Equals("") Then
            Exit Sub
        End If
        objParameter.Add("CPLNDV", PlantaSel)
        objParameter.Add("CLCLOR", cmbOrigen.Text.Trim)
        objParameter.Add("CLCLDS", cmbDestino.Text.Trim)
        objParameter.Add("TIPOBUSQ", cmbTipoDocumento.SelectedValue)
        objParameter.Add("DOCBUSQ", Me.txtNroDocumento.Text.Trim)

        If KryptonCheckBox1.Checked = True Then
            objParameter.Add("FLFECH", KryptonComboBox1.SelectedValue)
        Else
            objParameter.Add("FLFECH", "")
        End If


        Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Guia_Transporte_Estado(objParameter)
        Me.txtNroDocumento.Text = IIf(Me.txtNroDocumento.Text = "0", "", Me.txtNroDocumento.Text)
    End Sub

    'Private Function GetPlanta() As String
    '    Dim strCodPlanta As String = ""
    '    For i As Integer = 0 To Me.cmbChkPlanta.CheckedItems.Count - 1
    '        strCodPlanta += Me.cmbChkPlanta.CheckedItems(i).Value & ","
    '    Next
    '    If strCodPlanta.Trim.Length > 0 Then
    '        strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
    '    Else
    '        HelpClass.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
    '    End If
    '    Return strCodPlanta
    'End Function

    Private Function DevuelvePlantaSeleccionadas() As String
        Dim CodPlanta As String = ""
        Dim strCodPlanta As String = ""
        Dim PlantaTodos As Boolean = False
        For i As Integer = 0 To cmbChkPlanta.CheckedItems.Count - 1
            CodPlanta = cmbChkPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","
        Next
        If PlantaTodos = True Then
            strCodPlanta = ""
            For i As Integer = 1 To cmbChkPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cmbChkPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta
    End Function

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            Dim objBitmap_1 As Bitmap = My.Resources.button_ok1
            If cboMedioTransporteFiltro.SelectedValue <> 4 Then Exit Sub
            For i As Integer = 0 To gwdDatos.Rows.Count - 1
                If gwdDatos.Rows(i).Cells("FLAG_PSOVOL").Value = 1 Then
                    gwdDatos.Rows(i).DefaultCellStyle.BackColor = Color.MistyRose
                    gwdDatos.Rows(i).Cells("NGUIRM_P").ToolTipText = sMensaje
                End If
                If gwdDatos.Item("GPSLON_P", i).Value.ToString.Trim <> "" Then gwdDatos.Item("UBICACION_P", i).Value = objBitmap_1
            Next
            If Me.gwdDatos.Rows.Count > 0 Then Me.gwdDatos.CurrentRow.Selected = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Me.Listar_Guias_Remision_Cargo_Plan()
            Me.Listar_Ordenes_Compra_Cargo_Plan()
            Me.Listar_Guias_Transporte_Adicional_Cargo_Plan()
            If Me.gwdDatos.Columns(e.ColumnIndex).Name = "UBICACION_P" Then
                If gwdDatos.Item("GPSLON_P", e.RowIndex).Value.ToString.Trim <> "" Then
                    Dim objGpsBrowser As New frmMapaGps
                    With objGpsBrowser
                        .nroSolicitud = Me.gwdDatos.Item("NCSOTR_P", e.RowIndex).Value
                        .nroCorrelativo = Me.gwdDatos.Item("NCRRSR_P", e.RowIndex).Value
                        .WindowState = FormWindowState.Normal
                        .ShowForm(Me)
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub Cargar_Detalle_Solicitud()
    '  Dim dwvrow As DataGridViewRow
    '  Dim objEntidad As New ClaseGeneral
    '  Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
    '  Dim oSolTrans As New Solicitud_Transporte
    '  Dim oDt As New DataTable
    '  Dim objListaDr As DataRow()

    '  Me.dtgRecursosAsignados.Rows.Clear()
    '  objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR_P", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
    '  objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
    '  For Each obj_Entidad As ClaseGeneral In objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)
    '    dwvrow = New DataGridViewRow
    '    dwvrow.CreateCells(Me.dtgRecursosAsignados)
    '    dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
    '    dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
    '    dwvrow.Cells(2).Value = obj_Entidad.NPLNJT
    '    dwvrow.Cells(3).Value = obj_Entidad.NCRRPL
    '    dwvrow.Cells(4).Value = obj_Entidad.NRUCTR.Trim & " - " & obj_Entidad.TCMTRT.Trim
    '    dwvrow.Cells(5).Value = obj_Entidad.NPLCUN
    '    dwvrow.Cells(6).Value = obj_Entidad.NPLCAC
    '    dwvrow.Cells(7).Value = obj_Entidad.CBRCND
    '    dwvrow.Cells(8).Value = obj_Entidad.CBRCN2
    '    dwvrow.Cells(9).Value = obj_Entidad.FASGTR
    '    dwvrow.Cells(10).Value = obj_Entidad.HASGTR
    '    dwvrow.Cells(11).Value = obj_Entidad.FATALM
    '    dwvrow.Cells(12).Value = obj_Entidad.HATALM
    '    dwvrow.Cells(13).Value = obj_Entidad.FSLALM
    '    dwvrow.Cells(14).Value = obj_Entidad.HSLALM
    '    dwvrow.Cells(15).Value = obj_Entidad.NGUITR
    '    dwvrow.Cells(16).Value = obj_Entidad.NOPRCN
    '    dwvrow.Cells(17).Value = obj_Entidad.NPLNMT
    '    dwvrow.Cells(18).Value = obj_Entidad.NORINSS
    '    If obj_Entidad.NORINSS.Trim.ToString = "" OrElse obj_Entidad.NORINSS <= 0 Then
    '      dwvrow.Cells(18).Style.ForeColor = Color.Blue
    '      dwvrow.Cells(18).Value = "Enviar SAP"
    '      dwvrow.Cells(18).ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
    '    End If
    '    dwvrow.Cells(19).Value = obj_Entidad.SESPLN
    '    dwvrow.Cells(20).Value = obj_Entidad.GPSLAT
    '    dwvrow.Cells(21).Value = obj_Entidad.GPSLON
    '    dwvrow.Cells(22).Value = obj_Entidad.FECGPS
    '    dwvrow.Cells(23).Value = obj_Entidad.HORGPS
    '    dwvrow.Cells(24).Value = obj_Entidad.SEGUIMIENTO
    '    If obj_Entidad.NCOREG <> 0 Then
    '      dwvrow.Cells(25).Value = My.Resources.button_ok1
    '    Else
    '      dwvrow.Cells(25).Value = My.Resources.Nada_1
    '    End If
    '    dwvrow.Cells(26).Value = obj_Entidad.CTRSPT

    '    Me.dtgRecursosAsignados.Rows.Add(dwvrow)

    '  Next

    'End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSCHG = "" Then
            Me.btnActualizacionMasivo.Visible = False
        End If

        If objEntidad.STSADI = "" Then
            Me.btnExpCargoPlanCosto.Visible = False
            Me.btnExpCargoPlanMasivoCosto.Visible = False
        End If

        If objEntidad.STSVIS = "" Then
            Me.btnExportaCargoPlan.Visible = False
            Me.btnExportarCargoPlanMasivo.Visible = False
        End If

        If objEntidad.STSOP1 = "" Then
            Me.btnAdjuntarDocumento.Visible = False
        End If

        If objEntidad.STSOP2 = "" Then
            Me.btnConfirmarSalida.Visible = False
        End If

        If objEntidad.STSELI = "" Then
            Me.btnActualizar.Visible = False
        End If

    End Sub

    'Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
    '  If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.dtgRecursosAsignados.RowCount = 0 OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
    '  Dim frmConfirmarLlegada As New frmConfirmarLlegada
    '  With frmConfirmarLlegada
    '    .pCompania = Me.gwdDatos.Item("CCMPN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
    '    .pPlanta = Me.gwdDatos.Item("CPLNDV_C", Me.gwdDatos.CurrentCellAddress.Y).Value
    '    .pNCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR_D", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
    '    .pNCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR_D", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
    '    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '  End With

    'End Sub

    'Private Sub dtgRecursosAsignados_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '  If Me.dtgRecursosAsignados.RowCount = 0 OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
    '  Select Case Me.dtgRecursosAsignados.Columns(e.ColumnIndex).Name
    '    Case "NORINS_D"
    '      If dtgRecursosAsignados.Item("", e.RowIndex).Value.ToString = "Enviar SAP" Then
    '        Me.Enviar_Orden_Interna_SAP()
    '      End If
    '    Case "SEGUIMIENTO_D"
    '      If Me.dtgRecursosAsignados.Item("GPSLON_D", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then
    '        Dim objGpsBrowser As New frmMapa
    '        With objGpsBrowser
    '          .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT_D", e.RowIndex).Value
    '          .Longitud = Me.dtgRecursosAsignados.Item("GPSLON_D", e.RowIndex).Value
    '          .Fecha = Me.dtgRecursosAsignados.Item("FECGPS_D", e.RowIndex).Value
    '          .Hora = Me.dtgRecursosAsignados.Item("HORGPS_D", e.RowIndex).Value.ToString.Trim
    '          .WindowState = FormWindowState.Maximized
    '          .ShowForm(.Latitud, .Longitud, Me)
    '        End With
    '      End If
    '  End Select
    'End Sub

    'Private Sub Enviar_Orden_Interna_SAP()
    '  Dim intIndice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
    '  If Me.dtgRecursosAsignados.Item("NOPRCN_D", intIndice).Value = 0 Then
    '    HelpClass.MsgBox("No Tiene Operación Asignada")
    '    Exit Sub
    '  End If
    '  If Me.dtgRecursosAsignados.Item("NORINS_D", intIndice).Value.ToString.Trim <> "Enviar SAP" Then
    '    HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " & _
    '    Me.dtgRecursosAsignados.Item("NORINS_D", intIndice).Value.ToString)
    '    Exit Sub
    '  End If
    '  If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & _
    '     Me.dtgRecursosAsignados.Item("NOPRCN_D", intIndice).Value & " ?") = Windows.Forms.DialogResult.No Then
    '    Exit Sub
    '  End If
    '  Me.Generar_Orden_Interna(intIndice)
    'End Sub

    'Private Sub Generar_Orden_Interna(ByVal intIndice As Integer)
    '  If Me.dtgRecursosAsignados.CurrentRow Is Nothing OrElse intIndice < 0 Then
    '    Exit Sub
    '  End If
    '  Dim objOrdenInterna As New OrdenInterna_BLL
    '  Dim objEntidad As New Planeamiento
    '  Dim objParametros As New List(Of String)
    '  'Fila Seleccionada de la grilla
    '  Dim objFila As DataGridViewRow = Me.dtgRecursosAsignados.CurrentRow
    '  'Llenando el parametros de valores
    '  objParametros.Add(objFila.Cells("NOPRCN_D").Value.ToString())
    '  objParametros.Add(MainModule.USUARIO)
    '  objParametros.Add(HelpClass.TodayNumeric)
    '  objParametros.Add(HelpClass.NowNumeric)
    '  objParametros.Add(HelpClass.NombreMaquina)
    '  objParametros.Add(objFila.Cells("NPLCUN_D").Value.ToString())
    '  objParametros.Add(objFila.Cells("NPLCAC_D").Value.ToString())
    '  objParametros.Add(objFila.Cells("CBRCNT_D").Value.ToString())
    '  objParametros.Add(Me.cmbCompania.CCMPN_CodigoCompania)
    '  objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
    '  If objEntidad.NORINS > 0 Then
    '    HelpClass.MsgBox("Orden Interna N° " + CStr(objEntidad.NORINS) + " se envió al SAP satisfactoriamente")
    '    Me.dtgRecursosAsignados.Item("NORINS_D", intIndice).Value = objEntidad.NORINS
    '    Me.dtgRecursosAsignados.Item("NORINS_D", intIndice).Style.ForeColor = Color.Black
    '  Else
    '    HelpClass.MsgBox("Ocurrió un error en el envió al SAP")
    '  End If

    'End Sub

    Private Sub Listar_Guias_Remision_Cargo_Plan()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objHashtable As New Hashtable

        objHashtable.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("NGUITR", Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)

        'LLENANDO EL dtgGuiasSeleccionadas
        Me.dtgGuiasSeleccionadas.DataSource = objSolicitudTransporte.Listar_Guia_Remision_Cliente_CargoPlan(objHashtable)

    End Sub

    Private Sub Listar_Ordenes_Compra_Cargo_Plan()
        'Para cada guia de remision, traemos las ordenes de compra
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objHashtable As New Hashtable

        objHashtable.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("NGUITR", Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)

        Me.dtgOrdenCompra.DataSource = objSolicitudTransporte.Listar_Guia_Orden_Compra_CargoPlan(objHashtable)

    End Sub

    Private Sub Listar_Guias_Transporte_Adicional_Cargo_Plan()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objHashtable As New Hashtable

        objHashtable.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("NGUITR", Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashtable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)

        Me.dtgGuiasTransportistaAnexa.DataSource = objSolicitudTransporte.Listar_Guia_Anexa_CargoPlan(objHashtable)

    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    End Sub

    Private Sub btnConfirmarSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarSalida.Click
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Dim frm_frmActualizarFecha As New frmActualizarFecha
        If lint_indice < 0 Then Exit Sub
        If Me.gwdDatos.Item("NOPRCN_P", lint_indice).Value = 0 Then
            HelpClass.MsgBox("No tiene Operación asignada")
            Exit Sub
        End If
        If Me.gwdDatos.Item("NGUIRM_P", lint_indice).Value = 0 Then
            HelpClass.MsgBox("No tiene Guía de Transporte")
            Exit Sub
        End If
        frm_frmActualizarFecha.IsMdiContainer = True
        Try
            With frm_frmActualizarFecha
                .txt_1.Text = Me.gwdDatos.Item("TCMTRT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                .txt_2.Text = Me.gwdDatos.Item("NGUIRM_P", lint_indice).Value
                .dtpFechaEstimadaSalida.Value = Me.gwdDatos.Item("FECETD_S_P", lint_indice).Value 'Date.Today 'POR MIENTRAS

                'agregando campos para validacion de fecha de llegada
                .CCLNT = Me.gwdDatos.Item("CCLNT_P", lint_indice).Value
                .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                .CLCLDS = Me.gwdDatos.Item("CLCLDS", lint_indice).Value
                .CLCLOR = Me.gwdDatos.Item("CLCLOR", lint_indice).Value
                .CMEDTR = Me.gwdDatos.Item("CMEDTR_P", lint_indice).Value

                If Me.gwdDatos.Item("FECETA_S_P", lint_indice).Value.ToString.Trim = "" Then
                    .dtpFechaEstimadaLlegada.Checked = False
                    .dtpFechaEstimadaLlegada.Value = Date.Today
                Else
                    .dtpFechaEstimadaLlegada.Checked = True
                    .dtpFechaEstimadaLlegada.Value = Me.gwdDatos.Item("FECETA_S_P", lint_indice).Value
                End If
                .dtpFechaRealSalida.Value = Me.gwdDatos.Item("FEMVLH_S_P", lint_indice).Value
                If Me.gwdDatos.Item("FCHFTR_S_P", lint_indice).Value.ToString.Trim = "" Then
                    .dtpFechaRealLlegada.Checked = False
                    .dtpFechaRealLlegada.Value = Date.Today
                Else
                    .dtpFechaRealLlegada.Checked = True
                    .dtpFechaRealLlegada.Value = Me.gwdDatos.Item("FCHFTR_S_P", lint_indice).Value
                End If

                '---agregando la hora de inicio y fin
                Dim d As New Date
                If Me.gwdDatos.Item("HORAINI", lint_indice).Value.ToString.Trim = "0" Or Me.gwdDatos.Item("HORAINI", lint_indice).Value.ToString.Trim = "" Then
                    '.txtHoraInicio.Text = Date.Now.ToString("hh:mm")
                Else
                    .txtHoraInicio.Text = Me.gwdDatos.Item("HORAINI", lint_indice).Value
                End If

                If Me.gwdDatos.Item("HORAFIN", lint_indice).Value.ToString.Trim = "0" Or Me.gwdDatos.Item("HORAFIN", lint_indice).Value.ToString.Trim = "" Then
                    '.txtHoraFin.Text = Date.Now.ToString("hh:mm")
                Else
                    .txtHoraFin.Text = Me.gwdDatos.Item("HORAFIN", lint_indice).Value
                End If

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'Me.Cargar_Detalle_Solicitud()
                    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
                    Dim objParameter As New Hashtable
                    objParameter.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC_P", lint_indice).Value)
                    objParameter.Add("NGUIRM", Me.gwdDatos.Item("NGUIRM_P", lint_indice).Value)
                    objParameter.Add("FECETD", HelpClass.CFecha_a_Numero8Digitos(.dtpFechaEstimadaSalida.Value.ToShortDateString))
                    objParameter.Add("FECETA", IIf(.dtpFechaEstimadaLlegada.Checked, HelpClass.CFecha_a_Numero8Digitos(.dtpFechaEstimadaLlegada.Value.ToShortDateString), 0))
                    objParameter.Add("FEMVLH", HelpClass.CFecha_a_Numero8Digitos(.dtpFechaRealSalida.Value.ToShortDateString))
                    objParameter.Add("FCHFTR", IIf(.dtpFechaRealLlegada.Checked, HelpClass.CFecha_a_Numero8Digitos(.dtpFechaRealLlegada.Value.ToShortDateString), 0))
                    objParameter.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
                    objParameter.Add("CULUSA", MainModule.USUARIO)
                    objParameter.Add("TERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)

                    objParameter.Add("HORAINI", MainModule.FormatoHora(.txtHoraInicio.Text))
                    objParameter.Add("HORAFIN", MainModule.FormatoHora(.txtHoraFin.Text))

                    If objSolicitudTransporte.Actualizar_Fecha_Guia_Transportista(objParameter) = 1 Then
                        'cambiando los valores de la grilla de cargoplan
                        Me.gwdDatos.Item("HORAINI", lint_indice).Value = .txtHoraInicio.Text
                        Me.gwdDatos.Item("HORAFIN", lint_indice).Value = .txtHoraFin.Text

                        Me.gwdDatos.Item("FECETD_S_P", lint_indice).Value = .dtpFechaEstimadaSalida.Value.ToShortDateString
                        Me.gwdDatos.Item("FECETA_S_P", lint_indice).Value = IIf(.dtpFechaEstimadaLlegada.Checked, .dtpFechaEstimadaLlegada.Value.ToShortDateString, "")
                        Me.gwdDatos.Item("FEMVLH_S_P", lint_indice).Value = .dtpFechaRealSalida.Value.ToShortDateString
                        Me.gwdDatos.Item("FCHFTR_S_P", lint_indice).Value = IIf(.dtpFechaRealLlegada.Checked, .dtpFechaRealLlegada.Value.ToShortDateString, "")


                        HelpClass.MsgBox("Se Actualizó Satisfactoriamente", MessageBoxIcon.Information)
                    Else
                        HelpClass.MsgBox("Ocurrió un Error al Actualizar la Información", MessageBoxIcon.Error)
                    End If

                End If
            End With
        Catch : End Try
    End Sub

    'Private Sub txtNroSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
    '    If Not IsCopypage Then
    '        If e.KeyChar = "." Then
    '            e.Handled = False
    '            Exit Sub
    '        End If
    '        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    '    End If

    'End Sub

    '==================EXPORTAR CARGOPLANES
    Private Sub btnExportaCargoPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportaCargoPlan.Click
        Try
            bExcelFact = False
            ProcesoExportar_CargoPlan()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExpCargoPlanCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpCargoPlanCosto.Click
        Try
            bExcelFact = True
            ProcesoExportar_CargoPlan()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnExportarCargoPlanMasivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarCargoPlanMasivo.Click
        Try
            bExcelFact = False
            ProcesoExportar_CargoPlanMasivo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 
    End Sub

    Private Sub btnExpCargoPlanMasivoCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpCargoPlanMasivoCosto.Click
        Try
            bExcelFact = True
            ProcesoExportar_CargoPlanMasivo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub ProcesoExportar_CargoPlan()
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub 'OrElse Me.dtgRecursosAsignados.RowCount = 0 OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.dtgGuiasSeleccionadas.RowCount = 0 Then Exit Sub
        Dim objSolicitudTransporte As Solicitud_Transporte_BLL
        Dim oSolTrans As New Solicitud_Transporte
        Dim objDt As DataTable
        Dim objDsPreliminar As DataSet
        Dim objDs As DataSet
        Dim strNroCargoPlan As String = ""
        Dim frmConsistencia As frmConsistenciaCargoPlan
        Select Case Me.gwdDatos.Item("CMEDTR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            Case 1 'AEREO
                'frmConsistencia = New frmConsistenciaCargoPlan
                'With frmConsistencia
                '  .Compania = Me.cmbCompania.CCMPN_CodigoCompania ' gwdDatos.Item("CCMPN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .NroSolicitud = Me.gwdDatos.Item("NCSOTR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .NroCorrelativo = Me.gwdDatos.Item("NCRRSR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .NroOperacion = Me.gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .CodigoTransportista = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .Transportista = Me.gwdDatos.Item("TCMTRT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .GuiaTransporte = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .GuiaTransporte_STR = Me.gwdDatos.Item("NGUIRM_S_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .Planta = Me.cmbPlanta.Planta
                '  .ClienteNombre = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                '  .bExcelFact = bExcelFact
                '  .MedioTransporte = 1
                '  If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'End With

                objSolicitudTransporte = New Solicitud_Transporte_BLL
                objDt = New DataTable
                objDsPreliminar = New DataSet
                objDs = New DataSet
                '=================LLAMADA AL SOTRE QUE TRAE EL DATATABLE======================
                oSolTrans.PSCTRMNC = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.PSNGUIRM = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.CPLNDV = Me.gwdDatos.Item("CPLNDV_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.CCLNT = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Aereo(oSolTrans)
                objDt = objDsPreliminar.Tables("T_Detalle").Copy
                objDt.TableName = "Aereo"
                objDt.Columns.Remove("CCLNT")
                objDt.Columns.Remove("CREFFW")
                objDt.Columns.Remove("TCMPAL")
                objDt.Columns.Remove("NGUIRM")
                objDt.Columns.Remove("PESO_VOL")
                objDt.Columns.Remove("POR")
                objDt.Columns.Remove("CLIENTE")
                objDs.Tables.Add(objDt.Copy)
                If objDs.Tables(0).Rows.Count = 0 Then Exit Sub 'SI NO CONTIENE DETALLE NO SE EXPORTA
                '============FILTRO================
                Dim htFiltro As New Hashtable
                htFiltro.Add("TITULO_1", "REPORTE DE VUELO : " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRANSPORTISTA").ToString)
                htFiltro.Add("TITULO_2", "AVION : " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRACTO").ToString)
                htFiltro.Add("FECHA", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("FECHA").ToString)
                htFiltro.Add("ORIGEN", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ORIGEN").ToString)
                htFiltro.Add("DESTINO", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("DESTINO").ToString)
                htFiltro.Add("MEDIO", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRANSPORTISTA").ToString & Chr(10) & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("MODELO").ToString)
                htFiltro.Add("OPERACION", "NRO. OPERACIÓN: " & Me.gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value)
                htFiltro.Add("VER_COTIZACION", bExcelFact)
                htFiltro.Add("TARIFA_MONEDA", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("CMNTRN").ToString)
                htFiltro.Add("TARIFA_MONTO", Convert.ToDouble(objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ITRSRT")).ToString)
                htFiltro.Add("ESTADO_ENTREGA", "ESTADO DE ENTREGA: " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ESTADO_ENTREGA").ToString)

                'strNroCargoPlan = "00" & CStr(oSolTrans.PSNGUIRM).Substring(0, 1) & "-" & CStr(oSolTrans.PSNGUIRM).Substring(1)
                strNroCargoPlan = oSolTrans.PSNGUIRM.ToString.PadLeft(10, "0").Substring(0, 3) & "-" & oSolTrans.PSNGUIRM.ToString.PadLeft(10, "0").Substring(3)
                htFiltro.Add("CARGO_PLAN", "NRO. CARGO PLAN : " & strNroCargoPlan)
                '====================RESUMEN LOTES===============
                '================================================
                objDs.Tables.Add(objDsPreliminar.Tables("T_ResLote").Copy)
                objDs.Tables.Add(objDsPreliminar.Tables("ResCuenta").Copy)
                Dim htTotales As New Hashtable
                '============TOTALES==============
                '=================================
                htTotales.Add("T_KILO", objDsPreliminar.Tables("T_Totales").Rows(0).Item("PESO").ToString)
                htTotales.Add("T_M3", objDsPreliminar.Tables("T_Totales").Rows(0).Item("M3").ToString)
                htTotales.Add("T_BULTO", objDsPreliminar.Tables("T_Totales").Rows(0).Item("BULTOS").ToString)
                '=================================
                If oSolTrans.CCLNT = "11731" Then
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Aereo_Unitario_Plus(objDs, htFiltro, htTotales)
                Else
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Aereo_Unitario(objDs, htFiltro, htTotales)
                End If

            Case 2 'MARITIMO
            Case 3 'POSTAL
            Case 4 'TERRESTRE
                frmConsistencia = New frmConsistenciaCargoPlan
                With frmConsistencia
                    .Compania = Me.cmbCompania.CCMPN_CodigoCompania ' gwdDatos.Item("CCMPN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .NroSolicitud = Me.gwdDatos.Item("NCSOTR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .NroCorrelativo = Me.gwdDatos.Item("NCRRSR_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .NroOperacion = Me.gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .CodigoTransportista = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .Transportista = Me.gwdDatos.Item("TCMTRT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .GuiaTransporte = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .GuiaTransporte_STR = Me.gwdDatos.Item("NGUIRM_S_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .Planta = Me.gwdDatos.Item("CPLNDV_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .ClienteNombre = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .MedioTransporte = 4
                    .bExcelFact = bExcelFact
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                End With
            Case 5 'FLUVIAL       
                objSolicitudTransporte = New Solicitud_Transporte_BLL
                objDt = New DataTable
                objDsPreliminar = New DataSet
                oSolTrans.PSCTRMNC = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.PSNGUIRM = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
                oSolTrans.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                oSolTrans.CCLNT = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value

                '=======RUTA DE IMAGEN A LLAMAR PARA SER ENVIADO A LA FUNCION=======

                Dim dt As DataTable
                'Dim ws As New StorageFileManager.clsFileManager
                objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Fluvial(oSolTrans)
                If objDsPreliminar.Tables.Count > 0 Then
                    dt = objDsPreliminar.Tables(0)
                    dt.Columns.Add("Image", Type.GetType("System.Byte[]"))
                    'For Each dr As DataRow In dt.Rows
                    '    dr.Item("Image") = ws.getFileFirstList(dr.Item("NMRGIM"))
                    '    dt.AcceptChanges()
                    'Next
                    objDsPreliminar.AcceptChanges()
                    If objDsPreliminar.Tables(3).Rows.Count = 0 Then
                        HelpClass.MsgBox("La guía de transportes no contien información necesaria para realizar el Cargo Plan Fluvial")
                        Exit Sub
                    End If
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Fluvial_Unitario_Plus(objDsPreliminar)
                End If

        End Select
    End Sub

    Private Sub ProcesoExportar_CargoPlanMasivo()
        Dim PlantaSel As String = ""
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        If txtClienteFiltro.pCodigo = 0 Then
            HelpClass.MsgBox("Falta elegir Cliente", MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim objSolicitudTransporte As Solicitud_Transporte_BLL
        Dim objDsPreliminar As DataSet
        Dim oSolTrans As New Solicitud_Transporte
        oSolTrans.CCMPN = cmbCompania.CCMPN_CodigoCompania
        oSolTrans.CDVSN = cmbDivision.Division
        ''Cambio
        PlantaSel = DevuelvePlantaSeleccionadas()
        'If GetPlanta().Trim.Equals("") Then
        '    Exit Sub
        'End If
        'oSolTrans.CPLNDV_S = Me.GetPlanta()
        If PlantaSel.Trim.Equals("") Then
            MessageBox.Show("Seleccione planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        oSolTrans.CPLNDV_S = PlantaSel

        oSolTrans.CCLNT = txtClienteFiltro.pCodigo
        oSolTrans.CTRSPT = txtTransportista.pCodigoRNS
        If ckbRangoFechas.Checked Then
            oSolTrans.FE_INI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Text)
            oSolTrans.FE_FIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Text)
        Else
            oSolTrans.FE_INI = 0
            oSolTrans.FE_FIN = HelpClass.CFecha_a_Numero8Digitos(Now)
        End If
        oSolTrans.CLCLOR = cmbOrigen.Text.Trim
        oSolTrans.CLCLDS = cmbDestino.Text.Trim
        If Me.txtNroDocumento.Text.Trim.Equals("") Then
            Me.txtNroDocumento.Text = "0"
        End If
        oSolTrans.NCSOTR = 0
        oSolTrans.NOPRCN = 0
        oSolTrans.NGUITR = 0
        oSolTrans.NGUIRM = 0
        oSolTrans.NDCMFC = 0
        oSolTrans.NDCPRF = 0
        oSolTrans.NPRLQD = 0
        Select Case cmbTipoDocumento.SelectedValue
            Case "SOL"
                oSolTrans.NCSOTR = Me.txtNroDocumento.Text.Trim
            Case "OPE"
                oSolTrans.NOPRCN = Me.txtNroDocumento.Text.Trim
            Case "GTR"
                oSolTrans.NGUITR = Me.txtNroDocumento.Text.Trim
            Case "GRM"
                oSolTrans.NGUIRM = Me.txtNroDocumento.Text.Trim
            Case "PRF"
                oSolTrans.NDCPRF = Me.txtNroDocumento.Text.Trim
            Case "PRL"
                oSolTrans.NPRLQD = Me.txtNroDocumento.Text.Trim
            Case "FAC"
                oSolTrans.NDCMFC = Me.txtNroDocumento.Text.Trim
            Case Else
        End Select

        Select Case cboMedioTransporteFiltro.SelectedValue
            Case 1 'AEREO
                objSolicitudTransporte = New Solicitud_Transporte_BLL
                objDsPreliminar = New DataSet
                objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Aereo_ALL(oSolTrans)
                'AgregarDatosReferencialesGuia(objDsPreliminar)
                If oSolTrans.CCLNT = "11731" Then
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Aereo_Masivo_Plus(objDsPreliminar, bExcelFact)  ' bExcelFact = Permiso para visualizar costos
                Else
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Aereo_Masivo(objDsPreliminar, bExcelFact)  ' bExcelFact = Permiso para visualizar costos
                End If



            Case 2 'MARITIMO
            Case 3 'POSTAL
            Case 4 'TERRESTRE
                objSolicitudTransporte = New Solicitud_Transporte_BLL
                objDsPreliminar = New DataSet
                Dim objLogica As New DocsAdjuntos_SolTransporte_BLL
                objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Terrestre_All(oSolTrans)
                ' AgregarDatosReferencialesGuia(objDsPreliminar)
                If objDsPreliminar.Tables(0).Rows.Count > 0 Then
                    If oSolTrans.CCLNT = "11731" Then
                        Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Terrestre_Masivo_Plus(objDsPreliminar, bExcelFact) ' bExcelFact = Permiso para visualizar costos
                    Else
                        Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Terrestre_Masivo(objDsPreliminar, bExcelFact) ' bExcelFact = Permiso para visualizar costos
                    End If
                End If


            Case 5 'FLUVIAL 
                objSolicitudTransporte = New Solicitud_Transporte_BLL
                objDsPreliminar = New DataSet
                Dim objLogica As New DocsAdjuntos_SolTransporte_BLL

                Dim dt As DataTable
                'Dim ws As New StorageFileManager.clsFileManager
                objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Fluvial_ALL(oSolTrans)
                ' AgregarDatosReferencialesGuia(objDsPreliminar)
                dt = objDsPreliminar.Tables(0)
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"))
              
                objDsPreliminar.AcceptChanges()

                If oSolTrans.CCLNT = "11731" Then
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Fluvial_Masivo_Plus(objDsPreliminar)
                Else
                    Ransa.Utilitario.HelpClass_NPOI.ExportExcelPlusPetrol_Fluvial_Masivo(objDsPreliminar)
                End If

        End Select
        Me.txtNroDocumento.Text = IIf(Me.txtNroDocumento.Text = "0", "", Me.txtNroDocumento.Text)
    End Sub

    'Private Sub AgregarDatosReferencialesGuia(ByRef oDS As DataSet)

    '    'Agregando el campo ''Ruta''
    '    Dim dcolumn As DataColumn = New DataColumn("RUTA", GetType(System.String))
    '    'dcolumn.SetOrdinal(5)
    '    oDS.Tables("DT_GENERAL").Columns.Add(dcolumn)

    '    'Función para obtener la ruta de origen y destino



    '    'Agregando las columnas de Datos Adicionales
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("CLASE_CARGA", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("PROGRAMADOR", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("CORREO_APROBACION", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("SOLICITANTE", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("APROBADOR", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("GERENCIA", GetType(System.String)))
    '    oDS.Tables("DT_GENERAL").Columns.Add(New DataColumn("AREA", GetType(System.String)))
    '    Try
    '        Dim objGuiaRemision As New GuiaRemision_BLL
    '        Dim objSolicitud As New Solicitud_Transporte_BLL

    '        'por cada fila iteramos el resultado
    '        For i As Integer = 0 To oDS.Tables("DT_GENERAL").Rows.Count - 1

    '            'Por cada fila busca posibles resultados 
    '            Dim dtb As DataTable = objGuiaRemision.ObtieneDatosAdicionalesGuia(oDS.Tables(0).Rows(i).Item("NGUIRM").ToString(), oDS.Tables(0).Rows(i).Item("CCLNT").ToString())
    '            If dtb.Rows.Count > 0 Then
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("CLASE_CARGA") = dtb.Rows(0).Item("CLCRGA").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("PROGRAMADOR") = dtb.Rows(0).Item("UPROGM").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("CORREO_APROBACION") = dtb.Rows(0).Item("EMAPRB").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("SOLICITANTE") = dtb.Rows(0).Item("USLCNT").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("APROBADOR") = dtb.Rows(0).Item("APRBDO").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("GERENCIA") = dtb.Rows(0).Item("GRENCI").ToString()
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("AREA") = dtb.Rows(0).Item("AREASL").ToString()
    '            End If

    '            Dim dtbRuta As DataTable = objSolicitud.ObtieneRutaSolicitud(oDS.Tables(0).Rows(i).Item("NOPRCN").ToString(), oDS.Tables(0).Rows(i).Item("CCLNT").ToString())
    '            If dtb.Rows.Count > 0 Then
    '                oDS.Tables("DT_GENERAL").Rows(i).Item("RUTA") = dtbRuta.Rows(0).Item("RUTA").ToString()
    '            End If


    '        Next
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnActualizacionMasivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizacionMasivo.Click
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        If Not (Me.txtClienteFiltro.pCodigo = 11731 OrElse Me.txtClienteFiltro.pCodigo = 30507) Then Exit Sub
        Dim objSolicitudTransporte As NEGOCIO.Operaciones.Solicitud_Transporte_BLL
        Dim oSolTrans As ENTIDADES.Operaciones.Solicitud_Transporte
        Dim objHashtable As Hashtable
        Dim dblPesoTotal As Double = 0
        For lintCount As Integer = 0 To Me.gwdDatos.RowCount - 1
            'If gwdDatos.Rows(lintCount).DefaultCellStyle.BackColor = Color.MistyRose Then
            oSolTrans = New Solicitud_Transporte
            oSolTrans.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania ' gwdDatos.Item("CCMPN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
            oSolTrans.NCSOTR = Me.gwdDatos.Item("NCSOTR_P", lintCount).Value
            oSolTrans.NCRRSR = Me.gwdDatos.Item("NCRRSR_P", lintCount).Value
            oSolTrans.PSCTRMNC = Me.gwdDatos.Item("CTRMNC_P", lintCount).Value
            oSolTrans.PSNGUIRM = Me.gwdDatos.Item("NGUIRM_P", lintCount).Value
            oSolTrans.CPLNDV = Me.gwdDatos.Item("CPLNDV_P", Me.gwdDatos.CurrentCellAddress.Y).Value 'Me.cmbPlanta.Planta
            oSolTrans.CCLNT = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            objSolicitudTransporte = New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
            Dim objDataTable As DataTable = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Aereo(oSolTrans).Tables(2)
            For Each objRow As DataRow In objDataTable.Rows
                If objRow("CREFFW").ToString.Trim <> "" Then
                    objRow("PESO_VOL") = objRow("PESO")
                    dblPesoTotal = dblPesoTotal + objRow("PESO_VOL")
                End If
            Next
            For Each objRow As DataRow In objDataTable.Rows
                If objRow("CREFFW").ToString.Trim <> "" Then
                    objHashtable = New Hashtable
                    objHashtable.Add("CTRMNC", oSolTrans.PSCTRMNC)
                    objHashtable.Add("NGUITR", oSolTrans.PSNGUIRM)
                    objHashtable.Add("CCLNT", objRow("CCLNT"))
                    objHashtable.Add("NGUIRM", objRow("NGUIRM"))
                    objHashtable.Add("CREFFW", objRow("CREFFW"))
                    objHashtable.Add("PSOVOL", objRow("PESO_VOL"))
                    objHashtable.Add("PRCRMT", Math.Round((objRow("PESO_VOL") / dblPesoTotal) * 100))
                    objHashtable.Add("CUSCRT", MainModule.USUARIO)
                    objHashtable.Add("FCHCRT", HelpClass.TodayNumeric)
                    objHashtable.Add("HRACRT", HelpClass.NowNumeric)
                    objHashtable.Add("NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
                    objHashtable.Add("CULUSA", MainModule.USUARIO)
                    objHashtable.Add("FULTAC", HelpClass.TodayNumeric)
                    objHashtable.Add("HULTAC", HelpClass.NowNumeric)
                    objHashtable.Add("NTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                    objHashtable.Add("CCMPN", oSolTrans.CCMPN)
                    objSolicitudTransporte.Actualizar_Peso_Volumen__CargoPlan(objHashtable)
                End If
            Next
            'End If
        Next

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.dtgGuiasSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim obj_Logica As New GuiaTransportista_BLL
        Dim obj_EntidadGuia As GuiaTransportista
        Dim frmMovimiento As CTL_GUIA_DE_TRANSPORTISTA.frmMovimiento
        Dim obj_Table As DataTable
        Try
            obj_EntidadGuia = New GuiaTransportista
            'Llenando los datos de la guia de Anexo
            obj_EntidadGuia.CTRMNC = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.NGUIRM = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.CCLNT = Me.gwdDatos.Item("CCLNT_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.NRGUCL = Me.dtgGuiasSeleccionadas.Item("NRGUCL_R", Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y).Value
            obj_EntidadGuia.NRHJCR = Me.dtgGuiasSeleccionadas.Item("CCLNT_R", Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y).Value
            obj_EntidadGuia.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            obj_EntidadGuia.CDVSN = "R"
            obj_EntidadGuia.CPLNDV = Me.gwdDatos.Item("CPLNDV_P", Me.gwdDatos.CurrentCellAddress.Y).Value  'Me.cmbPlanta.Planta
            obj_Table = New DataTable
            obj_Table = obj_Logica.Lista_Guia_Salida_Zona_GR(obj_EntidadGuia)
            If obj_Table.Rows.Count > 1 Then
                frmMovimiento = New CTL_GUIA_DE_TRANSPORTISTA.frmMovimiento
                With frmMovimiento
                    .Tabla = obj_Table
                    .ShowDialog()
                    obj_EntidadGuia.NRGUSA = .Guia_Salida
                End With
            Else
                If obj_Table.Rows.Count = 0 Then
                    HelpClass.MsgBox("Guía de Remisión, no Emitida por SOLMIN Almacenes", MessageBoxIcon.Information)
                    Exit Sub
                End If
                obj_EntidadGuia.NRGUSA = obj_Table.Rows(0).Item("NRGUSA")
            End If
            'Proceso de registro
            If obj_Logica.Importar_Bulto_Guia_Remision(obj_EntidadGuia).CTRMNC <> 0 Then
                HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
                Me.Listar_Guias_Remision_Cargo_Plan()
                Me.Listar_Ordenes_Compra_Cargo_Plan()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Me.dtgGuiasSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim obj_Logica As New GuiaTransportista_BLL
        Dim obj_EntidadGuia As GuiaTransportista
        Try
            obj_EntidadGuia = New GuiaTransportista
            'Llenando los datos de la guia de Anexo
            obj_EntidadGuia.NOPRCN = Me.gwdDatos.Item("NOPRCN_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.CTRMNC = Me.gwdDatos.Item("CTRMNC_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.NGUIRM = Me.gwdDatos.Item("NGUIRM_P", Me.gwdDatos.CurrentCellAddress.Y).Value
            obj_EntidadGuia.CCLNT = Me.dtgGuiasSeleccionadas.Item("CCLNT_R", Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y).Value
            obj_EntidadGuia.NRGUCL = Me.dtgGuiasSeleccionadas.Item("NRGUCL_R", Me.dtgGuiasSeleccionadas.CurrentCellAddress.Y).Value
            If obj_Logica.Eliminar_Guia_Remision_Actualizacion(obj_EntidadGuia).CTRMNC <> 0 Then
                HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
                Me.Listar_Guias_Remision_Cargo_Plan()
                Me.Listar_Ordenes_Compra_Cargo_Plan()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function TransformarGrilla(ByVal gv As DataGridView, ByVal odtg As DataTable) As DataTable
        ''Limpiamos las Columnas que no estan en Tag de la Grilla
        Dim Columnas As String()
        Columnas = Split(gv.Tag, ",")
        Dim bol As Boolean = False

        For Columnax As Integer = odtg.Columns.Count - 1 To 0 Step -1
            bol = False
            For Each Columna As String In Columnas
                If Columna.Trim.Equals(odtg.Columns(Columnax).ColumnName.Trim) Then
                    bol = True
                    Exit For
                End If
            Next
            If bol = False Then
                odtg.Columns.RemoveAt(Columnax)
            End If
        Next

        'Nombre Para los Detalles
        ''Cambiamos los Indices de las Columnas (Ordenamos el Detalle)
        '-------------------------------------------------
        For Columna As Integer = 0 To gv.Columns.Count - 1
            For ColumnaX As Integer = 0 To odtg.Columns.Count - 1
                If gv.Columns(Columna).DataPropertyName.Trim = odtg.Columns(ColumnaX).ColumnName Then
                    odtg.Columns(ColumnaX).ColumnName = gv.Columns(Columna).HeaderText.Trim
                End If
            Next
        Next

        '-------------------------------------------------
        Dim colum As New Data.DataColumn
        Dim dtCopyColum As DataTable = odtg.Clone

        Dim intIndexDetalle As Integer
        For Columna As Integer = 0 To gv.Columns.Count - 1
            For Each colum In dtCopyColum.Columns
                If gv.Columns(Columna).HeaderText.Trim = colum.ColumnName Then
                    odtg.Columns(colum.ColumnName).SetOrdinal(intIndexDetalle)
                    odtg.Columns(colum.ColumnName).ColumnName = gv.Columns(Columna).HeaderText.Trim
                    intIndexDetalle += 1
                End If
            Next
        Next
        Return odtg
        '-------------------------------------------------
    End Function

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim ODs As New DataSet
        Dim objDt As DataTable
        objDt = TransformarGrilla(Me.gwdDatos, HelpClass.GetDataSetNative(Me.gwdDatos.DataSource))
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
    End Sub

   

    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged
        If KryptonCheckBox1.Checked Then
            KryptonComboBox1.Enabled = True
        Else
            KryptonComboBox1.Enabled = False
        End If
    End Sub


   
End Class
