Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Cliente
Imports Ransa.Controls.Cliente
Imports Ransa.DAO.Cliente
Imports System.Text
Public Class frmCtaCte
    Private oCuentaCorrienteNeg As SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
    Private oCuentaCorriente As SOLMIN_CTZ.Entidades.CuentaCorriente
    Private oCuentaCorrienteAnulacion As SOLMIN_CTZ.Entidades.CuentaCorriente
    Private oCtaCte_VentaNeg As SOLMIN_CTZ.NEGOCIO.clsCtaCte_Venta
    Private oCtaCte_Venta As SOLMIN_CTZ.Entidades.CtaCte_Venta
    Private oCtaCte_ObservacionNeg As SOLMIN_CTZ.NEGOCIO.clsCtaCte_Observacion
    Private oCtaCte_Observacion As SOLMIN_CTZ.Entidades.CtaCte_Observacion
    Private oFacturaNeg As SOLMIN_CTZ.NEGOCIO.clsFactura
    Private oTipoDocumento As SOLMIN_CTZ.NEGOCIO.clsTipoDocumento
    'Private oPlantas As SOLMIN_CTZ.NEGOCIO.clsPlanta
    Private bolBuscar As Boolean
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private oRegionVenta As clsRegionVenta
    Private bolCambiar As Boolean
    Private bolPaginar As Boolean
    Private Mensaje_SAP As String = "Enviar al SAP"
    Private Mensaje_PPL As String = "Enviar a PPL"
    Private frmWait As GenerandoSap
    Private sSap As String = "S"
    Private oDtTiposDocumentos As DataTable
    Private oDtRegionVenta As DataTable
    Private oDtPlanta As DataTable
    Private dblNumFacImp As Int64 = 0
    Private strCompFacImp As String = ""
    Private strTipoDocFacImp As Int32 = 0
    Private strDivision As String
    Private Sub frmCtaCte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CuentaCorriente
        oCuentaCorrienteNeg = New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        oCuentaCorriente = New SOLMIN_CTZ.Entidades.CuentaCorriente
        oCuentaCorrienteAnulacion = New SOLMIN_CTZ.Entidades.CuentaCorriente
        'Observacion y Ventas
        oCtaCte_VentaNeg = New SOLMIN_CTZ.NEGOCIO.clsCtaCte_Venta
        oCtaCte_Venta = New SOLMIN_CTZ.Entidades.CtaCte_Venta
        oCtaCte_ObservacionNeg = New SOLMIN_CTZ.NEGOCIO.clsCtaCte_Observacion
        oCtaCte_Observacion = New SOLMIN_CTZ.Entidades.CtaCte_Observacion
        'TipoDocumento
        oTipoDocumento = New SOLMIN_CTZ.NEGOCIO.clsTipoDocumento
        oRegionVenta = New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        'Compania /Division / Planta
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy

        Cargar_TipoDocumento()
        Cargar_Compania()

        Cargar_Region_Venta()
        cbRango.Checked = True
        dtFechaFin.Value = Now
        dtFechaInicio.Value = Now.AddDays(1 - CInt(Today.Day.ToString))

        Ocultar_Controles()

        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable
        'oFiltro.Parametro1 = "100"
        'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
        oFiltro("CMNDA1") = "100"
        oFiltro("FCMBO") = Format(Now, "yyyyMMdd")
 

        oFacturaNeg = New clsFactura
        If oFacturaNeg.Lista_Tipo_Cambio(oFiltro).Rows.Count = 0 Then
            lblTipoCambio.Text = "Tipo de Cambio : 0"
        Else
            lblTipoCambio.Text = "Tipo de Cambio : " & oFacturaNeg.Lista_Tipo_Cambio(oFiltro).Rows(0).Item("IVNTA").ToString.Trim
        End If

        CargarEstado()
        CargarSeguimiento()

    End Sub

