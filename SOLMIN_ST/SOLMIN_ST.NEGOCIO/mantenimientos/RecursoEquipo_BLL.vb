Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports System.Collections.Generic


Public Class RecursoEquipo_BLL
    Dim objDataAccessLayer As New RecursoEquipo_DAL

    Public Function Registrar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo
        Return objDataAccessLayer.Registrar_Recurso_Equipo(objEntidad)
    End Function

    Public Function Modificar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo
        Return objDataAccessLayer.Modificar_Recurso_Equipo(objEntidad)
    End Function


    Public Function Eliminar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo
        Return objDataAccessLayer.Eliminar_Recurso_Equipo(objEntidad)
    End Function

    Public Function Buscar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Return objDataAccessLayer.Buscar_Recurso_Equipo(objEntidad)
    End Function

    Public Function Obtener_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Return objDataAccessLayer.Obtener_Recurso_Equipo(objEntidad)
    End Function

    Public Function Listar_Tipo_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Return objDataAccessLayer.Listar_Tipo_Recurso_Equipo(objEntidad)
    End Function


End Class
