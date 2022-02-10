Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario

Public Class clsEmbarqueDAL
  Dim dt As New DataTable
  Public Function Lista_SeguimientoAduanero(ByVal objEntidad As beEmbarqueEntidad) As DataTable
    dt = New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    dt = Nothing
    Dim oListCheckPoint As New List(Of beCheckpointConsulta)
    lobjParams.Add("PSCCMPN", objEntidad.PSCCMPN)
    lobjParams.Add("PNCCLNT", objEntidad.PNCCLNT)
    lobjParams.Add("PSNORCML", objEntidad.PSNORCML)
    lobjParams.Add("PNNRITEM_INI", objEntidad.PNNRITEM_INI)
    lobjParams.Add("PNNRITEM_FIN", objEntidad.PNNRITEM_FIN)

    dt = lobjSql.ExecuteDataTable("SP_SC_LISTA_SEGUIMIENTO_ADUANERO_VISTA_REDUCIDAS_CONSULTA", lobjParams)

    For Each Item As DataRow In dt.Rows
      Item("NORSCI") = HelpClass.ToDecimalCvr(Item("NORSCI"))
      Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
      Item("PNNMOS") = HelpClass.ToDecimalCvr(Item("PNNMOS"))
      Item("TZNFCC") = HelpClass.ToStringCvr(Item("TZNFCC"))
      Item("TPRVCL") = HelpClass.ToStringCvr(Item("TPRVCL"))
      Item("TDITES") = HelpClass.ToStringCvr(Item("TDITES"))
      Item("NDOCEM") = HelpClass.ToStringCvr(Item("NDOCEM"))
      Item("NOPRCN") = HelpClass.ToDecimalCvr(Item("NOPRCN"))
      Item("CTRMAL") = HelpClass.ToStringCvr(Item("CTRMAL"))
      Item("TNMMDT") = HelpClass.ToStringCvr(Item("TNMMDT"))
      Item("CPRTOE") = HelpClass.ToStringCvr(Item("CPRTOE"))
      Item("CPRTOA") = HelpClass.ToStringCvr(Item("CPRTOA"))
      Item("TCANAL") = HelpClass.ToStringCvr(Item("TCANAL"))
      Item("CAGNCR") = HelpClass.ToStringCvr(Item("CAGNCR"))
      Item("TCMPVP") = HelpClass.ToStringCvr(Item("TCMPVP"))
      Item("TNMCIN") = HelpClass.ToStringCvr(Item("TNMCIN"))
      Item("TNRODU") = HelpClass.ToDecimalCvr(Item("TNRODU"))
      Item("FAPREV") = HelpClass.FechaNum_a_Fecha(Item("FAPREV"))
      Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
      Item("REGIMEN") = HelpClass.ToStringCvr(Item("REGIMEN"))
      Item("DESPACHO") = HelpClass.ToStringCvr(Item("DESPACHO"))
      Item("TRANSPORTE") = HelpClass.ToStringCvr(Item("TRANSPORTE"))
      Item("SESTRG") = HelpClass.ToStringCvr(Item("SESTRG"))
      Item("SESTRG_ESTADO") = HelpClass.ToStringCvr(Item("SESTRG_ESTADO"))
    Next

    Return dt
  End Function

  Public Function LISTA_ITEMS_X_ORDEN_COMPRA_CONSULTA(ByVal obj As beEmbarqueEntidad) As DataSet

    Dim dsPrincipal As New DataSet
    Dim dsResultado As New DataSet

    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCMPN", obj.PSCCMPN)
    lobjParams.Add("PNCCLNT", obj.PNCCLNT)
    lobjParams.Add("PSNORCML", obj.PSNORCML)
    lobjParams.Add("PNNRITEM_INI", obj.PNNRITEM_INI)
    lobjParams.Add("PNNRITEM_FIN", obj.PNNRITEM_FIN)
    lobjParams.Add("PSCDVSN", obj.PSCDVSN)
    lobjParams.Add("PSCEMB", "P")
    lobjParams.Add("PSSESTRG", "A")
    dsPrincipal = lobjSql.ExecuteDataSet("SP_SOLSC_ITEMS_X_ORDEN_COMPRA_CONSULTA", lobjParams)

    dsPrincipal.Tables(0).TableName = "dtPreEmbarque"
    dsPrincipal.Tables(1).TableName = "dtDetalleCHK"
    dsPrincipal.Tables(2).TableName = "dtCHKCliente"
    'dtDetalleCHK -> formatear fechas 
    dsResultado.Tables.Add(dsPrincipal.Tables("dtPreEmbarque").Copy)

    For Each Item As DataRow In dsPrincipal.Tables("dtDetalleCHK").Rows
      Item("DFECREA") = HelpClass.FechaNum_a_Fecha(Item("DFECREA"))
      Item("DFECEST") = HelpClass.FechaNum_a_Fecha(Item("DFECEST"))
    Next
    dsResultado.Tables.Add(dsPrincipal.Tables("dtDetalleCHK").Copy)
    'dtCHKCliente
    Dim oListCHK As New List(Of String)
    Dim odtListaCHK As New DataTable
    odtListaCHK.Columns.Add("NESTDO")
    odtListaCHK.Columns.Add("TDESES")
    Dim drCHK As DataRow
    For Each ItemDr As DataRow In dsPrincipal.Tables("dtCHKCliente").Rows
      If (Not oListCHK.Contains(ItemDr("NESTDO"))) Then
        oListCHK.Add(ItemDr("NESTDO"))
        drCHK = odtListaCHK.NewRow
        drCHK("NESTDO") = ItemDr("NESTDO")
        drCHK("TDESES") = ItemDr("TCOLUM").ToString.Trim
        odtListaCHK.Rows.Add(drCHK)
      End If
    Next
    dsResultado.Tables.Add(odtListaCHK)
    dsResultado.Tables(0).TableName = "dtPreEmbarque"
    dsResultado.Tables(1).TableName = "dtDetalleCHK"
    dsResultado.Tables(2).TableName = "dtCHKCliente"

    Return dsResultado
  End Function
End Class
