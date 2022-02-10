Public Class beAprobacionMargen

    Private _PNNOPRCN As Decimal = 0
    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property

    Private _PNCTRMNC As Decimal = 0
    Public Property PNCTRMNC() As Decimal
        Get
            Return _PNCTRMNC
        End Get
        Set(ByVal value As Decimal)
            _PNCTRMNC = value
        End Set
    End Property

    Private _PNNGUIRM As Decimal = 0
    Public Property PNNGUIRM() As Decimal
        Get
            Return _PNNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property

    Private _PNNMOPRP As Decimal = 0
    Public Property PNNMOPRP() As Integer
        Get
            Return _PNNMOPRP
        End Get
        Set(ByVal value As Integer)
            _PNNMOPRP = value
        End Set
    End Property

    Private _PNRESAPR As Decimal = 0
    Public Property PNRESAPR() As Decimal
        Get
            Return _PNRESAPR
        End Get
        Set(ByVal value As Decimal)
            _PNRESAPR = value
        End Set
    End Property


    Private _PSFLGSTA As String = ""
    Public Property PSFLGSTA() As String
        Get
            Return _PSFLGSTA
        End Get
        Set(ByVal value As String)
            _PSFLGSTA = value
        End Set
    End Property



    Private _PSTOBS As String = ""
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property



    Private _PSCULUSA As String = ""
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property

    Private _PSNTRMNL As String = ""
    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property


    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
      

End Class
