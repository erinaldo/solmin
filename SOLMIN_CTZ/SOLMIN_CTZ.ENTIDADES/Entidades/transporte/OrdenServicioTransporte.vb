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
        ''' <summary>
        ''' Modificación para poder generar una OS por detalle de Cotizacion
        ''' </summary>
        ''' <remarks>
        ''' Modify by: Hugo Pérez Ryan
        ''' Date     : 21/02/2012
        ''' </remarks>
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

    End Class

End Namespace