Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsOC

#Region "Atributos"

    Private dblProveedor As Double
    Private dblCliente As Double
    Private strNroOC As String
    Private dblFecOC As Double
    Private strDes As String
    Private strIncoterm As String
    Private strMedio As Integer
    Private strPrio As String
    Private strDestino As String
    Private dblMoneda As Double
    Private lstItems As SOLMIN_SC.Negocio.clsDetOC()
    ''' <summary>
    ''' Indica el Parcial de la Orden de Compra
    ''' </summary>
    Private intParcial As Integer
    ''' <summary>
    ''' Nro. de Embarque al que pertenece la Orden de Compra
    ''' </summary>
    Private dblEmbarque As Double
    ''' <summary>
    ''' Número de Items de la Orden de Compra
    ''' </summary>
    Private dblItems As Double

#End Region

#Region "Propiedades"

    Property Moneda()
        Get
            Return Me.dblMoneda
        End Get
        Set(ByVal value)
            Me.dblMoneda = value
        End Set
    End Property

    Property Destino()
        Get
            Return Me.strDestino
        End Get
        Set(ByVal value)
            Me.strDestino = value
        End Set
    End Property

    Property Prioridad()
        Get
            Return Me.strPrio
        End Get
        Set(ByVal value)
            Me.strPrio = value
        End Set
    End Property

    Property Medio()
        Get
            Return Me.strMedio
        End Get
        Set(ByVal value)
            Me.strMedio = value
        End Set
    End Property

    Property Incoterm()
        Get
            Return Me.strIncoterm
        End Get
        Set(ByVal value)
            Me.strIncoterm = value
        End Set
    End Property

    Property Descripcion()
        Get
            Return Me.strDes
        End Get
        Set(ByVal value)
            Me.strDes = value
        End Set
    End Property

    Property FechaOC()
        Get
            Return Me.dblFecOC
        End Get
        Set(ByVal value)
            Me.dblFecOC = value
        End Set
    End Property

    Property NroOC()
        Get
            Return Me.strNroOC
        End Get
        Set(ByVal value)
            Me.strNroOC = value
        End Set
    End Property

    Property Proveedor()
        Get
            Return Me.dblProveedor
        End Get
        Set(ByVal value)
            Me.dblProveedor = value
        End Set
    End Property

    Property Cliente()
        Get
            Return Me.dblCliente
        End Get
        Set(ByVal value)
            Me.dblCliente = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Nro. de parcial de la Orden de Compra
    ''' </summary>
    Public Property Parcial() As Integer
        Get
            Return Me.intParcial
        End Get
        Set(ByVal value As Integer)
            Me.intParcial = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Nro. de Embarque al que pertenece la Orden de Compra
    ''' </summary>
    Public Property Embarque() As Double
        Get
            Return Me.dblEmbarque
        End Get
        Set(ByVal value As Double)
            Me.dblEmbarque = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Nro. de Items de la Orden de Compra
    ''' </summary>
    Public Property NroItems() As Double
        Get
            Return Me.dblItems
        End Get
        Set(ByVal value As Double)
            Me.dblItems = value
        End Set
    End Property

    ''' <summary>
    ''' Devuelve un objeto item de la Orden de Compra
    ''' </summary>
    Public ReadOnly Property Item(ByVal pintPos As Integer) As clsDetOC
        Get
            Return Me.lstItems(pintPos)
        End Get
    End Property

#End Region

#Region "Constructor"

    Sub New()
        Me.dblItems = 0
    End Sub

#End Region

#Region "Metodos"
    ''' <summary>
    ''' Agrega un Item a la Orden de Compra
    ''' </summary>
    Public Sub Agregar_Item(ByVal poDr As DataRow)
        Dim oItemOC As New clsDetOC

        With oItemOC
            .Item = poDr.Item("NRITOC").ToString.Trim
            .Descripcion = poDr.Item("TDITES").ToString.Trim
            .Cantidad = poDr.Item("QRLCSC").ToString.Trim
            .PreEmbarque = Double.Parse(poDr.Item("NRPEMB").ToString.Trim)
            .Embarque = Double.Parse(poDr.Item("NORSCI").ToString.Trim)
            .Monto_Aduanas = Double.Parse(poDr.Item("ITTADN").ToString.Trim)
            .Monto_Almacen = Double.Parse(poDr.Item("ITTALM").ToString.Trim)
            .Monto_Embarque = Double.Parse(poDr.Item("ITTEMB").ToString.Trim)
            .Monto_PreEmb = Double.Parse(poDr.Item("ITTPRE").ToString.Trim)
            .Monto_SegLog = Double.Parse(poDr.Item("ITTSEG").ToString.Trim)
            .Monto_Transporte = Double.Parse(poDr.Item("ITTTRA").ToString.Trim)
            If Double.Parse(poDr.Item("IVLFOB").ToString.Trim) > 0 Then
                .Monto_FOB = Double.Parse(poDr.Item("IVLFOB").ToString.Trim)
            Else
                .Monto_FOB = Double.Parse(poDr.Item("FOB_ITEM").ToString.Trim)
            End If
            .Monto_CIF = Double.Parse(poDr.Item("ITTCIF").ToString.Trim)
            .Monto_Flete = Double.Parse(poDr.Item("IVLFLT").ToString.Trim)
            .Monto_Seguro = Double.Parse(poDr.Item("IVLSGR").ToString.Trim)
            .Monto_Advalorem = Double.Parse(poDr.Item("ITTADV").ToString.Trim)
            .Monto_IGV = Double.Parse(poDr.Item("ITTIGV").ToString.Trim)
            .Monto_IPM = Double.Parse(poDr.Item("ITTIPM").ToString.Trim)
            .Monto_Otros_Gastos = Double.Parse(poDr.Item("ITTOGS").ToString.Trim)
            If Not poDr.Table.Columns.Item("QCNTIT") Is Nothing Then
                .TotalItem = Double.Parse(poDr.Item("QCNTIT").ToString.Trim)
            End If
            If Not poDr.Table.Columns.Item("PNNMOS") Is Nothing Then
                .OrdenServicio = Double.Parse(poDr.Item("PNNMOS").ToString.Trim)
            End If
        End With
        If lstItems Is Nothing Then
            ReDim Preserve lstItems(0)
            lstItems(0) = oItemOC
        Else
            ReDim Preserve lstItems(lstItems.Length)
            lstItems(lstItems.Length - 1) = oItemOC
        End If
        Me.dblItems = lstItems.Length
    End Sub



