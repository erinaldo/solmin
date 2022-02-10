
Public Class AtencionRequerimiento

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CCMPN_S As String = ""
    Public Property CCMPN_S() As String
        Get
            Return _CCMPN_S
        End Get
        Set(ByVal value As String)
            _CCMPN_S = value
        End Set
    End Property

    Private _CDVSN As String = ""
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CDVSN_S As String = ""
    Public Property CDVSN_S() As String
        Get
            Return _CDVSN_S
        End Get
        Set(ByVal value As String)
            _CDVSN_S = value
        End Set
    End Property

    Private _CPLNDV As Decimal = 0D
    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property

    Private _CPLNDV_S As String = ""
    Public Property CPLNDV_S() As String
        Get
            Return _CPLNDV_S
        End Get
        Set(ByVal value As String)
            _CPLNDV_S = value
        End Set
    End Property

    Private _CCLNT As Decimal = 0D
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Private _CCLNT_S As String = ""
    Public Property CCLNT_S() As String
        Get
            Return _CCLNT_S
        End Get
        Set(ByVal value As String)
            _CCLNT_S = value
        End Set
    End Property

    Private _NUMREQT As Decimal = 0D 'Nro Req
    Public Property NUMREQT() As Decimal
        Get
            Return _NUMREQT
        End Get
        Set(ByVal value As Decimal)
            _NUMREQT = value
        End Set
    End Property

    Private _HRAREQ As Decimal = 0D 'Hora Req
    Public Property HRAREQ() As Decimal
        Get
            Return _HRAREQ
        End Get
        Set(ByVal value As Decimal)
            _HRAREQ = value
        End Set
    End Property

    Private _HRAREQ_S As String = "" 'Hora Req String
    Public Property HRAREQ_S() As String
        Get
            Return _HRAREQ_S
        End Get
        Set(ByVal value As String)
            _HRAREQ_S = value
        End Set
    End Property


    'Private _FRGTRO As Decimal = 0D 'Fecha registro
    'Public Property FRGTRO() As Decimal
    '    Get
    '        Return _FRGTRO
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FRGTRO = value
    '    End Set
    'End Property

    'Private _FRGTRO_INI As Decimal = 0D 'Fecha registro
    'Public Property FRGTRO_INI() As Decimal
    '    Get
    '        Return _FRGTRO_INI
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FRGTRO_INI = value
    '    End Set
    'End Property


    'Private _FRGTRO_FIN As Decimal = 0D 'Fecha registro
    'Public Property FRGTRO_FIN() As Decimal
    '    Get
    '        Return _FRGTRO_FIN
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FRGTRO_FIN = value
    '    End Set
    'End Property


    'Private _FRGTRO_S As String = "" 'Fecha registro String
    'Public Property FRGTRO_S() As String
    '    Get
    '        Return _FRGTRO_S
    '    End Get
    '    Set(ByVal value As String)
    '        _FRGTRO_S = value
    '    End Set
    'End Property

    'Private _HRGTRO As Decimal = 0D 'Hora registro
    'Public Property HRGTRO() As Decimal
    '    Get
    '        Return _HRGTRO
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _HRGTRO = value
    '    End Set
    'End Property


    'Private _HRGTRO_INI As Decimal = 0D 'Hora registro
    'Public Property HRGTRO_INI() As Decimal
    '    Get
    '        Return _HRGTRO_INI
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _HRGTRO_INI = value
    '    End Set
    'End Property


    'Private _HRGTRO_FIN As Decimal = 0D 'Hora registro
    'Public Property HRGTRO_FIN() As Decimal
    '    Get
    '        Return _HRGTRO_FIN
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _HRGTRO_FIN = value
    '    End Set
    'End Property

    'Private _HRGTRO_S As String = "" 'Hora registro String
    'Public Property HRGTRO_S() As String
    '    Get
    '        Return _HRGTRO_S
    '    End Get
    '    Set(ByVal value As String)
    '        _HRGTRO_S = value
    '    End Set
    'End Property

    Private _FECREQ As Decimal = 0D 'Fecha Req
    Public Property FECREQ() As Decimal
        Get
            Return _FECREQ
        End Get
        Set(ByVal value As Decimal)
            _FECREQ = value
        End Set
    End Property

    Private _FECREQ_S As String = "" 'Fecha Req String
    Public Property FECREQ_S() As String
        Get
            Return _FECREQ_S
        End Get
        Set(ByVal value As String)
            _FECREQ_S = value
        End Set
    End Property


    Private _FECREQ_INI As Decimal = 0D 'Fecha Req
    Public Property FECREQ_INI() As Decimal
        Get
            Return _FECREQ_INI
        End Get
        Set(ByVal value As Decimal)
            _FECREQ_INI = value
        End Set
    End Property

    Private _FECREQ_FIN As Decimal = 0D 'Fecha Req
    Public Property FECREQ_FIN() As Decimal
        Get
            Return _FECREQ_FIN
        End Get
        Set(ByVal value As Decimal)
            _FECREQ_FIN = value
        End Set
    End Property

    Private _HRAREQ_INI As Decimal = 0D 'Hora Ini Req
    Public Property HRAREQ_INI() As Decimal
        Get
            Return _HRAREQ_INI
        End Get
        Set(ByVal value As Decimal)
            _HRAREQ_INI = value
        End Set
    End Property

    Private _HRAREQ_FIN As Decimal = 0D 'Hora Fin Req
    Public Property HRAREQ_FIN() As Decimal
        Get
            Return _HRAREQ_FIN
        End Get
        Set(ByVal value As Decimal)
            _HRAREQ_FIN = value
        End Set
    End Property

    Private _SPRSTR As String = "" 'Prioridad
    Public Property SPRSTR() As String
        Get
            Return _SPRSTR
        End Get
        Set(ByVal value As String)
            _SPRSTR = value
        End Set
    End Property


    Private _SPRSTR_S As String = "" 'Prioridad CADENA
    Public Property SPRSTR_S() As String
        Get
            Return _SPRSTR_S
        End Get
        Set(ByVal value As String)
            _SPRSTR_S = value
        End Set
    End Property

    Private _TIPOCNT As String = ""  'Tipo Mercadería
    Public Property TIPOCNT() As String
        Get
            Return _TIPOCNT
        End Get
        Set(ByVal value As String)
            _TIPOCNT = value
        End Set
    End Property

    Private _TIPOCNT_S As String = ""
    Public Property TIPOCNT_S() As String
        Get
            Return _TIPOCNT_S
        End Get
        Set(ByVal value As String)
            _TIPOCNT_S = value
        End Set
    End Property

    Private _QPSOMR As Decimal = 0D 'Peso(kg)  15,5
    Public Property QPSOMR() As Decimal
        Get
            Return _QPSOMR
        End Get
        Set(ByVal value As Decimal)
            _QPSOMR = value
        End Set
    End Property

    Private _QMTLRG As Decimal = 0D 'Largo(m) 7,2
    Public Property QMTLRG() As Decimal
        Get
            Return _QMTLRG
        End Get
        Set(ByVal value As Decimal)
            _QMTLRG = value
        End Set
    End Property

    Private _QMTALT As Decimal = 0D 'Alto(m) 7,2
    Public Property QMTALT() As Decimal
        Get
            Return _QMTALT
        End Get
        Set(ByVal value As Decimal)
            _QMTALT = value
        End Set
    End Property

    Private _QMTANC As Decimal = 0D 'Ancho(m) 7,2
    Public Property QMTANC() As Decimal
        Get
            Return _QMTANC
        End Get
        Set(ByVal value As Decimal)
            _QMTANC = value
        End Set
    End Property

    Private _NRCTSL As Decimal = 0D 'Nro. de Contrato SOLMIN 10
    Public Property NRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            _NRCTSL = value
        End Set
    End Property

    Private _NRTFSV As Decimal = 0D 'Nro. Tarifa X Servicio 10
    Public Property NRTFSV() As Decimal
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Decimal)
            _NRTFSV = value
        End Set
    End Property

    Private _NDCORM As Decimal = 0D
    Public Property NDCORM() As Decimal
        Get
            Return _NDCORM
        End Get
        Set(ByVal value As Decimal)
            _NDCORM = value
        End Set
    End Property


    Private _NCRRSR As Decimal = 0D 'Numero Correlativo del Servicio    5
    Public Property NCRRSR() As Decimal
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Decimal)
            _NCRRSR = value
        End Set
    End Property

    Private _REFDO1 As String = "" 'Doc. Referencia 100
    Public Property REFDO1() As String
        Get
            Return _REFDO1
        End Get
        Set(ByVal value As String)
            _REFDO1 = value
        End Set
    End Property

    Private _SESREQ As String = ""  'Estado Req.    1
    Public Property SESREQ() As String
        Get
            Return _SESREQ
        End Get
        Set(ByVal value As String)
            _SESREQ = value
        End Set
    End Property

    Private _SESREQ_S As String = ""  'Estado Req.    1
    Public Property SESREQ_S() As String
        Get
            Return _SESREQ_S
        End Get
        Set(ByVal value As String)
            _SESREQ_S = value
        End Set
    End Property

    Private _SESTRG As String = ""  'Estado Registro
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Private _CUSCRT As String = ""
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Private _FCHCRT As Decimal = 0D
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Private _HRACRT As Decimal = 0D
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Private _NTRMCR As String = ""
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Private _FULTAC As Decimal = 0D
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Private _HULTAC As Decimal = 0D
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Private _TIPSRV As String = "" 'Tipo req
    Public Property TIPSRV() As String
        Get
            Return _TIPSRV
        End Get
        Set(ByVal value As String)
            _TIPSRV = value
        End Set
    End Property

    Private _TIPSRV_S As String = "" 'Tipo req cadena
    Public Property TIPSRV_S() As String
        Get
            Return _TIPSRV_S
        End Get
        Set(ByVal value As String)
            _TIPSRV_S = value
        End Set
    End Property


    Private _TOBS As String = ""
    Public Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal value As String)
            _TOBS = value
        End Set
    End Property


    Private _NORSRT As Decimal = 0D
    Public Property NORSRT() As Decimal
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Decimal)
            _NORSRT = value
        End Set
    End Property


    Private _CLCLOR As Decimal = 0D
    Public Property CLCLOR() As Decimal
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Decimal)
            _CLCLOR = value
        End Set
    End Property

    Private _CLCLOR_S As String = ""
    Public Property CLCLOR_S() As String
        Get
            Return _CLCLOR_S
        End Get
        Set(ByVal value As String)
            _CLCLOR_S = value
        End Set
    End Property

    Private _CLCLDS As Decimal = 0D
    Public Property CLCLDS() As Decimal
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Decimal)
            _CLCLDS = value
        End Set
    End Property

    Private _CLCLDS_S As String = ""
    Public Property CLCLDS_S() As String
        Get
            Return _CLCLDS_S
        End Get
        Set(ByVal value As String)
            _CLCLDS_S = value
        End Set
    End Property

    Private _TDRCOR As String = ""
    Public Property TDRCOR() As String
        Get
            Return _TDRCOR
        End Get
        Set(ByVal value As String)
            _TDRCOR = value
        End Set
    End Property

    Private _TDRENT As String = ""
    Public Property TDRENT() As String
        Get
            Return _TDRENT
        End Get
        Set(ByVal value As String)
            _TDRENT = value
        End Set
    End Property

    Private _NCSOTR As Decimal = 0D
    Public Property NCSOTR() As Decimal
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As Decimal)
            _NCSOTR = value
        End Set
    End Property

    Private _NUMREQT_LIST As String = ""
    Public Property NUMREQT_LIST() As String
        Get
            Return _NUMREQT_LIST
        End Get
        Set(ByVal value As String)
            _NUMREQT_LIST = value
        End Set
    End Property

    Private _QSLCIT As Decimal = 0D '15 , 5  cantidad
    Public Property QSLCIT() As Decimal
        Get
            Return _QSLCIT
        End Get
        Set(ByVal value As Decimal)
            _QSLCIT = value
        End Set
    End Property

    Private _CMEDTR As Decimal = 0D '2
    Public Property CMEDTR() As Decimal
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As Decimal)
            _CMEDTR = value
        End Set
    End Property

    Private _CUNDVH As Decimal = 0D '2 TIPO VEHICULO
    Public Property CUNDVH() As Decimal
        Get
            Return _CUNDVH
        End Get
        Set(ByVal value As Decimal)
            _CUNDVH = value
        End Set
    End Property

    Private _CUNDVH_D As String = "" '2 TIPO VEHICULO STRING
    Public Property CUNDVH_D() As String
        Get
            Return _CUNDVH_D
        End Get
        Set(ByVal value As String)
            _CUNDVH_D = value
        End Set
    End Property


    Private _CUNDMD As String = "" '3 TIPO UNID MEDIDA
    Public Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property


    Private _CMRCDR As Decimal '5  COD MERCADERIA
    Public Property CMRCDR() As Decimal
        Get
            Return _CMRCDR
        End Get
        Set(ByVal value As Decimal)
            _CMRCDR = value
        End Set
    End Property

    Private _CMRCDR_D As String = "" '5  COD MERCADERIA STRING
    Public Property CMRCDR_D() As String
        Get
            Return _CMRCDR_D
        End Get
        Set(ByVal value As String)
            _CMRCDR_D = value
        End Set
    End Property

    Private _CTPOSR As String = "" '  TIPO SERVICIO
    Public Property CTPOSR() As String
        Get
            Return _CTPOSR
        End Get
        Set(ByVal value As String)
            _CTPOSR = value
        End Set
    End Property


    Private _CUBORI As Decimal = 0D ' 6 COD UBIGEO_ORIGEN
    Public Property CUBORI() As Decimal
        Get
            Return _CUBORI
        End Get
        Set(ByVal value As Decimal)
            _CUBORI = value
        End Set
    End Property

    Private _CUBORI_S As String = "" ' 6  UBIGEO_ORIGEN
    Public Property CUBORI_S() As String
        Get
            Return _CUBORI_S
        End Get
        Set(ByVal value As String)
            _CUBORI_S = value
        End Set
    End Property

    Private _CUBDES As Decimal = 0D ' 6 COD UBIGEO_DESTINO
    Public Property CUBDES() As Decimal
        Get
            Return _CUBDES
        End Get
        Set(ByVal value As Decimal)
            _CUBDES = value
        End Set
    End Property

    Private _CUBDES_S As String = "" ' 6  UBIGEO_DESTINO
    Public Property CUBDES_S() As String
        Get
            Return _CUBDES_S
        End Get
        Set(ByVal value As String)
            _CUBDES_S = value
        End Set
    End Property

    Private _NSECREV As Decimal = 0D
    Public Property NSECREV() As Decimal
        Get
            Return _NSECREV
        End Get
        Set(ByVal value As Decimal)
            _NSECREV = value
        End Set
    End Property

    Private _FSECREV As Decimal = 0D
    Public Property FSECREV() As Decimal
        Get
            Return _FSECREV
        End Get
        Set(ByVal value As Decimal)
            _FSECREV = value
        End Set
    End Property

    Private _FSECREV_D As String = ""
    Public Property FSECREV_D() As String
        Get
            Return _FSECREV_D
        End Get
        Set(ByVal value As String)
            _FSECREV_D = value
        End Set
    End Property

    Private _PNCDTR As String = ""
    Public Property PNCDTR() As String
        Get
            Return _PNCDTR
        End Get
        Set(ByVal value As String)
            _PNCDTR = value
        End Set
    End Property

    Private _NPLNJT As Decimal = 0D
    Public Property NPLNJT() As Decimal
        Get
            Return _NPLNJT
        End Get
        Set(ByVal value As Decimal)
            _NPLNJT = value
        End Set
    End Property

    Private _NCRRPL As Decimal = 0D
    Public Property NCRRPL() As Decimal
        Get
            Return _NCRRPL
        End Get
        Set(ByVal value As Decimal)
            _NCRRPL = value
        End Set
    End Property


    Private _QUNIDJUNTA As Decimal = 0D
    Public Property QUNIDJUNTA() As Decimal
        Get
            Return _QUNIDJUNTA
        End Get
        Set(ByVal value As Decimal)
            _QUNIDJUNTA = value
        End Set
    End Property

    Private _QUNIDSOLICITADAS As Decimal = 0D
    Public Property QUNIDSOLICITADAS() As Decimal
        Get
            Return _QUNIDSOLICITADAS
        End Get
        Set(ByVal value As Decimal)
            _QUNIDSOLICITADAS = value
        End Set
    End Property

    Private _NOPRCN As Decimal = 0D
    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property


    Private _FCHATN As Decimal = 0D
    Public Property FCHATN() As Decimal
        Get
            Return _FCHATN
        End Get
        Set(ByVal value As Decimal)
            _FCHATN = value
        End Set
    End Property


    Private _FCHATN_D As String = ""
    Public Property FCHATN_D() As String
        Get
            Return _FCHATN_D
        End Get
        Set(ByVal value As String)
            _FCHATN_D = value
        End Set
    End Property

    Private _FCHATN_INI As Decimal = 0D
    Public Property FCHATN_INI() As Decimal
        Get
            Return _FCHATN_INI
        End Get
        Set(ByVal value As Decimal)
            _FCHATN_INI = value
        End Set
    End Property

    Private _FCHATN_FIN As Decimal = 0D
    Public Property FCHATN_FIN() As Decimal
        Get
            Return _FCHATN_FIN
        End Get
        Set(ByVal value As Decimal)
            _FCHATN_FIN = value
        End Set
    End Property


    Private _HRAATN As Decimal = 0D
    Public Property HRAATN() As Decimal
        Get
            Return _HRAATN
        End Get
        Set(ByVal value As Decimal)
            _HRAATN = value
        End Set
    End Property


    Private _HRAATN_D As String = ""
    Public Property HRAATN_D() As String
        Get
            Return _HRAATN_D
        End Get
        Set(ByVal value As String)
            _HRAATN_D = value
        End Set
    End Property

    Private _HRAATN_INI As Decimal = 0D
    Public Property HRAATN_INI() As Decimal
        Get
            Return _HRAATN_INI
        End Get
        Set(ByVal value As Decimal)
            _HRAATN_INI = value
        End Set
    End Property

    Private _HRAATN_FIN As Decimal = 0D
    Public Property HRAATN_FIN() As Decimal
        Get
            Return _HRAATN_FIN
        End Get
        Set(ByVal value As Decimal)
            _HRAATN_FIN = value
        End Set
    End Property

    Private _TOBERV As String = ""
    Public Property TOBERV() As String
        Get
            Return _TOBERV
        End Get
        Set(ByVal value As String)
            _TOBERV = value
        End Set
    End Property

    Private _PRSCNT As String = ""
    Public Property PRSCNT() As String
        Get
            Return _PRSCNT
        End Get
        Set(ByVal value As String)
            _PRSCNT = value
        End Set
    End Property

    Private _QMRCDR As Decimal = 0D
    Public Property QMRCDR() As Decimal
        Get
            Return _QMRCDR
        End Get
        Set(ByVal value As Decimal)
            _QMRCDR = value
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


    Private _TCRVTA As String = ""
    Public Property TCRVTA() As String
        Get
            Return _TCRVTA
        End Get
        Set(ByVal value As String)
            _TCRVTA = value
        End Set
    End Property

    Private _TIRALC As String = ""
    Public Property TIRALC() As String
        Get
            Return _TIRALC
        End Get
        Set(ByVal value As String)
            _TIRALC = value
        End Set
    End Property


    Private _TIPPROC As String = ""
    Public Property TIPPROC() As String
        Get
            Return _TIPPROC
        End Get
        Set(ByVal value As String)
            _TIPPROC = value
        End Set
    End Property


    Private _DIMENSIONES As Decimal = 0D
    Public Property DIMENSIONES() As Decimal
        Get
            Return _DIMENSIONES
        End Get
        Set(ByVal value As Decimal)
            _DIMENSIONES = value
        End Set
    End Property


    Private _TNMMDT As String = ""
    Public Property TNMMDT() As String
        Get
            Return _TNMMDT
        End Get
        Set(ByVal value As String)
            _TNMMDT = value
        End Set
    End Property


    Private _CCLNFC As Decimal = 0D
    Public Property CCLNFC() As Decimal
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Decimal)
            _CCLNFC = value
        End Set
    End Property


    Private _CCLNFC_S As String = ""
    Public Property CCLNFC_S() As String
        Get
            Return _CCLNFC_S
        End Get
        Set(ByVal value As String)
            _CCLNFC_S = value
        End Set
    End Property

    Private _SJTTR As String = ""
    Public Property SJTTR() As String
        Get
            Return _SJTTR
        End Get
        Set(ByVal value As String)
            _SJTTR = value
        End Set
    End Property


    Private _QUNIDATENDIDAS As Decimal = 0
    Public Property QUNIDATENDIDAS() As Decimal
        Get
            Return _QUNIDATENDIDAS
        End Get
        Set(ByVal value As Decimal)
            _QUNIDATENDIDAS = value
        End Set
    End Property

    Private _NROENV As Decimal = 0
    Public Property NROENV() As Decimal
        Get
            Return _NROENV
        End Get
        Set(ByVal value As Decimal)
            _NROENV = value
        End Set
    End Property

    Private _SOLICT As Decimal = 0
    Public Property SOLICT() As Decimal
        Get
            Return _SOLICT
        End Get
        Set(ByVal value As Decimal)
            If _SOLICT = Value Then
                Return
            End If
            _SOLICT = Value
        End Set
    End Property

    Private _CUSOSAR As String = ""
    Public Property CUSOSAR() As String
        Get
            Return _CUSOSAR
        End Get
        Set(ByVal value As String)
            If _CUSOSAR = value Then
                Return
            End If
            _CUSOSAR = value
        End Set
    End Property

    Private _NORSRTSR As Decimal = 0D
    Public Property NORSRTSR() As Decimal
        Get
            Return _NORSRTSR
        End Get
        Set(ByVal value As Decimal)
            _NORSRTSR = value
        End Set
    End Property

    Private _CLCLORSR As Decimal = 0D
    Public Property CLCLORSR() As Decimal
        Get
            Return _CLCLORSR
        End Get
        Set(ByVal value As Decimal)
            _CLCLORSR = value
        End Set
    End Property

    Private _CLCLORSR_S As String = ""
    Public Property CLCLORSR_S() As String
        Get
            Return _CLCLORSR_S
        End Get
        Set(ByVal value As String)
            _CLCLORSR_S = value
        End Set
    End Property

    Private _CLCLDSSR As Decimal = 0D
    Public Property CLCLDSSR() As Decimal
        Get
            Return _CLCLDSSR
        End Get
        Set(ByVal value As Decimal)
            _CLCLDSSR = value
        End Set
    End Property

    Private _CLCLDSSR_S As String = ""
    Public Property CLCLDSSR_S() As String
        Get
            Return _CLCLDSSR_S
        End Get
        Set(ByVal value As String)
            _CLCLDSSR_S = value
        End Set
    End Property

    Private _NDCORMSR As Decimal = 0D
    Public Property NDCORMSR() As Decimal
        Get
            Return _NDCORMSR
        End Get
        Set(ByVal value As Decimal)
            _NDCORMSR = value
        End Set
    End Property

    Private _PNCDTRSR As String = ""
    Public Property PNCDTRSR() As String
        Get
            Return _PNCDTRSR
        End Get
        Set(ByVal value As String)
            _PNCDTRSR = value
        End Set
    End Property

End Class
