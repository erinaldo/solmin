Public Class beDespachoNacional

    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PSTRECOR As String = ""
    Private _PSTPSRVA As String = ""
    Private _PSSESTRG As String = ""
    Private _PSTDREN2 As String = ""
    Private _PSTDRCOR As String = ""
    Private _PSNDOCEM As String = ""
    Private _PSTOBERV As String = ""
    Private _PSNREFCL As String = ""
    Private _PSREFDO1 As String = ""
    Private _PSFLGTRF As String = ""
    Private _PSCVPRCN As String = ""
    Private _PNCCIANV As Decimal = 0
    Private _PNCMEDTR As Decimal = 0
    Private _PNCLCLOR As Decimal = 0
    Private _PNCLCLDS As Decimal = 0
    Private _PNCPRVCL As Decimal = 0
    Private _PNQVOLMR As Decimal = 0
    Private _PNQPSOAR As Decimal = 0
    Private _PNCPLNDV As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PNFORSCI As Decimal = 0
    Private _PSFORSCI As String = ""
    Private _PNNORSCI As Decimal = 0

    Private _PSTPRVCL As String = ""
    Private _PSTNMCIN As String = ""
    Private _PSTNMMDT As String = ""
    Private _PSTCMLCL As String = ""
    Private _PSTDSDES As String = ""
    Private _PSORIGEN As String = ""
    Private _PSDESTIN As String = ""
    Private _PSTCMPCL As String = ""
    Private _PSREFNAV As String = ""
    Private _PNFECINI As Decimal = 0
    Private _PNFECFIN As Decimal = 0
    Private _PNNRTFSV As Decimal = 0
    Private _PSCTRMAL As String = ""
    Private _PSTTRMAL As String = ""
    Private _PNCAGNCR As Decimal = 0
    Private _PSTNMAGC As String = ""
    Private _PSREFNAV_DES As String = ""

     
    Private _PNNESTDO As Decimal = 0
    Private _PNCHK_INI As Decimal = 0
    Private _PNCHK_FIN As Decimal = 0
    Private _PSFTRTSG As String = ""
 


    Public Property PNCAGNCR() As Decimal
        Get
            Return _PNCAGNCR
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNCR = value
        End Set
    End Property

    Public Property PSCTRMAL() As String
        Get
            Return _PSCTRMAL
        End Get
        Set(ByVal value As String)
            _PSCTRMAL = value
        End Set
    End Property
    Public Property PSTNMAGC() As String
        Get
            Return _PSTNMAGC
        End Get
        Set(ByVal value As String)
            _PSTNMAGC = value
        End Set
    End Property


    Public Property PSTTRMAL() As String
        Get
            Return _PSTTRMAL
        End Get
        Set(ByVal value As String)
            _PSTTRMAL = value
        End Set
    End Property

    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property PSDESTIN() As String
        Get
            Return _PSDESTIN
        End Get
        Set(ByVal value As String)
            _PSDESTIN = value
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

    Public Property PSTDSDES() As String
        Get
            Return _PSTDSDES
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
        End Set
    End Property

    Public Property PSTCMLCL() As String
        Get
            Return _PSTCMLCL
        End Get
        Set(ByVal value As String)
            _PSTCMLCL = value
        End Set
    End Property

    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property

    Public Property PSTNMCIN() As String
        Get
            Return _PSTNMCIN
        End Get
        Set(ByVal value As String)
            _PSTNMCIN = value
        End Set
    End Property

    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property

    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property PNCCIANV() As Decimal
        Get
            Return _PNCCIANV
        End Get
        Set(ByVal value As Decimal)
            _PNCCIANV = value
        End Set
    End Property

    Public Property PNFORSCI() As Decimal
        Get
            Return _PNFORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNFORSCI = value
        End Set
    End Property


    Public Property PSFORSCI() As String
        Get
            Return _PSFORSCI
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
        End Set
    End Property


    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
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

    Public Property PNQPSOAR() As Decimal
        Get
            Return _PNQPSOAR
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOAR = value
        End Set
    End Property

    Public Property PNQVOLMR() As Decimal
        Get
            Return _PNQVOLMR
        End Get
        Set(ByVal value As Decimal)
            _PNQVOLMR = value
        End Set
    End Property

    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    'Public Property PNCLCLDS() As Decimal
    '    Get
    '        Return _PNCLCLDS
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNCLCLDS = value
    '    End Set
    'End Property

    Public Property PSCVPRCN() As String
        Get
            Return _PSCVPRCN
        End Get
        Set(ByVal value As String)
            _PSCVPRCN = value
        End Set
    End Property

    'Public Property PNCLCLOR() As Decimal
    '    Get
    '        Return _PNCLCLOR
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNCLCLOR = value
    '    End Set
    'End Property

    Public Property PNCMEDTR() As Decimal
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property

    Public Property PSFLGTRF() As String
        Get
            Return _PSFLGTRF
        End Get
        Set(ByVal value As String)
            _PSFLGTRF = value
        End Set
    End Property

    Public Property PSREFDO1() As String
        Get
            Return _PSREFDO1
        End Get
        Set(ByVal value As String)
            _PSREFDO1 = value
        End Set
    End Property

    Public Property PSNREFCL() As String
        Get
            Return _PSNREFCL
        End Get
        Set(ByVal value As String)
            _PSNREFCL = value
        End Set
    End Property

    Public Property PSTOBERV() As String
        Get
            Return _PSTOBERV
        End Get
        Set(ByVal value As String)
            _PSTOBERV = value
        End Set
    End Property

    Public Property PSNDOCEM() As String
        Get
            Return _PSNDOCEM
        End Get
        Set(ByVal value As String)
            _PSNDOCEM = value
        End Set
    End Property

    Public Property PSTDRCOR() As String
        Get
            Return _PSTDRCOR
        End Get
        Set(ByVal value As String)
            _PSTDRCOR = value
        End Set
    End Property

    Public Property PSTDREN2() As String
        Get
            Return _PSTDREN2
        End Get
        Set(ByVal value As String)
            _PSTDREN2 = value
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

    Public Property PSTPSRVA() As String
        Get
            Return _PSTPSRVA
        End Get
        Set(ByVal value As String)
            _PSTPSRVA = value
        End Set
    End Property

    Public Property PSTRECOR() As String
        Get
            Return _PSTRECOR
        End Get
        Set(ByVal value As String)
            _PSTRECOR = value
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

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSREFNAV() As String
        Get
            Return _PSREFNAV
        End Get
        Set(ByVal value As String)
            _PSREFNAV = value
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

    Public Property PNNRTFSV() As Decimal
        Get
            Return _PNNRTFSV
        End Get
        Set(ByVal value As Decimal)
            _PNNRTFSV = value
        End Set
    End Property

    Public Property PSREFNAV_DES() As String
        Get
            Return _PSREFNAV_DES
        End Get
        Set(ByVal value As String)
            _PSREFNAV_DES = value
        End Set
    End Property


    Public Property PNCLCLOR() As Decimal
        Get
            Return _PNCLCLOR
        End Get
        Set(ByVal value As Decimal)
            _PNCLCLOR = value
        End Set
    End Property

    Public Property PNCLCLDS() As Decimal
        Get
            Return _PNCLCLDS
        End Get
        Set(ByVal value As Decimal)
            _PNCLCLDS = value
        End Set
    End Property

    Public Property PNNESTDO() As Decimal
        Get
            Return _PNNESTDO
        End Get
        Set(ByVal value As Decimal)
            _PNNESTDO = value
        End Set
    End Property

    Public Property PNCHK_INI() As Decimal
        Get
            Return _PNCHK_INI
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_INI = value
        End Set
    End Property

    Public Property PNCHK_FIN() As Decimal
        Get
            Return _PNCHK_FIN
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_FIN = value
        End Set
    End Property

    Public Property PSFTRTSG() As String
        Get
            Return _PSFTRTSG
        End Get
        Set(ByVal value As String)
            _PSFTRTSG = value
        End Set
    End Property

    '
End Class
