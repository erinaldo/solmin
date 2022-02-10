Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsCliente
    Public Function Obtener_datos_cliente(ByVal PNCCLNT As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PARAM_CCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_OBTENER_DATOS_CLIENTE", lobjParams)
        Return dt
    End Function


    Public Function fdsCodigoClienteDelPortar(ByVal CCLNT As Decimal) As Decimal
        Dim objSqlManager As New SqlManager
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_CCLNT", CCLNT)
        objParametros.Add("IN_VALVAR", "", ParameterDirection.Output)
        Dim blnResultado As Double = 0
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_CODIGO_CLIENTE_DEL_PORTAL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            If Not htResultado("IN_VALVAR").ToString.Trim.Equals("") Then
                blnResultado = htResultado("IN_VALVAR")
            End If
        Catch ex As Exception
            blnResultado = 0
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

End Class
