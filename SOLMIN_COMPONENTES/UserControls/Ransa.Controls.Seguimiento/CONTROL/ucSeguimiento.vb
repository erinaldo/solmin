Imports Ransa.Utilitario
Public Class ucSeguimiento
    Private _pNORSCI As Decimal = 0
    Private _pCCLNT As Decimal = 0
    Private _pCCMPN As String = ""
    Private _pCDVSN As String = ""
    Private TabActivo As Double = 0
    Private oDt As New DataTable
    Private dtDocumento As New DataTable
    Private oTab As New clsTab
    Private oDs As New DataSet
    Friend WithEvents oDtgVar As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ctmGrillaDinamica As System.Windows.Forms.ContextMenuStrip
    Private strCodVariable As String
    Private obeEmbarqueConsulta As New beEmbarqueConsulta

    Public Sub pLoad()


        gvOrdenesEmb.AutoGenerateColumns = False
        dtgDocumentos.AutoGenerateColumns = False
        dtgDocumentosAdjuntos.AutoGenerateColumns = False
        dtgObsCargaInternacional.AutoGenerateColumns = False
        dtgObservaciones.AutoGenerateColumns = False
        dtgServicios.AutoGenerateColumns = False
        dtgCheckPoint.AutoGenerateColumns = False
        dtgCarga.AutoGenerateColumns = False
        dtgDocAdjuntos.AutoGenerateColumns = False
        gbxFianza.Visible = False
        lblFechaVencImport.Visible = False
        mskFVencRegimen.Visible = False
        Me.txtTransTercero.Visible = False
        Dim oDs As New DataSet
        oDs.Tables.Clear()
        Limpiar_Tabs()
        Crear_TabPages()
    End Sub

    Private Sub Crear_TabPages()
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oEmbarqueConsulta As New clsEmbarqueConsultaBL
        Dim oTabVar As System.Windows.Forms.TabPage

        oDt = oEmbarqueConsulta.Lista_Para_Crear_TabPages()

        Dim CellStyle As New System.Windows.Forms.DataGridViewCellStyle
        CellStyle.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        CellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        CellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        CellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText

        For intCont = 0 To oDt.Rows.Count - 1
            oTabVar = New System.Windows.Forms.TabPage()
            oTabVar.Name = "tab" & intCont
            oTabVar.Size = New System.Drawing.Size(998, 282)
            oTabVar.TabIndex = 1
            oTabVar.Text = oDt.Rows(intCont).Item("NOMVAR")
            oTabVar.BackColor = Color.White
            oTabVar.ResumeLayout(False)
            oDtgVar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
            oDtgVar.AutoGenerateColumns = False
            oDtgVar.Name = oDt.Rows(intCont).Item("VALVAR")
            oDtgVar.Size = New System.Drawing.Size(998, 282)
            oDtgVar.Text = oDt.Rows(intCont).Item("NOMVAR")
            oDtgVar.StateCommon.Background.Color1 = Color.White

            oDtgVar.AllowUserToAddRows = False
            oDtgVar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            oDtgVar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            oDtgVar.Dock = DockStyle.Fill
            oDtgVar.AccessibleName = oDt.Rows(intCont).Item("VALVAR")
            oDtgVar.RowsDefaultCellStyle = CellStyle

            oDtgVar.StateCommon.Background.Color1 = System.Drawing.Color.White
            oDtgVar.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
            oDtgVar.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText

            oDtgVar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Me.Controls.Add(oDtgVar)
            oTabVar.Controls.Add(oDtgVar)
            Me.TabControl3.Controls.Add(oTabVar)
            LLenar_Grilla_Dinamica(oDt.Rows(intCont).Item("VALVAR"))
        Next
    End Sub



    Private Sub LLenar_Grilla_Dinamica(ByVal pstrDescripcion As String)

        Dim oDt As New DataTable
        oDt = New DataTable
        Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
        oDt = oEmbarqueConsultaBL.Lista_Concepto_Costo_Embarque(pstrDescripcion)

        oDt.Columns.Add(New DataColumn("IVLORG"))
        oDt.Columns.Add(New DataColumn("NMONOC"))
        oDt.Columns.Add(New DataColumn("IVLDOL"))
        oDt.Columns.Add(New DataColumn("TOBS"))
        oDt.Columns.Add(New DataColumn("CMNDA1", GetType(System.Double)))
        oDt.TableName = pstrDescripcion
        oDs.Tables.Add(oDt.Copy)


        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CVARBL"
        oDcTx.HeaderText = "CVARBL"
        oDcTx.DataPropertyName = "CVARBL"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        oDtgVar.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "VALVAR"
        oDcTx.HeaderText = "VALVAR"
        oDcTx.DataPropertyName = "VALVAR"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        oDtgVar.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOMVAR"
        oDcTx.HeaderText = "Concepto"
        oDcTx.DataPropertyName = "NOMVAR"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Visible = True
        oDcTx.Width = 350
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDtgVar.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "IVLORG"
        oDcTx.HeaderText = "Monto (Moneda Origen)"
        oDcTx.DataPropertyName = "IVLORG"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = True
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDcTx.Width = 150
        oDtgVar.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NMONOC"
        oDcTx.HeaderText = "Moneda"
        oDcTx.DataPropertyName = "NMONOC"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = True
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDcTx.Width = 120
        oDtgVar.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "IVLDOL"
        oDcTx.HeaderText = "Monto Dólares"
        oDcTx.DataPropertyName = "IVLDOL"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = True
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDcTx.Width = 150
        oDtgVar.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Referencia"
        oDcTx.DataPropertyName = "TOBS"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = True
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDcTx.Width = 300
        oDtgVar.Columns.Add(oDcTx)


   


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CMNDA1"
        oDcTx.HeaderText = "CMNDA1"
        oDcTx.DataPropertyName = "CMNDA1"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = False
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.ReadOnly = True
        oDtgVar.Columns.Add(oDcTx)

      
        oDtgVar.DataSource = oDs.Tables.Item(pstrDescripcion)

        Dim s As String = ""
       

    End Sub



    Private Sub Limpiar_Costos_Totales_X_Embarque()
        Dim intCont, intRow As Integer
        Dim oBj As Object
        For intCont = 0 To oDs.Tables.Count - 1
            For intRow = 0 To oDs.Tables.Item(intCont).Rows.Count - 1
                oDs.Tables.Item(intCont).Rows(intRow).Item("IVLORG") = vbNullString
                oDs.Tables.Item(intCont).Rows(intRow).Item("IVLDOL") = vbNullString
                oDs.Tables.Item(intCont).Rows(intRow).Item("TOBS") = DBNull.Value
                oDs.Tables.Item(intCont).Rows(intRow).Item("CMNDA1") = DBNull.Value
                oDs.Tables.Item(intCont).Rows(intRow).Item("NMONOC") = vbNullString
                oBj = Me.TabControl3.Controls.Item("tab" & intCont).Controls.Item(oDs.Tables.Item(intCont).Rows(intRow).Item("CVARBL").ToString.Trim)
            Next
        Next
    End Sub

    Public Sub pLimpiar()
        _pNORSCI = 0
        _pCCLNT = 0
        _pCCMPN = ""
        _pCDVSN = ""
        Limpiar_Tabs()
        If oTab IsNot Nothing Then
            oTab.Limpiar()
        End If
        oTab = New clsTab
    End Sub

    Sub Limpiar_Tabs()
        gvOrdenesEmb.DataSource = Nothing
        dtgCarga.DataSource = Nothing
        dtgDocumentos.DataSource = Nothing
        dtgDocumentosAdjuntos.DataSource = Nothing
        dtgObsCargaInternacional.DataSource = Nothing
        dtgObservaciones.DataSource = Nothing
        dtgServicios.DataSource = Nothing
        dtgCheckPoint.DataSource = Nothing
        dtgDocAdjuntos.DataSource = Nothing

        txtEmbarqueMan.Text = ""
        mskEmbarque.Text = ""
        txtEstado.Text = ""
        txtNumEmbarcador.Text = ""
        txtNumDocEmb.Text = ""
        ctbAgenteDeCarga.Text = ""
        ctbMedioTransportes.Text = ""
        ctbCiaTransp.Text = ""
        ctbNave.Text = ""
        ctbTerminal.Text = ""
        cmbPaisOrg.Text = ""
        cmbPuertoOrg.Text = ""
        mskETD.Text = ""
        cmbPaisDest.Text = ""
        cmbPuertoDest.Text = ""
        mskETA.Text = ""
        txtM3.Text = ""
        txtDiaLibre.Text = ""
        txtKg.Text = ""
        txtSobreEstadia.Text = ""
        txtPolizaNum.Text = ""
        cmbPolizaBanco.Text = ""
        mskPolizaFecEmi.Text = ""
        mskPolizaFecVen.Text = ""
        cmbPolizaMoneda.Text = ""
        txtPolizaMonto.Text = ""
        txtNroOS.Text = ""
        cmbZona.Text = ""
        mskApertura.Text = ""
        txtNroOC.Text = ""
        UcProveedor_tab.Text = ""
        txtRefCli.Text = ""
        txtRefDoc.Text = ""
        txtMercaderia.Text = ""
        cboRegimen.Text = ""
        mskFVencRegimen.Text = ""
        cmbTipoDespachos.Text = ""
        cboCanal.Text = ""
        cmbTransporte.Text = ""
        txtTransTercero.Text = ""
        txtBeneficio.Text = ""
        txtDUA.Text = ""
        uc_Transportista.Text = ""
        Uc_Almacen_Local.Text = ""
        txtDireccion.Text = ""
        txtHorario.Text = ""
        txtContacto.Text = ""
        txtObservacion.Text = ""

        Limpiar_Costos_Totales_X_Embarque()
    End Sub




    Public Sub pActualizarInfoEmbarque(ByVal pCCMPN As String, ByVal pCDVSN As String, ByVal pCCLNT As Decimal, ByVal pNORSCI As Decimal)

        If pNORSCI = 0 Then
            pLimpiar()
            Exit Sub
        ElseIf _pNORSCI <> pNORSCI Then
            pLimpiar()
        End If

        _pCCMPN = pCCMPN
        _pCDVSN = pCDVSN
        _pCCLNT = pCCLNT
        _pNORSCI = pNORSCI

        Dim TabActivo As Int32 = TabControl1.SelectedIndex
        Dim TabName = TabControl1.TabPages(TabActivo).Name

        If Not oTab.Tab_Cargado(TabActivo) Then

            Select Case TabName
                Case "TabOrdenesEmbarcadas"
                    Llenar_Detalle_EmbarqueConsulta() 'Ordenes Embarcadas

                Case "TabApertura"
                    Listar_Datos_AperuraOS_Consulta() 'Apertura O/S

                Case "TabDocAdjuntos"
                    Llenar_Documentos_Embarque() 'Documentos Adjuntos

                Case "TabDatos"
                    Listar_Datos_EmbarqueConsulta() 'Datos Embarque

                Case "TabCostoSeguimiento"
                    Listar_Costos_Seguimiento() 'Costos del Seguimiento y Documentos de los costos del Seguimiento

                Case "TabObservaciones"
                    Llenar_Observaciones_Consulta() 'Observaciones del Seguimiento y Observaciones Carga Internaciona

                Case "TabServicios"
                    Llenar_Servicios_X_Embarque_Consulta() 'Servicios

                Case "TabCheckPoints"
                    Llenar_CheckPoint_Consulta() 'CheckPoints
            End Select
            oTab.Cargar_Tab(TabActivo)
        End If
    End Sub

    Private Sub Llenar_Detalle_EmbarqueConsulta()
        Dim oDt As DataTable
        Dim oEmbarqueConsulta As New clsEmbarqueConsultaBL
        gvOrdenesEmb.DataSource = Nothing
        oDt = oEmbarqueConsulta.Lista_Detalle_OC_Embarque_Ajuste_Consulta(_pCCLNT, _pNORSCI)
        gvOrdenesEmb.DataSource = oDt
    End Sub

    Sub Listar_Datos_AperuraOS_Consulta()
        Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
        obeEmbarqueConsulta = New beEmbarqueConsulta
        Dim dtDetalle As New DataTable

        Dim Hasdatos As New Hashtable
        Hasdatos = oEmbarqueConsultaBL.Lista_DatosAperturaOS(_pCCLNT, _pNORSCI)
        obeEmbarqueConsulta = Hasdatos("APERTURA")
        txtNroOS.Text = obeEmbarqueConsulta.PNPNNMOS
        cmbZona.Text = obeEmbarqueConsulta.PSTZNFCC
        mskApertura.Text = obeEmbarqueConsulta.PSFCEMSN
        txtNroOC.Text = obeEmbarqueConsulta.PSNORCML
        UcProveedor_tab.Text = obeEmbarqueConsulta.PSTPRVCL
        txtRefCli.Text = obeEmbarqueConsulta.PSNREFCL
        txtRefDoc.Text = obeEmbarqueConsulta.PSREFDO1
        txtMercaderia.Text = obeEmbarqueConsulta.PSTOBERV
        'valida Regimen --------------------------------
        If obeEmbarqueConsulta.PNNCODRG_REG > 0 Then
            cboRegimen.Text = obeEmbarqueConsulta.PSTDSCRG
        Else
            cboRegimen.Text = ""
        End If
        Dim regimen As Decimal = obeEmbarqueConsulta.PNNCODRG_REG
        Dim IsVisible As Boolean = IsRegimenTemporal(regimen)
        lblFechaVencImport.Visible = IsVisible
        mskFVencRegimen.Visible = IsVisible
        mskFVencRegimen.Text = obeEmbarqueConsulta.PSFECVEN_REG
        '---------------------------------------------------
        cmbTipoDespachos.Text = obeEmbarqueConsulta.PSDES_TIPODESPACHO
        cboCanal.Text = obeEmbarqueConsulta.PSTCANAL
        'valida Transporte

        If obeEmbarqueConsulta.PNTRANSPORTE = 0 Then
            cmbTransporte.Text = ""
        Else
            If obeEmbarqueConsulta.PSTERCERO = "TERCEROS" Then
                cmbTransporte.Text = obeEmbarqueConsulta.PSTERCERO
                Me.txtTransTercero.Visible = True
                txtTransTercero.Text = obeEmbarqueConsulta.PSTNMCTT
            Else
                cmbTransporte.Text = obeEmbarqueConsulta.PSTERCERO
                Me.txtTransTercero.Visible = False
            End If
        End If

        txtBeneficio.Text = obeEmbarqueConsulta.PSTBFTRB
        txtDUA.Text = obeEmbarqueConsulta.PSTNRODU
        uc_Transportista.Text = obeEmbarqueConsulta.PSTCMTRT
        Uc_Almacen_Local.Text = obeEmbarqueConsulta.PNDES_ALMLOCAL
        txtDireccion.Text = obeEmbarqueConsulta.PSTDRENT
        txtHorario.Text = obeEmbarqueConsulta.PSHORATN
        txtContacto.Text = obeEmbarqueConsulta.PSTPRSCN
        txtObservacion.Text = obeEmbarqueConsulta.PSTRECOR

        dtDocumento = New DataTable
        dtgDocAdjuntos.DataSource = Nothing
        dtDetalle = Hasdatos("DETDOC")
        dtDocumento = Hasdatos("DOCUMENTOS")

        dtDocumento.Columns.Add("FLGORG", Type.GetType("System.String"))
        dtDocumento.Columns.Add("FLGCOP", Type.GetType("System.String"))
        dtDocumento.Columns.Add("NUMDOC", Type.GetType("System.Decimal"))

        Dim intCont As Integer
        Dim intContY As Integer

        For intCont = 0 To dtDetalle.Rows.Count - 1
            For intContY = 0 To dtDocumento.Rows.Count - 1
                If dtDocumento.Rows(intContY).Item("NCODRG").ToString.Trim = dtDetalle.Rows(intCont).Item("NCODRG").ToString.Trim Then
                    If dtDetalle.Rows(intCont).Item("SORDOC").ToString.Trim = "O" Then
                        dtDocumento.Rows(intContY).Item("FLGORG") = "X"
                    Else
                        dtDocumento.Rows(intContY).Item("FLGCOP") = "X"
                    End If
                    dtDocumento.Rows(intContY).Item("NUMDOC") = dtDetalle.Rows(intCont).Item("QCANTI").ToString.Trim
                    Exit For
                End If
            Next intContY
        Next intCont

        dtgDocAdjuntos.DataSource = dtDocumento

    End Sub

    Sub Llenar_Documentos_Embarque()
        Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
        Dim dt As DataTable
        dtgDocumentos.DataSource = Nothing
        dt = oEmbarqueConsultaBL.Lista_DatosDocAdjuntos(_pCCLNT, _pNORSCI)
        dtgDocumentos.DataSource = dt
       
    End Sub

    Sub Listar_Datos_EmbarqueConsulta()
        Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
        obeEmbarqueConsulta = New beEmbarqueConsulta
        Dim dt As DataTable
        dtgCarga.DataSource = Nothing
        Dim Hasdatos As New Hashtable
        Hasdatos = oEmbarqueConsultaBL.Lista_DatosEmbarqueConsulta(_pCCLNT, _pNORSCI)
        obeEmbarqueConsulta = Hasdatos("EMBARQUE")
        txtEmbarqueMan.Text = obeEmbarqueConsulta.PNNORSCI
        mskEmbarque.Text = obeEmbarqueConsulta.PSFORSCI
        txtEstado.Text = obeEmbarqueConsulta.PSSESTRG_DESC
        txtNumEmbarcador.Text = obeEmbarqueConsulta.PSNOREMB
        txtNumDocEmb.Text = obeEmbarqueConsulta.PSNDOCEM
        ctbAgenteDeCarga.Text = obeEmbarqueConsulta.PSTNMAGC
        ctbMedioTransportes.Text = obeEmbarqueConsulta.PSTNMMDT
        ctbCiaTransp.Text = obeEmbarqueConsulta.PSTNMCIN
        ctbNave.Text = obeEmbarqueConsulta.PSTCMPVP
        ctbTerminal.Text = obeEmbarqueConsulta.PSTTRMAL
        cmbPaisOrg.Text = obeEmbarqueConsulta.PSTCMPPS_ORIGEN
        cmbPuertoOrg.Text = obeEmbarqueConsulta.PSDES_CPRTOE
        mskETD.Text = obeEmbarqueConsulta.PSFAPREV
        cmbPaisDest.Text = obeEmbarqueConsulta.PSTCMPPS_DEST
        cmbPuertoDest.Text = obeEmbarqueConsulta.PSDES_CPRTOA
        mskETA.Text = obeEmbarqueConsulta.PSFAPRAR
        txtM3.Text = obeEmbarqueConsulta.PNQVOLMR
        txtDiaLibre.Text = obeEmbarqueConsulta.PNNDIALB
        txtKg.Text = obeEmbarqueConsulta.PNQPSOAR
        txtSobreEstadia.Text = obeEmbarqueConsulta.PNNDIASE
        'validar Regimen
        Dim PNREGIMEN As Decimal
        PNREGIMEN = obeEmbarqueConsulta.PNREGIMEN
        Me.gbxFianza.Visible = IsRegimenTemporal(PNREGIMEN)

        txtPolizaNum.Text = obeEmbarqueConsulta.PSNDOCUM
        cmbPolizaBanco.Text = obeEmbarqueConsulta.PSTCMBCF
        mskPolizaFecEmi.Text = obeEmbarqueConsulta.PSFECEDC
        mskPolizaFecVen.Text = obeEmbarqueConsulta.PSFECVEN
        cmbPolizaMoneda.Text = obeEmbarqueConsulta.PSTMNDA
        txtPolizaMonto.Text = obeEmbarqueConsulta.PNITTDOC
        dt = Hasdatos("TIPO_CARGA")

        dtgCarga.DataSource = dt
    End Sub

    Private Function IsRegimenTemporal(ByVal PNREGIMEN As Decimal)
        Dim isTemporal As Boolean = False
        If PNREGIMEN = 2 OrElse PNREGIMEN = 5 OrElse PNREGIMEN = 15 OrElse PNREGIMEN = 18 Then
            isTemporal = True
        Else
            isTemporal = False
        End If
        Return isTemporal
    End Function

    Sub Listar_Costos_Seguimiento()
        Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
        Dim obeDatosEmbarque_BE1 As New beEmbarqueConsulta
        Dim dt As DataTable
        Dim Hasdatos As New Hashtable
        dtgDocumentos.DataSource = Nothing
        Dim dsCostos As New DataSet
        dsCostos = oEmbarqueConsultaBL.Lista_Costos_Seguimiento(_pNORSCI)
        dt = dsCostos.Tables("DETALLE_DOCUMENTO")
        dtgDocumentosAdjuntos.DataSource = dt


         
      



    
        Dim intCont, intContTablas, intRow As Integer
        Dim oDocAperturaConsulta As New clsEmbarqueConsultaBL
        Dim oDt As DataTable
        Dim oBj As Object
        Dim Suma As Double = 0
        Dim SumaDol As Double = 0
        oDt = dsCostos.Tables("DETALLE_COSTOS")

        For intCont = 0 To oDs.Tables.Count - 1
            For intContTablas = 0 To oDs.Tables.Item(intCont).Rows.Count - 1
                For intRow = 0 To oDt.Rows.Count - 1
                    If oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString = oDt.Rows(intRow).Item("CODVAR").ToString Then
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLORG") = Double.Parse(oDt.Rows(intRow).Item("IVLORG"))
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLDOL") = Double.Parse(oDt.Rows(intRow).Item("IVLDOL"))
                        'oDs.Tables.Item(intCont).Rows(intContTablas).Item("TOBS") = Lista_Documento_Costo_X_Costo_Total_Consulta(oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString)
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("TOBS") = ""
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("CMNDA1") = oDt.Rows(intRow).Item("CMNDA1")
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("NMONOC") = oDt.Rows(intRow).Item("NMONOC")
                        oBj = Me.TabControl3.Controls.Item("tab" & intCont).Controls.Item(oDs.Tables.Item(intCont).Rows(intContTablas).Item("CVARBL").ToString.Trim)
                        oBj.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    End If
                Next intRow
            Next intContTablas
        Next intCont


        Dim s As String = ""
    End Sub

    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged
        Try
            Dim intCont As Int32 = 0
            If (TabControl3.SelectedIndex > 0) Then
                Dim oBj As Object
                Dim odtgCosto As New ComponentFactory.Krypton.Toolkit.KryptonDataGridView

                oBj = sender.Controls.Item("tab" & TabControl3.SelectedIndex - 1).Controls.Item(oDs.Tables.Item(TabControl3.SelectedIndex - 1).Rows(0).Item(0).ToString.Trim)
                odtgCosto = CType(oBj, ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
                odtgCosto.Columns("CVARBL").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Function Lista_Documento_Costo_X_Costo_Total_Consulta(ByVal strCodVariable As String) As String
    '  Dim oEmbarqueConsultaBL As New clsEmbarqueConsultaBL
    '  Dim intCont As Integer
    '  Dim strDato As String = ""
    '  Dim oDt As DataTable
    '  oDt = oEmbarqueConsultaBL.Lista_Documentos_Costo_X_Costo_Total_Embarque_Consulta(_pNORSCI, strCodVariable)
    '  For intCont = 0 To oDt.Rows.Count - 1
    '    If oDt.Rows.Count - 1 = intCont Then
    '      strDato = strDato & oDt.Rows(intCont).Item("NOMVAR").ToString.Trim & "  N° " & oDt.Rows(intCont).Item("NDOCUM").ToString.Trim
    '    Else
    '      strDato = strDato & oDt.Rows(intCont).Item("NOMVAR").ToString.Trim & "  N° " & oDt.Rows(intCont).Item("NDOCUM").ToString.Trim & Chr(10)
    '    End If
    '  Next
    '  Return strDato
    'End Function


    Private Sub dtgDocumentosAdjuntos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentosAdjuntos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim ColName As String = ""
                Dim PSURLARC As String = ""
                ColName = dtgDocumentosAdjuntos.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "DOCCOSTO_LINK"
                        Dim CCLNT As Decimal = _pCCLNT
                        Dim CCMPN As String = _pCCMPN
                        Dim NMRGIM As Decimal = dtgDocumentosAdjuntos.CurrentRow.Cells("NMRGIM_COS").Value
                        If NMRGIM = 0 Then
                            Exit Sub
                        End If
                        Dim TABLE_NAME As String = "RZOL53C"
                        'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, "", frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocCosto)
                        'ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Neutro
                        'ofrmAdjuntarDocumentos.ShowDialog()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub dtgDocumentosAdjuntos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentosAdjuntos.CellClick
        Try
            Dim intPosicion As Int32 = 0
            Dim ColName As String = ""
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                intPosicion = e.RowIndex
                ColName = dtgDocumentosAdjuntos.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "DUA"
                        Dim PSURLARC As String = ""
                        If ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("RUTA_DUA").Value).ToString.Trim.Length > 0 Then
                            'PSURLARC = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_URLARC").Value).ToString.Trim
                            Dim URLARC As String = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("RUTA_DUA").Value).ToString.Trim

                            Dim url_completo As String = URLARC
                            Process.Start(url_completo)
                        End If


                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub




    Private Sub Llenar_Observaciones_Consulta()
        Me.dtgObservaciones.DataSource = Nothing
        dtgObsCargaInternacional.DataSource = Nothing
        Dim oEmbarqueConsulta As New clsEmbarqueConsultaBL
        Dim dtObservacionEmbarque As New DataTable
        Dim odtObsCI As New DataTable
        Dim ds As New DataSet
        ds = oEmbarqueConsulta.Lista_Observacion_Embarque_Consulta(_pNORSCI)
        odtObsCI = ds.Tables("DT_OBS_CI")
        dtObservacionEmbarque = ds.Tables("DT_OBS_EMBARQUE")
        dtgObsCargaInternacional.DataSource = odtObsCI
        dtgObservaciones.DataSource = dtObservacionEmbarque
    End Sub

    Private Sub Llenar_Servicios_X_Embarque_Consulta()

        dtgServicios.DataSource = Nothing
        Dim odtServicios As New DataTable
        Dim obeServicioConsulta As New beServicioFacturarConsulta
        Dim oEmbarqueConsulta As New clsEmbarqueConsultaBL
        obeServicioConsulta.PNCCLNT = _pCCLNT
        obeServicioConsulta.PNNORSCI = _pNORSCI
        odtServicios = oEmbarqueConsulta.Lista_Servicios_X_Operacion_Consulta(obeServicioConsulta)
        dtgServicios.DataSource = odtServicios
    End Sub

    Private Sub Llenar_CheckPoint_Consulta()
        dtgCheckPoint.DataSource = Nothing
        Dim oEmbarqueConsulta As New clsEmbarqueConsultaBL
        Dim obeParamCheckPoint As New beCheckpointConsulta
        Dim dtCHK As New DataTable
        obeParamCheckPoint.PNCCLNT = _pCCLNT
        obeParamCheckPoint.PNNORSCI = _pNORSCI
        obeParamCheckPoint.PSCCMPN = _pCCMPN
        obeParamCheckPoint.PSCDVSN = _pCDVSN
        dtCHK = oEmbarqueConsulta.Lista_CheckPoint_X_Embarque_Consulta(obeParamCheckPoint)
        dtgCheckPoint.DataSource = dtCHK

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            pActualizarInfoEmbarque(_pCCMPN, _pCDVSN, _pCCLNT, _pNORSCI)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick

        Try
            Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            Select Case ColName
                Case "LINK"
                    Dim CCLNT As Decimal = _pCCLNT
                    Dim CCMPN As String = _pCCMPN
                    Dim NMRGIM As Decimal = dtgDocumentos.CurrentRow.Cells("NMRGIM_DOC").Value
                    If NMRGIM = 0 Then
                        Exit Sub
                    End If
                    Dim TABLE_NAME As String = "RZOL53"
                    'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, "", frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocEmb)
                    'ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Neutro
                    'ofrmAdjuntarDocumentos.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Function ObtenerRutaDua(ByVal NumDua As String) As String
        NumDua = NumDua.Trim
        Dim strArr() As String
        Dim strRuta As String = ""
        strArr = NumDua.Split("-")
        If strArr.Length = 1 Then
            strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & Mid(NumDua, 8, 2)
            strRuta = strRuta & "&codaduana=" & Mid(NumDua, 1, 3)
            strRuta = strRuta & "&anoprese=" & Mid(NumDua, 4, 4)
            strRuta = strRuta & "&numecorre=" & Mid(NumDua, 10, 6)
        Else
            strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & strArr(2)
            strRuta = strRuta & "&codaduana=" & strArr(0)
            strRuta = strRuta & "&anoprese=" & strArr(1)
            strRuta = strRuta & "&numecorre=" & strArr(3)
        End If
        Return strRuta
    End Function



    Private Sub dtgDocumentos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgDocumentos.DataBindingComplete
        For Each Item As DataGridViewRow In dtgDocumentos.Rows
            If Item.Cells("NMRGIM_DOC").Value > 0 Then
                Item.Cells("LINK").Value = My.Resources.Resources.Archivo
            Else
                Item.Cells("LINK").Value = My.Resources.Resources.EnBlanco
            End If
        Next
    End Sub

    Private Sub dtgDocumentosAdjuntos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgDocumentosAdjuntos.DataBindingComplete
        Dim rutaDua As String = ""
        For Each Item As DataGridViewRow In dtgDocumentosAdjuntos.Rows
            If Item.Cells("NMRGIM_COST").Value > 0 Then
                Item.Cells("DOC_LINK").Value = My.Resources.Resources.Archivo
            Else
                Item.Cells("DOC_LINK").Value = My.Resources.Resources.EnBlanco
            End If


            If Item.Cells("DOC_NDOCIN").Value = 106 Then

                rutaDua = ObtenerRutaDua(Item.Cells("DOC_NDOCUM").Value.ToString.Trim)
                If rutaDua.Length > 0 Then
                    Item.Cells("RUTA_DUA").Value = rutaDua
                    Item.Cells("DUA").Value = "DUA"
                    'DUA_COSTO
                Else
                    Item.Cells("RUTA_DUA").Value = ""
                    Item.Cells("DUA ").Value = ""
                End If
            End If


        Next




    End Sub


End Class
