Imports RANSA.TYPEDEF
Imports RANSA.DATA


Public Class brOrdenDeCompra
    Private oDatos As daOrdenCompra

    Public Sub New()
        oDatos = New daOrdenCompra
    End Sub
    Public Function ListaEmbarquePorOC(ByVal obeOc As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListaEmbarquePorOC(obeOc)
    End Function

    Public Function InsertarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ActualizarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.ActualizarOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ListarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListarOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ObtenerOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ObtenerOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ListarOrdenDeCompraItems(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListarOrdenDeCompraItems(obeOrdenDeCompra)
    End Function

    'GASTON
    Public Function CuentaImputacionOrdenDeCompraInsert(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.CuentaImputacionOrdenDeCompraInsert(obeOrdenDeCompra)
    End Function

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Public Function ObtenerValoresGrilla(ByVal ValorEnvio As String) As DataTable
        Return oDatos.ObtenerValoresGrilla(ValorEnvio)
    End Function
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN 

#Region "Mantenimiento Detalle Oc"
    Public Function InsertarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ActualizarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.ActualizarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function ListarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function InsertarObservacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.InsertarObservacionOrdenDeCompra(obeOrdenDeCompra)
    End Function

    'Public Function ListarObservacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
    '    Return oDatos.ListarObservacionOrdenDeCompra(obeOrdenDeCompra)
    'End Function
    Public Function EliminarObservacionOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Return oDatos.EliminarObservacionOrdenDeCompra(obeOrdenCompra)
    End Function

    Public Function ListarDetalleOrdenDeCompraPendientes(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.ListarDetalleOrdenDeCompraPendientes(obeOrdenCompra)
    End Function


#End Region
#Region "Mantenimiento Detalle Pedido Oc"
    Public Function InsertarDetalleOrdenDePedCompra(ByVal obeOrdenDeCompra As beOrdenCompra)
        Return oDatos.InsertarDetalleOrdenDePedCompra(obeOrdenDeCompra)
    End Function
#End Region

#Region "Mantenimiento de CUENTAS IMPUTACION POR ORDEN COMPRA "
    Public Function fintEliminaCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.fintEliminaCuentaImputacionOrdenDeCompra(obeOrdenDeCompra)
    End Function
    Public Function fintInsertarCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function fintInsertarCuentaImputacionOrdenDeCompraCabDet(ByVal obeOrdenDeCompra As beOrdenCompra, ByVal mLlistaOrdenCompraDetalle As List(Of beOrdenCompra), ByVal mDeleteOrdenCompraDetalle As List(Of beOrdenCompra)) As Integer

        Dim intRetorno As Integer = 0
        Dim PNNSEQINOUT As Integer = 0

        intRetorno = oDatos.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenDeCompra, PNNSEQINOUT)
        If intRetorno > 0 Then

            For Each OrdenDetalle As beOrdenCompra In mLlistaOrdenCompraDetalle
                OrdenDetalle.PNNSEQIN = PNNSEQINOUT
                OrdenDetalle.PSUSUARIO = obeOrdenDeCompra.PSUSUARIO
                OrdenDetalle.PSNTRMNL = obeOrdenDeCompra.PSNTRMNL
                intRetorno = oDatos.fintInsertarCuentaImputacionDistribucion(OrdenDetalle)
            Next

            For Each OrdenDetalleDelete As beOrdenCompra In mDeleteOrdenCompraDetalle
                OrdenDetalleDelete.PSUSUARIO = obeOrdenDeCompra.PSUSUARIO
                OrdenDetalleDelete.PSNTRMNL = obeOrdenDeCompra.PSNTRMNL
                intRetorno = oDatos.fintEliminaCuentaImputacionDistribucion(OrdenDetalleDelete)
            Next


        End If


        Return intRetorno
    End Function


    Public Function flistListarCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.flistListarCuentaImputacionOrdenDeCompra(obeOrdenDeCompra)
    End Function

    Public Function flistObtenerCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.flistObtenerCuentaImputacionOrdenDeCompra(obeOrdenDeCompra)
    End Function
    Public Function flistListCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.flistListCuentaImputacionOrdenDeCompra(obeOrdenDeCompra)
    End Function


    Public Function fintInsertarCuentaImputacionOrdenDeCompra_Excel(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.fintInsertarCuentaImputacionOrdenDeCompra_Excel(obeOrdenDeCompra)
    End Function
#End Region
    Public Function ListCuentasImputacion(ByVal obeOrdenDeCompra As beOrdenCompra) As DataTable
        Return oDatos.ListCuentasImputacion(obeOrdenDeCompra)
    End Function



#Region "Mantenimiento de CUENTAS IMPUTACION POR DISTRIBUCION "
    Public Function flistListCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Return oDatos.flistListCuentaImputacionDistribucion(obeOrdenDeCompra)
    End Function

    Public Function fintInsertarCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.fintInsertarCuentaImputacionDistribucion(obeOrdenDeCompra)
    End Function
    Public Function fintEliminaCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Return oDatos.fintEliminaCuentaImputacionDistribucion(obeOrdenDeCompra)
    End Function

    Public Function finActualizarEstadoSeguimiento(ByVal olbeOrdenDeCompra As List(Of beOrdenCompra)) As Integer
        Return oDatos.finActualizarEstadoSeguimiento(olbeOrdenDeCompra)
    End Function


#End Region

#Region "Consultas & reportes"
    Public Function fdtExportarOrdenDeCompraXFechaEntrega(ByVal obeOrdenDeCompra As beOrdenCompra) As DataTable
        Return oDatos.fdtExportarOrdenDeCompraXFechaEntrega(obeOrdenDeCompra)
    End Function

    Public Function fdtIndicadorTiempoEntregaProveedor(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Return oDatos.fdtIndicadorTiempoEntregaProveedor(obeOrdenCompra)
    End Function
    Public Function fdtIndicadorTiempoEntregaProveedor_v2(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Return oDatos.fdtIndicadorTiempoEntregaProveedor_v2(obeOrdenCompra)
    End Function

    Public Function fdsReporteAnualSegOC(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Return oDatos.fdsReporteAnualSegOC(obeOrdenCompra)
    End Function
    Public Function ListaGuiaProveedor_OC(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Return oDatos.ListaGuiaProveedor_OC(obeOrdenCompra)
    End Function
#End Region


End Class
