Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class brTransportista
    Dim oDatos As New daTransportista

#Region "Mantenimiento DS"

    Public Function InsertarTransportista(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.InsertarTransportistaDS(obeTransportista)
    End Function
    Public Function ActualizarTransportista(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.ActualizarTransportistaDS(obeTransportista)
    End Function
    Public Function ListarTransportista(ByVal obeFiltroTransportista As beFiltroTransportista) As List(Of beTransportista)
        Return oDatos.ListarTransportistaDS(obeFiltroTransportista)
    End Function
    Public Function EliminarTransportista(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.EliminarTransportistaDS(obeTransportista)
    End Function

    Public Function flstListarTodosTransportistaDS() As List(Of beTransportista)
        Return oDatos.flstListarTodosTransportistaDS()

    End Function

     
#End Region

#Region "Mantenimiento AT"

    Public Function InsertarTransportistaAt(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.InsertarTransportistaAT(obeTransportista)
    End Function
    Public Function ActualizarTransportistaAT(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.ActualizarTransportistaAT(obeTransportista)
    End Function
    Public Function ListarTransportistaAT(ByVal obeTransportista As beTransportista) As List(Of beTransportista)
        Return oDatos.ListarTransportistaAT(obeTransportista)
    End Function
    Public Function EliminarTransportistaAT(ByVal obeTransportista As beTransportista) As Integer
        Return oDatos.EliminarTransportistaAT(obeTransportista)
    End Function
#End Region


End Class