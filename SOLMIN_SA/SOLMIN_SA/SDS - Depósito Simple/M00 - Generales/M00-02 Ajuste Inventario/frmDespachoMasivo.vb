Imports Ransa.Utilitario
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports RANSA.NEGO
Imports Ransa.TypeDef
Imports System.Text

Public Class frmDespachoMasivo

#Region "Variables"

#End Region

#Region "Delegados"

    Private Sub frmDespachoMasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        txtCliente.pUsuario = objSeguridadBN.pUsuario
        CargarPlanta()

    End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilia.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub txtGrupo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrupo.Validating
        If txtGrupo.Text = "" Then
            txtGrupo.Tag = ""
            Exit Sub
        Else
            If txtGrupo.Text <> "" And "" & txtGrupo.Tag = "" Then
                Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                If txtGrupo.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged
        txtGrupo.Tag = ""
    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
        End If
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.Click
        Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
    End Sub

    Private Sub txtFamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        If txtFamilia.Text = "" Then
            txtFamilia.Tag = ""
            Exit Sub
        Else
            If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
        End If
    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = UcPLanta_Cmb011.Planta
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If txtCliente.pCodigo = 0 Then

                MessageBox.Show("Seleccione Cliente.")
                Exit Sub
            End If

            Consultar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If dgMercaderias.Rows.Count > 0 Then
                ExportarExcel()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDespacho.Click
        Try
            Dim oDat As New DataTable
            Dim dtResumen As New DataTable

            If dgMercaderias.Rows.Count <= 0 Then
                MessageBox.Show("No existen datos. Verifique porfavor")
                Exit Sub
            End If
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            dgMercaderias.EndEdit()
            'oDat = CType(dgMercaderias.DataSource, DataTable)


            Dim dtResult As New DataTable
            dtResult.Columns.Add("CCLNT")
            dtResult.Columns.Add("CTPALM")
            dtResult.Columns.Add("CALMC")
            dtResult.Columns.Add("CZNALM")
            dtResult.Columns.Add("QSLMC2", Type.GetType("System.Decimal"))
            dtResult.Columns.Add("QSLMP2", Type.GetType("System.Decimal"))
            dtResult.Columns.Add("NORDSR")
            dtResult.Columns.Add("NCNTR")
            dtResult.Columns.Add("NCRCTC")
            dtResult.Columns.Add("NAUTR")
            dtResult.Columns.Add("CUNCN5")
            dtResult.Columns.Add("CUNPS5")
            dtResult.Columns.Add("CUNVL5")
            dtResult.Columns.Add("FUNDS2")
            dtResult.Columns.Add("CTPDP6")
            dtResult.Columns.Add("CMRCLR")
            dtResult.Columns.Add("CMRCD")
            dtResult.Columns.Add("TMRCD2")

            dtResult.Columns.Add("CFMCLR")
            dtResult.Columns.Add("CGRCLR")

            Dim dr As DataRow

            For Each item As DataGridViewRow In dgMercaderias.Rows
                If item.Cells("CHK").Value = True And item.Cells("QSLMC2").Value > 0 Then
                    dr = dtResult.NewRow
                    dr("CCLNT") = item.Cells("CCLNT").Value
                    dr("CTPALM") = ("" & item.Cells("CTPALM").Value).ToString.Trim
                    dr("CALMC") = ("" & item.Cells("CALMC").Value).ToString.Trim
                    dr("CZNALM") = ("" & item.Cells("CZNALM").Value).ToString.Trim
                    dr("QSLMC2") = item.Cells("QSLMC2").Value
                    dr("QSLMP2") = item.Cells("QSLMP2").Value
                    dr("NORDSR") = item.Cells("NORDSR").Value
                    dr("NCNTR") = item.Cells("NCNTR").Value
                    dr("NCRCTC") = item.Cells("NCRCTC").Value
                    dr("NAUTR") = item.Cells("NAUTR").Value
                    dr("CUNCN5") = ("" & item.Cells("CUNCN5").Value).ToString.Trim
                    dr("CUNPS5") = ("" & item.Cells("CUNPS5").Value).ToString.Trim
                    dr("CUNVL5") = ("" & item.Cells("CUNVL5").Value).ToString.Trim
                    dr("FUNDS2") = ("" & item.Cells("FUNDS2").Value).ToString.Trim
                    dr("CTPDP6") = ("" & item.Cells("CTPDP6").Value).ToString.Trim
                    dr("CMRCLR") = ("" & item.Cells("CMRCLR").Value).ToString.Trim
                    dr("CMRCD") = ("" & item.Cells("CMRCD").Value).ToString.Trim
                    dr("CFMCLR") = ("" & item.Cells("CFMCLR").Value).ToString.Trim
                    dr("CGRCLR") = ("" & item.Cells("CGRCLR").Value).ToString.Trim
                    dr("TMRCD2") = ("" & item.Cells("TMRCD2").Value).ToString.Trim
                    dtResult.Rows.Add(dr)
                End If
            Next

            'CHK


            'Dim dr() As DataRow
            'Dim dtResult As New DataTable
            'dtResult = oDat.Copy
            'dtResult.Rows.Clear()

            'dr = oDat.Select("QSLMC2 > 0")
            'For Each Item As DataRow In dr
            '    dtResult.ImportRow(Item)
            'Next
            If dtResult.Rows.Count = 0 Then
                MessageBox.Show("No existen cantidades a despachar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            dtResumen = ResumenDataTable(dtResult)

            Dim frm As New frmProcesarDespachoMasivo(dtResult, dtResumen, txtCliente)
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Consultar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarPlanta()

        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()

        'tipo almacen
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"

    End Sub

    Private Sub Consultar()
        Dim objNeg As New Ransa.NEGO.brDespachoMasivo
        Dim dt As DataTable

        If dgMercaderias.Rows.Count > 0 Then
            dgMercaderias.DataSource = Nothing
        End If

        Dim PNCCLNT As Decimal = txtCliente.pCodigo
        Dim PSCFMCLR As String = IIf(txtFamilia.Text.Trim = "", "", txtFamilia.Tag)
        Dim PSCGRCLR As String = IIf(txtGrupo.Text.Trim = "", "", txtGrupo.Tag)

        Dim PSCTPALM As String

        If txtTipoAlmacen.Resultado IsNot Nothing Then
            PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'txtTipoAlmacen.Tag
        Else
            PSCTPALM = String.Empty
        End If

        Dim PSCALMC As String
        If txtAlmacen.Resultado IsNot Nothing Then
            PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC 'txtAlmacen.Tag
        Else
            PSCALMC = String.Empty
        End If

        Dim PSCZNALM As String
        If txtZonaAlmacen.Resultado IsNot Nothing Then
            PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM 'txtZonaAlmacen.Tag
        Else
            PSCZNALM = String.Empty
        End If

        dt = objNeg.ListarStockMercaderiaClienteAlmacen(PNCCLNT, PSCFMCLR, PSCGRCLR, PSCTPALM, PSCALMC, PSCZNALM)
        dgMercaderias.AutoGenerateColumns = False
        dgMercaderias.DataSource = dt

        ChkFila = False

       


    End Sub

    Private Sub ExportarExcel()

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""

        odtExportar.Columns.Add("CMRCLR")
        MdataColumna = NPOI_SC.FormatDato("MERCADERIA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CMRCLR").Caption = MdataColumna

        odtExportar.Columns.Add("TMRCD2")
        MdataColumna = NPOI_SC.FormatDato("DESCRIPCION MERCADERIA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("TMRCD2").Caption = MdataColumna

        odtExportar.Columns.Add("QSLMC2")
        MdataColumna = NPOI_SC.FormatDato("CANTIDAD", NPOI_SC.keyDatoNumero)
        odtExportar.Columns("QSLMC2").Caption = MdataColumna

        odtExportar.Columns.Add("CUNCN5")
        MdataColumna = NPOI_SC.FormatDato("UNIDAD DE MEDIDA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CUNCN5").Caption = MdataColumna

        odtExportar.Columns.Add("CFMCLR")
        MdataColumna = NPOI_SC.FormatDato("COD FAMILIA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CFMCLR").Caption = MdataColumna

        odtExportar.Columns.Add("TFMCLR")
        MdataColumna = NPOI_SC.FormatDato("FAMILIA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("TFMCLR").Caption = MdataColumna

        odtExportar.Columns.Add("CGRCLR")
        MdataColumna = NPOI_SC.FormatDato("COD GRUPO", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CGRCLR").Caption = MdataColumna

        odtExportar.Columns.Add("TGRCLR")
        MdataColumna = NPOI_SC.FormatDato("GRUPO", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("TGRCLR").Caption = MdataColumna

        odtExportar.Columns.Add("CTPALM")
        MdataColumna = NPOI_SC.FormatDato("TIPO ALMACEN", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CTPALM").Caption = MdataColumna

        odtExportar.Columns.Add("CALMC")
        MdataColumna = NPOI_SC.FormatDato("ALMACEN", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CALMC").Caption = MdataColumna

        odtExportar.Columns.Add("CZNALM")
        MdataColumna = NPOI_SC.FormatDato("ZONA", NPOI_SC.keyDatoTexto)
        odtExportar.Columns("CZNALM").Caption = MdataColumna

        Dim dr As DataRow
        Dim NameColumna As String = ""

        For Each drDatos As DataGridViewRow In dgMercaderias.Rows
            dr = odtExportar.NewRow
            For Each dcColumna As DataColumn In odtExportar.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = drDatos.Cells(NameColumna).Value
            Next
            odtExportar.Rows.Add(dr)
        Next

        Dim ListaDatatable As New List(Of DataTable)
        ListaDatatable.Add(odtExportar.Copy)

        Dim LisFiltros As New List(Of SortedList)
        

        Dim ListTitulo As New List(Of String)
        ListTitulo.Add("LISTA MERCADERIA")
        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0)

    End Sub

    Private Function ResumenDataTable(ByVal Dt As DataTable) As DataTable
      

        Dim CodJoin As String = ""
        Dim oHasLista As New Hashtable
        Dim dtResumen As New DataTable
        dtResumen = Dt.Copy
        dtResumen.Rows.Clear()
        Dim MontoTotal As Object
        Dim FILA As Int32 = 0
        Dim filtro As String = ""
        For Each row As DataRow In Dt.Rows
            filtro = "CMRCLR = '" & Trim(row("CMRCLR")) & "' AND NORDSR = " & row("NORDSR")
            CodJoin = Trim(row("CMRCLR")) & "_" & row("NORDSR")
            If Not oHasLista.contains(CodJoin) Then
                dtResumen.ImportRow(row)
                FILA = dtResumen.Rows.Count - 1
                MontoTotal = Val("" & Dt.Compute("SUM(QSLMC2)", filtro))
                dtResumen.Rows(FILA)("QSLMC2") = MontoTotal
                oHasLista.Add(CodJoin, CodJoin)
            End If
        Next
        Return dtResumen
    End Function
    

    Private Sub dgMercaderias_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderias.CellValueChanged
        Try
            Dim dblCantidadAnterior As Decimal = 0
            If e.RowIndex > -1 And dgMercaderias.Columns(e.ColumnIndex).Name = "QSLMC2_D" Then
                dblCantidadAnterior = dgMercaderias.Rows(e.RowIndex).Cells("QSLMC2").Value
                If (Val("" & dgMercaderias.Rows(e.RowIndex).Cells("QSLMC2_D").Value) > dblCantidadAnterior) Then
                    dgMercaderias.Rows(e.RowIndex).Cells("QSLMC2_D").Value = dblCantidadAnterior
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMercaderias_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgMercaderias.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim colName As String = ""
            colName = dgMercaderias.Columns(dgMercaderias.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "QSLMC2_D"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dgMercaderias_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgMercaderias.DataError

    End Sub
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Public Shared Function SoloNumerosConDecimal(ByVal sender As TextBox, ByVal Keyascii As Short) As Short
        Dim TextBox As TextBox
        Dim NumeroTexto As String
        TextBox = CType(sender, TextBox)
        Dim ArrayEnteroDecimal() As String
        Dim NEnteros As Int32 = 0
        Dim NDecimales As Int32 = 0
        If TextBox.Tag IsNot Nothing Then
            ArrayEnteroDecimal = TextBox.Tag.ToString.Split("-")
            If ArrayEnteroDecimal.Length = 2 Then
                NEnteros = Convert.ToInt32(ArrayEnteroDecimal(0))
                NDecimales = Convert.ToInt32(ArrayEnteroDecimal(1))
            End If
        End If
        Dim InicioEnteros As String = IIf(NEnteros = 0, "0", 1)
        Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NEnteros & "}(\.[0-9]{0," & NDecimales & "})?$"
        NumeroTexto = TextBox.Text.Trim
        Dim NumeroOriginal As String = NumeroTexto
        NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
        If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
            NumeroTexto = NumeroOriginal
            SoloNumerosConDecimal = 0
        Else
            SoloNumerosConDecimal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimal = Keyascii
            Case 13
                SoloNumerosConDecimal = Keyascii
            Case 32
                SoloNumerosConDecimal = Keyascii
        End Select
    End Function

#End Region


    Private ChkFila As Boolean = False
    Private Sub btnchk_Click(sender As Object, e As EventArgs) Handles btnchk.Click
        ChkFila = Not ChkFila
        For Each item As DataGridViewRow In dgMercaderias.Rows
            item.Cells("CHK").Value = ChkFila
            If item.Cells("QSLMC2").Value = 0 Then
                item.Cells("CHK").Value = False
            End If
        Next
        dgMercaderias.EndEdit()
    End Sub
End Class
