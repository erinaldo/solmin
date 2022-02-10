Public Class Valorizacion

    Private _CCMPN As String = "" ' Compañía
    Private _CCLNT As Decimal = 0 'Cliente
    Private _CNFCVL As Decimal = 0 'Correlativo Config. valorización
    Private _REFCNT As String = "" 'Fecha Corte Valorización
    Private _QDAPVL As Decimal = 0 'Tiempo aprobación valorización
    Private _TOBSE1 As String = ""  'Observacion


    Private _NTRMCR As String = "" 'Num Terminal
    Private _SESTRG As String = "" 'Estado del Registro
    Private _CUSCRT As String = "" 'Usuario registro
    Private _FCHCRT As String = "" 'Fecha Registro  
    Private _HRACRT As String = "" 'Hora Registro   
    Private _FULTAC As String = "" 'Fecha Actualización
    Private _HULTAC As String = ""  'Hora Actualización


    Private _CULUSA As String = "" 'Usuario Actualización
    Private _NTRMNL As String = "" 'Nombre Máquina


    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Property CNFCVL() As Decimal
        Get
            Return _CNFCVL
        End Get
        Set(ByVal value As Decimal)
            _CNFCVL = value
        End Set
    End Property

    Property REFCNT() As String
        Get
            Return _REFCNT
        End Get
        Set(ByVal value As String)
            _REFCNT = value
        End Set
    End Property

    Property QDAPVL() As Decimal
        Get
            Return _QDAPVL
        End Get
        Set(ByVal value As Decimal)
            _QDAPVL = value
        End Set
    End Property

    Property TOBSE1() As String
        Get
            Return _TOBSE1
        End Get
        Set(ByVal value As String)
            _TOBSE1 = value
        End Set
    End Property

    Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property


    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As String)
            _FCHCRT = value
        End Set
    End Property


    Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As String)
            _HRACRT = value
        End Set
    End Property

    Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As String)
            _FULTAC = value
        End Set
    End Property

    Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As String)
            _HULTAC = value
        End Set
    End Property

    Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property


End Class
