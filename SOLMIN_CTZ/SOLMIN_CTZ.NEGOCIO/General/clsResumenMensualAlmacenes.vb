Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsResumenMensualAlmacenes

    Private oResumenMensualAlm As New SOLMIN_CTZ.DATOS.clsResumenMensualAlmacenes

#Region "Stock AT"
    Public Function fodtInventarioSATResumenMensualAll(ByVal obeFiltro As ResumenMensualAlmacenes) As DataTable
        Return oResumenMensualAlm.fodtInventarioSATResumenMensualAll(obeFiltro)
    End Function

    Public Function fodtMovimientosIngSATResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Return oResumenMensualAlm.fodtMovimientosIngSATResumenMensual(obeFiltros)
    End Function
    Public Function fodtMovimientosSalidaSATResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Return oResumenMensualAlm.fodtMovimientosSalidaSATResumenMensual(obeFiltros)
    End Function
#End Region

#Region "Stock DS"
    Public Function fodtInventarioDSResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Return oResumenMensualAlm.fodtInventarioDSResumenMensual(obeFiltros)
    End Function

    Public Function fodtMovimientosIngSalDSResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Return oResumenMensualAlm.fodtMovimientosIngSalDSResumenMensual(obeFiltros)
    End Function
#End Region

End Class
