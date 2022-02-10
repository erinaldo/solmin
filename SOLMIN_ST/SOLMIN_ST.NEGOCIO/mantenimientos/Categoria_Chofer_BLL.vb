Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES

Public Class Categoria_Chofer_BLL
    Private objDatos As New CategoriaChofer_DAL

    Public Function Listar_Categoria_Chofer() As List(Of CategoriaChofer)
        Try
            Return objDatos.Listar_Categoria_Chofer()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


End Class

