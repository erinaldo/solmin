
Public Class CargaAdjuntos_BL
    Dim oCargaAdjuntos_DAL As New CargaAdjuntos_DAL

    'Get_Bucket_AWS
    Public Function Get_Bucket_AWS() As DataTable
        Return oCargaAdjuntos_DAL.Get_Bucket_AWS()
    End Function
    Public Function Get_Bucket_AWS_APP2021() As DataTable
        Return oCargaAdjuntos_DAL.Get_Bucket_AWS_APP2021()
    End Function



    Public Function Cargar_Motivo_Adjuntos(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Return oCargaAdjuntos_DAL.Cargar_Motivo_Adjuntos(objCargaAdjuntos)
    End Function

    Public Function Listar_Documentos(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Return oCargaAdjuntos_DAL.Listar_Documentos(objCargaAdjuntos)
    End Function

    Public Function crear_carpeta(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Return oCargaAdjuntos_DAL.crear_carpeta(objCargaAdjuntos)
    End Function
  
    Public Function agregar_documento(ByVal objCargaAdjuntos As CargaAdjuntos) As String
        Return oCargaAdjuntos_DAL.agregar_documento(objCargaAdjuntos)
    End Function
    Public Sub eliminar_imagenes(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.eliminar_imagenes(objCargaAdjuntos)
    End Sub
    Public Sub Eliminar_Relacion_RZSC03(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZSC03(objCargaAdjuntos)
    End Sub
    Public Sub Guardar_relacion_RZSC03(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZSC03(objCargaAdjuntos)
    End Sub


    Public Sub Eliminar_Relacion_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZTR05(objCargaAdjuntos)
    End Sub
    Public Sub Guardar_relacion_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZTR05(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZTR76(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZTR76(objCargaAdjuntos)
    End Sub
    Public Sub Guardar_relacion_RZTR76(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZTR76(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZST07(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZST07(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZOL65P(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZOL65P(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZOL65I(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZOL65I(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZOL67(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZOL67(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZOL65(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZOL65(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZIM36(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZIM36(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZSC53(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZSC53(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZSC58(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZSC58(objCargaAdjuntos)
    End Sub

    Public Sub Eliminar_Relacion_RZTR31(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Eliminar_Relacion_RZTR31(objCargaAdjuntos)
    End Sub


    Public Sub Guardar_relacion_RZST07(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZST07(objCargaAdjuntos)

    End Sub

    Public Sub Guardar_relacion_RZOL65P(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZOL65P(objCargaAdjuntos)

    End Sub

    Public Sub Guardar_relacion_RZOL65I(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZOL65I(objCargaAdjuntos)

    End Sub

    Public Sub Guardar_relacion_RZOL67(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZOL67(objCargaAdjuntos)

    End Sub

    Public Sub Guardar_relacion_RZOL65(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZOL65(objCargaAdjuntos)
    End Sub

    Public Sub Guardar_relacion_RZIM36(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZIM36(objCargaAdjuntos)
    End Sub

    Public Sub Guardar_relacion_RZSC53(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZSC53(objCargaAdjuntos)
    End Sub

    Public Sub Guardar_relacion_RZSC58(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZSC58(objCargaAdjuntos)
    End Sub

    Public Sub Guardar_relacion_RZTR31(ByVal objCargaAdjuntos As CargaAdjuntos)
        oCargaAdjuntos_DAL.Guardar_relacion_RZTR31(objCargaAdjuntos)
    End Sub

    Public Function Listar_Documentos_List_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos) As DataTable
        Return oCargaAdjuntos_DAL.Listar_Documentos_List_RZTR05(objCargaAdjuntos)
    End Function

   

End Class
