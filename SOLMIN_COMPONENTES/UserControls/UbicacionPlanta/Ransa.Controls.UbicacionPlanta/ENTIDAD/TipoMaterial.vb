Namespace TipoMaterial
    Public Class beTipoMaterial

        Private _CCMPRN_CodigoTipoMaterial As String
        Public Property CCMPRN_CodigoTipoMaterial() As String
            Get
                Return _CCMPRN_CodigoTipoMaterial
            End Get
            Set(ByVal value As String)
                _CCMPRN_CodigoTipoMaterial = value
            End Set
        End Property


        Private _TDSDES_DescripcionTipoMaterial As String
        Public Property TDSDES_DescripcionTipoMaterial() As String
            Get
                Return _TDSDES_DescripcionTipoMaterial
            End Get
            Set(ByVal value As String)
                _TDSDES_DescripcionTipoMaterial = value
            End Set
        End Property


        Private _Orden As Int32 = -1
        Public Property Orden() As Int32
            Get
                Return _Orden
            End Get
            Set(ByVal value As Int32)
                _Orden = value
            End Set
        End Property

        Public Sub New()
            Orden = -1
            _CCMPRN_CodigoTipoMaterial = ""
            TDSDES_DescripcionTipoMaterial = ""
        End Sub

    End Class

End Namespace


