Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class brLote
    Inherits brBase(Of TYPEDEF.beLote, DATA.daLote)
    Private objDALote As New DATA.daLote

    Public Function ListarLotesPorCliente(ByVal obeLote As beLote) As DataTable
        Return objDALote.ListarLotesPorCliente(obeLote)
    End Function

    Public Function ListarLotesPorOS(ByVal obeLote As beLote) As DataTable
        Return objDALote.ListarLotesPorOS(obeLote)
    End Function
 
    Public Function ListarUbicacionesPorLoteCLiente(ByVal obeLote As beLote) As List(Of BeUbicacionesLotes)
        Return objDALote.ListarUbicacionesPorLoteCLiente(obeLote)
    End Function
 
    Public Function InsertarActualizarLotes(ByVal obeLote As beLote) As Boolean
        Return objDALote.InsertarActualizarLotes(obeLote)
    End Function

    Public Function AnularLotes(ByVal obeLote As beLote) As Boolean
        Return objDALote.AnularLotes(obeLote)
    End Function
 
    Public Function InsertarUbicacionLotes(ByVal obeLote As BeUbicacionesLotes) As Boolean
        Return objDALote.InsertarUbicacionLotes(obeLote)
    End Function

    Public Function AnularUbicacionLotes(ByVal obeLote As BeUbicacionesLotes) As Boolean
        Return objDALote.AnularUbicacionLotes(obeLote)
    End Function

    Public Function ListaDeLotesPorOC(ByVal obeLote As beLote) As DataTable
        Return objDALote.ListaDeLotesPorOC(obeLote)
    End Function

    Public Function RegistrarDespachoLote(ByVal lista As List(Of beLote)) As Boolean
        Return objDALote.RegistrarDespachoLote(lista)
    End Function

    Public Function RegistrarRecepcionLote(ByVal obeLote As beLote) As Boolean
        Return objDALote.RegistrarRecepcionLote(obeLote)
    End Function

    Public Function ValidarExistenciaCriterioLote(ByVal obeLote As beLote) As Integer
        Return objDALote.ValidarExistenciaCriterioLote(obeLote)
    End Function
End Class
