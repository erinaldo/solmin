Namespace mantenimientos

  Public Class VacacionesConductor
    Inherits Chofer

    Private _NCRRLT As Int32 = 0
    Private _ANOINI As Int32 = 0
    Private _ANOFIN As Int32 = 0
    Private _FECINI As String = ""
    Private _FECFIN As String = ""
    Private _QCNESP As Double = 0

    Public Property QCNESP() As Double
      Get
        Return _QCNESP
      End Get
      Set(ByVal value As Double)
        _QCNESP = value
      End Set
    End Property

    Public Property NCRRLT() As Int32
      Get
        Return _NCRRLT
      End Get
      Set(ByVal value As Int32)
        _NCRRLT = value
      End Set
    End Property

    Public Property ANOINI() As Int32
      Get
        Return _ANOINI
      End Get
      Set(ByVal value As Int32)
        _ANOINI = value
      End Set
    End Property

    Public Property ANOFIN() As Int32
      Get
        Return _ANOFIN
      End Get
      Set(ByVal Value As Int32)
        _ANOFIN = Value
      End Set
    End Property

    Public Property FECINI() As String
      Get
        Return _FECINI
      End Get
      Set(ByVal Value As String)
        _FECINI = Value
      End Set
    End Property


    Public Property FECFIN() As String
      Get
        Return _FECFIN
      End Get
      Set(ByVal Value As String)
        _FECFIN = Value
      End Set
    End Property

  End Class

End Namespace