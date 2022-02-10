Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOrdenInterna2
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
    Private frmInformacion As New dialogoInformacion
                

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
        '----------------------------
        dtFechaFin.Enabled = False
        dtFechaInicio.Enabled = False
        '----------------------------
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
            'cmbCompania.SelectedItem = 0
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
        Dim Dif1 As Integer
        LonInicio = Len(txtInicio.Text)
        Dif1 = MaxLongitud - LonInicio
        txtInicio.Text = HelpClass.Replicar("0", Dif1) & txtInicio.Text
    End Sub
    Private Sub txtFin_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFin.Validated
        Dim LonFinal As Integer = 0
        Dim MaxLongitud As Integer = 12
        Dim Dif2 As Integer
        LonFinal = Len(txtFin.Text)
        Dif2 = MaxLongitud - LonFinal
        txtFin.Text = HelpClass.Replicar("0", Dif2) & txtFin.Text
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
        'Fechas
        If cbRango.Checked Then
            oOrdenesinternas.INI_FECHA = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            oOrdenesinternas.FIN_FECHA = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Else
            oOrdenesinternas.INI_FECHA = "0"
            oOrdenesinternas.FIN_FECHA = "90000000"
        End If

        If Not (oOrdenesinternas.CCLORI Is Nothing) Then
            '------------Usando Hilos Thread------------
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            Me.CheckForIllegalCrossThreadCalls = False
            proceso_espera.Start()
            dtOrdenesInternas = oOrdenesinternasNeg.Lista_Ordenes_Internas_RSAP22(oOrdenesinternas)
            proceso_espera.Abort()
            '----------------------------------
            If dtOrdenesInternas.Rows.Count > 0 Then
                llenarGrillaOrdenInterna()
            Else
                Ocultar_Controles()
                frmInformacion.lblMensaje.Text = "No hay registros por mostrar para esta consulta"
                frmInformacion.ShowDialog()
            End If
        Else
            Ocultar_Controles()
            frmInformacion.lblMensaje.Text = "Debe seleccionar una Clase de Orden Valida"
            frmInformacion.ShowDialog()
        End If
        bolPaginar = False
    End Sub
    Private Sub llenarGrillaOrdenInterna()
        'Dim oDrVw As DataGridViewRow
        'Dim intCont As Integer
        Dim oDtOrdenesInternas As DataTable = oOrdenesinternasNeg.Lista_Ordenes_Internas_RSAP22(oOrdenesinternas)

        If oDtOrdenesInternas.Rows.Count > 0 Then
            Me.UcPaginacion1.PageCount = oDtOrdenesInternas.Rows(0).Item("PageCount")
        End If

        dtgOrdenesInternas.AutoGenerateColumns = False
        dtgOrdenesInternas.DataSource = oDtOrdenesInternas
        'With oDtOrdenesInternas
        '    For intCont = 0 To .Rows.Count - 1
        '        oDrVw = New DataGridViewRow
        '        oDrVw.CreateCells(Me.dtgOrdenesInternas)

        '        oDrVw.Cells(0).Value = .Rows(intCont).Item("CCLORI").ToString.Trim
        '        oDrVw.Cells(1).Value = .Rows(intCont).Item("AUFNR").ToString.Trim
        '        oDrVw.Cells(2).Value = HelpClass.FormatoFecha(IIf(IsDBNull(.Rows(intCont).Item("ZFECALTA").ToString.Trim), "", .Rows(intCont).Item("ZFECALTA").ToString.Trim))
        '        oDrVw.Cells(3).Value = .Rows(intCont).Item("NORSRT").ToString.Trim
        '        oDrVw.Cells(4).Value = .Rows(intCont).Item("CSCDSP").ToString.Trim
        '        oDrVw.Cells(5).Value = .Rows(intCont).Item("NOPRCN").ToString.Trim
        '        oDrVw.Cells(6).Value = .Rows(intCont).Item("NDCMFC").ToString.Trim
        '        oDrVw.Cells(7).Value = .Rows(intCont).Item("SESTOP").ToString.Trim
        '        oDrVw.Cells(8).Value = .Rows(intCont).Item("NPLVHT").ToString.Trim
        '        oDrVw.Cells(9).Value = .Rows(intCont).Item("WERKS").ToString.Trim
        '        oDrVw.Cells(10).Value = .Rows(intCont).Item("ZSTALIB").ToString.Trim
        '        oDrVw.Cells(11).Value = HelpClass.FormatoFecha(IIf(IsDBNull(.Rows(intCont).Item("ZFECLIB").ToString.Trim), "", .Rows(intCont).Item("ZFECLIB").ToString.Trim))
        '        oDrVw.Cells(12).Value = .Rows(intCont).Item("ZSTACIE").ToString.Trim
        '        oDrVw.Cells(13).Value = HelpClass.FormatoFecha(IIf(IsDBNull(.Rows(intCont).Item("XFECCIE").ToString.Trim), "", .Rows(intCont).Item("XFECCIE").ToString.Trim))
        '        oDrVw.Cells(14).Value = .Rows(intCont).Item("ZSTAFI").ToString.Trim
        '        oDrVw.Cells(15).Value = HelpClass.FormatoFecha(IIf(IsDBNull(.Rows(intCont).Item("FCIEFI").ToString.Trim), "", .Rows(intCont).Item("FCIEFI").ToString.Trim))
        '        oDrVw.Cells(16).Value = Format(CType(.Rows(intCont).Item("ZSALDO").ToString.Trim, Double), "###,###,###,##0.00")
        '        If Verificar_Estado(.Rows(intCont)) = "Ok" Then
        '            oDrVw.Cells(17).Value = btnOk
        '        Else
        '            oDrVw.Cells(17).Value = btnCancel
        '            For y As Integer = 0 To 17
        '                oDrVw.Cells(y).Style.BackColor = Color.MistyRose
        '            Next
        '        End If
        '        Me.dtgOrdenesInternas.Rows.Add(oDrVw)
        '        If intCont = 0 Then
        '            Me.UcPaginacion1.PageCount = .Rows(intCont).Item("PageCount")
        '        End If
        '    Next intCont
        'End With
    End Sub
    Private Sub dtgOrdenesInternas_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOrdenesInternas.DataBindingComplete
        'Imagenes
        Dim btnOk As Bitmap
        Dim btnCancel As Bitmap
        Dim btnBlanco As Bitmap
        Dim btnActualiza As Bitmap
        btnOk = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_ok)
        btnCancel = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.button_cancel)
        btnBlanco = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.CuadradoBlanco)
        btnActualiza = New Bitmap(Global.SOLMIN_CT.My.Resources.Resources.agt_reload)

        For i As Integer = 0 To dtgOrdenesInternas.Rows.Count - 1
            If Verificar_Estado(dtgOrdenesInternas.Rows(i)) = "Ok" Then
                dtgOrdenesInternas.Rows(i).Cells("STATUS").Value = btnOk
                dtgOrdenesInternas.Rows(i).Cells("STATUS").ToolTipText = "Correcto"
                dtgOrdenesInternas.Rows(i).Cells("Actualizar").Value = btnBlanco
            Else
                dtgOrdenesInternas.Rows(i).Cells("STATUS").Value = btnCancel
                dtgOrdenesInternas.Rows(i).Cells("STATUS").ToolTipText = "Incorrecto"
                dtgOrdenesInternas.Rows(i).Cells("Actualizar").Value = btnActualiza
                For y As Integer = 0 To dtgOrdenesInternas.ColumnCount - 1
                    dtgOrdenesInternas.Rows(i).Cells(y).Style.BackColor = Color.MistyRose
                Next
            End If
        Next
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
            strLiberado = .Item("ZSTALIB").ToString.Trim
            strCierreTecnico = .Item("ZSTACIE").ToString.Trim
            strCerrado = .Item("ZSTAFI").ToString.Trim
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

    Private Function Verificar_Estado(ByVal poRow As DataGridViewRow)
        Dim strEstado As String = ""
        Dim strNroDocumento As String = ""
        Dim strLiberado As String = ""
        Dim strCierreTecnico As String = ""
        Dim strCerrado As String = ""
        Dim strStatus As String = ""
        With poRow
            strNroDocumento = .Cells("NDCMFC").Value.ToString.Trim
            strEstado = .Cells("SESTOP").Value.ToString.Trim
            strLiberado = .Cells("ZSTALIB").Value.ToString.Trim
            strCierreTecnico = .Cells("ZSTACIE").Value.ToString.Trim
            strCerrado = .Cells("ZSTAFI").Value.ToString.Trim
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
#Region "Limpia Tablas"
    Private Sub Ocultar_Controles()
        btnResumen.Enabled = ButtonEnabled.False
    End Sub

    Private Sub Mostrar_Controles()
        btnResumen.Enabled = ButtonEnabled.True
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
            Cargar_Detalle_OrdenesInternas(Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("CCLORI_0").Value, _
                                        Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("AUFNR").Value)
            If e.ColumnIndex = 18 Then
                If dtgOrdenesInternas.Rows(e.RowIndex).Cells("STATUS").ToolTipText = "Incorrecto" Then
                    If MsgBox("Desea Actualizar El Registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim oOIControlNeg As New clsOrdenInternaControl
                        Dim oOIControlEnt As New OrdenInternaControl
                        'MsgBox("Hello")
                        oOIControlEnt.CCLORI = dtgOrdenesInternas.Rows(e.RowIndex).Cells("CCLORI_0").Value
                        oOIControlEnt.NORDIN = validaDigitos(dtgOrdenesInternas.Rows(e.RowIndex).Cells("AUFNR").Value)
                        If dtgOrdenesInternas.Rows(e.RowIndex).Cells("SESTOP").Value = "F" Then 'Facturado
                            oOIControlEnt.SACORI = "M"
                            oOIControlNeg.Cierre_OI_CL_SAP119A(oOIControlEnt)
                        End If
                        If dtgOrdenesInternas.Rows(e.RowIndex).Cells("SESTOP").Value = "*" Then 'Anulado
                            oOIControlEnt.SACORI = "Z"
                            oOIControlNeg.Anulacion_OI_CL_SAP119B(oOIControlEnt)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Function validaDigitos(ByVal cadena As String) As String
        Dim cadena10 As String = ""
        If cadena.Length > 10 Then
            cadena10 = cadena.Substring(2, 10)
        ElseIf cadena.Length > 0 And cadena.Length < 10 Then
            If cadena.Length = 9 Then
                cadena10 = "0" & cadena
            ElseIf cadena.Length = 8 Then
                cadena10 = "00" & cadena
            ElseIf cadena.Length = 7 Then
                cadena10 = "000" & cadena
            ElseIf cadena.Length = 6 Then
                cadena10 = "0000" & cadena
            End If
        Else
            cadena10 = "0000000000"
        End If

        Return cadena10
    End Function

    Private Sub dtgOrdenesInternas_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOrdenesInternas.CellEnter
        If e.RowIndex > -1 Then
            Cargar_Detalle_OrdenesInternas(Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("CCLORI_0").Value, _
                                        Me.dtgOrdenesInternas.Rows(e.RowIndex).Cells("AUFNR").Value)
        End If
    End Sub
    Private Sub Cargar_Detalle_OrdenesInternas(ByVal pCCLORI As String, ByVal pNORDIN As String)
        oOrdenesinternas.CCLORI = pCCLORI
        oOrdenesinternas.NORDIN = pNORDIN
        Mostrar_Controles()
        Limpiar_Paneles(1)
        llenarGrillaOrdenInternaDetalle(oOrdenesinternasNeg.Lista_Ordenes_Internas_Detalle(oOrdenesinternas))
    End Sub

    Private Sub llenarGrillaOrdenInternaDetalle(ByVal oDtx As DataTable)
        dtgDetalleOrdenesInternas.AutoGenerateColumns = False
        dtgDetalleOrdenesInternas.DataSource = oDtx
    End Sub

    Private Sub btnSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAP.Click
        If MsgBox("Desea Generar Ordenes SAP?", MsgBoxStyle.YesNo, "Mensaje de Información") = MsgBoxResult.Yes Then
            oOrdenesinternas.CSCDSP = sSociedad
            oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
            oOrdenesinternas.INI_ORDEN = txtInicio.Text
            oOrdenesinternas.FIN_ORDEN = txtFin.Text
            oOrdenesinternas.INI_FECHA = HelpClass.FormatoFechaAS400(Me.dtFechaInicio.Text)
            oOrdenesinternas.FIN_FECHA = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Text)
            If Not (oOrdenesinternas.CSCDSP Is Nothing) Then
                If Not (oOrdenesinternas.CCLORI Is Nothing) Then
                    Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
                    proceso_espera.Start()
                    oOrdenesinternasNeg.Actualiza_SAP_OrdenInterna_RSAP22(oOrdenesinternas)
                    proceso_espera.Abort()
                End If
            End If
        End If
    End Sub

    Private Sub btnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumen.Click
        Dim intCont As Integer
        Dim frmResumen As frmOrdenInternaResumen2
        Dim dtResumen As New DataTable
        frmResumen = New frmOrdenInternaResumen2

        oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
        oOrdenesinternas.CSCDSP = sSociedad
        'Rango
        oOrdenesinternas.INI_ORDEN = txtInicio.Text
        oOrdenesinternas.FIN_ORDEN = txtFin.Text
        'Rango Fechas
        If cbRango.Checked Then
            oOrdenesinternas.INI_FECHA = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            oOrdenesinternas.FIN_FECHA = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        Else
            oOrdenesinternas.INI_FECHA = "00000000"
            oOrdenesinternas.FIN_FECHA = "99999999"
        End If
    

        dtResumen = oOrdenesinternasNeg.Lista_Ordenes_Internas_Resumen_RSAP22(oOrdenesinternas)
        'Variables Para sumar Pendientes
        Dim montPELI As Double = 0
        Dim montPECT As Double = 0
        Dim montPECI As Double = 0
        Dim montPETO As Double = 0
        '--------------------------------
        Dim filas As Integer = dtResumen.Rows.Count
        frmResumen.txtCantPELI.Text = "0"
        frmResumen.txtCantPECT.Text = "0"
        frmResumen.txtCantPECI.Text = "0"
        frmResumen.txtCantPETO.Text = "0"

        frmResumen.txtCantFALI.Text = "0"
        frmResumen.txtCantFACT.Text = "0"
        frmResumen.txtCantFACI.Text = "0"
        frmResumen.txtCantFATO.Text = "0"

        frmResumen.txtCantANLI.Text = "0"
        frmResumen.txtCantANCT.Text = "0"
        frmResumen.txtCantANCI.Text = "0"
        frmResumen.txtCantANTO.Text = "0"

        frmResumen.MontFATO = "0"
        frmResumen.MontPETO = "0"
        frmResumen.MontANTO = "0"

        If filas > 0 Then
            For intCont = 0 To dtResumen.Rows.Count - 1
                If dtResumen.Rows(intCont).Item("TIPO") = "FACTURADO" Then
                    If dtResumen.Rows(intCont).Item("ZSTALIB") = "X" Then
                        frmResumen.txtCantFALI.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontFALI.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontFATO = CType(frmResumen.MontFATO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTACIE") = "X" Then
                        frmResumen.txtCantFACT.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontFACT.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontFATO = CType(frmResumen.MontFATO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTAFI") = "X" Then
                        frmResumen.txtCantFACI.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontFACI.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontFATO = CType(frmResumen.MontFATO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "PENDIENTE" Then
                    If dtResumen.Rows(intCont).Item("ZSTALIB") = "X" Then
                        frmResumen.txtCantPELI.Text = frmResumen.txtCantPELI.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPELI = montPELI + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTACIE") = "X" Then
                        frmResumen.txtCantPECT.Text = frmResumen.txtCantPECT.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPECT = montPECT + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTAFI") = "X" Then
                        frmResumen.txtCantPECI.Text = frmResumen.txtCantPECI.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPECI = montPECI + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "PENDIENTE_F" Then
                    If dtResumen.Rows(intCont).Item("ZSTALIB") = "X" Then
                        frmResumen.txtCantPELI.Text = frmResumen.txtCantPELI.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPELI = montPELI + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTACIE") = "X" Then
                        frmResumen.txtCantPECT.Text = frmResumen.txtCantPECT.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPECT = montPECT + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTAFI") = "X" Then
                        frmResumen.txtCantPECI.Text = frmResumen.txtCantPECI.Text + dtResumen.Rows(intCont).Item("CANT")
                        montPECI = montPECI + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                        montPETO = montPETO + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                End If
                If dtResumen.Rows(intCont).Item("TIPO") = "ANULADOS" Then
                    If dtResumen.Rows(intCont).Item("ZSTALIB") = "X" Then
                        frmResumen.txtCantANLI.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontANLI.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontANTO = CType(frmResumen.MontANTO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTACIE") = "X" Then
                        frmResumen.txtCantANCT.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontANCT.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontANTO = CType(frmResumen.MontANTO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                    If dtResumen.Rows(intCont).Item("ZSTAFI") = "X" Then
                        frmResumen.txtCantANCI.Text = dtResumen.Rows(intCont).Item("CANT")
                        frmResumen.txtMontANCI.Text = Format(CType(dtResumen.Rows(intCont).Item("COSTO"), Double), "###,###,###,##0.00")
                        frmResumen.MontANTO = CType(frmResumen.MontANTO, Double) + CType(dtResumen.Rows(intCont).Item("COSTO"), Double)
                    End If
                End If

            Next
        End If

        frmResumen.txtMontPELI.Text = Format(montPELI, "###,###,###,##0.00")
        frmResumen.txtMontPECT.Text = Format(montPECT, "###,###,###,##0.00")
        frmResumen.txtMontPECI.Text = Format(montPECI, "###,###,###,##0.00")
        frmResumen.txtMontPETO.Text = Format(montPETO, "###,###,###,##0.00")

        frmResumen.StartPosition = FormStartPosition.CenterScreen
        frmResumen.ShowInTaskbar = False
        frmResumen.ShowDialog()
    End Sub

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "008"
        Dim dtExportarExcel As New DataTable
        oOrdenesinternas.INI_ORDEN = txtInicio.Text
        oOrdenesinternas.FIN_ORDEN = txtFin.Text
        oOrdenesinternas.INI_FECHA = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
        oOrdenesinternas.FIN_FECHA = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
        oOrdenesinternas.CSCDSP = sSociedad
        If oOrdenesinternas.CCLORI = "" Then Exit Sub
        If oOrdenesinternas.INI_ORDEN = "" Then Exit Sub
        If oOrdenesinternas.FIN_ORDEN = "" Then Exit Sub
        If oOrdenesinternas.INI_FECHA = "" Then Exit Sub
        If oOrdenesinternas.FIN_FECHA = "" Then Exit Sub

        dtExportarExcel = oOrdenesinternasNeg.Lista_Ordenes_Internas_Reporte_V2(oOrdenesinternas)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Not dtExportarExcel Is Nothing Then
            If dtExportarExcel.Rows.Count > 1 Then
                Dim OdtExporta As DataTable = dtExportarExcel.Copy
                OdtExporta.Columns(0).ColumnName = "\nTIPO"
                OdtExporta.Columns(1).ColumnName = "ORDEN\nINTERNA"
                OdtExporta.Columns(2).ColumnName = "FECHA\nO/I"
                OdtExporta.Columns(3).ColumnName = "NRO. ORDEN \nDE SERVICIO"
                OdtExporta.Columns(4).ColumnName = "NRO\nOPERACIÓN"
                OdtExporta.Columns(5).ColumnName = "NRO.\nDOCUMENTO"
                OdtExporta.Columns(6).ColumnName = "ESTADO\nOPERACIÓN"
                OdtExporta.Columns(7).ColumnName = "NRO. PLACA\nVEHICULO"
                OdtExporta.Columns(8).ColumnName = "\nCENTRO"
                OdtExporta.Columns(9).ColumnName = "ESTADO\nLIBERACION"
                OdtExporta.Columns(10).ColumnName = "FECHA\nLIBERACION"
                OdtExporta.Columns(11).ColumnName = "ESTADO\nCIERRE"
                OdtExporta.Columns(12).ColumnName = "FECHA\nCIERRE"
                OdtExporta.Columns(13).ColumnName = "ESTADO\nCIERRE FINAL"
                OdtExporta.Columns(14).ColumnName = "FECHA\nCIERRE FINAL"
                OdtExporta.Columns(15).ColumnName = "IMPORTE\nBRUTO"
                Dim ListDt As New List(Of DataTable)
                ListDt.Add(OdtExporta)
                Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "DETALLE ORDENES INTERNAS")
                'Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtExportarExcel)
            Else
                HelpClass.MsgBox("No hay Registros para exportar")
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class
