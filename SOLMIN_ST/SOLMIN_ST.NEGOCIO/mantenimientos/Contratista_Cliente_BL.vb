Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Namespace mantenimientos
  Public Class Contratista_Cliente_BL

    Public Function Insertar_Contratista_Cliente(ByVal obeContratista_Cliente As Contratista_Cliente) As Integer
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.Insertar_Contratista_Cliente(obeContratista_Cliente)
    End Function

    Public Function Actualizar_Contratista_Cliente(ByVal obeContratista_Cliente As Contratista_Cliente) As Integer
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.Actualizar_Contratista_Cliente(obeContratista_Cliente)
    End Function

    Public Function ListarContratistaFiltro(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.ListarContratistaFiltro(obe_Contratista_Cliente)
    End Function
    Public Function Listar_Contratista_Cliente(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.Listar_Contratista_Cliente(obe_Contratista_Cliente)
    End Function

    Public Function Eliminar_Contratista_Cliente(ByVal obeContratista_Cliente As Contratista_Cliente) As Integer
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.Eliminar_Contratista_Cliente(obeContratista_Cliente)
    End Function

    Public Function Listar_Contratista_Cliente_Pasajero(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
      Dim odaContratista_Cliente_DAL As New Contratista_Cliente_DAL
      Return odaContratista_Cliente_DAL.Listar_Contratista_Cliente_Pasajero(obe_Contratista_Cliente)
    End Function

  End Class

End Namespace