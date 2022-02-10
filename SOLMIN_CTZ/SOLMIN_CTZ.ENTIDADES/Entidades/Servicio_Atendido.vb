Public Class Servicio_Atendido
    Private _CCLNT As Double = 0
    Private _NOPRCN As Double = 0
    Private _NRTFSNV As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _QCNESP As Double = 0
    Private _TUNDIT As String = ""
    Private _STPODT As String = ""
    Private _STIPPR As String = ""
    Private _CCLNFC As Double = 0
    Private _QATNAN As Double = 0
    Private _CPRCN1 As String = ""
    Private _NSRCN1 As String = ""
    Private _FOPRCN As Double = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _FLGFAC As String = ""
    Private _NDCFCC As Double = 0
    Private _NSECFC As Double = 0
    Private _TDCFCC As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULASA As String = ""
    Private _FULTAS As Double = 0
    Private _HULTAC As Double = 0
    Private _CMNDA1 As Double = 0
    Private _CPLNDV As Double = 0
    Private _CODVAR As String = ""

    Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property

    Property CMNDA1() As Double
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As Double)
            _CMNDA1 = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property

    Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Double)
            _NOPRCN = value
        End Set
    End Property

    Property NRTFSNV() As Double
        Get
            Return _NRTFSNV
        End Get
        Set(ByVal value As Double)
            _NRTFSNV = value
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

    Property QCNESP() As Double
        Get
            Return _QCNESP
        End Get
        Set(ByVal value As Double)
            _QCNESP = value
        End Set
    End Property

    Property TUNDIT() As String
        Get
            Return _TUNDIT
        End Get
        Set(ByVal value As String)
            _TUNDIT = value
        End Set
    End Property

    Property STPODT() As String
        Get
            Return _STPODT
        End Get
        Set(ByVal value As String)
            _STPODT = value
        End Set
    End Property

    Property STIPPR() As String
        Get
            Return _STIPPR
        End Get
        Set(ByVal value As String)
            _STIPPR = value
        End Set
    End Property

    Property CCLNFC() As Double
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Double)
            _CCLNFC = value
        End Set
    End Property

    Property QATNAN() As String
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As String)
            _QATNAN = value
        End Set
    End Property

    Property CPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal value As String)
            _CPRCN1 = value
        End Set
    End Property

    Property NSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal value As String)
            _NSRCN1 = value
        End Set
    End Property

    Property FOPRCN() As Double
        Get
            Return _FOPRCN
        End Get
        Set(ByVal value As Double)
            _FOPRCN = value
        End Set
    End Property

    Property FECINI() As Double
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Double)
            _FECINI = value
        End Set
    End Property

    Property FECFIN() As Double
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Double)
            _FECFIN = value
        End Set
    End Property

    Property FLGFAC() As String
        Get
            Return _FLGFAC
        End Get
        Set(ByVal value As String)
            _FLGFAC = value
        End Set
    End Property

    Property NDCFCC() As Double
        Get
            Return _NDCFCC
        End Get
        Set(ByVal value As Double)
            _NDCFCC = value
        End Set
    End Property

    Property NSECFC() As Double
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Double)
            _NSECFC = value
        End Set
    End Property


    Property TDCFCC() As String
        Get
            Return _TDCFCC
        End Get
        Set(ByVal value As String)
            _TDCFCC = value
        End Set
    End Property
    Property CODVAR() As String
        Get
            Return _CODVAR
        End Get
        Set(ByVal value As String)
            _CODVAR = value
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

    Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property


    Property FCHCRT() As Double
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Double)
            _FCHCRT = value
        End Set
    End Property

    Property HRACRT() As Double
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Double)
            _HRACRT = value
        End Set
    End Property

    Property CULASA() As String
        Get
            Return _CULASA
        End Get
        Set(ByVal value As String)
            _CULASA = value
        End Set
    End Property

    Property FULTAS() As Double
        Get
            Return _FULTAS
        End Get
        Set(ByVal value As Double)
            _FULTAS = value
        End Set
    End Property

    Property HULTAC() As Double
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Double)
            _HULTAC = value
        End Set
    End Property

    Private _CTPALJ As String
   
    Public Property PSCTPALJ() As String
        Get
            Return _CTPALJ
        End Get
        Set(ByVal value As String)
            _CTPALJ = value
        End Set
    End Property
End Class
