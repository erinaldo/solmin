Imports RANSA.TypeDef
Imports RANSA.DATA
Imports System.Transactions
Public Class brUbicacion
    Inherits brBase(Of beUbicacion, daUbicacion)

    Public Function ListarDetalleUbicacion(ByVal ParamArray params As Object()) As DataTable
        Return oData.ListardetallePosicion(params)
    End Function
    Public Function RegistrarReubicacionMercaderia(ByVal obeUbicacion As beUbicacion) As beUbicacion

        Return oData.RegistrarReubicacionMercaderia(obeUbicacion)
    End Function

    Public Function ListarPosiciones(ByVal obeUbicacion As beUbicacion) As List(Of beUbicacion)
        Return oData.ListarPosiciones(obeUbicacion)
    End Function

    Public Function Listar_ubicacion_Almacen_Zona(ByVal obeUbicacion As beUbicacion) As DataTable
        Return oData.Listar_ubicacion_Almacen_Zona(obeUbicacion)
    End Function
    Public Function Registrar_ubicacion_Almacen_Zona_Masivo(ByVal obeUbicacion As beUbicacion) As String
        Return oData.Registrar_ubicacion_Almacen_Zona_Masivo(obeUbicacion)
    End Function

End Class
