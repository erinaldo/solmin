
Namespace Operaciones

  Public Class Junta_Transporte

#Region "Atributo"

    Private _NPLNJT As String
    Private _NCRRPL As String
    Private _FPLNJT As String
    Private _HPLNJT As String
    Private _TDSCPL As String
    Private _TRSPAT As String
    Private _QCNASI As String
    Private _SESPLN As String
    Private _SESTRG As String
    Private _CUSCRT As String
    Private _FCHCRT As String
    Private _HRACRT As String
    Private _NTRMCR As String
    Private _CULUSA As String
    Private _FULTAC As String
    Private _HULTAC As String
    Private _NTRMNL As String
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
        Private _CPLNDV As Double = 0

        Private _QPROGRAMADOS As Double = 0
        Private _QSOLICITUD As Double = 0
        Private _ESTADO_JNT As String = ""
 

#End Region

#Region "Properties"

    Public Property NPLNJT() As String
      Get
        Return _NPLNJT
      End Get
      Set(ByVal Value As String)
        _NPLNJT = Value
      End Set
    End Property

    Public Property NCRRPL() As String
      Get
        Return _NCRRPL
      End Get
      Set(ByVal Value As String)
        _NCRRPL = Value
      End Set
    End Property

    Public Property FPLNJT() As String
      Get
        Return _FPLNJT
      End Get
      Set(ByVal Value As String)
        _FPLNJT = Value
      End Set
    End Property

    Public Property HPLNJT() As String
      Get
        Return _HPLNJT
      End Get
      Set(ByVal Value As String)
        _HPLNJT = Value
      End Set
    End Property

    Public Property TDSCPL() As String
      Get
        Return _TDSCPL
      End Get
      Set(ByVal Value As String)
        _TDSCPL = Value
      End Set
    End Property

    Public Property TRSPAT() As String
      Get
        Return _TRSPAT
      End Get
      Set(ByVal Value As String)
        _TRSPAT = Value
      End Set
    End Property

    Public Property QCNASI() As String
      Get
        Return _QCNASI
      End Get
      Set(ByVal Value As String)
        _QCNASI = Value
      End Set
    End Property

    Public Property SESPLN() As String
      Get
        Return _SESPLN
      End Get
      Set(ByVal Value As String)
        _SESPLN = Value
      End Set
    End Property

    Public Property SESTRG() As String
      Get
        Return _SESTRG
      End Get
      Set(ByVal Value As String)
        _SESTRG = Value
      End Set
    End Property

    Public Property CUSCRT() As String
      Get
        Return _CUSCRT
      End Get
      Set(ByVal Value As String)
        _CUSCRT = Value
      End Set
    End Property

    Public Property FCHCRT() As String
      Get
        Return _FCHCRT
      End Get
      Set(ByVal Value As String)
        _FCHCRT = Value
      End Set
    End Property

    Public Property HRACRT() As String
      Get
        Return _HRACRT
      End Get
      Set(ByVal Value As String)
        _HRACRT = Value
      End Set
    End Property

    Public Property NTRMCR() As String
      Get
        Return _NTRMCR
      End Get
      Set(ByVal Value As String)
        _NTRMCR = Value
      End Set
    End Property

    Public Property CULUSA() As String
      Get
        Return _CULUSA
      End Get
      Set(ByVal Value As String)
        _CULUSA = Value
      End Set
    End Property

    Public Property FULTAC() As String
      Get
        Return _FULTAC
      End Get
      Set(ByVal Value As String)
        _FULTAC = Value
      End Set
    End Property

    Public Property HULTAC() As String
      Get
        Return _HULTAC
      End Get
      Set(ByVal Value As String)
        _HULTAC = Value
      End Set
    End Property

    Public Property NTRMNL() As String
      Get
        Return _NTRMNL
      End Get
      Set(ByVal Value As String)
        _NTRMNL = Value
      End Set
    End Property

    Public Property CCMPN() As String
      Get
        Return _CCMPN
      End Get
      Set(ByVal Value As String)
        _CCMPN = Value
      End Set
    End Property

    Public Property CDVSN() As String
      Get
        Return _CDVSN
      End Get
      Set(ByVal Value As String)
        _CDVSN = Value
      End Set
    End Property

    Public Property CPLNDV() As Double
      Get
        Return _CPLNDV
      End Get
      Set(ByVal Value As Double)
        _CPLNDV = Value
      End Set
        End Property


        Public Property QPROGRAMADOS() As Double
            Get
                Return _QPROGRAMADOS
            End Get
            Set(ByVal Value As Double)
                _QPROGRAMADOS = Value
            End Set
        End Property


        Public Property QSOLICITUD() As Double
            Get
                Return _QSOLICITUD
            End Get
            Set(ByVal Value As Double)
                _QSOLICITUD = Value
            End Set
        End Property

        Private _QREQUERIMIENTOS As Decimal = 0D
        Public Property QREQUERIMIENTOS() As Decimal
            Get
                Return _QREQUERIMIENTOS
            End Get
            Set(ByVal value As Decimal)
                _QREQUERIMIENTOS = value
            End Set
        End Property

        Private _QUNIDADES As Decimal = 0D
        Public Property QUNIDADES() As Decimal
            Get
                Return _QUNIDADES
            End Get
            Set(ByVal value As Decimal)
                _QUNIDADES = value
            End Set
        End Property

        Public Property ESTADO_JNT() As String
            Get
                Return _ESTADO_JNT
            End Get
            Set(ByVal Value As String)
                _ESTADO_JNT = Value
            End Set
        End Property
        '

#End Region

  End Class

End Namespace
