

Public Class clsDetOC

#Region "Atributos"

    Private oDetOC As Datos.clsDetOC
    ''' <summary>
    ''' Descripción del Item
    ''' </summary>
    Private strDescripcion As String
    ''' <summary>
    ''' Número de Item
    ''' </summary>
    Private intItem As Integer
    ''' <summary>
    ''' Cantidad del Item
    ''' </summary>
    Private dblCantidad As Double
    ''' <summary>
    ''' Monto Total de PreEmbarque
    ''' </summary>
    Private dblMonto_PreEmb As Double
    ''' <summary>
    ''' Monto Total de Embarque
    ''' </summary>
    Private dblMonto_Embarque As Double
    ''' <summary>
    ''' Monto Total de Aduanas
    ''' </summary>
    Private dblMonto_Aduanas As Double
    ''' <summary>
    ''' Monto Total del Seguimiento Logístico
    ''' </summary>
    Private dblMonto_SegLog As Double
    ''' <summary>
    ''' Monto Total de Almacén
    ''' </summary>
    Private dblMonto_Almacen As Double
    ''' <summary>
    ''' Monto Total de Transporte
    ''' </summary>
    Private dblMonto_Transporte As Double
    ''' <summary>
    ''' Monto FOB del Item
    ''' </summary>
    Private dblMonto_FOB As Double
    ''' <summary>
    ''' Monto Flete del Item
    ''' </summary>
    Private dblMonto_Flete As Double
    ''' <summary>
    ''' Monto Seguro del Item
    ''' </summary>
    Private dblMonto_Seguro As Double
    ''' <summary>
    ''' Número de PreEmbarque
    ''' </summary>
    Private dblPreEmbarque As Double
    ''' <summary>
    ''' Monto CIF Total del Item
    ''' </summary>
    Private dblMonto_CIF As Double
    ''' <summary>
    ''' Monto Advalorem Total del Item
    ''' </summary>
    Private dblMonto_Advalorem As Double
    ''' <summary>
    ''' Monto IGV Total del Item
    ''' </summary>
    Private dblMonto_IGV As Double
    ''' <summary>
    ''' Monto IPM Total del Item
    ''' </summary>
    Private dblMonto_IPM As Double
    ''' <summary>
    ''' Monto Total de Otros Gastos Aduaneros del Item
    ''' </summary>
    Private dblMonto_Otros_Gastos As Double
    ''' <summary>
    ''' Número de Orden de Servicio
    ''' </summary>
    Private dblOS As Double
    ''' <summary>
    ''' Número de Embarque
    ''' </summary>
    Private dblEmbarque As Double
    ''' <summary>
    ''' Cantidad Total del Item
    ''' </summary>
    Private dblTotalCantidad As Double

#End Region

#Region "Constructor"

    Sub New()
        oDetOC = New Datos.clsDetOC
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Obtiene o establece la Cantidad del Item
    ''' </summary>
    Public Property Cantidad() As Double
        Get
            Return dblCantidad
        End Get
        Set(ByVal value As Double)
            dblCantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total de Aduanas
    ''' </summary>
    Public Property Monto_Aduanas() As Double
        Get
            Return Me.dblMonto_Aduanas
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Aduanas = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total de Almacén
    ''' </summary>
    Public Property Monto_Almacen() As Double
        Get
            Return Me.dblMonto_Almacen
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Almacen = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total de Embarque
    ''' </summary>
    Public Property Monto_Embarque() As Double
        Get
            Return Me.dblMonto_Embarque
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Embarque = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total de PreEmbarque
    ''' </summary>
    Public Property Monto_PreEmb() As Double
        Get
            Return Me.dblMonto_PreEmb
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_PreEmb = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total del Seguimiento Logístico
    ''' </summary>
    Public Property Monto_SegLog() As Double
        Get
            Return Me.dblMonto_SegLog
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_SegLog = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Monto Total de Transporte
    ''' </summary>
    Public Property Monto_Transporte() As Double
        Get
            Return Me.dblMonto_Transporte
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Transporte = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la Descripción del Item
    ''' </summary>
    Public Property Descripcion() As String
        Get
            Return Me.strDescripcion
        End Get
        Set(ByVal value As String)
            Me.strDescripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Número de Item
    ''' </summary>
    Public Property Item() As Integer
        Get
            Return Me.intItem
        End Get
        Set(ByVal value As Integer)
            Me.intItem = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el FOB del Item
    ''' </summary>
    Public Property Monto_FOB() As Double
        Get
            Return Me.dblMonto_FOB
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_FOB = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Flete del Item
    ''' </summary>
    Public Property Monto_Flete() As Double
        Get
            Return Me.dblMonto_Flete
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Flete = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Seguro del Item
    ''' </summary>
    Public Property Monto_Seguro() As Double
        Get
            Return Me.dblMonto_Seguro
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Seguro = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Número de PreEmbarque
    ''' </summary>
    Public Property PreEmbarque() As Double
        Get
            Return Me.dblPreEmbarque
        End Get
        Set(ByVal value As Double)
            Me.dblPreEmbarque = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el CIF del Item
    ''' </summary>
    Public Property Monto_CIF() As Double
        Get
            Return Me.dblMonto_CIF
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_CIF = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Advalorem del Item
    ''' </summary>
    Public Property Monto_Advalorem() As Double
        Get
            Return Me.dblMonto_Advalorem
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Advalorem = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el IGV del Item
    ''' </summary>
    Public Property Monto_IGV() As Double
        Get
            Return Me.dblMonto_IGV
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_IGV = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el IPM del Item
    ''' </summary>
    Public Property Monto_IPM() As Double
        Get
            Return Me.dblMonto_IPM
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_IPM = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece los Otros Gastos del Item
    ''' </summary>
    Public Property Monto_Otros_Gastos() As Double
        Get
            Return Me.dblMonto_Otros_Gastos
        End Get
        Set(ByVal value As Double)
            Me.dblMonto_Otros_Gastos = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Número de Embarque
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
    ''' Obtiene o establece el Número de Orden de Servicio
    ''' </summary>
    Public Property OrdenServicio() As Double
        Get
            Return Me.dblOS
        End Get
        Set(ByVal value As Double)
            Me.dblOS = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la Cantidad Total del Item
    ''' </summary>
    Public Property TotalItem() As Double
        Get
            Return Me.dblTotalCantidad
        End Get
        Set(ByVal value As Double)
            Me.dblTotalCantidad = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Busca_Det_OC(ByVal pdblCli As Double, ByVal pstrOC As String) As DataTable
        Return oDetOC.Busca_Det_OC(pdblCli, pstrOC)
    End Function

    Public Function Consulta_Item_Seguimiento_PreEmbarque(ByVal NORCML As String, ByVal CCLNT As Decimal, ByVal CCMPN As String, ByVal NORSCI As Decimal) As DataTable

        Dim ds As New DataSet
        ds = oDetOC.Consulta_Item_Seguimiento_PreEmbarque(NORCML, CCLNT, CCMPN, NORSCI)
        Dim dtPreEmbarcado As New DataTable
        Dim dtEmbarcado As New DataTable
        dtPreEmbarcado = ds.Tables(0).Copy
        dtEmbarcado = ds.Tables(1).Copy
        Dim NUMERO As Int32 = dtPreEmbarcado.Rows.Count - 1
        For index As Integer = 0 To NUMERO
            For index1 As Integer = 0 To dtEmbarcado.Rows.Count - 1
                If dtEmbarcado.Rows(index1).Item("CODIGO") = dtPreEmbarcado.Rows(index).Item("CODIGO") Then
                    dtPreEmbarcado.Rows.RemoveAt(index)
                End If
            Next
        Next
        Return dtPreEmbarcado
    End Function


    Public Sub Actualiza_Item_OC_Partida(ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblItem As Double, ByVal pstrPartida As String, ByVal pstrSubItem As String)
        oDetOC.Actualiza_Item_OC_Partida(pdblCliente, pstrOC, pdblItem, pstrPartida, pstrSubItem)
    End Sub

    Public Function Busca_Det_OC_ADICION_PARCIAL(ByVal pdblCli As Double, ByVal pstrOC As String, ByVal PNNRPARC As Decimal) As DataSet
        Return oDetOC.Busca_Det_OC_ADICION_PARCIAL(pdblCli, pstrOC, PNNRPARC)
    End Function

    Public Function LISTA_CANTIDADES_EMBARQUE_ADUANA(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNORSCI As Decimal, ByVal PNNRPEMB As Decimal) As DataTable

        Dim dt As New DataTable
        dt = oDetOC.LISTA_CANTIDADES_EMBARQUE_ADUANA(PNCCLNT, PSNORCML, PNNRITOC, PSSBITOC, PNNORSCI, PNNRPEMB)
        Return dt
    End Function

    Public Function SP_SOLMIN_SC_ACTUALIZAR_ITEM_EMBARQUE(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNRPEMB As Decimal, ByVal PNQRLCSC As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PSNFCTCM As String, ByVal PNNMITFC As Decimal, ByVal PSCPTDAR As String, ByVal CANT_ANTERIOR As Decimal) As Integer
        Return oDetOC.SP_SOLMIN_SC_ACTUALIZAR_ITEM_EMBARQUE(PNCCLNT, PNNORSCI, PNNRPEMB, PNQRLCSC, PSNORCML, PNNRITOC, PSSBITOC, PSNFCTCM, PNNMITFC, PSCPTDAR, CANT_ANTERIOR)
    End Function
#End Region

End Class
