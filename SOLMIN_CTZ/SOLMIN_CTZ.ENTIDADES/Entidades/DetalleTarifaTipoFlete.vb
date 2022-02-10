Public Class DetalleTarifaTipoFlete

    Inherits Base(Of DetalleTarifaTipoFlete)


    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

#Region "Atributos"
    Private _CCMPN As String
    Private _NRCTSL As Decimal 
    Private _NRTFSV As Decimal
    Private _NCRRSR As Decimal
    Private _TOBSSR As String
    Private _CUBORI As Decimal
    Private _CLCLOR As Decimal
    Private _CUBDES As Decimal
    Private _CLCLDS As Decimal
    Private _ITRSRT As Decimal
    Private _CMNTRN As Decimal
    Private _CMNLQT As Decimal
    Private _ILSFTR As Decimal
    Private _ILCFTR As Decimal
    Private _ILQFMX As Decimal
    Private _ILQSMT As Decimal
    Private _CUNSRA As String 
    Private _QDSTVR As Decimal
    Private _SFCRTV As String
    Private _SSRVPG As String
    Private _SSRVCB As String
    Private _SSRVFE As String
    Private _CSTNDT As Decimal
    Private _FULTAC As Decimal
    Private _HULTAC As Decimal
    Private _CULUSA As String 
    Private _NTRMNL As String
    Private _CUSCRT As String
    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _NTRMCR As String 
    Private _ORIGEN As String
    Private _DESTINO As String
    Private _MONEDA As String
    Private _UBIGEO_O As String 
    Private _UBIGEO_D As String
    Private _FLAG As Decimal
    Private _SESTRG As String
    Private _MONEDA_COBRAR As String
    Private _MONEDA_PAGAR As String
    Private _CSRCTZ As Decimal
    Private _SNTVJE As String = ""
    Private _SNTVJE_DESC As String = ""
    Private _ESTADO_ITEM As String = ""
    Private _COD_ESTADO As String = ""

#End Region

