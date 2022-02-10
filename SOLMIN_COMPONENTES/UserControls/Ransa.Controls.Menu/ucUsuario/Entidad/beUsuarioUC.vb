Imports System.Reflection

Public Class beUsuarioUC
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

  Private _PSMMCUSR As String = ""
  Private _PSMMNUSR As String = ""

  Public Property PSMMCUSR() As String
    Get
      Return _PSMMCUSR
    End Get
    Set(ByVal value As String)
      _PSMMCUSR = value
    End Set
  End Property

  Public Property PSMMNUSR() As String
    Get
      Return _PSMMNUSR
    End Get
    Set(ByVal value As String)
      _PSMMNUSR = value
    End Set
  End Property


End Class
