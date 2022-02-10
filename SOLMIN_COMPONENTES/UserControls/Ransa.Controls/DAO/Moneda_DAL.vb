Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.MONEDA


Public Class Moneda_DAL

    Private objSql As New SqlManager

    Public Function Tipo_Cambio(ByVal pobjEntidad As MONEDA.Moneda) As Double
        Try
            Dim objParam As New Parameter

            objParam.Add("PNTIPCAM", pobjEntidad.TIPCAM, ParameterDirection.Output)
            objParam.Add("PNFULTAC", pobjEntidad.FULTAC)
            objParam.Add("PNCMNDA1", pobjEntidad.CMNDA1)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_TIPO_CAMBIO", objParam)
            pobjEntidad.TIPCAM = objSql.ParameterCollection("PNTIPCAM")
            Return pobjEntidad.TIPCAM
        Catch ex As Exception
            Return pobjEntidad.TIPCAM = 0
        End Try
    End Function

    Public Function Listar_Monedas_Combo(ByVal strCompania As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            'Obtiene el resultado
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MONEDA", Nothing)
            
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

End Class
