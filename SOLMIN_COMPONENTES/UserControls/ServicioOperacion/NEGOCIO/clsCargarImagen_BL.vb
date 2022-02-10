
Public Class clsCargarImagen_BL

    Dim objWebService As New WSCargarDocumento.SolminWeb

    Public Function ExisteImagen(ByVal Carpeta As String, ByVal Nombre As String) As Boolean
        Return objWebService.ExisteImagen(Carpeta, Nombre)
    End Function

    Public Function GetFileExtencion(ByVal Carpeta As String, ByVal Nombre As String) As String
        Return objWebService.getFileExtension(Carpeta, Nombre)
    End Function

    Public Function RemplazarFile(ByVal strCarpeta As String, ByVal strorigen As String, ByVal strDestino As String) As String
        Return objWebService.CambiarNombre(strCarpeta, strorigen, strDestino)
    End Function

End Class
