Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports System.Data

Public Class PlantaFacturacion_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Planta_Facturacion_Combo(ByVal strCompania As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLANTAS_FACTURACION", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

    Public Function Listar_Planta_Zona_Facturacion(ByVal strCompania As String, ByVal strDivision As String) As DataTable
        Dim objResultado As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", strCompania)
        objParam.Add("PSCDVSN", strDivision)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLANTAS_ZONA_FACTURACION", objParam)
        Return objResultado
    End Function

End Class
