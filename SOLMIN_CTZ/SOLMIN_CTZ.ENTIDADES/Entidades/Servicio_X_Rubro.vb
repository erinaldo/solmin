Public Class Servicio_X_Rubro
    Inherits Base(Of Servicio_X_Rubro)

    Private _NRSRRB As Decimal = 0
    Private _NRRUBR As Decimal = 0
    Private _CSCDSP As String = ""
    Private _CRGVTA As String = ""
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CSRVNV As Decimal = 0
    Private _NOMSER As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _SESTRG As String = ""
    Private _CSRVC As String = ""
    Private _NRRUBR_NRSRRB As String = ""
    '<[AHM]>
    Private _CDSRSP As String = ""
    Private _TDSRSP As String = ""
    'CODIGO DE TARIFA
    Private _MATNR As String = ""
    '</[AHM]>

    Property NRSRRB() As Decimal
        Get
            Return _NRSRRB
        End Get
        Set(ByVal value As Decimal)
            _NRSRRB = value
        End Set
    End Property

    Property NRRUBR() As Decimal
        Get
            Return _NRRUBR
        End Get
        Set(ByVal value As Decimal)
            _NRRUBR = value
        End Set
    End Property


    Private _NOMRUB As String
    Public Property NOMRUB() As String
        Get
            Return _NOMRUB
        End Get
        Set(ByVal value As String)
            _NOMRUB = value
        End Set
    End Property

    Property CSCDSP() As String
        Get
            Return _CSCDSP
        End Get
        Set(ByVal value As String)
            _CSCDSP = value
        End Set
    End Property

    Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Property CSRVNV() As Decimal
        Get
            Return _CSRVNV
        End Get
        Set(ByVal value As Decimal)
            _CSRVNV = value
        End Set
    End Property

    Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            _NOMSER = value
        End Set
    End Property

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property

    Public Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As String)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As String)
            _HRACRT = Value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
        End Set
    End Property

    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As String)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As String)
            _HULTAC = Value
        End Set
    End Property


    Private _TCMTRF As String
    Public Property TCMTRF() As String
        Get
            Return _TCMTRF
        End Get
        Set(ByVal value As String)
            _TCMTRF = value
        End Set
    End Property



    Private _TSRVIN As String
    Public Property TSRVIN() As String
        Get
            Return _TSRVIN
        End Get
        Set(ByVal value As String)
            _TSRVIN = value
        End Set
    End Property


    Private _IAFCDT As Decimal
    Public Property IAFCDT() As Decimal
        Get
            Return _IAFCDT
        End Get
        Set(ByVal value As Decimal)
            _IAFCDT = value
        End Set
    End Property



    Private _IPRCDT As Decimal
    Public Property IPRCDT() As Decimal
        Get
            Return _IPRCDT
        End Get
        Set(ByVal value As Decimal)
            _IPRCDT = value
        End Set
    End Property

    Public Property CSRVC() As String
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As String)
            _CSRVC = value
        End Set
    End Property

    Public Property NRRUBR_NRSRRB() As String
        Get
            Return _NRRUBR_NRSRRB
        End Get
        Set(ByVal value As String)
            _NRRUBR_NRSRRB = value
        End Set
    End Property


    Public ReadOnly Property COD_SERV() As String
        Get
            Return NRRUBR.ToString & " - " & NRSRRB.ToString
        End Get

    End Property

    '<[AHM]>
    Property CDSRSP() As String
        Get
            Return _CDSRSP
        End Get
        Set(ByVal value As String)
            _CDSRSP = value
        End Set
    End Property

    Property TDSRSP() As String
        Get
            Return _TDSRSP
        End Get
        Set(ByVal value As String)
            _TDSRSP = value
        End Set
    End Property


    Property MATNR() As String
        Get
            Return _MATNR
        End Get
        Set(ByVal value As String)
            _MATNR = value
        End Set
    End Property
    '</[AHM]>
End Class
