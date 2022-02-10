Imports Db2Manager.RansaData.iSeries.DataObjects 
Imports System.Collections.Generic
Imports System.Data 
Public Class Rol_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Rol(ByVal objEntidad As RolBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_ROL", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Modificar_Rol(ByVal objEntidad As RolBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOROL", objEntidad.NCOROL)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_MODIFICAR_ROL", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar_Rol(ByVal objEntidad As RolBE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOROL", objEntidad.NCOROL)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SS_ELIMINAR_ROL", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Listar_Rol() As List(Of RolBE)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of RolBE)
        Dim objDat As New RolBE
        objDat.TOBS = "INICIO"
        objDat.NCOROL = "0"
        objGenericCollection.Add(objDat)
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_ROL", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New RolBE
                objDatos.NCOROL = objDataRow("NCOROL").ToString().Trim()
                objDatos.TOBS = objDataRow("TOBS").ToString().Trim()
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class 
