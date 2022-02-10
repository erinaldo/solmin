

    Public Class CentroCosto_BLL
        Private objDataAccessLayer As New CentroCosto_DAL

        Public Function Listar_Centro_Costo(ByVal objEntidad As CentroCosto) As List(Of CentroCosto)
            Try
                Return objDataAccessLayer.Listar_Centro_Costo(objEntidad)
            Catch ex As Exception
                Return New List(Of CentroCosto)
            End Try
        End Function

        Public Function Listar_RegionVenta(ByVal objEntidad As CentroCosto) As List(Of CentroCosto)
            Try
                Return objDataAccessLayer.Listar_RegionVenta(objEntidad)
            Catch ex As Exception
                Return New List(Of CentroCosto)
            End Try
        End Function
    End Class

