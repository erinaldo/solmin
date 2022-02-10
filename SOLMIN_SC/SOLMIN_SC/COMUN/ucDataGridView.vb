Imports System.Text
Imports ComponentFactory.Krypton.Toolkit
Public Class ucDataGridView
    Inherits KryptonDataGridView
    Private _NUMENTEROS As Int32 = 0
    Private _NUMDECIMALES As Int32 = 0
    Protected Overrides Sub OnEditingControlShowing(ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        Dim oDataGridViewTextBoxColumnNumero As ucTextBoxColumnNumero
        If TypeOf Me.Columns(Me.CurrentCellAddress.X) Is ucTextBoxColumnNumero Then
            oDataGridViewTextBoxColumnNumero = CType(Me.Columns(Me.CurrentCellAddress.X), ucTextBoxColumnNumero)
            _NUMENTEROS = oDataGridViewTextBoxColumnNumero.NUMENTEROS
            _NUMDECIMALES = oDataGridViewTextBoxColumnNumero.NUMDECIMALES
            If TypeOf e.Control Is TextBox Then
                Dim colName As String = ""
                Dim Texto As New TextBox
                colName = Me.Columns(Me.CurrentCell.ColumnIndex).Name
                If TypeOf e.Control Is TextBox Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                End If
                Texto = CType(e.Control, TextBox)
                Texto.Text = Texto.Text.Trim
                Texto.Tag = _NUMENTEROS & "-" & _NUMDECIMALES
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
        End If
    End Sub

    Private Function SoloNumerosConDecimal(ByVal Keyascii As Short) As Short
        Dim NumeroTexto As String
        Dim NEnteros As Int32 = _NUMENTEROS
        Dim NDecimales As Int32 = _NUMDECIMALES
        Dim InicioEnteros As String = IIf(NEnteros = 0, "0", 1)
        Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NEnteros & "}(\.[0-9]{0," & NDecimales & "})?$"
        NumeroTexto = Me.Text
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
        End Select
    End Function

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
