Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOrdenInternaControlV2
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private oOIControlV2 As SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private oOIControlV2Neg As SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oEstadoNeg As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private bolBuscar As Boolean
    Private bolPaginar As Boolean
    Private bolIniciaCarga As Boolean
    Private frmInformacion As New dialogoInformacion
    Private oDtGlobal As DataTable
    Private Sub frmOrdenInternaV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OI_CONTROL
        oOIControlV2 = New SOLMIN_CTZ.Entidades.OrdenInternaControl
        oOIControlV2Neg = New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
        'Compania /Division / Planta
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oEstadoNeg = New clsEstado
        Ocultar_Controles()
        Cargar_Compania()
        Cargar_Division()
        Cargar_Estado()
        dtFechaFin.Enabled = True
        dtFechaInicio.Enabled = True
        cbRango.Checked = True
        frmInformacion.ShowInTaskbar = False
        frmInformacion.StartPosition = FormStartPosition.CenterScreen
    End Sub
#Region "Comun"
    Private Sub Cargar_Compania()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbCompania.DataSource = oCompania.Lista
            cmbCompania.ValueMember = "CCMPN"
            bolBuscar = True
            cmbCompania.DisplayMember = "TCMPCM"
            'cmbCompania.SelectedIndex = 0
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar Then
                Cargar_Division()
            End If
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
    Private Sub cbRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRango.CheckedChanged
        If cbRango.Checked Then
            dtFechaFin.Enabled = True
            dtFechaInicio.Enabled = True
        Else
            dtFechaFin.Value = Date.Now
            dtFechaInicio.Value = Date.Now
            dtFechaFin.Enabled = False
            dtFechaInicio.Enabled = False
        End If
    End Sub
    Private Sub Cargar_Estado()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            oEstadoNeg.Estado_Factura()
            cmbEstado.DataSource = oEstadoNeg.Tabla
            cmbEstado.ValueMember = "COD"
            bolBuscar = True
            cmbEstado.DisplayMember = "TEX"
            cmbEstado.SelectedValue = "-1"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ocultar_Controles()
        UcPaginacion.Enabled = False
        btnResumenOI.Enabled = ButtonEnabled.False
        btnExportar.Enabled = ButtonEnabled.False
        btnCierreOI.Enabled = ButtonEnabled.False
        btnExportarOI.Enabled = ButtonEnabled.False
        dtgOrdenesInternas2.DataSource = Nothing
    End Sub
    Private Sub Mostrar_Controles()
        UcPaginacion.Enabled = True
        btnResumenOI.Enabled = ButtonEnabled.True
        btnExportar.Enabled = ButtonEnabled.True
        btnCierreOI.Enabled = ButtonEnabled.True
        btnExportarOI.Enabled = ButtonEnabled.True
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub
#End Region
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        bolPaginar = False
        bolIniciaCarga = True
        BuscarOI_Control_V2()
    End Sub
    Private Sub BuscarOI_Control_V2()
        If bolPaginar = False Then UcPaginacion.PageNumber = 1
        Dim oOI As New SOLMIN_CTZ.Entidades.OrdenInternaControl
        Dim oOINeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
        '--------Filtro---------
        oOI.PSCCMPN = cmbCompania.SelectedValue
        oOI.PSCDVSN = cmbDivision.SelectedValue
        oOI.PNCPLNDV = cmbPlanta.SelectedValue
        oOI.SESTOP = cmbEstado.SelectedValue
        oOI.NOPRCN = IIf(txtNroOperacion.Text = "", "-1", txtNroOperacion.Text)
        If cbRango.Checked Then
            oOI.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            oOI.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Else
            oOI.F_INICIO = "00000000"
            oOI.F_FINAL = "99999999"
        End If
        oOI.PageNumber = UcPaginacion.PageNumber
        oOI.PageSize = UcPaginacion.PageSize
        oOI.PageCount = UcPaginacion.PageCount
        '---------Fin Filtro--------
        '----------------CONSULTA INICIAL------------------
        If bolIniciaCarga = True Then
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            Dim dt As DataTable = oOINeg.Lista_Ordenes_Internas_Control_V2(oOI)
            If dt Is Nothing Then
                HelpClass.MsgBox("Hubo un Error Interno en la Base De Datos")
                proceso_espera.Abort()
                Exit Sub
            End If
            If Not oDtGlobal Is Nothing Then oDtGlobal.Rows.Clear()
            oDtGlobal = dt.Copy
            proceso_espera.Abort()
            bolIniciaCarga = False
        End If
        '---------------CANTIDAD DE PAGINAS----------------
        UcPaginacion.PageCount = HelpClass.num_paginas(oDtGlobal, UcPaginacion.PageSize)
        '-----------------PAGINACION------------------------
        Dim oDt2 As New DataTable
        oDt2.Rows.Clear()
        Dim pagIni As Integer = 0
        Dim pagFin As Integer = 0
        pagIni = (UcPaginacion.PageNumber - 1) * (UcPaginacion.PageSize) + 1
        pagFin = UcPaginacion.PageNumber * UcPaginacion.PageSize
        oDt2 = HelpClass.paginarDataDridView(oDtGlobal, pagIni - 1, pagFin - 1)
        Cargar_grilla_OI_Contro(oDt2)
        '-------------------------------
    End Sub
    Private Sub Cargar_grilla_OI_Contro(ByVal dt As DataTable)
        If dt.Rows.Count = 0 Then
            Ocultar_Controles()
            frmInformacion.lblMensaje.Text = "No hay registros por mostrar para esta consulta"
            frmInformacion.ShowDialog()
            Exit Sub
        End If
        Mostrar_Controles()
        dtgOrdenesInternas2.AutoGenerateColumns = False
        dtgOrdenesInternas2.DataSource = dt
    End Sub
    Private Sub dtgOrdenesInternas2_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOrdenesInternas2.DataBindingComplete
        Dim parametros As List(Of String)
        For i As Integer = 0 To dtgOrdenesInternas2.Rows.Count - 1
            parametros = New List(Of String)
            parametros.Add(dtgOrdenesInternas2.Rows(i).Cells("NDCMFC").Value)
            parametros.Add(dtgOrdenesInternas2.Rows(i).Cells("SESTOP").Value)
            parametros.Add(dtgOrdenesInternas2.Rows(i).Cells("ZSTALIB").Value)
            parametros.Add(dtgOrdenesInternas2.Rows(i).Cells("ZSTACIE").Value)
            parametros.Add(dtgOrdenesInternas2.Rows(i).Cells("ZSTAFI").Value)
            dtgOrdenesInternas2.Rows(i).Cells("Status").Value = Verificar_Estado(parametros)
        Next
    End Sub
    Private Function Verificar_Estado(ByVal parametros As List(Of String))
        Dim btnOk As Bitmap
        Dim btnCancel As Bitmap
        btnOk = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_ok)
        btnCancel = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_cancel)
        Dim strEstado As String = ""
        Dim strNroDocumento As String = ""
        Dim strLiberado As String = ""
        Dim strCierreTecnico As String = ""
        Dim strCerrado As String = ""
        Dim strStatus As Bitmap
        With parametros
            strNroDocumento = .Item(0).ToString.Trim
            strEstado = .Item(1).ToString.Trim
            strLiberado = .Item(2).ToString.Trim
            strCierreTecnico = .Item(3).ToString.Trim
            strCerrado = .Item(4).ToString.Trim
            If strEstado = "F" And strLiberado = "X" And strNroDocumento <> "0" Then
                strStatus = btnCancel
            ElseIf strEstado = "F" And strLiberado = "X" And strNroDocumento = "0" Then
                strStatus = btnOk
            ElseIf (strEstado = "P" Or strEstado = "A" Or strEstado = "C") And strLiberado = "X" Then
                strStatus = btnOk
            ElseIf strEstado = "F" And strCierreTecnico = "X" And strNroDocumento <> "0" Then
                strStatus = btnOk
            ElseIf strEstado = "*" And strCerrado = "X" Then
                strStatus = btnOk
            ElseIf strEstado = "*" And strCierreTecnico = "X" Then
                strStatus = btnOk
            Else
                strStatus = btnCancel
            End If
        End With
        Return strStatus
    End Function
    Private Sub UcPaginacion_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        bolPaginar = True
        BuscarOI_Control_V2()
    End Sub

    Private Sub btnResumenOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumenOI.Click
        oOIControlV2.PSCDVSN = cmbDivision.SelectedValue
        oOIControlV2.PNCPLNDV = cmbPlanta.SelectedValue
        oOIControlV2.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
        oOIControlV2.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        '----Descripciones----
        oOIControlV2.CCMPN_DESC = cmbCompania.Text
        oOIControlV2.CDVSN_DESC = cmbDivision.Text
        oOIControlV2.CPLNDV_DESC = cmbPlanta.Text
        oOIControlV2.oDtOI = oDtGlobal
        '----------------------
        Dim htValores As New Hashtable
        htValores = oOIControlV2Neg.Lista_OI_ControlResumenV2(oOIControlV2)
       
        Dim frmResumen As frmOIControlResumenV2
        frmResumen = New frmOIControlResumenV2(oOIControlV2, htValores)
        frmResumen.ShowInTaskbar = False
        frmResumen.StartPosition = FormStartPosition.CenterScreen
        frmResumen.ShowDialog()
    End Sub

    Private Sub btnCierreOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierreOI.Click

        oOIControlV2.CCMPN_DESC = cmbCompania.Text
        oOIControlV2.CDVSN_DESC = cmbDivision.Text
        oOIControlV2.CPLNDV_DESC = cmbPlanta.Text
        oOIControlV2.PSCCMPN = cmbCompania.SelectedValue
        oOIControlV2.PSCDVSN = cmbDivision.SelectedValue
        oOIControlV2.PNCPLNDV = cmbPlanta.SelectedValue
        oOIControlV2.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
        oOIControlV2.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        oOIControlV2.oDtOI = oDtGlobal
        Dim frmCierreOI As New frmOIControlCierreV2(oOIControlV2)
        frmCierreOI.StartPosition = FormStartPosition.CenterScreen
        frmCierreOI.ShowInTaskbar = False

        frmCierreOI.ShowDialog()
    End Sub
