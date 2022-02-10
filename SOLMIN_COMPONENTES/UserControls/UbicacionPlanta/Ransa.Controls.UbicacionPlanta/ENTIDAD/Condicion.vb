Namespace Condicion
    Public Class beCondicion

        Private _CCMPRN_CodigoCondicion As String
        Public Property CCMPRN_CodigoCondicion() As String
            Get
                Return _CCMPRN_CodigoCondicion
            End Get
            Set(ByVal value As String)
                _CCMPRN_CodigoCondicion = value
            End Set
        End Property


        Private _TDSDES_DescripcionCondicion As String
        Public Property TDSDES_DescripcionCondicion() As String
            Get
                Return _TDSDES_DescripcionCondicion
            End Get
            Set(ByVal value As String)
                _TDSDES_DescripcionCondicion = value
            End Set
        End Property

        Public Sub New()
            _CCMPRN_CodigoCondicion = ""
            _TDSDES_DescripcionCondicion = ""
        End Sub

    End Class

End Namespace


