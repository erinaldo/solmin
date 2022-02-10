'*********************************************************************'
'** Autor: Rafael Gamboa                                            **'
'** Fecha de Creación: 27/07/2009                                   **'
'** Descripción: CAPA DE ENTIDADES.                                 **'
'*********************************************************************'
Namespace mantenimientos
  'entidad de la tabla RZST10
  Public Class PaseConductor
    Inherits Chofer
    Private _CBRCNT As String = ""
    Private _NCOPSE As Double = 0
    Private _NEW_NCOPSE As Double = 0
    Private _NOMPSE As String = ""
    Private _FECREG As String = ""
    Private _TOBS As String = ""
    Private _FECINI As String = ""
    Private _FECFIN As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _OLD_PNFECINI As String = ""


    Public Property NOMPSE() As String
      Get
        Return _NOMPSE
      End Get
      Set(ByVal value As String)
        _NOMPSE = value
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

    Public Property NEW_NCOPSE() As Double
      Get
        Return _NEW_NCOPSE
      End Get
      Set(ByVal value As Double)
        _NEW_NCOPSE = value
      End Set
    End Property

    Public Property FECREG() As String
      Get
        Return _FECREG
      End Get
      Set(ByVal value As String)
        _FECREG = value
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

    Public Property OLD_PNFECINI() As String
      Get
        Return _OLD_PNFECINI
      End Get
      Set(ByVal value As String)
        _OLD_PNFECINI = value
      End Set
    End Property
    End Class

End Namespace