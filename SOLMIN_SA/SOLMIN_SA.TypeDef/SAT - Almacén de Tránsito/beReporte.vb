
Namespace Reportes

    Public Class beFiltrosDespachoPorAlmacen

        Inherits beBase(Of beFiltrosDespachoPorAlmacen)
        Public Sub New()
            Me.InicializeProperty(Me)
        End Sub

#Region " Atributos "
        Private _PNCCLNT As Int32 = 0
        Private _PSCCLNT As String = ""
        Private _PSCREFFW As String = ""
        Private _PNFECINI As Decimal = 0
        Private _PNFECFIN As Decimal = 0
        Private _PSTUBRFR As String = ""
        Private _PSTPING As String = ""
        Private _PNNPRTIN As Decimal = 0
        Private _PSSTPODP As String = ""
        Private _PNFRLZSR As Decimal = 0
        Private _PSCSRVC As String = ""
        Private _PNNPRTIN2 As Decimal = 0
        Private _PSTIPMAT As String = "" 'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS
        Private _PSCMATPE As String = "" 'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS
#End Region
#Region " Propiedades "
        Public Property PNCCLNT() As Decimal
            Get
                Return _PNCCLNT
            End Get
            Set(ByVal value As Decimal)
                _PNCCLNT = value
            End Set
        End Property
        Public Property PSCCLNT() As String
            Get
                Return _PSCCLNT
            End Get
            Set(ByVal value As String)
                _PSCCLNT = value
            End Set
        End Property

        Private _PSCTPDP6 As String
        Public Property PSCTPDP6() As String
            Get
                Return _PSCTPDP6
            End Get
            Set(ByVal value As String)
                _PSCTPDP6 = value
            End Set
        End Property


        Private _PNFECINV As Decimal
        Public Property PNFECINV() As Decimal
            Get
                Return _PNFECINV
            End Get
            Set(ByVal value As Decimal)
                _PNFECINV = value
            End Set
        End Property


        Private _PNTIPO As Integer
        Public Property PNTIPO() As Integer
            Get
                Return _PNTIPO
            End Get
            Set(ByVal value As Integer)
                _PNTIPO = value
            End Set
        End Property

        Private _PSTCMPCL As String
        Public Property PSTCMPCL() As String
            Get
                Return _PSTCMPCL
            End Get
            Set(ByVal value As String)
                _PSTCMPCL = value
            End Set
        End Property


        Public Property PSCREFFW() As String
            Get
                Return _PSCREFFW
            End Get
            Set(ByVal value As String)
                _PSCREFFW = value
            End Set
        End Property

        Public Property PNFECFIN() As String
            Get
                Return _PNFECFIN
            End Get
            Set(ByVal value As String)
                _PNFECFIN = CtypeDate(value)
            End Set
        End Property

        Public Property PNFECINI() As String
            Get
                Return _PNFECINI
            End Get
            Set(ByVal value As String)
                _PNFECINI = CtypeDate(value)
            End Set
        End Property


        Private _PNFPROCE As String
        Public Property PNFPROCE() As String
            Get
                Return _PNFPROCE
            End Get
            Set(ByVal value As String)
                _PNFPROCE = CtypeDate(value)
            End Set
        End Property

        Public Property PSTUBRFR() As String
            Get
                Return _PSTUBRFR
            End Get
            Set(ByVal value As String)
                _PSTUBRFR = value
            End Set
        End Property

        Public Property PSSTPING() As String
            Get
                Return _PSTPING
            End Get
            Set(ByVal value As String)
                _PSTPING = value
            End Set
        End Property


        Private _PSCCMPN As String
        Public Property PSCCMPN() As String
            Get
                Return _PSCCMPN
            End Get
            Set(ByVal value As String)
                _PSCCMPN = value
            End Set
        End Property


        Private _PSCDVSN As String
        Public Property PSCDVSN() As String
            Get
                Return _PSCDVSN
            End Get
            Set(ByVal value As String)
                _PSCDVSN = value
            End Set
        End Property

        Private _PNCPLNDV As Decimal
        Public Property PNCPLNDV() As Decimal
            Get
                Return _PNCPLNDV
            End Get
            Set(ByVal value As Decimal)
                _PNCPLNDV = value
            End Set
        End Property


        Private _NPLCUN As String
        Public Property PSNPLCUN() As String
            Get
                Return _NPLCUN
            End Get
            Set(ByVal value As String)
                _NPLCUN = value
            End Set
        End Property

        Private _PSNORCML As String
        Public Property PSNORCML() As String
            Get
                Return _PSNORCML
            End Get
            Set(ByVal value As String)
                _PSNORCML = value
            End Set
        End Property



        Private _PNNRITOC As Decimal
        Public Property PNNRITOC() As Decimal
            Get
                Return _PNNRITOC
            End Get
            Set(ByVal value As Decimal)
                _PNNRITOC = value
            End Set
        End Property

        Private _PSTLUGEN As String
        Public Property PSTLUGEN() As String
            Get
                Return _PSTLUGEN
            End Get
            Set(ByVal value As String)
                _PSTLUGEN = value
            End Set
        End Property


        Private _PSSSNCRG As String
        Public Property PSSSNCRG() As String
            Get
                Return _PSSSNCRG
            End Get
            Set(ByVal value As String)
                _PSSSNCRG = value
            End Set
        End Property
        Private _PNCANDIA As Decimal
        Public Property PNCANDIA() As Decimal
            Get
                Return _PNCANDIA
            End Get
            Set(ByVal value As Decimal)
                _PNCANDIA = value
            End Set
        End Property

        Public Property PNNPRTIN() As Decimal
            Get
                Return _PNNPRTIN
            End Get
            Set(ByVal value As Decimal)
                _PNNPRTIN = value
            End Set
        End Property

        Public Property PSSTPODP() As String
            Get
                Return _PSSTPODP
            End Get
            Set(ByVal value As String)
                _PSSTPODP = value
            End Set
        End Property

        Public Property PNFRLZSR() As Decimal
            Get
                Return _PNFRLZSR
            End Get
            Set(ByVal value As Decimal)
                _PNFRLZSR = value
            End Set
        End Property

        Public Property PSCSRVC() As String
            Get
                Return _PSCSRVC
            End Get
            Set(ByVal value As String)
                _PSCSRVC = value
            End Set
        End Property

        Public Property PNNPRTIN2() As Decimal
            Get
                Return _PNNPRTIN2
            End Get
            Set(ByVal value As Decimal)
                _PNNPRTIN2 = value
            End Set
        End Property


        Private _PSCTPALM As String
        Public Property PSCTPALM() As String
            Get
                Return _PSCTPALM
            End Get
            Set(ByVal value As String)
                _PSCTPALM = value
            End Set
        End Property


        Private _PSCALMC As String
        Public Property PSCALMC() As String
            Get
                Return _PSCALMC
            End Get
            Set(ByVal value As String)
                _PSCALMC = value
            End Set
        End Property


        Private _PSCZNALM As String
        Public Property PSCZNALM() As String
            Get
                Return _PSCZNALM
            End Get
            Set(ByVal value As String)
                _PSCZNALM = value
            End Set
        End Property
        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-INICIO
        Public Property PSTIPMAT() As String
            Get
                Return _PSTIPMAT
            End Get
            Set(ByVal value As String)
                _PSTIPMAT = value
            End Set
        End Property

        Public Property PSCMATPE() As String
            Get
                Return _PSCMATPE
            End Get
            Set(ByVal value As String)
                _PSCMATPE = value
            End Set
        End Property
        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-FIN
#End Region

    End Class
End Namespace

