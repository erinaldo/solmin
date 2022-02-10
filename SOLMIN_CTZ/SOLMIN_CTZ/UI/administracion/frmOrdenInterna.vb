Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOrdenInterna
    Private oEstado As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oOrdenesinternas As SOLMIN_CTZ.Entidades.OrdenesInternas
    Private oOrdenesinternasNeg As SOLMIN_CTZ.NEGOCIO.clsOrdenesInternas
    Private oClaseOrdenNeg As SOLMIN_CTZ.NEGOCIO.clsClaseOrden
    Private bolBuscar As Boolean
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private intRow As Integer
    Private bolCambiar As Boolean
    Private bolPaginar As Boolean
    Private sSociedad As String
    Private frmWait As GenerandoSap

    Private Sub frmOrdenInterna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ordenes Internas
        oOrdenesinternasNeg = New SOLMIN_CTZ.NEGOCIO.clsOrdenesInternas
        oOrdenesinternas = New SOLMIN_CTZ.Entidades.OrdenesInternas
        oClaseOrdenNeg = New SOLMIN_CTZ.NEGOCIO.clsClaseOrden
        'Compania /Division / Planta
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy

        Ocultar_Controles()
        oEstado = New clsEstado
        Cargar_Compania()
        Cargar_Division()

    End Sub

    Private Sub Cargar_Compania()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbCompania.DataSource = oCompania.Lista
            cmbCompania.ValueMember = "CCMPN"
            bolBuscar = True
            cmbCompania.DisplayMember = "TCMPCM"
            ' cmbCompania.SelectedIndex = 0
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
  
    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            'cmbDivision.DataSource = oDivision.Lista_Division_x_All(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
            Cargar_ClaseOrden()
            Cargar_DatosClaseOrden()
        End If
    End Sub
    Private Sub Cargar_Planta()
        Try
            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                cmbPlanta.DataSource = oPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                'If cmbPlanta.FindString("1") = 0 Then
                '    cmbPlanta.SelectedValue = 1
                'End If
                cmbPlanta.DisplayMember = "TPLNTA"

                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            Cargar_ClaseOrden()
            Cargar_DatosClaseOrden()
        End If
    End Sub
    Private Sub Cargar_ClaseOrden()
        Dim dtTemp As New DataTable
        'Crear ObjetoClaseOrden
        oOrdenesinternas.PSCCMPN = Me.cmbCompania.SelectedValue
        oOrdenesinternas.PSCDVSN = Me.cmbDivision.SelectedValue
        oOrdenesinternas.PNCPLNDV = Me.cmbPlanta.SelectedValue
        Try
            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                dtTemp = oClaseOrdenNeg.ListaClaseOrden(oOrdenesinternas)
                If dtTemp.Rows.Count < 1 Then
                    cmbClaseOrden.DataSource = Nothing
                    cmbClaseOrden.Items.Clear()
                    LimpiaDatosClaseOrden()
                Else
                    cmbClaseOrden.DataSource = dtTemp
                    cmbClaseOrden.ValueMember = "CCLORI"
                    cmbClaseOrden.DisplayMember = "CCLORI"
                    '-------Recuperamos el codigo de sociedad----------
                    Dim dtSociedad As New DataTable
                    oOrdenesinternas.PSCCMPN = cmbCompania.SelectedValue
                    dtSociedad = oOrdenesinternasNeg.ObtieneSociedad(oOrdenesinternas)
                    Dim drSociedad As DataRow = dtSociedad.Rows(0)
                    sSociedad = CStr(drSociedad("CSCDSP"))
                    '-------------------------------------------------
                End If
                bolBuscar = True
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbClaseOrden_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClaseOrden.SelectedIndexChanged
        If bolBuscar Then
            Cargar_DatosClaseOrden()
        End If
    End Sub
    Private Sub Cargar_DatosClaseOrden()
        Dim dtTempClaseOrden As New DataTable
        If Not (Me.cmbClaseOrden.SelectedValue Is Nothing) Then
            oOrdenesinternas.CCLORI = Me.cmbClaseOrden.SelectedValue
        Else
            oOrdenesinternas.CCLORI = ""
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False

            dtTempClaseOrden = oClaseOrdenNeg.Datos_ClaseOrden(oOrdenesinternas)
            If dtTempClaseOrden.Rows.Count < 1 Then
                LimpiaDatosClaseOrden()
            Else
                Dim drTempClaseOrden As DataRow = dtTempClaseOrden.Rows(0)
                txtClaseOrden.Text = CStr(drTempClaseOrden("TCLORS"))
                Dim LonInicio As Integer = 0
                Dim LonFinal As Integer = 0
                Dim MaxLongitud As Integer = 12
                Dim Dif1 As Integer
                Dim Dif2 As Integer
                LonInicio = Len(CStr(drTempClaseOrden("NRNINS")))
                LonFinal = Len(CStr(drTempClaseOrden("NULCTR")))
                Dif1 = MaxLongitud - LonInicio
                Dif2 = MaxLongitud - LonFinal
                txtInicio.Text = HelpClass.Replicar("0", Dif1) & CStr(drTempClaseOrden("NRNINS"))
                txtFin.Text = HelpClass.Replicar("0", Dif2) & CStr(drTempClaseOrden("NULCTR"))
            End If
            bolBuscar = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtInicio_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInicio.Validated
        Dim LonInicio As Integer = 0
        Dim MaxLongitud As Integer = 12
        LonInicio = Len(txtInicio.Text)
        txtInicio.Text = HelpClass.Replicar("0", MaxLongitud - LonInicio) & txtInicio.Text
    End Sub
    Private Sub txtFin_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFin.Validated
        Dim LonFinal As Integer = 0
        Dim MaxLongitud As Integer = 12
        LonFinal = Len(txtFin.Text)
        txtFin.Text = HelpClass.Replicar("0", MaxLongitud - LonFinal) & txtFin.Text
    End Sub

    Private Sub LimpiaDatosClaseOrden()
        txtClaseOrden.Text = ""
        txtInicio.Text = ""
        txtFin.Text = ""
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarOrdenInterna()
    End Sub
    Private Sub BuscarOrdenInterna()
        If bolPaginar = False Then
            UcPaginacion1.PageNumber = 1
        End If
        Limpiar_Paneles()
        Mostrar_Controles()
        Me.Cursor = Cursors.AppStarting
        
        cargaGrillaOrdenInterna()

        Me.Cursor = Cursors.Default
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub

    Private Sub cargaGrillaOrdenInterna()
        Dim dtOrdenesInternas As New DataTable
        oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
        oOrdenesinternas.CSCDSP = sSociedad
        'Rango
        oOrdenesinternas.INI_ORDEN = txtInicio.Text
        oOrdenesinternas.FIN_ORDEN = txtFin.Text
        'Variables de paginación
        oOrdenesinternas.PageNumber = UcPaginacion1.PageNumber
        oOrdenesinternas.PageCount = UcPaginacion1.PageCount
        oOrdenesinternas.PageSize = UcPaginacion1.PageSize

        If Not (oOrdenesinternas.CCLORI Is Nothing) Then
            '------------Usando Hilos Thread------------
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            dtOrdenesInternas = oOrdenesinternasNeg.Lista_Ordenes_Internas(oOrdenesinternas)
            proceso_espera.Abort()
            '----------------------------------
            If dtOrdenesInternas.Rows.Count > 0 Then
                llenarGrillaOrdenInterna(dtOrdenesInternas)
            Else
                Ocultar_Controles()
                MsgBox("No hay registros por mostrar para esta consulta", MsgBoxStyle.Information, "Mensaje de Información")
            End If
        Else
            Ocultar_Controles()
            MsgBox("Debe seleccionar una Clase de Orden Valida", MsgBoxStyle.Information, "Mensaje de Información")
        End If
        bolPaginar = False

    End Sub
    Private Sub llenarGrillaOrdenInterna(ByVal oDtx As DataTable)
        dtgOrdenesInternas.AutoGenerateColumns = False
        dtgOrdenesInternas.DataSource = oDtx
        If oDtx.Rows.Count > 0 Then
            Me.UcPaginacion1.PageCount = oDtx.Rows(0).Item("PageCount")
        End If
    End Sub
