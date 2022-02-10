Namespace Operaciones

    Public Class OrdenServicioTransporte

        Private _NORSRT As String = ""
        Private _NDCMRF As String = ""
        Private _CMRCDR As String = ""
        Private _QMRCDR As String = ""
        Private _PMRCDR As String = ""
        Private _VMRCDR As String = ""
        Private _LMRCDR As String = ""
        Private _CTPOSR As String = ""
        Private _CTPSBS As String = ""
        Private _TRFMRC As String = ""
        Private _CUNDMD As String = ""
        Private _NPTSCR As String = ""
        Private _NPTSDS As String = ""
        Private _CCLNT As String = ""
        Private _CCMPN As String = ""
        Private _CDVSN As String = ""
        Private _CPLNDV As String = ""
        Private _FULTAC As String = ""
        Private _HULTAC As String = ""
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As String = ""
        Private _HRACRT As String = ""
        Private _NTRMCR As String = ""
        Private _SESTOS As String = ""
        Private _CCLNFC As String = ""
        Private _SSCGST As String = ""
        Private _CCNCST As String = ""
        Private _CLCLDS As String = ""
        Private _CLCLOR As String = ""
        Private _PNTORG As String = ""
        Private _TIPSRV As String = ""
        Private _CODMER As String = ""
        Private _PNTDES As String = ""
        Private _NCTZCN As Double = 0
        Private _CTPUNV As String
        Private _NOPRCN As String = ""
        Private _RUTA As String = ""
        Private _NCRRSR As Int32 = 0

        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Private _PLANTA As String = ""
        Private _PLANTA_FACT As String = ""
        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        Private _CCNCS1 As Decimal = 0


        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        Private _MONCOBRO As String = ""
        Private _MONPAGO As String = ""
        '----- Fin -----
        Private _COD_SNT_VJE As String = ""


        Private _TARIFA_COBRO As Decimal = 0
        Private _TARIFA_PAGO As Decimal = 0

        Private _PARAM_COBRO As String = ""
        Private _PARAM_PAGO As String = ""

        Private _DES_MERCADERIA As String = ""


        Private _TCMLCL_O As String = ""
        Private _TCMLCL_D As String = ""
        'CCNCS1
        ''' <summary>
        ''' Modificación para poder generar una OS por detalle de Cotizacion
        ''' </summary>
        ''' <remarks>
        ''' Modify by: Hugo Pérez Ryan
        ''' Date     : 21/02/2012
        ''' </remarks>
        '''

        Private _CUBORI As Decimal = 0D
        Public Property CUBORI() As Decimal
            Get
                Return _CUBORI
            End Get
            Set(ByVal value As Decimal)
                _CUBORI = value
            End Set
        End Property

        Private _CUBDES As Decimal = 0D
        Public Property CUBDES() As Decimal
            Get
                Return _CUBDES
            End Get
            Set(ByVal value As Decimal)
                _CUBDES = value
            End Set
        End Property

        Private _UBIGEO_O As String
        Public Property UBIGEO_O() As String
            Get
                Return _UBIGEO_O
            End Get
            Set(ByVal value As String)
                _UBIGEO_O = value
            End Set
        End Property

        Private _UBIGEO_D As String
        Public Property UBIGEO_D() As String
            Get
                Return _UBIGEO_D
            End Get
            Set(ByVal value As String)
                _UBIGEO_D = value
            End Set
        End Property



        Private _NCRRCT As Int32 = 0
        Public Property CTPUNV() As String
            Get
                Return _CTPUNV
            End Get
            Set(ByVal value As String)
                _CTPUNV = value
            End Set
        End Property

        Public Property NCTZCN() As Double
            Get
                Return _NCTZCN
            End Get
            Set(ByVal value As Double)
                _NCTZCN = value
            End Set
        End Property


        Public Property CCNCST() As Double
            Get
                Return _CCNCST
            End Get
            Set(ByVal value As Double)
                _CCNCST = value
            End Set
        End Property


        Public Property CLCLDS() As String
            Get
                Return _CLCLDS
            End Get
            Set(ByVal value As String)
                _CLCLDS = value
            End Set
        End Property

        Public Property CLCLOR() As String
            Get
                Return _CLCLOR
            End Get
            Set(ByVal value As String)
                _CLCLOR = value
            End Set
        End Property

        Public Property NORSRT() As String
            Get
                Return _NORSRT
            End Get
            Set(ByVal value As String)
                _NORSRT = value
            End Set
        End Property

        Public Property NDCMRF() As String
            Get
                Return _NDCMRF
            End Get
            Set(ByVal value As String)
                _NDCMRF = value
            End Set
        End Property

        Public Property CMRCDR() As String
            Get
                Return _CMRCDR
            End Get
            Set(ByVal value As String)
                _CMRCDR = value
            End Set
        End Property

        Public Property QMRCDR() As String
            Get
                Return _QMRCDR
            End Get
            Set(ByVal value As String)
                _QMRCDR = value
            End Set
        End Property

        Public Property PMRCDR() As String
            Get
                Return _PMRCDR
            End Get
            Set(ByVal value As String)
                _PMRCDR = value
            End Set
        End Property

        Public Property VMRCDR() As String
            Get
                Return _VMRCDR
            End Get
            Set(ByVal value As String)
                _VMRCDR = value
            End Set
        End Property

        Public Property LMRCDR() As String
            Get
                Return _LMRCDR
            End Get
            Set(ByVal value As String)
                _LMRCDR = value
            End Set
        End Property

        Public Property CTPOSR() As String
            Get
                Return _CTPOSR
            End Get
            Set(ByVal value As String)
                _CTPOSR = value
            End Set
        End Property

        Public Property CTPSBS() As String
            Get
                Return _CTPSBS
            End Get
            Set(ByVal value As String)
                _CTPSBS = value
            End Set
        End Property

        Public Property TRFMRC() As String
            Get
                Return _TRFMRC
            End Get
            Set(ByVal value As String)
                _TRFMRC = value
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

        Public Property NPTSCR() As String
            Get
                Return _NPTSCR
            End Get
            Set(ByVal value As String)
                _NPTSCR = value
            End Set
        End Property

        Public Property NPTSDS() As String
            Get
                Return _NPTSDS
            End Get
            Set(ByVal value As String)
                _NPTSDS = value
            End Set
        End Property

        Public Property CCLNT() As String
            Get
                Return _CCLNT
            End Get
            Set(ByVal value As String)
                _CCLNT = value
            End Set
        End Property

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
            End Set
        End Property

        Public Property CPLNDV() As String
            Get
                Return _CPLNDV
            End Get
            Set(ByVal value As String)
                _CPLNDV = value
            End Set
        End Property

        Public Property FULTAC() As String
            Get
                Return _FULTAC
            End Get
            Set(ByVal value As String)
                _FULTAC = value
            End Set
        End Property

        Public Property HULTAC() As String
            Get
                Return _HULTAC
            End Get
            Set(ByVal value As String)
                _HULTAC = value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal value As String)
                _CULUSA = value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal value As String)
                _NTRMNL = value
            End Set
        End Property

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal value As String)
                _CUSCRT = value
            End Set
        End Property

        Public Property FCHCRT() As String
            Get
                Return _FCHCRT
            End Get
            Set(ByVal value As String)
                _FCHCRT = value
            End Set
        End Property

        Public Property HRACRT() As String
            Get
                Return _HRACRT
            End Get
            Set(ByVal value As String)
                _HRACRT = value
            End Set
        End Property

        Public Property NTRMCR() As String
            Get
                Return _NTRMCR
            End Get
            Set(ByVal value As String)
                _NTRMCR = value
            End Set
        End Property

        Public Property SESTOS() As String
            Get
                Return _SESTOS
            End Get
            Set(ByVal value As String)
                _SESTOS = value
            End Set
        End Property

        Public Property CCLNFC() As String
            Get
                Return _CCLNFC
            End Get
            Set(ByVal value As String)
                _CCLNFC = value
            End Set
        End Property

        Public Property SSCGST() As String
            Get
                Return _SSCGST
            End Get
            Set(ByVal value As String)
                _SSCGST = value
            End Set
        End Property

        Public Property PNTORG() As String
            Get
                Return _PNTORG
            End Get
            Set(ByVal value As String)
                _PNTORG = value
            End Set
        End Property

        Public Property TIPSRV() As String
            Get
                Return _TIPSRV
            End Get
            Set(ByVal value As String)
                _TIPSRV = value
            End Set
        End Property

        Public Property PNTDES() As String
            Get
                Return _PNTDES
            End Get
            Set(ByVal value As String)
                _PNTDES = value
            End Set
        End Property

        Public Property CODMER() As String
            Get
                Return _CODMER
            End Get
            Set(ByVal value As String)
                _CODMER = value
            End Set
        End Property

        Public Property NOPRCN() As String
            Get
                Return _NOPRCN
            End Get
            Set(ByVal value As String)
                _NOPRCN = value
            End Set
        End Property

        Public Property RUTA() As String
            Get
                Return _RUTA
            End Get
            Set(ByVal value As String)
                _RUTA = value
            End Set
        End Property

        Public Property NCRRSR() As Int32
            Get
                Return _NCRRSR
            End Get
            Set(ByVal value As Int32)
                _NCRRSR = value
            End Set
        End Property

        ''' <summary>
        ''' Modificación para poder generar una OS por detalle de Cotizacion
        ''' </summary>
        ''' <remarks>
        ''' Modify by: Hugo Pérez Ryan
        ''' Date     : 21/02/2012
        ''' </remarks>
        Public Property NCRRCT() As Int32
            Get
                Return _NCRRCT
            End Get
            Set(ByVal value As Int32)
                _NCRRCT = value
            End Set
        End Property

        Public Property CCNCS1() As Decimal
            Get
                Return _CCNCS1
            End Get
            Set(ByVal value As Decimal)
                _CCNCS1 = value
            End Set
        End Property


        Private _NRCTSL As Decimal = 0
        Public Property NRCTSL() As Decimal
            Get
                Return _NRCTSL
            End Get
            Set(ByVal value As Decimal)
                _NRCTSL = value
            End Set
        End Property

        Private _NRTFSV As Decimal = 0
        Public Property NRTFSV() As Decimal
            Get
                Return _NRTFSV
            End Get
            Set(ByVal value As Decimal)
                _NRTFSV = value
            End Set
        End Property


        Private _NLQDCN As Decimal
        Public Property NLQDCN() As Decimal
            Get
                Return _NLQDCN
            End Get
            Set(ByVal value As Decimal)
                _NLQDCN = value
            End Set
        End Property


        Private _TIPO As Integer
        Public Property TIPO() As Integer
            Get
                Return _TIPO
            End Get
            Set(ByVal value As Integer)
                _TIPO = value
            End Set
        End Property

        REM ECM-HUNDRED-INICIO
        Private _TDSCSP As String 'Sector OP
        Public Property TDSCSP() As String
            Get
                Return _TDSCSP
            End Get
            Set(ByVal value As String)
                _TDSCSP = value
            End Set
        End Property

        Private _CCLNT_COD As String 'Código Cliente
        Public Property CCLNT_COD() As String
            Get
                Return _CCLNT_COD
            End Get
            Set(ByVal value As String)
                _CCLNT_COD = value
            End Set
        End Property

        Private _TDSCSP_FACT As String 'Sector Fact
        Public Property TDSCSP_FACT() As String
            Get
                Return _TDSCSP_FACT
            End Get
            Set(ByVal value As String)
                _TDSCSP_FACT = value
            End Set
        End Property

        Private _CLIENT_FACT As String 'Cliente Fact
        Public Property CLIENT_FACT() As String
            Get
                Return _CLIENT_FACT
            End Get
            Set(ByVal value As String)
                _CLIENT_FACT = value
            End Set
        End Property
        REM ECM-HUNDRED-FIN


        REM CAMBIOS EN DEF-SALMON FASE-2 -INICIO
        Private _CTTRAN As String
        Public Property CTTRAN() As String
            Get
                Return _CTTRAN
            End Get
            Set(ByVal value As String)
                _CTTRAN = value
            End Set
        End Property


        Private _CTIPCG As String
        Public Property CTIPCG() As String
            Get
                Return _CTIPCG
            End Get
            Set(ByVal value As String)
                _CTIPCG = value
            End Set
        End Property


        Private _COD_CEBEDP As String
        Public Property COD_CEBEDP() As String
            Get
                Return _COD_CEBEDP
            End Get
            Set(ByVal value As String)
                _COD_CEBEDP = value
            End Set
        End Property


        Private _CODSAP_CEBEDP As String
        Public Property CODSAP_CEBEDP() As String
            Get
                Return _CODSAP_CEBEDP
            End Get
            Set(ByVal value As String)
                _CODSAP_CEBEDP = value
            End Set
        End Property


        Private _DESC_CEBEDP As String
        Public Property DESC_CEBEDP() As String
            Get
                Return _DESC_CEBEDP
            End Get
            Set(ByVal value As String)
                _DESC_CEBEDP = value
            End Set
        End Property


        Private _COD_CECODP As String
        Public Property COD_CECODP() As String
            Get
                Return _COD_CECODP
            End Get
            Set(ByVal value As String)
                _COD_CECODP = value
            End Set
        End Property


        Private _CODSAP_CECODP As String
        Public Property CODSAP_CECODP() As String
            Get
                Return _CODSAP_CECODP
            End Get
            Set(ByVal value As String)
                _CODSAP_CECODP = value
            End Set
        End Property


        Private _DESC_CECODP As String
        Public Property DESC_CECODP() As String
            Get
                Return _DESC_CECODP
            End Get
            Set(ByVal value As String)
                _DESC_CECODP = value
            End Set
        End Property


        Private _COD_CEBEDT As String
        Public Property COD_CEBEDT() As String
            Get
                Return _COD_CEBEDT
            End Get
            Set(ByVal value As String)
                _COD_CEBEDT = value
            End Set
        End Property


        Private _CODSAP_CEBEDT As String
        Public Property CODSAP_CEBEDT() As String
            Get
                Return _CODSAP_CEBEDT
            End Get
            Set(ByVal value As String)
                _CODSAP_CEBEDT = value
            End Set
        End Property


        Private _DESC_CEBEDT As String
        Public Property DESC_CEBEDT() As String
            Get
                Return _DESC_CEBEDT
            End Get
            Set(ByVal value As String)
                _DESC_CEBEDT = value
            End Set
        End Property


        Private _COD_CECODT As String
        Public Property COD_CECODT() As String
            Get
                Return _COD_CECODT
            End Get
            Set(ByVal value As String)
                _COD_CECODT = value
            End Set
        End Property


        Private _CODSAP_CECODT As String
        Public Property CODSAP_CECODT() As String
            Get
                Return _CODSAP_CECODT
            End Get
            Set(ByVal value As String)
                _CODSAP_CECODT = value
            End Set
        End Property


        Private _DESC_CECODT As String
        Public Property DESC_CECODT() As String
            Get
                Return _DESC_CECODT
            End Get
            Set(ByVal value As String)
                _DESC_CECODT = value
            End Set
        End Property


        REM CAMBIOS EN DEF-SALMON FASE-2 -FIN


        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Public Property PLANTA() As String
            Get
                Return _PLANTA
            End Get
            Set(ByVal value As String)
                _PLANTA = value
            End Set
        End Property

        Public Property PLANTA_FACT() As String
            Get
                Return _PLANTA_FACT
            End Get
            Set(ByVal value As String)
                _PLANTA_FACT = value
            End Set
        End Property
        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        Public Property MONCOBRO() As String
            Get
                Return _MONCOBRO
            End Get
            Set(ByVal value As String)
                _MONCOBRO = value
            End Set
        End Property

        Public Property MONPAGO() As String
            Get
                Return _MONPAGO
            End Get
            Set(ByVal value As String)
                _MONPAGO = value
            End Set
        End Property

        Public Property COD_SNT_VJE() As String
            Get
                Return _COD_SNT_VJE
            End Get
            Set(ByVal value As String)
                _COD_SNT_VJE = value
            End Set
        End Property

        Private _NGUITR As Decimal = 0
        Public Property NGUITR() As Decimal
            Get
                Return _NGUITR
            End Get
            Set(ByVal value As Decimal)
                _NGUITR = value
            End Set
        End Property

        Private _NGUIRM As Decimal = 0
        Public Property NGUIRM() As Decimal
            Get
                Return _NGUIRM
            End Get
            Set(ByVal value As Decimal)
                _NGUIRM = value
            End Set
        End Property

        'Private _PROCESO As Decimal = 0
        'Public Property PROCESO() As Decimal
        '    Get
        '        Return _PROCESO
        '    End Get
        '    Set(ByVal value As Decimal)
        '        _PROCESO = value
        '    End Set
        'End Property

        Private _PROCESO As String = ""
        Public Property PROCESO() As String
            Get
                Return _PROCESO
            End Get
            Set(ByVal value As String)
                _PROCESO = value
            End Set
        End Property
 
        Public Property TARIFA_COBRO() As Decimal
            Get
                Return _TARIFA_COBRO
            End Get
            Set(ByVal value As Decimal)
                _TARIFA_COBRO = value
            End Set
        End Property
        Public Property TARIFA_PAGO() As Decimal
            Get
                Return _TARIFA_PAGO
            End Get
            Set(ByVal value As Decimal)
                _TARIFA_PAGO = value
            End Set
        End Property
 

        Public Property PARAM_COBRO() As String
            Get
                Return _PARAM_COBRO
            End Get
            Set(ByVal value As String)
                _PARAM_COBRO = value
            End Set
        End Property
        Public Property PARAM_PAGO() As String
            Get
                Return _PARAM_PAGO
            End Get
            Set(ByVal value As String)
                _PARAM_PAGO = value
            End Set
        End Property

        Public Property DES_MERCADERIA() As String
            Get
                Return _DES_MERCADERIA
            End Get
            Set(ByVal value As String)
                _DES_MERCADERIA = value
            End Set
        End Property


        Public Property TCMLCL_O() As String
            Get
                Return _TCMLCL_O
            End Get
            Set(ByVal value As String)
                _TCMLCL_O = value
            End Set
        End Property
        Public Property TCMLCL_D() As String
            Get
                Return _TCMLCL_D
            End Get
            Set(ByVal value As String)
                _TCMLCL_D = value
            End Set
        End Property

       

        '----- Fin -----


    End Class

End Namespace
