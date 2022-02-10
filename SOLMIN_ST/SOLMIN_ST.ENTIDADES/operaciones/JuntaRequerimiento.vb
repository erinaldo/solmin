Public Class JuntaRequerimiento


    Private _NPLNJT As Decimal = 0D ' 10,0    NUM PLANEAMIENTO DE JUNTA
    Public Property NPLNJT() As Decimal
        Get
            Return _NPLNJT
        End Get
        Set(ByVal value As Decimal)
            _NPLNJT = value
        End Set
    End Property


    Private _NCRRPL As Decimal = 0D ' 5,0    NUM CORRELATIVO DEL PLANEAMIENTO
    Public Property NCRRPL() As Decimal
        Get
            Return _NCRRPL
        End Get
        Set(ByVal value As Decimal)
            _NCRRPL = value
        End Set
    End Property


    Private _NUMREQT As Decimal = 0D ' 10,0  NUM DE REQUERIMIENTO
    Public Property NUMREQT() As Decimal
        Get
            Return _NUMREQT
        End Get
        Set(ByVal value As Decimal)
            _NUMREQT = value
        End Set
    End Property


    Private _QANPRG As Decimal = 0D  ' 15,5 CANTIDAD PROGRAMADA
    Public Property QANPRG() As Decimal
        Get
            Return _QANPRG
        End Get
        Set(ByVal value As Decimal)
            _QANPRG = value
        End Set
    End Property


    Private _QATNAN As Decimal = 0D  '15,5 CANTIDAD ATENDIDA
    Public Property QATNAN() As Decimal
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Decimal)
            _QATNAN = value
        End Set
    End Property


    Private _SESTRG As String = ""
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Private _SESTRG_D As String = ""
    Public Property SESTRG_D() As String
        Get
            Return _SESTRG_D
        End Get
        Set(ByVal value As String)
            _SESTRG_D = value
        End Set
    End Property

    Private _CUSCRT As String = ""
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Private _FCHCRT As Decimal = 0D
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Private _HRACRT As Decimal = 0D
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Private _NTRMCR As String = ""
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Private _FULTAC As Decimal = 0D
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Private _HULTAC As Decimal = 0D
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Private _CMEDTR As Decimal = 0D
    Public Property CMEDTR() As Decimal
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As Decimal)
            _CMEDTR = value
        End Set
    End Property

    Private _CMEDTR_D As String = ""
    Public Property CMEDTR_D() As String
        Get
            Return _CMEDTR_D
        End Get
        Set(ByVal value As String)
            _CMEDTR_D = value
        End Set
    End Property

    Private _NORSRT As Decimal = 0D
    Public Property NORSRT() As Decimal
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Decimal)
            _NORSRT = value
        End Set
    End Property

    Private _CLCLOR As Decimal = 0D
    Public Property CLCLOR() As Decimal
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Decimal)
            _CLCLOR = value
        End Set
    End Property

    Private _CLCLOR_D As String = ""
    Public Property CLCLOR_D() As String
        Get
            Return _CLCLOR_D
        End Get
        Set(ByVal value As String)
            _CLCLOR_D = value
        End Set
    End Property

    Private _CLCLDS As Decimal = 0D
    Public Property CLCLDS() As Decimal
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Decimal)
            _CLCLDS = value
        End Set
    End Property

    Private _CLCLDS_D As String = ""
    Public Property CLCLDS_D() As String
        Get
            Return _CLCLDS_D
        End Get
        Set(ByVal value As String)
            _CLCLDS_D = value
        End Set
    End Property

    Private _QPSOMR As Decimal = 0D 'Peso(kg)  15,5
    Public Property QPSOMR() As Decimal
        Get
            Return _QPSOMR
        End Get
        Set(ByVal value As Decimal)
            _QPSOMR = value
        End Set
    End Property

    Private _QMTLRG As Decimal = 0D 'Largo(m) 7,2
    Public Property QMTLRG() As Decimal
        Get
            Return _QMTLRG
        End Get
        Set(ByVal value As Decimal)
            _QMTLRG = value
        End Set
    End Property

    Private _QMTALT As Decimal = 0D 'Alto(m) 7,2
    Public Property QMTALT() As Decimal
        Get
            Return _QMTALT
        End Get
        Set(ByVal value As Decimal)
            _QMTALT = value
        End Set
    End Property

    Private _QMTANC As Decimal = 0D 'Ancho(m) 7,2
    Public Property QMTANC() As Decimal
        Get
            Return _QMTANC
        End Get
        Set(ByVal value As Decimal)
            _QMTANC = value
        End Set
    End Property

    Private _HRAREQ As Decimal = 0D 'Hora Req
    Public Property HRAREQ() As Decimal
        Get
            Return _HRAREQ
        End Get
        Set(ByVal value As Decimal)
            _HRAREQ = value
        End Set
    End Property

    Private _HRAREQ_S As String = "" 'Hora Req String
    Public Property HRAREQ_S() As String
        Get
            Return _HRAREQ_S
        End Get
        Set(ByVal value As String)
            _HRAREQ_S = value
        End Set
    End Property




    'Private _FRGTRO As Decimal = 0D 'Fecha registro
    'Public Property FRGTRO() As Decimal
    '    Get
    '        Return _FRGTRO
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FRGTRO = value
    '    End Set
    'End Property

    'Private _FRGTRO_S As String = "" 'Fecha registro String
    'Public Property FRGTRO_S() As String
    '    Get
    '        Return _FRGTRO_S
    '    End Get
    '    Set(ByVal value As String)
    '        _FRGTRO_S = value
    '    End Set
    'End Property

    'Private _HRGTRO As Decimal = 0D 'Hora registro
    'Public Property HRGTRO() As Decimal
    '    Get
    '        Return _HRGTRO
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _HRGTRO = value
    '    End Set
    'End Property

    'Private _HRGTRO_S As String = "" 'Hora registro String
    'Public Property HRGTRO_S() As String
    '    Get
    '        Return _HRGTRO_S
    '    End Get
    '    Set(ByVal value As String)
    '        _HRGTRO_S = value
    '    End Set
    'End Property




    Private _FECREQ As Decimal = 0D 'Fecha Req
    Public Property FECREQ() As Decimal
        Get
            Return _FECREQ
        End Get
        Set(ByVal value As Decimal)
            _FECREQ = value
        End Set
    End Property

    Private _FECREQ_S As String = "" 'Fecha Req String
    Public Property FECREQ_S() As String
        Get
            Return _FECREQ_S
        End Get
        Set(ByVal value As String)
            _FECREQ_S = value
        End Set
    End Property

    Private _UNIDADES As Decimal
    Public Property UNIDADES() As Decimal
        Get
            Return _UNIDADES
        End Get
        Set(ByVal value As Decimal)
            _UNIDADES = value
        End Set
    End Property

    Private _FCHATN As Decimal
    Public Property FCHATN() As Decimal
        Get
            Return _FCHATN
        End Get
        Set(ByVal value As Decimal)
            _FCHATN = value
        End Set
    End Property


    Private _FCHATN_D As String
    Public Property FCHATN_D() As String
        Get
            Return _FCHATN_D
        End Get
        Set(ByVal value As String)
            _FCHATN_D = value
        End Set
    End Property

    Private _HRAATN As Decimal
    Public Property HRAATN() As Decimal
        Get
            Return _HRAATN
        End Get
        Set(ByVal value As Decimal)
            _HRAATN = value
        End Set
    End Property


    Private _HRAATN_D As String
    Public Property HRAATN_D() As String
        Get
            Return _HRAATN_D
        End Get
        Set(ByVal value As String)
            _HRAATN_D = value
        End Set
    End Property





End Class
