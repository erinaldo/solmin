Imports System.Reflection
Public Class beOpcionUC
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

  Private _PSMMCAPL As String = ""
  Private _PSMMCMNU As String = ""
  Private _PNMMCOPC As Decimal = 0
  Private _PSMMDOPC As String = ""


  Public Property PNMMCOPC() As Decimal
    Get
      Return _PNMMCOPC
    End Get
    Set(ByVal value As Decimal)
      _PNMMCOPC = value
    End Set
  End Property

  Public Property PSMMDOPC() As String
    Get
      Return _PSMMDOPC
    End Get
    Set(ByVal value As String)
      _PSMMDOPC = value
    End Set
  End Property

  Public Property PSMMCAPL() As String
    Get
      Return _PSMMCAPL
    End Get
    Set(ByVal value As String)
      _PSMMCAPL = value
    End Set
  End Property

  Public Property PSMMCMNU() As String
    Get
      Return _PSMMCMNU
    End Get
    Set(ByVal value As String)
      _PSMMCMNU = value
    End Set
  End Property

End Class


