Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class brLoteDeMercaderia
    Dim oDatos As New daLoteDeMercaderia
    Public Function InsertarLoteMercaderia(ByVal obeListaLote As List(Of beLoteDeMercaderia)) As beLoteDeMercaderia
        Dim obeLote As New beLoteDeMercaderia()
        Dim odaLoteDeMercaderia As New daLoteDeMercaderia()
        Try
            For Each oLote As beLoteDeMercaderia In obeListaLote
                obeLote = odaLoteDeMercaderia.InsertarLoteMercaderia(oLote)
            Next
        Catch ex As Exception
        End Try
        Return obeLote
    End Function
    Public Function ListarLoteMercaderia_x_OrdenServicio(ByVal obeLoteFiltro As beLoteDeMercaderiaFiltro) As List(Of beLoteDeMercaderia)
        Return New daLoteDeMercaderia().ListarLoteMercaderia_x_OrdenServicio(obeLoteFiltro)
    End Function
End Class