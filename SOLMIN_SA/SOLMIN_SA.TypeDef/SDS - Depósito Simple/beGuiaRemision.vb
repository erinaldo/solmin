Public Class beGuiaRemision
    Inherits beBase(Of beGuiaRemision)

    Private _PSCREFFW As String 'COD RECEPCION	
    Private _PSCIDPAQ As String 'IDPAQUETE
    Private _PSFREFFW As String 'FECHA
    Private _PNQBLTSR As Decimal 'CANTIDAD RECIBIDO
    Private _PSTUNDIT As String 'UNIDA
    Private _PNQPEPQT As Decimal 'Peso del Paquete:
    Private _PSTUNPSO As String ' Unidad de Peso:
    Private _PSTCITCL As String 'CODIGO PRODUCTO
    Private _PSTDITES As String 'DESCRIPCION DE PRODUCTO
    Private _PSTLUGEN As String 'Lugar de Entrega
    Private _PSNGRPRV As String 'NR GUIA DE PROVEEDOR
    Private _PSNFCPRT As String 'Número de Factura Proveedor
    Private _PNFECINI As Decimal 'Parametros para Fecha Inicio
    Private _PNFECFIN As Decimal ''Pram fecha Fin
    Private _PNQCNRCP As Decimal
    Private _PSNORCML As String
    Private _PNNRITOC As Decimal
    Private _PSSTOCK As String
    Private _PSFSLFFW As String
    ''GUIA REMISION
    Private _PNCCLNT As Decimal = 0
    Private _PSNGUIRM As String = ""
    Private _PSNGUIRS As String = ""

    Private _PNANIO As Decimal = 0 'CSR-HUNDRED-SGR-DAS-DMA-PMO-001


    Private _PSDNGUIRM As String = ""
    Private _PSTPLNTA As String 'DESCRIPCION DE PLANTA

    Private _PNFGUIRM As Decimal = 0
    Private _PSORIGEN As String = ""
    Private _PSDESTINO As String = ""
    Private _PNCDPEPL As Decimal = 0
    Private _PSTCMPTR As String = ""
    Private _PSNPLCCM As String = ""
    Private _PSNBRVCH As String = ""
    Private _PSTNMBCH As String = ""
    Private _PSSESTRG As String = ""

    'Private _PSCCLNT As String = ""
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As Decimal = 0
    Private _PSSTGUSA As String = ""

    ' Private _PSCPLNDV As String = ""

    Private _PNFSLDAL_INICIAL As Decimal = 0
    Private _PNFSLDAL_FINAL As Decimal = 0
    Private _PSNMNFTF As String = ""
    Private _PSFSLDAL As String = ""
    Private _PSSMTRCP As String = ""
    Private _PSMOTREC As String = ""
    Private _PSSTPDSP As String = ""
    Private _PSTIPDES As String = ""
    Private _PSSITUAC As String = ""
    Private _PNCTRSPT As Decimal = 0
    Private _PSNPLCUN As String = ""
    Private _PSNPLCAC As String = ""
    Private _PSCBRCNT As String = ""
    Private _PSCULUSA As String = ""
    Private _PSFGUIRM_S As String = ""
    Private _PSSMTGRM As String = ""
    Private _PSMOTTRA As String = ""
    Private _PSLINK As String

    Private _PSNGUIATR As String 'GUIA TRASNPORTE
    Private _PNNOPRCN As Decimal 'NUMERO DE LA OPERACION
    Private _PSESTADOOPERACION As String 'ESTADO DE LA OPERACION
    Private _PSTIPODOC As String 'TIPO DOCUMENTO
    Private _PSNDCMFC As String 'NUMERO DE DOCUMENTO

    
    'DETALLE
    Private _PSTIPBTO As String 'TIPO BULTO
    Private _PNQPSOBL As Decimal ' PESO
    Private _PNQREFFW As Decimal 'TIPO BULTO
    Private _PSDESCWB As String 'DESCRIPCION DEL BULTO
    Private _PNQVLBTO As Decimal 'VOLUMEN
    Private _PSTUNVOL As String 'UNIDAD DE VOLUMEN
    Private _PNQAROCP As Decimal 'MT2
    Private _PSDESPROV As String 'PROVEEDOR
    Private _PSSESDCM_DES As String 'Descripcion  del estado de guia de remision
    Private _PSSESDCM As String 'codigo del estado de guia de remision

    Private _PSPLANTA As String
    Private _PSTCMPCL As String

    'campos de datos de referencia
    Private _CLCRGA As String = ""
    Private _UPROGM As String = ""
    Private _EMAPRB As String = ""
    Private _USLCNT As String = ""
    Private _APRBDO As String = ""
    Private _GRENCI As String = ""
    Private _AREASL As String = ""

    Private _SERIEGR As String = ""


    Private _PNNMRGIM As Decimal

    Private _PSCTDGRM As String = ""

    Private _PNCUBGET As Decimal = 0

    Private _PSDNGUIRS As String = ""

    Private _PSPLTORIGEN As String = ""

    Private _PSPLTDESTINO As String = ""

    Private _PSNGUISO As String = ""

    'Private _PSSTRNGR As String = ""
    'Private _PSSTRNGR_DESC As String = ""
 
 

    Private _PSSTRNEG As String = ""
    Private _PSSTRNAG As String = ""
    Public Property PNNMRGIM() As Decimal
        Get
            Return _PNNMRGIM
        End Get
        Set(ByVal value As Decimal)
            _PNNMRGIM = value
        End Set
    End Property


    Public Property PSPLANTA() As String
        Get
            Return (_PSPLANTA)
        End Get
        Set(ByVal value As String)
            _PSPLANTA = value
        End Set
    End Property

    Public Property PSTCMPCL() As String
        Get
            Return (_PSTCMPCL)
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property PSTIPBTO() As String
        Get
            Return _PSTIPBTO
        End Get
        Set(ByVal value As String)
            _PSTIPBTO = value
        End Set
    End Property
    Public Property PNQPSOBL() As Decimal
        Get
            Return _PNQPSOBL
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOBL = value
        End Set
    End Property
    Public Property PNQREFFW() As Decimal
        Get
            Return _PNQREFFW
        End Get
        Set(ByVal value As Decimal)
            _PNQREFFW = value
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
    Public Property PNQVLBTO() As Decimal
        Get
            Return _PNQVLBTO
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
    Public Property PNQAROCP() As Decimal
        Get
            Return _PNQAROCP
        End Get
        Set(ByVal value As Decimal)
            _PNQAROCP = value
        End Set
    End Property
    Public Property PSDESPROV() As String
        Get
            Return _PSDESPROV
        End Get
        Set(ByVal value As String)
            _PSDESPROV = value
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

    Public Property PSMOTTRA() As String
        Get
            Return _PSMOTTRA
        End Get
        Set(ByVal value As String)
            _PSMOTTRA = value
        End Set
    End Property


    Public Property PSSMTGRM() As String
        Get
            Return _PSSMTGRM
        End Get
        Set(ByVal value As String)
            _PSSMTGRM = value
        End Set
    End Property


    Private _PSTOBORM As String
    Public Property PSTOBORM() As String
        Get
            Return _PSTOBORM
        End Get
        Set(ByVal value As String)
            _PSTOBORM = value
        End Set
    End Property

    Public Property PSFGUIRM_S() As String
        Get
            Return _PSFGUIRM_S
        End Get
        Set(ByVal value As String)
            _PSFGUIRM_S = value
        End Set
    End Property

    Public Property PSNMNFTF() As String
        Get
            Return _PSNMNFTF
        End Get
        Set(ByVal value As String)
            _PSNMNFTF = value
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
    Public Property PSSMTRCP() As String
        Get
            Return _PSSMTRCP
        End Get
        Set(ByVal value As String)
            _PSSMTRCP = value
        End Set
    End Property
    Public Property PSMOTREC() As String
        Get
            Return _PSMOTREC
        End Get
        Set(ByVal value As String)
            _PSMOTREC = value
        End Set
    End Property
    Public Property PSSTPDSP() As String
        Get
            Return _PSSTPDSP
        End Get
        Set(ByVal value As String)
            _PSSTPDSP = value
        End Set
    End Property
    Public Property PSTIPDES() As String
        Get
            Return _PSTIPDES
        End Get
        Set(ByVal value As String)
            _PSTIPDES = value
        End Set
    End Property
    Public Property PSSITUAC() As String
        Get
            Return _PSSITUAC
        End Get
        Set(ByVal value As String)
            _PSSITUAC = value
        End Set
    End Property
    Public Property PNCTRSPT() As Decimal
        Get
            Return _PNCTRSPT
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property

    Private _PNCPLCLP As Decimal
    Public Property PNCPLCLP() As Decimal
        Get
            Return _PNCPLCLP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property

    Public Property PSNPLCUN() As String
        Get
            Return _PSNPLCUN
        End Get
        Set(ByVal value As String)
            _PSNPLCUN = value
        End Set
    End Property
    Public Property PSNPLCAC() As String
        Get
            Return _PSNPLCAC
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property
    Public Property PSCBRCNT() As String
        Get
            Return _PSCBRCNT
        End Get
        Set(ByVal value As String)
            _PSCBRCNT = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property


    ''DETALLE GR
    Private _PSCMRCLR As String = ""
    Private _PSDMRCLR As String = ""
    Private _PNQTRMC As Decimal = 0
    Private _PSCUNCN6 As String = ""
    Private _PNQTRMP As Decimal = 0
    Private _PSCUNPS6 As String = ""
    ''OBSERV GR
    Private _PSTOBSGS As String = ""

    ''Filtro de la Guia
    Private _PNTIPO As Integer = 0
    Private _PNQCNGU As Decimal
    Private _PSCUNCN As String
    Private _PNQPSGU As Decimal
    Private _PSCUNPS As String
    Private _PNNCRRGR As Decimal


    Private _PSCHECK As Boolean
    Private _PSNMRGIM_S As String = ""

    Public Property PSSTGUSA() As String
        Get
            Return _PSSTGUSA
        End Get
        Set(ByVal value As String)
            _PSSTGUSA = value
        End Set
    End Property


    Public Property PNFSLDAL_INICIAL() As Decimal
        Get
            Return _PNFSLDAL_INICIAL
        End Get
        Set(ByVal value As Decimal)
            _PNFSLDAL_INICIAL = value
        End Set
    End Property


    Public Property PNFSLDAL_FINAL() As Decimal
        Get
            Return _PNFSLDAL_FINAL
        End Get
        Set(ByVal value As Decimal)
            _PNFSLDAL_FINAL = value
        End Set
    End Property

    Public Property PSCHECK() As Boolean
        Get
            Return _PSCHECK
        End Get
        Set(ByVal value As Boolean)
            _PSCHECK = value
        End Set
    End Property

    'Public Property PSCCLNT() As String
    '    Get
    '        Return _PSCCLNT
    '    End Get
    '    Set(ByVal value As String)
    '        _PSCCLNT = value
    '    End Set
    'End Property

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


    'Public Property PSCPLNDV() As String
    '    Get
    '        Return _PSCPLNDV
    '    End Get
    '    Set(ByVal value As String)
    '        _PSCPLNDV = value
    '    End Set
    'End Property

    Public Property PNNCRRGR() As Decimal
        Get
            Return _PNNCRRGR
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRGR = value
        End Set
    End Property

    Private _PNNSLCSR As Decimal
    Public Property PNNSLCSR() As Decimal
        Get
            Return _PNNSLCSR
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSR = value
        End Set
    End Property

    Public Property PSCUNPS() As String
        Get
            Return _PSCUNPS
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                _PSCUNPS = ""
            Else
                _PSCUNPS = value
            End If

        End Set
  End Property

  Private _PSTOBDGS As String
  Public Property PSTOBDGS() As String
    Get
      Return _PSTOBDGS
    End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                _PSTOBDGS = ""
            Else
                _PSTOBDGS = value
            End If
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


    Public Property PSCUNCN() As String
        Get
            Return _PSCUNCN
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                _PSCUNCN = ""
            Else
                _PSCUNCN = value
            End If

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


    Private _PSTDITEM As String
    Public Property PSTDITEM() As String
        Get
            Return _PSTDITEM
        End Get
        Set(ByVal value As String)
            _PSTDITEM = value
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

    Public Property PNQCNRCP() As Decimal
        Get
            Return _PNQCNRCP
        End Get
        Set(ByVal value As Decimal)
            _PNQCNRCP = value
        End Set
    End Property


    Private _PSNRFTPD As String
    Public Property PSNRFTPD() As String
        Get
            Return _PSNRFTPD
        End Get
        Set(ByVal value As String)
            _PSNRFTPD = value
        End Set
    End Property


    Private _PSNRFRPD As String
    Public Property PSNRFRPD() As String
        Get
            Return _PSNRFRPD
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
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



    Public Property PNTIPO() As Integer
        Get
            Return _PNTIPO
        End Get
        Set(ByVal value As Integer)
            _PNTIPO = value
        End Set
    End Property

    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property


    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property


    ''GUIA REMISION
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
    Public Property PNANIO() As Decimal
        Get
            Return _PNANIO
        End Get
        Set(ByVal value As Decimal)
            _PNANIO = value
        End Set
    End Property
    'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN


    Public Property PSNGUIRM() As String
        Get
            Return _PSNGUIRM
        End Get
        Set(ByVal value As String)
            _PSNGUIRM = value
        End Set
    End Property

    Public Property PSNGUIRS() As String
        Get
            Return _PSNGUIRS
        End Get
        Set(ByVal value As String)
            _PSNGUIRS = value
        End Set
    End Property




    Private _PNCPLNOR As Decimal
    Public Property PNCPLNOR() As Decimal
        Get
            Return _PNCPLNOR
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNOR = value
        End Set
    End Property

    Private _PNCPLNCL As Decimal
    Public Property PNCPLNCL() As Decimal
        Get
            Return _PNCPLNCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNCL = value
        End Set
    End Property


    Public Property PSDNGUIRM() As String
        Get
            Return _PSDNGUIRM
        End Get
        Set(ByVal value As String)
            _PSDNGUIRM = value
        End Set
    End Property
    Public Property PSTPLNTA() As String
        Get
            Return _PSTPLNTA
        End Get
        Set(ByVal value As String)
            _PSTPLNTA = value
        End Set
    End Property
    Public Property PNFGUIRM() As Decimal
        Get
            Return _PNFGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNFGUIRM = value
        End Set
    End Property

    Private _PNFINTRA As Decimal

    Public Property PNFINTRA() As Decimal
        Get
            Return _PNFINTRA
        End Get
        Set(ByVal value As Decimal)
            _PNFINTRA = value
        End Set
    End Property

    Public Property PSORIGEN() As String
        Get
            Return _PSORIGEN
        End Get
        Set(ByVal value As String)
            _PSORIGEN = value
        End Set
    End Property
    Public Property PSDESTINO() As String
        Get
            Return _PSDESTINO
        End Get
        Set(ByVal value As String)
            _PSDESTINO = value
        End Set
    End Property
    Public Property PNCDPEPL() As Decimal
        Get
            Return _PNCDPEPL
        End Get
        Set(ByVal value As Decimal)
            _PNCDPEPL = value
        End Set
    End Property
    Public Property PSTCMPTR() As String
        Get
            Return _PSTCMPTR
        End Get
        Set(ByVal value As String)
            _PSTCMPTR = value
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


    Private _PSNPLACP As String
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
    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property



    Private _PNNDCMRF As Decimal
    Public Property PNNDCMRF() As Decimal
        Get
            Return _PNNDCMRF
        End Get
        Set(ByVal value As Decimal)
            _PNNDCMRF = value
        End Set
    End Property


    Private _PNCMEDTR As Decimal
    Public Property PNCMEDTR() As Decimal
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property


    Private _PNCPRVCO As Decimal
    Public Property PNCPRVCO() As Decimal
        Get
            Return _PNCPRVCO
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCO = value
        End Set
    End Property



    Private _PNCPLCLO As Decimal
    Public Property PNCPLCLO() As Decimal
        Get
            Return _PNCPLCLO
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLO = value
        End Set
    End Property

    ''DETALLE GR


    Private _PSTOBSRM As String
    Public Property PSTOBSRM() As String
        Get
            Return _PSTOBSRM
        End Get
        Set(ByVal value As String)
            _PSTOBSRM = value
        End Set
    End Property


    Private _TOBCLI As String
    Public Property PSTOBCLI() As String
        Get
            Return _TOBCLI
        End Get
        Set(ByVal value As String)
            _TOBCLI = value
        End Set
    End Property


    Public Property PSCMRCLR() As String
        Get
            Return _PSCMRCLR
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = IIf(value Is Nothing, "", value)
        End Set
    End Property
    Public Property PSDMRCLR() As String
        Get
            Return _PSDMRCLR
        End Get
        Set(ByVal value As String)
            _PSDMRCLR = value
        End Set
    End Property
    Public Property PNQTRMC() As Decimal
        Get
            Return _PNQTRMC
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property
    Public Property PSCUNCN6() As String
        Get
            Return _PSCUNCN6
        End Get
        Set(ByVal value As String)
            _PSCUNCN6 = value
        End Set
    End Property
    Public Property PNQTRMP() As Decimal
        Get
            Return _PNQTRMP
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP = value
        End Set
    End Property
    Public Property PSCUNPS6() As String
        Get
            Return _PSCUNPS6
        End Get
        Set(ByVal value As String)
            _PSCUNPS6 = value
        End Set
    End Property

    ''OBSERV GR
    Public Property PSTOBSGS() As String
        Get
            Return _PSTOBSGS
        End Get
        Set(ByVal value As String)
            _PSTOBSGS = value
        End Set
    End Property


    Private _PNCPRVCL As Decimal
    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Private _PSCUSCRT As String
    Public Property PSCUSCRT() As String
        Get
            Return _PSCUSCRT
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property


    Public Property PSFECGUIA() As String
        Get
            Return NumeroAFecha(_PNFGUIRM)
        End Get
        Set(ByVal value As String)
            _PNFGUIRM = CtypeDate(value)
        End Set
    End Property



    Private _PNNROCTL As Decimal
    Public Property PNNROCTL() As Decimal
        Get
            Return _PNNROCTL
        End Get
        Set(ByVal value As Decimal)
            _PNNROCTL = value
        End Set
    End Property



    Private _PNNRGUSA As Decimal
    Public Property PNNRGUSA() As Decimal
        Get
            Return _PNNRGUSA
        End Get
        Set(ByVal value As Decimal)
            _PNNRGUSA = value
        End Set
    End Property


    Private _GUIASALIDA As String
    Public Property GUIASALIDA() As String
        Get
            Return _GUIASALIDA
        End Get
        Set(ByVal value As String)
            _GUIASALIDA = value
        End Set
    End Property


    Private _PSUSUARIO As String
    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property

    Public Property PSNGUIATR() As String
        Get
            Return _PSNGUIATR
        End Get
        Set(ByVal value As String)
            _PSNGUIATR = value
        End Set
    End Property
    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property
    Public Property PSESTADOOPERACION() As String
        Get
            Return _PSESTADOOPERACION
        End Get
        Set(ByVal value As String)
            _PSESTADOOPERACION = value
        End Set
    End Property
    Public Property PSTIPODOC() As String
        Get
            Return _PSTIPODOC
        End Get
        Set(ByVal value As String)
            _PSTIPODOC = value
        End Set
    End Property
    Public Property PSNDCMFC() As String
        Get
            Return _PSNDCMFC
        End Get
        Set(ByVal value As String)
            _PSNDCMFC = value
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



    Private _strAplicacion As String
    ''' <summary>
    ''' Direccion de la aplicacion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property strAplicacion() As String
        Get
            Return _strAplicacion
        End Get
        Set(ByVal value As String)
            _strAplicacion = value
        End Set
    End Property

    Public Property PSSESDCM_DES() As String
        Get
            Return _PSSESDCM_DES
        End Get
        Set(ByVal value As String)
            _PSSESDCM_DES = value
        End Set
    End Property
    Public Property PSSESDCM() As String
        Get
            Return _PSSESDCM
        End Get
        Set(ByVal value As String)
            _PSSESDCM = value
        End Set
    End Property


    Private _PNTDCFCC As Decimal
    Public Property PNTDCFCC() As Decimal
        Get
            Return _PNTDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNTDCFCC = value
        End Set
    End Property


    Private _PNNDCFCC As Decimal
    Public Property PNNDCFCC() As Decimal
        Get
            Return _PNNDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNNDCFCC = value
        End Set
    End Property


    Private _PNFDCFCC As Decimal
    Public Property PNFDCFCC() As Decimal
        Get
            Return _PNFDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNFDCFCC = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha Factura Contado 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaDocumento() As String
        Get
            Return NumeroAFecha(_PNFDCFCC)
        End Get
        Set(ByVal value As String)
            _PNFDCFCC = CtypeDate(value)
        End Set
    End Property


    Public Property FechaContrato() As String
        Get
            Return NumeroAFecha(_PNFDCFCC)
        End Get
        Set(ByVal value As String)
            _PNFDCFCC = CtypeDate(value)
        End Set
    End Property

    Private _SSTVAL As String
    Public Property PSSSTVAL() As String
        Get
            Return _SSTVAL
        End Get
        Set(ByVal value As String)
            _SSTVAL = value
        End Set
    End Property



    Public Property CLCRGA() As String
        Get
            Return _CLCRGA
        End Get
        Set(ByVal value As String)
            _CLCRGA = value
        End Set
    End Property

