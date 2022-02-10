Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class brContenedor
    Dim oDatos As New daContenedor


#Region "mantenimiento de Contenedor"
    Public Function InsertarContenedor(ByVal obeContenedor As beContenedor) As Integer
        Return oDatos.InsertarContenedor(obeContenedor)
    End Function
    Public Function ActualizarContenedor(ByVal obeContenedor As beContenedor) As Integer
        Return oDatos.ActualizarContenedor(obeContenedor)
    End Function
    Public Function ListarContenedor(ByVal obeContenedor As beContenedor) As List(Of beContenedor)
        Return oDatos.ListarContenedor(obeContenedor)
    End Function

    Public Function dtListarContenedor(ByVal obeContenedor As beContenedor) As DataTable
        Return oDatos.dtListarContenedor(obeContenedor)
    End Function
#End Region
#Region "Datos Adcionales de Contenedor"
    Public Function dtListaColorContenedor() As DataTable
        Return oDatos.dtListaColorContenedor()
    End Function

    Public Function dtListaMaterialContenedor() As DataTable
        Return oDatos.dtListaMaterialContenedor()
    End Function

    Public Function dtListaTipoContenedor() As DataTable
        Return oDatos.dtListaTipoContenedor()
    End Function
    Public Function ValidaMovimiento(ByVal obeContenedor As beContenedor) As Integer
        Return oDatos.ValidaMovimiento(obeContenedor)
    End Function

    Public Function dtListaReporteContenedores(ByVal obeContenedor As beContenedor) As DataSet
        Return oDatos.dtListaReporteContenedores(obeContenedor)
    End Function
#End Region
End Class