Imports System.Xml

Namespace slnSOLMIN_SAT.PreDespacho
    Public Class clsInformacion_AgregarBultoPreDespacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private strCRTLTE As String = ""
        Private intNROCTL As Int32 = 0
        Private strSTPDES As String = ""
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

        Public Property pstrCriterioLote_CRTLTE() As String
            Get
                Return strCRTLTE
            End Get
            Set(ByVal value As String)
                strCRTLTE = value
            End Set
        End Property

        Public Property pintNroControl_NROCTL() As Int32
            Get
                Return intNROCTL
            End Get
            Set(ByVal value As Int32)
                intNROCTL = value
            End Set
        End Property

        Public Property psSTPDES() As String
            Get
                Return strSTPDES
            End Get
            Set(ByVal value As String)
                strSTPDES = value
            End Set
        End Property

#End Region
    End Class

    Public Class clsInformacion_PreDespacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private intNROCTL As Int32 = 0
        Private intNITEMS As Int32 = 0
        Private strCRTLTE As String = ""
        Private strSMTRCP As String = ""
        Private strSMTRCP_Detalle As String = ""
        Private strSSNCRG As String = ""
        Private strSSNCRG_Detalle As String = ""
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

        Public Property pintNroControl_NROCTL() As Int32
            Get
                Return intNROCTL
            End Get
            Set(ByVal value As Int32)
                intNROCTL = value
            End Set
        End Property

        Public Property pintNroItems() As Int32
            Get
                Return intNITEMS
            End Get
            Set(ByVal value As Int32)
                intNITEMS = value
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

        Public Property pstrMotivoRecepcion_SMTRCP() As String
            Get
                Return strSMTRCP
            End Get
            Set(ByVal value As String)
                strSMTRCP = value
            End Set
        End Property

        Public Property pstrMotivoRecepcionDetalle_SMTRCP() As String
            Get
                Return strSMTRCP_Detalle
            End Get
            Set(ByVal value As String)
                strSMTRCP_Detalle = value
            End Set
        End Property

        Public Property pstrSentidoCarga_SSNCRG() As String
            Get
                Return strSSNCRG
            End Get
            Set(ByVal value As String)
                strSSNCRG = value
            End Set
        End Property

        Public Property pstrSentidoCargaDetalle_SSNCRG() As String
            Get
                Return strSSNCRG_Detalle
            End Get
            Set(ByVal value As String)
                strSSNCRG_Detalle = value
            End Set
        End Property
#End Region
    End Class

    ' Clases mejoradas
    Public Class clsLugarDestinoBulto
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private intCOUNT As Integer = 0
        Private strTLUGEN As String = ""
        Private intNROPLT As Int64 = 0
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                pstrCodigoRecepcion_CREFFW = strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pintNroOcurrenciaDistinta() As Integer
            Get
                pintNroOcurrenciaDistinta = intCOUNT
            End Get
            Set(ByVal value As Integer)
                intCOUNT = value
            End Set
        End Property

        Public Property pstrLugarEntrega_TLUGEN() As String
            Get
                pstrLugarEntrega_TLUGEN = strTLUGEN
            End Get
            Set(ByVal value As String)
                strTLUGEN = value
            End Set
        End Property

        Public Property pintNroPaletizado_NROPLT() As Int64
            Get
                pintNroPaletizado_NROPLT = intNROPLT
            End Get
            Set(ByVal value As Int64)
                intNROPLT = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsBultosParaPreDespacho
#Region " Tipo de Datos "
        Structure BultoParaPreDespacho
            Dim pstrCodigoRecepcion_CREFFW As String
            Dim pintNroPaletizado_NROPLT As Int64
        End Structure
#End Region
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCRTLTE As String
        Private lstCREFFW As List(Of BultoParaPreDespacho)
#End Region
#Region " Propiedades "
        Sub New()
            lstCREFFW = New List(Of BultoParaPreDespacho)
        End Sub

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCriterioLote_CRTLTE() As String
            Get
                pstrCriterioLote_CRTLTE = strCRTLTE
            End Get
            Set(ByVal value As String)
                strCRTLTE = value
            End Set
        End Property

        Public Sub pAdd_BultoParaPreDespacho(ByVal Bulto As BultoParaPreDespacho)
            lstCREFFW.Add(Bulto)
        End Sub

        Public Sub pDel_BultoParaPreDespacho(ByVal Bulto As BultoParaPreDespacho)
            lstCREFFW.Remove(Bulto)
        End Sub

        Public Function pBultos() As List(Of BultoParaPreDespacho)
            Return lstCREFFW
        End Function

        Public Function pCount_BultoParaPreDespacho() As Integer
            Return lstCREFFW.Count
        End Function
