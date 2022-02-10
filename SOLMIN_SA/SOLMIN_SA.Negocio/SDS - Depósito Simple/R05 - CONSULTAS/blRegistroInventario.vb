Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class blRegistroInventario
    Public Function ListarCabeceraERI(ByVal objbeCabeceraERI As beCabeceraERI) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListarCabeceraERI(objbeCabeceraERI)
        Return oDs
    End Function

    Public Function ListarDetalleERI(ByVal objbeInventarioDetallERI As beInventarioDetallERI) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListarDetalleERI(objbeInventarioDetallERI)
        Return oDs
    End Function

    Public Function ListaInventarioXFecha(ByVal objbeInventarioxFecha As beInventarioxFecha) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListaInventarioXFecha(objbeInventarioxFecha)
        Return oDs
    End Function

    Public Function ListaInventarioExportXFecha(ByVal objbeInventarioExcel As beInventarioExcel) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListaInventarioExportXFecha(objbeInventarioExcel)
        Return oDs
    End Function

    Public Function GenerarCabeceraERI(ByVal objbeCabEri As beCabERI, ByVal lstbeDetEri As List(Of beDetERI)) As String
        Try
            Dim oDs As DataSet
            Dim odaRegistroInventario As New daRegistroIventario
            Dim PNNROERI As String
            oDs = odaRegistroInventario.GenerarCabeceraERI(objbeCabEri)
            If Not IsNothing(oDs) Then
                If Not IsNothing(oDs.Tables(0)) Then
                    If Not IsNothing(oDs.Tables(0).Rows(0)("PNNROERI")) Then
                        PNNROERI = oDs.Tables(0).Rows(0)("PNNROERI")
                        For Each item As beDetERI In lstbeDetEri
                            item.PNNROERI = PNNROERI
                            odaRegistroInventario.GenerarDetalleERI(item)
                        Next
                    End If
                End If
            End If
            Return PNNROERI
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function ActualizaEstadoCabERI(ByVal objbeActualizaEstadoCabEri As beActualizaEstadoCabERI, ByVal lstbeActualizaStockFisicoEri As List(Of beActualizaStockFisicoERI)) As Integer
        Dim intRetorno As Integer
        Dim odaRegistroInventario As New daRegistroIventario
        intRetorno = odaRegistroInventario.ActualizaEstadoCabERI(objbeActualizaEstadoCabEri)
        For Each objbeActualizaStock As beActualizaStockFisicoERI In lstbeActualizaStockFisicoEri
            odaRegistroInventario.ActualizaStockFisicoERI(objbeActualizaStock)
        Next
        Return intRetorno
    End Function

    Public Function ActualizaEstadoCabERI(ByVal objbeActualizaEstadoCabEri As beActualizaEstadoCabERI) As Integer
        Dim intRetorno As Integer
        Dim odaRegistroInventario As New daRegistroIventario
        intRetorno = odaRegistroInventario.ActualizaEstadoCabERI(objbeActualizaEstadoCabEri)
        Return intRetorno
    End Function

    Public Function ListarProductosxRegularizar(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Try
            Dim oDs As New DataSet
            Dim odaRegistroInventario As New daRegistroIventario
            oDs = odaRegistroInventario.ListarProductosxRegularizar(objbeProductoxRegularizar)
            Return oDs
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ListarDisponibilidadInventario(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListarDisponibilidadInventario(objbeProductoxRegularizar)
        oDs.Tables(0).Columns.Add("DISINVEN", Type.GetType("System.Decimal"))
        Dim decInmobilizado As Decimal = 0
        Dim decCantDisponible As Decimal = 0
        Dim decDispoInventario As Decimal = 0
        For Each item As DataRow In oDs.Tables(0).Rows
            If item.Item("QSLMC_N").ToString() <> Nothing And item.Item("QSLMC_N").ToString() <> String.Empty Then
                decInmobilizado = item.Item("QSLMC_N")
            End If
            If item.Item("QSLMC_S").ToString() <> Nothing And item.Item("QSLMC_S").ToString() <> String.Empty Then
                decCantDisponible = item.Item("QSLMC_S")
            End If
            If decCantDisponible = 0 Then
                decDispoInventario = 0
            Else
                decDispoInventario = decInmobilizado / decCantDisponible
            End If
            If decDispoInventario = 0 Then
                item.Item("DISINVEN") = 0.0
            Else
                item.Item("DISINVEN") = decDispoInventario
            End If
        Next
        Return oDs
    End Function

    Public Function ListarOcupabilidadAlmacen(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.ListarOcupabilidadAlmacen(objbeProductoxRegularizar)
        oDs.Tables(0).Columns.Add("DISINVEN", Type.GetType("System.Decimal"))
        Dim decUbicacionesOcupadas As Decimal = 0.0
        Dim decUbicaciones As Decimal = 0.0
        Dim decOcupabilidad As Decimal = 0.0
        For Each item As DataRow In oDs.Tables(0).Rows
            If item.Item("UBICACIONES_O").ToString() <> Nothing And item.Item("UBICACIONES_O").ToString() <> String.Empty Then
                decUbicacionesOcupadas = item.Item("UBICACIONES_O")
            End If
            If item.Item("UBICACIONES").ToString() <> Nothing And item.Item("UBICACIONES").ToString() <> String.Empty Then
                decUbicaciones = item.Item("UBICACIONES")
            End If
            If decUbicaciones = 0 Then
                decOcupabilidad = 0.0
            Else
                decOcupabilidad = decUbicacionesOcupadas / decUbicaciones
            End If
            If decOcupabilidad = 0 Then
                item.Item("DISINVEN") = 0.0
            Else
                item.Item("DISINVEN") = decOcupabilidad
            End If
        Next
        Return oDs
    End Function

    Public Function EficienciadeRecepcionDespacho(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim odaRegistroInventario As New daRegistroIventario
        oDs = odaRegistroInventario.EficienciadeRecepcionDespacho(objbeProductoxRegularizar)
        Return oDs
    End Function

End Class
