Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class frmConsistenciaFac
    Private oServicio As SOLMIN_CTZ.NEGOCIO.clsServicio = New SOLMIN_CTZ.NEGOCIO.clsServicio
    Dim strNrOperacion_ As Decimal = 0
    Private Sub frmConsistenciaFac_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtFechaInicio.Value = Now.AddDays(1 - CInt(Today.Day.ToString))
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Cargar_Region_Venta()
        CargarTipoServicio()
        CargarServicio()



    End Sub

#Region "Carga de Controles"


    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Dim obrPlanta As New clsPlanta
        Dim oDtPlanta As DataTable
        obrPlanta.Crea_Lista()
        oDtPlanta = obrPlanta.Lista_Planta_Division(obeDivision.CCMPN_CodigoCompania, obeDivision.CDVSN_CodigoDivision)
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
        CargarTipoServicio()
        CargarServicio()

    End Sub

    Private Sub Cargar_Region_Venta()

        Dim obrRegionVenta As New clsRegionVenta
        obrRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As New DataTable
        oDtRegionVenta = obrRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
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


    Private Function Lista_Planta() As String
        Dim strPlantas As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            If (cmbPlanta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To Me.cmbPlanta.DataSource.Rows.Count - 1
                    If (Me.cmbPlanta.DataSource.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                        strPlantas += Me.cmbPlanta.DataSource.Rows(j).Item("CPLNDV") & ","
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


    Private Function strListaPlantaDes() As String
        Dim strPlantas As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            If (cmbPlanta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To Me.cmbPlanta.DataSource.Rows.Count - 1
                    If (Me.cmbPlanta.DataSource.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                        strPlantas += Me.cmbPlanta.DataSource.Rows(j).Item("TPLNTA") & ","
                    End If
                Next
            Else
                strPlantas = "TODOS"
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        Else
            strPlantas = "TODOS"
        End If


        Return strPlantas
    End Function


    Private Function Lista_RegionVenta() As String
        Dim strRegionVenta As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If (cmbRegionVenta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To Me.cmbRegionVenta.DataSource.Rows.Count - 1
                    If (cmbRegionVenta.DataSource.Rows(j).Item("CRGVTA") = cmbRegionVenta.CheckedItems(i).Value) Then
                        strRegionVenta += cmbRegionVenta.DataSource.Rows(j).Item("CRGVTA") & ","
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


    Private Function strListaRegionVentaDes() As String
        Dim strRegionVenta As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If (cmbRegionVenta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To Me.cmbRegionVenta.DataSource.Rows.Count - 1
                    If (cmbRegionVenta.DataSource.Rows(j).Item("CRGVTA") = cmbRegionVenta.CheckedItems(i).Value) Then
                        strRegionVenta += cmbRegionVenta.DataSource.Rows(j).Item("TCRVTA") & ","
                    End If
                Next
            Else
                strRegionVenta = "TODOS"
                Exit For
            End If
        Next
        If strRegionVenta.Trim.Length > 0 Then
            strRegionVenta = strRegionVenta.Trim.Substring(0, strRegionVenta.Trim.Length - 1)
        Else
            strRegionVenta = "TODOS"
        End If

        Return strRegionVenta
    End Function


#End Region


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            Dim obrOperaciones As New clsServicioOperacion
            'Dim olServOperaciones As New List(Of ServicioOperacion)
            'olServOperaciones = Nothing
            Dim obeServOperacion As New ServicioOperacion
            With obeServOperacion
                .CCMPN = UcCompania.CCMPN_CodigoCompania
                .CDVSN = UcDivision.Division
                .CPLNDV_STR = Lista_Planta()
                .CRGVTA = Lista_RegionVenta()
                .CCLNT = UcCliente.pCodigo
                .FATNSR_D = HelpClass.CtypeDate(dtFechaInicio.Value)
                .FATNSR_A = HelpClass.CtypeDate(Me.dtFechaFin.Value)
                .NRRUBR = cboRubro.SelectedValue
                .NRSRRB = cboRubroServicio.SelectedValue
            End With
            dtgCuentaCorriente.AutoGenerateColumns = False
            Me.dtgCuentaCorriente.DataSource = obrOperaciones.fdtLista_Consistencia_Facturacion_Tarifia_Fija(obeServOperacion)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        If dtgCuentaCorriente.Rows.Count = 0 Then Exit Sub
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Compañia :\n" & UcCompania.CCMPN_CodigoCompania & " - " & UcCompania.CCMPN_Descripcion)
        strlTitulo.Add("División :\n" & UcDivision.DivisionDescripcion)
        strlTitulo.Add("Planta(s) :\n" & strListaPlantaDes())
        strlTitulo.Add("Cliente :\n" & IIf(UcCliente.pCodigo = 0, "TODOS", UcCliente.pRazonSocial))
        strlTitulo.Add("Región Venta :\n" & strListaRegionVentaDes())
        strlTitulo.Add("Fecha de Servicio :\n" & Me.dtFechaInicio.Value.Date & " - " & dtFechaFin.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(Me.dtgCuentaCorriente, "", strlTitulo)
    End Sub

    Private Sub tbnGenerarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnGenerarOperacion.Click
        'Me.dtgCuentaCorriente.EndEdit()
        Guardar()
    End Sub

    Private Sub dtgCuentaCorriente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellClick
        Try
            If Me.dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "CHK" Then
                If dtgCuentaCorriente.CurrentRow.DataBoundItem.Item("TABTPD").ToString.Equals("S") OrElse Not dtgCuentaCorriente.CurrentRow.DataBoundItem.Item("NOPRCN").ToString.Equals("0") Then
                    dtgCuentaCorriente.CurrentRow.Cells("CHK").Value = False
                    Me.dtgCuentaCorriente.EndEdit()
                End If
            End If
        Catch : End Try

    End Sub

    Private Sub Guardar()

        dtgCuentaCorriente.CommitEdit(DataGridViewDataErrorContexts.Commit)

        Dim intError As Integer = -1
        Dim dblCodigo As Decimal = 0
        Try

            For intCont As Integer = 0 To dtgCuentaCorriente.Rows.Count - 1
                If Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CHK") Is DBNull.Value OrElse Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CHK") = False Then Continue For
                Dim tipoTarifa As String = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("STPTRA")

                ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
                Dim strNrOperacion As String = ""
                Dim oServicioBL As New Ransa.Controls.ServicioOperacion.clsServicio_BL
                Dim _oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
                'Inserta o Actualiza la operacion
                With _oServicio
                    .CCMPN = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCMPN")
                    .CDVSN = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CDVSN")
                    .CPLNDV = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CPLNDV")
                    .CCLNT = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                    .CCLNFC = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                    .FOPRCN = HelpClass.CtypeDate(Now.Date)
                    .CCLNFC = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                    .CPLNDV = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CPLNDV")
                    '.STIPPR = "O"
                    '.CTPALJ = "GE"
                    _oServicio.SESTRG = "A"
                    .STPODP = 0
                    .PSUSUARIO = ConfigurationWizard.UserName
                    '.NOPRCN = oServicioBL.fdecInsertarOperacionFacturacionSA(_oServicio)
                    'If .NOPRCN = 0 Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit For
                    'End If

                    ' End With
                    '-----------------------------------------------------
                    Dim TarifaReferencial As Double = 0
                    TarifaReferencial = CType("0" & Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CDTREF").ToString.Trim, Double)
                    'INICIO
                    If tipoTarifa.Equals("F") And TarifaReferencial > 0 Then
                        .CTPALM = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CTPALM").ToString 'cod tipo almacen
                        .TTPOMR = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCMPRN").ToString.Trim ' cod tipo material
                        .NRTFSV = CType("0" & Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("NRTFSV").ToString.Trim, Double) 'cod Tarifa
                        .CDTREF = TarifaReferencial  'cod Tarifa Referencial

                        .NDIAPL = CType("0" & Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("NDIAPL").ToString.Trim, Int32) 'Dias a facturar
                        If ProcesoCalculoFacturcion(_oServicio) = 1 Then
                            _oServicio.NOPRCN = strNrOperacion_
                        Else
                            Exit For
                        End If

                    Else 'CASO CONTRARIO
                        With _oServicio
                            .CCLNT = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                            .CCLNFC = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                            .FOPRCN = HelpClass.CtypeDate(Now.Date)
                            .CPLNDV = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CPLNDV")
                            .STIPPR = "O"
                            .TRDCCL = ""
                            .CTPALJ = "GE"
                            .STPODP = 7
                            .NOPRCN = oServicioBL.fdecInsertarOperacionFacturacionSA(_oServicio)
                        End With

                        '=================================
                        'Inserta o Actualiza los Servicios
                        If tipoTarifa <> "D" Then
                            With _oServicio
                                .CCLNT = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                                .NRTFSV = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("NRTFSV")
                                '.NCRROP = Val("" & Me.dgServicio.Rows(intCont).Cells("NCRROP").Value & "")
                                .QATNAN = 1
                                .QATNRL = 1
                                .STIPPR = "O"
                                .NORCML = "" 'OC
                                .CCNTCS = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCNTCS")  'OC
                                .TCTCST = "" 'CI
                                .TSRVC = "AUTOMATICO" 'OBSERVACION
                                .FATNSR = HelpClass.CtypeDate(Now.Date) 'Comun.FormatoFechaAS400(Me.dgServicio.Rows(intCont).Cells("FATNSR").Value.ToString.Replace(" ", "")) 'Fecha del Servicio
                                'If Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value = "0" Then  'Lote
                                '    .TLUGEN = ""
                                'Else
                                .TLUGEN = "" 'Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value
                                'End If
                                .TIPO = "N"
                                .STIPPR = "7"
                                .CTPALJ = "GE"

                                Dim msgserv As String = ""
                                Dim corr_servicio As Decimal = 0

                                msgserv = oServicioBL.fdecInsertarServiciosFacturacionSA(_oServicio, corr_servicio)
                                .NCRROP = corr_servicio
                                '.NCRROP = oServicioBL.fdecInsertarServiciosFacturacionSA(_oServicio)
                                If .NCRROP = 0 Then
                                    'HelpClass.ErrorMsgBox()
                                    MessageBox.Show(msgserv, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit For
                                End If
                            End With

                        End If

                    End If 'FIN                                                  
                    '--------------------------------------------
                End With

                '=================================
                'Inserta o Actualiza los Servicios

                'For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1


                'If tipoTarifa <> "D" Then
                '    With _oServicio
                '        .CCLNT = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCLNT")
                '        .NRTFSV = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("NRTFSV")
                '        '.NCRROP = Val("" & Me.dgServicio.Rows(intCont).Cells("NCRROP").Value & "")
                '        .QATNAN = 1
                '        .QATNRL = 1
                '        .STIPPR = "O"
                '        .NORCML = "" 'OC
                '        .CCNTCS = Me.dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("CCNTCS")  'OC
                '        .TCTCST = "" 'CI
                '        .TSRVC = "AUTOMATICO" 'OBSERVACION
                '        .FATNSR = HelpClass.CtypeDate(Now.Date) 'Comun.FormatoFechaAS400(Me.dgServicio.Rows(intCont).Cells("FATNSR").Value.ToString.Replace(" ", "")) 'Fecha del Servicio
                '        'If Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value = "0" Then  'Lote
                '        '    .TLUGEN = ""
                '        'Else
                '        .TLUGEN = "" 'Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value
                '        'End If
                '        .TIPO = "N"
                '        .STIPPR = "7"
                '        .CTPALJ = "GE"
                '        .NCRROP = oServicioBL.fdecInsertarServiciosFacturacionSA(_oServicio)
                '        If .NCRROP = 0 Then
                '            HelpClass.ErrorMsgBox()
                '            Exit For
                '        End If
                '    End With



                'End If
                _oServicio.NSECFC = oServicioBL.ObtenerCodigoConsistencia.Rows(0).Item("NULCTR")

                If oServicioBL.ActualizarServicio_Atendido(_oServicio) = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit For
                End If
                intError = 0
            Next
            'Next
            If intError = 0 Then
                btnBuscar_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub



    Public Function ProcesoCalculoFacturcion(ByVal _oServicio As Ransa.Controls.ServicioOperacion.Servicio_BE) As Integer
        Dim TituloAdicion As String = ""
        Dim strPLanta As String = ""
        'Dim lstrPLanta As String()
        Dim oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
        With oServicio
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = _oServicio.CPLNDV
            .NOPRCN = 0
            .CCLNFC = _oServicio.CCLNFC
            .CCLNT = _oServicio.CCLNT
            .NRTFSV = _oServicio.NRTFSV '0
            .QATNAN = _oServicio.QATNAN '0
            .TIPO = _oServicio.TIPO 'NUEVO
            .FOPRCN = 0
            .FECINI = 0
            .FECFIN = 0
            '.STPODP = 0 ' pTipoAlmacen NoAplica = 0
            .PSUSUARIO = ConfigurationWizard.UserName
            .CTPALM = _oServicio.CTPALM
            .TTPOMR = _oServicio.TTPOMR
            .NRTFSV = _oServicio.NRTFSV
            .NDIAPL = _oServicio.NDIAPL
            .CDTREF = _oServicio.CDTREF
        End With
        'if cmbdivision.selectedvalue = "r" then
        If _oServicio.CCLNT = 0 Then
            MsgBox("ingrese un cliente operación", MsgBoxStyle.Information, "información")
            Me.Cursor = Cursors.Default
            Exit Function
        End If
        Select Case oServicio.CDVSN
            Case "R"
                oServicio.STPODP = 7 ' 
                oServicio.CTPALJ = "PE"  'SERVICIO ALMACENAJE POR PERMANENCIA

                TituloAdicion = "SERVICIO GENERAL - " '& Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
            Case "S"
                'oServicio.STPODP = cmbTipoAlmacenaje.SelectedValue
                oServicio.CTPALJ = "MA"
                'oServicio.NORSCI = 9422
                TituloAdicion = "SERVICIO MANUAL - " '& Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")

            Case "T"
                'oServicio.STPODP = cmbTipoAlmacenaje.SelectedValue
                oServicio.CTPALJ = "MA"
                'oServicio.NORSCI = 9422
                TituloAdicion = "SERVICIO MANUAL - " '& Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")
        End Select

        Dim frm As New Ransa.Controls.ServicioOperacion.UcFrmServicioAgregarSA_DS
        frm.ConsistenciaFac = True
        frm.oServicio = oServicio
        'frm.Text = "SERVICIO GENERAL - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
        frm.Text = TituloAdicion
        '<[AHM]>
        frm.pCodigoCompania = UcCompania.CCMPN_CodigoCompania
        '</[AHM]>
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            strNrOperacion_ = frm.strNrOperacion_
            If strNrOperacion_ <> 0 Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function





    Private Sub dtgCuentaCorriente_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgCuentaCorriente.DataBindingComplete
        For intCont As Integer = 0 To Me.dtgCuentaCorriente.Rows.Count - 1
            If dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("TABTPD").ToString.Equals("S") OrElse Not dtgCuentaCorriente.Rows(intCont).DataBoundItem.Item("NOPRCN").ToString.Equals("0") Then
                dtgCuentaCorriente.Rows(intCont).Cells("CHK").ReadOnly = True
            End If
        Next
        Me.dtgCuentaCorriente.EndEdit()
    End Sub

    Private Sub dtgCuentaCorriente_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellDoubleClick
        If Me.dtgCuentaCorriente.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dtgCuentaCorriente.Columns(e.ColumnIndex).Name = "Operaciones" Then
            Dim ofrmListaOperacionPeriodo As New frmListaOperacionPeriodo
            Dim oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
            With oServicio
                .CCLNT = Me.dtgCuentaCorriente.CurrentRow.DataBoundItem.item("CCLNT")
                .CCMPN = Me.dtgCuentaCorriente.CurrentRow.DataBoundItem.item("CCMPN")
                .CDVSN = Me.dtgCuentaCorriente.CurrentRow.DataBoundItem.item("CDVSN")
                .TIPO_PLANTA = Me.dtgCuentaCorriente.CurrentRow.DataBoundItem.item("CPLNDV")
                .FechaInicio = dtFechaInicio.Value
                .FechaFin = dtFechaFin.Value
                .FECSERV_INI = HelpClass.FormatoFechaAS400(dtFechaInicio.Value.Date)
                .FECSERV_FIN = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Value.Date)
            End With
            ofrmListaOperacionPeriodo.oServicio = oServicio
            ofrmListaOperacionPeriodo.ShowDialog()
        End If


    End Sub


    Private Sub CargarTipoServicio()


        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oDtAux As New DataTable
        Dim oDr As DataRow
        Dim oDTabla As New DataTable
        oDtAux.Columns.Add("NRRUBR", GetType(String))
        oDtAux.Columns.Add("NOMRUB", GetType(String))
        Dim oDtSer As New DataTable

        If UcDivision.Division.ToString.Trim = "-1" Then
            oDTabla = Nothing
        Else
            oFiltro.Parametro1 = UcCompania.CCMPN_CodigoCompania
            oFiltro.Parametro2 = UcDivision.Division
            oDTabla = oServicio.Lista_Servicio_X_Compania_Division_X_Rubro(oFiltro)
        End If

        oDr = oDtAux.NewRow
        oDr("NOMRUB") = "TODOS"
        oDr("NRRUBR") = "0"
        oDtAux.Rows.Add(oDr)

        If oDTabla IsNot Nothing Then
            For Each dr As DataRow In oDTabla.Rows
                oDr = oDtAux.NewRow
                oDr("NRRUBR") = dr("NRRUBR")
                oDr("NOMRUB") = dr("NOMRUB")
                oDtAux.Rows.Add(oDr)
            Next
        End If
        oDTabla = oDtAux

        cboRubro.ValueMember = "NRRUBR"
        cboRubro.DisplayMember = "NOMRUB"
        cboRubro.DataSource = oDTabla
        cboRubro.StateCommon.Back.Color1 = Nothing
    End Sub
    Private Sub CargarServicio()
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oDtAux As New DataTable
        Dim oDr As DataRow
        Dim oDTabla As New DataTable
        oDtAux.Columns.Add("NRSRRB", GetType(String))
        oDtAux.Columns.Add("NOMSER", GetType(String))
        Dim oDtSer As New DataTable

        If cboRubro.SelectedValue.ToString.Trim = "0" Then
            oDTabla = Nothing
        Else
            oFiltro.Parametro1 = UcCompania.CCMPN_CodigoCompania
            oFiltro.Parametro2 = UcDivision.Division
            oFiltro.Parametro3 = cboRubro.SelectedValue
            oDTabla = oServicio.Lista_Servicio_X_Compania_Division_X_Rubro_Servicio(oFiltro)
        End If

        oDr = oDtAux.NewRow
        oDr("NOMSER") = "TODOS"
        oDr("NRSRRB") = "0"
        oDtAux.Rows.Add(oDr)

        If oDTabla IsNot Nothing Then
            For Each dr As DataRow In oDTabla.Rows
                oDr = oDtAux.NewRow
                oDr("NRSRRB") = dr("NRSRRB")
                oDr("NOMSER") = dr("NOMSER")
                oDtAux.Rows.Add(oDr)
            Next
        End If

        oDTabla = oDtAux

        cboRubroServicio.ValueMember = "NRSRRB"
        cboRubroServicio.DisplayMember = "NOMSER"
        cboRubroServicio.DataSource = oDTabla
        cboRubroServicio.StateCommon.Back.Color1 = Nothing
    End Sub

    Private Sub cboRubro_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRubro.SelectionChangeCommitted
        CargarServicio()
    End Sub
End Class


