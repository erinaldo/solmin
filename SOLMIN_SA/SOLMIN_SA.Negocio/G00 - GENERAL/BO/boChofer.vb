Public Class boChofer
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
    Private intCTRSP As Int32 = 0
    Private strNBRVCH As String = ""
    Private strTNMBCH As String = ""
    Private intNLELCH As Int32 = 0
    Private strNTRMNL As String = ""
    Private strSESTCH As String = ""
    Private strSTACTU As String = "S"
#End Region
#Region " Propiedades "
    Public Property pintEmpresaTransporte_CTRSP() As Int32
        Get
            Return intCTRSP
        End Get
        Set(ByVal value As Int32)
            intCTRSP = value
        End Set
    End Property

    Public Property pstrNroBrevete_NBRVCH() As String
        Get
            Return strNBRVCH
        End Get
        Set(ByVal value As String)
            strNBRVCH = value
        End Set
    End Property

    Public Property pstrChofer_TNMBCH() As String
        Get
            Return strTNMBCH
        End Get
        Set(ByVal value As String)
            strTNMBCH = value
        End Set
    End Property

    Public Property pintNroDocIdentidadChofer_NLELCH() As Int32
        Get
            Return intNLELCH
        End Get
        Set(ByVal value As Int32)
            intNLELCH = value
        End Set
    End Property

    Public Property pstrNroTerminal_NTRMNL() As String
        Get
            Return strNTRMNL
        End Get
        Set(ByVal value As String)
            strNTRMNL = value
        End Set
    End Property

    Public Property pStatusChofer_SESTCH() As String
        Get
            Return strSESTCH
        End Get
        Set(ByVal value As String)
            strSESTCH = value
        End Set
    End Property

    Public Property pblnStatusActualizarSiExiste_STACTU() As Boolean
        Get
            Dim blnStatus As Boolean = False
            If strSTACTU = "S" Then blnStatus = True
            Return blnStatus
        End Get
        Set(ByVal value As Boolean)
            Select Case value
                Case True : strSTACTU = "S"
                Case False : strSTACTU = "N"
            End Select
        End Set
    End Property
#End Region
End Class
