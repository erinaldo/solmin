Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Namespace mantenimientos

  Public Class Personal_Contratista_BL

    Public Function ListarTipoDocumento(ByVal strCompañia As String) As DataTable
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.ListarTipoDocumento(strCompañia)
    End Function

    Public Function ListarGradoAcademico(ByVal strCompañia As String) As DataTable
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.ListarGradoAcademico(strCompañia)
    End Function

    Public Function Insertar_Personal_Contratista(ByVal obePersonal_Contratista As Personal_Contratista) As Integer
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.Insertar_Personal_Contratista(obePersonal_Contratista)
    End Function

    Public Function Actualizar_Personal_Contratista(ByVal obePersonal_Contratista As Personal_Contratista) As Integer
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.Actualizar_Personal_Contratista(obePersonal_Contratista)
    End Function

    Public Function Listar_Personal_Contratista(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.Listar_Personal_Contratista(obe_Personal_Contratista)
    End Function

    Public Function ListarPersonalFiltro(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.ListarPersonalFiltro(obe_Personal_Contratista)
    End Function

    Public Function Eliminar_Personal_Contratista(ByVal obePersonal_Contratista As Personal_Contratista) As Integer
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
      Return odaPersonal_Contratista_DAL.Eliminar_Personal_Contratista(obePersonal_Contratista)
    End Function

    Public Function RptListar_Contratista_Personal(ByVal obe_Personal_Contratista As Personal_Contratista) As DataTable
            Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
            Dim dtTable As DataTable = odaPersonal_Contratista_DAL.RptListar_Contratista_Personal(obe_Personal_Contratista)
            For Indice As Integer = 0 To dtTable.Rows.Count - 1
                dtTable.Rows(Indice).Item("FNCMTO") = Utility.CFecha_de_8_a_10(dtTable.Rows(Indice).Item("FNCMTO").ToString)
                dtTable.Rows(Indice).Item("FINGEM") = Utility.CFecha_de_8_a_10(dtTable.Rows(Indice).Item("FINGEM").ToString)
            Next
            Return dtTable
    End Function

    Public Function Listar_Personal_Contratista_Cliente(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
      Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
            Return odaPersonal_Contratista_DAL.Listar_Personal_Contratista_Cliente(obe_Personal_Contratista)

    End Function
        Public Function Listar_Historial_Rutas_Pasajero(ByVal objEntidad As Personal_Contratista) As DataTable
            Dim odaPersonal_Contratista_DAL As New Personal_Contratista_DAL
            Return odaPersonal_Contratista_DAL.Listar_Historial_Rutas_Pasajero(objEntidad)
        End Function
  End Class

End Namespace