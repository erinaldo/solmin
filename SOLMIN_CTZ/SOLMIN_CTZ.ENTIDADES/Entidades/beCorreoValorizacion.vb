Public Class beCorreoValorizacion

    Private _CCLNT As Decimal = 0 'Cliente
    Private _NLTECL As String = "" 'Codigo Proceso Valorizacion Fijo CT_VALORIZ
    Private _NCRRIT As String = "" 'Correlativo Correo Valorizacion
    Private _EMAILTO As String = ""

    Private _TNMYAP As String = "" 'Nombre de Persona del Correo
    Private _EMAILCC As String = "" 'Correo Copia Siempre Vacio
    Private _EMAILBC As String = "" 'Correo Copia Siempre Vacio
    Private _TIPPROC As String = "" 'Valor Simpre Vacio

    Private _SESTRG As String = "" 'Estado del Registro



    Private _FULTAC As String = "" 'Fecha Actualización
    Private _HULTAC As String = ""  'Hora Actualización
    Private _CULUSA As String = "" 'Usuario Actualización

    Private _CUSCRT As String = "" 'Usuario registro
    Private _FCHCRT As String = "" 'Fecha Registro  
    Private _HRACRT As String = "" 'Hora Registro  


    Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Property NLTECL() As String
        Get
            Return _NLTECL
        End Get
        Set(ByVal value As String)
            _NLTECL = value
        End Set
    End Property

    Property NCRRIT() As String
        Get
            Return _NCRRIT
        End Get
        Set(ByVal value As String)
            _NCRRIT = value
        End Set
    End Property

    Property EMAILTO() As String
        Get
            Return _EMAILTO
        End Get
        Set(ByVal value As String)
            _EMAILTO = value
        End Set
    End Property

    Property TNMYAP() As String
        Get
            Return _TNMYAP
        End Get
        Set(ByVal value As String)
            _TNMYAP = value
        End Set
    End Property

    Property EMAILCC() As String
        Get
            Return _EMAILCC
        End Get
        Set(ByVal value As String)
            _EMAILCC = value
        End Set
    End Property

    Property EMAILBC() As String
        Get
            Return _EMAILBC
        End Get
        Set(ByVal value As String)
            _EMAILBC = value
        End Set
    End Property

    Property TIPPROC() As String
        Get
            Return _TIPPROC
        End Get
        Set(ByVal value As String)
            _TIPPROC = value
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









End Class
