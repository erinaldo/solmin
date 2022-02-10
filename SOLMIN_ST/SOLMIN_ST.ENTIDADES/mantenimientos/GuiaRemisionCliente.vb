Public Class GuiaRemisionCliente
  Private _CCLNT As Double = 0
  Private _NGUIRM As Double = 0
  Private _FGUIRM As Double = 0
  Private _FGUIRM_S As String = ""
  Private _FINTRA As Double = 0
  Private _CPLNOR As Double = 0
  Private _CPLNCL As Double = 0
  Private _CPRVCL As Double = 0
  Private _CPLCLP As Double = 0
  Private _CDPEPL As Double = 0
  Private _CTRSP As Double = 0
  Private _NPLCCM As String = ""
  Private _NPLACP As String = ""
  Private _NBRVCH As String = ""
  Private _SMTGRM As String = ""
  Private _TOBORM As String = ""
  Private _TRFRNC As String = ""
  Private _SSTVAL As String = ""
  Private _TDCFCC As Double = 0
  Private _NDCFCC As Double = 0
  Private _FDCFCC As Double = 0
  Private _TOBSRM As String = ""
  Private _FASNGN As String = ""
  Private _NGUIRO As Double = 0
  Private _NGRMTR As Double = 0
  Private _STRNSM As String = ""
  Private _FTRNSM As Double = 0
  Private _HTRNSM As Double = 0
  Private _NESTDO As Double = 0
  Private _NDCMRF As Double = 0
  Private _TCMPCL As String = ""
  Private _CPRCN1 As String = ""
  Private _NSRCN1 As String = ""
  Private _TTMNCN As Double = 0
  Private _CPRCN2 As String = ""
  Private _NSRCN2 As String = ""
  Private _TTMNCN1 As Double = 0
  Private _FCHCRT As Double = 0
  Private _HRACRT As Double = 0
  Private _CUSCRT As String = ""
  Private _FULTAC As Double = 0
  Private _HULTAC As Double = 0
  Private _CULUSA As String = ""
  Private _SESTRG As String = ""
  Private _NOPRCN As Double = 0
  Private _SMEDTR As String = ""
  Private _SSNCRG As String = ""
  Private _TFNCCR As String = ""
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
  Public Property CCLNT() As Double
    Get
      Return _CCLNT
    End Get
    Set(ByVal Value As Double)
      _CCLNT = Value
    End Set
  End Property

  Public Property NGUIRM() As Double
    Get
      Return _NGUIRM
    End Get
    Set(ByVal Value As Double)
      _NGUIRM = Value
    End Set
  End Property

  Public Property FGUIRM() As Double
    Get
      Return _FGUIRM
    End Get
    Set(ByVal Value As Double)
      _FGUIRM = Value
    End Set
  End Property

  Public Property FGUIRM_S() As String
    Get
      Return _FGUIRM_S
    End Get
    Set(ByVal value As String)
      _FGUIRM_S = value
    End Set
  End Property

  Public Property FINTRA() As Double
    Get
      Return _FINTRA
    End Get
    Set(ByVal Value As Double)
      _FINTRA = Value
    End Set
  End Property

  Public Property CPLNOR() As Double
    Get
      Return _CPLNOR
    End Get
    Set(ByVal Value As Double)
      _CPLNOR = Value
    End Set
  End Property

  Public Property CPLNCL() As Double
    Get
      Return _CPLNCL
    End Get
    Set(ByVal Value As Double)
      _CPLNCL = Value
    End Set
  End Property

  Public Property CPRVCL() As Double
    Get
      Return _CPRVCL
    End Get
    Set(ByVal Value As Double)
      _CPRVCL = Value
    End Set
  End Property

  Public Property CPLCLP() As Double
    Get
      Return _CPLCLP
    End Get
    Set(ByVal Value As Double)
      _CPLCLP = Value
    End Set
  End Property

  Public Property CDPEPL() As Double
    Get
      Return _CDPEPL
    End Get
    Set(ByVal Value As Double)
      _CDPEPL = Value
    End Set
  End Property

  Public Property CTRSP() As Double
    Get
      Return _CTRSP
    End Get
    Set(ByVal Value As Double)
      _CTRSP = Value
    End Set
  End Property

  Public Property NPLCCM() As String
    Get
      Return _NPLCCM
    End Get
    Set(ByVal Value As String)
      _NPLCCM = Value
    End Set
  End Property

  Public Property NPLACP() As String
    Get
      Return _NPLACP
    End Get
    Set(ByVal Value As String)
      _NPLACP = Value
    End Set
  End Property

  Public Property NBRVCH() As String
    Get
      Return _NBRVCH
    End Get
    Set(ByVal Value As String)
      _NBRVCH = Value
    End Set
  End Property

  Public Property SMTGRM() As String
    Get
      Return _SMTGRM
    End Get
    Set(ByVal Value As String)
      _SMTGRM = Value
    End Set
  End Property

  Public Property TOBORM() As String
    Get
      Return _TOBORM
    End Get
    Set(ByVal Value As String)
      _TOBORM = Value
    End Set
  End Property

  Public Property TRFRNC() As String
    Get
      Return _TRFRNC
    End Get
    Set(ByVal Value As String)
      _TRFRNC = Value
    End Set
  End Property

  Public Property SSTVAL() As String
    Get
      Return _SSTVAL
    End Get
    Set(ByVal Value As String)
      _SSTVAL = Value
    End Set
  End Property

  Public Property TDCFCC() As Double
    Get
      Return _TDCFCC
    End Get
    Set(ByVal Value As Double)
      _TDCFCC = Value
    End Set
  End Property

  Public Property NDCFCC() As Double
    Get
      Return _NDCFCC
    End Get
    Set(ByVal Value As Double)
      _NDCFCC = Value
    End Set
  End Property

  Public Property FDCFCC() As Double
    Get
      Return _FDCFCC
    End Get
    Set(ByVal Value As Double)
      _FDCFCC = Value
    End Set
  End Property

  Public Property TOBSRM() As String
    Get
      Return _TOBSRM
    End Get
    Set(ByVal Value As String)
      _TOBSRM = Value
    End Set
  End Property

  Public Property FASNGN() As String
    Get
      Return _FASNGN
    End Get
    Set(ByVal Value As String)
      _FASNGN = Value
    End Set
  End Property

  Public Property NGUIRO() As Double
    Get
      Return _NGUIRO
    End Get
    Set(ByVal Value As Double)
      _NGUIRO = Value
    End Set
  End Property

  Public Property NGRMTR() As Double
    Get
      Return _NGRMTR
    End Get
    Set(ByVal Value As Double)
      _NGRMTR = Value
    End Set
  End Property

  Public Property STRNSM() As String
    Get
      Return _STRNSM
    End Get
    Set(ByVal Value As String)
      _STRNSM = Value
    End Set
  End Property

  Public Property FTRNSM() As Double
    Get
      Return _FTRNSM
    End Get
    Set(ByVal Value As Double)
      _FTRNSM = Value
    End Set
  End Property

  Public Property HTRNSM() As Double
    Get
      Return _HTRNSM
    End Get
    Set(ByVal Value As Double)
      _HTRNSM = Value
    End Set
  End Property

  Public Property NESTDO() As Double
    Get
      Return _NESTDO
    End Get
    Set(ByVal Value As Double)
      _NESTDO = Value
    End Set
  End Property

  Public Property NDCMRF() As Double
    Get
      Return _NDCMRF
    End Get
    Set(ByVal Value As Double)
      _NDCMRF = Value
    End Set
  End Property

  Public Property TCMPCL() As String
    Get
      Return _TCMPCL
    End Get
    Set(ByVal Value As String)
      _TCMPCL = Value
    End Set
  End Property

  Public Property CPRCN1() As String
    Get
      Return _CPRCN1
    End Get
    Set(ByVal Value As String)
      _CPRCN1 = Value
    End Set
  End Property

  Public Property NSRCN1() As String
    Get
      Return _NSRCN1
    End Get
    Set(ByVal Value As String)
      _NSRCN1 = Value
    End Set
  End Property

  Public Property TTMNCN() As Double
    Get
      Return _TTMNCN
    End Get
    Set(ByVal Value As Double)
      _TTMNCN = Value
    End Set
  End Property

  Public Property CPRCN2() As String
    Get
      Return _CPRCN2
    End Get
    Set(ByVal Value As String)
      _CPRCN2 = Value
    End Set
  End Property

  Public Property NSRCN2() As String
    Get
      Return _NSRCN2
    End Get
    Set(ByVal Value As String)
      _NSRCN2 = Value
    End Set
  End Property

  Public Property TTMNCN1() As Double
    Get
      Return _TTMNCN1
    End Get
    Set(ByVal Value As Double)
      _TTMNCN1 = Value
    End Set
  End Property

  Public Property FCHCRT() As Double
    Get
      Return _FCHCRT
    End Get
    Set(ByVal Value As Double)
      _FCHCRT = Value
    End Set
  End Property

  Public Property HRACRT() As Double
    Get
      Return _HRACRT
    End Get
    Set(ByVal Value As Double)
      _HRACRT = Value
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

  Public Property FULTAC() As Double
    Get
      Return _FULTAC
    End Get
    Set(ByVal Value As Double)
      _FULTAC = Value
    End Set
  End Property

  Public Property HULTAC() As Double
    Get
      Return _HULTAC
    End Get
    Set(ByVal Value As Double)
      _HULTAC = Value
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

  Public Property SESTRG() As String
    Get
      Return _SESTRG
    End Get
    Set(ByVal Value As String)
      _SESTRG = Value
    End Set
  End Property

  Public Property NOPRCN() As Double
    Get
      Return _NOPRCN
    End Get
    Set(ByVal Value As Double)
      _NOPRCN = Value
    End Set
  End Property

  Public Property SMEDTR() As String
    Get
      Return _SMEDTR
    End Get
    Set(ByVal Value As String)
      _SMEDTR = Value
    End Set
  End Property

  Public Property SSNCRG() As String
    Get
      Return _SSNCRG
    End Get
    Set(ByVal Value As String)
      _SSNCRG = Value
    End Set
  End Property

  Public Property TFNCCR() As String
    Get
      Return _TFNCCR
    End Get
    Set(ByVal Value As String)
      _TFNCCR = Value
    End Set
  End Property

End Class
