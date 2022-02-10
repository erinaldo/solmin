Imports Ransa.TypeDef.Cliente
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario


Public Class frmAlcanceServiciosXCliente

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim oFrorm As New frmRegistroAlcanceServiciosXCliente
        With oFrorm
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSACTION = "ADD"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.btnBuscar.PerformClick()
            End If
        End With
    End Sub

    Private Sub frmAlcanceServiciosXCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcCompania_Cmb011.Usuario = HelpUtil.UserName
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
        txtCliente.pCargar(ClientePK)
        Cargar_Mes()
        txtAnio.Text = Now.Year
        cmbMes.SelectionStart = Now.Month
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = HelpUtil.UserName
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cargar_Mes()
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dtMes.Rows.Add(dr)

        cmbMes.Properties.DataSource = dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        cmbMes.RefreshEditValue()

        cmbMes.Properties.Items(Now.Month - 1).CheckState = CheckState.Checked

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Function ListaCodigoMeses() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbMes.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            If fblnValidaInformacion() = True Then
                Dim obrAlcanceServ As New clsAlcanceServicio
                Dim obeAlcanceServ As New beAlcanceServicio

                With obeAlcanceServ
                    .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = Me.UcDivision_Cmb011.Division
                    .PNCCLNT = Me.txtCliente.pCodigo
                    .PNNANASR = Me.txtAnio.Text
                    .PSMES = ListaCodigoMeses()
                End With
                dtgAlcanceDeServicio.AutoGenerateColumns = False
                Me.dtgAlcanceDeServicio.DataSource = obrAlcanceServ.flistListarAlcanceServicioXClientexAnio(obeAlcanceServ)
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub


    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If Me.txtCliente.pCodigo = 0 Then
            strMensajeError &= "Debe seleccionar cliente. " & vbNewLine
        End If
        If txtAnio.Text.ToString.Trim = "" Or Val(txtAnio.Text) < 2000 Then
            strMensajeError &= "Debe ingresar un año válido. " & vbNewLine
        End If
        If cmbMes.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub dtgAlcanceDeServicio_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgAlcanceDeServicio.DataBindingComplete
        For intX As Integer = 0 To Me.dtgAlcanceDeServicio.Rows.Count - 1
            Select Case Me.dtgAlcanceDeServicio.Rows(intX).Cells("NMSASR").Value
                Case 1
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Enero"
                Case 2
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Febrero"
                Case 3
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Marzo"
                Case 4
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Abril"
                Case 5
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Mayo"
                Case 6
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Junio"
                Case 7
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Julio"
                Case 8
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Agosto"
                Case 9
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Setiembre"
                Case 10
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Octubre"
                Case 11
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Noviembre"
                Case 12
                    Me.dtgAlcanceDeServicio.Rows(intX).Cells("MES").Value = "Diciembre"
            End Select

        Next
    End Sub
    Private Function CreateToEntity() As beAlcanceServicio
        Dim intIndex As Integer = dtgAlcanceDeServicio.CurrentCellAddress.Y
        Dim obeAlcanceServicio As New beAlcanceServicio
        With obeAlcanceServicio
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = dtgAlcanceDeServicio.Item("CDVSN", intIndex).Value
            .PNCCLNT = txtCliente.pCodigo
            .PNNANASR = dtgAlcanceDeServicio.Item("NANASR", intIndex).Value
            .PNNMSASR = dtgAlcanceDeServicio.Item("NMSASR", intIndex).Value
            .PNNCRRLT = dtgAlcanceDeServicio.Item("NCRRLT", intIndex).Value
            .PNQMDASC = dtgAlcanceDeServicio.Item("QMDASC", intIndex).Value
            .PSTSRVC = dtgAlcanceDeServicio.Item("TSRVC", intIndex).Value
            .PSSESTRG = "A"
            .PSUSUARIO = HelpUtil.UserName
            .PSNTRMNL = Environment.MachineName
        End With
        Return obeAlcanceServicio
    End Function

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dtgAlcanceDeServicio.Rows.Count = 0 Then Exit Sub
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim objFormulario As New frmRegistroAlcanceServiciosXCliente
        With objFormulario
            .BeAlcanceServicio = CreateToEntity()
            .PSACTION = "EDIT"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.btnBuscar.PerformClick()
            End If
        End With

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dtgAlcanceDeServicio.Rows.Count = 0 Then Exit Sub
        If Me.txtCliente.pCodigo = 0 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            Dim obeAlcanceServicio As beAlcanceServicio
            Dim obrAlcanceServicio As New clsAlcanceServicio
            Dim strResult As String
            If MessageBox.Show("Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                obeAlcanceServicio = CreateToEntity()
                obeAlcanceServicio.PSSESTRG = "*"

                strResult = obrAlcanceServicio.fstrActualizarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
                If strResult.Equals("") Then
                    MessageBox.Show("Se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.btnBuscar.PerformClick()
                Else
                    MessageBox.Show("Ocurrió un error al eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
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
            itemSortedList.Add(itemSortedList.Count, "Año:|" & txtAnio.Text)
            itemSortedList.Add(itemSortedList.Count, "Mes:|" & cmbMes.Text)
            LisFiltros.Add(itemSortedList)

            dtReporteExcel.Columns.Add("TCMPDV", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("División", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("MES", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Mes", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("NCRRLT", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoNumero)
            dtReporteExcel.Columns.Add("TDALSR", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Descripción Alcance", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("QMDALS", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Indicador", NPOI_SC.keyDatoNumero)
            dtReporteExcel.Columns.Add("TABRUN", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Unidad", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TRFMED", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Ref. Medida", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("QMDASC", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Medida", NPOI_SC.keyDatoNumero)
            dtReporteExcel.Columns.Add("TFRMMD", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Forma de Medición", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TINDMD", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Indicador de Medición", NPOI_SC.keyDatoTexto)
            dtReporteExcel.Columns.Add("TSRVC", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Descripción Servicio", NPOI_SC.keyDatoTexto)

            For i As Integer = 0 To Me.dtgAlcanceDeServicio.Rows.Count - 1
                With Me.dtgAlcanceDeServicio
                    NewRow = dtReporteExcel.NewRow
                    NewRow("TCMPDV") = .Item("TCMPDV", i).Value
                    NewRow("MES") = .Item("MES", i).Value
                    NewRow("NCRRLT") = .Item("NCRRLT", i).Value
                    NewRow("TDALSR") = .Item("TDALSR", i).Value
                    NewRow("QMDALS") = .Item("QMDALS", i).Value
                    NewRow("TABRUN") = .Item("TABRUN", i).Value
                    NewRow("QMDASC") = .Item("QMDASC", i).Value
                    NewRow("TRFMED") = .Item("TRFMED", i).Value
                    NewRow("TINDMD") = .Item("TINDMD", i).Value
                    NewRow("TFRMMD") = .Item("TFRMMD", i).Value
                    NewRow("TSRVC") = .Item("TSRVC", i).Value
                    dtReporteExcel.Rows.Add(NewRow)
                End With
            Next
            oListDtReport.Add(dtReporteExcel)
            strlTitulo.Add("Reporte de Alcance de Servicios por Cliente")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo, Nothing, LisFiltros, 0)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnual.Click
        Dim objFRM As New frmVistaAnual

        objFRM.CCLNT = txtCliente.pCodigo
        objFRM.CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objFRM.CDVSN = UcDivision_Cmb011.Division

        objFRM.ShowDialog()
    End Sub

    Private Sub btnMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMensual.Click
        Dim objForm As New frmReporteAlcanceServicioMensual
        objForm.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objForm.PSCDVSN = Me.UcDivision_Cmb011.Division
        objForm.PNCCLNT = Me.txtCliente.pCodigo
        objForm.ShowDialog()
    End Sub
End Class
