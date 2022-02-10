Public Class beDetCostoRubroAgencia

    Private _PNNORSCI As Decimal = 0
    Private _PNCSRVRL As Decimal = 0
    Private _PSCODVAR As String = ""
    Private _PNIMPORTE_TOTAL_DOL As Decimal = 0
    Private _PNIMPORTE_TOTAL_SOL As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PSCULUSA As String = ""
    Private _PNIMTPOC As Decimal = 0
    Private _PNTIPODOC As Decimal = 0
    Private _PNNUMDOC As Decimal = 0
    Private _PSTCMTPD As String = ""
    Private _PNIGV As Decimal = 0
    Private _PNIMPORTE_BASE_DOL As Decimal = 0
    Private _PNIMPORTE_BASE_SOL As Decimal = 0
    Private _PNIMPORTE_IGV_DOL As Decimal = 0
    Private _PNIMPORTE_IGV_SOL As Decimal = 0
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property PSCODVAR() As String
        Get
            Return _PSCODVAR
        End Get
        Set(ByVal value As String)
            _PSCODVAR = value
        End Set
    End Property



    Public Property PNCSRVRL() As Decimal
        Get
            Return _PNCSRVRL
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVRL = value
        End Set
    End Property


    Public Property PNIMPORTE_TOTAL_DOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_TOTAL_SOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_SOL = value
        End Set
    End Property



    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property

    Public Property PNIMTPOC() As Decimal
        Get
            Return _PNIMTPOC
        End Get
        Set(ByVal value As Decimal)
            _PNIMTPOC = value
        End Set
    End Property


    Public Property PNTIPODOC() As Decimal
        Get
            Return _PNTIPODOC
        End Get
        Set(ByVal value As Decimal)
            _PNTIPODOC = value
        End Set
    End Property

    Public Property PNNUMDOC() As Decimal
        Get
            Return _PNNUMDOC
        End Get
        Set(ByVal value As Decimal)
            _PNNUMDOC = value
        End Set
    End Property
    Public Property PSTCMTPD() As String
        Get
            Return _PSTCMTPD
        End Get
        Set(ByVal value As String)
            _PSTCMTPD = value
        End Set
    End Property

    Public Property PNIMPORTE_BASE_DOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_BASE_SOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_SOL = value
        End Set
    End Property
    Public Property PNIMPORTE_IGV_DOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_IGV_SOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_SOL = value
        End Set
    End Property

    Public Property PNIGV() As Decimal
        Get
            Return _PNIGV
        End Get
        Set(ByVal value As Decimal)
            _PNIGV = value
        End Set
    End Property

End Class
