Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO
Imports System.Collections

Public MustInherit Class HelpClass

    Public Shared Sub MsgBox(ByVal Texto As String)

        Dim SistNom As String = getSetting("Sistema")
        MessageBox.Show(Texto, SistNom, MessageBoxButtons.OK)

    End Sub

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
    '''''OJO'''''
    'Public Shared Sub CrystalReportTextObject(ByRef rpt As ReportClass, ByVal TextObject As String, ByVal Value As String)
    '    CType(rpt.ReportDefinition.ReportObjects(TextObject), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Value
    'End Sub

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

End Class