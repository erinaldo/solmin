Imports System.Runtime.InteropServices
Imports System.ComponentModel
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_ServTransp
#Region " Atributos "
    Private _pCCMPN_Compania As String = ""
    Private _pCDVSN_División As String = ""
    Private _pCSRVNV_Servicio As Int32 = 0
    Private _pTCMTRF_Descripcion As String = ""

    <Description("CCMPN")> _
    Public Property pCCMPN_Compania() As String
        Get
            Return _pCCMPN_Compania
        End Get
        Set(ByVal value As String)
            _pCCMPN_Compania = value
        End Set
    End Property

    <Description("CDVSN")> _
    Public Property pCDVSN_División() As String
        Get
            Return _pCDVSN_División
        End Get
        Set(ByVal value As String)
            _pCDVSN_División = value
        End Set
    End Property

    <Description("CSRVNV")> _
    Public Property pCSRVNV_Servicio() As Int32
        Get
            Return _pCSRVNV_Servicio
        End Get
        Set(ByVal value As Int32)
            _pCSRVNV_Servicio = value
        End Set
    End Property

    <Description("TCMTRF")> _
    Public Property pTCMTRF_Descripcion() As String
        Get
            Return _pTCMTRF_Descripcion
        End Get
        Set(ByVal value As String)
            _pTCMTRF_Descripcion = value
        End Set
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPN_Compania = ""
        pCDVSN_División = ""
        pCSRVNV_Servicio = 0
        pTCMTRF_Descripcion = ""
    End Sub
#End Region
End Class

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_ServTransp
#Region " Atributos "
    Public _pCSRVNV_Servicio As Int32 = 0
    Public _pTCMTRF_Descripcion As String = ""

    <Description("CSRVNV")> _
    Public Property pCSRVNV_Servicio() As Int32
        Get
            Return _pCSRVNV_Servicio
        End Get
        Set(ByVal value As Int32)
            _pCSRVNV_Servicio = value
        End Set
    End Property

    <Description("TCMTRF")> _
    Public Property pTCMTRF_Descripcion() As String
        Get
            Return _pTCMTRF_Descripcion
        End Get
        Set(ByVal value As String)
            _pTCMTRF_Descripcion = value
        End Set
    End Property


#End Region
#Region " Métodos "
    Public Sub pClear()
        pCSRVNV_Servicio = 0
        pTCMTRF_Descripcion = ""
    End Sub
#End Region
End Class