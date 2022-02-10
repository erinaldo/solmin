''' <summary>
''' Modified: Miguel Dagnino 19/10/2015
''' </summary>
''' <remarks></remarks>
Public Class ProvisionVenta

    Inherits Base(Of ProvisionVenta)
    Private _CCMPN As String
    Private _NMPRVT As Decimal
    Private _ANOMES As Decimal
    Private _CRGVTA As String
    Private _FCHPRV As Decimal
    Private _HRAPRV As Decimal
    Private _SESTRG As String
    Private _CUSCRT As String
    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _CULUSA As String
    Private _FULTAC As Decimal
    Private _HULTAC As Decimal
    Private _NTRMCR As String
    Private _NCRRDT As Decimal
    Private _TPOPER As String
    Private _NOPRCN As Decimal
    Private _NCRROP As Decimal
    Private _NSECFC As Decimal
    Private _FSECFC As Decimal
    Private _CMNDA1 As Decimal
    Private _IVLSRV As Decimal
    Private _ITTPRS As Decimal
    Private _ITPCMT As Decimal
    Private _CCLNFC As Decimal
    Private _CDVSN As String
    Private _CPLNDV As Decimal
    Private _CCNTCS As Decimal
    Private _STSPRV As String
    Private _NMRVVT As Decimal
    Private _FCHRVT As Decimal
    Private _UPDATE_IDENT As Decimal

    Private _CMNDTI As Decimal
    Private _MONEDA_TI As String
    Private _ISRVTI As Decimal
    Private _ITTISL As Decimal
    Private _CCNTBN As Decimal
    Private _CEBE_ORIGEN As String
    Private _CEBE_SAP_ORIGEN As String
    Private _CENCO2 As Decimal
    Private _CECO_ORIGEN As String
    Private _CECO_SAP_ORIGEN As String
    Private _CENCOS As Decimal
    Private _CECO_DESTINO As String
    Private _CECO_SAP_DESTINO As String

    Private _CZNFCC As Decimal
    Private _CGRONG As String
    Private _CTPODC As Decimal
    Private _NDCFCC As Decimal
    Private _FDCFCC As Decimal
    Private _NCRDCC As Decimal

    Public Property ANOMES() As Decimal
        Get
            Return (_ANOMES)
        End Get
        Set(ByVal value As Decimal)
            _ANOMES = value
        End Set
    End Property


    Private _ANIOMES As String
    Public Property ANIOMES() As String
        Get
            Return _ANIOMES
        End Get
        Set(ByVal value As String)
            _ANIOMES = value
        End Set
    End Property

    Public Property CRGVTA() As String
        Get
            Return (_CRGVTA)
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property
    Public Property FCHPRV() As Decimal
        Get
            Return (_FCHPRV)
        End Get
        Set(ByVal value As Decimal)
            _FCHPRV = value
        End Set
    End Property
    Public Property HRAPRV() As Decimal
        Get
            Return (_HRAPRV)
        End Get
        Set(ByVal value As Decimal)
            _HRAPRV = value
        End Set
    End Property

    Private _FECINI As String
    Public Property FECINI() As String
        Get
            Return _FECINI
        End Get
        Set(ByVal value As String)
            _FECINI = value
        End Set
    End Property


    Private _FECFIN As String
    Public Property FECFIN() As String
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As String)
            _FECFIN = value
        End Set
    End Property


    Public Property CCMPN() As String
        Get
            Return (_CCMPN)
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property NMPRVT() As Decimal
        Get
            Return (_NMPRVT)
        End Get
        Set(ByVal value As Decimal)
            _NMPRVT = value
        End Set
    End Property
    Public Property NCRRDT() As Decimal
        Get
            Return (_NCRRDT)
        End Get
        Set(ByVal value As Decimal)
            _NCRRDT = value
        End Set
    End Property
    Public Property TPOPER() As String
        Get
            Return (_TPOPER)
        End Get
        Set(ByVal value As String)
            _TPOPER = value
        End Set
    End Property
    Public Property NOPRCN() As Decimal
        Get
            Return (_NOPRCN)
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property
    Public Property NCRROP() As Decimal
        Get
            Return (_NCRROP)
        End Get
        Set(ByVal value As Decimal)
            _NCRROP = value
        End Set
    End Property


    Private _NCRRGU As Decimal
    Public Property NCRRGU() As Decimal
        Get
            Return _NCRRGU
        End Get
        Set(ByVal value As Decimal)
            _NCRRGU = value
        End Set
    End Property



    Private _NGUITR As Decimal
    Public Property NGUITR() As Decimal
        Get
            Return _NGUITR
        End Get
        Set(ByVal value As Decimal)
            _NGUITR = value
        End Set
    End Property

    Public Property NSECFC() As Decimal
        Get
            Return (_NSECFC)
        End Get
        Set(ByVal value As Decimal)
            _NSECFC = value
        End Set
    End Property
    Public Property FSECFC() As Decimal
        Get
            Return (_FSECFC)
        End Get
        Set(ByVal value As Decimal)
            _FSECFC = value
        End Set
    End Property
    Public Property CMNDA1() As Decimal
        Get
            Return (_CMNDA1)
        End Get
        Set(ByVal value As Decimal)
            _CMNDA1 = value
        End Set
    End Property
    Public Property IVLSRV() As Decimal
        Get
            Return (_IVLSRV)
        End Get
        Set(ByVal value As Decimal)
            _IVLSRV = value
        End Set
    End Property
    Public Property ITTPRS() As Decimal
        Get
            Return (_ITTPRS)
        End Get
        Set(ByVal value As Decimal)
            _ITTPRS = value
        End Set
    End Property
    Public Property ITPCMT() As Decimal
        Get
            Return (_ITPCMT)
        End Get
        Set(ByVal value As Decimal)
            _ITPCMT = value
        End Set
    End Property
    Public Property CCLNFC() As Decimal
        Get
            Return (_CCLNFC)
        End Get
        Set(ByVal value As Decimal)
            _CCLNFC = value
        End Set
    End Property
    Public Property CDVSN() As String
        Get
            Return (_CDVSN)
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property CPLNDV() As Decimal
        Get
            Return (_CPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property
    Public Property CCNTCS() As Decimal
        Get
            Return (_CCNTCS)
        End Get
        Set(ByVal value As Decimal)
            _CCNTCS = value
        End Set
    End Property

    Private _NLQDCN As Decimal
    Public Property NLQDCN() As Decimal
        Get
            Return _NLQDCN
        End Get
        Set(ByVal value As Decimal)
            _NLQDCN = value
        End Set
    End Property


    Private _CMNDPG As Decimal
    Public Property CMNDPG() As Decimal
        Get
            Return _CMNDPG
        End Get
        Set(ByVal value As Decimal)
            _CMNDPG = value
        End Set
    End Property


    Private _IMPPGO As Decimal
    Public Property IMPPGO() As Decimal
        Get
            Return _IMPPGO
        End Get
        Set(ByVal value As Decimal)
            _IMPPGO = value
        End Set
    End Property


    Private _ITPGSL As Decimal
    Public Property ITPGSL() As Decimal
        Get
            Return _ITPGSL
        End Get
        Set(ByVal value As Decimal)
            _ITPGSL = value
        End Set
    End Property


    Private _SESTOP As String
    Public Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property


    Private _CSRVC As Decimal
    Public Property CSRVC() As Decimal
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As Decimal)
            _CSRVC = value
        End Set
    End Property



    Public Property STSPRV() As String
        Get
            Return (_STSPRV)
        End Get
        Set(ByVal value As String)
            _STSPRV = value
        End Set
    End Property
    Public Property NMRVVT() As Decimal
        Get
            Return (_NMRVVT)
        End Get
        Set(ByVal value As Decimal)
            _NMRVVT = value
        End Set
    End Property
    Public Property FCHRVT() As Decimal
        Get
            Return (_FCHRVT)
        End Get
        Set(ByVal value As Decimal)
            _FCHRVT = value
        End Set
    End Property
    Public Property SESTRG() As String
        Get
            Return (_SESTRG)
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property
    Public Property CUSCRT() As String
        Get
            Return (_CUSCRT)
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property
    Public Property FCHCRT() As Decimal
        Get
            Return (_FCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property
    Public Property HRACRT() As Decimal
        Get
            Return (_HRACRT)
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return (_CULUSA)
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Public Property FULTAC() As Decimal
        Get
            Return (_FULTAC)
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property
    Public Property HULTAC() As Decimal
        Get
            Return (_HULTAC)
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property
    Public Property NTRMCR() As String
        Get
            Return (_NTRMCR)
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property
    Public Property UPDATE_IDENT() As Decimal
        Get
            Return (_UPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _UPDATE_IDENT = value
        End Set
    End Property


    Private _CHk As Boolean = True
    Public Property CHK() As Boolean
        Get
            Return _CHk
        End Get
        Set(ByVal value As Boolean)
            _CHk = value
        End Set
    End Property


    Private _ESTADO As String
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal value As String)
            _ESTADO = value
        End Set
    End Property

    Private _DIVISION As String
    Public Property DIVISION() As String
        Get
            Return _DIVISION
        End Get
        Set(ByVal value As String)
            _DIVISION = value
        End Set
    End Property


    Private _TPLNTA As String
    Public Property TPLNTA() As String
        Get
            Return _TPLNTA
        End Get
        Set(ByVal value As String)
            _TPLNTA = value
        End Set
    End Property



    Private _CCLNT As Decimal
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property


    Private _CLI_OPE As String
    Public Property CLI_OPE() As String
        Get
            Return _CLI_OPE
        End Get
        Set(ByVal value As String)
            _CLI_OPE = value
        End Set
    End Property


    Private _CLI_FAC As String
    Public Property CLI_FAC() As String
        Get
            Return _CLI_FAC
        End Get
        Set(ByVal value As String)
            _CLI_FAC = value
        End Set
    End Property


    Private _FEC_SECF As String
    Public Property FEC_SECF() As String
        Get
            Return _FEC_SECF
        End Get
        Set(ByVal value As String)
            _FEC_SECF = value
        End Set
    End Property


    Private _NOMSER As String
    Public Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            _NOMSER = value
        End Set
    End Property

    Private _FATNSR As String
    Public Property FATNSR() As String
        Get
            Return _FATNSR
        End Get
        Set(ByVal value As String)
            _FATNSR = value
        End Set
    End Property



    Private _QATNAN As Decimal
    Public Property QATNAN() As Decimal
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Decimal)
            _QATNAN = value
        End Set
    End Property


    Private _CUNDMD As String
    Public Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property


    Private _TSGNMN As String
    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            _TSGNMN = value
        End Set
    End Property

    Private _MONTO As Decimal
    Public Property MONTO() As Decimal
        Get
            Return _MONTO
        End Get
        Set(ByVal value As Decimal)
            _MONTO = value
        End Set
    End Property


    Private _CCNBNS As String
    Public Property CCNBNS() As String
        Get
            Return _CCNBNS
        End Get
        Set(ByVal value As String)
            _CCNBNS = value
        End Set
    End Property


    Private _TCNTCS As String
    Public Property TCNTCS() As String
        Get
            Return _TCNTCS
        End Get
        Set(ByVal value As String)
            _TCNTCS = value
        End Set
    End Property
    Public Property CMNDTI() As Decimal
        Get
            Return _CMNDTI
        End Get
        Set(ByVal value As Decimal)
            _CMNDTI = value
        End Set
    End Property
    Public Property MONEDA_TI() As String
        Get
            Return _MONEDA_TI
        End Get
        Set(ByVal value As String)
            _MONEDA_TI = value
        End Set
    End Property
    Public Property ISRVTI() As Decimal
        Get
            Return _ISRVTI
        End Get
        Set(ByVal value As Decimal)
        End Set
    End Property
    Public Property ITTISL() As Decimal
        Get
            Return _ITTISL
        End Get
        Set(ByVal value As Decimal)
            _ITTISL = value
        End Set
    End Property
    Public Property CCNTBN() As Decimal
        Get
            Return _CCNTBN
        End Get
        Set(ByVal value As Decimal)
            _CCNTBN = value
        End Set
    End Property
    Public Property CEBE_ORIGEN() As String
        Get
            Return _CEBE_ORIGEN
        End Get
        Set(ByVal value As String)
            _CEBE_ORIGEN = value
        End Set
    End Property
    Public Property CEBE_SAP_ORIGEN() As String
        Get
            Return _CEBE_SAP_ORIGEN
        End Get
        Set(ByVal value As String)
            _CEBE_SAP_ORIGEN = value
        End Set
    End Property
    Public Property CENCO2() As Decimal
        Get
            Return _CENCO2
        End Get
        Set(ByVal value As Decimal)
            _CENCO2 = value
        End Set
    End Property
    Public Property CECO_ORIGEN() As String
        Get
            Return _CECO_ORIGEN
        End Get
        Set(ByVal value As String)
            _CECO_ORIGEN = value
        End Set
    End Property
    Public Property CECO_SAP_ORIGEN() As String
        Get
            Return _CECO_SAP_ORIGEN
        End Get
        Set(ByVal value As String)
            _CECO_SAP_ORIGEN = value
        End Set
    End Property
    Public Property CENCOS() As Decimal
        Get
            Return _CENCOS
        End Get
        Set(ByVal value As Decimal)
            _CENCOS = value
        End Set
    End Property
    Public Property CECO_DESTINO() As String
        Get
            Return _CECO_DESTINO
        End Get
        Set(ByVal value As String)
            _CECO_DESTINO = value
        End Set
    End Property
    Public Property CECO_SAP_DESTINO() As String
        Get
            Return _CECO_SAP_DESTINO
        End Get
        Set(ByVal value As String)
            _CECO_SAP_DESTINO = value
        End Set
    End Property

    Public Property CZNFCC() As Decimal
        Get
            Return _CZNFCC
        End Get
        Set(ByVal value As Decimal)
            _CZNFCC = value
        End Set
    End Property

    Public Property CGRONG() As String
        Get
            Return _CGRONG
        End Get
        Set(ByVal value As String)
            _CGRONG = value
        End Set
    End Property

    Public Property CTPODC() As Decimal
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As Decimal)
            _CTPODC = value
        End Set
    End Property
    Public Property NDCFCC() As Decimal
        Get
            Return _NDCFCC
        End Get
        Set(ByVal value As Decimal)
            _NDCFCC = value
        End Set
    End Property

    Public Property FDCFCC() As Decimal
        Get
            Return _FDCFCC
        End Get
        Set(ByVal value As Decimal)
            _FDCFCC = value
        End Set
    End Property
    Public Property NCRDCC() As Decimal
        Get
            Return _NCRDCC
        End Get
        Set(ByVal value As Decimal)
            _NCRDCC = value
        End Set
    End Property


    'CSR-HUNDRED-hotfix/281016_Proceso_De_Venta-inicio
    Private _NORINS As Decimal
    Public Property NORINS() As Decimal
        Get
            Return (_NORINS)
        End Get
        Set(ByVal value As Decimal)
            _NORINS = value
        End Set
    End Property

    'CSR-HUNDRED-hotfix/281016_Proceso_De_Venta-fin
End Class
