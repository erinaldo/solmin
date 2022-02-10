Public Class clsTab
  Private bolTab0 As Boolean
  Private bolTab1 As Boolean
  Private bolTab2 As Boolean
  Private bolTab3 As Boolean
  Private bolTab4 As Boolean
  Private bolTab5 As Boolean
  Private bolTab6 As Boolean
  Private bolTab7 As Boolean

  Sub New()
    bolTab0 = False : bolTab1 = False : bolTab2 = False : bolTab3 = False : bolTab4 = False : bolTab5 = False : bolTab6 = False : bolTab7 = False
  End Sub

  Public Sub Limpiar()
    bolTab0 = False : bolTab1 = False : bolTab2 = False : bolTab3 = False : bolTab4 = False : bolTab5 = False : bolTab6 = False : bolTab7 = False
  End Sub

  Public Sub Cargar_Tab(ByVal pintTab As Integer)
    Select Case pintTab
      Case 0
        bolTab0 = True
      Case 1
        bolTab1 = True
      Case 2
        bolTab2 = True
      Case 3
        bolTab3 = True
      Case 4
        bolTab4 = True
      Case 5
        bolTab5 = True
      Case 6
        bolTab6 = True
      Case 7
        bolTab7 = True
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
      Case 3
        Return bolTab3
      Case 4
        Return bolTab4
      Case 5
        Return bolTab5
      Case 6
        Return bolTab6
      Case 7
        Return bolTab7
    End Select
  End Function
End Class

