Public Class beContenedor
    Inherits beBase(Of beContenedor)

    Public Sub New()
        Try
            Me.InicializeProperty(Me)
        Catch ex As Exception

        End Try

    End Sub

    Private _CCMPN As String
    Private _CCLNT As Decimal
    Private _CPRPCN As String
    Private _NSRECN As String
    Private _CMTRCN As String
    Private _CDMNCN As String
    Private _CCLOR As String
    Private _CTPOC1 As String
    Private _QTRACN As Decimal
    Private _QPSMXC As Decimal
    Private _QCPCBC As Decimal
    Private _FFACCN As Decimal
    Private _FINCSC As Decimal
    Private _TOBSCN As String
    Private _SESCN1 As String
    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _CUSCRT As String
    Private _FULTAC As Decimal
    Private _HULTAC As Decimal
    Private _CULUSA As String
    Private _NTRMNL As String
    Private _SESTRG As String


    Public Property PSCCMPN() As String
        Get
            Return (_CCMPN)
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return (_CCLNT)
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property
    Public Property PSCPRPCN() As String
        Get
            Return (_CPRPCN)
        End Get
        Set(ByVal value As String)
            _CPRPCN = value
        End Set
    End Property
    Public Property PSNSRECN() As String
        Get
            Return (_NSRECN)
        End Get
        Set(ByVal value As String)
            _NSRECN = value
        End Set
    End Property
    Public Property PSCMTRCN() As String
        Get
            Return (_CMTRCN)
        End Get
        Set(ByVal value As String)
            _CMTRCN = value
        End Set
    End Property
   


    Public Property PSCDMNCN() As String
        Get
            Return (_CDMNCN)
        End Get
        Set(ByVal value As String)
            _CDMNCN = value
        End Set
    End Property
    Public Property PSCCLOR() As String
        Get
            Return (_CCLOR)
        End Get
        Set(ByVal value As String)
            _CCLOR = value
        End Set
    End Property
    Public Property PSCTPOC1() As String
        Get
            Return (_CTPOC1)
        End Get
        Set(ByVal value As String)
            _CTPOC1 = value
        End Set
    End Property
    Public Property PNQTRACN() As Decimal
        Get
            Return (_QTRACN)
        End Get
        Set(ByVal value As Decimal)
            _QTRACN = value
        End Set
    End Property
    Public Property PNQPSMXC() As Decimal
        Get
            Return (_QPSMXC)
        End Get
        Set(ByVal value As Decimal)
            _QPSMXC = value
        End Set
    End Property
    Public Property PNQCPCBC() As Decimal
        Get
            Return (_QCPCBC)
        End Get
        Set(ByVal value As Decimal)
            _QCPCBC = value
        End Set
    End Property
    Public Property PNFFACCN() As Decimal
        Get
            Return (_FFACCN)
        End Get
        Set(ByVal value As Decimal)
            _FFACCN = value
        End Set
    End Property
    Public Property PNFINCSC() As Decimal
        Get
            Return (_FINCSC)
        End Get
        Set(ByVal value As Decimal)
            _FINCSC = value
        End Set
    End Property
    Public Property PSTOBSCN() As String
        Get
            Return (_TOBSCN)
        End Get
        Set(ByVal value As String)
            _TOBSCN = value
        End Set
    End Property
    Public Property PSSESCN1() As String
        Get
            Return (_SESCN1)
        End Get
        Set(ByVal value As String)
            _SESCN1 = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_FCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_HRACRT)
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property
    Public Property PSCUSCRT() As String
        Get
            Return (_CUSCRT)
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return (_FULTAC)
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_HULTAC)
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_CULUSA)
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_NTRMNL)
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property
    Private _DESFFACCN As String
    Public Property PSDESFFACCN() As String
        Get
            Return (_DESFFACCN)
        End Get
        Set(ByVal value As String)
            _DESFFACCN = value
        End Set
    End Property
    Private _DESFINCSC As String
    Public Property PSDESFINCSC() As String
        Get
            Return (_DESFINCSC)
        End Get
        Set(ByVal value As String)
            _DESFINCSC = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_SESTRG)
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

