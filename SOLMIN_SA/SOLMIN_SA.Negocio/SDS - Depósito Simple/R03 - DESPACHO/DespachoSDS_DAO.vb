Namespace slnSOLMIN_SDS.DespachoSDS
    Public Class clsParamImprGuiaRemision
#Region " Atributos "
        Private intNLINGR As Integer = 0
        Private strMOGUIA As String = ""
#End Region
#Region " Propiedades "
        Public Property pintNroLineasPorGuiaRemision() As Integer
            Get
                Return intNLINGR
            End Get
            Set(ByVal value As Integer)
                intNLINGR = value
            End Set
        End Property

        Public Property pstrModeloGuiaRemision() As String
            Get
                Return strMOGUIA
            End Get
            Set(ByVal value As String)
                strMOGUIA = value
            End Set
        End Property
#End Region
    End Class
End Namespace