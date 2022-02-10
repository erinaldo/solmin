Namespace mantenimientos

    Public Class TransportistaAcoplado
        Inherits Acoplado

        Private _NRUCTR As String = ""
        Private _FECINI As String = "0"
        Private _FECFIN As String = "0"
        Private _TOBS As String = ""
        Private _SESTAC As String = ""
        Private _SESTRG As String = ""
        Private _POS_RUC_ANTERIOR As String = ""
        Private _FLAG_SKIPCHECKS As String = ""
        Private _CDVSN As String
        Private _CPLNDV As Double = 0
        Private _CCMPN As String
        Private _ESTADO_ACOPLADO As String = ""
        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
            End Set
        End Property

    Public Property CPLNDV() As Double
      Get
        Return _CPLNDV
      End Get
      Set(ByVal value As Double)
        _CPLNDV = value
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

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal value As String)
                _FECINI = value
            End Set
        End Property

        Public Property FECFIN() As String
            Get
                Return _FECFIN
            End Get
            Set(ByVal value As String)
                _FECFIN = value
            End Set
        End Property

        Public Property TOBS() As String
            Get
                Return _TOBS
            End Get
            Set(ByVal Value As String)
                _TOBS = Value
            End Set
        End Property

        Public Property SESTAC() As String
            Get
                Return _SESTAC
            End Get
            Set(ByVal value As String)
                _SESTAC = value
            End Set
        End Property

        Public Overloads Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal value As String)
                _SESTRG = value
            End Set
        End Property

        Public Property POS_RUC_ANTERIOR() As String
            Get
                Return _POS_RUC_ANTERIOR
            End Get
            Set(ByVal value As String)
                _POS_RUC_ANTERIOR = value
            End Set
        End Property

        Public Property FLAG_SKIPCHECKS() As String
            Get
                Return _FLAG_SKIPCHECKS
            End Get
            Set(ByVal value As String)
                _FLAG_SKIPCHECKS = value
            End Set
        End Property

        Public Property ESTADO_ACOPLADO() As String
            Get
                Return _ESTADO_ACOPLADO
            End Get
            Set(ByVal value As String)
                _ESTADO_ACOPLADO = value
            End Set
        End Property


    End Class
End Namespace
