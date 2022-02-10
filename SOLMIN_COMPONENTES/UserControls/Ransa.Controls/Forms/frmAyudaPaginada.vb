Imports System.ComponentModel

Public Class frmAyudaPaginada

    Private _Tabla As String
    <Browsable(False)> _
    Public ReadOnly Property Tabla() As String
        Get
            Return _Tabla
        End Get
    End Property

    Private _Campos As String
    Private _Alias As String

    <Browsable(False)> _
    Public ReadOnly Property Campos() As String
        Get
            Return _Campos
        End Get
    End Property

    <Browsable(False)> _
    Public ReadOnly Property AliasCampos() As String
        Get
            Return _Alias
        End Get
    End Property

    Private Sub txtBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If String.IsNullOrEmpty(txtBusqueda.Text) Then Exit Sub
            Call pBusqueda()
        End If
    End Sub

    Private Sub pBusqueda()
        Dim strFiltro As String
        Try
            ' Primero Capturamos el Atributo
            If cboAtributos.Items.Count > 0 Then
                strFiltro = "[" & cboAtributos.SelectedValue & "]"

                If cboOperador.Items.Count > 0 Then
                    Select Case cboOperador.SelectedIndex
                        Case 0 ' IGUAL A
                            If IsNumeric(txtBusqueda.Text) Then
                                strFiltro = strFiltro & " = '" & txtBusqueda.Text & "'"
                            Else
                                strFiltro = strFiltro & " = " & txtBusqueda.Text
                            End If
                        Case 1 ' INICIA EN
                            strFiltro = strFiltro & " LIKE '" & txtBusqueda.Text & "%'"
                        Case 2 ' DISTINTO A
                            strFiltro = strFiltro & " <> '" & txtBusqueda.Text & "'"
                        Case 3 ' TERMINA EN
                            strFiltro = strFiltro & " LIKE '%" & txtBusqueda.Text & "'"
                        Case 4 ' CONTIENE EL TEXTO
                            strFiltro = strFiltro & " LIKE '%" & txtBusqueda.Text & "%'"
                        Case Else
                            strFiltro = ""
                    End Select
                End If


                Dim brp As brObject

                Dim dt As New DataTable
                dt = brp.TraerConsultaPaginada(Tabla, Campos, strFiltro, UcPaginacion1)




            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Búsqueda..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub showFiltro(ByVal sTabla As String, ByVal sCampos As String, ByVal sAlias As String)
        _Tabla = sTabla
        _Campos = sCampos
        Dim dt As New DataTable
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("value", GetType(String))
        Dim arrName As Array, arrvalue As Array
        arrName = sCampos.Split(",")
        arrvalue = sAlias.Split(",")
        For i As Integer = 0 To arrName.GetLength(0) - 1
            Dim dr As DataRow = dt.NewRow()
            dr("name") = arrName.GetValue(i).ToString()
            dr("value") = arrvalue.GetValue(i).ToString()
            dt.Rows.Add(dr)
        Next
        Dim arr As New Dictionary(Of String, String)
        cboAtributos.ValueMember = "name"
        cboAtributos.DisplayMember = "value"
        cboAtributos.DataSource = dt

        Me.ShowDialog()
    End Sub

    Private _CurrentRow As DataRow
    Public ReadOnly Property CurrentRow() As DataRow
        Get
            Return _CurrentRow
        End Get
    End Property



    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If dgvBusqueda.CurrentRow Is Nothing Then Exit Sub
        _CurrentRow = dgvBusqueda.CurrentRow.DataBoundItem
        Me.Close()
    End Sub
End Class
