Namespace slnSOLMIN_SAT.Almacen
    Public Class clsPrimaryKey_Bulto
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsPrimaryKey_ItemBulto
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private strCIDPAQ As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pstrCodigoIdentificacionPaquete_CIDPAQ() As String
            Get
                Return strCIDPAQ
            End Get
            Set(ByVal value As String)
                strCIDPAQ = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltrosParaBultos
#Region "Atributos"
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private dteFREFFW_Inicio As Date
        Private dteFREFFW_Final As Date
        Private strTUBRFR As String = ""
        Private strNROPLT As String = ""
        Private strCRTLTE As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaRecepcionInicio_FREFFW() As Date
            Get
                Return dteFREFFW_Inicio
            End Get
            Set(ByVal value As Date)
                dteFREFFW_Inicio = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaRecepcionInicio_FREFFW() As String
            Get
                If dteFREFFW_Inicio.Year > 1 Then
                    Return dteFREFFW_Inicio.ToString("yyyyMMdd")
                Else
                    Return ""
                End If
            End Get
        End Property

        Public Property pdteFechaRecepcionFinal_FREFFW() As Date
            Get
                Return dteFREFFW_Final
            End Get
            Set(ByVal value As Date)
                dteFREFFW_Final = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaRecepcionFinal_FREFFW() As String
            Get
                If dteFREFFW_Final.Year > 1 Then
                    Return dteFREFFW_Final.ToString("yyyyMMdd")
                Else
                    Return ""
                End If
            End Get
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pstrNroPaletizado_NROPLT() As String
            Get
                Return strNROPLT
            End Get
            Set(ByVal value As String)
                strNROPLT = value
            End Set
        End Property

        Public Property pstrCriterioLote_CRTLTE() As String
            Get
                Return strCRTLTE
            End Get
            Set(ByVal value As String)
                strCRTLTE = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltro_IngresoPorAlmacen
#Region "Atributos"
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private dteFREFFW_Inicio As Date
        Private dteFREFFW_Final As Date
        Private strTUBRFR As String = ""
        Public pTTINTC_TermInterCarga As String = ""
        Public pSTPING_TipoMovimiento As String = ""
        Private bSTIENV As Boolean = False
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaRecepcionInicio_FREFFW() As Date
            Get
                Return dteFREFFW_Inicio
            End Get
            Set(ByVal value As Date)
                dteFREFFW_Inicio = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaRecepcionInicio_FFec_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW_Inicio.Year > 1 Then strResultado = dteFREFFW_Inicio.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaRecepcionInicio_FNum_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW_Inicio.Year > 1 Then strResultado = dteFREFFW_Inicio.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaRecepcionInicio_FREFFW() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFREFFW_Inicio.Year > 1 Then Integer.TryParse(dteFREFFW_Inicio.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaRecepcionFinal_FREFFW() As Date
            Get
                Return dteFREFFW_Final
            End Get
            Set(ByVal value As Date)
                dteFREFFW_Final = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaRecepcionFinal_FFec_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW_Final.Year > 1 Then strResultado = dteFREFFW_Final.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaRecepcionFinal_FNum_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW_Final.Year > 1 Then strResultado = dteFREFFW_Final.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaRecepcionFinal_FREFFW() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFREFFW_Final.Year > 1 Then Integer.TryParse(dteFREFFW_Final.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pbSTIENV_IncluirEnviados() As Boolean
            Get
                Return bSTIENV
            End Get
            Set(ByVal value As Boolean)
                bSTIENV = value
            End Set
        End Property

        Public ReadOnly Property psSTIENV_IncluirEnviados() As String
            Get
                Dim sTemp As String = "N"
                If bSTIENV Then sTemp = "S"
                Return sTemp
            End Get
        End Property
#End Region
    End Class
End Namespace