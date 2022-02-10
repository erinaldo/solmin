Imports SOLMIN_SC.Negocio
Public Class frmBuscarOC
    Private intTipoG As Integer
    Private PNCCLNT As Double
    Private PSNORCML As String = ""
    Private PNNRPARC As Decimal = 0
    Private PSTCMPL As String = ""
    Private oPreEmbarque As clsPreEmbarque
    Private dblCantidadAnterior As Double
    Private pCCMPN As String = ""
    Private pCCMPN_DESC As String = ""
    Private pSCDVSN As String = ""
    Private pNCPLNDV As Decimal = 0
    Private dsItem As New DataSet

    Public Sub New(ByVal _pCCMPN As String, ByVal _pCCMPN_DESC As String, ByVal TCMPL As String, ByVal pdblCliente As Double, ByVal OC As String, ByVal PARCIAL As Decimal, ByVal _pSCDVSN As String, ByVal _pNCPLNDV As Decimal)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        intTipoG = 0
        PNCCLNT = pdblCliente
        PSNORCML = OC
        PNNRPARC = PARCIAL
        PSTCMPL = TCMPL
        oPreEmbarque = New clsPreEmbarque
        pCCMPN = _pCCMPN
        pCCMPN_DESC = _pCCMPN_DESC
        pSCDVSN = _pSCDVSN
        pNCPLNDV = _pNCPLNDV
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Sub LlenarNivelDetalle()
        Dim dtTipoItem As New DataTable
        dtTipoItem.Columns.Add("DISPLAY")
        dtTipoItem.Columns.Add("VALUE")

        Dim dr As DataRow
        dr = dtTipoItem.NewRow
        dr("DISPLAY") = "SubItem"
        dr("VALUE") = "SUB"
        dtTipoItem.Rows.Add(dr)

        dr = dtTipoItem.NewRow
        dr("DISPLAY") = "Item"
        dr("VALUE") = "ITE"
        dtTipoItem.Rows.Add(dr)

        cboTipo.DataSource = dtTipoItem
        cboTipo.DisplayMember = "DISPLAY"
        cboTipo.ValueMember = "VALUE"
        cboTipo.SelectedValue = "SUB"
    End Sub

    Private Sub frmBuscarOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgBusqueda.AutoGenerateColumns = False
            LlenarNivelDetalle()
            txtCliente.Text = PSTCMPL
            txtOrdenCompra.Text = PSNORCML
            txtParcial.Text = PNNRPARC
            dtgBusqueda.DataSource = Nothing

            Dim oDetOC As New clsDetOC
            dsItem = oDetOC.Busca_Det_OC_ADICION_PARCIAL(PNCCLNT, PSNORCML, PNNRPARC)
            Dim dtItem As New DataTable
            Dim dtItemPreEmb As New DataTable
            Dim dtTempItemOC As New DataTable
            dtItem = dsItem.Tables("ITEM_ORDEN").Copy
            dtItemPreEmb = dsItem.Tables("ITEM_PREEMB").Copy
            Dim OPC As String = cboTipo.SelectedValue
            dtTempItemOC = ObtenerSoloItems(OPC, dtItem, dtItemPreEmb)
            Llenar_dtgBusqueda(dtTempItemOC)
            lblCompania.Text = pCCMPN & "-" & pCCMPN_DESC

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Llenar_dtgBusqueda(ByVal oDt As DataTable)
        'dsItem.Tables.Clear()
        dtgBusqueda.DataSource = Nothing
        'Dim oDt As DataTable
        'Dim oDetOC As New clsDetOC
        'Dim Filas As Integer = 0
        'cboTipo.BeginUpdate()
        'Dim dtItemPreEmb As New DataTable
        'dsItem = oDetOC.Busca_Det_OC_ADICION_PARCIAL(PNCCLNT, PSNORCML, PNNRPARC)
        'oDt = dsItem.Tables("ITEM_ORDEN").Copy
        'dtItemPreEmb = dsItem.Tables("ITEM_PREEMB").Copy
        dtgBusqueda.DataSource = oDt
        Dim SaldoPreEmb As Decimal = 0
        For index As Integer = 0 To dtgBusqueda.Rows.Count - 1
            SaldoPreEmb = dtgBusqueda.Rows(index).Cells("SALDO_PRE").Value
            If SaldoPreEmb > 0 Then
                dtgBusqueda.Rows(index).Cells("VALIDAR").Value = True
                dtgBusqueda.Rows(index).Cells("ASIGNACION").ReadOnly = False
            Else
                dtgBusqueda.Rows(index).Cells("ASIGNACION").Value = False
                dtgBusqueda.Rows(index).Cells("ASIGNACION").ReadOnly = True
                dtgBusqueda.Rows(index).Cells("VALIDAR").ReadOnly = True
            End If
        Next
        cboTipo.EndUpdate()
    End Sub

    Private Function Validar_Regitro() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgBusqueda.RowCount - 1
            If Me.dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                Return True
            End If
        Next intCont
        Return False
    End Function

    Private Function Primer_Registro_Con_Check() As Integer
        Dim intCont, intSum As Integer
        intSum = 0
        For intCont = 0 To dtgBusqueda.RowCount - 1
            If Me.dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                Return intCont
            End If
        Next intCont
        Return 0
    End Function

    Private Sub Crear_PreEmbarque()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim intCont As Integer
            Dim NORCML As String = ""
            Dim NRITOC As Decimal = 0
            Dim SBITOC As String = ""
            Dim ASIGNACION As Decimal = 0
            Dim PNNRPEMB As Decimal = 0
            oPreEmbarque.Cliente = PNCCLNT
            oPreEmbarque.OC = PSNORCML
            oPreEmbarque.Parcial = PNNRPARC
            For intCont = 0 To dtgBusqueda.RowCount - 1
                If Me.dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                    NORCML = Me.PSNORCML
                    NRITOC = Me.dtgBusqueda.Rows(intCont).Cells("NRITOC").Value
                    SBITOC = Me.dtgBusqueda.Rows(intCont).Cells("SBITOC").Value.ToString.Trim
                    ASIGNACION = Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value
                    PNNRPEMB = oPreEmbarque.Mantenimiento_PreEmbarque(pCCMPN, "I", 0, NRITOC, SBITOC, ASIGNACION, "A", pSCDVSN, pNCPLNDV)
                End If
            Next
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox("Se grabaron correctamente los datos")
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub dtgBusqueda_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBusqueda.CellClick
        Dim SELLECCIONADO As Boolean = False
        dtgBusqueda.EndEdit()
        If e.RowIndex > -1 Then
            dblCantidadAnterior = dtgBusqueda.Rows(e.RowIndex).Cells("SALDO_PRE").Value
            If (dtgBusqueda.Rows(e.RowIndex).Cells("VALIDAR").ReadOnly = False) Then
                SELLECCIONADO = dtgBusqueda.Rows(e.RowIndex).Cells("VALIDAR").Value
                If (dtgBusqueda.Columns(e.ColumnIndex).Name = "VALIDAR") Then
                    dtgBusqueda.Rows(e.RowIndex).Cells("VALIDAR").Value = Not SELLECCIONADO
                End If
            End If
        End If
        Dim intCont As Integer
        If e.RowIndex = -1 And dtgBusqueda.Columns(e.ColumnIndex).Name = "VALIDAR" Then
            Me.Cursor = Cursors.WaitCursor
            For intCont = 0 To Me.dtgBusqueda.Rows.Count - 1
                If Double.Parse(Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value.ToString.Trim) > 0 Then
                    dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = Not dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value
                End If
            Next intCont
            Me.Cursor = Cursors.Default
        End If
        dtgBusqueda.Focus()

    End Sub
    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer

        For intCont = 0 To dtgBusqueda.RowCount - 1
            If dtgBusqueda.Rows(intCont).Cells("SALDO_PRE").Value > 0 Then
                dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = blnEstado
            End If
        Next intCont
    End Sub

    'Private Sub dtgBusqueda_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBusqueda.CellValueChanged
    '    Try
    '        Me.Focus()
    '        If e.RowIndex > -1 And dtgBusqueda.Columns(e.ColumnIndex).Name = "ASIGNACION" Then
    '            dblCantidadAnterior = dtgBusqueda.Rows(e.RowIndex).Cells("SALDO_PRE").Value
    '            If IsNumeric(dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value) = False Then
    '                dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value = dblCantidadAnterior
    '            End If
    '            If (Double.Parse(dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value) > 0) Then
    '                'If (Double.Parse(dtgBusqueda.Rows(e.RowIndex).Cells("SALDO_PRE").Value) - Double.Parse(dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value) >= 0) Then
    '                '    dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value = Double.Parse(dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value)
    '                'Else
    '                '    dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value = dblCantidadAnterior
    '                '    HelpUtil.MsgBox("La cantidad excede al pendiente, debe colocar una cantidad menor")
    '                'End If
    '            Else
    '                dtgBusqueda.Rows(e.RowIndex).Cells("ASIGNACION").Value = dblCantidadAnterior
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Validar_Regitro() Then
            Dim NORCML As String = ""
            Dim NRITOC As Decimal = 0
            Dim SBITOC As String = ""
            Dim ASIGNACION As Decimal = 0
            Dim SALDO_PRE As Decimal = 0
            Dim intCont As Int32 = 0
            For intCont = 0 To dtgBusqueda.RowCount - 1
                NORCML = Me.dtgBusqueda.Rows(intCont).Cells("NORCML").Value
                NRITOC = Me.dtgBusqueda.Rows(intCont).Cells("NRITOC").Value
                SBITOC = Me.dtgBusqueda.Rows(intCont).Cells("SBITOC").Value.ToString.Trim
                ASIGNACION = Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value
                SALDO_PRE = Me.dtgBusqueda.Rows(intCont).Cells("SALDO_PRE").Value
                If Me.dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                    If (ASIGNACION > SALDO_PRE) Then
                        Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value = SALDO_PRE
                    End If
                End If
            Next
            If (MessageBox.Show("Verifique las cantidades asignadas.Está seguro de PreEmbarcar", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                Crear_PreEmbarque()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            MessageBox.Show("Seleccione los ítems a PreEmbarcar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub

   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Function ObtenerSoloItems(ByVal OPC As String, ByVal dtItem As DataTable, ByVal dtItemPreEmb As DataTable) As DataTable
        Dim dtTempItemOC As New DataTable
        Select Case OPC
            Case "SUB"
                dtTempItemOC = dtItem.Copy
            Case "ITE"
                dtTempItemOC = dtItem.Copy
                Dim pNRITOC As String = ""
                Dim oListItem As New Hashtable
                For Each ItemP As DataRow In dtItemPreEmb.Rows
                    pNRITOC = ("" & ItemP("NORCML")).ToString.Trim & "_" & ItemP("NRITOC")
                    If Not oListItem.Contains(pNRITOC) Then
                        oListItem.Add(pNRITOC, pNRITOC)
                    End If
                Next
                Dim Filas As Integer = 0
                Dim TotFilas As Int32 = dtTempItemOC.Rows.Count - 1
                Dim Item As String = ""
                Dim LisHasVisitados As New Hashtable
                For Fila As Integer = 0 To TotFilas
                    If Fila <= TotFilas Then
                        Item = ("" & dtTempItemOC.Rows(Fila)("NORCML")).ToString.Trim & "_" & dtTempItemOC.Rows(Fila)("NRITOC")
                        If Not LisHasVisitados.Contains(Item) Then
                            LisHasVisitados.Add(Item, Item)
                            dtTempItemOC.Rows(Fila)("SBITOC") = ""
                            dtTempItemOC.Rows(Fila)("TDITES") = dtTempItemOC.Rows(Fila)("TDITES_ITEM")
                            dtTempItemOC.Rows(Fila)("SALDO_PRE") = dtTempItemOC.Rows(Fila)("SALDO_PRE_ITEM")
                            dtTempItemOC.Rows(Fila)("SOLICITADO") = dtTempItemOC.Rows(Fila)("SOLICITADO_ITEM")
                            dtTempItemOC.Rows(Fila)("PREEMBARCADO") = dtTempItemOC.Rows(Fila)("PREEMBARCADO_ITEM")
                            dtTempItemOC.Rows(Fila)("ASIGNACION") = dtTempItemOC.Rows(Fila)("ASIGNACION_ITEM")
                        Else
                            dtTempItemOC.Rows.RemoveAt(Fila)
                            TotFilas = TotFilas - 1
                            Fila = Fila - 1
                        End If
                    End If
                Next
                TotFilas = dtTempItemOC.Rows.Count - 1
                For Fila As Integer = 0 To TotFilas
                    If Fila <= TotFilas Then
                        pNRITOC = ("" & dtTempItemOC.Rows(Fila)("NORCML")).ToString.Trim & "_" & dtTempItemOC.Rows(Fila)("NRITOC")
                        If oListItem.Contains(pNRITOC) Then
                            dtTempItemOC.Rows.RemoveAt(Fila)
                            TotFilas = TotFilas - 1
                            Fila = Fila - 1
                        End If
                    End If
                Next

        End Select
        Return dtTempItemOC
    End Function

    
    Private Sub cboTipo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectionChangeCommitted
        Try
            Dim dtItem As New DataTable
            Dim dtItemPreEmb As New DataTable
            Dim dtTempItemOC As New DataTable
            dtItem = dsItem.Tables("ITEM_ORDEN").Copy
            dtItemPreEmb = dsItem.Tables("ITEM_PREEMB").Copy
            Dim OPC As String = cboTipo.SelectedValue
            dtTempItemOC = ObtenerSoloItems(OPC, dtItem, dtItemPreEmb)
            Llenar_dtgBusqueda(dtTempItemOC)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgBusqueda_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgBusqueda.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim colName As String = ""
            colName = dtgBusqueda.Columns(dtgBusqueda.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "ASIGNACION"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgBusqueda_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgBusqueda.DataError

    End Sub
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
