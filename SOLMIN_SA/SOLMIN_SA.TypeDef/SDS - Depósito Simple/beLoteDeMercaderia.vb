Public Class beLoteDeMercaderia
    Inherits beBase(Of beLoteDeMercaderia)
    'CABECERA LOTE MERCADERIA
#Region "stributos"
    Private _PNNORDSR As Decimal = 0
    Private _PNNCRRIN As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PNCPRVCL As Decimal = 0
    Private _PSNDCMPV As String = ""
    Private _PNCMNCT As Decimal = 0
    Private _PNQIMCT As Decimal = 0
    Private _PNIMPTTL As Decimal = 0
    Private _PNCMNVTA As Decimal = 0
    Private _PNIMPVTA As Decimal = 0
    Private _PNFINGAL As Decimal = 0
    Private _PNFPRDMR As Decimal = 0
    Private _PNFVNLTE As Decimal = 0
    Private _PNNTRNO As Decimal = 0
    Private _PSTOBSCR As String = ""
    Private _PSCRTLTE As String = ""
    Private _PSNTONCL As String = ""
    Private _PSNCALCL As String = ""
    Private _PNQINMC2 As Decimal = 0
    Private _PNQINMP2 As Decimal = 0
    Private _PNQDSMC2 As Decimal = 0
    Private _PNQDSMP2 As Decimal = 0
    Private _PNQMRCSL As Decimal = 0
    Private _PNQPSOSL As Decimal = 0
    Private _PNQCMMC1 As Decimal = 0
    Private _PNQCMMP1 As Decimal = 0
    Private _PSSTRNSM As String = ""
    Private _PNFTRNSM As Decimal = 0
    Private _PNHTRNSM As Decimal = 0
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSSESTRG As String = ""
    Private _PNUPDATE_IDENT As Decimal = 0

    'MOVIMIENTO LOTE MERCADERIA

    Private _PNNCRRSL As Decimal = 0
    Private _PSCTPOAT As String = ""
    Private _PNNGUIRN As Decimal = 0
    Private _PNNSLCS1 As Decimal = 0
    Private _PNFDSPAL As Decimal = 0

    Private _PNQTRMC As Decimal = 0
    Private _PNQTRMP As Decimal = 0

    Private _PNIMTITE As Decimal = 0
    Private _PNIMPVEN As Decimal = 0
    Private _PSCTPALM As String = ""
    Private _PSCALMC As String = ""
    Private _PSCZNALM As String = ""
    Private _CREACION As String = ""

#End Region
   
