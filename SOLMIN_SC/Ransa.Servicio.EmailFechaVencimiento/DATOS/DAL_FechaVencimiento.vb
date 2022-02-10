Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class DAL_FechaVencimiento

    Public Function Listar_Regimen_X_Vencer_Envio(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal) As List(Of BE_Regimen)
        Dim lobjSql As New SqlManager
        Dim odt As New DataTable
        Dim obeRegimen As BE_Regimen
        Dim oListRegimen As New List(Of BE_Regimen)
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_REGIMEN_X_VENCER_CLIENTE_ENVIO_EMAIL", lobjParams)
        For Each Item As DataRow In odt.Rows
            obeRegimen = New BE_Regimen
            obeRegimen.PNNORSCI = Item("NORSCI")
            obeRegimen.PSFORSCI = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            obeRegimen.PSREGIMEN = HelpClass.ToStringCvr(Item("REGIMEN"))
            'obeRegimen.PNNTPODT = Item("NTPODT")
            'obeRegimen.PNNCODRG = Item("NCODRG")
            obeRegimen.PSFECINI = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
            obeRegimen.PSFECVEN = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
            'obeRegimen.PSTOBSRL = HelpClass.ToStringCvr(Item("TOBSRL"))
            If Item("PNNMOS") = "0" Then
                obeRegimen.PSPNNMOS = ""
            Else
                obeRegimen.PSPNNMOS = HelpClass.ToStringCvr(Item("PNNMOS"))
            End If
            oListRegimen.Add(obeRegimen)
        Next
        Return oListRegimen
    End Function

    Public Function Listar_TipoCarga_X_Vencer_Envio(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal) As List(Of BE_TipoCarga)
        Dim lobjSql As New SqlManager
        Dim odt As New DataTable
        Dim obeTipoCarga As BE_TipoCarga
        Dim oListTipoCarga As New List(Of BE_TipoCarga)
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPOCARGA_X_VENCER_CLIENTE_ENVIO_EMAIL", lobjParams)
        For Each Item As DataRow In odt.Rows
            obeTipoCarga = New BE_TipoCarga
            obeTipoCarga.PNNORSCI = Item("NORSCI")
            obeTipoCarga.PSFORSCI = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            obeTipoCarga.PSTIPO_CARGA = HelpClass.ToStringCvr(Item("TIPO_CARGA"))
            obeTipoCarga.PNNTPODT = Item("NTPODT")
            obeTipoCarga.PNNCODRG = Item("NCODRG")
            obeTipoCarga.PSFECINI = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
            obeTipoCarga.PSFECVEN = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
            obeTipoCarga.PSTOBSRL = Item("TOBSRL")
            If Item("PNNMOS") = "0" Then
                obeTipoCarga.PSPNNMOS = ""
            Else
                obeTipoCarga.PSPNNMOS = HelpClass.ToStringCvr(Item("PNNMOS"))
            End If
            obeTipoCarga.PNQCANTI = Item("QCANTI")
            oListTipoCarga.Add(obeTipoCarga)
        Next
        Return oListTipoCarga
    End Function

    Public Function Listar_CartaFianza_X_Vencer_Envio(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal) As List(Of BE_CartaFianza)
        Dim lobjSql As New SqlManager
        Dim odt As New DataTable
        Dim oListCartaFianza As New List(Of BE_CartaFianza)
        Dim obecartaFianza As BE_CartaFianza
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_CARTA_FIANZA_X_VENCER_ENVIO_EMAIL", lobjParams)
        For Each Item As DataRow In odt.Rows
            obecartaFianza = New BE_CartaFianza
            obecartaFianza.PNNORSCI = Item("NORSCI")
            obecartaFianza.PSFORSCI = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            obecartaFianza.PSNDOCUM = HelpClass.ToStringCvr(Item("NDOCUM"))
            obecartaFianza.PNCBNCFN = Item("CBNCFN")
            obecartaFianza.PSTCMBCF = HelpClass.ToStringCvr(Item("TCMBCF"))
            obecartaFianza.PSFECINI = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
            obecartaFianza.PSFECVEN = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
            obecartaFianza.PNITTDOC = Item("ITTDOC")
            obecartaFianza.PSNMONOC = HelpClass.ToStringCvr(Item("NMONOC"))
            obecartaFianza.PNCMNDA1 = Item("CMNDA1")
            If Item("PNNMOS") = "0" Then
                obecartaFianza.PSPNNMOS = ""
            Else
                obecartaFianza.PSPNNMOS = HelpClass.ToStringCvr(Item("PNNMOS"))
            End If
            oListCartaFianza.Add(obecartaFianza)
        Next
        Return oListCartaFianza
    End Function

    'Public Function listaDestinatarioEnvio(ByVal PSLISCLIENTE As String) As List(Of BE_Destinatario)
    '    Dim oListDestinatario As New List(Of BE_Destinatario)
    '    Dim obeDestinatario As BE_Destinatario
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim odt As New DataTable
    '    lobjParams.Add("PSLISCLIENTE", PSLISCLIENTE)
    '    odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_EMAIL_ENVIO_FECHA_VENCIMIENTO", lobjParams)
    '    For Each Item As DataRow In odt.Rows
    '        obeDestinatario = New BE_Destinatario
    '        obeDestinatario.PNCCLNT = Item("CCLNT")
    '        obeDestinatario.PSTCMPCL = ("" & Item("TCMPCL")).ToString.Trim
    '        obeDestinatario.PSEMAILTO = ("" & Item("EMAILTO")).ToString.Trim
    '        obeDestinatario.PSNLTECL = ("" & Item("NLTECL")).ToString.Trim
    '        'obeDestinatario.PS_CCLNT_NLTECL = Item("CCLNT") & "_" & ("" & Item("NLTECL")).ToString.Trim
    '        oListDestinatario.Add(obeDestinatario)
    '    Next
    '    Return oListDestinatario
    'End Function
    Public Function listaDestinatarioEnvio() As List(Of BE_Destinatario)
        Dim oListDestinatario As New List(Of BE_Destinatario)
        Dim obeDestinatario As BE_Destinatario
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim odt As New DataTable
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_EMAIL_ENVIO_FECHA_VENCIMIENTO", lobjParams)
        For Each Item As DataRow In odt.Rows
            obeDestinatario = New BE_Destinatario
            obeDestinatario.PNCCLNT = Item("CCLNT")
            obeDestinatario.PSTCMPCL = ("" & Item("TCMPCL")).ToString.Trim
            obeDestinatario.PSEMAILTO = ("" & Item("EMAILTO")).ToString.Trim
            obeDestinatario.PSNLTECL = ("" & Item("NLTECL")).ToString.Trim
            oListDestinatario.Add(obeDestinatario)
        Next
        Return oListDestinatario
    End Function


End Class
