Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Public Class PreAsignacionUnidades_BLL

  Dim oPreAsignacioUnidades_DAL As PreAsignacioUnidades_DAL
  Dim lstPreAsignacionUnidades_BE As List(Of PreAsignacionUnidades_BE)

  Function Registrar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Registrar_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
  End Function


  Function Buscar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE, ByRef NumPaginas As Int64) As List(Of PreAsignacionUnidades_BE)
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Buscar_PreAsignacionUnidades(oPreAsignacionUnidades_BE, NumPaginas)
  End Function

  Function Ver_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As List(Of PreAsignacionUnidades_BE)
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Ver_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
  End Function

  Function Exportar_PreAsignacionUnidades() As List(Of PreAsignacionUnidades_BE)
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Exportar_PreAsignacionUnidades()
  End Function


  Function Modificar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Modificar_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
  End Function

  Function Asignar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Asignar_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
  End Function

  Function Eliminar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
    oPreAsignacioUnidades_DAL = New PreAsignacioUnidades_DAL
    Return oPreAsignacioUnidades_DAL.Eliminar_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
  End Function

End Class
