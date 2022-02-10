Namespace mantenimientos

    Public Class Contratista_Cliente
        Private _PNCCLNT As Double
        Private _PNCPRVCL As Double
        Private _PSCCMPN As String
        Private _PNNDIART As Double
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

        Private _PSTCMPCL As String
        Private _PSTPRVCL As String
        Private _PNNRUCPR As Double
        Private _PSTDRPRC As String

        Private _PSTNROFX As String
        Private _PSTLFNO1 As String
        Private _PSTEMAI2L As String


        Public Property PSTPRVCL() As String
            Get
                Return (_PSTPRVCL)
            End Get
            Set(ByVal value As String)
                _PSTPRVCL = value
            End Set
        End Property

        Public Property PNNRUCPR() As String
            Get
                Return (_PNNRUCPR)
            End Get
            Set(ByVal value As String)
                _PNNRUCPR = value
            End Set
        End Property

        Public Property PSTDRPRC() As String
            Get
                Return (_PSTDRPRC)
            End Get
            Set(ByVal value As String)
                _PSTDRPRC = value
            End Set
        End Property

        Public Property PSTNROFX() As String
            Get
                Return (_PSTNROFX)
            End Get
            Set(ByVal value As String)
                _PSTNROFX = value
            End Set
        End Property

        Public Property PSTLFNO1() As String
            Get
                Return (_PSTLFNO1)
            End Get
            Set(ByVal value As String)
                _PSTLFNO1 = value
            End Set
        End Property

        Public Property PSTEMAI2() As String
            Get
                Return (_PSTEMAI2L)
            End Get
            Set(ByVal value As String)
                _PSTEMAI2L = value
            End Set
        End Property


        Private _PNCANTPERSONAL As Double
        Public Property PNCANTPERSONAL() As Double
            Get
                Return _PNCANTPERSONAL
            End Get
            Set(ByVal value As Double)
                _PNCANTPERSONAL = value
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

        Public Property PSTCMPCL() As String
            Get
                Return (_PSTCMPCL)
            End Get
            Set(ByVal value As String)
                _PSTCMPCL = value
            End Set
        End Property



        Public Property PNCPRVCL() As Double
            Get
                Return (_PNCPRVCL)
            End Get
            Set(ByVal value As Double)
                _PNCPRVCL = value
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

        Public Property PNNDIART() As Double
            Get
                Return (_PNNDIART)
            End Get
            Set(ByVal value As Double)
                _PNNDIART = value
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
    End Class

End Namespace