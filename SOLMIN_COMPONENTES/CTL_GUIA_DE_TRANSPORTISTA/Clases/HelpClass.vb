Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO  
Imports System.Data
Imports System.Reflection

Public MustInherit Class HelpClass

  Public Shared Function RestarFechas(ByVal Fecha As Date, ByVal CantidadDias As Long) As Date
    Dim span As TimeSpan = New TimeSpan(Fecha.Ticks)
    Dim sp As TimeSpan = span.Subtract(TimeSpan.FromDays(CantidadDias))
    Return New Date(sp.Ticks)
  End Function

  Public Shared Sub MsgBox(ByVal Texto As String)

    Dim SistNom As String = "SOLMIN"
    MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK)

  End Sub

  Public Shared Sub MsgBox(ByVal Texto As String, ByVal i As System.Windows.Forms.MessageBoxIcon)
    Dim SistNom As String = "SOLMIN"
    MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK, i)
  End Sub

  Public Shared Sub ErrorMsgBox()

    Dim SistNom As String = "SOLMIN"
    MessageBox.Show(getErrMessage, SistNom, MessageBoxButtons.OK)

  End Sub

  Public Shared Function RspMsgBox(ByVal Texto As String) As DialogResult

    Dim SistNom As String = "SOLMIN"
    Return MessageBox.Show(Texto, SistNom, MessageBoxButtons.YesNo)

  End Function

  Public Shared Function getErrMessage() As String
    Return "ERROR: CONSULTE AL AREA DE SISTEMAS"
  End Function

  Public Shared Function getSetting(ByVal Nombre As String) As String
    Return ""
  End Function

  Public Shared Function CtypeDate(ByVal obj As Object) As String

    Dim objDate As New Date
    If obj.Equals("") = True Then
      objDate = DateTime.Today
    Else
      objDate = obj
    End If
    Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)

  End Function


  Public Shared Function DateConvert(ByVal obj As Object) As String

    Dim objDate As New Date
    If obj.Equals("") = True Then
      objDate = DateTime.Today
    Else
      objDate = obj
    End If
    Return objDate.Year & "-" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "-" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)

  End Function

  Public Shared Function RowFilterDate(ByVal obj As Date) As String
    Return IIf(obj.Month < 10, "0" & obj.Month, obj.Month) & "/" & IIf(obj.Day < 10, "0" & obj.Day, obj.Day) & "/" & obj.Year
  End Function

  Public Shared Sub OpenWeb(ByVal Url As String)
    On Error Resume Next
    System.Windows.Forms.Help.ShowHelp(New Form(), Url)
  End Sub

  Public Shared Function getTextFile(ByVal Archivo As String) As StringBuilder

    Dim str As New StringBuilder
    Try
      Dim oFile As New IO.StreamReader(Archivo)
      While oFile.EndOfStream = False
        str.Append(oFile.ReadLine)
      End While
    Catch : End Try

    Return str

  End Function

  Public Shared Sub CrystalReportTextObject(ByRef rpt As ReportClass, ByVal TextObject As String, ByVal Value As String)
    CType(rpt.ReportDefinition.ReportObjects(TextObject), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Value
  End Sub

  Public Shared Sub CrystalReportImageObject(ByRef rpt As ReportClass, ByVal TextObject As String, ByVal Value As String)


  End Sub

  Public Shared Sub WriteTextFile(ByVal Archivo As String, ByVal Texto As String)

    Try
      Dim oFile As New IO.StreamWriter(Application.StartupPath & "\" & Archivo, False, Encoding.ASCII)
      oFile.WriteLine(Texto.ToString())
      oFile.Close()
    Catch : End Try

  End Sub

  Public Shared Function CompletarCadena(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As HorizontalAlignment)

    'funcion para completar una cadena
    Dim longitudActual As Integer = Texto.Length

    For i As Integer = longitudActual To Longitud - 1
      If Orientacion = HorizontalAlignment.Right Then
        Texto = Texto & Caracter
      Else
        Texto = Caracter & Texto
      End If
    Next

    Return Texto

  End Function

  Public Shared Function FormatoNumerico_Sin_Comas(ByVal numero As String) As String
    Return numero.Replace(",", "")
  End Function



  Public Shared Function TodayNumeric() As String
    Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
  End Function

  Public Shared Function NowNumeric() As String
    Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
  End Function

  Public Shared Function CNumero_a_Fecha(ByVal oFecha As Object) As Date

    Dim y As Integer
    Dim m As Integer
    Dim d As Integer

    y = Left(oFecha.ToString(), 4)
    m = Right(Left(oFecha.ToString(), 6), 2)
    d = Right(oFecha.ToString(), 2)

    Dim objDate As New Date(y, m, d)

    Return objDate
  End Function

  'Public Shared Function GetDataSetNative(Of T)(ByVal _
  '          list As List(Of T)) As DataTable
  '  Dim _resultDataSet As New DataSet()
  '  Dim _resultDataTable As New DataTable("dtb")
  '  Dim _resultDataRow As DataRow = Nothing
  '  Dim _itemProperties() As PropertyInfo = list.Item(0).GetType().GetProperties()
  '  '    
  '  ' Meta Data. 
  '  '
  '  _itemProperties = list.Item(0).GetType().GetProperties()
  '  For Each p As PropertyInfo In _itemProperties
  '    _resultDataTable.Columns.Add(p.Name, _
  '              p.GetGetMethod.ReturnType())
  '  Next
  '  '
  '  ' Data
  '  '
  '  For Each item As T In list
  '    '
  '    ' Get the data from this item into a DataRow
  '    ' then add the DataRow to the DataTable.
  '    ' Eeach items property becomes a colunm.
  '    '
  '    _itemProperties = item.GetType().GetProperties()
  '    _resultDataRow = _resultDataTable.NewRow()
  '    For Each p As PropertyInfo In _itemProperties
  '      _resultDataRow(p.Name) = p.GetValue(item, Nothing)
  '    Next
  '    _resultDataTable.Rows.Add(_resultDataRow)
  '  Next
  '  '
  '  ' Add the DataTable to the DataSet, We are DONE!
  '  '
  '  _resultDataSet.Tables.Add(_resultDataTable)
  '  Return _resultDataSet.Tables(0)
  'End Function

  Public Shared Function GetDataSetNative(Of T)(ByVal list As List(Of T)) As DataTable
    Dim _resultDataSet As New DataSet()
    Dim _resultDataTable As New DataTable("dtb")
    Dim _resultDataRow As DataRow = Nothing
    If list.Count > 0 Then
      Dim _itemProperties() As PropertyInfo = list.Item(0).GetType().GetProperties()
      '    
      ' Meta Data. 
      '
      _itemProperties = list.Item(0).GetType().GetProperties()
      For Each p As PropertyInfo In _itemProperties
        _resultDataTable.Columns.Add(p.Name, _
                  p.GetGetMethod.ReturnType())
      Next
      '
      ' Data
      '
      For Each item As T In list
        '
        ' Get the data from this item into a DataRow
        ' then add the DataRow to the DataTable.
        ' Eeach items property becomes a colunm.
        '
        _itemProperties = item.GetType().GetProperties()
        _resultDataRow = _resultDataTable.NewRow()
        For Each p As PropertyInfo In _itemProperties
          _resultDataRow(p.Name) = p.GetValue(item, Nothing)
        Next
        _resultDataTable.Rows.Add(_resultDataRow)
      Next
      '
      ' Add the DataTable to the DataSet, We are DONE!
      '
      _resultDataSet.Tables.Add(_resultDataTable)
      Return _resultDataSet.Tables(0)
    Else
      Return New Data.DataTable
    End If

  End Function

  Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short

    'If (Keyascii < 48 And Keyascii <> 8 And Keyascii <> 13) Or Keyascii > 57 Then
    '  SoloNumeros = 0
    'Else
    '  SoloNumeros = Keyascii
    'End If

    If InStr("1234567890", Chr(Keyascii)) = 0 Then
      SoloNumeros = 0
    Else
      SoloNumeros = Keyascii
    End If
    Select Case Keyascii
      Case 8
        SoloNumeros = Keyascii
      Case 13
        SoloNumeros = Keyascii
    End Select

  End Function

  Public Shared Function SoloLetras(ByVal KeyAscii As Integer) As Integer
    KeyAscii = Asc(UCase(Chr(KeyAscii)))
    If InStr("1234567890", Chr(KeyAscii)) <> 0 Then
      SoloLetras = 0
    Else
      SoloLetras = KeyAscii
    End If
    Select Case KeyAscii
      Case 8
        SoloLetras = KeyAscii
      Case 13
        SoloLetras = KeyAscii
      Case 32
        SoloLetras = KeyAscii
    End Select
  End Function

  Public Shared Function ConvertHoraNumeric(ByVal Hora As String) As String
    Dim lstr_hora As String = Hora.Trim.Substring(0, 2) & Hora.Trim.Substring(3, 2) & Hora.Trim.Substring(6, 2)
    Return lstr_hora
  End Function

  Public Shared Function ConvertHoraGPS_Hora(ByVal Hora As String) As String
    Dim lstr_hora As String = ""
    Dim lint_hora As Integer = 0
    Dim lstr_hora_1 As String = ""
    Dim lstr_estado As String = Hora.Trim.Substring(8, 3)
    lint_hora = Convert.ToInt32(Hora.Trim.Substring(0, 2))
    If lint_hora > 0 And lint_hora < 5 Then
      Select Case lint_hora
        Case 1
          lstr_hora_1 = "20"
        Case 2
          lstr_hora_1 = "21"
        Case 3
          lstr_hora_1 = "22"
        Case 4
          lstr_hora_1 = "23"
      End Select
    Else
      lstr_hora_1 = Convert.ToString(lint_hora - 5)
    End If
    If lint_hora < 12 Then
      lstr_estado = " am"
    Else
      lstr_estado = " pm"
    End If
    If lint_hora < 10 Then lstr_hora_1 = "0" & lint_hora
    lstr_hora = lstr_hora_1 & ":" & Hora.Trim.Substring(3, Hora.Trim.Length - 6) & lstr_estado
    Return lstr_hora
  End Function

  Public Shared Function Now_Hora() As String
    Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & ":" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & ":" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second) & " " & IIf(Now.Hour < 10, "am", "pm")
  End Function

  Public Shared Function ImageConversion(ByVal image As System.Drawing.Image, ByVal formatoImagen As System.Drawing.Imaging.ImageFormat) As String
    If image Is Nothing Then Return ""
    Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream
    image.Save(memoryStream, formatoImagen)
    Dim value As String = ""
    For intCnt As Integer = 0 To memoryStream.ToArray.Length - 1
      value = value & memoryStream.ToArray(intCnt) & ","
    Next
    Return value
    End Function


   

End Class
