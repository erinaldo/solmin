Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class DuracionDias_BLL

        Dim objDal As New DuracionDias_DAL

        Public Function Listar(objEntidad As DuracionDias) As DataTable
            Dim dtb As New Data.DataTable
            dtb = objDal.Listar(objEntidad)
            Return dtb
        End Function

        Public Function Nuevo(ByVal objEntidad As DuracionDias) As String
            Return objDal.Nuevo(objEntidad)
        End Function

        Public Sub Editar(ByVal objEntidad As DuracionDias)
            objDal.Editar(objEntidad)
        End Sub


        Public Sub Eliminar(ByVal objEntidad As DuracionDias)
            objDal.Eliminar(objEntidad)
        End Sub

        'Public Function Obtener(objEntidad As DuracionDias) As DuracionDias
        '    Return objDal.Obtener(objEntidad)
        'End Function

        'Public Function ListarDuracionDias_x_Cliente(ByVal objEntidad As DuracionDias) As List(Of DuracionDias)
        '    Return objDal.ListarDuracionDias_x_Cliente(objEntidad)
        'End Function
        Public Function ListarDuracionDias_x_Cliente(ByVal objEntidad As DuracionDias) As DataTable
            Return objDal.ListarDuracionDias_x_Cliente(objEntidad)
        End Function

    End Class

End Namespace