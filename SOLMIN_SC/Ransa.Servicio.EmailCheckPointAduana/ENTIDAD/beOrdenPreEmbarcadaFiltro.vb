Public Class beOrdenPreEmbarcadaFiltro
    Private _PNNRPEMB As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PSNORCML As String = ""
    Private _PNNRPARC As Decimal = 0
    Private _PNNRITOC As Decimal = 0
    Private _PSTCMPL As String = ""
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PNNRPARC() As Decimal
        Get
            Return (_PNNRPARC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRPARC = value
        End Set
    End Property
    Public Property PNNRITOC() As Decimal
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property

    Public Property PSTCMPL() As String
        Get
            Return (_PSTCMPL)
        End Get
        Set(ByVal value As String)
            _PSTCMPL = value
        End Set
    End Property


    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property




End Class
