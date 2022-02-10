Public Class beProveedor
    Inherits beBase(Of beProveedor)

    Public Sub New()
        InicializeProperty(Me)
    End Sub

    Public CPRVCL_CodClienteTercero As Int64 = 0
    Public TPRVCL_DesClieTercero As String = ""
    Public TPRCL1_DesProvCliente As String = ""
    Public NRUCPR_RucProveedor As Int64 = 0
    Public NRUCPR_RucProveedorSTR As String = ""
    Public TNACPR_DesProvDistProveedor As String = ""
    Public TDRPRC_DirecCliTercero As String = ""
    Public CPAIS_CodigoPais As Int64 = 0
    Public TNROFX_NroFax As String = ""
    Public TLFN01_Telefono As String = ""
    Public TEMAI2_NombreEmail As String = ""
    Public TPRSCN_PersonaContacto As String = ""
    Public TLFN02_FonoContacto As String = ""
    Public TMAI03_EmailContacto As String = ""
    Public NDSDMP_NumDiasDemoraPago As Int64 = "0"
    Public SESTRG_Estado As String = ""
    Public FULTAC_FechaAct As Int64 = 0
    Public HULTAC_HoraAct As Int64 = 0
    Public CULUSA_UsuarioAct As String = ""
    Public CUSCRT_UsuarioCre As String = ""
    Public FCHCRT_FechaCre As Int64 = 0
    Public HRACRT_HoraCre As Int64 = 0
    Public CCLNT_CodigoCliente As Int64 = 0
    Public CPRPCL_CodigoClienteProveedor As String = ""
    Public CREAR_RELACION_CrearRelacionClientevsProveedor As String = ""

    Public RELACION As String = ""
    Public CREACION As String = ""