#Region "Excel"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        odtReporte = oDtGlobal.Copy
        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns.Remove("CCMPN")
        odtReporte.Columns.Remove("CDVSN")
        'odtReporte.Columns(0).ColumnName = "Compania"
        'odtReporte.Columns(1).ColumnName = "Division"
        odtReporte.Columns(0).ColumnName = "\n Planta"
        odtReporte.Columns(1).ColumnName = "\n Operacion"
        odtReporte.Columns(2).ColumnName = "Tipo \n Servicio"
        odtReporte.Columns(3).ColumnName = "Fecha Inicio \n Operación"
        odtReporte.Columns(4).ColumnName = "Fecha Fin \n Operación"
        odtReporte.Columns(5).ColumnName = "\n Fecha"
        odtReporte.Columns(6).ColumnName = "\n Planeamiento"
        odtReporte.Columns(7).ColumnName = "\n Estado"
        odtReporte.Columns(8).ColumnName = "Tipo \n Documento"
        odtReporte.Columns(9).ColumnName = "Nro \n Documento"
        odtReporte.Columns(10).ColumnName = "Nro\n Servicio"
        odtReporte.Columns(11).ColumnName = "Orden \n Interna"
        odtReporte.Columns(12).ColumnName = "\n Venta"
        odtReporte.Columns(13).ColumnName = "\n Gasto"
        odtReporte.Columns(14).ColumnName = "\n Guia"
        odtReporte.Columns(15).ColumnName = "Fecha \n Guia"
        odtReporte.Columns(16).ColumnName = "\n Placa"
        odtReporte.Columns(17).ColumnName = "Clase \n O/I"
        odtReporte.Columns(18).ColumnName = "Fecha \n Liberado"
        odtReporte.Columns(19).ColumnName = "Estado \n Liberado"
        odtReporte.Columns(20).ColumnName = "Fecha \n Cierre"
        odtReporte.Columns(21).ColumnName = "Estado \n Cierre"
        odtReporte.Columns(22).ColumnName = "Fecha Cierre \n  Final"
        odtReporte.Columns(23).ColumnName = "Estado Cierre \n Final"

        ListDt.Add(odtReporte)

        Dim Hashfiltro As New Hashtable
        Hashfiltro.Add("COMPAÑIA", cmbCompania.Text)
        Hashfiltro.Add("DIVISION", cmbDivision.Text)
        Hashfiltro.Add("PLANTA", cmbPlanta.Text)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "Control de Ordenes Internas", Hashfiltro)

        odtReporte.Dispose()
        odtReporte.Clear()
        ListDt.Clear()
    End Sub