#End Region
    End Class

    '---------------------------'
    '-- Pre-Despacho para PDT --'
    '---------------------------'
    Public Class clsWSListaPreDespachos
#Region "Atributos"
        Dim lstPreDespachos As List(Of clsWSPreDespacho)
#End Region
#Region "Propiedades"
        Sub New()
            lstPreDespachos = New List(Of clsWSPreDespacho)
        End Sub

        Public ReadOnly Property plstWSPreDespachos() As List(Of clsWSPreDespacho)
            Get
                Return lstPreDespachos
            End Get
        End Property

        Public Sub AddPreDespacho(ByVal objWSPreDespacho As clsWSPreDespacho)
            lstPreDespachos.Add(objWSPreDespacho)
        End Sub

        Public Sub DeletePreDespacho(ByVal objWSPreDespacho As clsWSPreDespacho)
            lstPreDespachos.Remove(objWSPreDespacho)
        End Sub
#End Region
    End Class

    Public Class clsWSPreDespacho
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private intCTRSPT As Int32 = 0
        Private strNPLCUN As String = ""
        Private strNPLCAC As String = ""
        Private strCBRCNT As String = ""
        Private lstListaPaletas As List(Of Int64)
#End Region
#Region "Propiedades"
        Sub New()
            lstListaPaletas = New List(Of Int64)
        End Sub

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pintCodigoTransportista_CTRSPT() As Int32
            Get
                Return intCTRSPT
            End Get
            Set(ByVal value As Int32)
                intCTRSPT = value
            End Set
        End Property

        Public Property pstrNroPlacaUnidad_NPLCUN() As String
            Get
                Return strNPLCUN
            End Get
            Set(ByVal value As String)
                strNPLCUN = value
            End Set
        End Property

        Public Property pstrNroPlacaAcoplado_NPLCAC() As String
            Get
                Return strNPLCAC
            End Get
            Set(ByVal value As String)
                strNPLCAC = value
            End Set
        End Property

        Public Property pstrCodigoBreveteTransportista_CBRCNT() As String
            Get
                Return strCBRCNT
            End Get
            Set(ByVal value As String)
                strCBRCNT = value
            End Set
        End Property

        Public ReadOnly Property plstWSPaletas() As List(Of Int64)
            Get
                Return lstListaPaletas
            End Get
        End Property

        Public Sub AgregarPaleta(ByVal intNroPaleta As Int64)
            lstListaPaletas.Add(intNroPaleta)
        End Sub

        Public Function NroPaletasRegistradas() As Integer
            Return lstListaPaletas.Count
        End Function

        Public Sub EliminarPaleta(ByVal intNroPaleta As Int64)
            lstListaPaletas.Remove(intNroPaleta)
        End Sub
#End Region
    End Class

    Public Class clsWSErrorPreDespacho
#Region "Atributos"
        Private XMLError As XmlDocument
