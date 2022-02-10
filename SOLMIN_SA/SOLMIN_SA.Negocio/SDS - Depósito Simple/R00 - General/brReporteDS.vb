Imports RANSA.TYPEDEF.Reportes
Imports RANSA.DATA

Public Class brReporteDS
    Dim odaReporteDS As New daReporteDS

    Public Function dtRepEntregaEmbAlmOC(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Return odaReporteDS.dtRepEntregaEmbAlmOC(pdblCodCli, pdblFecIni, pdblFecFin)
    End Function

    Public Function dtRepEntregaEmbAlmItem(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Return odaReporteDS.dtRepEntregaEmbAlmItem(pdblCodCli, pdblFecIni, pdblFecFin)
    End Function

    Public Function dsRepRotacionProducto(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataSet
        Return odaReporteDS.dsRepRotacionProducto(pdblCodCli, pdblFecIni, pdblFecFin)

    End Function

    Public Function dsReporteAnualRotacion(ByVal pdblCodCli As Double, ByVal anio As Double) As DataSet
        Return odaReporteDS.dsReporteAnualRotacion(pdblCodCli, anio)
    End Function
    Public Function dtRepStockPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Return odaReporteDS.dtRepStockPorFecha(obeFiltros)
    End Function

    Public Function dtRepPartesPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        Return odaReporteDS.dtRepPartesPorFecha(obeFiltros)
    End Function

    Public Function dtRepDetalleNroParte(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Return odaReporteDS.dtRepDetalleNroParte(obeFiltros)
    End Function

    Public Function fdtRepInventarioPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Return odaReporteDS.fdtRepInventarioPorFecha(obeFiltros)
    End Function

    Public Function fdtRepInventarioSDS(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Return odaReporteDS.fdtRepInventarioSDS(obeFiltros)
    End Function


    Public Function fdtRepStockProductoXUbicacion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Return odaReporteDS.fdtRepStockProductoXUbicacion(obeFiltros)
    End Function


    Public Shared Function fdtInventarioPorPosicion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        Return daReporteDS.fdtInventarioPorPosicion(obeFiltros)
    End Function


    'Miguel 31.01.2013

    Public Function fdtBodyEmail(ByVal ccmpn As String, ByVal cdvsn As String, ByVal cplndv As Double, ByVal cclnt As Double, ByVal creffw As String, ByVal nseqin As Integer) As DataTable
        Return odaReporteDS.fdtBodyEmail(ccmpn, cdvsn, cplndv, cclnt, creffw, nseqin)
    End Function

    Public Function fdtInventarioPorLotePorPosicion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        Return odaReporteDS.fdtInventarioPorLotePorPosicion(obeFiltros)
    End Function

End Class