#End Region

    Private Sub btnExportarOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarOI.Click
        BuscarOI_Control_V2_Reporte()

        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        odtReporte = oDtGlobal.Copy
        '---------Se cambia el nombre de la Cabecera----------
        'odtReporte.Columns.Remove("CCMPN")
        'odtReporte.Columns.Remove("CDVSN")
        'odtReporte.Columns(0).ColumnName = "Compania"
        'odtReporte.Columns(1).ColumnName = "Division"
        'odtReporte.Columns.Remove("PageCount")
        odtReporte.Columns(0).ColumnName = "Operacion"
        odtReporte.Columns(1).ColumnName = "Planta"
        odtReporte.Columns(2).ColumnName = "Fecha Inicio Operación"
        odtReporte.Columns(3).ColumnName = "Orden Interna"
        odtReporte.Columns(4).ColumnName = "Clase O/I"
        odtReporte.Columns(5).ColumnName = "Estado OI"
        odtReporte.Columns(6).ColumnName = "Estado Enviado SAP"
        odtReporte.Columns(7).ColumnName = "Fecha Creación OI"
        odtReporte.Columns(8).ColumnName = "Mes"
        odtReporte.Columns(9).ColumnName = "Fecha Cierre OI"
        odtReporte.Columns(10).ColumnName = "N° Liquidación"
        odtReporte.Columns(11).ColumnName = "Fecha Liquidación"
        odtReporte.Columns(12).ColumnName = "Estado Liquidación"
        odtReporte.Columns(13).ColumnName = "Moneda"
        odtReporte.Columns(14).ColumnName = "Tipo de Cambio"
        odtReporte.Columns(15).ColumnName = "Gasto"
        odtReporte.Columns(16).ColumnName = "Centro Costo"
        odtReporte.Columns(17).ColumnName = "Centro Beneficio"
        odtReporte.Columns(18).ColumnName = "Estado"
        odtReporte.Columns(19).ColumnName = "Tipo Documento"
        odtReporte.Columns(20).ColumnName = "N° Factura"
        odtReporte.Columns(21).ColumnName = "Fecha Factura"
        odtReporte.Columns(22).ColumnName = "Fecha Creación"
        odtReporte.Columns(23).ColumnName = "P \ F"
        'odtReporte.Columns(20).ColumnName = ""
        'odtReporte.Columns(21).ColumnName = "Estado \n Cierre"
        'odtReporte.Columns(22).ColumnName = "Fecha Cierre \n  Final"
        'odtReporte.Columns(23).ColumnName = "Estado Cierre \n Final"

        ListDt.Add(odtReporte)

        Dim Hashfiltro As New Hashtable
        Hashfiltro.Add("COMPAÑIA", cmbCompania.Text)
        Hashfiltro.Add("DIVISION", cmbDivision.Text)
        Hashfiltro.Add("PLANTA", cmbPlanta.Text)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "Reporte Órdenes Internas", Hashfiltro)

        odtReporte.Dispose()
        odtReporte.Clear()
        ListDt.Clear()
    End Sub

    Private Sub BuscarOI_Control_V2_Reporte()
        If bolPaginar = False Then UcPaginacion.PageNumber = 1
        Dim oOI As New SOLMIN_CTZ.Entidades.OrdenInternaControl
        Dim oOINeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
        '--------Filtro---------
        oOI.PSCCMPN = cmbCompania.SelectedValue
        oOI.PSCDVSN = cmbDivision.SelectedValue
        oOI.PNCPLNDV = cmbPlanta.SelectedValue
        oOI.SESTOP = IIf(cmbEstado.SelectedValue = "-1", "", cmbEstado.SelectedValue)
        oOI.NOPRCN = txtNroOperacion.Text
        If cbRango.Checked Then
            oOI.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            oOI.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Else
            oOI.F_INICIO = "00000000"
            oOI.F_FINAL = "99999999"
        End If
        'oOI.PageNumber = UcPaginacion.PageNumber
        'oOI.PageSize = UcPaginacion.PageSize
        'oOI.PageCount = UcPaginacion.PageCount
        '---------Fin Filtro--------
        '----------------CONSULTA INICIAL------------------
        'If bolIniciaCarga = True Then
        Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
        proceso_espera.Start()
        Dim dt As DataTable = oOINeg.Lista_Ordenes_Internas_Reporte(oOI)
        If dt Is Nothing Then
            HelpClass.MsgBox("Hubo un Error Interno en la Base De Datos")
            proceso_espera.Abort()
            Exit Sub
        End If
        If Not oDtGlobal Is Nothing Then oDtGlobal.Rows.Clear()
        oDtGlobal = dt.Copy
        proceso_espera.Abort()
        bolIniciaCarga = False
        'End If
        '---------------CANTIDAD DE PAGINAS----------------
        'UcPaginacion.PageCount = HelpClass.num_paginas(oDtGlobal, UcPaginacion.PageSize)
        ''-----------------PAGINACION------------------------
        'Dim oDt2 As New DataTable
        'oDt2.Rows.Clear()
        'Dim pagIni As Integer = 0
        'Dim pagFin As Integer = 0
        'pagIni = (UcPaginacion.PageNumber - 1) * (UcPaginacion.PageSize) + 1
        'pagFin = UcPaginacion.PageNumber * UcPaginacion.PageSize
        'oDt2 = HelpClass.paginarDataDridView(oDtGlobal, pagIni - 1, pagFin - 1)
        'Cargar_grilla_OI_Contro(oDt2)
        '-------------------------------
    End Sub
End Class
