'acd 1.0
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOrdenInternaControl

    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private intRow As Integer
    Private bolBuscar As Boolean
    Private bolCambiar As Boolean
    Private bolPaginar As Boolean
    Private bolIniciaCarga As Boolean = True
    Private oDtOI As DataTable
    Private oOIControl As SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private oOIControlNeg As SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oEstadoNeg As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private frmInformacion As New dialogoInformacion

    Private Sub frmOrdenInternaControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OI_CONTROL
        oOIControl = New SOLMIN_CTZ.Entidades.OrdenInternaControl
        oOIControlNeg = New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
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
        dtFechaFin.Enabled = False
        dtFechaInicio.Enabled = False
        '--------------------------------
        frmInformacion.ShowInTaskbar = False
        frmInformacion.StartPosition = FormStartPosition.CenterScreen
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
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        HGControlOrdenesInternas.Enabled = True
        bolPaginar = False
        BuscarOI_Control()
    End Sub
 
    Private Sub BuscarOI_Control()
        If bolPaginar = False Then
            UcPaginacion1.PageNumber = 1
        End If
        oOIControl.PSCCMPN = cmbCompania.SelectedValue
        oOIControl.PSCDVSN = cmbDivision.SelectedValue
        oOIControl.PNCPLNDV = cmbPlanta.SelectedValue
        oOIControl.SESTOP = cmbEstado.SelectedValue
        oOIControl.NOPRCN = IIf(txtNroOperacion.Text = "", "-1", txtNroOperacion.Text)
        If cbRango.Checked Then
            oOIControl.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            oOIControl.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Else
            oOIControl.F_INICIO = "0"
            oOIControl.F_FINAL = "90000000"
        End If

        oOIControl.PageNumber = UcPaginacion1.PageNumber
        oOIControl.PageSize = UcPaginacion1.PageSize

        Llenar_Grilla_OIControl()
    
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub
    Private Sub Llenar_Grilla_OIControl()

        'Imagenes
        Dim btnOk As Bitmap
        Dim btnCancel As Bitmap
        btnOk = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_ok)
        btnCancel = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_cancel)
        'Se hace el llenado de la grilla
        Mostrar_Controles()
        Dim intCont As Integer
        Dim oDt As DataTable
        '------------Usando Hilos Thread------------
        Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
        proceso_espera.Start()
        oDt = oOIControlNeg.Lista_Ordenes_Internas(oOIControl)
        proceso_espera.Abort()
        If oDt Is Nothing Then
            HelpClass.MsgBox("Hubo un Error interno en la Base de Datos")
            Ocultar_Controles()
            Exit Sub
        End If
        oDtOI = HelpClass.paginarDataDridView(oDt, 0, oDt.Rows.Count - 1)
        If oDt.Rows.Count > 0 Then
            Limpiar_Controles()
            For intCont = 0 To oDt.Rows.Count - 1
                Agrega_Row_OI()
                With Me.dtgControlOrdenInterna
                    'Indicar los nombres de las columnas
                    .Rows(intCont).Cells("CCMPN").Value = oDt.Rows(intCont).Item("CCMPN")
                    .Rows(intCont).Cells("CDVSN").Value = oDt.Rows(intCont).Item("CDVSN")
                    .Rows(intCont).Cells("CPLNDV").Value = oDt.Rows(intCont).Item("CPLNDV")
                    .Rows(intCont).Cells("NOPRCN").Value = oDt.Rows(intCont).Item("NOPRCN")
                    .Rows(intCont).Cells("CCLORI").Value = oDt.Rows(intCont).Item("CCLORI")
                    .Rows(intCont).Cells("FINCOP").Value = HelpClass.FormatoFecha(oDt.Rows(intCont).Item("FINCOP"))
                    .Rows(intCont).Cells("FTRMOP").Value = HelpClass.FormatoFecha(oDt.Rows(intCont).Item("FTRMOP"))
                    .Rows(intCont).Cells("FDCPRF").Value = HelpClass.FormatoFecha(oDt.Rows(intCont).Item("FDCPRF"))
                    .Rows(intCont).Cells("NPLNMT").Value = oDt.Rows(intCont).Item("NPLNMT")
                    .Rows(intCont).Cells("SESTOP").Value = oDt.Rows(intCont).Item("SESTOP")
                    .Rows(intCont).Cells("NORINS").Value = oDt.Rows(intCont).Item("NORINS")
                    If oDt.Rows(intCont).Item("VENTA").ToString.Trim = "" Then
                        .Rows(intCont).Cells("VENTA").Value = "0"
                    Else
                        .Rows(intCont).Cells("VENTA").Value = Format(CType(oDt.Rows(intCont).Item("VENTA"), Double), "###,###,###,##0.00")
                    End If
                    If oDt.Rows(intCont).Item("GASTO").ToString.Trim = "" Then
                        .Rows(intCont).Cells("GASTO").Value = "0"
                    Else
                        .Rows(intCont).Cells("GASTO").Value = Format(CType(oDt.Rows(intCont).Item("GASTO").ToString.Trim, Double), "###,###,###,##0.00") 'oDt.Rows(intCont).Item("GASTO")
                    End If
                    .Rows(intCont).Cells("NDCMFC").Value = oDt.Rows(intCont).Item("NDCMFC")
                    .Rows(intCont).Cells("NGUITR").Value = oDt.Rows(intCont).Item("NGUITR")
                    .Rows(intCont).Cells("FGUITR").Value = HelpClass.FormatoFecha(IIf(IsDBNull(oDt.Rows(intCont).Item("FGUITR")), "", oDt.Rows(intCont).Item("FGUITR")))
                    .Rows(intCont).Cells("NPLVHT").Value = oDt.Rows(intCont).Item("NPLVHT")
                    .Rows(intCont).Cells("CFAOLI").Value = oDt.Rows(intCont).Item("CFAOLI")
                    .Rows(intCont).Cells("CFAOCT").Value = oDt.Rows(intCont).Item("CFAOCT")
                    .Rows(intCont).Cells("CFAOCE").Value = oDt.Rows(intCont).Item("CFAOCE")
                    If Verificar_Estado(oDt.Rows(intCont)) = "Ok" Then
                        .Rows(intCont).Cells("Status").Value = btnOk
                    Else
                        .Rows(intCont).Cells("Status").Value = btnCancel
                        .Rows(intCont).DefaultCellStyle.BackColor = Color.MistyRose
                    End If
                    If intCont = 0 Then
                        Me.UcPaginacion1.PageCount = oOIControl.PageCount
                    End If
                End With
            Next intCont
        Else
            Ocultar_Controles()
            frmInformacion.lblMensaje.Text = "No hay registros por mostrar para esta consulta"
            frmInformacion.ShowDialog()
        End If

    End Sub

    Private Function Verificar_Estado(ByVal poRow As DataRow)
        Dim strEstado As String = ""
        Dim strNroDocumento As String = ""
        Dim strLiberado As String = ""
        Dim strCierreTecnico As String = ""
        Dim strCerrado As String = ""
        Dim strStatus As String = ""
        With poRow
            strNroDocumento = .Item("NDCMFC").ToString.Trim
            strEstado = .Item("SESTOP").ToString.Trim
            strLiberado = .Item("CFAOLI").ToString.Trim
            strCierreTecnico = .Item("CFAOCT").ToString.Trim
            strCerrado = .Item("CFAOCE").ToString.Trim
            If strEstado = "F" And strLiberado = "X" And strNroDocumento <> "0" Then
                strStatus = "Invalido"
            ElseIf strEstado = "F" And strLiberado = "X" And strNroDocumento = "0" Then
                strStatus = "Ok"
            ElseIf (strEstado = "P" Or strEstado = "A" Or strEstado = "C") And strLiberado = "X" Then
                strStatus = "Ok"
            ElseIf strEstado = "F" And strCierreTecnico = "X" And strNroDocumento <> "0" Then
                strStatus = "Ok"
            ElseIf strEstado = "*" And strCerrado = "X" Then
                strStatus = "Ok"
            ElseIf strEstado = "*" And strCierreTecnico = "X" Then
                strStatus = "Ok"
            Else
                strStatus = "No Definido"
            End If
            
        End With
        Return strStatus
    End Function
    Private Sub Agrega_Row_OI()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgControlOrdenInterna)
        Me.dtgControlOrdenInterna.Rows.Add(oDrVw)
    End Sub
    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        BuscarOI_Control()
    End Sub
    Private Sub Limpiar_Controles()
        Me.dtgControlOrdenInterna.Rows.Clear()
    End Sub
    Private Sub Ocultar_Controles()
      
        UcPaginacion1.Enabled = False
        btnResumenOI.Enabled = ButtonEnabled.False
        btnExportar.Enabled = ButtonEnabled.False
        btnCierreOI.Enabled = ButtonEnabled.False
    End Sub
    Private Sub Mostrar_Controles()
        UcPaginacion1.Enabled = True
        btnResumenOI.Enabled = ButtonEnabled.True
        btnExportar.Enabled = ButtonEnabled.True
        btnCierreOI.Enabled = ButtonEnabled.True
    End Sub
   
