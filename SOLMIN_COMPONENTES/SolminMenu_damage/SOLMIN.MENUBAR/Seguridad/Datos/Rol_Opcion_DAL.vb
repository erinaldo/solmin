Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class Rol_Opcion_DAL
    Private objSql As New SqlManager
    Public Sub Registar_RolOpcion(ByVal RolOpcionBE As Rol_OpcionBE)
        Dim objParam As New Parameter
        objParam.Add("PNNCOROL", RolOpcionBE.NCOROL)
        objParam.Add("PSMMCAPL", RolOpcionBE.MMCAPL)
        objParam.Add("PSMMCMNU", RolOpcionBE.MMCMNU)
        objParam.Add("PNMMCOPC", RolOpcionBE.MMCOPC)
        objParam.Add("PSCULUSA", RolOpcionBE.CULUSA)
        objParam.Add("PNFULTAC", RolOpcionBE.FULTAC)
        objParam.Add("PNHULTAC", RolOpcionBE.HULTAC)
        objParam.Add("PSNTRMNL", RolOpcionBE.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_OPCION_ROL", objParam)
    End Sub
    Public Sub Eliminar_RolOpcion(ByVal RolOpcionBE As Rol_OpcionBE)

        Dim objParam As New Parameter
        objParam.Add("PNNCOROL", RolOpcionBE.NCOROL)
        objParam.Add("PSMMCAPL", RolOpcionBE.MMCAPL)
        objParam.Add("PSMMCMNU", RolOpcionBE.MMCMNU)
        objParam.Add("PSMMCOPC", RolOpcionBE.MMCOPC)
        objParam.Add("PSCULUSA", RolOpcionBE.CULUSA)
        objParam.Add("PNFULTAC", RolOpcionBE.FULTAC)
        objParam.Add("PNHULTAC", RolOpcionBE.HULTAC)
        objParam.Add("PSNTRMNL", RolOpcionBE.NTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_OPCION_ROL", objParam)


    End Sub
    Public Function Listar_RolOpcion() As List(Of Rol_OpcionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Rol_OpcionBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_ROL", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Rol_OpcionBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
                objDatos.MMCOPC = objDataRow("MMCOPC").ToString.Trim
                objDatos.NCOROL = objDataRow("NCOROL").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 