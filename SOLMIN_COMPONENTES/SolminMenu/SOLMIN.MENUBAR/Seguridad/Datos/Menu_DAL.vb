Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class Menu_DAL
    Private objSql As New SqlManager
    Public Function Registrar_Menu(ByVal Menu_BE As MenuBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCAPL", Menu_BE.MMCAPL)
            objParam.Add("PSMMTMNU", Menu_BE.MMTMNU)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_MENU", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Modificar_Menu(ByVal Menu_BE As MenuBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCAPL", Menu_BE.MMCAPL)
            objParam.Add("PSMMCMNU", Menu_BE.MMCMNU)
            objParam.Add("PSMMTMNU", Menu_BE.MMTMNU)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_MODIFICAR_MENU", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Eliminar_Menu(ByVal Menu_BE As MenuBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCAPL", Menu_BE.MMCAPL)
            objParam.Add("PSMMCMNU", Menu_BE.MMCMNU)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_MENU", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Listar_Menu() As List(Of MenuBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of MenuBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New MenuBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
                objDatos.MMTMNU = objDataRow("MMTMNU").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
    Public Function Listar_Menu(ByVal Usuario_BE As String) As List(Of MenuBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of MenuBE)
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCUSR", Usuario_BE)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New MenuBE
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString.Trim
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString.Trim
                objDatos.MMTMNU = objDataRow("MMTMNU").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 