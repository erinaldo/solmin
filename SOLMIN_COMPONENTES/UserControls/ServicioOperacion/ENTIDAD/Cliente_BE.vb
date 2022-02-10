Public Class Cliente_BE
    'Inherits Base(Of Cliente)
    ''Inherits Base_BE

    Private _NRCTCL As Decimal = 0
    Private _CCLNT As Decimal = 0
    Private _DESCAR As String = ""
    Private _NOMCAR As String = ""
    Private _Correcto As Integer = 0
    Private _LIST_CRGVTA As String = ""
    Private _CRGVTA As String = ""
    Private _TCRVTA As String = ""

    Property Correcto() As Integer
        Get
            Return _Correcto
        End Get
        Set(ByVal value As Integer)
            _Correcto = value
        End Set
    End Property

    Property NRCTCL() As Decimal
        Get
            Return _NRCTCL
        End Get
        Set(ByVal value As Decimal)
            _NRCTCL = value
        End Set
    End Property


    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Private _ERROR As String
    Public Property PELIGRO() As String
        Get
            Return _ERROR
        End Get
        Set(ByVal value As String)
            _ERROR = value
        End Set
    End Property

    Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Property DESCAR() As String
        Get
            Return _DESCAR
        End Get
        Set(ByVal value As String)
            _DESCAR = value
        End Set
    End Property
    Property NOMCAR() As String
        Get
            Return _NOMCAR
        End Get
        Set(ByVal value As String)
            _NOMCAR = value
        End Set
    End Property


    Private _CUSCRT As String
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property


    Private _FCHCRT As Decimal
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property


    Private _HRACRT As Decimal
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property


    Private _CULUSA As String
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property


    Private _FULTAC As Decimal
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Private _DECIMAL As Decimal
    Public Property HULTAC() As Decimal
        Get
            Return _DECIMAL
        End Get
        Set(ByVal value As Decimal)
            _DECIMAL = value
        End Set
    End Property


    Private _TCMPCL As String
    Public Property TCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
        End Set
    End Property


    Private _NRUC As Decimal
    Public Property NRUC() As Decimal
        Get
            Return _NRUC
        End Get
        Set(ByVal value As Decimal)
            _NRUC = value
        End Set
    End Property


    Private _TMTVBJ As String
    Public Property TMTVBJ() As String
        Get
            Return _TMTVBJ
        End Get
        Set(ByVal value As String)
            _TMTVBJ = value
        End Set
    End Property


    Private _CANT_CLIENTE As Integer
    Public Property CANT_CLIENTE() As Integer
        Get
            Return _CANT_CLIENTE
        End Get
        Set(ByVal value As Integer)
            _CANT_CLIENTE = value
        End Set
    End Property


    Private _CANT_CONTRATO As Integer
    Public Property CANT_CONTRATO() As Integer
        Get
            Return _CANT_CONTRATO
        End Get
        Set(ByVal value As Integer)
            _CANT_CONTRATO = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property


    Private _CANT_DOCUMENTO As Integer
    Public Property CANT_DOCUMENTO() As Integer
        Get
            Return _CANT_DOCUMENTO
        End Get
        Set(ByVal value As Integer)
            _CANT_DOCUMENTO = value
        End Set
    End Property

    Public Property LIST_CRGVTA() As String
        Get
            Return _LIST_CRGVTA
        End Get
        Set(ByVal value As String)
            _LIST_CRGVTA = value
        End Set
    End Property

    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Public Property TCRVTA() As String
        Get
            Return _TCRVTA
        End Get
        Set(ByVal value As String)
            _TCRVTA = value
        End Set
    End Property


End Class