#Region "Logica Resumen OI"
    Private Sub btnResumenOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumenOI.Click
        oOIControl.PSCDVSN = cmbDivision.SelectedValue
        oOIControl.PNCPLNDV = cmbPlanta.SelectedValue
        oOIControl.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
        oOIControl.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        '----Descripciones----
        oOIControl.CCMPN_DESC = cmbCompania.Text
        oOIControl.CDVSN_DESC = cmbDivision.Text
        oOIControl.CPLNDV_DESC = cmbPlanta.Text
        'Asigando o Aperturado son ='es
        Dim intCont As Integer
        '------------------------------------------------
        Dim facturada_SE As Integer = 0
        Dim facturada_LI As Integer = 0
        Dim facturada_CT As Integer = 0
        Dim facturada_CE As Integer = 0
        Dim Pendiente_SE As Integer = 0
        Dim Pendiente_LI As Integer = 0
        Dim Pendiente_CT As Integer = 0
        Dim Pendiente_CE As Integer = 0
        Dim pendiente_F_SE As Integer = 0
        Dim Pendiente_F_LI As Integer = 0
        Dim Pendiente_F_CT As Integer = 0
        Dim Pendiente_F_CE As Integer = 0
        Dim anulada_SE As Integer = 0
        Dim anulada_LI As Integer = 0
        Dim anulada_CT As Integer = 0
        Dim anulada_CE As Integer = 0
        '-----------------------------------------------
        Dim pendienteGasto As Double = 0.0
        Dim pendiente_FGasto As Double = 0.0
        Dim facturadoGasto As Double = 0.0
        Dim anuladoGasto As Double = 0.0
        '-----------------------------------------------
        Dim MontoGasto As Double = 0.0
        '-----------------------------------------------
        'Solo para pendientes
        Dim MontoGastoPendienteSE As Double = 0.0
        Dim MontoGastoPendienteLI As Double = 0.0
        Dim MontoGastoPendienteCT As Double = 0.0
        Dim MontoGastoPendienteCE As Double = 0.0
        '-----------------------------------------------
        Dim frmResumen As frmOrdenInternaControlResumen
        frmResumen = New frmOrdenInternaControlResumen(oOIControl)
        Dim dtResumen As DataTable
        dtResumen = New DataTable
        '------------Usando Hilos Thread------------
        Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
        ' Dim dtOIControl As New DataTable
        proceso_espera.Start()
        dtResumen = oOIControlNeg.Lista_Ordenes_Internas_Resumen(oOIControl)
        proceso_espera.Abort()
        If dtResumen.Rows.Count > 0 Then
            For intCont = 0 To dtResumen.Rows.Count - 1
                MontoGasto = 0.0
                If dtResumen.Rows(intCont).Item("TIPO") = "FACTURADAS" Then
                    If Not IsDBNull(dtResumen.Rows(intCont).Item("GASTO")) Then
                        facturadoGasto = facturadoGasto + Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                        MontoGasto = Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                    Else
                        facturadoGasto = facturadoGasto + 0
                        MontoGasto = 0
                    End If
                    If IsDBNull(dtResumen.Rows(intCont).Item("CFAOLI")) Then
                        facturada_SE = dtResumen.Rows(intCont).Item("CANTIDAD")
                        frmResumen.txtTotFacturadoSE.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                    Else
                        If dtResumen.Rows(intCont).Item("CFAOLI") = "X" Then
                            facturada_LI = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotFacturadoLI.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCT") = "X" Then
                            facturada_CT = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotFacturadoCT.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCE") = "X" Then
                            facturada_CE = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotFacturadoCE.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "PENDIENTES" Then
                    If Not IsDBNull(dtResumen.Rows(intCont).Item("GASTO")) Then
                        pendienteGasto = pendienteGasto + Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                        MontoGasto = Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                    Else
                        pendienteGasto = pendienteGasto + 0
                        MontoGasto = 0
                    End If
                    If IsDBNull(dtResumen.Rows(intCont).Item("CFAOLI")) Then
                        Pendiente_SE = dtResumen.Rows(intCont).Item("CANTIDAD")
                        MontoGastoPendienteSE = MontoGastoPendienteSE + MontoGasto
                    Else
                        If dtResumen.Rows(intCont).Item("CFAOLI") = "X" Then
                            Pendiente_LI = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteLI = MontoGastoPendienteLI + MontoGasto
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCT") = "X" Then
                            Pendiente_CT = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteCT = MontoGastoPendienteCT + MontoGasto
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCE") = "X" Then
                            Pendiente_CE = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteCE = MontoGastoPendienteCE + MontoGasto
                        End If
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "PENDIENTES_F" Then
                    If Not IsDBNull(dtResumen.Rows(intCont).Item("GASTO")) Then
                        pendiente_FGasto = pendiente_FGasto + Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                        MontoGasto = Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                    Else
                        pendiente_FGasto = pendiente_FGasto + 0
                        MontoGasto = 0
                    End If
                    If IsDBNull(dtResumen.Rows(intCont).Item("CFAOLI")) Then
                        pendiente_F_SE = dtResumen.Rows(intCont).Item("CANTIDAD")
                        MontoGastoPendienteSE = MontoGastoPendienteSE + MontoGasto
                    Else
                        If dtResumen.Rows(intCont).Item("CFAOLI") = "X" Then
                            Pendiente_F_LI = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteLI = MontoGastoPendienteLI + MontoGasto
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCT") = "X" Then
                            Pendiente_F_CT = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteCT = MontoGastoPendienteCT + MontoGasto
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCE") = "X" Then
                            Pendiente_F_CE = dtResumen.Rows(intCont).Item("CANTIDAD")
                            MontoGastoPendienteCE = MontoGastoPendienteCE + MontoGasto
                        End If
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "ANULADOS" Then
                    If Not IsDBNull(dtResumen.Rows(intCont).Item("GASTO")) Then
                        anuladoGasto = anuladoGasto + Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                        MontoGasto = Format(CType(dtResumen.Rows(intCont).Item("GASTO"), Double), "###,###,###,##0.00")
                    Else
                        anuladoGasto = anuladoGasto + 0
                        MontoGasto = 0
                    End If
                    If IsDBNull(dtResumen.Rows(intCont).Item("CFAOLI")) Then
                        anulada_SE = dtResumen.Rows(intCont).Item("CANTIDAD")
                        frmResumen.txtTotAnuladoSE.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                    Else
                        If dtResumen.Rows(intCont).Item("CFAOLI") = "X" Then
                            anulada_LI = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotAnuladoLI.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCT") = "X" Then
                            anulada_CT = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotAnuladoCT.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                        If dtResumen.Rows(intCont).Item("CFAOCE") = "X" Then
                            anulada_CE = dtResumen.Rows(intCont).Item("CANTIDAD")
                            frmResumen.txtTotAnuladoCE.Text = Format(CType(MontoGasto, Double), "###,###,###,##0.00")
                        End If
                    End If
                End If
            Next
        End If
        '---------------------------------------
        frmResumen.txtTotPendienteSE.Text = Format(CType(MontoGastoPendienteSE, Double), "###,###,###,##0.00")
        frmResumen.txtTotPendienteLI.Text = Format(CType(MontoGastoPendienteLI, Double), "###,###,###,##0.00")
        frmResumen.txtTotPendienteCT.Text = Format(CType(MontoGastoPendienteCT, Double), "###,###,###,##0.00")
        frmResumen.txtTotPendienteCE.Text = Format(CType(MontoGastoPendienteCE, Double), "###,###,###,##0.00")
        '--------------------------------------
        frmResumen.linkSEPendiente.Text = pendiente_F_SE + Pendiente_SE
        frmResumen.linkLiberadoPendiente.Text = Pendiente_F_LI + Pendiente_LI
        frmResumen.linkCTPendiente.Text = Pendiente_F_CT + Pendiente_CT
        frmResumen.linkCerradoPendiente.Text = Pendiente_F_CE + Pendiente_CE
        '--------------------------------------
        frmResumen.linkSEFacturado.Text = facturada_SE
        frmResumen.linkLiberadoFacturado.Text = facturada_LI
        frmResumen.linkCTFacturado.Text = facturada_CT
        frmResumen.linkCerradoFacturado.Text = facturada_CE
        '--------------------------------------
        frmResumen.linkSEAnulado.Text = anulada_SE
        frmResumen.linkLiberadoAnulado.Text = anulada_LI
        frmResumen.linkCTAnulado.Text = anulada_CT
        frmResumen.linkCerradoAnulado.Text = anulada_CE
        '--------------------------------------
        frmResumen.txtPendienteGasto.Text = Format(CType(pendiente_FGasto + pendienteGasto, Double), "###,###,###,##0.00")
        frmResumen.txtFacturadoGasto.Text = Format(CType(facturadoGasto, Double), "###,###,###,##0.00")
        frmResumen.txtAnuladoGasto.Text = Format(CType(anuladoGasto, Double), "###,###,###,##0.00")
        '--------------------------------------
        frmResumen.StartPosition = FormStartPosition.CenterScreen
        frmResumen.ShowInTaskbar = False
        frmResumen.ShowDialog()
    End Sub
