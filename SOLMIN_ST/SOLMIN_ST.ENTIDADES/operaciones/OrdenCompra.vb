Namespace Operaciones
    Public Class OrdenCompra

#Region "Atributo"
        Private _CCLNT As String
        Private _SESTOP As String
        Private _NOPRCN As Double
        Private _FGUITR As String
        Private _FGUIRM As String
        Private _NPLVHT As String
        Private _NPLCAC As String
        Private _SINDRC As String

        Private _NGUIRM As Double
        Private _NGUITR As Double
        Private _FSLDCM As String
        Private _FLLGCM As String
        Private _TCMPCL As String
        Private _ORIGEN As String
        Private _DESTIN As String
        Private _CTPUNV As String
        Private _NMNFCR As String
        Private _TCMTRT As String
        Private _IMPPA As Decimal
        Private _MONEDA As String

        Private _NORCML As Double
        Private _NRITOC As Double
        Private _QCNTIT As Double
        Private _IVUNIT As Decimal
        Private _IVTOIT As Decimal
        Private _PRUNI As Decimal
        Private _TDITES As String
        Private _TPRVCL As String

        Private _FLETEITEM As Double

        Private _TOTALGUIA As Double
        Private _CCMPN As String = ""
#End Region

#Region "Properties"
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
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
        Public Property SESTOP() As String
            Get
                Return _SESTOP
            End Get
            Set(ByVal value As String)
                _SESTOP = value
            End Set
        End Property
        Public Property NOPRCN() As Double
            Get
                Return _NOPRCN
            End Get
            Set(ByVal value As Double)
                _NOPRCN = value
            End Set
        End Property
        Public Property FGUITR() As String
            Get
                Return _FGUITR
            End Get
            Set(ByVal value As String)
                _FGUITR = value
            End Set
        End Property

        Public Property FGUIRM() As String
            Get
                Return _FGUIRM
            End Get
            Set(ByVal value As String)
                _FGUIRM = value
            End Set
        End Property
        Public Property NPLVHT() As String
            Get
                Return _NPLVHT
            End Get
            Set(ByVal value As String)
                _NPLVHT = value
            End Set
        End Property
        Public Property NPLCAC() As Integer
            Get
                Return _NPLCAC
            End Get
            Set(ByVal value As Integer)
                _NPLCAC = value
            End Set
        End Property

        Public Property SINDRC() As String
            Get
                Return _SINDRC
            End Get
            Set(ByVal value As String)
                _SINDRC = value
            End Set
        End Property

        Public Property NGUIRM() As Double
            Get
                Return _NGUIRM
            End Get
            Set(ByVal value As Double)
                _NGUIRM = value
            End Set
        End Property
        Public Property NGUITR() As Double
            Get
                Return _NGUITR
            End Get
            Set(ByVal value As Double)
                _NGUITR = value
            End Set
        End Property
        Public Property FSLDCM() As String
            Get
                Return _FSLDCM
            End Get
            Set(ByVal value As String)
                _FSLDCM = value
            End Set
        End Property
        Public Property FLLGCM() As String
            Get
                Return _FLLGCM
            End Get
            Set(ByVal value As String)
                _FLLGCM = value
            End Set
        End Property
        Public Property TCMPCL() As String
            Get
                Return _TCMPCL
            End Get
            Set(ByVal value As String)
                _TCMPCL = value
            End Set
        End Property


        Public Property ORIGEN() As String
            Get
                Return _ORIGEN
            End Get
            Set(ByVal value As String)
                _ORIGEN = value
            End Set
        End Property

        Public Property DESTIN() As String
            Get
                Return _DESTIN
            End Get
            Set(ByVal value As String)
                _DESTIN = value
            End Set
        End Property

        Public Property CTPUNV() As Integer
            Get
                Return _CTPUNV
            End Get
            Set(ByVal value As Integer)
                _CTPUNV = value
            End Set
        End Property



        Public Property NMNFCR() As Integer
            Get
                Return _NMNFCR
            End Get
            Set(ByVal value As Integer)
                _NMNFCR = value
            End Set
        End Property

        Public Property TCMTRT() As String
            Get
                Return _TCMTRT
            End Get
            Set(ByVal value As String)
                _TCMTRT = value
            End Set
        End Property


        Public Property IMPPA() As Decimal
            Get
                Return _IMPPA
            End Get
            Set(ByVal value As Decimal)
                _IMPPA = value
            End Set
        End Property

        Public Property MONEDA() As String
            Get
                Return _MONEDA
            End Get
            Set(ByVal value As String)
                _MONEDA = value
            End Set
        End Property
        Public Property NORCML() As Integer
            Get
                Return _NORCML
            End Get
            Set(ByVal value As Integer)
                _NORCML = value
            End Set
        End Property
        Public Property NRITOC() As Int32
            Get
                Return _NRITOC
            End Get
            Set(ByVal value As Int32)
                _NRITOC = value
            End Set
        End Property

        Public Property QCNTIT() As Int32
            Get
                Return _QCNTIT
            End Get
            Set(ByVal value As Int32)
                _QCNTIT = value
            End Set
        End Property
        Public Property IVUNIT() As Double
            Get
                Return _IVUNIT
            End Get
            Set(ByVal value As Double)
                _IVUNIT = value
            End Set
        End Property
        Public Property IVTOIT() As Double
            Get
                Return _IVTOIT
            End Get
            Set(ByVal value As Double)
                _IVTOIT = value
            End Set
        End Property
        Public Property PRUNI() As Double
            Get
                Return _PRUNI
            End Get
            Set(ByVal value As Double)
                _PRUNI = value
            End Set
        End Property
        Public Property TDITES() As String
            Get
                Return _TDITES
            End Get
            Set(ByVal value As String)
                _TDITES = value
            End Set
        End Property
        Public Property TPRVCL() As Integer
            Get
                Return _TPRVCL
            End Get
            Set(ByVal value As Integer)
                _TPRVCL = value
            End Set
        End Property
        Public Property FLETEITEM() As Double
            Get
                Return _FLETEITEM
            End Get
            Set(ByVal value As Double)
                _FLETEITEM = value
            End Set
        End Property
        Public Property TOTALGUIA() As Double
            Get
                Return _TOTALGUIA
            End Get
            Set(ByVal value As Double)
                _TOTALGUIA = value
            End Set
        End Property



#End Region



    End Class
End Namespace

