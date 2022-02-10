Public Class RequestDataReversion 'ECM-Estimaci�n-de-Ingreso-Anulaci�n[RF002]-100516
    Private _IDESTM As Decimal = 0
    ''' <summary>
    ''' Id Estimacion 
    ''' </summary>
    Public Property IDESTM() As Decimal
        Get
            Return (_IDESTM)
        End Get
        Set(ByVal value As Decimal)
            _IDESTM = value
        End Set
    End Property

    Private _NDESAP As String = String.Empty
    ''' <summary>
    ''' Nro Dcmnto Estimaci�n SAP 
    ''' </summary>
    Public Property NDESAP() As String
        Get
            Return (_NDESAP)
        End Get
        Set(ByVal value As String)
            _NDESAP = value
        End Set
    End Property

    Private _CSCDSP As String = String.Empty
    ''' <summary>
    ''' Codigo Sociedad SAP 
    ''' </summary>
    Public Property CSCDSP() As String
        Get
            Return (_CSCDSP)
        End Get
        Set(ByVal value As String)
            _CSCDSP = value
        End Set
    End Property

    Private _ACNTSP As Decimal = 0
    ''' <summary>
    ''' A�o Contabilizaci�n SAP 
    ''' </summary>
    Public Property ACNTSP() As Decimal
        Get
            Return (_ACNTSP)
        End Get
        Set(ByVal value As Decimal)
            _ACNTSP = value
        End Set
    End Property

    Private _NDCCTE As String = String.Empty
    ''' <summary>
    ''' Num Documento Electr�nica 
    ''' </summary>
    Public Property NDCCTE() As String
        Get
            Return (_NDCCTE)
        End Get
        Set(ByVal value As String)
            _NDCCTE = value
        End Set
    End Property

    Private _FDCFCC As Decimal = 0
    ''' <summary>
    ''' Fecha de Documento Cta. Cte.
    ''' </summary>
    Public Property FDCFCC() As Decimal
        Get
            Return (_FDCFCC)
        End Get
        Set(ByVal value As Decimal)
            _FDCFCC = value
        End Set
    End Property

End Class
