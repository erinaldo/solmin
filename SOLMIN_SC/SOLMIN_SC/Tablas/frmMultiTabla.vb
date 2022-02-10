Imports SOLMIN_SC.Negocio
Imports System.Web

Public Class frmMultiTabla
    Private oMultiTabla As clsMultiTabla
    'Private oEnvio As clsEnvio
    Private oBs As New BindingSource
    Private strTabla As String = ""
    Private strTipoMant As String = ""


    Private Sub frmMultiTabla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oEnvio As New clsEnvio
        'oEnvio = New clsEnvio
        'oEnvio.Lista = DirectCast(HttpRuntime.Cache.Get("Envio"), clsEnvio).Lista.Copy
        oMultiTabla = New clsMultiTabla
        oMultiTabla.Crea_Tablas()
        'cmbTrans.DataSource = oEnvio.Lista_Envio(1)
        cmbTrans.DataSource = oEnvio.Listar_Envio(1)
        cmbTrans.ValueMember = "CMEDTR"
        cmbTrans.DisplayMember = "TNMMDT"
        Crear_Arbol()
        Me.tvwTabla.ExpandAll()
        Me.dtgDetalle.DataSource = oBs
    End Sub

    Private Sub Crear_Arbol()
        Dim tndNodo As TreeNode
        Dim lintCont As Integer

        Me.tvwTabla.Nodes(0).Nodes.Clear()

        With CType(oMultiTabla.Lista_Tablas, DataTable)
            For lintCont = 0 To .Rows.Count - 1
                tndNodo = New TreeNode(.Rows(lintCont).Item("DES"), 2, 0)
                tndNodo.Tag = .Rows(lintCont).Item("COD")
                Me.tvwTabla.Nodes(0).Nodes.Add(tndNodo)
            Next lintCont
        End With
    End Sub

    Private Sub Llenar_Grilla()
        Dim lintCont As Integer

        Me.dtgDetalle.Columns.Clear()
        Me.oDs.Tables(0).Clear()
        Me.oDs.Tables(1).Clear()
        Me.oDs.Tables(2).Clear()
        Select Case strTabla
            Case "A"
                Me.oDs.Tables(0).Load(oMultiTabla.Lista_Detalles.CreateDataReader())
                oBs.DataSource = Nothing
                oBs.DataSource = Me.oDs.Tables(0)
                For lintCont = 0 To Me.oDs.Tables(0).Columns.Count - 1
                    Me.dtgDetalle.Columns(lintCont).HeaderText = Me.oDs.Tables(0).Columns(lintCont).Caption
                Next lintCont
                Me.dtgDetalle.Columns(0).Visible = False
                Me.dtgDetalle.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                Me.dtgDetalle.Columns(2).Visible = False
                Me.dtgDetalle.Columns(3).Visible = False
            Case "V"
                Me.oDs.Tables(1).Load(oMultiTabla.Lista_Detalles.CreateDataReader())
                oBs.DataSource = Nothing
                oBs.DataSource = Me.oDs.Tables(1)
                For lintCont = 0 To Me.oDs.Tables(1).Columns.Count - 1
                    Me.dtgDetalle.Columns(lintCont).HeaderText = Me.oDs.Tables(1).Columns(lintCont).Caption
                Next lintCont
                Me.dtgDetalle.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                Me.dtgDetalle.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                Me.dtgDetalle.Columns(2).Visible = False
                Me.dtgDetalle.Columns(3).Visible = False
            Case "C"
                Me.oDs.Tables(2).Load(oMultiTabla.Lista_Detalles.CreateDataReader())
                oBs.DataSource = Nothing
                oBs.DataSource = Me.oDs.Tables(2)
                For lintCont = 0 To Me.oDs.Tables(2).Columns.Count - 1
                    Me.dtgDetalle.Columns(lintCont).HeaderText = Me.oDs.Tables(2).Columns(lintCont).Caption
                Next lintCont
                Me.dtgDetalle.Columns(0).Visible = False
                Me.dtgDetalle.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                Me.dtgDetalle.Columns(2).Visible = False
                Me.dtgDetalle.Columns(3).Visible = False
                Me.dtgDetalle.Columns(4).Visible = False
        End Select
        Colorear_Fila()
        Me.dtgDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub tvwTabla_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwTabla.NodeMouseClick
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.txtCod.Enabled = False
            Me.txtFilDes.Text = ""
            Me.txtFilCod.Text = ""
            Me.txtCod.Text = ""
            Me.KryptonHeaderGroup1.Visible = False
            Me.dtgDetalle.Visible = False
            Limpiar()
            If e.Node.Name <> "Raiz" And strTabla <> e.Node.Tag Then
                Me.KryptonHeaderGroup1.Visible = True
                strTabla = e.Node.Tag
                oMultiTabla.Tabla = e.Node.Tag
                oMultiTabla.Crea_Detalles()
                Llenar_Grilla()
                Me.dtgDetalle.Visible = True
            Else
                If e.Node.Name <> "Raiz" And strTabla = e.Node.Tag Then
                    Me.KryptonHeaderGroup1.Visible = True
                    Me.dtgDetalle.Visible = True
                Else
                    If e.Node.Name = "Raiz" Then
                        strTabla = ""
                    End If
                End If
            End If
            Configurar_Panel()
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox(ex.Message)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
            strTipoMant = ""
        End Try
        
    End Sub

    Private Sub Configurar_Panel()
        Select Case strTabla
            Case "A"
                Me.txtCod.Enabled = False
                Me.lblTrans.Visible = False
                Me.cmbTrans.Enabled = False
                Me.cmbTrans.Visible = False
            Case "C"
                Me.txtCod.Enabled = False
                Me.lblTrans.Visible = True
                Me.cmbTrans.Enabled = True
                Me.cmbTrans.Visible = True
            Case "V"
                Me.txtCod.Enabled = False
                Me.lblTrans.Visible = False
                Me.cmbTrans.Enabled = False
                Me.cmbTrans.Visible = False
        End Select
    End Sub

    Private Sub txtFilDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilDes.KeyUp
        If e.KeyValue <> 13 Then
            Filtrar()
        End If
    End Sub

    Private Sub Colorear_Fila()
        Select Case strTabla
            Case "A"
                For Each Fila As DataGridViewRow In Me.dtgDetalle.Rows
                    Select Case Fila.Cells(3).Value.ToString.Trim
                        Case "A"
                            Fila.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                            Fila.DefaultCellStyle.BackColor = Color.LightBlue
                        Case "*"
                            Fila.DefaultCellStyle.BackColor = Color.Red
                            Fila.DefaultCellStyle.SelectionBackColor = Color.Red
                    End Select
                Next
            Case "V"
                For Each Fila As DataGridViewRow In Me.dtgDetalle.Rows
                    Select Case Fila.Cells(3).Value.ToString.Trim
                        Case "A"
                            Fila.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                            Fila.DefaultCellStyle.BackColor = Color.LightBlue
                        Case "*"
                            Fila.DefaultCellStyle.BackColor = Color.Red
                            Fila.DefaultCellStyle.SelectionBackColor = Color.Red
                    End Select
                Next
            Case "C"
                For Each Fila As DataGridViewRow In Me.dtgDetalle.Rows
                    Select Case Fila.Cells(4).Value.ToString.Trim
                        Case "A"
                            Fila.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                            Fila.DefaultCellStyle.BackColor = Color.LightBlue
                        Case "*"
                            Fila.DefaultCellStyle.BackColor = Color.Red
                            Fila.DefaultCellStyle.SelectionBackColor = Color.Red
                    End Select
                Next
        End Select
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtCod.Text = ""
        If Me.strTabla = "V" Then
            Me.txtCod.Enabled = True
        Else
            Me.txtCod.Enabled = False
        End If
        Me.txtDes.Text = ""
        Me.cmbTrans.SelectedIndex = 0
        strTipoMant = "I"
    End Sub

    Private Sub Limpiar()
        Me.txtCod.Text = ""
        Me.txtDes.Text = ""
        Me.cmbTrans.SelectedIndex = 0
    End Sub

    Private Sub dtgDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDetalle.Click
        Me.txtCod.Clear()
        Me.txtDes.Clear()
        If Me.dtgDetalle.Rows.Count > 0 And Me.dtgDetalle.SelectedRows.Count = 1 Then
            Select Case strTabla
                Case "A"
                    Me.txtCod.Text = Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString.Trim
                    Me.txtDes.Text = Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim
                    strTipoMant = "U"
                Case "C"
                    Me.txtCod.Text = Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString.Trim
                    Me.txtDes.Text = Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim
                    Me.cmbTrans.SelectedValue = Me.dtgDetalle.SelectedRows(0).Cells(3).Value.ToString.Trim
                    strTipoMant = "U"
                Case "V"
                    Me.txtCod.Text = Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString.Trim
                    Me.txtDes.Text = Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim
                    Me.cmbTrans.SelectedValue = Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString.Trim
                    strTipoMant = "U"
            End Select
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Validar() Then
                If MessageBox.Show("Está seguro de grabar los datos ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.Hand
                    Select Case strTabla
                        Case "A"
                            If strTipoMant = "I" Then
                                oMultiTabla.Mantenimiento_Embarcador(strTipoMant, 0, Me.txtDes.Text, "A", "250")
                                strTipoMant = "U"
                            Else
                                If strTipoMant = "U" Then
                                    oMultiTabla.Mantenimiento_Embarcador(strTipoMant, Double.Parse(Me.txtCod.Text), Me.txtDes.Text, "A", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                                End If
                            End If
                        Case "C"
                            If strTipoMant = "I" Then
                                oMultiTabla.Mantenimiento_CiaTransporte(strTipoMant, 0, Me.cmbTrans.SelectedValue, Me.txtDes.Text, "A", "250")
                                strTipoMant = "U"
                            Else
                                If strTipoMant = "U" Then
                                    oMultiTabla.Mantenimiento_CiaTransporte(strTipoMant, Double.Parse(Me.txtCod.Text), Me.cmbTrans.SelectedValue, Me.txtDes.Text, "A", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                                End If
                            End If
                        Case "V"
                            oMultiTabla.Mantenimiento_Vapor(strTipoMant, Me.txtCod.Text, Me.txtDes.Text, "A", My.Computer.Name)
                            strTipoMant = "U"
                    End Select
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpUtil.MsgBox("Se guardaron correctamente los datos")
                    oMultiTabla.Crea_Detalles()
                    Llenar_Grilla()
                    Limpiar()
                    Me.txtFilCod.Text = ""
                    Me.txtFilDes.Text = ""
                    Configurar_Panel()
                End If
            Else
                HelpUtil.MsgBox("Debe completar los datos restantes para poder grabar la información")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Select Case Me.strTipoMant
            Case "I"
                Select Case Me.strTabla
                    Case "A"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                    Case "C"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                    Case "V"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        If Me.txtCod.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                End Select
            Case "U"
                Select Case Me.strTabla
                    Case "A"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                    Case "C"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                    Case "V"
                        If Me.txtDes.Text.Trim = vbNullString Then
                            Return False
                        End If
                        Return True
                End Select
        End Select
        Return False
    End Function

    Private Sub dtgDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDetalle.DoubleClick
        Try
            If Me.dtgDetalle.Rows.Count > 0 And Me.dtgDetalle.SelectedRows.Count = 1 Then
                If MessageBox.Show("Está seguro de cambiar el estado del registro?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Select Case strTabla
                        Case "A"
                            If Me.dtgDetalle.SelectedRows(0).Cells(3).Value.ToString.Trim = "*" Then
                                oMultiTabla.Mantenimiento_Embarcador("U", Double.Parse(Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString), Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "A", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                            Else
                                oMultiTabla.Mantenimiento_Embarcador("U", Double.Parse(Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString), Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "*", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                            End If
                        Case "C"
                            If Me.dtgDetalle.SelectedRows(0).Cells(4).Value.ToString.Trim = "*" Then
                                oMultiTabla.Mantenimiento_CiaTransporte("U", Double.Parse(Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString), Me.dtgDetalle.SelectedRows(0).Cells(3).Value.ToString.Trim, Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "A", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                            Else
                                oMultiTabla.Mantenimiento_CiaTransporte("U", Double.Parse(Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString), Me.dtgDetalle.SelectedRows(0).Cells(3).Value.ToString.Trim, Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "*", Me.dtgDetalle.SelectedRows(0).Cells(2).Value.ToString)
                            End If
                        Case "V"
                            If Me.dtgDetalle.SelectedRows(0).Cells(3).Value.ToString.Trim = "*" Then
                                oMultiTabla.Mantenimiento_Vapor("U", Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString.Trim, Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "A", My.Computer.Name)
                            Else
                                oMultiTabla.Mantenimiento_Vapor("U", Me.dtgDetalle.SelectedRows(0).Cells(0).Value.ToString.Trim, Me.dtgDetalle.SelectedRows(0).Cells(1).Value.ToString.Trim, "*", My.Computer.Name)
                            End If
                    End Select
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpUtil.MsgBox("Se actualizó correctamente el registro")
                    oMultiTabla.Crea_Detalles()
                    Llenar_Grilla()
                End If
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpUtil.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFilCod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilCod.KeyUp
        If e.KeyValue <> 13 Then
            Filtrar()
        End If
    End Sub

    Private Sub Filtrar()
        Dim oDr As DataRow()
        Dim oNewDr As DataRow
        Dim oDt As DataTable
        Dim lintCont As Integer
        Select Case strTabla
            Case "A"
                oDr = Me.oDs.Tables(0).Select("TNMAGC LIKE '%" & Me.txtFilDes.Text.ToUpper & "%' AND CAGNCR LIKE '%" & Me.txtFilCod.Text.ToUpper & "%'")
                oDt = Me.oDs.Tables(0).Clone
                For lintCont = 1 To oDr.Length
                    oNewDr = oDt.NewRow
                    oNewDr(0) = oDr(lintCont - 1).Item(0)
                    oNewDr(1) = oDr(lintCont - 1).Item(1)
                    oNewDr(2) = oDr(lintCont - 1).Item(2)
                    oNewDr(3) = oDr(lintCont - 1).Item(3)
                    oDt.Rows.Add(oNewDr)
                Next lintCont
                oBs.DataSource = oDt
            Case "V"
                oDr = Me.oDs.Tables(1).Select("TCMPVP LIKE '%" & Me.txtFilDes.Text.ToUpper & "%' AND CVPRCN LIKE '%" & Me.txtFilCod.Text.ToUpper & "%'")
                oDt = Me.oDs.Tables(1).Clone
                For lintCont = 1 To oDr.Length
                    oNewDr = oDt.NewRow
                    oNewDr(0) = oDr(lintCont - 1).Item(0)
                    oNewDr(1) = oDr(lintCont - 1).Item(1)
                    oNewDr(2) = oDr(lintCont - 1).Item(2)
                    oNewDr(3) = oDr(lintCont - 1).Item(3)
                    oDt.Rows.Add(oNewDr)
                Next lintCont
                oBs.DataSource = oDt
            Case "C"
                oDr = Me.oDs.Tables(2).Select("TNMCIN LIKE '%" & Me.txtFilDes.Text.ToUpper & "%' AND CCIANV LIKE '%" & Me.txtFilCod.Text.ToUpper & "%'")
                oDt = Me.oDs.Tables(2).Clone
                For lintCont = 1 To oDr.Length
                    oNewDr = oDt.NewRow
                    oNewDr(0) = oDr(lintCont - 1).Item(0)
                    oNewDr(1) = oDr(lintCont - 1).Item(1)
                    oNewDr(2) = oDr(lintCont - 1).Item(2)
                    oNewDr(3) = oDr(lintCont - 1).Item(3)
                    oNewDr(4) = oDr(lintCont - 1).Item(4)
                    oDt.Rows.Add(oNewDr)
                Next lintCont
                oBs.DataSource = oDt
        End Select
        strTipoMant = ""
        Colorear_Fila()
    End Sub
End Class
