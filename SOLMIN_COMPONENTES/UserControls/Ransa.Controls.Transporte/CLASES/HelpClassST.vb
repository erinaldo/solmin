Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.Directory
Imports System.Data
Imports System.Reflection
Imports System.Data.OleDb
Imports System.ComponentModel
'Imports CarlosAg.ExcelXmlWriter

Public MustInherit Class HelpClassST

    ''' <summary>
    ''' Convierte Número a formato de fecha (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="fecha">Fecha en formato Date</param>
    ''' <returns>Fecha en Número</returns>
    ''' <remarks></remarks>
    ''' 






    Private Shared propertyinfo As Dictionary(Of String, PropertyInfo)
    Public Shared Function CreateObjectsFromDataTable(Of T)(ByVal table As DataTable) As List(Of T)
        Dim tipo As String = ""
        Dim oLista As List(Of T) = New List(Of T)
        'If Not String.IsNullOrEmpty(Me.PageCount) Then oLista.PageCount = Me.PageCount
        Try
            For Each row As DataRow In table.Rows
                Dim obj As T = Activator.CreateInstance(Of T)()
                propertyinfo = New Dictionary(Of String, PropertyInfo)

                For Each info As PropertyInfo In GetType(T).GetProperties()
                    propertyinfo.Add(info.GetCustomAttributes(False)(0).Description.ToString.ToUpper, info)
                Next

                For Each col As DataColumn In table.Columns
                    Dim val As Object = row(col)
                    If val IsNot System.DBNull.Value Then
                        'tipo = val.GetType.FullName.ToString
                        'Select Case tipo
                        '    Case "System.String"
                        '        val = val.ToString.Trim
                        '        val = DirectCast(val, System.Decimal)
                        'End Select
                        If propertyinfo.ContainsKey(col.ColumnName.ToUpper()) Then
                            'Tipo de dato de la propiedad
                            tipo = propertyinfo(col.ColumnName).PropertyType.FullName.ToString()
                            Select Case tipo
                                Case "System.String"
                                    propertyinfo(col.ColumnName).SetValue(obj, val.ToString.Trim, Nothing)
                                Case "System.Decimal"
                                    propertyinfo(col.ColumnName).SetValue(obj, Convert.ToDecimal(val), Nothing)
                                Case "System.Int8", "System.Int16", "System.Int32"
                                    propertyinfo(col.ColumnName).SetValue(obj, Convert.ToInt32(val), Nothing)
                                Case "System.DateTime"
                                    propertyinfo(col.ColumnName).SetValue(obj, DirectCast(val, System.DateTime), Nothing)
                            End Select
                        End If
                    End If
                Next
                oLista.Add(obj)
            Next
        Catch ex As Exception
        End Try
        Return oLista
    End Function

    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function



    Public Shared Function CDate_a_Numero8Digitos(ByVal fecha As Date) As String

        Dim yy As String = fecha.Year
        Dim mm As String = fecha.Month
        Dim dd As String = fecha.Day

        If mm.Length = 1 Then
            mm = "0" & mm
        End If
        If dd.Length = 1 Then
            dd = "0" & dd
        End If
        Return yy & mm & dd
    End Function

    Public Shared Function CDate_a_Numero8DigitosDefault(ByVal fecha As Date) As String
        Dim retorno As String = ""
        If (fecha = "") Then
            retorno = "0"
        Else
            Dim yy As String = fecha.Year
            Dim mm As String = fecha.Month
            Dim dd As String = fecha.Day

            If mm.Length = 1 Then
                mm = "0" & mm
            End If
            If dd.Length = 1 Then
                dd = "0" & dd
            End If
            retorno = yy & mm & dd
        End If

        Return retorno
    End Function

    ''' <summary>
    ''' convierte fecha(string) en número yyyymmdd
    ''' </summary>
    ''' <param name="fecha"> fecha(string)</param>
    ''' <returns>Fecha en Número</returns>
    ''' <remarks></remarks>
    Public Shared Function CFecha_a_Numero10Digitos(ByVal fecha As String) As String
        Dim y As String = fecha.Substring(6, 4)
        Dim m As String = fecha.Substring(3, 2)
        Dim d As String = fecha.Substring(0, 2)
        Return y & "-" & m & "-" & d
    End Function
    Public Shared Function CFecha_de_8_a_10(ByVal fecha As String) As String
        If fecha = "" OrElse fecha = "0" Then Return ""
        Dim y As String = fecha.Substring(0, 4)
        Dim m As String = fecha.Substring(4, 2)
        Dim d As String = fecha.Substring(6, 2)
        Return y & "-" & m & "-" & d
    End Function
    Public Shared Function CFecha_10_10(ByVal fecha As String) As String
        If fecha = "" OrElse fecha = "0" Then Return ""
        Dim y As String = fecha.Substring(0, 4)
        Dim m As String = fecha.Substring(5, 2)
        Dim d As String = fecha.Substring(8, 2)
        Return y & "/" & m & "/" & d
    End Function

    Public Shared Function CFecha_a_Numero8Digitos(ByVal fecha As String) As String
        Dim y As String = fecha.Substring(6, 4)
        Dim m As String = fecha.Substring(3, 2)
        Dim d As String = fecha.Substring(0, 2)
        Return y & m & d
    End Function
    Public Shared Function CFecha_de_10_a_8(ByVal fecha As String) As String
        Dim y As String = fecha.Substring(0, 4)
        Dim m As String = fecha.Substring(5, 2)
        Dim d As String = fecha.Substring(8, 2)
        Return y & m & d
    End Function

    Public Shared Function TodayAnio() As Int64
        Return Today.Year
    End Function


    ''' <summary>
    ''' Actualiza la celda seleccionada 
    ''' </summary>
    ''' <param name="grilla">Nombre del DataGridView</param>
    ''' <param name="valorBusqueda">Valor de búqueda</param>
    ''' <param name="columnaBusqueda">Columna en la que  va ha realizar la búsqueda</param>
    ''' <remarks></remarks>
    'Public Shared Sub seleccionarFila(ByVal grilla As DataGridView, ByVal valorBusqueda As String, ByVal columnaBusqueda As String)
    '    For i As Integer = 0 To grilla.Rows.Count - 1
    '        If grilla.Item(columnaBusqueda, i).Value.Equals(valorBusqueda) Then
    '            grilla.CurrentCell = grilla.Rows(i).Cells(0)
    '        End If
    '    Next
    'End Sub

    ''' <summary>
    ''' Link de la solicitud de transporte
    ''' </summary>
    ''' <returns>link de transporte</returns>
    ''' <remarks></remarks>
    'Public Shared Function getURLDocLinksSolTransp() As String
    '    Return getSetting("URLDocLinksSolTransp")
    'End Function

    ''' <summary>
    ''' Resta en día a una fecha 
    ''' </summary>
    ''' <param name="Fecha">Fecha a la que se va restar</param>
    ''' <param name="CantidadDias">Cantidad de días a restar</param>
    ''' <returns>Retornar fecha restada</returns>
    ''' <remarks></remarks>
    'Public Shared Function RestarFechas(ByVal Fecha As Date, ByVal CantidadDias As Long) As Date
    '    Dim span As TimeSpan = New TimeSpan(Fecha.Ticks)
    '    Dim sp As TimeSpan = span.Subtract(TimeSpan.FromDays(CantidadDias))
    '    Return New Date(sp.Ticks)
    'End Function

    ''' <summary>
    ''' Muestra un mensaje en un cuadro de diálogo
    ''' </summary>
    ''' <param name="Texto">Texto a mostrar en el mensaje</param>
    ''' <remarks></remarks>
    'Public Shared Sub MsgBox(ByVal Texto As String)
    '    Dim SistNom As String = getSetting("Sistema")
    '    MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK)
    'End Sub

    ''' <summary>
    ''' Muestra un mensaje en un cuadro de diálogo
    ''' </summary>
    ''' <param name="Texto">Texto a mostrar en el mensaje</param>
    ''' <param name="i">MessageBoxIcon</param>
    ''' <remarks></remarks>
    'Public Shared Sub MsgBox(ByVal Texto As String, ByVal i As System.Windows.Forms.MessageBoxIcon)
    '    Dim SistNom As String = getSetting("Sistema")
    '    MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK, i)
    'End Sub

    ''' <summary>
    ''' Muestra un mensaje de error en un cuadro de diálogo
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    'Public Shared Sub ErrorMsgBox()
    '    Dim SistNom As String = getSetting("Sistema")
    '    MessageBox.Show(getErrMessage, SistNom, MessageBoxButtons.OK)
    'End Sub

    ''' <summary>
    ''' Muestra un mensaje de pregunta en un cuadro de diálogo
    ''' </summary>
    ''' <param name="Texto">Texto a mostrar en el mensaje</param>
    ''' <returns>Retorna  Yes o No</returns>
    ''' <remarks></remarks>
    'Public Shared Function RspMsgBox(ByVal Texto As String) As DialogResult
    '    Dim SistNom As String = getSetting("Sistema")
    '    Return MessageBox.Show(Texto, SistNom, MessageBoxButtons.YesNo)
    'End Function

    ''' <summary>
    ''' Retorna mensaje de error
    ''' </summary>
    ''' <returns>error</returns>
    ''' <remarks></remarks>
    'Public Shared Function getErrMessage() As String
    '    Return Configuration.ConfigurationSettings.AppSettings("MsgErr").ToString()
    'End Function

    'Public Shared Function getSetting(ByVal Nombre As String) As String
    '    Return Configuration.ConfigurationSettings.AppSettings(Nombre).ToString()
    'End Function

    ''' <summary>
    ''' Convierte fecha en Número 
    ''' </summary>
    ''' <param name="obj">Fecha</param>
    ''' <returns>Número</returns>
    ''' <remarks></remarks>
    Public Shared Function CtypeDate(ByVal obj As Object) As String
        Dim objDate As New Date
        If obj.Equals("") = True Then
            objDate = DateTime.Today
        Else
            objDate = obj
        End If
        Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)
    End Function

    ''' <summary>
    ''' Convierte fecha (yyyy/mm/dd hh:mm:ss) en Cadena (yyyy-mm-dd)
    ''' </summary>
    ''' <param name="obj">Fecha</param>
    ''' <returns>Cadena en formato (YYYY-MM-DD) </returns>
    ''' <remarks></remarks>
    Public Shared Function DateConvert(ByVal obj As Object) As String
        Dim objDate As New Date
        If obj.Equals("") = True Then
            objDate = DateTime.Today
        Else
            objDate = obj
        End If
        Return objDate.Year & "-" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "-" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)

    End Function

    ''' <summary>
    ''' Conviete de fecha (yyyy/mm/dd hh:mm:ss) en fecha (yyyy/mm/dd )
    ''' </summary>
    ''' <param name="obj">Fecha</param>
    ''' <returns>Fecha en formato (yyyy/mm/dd )</returns>
    ''' <remarks></remarks>
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

    Public Shared Sub WriteTextFile(ByVal Archivo As String, ByVal Texto As String)
        Try
            Dim oFile As New IO.StreamWriter(Application.StartupPath & "\" & Archivo, False, Encoding.ASCII)
            oFile.WriteLine(Texto.ToString())
            oFile.Close()
        Catch : End Try

    End Sub

    ''' <summary>
    ''' Funcion para completar una cadena
    ''' </summary>
    ''' <param name="Texto">Texto</param>
    ''' <param name="Longitud">Longitud</param>
    ''' <param name="Caracter">Caracter</param>
    ''' <param name="Orientacion">Orientación</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CompletarCadena(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As HorizontalAlignment)
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

    ''' <summary>
    ''' Retorna Número sin comas
    ''' </summary>
    ''' <param name="numero">Número</param>
    ''' <returns>Número son comas</returns>
    ''' <remarks></remarks>
    Public Shared Function FormatoNumerico_Sin_Comas(ByVal numero As String) As String
        Return numero.Replace(",", "")
    End Function

    ''' <summary>
    ''' Retorna el Nombre de la PC
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>


    ''' <summary>
    ''' Retorna la fecha actual en número yyymmdd
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    ''' <summary>
    ''' Retorna Hora actual en Número hhmmss
    ''' </summary>
    ''' <returns>Hora</returns>
    ''' <remarks></remarks>
    Public Shared Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

    ''' <summary>
    ''' Convierte número de ocho yyyymmdd digitos a cadena en formato (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="oFecha">Número en formato yyyymmdd</param>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    Public Shared Function CNumero8Digitos_a_Fecha(ByVal oFecha As Object) As String
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""

        y = Left(oFecha.ToString(), 4)
        m = Right(Left(oFecha.ToString(), 6), 2)
        d = Right(oFecha.ToString(), 2)
        Return d & "/" & m & "/" & y
    End Function

    ''' <summary>
    ''' Convierte número de ocho digitos yyyymmdd a fecha en formato (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="oFecha">>Número en formato yyyymmdd</param>
    ''' <returns>retorna fecha en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Convierte número de 6 yyyymm digitos a cadena en formato (mm-yyyy)
    ''' </summary>
    ''' <param name="oFecha">Número en formato yyyymmdd</param>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    Public Shared Function CNumero6Digitos_a_Fecha(ByVal oFecha As Object) As String
        Dim y As String = ""
        Dim m As String = ""
        'Dim d As String = ""
        Dim Fecha As Date = CType(CNumero8Digitos_a_Fecha(oFecha), Date)
        Dim Mes As String = MonthName(Convert.ToInt32(Fecha.Month), True).ToUpper
        y = Left(oFecha.ToString(), 4)
        m = Mes 'Left(oFecha.ToString(), 2)
        'd = Right(oFecha.ToString(), 2)
        Return m & "-" & y
    End Function

    Public Shared Function CNumero_a_Hora_string(ByVal oHora As Object) As String
        Dim h As String
        Dim m As String
        Dim s As String
        If oHora.ToString.Trim.Length < 6 Then
            oHora = "0" & oHora
        End If

        h = Left(oHora.ToString(), 2)
        m = Right(Left(oHora.ToString(), 4), 2)
        s = Right(oHora.ToString(), 2)
        Return h + ":" + m + ":" + s

    End Function

    Public Shared Function HoraNum_a_Hora_Default(ByVal oHora As Object) As String
        Dim Hora As String = ("" & oHora).ToString.Trim
        If Hora = "" OrElse Hora = "0" Then Return ""

        Dim h As String = ""
        Dim m As String = ""
        Dim s As String = ""
        If Hora.ToString.Trim.Length < 6 Then
            Hora = "0" & Hora
        End If
        h = Left(Hora, 2).PadLeft(2, "0")
        m = Right(Left(Hora, 4), 2).PadLeft(2, "0")
        s = Right(Hora, 2).PadLeft(2, "0")
        Hora = h + ":" + m + ":" + s
        Return Hora
    End Function


    ''' <summary>
    ''' Listar Meses del Año
    ''' </summary>
    ''' <param name="oAnio">>String en formato yyyy</param>
    ''' <returns>retorna datatable con Meses del Año</returns>
    ''' <remarks></remarks>

    Public Shared Function Listar_Meses_X_Anio(ByVal oAnio As String) As DataTable
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("VALUE")
        odtMeses.Columns.Add("ANIO")
        odtMeses.Columns.Add("MES")

        odtMeses.Rows.Add(New Object() {oAnio + "01", oAnio, "ENERO"})
        odtMeses.Rows.Add(New Object() {oAnio + "02", oAnio, "FEBRERO"})
        odtMeses.Rows.Add(New Object() {oAnio + "03", oAnio, "MARZO"})
        odtMeses.Rows.Add(New Object() {oAnio + "04", oAnio, "ABRIL"})
        odtMeses.Rows.Add(New Object() {oAnio + "05", oAnio, "MAYO"})
        odtMeses.Rows.Add(New Object() {oAnio + "06", oAnio, "JUNIO"})
        odtMeses.Rows.Add(New Object() {oAnio + "07", oAnio, "JULIO"})
        odtMeses.Rows.Add(New Object() {oAnio + "08", oAnio, "AGOSTO"})
        odtMeses.Rows.Add(New Object() {oAnio + "09", oAnio, "SETIEMBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "10", oAnio, "OCTUBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "11", oAnio, "NOVIEMBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "12", oAnio, "DICIEMBRE"})

        Return odtMeses
    End Function


    ''' <summary>
    ''' Convierte número de ocho digitos yyyymmdd a fecha en formato (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="oHora">>Número en formato yyyymmdd</param>
    ''' <returns>retorna fecha en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    Public Shared Function CNumero_a_Hora(ByVal oHora As Object) As Date
        Dim h As String
        Dim m As String
        Dim s As String
        If oHora.ToString.Trim.Length < 6 Then
            oHora = "0" & oHora
        End If

        h = Left(oHora.ToString(), 2)
        m = Right(Left(oHora.ToString(), 4), 2)
        s = Right(oHora.ToString(), 2)
        Return h + ":" + m + ":" + s
    End Function

    ''' <summary>
    ''' Convierte Lista de Objetos en DataTable  
    ''' </summary>
    ''' <typeparam name="T"> List(Of T)</typeparam>
    ''' <param name="list">Lista de Objetos</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataSetNative(Of T)(ByVal list As List(Of T)) As DataTable
        Dim _resultDataSet As New DataSet()
        Dim _resultDataTable As New DataTable("dtb")
        Dim _resultDataRow As DataRow = Nothing
        If list.Count > 0 Then
            Dim _itemProperties() As PropertyInfo = list.Item(0).GetType().GetProperties()
            _itemProperties = list.Item(0).GetType().GetProperties()
            For Each p As PropertyInfo In _itemProperties
                _resultDataTable.Columns.Add(p.Name, _
                       p.GetGetMethod.ReturnType())
            Next
            For Each item As T In list
                _itemProperties = item.GetType().GetProperties()
                _resultDataRow = _resultDataTable.NewRow()
                For Each p As PropertyInfo In _itemProperties
                    _resultDataRow(p.Name) = p.GetValue(item, Nothing)
                Next
                _resultDataTable.Rows.Add(_resultDataRow)
            Next
            _resultDataSet.Tables.Add(_resultDataTable)
            Return _resultDataSet.Tables(0)
        Else
            Return New Data.DataTable

        End If

    End Function

    ''' <summary>
    ''' Valida Solo números
    ''' </summary>
    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
            Case 32
                SoloNumeros = Keyascii
        End Select

    End Function


    ''' <summary>
    ''' Valida Ingreso Numero con signo
    ''' </summary>
    Public Shared Function Numeros(ByVal NumeroEvaluacion As String, ByVal ConSigno As Boolean, ByVal numEnteros As Int32, ByVal NumDecimales As Int32, ByVal Keyascii As Short) As Short
        NumeroEvaluacion = NumeroEvaluacion.Trim
        Dim NumeroFormadoTMP As String = ""
        Dim ArrayNumeroFormado() As String
        Dim numero As Short

        If (ConSigno = False) Then
            If InStr("1234567890", Chr(Keyascii)) = 0 Then
                numero = 0
            Else
                numero = Keyascii
            End If
        Else

            If (numEnteros < 0 Or NumDecimales < 0) Then
                numero = 0

            Else
                If InStr("1234567890.-", Chr(Keyascii)) Then

                    If (NumeroEvaluacion = "") Then
                        If InStr("-", Chr(Keyascii)) <> 0 Then
                            numero = Keyascii
                        Else
                            If InStr("1234567890", Chr(Keyascii)) = 0 Then
                                numero = 0
                            Else
                                numero = Keyascii
                            End If
                        End If
                    Else
                        If (CharOcurrencia(NumeroEvaluacion, ".") = 0 And CharOcurrencia(NumeroEvaluacion, "-") <= 1) Then

                            If InStr(".", Chr(Keyascii)) <> 0 Then

                                If (NumDecimales = 0) Then
                                    numero = 0
                                Else
                                    numero = Keyascii
                                End If
                            Else
                                If InStr("1234567890", Chr(Keyascii)) = 0 Then
                                    numero = 0
                                Else
                                    numero = Keyascii
                                End If
                            End If
                        Else
                            If InStr("1234567890", Chr(Keyascii)) = 0 Then
                                numero = 0
                            Else
                                numero = Keyascii
                            End If
                        End If
                    End If


                    If (numero <> 0) Then
                        NumeroFormadoTMP = (NumeroEvaluacion & Chr(Keyascii)).Trim
                        NumeroFormadoTMP = NumeroFormadoTMP.Replace("-", "").Trim
                        If (NumeroFormadoTMP <> "") Then
                            ArrayNumeroFormado = NumeroFormadoTMP.Split(".")
                            If (ArrayNumeroFormado.Length > 0) Then
                                If (ArrayNumeroFormado(0).Length > numEnteros) Then
                                    numero = 0
                                End If
                                If (ArrayNumeroFormado.Length = 2) Then
                                    If (ArrayNumeroFormado(1).Length > NumDecimales) Then
                                        numero = 0
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        End If






        Select Case Keyascii
            Case 8
                numero = Keyascii
            Case 13
                numero = Keyascii

        End Select
        Return numero
    End Function

    Public Shared Function CharOcurrencia(ByVal texto As String, ByVal busqueda As Char) As Int32
        Dim bus As String = busqueda.ToString
        Dim lenCadena As Int32 = texto.Trim.Length - 1
        Dim numChar As Int32 = 0
        For index As Integer = 0 To lenCadena
            If (texto.Substring(index, 1) = busqueda) Then
                numChar += 1
            End If
        Next
        Return numChar
    End Function

    ''' <summary>
    ''' Valida solo Letras
    ''' </summary>
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

    ''' <summary>
    ''' Convierte  Hora a número
    ''' </summary>
    ''' <param name="Hora"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertHoraNumeric(ByVal Hora As String) As String
        Dim lstr_hora As String = Hora.Trim.Substring(0, 2) & Hora.Trim.Substring(3, 2) & Hora.Trim.Substring(6, 2)
        Return lstr_hora
    End Function

    Public Shared Function ConvertFechaGPS_Fecha(ByVal Fecha As String) As String
        Dim lstr_Fecha As String = CType(Fecha, Date).AddDays(-1).ToShortDateString
        Return lstr_Fecha
    End Function

    ''' <summary>
    ''' Hora actual 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Now_Hora() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & ":" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & ":" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dataGridView"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Shared Function Generate(ByVal dataGridView As DataGridView) As Workbook
    '    Dim workbook As New Workbook()
    '    Dim worksheet As Worksheet = workbook.Worksheets.Add("Hoja 1")

    '    Dim worksheetRow As New WorksheetRow()
    '    For Each dataGridViewColumn As DataGridViewColumn In dataGridView.Columns
    '        If dataGridViewColumn.Visible Then
    '            worksheet.Table.Columns.Add(New WorksheetColumn(dataGridViewColumn.Width))
    '            worksheetRow.Cells.Add(New WorksheetCell(dataGridViewColumn.HeaderText))
    '        End If
    '    Next
    '    worksheet.Table.Rows.Insert(0, worksheetRow)

    '    Dim worksheetDefaultStyle As WorksheetStyle = GetWorksheetStyle(dataGridView.DefaultCellStyle, "Default")
    '    workbook.Styles.Add(worksheetDefaultStyle)

    '    For rowIndex As Integer = 0 To dataGridView.RowCount - 1
    '        worksheetRow = worksheet.Table.Rows.Add()

    '        For columnIndex As Integer = 0 To dataGridView.ColumnCount - 1
    '            If dataGridView.Columns(columnIndex).Visible Then
    '                Dim cell As DataGridViewCell = dataGridView(columnIndex, rowIndex)
    '                Dim cellStyle As WorksheetStyle = GetWorksheetStyle(cell.InheritedStyle, "column" & columnIndex & "row" & rowIndex)

    '                If cellStyle IsNot Nothing Then
    '                    workbook.Styles.Add(cellStyle)
    '                Else
    '                    cellStyle = worksheetDefaultStyle
    '                End If

    '                Dim dataType As DataType = GetDataType(cell.ValueType)
    '                worksheetRow.Cells.Add(cell.FormattedValue.ToString(), dataType, cellStyle.ID)
    '            End If
    '        Next
    '    Next

    '    Return workbook
    'End Function

    'Private Shared Function GetWorksheetStyle(ByVal dataGridViewCellStyle As DataGridViewCellStyle, ByVal id As String) As WorksheetStyle
    '    Dim worksheetStyle As WorksheetStyle = Nothing

    '    If dataGridViewCellStyle IsNot Nothing Then
    '        worksheetStyle = New WorksheetStyle(id)
    '        If Not dataGridViewCellStyle.BackColor.IsEmpty Then
    '            worksheetStyle.Interior.Color = GetColorName(dataGridViewCellStyle.BackColor)
    '            worksheetStyle.Interior.Pattern = StyleInteriorPattern.Solid
    '        End If

    '        If Not dataGridViewCellStyle.ForeColor.IsEmpty Then
    '            worksheetStyle.Font.Color = GetColorName(dataGridViewCellStyle.ForeColor)
    '        End If
    '        If dataGridViewCellStyle.Font IsNot Nothing Then
    '            worksheetStyle.Font.Bold = dataGridViewCellStyle.Font.Bold
    '            worksheetStyle.Font.FontName = dataGridViewCellStyle.Font.Name
    '            worksheetStyle.Font.Italic = dataGridViewCellStyle.Font.Italic
    '            worksheetStyle.Font.Size = Convert.ToInt32(dataGridViewCellStyle.Font.Size)
    '            worksheetStyle.Font.Strikethrough = dataGridViewCellStyle.Font.Strikeout
    '            worksheetStyle.Font.Underline = IIf(dataGridViewCellStyle.Font.Underline, UnderlineStyle.Single, UnderlineStyle.None)
    '        End If

    '        worksheetStyle.Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1, "Black")
    '        worksheetStyle.Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1, "Black")
    '        worksheetStyle.Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1, "Black")
    '        worksheetStyle.Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1, "Black")
    '    End If
    '    Return worksheetStyle
    'End Function

    'Private Shared Function GetColorName(ByVal color As System.Drawing.Color) As String
    '    Return "#" + color.ToArgb().ToString("X").Substring(2)
    'End Function

    'Private Shared Function GetDataType(ByVal valueType As Type) As DataType
    '    If valueType.ToString = GetType(DateTime).ToString Then
    '        Return DataType.[String]
    '    ElseIf valueType.ToString = GetType(String()).ToString Then
    '        Return DataType.[String]
    '    ElseIf valueType.ToString = GetType(SByte).ToString OrElse _
    '           valueType.ToString = GetType(Byte).ToString OrElse _
    '           valueType.ToString = GetType(Short).ToString OrElse _
    '           valueType.ToString = GetType(UShort).ToString OrElse _
    '           valueType.ToString = GetType(Integer).ToString OrElse _
    '           valueType.ToString = GetType(UInteger).ToString OrElse _
    '           valueType.ToString = GetType(Long).ToString OrElse _
    '           valueType.ToString = GetType(ULong).ToString OrElse _
    '           valueType.ToString = GetType(Single).ToString OrElse _
    '           valueType.ToString = GetType(Double).ToString OrElse _
    '           valueType.ToString = GetType(Decimal).ToString Then
    '        Return DataType.Number
    '    Else
    '        Return DataType.[String]
    '    End If
    'End Function


    ''' <summary>
    ''' Exporta a Excel Lista de DataGridView por medio de HTML
    ''' </summary>
    'Public Shared Sub ExportarExcel_HTML(ByVal objListDtg As List(Of DataGridView))
    '    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"
    '    If IO.Directory.Exists(path) = False Then
    '        IO.Directory.CreateDirectory(path)
    '    End If
    '    Dim archivo As String = path & "reporte" & HelpClassST.NowNumeric & ".xls" 'xml
    '    Dim xls As New IO.StreamWriter(archivo, True, Encoding.Default)

    '    For Each odtg As DataGridView In objListDtg
    '        xls.WriteLine("<TABLE border='1' >")
    '        xls.WriteLine("<tr>")
    '        For columna As Integer = 0 To odtg.Columns.Count - 1
    '            If odtg.Columns.Item(columna).Visible Then
    '                xls.Write("<td style='background:#FFA200; text-align:center; line-height:18px; Font(-weight): bold()' >" & odtg.Columns.Item(columna).HeaderText.ToString() & "</td>")


    '            End If
    '        Next
    '        xls.WriteLine("</tr>")
    '        For fila As Integer = 0 To odtg.Rows.Count - 1
    '            xls.WriteLine("<tr>")
    '            For columna As Integer = 0 To odtg.Columns.Count - 1
    '                If odtg.Columns.Item(columna).Visible Then
    '                    If Not ((odtg.Item(columna, fila).Value Is DBNull.Value) OrElse odtg.Item(columna, fila).Value = Nothing) Then
    '                        xls.Write("<td>" & odtg.Item(columna, fila).Value & "</td>")
    '                    Else
    '                        xls.Write("<td> </td>")
    '                    End If
    '                End If
    '            Next
    '            xls.WriteLine("</tr>")
    '        Next
    '        xls.WriteLine("</TABLE>")
    '    Next
    '    xls.Flush()
    '    xls.Close()
    '    xls.Dispose()
    '    AbrirDocumento(archivo)
    'End Sub

    ''' <summary>
    ''' Exporta a Excel Lista de DataGridView por medio de XML
    ''' </summary>
    'Public Shared Sub ExportarExcel_XML(ByVal objListDtg As List(Of DataGridView))
    '    'averiguando si es que existe el directorio a exportar
    '    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"
    '    If IO.Directory.Exists(path) = False Then
    '        IO.Directory.CreateDirectory(path)
    '    End If
    '    Dim archivo As String = path & "reporte" & HelpClassST.NowNumeric & ".xml" 'xml
    '    Dim xls As New IO.StreamWriter(archivo, True, Encoding.UTF8)
    '    xls.WriteLine("<?xml version=""1.0""?>")
    '    xls.WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet""")
    '    xls.WriteLine("xmlns:o=""urn:schemas-microsoft-com:office:office""")
    '    xls.WriteLine("xmlns:x=""urn:schemas-microsoft-com:office:excel""")
    '    xls.WriteLine("xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet""")
    '    xls.WriteLine("xmlns:html=""http://www.w3.org/TR/REC-html40"">")

    '    For Each odtg As DataGridView In objListDtg
    '        xls.WriteLine("<Worksheet ss:Name=""" & odtg.Tag.ToString & """>")
    '        xls.WriteLine(" <Table> ")
    '        xls.WriteLine(" <Row>")
    '        For columna As Integer = 0 To odtg.Columns.Count - 1
    '            xls.WriteLine(" <Cell><Data ss:Type=""String"">" & odtg.Columns.Item(columna).HeaderText.ToString & "</Data></Cell>")
    '        Next
    '        xls.WriteLine(" </Row>")
    '        For fila As Integer = 0 To odtg.Rows.Count - 1
    '            xls.WriteLine("<Row>")
    '            For columna As Integer = 0 To odtg.Columns.Count - 1
    '                If odtg.Columns.Item(columna).Visible Then
    '                    xls.WriteLine("<Cell><Data ss:Type=""String"">" & odtg.Item(columna, fila).Value.ToString() & "</Data></Cell>")
    '                End If
    '            Next
    '            xls.WriteLine(" </Row>")
    '        Next
    '        xls.WriteLine(" </Table>")
    '        xls.WriteLine(" </Worksheet>")

    '    Next
    '    xls.WriteLine(" </Workbook>")
    '    xls.Flush()
    '    xls.Close()
    '    xls.Dispose()
    '    AbrirDocumento(archivo)
    'End Sub

#Region "Exportar Excel lista de DataGridView con oledb"

    'Public Shared Sub ListaATexto(ByVal objListDtg As DataGridView, ByVal Archivo As String, ByVal Separador As String)
    '    Using sw As New StreamWriter(Archivo, False, System.Text.Encoding.Default)
    '        For I As Integer = 0 To objListDtg.ColumnCount - 1
    '            sw.Write(objListDtg.Columns(I).HeaderText)
    '            If I = objListDtg.ColumnCount - 1 Then Exit For
    '            sw.Write(Separador)
    '        Next
    '        sw.WriteLine()
    '        For I As Integer = 0 To objListDtg.Rows.Count - 1
    '            For J As Integer = 0 To objListDtg.Columns.Count - 1
    '                sw.Write(objListDtg.Rows(I).Cells(J).Value)
    '                If J = objListDtg.ColumnCount - 1 Then Exit For
    '                sw.Write(Separador)
    '            Next
    '            sw.WriteLine()
    '        Next
    '    End Using
    'End Sub

    'Public Shared Sub TextoAExcel(ByVal Archivo As String, ByVal Hoja As String, Optional ByVal Eliminar As Boolean = True)
    '    Dim Ruta As String = Application.StartupPath
    '    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    '    Dim Nombre As String = Path.GetFileNameWithoutExtension(Archivo)
    '    Dim ArchivoExcel As String = Ruta & "\" & Nombre & ".xls"
    '    If Eliminar Then
    '        If File.Exists(ArchivoExcel) Then File.Delete(ArchivoExcel)
    '    End If
    '    Using con As New OleDbConnection("provider=Microsoft.Jet.oledb.4.0;data source=" & Ruta & ";extended properties=Text;")
    '        con.Open()
    '        Dim cmd As New OleDbCommand("Select * Into [" & Hoja.Trim & "] In ''[Excel 8.0;Database=" & ArchivoExcel & "]From " & Nombre & "#TXT", con)
    '        cmd.ExecuteNonQuery()
    '    End Using
    'End Sub

    ''' <summary>
    ''' Exporta a Excel Lista de DataGridView por medio de oledb
    ''' </summary>
    'Public Shared Sub ExportarExcel_OLEDB(ByVal objListDtg As List(Of DataGridView), ByVal Separador As String, ByVal Formato As Boolean)
    '    Dim Archivo As String = "Exportar"
    '    Dim ArchivoExcel As String = Application.StartupPath & "\" & Archivo & ".xls"
    '    If File.Exists(ArchivoExcel) Then File.Delete(ArchivoExcel)
    '    For Each odtg As DataGridView In objListDtg
    '        ListaATexto(odtg, Archivo & ".txt", ",")
    '        TextoAExcel(Archivo & ".txt", odtg.Tag.Trim.ToString, False)
    '    Next
    '    'FormatearLibro(ArchivoExcel)
    '    AbrirDocumento(ArchivoExcel)
    'End Sub

    'Private Shared Sub FormatearLibro(ByVal Archivo As String)
    '    If File.Exists(Archivo) Then
    '        Dim xls As Object
    '        xls = CreateObject("scalc.Application")
    '        xls.Visible = False
    '        Dim Libro As Object = xls.Workbooks.Open(Archivo)
    '        With Libro
    '            Dim Hoja As Object = .Sheets.Item(1)
    '            Dim Rango As Object = xls.Selection.CurrentRegion
    '            Rango.Rows(1).Font.Bold = True
    '            Rango.Rows(1).Font.ColorIndex = 15
    '            Rango.Rows(1).Borders(9).LineStyle = 1
    '            For I As Integer = 7 To 11
    '                Rango.Borders(I).LineStyle = 1
    '            Next
    '            Dim Columna As Object = Hoja.Columns.AutoFit
    '            Rango.Select()
    '            Rango.Copy()
    '            For I As Integer = 2 To .Sheets.Count
    '                Dim Hoja2 As Object = .Sheets.Item(I)
    '                Hoja2.Select()
    '                Hoja2.Range("A1").PasteSpecial(Paste:=-4122, Operation:=-4142, SkipBlanks:=False, Transpose:=False)
    '                Columna = Hoja2.Columns.AutoFit()
    '            Next
    '            xls.CutCopyMode = False
    '            Columna = Nothing
    '            Rango = Nothing
    '            Hoja = Nothing
    '        End With
    '        Libro.Close(True)
    '        Libro = Nothing
    '        xls.Quit()
    '        xls = Nothing
    '    End If
    'End Sub

#End Region

    ''' <summary>
    ''' Abre cualquier tipo de documento
    ''' </summary>
    'Public Shared Sub AbrirDocumento(ByVal Path As String)
    '    Try
    '        Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
    '        Dim Proceso As New System.Diagnostics.Process
    '        With InfoProceso
    '            .FileName = Path
    '            .CreateNoWindow = True
    '            .ErrorDialog = True
    '            .UseShellExecute = True
    '            .WindowStyle = ProcessWindowStyle.Normal
    '        End With
    '        Proceso.StartInfo = InfoProceso
    '        Proceso.Start()
    '        Proceso.Dispose()
    '    Catch
    '    End Try
    'End Sub

    'Public Shared Function getAppVersion() As String
    '    Dim version As String = " 1.0"
    '    Try
    '        Dim verDeployed As System.Version
    '        Dim strVerDeployed As String
    '        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
    '            verDeployed = My.Application.Deployment.CurrentVersion
    '            strVerDeployed = verDeployed.ToString
    '        Else ' or if command line execution
    '            Dim asmThis As System.Reflection.Assembly = System.Reflection.Assembly.Load("CADView")
    '            Dim asnThis As System.Reflection.AssemblyName = asmThis.GetName()
    '            verDeployed = asnThis.Version
    '            strVerDeployed = verDeployed.ToString
    '        End If
    '        version = strVerDeployed
    '    Catch ex As Exception
    '    End Try
    '    Return version
    'End Function

    Public Shared Function MailAccount() As String
        Return "solmin.integracion@gmail.com"
    End Function

    Public Shared Function Mailpassword() As String
        Return "Pa$$w0rd2000"
    End Function

    'Public Shared Function ObjectToInt64(ByVal obj As Object) As Int64
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0 Else Return Convert.ToInt64(obj)
    'End Function
    'Public Shared Function ObjectToInt32(ByVal obj As Object) As Int32
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0 Else Return Convert.ToInt32(obj)
    'End Function
    'Public Shared Function ObjectToInt16(ByVal obj As Object) As Int16
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0 Else Return Convert.ToInt16(obj)
    'End Function
    'Public Shared Function ObjectToDecimal(ByVal obj As Object) As Decimal
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0.0 Else Return Convert.ToDecimal(obj)
    'End Function
    'Public Shared Function StringToDecimal(ByVal obj As Object) As Decimal
    '    If (obj Is Nothing Or obj = "") Then Return 0 Else Return Convert.ToDecimal(obj)
    'End Function
    'Public Shared Function ObjectToInteger(ByVal obj As Object) As Integer
    '    Return ObjectToInt32(obj)
    'End Function
    'Public Shared Function ObjectToDouble(ByVal obj As Object) As Double
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0 Else Return Convert.ToDouble(obj)
    'End Function
    'Public Shared Function ObjectToBoolean(ByVal obj As Object) As Double
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return 0 Else Return Convert.ToBoolean(obj)
    'End Function
    'Public Shared Function ObjectToString(ByVal obj As Object) As String
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return "" Else Return Convert.ToString(obj)
    'End Function
    'Public Shared Function ObjectToDateTime(ByVal obj As Object) As DateTime
    '    If (obj Is Nothing Or IsDBNull(obj)) Then Return DateTime.MinValue Else Return Convert.ToDateTime(obj)
    'End Function
    'Metodo para cambiar el Formato de Fecha de un DataGridView de yyyymmdd a yyyy-mm-dd
    'Argumentos: Nombre del DataGridView y Array de Nombre de Columnas de Fechas a Formatear
    'Public Shared Sub DisplayDateFormat(ByVal myGrid As DataGridView, ByVal columns() As String)
    '    Dim indice As Integer
    '    Dim row As Integer
    '    Dim fecha As String = ""
    '    If myGrid.RowCount <= 0 Then Exit Sub 'Si el grid no tiene filas abandona el metodo
    '    For indice = 0 To columns.Length - 1 'Recorre el array de columnas 
    '        For row = 0 To myGrid.RowCount - 1 'Recorres las filas del grid
    '            fecha = myGrid.Item(columns(indice), row).Value.ToString 'Obtiene el valor de la Celda
    '            If fecha = "" OrElse fecha = "0" Then
    '                myGrid.Item(columns(indice), row).Value = ""
    '            Else
    '                myGrid.Item(columns(indice), row).Value = HelpClassST.CFecha_de_8_a_10(fecha) 'Si la celda es diferente de vacio entonces asigna a esa celda el valor de fecha convertido a yyyy-mm-dd
    '            End If
    '        Next
    '    Next
    'End Sub


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

End Class

