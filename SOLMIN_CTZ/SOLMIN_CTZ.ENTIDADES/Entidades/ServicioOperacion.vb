Public Class ServicioOperacion

    Private _NOPRCN As Double = 0
    Private _CCLNT As Double = 0
    Private _CCLNFC As Double = 0
    'Private _FOPRCN As Double = 0
    Private _NRTFSV As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _QATNAN As Double = 0
    'Private _QATNRL As Double = 0
    'Private _FECINI As Double = 0
    'Private _FECFIN As Double = 0
    'Private _STIPPR As String = ""
    Private _FLGFAC As String = ""
    'Private _TOBS As String = ""
    Private _CMNDA1 As Integer = 0
    'Private _TIPO_PROCESO As String = ""
    'Private _SSTINV As String = ""
    Private _TCTCST As String = ""
    'Private _VALCTE As Decimal = 0D
    Private _TSGNMN As String = ""
    Private _IVLSRV As Decimal = 0D
    'Private _TSRVC As String = ""
    'Private _FecServ As String = ""
    'Private _LIST_NOPRCN As String = ""
    Private _NDCFCC As Decimal = 0
    'Private _STPTRA As String = ""
    'Private _STPTRA_DESC As String = ""
    Private _CTPODC As Integer = 0
    Private _TIPO_PLANTA As String = ""
    'Private _NORCCL As String = ""
    Private _CSRVC As Decimal = 0
    Private _CUNDMD As String = ""
    Private _NRRUBR As Decimal = 0
    Private _NRSRRB As Decimal = 0
    Private _SESTRG As String = ""
    Private _CCNTCS As String = ""
    Private _NCRROP As Decimal = 0
    Private _TUNDIT = ""
    Private _CPLNDV As Integer = 0
    Private _CPLNDV_STR As String = ""
    Private _NCRRDC As Integer = 0
    'Private _NSECFC_UPD As Double = 0
    Private _NSECFC As Double = 0
    'Private _NSLCSR As Decimal = 0
    'Private _NORDSR As Decimal = 0
    'Private _CTPALJ As String = ""
    'Private _FLGPEN As String = "0"
    Private _NORSCI As Decimal = 0
    Private _FULTAC As Integer = 0
    Private _FECFAC As Decimal = 0

    Private _FATNSR As Decimal = 0
    Private _NCRRFC As Decimal = 0

    Private _FDCFCC_INI As Decimal = 0
    Private _FDCFCC_FIN As Decimal = 0
    Private _FOPRCN_INI As Decimal = 0
    Private _FOPRCN_FIN As Decimal = 0

    Private _DESTAR As String = ""

    'Public Property FecServ() As String
    '    Get
    '        Return _FecServ
    '    End Get
    '    Set(ByVal value As String)
    '        _FecServ = value
    '    End Set
    'End Property

    'Public Property TSRVC() As String
    '    Get
    '        Return _TSRVC
    '    End Get
    '    Set(ByVal value As String)
    '        _TSRVC = value
    '    End Set
    'End Property

    'Public Property VALCTE() As Decimal
    '    Get
    '        Return _VALCTE
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _VALCTE = value
    '    End Set
    'End Property

    Private _PageSize As Integer = 0
    Public Property PageSize() As Integer
        Get
            Return _PageSize
        End Get
        Set(ByVal value As Integer)
            _PageSize = value
        End Set
    End Property

    Private _PageCount As Integer = 0
    Public Property PageCount() As Integer
        Get
            Return _PageCount
        End Get
        Set(ByVal value As Integer)
            _PageCount = value
        End Set
    End Property

    Private _PageNumber As Integer = 0
    Public Property PageNumber() As Integer
        Get
            Return _PageNumber
        End Get
        Set(ByVal value As Integer)
            _PageNumber = value
        End Set
    End Property

    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            _TSGNMN = value
        End Set
    End Property
    Public Property IVLSRV() As Decimal
        Get
            Return _IVLSRV
        End Get
        Set(ByVal value As Decimal)
            _IVLSRV = value
        End Set
    End Property


   
    Public Property TCTCST() As String
        Get
            Return _TCTCST
        End Get
        Set(ByVal value As String)
            _TCTCST = value
        End Set
    End Property
  


    'Public Property SSTINV() As String
    '    Get
    '        Return _SSTINV
    '    End Get
    '    Set(ByVal value As String)
    '        _SSTINV = value
    '    End Set
    'End Property


    'Public Property TIPO_PROCESO() As String
    '    Get
    '        Return _TIPO_PROCESO
    '    End Get
    '    Set(ByVal value As String)
    '        _TIPO_PROCESO = value
    '    End Set
    'End Property

    Public Property CMNDA1() As Integer
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As Integer)
            _CMNDA1 = value
        End Set
    End Property


    Public Property FULTAC() As Integer
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Integer)
            _FULTAC = value
        End Set
    End Property

    'Public Property FLGPEN() As String
    '    Get
    '        Return _FLGPEN
    '    End Get
    '    Set(ByVal value As String)
    '        _FLGPEN = value
    '    End Set
    'End Property



    Public Property NSECFC() As Double
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Double)
            _NSECFC = value
        End Set
    End Property

    'Public Property NSECFC_UPD() As Double
    '    Get
    '        Return _NSECFC_UPD
    '    End Get
    '    Set(ByVal value As Double)
    '        _NSECFC_UPD = value
    '    End Set
    'End Property

    Public Property NCRRDC() As Integer
        Get
            Return _NCRRDC
        End Get
        Set(ByVal value As Integer)
            _NCRRDC = value
        End Set
    End Property

    'Public Property STIPPR() As String
    '    Get
    '        Return _STIPPR
    '    End Get
    '    Set(ByVal value As String)
    '        _STIPPR = value
    '    End Set
    'End Property
    Public Property CCLNFC() As Integer
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Integer)
            _CCLNFC = value
        End Set
    End Property

    Public Property CPLNDV() As Integer
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Integer)
            _CPLNDV = value
        End Set
    End Property


    Public Property CPLNDV_STR() As String
        Get
            Return _CPLNDV_STR
        End Get
        Set(ByVal value As String)
            _CPLNDV_STR = value
        End Set
    End Property


    Public Property TUNDIT() As String
        Get
            Return _TUNDIT
        End Get
        Set(ByVal value As String)
            _TUNDIT = value
        End Set
    End Property
   
    Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Double)
            _NOPRCN = value
        End Set
    End Property

    Public Property NCRROP() As Decimal
        Get
            Return _NCRROP
        End Get
        Set(ByVal value As Decimal)
            _NCRROP = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property
    Private _FATNSR_D As Decimal
    Property FATNSR_D() As Decimal
        Get
            Return _FATNSR_D
        End Get
        Set(ByVal value As Decimal)
            _FATNSR_D = value
        End Set
    End Property


    Private _FATNSR_A As Decimal
    Public Property FATNSR_A() As Decimal
        Get
            Return _FATNSR_A
        End Get
        Set(ByVal value As Decimal)
            _FATNSR_A = value
        End Set
    End Property

    'Property FOPRCN() As Double
    '    Get
    '        Return _FOPRCN
    '    End Get
    '    Set(ByVal value As Double)
    '        _FOPRCN = value
    '    End Set
    'End Property
    Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Double)
            _NRTFSV = value
        End Set
    End Property
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal Value As String)
            _CDVSN = Value
        End Set
    End Property
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property
    Property QATNAN() As Double
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Double)
            _QATNAN = value
        End Set
    End Property

    'Property QATNRL() As Double
    '    Get
    '        Return _QATNRL
    '    End Get
    '    Set(ByVal value As Double)
    '        _QATNRL = value
    '    End Set
    'End Property

    'Property FECINI() As Double
    '    Get
    '        Return _FECINI
    '    End Get
    '    Set(ByVal value As Double)
    '        _FECINI = value
    '    End Set
    'End Property




    'Property FECFIN() As Double
    '    Get
    '        Return _FECFIN
    '    End Get
    '    Set(ByVal value As Double)
    '        _FECFIN = value
    '    End Set
    'End Property


    Property FLGFAC() As String
        Get
            Return _FLGFAC
        End Get
        Set(ByVal value As String)
            _FLGFAC = value
        End Set
    End Property
 
    'Public Property TOBS() As String
    '    Get
    '        Return _TOBS
    '    End Get
    '    Set(ByVal value As String)
    '        _TOBS = value
    '    End Set
    'End Property

    Public Property CCNTCS() As String
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As String)
            _CCNTCS = value
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

    Public Property NRRUBR() As Decimal
        Get
            Return _NRRUBR
        End Get
        Set(ByVal value As Decimal)
            _NRRUBR = value
        End Set
    End Property

    Public Property NRSRRB() As Decimal
        Get
            Return _NRSRRB
        End Get
        Set(ByVal value As Decimal)
            _NRSRRB = value
        End Set
    End Property
    Public Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property

    Public Property CSRVC() As Decimal
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As Decimal)
            _CSRVC = value
        End Set
    End Property



    'Public Property NORCCL() As String
    '    Get
    '        Return _NORCCL
    '    End Get
    '    Set(ByVal value As String)
    '        _NORCCL = value
    '    End Set
    'End Property


    'Private _STPODP As String
    '''' <summary>
    ''''Flag. Tipo de Deposito
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property STPODP() As String
    '    Get
    '        Return _STPODP
    '    End Get
    '    Set(ByVal value As String)
    '        _STPODP = value
    '    End Set
    'End Property


    '''' <summary>
    '''' Num Solicitud de Servicio
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property NSLCSR() As Decimal
    '    Get
    '        Return _NSLCSR
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NSLCSR = value
    '    End Set
    'End Property



    '''' <summary>
    '''' Num Orden Servicio 
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property NORDSR() As Decimal
    '    Get
    '        Return _NORDSR
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NORDSR = value
    '    End Set
    'End Property



    '''' <summary>
    ''''  Tipo de Almacenaje
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property CTPALJ() As String
    '    Get
    '        Return _CTPALJ
    '    End Get
    '    Set(ByVal value As String)
    '        _CTPALJ = value
    '    End Set
    'End Property


    Public Property CTPODC() As Integer
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As Integer)
            _CTPODC = value
        End Set
    End Property


    Public Property TIPO_PLANTA() As String
        Get
            Return _TIPO_PLANTA
        End Get
        Set(ByVal value As String)
            _TIPO_PLANTA = value
        End Set
    End Property


    Private _CRGVTA As String = ""
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

 

    'Public Property LIST_NOPRCN() As String
    '    Get
    '        Return _LIST_NOPRCN
    '    End Get
    '    Set(ByVal value As String)
    '        _LIST_NOPRCN = value
    '    End Set
    'End Property

    Public Property NDCFCC() As Decimal
        Get
            Return _NDCFCC
        End Get
        Set(ByVal value As Decimal)
            _NDCFCC = value
        End Set
    End Property
    '
    'Public Property STPTRA() As String
    '    Get
    '        Return _STPTRA
    '    End Get
    '    Set(ByVal value As String)
    '        _STPTRA = value
    '    End Set
    'End Property

    'Public Property STPTRA_DESC() As String
    '    Get
    '        Return _STPTRA_DESC
    '    End Get
    '    Set(ByVal value As String)
    '        _STPTRA_DESC = value
    '    End Set
    'End Property

    Public Property FECFAC() As Decimal
        Get
            Return _FECFAC
        End Get
        Set(ByVal value As Decimal)
            _FECFAC = value
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

    Public Property NCRRFC() As Decimal
        Get
            Return _NCRRFC
        End Get
        Set(ByVal value As Decimal)
            _NCRRFC = value
        End Set
    End Property

    Public Property FDCFCC_INI() As Decimal
        Get
            Return _FDCFCC_INI
        End Get
        Set(ByVal value As Decimal)
            _FDCFCC_INI = value
        End Set
    End Property

    Public Property FDCFCC_FIN() As Decimal
        Get
            Return _FDCFCC_FIN
        End Get
        Set(ByVal value As Decimal)
            _FDCFCC_FIN = value
        End Set
    End Property

    Public Property FOPRCN_INI() As Decimal
        Get
            Return _FOPRCN_INI
        End Get
        Set(ByVal value As Decimal)
            _FOPRCN_INI = value
        End Set
    End Property

    Public Property FOPRCN_FIN() As Decimal
        Get
            Return _FOPRCN_FIN
        End Get
        Set(ByVal value As Decimal)
            _FOPRCN_FIN = value
        End Set
    End Property

    Public Property DESTAR() As String
        Get
            Return _DESTAR
        End Get
        Set(ByVal value As String)
            _DESTAR = value
        End Set
    End Property




End Class