#Region "Campos de la Entidad V2"
    Private _PNCPRVCL As Decimal = 0
    Private _PSTPRVCL As String = ""
    Private _PSTPRCL1 As String = ""
    Private _PNNRUCPR As Decimal = 0
    Private _PSTNACPR As String = ""
    Private _PSTDRPRC As String = ""
    Private _PNCPAIS As Decimal = 0
    Private _PSTNROFX As String = ""
    Private _PSTLFNO1 As String = ""
    Private _PSTEMAI2 As String = ""
    Private _PSTPRSCN As String = ""
    Private _PSTLFNO2 As String = ""
    Private _PSTEMAI3 As String = ""
    Private _PNNDSDMP As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PSSTPORL As String = ""
    Private _NOMCOMPLETO As String = ""




    Private _PNCPLCLP As Decimal
    Public Property PNCPLCLP() As Decimal
        Get
            Return _PNCPLCLP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property

    Private _PSTDRPCP As String = ""
    Public Property PSTDRPCP() As String
        Get
            Return _PSTDRPCP
        End Get
        Set(ByVal value As String)
            _PSTDRPCP = value
        End Set
    End Property


    Private _PSTDRDST As String = ""
    Public Property PSTDRDST() As String
        Get
            Return _PSTDRDST
        End Get
        Set(ByVal value As String)
            _PSTDRDST = value
        End Set
    End Property


    Private _PSTCMPCP As String = ""
    Public Property PSTCMPCP() As String
        Get
            Return _PSTCMPCP
        End Get
        Set(ByVal value As String)
            _PSTCMPCP = value
        End Set
    End Property

    Public Property PSNOMCOMPLETO() As String
        Get
            Return _NOMCOMPLETO
        End Get
        Set(ByVal value As String)
            _NOMCOMPLETO = value
        End Set
    End Property


    Private _PSDIRCOMPLETO As String = ""
    Public Property PSDIRCOMPLETO() As String
        Get
            Return _PSDIRCOMPLETO
        End Get
        Set(ByVal value As String)
            _PSDIRCOMPLETO = value
        End Set
    End Property



    Public Property PSSTPORL() As String
        Get
            Return _PSSTPORL
        End Get
        Set(ByVal value As String)
            _PSSTPORL = value
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

    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Public Property PSTPRVCL() As String
        Get
            Return (_PSTPRVCL)
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property
    Public Property PSTPRCL1() As String
        Get
            Return (_PSTPRCL1)
        End Get
        Set(ByVal value As String)
            _PSTPRCL1 = value
        End Set
    End Property
    Public Property PNNRUCPR() As Decimal
        Get
            Return (_PNNRUCPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCPR = value
        End Set
    End Property
    Public Property PSTNACPR() As String
        Get
            Return (_PSTNACPR)
        End Get
        Set(ByVal value As String)
            _PSTNACPR = value
        End Set
    End Property
    ''' <summary>
    ''' Dirección Cliente Tercero 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTDRPRC() As String
        Get
            Return (_PSTDRPRC)
        End Get
        Set(ByVal value As String)
            _PSTDRPRC = value
        End Set
    End Property
    Public Property PNCPAIS() As Decimal
        Get
            Return (_PNCPAIS)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
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
            Return (_PSTEMAI2)
        End Get
        Set(ByVal value As String)
            _PSTEMAI2 = value
        End Set
    End Property
    ''' <summary>
    ''' Extencion a la direccion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTPRSCN() As String
        Get
            Return (_PSTPRSCN)
        End Get
        Set(ByVal value As String)
            _PSTPRSCN = value
        End Set
    End Property
    Public Property PSTLFNO2() As String
        Get
            Return (_PSTLFNO2)
        End Get
        Set(ByVal value As String)
            _PSTLFNO2 = value
        End Set
    End Property
    Public Property PSTEMAI3() As String
        Get
            Return (_PSTEMAI3)
        End Get
        Set(ByVal value As String)
            _PSTEMAI3 = value
        End Set
    End Property
    Public Property PNNDSDMP() As Decimal
        Get
            Return (_PNNDSDMP)
        End Get
        Set(ByVal value As Decimal)
            _PNNDSDMP = value
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
    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
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
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property


    Private _PNCPLCLP_CodPlanta As Decimal = 0
    Public Property CPLCLP_CodPlanta() As Decimal
        Get
            Return _PNCPLCLP_CodPlanta
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP_CodPlanta = value
        End Set
    End Property

    Private _PSNTLFPL As String = ""
    Public Property PSNTLFPL() As String
        Get
            Return _PSNTLFPL
        End Get
        Set(ByVal value As String)
            _PSNTLFPL = value
        End Set
    End Property


    Private _PSCCLTTM As String = ""
    Public Property PSCCLTTM() As String
        Get
            Return _PSCCLTTM
        End Get
        Set(ByVal value As String)
            _PSCCLTTM = value
        End Set
    End Property


    Private _PSCPRPCL As String
    ''' <summary>
    '''  Codigo del proveedor - Cliente 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCPRPCL() As String
        Get
            Return _PSCPRPCL
        End Get
        Set(ByVal value As String)
            _PSCPRPCL = value
        End Set
    End Property

    Private _PSCCTCST As String = ""
    ''' <summary>
    ''' CENTRO DE COSTO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCCTCST() As String
        Get
            Return _PSCCTCST
        End Get
        Set(ByVal value As String)
            _PSCCTCST = value
        End Set
    End Property

    Private _PSTDSCNT As String = ""

    ''' <summary>
    ''' DESCRIPCION DEL CENTRO DE COSTO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTDSCNT() As String
        Get
            Return _PSTDSCNT
        End Get
        Set(ByVal value As String)
            _PSTDSCNT = value
        End Set
    End Property


    Private _PSCDIVSU As String = ""
    ''' <summary>
    ''' Divisionaria-Subdivisionaria 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCDIVSU() As String
        Get
            Return _PSCDIVSU
        End Get
        Set(ByVal value As String)
            _PSCDIVSU = value
        End Set
    End Property


    Private _PSCDUNNG As String = ""
    ''' <summary>
    ''' Cod Unidad de Negocio 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCDUNNG() As String
        Get
            Return _PSCDUNNG
        End Get
        Set(ByVal value As String)
            _PSCDUNNG = value
        End Set
    End Property


    Private _PSCDGALM As String = ""
    ''' <summary>
    ''' Codigo Almacen   
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCDGALM() As String
        Get
            Return _PSCDGALM
        End Get
        Set(ByVal value As String)
            _PSCDGALM = value
        End Set
    End Property

    Private _PSNTRMNL As String = ""
    ''' <summary>
    ''' NRO DE TERMINAL USADO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property

    Private _PSINTERNO As String = ""
    ''' <summary>
    ''' Es proveedor o planta del cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSINTERNO() As String
        Get
            Return _PSINTERNO
        End Get
        Set(ByVal value As String)
            If value Is Nothing OrElse value = "" Then
                _PSINTERNO = "0"
            Else
                _PSINTERNO = value
            End If
        End Set
    End Property
    Private _PSCPRVD1 As String
    Public Property PSCPRVD1() As String
        Get
            Return _PSCPRVD1
        End Get
        Set(ByVal value As String)
            _PSCPRVD1 = value
        End Set
    End Property

#End Region


End Class
