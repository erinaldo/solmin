Public Class beMantValorizacion





    Private _CCMPN As String = "" ' Compañía
    Private _CCLNT As Decimal = 0 'Cliente
    Private _CNFCVL As Decimal = 0 'Correlativo Config. valorización
    Private _REFCNT As String = "" 'Fecha Corte Valorización
    Private _QDAPVL As Decimal = 0 'Tiempo aprobación valorización


    Private _NROVLR As Decimal = 0  'Nro Valorización
    Private _DOCVLR As String = ""  'Nro Doc Valorización
    Private _SEGVLR As String = ""
    Private _NROSGV As Decimal = 0 'Número Doc Seguimiento 
    Private _NROSGV_STR As String = ""
    Private _SESTRG As String = ""

    Private _FCHCRT As String = "" 'Fecha Registro
    Private _CUSCRT As String = "" 'Usuario Registro    
    Private _HRACRT As String = "" 'Hora Registro



    Private _NTRMCR As String = "" 'Num Terminal

    Private _FULTAC As Decimal = 0 'Fecha Actualizacion
    Private _HULTAC As Decimal = 0 'Hora Actualizacion
    Private _CULUSA As String = "" 'Usuario Actualizacion    
    Private _NTRMNL As String = "" 'Nombre Máquina


    Private _FCHINI As Decimal = 0 'FECHA INICIO VALORIZACION
    Private _FCHFIN As Decimal = 0 'FECHA FIN VALORIZACION

    Private _CDVSN As String = "" 'Codigo División 
    Private _CPLNDV As Decimal = 0 'Codigo Planta 
    Private _NOPRCN As Decimal = 0  'Número Operación
    Private _TPOPER As String = "" 'Tipo Operación

    Private _QATNAN As Decimal = 0 'Cantidad
    Private _IVLSRV As Decimal = 0
    Private _ITPCMT As Decimal = 0 'TC_VENTA

    Private _NSECFC As Decimal = 0 'Nro Consistencia
    Private _CSRVC As Decimal = 0 'COD_SERVICIO
    Private _CMNDA1 As Decimal = 0 'ID_MON_COBRO

    Private _NCRROP As Decimal = 0
    Private _NGUITR As Decimal = 0
    Private _NCRRGU As Decimal = 0
    Private _SESTOP As String = "" 'Cod Estado Operacion
    Private _NLQDCN As Decimal = 0


    Private _TOTSOLES As Decimal = 0
    Private _TOTDOLARES As Decimal = 0

    Private _FCHASG As Decimal = 0 'Fecha Envío
    Private _HRAASG As Decimal = 0 'Hora Envío
    Private _DESTAP As String = "" 'Aprobador ( texto  )
    Private _ARADST As String = "" 'Destino ( código)
    Private _TOBS As String = "" 'Observacion

    Private _NCRRDT As Decimal = 0 'Correlativo

    Private _FCHAPR As Decimal = 0 'Fecha Aprobación
    Private _HRAAPR As Decimal = 0 'Hora Aprobación

    Private _TOBSER As String = "" 'Observacion Aprobación

    Private _OBSAVL As String = ""  'Observacion Anulación

    Private _NCRRDE As Decimal = 0

    Private _FLGAPR As String = ""

    Private _NGUIRM As Decimal = 0

    Private _AUTORIZADO As String = ""

    Private _ACCION As String = ""

    Private _DOCGENERADO As String = ""

    Private _NOPRCN_LIST As String = ""

    Private _NRTFSV As Decimal = 0
    Private _CRROP As Decimal = 0
    Private _FATNSR As Decimal = 0
    Private _FATNSR_INI As Decimal = 0
    Private _FATNSR_FIN As Decimal = 0
    Private _TPOVLR As String = ""

    Private _NOPRSD As Double = 0
    Private _NRITEM As Decimal = 0

    Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property


    Property FCHINI() As Decimal
        Get
            Return _FCHINI
        End Get
        Set(ByVal value As Decimal)
            _FCHINI = value
        End Set
    End Property

    Property FCHFIN() As Decimal
        Get
            Return _FCHFIN
        End Get
        Set(ByVal value As Decimal)
            _FCHFIN = value
        End Set
    End Property

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property




    Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property





    Property NROVLR() As Decimal
        Get
            Return _NROVLR
        End Get
        Set(ByVal value As Decimal)
            _NROVLR = value
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

    Property DOCVLR() As String
        Get
            Return _DOCVLR
        End Get
        Set(ByVal value As String)
            _DOCVLR = value
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

    Property SEGVLR() As String
        Get
            Return _SEGVLR
        End Get
        Set(ByVal value As String)
            _SEGVLR = value
        End Set
    End Property

    Property NROSGV() As Decimal
        Get
            Return _NROSGV
        End Get
        Set(ByVal value As Decimal)
            _NROSGV = value
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


    Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property
    Property TPOPER() As String
        Get
            Return _TPOPER
        End Get
        Set(ByVal value As String)
            _TPOPER = value
        End Set
    End Property



    Property QATNAN() As Decimal
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Decimal)
            _QATNAN = value
        End Set
    End Property

    Property IVLSRV() As Decimal
        Get
            Return _IVLSRV
        End Get
        Set(ByVal value As Decimal)
            _IVLSRV = value
        End Set
    End Property

    Property ITPCMT() As Decimal
        Get
            Return _ITPCMT
        End Get
        Set(ByVal value As Decimal)
            _ITPCMT = value
        End Set
    End Property

    Property NSECFC() As Decimal
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Decimal)
            _NSECFC = value
        End Set
    End Property

    Property CSRVC() As Decimal
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As Decimal)
            _CSRVC = value
        End Set
    End Property
    Property CMNDA1() As Decimal
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As Decimal)
            _CMNDA1 = value
        End Set
    End Property



    Property NCRROP() As Decimal
        Get
            Return _NCRROP
        End Get
        Set(ByVal value As Decimal)
            _NCRROP = value
        End Set
    End Property
    Property NGUITR() As Decimal
        Get
            Return _NGUITR
        End Get
        Set(ByVal value As Decimal)
            _NGUITR = value
        End Set
    End Property


    Property NCRRGU() As Decimal
        Get
            Return _NCRRGU
        End Get
        Set(ByVal value As Decimal)
            _NCRRGU = value
        End Set
    End Property

    Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property

    Property NLQDCN() As Decimal
        Get
            Return _NLQDCN
        End Get
        Set(ByVal value As Decimal)
            _NLQDCN = value
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

    Property TOTSOLES() As Decimal
        Get
            Return _TOTSOLES
        End Get
        Set(ByVal value As Decimal)
            _TOTSOLES = value
        End Set
    End Property

    Property TOTDOLARES() As Decimal
        Get
            Return _TOTDOLARES
        End Get
        Set(ByVal value As Decimal)
            _TOTDOLARES = value
        End Set
    End Property

    Property FCHASG() As Decimal
        Get
            Return _FCHASG
        End Get
        Set(ByVal value As Decimal)
            _FCHASG = value
        End Set
    End Property


    Property HRAASG() As Decimal
        Get
            Return _HRAASG
        End Get
        Set(ByVal value As Decimal)
            _HRAASG = value
        End Set
    End Property

    Property DESTAP() As String
        Get
            Return _DESTAP
        End Get
        Set(ByVal value As String)
            _DESTAP = value
        End Set
    End Property

    Property ARADST() As String
        Get
            Return _ARADST
        End Get
        Set(ByVal value As String)
            _ARADST = value
        End Set
    End Property

    Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal value As String)
            _TOBS = value
        End Set
    End Property




    Property NCRRDT() As Decimal
        Get
            Return _NCRRDT
        End Get
        Set(ByVal value As Decimal)
            _NCRRDT = value
        End Set
    End Property



    Property FCHAPR() As Decimal
        Get
            Return _FCHAPR
        End Get
        Set(ByVal value As Decimal)
            _FCHAPR = value
        End Set
    End Property

    Property HRAAPR() As Decimal
        Get
            Return _HRAAPR
        End Get
        Set(ByVal value As Decimal)
            _HRAAPR = value
        End Set
    End Property


    Property TOBSER() As String
        Get
            Return _TOBSER
        End Get
        Set(ByVal value As String)
            _TOBSER = value
        End Set
    End Property



    Property OBSAVL() As String
        Get
            Return _OBSAVL
        End Get
        Set(ByVal value As String)
            _OBSAVL = value
        End Set
    End Property

    Property NCRRDE() As Decimal
        Get
            Return _NCRRDE
        End Get
        Set(ByVal value As Decimal)
            _NCRRDE = value
        End Set
    End Property

    Property FLGAPR() As String
        Get
            Return _FLGAPR
        End Get
        Set(ByVal value As String)
            _FLGAPR = value
        End Set
    End Property

    Property NROSGV_STR() As String
        Get
            Return _NROSGV_STR
        End Get
        Set(ByVal value As String)
            _NROSGV_STR = value
        End Set
    End Property
    '
    Property NGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Decimal)
            _NGUIRM = value
        End Set
    End Property
    Property AUTORIZADO() As String
        Get
            Return _AUTORIZADO
        End Get
        Set(ByVal value As String)
            _AUTORIZADO = value
        End Set
    End Property

    Property ACCION() As String
        Get
            Return _ACCION
        End Get
        Set(ByVal value As String)
            _ACCION = value
        End Set
    End Property

    Property DOCGENERADO() As String
        Get
            Return _DOCGENERADO
        End Get
        Set(ByVal value As String)
            _DOCGENERADO = value
        End Set
    End Property


    Property NOPRCN_LIST() As String
        Get
            Return _NOPRCN_LIST
        End Get
        Set(ByVal value As String)
            _NOPRCN_LIST = value
        End Set
    End Property

    Public Property NRTFSV() As Decimal
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Decimal)
            _NRTFSV = value
        End Set
    End Property

    Public Property CRROP() As Decimal
        Get
            Return _CRROP
        End Get
        Set(ByVal value As Decimal)
            _CRROP = value
        End Set
    End Property

    Public Property FATNSR_INI() As Decimal
        Get
            Return _FATNSR_INI
        End Get
        Set(ByVal value As Decimal)
            _FATNSR_INI = value
        End Set
    End Property

    Public Property FATNSR_FIN() As Decimal
        Get
            Return _FATNSR_FIN
        End Get
        Set(ByVal value As Decimal)
            _FATNSR_FIN = value
        End Set
    End Property

    Public Property FATNSR() As Decimal
        Get
            Return _FATNSR
        End Get
        Set(ByVal value As Decimal)
            _FATNSR = value
        End Set
    End Property

    Property TPOVLR() As String
        Get
            Return _TPOVLR
        End Get
        Set(ByVal value As String)
            _TPOVLR = value
        End Set
    End Property

    Public Property NOPRSD() As Double
        Get
            Return _NOPRSD
        End Get
        Set(ByVal value As Double)
            _NOPRSD = value
        End Set
    End Property

    Public Property NRITEM() As Decimal
        Get
            Return _NRITEM
        End Get
        Set(ByVal value As Decimal)
            _NRITEM = value
        End Set
    End Property

End Class
