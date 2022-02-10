Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsConsultaOAgencia

  Private objSql As New SqlManager

  Public Function Lista_ConsultaOAgencia(ByVal oConsultaOAgencia As beConsultaOAgencia) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCMPN", oConsultaOAgencia.PSCCMPN)
    lobjParams.Add("PSCDVSN", oConsultaOAgencia.PSCDVSN)
    lobjParams.Add("PSCPLNDV", oConsultaOAgencia.PSCPLNDV)
    lobjParams.Add("PSCCLNT", oConsultaOAgencia.PNCCLNT)
    lobjParams.Add("PSPNNMOS", oConsultaOAgencia.PSPNNMOS)
    lobjParams.Add("PNFINGRESO_MIN", oConsultaOAgencia.PNFINGRESO_MIN)
    lobjParams.Add("PNFINGRESO_MAX", oConsultaOAgencia.PNFINGRESO_MAX)
    lobjParams.Add("PSBL", oConsultaOAgencia.PSBL)

    dt = lobjSql.ExecuteDataTable("SP_SOLSC_ORDEN_SERVICIO_AGENCIAS_PRINCIPAL", lobjParams)
    Return dt
  End Function

  Public Function Lista_ConsultaOAgencia_Checkpoint(ByVal oConsultaOAgencia As beConsultaOAgencia) As DataTable
    Dim newdt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCLNT", oConsultaOAgencia.PNCCLNT)
    lobjParams.Add("PSPNCDTR", oConsultaOAgencia.PSPNCDTR)
    newdt = lobjSql.ExecuteDataTable("SP_SOLSC_ORDEN_SERVICIO_AGENCIAS_CHECKPOINT", lobjParams)
    Return newdt
  End Function
End Class
