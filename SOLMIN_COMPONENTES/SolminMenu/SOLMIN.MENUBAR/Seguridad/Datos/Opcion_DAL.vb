Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Collections.Generic
Imports System.Data
Public Class Opcion_DAL
  Private objSql As New SqlManager
  Public Function Registar_Opcion(ByVal Opcion_BE As OpcionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", Opcion_BE.MMCAPL)
      objParam.Add("PSMMCMNU", Opcion_BE.MMCMNU)
      objParam.Add("PSMMDOPC", Opcion_BE.MMDOPC)
      objParam.Add("PSMMNPVB", Opcion_BE.MMNPVB)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_OPCION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Modificar_Opcion(ByVal Opcion_BE As OpcionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", Opcion_BE.MMCAPL)
      objParam.Add("PSMMCMNU", Opcion_BE.MMCMNU)
      objParam.Add("PNMMCOPC", Opcion_BE.MMCOPC)
      objParam.Add("PSMMDOPC", Opcion_BE.MMDOPC)
      objParam.Add("PSMMNPVB", Opcion_BE.MMNPVB)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_MODIFICAR_OPCION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Eliminar_Opcion(ByVal Opcion_BE As OpcionBE) As Integer
    Try
      Dim objParam As New Parameter
      objParam.Add("PSMMCAPL", Opcion_BE.MMCAPL)
      objParam.Add("PSMMCMNU", Opcion_BE.MMCMNU)
      objParam.Add("PNMMCOPC", Opcion_BE.MMCOPC)
      objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_OPCION", objParam)
      Return 1
    Catch ex As Exception
      Return 0
    End Try
  End Function
  Public Function Listar_Opcion() As List(Of OpcionBE)
    Dim objDataTable As New DataTable
    Dim objGenericCollection As New List(Of OpcionBE)
    Try
      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION", Nothing)
      For Each objDataRow As DataRow In objDataTable.Rows
        Dim objDatos As New OpcionBE
        objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
        objDatos.MMDAPL = objDataRow("MMDAPL").ToString.Trim
        objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
        objDatos.MMTMNU = objDataRow("MMTMNU").ToString.Trim
        objDatos.MMCOPC = objDataRow("MMCOPC").ToString.Trim
        objDatos.MMDOPC = objDataRow("MMDOPC").ToString.Trim
        objDatos.MMNPVB = objDataRow("MMNPVB").ToString.Trim
        objGenericCollection.Add(objDatos)
      Next
    Catch ex As Exception
    End Try
    Return objGenericCollection
  End Function
  Public Function Listar_Opcion(ByVal objOpcion As OpcionBE) As List(Of OpcionBE)
    Dim objDataTable As New DataTable
    Dim objGenericCollection As New List(Of OpcionBE)
    Dim objParam As New Parameter
    Try
      objParam.Add("PSMMCAPL", objOpcion.MMCAPL)
      objParam.Add("PSMMCMNU", objOpcion.MMCMNU)
      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_X_MENU_APLICACION", objParam)
      For Each objDataRow As DataRow In objDataTable.Rows
        Dim objDatos As New OpcionBE
        objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
        objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
        objDatos.MMTMNU = objDataRow("MMTMNU").ToString.Trim
        objDatos.MMCOPC = objDataRow("MMCOPC").ToString.Trim
        objDatos.MMDOPC = objDataRow("MMDOPC").ToString.Trim
        objDatos.MMNPVB = objDataRow("MMNPVB").ToString.Trim
        objGenericCollection.Add(objDatos)
      Next
    Catch ex As Exception
    End Try
    Return objGenericCollection
  End Function
End Class
