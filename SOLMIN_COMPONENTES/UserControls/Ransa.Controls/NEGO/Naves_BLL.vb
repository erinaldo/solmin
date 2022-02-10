Imports System.Data

Public Class Naves_BLL

    Private objDatos As New Naves_DAL

    Public Function Listar_Naves() As DataTable
        Return objDatos.Listar_Naves
    End Function

End Class
