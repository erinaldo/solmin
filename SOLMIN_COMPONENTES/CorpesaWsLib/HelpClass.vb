
Imports Microsoft.VisualBasic 
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.Directory
Imports System.Data
Imports System.Reflection
Imports System.Data.OleDb
Imports System.ComponentModel

Public MustInherit Class HelpClass
  
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
 
End Class

