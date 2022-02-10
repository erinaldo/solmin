Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.WayBill

Public Class cControlOperaciones
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Función que registre la información (I/S) del día, con lo cual queda cerrado las operaciones (I/S) para ese día
    ''' </summary>
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal TD_Control As TD_ControlOperacionPK01, _
                                  ByVal strUsuario As String, ByRef strMensajeError As String) As Int64
        Dim intNroOperacion As Int64 = 0
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Control.pCCLNT_CodigoCliente)
            .Add("IN_FTRMOP", TD_Control.pFTRMOP_FechaCierre_Int)
            .Add("IN_STPODP", TD_Control.pSTPODP_TipoAlmacen)
            .Add("IN_CTPOAT", TD_Control.pCTPOAT_TipoOperacion)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_MESERR", "", ParameterDirection.Output)
            .Add("OU_NOPRSP", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_CTRLOPER_RZ0090_INS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = "" & htResultado("OU_MESERR")
            If strMensajeError = "" Then Int64.TryParse(htResultado("OU_NOPRSP"), intNroOperacion)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoControlOperacion >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CTRLOPER_RZ0090_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intNroOperacion
    End Function

    ''' <summary>
    ''' Función que elimina el Control de Operación
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal TD_Control As TD_ControlOperacionPK02, _
                                  ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim blnResultado As Boolean = True
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Control.pCCLNT_CodigoCliente)
            .Add("IN_STPODP", TD_Control.pSTPODP_TipoAlmacen)
            .Add("IN_CTPOAT", TD_Control.pCTPOAT_TipoOperacion)
            .Add("IN_NOPRSP", TD_Control.pNOPRSP_NroOperacion)
            .Add("IN_USUARI", strUsuario)
            .Add("OU_MESERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_CTRLOPER_RZ0090_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = "" & htResultado("OU_MESERR")
            If strMensajeError = "" Then blnResultado = False
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoControlOperacion >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CTRLOPER_RZ0090_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Listado del Resumen de Movimiento para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtListar_ResumenMovimiento_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_CtrlOperacion, _
                                                           ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoAlmacen)
            .Add("IN_CTPOAT", TD_Filtro.pCTPOAT_TipoOperacion)
            .Add("IN_FECMOV", TD_Filtro.pFTRMOP_FechaCierre_Int)
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_CTRLOPER_RZO090_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_ResumenMovimiento_L01 >> de la clase << daoControlOperacion >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_CTRLOPER_RZO090_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function
#End Region
End Class