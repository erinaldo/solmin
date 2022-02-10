Imports System.Reflection
Public Class beAplicacionInfoUC
  Public Sub New()
    Inicilizar()
  End Sub
  Private Sub Inicilizar()
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

  Private _PSBUSQUEDA As String

  Private _PageSize As Integer
  Private _PageCount As Integer
  Private _PageNumber As Integer

  Private _PSMMCAPL As String = ""
  Private _PSMMDAPL As String = ""
  Private _PSSESTRG As String = ""

  Public Property PSMMCAPL() As String
    Get
      Return _PSMMCAPL
    End Get
    Set(ByVal value As String)
      _PSMMCAPL = value
    End Set
  End Property

  Public Property PSMMDAPL() As String
    Get
      Return _PSMMDAPL
    End Get
    Set(ByVal value As String)
      _PSMMDAPL = value
    End Set
  End Property

  Public Property PSSESTRG() As String
    Get
      Return _PSSESTRG
    End Get
    Set(ByVal value As String)
      _PSSESTRG = value
    End Set
  End Property

  Public Property PSBUSQUEDA() As String
    Get
      Return (_PSBUSQUEDA)
    End Get
    Set(ByVal value As String)
      _PSBUSQUEDA = value
    End Set
  End Property

  Public Property PageSize() As Integer
    Get
      Return _PageSize
    End Get
    Set(ByVal value As Integer)
      _PageSize = value
    End Set
  End Property

  Public Property PageCount() As Integer
    Get
      Return _PageCount
    End Get
    Set(ByVal value As Integer)
      _PageCount = value
    End Set
  End Property

  Public Property PageNumber() As Integer
    Get
      Return _PageNumber
    End Get
    Set(ByVal value As Integer)
      _PageNumber = value
    End Set
  End Property

  Public Sub pClear()
    Inicilizar()
  End Sub
End Class
