Imports Ransa.Utilitario
Imports System.Windows.Forms

Public Class ucMaestroIncidencias


    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pCompania As String
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)


#Region "EVENTOS"

    Sub pInicializar()

        'UcCompania_Cmb011.Visible = False
        UcCompania_Cmb012.Usuario = _pUsuario
        UcCompania_Cmb012.pActualizar()
        UcCompania_Cmb012.HabilitarCompaniaActual(_pCompania)
        Cargar_Areas()
        txtAnio.Text = Now.Year
        Lista_Inc_Para()

    End Sub

    Dim dt As DataTable

    Function Valida() As String

        Dim mensaje As String = ""

        If UcCompania_Cmb012.CCMPN_CodigoCompania = "" Then
            mensaje = mensaje & "* Seleccione una compañia" & Environment.NewLine
        End If
        If Lista_Areas().Trim = "" Then
            mensaje = mensaje & "* Seleccione una área" & Environment.NewLine
        End If
        If txtAnio.Text = "" Then
            mensaje = mensaje & "* Ingrese un año"
        End If

        Return mensaje
    End Function


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim Mensaje As String = ""

            Mensaje = Valida()
            If Mensaje.Trim.Length > 0 Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obrIncidencia As New brIncidencias
            Dim obeIncidencias As New beIncidencias
            Dim DT As New DataTable
            With obeIncidencias
                .PSCCMPN = UcCompania_Cmb012.CCMPN_CodigoCompania
                .PSCARINC = Lista_Areas()  'ListaCodigoDivisiones()
                .PNCTPINC = cmbIncPara.SelectedValue
                .ANIO = CInt(txtAnio.Text)
            End With
            dtgIncidencias.AutoGenerateColumns = False
            DT = obrIncidencia.olistListarMaestroIncidencias(obeIncidencias)
            DT.Columns.Remove("CODIGO")
            Dim dt1 As DataTable = DT.Copy

            Dim dv1 As New DataView(dt1)
            dv1.Sort = "TDARINC ASC"
            dt1 = dv1.ToTable

            Dim dtFinal As New DataTable
            Dim drFinal As DataRow

            dtFinal.Columns.Add("CCMPN", Type.GetType("System.String"))
            dtFinal.Columns.Add("CARINC", Type.GetType("System.String"))
            dtFinal.Columns.Add("CTPINC", Type.GetType("System.Decimal"))
            dtFinal.Columns.Add("TTPINC", Type.GetType("System.String"))
            dtFinal.Columns.Add("TDARINC", Type.GetType("System.String"))
            dtFinal.Columns.Add("CINCID", Type.GetType("System.Int32"))
            dtFinal.Columns.Add("TINCSI", Type.GetType("System.String"))
            dtFinal.Columns.Add("STIPPR", Type.GetType("System.String")) 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516

            dtFinal.Columns.Add("ENE", Type.GetType("System.String"))
            dtFinal.Columns.Add("FEB", Type.GetType("System.String"))
            dtFinal.Columns.Add("MAR", Type.GetType("System.String"))
            dtFinal.Columns.Add("ABR", Type.GetType("System.String"))
            dtFinal.Columns.Add("MAY", Type.GetType("System.String"))
            dtFinal.Columns.Add("JUN", Type.GetType("System.String"))
            dtFinal.Columns.Add("JUL", Type.GetType("System.String"))
            dtFinal.Columns.Add("AGO", Type.GetType("System.String"))
            dtFinal.Columns.Add("SEP", Type.GetType("System.String"))
            dtFinal.Columns.Add("OCT", Type.GetType("System.String"))
            dtFinal.Columns.Add("NOV", Type.GetType("System.String"))
            dtFinal.Columns.Add("DIC", Type.GetType("System.String"))
            dtFinal.Columns.Add("TOTAL", Type.GetType("System.Int32"))

            For Each dr As DataRow In dt1.Rows
                drFinal = dtFinal.NewRow
                drFinal("CCMPN") = dr("CCMPN")
                drFinal("CARINC") = dr("CARINC")
                drFinal("CTPINC") = dr("CTPINC")
                drFinal("TTPINC") = dr("TTPINC")
                drFinal("TDARINC") = dr("TDARINC")
                drFinal("CINCID") = dr("CINCID")
                drFinal("TINCSI") = dr("TINCSI").ToString.Trim
                drFinal("STIPPR") = dr("STIPPR").ToString.Trim 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516

                If dr("ENE").ToString.Trim = "0" Then
                    drFinal("ENE") = ""
                Else
                    drFinal("ENE") = dr("ENE").ToString.Trim
                End If
                If dr("FEB").ToString.Trim = "0" Then
                    drFinal("FEB") = ""
                Else
                    drFinal("FEB") = dr("FEB").ToString.Trim
                End If
                If dr("MAR").ToString.Trim = "0" Then
                    drFinal("MAR") = ""
                Else
                    drFinal("MAR") = dr("MAR").ToString.Trim
                End If
                If dr("ABR").ToString.Trim = "0" Then
                    drFinal("ABR") = ""
                Else
                    drFinal("ABR") = dr("ABR").ToString.Trim
                End If
                If dr("MAY").ToString.Trim = "0" Then
                    drFinal("MAY") = ""
                Else
                    drFinal("MAY") = dr("MAY").ToString.Trim
                End If
                If dr("JUN").ToString.Trim = "0" Then
                    drFinal("JUN") = ""
                Else
                    drFinal("JUN") = dr("JUN").ToString.Trim
                End If
                If dr("JUL").ToString.Trim = "0" Then
                    drFinal("JUL") = ""
                Else
                    drFinal("JUL") = dr("JUL").ToString.Trim
                End If
                If dr("AGO").ToString.Trim = "0" Then
                    drFinal("AGO") = ""
                Else
                    drFinal("AGO") = dr("AGO").ToString.Trim
                End If
                If dr("SEP").ToString.Trim = "0" Then
                    drFinal("SEP") = ""
                Else
                    drFinal("SEP") = dr("SEP").ToString.Trim
                End If
                If dr("OCT").ToString.Trim = "0" Then
                    drFinal("OCT") = ""
                Else
                    drFinal("OCT") = dr("OCT").ToString.Trim
                End If
                If dr("NOV").ToString.Trim = "0" Then
                    drFinal("NOV") = ""
                Else
                    drFinal("NOV") = dr("NOV").ToString.Trim
                End If
                If dr("DIC").ToString.Trim = "0" Then
                    drFinal("DIC") = ""
                Else
                    drFinal("DIC") = dr("DIC").ToString.Trim
                End If
                drFinal("TOTAL") = dr("TOTAL")
                dtFinal.Rows.Add(drFinal)
            Next


            Me.dtgIncidencias.DataSource = dtFinal

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UcCompania_Cmb012_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb012.SelectionChangeCommitted
        Try
            'Cargar_Divisiones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Areas()

        'Dim objDAL As New Ransa.DAO.UbicacionPlanta.Division.daoDivision
        'dt = New DataTable
        'dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, UcCompania_Cmb012.CCMPN_CodigoCompania)
        'dt.Columns.Remove("CCMPN")

        Dim dtResult As New DataTable
        Dim objBLL As New brIncidencias
        Dim dtCombo As New DataTable
        Dim dr As DataRow

        dtCombo.Columns.Add("CARINC", Type.GetType("System.String"))
        dtCombo.Columns.Add("TDARINC", Type.GetType("System.String"))

        dtResult = objBLL.Lista_Areas

        For Each fila As DataRow In dtResult.Rows
            dr = dtCombo.NewRow

            dr("CARINC") = fila("CARINC")
            dr("TDARINC") = fila("TDARINC")
            dtCombo.Rows.Add(dr)

        Next

        dr = dtCombo.NewRow
        dr("CARINC") = "0"
        dr("TDARINC") = "TODOS"
        dtCombo.Rows.InsertAt(dr, 0)
        cmbArea.DisplayMember = "TDARINC"
        cmbArea.ValueMember = "CARINC"
        cmbArea.DataSource = dtCombo
        cmbArea.SelectedValue = "0"

        dt = dtCombo.Copy

        For i As Integer = 0 To cmbArea.Items.Count - 1
            If cmbArea.Items.Item(i).Value = "0" Then
                cmbArea.SetItemChecked(i, True)
            End If
        Next

    End Sub

    Private Function Lista_Areas() As String

        Dim strCadDocumentos As String = ""
        If dt Is Nothing = True Then
            If cmbArea.CheckedItems.Count = 0 Then
                Return strCadDocumentos
            End If
        End If

        Dim valida As Boolean = False
        For i As Integer = 0 To cmbArea.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CARINC") = cmbArea.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CARINC") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbArea.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CARINC") <> "0") Then
                        strCadDocumentos += dt.Rows(j).Item("CARINC") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbArea.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CARINC") = cmbArea.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("CARINC") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos

    End Function

    Private Function Lista_Divisiones_Descripcion() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbArea.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CARINC") = cmbArea.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CARINC") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For j As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(j).Item("CARINC") <> "0" Then
                    strCadDocumentos += dt.Rows(j).Item("TDARINC") & " - "
                End If
            Next
        Else
            For i As Integer = 0 To cmbArea.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CARINC") = cmbArea.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("TDARINC") & " - "
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos


    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrmMIncidencias As New frmMIncidencias
            With ofrmMIncidencias
                .PSUSER = _pUsuario
                If Lista_Areas.Trim.Length = 1 Then
                    If Lista_Areas.Trim = "0" Then
                        .PSCARINC = "S"
                    Else
                        .PSCARINC = Lista_Areas.Trim
                    End If
                Else
                    .PSCARINC = "S"
                End If
                .PSCCMPN = UcCompania_Cmb012.CCMPN_CodigoCompania
                .PNCTPINC = cmbIncPara.SelectedValue
                .PSSTIPPR = "V"

            End With
            If ofrmMIncidencias.ShowDialog() = Windows.Forms.DialogResult.OK Then
                btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try

            If Me.dtgIncidencias.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim ofrmMIncidencias As New frmMIncidencias
            With ofrmMIncidencias
                .PSUSER = _pUsuario
                .PSCCMPN = UcCompania_Cmb012.CCMPN_CodigoCompania
                .PSCARINC = ("" & Me.dtgIncidencias.CurrentRow.Cells("CARINC").Value).ToString.Trim
                .PSTDARINC = ("" & Me.dtgIncidencias.CurrentRow.Cells("TDARINC").Value).ToString.Trim
                .PNCINCID = Me.dtgIncidencias.CurrentRow.Cells("CINCID").Value
                .PSTINCSI = ("" & Me.dtgIncidencias.CurrentRow.Cells("TINCSI").Value).ToString.Trim
                .PNCTPINC = Me.dtgIncidencias.CurrentRow.Cells("CTPINC").Value
                .PSSTIPPR = Me.dtgIncidencias.CurrentRow.Cells("STIPPR").Value
            End With
            If ofrmMIncidencias.ShowDialog() = Windows.Forms.DialogResult.OK Then
                btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgIncidencias.CurrentCellAddress.Y = -1 Then Exit Sub
            If MessageBox.Show("¿Desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            Dim obr As New brIncidencias
            Dim obe As New beIncidencias
            With obe
                .PSCCMPN = ("" & Me.dtgIncidencias.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                .PSCARINC = ("" & Me.dtgIncidencias.CurrentRow.Cells("CARINC").Value).ToString.Trim
                .PNCINCID = Me.dtgIncidencias.CurrentRow.Cells("CINCID").Value
                .PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .PSUSUARIO = _pUsuario
                .PSSESTRG = "*"
            End With
            If obr.intEliminarMaestroIncidencias(obe) = 1 Then
                'MessageBox.Show("Se eliminó el registro satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnBuscar_Click(Nothing, Nothing)
            Else
                'MessageBox.Show("No se puede eliminar, hay registro de incidencias asociadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Registro cerrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC


            If Me.dtgIncidencias.Rows.Count = 0 Then Exit Sub

            Dim dt_grilla As DataTable = Me.dtgIncidencias.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("TDARINC").Caption = NPOI_SC.FormatDato("Área", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CINCID").Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TINCSI").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("ENE", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("ENE", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("FEB", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("FEB", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("MAR", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("MAR", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("ABR", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("ABR", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("MAY", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("MAY", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("JUN", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("JUN", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("JUL", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("JUL", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("AGO", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("AGO", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("SEP", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("SEP", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("OCT", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("OCT", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("NOV", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("NOV", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("DIC", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("DIC", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TOTAL", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("TOTAL", NPOI_SC.keyDatoNumero)


            For Each INC As DataRow In dt_grilla.Rows
                dr = dtExcel.NewRow
                dr("TDARINC") = INC("TDARINC").ToString.Trim
                dr("CINCID") = INC("CINCID")
                dr("TINCSI") = INC("TINCSI").ToString.Trim

                dr("ENE") = IIf(INC("ENE") = "", DBNull.Value, INC("ENE"))
                dr("FEB") = IIf(INC("FEB") = "", DBNull.Value, INC("FEB"))
                dr("MAR") = IIf(INC("MAR") = "", DBNull.Value, INC("MAR"))
                dr("ABR") = IIf(INC("ABR") = "", DBNull.Value, INC("ABR"))
                dr("MAY") = IIf(INC("MAY") = "", DBNull.Value, INC("MAY"))
                dr("JUN") = IIf(INC("JUN") = "", DBNull.Value, INC("JUN"))
                dr("JUL") = IIf(INC("JUL") = "", DBNull.Value, INC("JUL"))
                dr("AGO") = IIf(INC("AGO") = "", DBNull.Value, INC("AGO"))
                dr("SEP") = IIf(INC("SEP") = "", DBNull.Value, INC("SEP"))
                dr("OCT") = IIf(INC("OCT") = "", DBNull.Value, INC("OCT"))
                dr("NOV") = IIf(INC("NOV") = "", DBNull.Value, INC("NOV"))
                dr("DIC") = IIf(INC("DIC") = "", DBNull.Value, INC("DIC"))
                dr("TOTAL") = INC("TOTAL")

                dtExcel.Rows.Add(dr)

            Next

            ListaDatatable = New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            ListaTitulos = New List(Of String)
            ListaTitulos.Add("MAESTRO INCIDENCIAS")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & UcCompania_Cmb012.CCMPN_Descripcion)
            If Lista_Areas.Trim.Length > 5 Then
                F.Add(1, "Área:|" & "VARIOS")
            Else
                F.Add(1, "Área:|" & Lista_Divisiones_Descripcion())
            End If
            F.Add(2, "Inc. Para:|" & cmbIncPara.Text)
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("TDARINC")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Try
            Me.ParentForm.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"

    'Private Sub Cargar_Divisiones()
    '    Dim objDAL As New Ransa.DAO.UbicacionPlanta.Division.daoDivision
    '    Dim dt As DataTable = Nothing
    '    dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, UcCompania_Cmb011.CCMPN_CodigoCompania)
    '    cmbDivision.Properties.DataSource = dt
    '    cmbDivision.Properties.ValueMember = "CDVSN"
    '    cmbDivision.Properties.DisplayMember = "TCMPDV"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    cmbDivision.CheckAll()
    'End Sub

    'Function ListaCodigoDivisiones() As String
    '    Dim strCadDocumentos As String = ""
    '    For i As Integer = 0 To cmbDivision.Properties.Items.Count - 1
    '        If cmbDivision.Properties.Items.Item(i).CheckState = 1 Then
    '            strCadDocumentos += cmbDivision.Properties.Items.Item(i).Value & ","
    '        End If
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function

    'Function ListaDescripcionDivisiones() As String
    '    Dim strCadDocumentos As String = ""
    '    For i As Integer = 0 To cmbDivision.Properties.Items.Count - 1
    '        If cmbDivision.Properties.Items.Item(i).CheckState = 1 Then
    '            strCadDocumentos += cmbDivision.Properties.Items.Item(i).Description & "-"
    '        End If
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function

#End Region

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias

        cmbIncPara.DataSource = objBLL.Lista_Inc_Para
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 1

    End Sub

    Private Sub cmbDivision1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectedIndexChanged
        Dim bolea As Boolean = False

        For i As Integer = 0 To cmbArea.Items.Count - 1
            bolea = cmbArea.Items.Item(i).checked
            If cmbArea.Items.Item(i).Value = "0" Then
                cmbArea.SetItemChecked(i, bolea)
            End If
        Next
    End Sub

    Private Sub cmbDivision1_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectionChangeCommitted
        Dim bolea As Boolean = False

        For i As Integer = 0 To cmbArea.Items.Count - 1
            bolea = cmbArea.Items.Item(i).checked
            If cmbArea.Items.Item(i).Value = "0" Then
                cmbArea.SetItemChecked(i, bolea)
            End If
        Next
    End Sub


    Private Sub dtgIncidencias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgIncidencias.CellDoubleClick

        Dim ultimo_dia As Integer = 0

        If dtgIncidencias.Columns(e.ColumnIndex).Name.EndsWith("_MES") = True Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            If dtgIncidencias.Item(e.ColumnIndex, e.RowIndex).Value.ToString <> "" Then

                If txtAnio.Text = "" Then
                    Exit Sub
                End If

                Dim ObjFrm As New frmVistaRegistros

                If dtgIncidencias.Item(e.ColumnIndex, e.RowIndex).Value > 0 Then

                    ObjFrm.pCompaniades = UcCompania_Cmb012.CCMPN_Descripcion
                    ObjFrm.pCompania = UcCompania_Cmb012.CCMPN_CodigoCompania
                    'ObjFrm.pDivision = dtgIncidencias.Item(1, e.RowIndex).Value
                    'ObjFrm.pDivisiondes = dtgIncidencias.Item(2, e.RowIndex).Value
                    'ObjFrm.pCodIncidencia = dtgIncidencias.Item(3, e.RowIndex).Value
                    'ObjFrm.pIncidenciades = dtgIncidencias.Item(4, e.RowIndex).Value

                    ObjFrm.pArea = dtgIncidencias.Rows(e.RowIndex).Cells("CARINC").Value.ToString.Trim
                    ObjFrm.pAreades = dtgIncidencias.Rows(e.RowIndex).Cells("TDARINC").Value
                    ObjFrm.pCodIncidencia = dtgIncidencias.Rows(e.RowIndex).Cells("CINCID").Value
                    ObjFrm.pIncidenciades = dtgIncidencias.Rows(e.RowIndex).Cells("TINCSI").Value


                    Select Case dtgIncidencias.Columns(e.ColumnIndex).Name.Split("_")(0)

                        Case "ENE"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 1)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0101")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "01" & ultimo_dia)

                        Case "FEB"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 2)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0201")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "02" & ultimo_dia)

                        Case "MAR"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 3)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0301")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "03" & ultimo_dia)

                        Case "ABR"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 4)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0401")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "04" & ultimo_dia)

                        Case "MAY"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 5)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0501")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "05" & ultimo_dia)

                        Case "JUN"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 6)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0601")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "06" & ultimo_dia)

                        Case "JUL"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 7)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0701")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "07" & ultimo_dia)

                        Case "AGO"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 8)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0801")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "08" & ultimo_dia)

                        Case "SEP"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 9)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0901")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "09" & ultimo_dia)

                        Case "OCT"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 10)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "1001")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "10" & ultimo_dia)

                        Case "NOV"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 11)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "1101")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "11" & ultimo_dia)

                        Case "DIC"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 12)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "1201")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "12" & ultimo_dia)

                        Case "TOTAL"
                            ultimo_dia = Date.DaysInMonth(CInt(txtAnio.Text), 12)
                            ObjFrm.pFechaInicio = CDec(CInt(txtAnio.Text) & "0101")
                            ObjFrm.pFechaFin = CDec(CInt(txtAnio.Text) & "12" & ultimo_dia)

                    End Select

                    ObjFrm.ShowDialog()

                End If
            End If
        End If

    End Sub

End Class
