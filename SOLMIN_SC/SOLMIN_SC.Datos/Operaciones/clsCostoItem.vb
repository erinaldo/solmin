Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsCostoItem

   
    Public Function Lista_Costo_Item_Resumido(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal PNPNNMOS As Decimal, ByVal FECHA_INI As Decimal, ByVal FECHA_FIN As Decimal, ByVal PSTPSRVA As String, ByVal PSSESTRG As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim cont As Integer = 0

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PCNORCML", NORCML)
        lobjParams.Add("PNPNNMOS", PNPNNMOS)
        lobjParams.Add("PNFECINI", FECHA_INI)
        lobjParams.Add("PNFECFIN", FECHA_FIN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PSSESTRG", PSSESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTO_X_ITEM_RESUMIDO_V1", lobjParams)

        dt.Columns.Add("TOTIMP", Type.GetType("System.Decimal"))

        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows

                cont = 0
                If CDec(dr("FAPRAR")) <> 0D Then
                    dr("FAPRAR") = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(dr("FAPRAR"))
                Else
                    dr("FAPRAR") = ""
                End If
                If dr("TCMPVP").ToString.Trim <> "" And dr("TNMCIN").ToString.Trim <> "" Then
                    dr("TCMPVP") = dr("TCMPVP").ToString.Trim & " / " & dr("TNMCIN").ToString.Trim
                End If
                If dr("TCMPVP").ToString.Trim <> "" And dr("TNMCIN").ToString.Trim = "" Then
                    dr("TCMPVP") = dr("TCMPVP").ToString.Trim
                ElseIf dr("TCMPVP").ToString.Trim = "" And dr("TNMCIN").ToString.Trim <> "" Then
                    dr("TCMPVP") = dr("TNMCIN").ToString.Trim
                ElseIf dr("TCMPVP").ToString.Trim = "" And dr("TNMCIN").ToString.Trim <> "" Then
                    dr("TCMPVP") = ""
                End If

                'dr("TOTIMP") = dr("TOTADV") + dr("TOTIGV") + dr("TOTIPM") + dr("TASDES")

            Next
        End If

        Return dt
    End Function

  

    Public Function Lista_Ordenes_Embarcadas_A_Distribuir(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_ORDENES_EMBARCADAS_A_DISTRIBUIR", lobjParams)
        Return dt
    End Function


    Public Function Lista_Embarques_A_Distribuir(ByVal PNCCLNT As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_EMBARQUES_A_DISTRIBUIR", lobjParams)
        Return dt
    End Function

    Public Sub Distribuir_Concepto_x_Item(ByVal obeDistribucionCostoxItemOC As beDistribucionCostoxItemOC)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDistribucionCostoxItemOC.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeDistribucionCostoxItemOC.PNCCLNT)
        lobjParams.Add("PSNORCML", obeDistribucionCostoxItemOC.PSNORCML)
        lobjParams.Add("PNNRITEM", obeDistribucionCostoxItemOC.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeDistribucionCostoxItemOC.PNNRPEMB)
        lobjParams.Add("PSCODVAR", obeDistribucionCostoxItemOC.PSCODVAR)
        lobjParams.Add("PNIVLDOL", obeDistribucionCostoxItemOC.PNIVLDOL)
        lobjParams.Add("PNIVLORG", obeDistribucionCostoxItemOC.PNIVLORG)
        lobjParams.Add("PNCMNDA1", obeDistribucionCostoxItemOC.PNCMNDA1)
        lobjParams.Add("PSNMONOC", obeDistribucionCostoxItemOC.PSNMONOC)
        lobjParams.Add("PNQRLCSC", obeDistribucionCostoxItemOC.PNQRLCSC)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_DISTRIBUCION_COSTOS_X_ITEM", lobjParams)
    End Sub
    Public Function Lista_Costos_Agencias_X_OS(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNPNNMOS As Decimal) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNPNNMOS", PNPNNMOS)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_LISTAR_DETALLE_COSTOS_EMBARQUE_RUBRO_AGENCIA_X_OS_V2", lobjParams)
        Return ds
    End Function


    Public Function Lista_Item_Cierre_Orden_Compra(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_ITEMS_CIERRE_OC", lobjParams)
        ds.Tables(0).TableName = "dtItemOC"
        ds.Tables(1).TableName = "dtItemEmb"
        Return ds
    End Function


    Public Function Lista_Item_Cierre_Orden_Compra_Embarcado(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_ITEMS_CIERRE_OC_EMBARCADOS", lobjParams)
        Return dt
    End Function



End Class
