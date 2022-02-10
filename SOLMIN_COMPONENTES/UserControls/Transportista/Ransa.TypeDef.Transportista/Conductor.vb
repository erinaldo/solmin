Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_ConductorPK
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pNRUCTR_RucTransportista As String = ""
    Public pCBRCNT_Brevete As String = ""
    Public pUsuario As String = ""
#End Region
#Region " Métodos "
    Sub New()
        pCCMPN_Compania = ""
        pCBRCNT_Brevete = ""
        pNRUCTR_RucTransportista = ""
        pUsuario = ""
    End Sub

    Sub New(ByVal Compania As String, ByVal Brevete As String, ByVal Usuario As String)
        pCCMPN_Compania = Compania
        pCBRCNT_Brevete = Brevete
        pUsuario = Usuario
    End Sub

    Sub New(ByVal Compania As String, ByVal Brevete As String, ByVal Usuario As String, ByVal Transportista As String)
        pCCMPN_Compania = Compania
        pCBRCNT_Brevete = Brevete
        pNRUCTR_RucTransportista = Transportista
        pUsuario = Usuario
    End Sub

    Public Sub pClear()
        pCBRCNT_Brevete = ""
        pUsuario = ""
        pNRUCTR_RucTransportista = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información completa del Conductor
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Obj_Conductor
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCBRCNT_Brevete As String = ""
    Public pTNMCMC_NombreChofer As String = ""
    Public pAPEPAT_ApPaterno As String = ""
    Public pAPEMAT_ApMaterno As String = ""
    Public pNCLICO_TipoLicencia As String = ""
    Public pNLELCH_DocumentoIdentidad As Int64 = 0
    Public pCSGRSC_SeguroSocial As String = ""
    Public pTGRPSN_GrupoSanguineo As String = ""
    Public pFVEDNI_FechaVencDNI As Date
    Public pFEMLIC_FechaVencLicencia As Date
    Public pFVELIC_FechaVencLicencia As Date
    Public pCODSAP_CodigoSAP As String = ""
    Public pFECING_FechaIngreso As Int32 = 0
    Public pTDRCC_Direccion As String = ""
    Public pNTERPM_NroTelefonoRPM As String = ""
    Public pTOBS_Observaciones As String = ""
    Public pSINDRC_StatusRecurso As String = ""
    Public pSESTRG_StatusRegistro As String = ""
    Public pNRUCTR_RucTransportista As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCBRCNT_Brevete = ""
        pTNMCMC_NombreChofer = ""
        pAPEPAT_ApPaterno = ""
        pAPEMAT_ApMaterno = ""
        pNCLICO_TipoLicencia = ""
        pNLELCH_DocumentoIdentidad = 0
        pCSGRSC_SeguroSocial = ""
        pTGRPSN_GrupoSanguineo = ""
        pFVEDNI_FechaVencDNI = New Date
        pFEMLIC_FechaVencLicencia = New Date
        pFVELIC_FechaVencLicencia = New Date
        pCODSAP_CodigoSAP = ""
        pFECING_FechaIngreso = 0
        pTDRCC_Direccion = ""
        pNTERPM_NroTelefonoRPM = ""
        pTOBS_Observaciones = ""
        pSINDRC_StatusRecurso = ""
        pSESTRG_StatusRegistro = ""
        pNRUCTR_RucTransportista = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class

''' <summary>
''' Información Básica del Conductor
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Conductor_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCBRCNT_Brevete As String = ""
    Public pTNMCMC_NombreChofer As String = ""
    Public pAPEPAT_ApPaterno As String = ""
    Public pAPEMAT_ApMaterno As String = ""
    Public pSINDRC_StatusRecurso As String = ""
    Public pNRUCTR_RucTransportista As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCBRCNT_Brevete = ""
        pTNMCMC_NombreChofer = ""
        pAPEPAT_ApPaterno = ""
        pAPEMAT_ApMaterno = ""
        pSINDRC_StatusRecurso = ""
        pNRUCTR_RucTransportista = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub

    Public Function pNombreCompleto() As String
        Dim sTemp As String = ""
        If pTNMCMC_NombreChofer <> "" And pAPEPAT_ApPaterno <> "" And pAPEMAT_ApMaterno <> "" Then
            sTemp = pTNMCMC_NombreChofer & " " & pAPEPAT_ApPaterno & " " & pAPEMAT_ApMaterno
        Else
            If pTNMCMC_NombreChofer <> "" And pAPEPAT_ApPaterno <> "" Then
                sTemp = pTNMCMC_NombreChofer & " " & pAPEPAT_ApPaterno
            Else
                If pTNMCMC_NombreChofer <> "" Then
                    sTemp = pTNMCMC_NombreChofer
                Else
                    sTemp = ""
                End If
            End If
        End If
        Return sTemp
    End Function
#End Region
End Class

''' <summary>
''' Filtro para el Listado de Conductors para ser utilizadas en un DataGrid con opciones de Paginación
''' </summary>
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Qry_Conductor_L01
#Region " Atributos "
    Public pCCMPN_Compania As String = ""
    Public pCBRCNT_Brevete As String = ""
    Public pNombreApellidoChofer As String = ""
    Public pSINDRC_StatusRecurso As String = ""
    Public pUsuario As String = ""
    Public pNROPAG_NroPagina As Int32 = 0
    Public pREGPAG_NroRegPorPagina As Int32 = 0
    Public pNRUCTR_RucTransportista As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCBRCNT_Brevete = ""
        pNombreApellidoChofer = ""
        pSINDRC_StatusRecurso = ""
        pUsuario = ""
        pNROPAG_NroPagina = 0
        pREGPAG_NroRegPorPagina = 0
        pNRUCTR_RucTransportista = ""
    End Sub

    Public Sub pClearAll()
        pCCMPN_Compania = ""
        Call MyClass.pClear()
    End Sub
#End Region
End Class