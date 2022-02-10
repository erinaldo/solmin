Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class OperacionesXAlquiler_BLL

    Dim objDataAccessLayer As New OperacionesXAlquiler_DAL

    Public Function Listar_Operacion_X_Alquiler(ByVal objEntidad As OperacionesXAlquiler) As List(Of OperacionesXAlquiler)
        Return objDataAccessLayer.Listar_Operacion_X_Alquiler(objEntidad)
    End Function

    Public Sub Registrar_Operacion_X_Alquiler(ByVal olstOperacionXAlquiler As List(Of OperacionesXAlquiler))
        For Each objEntidad As OperacionesXAlquiler In olstOperacionXAlquiler
            objDataAccessLayer.Registrar_Operacion_X_Alquiler(objEntidad)
        Next
    End Sub

    Public Sub Actualizar_NroAlquiler_Operacion(ByVal olstOperacionXAlquiler As List(Of OperacionesXAlquiler))
        For Each objEntidad As OperacionesXAlquiler In olstOperacionXAlquiler
            objDataAccessLayer.Actualizar_NroAlquiler_Operacion(objEntidad)
        Next
    End Sub

    Public Sub Registrar_Aprobacion_Alquiler(ByVal obeOperacionesXAlquiler As OperacionesXAlquiler)
        objDataAccessLayer.Registrar_Aprobacion_Alquiler(obeOperacionesXAlquiler)
    End Sub

End Class
