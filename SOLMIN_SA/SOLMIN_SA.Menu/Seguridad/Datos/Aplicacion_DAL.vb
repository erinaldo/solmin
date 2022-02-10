Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Collections.Generic
Imports System.Data

Public Class Aplicacion_DAL
    Private objSql As New SqlManager
  Public Function Registrar_Aplicacion(ByVal obj_Entidad As AplicacionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", obj_Entidad.MMCAPL)
      objParam.Add("PSMMDAPL", obj_Entidad.MMDAPL)
      objParam.Add("PSCUSCRT", obj_Entidad.CUSCRT)
      objParam.Add("PNFCHCRT", obj_Entidad.FCHCRT)
      objParam.Add("PNHRACRT", obj_Entidad.HRACRT)
      'objParam.Add("PSNTRMCR", obj_Entidad.NTRMCR)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_APLICACION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Modificar_Aplicacion(ByVal obj_Entidad As AplicacionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", obj_Entidad.MMCAPL)
      objParam.Add("PSMMDAPL", obj_Entidad.MMDAPL)
      objParam.Add("PSCULUSA", obj_Entidad.CULUSA)
      objParam.Add("PNFULTAC", obj_Entidad.FULTAC)
      objParam.Add("PNHULTAC", obj_Entidad.HULTAC)
      'objParam.Add("PSNTRMNL", obj_Entidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_MODIFICAR_APLICACION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Eliminar_Aplicacion(ByVal obj_Entidad As AplicacionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", obj_Entidad.MMCAPL)
      objParam.Add("PSCULUSA", obj_Entidad.CULUSA)
      objParam.Add("PNFULTAC", obj_Entidad.FULTAC)
      objParam.Add("PNHULTAC", obj_Entidad.HULTAC)
      'objParam.Add("PSNTRMNL", obj_Entidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_APLICACION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
    Public Function Listar_Aplicacion() As List(Of AplicacionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AplicacionBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_FILTRAR_APLICACION", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New AplicacionBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString().Trim()
                objDatos.MMDAPL = objDataRow("MMDAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
    Public Function Listar_Aplicacion(ByVal Usuario_BE As String) As List(Of AplicacionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AplicacionBE)
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCUSR", Usuario_BE)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_FILTRAR_APLICACION", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New AplicacionBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString().Trim()
                objDatos.MMDAPL = objDataRow("MMDAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 