Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class brZonaAlmacen
    Dim odaZonaAlmacen As New daZonaAlmacen
    Public Function listar_Zona_Almacen(ByVal obeZonaAlmacen As beZonaAlmacen) As List(Of beZonaAlmacen)
        Return odaZonaAlmacen.listar_Zona_Almacen(obeZonaAlmacen)
    End Function
    Public Function mantenimiento_zona_almacem(ByVal obeZonaAlmacen As beZonaAlmacen, ByVal tipo As Integer) As Short
        Return odaZonaAlmacen.mantenimiento_zona_almacem(obeZonaAlmacen, tipo)
    End Function
End Class