public property UPROGM ()as string
        Get
            Return _UPROGM
        End Get
        Set(ByVal value As String)
            _UPROGM = value
        End Set
    End Property

public property EMAPRB() as string
        Get
            Return _EMAPRB
        End Get
        Set(ByVal value As String)
            _EMAPRB = value
        End Set
    End Property

public property USLCNT() as string
        Get
            Return _USLCNT
        End Get
        Set(ByVal value As String)
            _USLCNT = value
        End Set
    End Property

public property APRBDO() as string
        Get
            Return _APRBDO
        End Get
        Set(ByVal value As String)
            _APRBDO = value
        End Set
    End Property

public property GRENCI() as string
        Get
            Return _GRENCI
        End Get
        Set(ByVal value As String)
            _GRENCI = value
        End Set
    End Property

public property AREASL() as string
        Get
            Return _AREASL
        End Get
        Set(ByVal value As String)
            _AREASL = value
        End Set
    End Property

    Public Property SERIEGR() As String
        Get
            Return _SERIEGR
        End Get
        Set(ByVal value As String)
            _SERIEGR = value
        End Set
    End Property

    Public Property PSCTDGRM() As String
        Get
            Return _PSCTDGRM
        End Get
        Set(ByVal value As String)
            _PSCTDGRM = value
        End Set
    End Property

    Public Property PNCUBGET() As Decimal
        Get
            Return _PNCUBGET
        End Get
        Set(ByVal value As Decimal)
            _PNCUBGET = value
        End Set
    End Property

    Public Property PSDNGUIRS() As String
        Get
            Return _PSDNGUIRS
        End Get
        Set(ByVal value As String)
            _PSDNGUIRS = value
        End Set
    End Property

    Public Property PSPLTORIGEN() As String
        Get
            Return _PSPLTORIGEN
        End Get
        Set(ByVal value As String)
            _PSPLTORIGEN = value
        End Set
    End Property

    Public Property PSPLTDESTINO() As String
        Get
            Return _PSPLTDESTINO
        End Get
        Set(ByVal value As String)
            _PSPLTDESTINO = value
        End Set
    End Property

    Public Property PSNGUISO() As String
        Get
            Return _PSNGUISO
        End Get
        Set(ByVal value As String)
            _PSNGUISO = value
        End Set
    End Property


    'Public Property PSSTRNGR() As String
    '    Get
    '        Return _PSSTRNGR
    '    End Get
    '    Set(ByVal value As String)
    '        _PSSTRNGR = value
    '    End Set
    'End Property
    'Public Property PSSTRNGR_DESC() As String
    '    Get
    '        Return _PSSTRNGR_DESC
    '    End Get
    '    Set(ByVal value As String)
    '        _PSSTRNGR_DESC = value
    '    End Set
    'End Property

    Public Property PSSTRNEG() As String
        Get
            Return _PSSTRNEG
        End Get
        Set(ByVal value As String)
            _PSSTRNEG = value
        End Set
    End Property

    Public Property PSSTRNAG() As String
        Get
            Return _PSSTRNAG
        End Get
        Set(ByVal value As String)
            _PSSTRNAG = value
        End Set
    End Property

    Public Property PSNMRGIM_S() As String
        Get
            Return _PSNMRGIM_S
        End Get
        Set(ByVal value As String)
            _PSNMRGIM_S = value
        End Set
    End Property


  


