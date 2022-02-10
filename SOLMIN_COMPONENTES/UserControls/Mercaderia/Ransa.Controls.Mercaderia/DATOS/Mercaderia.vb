Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Mercaderia

Public Class cMercaderia
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Procedimiento para eliminar una Mercadería
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal Mercaderia As TD_MercaderiaPK, ByVal Usuario As String, _
                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        With Mercaderia
            objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
            objParametros.Add("IN_CMRCLR", .pCMRCLR_Mercaderia)
            objParametros.Add("IN_USUARIO", Usuario)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDS_MERCADERIA_RZOL11_DEL", objParametros)
            Return True
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnEliminar_Mercaderia >> de la clase << daoMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_MERCADERIA_RZOL11_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Listado de Mercaderias en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación - Gestión
    ''' </summary>
    Public Shared Function fdtListar_Mercaderias_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_Mercaderia_L01, _
                                                     ByRef intNroTotalPaginas As Int32, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CFMCLR", TD_Filtro.pCFMCLR_Familia)
            .Add("IN_CGRCLR", TD_Filtro.pCGRCLR_Grupo)
            .Add("IN_CMRCLR", TD_Filtro.pCMRCLR_Mercaderia)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_MERCADERIA_RZOL11_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            strMensajeError = "Error producido en la funcion : << fdtListar_Mercaderias_L01 >> de la clase << daoMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_MERCADERIA_RZOL11_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function
#End Region
End Class