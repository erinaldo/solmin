Imports RANSA.TypeDef
Imports RANSA.DATA
''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class brDespacho

    Dim oDatos As New daDespacho


    Public Function fdtListaStockMercaderiasPorAlmacen(ByVal intOrdenServicio As Int64) As DataTable

        Return oDatos.fdtListarStockMercaderiasPorAlmacen(intOrdenServicio)

    End Function


    Public Function ListarDespachoPorPedido(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListarDespachoPorPedido(opbeDespacho)
    End Function

    Public Function ListaPedidoPendientePorCliente(ByVal opbeDespacho As beDespacho) As List(Of bePedidoPorPlanta)
        Return oDatos.ListaPedidoPendientePorCliente(opbeDespacho)
    End Function

    Public Function ListaDespachoMercaderiaPorClientePorPlanta(ByVal opbeDespacho As bePedidoPorPlanta) As List(Of bePedidoPorPlanta)
        Return oDatos.ListaDespachoMercaderiaPorClientePorPlanta(opbeDespacho)
    End Function

    Public Function ListaDespachoMercaderiaPorClientePorPlanta_V2(ByVal opbeDespacho As bePedidoPorPlanta) As List(Of bePedidoPorPlanta)
        Return oDatos.ListaDespachoMercaderiaPorClientePorPlanta_V2(opbeDespacho)
    End Function



    Public Function AnularDespachoMercaderiaPorClientePorPlanta(ByVal pobeDespacho As bePedidoPorPlanta) As Integer
        Return oDatos.AnularDespachoMercaderiaPorClientePorPlanta(pobeDespacho)
    End Function

    Public Function GuardarPedidoPlanta(ByVal polbePedidoPlanta As List(Of bePedidoPorPlanta)) As Double
        Return oDatos.GuardarPedidoPlanta(polbePedidoPlanta)
    End Function

    Public Function AnularPedidoMercaderiaPorClientePorPlanta(ByVal polbePedidoPlanta As bePedidoPorPlanta) As Double
        Return oDatos.AnularPedidoMercaderiaPorClientePorPlanta(polbePedidoPlanta)
    End Function

    Public Function flistListaExportarGuiaManualOutotec(ByVal obeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.flistListaExportarGuiaManualOutotec(obeDespacho)
    End Function

    Public Function ListaParaExportarABB(ByVal polbebeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaParaExportarABB(polbebeDespacho)
    End Function

    Public Function flistListaExportarGuiaOutotec(ByVal pbeFiltro As beDespacho) As List(Of beDespacho)
        Return oDatos.flistListaExportarGuiaOutotec(pbeFiltro)
    End Function

    Public Function ListaSerieExportarABB(ByVal pobeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaSerieExportarABB(pobeDespacho)
    End Function

    Public Function ListaPedidoPendienteEntrega_x_Cliente(ByVal pobeDespacho As beDespacho) As DataSet
        Return oDatos.ListaPedidoPendienteEntrega_x_Cliente(pobeDespacho)
    End Function

    Public Function RestaurarGuiaDeRemisionDSD(ByVal pobeDespacho As beDespacho) As Integer
        Return oDatos.RestaurarGuiaDeRemisionDSD(pobeDespacho)
    End Function

    Public Function AnularGuiaDeRemisionDSD(ByVal pobeDespacho As beDespacho) As Integer
        Return oDatos.AnularGuiaDeRemisionDSD(pobeDespacho)
    End Function

    Public Function AnularGuiaDeSalida(ByVal opbeDespacho As beDespacho) As Integer
        Return oDatos.AnularGuiaDeSalida(opbeDespacho)
    End Function

    Public Function AnularGuiaDeIngreso(ByVal opbeDespacho As beDespacho) As Integer
        Return oDatos.AnularGuiaDeIngreso(opbeDespacho)
    End Function

    Public Function ListaMovimientosPorGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaMovimientosPorGuiaRansa(opbeDespacho)
    End Function


    Public Function flstListaItemsXGuiaRansaDespacho(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.flstListaItemsXGuiaRansaDespacho(opbeDespacho)
    End Function


    Public Function AnularMovimientoGuiaIngreso(ByVal opbeDespacho As beDespacho) As Integer
        Return oDatos.AnularMovimientoGuiaIngreso(opbeDespacho)
    End Function


    Public Function AnularMovimientoGuiaSalida(ByVal opbeDespacho As beDespacho) As Integer
        Return oDatos.AnularMovimientoGuiaSalida(opbeDespacho)
    End Function

    Public Function intRevertirMovimientoGuiaIngreso(ByVal opbeDespacho As beDespacho, ByVal olbeKardex As List(Of beMercaderia), ByVal olbeUbicacion As List(Of beMercaderia), ByVal olbeSerie As List(Of beMercaderia), ByVal olbeProyecto As List(Of beProyecto), ByVal olbelote As List(Of beMercaderia), ByVal strError As String) As Integer
        Dim intResultado As Integer = -1
        Dim obrProyecto As New brProyecto
        intResultado = oDatos.intRevertirMovimientoGuiaIngreso(opbeDespacho)
        If intResultado = -1 Then
            strError = "Error al revertir el ingreso"
            Return intResultado
        End If

        'Proyecto
        For Each obeProyecto As beProyecto In olbeProyecto
            obeProyecto.PSSTPING = opbeDespacho.PSSTPING
            obeProyecto.PSNORCML = opbeDespacho.PSNORCML.Trim
            obeProyecto.PNNRITOC = opbeDespacho.PNNRITOC
            obeProyecto.PNQCNTIT2 = obeProyecto.PNQTRMC - obeProyecto.PNQCNTIT2
            intResultado = obrProyecto.fintAnularIngresoProyecto(obeProyecto)
            If intResultado = -1 Then
                strError = "Error al anular el ingreso proyecto"
                Return intResultado
            End If
        Next

        'Kardex
        For Each obeMercaderia As beMercaderia In olbeKardex
            obeMercaderia.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeMercaderia.PSNTRMNL = opbeDespacho.PSNTRMNL
            obeMercaderia.PNNORDSR = opbeDespacho.PNNORDSR
            obeMercaderia.PNNSLCSR = opbeDespacho.PNNSLCSR
            intResultado = oDatos.intRevertirMovimientoGuiaIngresoKardex(obeMercaderia)
            If intResultado = -1 Then
                strError = "Error al revertir ingreso  Kardex"
                Return intResultado
            End If
        Next
        'Serie
        For Each obeSerie As beMercaderia In olbeSerie
            If obeSerie.CHK = False Then
                obeSerie.PNNORDSR = opbeDespacho.PNNORDSR
                intResultado = oDatos.intRevertirMovimientoGuiaIngresoSeriesIng(obeSerie)
                If intResultado = -1 Then
                    strError = "Error al revertir ingreso Serie"
                    Return intResultado
                End If
            End If
        Next

        'Ubicación
        For Each obeUbicacion As beMercaderia In olbeUbicacion
            obeUbicacion.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeUbicacion.PSNTRMNL = opbeDespacho.PSNTRMNL

            intResultado = oDatos.intRevertirMovimientoGuiaIngresoUbicacion(obeUbicacion)
            If intResultado = -1 Then
                strError = "Error al revertir ingreso ubicación"
                Return intResultado
            End If

        Next

        'Lote
        For Each obeLote As beMercaderia In olbelote
            obeLote.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeLote.PSNTRMNL = opbeDespacho.PSNTRMNL

            intResultado = oDatos.intRevertirMovimientoGuiaIngresoLote(obeLote)
            If intResultado = -1 Then
                strError = "Error al revertir ingreso lote"
                Return intResultado
            End If

        Next


        Return intResultado
    End Function




    Public Function intRevertirMovimientoGuiaSalida(ByVal opbeDespacho As beDespacho, ByVal olbeKardex As List(Of beMercaderia), ByVal olbeUbicacion As List(Of beMercaderia), ByVal olbeSerie As List(Of beMercaderia), ByVal olbeProyecto As List(Of beProyecto), ByVal olbelote As List(Of beMercaderia), ByVal strError As String) As Integer
        Dim intResultado As Integer = -1
        Dim obrProyecto As New brProyecto
        intResultado = oDatos.intRevertirMovimientoGuiaSalida(opbeDespacho)
        If intResultado = -1 Then
            strError = "Error al revertir el ingreso"
            Return intResultado
        End If

        Dim key As New KeyValuePair(Of Int64, Int64)(opbeDespacho.PNNORDSR, opbeDespacho.PNNSLCSR)
        For Each obeProyecto As beProyecto In olbeProyecto
            obeProyecto.PSNORCML = opbeDespacho.PSNORCML.Trim
            obeProyecto.PNNRITOC = opbeDespacho.PNNRITOC
            obeProyecto.PNQCNTIT2 = obeProyecto.PNQTRMC - obeProyecto.PNQCNTIT2
            obrProyecto.fintAnularSalidaProyecto(obeProyecto)
            If intResultado = -1 Then
                strError = "Error al revertir Salida ubicación"
                Return intResultado
            End If
        Next

        'Kardex
        For Each obeMercaderia As beMercaderia In olbeKardex
            obeMercaderia.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeMercaderia.PSNTRMNL = opbeDespacho.PSNTRMNL
            obeMercaderia.PNNORDSR = opbeDespacho.PNNORDSR
            obeMercaderia.PNNSLCSR = opbeDespacho.PNNSLCSR
            intResultado = oDatos.intRevertirMovimientoGuiaSalidaKardex(obeMercaderia)
            If intResultado = -1 Then
                strError = "Error al revertir Salida  Kardex"
                Return intResultado
            End If
        Next
        'Serie
        For Each obeSerie As beMercaderia In olbeSerie
            If obeSerie.CHK = False Then
                obeSerie.PNNORDSR = opbeDespacho.PNNORDSR
                obeSerie.PSUSUARIO = opbeDespacho.PSUSUARIO
                intResultado = oDatos.intRevertirMovimientoGuiaIngresoSeriesIng(obeSerie)
                If intResultado = -1 Then
                    strError = "Error al revertir Salida Serie"
                    Return intResultado
                End If
            End If
        Next

        'Ubicación
        For Each obeUbicacion As beMercaderia In olbeUbicacion
            obeUbicacion.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeUbicacion.PSNTRMNL = opbeDespacho.PSNTRMNL

            intResultado = oDatos.intRevertirMovimientoGuiaSalidaUbicacion(obeUbicacion)
            If intResultado = -1 Then
                strError = "Error al revertir ingreso ubicación"
                Return intResultado
            End If

        Next

        'Lote
        For Each obeLote As beMercaderia In olbelote
            obeLote.PSUSUARIO = opbeDespacho.PSUSUARIO
            obeLote.PSNTRMNL = opbeDespacho.PSNTRMNL

            intResultado = oDatos.intRevertirMovimientoGuiaSalidaLote(obeLote)
            If intResultado = -1 Then
                strError = "Error al revertir ingreso lote"
                Return intResultado
            End If

        Next

        Return intResultado



    End Function


    Public Function ListaGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaGuiaRansa(opbeDespacho)
    End Function

    Public Function ListaGuiaRansaDesp(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaGuiaRansaDesp(opbeDespacho)
    End Function

    Public Function fdtReporteGuiaRansa(ByVal opbeDespacho As beDespacho) As DataTable
        Return oDatos.fdtReporteGuiaRansa(opbeDespacho)
    End Function

    Public Function ListaGuiaRemisionDesp(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaGuiaRemisionDesp(opbeDespacho)
    End Function

    Public Function ListaDetalleGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.ListaDetalleGuiaRansa(opbeDespacho)
    End Function

    Public Function fdtListaParaExportarABBRecepcion(ByVal opbeDespacho As beDespacho) As DataTable
        Return oDatos.fdtListaParaExportarABBRecepcion(opbeDespacho)
    End Function
    Public Function fdtListaParaExportarOutotecDespacho(ByVal obeDespacho As beDespacho) As DataSet
        Return oDatos.fdtListaParaExportarOutotecDespacho(obeDespacho)
    End Function

    Public Function fintRegistrarEnvioInterfaz(ByVal obeDespacho As beDespacho) As Integer
        Return oDatos.fintRegistrarEnvioInterfaz(obeDespacho)
    End Function

    Public Function flistaMercaderiImprimirCodigoBarra(ByVal obeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.flistaMercaderiImprimirCodigoBarra(obeDespacho)
    End Function

    Public Function olistGuiaRansaXNroParte(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Return oDatos.olistGuiaRansaXNroParte(opbeDespacho)
    End Function

    Public Function fdtOntenerInformacionDespachoInterfazSAP(ByVal objDatos As beInferfazSapPedido, ByRef msgError As String) As DataSet
        Return oDatos.fdtOntenerInformacionDespachoInterfazSAP(objDatos, msgError)
    End Function

    Public Function strObtenerCodigoRegionVenta(ByVal objDatos As beInferfazSapPedido) As String
        Return oDatos.strObtenerCodigoRegionVenta(objDatos)
    End Function

    Public Function fdtOntenerInformacionPedidoInterfazSAP(ByVal objDatos As beInferfazSapPedido, ByRef msgError As String) As DataSet
        Return oDatos.fdtOntenerInformacionPedidoInterfazSAP(objDatos, msgError)
    End Function

    Public Sub ActualizarEstadoTransmisionDocumentoSapInterfaz(ByVal objDatos As beInferfazSapPedido)
        oDatos.ActualizarEstadoTransmisionDocumentoSapInterfaz(objDatos)
    End Sub

    Public Function fdtListaPedidoTraslado(ByVal pobePedido As beDespacho) As DataTable
        Return oDatos.fdtListaPedidoTraslado(pobePedido)
    End Function

    Public Function fdtListaDetallePedidoTraslado(ByVal pobePedido As beDespacho) As DataTable
        Return oDatos.fdtListaDetallePedidoTraslado(pobePedido)
    End Function
    Public Function fdtListaDetallePedidoTrasladoAtender(ByVal pobePedido As beDespacho) As DataTable
        Return oDatos.fdtListaDetallePedidoTrasladoAtender(pobePedido)
    End Function
End Class