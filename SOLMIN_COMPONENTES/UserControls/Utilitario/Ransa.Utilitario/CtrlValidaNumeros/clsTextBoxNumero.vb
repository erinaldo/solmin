Imports System.Text
Imports System.ComponentModel
Public Class clsTextBoxNumero

    Inherits TextBox

    Private _NUMENTEROS As Int32 = 0
    <Description("Cantidad de dígitos enteros"), Category("NUMERO")> _
    Public Property NUMENTEROS() As Int32
        Get
            Return _NUMENTEROS
        End Get
        Set(ByVal value As Int32)
            _NUMENTEROS = value
        End Set
    End Property


    Private _NUMDECIMALES As Int32 = 0
    <Description("Cantidad de dígitos decimales"), Category("NUMERO")> _
    Public Property NUMDECIMALES() As Int32
        Get
            Return _NUMDECIMALES
        End Get
        Set(ByVal value As Int32)
            _NUMDECIMALES = value
        End Set
    End Property

  
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If SoloNumerosConDecimal(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
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

    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        Dim NumeroTexto As String = Me.Text
        If NumeroTexto.EndsWith(".") Then
            Me.Text = NumeroTexto.Replace(".", "")
        End If
    End Sub

End Class
