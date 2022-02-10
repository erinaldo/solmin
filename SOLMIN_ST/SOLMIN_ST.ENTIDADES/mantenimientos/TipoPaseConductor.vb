'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 27/07/2009                                   **'
'** Descripción: CAPA DE ENTIDADES.                                 **'
'*********************************************************************'
Namespace mantenimientos
    'entidad de la tabla RZST14
  Public Class TipoPaseConductor
    Private _NCOPSE As Double = 0
    Private _NOMPSE As String = ""
    Private _TOBS As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""


        Private _CCMPN As String
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property


    Public Property NCOPSE() As Double
      Get
        Return _NCOPSE
      End Get
      Set(ByVal value As Double)
        _NCOPSE = value
      End Set
    End Property

    Public Property NOMPSE() As String
      Get
        Return _NOMPSE
      End Get
      Set(ByVal value As String)
        _NOMPSE = value
      End Set
    End Property

    Public Property TOBS() As String
      Get
        Return _TOBS
      End Get
      Set(ByVal value As String)
        _TOBS = value
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