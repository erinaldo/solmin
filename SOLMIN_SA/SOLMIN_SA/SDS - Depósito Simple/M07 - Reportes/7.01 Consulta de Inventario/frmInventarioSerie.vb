Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports RANSA.Utilitario
Public Class frmInventarioSerie
    Public obeMercaderia As New beMercaderia()
    Private Sub frmInventarioSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgMercaderiaGuiaDet.AutoGenerateColumns = False
            dgMercaderiaUbicacionDet.AutoGenerateColumns = False
            Me.dtgMovimientos.AutoGenerateColumns = False
            dtgKardex.AutoGenerateColumns = False
            UcPaginacion.PageNumber = 1
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub ListarSolicitudServicioxCliente()
        'Try
        Dim oblInventarioMercaderia As New blInventarioMercaderia()
        obeMercaderia.PageSize = UcPaginacion.PageSize
        obeMercaderia.PageNumber = UcPaginacion.PageNumber
        Me.dtgMovimientos.DataSource = oblInventarioMercaderia.Lista_Solicitud_Servicio_por_Cliente(obeMercaderia)
        If TryCast(dtgMovimientos.DataSource, List(Of beMercaderia)).Count > 0 Then
            UcPaginacion.PageCount = TryCast(dtgMovimientos.DataSource, List(Of beMercaderia)).Item(0).PageCount
        End If
        'Catch ex As Exception
        'End Try
     
    End Sub


    Private Sub ListaProyecto()
        Dim oListaProyecto As New beList(Of beProyecto)
        Dim objBRProyecto As New brProyecto
        Dim obeProyecto As New beProyecto
        With obeProyecto
            .PNNORDSR = obeMercaderia.PNNORDSR
        End With
        oListaProyecto = objBRProyecto.flistProyectosXOs(obeProyecto)
        dgProyecto.AutoGenerateColumns = False
        dgProyecto.DataSource = oListaProyecto
    End Sub

    Private Sub ListarLote()
        Dim obrLote As New brLote
        Dim objLote As New beLote
        With objLote
            .NORDSR = obeMercaderia.PNNORDSR
        End With
        dgvLotes.AutoGenerateColumns = False
        dgvLotes.DataSource = obrLote.ListarLotesPorOS(objLote)
    End Sub

    Private Sub dgvLotes_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLotes.CurrentCellChanged

        Try
            If dgvLotes.CurrentRow IsNot Nothing Then ' dgvLotes.RowCount > 0 Then
                Dim objLote As New beLote
                Dim obrLote As New brLote
                With objLote
                    .NORDSR = dgvLotes.CurrentRow.DataBoundItem.Row("NORDSR")
                    .NCRRIN = dgvLotes.CurrentRow.DataBoundItem.Row("NCRRIN")
                End With
                dgvUbicacionLote.AutoGenerateColumns = False
                dgvUbicacionLote.DataSource = obrLote.ListarUbicacionesPorLoteCLiente(objLote)


                Dim obeFiltro As New beMercaderia
                Dim oblInventarioMercaderia As New blInventarioMercaderia()

                With obeFiltro
                    .PNNORDSR = dgvLotes.CurrentRow.DataBoundItem.Row("NORDSR")
                    .PNNCRRIN = dgvLotes.CurrentRow.DataBoundItem.Row("NCRRIN")
                End With
                dtgMovimientoLote.AutoGenerateColumns = False
                Me.dtgMovimientoLote.DataSource = oblInventarioMercaderia.Lista_Solicitud_Servicio_por_Lote(obeFiltro)


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarSeriexOrdenServicio()
        Try
            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            dgMercaderiaGuiaDet.DataSource = oblInventarioMercaderia.ListarInventarioMercaderiaxSerie(obeMercaderia).Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Buscar()
        'Try
        dgMercaderiaGuiaDet.DataSource = Nothing
        dtgKardex.DataSource = Nothing
        dgMercaderiaUbicacionDet.DataSource = Nothing
        Me.dtgMovimientos.DataSource = Nothing
        Dim obrMercaderia As New brMercaderia
        obeMercaderia.PNNORDSR = obeMercaderia.PNNORDSR
        Me.dtgKardex.DataSource = obrMercaderia.ListaKardex(obeMercaderia)
        dgMercaderiaUbicacionDet.DataSource = New blInventarioMercaderia().ListarInventarioMercaderiaxUbicacion(obeMercaderia).Tables(0)
        ListarSeriexOrdenServicio()
        ListarSolicitudServicioxCliente()
        ListaProyecto()
        ListarLote()

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dgMercaderiaUbicacionDet_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaUbicacionDet.CellDoubleClick
        Try
            If dgMercaderiaUbicacionDet.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            Dim fila As Int32 = e.RowIndex
            If (e.ColumnIndex = 7) Then
                Dim ofrmMovimientoPosicion As New frmMovimientoPosicion()
                Dim obeAlmacen As New beAlmacen()
                obeAlmacen.PSCTPALM = ("" & dgMercaderiaUbicacionDet.Item("CTPALM", fila).Value).ToString.Trim
                obeAlmacen.PSCALMC = ("" & dgMercaderiaUbicacionDet.Item("CALMC", fila).Value).ToString.Trim
                obeAlmacen.PSCSECTR = ("" & dgMercaderiaUbicacionDet.Item("CSECTR", fila).Value).ToString.Trim
                obeAlmacen.PSCPSCN = ("" & dgMercaderiaUbicacionDet.Item("CPSCN", fila).Value).ToString.Trim
                obeAlmacen.PNNORDSR = Val("" & dgMercaderiaUbicacionDet.Item("NORDSR1", fila).Value)
                obeAlmacen.PSTNMSCT = ("" & dgMercaderiaUbicacionDet.Item("TNMSCT", fila).Value).ToString.Trim
                obeAlmacen.PSTCMZNA = ("" & dgMercaderiaUbicacionDet.Item("TCMZNA", fila).Value).ToString.Trim
                obeAlmacen.PSTALMC = ("" & dgMercaderiaUbicacionDet.Item("TCMPAL", fila).Value).ToString.Trim
                ofrmMovimientoPosicion.obeAlmacen = obeAlmacen
                ofrmMovimientoPosicion.ShowDialog(Me)
            End If
            If e.ColumnIndex = 8 Then
                Dim obeUsuario As New beUsuario()

                obeUsuario.FECHA_CREACION = ("" & dgMercaderiaUbicacionDet.Item("FCHCRT", fila).Value).ToString.Trim
                obeUsuario.FECHA_ACTUALIZACION = ("" & dgMercaderiaUbicacionDet.Item("FULTAC", fila).Value).ToString.Trim
                obeUsuario.HORA_ACTUALIZACION = ("" & dgMercaderiaUbicacionDet.Item("HULTAC", fila).Value).ToString.Trim
                obeUsuario.HORA_CREACION = ("" & dgMercaderiaUbicacionDet.Item("HRACRT", fila).Value).ToString.Trim
                obeUsuario.TERMINAL_ACTUALIZACION = ("" & dgMercaderiaUbicacionDet.Item("NTRMNL", fila).Value).ToString.Trim
                obeUsuario.TERMINAL_CREACION = ("" & dgMercaderiaUbicacionDet.Item("NTRMCR", fila).Value).ToString.Trim
                obeUsuario.USUARIO_ACTUALIZACION = ("" & dgMercaderiaUbicacionDet.Item("CULUSA", fila).Value).ToString.Trim
                obeUsuario.USUARIO_CREACION = ("" & dgMercaderiaUbicacionDet.Item("CUSCRT", fila).Value).ToString.Trim
                Dim ofrmAuditoria As New frmAuditoria
                ofrmAuditoria.obeUsuario = obeUsuario
                ofrmAuditoria.ShowDialog(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            ListarSolicitudServicioxCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Me.dtgMovimientos.RowCount > 0 Then
            Try

                Dim lstReporte As New List(Of beMercaderia)
                Dim oblInventarioMercaderia As New blInventarioMercaderia()
                Dim NPOI As New HelpClass_NPOI_SA
                Dim dtReporte As New DataTable
                Dim itemSortedList As SortedList
                Dim oListDtReport As New List(Of DataTable)
                Dim LisFiltros As New List(Of SortedList)
                Dim strlTitulo As New List(Of String)
                Dim NewRow As DataRow

                itemSortedList = New SortedList
                itemSortedList.Add(itemSortedList.Count, "Nr. Orden Servicio:| " & obeMercaderia.PNNORDSR)
                LisFiltros.Add(itemSortedList)

                obeMercaderia.PNNORDSR = obeMercaderia.PNNORDSR
                lstReporte = oblInventarioMercaderia.Lista_Solicitud_Servicio_por_Cliente_Exportar(obeMercaderia)
                With dtReporte
                    .Columns.Add("PNNSLCSR", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("Nr. Solicitud", HelpClass_NPOI_SA.keyDatoNumero)
                    .Columns.Add("PSTABTRF", Type.GetType("System.String")).Caption = NPOI.FormatDato("Tipo Movimiento", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PSFECHA", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PS_DESTIPO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Tipo Almacén", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PS_DESALM", Type.GetType("System.String")).Caption = NPOI.FormatDato("Almacén", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PNCANTIDAD", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("Cantidad", HelpClass_NPOI_SA.keyDatoNumero)
                    .Columns.Add("PSCUNCN6", Type.GetType("System.String")).Caption = NPOI.FormatDato("Unidad Cantidad", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PNPESO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("Peso", HelpClass_NPOI_SA.keyDatoNumero)
                    .Columns.Add("PSCUNPS6", Type.GetType("System.String")).Caption = NPOI.FormatDato("Unidad Peso", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PNNGUIRN", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("Nr. Guía", HelpClass_NPOI_SA.keyDatoNumero)
                    .Columns.Add("PNNGUIRM", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("Nr. Guía Remisión", HelpClass_NPOI_SA.keyDatoNumero)
                    .Columns.Add("PSNGUICL", Type.GetType("System.String")).Caption = NPOI.FormatDato("Nr. Guía Cliente", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PSNRFRPD", Type.GetType("System.String")).Caption = NPOI.FormatDato("Nr. Referencia", HelpClass_NPOI_SA.keyDatoTexto)
                    .Columns.Add("PSNORCCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("Orden Compra", HelpClass_NPOI_SA.keyDatoTexto)
                End With

                For Indice As Integer = 0 To lstReporte.Count - 1
                    NewRow = dtReporte.NewRow
                    NewRow("PNNSLCSR") = lstReporte(Indice).PNNSLCSR
                    NewRow("PSTABTRF") = lstReporte(Indice).PSTABTRF
                    NewRow("PSFECHA") = lstReporte(Indice).PSFECHA
                    NewRow("PS_DESTIPO") = lstReporte(Indice).PSDESTIPO
                    NewRow("PS_DESALM") = lstReporte(Indice).PSDESALM
                    NewRow("PNCANTIDAD") = lstReporte(Indice).PNCANTIDAD
                    NewRow("PSCUNCN6") = lstReporte(Indice).PSCUNCN6
                    NewRow("PNPESO") = lstReporte(Indice).PNPESO
                    NewRow("PSCUNPS6") = lstReporte(Indice).PSCUNPS6
                    NewRow("PNNGUIRN") = lstReporte(Indice).PNNGUIRN
                    NewRow("PNNGUIRM") = lstReporte(Indice).PNNGUIRM
                    NewRow("PSNGUICL") = lstReporte(Indice).PSNGUICL
                    NewRow("PSNRFRPD") = lstReporte(Indice).PSNRFRPD
                    NewRow("PSNORCCL") = lstReporte(Indice).PSNORCCL
                    dtReporte.Rows.Add(NewRow)
                Next
                oListDtReport.Add(dtReporte)
                strlTitulo.Add("Movimiento de Orden de Servicio")
                NPOI.ExportExcelGeneralMultiple(oListDtReport, strlTitulo, Nothing, LisFiltros, Nothing)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        If TabControl.SelectedIndex <> 0 Then
            btnExportar.Visible = False
        Else
            btnExportar.Visible = True
        End If


    End Sub

    Private Sub hgMercaderia_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hgMercaderia.Paint

    End Sub

    Private Sub hgMercaderia_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hgMercaderia.Panel.Paint

    End Sub
End Class

