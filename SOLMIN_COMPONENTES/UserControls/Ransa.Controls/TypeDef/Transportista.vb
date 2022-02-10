
Namespace mantenimiento

    Public Class Transportista
        Private _NRUCTR As String = ""
        Private _CTRSPT As String = ""
        Private _TCMTRT As String = ""
        Private _TABTRT As String = ""
        Private _TDRCTR As String = ""
        Private _TLFTRP As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As String = ""
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""
        Private _NEWCTRSPT As String = ""
        Private _SINDRC As String = ""
        Private _TRACTOS_ASIGNADOS As Integer = 0
        Private _ACOPLADOS_ASIGNADOS As Integer = 0
        Private _CHOFERES_ASIGNADOS As Integer = 0
        Private _CCMPN As String
        Private _CDVSN As String
        Private _CPLNDV As Double = 0
        Private _RUCPR2 As String = ""

        Public Property CPLNDV() As Double
            Get
                Return _CPLNDV
            End Get
            Set(ByVal value As Double)
                _CPLNDV = value
            End Set
        End Property

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
            End Set
        End Property

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property


        Public Property CHOFERES_ASIGNADOS() As Integer
            Get
                Return _CHOFERES_ASIGNADOS
            End Get
            Set(ByVal Value As Integer)
                _CHOFERES_ASIGNADOS = Value
            End Set
        End Property

        Public Property ACOPLADOS_ASIGNADOS() As Integer
            Get
                Return _ACOPLADOS_ASIGNADOS
            End Get
            Set(ByVal Value As Integer)
                _ACOPLADOS_ASIGNADOS = Value
            End Set
        End Property

        Public Property TRACTOS_ASIGNADOS() As Integer
            Get
                Return _TRACTOS_ASIGNADOS
            End Get
            Set(ByVal Value As Integer)
                _TRACTOS_ASIGNADOS = Value
            End Set
        End Property

        Public Property SINDRC() As String
            Get
                Return _SINDRC
            End Get
            Set(ByVal Value As String)
                _SINDRC = Value
            End Set
        End Property

        Public Property CTRSPT() As String
            Get
                Return _CTRSPT
            End Get
            Set(ByVal Value As String)
                _CTRSPT = Value
            End Set
        End Property

        Public Property TCMTRT() As String
            Get
                Return _TCMTRT
            End Get
            Set(ByVal Value As String)
                _TCMTRT = Value
            End Set
        End Property

        Public Property TABTRT() As String
            Get
                Return _TABTRT
            End Get
            Set(ByVal Value As String)
                _TABTRT = Value
            End Set
        End Property

        Public Property NRUCTR() As String
            Get
                Return _NRUCTR
            End Get
            Set(ByVal Value As String)
                _NRUCTR = Value
            End Set
        End Property

        Public Property TDRCTR() As String
            Get
                Return _TDRCTR
            End Get
            Set(ByVal Value As String)
                _TDRCTR = Value
            End Set
        End Property

        Public Property TLFTRP() As String
            Get
                Return _TLFTRP
            End Get
            Set(ByVal Value As String)
                _TLFTRP = Value
            End Set
        End Property

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal value As String)
                _SESTRG = value
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

        Public Property HRACRT() As Double
            Get
                Return _HRACRT
            End Get
            Set(ByVal Value As Double)
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

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Double)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Double)
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

        Public Property NEWCTRSPT() As String
            Get
                Return _NEWCTRSPT
            End Get
            Set(ByVal Value As String)
                _NEWCTRSPT = Value
            End Set
        End Property

        Public Property RUCPR2() As String
            Get
                Return _RUCPR2
            End Get
            Set(ByVal value As String)
                _RUCPR2 = value
            End Set
        End Property

    End Class

End Namespace