#Region "Datos Adisionales"



    Private _PNNLINGR As Decimal
    Public Property PNNLINGR() As Decimal
        Get
            Return _PNNLINGR
        End Get
        Set(ByVal value As Decimal)
            _PNNLINGR = value
        End Set
    End Property

    Private _PSMODELO As String
    ''' <summary>
    ''' Es el modelo de la Guía de remision el modelo de la guia varia por cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSMODELO() As String
        Get
            Return _PSMODELO
        End Get
        Set(ByVal value As String)
            _PSMODELO = value
        End Set
    End Property


    Private _PSDECONC As String
    Public Property PSDECONC() As String
        Get
            Return _PSDECONC
        End Get
        Set(ByVal value As String)
            _PSDECONC = value
        End Set
    End Property


    Private _PSMGUIFA As String
    Public Property PSMGUIFA() As String
        Get
            Return _PSMGUIFA
        End Get
        Set(ByVal value As String)
            _PSMGUIFA = value
        End Set
    End Property


    Private _PSMGFFIN As String
    Public Property PSMGFFIN() As String
        Get
            Return _PSMGFFIN
        End Get
        Set(ByVal value As String)
            _PSMGFFIN = value
        End Set
    End Property


    Private _PSMOBSER As String
    Public Property PSMOBSER() As String
        Get
            Return _PSMOBSER
        End Get
        Set(ByVal value As String)
            _PSMOBSER = value
        End Set
    End Property


    Private _PSTOXBUL As String
    Public Property PSTOXBUL() As String
        Get
            Return _PSTOXBUL
        End Get
        Set(ByVal value As String)
            _PSTOXBUL = value
        End Set
    End Property

    Private _CPRCN1 As String
    Public Property PSCPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal value As String)
            _CPRCN1 = value
        End Set
    End Property

    Private _NSRCN1 As String
    Public Property PSNSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal value As String)
            _NSRCN1 = value
        End Set
    End Property

    Private _PNNGUIRO As Decimal
    Public Property PNNGUIRO() As Decimal
        Get
            Return _PNNGUIRO
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRO = value
        End Set
    End Property


    Private _PSSTRNSM As String
    Public Property PSSTRNSM() As String
        Get
            Return _PSSTRNSM
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property

    Private _PNCCLNGR As Decimal = 0
    Public Property PNCCLNGR() As Decimal
        Get
            Return _PNCCLNGR
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNGR = value
        End Set
    End Property


    Private _PSCSRECL As String
    Public Property PSCSRECL() As String
        Get
            Return _PSCSRECL
        End Get
        Set(ByVal value As String)
            _PSCSRECL = IIf(value Is Nothing, "", value)
        End Set
    End Property

