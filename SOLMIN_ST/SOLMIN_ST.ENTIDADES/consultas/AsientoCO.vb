
Namespace consultas

    Public Class AsientoCO

        Private _NCRDCO As Decimal
        Public Property NCRDCO() As Decimal
            Get
                Return _NCRDCO
            End Get
            Set(ByVal value As Decimal)
                _NCRDCO = value
            End Set
        End Property


        Private _DOCDATE As String
        Public Property DOCDATE() As String
            Get
                Return _DOCDATE
            End Get
            Set(ByVal value As String)
                _DOCDATE = value
            End Set
        End Property


        Private _POSTDATE As String
        Public Property POSTDATE() As String
            Get
                Return _POSTDATE
            End Get
            Set(ByVal value As String)
                _POSTDATE = value
            End Set
        End Property


        Private _IMPORTECO As Decimal
        Public Property IMPORTECO() As Decimal
            Get
                Return _IMPORTECO
            End Get
            Set(ByVal value As Decimal)
                _IMPORTECO = value
            End Set
        End Property


        Private _NCCSAP As Decimal
        Public Property NCCSAP() As Decimal
            Get
                Return _NCCSAP
            End Get
            Set(ByVal value As Decimal)
                _NCCSAP = value
            End Set
        End Property


        Private _D_HDR_TX As String
        Public Property D_HDR_TX() As String
            Get
                Return _D_HDR_TX
            End Get
            Set(ByVal value As String)
                _D_HDR_TX = value
            End Set
        End Property
        
        


    End Class

End Namespace