#End Region
#Region "Propiedades"
        Sub New()
            ' Documento XML detallando el Error de los registros
            XMLError = New XmlDocument()
            ' Write down the XML declaration
            Dim xmlDeclaration As XmlDeclaration = XMLError.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            ' Create the root element
            Dim rootNode As XmlElement = XMLError.CreateElement("ERRORES")
            XMLError.InsertBefore(xmlDeclaration, XMLError.DocumentElement)
            XMLError.AppendChild(rootNode)
        End Sub

        Public ReadOnly Property xmlErrorMsg() As XmlDocument
            Get
                Return XMLError
            End Get
        End Property

        Public Sub pAddError(ByVal strErrorCode As String, ByVal strMensajeError As String, ByVal strCliente As String, ByVal strEmpTransporte As String, _
                             ByVal strUnidadTransporte As String, ByVal strAcoplado As String, ByVal strBrevete As String, ByVal strNroPaleta As String)
            Dim parentNode As XmlElement = Nothing
            Dim itemNode As XmlElement = Nothing

            parentNode = XMLError.CreateElement("ERRORPREDESPACHO")
            XMLError.DocumentElement.PrependChild(parentNode)

            ' Crea los nodos requeridos de la cabecera
            Dim ErrorCode_Node As XmlElement = XMLError.CreateElement("ERRCOD")
            Dim ErrorMsg_Node As XmlElement = XMLError.CreateElement("ERRMSG")
            Dim Cliente_Node As XmlElement = XMLError.CreateElement("CCLNT")
            Dim EmpTransporte_Node As XmlElement = XMLError.CreateElement("CTRSPT")
            Dim UnidadTransporte_Node As XmlElement = XMLError.CreateElement("NPLCUN")
            Dim Acoplado_Node As XmlElement = XMLError.CreateElement("NPLCAC")
            Dim Brevete_Node As XmlElement = XMLError.CreateElement("CBRCNT")
            Dim NroPaleta_Node As XmlElement = XMLError.CreateElement("NROPLT")

            ' Asigna los valores respectivos a los nodos de la cabecera
            Dim ErrorCode_Text As XmlText = XMLError.CreateTextNode(strErrorCode)
            Dim ErrorMsg_Text As XmlText = XMLError.CreateTextNode(strMensajeError)
            Dim Cliente_Text As XmlText = XMLError.CreateTextNode(strCliente)
            Dim EmpTransporte_Text As XmlText = XMLError.CreateTextNode(strEmpTransporte)
            Dim UnidadTransporte_Text As XmlText = XMLError.CreateTextNode(strUnidadTransporte)
            Dim Acoplado_Text As XmlText = XMLError.CreateTextNode(strAcoplado)
            Dim Brevete_Text As XmlText = XMLError.CreateTextNode(strBrevete)
            Dim NroPaleta_Text As XmlText = XMLError.CreateTextNode(strNroPaleta)

            ' Añade los nodos al nodo padre son los valores
            parentNode.AppendChild(ErrorCode_Node)
            parentNode.AppendChild(ErrorMsg_Node)
            parentNode.AppendChild(Cliente_Node)
            parentNode.AppendChild(EmpTransporte_Node)
            parentNode.AppendChild(UnidadTransporte_Node)
            parentNode.AppendChild(Acoplado_Node)
            parentNode.AppendChild(Brevete_Node)
            parentNode.AppendChild(NroPaleta_Node)


            ' Se guarda los valores en los respectivos nodos
            ErrorCode_Node.AppendChild(ErrorCode_Text)
            ErrorMsg_Node.AppendChild(ErrorMsg_Text)
            Cliente_Node.AppendChild(Cliente_Text)
            EmpTransporte_Node.AppendChild(EmpTransporte_Text)
            UnidadTransporte_Node.AppendChild(UnidadTransporte_Text)
            Acoplado_Node.AppendChild(Acoplado_Text)
            Brevete_Node.AppendChild(Brevete_Text)
            NroPaleta_Node.AppendChild(NroPaleta_Text)
        End Sub
#End Region
    End Class

    '-----------------------------------'
    '-- Verificación Paletas para PDT --'
    '-----------------------------------'
    Public Class clsWSListaPaletasVerifidasPorCliente
#Region "Atributos"
        Private lstWSPaletasVerificadasPorCliente As List(Of clsWSPaletasVerificadasPorCliente) = New List(Of clsWSPaletasVerificadasPorCliente)
#End Region
#Region "Propiedades"
        Sub New()
            lstWSPaletasVerificadasPorCliente = New List(Of clsWSPaletasVerificadasPorCliente)
        End Sub

        Public ReadOnly Property Items() As List(Of clsWSPaletasVerificadasPorCliente)
            Get
                Return lstWSPaletasVerificadasPorCliente
            End Get
        End Property

        Public Sub Add(ByVal objWSPaletasVerificadasPorCliente As clsWSPaletasVerificadasPorCliente)
            lstWSPaletasVerificadasPorCliente.Add(objWSPaletasVerificadasPorCliente)
        End Sub

        Public Sub Delete(ByVal objWSPaletasVerificadasPorCliente As clsWSPaletasVerificadasPorCliente)
            lstWSPaletasVerificadasPorCliente.Remove(objWSPaletasVerificadasPorCliente)
        End Sub
#End Region
    End Class

    Public Class clsWSPaletasVerificadasPorCliente
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private intNROPLT As Int64 = 0
        Private lstPaletaVerificada As List(Of clsWSPaletaVerificada)
#End Region
#Region "Propiedades"
        Sub New()
            lstPaletaVerificada = New List(Of clsWSPaletaVerificada)
        End Sub

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public ReadOnly Property Items() As List(Of clsWSPaletaVerificada)
            Get
                Return lstPaletaVerificada
            End Get
        End Property

        Public Sub Add(ByVal objWSPaletaVerificada As clsWSPaletaVerificada)
            lstPaletaVerificada.Add(objWSPaletaVerificada)
        End Sub

        Public Sub Delete(ByVal objWSPaletaVerificada As clsWSPaletaVerificada)
            lstPaletaVerificada.Remove(objWSPaletaVerificada)
        End Sub
#End Region
    End Class

    Public Class clsWSPaletaVerificada
#Region "Atributos"
        Private strCUSVFN As String = ""
        Private intNROPLT As Int64 = 0
        Private intFCHVFN As Int32 = 0
        Private intHRAVFN As Int32 = 0
