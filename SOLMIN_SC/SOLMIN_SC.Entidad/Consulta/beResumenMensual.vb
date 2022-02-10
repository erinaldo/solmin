Public Class beResumenMensual
    Private _PNCCLNT As Decimal = 0
    Private _PNFECHA_INI As Decimal = 0
    Private _PNFECHA_FIN As Decimal = 0
    Private _PNNORSCI As Decimal = 0
    Private _PSESTADO As String = ""
  Private _PSLISTREGIMEN As String = ""
  Private _PSTPSRVA As String = ""
    Private _PNPNNMOS As Decimal = 0
    Private _PNCPRVCL As Decimal = 0
    Private _PSNORCML As String = ""
    Private _PSTIPO_CHK As String = ""
    Private _PNCHK_COD As Decimal = 0
    Private _PNFECHA_CHK_INI As Decimal = 0
  Private _PNFECHA_CHK_FIN As Decimal = 0

    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNFECHA_INI() As Decimal
        Get
            Return _PNFECHA_INI
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA_INI = value
        End Set
    End Property


    Public Property PNFECHA_FIN() As Decimal
        Get
            Return _PNFECHA_FIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA_FIN = value
        End Set
    End Property

   
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property


    Public Property PSESTADO() As String
        Get
            Return _PSESTADO
        End Get
        Set(ByVal value As String)
            _PSESTADO = value
        End Set
  End Property

  Public Property PSTPSRVA() As String
    Get
      Return _PSTPSRVA
    End Get
    Set(ByVal value As String)
      _PSTPSRVA = value
    End Set
  End Property

    Public Property PSLISTREGIMEN() As String
        Get
            Return _PSLISTREGIMEN
        End Get
        Set(ByVal value As String)
            _PSLISTREGIMEN = value
        End Set
    End Property

    Public Property PNPNNMOS() As String
        Get
            Return _PNPNNMOS
        End Get
        Set(ByVal value As String)
            _PNPNNMOS = value
        End Set
    End Property

    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PSTIPO_CHK() As String
        Get
            Return _PSTIPO_CHK
        End Get
        Set(ByVal value As String)
            _PSTIPO_CHK = value
        End Set
    End Property

    Public Property PNCHK_COD() As Decimal
        Get
            Return _PNCHK_COD
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_COD = value
        End Set
    End Property

    Public Property PNFECHA_CHK_INI() As Decimal
        Get
            Return _PNFECHA_CHK_INI
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA_CHK_INI = value
        End Set
    End Property

    Public Property PNFECHA_CHK_FIN() As Decimal
        Get
            Return _PNFECHA_CHK_FIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA_CHK_FIN = value
        End Set
    End Property

End Class