#Region "Properties"


    Private _QIMPIN As Decimal
    Public Property QIMPIN() As Decimal
        Get
            Return _QIMPIN
        End Get
        Set(ByVal value As Decimal)
            _QIMPIN = value
        End Set
    End Property


    Private _QIMPFN As Decimal
    Public Property QIMPFN() As Decimal
        Get
            Return _QIMPFN
        End Get
        Set(ByVal value As Decimal)
            _QIMPFN = value
        End Set
    End Property


    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            If _CCMPN = value Then
                Return
            End If
            _CCMPN = value
        End Set
    End Property
    Public Property NRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            If _NRCTSL = value Then
                Return
            End If
            _NRCTSL = value
        End Set
    End Property
    Public Property NRTFSV() As Decimal
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Decimal)
            If _NRTFSV = value Then
                Return
            End If
            _NRTFSV = value
        End Set
    End Property
    Public Property NCRRSR() As Decimal
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Decimal)
            If _NCRRSR = value Then
                Return
            End If
            _NCRRSR = value
        End Set
    End Property
    Public Property TOBSSR() As String
        Get
            Return _TOBSSR
        End Get
        Set(ByVal value As String)
            If _TOBSSR = value Then
                Return
            End If
            _TOBSSR = value
        End Set
    End Property
    Public Property CUBORI() As Decimal
        Get
            Return _CUBORI
        End Get
        Set(ByVal value As Decimal)
            If _CUBORI = value Then
                Return
            End If
            _CUBORI = value
        End Set
    End Property
    Public Property CLCLOR() As Decimal
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Decimal)
            If _CLCLOR = value Then
                Return
            End If
            _CLCLOR = value
        End Set
    End Property
    Public Property CUBDES() As Decimal
        Get
            Return _CUBDES
        End Get
        Set(ByVal value As Decimal)
            If _CUBDES = value Then
                Return
            End If
            _CUBDES = value
        End Set
    End Property
    Public Property CLCLDS() As Decimal
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Decimal)
            If _CLCLDS = value Then
                Return
            End If
            _CLCLDS = value
        End Set
    End Property
    Public Property ITRSRT() As Decimal
        Get
            Return _ITRSRT
        End Get
        Set(ByVal value As Decimal)
            If _ITRSRT = value Then
                Return
            End If
            _ITRSRT = value
        End Set
    End Property
    Public Property CMNTRN() As Decimal
        Get
            Return _CMNTRN
        End Get
        Set(ByVal value As Decimal)
            If _CMNTRN = value Then
                Return
            End If
            _CMNTRN = value
        End Set
    End Property
    Public Property CMNLQT() As Decimal
        Get
            Return _CMNLQT
        End Get
        Set(ByVal value As Decimal)
            If _CMNLQT = value Then
                Return
            End If
            _CMNLQT = value
        End Set
    End Property
    Public Property ILSFTR() As Decimal
        Get
            Return _ILSFTR
        End Get
        Set(ByVal value As Decimal)
            If _ILSFTR = value Then
                Return
            End If
            _ILSFTR = value
        End Set
    End Property
    Public Property ILCFTR() As Decimal
        Get
            Return _ILCFTR
        End Get
        Set(ByVal value As Decimal)
            If _ILCFTR = value Then
                Return
            End If
            _ILCFTR = value
        End Set
    End Property
    Public Property ILQFMX() As Decimal
        Get
            Return _ILQFMX
        End Get
        Set(ByVal value As Decimal)
            If _ILQFMX = value Then
                Return
            End If
            _ILQFMX = value
        End Set
    End Property
    Public Property ILQSMT() As Decimal
        Get
            Return _ILQSMT
        End Get
        Set(ByVal value As Decimal)
            If _ILQSMT = value Then
                Return
            End If
            _ILQSMT = value
        End Set
    End Property
    Public Property CUNSRA() As String
        Get
            Return _CUNSRA
        End Get
        Set(ByVal value As String)
            If _CUNSRA = value Then
                Return
            End If
            _CUNSRA = value
        End Set
    End Property
    Public Property QDSTVR() As Decimal
        Get
            Return _QDSTVR
        End Get
        Set(ByVal value As Decimal)
            If _QDSTVR = value Then
                Return
            End If
            _QDSTVR = value
        End Set
    End Property
    Public Property SFCRTV() As String
        Get
            Return _SFCRTV
        End Get
        Set(ByVal value As String)
            If _SFCRTV = value Then
                Return
            End If
            _SFCRTV = value
        End Set
    End Property
    Public Property SSRVPG() As String
        Get
            Return _SSRVPG
        End Get
        Set(ByVal value As String)
            If _SSRVPG = value Then
                Return
            End If
            _SSRVPG = value
        End Set
    End Property
    Public Property SSRVCB() As String
        Get
            Return _SSRVCB
        End Get
        Set(ByVal value As String)
            If _SSRVCB = value Then
                Return
            End If
            _SSRVCB = value
        End Set
    End Property
    Public Property SSRVFE() As String
        Get
            Return _SSRVFE
        End Get
        Set(ByVal value As String)
            If _SSRVFE = value Then
                Return
            End If
            _SSRVFE = value
        End Set
    End Property
    Public Property CSTNDT() As Decimal
        Get
            Return _CSTNDT
        End Get
        Set(ByVal value As Decimal)
            If _CSTNDT = value Then
                Return
            End If
            _CSTNDT = value
        End Set
    End Property
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            If _FULTAC = value Then
                Return
            End If
            _FULTAC = value
        End Set
    End Property
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            If _HULTAC = value Then
                Return
            End If
            _HULTAC = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            If _CULUSA = value Then
                Return
            End If
            _CULUSA = value
        End Set
    End Property
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            If _NTRMNL = value Then
                Return
            End If
            _NTRMNL = value
        End Set
    End Property
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            If _CUSCRT = value Then
                Return
            End If
            _CUSCRT = value
        End Set
    End Property
    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            If _FCHCRT = value Then
                Return
            End If
            _FCHCRT = value
        End Set
    End Property
    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            If _HRACRT = value Then
                Return
            End If
            _HRACRT = value
        End Set
    End Property
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            If _NTRMCR = value Then
                Return
            End If
            _NTRMCR = value
        End Set
    End Property

    Public Property ORIGEN() As String
        Get
            Return _ORIGEN
        End Get
        Set(ByVal value As String)
            If _ORIGEN = value Then
                Return
            End If
            _ORIGEN = value
        End Set
    End Property
    Public Property DESTINO() As String
        Get
            Return _DESTINO
        End Get
        Set(ByVal value As String)
            If _DESTINO = value Then
                Return
            End If
            _DESTINO = value
        End Set
    End Property
    Public Property MONEDA() As String
        Get
            Return _MONEDA
        End Get
        Set(ByVal value As String)
            If _MONEDA = value Then
                Return
            End If
            _MONEDA = value
        End Set
    End Property
    Public Property UBIGEO_O() As String
        Get
            Return _UBIGEO_O
        End Get
        Set(ByVal value As String)
            If _UBIGEO_O = value Then
                Return
            End If
            _UBIGEO_O = value
        End Set
    End Property
    Public Property UBIGEO_D() As String
        Get
            Return _UBIGEO_D
        End Get
        Set(ByVal value As String)
            If _UBIGEO_D = value Then
                Return
            End If
            _UBIGEO_D = value
        End Set
    End Property

    Public Property FLAG() As Decimal
        Get
            Return _FLAG
        End Get
        Set(ByVal value As Decimal)
            If _FLAG = value Then
                Return
            End If
            _FLAG = value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            If _SESTRG = value Then
                Return
            End If
            _SESTRG = value
        End Set
    End Property

    Public Property MONEDA_COBRAR() As String
        Get
            Return _MONEDA_COBRAR
        End Get
        Set(ByVal value As String)
            If _MONEDA_COBRAR = value Then
                Return
            End If
            _MONEDA_COBRAR = value
        End Set
    End Property
    Public Property MONEDA_PAGAR() As String
        Get
            Return _MONEDA_PAGAR
        End Get
        Set(ByVal value As String)
            If _MONEDA_PAGAR = value Then
                Return
            End If
            _MONEDA_PAGAR = value
        End Set
    End Property

    Public Property CSRCTZ() As Decimal
        Get
            Return _CSRCTZ
        End Get
        Set(ByVal value As Decimal)
            If _CSRCTZ = value Then
                Return
            End If
            _CSRCTZ = value
        End Set
    End Property



    Private _ITRAPG As Decimal
    Public Property ITRAPG() As Decimal
        Get
            Return _ITRAPG
        End Get
        Set(ByVal value As Decimal)
            _ITRAPG = value
        End Set
    End Property


    Private _NSEQIN As Decimal
    Public Property NSEQIN() As Decimal
        Get
            Return _NSEQIN
        End Get
        Set(ByVal value As Decimal)
            _NSEQIN = value
        End Set
    End Property





    Public ReadOnly Property Retorno() As String
        Get
      
            If _SFCRTV = "I" Then
                Return "Si"
            Else
                Return "No"
            End If
        End Get

    End Property

    Public ReadOnly Property TipoServicio() As String
        Get

            If _SFCRTV = "F" Then
                Return "Fijo"
            Else
                Return "Eventual"
            End If
        End Get

    End Property

    Private _RangoTarifa As List(Of RangoTarifaXTarifaFlete)

    Public Property RangoTarifa() As List(Of RangoTarifaXTarifaFlete)
        Get
            Return _RangoTarifa
        End Get
        Set(ByVal value As List(Of RangoTarifaXTarifaFlete))
            _RangoTarifa = value
        End Set
    End Property

    'RCS-HUNDRED-INICIO
    Private _CMNDTI As Decimal
    Private _MONEDA_TARINT As String
    Private _ISRVTI As Decimal

    Public Property CMNDTI() As Decimal
        Get
            Return _CMNDTI
        End Get
        Set(ByVal value As Decimal)
            _CMNDTI = value
        End Set
    End Property

    Public Property MONEDA_TARINT() As String
        Get
            Return _MONEDA_TARINT
        End Get
        Set(ByVal value As String)
            _MONEDA_TARINT = value
        End Set
    End Property

    Public Property ISRVTI() As Decimal
        Get
            Return _ISRVTI
        End Get
        Set(ByVal value As Decimal)
            _ISRVTI = value
        End Set
    End Property
    'RCS-HUNDRED-FIN

    Public Property SNTVJE() As String
        Get
            Return _SNTVJE
        End Get
        Set(ByVal value As String)
            _SNTVJE = value
        End Set
    End Property
    Public Property SNTVJE_DESC() As String
        Get
            Return _SNTVJE_DESC
        End Get
        Set(ByVal value As String)
            _SNTVJE_DESC = value
        End Set
    End Property

    Public Property ESTADO_ITEM() As String
        Get
            Return _ESTADO_ITEM
        End Get
        Set(ByVal value As String)
            _ESTADO_ITEM = value
        End Set
    End Property
    Public Property COD_ESTADO() As String
        Get
            Return _COD_ESTADO
        End Get
        Set(ByVal value As String)
            _COD_ESTADO = value
        End Set
    End Property

 

#End Region


End Class
