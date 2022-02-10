Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.ComponentModel
Public MustInherit Class HelpUtil

    'Declaración de la API (Para Liberar Memoria http://gdev.wordpress.com/2005/11/30/liberar-memoria-con-vb-net/)
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean


    Public Shared Sub MsgBox(ByVal Texto As String)
        Dim SistNom As String = getSetting("Sistema")
        MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK)
    End Sub

    Public Shared ReadOnly Property UserName()
        Get
            Return New Negocio.clsUsuario().GetUserName
        End Get
    End Property

    'Public Shared Function RspMsgBox(ByVal Texto As String) As DialogResult
    '    Dim SistNom As String = getSetting("Sistema")
    '    Return MessageBox.Show(Texto, SistNom, MessageBoxButtons.YesNo)
    'End Function

    Public Shared Function getSetting(ByVal Nombre As String) As String
        Return Configuration.ConfigurationSettings.AppSettings(Nombre).ToString()
    End Function

    'Public Shared Function DtypeDate(ByVal obj As Object) As String

    '    Dim objDate As New Date
    '    If obj.Equals("") = True Then
    '        objDate = DateTime.Today
    '    Else
    '        objDate = obj
    '    End If
    '    Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)

    'End Function

    Public Shared Function Str8ToDate(ByVal obj As String) As Date

        Dim objDate As New Date
        If obj.Equals("") = True Then
            objDate = DateTime.Today
        Else
            If IsNumeric(obj) Then
                objDate = CType((obj.Substring(6, 2) + "/" + obj.Substring(4, 2) + "/" + obj.Substring(0, 4)), Date)
            Else
                objDate = DateTime.Today
            End If
        End If
        Return objDate
    End Function
    'Funcion de liberacion de memoria
    Public Shared Sub ClearMemory()

        Try

            ''Forzando al Garbage Collector
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)

        Catch : End Try

    End Sub
    Public Shared Function SoloNumerosSinComa(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumerosSinComa = 0
        Else
            SoloNumerosSinComa = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosSinComa = Keyascii
            Case 13
                SoloNumerosSinComa = Keyascii
            Case 32
                SoloNumerosSinComa = Keyascii
        End Select

    End Function

    'Public Shared Function SoloNumerosConDecimal(ByVal Keyascii As Short) As Short

    '    If InStr("1234567890.", Chr(Keyascii)) = 0 Then
    '        SoloNumerosConDecimal = 0
    '    Else
    '        SoloNumerosConDecimal = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloNumerosConDecimal = Keyascii
    '        Case 13
    '            SoloNumerosConDecimal = Keyascii
    '        Case 32
    '            SoloNumerosConDecimal = Keyascii
    '    End Select

    'End Function

    'Public Shared Function SoloNumerosConDecimal(ByVal NumeroTexto As String, ByVal NumEnteros As Int32, ByVal NumDecimales As Int32, ByVal Keyascii As Short) As Short


    '    Dim InicioEnteros As String = IIf(NumEnteros = 0, "0", 1)
    '    'Dim RegexExpresion As String = "^[0-9]{1," & NumEnteros & "}(\.[0-9]{0," & NumDecimales & "})?$"
    '    Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NumEnteros & "}(\.[0-9]{0," & NumDecimales & "})?$"
    '    Dim NumeroOriginal As String = NumeroTexto
    '    NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
    '    If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
    '        NumeroTexto = NumeroOriginal
    '        SoloNumerosConDecimal = 0
    '    Else
    '        SoloNumerosConDecimal = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloNumerosConDecimal = Keyascii
    '        Case 13
    '            SoloNumerosConDecimal = Keyascii
    '        Case 32
    '            SoloNumerosConDecimal = Keyascii
    '    End Select

    'End Function


    Public Shared Function SoloNumerosConDecimal(ByVal sender As TextBox, ByVal Keyascii As Short) As Short
        Dim TextBox As TextBox
        Dim NumeroTexto As String
        TextBox = CType(sender, TextBox)
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

    Public Const Len_OrdenEmbarcada_CPTDAR As Integer = 20
    Public Const Len_OrdenEmbarcada_NFCTCM As Integer = 30
    Public Const Len_OrdenEmbarcada_QTPCM2 As Integer = 16



  Public Shared Function Numero_Paginas(ByVal dtPrincipal As DataTable, ByVal PageSize As Int32) As Int64
    Dim num_registros As Int64
    Dim num_registro_pag As Int64
    Dim pag As Decimal = 0
    Dim resultado As Int64
    num_registros = dtPrincipal.Rows.Count
    num_registro_pag = PageSize
    pag = num_registros / num_registro_pag
    If (pag) > Math.Truncate(pag) Then
      resultado = Math.Truncate(pag + 1)
    Else
      resultado = Math.Truncate(pag)
    End If
    Return resultado
  End Function


  Public Shared Function PaginarDatos(ByVal dtPaginar As DataTable, ByVal PageSize As Int32, ByVal PageNumber As Int32) As DataTable
    Dim dtnew As New DataTable
    Dim posicion_inicial As Int64
    Dim posicion_final As Int64
    dtnew = dtPaginar.Clone
    If dtPaginar.Rows.Count > 0 Then
      posicion_inicial = PageSize * (PageNumber - 1)
      posicion_final = PageSize * PageNumber
      If posicion_final >= dtPaginar.Rows.Count Then
        posicion_final = dtPaginar.Rows.Count - 1
      End If
      For i As Integer = posicion_inicial To posicion_final
        dtnew.ImportRow(dtPaginar.Rows(i))
      Next
    End If
    Return dtnew
  End Function






End Class
