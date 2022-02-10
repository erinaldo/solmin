Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class TreeViewNodos_DAL
    Private objSql As New SqlManager
    Public Function Conseguir_Opcion(ByVal Usuario As String) As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCUSR", Usuario)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_USUARIO", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCOPC").ToString().Trim()
                objDatos.Nombre = objDataRow("MMDOPC").ToString().Trim()
                objDatos.IdSecundario = objDataRow("MMCMNU").ToString().Trim()
                objDatos.IdTerciario = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return (objGenericCollection)
    End Function
    Public Function Listar_Opcion() As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCOPC").ToString().Trim()
                objDatos.Nombre = objDataRow("MMDOPC").ToString().Trim()
                objDatos.IdSecundario = objDataRow("MMCMNU").ToString().Trim()
                objDatos.IdTerciario = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
    Public Function Conseguir_Menu(ByVal Usuario As String) As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Dim objParam As New Parameter
        objParam.Add("PSMMCUSR", Usuario)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCMNU").ToString().Trim()
                objDatos.Nombre = objDataRow("MMTMNU").ToString().Trim()
                objDatos.IdSecundario = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return (objGenericCollection)
    End Function
    Public Function Listar_Menu() As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCMNU").ToString().Trim()
                objDatos.Nombre = objDataRow("MMTMNU").ToString().Trim()
                objDatos.IdSecundario = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
    Public Function Conseguir_Aplicacion(ByVal Usuario As String) As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Dim objParam As New Parameter
        objParam.Add("PSMMCUSR", Usuario)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_FILTRAR_APLICACION", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCAPL").ToString().Trim()
                objDatos.Nombre = objDataRow("MMDAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return (objGenericCollection)
    End Function
    Public Function Listar_Aplicacion() As List(Of TreeViewNodosBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TreeViewNodosBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_FILTRAR_APLICACION", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TreeViewNodosBE
                objDatos.IdPrincipal = objDataRow("MMCAPL").ToString().Trim()
                objDatos.Nombre = objDataRow("MMDAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
    Public Function Conseguir_Usuario_Opcion(ByVal UsuarioOpcionBE As String) As List(Of Usuario_OpcionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Usuario_OpcionBE)
        Dim objParam As New Parameter
        objParam.Add("PSMMCUSR", UsuarioOpcionBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_USUARIO", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Usuario_OpcionBE
                objDatos.MMCUSR = objDataRow("MMCUSR").ToString().Trim()
                objDatos.MMCOPC = objDataRow("MMCOPC").ToString().Trim()
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString().Trim()
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return (objGenericCollection)
    End Function
    Public Function Conseguir_Rol_Opcion(ByVal RolOpcionBE As String) As List(Of Rol_OpcionBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Rol_OpcionBE)
        Dim objParam As New Parameter
        objParam.Add("PNNCOROL", RolOpcionBE)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCION_ROL", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Rol_OpcionBE
                objDatos.NCOROL = objDataRow("NCOROL").ToString().Trim()
                objDatos.MMCOPC = objDataRow("MMCOPC").ToString().Trim()
                objDatos.MMCMNU = objDataRow("MMCMNU").ToString().Trim()
                objDatos.MMCAPL = objDataRow("MMCAPL").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return (objGenericCollection)
    End Function
End Class 

