Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class Multimodal_BLL
    Dim objDataAccessLayer As New Multimodal_DAL

        Public Function Importar_Operaciones_Multimodal(ByVal objParametro As Hashtable) As Integer
            Return objDataAccessLayer.Importar_Operaciones_Multimodal(objParametro)
        End Function

        Public Function Listar_Operaciones_Multimodal_Filtro(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_Multimodal_Filtro(objParametro)
        End Function


    Public Function Listar_Operaciones_Multimodal(ByVal objEntidad As List(Of String)) As List(Of Multimodal)
      Return objDataAccessLayer.Listar_Operaciones_Multimodal(objEntidad)
    End Function

    Public Function Registrar_Operaciones_Multimodal(ByVal objEntidad As Multimodal) As Multimodal
      Return objDataAccessLayer.Registrar_Operacion_Multimodal(objEntidad)
    End Function

    Public Function Modificar_Operacion_Multimodal(ByVal objEntidad As Multimodal) As Multimodal
      Return objDataAccessLayer.Modificar_Operacion_Multimodal(objEntidad)
    End Function

    Public Function Eliminar_Operacion_Multimodal(ByVal objEntidad As Multimodal) As Multimodal
      Return objDataAccessLayer.Eliminar_Operacion_Multimodal(objEntidad)
    End Function

    Public Function Listar_Reporte_Operacion_Multimodal(ByVal objEntidad As List(Of String)) As DataSet
      Return objDataAccessLayer.Listar_Reporte_Operacion_Multimodal(objEntidad)
    End Function

    Public Function Listar_Reporte_Bulto(ByVal objParametro As Hashtable) As DataSet
      Return objDataAccessLayer.Listar_Reporte_Bulto(objParametro)
    End Function
  End Class
End Namespace

