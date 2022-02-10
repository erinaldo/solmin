
Namespace Operaciones
  Public Class ValeCombustible

#Region "Atributo"
    Private _NRSCVL As Double = 0
    Private _FECSLC As Double = 0
    Private _FECSLC_S As String = ""
    Private _NRVLGR As Double = 0
    Private _FCVALE As Double = 0
    Private _FCVALE_S As String = ""
    Private _CTPCMB As String = ""
    Private _TDSCMB As String = ""
    Private _QGLNSL As Double = 0
    Private _QGLNVL As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _CCNTCS As Double = 0
    Private _TCNTCS As String = ""
    Private _STPVHT As String = ""
    Private _CTRSPT As Double = 0
    Private _NRUCTR As String = ""
    Private _TCMTRT As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _NPLVEH As String = ""
    Private _NCRTRC As Double = 0
    Private _SSVLCM As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _USRCRT As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _SESTRG As String = ""
    Private _FECFIN As String = ""
    Private _FECINI As String = ""
    Private _NLQCMB As Double = 0
    Private _FLQDCN_S As String = ""
    Private _RUTA As String = ""
    Private _NOPRCN As Double = 0
    Private _NORSRT As Double = 0
    Private _TOBSCR As String = ""
    Private _CLCLOR As Double = 0
        Private _CLCLDS As Double = 0
        Private _FLQDCN As Double = 0

        Private _NSLCMB As Decimal = 0
        Private _FSLCMB As String = ""
        Private _CTPOD1 As Decimal = 0
        Private _NDCCT1 As Decimal = 0
        Private _FDCCT1 As String = ""
        Private _QGLNCM As Decimal = 0
        Private _CSTGLN As Decimal = 0
        Private _NPRCN1 As String = ""
        Private _NPRCN2 As String = ""
        Private _NPRCN3 As String = ""
        Private _FCHLQD As String = ""
        Private _HRALQD As String = ""
        Private _USRLQD As String = ""

        Private _CGRFO As Decimal = 0
        Private _FCRCMB As String = ""
        Private _NVLGRF As Decimal = 0

        Private _NPLCUN As String = ""
        Private _NKMRCR As Double = 0
        Private _NURRCR As Double = 0
        Private _NRNDUR As Double = 0
        Private _NRNDPRC As Double = 0
        Private _NRITEM As Decimal = 0
        Private _CSTRGL As Decimal = 0
        Private _CMNDA1 As Decimal = 0
        Private _NVLGRS As String = ""
        Private _NDCCTS As String = ""
        Public NRITEMO As Decimal = 0

#End Region

