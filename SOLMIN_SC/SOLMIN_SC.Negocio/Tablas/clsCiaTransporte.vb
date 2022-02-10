Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad

Public Class clsCiaTransporte

  Dim objDatos As New Datos.clsCiaTransporte

  Public Function Lista_Cia_Transporte(ByVal oCiaTransporte As beCiaTransporte) As DataTable
    Dim odaCiaTransporte As New Datos.clsCiaTransporte()
    Dim odtCiaTransporte As New DataTable
    odtCiaTransporte = odaCiaTransporte.Lista_Cia_Transporte(oCiaTransporte)
    Return odtCiaTransporte
  End Function

  Public Function Registrar_CiaTransporte(ByVal TNMCIN As String, ByVal TDIRCN As String, ByVal SMETRA As Int32, ByVal CPAIS As Int32) As Integer
    Return objDatos.Registrar_CiaTransporte(TNMCIN, TDIRCN, SMETRA, CPAIS)
  End Function

  Public Function Eliminar_CiaTransporte(ByVal CCIANV As Int32) As Integer
    Return objDatos.Eliminar_CiaTransporte(CCIANV)
  End Function

  Public Function Restablecer_CiaTransporte(ByVal CCIANV As Int32) As Integer
    Return objDatos.Restablecer_CiaTransporte(CCIANV)
  End Function

  Public Function Actualizar_CiaTransporte(ByVal CCIANV As Int32, ByVal TNMCIN As String, ByVal TDIRCN As String, ByVal SMETRA As Int32, ByVal CPAIS As Int32) As Integer
    Return objDatos.Actualizar_CiaTransporte(CCIANV, TNMCIN, TDIRCN, SMETRA, CPAIS)
    End Function

    Public Function Lista_Cia_Transporte_Todos() As List(Of beCiaTransporte)
        Return objDatos.Lista_Cia_Transporte_Todos()
    End Function
End Class
