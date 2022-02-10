Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.DATOS

Public Class AVC_BLL

  Private objAVC_DAL As New AVC_DAL

  Public Function Guardar_AVC(ByVal objAVC As AVC) As AVC
    Return objAVC_DAL.Guardar_AVC(objAVC)
  End Function

  Public Function Generar_Codigo() As Double
    Return objAVC_DAL.Generar_Codigo
  End Function
  Public Function Lista_Avc(ByVal pdblNrAVC As Double) As AVC
    Return objAVC_DAL.Lista_Avc(pdblNrAVC)
  End Function

  Public Function Lista_Mantenimiento_AVC(ByVal objEntidad As Hashtable) As List(Of AVC)
    Return objAVC_DAL.Lista_Mantenimiento_AVC(objEntidad)
  End Function

  Public Function Anular(ByVal objEntidad As AVC) As Integer
    Return objAVC_DAL.Anular(objEntidad)
  End Function

  Public Function Auditoria(ByVal objAVC As ClaseGeneral) As ClaseGeneral
    Return objAVC_DAL.Auditoria(objAVC)
  End Function

  Public Function Lista_Reporte_AVC(ByVal objEntidad As Hashtable) As List(Of AVC)
    Return objAVC_DAL.Lista_Reporte_AVC(objEntidad)
  End Function

  Public Function Lista_Reporte_AVC_Tabla(ByVal objEntidad As Hashtable) As DataTable
    Return objAVC_DAL.Lista_Reporte_AVC_Tabla(objEntidad)
  End Function

End Class