#Region "Properties"

    Public Property NRSCVL() As Double
      Get
        Return (_NRSCVL)
      End Get
      Set(ByVal value As Double)
        _NRSCVL = value
      End Set
    End Property

    Public Property FECSLC() As Double
      Get
        Return (_FECSLC)
      End Get
      Set(ByVal value As Double)
        _FECSLC = value
      End Set
    End Property

    Public Property FECSLC_S() As String
      Get
        Return (_FECSLC_S)
      End Get
      Set(ByVal value As String)
        _FECSLC_S = value
      End Set
    End Property

    Public Property NRVLGR() As Double
      Get
        Return (_NRVLGR)
      End Get
      Set(ByVal value As Double)
        _NRVLGR = value
      End Set
    End Property

    Public Property FCVALE() As Double
      Get
        Return (_FCVALE)
      End Get
      Set(ByVal value As Double)
        _FCVALE = value
      End Set
    End Property

    Public Property FCVALE_S() As String
      Get
        Return _FCVALE_S
      End Get
      Set(ByVal value As String)
        _FCVALE_S = value
      End Set
    End Property

    Public Property CTPCMB() As String
      Get
        Return (_CTPCMB)
      End Get
      Set(ByVal value As String)
        _CTPCMB = value
      End Set
    End Property

    Public Property TDSCMB()
      Get
        Return _TDSCMB
      End Get
      Set(ByVal value)
        _TDSCMB = value
      End Set
    End Property

    Public Property QGLNSL() As Double
      Get
        Return (_QGLNSL)
      End Get
      Set(ByVal value As Double)
        _QGLNSL = value
      End Set
    End Property

    Public Property QGLNVL() As Double
      Get
        Return (_QGLNVL)
      End Get
      Set(ByVal value As Double)
        _QGLNVL = value
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

    Public Property CDVSN() As String
      Get
        Return (_CDVSN)
      End Get
      Set(ByVal value As String)
        _CDVSN = value
      End Set
    End Property

    Public Property CPLNDV() As Double
      Get
        Return (_CPLNDV)
      End Get
      Set(ByVal value As Double)
        _CPLNDV = value
      End Set
    End Property

    Public Property CCNTCS() As Double
      Get
        Return (_CCNTCS)
      End Get
      Set(ByVal value As Double)
        _CCNTCS = value
      End Set
    End Property

    Public Property TCNTCS() As String
      Get
        Return _TCNTCS
      End Get
      Set(ByVal value As String)
        _TCNTCS = value
      End Set
    End Property

    Public Property STPVHT() As String
      Get
        Return (_STPVHT)
      End Get
      Set(ByVal value As String)
        _STPVHT = value
      End Set
    End Property

    Public Property CTRSPT() As Double
      Get
        Return (_CTRSPT)
      End Get
      Set(ByVal value As Double)
        _CTRSPT = value
      End Set
    End Property

    Public Property NRUCTR() As String
      Get
        Return _NRUCTR
      End Get
      Set(ByVal value As String)
        _NRUCTR = value
      End Set
    End Property

    Public Property TCMTRT() As String
      Get
        Return _TCMTRT
      End Get
      Set(ByVal value As String)
        _TCMTRT = value
      End Set
    End Property

    Public Property CBRCNT() As String
      Get
        Return (_CBRCNT)
      End Get
      Set(ByVal value As String)
        _CBRCNT = value
      End Set
    End Property

    Public Property CBRCND() As String
      Get
        Return _CBRCND
      End Get
      Set(ByVal value As String)
        _CBRCND = value
      End Set
    End Property

    Public Property NPLVEH() As String
      Get
        Return (_NPLVEH)
      End Get
      Set(ByVal value As String)
        _NPLVEH = value
      End Set
    End Property

    Public Property NCRTRC() As Double
      Get
        Return (_NCRTRC)
      End Get
      Set(ByVal value As Double)
        _NCRTRC = value
      End Set
    End Property

    Public Property SSVLCM() As String
      Get
        Return (_SSVLCM)
      End Get
      Set(ByVal value As String)
        _SSVLCM = value
      End Set
    End Property

    Public Property FCHCRT() As Double
      Get
        Return (_FCHCRT)
      End Get
      Set(ByVal value As Double)
        _FCHCRT = value
      End Set
    End Property

    Public Property HRACRT() As Double
      Get
        Return (_HRACRT)
      End Get
      Set(ByVal value As Double)
        _HRACRT = value
      End Set
    End Property

    Public Property USRCRT() As String
      Get
        Return (_USRCRT)
      End Get
      Set(ByVal value As String)
        _USRCRT = value
      End Set
    End Property

    Public Property FULTAC() As Double
      Get
        Return (_FULTAC)
      End Get
      Set(ByVal value As Double)
        _FULTAC = value
      End Set
    End Property

    Public Property HULTAC() As Double
      Get
        Return (_HULTAC)
      End Get
      Set(ByVal value As Double)
        _HULTAC = value
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

    Public Property NTRMNL() As String
      Get
        Return (_NTRMNL)
      End Get
      Set(ByVal value As String)
        _NTRMNL = value
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

    Public Property FECFIN() As String
      Get
        Return _FECFIN
      End Get
      Set(ByVal value As String)
        _FECFIN = value
      End Set
    End Property

    Public Property FECINI() As String
      Get
        Return _FECINI
      End Get
      Set(ByVal value As String)
        _FECINI = value
      End Set
    End Property

    Public Property NLQCMB() As Double
      Get
        Return _NLQCMB
      End Get
      Set(ByVal value As Double)
        _NLQCMB = value
      End Set
    End Property

    Public Property FLQDCN_S() As String
      Get
        Return _FLQDCN_S
      End Get
      Set(ByVal value As String)
        _FLQDCN_S = value
      End Set
    End Property

    Public Property RUTA() As String
      Get
        Return _RUTA
      End Get
      Set(ByVal value As String)
        _RUTA = value
      End Set
    End Property

    Public Property NOPRCN() As Double
      Get
        Return _NOPRCN
      End Get
      Set(ByVal value As Double)
        _NOPRCN = value
      End Set
    End Property

    Public Property NORSRT() As Double
      Get
        Return _NORSRT
      End Get
      Set(ByVal value As Double)
        _NORSRT = value
      End Set
    End Property

    Public Property TOBSCR() As String
      Get
        Return _TOBSCR
      End Get
      Set(ByVal value As String)
        _TOBSCR = value
      End Set
    End Property

    Public Property CLCLOR() As Double
      Get
        Return _CLCLOR
      End Get
      Set(ByVal value As Double)
        _CLCLOR = value
      End Set
    End Property

    Public Property CLCLDS() As Double
      Get
        Return _CLCLDS
      End Get
      Set(ByVal value As Double)
        _CLCLDS = value
      End Set
        End Property

        Public Property FLQDCN() As Double
            Get
                Return _FLQDCN
            End Get
            Set(ByVal value As Double)
                _FLQDCN = value
            End Set
        End Property

        Public Property NSLCMB() As Double
            Get
                Return _NSLCMB
            End Get
            Set(ByVal value As Double)
                _NSLCMB = value
            End Set
        End Property

        Public Property FSLCMB() As String
            Get
                Return _FSLCMB
            End Get
            Set(ByVal value As String)
                _FSLCMB = value
            End Set
        End Property


        Public Property CTPOD1() As Decimal
            Get
                Return _CTPOD1
            End Get
            Set(ByVal value As Decimal)
                _CTPOD1 = value
            End Set
        End Property


        Public Property NDCCT1() As Decimal
            Get
                Return _NDCCT1
            End Get
            Set(ByVal value As Decimal)
                _NDCCT1 = value
            End Set
        End Property

        Public Property FDCCT1() As String
            Get
                Return _FDCCT1
            End Get
            Set(ByVal value As String)
                _FDCCT1 = value
            End Set
        End Property

        Public Property QGLNCM() As Decimal
            Get
                Return _QGLNCM
            End Get
            Set(ByVal value As Decimal)
                _QGLNCM = value
            End Set
        End Property

        Public Property CSTGLN() As Decimal
            Get
                Return _CSTGLN
            End Get
            Set(ByVal value As Decimal)
                _CSTGLN = value
            End Set
        End Property


        Public Property NPRCN1() As String
            Get
                Return _NPRCN1
            End Get
            Set(ByVal value As String)
                _NPRCN1 = value
            End Set
        End Property
        Public Property NPRCN2() As String
            Get
                Return _NPRCN2
            End Get
            Set(ByVal value As String)
                _NPRCN2 = value
            End Set
        End Property

        Public Property NPRCN3() As String
            Get
                Return _NPRCN3
            End Get
            Set(ByVal value As String)
                _NPRCN3 = value
            End Set
        End Property

        Public Property FCHLQD() As String
            Get
                Return _FCHLQD
            End Get
            Set(ByVal value As String)
                _FCHLQD = value
            End Set
        End Property
        Public Property HRALQD() As String
            Get
                Return _HRALQD
            End Get
            Set(ByVal value As String)
                _HRALQD = value
            End Set
        End Property

        Public Property USRLQD() As String
            Get
                Return _USRLQD
            End Get
            Set(ByVal value As String)
                _USRLQD = value
            End Set
        End Property

        Public Property CGRFO() As Decimal
            Get
                Return _CGRFO
            End Get
            Set(ByVal value As Decimal)
                _CGRFO = value
            End Set
        End Property

        Public Property FCRCMB() As String
            Get
                Return _FCRCMB
            End Get
            Set(ByVal value As String)
                _FCRCMB = value
            End Set
        End Property

        Public Property NVLGRF() As Decimal
            Get
                Return _NVLGRF
            End Get
            Set(ByVal value As Decimal)
                _NVLGRF = value
            End Set
        End Property

        Public Property NPLCUN() As String
            Get
                Return (_NPLCUN)
            End Get
            Set(ByVal value As String)
                _NPLCUN = value
            End Set
        End Property

        Public Property NKMRCR() As Decimal
            Get
                Return _NKMRCR
            End Get
            Set(ByVal value As Decimal)
                _NKMRCR = value
            End Set
        End Property

        Public Property NURRCR() As Decimal
            Get
                Return _NURRCR
            End Get
            Set(ByVal value As Decimal)
                _NURRCR = value
            End Set
        End Property

        Public Property NRNDUR() As Decimal
            Get
                Return _NRNDUR
            End Get
            Set(ByVal value As Decimal)
                _NRNDUR = value
            End Set
        End Property
        Public Property NRNDPRC() As Decimal
            Get
                Return _NRNDPRC
            End Get
            Set(ByVal value As Decimal)
                _NRNDPRC = value
            End Set
        End Property

        Public Property NRITEM() As Decimal
            Get
                Return _NRITEM
            End Get
            Set(ByVal value As Decimal)
                _NRITEM = value
            End Set
        End Property

        Public Property CSTRGL() As Decimal
            Get
                Return _CSTRGL
            End Get
            Set(ByVal value As Decimal)
                _CSTRGL = value
            End Set
        End Property
        Public Property CMNDA1() As Decimal
            Get
                Return _CMNDA1
            End Get
            Set(ByVal value As Decimal)
                _CMNDA1 = value
            End Set
        End Property
        Public Property NVLGRS() As String
            Get
                Return _NVLGRS
            End Get
            Set(ByVal value As String)
                _NVLGRS = value
            End Set
        End Property
        Public Property NDCCTS() As String
            Get
                Return _NDCCTS
            End Get
            Set(ByVal value As String)
                _NDCCTS = value
            End Set
        End Property
        '

#End Region

  End Class

End Namespace