#Region "Propiedades"
    Public Property PNNCRRSL() As Decimal
        Get
            Return (_PNNCRRSL)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRSL = value
        End Set
    End Property
    Public Property PSCTPOAT() As String
        Get
            Return (_PSCTPOAT)
        End Get
        Set(ByVal value As String)
            _PSCTPOAT = value
        End Set
    End Property

    Public Property PNNGUIRN() As Decimal
        Get
            Return (_PNNGUIRN)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property
    Public Property PNNSLCS1() As Decimal
        Get
            Return (_PNNSLCS1)
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCS1 = value
        End Set
    End Property
    Public Property PNFDSPAL() As Decimal
        Get
            Return (_PNFDSPAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFDSPAL = value
        End Set
    End Property
    Public Property PNQTRMC() As Decimal
        Get
            Return (_PNQTRMC)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property

    Public Property PNQTRMP() As Decimal
        Get
            Return (_PNQTRMP)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP = value
        End Set
    End Property

    Public Property PNIMTITE() As Decimal
        Get
            Return (_PNIMTITE)
        End Get
        Set(ByVal value As Decimal)
            _PNIMTITE = value
        End Set
    End Property

    Public Property PNIMPVEN() As Decimal
        Get
            Return (_PNIMPVEN)
        End Get
        Set(ByVal value As Decimal)
            _PNIMPVEN = value
        End Set
    End Property
    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property
    Public Property CREACION() As String
        Get
            Return (_CREACION)
        End Get
        Set(ByVal value As String)
            _CREACION = value
        End Set
    End Property




    Public Property PNNORDSR() As Decimal
        Get
            Return (_PNNORDSR)
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property
    Public Property PNNCRRIN() As Decimal
        Get
            Return (_PNNCRRIN)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIN = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property
    Public Property PSNDCMPV() As String
        Get
            Return (_PSNDCMPV)
        End Get
        Set(ByVal value As String)
            _PSNDCMPV = value
        End Set
    End Property
    Public Property PNCMNCT() As Decimal
        Get
            Return (_PNCMNCT)
        End Get
        Set(ByVal value As Decimal)
            _PNCMNCT = value
        End Set
    End Property
    Public Property PNQIMCT() As Decimal
        Get
            Return (_PNQIMCT)
        End Get
        Set(ByVal value As Decimal)
            _PNQIMCT = value
        End Set
    End Property
    Public Property PNIMPTTL() As Decimal
        Get
            Return (_PNIMPTTL)
        End Get
        Set(ByVal value As Decimal)
            _PNIMPTTL = value
        End Set
    End Property
    Public Property PNCMNVTA() As Decimal
        Get
            Return (_PNCMNVTA)
        End Get
        Set(ByVal value As Decimal)
            _PNCMNVTA = value
        End Set
    End Property
    Public Property PNIMPVTA() As Decimal
        Get
            Return (_PNIMPVTA)
        End Get
        Set(ByVal value As Decimal)
            _PNIMPVTA = value
        End Set
    End Property
    Public Property PNFINGAL() As Decimal
        Get
            Return (_PNFINGAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFINGAL = value
        End Set
    End Property
    Public Property PNFPRDMR() As Decimal
        Get
            Return (_PNFPRDMR)
        End Get
        Set(ByVal value As Decimal)
            _PNFPRDMR = value
        End Set
    End Property
    Public Property PNFVNLTE() As Decimal
        Get
            Return (_PNFVNLTE)
        End Get
        Set(ByVal value As Decimal)
            _PNFVNLTE = value
        End Set
    End Property
    Public Property PNNTRNO() As Decimal
        Get
            Return (_PNNTRNO)
        End Get
        Set(ByVal value As Decimal)
            _PNNTRNO = value
        End Set
    End Property
    Public Property PSTOBSCR() As String
        Get
            Return (_PSTOBSCR)
        End Get
        Set(ByVal value As String)
            _PSTOBSCR = value
        End Set
    End Property
    Public Property PSCRTLTE() As String
        Get
            Return (_PSCRTLTE)
        End Get
        Set(ByVal value As String)
            _PSCRTLTE = value
        End Set
    End Property
    Public Property PSNTONCL() As String
        Get
            Return (_PSNTONCL)
        End Get
        Set(ByVal value As String)
            _PSNTONCL = value
        End Set
    End Property
    Public Property PSNCALCL() As String
        Get
            Return (_PSNCALCL)
        End Get
        Set(ByVal value As String)
            _PSNCALCL = value
        End Set
    End Property
    Public Property PNQINMC2() As Decimal
        Get
            Return (_PNQINMC2)
        End Get
        Set(ByVal value As Decimal)
            _PNQINMC2 = value
        End Set
    End Property
    Public Property PNQINMP2() As Decimal
        Get
            Return (_PNQINMP2)
        End Get
        Set(ByVal value As Decimal)
            _PNQINMP2 = value
        End Set
    End Property
    Public Property PNQDSMC2() As Decimal
        Get
            Return (_PNQDSMC2)
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMC2 = value
        End Set
    End Property
    Public Property PNQDSMP2() As Decimal
        Get
            Return (_PNQDSMP2)
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMP2 = value
        End Set
    End Property
    Public Property PNQMRCSL() As Decimal
        Get
            Return (_PNQMRCSL)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRCSL = value
        End Set
    End Property
    Public Property PNQPSOSL() As Decimal
        Get
            Return (_PNQPSOSL)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOSL = value
        End Set
    End Property
    Public Property PNQCMMC1() As Decimal
        Get
            Return (_PNQCMMC1)
        End Get
        Set(ByVal value As Decimal)
            _PNQCMMC1 = value
        End Set
    End Property
    Public Property PNQCMMP1() As Decimal
        Get
            Return (_PNQCMMP1)
        End Get
        Set(ByVal value As Decimal)
            _PNQCMMP1 = value
        End Set
    End Property
    Public Property PSSTRNSM() As String
        Get
            Return (_PSSTRNSM)
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property
    Public Property PNFTRNSM() As Decimal
        Get
            Return (_PNFTRNSM)
        End Get
        Set(ByVal value As Decimal)
            _PNFTRNSM = value
        End Set
    End Property
    Public Property PNHTRNSM() As Decimal
        Get
            Return (_PNHTRNSM)
        End Get
        Set(ByVal value As Decimal)
            _PNHTRNSM = value
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
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
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
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
#End Region
   

  
End Class

Public Class beLoteDeMercaderiaFiltro
    Public PNNORDSR As Decimal = 0
    Public PNNCRRIN As Decimal = 0
End Class