#Region "Atributos agregados para la interfaz con Outotec"

    Private _strTipoMovIntfz As String
    Public Property pstrTipoMovIntfz() As String
        Get
            Return _strTipoMovIntfz
        End Get
        Set(ByVal value As String)
            _strTipoMovIntfz = value
        End Set
    End Property


    Private _PSSERIE As String
    Public Property PSSERIE() As String
        Get
            Return _PSNGUIRM.Substring(0, 3)
        End Get
        Set(ByVal value As String)
            _PSSERIE = value
        End Set
    End Property


    Private _PSNROFIC As String
    Public Property PSNROFIC() As String
        Get
            Return _PSNGUIRM.Substring(3, 7)
        End Get
        Set(ByVal value As String)
            _PSNROFIC = value
        End Set
    End Property

    Public Property FechaEmisionGuia() As String
        Get
            Return NumeroAFecha(_PNFGUIRM)
        End Get
        Set(ByVal value As String)
            _PNFGUIRM = CtypeDate(value)
        End Set
    End Property


    Public ReadOnly Property FechaInicioTraslado() As String
        Get
            Return NumeroAFecha(_PNFINTRA)
        End Get
    End Property

    Private _dteFGUIRM As Date
    Public Property FechaEmision_FGUIRM() As Date
        Get
            Return _dteFGUIRM
        End Get
        Set(ByVal value As Date)
            _dteFGUIRM = value
        End Set
    End Property

    Private _dteFINTRA As Date
    Public Property FechaTraslado_FINTRA() As Date
        Get
            Return _dteFINTRA
        End Get
        Set(ByVal value As Date)
            _dteFINTRA = value
        End Set
    End Property

    Private _dteFDCFCC As Date
    Public Property FechaEmisionDocumento_FDCFCC() As Date
        Get
            Return _dteFDCFCC
        End Get
        Set(ByVal value As Date)
            _dteFDCFCC = value
        End Set
    End Property

    Private _PSTIPORG As String
    ''' <summary>
    ''' CLASE DE ORIGEN SI ES PROVEEDOR CLIENTE O ALMACEN
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTIPORG() As String
        Get
            Return _PSTIPORG
        End Get
        Set(ByVal value As String)
            _PSTIPORG = value
        End Set
    End Property


    Private _PSCORIDE As String
    ''' <summary>
    ''' COD CLIENTE TERCERO DE GUIA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCORIDE() As String
        Get
            Return _PSCORIDE
        End Get
        Set(ByVal value As String)
            _PSCORIDE = value
        End Set
    End Property

    Private _PSNRGMT1 As String
    Public Property PSNRGMT1() As String
        Get
            Return _PSNRGMT1
        End Get
        Set(ByVal value As String)
            _PSNRGMT1 = value
        End Set
    End Property


    Private _PNNRUCT As Decimal
    Public Property PNNRUCT() As Decimal
        Get
            Return _PNNRUCT
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCT = value
        End Set
    End Property

    Private _TransferReason As String
    Public Property TransferReason() As String
        Get
            Return _TransferReason
        End Get
        Set(ByVal value As String)
            _TransferReason = value
        End Set
    End Property

    Private _TransportCarrierFiscalCode As String
    Public Property TransportCarrierFiscalCode() As String
        Get
            Return _TransportCarrierFiscalCode
        End Get
        Set(ByVal value As String)
            _TransportCarrierFiscalCode = value
        End Set
    End Property

    Private _TransportCarrierAddress As String
    Public Property TransportCarrierAddress() As String
        Get
            Return _TransportCarrierAddress
        End Get
        Set(ByVal value As String)
            _TransportCarrierAddress = value
        End Set
    End Property

    Private _Driver As String = ""
    Public Property Driver() As String
        Get
            Return _Driver
        End Get
        Set(ByVal value As String)
            _Driver = value
        End Set
    End Property

    Public ReadOnly Property pstrFechaEmision_FGUIRM() As String
        Get
            Dim strResultado As String = ""
            If _dteFGUIRM.Year > 1 Then strResultado = _dteFGUIRM.ToString("yyyyMMdd")
            Return strResultado
        End Get
    End Property

    Public ReadOnly Property pstrFechaTraslado_FINTRA() As String
        Get
            Dim strResultado As String = ""
            If _dteFINTRA.Year > 1 Then strResultado = _dteFINTRA.ToString("yyyyMMdd")
            Return strResultado
        End Get
    End Property

    Public ReadOnly Property pstrFechaEmisionDocumento_FDCFCC() As String
        Get
            Dim strResultado As String = ""
            If _dteFDCFCC.Year > 1 Then strResultado = _dteFDCFCC.ToString("yyyyMMdd")
            Return strResultado
        End Get
    End Property

    Private _intTipoRep As Integer = 0
    Public Property TipoRep() As Integer
        Get
            TipoRep = _intTipoRep
        End Get
        Set(ByVal value As Integer)
            _intTipoRep = value
        End Set
    End Property

    Private _pstrOrderType As String = ""
    Public Property pstrOrderType() As String
        Get
            Return _pstrOrderType
        End Get
        Set(ByVal value As String)
            _pstrOrderType = value
        End Set
    End Property

    Private _OrderNumber As String
    Public Property pstrOrderNumber() As String
        Get
            Return _OrderNumber
        End Get
        Set(ByVal value As String)
            _OrderNumber = value
        End Set
    End Property


    Private _PNNGUIRN As String
    Public Property PNNGUIRN() As String
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As String)
            _PNNGUIRN = value
        End Set
    End Property

#End Region


#End Region
    Public Sub New()
        Me.InicializeProperty(Me)

    End Sub
End Class

