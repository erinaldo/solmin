Namespace mantenimientos
    '****************************************************************************************************
    '** Autor: Anddy Ramos
    '** Fecha de Creación: 15/07/2009 
    '** Descripción: entidades.
    '****************************************************************************************************
    Public Class TipoLicenciaConducir

        Private _NCLICO As Double = 0
        Private _CCATLI As String = ""
        Private _TCATLI As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""
        Private _CCMPN As String = ""
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property
        Public Property NCLICO() As Double
            Get
                Return _NCLICO
            End Get
            Set(ByVal value As Double)
                _NCLICO = value
            End Set
        End Property

        Public Property CCATLI() As String
            Get
                Return _CCATLI
            End Get
            Set(ByVal value As String)
                _CCATLI = value
            End Set
        End Property

        Public Property TCATLI() As String
            Get
                Return _TCATLI
            End Get
            Set(ByVal value As String)
                _TCATLI = value
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
            Set(ByVal value As String)
                _CUSCRT = value
            End Set
        End Property

        Public Property FCHCRT() As Double
            Get
                Return _FCHCRT
            End Get
            Set(ByVal value As Double)
                _FCHCRT = value
            End Set
        End Property

        Public Property HRACRT() As Double
            Get
                Return _HRACRT
            End Get
            Set(ByVal value As Double)
                _HRACRT = value
            End Set
        End Property

        Public Property NTRMCR() As String
            Get
                Return _NTRMCR
            End Get
            Set(ByVal value As String)
                _NTRMCR = value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal value As String)
                _CULUSA = value
            End Set
        End Property

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal value As Double)
                _FULTAC = value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal value As Double)
                _HULTAC = value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal value As String)
                _NTRMNL = value
            End Set
        End Property

    End Class

End Namespace