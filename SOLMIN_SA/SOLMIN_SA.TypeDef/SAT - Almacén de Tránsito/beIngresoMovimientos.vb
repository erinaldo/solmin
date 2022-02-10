Public Class beIngresoMovimientos
    'Inherits beBultoPK
    Inherits beBase(Of beIngresoMovimientos)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    'CABECERA
    Private _PNCCLNT As Decimal
    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PNCPLNDV As Decimal
    Private _PSNORCML As String
    Private _PNNRITOC As Decimal
    'Detalle
    Private _PSCREFFW As String 'COD RECEPCION	
    Private _PSCIDPAQ As String 'IDPAQUETE
    Private _PSFREFFW As String 'FECHA

    Private _PNQBLTSR As Decimal 'CANTIDAD RECIBIDO
    Private _PSTUNDIT As String 'UNIDA

    Private _PNQPEPQT As Decimal 'Peso del Paquete:
    Private _PSTUNPSO As String ' Unidad de Peso:

    Private _PNQVLBTO As Decimal 'Peso del Paquete:
    Private _PSTUNVOL As String ' Unidad de Peso:

    Private _PSTCITCL As String 'CODIGO PRODUCTO
    Private _PSTDITES As String 'DESCRIPCION DE PRODUCTO
    Private _PSTLUGEN As String 'Lugar de Entrega
    Private _PSNGRPRV As String 'NR GUIA DE PROVEEDOR
    Private _PSNFCPRT As String 'Número de Factura Proveedor
    Private _PNFECINI As Decimal 'Parametros para Fecha Inicio
    Private _PNFECFIN As Decimal 'Pram fecha Fin
    Private _PNQCNRCP As Decimal

    Private _PSSTOCK As String
    Private _PSFSLFFW As String
    Private _PNDIAS As Int32
    ''
    Private _PSSTPING As String
    Private _PSSSNCRG As String
    Private _PSTIPO As String
    Private _PSSENTIDO As String

    Private _PSTNMBAR As String
    Private _PSURLARC As String

    ''
    Private _PSUSUARIO As String
    Private _PSPLANTA As String
    Private _PSTCMPCL As String
    '---  Centro de Costos
    Private _PSMEDSUG As String
    Private _PSMEDTRANS As String
    Private _PSTCTCST As String
    Private _PSTCTCSA As String
    Private _PSTCTCSF As String
    '---  
    Private _PSTCTAFE As String
    Private _PSLINK As String

    Private _PSTPRVCL As String

    Private _PSFINGAL As String
    Private _PSFSLDAL As String
    Private _PNDIASCL As Integer

    Private _PSTCMAEM As String
    Private _PSCZNALM As String
    Private _PNNSEQIN As Decimal = -1
    Private _PNCPRVCL As Decimal
    Private _PSNRUCPR As String

    'MPS
    Private _PSTIPOMOV As String
    Private _PNMEDIOSUG As Decimal
    Private _PNMEDIOCONF As Decimal
    Private _PSGUIAPROV As String
    Private _PSBULTO As String
    Private _PNGUIAREMISION As Decimal
    Private _PSCODITEM As String

    Public Property PSNRUCPR() As String
        Get
            Return _PSNRUCPR
        End Get
        Set(ByVal value As String)
            _PSNRUCPR = value
        End Set
    End Property

    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property


    Public Property PSTCMAEM() As String
        Get
            Return _PSTCMAEM
        End Get
        Set(ByVal value As String)
            _PSTCMAEM = value
        End Set
    End Property


    Private _PSDESCWB As String
    Public Property PSDESCWB() As String
        Get
            Return _PSDESCWB
        End Get
        Set(ByVal value As String)
            _PSDESCWB = value
        End Set
    End Property

    Public Property PSFINGAL() As String
        Get
            Return _PSFINGAL
        End Get
        Set(ByVal value As String)
            _PSFINGAL = value
        End Set
    End Property
    Public Property PSFSLDAL() As String
        Get
            Return _PSFSLDAL
        End Get
        Set(ByVal value As String)
            _PSFSLDAL = value
        End Set
    End Property

    Public Property PNDIASCL() As Integer
        Get
            Return _PNDIASCL
        End Get
        Set(ByVal value As Integer)
            _PNDIASCL = value
        End Set
    End Property




    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property


    Public Property PSLINK() As String
        Get
            Return _PSLINK
        End Get
        Set(ByVal value As String)
            _PSLINK = value
        End Set
    End Property


    Public Property PSTCTAFE() As String
        Get
            Return _PSTCTAFE
        End Get
        Set(ByVal value As String)
            _PSTCTAFE = value
        End Set
    End Property

    Public Property PNQVLBTO() As Decimal
        Get
            Return (_PNQVLBTO)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLBTO = value
        End Set
    End Property


    Public Property PSTUNVOL() As String
        Get
            Return _PSTUNVOL
        End Get
        Set(ByVal value As String)
            _PSTUNVOL = value
        End Set
    End Property


    Private _PSTRFRNA As String
    Public Property PSTRFRNA() As String
        Get
            Return _PSTRFRNA
        End Get
        Set(ByVal value As String)
            _PSTRFRNA = value
        End Set
    End Property


    Public Property PSMEDSUG() As String
        Get
            Return _PSMEDSUG
        End Get
        Set(ByVal value As String)
            _PSMEDSUG = value
        End Set
    End Property

    Public Property PSMEDTRANS() As String
        Get
            Return _PSMEDTRANS
        End Get
        Set(ByVal value As String)
            _PSMEDTRANS = value
        End Set
    End Property

    Public Property PSTCTCST() As String
        Get
            Return _PSTCTCST
        End Get
        Set(ByVal value As String)
            _PSTCTCST = value
        End Set
    End Property

    Public Property PSTCTCSF() As String
        Get
            Return _PSTCTCSF
        End Get
        Set(ByVal value As String)
            _PSTCTCSF = value
        End Set
    End Property

    Public Property PSTCTCSA() As String
        Get
            Return _PSTCTCSA
        End Get
        Set(ByVal value As String)
            _PSTCTCSA = value
        End Set
    End Property


    ''-----------------
    Public Property PSPLANTA() As String
        Get
            Return _PSPLANTA
        End Get
        Set(ByVal value As String)
            _PSPLANTA = value
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

    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property


    Public Property PSTNMBAR() As String
        Get
            Return (_PSTNMBAR)
        End Get
        Set(ByVal value As String)
            _PSTNMBAR = value
        End Set
    End Property
    Public Property PSURLARC() As String
        Get
            Return (_PSURLARC)
        End Get
        Set(ByVal value As String)
            _PSURLARC = value
        End Set
    End Property

    Public Property PSSTPING() As String
        Get
            Return _PSSTPING
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property

    Public Property PSSSNCRG() As String
        Get
            Return _PSSSNCRG
        End Get
        Set(ByVal value As String)
            _PSSSNCRG = value
        End Set
    End Property

    Public Property PSTIPO() As String
        Get
            Return _PSTIPO
        End Get
        Set(ByVal value As String)
            _PSTIPO = value
        End Set
    End Property

    Public Property PSSENTIDO() As String
        Get
            Return _PSSENTIDO
        End Get
        Set(ByVal value As String)
            _PSSENTIDO = value
        End Set
    End Property
    ''

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

    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSCREFFW() As String
        Get
            Return (_PSCREFFW)
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property
    Public Property PNNRITOC() As Decimal
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property
    Public Property PSCIDPAQ() As String
        Get
            Return (_PSCIDPAQ)
        End Get
        Set(ByVal value As String)
            _PSCIDPAQ = value
        End Set
    End Property

    Public Property PSFREFFW() As String
        Get
            Return (_PSFREFFW)
        End Get
        Set(ByVal value As String)
            _PSFREFFW = value
        End Set
    End Property
    Public Property PNQBLTSR() As Decimal
        Get
            Return (_PNQBLTSR)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTSR = value
        End Set
    End Property
    Public Property PSTUNDIT() As String
        Get
            Return (_PSTUNDIT)
        End Get
        Set(ByVal value As String)
            _PSTUNDIT = value
        End Set
    End Property
    Public Property PNQPEPQT() As Decimal
        Get
            Return (_PNQPEPQT)
        End Get
        Set(ByVal value As Decimal)
            _PNQPEPQT = value
        End Set
    End Property
    Public Property PSTUNPSO() As String
        Get
            Return (_PSTUNPSO)
        End Get
        Set(ByVal value As String)
            _PSTUNPSO = value
        End Set
    End Property

    Public Property PSTCITCL() As String
        Get
            Return (_PSTCITCL)
        End Get
        Set(ByVal value As String)
            _PSTCITCL = value
        End Set
    End Property
    Public Property PSTDITES() As String
        Get
            Return (_PSTDITES)
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
        End Set
    End Property
    Public Property PSTLUGEN() As String
        Get
            Return (_PSTLUGEN)
        End Get
        Set(ByVal value As String)
            _PSTLUGEN = value
        End Set
    End Property
    Public Property PSNGRPRV() As String
        Get
            Return (_PSNGRPRV)
        End Get
        Set(ByVal value As String)
            _PSNGRPRV = value
        End Set
    End Property
    Public Property PSNFCPRT() As String
        Get
            Return (_PSNFCPRT)
        End Get
        Set(ByVal value As String)
            _PSNFCPRT = value
        End Set
    End Property
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PNFECINI() As Decimal
        Get
            Return (_PNFECINI)
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property

    Public Property PNFECFIN() As Decimal
        Get
            Return (_PNFECFIN)
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property

    Public Property PNQCNRCP() As Decimal
        Get
            Return _PNQCNRCP
        End Get
        Set(ByVal value As Decimal)
            _PNQCNRCP = value
        End Set
    End Property

    Public Property PSSTOCK() As String
        Get
            Return _PSSTOCK
        End Get
        Set(ByVal value As String)
            _PSSTOCK = value
        End Set
    End Property

    Public Property PSFSLFFW() As String
        Get
            Return _PSFSLFFW
        End Get
        Set(ByVal value As String)
            _PSFSLFFW = value
        End Set
    End Property

    Public Property PNDIAS() As Int32
        Get
            Return _PNDIAS
        End Get
        Set(ByVal value As Int32)
            _PNDIAS = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            Return _PSCZNALM
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property

    Public Property PNNSEQIN() As Decimal
        Get
            Return _PNNSEQIN
        End Get
        Set(ByVal value As Decimal)
            _PNNSEQIN = value
        End Set
    End Property

    'MPS
    Public Property PSTIPOMOV() As String

        Get
            Return _PSTIPOMOV
        End Get
        Set(ByVal value As String)
            _PSTIPOMOV = value
        End Set
    End Property


    Public Property PNMEDIOSUG() As Decimal
        Get
            Return _PNMEDIOSUG
        End Get
        Set(ByVal value As Decimal)
            _PNMEDIOSUG = value
        End Set
    End Property

    Public Property PNMEDIOCONF() As Decimal
        Get
            Return _PNMEDIOCONF
        End Get
        Set(ByVal value As Decimal)
            _PNMEDIOCONF = value
        End Set
    End Property

    Public Property PSGUIAPROV() As String

        Get
            Return _PSGUIAPROV
        End Get
        Set(ByVal value As String)
            _PSGUIAPROV = value
        End Set
    End Property

    Public Property PSBULTO() As String

        Get
            Return _PSBULTO
        End Get
        Set(ByVal value As String)
            _PSBULTO = value
        End Set
    End Property

    Public Property PNGUIAREMISION() As Decimal
        Get
            Return _PNGUIAREMISION
        End Get
        Set(ByVal value As Decimal)
            _PNGUIAREMISION = value
        End Set
    End Property



    Public Property PSCODITEM() As String
        Get
            Return _PSCODITEM
        End Get
        Set(ByVal value As String)
            _PSCODITEM = value
        End Set
    End Property
End Class
