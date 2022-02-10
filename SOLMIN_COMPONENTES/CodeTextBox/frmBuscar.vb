
Public Class frmBuscar

    Dim objDataTable As New DataTable
    Dim objOwner As CodeTextBox

    Public Sub ShowForm(ByVal objData As DataTable, ByVal owner As IWin32Window)

        objOwner = owner
        Me.objDataTable = objData.Copy()
        Me.dtgDatos.DataSource = Nothing
        Me.dtgDatos.DataSource = objData
        Mostrar_Columnas()
        Me.txtFiltro.Focus()
        Me.ShowDialog(owner)

    End Sub

    Private Sub Mostrar_Columnas()

        'Mostrando todas las columnas
        For i As Integer = 0 To Me.dtgDatos.Columns.Count - 1
            Me.dtgDatos.Columns(i).Visible = True
        Next

        For i As Integer = 0 To Me.dtgDatos.Columns.Count - 1
            If objDataTable.Columns(i).ColumnName.Equals("Codigo") = True Then
                Me.dtgDatos.Columns(i).Width = objOwner._KeyColumnWidth
                objOwner.IndiceKey = i
            ElseIf objDataTable.Columns(i).ColumnName.Equals("Valor") = True Then
                Me.dtgDatos.Columns(i).Width = objOwner._ValueColumnWidth
                objOwner.IndiceValue = i
            Else
                Me.dtgDatos.Columns(i).Visible = False
            End If
        Next

        'Verificando si es que la columna de KeyValue o Value debe estar visible
        If objOwner._KeyFieldVisible = False Then
            Me.dtgDatos.Columns(objOwner.IndiceKey).Visible = False
        End If

        If objOwner._ValueFieldVisible = False Then
            Me.dtgDatos.Columns(objOwner.IndiceValue).Visible = False
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
 

    Private Sub txtFiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyDown

        If e.KeyCode = Keys.Enter Then

            'Verificando si es que hay 1 solo elemento, se selecciona
            If Me.dtgDatos.Rows.Count = 2 Then
                Seleccionar_Texto()
            End If

        End If

    End Sub

    Private Sub Seleccionar_Texto()

        If dtgDatos.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If

        'Carga los datos del registro seleccionado
        objOwner._Codigo = dtgDatos.Rows(dtgDatos.CurrentCellAddress.Y).Cells(objOwner.IndiceKey).Value
        objOwner._Descripcion = dtgDatos.Rows(dtgDatos.CurrentCellAddress.Y).Cells(objOwner.IndiceValue).Value

        'Mostrando el contenido
        objOwner.Mostrar_Contenido()

        Me.Close()

    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged

        'Filtra el la data segun lo tipeado
        Dim dw As New DataView
        Dim filtro1 As String = ""
        Dim filtro2 As String = ""
        Dim filtro As String = ""

        dw = Me.objDataTable.DefaultView

        If objOwner._KeySearch = True Then
            Select Case objDataTable.Columns("Codigo").DataType.Name

                Case "Decimal", "Integer", "Int32", "Long", "Int16", "Double"

                    If IsNumeric(Me.txtFiltro.Text.Trim) = True Then
                        filtro1 += "Codigo = " & Me.txtFiltro.Text.Trim
                    End If

                Case Else

                    filtro1 += "Codigo Like '%" & Me.txtFiltro.Text.Trim & "%'"

            End Select

        End If

        If objOwner._ValueSearch = True Then

            Select Case objDataTable.Columns("Valor").DataType.Name

                Case "Decimal", "Integer", "Int32", "Long", "Int16", "Double"

                    If IsNumeric(Me.txtFiltro.Text.Trim) = True Then
                        filtro2 += "Valor=" & Me.txtFiltro.Text.Trim
                    End If

                Case Else
                    filtro2 += "Valor Like '%" & Me.txtFiltro.Text.Trim & "%'"

            End Select
        End If


        If filtro2.Equals("") = False And filtro1.Equals("") = False Then
            filtro = filtro1 & "  or  " & filtro2
        ElseIf filtro1.Equals("") = True Then
            filtro = filtro2
        ElseIf filtro2.Equals("") = True Then
            filtro = filtro1
        Else
            filtro = ""
        End If

        dw.RowFilter = filtro
        Me.dtgDatos.DataSource = dw

    End Sub

    Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtFiltro.Focus()
    End Sub

  Private Sub dtgDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellClick

    If e.RowIndex = -1 Then
      Exit Sub
    End If
    If Me.dtgDatos.DataSource Is Nothing Then
      Exit Sub
    End If
    If e.ColumnIndex > -1 Then
      If dtgDatos.Item(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
        Exit Sub
      End If
    End If
    'Carga los datos del registro seleccionado
    objOwner._Codigo = dtgDatos.Rows(e.RowIndex).Cells(objOwner.IndiceKey).Value
    objOwner._Descripcion = dtgDatos.Rows(e.RowIndex).Cells(objOwner.IndiceValue).Value

    'Mostrando el contenido
    objOwner.Mostrar_Contenido()
    objOwner.Texto.BackColor = Color.FromArgb(197, 191, 219)
    Me.Close()

  End Sub

    Private Sub dtgDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgDatos.KeyDown

        If e.KeyCode = Keys.F2 Then
            Seleccionar_Texto()
        End If

    End Sub
 

    Private Sub dtgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick

    End Sub
End Class
