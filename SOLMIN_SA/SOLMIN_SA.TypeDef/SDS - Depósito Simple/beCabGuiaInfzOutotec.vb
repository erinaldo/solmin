Public Class beCabGuiaInfzOutotec
    Inherits beBase(Of beCabGuiaInfzOutotec)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    Private _nguias As Integer
    Private _nserof As String
    Private _ndocof As String
    Private _ctpdoc As String
    Private _npensa As Integer
    Private _cgauma As String
    Private _femisi As DateTime
    Private _finitr As DateTime
    Private _cconce As String
    Private _nordpr As String
    Private _ctpope As String
    Private _nordcl As String
    Private _clcori As String
    Private _ddiori As String
    Private _ctpode As String
    Private _coride As String
    Private _ddirec01 As String
    Private _ddirec02 As String
    Private _ctpref As String
    Private _ndcref As Integer
    Private _dvehic As String
    Private _nconst As String
    Private _nplaca01 As String
    Private _nplaca02 As String
    Private _cciatr As String
    Private _cchofe As String
    Private _cunmed As String
    Private _qtotpe As Decimal
    Private _icosmt As Decimal
    Private _dobser As String
    Private _ctpfac As String
    Private _nfactu01 As String
    Private _nfactu02 As String
    Private _fecdoc As DateTime
    Private _senlac As String
    Private _sguias As String
    Private _fstatu As DateTime
    Private _cmtanu As String
    Private _ctpgui As String
    Private _dtpgui As String
    Private _cusuar As String
    Private _sgepes As String
    Private _drztra As String
    Private _cructr As String
    Private _dchofe As String
    Private _nbreve As String

    Public Property nguias() As Integer
        Get
            Return (_nguias)
        End Get
        Set(ByVal value As Integer)
            _nguias = value
        End Set
    End Property
    Public Property nserof() As String
        Get
            Return (_nserof)
        End Get
        Set(ByVal value As String)
            _nserof = value
        End Set
    End Property
    Public Property ndocof() As String
        Get
            Return (_ndocof)
        End Get
        Set(ByVal value As String)
            _ndocof = value
        End Set
    End Property
    Public Property ctpdoc() As String
        Get
            Return (_ctpdoc)
        End Get
        Set(ByVal value As String)
            _ctpdoc = value
        End Set
    End Property
    Public Property npensa() As Integer
        Get
            Return (_npensa)
        End Get
        Set(ByVal value As Integer)
            _npensa = value
        End Set
    End Property
    Public Property cgauma() As String
        Get
            Return (_cgauma)
        End Get
        Set(ByVal value As String)
            _cgauma = value
        End Set
    End Property
    Public Property femisi() As DateTime
        Get
            Return (_femisi)
        End Get
        Set(ByVal value As DateTime)
            _femisi = value
        End Set
    End Property
    Public Property finitr() As DateTime
        Get
            Return (_finitr)
        End Get
        Set(ByVal value As DateTime)
            _finitr = value
        End Set
    End Property
    Public Property cconce() As String
        Get
            Return (_cconce)
        End Get
        Set(ByVal value As String)
            _cconce = value
        End Set
    End Property
    Public Property nordpr() As String
        Get
            Return (_nordpr)
        End Get
        Set(ByVal value As String)
            _nordpr = value
        End Set
    End Property
    Public Property ctpope() As String
        Get
            Return (_ctpope)
        End Get
        Set(ByVal value As String)
            _ctpope = value
        End Set
    End Property
    Public Property nordcl() As String
        Get
            Return (_nordcl)
        End Get
        Set(ByVal value As String)
            _nordcl = value
        End Set
    End Property
    Public Property clcori() As String
        Get
            Return (_clcori)
        End Get
        Set(ByVal value As String)
            _clcori = value
        End Set
    End Property
    Public Property ddiori() As String
        Get
            Return (_ddiori)
        End Get
        Set(ByVal value As String)
            _ddiori = value
        End Set
    End Property
    Public Property ctpode() As String
        Get
            Return (_ctpode)
        End Get
        Set(ByVal value As String)
            _ctpode = value
        End Set
    End Property
    Public Property coride() As String
        Get
            Return (_coride)
        End Get
        Set(ByVal value As String)
            _coride = value
        End Set
    End Property
    Public Property ddirec01() As String
        Get
            Return (_ddirec01)
        End Get
        Set(ByVal value As String)
            _ddirec01 = value
        End Set
    End Property
    Public Property ddirec02() As String
        Get
            Return (_ddirec02)
        End Get
        Set(ByVal value As String)
            _ddirec02 = value
        End Set
    End Property
    Public Property ctpref() As String
        Get
            Return (_ctpref)
        End Get
        Set(ByVal value As String)
            _ctpref = value
        End Set
    End Property
    Public Property ndcref() As Integer
        Get
            Return (_ndcref)
        End Get
        Set(ByVal value As Integer)
            _ndcref = value
        End Set
    End Property
    Public Property dvehic() As String
        Get
            Return (_dvehic)
        End Get
        Set(ByVal value As String)
            _dvehic = value
        End Set
    End Property
    Public Property nconst() As String
        Get
            Return (_nconst)
        End Get
        Set(ByVal value As String)
            _nconst = value
        End Set
    End Property
    Public Property nplaca01() As String
        Get
            Return (_nplaca01)
        End Get
        Set(ByVal value As String)
            _nplaca01 = value
        End Set
    End Property
    Public Property nplaca02() As String
        Get
            Return (_nplaca02)
        End Get
        Set(ByVal value As String)
            _nplaca02 = value
        End Set
    End Property
    Public Property cciatr() As String
        Get
            Return (_cciatr)
        End Get
        Set(ByVal value As String)
            _cciatr = value
        End Set
    End Property
    Public Property cchofe() As String
        Get
            Return (_cchofe)
        End Get
        Set(ByVal value As String)
            _cchofe = value
        End Set
    End Property
    Public Property cunmed() As String
        Get
            Return (_cunmed)
        End Get
        Set(ByVal value As String)
            _cunmed = value
        End Set
    End Property
    Public Property qtotpe() As Decimal
        Get
            Return (_qtotpe)
        End Get
        Set(ByVal value As Decimal)
            _qtotpe = value
        End Set
    End Property
    Public Property icosmt() As Decimal
        Get
            Return (_icosmt)
        End Get
        Set(ByVal value As Decimal)
            _icosmt = value
        End Set
    End Property
    Public Property dobser() As String
        Get
            Return (_dobser)
        End Get
        Set(ByVal value As String)
            _dobser = value
        End Set
    End Property
    Public Property ctpfac() As String
        Get
            Return (_ctpfac)
        End Get
        Set(ByVal value As String)
            _ctpfac = value
        End Set
    End Property
    Public Property nfactu01() As String
        Get
            Return (_nfactu01)
        End Get
        Set(ByVal value As String)
            _nfactu01 = value
        End Set
    End Property
    Public Property nfactu02() As String
        Get
            Return (_nfactu02)
        End Get
        Set(ByVal value As String)
            _nfactu02 = value
        End Set
    End Property
    Public Property fecdoc() As DateTime
        Get
            Return (_fecdoc)
        End Get
        Set(ByVal value As DateTime)
            _fecdoc = value
        End Set
    End Property
    Public Property senlac() As String
        Get
            Return (_senlac)
        End Get
        Set(ByVal value As String)
            _senlac = value
        End Set
    End Property
    Public Property sguias() As String
        Get
            Return (_sguias)
        End Get
        Set(ByVal value As String)
            _sguias = value
        End Set
    End Property
    Public Property fstatu() As DateTime
        Get
            Return (_fstatu)
        End Get
        Set(ByVal value As DateTime)
            _fstatu = value
        End Set
    End Property
    Public Property cmtanu() As String
        Get
            Return (_cmtanu)
        End Get
        Set(ByVal value As String)
            _cmtanu = value
        End Set
    End Property
    Public Property ctpgui() As String
        Get
            Return (_ctpgui)
        End Get
        Set(ByVal value As String)
            _ctpgui = value
        End Set
    End Property
    Public Property dtpgui() As String
        Get
            Return (_dtpgui)
        End Get
        Set(ByVal value As String)
            _dtpgui = value
        End Set
    End Property
    Public Property cusuar() As String
        Get
            Return (_cusuar)
        End Get
        Set(ByVal value As String)
            _cusuar = value
        End Set
    End Property
    Public Property sgepes() As String
        Get
            Return (_sgepes)
        End Get
        Set(ByVal value As String)
            _sgepes = value
        End Set
    End Property


  

    Public Property drztra() As String
        Get
            Return (_drztra)
        End Get
        Set(ByVal value As String)
            _drztra = value
        End Set
    End Property
    Public Property cructr() As String
        Get
            Return (_cructr)
        End Get
        Set(ByVal value As String)
            _cructr = value
        End Set
    End Property
    Public Property dchofe() As String
        Get
            Return (_dchofe)
        End Get
        Set(ByVal value As String)
            _dchofe = value
        End Set
    End Property
    Public Property nbreve() As String
        Get
            Return (_nbreve)
        End Get
        Set(ByVal value As String)
            _nbreve = value
        End Set
    End Property


    Private _codcli As String
    Public Property codcli() As String
        Get
            Return _codcli
        End Get
        Set(ByVal value As String)
            _codcli = value
        End Set
    End Property

End Class