#End Region

    Private Sub btnCierreOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierreOI.Click
        oOIControl.CCMPN_DESC = cmbCompania.Text
        oOIControl.CDVSN_DESC = cmbDivision.Text
        oOIControl.CPLNDV_DESC = cmbPlanta.Text
        oOIControl.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
        oOIControl.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Dim frmCierreOI As New frmOrdenInternaControlCierre(oOIControl)
        frmCierreOI.StartPosition = FormStartPosition.CenterScreen
        frmCierreOI.ShowInTaskbar = False

        frmCierreOI.ShowDialog()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "004"

        Dim dtNuevo As New DataTable
        dtNuevo = oDtOI.Clone
        'Eliminamos Columnas que no se usaran
        dtNuevo.Columns.Remove("CCMPN")
        dtNuevo.Columns.Remove("CDVSN")
        dtNuevo.Columns.Remove("CPLNDV")
        dtNuevo.Columns.Remove("CFAOAB")
        dtNuevo.Columns.Remove("CFAOLI")
        dtNuevo.Columns.Remove("CFAOCT")
        dtNuevo.Columns.Remove("CFAOCE")
        dtNuevo.Columns.Remove("CTPOSR")
        dtNuevo.Columns.Remove("PageCount")
        dtNuevo.Columns.Remove("ROWNUMBER")
        dtNuevo.Columns.Remove("CCLORI")
        dtNuevo.Columns.Remove("CTPDCF")

        'Cambiamos de tipo de dato a las Fechas
        dtNuevo.Columns(0).DataType = GetType(String)
        dtNuevo.Columns(1).DataType = GetType(String)
        dtNuevo.Columns(2).DataType = GetType(String)
        dtNuevo.Columns(3).DataType = GetType(String)
        dtNuevo.Columns(4).DataType = GetType(String)
        dtNuevo.Columns(5).DataType = GetType(String)
        dtNuevo.Columns(6).DataType = GetType(String)
        dtNuevo.Columns(7).DataType = GetType(String)
        dtNuevo.Columns(8).DataType = GetType(String)
        dtNuevo.Columns(9).DataType = GetType(String)
        dtNuevo.Columns(10).DataType = GetType(String)
        dtNuevo.Columns(11).DataType = GetType(String)
        dtNuevo.Columns(12).DataType = GetType(String)
        dtNuevo.Columns(13).DataType = GetType(String)

        'Agegamos datos Filtro
        Dim filaNueva As DataRow
        '----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Compania:"
        filaNueva(1) = cmbCompania.Text
        dtNuevo.Rows.Add(filaNueva)
        '-----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Division:"
        filaNueva(1) = cmbDivision.Text
        dtNuevo.Rows.Add(filaNueva)
        '------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Planta:"
        filaNueva(1) = cmbPlanta.Text
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Desde: " & dtFechaInicio.Text
        filaNueva(1) = "Hasta: " & dtFechaFin.Text
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "NRO OPERACION"
        filaNueva(1) = "INICIO OPERACION"
        filaNueva(2) = "FIN OPERACION"
        filaNueva(3) = "FECHA PREFACTURA"
        filaNueva(4) = "NRO PLANEAMIENTO"
        filaNueva(5) = "ESTADO"
        filaNueva(6) = "NRO DOCUMENTO"
        filaNueva(7) = "NRO SERVICIO"
        filaNueva(8) = "NRO O / I"
        filaNueva(9) = "VENTA"
        filaNueva(10) = "GASTO"
        filaNueva(11) = "NRO GUIA"
        filaNueva(12) = "FECHA GUIA"
        filaNueva(13) = "PLACA VEHICULO"

        dtNuevo.Rows.Add(filaNueva)

        For i As Integer = 0 To oDtOI.Rows.Count - 1
            If Not (i > (oDtOI.Rows.Count - 1)) Then
                dtNuevo.ImportRow(oDtOI.Rows(i))
                dtNuevo.Rows(i + 5).Item("FINCOP") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FINCOP").ToString.Trim)
                dtNuevo.Rows(i + 5).Item("FTRMOP") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FTRMOP").ToString.Trim)
                dtNuevo.Rows(i + 5).Item("FDCPRF") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FDCPRF").ToString.Trim)
                dtNuevo.Rows(i + 5).Item("FGUITR") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FGUITR").ToString.Trim)

            End If
        Next

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dtNuevo.Rows.Count > 1 Then
            Dim list As New List(Of DataTable)
            list.Add(dtNuevo)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(list, strReporteseleccionado)
            'Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtNuevo)
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub
End Class

