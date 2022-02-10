Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Moneda

Public Class cMoneda
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Obtener la Moneda - RZZK02
    ''' </summary>
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal strCodigo As String, ByRef strMensajeError As String) As TD_Moneda
        Dim objMoneda As TD_Moneda = New TD_Moneda
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_CMNDA1", strCodigo)
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_MONEDA_RZZK02_OBJ", objParametros)
            If dtTemp.Rows.Count > 0 Then
                objMoneda.pCMNDA1_Codigo = dtTemp.Rows(0).Item("CMNDA1")
                objMoneda.pTMNDA_Detalle = dtTemp.Rows(0).Item("TMNDA")
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoMoneda >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_MONEDA_RZZK02_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return objMoneda
    End Function

    ''' <summary>
    ''' Obtener la Moneda - RZZK02
    ''' </summary>
    Public Shared Function ObtenerPorAbreviatura(ByVal objSqlManager As SqlManager, ByVal strAbreviatura As String, ByRef strMensajeError As String) As TD_Moneda
        Dim objMoneda As TD_Moneda = New TD_Moneda
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_TSGNMN", strAbreviatura)
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_MONEDA_RZZK02_OBJ2", objParametros)
            If dtTemp.Rows.Count > 0 Then
                objMoneda.pCMNDA1_Codigo = dtTemp.Rows(0).Item("CMNDA1")
                objMoneda.pTMNDA_Detalle = dtTemp.Rows(0).Item("TMNDA")
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoMoneda >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_MONEDA_RZZK02_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return objMoneda
    End Function

    ''' <summary>
    ''' Listado información de la Tabla de Ayuda - RZO103
    ''' </summary>
    Public Shared Function fdtListar_Moneda_L01(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_MONEDA_RZZK02_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_Moneda_L01 >> de la clase << daoMoneda >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_MONEDA_RZZK02_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return dtTemp
    End Function
#End Region
End Class