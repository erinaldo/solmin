Public Class TipoAyuda_BE
#Region " Atributos "
    Private _pCCMPRN_Codigo As String = ""
    Private _pTDSDES_Detalle As String = ""
    Public Property pCCMPRN_Codigo() As String
        Get
            Return _pCCMPRN_Codigo
        End Get
        Set(ByVal value As String)
            _pCCMPRN_Codigo = value
        End Set
    End Property
    Public Property pTDSDES_Detalle() As String
        Get
            Return _pTDSDES_Detalle
        End Get
        Set(ByVal value As String)
            _pTDSDES_Detalle = value
        End Set
    End Property

#End Region
#Region " Métodos "
    Public Sub pClear()
        _pCCMPRN_Codigo = ""
        _pTDSDES_Detalle = ""
    End Sub
#End Region
End Class
