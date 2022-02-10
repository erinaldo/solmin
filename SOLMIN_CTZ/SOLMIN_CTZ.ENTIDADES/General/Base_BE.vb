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

    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property

    Private _PNCPLNDV As Integer
    Public Property PNCPLNDV() As Integer
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Integer)
            _PNCPLNDV = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Private _PSCTPDCI As String = ""
    Public Property PSCTPDCI() As String
        Get
            Return _PSCTPDCI
        End Get
        Set(ByVal value As String)
            _PSCTPDCI = value
        End Set
    End Property

    Public Sub New()
        Me._PageSize = 0
        Me._PageCount = 0
        Me._PageNumber = 0
        Me._PSCCMPN = ""
        Me._PSCDVSN = ""
        Me._PNCPLNDV = 0
        Me._CULUSA = ""
        Me._NTRMNL = ""
        Me._PSCTPDCI = ""
    End Sub
End Class