#Region "Comun"

    Private Sub CargarSeguimiento()
        Dim oSeguimiento As New clsSeguimientoDocumentos
        Dim oDt As New DataTable
        Dim oDtAux As New DataTable
        Dim dr As DataRow
        oDt.Columns.Add("CDSGDC", GetType(Decimal))
        oDt.Columns.Add("TDSGDC", GetType(String))
        dr = oDt.NewRow
        dr(0) = 0
        dr(1) = "TODOS"
        oDt.Rows.Add(dr)

        oDtAux = oSeguimiento.ListaSeguimientoDocumentos("EZ")

        For Each oDr As DataRow In oDtAux.Rows
            oDt.ImportRow(oDr)
        Next

        cmbSeguimiento.DataSource = oDt
        cmbSeguimiento.ValueMember = "CDSGDC"
        cmbSeguimiento.DisplayMember = "TDSGDC"
    End Sub

    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        'UcPLanta_Cmb01.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        'UcPLanta_Cmb01.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        'UcPLanta_Cmb01.Usuario = ConfigurationWizard.UserName
        'UcPLanta_Cmb01.pActualizar()
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

    Private Sub Cargar_Region_Venta()
        oRegionVenta.Crea_Lista()
        oDtRegionVenta = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        oDtRegionVenta.Columns.Remove("CCMPN")
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta

        For j As Integer = 0 To Me.cmbRegionVenta.Items.Count - 1
            If cmbRegionVenta.Items.Item(j).Value = "-1" Then
                cmbRegionVenta.SetItemChecked(j, True)
            End If
        Next
    End Sub

    Private Sub Cargar_TipoDocumento()
        oTipoDocumento.Crea_TipoDocumento()
        oDtTiposDocumentos = oTipoDocumento.Lista_TipoDocumento_Multiple(1)
        Me.cmbTipoDocumento.ValueMember = "CTPODC"
        Me.cmbTipoDocumento.DisplayMember = "TCMTPD"
        Me.cmbTipoDocumento.DataSource = oDtTiposDocumentos

        For i As Integer = 0 To cmbTipoDocumento.Items.Count - 1
            If cmbTipoDocumento.Items.Item(i).Value = "0" Then
                cmbTipoDocumento.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Sub Ocultar_Controles()
        btnAnulacion.Enabled = ButtonEnabled.False
        'btnExportarXLS.Enabled = ButtonEnabled.False
        'btnImprimir.Enabled = ButtonEnabled.False
        'btnVentas.Enabled = ButtonEnabled.False
        btnFacturar.Enabled = ButtonEnabled.False
        UcPaginacion1.Enabled = False
    End Sub

    Private Sub Mostrar_Controles()
        'btnAnulacion.Enabled = ButtonEnabled.True
        'btnExportarXLS.Enabled = ButtonEnabled.True
        'btnImprimir.Enabled = ButtonEnabled.True
        'btnVentas.Enabled = ButtonEnabled.True
        btnFacturar.Enabled = ButtonEnabled.True
        UcPaginacion1.Enabled = True
    End Sub

    Private Sub Limpiar_Paneles()
        Me.dtgObservaciones.DataSource = Nothing
        Me.dtgVentas.DataSource = Nothing
        Me.dtgDetalleOI.DataSource = Nothing
    End Sub

    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub

    Private Sub Limpiar_Controles()
        Me.dtgCuentaCorriente.DataSource = Nothing
    End Sub

    Private Function Lista_Tipo_Documentos() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbTipoDocumento.CheckedItems.Count - 1
            If (cmbTipoDocumento.CheckedItems(i).Value <> "0") Then
                For j As Integer = 0 To oDtTiposDocumentos.Rows.Count - 1
                    If (oDtTiposDocumentos.Rows(j).Item("CTPODC") = cmbTipoDocumento.CheckedItems(i).Value) Then
                        strCadDocumentos += oDtTiposDocumentos.Rows(j).Item("CTPODC") & ","
                    End If
                Next
            Else
                strCadDocumentos = "0,"
                Exit For
            End If
        Next
        strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

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
                strPlantas = "*,"
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        Else
            strPlantas = "*,"
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
                strRegionVenta = "*,"
                Exit For
            End If
        Next
        If strRegionVenta.Trim.Length > 0 Then
            strRegionVenta = strRegionVenta.Trim.Substring(0, strRegionVenta.Trim.Length - 1)
        Else
            strRegionVenta = "*,"

        End If
        Return strRegionVenta
    End Function

    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        Buscar_CtaCte()
    End Sub

    Private Sub CargarTodo()
        'KryptonHeaderGroup4.Enabled = True
        Limpiar_Paneles()
        Buscar_CtaCte()
    End Sub

    'Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click
    '    Dim dlg As dlgCtaCte
    '    dlg = New dlgCtaCte

    '    dlg.txtCompania.Text = UcCompania.CCMPN_Descripcion
    '    dlg.txtDivision.Text = UcDivision.DivisionDescripcion
    '    'dlg.txtPlanta.Text = UcPLanta_Cmb01.DescripcionPlanta
    '    dlg.txtPlanta.Text = Lista_DescPlanta()
    '    dlg.txtCodCompania.Text = UcCompania.CCMPN_CodigoCompania
    '    dlg.txtCodDivision.Text = IIf(UcDivision.Division = "-1", "*", UcDivision.Division)
    '    'dlg.txtCodPlanta.Text = IIf(UcPLanta_Cmb01.Planta = "-1", "*", UcPLanta_Cmb01.Planta)
    '    dlg.txtCodPlanta.Text = Lista_Planta()
    '    dlg.dtFechaInicio.Text = dtFechaInicio.Text
    '    dlg.dtFechaFin.Text = dtFechaFin.Text
    '    Dim cliente_TK As New Ransa.TypeDef.Cliente.TD_ClientePK
    '    cliente_TK.pCCLNT_Cliente = UcCliente.pCodigo
    '    dlg.ucCliente.pCargar(cliente_TK)

    '    dlg.txtCodRegionVenta.Text = Lista_RegionVenta() 'IIf(Me.cmbRegionVenta2.SelectedValue = "-1", "*", Me.cmbRegionVenta2.SelectedValue)
    '    dlg.txtRegionVenta.Text = Lista_DescRegionVenta() 'Me.cmbRegionVenta2.Text

    '    dlg.ShowInTaskbar = False
    '    dlg.StartPosition = FormStartPosition.CenterParent
    '    dlg.ShowDialog()
    'End Sub

    'Private Sub btnAnulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnulacion.Click
    '    ==============VERIFICAMOS SI ES EL MES ACTUAL=================
    '    Dim mesActual As Integer = CInt(CStr(Format(Now, "yyyyMMdd")).Substring(0, 6))
    '    Dim iPosFactElim As Integer = -1
    '    Dim mesDocumento As Integer = 0
    '    Me.dtgCuentaCorriente.EndEdit()
    '    oCuentaCorrienteAnulacion()
    '    Try

    '        For intContador As Integer = 0 To Me.dtgCuentaCorriente.RowCount - 1
    '            If Me.dtgCuentaCorriente.Item("SELECCION", intContador).Value = True And iPosFactElim = -1 Then
    '                iPosFactElim = intContador
    '                oCuentaCorrienteAnulacion.PSCCMPN = Me.dtgCuentaCorriente.Item("CCMPN", intContador).Value
    '                oCuentaCorrienteAnulacion.PSCDVSN = Me.dtgCuentaCorriente.Item("CDVSN", intContador).Value
    '                oCuentaCorrienteAnulacion.CTPODC = Me.dtgCuentaCorriente.Item("CTPODC", intContador).Value
    '                oCuentaCorrienteAnulacion.NDCCTC = Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value
    '                oCuentaCorrienteAnulacion.FDCCTC = HelpClass.FormatoFechaAS400(Me.dtgCuentaCorriente.Item("FDCCTC", intContador).Value)
    '                oCuentaCorrienteAnulacion.SABOPN = Me.dtgCuentaCorriente.Item("SABOPN", intContador).Value
    '                oCuentaCorrienteAnulacion.CMNDA = Me.dtgCuentaCorriente.Item("CMNDA", intContador).Value
    '                oCuentaCorrienteAnulacion.ITTPGS = Me.dtgCuentaCorriente.Item("ITTPGS", intContador).Value
    '                oCuentaCorrienteAnulacion.ITTPGD = Me.dtgCuentaCorriente.Item("ITTPGD", intContador).Value
    '                oCuentaCorrienteAnulacion.NTRMNL = HelpClass.NombreMaquina
    '                mesDocumento = CInt(CStr(oCuentaCorrienteAnulacion.FDCCTC).Substring(0, 6))
    '            End If
    '            Me.dtgCuentaCorriente.Item("SELECCION", intContador).Value = False
    '        Next
    '        If iPosFactElim <> -1 Then
    '            Select Case oCuentaCorrienteAnulacion.PSCDVSN
    '                Case "T"
    '                    If MsgBox("¿Desea Anular este Documento Nro.'" & oCuentaCorrienteAnulacion.NDCCTC & "' ?", MsgBoxStyle.YesNo, "Mensaje de Información") = MsgBoxResult.Yes Then
    '                        If mesDocumento <= mesActual And oCuentaCorrienteAnulacion.SABOPN = "P" Then
    '                            If (oCuentaCorrienteAnulacion.ITTPGD = 0 And oCuentaCorrienteAnulacion.CMNDA = "100") Or (oCuentaCorrienteAnulacion.ITTPGS = 0 And oCuentaCorrienteAnulacion.CMNDA = "1") Then
    '                                oCuentaCorrienteNeg.AnularCuentaCorriente(oCuentaCorrienteAnulacion)
    '                                HelpClass.MsgBox("Factura Anulada con Éxito")
    '                            End If
    '                        Else
    '                            HelpClass.MsgBox("No se puede Eliminar el documento pues NO pertenece al mes actual")
    '                        End If
    '                    End If
    '                Case "S"
    '                    Dim obeCuentaCorriente As CuentaCorriente
    '                    For Fila As Integer = 0 To Me.dtgCuentaCorriente.RowCount - 1
    '                        If Me.dtgCuentaCorriente.Item("SELECCION", Fila).Value = True Then
    '                            obeCuentaCorriente = New CuentaCorriente
    '                            obeCuentaCorriente.PSCCMPN = dtgCuentaCorriente.Rows(Fila).Cells("CCMPN").Value
    '                            obeCuentaCorriente.PSCDVSN = dtgCuentaCorriente.Rows(Fila).Cells("CDVSN").Value
    '                            obeCuentaCorriente.PNCTPODC = dtgCuentaCorriente.Rows(Fila).Cells("CTPODC").Value
    '                            obeCuentaCorriente.PNNDCCTC = dtgCuentaCorriente.Rows(Fila).Cells("NDCCTC").Value
    '                            obeCuentaCorriente.NTRMNL = HelpClass.NombreMaquina

    '                            oCuentaCorrienteNeg.AnularCuentaCorriente(oCuentaCorrienteAnulacion)
    '                        End If
    '                    Next
    '                    Exit Sub
    '                Case "R"
    '                    Exit Sub
    '                Case Else
    '                    Exit Sub
    '            End Select
    '        End If
    '    Catch ex As Exception
    '        HelpClass.MsgBox("Ocurrio un Error: " & ex.Message)
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Function HaySeleccion() As Boolean
    '    Me.dtgCuentaCorriente.EndEdit()
    '    Dim Seleccion As Boolean = False
    '    For Fila As Integer = 0 To Me.dtgCuentaCorriente.RowCount - 1
    '        If dtgCuentaCorriente.Rows(Fila).Cells("SELECCION").Value = True Then
    '            Seleccion = True
    '            Exit For
    '        End If
    '    Next
    '    Return Seleccion
    'End Function
    Private Sub btnAnulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnulacion.Click
        Me.dtgCuentaCorriente.EndEdit()
        Try
            If dtgCuentaCorriente.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim FilaSelec As Int32 = dtgCuentaCorriente.CurrentRow.Index
            Dim sbError As New StringBuilder
            Dim strMen As String = ""
            'Dim NDCCTC As Decimal = dtgCuentaCorriente.Rows(FilaSelec).Cells("NDCCTC").Value
            'Dim TABTPD As String = dtgCuentaCorriente.Rows(FilaSelec).Cells("TABTPD").Value

            'If dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value <> 1 Then
            '    MessageBox.Show("No puede anular este tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            'If dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value = 1 OrElse dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value = 7 Or dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value = 51 OrElse dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value = 57 Then
            '    If MessageBox.Show("Está seguro de anular documento: " & TABTPD & "-" & NDCCTC & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '        Dim obeCuentaCorriente As CuentaCorriente
            '        obeCuentaCorriente = New CuentaCorriente
            '        obeCuentaCorriente.PSCCMPN = ("" & dtgCuentaCorriente.Rows(FilaSelec).Cells("CCMPN").Value).ToString.Trim
            '        obeCuentaCorriente.PSCDVSN = ("" & dtgCuentaCorriente.Rows(FilaSelec).Cells("CDVSN").Value).ToString.Trim
            '        obeCuentaCorriente.PNCTPODC = dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value
            '        obeCuentaCorriente.PNNDCCTC = dtgCuentaCorriente.Rows(FilaSelec).Cells("NDCCTC").Value
            '        obeCuentaCorriente.PNCCLNT = dtgCuentaCorriente.Rows(FilaSelec).Cells("CCLNT").Value
            '        obeCuentaCorriente.NTRMNL = HelpClass.NombreMaquina
            '        strMen = oCuentaCorrienteNeg.Anular_Cuenta_Corriente(obeCuentaCorriente)
            '        Dim msg As String = ""
            '        Select Case strMen
            '            Case 0
            '                msg = " El documento debe ser anulado primero desde AS"
            '                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '            Case 1
            '                msg = "Documento Anulado" ' satisfactorio
            '                Try
            '                    Dim pobjFiltro As New Hashtable
            '                    pobjFiltro("PSCCMPN") = ("" & dtgCuentaCorriente.Rows(FilaSelec).Cells("CCMPN").Value).ToString.Trim
            '                    pobjFiltro("PNCTPODC") = dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value
            '                    pobjFiltro("PNNDCCTC") = dtgCuentaCorriente.Rows(FilaSelec).Cells("NDCCTC").Value
            '                    Dim clsFacturaBL As New clsFactura
            '                    clsFacturaBL.Anular_Cuenta_corriente_Historial_RZCT34(pobjFiltro)

            '                Catch ex As Exception
            '                End Try


            '                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '            Case 2
            '                msg = " - Registro no creado desde este Sistema"
            '                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        End Select
            '    End If
            'Else
            '    MessageBox.Show("No puede anular este tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If

            If dtgCuentaCorriente.RowCount > 0 Then
                Dim ndcctc As String = Trim(dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value)
                Dim tabtpd As String = Trim(dtgCuentaCorriente.Rows(FilaSelec).Cells("TABTPD").Value)
                Dim ccmpn As String = Trim(UcCompania.CCMPN_CodigoCompania)
                Dim ctpodc As String = Trim(dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value)

 
                If MessageBox.Show(String.Format("¿Está seguro de anular documento: {0} - {1}?", TABTPD, NDCCTC), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'INI-ECM-ActualizacionTarifario[RF003]-160516
                    'Dim mensajeValidacion As String = oCuentaCorrienteNeg.ValidarAnulacionDocumento(ccmpn, ctpodc, ndcctc)
                    'If Len(mensajeValidacion) > 0 Then
                    '    MessageBox.Show(mensajeValidacion, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    Exit Sub
                    'End If
                    'FIN-ECM-ActualizacionTarifario[RF003]-160516
 
                'If MessageBox.Show(String.Format("¿Está seguro de anular documento: {0} - {1}?", tabtpd, ndcctc), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

  '                  Dim mensajeValidacion As String = oCuentaCorrienteNeg.ValidarAnulacionDocumento(ccmpn, ctpodc, ndcctc)
   '                 If Len(mensajeValidacion) > 0 Then
    '                    MessageBox.Show(mensajeValidacion, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
     '                   Exit Sub
      '              End If
 

                    Dim cuentaCorriente As New CuentaCorriente
                    With cuentaCorriente
                        .PSCCMPN = Trim(dtgCuentaCorriente.Rows(FilaSelec).Cells("CCMPN").Value)
                        .PSCDVSN = Trim(dtgCuentaCorriente.Rows(FilaSelec).Cells("CDVSN").Value)
                        .PNCTPODC = dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value
                        .PNNDCCTC = dtgCuentaCorriente.Rows(FilaSelec).Cells("NDCCTC").Value
                        .PNCCLNT = dtgCuentaCorriente.Rows(FilaSelec).Cells("CCLNT").Value
                        .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With

                    Dim mensajeAnulacion As String = oCuentaCorrienteNeg.AnulacionCuentaCorriente(cuentaCorriente)
                    If Len(mensajeAnulacion) > 0 Then
                        MessageBox.Show(mensajeAnulacion, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    Dim tmpTable As New Hashtable
                    tmpTable("PSCCMPN") = Trim(dtgCuentaCorriente.Rows(FilaSelec).Cells("CCMPN").Value)
                    tmpTable("PNCTPODC") = dtgCuentaCorriente.Rows(FilaSelec).Cells("CTPODC").Value
                    tmpTable("PNNDCCTC") = dtgCuentaCorriente.Rows(FilaSelec).Cells("NDCCTC").Value
                    Dim facturaBL As New clsFactura
                    facturaBL.Anular_Cuenta_corriente_Historial_RZCT34(tmpTable)
                    MessageBox.Show("El documento se anulo con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub cbSap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSap.CheckedChanged
        If cbSap.Checked Then
            sSap = "N"
        Else
            sSap = "S"
        End If
    End Sub
#End Region

#Region "Carga Detalles Ventas, O/I, Observaciones, "

    Private Sub CargarEstado()
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("Nombre", GetType(String))
        oDt.Columns.Add("Codigo", GetType(String))

        oDr = oDt.NewRow
        oDr(0) = "---------TODOS------------"
        oDr(1) = "O"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr(0) = "Emitidas"
        oDr(1) = "E"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr(0) = "En Cobranza"
        oDr(1) = "Z"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr(0) = "En Cobrador"
        oDr(1) = "R"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr(0) = "En Cliente"
        oDr(1) = "C"
        oDt.Rows.Add(oDr)

        cmbEstadoFac.DataSource = oDt
        cmbEstadoFac.ValueMember = "Codigo"
        cmbEstadoFac.DisplayMember = "Nombre"

    End Sub

    Private Sub Buscar_CtaCte()
        'BUSCA SEGUN FILTRO
        If bolPaginar = False Then
            UcPaginacion1.PageNumber = 1
        End If
        Dim tipoDocu As String = Lista_Tipo_Documentos()
        'Buscamos Rango de Fechas y Estado SAP
        If cbRango.Checked Then
            oCuentaCorriente.FechaInicio = HelpClass.FormatoFechaAS400(Me.dtFechaInicio.Text)
            oCuentaCorriente.FechaFin = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Text)
        Else
            oCuentaCorriente.FechaInicio = "0"
            oCuentaCorriente.FechaFin = "90000000"
        End If
        oCuentaCorriente.EstadoSap = sSap
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oCuentaCorriente.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            oCuentaCorriente.CCLNT = IIf(Me.UcCliente.pCodigo.ToString = "0", "-1", Me.UcCliente.pCodigo)

            If UcDivision.Division = "-1" Then
                oCuentaCorriente.PSCDVSN = "%"
            Else
                oCuentaCorriente.PSCDVSN = UcDivision.Division
            End If
            oCuentaCorriente.PSEST_DOC = cmbEstadoFac.SelectedValue
            oCuentaCorriente.PNCDSGDC = cmbSeguimiento.SelectedValue
            oCuentaCorriente.CPLNDV = Lista_Planta() 'UcPLanta_Cmb01.Planta
            oCuentaCorriente.CTPODC = tipoDocu
            oCuentaCorriente.PageNumber = UcPaginacion1.PageNumber
            oCuentaCorriente.PageCount = UcPaginacion1.PageCount
            oCuentaCorriente.PageSize = UcPaginacion1.PageSize

            If Me.txtNumDocumento.Text.Trim = "" Or Me.txtNumDocumento.Text.Trim.Length = 0 Then
                oCuentaCorriente.NDCCTC = "0"
            Else
                oCuentaCorriente.NDCCTC = txtNumDocumento.Text.Trim
            End If

            oCuentaCorriente.CRGVTA = Lista_RegionVenta() 'cmbRegionVenta2.SelectedValue
            Dim odtCtaCte As New DataTable
            '------------Usando Hilos Thread------------
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            odtCtaCte = oCuentaCorrienteNeg.Listar_CuentaCorriente(oCuentaCorriente)
            proceso_espera.Abort()
            '----------------------------------
            Limpiar_Controles()

            Llenar_Grilla_CuentaCorriente(odtCtaCte)
            If Me.dtgCuentaCorriente.Rows.Count > 0 Then
                Cargar_Informacion_CtaCte(Me.dtgCuentaCorriente.Rows(0).Cells("CCMPN").Value, _
                                        Me.dtgCuentaCorriente.Rows(0).Cells("CTPODC").Value, _
                                        Me.dtgCuentaCorriente.Rows(0).Cells("NDCCTC").Value)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Replicar(ByVal str As String, ByVal Times As Int32) As String
        Replicar = String.Empty
        For i As Integer = 1 To Times
            Replicar += str
        Next
    End Function
    Private Sub dtgCuentaCorriente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellClick
        If e.RowIndex > -1 Then

            ' If e.ColumnIndex = 15 Then                                      'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
            If dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "NDCMSP" Then
                If Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CTPODC").Value = 6 Then
                    MessageBox.Show("Los documentos Partes Transferencia no pueden ser enviados a SAP", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else                                                          'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
                    If Me.dtgCuentaCorriente.CurrentCell.Value = Mensaje_SAP Then
                        oCuentaCorriente.PSCCMPN = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CCMPN").Value
                        oCuentaCorriente.CTPODC = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CTPODC").Value
                        If Len(oCuentaCorriente.CTPODC) < 3 Then
                            oCuentaCorriente.CTPODC = Replicar("0", 3 - Len(oCuentaCorriente.CTPODC)) & oCuentaCorriente.CTPODC
                        End If
                        oCuentaCorriente.NDCCTC = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("NDCCTC").Value.ToString.PadLeft(10, "0")
                        Dim question As Integer
                        question = MessageBox.Show("Enviar Documento al SAP?", "Mensaje de Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        If question = 6 Then
                            Try
                                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                                If oCuentaCorriente.CTPODC = "051" Or oCuentaCorriente.CTPODC = "052" Or oCuentaCorriente.CTPODC = "053" Or oCuentaCorriente.CTPODC = "057" Then
                                    Dim oFiltro As New Filtro
                                    Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

                                    oFiltro.Parametro1 = oCuentaCorriente.PSCCMPN
                                    oFiltro.Parametro2 = oCuentaCorriente.CTPODC
                                    oFiltro.Parametro3 = oCuentaCorriente.NDCCTC.PadLeft(10, "0")
                                    'oFacturaNeg.Enviar_Documento_SAP(oFiltro)
                                    oFacturaNeg.Enviar_Documento_SAP_FE(oFiltro)

                                Else : oCuentaCorrienteNeg.Generar_SAP_CuentaCorriente(oCuentaCorriente)
                                End If

                                'KryptonHeaderGroup4.Enabled = True
                                bolPaginar = False
                                Limpiar_Paneles()
                                Buscar_CtaCte()
                                MsgBox("Se ha generado un codigo SAP a este documento")
                                Me.Cursor = System.Windows.Forms.Cursors.Default
                            Catch ex As Exception
                                Me.Cursor = System.Windows.Forms.Cursors.Default
                                HelpClass.MsgBox(ex.Message)
                            End Try
                        End If
                    End If
                End If

                '  ElseIf e.ColumnIndex = 45 Then                                           'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA
            ElseIf dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "ESTADOPAPERLSS" Then   'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA

                If Me.dtgCuentaCorriente.CurrentCell.Value.ToString() = Mensaje_PPL Then

                    oCuentaCorriente.PSCCMPN = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CCMPN").Value
                    oCuentaCorriente.CTPODC = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CTPODC").Value
                    If Len(oCuentaCorriente.CTPODC) < 3 Then
                        oCuentaCorriente.CTPODC = Replicar("0", 3 - Len(oCuentaCorriente.CTPODC)) & oCuentaCorriente.CTPODC
                    End If
                    oCuentaCorriente.NDCCTC = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("NDCCTC").Value

                    Dim question As Integer
                    question = MessageBox.Show("Enviar Documento al PPL?", "Mensaje de Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                    If question = 6 Then
                        Try
                            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                            If oCuentaCorriente.CTPODC = "051" Or oCuentaCorriente.CTPODC = "052" Or oCuentaCorriente.CTPODC = "053" Or oCuentaCorriente.CTPODC = "057" Then
                                Dim oFiltro As New Filtro
                                Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

                                oFiltro.Parametro1 = oCuentaCorriente.PSCCMPN
                                oFiltro.Parametro2 = oCuentaCorriente.CTPODC
                                oFiltro.Parametro3 = oCuentaCorriente.NDCCTC.PadLeft(10, "0")
                                oFiltro.Parametro4 = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CSCDSP").Value
                                oFiltro.Parametro5 = Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("NUMEROFE").Value
                                oFacturaNeg.Reenviar_Documento_SAP_FE(oFiltro)
                                'Else : oCuentaCorrienteNeg.Generar_SAP_CuentaCorriente(oCuentaCorriente)
                            End If

                            'KryptonHeaderGroup4.Enabled = True
                            bolPaginar = False
                            Limpiar_Paneles()
                            Buscar_CtaCte()
                            'MsgBox("Se ha generado un codigo SAP a este documento")
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                        Catch ex As Exception
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            HelpClass.MsgBox(ex.Message)
                        End Try
                    End If
                End If
            Else
                Cargar_Informacion_CtaCte(Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CCMPN").Value, _
                                                        Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CTPODC").Value, _
                                                        Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("NDCCTC").Value)
            End If
        End If
    End Sub
    Private Sub dtgCuentaCorriente_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellEnter
        If e.RowIndex > -1 Then
            Cargar_Informacion_CtaCte(Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CCMPN").Value, _
                                        Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("CTPODC").Value, _
                                        Me.dtgCuentaCorriente.Rows(e.RowIndex).Cells("NDCCTC").Value)
        End If
    End Sub
    Private Sub Cargar_Informacion_CtaCte(ByVal pdblCompania As String, ByVal pstrDocumento As String, ByVal pstrNumDocumento As String)
        bolCambiar = False
        Mostrar_Controles()
        Limpiar_Paneles()
        'cargamos objetos
        oCtaCte_Observacion.PSCCMPN = pdblCompania
        oCtaCte_Observacion.NDCCTC = pstrNumDocumento
        oCtaCte_Observacion.CTPODC = pstrDocumento
        oCtaCte_Venta.PSCCMPN = pdblCompania
        oCtaCte_Venta.NDCCTC = pstrNumDocumento
        oCtaCte_Venta.CTPODC = pstrDocumento
        Cargar_Ventas()
        Cargar_Observaciones()
        Cargar_OrdenesInternas()
        bolCambiar = True
    End Sub
    Private Sub Cargar_OrdenesInternas()
        Dim oDt As DataTable
        oDt = oCuentaCorrienteNeg.Lista_CtaCte_OrdenesInternas(oCtaCte_Venta)
        dtgDetalleOI.AutoGenerateColumns = False
        dtgDetalleOI.DataSource = oDt
    End Sub
    Private Sub Cargar_Observaciones()
        Dim oDt As DataTable
        oDt = oCtaCte_ObservacionNeg.Lista_CtaCte_Observacion(oCtaCte_Observacion)
        dtgObservaciones.AutoGenerateColumns = False
        dtgObservaciones.DataSource = oDt
    End Sub
    Private Sub Cargar_Ventas()
        Dim oDt As DataTable
        oDt = oCtaCte_VentaNeg.Lista_CtaCte_Venta(oCtaCte_Venta)
        dtgVentas.AutoGenerateColumns = False
        dtgVentas.DataSource = oDt
    End Sub
    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim dlg As dlgCtaCte
    '    dlg = New dlgCtaCte
    '    dlg.txtCompania.Text = UcCompania.CCMPN_Descripcion
    '    dlg.txtDivision.Text = UcDivision.DivisionDescripcion
    '    dlg.txtCodCompania.Text = UcCompania.CCMPN_CodigoCompania
    '    dlg.txtCodDivision.Text = IIf(UcDivision.Division = "-1", "*", UcDivision.Division)
    '    dlg.ShowInTaskbar = False
    '    dlg.StartPosition = FormStartPosition.CenterParent
    '    dlg.ShowDialog()
    'End Sub
#End Region

#Region "Grilla Cuenta Corriente"
    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    If cmbTipoDocumento.Text.Trim = "" Then
    '        HelpClass.MsgBox("Debe Seleccionar al Menos un Tipo Documento")
    '        Exit Sub
    '    End If
    '    bolPaginar = False
    '    Limpiar_Paneles()
    '    Buscar_CtaCte()
    'End Sub
    Private Sub Llenar_Grilla_CuentaCorriente(ByVal odtCtaCte As DataTable)
        If odtCtaCte.Rows.Count = 0 Then Ocultar_Controles()
        If odtCtaCte.Rows.Count = 0 Then Exit Sub
        Mostrar_Controles()
        dtgCuentaCorriente.AutoGenerateColumns = False
        dtgCuentaCorriente.DataSource = odtCtaCte
        If odtCtaCte.Rows.Count > 0 Then
            Me.UcPaginacion1.PageCount = odtCtaCte.Rows(0).Item("PageCount")
        End If
    End Sub
    Private Sub dtgCuentaCorriente_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgCuentaCorriente.DataBindingComplete
        For i As Integer = 0 To dtgCuentaCorriente.Rows.Count - 1
            If dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Value.ToString.Trim = "0" Then
                Dim cell As DataGridViewImageCell = CType(dtgCuentaCorriente.Rows(i).Cells("imgLINKFE"), DataGridViewImageCell)
                dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Value = Mensaje_SAP
                dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Style.ForeColor = Color.Blue
                cell.Value = My.Resources.text_block
            Else
                Dim cell As DataGridViewImageCell = CType(dtgCuentaCorriente.Rows(i).Cells("imgLINKFE"), DataGridViewImageCell)

                If ((dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "51" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "52" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "53" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "57") AndAlso dtgCuentaCorriente.Rows(i).Cells("NDCMSP").Value <> Mensaje_SAP) Then

                    If dtgCuentaCorriente.Rows(i).Cells("LINK_FE").Value.ToString.Trim = String.Empty Then
                        cell.Value = My.Resources.text_block 'My.Resources.ImportarCap
                    Else
                        cell.Value = My.Resources.pdf2
                    End If

                    'Else
                    '    cell.Value = My.Resources.filesave

                End If
            End If
        Next

    End Sub
#End Region

#Region "Imprime Facturas"

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        Try
            If HelpClass.RspMsgBox("Está seguro de Imprimir la Factura? ") = Windows.Forms.DialogResult.Yes Then
                Me.dtgCuentaCorriente.EndEdit()
                For intContador As Integer = 0 To Me.dtgCuentaCorriente.RowCount - 1
                    If Me.dtgCuentaCorriente.Item("SELECCION", intContador).Value = True Then
                        Select Case Me.dtgCuentaCorriente.Item("CDVSN", intContador).Value
                            Case "T", "S"
                                Imprime_Factura(Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value, Me.dtgCuentaCorriente.Item("CCMPN", intContador).Value, Me.dtgCuentaCorriente.Item("CTPODC", intContador).Value, Me.dtgCuentaCorriente.Item("CDVSN", intContador).Value)
                                HelpClass.MsgBox("Se acabó de imprimir la Factura N° " & Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value)
                                Me.dtgCuentaCorriente.Item("SELECCION", intContador).Value = False

                                'Case "R"

                                '    Imprime_Factura_SA(Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value, Me.dtgCuentaCorriente.Item("CCMPN", intContador).Value, Me.dtgCuentaCorriente.Item("CTPODC", intContador).Value)
                                '    HelpClass.MsgBox("Se acabó de imprimir la Factura N° " & Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value)
                                '    Me.dtgCuentaCorriente.Item("SELECCION", intContador).Value = False
                            Case Else
                                Exit Sub
                        End Select
                        If Me.dtgCuentaCorriente.Item("CDVSN", intContador).Value = "T" Then
                            ImprimirSustento(Me.dtgCuentaCorriente.Item("NDCCTC", intContador).Value, Me.dtgCuentaCorriente.Item("CCMPN", intContador).Value, Me.dtgCuentaCorriente.Item("CTPODC", intContador).Value, Me.dtgCuentaCorriente.Item("CDVSN", intContador).Value)
                        End If
                    End If
                Next
            End If
        Catch : End Try
    End Sub

    Public Sub Imprime_Factura(ByVal pdblNumFacImp As Int64, ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrDivision As String)
        Try
            Dim prn As New Printing.PrintDocument

            dblNumFacImp = pdblNumFacImp
            strCompFacImp = pstrCompania
            strTipoDocFacImp = pstrTipoDoc
            strDivision = pstrDivision
            With prn
                AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
                prn.Print()
                RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            End With
            dblNumFacImp = 0
            strCompFacImp = ""
            strTipoDocFacImp = 0
        Catch ex As Exception
            HelpClass.MsgBox("Error al imprimir la factura N° " & pdblNumFacImp & vbCrLf & ex.Message)
        End Try
    End Sub



    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim oDs As New DataSet
        Dim myFont As New Font("Nina Negrita", 8, FontStyle.Bold)
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim intPosLinea As Integer = 0
        Dim dblTotal As Double = 0
        Dim dblValorReferencial As Double = 0
        Dim bolIGV As Boolean = False
        Dim strMonto As String = ""
        Dim strMoneda As String = ""
        Dim lintEstado As Int32 = 0
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim dblSubTotalSoles As Double = 0

        Select Case strDivision 'Me.cmbDivision.SelectedValue
            Case "S"
                Dim oFiltro As New Filtro
                oFiltro.Parametro1 = strCompFacImp
                oFiltro.Parametro2 = strTipoDocFacImp
                oFiltro.Parametro3 = dblNumFacImp
                oDs = oFacturaNeg.Lista_Datos_Factura(oFiltro)
            Case "T"
                Dim oFiltro As Hashtable
                oFiltro = New Hashtable
                oFiltro.Add("PSCCMPN", strCompFacImp)
                oFiltro.Add("PNCTPODC", strTipoDocFacImp)
                oFiltro.Add("PNNDCCTC", dblNumFacImp)
                oDs = oFacturaNeg.Lista_Datos_Factura_Transporte(oFiltro)
                oFiltro = New Hashtable
                oFiltro.Add("PNCTPODC", strTipoDocFacImp)
                oFiltro.Add("PNNDCCTC", dblNumFacImp)
                dblValorReferencial = oFacturaNeg.Obtener_Valor_Referencial(oFiltro)
                lintEstado = oFacturaNeg.Obtener_Tipo_Factura(oFiltro)
        End Select

        strMoneda = oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim()

        args.Graphics.DrawString("Sres.:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 80)
        args.Graphics.DrawString("Código:  " & oDs.Tables(0).Rows(0).Item("CCLNT").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 370, 80)
        args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TCMPCL").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 93)
        args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TDRCOR").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 106)
        args.Graphics.DrawString("Num.R.U.C.:  " & oDs.Tables(0).Rows(0).Item("NRUC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 119)
        args.Graphics.DrawString("Zona Cobranza:  " & oDs.Tables(0).Rows(0).Item("CZNCBD").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 350, 119)
        args.Graphics.DrawString("Fecha Doc.:  " & oDs.Tables(0).Rows(0).Item("FECHA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 132)

        args.Graphics.DrawString("Referencia:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 180)
        args.Graphics.DrawString("No. Control : " & dblNumFacImp, New Font(myFont, FontStyle.Regular), Brushes.Black, 600, 180)

        oDr = oDs.Tables(2).Select("CTPDCC = 1")
        intPosLinea = 202
        For intCont = 0 To oDr.Length - 1
            args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next intCont

        ' If lintEstado = 0 Then
        args.Graphics.DrawString("Cod", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 270)
        args.Graphics.DrawString("Descripción", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 270)
        args.Graphics.DrawString("Cantidad", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 270)
        args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 270)
        args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 270)
        args.Graphics.DrawString("Rub", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 283)
        args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 283)
        args.Graphics.DrawString("Aplicada", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 283)
        args.Graphics.DrawString("Tarifa", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 283)
        args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 283)
        ' Else
        ' args.Graphics.DrawString("DETALLE", New Font(myFont, FontStyle.Regular), Brushes.Black, 300, 270)
        ' End If
        args.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 15, 296)

        If strMoneda = "DOL" Then
            strMoneda = "USD"
        Else
            strMoneda = "S/."
        End If
        'If lintEstado = 0 Then
        intPosLinea = 309
        For intCont = 0 To oDs.Tables(1).Rows.Count - 1
            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                args.Graphics.DrawString(strMoneda, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
                If strMoneda = "USD" Then
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
                Else
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
                End If
                dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(intCont).Item("IVLDCS")
            Else
                bolIGV = True
                intPosLinea = intPosLinea - 13
            End If
            intPosLinea = intPosLinea + 13
        Next intCont

        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        If bolIGV Then
            args.Graphics.DrawString("IGV " & oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            If strMoneda = "USD" Then
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim
            Else
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim
            End If
            intPosLinea = intPosLinea + 13
        End If
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Total: " & strMoneda, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13

        'CSR-HUNDRED-240815-AJUSTE-MONEDA-INICIO
        Dim strMensajeError As String = ""
        Dim dtMoneda As DataTable
        Dim oMoneda_DAL As New Ransa.Controls.Moneda.Moneda_DAL
        Dim Soles As String = ""
        Dim Dolares As String = ""

        dtMoneda = oMoneda_DAL.fdtListar_Listar_Moneda(strMensajeError)

        For Each dr As DataRow In dtMoneda.Rows
            If (dr("CMNDA1") = 1) Then
                Soles = dr("TMNDA").ToString
            ElseIf (dr("CMNDA1") = 100) Then
                Dolares = dr("TMNDA").ToString
            End If
        Next
        'CSR-HUNDRED-240815-AJUSTE-MONEDA-FIN

        If strMoneda = "USD" Then
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & Dolares        'CSR-HUNDRED-240815-AJUSTE-MONEDA " Dolares Americanos"
        Else
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & Soles          'CSR-HUNDRED-240815-AJUSTE-MONEDA " Nuevos Soles" 
        End If
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda & "    " & Format(dblTotal, "###,###,###,###.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)
        Select Case UcDivision.Division
            Case "T"
                args.Graphics.DrawString("Reg. MTC 150491-CNG VAL. REF DETRACCION S/." & dblValorReferencial, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
                If dblSubTotalSoles >= 700 Then
                    args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL  " & oDs.Tables(0).Rows(0).Item("NDSPGD") & " % " & " -  CUENTA " & IIf(strCompFacImp.Trim.Equals("EZ"), "362956", "").ToString, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
                End If
            Case "S"
                If dblSubTotalSoles >= 700 Then
                    args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL  " & "0.12% " & " -  CUENTA " & IIf(strCompFacImp.Trim.Equals("EZ"), "362956", "").ToString, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
                End If
        End Select
        If lintEstado = 0 Then
            args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 756)
        End If
    End Sub


    Private Sub ImprimirSustento(ByVal pdblNumFacImp As Int64, ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrDivision As String)
        Dim obj_Logica As New clsCuentaCorriente
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objDt As New DataTable

        'Dim objetoRep As New rptSustento_FacturaV1
        Dim objetoRep As New rptSustento_Factura
        Dim objParametro As New CuentaCorriente
        Try
            If pdblNumFacImp = 0 Then Exit Sub
            objParametro.NDCCTC = pdblNumFacImp
            objParametro.PSCCMPN = pstrCompania
            objParametro.PSCDVSN = pstrDivision
            objDt = obj_Logica.Listar_Sustento_Factura(objParametro)

            objDt.TableName = "RZCT01"

            If objDt.Rows.Count = 0 Then
                HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
                Exit Sub
            End If
            objDs.Tables.Add(objDt.Copy)
            objetoRep.SetDataSource(objDs)

            CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
            CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCompania.CCMPN_Descripcion
            CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcDivision.DivisionDescripcion
            CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Lista_DescPlanta() 'UcPLanta_Cmb01.DescripcionPlanta
            CType(objetoRep.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & CStr(pdblNumFacImp).Trim
            objPrintForm.ShowForm(objetoRep, Me)

        Catch : End Try
    End Sub
#End Region



    Private Sub ActualizarFacturas(ByVal psTipo As String)
        Dim oCuentaCC As New CuentaCorriente
        Dim oCuentaAct As New CuentaCorriente
        oCuentaCorrienteNeg = New clsCuentaCorriente
        Dim oDtResultado As New DataTable
        Dim oFrmAgrFac As New frmLeerfacturas

        oFrmAgrFac.psTipoDocumento = psTipo
        oFrmAgrFac.Text = "Enviar Documentos " & IIf(psTipo = "Z", "a ", "al ") & DescripcionTipo(psTipo)
        Dim psCorrelativo As String = "0"
        Dim psCorrelativoAux As String = String.Empty
        Dim nCount As Integer = 0
        If oFrmAgrFac.ShowDialog = Windows.Forms.DialogResult.Yes Then

            oDtResultado = oFrmAgrFac.oDtResultado
            oDtResultado.DefaultView.Sort = "CCMPN,CDVSN"
            oDtResultado = oDtResultado.DefaultView.ToTable

            For Each dr As DataRow In oDtResultado.Rows
                oCuentaAct = New CuentaCorriente
                oCuentaAct = oCuentaCC
                Dim psCodigo As String = String.Empty
                psCodigo = dr("CCMPN") & dr("CDVSN") & "RNC"

                oCuentaAct.PSEST_DOC = psTipo
                oCuentaAct.NDCCTC = dr("Numero")

                'En caso de que la compañia o division sean diferentes se obtiene otro correlativo
                If nCount > 0 And psCorrelativoAux <> psCodigo Then
                    nCount = 0
                End If

                'Se obtiene el correlativo para solo cuando es tipo cobranza
                If nCount = 0 And psTipo = "Z" Then
                    psCorrelativo = oCuentaCorrienteNeg.ObtenerCorrelativo(psCodigo).Rows(0).Item("NULCTR")
                End If

                oCuentaAct.NRLENC = psCorrelativo
                oCuentaAct.FENT = HelpClass.CtypeDate(oFrmAgrFac.dtpFechaEnvio.Value)
                'Seteamos el correlativo para la comparación
                psCorrelativoAux = psCodigo
                oCuentaAct.Estado = "1"
                If oCuentaCorrienteNeg.ActualizaEstadoDocumento(oCuentaAct) = 0 Then
                    MessageBox.Show("Ocurrió un error al grabar en el número de doc. " & oCuentaAct.NDCCTC)
                End If

                nCount += 1
            Next

            'No se imprime si es de tipo Cliente
            If Not psTipo = "C" Then
                ImprimirNumeroDocumentos(oDtResultado, psTipo, psCorrelativo, oFrmAgrFac.dtpFechaEnvio.Value.ToShortDateString)
            End If

            '  btnBuscar_Click(Nothing, Nothing)
            btnBusca_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ImprimirNumeroDocumentos(ByVal oDt As DataTable, ByVal psTipo As String, ByVal psCorrelativo As String, ByVal psFechaTansferencia As String)
        Dim objPrintForm As New PrintForm
        Dim objetoRep As New rptListaDocumentos
        Dim objDs As New DataSet
        oDt.TableName = "DataTable1"
        objDs.Tables.Add(oDt.Copy)

        objetoRep.SetDataSource(objDs)
        objetoRep.SetParameterValue("pUsuario", ConfigurationWizard.UserName)
        objetoRep.SetParameterValue("pCompania", oDt.Rows(0).Item("CCMPN") & "  " & oDt.Rows(0).Item("TCMPCM"))
        objetoRep.SetParameterValue("pDivision", oDt.Rows(0).Item("CDVSN") & "  " & oDt.Rows(0).Item("TCMPDV"))
        objetoRep.SetParameterValue("pTransferencia", DescripcionTipo(psTipo) & "  " & psFechaTansferencia)
        objetoRep.SetParameterValue("pNumeroDocumentos", DescripcionTipo(psTipo) & " : " & oDt.Rows.Count.ToString)

        If psTipo = "Z" Then
            CType(objetoRep.ReportDefinition.ReportObjects("txtCorrelativo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = psCorrelativo
            objetoRep.SetParameterValue("bolCobranza", True)
        Else
            objetoRep.SetParameterValue("bolCobranza", False)
        End If

        objPrintForm.ShowForm(objetoRep, Me)

    End Sub

    Private Function DescripcionTipo(ByVal psTipo As String) As String
        Dim psDesTipo As String = ""
        Select Case psTipo
            Case "Z"
                psDesTipo = "Cobranzas."
            Case "R"
                psDesTipo = "Cobrador."
            Case "C"
                psDesTipo = "Cliente."

        End Select
        Return psDesTipo
    End Function



    Private Sub txtNumDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDocumento.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub btnPorCobranza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorCobranza.Click
        ActualizarFacturas("Z")
    End Sub

    Private Sub btnPorCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorCliente.Click
        ActualizarFacturas("C")
    End Sub

    Private Sub btnPorCobrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorCobrador.Click
        ActualizarFacturas("R")
    End Sub


    Private Function ObtenerCodigoDescripcion(ByRef strEstadoActual As String, ByRef strFechaEstado As String) As String
        Dim psCodigo As String = String.Empty

        If dtgCuentaCorriente.CurrentRow.Cells("EST_COBRADOR").Value <> String.Empty _
        And dtgCuentaCorriente.CurrentRow.Cells("EST_CLIENTE").Value <> String.Empty Then
            psCodigo = "C"
            strEstadoActual = "Cliente"
            strFechaEstado = dtgCuentaCorriente.CurrentRow.Cells("FEC_CLIENTE").Value
        Else
            If dtgCuentaCorriente.CurrentRow.Cells("EST_COBRADOR").Value <> String.Empty _
             And dtgCuentaCorriente.CurrentRow.Cells("EST_CLIENTE").Value = String.Empty Then
                psCodigo = "R"
                strEstadoActual = "Cobrador"
                strFechaEstado = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRADOR").Value
            Else
                If dtgCuentaCorriente.CurrentRow.Cells("EST_COBRANZA").Value <> String.Empty _
             And dtgCuentaCorriente.CurrentRow.Cells("EST_COBRADOR").Value = String.Empty _
             And dtgCuentaCorriente.CurrentRow.Cells("EST_CLIENTE").Value = String.Empty Then
                    psCodigo = "Z"
                    strEstadoActual = "Cobranza"
                    strFechaEstado = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRANZA").Value
                End If
            End If
        End If

        Return psCodigo
    End Function

    Private Sub ExportarExcel()

        Dim oCuentaCorrienteExport As New CuentaCorriente

        For i As Integer = 0 To UcPaginacion1.PageCount - 1

        Next

        Dim oDtExportar As New DataTable
        Dim ds As New DataSet
        If dtgCuentaCorriente.RowCount = 0 Then Exit Sub
        oCuentaCorrienteExport = oCuentaCorriente

        oCuentaCorrienteExport.PageNumber = 1
        oCuentaCorrienteExport.PageCount = 0
        oCuentaCorrienteExport.PageSize = 10000

        oDtExportar = oCuentaCorrienteNeg.Listar_CuentaCorriente(oCuentaCorrienteExport)
        oDtExportar.Columns.Remove("ROWNUMBER")
        oDtExportar.Columns.Remove("CO_CIAA")
        oDtExportar.Columns.Remove("TI_DOCU")
        oDtExportar.Columns.Remove("NO_DOCU")
        oDtExportar.Columns.Remove("CO_MONE")
        oDtExportar.Columns.Remove("IVLAFD")
        oDtExportar.Columns.Remove("IVLAFS")
        oDtExportar.Columns.Remove("NINDRN")
        oDtExportar.Columns.Remove("ITTPGD")
        oDtExportar.Columns.Remove("ITTPGS")
        oDtExportar.Columns.Remove("PageCount")

        oDtExportar.Columns.Remove("EST_COBRANZA")
        oDtExportar.Columns.Remove("EST_COBRADOR")
        oDtExportar.Columns.Remove("EST_CLIENTE")


        oDtExportar.Columns("TABTPD").SetOrdinal(0)
        oDtExportar.Columns("TABTPD").ColumnName = "TIPO"

        oDtExportar.Columns("NU_DOCU").SetOrdinal(1)
        oDtExportar.Columns("NU_DOCU").ColumnName = "NRO DOCUMENTO"

        oDtExportar.Columns("FE_CNTA_CNTE").SetOrdinal(2)
        oDtExportar.Columns("FE_CNTA_CNTE").ColumnName = "FECHA"

        oDtExportar.Columns("CO_DIVI").SetOrdinal(3)
        oDtExportar.Columns("CO_DIVI").ColumnName = "COD DIVISION"

        oDtExportar.Columns("CO_PLAN").SetOrdinal(4)
        oDtExportar.Columns("CO_PLAN").ColumnName = "COD PLANTA"

        oDtExportar.Columns("CO_ZONA").SetOrdinal(5)
        oDtExportar.Columns("CO_ZONA").ColumnName = "COD ZONA"

        oDtExportar.Columns("NO_ZONA").SetOrdinal(6)
        oDtExportar.Columns("NO_ZONA").ColumnName = "ZONA"

        oDtExportar.Columns("CO_CLIE").SetOrdinal(7)
        oDtExportar.Columns("CO_CLIE").ColumnName = "CODIGO"

        oDtExportar.Columns("NO_CLIE").SetOrdinal(8)
        oDtExportar.Columns("NO_CLIE").ColumnName = "CLIENTE"

        oDtExportar.Columns("NRUC").SetOrdinal(9)
        oDtExportar.Columns("NRUC").ColumnName = "RUC"

        oDtExportar.Columns("CO_SAPP").SetOrdinal(10)
        oDtExportar.Columns("CO_SAPP").ColumnName = "CODIGO SAP"

        oDtExportar.Columns("ST_DOCU").SetOrdinal(11)
        oDtExportar.Columns("ST_DOCU").ColumnName = "ABONO / PENDIENTE"

        oDtExportar.Columns("ST_REGI").SetOrdinal(12)
        oDtExportar.Columns("ST_REGI").ColumnName = "ESTADO"

        oDtExportar.Columns("SI_MONE").SetOrdinal(13)
        oDtExportar.Columns("SI_MONE").ColumnName = "MONEDA"

        oDtExportar.Columns("IVLIGS").SetOrdinal(14)
        oDtExportar.Columns("IVLIGS").ColumnName = "IGV SOLES"

        oDtExportar.Columns("IM_SOLE").SetOrdinal(15)
        oDtExportar.Columns("IM_SOLE").ColumnName = "IMPORTE SOLES"

        oDtExportar.Columns("IVLIGD").SetOrdinal(16)
        oDtExportar.Columns("IVLIGD").ColumnName = "IGV DOLARES"

        oDtExportar.Columns("IM_DOLA").SetOrdinal(17)
        oDtExportar.Columns("IM_DOLA").ColumnName = "IMPORTE DOLARES"



        oDtExportar.Columns("FDSGDC").SetOrdinal(18)
        oDtExportar.Columns("FDSGDC").ColumnName = "FECHA SEGUIMIENTO"

        oDtExportar.Columns("HDSGDC").SetOrdinal(19)
        oDtExportar.Columns("HDSGDC").ColumnName = "HORA SEGUIMIENTO"

        oDtExportar.Columns("ESTADO_ACTUAL").SetOrdinal(20)
        oDtExportar.Columns("ESTADO_ACTUAL").ColumnName = "ESTADO DOCUMENTO"

        oDtExportar.Columns("URSPDC").SetOrdinal(21)
        oDtExportar.Columns("URSPDC").ColumnName = "USUARIO RESPONSABLE"

        oDtExportar.Columns("TOBSSG").SetOrdinal(22)
        oDtExportar.Columns("TOBSSG").ColumnName = "OBSERVACION"





        oDtExportar.Columns("FEC_COBRANZA").SetOrdinal(23)
        oDtExportar.Columns("FEC_COBRANZA").ColumnName = "FECHA COBRANZA"

        oDtExportar.Columns("NRLENC").SetOrdinal(24)
        oDtExportar.Columns("NRLENC").ColumnName = "NRO ENTREGA COBRANZA"



        oDtExportar.Columns("FEC_COBRADOR").SetOrdinal(25)
        oDtExportar.Columns("FEC_COBRADOR").ColumnName = "FECHA COBRADOR"



        oDtExportar.Columns("FEC_CLIENTE").SetOrdinal(26)
        oDtExportar.Columns("FEC_CLIENTE").ColumnName = "FECHA CLIENTE"


        ds.Tables.Add(oDtExportar.Copy)


        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Listado de Clientes  \n ")

        strlTitulo.Add("  \n" & "")


        strlTitulo.Add("Compañia :\n" & UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion)
        strlTitulo.Add("División :\n" & UcDivision.DivisionDescripcion)
        'strlTitulo.Add("Planta :\n" & UcPLanta_Cmb01.DescripcionPlanta)
        strlTitulo.Add("Planta :\n" & Lista_DescPlanta())
        strlTitulo.Add("Tipo Doc :\n" & cmbTipoDocumento.Text)
        strlTitulo.Add("Nro Documento :\n" & txtNumDocumento.Text)
        'strlTitulo.Add("Región Venta :\n" & cmbRegionVenta2.Text)
        strlTitulo.Add("Región Venta :\n" & Lista_DescRegionVenta())
        strlTitulo.Add("Cliente :\n" & IIf(UcCliente.pCodigo = 0, "", UcCliente.pCodigo & " - " & UcCliente.pRazonSocial))
        strlTitulo.Add("Estado Doc :\n" & cmbEstadoFac.Text)


        If cbRango.Checked Then
            strlTitulo.Add("Fecha Ini :\n" & dtFechaInicio.Value.ToShortDateString)
            strlTitulo.Add("Fecha Fin :\n" & dtFechaFin.Value.ToShortDateString)
        End If

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(ds, strlTitulo)


    End Sub



    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        ExportarExcel()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If dtgCuentaCorriente.RowCount <= 0 Then Exit Sub

        If dtgCuentaCorriente.CurrentRow.Cells("NRLENC").Value > 0 Then
            Dim ofrm As New frmModificaEnvioDocumento

            ofrm.lblTipo.Text = dtgCuentaCorriente.CurrentRow.Cells("TABTPD").Value
            ofrm.lblCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("TCMPCL").Value
            ofrm.lblNumero.Text = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value
            ofrm.lblImporte.Text = Math.Round(dtgCuentaCorriente.CurrentRow.Cells("ITTFCS").Value, 2)
            ofrm.lblNroCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("NRLENC").Value
            ofrm.txtCobrador.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRADOR").Value
            ofrm.txtCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_CLIENTE").Value

            If ofrm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                'btnBuscar_Click(Nothing, Nothing)
                btnBusca_Click(Nothing, Nothing)
            End If

        Else
            MessageBox.Show("No se generado la cobranza para este documento", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    Private Sub btnGestionDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionDocumentos.Click
        Dim ofrm As New frmGestionDocumentos
        ofrm.beCuentaCorriente = filtroCC()
        If ofrm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            'btnBuscar_Click(Nothing, Nothing)
            btnBusca_Click(Nothing, Nothing)
        End If
    End Sub

    Private Function filtroCC() As SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim obeCuentaCorriente As New SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim tipoDocu As String = Lista_Tipo_Documentos()
        'Buscamos Rango de Fechas y Estado SAP
        If cbRango.Checked Then
            obeCuentaCorriente.FechaInicio = HelpClass.FormatoFechaAS400(Me.dtFechaInicio.Text)
            obeCuentaCorriente.FechaFin = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Text)
        Else
            obeCuentaCorriente.FechaInicio = "0"
            obeCuentaCorriente.FechaFin = "90000000"
        End If
        obeCuentaCorriente.EstadoSap = sSap
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            obeCuentaCorriente.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            obeCuentaCorriente.CCLNT = IIf(Me.UcCliente.pCodigo.ToString = "0", "-1", Me.UcCliente.pCodigo)
            If UcDivision.Division = "-1" Then
                obeCuentaCorriente.PSCDVSN = "%"
            Else
                obeCuentaCorriente.PSCDVSN = UcDivision.Division
            End If
            obeCuentaCorriente.PSEST_DOC = cmbEstadoFac.SelectedValue
            obeCuentaCorriente.PNCDSGDC = cmbSeguimiento.SelectedValue
            obeCuentaCorriente.CPLNDV = Lista_Planta() 'UcPLanta_Cmb01.Planta
            obeCuentaCorriente.CTPODC = tipoDocu
            'If Me.txtNumDocumento.Text.Trim = "" Or Me.txtNumDocumento.Text.Trim.Length = 0 Then
            '    obeCuentaCorriente.NDCCTC = "0"
            'Else
            '    obeCuentaCorriente.NDCCTC = txtNumDocumento.Text.Trim
            'End If
            obeCuentaCorriente.CRGVTA = Lista_RegionVenta() 'cmbRegionVenta2.SelectedValue
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
        Return obeCuentaCorriente
    End Function


    Private Sub dtgCuentaCorriente_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellDoubleClick
        Try

            If dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "imgSeg" Then
                Dim ofrm As New frmEstadoDocumento
                If dtgCuentaCorriente.CurrentRow.Cells("ESTADO_ACTUAL").Value Is DBNull.Value Then Exit Sub
                ofrm.PNNDCCTC = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value
                ofrm.lblTipo.Text = dtgCuentaCorriente.CurrentRow.Cells("TABTPD").Value
                ofrm.lblCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("TCMPCL").Value
                ofrm.lblNumero.Text = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value
                ofrm.lblImporte.Text = Math.Round(dtgCuentaCorriente.CurrentRow.Cells("ITTFCS").Value, 2)

                ofrm.lblFechaEmision.Text = dtgCuentaCorriente.CurrentRow.Cells("FDCCTC").Value
                'ofrm.lblEstadoCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_COBRANZA").Value
                ofrm.lblFechaCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRANZA").Value

                ofrm.lblNroCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("NRLENC").Value

                'ofrm.lblEstadoCobrador.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_COBRADOR").Value
                ofrm.lblFechaCobrador.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRADOR").Value

                'ofrm.lblEstadoCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_CLIENTE").Value
                ofrm.lblFechaCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_CLIENTE").Value

                ofrm.lblMoneda.Text = dtgCuentaCorriente.CurrentRow.Cells("TSGNMN").Value

                ofrm.ShowDialog()
            End If

            If dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "imgLINKFE" Then
                Dim NumeroFE = dtgCuentaCorriente.CurrentRow.Cells("NUMEROFE").Value.ToString.Trim
                Dim UrlsFE = dtgCuentaCorriente.CurrentRow.Cells("LINK_FE").Value.ToString.Trim
                'Dim startInfo As New ProcessStartInfo(UrlsFE)
                'startInfo.UseShellExecute = False
                'startInfo.WindowStyle = ProcessWindowStyle.Maximized
                Process.Start(UrlsFE)
            End If



            'If dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "imgCob" Then
            '    Dim ofrm As New frmListaControlDocumentos

            '    ofrm.lblTipo.Text = dtgCuentaCorriente.CurrentRow.Cells("TABTPD").Value
            '    ofrm.lblCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("TCMPCL").Value
            '    ofrm.lblNumero.Text = dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value
            '    ofrm.lblImporte.Text = Math.Round(dtgCuentaCorriente.CurrentRow.Cells("ITTFCS").Value, 2)

            '    ofrm.lblEstadoCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_COBRANZA").Value
            '    ofrm.lblFechaCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRANZA").Value

            '    ofrm.lblNroCobranza.Text = dtgCuentaCorriente.CurrentRow.Cells("NRLENC").Value

            '    ofrm.lblEstadoCobrador.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_COBRADOR").Value
            '    ofrm.lblFechaCobrador.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_COBRADOR").Value

            '    ofrm.lblEstadoCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("EST_CLIENTE").Value
            '    ofrm.lblFechaCliente.Text = dtgCuentaCorriente.CurrentRow.Cells("FEC_CLIENTE").Value
            '    ofrm.ShowDialog()

            'End If

            'If dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "imgLINKFE" Then
            '    Dim NumeroFE = dtgCuentaCorriente.CurrentRow.Cells("NUMEROFE").Value.ToString.Trim
            '    Dim UrlsFE = dtgCuentaCorriente.CurrentRow.Cells("LINK_FE").Value.ToString.Trim


            '    If (dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "51" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "52" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "53" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "57") AndAlso dtgCuentaCorriente.CurrentRow.Cells("NDCMSP").Value.ToString.Trim <> "Enviar al SAP" Then


            '        'If String.IsNullOrEmpty(NumeroFE) Or String.IsNullOrEmpty(UrlsFE) Then
            '        If String.IsNullOrEmpty(UrlsFE) Then

            '            'Exit Sub
            '            oCuentaCorriente.PSCCMPN = Me.dtgCuentaCorriente.CurrentRow.Cells("CCMPN").Value
            '            oCuentaCorriente.CTPODC = Me.dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value
            '            If Len(oCuentaCorriente.CTPODC) < 3 Then
            '                oCuentaCorriente.CTPODC = Replicar("0", 3 - Len(oCuentaCorriente.CTPODC)) & oCuentaCorriente.CTPODC
            '            End If
            '            oCuentaCorriente.NDCCTC = Me.dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value

            '            Dim question As Integer
            '            question = MessageBox.Show("Desea obtener URL Documento?", "Mensaje de Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)


            '            If question = 6 Then
            '                Try
            '                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            '                    If oCuentaCorriente.CTPODC = "051" Or oCuentaCorriente.CTPODC = "052" Or oCuentaCorriente.CTPODC = "053" Or oCuentaCorriente.CTPODC = "057" Then
            '                        Dim oFiltro As New Filtro
            '                        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

            '                        oFiltro.Parametro1 = oCuentaCorriente.PSCCMPN
            '                        oFiltro.Parametro2 = oCuentaCorriente.CTPODC
            '                        oFiltro.Parametro3 = oCuentaCorriente.NDCCTC.PadLeft(10, "0")
            '                        oFiltro.Parametro4 = Me.dtgCuentaCorriente.CurrentRow.Cells("CSCDSP").Value '.ToString.Trim.PadLeft(4, "0")
            '                        oFiltro.Parametro5 = Me.dtgCuentaCorriente.CurrentRow.Cells("NUMEROFE").Value


            '                        oFacturaNeg.Reenviar_Documento_SAP_FE(oFiltro)

            '                        'Else : oCuentaCorrienteNeg.Generar_SAP_CuentaCorriente(oCuentaCorriente)
            '                    End If

            '                    'KryptonHeaderGroup4.Enabled = True
            '                    bolPaginar = False
            '                    Limpiar_Paneles()
            '                    Buscar_CtaCte()
            '                    'MsgBox("Se ha generado un codigo SAP a este documento")
            '                    Me.Cursor = System.Windows.Forms.Cursors.Default
            '                Catch ex As Exception
            '                    Me.Cursor = System.Windows.Forms.Cursors.Default
            '                    HelpClass.MsgBox(ex.Message)
            '                End Try
            '            End If





            '        Else
            '            'Dim url As String = "http://www.paperless.com.pe/"
            '            'Dim url As String = dtgCuentaCorriente.CurrentRow.Cells("LINK_FE").Value.ToString.Trim
            '            Dim startInfo As New ProcessStartInfo(UrlsFE)
            '            startInfo.WindowStyle = ProcessWindowStyle.Maximized
            '            Process.Start(startInfo)
            '        End If


            '    End If


            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub dtgCuentaCorriente_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellMouseEnter

        'Dim markingUnderMouse As Bitmap = Nothing
        'Try
        '    markingUnderMouse = CType(dtgCuentaCorriente.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Bitmap)
        'Catch : End Try
        'If markingUnderMouse Is Nothing Then dtgCuentaCorriente.Cursor = Cursors.Default Else dtgCuentaCorriente.Cursor = Cursors.Hand
        Dim markingUnderMouse As Bitmap = Nothing
        Try
            markingUnderMouse = CType(dtgCuentaCorriente.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Bitmap)
        Catch : End Try
        If markingUnderMouse Is Nothing Then
            dtgCuentaCorriente.Cursor = Cursors.Default
        Else
            Dim NomColumna As String = dtgCuentaCorriente.Columns.Item(e.ColumnIndex).Name
            If NomColumna.Trim = "imgLINKFE" Then
                If dtgCuentaCorriente.Rows(e.RowIndex).Cells("NUMEROFE").Value.ToString.Trim = String.Empty Then
                    'If dtgCuentaCorriente.Rows(e.RowIndex).Cells("IVLIGS").Value > 100 Then    'Quitar
                    dtgCuentaCorriente.Cursor = Cursors.Default
                Else
                    dtgCuentaCorriente.Cursor = Cursors.Hand
                End If
            Else
                dtgCuentaCorriente.Cursor = Cursors.Hand
            End If
        End If
    End Sub

    Private Sub tsmReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmReporte.Click
        Try
            Dim ofrmRptEntregCobranza As New frmRptEntregCobranza
            ofrmRptEntregCobranza.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If cmbTipoDocumento.Text.Trim = "" Then
            HelpClass.MsgBox("Debe Seleccionar al Menos un Tipo Documento")
            Exit Sub
        End If
        bolPaginar = False
        Limpiar_Paneles()
        Buscar_CtaCte()

    End Sub

    Private Sub btnRptRegVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptRegVenta.Click
        Try
            ''Dim dlg As dlgCtaCte
            ''dlg = New dlgCtaCte
            Dim dlg As dlgCtaCte
            dlg = New dlgCtaCte
            'dlg.txtCompania.Text = UcCompania.CCMPN_Descripcion
            'dlg.txtDivision.Text = UcDivision.DivisionDescripcion
            'dlg.txtPlanta.Text = Lista_DescPlanta()
            'dlg.txtCodCompania.Text = UcCompania.CCMPN_CodigoCompania
            'dlg.txtCodDivision.Text = IIf(UcDivision.Division = "-1", "*", UcDivision.Division)
            'dlg.txtCodPlanta.Text = Lista_Planta()
            'dlg.dtFechaInicio.Text = dtFechaInicio.Text
            'dlg.dtFechaFin.Text = dtFechaFin.Text
            'Dim cliente_TK As New Ransa.TypeDef.Cliente.TD_ClientePK
            'cliente_TK.pCCLNT_Cliente = UcCliente.pCodigo
            'dlg.ucCliente.pCargar(cliente_TK)
            'dlg.txtCodRegionVenta.Text = Lista_RegionVenta()
            'dlg.txtRegionVenta.Text = Lista_DescRegionVenta()
            'dlg.ShowInTaskbar = False
            'dlg.StartPosition = FormStartPosition.CenterParent
            dlg.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnRptServCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptServCliente.Click
        Try
            Dim oFrmRepVenta As New FrmRepVenta
            oFrmRepVenta.TipoRep = FrmRepVenta.TipoReporte.ServicioCliente
            oFrmRepVenta.Text = "Por Servicio/Cliente"
            oFrmRepVenta.ShowDialog()
            ' ''--------------------------------------------------------
            'Dim obj_Logica As New clsCuentaCorriente
            'Dim objPrintForm As New PrintForm
            'Dim objDs As New DataSet
            'Dim objetoRep As New rptFacturasSOLMIN
            'Dim ListaParametros As New List(Of String)
            ' ''--------------------------------------------------------

            'Dim oCtaCte As New CuentaCorriente
            'Dim oDtb As New DataTable
            'Dim oDtResLote As New DataTable

            'oCtaCte.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            ''oCtaCte.FechaInicio = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            ''oCtaCte.FechaFin = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
            'oCtaCte.FechaInicio = CType(dtFechaInicio.Text, DateTime).ToString("yyyyMMdd")
            'oCtaCte.FechaFin = CType(dtFechaFin.Text, DateTimeOffset).ToString("yyyyMMdd")

            'objDs = obj_Logica.Listar_FacturadoSOLMIN(oCtaCte)

            'If objDs.Tables.Count = 0 Then Exit Sub
            'objDs.Tables(0).TableName = "RZCT01_SOLMIN"
            'HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", UcCompania.CCMPN_Descripcion)
            ''HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", cmbDivision.Text)
            ''HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", cmbPlanta.Text)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblInicio", dtFechaInicio.Text)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblFin", dtFechaFin.Text)
            'objetoRep.SetDataSource(objDs)
            ''objPrintForm.StartPosition = FormStartPosition.CenterScreen
            'objPrintForm.ShowForm(objetoRep, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnRptModFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptModFact.Click
        Try
            Dim oFrmRepVenta As New FrmRepVenta
            oFrmRepVenta.Text = "Por Módulo Facturación"
            oFrmRepVenta.TipoRep = FrmRepVenta.TipoReporte.ModuloFacturacion
            oFrmRepVenta.ShowDialog()
            ''--------------------------------------------------------
            'Dim obj_Logica As New clsCuentaCorriente
            'Dim objPrintForm As New PrintForm
            'Dim objDs As New DataSet
            'Dim objetoRep As New rptFacturaCompara
            'Dim ListaParametros As New List(Of String)
            ' ''--------------------------------------------------------

            'Dim oCtaCte As New CuentaCorriente
            'Dim oDtb As New DataTable
            'Dim oDtResLote As New DataTable

            'oCtaCte.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            'oCtaCte.FechaInicio = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
            'oCtaCte.FechaFin = HelpClass.FormatoFechaAS400(dtFechaFin.Text)

            'objDs = obj_Logica.Listar_Compara_Servicio(oCtaCte)

            'If objDs.Tables.Count = 0 Then Exit Sub
            'objDs.Tables(0).TableName = "RZCT01_CMP"
            'HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", UcCompania.CCMPN_Descripcion)
            ''HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", cmbDivision.Text)
            ''HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", cmbPlanta.Text)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblInicio", dtFechaInicio.Text)
            'HelpClass.CrystalReportTextObject(objetoRep, "lblFin", dtFechaFin.Text)
            'objetoRep.SetDataSource(objDs)

            'objPrintForm.StartPosition = FormStartPosition.CenterScreen
            'objPrintForm.WindowState = FormWindowState.Maximized
            'objPrintForm.ShowForm(objetoRep, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgCuentaCorriente_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dtgCuentaCorriente.RowsAdded


        For i As Integer = 0 To dtgCuentaCorriente.Rows.Count - 1



            If dtgCuentaCorriente.Rows(i).Cells("ESTADOPAPERLSS").Value.ToString.Trim <> "0" And dtgCuentaCorriente.Rows(i).Cells("ESTADOPAPERLSS").Value.ToString.Trim <> "" Then

                If (dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "51" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "52" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "53" OrElse dtgCuentaCorriente.Rows(i).Cells("CTPODC").Value.ToString.Trim = "57") Then

                    dtgCuentaCorriente.Rows(i).Cells("ESTADOPAPERLSS").Value = Mensaje_PPL
                    dtgCuentaCorriente.Rows(i).Cells("ESTADOPAPERLSS").Style.ForeColor = Color.Blue
                End If


            End If
        Next

    End Sub

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private Sub btnGestionPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPT.Click
        Try
            If dtgCuentaCorriente.RowCount > 0 Then
                If CInt(dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value) <> 6 Then
                    MessageBox.Show("El documento selecionado no es un parte de transferencia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                With frmGestionPT
                    .TipoDoc = Trim(dtgCuentaCorriente.CurrentRow.Cells("TABTPD").Value)
                    .NumeroDoc = Trim(dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value)
                    .Ccmpn = UcCompania.CCMPN_CodigoCompania
                    .Ctpodc = Trim(dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value)
                    .Ndcctc = Trim(dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value)
                    .ShowDialog()
                    .Dispose()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSunatPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSunatPP.Click

        Dim NumeroFE = dtgCuentaCorriente.CurrentRow.Cells("NUMEROFE").Value.ToString.Trim
        Dim UrlsFE = dtgCuentaCorriente.CurrentRow.Cells("LINK_FE").Value.ToString.Trim


        If (dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "51" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "52" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "53" OrElse dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value.ToString.Trim = "57") AndAlso dtgCuentaCorriente.CurrentRow.Cells("NDCMSP").Value.ToString.Trim <> "Enviar al SAP" Then



            'If String.IsNullOrEmpty(UrlsFE) Then ''INTEGRACION-041116-RANSASELVA


            oCuentaCorriente.PSCCMPN = Me.dtgCuentaCorriente.CurrentRow.Cells("CCMPN").Value
            oCuentaCorriente.CTPODC = Me.dtgCuentaCorriente.CurrentRow.Cells("CTPODC").Value
            If Len(oCuentaCorriente.CTPODC) < 3 Then
                oCuentaCorriente.CTPODC = Replicar("0", 3 - Len(oCuentaCorriente.CTPODC)) & oCuentaCorriente.CTPODC
            End If
            oCuentaCorriente.NDCCTC = Me.dtgCuentaCorriente.CurrentRow.Cells("NDCCTC").Value

            Dim question As Integer
            question = MessageBox.Show("Desea obtener URL Documento?", "Mensaje de Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)


            If question = 6 Then
                Try
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If oCuentaCorriente.CTPODC = "051" Or oCuentaCorriente.CTPODC = "052" Or oCuentaCorriente.CTPODC = "053" Or oCuentaCorriente.CTPODC = "057" Then
                        Dim oFiltro As New Filtro
                        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

                        oFiltro.Parametro1 = oCuentaCorriente.PSCCMPN
                        oFiltro.Parametro2 = oCuentaCorriente.CTPODC
                        oFiltro.Parametro3 = oCuentaCorriente.NDCCTC.PadLeft(10, "0")
                        oFiltro.Parametro4 = Me.dtgCuentaCorriente.CurrentRow.Cells("CSCDSP").Value
                        oFiltro.Parametro5 = Me.dtgCuentaCorriente.CurrentRow.Cells("NUMEROFE").Value


                        oFacturaNeg.Reenviar_Documento_SAP_FE(oFiltro)


                    End If


                    bolPaginar = False
                    Limpiar_Paneles()
                    Buscar_CtaCte()

                    Me.Cursor = System.Windows.Forms.Cursors.Default
                Catch ex As Exception
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpClass.MsgBox(ex.Message)
                End Try
            End If





            ''INTEGRACION-041116-RANSASELVA
            'Else

            '    Dim startInfo As New ProcessStartInfo(UrlsFE)
            '    startInfo.WindowStyle = ProcessWindowStyle.Maximized
            '    '    Process.Start(startInfo)
            'End If
            ''INTEGRACION-041116-RANSASELVA


        End If
    End Sub
End Class


