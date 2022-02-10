Imports System.Globalization
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.WService
Imports System.Text

Public Class frmListarGastos
    ReadOnly liquidarOperacion As New LiquidarOperacion_BL
    Dim TotalCheckBoxes As Integer = 0
    Dim TotalCheckedCheckBoxes As Integer = 0
    Dim HeaderCheckBox As CheckBox = Nothing
    Dim IsHeaderCheckBoxClicked As Boolean = True

    Private _operacion As New Operacion_BE
    Public Property Operacion() As Operacion_BE
        Get
            Return _operacion
        End Get
        Set(ByVal value As Operacion_BE)
            _operacion = value
        End Set
    End Property

    Private Sub frmListarGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvListarGastos.AllowUserToAddRows = False
            dgvListarGastos.AllowUserToDeleteRows = False

            AddHeaderCheckBox()

            AddHandler HeaderCheckBox.KeyUp, AddressOf HeaderCheckBox_KeyUp
            AddHandler HeaderCheckBox.MouseClick, AddressOf HeaderCheckBox_MouseClick
            AddHandler dgvListarGastos.CellValueChanged, AddressOf dgvListarGastos_CellValueChanged
            AddHandler dgvListarGastos.CurrentCellDirtyStateChanged, AddressOf dgvListarGastos_CurrentCellDirtyStateChanged
            AddHandler dgvListarGastos.CellPainting, AddressOf dgvListarGastos_CellPainting

            BindGridView()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub BindGridView()
        dgvListarGastos.DataSource = GetDataSource()

        TotalCheckBoxes = dgvListarGastos.RowCount
        TotalCheckedCheckBoxes = 0
    End Sub

    Private Function GetDataSource() As DataTable
        Dim request As New LiquidacionGastos_ReqType
        Dim errorFound As Boolean = False
        'Dim errorMessage As New StringBuilder

        request.IM_BELNR = Operacion.NRFSAP
        request.IM_GJAHR = Operacion.AEJINS

        Dim wService As New LiquidacionGastosReq_Service
        Dim resultado As New LiquidacionGastos_ResType
        resultado = wService.LiquidacionGastos(request)

        Dim messages As String = ""
        Dim message As String = ""
        Dim tabla As New Hashtable()
        For Each item As RETURN_Type In resultado.List_RETURN
            message = ("" & item.MESSAGE).ToString.Trim
            If (("" & item.TYPE).ToString.Trim <> "S" AndAlso ("" & item.TYPE).ToString.Trim <> "") Then
                If (Not tabla.Contains(message) And message <> "") Then
                    tabla.Add(message, message)
                    messages = messages & item.MESSAGE & vbNewLine
                End If
            End If
        Next

        Dim listadoGasto As New DataTable
        messages = messages.Trim()
        If messages.Length > 0 Then
            MessageBox.Show(messages, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        listadoGasto.Columns.Add("NRFSAP") 'Ref Ped. SAP
        listadoGasto.Columns.Add("NOPRCN") 'Número Operación
        listadoGasto.Columns.Add("CGSTOS_SAP") '**oculto** Código Gasto SW
        listadoGasto.Columns.Add("COD_GASTO") 'Cod. Gasto
        listadoGasto.Columns.Add("TGSTOS") 'Gasto
        listadoGasto.Columns.Add("CDMNDA_SAP") '**oculto** Código Moneda SW
        listadoGasto.Columns.Add("COD_MONEDA") '**oculto** Código Moneda SAP
        listadoGasto.Columns.Add("TMNDA") 'Moneda
        listadoGasto.Columns.Add("IGSTOS") 'Importe Gastos
        listadoGasto.Columns.Add("FECINI") 'Fecha Inicio
        listadoGasto.Columns.Add("FECFIN") 'Fecha Fin
        listadoGasto.Columns.Add("TOBDCT") 'Observaciones

        Dim conceptoGastos As New DataSet()
        conceptoGastos = liquidarOperacion.ListarConceptoGastosEquivalenteSAP(Operacion.PSCCMPN)


        If resultado.List_ET_LIQSOLM IsNot Nothing Then   'Adicionado jm

            For Each item As ET_LIQSOLM_Type In resultado.List_ET_LIQSOLM
                Dim dr As DataRow = listadoGasto.NewRow
                dr("NRFSAP") = item.BELNR
                dr("NOPRCN") = item.NOPRCN

                Dim codGasto As Decimal
                Dim descripcionGasto As String = ""
                ObtenerConceptoGastoEquivalente(conceptoGastos.Tables(0), codGasto, descripcionGasto, item.CGSTOS)
                dr("COD_GASTO") = codGasto
                dr("TGSTOS") = descripcionGasto
                dr("CGSTOS_SAP") = item.CGSTOS

                Dim codMoneda As Decimal
                Dim descripcionMoneda As String = ""
                ObtenerMonedaGastoEquivalente(conceptoGastos.Tables(1), codMoneda, descripcionMoneda, item.CDMNDA)
                dr("COD_MONEDA") = codMoneda
                dr("TMNDA") = descripcionMoneda
                dr("CDMNDA_SAP") = item.CDMNDA

                dr("IGSTOS") = item.IGSTOS

                If item.FECINI.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) <> "01/01/0001" Then
                    dr("FECINI") = item.FECINI.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                End If

                If item.FECFIN.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) <> "01/01/0001" Then
                    dr("FECFIN") = item.FECFIN.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                End If

                dr("TOBDCT") = item.TOBDCT
                listadoGasto.Rows.Add(dr)
            Next
        End If

        Return listadoGasto

    End Function

    Public Sub ObtenerConceptoGastoEquivalente(ByVal dt As DataTable, ByRef codGasto As Decimal, ByRef descripcionGasto As String, ByVal codGastoServicio As String)
        For Each row As DataRow In dt.Rows
            If row("COD_SAP_GASTO").ToString() = codGastoServicio Then
                codGasto = row("CGSTOS")
                descripcionGasto = row("TGSTOS").ToString().Trim()
                Exit For
            End If
        Next
    End Sub

    Public Sub ObtenerMonedaGastoEquivalente(ByVal dt As DataTable, ByRef codMoneda As Decimal, ByRef descripcionMoneda As String, ByVal codMonedaServicio As String)
        For Each row As DataRow In dt.Rows
            If row("COD_SAP_MONEDA").ToString() = codMonedaServicio Then
                codMoneda = row("CMNDA1").ToString()
                descripcionMoneda = row("TMNDA").ToString().Trim()
                Exit For
            End If
        Next
    End Sub

    Private Sub dgvListarGastos_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
        Try
            If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvListarGastos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If Not IsHeaderCheckBoxClicked Then
                RowCheckBoxClick(DirectCast(dgvListarGastos(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvListarGastos_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If TypeOf dgvListarGastos.CurrentCell Is DataGridViewCheckBoxCell Then
                dgvListarGastos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "HeaderCheckBox"

    Private Sub HeaderCheckBox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        HeaderCheckBoxClick(DirectCast(sender, CheckBox))
    End Sub

    Private Sub HeaderCheckBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            HeaderCheckBoxClick(DirectCast(sender, CheckBox))
        End If
    End Sub

    Private Sub AddHeaderCheckBox()
        HeaderCheckBox = New CheckBox()

        HeaderCheckBox.Size = New Size(15, 15)

        'Agregue el CheckBox en el DataGridView
        Me.dgvListarGastos.Controls.Add(HeaderCheckBox)
    End Sub

    Private Sub ResetHeaderCheckBoxLocation(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        'Obtener los límites de encabezado de columna
        Dim oRectangle As Rectangle = Me.dgvListarGastos.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)

        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1

        'Cambiar la ubicación del ckeck para hacer que se quede en la cabecera
        HeaderCheckBox.Location = oPoint
    End Sub

    Private Sub HeaderCheckBoxClick(ByVal HCheckBox As CheckBox)
        IsHeaderCheckBoxClicked = True

        For Each Row As DataGridViewRow In dgvListarGastos.Rows
            DirectCast(Row.Cells("Check"), DataGridViewCheckBoxCell).Value = HCheckBox.Checked
        Next

        dgvListarGastos.RefreshEdit()

        If HCheckBox.Checked Then
            TotalCheckedCheckBoxes = TotalCheckBoxes
        Else
            TotalCheckedCheckBoxes = 0
        End If

        IsHeaderCheckBoxClicked = False
    End Sub

    Private Sub RowCheckBoxClick(ByVal RCheckBox As DataGridViewCheckBoxCell)
        If RCheckBox IsNot Nothing Then
            'Actualizar contador        
            If CBool(RCheckBox.Value) AndAlso TotalCheckedCheckBoxes < TotalCheckBoxes Then
                TotalCheckedCheckBoxes += 1
            ElseIf TotalCheckedCheckBoxes > 0 Then
                TotalCheckedCheckBoxes -= 1
            End If

            'Cambiar estado de la casilla de cabecera
            If TotalCheckedCheckBoxes < TotalCheckBoxes Then
                HeaderCheckBox.Checked = False
            ElseIf TotalCheckedCheckBoxes = TotalCheckBoxes Then
                HeaderCheckBox.Checked = True
            End If
        End If
    End Sub
#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim status As Integer = 0
            Dim selectedRecord As Boolean = False
            Dim bugExists As Boolean = False
            For Each Row As DataGridViewRow In dgvListarGastos.Rows
                If Row.Cells("Check").Value Then
                    selectedRecord = True

                    If Row.Cells("COD_GASTO").Value.ToString() = String.Empty Or Row.Cells("COD_GASTO").Value.ToString() = "0" Then
                        bugExists = True
                    End If
                    If Row.Cells("COD_MONEDA").Value.ToString() = String.Empty Or Row.Cells("COD_MONEDA").Value.ToString() = "0" Then
                        bugExists = True
                    End If
                End If
            Next

            If Not selectedRecord Then
                MessageBox.Show("Debe seleccionar un registro para continuar con la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf bugExists Then
                MessageBox.Show("Verificar asignación de mapeo con SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                For Each Row As DataGridViewRow In dgvListarGastos.Rows
                    If Row.Cells("Check").Value Then
                        Dim gastoOperacion As New DetalleGasto_BE
                        gastoOperacion.PSCCMPN = Operacion.PSCCMPN
                        gastoOperacion.PONNLQGST = Operacion.NLQGST_C
                        gastoOperacion.PNNOPRCN = Operacion.NOPRCN_C
                        gastoOperacion.PNNCRRRT = Operacion.NCRRRT_C
                        gastoOperacion.PNCGSTOS = Row.Cells("COD_GASTO").Value
                        gastoOperacion.PNCDMNDA = Row.Cells("COD_MONEDA").Value
                        gastoOperacion.PNIGSTOS = Row.Cells("IGSTOS").Value
                        gastoOperacion.PSTOBDCT = Row.Cells("TOBDCT").Value
                        gastoOperacion.PSCULUSA = MainModule.USUARIO
                        gastoOperacion.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                        If Row.Cells("FECINI").Value.ToString() <> String.Empty Then
                            gastoOperacion.PNNFECINI = Decimal.Parse(Date.Parse(Row.Cells("FECINI").Value).ToString("yyyyMMdd"))
                        End If
                        If Row.Cells("FECFIN").Value.ToString() <> String.Empty Then
                            gastoOperacion.PNNFECFIN = Decimal.Parse(Date.Parse(Row.Cells("FECFIN").Value).ToString("yyyyMMdd"))
                        End If

                        status += liquidarOperacion.RegistrarGastoOperacionOrigenPedido(gastoOperacion)

                    End If
                Next
                If status = 0 Then
                    MessageBox.Show("Guardó con éxito", "Listar Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Algunos gastos no fueron actualizados correctamente", "Listar Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class