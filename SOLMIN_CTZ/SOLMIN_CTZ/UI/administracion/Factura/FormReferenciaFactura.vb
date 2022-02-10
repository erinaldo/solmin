Imports System.Text
Public Class FormReferenciaFactura
    Private pTamanioReferencia1 As Integer = 380
    Private pTamanioReferencia2 As Integer = 624
    'Private pTamanioFilas As Integer = 5
    Private pTamanioFilasReferenciaCab As Integer = 4
    Private pTamanioFilasReferenciaDet As Integer = 5
    Private _datasource As DataTable
    Public Property DataSource() As DataTable
        Get
            Return _datasource
        End Get
        Set(ByVal value As DataTable)
            _datasource = value
        End Set
    End Property

    Private _referencia As String
    Public ReadOnly Property Referencia_Factura() As String
        Get
            Return _referencia
        End Get
    End Property

    Private _TipoReferencia As Integer
    Public WriteOnly Property TipoReferencia() As Integer
        Set(ByVal value As Integer)
            _TipoReferencia = value
        End Set
    End Property
    Private _texto As String
    Public WriteOnly Property TextoInicial() As String
        Set(ByVal value As String)
            _texto = value
        End Set
    End Property


    Private Sub FormReferenciaFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dgvReferencias.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
        Me.dgvReferencias.AlternatingRowsDefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
        Me.dgvReferencias.Rows.Clear()
        If DataSource IsNot Nothing Then
            For x As Integer = 0 To DataSource.Rows.Count - 1
                Me.dgvReferencias.Rows.Add(1)
                Me.dgvReferencias.Item("_SELEC", x).Value = False
                Me.dgvReferencias.Item("_REF", x).Value = DataSource.Rows(x)(0).ToString.Trim
            Next
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strReferencia As New StringBuilder
        Dim numFilas As Integer = 0
        Dim srtTexto As String = ""
        Me.dgvReferencias.EndEdit()
        For indice As Integer = 0 To Me.dgvReferencias.Rows.Count - 1
            If Me.dgvReferencias.Item("_SELEC", indice).Value = True Then
                strReferencia.Append(Me.dgvReferencias.Item("_REF", indice).Value.ToString.Trim & vbNewLine)
            End If
        Next
        srtTexto = strReferencia.ToString.Trim
        'If _texto.Length > 0 Then
        '    srtTexto = _texto & vbNewLine & strReferencia.ToString.Trim
        'Else
        '    srtTexto = strReferencia.ToString.Trim
        'End If

        For Each dr As String In srtTexto.ToString.Split(vbNewLine)
            numFilas += 1
        Next
        If _TipoReferencia = 1 Then
            If numFilas <= pTamanioFilasReferenciaCab Then
                _referencia = srtTexto.ToString.Trim
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim msg As String = ""
                msg = "Ha excedido el número de filas imprimibles en la Factura(" & pTamanioFilasReferenciaCab & " Filas como max. referencia)"
                msg = msg & Chr(13) & "Debe rectificar las referencias en la Factura después de adicionar." & Chr(13) & " Desea adicionar las referencias ?"
                If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    _referencia = srtTexto.ToString.Trim
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            'If strReferencia.Length < pTamanioReferencia1 Then
            '    If numFilas < pTamanioFilas Then
            '        _referencia = srtTexto.ToString.Trim
            '        Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Else
            '        'MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Dim msg As String = ""
            '        msg = "Las referencias seleccionadas ha excedido el número de líneas permitidas en la Factura(4 líneas como max. referencia)"
            '        msg = msg & Chr(13) & "Debe verificar las referencias adicionadas"
            '        msg = msg & Chr(13) & "Desea continuar ?"
            '        If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            '            _referencia = srtTexto.ToString.Trim
            '            Me.DialogResult = Windows.Forms.DialogResult.OK
            '        End If
            '    End If
            'Else
            '    'MessageBox.Show("La referencia excede el maximo número de caracteres ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Dim msg As String = ""
            '    msg = "Las referencias seleccionadas ha excedido el número de líneas permitidas en la Factura(4 líneas como max. referencia)"
            '    msg = msg & Chr(13) & "Debe verificar las referencias adicionadas"
            '    msg = msg & Chr(13) & "Desea continuar ?"
            '    If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            '        _referencia = srtTexto.ToString.Trim
            '        Me.DialogResult = Windows.Forms.DialogResult.OK
            '    End If
            'End If
        Else
            If numFilas <= pTamanioFilasReferenciaDet Then
                _referencia = srtTexto.ToString.Trim
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim msg As String = ""
                msg = "Ha excedido el número de filas imprimibles en la Factura(" & pTamanioFilasReferenciaDet & " Filas como max. referencia)"
                msg = msg & Chr(13) & "Debe rectificar las referencias en la Factura después de adicionar." & Chr(13) & " Desea adicionar las referencias ?"
                If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    _referencia = srtTexto.ToString.Trim
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

            'If srtTexto.Length < pTamanioReferencia2 Then
            '    If numFilas < pTamanioFilas Then
            '        _referencia = srtTexto.ToString.Trim
            '        Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Else
            '        'MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Dim msg As String = ""
            '        msg = "Las referencias seleccionadas ha excedido el número" & Chr(13) & "de líneas permitidas en la Factura(4 líneas como max. referencia)"
            '        msg = msg & Chr(13) & "Debe verificar las referencias adicionadas ,Desea continuar para adicionar las referencias ?"
            '        If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            '            _referencia = srtTexto.ToString.Trim
            '            Me.DialogResult = Windows.Forms.DialogResult.OK
            '        End If
            '    End If
            'Else
            '    'MessageBox.Show("La referencia excede el maximo de caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Dim msg As String = ""
            '    msg = "Las referencias seleccionadas ha excedido el número" & Chr(13) & "de caracteres permitidos"
            '    msg = msg & Chr(13) & "Debe verificar las referencias adicionadas ,Desea continuar para adicionar las referencias ?"
            '    If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            '        _referencia = srtTexto.ToString.Trim
            '        Me.DialogResult = Windows.Forms.DialogResult.OK
            '    End If
            'End If
        End If

    End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    Dim strReferencia As New StringBuilder
    '    Dim numFilas As Integer = 0
    '    Dim srtTexto As String = ""
    '    Me.dgvReferencias.EndEdit()
    '    For indice As Integer = 0 To Me.dgvReferencias.Rows.Count - 1
    '        If Me.dgvReferencias.Item("_SELEC", indice).Value = True Then
    '            strReferencia.AppendLine(Me.dgvReferencias.Item("_REF", indice).Value.ToString.Trim)
    '        End If
    '    Next
    '    If _texto.Length > 0 Then
    '        srtTexto = _texto & vbNewLine & strReferencia.ToString.Trim
    '    Else
    '        srtTexto = strReferencia.ToString.Trim
    '    End If

    '    For Each dr As String In srtTexto.ToString.Split(vbNewLine)
    '        numFilas += 1
    '    Next
    '    If _TipoReferencia = 1 Then
    '        If strReferencia.Length < pTamanioReferencia1 Then
    '            If numFilas < pTamanioFilas Then
    '                _referencia = srtTexto.ToString.Trim
    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Else
    '                MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("La referencia excede el maximo número de caracteres ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        If srtTexto.Length < pTamanioReferencia2 Then
    '            If numFilas < pTamanioFilas Then
    '                _referencia = srtTexto.ToString.Trim
    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Else
    '                MessageBox.Show("La referencia excede el maximo número de filas(max. 4)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("La referencia excede el maximo de caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If

    'End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvReferencias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReferencias.CellClick
        If e.ColumnIndex = 0 Then
            Me.dgvReferencias.BeginEdit(True)
            If Me.dgvReferencias.Item("_SELEC", e.RowIndex).Value = False Then
                Me.dgvReferencias.Item("_SELEC", e.RowIndex).Value = True
            Else
                Me.dgvReferencias.Item("_SELEC", e.RowIndex).Value = False
            End If
        ElseIf e.ColumnIndex = 1 Then
            Me.dgvReferencias.BeginEdit(True)
            Me.dgvReferencias.Item("_REF", e.RowIndex).ReadOnly = False
        End If
    End Sub


End Class
