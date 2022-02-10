Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class Moneda_DAL

    Public Function fdtListar_Listar_Moneda(ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objSqlManager As New SqlManager
        Dim objParametros As Parameter = New Parameter
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable(" SP_SOLMIN_LISTAR_MONEDA", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_Listar_Moneda >> de la clase << daoMoneda >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento :  SP_SOLMIN_LISTAR_MONEDA >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return dtTemp
    End Function

End Class
