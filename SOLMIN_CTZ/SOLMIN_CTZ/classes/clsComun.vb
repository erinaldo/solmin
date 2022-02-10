Imports System.Text
Public Class clsComun
    Enum TipoDocumento
        Neutro = 0
        Factura = 1
        NotaDebito = 2
        NotaCredito = 3
        BoletaVenta = 7

        NotaCreditoElectronico = 53
        NotaDebitoElectronico = 52

    End Enum

    Enum FormaVerDocumento
        Resumido = 1
        Detallado = 2
    End Enum

    Public Shared Function ObtenerDescripcionTipoAlmacenaje(ByVal CTPALJ As String)
        Dim Tipo As String = ""
        Select Case CTPALJ
            Case "MA" '"MA"
                Tipo = "MANUAL"
            Case "AD" '"AD"
                Tipo = "ADICIONAL"
            Case "GE"
                Tipo = "GENERAL"
            Case "RE"
                Tipo = "REEMBOLSO"
            Case "AL" '"AL"
                Tipo = "ALMACENAJE"
            Case "AP" 'AP
                Tipo = "ALMACENAJE POR FECHA DE CORTE"
            Case "MP" 'MP
                Tipo = "MANIPULEO POR FECHA DE CORTE"
            Case "PP" 'PP
                Tipo = "ALMACENAJE POR PESO PROMEDIOS"
            Case "PE" 'PE
                Tipo = "ALMACENAJE POR PERMANENCIA"
        End Select
        Return Tipo
    End Function

    Public Shared Function SoloNumerosConDecimal(ByVal sender As Object, ByVal Keyascii As Short) As Short
        Dim TextBox As Object = Nothing
        If TypeOf sender Is TextBox Then
            'TextBox = System.Windows.Forms.TextBox
            TextBox = CType(sender, TextBox)
            'TextBox = CType(sender, TextBox)
        End If
        If TypeOf sender Is ToolStripTextBox Then
            TextBox = CType(sender, ToolStripTextBox)
        End If
        Dim NumeroTexto As String
        'TextBox = CType(sender, TextBox)
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

    Public Shared Function SoloNumerosConDecimal2(ByVal sender As Object, ByVal Keyascii As Short, ByVal estado As Boolean) As Short
        Dim TextBox As Object = Nothing
        If TypeOf sender Is TextBox Then
            'TextBox = System.Windows.Forms.TextBox
            TextBox = CType(sender, TextBox)
            'TextBox = CType(sender, TextBox)
        End If
        If TypeOf sender Is ToolStripTextBox Then
            TextBox = CType(sender, ToolStripTextBox)
        End If
        Dim NumeroTexto As String
        'TextBox = CType(sender, TextBox)
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
        If estado = True Then
            NumeroTexto = ""
        End If

        If Keyascii = 8 Then
            If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
                NumeroTexto = NumeroOriginal
                SoloNumerosConDecimal2 = 0
            Else
                SoloNumerosConDecimal2 = Keyascii
            End If
        ElseIf InStr(NumeroTexto, ".") <> 0 Then
            Dim a() As String
            a = NumeroTexto.Split(".") 'Split(NumeroTexto, ".")
            If a(0).Length >= 1 And a(0).Length <= NEnteros And a(1).Length >= 0 And a(1).Length <= NDecimales Then
                NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
                If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
                    NumeroTexto = NumeroOriginal
                    SoloNumerosConDecimal2 = 0
                Else
                    SoloNumerosConDecimal2 = Keyascii
                End If
            End If
        ElseIf NumeroTexto.Length >= NEnteros And NumeroTexto.Length < NEnteros + 1 Then
            If Chr(Keyascii) = "." Then
                If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
                    NumeroTexto = NumeroOriginal
                    SoloNumerosConDecimal2 = 0
                Else
                    SoloNumerosConDecimal2 = Keyascii
                End If
            End If
            ElseIf NumeroTexto.Length >= NEnteros + 1 And NumeroTexto.Length <= NEnteros + 1 + NDecimales Then
                NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
                If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
                    NumeroTexto = NumeroOriginal
                    SoloNumerosConDecimal2 = 0
                Else
                    SoloNumerosConDecimal2 = Keyascii
                End If
            ElseIf NumeroTexto.Length >= NEnteros + NDecimales + 2 Then

            Else
                NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
                If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
                    NumeroTexto = NumeroOriginal
                    SoloNumerosConDecimal2 = 0
                Else
                    SoloNumerosConDecimal2 = Keyascii
                End If
                Select Case Keyascii
                    Case 8
                        SoloNumerosConDecimal2 = Keyascii
                    Case 13
                        SoloNumerosConDecimal2 = Keyascii
                    Case 32
                        SoloNumerosConDecimal2 = Keyascii
                    Case 49
                        SoloNumerosConDecimal2 = Keyascii
                    Case 50
                        SoloNumerosConDecimal2 = Keyascii
                    Case 51
                        SoloNumerosConDecimal2 = Keyascii
                    Case 52
                        SoloNumerosConDecimal2 = Keyascii
                    Case 53
                        SoloNumerosConDecimal2 = Keyascii
                    Case 54
                        SoloNumerosConDecimal2 = Keyascii
                    Case 55
                        SoloNumerosConDecimal2 = Keyascii
                    Case 56
                        SoloNumerosConDecimal2 = Keyascii
                    Case 57
                        SoloNumerosConDecimal2 = Keyascii
                End Select
            End If

    End Function


End Class
