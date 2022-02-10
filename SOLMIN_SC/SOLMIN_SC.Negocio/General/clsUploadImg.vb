Imports System.Collections.Generic
Imports SOLMIN_SC.Entidad
Public Class UploadImagen
    'Public Function GuardarEnTabla(ByVal objParams As Hashtable) As Boolean
    '    Dim obj As New SOLMIN_SC.Datos.clsUploadImagen
    '    Return obj.GuardarEnTabla(objParams)
    'End Function

    'Public Function EliminaRelacion(ByVal objParams As Hashtable) As Boolean
    '    Dim obj As New SOLMIN_SC.Datos.clsUploadImagen
    '    Return obj.EliminaRelacion(objParams)
    'End Function

    Public Function GuardarRelacionImagenRZOL39P_PreEmbarque(ByVal obeCabImagen As beCabImagen, ByVal PNNRPEMB As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.GuardarRelacionImagenRZOL39P_PreEmbarque(obeCabImagen, PNNRPEMB)
    End Function

    Public Function EliminaRelacionImagenRZOL39P_PreEmbarque(ByVal PNNMRGIM As Decimal, ByVal PNNRPEMB As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.EliminaRelacionImagenRZOL39P_PreEmbarque(PNNMRGIM, PNNRPEMB)
    End Function


    Public Function GuardarRelacionImagenRZOL53_Embarque_Doc(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.GuardarRelacionImagenRZOL53_Embarque_Doc(obeCabImagen, PNNORSCI, PNNDOCIN, PNNCRRDC)
    End Function


    Public Function EliminaRelacionImagenRZOL53_Embarque_Doc(ByVal PNNMRGIM As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.EliminaRelacionImagenRZOL53_Embarque_Doc(PNNMRGIM, PNNORSCI, PNNDOCIN, PNNCRRDC)
    End Function

    Public Function GuardarRelacionImagenRZOL53C_Embarque_Costos(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.GuardarRelacionImagenRZOL53C_Embarque_Costos(obeCabImagen, PNNORSCI, PNNDOCIN, PNNCRRDC)
    End Function


    Public Function EliminaRelacionImagenRZOL53C_Embarque_Costos(ByVal PNNMRGIM As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNDOCIN As Decimal, ByVal PNNCRRDC As Decimal) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.EliminaRelacionImagenRZOL53C_Embarque_Costos(PNNMRGIM, PNNORSCI, PNNDOCIN, PNNCRRDC)
    End Function

    Public Function GuardarRelacionImagenRZOL42C_Costos_X_Embarque(ByVal obeCabImagen As beCabImagen, ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.GuardarRelacionImagenRZOL42C_Costos_X_Embarque(obeCabImagen, PNNORSCI, PSCODVAR)
    End Function
    Public Function EliminaRelacionImagenRZOL42C_Costos_X_Embarque(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Boolean
        Dim UploadImagen As New SOLMIN_SC.Datos.clsUploadImagen
        Return UploadImagen.EliminaRelacionImagenRZOL42C_Costos_X_Embarque(PNNORSCI, PSCODVAR)
    End Function
End Class
