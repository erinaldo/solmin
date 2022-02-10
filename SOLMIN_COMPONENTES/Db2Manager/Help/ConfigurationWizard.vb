Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO

Namespace RansaData.iSeries.DataObjects

    Public MustInherit Class ConfigurationWizard

        Public Shared Function LoginFileExists() As Boolean
            If IO.File.Exists(getFolder() & "\LoginConf" & User() & ".cnf") = True Then
                Return True
            Else
                Return False
            End If
        End Function

        'Private Shared Function LoginFileExists() As Boolean
        '    If IO.File.Exists("c:\LoginConf.cnf") = True Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End Function

        ''' <summary>
        '''  Función que indica con un valor TRUE si el archivo de cadena de conexión existe
        ''' </summary>
        'Public Shared Function ConnectionFileExists() As Boolean

        '    If IO.File.Exists("c:\ConnStr.cnf") = True Then
        '        Return True
        '    Else
        '        Return False
        '    End If

        'End Function

        Public Shared Function ConnectionFileExists() As Boolean

            If IO.File.Exists(getFolder() & "\ConnStr" & User() & ".cnf") = True Then
                Return True
            Else
                Return False
            End If

        End Function


''' <summary>
'''  Función que devuelve el contenido del archivo de cadena de conexión
''' </summary>

        'Public Shared Function getConfigFile() As String

        '    Dim str As New StringBuilder
        '    Try
        '        Dim oFile As New IO.StreamReader("c:\ConnStr.cnf", True)
        '        While oFile.EndOfStream = False
        '            str.Append(oFile.ReadLine)
        '        End While
        '        oFile.Close()
        '        oFile.Dispose()
        '    Catch : End Try

        '    Return str.ToString()

        'End Function

        Public Shared Function getConfigFile() As String

            Dim str As New StringBuilder
            Try
                Dim oFile As New IO.StreamReader(getFolder() & "\ConnStr" & User() & ".cnf", True)
                While oFile.EndOfStream = False
                    str.Append(oFile.ReadLine)
                End While
                oFile.Close()
                oFile.Dispose()
            Catch : End Try

            Return str.ToString()

        End Function

