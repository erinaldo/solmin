Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class Usuario_Opcion_DAL
    Private objSql As New SqlManager
    Public Sub Registar_UsuarioOpcion(ByVal UsuOpcionBE As Usuario_OpcionBE)
        Dim objParam As New Parameter
        objParam.Add("PSMMCAPL", UsuOpcionBE.MMCAPL)
        objParam.Add("PSMMCMNU", UsuOpcionBE.MMCMNU)
        objParam.Add("PNMMCOPC", UsuOpcionBE.MMCOPC)
        objParam.Add("PSMMCUSR", UsuOpcionBE.MMCUSR)
        objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_OPCION_USUARIO", objParam)
    End Sub
    Public Sub Eliminar_UsuarioOpcion(ByVal UsuOpcionBE As Usuario_OpcionBE)

        Dim objParam As New Parameter
        objParam.Add("PSMMCAPL", UsuOpcionBE.MMCAPL)
        objParam.Add("PSMMCMNU", UsuOpcionBE.MMCMNU)
        objParam.Add("PSMMCOPC", UsuOpcionBE.MMCOPC)
        objParam.Add("PSMMCUSR", UsuOpcionBE.MMCUSR)
        objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_OPCION_USUARIO", objParam)


    End Sub
    Public Function Listar_UsuarioOpcion() As List(Of Usuario_OpcionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Usuario_OpcionBE)
        Dim objParam As New Parameter
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_USUARIO", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Usuario_OpcionBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
                objDatos.MMCOPC = objDataRow("MMCOPC").ToString.Trim
                objDatos.MMCUSR = objDataRow("MMCUSR").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 