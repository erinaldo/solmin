Imports System.Drawing
Imports WebServiceLib = solmin_st.negocio.localhost

Public Class ImageWebUpload_BLL

  Private objWebService As New WebServiceLib.SolminWeb
    Private _rutaImagen As String = ""

    Sub New()
    End Sub

    Public Property ImageSourcePath() As String
        Get
            Return _rutaImagen
        End Get
        Set(ByVal value As String)
            _rutaImagen = value
        End Set
    End Property

    Public Function UploadImage(ByVal Nombre As String, ByVal Carpeta As String) As Boolean
        Dim objImage As New Object
        objImage = CType(Drawing.Image.FromFile(_rutaImagen), Object)
    Return objWebService.GuardarImagen(objImage, Nombre, Carpeta)
    End Function

    Public Function ExisteImagen(ByVal Carpeta As String, ByVal Nombre As String) As Boolean
    Return objWebService.ExisteImagen(Carpeta, Nombre)
    End Function

    Public Function getImage(ByVal Carpeta As String, ByVal Nombre As String) As Drawing.Bitmap
    Return CType(CType(objWebService.getImage(Carpeta, Nombre), Object), Drawing.Bitmap)
    End Function

End Class
