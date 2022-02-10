Imports SOLMIN_ST
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Public Class RecursosReasignado_BLL
    Dim objDataAccessLayer As New RecursosReasignado_DAL

    Sub New()
    End Sub
 
    Public Function Listar_Recursos_Asignados(ByVal objParametro As AsigRecursoGT_BE) As List(Of AsigRecursoGT_BE)
        Return objDataAccessLayer.Listar_Recursos_Asignados(objParametro)
    End Function
    Public Function Insertar_Asignacion_Recurso(ByVal objParametro As AsigRecursoGT_BE) As String
        Return objDataAccessLayer.Insertar_Asignacion_Recurso(objParametro)
    End Function
    Public Function Eliminar_Asignacion_Recurso(ByVal objParametro As AsigRecursoGT_BE) As String
        Return objDataAccessLayer.Eliminar_Asignacion_Recurso(objParametro)
    End Function
End Class
