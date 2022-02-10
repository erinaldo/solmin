Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_ExportInf_F01
#Region " Tipos "
    Enum TipoTransmision
        TodosRegistros
        PenEnvRecep
        PenEnvRecepYEnviados
        PenEnvDesp
        PenEnvDespYEnviados
    End Enum

    Enum Sentido
        Recepcion
        Despacho
        SinConsiderar
    End Enum

    Enum Formato
        Ellipse
        SAP
        SinConsiderar
    End Enum
#End Region
#Region " Atributos "
    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pCREFFW_CodigoBulto As String = ""
    Public pFechaInicial As Date
    Public pFechaFinal As Date
    Public pTTINTC_TermInterCarga As String = ""
    Public pTUBRFR_Ubicacion As String = ""
    'Public pNROPLT_NroPaletizado As String = ""
    'Public pCRTLTE_CriterioLote As String = ""
    Public pSTPING_TipoMovimiento As String = ""
    Private pStatusTransmision As TipoTransmision
    Public pOperacion As Sentido = Sentido.SinConsiderar
    Public pFormatFile As Formato = Formato.SinConsiderar
    Public pUpdateInf As Boolean = False
    Public pUsuario As String = ""
    Public _PSCCMPN As String = ""
    Public _PSCDVSN As String = ""
    Public _PNCPLNDV As Decimal = 0


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
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property


    Public ReadOnly Property pFechaInicial_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFechaInicial.Year > 1 Then Int32.TryParse(pFechaInicial.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public ReadOnly Property pFechaFinal_FNum() As Int32
        Get
            Dim intTemp As Int32 = 0
            If pFechaFinal.Year > 1 Then Int32.TryParse(pFechaFinal.ToString("yyyyMMdd"), intTemp)
            Return intTemp
        End Get
    End Property

    Public Property pSTRNSM_StatusTransmisionEnum() As TipoTransmision
        Set(ByVal value As TipoTransmision)
            pStatusTransmision = value
        End Set
        Get
            Return pStatusTransmision
        End Get
    End Property

    Public ReadOnly Property pSTRNSM_StatusTransmision() As String
        Get
            Dim sTemp As String = ""
            Select Case pStatusTransmision
                Case TipoTransmision.TodosRegistros
                    sTemp = ""
                Case TipoTransmision.PenEnvRecep
                    sTemp = "P"
                Case TipoTransmision.PenEnvRecepYEnviados
                    sTemp = "R"
                Case TipoTransmision.PenEnvDesp
                    sTemp = "D"
                Case TipoTransmision.PenEnvDespYEnviados
                    sTemp = "E"
            End Select
            Return sTemp
        End Get
    End Property

    Public ReadOnly Property pSTUPDT_UpdateInf() As String
        Get
            Dim sTemp As String = "N"
            If pUpdateInf Then sTemp = "S"
            Return sTemp
        End Get
    End Property
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCLNT_CodigoCliente = 0
        pCREFFW_CodigoBulto = ""
        pFechaInicial = New Date
        pFechaFinal = New Date
        pTTINTC_TermInterCarga = ""
        pTUBRFR_Ubicacion = ""
        'pNROPLT_NroPaletizado = ""
        'pCRTLTE_CriterioLote = ""
        pSTPING_TipoMovimiento = ""
        pStatusTransmision = TipoTransmision.TodosRegistros
        pOperacion = Sentido.SinConsiderar
        pFormatFile = Formato.SinConsiderar
        pUsuario = ""
    End Sub
#End Region
End Class