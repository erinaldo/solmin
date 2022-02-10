Public Class beAplicacion

  Private _PSMMCAPL_CodApl As String = ""
  Private _PSMMDAPL_DesApl As String = ""
  Private _PSSESTRG_Apl As String = ""

  Public Property PSMMCAPL_CodApl() As String
    Get
      Return _PSMMCAPL_CodApl
    End Get
    Set(ByVal value As String)
      _PSMMCAPL_CodApl = value
    End Set
  End Property

  Public Property PSMMDAPL_DesApl() As String
    Get
      Return _PSMMDAPL_DesApl
    End Get
    Set(ByVal value As String)
      _PSMMDAPL_DesApl = value
    End Set
  End Property

  Public Property PSSESTRG_Apl() As String
    Get
      Return _PSSESTRG_Apl
    End Get
    Set(ByVal value As String)
      _PSSESTRG_Apl = value
    End Set
  End Property

End Class
