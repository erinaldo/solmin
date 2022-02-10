Imports RANSA.DATA
Imports System.Collections.Generic
Public Class UploadImagen
    Public Function GuardarEnTabla(ByVal objParams As Hashtable) As Boolean
        Dim obj As New clsUploadImagen
        Return obj.GuardarEnTabla(objParams)
    End Function

    Public Function GuardarEnTablaGuiaRemision(ByVal objParams As Hashtable) As Boolean
        Dim obj As New clsUploadImagen
        Return obj.GuardarEnTablaGuiaRemision(objParams)
    End Function

    Public Function EliminaRelacion(ByVal objParams As Hashtable) As Boolean
        Dim obj As New clsUploadImagen
        Return obj.EliminaRelacion(objParams)
    End Function

    Public Function EliminaRelacionImagenGuia(ByVal objParams As Hashtable) As Boolean
        Dim obj As New clsUploadImagen
        Return obj.EliminaRelacionImagenGuia(objParams)
    End Function




End Class
