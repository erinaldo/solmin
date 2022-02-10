Namespace Compania
    Public Class beCompania

        Private _CCMPN_CodigoCompania As String
        Public Property CCMPN_CodigoCompania() As String
            Get
                Return _CCMPN_CodigoCompania
            End Get
            Set(ByVal value As String)
                _CCMPN_CodigoCompania = value
            End Set
        End Property


        Private _TCMPCM_DescripcionCompania As String
        Public Property TCMPCM_DescripcionCompania() As String
            Get
                Return _TCMPCM_DescripcionCompania
            End Get
            Set(ByVal value As String)
                _TCMPCM_DescripcionCompania = value
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
            _CCMPN_CodigoCompania = ""
            TCMPCM_DescripcionCompania = ""
        End Sub
    End Class

End Namespace


