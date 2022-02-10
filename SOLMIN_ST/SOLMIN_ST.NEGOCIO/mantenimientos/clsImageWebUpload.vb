Imports SOLMIN_ST.Negocio.pe.com.ransa.asp

Namespace mantenimientos

    Public Class clsImageWebUpload
        Dim objWebService As New SolminWeb

        Public Function ExisteImagen(ByVal Carpeta As String, ByVal Nombre As String) As Boolean
            Return objWebService.ExisteImagen(Carpeta, Nombre)
        End Function

        Public Function GetFileExtension(ByVal Carpeta As String, ByVal Nombre As String) As String
            Return objWebService.getFileExtension(Carpeta, Nombre)
        End Function

    End Class

End Namespace