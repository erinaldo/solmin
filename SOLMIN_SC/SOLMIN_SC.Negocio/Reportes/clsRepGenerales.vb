Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsRepGenerales
  
    Public Function Lista_Datos_Resumen_Mensual_Emb_Facturados(ByVal obeServicioConsulta As beServicioConsulta) As DataTable
        Dim odaRepGenerales As New Datos.clsRepGenerales
        Dim odtDatos As New DataTable
        odtDatos = odaRepGenerales.Lista_Datos_Resumen_Mensual_Emb_Facturados(obeServicioConsulta)
        Return odtDatos
    End Function
    ''' <summary>
    ''' Reporte de PreEmbarque Embarque
    ''' </summary>
    ''' <param name="PNCCLNT"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Lista_Datos_PreEmbarque_Embarque(ByVal PNCCLNT As Decimal) As DataSet
        Dim odaRepGenerales As New Datos.clsRepGenerales
        Return odaRepGenerales.Lista_Datos_PreEmbarque_Embarque(PNCCLNT)
    End Function





End Class
