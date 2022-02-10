Namespace Reportes

    Public Class bePreDespacho
        Inherits beBase(Of bePreDespacho)
        Public Sub New()
            Me.InicializeProperty(Me)
        End Sub

        Private _PSCCMPN As String
        Private _PSCDVSN As String
        Private _PNCPLNDV As String

        Private _PNCCLNT As String
        Private _PSCREFFW As String

        Private _PNFECHAINI As String
        Private _PNFECHAFIN As String

        Private _PSTIPOVISTA As String


        Private _PSNRPLTS As String = ""
        Private _PNNROPLT As Decimal = 0
        Private _PNNSEQIN As Decimal = 0
        Private _PNPREDESPACHO As Decimal = 0
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
        Public Property PNCPLNDV() As String
            Get
                Return _PNCPLNDV
            End Get
            Set(ByVal value As String)
                _PNCPLNDV = value
            End Set
        End Property


        Public Property PNCCLNT() As String
            Get
                Return _PNCCLNT
            End Get
            Set(ByVal value As String)
                _PNCCLNT = value
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
        Public Property PNFECHAINI() As String
            Get
                Return _PNFECHAINI
            End Get
            Set(ByVal value As String)
                _PNFECHAINI = value
            End Set
        End Property
        Public Property PNFECHAFIN() As String
            Get
                Return _PNFECHAFIN
            End Get
            Set(ByVal value As String)
                _PNFECHAFIN = value
            End Set
        End Property
        Public Property PSTIPOVISTA() As String
            Get
                Return _PSTIPOVISTA
            End Get
            Set(ByVal value As String)
                _PSTIPOVISTA = value
            End Set
        End Property

        Public Property PSNRPLTS() As String
            Get
                Return _PSNRPLTS
            End Get
            Set(ByVal value As String)
                _PSNRPLTS = value
            End Set
        End Property

        Public Property PNNROPLT() As Decimal
            Get
                Return _PNNROPLT
            End Get
            Set(ByVal value As Decimal)
                _PNNROPLT = value
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

        Public Property PNPREDESPACHO() As Decimal
            Get
                Return _PNPREDESPACHO
            End Get
            Set(ByVal value As Decimal)
                _PNPREDESPACHO = value
            End Set
        End Property




    End Class

End Namespace