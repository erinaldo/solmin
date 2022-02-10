Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Collections.Generic
Imports System.Data
Public Class Acceso_Directo_DAL
  Private objSql As New SqlManager
  Public Function Registrar_AccesoDirecto(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCUSR", objEntidad.MMCUSR)
      objParam.Add("PSMMCAPL", objEntidad.MMCAPL)
      objParam.Add("PSMMCMNU", objEntidad.MMCMNU)
      objParam.Add("PNMMCOPC", objEntidad.MMCOPC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_FAVORITO", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Eliminar_AccesoDirecto(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCUSR", objEntidad.MMCUSR)
      objParam.Add("PSMMCAPL", objEntidad.MMCAPL)
      objParam.Add("PSMMCMNU", objEntidad.MMCMNU)
      objParam.Add("PNMMCOPC", objEntidad.MMCOPC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_FAVORITO", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Activar_AccesoDirecto(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCUSR", objEntidad.MMCUSR)
      objParam.Add("PSMMCAPL", objEntidad.MMCAPL)
      objParam.Add("PSMMCMNU", objEntidad.MMCMNU)
      objParam.Add("PNMMCOPC", objEntidad.MMCOPC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_ACTIVAR_FAVORITO", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Listar_AccesoDirecto() As List(Of Acceso_DirectoBE)
    Dim objDataTable As New DataTable
    Dim objGenericCollection As New List(Of Acceso_DirectoBE)
    Try
      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_FAVORITO", Nothing)
      For Each objDataRow As DataRow In objDataTable.Rows
        Dim objDatos As New Acceso_DirectoBE
        objDatos.MMCUSR = objDataRow("MMCUSR").ToString().Trim()
        objDatos.MMCAPL = objDataRow("MMCAPL").ToString().Trim()
        objDatos.MMCMNU = objDataRow("MMCMNU").ToString().Trim()
        objDatos.MMCOPC = objDataRow("MMCOPC").ToString().Trim()
        objDatos.MMDOPC = objDataRow("MMDOPC").ToString().Trim()
        objDatos.MMNPVB = objDataRow("MMNPVB").ToString().Trim()
        objDatos.NJERAC = objDataRow("NJERAC").ToString().Trim()
        objDatos.SESTRG = objDataRow("SESTRG").ToString().Trim()
        objGenericCollection.Add(objDatos)
      Next
    Catch ex As Exception
    End Try
    Return objGenericCollection
  End Function
End Class
