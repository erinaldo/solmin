Imports SOLMIN_SC.Negocio.pe.com.ransa.asp

Public Class clsImageWebUpload

    Dim objWebService As New SolminWeb

    Public Function ExisteImagen(ByVal Carpeta As String, ByVal Nombre As String) As Boolean
        Return objWebService.ExisteImagen(Carpeta, Nombre)
    End Function

    Public Function GetFileExtencion(ByVal Carpeta As String, ByVal Nombre As String) As String
        Return objWebService.getFileExtension(Carpeta, Nombre)
    End Function
End Class