#Region "Limpia Tablas"
    Private Sub Ocultar_Controles()
        btnResumen.Enabled = ButtonEnabled.False
        btnExportarXLS.Enabled = ButtonEnabled.False
    End Sub

    Private Sub Mostrar_Controles()
        btnResumen.Enabled = ButtonEnabled.True
        btnExportarXLS.Enabled = ButtonEnabled.True
    End Sub

    Private Sub Limpiar_Paneles(Optional ByVal Grilla1 As Integer = 0)
        If Grilla1 <> 1 Then
            Me.dtgOrdenesInternas.DataSource = Nothing
        End If
        Me.dtgDetalleOrdenesInternas.DataSource = Nothing
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        BuscarOrdenInterna()
    End Sub
#End Region

    Private Sub dtgOrdenesInternas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOrdenesInternas.CellClick
        If e.RowIndex > -1 Then
            Cargar_Detalle_OrdenesInternas(Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("CCLORI").Value, _
                                        Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("NORSAP").Value)
        End If
    End Sub
    Private Sub dtgOrdenesInternas_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOrdenesInternas.CellEnter
        If e.RowIndex > -1 Then
            Cargar_Detalle_OrdenesInternas(Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("CCLORI").Value, _
                                        Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("NORSAP").Value)
        End If
    End Sub
    Private Sub Cargar_Detalle_OrdenesInternas(ByVal pCCLORI As String, ByVal pNORDIN As String)
        oOrdenesinternas.CCLORI = pCCLORI
        oOrdenesinternas.NORDIN = pNORDIN
        Mostrar_Controles()
        Limpiar_Paneles(1)
        llenarGrillaOrdenInternaDetalle(oOrdenesinternasNeg.Lista_Ordenes_Internas_Detalle(oOrdenesinternas))
    End Sub

    Private Sub llenarGrillaOrdenInternaDetalle(ByVal odtx As DataTable)
        
        dtgDetalleOrdenesInternas.AutoGenerateColumns = False
        dtgDetalleOrdenesInternas.DataSource = odtx
    End Sub

    Private Sub btnSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAP.Click
        If MsgBox("Desea Generar Ordenes SAP?", MsgBoxStyle.YesNo, "Mensaje de Información") = MsgBoxResult.Yes Then
            oOrdenesinternas.CSCDSP = sSociedad
            oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
            oOrdenesinternas.NRNINS = txtInicio.Text
            oOrdenesinternas.NULCTR = txtFin.Text
            If Not (oOrdenesinternas.CSCDSP Is Nothing) Then
                If Not (oOrdenesinternas.CCLORI Is Nothing) Then
                    Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
                    proceso_espera.Start()
                    oOrdenesinternasNeg.Actualiza_SAP_OrdenInterna(oOrdenesinternas)
                    proceso_espera.Abort()
                End If
            End If
        End If
    End Sub

    Private Sub btnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumen.Click
        Dim frmResumen As frmOrdenInternaResumen
        Dim dtResumen As New DataTable
        frmResumen = New frmOrdenInternaResumen

        oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
        oOrdenesinternas.CSCDSP = sSociedad
        'Rango
        oOrdenesinternas.INI_ORDEN = txtInicio.Text
        oOrdenesinternas.FIN_ORDEN = txtFin.Text

        dtResumen = oOrdenesinternasNeg.Lista_Ordenes_Internas_Resumen(oOrdenesinternas)
        If dtResumen.Rows.Count > 3 Then
            Dim drAbierto As DataRow = dtResumen.Rows(0)
            Dim drLiberada As DataRow = dtResumen.Rows(1)
            Dim drCierreTecnico As DataRow = dtResumen.Rows(2)
            Dim drCerrado As DataRow = dtResumen.Rows(3)
            frmResumen.txtFaseAbierto.Text = CStr(drAbierto("CANT"))
            frmResumen.txtFaseLiberada.Text = CStr(drLiberada("CANT"))
            frmResumen.txtFaseCierreTecnico.Text = CStr(drCierreTecnico("CANT"))
            frmResumen.txtFaseCierre.Text = CStr(drCerrado("CANT"))
            frmResumen.txtTotal.Text = CInt(drAbierto("CANT")) + CInt(drLiberada("CANT")) + CInt(drCierreTecnico("CANT")) + CInt(drCerrado("CANT"))
        End If

        frmResumen.StartPosition = FormStartPosition.CenterScreen
        frmResumen.ShowInTaskbar = False
        frmResumen.ShowDialog()
    End Sub

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "007"
        Dim dtExportarExcel As New DataTable

        dtExportarExcel = oOrdenesinternasNeg.Lista_Ordenes_Internas_Reporte(oOrdenesinternas)
        If dtExportarExcel Is Nothing Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dtExportarExcel.Rows.Count > 1 Then
            Dim list As New List(Of DataTable)
            list.Add(dtExportarExcel)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(list, strReporteseleccionado)
            'Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtExportarExcel)
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class
