Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class RutaMilpo
    'Public Ruta_QA_Milpo As String = "http://interfacepiqas.votorantim.com.br/XISOAPAdapter/MessageServlet?senderParty=PY_MILPO_RANSA&senderService=BC_RANSA_SERVICES_QA&receiverParty=&receiverService=&interface=SI_EnvioDespachos_Ransa_Out&interfaceNamespace=http://vm.milpo.ransa.enviodespachos"
    'Public Ruta_PRD_Milpo As String
    'Public Ruta_DET_Milpo As String

    Public Usuario As String = "XMPIRANSA"
    Public Clave As String = "b)W$(Gf~%$3]S>i$RewV6[znpGX%9ip[zgQHqUY}"


    Public Function RutaServerMilpo() As String
        Dim Url As String = ""
        If ConfigurationWizard.Library() = "DC@RNSLIB" Then
            Url = "http://integracion.gromero.com.pe/milpo/prd/ConfirmacionDespacho"
        Else
            Url = "http://integracion.gromero.com.pe/milpo/qas/ConfirmacionDespacho"
        End If
        Return Url
    End Function

End Class
