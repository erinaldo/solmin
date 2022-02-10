Imports System.Runtime.InteropServices

Namespace GuiaRemision


    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_GuiaRemisionPK

#Region "Atributos"
        'Parametros de la hoja al procedure

        Public _PSCCMPN As String = ""
        Public _PSCDVSN As String = ""

        Public _PNCPLNDV As Decimal = 0
        Public _PNCCLNT As Decimal = 0
        Public _PNCCLNGR As Decimal = 0
        Public GUIASALIDA As Decimal = 0


        Public _NORCML As String = ""
        'Elementos de la grilla a cargar
        Public _NGUIRM As Decimal = 0
        Public _FGUIRM As String = ""
        Public _MOTTRA As String = ""
        Public _TNMMDT As String = ""
        Public _SITUAC As String = ""
        Public _NPLACP As String = ""

        Public _NPLCCM As String = ""
        Public _NBRVCH As String = ""
        Public _TCMPTR As String = ""

        Public _QCNPEN As Integer = 0
        Public _QCNREC As Integer = 0



        Public PAGESIZE As Double = 0
        Public PAGENUMBER As Double = 0
        Public PAGECOUNT As Double = 0

        'Elementos de la página 
        Public pFGUIRM_FechaGR_Inicio As Date
        Public pFGUIRM_FechaGR_Fin As Date
        Public pNROPAG_NroPagina As Int32 = 0
        Public pREGPAG_NroRegPorPagina As Int32 = 0
        'Public pTCNDPG_CondicionPago As String = ""
        Private _pTCNDPG_CondicionPago As String = ""
        Public pSFLGES_FlagEstado As String = ""
















        Public Property pTCNDPG_CondicionPago() As String
            Get
                Return _pTCNDPG_CondicionPago
            End Get
            Set(ByVal value As String)
                _pTCNDPG_CondicionPago = value
            End Set
        End Property

#End Region
#Region " Métodos "

#End Region
#Region "Procedimientos y Métodos"

#End Region
    End Class


    Public Class TD_GuiaRemision
        Public pCCLNT_CodigoCliente As Int64 = 0
        Public pNORCML_NroOrdenCompra As String = ""
        Public pTPOOCM_TipoOC As String = ""
        Public pCPRVCL_CodigoClienteTercero As Int32 = 0
        Public pFORCML_FechaOCDte As Date
        Public pFSOLIC_FechaSolicOCDte As Date
        Public pTDSCML_Descripcion As String = ""
        Public pTCMAEM_DescAreaEmpresa As String = ""
        Public pTTINTC_TerminoIntern As String = ""
        Public pNREFCL_ReferenciaCliente As String = ""
        Public pTPAGME_TerminoPago As String = ""
        Public pREFDO1_ReferenciaDocumento As String = ""
        Public pNTPDES_Prioridad As Integer = 0
        Public pCMNDA1_Moneda As Int32 = 0
        Public pTEMPFAC_EmpresaFacturar As String = ""
        Public pTNOMCOM_NombreComprador As String = ""
        Public pTCTCST_CentroCosto As String = ""
        Public pCREGEMB_RegEmbarque As String = ""
        Public pCMEDTR_MedioTransporte As Int32 = 0
        Public pTDEFIN_DestinoFinal As String = ""
        Public pIVCOTO_ImporteCostoTotal As Decimal = 0.0
        Public pIVTOCO_ImporteTotalCompra As Decimal = 0.0
        Public pIVTOIM_ImporteTotalImpuesto As Decimal = 0.0
        Public pTDAITM_Observaciones As String = ""
        Public pNTRMNL_Terminal As String = ""
        Private _pTCNDPG_CondicionPago As String = ""
        Public pTRSCN_NombreContacto As String = ""
        Public pTLFNO2_TelefonoContacto As String = ""
        Public pTEMAI3_EmailContacto As String = ""

        Public Property pTCNDPG_CondicionPago() As String
            Get
                Return _pTCNDPG_CondicionPago
            End Get
            Set(ByVal value As String)
                _pTCNDPG_CondicionPago = value
            End Set
        End Property



        Public ReadOnly Property pFORCML_FechaOCInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFORCML_FechaOCDte.Year > 1 Then Int32.TryParse(pFORCML_FechaOCDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public ReadOnly Property pFSOLIC_FechaSolicOCInt() As Int32
            Get
                Dim intTemp As Int32 = 0
                If pFSOLIC_FechaSolicOCDte.Year > 1 Then Int32.TryParse(pFSOLIC_FechaSolicOCDte.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property
    End Class


    Public Class TD_QRY_GuiaRemision_L01
        Public NGUIRM As Decimal = 0
        Public PNCCLNT As Decimal = 0
        Public PSCCMPN As String = ""
        Public PSCDVSN As String = ""
        Public PNCPLNDV As Decimal = 0
        Public PNCCLNGR As Decimal = 0
        Public GUIASALIDA As Decimal = 0
        Public NORCML As String = ""

        Public PAGESIZE As Int64 = 0
        Public PAGENUMBER As Int64 = 0
 

        Public pFGUIRM_FechaGR_Inicio As String
        Public pFGUIRM_FechaGR_Fin As String
        Public pNROPAG_NroPagina As Int32 = 0
        Public pREGPAG_NroRegPorPagina As Int32 = 0

 

  
        'Public Property GUIASALIDA() As Decimal
        '    Get
        '        Return _GUIASALIDA
        '    End Get
        '    Set(ByVal value As Decimal)
        '        _GUIASALIDA = value
        '    End Set
        'End Property

        'Public Property PNCCLNGR() As Decimal
        '    Get
        '        Return _PNCCLNGR
        '    End Get
        '    Set(ByVal value As Decimal)
        '        _PNCCLNGR = value
        '    End Set
        'End Property

        'Public Property PNCCLNT() As Decimal
        '    Get
        '        Return _PNCCLNT
        '    End Get
        '    Set(ByVal value As Decimal)
        '        _PNCCLNT = value
        '    End Set
        'End Property

        'Public Property PSCCMPN() As String
        '    Get
        '        Return _PSCCMPN
        '    End Get
        '    Set(ByVal value As String)
        '        _PSCCMPN = value
        '    End Set
        'End Property


        'Public Property PSCDVSN() As String
        '    Get
        '        Return _PSCDVSN
        '    End Get
        '    Set(ByVal value As String)
        '        _PSCDVSN = value
        '    End Set
        'End Property

        'Public Property PNCPLNDV() As Decimal
        '    Get
        '        Return _PNCPLNDV
        '    End Get
        '    Set(ByVal value As Decimal)
        '        _PNCPLNDV = value
        '    End Set
        'End Property




    End Class






End Namespace