#Region "Paginacion"
    Private pnPageNumber As Integer
    Public Property nPageNumber() As Integer
        Get
            Return (pnPageNumber)
        End Get
        Set(ByVal value As Integer)
            pnPageNumber = value
        End Set
    End Property

    Private pnPageSize As Integer
    Public Property nPageSize() As Integer
        Get
            Return (pnPageSize)
        End Get
        Set(ByVal value As Integer)
            pnPageSize = value
        End Set
    End Property
#End Region
#Region "Adicional al contenedor"

    Private _UBICACION As String
    Public Property PSUBICACION() As String
        Get
            Return _UBICACION
        End Get
        Set(ByVal value As String)
            _UBICACION = value
        End Set
    End Property


    Private _DESCCLOR As String
    Public Property PSDESCCLOR() As String
        Get
            Return (_DESCCLOR)
        End Get
        Set(ByVal value As String)
            _DESCCLOR = value
        End Set
    End Property
    Private _DESCMTRCN As String
    Public Property PSDESCMTRCN() As String
        Get
            Return (_DESCMTRCN)
        End Get
        Set(ByVal value As String)
            _DESCMTRCN = value
        End Set
    End Property
    Private _DESCTPOC1 As String
    Public Property PSDESCTPOC1() As String
        Get
            Return (_DESCTPOC1)
        End Get
        Set(ByVal value As String)
            _DESCTPOC1 = value
        End Set
    End Property
    Private _DESSESCN1 As String

    Public Property PSDESSESCN1() As String
        Get
            Return (_DESSESCN1)
        End Get
        Set(ByVal value As String)
            _DESSESCN1 = value
        End Set
    End Property
    Private _PNFREFFW As Decimal
    Public Property PNFREFFW() As Decimal
        Get
            Return (_PNFREFFW)
        End Get
        Set(ByVal value As Decimal)
            _PNFREFFW = value
        End Set
    End Property
    Private _PNFSLFFW As Decimal
    Public Property PNFSLFFW() As Decimal
        Get
            Return (_PNFSLFFW)
        End Get
        Set(ByVal value As Decimal)
            _PNFSLFFW = value
        End Set
    End Property
    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return (_PSCDVSN)
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property

    Private _PSTPLNTA As String
    Public Property PSTPLNTA() As String
        Get
            Return _PSTPLNTA
        End Get
        Set(ByVal value As String)
            _PSTPLNTA = value
        End Set
    End Property


    Private _PSCREFFW As String
    Public Property PSCREFFW() As String
        Get
            Return _PSCREFFW
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property


    Private _FechaIngreso As String
    Public Property PSFechaIngreso() As String
        Get
            Return _FechaIngreso
        End Get
        Set(ByVal value As String)
            _FechaIngreso = value
        End Set
    End Property

    Private _PSNGRPRV As String
    Public Property PSNGRPRV() As String
        Get
            Return _PSNGRPRV
        End Get
        Set(ByVal value As String)
            _PSNGRPRV = value
        End Set
    End Property


    Private _FechaSalida As String
    Public Property FechaSalida() As String
        Get
            Return _FechaSalida
        End Get
        Set(ByVal value As String)
            _FechaSalida = value
        End Set
    End Property


    Private _PSNGUIRM As String
    Public Property PSNGUIRM() As String
        Get
            Return _PSNGUIRM
        End Get
        Set(ByVal value As String)
            _PSNGUIRM = value
        End Set
    End Property

    Private _TCMLCL_OR As String
    Public Property PSTCMLCL_OR() As String
        Get
            Return _TCMLCL_OR
        End Get
        Set(ByVal value As String)
            _TCMLCL_OR = value
        End Set
    End Property


    Private _PSGUIA_TRANS As String
    Public Property PSGUIA_TRANS() As String
        Get
            Return _PSGUIA_TRANS
        End Get
        Set(ByVal value As String)
            _PSGUIA_TRANS = value
        End Set
    End Property

    Private _TCMLCL_DES As String
    Public Property PSTCMLCL_DES() As String
        Get
            Return _TCMLCL_DES
        End Get
        Set(ByVal value As String)
            _TCMLCL_DES = value
        End Set
    End Property


    Private _PSTNMMDT As String
    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property


    Private _PSTCMTRT As String
    Public Property PSTCMTRT() As String
        Get
            Return _PSTCMTRT
        End Get
        Set(ByVal value As String)
            _PSTCMTRT = value
        End Set
    End Property

#End Region
End Class