#End Region

    Public Function ListarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.ListarOrdenDeCompra(obeOrdenDeCompra)
    End Function
    Public Function ListarDetalleOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.ListarDetalleOrdenDeCompra(obeOrdenDeCompra)
    End Function
    Public Function finActualizarEstadoSeguimiento(ByVal olbeOrdenDeCompra As List(Of beOrdenCompra)) As Integer
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.finActualizarEstadoSeguimiento(olbeOrdenDeCompra)
    End Function
    Public Function fdtIndicadorTiempoEntregaProveedor(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.fdtIndicadorTiempoEntregaProveedor(obeOrdenCompra)
    End Function
    Public Function fdtIndicadorTiempoEntregaProveedor_v2(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.fdtIndicadorTiempoEntregaProveedor_v2(obeOrdenCompra)
    End Function
    Public Function fdsReporteAnualSegOC(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.fdsReporteAnualSegOC(obeOrdenCompra)
    End Function

    Public Function flstListaDetalleOrdenConSeguimientoLocal(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.flstListaDetalleOrdenConSeguimientoLocal(obeOrdenCompra)
    End Function



    Public Function fintVerificarEstadoSegumientoOcLocal(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Dim oDatos As New SOLMIN_SC.Datos.clsDetOC
        Return oDatos.fintVerificarEstadoSegumientoOcLocal(obeOrdenCompra)
    End Function

End Class
