Imports System.Reflection

Public Class Base_BE
  Private _PageSize As Integer
  Public Property PageSize() As Integer
    Get
      Return _PageSize
    End Get
    Set(ByVal value As Integer)
      _PageSize = value
    End Set
  End Property

  Private _PageCount As Integer
  Public Property PageCount() As Integer
    Get
      Return _PageCount
    End Get
    Set(ByVal value As Integer)
      _PageCount = value
    End Set
  End Property

  Private _PageNumber As Integer
  Public Property PageNumber() As Integer
    Get
      Return _PageNumber
    End Get
    Set(ByVal value As Integer)
      _PageNumber = value
    End Set
  End Property

  Public Sub New()
    Me._PageSize = 0
    Me.PageCount = 0
    Me.PageNumber = 0
  End Sub
End Class

Public Class beList(Of T As Base_BE)
  Inherits List(Of T)
  Private _PageCount As Int32
  Public Property PageCount() As Int32
    Get
      Return _PageCount
    End Get
    Set(ByVal value As Int32)
      _PageCount = value
    End Set
  End Property
End Class
