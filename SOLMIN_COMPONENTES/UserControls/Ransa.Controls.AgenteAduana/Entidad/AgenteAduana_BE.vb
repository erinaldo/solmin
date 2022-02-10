Imports System.Reflection

Public Class AgenteAduana_BE
  Inherits Base_BE
  Public Sub New()
    Dim Propiedades() As PropertyInfo = Me.GetType.GetProperties()
    For Each Propiedad As PropertyInfo In Propiedades
      Dim Valor As Object = Propiedad.PropertyType.ToString
      Select Case Valor
        Case "System.String"
          Propiedad.SetValue(Me, "", Nothing)
        Case "System.Int8", "System.Int16", "System.Int32", "System.Int64"
          Propiedad.SetValue(Me, 0, Nothing)
        Case "System.Decimal", "System.Double"
          Propiedad.SetValue(Me, 0D, Nothing)
        Case "System.DateTime"
          Propiedad.SetValue(Me, #12:00:00 AM#, Nothing)
      End Select
    Next
  End Sub

  Private _PNCAGNAD As Decimal
  Private _PNCCLNT As Decimal
  Private _PSNRUCTR As String
  Private _PSTCMAA As String
  Private _PSTABAA As String
  Private _PSTABTRT As String
  Private _PSTRPRTR As String
  Private _PSNLBELR As String
  Private _PSNEMMTC As String
  Private _PNNRKNTR As Decimal
  Private _PNFULTAC As Decimal
  Private _PNHULTAC As Decimal
  Private _PSCULUSA As String
  Private _PSNTRMNL As String
  Private _PSCUSCRT As String
  Private _PNFCHCRT As Decimal
  Private _PNHRACRT As Decimal
  Private _PSNTRMCR As String
  Private _PSTDRCTR As String
  Private _PSTLFTRP As String
  Private _PNUPDATE_IDENT As Decimal

  Public Property PNCAGNAD() As Decimal
    Get
      Return (_PNCAGNAD)
    End Get
    Set(ByVal value As Decimal)
      _PNCAGNAD = value
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

  Public Property PSNRUCTR() As String
    Get
      Return (_PSNRUCTR)
    End Get
    Set(ByVal value As String)
      _PSNRUCTR = value
    End Set
  End Property



  Public Property PSTABAA() As String
    Get
      Return (_PSTABAA)
    End Get
    Set(ByVal value As String)
      _PSTABAA = value
    End Set
  End Property

  Public Property PSTCMAA() As String
    Get
      Return (_PSTCMAA)
    End Get
    Set(ByVal value As String)
      _PSTCMAA = value
    End Set
  End Property
  Public Property PSTABTRT() As String
    Get
      Return (_PSTABTRT)
    End Get
    Set(ByVal value As String)
      _PSTABTRT = value
    End Set
  End Property
  Public Property PSTRPRTR() As String
    Get
      Return (_PSTRPRTR)
    End Get
    Set(ByVal value As String)
      _PSTRPRTR = value
    End Set
  End Property
  Public Property PSNLBELR() As String
    Get
      Return (_PSNLBELR)
    End Get
    Set(ByVal value As String)
      _PSNLBELR = value
    End Set
  End Property
  Public Property PSNEMMTC() As String
    Get
      Return (_PSNEMMTC)
    End Get
    Set(ByVal value As String)
      _PSNEMMTC = value
    End Set
  End Property
  Public Property PNNRKNTR() As Decimal
    Get
      Return (_PNNRKNTR)
    End Get
    Set(ByVal value As Decimal)
      _PNNRKNTR = value
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
  Public Property PSNTRMNL() As String
    Get
      Return (_PSNTRMNL)
    End Get
    Set(ByVal value As String)
      _PSNTRMNL = value
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
  Public Property PNFCHCRT() As Decimal
    Get
      Return (_PNFCHCRT)
    End Get
    Set(ByVal value As Decimal)
      _PNFCHCRT = value
    End Set
  End Property
  Public Property PNHRACRT() As Decimal
    Get
      Return (_PNHRACRT)
    End Get
    Set(ByVal value As Decimal)
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
  Public Property PSTDRCTR() As String
    Get
      Return (_PSTDRCTR)
    End Get
    Set(ByVal value As String)
      _PSTDRCTR = value
    End Set
  End Property
  Public Property PSTLFTRP() As String
    Get
      Return (_PSTLFTRP)
    End Get
    Set(ByVal value As String)
      _PSTLFTRP = value
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
End Class
