
Public Class beLote
    Inherits beBase(Of beLote)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    Private _CCLNT As Decimal = 0


    Private _NORDSR As Decimal = 0
    Private _NCRRIN As Decimal = 0
    Private _CMRCLR As String = ""
    Private _TMRCD2 As String = ""
    Private _CRTLTE As String = ""
    Private _CPRVCL As Decimal = 0
    Private _TPRVCL As String = ""

    Private _NDCMPV As String = ""
    Private _CMNCT As Decimal = 0
    Private _IMPTTL As Decimal = 0
    Private _CMNVTA As Decimal = 0
    Private _IMPVTA As Decimal = 0
    Private _FINGAL As Decimal = 0
    Private _FPRDMR As Decimal = 0

    Private _FVNLTE As Decimal = 0
    Private _NTRNO As Decimal = 0
    Private _TOBSCR As String = 0
    Private _QINMC2 As Decimal = 0
    Private _QINMP2 As Decimal = 0
    Private _QDSMC2 As Decimal = 0
    Private _QDSMP2 As Decimal = 0

    Private _QCMMC1 As Decimal = 0
    Private _QCMMP1 As Decimal = 0
    Private _QMRCSL As Decimal = 0
    Private _QPSOSL As Decimal = 0


    'Private _Lista As List(Of BeUbicacionesLotes)
    'Public ReadOnly Property Lista() As List(Of BeUbicacionesLotes)
    '    Get
    '        Return _Lista
    '    End Get
    'End Property



    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public Property NORDSR() As Decimal
        Get
            Return _NORDSR
        End Get
        Set(ByVal value As Decimal)
            _NORDSR = value
        End Set
    End Property

    Public Property NCRRIN() As Decimal
        Get
            Return _NCRRIN
        End Get
        Set(ByVal value As Decimal)
            _NCRRIN = value
        End Set
    End Property

    Public Property CMRCLR() As String
        Get
            Return _CMRCLR
        End Get
        Set(ByVal value As String)
            _CMRCLR = value
        End Set
    End Property

    Public Property TMRCD2() As String
        Get
            Return _TMRCD2
        End Get
        Set(ByVal value As String)
            _TMRCD2 = value
        End Set
    End Property

    Public Property CRTLTE() As String
        Get
            Return _CRTLTE
        End Get
        Set(ByVal value As String)
            _CRTLTE = value
        End Set
    End Property

    Public Property CPRVCL() As Decimal
        Get
            Return _CPRVCL
        End Get
        Set(ByVal value As Decimal)
            _CPRVCL = value
        End Set
    End Property

    Public Property TPRVCL() As String
        Get
            Return _TPRVCL
        End Get
        Set(ByVal value As String)
            _TPRVCL = value
        End Set
    End Property

    Public Property NDCMPV() As String
        Get
            Return _NDCMPV
        End Get
        Set(ByVal value As String)
            _NDCMPV = value
        End Set
    End Property

    Public Property CMNCT() As Decimal
        Get
            Return _CMNCT
        End Get
        Set(ByVal value As Decimal)
            _CMNCT = value
        End Set
    End Property

    Public Property IMPTTL() As Decimal
        Get
            Return _IMPTTL
        End Get
        Set(ByVal value As Decimal)
            _IMPTTL = value
        End Set
    End Property

    Public Property CMNVTA() As Decimal
        Get
            Return _CMNVTA
        End Get
        Set(ByVal value As Decimal)
            _CMNVTA = value
        End Set
    End Property

    Public Property IMPVTA() As Decimal
        Get
            Return _IMPVTA
        End Get
        Set(ByVal value As Decimal)
            _IMPVTA = value
        End Set
    End Property

    Public Property FINGAL() As Decimal
        Get
            Return _FINGAL
        End Get
        Set(ByVal value As Decimal)
            _FINGAL = value
        End Set
    End Property

    Public Property FPRDMR() As Decimal
        Get
            Return _FPRDMR
        End Get
        Set(ByVal value As Decimal)
            _FPRDMR = value
        End Set
    End Property

    Public Property FVNLTE() As Decimal
        Get
            Return _FVNLTE
        End Get
        Set(ByVal value As Decimal)
            _FVNLTE = value
        End Set
    End Property

    Public Property NTRNO() As Decimal
        Get
            Return _NTRNO
        End Get
        Set(ByVal value As Decimal)
            _NTRNO = value
        End Set
    End Property

    Public Property TOBSCR() As String
        Get
            Return _TOBSCR
        End Get
        Set(ByVal value As String)
            _TOBSCR = value
        End Set
    End Property

    Public Property QINMC2() As Decimal
        Get
            Return _QINMC2
        End Get
        Set(ByVal value As Decimal)
            _QINMC2 = value
        End Set
    End Property

    Public Property QINMP2() As Decimal
        Get
            Return _QINMP2
        End Get
        Set(ByVal value As Decimal)
            _QINMP2 = value
        End Set
    End Property

    Public Property QDSMC2() As Decimal
        Get
            Return _QDSMC2
        End Get
        Set(ByVal value As Decimal)
            _QDSMC2 = value
        End Set
    End Property

    Public Property QDSMP2() As Decimal
        Get
            Return _QDSMP2
        End Get
        Set(ByVal value As Decimal)
            _QDSMP2 = value
        End Set
    End Property

    Public Property QCMMC1() As Decimal
        Get
            Return _QCMMC1
        End Get
        Set(ByVal value As Decimal)
            If _QCMMC1 = value Then
                Return
            End If
            _QCMMC1 = value
        End Set
    End Property

    Public Property QCMMP1() As Decimal
        Get
            Return _QCMMP1
        End Get
        Set(ByVal value As Decimal)
            If _QCMMP1 = value Then
                Return
            End If
            _QCMMP1 = value
        End Set
    End Property

    Public Property QMRCSL() As Decimal
        Get
            Return _QMRCSL
        End Get
        Set(ByVal value As Decimal)
            If _QMRCSL = value Then
                Return
            End If
            _QMRCSL = value
        End Set
    End Property

    Public Property QPSOSL() As Decimal
        Get
            Return _QPSOSL
        End Get
        Set(ByVal value As Decimal)
            If _QPSOSL = value Then
                Return
            End If
            _QPSOSL = value
        End Set
    End Property


    Private _NUEVO As Boolean
    Public Property NUEVO() As Boolean
        Get
            Return _NUEVO
        End Get
        Set(ByVal value As Boolean)
            _NUEVO = value
        End Set
    End Property


    Private _QTRMC As Decimal
    Public Property QTRMC() As Decimal
        Get
            Return _QTRMC
        End Get
        Set(ByVal value As Decimal)
            _QTRMC = value
        End Set
    End Property


    Private _QTRMP As Decimal
    Public Property QTRMP() As Decimal
        Get
            Return _QTRMP
        End Get
        Set(ByVal value As Decimal)
            _QTRMP = value
        End Set
    End Property

    Private _CTPOAT As String
    Public Property CTPOAT() As String
        Get
            Return _CTPOAT
        End Get
        Set(ByVal value As String)
            _CTPOAT = value
        End Set
    End Property

    Private _NGUIRN As Decimal
    Public Property NGUIRN() As Decimal
        Get
            Return _NGUIRN
        End Get
        Set(ByVal value As Decimal)
            _NGUIRN = value
        End Set
    End Property

    Private _NSLCS1 As Decimal
    Public Property NSLCS1() As Decimal
        Get
            Return _NSLCS1
        End Get
        Set(ByVal value As Decimal)
            _NSLCS1 = value
        End Set
    End Property

    Private _CTPALM As String
    Public Property CTPALM() As String
        Get
            Return _CTPALM
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property

    Private _CALMC As String
    Public Property CALMC() As String
        Get
            Return _CALMC
        End Get
        Set(ByVal value As String)
            _CALMC = value
        End Set
    End Property

    Private _CZNALM As String
    Public Property CZNALM() As String
        Get
            Return _CZNALM
        End Get
        Set(ByVal value As String)
            _CZNALM = value
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

End Class
