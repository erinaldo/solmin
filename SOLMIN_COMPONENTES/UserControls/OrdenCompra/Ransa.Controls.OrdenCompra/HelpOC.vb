Imports System.IO
Public Class HelpOC
    Public Function validaCaracter(ByVal strCadena As String, ByRef strMensaje As String) As String

        Dim sLine As String = String.Empty
        Dim strRuta As String = Application.StartupPath & "\\Texto\\" & "txtValidaCaracter.txt"


        If File.Exists(strRuta) Then

            Dim objReaderValida As New IO.StreamReader(strRuta, System.Text.Encoding.GetEncoding(1252))

            Do
                sLine = objReaderValida.ReadLine()

                If Not sLine Is Nothing AndAlso Not sLine.ToString.Equals("") Then
                    strCadena = strCadena.Replace(sLine.Substring(0, 1), sLine.Substring(1, sLine.Length - 1))
                End If

            Loop Until sLine Is Nothing OrElse sLine.ToString.Equals("")

            objReaderValida.Close()
        Else
            strMensaje = "No se encuentra el archivo de validación de caracteres, Notifique a Sistemas"
        End If
        Return strCadena
    End Function
End Class
