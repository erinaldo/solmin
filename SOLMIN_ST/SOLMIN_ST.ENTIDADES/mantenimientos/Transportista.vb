Namespace mantenimientos

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
        Private _FLARSO As String = ""
        Private _SINDRC_S As String = ""
        Private _CANT_TRACTO As Integer = 0
        Private _CANT_ACOPLADO As Integer = 0
        Private _CANT_EQUIPO As Integer = 0
        Private _TipoRecurso As String = ""
        Private _Placa As String = ""
        Private _CANT_COD_SAP As Decimal = 0
        Private _TRANSPORTISTA_AS As String = ""
        Private _CTRSPT_AS As Decimal = 0
        Private _COD_SAP As String = ""
        'Private _DIREC As String = ""
        Private _CODRESPSEG As String = ""
        Private _PORSEGCARGA As Decimal = 0
        'Private _TABTRT As String = ""
        Private _RESPSEG As String = ""
    

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

        'Public Property TABTRT() As String
        '  Get
        '    Return _TABTRT
        '  End Get
        '  Set(ByVal Value As String)
        '    _TABTRT = Value
        '  End Set
        'End Property

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

        Public Property FLARSO() As String
            Get
                Return _FLARSO
            End Get
            Set(ByVal value As String)
                _FLARSO = value
            End Set
        End Property

        Public Property SINDRC_S() As String
            Get
                Return _SINDRC_S
            End Get
            Set(ByVal value As String)
                _SINDRC_S = value
            End Set
        End Property

        Public Property CANT_TRACTO() As Integer
            Get
                Return _CANT_TRACTO
            End Get
            Set(ByVal value As Integer)
                _CANT_TRACTO = value
            End Set
        End Property

        Public Property CANT_ACOPLADO() As Integer
            Get
                Return _CANT_ACOPLADO
            End Get
            Set(ByVal value As Integer)
                _CANT_ACOPLADO = value
            End Set
        End Property

        Public Property CANT_EQUIPO() As Integer
            Get
                Return _CANT_EQUIPO
            End Get
            Set(ByVal value As Integer)
                _CANT_EQUIPO = value
            End Set
        End Property


        Public Property TipoRecurso() As String
            Get
                Return _TipoRecurso
            End Get
            Set(ByVal value As String)
                _TipoRecurso = value
            End Set
        End Property
        Public Property Placa() As String
            Get
                Return _Placa
            End Get
            Set(ByVal value As String)
                _Placa = value
            End Set
        End Property

        Public Property CANT_COD_SAP() As Decimal
            Get
                Return _CANT_COD_SAP
            End Get
            Set(ByVal value As Decimal)
                _CANT_COD_SAP = value
            End Set
        End Property

        Public Property TRANSPORTISTA_AS() As String
            Get
                Return _TRANSPORTISTA_AS
            End Get
            Set(ByVal value As String)
                _TRANSPORTISTA_AS = value
            End Set
        End Property

        Public Property CTRSPT_AS() As Decimal
            Get
                Return _CTRSPT_AS
            End Get
            Set(ByVal value As Decimal)
                _CTRSPT_AS = value
            End Set
        End Property

        Public Property COD_SAP() As String
            Get
                Return _COD_SAP
            End Get
            Set(ByVal value As String)
                _COD_SAP = value
            End Set
        End Property

        'Public Property DIREC() As String
        '    Get
        '        Return _DIREC
        '    End Get
        '    Set(ByVal value As String)
        '        _DIREC = value
        '    End Set
        'End Property

        Public Property CODRESPSEG() As String
            Get
                Return _CODRESPSEG
            End Get
            Set(ByVal value As String)
                _CODRESPSEG = value
            End Set
        End Property

        Public Property PORSEGCARGA() As Decimal
            Get
                Return _PORSEGCARGA
            End Get
            Set(ByVal value As Decimal)
                _PORSEGCARGA = value
            End Set
        End Property

        Public Property TABTRT() As String
            Get
                Return _TABTRT
            End Get
            Set(ByVal value As String)
                _TABTRT = value
            End Set
        End Property

        Public Property RESPSEG() As String
            Get
                Return _RESPSEG
            End Get
            Set(ByVal value As String)
                _RESPSEG = value
            End Set
        End Property


        
  End Class

End Namespace