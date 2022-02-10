Public Class RangoTarifaXTarifaFlete


    Inherits Base(Of RangoTarifaXTarifaFlete)


    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

#Region "Atributos"
    Private _CCMPN As String
    Private _NRCTSL As Decimal
    Private _NRTFSV As Decimal
    Private _NCRRSR As Decimal
    Private _NSEQIN As Decimal
    Private _QIMPIN As Decimal
    Private _QIMPFN As Decimal
    Private _ITRSRT As Decimal
    Private _ITRAPG As Decimal
    Private _FULTAC As Decimal
    Private _HULTAC As Decimal
    Private _CULUSA As String
    Private _NTRMNL As String
    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _CUSCRT As String
    Private _NTRMNC As String
    Private _VALOR As Decimal
    Private _SESTRG As String
    Private _ISRVTI As Decimal 'RCS-HUNDRED

    Private _QRNGBS As Decimal = 0
    Private _ITRCAD As Decimal = 0
    Private _ITRPAD As Decimal = 0




#End Region
#Region "Propiedades"
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            If _CCMPN = value Then
                Return
            End If
            _CCMPN = value
        End Set
    End Property
    Public Property NRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            If _NRCTSL = value Then
                Return
            End If
            _NRCTSL = value
        End Set
    End Property
    Public Property NRTFSV() As Decimal
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Decimal)
            If _NRTFSV = value Then
                Return
            End If
            _NRTFSV = value
        End Set
    End Property
    Public Property NCRRSR() As Decimal
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Decimal)
            If _NCRRSR = value Then
                Return
            End If
            _NCRRSR = value
        End Set
    End Property
    Public Property NSEQIN() As Decimal
        Get
            Return _NSEQIN
        End Get
        Set(ByVal value As Decimal)
            If _NSEQIN = value Then
                Return
            End If
            _NSEQIN = value
        End Set
    End Property
    Public Property QIMPIN() As Decimal
        Get
            Return _QIMPIN
        End Get
        Set(ByVal value As Decimal)
            If _QIMPIN = value Then
                Return
            End If
            _QIMPIN = value
        End Set
    End Property
    Public Property QIMPFN() As Decimal
        Get
            Return _QIMPFN
        End Get
        Set(ByVal value As Decimal)
            If _QIMPFN = value Then
                Return
            End If
            _QIMPFN = value
        End Set
    End Property
    Public Property ITRSRT() As Decimal
        Get
            Return _ITRSRT
        End Get
        Set(ByVal value As Decimal)
            If _ITRSRT = value Then
                Return
            End If
            _ITRSRT = value
        End Set
    End Property
    Public Property ITRAPG() As Decimal
        Get
            Return _ITRAPG
        End Get
        Set(ByVal value As Decimal)
            If _ITRAPG = value Then
                Return
            End If
            _ITRAPG = value
        End Set
    End Property
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            If _FULTAC = value Then
                Return
            End If
            _FULTAC = value
        End Set
    End Property
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            If _HULTAC = value Then
                Return
            End If
            _HULTAC = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            If _CULUSA = value Then
                Return
            End If
            _CULUSA = value
        End Set
    End Property
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            If _NTRMNL = value Then
                Return
            End If
            _NTRMNL = value
        End Set
    End Property
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            If _FCHCRT = value Then
                Return
            End If
            _FCHCRT = value
        End Set
    End Property
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            If _HRACRT = value Then
                Return
            End If
            _HRACRT = value
        End Set
    End Property
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            If _CUSCRT = value Then
                Return
            End If
            _CUSCRT = value
        End Set
    End Property
    Public Property NTRMNC() As String
        Get
            Return _NTRMNC
        End Get
        Set(ByVal value As String)
            If _NTRMNC = value Then
                Return
            End If
            _NTRMNC = value
        End Set
    End Property

    Public Property VALOR() As Decimal
        Get
            Return _VALOR
        End Get
        Set(ByVal value As Decimal)
            If _VALOR = value Then
                Return
            End If
            _VALOR = value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            If _SESTRG = value Then
                Return
            End If
            _SESTRG = value
        End Set
    End Property

    'RCS-HUNDRED-INICIO
    Public Property ISRVTI() As Decimal
        Get
            Return _ISRVTI
        End Get
        Set(ByVal value As Decimal)
            _ISRVTI = value
        End Set
    End Property

    Public Property QRNGBS() As Decimal
        Get
            Return _QRNGBS
        End Get
        Set(ByVal value As Decimal)
            _QRNGBS = value
        End Set
    End Property
    Public Property ITRCAD() As Decimal
        Get
            Return _ITRCAD
        End Get
        Set(ByVal value As Decimal)
            _ITRCAD = value
        End Set
    End Property
    Public Property ITRPAD() As Decimal
        Get
            Return _ITRPAD
        End Get
        Set(ByVal value As Decimal)
            _ITRPAD = value
        End Set
    End Property

   
#End Region
End Class

