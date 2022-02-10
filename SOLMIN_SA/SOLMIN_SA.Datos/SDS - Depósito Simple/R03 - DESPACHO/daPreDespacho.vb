Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daPreDespacho 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
    Private sqlManager As New SqlManager

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

    'Detalle de Bulto
    Public Function ListaDetalleBulto() As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PNCCLNT", parametroPedido.Pncclnt)
            parameter.Add("PSCCMPN", parametroPedido.Psccmpn)
            parameter.Add("PSCDVSN", parametroPedido.Pscdvsn)
            parameter.Add("PNCPLNDV", parametroPedido.Pncplndv)
            parameter.Add("PSCREFFW", parametroPedido.Pscreffw)
            parameter.Add("PNNSEQIN", parametroPedido.Pnnseqin)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_ITEMS_BULTO_LIST2", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function

    'Cabecera de Pedido
    Public Function ListaCabeceraPedido() As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PNCCLNT", parametroPedido.Pncclnt)
            parameter.Add("PSCCMPN", parametroPedido.Psccmpn)
            parameter.Add("PSCDVSN", parametroPedido.Pscdvsn)
            parameter.Add("PNCPLNDV", parametroPedido.Pncplndv)
            parameter.Add("PSCREFFW", parametroPedido.Pscreffw)
            parameter.Add("PNNSEQIN", parametroPedido.Pnnseqin)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_PEDIDO_TRASLADO_LIST_BULTO", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function

    'Detalle de Pedido 
    Public Function ListaDetallePedido() As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PNCCLNT", parametroPedido.Pncclnt)
            parameter.Add("PSCCMPN", parametroPedido.Psccmpn)
            parameter.Add("PSCDVSN", parametroPedido.Pscdvsn)
            parameter.Add("PNCPLNDV", parametroPedido.Pncplndv)
            parameter.Add("PSCREFFW", parametroPedido.Pscreffw)
            parameter.Add("PNNSEQIN", parametroPedido.Pnnseqin)
            parameter.Add("NRPDTS", parametroPedido.psnrpdts)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_DET_PEDIDO_TRASLADO_LIST_BULTO", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function

    Public Function ValidarDespachoMilpo(ByVal Pncclnt As Double) As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PNCCLNT ", Pncclnt)
            output = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_VALIDA_CLIENTE_MILPO", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function

    Public Sub QuitarBulto()
        'Try
        Dim parameter As New Parameter
        parameter.Add("IN_CCMPN", parametroPedido.Psccmpn) 'Compañía
        parameter.Add("IN_CDVSN", parametroPedido.Pscdvsn) 'División
        parameter.Add("IN_CPLNDV", parametroPedido.Pncplndv) 'Planta
        parameter.Add("IN_CCLNT", parametroPedido.Pncclnt) 'Cód. Cliente
        parameter.Add("IN_CREFFW", parametroPedido.Pscreffw) 'Bulto
        parameter.Add("IN_CIDPAQ", parametroBulto.cidpaq) 'Cód. Identificación de paquete
        parameter.Add("IN_NSEQIN", parametroPedido.Pnnseqin) 'Nro. Secuencia
        parameter.Add("IN_NORCML", parametroBulto.norcml) 'Nro. OC
        parameter.Add("IN_NRITOC", parametroBulto.nritoc) 'Nro. Ítem
        parameter.Add("IN_NRPDTS", parametroPedido.psnrpdts) 'Número de Pedido de traslado
        parameter.Add("IN_NROSEC", parametroBulto.nrosec) 'Nro. Ítem del Pedido de traslado
        parameter.Add("IN_QBLTSR", parametroBulto.qbltsr) 'Saldo cantidad bulto
        parameter.Add("IN_USUARI", parametroBulto.usuari) 'Usuario del sistema
        sqlManager.ExecuteNonQuery("SP_SOLMIN_SA_PEDIDO_TRASLADO_DETALLE_BULTO_UPDATE_DEL", parameter)
        'Catch ex As Exception

        'End Try
    End Sub


    Public Function ValidarDespacho() As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PNCCLNT", parametroPedido.Pncclnt)
            parameter.Add("PSCCMPN", parametroPedido.Psccmpn)
            parameter.Add("PSCDVSN", parametroPedido.Pscdvsn)
            parameter.Add("PNCPLNDV", parametroPedido.Pncplndv)
            parameter.Add("PNNROCTL", parametroPedido.pnnroctl)

            output = sqlManager.ExecuteDataTable(" SP_SOLMIN_SA_SAT_VALIDA_DESPACHO", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function


End Class
