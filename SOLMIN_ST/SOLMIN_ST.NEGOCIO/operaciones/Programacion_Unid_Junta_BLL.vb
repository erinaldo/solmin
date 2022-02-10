
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class Programacion_Unid_Junta_BLL

    Dim ObjDAL As Programacion_Unid_Junta_DAL


    Public Sub Insertar_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad)

        ObjDAL = New Programacion_Unid_Junta_DAL
        ObjDAL.Insertar_Unidades_RequerimientosJunta(Entidad)

    End Sub

    Public Function Lista_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal CCMPN As String) As List(Of Programacion_Unidad)

        ObjDAL = New Programacion_Unid_Junta_DAL
        Return ObjDAL.Lista_Unidades_RequerimientosJunta(Entidad, CCMPN)

    End Function

    Public Function Eliminar_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad) As Int32

        ObjDAL = New Programacion_Unid_Junta_DAL
        Return ObjDAL.Eliminar_Unidades_RequerimientosJunta(Entidad)

    End Function

    Public Function Lista_Unidades_Programadas(ByVal CCMPN As String, ByVal NUMREQT As Decimal, ByVal SESASG As String) As List(Of Programacion_Unidad)

        ObjDAL = New Programacion_Unid_Junta_DAL
        Return ObjDAL.Lista_Unidades_Programadas(CCMPN, NUMREQT, SESASG)

    End Function

    Public Function Cambiar_Estado_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal PNNOPRCN As Double) As Int32

        ObjDAL = New Programacion_Unid_Junta_DAL
        Return ObjDAL.Cambiar_Estado_Unidades_RequerimientosJunta(Entidad, PNNOPRCN)
    End Function

    Public Function Estado_Unidad_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal CCMPN As String) As DataTable

        ObjDAL = New Programacion_Unid_Junta_DAL
        Return ObjDAL.Estado_Unidad_RequerimientosJunta(Entidad, CCMPN)

    End Function

End Class

