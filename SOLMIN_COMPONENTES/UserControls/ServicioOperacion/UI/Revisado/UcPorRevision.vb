Imports Ransa.Utilitario

Public Class UcPorRevision

#Region "Declaracion de Variables"
    Private Estatico As New Estaticos
    Public Event Listar_Revisiones(ByVal oServicioBE As Servicio_BE)
    Public Event Listar_Operaciones(ByVal ServicioBE As Servicio_BE, ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Public Event Facturar(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    Public Event Boleta(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
   
    Public Event FacturarElectrinica(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista)
    'Public Event BoletaElectronica(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    'Public Event ParteTransferencia(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)

    Public Event Procesar_Consistencias(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Public Event Anular_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Private tipo_cambio As Double = 0D
    Private valor_igv As Double = 0D
    Private oServicioOpeNeg As New clsServicio_BL
    Private Marcar As Image
    Private Desmarcar As Image
    Public _pTipoAlmacen As String
    Private _oServicio As Servicio_BE
    Public sTotalDatosPorRevision As String
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property
#End Region

#Region "Eventos de Control"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub dtgFacturacion_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFacturacion.CurrentCellChanged
    '    Try
    '        If dtgFacturacion.Rows.Count = 0 Then Exit Sub
    '        RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            dtgFacturacion.Columns("chk").ReadOnly = True
            If dtgFacturacion.RowCount > 0 Then
                If Existe_Check() Then
                    Poner_Check_Todo_OC(False)
                    btnMarcarItems.Image = Desmarcar
                Else
                    'If Not (oServicio.FLGFAC = "S" OrElse oServicio.FLGFAC = "0") Then
                    Poner_Check_Todo_OC(True)
                    btnMarcarItems.Image = Marcar
                    'End If
                End If
            End If

            dtgFacturacion.Columns("chk").ReadOnly = False
            Me.dtgFacturacion.EndEdit()


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub btnRevisado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisado.Click
    '    Try
    '        If dtgFacturacion.RowCount = 0 Then Exit Sub
    '        RaiseEvent Procesar_Consistencias(dtgFacturacion)
    '        LimpiarDetalleRevision()
    '        Refrescar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnQuitaConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaConsistencia.Click
        Try
            If dtgFacturacion.Rows.Count = 0 Then Exit Sub

            If MsgBox("Seguro que desea eliminar la Consistencia ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
                RaiseEvent Anular_Revision(dtgFacturacion)
            Else
                Exit Sub
            End If
            LimpiarDetalleRevision()
            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.dtgFacturacion.CurrentCellAddress.Y = -1 Then Exit Sub
    '    Dim oServ As New Servicio_BE

    '    oServ = oServicio

    '    Dim frm As New UcFrmConsistencia(oServ)
    '    frm.TipoAlmacen = _pTipoAlmacen
    '    frm.Revision = Val(dtgFacturacion.CurrentRow.Cells("NSECFC1").Value)

    '    If Val(dtgFacturacion.CurrentRow.Cells("NSECFC1").Value) > 0 And (oServ.CTPALJ = "0" Or oServ.CTPALJ = "") Then
    '        oServ.CTPALJ = dtgOperaciones.CurrentRow.Cells("CTPALJ").Value
    '    End If
    '    oServ.CPLNDV = dtgFacturacion.CurrentRow.Cells("CPLNDV1").Value
    '    frm.ShowDialog()
    'End Sub

    Private Sub dtgFacturacion_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgFacturacion.DataBindingComplete
        Try
            Dim sumaDolares As Double = 0D
            Dim sumaSoles As Double = 0D
            Dim cambio As Double = CType(IIf(lblTipoCambio_1.Text = "0", "0", Val(lblTipoCambio_1.Text)), Decimal)
            Dim montoTemp As Double = 0D
            For i As Integer = 0 To dtgFacturacion.Rows.Count - 1
                If Me.dtgFacturacion.Rows(i).Cells("CMNDA1").Value() = 100 Then
                    montoTemp = IIf(IsDBNull(Me.dtgFacturacion.Rows(i).Cells("TOTAL1").Value()), 0, Me.dtgFacturacion.Rows(i).Cells("TOTAL1").Value())
                    sumaDolares = sumaDolares + montoTemp
                    If cambio <> 0 Then
                        sumaSoles = sumaSoles + (Me.dtgFacturacion.Rows(i).Cells("TOTAL1").Value() * cambio)
                    End If
                Else
                    If cambio <> 0 Then
                        sumaDolares = sumaDolares + (Me.dtgFacturacion.Rows(i).Cells("TOTAL1").Value() / cambio)
                    End If
                    sumaSoles = sumaSoles + Me.dtgFacturacion.Rows(i).Cells("TOTAL1").Value()
                End If

            Next

            sTotalDatosPorRevision = "Monto a Cobrar : S/. " & Format(sumaSoles, "###,###,###,###.00") & " / - - / Monto a Cobrar : USD " & Format(sumaDolares, "###,###,###,###.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgOperaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellDoubleClick
        Try
            If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If dtgOperaciones.Columns(e.ColumnIndex).Name = "Det" Then
                Dim oFrmServicios As New frmListaServicios

                oFrmServicios.ServicioBE = oServicio
                oFrmServicios.ServicioBE.CTPALJ = Me.dtgOperaciones.CurrentRow.Cells("CTPALJ").Value
                oFrmServicios.ServicioBE.NOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN_D").Value
                oFrmServicios.ServicioBE.STPODP = Me.dtgOperaciones.CurrentRow.Cells("STPODP2").Value
                oFrmServicios.ServicioBE.CPLNDV = Me.dtgOperaciones.CurrentRow.Cells("CPLNDV").Value
                oFrmServicios.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete

        For i As Integer = 0 To dtgOperaciones.Rows.Count - 1

            'DESCRIPCION TIPO ALMACENAJE
            Select Case Me.dtgOperaciones.Rows(i).Cells("CTPALJ").Value.ToString.Trim
                Case Estatico.E_ESP_Manual '"MA"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANUAL"
                Case Estatico.E_ESP_Adicional '"AD"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ADICIONAL"
                Case Estatico.E_ESP_General, "" '"GE"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "GENERAL"
                Case Estatico.E_ESP_Reembolso
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "REEMBOLSO"
                Case Estatico.E_ESP_Almacenaje '"AL"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE"
                Case Estatico.E_ESP_AlmacenajePeso 'AP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR FECHA DE CORTE"
                Case Estatico.E_ESP_ManipuleoPeso 'MP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANIPULEO POR FECHA DE CORTE"
                Case Estatico.E_ESP_PesoPromedio 'PP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PESO PROMEDIOS"
                Case Estatico.E_ESP_Permanencia 'PE
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PERMANENCIA"

            End Select

        Next

    End Sub

    Private Sub btntrasladar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrasladar.Click
        Try
            Dim ofrmTrasladar As New frmTrasladarOperacion
            Dim bolSel As Boolean = False
            dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)



            For i As Integer = 0 To dtgOperaciones.RowCount - 1
                If dtgOperaciones.Rows(i).Cells("chk2").Value = True Then
                    bolSel = True
                    Exit For
                End If
            Next

            If Not bolSel Then
                MessageBox.Show("No ha seleccionado ningún registro.", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            '=========Validamos si esta provisionado
            Dim obeServicio As Servicio_BE
            Dim olstServicio As New List(Of Servicio_BE)
            For i As Integer = 0 To dtgOperaciones.RowCount - 1
                If dtgOperaciones.Rows(i).Cells("chk2").Value = True Then
                    obeServicio = New Servicio_BE
                    obeServicio.CCMPN = _oServicio.CCMPN
                    obeServicio.NOPRCN = dtgOperaciones.Rows(i).Cells("NOPRCN_D").Value
                    obeServicio.NSECFC = dtgFacturacion.CurrentRow.Cells("NSECFC1").Value
                    obeServicio.TIPO_REV = "2"
                    olstServicio.Add(obeServicio)
                End If
            Next
            'If fblnValidarProvision(olstServicio) Then Exit Sub
            '=========Validamos si esta provisionado


            If oServicio.FLGFAC = "S" OrElse oServicio.FLGFAC = "0" Then
                MessageBox.Show("No se puede trasladar una operación cuando ya está facturado", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            ofrmTrasladar.lblCliente.Text = dtgOperaciones.CurrentRow.Cells("CLI_OPE").Value
            ofrmTrasladar.lblRevision.Text = dtgFacturacion.CurrentRow.Cells("NSECFC1").Value

            ofrmTrasladar.oServicio = oServicio
            ofrmTrasladar.oServicio.CTPALJ = IIf(oServicio.CTPALJ = "", "0", oServicio.CTPALJ)


            dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)

            ofrmTrasladar.dtg = dtgOperaciones

            If ofrmTrasladar.ShowDialog = DialogResult.Yes Then

                oServicio.NOPRCN = 0
                oServicio.NSECFC = 0
                oServicio.NSECFC_UPD = 0


                LimpiarDetalleRevision()
                Refrescar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub UcPorRevision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Marcar = btnMarcarItems.BackgroundImage
        Desmarcar = btnMarcarItems.Image
    End Sub

    'Private Sub dtgFacturacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacion.CellClick
    '    Try

    '        'If dtgFacturacion.Columns(e.ColumnIndex).Name = "chk" Then
    '        '    If oServicio.FLGFAC = "S" OrElse oServicio.FLGFAC = "0" Then
    '        '        dtgFacturacion.CurrentRow.Cells("chk").Value = False
    '        '        Me.dtgFacturacion.EndEdit()
    '        '    End If
    '        'End If
    '    Catch : End Try
    'End Sub

    Private Sub dtgFacturacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacion.CellDoubleClick
        Try
            If dtgFacturacion.Columns(e.ColumnIndex).Name = "chk" Then
                If oServicio.FLGFAC = "S" OrElse oServicio.FLGFAC = "0" Then
                    dtgFacturacion.CurrentRow.Cells("chk").Value = False
                    Me.dtgFacturacion.EndEdit()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    'Private Sub FacturaResumidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaResumidadToolStripMenuItem.Click
    '    Try
    '        If oServicio.CCLNT = 0 Then
    '            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '            Me.Cursor = Cursors.Default
    '            Exit Sub
    '        End If

    '        Dim olOperacion As New List(Of Servicio_BE)
    '        RaiseEvent Facturar(floOpercionesConCheck, 1)
    '        Refrescar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub FacturaDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDetalladaToolStripMenuItem.Click
    '    Try
    '        If oServicio.CCLNT = 0 Then
    '            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '            Me.Cursor = Cursors.Default
    '            Exit Sub
    '        End If

    '        Dim olOperacion As New List(Of Servicio_BE)
    '        RaiseEvent Facturar(floOpercionesConCheck, 2)
    '        Refrescar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub ExportarPorItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorItem.Click
        Try
            ExportarReporteRevision("I")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExportarPorOc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorOc.Click
        Try

            ExportarReporteRevision("O")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExportarPorRevision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarPorRevision.Click
        Try
            '-------------------------EXPORTAR POR REVISION------------------------------------'
            ExportarReportePorRevision()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificaClienteFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaClienteFac.Click
        Try
            If dtgFacturacion.Rows.Count = 0 Then Exit Sub
            Dim ofrm As New frmActualizaClienteFacturar

            Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If Not ValidaSeleccion() Then
                MessageBox.Show("No ha seleccionado ningun registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            ofrm.oDtg = dtgFacturacion
            ofrm.oServicio = oServicio
            If ofrm.ShowDialog = DialogResult.Yes Then
                LimpiarDetalleRevision()
                Refrescar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


#End Region

#Region "Procedimientos y Funciones"


    Private Sub ExportarReportePorRevision()
        dtgFacturacion.EndEdit()
        If Me.dtgFacturacion.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obj_Servicio As New Servicio_BE
        Dim objDtSinReem As New DataTable
        Dim objDtConReem As New DataTable
        Dim objDsServ As New DataSet
        Dim objDsSinReem As New DataSet
        Dim objDsConReem As New DataSet
        Dim obj_Logica As New clsConsistencia_BL
        'Try


        If Lista_NrosRevision.Length = 0 Then
            MessageBox.Show("No ha seleccionado ningún registro", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            'Dim tipo_cambio As Decimal = Val("" & lblTipoCambio_1.Text & "")
            'Dim valor_igv As Decimal = 0
            Dim strMensaje As String = String.Empty
            Dim ListRevision As New List(Of Servicio_BE)
            obj_Servicio.CMNDA1 = 100
            obj_Servicio.FULTAC = Format(Now, "yyyyMMdd")
            obj_Servicio.CCLNT = _oServicio.CCLNT
            obj_Servicio.CCMPN = _oServicio.CCMPN
            obj_Servicio.CDVSN = _oServicio.CDVSN
            obj_Servicio.NROS_REVISION = Lista_NrosRevision()
            objDsServ = oServicioOpeNeg.pLista_Detalle_Servicios_Por_Revision(obj_Servicio)
            If objDsServ.Tables.Count = 0 Then
                MsgBox("No tiene registros", MessageBoxIcon.Information)
                Exit Sub
            End If

            '==========OBTENEMOS TIPO DE CAMBIO DEL DIA=========            
            tipo_cambio = obj_Logica.Obtener_Tipo_Cambio(obj_Servicio)
            valor_igv = obj_Logica.Obtener_igv_actual(obj_Servicio)
            If tipo_cambio = 0 Then
                MsgBox("No existe Tipo de Cambio para el Dia de Hoy")
                Exit Sub
            End If

            objDsServ.Tables(0).Columns.Add("TIPO_CAMBIO")
            objDsServ.Tables(1).Columns.Add("TIPO_CAMBIO")

            For i As Integer = 0 To objDsServ.Tables(0).Rows.Count - 1
                objDsServ.Tables(0).Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next

            For i As Integer = 0 To objDsServ.Tables(1).Rows.Count - 1
                objDsServ.Tables(1).Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next
            '========================TABLA APOYO======================
            Dim oDtUtil As New DataTable
            oDtUtil.TableName = "UTILES"
            oDtUtil.Columns.Add("IGV")
            oDtUtil.Columns.Add("TIPO_CAMBIO")
            Dim rowUtil As DataRow
            rowUtil = oDtUtil.NewRow
            rowUtil(0) = valor_igv
            rowUtil(1) = tipo_cambio
            oDtUtil.Rows.Add(rowUtil)
            oDtUtil.TableName = "UTILES"
            '====================================DANDO FORMATO A TABLAS============================
            '======================================================================================
            Dim oDtFiltro As New DataTable
            Dim oDtDetalleSinReembolso As New DataTable
            Dim oDtDetalleReembolso As New DataTable
            oDtDetalleSinReembolso = objDsServ.Tables(0).Copy
            oDtDetalleReembolso = objDsServ.Tables(1).Copy
            '===PARA EL FILTRO===
            oDtFiltro.TableName = "Filtro"
            oDtFiltro.Columns.Add("Filtro")
            oDtFiltro.Columns.Add("Valor")
            Dim row As DataRow
            row = oDtFiltro.NewRow
            row(0) = "Compañia :"
            row(1) = _oServicio.CCMPN_DESC
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "División :"
            row(1) = _oServicio.CDVSN_DESC
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "Planta :"
            row(1) = _oServicio.CPLNDV_DESC
            oDtFiltro.Rows.Add(row)
            If _oServicio.CCLNT > 0 Then
                row = oDtFiltro.NewRow
                row(0) = "Cliente :"
                row(1) = _oServicio.CCLNT & " - " & _oServicio.CCLNT_DESC
                oDtFiltro.Rows.Add(row)
            End If
            'If obj_Servicio.NSECFC > 0 Then
            '    row = oDtFiltro.NewRow
            '    row(0) = "Nro. Consistencia :"
            '    row(1) = obj_Servicio.NSECFC.ToString
            '    oDtFiltro.Rows.Add(row)
            'End If

            '========================================
            '==== PARA EL RESUMEN NO REEMBOLSO=======
            '========================================
            Dim oDtResumenSinReembolso As DataTable = oDtDetalleSinReembolso.Copy
            Dim oDtResumenConReembolso As DataTable = oDtDetalleReembolso.Copy
            Dim colResumenSinReem As Integer = oDtResumenSinReembolso.Columns.Count - 1
            Dim colResumenConReem As Integer = oDtResumenConReembolso.Columns.Count - 1

            Dim tarifaSinReem1 As Integer = 0
            Dim tarifaSinReem2 As Integer = 0
            Dim tarifaConReem1 As Integer = 0
            Dim tarifaConReem2 As Integer = 0
            Dim bTrfInicia As Boolean = True
            Dim ldblSub_totalSinReem As Double = 0D
            Dim ldblSub_totalConReem As Double = 0D
            Dim iPosIniSinReem As Integer = 0
            Dim iPosIniConReem As Integer = 0
            Dim oDvSinReem As New DataView(oDtResumenSinReembolso)
            Dim oDvConReem As New DataView(oDtResumenConReembolso)
            oDvSinReem.Sort = "NRTFSV ASC"
            oDvConReem.Sort = "NRTFSV ASC"

            oDtResumenSinReembolso = oDvSinReem.ToTable(True, "NSECFC", "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")
            oDtResumenConReembolso = oDvConReem.ToTable(True, "NSECFC", "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")

            For i As Integer = 0 To oDtResumenSinReembolso.Rows.Count - 1
                If i = 0 Then
                    tarifaSinReem1 = oDtResumenSinReembolso.Rows(i).Item("NRTFSV")
                    iPosIniSinReem = i
                Else
                    tarifaSinReem2 = oDtResumenSinReembolso.Rows(i).Item("NRTFSV")
                    If tarifaSinReem1 = tarifaSinReem2 Then
                        oDtResumenSinReembolso.Rows(iPosIniSinReem).Item("SUB_TOTAL") = oDtResumenSinReembolso.Rows(iPosIniSinReem).Item("SUB_TOTAL") + oDtResumenSinReembolso.Rows(i).Item("SUB_TOTAL")
                        oDtResumenSinReembolso.Rows(iPosIniSinReem).Item("QATNAN") = oDtResumenSinReembolso.Rows(iPosIniSinReem).Item("QATNAN") + oDtResumenSinReembolso.Rows(i).Item("QATNAN")
                        oDtResumenSinReembolso.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifaSinReem1 = oDtResumenSinReembolso.Rows(i).Item("NRTFSV")
                        iPosIniSinReem = i
                    End If
                End If
            Next

            '========================================
            '==== PARA EL RESUMEN REEMBOLSO=======
            '========================================

            For i As Integer = 0 To oDtResumenConReembolso.Rows.Count - 1
                If i = 0 Then
                    tarifaConReem1 = oDtResumenConReembolso.Rows(i).Item("NRTFSV")
                    iPosIniConReem = i
                Else
                    tarifaConReem2 = oDtResumenConReembolso.Rows(i).Item("NRTFSV")
                    If tarifaConReem1 = tarifaConReem2 Then
                        oDtResumenConReembolso.Rows(iPosIniConReem).Item("SUB_TOTAL") = oDtResumenConReembolso.Rows(iPosIniConReem).Item("SUB_TOTAL") + oDtResumenConReembolso.Rows(i).Item("SUB_TOTAL")
                        oDtResumenConReembolso.Rows(iPosIniConReem).Item("QATNAN") = oDtResumenConReembolso.Rows(iPosIniConReem).Item("QATNAN") + oDtResumenConReembolso.Rows(i).Item("QATNAN")
                        oDtResumenConReembolso.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifaConReem1 = oDtResumenConReembolso.Rows(i).Item("NRTFSV")
                        iPosIniConReem = i
                    End If
                End If
            Next

            'oDtResumen.Columns.RemoveAt(0) ' QUITO LA OPERACION USADA COMO FLAG
            Dim objListaResSinReemDr As DataRow() = oDtResumenSinReembolso.Select("QATNAN > 0")
            Dim objListaResConReemDr As DataRow() = oDtResumenConReembolso.Select("QATNAN > 0")
            Dim objDrSinReem As DataRow
            Dim objDrConReem As DataRow
            Dim lintCont As Integer
            Dim objDtDetSinReem As New DataTable
            objDtDetSinReem.Columns.Add("NRTFSV")
            objDtDetSinReem.Columns.Add("TCMTRF")
            objDtDetSinReem.Columns.Add("MONEDA")
            objDtDetSinReem.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDetSinReem.Columns.Add("QATNAN", GetType(System.Double))
            objDtDetSinReem.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDetSinReem.Columns.Add("TOTAL_DOLARES", GetType(System.Double))

            Dim objDtDetConReem As New DataTable
            objDtDetConReem.Columns.Add("NRTFSV")
            objDtDetConReem.Columns.Add("TCMTRF")
            objDtDetConReem.Columns.Add("MONEDA")
            objDtDetConReem.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDetConReem.Columns.Add("QATNAN", GetType(System.Double))
            objDtDetConReem.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDetConReem.Columns.Add("TOTAL_DOLARES", GetType(System.Double))

            For lintCont = 0 To objListaResSinReemDr.Length - 1
                objDrSinReem = objDtDetSinReem.NewRow
                objDrSinReem(0) = objListaResSinReemDr(lintCont).Item("NRTFSV") 'TARIFA
                objDrSinReem(1) = objListaResSinReemDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDrSinReem(2) = objListaResSinReemDr(lintCont).Item("TMNDA")  'MONEDA
                objDrSinReem(3) = objListaResSinReemDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDrSinReem(4) = objListaResSinReemDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_totalSinReem = objListaResSinReemDr(lintCont).Item("SUB_TOTAL")
                If objDrSinReem(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDrSinReem(5) = Math.Round(ldblSub_totalSinReem, 2)  'IMPORTE SOLES
                    objDrSinReem(6) = Math.Round(ldblSub_totalSinReem / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDrSinReem(5) = Math.Round(ldblSub_totalSinReem * tipo_cambio, 2) 'IMPORTE SOLES
                    objDrSinReem(6) = Math.Round(ldblSub_totalSinReem, 2) 'IMPORTE DOLARES
                End If
                objDtDetSinReem.Rows.Add(objDrSinReem)
            Next lintCont


            For lintCont = 0 To objListaResConReemDr.Length - 1
                objDrConReem = objDtDetConReem.NewRow
                objDrConReem(0) = objListaResConReemDr(lintCont).Item("NRTFSV") 'TARIFA
                objDrConReem(1) = objListaResConReemDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDrConReem(2) = objListaResConReemDr(lintCont).Item("TMNDA")  'MONEDA
                objDrConReem(3) = objListaResConReemDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDrConReem(4) = objListaResConReemDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_totalConReem = objListaResConReemDr(lintCont).Item("SUB_TOTAL")
                If objDrConReem(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDrConReem(5) = Math.Round(ldblSub_totalConReem, 2)  'IMPORTE SOLES
                    objDrConReem(6) = Math.Round(ldblSub_totalConReem / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDrConReem(5) = Math.Round(ldblSub_totalConReem * tipo_cambio, 2) 'IMPORTE SOLES
                    objDrConReem(6) = Math.Round(ldblSub_totalConReem, 2) 'IMPORTE DOLARES
                End If
                objDtDetConReem.Rows.Add(objDrConReem)
            Next lintCont

            '=======================================
            '====== PARA EL RESUMEN DE LOTES =======
            '=======================================
            Dim oDtResLotePrintSinReem As New DataTable
            Dim oDtResLotePrintConReem As New DataTable
            Dim oDtCiPrint As New DataTable
            If obj_Servicio.CDVSN = "R" Then
                oDtResLotePrintSinReem = GenerarLoteSinReem(oDtDetalleSinReembolso)
                oDtResLotePrintConReem = GenerarLoteConReem(oDtDetalleReembolso)

                '==================RESUMEN PARA LA CUENTA DE IMPUTACION===========================
                oDtCiPrint = GeneraCI(oDtDetalleReembolso)
            End If
            '=======================================
            '=======================================
            objDsServ.Tables(0).TableName = "Detallle Sin Reembolso"
            objDsServ.Tables(1).TableName = "Detalle Reembolso"


            If obj_Servicio.CDVSN = "R" Then
                objDsServ.Tables(0).DefaultView.Sort = "NSECFC, NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA,NCRROP"
                objDsServ.Tables(1).DefaultView.Sort = "NSECFC, NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA,NCRROP"
            Else
                objDsServ.Tables(0).DefaultView.Sort = "NSECFC, NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA"
                objDsServ.Tables(1).DefaultView.Sort = "NSECFC, NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA"
            End If
            'objDsServ.Tables(0) = objDsServ.Tables(0).DefaultView.ToTable
            objDtSinReem = objDsServ.Tables(0).DefaultView.ToTable
            objDtConReem = objDsServ.Tables(1).DefaultView.ToTable
            oDtFiltro.TableName = "Filtro"
            oDtResumenSinReembolso.TableName = "Resumen Sin Reembolso"
            oDtResumenConReembolso.TableName = "Resumen Reembolso"
            'oDtResumen.TableName = "Resumen"
            'objDtDet.TableName = "Resumen"

            objDsSinReem.Tables.Add(objDtSinReem.Copy)  'Detalle
            objDsConReem.Tables.Add(objDtConReem.Copy)  'Detalle

            '======================SIN REEMBOLSO=============='
            'objDsSinReem.Tables.Add(objDsServ.Tables(0).Copy)
            objDsSinReem.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDsSinReem.Tables.Add(objDtDetSinReem.Copy) 'Resumen
            objDsSinReem.Tables.Add(oDtUtil.Copy) 'Utiles

            '======================REEMBOLSO=================='
            'objDsConReem.Tables.Add(objDsServ.Tables(1).Copy)
            objDsConReem.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDsConReem.Tables.Add(objDtDetConReem.Copy) 'Resumen
            objDsConReem.Tables.Add(oDtUtil.Copy) 'Utiles



            If _oServicio.CDVSN = "R" Then objDsSinReem.Tables.Add(oDtResLotePrintSinReem.Copy) 'Resumen Lotes
            If _oServicio.CDVSN = "R" Then objDsConReem.Tables.Add(oDtResLotePrintConReem.Copy) 'Resumen Lotes
            objDsConReem.Tables.Add(oDtCiPrint.Copy) 'Resumen CI


            'EmitirReporteExcel(objDs, obj_Servicio, TipoReporte)
            EmitirReporteExcel(objDsSinReem, objDsConReem, obj_Servicio)

        End If


        'ObtenerFiltroReporte(valor_igv)
        'oServicioOpeNeg.pExportarConsistenciaRevisionExcel(oServicio, tipo_cambio, valor_igv, strTipo, strMensaje, True, ListRevision)


        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Function filtraDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function

    Private Function BuscarDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function

    Private Function GenerarLoteSinReem(ByVal oDetalleSinRe As DataTable) As DataTable
        Dim dtFiltro As New DataTable
        Dim oDtResLotePrint As New DataTable

        Dim oDtResLote As DataTable = oDetalleSinRe.Copy

        Dim oDvLote As New DataView(oDtResLote)
        Dim objDataRow As DataRow
        Dim TotMntSoles As Double = 0D
        Dim TotMntDolares As Double = 0D
        oDvLote.Sort = "LOTE ASC"
        oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP", "QATNAN", "VALCTE")
        Dim OriginalCount As Integer = oDtResLote.Rows.Count

        oDtResLote.Columns.Remove("NOPRCN")

        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0
            dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")

            For Each dr As DataRow In dtFiltro.Rows '
                If dr("TMNDA").ToString.Trim = "USD" Then
                    TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                    TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                Else
                    TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                    If tipo_cambio = 0 Then
                        TotMntDolares += 0
                    Else
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                    End If
                End If
            Next

            If dtFiltro.Rows.Count > 0 Then
                objDataRow = oDtResLotePrint.NewRow
                objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                objDataRow.Item("SOLES") = TotMntSoles.ToString("N2")
                objDataRow.Item("DOLARES") = TotMntDolares.ToString("N2")
                oDtResLotePrint.Rows.Add(objDataRow)
                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        Return oDtResLotePrint
    End Function
    Private Function GenerarLoteConReem(ByVal oDtDetalleConReem As DataTable) As DataTable
        Dim dtFiltro As New DataTable
        Dim oDtResLotePrint As New DataTable
        Dim oDtResLote As DataTable = oDtDetalleConReem.Copy

        Dim oDvLote As New DataView(oDtResLote)
        Dim objDataRow As DataRow
        Dim TotMntSoles As Double = 0D
        Dim TotMntDolares As Double = 0D
        oDvLote.Sort = "LOTE ASC"
        oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP", "QATNAN", "VALCTE")
        Dim OriginalCount As Integer = oDtResLote.Rows.Count

        oDtResLote.Columns.Remove("NOPRCN")

        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0
            dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")

            For Each dr As DataRow In dtFiltro.Rows '
                If dr("TMNDA").ToString.Trim = "USD" Then

                    If Val(dr("VALCTE")) > 0 Then
                        TotMntSoles += dr("SUB_TOTAL") * tipo_cambio ' + (dr("QATNAN") * tipo_cambio * dr("VALCTE") / 100)
                        TotMntDolares += dr("SUB_TOTAL") '+ (dr("QATNAN") * dr("VALCTE") / 100)
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    End If

                Else
                    If Val(dr("VALCTE")) > 0 Then
                        TotMntSoles += dr("SUB_TOTAL") ' + (dr("QATNAN") * dr("VALCTE") / 100)
                    Else
                        TotMntSoles += dr("SUB_TOTAL")
                    End If

                    If tipo_cambio = 0 Then
                        TotMntDolares += 0
                    Else
                        If Val(dr("VALCTE")) > 0 Then
                            TotMntDolares += dr("SUB_TOTAL") / tipo_cambio '+ (dr("QATNAN") / tipo_cambio * dr("VALCTE") / 100)
                        Else
                            TotMntDolares += dr("SUB_TOTAL") / tipo_cambio
                        End If
                    End If
                End If
            Next

            If dtFiltro.Rows.Count > 0 Then
                objDataRow = oDtResLotePrint.NewRow
                objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                objDataRow.Item("SOLES") = TotMntSoles.ToString("N2")
                objDataRow.Item("DOLARES") = TotMntDolares.ToString("N2")
                oDtResLotePrint.Rows.Add(objDataRow)
                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        Return oDtResLotePrint
    End Function

    Private Function GeneraCI(ByVal oDtDetalle As DataTable) As DataTable
        Dim oDtCI As New DataTable
        Dim oDtCiPrint As New DataTable
        Dim oDtCiPrintFinal As New DataTable
        Dim dtFiltro As New DataTable
        oDtCI = oDtDetalle.Copy
        Dim oDvCI As New DataView(oDtCI)
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE
        Dim objDataRow As DataRow = Nothing
        Dim TotMntSoles As Decimal = 0D
        Dim TotMntDolares As Decimal = 0D


        oDtCI = oDvCI.ToTable(True, "NOPRCN", "NRTFSV", "CI", "TMNDA", "NCRROP", "NGUITR", "CTRMNC", "QATNAN", "VALCTE", "SUB_TOTAL")
        Dim OriginalCount As Integer = oDtCI.Rows.Count

        oDtCI.Columns.Remove("NOPRCN")

        oDtCiPrint.Columns.Add("CI")
        oDtCiPrint.Columns.Add("MONEDA")
        oDtCiPrint.Columns.Add("SOLES")
        oDtCiPrint.Columns.Add("DOLARES")
        oDtCiPrintFinal = oDtCiPrint.Clone

        oDtCI.DefaultView.Sort = "CI"
        oDtCI = oDtCI.DefaultView.ToTable

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0

            '=============EN CASO DE QUE LA CUENTA IMPUTACION SEA DESDE UN CARGO PLAN==================
            If oDtCI.Rows(i)("CI").ToString.Trim = "IMP_CARGO_PLAN" Then

                obe.NGUITR = oDtCI.Rows(i)("NGUITR")
                obe.CTRMNC = oDtCI.Rows(i)("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)

                For Each dr As DataRow In oDtCagoPlan.Rows

                    If oDtCI.Rows(i)("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") * tipo_cambio + (oDtCI.Rows(i)("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            TotMntDolares = oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") * tipo_cambio
                            TotMntDolares = oDtCI.Rows(i)("QATNAN")
                        End If


                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = oDtCI.Rows(i)("QATNAN")
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares = oDtCI.Rows(i)("QATNAN") / tipo_cambio + (oDtCI.Rows(i)("QATNAN") / tipo_cambio * oDtCI.Rows(i)("ITPCMT") / 100)
                            Else
                                TotMntDolares = oDtCI.Rows(i)("QATNAN") / tipo_cambio
                            End If

                        End If
                    End If

                    TotMntSoles = (TotMntSoles * dr("PRCRMT") / 100)
                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = dr("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                Next


            Else
                '=============CUENTA DE IMPUTACION NORMAL
                dtFiltro = filtraDatatable(oDtCI, "CI = '" + oDtCI.Rows(i)("CI").ToString.Trim + "'")
                For Each dr As DataRow In dtFiltro.Rows

                    If dr("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("SUB_TOTAL") * tipo_cambio '+ (dr("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            TotMntDolares += dr("SUB_TOTAL") ' + (dr("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles += dr("SUB_TOTAL") * tipo_cambio ' + (dr("QATNAN") * tipo_cambio / 100)
                            TotMntDolares += dr("SUB_TOTAL")
                        End If

                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("SUB_TOTAL") '* oDtCI.Rows(i)("VALCTE")
                        Else
                            TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares += dr("SUB_TOTAL") / tipo_cambio ' * oDtCI.Rows(i)("VALCTE") + (dr("QATNAN") / tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            Else
                                TotMntDolares += dr("SUB_TOTAL") / tipo_cambio ' + (dr("QATNAN") / tipo_cambio / 100)
                            End If

                        End If
                    End If

                Next

                If dtFiltro.Rows.Count > 0 Then

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim

                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                    i = i + dtFiltro.Rows.Count - 1
                End If


            End If

        Next i


        '=====se recorre nuevamente para saber si se encontro la misma cuenta ya sea en un cargo plan o registro normal=========
        oDtCiPrint.DefaultView.Sort = "CI"
        oDtCiPrint = oDtCiPrint.DefaultView.ToTable

        OriginalCount = oDtCiPrint.Rows.Count

        For i As Integer = 0 To OriginalCount - 1

            TotMntDolares = 0
            TotMntSoles = 0

            dtFiltro = filtraDatatable(oDtCiPrint, "CI = '" + oDtCiPrint.Rows(i)("CI").ToString.Trim + "'")
            For Each dr As DataRow In dtFiltro.Rows

                If dr("MONEDA").ToString.Trim = "USD" Then
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    TotMntDolares += Convert.ToDouble(dr("DOLARES"))

                Else
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    If tipo_cambio = 0 Then
                        TotMntDolares += 0
                    Else
                        TotMntDolares += Convert.ToDouble(dr("SOLES"))
                    End If
                End If

            Next

            If dtFiltro.Rows.Count > 0 Then

                objDataRow = oDtCiPrintFinal.NewRow
                objDataRow.Item("CI") = oDtCiPrint.Rows(i)("CI").ToString.Trim
                objDataRow.Item("MONEDA") = oDtCiPrint.Rows(i)("MONEDA").ToString.Trim

                objDataRow.Item("SOLES") = TotMntSoles
                objDataRow.Item("DOLARES") = TotMntDolares
                oDtCiPrintFinal.Rows.Add(objDataRow)

                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        If oDtCiPrintFinal.Rows.Count > 0 Then oDtCiPrint = oDtCiPrintFinal


        Return oDtCiPrint
    End Function

    Private Function GeneraCICargoPlan(ByVal _oServicio As Servicio_BE) As DataTable
        Dim oServicioNeg As New clsServicio_BL
        Dim oDs As New DataSet
        Dim oDtCI As New DataTable
        Dim oDtOC_Dist As New DataTable

        Dim oDtCIFiltro As New DataTable
        Dim where As String = ""
        Dim sumaCI As Double = 0D

        Dim oDtTemp As New DataTable
        Dim oDtOCTemp As New DataTable

        ' === Creamos Structura Tabla Distribución === 
        oDtOCTemp.Columns.Add("FLG")
        oDtOCTemp.Columns.Add("CI")
        oDtOCTemp.Columns.Add("POR")
        ' ========== ========== ========== ============

        oDs = oServicioNeg.Importa_CI_CargoPlan(_oServicio)
        oDtCI = oDs.Tables(0)
        oDtOC_Dist = oDs.Tables(1)
        Dim oDtFinal As New DataTable

        oDtFinal.Columns.Add("CI", GetType(String))
        oDtFinal.Columns.Add("PRCRMT", GetType(Decimal))
        Dim drFinal As DataRow
        If oDtOC_Dist.Rows.Count = 0 Then
            '============Distribución Simple================
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                where = "CI = '" & oDtCI.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtCI, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("PRCRMT")
                Next

                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        Else
            '============Hacemos distribucion adicional por OC============
            Dim iRow As DataRow
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                '=========================Buscamos OC=========================
                where = "NORCML = '" & oDtCI.Rows(i).Item("NORCML").ToString.Trim & "' "
                oDtTemp = BuscarDatatable(oDtOC_Dist, where)
                If oDtTemp.Rows.Count > 0 Then
                    For Each oDrOC As DataRow In oDtTemp.Rows
                        iRow = oDtOCTemp.NewRow
                        iRow("FLG") = "DISTRIBUIDOS"
                        Select Case oDtCI.Rows(i).Item("CMEDTR")
                            Case "4" 'TERRESTRE
                                iRow("CI") = oDrOC("TCTCST")
                            Case "1" 'AEREO
                                iRow("CI") = oDrOC("TCTCSA")
                            Case "5" ' FLUVIAL
                                iRow("CI") = oDrOC("TCTCSF")
                        End Select
                        iRow("POR") = oDtCI.Rows(i).Item("PRCRMT") * oDrOC("IPRCTJ") * 0.01 ' VALOR DEL PORCENTAJE DISTRIBUIDO
                        oDtOCTemp.Rows.Add(iRow)
                    Next
                Else
                    iRow = oDtOCTemp.NewRow
                    iRow("FLG") = "NORMAL"
                    iRow("CI") = oDtCI.Rows(i).Item("CI")
                    iRow("POR") = oDtCI.Rows(i).Item("PRCRMT")
                    oDtOCTemp.Rows.Add(iRow)
                End If
            Next
            oDtOCTemp.DefaultView.Sort = "CI"
            oDtOCTemp = oDtOCTemp.DefaultView.ToTable()
            For i As Integer = 0 To oDtOCTemp.Rows.Count - 1
                where = "CI = '" & oDtOCTemp.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtOCTemp, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("POR")
                Next

                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtOCTemp.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        End If

        Return oDtFinal
    End Function

    Private Function ResumenTable(ByVal objDt As DataTable) As DataTable

        Dim oDtDetalle As DataTable = objDt
        Dim oDtResumenAlmacen As New DataTable

        oDtResumenAlmacen = oDtDetalle.Clone

        Select Case _oServicio.CTPALJ
            Case ""
                Dim TCMPCL As String = ""
                Dim NSECFC As String = ""
                Dim NOPRCN As String = ""
                Dim TMNDA As String = ""
                Dim NRTFSV As String = ""
                Dim SERVICIO As String = ""
                Dim TCMTRF As String = ""
                Dim IVLSRV As String = ""
                Dim QATNAN As String = ""
                Dim SUB_TOTAL As String = ""
                Dim SESTRG_SERV As String = ""
                Dim NCRROP As String = ""
                Dim Division As String = ""

                Dim nCount As Integer = 0
                Dim blExiste As Boolean = False
                Dim blExisteNRev As Boolean = False
                Dim blExisteOper As Boolean = False

                For Each dr As DataRow In oDtDetalle.Rows

                    blExiste = False



                    If nCount = 0 Then
                        TCMPCL = dr("TCMPCL")
                        NSECFC = dr("NSECFC")
                        NOPRCN = dr("NOPRCN")
                        TMNDA = dr("TMNDA")
                        NRTFSV = dr("NRTFSV")
                        SERVICIO = dr("SERVICIO")
                        TCMTRF = dr("TCMTRF")
                        IVLSRV = dr("IVLSRV")
                        QATNAN = dr("QATNAN")
                        SUB_TOTAL = dr("SUB_TOTAL")
                        NCRROP = dr("NCRROP")
                        Division = dr("CDVSN")
                        If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
                    End If

                    If dr("CDVSN") = "R" Then
                        If TCMPCL = dr("TCMPCL") And _
                                                              NSECFC = dr("NSECFC") And _
                                                              NOPRCN = dr("NOPRCN") And _
                                                              TMNDA = dr("TMNDA") And _
                                                              NRTFSV = dr("NRTFSV") And _
                                                              SERVICIO = dr("SERVICIO") And _
                                                              TCMTRF = dr("TCMTRF") And _
                                                              IVLSRV = dr("IVLSRV") And _
                                                              QATNAN = dr("QATNAN") And _
                                                              SUB_TOTAL = dr("SUB_TOTAL") And _
                                                              NCRROP = dr("NCRROP") And _
                                                              SESTRG_SERV = dr("SESTRG_SERV") Then
                            blExiste = True
                        End If
                    Else
                        If TCMPCL = dr("TCMPCL") And _
                                                                              NSECFC = dr("NSECFC") And _
                                                                              NOPRCN = dr("NOPRCN") And _
                                                                              TMNDA = dr("TMNDA") And _
                                                                              NRTFSV = dr("NRTFSV") And _
                                                                              SERVICIO = dr("SERVICIO") And _
                                                                              TCMTRF = dr("TCMTRF") And _
                                                                              IVLSRV = dr("IVLSRV") And _
                                                                              QATNAN = dr("QATNAN") And _
                                                                              SUB_TOTAL = dr("SUB_TOTAL") Then
                            blExiste = True
                        End If
                    End If


                    nCount += 1

                    If blExiste And nCount > 1 Then
                        Continue For

                    Else
                        oDtResumenAlmacen.ImportRow(dr)
                    End If
                    TCMPCL = dr("TCMPCL")
                    NSECFC = dr("NSECFC")
                    NOPRCN = dr("NOPRCN")
                    TMNDA = dr("TMNDA")
                    NRTFSV = dr("NRTFSV")
                    SERVICIO = dr("SERVICIO")
                    TCMTRF = dr("TCMTRF")
                    IVLSRV = dr("IVLSRV")
                    QATNAN = dr("QATNAN")
                    SUB_TOTAL = dr("SUB_TOTAL")
                    NCRROP = dr("NCRROP")
                    If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
                Next



                oDtDetalle = oDtResumenAlmacen
                '=============================================================================
                TCMPCL = ""
                NSECFC = ""
                NOPRCN = ""
                TMNDA = ""
                NRTFSV = ""
                SERVICIO = ""
                TCMTRF = ""
                IVLSRV = ""
                QATNAN = ""
                SUB_TOTAL = ""
                SESTRG_SERV = ""

                For i As Integer = 0 To oDtDetalle.Rows.Count - 1
                    blExiste = False
                    blExisteNRev = False
                    blExisteOper = False
                    If i = 0 Then
                        TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
                        NSECFC = oDtDetalle.Rows(i).Item("NSECFC")
                        NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                        TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                        NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                        SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                        TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                        IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                        QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                        SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                        If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

                    End If
                    If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then

                        If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                              NSECFC = oDtDetalle.Rows(i).Item("NSECFC") And _
                              NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                              TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                              NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                              SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                              TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                              IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                              SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV") Then
                            blExiste = True
                        End If
                    Else

                        If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                              NSECFC = oDtDetalle.Rows(i).Item("NSECFC") And _
                              NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                              TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                              NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                              SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                              TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                              IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                              QATNAN = oDtDetalle.Rows(i).Item("QATNAN") And _
                              SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL") Then
                            blExiste = True
                        End If
                    End If
                    If NSECFC = oDtDetalle.Rows(i).Item("NSECFC") Then
                        blExisteNRev = True
                    End If

                    If NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") Then
                        blExisteOper = True
                    End If


                    TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
                    NSECFC = oDtDetalle.Rows(i).Item("NSECFC")
                    NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                    TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                    NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                    SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                    TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                    IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                    QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                    SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                    If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

                    If blExisteOper And i > 0 Then
                        oDtDetalle.Rows(i).Item("NOPRCN") = 0
                        oDtDetalle.Rows(i).Item("FOPRCN") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""
                    End If

                    If blExisteNRev And i > 0 Then
                        oDtDetalle.Rows(i).Item("NSECFC") = 0
                    End If

                    If blExiste And i > 0 Then
                        oDtDetalle.Rows(i).Item("TCMPCL") = ""
                        oDtDetalle.Rows(i).Item("TIPRO") = ""
                        oDtDetalle.Rows(i).Item("NRTFSV") = 0
                        oDtDetalle.Rows(i).Item("SERVICIO") = ""
                        oDtDetalle.Rows(i).Item("TCMTRF") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""


                        oDtDetalle.AcceptChanges()
                    End If

                Next
                'If Not chkDetallado.Checked And ServicioOperacion.TipoReporte.Excel = tipoReporte Then
                With oDtDetalle
                    If .Columns("cclnt") IsNot Nothing Then .Columns.Remove("cclnt")
                    If .Columns("ccmpn") IsNot Nothing Then .Columns.Remove("ccmpn")
                    If .Columns("cdvsn") IsNot Nothing Then .Columns.Remove("cdvsn")
                    If .Columns("SESTRG") IsNot Nothing Then .Columns.Remove("SESTRG")
                    If .Columns("TIPO_CAMBIO") IsNot Nothing Then .Columns.Remove("TIPO_CAMBIO")

                    If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
                    If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
                    'If .Columns("NSECFC") IsNot Nothing Then .Columns.Remove("NSECFC")



                    If .Columns("CREFFW") IsNot Nothing Then .Columns.Remove("CREFFW")
                    If .Columns("NCRRDC") IsNot Nothing Then .Columns.Remove("NCRRDC")
                    If .Columns("NDIAPL") IsNot Nothing Then .Columns.Remove("NDIAPL")
                    If .Columns("DESCWB") IsNot Nothing Then .Columns.Remove("DESCWB")
                    If .Columns("TUBRFR") IsNot Nothing Then .Columns.Remove("TUBRFR")
                    If .Columns("QREFFW") IsNot Nothing Then .Columns.Remove("QREFFW")
                    If .Columns("TIPBTO") IsNot Nothing Then .Columns.Remove("TIPBTO")
                    If .Columns("QPSOBL") IsNot Nothing Then .Columns.Remove("QPSOBL")
                    If .Columns("TUNPSO") IsNot Nothing Then .Columns.Remove("TUNPSO")
                    If .Columns("QVLBTO") IsNot Nothing Then .Columns.Remove("QVLBTO")
                    If .Columns("TUNVOL") IsNot Nothing Then .Columns.Remove("TUNVOL")
                    If .Columns("NSRCN1") IsNot Nothing Then .Columns.Remove("NSRCN1")
                    If .Columns("CPRCN1") IsNot Nothing Then .Columns.Remove("CPRCN1")

                    If .Columns("PROVEEDOR") IsNot Nothing Then .Columns.Remove("PROVEEDOR")
                    If .Columns("RUC") IsNot Nothing Then .Columns.Remove("RUC")
                    If .Columns("COD") IsNot Nothing Then .Columns.Remove("COD")
                    If .Columns("DOCUMENTO") IsNot Nothing Then .Columns.Remove("DOCUMENTO")
                    If .Columns("NUMERO_DOC") IsNot Nothing Then .Columns.Remove("NUMERO_DOC")
                    If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")


                    If .Columns("CORR") IsNot Nothing Then .Columns.Remove("CORR")
                    If .Columns("FECHA") IsNot Nothing Then .Columns.Remove("FECHA")
                    If .Columns("PESO") IsNot Nothing Then .Columns.Remove("PESO")
                    If .Columns("VOLUMEN") IsNot Nothing Then .Columns.Remove("VOLUMEN")
                    If .Columns("AREA") IsNot Nothing Then .Columns.Remove("AREA")

                    If .Columns("TCTCST") IsNot Nothing Then .Columns.Remove("TCTCST")
                    If .Columns("TCTCSA") IsNot Nothing Then .Columns.Remove("TCTCSA")
                    If .Columns("TCTCSF") IsNot Nothing Then .Columns.Remove("TCTCSF")
                    If .Columns("NORAGN") IsNot Nothing Then .Columns.Remove("NORAGN")
                    If .Columns("FREFFW") IsNot Nothing Then .Columns.Remove("FREFFW")


                    Dim intLinea As Integer = 0

                    .Columns("TCMPCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NSECFC").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TRDCCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TIPRO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NRTFSV").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("SERVICIO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TCMTRF").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FATNSR").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("QATNAN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("IVLSRV").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TMNDA").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("SUB_TOTAL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("SESTRG_SERV").SetOrdinal(intLinea)
                    intLinea += 1

                    If Not .Columns("QATNRL") Is Nothing Then
                        .Columns("QATNRL").SetOrdinal(intLinea)
                        intLinea += 1
                        .Columns("IVLSRV").SetOrdinal(intLinea)
                        intLinea += 1
                        .Columns("TMNDA").SetOrdinal(intLinea)
                        intLinea += 1
                        .Columns("SUB_TOTAL").SetOrdinal(intLinea)
                        intLinea += 1
                        .Columns("SESTRG_SERV").SetOrdinal(intLinea)
                        intLinea += 1
                        .Columns("QATNRL").ColumnName = "Cantidad real"
                    End If


                    .Columns("TCMPCL").ColumnName = "Cliente"
                    .Columns("NSECFC").ColumnName = "Nro. Revision"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("TRDCCL").ColumnName = "Referencia Operación"
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"

                    .Columns("TIPRO").ColumnName = "Proceso"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("QATNAN").ColumnName = "Cantidad"
                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                    .Columns("FOPRCN").ColumnName = "Fecha Operación"
                    .Columns("FATNSR").ColumnName = "Fecha Servicio"
                    If .Columns("TSRVC") IsNot Nothing Then .Columns("TSRVC").ColumnName = "Observación"
                    If .Columns("OBSERVACION") IsNot Nothing Then .Columns("OBSERVACION").ColumnName = "Observación"
                    .Columns.Remove("Cliente")
                    'If .Columns("FOPRCN") IsNot Nothing Then .Columns.Remove("FOPRCN")
                    'If .Columns("FATNSR") IsNot Nothing Then .Columns.Remove("FATNSR")
                    If .Columns("NCRROP") IsNot Nothing Then .Columns.Remove("NCRROP")

                End With



        End Select

        Return oDtDetalle
    End Function

    Private Sub EmitirReporteExcel(ByVal objDsSinReem As DataSet, ByVal objDsConReem As DataSet, ByVal obj_Servicio As Servicio_BE)
        Dim odsExcelSinReem As New DataSet
        Dim odsExcelConReem As New DataSet
        '----------------SIN REEMBOLSO------------------'
        Dim oDtDetalleSinReem As DataTable = objDsSinReem.Tables(0)
        Dim oDtFiltroSinReem As DataTable = objDsSinReem.Tables(1)
        Dim oDtResumenSinReem As DataTable = objDsSinReem.Tables(2)

        Dim oDtDetalleConReem As DataTable = objDsConReem.Tables(0)
        Dim oDtFiltroConReem As DataTable = objDsConReem.Tables(1)
        Dim oDtResumenConReem As DataTable = objDsConReem.Tables(2)
        'Dim oDtDetalle As DataTable = objDs.Tables(0)
        'Dim oDtFiltro As DataTable = objDs.Tables(1)
        'Dim oDtResumen As DataTable = objDs.Tables(2)
        Dim oDtResLoteSinReem As New DataTable
        Dim oDtResLoteConReem As New DataTable
        'Dim oDtResumenAlmacen As New DataTable
        Dim oDtResumenSinReemAlmacen As New DataTable
        Dim oDtResumenConReemAlmacen As New DataTable
        'Dim drResumenSinReem As DataRow
        'Dim drResumenConReem As DataRow
        Dim drResumenSinRe As DataRow
        Dim drResumenConRe As DataRow
        Dim blExisteAlmacenSinRe As Boolean = False
        Dim blExisteAlmacenConRe As Boolean = False
        oDtResumenSinReemAlmacen = oDtDetalleSinReem.Clone
        oDtResumenConReemAlmacen = oDtDetalleConReem.Clone
        Dim oDtReemb As DataTable = Nothing

        '===PARA EL DETALLE===
        Select Case _oServicio.CDVSN
            Case "R"
                oDtResLoteSinReem = objDsSinReem.Tables(4)
                oDtResLoteConReem = objDsConReem.Tables(4)
                Select Case obj_Servicio.STPODP
                    Case "" ', "7"
                        '==========ALMACEN============

                        'If obj_Servicio.CTPALJ = "RE" Then
                        If Not oDtDetalleConReem.Columns("QATNRL") Is Nothing Then
                            oDtDetalleConReem.Columns.Remove("QATNRL")
                        End If
                        'End If
                        'pora que se muetre las descripcion de las columnas
                        _oServicio.CTPALJ = ""
                        oDtResumenSinReemAlmacen = ResumenTable(oDtDetalleSinReem)
                        oDtResumenSinReemAlmacen.TableName = "Servicio Sin Reembolso"
                        oDtResumenConReemAlmacen = ResumenTable(oDtDetalleConReem)
                        oDtResumenConReemAlmacen.TableName = "Servicio Con Reembolso"
                        oDtDetalleSinReem = oDtResumenSinReemAlmacen.Copy
                        oDtDetalleConReem = oDtResumenConReemAlmacen.Copy

                End Select

            Case Else
                '==========SIL============
                oDtResLoteConReem = objDsConReem.Tables(4)
                '=============SIN REEMBOLSO==================='
                If oDtDetalleSinReem.Columns("CCMPN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CCMPN")
                If oDtDetalleSinReem.Columns("CDVSN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CDVSN")
                If oDtDetalleSinReem.Columns("CCLNT") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CCLNT")
                If oDtDetalleSinReem.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TIPO_CAMBIO")
                If oDtDetalleSinReem.Columns("CMEDTR_VALUE") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CMEDTR_VALUE")
                If oDtDetalleSinReem.Columns("OS") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("OS")

                '================REEMBOLSO====================='
                If oDtDetalleConReem.Columns("CCMPN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CCMPN")
                If oDtDetalleConReem.Columns("CDVSN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CDVSN")
                If oDtDetalleConReem.Columns("CCLNT") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CCLNT")
                If oDtDetalleConReem.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TIPO_CAMBIO")
                If oDtDetalleConReem.Columns("CMEDTR_VALUE") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CMEDTR_VALUE")
                If oDtDetalleConReem.Columns("OS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("OS")


                oDtResumenSinReemAlmacen = oDtDetalleSinReem.Clone
                oDtResumenConReemAlmacen = oDtDetalleConReem.Clone

                For Each dr As DataRow In oDtDetalleSinReem.Rows

                    blExisteAlmacenSinRe = False

                    For Each drAux As DataRow In oDtResumenSinReemAlmacen.Select("TCMPCL='" & dr("TCMPCL") & _
                                                                         "' and NOPRCN='" & dr("NOPRCN") & _
                                                                         "' and TMNDA='" & dr("TMNDA") & _
                                                                         "' and NRTFSV=" & dr("NRTFSV") & _
                                                                         "  and SERVICIO='" & dr("SERVICIO").ToString.Replace("'", "") & _
                                                                         "' and TCMTRF='" & dr("TCMTRF").ToString.Replace("'", "") & _
                                                                         "' and IVLSRV=" & dr("IVLSRV") & _
                                                                         "  and QATNAN=" & dr("QATNAN"))
                        blExisteAlmacenSinRe = True
                    Next

                    If blExisteAlmacenSinRe Then Continue For

                    drResumenSinRe = oDtResumenSinReemAlmacen.NewRow

                    drResumenSinRe("TCMPCL") = dr("TCMPCL")
                    drResumenSinRe("NOPRCN") = dr("NOPRCN")
                    drResumenSinRe("TMNDA") = dr("TMNDA")
                    drResumenSinRe("NRTFSV") = dr("NRTFSV")
                    drResumenSinRe("SUB_TOTAL") = dr("SUB_TOTAL")
                    drResumenSinRe("SERVICIO") = dr("SERVICIO").ToString.Replace("'", "")
                    drResumenSinRe("TCMTRF") = dr("TCMTRF").ToString.Replace("'", "")
                    drResumenSinRe("IVLSRV") = dr("IVLSRV")
                    drResumenSinRe("QATNAN") = dr("QATNAN")
                    drResumenSinRe("FOPRCN") = dr("FOPRCN")
                    drResumenSinRe("TRDCCL") = dr("TRDCCL")
                    drResumenSinRe("TRFSRC") = dr("TRFSRC")

                    oDtResumenSinReemAlmacen.Rows.Add(drResumenSinRe)
                Next


                For Each dr As DataRow In oDtDetalleConReem.Rows

                    blExisteAlmacenConRe = False

                    For Each drAux As DataRow In oDtResumenConReemAlmacen.Select("TCMPCL='" & dr("TCMPCL") & _
                                                                         "' and NOPRCN='" & dr("NOPRCN") & _
                                                                         "' and TMNDA='" & dr("TMNDA") & _
                                                                         "' and NRTFSV=" & dr("NRTFSV") & _
                                                                         "  and SERVICIO='" & dr("SERVICIO").ToString.Replace("'", "") & _
                                                                         "' and TCMTRF='" & dr("TCMTRF").ToString.Replace("'", "") & _
                                                                         "' and IVLSRV=" & dr("IVLSRV") & _
                                                                         "  and QATNAN=" & dr("QATNAN"))
                        blExisteAlmacenConRe = True
                    Next

                    If blExisteAlmacenConRe Then Continue For

                    drResumenConRe = oDtResumenConReemAlmacen.NewRow

                    drResumenConRe("TCMPCL") = dr("TCMPCL")
                    drResumenConRe("TCMPCL") = dr("TCMPCL")
                    drResumenConRe("NOPRCN") = dr("NOPRCN")
                    drResumenConRe("TMNDA") = dr("TMNDA")
                    drResumenConRe("NRTFSV") = dr("NRTFSV")
                    drResumenConRe("SUB_TOTAL") = dr("SUB_TOTAL")
                    drResumenConRe("SERVICIO") = dr("SERVICIO").ToString.Replace("'", "")
                    drResumenConRe("TCMTRF") = dr("TCMTRF").ToString.Replace("'", "")
                    drResumenConRe("IVLSRV") = dr("IVLSRV")
                    drResumenConRe("QATNAN") = dr("QATNAN")
                    drResumenConRe("TIPRO") = dr("TIPRO")
                    oDtResumenConReemAlmacen.Rows.Add(drResumenConRe)
                Next

                oDtDetalleSinReem = oDtResumenSinReemAlmacen
                oDtDetalleConReem = oDtResumenConReemAlmacen


                If oDtDetalleConReem.Columns("TRANSPORTE") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TRANSPORTE")
                If oDtDetalleConReem.Columns("DESPACHO") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("DESPACHO")
                If oDtDetalleConReem.Columns("REGIMEN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("REGIMEN")
                If oDtDetalleConReem.Columns("FORSCI") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FORSCI")
                If oDtDetalleConReem.Columns("FAPRAR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FAPRAR")
                If oDtDetalleConReem.Columns("TCMPVP") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCMPVP")
                If oDtDetalleConReem.Columns("TCMPPS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCMPPS")
                If oDtDetalleConReem.Columns("CPAIS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CPAIS")
                If oDtDetalleConReem.Columns("CMEDTR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CMEDTR")
                If oDtDetalleConReem.Columns("TCANAL") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCANAL")
                If oDtDetalleConReem.Columns("TNRODU") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TNRODU")
                If oDtDetalleConReem.Columns("PNNMOS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("PNNMOS")
                If oDtDetalleConReem.Columns("TZNFCC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TZNFCC")
                If oDtDetalleConReem.Columns("CZNFCC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CZNFCC")
                If oDtDetalleConReem.Columns("NDOCEM") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NDOCEM")
                If oDtDetalleConReem.Columns("NORSCI") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NORSCI")
                If oDtDetalleConReem.Columns("FAPREV") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FAPREV")
                If oDtDetalleConReem.Columns("TRANSPORTE") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TRANSPORTE")
                If oDtDetalleConReem.Columns("DESPACHO") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("DESPACHO")
                If oDtDetalleConReem.Columns("REGIMEN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("REGIMEN")
                If oDtDetalleConReem.Columns("FORSCI") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FORSCI")
                If oDtDetalleConReem.Columns("FAPRAR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FAPRAR")
                If oDtDetalleConReem.Columns("TCMPVP") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCMPVP")
                If oDtDetalleConReem.Columns("TCMPPS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCMPPS")
                If oDtDetalleConReem.Columns("CPAIS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CPAIS")
                If oDtDetalleConReem.Columns("CMEDTR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CMEDTR")
                If oDtDetalleConReem.Columns("TCANAL") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TCANAL")
                If oDtDetalleConReem.Columns("TNRODU") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TNRODU")
                If oDtDetalleConReem.Columns("PNNMOS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("PNNMOS")
                If oDtDetalleConReem.Columns("TZNFCC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TZNFCC")
                If oDtDetalleConReem.Columns("CZNFCC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CZNFCC")
                If oDtDetalleConReem.Columns("NDOCEM") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NDOCEM")
                If oDtDetalleConReem.Columns("NORSCI") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NORSCI")
                If oDtDetalleConReem.Columns("FAPREV") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("FAPREV")


                Dim intLinea As Integer = 0

                With oDtDetalleSinReem
                    .Columns("TCMPCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TRDCCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TIPRO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NRTFSV").SetOrdinal(intLinea)
                    intLinea += 1

                    .Columns("SERVICIO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TCMTRF").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FATNSR").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("IVLSRV").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("QATNAN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("SUB_TOTAL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TMNDA").SetOrdinal(intLinea)
                    intLinea += 1
                End With

                With oDtDetalleConReem
                    .Columns("TCMPCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FOPRCN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TRDCCL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TIPRO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("NRTFSV").SetOrdinal(intLinea)
                    intLinea += 1

                    .Columns("SERVICIO").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TCMTRF").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("FATNSR").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("IVLSRV").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("QATNAN").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("SUB_TOTAL").SetOrdinal(intLinea)
                    intLinea += 1
                    .Columns("TMNDA").SetOrdinal(intLinea)
                    intLinea += 1
                End With

                With oDtDetalleSinReem
                    .Columns("TCMPCL").ColumnName = "Cliente"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("FOPRCN").ColumnName = "Fecha Operación"
                    .Columns("TRDCCL").ColumnName = "Referencia Operación"
                    .Columns("TIPRO").ColumnName = "Proceso"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SERVICIO").ColumnName = "Servicio-Rubro"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("FATNSR").ColumnName = "Fecha servicio"
                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("QATNAN").ColumnName = "Cantidad"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"


                End With


                With oDtDetalleConReem
                    .Columns("TCMPCL").ColumnName = "Cliente"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("FOPRCN").ColumnName = "Fecha Operación"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("SERVICIO").ColumnName = "Servicio-Rubro"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("FATNSR").ColumnName = "Fecha servicio"
                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("QATNAN").ColumnName = "Cantidad"
                    .Columns("TRDCCL").ColumnName = "Referencia Operación"
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                    .Columns("TIPRO").ColumnName = "Proceso"
                End With



                oDtDetalleSinReem.TableName = "Servicio Sin Reembolso"
                oDtDetalleConReem.TableName = "Servicio Reembolso"

                If oDtDetalleSinReem.Columns("QATNRL") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QATNRL")
                If oDtDetalleSinReem.Columns("SESTRG_SERV") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("SESTRG_SERV")
                If oDtDetalleSinReem.Columns("LOTE") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("LOTE")
                If oDtDetalleSinReem.Columns("CI") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CI")
                If oDtDetalleSinReem.Columns("OC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("OC")
                If oDtDetalleSinReem.Columns("CREFFW") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CREFFW")
                If oDtDetalleSinReem.Columns("TCTCST") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TCTCST")
                If oDtDetalleSinReem.Columns("TCTCSA") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TCTCSA")
                If oDtDetalleSinReem.Columns("TCTCSF") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TCTCSF")
                If oDtDetalleSinReem.Columns("NCRRDC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NCRRDC")
                If oDtDetalleSinReem.Columns("QPRDFC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QPRDFC")
                If oDtDetalleSinReem.Columns("NDIAPL") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NDIAPL")
                If oDtDetalleSinReem.Columns("DESCWB") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("DESCWB")
                If oDtDetalleSinReem.Columns("TUBRFR") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TUBRFR")
                If oDtDetalleSinReem.Columns("QREFFW") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QREFFW")
                If oDtDetalleSinReem.Columns("TIPBTO") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TIPBTO")
                If oDtDetalleSinReem.Columns("QPSOBL") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QPSOBL")
                If oDtDetalleSinReem.Columns("TUNPSO") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TUNPSO")
                If oDtDetalleSinReem.Columns("QVLBTO") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QVLBTO")
                If oDtDetalleSinReem.Columns("TUNVOL") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TUNVOL")
                If oDtDetalleSinReem.Columns("QAROCP") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QAROCP")
                If oDtDetalleSinReem.Columns("NSRCN1") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NSRCN1")
                If oDtDetalleSinReem.Columns("CPRCN1") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CPRCN1")
                If oDtDetalleSinReem.Columns("TSRVC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TSRVC")
                If oDtDetalleSinReem.Columns("NORAGN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NORAGN")
                If oDtDetalleSinReem.Columns("FREFFW") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("FREFFW")

        End Select

        oDtDetalleConReem = GeneraCargoPlanDetalle(oDtDetalleConReem)
        '---------------------------------SIN REEMBOLSO-----------------------------------------'
        If oDtDetalleSinReem.Columns("Cliente") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("Cliente")
        If oDtDetalleSinReem.Columns("CCLNT") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CCLNT")
        'If oDtDetalle.Columns("FOPRCN") IsNot Nothing Then oDtDetalle.Columns.Remove("FOPRCN")
        'If oDtDetalle.Columns("FATNSR") IsNot Nothing Then oDtDetalle.Columns.Remove("FATNSR")
        If oDtDetalleSinReem.Columns("ALMACEN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("ALMACEN")
        If oDtDetalleSinReem.Columns("Nro Secuencia") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("Nro Secuencia")


        If oDtDetalleSinReem.Columns("CCMPN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CCMPN")
        If oDtDetalleSinReem.Columns("CDVSN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CDVSN")
        If oDtDetalleSinReem.Columns("NSECFC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NSECFC")
        If oDtDetalleSinReem.Columns("SESTRG") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("SESTRG")
        If oDtDetalleSinReem.Columns("NCRROP") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NCRROP")
        If oDtDetalleSinReem.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TIPO_CAMBIO")
        If oDtDetalleSinReem.Columns("NSLCSR") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NSLCSR")
        If oDtDetalleSinReem.Columns("NGUITR") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NGUITR")
        If oDtDetalleSinReem.Columns("CTRMNC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("CTRMNC")
        If oDtDetalleSinReem.Columns("COD") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("COD")

        If oDtDetalleSinReem.Columns("VALCTE") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("VALCTE")
        If oDtDetalleSinReem.Columns("ITPCMT") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("ITPCMT")
        If oDtDetalleSinReem.Columns("TOBS") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TOBS")



        '---------------------------------REEMBOLSO-----------------------------------------'
        If oDtDetalleConReem.Columns("Cliente") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("Cliente")
        If oDtDetalleConReem.Columns("CCLNT") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CCLNT")
        'If oDtDetalle.Columns("FOPRCN") IsNot Nothing Then oDtDetalle.Columns.Remove("FOPRCN")
        'If oDtDetalle.Columns("FATNSR") IsNot Nothing Then oDtDetalle.Columns.Remove("FATNSR")
        If oDtDetalleConReem.Columns("ALMACEN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("ALMACEN")
        If oDtDetalleConReem.Columns("Nro Secuencia") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("Nro Secuencia")


        If oDtDetalleConReem.Columns("CCMPN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CCMPN")
        If oDtDetalleConReem.Columns("CDVSN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CDVSN")
        If oDtDetalleConReem.Columns("NSECFC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NSECFC")
        If oDtDetalleConReem.Columns("SESTRG") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("SESTRG")
        If oDtDetalleConReem.Columns("NCRROP") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NCRROP")
        If oDtDetalleConReem.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TIPO_CAMBIO")
        If oDtDetalleConReem.Columns("NSLCSR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NSLCSR")
        If oDtDetalleConReem.Columns("NGUITR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NGUITR")
        If oDtDetalleConReem.Columns("CTRMNC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("CTRMNC")
        If oDtDetalleConReem.Columns("COD") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("COD")

        If oDtDetalleConReem.Columns("VALCTE") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("VALCTE")
        If oDtDetalleConReem.Columns("ITPCMT") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("ITPCMT")
        If oDtDetalleConReem.Columns("TOBS") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TOBS")

        'If Not obj_Servicio.CTPALJ = "RE" And Not chkDetallado.Checked Then

        If oDtDetalleSinReem.Columns("NRITOC") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NRITOC")
        If oDtDetalleSinReem.Columns("TDITES") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TDITES")
        If oDtDetalleSinReem.Columns("TLUGEN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("TLUGEN")
        If oDtDetalleSinReem.Columns("QBLTSR") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("QBLTSR")
        If oDtDetalleSinReem.Columns("NSEQIN") IsNot Nothing Then oDtDetalleSinReem.Columns.Remove("NSEQIN")

        If oDtDetalleConReem.Columns("NRITOC") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NRITOC")
        If oDtDetalleConReem.Columns("TDITES") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TDITES")
        If oDtDetalleConReem.Columns("TLUGEN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("TLUGEN")
        If oDtDetalleConReem.Columns("QBLTSR") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("QBLTSR")
        If oDtDetalleConReem.Columns("NSEQIN") IsNot Nothing Then oDtDetalleConReem.Columns.Remove("NSEQIN")
        'End If




        odsExcelSinReem.Tables.Add(oDtDetalleSinReem.Copy)
        odsExcelSinReem.Tables.Add(oDtFiltroSinReem.Copy)
        odsExcelSinReem.Tables.Add(oDtResumenSinReem.Copy)
        odsExcelSinReem.Tables.Add(oDtResLoteSinReem.Copy)

        odsExcelConReem.Tables.Add(oDtDetalleConReem.Copy)
        odsExcelConReem.Tables.Add(oDtFiltroConReem.Copy)
        odsExcelConReem.Tables.Add(oDtResumenConReem.Copy)
        odsExcelConReem.Tables.Add(oDtResLoteConReem.Copy)
        If _oServicio.CDVSN = "R" Then odsExcelConReem.Tables.Add(objDsConReem.Tables(5).Copy)

        Ransa.Utilitario.HelpClass_NPOI.ExportExcel_Consistencias(odsExcelSinReem, odsExcelConReem, IIf(oDtReemb Is Nothing, 1, 2))


    End Sub

    Private Function GeneraCargoPlanDetalle(ByVal oDt As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow

        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("Moneda").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("Monto a Cobrar"))

                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("Monto a Cobrar")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Cobrar") = TotMntDolares


                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("Monto a Cobrar") = TotMntDolares
                        drAux("Estado Facturación") = row("Estado Facturación")
                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        Return oDtAux
    End Function

    Private Function ValidaSeleccion() As Boolean
        For intCont As Integer = 0 To dtgFacturacion.Rows.Count - 1
            If Convert.ToBoolean(dtgFacturacion.Rows(intCont).Cells("chk").Value) = True Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Refrescar()
        LimpiarDetalleRevision()
        RaiseEvent Listar_Revisiones(_oServicio)
        'dtgFacturacion_CurrentCellChanged(Nothing, Nothing)
        dtgFacturacion_SelectionChanged(dtgFacturacion, Nothing)
    End Sub

    Public Sub Limpiar_Revision()

        Try
            dtgFacturacion.DataSource = Nothing
        Catch ex As Exception
            'dtgFacturacion.DataSource = Nothing
        End Try
    End Sub

    Public Sub LimpiarDetalleRevision()
        Try
            dtgOperaciones.DataSource = Nothing
        Catch ex As Exception
            'dtgOperaciones.DataSource = Nothing
        End Try

    End Sub

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgFacturacion.Rows.Count - 1
            If dtgFacturacion.Rows(intCont).Cells("chk").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)

        Dim intCont As Integer
        For intCont = 0 To dtgFacturacion.RowCount - 1
            dtgFacturacion.Rows(intCont).Cells("chk").Value = blnEstado
        Next intCont

    End Sub

    Private Function floOpercionesConCheck() As List(Of Servicio_BE)
        dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim BE_servicio As New Servicio_BE
        Dim olOperacion As New List(Of Servicio_BE)
        Dim intCOnt As Integer
        For intCOnt = 0 To dtgFacturacion.Rows.Count - 1
            If Convert.ToBoolean(dtgFacturacion.Rows(intCOnt).Cells("chk").Value) = True Then
                BE_servicio = New Servicio_BE
                BE_servicio.CCMPN = oServicio.CCMPN
                BE_servicio.CDVSN = oServicio.CDVSN

                BE_servicio.CPLNDV = dtgFacturacion.Rows(intCOnt).Cells("CPLNDV1").Value
                BE_servicio.CCLNT = dtgFacturacion.Rows(intCOnt).Cells("CCLNT").Value

                BE_servicio.NSECFC = dtgFacturacion.Rows(intCOnt).Cells("NSECFC1").Value

                BE_servicio.CMNDA1 = dtgFacturacion.Rows(intCOnt).Cells("CMNDA1").Value
                BE_servicio.TSGNMN = dtgFacturacion.Rows(intCOnt).Cells("TSGNMN").Value

                BE_servicio.CRGVTA = dtgFacturacion.Rows(intCOnt).Cells("CRGVTA").Value
                BE_servicio.CCLNFC = dtgFacturacion.Rows(intCOnt).Cells("CCLNFC").Value
                BE_servicio.TCMPDV = dtgFacturacion.Rows(intCOnt).Cells("TCMPDV").Value
                BE_servicio.TIPO = "1"
                olOperacion.Add(BE_servicio)
            End If

        Next intCOnt
        Return olOperacion
    End Function

    Private Sub ObtenerFiltroReporte(ByRef valor_igv As Decimal)
        Dim obj_Logica As New clsConsistencia_BL

        oServicio.FULTAC = Format(Now, "yyyyMMdd")

        oServicio.CPLNDV = dtgFacturacion.CurrentRow.Cells("CPLNDV1").Value

        valor_igv = obj_Logica.Obtener_igv_actual(oServicio)


    End Sub

    Private Function ObtenerTipoServicio(ByVal NSECFC As String, ByVal bolConsulta As Boolean) As String
        Dim CTPALJ As String = String.Empty
        Dim oDtOperaciones As New DataTable
        Dim oDtOperacionesConsulta As New DataTable
        oDtOperaciones = CType(dtgOperaciones.DataSource, DataTable)

        If bolConsulta Then
            oServicio.NSECFC = NSECFC
            oServicio.FECINI = 0
            oServicio.FECFIN = 99999999
            oServicio.CTPALJ = "0"
            oDtOperacionesConsulta = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)
            If oDtOperacionesConsulta.Rows.Count > 0 Then CTPALJ = oDtOperacionesConsulta.Rows(0).Item("CTPALJ")
        Else
            For Each dr As DataRow In oDtOperaciones.Select("NSECFC=" & NSECFC)
                CTPALJ = dr("CTPALJ")
                Exit For
            Next
        End If

        Return CTPALJ
    End Function

    Private Sub ObtenerNrosRevisionExpExcel(ByVal ListRevision1 As List(Of Servicio_BE), ByRef strMensaje As String)

        Dim BeServicio As Servicio_BE

        dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For intCont As Integer = 0 To dtgFacturacion.Rows.Count - 1
            If Convert.ToBoolean(dtgFacturacion.Rows(intCont).Cells("chk").Value) = True Then

                BeServicio = New Servicio_BE

                'BeServicio.STPODP = dtgFacturacion.Rows(intCont).Cells("STPODP").Value
                BeServicio.NSECFC = dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value
                'BeServicio.CPLNDV = dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value
                'BeServicio.CTPALJ = ObtenerTipoServicio(dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value, True)
                ListRevision1.Add(BeServicio)
                'nCount += 1
            End If
        Next
    End Sub

    Private Function Lista_NrosRevision() As String
        Dim strNrosRevision As String = ""

        For intCont As Integer = 0 To dtgFacturacion.Rows.Count - 1
            If Convert.ToBoolean(dtgFacturacion.Rows(intCont).Cells("chk").Value) = True Then
                strNrosRevision += dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value & ","
            End If
        Next

        If strNrosRevision <> "" Then strNrosRevision = strNrosRevision.Trim.Substring(0, strNrosRevision.Trim.Length - 1)
        Return strNrosRevision
    End Function

    Private Sub ObtenerNroRevision(ByVal ListRevision As List(Of Servicio_BE), ByRef strMensaje As String)

        Dim CTPALJ As String = String.Empty
        Dim CTPALJ2 As String = String.Empty

        Dim PLANTA1 As String = String.Empty
        Dim PLANTA2 As String = String.Empty

        Dim ALMACENAJE1 As String = String.Empty
        Dim ALMACENAJE2 As String = String.Empty

        Dim nCount As Integer = 0
        Dim BeServicio As Servicio_BE

        dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For intCont As Integer = 0 To dtgFacturacion.Rows.Count - 1
            If Convert.ToBoolean(dtgFacturacion.Rows(intCont).Cells("chk").Value) = True Then

                BeServicio = New Servicio_BE
                If nCount = 0 Then
                    CTPALJ = ObtenerTipoServicio(dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value, True)
                    oServicio.CTPALJ = CTPALJ

                    PLANTA1 = dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value

                    ALMACENAJE1 = dtgFacturacion.Rows(intCont).Cells("STPODP").Value

                Else
                    CTPALJ2 = ObtenerTipoServicio(dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value, True)
                    PLANTA2 = dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value
                    ALMACENAJE2 = dtgFacturacion.Rows(intCont).Cells("STPODP").Value
                End If

                If CTPALJ = "RE" Or CTPALJ2 = "RE" Then
                    If CTPALJ <> CTPALJ2 And nCount > 0 Then
                        strMensaje = "Las Operaciones de Reembolso deben ir juntas"
                        ListRevision = New List(Of Servicio_BE)
                        Exit For
                    End If
                End If

                If ALMACENAJE1 <> ALMACENAJE2 And nCount > 0 Then
                    strMensaje = "Los Almacenajes deben de ir juntos"
                    ListRevision = New List(Of Servicio_BE)
                    Exit For
                End If

                BeServicio.STPODP = dtgFacturacion.Rows(intCont).Cells("STPODP").Value
                BeServicio.NSECFC = dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value
                BeServicio.CPLNDV = dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value
                BeServicio.CTPALJ = ObtenerTipoServicio(dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value, True)
                ListRevision.Add(BeServicio)
                nCount += 1
            End If
        Next

    End Sub

    Private Sub ExportarReporteRevision(ByVal strTipo As String)
        If dtgFacturacion.Rows.Count = 0 Then Exit Sub


        Try
            Dim tipo_cambio As Decimal = Val("" & lblTipoCambio_1.Text & "")
            Dim valor_igv As Decimal = 0
            Dim strMensaje As String = String.Empty
            Dim ListRevision As New List(Of Servicio_BE)

            ObtenerNroRevision(ListRevision, strMensaje)

            If strMensaje.Length > 0 Then
                MessageBox.Show(strMensaje, "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                ObtenerFiltroReporte(valor_igv)

                If ListRevision.Count = 0 Then
                    MessageBox.Show("No ha seleccionado ningún registro", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If


            oServicioOpeNeg.pExportarConsistenciaRevisionExcel(oServicio, tipo_cambio, valor_igv, strTipo, strMensaje, True, ListRevision)

            If strMensaje.Length > 0 Then
                MessageBox.Show(strMensaje, "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    'Private Sub BoletaResumidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaResumidaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Boleta(floOpercionesConCheck, 1)
    'End Sub

    'Private Sub BoletaDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaDetalladaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Boleta(floOpercionesConCheck, 2)
    'End Sub


    'Private Function fblnValidarProvision(ByVal olstServicio As List(Of Servicio_BE)) As Boolean
    '    Dim intResultado As Integer = 0
    '    'Dim intCont As Integer = 0

    '    For Each obeServicio As Servicio_BE In olstServicio
    '        intResultado = oServicioOpeNeg.intTieneProvision(obeServicio)
    '        Select Case intResultado
    '            Case 0
    '                Ransa.Utilitario.HelpClass.ErrorMsgBox()
    '            Case 2
    '                'Validamos si el Usuario tiene permiso para Anular la provisión
    '                Try
    '                    If oServicioOpeNeg.fblnUsuarioPermitidoRevertirProvision(Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName) Then
    '                        If obeServicio.TIPO_REV = "1" Then
    '                            If MsgBox("La Revisión :" & obeServicio.NSECFC & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                                Return True
    '                                Me.Cursor = System.Windows.Forms.Cursors.Default
    '                                Return True
    '                            End If
    '                        Else
    '                            If MsgBox("La Operación :" & obeServicio.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                                Me.Cursor = System.Windows.Forms.Cursors.Default
    '                                Return True
    '                            End If
    '                        End If
    '                    Else
    '                        'Usuario No puede Generar un revisado o Eliminar la provisión
    '                        MsgBox("Usted no tiene  autorización para administrar la operación :" & obeServicio.NOPRCN & " porque se encuentra provisionada.")
    '                        Return True
    '                    End If
    '                Catch ex As Exception
    '                    Ransa.Utilitario.HelpClass.ErrorMsgBox()
    '                    Return True
    '                End Try
    '        End Select
    '    Next


    '    Return False
    'End Function

#Region "Facturacion-ELectronica"

    Private Sub FacturaResumidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaResumidaToolStripMenuItem.Click
        If oServicio.CCLNT = 0 Then
            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim olOperacion As New List(Of Servicio_BE)
        RaiseEvent FacturarElectrinica(floOpercionesConCheck, 1, Ransa.Utilitario.HelpClass.TipoLista.CONSISTENCIA)
        Refrescar()

    End Sub

    Private Sub FacturaDetalladaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDetalladaToolStripMenuItem1.Click
        If oServicio.CCLNT = 0 Then
            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim olOperacion As New List(Of Servicio_BE)
        RaiseEvent FacturarElectrinica(floOpercionesConCheck, 2, Ransa.Utilitario.HelpClass.TipoLista.CONSISTENCIA)
        Refrescar()
    End Sub


    'Private Sub BoletaResumidaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaResumidaToolStripMenuItem1.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent BoletaElectronica(floOpercionesConCheck, 1)
    'End Sub


    'Private Sub BoletaDetalladaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaDetalladaToolStripMenuItem1.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent BoletaElectronica(floOpercionesConCheck, 2)
    'End Sub


#End Region

    'Private Sub ParteTransResumidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParteTransResumidaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If
    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent ParteTransferencia(floOpercionesConCheck, 1)

    'End Sub

    'Private Sub ParteTransDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParteTransDetalladaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent ParteTransferencia(floOpercionesConCheck, 2)
    'End Sub


    'Private Sub dtgFacturacion_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFacturacion.CurrentCellChanged
    '    Try
    '        If dtgFacturacion.Rows.Count = 0 Then Exit Sub
    '        RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dtgFacturacion_SelectionChanged(sender As Object, e As EventArgs) Handles dtgFacturacion.SelectionChanged
        Try
            If dtgFacturacion.Rows.Count = 0 Then Exit Sub
            RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub tbnAsignarDocCliente_Click(sender As Object, e As EventArgs) Handles tbnAsignarDocCliente.Click
    '    Try

    '        Dim oListServicioCheck As New List(Of Servicio_BE)
    '        oListServicioCheck = floOpercionesConCheck()
    '        If oListServicioCheck.Count > 0 Then
    '            Dim strCosistencia As String = ""
    '            For Each item As Servicio_BE In oListServicioCheck
    '                strCosistencia = strCosistencia & "," & item.NSECFC
    '            Next
    '            strCosistencia = strCosistencia.Substring(1)
    '            Dim ofrmEditDocSubDocCliente As New frmEditDocSubDocCliente
    '            ofrmEditDocSubDocCliente.pCCLNT = oListServicioCheck(0).CCLNT
    '            ofrmEditDocSubDocCliente.pListConsistencia = strCosistencia
    '            ofrmEditDocSubDocCliente.pCCMPN = oListServicioCheck(0).CCMPN
    '            ofrmEditDocSubDocCliente.pCDVSN = oListServicioCheck(0).CDVSN
    '            If ofrmEditDocSubDocCliente.ShowDialog() = DialogResult.OK Then
    '                RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
    '            End If
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub btnLimpiarDocCliente_Click(sender As Object, e As EventArgs) Handles btnLimpiarDocCliente.Click
    '    Try

    '        Dim oListServicioCheck As New List(Of Servicio_BE)
    '        oListServicioCheck = floOpercionesConCheck()
    '        If oListServicioCheck.Count > 0 Then

    '            If MessageBox.Show("Está seguro de quitar el documento asignado?", "Aviso", MessageBoxButtons.YesNo) = DialogResult.No Then
    '                Exit Sub
    '            End If

    '            Dim oclsServicio_BL As New clsServicio_BL
    '            Dim objParam As New Hashtable
    '            Dim user As String = ""
    '            Dim terminal As String = ""
    '            Dim strCosistencia As String = ""
    '            For Each item As Servicio_BE In oListServicioCheck
    '                strCosistencia = strCosistencia & "," & item.NSECFC
    '            Next
    '            strCosistencia = strCosistencia.Substring(1)

    '            user = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
    '            terminal = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server
    '            oclsServicio_BL.QuitarDocumentoAprobacionCliente(oListServicioCheck(0).CCMPN, oListServicioCheck(0).CCLNT, strCosistencia, user, terminal)
    '            RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private cOrgVenta As String = ""
    Private dOrgVenta As String = ""
   

    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
        For lint_Contador As Integer = 0 To Sender.RowCount - 1
           
            If Sender.Item("chk", lint_Contador).Value = "S" Then
                If intIndice = 0 Then
                    cOrgVenta = Sender.Item("CRGVTA_D", lint_Contador).Value
                    dOrgVenta = Sender.Item("TCRVTA_D", lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Sender.Item("CRGVTA_D", lint_Contador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If

        Next
        Return lstr_Estado
    End Function

    Private Sub btnPreLiquidar_Click(sender As Object, e As EventArgs) Handles btnPreLiquidar.Click
     
         
       
        Try
            If dtgFacturacion.RowCount = 0 Then Exit Sub

            

            Dim objEntidad As New PreLiquidar_BE 'Factura_Transporte
            Dim objGenericCollection As New List(Of PreLiquidar_BE)
            Dim objfrmPreLiquidar As New frmPreLiquidar
            Me.dtgFacturacion.EndEdit()
            Dim Region As String = ""
            Dim ClienteFac As Decimal = 0
            Dim Fila As Int64 = 0
            Dim Moneda As String = ""

            For Each row As DataGridViewRow In dtgFacturacion.Rows

                If row.Cells("chk").Value = True Then


                    If Fila = 0 Then
                        Region = ("" & row.Cells("CRGVTA").Value).ToString.Trim
                        ClienteFac = row.Cells("CCLNFC").Value
                        Moneda = ("" & row.Cells("TSGNMN").Value).ToString.Trim
                    End If
                    If Region <> ("" & row.Cells("CRGVTA").Value).ToString.Trim Then
                        MessageBox.Show("Los registros seleccionados deben tener mismo Negocio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    End If
                    If ClienteFac <> row.Cells("CCLNFC").Value Then
                        MessageBox.Show("Los registros seleccionados deben tener mismo Cliente Fac.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    End If
                    If Moneda <> ("" & row.Cells("TSGNMN").Value).ToString.Trim Then
                        MessageBox.Show("Los registros seleccionados deben tener misma moneda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    End If

                    If row.Cells("NPRELIQ").Value <> 0 Then
                        MessageBox.Show("Uno de los registros tiene PL.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

 

                    objEntidad = New PreLiquidar_BE
                    objEntidad.NSECFC = row.Cells("NSECFC1").Value
                    objEntidad.TOTAL1 = row.Cells("TOTAL1").Value
                    objEntidad.TSGNMN = row.Cells("TSGNMN").Value
                    objEntidad.FSECFC = row.Cells("FSECFC").Value
                    objEntidad.TPLNTA = row.Cells("TPLNTA").Value
                    objEntidad.TCMPCL = row.Cells("TCMPCL").Value
                    objEntidad.DESCLIFAC = row.Cells("DESCLIFAC").Value
                    objEntidad.TCMPDV = row.Cells("TCMPDV").Value
                    objEntidad.CCNTCS = row.Cells("CCNTCS").Value
                    objEntidad.STPODP = row.Cells("STPODP").Value
                    objEntidad.DESSTPODP = row.Cells("DESSTPODP").Value
                    objEntidad.CRGVTA = row.Cells("CRGVTA").Value
                    objEntidad.CMNDA1 = row.Cells("CMNDA1").Value
                    objEntidad.CCLNFC = row.Cells("CCLNFC").Value
                    objEntidad.TIPO_REV = row.Cells("TIPO_REV").Value


                    objEntidad.CCMPN = oServicio.CCMPN
                    objEntidad.CDVSN = oServicio.CDVSN

                    objGenericCollection.Add(objEntidad)



                    Fila = Fila + 1

                End If


            Next
            '---------------------------------------
            
            If objGenericCollection.Count = 0 Then             
                    MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)                 
                Exit Sub
            End If

            With objfrmPreLiquidar
                .CCLNT = oServicio.CCLNT
                .CCMPN = oServicio.CCMPN
                .CDVSN = oServicio.CDVSN

                .CPLNDV = 0
             
                .CPLNDV_1 = "TODOS"
                .ListFactura_Transporte = objGenericCollection
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Refrescar()

                End If

            End With




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    '------------------------------------------------------------------------------------------------------------------

 
End Class

