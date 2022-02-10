Public Class beSeguimiento
    Inherits beBase(Of beSeguimiento)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub


    Private _CCMPN As String = ""
    Private _NINCSI As Decimal = 0D
    Private _FRGTRO As Decimal = 0D
    Private _FRGTRO1 As String = ""
    Private _HRGTRO As Decimal = 0D
    Private _CINCID As Decimal = 0D
    Private _CDVSN As String = ""
    Private _CCLNT As Decimal = 0D
    Private _CCLNT1 As String = ""
    Private _TRDCCL As String = ""
    Private _TINCDT As String = ""
    Private _CTPALM As String = ""
    Private _CALMC As String = ""
    Private _CZNALM As String = ""
    Private _CPRVCL As Decimal = 0D
    Private _CPLCLP As Decimal = 0D
    Private _QAINSM As Decimal = 0D
    Private _CUNDCN As String = ""
    Private _ICSTOS As Decimal = 0D
    Private _CDMNDA As Decimal = 0D
    Private _TIRALC As String = ""
    Private _PRSCNT As String = ""
    Private _SESTRG As String = ""
    Private _NTRMNL As String = ""
    Private _ANIO As Integer = 0
    Private _HoraRegistro As String = ""
    Private _TCMPDV As String = ""
    Private _TCMPCM As String = ""

    Private _SORINC As String = ""
    Private _SNVINC As String = ""
    Private _NMRGIM As Decimal = 0D
    Private _CPLNDV As Decimal = 0D

    Private _TPLNTA As String = ""
    Private _MONEDA As String = ""

    Private _NIVEL As String = ""
    Private _REPORTADO As String = ""

    Private _ADJUNTAR As String = ""

    Private _FCHCRT As Decimal = 0D
    Private _HRACRT As Decimal = 0D

    Private _SESINC As String = ""

    Private _ESTADO As String = ""


    Private _SACPINC As String = ""
    Public Property PSSACPINC() As String
        Get
            Return _SACPINC
        End Get
        Set(ByVal value As String)
            _SACPINC = value
        End Set
    End Property


    Private _SACCINC As String = ""
    Public Property PSSACCINC() As String
        Get
            Return _SACCINC
        End Get
        Set(ByVal value As String)
            _SACCINC = value
        End Set
    End Property


    Private _SCLINC As String = ""
    Public Property PSSCLINC() As String
        Get
            Return _SCLINC
        End Get
        Set(ByVal value As String)
            _SCLINC = value
        End Set
    End Property


    Private _TOBRES2 As String = ""
    Public Property PSTOBRES2() As String
        Get
            Return _TOBRES2
        End Get
        Set(ByVal value As String)
            _TOBRES2 = value
        End Set
    End Property

    Private _CARINC As String = ""
    Public Property PSCARINC() As String
        Get
            Return _CARINC
        End Get
        Set(ByVal value As String)
            _CARINC = value
        End Set
    End Property


    Private _TDARINC As String = ""
    Public Property PSTDARINC() As String
        Get
            Return _TDARINC
        End Get
        Set(ByVal value As String)
            _TDARINC = value
        End Set
    End Property


    Private _PSCRGVTA As String = ""
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

    Private _FCH_2_1 As String

    Public Property PNFCH_2_1() As String
        Get
            Return _FCH_2_1
        End Get
        Set(ByVal value As String)
            _FCH_2_1 = value
        End Set
    End Property

    Private _FCH_3_2 As String

    Public Property PNFCH_3_2() As String
        Get
            Return _FCH_3_2
        End Get
        Set(ByVal value As String)
            _FCH_3_2 = value
        End Set
    End Property

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

    '------------------ NUEVOS ---------------------------

    Private _STPSLC As String
    Public Property PSSTPSLC() As String
        Get
            Return _STPSLC
        End Get
        Set(ByVal value As String)
            _STPSLC = value
        End Set
    End Property

    Private _TSOLUC As String
    Public Property PSTSOLUC() As String
        Get
            Return _TSOLUC
        End Get
        Set(ByVal value As String)
            _TSOLUC = value
        End Set
    End Property

    Private _FCHRVI As Decimal
    Public Property PNFCHRVI() As Decimal
        Get
            Return _FCHRVI
        End Get
        Set(ByVal value As Decimal)
            _FCHRVI = value
        End Set
    End Property

    Private _FCHREVISION As String
    Public Property PSFCHREVISION() As String
        Get
            Return _FCHREVISION
        End Get
        Set(ByVal value As String)
            _FCHREVISION = value
        End Set
    End Property

    Private _HRARVI As Decimal
    Public Property PNHRARVI() As Decimal
        Get
            Return _HRARVI
        End Get
        Set(ByVal value As Decimal)
            _HRARVI = value
        End Set
    End Property

    Private _HRAREVISION As String
    Public Property PSHRAREVISION() As String
        Get
            Return _HRAREVISION
        End Get
        Set(ByVal value As String)
            _HRAREVISION = value
        End Set
    End Property

    Private _CUSEVI As String
    Public Property PSCUSEVI() As String
        Get
            Return _CUSEVI
        End Get
        Set(ByVal value As String)
            _CUSEVI = value
        End Set
    End Property

    Private _TOBRES As String
    Public Property PSTOBRES() As String
        Get
            Return _TOBRES
        End Get
        Set(ByVal value As String)
            _TOBRES = value
        End Set
    End Property

    '------------------------------------------------------------

    Private _CDASCI As String
    Public Property PSCDASCI() As String
        Get
            Return _CDASCI
        End Get
        Set(ByVal value As String)
            _CDASCI = value
        End Set
    End Property

    Private _CASUMIDO As String
    Public Property PSCASUMIDO() As String
        Get
            Return _CASUMIDO
        End Get
        Set(ByVal value As String)
            _CASUMIDO = value
        End Set
    End Property

    Private _PRCASC As Decimal
    Public Property PNPRCASC() As Decimal
        Get
            Return _PRCASC
        End Get
        Set(ByVal value As Decimal)
            _PRCASC = value
        End Set
    End Property

    Private _HRATRI As Decimal
    Public Property PNHRATRI() As Decimal
        Get
            Return _HRATRI
        End Get
        Set(ByVal value As Decimal)
            _HRATRI = value
        End Set
    End Property

    Private _HRACONCLUIDO As String
    Public Property PSHRACONCLUIDO() As String
        Get
            Return _HRACONCLUIDO
        End Get
        Set(ByVal value As String)
            _HRACONCLUIDO = value
        End Set
    End Property

    Private _FCHTRI As Decimal
    Public Property PNFCHTRI() As Decimal
        Get
            Return _FCHTRI
        End Get
        Set(ByVal value As Decimal)
            _FCHTRI = value
        End Set
    End Property

    Private _FCHCONCLUIDO As String
    Public Property PSFCHCONCLUIDO() As String
        Get
            Return _FCHCONCLUIDO
        End Get
        Set(ByVal value As String)
            _FCHCONCLUIDO = value
        End Set
    End Property

    Private _NMRGIA As Decimal
    Public Property PNNMRGIA() As Decimal
        Get
            Return _NMRGIA
        End Get
        Set(ByVal value As Decimal)
            _NMRGIA = value
        End Set
    End Property

    '-------------------------------------------------------------

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
