Public Class CentroCosto
    Private _PSCCMPN As String = ""
    Private _PNCCNTCS As Integer = 0
    Private _PSTCNTCS As String = ""
    Private _PSCCNBNS As String = ""
    Private _PSCRGVTA As String = ""
    Private _PNFULTAC As Integer = 0
    Private _PNHULTAC As Integer = 0
    Private _PSCULUSA As String = ""
    Private _PSSESTRG As String = ""

    '<[AHM]>
    Private _PSCDSDSP As String = ""
    Private _PSCDSRSP As String = ""
    Private _PSCDTSSP As String = ""
    Private _PSCDTASP As String = ""
    Private _PSCDSPSP As String = ""
    Private _PSCDUPSP As String = ""
    Private _PSCDSCSP As String = ""
    Private _PSCDTPCE As String = ""
    '</[AHM]>

    Private _PSCCNCOS As String 'RCS-HUNDRED
    Private _CEBE As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private _CECO As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Property PNCCNTCS() As String
        Get
            Return _PNCCNTCS
        End Get
        Set(ByVal value As String)
            _PNCCNTCS = value
        End Set
    End Property
    Property PSTCNTCS() As String
        Get
            Return _PSTCNTCS
        End Get
        Set(ByVal value As String)
            _PSTCNTCS = value
        End Set
    End Property
    Property PSCCNBNS() As String
        Get
            Return _PSCCNBNS
        End Get
        Set(ByVal value As String)
            _PSCCNBNS = value
        End Set
    End Property
    Property PSCRGVTA() As String
        Get
            Return _PSCRGVTA
        End Get
        Set(ByVal value As String)
            _PSCRGVTA = value
        End Set
    End Property
    Property PNFULTAC() As Integer
        Get
            Return _PNFULTAC
        End Get
        Set(ByVal value As Integer)
            _PNFULTAC = value
        End Set
    End Property
    Property PNHULTAC() As Integer
        Get
            Return _PNHULTAC
        End Get
        Set(ByVal value As Integer)
            _PNHULTAC = value
        End Set
    End Property
    Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property

    '<[AHM]>
    Property PSCDSDSP() As String
        Get
            Return _PSCDSDSP
        End Get
        Set(ByVal value As String)
            _PSCDSDSP = value
        End Set
    End Property

    Property PSCDSRSP() As String
        Get
            Return _PSCDSRSP
        End Get
        Set(ByVal value As String)
            _PSCDSRSP = value
        End Set
    End Property

    Property PSCDTSSP() As String
        Get
            Return _PSCDTSSP
        End Get
        Set(ByVal value As String)
            _PSCDTSSP = value
        End Set
    End Property

    Property PSCDTASP() As String
        Get
            Return _PSCDTASP
        End Get
        Set(ByVal value As String)
            _PSCDTASP = value
        End Set
    End Property

    Property PSCDSPSP() As String
        Get
            Return _PSCDSPSP
        End Get
        Set(ByVal value As String)
            _PSCDSPSP = value
        End Set
    End Property

    Property PSCDUPSP() As String
        Get
            Return _PSCDUPSP
        End Get
        Set(ByVal value As String)
            _PSCDUPSP = value
        End Set
    End Property

    Property PSCDSCSP() As String
        Get
            Return _PSCDSCSP
        End Get
        Set(ByVal value As String)
            _PSCDSCSP = value
        End Set
    End Property

    Property PSCDTPCE() As String
        Get
            Return _PSCDTPCE
        End Get
        Set(ByVal value As String)
            _PSCDTPCE = value
        End Set
    End Property

    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Public Property PSCCNCOS() As String
        Get
            Return _PSCCNCOS
        End Get
        Set(ByVal value As String)
            _PSCCNCOS = value
        End Set
    End Property
    'RCS-HUNDRED-FIN

    'Private _PSCCNBNS As Integer
    'Public Property PSCCNBNS() As Integer
    '    Get
    '        Return _PSCCNBNS
    '    End Get
    '    Set(ByVal value As Integer)
    '        _PSCCNBNS = value
    '    End Set
    'End Property

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Property CEBE() As String
        Get
            Return _CEBE
        End Get
        Set(ByVal value As String)
            _CEBE = value
        End Set
    End Property

    Public Property CECO() As String
        Get
            Return _CECO
        End Get
        Set(ByVal value As String)
            _CECO = value
        End Set
    End Property
    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

End Class
