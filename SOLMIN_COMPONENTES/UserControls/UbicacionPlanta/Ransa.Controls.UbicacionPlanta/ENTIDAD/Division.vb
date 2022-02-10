
Namespace Division

    Public Class beDivision

        Private _CCMPN_CodigoCompania As String
        Public Property CCMPN_CodigoCompania() As String
            Get
                Return _CCMPN_CodigoCompania
            End Get
            Set(ByVal value As String)
                _CCMPN_CodigoCompania = value
            End Set
        End Property


        Private _CDVSN_CodigoDivision As String
        Public Property CDVSN_CodigoDivision() As String
            Get
                Return _CDVSN_CodigoDivision
            End Get
            Set(ByVal value As String)
                _CDVSN_CodigoDivision = value
            End Set
        End Property


        Private _TCMPDV_DescripcionDivision As String
        Public Property TCMPDV_DescripcionDivision() As String
            Get
                Return _TCMPDV_DescripcionDivision
            End Get
            Set(ByVal value As String)
                _TCMPDV_DescripcionDivision = value
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
            CCMPN_CodigoCompania = ""
            TCMPDV_DescripcionDivision = ""
            _TCMPDV_DescripcionDivision = ""
        End Sub
    End Class

End Namespace


