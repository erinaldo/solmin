Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection

    Public MustInherit Class HelpClass

    Public Shared Sub MsgBox(ByVal Texto As String)

        Dim SistNom As String = getSetting("Sistema")
        MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK)
    End Sub
    ''' <summary>
    ''' Muestra un mensaje en un cuadro de diálogo
    ''' </summary>
    ''' <param name="Texto">Texto a mostrar en el mensaje</param>
    ''' <param name="i">MessageBoxIcon</param>
    ''' <remarks></remarks>
    Public Shared Sub MsgBox(ByVal Texto As String, ByVal i As System.Windows.Forms.MessageBoxIcon)
        Dim SistNom As String = getSetting("Sistema")
        MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK, i)
    End Sub

    ''' <summary>
    ''' Muestra un mensaje de error en un cuadro de diálogo
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Shared Sub ErrorMsgBox()
        Dim SistNom As String = getSetting("Sistema")
        MessageBox.Show(getErrMessage, SistNom, MessageBoxButtons.OK)
    End Sub
        Public Shared Function RspMsgBox(ByVal Texto As String) As DialogResult

            Dim SistNom As String = getSetting("Sistema")
            Return MessageBox.Show(Texto, SistNom, MessageBoxButtons.YesNo)

        End Function

    Public Shared Function getErrMessage() As String
        Return Configuration.ConfigurationSettings.AppSettings("MsgErr").ToString()
    End Function

        Public Shared Function getSetting(ByVal Nombre As String) As String
            Return Configuration.ConfigurationSettings.AppSettings(Nombre).ToString()
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

        Public Shared Function CompletarCadena(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As HorizontalAlignment)

            'funcion para completar una cadena
            Dim longitudActual As Integer = Texto.Length

            For i As Integer = longitudActual To Longitud
                If Orientacion = HorizontalAlignment.Right Then
                    Texto = Texto & Caracter
                Else
                    Texto = Caracter & Texto
                End If
            Next

            Return Texto

        End Function
    '---ACD---
    'Replica Ceros
    Public Shared Function Replicar(ByVal str As String, ByVal Times As Int32) As String
        Replicar = String.Empty
        For i As Integer = 1 To Times
            Replicar += str
        Next
    End Function

    Public Shared Function FormatoFecha(ByVal fecha As String) As String
        Dim fechaFormato As String
        If fecha.Length = 8 Then
            fechaFormato = fecha.Substring(6, 2) & "/" & fecha.Substring(4, 2) & "/" & fecha.Substring(0, 4)
        ElseIf fecha.Length = 1 Then
            fechaFormato = ""
        Else
            fechaFormato = Right(fecha, 2) & "/" & Right(fecha, 2) & "/" & Left(fecha, 4)
        End If
        'fechaFormato = fecha
        Return fechaFormato
    End Function

    Public Shared Function FormatoFechaAS400(ByVal fecha As String) As String
        Dim Cadena() As String
        Cadena = Split(fecha, "/")
        Dim fechaFormatoAS400 As String
        If fecha.Length > 1 Then
            fechaFormatoAS400 = Cadena(2) & Cadena(1) & Cadena(0)
        Else
            fechaFormatoAS400 = "00000000"
        End If
        'fechaFormato = fecha
        Return fechaFormatoAS400
    End Function

    Public Shared Function paginarDataDridView(ByVal dtPaginar As DataTable, ByVal inicial As Integer, ByVal final As Integer)
        Dim dtnew As New DataTable
        dtnew = dtPaginar.Clone
        For i As Integer = inicial To final
            If Not (i > (dtPaginar.Rows.Count - 1)) Then
                dtnew.ImportRow(dtPaginar.Rows(i))
            End If
        Next
        Return dtnew
    End Function

    Public Shared Function num_paginas(ByVal dtPaginar As DataTable, ByVal paginaSize As Integer)
        Dim TotalPaginas As Integer
        If dtPaginar.Rows.Count Mod paginaSize = 0 Then
            TotalPaginas = dtPaginar.Rows.Count / paginaSize
        Else
            Dim value As Double = dtPaginar.Rows.Count / paginaSize

            TotalPaginas = Math.Round(value) '+ 1
            If (value - Math.Round(value)) > 0 Then
                TotalPaginas = Math.Round(value) + 1
            Else
                TotalPaginas = Math.Round(value) '+ 1
            End If
        End If
        Return TotalPaginas
    End Function

    '---ACD FIN---

    Public Shared Function FormatoNumerico_Sin_Comas(ByVal numero As String) As String
        Return numero.Replace(",", "")
    End Function

   

    Public Shared Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    Public Shared Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

    Public Shared Sub memoria(ByVal Key As String, ByVal value As String)
        My.Settings.Context.Add(Key, value)
    End Sub

    Public Shared Sub CacheMemory(ByVal Key As String, ByVal value As Object)
        If My.Settings.Context.ContainsKey(Key) Then
            Throw New Exception("Objeto ya existe en Memoria")
        End If
        My.Settings.Context.Add(Key, value)
    End Sub

    Public Shared Function CacheMemory(ByVal Key As String) As Object
        Return My.Settings.Context.Item(Key)
    End Function

    Public Shared Sub ClearCacheMemory(ByVal Key As String)
        My.Settings.Context.Remove(Key)
    End Sub

    Public Shared Function ExistCacheItem(ByVal key As String) As Boolean
        Return My.Settings.Context.ContainsKey(key)
    End Function

    Public Shared Function memoria(ByVal Key As String)
        Return My.Settings.Context.Item(Key).ToString()
    End Function

    Public Shared Sub eliminar_memoria(ByVal Key As String)
        My.Settings.Context.Remove(Key)
    End Sub

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
    ''' Convierte número de ocho yyyymmdd digitos a cadena en formato (dd/mm/yyyy)
    ''' </summary>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>

    Public Shared Function CNumero8Digitos_a_FechaDefault(ByVal oFechaNumero As Int64) As String
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        Dim oFecha As String = oFechaNumero.ToString()
        If (Val(oFecha) = 0) Then
            FechaFormada = ""
        Else
            y = Left(oFecha.ToString(), 4)
            m = Right(Left(oFecha.ToString(), 6), 2)
            d = Right(oFecha.ToString(), 2)
            FechaFormada = d & "/" & m & "/" & y

        End If
        Return FechaFormada
    End Function





    ''' <summary>
    ''' Meses del año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function odtMeses() As DataTable
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dtMes.Rows.Add(dr)

        Return dtMes
    End Function

    Public Shared Function RowToDatatable(ByVal drSelect As DataRow(), ByVal tbl As DataTable) As DataTable

        Dim dt As New DataTable
        dt = tbl.Clone
        For Each row As DataRow In drSelect
            dt.ImportRow(row)
        Next
        Return dt
    End Function



End Class

Public Enum TipoOperacion
    StandBy = 0
    Nuevo = 1
    Modificar = 2
    Eliminar = 3
End Enum
