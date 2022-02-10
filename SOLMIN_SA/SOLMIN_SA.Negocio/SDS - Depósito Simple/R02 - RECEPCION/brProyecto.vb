Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brProyecto
    Dim objDAProyecto As New daProyecto

    Public Function fIntInsertarProyectoOcRegularizacion(ByVal obeProyecto As beProyecto) As Integer
        Return objDAProyecto.fIntInsertarProyectoOcRegularizacion(obeProyecto)
    End Function

    Public Function ListaProyectos(ByVal obeProyectoFiltro As beProyecto) As beList(Of beProyecto)
        Return objDAProyecto.ListaProyectos(obeProyectoFiltro)
    End Function

    Public Function ListaProyectosPorMovimiento(ByVal obeProyectoFiltro As beProyecto) As beList(Of beProyecto)
        Return objDAProyecto.ListaProyectosPorMovimiento(obeProyectoFiltro)
    End Function


    Public Function flistProyectosXOs(ByVal obeProyecto As beProyecto) As beList(Of beProyecto)
        Return objDAProyecto.flistProyectosXOs(obeProyecto)
    End Function

    Public Function fintEliminarProyecto(ByVal obeProyectoFiltro As beProyecto) As Integer
        Return objDAProyecto.fintEliminarProyecto(obeProyectoFiltro)
    End Function

    Public Function fintIngresarProyecto(ByVal obeProyecto As beProyecto) As Integer
        Return objDAProyecto.fintIngresarProyecto(obeProyecto)
    End Function

    Public Function fintSalidaProyecto(ByVal obeProyecto As beProyecto) As Integer
        Return objDAProyecto.fintSalidaProyecto(obeProyecto)
    End Function

    Public Function fintAnularIngresoProyecto(ByVal obeProyecto As beProyecto) As Integer
        Return objDAProyecto.fintAnularIngresoProyecto(obeProyecto)
    End Function

    Public Function fintAnularSalidaProyecto(ByVal obeProyecto As beProyecto) As Integer
        Return objDAProyecto.fintAnularSalidaProyecto(obeProyecto)
    End Function
End Class