#End Region
#Region "Propiedades"
        Public Property pstrUsuarioVerifica() As String
            Get
                Return strCUSVFN
            End Get
            Set(ByVal value As String)
                strCUSVFN = value
            End Set
        End Property

        Public Property pintNroPaleta_NROPLT() As Int64
            Get
                Return intNROPLT
            End Get
            Set(ByVal value As Int64)
                intNROPLT = value
            End Set
        End Property

        Public Property pintFechaVerifica() As Int32
            Get
                Return intFCHVFN
            End Get
            Set(ByVal value As Int32)
                intFCHVFN = value
            End Set
        End Property

        Public Property pintHoraVerifica() As Int32
            Get
                Return intHRAVFN
            End Get
            Set(ByVal value As Int32)
                intHRAVFN = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsWSErrorPaletasVerificadas
#Region "Atributos"
        Private XMLError As XmlDocument
#End Region
#Region "Propiedades"
        Sub New()
            ' Documento XML detallando el Error de los registros
            XMLError = New XmlDocument()
            ' Write down the XML declaration
            Dim xmlDeclaration As XmlDeclaration = XMLError.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            ' Create the root element
            Dim rootNode As XmlElement = XMLError.CreateElement("ERRORES")
            XMLError.InsertBefore(xmlDeclaration, XMLError.DocumentElement)
            XMLError.AppendChild(rootNode)
        End Sub

        Public ReadOnly Property xmlErrorMsg() As XmlDocument
            Get
                Return XMLError
            End Get
        End Property

        Public Sub pAddError(ByVal strErrorCode As String, ByVal strMensajeError As String, ByVal strCliente As String, ByVal strNroPaleta As String, _
                             ByVal strUsuario As String, ByVal strFecha As String, ByVal strHora As String)
            Dim parentNode As XmlElement = Nothing
            Dim itemNode As XmlElement = Nothing

            parentNode = XMLError.CreateElement("ERRORVERIFICACION")
            XMLError.DocumentElement.PrependChild(parentNode)

            ' Crea los nodos requeridos de la cabecera
            Dim ErrorCode_Node As XmlElement = XMLError.CreateElement("ERRCOD")
            Dim ErrorMsg_Node As XmlElement = XMLError.CreateElement("ERRMSG")
            Dim Cliente_Node As XmlElement = XMLError.CreateElement("CCLNT")
            Dim NroPaleta_Node As XmlElement = XMLError.CreateElement("NROPLT")
            Dim UsuarioVerificacion_Node As XmlElement = XMLError.CreateElement("CUSVFN")
            Dim FechaVerificacion_Node As XmlElement = XMLError.CreateElement("FCHVFN")
            Dim HoraVerificacion_Node As XmlElement = XMLError.CreateElement("HRAVFN")

            ' Asigna los valores respectivos a los nodos de la cabecera
            Dim ErrorCode_Text As XmlText = XMLError.CreateTextNode(strErrorCode)
            Dim ErrorMsg_Text As XmlText = XMLError.CreateTextNode(strMensajeError)
            Dim Cliente_Text As XmlText = XMLError.CreateTextNode(strCliente)
            Dim NroPaleta_Text As XmlText = XMLError.CreateTextNode(strNroPaleta)
            Dim UsuarioVerificacion_Text As XmlText = XMLError.CreateTextNode(strUsuario)
            Dim FechaVerificacion_Text As XmlText = XMLError.CreateTextNode(strFecha)
            Dim HoraVerificacion_Text As XmlText = XMLError.CreateTextNode(strHora)


            ' Añade los nodos al nodo padre son los valores
            parentNode.AppendChild(ErrorCode_Node)
            parentNode.AppendChild(ErrorMsg_Node)
            parentNode.AppendChild(Cliente_Node)
            parentNode.AppendChild(NroPaleta_Node)
            parentNode.AppendChild(UsuarioVerificacion_Node)
            parentNode.AppendChild(FechaVerificacion_Node)
            parentNode.AppendChild(HoraVerificacion_Node)

            ' Se guarda los valores en los respectivos nodos
            ErrorCode_Node.AppendChild(ErrorCode_Text)
            ErrorMsg_Node.AppendChild(ErrorMsg_Text)
            Cliente_Node.AppendChild(Cliente_Text)
            NroPaleta_Node.AppendChild(NroPaleta_Text)
            UsuarioVerificacion_Node.AppendChild(UsuarioVerificacion_Text)
            FechaVerificacion_Node.AppendChild(FechaVerificacion_Text)
            HoraVerificacion_Node.AppendChild(HoraVerificacion_Text)
        End Sub
#End Region
    End Class
End Namespace