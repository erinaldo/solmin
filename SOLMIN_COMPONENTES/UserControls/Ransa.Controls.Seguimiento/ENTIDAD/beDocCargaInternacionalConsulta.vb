Public Class beDocCargaInternacionalConsulta
  Private _PNNORSCI As Decimal = 0
  Private _PNNRPARC As Decimal = 0
  Private _PNNDOCIN As Decimal = 0
  Private _PNNCRRDC As Decimal = 0
  Private _PSNDOCUM As String = ""
  Private _PNIVLORG As Decimal = 0
  Private _PNIVLDOL As Decimal = 0
  Private _PNCMNDA1 As Decimal = 0
  Private _PSNMONOC As String = ""
  Private _PSTOBS As String = ""
  Private _PSNOMVAR As String = ""
  Private _PNCCLNT As String = ""
  Private _PNSECSUS As Decimal = 0
  Private _PNFREDOC As Decimal = 0
  Private _PSNDOCLI As String = ""
  Private _PSFCDCOR As String = ""
  Private _PSFCDCCP As String = ""
  Private _PSTOBSMD As String = ""
  Private _PSTNMBAR As String = ""
  Private _PSURLARC As String = ""
  Private _PSSORDOC As String = ""

  Private _PSCULUSA As String = ""
  Private _PNFULTAC As Decimal = 0
  Private _PNHULTAC As Decimal = 0
  Private _PSSESTRG As String = ""
  Private _PSNORCML As String = ""
  Private _PNIVFOBD As Decimal = 0
  Private _PSTDOCIN As String = ""
  Private _PSTNMBARIMAGE As String = ""
  Private _PNNCODRG As Decimal = 0
  Private _PNQCANTI As Decimal = 0
  Private _PNNTPODT As Decimal = 0
  Private _PSTDSCRG As String = ""
  Private _PSFLGORG As String = ""
  Private _PSFLGCOP As String = ""
  Private _PSNUMDOC As String = ""
  Private _PSCVARBL As String = ""
  Private _PNVALVAR As String = ""
  Private _PNCODVAR As Decimal = 0
  Private _PSUID As String = ""
  Private _PNFECORG As Decimal = 0
  Private _PNFECCOP As Decimal = 0
  Private _PNFOB As Decimal = 0
  Private _PNEXISTS As Decimal = 0

  Public Property PNCODVAR() As Decimal
    Get
      Return _PNCODVAR
    End Get
    Set(ByVal value As Decimal)
      _PNCODVAR = value
    End Set
  End Property


  Public Property PSCVARBL() As String
    Get
      Return (_PSCVARBL)
    End Get
    Set(ByVal value As String)
      _PSCVARBL = value
    End Set
  End Property

  Public Property PNVALVAR() As String
    Get
      Return (_PNVALVAR)
    End Get
    Set(ByVal value As String)
      _PNVALVAR = value
    End Set
  End Property



  Public Property PNNORSCI() As Decimal
    Get
      Return (_PNNORSCI)
    End Get
    Set(ByVal value As Decimal)
      _PNNORSCI = value
    End Set
  End Property
  Public Property PNNDOCIN() As Decimal
    Get
      Return (_PNNDOCIN)
    End Get
    Set(ByVal value As Decimal)
      _PNNDOCIN = value
    End Set
  End Property
  Public Property PNNCRRDC() As Decimal
    Get
      Return (_PNNCRRDC)
    End Get
    Set(ByVal value As Decimal)
      _PNNCRRDC = value
    End Set
  End Property
  Public Property PNSECSUS() As Decimal
    Get
      Return (_PNSECSUS)
    End Get
    Set(ByVal value As Decimal)
      _PNSECSUS = value
    End Set
  End Property

  Public Property PSNDOCUM() As String
    Get
      Return (_PSNDOCUM)
    End Get
    Set(ByVal value As String)
      _PSNDOCUM = value
    End Set
  End Property

  Public Property PNIVLORG() As Decimal
    Get
      Return (_PNIVLORG)
    End Get
    Set(ByVal value As Decimal)
      _PNIVLORG = value
    End Set
  End Property

  Public Property PNIVLDOL() As Decimal
    Get
      Return (_PNIVLDOL)
    End Get
    Set(ByVal value As Decimal)
      _PNIVLDOL = value
    End Set
  End Property

  Public Property PNCMNDA1() As Decimal
    Get
      Return (_PNCMNDA1)
    End Get
    Set(ByVal value As Decimal)
      _PNCMNDA1 = value
    End Set
  End Property

  Public Property PSNMONOC() As String
    Get
      Return (_PSNMONOC)
    End Get
    Set(ByVal value As String)
      _PSNMONOC = value
    End Set
  End Property

  Public Property PSTOBS() As String
    Get
      Return (_PSTOBS)
    End Get
    Set(ByVal value As String)
      _PSTOBS = value
    End Set
  End Property


  Public Property PSNOMVAR() As String
    Get
      Return (_PSNOMVAR)
    End Get
    Set(ByVal value As String)
      _PSNOMVAR = value
    End Set
  End Property

  Public Property PNFREDOC() As Decimal
    Get
      Return (_PNFREDOC)
    End Get
    Set(ByVal value As Decimal)
      _PNFREDOC = value
    End Set
  End Property
  Public Property PSNDOCLI() As String
    Get
      Return (_PSNDOCLI)
    End Get
    Set(ByVal value As String)
      _PSNDOCLI = value
    End Set
  End Property
  Public Property PSFCDCOR() As String
    Get
      Return (_PSFCDCOR)
    End Get
    Set(ByVal value As String)
      _PSFCDCOR = value
    End Set
  End Property
  Public Property PSFCDCCP() As String
    Get
      Return (_PSFCDCCP)
    End Get
    Set(ByVal value As String)
      _PSFCDCCP = value
    End Set
  End Property
  Public Property PSTOBSMD() As String
    Get
      Return (_PSTOBSMD)
    End Get
    Set(ByVal value As String)
      _PSTOBSMD = value
    End Set
  End Property
  Public Property PSTNMBAR() As String
    Get
      Return (_PSTNMBAR)
    End Get
    Set(ByVal value As String)
      _PSTNMBAR = value
    End Set
  End Property
  Public Property PSURLARC() As String
    Get
      Return (_PSURLARC)
    End Get
    Set(ByVal value As String)
      _PSURLARC = value
    End Set
  End Property
  Public Property PSSORDOC() As String
    Get
      Return (_PSSORDOC)
    End Get
    Set(ByVal value As String)
      _PSSORDOC = value
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
  Public Property PNFULTAC() As Decimal
    Get
      Return (_PNFULTAC)
    End Get
    Set(ByVal value As Decimal)
      _PNFULTAC = value
    End Set
  End Property
  Public Property PNHULTAC() As Decimal
    Get
      Return (_PNHULTAC)
    End Get
    Set(ByVal value As Decimal)
      _PNHULTAC = value
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

  Public Property PSNORCML() As String
    Get
      Return (_PSNORCML)
    End Get
    Set(ByVal value As String)
      _PSNORCML = value
    End Set
  End Property
  Public Property PNIVFOBD() As Decimal
    Get
      Return (_PNIVFOBD)
    End Get
    Set(ByVal value As Decimal)
      _PNIVFOBD = value
    End Set
  End Property

  Public Property PSTDOCIN() As String
    Get
      Return (_PSTDOCIN)
    End Get
    Set(ByVal value As String)
      _PSTDOCIN = value
    End Set
  End Property

  Public Property PSTNMBARIMAGE() As String
    Get
      Return (_PSTNMBARIMAGE)
    End Get
    Set(ByVal value As String)
      _PSTNMBARIMAGE = value
    End Set
  End Property

  Public Property PNNCODRG() As Decimal
    Get
      Return (_PNNCODRG)
    End Get
    Set(ByVal value As Decimal)
      _PNNCODRG = value
    End Set
  End Property
  Public Property PNQCANTI() As Decimal
    Get
      Return (_PNQCANTI)
    End Get
    Set(ByVal value As Decimal)
      _PNQCANTI = value
    End Set
  End Property


  Public Property PNNTPODT() As Decimal
    Get
      Return (_PNNTPODT)
    End Get
    Set(ByVal value As Decimal)
      _PNNTPODT = value
    End Set
  End Property

  Public Property PSTDSCRG() As String
    Get
      Return (_PSTDSCRG)
    End Get
    Set(ByVal value As String)
      _PSTDSCRG = value
    End Set
  End Property


  Public Property PSFLGORG() As String
    Get
      Return (_PSFLGORG)
    End Get
    Set(ByVal value As String)
      _PSFLGORG = value
    End Set
  End Property

  Public Property PSFLGCOP() As String
    Get
      Return (_PSFLGCOP)
    End Get
    Set(ByVal value As String)
      _PSFLGCOP = value
    End Set
  End Property

  Public Property PSNUMDOC() As String
    Get
      Return (_PSNUMDOC)
    End Get
    Set(ByVal value As String)
      _PSNUMDOC = value
    End Set
  End Property

  Public Property PNCCLNT() As String
    Get
      Return (_PNCCLNT)
    End Get
    Set(ByVal value As String)
      _PNCCLNT = value
    End Set
  End Property


  Public Property PSUID() As String
    Get
      Return (_PSUID)
    End Get
    Set(ByVal value As String)
      _PSUID = value
    End Set
  End Property

  Public Property PNFECORG() As Decimal
    Get
      Return (_PNFECORG)
    End Get
    Set(ByVal value As Decimal)
      _PNFECORG = value
    End Set
  End Property


  Public Property PNFOB() As Decimal
    Get
      Return (_PNFOB)
    End Get
    Set(ByVal value As Decimal)
      _PNFOB = value
    End Set
  End Property
  Public Property PNEXISTS() As Decimal
    Get
      Return (_PNEXISTS)
    End Get
    Set(ByVal value As Decimal)
      _PNEXISTS = value
    End Set
  End Property


  Public Property PNFECCOP() As Decimal
    Get
      Return (_PNFECCOP)
    End Get
    Set(ByVal value As Decimal)
      _PNFECCOP = value
    End Set
  End Property

  Public Property PNNRPARC() As Decimal
    Get
      Return (_PNNRPARC)
    End Get
    Set(ByVal value As Decimal)
      _PNNRPARC = value
    End Set
  End Property

End Class

