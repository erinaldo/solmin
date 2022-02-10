Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Public Class frmMantAlcanceServicios
  
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim oFormulario As New frmRegistroAlcanceServicios
        oFormulario.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
        oFormulario.PSCDVSN = Me.UcDivision_Cmb011.Division
        oFormulario.PNCCLNT = Me.txtCliente.pCodigo
        oFormulario.PSACTION = "ADD"
        If oFormulario.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ListarAlcanceServicio()
        End If
    End Sub

    Private Sub frmMantAlcanceServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCliente.pAccesoPorUsuario = True
        txtCliente.pRequerido = True
        txtCliente.pUsuario = HelpUtil.UserName
        UcCompania_Cmb011.Usuario = HelpUtil.UserName
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = HelpUtil.UserName
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarAlcanceServicio()
    End Sub
    Private Sub ListarAlcanceServicio()
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim obrAlcanceServicio As New clsAlcanceServicio
        Dim obeAlcanceServicio As New beAlcanceServicio
        Me.dtgDatos.AutoGenerateColumns = False
        obeAlcanceServicio.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
        obeAlcanceServicio.PSCDVSN = Me.UcDivision_Cmb011.Division
        obeAlcanceServicio.PNCCLNT = Me.txtCliente.pCodigo
        Me.dtgDatos.DataSource = obrAlcanceServicio.flistListarAlcanceServicioXCliente(obeAlcanceServicio)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dtgDatos.Rows.Count = 0 Then Exit Sub
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim oFormulario As New frmRegistroAlcanceServicios
        oFormulario.BeAlcanceServicio = CreateToEntity()
        oFormulario.PSACTION = "EDIT"
        If oFormulario.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ListarAlcanceServicio()
        End If
    End Sub
    Private Function CreateToEntity() As beAlcanceServicio
        Dim intIndex As Integer = dtgDatos.CurrentCellAddress.Y
        Dim obeAlcanceServicio As New beAlcanceServicio
        obeAlcanceServicio.PSCCMPN = dtgDatos.Item("CCMPN", intIndex).Value
        obeAlcanceServicio.PSCDVSN = dtgDatos.Item("CDVSN", intIndex).Value
        obeAlcanceServicio.PNCCLNT = txtCliente.pCodigo
        obeAlcanceServicio.PSTDALSR = dtgDatos.Item("TDALSR", intIndex).Value
        obeAlcanceServicio.PSTINDMD = dtgDatos.Item("TINDMD", intIndex).Value
        obeAlcanceServicio.PNQMDALS = dtgDatos.Item("QMDALS", intIndex).Value
        obeAlcanceServicio.PSCUNDSR = dtgDatos.Item("CUNDSR", intIndex).Value
        obeAlcanceServicio.PSTFRMMD = dtgDatos.Item("TFRMMD", intIndex).Value
        obeAlcanceServicio.PSTRFMED = dtgDatos.Item("TRFMED", intIndex).Value
        obeAlcanceServicio.PNNCRRLT = dtgDatos.Item("NCRRLT", intIndex).Value
        obeAlcanceServicio.PSSESTRG = "A"
        Return obeAlcanceServicio
    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgDatos.Rows.Count = 0 Then Exit Sub
            If Me.txtCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            'If MessageBox.Show("Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim objbeAlcanceServicio As beAlcanceServicio
            Dim obrAlcanceServicio As New clsAlcanceServicio
            Dim intValida As Integer
            objbeAlcanceServicio = CreateToEntity()
            objbeAlcanceServicio.PSSESTRG = "*"
            objbeAlcanceServicio.PSUSUARIO = HelpUtil.UserName
            objbeAlcanceServicio.PSNTRMNL = Environment.MachineName
            intValida = obrAlcanceServicio.fintValidarAlcanceServicioXCliente(objbeAlcanceServicio)
            If intValida = 1 Then
                If MessageBox.Show("El Alcance de Servicio tiene relación con otros registros" & Chr(10) & "Desea anular?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If obrAlcanceServicio.fintActualizarAlcanceServicioXCliente(objbeAlcanceServicio) = 1 Then
                        MessageBox.Show("Se anuló correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ListarAlcanceServicio()
                    Else
                        MessageBox.Show("Ocurrió un error al anular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            ElseIf intValida = 0 Then
                If MessageBox.Show("Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If obrAlcanceServicio.fintActualizarAlcanceServicioXCliente(objbeAlcanceServicio) = 1 Then
                        MessageBox.Show("Se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ListarAlcanceServicio()
                    Else
                        MessageBox.Show("Ocurrió un error al eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End If
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try

            If Me.dtgDatos.Rows.Count = 0 Then
                MessageBox.Show("No existe datos para exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim dtReporteExcel As New DataTable
            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
            Dim itemSortedList As SortedList
            Dim oListDtReport As New List(Of DataTable)
            Dim LisFiltros As New List(Of SortedList)
            Dim strlTitulo As New List(Of String)
            Dim NewRow As DataRow

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Compañía:|" & UcCompania_Cmb011.CCMPN_Descripcion)
            itemSortedList.Add(itemSortedList.Count, "Divisón:|" & UcDivision_Cmb011.DivisionDescripcion)
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & txtCliente.pRazonSocial)
            LisFiltros.Add(itemSortedList)

            dtReporteExcel.Columns.Add("NCRRLT", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoNumero)
            dtReporteExcel.Columns.Add("TDALSR", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TFRMMD", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Forma Medición", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TINDMD", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Indicador Medición", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("QMDALS", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Indicador", NPOI_SC.keyDatoNumero)
            dtReporteExcel.Columns.Add("TABRUN", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Unidad", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TRFMED", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Referencia Medida", NPOI_SC.keyDatoTexto)


            For i As Integer = 0 To Me.dtgDatos.Rows.Count - 1
                With Me.dtgDatos
                    NewRow = dtReporteExcel.NewRow
                    NewRow("NCRRLT") = .Item("NCRRLT", i).Value
                    NewRow("TDALSR") = .Item("TDALSR", i).Value
                    NewRow("TFRMMD") = .Item("TFRMMD", i).Value
                    NewRow("TINDMD") = .Item("TINDMD", i).Value
                    NewRow("QMDALS") = .Item("QMDALS", i).Value
                    NewRow("TABRUN") = .Item("TABRUN", i).Value
                    NewRow("TRFMED") = .Item("TRFMED", i).Value
                    dtReporteExcel.Rows.Add(NewRow)
                End With
            Next
            oListDtReport.Add(dtReporteExcel)
            strlTitulo.Add("Reporte Alcance de Servicios")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo, Nothing, LisFiltros, 0)
        Catch ex As Exception

        End Try
    End Sub
End Class
