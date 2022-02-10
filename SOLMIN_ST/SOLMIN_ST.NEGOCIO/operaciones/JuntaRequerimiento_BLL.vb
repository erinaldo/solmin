Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class JuntaRequerimiento_BLL

    Dim ObjDAL As JuntaRequerimiento_DAL


    Public Sub Insertar_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento)

        ObjDAL = New JuntaRequerimiento_DAL
        ObjDAL.Insertar_Requerimientos_X_Junta(Entidad)

    End Sub

    Public Function Lista_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento) As List(Of JuntaRequerimiento)

        ObjDAL = New JuntaRequerimiento_DAL
        Return ObjDAL.Lista_Requerimientos_X_Junta(Entidad)

    End Function

    Public Function Eliminar_Requerimientos_X_Junta(ByVal Entidad As JuntaRequerimiento) As Int32

        ObjDAL = New JuntaRequerimiento_DAL
        Return ObjDAL.Eliminar_Requerimientos_X_Junta(Entidad)

    End Function

    Public Function Lista_Requerimiento_X_Junta_RZOL48(ByVal Entidad As AtencionRequerimiento) As List(Of AtencionRequerimiento)

        ObjDAL = New JuntaRequerimiento_DAL
        Return ObjDAL.Lista_Requerimiento_X_Junta_RZOL48(Entidad)

    End Function

    Public Function Listar_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of ENTIDADES.Operaciones.Junta_Transporte)
        ObjDAL = New JuntaRequerimiento_DAL
        Return ObjDAL.Listar_Junta_Transporte(objParamList)
    End Function



End Class
