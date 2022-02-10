Namespace slnSOLMIN_SAT.Recepcion
    Public Class clsPrimaryKey_OrdenCompra
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNORCML As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = "" & value
            End Set
        End Property


        Private _Compania As String
        Public Property Compania() As String
            Get
                Return _Compania
            End Get
            Set(ByVal value As String)
                _Compania = value
            End Set
        End Property


        Private _Division As String
        Public Property Division() As String
            Get
                Return _Division
            End Get
            Set(ByVal value As String)
                _Division = value
            End Set
        End Property


        Private _Planta As Decimal
        Public Property Planta() As Decimal
            Get
                Return _Planta
            End Get
            Set(ByVal value As Decimal)
                _Planta = value
            End Set
        End Property

#End Region
    End Class

    Public Class clsPrimaryKey_ItemOrdenCompra
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNORCML As String = ""
        Private intNRITOC As Int32 = 0
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = "" & value
            End Set
        End Property

        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property
#End Region
    End Class
End Namespace