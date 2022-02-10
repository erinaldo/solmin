Public Class beDespachoMovimientos
    'Inherits beBultoPK
    Inherits beBase(Of beDespachoMovimientos)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub
    'CABECERA

    Private _PNCCLNT As Decimal
    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PNCPLNDV As Decimal
    Private _PSNORCML As String 'ORDEN DE COMPRA --GR
    Private _PNNRITOC As Decimal 'ITEM--GR

    'Detalle
    Private _PNNGUIRM As Decimal 'NUM GR -- 
    Private _PNNCRRGR As Decimal 'ITEM GUIA --Correl

    Private _PSCREFFW As String 'COD BARRA --GR COD BULTO
    Private _PNQBLTSR As Decimal 'CANTIDAD DESPACHADO --GR
    Private _PSTUNDIT As String 'UNIDAD PROD--GR
    Private _PNQPEPQT As Decimal 'Peso del Paquete:
    Private _PSTUNPSO As String ' Unidad de Peso
    Private _PSTCITCL As String 'CODIGO PRODUCTO --cod MERCADERIA
    Private _PSTDITES As String 'DESCRIPCION DE PRODUCTO--desc mercaderia
    Private _PSTLUGEN As String = "" 'Lugar de Entrega--GR
    Private _PSNGRPRV As String 'NR GUIA DE PROVEEDOR--GR
    Private _PSNFCPRT As String 'Número de Factura Proveedor


    ''' 

    Private _PSFGUIRM As String 'Fecha Guia 
    Private _PSPLANDES As String 'PLANTA DE Destino
    Private _PSDIRDES As String  'DIRECCION Destino
    Private _PSPLANOR As String 'PLANTA DE ORIGEN
    Private _PSDIRORI As String  'DIRECCION ORIGEN
    Private _PSTDRCPL As String
    Private _PSTOBORM As String 'Observaciones
    Private _PSTCMTRT As String 'razonSocial
    Private _PSNPLCCM As String 'Placa
    Private _PSNPLACP As String 'Acoplado
    Private _PSNBRVCH As String 'BREVETE
    Private _PSTNMBCH As String 'Nom Chofer
    Private _PSTDRCTR As String 'Direccion
    Private _PSNRUCTR As String 'RUC
    Private _PNQCNGU As Decimal '--CANTIDA BULTO GR
    Private _PSCUNCN As String 'UNIDAD BULTO GR
    Private _PNQPSGU As Decimal '--CANTIDA PESO GR
    Private _PSCUNPS As String 'UNIDAD PESO GR
    Private _PSDESPROV As String ' --PROVEEDOR GR
    Private _PNFECINI As Decimal '  Parametros para Fecha Inicio
    Private _PNFECFIN As Decimal '  'Pram fecha Fin
    Private _DetalleGR As String
    Private _PNQCNRCP As Decimal
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

    ''
    '---  Centro de Costos
    Private _MEDSUG As String
    Private _MEDTRANS As String
    Private _TCTCST As String
    Private _TCTCSA As String
    Private _TCTCSF As String
    '---------------------------------
    Private _PSSTPDES As String
    Private _PSFLGCNL As String = ""
    '
    Private _PSHCNFCL As String
    Private _PSFCNFCL As String

    Private _PSTRFRNA As String
    Private _PSMEDENVIO As String
    Private _PNCODMEDENVIO As Decimal
    Private _PSTUNVOL As String
    Private _PNQVLBTO As Decimal
    '-----

    Private _PSTCTCST As String
    Private _PSTCTCSA As String
    Private _PSTCTCSF As String
    Private _PSTCTAFE As String
    Private _PSLINK As String

    Private _PSTPRVCL As String
    Private _PSDESCWB As String
    Private _PSFREFFW As String
    Private _PSFSLFFW As String
    Private _PNDIASCL As Integer
    Private _PSFINGAL As String
    Private _PSFSLDAL As String
    Private _PNDIAS As Integer
    Private _PSTCMAEM As String
    Private _PSCZNALM As String
    Private _PNNSEQIN As Decimal = -1
    Private _PNCCLNGR As Decimal
    Private _PNCPRVCL As Decimal
    Private _PSNRUCPR As String

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

    Public Property PNCCLNGR() As Decimal
        Get
            Return _PNCCLNGR
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNGR = value
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

    Public Property PNDIASCL() As Integer
        Get
            Return _PNDIASCL
        End Get
        Set(ByVal value As Integer)
            _PNDIASCL = value
        End Set
    End Property

    Public Property PNDIAS() As Integer
        Get
            Return _PNDIAS
        End Get
        Set(ByVal value As Integer)
            _PNDIAS = value
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


    Public Property PSDESCWB() As String
        Get
            Return _PSDESCWB
        End Get
        Set(ByVal value As String)
            _PSDESCWB = value
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

    Public Property PNCODMEDENVIO() As Decimal
        Get
            Return (_PNCODMEDENVIO)
        End Get
        Set(ByVal value As Decimal)
            _PNCODMEDENVIO = value
        End Set
    End Property


    Public Property PSMEDENVIO() As String
        Get
            Return _PSMEDENVIO
        End Get
        Set(ByVal value As String)
            _PSMEDENVIO = value
        End Set
    End Property

    Public Property PSTRFRNA() As String
        Get
            Return _PSTRFRNA
        End Get
        Set(ByVal value As String)
            _PSTRFRNA = value
        End Set
    End Property

    Public Property PSSTPDES() As String
        Get
            Return _PSSTPDES
        End Get
        Set(ByVal value As String)
            _PSSTPDES = value
        End Set
    End Property
    Public Property PSHCNFCL() As String
        Get
            Return _PSHCNFCL
        End Get
        Set(ByVal value As String)
            _PSHCNFCL = value
        End Set
    End Property
    Public Property PSFCNFCL() As String
        Get
            Return _PSFCNFCL
        End Get
        Set(ByVal value As String)
            _PSFCNFCL = value
        End Set
    End Property

    Public Property PSFLGCNL() As String
        Get
            Return _PSFLGCNL
        End Get
        Set(ByVal value As String)
            _PSFLGCNL = value
        End Set
    End Property

    '---------------------------------------------
    Public Property MEDSUG() As String
        Get
            Return _MEDSUG
        End Get
        Set(ByVal value As String)
            _MEDSUG = value
        End Set
    End Property

    Public Property MEDTRANS() As String
        Get
            Return _MEDTRANS
        End Get
        Set(ByVal value As String)
            _MEDTRANS = value
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

    Public Property TCTCSF() As String
        Get
            Return _TCTCSF
        End Get
        Set(ByVal value As String)
            _TCTCSF = value
        End Set
    End Property

    Public Property TCTCSA() As String
        Get
            Return _TCTCSA
        End Get
        Set(ByVal value As String)
            _TCTCSA = value
        End Set
    End Property


    ''-----------------------------------------------

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


    ''

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


    Public Property PSFSLFFW() As String
        Get
            Return _PSFSLFFW
        End Get
        Set(ByVal value As String)
            _PSFSLFFW = value
        End Set

    End Property

    Public Property PSFGUIRM() As String
        Get
            Return _PSFGUIRM
        End Get
        Set(ByVal value As String)
            _PSFGUIRM = value
        End Set
    End Property

    Public Property PSPLANDES() As String
        Get
            Return _PSPLANDES
        End Get
        Set(ByVal value As String)
            _PSPLANDES = value
        End Set
    End Property

    Public Property PSDIRDES() As String
        Get
            Return _PSDIRDES
        End Get
        Set(ByVal value As String)
            _PSDIRDES = value
        End Set
    End Property

    Public Property PSTDRCPL() As String
        Get
            Return _PSTDRCPL
        End Get
        Set(ByVal value As String)
            _PSTDRCPL = value
        End Set
    End Property

    Public Property PSTOBORM() As String
        Get
            Return _PSTOBORM
        End Get
        Set(ByVal value As String)
            _PSTOBORM = value
        End Set
    End Property

    Public Property PSTCMTRT() As String
        Get
            Return _PSTCMTRT
        End Get
        Set(ByVal value As String)
            _PSTCMTRT = value
        End Set
    End Property

    Public Property PSNPLCCM() As String
        Get
            Return _PSNPLCCM
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property

    Public Property PSNPLACP() As String
        Get
            Return _PSNPLACP
        End Get
        Set(ByVal value As String)
            _PSNPLACP = value
        End Set
    End Property

    Public Property PSNBRVCH() As String
        Get
            Return _PSNBRVCH
        End Get
        Set(ByVal value As String)
            _PSNBRVCH = value
        End Set
    End Property

    Public Property PSTNMBCH() As String
        Get
            Return _PSTNMBCH
        End Get
        Set(ByVal value As String)
            _PSTNMBCH = value
        End Set
    End Property

    Public Property PSTDRCTR() As String
        Get
            Return _PSTDRCTR
        End Get
        Set(ByVal value As String)
            _PSTDRCTR = value
        End Set
    End Property


    Public Property PSNRUCTR() As String
        Get
            Return _PSNRUCTR
        End Get
        Set(ByVal value As String)
            _PSNRUCTR = value
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

    Public Property PNNGUIRM() As Decimal
        Get
            Return _PNNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property
    Public Property PNNCRRGR() As Decimal
        Get
            Return _PNNCRRGR
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRGR = value
        End Set
    End Property

    Public Property PNQCNGU() As Decimal
        Get
            Return _PNQCNGU
        End Get
        Set(ByVal value As Decimal)
            _PNQCNGU = value
        End Set
    End Property
    Public Property PSCUNCN() As String
        Get
            Return (_PSCUNCN)
        End Get
        Set(ByVal value As String)
            _PSCUNCN = value
        End Set
    End Property

    Public Property PNQPSGU() As Decimal
        Get
            Return _PNQPSGU
        End Get
        Set(ByVal value As Decimal)
            _PNQPSGU = value
        End Set
    End Property
    Public Property PSCUNPS() As String
        Get
            Return (_PSCUNPS)
        End Get
        Set(ByVal value As String)
            _PSCUNPS = value
        End Set
    End Property

    Public Property PSDESPROV() As String
        Get
            Return (_PSDESPROV)
        End Get
        Set(ByVal value As String)
            _PSDESPROV = value
        End Set
    End Property

    Public Property PSPLANOR() As String
        Get
            Return (_PSPLANOR)
        End Get
        Set(ByVal value As String)
            _PSPLANOR = value
        End Set
    End Property

    Public Property PSDIRORI() As String
        Get
            Return (_PSDIRORI)
        End Get
        Set(ByVal value As String)
            _PSDIRORI = value
        End Set
    End Property

    Public Property DetalleGR() As String
        Get
            Return _DetalleGR
        End Get
        Set(ByVal value As String)
            _DetalleGR = value
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
End Class
