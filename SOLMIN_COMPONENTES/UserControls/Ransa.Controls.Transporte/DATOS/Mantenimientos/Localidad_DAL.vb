Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data


Public Class Localidad_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Localidades_Combo(ByVal strCompania As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LOCALIDADES", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

    Public Function Listar_Localidades(ByVal strCompania As String) As List(Of mantenimientos.LocalidadRuta)

        Dim oDt As New DataTable
        Dim localidades As New List(Of mantenimientos.LocalidadRuta)
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LOCALIDADES", Nothing)
            For Each objDataRow As DataRow In oDt.Rows
                Dim objEntidad As New mantenimientos.LocalidadRuta
                objEntidad.TCMLCL = objDataRow("TCMLCL").ToString.Trim
                objEntidad.CLCLD = objDataRow("CLCLD").ToString.Trim
                localidades.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return localidades
    End Function

End Class
