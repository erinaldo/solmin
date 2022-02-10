Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsConsultaOAgencia

  Dim objDatos As New Datos.clsConsultaOAgencia

  Public Function Lista_ConsultaOAgencia(ByVal oConsultaOAgencia As beConsultaOAgencia) As DataTable
    Dim odaConsultaOAgencia As New Datos.clsConsultaOAgencia()
    Dim odtConsultaOAgencia As New DataTable
    odtConsultaOAgencia = odaConsultaOAgencia.Lista_ConsultaOAgencia(oConsultaOAgencia)
    Return odtConsultaOAgencia
  End Function

  Public Function Lista_ConsultaOAgencia_Checkpoint(ByVal oConsultaOAgencia As beConsultaOAgencia) As DataTable
    Dim odaConsultaOAgencia As New Datos.clsConsultaOAgencia()
    Dim objdatatable As New DataTable
    objdatatable = odaConsultaOAgencia.Lista_ConsultaOAgencia_Checkpoint(oConsultaOAgencia)
    Return objdatatable
  End Function
End Class
