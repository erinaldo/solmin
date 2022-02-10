Imports SOLMIN_SC.Negocio
Public Class frmBuscar
    Private intTipoG As Integer
    Private dblCliente As Double
    'Private bolValCheck As Boolean
    Private oPreEmbarque As clsPreEmbarque
    Private dblCantidadAnterior As Double
    Private pCCMPN As String = ""
    Private pCCMPN_DESC As String = ""
    Private pSCDVSN As String = ""
    Private pNCPLNDV As Decimal = 0
    Private dtItemOrdenCompra As New DataTable

    Public Sub New(ByVal pdblCliente As Double, ByVal _pCCMPN As String, ByVal _pCCMPN_DESC As String, ByVal _pSCDVSN As String, ByVal _pNCPLNDV As Decimal)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        intTipoG = 0
        dblCliente = pdblCliente
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

    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgBusqueda.AutoGenerateColumns = False
            dtgBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            lblCompania.Text = pCCMPN & "-" & pCCMPN_DESC
           
            LlenarNivelDetalle()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



    Private Sub Llenar_dtgBusqueda(ByVal oDt As DataTable)
        dtgBusqueda.DataSource = Nothing
        Dim oDetOC As New clsDetOC
        Dim Filas As Integer = 0
        cboTipo.BeginUpdate()
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


    'Private Sub Llenar_dtgBusqueda()
    '    dtgBusqueda.Rows.Clear()
    '    Try
    '        Dim oDrVw As DataGridViewRow
    '        Dim oDt As DataTable
    '        Dim oDetOC As New clsDetOC
    '        Dim strOC As String
    '        Dim intCont As Integer

    '        strOC = Me.txtFilOC.Text.ToUpper.Trim

    '        oDt = oDetOC.Busca_Det_OC(dblCliente, strOC)
    '        Dim Filas As Integer = 0
    '        With oDt
    '            If oDt.Rows.Count > 0 Then
    '                For intCont = 0 To .Rows.Count - 1
    '                    oDrVw = New DataGridViewRow
    '                    oDrVw.CreateCells(Me.dtgBusqueda)
    '                    dtgBusqueda.Rows.Add(oDrVw)
    '                    Filas = dtgBusqueda.Rows.Count - 1
    '                    dtgBusqueda.Rows(Filas).Cells("NORCML").Value = .Rows(intCont).Item("NORCML").ToString.Trim
    '                    If Double.Parse(.Rows(intCont).Item("SALDO_PRE").ToString.Trim) > 0 Then
    '                        dtgBusqueda.Rows(Filas).Cells("VALIDAR").Value = True
    '                        dtgBusqueda.Rows(Filas).Cells("ASIGNACION").ReadOnly = False
    '                    Else
    '                        dtgBusqueda.Rows(Filas).Cells("ASIGNACION").Value = False
    '                        dtgBusqueda.Rows(Filas).Cells("ASIGNACION").ReadOnly = True
    '                        dtgBusqueda.Rows(Filas).Cells("VALIDAR").ReadOnly = True
    '                    End If
    '                    dtgBusqueda.Rows(Filas).Cells("NRITOC").Value = .Rows(intCont).Item("NRITOC").ToString.Trim
    '                    dtgBusqueda.Rows(Filas).Cells("SBITOC").Value = .Rows(intCont).Item("SBITOC").ToString.Trim
    '                    dtgBusqueda.Rows(Filas).Cells("TDITES").Value = .Rows(intCont).Item("TDITES").ToString.Trim

    '                    dtgBusqueda.Rows(Filas).Cells("SALDO_PRE").Value = .Rows(intCont).Item("SALDO_PRE")
    '                    dtgBusqueda.Rows(Filas).Cells("ASIGNACION").Value = .Rows(intCont).Item("SALDO_PRE")

    '                    dtgBusqueda.Rows(Filas).Cells("SOLICITADO").Value = .Rows(intCont).Item("SOLICITADO")
    '                    dtgBusqueda.Rows(Filas).Cells("PREEMBARCADO").Value = .Rows(intCont).Item("PREEMBARCADO")
    '                Next intCont
    '            End If
    '        End With


    '    Catch ex As Exception
    '        HelpUtil.MsgBox(ex.Message)
    '    End Try
    'End Sub

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
        Dim intCont As Integer
        Try

            Dim NORCML As String = ""
            Dim NRITOC As Decimal = 0
            Dim SBITOC As String = ""
            Dim ASIGNACION As Decimal = 0
            Dim SALDO_PRE As Decimal = 0
            Dim PNNRPEMB As Decimal = 0

            oPreEmbarque.Cliente = dblCliente
            oPreEmbarque.OC = Me.dtgBusqueda.Rows(Primer_Registro_Con_Check).Cells("NORCML").Value.ToString.Trim
            oPreEmbarque.Busca_Nro_Parcial()
            For intCont = 0 To dtgBusqueda.RowCount - 1

                NORCML = Me.dtgBusqueda.Rows(intCont).Cells("NORCML").Value
                NRITOC = Me.dtgBusqueda.Rows(intCont).Cells("NRITOC").Value
                SBITOC = Me.dtgBusqueda.Rows(intCont).Cells("SBITOC").Value.ToString.Trim
                ASIGNACION = Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value
                SALDO_PRE = Me.dtgBusqueda.Rows(intCont).Cells("SALDO_PRE").Value

                If Me.dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                    If (ASIGNACION <= SALDO_PRE) Then
                        If NORCML = oPreEmbarque.OC Then
                            PNNRPEMB = oPreEmbarque.Mantenimiento_PreEmbarque(pCCMPN, "I", 0, NRITOC, SBITOC, ASIGNACION, "A", pSCDVSN, pNCPLNDV)
                        Else
                            oPreEmbarque.OC = NORCML
                            oPreEmbarque.Busca_Nro_Parcial()
                            PNNRPEMB = oPreEmbarque.Mantenimiento_PreEmbarque(pCCMPN, "I", 0, NRITOC, SBITOC, ASIGNACION, "A", pSCDVSN, pNCPLNDV)
                        End If
                    End If
                End If
            Next
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox("Se grabaron correctamente los datos")

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtFilOC_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilOC.KeyUp
        Dim msg As String = ""
        If e.KeyValue = 13 Then
            btnBuscar_Click(btnBuscar, Nothing)
        End If
    End Sub


    Private Function ValidaIngreso() As String
        Dim msg As String = ""
        txtFilOC.Text = txtFilOC.Text.Trim
        If (txtFilOC.Text.Trim.Length < 2) Then
            msg = "Debe ingresar por lo menos 2 caracteres para la búsqueda."
        End If
        Return msg
    End Function
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
        txtFilOC.Focus()
        If Validar_Regitro() Then
            Dim NORCML As String = ""
            Dim NRITOC As Decimal = 0
            Dim SBITOC As String = ""
            Dim ASIGNACION As Decimal = 0
            Dim SALDO_PRE As Decimal = 0
            Dim intCont As Int32 = 0
            Dim ValidarPUnitario As Boolean = True
            Dim QPrecioUnitario As Decimal = 0
            Dim msg As String = ""
            For intCont = 0 To dtgBusqueda.RowCount - 1
                NORCML = Me.dtgBusqueda.Rows(intCont).Cells("NORCML").Value
                NRITOC = Me.dtgBusqueda.Rows(intCont).Cells("NRITOC").Value
                SBITOC = Me.dtgBusqueda.Rows(intCont).Cells("SBITOC").Value.ToString.Trim
                ASIGNACION = Me.dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value
                SALDO_PRE = Me.dtgBusqueda.Rows(intCont).Cells("SALDO_PRE").Value
                QPrecioUnitario = Me.dtgBusqueda.Rows(intCont).Cells("IVUNIT").Value
                If dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = True Then
                    If dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value Then
                        If (ASIGNACION > SALDO_PRE) Then
                            dtgBusqueda.Rows(intCont).Cells("ASIGNACION").Value = SALDO_PRE
                        End If
                    End If
                    If QPrecioUnitario = 0 Then
                        ValidarPUnitario = False
                    End If
                End If
            Next
            msg = "Verifique las cantidades asignadas."
            If ValidarPUnitario = False Then
                msg = msg & Chr(13) & "Existen items a preembarcar con precio unitario cero.Esto afectará"
                msg = msg & Chr(13) & "la posterior distribución de costeo de orden de compra."
                msg = msg & Chr(13) & "Desea preembarcar de todas maneras?"
                msg = msg.Trim
            Else
                msg = msg & Chr(13) & "Está seguro de PreEmbarcar?"
            End If
            ' msg = msg & Chr(13) & "Verifique las cantidades asignadas.Está seguro de PreEmbarcar"
            If (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes) Then
                Crear_PreEmbarque()
                Me.txtFilOC.Text = vbNullString
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            MessageBox.Show("No existen ítems seleccionados a PreEmbarcar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        dtItemOrdenCompra.Rows.Clear()
        Dim strOC As String = ""
        Try
            Dim msg As String = ""
            msg = ValidaIngreso()
            If (msg.Length <> 0) Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'bolValCheck = False
            strOC = Me.txtFilOC.Text.ToUpper.Trim
            Dim OPC As String = cboTipo.SelectedValue
            Dim cclnt As Decimal = dblCliente
            Dim oDetOC As New clsDetOC
            dtItemOrdenCompra = oDetOC.Busca_Det_OC(dblCliente, strOC)
            Dim dtTempItemOC As New DataTable
            dtTempItemOC = ObtenerSoloItems(OPC, dtItemOrdenCompra)
            Llenar_dtgBusqueda(dtTempItemOC)

        Catch ex As Exception
            cboTipo.Enabled = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
      
    End Sub


    Private Function ObtenerSoloItems(ByVal OPC As String, ByVal dtItemOC As DataTable) As DataTable
        Dim dtTempItemOC As New DataTable
        Dim LisHasVisitados As New Hashtable
        Dim Item As String = ""
        Select Case OPC
            Case "SUB"
                dtTempItemOC = dtItemOC.Copy
            Case "ITE"
                dtTempItemOC = dtItemOC.Copy
                Dim TotFilas As Int32 = dtTempItemOC.Rows.Count - 1
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
        End Select
        Return dtTempItemOC
    End Function


    Private Sub dtgBusqueda_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgBusqueda.DataError

    End Sub
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
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

  
    Private Sub cboTipo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectionChangeCommitted
        Try
            Dim OPC As String = cboTipo.SelectedValue
            Dim dtTempItemOC As New DataTable
            dtTempItemOC = ObtenerSoloItems(OPC, dtItemOrdenCompra)
            Llenar_dtgBusqueda(dtTempItemOC)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


  
End Class
