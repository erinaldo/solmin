Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class Gastos_Ruta_BLL

  Private lobjGastos_RutaDAL As Gastos_Ruta_DAL

  Public Sub New()
    lobjGastos_RutaDAL = New Gastos_Ruta_DAL
  End Sub

  Public Function Lista_Solicitud_Gastos_Ruta(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
    Return lobjGastos_RutaDAL.Lista_Solicitud_Gastos_Ruta(objetoParametro)
  End Function
  Public Function Calular_Importe_Ruta(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
    Return lobjGastos_RutaDAL.Calular_Importe_Ruta(objetoParametro)
  End Function
  Public Function Obtener_Datos_Obrero(ByVal objetoParametro As Hashtable) As Obrero
    Return lobjGastos_RutaDAL.Obtener_Datos_Obrero(objetoParametro)
  End Function

  Public Function ReporteControlGastos(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
    Return lobjGastos_RutaDAL.ReporteControlGastos(objetoParametro)
  End Function

  Public Function Reporte_Pedido_Efectivo(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
    Return lobjGastos_RutaDAL.Reporte_Pedido_Efectivo(objetoParametro)
  End Function
  Public Function Reporte_Lista_Asignacion_AVC(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
    Return lobjGastos_RutaDAL.Reporte_Lista_Asignacion_AVC(objetoParametro)
  End Function
  Public Function Actualizar_Estado_Imprimir_AVC(ByVal intNMSLPE As Int64, ByVal stsTipo As String) As Int32
    Return lobjGastos_RutaDAL.Actualizar_Estado_Imprimir_AVC(intNMSLPE, stsTipo)
  End Function

End Class
