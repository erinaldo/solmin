Imports SOLMIN_SC.Entidad
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class clsResumenTipoCarga
  Public Function ListarEmbarqueTipoCarga(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECHA_INICIAL As Decimal, ByVal PNFECHA_FINAL As Decimal, ByVal PSTPSRVA As String) As List(Of beTipoCarga)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim oLiistTipoCarga As New List(Of beTipoCarga)
    Dim obeTipoCarga As beTipoCarga
    Dim dt As New DataTable
    lobjParams.Add("PSCCMPN", PSCCMPN)
    lobjParams.Add("PNCCLNT", PNCCLNT)
    lobjParams.Add("PNFECHA_INICIAL", PNFECHA_INICIAL)
    lobjParams.Add("PNFECHA_FINAL", PNFECHA_FINAL)
    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_EMBARQUE_X_CLIENTE", lobjParams)
    For Each Item As DataRow In dt.Rows
      obeTipoCarga = New beTipoCarga
      obeTipoCarga.PNNORSCI = Item("EMBARQUE")
      obeTipoCarga.PSCOD_PUERTO = HelpClass.ToStringCvr(Item("COD_PUERTO"))
      obeTipoCarga.PSPUERTO = HelpClass.ToStringCvr(Item("PUERTO_EMBARQUE"))
      obeTipoCarga.PNCOD_PAIS = Item("COD_PAIS")
      obeTipoCarga.PSPAIS = HelpClass.ToStringCvr(Item("PAIS_ORIGEN"))
      obeTipoCarga.PNFLETE = Item("FLETE")
      obeTipoCarga.PNVOLUMEN = Item("VOLUMEN")
      obeTipoCarga.PNPESO = Item("PESO")
      obeTipoCarga.PNCOD_TRANSPORTE = Item("COD_TRANSPORTE")
      obeTipoCarga.PSTRANSPORTE = HelpClass.ToStringCvr(Item("TRANSPORTE"))
      obeTipoCarga.PNCOD_FORWARDER = Item("COD_FORWARDER")
      obeTipoCarga.PSFORWARDER = HelpClass.ToStringCvr(Item("FORWARDER"))
      obeTipoCarga.PSMERCADERIA = HelpClass.ToStringCvr(Item("MERCADERIA"))
      obeTipoCarga.PSTIPO_CARGA = HelpClass.ToStringCvr(Item("TIPO_CARGA"))
      obeTipoCarga.PSFECHA_ORDEN = HelpClass.FechaNum_a_Fecha(Item("FECHA_ORDEN"))

      obeTipoCarga.PSTCMPCL = HelpClass.ToStringCvr(Item("TCMPCL"))
      obeTipoCarga.PSTMTVBJ = HelpClass.ToStringCvr(Item("TMTVBJ"))
      obeTipoCarga.PNCCLNT = Item("CCLNT")
      oLiistTipoCarga.Add(obeTipoCarga)
    Next
    Return oLiistTipoCarga
  End Function

End Class
