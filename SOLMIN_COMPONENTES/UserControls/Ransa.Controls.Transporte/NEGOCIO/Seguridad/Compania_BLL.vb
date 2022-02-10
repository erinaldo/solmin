
Public Class Compania_BLL

  Private objCompaniaDato As Compania_DAL
    Private oDt As List(Of mantenimientos.ClaseGeneral)

  Sub New()
    objCompaniaDato = New Compania_DAL
  End Sub

  Property Lista()
    Get
      Return oDt
    End Get
    Set(ByVal value)
      oDt = value
    End Set
  End Property

  Public Sub Crea_Lista()
    oDt = objCompaniaDato.Lista_Compania_X_Usuario()
  End Sub

End Class
