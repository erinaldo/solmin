
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class MedioTransporte_DAL

    Private objSql As New SqlManager

    Public Function Lista_Medio_Transporte() As List(Of MedioTransporte)
        Dim objLisMedioTransporte As New List(Of MedioTransporte)
        Dim objMedioTransporte As MedioTransporte
        Dim oDt As DataTable
        Try
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MEDIO_TRANSPORTE", Nothing)
            For Each objData As DataRow In oDt.Rows
                objMedioTransporte = New MedioTransporte
                objMedioTransporte.CTPMDT = objData("CTPMDT")
                objMedioTransporte.TTPMDT = objData("TTPMDT").ToString.Trim
                objMedioTransporte.QPRCHF = objData("QPRCHF")
                objLisMedioTransporte.Add(objMedioTransporte)
            Next
        Catch : End Try
        Return objLisMedioTransporte
    End Function

    Public Function Lista_MedioTrasnporteTabla(ByVal strCompania As String) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MEDIO_TRANSPORTE_TABLA", Nothing)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

End Class
