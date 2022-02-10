Imports System.IO

Public Class Validacion

    ''' <summary>
    ''' Convierte de Imagen("Image") a arreglo de Bytes 
    ''' </summary>
    ''' <param name="img ">Imagen ("Image")</param>
    ''' <returns>Arreglo de Byte()</returns>
    ''' <remarks></remarks>

    Public Shared Function ImageToByte(ByVal img As Drawing.Image) As Byte()
        Dim imgStream As IO.MemoryStream = New IO.MemoryStream()

        img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
        imgStream.Close()
        Dim byteArray As Byte() = imgStream.ToArray()
        imgStream.Dispose()
        Return byteArray
    End Function

    ''' <summary>
    ''' Convierte de dirección Url de una imagen  a Bitmap 
    ''' </summary>
    ''' <param name="url">Dirección url</param>
    ''' <param name="originalsize"></param>
    ''' <param name="height">Alto</param>
    ''' <param name="width">Ancho</param>
    ''' <returns>Bitmap</returns>
    ''' <remarks></remarks>
    Public Shared Function LoadImageFromUrl(ByRef url As String, Optional ByVal originalsize As Boolean = False, Optional ByVal height As Integer = 80, Optional ByVal width As Integer = 60) As Drawing.Bitmap
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Drawing.Image = Drawing.Image.FromStream(response.GetResponseStream())
            Dim objbitmap As Drawing.Bitmap
            If originalsize = False Then
                objbitmap = New Drawing.Bitmap(img, height, width)
            Else
                objbitmap = img
            End If
            response.Close()
            Return objbitmap
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' envias direccion del  imagen, devuelve arreglo de Bytes()
    ''' </summary>
    ''' <param name="nombrearchivo"> Dirección del Imagen </param>
    ''' <returns>Arreglo de Byte()</returns>
    ''' <remarks></remarks>
    Public Shared Function ConversionImagen(ByVal nombrearchivo As String) As Byte()
        'Declaramos fs para poder abrir la imagen.
        Dim fs As New FileStream(nombrearchivo, FileMode.Open)

        ' Declaramos un lector binario para pasar la imagen
        ' a bytes
        Dim br As New BinaryReader(fs)
        Dim imagen As Byte() = New Byte(CInt(fs.Length) - 1) {}
        br.Read(imagen, 0, CInt(fs.Length))
        br.Close()
        fs.Close()
        Return imagen
    End Function

    ''' <summary>
    ''' Convierte de Número a Letra
    ''' </summary>
    ''' <param name="value">Número</param>
    ''' <returns>Letra</returns>
    ''' <remarks></remarks>
    Public Function Num2Text(ByVal value As Double) As String
        Dim valores() As String
        Dim valor As String = value
        Dim entero As Decimal = 0
        Dim fraccion As Decimal = 0
        If valor.Contains(".") OrElse valor.Contains(",") Then
            valores = Split(valor, ".")
            value = CDec(valores(0))
            If valores.Length > 1 Then
                fraccion = CDec(valores(1))
            End If
        End If
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
        If fraccion <> 0 Then
            Num2Text = Num2Text & " y  " & fraccion & "/100"
        End If
    End Function

    ''' <summary>
    ''' Convierte de número a formato de fecha
    ''' </summary>
    ''' <param name="oFecha">Numero</param>
    ''' <returns>Fecha</returns>
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

    Public Shared Function CFecha_a_Numero10Digitos(ByVal fecha As String) As String
        If fecha = "" OrElse fecha = "0" Then Return ""
        Dim y As String = fecha.Substring(0, 4)
        Dim m As String = fecha.Substring(4, 2)
        Dim d As String = fecha.Substring(6, 2)
        Return y & "-" & m & "-" & d
    End Function
    Public Shared Function CFecha_a_NewFormat(ByVal fecha As String) As String
        Dim y As String = fecha.Substring(6, 4)
        Dim m As String = fecha.Substring(3, 2)
        Dim d As String = fecha.Substring(0, 2)
        Return y & "-" & m & "-" & d
    End Function
End Class
