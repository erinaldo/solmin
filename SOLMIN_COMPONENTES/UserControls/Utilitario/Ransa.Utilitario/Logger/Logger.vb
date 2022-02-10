Imports System.IO
Imports System.Text
'<[AHM]>
Public NotInheritable Class Logger
    Public Function RegistrarEvento(ByVal ParamArray parametros As String()) As Boolean
        Dim mensaje As String = Me.FormatMessage(parametros)
        Dim fullPath As String = Me.FormatNameFile()
        Dim done As Boolean = Me.GrabarTxt(fullPath, String.Format("{0}{1}{2}{3}", DateTime.Now, Environment.NewLine, mensaje, Environment.NewLine))

        Return done
    End Function

    Private Function FormatMessage(ByVal ParamArray parametros As String()) As String
        Dim mensaje As String = ""
        For Each parametro As String In parametros
            mensaje += String.Format("{0}{1}", parametro, Environment.NewLine)
        Next

        Return mensaje
    End Function

    Private Function FormatNameFile() As String
        Return String.Format("{0}{1}{2}", AppDomain.CurrentDomain.BaseDirectory, "\log\", String.Format("{0:yyMMdd}{1}", DateTime.Now, "log.txt"))
    End Function

    Dim _locker As Object = New Object
    Private Function GrabarTxt(ByVal fullPathName As String, ByVal mensaje As String) As Boolean
        Try
            If (Not Directory.Exists(Path.GetDirectoryName(fullPathName))) Then
                Directory.CreateDirectory(Path.GetDirectoryName(fullPathName))
            End If

            SyncLock _locker
                Dim log As StreamWriter
                If (Not File.Exists(fullPathName)) Then
                    log = New StreamWriter(fullPathName, True, Encoding.Default)
                Else
                    log = File.AppendText(fullPathName)
                End If
                Using (log)
                    log.WriteLine(mensaje)
                    log.Close()
                End Using
            End SyncLock

            Return True
        Catch ex As Exception
            'ESTABLECER UN PUNTO DE REFERECIA LA CAIDA
            Return False
        End Try
    End Function

End Class
'</[AHM]>