Public Class beServicio

    Private _PNNOPRCN As Decimal = 0
    Private _PNNRTFSV As Decimal = 0
    Private _PNCCLNFC As Decimal = 0
    Private _PSFLGFAC As String = ""
    Private _PNQATNAN As Decimal = 0
    Private _PSFECFIN As String = ""
    Private _PSSERVICIO As String = ""
    Private _PSFECINI As String = ""
    Private _PSCDVSN As String = ""
    Private _PSCCMPN As String = ""
    Private _PSTOBS As String = ""
    Private _PSTCMPCL As String = ""
    Private _PSNDCFCC As String = ""
    Private _PSCMNDA1 As String = ""
    Private _PNIVLSRV As Decimal = 0
    Private _PNNRRNGO As Decimal = 0
    Private _PSDESTAR As String = 0
    Private _PSFOPRCN As String = ""
    Private _PSFLGFAC_ESTADO As String = ""
    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property



    Public Property PNNRTFSV() As Decimal
        Get
            Return _PNNRTFSV
        End Get
        Set(ByVal value As Decimal)
            _PNNRTFSV = value
        End Set
    End Property



    Public Property PNCCLNFC() As Decimal
        Get
            Return _PNCCLNFC
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNFC = value
        End Set
    End Property




    Public Property PSSERVICIO() As String
        Get
            Return _PSSERVICIO
        End Get
        Set(ByVal value As String)
            _PSSERVICIO = value
        End Set
    End Property

    Public Property PSFECINI() As String
        Get
            Return _PSFECINI
        End Get
        Set(ByVal value As String)
            _PSFECINI = value
        End Set
    End Property


    Public Property PSFECFIN() As String
        Get
            Return _PSFECFIN
        End Get
        Set(ByVal value As String)
            _PSFECFIN = value
        End Set
    End Property


    Public Property PNQATNAN() As Decimal
        Get
            Return _PNQATNAN
        End Get
        Set(ByVal value As Decimal)
            _PNQATNAN = value
        End Set
    End Property



    Public Property PSFLGFAC() As String
        Get
            Return _PSFLGFAC
        End Get
        Set(ByVal value As String)
            _PSFLGFAC = value
        End Set
    End Property


    Public Property PSFLGFAC_ESTADO() As String
        Get
            Return _PSFLGFAC_ESTADO
        End Get
        Set(ByVal value As String)
            _PSFLGFAC_ESTADO = value
        End Set
    End Property


    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property




   
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property


   
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


  
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property



    Public Property PSNDCFCC() As String
        Get
            Return _PSNDCFCC
        End Get
        Set(ByVal value As String)
            _PSNDCFCC = value
        End Set
    End Property



    Public Property PSCMNDA1() As String
        Get
            Return _PSCMNDA1
        End Get
        Set(ByVal value As String)
            _PSCMNDA1 = value
        End Set
    End Property




    Public Property PNIVLSRV() As Decimal
        Get
            Return _PNIVLSRV
        End Get
        Set(ByVal value As Decimal)
            _PNIVLSRV = value
        End Set
    End Property



    Public Property PSDESTAR() As String
        Get
            Return _PSDESTAR
        End Get
        Set(ByVal value As String)
            _PSDESTAR = value
        End Set
    End Property

    
    Public Property PNNRRNGO() As Decimal
        Get
            Return _PNNRRNGO
        End Get
        Set(ByVal value As Decimal)
            _PNNRRNGO = value
        End Set
    End Property
    Public Property PSFOPRCN() As String
        Get
            Return _PSFOPRCN
        End Get
        Set(ByVal value As String)
            _PSFOPRCN = value
        End Set
    End Property




End Class
