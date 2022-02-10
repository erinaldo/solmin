
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
    Private _CCLNT As Decimal
    Private _CCLNT1 As String
    Private _TRDCCL As String
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
    Private _TCMPCM As String

    Private _SORINC As String
    Private _SNVINC As String

    Private _TSNVINC As String

    Private _NMRGIM As Decimal
    Private _CPLNDV As Decimal

    Private _TPLNTA As String
    Private _MONEDA As String

    Private _NIVEL As String
    Private _REPORTADO As String

    Private _ADJUNTAR As String

    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _SESINC As String

    Private _CARINC As String
    Public Property PSCARINC() As String
        Get
            Return _CARINC
        End Get
        Set(ByVal value As String)
            _CARINC = value
        End Set
    End Property

    Private _TDARINC As String
    Public Property PSTDARINC() As String
        Get
            Return _TDARINC
        End Get
        Set(ByVal value As String)
            _TDARINC = value
        End Set
    End Property

    Private _PSCRGVTA As String
    Public Property PSCRGVTA() As String
        Get
            Return _PSCRGVTA
        End Get
        Set(ByVal value As String)
            _PSCRGVTA = value
        End Set
    End Property

    Private _PSTCRVTA As String
    Public Property PSTCRVTA() As String
        Get
            Return _PSTCRVTA
        End Get
        Set(ByVal value As String)
            _PSTCRVTA = value
        End Set
    End Property

    Public Property PSTSNVINC() As String
        Get
            Return _TSNVINC
        End Get
        Set(ByVal value As String)
            _TSNVINC = value
        End Set
    End Property

    Private _PSTTPINC As String
    Public Property PSTTPINC() As String
        Get
            Return _PSTTPINC
        End Get
        Set(ByVal value As String)
            _PSTTPINC = value
        End Set
    End Property

    Private _PNCTPINC As Decimal
    Public Property PNCTPINC() As Decimal
        Get
            Return _PNCTPINC
        End Get
        Set(ByVal value As Decimal)
            _PNCTPINC = value
        End Set
    End Property

    Private _ESTADO As String
    Public Property PSESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal value As String)
            _ESTADO = value
        End Set
    End Property


    Public Property PSSESINC() As String
        Get
            Return _SESINC
        End Get
        Set(ByVal value As String)
            _SESINC = value
        End Set
    End Property


    Public Property PNFCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Public Property PNHRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Private _FULTAC As Decimal
    Private _HULTAC As Decimal


    Public Property PNFULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Public Property PNHULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property


    Private _MEDIDA As String
    Private _CPLNDV_DES As String


    Public Property PSADJUNTAR() As String
        Get
            Return _ADJUNTAR
        End Get
        Set(ByVal value As String)
            _ADJUNTAR = value
        End Set
    End Property

    Public Property PSCPLNDV_DES() As String
        Get
            Return _CPLNDV_DES
        End Get
        Set(ByVal value As String)
            _CPLNDV_DES = value
        End Set
    End Property

    Public Property PSMEDIDA() As String
        Get
            Return _MEDIDA
        End Get
        Set(ByVal value As String)
            _MEDIDA = value
        End Set
    End Property

    Public Property PSNIVEL() As String
        Get
            Return _NIVEL
        End Get
        Set(ByVal value As String)
            _NIVEL = value
        End Set
    End Property

    Public Property PSREPORTADO() As String
        Get
            Return _REPORTADO
        End Get
        Set(ByVal value As String)
            _REPORTADO = value
        End Set
    End Property

    Public Property PSMONEDA() As String
        Get
            Return _MONEDA
        End Get
        Set(ByVal value As String)
            _MONEDA = value
        End Set
    End Property


    Public Property PSTPLNTA() As String
        Get
            Return _TPLNTA
        End Get
        Set(ByVal value As String)
            _TPLNTA = value
        End Set
    End Property

    Public Property PNCPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property

    Public Property PSSORINC() As String
        Get
            Return _SORINC
        End Get
        Set(ByVal value As String)
            _SORINC = value
        End Set
    End Property


    Private _TSORINC As String
    Public Property PSTSORINC() As String
        Get
            Return _TSORINC
        End Get
        Set(ByVal value As String)
            _TSORINC = value
        End Set
    End Property

    Public Property PSSNVINC() As String
        Get
            Return _SNVINC
        End Get
        Set(ByVal value As String)
            _SNVINC = value
        End Set
    End Property


    Public Property PNNMRGIM() As Decimal
        Get
            Return _NMRGIM
        End Get
        Set(ByVal value As Decimal)
            _NMRGIM = value
        End Set
    End Property

    Public Property PSTCMPCM() As String
        Get
            Return _TCMPCM
        End Get
        Set(ByVal value As String)
            _TCMPCM = value
        End Set
    End Property


    Public Property PSTRDCCL() As String
        Get
            Return _TRDCCL
        End Get
        Set(ByVal value As String)
            _TRDCCL = value
        End Set
    End Property

    Public Property PSTCMPDV() As String
        Get
            Return _TCMPDV
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
            Return _NINCSI
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


    Private _PSTPRVCL As String = ""
    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property


    Private _TDRPCP As String = ""
    Public Property PSTDRPCP() As String
        Get
            Return _TDRPCP
        End Get
        Set(ByVal value As String)
            _TDRPCP = value
        End Set
    End Property


    Private _TMNDA As String = ""
    Public Property PSTMNDA() As String
        Get
            Return _TMNDA
        End Get
        Set(ByVal value As String)
            _TMNDA = value
        End Set
    End Property


    Private _PSTCMPCL As String = ""
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Private _PSEMAIL As String = ""
    Public Property PSEMAIL() As String
        Get
            Return _PSEMAIL
        End Get
        Set(ByVal value As String)
            _PSEMAIL = value
        End Set
    End Property
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
    Private _PSSTIPPR As String
    Public Property PSSTIPPR() As String
        Get
            Return _PSSTIPPR
        End Get
        Set(ByVal value As String)
            _PSSTIPPR = value
        End Set
    End Property

    Private _PSDESDRF As String
    Public Property PSDESDRF() As String
        Get
            Return _PSDESDRF
        End Get
        Set(ByVal value As String)
            _PSDESDRF = value
        End Set
    End Property

    Private _PSDESPRO As String
    Public Property PSDESPRO() As String
        Get
            Return _PSDESPRO
        End Get
        Set(ByVal value As String)
            _PSDESPRO = value
        End Set
    End Property

    Private _PSCSRVC As String
    Public Property PSCSRVC() As String
        Get
            Return _PSCSRVC
        End Get
        Set(ByVal value As String)
            _PSCSRVC = value
        End Set
    End Property

    Private _PNNGUIRN As Decimal
    Public Property PNNGUIRN() As Decimal
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property

    Private _PSNGUICL As String
    Public Property PSNGUICL() As String
        Get
            Return _PSNGUICL
        End Get
        Set(ByVal value As String)
            _PSNGUICL = value
        End Set
    End Property

    Private _PNCDPEPL As Decimal
    Public Property PNCDPEPL() As Decimal
        Get
            Return _PNCDPEPL
        End Get
        Set(ByVal value As Decimal)
            _PNCDPEPL = value
        End Set
    End Property

    Private _PNFRLZSR_INI As String
    Public Property PNFRLZSR_INI() As String
        Get
            Return _PNFRLZSR_INI
        End Get
        Set(ByVal value As String)
            _PNFRLZSR_INI = value
        End Set
    End Property

    Private _PNFRLZSR_FIN As String
    Public Property PNFRLZSR_FIN() As String
        Get
            Return _PNFRLZSR_FIN
        End Get
        Set(ByVal value As String)
            _PNFRLZSR_FIN = value
        End Set
    End Property

    Private _PSTIPDRF As String
    Public Property PSTIPDRF() As String
        Get
            Return _PSTIPDRF
        End Get
        Set(ByVal value As String)
            _PSTIPDRF = value
        End Set
    End Property
    'Campos del DataGrid
    Private _PSTOPMOV As String
    Public Property PSTOPMOV() As String
        Get
            Return _PSTOPMOV
        End Get
        Set(ByVal value As String)
            _PSTOPMOV = value
        End Set
    End Property

    Private _PSFRLZSR As Decimal
    Public Property PSFRLZSR() As Decimal
        Get
            Return _PSFRLZSR
        End Get
        Set(ByVal value As Decimal)
            _PSFRLZSR = value
        End Set
    End Property

    'Private _PSNGUIRN As Decimal
    'Public Property PSNGUIRN() As Decimal
    '    Get
    '        Return _PSNGUIRN
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PSNGUIRN = value
    '    End Set
    'End Property

    Private _PSNORCCL As String
    Public Property PSNORCCL() As String
        Get
            Return _PSNORCCL
        End Get
        Set(ByVal value As String)
            _PSNORCCL = value
        End Set
    End Property

    'Private _PSCDPEPL As Decimal
    'Public Property PSCDPEPL() As Decimal
    '    Get
    '        Return _PSCDPEPL
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PSCDPEPL = value
    '    End Set
    'End Property

    Private _PSNRFTPD As String
    Public Property PSNRFTPD() As String
        Get
            Return _PSNRFTPD
        End Get
        Set(ByVal value As String)
            _PSNRFTPD = value
        End Set
    End Property

    Private _PSNRFRPD As String
    Public Property PSNRFRPD() As String
        Get
            Return _PSNRFRPD
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property
    'END: JDT-Almacén Repuestos On Side - Piura[RF003]-190516

End Class