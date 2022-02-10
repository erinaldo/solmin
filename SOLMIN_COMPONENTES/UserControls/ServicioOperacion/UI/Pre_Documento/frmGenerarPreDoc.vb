Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports System.Windows.Forms
 

Public Class frmGenerarPreDoc

    'Public pCodMoneda As Decimal = 0
    'Public pDescMoneda As String = ""
    Public pCCMPN As String = ""
    Public pNRLQD As Decimal = 0
    Public pCCNLT As Decimal = 0
    Public pTIPOPL As String = ""
 
    Private checkallTransporte As Boolean = False


    Public TotalGenerarPreDoc As Decimal = 0
    Public ImpTotal As Decimal = 0
    Public pDialog As Boolean = False
    Private CodEstadoPL As String = ""
    Private dtListPendiente As New DataTable

    'Private cOrgVenta As String = ""

    Public pSoloLectura As Boolean = False
    Private Sub frmGenerarPreDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

           
            Dim oclsMoneda_BL As New clsMoneda_BL
            Dim dtMoneda As New DataTable
            dtMoneda = oclsMoneda_BL.Lista_Moneda_Sol_Dol()
            cmbMoneda.DataSource = dtMoneda
            cmbMoneda.DisplayMember = "TMNDA"
            cmbMoneda.ValueMember = "CMNDA1"

            ActualizarSeleccionMoneda()
            'Dim bePreDoc As New PreDoc_BE
            'bePreDoc = New PreDoc_BE
            'bePreDoc.PSCCMPN = pCCMPN
            'bePreDoc.PNNRCTRL = pNRLQD
            'bePreDoc.PSTIPOPL = pTIPOPL
            'dtCabPreDoc = oclsPreDoc_BL.ListarCabMonedaPreDoc(bePreDoc)
            'Dim CantPreDoc As Decimal = 0
            'If dtCabPreDoc.Rows.Count > 0 Then
            '    CantPreDoc = dtCabPreDoc.Rows(0)("CANT_PREDOC")
            '    If CantPreDoc > 0 Then
            '        cmbMoneda.SelectedValue = dtCabPreDoc.Rows(0)("ID_MONEDA")
            '        cmbMoneda.Enabled = False
            '    End If
            '    If CantPreDoc = 0 Then
            '        cmbMoneda.SelectedValue = dtCabPreDoc.Rows(0)("ID_MONEDA")
            '    End If
            'End If

            GetEstadoPL()

            dtgPreDocumentos.AutoGenerateColumns = False
            Dim OTipoDatoGeneral_BLL As New clsDatoGeneral_BLL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(pCCMPN, "TPRDOC")
            cblTipo.DataSource = oListTipoDatoGeneral
            cblTipo.ValueMember = "CODIGO_TIPO"
            cblTipo.DisplayMember = "DESC_TIPO"
            cblTipo.SelectedValue = "01"
            cblTipo_SelectionChangeCommitted(cblTipo, Nothing)


            dtgOpPendientes.AutoGenerateColumns = False
            'txtMoneda.Text = pDescMoneda
            txtPL.Text = pNRLQD

            ListarPendDocumentos()
            For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1
                ImpTotal = ImpTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value
            Next
            txtMontoPend.Text = ImpTotal
            dtgPreDocumentos.AutoGenerateColumns = False
            ListarPlDocumentos()
            dtgOpPendientes.DataSource = dtListPendiente
            'lblMoneda.Text = pDescMoneda
            lblMoneda.Text = cmbMoneda.Text

            If pSoloLectura = True Then
                btnAnulLib.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bntLibPL.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                MenuBar.Enabled = False
                ToolStrip1.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub ActualizarSeleccionMoneda()
        Dim oclsPreDoc_BL As New clsPreDoc_BL
        Dim dtCabPreDoc As New DataTable
        Dim bePreDoc As New PreDoc_BE
        bePreDoc = New PreDoc_BE
        bePreDoc.PSCCMPN = pCCMPN
        bePreDoc.PNNRCTRL = pNRLQD
        bePreDoc.PSTIPOPL = pTIPOPL
        dtCabPreDoc = oclsPreDoc_BL.ListarCabMonedaPreDoc(bePreDoc)
        Dim CantPreDoc As Decimal = 0
        If dtCabPreDoc.Rows.Count > 0 Then
            CantPreDoc = dtCabPreDoc.Rows(0)("CANT_PREDOC")
            If CantPreDoc > 0 Then
                cmbMoneda.SelectedValue = dtCabPreDoc.Rows(0)("ID_MONEDA")
                cmbMoneda.Enabled = False
            End If
            If CantPreDoc = 0 Then
                cmbMoneda.SelectedValue = dtCabPreDoc.Rows(0)("ID_MONEDA")
                cmbMoneda.Enabled = True
            End If
        End If
        If pTIPOPL = "A" Then
            cmbMoneda.Enabled = False
        End If
    End Sub


    Private Sub GetEstadoPL()
        Dim obePreDoc As New clsPreDoc_BL
        Dim bePreDoc As New PreDoc_BE
        bePreDoc.PSCCMPN = pCCMPN
        bePreDoc.PNNRCTRL = pNRLQD
        bePreDoc.PSTIPOPL = pTIPOPL
        Dim dt As New DataTable
        dt = obePreDoc.ListarEstadoPL(bePreDoc)
        If dt.Rows.Count > 0 Then
            CodEstadoPL = dt.Rows(0)("COD_ESTADO_PL")
            txtEstado.Text = dt.Rows(0)("DESC_ESTADO_PL")
        End If

    End Sub
    Private Sub ListarPlDocumentos()
        Dim dtResult As New DataTable

        Dim obrFiltroPreDoc As New clsPreDoc_BL
        Dim oPreDocFiltro As New PreDoc_BE
        oPreDocFiltro = New PreDoc_BE
        oPreDocFiltro.PSCCMPN = pCCMPN
        oPreDocFiltro.PNNRCTRL = pNRLQD
        oPreDocFiltro.PSTIPOPL = pTIPOPL
        dtResult = obrFiltroPreDoc.ListarPLDocumentos(oPreDocFiltro)
        dtgPreDocumentos.DataSource = dtResult
    End Sub
    Private Sub ListarPendDocumentos()

        'ActualizarSeleccionMoneda()

        Dim obrFiltroPreDoc As New clsPreDoc_BL
        Dim oPreDocFiltro As New PreDoc_BE
        oPreDocFiltro = New PreDoc_BE
        oPreDocFiltro.PSCCMPN = pCCMPN
        oPreDocFiltro.PNCCNLT = pCCNLT
        oPreDocFiltro.PNNRCTRL = pNRLQD
        oPreDocFiltro.PSTIPOPL = pTIPOPL
        'oPreDocFiltro.PNCMNDGU = pCodMoneda
        oPreDocFiltro.PNCMNDGU = cmbMoneda.SelectedValue

        dtListPendiente = obrFiltroPreDoc.ListarPendDoc(oPreDocFiltro)

        Dim nuevoTotal As Decimal = 0
        For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1
            nuevoTotal = nuevoTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value
        Next
        txtMontoPend.Text = nuevoTotal
        dtgOpPendientes.DataSource = dtListPendiente


    End Sub




    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Comun.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then

            e.Handled = True

        End If

    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtTotalG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalG.KeyPress
        NumerosyDecimal(txtTotalG, e)


    End Sub
    Private Sub GenerarPreDoc_Por_Importe()
        Dim objfrmGenerarPDoc As New frmGenerarPDoc
        Dim pTotal As Decimal = 0
        Dim Acum As Decimal = 0
        Dim oPreDoc_B As New PreDoc_BE
        Dim olistPreDoc_B As New List(Of PreDoc_BE)


        If dtgOpPendientes.Rows.Count = 0 Then Exit Sub

        If txtTotalG.Text = "" Then
            MessageBox.Show("Digite un monto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim primerRegistro As String = ""
        Dim regValido As Boolean = True

        If regValido = False Then
            MessageBox.Show("Los registros seleccionados deben tener mismo IGV/Detracción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim MaximoMontoPendiente As Decimal = 0
        Dim TotalAcumulado As Decimal = 0
        Dim Importe As Decimal = 0

        TotalGenerarPreDoc = txtTotalG.Text
        MaximoMontoPendiente = txtMontoPend.Text

        If TotalGenerarPreDoc > MaximoMontoPendiente Then
            MessageBox.Show("Máximo monto permitido " & MaximoMontoPendiente, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If TotalGenerarPreDoc <= 0 Then
            MessageBox.Show("Monto debe ser mayor 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim oHasListResumen As New Hashtable
        Dim pClave As String = ""
        Dim pClaveSeleccionada As String = ""

        For Each item As DataRow In dtListPendiente.Rows
            pClave = item("AFECTO_DET") & "_" & item("POR_DETRACCION") & "_" & item("PIGVA")
            If Not oHasListResumen.Contains(pClave) Then
                oHasListResumen(pClave) = item("IMPORTE_PENDTE")
            Else
                oHasListResumen(pClave) = oHasListResumen(pClave) + item("IMPORTE_PENDTE")
            End If
        Next
        For Each item As DictionaryEntry In oHasListResumen
            If item.Value = TotalGenerarPreDoc Then
                pClaveSeleccionada = item.Key
                Exit For
            End If
        Next
        If pClaveSeleccionada = "" Then
            For Each item As DictionaryEntry In oHasListResumen
                If TotalGenerarPreDoc <= item.Value Then
                    pClaveSeleccionada = item.Key
                    Exit For
                End If
            Next
        End If

        If pClaveSeleccionada = "" Then
            MessageBox.Show("Criterio no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim FinBusqueda As Boolean = False
        'Para un valor exacto---------------

        For Each row As DataGridViewRow In dtgOpPendientes.Rows


            If TotalGenerarPreDoc = row.Cells("IMPDOC").Value Then
                oPreDoc_B = New PreDoc_BE
                oPreDoc_B.ADETDOC = row.Cells("ADETDOC").Value
                oPreDoc_B.PDETDOC = row.Cells("PDETDOC").Value
                oPreDoc_B.IGVDOC = row.Cells("IGVDOC").Value
                oPreDoc_B.PSCCMPN = pCCMPN
                oPreDoc_B.PNNRCTRL = pNRLQD
                oPreDoc_B.PSTIPOPL = pTIPOPL
                oPreDoc_B.SERVICIO = row.Cells("SERVICIO").Value
                oPreDoc_B.MONEDA = row.Cells("MONEDA").Value
                Importe = row.Cells("IMPDOC").Value

                oPreDoc_B.PNIVLSRV = Importe
                oPreDoc_B.PNNOPRCN = row.Cells("NOPRCN").Value
                oPreDoc_B.PNCMNDA1 = row.Cells("CMNDA1").Value
                oPreDoc_B.PSTPOPER = row.Cells("TPOPER").Value
                oPreDoc_B.PNNGUIRM = row.Cells("NGUIRM").Value
                oPreDoc_B.PNNCRROP = row.Cells("NCRROP").Value
                oPreDoc_B.PNNGUITR = row.Cells("NGUITR").Value
                oPreDoc_B.PNNCRRGU = row.Cells("NCRRGU").Value
                oPreDoc_B.PSCDVSN = row.Cells("CDVSN").Value
                oPreDoc_B.PNCPLNDV = row.Cells("CPLNDV").Value
                oPreDoc_B.PNCSRVC = row.Cells("CSRVC").Value
                oPreDoc_B.PNQATNAN = 1

                oPreDoc_B.PSFAJIMP = ("" & row.Cells("FAJIMP").Value).ToString.Trim   ' ""   'FAJIMP
                oPreDoc_B.PNCCNLT = row.Cells("CCLNT").Value

                olistPreDoc_B.Add(oPreDoc_B)

                FinBusqueda = True
                Exit For
            End If

        Next

        '------------------------------


        If FinBusqueda = False Then

            For Each row As DataGridViewRow In dtgOpPendientes.Rows

                pClave = row.Cells("ADETDOC").Value & "_" & row.Cells("PDETDOC").Value & "_" & row.Cells("IGVDOC").Value

                If pClaveSeleccionada = pClave Then
                    oPreDoc_B = New PreDoc_BE
                    oPreDoc_B.ADETDOC = row.Cells("ADETDOC").Value
                    oPreDoc_B.PDETDOC = row.Cells("PDETDOC").Value
                    oPreDoc_B.IGVDOC = row.Cells("IGVDOC").Value
                    oPreDoc_B.PSCCMPN = pCCMPN
                    oPreDoc_B.PNNRCTRL = pNRLQD
                    oPreDoc_B.PSTIPOPL = pTIPOPL
                    oPreDoc_B.SERVICIO = row.Cells("SERVICIO").Value
                    oPreDoc_B.MONEDA = row.Cells("MONEDA").Value

                    Importe = row.Cells("IMPDOC").Value
                    If (TotalAcumulado + Importe) < TotalGenerarPreDoc Then
                        TotalAcumulado = TotalAcumulado + Importe
                        oPreDoc_B.PNIVLSRV = Importe
                    Else
                        Importe = TotalGenerarPreDoc - TotalAcumulado
                        oPreDoc_B.PNIVLSRV = Importe
                        FinBusqueda = True
                    End If

                    oPreDoc_B.PNNOPRCN = row.Cells("NOPRCN").Value
                    oPreDoc_B.PNCMNDA1 = row.Cells("CMNDA1").Value
                    oPreDoc_B.PSTPOPER = row.Cells("TPOPER").Value
                    oPreDoc_B.PNNGUIRM = row.Cells("NGUIRM").Value
                    oPreDoc_B.PNNCRROP = row.Cells("NCRROP").Value
                    oPreDoc_B.PNNGUITR = row.Cells("NGUITR").Value
                    oPreDoc_B.PNNCRRGU = row.Cells("NCRRGU").Value
                    oPreDoc_B.PSCDVSN = row.Cells("CDVSN").Value
                    oPreDoc_B.PNCPLNDV = row.Cells("CPLNDV").Value
                    oPreDoc_B.PNCSRVC = row.Cells("CSRVC").Value
                    oPreDoc_B.PNQATNAN = 1

                    oPreDoc_B.PSFAJIMP = ("" & row.Cells("FAJIMP").Value).ToString.Trim ' ""
                    oPreDoc_B.PNCCNLT = row.Cells("CCLNT").Value

                    olistPreDoc_B.Add(oPreDoc_B)

                    If FinBusqueda = True Then
                        Exit For
                    End If

                End If

            Next

        End If

        'objfrmGenerarPDoc.desMon = pDescMoneda
        objfrmGenerarPDoc.desMon = cmbMoneda.Text
        objfrmGenerarPDoc.ListPre_Doc = olistPreDoc_B
        objfrmGenerarPDoc.pCCMPN = Me.pCCMPN
        objfrmGenerarPDoc.pNRLQD = Me.pNRLQD
        objfrmGenerarPDoc.pTIPOPL = Me.pTIPOPL
        'objfrmGenerarPDoc.pCodMoneda = Me.pCodMoneda
        objfrmGenerarPDoc.pCodMoneda = cmbMoneda.SelectedValue

        If objfrmGenerarPDoc.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim nuevoTotal As Decimal = 0

            GetEstadoPL()
            ListarPlDocumentos()
            ListarPendDocumentos()
            For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1
                nuevoTotal = nuevoTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value
            Next
            txtMontoPend.Text = nuevoTotal
            'pDialog = True
            Exit Sub
        End If

    End Sub
    Private Sub GenerarPreDoc_Manual()
        Dim primerRegistro As String = ""
        Dim pActual As String = ""
        Dim regValido As Boolean = True


        For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1
            If dtgOpPendientes.Item("CHK", intIndice).Value = True Then
                If primerRegistro = "" Then
                    primerRegistro = dtgOpPendientes.Item("ADETDOC", intIndice).Value & "_" & dtgOpPendientes.Item("PDETDOC", intIndice).Value & "_" & dtgOpPendientes.Item("IGVDOC", intIndice).Value
                End If
                pActual = dtgOpPendientes.Item("ADETDOC", intIndice).Value & "_" & dtgOpPendientes.Item("PDETDOC", intIndice).Value & "_" & dtgOpPendientes.Item("IGVDOC", intIndice).Value
                If pActual <> primerRegistro Then
                    regValido = False
                    Exit For
                End If

            End If

        Next

        If regValido = False Then
            MessageBox.Show("Los registros seleccionados deben tener mismo IGV/Detracción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim oPreDoc_BE As New PreDoc_BE
        Dim olistPreDoc_BE As New List(Of PreDoc_BE)
        Dim objfrmGenerarPDoc As New frmGenerarPDoc
        Me.dtgOpPendientes.EndEdit()

        For Each row As DataGridViewRow In dtgOpPendientes.Rows
            If row.Cells("CHK").Value = True Then
                oPreDoc_BE = New PreDoc_BE
                oPreDoc_BE.PSCCMPN = pCCMPN
                oPreDoc_BE.PNNRCTRL = pNRLQD
                oPreDoc_BE.PSTIPOPL = pTIPOPL
                oPreDoc_BE.SERVICIO = row.Cells("SERVICIO").Value
                oPreDoc_BE.MONEDA = row.Cells("MONEDA").Value
                oPreDoc_BE.PNIVLSRV = row.Cells("PNIMDOC").Value
                oPreDoc_BE.PNNOPRCN = row.Cells("NOPRCN").Value
                oPreDoc_BE.PNCMNDA1 = row.Cells("CMNDA1").Value
                oPreDoc_BE.PSTPOPER = row.Cells("TPOPER").Value
                oPreDoc_BE.PNNGUIRM = row.Cells("NGUIRM").Value
                oPreDoc_BE.PNNCRROP = row.Cells("NCRROP").Value
                oPreDoc_BE.PNNGUITR = row.Cells("NGUITR").Value
                oPreDoc_BE.PNNCRRGU = row.Cells("NCRRGU").Value
                oPreDoc_BE.PSCDVSN = row.Cells("CDVSN").Value
                oPreDoc_BE.PNCPLNDV = row.Cells("CPLNDV").Value
                oPreDoc_BE.PNCSRVC = row.Cells("CSRVC").Value
                oPreDoc_BE.PSCULUSA = ConfigurationWizard.UserName
                oPreDoc_BE.PSNTRMNL = HelpClass.NombreMaquina
                oPreDoc_BE.PNQATNAN = 1
                oPreDoc_BE.PSFAJIMP = ("" & row.Cells("FAJIMP").Value).ToString.Trim ' ""
                oPreDoc_BE.PNCCNLT = row.Cells("CCLNT").Value
                olistPreDoc_BE.Add(oPreDoc_BE)
            End If
        Next


        If olistPreDoc_BE.Count = 0 Then
            MessageBox.Show("No ha seleccionado registros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dtgOpPendientes.CurrentRow.Cells("CHK").Value = True Then
            If dtgOpPendientes.CurrentRow.Cells("PNIMDOC").Value = 0 Then
                MessageBox.Show("Importe documento debe ser mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        objfrmGenerarPDoc.ListPre_Doc = olistPreDoc_BE
        'objfrmGenerarPDoc.desMon = pDescMoneda
        objfrmGenerarPDoc.desMon = cmbMoneda.Text
        objfrmGenerarPDoc.pCCMPN = Me.pCCMPN
        objfrmGenerarPDoc.pNRLQD = Me.pNRLQD
        objfrmGenerarPDoc.pTIPOPL = Me.pTIPOPL
        'objfrmGenerarPDoc.pCodMoneda = Me.pCodMoneda
        objfrmGenerarPDoc.pCodMoneda = cmbMoneda.SelectedValue


        If objfrmGenerarPDoc.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GetEstadoPL()
            ListarPlDocumentos()
            ListarPendDocumentos()
            txtTotalS.Text = 0
            txtTotalG.Text = 0
            'pDialog = True
        End If
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Dim nuevoImporte As Decimal = 0
        Try

            If EsPLModificable() = False Then
                MessageBox.Show("PL liberado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            pDialog = True
            If cblTipo.SelectedValue = "01" Then
                GenerarPreDoc_Por_Importe()
            End If
            If cblTipo.SelectedValue = "02" Then
                GenerarPreDoc_Manual()
            End If

            ActualizarSeleccionMoneda()
            '---------------------------------------------------------------------------------------------

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dtgOpPendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOpPendientes.CellContentClick, dtgOpPendientes.CellContentDoubleClick

        Dim pTotal As New Decimal
        pTotal = 0
        Dim ImpTotal As New Decimal
        ImpTotal = 0
        Try

            If e.RowIndex = -1 Then Exit Sub

            If dtgOpPendientes.RowCount > 0 Then

                If dtgOpPendientes.Columns(e.ColumnIndex).Name = "CHK" Then


                    If dtgOpPendientes.CurrentCellAddress.Y < 0 Then Exit Sub

                    dtgOpPendientes.Rows(e.RowIndex).Cells("PNIMDOC").ReadOnly = True



                    If dtgOpPendientes.Rows(e.RowIndex).Cells("IMPDOC").Value > 0 Then

                        If dtgOpPendientes.Rows(e.RowIndex).Cells("CHK").Value Then

                            dtgOpPendientes.Rows(e.RowIndex).Cells("CHK").Value = False

                            dtgOpPendientes.Rows(e.RowIndex).Cells("PNIMDOC").Value = 0




                        Else

                            dtgOpPendientes.Rows(e.RowIndex).Cells("CHK").Value = True

                            dtgOpPendientes.Rows(e.RowIndex).Cells("PNIMDOC").Value = dtgOpPendientes.Rows(e.RowIndex).Cells("IMPDOC").Value


                            dtgOpPendientes.Rows(e.RowIndex).Cells("PNIMDOC").ReadOnly = False



                        End If

                    Else

                        dtgOpPendientes.EndEdit()

                        dtgOpPendientes.Rows(e.RowIndex).Cells("CHK").Value = False

                        dtgOpPendientes.Rows(e.RowIndex).Cells("PNIMDOC").Value = 0





                    End If
                End If



                For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                    ImpTotal = ImpTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value

                Next
                txtMontoPend.Text = ImpTotal

                For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                    pTotal = pTotal + dtgOpPendientes.Item("PNIMDOC", intIndice).Value

                Next
                txtTotalS.Text = pTotal



            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub dtgOpPendientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOpPendientes.CellEndEdit
        Dim intCont As Integer = 0

        Dim ColumName As String
        Dim ImpTotal As New Decimal
        ImpTotal = 0
        Dim pendiente As Decimal
        Dim pTotal As New Decimal
        pTotal = 0
        Dim strMensajeError As String = ""

        Try

            With dtgOpPendientes

                pendiente = .CurrentRow.Cells("IMPDOC").Value

                Select Case .Columns(e.ColumnIndex).Name

                    Case "PNIMDOC"

                        intCont = 0

                        If .CurrentCell.Value = 0 Then

                            .CurrentCell.Value = 0D

                        Else

                            Dim decTemp As Decimal = 0D

                            Decimal.TryParse("" & .CurrentCell.Value, decTemp)

                            .CurrentCell.Value = decTemp

                        End If

                        If .CurrentCell.Value < 0 Then

                            strMensajeError = "Cant. a recepcionar debe ser mayor a cero o igual."

                            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            .CurrentCell.Value = 0D



                        ElseIf .CurrentCell.Value > pendiente Then

                            strMensajeError = "Cant. a recepcionar debe ser menor a la cantidad pendiente."

                            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            .CurrentCell.Value = 0D

                        End If

                        For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                            ImpTotal = ImpTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value

                        Next
                        txtMontoPend.Text = ImpTotal

                        For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                            pTotal = pTotal + dtgOpPendientes.Item("PNIMDOC", intIndice).Value

                        Next
                        txtTotalS.Text = pTotal


                End Select

                ColumName = .Columns(e.ColumnIndex).Name


            End With

        Catch ex As Exception

            dtgOpPendientes.CurrentCell.Value = 0

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub dtgOpPendientes_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtgOpPendientes.EditingControlShowing

        Dim colName As String = ""

        Try

            Dim Texto As New TextBox

            If TypeOf e.Control Is TextBox Then

                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal ' Comun.SoloNumerosConDecimal '.Event_KeyPress_NumeroWithDecimal

            End If

            colName = dtgOpPendientes.Columns(dtgOpPendientes.CurrentCell.ColumnIndex).Name

            Select Case colName

                Case "PNIMDOC"

                    Texto = CType(e.Control, TextBox)

                    Texto.Text = Texto.Text.Trim

                    Texto.Tag = "10-5"

                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal


            End Select

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub



    Private Sub cblTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipo.SelectionChangeCommitted
        Try
            If cblTipo.SelectedValue = "01" Then 'cblTipo.SelectedValue <> "" Then
                dtgOpPendientes.Columns("CHK").Visible = False
                dtgOpPendientes.Columns("PNIMDOC").Visible = False
                Me.lblTotal.Visible = True
                Me.txtMontoPend.Visible = True
                Me.lblTotalSeleccionado.Visible = False
                Me.txtTotalS.Visible = False
                Me.lblMoneda.Visible = True
                Me.lblTotal.Visible = True
                Me.lblMonto.Visible = True
                Me.txtTotalG.Visible = True
            Else
                dtgOpPendientes.Columns("CHK").Visible = True
                dtgOpPendientes.Columns("PNIMDOC").Visible = True
                Me.lblTotalSeleccionado.Visible = True
                Me.txtTotalS.Visible = True
                Me.lblTotal.Visible = False
                Me.txtMontoPend.Visible = False
                Me.lblMoneda.Visible = False
                Me.lblTotal.Visible = False
                Me.txtTotalG.Visible = False
                Me.lblMonto.Visible = False

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEliminarPDoc_Click(sender As Object, e As EventArgs) Handles btnEliminarPDoc.Click
        Try

            Dim obrPreDoc_BE As New clsPreDoc_BL
            If dtgPreDocumentos.Rows.Count = 0 Then
                MessageBox.Show("No existen registros a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If EsPLModificable() = False Then
                MessageBox.Show("PL liberado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Está seguro de eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            pDialog = True

            dtgPreDocumentos.EndEdit()
            Dim oPreDoc_BE As New PreDoc_BE
            Dim sErrorMesage As String = ""

            Dim sStatus As String = ""
            Dim strmsg As String = ""
            oPreDoc_BE.PSCCMPN = pCCMPN
            oPreDoc_BE.PNNRCTRL = pNRLQD
            oPreDoc_BE.PSTPCTRL = dtgPreDocumentos.CurrentRow.Cells("TPCTRL").Value
            oPreDoc_BE.PNNCRRPD = dtgPreDocumentos.CurrentRow.Cells("NCRRPD").Value
            oPreDoc_BE.PSNTRMNL = HelpClass.NombreMaquina
            oPreDoc_BE.PSCULUSA = ConfigurationWizard.UserName

            strmsg = obrPreDoc_BE.EliminarCabDoc(oPreDoc_BE)

            ActualizarSeleccionMoneda()

            If strmsg.Length > 0 Then
                MessageBox.Show(strmsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ListarPlDocumentos()
                ListarPendDocumentos()
                Dim nuevoTotal As Decimal = 0
                For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                    nuevoTotal = nuevoTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value

                Next
                txtMontoPend.Text = nuevoTotal

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bntLibPL_Click(sender As Object, e As EventArgs) Handles bntLibPL.Click

        Try



            Dim bePreDoc As PreDoc_BE
            Dim obePreDoc As New clsPreDoc_BL
            Dim msg As String = ""
            Dim msgOpPend As String = ""
            Dim MontoPendiente As Decimal = 0

            For Each item As DataGridViewRow In dtgOpPendientes.Rows
                MontoPendiente = MontoPendiente + item.Cells("IMPDOC").Value
            Next

            If dtgOpPendientes.Rows.Count > 0 Then
                msgOpPend = "con servicios pendientes para generar."
            End If

            'If CodEstadoPL = "A" And dtgPreDocumentos.Rows.Count > 0 Then
            '    MessageBox.Show("PL liberado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            If CodEstadoPL = "L" Then
                MessageBox.Show("PL liberado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If dtgPreDocumentos.Rows.Count = 0 Then
                MessageBox.Show("PL sin Pre-Documentos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Está seguro de liberar PL" & Chr(10) & msgOpPend, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            pDialog = True

            Dim oListVR As New List(Of PreDoc_BE)
            Dim oPreDoc_BE_VR As PreDoc_BE

            bePreDoc = New PreDoc_BE
            bePreDoc.PSCCMPN = pCCMPN
            bePreDoc.PNNRCTRL = pNRLQD
            bePreDoc.PSTIPOPL = pTIPOPL
            'bePreDoc.PNCMNDA1 = pCodMoneda
            bePreDoc.PNCMNDA1 = cmbMoneda.SelectedValue
            bePreDoc.PNIMPOPEND = MontoPendiente
            bePreDoc.PSCULUSA = ConfigurationWizard.UserName
            bePreDoc.PSNTRMNL = HelpClass.NombreMaquina


            Dim ds_ValorREf As New DataSet
            Dim dtOp As New DataTable
            Dim dtVR As New DataTable
            Dim drVR() As DataRow
            Dim ImpoPreDoc As Decimal = 0
            Dim TotPorrateoVR As Decimal = 0
            Dim ValorRefServ As Decimal = 0
            'Dim VarRef As Decimal = 0

            If pTIPOPL = "T" Then

                ds_ValorREf = obePreDoc.ListarDetallePL_ValorReferencial(bePreDoc)
                dtOp = ds_ValorREf.Tables(0).Copy
                dtVR = ds_ValorREf.Tables(1).Copy
                dtVR.Columns.Add("VR_ITEMPREDOC", Type.GetType("System.Decimal"))


                For Each item As DataRow In dtOp.Rows
                    ValorRefServ = item("VLRFDT")
                    drVR = dtVR.Select("NOPRCN='" & item("NOPRCN") & "' AND NGUIRM='" & item("NGUITR") & "' AND NCRRGU=' " & item("NCRRGU") & "'")

                    ImpoPreDoc = 0
                    TotPorrateoVR = 0
                    For Each itemServ As DataRow In drVR '.Rows
                        ImpoPreDoc = ImpoPreDoc + itemServ("IVLSRV")
                    Next
                    For Each itemServ As DataRow In drVR ' dtVR.Rows
                        'VarRef = itemServ("IVLSRV")
                        itemServ("VR_ITEMPREDOC") = Math.Round((itemServ("IVLSRV") / ImpoPreDoc) * ValorRefServ, 2)  '   Math.Round(VarRef / ImpoPreDoc, 2, MidpointRounding.AwayFromZero) * ValorRefServ
                        TotPorrateoVR = TotPorrateoVR + itemServ("VR_ITEMPREDOC")
                    Next
                    If drVR.Length > 0 Then
                        drVR(drVR.Length - 1)("VR_ITEMPREDOC") = drVR(drVR.Length - 1)("VR_ITEMPREDOC") + ValorRefServ - TotPorrateoVR
                    End If

                    For Each itemServ As DataRow In drVR
                        oPreDoc_BE_VR = New PreDoc_BE
                        oPreDoc_BE_VR.PSCCMPN = pCCMPN
                        oPreDoc_BE_VR.PNNRCTRL = pNRLQD
                        oPreDoc_BE_VR.PSTIPOPL = pTIPOPL
                        oPreDoc_BE_VR.PNNCRRPD = itemServ("NCRRPD")
                        oPreDoc_BE_VR.PNCRIPD = itemServ("NCRIPD")
                        oPreDoc_BE_VR.PNVLRFDT = itemServ("VR_ITEMPREDOC")
                        oListVR.Add(oPreDoc_BE_VR)
                    Next


                Next
            End If


            msg = obePreDoc.LiberarPL(bePreDoc)
            If msg = "" Then
                For Each itemPreDoc As PreDoc_BE In oListVR
                    obePreDoc.ActualizarDetallePL_ValorReferencial(itemPreDoc)
                Next
                ListarPlDocumentos()
            End If
            If msg.Length > 0 Then
                MessageBox.Show("No se pudo liberar" & Chr(13) & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                GetEstadoPL()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            Dim nuevoRegistro As String = ""
            Dim ofrmAjustarImporte As New frmAjustarImporte

            If dtgOpPendientes.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ImpoPendiente As Decimal = 0
            For Each item As DataGridViewRow In dtgOpPendientes.Rows
                If ("" & item.Cells("FAJIMP").Value).ToString.Trim = "X" Then
                    MessageBox.Show("No puede adicionar. El registro ya tiene ajuste", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    ImpoPendiente = ImpoPendiente + item.Cells("IMPDOC").Value
                End If

            Next


            If dtListPendiente.Columns("FAJIMP") Is Nothing Then
                dtListPendiente.Columns.Add("FAJIMP")
            End If
            If dtListPendiente.Columns("DESC_FAJIMP") Is Nothing Then
                dtListPendiente.Columns.Add("DESC_FAJIMP")
            End If

            dtgOpPendientes.DataSource = dtListPendiente

            ofrmAjustarImporte.pServicio = dtgOpPendientes.CurrentRow.Cells("SERVICIO").Value
            'ofrmAjustarImporte.pDescMoned = pDescMoneda
            ofrmAjustarImporte.pDescMoned = cmbMoneda.Text
            ofrmAjustarImporte.pOper = dtgOpPendientes.CurrentRow.Cells("NOPRCN").Value
            ofrmAjustarImporte.pNRLQD = pNRLQD
            ofrmAjustarImporte.pTIPOPL = pTIPOPL
            ofrmAjustarImporte.pCCMPN = pCCMPN
            'ofrmAjustarImporte.pCMNDA1 = pCodMoneda
            ofrmAjustarImporte.pCMNDA1 = cmbMoneda.SelectedValue
            ofrmAjustarImporte.pImpoPendiente = ImpoPendiente

            If ofrmAjustarImporte.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim drPrueba As DataRow
                drPrueba = dtListPendiente.NewRow
                drPrueba("AFECTO_DET") = dtgOpPendientes.CurrentRow.Cells("ADETDOC").Value
                drPrueba("POR_DETRACCION") = dtgOpPendientes.CurrentRow.Cells("PDETDOC").Value
                drPrueba("PIGVA") = dtgOpPendientes.CurrentRow.Cells("IGVDOC").Value
                drPrueba("NOPRCN") = dtgOpPendientes.CurrentRow.Cells("NOPRCN").Value
                drPrueba("SERVICIO") = dtgOpPendientes.CurrentRow.Cells("SERVICIO").Value
                drPrueba("FAJIMP") = "X"
                drPrueba("DESC_FAJIMP") = "AJUSTE"

                drPrueba("MONEDA") = dtgOpPendientes.CurrentRow.Cells("MONEDA").Value
                drPrueba("IMPORTE_PENDTE") = ofrmAjustarImporte.txtAjuste.Text
                drPrueba("ID_MON_IMPORTE") = dtgOpPendientes.CurrentRow.Cells("CMNDA1").Value



                drPrueba("TPOPER") = dtgOpPendientes.CurrentRow.Cells("TPOPER").Value
                drPrueba("NGUIRM") = dtgOpPendientes.CurrentRow.Cells("NGUIRM").Value
                drPrueba("NCRROP") = dtgOpPendientes.CurrentRow.Cells("NCRROP").Value
                drPrueba("NGUITR") = dtgOpPendientes.CurrentRow.Cells("NGUITR").Value
                drPrueba("NCRRGU") = dtgOpPendientes.CurrentRow.Cells("NCRRGU").Value
                drPrueba("CDVSN") = dtgOpPendientes.CurrentRow.Cells("CDVSN").Value
                drPrueba("CPLNDV") = dtgOpPendientes.CurrentRow.Cells("CPLNDV").Value
                drPrueba("CSRVC") = dtgOpPendientes.CurrentRow.Cells("CSRVC").Value
                drPrueba("CCLNT") = dtgOpPendientes.CurrentRow.Cells("CCLNT").Value

                drPrueba("ID_MON_SERV") = dtgOpPendientes.CurrentRow.Cells("CMNDA1").Value
                drPrueba("QATNAN") = 1
                drPrueba("IVLSRV") = ofrmAjustarImporte.txtAjuste.Text.Trim
                drPrueba("IMPORTE_SERV") = ofrmAjustarImporte.txtAjuste.Text.Trim




                For Each item As DataRow In dtListPendiente.Rows
                    item("PIGVA") = Val("" & item("PIGVA"))
                Next
                dtListPendiente.Rows.InsertAt(drPrueba, 0)
                dtgOpPendientes.DataSource = dtListPendiente

                Dim nuevoTotal As Decimal = 0
                For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                    nuevoTotal = nuevoTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value

                Next
                txtMontoPend.Text = nuevoTotal
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub dtgPreDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPreDocumentos.CellContentClick
        If e.RowIndex >= 0 Then
            If dtgPreDocumentos.Columns(e.ColumnIndex).Name = "OPERACION" Then

                Dim objfrmOperacion As New frmOperacionesXPreDoc

                objfrmOperacion.PSCCMPN = pCCMPN
                objfrmOperacion.PNNRCTRL = pNRLQD
                objfrmOperacion.PSTPCTRL = Me.dtgPreDocumentos.CurrentRow.Cells("TPCTRL").Value
                objfrmOperacion.PNNCRRPD = Me.dtgPreDocumentos.CurrentRow.Cells("NCRRPD").Value

                objfrmOperacion.ShowDialog()
            End If
        End If

    End Sub


    Private Sub dtgPreDocumentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPreDocumentos.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            If Me.dtgPreDocumentos.RowCount = 0 Then Exit Sub
            Dim lintEstado As Boolean = Me.dtgPreDocumentos.Item(0, 0).Value
            For lint_Contador As Integer = 0 To Me.dtgPreDocumentos.RowCount - 1
                Me.dtgPreDocumentos.Item(0, lint_Contador).Value = Not lintEstado
                Me.dtgPreDocumentos.EndEdit()
            Next
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try

            Dim i As Integer
            If dtgOpPendientes.RowCount = 0 Then Exit Sub
            Dim ofrmAjustarImporte As New frmAjustarImporte
            If dtListPendiente.Columns("FAJIMP") Is Nothing Then
                dtListPendiente.Columns.Add("FAJIMP")
            End If
            If dtListPendiente.Columns("DESC_FAJIMP") Is Nothing Then
                dtListPendiente.Columns.Add("DESC_FAJIMP")
            End If

            If Me.dtgOpPendientes.CurrentRow.Cells("DESC_FAJIMP").Value = "" Then

                MessageBox.Show("Solo es posible eliminar tipo AJUSTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            If Me.dtgOpPendientes.CurrentRow.Cells("DESC_FAJIMP").Value <> "" Then
                i = dtgOpPendientes.CurrentRow.Index
                dtgOpPendientes.Rows.RemoveAt(i)
            End If

            Dim nuevoTotal As Decimal = 0
            For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1

                nuevoTotal = nuevoTotal + dtgOpPendientes.Item("IMPDOC", intIndice).Value

            Next
            txtMontoPend.Text = nuevoTotal

        Catch ex As Exception
            MessageBox.Show("Solo es posible eliminar tipo AJUSTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function EsPLModificable() As Boolean
        Dim bmodificable As Boolean = True
        'If (CodEstadoPL = "A" Or CodEstadoPL = "") And dtgPreDocumentos.Rows.Count > 0 Then
        '    bmodificable = False
        'End If
        If (CodEstadoPL = "L") Then
            bmodificable = False
        End If
        Return bmodificable
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Try

            If dtgPreDocumentos.Rows.Count = 0 Then
                MessageBox.Show("No existen registros para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If EsPLModificable() = False Then
                MessageBox.Show("PL liberado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim ofrmEditPreDoC As New frmEditPreDoc
            ofrmEditPreDoC.pCCMPN = pCCMPN

            ofrmEditPreDoC.pNPRLQD = pNRLQD ' dtgPreDocumentos.CurrentRow.Cells("NPRLQD").Value
            ofrmEditPreDoC.pTIPOPL = pTIPOPL
            ofrmEditPreDoC.pNCRRPD = dtgPreDocumentos.CurrentRow.Cells("NCRRPD").Value
            ofrmEditPreDoC.pTPDCPE = dtgPreDocumentos.CurrentRow.Cells("TPDCPE").Value
            ofrmEditPreDoC.pTPCTRL = dtgPreDocumentos.CurrentRow.Cells("TPCTRL").Value
            ofrmEditPreDoC.pDoc = dtgPreDocumentos.CurrentRow.Cells("DCCLNT").Value
            ofrmEditPreDoC.pSubDoc = dtgPreDocumentos.CurrentRow.Cells("SBCLNT").Value
            ofrmEditPreDoC.pUser = ConfigurationWizard.UserName
            ofrmEditPreDoC.pMachine = HelpClass.NombreMaquina
            If ofrmEditPreDoC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.ListarPlDocumentos()
                pDialog = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub btnAnulLib_Click(sender As Object, e As EventArgs) Handles btnAnulLib.Click
        Try


            Dim bePreDoc As PreDoc_BE
            Dim obePreDoc As New clsPreDoc_BL
            Dim msg As String = ""

            If CodEstadoPL = "B" Then
                Exit Sub
            End If
            If dtgPreDocumentos.Rows.Count = 0 Then
                Exit Sub
            End If


            If MessageBox.Show("Está seguro de anular liberación PL." & Chr(10), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            pDialog = True

            bePreDoc = New PreDoc_BE
            bePreDoc.PSCCMPN = pCCMPN
            bePreDoc.PNNRCTRL = pNRLQD
            bePreDoc.PSTIPOPL = pTIPOPL
            bePreDoc.PSCULUSA = ConfigurationWizard.UserName
            bePreDoc.PSNTRMNL = HelpClass.NombreMaquina



            msg = obePreDoc.AnularLiberacionPL(bePreDoc)
            If msg = "" Then
                GetEstadoPL()
                ListarPlDocumentos()
            Else
                MessageBox.Show("No se pudo anular liberación." & Chr(13) & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbMoneda_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMoneda.SelectionChangeCommitted
        Try

            ListarPendDocumentos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class