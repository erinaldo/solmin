Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class Usuario_DAL
    Private objSql As New SqlManager
    Public Function Listar_Usuario() As List(Of UsuarioBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of UsuarioBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_FILTRAR_USUARIO", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New UsuarioBE
                objDatos.MMCUSR = objDataRow("MMCUSR").ToString().Trim()
                objDatos.MMNUSR = objDataRow("MMNUSR").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 