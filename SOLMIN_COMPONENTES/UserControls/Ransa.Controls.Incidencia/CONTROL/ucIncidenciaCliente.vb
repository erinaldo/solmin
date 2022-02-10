Imports System.Windows.Forms
Imports Ransa.Utilitario

Public Class ucIncidenciaCliente

#Region "PROPIEDADES"
    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pCompaniaActual As String = ""
    Public Property pCompaniaActual() As String
        Get
            Return _pCompaniaActual
        End Get
        Set(ByVal value As String)
            _pCompaniaActual = value
        End Set
    End Property

    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)

#End Region


    Dim dt As DataTable

    Sub pInicializar()

        dtgIncidencias.AutoGenerateColumns = False
        UcCompania_Cmb011.Usuario = _pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(_pCompaniaActual)
        Dim ClientePK As TypeDef.Cliente.TD_ClientePK = New TypeDef.Cliente.TD_ClientePK(0, _pUsuario)
        txtCliente.pCargar(ClientePK)
        txtAnio.Text = Now.Year
    End Sub

    'Private Sub Cargar_Divisiones()
    '    Dim objDAL As New Ransa.DAO.UbicacionPlanta.Division.daoDivision
    '    Dim dt As DataTable = Nothing
    '    dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, UcCompania_Cmb011.CCMPN_CodigoCompania)
    '    UcDivision_Cmb011.Properties.DataSource = dt
    '    UcDivision_Cmb011.Properties.ValueMember = "CDVSN"
    '    UcDivision_Cmb011.Properties.DisplayMember = "TCMPDV"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    UcDivision_Cmb011.CheckAll()
    'End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            Cargar_Divisiones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Divisiones()
        Dim objDAL As New Ransa.DAO.UbicacionPlanta.Division.daoDivision
        dt = New DataTable
        dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, UcCompania_Cmb011.CCMPN_CodigoCompania)
        dt.Columns.Remove("CCMPN")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("CDVSN") = "0"
        dr("TCMPDV") = "TODOS"
        dt.Rows.InsertAt(dr, 0)
        cmbDivision1.DisplayMember = "TCMPDV"
        cmbDivision1.ValueMember = "CDVSN"
        cmbDivision1.DataSource = dt
        cmbDivision1.SelectedValue = "0"

        For i As Integer = 0 To cmbDivision1.Items.Count - 1
            If cmbDivision1.Items.Item(i).Value = "0" Then
                cmbDivision1.SetItemChecked(i, True)
            End If
        Next

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim objFrm As New frmRegistroIncidenciaCliente
            objFrm.pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            If Lista_Divisiones.Trim.Length = 1 Then
                If Lista_Divisiones.Trim.Length = 1 Then
                    objFrm.pDivision = "S"
                Else
                    objFrm.pDivision = Lista_Divisiones.Trim
                End If
            Else
                objFrm.pDivision = "S"
            End If
            objFrm.pUsuario = _pUsuario
            objFrm.pCliente = txtCliente.pCodigo
            objFrm.pClienteDes = txtCliente.pRazonSocial
            If objFrm.ShowDialog = DialogResult.OK Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Lista_Divisiones_Descripcion() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CDVSN") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For j As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(j).Item("CDVSN") <> "0" Then
                    strCadDocumentos += dt.Rows(j).Item("TCMPDV") & " - "
                End If
            Next
        Else
            For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("TCMPDV") & " - "
                    End If
                Next
            Next

        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Function Valida() As String
        Dim msg As String = ""
        Dim divisiones As String = ""
        divisiones = Lista_Divisiones()

        If divisiones.Trim = "" Then
            msg = "* Seleccione una división" & Environment.NewLine
        End If
        If txtCliente.pCodigo = 0D Then
            msg = msg & "* Seleccione un cliente" & Environment.NewLine
        End If
        If txtAnio.Text.Trim = "" Then
            msg = msg & "* Ingrese un año" & Environment.NewLine
        End If
        Return msg
    End Function

    Sub Buscar()

        Me.dtgIncidencias.DataSource = Nothing
        Dim ObjBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim mensaje As String = ""
        Dim DT As New DataTable

        mensaje = Valida()
        If mensaje.Trim.Length > 0 Then
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        objBE.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objBE.PSCDVSN = Lista_Divisiones() 'ListaCodigoDivisiones()
        objBE.PNCCLNT = txtCliente.pCodigo
        objBE.ANIO = CInt(txtAnio.Text)
        DT = ObjBLL.olistListarMaestroIncidenciasCliente(objBE)

        DT.Columns.Remove("CODIGO")
        Dim dt1 As DataTable = DT

        Dim dv1 As New DataView(dt1)
        dv1.Sort = "TCMPDV ASC"
        dt1 = dv1.ToTable

        Dim dtFinal As New DataTable
        Dim drFinal As DataRow

        dtFinal.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtFinal.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtFinal.Columns.Add("CDVSN", Type.GetType("System.String"))
        dtFinal.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtFinal.Columns.Add("CINCID", Type.GetType("System.Int32"))
        dtFinal.Columns.Add("TINCSI", Type.GetType("System.String"))

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
            drFinal("CCLNT") = dr("CCLNT")
            drFinal("CDVSN") = dr("CDVSN")
            drFinal("TCMPDV") = dr("TCMPDV")
            drFinal("CINCID") = dr("CINCID")
            drFinal("TINCSI") = dr("TINCSI")

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

        Me.dtgIncidencias.DataSource = dtFinal.Copy

    End Sub

    Private Function Lista_Divisiones() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CDVSN") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CDVSN") <> "0") Then
                        strCadDocumentos += dt.Rows(j).Item("CDVSN") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("CDVSN") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos

    End Function


    'Function ListaCodigoDivisiones() As String
    '    Dim strCadDocumentos As String = ""
    '    For i As Integer = 0 To UcDivision_Cmb011.Properties.Items.Count - 1
    '        If UcDivision_Cmb011.Properties.Items.Item(i).CheckState = 1 Then
    '            strCadDocumentos += UcDivision_Cmb011.Properties.Items.Item(i).Value & ","
    '        End If
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function

    'Function ListaDescripcionDivisiones() As String
    '    Dim strCadDocumentos As String = ""
    '    For i As Integer = 0 To UcDivision_Cmb011.Properties.Items.Count - 1
    '        If UcDivision_Cmb011.Properties.Items.Item(i).CheckState = 1 Then
    '            strCadDocumentos += UcDivision_Cmb011.Properties.Items.Item(i).Description & "-"
    '        End If
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

        Try
            Dim NPOI As New HelpClass_NPOI_ST

            NPOI = New Ransa.Utilitario.HelpClass_NPOI_ST

            If Me.dtgIncidencias.Rows.Count = 0 Then Exit Sub

            Dim dt_grilla As DataTable = Me.dtgIncidencias.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("TCMPDV").Caption = NPOI.FormatDato("División", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("CINCID").Caption = NPOI.FormatDato("Código", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("TINCSI").Caption = NPOI.FormatDato("Descripción", HelpClass_NPOI_ST.keyDatoTexto)

            dtExcel.Columns.Add("ENE", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("ENE", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("FEB", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("FEB", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("MAR", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("MAR", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("ABR", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("ABR", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("MAY", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("MAY", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("JUN", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("JUN", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("JUL", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("JUL", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("AGO", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("AGO", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("SEP", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("SEP", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("OCT", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("OCT", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("NOV", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("NOV", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("DIC", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("DIC", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("TOTAL", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("TOTAL", HelpClass_NPOI_ST.keyDatoNumero)

            For Each INC As DataRow In dt_grilla.Rows
                dr = dtExcel.NewRow
                dr("TCMPDV") = INC("TCMPDV").ToString.Trim
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
            ListaTitulos.Add("INCIDENCIAS POR CLIENTE")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & UcCompania_Cmb011.CCMPN_Descripcion)
            If Lista_Divisiones.Trim.Length > 5 Then
                F.Add(1, "División:|" & "VARIOS")
            Else
                F.Add(1, "División:|" & Lista_Divisiones_Descripcion())
            End If
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("TCMPDV")

            NPOI.ExportExcelGeneralMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try

            If Me.dtgIncidencias.CurrentCellAddress.Y = -1 Then Exit Sub
            If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            Dim obr As New brIncidencias
            Dim obe As New beIncidencias
            With obe
                .PSCCMPN = ("" & Me.dtgIncidencias.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                .PNCCLNT = Me.dtgIncidencias.CurrentRow.Cells("CCLNT").Value
                .PNCINCID = Me.dtgIncidencias.CurrentRow.Cells("CINCID").Value
                .PSNTRMNL = Environment.MachineName
                .PSUSUARIO = _pUsuario
            End With
            If obr.intEliminarIncidenciasCliente(obe) = 1 Then
                Buscar()
            Else
                'MessageBox.Show("No se puede eliminar, hay registro de incidencias asociadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Buscar()
            End If
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

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsCerrar.Click
        Try
            Me.ParentForm.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCopiarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPerfil.Click

        Dim objFrm As New frmCopiarPerfil

        objFrm.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objFrm.PSCCMPN_DES = UcCompania_Cmb011.CCMPN_Descripcion
        objFrm.pUsuario = _pUsuario

        If txtCliente.pCodigo = 0D Then
            MessageBox.Show("Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        objFrm.pCodCliente = txtCliente.pCodigo
        objFrm.pClienteDestino = txtCliente.pRazonSocial
        objFrm.PSCDVSN = "S"

        If objFrm.ShowDialog = DialogResult.OK Then
            Buscar()
        End If

    End Sub
End Class
