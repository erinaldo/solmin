Public Class AsigRecursoGT_BE
    Public Sub New()

    End Sub
#Region "Atributos"

    Private _PSCCMPN As String = ""
    Private _PNFECHAINICIO As Double
    Private _PNCTRMNC As Double = 0
    Private _PNNGUITR As Double = 0
    Private _PSMOTIVO As String = ""
    Private _PNCMEDTR As Double = 0
    Private _PSTRACTO As String = ""
    Private _PSACOPLADO As String = ""
    Private _PSBREVETE1 As String = ""
    Private _PSBREVETE2 As String = ""
    Private _PSCOD_ORIGEN As Double = 0
    Private _PSCOD_DESTINO As Double = 0
	Private _PSDES_ORIGEN As String = ""
    Private _PSDES_DESTINO As String = ""
    Private _PSOBS As String = ""
    Private _PSCULUSA As String = ""
    Private _PSTERMINAL As String = ""
    Private _CORR As String = ""
    Private _CODVAR As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As String = ""
    Private _RucTransportista As String = ""
    Private _FECHAINICIO As String = ""
#End Region
#Region "Propiedades"


    Public Property CCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Public Property FECHAINICIO() As Double
        Get
            Return _FECHAINICIO
        End Get
        Set(ByVal value As Double)
            _FECHAINICIO = value
        End Set
    End Property
    Public Property CTRMNC() As Double
        Get
            Return _PNCTRMNC
        End Get
        Set(ByVal value As Double)
            _PNCTRMNC = value
        End Set
    End Property
    Public Property NGUITR() As Double
        Get
            Return _PNNGUITR
        End Get
        Set(ByVal value As Double)
            _PNNGUITR = value
        End Set
    End Property
    Public Property MOTIVO() As String
        Get
            Return _PSMOTIVO
        End Get
        Set(ByVal value As String)
            _PSMOTIVO = value
        End Set
    End Property
    Public Property CMEDTR() As Double
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Double)
            _PNCMEDTR = value
        End Set
    End Property
    Public Property TRACTO() As String
        Get
            Return _PSTRACTO
        End Get
        Set(ByVal value As String)
            _PSTRACTO = value
        End Set
    End Property
    Public Property ACOPLADO() As String
        Get
            Return _PSACOPLADO
        End Get
        Set(ByVal value As String)
            _PSACOPLADO = value
        End Set
    End Property
    Public Property CONDUCTOR1() As String
        Get
            Return _PSBREVETE1
        End Get
        Set(ByVal value As String)
            _PSBREVETE1 = value
        End Set
    End Property
    Public Property CONDUCTOR2() As String
        Get
            Return _PSBREVETE2
        End Get
        Set(ByVal value As String)
            _PSBREVETE2 = value
        End Set
    End Property
    Public Property COD_LOCALIDAD_ORIGEN() As Double
        Get
            Return _PSCOD_ORIGEN
        End Get
        Set(ByVal value As Double)
            _PSCOD_ORIGEN = value
        End Set
    End Property
    Public Property COD_LOCALIDAD_DESTINO() As Double
        Get
            Return _PSCOD_DESTINO
        End Get
        Set(ByVal value As Double)
            _PSCOD_DESTINO = value
        End Set
    End Property
	 Public Property LOCALIDAD_ORIGEN() As String
        Get
            Return _PSDES_ORIGEN
        End Get
        Set(ByVal value As String)
            _PSDES_ORIGEN = value
        End Set
    End Property
    Public Property LOCALIDAD_DESTINO() As String
        Get
            Return _PSDES_DESTINO
        End Get
        Set(ByVal value As String)
            _PSDES_DESTINO = value
        End Set
    End Property
    Public Property OBS() As String
        Get
            Return _PSOBS
        End Get
        Set(ByVal value As String)
            _PSOBS = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property TERMINAL() As String
        Get
            Return _PSTERMINAL
        End Get
        Set(ByVal value As String)
            _PSTERMINAL = value
        End Set
    End Property
    Public Property CORR() As String
        Get
            Return _CORR
        End Get
        Set(ByVal value As String)
            _CORR = value
        End Set
    End Property
    Public Property CODVAR() As String
        Get
            Return _CODVAR
        End Get
        Set(ByVal value As String)
            _CODVAR = value
        End Set
    End Property
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property CPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property
    Public Property RucTransportista() As String
        Get
            Return _RucTransportista
        End Get
        Set(ByVal value As String)
            _RucTransportista = value
        End Set
    End Property
    Public Property FECHA_ASIG() As String
        Get
            Return _FECHAINICIO
        End Get
        Set(ByVal value As String)
            _FECHAINICIO = value
        End Set
    End Property

#End Region
End Class
