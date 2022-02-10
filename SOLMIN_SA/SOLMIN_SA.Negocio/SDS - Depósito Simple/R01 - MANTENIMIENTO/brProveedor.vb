Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brProveedor
    Inherits brBase(Of beProveedor, daProveedor)

    Public Function GrabarProveedorDeCliente(ByVal obeProveedor As beProveedor) As Integer
        Return New daProveedor().GrabarProveedorDeCliente(obeProveedor)
    End Function

    Public Function GrabarProveedorDeCliente_v2(ByVal obeProveedor As beProveedor) As Integer
        Return New daProveedor().GrabarProveedorDeCliente_v2(obeProveedor)
    End Function

    Public Function flistTipoClienteTercero(ByVal obeProveedor As TYPEDEF.beProveedor) As List(Of TYPEDEF.beProveedor)
        Return New daProveedor().flistTipoClienteTercero(obeProveedor)
    End Function

End Class
