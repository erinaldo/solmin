
Public Class beIncidencias
    Inherits beBase(Of beIncidencias)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub


    Private _CCMPN As String
    Private _NINCSI As Decimal
    Private _FRGTRO As Decimal
    Private _FRGTRO1 As String
    Private _HRGTRO As Decimal
    Private _CINCID As Decimal
    Private _CDVSN As String
    Private _CCLNT As Decimal
    Private _CCLNT1 As String
    Private _TINCDT As String
    Private _CTPALM As String
    Private _CALMC As String
    Private _CZNALM As String
    Private _CPRVCL As Decimal
    Private _CPLCLP As Decimal
    Private _QAINSM As Decimal
    Private _CUNDCN As String
    Private _ICSTOS As Decimal
    Private _CDMNDA As Decimal
    Private _TIRALC As String
    Private _PRSCNT As String
    Private _SESTRG As String
    Private _NTRMNL As String
    Private _ANIO As Integer
    Private _HoraRegistro As String
    Private _TCMPDV As String

    Public Property PSTCMPDV() As String
        Get
            Return (_TCMPDV)
        End Get
        Set(ByVal value As String)
            _TCMPDV = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return (_CCMPN)
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property ANIO() As Integer
        Get
            Return (_ANIO)
        End Get
        Set(ByVal value As Integer)
            _ANIO = value
        End Set
    End Property

    Public Property PNNINCSI() As Decimal
        Get
            Return (_NINCSI)
        End Get
        Set(ByVal value As Decimal)
            _NINCSI = value
        End Set
    End Property
    Public Property PNFRGTRO() As Decimal
        Get
            Return (_FRGTRO)
        End Get
        Set(ByVal value As Decimal)
            _FRGTRO = value
        End Set
    End Property

    Public Property PSFRGTRO1() As String
        Get
            Return (_FRGTRO1)
        End Get
        Set(ByVal value As String)
            _FRGTRO1 = value
        End Set
    End Property

    Public Property PNHRGTRO() As Decimal
        Get
            'Return CtypeHour(_HoraRegistro)
            Return Hora_Decimal(_HoraRegistro)
        End Get
        Set(ByVal value As Decimal)
            _HoraRegistro = Decimal_Hora(value)
            '_HoraRegistro = NumeroAHora(value)
        End Set
    End Property
    Public Property PNCINCID() As Decimal
        Get
            Return (_CINCID)
        End Get
        Set(ByVal value As Decimal)
            _CINCID = value
        End Set
    End Property


    Private _PSTINCSI As String
    Public Property PSTINCSI() As String
        Get
            Return _PSTINCSI
        End Get
        Set(ByVal value As String)
            _PSTINCSI = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return (_CDVSN)
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return (_CCLNT)
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public Property PSCCLNT1() As String
        Get
            Return (_CCLNT1)
        End Get
        Set(ByVal value As String)
            _CCLNT1 = value
        End Set
    End Property


    Private _PNFECINI As Decimal
    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property


    Private _PNFECFIN As Decimal
    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property


 
    Public Property FechaRegistro() As String
        Get
            Return NumeroAFecha(_FRGTRO)
        End Get
        Set(ByVal value As String)
            _FRGTRO = CtypeDate(value)
        End Set
    End Property

 
    Public Property HoraRegistro() As String
        Get
            Return _HoraRegistro
        End Get
        Set(ByVal value As String)
            _HoraRegistro = value
        End Set
    End Property


    Public Property PSTINCDT() As String
        Get
            Return (_TINCDT)
        End Get
        Set(ByVal value As String)
            _TINCDT = value
        End Set
    End Property
    Public Property PSCTPALM() As String
        Get
            Return (_CTPALM)
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_CALMC)
        End Get
        Set(ByVal value As String)
            _CALMC = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            Return (_CZNALM)
        End Get
        Set(ByVal value As String)
            _CZNALM = value
        End Set
    End Property
    Public Property PNCPRVCL() As Decimal
        Get
            Return (_CPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _CPRVCL = value
        End Set
    End Property
    Public Property PNCPLCLP() As Decimal
        Get
            Return (_CPLCLP)
        End Get
        Set(ByVal value As Decimal)
            _CPLCLP = value
        End Set
    End Property
    Public Property PNQAINSM() As Decimal
        Get
            Return (_QAINSM)
        End Get
        Set(ByVal value As Decimal)
            _QAINSM = value
        End Set
    End Property
    Public Property PSCUNDCN() As String
        Get
            Return (_CUNDCN)
        End Get
        Set(ByVal value As String)
            _CUNDCN = value
        End Set
    End Property
    Public Property PNICSTOS() As Decimal
        Get
            Return (_ICSTOS)
        End Get
        Set(ByVal value As Decimal)
            _ICSTOS = value
        End Set
    End Property
    Public Property PNCDMNDA() As Decimal
        Get
            Return (_CDMNDA)
        End Get
        Set(ByVal value As Decimal)
            _CDMNDA = value
        End Set
    End Property
    Public Property PSTIRALC() As String
        Get
            Return (_TIRALC)
        End Get
        Set(ByVal value As String)
            _TIRALC = value
        End Set
    End Property
    Public Property PSPRSCNT() As String
        Get
            Return (_PRSCNT)
        End Get
        Set(ByVal value As String)
            _PRSCNT = value
        End Set
    End Property


    Private _PSTALMC As String
    Public Property PSTALMC() As String
        Get
            Return _PSTALMC
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property


    Private _PSTCMPAL As String
    Public Property PSTCMPAL() As String
        Get
            Return _PSTCMPAL
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property


    Private _TCMZNA As String
    Public Property PSTCMZNA() As String
        Get
            Return _TCMZNA
        End Get
        Set(ByVal value As String)
            _TCMZNA = value
        End Set
    End Property


    Private _PSTPRVCL As String
    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property


    Private _TDRPCP As String
    Public Property PSTDRPCP() As String
        Get
            Return _TDRPCP
        End Get
        Set(ByVal value As String)
            _TDRPCP = value
        End Set
    End Property


    Private _TMNDA As String
    Public Property PSTMNDA() As String
        Get
            Return _TMNDA
        End Get
        Set(ByVal value As String)
            _TMNDA = value
        End Set
    End Property


    Private _PSTCMPCL As String
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property



End Class