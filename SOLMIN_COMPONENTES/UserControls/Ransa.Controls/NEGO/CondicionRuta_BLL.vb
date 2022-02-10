Imports System.Data

Public Class CondicionRuta_BLL

    Private objDatos As New CondicionRuta_DAL

    Public Function Listar_Condicion_Ruta_Combo() As DataTable
        Return objDatos.Listar_Condicion_Ruta_Combo
    End Function

End Class
