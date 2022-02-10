Namespace mantenimientos
    Public Class Viajes_Cliente
        Private _PNNPRGVJ As Double
        Private _PNFCHPSA_1 As Double
        Private _PSFCHPSA As String
        Private _PNHRAPSA_1 As Double
        Private _PSHRAPSA As String

        Private _PSTNMMDT As String
        Private _PSTCMPCL As String


        Private _PSCCMPN As String
        Private _PNCMEDTR As Double
        Private _PNCCLNT As Double
        Private _PSSESTRG As String
        Private _PSCUSCRT As String
        Private _PNFCHCRT As Double
        Private _PNHRACRT As Double
        Private _PSNTRMCR As String
        Private _PSCULUSA As String
        Private _PNFULTAC As Double
        Private _PNHULTAC As Double
        Private _PSNTRMNL As String
        Private _PNUPDATE_IDENT As Double


        Private _PNFINI As Double
        Private _PNFFIN As Double


        Public Property PNFINI() As Double
            Get
                Return (_PNFINI)
            End Get
            Set(ByVal value As Double)
                _PNFINI = value
            End Set
        End Property

        Public Property PNFFIN() As Double
            Get
                Return (_PNFFIN)
            End Get
            Set(ByVal value As Double)
                _PNFFIN = value
            End Set
        End Property


        Public Property PNNPRGVJ() As Double
            Get
                Return (_PNNPRGVJ)
            End Get
            Set(ByVal value As Double)
                _PNNPRGVJ = value
            End Set
        End Property
        Public Property PNFCHPSA_1() As Double
            Get
                Return (_PNFCHPSA_1)
            End Get
            Set(ByVal value As Double)
                _PNFCHPSA_1 = value
            End Set
        End Property
        Public Property PNHRAPSA_1() As Double
            Get
                Return (_PNHRAPSA_1)
            End Get
            Set(ByVal value As Double)
                _PNHRAPSA_1 = value
            End Set
        End Property


        Public Property PSFCHPSA() As String
            Get
                Return (_PSFCHPSA)
            End Get
            Set(ByVal value As String)
                _PSFCHPSA = value
            End Set
        End Property

        Public Property PSHRAPSA() As String
            Get
                Return (_PSHRAPSA)
            End Get
            Set(ByVal value As String)
                _PSHRAPSA = value
            End Set
        End Property


        Public Property PSCCMPN() As String
            Get
                Return (_PSCCMPN)
            End Get
            Set(ByVal value As String)
                _PSCCMPN = value
            End Set
        End Property


        Public Property PSTNMMDT() As String
            Get
                Return (_PSTNMMDT)
            End Get
            Set(ByVal value As String)
                _PSTNMMDT = value
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


        Public Property PNCMEDTR() As Double
            Get
                Return (_PNCMEDTR)
            End Get
            Set(ByVal value As Double)
                _PNCMEDTR = value
            End Set
        End Property

        Public Property PNCCLNT() As Double
            Get
                Return (_PNCCLNT)
            End Get
            Set(ByVal value As Double)
                _PNCCLNT = value
            End Set
        End Property
        Public Property PSSESTRG() As String
            Get
                Return (_PSSESTRG)
            End Get
            Set(ByVal value As String)
                _PSSESTRG = value
            End Set
        End Property
        Public Property PSCUSCRT() As String
            Get
                Return (_PSCUSCRT)
            End Get
            Set(ByVal value As String)
                _PSCUSCRT = value
            End Set
        End Property
        Public Property PNFCHCRT() As Double
            Get
                Return (_PNFCHCRT)
            End Get
            Set(ByVal value As Double)
                _PNFCHCRT = value
            End Set
        End Property
        Public Property PNHRACRT() As Double
            Get
                Return (_PNHRACRT)
            End Get
            Set(ByVal value As Double)
                _PNHRACRT = value
            End Set
        End Property
        Public Property PSNTRMCR() As String
            Get
                Return (_PSNTRMCR)
            End Get
            Set(ByVal value As String)
                _PSNTRMCR = value
            End Set
        End Property
        Public Property PSCULUSA() As String
            Get
                Return (_PSCULUSA)
            End Get
            Set(ByVal value As String)
                _PSCULUSA = value
            End Set
        End Property
        Public Property PNFULTAC() As Double
            Get
                Return (_PNFULTAC)
            End Get
            Set(ByVal value As Double)
                _PNFULTAC = value
            End Set
        End Property
        Public Property PNHULTAC() As Double
            Get
                Return (_PNHULTAC)
            End Get
            Set(ByVal value As Double)
                _PNHULTAC = value
            End Set
        End Property
        Public Property PSNTRMNL() As String
            Get
                Return (_PSNTRMNL)
            End Get
            Set(ByVal value As String)
                _PSNTRMNL = value
            End Set
        End Property
        Public Property PNUPDATE_IDENT() As Double
            Get
                Return (_PNUPDATE_IDENT)
            End Get
            Set(ByVal value As Double)
                _PNUPDATE_IDENT = value
            End Set
        End Property



        Private _PNCANTRUTA As Double
        Public Property PNCANTRUTA() As Double
            Get
                Return _PNCANTRUTA
            End Get
            Set(ByVal value As Double)
                _PNCANTRUTA = value
            End Set
        End Property


        Private _PNCANTPASAJERO As Double
        Public Property PNCANTPASAJERO() As Double
            Get
                Return _PNCANTPASAJERO
            End Get
            Set(ByVal value As Double)
                _PNCANTPASAJERO = value
            End Set
        End Property

    End Class
End Namespace