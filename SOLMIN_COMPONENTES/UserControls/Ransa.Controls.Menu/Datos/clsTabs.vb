Public Class clsTabs
  Private bolTab0 As Boolean
  Private bolTab1 As Boolean
  Private bolTab2 As Boolean
  
  Sub New()
    bolTab0 = False : bolTab1 = False : bolTab2 = False
  End Sub

  Public Sub Limpiar()
    bolTab0 = False : bolTab1 = False : bolTab2 = False
  End Sub

  Public Sub Cargar_Tab(ByVal pintTab As Integer)
    Select Case pintTab
      Case 0
        bolTab0 = True
      Case 1
        bolTab1 = True
      Case 2
        bolTab2 = True
    End Select
  End Sub

  Public Function Tab_Cargado(ByVal pintTab As Integer) As Boolean
    Select Case pintTab
      Case 0
        Return bolTab0
      Case 1
        Return bolTab1
      Case 2
        Return bolTab2
    End Select
  End Function
End Class
