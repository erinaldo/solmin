Namespace mantenimientos

  Public Class TipoDocumento
    Private _CTPODC As Int32 = 0
    Private _TCMTPD As String = ""
    Private _CCMPN As String = ""

    Public Property CTPODC() As Int32
      Get
        Return _CTPODC
      End Get
      Set(ByVal value As Int32)
        _CTPODC = value
      End Set
    End Property
  
    Public Property TCMTPD() As String
      Get
        Return _TCMTPD
      End Get
      Set(ByVal value As String)
        _TCMTPD = value
      End Set
    End Property

    Public Property CCMPN() As String
      Get
        Return _CCMPN
      End Get
      Set(ByVal value As String)
        _CCMPN = value
      End Set
    End Property


  End Class

End Namespace
