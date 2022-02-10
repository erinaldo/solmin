Public Class beMenu
  Private _PSMMCAPL_CodApl As String = ""
  Private _PSSESTRG_Mnu As String = ""
  Private _PSMMCMNU_CodMnu As String = ""
  Private _PSMMTMNU_DesMnu As String = ""

  Public Property PSMMCAPL_CodApl() As String
    Get
      Return _PSMMCAPL_CodApl
    End Get
    Set(ByVal value As String)
      _PSMMCAPL_CodApl = value
    End Set
  End Property

  Public Property PSMMCMNU_CodMnu() As String
    Get
      Return _PSMMCMNU_CodMnu
    End Get
    Set(ByVal value As String)
      _PSMMCMNU_CodMnu = value
    End Set
  End Property

  Public Property PSMMTMNU_DesMnu() As String
    Get
      Return _PSMMTMNU_DesMnu
    End Get
    Set(ByVal value As String)
      _PSMMTMNU_DesMnu = value
    End Set
  End Property

  Public Property PSSESTRG_Mnu() As String
    Get
      Return _PSSESTRG_Mnu
    End Get
    Set(ByVal value As String)
      _PSSESTRG_Mnu = value
    End Set
  End Property
End Class
