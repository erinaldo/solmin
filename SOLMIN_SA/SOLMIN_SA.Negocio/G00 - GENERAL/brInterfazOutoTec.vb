Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brInterfazOutoTec

#Region "Recepcion "

    Public Function fintInsertarCabeceraProceso(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.fintInsertarCabeceraProceso(oParametro)
    End Function

    Public Function fintInsertarDetalleProceso(ByVal olParametro As List(Of beDetInfzOutotec)) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Dim intError As Integer = 0
        For Each oParamentro As beDetInfzOutotec In olParametro
            intError = odaInterfazOutoTec.fintInsertarDetalleProceso(oParamentro)
            If intError <> -1 And Not oParamentro.olistaProyecto Is Nothing Then
                Dim olistDetInfzProyecto As New List(Of beDetInfzOutotec)
                Dim obeDetInfzOutotec As New beDetInfzOutotec
                For Each obeProyecto As beProyecto In oParamentro.olistaProyecto
                    obeDetInfzOutotec = New beDetInfzOutotec
                    obeDetInfzOutotec.ctpdoc = oParamentro.ctpdoc
                    obeDetInfzOutotec.npensa = oParamentro.npensa
                    obeDetInfzOutotec.norden = oParamentro.norden
                    obeDetInfzOutotec.citems = oParamentro.citems
                    obeDetInfzOutotec.nordpr = obeProyecto.PSNRFRPD
                    obeDetInfzOutotec.qitems = obeProyecto.PNQCNTIT2
                    obeDetInfzOutotec.cubica = ""
                    olistDetInfzProyecto.Add(obeDetInfzOutotec)
                Next
                If fintInsertarProyectoProceso(olistDetInfzProyecto) = -1 Then
                    Return intError
                End If
           
            End If
        Next
        Return intError
    End Function

    Public Function fintInsertarProceso(ByVal obeCabInterfazOutotec As beCabInfzOutotec, ByVal olbeDetInterfazOutotec As List(Of beDetInfzOutotec)) As Integer
        Dim intResultado As Integer = 0
        Dim odaInterfazOutoTec As New daInterfazOutoTec
    
        If odaInterfazOutoTec.fintInsertarCabeceraProceso(obeCabInterfazOutotec) = -1 Then Return -1
        If fintInsertarDetalleProceso(olbeDetInterfazOutotec) = -1 Then Return -1
    End Function

    Public Function fintInsertarProyectoProceso(ByVal olParametro As List(Of beDetInfzOutotec)) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Dim intError As Integer = 0
        For Each oParamentro As beDetInfzOutotec In olParametro
            intError = odaInterfazOutoTec.fintInsertarProyectoProceso(oParamentro)
        Next
        Return intError
    End Function

    Public Function fintProveedorPerteneceAlmacen(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        If odaInterfazOutoTec.fintProveedorPerteneceAlmacen(oParametro) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function flistObtenerPedidoOutotecXItem(ByVal oParametro As beDetInfzPedidoOuototec) As DataSet
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.flistObtenerPedidoOutotecXItem(oParametro)
    End Function

#End Region


#Region "Pedidos"

    Public Function flistObtenerPedidoOutotec(ByVal oParametro As beCabInfzPedidoOuototec) As DataSet
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.flistObtenerPedidoOutotec(oParametro)
    End Function

    Public Function flistPedidosPendientesOutotec(ByVal oParametro As beCabInfzPedidoOuototec) As DataSet
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.flistPedidosPendientesOutotec(oParametro)
    End Function

    Public Function fintActualizarPedidosOutotec(ByVal oParametro As beDetInfzPedidoOuototec) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.fintActualizarPedidosOutotec(oParametro)
    End Function

#End Region

#Region "Despacho"

    Public Function fintInsertarCabeceraGuia(ByVal oParametro As beCabGuiaInfzOutotec) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.fintInsertarCabeceraGuia(oParametro)
    End Function


    Public Function fintInsertarDetalleGuia(ByVal olParametro As List(Of beDetGuiaInfzOutotec)) As Integer
        Dim intError As Integer = 0
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        For Each oParamentro As beDetGuiaInfzOutotec In olParametro
            intError = odaInterfazOutoTec.fintInsertarDetalleGuia(oParamentro)
            If intError <> -1 Then
            Else
                Return intError
            End If
        Next
        Return intError
    End Function


#End Region

    Public Function fintAnularProcesoIngDesp(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim odaInterfazOutoTec As New daInterfazOutoTec
        Return odaInterfazOutoTec.fintAnularProcesoIngDesp(oParametro)
    End Function
End Class
