Namespace mantenimientos

  Public Class Viaje_Pasajero
    Private _PNNPRGVJ As Double = 0
    Private _PNNCRRRT As Double = 0
    Private _PNNCRRIN As Double = 0
    Private _PNNCREMB As Double = 0
    Private _PNCCLNT As Double = 0
    Private _PNCPRVCL As Double = 0
    Private _PSTPDCPE As String = ""
    Private _PSNMDCPE As String = ""
    Private _PSTCMLGD As String = ""
    Private _PSSSGRSD As String = ""
    Private _PNFCVNSS As Double = 0
    Private _PSSSGRSP As String = ""
    Private _PNFCVNSP As Double = 0
    Private _PSSSGRSV As String = ""
    Private _PNFCVNSV As Double = 0
    Private _PSSSGRAP As String = ""
    Private _PNFCVNSA As Double = 0
    Private _PNFCEXMD As Double = 0
    Private _PSSSDCSL As String = ""
    Private _PSSSVCNR As String = ""
    Private _PNFCRSSG As Double = 0
    Private _PSTMTVIN As String = ""
    Private _PSNORCMC As String = ""
    Private _PSNPSPER As String = ""
    Private _PNFVCPSP As Double = 0
    Private _PNCTRMNC As Double = 0
    Private _PNNGUITR As Double = 0
    Private _PSSESTRG As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Double = 0
    Private _PNHRACRT As Double = 0
    Private _PSNTRMCR As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Double = 0
    Private _PNHULTAC As Double = 0
    Private _PSNTRMNL As String = ""
    Private _PSAPENOM As String = ""
    Private _PNUPDATE_IDENT As Double = 0
    Private _PSTCMPCL As String = ""
    Private _PSORIGEN As String = ""
    Private _PSDESTINO As String = ""
    Private _PSCCMPN As String = ""
    Private _PSTIPODOC As String = ""
    Private _PNFECFIN As Double = 0
    Private _PNFECINI As Double = 0
    Private _PNCMEDTR As Double = 0
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As Double = 0

    Public Property PNCMEDTR() As Double
      Get
        Return _PNCMEDTR
      End Get
      Set(ByVal value As Double)
        _PNCMEDTR = value
      End Set
    End Property


    Public Property PSCDVSN() As String
      Get
        Return _PSCDVSN
      End Get
      Set(ByVal value As String)
        _PSCDVSN = value
      End Set
    End Property

    Public Property PNCPLNDV() As Double
      Get
        Return _PNCPLNDV
      End Get
      Set(ByVal value As Double)
        _PNCPLNDV = value
      End Set
    End Property

    Public Property PNFECFIN() As Double
      Get
        Return _PNFECFIN
      End Get
      Set(ByVal value As Double)
        _PNFECFIN = value
      End Set
    End Property

    Public Property PNFECINI() As Double
      Get
        Return _PNFECINI
      End Get
      Set(ByVal value As Double)
        _PNFECINI = value
      End Set
    End Property

    Public Property PSCCMPN() As String
      Get
        Return _PSCCMPN
      End Get
      Set(ByVal value As String)
        _PSCCMPN = value
      End Set
    End Property


    Public Property PSORIGEN() As String
      Get
        Return _PSORIGEN
      End Get
      Set(ByVal value As String)
        _PSORIGEN = value
      End Set
    End Property


    Public Property PSDESTINO() As String
      Get
        Return _PSDESTINO
      End Get
      Set(ByVal value As String)
        _PSDESTINO = value
      End Set
    End Property



    Public Property PSTCMPCL() As String
      Get
        Return _PSTCMPCL
      End Get
      Set(ByVal value As String)
        _PSTCMPCL = value
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

    Private _PSFCVNSS_1 As String
    Public Property PSFCVNSS_1() As String
      Get
        Return _PSFCVNSS_1
      End Get
      Set(ByVal value As String)
        _PSFCVNSS_1 = value
      End Set
    End Property


    Private _PSFCVNSP_1 As String
    Public Property PSFCVNSP_1() As String
      Get
        Return _PSFCVNSP_1
      End Get
      Set(ByVal value As String)
        _PSFCVNSP_1 = value
      End Set
    End Property


    Private _PSFCVNSV_1 As String
    Public Property PSFCVNSV_1() As String
      Get
        Return _PSFCVNSV_1
      End Get
      Set(ByVal value As String)
        _PSFCVNSV_1 = value
      End Set
    End Property


    Private _PSFCVNSA_1 As String
    Public Property PSFCVNSA_1() As String
      Get
        Return _PSFCVNSA_1
      End Get
      Set(ByVal value As String)
        _PSFCVNSA_1 = value
      End Set
    End Property

    Private _PSFCEXMD_1 As String
    Public Property PSFCEXMD_1() As String
      Get
        Return _PSFCEXMD_1
      End Get
      Set(ByVal value As String)
        _PSFCEXMD_1 = value
      End Set
    End Property


    Private _PSFCRSSG_1 As String
    Public Property PSFCRSSG_1() As String
      Get
        Return _PSFCRSSG_1
      End Get
      Set(ByVal value As String)
        _PSFCRSSG_1 = value
      End Set
    End Property


    Private _PSFVCPSP_1 As String
    Public Property PSFVCPSP_1() As String
      Get
        Return _PSFVCPSP_1
      End Get
      Set(ByVal value As String)
        _PSFVCPSP_1 = value
      End Set
    End Property




    Public Property PNNPRGVJ() As Double
      Get
        Return (_PNNPRGVJ)
      End Get
      Set(ByVal value As Double)
        _PNNPRGVJ = value
      End Set
    End Property
    Public Property PNNCRRRT() As Double
      Get
        Return (_PNNCRRRT)
      End Get
      Set(ByVal value As Double)
        _PNNCRRRT = value
      End Set
    End Property
    Public Property PNNCRRIN() As Double
      Get
        Return (_PNNCRRIN)
      End Get
      Set(ByVal value As Double)
        _PNNCRRIN = value
      End Set
    End Property
    Public Property PNNCREMB() As Double
      Get
        Return (_PNNCREMB)
      End Get
      Set(ByVal value As Double)
        _PNNCREMB = value
      End Set
    End Property
    Public Property PNCCLNT() As Double
      Get
        Return (_PNCCLNT)
      End Get
      Set(ByVal value As Double)
        _PNCCLNT = value
      End Set
    End Property
    Public Property PNCPRVCL() As Double
      Get
        Return (_PNCPRVCL)
      End Get
      Set(ByVal value As Double)
        _PNCPRVCL = value
      End Set
    End Property


    Public Property PSTIPODOC() As String
      Get
        Return (_PSTIPODOC)
      End Get
      Set(ByVal value As String)
        _PSTIPODOC = value
      End Set
    End Property

    Public Property PSTPDCPE() As String
      Get
        Return (_PSTPDCPE)
      End Get
      Set(ByVal value As String)
        _PSTPDCPE = value
      End Set
    End Property
    Public Property PSNMDCPE() As String
      Get
        Return (_PSNMDCPE)
      End Get
      Set(ByVal value As String)
        _PSNMDCPE = value
      End Set
    End Property

    Public Property PSAPENOM() As String
      Get
        Return (_PSAPENOM)
      End Get
      Set(ByVal value As String)
        _PSAPENOM = value
      End Set
    End Property


    Public Property PSTCMLGD() As String
      Get
        Return (_PSTCMLGD)
      End Get
      Set(ByVal value As String)
        _PSTCMLGD = value
      End Set
    End Property
    Public Property PSSSGRSD() As String
      Get
        Return (_PSSSGRSD)
      End Get
      Set(ByVal value As String)
        _PSSSGRSD = value
      End Set
    End Property
    Public Property PNFCVNSS() As Double
      Get
        Return (_PNFCVNSS)
      End Get
      Set(ByVal value As Double)
        _PNFCVNSS = value
      End Set
    End Property
    Public Property PSSSGRSP() As String
      Get
        Return (_PSSSGRSP)
      End Get
      Set(ByVal value As String)
        _PSSSGRSP = value
      End Set
    End Property
    Public Property PNFCVNSP() As Double
      Get
        Return (_PNFCVNSP)
      End Get
      Set(ByVal value As Double)
        _PNFCVNSP = value
      End Set
    End Property
    Public Property PSSSGRSV() As String
      Get
        Return (_PSSSGRSV)
      End Get
      Set(ByVal value As String)
        _PSSSGRSV = value
      End Set
    End Property
    Public Property PNFCVNSV() As Double
      Get
        Return (_PNFCVNSV)
      End Get
      Set(ByVal value As Double)
        _PNFCVNSV = value
      End Set
    End Property
    Public Property PSSSGRAP() As String
      Get
        Return (_PSSSGRAP)
      End Get
      Set(ByVal value As String)
        _PSSSGRAP = value
      End Set
    End Property
    Public Property PNFCVNSA() As Double
      Get
        Return (_PNFCVNSA)
      End Get
      Set(ByVal value As Double)
        _PNFCVNSA = value
      End Set
    End Property
    Public Property PNFCEXMD() As Double
      Get
        Return (_PNFCEXMD)
      End Get
      Set(ByVal value As Double)
        _PNFCEXMD = value
      End Set
    End Property
    Public Property PSSSDCSL() As String
      Get
        Return (_PSSSDCSL)
      End Get
      Set(ByVal value As String)
        _PSSSDCSL = value
      End Set
    End Property
    Public Property PSSSVCNR() As String
      Get
        Return (_PSSSVCNR)
      End Get
      Set(ByVal value As String)
        _PSSSVCNR = value
      End Set
    End Property
    Public Property PNFCRSSG() As Double
      Get
        Return (_PNFCRSSG)
      End Get
      Set(ByVal value As Double)
        _PNFCRSSG = value
      End Set
    End Property
    Public Property PSTMTVIN() As String
      Get
        Return (_PSTMTVIN)
      End Get
      Set(ByVal value As String)
        _PSTMTVIN = value
      End Set
    End Property
    Public Property PSNORCMC() As String
      Get
        Return (_PSNORCMC)
      End Get
      Set(ByVal value As String)
        _PSNORCMC = value
      End Set
    End Property
    Public Property PSNPSPER() As String
      Get
        Return (_PSNPSPER)
      End Get
      Set(ByVal value As String)
        _PSNPSPER = value
      End Set
    End Property
    Public Property PNFVCPSP() As Double
      Get
        Return (_PNFVCPSP)
      End Get
      Set(ByVal value As Double)
        _PNFVCPSP = value
      End Set
    End Property
    Public Property PNCTRMNC() As Double
      Get
        Return (_PNCTRMNC)
      End Get
      Set(ByVal value As Double)
        _PNCTRMNC = value
      End Set
    End Property
    Public Property PNNGUITR() As Double
      Get
        Return (_PNNGUITR)
      End Get
      Set(ByVal value As Double)
        _PNNGUITR = value
      End Set
    End Property
    Public Property PSSESTRG() As String
      Get
        Return (_PSSESTRG)
      End Get
      Set(ByVal value As String)
        _PSSESTRG = value
      End Set
    End Property
    Public Property PSCUSCRT() As String
      Get
        Return (_PSCUSCRT)
      End Get
      Set(ByVal value As String)
        _PSCUSCRT = value
      End Set
    End Property
    Public Property PNFCHCRT() As Double
      Get
        Return (_PNFCHCRT)
      End Get
      Set(ByVal value As Double)
        _PNFCHCRT = value
      End Set
    End Property
    Public Property PNHRACRT() As Double
      Get
        Return (_PNHRACRT)
      End Get
      Set(ByVal value As Double)
        _PNHRACRT = value
      End Set
    End Property
    Public Property PSNTRMCR() As String
      Get
        Return (_PSNTRMCR)
      End Get
      Set(ByVal value As String)
        _PSNTRMCR = value
      End Set
    End Property
    Public Property PSCULUSA() As String
      Get
        Return (_PSCULUSA)
      End Get
      Set(ByVal value As String)
        _PSCULUSA = value
      End Set
    End Property
    Public Property PNFULTAC() As Double
      Get
        Return (_PNFULTAC)
      End Get
      Set(ByVal value As Double)
        _PNFULTAC = value
      End Set
    End Property
    Public Property PNHULTAC() As Double
      Get
        Return (_PNHULTAC)
      End Get
      Set(ByVal value As Double)
        _PNHULTAC = value
      End Set
    End Property
    Public Property PSNTRMNL() As String
      Get
        Return (_PSNTRMNL)
      End Get
      Set(ByVal value As String)
        _PSNTRMNL = value
      End Set
    End Property
    Public Property PNUPDATE_IDENT() As Double
      Get
        Return (_PNUPDATE_IDENT)
      End Get
      Set(ByVal value As Double)
        _PNUPDATE_IDENT = value
      End Set
    End Property
  End Class

End Namespace