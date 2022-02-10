Imports RANSA.TypeDef
Imports RANSA.DATA

Public Class brPreDespacho 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)

    Private _parametroPedido As bePedidoTrasladoxBulto
    ''' <summary>
    ''' Parametro pedido traslado por bulto
    ''' </summary>
    Public Property parametroPedido() As bePedidoTrasladoxBulto
        Get
            Return _parametroPedido
        End Get
        Set(ByVal value As bePedidoTrasladoxBulto)
            _parametroPedido = value
        End Set
    End Property

    Private _parametroBulto As beQuitarBulto
    ''' <summary>
    ''' Parametro quitar pedido traslado por bulto
    ''' </summary>
    Public Property parametroBulto() As beQuitarBulto
        Get
            Return _parametroBulto
        End Get
        Set(ByVal value As beQuitarBulto)
            _parametroBulto = value
        End Set
    End Property


    Dim preDespacho As New daPreDespacho

    'Detalle de Bulto
    Public Function ListaDetalleBulto() As DataTable
        preDespacho.parametroPedido = parametroPedido
        Dim output As DataTable = preDespacho.ListaDetalleBulto()
        output.Columns.Add("CantPorAtender", Type.GetType("System.Double"))
        output.Columns.Add("CantDespachado", Type.GetType("System.Double"))
        output.Columns.Add("ID", Type.GetType("System.String"))
        output.Columns.Add("NroPosicionPedido", Type.GetType("System.String"))
        output.Columns.Add("NroPedido", Type.GetType("System.String"))

        For Each row As DataRow In output.Rows
            row("CantPorAtender") = row("QBLTSR")
            row("CantDespachado") = 0
            row("ID") = String.Empty
            row("NroPosicionPedido") = ""
            row("NroPedido") = String.Empty
        Next row

        Return output

    End Function

    'Cabecera de Pedido
    Public Function ListaCabeceraPedido() As DataTable
        preDespacho.parametroPedido = parametroPedido
        Return preDespacho.ListaCabeceraPedido()
    End Function

    'Todo Detalle de Pedido 
    Public Function ListaTodoDetallePedido() As DataTable
        preDespacho.parametroPedido = parametroPedido
        Dim output As DataTable = preDespacho.ListaDetallePedido()
        output.Columns.Add("IsChecked", Type.GetType("System.Boolean"))
        output.Columns.Add("ID", Type.GetType("System.String"))
        output.Columns.Add("CantStock", Type.GetType("System.Double"))

        For Each row As DataRow In output.Rows
            row("IsChecked") = False
            row("ID") = String.Format("{0}-{1}-{2}", Trim(row("NROSEC")), Trim(row("TCITCL")), Trim(row("NRPDTS")))
            row("CantStock") = row("QTYPEN")

        Next row

        Return output
    End Function

    'Validar despacho sea del cliente milpo
    Public Function ValidarDespachoMilpo(ByVal cliente As Double) As Boolean
        Dim esClienteMilpo As Boolean = False
        Dim output As DataTable = preDespacho.ValidarDespachoMilpo(cliente)

        If output IsNot Nothing Then
            If output.Rows.Count > 0 Then
                esClienteMilpo = True
            End If
        End If

        Return esClienteMilpo
    End Function

    'Quitar despacho pedido bulto
    Public Sub QuitarBulto()
        preDespacho.parametroPedido = parametroPedido
        preDespacho.parametroBulto = parametroBulto
        preDespacho.QuitarBulto()
    End Sub

    Public Function ValidarDespacho() As DataTable
        preDespacho.parametroPedido = parametroPedido
        Return preDespacho.ValidarDespacho()
    End Function
End Class
