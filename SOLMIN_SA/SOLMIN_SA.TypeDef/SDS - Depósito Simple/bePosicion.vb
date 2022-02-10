Public Class bePosicion
	Private _PSSSCPOS As String
	Private _PSCTPALM As String
	Private _PNCSRVPK As Double
	Private _PSCROTMR As String
	Private _PSCPSCN As String
	Private _PSCALMC As String
    Private _PNCCLNT As Double
    Private _PSCSECTR As String

    Public Property PNCCLNT() As Double
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Double)
            _PNCCLNT = value
        End Set
    End Property

	Public Property PSSSCPOS As String
		Get
			Return (_PSSSCPOS)
		End Get
		Set(ByVal value As String)
			_PSSSCPOS=value
		End Set
	End Property
	Public Property PSCTPALM As String
		Get
			Return (_PSCTPALM)
		End Get
		Set(ByVal value As String)
			_PSCTPALM=value
		End Set
	End Property
	Public Property PNCSRVPK As Double
		Get
			Return (_PNCSRVPK)
		End Get
		Set(ByVal value As Double)
			_PNCSRVPK=value
		End Set
	End Property
	Public Property PSCROTMR As String
		Get
			Return (_PSCROTMR)
		End Get
		Set(ByVal value As String)
			_PSCROTMR=value
		End Set
	End Property
	Public Property PSCPSCN As String
		Get
			Return (_PSCPSCN)
		End Get
		Set(ByVal value As String)
			_PSCPSCN=value
		End Set
	End Property
	Public Property PSCALMC As String
		Get
			Return (_PSCALMC)
		End Get
		Set(ByVal value As String)
			_PSCALMC=value
		End Set
    End Property

    Public Property PSCSECTR() As String
        Get
            Return _PSCSECTR
        End Get
        Set(ByVal value As String)
            _PSCSECTR = value
        End Set
    End Property

    Private _PSCMRCLR As String
    Public Property PSCMRCLR() As String
        Get
            Return _PSCMRCLR
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property


End Class