''' <summary>
'''  Procedimiento que escribe el contenido del archivo de cadena de conexión
''' </summary>

        'Public Shared Sub WriteConfigFile(ByVal Texto As String)

        '    Try
        '        'Verificando si existe, lo borra
        '        DeleteConfig()
        '        'Escribiendo el archivo
        '        Dim oFile As New IO.StreamWriter("c:\ConnStr.cnf", False, Encoding.ASCII)
        '        oFile.WriteLine(Texto.ToString())
        '        oFile.Close()
        '        oFile.Dispose()
        '    Catch : End Try

        'End Sub

        Public Shared Sub WriteConfigFile(ByVal Texto As String)

            Try
                'Verificando si existe, lo borra
                DeleteConfig()
                'Escribiendo el archivo
                Dim oFile As New IO.StreamWriter(getFolder() & "\ConnStr" & User() & ".cnf", False, Encoding.ASCII)
                oFile.WriteLine(Texto.ToString())
                oFile.Close()
                oFile.Dispose()
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.ToString)
            End Try

        End Sub

''' <summary>
''' Función que devuelve el nombre del usuario en base al contenido del archivo de cadena de conexion
''' </summary> 

        Public Shared Function UserName() As String
            Return GetConnectionSetting("UserId=".ToUpper())
        End Function

        Public Shared Function Password() As String
            Return GetConnectionSetting("Password=".ToUpper())
        End Function

        Public Shared Function Server() As String
            Return GetConnectionSetting("Data Source=".ToUpper())
        End Function
        
        Public Shared Function Library() As String
            Return GetConnectionSetting("DefaultCollection=".ToUpper())
        End Function

        Public Shared Function AmbienteSistema() As String
            Dim libreria As String = GetConnectionSetting("DefaultCollection=".ToUpper())
            Dim ambiente As String = ""
            If libreria.Contains("DC@DESLIB") Then
                ambiente = "DEV"
            End If
            If libreria.Contains("DC@RNSLIB") Then
                ambiente = "PRD"
            End If
            Return ambiente
        End Function

        Public Shared Function GetConnectionSetting(ByVal objSetting As String) As String

            Dim Cadena As String = getConfigFile().ToUpper()
            Dim indice As Integer = Cadena.IndexOf(objSetting.ToUpper, 0)

            Dim objResultado As String = ""
            Dim tamano_texto As Integer = objSetting.Length

            For i As Integer = indice To Cadena.Length - 1

                If (Cadena.Chars(i) = ";") Then
                    Exit For
                End If

                objResultado = objResultado & Cadena.Chars(i)
            Next

            objResultado = Right(objResultado, objResultado.Length - tamano_texto)
            Return objResultado

        End Function

        Public Shared Function ReplaceSchema(ByVal LibraryName As String) As String

            Dim Cadena As String = getConfigFile().ToUpper()
            Dim indice As Integer = Cadena.IndexOf(New String("DefaultCollection=").ToUpper, 0)
            Dim final As Integer = 0

            For i As Integer = indice To Cadena.Length - 1 
                If (Cadena.Chars(i) = ";") Then
                    final = i - 1
                    Exit For
                End If
            Next

            'removiendo el default collection anterior
            Cadena = Cadena.Remove(indice, Math.Abs((indice - final) - 2))
            'insertando el default collection nuevo
            Cadena = Cadena.Insert(indice, "DefaultCollection=" & LibraryName & " ;")
 
            Return Cadena
  
        End Function
        Public Shared Function ReplaceSchema(ByVal LibraryName As String, ByVal strCadena As String) As String

            Dim Cadena As String = strCadena.ToUpper()
            Dim indice As Integer = Cadena.IndexOf(New String("DefaultCollection=").ToUpper, 0)
            Dim final As Integer = 0

            For i As Integer = indice To Cadena.Length - 1
                If (Cadena.Chars(i) = ";") Then
                    final = i - 1
                    Exit For
                End If
            Next

            'removiendo el default collection anterior
            Cadena = Cadena.Remove(indice, Math.Abs((indice - final) - 2))
            'insertando el default collection nuevo
            Cadena = Cadena.Insert(indice, "DefaultCollection=" & LibraryName & " ;")

            Return Cadena

        End Function
''' <summary>
'''  Procedimiento que elimina el archivo de cadena de conexión
''' </summary>

        'Public Shared Sub DeleteConfig()
        '    Try
        '        If IO.File.Exists("c:\ConnStr.cnf") = True And LoginFileExists() = False Then
        '            IO.File.Delete("c:\ConnStr.cnf")
        '        End If
        '    Catch : End Try
        'End Sub

        Public Shared Sub DeleteConfig()
            Try
                If IO.File.Exists(getFolder() & "\ConnStr" & User() & ".cnf") = True And LoginFileExists() = False Then
                    IO.File.Delete(getFolder() & "\ConnStr" & User() & ".cnf")
                End If
            Catch : End Try
        End Sub

        Private Shared Function User() As String

            Dim user_name As String = My.User.Name

            If user_name = "" Then
                Dim objLocalUser As New Microsoft.VisualBasic.ApplicationServices.User
                user_name = objLocalUser.Name
            End If

            user_name = user_name.Replace("\", "_")
            'user_name = user_name.Replace(" ", "_") 
            Return user_name

        End Function

        Private Shared Function getFolder() As String
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        End Function

        Public Shared Function NombreMaquina() As String
            Dim pcname As String = My.Computer.Name.ToString()
            If pcname.Length > 10 Then
                pcname = pcname.Substring(0, 10)
            End If
            Return pcname
        End Function

    End Class

End Namespace
